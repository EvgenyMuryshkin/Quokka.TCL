using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quokka.TCL.Tools;
using Quokka.TCL.Vivado;
using System;
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

        /// <summary>
        /// <para>Launch a set of runs</para>
        /// 1<br/>
        /// 2<br/>
        /// 3<br/>
        /// <br/>
        /// TCL Syntax: launch_runs [-jobs &lt;arg&gt;] [-scripts_only] [-lsf &lt;arg&gt;] [-sge &lt;arg&gt;] [-cluster_configuration &lt;arg&gt;] [-dir &lt;arg&gt;] [-to_step &lt;arg&gt;] [-next_step] [-host &lt;args&gt;] [-remote_cmd &lt;arg&gt;] [-email_to &lt;args&gt;] [-email_all] [-pre_launch_script &lt;arg&gt;] [-post_launch_script &lt;arg&gt;] [-custom_script &lt;arg&gt;] [-force] [-quiet] [-verbose] &lt;runs&gt;...
        /// 
        /// <para>launch_runs -to_step place_design impl_1</para>
        /// 
        /// <para>See ug835-vivado-tcl-commands.pdf, page 1012</para>
        /// </summary>
        /// <param name="runs">(Required) Runs to launch UG835 (v2020.2) November 18, 2020 www.xilinx.com</param>
        /// <param name="jobs">(Optional) Number of jobs Default: 1</param>
        public virtual SimpleTCLCommand launch_runs(TCLParameterList runs, Int32? jobs = null, bool? scripts_only = null, String lsf = null, String sge = null, String cluster_configuration = null, String dir = null, String to_step = null, bool? next_step = null, TCLParameterList host = null, String remote_cmd = null, TCLParameterList email_to = null, bool? email_all = null, String pre_launch_script = null, String post_launch_script = null, String custom_script = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: launch_runs [-jobs <arg>] [-scripts_only] [-lsf <arg>] [-sge <arg>] [-cluster_configuration <arg>] [-dir <arg>] [-to_step <arg>] [-next_step] [-host <args>] [-remote_cmd <arg>] [-email_to <args>] [-email_all] [-pre_launch_script <arg>] [-post_launch_script <arg>] [-custom_script <arg>] [-force] [-quiet] [-verbose] <runs>...

			return null;
		}

        /**
 * <summary>
 * this comment is on line 1 in the tooltip
 * this comment is on line 2 in the tooltip
 * </summary>
 */
        public void T()
        {

        }
	}
}
