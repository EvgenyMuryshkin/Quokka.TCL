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
using Docnet.Core.Readers;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace System
{
    public static class StringExtensions
    {
        public static string Escaped(this string s)
        {
            return s.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;");
        }

        public static List<string> Escaped(this List<string> s)
        {
            return s.Select(i => i.Escaped()).ToList();
        }
    }
}

namespace Quokka.TCL.SourceGenerator
{

    class VivdoCommandTextLines
    {
        public int Page;
        public List<string> Lines = new List<string>();
    }

    enum CommandGenerationMode
    {
        Declaration,
        Call
    }

    class VivadoGeneratorContext
    {
        public IDocReader docReader;
        public List<string> categories = new List<string>();
        public Dictionary<string, List<string>> mapCategoryToCommands = new Dictionary<string, List<string>>();
        public HashSet<string> commandsSet = new HashSet<string>();
        public Dictionary<string, VivdoCommandTextLines> commandsData = new Dictionary<string, VivdoCommandTextLines>();
        public VivadoCommandLog Log = new VivadoCommandLog();
        public VivadoTCLFixes Fixes = new VivadoTCLFixes();

        public string generatedPath { get; set; }
    }

    [TestClass]
    public class VivadoGenerator : BaseGenerator
    {
        string pdfName = "ug835-vivado-tcl-commands.pdf";
        string fixesName = "ug835-vivado-tcl-commands.json";

        //[TestMethod]
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

            var fixes = new VivadoTCLFixes();

            foreach (var p in paramTypes)
            {
                var lines = new List<string>()
                {
                    "test_command",
                    "Syntax",
                    $"test_command {p}"
                };

                var record = new VivadoCommandRecord(log, fixes, "test_command", new VivdoCommandTextLines() { Lines = lines });
            }
        }

        void GenerateCommandDocumentation(
            VivadoCommandRecord record,
            IndentedStringBuilder builder)
        {
            builder.AppendLine($"/// <summary>");
            builder.AppendDocumentationLinesIfAny(record.ShortDescription.Escaped());
            builder.AppendDocumentationSeparator();
            builder.AppendLine($"/// TCL Syntax: {record.Syntax.Escaped()}");
            builder.AppendDocumentationSeparator();
            builder.AppendDocumentationLinesIfAny(record.Description.Escaped());
            builder.AppendDocumentationLinesIfAny(record.Examples.Escaped());
            builder.AppendDocumentationLines($"See {pdfName}, page {record.CommandData.Page}");
            builder.AppendLine($"/// </summary>");

            var orderedParameters = record.orderedParameters;

            foreach (var arg in orderedParameters)
            {
                var descriptionLines = new List<string>();

                switch (arg.Usage)
                {
                    case VivadoCommandParameterUsage.Optional:
                        descriptionLines.Add("(Optional)");
                        break;
                    case VivadoCommandParameterUsage.Required:
                        descriptionLines.Add("(Required)");
                        break;
                }

                descriptionLines.AddRange(arg.Description);

                // make single description line if it is short
                if (descriptionLines.Sum(l => l.Length) < 80)
                {
                    descriptionLines = new List<string>() { string.Join(" ", descriptionLines) };
                }

                switch (descriptionLines.Count)
                {
                    case 1:
                        builder.AppendLine($"/// <param name=\"{arg.ParamName}\">{descriptionLines[0].Escaped()}</param>");
                        break;
                    default:
                        builder.AppendLine($"/// <param name=\"{arg.ParamName}\">");
                        builder.AppendDocumentationLines(descriptionLines.Escaped());
                        builder.AppendLine($"/// </param>");
                        break;
                }
            }

            if (record.Returns.Any())
            {
                builder.AppendDocumentationSection("returns", record.Returns.Escaped());
            }
        }

