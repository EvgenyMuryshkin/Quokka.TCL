// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class ToolLaunchCommands
	{
		private readonly QuokkaTCL _tcl;
		public ToolLaunchCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Get registered simulators
		///
		/// Get the list of simulators registered for use with the Vivado Design Suite unified simulation
		/// environment.
		/// The Vivado Design Suite comes with some simulators pre-registered for use with the unified
		/// simulation environment. You can also register your own third-party simulators using the
		/// register_simulator command.
		/// This command returns the names of registered simulators, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 899
		/// </summary>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// Perform case-insensitive matching (valid only when -regexp
		/// specified)
		/// </param>
		/// <param name="filter">
		/// Optional
		/// Filter list with expression
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="patterns">
		/// Optional
		/// Match simulator names against patterns Default: *
		/// </param>
		public void get_simulators(bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_simulators");
			_tcl.Add(command);
		}
		/// <summary>
		/// Issues an error that you can not run this command
		///
		/// Launches the ChipScope™ Pro Analyzer tool for the active run, or a specified Implemented
		/// Design run. You can setup a Netlist Design for use with ChipScope prior to implementation, using
		/// the create_debug_core, create_debug_port, and connect_debug_port commands.
		/// The Implemented Design must also have a bitstream file generated by BitGen for
		/// launch_chipscope_analyzer to run. If BitGen has not been run, an error will be returned.
		/// Note: It is not enough to use the write_bitstream command to create a bitstream file. You must follow
		/// the steps outlined below in the second example.
		///
		/// The following example launches ChipScope Pro Analyzer, specifying the implementation run to
		/// use and the name of the ChipScope project to create:
		/// launch_chipscope_analyzer -run impl_3 -csproject impl_3_cs_project
		/// The following example sets the add_step Bitgen property for the impl_4 run, launches the
		/// impl_4 run, and then launches the ChipScope Pro Analyzer on the specified run:
		/// set_property add_step Bitgen [get_runs impl_4]
		/// launch_runs impl_4 -jobs 2
		/// launch_chipscope_analyzer -run impl_4
		/// Note: In this example the ChipScope project will be called csdefaultproj.cpj.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 986
		/// </summary>
		/// <param name="run">
		/// Optional
		/// Implemented run to launch ChipScope Analyzer with
		/// </param>
		/// <param name="csproject">
		/// Optional
		/// ChipScope project
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void launch_chipscope_analyzer(string run = null, string csproject = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("launch_chipscope_analyzer");
			_tcl.Add(command);
		}
		/// <summary>
		/// Issues an error that you can not run this command
		///
		/// Launch iMPACT to configure your device and generate programming files. You can also read back
		/// and verify design configuration data, debug configuration problems, or execute XSVF files.
		/// You must generate the bitstream file using write_bitstream prior to using iMPACT.
		/// The command returns the list of files read.
		///
		/// The following example launches iMPACT using the specified implementation run:
		/// launch_impact -run impl_3
		///
		/// See ug835-vivado-tcl-commands.pdf, page 988
		/// </summary>
		/// <param name="run">
		/// Optional
		/// Implemented run to launch iMPACT with
		/// </param>
		/// <param name="ipf">
		/// Optional
		/// Project for iMPACT
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void launch_impact(string run = null, string ipf = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("launch_impact");
			_tcl.Add(command);
		}
		/// <summary>
		/// Launch simulation
		///
		/// Launch a simulator to perform analysis and verification of a design.
		/// The launch_simulation command creates a script file for the target simulator and then
		/// executes this file in the simulation run directory. The simulation results are saved in the log files
		/// created in the run directory.
		/// To run simulation for a specific simulator, you must first define the target simulator by setting the
		/// TARGET_SIMULATOR property on the design project:
		/// set_property TARGET_SIMULATOR <name> [current_project]
		/// The TARGET_SIMULATOR property can have a value of XSim, ModelSim, IES, Xcelium, VCS,
		/// Riviera, or ActiveHDL. The default value is XSim, the Vivado simulator.
		/// The target simulator can also be defined from the Vivado IDE. Create or open a project, select
		/// Tools → Settings → Simulation menu item, and select the Target simulator from the drop-down
		/// menu. The available choices are: Vivado simulator, ModelSim Simulator, Questa Advanced
		/// Simulator, Incisive Enterprise Simulator (IES), Xcelium Parallel Simulator, Verilog Compiler
		/// Simulator (VCS), Riviera-PRO Simulator, and Active-HDL Simulator.
		/// TIP: Some of these simulators are only available on Linux and some are only available on Windows.
		/// The launch_simulation command uses a three-step process comprised of compile,
		/// elaborate, and simulate steps. A script file for the target simulator is created for each step in the
		/// process, (compile.bat, elaborate.bat, simulate.bat), and written to the simulation run
		/// directory.
		/// TIP: On Linux the script files are named with the .sh suffix instead of .bat.
		/// By default, launch_simulation will run these script files in sequence to run the simulation.
		/// You can create the scripts without running them by using the -scripts_only option.
		/// This command returns a transcript of its process, or returns an error if it fails.
		///
		/// The following commands run behavioral simulation of the design using the Vivado simulator:
		/// set_property target_simulator "XSim" [current_project]
		/// launch_simulation
		/// The following commands run post-synthesis functional simulation of the design using the
		/// ModelSim Simulator:
		/// set_property target_simulator "ModelSim" [current_project]
		/// launch_simulation -mode "post-synthesis" -type "functional"
		/// The following commands run post-implementation functional simulation of the design using the
		/// Cadence IES Simulator:
		/// set_property target_simulator "IES" [current_project]
		/// launch_simulation -mode "post-implementation" -type "functional"
		/// The following commands run post-implementation timing simulation of the design using the
		/// Synopsys VCS Simulator:
		/// set_property target_simulator "VCS" [current_project]
		/// launch_simulation -mode "post-implementation" -type "timing"
		/// The following command generates behavioral simulation scripts for the target simulator in the
		/// simulation run directory:
		/// launch_simulation -scripts_only
		/// The following commands run behavioral simulation flow of the design for the "my_simset"
		/// simulation fileset for the target simulator in the simulation run directory:
		/// launch_simulation -simset [get_filesets my_simset]
		/// The following command runs behavioral simulation flow for the char_fifo.xci IP for the
		/// target simulator in the simulation run directory, and does not clean up prior simulation files:
		/// launch_simulation -noclean_dir -of_objects [get_files char_fifo.xci]
		/// The following command generates absolute paths for the source files in the generated script files:
		/// launch_simulation -absolute_path
		/// The following command will pick the simulator tools from the specified installation path instead
		/// of from the PATH variable:
		/// launch_simulation -install_path /tools/ius/13.20.005/tools/bin
		///
		/// See ug835-vivado-tcl-commands.pdf, page 995
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Generate compile order file for this object (applicable with -
		/// scripts_only option only)
		/// </param>
		/// <param name="step">
		/// Optional
		/// Launch a simulation step. Values: all, compile, elaborate,
		/// simulate. Default:all (launch all steps). Default: all
		/// </param>
		/// <param name="simset">
		/// Optional
		/// Name of the simulation fileset
		/// </param>
		/// <param name="mode">
		/// Optional
		/// Simulation mode. Values: behavioral, post-synthesis, post￾implementation Default: behavioral
		/// </param>
		/// <param name="type">
		/// Optional
		/// Netlist type. Values: functional, timing. This is only
		/// applicable when mode is set to post-synthesis or post￾implementation
		/// </param>
		/// <param name="scripts_only">
		/// Optional
		/// Only generate scripts
		/// </param>
		/// <param name="absolute_path">
		/// Optional
		/// Make design source file paths in 'absolute' format
		/// </param>
		/// <param name="install_path">
		/// Optional
		/// Custom installation directory path
		/// </param>
		/// <param name="noclean_dir">
		/// Optional
		/// Do not remove simulation run directory files
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void launch_simulation(string of_objects, string step = null, string simset = null, string mode = null, string type = null, bool? scripts_only = null, bool? absolute_path = null, string install_path = null, bool? noclean_dir = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("launch_simulation");
			_tcl.Add(command);
		}
	}
}
