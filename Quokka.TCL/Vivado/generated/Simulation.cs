#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class SimulationCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public SimulationCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// <para>
		/// Add breakpoint at a line of a HDL source<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: add_bp [-quiet] [-verbose] &lt;file_name&gt; &lt;line_number&gt;
		/// <br/>
		/// <para>
		/// The add_bp command lets you add breakpoints to an HDL source file to pause the current<br/>
		/// simulation.<br/>
		/// A breakpoint is a user-determined stopping point in the source code used for debugging the<br/>
		/// design. When simulating a design with breakpoints, simulation of the design stops at each<br/>
		/// breakpoint to let you examine values and verify the design behavior.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// You can report breakpoints in the current simulation using the report_bps command, and<br/>
		/// remove existing breakpoints using the remove_bps command.<br/>
		/// This command returns a new breakpoint object if there is not already a breakpoint set at the<br/>
		/// specified file line, or returns an existing breakpoint object if there is already a breakpoint defined<br/>
		/// for the specified file and line number.<br/>
		/// TIP: You can capture the returned breakpoint object in a Tcl variable if needed.<br/>
		/// The add_bp command returns an error if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example adds a the breakpoint to the HDL source file at the specified line number:<br/>
		/// add_bp C:/Data/ug937/sources/sinegen.vhd 137<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 33<br/>
		/// </para>
		/// </summary>
		/// <param name="file_name">(Required) Filename to add the breakpoint</param>
		/// <param name="line_number">(Required) Line number of the given file to set the breakpoint</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>
		/// </returns>
		public TTCL add_bp(TCLObject file_name, TCLObject line_number, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: add_bp [-quiet] [-verbose] <file_name> <line_number>
			_tcl.Entry(_builder.add_bp(file_name, line_number, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Conditionally execute Tcl commands<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: add_condition [-name &lt;arg&gt;] [-radix &lt;arg&gt;] [-notrace] [-quiet] [-verbose] &lt;condition_expression&gt; &lt;commands&gt;
		/// <br/>
		/// <para>
		/// Add a condition that is evaluated by a specified condition, &lt;condition_expression&gt;, and runs a<br/>
		/// series of simulation Tcl commands when the condition is TRUE.<br/>
		/// Conditions can be defined prior to starting the simulation. When a condition is added, the<br/>
		/// simulator evaluates the condition expression anytime a signal change is detected. When a<br/>
		/// specified condition expression becomes TRUE, the condition commands are run.<br/>
		/// The add_condition command returns a condition identifier for the added condition, or returns<br/>
		/// an error if the command fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example defines a condition named resetLow, that becomes true when the reset<br/>
		/// signal is low, and then puts a message to the standard output, and stops the current simulation:<br/>
		/// add_condition -name resetLow {/testbench/reset == 0 } {<br/>
		/// puts "Condition Reset was encountered at [current_time]. Stopping<br/>
		/// simulation."<br/>
		/// stop }<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This next example defines a Tcl procedure, called myProc, that uses the add_force command to<br/>
		/// define clk and reset signal values, and print a standard message when it completes. A<br/>
		/// condition is then added that calls myProc when reset is low:<br/>
		/// proc myProc {} {<br/>
		/// add_force clk {0 1} { 1 2} -repeat_every 4 -cancel_after 500<br/>
		/// add_force reset 1<br/>
		/// run 10 ns<br/>
		/// remove_force force2<br/>
		/// puts "Reached end of myProc"<br/>
		/// }<br/>
		/// add_condition -radix unsigned /top/reset==0 myproc<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 37<br/>
		/// </para>
		/// </summary>
		/// <param name="condition_expression">(Required) The condition expression when true executes the given commands</param>
		/// <param name="commands">(Required) Commands to execute upon condition</param>
		/// <param name="name">
		/// <para>
		/// (Optional)<br/>
		/// Assign a unique name (label) to a condition. Multiple<br/>
		/// conditions cannot be assigned the same name. If no name<br/>
		/// is specified, then a default label named as condition&lt;id&gt; is<br/>
		/// automatically created<br/>
		/// </para>
		/// </param>
		/// <param name="radix">
		/// <para>
		/// (Optional)<br/>
		/// Specifies which radix to use. Allowed values are: default,<br/>
		/// dec, bin, oct, hex, unsigned, ascii, smag.<br/>
		/// </para>
		/// </param>
		/// <param name="notrace">(Optional) Turn off the logging of condition commands</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The condition object created</returns>
		public TTCL add_condition(TCLObject condition_expression, TCLObject commands, String name = null, String radix = null, bool? notrace = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: add_condition [-name <arg>] [-radix <arg>] [-notrace] [-quiet] [-verbose] <condition_expression> <commands>
			_tcl.Entry(_builder.add_condition(condition_expression, commands, name, radix, notrace, quiet, verbose));
			return _tcl;
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
		/// Force value of signal, wire, or reg to a specified value<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: add_force [-radix &lt;arg&gt;] [-repeat_every &lt;arg&gt;] [-cancel_after &lt;arg&gt;] [-quiet] [-verbose] &lt;hdl_object&gt; &lt;values&gt;...
		/// <br/>
		/// <para>
		/// Force the value of a signal, wire, or reg to a certain value during simulation.<br/>
		/// The add_force command has the same effect as the Verilog force/release commands in<br/>
		/// the test bench or the module definition. It forces an HDL object to hold the specified value for<br/>
		/// the specified time, or until released by the -cancel_after option, or the remove_forces<br/>
		/// command.<br/>
		/// IMPORTANT! If there are Verilog force/release statements on an HDL object in the test bench or<br/>
		/// module, these commands are overridden by the Tcl add_force command. When the Tcl force expires or<br/>
		/// is released, the HDL object resumes normal operation in the simulation, including the application of any<br/>
		/// Verilog forces.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns the name of the force object created, or returns an error if the command<br/>
		/// failed. The name of the returned force object is important when using the remove_forces<br/>
		/// command, and should be captured in a Tcl variable for later recall, as shown in the examples.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example forces the reset signal high at 300 nanoseconds, using the default radix,<br/>
		/// and captures the name of the returned force object in a Tcl variable which can be used to later<br/>
		/// remove the force:<br/>
		/// set for10 [ add_force reset 1 300 ]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example shows the use of {&lt;value&gt; &lt;time&gt;} pairs, repeated periodically, and<br/>
		/// canceled after a specified time.<br/>
		/// add_force mySig {0} {1 50} {0 100} {1 150} -repeat_every 200<br/>
		/// -cancel_after 10000<br/>
		/// Note: In the preceding example, the first {&lt;value&gt; &lt;time&gt;} pair does not include a time. This indicates that<br/>
		/// the specified value, 0, is applied at time 0 (the current_time).<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 48<br/>
		/// </para>
		/// </summary>
		/// <param name="hdl_object">(Required) Specifies the object upon which to add a force</param>
		/// <param name="values">(Required) Adds a value and time offset to the force: {value [ time_offset ] }</param>
		/// <param name="radix">
		/// <para>
		/// (Optional)<br/>
		/// Specifies which radix to use. Allowed values are: default,<br/>
		/// dec, bin, oct, hex, unsigned, ascii, smag<br/>
		/// </para>
		/// </param>
		/// <param name="repeat_every">(Optional) Repeat every time duration</param>
		/// <param name="cancel_after">(Optional) Cancel after time offset</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The force objects added</returns>
		public TTCL add_force(TCLObject hdl_object, TCLObjectList values, String radix = null, String repeat_every = null, String cancel_after = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: add_force [-radix <arg>] [-repeat_every <arg>] [-cancel_after <arg>] [-quiet] [-verbose] <hdl_object> <values>...
			_tcl.Entry(_builder.add_force(hdl_object, values, radix, repeat_every, cancel_after, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a VCD checkpoint (equivalent of Verilog $dumpall system task)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: checkpoint_vcd [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// The checkpoint_vcd command inserts current HDL object signal values into the Value Change<br/>
		/// Dump (VCD) file. Nothing is returned. This Tcl command is the equivalent of the Verilog<br/>
		/// $dumpall system task, providing the initial values of the specified signals.<br/>
		/// VCD is an ASCII file containing header information, variable definitions, and value change details<br/>
		/// of a set of HDL signals. The VCD file can be used to view simulation result in a VCD viewer or to<br/>
		/// estimate the power consumption of the design. See the IEEE Standard for Verilog Hardware<br/>
		/// Description Language (IEEE Std 1364-2005) for a description of the VCD file format.<br/>
		/// You must execute the open_vcd and log_vcd commands before using the checkpoint_vcd<br/>
		/// command. After you execute the checkpoint_vcd command, run or rerun the simulation to<br/>
		/// capture the signal values.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following is an example of the checkpoint_vcd command where the command dumps<br/>
		/// signal values of specified HDL objects into the open VCD file:<br/>
		/// checkpoint_vcd<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 133<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL checkpoint_vcd(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: checkpoint_vcd [-quiet] [-verbose]
			_tcl.Entry(_builder.checkpoint_vcd(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Flush SAIF toggle information to the SAIF output file and close the file<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: close_saif [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Closes the open SAIF file.<br/>
		/// Only one SAIF file can be open in the Vivado simulator at one time, using open_saif. You must<br/>
		/// close the currently opened SAIF file before opening another file.<br/>
		/// This command returns nothing if it is successful, or an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following is an example:<br/>
		/// close_saif<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 145<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL close_saif(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: close_saif [-quiet] [-verbose]
			_tcl.Entry(_builder.close_saif(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Unload the current simulation without exiting Vivado<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: close_sim [-force] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Close the current Vivado simulation.<br/>
		/// Note: This command does not support third party simulators.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example closes the current simulation, forcing the close even if changes would be<br/>
		/// lost:<br/>
		/// close_sim -force<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 147<br/>
		/// </para>
		/// </summary>
		/// <param name="force">
		/// <para>
		/// (Optional)<br/>
		/// Forces the closing of the simulation, even if changes would<br/>
		/// be lost. Default behavior is to reject the closing with an error<br/>
		/// if changes would be lost.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL close_sim(bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: close_sim [-force] [-quiet] [-verbose]
			_tcl.Entry(_builder.close_sim(force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Flush VCD information to the VCD output file and close the file<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: close_vcd [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Closes the open Value Change Dump (VCD) file.<br/>
		/// Only one VCD file can be open in the Vivado simulator at one time. You must close the currently<br/>
		/// opened VCD file before opening another file.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example closes the current VCD object:<br/>
		/// close_vcd<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 149<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL close_vcd(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: close_vcd [-quiet] [-verbose]
			_tcl.Entry(_builder.close_vcd(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Compile simulation libraries<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: compile_simlib [-directory &lt;arg&gt;] [-family &lt;arg&gt;] [-force] [-language &lt;arg&gt;] [-library &lt;arg&gt;] [-print_library_info &lt;arg&gt;] -simulator &lt;arg&gt; [-simulator_exec_path &lt;arg&gt;] [-gcc_exec_path &lt;arg&gt;] [-source_library_path &lt;arg&gt;] [-no_ip_compile] [-32bit] [-no_systemc_compile] [-no_dpi_compile] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Compile Xilinx® simulation libraries for the cells and IP used in the current project, or from a<br/>
		/// specified directory for use in multiple design projects.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The Vivado Design Suite provides simulation models as a set of files and libraries that contain the<br/>
		/// behavioral and timing models for use by the Vivado simulator. The compile_simlib command<br/>
		/// compiles these libraries for use by third-party simulators prior to design simulation. Libraries<br/>
		/// must generally be compiled or recompiled with a new software release to update simulation<br/>
		/// models and to support a new version of a simulator.<br/>
		/// IMPORTANT! You should rerun the compile_simlib command any time a new third party simulator<br/>
		/// will be used, or a new Vivado Design Suite version or update is installed.<br/>
		/// When this command is run from a current project, the tool will use the device family, target<br/>
		/// language, and library settings specified by the project as the default values, rather than the<br/>
		/// default settings of the command defined below. The default settings can be overridden by<br/>
		/// specifying the necessary options when the command is run.<br/>
		/// The compile_simlib command uses simulator compilation directives when compiling the<br/>
		/// simulation libraries. You can edit the default configuration settings using the<br/>
		/// config_compile_simlib command.<br/>
		/// The command returns information related to the compiled libraries, or an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example shows how to compile UNISIM and SIMPRIM libraries for ModelSim<br/>
		/// (VHDL) for a design using a Virtex-7 device:<br/>
		/// compile_simlib -simulator modelsim -family virtex7 -library unisim \<br/>
		/// -library simprim -language vhdl<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 166<br/>
		/// </para>
		/// </summary>
		/// <param name="simulator">(Required) Compile libraries for this simulator</param>
		/// <param name="directory">(Optional) Directory path for saving the compiled results Default: .</param>
		/// <param name="family">(Optional) Select device architecture Default: all</param>
		/// <param name="force">(Optional) Overwrite the pre-compiled libraries</param>
		/// <param name="language">(Optional) Compile libraries for this language Default: all</param>
		/// <param name="library">(Optional) Select library to compile Default: all</param>
		/// <param name="print_library_info">(Optional) Print Pre-Compiled library information</param>
		/// <param name="simulator_exec_path">(Optional) Use simulator executables from this directory</param>
		/// <param name="gcc_exec_path">(Optional) Use GNU executables from this directory</param>
		/// <param name="source_library_path">
		/// <para>
		/// (Optional)<br/>
		/// If specified, this directory will be searched for the library<br/>
		/// source files before searching the default path(s) found in<br/>
		/// environment variable XILINX_VIVADO for Vivado<br/>
		/// </para>
		/// </param>
		/// <param name="no_ip_compile">(Optional) Do not compile IP static files from repository</param>
		/// <param name="_32bit">(Optional) Perform the 32-bit compilation</param>
		/// <param name="no_systemc_compile">(Optional) Do not compile models for system simulation</param>
		/// <param name="no_dpi_compile">(Optional) Do not compile DPI models</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL compile_simlib(String simulator, String directory = null, String family = null, bool? force = null, String language = null, String library = null, String print_library_info = null, String simulator_exec_path = null, String gcc_exec_path = null, String source_library_path = null, bool? no_ip_compile = null, bool? _32bit = null, bool? no_systemc_compile = null, bool? no_dpi_compile = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: compile_simlib [-directory <arg>] [-family <arg>] [-force] [-language <arg>] [-library <arg>] [-print_library_info <arg>] -simulator <arg> [-simulator_exec_path <arg>] [-gcc_exec_path <arg>] [-source_library_path <arg>] [-no_ip_compile] [-32bit] [-no_systemc_compile] [-no_dpi_compile] [-quiet] [-verbose]
			_tcl.Entry(_builder.compile_simlib(simulator, directory, family, force, language, library, print_library_info, simulator_exec_path, gcc_exec_path, source_library_path, no_ip_compile, _32bit, no_systemc_compile, no_dpi_compile, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Configure settings for compile_simlib<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: config_compile_simlib [-cfgopt &lt;arg&gt;] [-simulator &lt;arg&gt;] [-reset] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Configure third party simulator options for use by the compile_simlib command.<br/>
		/// The Vivado Design Suite has a pre-defined configuration file for the compile_simlib<br/>
		/// command, with compilation options defined for supported third-party simulators, languages, and<br/>
		/// libraries. The config_compile_simlib command is provided to let you change the<br/>
		/// configuration options for specific combinations of simulator, language, and library.<br/>
		/// Use the config_compile_simlib command without any arguments to return all current<br/>
		/// configuration options.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example configures the compilation options for the Modelsim simulator, Verilog<br/>
		/// language, and Unisim library:<br/>
		/// config_compile_simlib -cfgopt {modelsim.verilog.unisim: -quiet}<br/>
		/// The following example configures the compilation options for multiple simulation libraries:<br/>
		/// config_compile_simlib -cfgopt {modelsim.verilog.synopsys: -quiet} \<br/>
		/// -cfgopt {modelsim.verilog.simprim:-source +define+XIL_TIMING}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 171<br/>
		/// </para>
		/// </summary>
		/// <param name="cfgopt">(Optional) Configuration option in form of simulator.language.library.options</param>
		/// <param name="simulator">(Optional) Display the configurations for specified simulator</param>
		/// <param name="reset">(Optional) Reset all configurations</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL config_compile_simlib(String cfgopt = null, String simulator = null, bool? reset = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: config_compile_simlib [-cfgopt <arg>] [-simulator <arg>] [-reset] [-quiet] [-verbose]
			_tcl.Entry(_builder.config_compile_simlib(cfgopt, simulator, reset, quiet, verbose));
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
		/// Get index of the selected subprogram frame (default, top i.e. most recent subprogram call) in the<br/>
		/// call-stack of the HDL process scope (current_scope). Sets current stack frame for the subprogram<br/>
		/// call-stack of the current_scope.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_frame [-up] [-down] [-set &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Returns the index of the frame which is selected as the "current" frame in sub-program call-stack<br/>
		/// of the current HDL process-scope, or current_scope. By default, the most recently called<br/>
		/// subprogram-frame is the current frame, i.e. with frame-index "0" (zero) and marked with (-&gt;).<br/>
		/// Switches like -up,-down, and -set let you select other frames in the call-stack, rather than the<br/>
		/// current frame.<br/>
		/// IMPORTANT! The current_frame strictly follows the current_scope . If current_scope is<br/>
		/// not an HDL process scope waiting inside a sub-program, the current_frame command reports that<br/>
		/// the current process does not have an associated sub-program stack.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// Example design:<br/>
		/// module top;<br/>
		/// int i;<br/>
		/// function void f(input int in1);<br/>
		/// automatic int a;<br/>
		/// a = in1 + 7;<br/>
		/// $display($time, " in f :: a %d in1 %d ", a, in1);<br/>
		/// endfunction<br/>
		/// task automatic t(input int in2);<br/>
		/// int b;<br/>
		/// b = in2 + 10;<br/>
		/// $display($time, " in t :: in2 %d b %d ", in2, b);<br/>
		/// #5;<br/>
		/// f(b); // Case C<br/>
		/// $display($time, " Back in t : after wait and f(%d) ", b);<br/>
		/// endtask<br/>
		/// initial begin // "/top/Initial18_0"<br/>
		/// $display($time, " in initial 1 ");<br/>
		/// i = 200;<br/>
		/// t(i); // Case B<br/>
		/// $display($time, " Back in initial 1 after t(%d) ", i);<br/>
		/// end<br/>
		/// initial begin // "/top/Initial25_1"<br/>
		/// $display($time, " in initial 2 ");<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// #2;<br/>
		/// f(50); // Case A<br/>
		/// $display($time, " Back in initial 2 after f(50) ");<br/>
		/// end<br/>
		/// endmodule<br/>
		/// When simulation is stopped inside function "f" for its call at 'Case C', function "f" is called from<br/>
		/// task "t" at 'Case C' which itself is called from process "/top/Initial18_0" at 'Case B'<br/>
		/// &gt; current_scope<br/>
		/// /top/Initial18_0<br/>
		/// &gt; report_frames<br/>
		/// -&gt; 0 : f<br/>
		/// 1 : t<br/>
		/// 2: /top/Initial18_0<br/>
		/// 1. &gt; current_frame<br/>
		/// 0<br/>
		/// 2. &gt; current_frame -up<br/>
		/// 1<br/>
		/// &gt; report_frames<br/>
		/// 0 : f<br/>
		/// -&gt; 1 : t<br/>
		/// 2 : /top/Initial18_0<br/>
		/// 3. &gt; current_frame -down<br/>
		/// 0<br/>
		/// &gt; report_frames<br/>
		/// -&gt; 0 : f<br/>
		/// 1 : t<br/>
		/// 2: /top/Initial18_0<br/>
		/// 4. &gt; current_frame -set 1<br/>
		/// 1<br/>
		/// &gt; report_frames<br/>
		/// 0 : f<br/>
		/// -&gt; 1 : t<br/>
		/// 2 : /top/Initial18_0<br/>
		/// 5. &gt; current_frame -verbose<br/>
		/// -&gt; 0 : f @top.v:6<br/>
		/// 1 : t @top.v:15<br/>
		/// 2: /top/Initial18_0 @top.v:21<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 389<br/>
		/// </para>
		/// </summary>
		/// <param name="up">
		/// <para>
		/// (Optional)<br/>
		/// Selects stack frame of the caller subprogram/process as the<br/>
		/// current frame.<br/>
		/// </para>
		/// </param>
		/// <param name="down">(Optional) Selects stack frame of the callee subprogram as the current frame.</param>
		/// <param name="set">
		/// <para>
		/// (Optional)<br/>
		/// Selects stack frame with given index as the current frame of<br/>
		/// the call stack of current HDL process scope. Default: 0<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Returns index of the selected subprogram frame in the call stack of the current_scope.</returns>
		public TTCL current_frame(bool? up = null, bool? down = null, String set = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: current_frame [-up] [-down] [-set <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.current_frame(up, down, set, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get the current scope or set the current scope<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_scope [-quiet] [-verbose] [&lt;hdl_scope&gt;]
		/// <br/>
		/// <para>
		/// Return the current scope in the current simulation, or set the current scope to the specified HDL<br/>
		/// scope.<br/>
		/// The current_scope command returns the name of the current simulation scope.<br/>
		/// If &lt;hdl_scope&gt; is supplied then, the current scope is set to the specified scope.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets the current scope to the specified HDL scope:<br/>
		/// current_scope /testbench/dut<br/>
		/// This example returns the current scope name to console:<br/>
		/// current_scope<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 415<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hdl_scope">(Optional) Default: NULL</param>
		/// <returns>The current scope</returns>
		public TTCL current_scope(bool? quiet = null, bool? verbose = null, TCLObject hdl_scope = null)
		{
			// TCL Syntax: current_scope [-quiet] [-verbose] [<hdl_scope>]
			_tcl.Entry(_builder.current_scope(quiet, verbose, hdl_scope));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set the current simulation object or get the current simulation object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_sim [-quiet] [-verbose] [&lt;simulationObject&gt;]
		/// <br/>
		/// <para>
		/// Get or set the current Vivado simulation object.<br/>
		/// This command can be used after the Vivado simulator has been launched to return or set the<br/>
		/// current simulation object.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets the curent simulation:<br/>
		/// current_sim simulation_2<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 417<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="simulationObject">
		/// <para>
		/// (Optional)<br/>
		/// Simulation Object to set the current simulation object to<br/>
		/// Default: NULL<br/>
		/// </para>
		/// </param>
		/// <returns>Returns the current simulation object</returns>
		public TTCL current_sim(bool? quiet = null, bool? verbose = null, TCLObject simulationObject = null)
		{
			// TCL Syntax: current_sim [-quiet] [-verbose] [<simulationObject>]
			_tcl.Entry(_builder.current_sim(quiet, verbose, simulationObject));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report current simulation time<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_time [-s] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Returns the current simulation time to the Tcl Console or Vivado Design Suite Tcl shell.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the current time of the current simulation:<br/>
		/// current_time<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 419<br/>
		/// </para>
		/// </summary>
		/// <param name="s">(Optional) Short -- suppress the space between numeric part and unit part</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Prints the current simulation time on the console in textual format</returns>
		public TTCL current_time(bool? s = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: current_time [-s] [-quiet] [-verbose]
			_tcl.Entry(_builder.current_time(s, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Return the current VCD object or make VCDObject the current VCD object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_vcd [-quiet] [-verbose] [&lt;VCDObject&gt;]
		/// <br/>
		/// <para>
		/// Defines the current Value Change Dump (VCD) object, or returns the name of the current VCD<br/>
		/// object in the current simulation.<br/>
		/// A VCD file must be opened and assigned to a VCD object using the open_vcd command in<br/>
		/// order for there to be a current VCD object.<br/>
		/// This command returns the current VCD object.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets the specified VCD object as current:<br/>
		/// current_vcd vcd2<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 421<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="VCDObject">(Optional) VCDObject Default: NULL</param>
		public TTCL current_vcd(bool? quiet = null, bool? verbose = null, TCLObject VCDObject = null)
		{
			// TCL Syntax: current_vcd [-quiet] [-verbose] [<VCDObject>]
			_tcl.Entry(_builder.current_vcd(quiet, verbose, VCDObject));
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
		/// Describe an HDL object (variable, signal, wire, or reg) by printing type and declaration<br/>
		/// information<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: describe [-quiet] [-verbose] &lt;hdl_object&gt;
		/// <br/>
		/// <para>
		/// Describe an HDL object (variable, signal, wire, or reg) by printing type and declaration<br/>
		/// information, as well as path, and file information for the HDL source of the specified objects.<br/>
		/// TIP: The describe command works for a single HDL object. Use the report_objects command for<br/>
		/// a brief report on multiple HDL objects.<br/>
		/// HDL objects include HDL signals, variables, or constants as defined in the Verilog or VHDL test<br/>
		/// bench and source files. An HDL signal includes Verilog wire or reg entities, and VHDL signals.<br/>
		/// Examples of HDL variables include Verilog real, realtime, time, and event. HDL constants include<br/>
		/// Verilog parameters and localparams, and VHDL generic and constants.<br/>
		/// The command returns the description of specified HDL objects, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// Verilog parameters and localparams, and VHDL generic and constants.<br/>
		/// The command returns the description of specified HDL objects, or returns an error if it fails.<br/>
		/// Arguments<br/>
		/// -quiet - (Optional) Execute the command quietly, returning no messages from the command.<br/>
		/// The command also returns TCL_OK regardless of any errors encountered during execution.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: Any errors encountered on the command-line, while launching the command, will be returned. Only<br/>
		/// errors occurring inside the command will be trapped.<br/>
		/// -verbose - (Optional) Temporarily override any message limits and return all messages from this<br/>
		/// command.<br/>
		/// Note: Message limits can be defined with the set_msg_config command.<br/>
		/// &lt;hdl_object&gt; - (Required) Specifies a single HDL object to describe.<br/>
		/// Note: Objects can be specified by name, or returned as objects by the get_objects command.<br/>
		/// Examples<br/>
		/// The following example shows how the objects description depends on the scope of the current<br/>
		/// simulation:<br/>
		/// current_scope testbench<br/>
		/// /testbench<br/>
		/// describe leds_n<br/>
		/// Signal: {leds_n[3:0]}<br/>
		/// Path: {/testbench/leds_n}<br/>
		/// Location: {File "C:/Data/ug937/sim/testbench.v" Line 9}<br/>
		/// current_scope dut<br/>
		/// /testbench/dut<br/>
		/// describe leds_n<br/>
		/// Port(OUT): {LEDS_n[3:0]}<br/>
		/// Path: {/testbench/dut/LEDS_n}<br/>
		/// Location: {File "C:/Data/sources/sinegen_demo.vhd" Line 42}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 486<br/>
		/// </para>
		/// </summary>
		/// <param name="hdl_object">(Required) The hdl_object or hdl_scope to describe</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The description of the selected objects</returns>
		public TTCL describe(TCLObject hdl_object, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: describe [-quiet] [-verbose] <hdl_object>
			_tcl.Entry(_builder.describe(hdl_object, quiet, verbose));
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
		/// Flush VCD simulation output to the VCD output file (equivalent of $dumpflush verilog system<br/>
		/// task)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: flush_vcd [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Flush HDL signal information currently in memory into the specified Value Change Dump (VCD)<br/>
		/// file.<br/>
		/// VCD is an ASCII file containing header information, variable definitions, and the value change<br/>
		/// details of a set of HDL signals. The VCD file can be used to view simulation results in a VCD<br/>
		/// viewer, or to estimate the power consumption of the design.<br/>
		/// Note: You must run the open_vcd command to open a VCD file to write to before using the flush_vcd<br/>
		/// command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example flushes the VCD buffer into the current VCD file:<br/>
		/// flush_vcd<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 537<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL flush_vcd(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: flush_vcd [-quiet] [-verbose]
			_tcl.Entry(_builder.flush_vcd(quiet, verbose));
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
		/// Write all the simulation .mem files.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: generate_mem_files [-force] [-quiet] [-verbose] &lt;directory&gt;
		/// <br/>
		/// <para>
		/// For embedded processor based designs, with associated Executable Linkable Files (ELF) from the<br/>
		/// Software Development Kit (SDK), this command merges the Block Memory Map (BMM) for the<br/>
		/// design with the program data in the ELF file to generate memory (MEM) files for use during<br/>
		/// simulation.<br/>
		/// The MEM file is a text file that describes how individual Block RAMs on the Xilinx device are<br/>
		/// grouped together to form a contiguous address space called an Address Block, with the ELF data<br/>
		/// mapped into the memory.<br/>
		/// The file names and the number of MEM files generated is determined by the memory map data<br/>
		/// specified by the processor system IP cores, or IP integrator block designs.<br/>
		/// This command returns the directory where the MEM files are written, or returns an error if it<br/>
		/// fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 542<br/>
		/// </para>
		/// </summary>
		/// <param name="directory">
		/// <para>
		/// (Required)<br/>
		/// Directory for exporting .mem files. Values: A directory with<br/>
		/// alphanumeric characters.<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Overwrite existing .mem files</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The name of the directory</returns>
		public TTCL generate_mem_files(TCLObject directory, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_mem_files [-force] [-quiet] [-verbose] <directory>
			_tcl.Entry(_builder.generate_mem_files(directory, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of HDL objects in one or more HDL scopes as per the specified pattern<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_objects [-filter &lt;arg&gt;] [-r] [-local] [-regexp] [-nocase] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Returns a list of HDL objects matching the specified search pattern in one or more HDL scopes.<br/>
		/// HDL objects include HDL signals, variables, or constants as defined in the Verilog or VHDL test<br/>
		/// bench and source files. An HDL signal includes Verilog wire or reg entities, and VHDL signals.<br/>
		/// Examples of HDL variables include Verilog real, realtime, time, and event. HDL constants include<br/>
		/// Verilog parameters and localparams, and VHDL generic and constants.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The HDL scope, or scope, is defined by a declarative region in the HDL code such as a module,<br/>
		/// function, task, process, or begin-end blocks in Verilog. VHDL scopes include entity/architecture<br/>
		/// definitions, block, function, procedure, and process blocks.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// Verilog parameters and localparams, and VHDL generic and constants.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The HDL scope, or scope, is defined by a declarative region in the HDL code such as a module,<br/>
		/// function, task, process, or begin-end blocks in Verilog. VHDL scopes include entity/architecture<br/>
		/// definitions, block, function, procedure, and process blocks.<br/>
		/// Arguments<br/>
		/// -r - (Optional) Apply the command to the current scope, and all sub-scopes of the current scope.<br/>
		/// -regexp - (Optional) Specifies that the search &lt;patterns&gt; are written as regular expressions.<br/>
		/// Both search &lt;patterns&gt; and -filter expressions must be written as regular expressions when<br/>
		/// this argument is used. Xilinx regular expression Tcl commands are always anchored to the start of<br/>
		/// the search string. You can add ".*" to the beginning or end of a search string to widen the search<br/>
		/// to include a substring. See http://perldoc.perl.org/perlre.html for help with regular expression<br/>
		/// syntax.<br/>
		/// Note: The Tcl built-in command regexp is not anchored, and works as a standard Tcl command. For more<br/>
		/// information refer to http://www.tcl.tk/man/tcl8.5/TclCmd/regexp.htm.<br/>
		/// -nocase - (Optional) Perform case-insensitive matching when a pattern has been specified. This<br/>
		/// argument applies to the use of -regexp only.<br/>
		/// -filter &lt;args&gt; - (Optional) Filter the results list with the specified expression. The -filter<br/>
		/// argument filters the list of objects returned by get_objects based on property values on the<br/>
		/// objects. You can find the properties on an object with the report_property or<br/>
		/// list_property commands. In the case of the HDL object, "NAME", "SCOPE" and "TYPE" are<br/>
		/// some of the properties that can be used to filter results.<br/>
		/// The filter search pattern should be quoted to avoid having to escape special characters that may<br/>
		/// be found in net, pin, or cell names, or other properties. String matching is case-sensitive and is<br/>
		/// always anchored to the start and to the end of the search string. The wildcard “*” character can<br/>
		/// be used at the beginning or at the end of a search string to widen the search to include a<br/>
		/// substring of the property value.<br/>
		/// Note: The filter returns an object if a specified property exists on the object, and the specified pattern<br/>
		/// matches the property value on the object. In the case of the "*" wildcard character, this will match a<br/>
		/// property with a defined value of "".<br/>
		/// For string comparison, the specific operators that can be used in filter expressions are "equal"<br/>
		/// (==), "not-equal" (!=), "match" (=~), and "not-match" (!~). Numeric comparison operators &lt;, &gt;, &lt;=,<br/>
		/// and &gt;= can also be used. Multiple filter expressions can be joined by AND and OR (&amp;&amp; and ||).<br/>
		/// The following gets input pins that do NOT contain the “RESET” substring within their name:<br/>
		/// get_pins * -filter {DIRECTION == IN &amp;&amp; NAME !~ "*RESET*"}<br/>
		/// Boolean (bool) type properties can be directly evaluated in filter expressions as true or not true:<br/>
		/// -filter {IS_PRIMITIVE &amp;&amp; !IS_LOC_FIXED}<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// -quiet - (Optional) Execute the command quietly, returning no messages from the command.<br/>
		/// The command also returns TCL_OK regardless of any errors encountered during execution.<br/>
		/// Note: Any errors encountered on the command-line, while launching the command, will be returned. Only<br/>
		/// errors occurring inside the command will be trapped.<br/>
		/// -verbose - (Optional) Temporarily override any message limits and return all messages from this<br/>
		/// command.<br/>
		/// Note: Message limits can be defined with the set_msg_config command.<br/>
		/// &lt;patterns&gt; - (Optional) Match HDL objects against the specified patterns. The default pattern is<br/>
		/// the wildcard '*' which returns all the children in the current scope. The search pattern can be<br/>
		/// defined in two ways:<br/>
		/// • &lt;patterns&gt; - Specifies only the search pattern for the objects to get. This method returns all<br/>
		/// objects in the current scope (and any sub-scopes when -recursive is used).<br/>
		/// • &lt;scope&gt;/&lt;pattern&gt; - Specifies the scope of interest, relative to the current scope, and the<br/>
		/// pattern for objects to locate. In this case, the specified &lt;scope&gt;, and any sub-scopes of it if -<br/>
		/// recursive is used, are identified starting from the current scope. Then all objects matching<br/>
		/// the search &lt;pattern&gt; are identified and returned.<br/>
		/// Examples<br/>
		/// The following example specifies the current_scope, then gets all HDL objects in that scope:<br/>
		/// current_scope ./cpuEngine<br/>
		/// get_objects<br/>
		/// The following example returns the count of all objects in the current scope, and then returns the<br/>
		/// count of all objects in the current scope, and all sub-scopes of it:<br/>
		/// llength [get_objects]<br/>
		/// 182<br/>
		/// llength [get_objects -recursive ]<br/>
		/// 2182<br/>
		/// The following example specifies the &lt;scope&gt;/&lt;pattern&gt; search pattern as discussed above.<br/>
		/// Notice that the cpuEngine scope and various sub-scopes of it are identified, then objects<br/>
		/// matching the cl* pattern in those scopes are returned:<br/>
		/// get_objects -recursive -filter {type == internal_signal} cpuEngine/cl*<br/>
		/// /top/cpuEngine/clk_i<br/>
		/// /top/cpuEngine/iwb_biu/clk<br/>
		/// /top/cpuEngine/iwb_biu/clmode<br/>
		/// /top/cpuEngine/or1200_cpu/clk<br/>
		/// ...<br/>
		/// /top/cpuEngine/or1200_immu_top/or1200_immu_tlb/itlb_mr_ram/clk<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Search the current scope, and all sub-scopes, for any internal signals whose names start with cl<br/>
		/// or ma:<br/>
		/// get_objects -recursive -filter {type == internal_signal} ma* cl*<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 851<br/>
		/// </para>
		/// </summary>
		/// <param name="filter">
		/// <para>
		/// (Optional)<br/>
		/// filters &lt;patterns&gt; according to the specified property-matching expressions<br/>
		/// </para>
		/// </param>
		/// <param name="r">(Optional) Searches recursively for objects</param>
		/// <param name="local">
		/// <para>
		/// (Optional)<br/>
		/// Searches objects in the subprogram frame selected for the<br/>
		/// current scope<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">
		/// <para>
		/// (Optional)<br/>
		/// Search using regular expressions, search design objects<br/>
		/// from which to create wave objects by design object name.<br/>
		/// The application supplying the design objects determines<br/>
		/// how the match is to be performed. Items must be strings.<br/>
		/// </para>
		/// </param>
		/// <param name="nocase">(Optional) Perform a case insensitive match (only used with regexp)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Patterns to search for. Default is * where all HDL objects are<br/>
		/// returned<br/>
		/// </para>
		/// </param>
		/// <returns>Returns all the objects found given the specified pattern</returns>
		public TTCL get_objects(String filter = null, bool? r = null, bool? local = null, bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_objects [-filter <arg>] [-r] [-local] [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_objects(filter, r, local, regexp, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of children HDL scopes of a scope<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_scopes [-filter &lt;arg&gt;] [-regexp] [-nocase] [-r] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Get a list of children HDL scopes of the current or specified scope<br/>
		/// This command returns a list of scope objects, or returns an error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example recursively returns all of the children scopes of the specified scope:<br/>
		/// get_scopes -r /testbench/dut<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 915<br/>
		/// </para>
		/// </summary>
		/// <param name="filter">
		/// <para>
		/// (Optional)<br/>
		/// filters &lt;patterns&gt; according to the specified property-matching expressions<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) interprets &lt;patterns&gt; using regular expressions</param>
		/// <param name="nocase">(Optional) only when regexp is used, performs a case insensitive match</param>
		/// <param name="r">
		/// <para>
		/// (Optional)<br/>
		/// only when a glob or regular expression pattern is used,<br/>
		/// descends recursively into children scopes to search for<br/>
		/// &lt;patterns&gt;<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// the pattern strings to search for scopes. Default: * (all<br/>
		/// children scopes)<br/>
		/// </para>
		/// </param>
		/// <returns>Returns HDL scope objects from the given arguments</returns>
		public TTCL get_scopes(String filter = null, bool? regexp = null, bool? nocase = null, bool? r = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_scopes [-filter <arg>] [-regexp] [-nocase] [-r] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_scopes(filter, regexp, nocase, r, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get registered simulators<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_simulators [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Get the list of simulators registered for use with the Vivado Design Suite unified simulation<br/>
		/// environment.<br/>
		/// The Vivado Design Suite comes with some simulators pre-registered for use with the unified<br/>
		/// simulation environment. You can also register your own third-party simulators using the<br/>
		/// register_simulator command.<br/>
		/// This command returns the names of registered simulators, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 920<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match simulator names against patterns Default: *</param>
		public TTCL get_simulators(bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_simulators [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_simulators(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of processes in a design, which are waiting inside a subprogram<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_stacks [-of_instance &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Returns list of HDL scopes for all the processes in a design which are waiting inside a<br/>
		/// subprogram. With -of_instance switch, the output can be limited to such processes of the<br/>
		/// given instance only.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of all sites available on the target device:<br/>
		/// module top;<br/>
		/// int i;<br/>
		/// function void f(input int in1);<br/>
		/// automatic int a;<br/>
		/// a = in1 + 7;<br/>
		/// $display($time, " in f :: a %d in1 %d ", a, in1);<br/>
		/// endfunction<br/>
		/// task automatic t(input int in2);<br/>
		/// int b;<br/>
		/// b = in2 + 10;<br/>
		/// $display($time, " in t :: in2 %d b %d ", in2, b);<br/>
		/// #5;<br/>
		/// f(b); // Case C<br/>
		/// $display($time, " Back in t : after wait and f(%d) ", b);<br/>
		/// endtask<br/>
		/// initial begin // "/top/Initial18_0"<br/>
		/// $display($time, " in initial 1 ");<br/>
		/// i = 200;<br/>
		/// t(i); // Case B<br/>
		/// $display($time, " Back in initial 1 after t(%d) ", i);<br/>
		/// end<br/>
		/// initial begin // "/top/Initial25_1"<br/>
		/// $display($time, " in initial 2 ");<br/>
		/// #2;<br/>
		/// f(50); // Case A<br/>
		/// $display($time, " Back in initial 2 after f(50) ");<br/>
		/// end<br/>
		/// endmodule<br/>
		/// When simulation is stopped inside function "f" for its call at 'Case A' , the two processes /top/<br/>
		/// Initial18_0, and /top/Initial25_1, are waiting inside task "t" (call at 'CaseB') and<br/>
		/// function "f" (call at 'CaseA') respectively.<br/>
		/// 1. &gt; get_stacks<br/>
		/// /top/Initial18_0 /top/Initial25_1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 940<br/>
		/// </para>
		/// </summary>
		/// <param name="of_instance">(Optional) Default: NULL</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>
		/// </returns>
		public TTCL get_stacks(String of_instance = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_stacks [-of_instance <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_stacks(of_instance, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get current value of the selected HDL object (variable, signal, wire, reg)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_value [-radix &lt;arg&gt;] [-quiet] [-verbose] &lt;hdl_object&gt;
		/// <br/>
		/// <para>
		/// Get the value of a single HDL object at the current simulation run time.<br/>
		/// TIP: Use the report_values command to return the values of more than one HDL objects.<br/>
		/// HDL objects include HDL signals, variables, or constants as defined in the Verilog or VHDL test<br/>
		/// bench and source files. An HDL signal includes Verilog wire or reg entities, and VHDL signals.<br/>
		/// Examples of HDL variables include Verilog real, realtime, time, and event.<br/>
		/// HDL constants include Verilog parameters and localparams, and VHDL generic and constants.<br/>
		/// The HDL scope, or scope, is defined by a declarative region in the HDL code such as a module,<br/>
		/// function, task, process, or begin-end blocks in Verilog. VHDL scopes include entity/architecture<br/>
		/// definitions, block, function, procedure, and process blocks.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// HDL constants include Verilog parameters and localparams, and VHDL generic and constants.<br/>
		/// The HDL scope, or scope, is defined by a declarative region in the HDL code such as a module,<br/>
		/// function, task, process, or begin-end blocks in Verilog. VHDL scopes include entity/architecture<br/>
		/// definitions, block, function, procedure, and process blocks.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Arguments<br/>
		/// -radix &lt;arg&gt; - (Optional) Specifies the radix to use when returning the value of the specified<br/>
		/// object. Allowed values are: default, dec, bin, oct, hex, unsigned, ascii, or smag.<br/>
		/// Note: The radix dec indicates a signed decimal. Specify the radix unsigned when dealing with unsigned<br/>
		/// data.<br/>
		/// -quiet - (Optional) Execute the command quietly, returning no messages from the command.<br/>
		/// The command also returns TCL_OK regardless of any errors encountered during execution.<br/>
		/// Note: Any errors encountered on the command-line, while launching the command, will be returned. Only<br/>
		/// errors occurring inside the command will be trapped.<br/>
		/// -verbose - (Optional) Temporarily override any message limits and return all messages from this<br/>
		/// command.<br/>
		/// Note: Message limits can be defined with the set_msg_config command.<br/>
		/// &lt;hdl_object&gt; - (Required) Specifies a single HDL object to get the value of. The object can be<br/>
		/// specified by name, or can be returned as an object from the get_objects command.<br/>
		/// Examples<br/>
		/// The following example gets the value of the sysClk signal:<br/>
		/// get_value sysClk<br/>
		/// Z<br/>
		/// This example shows the difference between the bin, dec, and unsigned radix on the value<br/>
		/// returned from the specified bus:<br/>
		/// get_value -radix bin /test/bench_VStatus_pad_0_i[7:0]<br/>
		/// 10100101<br/>
		/// get_value -radix unsigned /test/bench_VStatus_pad_0_i[7:0]<br/>
		/// 165<br/>
		/// get_value -radix dec /test/bench_VStatus_pad_0_i[7:0]<br/>
		/// -91<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 955<br/>
		/// </para>
		/// </summary>
		/// <param name="hdl_object">(Required) The hdl_object to retrieve the current value</param>
		/// <param name="radix">
		/// <para>
		/// (Optional)<br/>
		/// radix specifies the radix to use for printing the values of the<br/>
		/// hdl_objects. Allowed values are: default, dec, bin, oct,hex,<br/>
		/// unsigned, ascii, smag<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Returns a string representation of value of a hdl_object</returns>
		public TTCL get_value(TCLObject hdl_object, String radix = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_value [-radix <arg>] [-quiet] [-verbose] <hdl_object>
			_tcl.Entry(_builder.get_value(hdl_object, radix, quiet, verbose));
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
		/// Generate simulation scripts of the design and launch steps for the target simulator.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: launch_simulation [-step &lt;arg&gt;] [-simset &lt;arg&gt;] [-mode &lt;arg&gt;] [-type &lt;arg&gt;] [-scripts_only] [-of_objects &lt;args&gt;] [-absolute_path] [-install_path &lt;arg&gt;] [-gcc_install_path &lt;arg&gt;] [-noclean_dir] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Launch a simulator to perform analysis and verification of a design.<br/>
		/// The launch_simulation command creates a script file for the target simulator and then<br/>
		/// executes this file in the simulation run directory. The simulation results are saved in the log files<br/>
		/// created in the run directory.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// To run simulation for a specific simulator, you must first define the target simulator by setting the<br/>
		/// TARGET_SIMULATOR property on the design project:<br/>
		/// set_property TARGET_SIMULATOR &lt;name&gt; [current_project]<br/>
		/// The TARGET_SIMULATOR property can have a value of XSim, ModelSim, IES, Xcelium, VCS,<br/>
		/// Riviera, or ActiveHDL. The default value is XSim, the Vivado simulator.<br/>
		/// The target simulator can also be defined from the Vivado IDE. Create or open a project, select<br/>
		/// Tools → Settings → Simulation menu item, and select the Target simulator from the drop-down<br/>
		/// menu. The available choices are: Vivado simulator, ModelSim Simulator, Questa Advanced<br/>
		/// Simulator, Incisive Enterprise Simulator (IES), Xcelium Parallel Simulator, Verilog Compiler<br/>
		/// Simulator (VCS), Riviera-PRO Simulator, and Active-HDL Simulator.<br/>
		/// TIP: Some of these simulators are only available on Linux and some are only available on Windows.<br/>
		/// The launch_simulation command uses a three-step process comprised of compile,<br/>
		/// elaborate, and simulate steps. A script file for the target simulator is created for each step in the<br/>
		/// process, (compile.bat, elaborate.bat, simulate.bat), and written to the simulation run<br/>
		/// directory.<br/>
		/// TIP: On Linux the script files are named with the .sh suffix instead of .bat.<br/>
		/// By default, launch_simulation will run these script files in sequence to run the simulation.<br/>
		/// You can create the scripts without running them by using the -scripts_only option.<br/>
		/// This command returns a transcript of its process, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following commands run behavioral simulation of the design using the Vivado simulator:<br/>
		/// set_property target_simulator "XSim" [current_project]<br/>
		/// launch_simulation<br/>
		/// The following commands run post-synthesis functional simulation of the design using the<br/>
		/// ModelSim Simulator:<br/>
		/// set_property target_simulator "ModelSim" [current_project]<br/>
		/// launch_simulation -mode "post-synthesis" -type "functional"<br/>
		/// The following commands run post-implementation functional simulation of the design using the<br/>
		/// Cadence IES Simulator:<br/>
		/// set_property target_simulator "IES" [current_project]<br/>
		/// launch_simulation -mode "post-implementation" -type "functional"<br/>
		/// The following commands run post-implementation timing simulation of the design using the<br/>
		/// Synopsys VCS Simulator:<br/>
		/// set_property target_simulator "VCS" [current_project]<br/>
		/// launch_simulation -mode "post-implementation" -type "timing"<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following command generates behavioral simulation scripts for the target simulator in the<br/>
		/// simulation run directory:<br/>
		/// launch_simulation -scripts_only<br/>
		/// The following commands run behavioral simulation flow of the design for the "my_simset"<br/>
		/// simulation fileset for the target simulator in the simulation run directory:<br/>
		/// launch_simulation -simset [get_filesets my_simset]<br/>
		/// The following command runs behavioral simulation flow for the char_fifo.xci IP for the<br/>
		/// target simulator in the simulation run directory, and does not clean up prior simulation files:<br/>
		/// launch_simulation -noclean_dir -of_objects [get_files char_fifo.xci]<br/>
		/// The following command generates absolute paths for the source files in the generated script files:<br/>
		/// launch_simulation -absolute_path<br/>
		/// The following command will pick the simulator tools from the specified installation path instead<br/>
		/// of from the PATH variable:<br/>
		/// launch_simulation -install_path /tools/ius/13.20.005/tools/bin<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1017<br/>
		/// </para>
		/// </summary>
		/// <param name="step">
		/// <para>
		/// (Optional)<br/>
		/// Launch a simulation step. Values: all, compile, elaborate,<br/>
		/// simulate. Default:all (launch all steps). Default: all<br/>
		/// </para>
		/// </param>
		/// <param name="simset">(Optional) Name of the simulation fileset</param>
		/// <param name="mode">
		/// <para>
		/// (Optional)<br/>
		/// Simulation mode. Values: behavioral, post-synthesis, post-implementation Default: behavioral<br/>
		/// </para>
		/// </param>
		/// <param name="type">
		/// <para>
		/// (Optional)<br/>
		/// Netlist type. Values: functional, timing. This is only<br/>
		/// applicable when mode is set to post-synthesis or post-implementation<br/>
		/// </para>
		/// </param>
		/// <param name="scripts_only">(Optional) Only generate scripts</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Generate compile order file for this object (applicable with -<br/>
		/// scripts_only option only)<br/>
		/// </para>
		/// </param>
		/// <param name="absolute_path">(Optional) Make design source file paths in 'absolute' format</param>
		/// <param name="install_path">(Optional) Custom installation directory path</param>
		/// <param name="gcc_install_path">
		/// <para>
		/// (Optional)<br/>
		/// Specify GNU compiler installation directory path for the g+<br/>
		/// +/gcc executables<br/>
		/// </para>
		/// </param>
		/// <param name="noclean_dir">(Optional) Do not remove simulation run directory files</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL launch_simulation(launch_simulation_step? step = null, String simset = null, launch_simulation_mode? mode = null, launch_simulation_type? type = null, bool? scripts_only = null, TCLParameterList of_objects = null, bool? absolute_path = null, String install_path = null, String gcc_install_path = null, bool? noclean_dir = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: launch_simulation [-step <arg>] [-simset <arg>] [-mode <arg>] [-type <arg>] [-scripts_only] [-of_objects <args>] [-absolute_path] [-install_path <arg>] [-gcc_install_path <arg>] [-noclean_dir] [-quiet] [-verbose]
			_tcl.Entry(_builder.launch_simulation(step, simset, mode, type, scripts_only, of_objects, absolute_path, install_path, gcc_install_path, noclean_dir, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Limit the maximum size of the VCD file on disk (equivalent of $dumplimit verilog task)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: limit_vcd [-quiet] [-verbose] &lt;filesize&gt;
		/// <br/>
		/// <para>
		/// Specify the size limit, in bytes, of the Value Change Dump (VCD) file. This command operates like<br/>
		/// the Verilog $dumplimit simulator directive.<br/>
		/// When the specified file size limit has been reached, the dump process stops, and a comment is<br/>
		/// inserted into the VCD file to indicate that the file size limit has been reached.<br/>
		/// Note: You must run the open_vcd command before using the limit_vcd command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example limits the current VCD file:<br/>
		/// limit_vcd 1000<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1022<br/>
		/// </para>
		/// </summary>
		/// <param name="filesize">(Required) Specify the maximum size of the VCD file in bytes.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL limit_vcd(TCLObject filesize, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: limit_vcd [-quiet] [-verbose] <filesize>
			_tcl.Entry(_builder.limit_vcd(filesize, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Log Switching Activity Interchange Format (SAIF) toggle for specified wire, signal, or reg<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: log_saif [-quiet] [-verbose] &lt;hdl_objects&gt;...
		/// <br/>
		/// <para>
		/// Writes the switching activity rates for the specified HDL signals during the current simulation.<br/>
		/// The Switching Activity Interchange format (SAIF) file is an ASCII file containing header<br/>
		/// information, and toggle counts for the specified signals of the design. It also contains the timing<br/>
		/// attributes which specify time durations for signals at level 0, 1, X, or Z.<br/>
		/// The log_saif command can only be used after the open_saif command has opened an SAIF<br/>
		/// file in the current simulation to capture switching activity rates.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example logs switching activity for all signals in the current_scope:<br/>
		/// log_saif [ get_objects ]<br/>
		/// Log SAIF for only the internal signals starting with name c of the scope /tb/UUT:<br/>
		/// log_saif [get_objects -filter { type == internal_signal }/tb/UUT/c*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1045<br/>
		/// </para>
		/// </summary>
		/// <param name="hdl_objects">(Required) The hdl_objects to log</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Does not return any object</returns>
		public TTCL log_saif(TCLObjectList hdl_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: log_saif [-quiet] [-verbose] <hdl_objects>...
			_tcl.Entry(_builder.log_saif(hdl_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Log Value Change Dump (VCD) simulation output for specified wire, signal, or reg<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: log_vcd [-level &lt;arg&gt;] [-quiet] [-verbose] [&lt;hdl_objects&gt;...]
		/// <br/>
		/// <para>
		/// Indicates which HDL objects to write into the Value Change Dump (VCD) file. In some designs<br/>
		/// the simulation results can become quite large; the log_vcd command lets you define the<br/>
		/// specific content of interest. This command models the behavior of the Verilog $dumpvars<br/>
		/// system task.<br/>
		/// HDL objects include HDL signals, variables, or constants as defined in the Verilog or VHDL test<br/>
		/// bench and source files. An HDL signal includes Verilog wire or reg entities, and VHDL signals.<br/>
		/// Examples of HDL variables include Verilog real, realtime, time, and event.<br/>
		/// This command specifies which HDL objects and how many levels of design hierarchy to write<br/>
		/// into the VCD file. The actual values of the objects are written to the VCD file when you run the<br/>
		/// checkpoint_vcd or flush_vcd commands at a specific time during simulation.<br/>
		/// IMPORTANT! You must use the open_vcd command before using any other *_vcd commands.<br/>
		/// Nothing is returned by this command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This command specifies which HDL objects and how many levels of design hierarchy to write<br/>
		/// into the VCD file. The actual values of the objects are written to the VCD file when you run the<br/>
		/// checkpoint_vcd or flush_vcd commands at a specific time during simulation.<br/>
		/// IMPORTANT! You must use the open_vcd command before using any other *_vcd commands.<br/>
		/// Nothing is returned by this command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Arguments<br/>
		/// -level &lt;arg&gt; - (Optional) Specifies the number of levels of design hierarchy to traverse when<br/>
		/// locating HDL objects to write to the VCD file. The default value of 0 causes the tool to dump all<br/>
		/// values for the specified HDL objects at the level of hierarchy defined by &lt;hdl_objects&gt;, and all<br/>
		/// levels below that. A value of 1 indicates that only the level of hierarchy specified by<br/>
		/// &lt;hdl_objects&gt; should be written to the VCD file.<br/>
		/// -quiet - (Optional) Execute the command quietly, returning no messages from the command.<br/>
		/// The command also returns TCL_OK regardless of any errors encountered during execution.<br/>
		/// Note: Any errors encountered on the command-line, while launching the command, will be returned. Only<br/>
		/// errors occurring inside the command will be trapped.<br/>
		/// -verbose - (Optional) Temporarily override any message limits and return all messages from this<br/>
		/// command.<br/>
		/// Note: Message limits can be defined with the set_msg_config command.<br/>
		/// &lt;hdl_objects&gt; - (Optional) Specifies the HDL objects to identify and write changing values into<br/>
		/// the VCD file. The level of hierarchy is also represented in the hdl_objects pattern. For<br/>
		/// instance /tb/UUT/* indicates all HDL objects within the /tb/UUT level of the design.<br/>
		/// Examples<br/>
		/// Log value changes for all the ports from the scope /tb/UUT:<br/>
		/// log_vcd [get_objects -filter { type == port } /tb/UUT/* ]<br/>
		/// Note: Since -levels is not specified, all levels below the specified scope will be searched for ports<br/>
		/// matching the specified pattern as well.<br/>
		/// Log VCD for all the objects in the current_scope:<br/>
		/// log_vcd *<br/>
		/// log_vcd [ get_objects *]<br/>
		/// Log value changes for only internal signals with names starting with C, of the root scope /tb/<br/>
		/// UUT:<br/>
		/// log_vcd [get_objects -filter { type == internal_signal }./C*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1047<br/>
		/// </para>
		/// </summary>
		/// <param name="level">(Optional) Number of levels to log (for HDL scopes) Default: 0</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hdl_objects">(Optional) Which HDL objects to log</param>
		/// <returns>Does not return any object</returns>
		public TTCL log_vcd(Int32? level = null, bool? quiet = null, bool? verbose = null, TCLObjectList hdl_objects = null)
		{
			// TCL Syntax: log_vcd [-level <arg>] [-quiet] [-verbose] [<hdl_objects>...]
			_tcl.Entry(_builder.log_vcd(level, quiet, verbose, hdl_objects));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Log simulation output for specified wire, signal, or reg for viewing using Vivado Simulators<br/>
		/// waveform viewer. Unlike add_wave, this command does not add the waveform object to<br/>
		/// waveform viewer (i.e. Waveform Configuration). It simply enables logging of output to the Vivado<br/>
		/// Simulators Waveform Database (WDB).<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: log_wave [-recursive] [-r] [-verbose] [-v] [-quiet] &lt;hdl_objects&gt;...
		/// <br/>
		/// <para>
		/// Log simulation activity for the specified HDL objects into the waveform database file (.wdb) for<br/>
		/// viewing using Vivado simulator waveform viewer.<br/>
		/// In the Vivado simulator, an HDL object is an entity that can hold a value, such as a wire, signal, or<br/>
		/// register.<br/>
		/// Unlike add_wave, this command does not add the waveform object to waveform configuration.<br/>
		/// It simply enables logging of waveform activity to the Vivado simulator waveform database<br/>
		/// (WDB). See the Vivado Design Suite User Guide: Logic Simulation (UG900) for more information.<br/>
		/// This command returns nothing.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example logs the waveform activities for the specified HDL objects.<br/>
		/// log_wave -r [get_objects /testbench/dut/*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1049<br/>
		/// </para>
		/// </summary>
		/// <param name="hdl_objects">(Required) Which hdl_objects to trace</param>
		/// <param name="recursive">(Optional) Searches recursively for objects</param>
		/// <param name="r">(Optional) Searches recursively for objects</param>
		/// <param name="verbose">(Optional) Displays all warnings</param>
		/// <param name="v">(Optional) Displays all warnings</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		public TTCL log_wave(TCLObjectList hdl_objects, bool? recursive = null, bool? r = null, bool? verbose = null, bool? v = null, bool? quiet = null)
		{
			// TCL Syntax: log_wave [-recursive] [-r] [-verbose] [-v] [-quiet] <hdl_objects>...
			_tcl.Entry(_builder.log_wave(hdl_objects, recursive, r, verbose, v, quiet));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Turns on or off printing of file name and line number of the hdl statement being simulated<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: ltrace [-quiet] [-verbose] &lt;value&gt;
		/// <br/>
		/// <para>
		/// Enables line-level tracing for simulation debugging purposes.<br/>
		/// During simulation the simulation source file and line number being evaluated is returned to the<br/>
		/// Tcl console.<br/>
		/// TIP: Process tracing with the ptrace command provides more detailed information than is available with<br/>
		/// line tracing.<br/>
		/// This feature can also be enabled using the LINE_TRACING property on the current simulation<br/>
		/// object:<br/>
		/// set_property LINE_TRACING on [current_sim]<br/>
		/// The command returns the state of line tracing, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1051<br/>
		/// </para>
		/// </summary>
		/// <param name="value">(Required) value: on, true, yes. Otherwise set to off, false, no</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL ltrace(TCLObject value, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: ltrace [-quiet] [-verbose] <value>
			_tcl.Entry(_builder.ltrace(value, quiet, verbose));
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
		/// Open file for storing signal switching rate for power estimation. The switching rate is written out<br/>
		/// in Switching Activity Interchange Format (SAIF) Only one SAIF is allowed to be open per<br/>
		/// simulation run.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: open_saif [-quiet] [-verbose] &lt;file_name&gt;
		/// <br/>
		/// <para>
		/// Create or open a Switching Activity Interchange Format (SAIF) file for storing signal switching<br/>
		/// rates in the current simulation for later use by the report_power command.<br/>
		/// The Switching Activity Interchange format (SAIF) file is an ASCII file containing header<br/>
		/// information, and toggle counts for the specified signals of the design. It also contains the timing<br/>
		/// attributes which specify time durations for signals at level 0, 1, X, or Z.<br/>
		/// The SAIF file is recommended for power analysis since it is smaller than the VCD file.<br/>
		/// When an SAIF file has been opened, you can write the switching activity from the simulation into<br/>
		/// the SAIF file using log_saif.<br/>
		/// Only one SAIF can be open at one time during simulation. To close the SAIF file, use the<br/>
		/// close_saif command.<br/>
		/// This command returns the object ID of the opened SAIF file, or returns an error if the command<br/>
		/// failed.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example opens the specified simulation:<br/>
		/// open_saif myData.saif<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1096<br/>
		/// </para>
		/// </summary>
		/// <param name="file_name">(Required) The SAIF filename to store information</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The SAIF object that was opened</returns>
		public TTCL open_saif(TCLObject file_name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: open_saif [-quiet] [-verbose] <file_name>
			_tcl.Entry(_builder.open_saif(file_name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Open a Value Change Dump (VCD) file for capturing simulation output. This Tcl command models<br/>
		/// behavior of $dumpfile Verilog system task<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: open_vcd [-quiet] [-verbose] [&lt;file_name&gt;]
		/// <br/>
		/// <para>
		/// Create or open a Value Change Dump (VCD) file to capture simulation output. This command<br/>
		/// operates like the Verilog $dumpfile simulator directive.<br/>
		/// VCD is an ASCII file containing header information, variable definitions, and value change details<br/>
		/// of a set of HDL signals. The VCD file can be used to view simulation result in a VCD viewer or to<br/>
		/// estimate the power consumption of the design.<br/>
		/// When a VCD file has been opened, you can write the value changes from the simulation into the<br/>
		/// VCD file using checkpoint_vcd, flush_vcd, or log_vcd. In addition, you can pause and<br/>
		/// resume the collection of value change data with the stop_vcd and start_vcd commands.<br/>
		/// You can limit the size of the VCD file by using the limit_vcd command.<br/>
		/// To close the VCD file, use the close_vcd command.<br/>
		/// Note: You must use the open_vcd command before using any other *_vcd commands. Only one VCD file<br/>
		/// can be open at any time.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example opens the specified VCD file (design1.vcd) so that value changes can<br/>
		/// be written to it. The log_vcd command identifies all ports in the /tb/UUT scope, and only that<br/>
		/// level of the design hierarchy, to be written to the VCD file. The simulation is run for a specified<br/>
		/// period of time, and flush_vcd writes the current values of the HDL objects to the VCD file.<br/>
		/// Then close_vcd closes the open file.<br/>
		/// open_vcd design1.vcd<br/>
		/// log_vcd -level 1 [get_objects filter { type == port } /tb/UUT/* ]<br/>
		/// run 1000<br/>
		/// flush_vcd<br/>
		/// close_vcd<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1098<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="file_name">
		/// <para>
		/// (Optional)<br/>
		/// file name. Defaults to dump.vcd (This is LRM standard)<br/>
		/// Default: dump.vcd<br/>
		/// </para>
		/// </param>
		/// <returns>
		/// </returns>
		public TTCL open_vcd(bool? quiet = null, bool? verbose = null, TCLObject file_name = null)
		{
			// TCL Syntax: open_vcd [-quiet] [-verbose] [<file_name>]
			_tcl.Entry(_builder.open_vcd(quiet, verbose, file_name));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Open Waveform Database (WDB) file produced by a prior simulation run and return a simulation<br/>
		/// object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: open_wave_database [-noautoloadwcfg] [-protoinst &lt;args&gt;] [-quiet] [-verbose] &lt;wdb&gt;
		/// <br/>
		/// <para>
		/// The open_wave_database command opens an existing static simulator database file (WDB)<br/>
		/// and associated wave config file (WCFG). This simulation is a static simulation, not live, and can<br/>
		/// only be used to review prior results.<br/>
		/// Note: Many of the commands for running and resetting the simulation are not available in a static<br/>
		/// simulation.<br/>
		/// Vivado simulator uses a simulation debug data model to allow users to debug HDL source files<br/>
		/// using source code stepping, breakpoints, conditions, and waveform viewing tools. The debug<br/>
		/// data model contains HDL object and scope names, and maps them to memory addresses to let<br/>
		/// you examine the changing values of signals, variables and constants during the simulation. When<br/>
		/// the simulation completes, the simulation is written to a static simulator database file (WDB).<br/>
		/// HDL objects can be added to the simulation waveform database using the log_wave command<br/>
		/// which enables logging of waveform activity for the specified objects to the Vivado simulator<br/>
		/// waveform database.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The waveform database is associated with a Wave Config file that stores the waveform activity<br/>
		/// for the simulation. The Wave Config file contains just the list of wave objects (signals, dividers,<br/>
		/// groups, virtual buses) to display, and their display properties, plus markers. The waveform<br/>
		/// database (WDB) contains the event data, values changing over time, for all traced signals,<br/>
		/// whether displayed or not.<br/>
		/// A Wave Config file is written to disk by the use of the save_wave_config command, and can<br/>
		/// be opened with the open_wave_config command.<br/>
		/// Use the open_wave_database command with the open_wave_config command to open a<br/>
		/// previously completed simulation for review in the Vivado IDE.<br/>
		/// TIP: Objects that were logged in the simulation waveform database, with the log_wave command, can<br/>
		/// be added posthumously to the wave configuration in a static simulation using the add_wave command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example opens a WDB file with the specified name, then opens an associated<br/>
		/// Wave Config file, and finally uses the current_fileset command to open the simulation<br/>
		/// database in the Vivado IDE:<br/>
		/// open_wave_database {C:/Data/project_xsim/testbench_behav.wdb}<br/>
		/// open_wave_config {C:/Data/project_xsim/testbench_behav.wcfg}<br/>
		/// current_fileset<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1102<br/>
		/// </para>
		/// </summary>
		/// <param name="wdb">(Required) file name</param>
		/// <param name="noautoloadwcfg">(Optional) Do not automatically open associated WCFG files</param>
		/// <param name="protoinst">(Optional) Specify a .protoinst file for protocol analysis</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL open_wave_database(TCLObject wdb, bool? noautoloadwcfg = null, TCLParameterList protoinst = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: open_wave_database [-noautoloadwcfg] [-protoinst <args>] [-quiet] [-verbose] <wdb>
			_tcl.Entry(_builder.open_wave_database(wdb, noautoloadwcfg, protoinst, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Turns on or off printing of name of the hdl process being simulated<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: ptrace [-quiet] [-verbose] &lt;value&gt;
		/// <br/>
		/// <para>
		/// Enables process tracing for simulation debugging purposes.<br/>
		/// During simulation the name of the HDL process that is evaluated will be written to the Tcl<br/>
		/// console, as well as the simulation source file and line number associated with the process.<br/>
		/// TIP: Process tracing provides more detailed information than is available with line tracing and the<br/>
		/// ltrace command.<br/>
		/// This feature can also be enabled using the PROCESS_TRACING property on the current<br/>
		/// simulation object:<br/>
		/// set_property PROCESS_TRACING on [current_sim]<br/>
		/// The command returns the state of process tracing, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1149<br/>
		/// </para>
		/// </summary>
		/// <param name="value">(Required) value: on, true, yes. Otherwise set to off, false, no</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL ptrace(TCLObject value, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: ptrace [-quiet] [-verbose] <value>
			_tcl.Entry(_builder.ptrace(value, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Import simulation data in saif format<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_saif [-strip_path &lt;arg&gt;] [-no_strip] [-out_file &lt;arg&gt;] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Reads a Switching Activity Interchange Format (SAIF) file for use during power analysis by the<br/>
		/// report_power command, or power optimization by power_opt_design. The read_saif<br/>
		/// command will annotate the design nodes with activity from the SAIF file and estimate power<br/>
		/// appropriately.<br/>
		/// Running report_power or power_opt_design after reading the SAIF file will use the activity<br/>
		/// rates from the specified file during optimization and analysis.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example:<br/>
		/// read_saif -strip_path design/top/F1 C:/Data/design1.saif<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1176<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Specifies the name of the SAIF file to be read</param>
		/// <param name="strip_path">
		/// <para>
		/// (Optional)<br/>
		/// Specifies the name of the instance of the current design as<br/>
		/// it appears in the SAIF file<br/>
		/// </para>
		/// </param>
		/// <param name="no_strip">(Optional) Do not strip first two levels of hierarchy from SAIF file</param>
		/// <param name="out_file">
		/// <para>
		/// (Optional)<br/>
		/// Specifies the name of the output file that contains nets that<br/>
		/// could not be matched<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL read_saif(TCLObject file, String strip_path = null, bool? no_strip = null, String out_file = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_saif [-strip_path <arg>] [-no_strip] [-out_file <arg>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.read_saif(file, strip_path, no_strip, out_file, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Recompile the design without changing compilation options and restart the current simulation<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: relaunch_sim [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Relaunch the simulator to perform analysis and verification of an updated design.<br/>
		/// The relaunch_sim command suspends the current simulation, recompiles the current design<br/>
		/// into a new simulation snapshot, then connects the current simulation to the new snapshot, and<br/>
		/// restarts the simulation.<br/>
		/// In the typical HDL debug cycle you will compile a design into a simulation snapshot and launch a<br/>
		/// simulation, configuring the Vivado simulator IDE to display the signals of interest in the<br/>
		/// waveform viewer, as well as the scopes and objects of interest. During the debug process you<br/>
		/// may discover issues with your code or test bench, make corrections to your design, recompile<br/>
		/// and relaunch the simulator.<br/>
		/// This command lets you recompile the design, and relaunch the simulator while preserving the<br/>
		/// current Vivado simulator configuration, such as open waveform and code windows, Scopes and<br/>
		/// Objects window settings.<br/>
		/// IMPORTANT! The relaunch_sim command applies only to simulations running in the Vivado Design<br/>
		/// Suite IDE, not stand-alone or batch Vivado simulator runs.<br/>
		/// This command returns a transcript of its process, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following command relaunches the current simulation:<br/>
		/// relaunch_sim<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1231<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Current simulation object</returns>
		public TTCL relaunch_sim(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: relaunch_sim [-quiet] [-verbose]
			_tcl.Entry(_builder.relaunch_sim(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove breakpoints from a simulation<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_bps [-all] [-file &lt;arg&gt;] [-line &lt;arg&gt;] [-quiet] [-verbose] [&lt;BreakPointObjsOrIds&gt;...]
		/// <br/>
		/// <para>
		/// Remove specified breakpoints from the current simulation. You must have an open simulation to<br/>
		/// use this command.<br/>
		/// A breakpoint is a user-determined stopping point in the source code used for debugging the<br/>
		/// design. When simulating a design with breakpoints, simulation of the design stops at each<br/>
		/// breakpoint to let you examine values and verify the design behavior.<br/>
		/// The breakpoints in the current simulation can be reported using the report_bps command.<br/>
		/// This command returns nothing, or an error if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example removes all the breakpoints in the current simulation:<br/>
		/// remove_bps -all<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1233<br/>
		/// </para>
		/// </summary>
		/// <param name="all">(Optional) Remove all breakpoints</param>
		/// <param name="file">(Optional) The specific file to remove the breakpoint from given a line number</param>
		/// <param name="line">
		/// <para>
		/// (Optional)<br/>
		/// The specific line number to remove the breakpoint given a<br/>
		/// filename Default: -1<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="BreakPointObjsOrIds">
		/// <para>
		/// (Optional)<br/>
		/// A list of one or more breakpoint objects and/or breakpoint<br/>
		/// object ID's to be removed<br/>
		/// </para>
		/// </param>
		public TTCL remove_bps(bool? all = null, String file = null, String line = null, bool? quiet = null, bool? verbose = null, TCLObjectList BreakPointObjsOrIds = null)
		{
			// TCL Syntax: remove_bps [-all] [-file <arg>] [-line <arg>] [-quiet] [-verbose] [<BreakPointObjsOrIds>...]
			_tcl.Entry(_builder.remove_bps(all, file, line, quiet, verbose, BreakPointObjsOrIds));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove conditions from a simulation. The names can be specified as Tcl glob pattern<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_conditions [-all] [-quiet] [-verbose] [&lt;ConditionObjs&gt;]
		/// <br/>
		/// <para>
		/// Remove specified conditions from the current simulation. You must have an open simulation to<br/>
		/// use this command.<br/>
		/// Conditions can be defined prior to starting the simulation. When a condition is added, the<br/>
		/// simulator evaluates the condition expression anytime a signal change is detected. When a<br/>
		/// specified condition expression becomes TRUE, the condition commands are run.<br/>
		/// The conditions in the current simulation can be reported using the report_conditions<br/>
		/// command.<br/>
		/// This command returns nothing, or an error if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example removes the specified condition from the current simulation:<br/>
		/// remove_conditions condition3<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1241<br/>
		/// </para>
		/// </summary>
		/// <param name="all">(Optional) Remove all conditions</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="ConditionObjs">(Optional) ConditionObjs, id's or names</param>
		public TTCL remove_conditions(bool? all = null, bool? quiet = null, bool? verbose = null, TCLObject ConditionObjs = null)
		{
			// TCL Syntax: remove_conditions [-all] [-quiet] [-verbose] [<ConditionObjs>]
			_tcl.Entry(_builder.remove_conditions(all, quiet, verbose, ConditionObjs));
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
		/// Release force on signal, wire, or reg applied using 'add_force' command<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_forces [-all] [-quiet] [-verbose] [&lt;ForceObj&gt;...]
		/// <br/>
		/// <para>
		/// Remove the specified force objects, or force IDs from the current simulation.<br/>
		/// Forces are applied to specific HDL objects using the add_forces command. This command<br/>
		/// removes those forces from the current simulation.<br/>
		/// IMPORTANT! If there are force/release statements on an HDL object in the test bench or module,<br/>
		/// these statements are overridden by the add_force command. When the remove_force command<br/>
		/// releases these objects to resume their normal operation, the Verilog force/release statements<br/>
		/// resume their effect.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a force object using the add_force command, and captures the<br/>
		/// force ID in a Tcl variable, then removes that force object:<br/>
		/// set f10 [ add_force reset 1 300 ]<br/>
		/// remove_forces $f10<br/>
		/// The following example removes all force objects from the current simulation:<br/>
		/// remove_forces -all<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1249<br/>
		/// </para>
		/// </summary>
		/// <param name="all">(Optional) Remove all forces</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="ForceObj">(Optional) ForceObj or id's</param>
		public TTCL remove_forces(bool? all = null, bool? quiet = null, bool? verbose = null, TCLObjectList ForceObj = null)
		{
			// TCL Syntax: remove_forces [-all] [-quiet] [-verbose] [<ForceObj>...]
			_tcl.Entry(_builder.remove_forces(all, quiet, verbose, ForceObj));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Print details of the given breakpoint objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_bps [-quiet] [-verbose] [&lt;BreakPointObjs&gt;...]
		/// <br/>
		/// <para>
		/// Report a specific breakpoint object, or report all breakpoints in the current simulation. You must<br/>
		/// have an open simulation for this command to return anything.<br/>
		/// A breakpoint is a user-determined stopping point in the source code used for debugging the<br/>
		/// design. When simulating a design with breakpoints, simulation of the design stops at each<br/>
		/// breakpoint to let you examine values and verify the design behavior.<br/>
		/// This command returns the filename and line number of the specified breakpoints, or of all<br/>
		/// breakpoints in the current simulation, or returns an error if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports all breakpoints in the current simulation:<br/>
		/// report_bps<br/>
		/// This example reports the specified breakpoints in the current simulation:<br/>
		/// report_bps bp1 bp2 bp5<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1295<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="BreakPointObjs">(Optional) List of breakpoint objects to report</param>
		/// <returns>Print the breakpoints id, file_name and line_number to the console in textual format</returns>
		public TTCL report_bps(bool? quiet = null, bool? verbose = null, TCLObjectList BreakPointObjs = null)
		{
			// TCL Syntax: report_bps [-quiet] [-verbose] [<BreakPointObjs>...]
			_tcl.Entry(_builder.report_bps(quiet, verbose, BreakPointObjs));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Print details of the given condition objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_conditions [-quiet] [-verbose] [&lt;ConditionObjs&gt;...]
		/// <br/>
		/// <para>
		/// Report a specific simulation condition, or report all conditions in the current simulation. You must<br/>
		/// have an open simulation for this command to return anything.<br/>
		/// Conditions can be defined prior to starting the simulation. When a condition is added, the<br/>
		/// simulator evaluates the condition expression anytime a signal change is detected. When a<br/>
		/// specified condition expression becomes TRUE, the condition commands are run.<br/>
		/// This command returns the condition identifier, expression, commands, and names of conditions,<br/>
		/// or returns an error if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports conditions in the current simulation. The condition identifier,<br/>
		/// expression, commands, and names are reported:<br/>
		/// report_conditions<br/>
		/// #2: condition2<br/>
		/// Expression: {/testbench/reset == 0 }<br/>
		/// Command: {<br/>
		/// puts "Condition Reset was encountered at [current_time]. \<br/>
		/// Stopping simulation."<br/>
		/// stop }<br/>
		/// Name: resetLow<br/>
		/// #3: condition3<br/>
		/// Expression: {/testbench/leds_n == X000 }<br/>
		/// Command: {<br/>
		/// puts "Condition LED Unknown was encountered at [current_time]. \<br/>
		/// Stopping simulation."<br/>
		/// stop }<br/>
		/// Name: ledUnknown<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1321<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="ConditionObjs">(Optional) ConditionObjs, id's or names</param>
		/// <returns>Prints name, id, condition_expression and commands of each condition object on the console</returns>
		public TTCL report_conditions(bool? quiet = null, bool? verbose = null, TCLObjectList ConditionObjs = null)
		{
			// TCL Syntax: report_conditions [-quiet] [-verbose] [<ConditionObjs>...]
			_tcl.Entry(_builder.report_conditions(quiet, verbose, ConditionObjs));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Print drivers along with current driving values for an HDL wire or signal object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_drivers [-quiet] [-verbose] &lt;hdl_object&gt;
		/// <br/>
		/// <para>
		/// The report_drivers command prints the name and value of the driving signal, as well as the<br/>
		/// current value of a signal type HDL object.<br/>
		/// Use this command to determine what signal or process is driving the value on a specific HDL<br/>
		/// signal, or net object. A driver of a signal is the statement in the HDL source file that is performing<br/>
		/// assignment to the signal.<br/>
		/// The output format of report_drivers is as follows:<br/>
		/// Drivers for &lt;hdl_object&gt;<br/>
		/// &lt;Value of HDL Object&gt;: Net &lt;Hierarchical name of the probed signal&gt;<br/>
		/// [ Declared Net : &lt;The declared signal to which the probed signal is<br/>
		/// connected&gt;]<br/>
		/// &lt;Value of Driver&gt; : Driver &lt;Hierarchical name of the HDL process<br/>
		/// containing<br/>
		/// the driver&gt; at &lt;file_name&gt;:&lt;line number&gt;<br/>
		/// Note: The Declared Net is returned when the probed signal name is different from the hierarchical name of<br/>
		/// the actual declared signal due to the current scope of the simulation. Each bit of the declared net is printed<br/>
		/// for the probed signal.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The values of signals returned by the report_drivers command depend on the state of the<br/>
		/// simulation. In the following example, the report is run before and after simulation:<br/>
		/// current_scope /testbench/dut<br/>
		/// report_drivers leds_n[3:0]<br/>
		/// Drivers for /testbench/dut/LEDS_n[3:0]<br/>
		/// 0 : Net /testbench/dut/LEDS_n[0]<br/>
		/// Declared Net : /testbench/leds_n[3]<br/>
		/// 0 : Driver /testbench/dut/line__187 at C:/Data/sources/sinegen_demo.vhd:187<br/>
		/// 0 : Driver /testbench/dut/line__186 at C:/Data/sources/sinegen_demo.vhd:186<br/>
		/// 0 : Driver /testbench/dut/line__185 at C:/Data/sources/sinegen_demo.vhd:185<br/>
		/// 0 : Driver /testbench/dut/line__184 at C:/Data/sources/sinegen_demo.vhd:184<br/>
		/// 0 : Net /testbench/dut/LEDS_n[1]<br/>
		/// Declared Net : /testbench/leds_n[2]<br/>
		/// 0 : Driver /testbench/dut/line__187 at C:/Data/sources/sinegen_demo.vhd:187<br/>
		/// 0 : Driver /testbench/dut/line__186 at C:/Data/sources/sinegen_demo.vhd:186<br/>
		/// 0 : Driver /testbench/dut/line__185 at C:/Data/sources/sinegen_demo.vhd:185<br/>
		/// 0 : Driver /testbench/dut/line__184 at C:/Data/sources/sinegen_demo.vhd:184<br/>
		/// 0 : Net /testbench/dut/LEDS_n[2]<br/>
		/// Declared Net : /testbench/leds_n[1]<br/>
		/// 0 : Driver /testbench/dut/line__187 at C:/Data/sources/sinegen_demo.vhd:187<br/>
		/// 1 : Driver /testbench/dut/line__186 at C:/Data/sources/sinegen_demo.vhd:186<br/>
		/// 1 : Driver /testbench/dut/line__185 at C:/Data/sources/sinegen_demo.vhd:185<br/>
		/// 1 : Driver /testbench/dut/line__184 at C:/Data/sources/sinegen_demo.vhd:184<br/>
		/// X : Net /testbench/dut/LEDS_n[3]<br/>
		/// Declared Net : /testbench/leds_n[0]<br/>
		/// 0 : Driver /testbench/dut/line__187 at C:/Data/sources/sinegen_demo.vhd:187<br/>
		/// 0 : Driver /testbench/dut/line__186 at C:/Data/sources/sinegen_demo.vhd:186<br/>
		/// 0 : Driver /testbench/dut/line__185 at C:/Data/sources/sinegen_demo.vhd:185<br/>
		/// 0 : Driver /testbench/dut/line__184 at C:/Data/sources/sinegen_demo.vhd:184<br/>
		/// run all<br/>
		/// report_drivers leds_n[3:0]<br/>
		/// Drivers for /testbench/dut/LEDS_n[3:0]<br/>
		/// 0 : Net /testbench/dut/LEDS_n[0]<br/>
		/// Declared Net : /testbench/leds_n[3]<br/>
		/// 0 : Driver /testbench/dut/line__187 at C:/Data/sources/sinegen_demo.vhd:187<br/>
		/// 0 : Driver /testbench/dut/line__186 at C:/Data/sources/sinegen_demo.vhd:186<br/>
		/// 0 : Driver /testbench/dut/line__185 at C:/Data/sources/sinegen_demo.vhd:185<br/>
		/// 0 : Driver /testbench/dut/line__184 at C:/Data/sources/sinegen_demo.vhd:184<br/>
		/// 1 : Net /testbench/dut/LEDS_n[1]<br/>
		/// Declared Net : /testbench/leds_n[2]<br/>
		/// 0 : Driver /testbench/dut/line__187 at C:/Data/sources/sinegen_demo.vhd:187<br/>
		/// 0 : Driver /testbench/dut/line__186 at C:/Data/sources/sinegen_demo.vhd:186<br/>
		/// 0 : Driver /testbench/dut/line__185 at C:/Data/sources/sinegen_demo.vhd:185<br/>
		/// 0 : Driver /testbench/dut/line__184 at C:/Data/sources/sinegen_demo.vhd:184<br/>
		/// 0 : Net /testbench/dut/LEDS_n[2]<br/>
		/// Declared Net : /testbench/leds_n[1]<br/>
		/// 1 : Driver /testbench/dut/line__187 at C:/Data/sources/sinegen_demo.vhd:187<br/>
		/// 1 : Driver /testbench/dut/line__186 at C:/Data/sources/sinegen_demo.vhd:186<br/>
		/// 1 : Driver /testbench/dut/line__185 at C:/Data/sources/sinegen_demo.vhd:185<br/>
		/// 1 : Driver /testbench/dut/line__184 at C:/Data/sources/sinegen_demo.vhd:184<br/>
		/// 0 : Net /testbench/dut/LEDS_n[3]<br/>
		/// Declared Net : /testbench/leds_n[0]<br/>
		/// 0 : Driver /testbench/dut/line__187 at C:/Data/sources/sinegen_demo.vhd:187<br/>
		/// 0 : Driver /testbench/dut/line__186 at C:/Data/sources/sinegen_demo.vhd:186<br/>
		/// 1 : Driver /testbench/dut/line__185 at C:/Data/sources/sinegen_demo.vhd:185<br/>
		/// 0 : Driver /testbench/dut/line__184 at C:/Data/sources/sinegen_demo.vhd:184<br/>
		/// Note: Notice the declared net is reported, because the current scope of the simulation is set to a different<br/>
		/// level than the top-level of the test bench.<br/>
		/// This command returns a report of the drivers on the specified objects, or returns an error if it<br/>
		/// fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the drivers for the HDL objects returned by the get_objects<br/>
		/// command:<br/>
		/// report_drivers [get_objects leds_n]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1353<br/>
		/// </para>
		/// </summary>
		/// <param name="hdl_object">(Required) Which hdl_object to report</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_drivers(TCLObject hdl_object, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_drivers [-quiet] [-verbose] <hdl_object>
			_tcl.Entry(_builder.report_drivers(hdl_object, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Print, in textual format, stack frames when current_scope is a process waiting inside subprogram<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_frames [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Returns a list of strings of sub-program names, and the calling HDL process in the sub-program<br/>
		/// call hierarchy for the current HDL process scope, or current_scope. The list starts with the<br/>
		/// HDL process till the most recent sub-program in the hierarchy. Each frame has an associated<br/>
		/// frame-index. The most recent sub-program is shown at the top, and has an index "0". The symbol<br/>
		/// (-&gt;) is used to indicate the current_frame.<br/>
		/// By default, the most recently called sub-program frame is the current_frame. Other frames<br/>
		/// can be selected using current_frame command. In verbose mode, output gives the source<br/>
		/// line-file information for each and every call.<br/>
		/// IMPORTANT! report_frames strictly follows the current_scope . If the current_scope is not<br/>
		/// an HDL process scope waiting inside a sub-program, the command returns an empty list.<br/>
		/// This command returns the name of the design object of the current_instance, or returns nothing<br/>
		/// when set to the top of current design.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// Example design:<br/>
		/// module top;<br/>
		/// int i;<br/>
		/// function void f(input int in1);<br/>
		/// automatic int a;<br/>
		/// a = in1 + 7;<br/>
		/// $display($time, " in f :: a %d in1 %d ", a, in1);<br/>
		/// endfunction<br/>
		/// task automatic t(input int in2);<br/>
		/// int b;<br/>
		/// b = in2 + 10;<br/>
		/// $display($time, " in t :: in2 %d b %d ", in2, b);<br/>
		/// #5;<br/>
		/// f(b); // Case C<br/>
		/// $display($time, " Back in t : after wait and f(%d) ", b);<br/>
		/// endtask<br/>
		/// initial begin // "/top/Initial18_0"<br/>
		/// $display($time, " in initial 1 ");<br/>
		/// i = 200;<br/>
		/// t(i); // Case B<br/>
		/// $display($time, " Back in initial 1 after t(%d) ", i);<br/>
		/// end<br/>
		/// initial begin // "/top/Initial25_1"<br/>
		/// $display($time, " in initial 2 ");<br/>
		/// #2;<br/>
		/// f(50); // Case A<br/>
		/// $display($time, " Back in initial 2 after f(50) ");<br/>
		/// end<br/>
		/// endmodule<br/>
		/// When simulation is stopped inside function "f" for its call at 'Case C', function "f" is called from<br/>
		/// task "t" at 'Case C', which itself is called from process "/top/Initial18_0" at 'Case B':<br/>
		/// &gt; current_scope<br/>
		/// /top/Initial18_0<br/>
		/// 1. &gt; report_frames<br/>
		/// -&gt; 0 : f<br/>
		/// 1 : t<br/>
		/// 2: /top/Initial18_0<br/>
		/// 2. &gt; report_frames -verbose<br/>
		/// -&gt; 0 : f @top.v:6<br/>
		/// 1 : t @top.v:15<br/>
		/// 2 : /top/Initial18_0 @top.v:21<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1362<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Returns string</returns>
		public TTCL report_frames(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_frames [-quiet] [-verbose]
			_tcl.Entry(_builder.report_frames(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Print details of the given hdl objects (variable, signal, wire, or reg)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_objects [-quiet] [-verbose] [&lt;hdl_objects&gt;...]
		/// <br/>
		/// <para>
		/// The report_objects command reports the type, name, and language of the specified HDL<br/>
		/// objects to the Tcl Console or Tcl shell. You must have an open simulation to use this command.<br/>
		/// This command returns a brief description of the specified objects. Use the describe command<br/>
		/// to return more detailed information.<br/>
		/// HDL objects include HDL signals, variables, or constants as defined in the Verilog or VHDL test<br/>
		/// bench and source files. An HDL signal includes Verilog wire or reg entities, and VHDL signals.<br/>
		/// Examples of HDL variables include Verilog real, realtime, time, and event. HDL constants include<br/>
		/// Verilog parameters and localparams, and VHDL generic and constants.<br/>
		/// The command returns the HDL object type, the name, and the code type (Verilog/VHDL) for<br/>
		/// each object, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// Verilog parameters and localparams, and VHDL generic and constants.<br/>
		/// The command returns the HDL object type, the name, and the code type (Verilog/VHDL) for<br/>
		/// each object, or returns an error if it fails.<br/>
		/// Arguments<br/>
		/// -quiet - (Optional) Execute the command quietly, returning no messages from the command.<br/>
		/// The command also returns TCL_OK regardless of any errors encountered during execution.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: Any errors encountered on the command-line, while launching the command, will be returned. Only<br/>
		/// errors occurring inside the command will be trapped.<br/>
		/// -verbose - (Optional) Temporarily override any message limits and return all messages from this<br/>
		/// command.<br/>
		/// Note: Message limits can be defined with the set_msg_config command.<br/>
		/// &lt;hdl_objects&gt; - (Optional) Specifies the objects to report. The default command reports all<br/>
		/// objects found in the current scope of the simulation, or current_scope.<br/>
		/// Note: Objects can be specified by name, or returned as objects by the get_objects command.<br/>
		/// Examples<br/>
		/// The following example shows how the specified objects reported depend upon the current scope<br/>
		/// of the simulation:<br/>
		/// current_scope testbench<br/>
		/// /testbench<br/>
		/// report_objects [get_objects leds_n]<br/>
		/// Declared: {leds_n[3:0]} Verilog<br/>
		/// current_scope dut<br/>
		/// /testbench/dut<br/>
		/// report_objects leds_n<br/>
		/// Out: {LEDS_n[3:0]} VHDL<br/>
		/// This example reports the specified HDL objects of the current simulation scope:<br/>
		/// report_objects [get_objects GPIO*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1393<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hdl_objects">(Optional) The hdl_objects to report. Default is report_objects [get_objects *]</param>
		/// <returns>Print name, type, data_type of the HDL objects on console in textual format</returns>
		public TTCL report_objects(bool? quiet = null, bool? verbose = null, TCLObjectList hdl_objects = null)
		{
			// TCL Syntax: report_objects [-quiet] [-verbose] [<hdl_objects>...]
			_tcl.Entry(_builder.report_objects(quiet, verbose, hdl_objects));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Print names of the children scopes (declarative regions) of given scope(s) or the current scope<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_scopes [-quiet] [-verbose] [&lt;hdl_scopes&gt;...]
		/// <br/>
		/// <para>
		/// Reports the names and types of HDL Scopes in the current scope of the current simulation, or of<br/>
		/// specified scopes.<br/>
		/// An HDL Scope is a declarative region of an HDL file, where objects are declared. The following<br/>
		/// are examples of HDL Scopes in Verilog and VHDL:<br/>
		/// • Verilog scopes: module, function, task, process, other begin-end blocks<br/>
		/// • VHDL scopes: entity/architecture pair, block, function, procedure, process<br/>
		/// You must have an open simulation to use this command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the children scopes of /tb/UUT:<br/>
		/// report_scopes [get_scopes /tb/UUT/* filter {type==module}<br/>
		/// The following example reports the children scopes of the current scope:<br/>
		/// report_scopes<br/>
		/// VHDL Instance: {U_DEBOUNCE_0}<br/>
		/// VHDL Instance: {U_DEBOUNCE_1}<br/>
		/// VHDL Instance: {U_SINEGEN}<br/>
		/// VHDL Instance: {U_FSM}<br/>
		/// VHDL Process: {line__138}<br/>
		/// VHDL Process: {line__184}<br/>
		/// VHDL Process: {line__185}<br/>
		/// VHDL Process: {line__186}<br/>
		/// VHDL Process: {line__187}<br/>
		/// VHDL Process: {line__191}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1437<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hdl_scopes">(Optional) The hdl_objects to report. Default is report_scopes [get_scopes *]</param>
		/// <returns>report_scopes prints a subset of properties of the HDL scope on console in textual format</returns>
		public TTCL report_scopes(bool? quiet = null, bool? verbose = null, TCLObjectList hdl_scopes = null)
		{
			// TCL Syntax: report_scopes [-quiet] [-verbose] [<hdl_scopes>...]
			_tcl.Entry(_builder.report_scopes(quiet, verbose, hdl_scopes));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report info of simulation libraries<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_simlib_info [-file &lt;arg&gt;] [-append] [-quiet] [-verbose] &lt;path&gt;
		/// <br/>
		/// <para>
		/// Report information on libraries compiled by the compile_simlib command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports information related to the compiled simulation library at the<br/>
		/// specified path:<br/>
		/// report_simlib_info C:/Data/compiled_simlib<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1440<br/>
		/// </para>
		/// </summary>
		/// <param name="path">(Required) Specify the path for pre-compiled libraries</param>
		/// <param name="file">(Optional) Output file Default: report_simlib_info.log</param>
		/// <param name="append">(Optional) Append mode</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_simlib_info(TCLObject path, String file = null, bool? append = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_simlib_info [-file <arg>] [-append] [-quiet] [-verbose] <path>
			_tcl.Entry(_builder.report_simlib_info(path, file, append, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Print names of processes in a design, which are waiting inside a subprogram, in textual format<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_stacks [-of_instance &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Print name of the HDL process scopes waiting inside a subprogram in textual format.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// Example design:<br/>
		/// module top;<br/>
		/// int i;<br/>
		/// function void f(input int in1);<br/>
		/// automatic int a;<br/>
		/// a = in1 + 7;<br/>
		/// $display($time, " in f :: a %d in1 %d ", a, in1);<br/>
		/// endfunction<br/>
		/// task automatic t(input int in2);<br/>
		/// int b;<br/>
		/// b = in2 + 10;<br/>
		/// $display($time, " in t :: in2 %d b %d ", in2, b);<br/>
		/// #5;<br/>
		/// f(b); // Case C<br/>
		/// $display($time, " Back in t : after wait and f(%d) ", b);<br/>
		/// endtask<br/>
		/// initial begin // "/top/Initial18_0"<br/>
		/// $display($time, " in initial 1 ");<br/>
		/// i = 200;<br/>
		/// t(i); // Case B<br/>
		/// $display($time, " Back in initial 1 after t(%d) ", i);<br/>
		/// end<br/>
		/// initial begin // "/top/Initial25_1"<br/>
		/// $display($time, " in initial 2 ");<br/>
		/// #2;<br/>
		/// f(50); // Case A<br/>
		/// $display($time, " Back in initial 2 after f(50) ");<br/>
		/// end<br/>
		/// endmodule<br/>
		/// When simulation is stopped inside function "f" for its call at 'Case A' , the two processes /top/<br/>
		/// Initial18_0 and /top/Initial25_1, are waiting inside task "t" (call at 'CaseB') and<br/>
		/// function "f" (call at 'CaseA') respectively.<br/>
		/// 1. &gt; report_stacks<br/>
		/// Verilog Process: {/top/Initial18_0}<br/>
		/// Verilog Process: {/top/Initial25_1}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1445<br/>
		/// </para>
		/// </summary>
		/// <param name="of_instance">(Optional) Default: NULL</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Returns string</returns>
		public TTCL report_stacks(String of_instance = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_stacks [-of_instance <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_stacks(of_instance, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Print current simulated value of given HDL objects (variable, signal, wire, or reg)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_values [-radix &lt;arg&gt;] [-quiet] [-verbose] [&lt;hdl_objects&gt;...]
		/// <br/>
		/// <para>
		/// Report the values of the specified HDL objects at the current simulation run time.<br/>
		/// HDL objects include HDL signals, variables, or constants as defined in the Verilog or VHDL test<br/>
		/// bench and source files. An HDL signal includes Verilog wire or reg entities, and VHDL signals.<br/>
		/// Examples of HDL variables include Verilog real, realtime, time, and event.<br/>
		/// HDL constants include Verilog parameters and localparams, and VHDL generic and constants.<br/>
		/// The HDL scope, or scope, is defined by a declarative region in the HDL code such as a module,<br/>
		/// function, task, process, or begin-end blocks in Verilog. VHDL scopes include entity/architecture<br/>
		/// definitions, block, function, procedure, and process blocks.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// HDL constants include Verilog parameters and localparams, and VHDL generic and constants.<br/>
		/// The HDL scope, or scope, is defined by a declarative region in the HDL code such as a module,<br/>
		/// function, task, process, or begin-end blocks in Verilog. VHDL scopes include entity/architecture<br/>
		/// definitions, block, function, procedure, and process blocks.<br/>
		/// Arguments<br/>
		/// -radix &lt;arg&gt; - (Optional) Specifies the radix to use when returning the value of the specified<br/>
		/// objects. Allowed values are: default, dec, bin, oct, hex, unsigned, ascii, or smag.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: The radix dec indicates a signed decimal. Specify the radix unsigned when dealing with unsigned<br/>
		/// data.<br/>
		/// -quiet - (Optional) Execute the command quietly, returning no messages from the command.<br/>
		/// The command also returns TCL_OK regardless of any errors encountered during execution.<br/>
		/// Note: Any errors encountered on the command-line, while launching the command, will be returned. Only<br/>
		/// errors occurring inside the command will be trapped.<br/>
		/// -verbose - (Optional) Temporarily override any message limits and return all messages from this<br/>
		/// command.<br/>
		/// Note: Message limits can be defined with the set_msg_config command.<br/>
		/// &lt;hdl_objects&gt; - (Required) Specifies one or more HDL objects to return the values of. The object<br/>
		/// can be specified by name, or can be returned as an object from the get_objects command.<br/>
		/// Examples<br/>
		/// The following example reports the value of all objects at the current time:<br/>
		/// report_values [get_objects]<br/>
		/// This example shows the difference between the bin, dec, and unsigned radix on the value<br/>
		/// returned from the specified bus:<br/>
		/// report_values -radix bin /test/bench_VStatus_pad_0_i[7:0]<br/>
		/// Declared: {/test/bench_VStatus_pad_0_i[7:0]} Verilog 10100101<br/>
		/// report_values -radix unsigned /test/bench_VStatus_pad_0_i[7:0]<br/>
		/// Declared: {/test/bench_VStatus_pad_0_i[7:0]} Verilog 165<br/>
		/// report_values -radix dec /test/bench_VStatus_pad_0_i[7:0]<br/>
		/// Declared: {/test/bench_VStatus_pad_0_i[7:0]} Verilog -91<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1475<br/>
		/// </para>
		/// </summary>
		/// <param name="hdl_objects">(Required) The hdl_objects to report. Default is report_objects [get_objects *]</param>
		/// <param name="radix">
		/// <para>
		/// (Optional)<br/>
		/// The radix specifies the radix to use for printing the values of<br/>
		/// the hdl_objects. Allowed values are: default, dec, bin, oct,<br/>
		/// hex, unsigned, ascii, smag.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Print name and value of HDL objects on the console in textual format</returns>
		public TTCL report_values(TCLObjectList hdl_objects, String radix = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_values [-radix <arg>] [-quiet] [-verbose] [<hdl_objects>...]
			_tcl.Entry(_builder.report_values(hdl_objects, radix, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Reset an existing simulation run<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_simulation [-mode &lt;arg&gt;] [-type &lt;arg&gt;] [-quiet] [-verbose] [&lt;simset&gt;]
		/// <br/>
		/// <para>
		/// Reset the current simulation to its starting condition, by cleaning out the various output files<br/>
		/// created during compilation and simulation for the specified simulation fileset.<br/>
		/// IMPORTANT! Local files will be removed from the project simulation folders without warning.<br/>
		/// The command returns nothing if successful, or an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example resets the post-synthesis timing simulation by removing files for the sim_2<br/>
		/// simset:<br/>
		/// reset_simulation -mode post-synthesis -type timing sim_2<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1514<br/>
		/// </para>
		/// </summary>
		/// <param name="mode">
		/// <para>
		/// (Optional)<br/>
		/// Remove generated data for the specified mode. Values:<br/>
		/// behavioral, post-synthesis, post-implementation Default:<br/>
		/// behavioral<br/>
		/// </para>
		/// </param>
		/// <param name="type">
		/// <para>
		/// (Optional)<br/>
		/// Remove generated data for the specified type. Applicable<br/>
		/// mode is post-synthesis or post-implementation. Values:<br/>
		/// functional, timing<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="simset">(Optional) Name of the simulation fileset to reset</param>
		public TTCL reset_simulation(reset_simulation_mode? mode = null, reset_simulation_type? type = null, bool? quiet = null, bool? verbose = null, TCLObject simset = null)
		{
			// TCL Syntax: reset_simulation [-mode <arg>] [-type <arg>] [-quiet] [-verbose] [<simset>]
			_tcl.Entry(_builder.reset_simulation(mode, type, quiet, verbose, simset));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Rewind simulation to post loading state (as if design was reloaded), time is set to 0<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: restart [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Return the current simulation to its initial state, as if the design was reloaded, resetting the<br/>
		/// current simulation time to 0.<br/>
		/// The restart command retains breakpoints, Tcl forces, and settings in the waveform<br/>
		/// configuration window, but resets all simulation values, and clears all other Tcl commands.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example restarts the current simulation:<br/>
		/// restart<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1535<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>
		/// </returns>
		public TTCL restart(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: restart [-quiet] [-verbose]
			_tcl.Entry(_builder.restart(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Run the simulation for the specified time<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: run [-all] [-quiet] [-verbose] [&lt;time&gt;] [&lt;unit&gt;]
		/// <br/>
		/// <para>
		/// Run the current simulation from the current time to the specified time, or until the simulation<br/>
		/// stops.<br/>
		/// A running simulation can be stopped at a predetermined time, at a specific breakpoint in the HDL<br/>
		/// source code, by encountering a TRUE condition, by evaluating the circuit until there are no<br/>
		/// remaining events, or by encountering a runtime error such as an out-of-bounds value.<br/>
		/// The run command instructs an existing simulation to run for a specified length of time, or until<br/>
		/// there are no remaining events. The time is specified as a floating point number indicating a<br/>
		/// period of time in the current simulation units, or in the specified units.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example runs an existing simulation for the specified simulation run time, using the<br/>
		/// default units (ns):<br/>
		/// run 1000<br/>
		/// The following example runs an existing simulation for 300 microseconds (us):<br/>
		/// run 300 us<br/>
		/// The following example runs the current simulation until no event is left in the event queue, a<br/>
		/// breakpoint or valid condition is met, or a simulation runtime error occurs:<br/>
		/// run -all<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1545<br/>
		/// </para>
		/// </summary>
		/// <param name="all">
		/// <para>
		/// (Optional)<br/>
		/// Runs simulation till a breakpoint, an exception or no events<br/>
		/// left in the queue<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="time">(Optional) Length of simulation time</param>
		/// <param name="unit">(Optional) Unit for time from the following time units: fs, ps, ns, us, ms, sec</param>
		public TTCL run(bool? all = null, bool? quiet = null, bool? verbose = null, TCLObject time = null, TCLObject unit = null)
		{
			// TCL Syntax: run [-all] [-quiet] [-verbose] [<time>] [<unit>]
			_tcl.Entry(_builder.run(all, quiet, verbose, time, unit));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set the current value of an HDL object (variable, signal, wire, or reg) to a specified value<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_value [-radix &lt;arg&gt;] [-quiet] [-verbose] &lt;hdl_object&gt; &lt;value&gt;
		/// <br/>
		/// <para>
		/// Specify the value of a single HDL object at the current simulation run time.<br/>
		/// HDL objects include HDL signals, variables, or constants as defined in the Verilog or VHDL test<br/>
		/// bench and source files. An HDL signal includes Verilog wire or reg entities, and VHDL signals.<br/>
		/// Examples of HDL variables include Verilog real, realtime, time, and event.<br/>
		/// HDL constants include Verilog parameters and localparams, and VHDL generic and constants.<br/>
		/// The HDL scope, or scope, is defined by a declarative region in the HDL code such as a module,<br/>
		/// function, task, process, or begin-end blocks in Verilog. VHDL scopes include entity/architecture<br/>
		/// definitions, block, function, procedure, and process blocks.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// HDL constants include Verilog parameters and localparams, and VHDL generic and constants.<br/>
		/// The HDL scope, or scope, is defined by a declarative region in the HDL code such as a module,<br/>
		/// function, task, process, or begin-end blocks in Verilog. VHDL scopes include entity/architecture<br/>
		/// definitions, block, function, procedure, and process blocks.<br/>
		/// Arguments<br/>
		/// -radix &lt;arg&gt; - (Optional) Specifies the radix to use when returning the value of the specified<br/>
		/// object. Allowed values are: default, dec, bin, oct, hex, unsigned, ascii, or smag.<br/>
		/// Note: The radix dec indicates a signed decimal. Specify the radix unsigned when dealing with unsigned<br/>
		/// data.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// -quiet - (Optional) Execute the command quietly, returning no messages from the command.<br/>
		/// The command also returns TCL_OK regardless of any errors encountered during execution.<br/>
		/// Note: Any errors encountered on the command-line, while launching the command, will be returned. Only<br/>
		/// errors occurring inside the command will be trapped.<br/>
		/// -verbose - (Optional) Temporarily override any message limits and return all messages from this<br/>
		/// command.<br/>
		/// Note: Message limits can be defined with the set_msg_config command.<br/>
		/// &lt;hdl_object&gt; - (Required) Specifies a single HDL object to get the value of. The object can be<br/>
		/// specified by name, or can be returned as an object from the get_objects command.<br/>
		/// &lt;value&gt; - (Required) The value to set the specified object to. The specified &lt;value&gt; depends on<br/>
		/// the type of the &lt;hdl_object&gt;. HDL object types include: "logic", floating point, VHDL<br/>
		/// enumerated, and VHDL integral. For all but "logic" the -radix option is ignored.<br/>
		/// • "Logic" does not refer to an actual HDL object type, but means any object whose values are<br/>
		/// similar to those of VHDL std_logic, such as:<br/>
		/// ○ the Verilog implicit 4-state bit type,<br/>
		/// ○ the VHDL bit and std_logic predefined types,<br/>
		/// ○ any VHDL enumeration type which is a subset of std_logic, including the character literals<br/>
		/// '0' and '1'.<br/>
		/// • For logic types the value depends on the radix:<br/>
		/// ○ If the specified value has fewer bits than the logic type expects, the value is zero extended,<br/>
		/// but not sign extended, to match the expected length.<br/>
		/// ○ If the specified value has more bits than the logic type expects, the extra bits on the MSB<br/>
		/// side should all be zeros, or the Vivado simulator will return a "size mismatch" error.<br/>
		/// • Accepted values for floating point objects are floating point values.<br/>
		/// • The accepted value for non-logic VHDL enumerated types is a scalar value from the<br/>
		/// enumerated set of values, without single quotes in the case of characters.<br/>
		/// • Accepted values for VHDL integral types is a signed decimal integer in the range accepted by<br/>
		/// the type.<br/>
		/// Examples<br/>
		/// The following example sets the value of the sysClk signal:<br/>
		/// set_value sysClk Z<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This example uses the bin, dec, and unsigned radix to specify the same value on the given<br/>
		/// bus:<br/>
		/// set_value -radix bin /test/bench_VStatus_pad_0_i[7:0] 10100101<br/>
		/// set_value -radix unsigned /test/bench_VStatus_pad_0_i[7:0] 165<br/>
		/// set_value -radix dec /test/bench_VStatus_pad_0_i[7:0] -91<br/>
		/// The following example shows the bit extension performed when the provided value has fewer<br/>
		/// bits than the logic type expects:<br/>
		/// set_value -radix bin /test/bench_VStatus_pad_0_i[7:0] 101<br/>
		/// get_value -radix bin /test/bench_VStatus_pad_0_i[7:0]<br/>
		/// 00000101<br/>
		/// The following example shows the bit truncation performed when the provided value has more<br/>
		/// bits than the logic type expects:<br/>
		/// set_value -radix bin /test/bench_VStatus_pad_0_i[7:0] 0010100101<br/>
		/// get_value -radix bin /test/bench_VStatus_pad_0_i[7:0]<br/>
		/// 10100101<br/>
		/// set_value -radix bin /test/bench_VStatus_pad_0_i[7:0] 1110100101<br/>
		/// ERROR: [#UNDEF] Object size 8 does not match size of given value 1110100101<br/>
		/// Note: In the second set_value command, the extra bits are not zero, and so an error is returned.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1698<br/>
		/// </para>
		/// </summary>
		/// <param name="hdl_object">(Required) Set the value on the given hdl_object.</param>
		/// <param name="value">(Required) The value to assign to the specified object.</param>
		/// <param name="radix">
		/// <para>
		/// (Optional)<br/>
		/// radix specifies the radix to use for interpreting value.<br/>
		/// Allowed values are: default, dec, bin, oct, hex, unsigned,<br/>
		/// ascii, smag<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_value(TCLObject hdl_object, TCLObject value, String radix = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_value [-radix <arg>] [-quiet] [-verbose] <hdl_object> <value>
			_tcl.Entry(_builder.set_value(hdl_object, value, radix, quiet, verbose));
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
		/// Start capturing VCD output (equivalent of $dumpon verilog system task). This can be used after a<br/>
		/// stop_vcd TCL command has stopped VCD generation started by open_vcd<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: start_vcd [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// The start_vcd command specifies that the tool start writing Value Change Dump (VCD)<br/>
		/// information into the specified VCD object. This Tcl command models the behavior of the Verilog<br/>
		/// $dumpon system task.<br/>
		/// IMPORTANT! You must execute the open_vcd command before using the start_vcd command.<br/>
		/// Nothing is returned by this command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example starts the writing of HDL signals into the current VCD file:<br/>
		/// start_vcd<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1714<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL start_vcd(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: start_vcd [-quiet] [-verbose]
			_tcl.Entry(_builder.start_vcd(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Step simulation to the next statement<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: step [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Step the current simulation to the next executable statement in the HDL source files.<br/>
		/// The line stepping feature lets you run the simulator stepping through the source code line-by-line. This is helpful if you are interested in observing how each line or feature of your HDL source<br/>
		/// affects the results of simulation.<br/>
		/// The step command returns information related to the next executable line from the HDL source<br/>
		/// file, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example runs the current executable line of the HDL source code, and pauses at<br/>
		/// the next executable line, returning information about that line:<br/>
		/// step<br/>
		/// Stopped at time : 0 fs : File "C:/Data/ug937/sim/testbench.v" Line 17<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1718<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL step(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: step [-quiet] [-verbose]
			_tcl.Entry(_builder.step(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Use within a condition to tell simulation to stop when a condition is true<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: stop [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// The stop command pauses the current simulation. This command can be used within a<br/>
		/// condition, defined by add_condition, to pause the simulation when the condition is true.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example defines a condition named resetLow, that becomes true when the reset<br/>
		/// signal is low, and then puts a message to the standard output, and stops the current simulation:<br/>
		/// add_condition -name resetLow {/testbench/reset == 0 } {<br/>
		/// puts "Condition Reset was encountered at [current_time]. \<br/>
		/// Stopping simulation."<br/>
		/// stop }<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1720<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>A "stop" in simulation is a pause and not a quit</returns>
		public TTCL stop(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: stop [-quiet] [-verbose]
			_tcl.Entry(_builder.stop(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Stop capturing VCD output (equivalent of $dumpoff verilog system task). The start_vcd TCL<br/>
		/// command can be used to resume capturing VCD<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: stop_vcd [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Stop writing the simulation values to the current Value Change Dump (VCD) file. This suspends<br/>
		/// the output of simulation information to the file until the process is resumed using the<br/>
		/// start_vcd command.<br/>
		/// This Tcl command models the behavior of the Verilog $dumpoff system task.<br/>
		/// IMPORTANT! You must execute the open_vcd command before using the stop_vcd command.<br/>
		/// Nothing is returned by the command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example stops writing simulation values to the current VCD file:<br/>
		/// stop_vcd<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1729<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL stop_vcd(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: stop_vcd [-quiet] [-verbose]
			_tcl.Entry(_builder.stop_vcd(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// write_sdf command generates flat sdf delay files for event simulation<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_sdf [-process_corner &lt;arg&gt;] [-cell &lt;arg&gt;] [-rename_top &lt;arg&gt;] [-force] [-mode &lt;arg&gt;] [-gzip] [-multithread &lt;arg&gt;] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Writes the timing delays for cells in the design to a Standard Delay Format (SDF) file.<br/>
		/// The output SDF file can be used by the write_verilog command to create Verilog netlists for<br/>
		/// static timing analysis and timing simulation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example writes an SDF file to the specified directory:<br/>
		/// write_sdf C:/Data/FPGA_Design/designOut.sdf<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1889<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) File name</param>
		/// <param name="process_corner">
		/// <para>
		/// (Optional)<br/>
		/// Specify process corner for which SDF delays are required;<br/>
		/// Values: slow, fast Default: slow<br/>
		/// </para>
		/// </param>
		/// <param name="cell">(Optional) Root of the design to write, e.g. des.subblk.cpu Default: whole design</param>
		/// <param name="rename_top">
		/// <para>
		/// (Optional)<br/>
		/// Replace name of top module with custom name e.g. netlist<br/>
		/// Default: new top module name<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Overwrite existing SDF file</param>
		/// <param name="mode">
		/// <para>
		/// (Optional)<br/>
		/// Specify sta (Static Timing Analysis) or timesim (Timing<br/>
		/// Simulation) mode for SDF Default: timesim<br/>
		/// </para>
		/// </param>
		/// <param name="gzip">(Optional) write gzipped SDF</param>
		/// <param name="multithread">(Optional) Run in multithread mode with specified number of threads Default: -1</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_sdf(TCLObject file, write_sdf_process_corner? process_corner = null, String cell = null, String rename_top = null, bool? force = null, String mode = null, bool? gzip = null, Int32? multithread = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_sdf [-process_corner <arg>] [-cell <arg>] [-rename_top <arg>] [-force] [-mode <arg>] [-gzip] [-multithread <arg>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_sdf(file, process_corner, cell, rename_top, force, mode, gzip, multithread, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Export the current netlist in Verilog format<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_verilog [-cell &lt;arg&gt;] [-mode &lt;arg&gt;] [-lib] [-port_diff_buffers] [-write_all_overrides] [-keep_vcc_gnd] [-rename_top &lt;arg&gt;] [-sdf_anno &lt;arg&gt;] [-sdf_file &lt;arg&gt;] [-force] [-include_xilinx_libs] [-logic_function_stripped] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Write a Verilog netlist of the current design or from a specific cell of the design to the specified<br/>
		/// file or directory. The output is a IEEE 1364-2001 compliant Verilog HDL file that contains netlist<br/>
		/// information obtained from the input design files.<br/>
		/// You can output a complete netlist of the design or specific cell, or output a port list for the<br/>
		/// design, or a Verilog netlist for simulation or static timing analysis.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example writes a Verilog simulation netlist file for the whole design to the specified<br/>
		/// file and path:<br/>
		/// write_verilog C:/Data/my_verilog.v<br/>
		/// In the following example, because the -mode timesim and -sdf_anno options are specified,<br/>
		/// the $sdf_annotate statement will be added to the Verilog netlist. However, since the -<br/>
		/// sdf_file option is not specified, the SDF file is assumed to have the same name as the Verilog<br/>
		/// output file, with an .sdf file extension:<br/>
		/// write_verilog C:/Data/my_verilog.net -mode timesim -sdf_anno true<br/>
		/// Note: The SDF filename written to the $sdf_annotate statement will be my_verilog.sdf.<br/>
		/// In the following example, the functional simulation mode is specified, the option to keep VCC<br/>
		/// and GND primitives in the output simulation netlist is enabled, and the output file is specified:<br/>
		/// write_verilog -mode funcsim -keep_vcc_gnd out.v<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1891<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Which file to write</param>
		/// <param name="cell">(Optional) Root of the design to write, e.g. des.subblk.cpu Default: whole design</param>
		/// <param name="mode">
		/// <para>
		/// (Optional)<br/>
		/// Values: design, pin_planning, synth_stub, sta, funcsim,<br/>
		/// timesim Default: design<br/>
		/// </para>
		/// </param>
		/// <param name="lib">(Optional) Write each library into a separate file</param>
		/// <param name="port_diff_buffers">(Optional) Output differential buffers when writing in -port mode</param>
		/// <param name="write_all_overrides">
		/// <para>
		/// (Optional)<br/>
		/// Write parameter overrides on Xilinx primitives even if the<br/>
		/// override value is the same as the default value<br/>
		/// </para>
		/// </param>
		/// <param name="keep_vcc_gnd">
		/// <para>
		/// (Optional)<br/>
		/// Don't replace VCC/GND instances by literal constants on<br/>
		/// load terminals. For simulation modes only.<br/>
		/// </para>
		/// </param>
		/// <param name="rename_top">
		/// <para>
		/// (Optional)<br/>
		/// Replace top module name with custom name e.g. netlist<br/>
		/// Default: new top module name<br/>
		/// </para>
		/// </param>
		/// <param name="sdf_anno">(Optional) Specify if sdf_annotate system task statement is generated</param>
		/// <param name="sdf_file">(Optional) Full path to sdf file location Default: &lt;file&gt;.sdf</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="include_xilinx_libs">
		/// <para>
		/// (Optional)<br/>
		/// Include simulation models directly in netlist instead of<br/>
		/// linking to library<br/>
		/// </para>
		/// </param>
		/// <param name="logic_function_stripped">
		/// <para>
		/// (Optional)<br/>
		/// Convert INIT strings on LUTs &amp; RAMBs to fixed values.<br/>
		/// Resulting netlist will not behave correctly.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>the name of the output file or directory</returns>
		public TTCL write_verilog(TCLObject file, String cell = null, write_verilog_mode? mode = null, bool? lib = null, bool? port_diff_buffers = null, bool? write_all_overrides = null, bool? keep_vcc_gnd = null, String rename_top = null, String sdf_anno = null, String sdf_file = null, bool? force = null, bool? include_xilinx_libs = null, bool? logic_function_stripped = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_verilog [-cell <arg>] [-mode <arg>] [-lib] [-port_diff_buffers] [-write_all_overrides] [-keep_vcc_gnd] [-rename_top <arg>] [-sdf_anno <arg>] [-sdf_file <arg>] [-force] [-include_xilinx_libs] [-logic_function_stripped] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_verilog(file, cell, mode, lib, port_diff_buffers, write_all_overrides, keep_vcc_gnd, rename_top, sdf_anno, sdf_file, force, include_xilinx_libs, logic_function_stripped, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Export the current netlist in VHDL format<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_vhdl [-cell &lt;arg&gt;] [-mode &lt;arg&gt;] [-lib] [-port_diff_buffers] [-write_all_overrides] [-keep_vcc_gnd] [-rename_top &lt;arg&gt;] [-arch_only] [-force] [-include_xilinx_libs] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Write a VHDL netlist of the current design or from a specific cell of the design to the specified<br/>
		/// file or directory.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The output of this command is a VHDL IEEE 1076.4 VITAL-2000 compliant VHDL file that<br/>
		/// contains netlist information obtained from the input design files. You can output a complete<br/>
		/// netlist of the design or specific cell, or output a port list for the design.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example writes a VHDL simulation netlist file for the whole design to the specified<br/>
		/// file and path:<br/>
		/// write_vhdl C:/Data/bft_top.vhd<br/>
		/// In the following example the entity definition of the top-level module is not output to the VHDL<br/>
		/// netlist:<br/>
		/// write_vhdl C:/Data/vhdl_arch_only.vhd -arch_only<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1895<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Which file to write</param>
		/// <param name="cell">(Optional) Root of the design to write, e.g. des.subblk.cpu Default: whole design</param>
		/// <param name="mode">
		/// <para>
		/// (Optional)<br/>
		/// Output mode. Valid values: funcsim, pin_planning,<br/>
		/// synth_stub Default: funcsim<br/>
		/// </para>
		/// </param>
		/// <param name="lib">(Optional) Write each library into a separate file</param>
		/// <param name="port_diff_buffers">(Optional) Output differential buffers when writing in -port mode</param>
		/// <param name="write_all_overrides">
		/// <para>
		/// (Optional)<br/>
		/// Write parameter overrides on Xilinx primitives even if the<br/>
		/// same as the default value<br/>
		/// </para>
		/// </param>
		/// <param name="keep_vcc_gnd">
		/// <para>
		/// (Optional)<br/>
		/// Don't replace VCC/GND instances by literal constants on<br/>
		/// load terminals. For simulation modes only.<br/>
		/// </para>
		/// </param>
		/// <param name="rename_top">
		/// <para>
		/// (Optional)<br/>
		/// Replace top module name with custom name e.g. netlist<br/>
		/// Default: new top module name<br/>
		/// </para>
		/// </param>
		/// <param name="arch_only">
		/// <para>
		/// (Optional)<br/>
		/// Write only the architecture, not the entity declaration for the<br/>
		/// top cell<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="include_xilinx_libs">
		/// <para>
		/// (Optional)<br/>
		/// Include simulation models directly in netlist instead of<br/>
		/// linking to library<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>the name of the output file or directory</returns>
		public TTCL write_vhdl(TCLObject file, String cell = null, String mode = null, bool? lib = null, bool? port_diff_buffers = null, bool? write_all_overrides = null, bool? keep_vcc_gnd = null, String rename_top = null, bool? arch_only = null, bool? force = null, bool? include_xilinx_libs = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_vhdl [-cell <arg>] [-mode <arg>] [-lib] [-port_diff_buffers] [-write_all_overrides] [-keep_vcc_gnd] [-rename_top <arg>] [-arch_only] [-force] [-include_xilinx_libs] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_vhdl(file, cell, mode, lib, port_diff_buffers, write_all_overrides, keep_vcc_gnd, rename_top, arch_only, force, include_xilinx_libs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Load a simulation snapshot for simulation and return a simulation object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: xsim [-view &lt;args&gt;] [-autoloadwcfg] [-runall] [-R] [-maxdeltaid &lt;arg&gt;] [-nolog] [-maxlogsize &lt;arg&gt;] [-onfinish &lt;arg&gt;] [-onerror &lt;arg&gt;] [-tclbatch &lt;args&gt;] [-t &lt;args&gt;] [-testplusarg &lt;args&gt;] [-vcdfile &lt;arg&gt;] [-vcdunit &lt;arg&gt;] [-wdb &lt;arg&gt;] [-tp] [-tl] [-nosignalhandlers] [-ieeewarnings] [-stats] [-scNoLogFile] [-sv_seed &lt;arg&gt;] [-protoinst &lt;args&gt;] [-cov_db_dir &lt;arg&gt;] [-cov_db_name &lt;arg&gt;] [-ignore_assertions] [-ignore_coverage] [-downgrade_error2info] [-downgrade_error2warning] [-downgrade_fatal2info] [-downgrade_fatal2warning] [-ignore_feature &lt;args&gt;] [-downgrade_severity &lt;args&gt;] [-quiet] [-verbose] &lt;snapshot&gt;
		/// <br/>
		/// <para>
		/// The xsim command loads a simulation snapshot to run a batch mode simulation, or to provide a<br/>
		/// GUI and/or Tcl-based interactive simulation environment. The snapshot must be generated using<br/>
		/// the xelab command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example launches xsim on the specified simulation snapshot:<br/>
		/// xsim C:/Data/project_xsim/project_xsim.sim/sim_1/behav/testbench_behav<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1903<br/>
		/// </para>
		/// </summary>
		/// <param name="snapshot">(Required) The name of design snapshot or WDB file</param>
		/// <param name="view">
		/// <para>
		/// (Optional)<br/>
		/// Open a wave configuration file. This switch may be repeated<br/>
		/// to open multiple files.<br/>
		/// </para>
		/// </param>
		/// <param name="autoloadwcfg">
		/// <para>
		/// (Optional)<br/>
		/// For a WDB file named &lt;name&gt;.wdb, automatically open all<br/>
		/// WCFG files named &lt;name&gt;#.wcfg. Ignored if -view is<br/>
		/// present.<br/>
		/// </para>
		/// </param>
		/// <param name="runall">(Optional) Run simulation until completion, then quit (does 'run -all; exit')</param>
		/// <param name="R">(Optional) Run simulation until completion, then quit (does 'run -all; exit')</param>
		/// <param name="maxdeltaid">
		/// <para>
		/// (Optional)<br/>
		/// Specify the maximum delta number. Will report error if it<br/>
		/// exceeds maximum simulation loops at the same time<br/>
		/// Default: 10000<br/>
		/// </para>
		/// </param>
		/// <param name="nolog">(Optional) Ignored (for compatibility with xsim command-line tool)</param>
		/// <param name="maxlogsize">
		/// <para>
		/// (Optional)<br/>
		/// Set the maximum size a log file can reach in MB. The default<br/>
		/// setting is unlimited Default: -1<br/>
		/// </para>
		/// </param>
		/// <param name="onfinish">(Optional) Specify behavior at end of simulation: quit|stop Default: stop</param>
		/// <param name="onerror">
		/// <para>
		/// (Optional)<br/>
		/// Specify behavior upon simulation run-time error: quit|stop<br/>
		/// Default: stop<br/>
		/// </para>
		/// </param>
		/// <param name="tclbatch">(Optional) Specify the TCL file for batch mode execution</param>
		/// <param name="t">(Optional) Specify the TCL file for batch mode execution</param>
		/// <param name="testplusarg">
		/// <para>
		/// (Optional)<br/>
		/// Specify plusargs to be used by $test$plusargs and $value<br/>
		/// $plusargs system functions<br/>
		/// </para>
		/// </param>
		/// <param name="vcdfile">
		/// <para>
		/// (Optional)<br/>
		/// Specify the vcd output file<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Name Description<br/>
		/// </para>
		/// </param>
		/// <param name="vcdunit">
		/// <para>
		/// (Optional)<br/>
		/// Specify the vcd output unit. Default is the same as the<br/>
		/// engine precision unit<br/>
		/// </para>
		/// </param>
		/// <param name="wdb">(Optional) Specify the waveform database output file</param>
		/// <param name="tp">(Optional) Enable printing of hierarchical names of process being executed</param>
		/// <param name="tl">
		/// <para>
		/// (Optional)<br/>
		/// Enable printing of file name and line number of statements<br/>
		/// being executed.<br/>
		/// </para>
		/// </param>
		/// <param name="nosignalhandlers">(Optional) Run with no signal handlers to avoid conflict with security software</param>
		/// <param name="ieeewarnings">(Optional) Enable warnings from VHDL IEEE functions</param>
		/// <param name="stats">(Optional) Display memory and cpu stats upon exiting</param>
		/// <param name="scNoLogFile">(Optional) Keep the SystemC output separate from XSim output</param>
		/// <param name="sv_seed">(Optional) Seed for constraint random stimulus Default: 1</param>
		/// <param name="protoinst">(Optional) Specify a .protoinst file for protocol analysis</param>
		/// <param name="cov_db_dir">
		/// <para>
		/// (Optional)<br/>
		/// System Verilog Coverage Run Directory. The coverage data<br/>
		/// will be present under &lt;cov_db_dir&gt;/xsim.covdb/<br/>
		/// &lt;cov_db_name&gt; directory.Default is ./ or inherits value set in<br/>
		/// similar xelab option.<br/>
		/// </para>
		/// </param>
		/// <param name="cov_db_name">
		/// <para>
		/// (Optional)<br/>
		/// System Verilog Coverage Run Name. The coverage data will<br/>
		/// be present under &lt;cov_db_dir&gt;/xsim.covdb/&lt;cov_db_name&gt;<br/>
		/// directory.Default is snapshot name or inherits value set in<br/>
		/// similar xelab option.<br/>
		/// </para>
		/// </param>
		/// <param name="ignore_assertions">(Optional) Ignore System Verilog concurrent assertion constructs at runtime.</param>
		/// <param name="ignore_coverage">(Optional) Ignore System Verilog Functional Coverage at runtime.</param>
		/// <param name="downgrade_error2info">(Optional) Downgrade System verilog message severity from error to info level.</param>
		/// <param name="downgrade_error2warning">(Optional) Downgrade System verilog message severity from error to warning level.</param>
		/// <param name="downgrade_fatal2info">(Optional) Downgrade System verilog message severity from fatal to info level.</param>
		/// <param name="downgrade_fatal2warning">(Optional) Downgrade System verilog message severity from fatal to warning level.</param>
		/// <param name="ignore_feature">
		/// <para>
		/// (Optional)<br/>
		/// Specify System Verilog feature to be ignored at runtime.<br/>
		/// Choices are: assertion : Ignore concurrent assertions.<br/>
		/// </para>
		/// </param>
		/// <param name="downgrade_severity">
		/// <para>
		/// (Optional)<br/>
		/// Downgrade severity level of System Verilog HDL<br/>
		/// messages.Choices are: error2warning|error2info|<br/>
		/// fatal2warning|fatal2info.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Current simulation object</returns>
		public TTCL xsim(TCLObject snapshot, TCLParameterList view = null, bool? autoloadwcfg = null, bool? runall = null, bool? R = null, String maxdeltaid = null, bool? nolog = null, String maxlogsize = null, String onfinish = null, String onerror = null, TCLParameterList tclbatch = null, TCLParameterList t = null, TCLParameterList testplusarg = null, String vcdfile = null, String vcdunit = null, String wdb = null, bool? tp = null, bool? tl = null, bool? nosignalhandlers = null, bool? ieeewarnings = null, bool? stats = null, bool? scNoLogFile = null, String sv_seed = null, TCLParameterList protoinst = null, String cov_db_dir = null, String cov_db_name = null, bool? ignore_assertions = null, bool? ignore_coverage = null, bool? downgrade_error2info = null, bool? downgrade_error2warning = null, bool? downgrade_fatal2info = null, bool? downgrade_fatal2warning = null, TCLParameterList ignore_feature = null, TCLParameterList downgrade_severity = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: xsim [-view <args>] [-autoloadwcfg] [-runall] [-R] [-maxdeltaid <arg>] [-nolog] [-maxlogsize <arg>] [-onfinish <arg>] [-onerror <arg>] [-tclbatch <args>] [-t <args>] [-testplusarg <args>] [-vcdfile <arg>] [-vcdunit <arg>] [-wdb <arg>] [-tp] [-tl] [-nosignalhandlers] [-ieeewarnings] [-stats] [-scNoLogFile] [-sv_seed <arg>] [-protoinst <args>] [-cov_db_dir <arg>] [-cov_db_name <arg>] [-ignore_assertions] [-ignore_coverage] [-downgrade_error2info] [-downgrade_error2warning] [-downgrade_fatal2info] [-downgrade_fatal2warning] [-ignore_feature <args>] [-downgrade_severity <args>] [-quiet] [-verbose] <snapshot>
			_tcl.Entry(_builder.xsim(snapshot, view, autoloadwcfg, runall, R, maxdeltaid, nolog, maxlogsize, onfinish, onerror, tclbatch, t, testplusarg, vcdfile, vcdunit, wdb, tp, tl, nosignalhandlers, ieeewarnings, stats, scNoLogFile, sv_seed, protoinst, cov_db_dir, cov_db_name, ignore_assertions, ignore_coverage, downgrade_error2info, downgrade_error2warning, downgrade_fatal2info, downgrade_fatal2warning, ignore_feature, downgrade_severity, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
