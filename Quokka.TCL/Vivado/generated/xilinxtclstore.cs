#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class xilinxtclstoreCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public xilinxtclstoreCommands(TTCL tcl, VivadoTCLBuilder builder)
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
		public TTCL convert_ngc(TCLObject files, String output_dir = null, String format = null, bool? add_to_project = null, bool? force = null, bool? quiet = null, bool? verbose = null)
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
		public TTCL copy_run(String name, TCLObject run, String parent_run = null, bool? verbose = null, bool? quiet = null)
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
		public TTCL export_bd_synth(TCLObject file, bool? force = null, bool? keep = null, bool? verbose = null, bool? quiet = null)
		{
			// TCL Syntax: export_bd_synth [-force] [-keep] [-verbose] [-quiet] <file>
			_tcl.Entry(_builder.export_bd_synth(file, force, keep, verbose, quiet));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// (User-written application) Generate and export IP/IPI user files from a project. This can be<br/>
		/// scoped to work on one or more IPs.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: export_ip_user_files [-of_objects &lt;arg&gt;] [-ip_user_files_dir &lt;arg&gt;] [-ipstatic_source_dir &lt;arg&gt;] [-lib_map_path &lt;arg&gt;] [-no_script] [-sync] [-reset] [-force] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Export IP user files repository with static, dynamic, netlist, verilog/vhdl stubs and memory<br/>
		/// initializaton files.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following command will export the dynamic files for the char_fifo IP to &lt;project&gt;/<br/>
		/// &lt;project&gt;.ip_user_files/ip/char_fifo directory, and IP static files to &lt;project&gt;/<br/>
		/// &lt;project&gt;.ip_user_files/ipstatic directory:<br/>
		/// export_ip_user_files -of_objects [get_ips char_fifo]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 517<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) IP,IPI or a fileset object Default: None</param>
		/// <param name="ip_user_files_dir">
		/// <para>
		/// (Optional)<br/>
		/// Directory path to simulation base directory (for static,<br/>
		/// dynamic, wrapper, netlist, script and MEM files) Default:<br/>
		/// None<br/>
		/// </para>
		/// </param>
		/// <param name="ipstatic_source_dir">(Optional) Directory path to the IP static files Default: None</param>
		/// <param name="lib_map_path">(Optional) Compiled simulation library directory path Default: Empty</param>
		/// <param name="no_script">(Optional) Do not export simulation scripts Default: 1</param>
		/// <param name="sync">(Optional) Delete IP/IPI dynamic and simulation script files</param>
		/// <param name="reset">(Optional) Delete all IP/IPI static, dynamic and simulation script files</param>
		/// <param name="force">(Optional) Overwrite files</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of files that were exported</returns>
		public TTCL export_ip_user_files(String of_objects = null, String ip_user_files_dir = null, String ipstatic_source_dir = null, String lib_map_path = null, bool? no_script = null, bool? sync = null, bool? reset = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: export_ip_user_files [-of_objects <arg>] [-ip_user_files_dir <arg>] [-ipstatic_source_dir <arg>] [-lib_map_path <arg>] [-no_script] [-sync] [-reset] [-force] [-quiet] [-verbose]
			_tcl.Entry(_builder.export_ip_user_files(of_objects, ip_user_files_dir, ipstatic_source_dir, lib_map_path, no_script, sync, reset, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// (User-written application) Export a script and associated data files (if any) for driving standalone<br/>
		/// simulation using the specified simulator.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: export_simulation [-simulator &lt;arg&gt;] [-of_objects &lt;arg&gt;] [-ip_user_files_dir &lt;arg&gt;] [-ipstatic_source_dir &lt;arg&gt;] [-lib_map_path &lt;arg&gt;] [-script_name &lt;arg&gt;] [-directory &lt;arg&gt;] [-runtime &lt;arg&gt;] [-define &lt;arg&gt;] [-generic &lt;arg&gt;] [-include &lt;arg&gt;] [-use_ip_compiled_libs] [-absolute_path] [-export_source_files] [-generate_hier_access] [-32bit] [-force] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Export a simulation script file for the target simulator. Currently the Cadence Incisive Enterprise<br/>
		/// Simulator (ies) and the Synopsys VCS MX simulator (vcs_mx) are supported. The generated<br/>
		/// script will contain simulator commands for compiling, elaborating and simulating the design.<br/>
		/// The command will retrieve the simulation compile order of specified objects, and export this<br/>
		/// information in a text file with the compiler commands and default options for the target<br/>
		/// simulator. The specified object can be either a simulation fileset or an IP. If the object is not<br/>
		/// specified, then the export_simulation command will generate the script for the simulation<br/>
		/// top.<br/>
		/// Any verilog include directories or file paths for the files containing verilog define statements will<br/>
		/// be added to the compiler command line.<br/>
		/// By default, the design source file and include directory paths in the compiler command line will<br/>
		/// be set relative to the "reference_dir" variable that is defined in the generated script. To make<br/>
		/// these paths absolute, specify the -absolute_path option.<br/>
		/// The command will also copy data files (if any) from the fileset, or from an IP, to the output<br/>
		/// directory. If the design contains "Verilog" sources, then the generated script will also copy "glbl.v"<br/>
		/// from the software installation path to the output directory.<br/>
		/// A default ".do" file will be created in the output directory for the target simulator that will be<br/>
		/// referred in the compiler commands in the script.<br/>
		/// Note: In order to perform simulation with the generated script, the simulation libraries must be compiled<br/>
		/// first using the compile_simlib command, with the compiled library directory path specified, when<br/>
		/// generating this script. The generated simulation script will automatically include the setup files for the<br/>
		/// target simulator from the compiled library directory.<br/>
		/// This command returns nothing.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following command generates a simulation script file in the current directory for the "IES"<br/>
		/// simulator:<br/>
		/// export_simulation -simulator ies -directory .<br/>
		/// The following command overwrites an existing script file in the current directory:<br/>
		/// export_simulation -force -simulator ies -directory .<br/>
		/// The following command generates a simulation script file named test_ies.sh in the ./<br/>
		/// test_sim directory:<br/>
		/// export_simulation -simulator ies -directory ./test_sim \<br/>
		/// -script_name test_ies.sh<br/>
		/// The following command generates a script file named top_tb_sim_ies.sh in the ./<br/>
		/// test_sim directory for a project with simulation top set to "top_tb". The command will also<br/>
		/// copy any data files (.mif, .coe, .dat, etc) to the ./test_sim directory:<br/>
		/// export_simulation -simulator ies -directory ./test_sim<br/>
		/// The following command generates a script file accum_0_sim_ies.sh for the "accum_0" IP in<br/>
		/// the specified output directory for the "IES" simulator:<br/>
		/// export_simulation -of_objects [get_files accum_0.xci] \<br/>
		/// -simulator ies -directory test_sim<br/>
		/// The following command generates a script file accum_0_sim_vcs_mx.sh for the "accum_0" IP<br/>
		/// in the specified output directory for the "VCS_MX" simulator:<br/>
		/// export_simulation -of_objects [get_ips accum_0] -simulator vcs_mx \<br/>
		/// -directory test_sim<br/>
		/// The following command generates a script file fifo_tb_sim_vcs_mx.sh for the simulation<br/>
		/// fileset "sim_fifo_test" whose top is set to "fifo_tb" in the specified output directory for the "IES"<br/>
		/// simulator:<br/>
		/// export_simulation -of_objects [get_filesets sim_fifo_test] \<br/>
		/// -simulator ies -directory test_sim<br/>
		/// The following command exports a script file top_tb_sim_vcs_mx.sh for the "VCS_MX"<br/>
		/// simulator in the specified output directory with the design source files compiled for 32 bit<br/>
		/// version of the simulator compiler (no 64 bit option will be added to the command line):<br/>
		/// export_simulation -force -32bit -simulator vcs_mx -directory test_bft_vcs_mx<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example will include /sim_libs/ius/lin64/lib/cds.lib file path in the ./<br/>
		/// test_sim/cds.lib file ("INCLUDE /sim_libs/ius/lin64/lib/cds.lib") for referencing the<br/>
		/// compiled libraries for "IES" simulator:<br/>
		/// export_simulation -lib_map_path "/sim_libs/ius/lin64/lib" \<br/>
		/// -simulator ies -directory "test_sim"<br/>
		/// The following example will include /sim_libs/vcs/lin64/lib/synopsys_sim.setup file<br/>
		/// path in the ./test_sim/synopsys_sim.setup file ("OTHERS=/sim_libs/vcs/lin64/lib/<br/>
		/// synopsys_sim.setup") for refrencing the compiled libraries for the "VCS_MX" simulator:<br/>
		/// export_simulation -lib_map_path "/sim_libs/vcs/lin64/lib" \<br/>
		/// -simulator vcs_mx -directory "test_sim"<br/>
		/// The following example generates a script file in ./test_sim/ies directory and then compiles,<br/>
		/// elaborates and simulates the design in "IES" simulator:<br/>
		/// export_simulation -lib_map_path "/sim_libs/ies/lin64/lib" \<br/>
		/// -simulator ies -directory "./test_sim/ies"<br/>
		/// cd test_sim/ies<br/>
		/// ./top_tb_sim_ies.sh<br/>
		/// The following example generates a script file in ./test_sim/vcs_mx directory and then<br/>
		/// compile, elaborate and simulate the design in "VCS_MX" simulator:<br/>
		/// export_simulation -lib_map_path "/sim_libs/vcs/lin64/lib" \<br/>
		/// -simulator vcs_mx -directory "./test_sim/vcs_mx"<br/>
		/// cd test_sim/vcs_mx<br/>
		/// ./top_tb_sim_vcs_mx.sh<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 519<br/>
		/// </para>
		/// </summary>
		/// <param name="simulator">
		/// <para>
		/// (Optional)<br/>
		/// Simulator for which the simulation script will be created<br/>
		/// (value=all|xsim|modelsim|questa|ies|xceliu m|vcs|<br/>
		/// riviera|activehdl) Default: all<br/>
		/// </para>
		/// </param>
		/// <param name="of_objects">(Optional) Export simulation script for the specified object Default: None</param>
		/// <param name="ip_user_files_dir">
		/// <para>
		/// (Optional)<br/>
		/// Directory path to the exported IP/BD (Block Design) user<br/>
		/// files (for static, dynamic and data files) Default: Empty<br/>
		/// </para>
		/// </param>
		/// <param name="ipstatic_source_dir">(Optional) Directory path to the exported IP/BD static files Default: Empty</param>
		/// <param name="lib_map_path">
		/// <para>
		/// (Optional)<br/>
		/// Precompiled simulation library directory path. If not<br/>
		/// specified, then please follow the instructions in the<br/>
		/// generated script header to manually provide the simulation<br/>
		/// library mapping information. Default: Empty<br/>
		/// </para>
		/// </param>
		/// <param name="script_name">
		/// <para>
		/// (Optional)<br/>
		/// Output script filename. If not specified, then a file with a<br/>
		/// default name will be created. Default: top_module.sh<br/>
		/// </para>
		/// </param>
		/// <param name="directory">
		/// <para>
		/// (Optional)<br/>
		/// Directory where the simulation script will be generated<br/>
		/// Default: export_sim<br/>
		/// </para>
		/// </param>
		/// <param name="runtime">
		/// <para>
		/// (Optional)<br/>
		/// Run simulation for this time (default:full simulation run or<br/>
		/// until a logical break or finish condition) Default: Empty<br/>
		/// </para>
		/// </param>
		/// <param name="define">
		/// <para>
		/// (Optional)<br/>
		/// Read verilog defines from the list specified with this switch<br/>
		/// Default: Empty<br/>
		/// </para>
		/// </param>
		/// <param name="generic">
		/// <para>
		/// (Optional)<br/>
		/// Read vhdl generics from the list specified with this switch<br/>
		/// Default: Empty<br/>
		/// </para>
		/// </param>
		/// <param name="include">
		/// <para>
		/// (Optional)<br/>
		/// Read include directory paths from the list specified with this<br/>
		/// switch Default: Empty<br/>
		/// </para>
		/// </param>
		/// <param name="use_ip_compiled_libs">
		/// <para>
		/// (Optional)<br/>
		/// Reference pre-compiled IP static library during compilation.<br/>
		/// This switch requires -ip_user_files_dir and -<br/>
		/// ipstatic_source_dir switches as well for generating scripts<br/>
		/// using pre-compiled IP library.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Name Description<br/>
		/// </para>
		/// </param>
		/// <param name="absolute_path">(Optional) Make all file paths absolute</param>
		/// <param name="export_source_files">(Optional) Copy IP/BD design files to output directory</param>
		/// <param name="generate_hier_access">(Optional) Extract path for hierarchical access simulation</param>
		/// <param name="_32bit">(Optional) Perform 32bit compilation</param>
		/// <param name="force">(Optional) Overwrite previous files</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>None</returns>
		public TTCL export_simulation(String simulator = null, String of_objects = null, String ip_user_files_dir = null, String ipstatic_source_dir = null, String lib_map_path = null, String script_name = null, String directory = null, String runtime = null, String define = null, String generic = null, String include = null, bool? use_ip_compiled_libs = null, bool? absolute_path = null, bool? export_source_files = null, bool? generate_hier_access = null, bool? _32bit = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: export_simulation [-simulator <arg>] [-of_objects <arg>] [-ip_user_files_dir <arg>] [-ipstatic_source_dir <arg>] [-lib_map_path <arg>] [-script_name <arg>] [-directory <arg>] [-runtime <arg>] [-define <arg>] [-generic <arg>] [-include <arg>] [-use_ip_compiled_libs] [-absolute_path] [-export_source_files] [-generate_hier_access] [-32bit] [-force] [-quiet] [-verbose]
			_tcl.Entry(_builder.export_simulation(simulator, of_objects, ip_user_files_dir, ipstatic_source_dir, lib_map_path, script_name, directory, runtime, define, generic, include, use_ip_compiled_libs, absolute_path, export_source_files, generate_hier_access, _32bit, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// (User-written application) Generate sources for hierarchical access simulation<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: generate_hier_access [-bypass &lt;arg&gt;] [-driver &lt;arg&gt;] [-directory &lt;arg&gt;] [-pseudo_top &lt;arg&gt;] [-testbench &lt;arg&gt;] [-log &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Generates sources for hierarchical access simulation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 540<br/>
		/// </para>
		/// </summary>
		/// <param name="bypass">(Optional) Hierarchical access module name Default: xil_dut_bypass</param>
		/// <param name="driver">(Optional) Signal driver template module name Default: xil_bypass_driver</param>
		/// <param name="directory">
		/// <para>
		/// (Optional)<br/>
		/// Output directory for the generated sources Default: current<br/>
		/// working directory<br/>
		/// </para>
		/// </param>
		/// <param name="pseudo_top">(Optional) Top-level pseudo testbench module name Default: None</param>
		/// <param name="testbench">(Optional) User design testbench module name Default: None</param>
		/// <param name="log">
		/// <para>
		/// (Optional)<br/>
		/// Simulator log containing hierarchical path information<br/>
		/// (required for the non-Vivado standalone flow only) Default:<br/>
		/// None<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>None</returns>
		public TTCL generate_hier_access(String bypass = null, String driver = null, String directory = null, String pseudo_top = null, String testbench = null, String log = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_hier_access [-bypass <arg>] [-driver <arg>] [-directory <arg>] [-pseudo_top <arg>] [-testbench <arg>] [-log <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.generate_hier_access(bypass, driver, directory, pseudo_top, testbench, log, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// (User-written application) Extract IP static files from the project or repository and prepare it for<br/>
		/// compile_simlib<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: setup_ip_static_library [-directory &lt;arg&gt;] [-ip_repo_path &lt;arg&gt;] [-ips &lt;arg&gt;] [-library &lt;arg&gt;] [-project] [-install] [-no_update_catalog] [-force] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Retrieve static simulation files for IP cores used in the current project, or from the Xilinx IP<br/>
		/// catalog, and create a source library for the compile_simlib command to use for compiling the<br/>
		/// IP files for a specified simulator.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following command will build static library for all the IPs in the current project in ./<br/>
		/// static_compiled_lib:<br/>
		/// setup_ip_static_library -project<br/>
		/// The following command will build static library for the current project in /work/simlib. The<br/>
		/// command will create the specified directory if it does not exist:<br/>
		/// setup_ip_static_library -directory /work/simlib -project<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1701<br/>
		/// </para>
		/// </summary>
		/// <param name="directory">(Optional) Extract static files in the specified directory Default: None</param>
		/// <param name="ip_repo_path">
		/// <para>
		/// (Optional)<br/>
		/// Extract static files from the specified IP repository path<br/>
		/// Default: None<br/>
		/// </para>
		/// </param>
		/// <param name="ips">(Optional) Extract static files for the specified IPs only Default: Empty</param>
		/// <param name="library">(Optional) Extract static files for the specified IP library Default: Empty</param>
		/// <param name="project">(Optional) Extract static files for the current project</param>
		/// <param name="install">(Optional) Extract static files for the IP catalog</param>
		/// <param name="no_update_catalog">(Optional) Do no update IP catalog Default: 1</param>
		/// <param name="force">(Optional) Overwrite static files</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>None</returns>
		public TTCL setup_ip_static_library(String directory = null, String ip_repo_path = null, String ips = null, String library = null, bool? project = null, bool? install = null, bool? no_update_catalog = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: setup_ip_static_library [-directory <arg>] [-ip_repo_path <arg>] [-ips <arg>] [-library <arg>] [-project] [-install] [-no_update_catalog] [-force] [-quiet] [-verbose]
			_tcl.Entry(_builder.setup_ip_static_library(directory, ip_repo_path, ips, library, project, install, no_update_catalog, force, quiet, verbose));
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
		public TTCL write_project_tcl(TCLObject file, String paths_relative_to = null, String origin_dir_override = null, String target_proj_dir = null, bool? force = null, bool? all_properties = null, bool? no_copy_sources = null, bool? no_ip_version = null, bool? absolute_path = null, bool? dump_project_info = null, bool? use_bd_files = null, bool? @internal = null, bool? validate = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_project_tcl [-paths_relative_to <arg>] [-origin_dir_override <arg>] [-target_proj_dir <arg>] [-force] [-all_properties] [-no_copy_sources] [-no_ip_version] [-absolute_path] [-dump_project_info] [-use_bd_files] [-internal] [-validate] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_project_tcl(file, paths_relative_to, origin_dir_override, target_proj_dir, force, all_properties, no_copy_sources, no_ip_version, absolute_path, dump_project_info, use_bd_files, @internal, validate, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
