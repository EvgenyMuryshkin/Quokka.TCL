using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quokka.TCL.Tools;
using Quokka.TCL.Vivado;
using System.Collections.Generic;
using System.IO;

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

        [TestMethod]
        public void SmokeTest()
        {
            var tcl = new VivadoTCL();

            tcl
                .create_project("test", part: "xcku5p-ffvb676-2-e", verbose: true)
                .SetProperty("board_part", "xilinx.com:kcu116:part0:1.5", tcl.CurrentProject)
                .SetProperty("target_language", "Verilog", tcl.CurrentProject)
                .SetProperty("default_lib", "work", tcl.CurrentProject)
                .SetProperty("platform.board_id", "kcu116", tcl.CurrentProject)
                .AddSources(TestSourceFolder, "*.v")
                .update_compile_order(fileset: "sources_1")
                .SetProperty("top", "testbench", tcl.Builder.current_fileset())
                .SetProperty("top", "testbench", tcl.Sim1)
                .SetProperty("SOURCE_SET", "sources_1", tcl.Sim1)
                .SetProperty("RUNTIME", "0ns", tcl.Sim1)
                .launch_simulation()
                .restart()
                .open_vcd(file_name: tcl.FileName(Path.Combine(TestOutputFolder, "sim.vcd")))
                .log_vcd(hdl_objects: "*")
                .run(time: "1000", unit: "ns")
                .flush_vcd()
                .close_vcd()
                .close_sim()
                ;

            RunTCL(tcl);
        }
    }
}
