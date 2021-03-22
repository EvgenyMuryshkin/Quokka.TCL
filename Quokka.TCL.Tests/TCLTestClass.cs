﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quokka.Rollout;
using Quokka.TCL.Tools;
using System.IO;

namespace Quokka.TCL.Tests
{
    public class TCLTestClass
    {
        protected string TestOutputFolder => Path.Combine(RolloutTools.SolutionLocation(), "Quokka.TCL.Tests", "output");

        [TestInitialize]
        public void OnInitialize()
        {
            if (Directory.Exists(TestOutputFolder))
                Directory.Delete(TestOutputFolder, true);

            Directory.CreateDirectory(TestOutputFolder);
        }

        protected void SaveTCL(TCLFile tcl)
        {
            File.WriteAllText(Path.Combine(TestOutputFolder, $"script.tcl"), tcl.ToString());
        }
    }
}