        IEnumerable<string> MethodArguments(List<VivadoCommandParameter> parameters)
        {
            return parameters.Select(a =>
            {
                var nativeType = a.ElementType.Name;

                switch (a.Usage)
                {
                    case VivadoCommandParameterUsage.Optional:
                        if (a.ElementType != typeof(string))
                        nativeType += "?";
                        break;
                }


                switch (a.Type)
                {
                    case VivadoCommandParameterType.Flag:
                        return $"bool? {a.CSName} = null";
                    case VivadoCommandParameterType.Object:
                        switch (a.Usage)
                        {
                            case VivadoCommandParameterUsage.Optional:
                                if (a.IsArray)
                                    return $"TCLObjectList {a.CSName} = null";

                                return $"TCLObject {a.CSName} = null";
                            case VivadoCommandParameterUsage.Required:
                                if (a.IsArray)
                                    return $"TCLObjectList {a.CSName}";

                                return $"TCLObject {a.CSName}";
                            default:
                                throw new Exception($"Unsupported parameter usage: {a.Usage}");
                        }
                    case VivadoCommandParameterType.String:
                        switch (a.Usage)
                        {
                            case VivadoCommandParameterUsage.Optional:
                                if (a.EnumName != null)
                                    return $"{a.EnumName}? {a.CSName} = null";

                                if (a.IsArray)
                                    return $"TCLParameterList {a.CSName} = null";
                                
                                return $"{nativeType} {a.CSName} = null";
                            case VivadoCommandParameterUsage.Required:
                                if (a.EnumName != null)
                                    return $"{a.EnumName} {a.CSName}";

                                if (a.IsArray)
                                    return $"TCLParameterList {a.CSName}";
                                
                                return $"{nativeType} {a.CSName}";
                            default:
                                throw new Exception($"Unsupported parameter usage: {a.Usage}");
                        }
                    case VivadoCommandParameterType.Enum:
                        switch (a.Usage)
                        {
                            case VivadoCommandParameterUsage.Optional:
                                return $"{a.EnumName}? {a.CSName} = null";
                            case VivadoCommandParameterUsage.Required:
                                return $"{a.EnumName} {a.CSName}";
                            default:
                                throw new Exception($"Unsupported parameter usage: {a.Usage}");
                        }
                    default:
                        throw new Exception($"Unsupported parameter type: {a.Type}");
                }
            });
        }

        void GenerateCommandDeclaration(
            VivadoCommandRecord record,
            IndentedStringBuilder builder)
        {
            GenerateCommandDocumentation(record, builder);

            var orderedParameters = record.orderedParameters;
            var args = MethodArguments(orderedParameters);

            builder.AppendLine($"public virtual SimpleTCLCommand {record.Name}({string.Join(", ", args)})");
            using (builder.CodeBlock())
            {
                builder.AppendLine($"// TCL Syntax: {record.Syntax}");
                builder.AppendLine($"return");

                using (builder.Indent())
                {
                    builder.AppendLine($"new SimpleTCLCommand(\"{record.Name}\")");
                    using (builder.Indent())
                    {
                        foreach (var arg in record.Parameters)
                        {
                            var argMethodParts = new List<string>();
                            if (arg.Usage == VivadoCommandParameterUsage.Optional)
                                argMethodParts.Add("Optional");
                            else
                                argMethodParts.Add("Required");

                            if (arg.IsNamed)
                                argMethodParts.Add("Named");

                            //if (arg.EnumName != null)
                            //    argMethodParts.Add("Enum");
                            if (arg.Type == VivadoCommandParameterType.Object)
                                argMethodParts.Add("Object");
                            else if (arg.Type == VivadoCommandParameterType.Flag)
                                argMethodParts.Add("Flag");
                            else if (arg.Type == VivadoCommandParameterType.Enum)
                                argMethodParts.Add("Enum");
                            else
                                argMethodParts.Add(arg.ElementType.Name);

                            if (arg.IsArray)
                                argMethodParts.Add("List");

                            var methodName = string.Join("", argMethodParts);

                            var fileArgumentNames = new HashSet<string>()
                            {
                                "file_name",
                                "files",
                                "dir",
                                "path"
                            };

                            var argValue = arg.CSName;
                            if (fileArgumentNames.Contains(arg.Name))
                            {
                                argValue = $"FileName({arg.CSName})";
                            }

                            builder.AppendLine($".{methodName}(\"{arg.Name}\", {argValue})");
                        }
                    }
                }

                builder.AppendLine($";");
            }
        }

