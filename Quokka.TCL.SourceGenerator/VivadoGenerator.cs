using Docnet.Core;
using Docnet.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Quokka.Rollout;
using System;
using Quokka.TCL.Tools;

namespace Quokka.TCL.SourceGenerator
{
    class VivadoCommandRecordSection
    {
        public string SectionName;
        public Action<List<string>> Handler;

        public VivadoCommandRecordSection(string sectionName, Action<List<string>> handler)
        {
            SectionName = sectionName;
            Handler = handler;
        }
    }

    class VivadoCommandRecord
    {
        public List<string> ShortDescription = new List<string>();
        public List<string> Description = new List<string>();

        public VivadoCommandRecord(string name, List<string> lines)
        {
            var orderedSections = new VivadoCommandRecordSection[]
            {
                new VivadoCommandRecordSection(name, (content) => { ShortDescription = content; }),
                new VivadoCommandRecordSection("Syntax", (content) => { }),
                new VivadoCommandRecordSection("Returns", (content) => { }),
                new VivadoCommandRecordSection("Usage", (content) => { }),
                new VivadoCommandRecordSection("Categories", (content) => { }),
                new VivadoCommandRecordSection("Description", (content) => { Description = content; }),
                new VivadoCommandRecordSection("Arguments", (content) => { }),
                new VivadoCommandRecordSection("Examples", (content) => { }),
                new VivadoCommandRecordSection("See Also", (content) => { }),
            };

            // make sure that sections are in expected order
            var indexes = orderedSections
                .Select(s => new { name = s.SectionName, index = lines.IndexOf(s.SectionName) })
                .Where(s => s.index != -1)
                .ToList();

            for (var idx = 0; idx < indexes.Count - 1; idx++)
            {
                var thisSection = indexes[idx];
                var nextSection = indexes[idx + 1];
                if (thisSection.index > nextSection.index)
                {
                    throw new Exception($"Command {name}: Section {thisSection.name} is expected to be before {nextSection.name}");
                }
            }

            var existingSections = orderedSections.Where(s => indexes.Any(i => i.name == s.SectionName)).ToList();
            for (var idx = 0; idx < existingSections.Count; idx++)
            {
                var thisSection = existingSections[idx];
                var nextSection = existingSections.Skip(idx + 1).FirstOrDefault();

                var text = BaseGenerator.between(lines, thisSection.SectionName, nextSection?.SectionName);
                thisSection.Handler(text);
            }
        }
    }

    [TestClass]
    public class VivadoGenerator : BaseGenerator
    {
        [TestMethod]
        public void Generate()
        {
            var path = Path.Combine(RolloutTools.SolutionLocation(), "docs", "ug835-vivado-tcl-commands.pdf");

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
                var commandsData = allCommandsSet.ToDictionary(p => p, p => new List<string>());

                // extract text for all commands
                var ingoreCommandPageLines = new HashSet<string>()
                {
                    "Chapter 3",
                    "Tcl Commands Listed Alphabetically",
                    "This chapter contains all SDC and Tcl commands, arranged alphabetically.",
                    "UG835 (v2019.2) October 30, 2019 www.xilinx.com",
                    "Tcl Command Reference Guide 31 Send Feedback"
                };

                string currentCommand = null;
                for (var pageNumber = 31; pageNumber <= 1869; pageNumber++)
                {
                    var reader = docReader.GetPageReader(page(pageNumber));
                    var text = reader.GetText();
                    var lines = text.Split('\n').Select(l => l.Trim()).Where(l => !ingoreCommandPageLines.Contains(l)).ToList();
                    if (allCommandsSet.Contains(lines[0]))
                    {
                        currentCommand = lines[0];
                    }

                    if (!commandsData.ContainsKey(currentCommand))
                    {
                        throw new KeyNotFoundException($"Not a valid command name: {currentCommand}");

                    }

                    commandsData[currentCommand].AddRange(lines);
                }

                var missingCommandsText = commandsData.Where(p => !p.Value.Any()).Select(p => p.Key).ToList();
                if (missingCommandsText.Any())
                {
                    throw new Exception($"No description found for commands: {string.Join(", ", missingCommandsText)}");
                }

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
                                var record = new VivadoCommandRecord(command, commandsData[command]);

                                builder.AppendLine($"/// <summary>");
                                builder.AppendDocumentationLines(record.ShortDescription);
                                builder.AppendLine($"/// </summary>");
                                //builder.AppendLine($"/// <param name=\"name\"></param>");
                                builder.AppendLine($"public void {command}()");
                                using (builder.CodeBlock())
                                {
                                    builder.AppendLine($"var command = new SimpleTCLCommand(\"{command}\");");
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
                vivadoTCL.AppendLine("namespace Quokka.TCL.Vivado");
                using (vivadoTCL.CodeBlock())
                {
                    vivadoTCL.AppendLine($"public partial class VivadoTCL : QuokkaTCL");
                    using (vivadoTCL.CodeBlock())
                    {
                        foreach (var category in categories)
                        {
                            vivadoTCL.AppendLine($"public {category}Commands {category};");
                        }

                        vivadoTCL.AppendLine($"public VivadoTCL()");
                        using (vivadoTCL.CodeBlock())
                        {
                            foreach (var category in categories)
                            {
                                vivadoTCL.AppendLine($"{category} = new {category}Commands(this);");
                            }
                        }
                    }
                }
                var vivadoTCLFilePath = Path.Combine(generatedPath, $"VivadoTCL.cs");
                File.WriteAllText(vivadoTCLFilePath, vivadoTCL.ToString());
            }
        }
    }
}
