using Docnet.Core;
using Docnet.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Quokka.Rollout;

namespace Quokka.TCL.SourceGenerator
{
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

                for (int i = 0; i < categories.Count; i++)
                {
                    var category = categories[i];
                    var next = categories.Skip(i + 1).FirstOrDefault() ?? "";
                    var commands = between(commandLines, $"{category}:", $"{next}:");

                    var builder = new IndentedStringBuilder();
                    builder.AppendLine($"using System;");
                    builder.AppendLine("namespace Quokka.TCL.Vivado");
                    using (builder.Block())
                    {
                        builder.AppendLine($"public partial class {category}Commands : QuokkaTCL");
                        using (builder.Block())
                        {
                            foreach (var command in commands)
                            {
                                builder.AppendLine($"public void {command}()");
                                using (builder.Block())
                                {

                                }
                            }
                        }
                    }

                    var filePath = Path.Combine(generatedPath, $"{category}.cs");
                    File.WriteAllText(filePath, builder.ToString());
                }

                var vivadoTCL = new IndentedStringBuilder();
                vivadoTCL.AppendLine($"using System;");
                vivadoTCL.AppendLine("namespace Quokka.TCL.Vivado");
                using (vivadoTCL.Block())
                {
                    vivadoTCL.AppendLine($"public partial class VivadoTCL : QuokkaTCL");
                    using (vivadoTCL.Block())
                    {
                        foreach (var category in categories)
                        {
                            vivadoTCL.AppendLine($"public {category}Commands {category} = new {category}Commands();");
                        }
                    }
                }
                var vivadoTCLFilePath = Path.Combine(generatedPath, $"VivadoTCL.cs");
                File.WriteAllText(vivadoTCLFilePath, vivadoTCL.ToString());
            }
        }
    }
}
