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
        public void FlatTCL_LaunchSim_NoAttribute()
        {
            var tcl = new VivadoTCL();
            tcl.launch_simulation(mode: launch_simulation_mode.behavioral);
            SaveTCL(tcl);
            Assert.AreEqual("launch_simulation -mode behavioral", LoadTCLLines()[0]);
        }

        [TestMethod]
        public void FlatTCL_LaunchSim_WriteAttribute()
        {
            var tcl = new VivadoTCL();
            tcl.launch_simulation(mode: launch_simulation_mode.post_implementation);
            SaveTCL(tcl);
            Assert.AreEqual("launch_simulation -mode post-implementation", LoadTCLLines()[0]);
        }

        [TestMethod]
        public void FlatTCL_Custom_CreateProject()
        {
            var tcl = new VivadoTCL(new CustomVivadoTCLBuilder());
            tcl.create_project("test");
            SaveTCL(tcl);
            Assert.AreEqual("create_project -verbose test", LoadTCLLines()[0]);
        }

        void BuildAndRunSim(string testbench)
        {
            var tcl = new VivadoTCL();

            tcl
                .create_project("test", part: "xa7s6cpga196-2I", verbose: true)
                .SetProperty("target_language", "Verilog", tcl.CurrentProject)
                .AddSources(TestSourceFolder, "*.v")
                .update_compile_order(fileset: "sources_1")
                .SetProperty("top", "top", tcl.CurrentFileSet)
                .SetProperty("top", testbench, tcl.Sim1)
                .SetProperty("SOURCE_SET", "sources_1", tcl.Sim1)
                .SetProperty("RUNTIME", "0ns", tcl.Sim1)
                .launch_runs("impl_1", jobs: 4)
                .wait_on_run("impl_1")
                .launch_simulation(mode: launch_simulation_mode.post_implementation, type: launch_simulation_type.timing)
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

        [TestMethod]
        public void SmokeTest_Pass()
        {
            BuildAndRunSim("testbench_pass");
            Assert.IsFalse(File.ReadAllText(LogFile).Contains("Assert failed"));
        }

        [TestMethod]
        public void SmokeTest_Fail()
        {
            BuildAndRunSim("testbench_fail");
            Assert.IsTrue(File.ReadAllText(LogFile).Contains("Assert failed"));
        }
    }
}
