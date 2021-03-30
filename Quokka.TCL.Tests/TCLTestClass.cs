using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quokka.Rollout;
using Quokka.TCL.Tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Quokka.TCL.Tests
{
    public class TCLTestClass
    {
        protected string TestOutputFolder => Path.Combine(RolloutTools.SolutionLocation(), "Quokka.TCL.Tests", "output");
        protected string TestSourceFolder => Path.Combine(RolloutTools.SolutionLocation(), "Quokka.TCL.Tests", "source");
        protected string pidFile => Path.Combine(TestOutputFolder, "pid.txt");
        protected string LogFile => Path.Combine(TestOutputFolder, "vivado.log");

        [TestInitialize]
        public void OnInitialize()
        {
            if (Directory.Exists(TestOutputFolder))
                Directory.Delete(TestOutputFolder, true);

            Directory.CreateDirectory(TestOutputFolder);
        }

        protected void SaveTCL(TCLFile tcl)
        {
            if (tcl == null)
                throw new NullReferenceException(nameof(tcl));

            File.WriteAllText(Path.Combine(TestOutputFolder, $"script.tcl"), tcl.ToString());
        }

        protected void RunTCL(TCLFile tcl = null)
        {
            if (tcl != null)
                SaveTCL(tcl);

            if (File.Exists(pidFile))
            {
                var pid = int.Parse(File.ReadAllText(pidFile));
                // previous run was not completed, vivado may hang in there and lock files. Kill it
                var running = Process.GetProcesses().FirstOrDefault(p => p.Id == pid);
                if (running != null)
                {
                    running.Kill(true);
                }
            }

            var process = Process.Start(new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                WorkingDirectory = TestOutputFolder,
                Arguments = $"/c vivado.bat -mode batch -source script.tcl"
            });

            File.WriteAllText(pidFile, $"{process.Id}");

            process.WaitForExit();
            Assert.AreEqual(0, process.ExitCode);

            var logFile = Path.Combine(TestOutputFolder, "vivado.log");
            if (File.Exists(logFile))
            {
                var lines = File.ReadAllLines(logFile);
                File.WriteAllLines(logFile, lines);
            }
        }

        protected List<string> LoadTCLLines()
        {
            return File.ReadAllLines(Path.Combine(TestOutputFolder, $"script.tcl"))
                .Where(l => !string.IsNullOrWhiteSpace(l))
                .ToList();
        }
    }
}
