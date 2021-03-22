using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quokka.TCL.Vivado;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quokka.TCL.Tests
{
    [TestClass]
    public class TestCases : TCLTestClass
    {
        [TestMethod]
        public void CreateProject()
        {
            var tcl = new VivadoTCL();
            tcl.Project.create_project("test");
            SaveTCL(tcl);
        }
    }
}
