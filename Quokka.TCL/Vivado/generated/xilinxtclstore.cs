// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class xilinxtclstoreCommands
	{
		private readonly QuokkaTCL _tcl;
		public xilinxtclstoreCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// (User-written application) Convert all provided NGC files to a supported format
		///
		/// Converts provided NGC files to a supported format.
		///
		/// The following example will convert test.ngc to test.edn, with verbose messaging. The
		/// test.edn file will be added to the current open project:
		/// convert_ngc ./test.ngc -add_to_project -verbose
		/// The following example will convert test.ngc to test.edn. The test.edn file will be placed
		/// in the ./output directory. If ./output/test.edn exists it will be replaced:
		/// convert_ngc ./test.ngc -output_dir output -force
		/// The following example converts all NGC files in the current directory and in all sub-directories:
		/// convert_ngc [ glob ./**/*.ngc ] [ glob ./*.ngc ]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 208
		/// </summary>
		/// <param name="files">
		/// Required
		/// A list of NGC files to convert
		/// </param>
		/// <param name="output_dir">
		/// Optional
		/// Directory to place all output, else the output is placed at
		/// location of NGC file Default: Script output directory path
		/// </param>
		/// <param name="format">
		/// Optional
		/// Accepts 'Verilog' or 'EDIF' (Default: EDIF), specifies the
		/// desired output format Default: EDIF
		/// </param>
		/// <param name="add_to_project">
		/// Optional
		/// Adds the output files to the current project, if no project is
		/// open, then this option does nothing
		/// </param>
		/// <param name="force">
		/// Optional
		/// Force overwriting of files that already exist on disk, replaces
		/// files in project if add_to_project switch was specified
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>None</returns>
		public void convert_ngc(string files, string output_dir = null, string format = null, bool? add_to_project = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("convert_ngc");
			_tcl.Add(command);
		}
		/// <summary>
		/// (User-written application) Copy a run from an already existing run, source-run, to a new copy of
		/// that run, destination-run.
		///
		/// Copies an existing synthesis or implementation run.
		///
		/// The following example will copy synth_1 run into a new synth_2 run:
		/// copy_run -name synth_2 [get_runs synth_1]
		/// The following example will copy the impl_1 run into a new run called impl_2, and assign synth_2
		/// as the parent of the new run:
		/// copy_run -name impl_2 [get_runs impl_1] -parent_run synth_2
		///
		/// See ug835-vivado-tcl-commands.pdf, page 215
		/// </summary>
		/// <param name="name">
		/// Required
		/// Specify the name of the new run
		/// </param>
		/// <param name="run">
		/// Required
		/// The run to be copied, accepts name or run object
		/// </param>
		/// <param name="parent_run">
		/// Optional
		/// Specify the synthesis run for the new implementation run,
		/// accepts name or run object (Default: same as source run)
		/// Default: None
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Print detailed information as the copy progresses
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <returns>The new run object</returns>
		public void copy_run(string name, string run, string parent_run = null, bool? verbose = null, bool? quiet = null)
		{
			var command = new SimpleTCLCommand("copy_run");
			_tcl.Add(command);
		}
		/// <summary>
		/// (User-written application) Creates and launches a new run based on the suggestions by
		/// report_qor_suggestions. This proc looks for 5 files in the directory specified by the user.
		/// 1.RQSPreSynth_<newProjName>.xdc 2.RQSImplCommon_<newProjName>.xdc
		/// 3.RQSPreImpl_<newProjName>.xdc 4.RQSPreImpl_<newProjName>.tcl
		/// 5.RQSImplCommon_<newProjName>.tcl. There are 2 flows. One is creating both synth and impl
		/// runs and the other is creating only impl run making user specified synth run as the parent for the
		/// newly created impl run. In the first flow, we create a new synth run based on the current impl
		/// run's parent run (i,e current synth run). We create a new constraint fileset and add the current
		/// synth run's constraint fileset's files to that. And we add RQSPreSynth_<>.xdc file to newly
		/// created constraint set. We create a impl run based on the current impl run. We create a impl run
		/// constraint (if it is not same as the one that has already been created), and add the current impl
		/// run's constraint fileset's files to that. We also add RQSImplCommon_<>.xdc to new impl
		/// constraint fileset. We set STEPS.OPT_DESIGN.TCL.PRE property of newly created impl run to
		/// RQSImplCommon_<>.tcl file. In this flow, we ignore RQSPreImpl_<>.xdc/tcl files. In the second
		/// flow, user specified synth run is used as parent for the newly created impl run. So there is no
		/// synth run creation. We create impl run based on current impl run and user specified synth run.
		/// We create a new impl constraint fileset and add fileset to that form the current impl run's
		/// constraint fileset. We also add RQSImplCommon_<>.xdc , RQSPreImpl_<>.xdc files. If
		/// RQSPreImpl_<>.tcl file is available, it is set as STEPS.OPT_DESIGN.TCL.PRE property for new
		/// impl run otherwise RQSImplCommon_<>.tcl is set. In both the flows adding or setting files is
		/// subject to availability of those files in the output directory.
		///
		/// Creates and launches a new implementation run based on the suggestions provided by
		/// report_qor_suggestions.
		///
		/// The following example will create and launch a new run, exp_1, using the constraints files from
		/// the specified directory:
		/// create_rqs_run -dir path_to_dir -new_name exp_1 -synth_name synth_1 \
		/// -opt_more_options optVal -place_more_options placeVal
		/// TIP: The constraints were previously created using the -output_dir option of the
		/// report_qor_suggestions command.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 346
		/// </summary>
		/// <param name="dir">
		/// Required
		/// Specify the directory from where the xdc files and tcl files
		/// need to fetched.
		/// </param>
		/// <param name="new_name">
		/// Required
		/// Specify the name of the new run
		/// </param>
		/// <param name="synth_name">
		/// Optional
		/// Specify the name of the already existing synth run. This run
		/// will be the parent run for the newly created impl run
		/// Default: None
		/// Name Description
		/// </param>
		/// <param name="opt_more_options">
		/// Optional
		/// optional argument. Specify the value for opt_design step's
		/// more option property which will be set on newly created
		/// run. Default: None
		/// </param>
		/// <param name="place_more_options">
		/// Optional
		/// Specify the value for place_design step's more option
		/// property which will be set on newly created run. Default:
		/// None
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>None</returns>
		public void create_rqs_run(string dir, string new_name, string synth_name = null, string opt_more_options = null, string place_more_options = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("create_rqs_run");
			_tcl.Add(command);
		}
		/// <summary>
		/// (User-written application) Create and write a single design checkpoint and stub files for a Block
		/// Design (BD), for use with third party synthesis tools. Perform synthesis as necessary.
		///
		/// Runs synthesis for a block design (.bd), integrates the design along with any needed sub-designs
		/// (e.g. out-of-context synthesized IP), and writes out a single design checkpoint (.dcp) of the
		/// entire synthesized design, as well as HDL stub files, for use in other synthesis tools. The output
		/// files will be placed in the same directory as the source BD file.
		///
		/// The following command will generate a synthesis checkpoint, with stub files, for the specified
		/// block design:
		/// export_bd_synth [get_files block_1.bd]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 503
		/// </summary>
		/// <param name="file">
		/// Required
		/// The Block Design file to write a synthesized checkpoint for
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite existing design checkpoint and stub files
		/// </param>
		/// <param name="keep">
		/// Optional
		/// Keep the temporary directory and project
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Print verbose messaging
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <returns>(none) An error will be thrown if the command is not successful</returns>
		public void export_bd_synth(string file, bool? force = null, bool? keep = null, bool? verbose = null, bool? quiet = null)
		{
			var command = new SimpleTCLCommand("export_bd_synth");
			_tcl.Add(command);
		}
		/// <summary>
		/// (User-written application) Generate and export IP/IPI user files from a project. This can be
		/// scoped to work on one or more IPs. Argument Usage: [-of_objects <arg>]: IP,IPI or a fileset object
		/// [-ip_user_files_dir <arg>]: Directory path to simulation base directory (for static, dynamic,
		/// wrapper, netlist, script and MEM files) [-ipstatic_source_dir <arg>]: Directory path to the IP static
		/// files [-lib_map_path <arg> = Empty]: Compiled simulation library directory path [-no_script]: Do
		/// not export simulation scripts [-sync]: Delete IP/IPI dynamic and simulation script files [-reset]:
		/// Delete all IP/IPI static, dynamic and simulation script files [-force]: Overwrite files
		///
		/// Export IP user files repository with static, dynamic, netlist, verilog/vhdl stubs and memory
		/// initializaton files.
		///
		/// The following command will export the dynamic files for the char_fifo IP to <project>/
		/// <project>.ip_user_files/ip/char_fifo directory, and IP static files to <project>/
		/// <project>.ip_user_files/ipstatic directory:
		/// export_ip_user_files -of_objects [get_ips char_fifo]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 505
		/// </summary>
		/// <param name="of_objects">
		/// Optional
		/// IP,IPI or a fileset object Default: None
		/// </param>
		/// <param name="ip_user_files_dir">
		/// Optional
		/// Directory path to simulation base directory (for static,
		/// dynamic, wrapper, netlist, script and MEM files) Default:
		/// None
		/// </param>
		/// <param name="ipstatic_source_dir">
		/// Optional
		/// Directory path to the IP static files Default: None
		/// </param>
		/// <param name="lib_map_path">
		/// Optional
		/// Compiled simulation library directory path Default: Empty
		/// </param>
		/// <param name="no_script">
		/// Optional
		/// Do not export simulation scripts Default: 1
		/// </param>
		/// <param name="sync">
		/// Optional
		/// Delete IP/IPI dynamic and simulation script files
		/// </param>
		/// <param name="reset">
		/// Optional
		/// Delete all IP/IPI static, dynamic and simulation script files
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite files
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>list of files that were exported</returns>
		public void export_ip_user_files(string of_objects = null, string ip_user_files_dir = null, string ipstatic_source_dir = null, string lib_map_path = null, bool? no_script = null, bool? sync = null, bool? reset = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("export_ip_user_files");
			_tcl.Add(command);
		}
		/// <summary>
		/// (User-written application) Export a script and associated data files (if any) for driving standalone
		/// simulation using the specified simulator.
		///
		/// Export a simulation script file for the target simulator. Currently the Cadence Incisive Enterprise
		/// Simulator (ies) and the Synopsys VCS MX simulator (vcs_mx) are supported. The generated
		/// script will contain simulator commands for compiling, elaborating and simulating the design.
		/// The command will retrieve the simulation compile order of specified objects, and export this
		/// information in a text file with the compiler commands and default options for the target
		/// simulator. The specified object can be either a simulation fileset or an IP. If the object is not
		/// specified, then the export_simulation command will generate the script for the simulation
		/// top.
		/// Any verilog include directories or file paths for the files containing verilog define statements will
		/// be added to the compiler command line.
		/// By default, the design source file and include directory paths in the compiler command line will
		/// be set relative to the "reference_dir" variable that is defined in the generated script. To make
		/// these paths absolute, specify the -absolute_path option.
		/// The command will also copy data files (if any) from the fileset, or from an IP, to the output
		/// directory. If the design contains "Verilog" sources, then the generated script will also copy "glbl.v"
		/// from the software installation path to the output directory.
		/// A default ".do" file will be created in the output directory for the target simulator that will be
		/// referred in the compiler commands in the script.
		/// Note: In order to perform simulation with the generated script, the simulation libraries must be compiled
		/// first using the compile_simlib command, with the compiled library directory path specified, when
		/// generating this script. The generated simulation script will automatically include the setup files for the
		/// target simulator from the compiled library directory.
		/// This command returns nothing.
		///
		/// The following command generates a simulation script file in the current directory for the "IES"
		/// simulator:
		/// export_simulation -simulator ies -directory .
		/// The following command overwrites an existing script file in the current directory:
		/// export_simulation -force -simulator ies -directory .
		/// The following command generates a simulation script file named test_ies.sh in the ./
		/// test_sim directory:
		/// export_simulation -simulator ies -directory ./test_sim \
		/// -script_name test_ies.sh
		/// The following command generates a script file named top_tb_sim_ies.sh in the ./
		/// test_sim directory for a project with simulation top set to "top_tb". The command will also
		/// copy any data files (.mif, .coe, .dat, etc) to the ./test_sim directory:
		/// export_simulation -simulator ies -directory ./test_sim
		/// The following command generates a script file accum_0_sim_ies.sh for the "accum_0" IP in
		/// the specified output directory for the "IES" simulator:
		/// export_simulation -of_objects [get_files accum_0.xci] \
		/// -simulator ies -directory test_sim
		/// The following command generates a script file accum_0_sim_vcs_mx.sh for the "accum_0" IP
		/// in the specified output directory for the "VCS_MX" simulator:
		/// export_simulation -of_objects [get_ips accum_0] -simulator vcs_mx \
		/// -directory test_sim
		/// The following command generates a script file fifo_tb_sim_vcs_mx.sh for the simulation
		/// fileset "sim_fifo_test" whose top is set to "fifo_tb" in the specified output directory for the "IES"
		/// simulator:
		/// export_simulation -of_objects [get_filesets sim_fifo_test] \
		/// -simulator ies -directory test_sim
		/// The following command exports a script file top_tb_sim_vcs_mx.sh for the "VCS_MX"
		/// simulator in the specified output directory with the design source files compiled for 32 bit
		/// version of the simulator compiler (no 64 bit option will be added to the command line):
		/// export_simulation -force -32bit -simulator vcs_mx -directory
		/// test_bft_vcs_mx
		/// The following example will include /sim_libs/ius/lin64/lib/cds.lib file path in the ./
		/// test_sim/cds.lib file ("INCLUDE /sim_libs/ius/lin64/lib/cds.lib") for referencing the
		/// compiled libraries for "IES" simulator:
		/// export_simulation -lib_map_path "/sim_libs/ius/lin64/lib" \
		/// -simulator ies -directory "test_sim"
		/// The following example will include /sim_libs/vcs/lin64/lib/synopsys_sim.setup file
		/// path in the ./test_sim/synopsys_sim.setup file ("OTHERS=/sim_libs/vcs/lin64/lib/
		/// synopsys_sim.setup") for refrencing the compiled libraries for the "VCS_MX" simulator:
		/// export_simulation -lib_map_path "/sim_libs/vcs/lin64/lib" \
		/// -simulator vcs_mx -directory "test_sim"
		/// The following example generates a script file in ./test_sim/ies directory and then compiles,
		/// elaborates and simulates the design in "IES" simulator:
		/// export_simulation -lib_map_path "/sim_libs/ies/lin64/lib" \
		/// -simulator ies -directory "./test_sim/ies"
		/// cd test_sim/ies
		/// ./top_tb_sim_ies.sh
		/// The following example generates a script file in ./test_sim/vcs_mx directory and then
		/// compile, elaborate and simulate the design in "VCS_MX" simulator:
		/// export_simulation -lib_map_path "/sim_libs/vcs/lin64/lib" \
		/// -simulator vcs_mx -directory "./test_sim/vcs_mx"
		/// cd test_sim/vcs_mx
		/// ./top_tb_sim_vcs_mx.sh
		///
		/// See ug835-vivado-tcl-commands.pdf, page 508
		/// </summary>
		/// <param name="simulator">
		/// Optional
		/// Simulator for which the simulation script will be created
		/// (value=all|xsim|modelsim|questa|ies|xceliu m|vcs|
		/// riviera|activehdl) Default: all
		/// </param>
		/// <param name="of_objects">
		/// Optional
		/// Export simulation script for the specified object Default:
		/// None
		/// </param>
		/// <param name="ip_user_files_dir">
		/// Optional
		/// Directory path to the exported IP/BD (Block Design) user
		/// files (for static, dynamic and data files) Default: Empty
		/// </param>
		/// <param name="ipstatic_source_dir">
		/// Optional
		/// Directory path to the exported IP/BD static files Default:
		/// Empty
		/// </param>
		/// <param name="lib_map_path">
		/// Optional
		/// Precompiled simulation library directory path. If not
		/// specified, then please follow the instructions in the
		/// generated script header to manually provide the simulation
		/// library mapping information. Default: Empty
		/// </param>
		/// <param name="script_name">
		/// Optional
		/// Output script filename. If not specified, then a file with a
		/// default name will be created. Default: top_module.sh
		/// </param>
		/// <param name="directory">
		/// Optional
		/// Directory where the simulation script will be generated
		/// Default: export_sim
		/// </param>
		/// <param name="runtime">
		/// Optional
		/// Run simulation for this time (default:full simulation run or
		/// until a logical break or finish condition) Default: Empty
		/// </param>
		/// <param name="define">
		/// Optional
		/// Read verilog defines from the list specified with this switch
		/// Default: Empty
		/// </param>
		/// <param name="generic">
		/// Optional
		/// Read vhdl generics from the list specified with this switch
		/// Default: Empty
		/// </param>
		/// <param name="include">
		/// Optional
		/// Read include directory paths from the list specified with this
		/// switch Default: Empty
		/// </param>
		/// <param name="use_ip_compiled_libs">
		/// Optional
		/// Reference pre-compiled IP static library during compilation.
		/// This switch requires -ip_user_files_dir and -
		/// ipstatic_source_dir switches as well for generating scripts
		/// using pre-compiled IP library.
		/// Name Description
		/// </param>
		/// <param name="absolute_path">
		/// Optional
		/// Make all file paths absolute
		/// </param>
		/// <param name="export_source_files">
		/// Optional
		/// Copy IP/BD design files to output directory
		/// </param>
		/// <param name="32bit">
		/// Optional
		/// Perform 32bit compilation
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite previous files
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>None</returns>
		public void export_simulation(string simulator = null, string of_objects = null, string ip_user_files_dir = null, string ipstatic_source_dir = null, string lib_map_path = null, string script_name = null, string directory = null, string runtime = null, string define = null, string generic = null, string include = null, bool? use_ip_compiled_libs = null, bool? absolute_path = null, bool? export_source_files = null, bool? 32bit = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("export_simulation");
			_tcl.Add(command);
		}
		/// <summary>
		/// (User-written application) Extract IP static files from the project or repository and prepare it for
		/// compile_simlib Argument Usage: [-directory <arg>]: Extract static files in the specified directory [-
		/// ip_repo_path <arg>]: Extract static files from the specified IP repository path [-ips <arg> =
		/// Empty]: Extract static files for the specified IPs only [-library <arg> = Empty]: Extract static files
		/// for the specified IP library [-project]: Extract static files for the current project [-install]: Extract
		/// static files for the IP catalog [-no_update_catalog]: Do no update IP catalog [-force]: Overwrite
		/// static files
		///
		/// Retrieve static simulation files for IP cores used in the current project, or from the Xilinx IP
		/// catalog, and create a source library for the compile_simlib command to use for compiling the
		/// IP files for a specified simulator.
		///
		/// The following command will build static library for all the IPs in the current project in ./
		/// static_compiled_lib:
		/// setup_ip_static_library -project
		/// The following command will build static library for the current project in /work/simlib. The
		/// command will create the specified directory if it does not exist:
		/// setup_ip_static_library -directory /work/simlib -project
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1668
		/// </summary>
		/// <param name="directory">
		/// Optional
		/// Extract static files in the specified directory Default: None
		/// </param>
		/// <param name="ip_repo_path">
		/// Optional
		/// Extract static files from the specified IP repository path
		/// Default: None
		/// </param>
		/// <param name="ips">
		/// Optional
		/// Extract static files for the specified IPs only Default: Empty
		/// </param>
		/// <param name="library">
		/// Optional
		/// Extract static files for the specified IP library Default: Empty
		/// </param>
		/// <param name="project">
		/// Optional
		/// Extract static files for the current project
		/// </param>
		/// <param name="install">
		/// Optional
		/// Extract static files for the IP catalog
		/// </param>
		/// <param name="no_update_catalog">
		/// Optional
		/// Do no update IP catalog Default: 1
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite static files
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>None</returns>
		public void setup_ip_static_library(string directory = null, string ip_repo_path = null, string ips = null, string library = null, bool? project = null, bool? install = null, bool? no_update_catalog = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("setup_ip_static_library");
			_tcl.Add(command);
		}
		/// <summary>
		/// (User-written application) Export Tcl script for re-creating the current project
		///
		/// Creates a Tcl script to recreate the current project.
		/// The generated script will contain the Tcl commands for creating the project, setting the project
		/// type, creating filesets, adding/importing source files, defining runs and run properties.
		/// IMPORTANT! The new project will be created in the current working directory (CWD) where the generated Tcl
		/// script is sourced from. The script written out by write_project_tcl should be sourced in the same
		/// directory from which it was created. If you source the script from a different directory, you should first set the
		/// <origin_dir_loc> variable in Tcl shell to this alternate directory, or edit the script to define the <origin_dir>
		/// variable in the script in order to maintain the relative path between the CWD and the source files referenced in
		/// the script.
		/// This Tcl project script and the various design sources can be stored in a version control system
		/// for source file management and project archival.
		///
		/// The following example exports Tcl script named recreate.tcl for the current project:
		/// write_project_tcl recreate.tcl
		/// The following example exports a Tcl script named recreate.tcl for the current project in
		/// the ./script directory and specifies the /tmp/test directory for the create_project
		/// command. When the recreate.tcl script is run in the Vivado Tcl shell, the project will be re￾created in /tmp/test directory:
		/// write_project_tcl -target_proj_dir "/tmp/test" ./script/recreate.tcl
		/// The following command exports Tcl script for the current project and writes all the properties,
		/// both default or non-default values:
		/// write_project_tcl -all_properties recreate.tcl
		/// The following command exports Tcl script for the current project and adds files that are local in
		/// this project. The recreated project will reference these files:
		/// write_project_tcl -no_copy_sources -use_bd_files recreate.tcl
		/// IMPORTANT! The -use_bd_files switch is required for use with -no_copy_sources in designs with
		/// block diagrams.
		/// The following command exports recreate.tcl script for the current project in the current
		/// working directory, creates a new project in ./my_test directory, prints the list of files in the
		/// new project, prints the current project settings and then closes the newly created project:
		/// open_project ./test/test.xpr
		/// write_project_tcl -force recreate.tcl
		/// close_project
		/// file mkdir my_test
		/// cd my_test
		/// source ../recreate.tcl
		/// get_files -of_objects [get_filesets sources_1]
		/// report_property [current_project]
		/// close_project
		/// The following command creates a new project named bft_test, adds files to the project, sets the
		/// fileset property, exports a tcl script named bft.tcl in the current working directory, creates a
		/// new project in ./my_bft directory, prints the list of files in the new project (test_1.v and
		/// test_2.v), prints the "verilog_define" property value and then closes the newly created project:
		/// create_project bft_test ./bft_test
		/// add_files test_1.v
		/// add_files test_2.v
		/// set_property verilog_define {a=10} [get_filesets sources_1]
		/// write_project_tcl -force bft.tcl
		/// close_project
		/// file mkdir my_bft
		/// cd my_bft
		/// source ../bft.tcl
		/// get_files -of_objects [get_filesets sources_1]
		/// get_property verilog_define [get_filesets sources_1]
		/// close_project
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1840
		/// </summary>
		/// <param name="file">
		/// Required
		/// Name of the tcl script file to generate
		/// </param>
		/// <param name="paths_relative_to">
		/// Optional
		/// Override the reference directory variable for source file
		/// relative paths Default: Script output directory path
		/// </param>
		/// <param name="origin_dir_override">
		/// Optional
		/// Set 'origin_dir' directory variable to the specified value
		/// (Default is value specified with the -paths_relative_to switch)
		/// Default: None
		/// </param>
		/// <param name="target_proj_dir">
		/// Optional
		/// Directory where the project needs to be restored Default:
		/// Current project directory path
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite existing tcl script file
		/// </param>
		/// <param name="all_properties">
		/// Optional
		/// Write all properties (default & non-default) for the project
		/// object(s)
		/// </param>
		/// <param name="no_copy_sources">
		/// Optional
		/// Do not import sources even if they were local in the original
		/// project Default: 1
		/// </param>
		/// <param name="no_ip_version">
		/// Optional
		/// Flag to not include the IP version as part of the IP VLNV in
		/// create_bd_cell commands. Default: 1
		/// </param>
		/// <param name="absolute_path">
		/// Optional
		/// Make all file paths absolute wrt the original project directory
		/// </param>
		/// <param name="dump_project_info">
		/// Optional
		/// Write object values
		/// </param>
		/// <param name="use_bd_files">
		/// Optional
		/// Use BD sources directly instead of writing out procs to
		/// create them
		/// </param>
		/// <param name="internal">
		/// Optional
		/// Print basic header information in the generated tcl script
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Execute the command quietly, returning no messages from
		/// the command.
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>true (0) if success, false (1) otherwise</returns>
		public void write_project_tcl(string file, string paths_relative_to = null, string origin_dir_override = null, string target_proj_dir = null, bool? force = null, bool? all_properties = null, bool? no_copy_sources = null, bool? no_ip_version = null, bool? absolute_path = null, bool? dump_project_info = null, bool? use_bd_files = null, bool? internal = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("write_project_tcl");
			_tcl.Add(command);
		}
	}
}