        void GenerateCommandCall(
            VivadoCommandRecord record, 
            IndentedStringBuilder builder,
            string returnType,
            string target)
        {
            GenerateCommandDocumentation(record, builder);

            var orderedParameters = record.orderedParameters;
            var args = MethodArguments(orderedParameters);

            var argsForward = orderedParameters.Select(a => a.CSName);
            builder.AppendLine($"public {returnType} {record.Name}({string.Join(", ", args)})");

            using (builder.CodeBlock())
            {
                builder.AppendLine($"// TCL Syntax: {record.Syntax}");
                builder.AppendLine($"{target}.Entry(_builder.{record.Name}({string.Join(", ", argsForward)}));");
                builder.AppendLine($"return {target};");
            }
        }

        void ReadCategoriesAndCommandsSet(VivadoGeneratorContext generatorContext)
        {
            // find list of commands
            var commandsPage = generatorContext.docReader.GetPageReader(page(21));
            var categories = generatorContext.categories =
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
                Enumerable.Range(21, 12)
                .SelectMany(p => generatorContext.docReader.GetPageReader(page(p)).GetText().Split('\n').Select(l => l.Trim()))
                .Where(l => !skipLines.Any(s => l.StartsWith(s)))
                .SkipWhile(l => !l.StartsWith("Tcl Commands Listed by Category")).Skip(1)
                .SelectMany(l => l.Split(" ").Select(l => l.Trim()))
                .ToList();

            for (int i = 0; i < categories.Count; i++)
            {
                var category = categories[i];
                var next = categories.Skip(i + 1).FirstOrDefault() ?? "";
                var commands = between(commandLines, $"{category}:", $"{next}:");
                generatorContext.mapCategoryToCommands[category] = commands;
            }

            var commandsSet = generatorContext.commandsSet = generatorContext.mapCategoryToCommands.SelectMany(p => p.Value).ToHashSet();
            generatorContext.commandsData = commandsSet.ToDictionary(p => p, p => new VivdoCommandTextLines());
        }

