#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class ProjectCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public ProjectCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// <para>
		/// Add sources to the active fileset<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: add_files [-fileset &lt;arg&gt;] [-of_objects &lt;args&gt;] [-norecurse] [-copy_to &lt;arg&gt;] [-force] [-scan_for_includes] [-quiet] [-verbose] [&lt;files&gt;...]
		/// <br/>
		/// <para>
		/// Adds one or more source files, or the source file contents of one or more directories, to the<br/>
		/// specified fileset in the current project. Valid source files include HDL sources (VHDL, Verilog,<br/>
		/// SystemVerilog, and related header files), netlist sources (DCP, EDIF, and NGC), and memory<br/>
		/// interface files (BMM, MIF, MEM, ELF).<br/>
		/// IP and Block Design sources are not added through the add_files command. These are<br/>
		/// compound files that are supported by separate commands such as import_ip, read_bd, and<br/>
		/// read_ip.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// For every file added to a project the Vivado Design Suite attempts to store and maintain both a<br/>
		/// relative path and an absolute path to the file or directory. When a project is opened, these paths<br/>
		/// are used to locate the files and directories. By default the Vivado Design Suite applies a Relative<br/>
		/// First approach to resolving paths, searching the relative path first, then the absolute path. You<br/>
		/// can use the PATH_MODE property to change how the Vivado tool resolves file paths or<br/>
		/// properties for specific objects. For more information, see the Vivado Design Suite Properties<br/>
		/// Reference Guide (UG912).<br/>
		/// IMPORTANT! Adding multiple files one at a time can cause noticeable performance degradation. It is<br/>
		/// more efficient to use a single add_files command to import a list of files:<br/>
		/// add_files {file1 file2 file3 ... fileN}<br/>
		/// The Vivado tool does not read the contents of a file automatically when the file is added to the<br/>
		/// project with add_files, but rather reads the file contents when they are needed. For instance,<br/>
		/// a constraints file is not read when added to the design until needed by synthesis, timing, or<br/>
		/// implementation. To read the file at the time of adding it to the design, use the read_xxx<br/>
		/// command instead.<br/>
		/// TIP: When running the Vivado tool in Non-Project mode, in which there is no project file to maintain and<br/>
		/// manage the various project source files, you should use the read_xxx commands to read the contents of<br/>
		/// source files into the in-memory design. Refer to the Vivado Design Suite User Guide: Design Flows<br/>
		/// Overview (UG892) for more information on Non-Project mode.<br/>
		/// The add_files command adds them by reference to the specified fileset. This is different from<br/>
		/// the import_files command, which copies the file into the local project folders as well as<br/>
		/// adding them to the specified fileset.<br/>
		/// This command returns the files that were added, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example adds a file called rtl.v to the current project:<br/>
		/// add_files rtl.v<br/>
		/// In the preceding example the tool looks for the rtl.v file in the current working directory since no<br/>
		/// file path is specified, and the file is added to the source fileset as a default since no fileset is<br/>
		/// specified.<br/>
		/// The following example adds a file called top.xdc to the constrs_1 constraint fileset, as well<br/>
		/// as any appropriate source files found in the project_1 directory, and its subdirectories:<br/>
		/// add_files -fileset constrs_1 -quiet c:/Design/top.xdc c:/Design/project_1<br/>
		/// In addition, the tool ignores any command line errors because the -quiet argument was<br/>
		/// specified.<br/>
		/// If the -norecurse option had been specified then only constraint files found in the<br/>
		/// project_1 directory would have been added, but subdirectories would not be searched.<br/>
		/// The following example adds an existing IP core file to the current project:<br/>
		/// add_files -norecurse C:/Data/ip/c_addsub_v11_0_0.xci<br/>
		/// Note: Use the import_ip command to import the IP file into the local project folders.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example reads a top-level design netlist, and the char_fifo IP in a Non-Project<br/>
		/// Mode design:<br/>
		/// # Read top-level EDIF and IP DCP<br/>
		/// read_edif ./sources/wave_gen.edif<br/>
		/// add_files ./my_IP/char_fifo/char_fifo.xci<br/>
		/// Note: Either add_files or read_ip can be used reading in an IP core. All output products of the IP,<br/>
		/// including a design checkpoint ( DCP), will be read as needed.<br/>
		/// The following example adds an existing DSP module, created in System Generator, into the<br/>
		/// current project:<br/>
		/// add_files C:/Data/model1.mdl<br/>
		/// Note: Use the create_sysgen command to use System Generator to create a new DSP module.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 44<br/>
		/// </para>
		/// </summary>
		/// <param name="fileset">(Optional) Fileset name</param>
		/// <param name="of_objects">(Optional) Filesets or sub-designs or RMs to add the files to</param>
		/// <param name="norecurse">(Optional) Do not recursively search in specified directories</param>
		/// <param name="copy_to">(Optional) Copy the file to the specified directory before adding it to project</param>
		/// <param name="force">(Optional) Overwrite the existing file when -copy_to is used</param>
		/// <param name="scan_for_includes">(Optional) Scan and add any included files found in the fileset's RTL sources</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="files">
		/// <para>
		/// (Optional)<br/>
		/// Name of the files and/or directories to add. Must be<br/>
		/// specified if -scan_for_includes is not used.<br/>
		/// </para>
		/// </param>
		/// <returns>list of file objects that were added</returns>
		public TTCL add_files(String fileset = null, TCLParameterList of_objects = null, bool? norecurse = null, String copy_to = null, bool? force = null, bool? scan_for_includes = null, bool? quiet = null, bool? verbose = null, TCLObjectList files = null)
		{
			// TCL Syntax: add_files [-fileset <arg>] [-of_objects <args>] [-norecurse] [-copy_to <arg>] [-force] [-scan_for_includes] [-quiet] [-verbose] [<files>...]
			_tcl.Entry(_builder.add_files(fileset, of_objects, norecurse, copy_to, force, scan_for_includes, quiet, verbose, files));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Add a new bus interface to a peripheral.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: add_peripheral_interface -interface_mode &lt;arg&gt; -axi_type &lt;arg&gt; [-quiet] [-verbose] &lt;name&gt; &lt;peripheral&gt;
		/// <br/>
		/// <para>
		/// Add an AXI bus interface to a peripheral created with the create_peripheral command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 57<br/>
		/// </para>
		/// </summary>
		/// <param name="interface_mode">(Required) Mode of an interface, supported option - master,slave.</param>
		/// <param name="axi_type">(Required) Type of a axi interface, supported option - lite,full,stream.</param>
		/// <param name="name">(Required) Name to initialize the newly added element e.g S1_AXI, M1_AXI</param>
		/// <param name="peripheral">(Required) Peripheral object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL add_peripheral_interface(String interface_mode, String axi_type, TCLObject name, TCLObject peripheral, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: add_peripheral_interface -interface_mode <arg> -axi_type <arg> [-quiet] [-verbose] <name> <peripheral>
			_tcl.Entry(_builder.add_peripheral_interface(interface_mode, axi_type, name, peripheral, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Applies board connections to given designs<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: apply_board_connection [-board_interface &lt;arg&gt;] -ip_intf &lt;arg&gt; -diagram &lt;arg&gt; [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Connects the interface pin of an IP core in the specified block design to the interface of the<br/>
		/// current board part in the current project or design.<br/>
		/// The board part provides a representation of the Xilinx device in the context of the board-level<br/>
		/// system, and can help define key aspects of the design, such as clock constraints, I/O port<br/>
		/// assignments, and supported interfaces. The board part file stores information regarding board<br/>
		/// attributes. The file, called board_part.xml, is located in the data/boards/board_parts<br/>
		/// folder of the Vivado Design Suite installation area.<br/>
		/// The command lets you quickly connect compatible interface pins of an IP integrator block design<br/>
		/// to the appropriate interface definition on the current board part. To make the connection<br/>
		/// between the IP core to the board part, the IP integrator of the Vivado Design Suite adds an<br/>
		/// external interface port and interface connection to the block design. The added external<br/>
		/// interface port is named for the specified board part interface.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The apply_board_connection commands uses the available interfaces of the current board<br/>
		/// part defined in the project. An error is returned if the project uses a target part rather than a<br/>
		/// target board. You can use the current_board_part command to identify the target board<br/>
		/// used by the project, or get_board_parts to list the boards available for use by the project.<br/>
		/// Use the get_board_part_interfaces command to determine the list of available interfaces<br/>
		/// on the current board.<br/>
		/// To remove an existing IP interface connection, specify the -ip_intf option, but do not specify<br/>
		/// the -board_interface. If no board part interface is specified, the IP interface pin is<br/>
		/// disconnected.<br/>
		/// This command returns a transcript of it actions, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 103<br/>
		/// </para>
		/// </summary>
		/// <param name="ip_intf">
		/// <para>
		/// (Required)<br/>
		/// Full path of IP interface name to which board automation<br/>
		/// need to be applied.<br/>
		/// </para>
		/// </param>
		/// <param name="diagram">(Required) The IP Integrator design name.</param>
		/// <param name="board_interface">(Optional) Board interface name to which connection need to be applied.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>sucess/failure status of applied action.</returns>
		public TTCL apply_board_connection(String ip_intf, String diagram, String board_interface = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: apply_board_connection [-board_interface <arg>] -ip_intf <arg> -diagram <arg> [-quiet] [-verbose]
			_tcl.Entry(_builder.apply_board_connection(ip_intf, diagram, board_interface, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Archive the current project<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: archive_project [-temp_dir &lt;arg&gt;] [-force] [-exclude_run_results] [-include_config_settings] [-include_runs_in_progress] [-include_local_ip_cache] [-quiet] [-verbose] [&lt;file&gt;]
		/// <br/>
		/// <para>
		/// Archives a project to store as backup, or to encapsulate the design and send it to a remote site.<br/>
		/// The tool parses the hierarchy of the design, copies the required source files, include files, and<br/>
		/// remote files from the library directories, copies the constraint files, copies the results of the<br/>
		/// various synthesis, simulation, and implementation runs, and then creates a ZIP file of the project.<br/>
		/// TIP: In order to archive the tcl.pre and tcl.post scripts, associated with the synthesis and implementation<br/>
		/// steps in the Design Run Settings dialog box, you must add these script files to the project as design sources.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// An alternative method of archiving the project is using write_project_tcl to create a Tcl<br/>
		/// script that will recreate the project in its current form.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following command archives the current project:<br/>
		/// archive_project<br/>
		/// Note: The project archive is named &lt;project_name&gt;.zip because no file name is specified.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example specifies project_3 as the current project, and then archives that<br/>
		/// project into a file called proj3.zip:<br/>
		/// current_project project_3<br/>
		/// archive_project -force -exclude_run_results proj3.zip<br/>
		/// Note: The use of the -force argument causes the tool to overwrite the proj3.zip file if one exists. The<br/>
		/// use of the -exclude_run_results argument causes the tool to leave any results from synthesis or<br/>
		/// implementation runs out of the archive. The various runs defined in the project are included in the archive,<br/>
		/// but not any of the results.<br/>
		/// The following command archives the current project in the specified file, overwrites an existing<br/>
		/// file if needed, excludes the run results, and includes any configuration settings used when<br/>
		/// launching the Vivado tool:<br/>
		/// archive_project -force mb1_archive.zip -temp_dir C:/Data/Temp \<br/>
		/// -exclude_run_results -include_config_settings<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 109<br/>
		/// </para>
		/// </summary>
		/// <param name="temp_dir">(Optional) specify temporary location to save project copy to archive Default: .</param>
		/// <param name="force">(Optional) Overwrite existing archived file</param>
		/// <param name="exclude_run_results">(Optional) Exclude run results from the archive</param>
		/// <param name="include_config_settings">
		/// <para>
		/// (Optional)<br/>
		/// Include current project environment configuration settings/<br/>
		/// files in archive<br/>
		/// </para>
		/// </param>
		/// <param name="include_runs_in_progress">
		/// <para>
		/// (Optional)<br/>
		/// Include run result even if the run is in progress, this switch<br/>
		/// will be ignored if -exclude_run_results is specified<br/>
		/// </para>
		/// </param>
		/// <param name="include_local_ip_cache">(Optional) Include IP cache results in the archive</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="file">(Optional) Name of the archive file</param>
		/// <returns>true</returns>
		public TTCL archive_project(String temp_dir = null, bool? force = null, bool? exclude_run_results = null, bool? include_config_settings = null, bool? include_runs_in_progress = null, bool? include_local_ip_cache = null, bool? quiet = null, bool? verbose = null, TCLObject file = null)
		{
			// TCL Syntax: archive_project [-temp_dir <arg>] [-force] [-exclude_run_results] [-include_config_settings] [-include_runs_in_progress] [-include_local_ip_cache] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.archive_project(temp_dir, force, exclude_run_results, include_config_settings, include_runs_in_progress, include_local_ip_cache, quiet, verbose, file));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Auto detect the XPM Libraries that are used in the design and set the XPM_LIBRARIES project<br/>
		/// property.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: auto_detect_xpm [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This command collects the list of Xilinx Parameterized Macros (XPM) used in RTL design files and<br/>
		/// sets the XPM_LIBRARIES property. Because it identifies XPM used in the RTL source files, it<br/>
		/// must be used after the RTL files are read or added to the design as shown in the example.<br/>
		/// TIP: This command is intended for use in non-project mode, and is not needed for project-based flows.<br/>
		/// This command will find all the XPMs used in the user RTL and update the XPM_LIBRARIES<br/>
		/// property on the current project. Synthesis and simulation will use the XPM_LIBRARIES property<br/>
		/// to properly support these macros.<br/>
		/// This command returns nothing, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reads the specified RTL file, and then uses auto_detect_xpm to define<br/>
		/// the XPM_LIBRARIES used in the files:<br/>
		/// read_verilog ../top_bgRAM_173_0.v<br/>
		/// read_xdc ../top_bgRAM_173_0.xdc<br/>
		/// auto_detect_xpm<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 116<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL auto_detect_xpm(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: auto_detect_xpm [-quiet] [-verbose]
			_tcl.Entry(_builder.auto_detect_xpm(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Check if a module can be referenced<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: can_resolve_reference [-quiet] [-verbose] &lt;module&gt;...
		/// <br/>
		/// <para>
		/// This command is used to validate reference to modules prior to trying to import them into the<br/>
		/// design. Its primary use is in scripts like the script produced by the write_bd_tcl command,<br/>
		/// though you can use it in your own scripts as well.<br/>
		/// This command returns 0 if the reference cannot be resolved, or returns 1 if it can be resolved.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example determines if the reference to the specified module can be resolved:<br/>
		/// can_resolve_reference clk_div<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 124<br/>
		/// </para>
		/// </summary>
		/// <param name="module">(Required) module name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL can_resolve_reference(TCLObjectList module, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: can_resolve_reference [-quiet] [-verbose] <module>...
			_tcl.Entry(_builder.can_resolve_reference(module, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Check HDL syntax in the supplied fileset or active fileset.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: check_syntax [-fileset &lt;arg&gt;] [-return_string] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Parses Verilog, SystemVerilog, and VHDL source files and generates syntax warnings and error<br/>
		/// messages for the design.<br/>
		/// TIP: The syntax is also checked automatically as the file is edited in the Vivado text editor, or when the file<br/>
		/// is saved.<br/>
		/// This command returns warnings or errors related to the files it examines, or returns nothing if no<br/>
		/// problems are found.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example checks the syntax of files in the simulation fileset:<br/>
		/// check_syntax -fileset sim_1<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 126<br/>
		/// </para>
		/// </summary>
		/// <param name="fileset">(Optional) Fileset to check for syntax</param>
		/// <param name="return_string">(Optional) Return the syntax check messages as a string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL check_syntax(String fileset = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: check_syntax [-fileset <arg>] [-return_string] [-quiet] [-verbose]
			_tcl.Entry(_builder.check_syntax(fileset, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Close the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: close_design [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Closes the currently active design. If the design has been modified, you will not be prompted to<br/>
		/// save the design prior to closing. You will need to run save_design or save_design_as to<br/>
		/// save any changes made to the design before using the close_design command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example closes the current design:<br/>
		/// close_design<br/>
		/// Note: If multiple designs are open, you can specify the current design with the current_design<br/>
		/// command prior to using close_design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example sets the current design, then closes it:<br/>
		/// current_design rtl_1<br/>
		/// close_design<br/>
		/// current_design sets rtl_1 as the active design, then the close_design command closes<br/>
		/// it.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 137<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL close_design(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: close_design [-quiet] [-verbose]
			_tcl.Entry(_builder.close_design(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Close current opened project<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: close_project [-delete] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Closes the current open project.<br/>
		/// TIP: Any user-defined Tcl variables that are in the global namespace (i.e. not in a project-specific<br/>
		/// namespace) are not reset or cleared by this command. Global variables are persistent with the invocation<br/>
		/// of Vivado and are only cleared when the Vivado Design Suite is closed. You can also use the unset<br/>
		/// command to expressly clear a specific Tcl variable.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following command closes the active project:<br/>
		/// close_project<br/>
		/// This example closes the current project. If you have multiple projects open, the<br/>
		/// close_project command applies to the current project which can be defined with the<br/>
		/// current_project command.<br/>
		/// The following example sets project_1 as the current project, and then closes the project and<br/>
		/// deletes it from the computer hard disk:<br/>
		/// current_project project_1<br/>
		/// close_project -delete<br/>
		/// Note: Use the -delete argument with caution. You will not be prompted to confirm the deletion of<br/>
		/// project data.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 143<br/>
		/// </para>
		/// </summary>
		/// <param name="delete">(Optional) Delete the project from disk also</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL close_project(bool? delete = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: close_project [-delete] [-quiet] [-verbose]
			_tcl.Entry(_builder.close_project(delete, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Compile C code into RTL<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: compile_c [-force] [-quiet] [-verbose] &lt;objects&gt;
		/// <br/>
		/// <para>
		/// In IP cores that are imported from Vivado HLS, the compile_c command detects C, C++, and<br/>
		/// SystemC files and converts those files to RTL for synthesis by the Vivado Design Suite.<br/>
		/// This lets you use Vivado HLS to describe IP cores in a high-level language, like C or C++ rather<br/>
		/// than RTL.<br/>
		/// When HLS-based IP cores are generated, they only deliver the C source. When the HLS-based IP<br/>
		/// is synthesized, either in the out-of-context flow, or with the top-level design, the compile_c<br/>
		/// command launches Vivado HLS to convert the C source files into RTL, and import the resulting<br/>
		/// RTL sources back into the design prior to synthesis.<br/>
		/// RECOMMENDED: The compile_c command is automatically called by the Vivado Design Suite when<br/>
		/// it encounters IP with C code from the Vivado HLS system. You should not need to manually call this<br/>
		/// command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 164<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) The objects which need C to RTL conversion</param>
		/// <param name="force">(Optional) Force generate product state regeneration</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL compile_c(TCLObject objects, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: compile_c [-force] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.compile_c(objects, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Copy an existing IP<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: copy_ip -name &lt;arg&gt; [-dir &lt;arg&gt;] [-quiet] [-verbose] &lt;objects&gt;...
		/// <br/>
		/// <para>
		/// Create a copy of an IP core that has been previously instanced into the current project.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 218<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of copied IP</param>
		/// <param name="objects">(Required) IP to be copied</param>
		/// <param name="dir">
		/// <para>
		/// (Optional)<br/>
		/// Directory path for remote IP to be created and managed<br/>
		/// outside the project<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>IP file object that was added to the project</returns>
		public TTCL copy_ip(String name, TCLObjectList objects, String dir = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: copy_ip -name <arg> [-dir <arg>] [-quiet] [-verbose] <objects>...
			_tcl.Entry(_builder.copy_ip(name, objects, dir, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create the Gadget for Project summary dashboard<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_dashboard_gadget -name &lt;arg&gt; -type &lt;arg&gt; [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// IMPORTANT! This command is primarily intended to be used in the Vivado IDE, with the Project<br/>
		/// Summary, and the Add Gadget command.<br/>
		/// Create a new "gadget" for a dashboard, such as the Project Summary dashboard that lets you<br/>
		/// view different aspects of the synthesized or implemented design run. Aspects of the design<br/>
		/// include timing information, resource utilization, DRC and methodology violations, and power<br/>
		/// analysis.<br/>
		/// A dashboard gadget has a series of properties that define the information displayed, and the way<br/>
		/// it is displayed. These properties can be set using the set_property command. To determine<br/>
		/// the properties on a gadget, you can use the following command:<br/>
		/// report_property -all [get_dashboard_gadget &lt;gadget_name&gt;]<br/>
		/// Properties of a dashboard gadget can be set using the set_property command. Some of the<br/>
		/// properties of a gadget that can be set include:<br/>
		/// • TYPE: Indicates the type of information presented by the gadget as defined by the -type<br/>
		/// option.<br/>
		/// • ROW: Indicates the row placement in the dashboard.<br/>
		/// • COL: Indicates the column placement of the gadget in the dashboard.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • REPORTS: specifies the reports associated with the gadget.<br/>
		/// • RUN.STEP and TYPE: specifies the synthesis or implementation run step that the gadget<br/>
		/// applies to.<br/>
		/// • VIEW.TYPE and ORIENTATION: Specifies the presentation of information as a graph or table,<br/>
		/// and indicates the orientation of the data.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 253<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of the gadget</param>
		/// <param name="type">(Required) Type of the gadget</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_dashboard_gadget(String name, String type, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_dashboard_gadget -name <arg> -type <arg> [-quiet] [-verbose]
			_tcl.Entry(_builder.create_dashboard_gadget(name, type, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new fileset<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_fileset [-constrset] [-simset] [-blockset] [-clone_properties &lt;arg&gt;] -define_from &lt;arg&gt; [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Defines a new fileset within a design project. Files can be added to a newly created fileset using<br/>
		/// the add_files command.<br/>
		/// A fileset is a list of files with a specific function within the project. One or more constraint files is<br/>
		/// a constraint set (-constrset); one or more simulation test benches is a simulation set (-<br/>
		/// simset). Only one fileset option can be specified when using the create_fileset command.<br/>
		/// As a default, the tool will create a constraint fileset if the type is not specified.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// You can also use the create_fileset -blockset command to configure an IP core, or<br/>
		/// hierarchical module of the design, as an out-of-context (OOC) block. The block fileset, or<br/>
		/// blockset, creates a hierarchical file collection for the IP or module specified with the -<br/>
		/// define_from option. The files related to the specified hierarchical module will be moved from<br/>
		/// their current fileset to the new blockset. When the blockset is created, the Vivado Design Suite<br/>
		/// also defines out-of-context synthesis and implementation runs for the block. The output<br/>
		/// products for the OOC module are stored in the blockset, including the synthesized design<br/>
		/// checkpoint (DCP) and any required structural simulation netlists. Stuctural simulation netlists are<br/>
		/// needed when a behavioral model for the block is not available, or is not available in the language<br/>
		/// supported by the target simulator. You can define an out-of-context constraint file for the IP or<br/>
		/// moduleif needed, and add the at to the block fileset as well.<br/>
		/// TIP: Refer to the Vivado Design Suite User Guide: Designing with IP (UG896) or the Vivado Design Suite<br/>
		/// User Guide: Hierarchical Design (UG905) for more information on out-of-context design.<br/>
		/// The create_fileset command returns the name of the newly created fileset, or will return an<br/>
		/// error message if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a new constraint file set named constraints2:<br/>
		/// create_fileset -constrset -quiet constraints2<br/>
		/// Note: With -quiet specified, the tool will not return anything if it encounters an error in trying to create<br/>
		/// the specified fileset.<br/>
		/// The following example creates an out-of-context (OOC) blockset for the hierarchical module<br/>
		/// specified by the -define_from option:<br/>
		/// create_fileset -blockset -define_from dac_spi dac_spi<br/>
		/// The following example creates a new simulation fileset named sim_1:<br/>
		/// create_fileset -simset sim_1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 272<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of the fileset to be create</param>
		/// <param name="constrset">(Optional) Create fileset as constraints fileset (default)</param>
		/// <param name="simset">(Optional) Create fileset as simulation source fileset</param>
		/// <param name="blockset">(Optional) Create fileset as block source fileset</param>
		/// <param name="clone_properties">(Optional) Fileset to initialize properties from</param>
		/// <param name="define_from">(Optional) Name of the module in the source fileset to be the top of the blockset</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>new fileset object</returns>
		public TTCL create_fileset(TCLObject name, bool? constrset = null, bool? simset = null, bool? blockset = null, String clone_properties = null, String define_from = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_fileset [-constrset] [-simset] [-blockset] [-clone_properties <arg>] -define_from <arg> [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_fileset(name, constrset, simset, blockset, clone_properties, define_from, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Creates a run for the given IP.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_ip_run [-force] [-quiet] [-verbose] &lt;objects&gt;
		/// <br/>
		/// <para>
		/// Defines a synthesis and implementation run for a single IP object as specified by the get_ips<br/>
		/// command, or for the specified IP core file (XCI) as specified by the get_files command.<br/>
		/// The IP run is used to generate the synthesis design checkpoint file (DCP) to support the out-of-context (OOC) IP flow, or to synthesize and implement an IP module in the OOC hierarchical<br/>
		/// design flow.<br/>
		/// Two runs are created: one for synthesis, and one for implementation. The runs are named after<br/>
		/// the IP core and the run type, &lt;ip_name&gt;_synth_1 and &lt;ip_name&gt;_impl_1.<br/>
		/// The IP source files required to synthesize the run are copied into the IP run directory. The<br/>
		/// attributes of the run can be configured with the use of the set_property command.<br/>
		/// This command returns the name of the synthesis run created for the IP module.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates synthesis and implementation runs for the specified IP module:<br/>
		/// create_ip_run [get_ips add1]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 319<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">
		/// <para>
		/// (Required)<br/>
		/// All of the IP objects (from get_ips or get_files) for which a<br/>
		/// run needs to be generated for.<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Force regeneration of products of the given IP.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_ip_run(TCLObject objects, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_ip_run [-force] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.create_ip_run(objects, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a peripheral with a VLNV.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_peripheral [-dir &lt;arg&gt;] [-quiet] [-verbose] &lt;vendor&gt; &lt;library&gt; &lt;name&gt; &lt;version&gt;
		/// <br/>
		/// <para>
		/// Create an AXI peripheral to add to the IP repository with the specified VLNV attribute.<br/>
		/// The AXI peripheral that is created is just a framework until interfaces have been added to the<br/>
		/// peripheral using the add_peripheral_interface command, and the peripheral has been<br/>
		/// generated using the generate_peripheral command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 329<br/>
		/// </para>
		/// </summary>
		/// <param name="vendor">(Required) Vendor, for example xilinx.com</param>
		/// <param name="library">(Required) Library, for example ip</param>
		/// <param name="name">(Required) Name, for example myip</param>
		/// <param name="version">(Required) Version, for example 1.4</param>
		/// <param name="dir">
		/// <para>
		/// (Optional)<br/>
		/// Directory path for remote Peripheral to be created and<br/>
		/// managed outside the project<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_peripheral(TCLObject vendor, TCLObject library, TCLObject name, TCLObject version, String dir = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_peripheral [-dir <arg>] [-quiet] [-verbose] <vendor> <library> <name> <version>
			_tcl.Entry(_builder.create_peripheral(vendor, library, name, version, dir, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new project<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_project [-part &lt;arg&gt;] [-force] [-in_memory] [-ip] [-rtl_kernel] [-quiet] [-verbose] [&lt;name&gt;] [&lt;dir&gt;]
		/// <br/>
		/// <para>
		/// Creates a Vivado Design Suite project file (.xpr), or a project file for the Vivado Lab Edition (.lpr),<br/>
		/// in the specified directory.<br/>
		/// For the Vivado Lab Edition: The create_project command has a different command syntax,<br/>
		/// with fewer options, in the Vivado Lab Edition. The options that are not supported in Vivado Lab<br/>
		/// Edition are:<br/>
		/// • -part - The Vivado Lab Edition project (.lpr) does not specify a target part because the<br/>
		/// current_hw_target and current_hw_device determine the target part.<br/>
		/// • -ip - The Vivado Lab Edition does not define projects for the Managed IP flow.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// For the Vivado Design Suite: The default project created for the Vivado Design Suite is an RTL<br/>
		/// project, which defines the project as holding and manage RTL source files in the source fileset.<br/>
		/// The type of project is determined by the DESIGN_MODE Property on the source fileset when the<br/>
		/// project is created. To change the project type, use the set_property command to set the<br/>
		/// DESIGN_MODE property on the current_fileset as follows:<br/>
		/// • RTL Project - set_property DESIGN_MODE RTL [current_fileset]<br/>
		/// • Netlist Project - set_property DESIGN_MODE GateLvl [current_fileset]<br/>
		/// • I/O Planning Project - set_property DESIGN_MODE PinPlanning<br/>
		/// [current_fileset]<br/>
		/// Refer to the Vivado Design Suite User Guide: System-Level Design Entry (UG895) for more<br/>
		/// information on the different types of projects.<br/>
		/// This command returns a transcript of its process and the name of the created project, or returns<br/>
		/// an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// When run from the Vivado Design Suite, the following example creates a project called<br/>
		/// project1.xpr in a directory called myDesigns:<br/>
		/// create_project project1 myDesigns<br/>
		/// Note: Because the &lt;dir&gt; is specified as the folder name only, the tool will create the project in the current<br/>
		/// working directory, or the directory from which the tool was launched.<br/>
		/// When run from the Vivado Lab Edition, this example creates a project called project1.lpr in<br/>
		/// a directory called myDesigns:<br/>
		/// create_project project1 myDesigns<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example creates a project called Proj1 in a directory called FPGA in C:/Designs. In<br/>
		/// addition, the tool will overwrite an existing project if one is found to exist in the specified<br/>
		/// location. In the second and third lines, the location of -force is changed to show the flexibility<br/>
		/// of argument placement.<br/>
		/// create_project Proj1 C:/Designs/FPGA -force<br/>
		/// -or-<br/>
		/// create_project Proj1 -force C:/Designs/FPGA<br/>
		/// -or-<br/>
		/// create_project -force Proj1 C:/Designs/FPGA<br/>
		/// Note: In all cases the first argument without a preceding keyword is interpreted as the &lt;name&gt; variable,<br/>
		/// and the second argument without a preceding keyword is the &lt;dir&gt; variable.<br/>
		/// The following example creates a project for the Manage IP flow in the specified directory:<br/>
		/// create_project -ip manageIP C:/Data<br/>
		/// The following example creates a new project called pin_project, and then sets the<br/>
		/// DESIGN_MODE property as required for an I/O Pin Planning project, and finally opens an IO<br/>
		/// design:<br/>
		/// create_project pin_project C:/Designs/PinPlanning<br/>
		/// set_property design_mode PinPlanning [current_fileset]<br/>
		/// open_io_design -name io_1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 343<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Project name</param>
		/// <param name="part">(Optional) Target part</param>
		/// <param name="force">(Optional) Overwrite existing project directory</param>
		/// <param name="in_memory">(Optional) Create an in-memory project</param>
		/// <param name="ip">(Optional) Default GUI behavior is for a managed IP project</param>
		/// <param name="rtl_kernel">(Optional) Default GUI behavior is for a RTL Kernel project</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="dir">(Optional) Directory where the project file is saved Default: .</param>
		/// <returns>new project object</returns>
		public TTCL create_project(TCLObject name, String part = null, bool? force = null, bool? in_memory = null, bool? ip = null, bool? rtl_kernel = null, bool? quiet = null, bool? verbose = null, TCLObject dir = null)
		{
			// TCL Syntax: create_project [-part <arg>] [-force] [-in_memory] [-ip] [-rtl_kernel] [-quiet] [-verbose] [<name>] [<dir>]
			_tcl.Entry(_builder.create_project(name, part, force, in_memory, ip, rtl_kernel, quiet, verbose, dir));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Define a synthesis or implementation run for the current project<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_run [-constrset &lt;arg&gt;] [-parent_run &lt;arg&gt;] [-part &lt;arg&gt;] -flow &lt;arg&gt; [-strategy &lt;arg&gt;] [-report_strategy &lt;arg&gt;] [-pr_config &lt;arg&gt;] [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Defines a synthesis or implementation run. The attributes of the run can be configured with the<br/>
		/// use of the set_property command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a run named synth_1 referencing the Vivado synthesis tool flow:<br/>
		/// create_run -flow {Vivado Synthesis 2013} synth_1<br/>
		/// Note: The defaults of sources_1, constrs_1, and the default part for the project will be used in the synthesis<br/>
		/// run. In addition, since this is a synthesis run, the -parent_run argument is not required.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example creates an implementation run based on the Vivado Implementation 2013<br/>
		/// tool flow, and attaches it to the synth_1 synthesis run previously created:<br/>
		/// create_run impl_2 -parent_run synth_1 -flow {Vivado Implementation 2013}<br/>
		/// Note: The -parent_run argument is required in this example because it is an implementation of<br/>
		/// synthesized RTL sources.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 359<br/>
		/// </para>
		/// </summary>
		/// <param name="flow">(Required) Flow name</param>
		/// <param name="name">(Required) Name for new run</param>
		/// <param name="constrset">(Optional) Constraint fileset to use</param>
		/// <param name="parent_run">(Optional) Synthesis run to link to new implementation run</param>
		/// <param name="part">(Optional) Target part</param>
		/// <param name="strategy">(Optional) Strategy to apply to the run</param>
		/// <param name="report_strategy">(Optional) Report strategy to apply to the run</param>
		/// <param name="pr_config">(Optional) partition configuration to apply to the run</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>run object</returns>
		public TTCL create_run(String flow, TCLObject name, String constrset = null, String parent_run = null, String part = null, String strategy = null, String report_strategy = null, String pr_config = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_run [-constrset <arg>] [-parent_run <arg>] [-part <arg>] -flow <arg> [-strategy <arg>] [-report_strategy <arg>] [-pr_config <arg>] [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_run(flow, name, constrset, parent_run, part, strategy, report_strategy, pr_config, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create embedded source for XPS and add to the source fileset (Not supported anymore. Please<br/>
		/// use Vivado IP integrator.)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_xps [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Create an Embedded Processor source for use in the current project, and add it to the source<br/>
		/// files.<br/>
		/// This command will launch the Xilinx Platform Studio (XPS) to let you design the hardware portion<br/>
		/// of the embedded processor system. In XPS you can define and configure the microprocessor,<br/>
		/// peripherals, and the interconnection of these components. After you exit XPS, the created files<br/>
		/// for the Embedded Processor sub-design will be written to the local project directory<br/>
		/// (&lt;project_name&gt;.srcs/sources_1/edk/&lt;name&gt; ), and added to the source files.<br/>
		/// For more information on using specific features of XPS refer to EDK Concepts, Tools, and<br/>
		/// Techniques (UG683).<br/>
		/// You can also add existing Xilinx Microprocessor Project (.xmp) files from XPS in the current<br/>
		/// project using the add_files command.<br/>
		/// The command returns the name of the Embedded Processor sub-design created.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example launches XPS to define and configure the specified Embedded Processor<br/>
		/// sub-design:<br/>
		/// create_xps xpsTest1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 373<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Source name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>source file name that was created</returns>
		public TTCL create_xps(TCLObject name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_xps [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_xps(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get the current board_part object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_board_part [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Return the Xilinx device used in the current project or design.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// The board part provides a representation of the Xilinx device in the context of the board-level<br/>
		/// system, and is represented by the part0 component in the Board Interface file.<br/>
		/// The board can be specified:<br/>
		/// • When the project is created by selecting Boards from the Default Part dialog box.<br/>
		/// • By setting the BOARD_PART property on the current project as shown in the example.<br/>
		/// • By selecting the Project Device in the Settings dialog box in an open project in the Vivado IDE.<br/>
		/// Refer to the Vivado Design Suite User Guide: System-Level Design Entry (UG895) for information on<br/>
		/// creating projects, and on configuring project settings.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// IMPORTANT! When you specify the board with the set_property command, the target part is also<br/>
		/// changed to match the part required by the specified BOARD_PART property.<br/>
		/// The current_board_part command returns the NAME property of the current board part.<br/>
		/// The command returns a warning when the project targets a Xilinx FPGA instead of a board, or<br/>
		/// when the BOARD_PART property has not been defined. The command returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 382<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>current board_part object</returns>
		public TTCL current_board_part(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: current_board_part [-quiet] [-verbose]
			_tcl.Entry(_builder.current_board_part(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get the current fileset (any type) or set the current fileset (applicable to simulation filesets only)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_fileset [-constrset] [-simset] [-quiet] [-verbose] [&lt;fileset&gt;...]
		/// <br/>
		/// <para>
		/// Get the active source, constraint, or simulation fileset within the current project.<br/>
		/// When used without any options, current_fileset sets and returns the sources_1 set as the active<br/>
		/// fileset.<br/>
		/// This command can also be used to set the current simulation fileset.<br/>
		/// Note: Use set_property CONSTRSET to define the active constraint set on a synthesis or<br/>
		/// implementation run.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the name of the currently active constraint fileset:<br/>
		/// current_fileset -constrset<br/>
		/// The following example sets sim_2 as the active simulation set:<br/>
		/// current_fileset -simset sim_2<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 387<br/>
		/// </para>
		/// </summary>
		/// <param name="constrset">(Optional) Get the current constraints fileset</param>
		/// <param name="simset">(Optional) Get the current active simulation fileset</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="fileset">(Optional) Specify the simulation fileset to set as current (active); optional</param>
		/// <returns>current fileset (the current srcset by default)</returns>
		public TTCL current_fileset(bool? constrset = null, bool? simset = null, bool? quiet = null, bool? verbose = null, TCLObjectList fileset = null)
		{
			// TCL Syntax: current_fileset [-constrset] [-simset] [-quiet] [-verbose] [<fileset>...]
			_tcl.Entry(_builder.current_fileset(constrset, simset, quiet, verbose, fileset));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set or get current project<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_project [-quiet] [-verbose] [&lt;project&gt;]
		/// <br/>
		/// <para>
		/// Specifies the current project or returns the current project when no project is specified.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets project_2 as the current project:<br/>
		/// current_project project_2<br/>
		/// This command makes the current project the focus of all the tool commands. In the GUI mode,<br/>
		/// the current project is defined automatically when switching the GUI between projects.<br/>
		/// The following example returns the name of the current project in the tool:<br/>
		/// current_project<br/>
		/// Note: The returned value is the name of the project and not the name or path of the project file.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 411<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="project">(Optional) Project to set as current</param>
		/// <returns>current or newly set project object</returns>
		public TTCL current_project(bool? quiet = null, bool? verbose = null, TCLObject project = null)
		{
			// TCL Syntax: current_project [-quiet] [-verbose] [<project>]
			_tcl.Entry(_builder.current_project(quiet, verbose, project));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set or get the current run<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_run [-synthesis] [-implementation] [-quiet] [-verbose] [&lt;run&gt;]
		/// <br/>
		/// <para>
		/// Defines the current synthesis or implementation run, or returns the name of the current run. The<br/>
		/// current run is the one automatically selected when the Synthesize or Implement commands are<br/>
		/// launched.<br/>
		/// You can use the get_runs command to determine the list of defined runs in the current design.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example defines the synth_1 run as the current_run:<br/>
		/// current_run synth_1<br/>
		/// Note: The -synthesis and -implementation arguments are not required because the name allows the<br/>
		/// tool to identify the specific run of interest.<br/>
		/// The following command returns the name of the current implementation run:<br/>
		/// current_run -implementation -quiet<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 413<br/>
		/// </para>
		/// </summary>
		/// <param name="synthesis">(Optional) Set or get the current synthesis run</param>
		/// <param name="implementation">
		/// <para>
		/// (Optional)<br/>
		/// Set or get the current implementation run (default unless '-<br/>
		/// synthesis' is specified)<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="run">(Optional) Run to set as current; optional</param>
		/// <returns>run object</returns>
		public TTCL current_run(bool? synthesis = null, bool? implementation = null, bool? quiet = null, bool? verbose = null, TCLObject run = null)
		{
			// TCL Syntax: current_run [-synthesis] [-implementation] [-quiet] [-verbose] [<run>]
			_tcl.Entry(_builder.current_run(synthesis, implementation, quiet, verbose, run));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Deletes the gadgets from project summary dashboard<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_dashboard_gadgets [-quiet] [-verbose] &lt;gadgets&gt;
		/// <br/>
		/// <para>
		/// This command removes the gadget from the Project Summary dashboard, and removes it from<br/>
		/// the project.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 432<br/>
		/// </para>
		/// </summary>
		/// <param name="gadgets">(Required) Gadgets to delete</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_dashboard_gadgets(TCLObject gadgets, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_dashboard_gadgets [-quiet] [-verbose] <gadgets>
			_tcl.Entry(_builder.delete_dashboard_gadgets(gadgets, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Delete a fileset<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_fileset [-merge &lt;arg&gt;] [-quiet] [-verbose] &lt;fileset&gt;
		/// <br/>
		/// <para>
		/// Deletes the specified fileset. However, if the fileset cannot be deleted, then no message is<br/>
		/// returned.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example deletes the sim_2 fileset from the current project.<br/>
		/// delete_fileset sim_2<br/>
		/// Note: The fileset and all of its files are removed from the project. The files are not removed from the hard<br/>
		/// drive.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 443<br/>
		/// </para>
		/// </summary>
		/// <param name="fileset">(Required) Fileset to be deleted</param>
		/// <param name="merge">(Optional) Fileset to merge files from the deleted fileset into</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_fileset(TCLObject fileset, String merge = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_fileset [-merge <arg>] [-quiet] [-verbose] <fileset>
			_tcl.Entry(_builder.delete_fileset(fileset, merge, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Deletes the block fileset and run associated with a given IP.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_ip_run [-force] [-quiet] [-verbose] &lt;objects&gt;
		/// <br/>
		/// <para>
		/// Deletes the out-of-context (OOC) synthesis and implementation runs for the specified IP<br/>
		/// module.<br/>
		/// The contents of the run directory are deleted from the project as well as the run. However, the<br/>
		/// output products created by the run and copied to the IP sources folder, the DCP file and Verilog<br/>
		/// and VHDL structural netlists, are not deleted from the project. You must use the reset_target<br/>
		/// or generate_target command to update the IP output products.<br/>
		/// IMPORTANT! The command requires an IP object as specified by the get_ips or get_files<br/>
		/// command, and will not delete a run based on either the name of the run, or a run object as returned by<br/>
		/// get_runs.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example deletes the OOC synthesis and implementation runs from the specified IP<br/>
		/// module:<br/>
		/// delete_ip_run [get_ips add1]<br/>
		/// Note: In this example, all run results will also be removed from the run directory on the hard drive.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 457<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">
		/// <para>
		/// (Required)<br/>
		/// All of the IP objects (from get_ips or get_files) for which the<br/>
		/// block fileset and run will be deleted.<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Force the deletion of the block fileset and run.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_ip_run(TCLObject objects, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_ip_run [-force] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.delete_ip_run(objects, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Delete existing runs<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_runs [-noclean_dir] [-quiet] [-verbose] &lt;runs&gt;
		/// <br/>
		/// <para>
		/// Deletes the specified runs from the project, and deletes all results of the run from the project<br/>
		/// directory on the hard drive unless otherwise specified.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example deletes the first_pass run from the project:<br/>
		/// delete_runs first_pass<br/>
		/// Note: In this example, all run results will also be removed from the project directory on the hard drive.<br/>
		/// The following command deletes the first_pass run, but leaves the run results on the hard drive:<br/>
		/// delete_runs -noclean_dir first_pass<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 478<br/>
		/// </para>
		/// </summary>
		/// <param name="runs">(Required) Run to modify</param>
		/// <param name="noclean_dir">(Optional) Do not remove all output files and directories from disk</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_runs(TCLObject runs, bool? noclean_dir = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_runs [-noclean_dir] [-quiet] [-verbose] <runs>
			_tcl.Entry(_builder.delete_runs(runs, noclean_dir, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Find top module candidates in the supplied files, fileset, or active fileset. Returns a rank ordered<br/>
		/// list of candidates.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: find_top [-fileset &lt;arg&gt;] [-files &lt;args&gt;] [-return_file_paths] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Find the most likely candidates for the top module in the files defined in the current fileset, or in<br/>
		/// the specified fileset, or in the specified list of files.<br/>
		/// The command returns an ordered list of modules that the tool identifies as the best candidates<br/>
		/// for the top-level of the design. You can use the lindex command, and choose index 0 to select<br/>
		/// the best candidate for the top module.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example chooses the best top module of the current design for synthesis:<br/>
		/// synth_design -top [lindex [find_top] 0]<br/>
		/// Note: Since find_top returns multiple possible candidates, choosing index 0 chooses the best top<br/>
		/// candidate for synthesis.<br/>
		/// The following example returns the best top module candidate from the specified list of files:<br/>
		/// find_top -files [get_files -filter {NAME =~ *or1200*}]<br/>
		/// The following example sets the results of find_top into the variable $topVar, then uses that<br/>
		/// variable to define the top module in the current fileset using the set_property command:<br/>
		/// set topVar [ find_top -files [get_files -filter {NAME =~ *usbf*} ] ]<br/>
		/// usbf_top<br/>
		/// set_property top $topVar [current_fileset]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 535<br/>
		/// </para>
		/// </summary>
		/// <param name="fileset">(Optional) Fileset to parse to search for top candidates</param>
		/// <param name="files">(Optional) Files to parse to search for top candidates</param>
		/// <param name="return_file_paths">
		/// <para>
		/// (Optional)<br/>
		/// For each top returned, also include the associated file path.<br/>
		/// The returned value will be a single list of strings, alternating<br/>
		/// top names and file paths.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL find_top(String fileset = null, TCLParameterList files = null, bool? return_file_paths = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: find_top [-fileset <arg>] [-files <args>] [-return_file_paths] [-quiet] [-verbose]
			_tcl.Entry(_builder.find_top(fileset, files, return_file_paths, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Generate output products for peripheral object.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: generate_peripheral [-driver] [-example_design] [-bfm_example_design] [-debug_hw_example_design] [-enable_interrupt] [-force] [-quiet] [-verbose] &lt;peripheral&gt;
		/// <br/>
		/// <para>
		/// Generate the output products for the specified peripheral object. The output products are<br/>
		/// written to the IP repository location specified when the IP is created by the<br/>
		/// create_peripheral command, under the name of the IP as specified at creation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 545<br/>
		/// </para>
		/// </summary>
		/// <param name="peripheral">(Required) peripheral object</param>
		/// <param name="driver">(Optional) Generate driver for peripheral.</param>
		/// <param name="example_design">(Optional) Generate all supported example designs for peripheral.</param>
		/// <param name="bfm_example_design">(Optional) Generate bfm simulation example design for peripheral.</param>
		/// <param name="debug_hw_example_design">(Optional) Generate debug hardware example design for peripheral.</param>
		/// <param name="enable_interrupt">(Optional) Generate peripheral with interrupt suppport.</param>
		/// <param name="force">(Optional) Overwrite the existing IP in the repository.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL generate_peripheral(TCLObject peripheral, bool? driver = null, bool? example_design = null, bool? bfm_example_design = null, bool? debug_hw_example_design = null, bool? enable_interrupt = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_peripheral [-driver] [-example_design] [-bfm_example_design] [-debug_hw_example_design] [-enable_interrupt] [-force] [-quiet] [-verbose] <peripheral>
			_tcl.Entry(_builder.generate_peripheral(peripheral, driver, example_design, bfm_example_design, debug_hw_example_design, enable_interrupt, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Generate target data for the specified source<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: generate_target [-force] [-quiet] [-verbose] &lt;name&gt; &lt;objects&gt;
		/// <br/>
		/// <para>
		/// This command generates target data for the specified IP objects (get_ips) or source file for IP<br/>
		/// cores (.xci and .xco), DSP modules (.slx or .mdl), or block designs (.bd). The target data<br/>
		/// that is generated are the files necessary to support the IP or block design through the FPGA<br/>
		/// design flow.<br/>
		/// The instantiation template, synthesis netlist, and simulation netlist are standard targets. However,<br/>
		/// each IP in the catalog may also support its own set of targets. You can view the available targets<br/>
		/// on an object by examining the SUPPORTED_TARGETS property, or you can use the<br/>
		/// list_targets command to list the targets for design source file.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example generates the change log for all of the IP cores in the current project, forcing<br/>
		/// regeneration of any targets that are up-to-date:<br/>
		/// generate_target changelog [get_ips] -force<br/>
		/// The following example generates the instantiation template and synthesis targets for all of the IP<br/>
		/// cores in the current project:<br/>
		/// generate_target {instantiation_template synthesis} [get_ips]<br/>
		/// TIP: Note the use of the braces to pass the list of targets to the command. The absence of the -force<br/>
		/// option means that only out-of-date targets will be regenerated.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example generates all targets for the specified block design:<br/>
		/// generate_target all \<br/>
		/// [get_files C:/Data/project_mb/project_mb.srcs/sources_1/bd/base_mb/<br/>
		/// base_mb.bd]<br/>
		/// IMPORTANT! The use of get_ips is not supported to generate targets for individual IP within block<br/>
		/// designs. The tool will return an error.<br/>
		/// The following queries the SUPPORTED_TARGETS property of the specified IP object, and then<br/>
		/// generates the example project for the IP:<br/>
		/// get_property SUPPORTED_TARGETS [get_ips blk_mem*]<br/>
		/// open_example_project -dir C:/Data/examples -force [get_ips blk_mem*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 552<br/>
		/// </para>
		/// </summary>
		/// <param name="name">
		/// <para>
		/// (Required)<br/>
		/// List of targets to be generated, or 'all' to generate all<br/>
		/// supported targets<br/>
		/// </para>
		/// </param>
		/// <param name="objects">(Required) The objects for which data needs to be generated</param>
		/// <param name="force">(Optional) Force target data regeneration</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL generate_target(TCLObject name, TCLObject objects, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_target [-force] [-quiet] [-verbose] <name> <objects>
			_tcl.Entry(_builder.generate_target(name, objects, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get the list of board_part available in the project<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_parts [-regexp] [-nocase] [-latest_file_version] [-latest_hw_revision] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of available board parts in the board repository, as defined by the Board Interface files<br/>
		/// available for use by the current project or design.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The board part provides a representation of the Xilinx device in the context of the board-level<br/>
		/// system, and is represented by the part0 component in the Board Interface file. The<br/>
		/// current_board_part command returns the board part in use by the current project. Refer to<br/>
		/// the current_board_part command for the different methods of defining the board in use.<br/>
		/// This command returns the list of available Xilinx devices (part0) in the Board Interface files<br/>
		/// defined in the current board repository, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the board parts matching the specified filter search pattern:<br/>
		/// get_board_parts -filter {BOARD_NAME=~z*}<br/>
		/// The following example returns all board parts matching the specified search patterns:<br/>
		/// get_board_parts {*av* *kc*}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 638<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="latest_file_version">(Optional) Show only latest board parts by file version</param>
		/// <param name="latest_hw_revision">(Optional) Show only latest board parts by board revision</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Match Board Part names against patterns Default: * Values:<br/>
		/// The default search pattern is the wildcard *, or .* when -<br/>
		/// regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of board_part objects</returns>
		public TTCL get_board_parts(bool? regexp = null, bool? nocase = null, bool? latest_file_version = null, bool? latest_hw_revision = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_board_parts [-regexp] [-nocase] [-latest_file_version] [-latest_hw_revision] [-filter <arg>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_parts(regexp, nocase, latest_file_version, latest_hw_revision, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get the list of boards available in the project<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_boards [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of evaluation boards available for use by the current project.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// The board in use by the project is returned by the current_board_part command.<br/>
		/// The board can be specified:<br/>
		/// • When the project is created by selecting Boards from the Default Part dialog box.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • By setting the BOARD property on the current project as shown in the example.<br/>
		/// • By selecting the Project Device in the Settings dialog box in an open project in the Vivado IDE.<br/>
		/// Refer to the Vivado Design Suite User Guide: System-Level Design Entry (UG895) for information on<br/>
		/// creating projects, and on configuring project settings.<br/>
		/// IMPORTANT! When you specify the board with the set_property command, the target part is also<br/>
		/// changed to match the part required by the specified BOARD property.<br/>
		/// This command returns a list of boards that are available for use by the current project, or returns<br/>
		/// an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the properties of the specified evaluation board:<br/>
		/// report_property [get_boards -filter {LIBRARY_NAME==artix7}]<br/>
		/// The following example returns all boards matching the specified search patterns:<br/>
		/// get_boards {*ar* *kc*}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 642<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'board' objects of these types: 'board_component'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Match Board names against patterns Default: * Values: The<br/>
		/// default search pattern is the wildcard *, or .* when -regexp<br/>
		/// is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of board objects</returns>
		public TTCL get_boards(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_boards [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_boards(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create the Project summary dashboard<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_dashboard_gadgets [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of the dashboard gadgets in the current project.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the dashboard gadgets in the current project:<br/>
		/// get_dashboard_gadgets<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 667<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Match gadget names against patterns Default: * Values: The<br/>
		/// default search pattern is the wildcard *<br/>
		/// </para>
		/// </param>
		public TTCL get_dashboard_gadgets(bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_dashboard_gadgets [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_dashboard_gadgets(quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of source files<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_files [-regexp] [-nocase] [-filter &lt;arg&gt;] [-compile_order &lt;arg&gt;] [-used_in &lt;arg&gt;] [-references] [-all] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of files in the current project that match a specified search pattern. The default<br/>
		/// command gets a list of all files in the project.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The get_files command returns a machine readable list of files in the project, in a design, or in<br/>
		/// a sub-design such as an IP core or block design. You can filter the results returned by<br/>
		/// get_files using one of the command arguments such as -of_objects, -compile_order,<br/>
		/// -used_in, and -filter.<br/>
		/// The -compile_order and -used_in options must be used together to return a list of files<br/>
		/// from the sources or constraints filesets used in synthesis, simulation, or implementation, sorted<br/>
		/// according to the order of evaluation by the Vivado tools. The -compile_order and -used_in<br/>
		/// options use complex file ordering rules that can change based on header files, include files, or<br/>
		/// other language options. You can also filter files returned by get_files according to the<br/>
		/// USED_IN property, using the -filter option instead of the -used_in option.<br/>
		/// You can use the report_compile_order command to generate a report of all files in the<br/>
		/// sources or constraints filesets, used in synthesis, simulation, AND implementation, sorted into<br/>
		/// different sections.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the VHDL files in the design that are used in simulation:<br/>
		/// get_files -filter {FILE_TYPE == VHDL &amp;&amp; USED_IN =~ simulation*}<br/>
		/// This example returns the design source files that are used in simulation:<br/>
		/// get_files -compile_order sources -used_in simulation<br/>
		/// This example gets a list of files associated with the specified IP core composite file (ip.xci), from<br/>
		/// the sources_1 fileset that are used in synthesis:<br/>
		/// get_files -compile_order sources -used_in synthesis -of [get_files ip.xci]<br/>
		/// The following example gets a list of the files found in the sources_1 and constrs_1 filesets:<br/>
		/// get_files -of [get_filesets {sources_1 constrs_1}]<br/>
		/// Note: If there are no files matching the pattern you will get a warning.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 691<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="compile_order">(Optional) Get files by type and in compilation order (must use with - used_in)</param>
		/// <param name="used_in">(Optional) Get files used in a specific step (must use with - compile_order)</param>
		/// <param name="references">
		/// <para>
		/// (Optional)<br/>
		/// Get files referenced in the provided objects (must use with -<br/>
		/// of_objects)<br/>
		/// </para>
		/// </param>
		/// <param name="all">(Optional) Include all internal files.</param>
		/// <param name="of_objects">(Optional) Get 'file' objects of these types: 'file fileset ip reconfig_module'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match file names against patterns Default: *</param>
		/// <returns>list of file objects</returns>
		public TTCL get_files(bool? regexp = null, bool? nocase = null, String filter = null, String compile_order = null, String used_in = null, bool? references = null, bool? all = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_files [-regexp] [-nocase] [-filter <arg>] [-compile_order <arg>] [-used_in <arg>] [-references] [-all] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_files(regexp, nocase, filter, compile_order, used_in, references, all, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of filesets in the current project<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_filesets [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of filesets in the current project that match a specified search pattern. The default<br/>
		/// command gets a list of all filesets in the project.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the source files in the Source Set:<br/>
		/// get_files -of_objects [get_filesets sources_1]<br/>
		/// The following example makes project_2 the active project, and then gets a list of filesets<br/>
		/// beginning with the letter s or the letter r:<br/>
		/// current_project project_2<br/>
		/// get_filesets s* r* -quiet<br/>
		/// Note: If there are no filesets matching the pattern, such as r*, you will get a warning that no filesets<br/>
		/// matched the specified pattern. However, in the above example the use of -quiet will suppress that<br/>
		/// warning message.<br/>
		/// The following example gets filesets beginning with the letter C, using a case insensitive regular<br/>
		/// expression:<br/>
		/// get_filesets C.* -regexp -nocase<br/>
		/// In the above example, constrs_1 and constrs_2 constraint sets would be returned if defined in<br/>
		/// the current project.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 695<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'fileset' objects of these types: 'reconfig_module'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match fileset names against patterns Default: *</param>
		/// <returns>list of fileset objects</returns>
		public TTCL get_filesets(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_filesets [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_filesets(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of results for IP upgrades during the current project<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_ip_upgrade_results [-srcset &lt;arg&gt;] [-quiet] [-verbose] [&lt;objects&gt;...]
		/// <br/>
		/// <para>
		/// Returns the names of the upgrade_log files for the specified IPs.<br/>
		/// This command is used by the Vivado IDE to populate the IP Status Report window with<br/>
		/// information from the upgrade_log file. You can use the command to quickly obtain the<br/>
		/// upgrade_log file name, and then use the appropriate file commands, to read or display the<br/>
		/// contents.<br/>
		/// This command returns the upgrade_log file names of the specified IP objects, or returns an error<br/>
		/// if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 806<br/>
		/// </para>
		/// </summary>
		/// <param name="srcset">
		/// <para>
		/// (Optional)<br/>
		/// (Optional) Specifies the source file set containing the<br/>
		/// upgraded IP Default: The current source fileset Values:<br/>
		/// Source set name<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">
		/// <para>
		/// (Optional)<br/>
		/// IP to be upgraded Values: IP instance(s) within the design,<br/>
		/// as returned by 'get_ips &lt;instance name&gt;' or 'get_bd_cells<br/>
		/// &lt;cell name&gt;'<br/>
		/// </para>
		/// </param>
		/// <returns>list of IP upgrade results</returns>
		public TTCL get_ip_upgrade_results(String srcset = null, bool? quiet = null, bool? verbose = null, TCLObjectList objects = null)
		{
			// TCL Syntax: get_ip_upgrade_results [-srcset <arg>] [-quiet] [-verbose] [<objects>...]
			_tcl.Entry(_builder.get_ip_upgrade_results(srcset, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of IPs in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_ips [-regexp] [-nocase] [-all] [-filter &lt;arg&gt;] [-exclude_bd_ips] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Get a list of IP cores in the current project based on the specified search pattern. The default<br/>
		/// command returns a list of all IPs in the project.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns a list of IP cores with names beginning with the string "EDK":<br/>
		/// get_ips EDK*<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 812<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="all">(Optional) Include subcore IP in search</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="exclude_bd_ips">(Optional) Exclude all IP owned by a block design.</param>
		/// <param name="of_objects">(Optional) Get 'ip' objects of these types: 'ip file'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Match IP names against patterns Default: * Values: The<br/>
		/// default search pattern is the wildcard *, or .* when -regexp<br/>
		/// is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of IP objects</returns>
		public TTCL get_ips(bool? regexp = null, bool? nocase = null, bool? all = null, String filter = null, bool? exclude_bd_ips = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_ips [-regexp] [-nocase] [-all] [-filter <arg>] [-exclude_bd_ips] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_ips(regexp, nocase, all, filter, exclude_bd_ips, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of projects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_projects [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of open projects that match the specified search pattern. The default gets a list of all<br/>
		/// open projects.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of all open projects.<br/>
		/// get_projects<br/>
		/// The following example sets a variable called project_found to the length of the list of projects<br/>
		/// returned by get_projects, then prints either that projects were found or were not found as<br/>
		/// appropriate:<br/>
		/// set project_found [llength [get_projects ISC*] ]<br/>
		/// if {$project_found &gt; 0} {puts "Project Found."} \<br/>
		/// else {puts "No Projects Found."}<br/>
		/// Note: If there are no projects matching the pattern you will get a warning.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 898<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match project names against patterns Default: *</param>
		/// <returns>list of project objects</returns>
		public TTCL get_projects(bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_projects [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_projects(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of runs<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_runs [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of synthesis and implementation runs in the current project that match a specified<br/>
		/// search pattern. The default command gets a list of all runs defined in the project.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of all incomplete runs in the current project:<br/>
		/// get_runs -filter {PROGRESS &lt; 100}<br/>
		/// The following example gets a list of runs matching the specified pattern:<br/>
		/// get_runs imp*<br/>
		/// Note: If there are no runs matching the pattern you will get a warning.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 912<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'run' objects of these types: 'reconfig_module'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match run names against patterns Default: *</param>
		/// <returns>list of run objects</returns>
		public TTCL get_runs(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_runs [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_runs(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Display help for one or more topics<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: help [-category &lt;arg&gt;] [-args] [-syntax] [-long] [-prop &lt;arg&gt;] [-class &lt;arg&gt;] [-message &lt;arg&gt;] [-quiet] [-verbose] [&lt;pattern_or_object&gt;]
		/// <br/>
		/// <para>
		/// Returns a long description of the specified Tcl command; or a list of available Xilinx Tcl command<br/>
		/// categories; or a list of commands matching a specific pattern.<br/>
		/// The default help command without any arguments returns a list of Tcl command categories that<br/>
		/// can be further explored. Command categories are groups of commands performing a specific<br/>
		/// function, like File I/O commands for instance.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Available options for the help command can return just the command syntax for a quick<br/>
		/// reminder of how the command should be structured; the command syntax and a brief description<br/>
		/// of each argument; or the long form of the command with more detailed descriptions and<br/>
		/// examples of the command.<br/>
		/// To limit the memory usage of the Vivado Design Suite, some features of the tool are only loaded<br/>
		/// into memory when that feature set is used. To access the complete list of Tcl commands and help<br/>
		/// text associated with a given feature, you must load the feature into memory using the<br/>
		/// load_features command.<br/>
		/// The help command can also return any available information related to various properties<br/>
		/// assignable to design objects. Use the -prop and -class options to return help information for<br/>
		/// properties.<br/>
		/// This command returns the specified help text, or an error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns a list of Xilinx Tcl command categories:<br/>
		/// help<br/>
		/// This example loads the simulator feature of the Vivado Design Suite, and then returns a list of Tcl<br/>
		/// commands in the simulation and waveform categories:<br/>
		/// load_features simulator<br/>
		/// help -category simulation<br/>
		/// help -category waveform<br/>
		/// Returns a list of all commands matching the specified search pattern:<br/>
		/// help *file*<br/>
		/// This list can be used to quickly locate a command for a specific purpose, such as remove_files<br/>
		/// or delete_files.<br/>
		/// The following help command returns a long description of the remove_files command and its<br/>
		/// arguments:<br/>
		/// help remove_files<br/>
		/// Note: You can also use the -args option to get a brief description of the command.<br/>
		/// This example defines a procedure called short, and returns the -args form of help for the<br/>
		/// specified command:<br/>
		/// proc short cmdName {help -args $cmdName}<br/>
		/// Note: You can add this procedure to your init.tcl file to load this command every time the tool is<br/>
		/// launched. Refer to Chapter 1, Introduction of the Vivado Design Suite Tcl Command Reference (UG835) for<br/>
		/// more information on the init.tcl file.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following examples show how to obtain help for properties of design objects, or a class of<br/>
		/// design objects:<br/>
		/// help -class cell -prop NAME<br/>
		/// help -prop NAME [get_cells cpuEngine]<br/>
		/// Note: In the preceding example, the first command returns general information related to the NAME<br/>
		/// property, while the second command also returns the value of the NAME property on the specified design<br/>
		/// object.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 972<br/>
		/// </para>
		/// </summary>
		/// <param name="category">(Optional) Search for topics in the specified category</param>
		/// <param name="args">(Optional) Display arguments description</param>
		/// <param name="syntax">(Optional) Display syntax description</param>
		/// <param name="long">(Optional) Display long help description</param>
		/// <param name="prop">(Optional) Display property help for matching property names Default: *</param>
		/// <param name="class">(Optional) Display object type help</param>
		/// <param name="message">
		/// <para>
		/// (Optional)<br/>
		/// Display information about the message with the given<br/>
		/// message. Every message delivered by the tool has a unique<br/>
		/// global message ID that consists of an application sub-system code and a message identifier. Example: -message<br/>
		/// {Common 17-8}.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="pattern_or_object">(Optional) Display help for topics that match the specified pattern Default: *</param>
		public TTCL help(String category = null, bool? args = null, bool? syntax = null, bool? @long = null, String prop = null, String @class = null, String message = null, bool? quiet = null, bool? verbose = null, TCLObject pattern_or_object = null)
		{
			// TCL Syntax: help [-category <arg>] [-args] [-syntax] [-long] [-prop <arg>] [-class <arg>] [-message <arg>] [-quiet] [-verbose] [<pattern_or_object>]
			_tcl.Entry(_builder.help(category, args, syntax, @long, prop, @class, message, quiet, verbose, pattern_or_object));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Import files and/or directories into the active fileset<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: import_files [-fileset &lt;arg&gt;] [-force] [-of_objects &lt;args&gt;] [-norecurse] [-flat] [-relative_to &lt;arg&gt;] [-quiet] [-verbose] [&lt;files&gt;...]
		/// <br/>
		/// <para>
		/// Imports one or more files or the source file contents of one or more directories to the specified<br/>
		/// fileset.<br/>
		/// For every file added to a project the Vivado Design Suite attempts to store and maintain both a<br/>
		/// relative path and an absolute path to the file or directory. When a project is opened, these paths<br/>
		/// are used to locate the files and directories. By default the Vivado Design Suite applies a Relative<br/>
		/// First approach to resolving paths, searching the relative path first, then the absolute path. You<br/>
		/// can use the PATH_MODE property to change how the Vivado tool resolves file paths or<br/>
		/// properties for specific objects. For more information, see the Vivado Design Suite Properties<br/>
		/// Reference Guide (UG912).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// IMPORTANT! Importing multiple files one at a time can cause noticeable performance degradation. It is<br/>
		/// more efficient to use a single import_files command to import a list of files:<br/>
		/// import_files {file1 file2 file3 ... fileN}<br/>
		/// This command is different from the add_files command, which adds files by reference into the<br/>
		/// specified fileset. This command imports the files into the local project folders under<br/>
		/// project.srcs\&lt;fileset&gt;\imports and then adds the file to the specified fileset.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example imports the top.ucf file into the constrs_1 constraint fileset.<br/>
		/// import_files -fileset constrs_1 top.ucf<br/>
		/// The following example imports the valid source files into the source fileset (sources_1) as a<br/>
		/// default since the -fileset argument is not specified. In addition, the -norecurse argument<br/>
		/// restricts the tool to looking only in the specified \level1 directory and not searching any<br/>
		/// subdirectories. All valid source files will be imported into the \imports folder of the project<br/>
		/// because the -flat argument has been specified.<br/>
		/// import_files C:/Data/FPGA_Design/level1 -norecurse -flat<br/>
		/// Note: Without the -flat option a \level1 directory would be created inside of the \imports folder of<br/>
		/// the project.<br/>
		/// The following example imports files into the source fileset (sources_1) because the -fileset<br/>
		/// argument is not specified. Valid source files are imported from the \level1 directory, and all<br/>
		/// subdirectories, and the files will be written into the \imports folder of the project starting at<br/>
		/// the \Data directory due to the use of the -relative_to argument.<br/>
		/// import_files C:/Data/FPGA_Design/level1 -relative_to C:/Data<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 984<br/>
		/// </para>
		/// </summary>
		/// <param name="fileset">(Optional) Fileset name</param>
		/// <param name="force">(Optional) Overwrite files of the same name in project directory</param>
		/// <param name="of_objects">(Optional) RMs to import the files to</param>
		/// <param name="norecurse">(Optional) Disables the default behavior of recursive directory searches</param>
		/// <param name="flat">(Optional) Import the files into a flat directory structure</param>
		/// <param name="relative_to">(Optional) Import the files with respect to the given relative directory</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="files">(Optional) Name of the files to import into fileset</param>
		/// <returns>A list of file objects that were imported</returns>
		public TTCL import_files(String fileset = null, bool? force = null, TCLParameterList of_objects = null, bool? norecurse = null, bool? flat = null, String relative_to = null, bool? quiet = null, bool? verbose = null, TCLObjectList files = null)
		{
			// TCL Syntax: import_files [-fileset <arg>] [-force] [-of_objects <args>] [-norecurse] [-flat] [-relative_to <arg>] [-quiet] [-verbose] [<files>...]
			_tcl.Entry(_builder.import_files(fileset, force, of_objects, norecurse, flat, relative_to, quiet, verbose, files));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Import an IP file and add it to the fileset<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: import_ip [-srcset &lt;arg&gt;] [-name &lt;arg&gt;] [-quiet] [-verbose] [&lt;files&gt;]
		/// <br/>
		/// <para>
		/// Adds an existing XCI or XCO file as an IP source into the current project, and copies it into the<br/>
		/// local project directory structure.<br/>
		/// The import_ip command allows you to read existing IP files directly, and copy them into the<br/>
		/// local project folders. Use the read_ip or add_files command to add IP files by reference into<br/>
		/// the current project.<br/>
		/// Use the create_ip command to create new IP files from the current IP catalog.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example copies the 10gig ethernet core into the current project, and assigns it a<br/>
		/// name of IP_block1:<br/>
		/// import_ip C:/Data/FPGA_Design/10gig_eth.xci -name IP_block1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 987<br/>
		/// </para>
		/// </summary>
		/// <param name="srcset">
		/// <para>
		/// (Optional)<br/>
		/// (Optional) Specifies the source file set containing the objects<br/>
		/// to be upgraded Default: The current source fileset Values:<br/>
		/// Source set name<br/>
		/// </para>
		/// </param>
		/// <param name="name">
		/// <para>
		/// (Optional)<br/>
		/// (Optional) Specifies a replacement name for the imported<br/>
		/// IP; may not be used with multiple files. Default: The current<br/>
		/// name for the imported IP Values: The new name for the<br/>
		/// imported IP<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="files">
		/// <para>
		/// (Optional)<br/>
		/// Names of the IP files to be imported Values: A list of XCI<br/>
		/// (and/or XCO) file name(s)<br/>
		/// </para>
		/// </param>
		/// <returns>list of file objects that were added</returns>
		public TTCL import_ip(String srcset = null, String name = null, bool? quiet = null, bool? verbose = null, TCLObject files = null)
		{
			// TCL Syntax: import_ip [-srcset <arg>] [-name <arg>] [-quiet] [-verbose] [<files>]
			_tcl.Entry(_builder.import_ip(srcset, name, quiet, verbose, files));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Imports the given Synplify project file<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: import_synplify [-copy_sources] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Imports Synplify synthesis project files (.prj) into the current project, including the various<br/>
		/// source files used in the synthesis run.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a new project and imports the specified Synplify project file,<br/>
		/// copying the various source files from the Synplify project into the local project directories:<br/>
		/// create_project syn_test C:/Data/FPGA_Design/syn_test<br/>
		/// import_synplify -copy_sources C:/Data/syn_data.prj<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 989<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Name of the Synplify project file to be imported</param>
		/// <param name="copy_sources">
		/// <para>
		/// (Optional)<br/>
		/// Copy all the sources from synplify project file into the<br/>
		/// created project<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of files object that were imported from the Synplify file</returns>
		public TTCL import_synplify(TCLObject file, bool? copy_sources = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: import_synplify [-copy_sources] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.import_synplify(file, copy_sources, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Import XISE project file settings into the created project<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: import_xise [-copy_sources] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Imports an ISE project file (XISE) into the current project. This allows ISE projects to be quickly<br/>
		/// migrated into the Vivado Design Suite for synthesis, simulation, and implementation. All project<br/>
		/// source files, constraint files, simulation files, and run settings are imported from the ISE project<br/>
		/// and recreated in the current project.<br/>
		/// This command should be run on a new empty project. Since source files, constraints, and run<br/>
		/// settings are imported from the ISE project, any existing source files or constraints may be<br/>
		/// overwritten.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a new project called importISE, and then imports the ISE project<br/>
		/// file (first_use.xise) into the new project.<br/>
		/// create_project importISE C:/Data/importISE import_xise \<br/>
		/// C:/Data/FPGA_design/ise_designs/drp_des/first_use.xise<br/>
		/// Note: This example does not specify the -copy_sources argument, so all source files in the ISE project<br/>
		/// will be added to the current project by reference.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 991<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Name of the XISE project file to be imported</param>
		/// <param name="copy_sources">(Optional) Copy all ISE sources into the created project</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>true</returns>
		public TTCL import_xise(TCLObject file, bool? copy_sources = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: import_xise [-copy_sources] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.import_xise(file, copy_sources, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Imports the given XST project file<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: import_xst [-copy_sources] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Imports XST synthesis project files into the current project, including the various source files<br/>
		/// used in the XST run.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a new project called xst_test, and imports the drp_des.xst<br/>
		/// file:<br/>
		/// create_project xst_test C:/Data/FPGA_Design/xst_test<br/>
		/// import_xst C:/Data/ise_designs/drp_des.xst<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 993<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Name of the XST project file to be imported</param>
		/// <param name="copy_sources">(Optional) Copy all the sources from xst project file into the created project</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of files object that were imported from the XST file</returns>
		public TTCL import_xst(TCLObject file, bool? copy_sources = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: import_xst [-copy_sources] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.import_xst(file, copy_sources, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Launch a set of runs<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: launch_runs [-jobs &lt;arg&gt;] [-scripts_only] [-lsf &lt;arg&gt;] [-sge &lt;arg&gt;] [-cluster_configuration &lt;arg&gt;] [-dir &lt;arg&gt;] [-to_step &lt;arg&gt;] [-next_step] [-host &lt;args&gt;] [-remote_cmd &lt;arg&gt;] [-email_to &lt;args&gt;] [-email_all] [-pre_launch_script &lt;arg&gt;] [-post_launch_script &lt;arg&gt;] [-custom_script &lt;arg&gt;] [-force] [-quiet] [-verbose] &lt;runs&gt;...
		/// <br/>
		/// <para>
		/// Launches synthesis and implementation runs when running the Vivado tools in Project Mode.<br/>
		/// Refer to the Vivado Design Suite User Guide: Design Flows Overview (UG892) for a complete<br/>
		/// description of Project Mode and Non-Project Mode.<br/>
		/// A run must be previously defined using the create_run command, and the properties of the<br/>
		/// run must be previously configured using the set_property command. Both synthesis and<br/>
		/// implementation runs can be specified in the same launch_runs command. However, to launch<br/>
		/// an implementation run, the parent synthesis run must already be complete.<br/>
		/// In Non-Project Mode, Vivado synthesis can be launched directly using the synth_design<br/>
		/// command, and does not require the use of a defined run.<br/>
		/// In Non-Project Mode, Vivado implementation steps can be launched individually with the<br/>
		/// opt_design, power_opt_design, place_design, route_design, phys_opt_design,<br/>
		/// and write_bitstream commands.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following command launches three different synthesis runs with two parallel jobs:<br/>
		/// launch_runs synth_1 synth_2 synth_4 -jobs 2<br/>
		/// Note: The results for each run will be written to a separate folder synth_1, synth_2, and synth_4<br/>
		/// inside of the &lt;project&gt;.runs directory.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example creates a results directory to write run results. In this case a separate<br/>
		/// folder named impl_3, impl_4, and synth_3 will be written to the specified directory. In<br/>
		/// addition, the -scripts_only argument tells the tool to write runme.bat scripts to each of<br/>
		/// these folders but not to launch the runs at this time.<br/>
		/// launch_runs impl_3 impl_4 synth_3 -dir C:/Data/FPGA_Design/results -<br/>
		/// scripts_only<br/>
		/// The following example configures the impl_1 run, setting options for Vivado Implementation<br/>
		/// 2013, enabling some of the optional optimizations, and then launches the run to the<br/>
		/// place_design step:<br/>
		/// set_property flow {Vivado Implementation 2013} [get_runs impl_1]<br/>
		/// set_property STEPS.POWER_OPT_DESIGN.IS_ENABLED true [get_runs impl_1]<br/>
		/// set_property STEPS.POST_PLACE_POWER_OPT_DESIGN.IS_ENABLED true \<br/>
		/// [get_runs impl_1]<br/>
		/// set_property STEPS.PHYS_OPT_DESIGN.IS_ENABLED true [get_runs impl_1]<br/>
		/// launch_runs -to_step place_design impl_1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1012<br/>
		/// </para>
		/// </summary>
		/// <param name="runs">(Required) Runs to launch UG835 (v2020.2) November 18, 2020 www.xilinx.com</param>
		/// <param name="jobs">(Optional) Number of jobs Default: 1</param>
		/// <param name="scripts_only">(Optional) Only generate scripts</param>
		/// <param name="lsf">
		/// <para>
		/// (Optional)<br/>
		/// Use LSF to launch jobs. Required argument is the bsub<br/>
		/// command line to pass to LSF Default: empty<br/>
		/// </para>
		/// </param>
		/// <param name="sge">
		/// <para>
		/// (Optional)<br/>
		/// Use SGE to launch jobs. Required argument is the qsub<br/>
		/// command line to pass to SGE Default: empty<br/>
		/// </para>
		/// </param>
		/// <param name="cluster_configuration">
		/// <para>
		/// (Optional)<br/>
		/// Run jobs on a particular cluster configuration (picks cluster<br/>
		/// configuration from GUI settings). Default: empty<br/>
		/// </para>
		/// </param>
		/// <param name="dir">(Optional) Launch directory</param>
		/// <param name="to_step">
		/// <para>
		/// (Optional)<br/>
		/// Last Step to run. Ignored when launching multiple runs. Not<br/>
		/// valid with -next_step<br/>
		/// </para>
		/// </param>
		/// <param name="next_step">
		/// <para>
		/// (Optional)<br/>
		/// Run next step. Ignored when launching multiple runs. Not<br/>
		/// valid with -to_step.<br/>
		/// </para>
		/// </param>
		/// <param name="host">
		/// <para>
		/// (Optional)<br/>
		/// Launch on specified remote host with a specified number of<br/>
		/// jobs. Example: -host {machine1 2} -host {machine2 4}<br/>
		/// </para>
		/// </param>
		/// <param name="remote_cmd">(Optional) Command to log in to remote hosts Default: ssh -q -o BatchMode=yes</param>
		/// <param name="email_to">
		/// <para>
		/// (Optional)<br/>
		/// List of email addresses to notify when jobs complete (only<br/>
		/// applicable with -host)<br/>
		/// </para>
		/// </param>
		/// <param name="email_all">(Optional) Send email after each job completes (only applicable with - host)</param>
		/// <param name="pre_launch_script">(Optional) Script to run before launching each job (only applicable with -host)</param>
		/// <param name="post_launch_script">(Optional) Script to run after each job completes (only applicable with - host)</param>
		/// <param name="custom_script">
		/// <para>
		/// (Optional)<br/>
		/// User run script map file which contains run name to user<br/>
		/// run script mapping<br/>
		/// </para>
		/// </param>
		/// <param name="force">
		/// <para>
		/// (Optional)<br/>
		/// Run the command, even if there are pending constraint<br/>
		/// changes, which will be lost (in a Dynamic Function eXchange<br/>
		/// design)<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL launch_runs(TCLObjectList runs, Int32? jobs = null, bool? scripts_only = null, String lsf = null, String sge = null, String cluster_configuration = null, String dir = null, String to_step = null, bool? next_step = null, TCLParameterList host = null, String remote_cmd = null, TCLParameterList email_to = null, bool? email_all = null, String pre_launch_script = null, String post_launch_script = null, String custom_script = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: launch_runs [-jobs <arg>] [-scripts_only] [-lsf <arg>] [-sge <arg>] [-cluster_configuration <arg>] [-dir <arg>] [-to_step <arg>] [-next_step] [-host <args>] [-remote_cmd <arg>] [-email_to <args>] [-email_all] [-pre_launch_script <arg>] [-post_launch_script <arg>] [-custom_script <arg>] [-force] [-quiet] [-verbose] <runs>...
			_tcl.Entry(_builder.launch_runs(runs, jobs, scripts_only, lsf, sge, cluster_configuration, dir, to_step, next_step, host, remote_cmd, email_to, email_all, pre_launch_script, post_launch_script, custom_script, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// List applicable targets for the specified source<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: list_targets [-quiet] [-verbose] &lt;files&gt;
		/// <br/>
		/// <para>
		/// List the targets that are available for a specified IP core, DSP module, or IP Subsystem. The<br/>
		/// following file types are accepted: .xci, .xco, .mdl, .bd, .bxml.<br/>
		/// Use the generate_targets command to generate the listed targets.<br/>
		/// The command returns the list of available targets. If no targets are available for the specified file<br/>
		/// objects, nothing is returned.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example lists the available targets for any DSP modules in the design:<br/>
		/// list_targets [get_files *.mdl]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1038<br/>
		/// </para>
		/// </summary>
		/// <param name="files">(Required) Source file for which the targets needs to be listed</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of targets</returns>
		public TTCL list_targets(TCLObject files, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: list_targets [-quiet] [-verbose] <files>
			_tcl.Entry(_builder.list_targets(files, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Locks or unlocks netlist, placement or routing of a design. The 'lock/unlock' will only applied on<br/>
		/// physically placed cells and routed nets<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: lock_design [-level &lt;arg&gt;] [-unlock] [-export] [-quiet] [-verbose] [&lt;cell&gt;]
		/// <br/>
		/// <para>
		/// This command is used in the Hierarchical Design Flows for Design Preservation and Partial<br/>
		/// Reconfiguration. Refer to the Vivado Design Suite User Guide: Hierarchical Design (UG905) for more<br/>
		/// information on these design flows, and the use of this command.<br/>
		/// The lock_design command is used to lock down the placement and/or routing of a design, or<br/>
		/// of the specified cell of a design. After reading in an Out-of-Context (OOC) design checkpoint<br/>
		/// using the read_checkpoint command, the preservation level for the module must be defined.<br/>
		/// This command sets the IS_LOC_FIXED, IS_BEL_FIXED, and IS_ROUTE_FIXED properties of the<br/>
		/// specified logic.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example locks the netlist, placement, and routing data for the specified cells of the<br/>
		/// current design:<br/>
		/// lock_design -level routing [get_cells usbEngine*]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This example unlocks the routing data for the specified cells of the current design, while leaving<br/>
		/// the netlist and placement data locked from the prior example:<br/>
		/// lock_design -unlock -level routing [get_cells usbEngine*]<br/>
		/// The following example unlocks the routing, placement, and netlist data for the specified cells of<br/>
		/// the current design:<br/>
		/// lock_design -unlock -level logical [get_cells usbEngine*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1042<br/>
		/// </para>
		/// </summary>
		/// <param name="level">
		/// <para>
		/// (Optional)<br/>
		/// specify the locking and unlocking level; Valid values are<br/>
		/// logical, placement, and routing. Default: placement<br/>
		/// </para>
		/// </param>
		/// <param name="unlock">
		/// <para>
		/// (Optional)<br/>
		/// Unlock cells, if cells are not specified, whole design is<br/>
		/// unlocked; '-level' parameter must be specified for<br/>
		/// unlocking.<br/>
		/// </para>
		/// </param>
		/// <param name="export">(Optional) mark that the constraints can be exported.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="cell">
		/// <para>
		/// (Optional)<br/>
		/// Lock cells, if cells are not specified, whole design is locked.<br/>
		/// Notice only placed cells and routed nets will be locked.<br/>
		/// Default: *<br/>
		/// </para>
		/// </param>
		public TTCL lock_design(String level = null, bool? unlock = null, bool? export = null, bool? quiet = null, bool? verbose = null, TCLObject cell = null)
		{
			// TCL Syntax: lock_design [-level <arg>] [-unlock] [-export] [-quiet] [-verbose] [<cell>]
			_tcl.Entry(_builder.lock_design(level, unlock, export, quiet, verbose, cell));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Generate HDL wrapper for the specified source<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: make_wrapper [-top] [-testbench] [-inst_template] [-fileset &lt;arg&gt;] [-import] [-force] [-quiet] [-verbose] &lt;files&gt;
		/// <br/>
		/// <para>
		/// Create a Verilog or VHDL wrapper for instantiating a sub-design into the project.<br/>
		/// The make_wrapper command will create a wrapper for Embedded Processor Designs from the<br/>
		/// IP integrator of the Vivado Design Suite, or any IP integrator block design, as well as DSP<br/>
		/// modules created in System Generator or MathWorks MatLab.<br/>
		/// You can generate a wrapper to make the sub-design the top-level of a stand-alone design, or for<br/>
		/// instantiating a sub-design into an existing design. You can also generate a wrapper for a<br/>
		/// simulation test bench of System Generator sub-designs.<br/>
		/// Note: The wrapper is generated in Verilog or VHDL according to the TARGET_LANGUAGE property on the<br/>
		/// project.<br/>
		/// The command returns information related to the creation of the wrappers, or returns an error if it<br/>
		/// fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates the instantiation template to integrate the specified IP integrator<br/>
		/// block design into the design hierarchy of the current project:<br/>
		/// make_wrapper -inst_template -fileset [get_filesets sources_1] \<br/>
		/// -files [get_files C:/Data/design_1/design_1.bd]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1059<br/>
		/// </para>
		/// </summary>
		/// <param name="files">(Required) Source file for which the wrapper needs to be generated</param>
		/// <param name="top">(Optional) Create a top-level wrapper for the specified source</param>
		/// <param name="testbench">(Optional) Create a testbench for the specified source</param>
		/// <param name="inst_template">
		/// <para>
		/// (Optional)<br/>
		/// Create an instantiation template for the specified source.<br/>
		/// The template will not be added to the project and will be<br/>
		/// generated for reference purposes only.<br/>
		/// </para>
		/// </param>
		/// <param name="fileset">(Optional) Fileset name</param>
		/// <param name="import">(Optional) Import generated wrapper to the project</param>
		/// <param name="force">(Optional) Overwrite existing source(s)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL make_wrapper(TCLObject files, bool? top = null, bool? testbench = null, bool? inst_template = null, String fileset = null, bool? import = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: make_wrapper [-top] [-testbench] [-inst_template] [-fileset <arg>] [-import] [-force] [-quiet] [-verbose] <files>
			_tcl.Entry(_builder.make_wrapper(files, top, testbench, inst_template, fileset, import, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Reposition the Gadget for Project summary dashboard<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: move_dashboard_gadget -name &lt;arg&gt; -row &lt;arg&gt; -col &lt;arg&gt; [-dashboard &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Specify the placement of a dashboard gadget into the dashboard.<br/>
		/// TIP: Currently the Project Summary is the only dashboard, so the gadget is placed into that dashboard.<br/>
		/// The arrangement of gadgets in a dashboard is by row and column. The Project Summary<br/>
		/// dashboard has two columns, 0 and 1, and has as many rows as needed to display all the gadgets.<br/>
		/// If you specify a column other than 0 or 1, or specify a row in excess of the current defined rows +<br/>
		/// 1, an error will be returned.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1068<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of the gadget</param>
		/// <param name="row">(Required) Target row number to which the gadget has to be moved</param>
		/// <param name="col">(Required) Target column number to which the gadget has to be moved</param>
		/// <param name="dashboard">(Optional) Name of the dashboard to which the gadget is associated</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL move_dashboard_gadget(String name, String row, String col, String dashboard = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: move_dashboard_gadget -name <arg> -row <arg> -col <arg> [-dashboard <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.move_dashboard_gadget(name, row, col, dashboard, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Moves the files from one fileset to another while maintaining all of their original properties.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: move_files [-fileset &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;files&gt;...]
		/// <br/>
		/// <para>
		/// Moves files returned by the get_files command from one fileset to another while maintaining<br/>
		/// the properties on the files.<br/>
		/// This command returns the list of files that were moved, or an error if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example moves the file, top_full.xdc, to the constrs_2 fileset.<br/>
		/// move_files -fileset constrs_2 [get_files top_full.xdc]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1070<br/>
		/// </para>
		/// </summary>
		/// <param name="fileset">(Optional) Destination fileset name</param>
		/// <param name="of_objects">(Optional) Reconfig Modules to move the files to</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="files">(Optional) Name of the files to be moved</param>
		/// <returns>list of files that were moved</returns>
		public TTCL move_files(String fileset = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObjectList files = null)
		{
			// TCL Syntax: move_files [-fileset <arg>] [-of_objects <args>] [-quiet] [-verbose] [<files>...]
			_tcl.Entry(_builder.move_files(fileset, of_objects, quiet, verbose, files));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Open a design checkpoint in a new project<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: open_checkpoint [-part &lt;arg&gt;] [-ignore_timing] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Open a design checkpoint file (DCP), create a new in-memory project and initialize a design<br/>
		/// immediately in the new project with the contents of the checkpoint. This command can be used<br/>
		/// to open a top-level design checkpoint, or the checkpoint created for an out-of-context module.<br/>
		/// When opening a checkpoint, there is no need to create a project first. The open_checkpoint<br/>
		/// command reads the design data into memory, opening the design in Non-Project Mode. Refer to<br/>
		/// the Vivado Design Suite User Guide: Design Flows Overview (UG892) for more information on<br/>
		/// Project Mode and Non-Project Mode.<br/>
		/// Note: When multiple design checkpoints are open in the Vivado tool, you must use the<br/>
		/// current_project command to switch between the open designs. You can use current_design to<br/>
		/// check which checkpoint is the active design.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example opens the specified checkpoint file, and specifies the target part for the<br/>
		/// design:<br/>
		/// open_checkpoint C:/Data/state1/checkpoint.dcp -part xc7k325tffg900-2<br/>
		/// Note: If the specified part is not compatible with the device and package used by the specified checkpoint,<br/>
		/// the command will return an error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1075<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Design checkpoint file</param>
		/// <param name="part">
		/// <para>
		/// (Optional)<br/>
		/// Override the checkpoint part. Note that this may cause<br/>
		/// errors if the checkpoint contains xdef.<br/>
		/// </para>
		/// </param>
		/// <param name="ignore_timing">
		/// <para>
		/// (Optional)<br/>
		/// reload a checkpoint without the timing constraints. Will not<br/>
		/// work if '-time' option given.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL open_checkpoint(TCLObject file, String part = null, bool? ignore_timing = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: open_checkpoint [-part <arg>] [-ignore_timing] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.open_checkpoint(file, part, ignore_timing, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Open the example project for the indicated IP<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: open_example_project [-dir &lt;arg&gt;] [-force] [-in_process] [-quiet] [-verbose] &lt;objects&gt;...
		/// <br/>
		/// <para>
		/// Open an example project for the specified IP cores. The example project can be used to explore<br/>
		/// the features of the IP core in a stand-alone project, instead of integrated into the current project.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following copies the IP customization and opens the example project for the specified IP<br/>
		/// core in a new location:<br/>
		/// open_example_project -dir C:/Data/examples -force [get_ips blk_mem*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1077<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) The objects whose example projects will be opened</param>
		/// <param name="dir">(Optional) Path to directory where example project will be created</param>
		/// <param name="force">(Optional) Overwrite an example project if it exists</param>
		/// <param name="in_process">(Optional) Open the example project in the same process</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The Project that was opened</returns>
		public TTCL open_example_project(TCLObjectList objects, String dir = null, bool? force = null, bool? in_process = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: open_example_project [-dir <arg>] [-force] [-in_process] [-quiet] [-verbose] <objects>...
			_tcl.Entry(_builder.open_example_project(objects, dir, force, in_process, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Open an IO design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: open_io_design [-name &lt;arg&gt;] [-part &lt;arg&gt;] [-constrset &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Opens a new or existing I/O Pin Planning design.<br/>
		/// Note: The design_mode property for the current source fileset must be defined as PinPlanning in order to<br/>
		/// open an I/O design. If not, you will get the following error:<br/>
		/// ERROR: The design mode of 'sources_1' must be PinPlanning<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following creates a new I/O design called myIO:<br/>
		/// open_io_design -name myIO<br/>
		/// Note: The default source set, constraint set, and part will be used in this case.<br/>
		/// The following example opens an existing I/O design called myIO, and specifies the constraint set<br/>
		/// to be used:<br/>
		/// open_io_design -name myIO -constrset topCon<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1087<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Optional) Design name</param>
		/// <param name="part">(Optional) Target part</param>
		/// <param name="constrset">(Optional) Constraint fileset to use</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>design object</returns>
		public TTCL open_io_design(String name = null, String part = null, String constrset = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: open_io_design [-name <arg>] [-part <arg>] [-constrset <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.open_io_design(name, part, constrset, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Open a Vivado project file (.xpr)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: open_project [-part &lt;arg&gt;] [-read_only] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Opens the specified Vivado Design Suite project file (.xpr), or the project file for the Vivado Lab<br/>
		/// Edition (.lpr).<br/>
		/// IMPORTANT! The open_project command has a different command syntax in the Vivado Lab<br/>
		/// Edition. The -part option is not supported because the Vivado Lab Edition project (.lpr ) does not<br/>
		/// specify a target part. The current_hw_target and current_hw_device commands determine<br/>
		/// the target part.<br/>
		/// This command returns a transcript of its process and the name of the created project, or returns<br/>
		/// an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example opens the project named my_project1 located in the Designs directory.<br/>
		/// open_project C:/Designs/project1.xpr<br/>
		/// Note: The project must be specified with the .xpr extension for the tool to recognize it as a project file.<br/>
		/// The path to the file must be specified along with the project file name or the tool will return an error that it<br/>
		/// cannot find the specified file.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1089<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Project file to be read</param>
		/// <param name="part">(Optional) Open the project using this part (overrides project's part)</param>
		/// <param name="read_only">(Optional) Open the project in read-only mode</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>opened project object</returns>
		public TTCL open_project(TCLObject file, String part = null, bool? read_only = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: open_project [-part <arg>] [-read_only] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.open_project(file, part, read_only, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Open a run into a netlist or implementation design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: open_run [-name &lt;arg&gt;] [-pr_config &lt;arg&gt;] [-quiet] [-verbose] &lt;run&gt;
		/// <br/>
		/// <para>
		/// Opens the specified synthesis run into a Netlist Design or implementation run into an<br/>
		/// Implemented Design. The run properties defining the target part and constraint set are combined<br/>
		/// with the synthesis or implementation results to create the design view in the tool.<br/>
		/// This command is intended to open a synthesized or implemented design that was created from<br/>
		/// design runs in Project Mode in the Vivado Design Suite.<br/>
		/// Use the open_checkpoint command to open a Non-Project based checkpoint into memory,<br/>
		/// opening the design in Non-Project Mode. Refer to the Vivado Design Suite User Guide: Design<br/>
		/// Flows Overview (UG892) for more information on Project Mode and Non-Project Mode.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following command opens the specified synthesis run into a Netlist Design named<br/>
		/// synthPass1:<br/>
		/// open_run -name synthPass1 synth_1<br/>
		/// The following opens an Implemented Design for impl_1:<br/>
		/// open_run impl_1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1094<br/>
		/// </para>
		/// </summary>
		/// <param name="run">(Required) Run to open into the design</param>
		/// <param name="name">(Optional) Design name</param>
		/// <param name="pr_config">
		/// <para>
		/// (Optional)<br/>
		/// PR Configuration to apply while opening the design (only<br/>
		/// valid when opening a synthesis run)<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>design object</returns>
		public TTCL open_run(TCLObject run, String name = null, String pr_config = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: open_run [-name <arg>] [-pr_config <arg>] [-quiet] [-verbose] <run>
			_tcl.Entry(_builder.open_run(run, name, pr_config, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Refresh the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: refresh_design [-part &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Reloads the current design from the project data on the hard drive. This overwrites the in-memory view of the design to undo any recent design changes.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following command reloads the current design from the project data on hard disk. This will<br/>
		/// overwrite the unsaved changes of the design which are in memory.<br/>
		/// refresh_design<br/>
		/// Note: You can use the command to undo a series of changes to the design and revert to the previously<br/>
		/// saved design.<br/>
		/// The following example refreshes the current design using the specified V6 part as the target<br/>
		/// device. The second command is required to make the selected part the target device for the<br/>
		/// active implementation run.<br/>
		/// refresh_design -part xc6vcx75tff784-1<br/>
		/// set_property part xc6vcx75tff784-1 [get_runs impl_6]<br/>
		/// Note: The second command is not required if the target part is not changed.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1198<br/>
		/// </para>
		/// </summary>
		/// <param name="part">(Optional) Target part</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_design(String part = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_design [-part <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.refresh_design(part, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Update and initialize the BRAM initialization strings with contents of elf files.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: refresh_meminit [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1223<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_meminit(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_meminit [-quiet] [-verbose]
			_tcl.Entry(_builder.refresh_meminit(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Reimport files when they are found out-of-date<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reimport_files [-force] [-quiet] [-verbose] [&lt;files&gt;...]
		/// <br/>
		/// <para>
		/// Reimports project files. This updates the local project files from the original referenced source<br/>
		/// files.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reimports all project files regardless of whether they are out of date, or<br/>
		/// the local files are newer than the referenced source file:<br/>
		/// reimport_files -force<br/>
		/// Note: No warnings will be issued for newer local files that will be overwritten.<br/>
		/// The following example reimports the specified files to the project, but only if the original source<br/>
		/// file is newer than the local project file:<br/>
		/// reimport_files C:/Data/FPGA_Design/source1.v \<br/>
		/// C:/Data/FPGA_Design/source2.vhdl<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1229<br/>
		/// </para>
		/// </summary>
		/// <param name="force">(Optional) Force a reimport to happen even when the local files may be newer</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="files">
		/// <para>
		/// (Optional)<br/>
		/// List of files to reimport. If no files are specified, all files in<br/>
		/// the project that are out-of-date, will be reimported<br/>
		/// </para>
		/// </param>
		/// <returns>list of file objects that were imported</returns>
		public TTCL reimport_files(bool? force = null, bool? quiet = null, bool? verbose = null, TCLObjectList files = null)
		{
			// TCL Syntax: reimport_files [-force] [-quiet] [-verbose] [<files>...]
			_tcl.Entry(_builder.reimport_files(force, quiet, verbose, files));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove files or directories from a fileset<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_files [-fileset &lt;arg&gt;] [-quiet] [-verbose] &lt;files&gt;...
		/// <br/>
		/// <para>
		/// Removes the specified file objects from the current or specified fileset. The file is removed from<br/>
		/// the current project, but is not removed from the disk.<br/>
		/// Files can be specified as file name strings, or as file objects returned by the get_files<br/>
		/// command. When specified as strings, the file is looked for in the current or specified fileset.<br/>
		/// When the file object is specified by get_files, the fileset is defined by the object, and -<br/>
		/// fileset is ignored.<br/>
		/// When successful, this command returns nothing. If the specified file is not found, an error is<br/>
		/// returned.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example removes the file named C:/Design/top.xdc from the constraint set<br/>
		/// constrs_1:<br/>
		/// remove_files -fileset constrs_1 C:/Design/top.xdc<br/>
		/// Multiple files can be specified as follows:<br/>
		/// remove_files -fileset sim_1 top_tb1.vhdl top_tb2.vhdl<br/>
		/// The following example gets all the file objects in the current project, and removes them:<br/>
		/// remove_files [get_files]<br/>
		/// CAUTION! This will remove ALL files from your design.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1247<br/>
		/// </para>
		/// </summary>
		/// <param name="files">(Required) Name of the file(s) to be removed</param>
		/// <param name="fileset">(Optional) Fileset name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of files that were removed</returns>
		public TTCL remove_files(TCLObjectList files, String fileset = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_files [-fileset <arg>] [-quiet] [-verbose] <files>...
			_tcl.Entry(_builder.remove_files(files, fileset, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Change the order of source files in the active fileset<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reorder_files [-fileset &lt;arg&gt;] [-before &lt;arg&gt;] [-after &lt;arg&gt;] [-front] [-back] [-auto] [-disable_unused] [-quiet] [-verbose] &lt;files&gt;...
		/// <br/>
		/// <para>
		/// Reorders source files in the specified fileset. Takes the files indicated and places them at the front<br/>
		/// of, the back of, or before or after other files within the fileset. This command also has an auto<br/>
		/// reorder feature that reorders the files based on the requirements of the current top module in<br/>
		/// the design.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example takes the specified files and moves them to the front of the source fileset:<br/>
		/// reorder_files -front {C:/Data/FPGA/file1.vhdl C:/Data/FPGA/file2.vhdl}<br/>
		/// Note: The default source fileset is used in the preceding example since the -fileset argument is not<br/>
		/// specified.<br/>
		/// The following example sets a new top_module in the design, and then automatically reorders and<br/>
		/// disables unused files based on the hierarchy of the new top-module:<br/>
		/// set_property top block1 [current_fileset]<br/>
		/// reorder_files -auto -disable_unused<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1286<br/>
		/// </para>
		/// </summary>
		/// <param name="files">(Required) Files to move</param>
		/// <param name="fileset">(Optional) Fileset to reorder</param>
		/// <param name="before">(Optional) Move the listed files before this file</param>
		/// <param name="after">(Optional) Move the listed files after this file</param>
		/// <param name="front">(Optional) Move the listed files to the front (default)</param>
		/// <param name="back">(Optional) Move the listed files to the back</param>
		/// <param name="auto">(Optional) Automatically re-orders the given fileset</param>
		/// <param name="disable_unused">(Optional) Disables all files not associated with the TOP design unit</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reorder_files(TCLObjectList files, String fileset = null, String before = null, String after = null, bool? front = null, bool? back = null, bool? auto = null, bool? disable_unused = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reorder_files [-fileset <arg>] [-before <arg>] [-after <arg>] [-front] [-back] [-auto] [-disable_unused] [-quiet] [-verbose] <files>...
			_tcl.Entry(_builder.reorder_files(files, fileset, before, after, front, back, auto, disable_unused, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report the compile order by analyzing files and constructing a hierarchy.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_compile_order [-fileset &lt;arg&gt;] [-missing_instances] [-constraints] [-sources] [-used_in &lt;arg&gt;] [-file &lt;arg&gt;] [-append] [-of_objects &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Report the compilation order of files in the various active filesets: constraints, design sources,<br/>
		/// and simulation sources.<br/>
		/// This command returns the order of file processing for synthesis, implementation, and simulation.<br/>
		/// The report can be limited by specifying the fileset of interest with -fileset, or using the -<br/>
		/// constraints option or -sources option.<br/>
		/// The -used_in option lets you report the processing order of files used in Synthesis, Simulation, or<br/>
		/// one of the implementation steps, according to the value of the USED_IN property.<br/>
		/// By default the report is returned to the Tcl console, or standard output, but it can also be written<br/>
		/// to a file.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the compilation order of the active filesets in the current design:<br/>
		/// report_compile_order<br/>
		/// The following returns a list of cells with missing source files in the current design, and appends<br/>
		/// the report to the specified file:<br/>
		/// report_compile_order -missing_instances -file C:/Data/report1.txt -append<br/>
		/// The following command lists the compile order of the files in the active constraint set:<br/>
		/// report_compile_order -constraints<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1318<br/>
		/// </para>
		/// </summary>
		/// <param name="fileset">(Optional) FileSet to parse to determine compile order</param>
		/// <param name="missing_instances">(Optional) Report missing instances in the design hierarchy</param>
		/// <param name="constraints">(Optional) Report the constraint compile order</param>
		/// <param name="sources">(Optional) Report the source compile order</param>
		/// <param name="used_in">(Optional) Specify the used in filter.</param>
		/// <param name="file">(Optional) Filename to output results to.</param>
		/// <param name="append">(Optional) Append output to existing file</param>
		/// <param name="of_objects">(Optional) Get 'file' objects of these types: 'file fileset ip reconfig_module'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_compile_order(String fileset = null, bool? missing_instances = null, bool? constraints = null, bool? sources = null, String used_in = null, String file = null, bool? append = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_compile_order [-fileset <arg>] [-missing_instances] [-constraints] [-sources] [-used_in <arg>] [-file <arg>] [-append] [-of_objects <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_compile_order(fileset, missing_instances, constraints, sources, used_in, file, append, of_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Reset current project<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_project [-exclude_runs] [-exclude_ips] [-exclude_sim_runs] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Reset the current project to its starting condition, with source and constraint files, by cleaning<br/>
		/// out the various output files created during synthesis, simulation, implementation, and<br/>
		/// write_bitstream. Also resets the state of the project to the start of the design flow.<br/>
		/// TIP: Any user-defined Tcl variables that are in the global namespace (i.e. not in a project-specific<br/>
		/// namespace) are not reset or cleared by this command. Global variables are persistent with the invocation<br/>
		/// of Vivado and are only cleared when the Vivado Design Suite is closed. You can also use the unset<br/>
		/// command to expressly clear a specific Tcl variable.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1509<br/>
		/// </para>
		/// </summary>
		/// <param name="exclude_runs">(Optional) Do not reset runs</param>
		/// <param name="exclude_ips">(Optional) Do not reset ips</param>
		/// <param name="exclude_sim_runs">(Optional) Do not reset simulation runs</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_project(bool? exclude_runs = null, bool? exclude_ips = null, bool? exclude_sim_runs = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_project [-exclude_runs] [-exclude_ips] [-exclude_sim_runs] [-quiet] [-verbose]
			_tcl.Entry(_builder.reset_project(exclude_runs, exclude_ips, exclude_sim_runs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Reset an existing run<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_runs [-prev_step] [-from_step &lt;arg&gt;] [-quiet] [-verbose] &lt;runs&gt;
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1513<br/>
		/// </para>
		/// </summary>
		/// <param name="runs">(Required) Runs to modify</param>
		/// <param name="prev_step">(Optional) Reset last run step</param>
		/// <param name="from_step">(Optional) First Step to reset</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_runs(TCLObject runs, bool? prev_step = null, String from_step = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_runs [-prev_step] [-from_step <arg>] [-quiet] [-verbose] <runs>
			_tcl.Entry(_builder.reset_runs(runs, prev_step, from_step, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Reset target data for the specified source<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_target [-quiet] [-verbose] &lt;name&gt; &lt;objects&gt;
		/// <br/>
		/// <para>
		/// Remove the current target data for the specified IP core. This deletes any files that were<br/>
		/// delivered during generation of the specified targets. This does not remove the core from the<br/>
		/// current project, but does remove the associated target data from its referenced location.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example resets the instantiation template for the specified IP core:<br/>
		/// reset_target instantiation_template [get_ips blk_mem*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1521<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) List of targets to be reset, or 'all' to reset all generated targets</param>
		/// <param name="objects">(Required) The objects for which data needs to be reset</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_target(TCLObject name, TCLObject objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_target [-quiet] [-verbose] <name> <objects>
			_tcl.Entry(_builder.reset_target(name, objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Save the current design's constraints<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: save_constraints [-force] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Saves any changes to the constraints files of the active constraints set. This command writes any<br/>
		/// changes to the constraints files to the project data on the hard drive; saving any work in progress<br/>
		/// and committing any changes.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example saves the constraints files for the active constraints set regardless of any<br/>
		/// changes to the files:<br/>
		/// save_constraints -force<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1571<br/>
		/// </para>
		/// </summary>
		/// <param name="force">
		/// <para>
		/// (Optional)<br/>
		/// Force constraints save, overwriting the target and source<br/>
		/// XDC if necessary<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL save_constraints(bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: save_constraints [-force] [-quiet] [-verbose]
			_tcl.Entry(_builder.save_constraints(force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Save current design's constraints as a new set of constraints files<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: save_constraints_as [-dir &lt;arg&gt;] [-target_constrs_file &lt;arg&gt;] [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Copies the active constraints set to create a new constraints set, with local copies of any<br/>
		/// constraints files that are part of the constraints set. You can also specify a new constraints file to<br/>
		/// use as the target for the copied constraints set.<br/>
		/// Use this command to save changes to the constraints in a design without affecting the current<br/>
		/// constraints files. This allows you to do some "what-if" type development of design constraints.<br/>
		/// Note: The new constraint set created by the save_constraints_as command will not be active in the<br/>
		/// design, although it will be referenced by the design. To make the constraints set active you must set the<br/>
		/// constrset property to point to the new constraints set for specific runs. See the example below.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example saves the active constraints set into a new constraints set called<br/>
		/// constrs_2, and copies any constraints files into the specified directory, as well as creating a new<br/>
		/// target constraints file for the constraints set:<br/>
		/// save_constraints_as -dir C:/Data/con1 \<br/>
		/// -target_constrs_file rev1.xdc constrs_2<br/>
		/// The following example saves the active constraints set as a new constraints set called newCon2,<br/>
		/// and copies any constraint files into the newCon2 constraint directory under project sources. The<br/>
		/// constrset property for the specified synthesis and implementation runs are then set to point to<br/>
		/// the new constraints set:<br/>
		/// save_constraints_as newCon2<br/>
		/// set_property CONSTRSET newCon2 [get_runs synth_1]<br/>
		/// set_property CONSTRSET newCon2 [get_runs impl_1]<br/>
		/// Note: The constraints set is not active in the design until it has been set to active for the current runs.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1573<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of the new constraints fileset</param>
		/// <param name="dir">(Optional) Directory to save constraints to</param>
		/// <param name="target_constrs_file">(Optional) Target constraints file for the new fileset</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL save_constraints_as(TCLObject name, String dir = null, String target_constrs_file = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: save_constraints_as [-dir <arg>] [-target_constrs_file <arg>] [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.save_constraints_as(name, dir, target_constrs_file, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Save the current project under a new name<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: save_project_as [-scan_for_includes] [-exclude_run_results] [-include_local_ip_cache] [-force] [-quiet] [-verbose] &lt;name&gt; [&lt;dir&gt;]
		/// <br/>
		/// <para>
		/// Saves a currently open project file under a new name in the specified directory, or in the current<br/>
		/// working directory if no other directory is specified.<br/>
		/// This command save a Vivado Design Suite project file (.xpr), or a project file for the Vivado Lab<br/>
		/// Edition (.lpr), in the specified directory.<br/>
		/// The command returns the name of the saved project, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example saves the active project as a new project called myProject in a directory<br/>
		/// called myProjectDir:<br/>
		/// save_project_as myProject myProjectDir<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: Because &lt;dir&gt; is specified as the folder name only, the tool will create the project in the current<br/>
		/// working directory, or the directory from which the tool was launched.<br/>
		/// The following example saves the current project to a new project called myProject in a directory<br/>
		/// called C:/Designs/myProjectDir. If you use the -force argument, the tool will overwrite an<br/>
		/// existing project if one is found in the specified location.<br/>
		/// save_project_as myProject C:/Designs/myProjectDir -force<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1575<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) New name for the project to save</param>
		/// <param name="scan_for_includes">(Optional) Scan for include files and add them to the new project</param>
		/// <param name="exclude_run_results">(Optional) Exclude run results in the new project</param>
		/// <param name="include_local_ip_cache">(Optional) Include IP cache results in the new project</param>
		/// <param name="force">(Optional) Overwrite existing project directory</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="dir">(Optional) Directory where the project file is saved Default: .</param>
		/// <returns>saved project object</returns>
		public TTCL save_project_as(TCLObject name, bool? scan_for_includes = null, bool? exclude_run_results = null, bool? include_local_ip_cache = null, bool? force = null, bool? quiet = null, bool? verbose = null, TCLObject dir = null)
		{
			// TCL Syntax: save_project_as [-scan_for_includes] [-exclude_run_results] [-include_local_ip_cache] [-force] [-quiet] [-verbose] <name> [<dir>]
			_tcl.Entry(_builder.save_project_as(name, scan_for_includes, exclude_run_results, include_local_ip_cache, force, quiet, verbose, dir));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Sets the part on the current project. If no project is open, then a diskless project is created.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_part [-quiet] [-verbose] &lt;part&gt;
		/// <br/>
		/// <para>
		/// Change the part used by the current project for subsequent elaboration, synthesis,<br/>
		/// implementation, and analysis.<br/>
		/// TIP: The part is changed for the current project only, and not for the in-memory design. You can change<br/>
		/// the speed grade of the device in the in-memory design for timing analysis using the set_speed_grade<br/>
		/// command. You can change the part used when opening an existing design checkpoint using the -part<br/>
		/// option of the open_checkpoint or read_checkpoint commands.<br/>
		/// This command is provided to let you change the part for the in-memory project of non-project<br/>
		/// based designs, and does not support project-based designs. For a project-based design set the<br/>
		/// PART property on the project as follows:<br/>
		/// set_property PART xc7vx485tffg1158-2 [current_project]<br/>
		/// Use the get_parts command to get a list of the available parts.<br/>
		/// The set_part command creates an in-memory project for a non-project based design, or<br/>
		/// assigns the part to the existing in-memory project.<br/>
		/// Note: For a discussion of Project Mode and Non-Project Mode refer to the Vivado Design Suite User Guide:<br/>
		/// Design Flows Overview (UG892).<br/>
		/// This command returns the part that the in-memory project is set to use, or returns an error if it<br/>
		/// fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1675<br/>
		/// </para>
		/// </summary>
		/// <param name="part">(Required) Set current project's part to this part.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_part(TCLObject part, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_part [-quiet] [-verbose] <part>
			_tcl.Entry(_builder.set_part(part, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set Timing Speed Grade and Temperature Grade<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_speed_grade [-temperature &lt;arg&gt;] [-quiet] [-verbose] [&lt;value&gt;]
		/// <br/>
		/// <para>
		/// Note: After set_speed_grade has been used on a design, it can be used for timing analysis, but it will no<br/>
		/// longer go through implementation. If you want to run implementation on the design, you should save the<br/>
		/// design checkpoint and use read_checkpoint -part to implement the design with the new speed<br/>
		/// grade.<br/>
		/// Sets the speed grade used for timing analysis for the target device in the current design.<br/>
		/// This command is used to change the speed grade of the target device for timing analysis only,<br/>
		/// and does not affect other aspects of the design. It must be run on an opened synthesized or<br/>
		/// implemented design.<br/>
		/// Use the set_speed_grade command prior to the report_timing_summary or<br/>
		/// report_timing command or other timing commands to change the speed grade for analysis. If<br/>
		/// the timing is valid, then you can use the set_property or set_part command to change the<br/>
		/// target part for the project to re-synthesize and implement the design.<br/>
		/// TIP: For UltraScale devices, you can specify either the temperature or the value to define the speed grade<br/>
		/// for the part. For 7 series devices, you can only specify the value.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns a transcript of its process, and the speed grade set, or returns an error if it<br/>
		/// fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets the speed grade for the device in the current design to -1:<br/>
		/// set_speed_grade -1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1686<br/>
		/// </para>
		/// </summary>
		/// <param name="temperature">
		/// <para>
		/// (Optional)<br/>
		/// Temperature grade used for timing analysis (Not available<br/>
		/// for 7 Series and earlier)<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="value">(Optional) Speed grade used for timing analysis</param>
		/// <returns>string result</returns>
		public TTCL set_speed_grade(String temperature = null, bool? quiet = null, bool? verbose = null, TCLObject value = null)
		{
			// TCL Syntax: set_speed_grade [-temperature <arg>] [-quiet] [-verbose] [<value>]
			_tcl.Entry(_builder.set_speed_grade(temperature, quiet, verbose, value));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Generate a synthesis netlist for an IP<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: synth_ip [-force] [-quiet] [-verbose] &lt;objects&gt;
		/// <br/>
		/// <para>
		/// This command is used in the non-project flow to create a synthesized design checkpoint file<br/>
		/// (DCP) to support the out-of-context (OOC) IP flow, or to synthesize and implement an IP module<br/>
		/// in the OOC hierarchical design flow. IP objects are specified by the get_ips command, or for<br/>
		/// the specified IP core file (XCI) as specified by the get_files command.<br/>
		/// IMPORTANT! To enable this functionality, the IP core must be marked for OOC generation by setting the<br/>
		/// GENERATE_SYNTH_CHECKPOINT property to true (or 1) using the set_property command on the<br/>
		/// XCI file.<br/>
		/// For project-based designs you would use the create_ip_run and launch_runs commands.<br/>
		/// Refer to the Vivado Design Suite User Guide: Design Flows Overview (UG892) for more information<br/>
		/// on Project and Non-Project Modes in Vivado.<br/>
		/// The synth_ip command will automatically generate any required target files prior to<br/>
		/// synthesizing the IP core. The source files required to synthesize the IP are copied into the IP run<br/>
		/// directory. Upon completion, any newly generated OOC target files (dcp, stub files, funcsim<br/>
		/// netlists...) are registered with the associated IP core.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example synthesizes the specified IP object, regenerating the netlist if the<br/>
		/// synthesized core is up-to-date:<br/>
		/// synth_ip [get_ips char_fifo] -force<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1742<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) All the objects for which a netlist needs to be generated for.</param>
		/// <param name="force">(Optional) Force regeneration of the netlist.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL synth_ip(TCLObject objects, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: synth_ip [-force] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.synth_ip(objects, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Updates a fileset compile order and possibly top based on a design graph.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: update_compile_order [-force_gui] [-fileset &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Update the compile order of the design sources in the current project, or in the specified fileset.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example updates the compile order of the source files in the simulation fileset:<br/>
		/// update_compile_order -fileset sim_1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1763<br/>
		/// </para>
		/// </summary>
		/// <param name="force_gui">(Optional) Execute this command, even when run interactively in the GUI.</param>
		/// <param name="fileset">(Optional) Fileset to update based on a design graph</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL update_compile_order(bool? force_gui = null, String fileset = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: update_compile_order [-force_gui] [-fileset <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.update_compile_order(force_gui, fileset, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// update the netlist of the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: update_design -cells &lt;args&gt; [-strict] [-from_file &lt;arg&gt;] [-from_design &lt;arg&gt;] [-from_cell &lt;arg&gt;] [-black_box] [-buffer_ports] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This command updates the in-memory design, replacing the current netlist in the specified cell<br/>
		/// with a netlist from a specified file, from another open design, from a specified cell of a design, or<br/>
		/// converts the cell to a black box cell.<br/>
		/// The update_design command can update a single instance, or can update all instances of a<br/>
		/// master cell.<br/>
		/// Only the in-memory view of the design is changed by the new netlist. You must save the design<br/>
		/// using the write_checkpoint command, or any updates will be lost when you close the project<br/>
		/// or exit the tool.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example replaces a black box cell with the netlist from the specified file:<br/>
		/// update_design -from_file C:/Data/cell_contents.v -cell black_box_cell<br/>
		/// The following example updates the netlist in the arnd4 cell with the specified Verilog netlist:<br/>
		/// update_design -cell arnd4 -from_file C:/Data/round_4.v<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example updates the arnd4 cell in the current design with the netlist from the<br/>
		/// same cell in the specified design:<br/>
		/// update_design -cell arnd4 -from_design netlist_2 -from_cell arnd4<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1765<br/>
		/// </para>
		/// </summary>
		/// <param name="cells">(Required) List of cells to update with a new sub-netlist.</param>
		/// <param name="strict">
		/// <para>
		/// (Optional)<br/>
		/// Require exact ports match for replacing cell (otherwise extra<br/>
		/// ports are allowed).<br/>
		/// </para>
		/// </param>
		/// <param name="from_file">(Optional) Name of the file containing the new sub-netlist.</param>
		/// <param name="from_design">(Optional) Name of the an open netlist design containing the new sub-netlist.</param>
		/// <param name="from_cell">(Optional) Name of cell in the from_design which defines the new sub-netlist.</param>
		/// <param name="black_box">(Optional) Update the cell to a black_box.</param>
		/// <param name="buffer_ports">(Optional) buffer all the ports of black box</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL update_design(TCLParameterList cells, bool? strict = null, String from_file = null, String from_design = null, String from_cell = null, bool? black_box = null, bool? buffer_ports = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: update_design -cells <args> [-strict] [-from_file <arg>] [-from_design <arg>] [-from_cell <arg>] [-black_box] [-buffer_ports] [-quiet] [-verbose]
			_tcl.Entry(_builder.update_design(cells, strict, from_file, from_design, from_cell, black_box, buffer_ports, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Update file(s) in the project based on the file(s) or directory(ies) specified<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: update_files [-from_files &lt;args&gt;] [-norecurse] [-to_files &lt;args&gt;] [-filesets &lt;args&gt;] [-force] [-report_only] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Updates the specified files with the contents of specified remote files. Use this command to<br/>
		/// update a local file with the contents of its original remote file, or replace it with the contents of a<br/>
		/// different remote file.<br/>
		/// This command returns a list of updated files, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example updates the various project source IP core files with the specified -<br/>
		/// from_files, reporting the results without making any updates:<br/>
		/// update_files -from_files C:/Data/IP/*.xci \<br/>
		/// -to_file [get_files *.xci} -report_only<br/>
		/// Note: No warnings will be issued for newer local files that will be overwritten.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1768<br/>
		/// </para>
		/// </summary>
		/// <param name="from_files">(Optional) New files and directories to use for updating</param>
		/// <param name="norecurse">(Optional) Recursively search in specified directories</param>
		/// <param name="to_files">(Optional) Existing project files and directories to limit updates to</param>
		/// <param name="filesets">(Optional) Fileset name</param>
		/// <param name="force">
		/// <para>
		/// (Optional)<br/>
		/// Overwrite imported files in the project, even if read-only, if<br/>
		/// possible<br/>
		/// </para>
		/// </param>
		/// <param name="report_only">
		/// <para>
		/// (Optional)<br/>
		/// Do no actual file updates, but report on updates that<br/>
		/// otherwise would have been made<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of the files updated</returns>
		public TTCL update_files(TCLParameterList from_files = null, bool? norecurse = null, TCLParameterList to_files = null, TCLParameterList filesets = null, bool? force = null, bool? report_only = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: update_files [-from_files <args>] [-norecurse] [-to_files <args>] [-filesets <args>] [-force] [-report_only] [-quiet] [-verbose]
			_tcl.Entry(_builder.update_files(from_files, norecurse, to_files, filesets, force, report_only, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Update the dcp by adding the generated sw param info files to it<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: update_sw_parameters [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Updates the design check-points (DCPs) with the latest hardware def. This hardware def will<br/>
		/// have the updated sw parameters information.<br/>
		/// Whenever a software parameter of an IP is modified, the runs need not to go stale. But already<br/>
		/// generated design checkpoints need to be updated with the modified parameter information. This<br/>
		/// information is captured in the hwdef file. With update_sw_parameters command, the<br/>
		/// hwdef file is added to already generated design checkpoints.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example modifies a software parameter for the CIPS IP, generates the hw_handoff<br/>
		/// target and then updates the DCPs with the modified values:<br/>
		/// set_property -dict [list CONFIG.PS_I2C0_PERIPHERAL_ENABLE {1}]<br/>
		/// [get_bd_cells versal_cips_0]<br/>
		/// generate_target hw_handoff [get_files top.bd]<br/>
		/// update_sw_parameters<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1782<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL update_sw_parameters(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: update_sw_parameters [-quiet] [-verbose]
			_tcl.Entry(_builder.update_sw_parameters(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Check whether the XML files describing a board in the given directory are valid. Only supported<br/>
		/// for board XML files with schema_version&gt;=2.0. The XML files must contain an appropriate<br/>
		/// DOCTYPE declaration to be fully validated. Examples: &lt;!DOCTYPE board SYSTEM "board.dtd"&gt;<br/>
		/// &lt;!-- for board.xml --&gt; &lt;!DOCTYPE ip_presets SYSTEM "preset.dtd"&gt; &lt;!-- for preset.xml --&gt; &lt;!<br/>
		/// DOCTYPE part_info SYSTEM "part0_pins.dtd"&gt; &lt;!-- for part0_pins.xml --&gt;<br/>
		/// Note that if a project is open and an IP repository loaded, this command will also validate certain<br/>
		/// IP and Interface attributes used in the board definition against the current IP repository.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: validate_board_files [-quiet] [-verbose] [&lt;dir&gt;...]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1796<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="dir">
		/// <para>
		/// (Optional)<br/>
		/// The name of a directory containing the board files<br/>
		/// (board.xml, part0_pins.xml, preset.xml) to be checked<br/>
		/// </para>
		/// </param>
		/// <returns>ok if all board files are valid</returns>
		public TTCL validate_board_files(bool? quiet = null, bool? verbose = null, TCLObjectList dir = null)
		{
			// TCL Syntax: validate_board_files [-quiet] [-verbose] [<dir>...]
			_tcl.Entry(_builder.validate_board_files(quiet, verbose, dir));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Block execution of further Tcl commands until the specified run completes.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: wait_on_run [-timeout &lt;arg&gt;] [-quiet] [-verbose] &lt;run&gt;
		/// <br/>
		/// <para>
		/// Blocks the execution of Tcl commands until the specified run has completed either successfully<br/>
		/// or in error, or until the specified amount of time has elapsed.<br/>
		/// This command will tell you when the run has terminated, but not the results of the run. To<br/>
		/// determine if the run has completed successfully, you could query the value of the PROGRESS<br/>
		/// property of the run:<br/>
		/// launch_runs synth_1<br/>
		/// wait_on_run synth_1<br/>
		/// if {[get_property PROGRESS [get_runs synth_1]] != "100%"} {<br/>
		/// error "ERROR: synth_1 failed"<br/>
		/// }<br/>
		/// The wait_on_run command can be used for runs that have been launched. If the specified run<br/>
		/// has not been launched when the wait_on_run command is used, you will get an error. Runs<br/>
		/// that have already completed do not return an error.<br/>
		/// Note: This command is used for running the tool in batch mode or from Tcl scripts. It is ignored when<br/>
		/// running interactively from the GUI.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example launches the impl_1 run, and then waits for the specified run to complete,<br/>
		/// or to wait for one hour, whichever occurs first:<br/>
		/// launch_runs impl_1<br/>
		/// wait_on_run -timeout 60 impl_1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1814<br/>
		/// </para>
		/// </summary>
		/// <param name="run">(Required) Run to wait on</param>
		/// <param name="timeout">(Optional) Maximum time to wait for the run to complete (in minutes) Default: -1</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL wait_on_run(TCLObject run, String timeout = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: wait_on_run [-timeout <arg>] [-quiet] [-verbose] <run>
			_tcl.Entry(_builder.wait_on_run(run, timeout, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Writes hardware definition for use in the software development<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_hwdef [-force] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Writes a hardware definition (.hwdef) file for use in the software development tools (SDK).<br/>
		/// Each BD and HIP generates a .hwdef file. Write_hwdef merges all the files into a single<br/>
		/// container. This command is run automatically by the Vivado Design Suite when generating the<br/>
		/// output products for a top-level design that includes a block design with an embedded processor<br/>
		/// like MicroBlaze, or Zynq-7000 SoC. Block designs are created in the IP integrator of the Vivado<br/>
		/// Design Suite with the create_bd_design command.<br/>
		/// The write_hwdef command is run after place_design and creates a hardware container file<br/>
		/// with .hwdef extension. The container file includes device metadata and hardware design files.<br/>
		/// The write_hwdef command returns nothing if successful, or an error if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates the specified hardware definition file:<br/>
		/// write_hwdef -force C:/Data/ug940/lab1/zynq_design.hdf<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1862<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Required)<br/>
		/// Hardware definition file (Values: A filename with<br/>
		/// alphanumeric characters and .hwdef extention.)<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Overwrites the existing hardware definition file</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>success/failure status of applied action.</returns>
		public TTCL write_hwdef(TCLObject file, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_hwdef [-force] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_hwdef(file, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write a tcl script on disk that will recreate a given IP.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_ip_tcl [-force] [-no_ip_version] [-ip_name &lt;arg&gt;] [-show_defaults] [-multiple_files] [-quiet] [-verbose] [&lt;objects&gt;] [&lt;tcl_filename&gt;...]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1871<br/>
		/// </para>
		/// </summary>
		/// <param name="force">(Optional) Flag to overwrite existing file.</param>
		/// <param name="no_ip_version">
		/// <para>
		/// (Optional)<br/>
		/// Flag to not include the IP version in the IP VLNV in create_ip<br/>
		/// commands. NOTE - this may have implications if there are<br/>
		/// major IP version changes.<br/>
		/// </para>
		/// </param>
		/// <param name="ip_name">
		/// <para>
		/// (Optional)<br/>
		/// Set the name of the IP. This argument is not supported for<br/>
		/// multiple IP.<br/>
		/// </para>
		/// </param>
		/// <param name="show_defaults">(Optional) Add a comment containing the default parameter values of the IP.</param>
		/// <param name="multiple_files">(Optional) Flag to create a .tcl file for each IP supplied as an argument</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">
		/// <para>
		/// (Optional)<br/>
		/// IP(s) to be written to disk Values: IP instance(s) as returned<br/>
		/// by 'get_ips &lt;instance name&gt;'<br/>
		/// </para>
		/// </param>
		/// <param name="tcl_filename">
		/// <para>
		/// (Optional)<br/>
		/// File path to the exported tcl file. If the path is a directory and<br/>
		/// multiple IP are given as an argument, a file for each IP will<br/>
		/// be created. Default: ./<br/>
		/// </para>
		/// </param>
		/// <returns>IP TCL file</returns>
		public TTCL write_ip_tcl(bool? force = null, bool? no_ip_version = null, String ip_name = null, bool? show_defaults = null, bool? multiple_files = null, bool? quiet = null, bool? verbose = null, TCLObject objects = null, TCLObjectList tcl_filename = null)
		{
			// TCL Syntax: write_ip_tcl [-force] [-no_ip_version] [-ip_name <arg>] [-show_defaults] [-multiple_files] [-quiet] [-verbose] [<objects>] [<tcl_filename>...]
			_tcl.Entry(_builder.write_ip_tcl(force, no_ip_version, ip_name, show_defaults, multiple_files, quiet, verbose, objects, tcl_filename));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Save peripheral component to the disk.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_peripheral [-quiet] [-verbose] &lt;peripheral&gt;
		/// <br/>
		/// <para>
		/// Write the specified AXI peripheral object to disk in the form of the component.xml file. The<br/>
		/// peripheral is written to the repository location specified by the create_peripheral<br/>
		/// command, under the name specified at creation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1876<br/>
		/// </para>
		/// </summary>
		/// <param name="peripheral">(Required) Peripheral object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_peripheral(TCLObject peripheral, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_peripheral [-quiet] [-verbose] <peripheral>
			_tcl.Entry(_builder.write_peripheral(peripheral, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
