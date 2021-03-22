using Docnet.Core;
using Docnet.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Quokka.Rollout;
using System;
using Quokka.TCL.Tools;
using System.Diagnostics;

namespace Quokka.TCL.SourceGenerator
{
    class VivdoCommandTextLines
    {
        public int Page;
        public List<string> Lines = new List<string>();
    }


    [TestClass]
    public class VivadoGenerator : BaseGenerator
    {
        [TestMethod]
        public void VivadoCommandRecordTest()
        {
            var log = new VivadoCommandLog();

            var paramTypes = new List<string>()
            {
                "[-optional_flag]",
                "[<optional_name> <arg>]",
                "<required_value>",
                "[<patterns>...]",
                "<required_name> <arg>",
                "[<optional_value>]",
            };

            var lines = new List<string>()
            {
                "test_command",
                "Syntax",
            };

            var record = new VivadoCommandRecord(log, "test_command", lines);
        }

        [TestMethod]
        public void Generate()
        {
            var pdfName = "ug835-vivado-tcl-commands.pdf";
            var path = Path.Combine(RolloutTools.SolutionLocation(), "docs", pdfName);

            using (var docReader = DocLib.Instance.GetDocReader(path, new PageDimensions()))
            {
                // find list of commands
                var commandsPage = docReader.GetPageReader(page(20));
                var categories =
                    between(commandsPage.GetText(), "Tcl Command Categories", "Tcl Commands Listed by Category")
                    .SelectMany(l => l.Split(" "))
                    .ToList();

                var skipLines = new HashSet<string>()
                {
                    "Chapter 2",
                    "UG835",
                    "Tcl Command Reference Guide"
                };

                var commandLines =
                    Enumerable.Range(20, 11)
                    .SelectMany(p => docReader.GetPageReader(page(p)).GetText().Split('\n').Select(l => l.Trim()))
                    .Where(l => !skipLines.Any(s => l.StartsWith(s)))
                    .SkipWhile(l => !l.StartsWith("Tcl Commands Listed by Category")).Skip(1)
                    .SelectMany(l => l.Split(" ").Select(l => l.Trim()))
                    .ToList();

                var generatedPath = Path.Combine(RolloutTools.SolutionLocation(), "Quokka.TCL", "Vivado", "generated");
                if (!Directory.Exists(generatedPath))
                    Directory.CreateDirectory(generatedPath);


                Dictionary<string, List<string>> mapCategoryToCommands = new Dictionary<string, List<string>>();
                for (int i = 0; i < categories.Count; i++)
                {
                    var category = categories[i];
                    var next = categories.Skip(i + 1).FirstOrDefault() ?? "";
                    var commands = between(commandLines, $"{category}:", $"{next}:");
                    mapCategoryToCommands[category] = commands;
                }

                var allCommandsSet = mapCategoryToCommands.SelectMany(p => p.Value).ToHashSet();
                var commandsData = allCommandsSet.ToDictionary(p => p, p => new VivdoCommandTextLines());

                // extract text for all commands
                var ignoreTextLines = new HashSet<string>()
                {
                    "Chapter 3",
                    "Tcl Commands Listed Alphabetically",
                    "Chapter 3 Tcl Commands Listed Alphabetically",
                    "This chapter contains all SDC and Tcl commands, arranged alphabetically.",
                    "UG835 (v2019.2) October 30, 2019 www.xilinx.com",
                    "Chapter 3: Tcl Commands Listed Alphabetically",
                };

                var breaks = new HashSet<int>() { };

                string currentCommand = null;
                for (var pageNumber = 31; pageNumber <= 1869; pageNumber++)
                {
                    if (breaks.Contains(pageNumber))
                        Debugger.Break();

                    var ignorePageTextLines = ignoreTextLines.ToHashSet();
                    ignorePageTextLines.Add($"Tcl Command Reference Guide {pageNumber} Send Feedback");

                    var reader = docReader.GetPageReader(page(pageNumber));
                    var text = reader.GetText();
                    var lines = text
                        .Split('\n')
                        .Select(l => l.Trim())
                        .Where(l => !ignorePageTextLines.Contains(l))
                        .Select(l => l.Replace((char)8209, '-'))
                        .ToList();

                    // empty page
                    if (!lines.Any())
                        continue;

                    if (allCommandsSet.Contains(lines[0]))
                    {
                        currentCommand = lines[0];
                        commandsData[currentCommand].Page = pageNumber;
                    }

                    if (!commandsData.ContainsKey(currentCommand))
                    {
                        throw new KeyNotFoundException($"Not a valid command name: {currentCommand}");

                    }

                    commandsData[currentCommand].Lines.AddRange(lines);
                }

                var missingCommandsText = commandsData.Where(p => !p.Value.Lines.Any()).Select(p => p.Key).ToList();
                if (missingCommandsText.Any())
                {
                    throw new Exception($"No description found for commands: {string.Join(", ", missingCommandsText)}");
                }

                var log = new VivadoCommandLog();

                foreach (var pair in mapCategoryToCommands)
                {
                    var (category, commands) = pair;

                    var builder = new IndentedStringBuilder();
                    Header(builder);
                    builder.AppendLine($"using Quokka.TCL.Tools;");
                    builder.AppendLine("namespace Quokka.TCL.Vivado");
                    using (builder.CodeBlock())
                    {
                        builder.AppendLine($"public partial class {category}Commands");
                        using (builder.CodeBlock())
                        {
                            builder.AppendLine($"private readonly QuokkaTCL _tcl;");
                            builder.AppendLine($"public {category}Commands(QuokkaTCL tcl)");
                            using (builder.CodeBlock())
                            {
                                builder.AppendLine($"_tcl = tcl;");
                            }

                            foreach (var command in commands)
                            {
                                var commandData = commandsData[command];
                                var record = new VivadoCommandRecord(log, command, commandData.Lines);

                                builder.AppendLine($"/// <summary>");
                                builder.AppendDocumentationLinesIfAny(record.ShortDescription);
                                builder.AppendDocumentationLinesIfAny(record.Description);
                                builder.AppendDocumentationLinesIfAny(record.Examples);
                                builder.AppendDocumentationLines($"See {pdfName}, page {commandData.Page}");
                                builder.AppendLine($"/// </summary>");

                                var orderedArguments = record.Parameters.Where(c => c is VivadoCommandRequiredParameter).Concat(record.Parameters.Where(c => c is VivadoCommandOptionalParameter)).ToList();
                                
                                foreach (var arg in orderedArguments)
                                {
                                    builder.AppendLine($"/// <param name=\"{arg.CSName}\">");
                                    switch (arg)
                                    {
                                        case VivadoCommandOptionalParameter _:
                                            builder.AppendDocumentationLines("Optional");
                                            break;
                                        case VivadoCommandRequiredParameter _:
                                            builder.AppendDocumentationLines("Required");
                                            break;
                                    }

                                    builder.AppendDocumentationLines(arg.Description);
                                    builder.AppendLine($"/// </param>");
                                }

                                if (record.Returns.Any())
                                {
                                    builder.AppendDocumentationSection("returns", record.Returns);
                                }

                                var args = orderedArguments.Select(a =>
                                {
                                    switch (a)
                                    {
                                        case VivadoCommandOptionalFlagParameter _:
                                            return $"bool? {a.CSName} = null";
                                        case VivadoCommandOptionalParameter _:
                                            return $"string {a.CSName} = null";
                                        case VivadoCommandRequiredParameter _:
                                            return $"string {a.CSName}";
                                        default:
                                            throw new Exception($"Unsupported parameter type: {a.GetType()}");
                                    }
                                });

                                builder.AppendLine($"public void {command}({string.Join(", ", args)})");
                                using (builder.CodeBlock())
                                {
                                    builder.AppendLine($"var command = new SimpleTCLCommand(\"{command}\");");

                                    foreach (var arg in record.Parameters)
                                    {
                                        switch (arg)
                                        {
                                            case VivadoCommandOptionalFlagParameter _:
                                                builder.AppendLine($"command.Flag(\"{arg.Name}\", {arg.CSName});");
                                                break;
                                            case VivadoCommandOptionalParameter _:
                                                builder.AppendLine($"command.OptionalString(\"{arg.Name}\", {arg.CSName});");
                                                break;
                                            case VivadoCommandRequiredParameter _:
                                                builder.AppendLine($"command.RequiredString(\"{arg.Name}\", {arg.CSName});");
                                                break;
                                            default:
                                                throw new Exception($"Unsupported parameter type: {arg.GetType()}");
                                        }
                                    }

                                    builder.AppendLine($"_tcl.Add(command);");
                                }
                            }
                        }
                    }

                    var filePath = Path.Combine(generatedPath, $"{category}.cs");
                    File.WriteAllText(filePath, builder.ToString());
                }

                var vivadoTCL = new IndentedStringBuilder();
                Header(vivadoTCL);
                vivadoTCL.AppendLine($"using Quokka.TCL.Tools;");
                vivadoTCL.AppendLine("namespace Quokka.TCL.Vivado");
                using (vivadoTCL.CodeBlock())
                {
                    vivadoTCL.AppendLine($"public partial class VivadoTCL : QuokkaTCL");
                    using (vivadoTCL.CodeBlock())
                    {
                        foreach (var category in categories)
                        {
                            vivadoTCL.AppendLine($"public {category}Commands {category} => new {category}Commands(this);");
                        }
/*
                        vivadoTCL.AppendLine($"public VivadoTCL()");
                        using (vivadoTCL.CodeBlock())
                        {
                            foreach (var category in categories)
                            {
                                vivadoTCL.AppendLine($"{category} = new {category}Commands(this);");
                            }
                        }
*/
                    }
                }
                var vivadoTCLFilePath = Path.Combine(generatedPath, $"VivadoTCL.cs");
                File.WriteAllText(vivadoTCLFilePath, vivadoTCL.ToString());

                var logPath = Path.Combine(generatedPath, "log.md");
                File.WriteAllText(logPath, log.ToString());
            }
        }
    }
}