        void ReadCommandLines(VivadoGeneratorContext generatorContext)
        {
            var commandsData = generatorContext.commandsData;

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
            for (var pageNumber = 33; pageNumber <= 1907; pageNumber++)
            {
                if (breaks.Contains(pageNumber))
                    Debugger.Break();

                var ignorePageTextLines = ignoreTextLines.ToHashSet();
                ignorePageTextLines.Add($"Tcl Command Reference Guide {pageNumber} Send Feedback");

                var reader = generatorContext.docReader.GetPageReader(page(pageNumber));
                var text = reader.GetText();
                var lines = text
                    .Split('\n')
                    .Select(l => l.Trim())
                    .Where(l => !ignorePageTextLines.Contains(l))
                    // bunch of hacks and fixes
                    .Select(l => l.Replace((char)8209, '-'))
                    .Select(l => l.Replace((char)65534, '-'))
                    .SelectMany(l =>
                    {
                        if (l.StartsWith("-or-"))
                        {
                            return new[] { "-or-", l.Substring(4) };
                        }
                        else
                        {
                            return new[] { l };
                        }
                    })
                    .ToList();

                // empty page
                if (!lines.Any())
                    continue;

                if (generatorContext.commandsSet.Contains(lines[0]))
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
        }

        void GenerateVivadoTCLBuilder(VivadoGeneratorContext generatorContext)
        {
            var generatedPath = generatorContext.generatedPath;
            var commandsData = generatorContext.commandsData;

            var commandsBuilder = new IndentedStringBuilder();
            using (Header(commandsBuilder))
            {
                commandsBuilder.AppendLine($"using Quokka.TCL.Tools;");
                commandsBuilder.AppendLine($"using System.Collections.Generic;");
                commandsBuilder.AppendLine("namespace Quokka.TCL.Vivado");
                using (commandsBuilder.CodeBlock())
                {
                    foreach (var command in commandsData.Keys.OrderBy(k => k))
                    {
                        var commandData = commandsData[command];
                        var record = new VivadoCommandRecord(generatorContext.Log, generatorContext.Fixes, command, commandData);
                        foreach (var p in record.Parameters.Where(t => t.EnumValues.Any()))
                        {
                            commandsBuilder.AppendLine($"public enum {record.Name}_{p.Name}");
                            using (commandsBuilder.CodeBlock())
                            {
                                foreach (var value in p.EnumValues)
                                {
                                    if (StaticData.keywords.Contains(value))
                                    {
                                        commandsBuilder.AppendLine($"[TCLWrite(\"{value}\")]");
                                        commandsBuilder.AppendLine($"{value.ToUpper()},");
                                        continue;
                                    }


                                    if (value.Contains(" ") || value.Contains("-"))
                                    {
                                        commandsBuilder.AppendLine($"[TCLWrite(\"{value}\")]");
                                        var langValue = Regex.Replace(value, @"[ \-]", "_");
                                        commandsBuilder.AppendLine($"{langValue},");
                                        continue;
                                    }

                                    if (value == "0")
                                    {
                                        commandsBuilder.AppendLine($"[TCLWrite(\"0\")]");
                                        commandsBuilder.AppendLine($"ZERO,");
                                        continue;
                                    }

                                    if (value == "1")
                                    {
                                        commandsBuilder.AppendLine($"[TCLWrite(\"1\")]");
                                        commandsBuilder.AppendLine($"ONE,");
                                        continue;
                                    }

                                    commandsBuilder.AppendLine($"{value},");
                                }
                            }
                        }
                    }

                    commandsBuilder.AppendLine($"public partial class VivadoTCLBuilder");
                    using (commandsBuilder.CodeBlock())
                    {
                        foreach (var command in commandsData.Keys.OrderBy(k => k))
                        {
                            var commandData = commandsData[command];
                            var record = new VivadoCommandRecord(generatorContext.Log, generatorContext.Fixes, command, commandData);

                            GenerateCommandDeclaration(record, commandsBuilder);
                        }
                    }
                }
            }

            var commandsBuilderPath = Path.Combine(generatedPath, $"VivadoTCLBuilder.cs");
            File.WriteAllText(commandsBuilderPath, commandsBuilder.ToString());
        }

        void GenerateVivadoTCLCategoriesBuilder(VivadoGeneratorContext generatorContext)
        {
            var generatedPath = generatorContext.generatedPath;
            var commandsData = generatorContext.commandsData;

            foreach (var pair in generatorContext.mapCategoryToCommands)
            {
                var (category, commands) = pair;

                var builder = new IndentedStringBuilder();
                using (Header(builder))
                {
                    builder.AppendLine($"using Quokka.TCL.Tools;");
                    builder.AppendLine($"using System.Collections.Generic;");
                    builder.AppendLine("namespace Quokka.TCL.Vivado");
                    using (builder.CodeBlock())
                    {
                        builder.AppendLine($"public partial class {category}Commands<TTCL> where TTCL : TCLFile");
                        using (builder.CodeBlock())
                        {
                            builder.AppendLine($"private readonly TTCL _tcl;");
                            builder.AppendLine($"private readonly VivadoTCLBuilder _builder;");
                            builder.AppendLine($"public {category}Commands(TTCL tcl, VivadoTCLBuilder builder)");
                            using (builder.CodeBlock())
                            {
                                builder.AppendLine($"_tcl = tcl;");
                                builder.AppendLine($"_builder = builder;");
                            }

                            foreach (var command in commands.OrderBy(c => c))
                            {
                                var commandData = commandsData[command];
                                var record = new VivadoCommandRecord(generatorContext.Log, generatorContext.Fixes, command, commandData);

                                GenerateCommandCall(record, builder, "TTCL", "_tcl");
                            }
                        }
                    }
                }

                var filePath = Path.Combine(generatedPath, $"{category}.cs");
                File.WriteAllText(filePath, builder.ToString());
            }
        }

        void GenerateVivadoFlatTCL(VivadoGeneratorContext generatorContext)
        {
            var generatedPath = generatorContext.generatedPath;

            var vivadoTCL = new IndentedStringBuilder();
            using (Header(vivadoTCL))
            {
                vivadoTCL.AppendLine($"using Quokka.TCL.Tools;");
                vivadoTCL.AppendLine($"using System.Collections.Generic;");
                vivadoTCL.AppendLine("namespace Quokka.TCL.Vivado");
                using (vivadoTCL.CodeBlock())
                {
                    vivadoTCL.AppendLine($"public partial class VivadoTCL : FluentVivadoTCLFile<VivadoTCL>");
                    using (vivadoTCL.CodeBlock())
                    {
                        vivadoTCL.AppendLine($"public VivadoTCL(VivadoTCLBuilder builder = null) : base(builder)");
                        using (vivadoTCL.CodeBlock())
                        {
                        }

                        foreach (var command in generatorContext.commandsSet.OrderBy(c => c))
                        {
                            var commandData = generatorContext.commandsData[command];
                            var record = new VivadoCommandRecord(generatorContext.Log, generatorContext.Fixes, command, commandData);

                            GenerateCommandCall(record, vivadoTCL, "VivadoTCL", "this");
                        }
                    }
                }
            }

            var vivadoTCLFilePath = Path.Combine(generatedPath, $"VivadoTCL.cs");
            File.WriteAllText(vivadoTCLFilePath, vivadoTCL.ToString());
        }

        void GenerateVivadoCategorizedTCL(VivadoGeneratorContext generatorContext)
        {
            var generatedPath = generatorContext.generatedPath;

            var vivadoTCL = new IndentedStringBuilder();
            using (Header(vivadoTCL))
            {
                vivadoTCL.AppendLine($"using Quokka.TCL.Tools;");
                vivadoTCL.AppendLine("namespace Quokka.TCL.Vivado");
                using (vivadoTCL.CodeBlock())
                {
                    vivadoTCL.AppendLine($"public partial class VivadoCategorizedTCL : FluentVivadoTCLFile<VivadoCategorizedTCL>");
                    using (vivadoTCL.CodeBlock())
                    {
                        vivadoTCL.AppendLine($"public VivadoCategorizedTCL(VivadoTCLBuilder builder = null) : base(builder)");
                        using (vivadoTCL.CodeBlock())
                        {
                        }

                        foreach (var category in generatorContext.categories)
                        {
                            vivadoTCL.AppendLine($"public {category}Commands<VivadoCategorizedTCL> {category} => new {category}Commands<VivadoCategorizedTCL>(this, _builder);");
                        }
                    }
                }
            }

            var vivadoTCLFilePath = Path.Combine(generatedPath, $"VivadoCategorizedTCL.cs");
            File.WriteAllText(vivadoTCLFilePath, vivadoTCL.ToString());
        }
        
        [TestMethod]
        public void Generate()
        {
            var path = Path.Combine(RolloutTools.SolutionLocation(), "docs", pdfName);
            var fixes = Path.Combine(RolloutTools.SolutionLocation(), "docs", fixesName);

            var generatedPath = Path.Combine(RolloutTools.SolutionLocation(), "Quokka.TCL", "Vivado", "generated");
            if (!Directory.Exists(generatedPath))
                Directory.CreateDirectory(generatedPath);

            using (var docReader = DocLib.Instance.GetDocReader(path, new PageDimensions()))
            {
                var generatorContext = new VivadoGeneratorContext()
                {
                    docReader = docReader,
                    generatedPath = generatedPath,
                    Fixes = JsonConvert.DeserializeObject<VivadoTCLFixes>(File.ReadAllText(fixes))
                };

                ReadCategoriesAndCommandsSet(generatorContext);
                ReadCommandLines(generatorContext);
                GenerateVivadoTCLBuilder(generatorContext);
                GenerateVivadoTCLCategoriesBuilder(generatorContext);
                GenerateVivadoFlatTCL(generatorContext);
                GenerateVivadoCategorizedTCL(generatorContext);

                var logPath = Path.Combine(generatedPath, "log.md");
                File.WriteAllText(logPath, generatorContext.Log.ToString());
            }
        }
    }
}
