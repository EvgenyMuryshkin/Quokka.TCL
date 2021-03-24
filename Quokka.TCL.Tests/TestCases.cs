using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quokka.TCL.Tools;
using Quokka.TCL.Vivado;

namespace Quokka.TCL.Tests
{
    class CustomVivadoTCLBuilder : VivadoTCLBuilder
    {
        public override SimpleTCLCommand create_project(string name, string part = null, bool? force = null, bool? in_memory = null, bool? ip = null, bool? rtl_kernel = null, bool? quiet = null, bool? verbose = null, string dir = null)
        {
            // always verbose
            return base.create_project(name, part, force, in_memory, ip, rtl_kernel, quiet, true, dir);
        }
    }

    [TestClass]
    public class TestCases : TCLTestClass
    {
        [TestMethod]
        public void CategorizedTCL_CreateProject()
        {
            var tcl = new VivadoCategorizedTCL();
            tcl.Project.create_project("test", quiet: true);
            SaveTCL(tcl);
            Assert.AreEqual("create_project -quiet test", LoadTCLLines()[0]);
        }

        [TestMethod]
        public void FlatTCL_CreateProject()
        {
            var tcl = new VivadoTCL();
            tcl.create_project("test", verbose: true);
            SaveTCL(tcl);
            Assert.AreEqual("create_project -verbose test", LoadTCLLines()[0]);
        }

        [TestMethod]
        public void FlatTCL_Custom_CreateProject()
        {
            var tcl = new VivadoTCL(new CustomVivadoTCLBuilder());
            tcl.create_project("test");
            SaveTCL(tcl);
            Assert.AreEqual("create_project -verbose test", LoadTCLLines()[0]);
        }
    }
}
