#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
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
		/// <para>
		/// (User-written application) Convert all provided NGC files to a supported format<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: convert_ngc [-output_dir &lt;arg&gt;] [-format &lt;arg&gt;] [-add_to_project] [-force] [-quiet] [-verbose] &lt;files&gt;
		/// <br/>
		/// <para>
		/// Converts provided NGC files to a supported format.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example will convert test.ngc to test.edn, with verbose messaging. The<br/>
		/// test.edn file will be added to the current open project:<br/>
		/// convert_ngc ./test.ngc -add_to_project -verbose<br/>
		/// The following example will convert test.ngc to test.edn. The test.edn file will be placed<br/>
		/// in the ./output directory. If ./output/test.edn exists it will be replaced:<br/>
		/// convert_ngc ./test.ngc -output_dir output -force<br/>
		/// The following example converts all NGC files in the current directory and in all sub-directories:<br/>
		/// convert_ngc [ glob ./**/*.ngc ] [ glob ./*.ngc ]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 213<br/>
		/// </para>
		/// </summary>
		/// <param name="files">(Required) A list of NGC files to convert</param>
		/// <param name="output_dir">
		/// <para>
		/// (Optional)<br/>
		/// Directory to place all output, else the output is placed at<br/>
		/// location of NGC file Default: Script output directory path<br/>
		/// </para>
		/// </param>
		/// <param name="format">
		/// <para>
		/// (Optional)<br/>
		/// Accepts 'Verilog' or 'EDIF' (Default: EDIF), specifies the<br/>
		/// desired output format Default: EDIF<br/>
		/// </para>
		/// </param>
		/// <param name="add_to_project">
		/// <para>
		/// (Optional)<br/>
		/// Adds the output files to the current project, if no project is<br/>
		/// open, then this option does nothing<br/>
		/// </para>
		/// </param>
		/// <param name="force">
		/// <para>
		/// (Optional)<br/>
		/// Force overwriting of files that already exist on disk, replaces<br/>
		/// files in project if add_to_project switch was specified<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>None</returns>
		public TTCL convert_ngc(String files, String output_dir = null, String format = null, bool? add_to_project = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: convert_ngc [-output_dir <arg>] [-format <arg>] [-add_to_project] [-force] [-quiet] [-verbose] <files>
			_tcl.Entry(_builder.convert_ngc(files, output_dir, format, add_to_project, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// (User-written application) Copy a run from an already existing run, source-run, to a new copy of<br/>
		/// that run, destination-run.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: copy_run [-parent_run &lt;arg&gt;] [-verbose] -name &lt;arg&gt; [-quiet] &lt;run&gt;
		/// <br/>
		/// <para>
		/// Copies an existing synthesis or implementation run.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example will copy synth_1 run into a new synth_2 run:<br/>
		/// copy_run -name synth_2 [get_runs synth_1]<br/>
		/// The following example will copy the impl_1 run into a new run called impl_2, and assign synth_2<br/>
		/// as the parent of the new run:<br/>
		/// copy_run -name impl_2 [get_runs impl_1] -parent_run synth_2<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 220<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Specify the name of the new run</param>
		/// <param name="run">(Required) The run to be copied, accepts name or run object</param>
		/// <param name="parent_run">
		/// <para>
		/// (Optional)<br/>
		/// Specify the synthesis run for the new implementation run,<br/>
		/// accepts name or run object (Default: same as source run)<br/>
		/// Default: None<br/>
		/// </para>
		/// </param>
		/// <param name="verbose">(Optional) Print detailed information as the copy progresses</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <returns>The new run object</returns>
		public TTCL copy_run(String name, String run, String parent_run = null, bool? verbose = null, bool? quiet = null)
		{
			// TCL Syntax: copy_run [-parent_run <arg>] [-verbose] -name <arg> [-quiet] <run>
			_tcl.Entry(_builder.copy_run(name, run, parent_run, verbose, quiet));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// (User-written application) Creates and launches a new run based on the suggestions by<br/>
		/// report_qor_suggestions. This proc looks for 5 files in the directory specified by the user.<br/>
		/// 1.RQSPreSynth_&lt;newProjName&gt;.xdc 2.RQSImplCommon_&lt;newProjName&gt;.xdc<br/>
		/// 3.RQSPreImpl_&lt;newProjName&gt;.xdc 4.RQSPreImpl_&lt;newProjName&gt;.tcl<br/>
		/// 5.RQSImplCommon_&lt;newProjName&gt;.tcl. There are 2 flows. One is creating both synth and impl<br/>
		/// runs and the other is creating only impl run making user specified synth run as the parent for the<br/>
		/// newly created impl run. In the first flow, we create a new synth run based on the current impl<br/>
		/// run's parent run (i,e current synth run). We create a new constraint fileset and add the current<br/>
		/// synth run's constraint fileset's files to that. And we add RQSPreSynth_&lt;&gt;.xdc file to newly<br/>
		/// created constraint set. We create a impl run based on the current impl run. We create a impl run<br/>
		/// constraint (if it is not same as the one that has already been created), and add the current impl<br/>
		/// run's constraint fileset's files to that. We also add RQSImplCommon_&lt;&gt;.xdc to new impl<br/>
		/// constraint fileset. We set STEPS.OPT_DESIGN.TCL.PRE property of newly created impl run to<br/>
		/// RQSImplCommon_&lt;&gt;.tcl file. In this flow, we ignore RQSPreImpl_&lt;&gt;.xdc/tcl files. In the second<br/>
		/// flow, user specified synth run is used as parent for the newly created impl run. So there is no<br/>
		/// synth run creation. We create impl run based on current impl run and user specified synth run.<br/>
		/// We create a new impl constraint fileset and add fileset to that form the current impl run's<br/>
		/// constraint fileset. We also add RQSImplCommon_&lt;&gt;.xdc , RQSPreImpl_&lt;&gt;.xdc files. If<br/>
		/// RQSPreImpl_&lt;&gt;.tcl file is available, it is set as STEPS.OPT_DESIGN.TCL.PRE property for new<br/>
		/// impl run otherwise RQSImplCommon_&lt;&gt;.tcl is set. In both the flows adding or setting files is<br/>
		/// subject to availability of those files in the output directory.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_rqs_run -dir &lt;arg&gt; -new_name &lt;arg&gt; [-synth_name &lt;arg&gt;] [-opt_more_options &lt;arg&gt;] [-place_more_options &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Creates and launches a new implementation run based on the suggestions provided by<br/>
		/// report_qor_suggestions.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example will create and launch a new run, exp_1, using the constraints files from<br/>
		/// the specified directory:<br/>
		/// create_rqs_run -dir path_to_dir -new_name exp_1 -synth_name synth_1 \<br/>
		/// -opt_more_options optVal -place_more_options placeVal<br/>
		/// TIP: The constraints were previously created using the -output_dir option of the<br/>
		/// report_qor_suggestions command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 356<br/>
		/// </para>
		/// </summary>
		/// <param name="dir">
		/// <para>
		/// (Required)<br/>
		/// Specify the directory from where the xdc files and tcl files<br/>
		/// need to fetched.<br/>
		/// </para>
		/// </param>
		/// <param name="new_name">(Required) Specify the name of the new run</param>
		/// <param name="synth_name">
		/// <para>
		/// (Optional)<br/>
		/// Specify the name of the already existing synth run. This run<br/>
		/// will be the parent run for the newly created impl run<br/>
		/// Default: None<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Name Description<br/>
		/// </para>
		/// </param>
		/// <param name="opt_more_options">
		/// <para>
		/// (Optional)<br/>
		/// optional argument. Specify the value for opt_design step's<br/>
		/// more option property which will be set on newly created<br/>
		/// run. Default: None<br/>
		/// </para>
		/// </param>
		/// <param name="place_more_options">
		/// <para>
		/// (Optional)<br/>
		/// Specify the value for place_design step's more option<br/>
		/// property which will be set on newly created run. Default:<br/>
		/// None<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>None</returns>
		public TTCL create_rqs_run(String dir, String new_name, String synth_name = null, String opt_more_options = null, String place_more_options = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_rqs_run -dir <arg> -new_name <arg> [-synth_name <arg>] [-opt_more_options <arg>] [-place_more_options <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_rqs_run(dir, new_name, synth_name, opt_more_options, place_more_options, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// (User-written application) Create and write a single design checkpoint and stub files for a Block<br/>
		/// Design (BD), for use with third party synthesis tools. Perform synthesis as necessary.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: export_bd_synth [-force] [-keep] [-verbose] [-quiet] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Runs synthesis for a block design (.bd), integrates the design along with any needed sub-designs<br/>
		/// (e.g. out-of-context synthesized IP), and writes out a single design checkpoint (.dcp) of the<br/>
		/// entire synthesized design, as well as HDL stub files, for use in other synthesis tools. The output<br/>
		/// files will be placed in the same directory as the source BD file.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following command will generate a synthesis checkpoint, with stub files, for the specified<br/>
		/// block design:<br/>
		/// export_bd_synth [get_files block_1.bd]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 515<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) The Block Design file to write a synthesized checkpoint for</param>
		/// <param name="force">(Optional) Overwrite existing design checkpoint and stub files</param>
		/// <param name="keep">(Optional) Keep the temporary directory and project</param>
		/// <param name="verbose">(Optional) Print verbose messaging</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <returns>(none) An error will be thrown if the command is not successful</returns>
		public TTCL export_bd_synth(String file, bool? force = null, bool? keep = null, bool? verbose = null, bool? quiet = null)
		{
			// TCL Syntax: export_bd_synth [-force] [-keep] [-verbose] [-quiet] <file>
			_tcl.Entry(_builder.export_bd_synth(file, force, keep, verbose, quiet));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// (User-written application) Export Tcl script for re-creating the current project<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_project_tcl [-paths_relative_to &lt;arg&gt;] [-origin_dir_override &lt;arg&gt;] [-target_proj_dir &lt;arg&gt;] [-force] [-all_properties] [-no_copy_sources] [-no_ip_version] [-absolute_path] [-dump_project_info] [-use_bd_files] [-internal] [-validate] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Creates a Tcl script to recreate the current project.<br/>
		/// The generated script will contain the Tcl commands for creating the project, setting the project<br/>
		/// type, creating filesets, adding/importing source files, defining runs and run properties.<br/>
		/// IMPORTANT! The new project will be created in the current working directory (CWD) where the<br/>
		/// generated Tcl script is sourced from. The script written out by write_project_tcl should be sourced<br/>
		/// in the same directory from which it was created. If you source the script from a different directory, you<br/>
		/// should first set the &lt;origin_dir_loc&gt; variable in Tcl shell to this alternate directory, or edit the script to<br/>
		/// define the &lt;origin_dir&gt; variable in the script in order to maintain the relative path between the CWD and<br/>
		/// the source files referenced in the script.<br/>
		/// This Tcl project script and the various design sources can be stored in a version control system<br/>
		/// for source file management and project archival.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example exports Tcl script named recreate.tcl for the current project:<br/>
		/// write_project_tcl recreate.tcl<br/>
		/// The following example exports a Tcl script named recreate.tcl for the current project in<br/>
		/// the ./script directory and specifies the /tmp/test directory for the create_project<br/>
		/// command. When the recreate.tcl script is run in the Vivado Tcl shell, the project will be re-created in /tmp/test directory:<br/>
		/// write_project_tcl -target_proj_dir "/tmp/test" ./script/recreate.tcl<br/>
		/// The following command exports Tcl script for the current project and writes all the properties,<br/>
		/// both default or non-default values:<br/>
		/// write_project_tcl -all_properties recreate.tcl<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following command exports Tcl script for the current project and adds files that are local in<br/>
		/// this project. The recreated project will reference these files:<br/>
		/// write_project_tcl -no_copy_sources -use_bd_files recreate.tcl<br/>
		/// IMPORTANT! The -use_bd_files switch is required for use with -no_copy_sources in designs<br/>
		/// with block diagrams.<br/>
		/// The following command exports recreate.tcl script for the current project in the current<br/>
		/// working directory, creates a new project in ./my_test directory, prints the list of files in the<br/>
		/// new project, prints the current project settings and then closes the newly created project:<br/>
		/// open_project ./test/test.xpr<br/>
		/// write_project_tcl -force recreate.tcl<br/>
		/// close_project<br/>
		/// file mkdir my_test<br/>
		/// cd my_test<br/>
		/// source ../recreate.tcl<br/>
		/// get_files -of_objects [get_filesets sources_1]<br/>
		/// report_property [current_project]<br/>
		/// close_project<br/>
		/// The following command creates a new project named bft_test, adds files to the project, sets the<br/>
		/// fileset property, exports a tcl script named bft.tcl in the current working directory, creates a<br/>
		/// new project in ./my_bft directory, prints the list of files in the new project (test_1.v and<br/>
		/// test_2.v), prints the "verilog_define" property value and then closes the newly created project:<br/>
		/// create_project bft_test ./bft_test<br/>
		/// add_files test_1.v<br/>
		/// add_files test_2.v<br/>
		/// set_property verilog_define {a=10} [get_filesets sources_1]<br/>
		/// write_project_tcl -force bft.tcl<br/>
		/// close_project<br/>
		/// file mkdir my_bft<br/>
		/// cd my_bft<br/>
		/// source ../bft.tcl<br/>
		/// get_files -of_objects [get_filesets sources_1]<br/>
		/// get_property verilog_define [get_filesets sources_1]<br/>
		/// close_project<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1878<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Name of the tcl script file to generate</param>
		/// <param name="paths_relative_to">
		/// <para>
		/// (Optional)<br/>
		/// Override the reference directory variable for source file<br/>
		/// relative paths Default: Script output directory path<br/>
		/// </para>
		/// </param>
		/// <param name="origin_dir_override">
		/// <para>
		/// (Optional)<br/>
		/// Set 'origin_dir' directory variable to the specified value<br/>
		/// (Default is value specified with the -paths_relative_to switch)<br/>
		/// Default: None<br/>
		/// </para>
		/// </param>
		/// <param name="target_proj_dir">
		/// <para>
		/// (Optional)<br/>
		/// Directory where the project needs to be restored Default:<br/>
		/// Current project directory path<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Overwrite existing tcl script file</param>
		/// <param name="all_properties">(Optional) Write all properties (default &amp; non-default) for the project object(s)</param>
		/// <param name="no_copy_sources">
		/// <para>
		/// (Optional)<br/>
		/// Do not import sources even if they were local in the original<br/>
		/// project Default: 1<br/>
		/// </para>
		/// </param>
		/// <param name="no_ip_version">
		/// <para>
		/// (Optional)<br/>
		/// Flag to not include the IP version as part of the IP VLNV in<br/>
		/// create_bd_cell commands. Default: 1<br/>
		/// </para>
		/// </param>
		/// <param name="absolute_path">(Optional) Make all file paths absolute wrt the original project directory</param>
		/// <param name="dump_project_info">(Optional) Write object values</param>
		/// <param name="use_bd_files">(Optional) Use BD sources directly instead of writing out procs to create them</param>
		/// <param name="internal">(Optional) Print basic header information in the generated tcl script</param>
		/// <param name="validate">
		/// <para>
		/// (Optional)<br/>
		/// Runs a validate script before recreating the project. To test if<br/>
		/// the files and paths refrenced in the tcl file exists or not.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Execute the command quietly, returning no messages from the command.</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>true (0) if success, false (1) otherwise</returns>
		public TTCL write_project_tcl(String file, String paths_relative_to = null, String origin_dir_override = null, String target_proj_dir = null, bool? force = null, bool? all_properties = null, bool? no_copy_sources = null, bool? no_ip_version = null, bool? absolute_path = null, bool? dump_project_info = null, bool? use_bd_files = null, bool? @internal = null, bool? validate = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_project_tcl [-paths_relative_to <arg>] [-origin_dir_override <arg>] [-target_proj_dir <arg>] [-force] [-all_properties] [-no_copy_sources] [-no_ip_version] [-absolute_path] [-dump_project_info] [-use_bd_files] [-internal] [-validate] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_project_tcl(file, paths_relative_to, origin_dir_override, target_proj_dir, force, all_properties, no_copy_sources, no_ip_version, absolute_path, dump_project_info, use_bd_files, @internal, validate, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
