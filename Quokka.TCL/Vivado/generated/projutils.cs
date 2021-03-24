// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class projutilsCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public projutilsCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// (User-written application) Convert all provided NGC files to a supported format
		///
		///
		/// TCL Syntax: convert_ngc [-output_dir <arg>] [-format <arg>] [-add_to_project] [-force] [-quiet] [-verbose] <files>
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
		/// See ug835-vivado-tcl-commands.pdf, page 213
		/// </summary>
		/// <param name="files">(Required) A list of NGC files to convert</param>
		/// <param name="output_dir">
		/// (Optional)
		/// Directory to place all output, else the output is placed at
		/// location of NGC file Default: Script output directory path
		/// </param>
		/// <param name="format">
		/// (Optional)
		/// Accepts 'Verilog' or 'EDIF' (Default: EDIF), specifies the
		/// desired output format Default: EDIF
		/// </param>
		/// <param name="add_to_project">
		/// (Optional)
		/// Adds the output files to the current project, if no project is
		/// open, then this option does nothing
		/// </param>
		/// <param name="force">
		/// (Optional)
		/// Force overwriting of files that already exist on disk, replaces
		/// files in project if add_to_project switch was specified
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>None</returns>
		public TTCL convert_ngc(string files, string output_dir = null, string format = null, bool? add_to_project = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: convert_ngc [-output_dir <arg>] [-format <arg>] [-add_to_project] [-force] [-quiet] [-verbose] <files>
			_tcl.Entry(_builder.convert_ngc(files, output_dir, format, add_to_project, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// (User-written application) Copy a run from an already existing run, source-run, to a new copy of
		/// that run, destination-run.
		///
		///
		/// TCL Syntax: copy_run [-parent_run <arg>] [-verbose] -name <arg> [-quiet] <run>
		///
		/// Copies an existing synthesis or implementation run.
		///
		/// The following example will copy synth_1 run into a new synth_2 run:
		/// copy_run -name synth_2 [get_runs synth_1]
		/// The following example will copy the impl_1 run into a new run called impl_2, and assign synth_2
		/// as the parent of the new run:
		/// copy_run -name impl_2 [get_runs impl_1] -parent_run synth_2
		///
		/// See ug835-vivado-tcl-commands.pdf, page 220
		/// </summary>
		/// <param name="name">(Required) Specify the name of the new run</param>
		/// <param name="run">(Required) The run to be copied, accepts name or run object</param>
		/// <param name="parent_run">
		/// (Optional)
		/// Specify the synthesis run for the new implementation run,
		/// accepts name or run object (Default: same as source run)
		/// Default: None
		/// </param>
		/// <param name="verbose">(Optional) Print detailed information as the copy progresses</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <returns>The new run object</returns>
		public TTCL copy_run(string name, string run, string parent_run = null, bool? verbose = null, bool? quiet = null)
		{
			// TCL Syntax: copy_run [-parent_run <arg>] [-verbose] -name <arg> [-quiet] <run>
			_tcl.Entry(_builder.copy_run(name, run, parent_run, verbose, quiet));
			return _tcl;
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
		///
		/// TCL Syntax: create_rqs_run -dir <arg> -new_name <arg> [-synth_name <arg>] [-opt_more_options <arg>] [-place_more_options <arg>] [-quiet] [-verbose]
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
		/// See ug835-vivado-tcl-commands.pdf, page 356
		/// </summary>
		/// <param name="dir">
		/// (Required)
		/// Specify the directory from where the xdc files and tcl files
		/// need to fetched.
		/// </param>
		/// <param name="new_name">(Required) Specify the name of the new run</param>
		/// <param name="synth_name">
		/// (Optional)
		/// Specify the name of the already existing synth run. This run
		/// will be the parent run for the newly created impl run
		/// Default: None
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Name Description
		/// </param>
		/// <param name="opt_more_options">
		/// (Optional)
		/// optional argument. Specify the value for opt_design step's
		/// more option property which will be set on newly created
		/// run. Default: None
		/// </param>
		/// <param name="place_more_options">
		/// (Optional)
		/// Specify the value for place_design step's more option
		/// property which will be set on newly created run. Default:
		/// None
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>None</returns>
		public TTCL create_rqs_run(string dir, string new_name, string synth_name = null, string opt_more_options = null, string place_more_options = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_rqs_run -dir <arg> -new_name <arg> [-synth_name <arg>] [-opt_more_options <arg>] [-place_more_options <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_rqs_run(dir, new_name, synth_name, opt_more_options, place_more_options, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// (User-written application) Create and write a single design checkpoint and stub files for a Block
		/// Design (BD), for use with third party synthesis tools. Perform synthesis as necessary.
		///
		///
		/// TCL Syntax: export_bd_synth [-force] [-keep] [-verbose] [-quiet] <file>
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
		/// See ug835-vivado-tcl-commands.pdf, page 515
		/// </summary>
		/// <param name="file">(Required) The Block Design file to write a synthesized checkpoint for</param>
		/// <param name="force">(Optional) Overwrite existing design checkpoint and stub files</param>
		/// <param name="keep">(Optional) Keep the temporary directory and project</param>
		/// <param name="verbose">(Optional) Print verbose messaging</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <returns>(none) An error will be thrown if the command is not successful</returns>
		public TTCL export_bd_synth(string file, bool? force = null, bool? keep = null, bool? verbose = null, bool? quiet = null)
		{
			// TCL Syntax: export_bd_synth [-force] [-keep] [-verbose] [-quiet] <file>
			_tcl.Entry(_builder.export_bd_synth(file, force, keep, verbose, quiet));
			return _tcl;
		}
		/// <summary>
		/// (User-written application) Export Tcl script for re-creating the current project
		///
		///
		/// TCL Syntax: write_project_tcl [-paths_relative_to <arg>] [-origin_dir_override <arg>] [-target_proj_dir <arg>] [-force] [-all_properties] [-no_copy_sources] [-no_ip_version] [-absolute_path] [-dump_project_info] [-use_bd_files] [-internal] [-validate] [-quiet] [-verbose] <file>
		///
		/// Creates a Tcl script to recreate the current project.
		/// The generated script will contain the Tcl commands for creating the project, setting the project
		/// type, creating filesets, adding/importing source files, defining runs and run properties.
		/// IMPORTANT! The new project will be created in the current working directory (CWD) where the
		/// generated Tcl script is sourced from. The script written out by write_project_tcl should be sourced
		/// in the same directory from which it was created. If you source the script from a different directory, you
		/// should first set the <origin_dir_loc> variable in Tcl shell to this alternate directory, or edit the script to
		/// define the <origin_dir> variable in the script in order to maintain the relative path between the CWD and
		/// the source files referenced in the script.
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
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The following command exports Tcl script for the current project and adds files that are local in
		/// this project. The recreated project will reference these files:
		/// write_project_tcl -no_copy_sources -use_bd_files recreate.tcl
		/// IMPORTANT! The -use_bd_files switch is required for use with -no_copy_sources in designs
		/// with block diagrams.
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
		/// See ug835-vivado-tcl-commands.pdf, page 1878
		/// </summary>
		/// <param name="file">(Required) Name of the tcl script file to generate</param>
		/// <param name="paths_relative_to">
		/// (Optional)
		/// Override the reference directory variable for source file
		/// relative paths Default: Script output directory path
		/// </param>
		/// <param name="origin_dir_override">
		/// (Optional)
		/// Set 'origin_dir' directory variable to the specified value
		/// (Default is value specified with the -paths_relative_to switch)
		/// Default: None
		/// </param>
		/// <param name="target_proj_dir">
		/// (Optional)
		/// Directory where the project needs to be restored Default:
		/// Current project directory path
		/// </param>
		/// <param name="force">(Optional) Overwrite existing tcl script file</param>
		/// <param name="all_properties">(Optional) Write all properties (default & non-default) for the project object(s)</param>
		/// <param name="no_copy_sources">
		/// (Optional)
		/// Do not import sources even if they were local in the original
		/// project Default: 1
		/// </param>
		/// <param name="no_ip_version">
		/// (Optional)
		/// Flag to not include the IP version as part of the IP VLNV in
		/// create_bd_cell commands. Default: 1
		/// </param>
		/// <param name="absolute_path">(Optional) Make all file paths absolute wrt the original project directory</param>
		/// <param name="dump_project_info">(Optional) Write object values</param>
		/// <param name="use_bd_files">(Optional) Use BD sources directly instead of writing out procs to create them</param>
		/// <param name="@internal">(Optional) Print basic header information in the generated tcl script</param>
		/// <param name="validate">
		/// (Optional)
		/// Runs a validate script before recreating the project. To test if
		/// the files and paths refrenced in the tcl file exists or not.
		/// </param>
		/// <param name="quiet">(Optional) Execute the command quietly, returning no messages from the command.</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>true (0) if success, false (1) otherwise</returns>
		public TTCL write_project_tcl(string file, string paths_relative_to = null, string origin_dir_override = null, string target_proj_dir = null, bool? force = null, bool? all_properties = null, bool? no_copy_sources = null, bool? no_ip_version = null, bool? absolute_path = null, bool? dump_project_info = null, bool? use_bd_files = null, bool? @internal = null, bool? validate = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_project_tcl [-paths_relative_to <arg>] [-origin_dir_override <arg>] [-target_proj_dir <arg>] [-force] [-all_properties] [-no_copy_sources] [-no_ip_version] [-absolute_path] [-dump_project_info] [-use_bd_files] [-internal] [-validate] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_project_tcl(file, paths_relative_to, origin_dir_override, target_proj_dir, force, all_properties, no_copy_sources, no_ip_version, absolute_path, dump_project_info, use_bd_files, @internal, validate, quiet, verbose));
			return _tcl;
		}
	}
}
