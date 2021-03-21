// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class SimulationCommands
	{
		private readonly QuokkaTCL _tcl;
		public SimulationCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Add breakpoint at a line of a HDL source
		///
		/// The add_bp command lets you add breakpoints to an HDL source file to pause the current
		/// simulation.
		/// A breakpoint is a user-determined stopping point in the source code used for debugging the
		/// design. When simulating a design with breakpoints, simulation of the design stops at each
		/// breakpoint to let you examine values and verify the design behavior.
		/// You can report breakpoints in the current simulation using the report_bps command, and
		/// remove existing breakpoints using the remove_bps command.
		/// This command returns a new breakpoint object if there is not already a breakpoint set at the
		/// specified file line, or returns an existing breakpoint object if there is already a breakpoint defined
		/// for the specified file and line number.
		/// TIP: You can capture the returned breakpoint object in a Tcl variable if needed.
		/// The add_bp command returns an error if the command fails.
		///
		/// The following example adds a the breakpoint to the HDL source file at the specified line number:
		/// add_bp C:/Data/ug937/sources/sinegen.vhd 137
		///
		/// See ug835-vivado-tcl-commands.pdf, page 31
		/// </summary>
		/// <param name="file_name">
		/// Required
		/// Filename to add the breakpoint
		/// </param>
		/// <param name="line_number">
		/// Required
		/// Line number of the given file to set the breakpoint
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>
		/// </returns>
		public void add_bp(string file_name, string line_number, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("add_bp");
			_tcl.Add(command);
		}
		/// <summary>
		/// Conditionally execute Tcl commands
		///
		/// Add a condition that is evaluated by a specified condition, <condition_expression>, and runs a
		/// series of simulation Tcl commands when the condition is TRUE.
		/// Conditions can be defined prior to starting the simulation. When a condition is added, the
		/// simulator evaluates the condition expression anytime a signal change is detected. When a
		/// specified condition expression becomes TRUE, the condition commands are run.
		/// The add_condition command returns a condition identifier for the added condition, or returns
		/// an error if the command fails.
		///
		/// The following example defines a condition named resetLow, that becomes true when the reset
		/// signal is low, and then puts a message to the standard output, and stops the current simulation:
		/// add_condition -name resetLow {/testbench/reset == 0 } {
		/// puts "Condition Reset was encountered at [current_time]. Stopping
		/// simulation."
		/// stop }
		/// This next example defines a Tcl procedure, called myProc, that uses the add_force command to
		/// define clk and reset signal values, and print a standard message when it completes. A
		/// condition is then added that calls myProc when reset is low:
		/// proc myProc {} {
		/// add_force clk {0 1} { 1 2} -repeat_every 4 -cancel_after 500
		/// add_force reset 1
		/// run 10 ns
		/// remove_force force2
		/// puts "Reached end of myProc"
		/// }
		/// add_condition -radix unsigned /top/reset==0 myproc
		///
		/// See ug835-vivado-tcl-commands.pdf, page 35
		/// </summary>
		/// <param name="condition_expression">
		/// Required
		/// The condition expression when true executes the given
		/// commands
		/// </param>
		/// <param name="commands">
		/// Required
		/// Commands to execute upon condition
		/// </param>
		/// <param name="name">
		/// Optional
		/// Assign a unique name (label) to a condition. Multiple
		/// conditions cannot be assigned the same name. If no name
		/// is specified, then a default label named as condition<id> is
		/// automatically created
		/// </param>
		/// <param name="radix">
		/// Optional
		/// Specifies which radix to use. Allowed values are: default,
		/// dec, bin, oct, hex, unsigned, ascii, smag.
		/// </param>
		/// <param name="notrace">
		/// Optional
		/// Turn off the logging of condition commands
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>The condition object created</returns>
		public void add_condition(string condition_expression, string commands, string name = null, string radix = null, bool? notrace = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("add_condition");
			_tcl.Add(command);
		}
		/// <summary>
		/// Add sources to the active fileset
		///
		/// Adds one or more source files, or the source file contents of one or more directories, to the
		/// specified fileset in the current project. Valid source files include HDL sources (VHDL, Verilog,
		/// SystemVerilog, and related header files), netlist sources (DCP, EDIF, and NGC), and memory
		/// interface files (BMM, MIF, MEM, ELF).
		/// IP and Block Design sources are not added through the add_files command. These are
		/// compound files that are supported by separate commands such as import_ip, read_bd, and
		/// read_ip.
		/// For every file added to a project the Vivado Design Suite attempts to store and maintain both a
		/// relative path and an absolute path to the file or directory. When a project is opened, these paths
		/// are used to locate the files and directories. By default the Vivado Design Suite applies a Relative
		/// First approach to resolving paths, searching the relative path first, then the absolute path. You
		/// can use the PATH_MODE property to change how the Vivado tool resolves file paths or
		/// properties for specific objects. For more information, see the Vivado Design Suite Properties
		/// Reference Guide (UG912).
		/// IMPORTANT! Adding multiple files one at a time can cause noticeable performance degradation. It is more
		/// efficient to use a single add_files command to import a list of files:
		/// add_files {file1 file2 file3 ... fileN}
		/// The Vivado tool does not read the contents of a file automatically when the file is added to the
		/// project with add_files, but rather reads the file contents when they are needed. For instance,
		/// a constraints file is not read when added to the design until needed by synthesis, timing, or
		/// implementation. To read the file at the time of adding it to the design, use the read_xxx
		/// command instead.
		/// TIP: When running the Vivado tool in Non-Project mode, in which there is no project file to maintain and
		/// manage the various project source files, you should use the read_xxx commands to read the contents of
		/// source files into the in-memory design. Refer to the Vivado Design Suite User Guide: Design Flows Overview
		/// (UG892) for more information on Non-Project mode.
		/// The add_files command adds them by reference to the specified fileset. This is different from
		/// the import_files command, which copies the file into the local project folders as well as
		/// adding them to the specified fileset.
		/// This command returns the files that were added, or returns an error if it fails.
		///
		/// The following example adds a file called rtl.v to the current project:
		/// add_files rtl.v
		/// In the preceding example the tool looks for the rtl.v file in the current working directory since no
		/// file path is specified, and the file is added to the source fileset as a default since no fileset is
		/// specified.
		/// The following example adds a file called top.xdc to the constrs_1 constraint fileset, as well
		/// as any appropriate source files found in the project_1 directory, and its subdirectories:
		/// add_files -fileset constrs_1 -quiet c:/Design/top.xdc c:/Design/project_1
		/// In addition, the tool ignores any command line errors because the -quiet argument was
		/// specified.
		/// If the -norecurse option had been specified then only constraint files found in the
		/// project_1 directory would have been added, but subdirectories would not be searched.
		/// The following example adds an existing IP core file to the current project:
		/// add_files -norecurse C:/Data/ip/c_addsub_v11_0_0.xci
		/// Note: Use the import_ip command to import the IP file into the local project folders.
		/// The following example reads a top-level design netlist, and the char_fifo IP in a Non-Project
		/// Mode design:
		/// # Read top-level EDIF and IP DCP
		/// read_edif ./sources/wave_gen.edif
		/// add_files ./my_IP/char_fifo/char_fifo.xci
		/// Note: Either add_files or read_ip can be used reading in an IP core. All output products of the IP,
		/// including a design checkpoint ( DCP), will be read as needed.
		/// The following example adds an existing DSP module, created in System Generator, into the
		/// current project:
		/// add_files C:/Data/model1.mdl
		/// Note: Use the create_sysgen command to use System Generator to create a new DSP module.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 42
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Filesets or sub-designs or RMs to add the files to
		/// </param>
		/// <param name="fileset">
		/// Optional
		/// Fileset name
		/// </param>
		/// <param name="norecurse">
		/// Optional
		/// Do not recursively search in specified directories
		/// </param>
		/// <param name="copy_to">
		/// Optional
		/// Copy the file to the specified directory before adding it to
		/// project
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite the existing file when -copy_to is used
		/// </param>
		/// <param name="scan_for_includes">
		/// Optional
		/// Scan and add any included files found in the fileset's RTL
		/// sources
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="files">
		/// Optional
		/// Name of the files and/or directories to add. Must be
		/// specified if -scan_for_includes is not used.
		/// </param>
		/// <returns>list of file objects that were added</returns>
		public void add_files(string of_objects, string fileset = null, bool? norecurse = null, string copy_to = null, bool? force = null, bool? scan_for_includes = null, bool? quiet = null, bool? verbose = null, string files = null)
		{
			var command = new SimpleTCLCommand("add_files");
			_tcl.Add(command);
		}
		/// <summary>
		/// Force value of signal, wire, or reg to a specified value
		///
		/// Force the value of a signal, wire, or reg to a certain value during simulation.
		/// The add_force command has the same effect as the Verilog force/release commands in
		/// the test bench or the module definition. It forces an HDL object to hold the specified value for
		/// the specified time, or until released by the -cancel_after option, or the remove_forces
		/// command.
		/// IMPORTANT! If there are Verilog force/release statements on an HDL object in the test bench or
		/// module, these commands are overridden by the Tcl add_force command. When the Tcl force expires or is
		/// released, the HDL object resumes normal operation in the simulation, including the application of any Verilog
		/// forces.
		/// This command returns the name of the force object created, or returns an error if the command
		/// failed. The name of the returned force object is important when using the remove_forces
		/// command, and should be captured in a Tcl variable for later recall, as shown in the examples.
		///
		/// The following example forces the reset signal high at 300 nanoseconds, using the default radix,
		/// and captures the name of the returned force object in a Tcl variable which can be used to later
		/// remove the force:
		/// set for10 [ add_force reset 1 300 ]
		/// The following example shows the use of {<value> <time>} pairs, repeated periodically, and
		/// canceled after a specified time.
		/// add_force mySig {0} {1 50} {0 100} {1 150} -repeat_every 200
		/// -cancel_after 10000
		/// Note: In the preceding example, the first {<value> <time>} pair does not include a time. This indicates that
		/// the specified value, 0, is applied at time 0 (the current_time).
		///
		/// See ug835-vivado-tcl-commands.pdf, page 46
		/// </summary>
		/// <param name="hdl_object">
		/// Required
		/// Specifies the object upon which to add a force
		/// </param>
		/// <param name="values">
		/// Required
		/// Adds a value and time offset to the force: {value
		/// [ time_offset ] }
		/// </param>
		/// <param name="radix">
		/// Optional
		/// Specifies which radix to use. Allowed values are: default,
		/// dec, bin, oct, hex, unsigned, ascii, smag
		/// </param>
		/// <param name="repeat_every">
		/// Optional
		/// Repeat every time duration
		/// </param>
		/// <param name="cancel_after">
		/// Optional
		/// Cancel after time offset
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>The force objects added</returns>
		public void add_force(string hdl_object, string values, string radix = null, string repeat_every = null, string cancel_after = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("add_force");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a VCD checkpoint (equivalent of Verilog $dumpall system task)
		///
		/// The checkpoint_vcd command inserts current HDL object signal values into the Value Change
		/// Dump (VCD) file. Nothing is returned. This Tcl command is the equivalent of the Verilog
		/// $dumpall system task, providing the initial values of the specified signals.
		/// VCD is an ASCII file containing header information, variable definitions, and value change details
		/// of a set of HDL signals. The VCD file can be used to view simulation result in a VCD viewer or to
		/// estimate the power consumption of the design. See the IEEE Standard for Verilog Hardware
		/// Description Language (IEEE Std 1364-2005) for a description of the VCD file format.
		/// You must execute the open_vcd and log_vcd commands before using the checkpoint_vcd
		/// command. After you execute the checkpoint_vcd command, run or rerun the simulation to
		/// capture the signal values.
		///
		/// The following is an example of the checkpoint_vcd command where the command dumps
		/// signal values of specified HDL objects into the open VCD file:
		/// checkpoint_vcd
		///
		/// See ug835-vivado-tcl-commands.pdf, page 129
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void checkpoint_vcd(bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("checkpoint_vcd");
			_tcl.Add(command);
		}
		/// <summary>
		/// Flush SAIF toggle information to the SAIF output file and close the file
		///
		/// Closes the open SAIF file.
		/// Only one SAIF file can be open in the Vivado simulator at one time, using open_saif. You must
		/// close the currently opened SAIF file before opening another file.
		/// This command returns nothing if it is successful, or an error if it fails.
		///
		/// The following is an example:
		/// close_saif
		///
		/// See ug835-vivado-tcl-commands.pdf, page 141
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void close_saif(bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("close_saif");
			_tcl.Add(command);
		}
		/// <summary>
		/// Unload the current simulation without exiting Vivado
		///
		/// Close the current Vivado simulation.
		/// Note: This command does not support third party simulators.
		///
		/// The following example closes the current simulation, forcing the close even if changes would be
		/// lost:
		/// close_sim -force
		///
		/// See ug835-vivado-tcl-commands.pdf, page 143
		/// </summary>
		/// <param name="force">
		/// Optional
		/// Forces the closing of the simulation, even if changes would
		/// be lost. Default behavior is to reject the closing with an error
		/// if changes would be lost.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void close_sim(bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("close_sim");
			_tcl.Add(command);
		}
		/// <summary>
		/// Flush VCD information to the VCD output file and close the file
		///
		/// Closes the open Value Change Dump (VCD) file.
		/// Only one VCD file can be open in the Vivado simulator at one time. You must close the currently
		/// opened VCD file before opening another file.
		///
		/// The following example closes the current VCD object:
		/// close_vcd
		///
		/// See ug835-vivado-tcl-commands.pdf, page 145
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void close_vcd(bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("close_vcd");
			_tcl.Add(command);
		}
		/// <summary>
		/// Compile simulation libraries
		///
		/// Compile Xilinx® simulation libraries for the cells and IP used in the current project, or from a
		/// specified directory for use in multiple design projects.
		/// The Vivado Design Suite provides simulation models as a set of files and libraries that contain the
		/// behavioral and timing models for use by the Vivado simulator. The compile_simlib command
		/// compiles these libraries for use by third-party simulators prior to design simulation. Libraries
		/// must generally be compiled or recompiled with a new software release to update simulation
		/// models and to support a new version of a simulator.
		/// IMPORTANT! You should rerun the compile_simlib command any time a new third party simulator will be
		/// used, or a new Vivado Design Suite version or update is installed.
		/// When this command is run from a current project, the tool will use the device family, target
		/// language, and library settings specified by the project as the default values, rather than the
		/// default settings of the command defined below. The default settings can be overridden by
		/// specifying the necessary options when the command is run.
		/// The compile_simlib command uses simulator compilation directives when compiling the
		/// simulation libraries. You can edit the default configuration settings using the
		/// config_compile_simlib command.
		/// The command returns information related to the compiled libraries, or an error if it fails.
		///
		/// The following example shows how to compile UNISIM and SIMPRIM libraries for ModelSim
		/// (VHDL) for a design using a Virtex-7 device:
		/// compile_simlib -simulator modelsim -family virtex7 -library unisim \
		/// -library simprim -language vhdl
		///
		/// See ug835-vivado-tcl-commands.pdf, page 161
		/// </summary>
		/// <param name="simulator">
		/// Required
		/// Compile libraries for this simulator
		/// </param>
		/// <param name="directory">
		/// Optional
		/// Directory path for saving the compiled results Default: .
		/// </param>
		/// <param name="family">
		/// Optional
		/// Select device architecture Default: all
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite the pre-compiled libraries
		/// </param>
		/// <param name="language">
		/// Optional
		/// Compile libraries for this language Default: all
		/// </param>
		/// <param name="library">
		/// Optional
		/// Select library to compile Default: all
		/// </param>
		/// <param name="print_library_info">
		/// Optional
		/// Print Pre-Compiled library information
		/// </param>
		/// <param name="simulator_exec_path">
		/// Optional
		/// Use simulator executables from this directory
		/// </param>
		/// <param name="source_library_path">
		/// Optional
		/// If specified, this directory will be searched for the library
		/// source files before searching the default path(s) found in
		/// environment variable XILINX_VIVADO for Vivado
		/// </param>
		/// <param name="no_ip_compile">
		/// Optional
		/// Do not compile IP static files from repository
		/// </param>
		/// <param name="32bit">
		/// Optional
		/// Perform the 32-bit compilation
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void compile_simlib(string simulator, string directory = null, string family = null, bool? force = null, string language = null, string library = null, string print_library_info = null, string simulator_exec_path = null, string source_library_path = null, bool? no_ip_compile = null, bool? 32bit = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("compile_simlib");
			_tcl.Add(command);
		}
		/// <summary>
		/// Configure settings for compile_simlib
		///
		/// Configure third party simulator options for use by the compile_simlib command.
		/// The Vivado Design Suite has a pre-defined configuration file for the compile_simlib
		/// command, with compilation options defined for supported third-party simulators, languages, and
		/// libraries. The config_compile_simlib command is provided to let you change the
		/// configuration options for specific combinations of simulator, language, and library.
		/// Use the config_compile_simlib command without any arguments to return all current
		/// configuration options.
		///
		/// The following example configures the compilation options for the Modelsim simulator, Verilog
		/// language, and Unisim library:
		/// config_compile_simlib -cfgopt {modelsim.verilog.unisim: -quiet}
		/// The following example configures the compilation options for multiple simulation libraries:
		/// config_compile_simlib -cfgopt {modelsim.verilog.synopsys: -quiet} \
		/// -cfgopt {modelsim.verilog.simprim:-source +define+XIL_TIMING}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 166
		/// </summary>
		/// <param name="cfgopt">
		/// Optional
		/// Configuration option in form of
		/// simulator.language.library.options
		/// </param>
		/// <param name="simulator">
		/// Optional
		/// Display the configurations for specified simulator
		/// </param>
		/// <param name="reset">
		/// Optional
		/// Reset all configurations
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void config_compile_simlib(string cfgopt = null, string simulator = null, bool? reset = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("config_compile_simlib");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new fileset
		///
		/// Defines a new fileset within a design project. Files can be added to a newly created fileset using
		/// the add_files command.
		/// A fileset is a list of files with a specific function within the project. One or more constraint files is
		/// a constraint set (-constrset); one or more simulation test benches is a simulation set (-
		/// simset). Only one fileset option can be specified when using the create_fileset command.
		/// As a default, the tool will create a constraint fileset if the type is not specified.
		/// You can also use the create_fileset -blockset command to configure an IP core, or
		/// hierarchical module of the design, as an out-of-context (OOC) block. The block fileset, or
		/// blockset, creates a hierarchical file collection for the IP or module specified with the -
		/// define_from option. The files related to the specified hierarchical module will be moved from
		/// their current fileset to the new blockset. When the blockset is created, the Vivado Design Suite
		/// also defines out-of-context synthesis and implementation runs for the block. The output
		/// products for the OOC module are stored in the blockset, including the synthesized design
		/// checkpoint (DCP) and any required structural simulation netlists. Stuctural simulation netlists are
		/// needed when a behavioral model for the block is not available, or is not available in the language
		/// supported by the target simulator. You can define an out-of-context constraint file for the IP or
		/// moduleif needed, and add the at to the block fileset as well.
		/// TIP: Refer to the Vivado Design Suite User Guide: Designing with IP (UG896) or the Vivado Design Suite User
		/// Guide: Hierarchical Design (UG905) for more information on out-of-context design.
		/// The create_fileset command returns the name of the newly created fileset, or will return an
		/// error message if it fails.
		///
		/// The following example creates a new constraint file set named constraints2:
		/// create_fileset -constrset -quiet constraints2
		/// Note: With -quiet specified, the tool will not return anything if it encounters an error in trying to create
		/// the specified fileset.
		/// The following example creates an out-of-context (OOC) blockset for the hierarchical module
		/// specified by the -define_from option:
		/// create_fileset -blockset -define_from dac_spi dac_spi
		/// The following example creates a new simulation fileset named sim_1:
		/// create_fileset -simset sim_1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 264
		/// </summary>
		/// <param name="define_from">
		/// Required
		/// Name of the module in the source fileset to be the top of
		/// the blockset
		/// </param>
		/// <param name="name">
		/// Required
		/// Name of the fileset to be create
		/// </param>
		/// <param name="constrset">
		/// Optional
		/// Create fileset as constraints fileset (default)
		/// </param>
		/// <param name="simset">
		/// Optional
		/// Create fileset as simulation source fileset
		/// </param>
		/// <param name="blockset">
		/// Optional
		/// Create fileset as block source fileset
		/// </param>
		/// <param name="clone_properties">
		/// Optional
		/// Fileset to initialize properties from
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>new fileset object</returns>
		public void create_fileset(string define_from, string name, bool? constrset = null, bool? simset = null, bool? blockset = null, string clone_properties = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("create_fileset");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get index of the selected subprogram frame (default, top i.e. most recent subprogram call) in the
		/// call-stack of the HDL process scope (current_scope). Sets current stack frame for the subprogram
		/// call-stack of the current_scope.
		///
		/// Returns the index of the frame which is selected as the "current" frame in sub-program call-stack
		/// of the current HDL process-scope, or current_scope. By default, the most recently called
		/// subprogram-frame is the current frame, i.e. with frame-index "0" (zero) and marked with (->).
		/// Switches like -up,-down, and -set let you select other frames in the call-stack, rather than the
		/// current frame.
		/// IMPORTANT! The current_frame strictly follows the current_scope. If current_scope is not an
		/// HDL process scope waiting inside a sub-program, the current_frame command reports that the current
		/// process does not have an associated sub-program stack.
		///
		/// Example design:
		/// module top;
		/// int i;
		/// function void f(input int in1);
		/// automatic int a;
		/// a = in1 + 7;
		/// $display($time, " in f :: a %d in1 %d ", a, in1);
		/// endfunction
		/// task automatic t(input int in2);
		/// int b;
		/// b = in2 + 10;
		/// $display($time, " in t :: in2 %d b %d ", in2, b);
		/// #5;
		/// f(b); // Case C
		/// $display($time, " Back in t : after wait and f(%d) ", b);
		/// endtask
		/// initial begin // "/top/Initial18_0"
		/// $display($time, " in initial 1 ");
		/// i = 200;
		/// t(i); // Case B
		/// $display($time, " Back in initial 1 after t(%d) ", i);
		/// end
		/// initial begin // "/top/Initial25_1"
		/// $display($time, " in initial 2 ");
		/// #2;
		/// f(50); // Case A
		/// $display($time, " Back in initial 2 after f(50) ");
		/// end
		/// endmodule
		/// When simulation is stopped inside function "f" for its call at 'Case C', function "f" is called from
		/// task "t" at 'Case C' which itself is called from process "/top/Initial18_0" at 'Case B'
		/// > current_scope
		/// /top/Initial18_0
		/// > report_frames
		/// -> 0 : f
		/// 1 : t
		/// 2: /top/Initial18_0
		/// 1. > current_frame
		/// 0
		/// 2. > current_frame -up
		/// 1
		/// > report_frames
		/// 0 : f
		/// -> 1 : t
		/// 2 : /top/Initial18_0
		/// 3. > current_frame -down
		/// 0
		/// > report_frames
		/// -> 0 : f
		/// 1 : t
		/// 2: /top/Initial18_0
		/// 4. > current_frame -set 1
		/// 1
		/// > report_frames
		/// 0 : f
		/// -> 1 : t
		/// 2 : /top/Initial18_0
		/// 5. > current_frame -verbose
		/// -> 0 : f @top.v:6
		/// 1 : t @top.v:15
		/// 2: /top/Initial18_0 @top.v:21
		///
		/// See ug835-vivado-tcl-commands.pdf, page 379
		/// </summary>
		/// <param name="up">
		/// Optional
		/// Selects stack frame of the caller subprogram/process as the
		/// current frame.
		/// </param>
		/// <param name="down">
		/// Optional
		/// Selects stack frame of the callee subprogram as the current
		/// frame.
		/// </param>
		/// <param name="set">
		/// Optional
		/// Selects stack frame with given index as the current frame of
		/// the call stack of current HDL process scope. Default: 0
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>Returns index of the selected subprogram frame in the call stack of the current_scope.</returns>
		public void current_frame(bool? up = null, bool? down = null, string set = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("current_frame");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the current scope or set the current scope
		///
		/// Return the current scope in the current simulation, or set the current scope to the specified HDL
		/// scope.
		/// The current_scope command returns the name of the current simulation scope.
		/// If <hdl_scope> is supplied then, the current scope is set to the specified scope.
		///
		/// The following example sets the current scope to the specified HDL scope:
		/// current_scope /testbench/dut
		/// This example returns the current scope name to console:
		/// current_scope
		///
		/// See ug835-vivado-tcl-commands.pdf, page 405
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="hdl_scope">
		/// Optional
		/// Default: NULL
		/// </param>
		/// <returns>The current scope</returns>
		public void current_scope(bool? quiet = null, bool? verbose = null, string hdl_scope = null)
		{
			var command = new SimpleTCLCommand("current_scope");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set the current simulation object or get the current simulation object
		///
		/// Get or set the current Vivado simulation object.
		/// This command can be used after the Vivado simulator has been launched to return or set the
		/// current simulation object.
		///
		/// The following example sets the curent simulation:
		/// current_sim simulation_2
		///
		/// See ug835-vivado-tcl-commands.pdf, page 407
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="simulationObject">
		/// Optional
		/// Simulation Object to set the current simulation object to
		/// Default: NULL
		/// </param>
		/// <returns>Returns the current simulation object</returns>
		public void current_sim(bool? quiet = null, bool? verbose = null, string simulationObject = null)
		{
			var command = new SimpleTCLCommand("current_sim");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report current simulation time
		///
		/// Returns the current simulation time to the Tcl Console or Vivado Design Suite Tcl shell.
		///
		/// The following example returns the current time of the current simulation:
		/// current_time
		///
		/// See ug835-vivado-tcl-commands.pdf, page 409
		/// </summary>
		/// <param name="s">
		/// Optional
		/// Short -- suppress the space between numeric part and unit
		/// part
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>Prints the current simulation time on the console in textual format</returns>
		public void current_time(bool? s = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("current_time");
			_tcl.Add(command);
		}
		/// <summary>
		/// Return the current VCD object or make VCDObject the current VCD object
		///
		/// Defines the current Value Change Dump (VCD) object, or returns the name of the current VCD
		/// object in the current simulation.
		/// A VCD file must be opened and assigned to a VCD object using the open_vcd command in
		/// order for there to be a current VCD object.
		/// This command returns the current VCD object.
		///
		/// The following example sets the specified VCD object as current:
		/// current_vcd vcd2
		///
		/// See ug835-vivado-tcl-commands.pdf, page 411
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="VCDObject">
		/// Optional
		/// VCDObject Default: NULL
		/// </param>
		public void current_vcd(bool? quiet = null, bool? verbose = null, string VCDObject = null)
		{
			var command = new SimpleTCLCommand("current_vcd");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete a fileset
		///
		/// Deletes the specified fileset. However, if the fileset cannot be deleted, then no message is
		/// returned.
		///
		/// The following example deletes the sim_2 fileset from the current project.
		/// delete_fileset sim_2
		/// Note: The fileset and all of its files are removed from the project. The files are not removed from the hard
		/// drive.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 432
		/// </summary>
		/// <param name="fileset">
		/// Required
		/// Fileset to be deleted
		/// </param>
		/// <param name="merge">
		/// Optional
		/// Fileset to merge files from the deleted fileset into
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void delete_fileset(string fileset, string merge = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("delete_fileset");
			_tcl.Add(command);
		}
		/// <summary>
		/// Describe an HDL object (variable, signal, wire, or reg) by printing type and declaration
		/// information
		///
		/// Describe an HDL object (variable, signal, wire, or reg) by printing type and declaration
		/// information, as well as path, and file information for the HDL source of the specified objects.
		/// TIP: The describe command works for a single HDL object. Use the report_objects command for a
		/// brief report on multiple HDL objects.
		/// HDL objects include HDL signals, variables, or constants as defined in the Verilog or VHDL test
		/// bench and source files. An HDL signal includes Verilog wire or reg entities, and VHDL signals.
		/// Examples of HDL variables include Verilog real, realtime, time, and event. HDL constants include
		/// Verilog parameters and localparams, and VHDL generic and constants.
		/// The command returns the description of specified HDL objects, or returns an error if it fails.
		///
		/// Verilog parameters and localparams, and VHDL generic and constants.
		/// The command returns the description of specified HDL objects, or returns an error if it fails.
		/// Arguments
		/// -quiet - (Optional) Execute the command quietly, returning no messages from the command.
		/// The command also returns TCL_OK regardless of any errors encountered during execution.
		/// Note: Any errors encountered on the command-line, while launching the command, will be returned. Only
		/// errors occurring inside the command will be trapped.
		/// -verbose - (Optional) Temporarily override any message limits and return all messages from this
		/// command.
		/// Note: Message limits can be defined with the set_msg_config command.
		/// <hdl_object> - (Required) Specifies a single HDL object to describe.
		/// Note: Objects can be specified by name, or returned as objects by the get_objects command.
		/// Examples
		/// The following example shows how the objects description depends on the scope of the current
		/// simulation:
		/// current_scope testbench
		/// /testbench
		/// describe leds_n
		/// Signal: {leds_n[3:0]}
		/// Path: {/testbench/leds_n}
		/// Location: {File "C:/Data/ug937/sim/testbench.v" Line 9}
		/// current_scope dut
		/// /testbench/dut
		/// describe leds_n
		/// Port(OUT): {LEDS_n[3:0]}
		/// Path: {/testbench/dut/LEDS_n}
		/// Location: {File "C:/Data/sources/sinegen_demo.vhd" Line 42}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 474
		/// </summary>
		/// <param name="hdl_object">
		/// Required
		/// The hdl_object or hdl_scope to describe
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>The description of the selected objects</returns>
		public void describe(string hdl_object, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("describe");
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
		/// Flush VCD simulation output to the VCD output file (equivalent of $dumpflush verilog system
		/// task)
		///
		/// Flush HDL signal information currently in memory into the specified Value Change Dump (VCD)
		/// file.
		/// VCD is an ASCII file containing header information, variable definitions, and the value change
		/// details of a set of HDL signals. The VCD file can be used to view simulation results in a VCD
		/// viewer, or to estimate the power consumption of the design.
		/// Note: You must run the open_vcd command to open a VCD file to write to before using the flush_vcd
		/// command.
		///
		/// The following example flushes the VCD buffer into the current VCD file:
		/// flush_vcd
		///
		/// See ug835-vivado-tcl-commands.pdf, page 526
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void flush_vcd(bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("flush_vcd");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write all the simulation .mem files.
		///
		/// For embedded processor based designs, with associated Executable Linkable Files (ELF) from the
		/// Software Development Kit (SDK), this command merges the Block Memory Map (BMM) for the
		/// design with the program data in the ELF file to generate memory (MEM) files for use during
		/// simulation.
		/// The MEM file is a text file that describes how individual Block RAMs on the Xilinx device are
		/// grouped together to form a contiguous address space called an Address Block, with the ELF data
		/// mapped into the memory.
		/// The file names and the number of MEM files generated is determined by the memory map data
		/// specified by the processor system IP cores, or IP integrator block designs.
		/// This command returns the directory where the MEM files are written, or returns an error if it
		/// fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 529
		/// </summary>
		/// <param name="directory">
		/// Required
		/// Directory for exporting .mem files. Values: A directory with
		/// alphanumeric characters.
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite existing .mem files
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>The name of the directory</returns>
		public void generate_mem_files(string directory, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("generate_mem_files");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of HDL objects in one or more HDL scopes as per the specified pattern
		///
		/// Returns a list of HDL objects matching the specified search pattern in one or more HDL scopes.
		/// HDL objects include HDL signals, variables, or constants as defined in the Verilog or VHDL test
		/// bench and source files. An HDL signal includes Verilog wire or reg entities, and VHDL signals.
		/// Examples of HDL variables include Verilog real, realtime, time, and event. HDL constants include
		/// Verilog parameters and localparams, and VHDL generic and constants.
		/// The HDL scope, or scope, is defined by a declarative region in the HDL code such as a module,
		/// function, task, process, or begin-end blocks in Verilog. VHDL scopes include entity/architecture
		/// definitions, block, function, procedure, and process blocks.
		///
		/// Verilog parameters and localparams, and VHDL generic and constants.
		/// The HDL scope, or scope, is defined by a declarative region in the HDL code such as a module,
		/// function, task, process, or begin-end blocks in Verilog. VHDL scopes include entity/architecture
		/// definitions, block, function, procedure, and process blocks.
		/// Arguments
		/// -recursive | -r - (Optional) Apply the command to the current scope, and all sub-scopes of
		/// the current scope.
		/// -regexp - (Optional) Specifies that the search <patterns> are written as regular expressions.
		/// Both search <patterns> and -filter expressions must be written as regular expressions when
		/// this argument is used. Xilinx regular expression Tcl commands are always anchored to the start of
		/// the search string. You can add ".*" to the beginning or end of a search string to widen the search
		/// to include a substring. See http://perldoc.perl.org/perlre.html for help with regular expression
		/// syntax.
		/// Note: The Tcl built-in command regexp is not anchored, and works as a standard Tcl command. For more
		/// information refer to http://www.tcl.tk/man/tcl8.5/TclCmd/regexp.htm.
		/// -nocase - (Optional) Perform case-insensitive matching when a pattern has been specified. This
		/// argument applies to the use of -regexp only.
		/// -filter <args> - (Optional) Filter the results list with the specified expression. The -filter
		/// argument filters the list of objects returned by get_objects based on property values on the
		/// objects. You can find the properties on an object with the report_property or
		/// list_property commands. In the case of the HDL object, "NAME", "SCOPE" and "TYPE" are
		/// some of the properties that can be used to filter results.
		/// The filter search pattern should be quoted to avoid having to escape special characters that may
		/// be found in net, pin, or cell names, or other properties. String matching is case-sensitive and is
		/// always anchored to the start and to the end of the search string. The wildcard “*” character can
		/// be used at the beginning or at the end of a search string to widen the search to include a
		/// substring of the property value.
		/// Note: The filter returns an object if a specified property exists on the object, and the specified pattern
		/// matches the property value on the object. In the case of the "*" wildcard character, this will match a
		/// property with a defined value of "".
		/// For string comparison, the specific operators that can be used in filter expressions are "equal"
		/// (==), "not-equal" (!=), "match" (=~), and "not-match" (!~). Numeric comparison operators <, >, <=,
		/// and >= can also be used. Multiple filter expressions can be joined by AND and OR (&& and ||).
		/// The following gets input pins that do NOT contain the “RESET” substring within their name:
		/// get_pins * -filter {DIRECTION == IN && NAME !~ "*RESET*"}
		/// Boolean (bool) type properties can be directly evaluated in filter expressions as true or not true:
		/// -filter {IS_PRIMITIVE && !IS_LOC_FIXED}
		/// -quiet - (Optional) Execute the command quietly, returning no messages from the command.
		/// The command also returns TCL_OK regardless of any errors encountered during execution.
		/// Note: Any errors encountered on the command-line, while launching the command, will be returned. Only
		/// errors occurring inside the command will be trapped.
		/// -verbose - (Optional) Temporarily override any message limits and return all messages from this
		/// command.
		/// Note: Message limits can be defined with the set_msg_config command.
		/// <patterns> - (Optional) Match HDL objects against the specified patterns. The default pattern is
		/// the wildcard '*' which returns all the children in the current scope. The search pattern can be
		/// defined in two ways:
		/// • <patterns> - Specifies only the search pattern for the objects to get. This method returns all
		/// objects in the current scope (and any sub-scopes when -recursive is used).
		/// • <scope>/<pattern> - Specifies the scope of interest, relative to the current scope, and the
		/// pattern for objects to locate. In this case, the specified <scope>, and any sub-scopes of it if -
		/// recursive is used, are identified starting from the current scope. Then all objects matching
		/// the search <pattern> are identified and returned.
		/// Examples
		/// The following example specifies the current_scope, then gets all HDL objects in that scope:
		/// current_scope ./cpuEngine
		/// get_objects
		/// The following example returns the count of all objects in the current scope, and then returns the
		/// count of all objects in the current scope, and all sub-scopes of it:
		/// llength [get_objects]
		/// 182
		/// llength [get_objects -recursive ]
		/// 2182
		/// The following example specifies the <scope>/<pattern> search pattern as discussed above.
		/// Notice that the cpuEngine scope and various sub-scopes of it are identified, then objects
		/// matching the cl* pattern in those scopes are returned:
		/// get_objects -recursive -filter {type == internal_signal} cpuEngine/cl*
		/// /top/cpuEngine/clk_i
		/// /top/cpuEngine/iwb_biu/clk
		/// /top/cpuEngine/iwb_biu/clmode
		/// /top/cpuEngine/or1200_cpu/clk
		/// ...
		/// /top/cpuEngine/or1200_immu_top/or1200_immu_tlb/itlb_mr_ram/clk
		/// Search the current scope, and all sub-scopes, for any internal signals whose names start with cl
		/// or ma:
		/// get_objects -recursive -filter {type == internal_signal} ma* cl*
		///
		/// See ug835-vivado-tcl-commands.pdf, page 831
		/// </summary>
		/// <param name="filter">
		/// Optional
		/// filters <patterns> according to the specified property￾matching expressions
		/// </param>
		/// <param name="r">
		/// Optional
		/// Searches recursively for objects
		/// </param>
		/// <param name="local">
		/// Optional
		/// Searches objects in the subprogram frame selected for the
		/// current scope
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Search using regular expressions, search design objects
		/// from which to create wave objects by design object name.
		/// The application supplying the design objects determines
		/// how the match is to be performed. Items must be strings.
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// Perform a case insensitive match (only used with regexp)
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
		/// Patterns to search for. Default is * where all HDL objects are
		/// returned
		/// </param>
		/// <returns>Returns all the objects found given the specified pattern</returns>
		public void get_objects(string filter = null, bool? r = null, bool? local = null, bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_objects");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of children HDL scopes of a scope
		///
		/// Get a list of children HDL scopes of the current or specified scope
		/// This command returns a list of scope objects, or returns an error.
		///
		/// The following example recursively returns all of the children scopes of the specified scope:
		/// get_scopes -r /testbench/dut
		///
		/// See ug835-vivado-tcl-commands.pdf, page 894
		/// </summary>
		/// <param name="filter">
		/// Optional
		/// filters <patterns> according to the specified property￾matching expressions
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// interprets <patterns> using regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// only when regexp is used, performs a case insensitive
		/// match
		/// </param>
		/// <param name="r">
		/// Optional
		/// only when a glob or regular expression pattern is used,
		/// descends recursively into children scopes to search for
		/// <patterns>
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
		/// the pattern strings to search for scopes. Default: * (all
		/// children scopes)
		/// </param>
		/// <returns>Returns HDL scope objects from the given arguments</returns>
		public void get_scopes(string filter = null, bool? regexp = null, bool? nocase = null, bool? r = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_scopes");
			_tcl.Add(command);
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
		/// Get list of processes in a design, which are waiting inside a subprogram
		///
		/// Returns list of HDL scopes for all the processes in a design which are waiting inside a
		/// subprogram. With -of_instance switch, the output can be limited to such processes of the
		/// given instance only.
		///
		/// The following example gets a list of all sites available on the target device:
		/// module top;
		/// int i;
		/// function void f(input int in1);
		/// automatic int a;
		/// a = in1 + 7;
		/// $display($time, " in f :: a %d in1 %d ", a, in1);
		/// endfunction
		/// task automatic t(input int in2);
		/// int b;
		/// b = in2 + 10;
		/// $display($time, " in t :: in2 %d b %d ", in2, b);
		/// #5;
		/// f(b); // Case C
		/// $display($time, " Back in t : after wait and f(%d) ", b);
		/// endtask
		/// initial begin // "/top/Initial18_0"
		/// $display($time, " in initial 1 ");
		/// i = 200;
		/// t(i); // Case B
		/// $display($time, " Back in initial 1 after t(%d) ", i);
		/// end
		/// initial begin // "/top/Initial25_1"
		/// $display($time, " in initial 2 ");
		/// #2;
		/// f(50); // Case A
		/// $display($time, " Back in initial 2 after f(50) ");
		/// end
		/// endmodule
		/// When simulation is stopped inside function "f" for its call at 'Case A' , the two processes /top/
		/// Initial18_0, and /top/Initial25_1, are waiting inside task "t" (call at 'CaseB') and
		/// function "f" (call at 'CaseA') respectively.
		/// 1. > get_stacks
		/// /top/Initial18_0 /top/Initial25_1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 919
		/// </summary>
		/// <param name="of_instance">
		/// Optional
		/// Default: NULL
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>
		/// </returns>
		public void get_stacks(string of_instance = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("get_stacks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get current value of the selected HDL object (variable, signal, wire, reg)
		///
		/// Get the value of a single HDL object at the current simulation run time.
		/// TIP: Use the report_values command to return the values of more than one HDL objects.
		/// HDL objects include HDL signals, variables, or constants as defined in the Verilog or VHDL test
		/// bench and source files. An HDL signal includes Verilog wire or reg entities, and VHDL signals.
		/// Examples of HDL variables include Verilog real, realtime, time, and event.
		/// HDL constants include Verilog parameters and localparams, and VHDL generic and constants.
		/// The HDL scope, or scope, is defined by a declarative region in the HDL code such as a module,
		/// function, task, process, or begin-end blocks in Verilog. VHDL scopes include entity/architecture
		/// definitions, block, function, procedure, and process blocks.
		///
		/// HDL constants include Verilog parameters and localparams, and VHDL generic and constants.
		/// The HDL scope, or scope, is defined by a declarative region in the HDL code such as a module,
		/// function, task, process, or begin-end blocks in Verilog. VHDL scopes include entity/architecture
		/// definitions, block, function, procedure, and process blocks.
		/// Arguments
		/// -radix <arg> - (Optional) Specifies the radix to use when returning the value of the specified
		/// object. Allowed values are: default, dec, bin, oct, hex, unsigned, ascii, or smag.
		/// Note: The radix dec indicates a signed decimal. Specify the radix unsigned when dealing with unsigned
		/// data.
		/// -quiet - (Optional) Execute the command quietly, returning no messages from the command.
		/// The command also returns TCL_OK regardless of any errors encountered during execution.
		/// Note: Any errors encountered on the command-line, while launching the command, will be returned. Only
		/// errors occurring inside the command will be trapped.
		/// -verbose - (Optional) Temporarily override any message limits and return all messages from this
		/// command.
		/// Note: Message limits can be defined with the set_msg_config command.
		/// <hdl_object> - (Required) Specifies a single HDL object to get the value of. The object can be
		/// specified by name, or can be returned as an object from the get_objects command.
		/// Examples
		/// The following example gets the value of the sysClk signal:
		/// get_value sysClk
		/// Z
		/// This example shows the difference between the bin, dec, and unsigned radix on the value
		/// returned from the specified bus:
		/// get_value -radix bin /test/bench_VStatus_pad_0_i[7:0]
		/// 10100101
		/// get_value -radix unsigned /test/bench_VStatus_pad_0_i[7:0]
		/// 165
		/// get_value -radix dec /test/bench_VStatus_pad_0_i[7:0]
		/// -91
		///
		/// See ug835-vivado-tcl-commands.pdf, page 934
		/// </summary>
		/// <param name="hdl_object">
		/// Required
		/// The hdl_object to retrieve the current value
		/// </param>
		/// <param name="radix">
		/// Optional
		/// radix specifies the radix to use for printing the values of the
		/// hdl_objects. Allowed values are: default, dec, bin, oct,hex,
		/// unsigned, ascii, smag
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>Returns a string representation of value of a hdl_object</returns>
		public void get_value(string hdl_object, string radix = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("get_value");
			_tcl.Add(command);
		}
		/// <summary>
		/// Import files and/or directories into the active fileset
		///
		/// Imports one or more files or the source file contents of one or more directories to the specified
		/// fileset.
		/// For every file added to a project the Vivado Design Suite attempts to store and maintain both a
		/// relative path and an absolute path to the file or directory. When a project is opened, these paths
		/// are used to locate the files and directories. By default the Vivado Design Suite applies a Relative
		/// First approach to resolving paths, searching the relative path first, then the absolute path. You
		/// can use the PATH_MODE property to change how the Vivado tool resolves file paths or
		/// properties for specific objects. For more information, see the Vivado Design Suite Properties
		/// Reference Guide (UG912).
		/// IMPORTANT! Importing multiple files one at a time can cause noticeable performance degradation. It is more
		/// efficient to use a single import_files command to import a list of files:
		/// import_files {file1 file2 file3 ... fileN}
		/// This command is different from the add_files command, which adds files by reference into the
		/// specified fileset. This command imports the files into the local project folders under
		/// project.srcs\<fileset>\imports and then adds the file to the specified fileset.
		///
		/// The following example imports the top.ucf file into the constrs_1 constraint fileset.
		/// import_files -fileset constrs_1 top.ucf
		/// The following example imports the valid source files into the source fileset (sources_1) as a
		/// default since the -fileset argument is not specified. In addition, the -norecurse argument
		/// restricts the tool to looking only in the specified \level1 directory and not searching any
		/// subdirectories. All valid source files will be imported into the \imports folder of the project
		/// because the -flat argument has been specified.
		/// import_files C:/Data/FPGA_Design/level1 -norecurse -flat
		/// Note: Without the -flat option a \level1 directory would be created inside of the \imports folder of
		/// the project.
		/// The following example imports files into the source fileset (sources_1) because the -fileset
		/// argument is not specified. Valid source files are imported from the \level1 directory, and all
		/// subdirectories, and the files will be written into the \imports folder of the project starting at
		/// the \Data directory due to the use of the -relative_to argument.
		/// import_files C:/Data/FPGA_Design/level1 -relative_to C:/Data
		///
		/// See ug835-vivado-tcl-commands.pdf, page 962
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// RMs to import the files to
		/// </param>
		/// <param name="fileset">
		/// Optional
		/// Fileset name
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite files of the same name in project directory
		/// </param>
		/// <param name="norecurse">
		/// Optional
		/// Disables the default behavior of recursive directory searches
		/// </param>
		/// <param name="flat">
		/// Optional
		/// Import the files into a flat directory structure
		/// </param>
		/// <param name="relative_to">
		/// Optional
		/// Import the files with respect to the given relative directory
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="files">
		/// Optional
		/// Name of the files to import into fileset
		/// </param>
		/// <returns>A list of file objects that were imported</returns>
		public void import_files(string of_objects, string fileset = null, bool? force = null, bool? norecurse = null, bool? flat = null, string relative_to = null, bool? quiet = null, bool? verbose = null, string files = null)
		{
			var command = new SimpleTCLCommand("import_files");
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
		/// <summary>
		/// Limit the maximum size of the VCD file on disk (equivalent of $dumplimit verilog task)
		///
		/// Specify the size limit, in bytes, of the Value Change Dump (VCD) file. This command operates like
		/// the Verilog $dumplimit simulator directive.
		/// When the specified file size limit has been reached, the dump process stops, and a comment is
		/// inserted into the VCD file to indicate that the file size limit has been reached.
		/// Note: You must run the open_vcd command before using the limit_vcd command.
		///
		/// The following example limits the current VCD file:
		/// limit_vcd 1000
		///
		/// See ug835-vivado-tcl-commands.pdf, page 999
		/// </summary>
		/// <param name="filesize">
		/// Required
		/// Specify the maximum size of the VCD file in bytes.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void limit_vcd(string filesize, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("limit_vcd");
			_tcl.Add(command);
		}
		/// <summary>
		/// Log Switching Activity Interchange Format (SAIF) toggle for specified wire, signal, or reg
		///
		/// Writes the switching activity rates for the specified HDL signals during the current simulation.
		/// The Switching Activity Interchange format (SAIF) file is an ASCII file containing header
		/// information, and toggle counts for the specified signals of the design. It also contains the timing
		/// attributes which specify time durations for signals at level 0, 1, X, or Z.
		/// The log_saif command can only be used after the open_saif command has opened an SAIF
		/// file in the current simulation to capture switching activity rates.
		///
		/// The following example logs switching activity for all signals in the current_scope:
		/// log_saif [ get_objects ]
		/// Log SAIF for only the internal signals starting with name c of the scope /tb/UUT:
		/// log_saif [get_objects -filter { type == internal_signal }/tb/UUT/c*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1022
		/// </summary>
		/// <param name="hdl_objects">
		/// Required
		/// The hdl_objects to log
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>Does not return any object</returns>
		public void log_saif(string hdl_objects, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("log_saif");
			_tcl.Add(command);
		}
		/// <summary>
		/// Log Value Change Dump (VCD) simulation output for specified wire, signal, or reg
		///
		/// Indicates which HDL objects to write into the Value Change Dump (VCD) file. In some designs
		/// the simulation results can become quite large; the log_vcd command lets you define the
		/// specific content of interest. This command models the behavior of the Verilog $dumpvars
		/// system task.
		/// HDL objects include HDL signals, variables, or constants as defined in the Verilog or VHDL test
		/// bench and source files. An HDL signal includes Verilog wire or reg entities, and VHDL signals.
		/// Examples of HDL variables include Verilog real, realtime, time, and event.
		/// This command specifies which HDL objects and how many levels of design hierarchy to write
		/// into the VCD file. The actual values of the objects are written to the VCD file when you run the
		/// checkpoint_vcd or flush_vcd commands at a specific time during simulation.
		/// IMPORTANT! You must use the open_vcd command before using any other *_vcd commands.
		/// Nothing is returned by this command.
		///
		/// This command specifies which HDL objects and how many levels of design hierarchy to write
		/// into the VCD file. The actual values of the objects are written to the VCD file when you run the
		/// checkpoint_vcd or flush_vcd commands at a specific time during simulation.
		/// IMPORTANT! You must use the open_vcd command before using any other *_vcd commands.
		/// Nothing is returned by this command.
		/// Arguments
		/// -level <arg> - (Optional) Specifies the number of levels of design hierarchy to traverse when
		/// locating HDL objects to write to the VCD file. The default value of 0 causes the tool to dump all
		/// values for the specified HDL objects at the level of hierarchy defined by <hdl_objects>, and all
		/// levels below that. A value of 1 indicates that only the level of hierarchy specified by
		/// <hdl_objects> should be written to the VCD file.
		/// -quiet - (Optional) Execute the command quietly, returning no messages from the command.
		/// The command also returns TCL_OK regardless of any errors encountered during execution.
		/// Note: Any errors encountered on the command-line, while launching the command, will be returned. Only
		/// errors occurring inside the command will be trapped.
		/// -verbose - (Optional) Temporarily override any message limits and return all messages from this
		/// command.
		/// Note: Message limits can be defined with the set_msg_config command.
		/// <hdl_objects> - (Optional) Specifies the HDL objects to identify and write changing values into
		/// the VCD file. The level of hierarchy is also represented in the hdl_objects pattern. For
		/// instance /tb/UUT/* indicates all HDL objects within the /tb/UUT level of the design.
		/// Examples
		/// Log value changes for all the ports from the scope /tb/UUT:
		/// log_vcd [get_objects -filter { type == port } /tb/UUT/* ]
		/// Note: Since -levels is not specified, all levels below the specified scope will be searched for ports
		/// matching the specified pattern as well.
		/// Log VCD for all the objects in the current_scope:
		/// log_vcd *
		/// log_vcd [ get_objects *]
		/// Log value changes for only internal signals with names starting with C, of the root scope /tb/
		/// UUT:
		/// log_vcd [get_objects -filter { type == internal_signal }./C*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1024
		/// </summary>
		/// <param name="level">
		/// Optional
		/// Number of levels to log (for HDL scopes) Default: 0
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="hdl_objects">
		/// Optional
		/// Which HDL objects to log
		/// </param>
		/// <returns>Does not return any object</returns>
		public void log_vcd(string level = null, bool? quiet = null, bool? verbose = null, string hdl_objects = null)
		{
			var command = new SimpleTCLCommand("log_vcd");
			_tcl.Add(command);
		}
		/// <summary>
		/// Log simulation output for specified wire, signal, or reg for viewing using Vivado Simulators
		/// waveform viewer. Unlike add_wave, this command does not add the waveform object to
		/// waveform viewer (i.e. Waveform Configuration). It simply enables logging of output to the Vivado
		/// Simulators Waveform Database (WDB).
		///
		/// Log simulation activity for the specified HDL objects into the waveform database file (.wdb) for
		/// viewing using Vivado simulator waveform viewer.
		/// In the Vivado simulator, an HDL object is an entity that can hold a value, such as a wire, signal, or
		/// register.
		/// Unlike add_wave, this command does not add the waveform object to waveform configuration.
		/// It simply enables logging of waveform activity to the Vivado simulator waveform database
		/// (WDB). See the Vivado Design Suite User Guide: Logic Simulation (UG900) for more information.
		/// This command returns nothing.
		///
		/// The following example logs the waveform activities for the specified HDL objects.
		/// log_wave -r [get_objects /testbench/dut/*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1026
		/// </summary>
		/// <param name="hdl_objects">
		/// Required
		/// Which hdl_objects to trace
		/// </param>
		/// <param name="recursive">
		/// Optional
		/// Searches recursively for objects
		/// </param>
		/// <param name="r">
		/// Optional
		/// Searches recursively for objects
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Displays all warnings
		/// </param>
		/// <param name="v">
		/// Optional
		/// Displays all warnings
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		public void log_wave(string hdl_objects, bool? recursive = null, bool? r = null, bool? verbose = null, bool? v = null, bool? quiet = null)
		{
			var command = new SimpleTCLCommand("log_wave");
			_tcl.Add(command);
		}
		/// <summary>
		/// Turns on or off printing of file name and line number of the hdl statement being simulated
		///
		/// Enables line-level tracing for simulation debugging purposes.
		/// During simulation the simulation source file and line number being evaluated is returned to the
		/// Tcl console.
		/// TIP: Process tracing with the ptrace command provides more detailed information than is available with line
		/// tracing.
		/// This feature can also be enabled using the LINE_TRACING property on the current simulation
		/// object:
		/// set_property LINE_TRACING on [current_sim]
		/// The command returns the state of line tracing, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1028
		/// </summary>
		/// <param name="value">
		/// Required
		/// value: on, true, yes. Otherwise set to off, false, no
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void ltrace(string value, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("ltrace");
			_tcl.Add(command);
		}
		/// <summary>
		/// Moves the files from one fileset to another while maintaining all of their original properties.
		///
		/// Moves files returned by the get_files command from one fileset to another while maintaining
		/// the properties on the files.
		/// This command returns the list of files that were moved, or an error if the command fails.
		///
		/// The following example moves the file, top_full.xdc, to the constrs_2 fileset.
		/// move_files -fileset constrs_2 [get_files top_full.xdc]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1047
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Reconfig Modules to move the files to
		/// </param>
		/// <param name="fileset">
		/// Optional
		/// Destination fileset name
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="files">
		/// Optional
		/// Name of the files to be moved
		/// </param>
		/// <returns>list of files that were moved</returns>
		public void move_files(string of_objects, string fileset = null, bool? quiet = null, bool? verbose = null, string files = null)
		{
			var command = new SimpleTCLCommand("move_files");
			_tcl.Add(command);
		}
		/// <summary>
		/// Open file for storing signal switching rate for power estimation. The switching rate is written out
		/// in Switching Activity Interchange Format (SAIF) Only one SAIF is allowed to be open per
		/// simulation run.
		///
		/// Create or open a Switching Activity Interchange Format (SAIF) file for storing signal switching
		/// rates in the current simulation for later use by the report_power command.
		/// The Switching Activity Interchange format (SAIF) file is an ASCII file containing header
		/// information, and toggle counts for the specified signals of the design. It also contains the timing
		/// attributes which specify time durations for signals at level 0, 1, X, or Z.
		/// The SAIF file is recommended for power analysis since it is smaller than the VCD file.
		/// When an SAIF file has been opened, you can write the switching activity from the simulation into
		/// the SAIF file using log_saif.
		/// Only one SAIF can be open at one time during simulation. To close the SAIF file, use the
		/// close_saif command.
		/// This command returns the object ID of the opened SAIF file, or returns an error if the command
		/// failed.
		///
		/// The following example opens the specified simulation:
		/// open_saif myData.saif
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1073
		/// </summary>
		/// <param name="file_name">
		/// Required
		/// The SAIF filename to store information
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>The SAIF object that was opened</returns>
		public void open_saif(string file_name, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("open_saif");
			_tcl.Add(command);
		}
		/// <summary>
		/// Open a Value Change Dump (VCD) file for capturing simulation output. This Tcl command models
		/// behavior of $dumpfile Verilog system task
		///
		/// Create or open a Value Change Dump (VCD) file to capture simulation output. This command
		/// operates like the Verilog $dumpfile simulator directive.
		/// VCD is an ASCII file containing header information, variable definitions, and value change details
		/// of a set of HDL signals. The VCD file can be used to view simulation result in a VCD viewer or to
		/// estimate the power consumption of the design.
		/// When a VCD file has been opened, you can write the value changes from the simulation into the
		/// VCD file using checkpoint_vcd, flush_vcd, or log_vcd. In addition, you can pause and
		/// resume the collection of value change data with the stop_vcd and start_vcd commands.
		/// You can limit the size of the VCD file by using the limit_vcd command.
		/// To close the VCD file, use the close_vcd command.
		/// Note: You must use the open_vcd command before using any other *_vcd commands. Only one VCD file
		/// can be open at any time.
		///
		/// The following example opens the specified VCD file (design1.vcd) so that value changes can
		/// be written to it. The log_vcd command identifies all ports in the /tb/UUT scope, and only that
		/// level of the design hierarchy, to be written to the VCD file. The simulation is run for a specified
		/// period of time, and flush_vcd writes the current values of the HDL objects to the VCD file.
		/// Then close_vcd closes the open file.
		/// open_vcd design1.vcd
		/// log_vcd -level 1 [get_objects filter { type == port } /tb/UUT/* ]
		/// run 1000
		/// flush_vcd
		/// close_vcd
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1075
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="file_name">
		/// Optional
		/// file name. Defaults to dump.vcd (This is LRM standard)
		/// Default: dump.vcd
		/// </param>
		/// <returns>
		/// </returns>
		public void open_vcd(bool? quiet = null, bool? verbose = null, string file_name = null)
		{
			var command = new SimpleTCLCommand("open_vcd");
			_tcl.Add(command);
		}
		/// <summary>
		/// Open Waveform Database (WDB) file produced by a prior simulation run and return a simulation
		/// object
		///
		/// The open_wave_database command opens an existing static simulator database file (WDB)
		/// and associated wave config file (WCFG). This simulation is a static simulation, not live, and can
		/// only be used to review prior results.
		/// Note: Many of the commands for running and resetting the simulation are not available in a static
		/// simulation.
		/// Vivado simulator uses a simulation debug data model to allow users to debug HDL source files
		/// using source code stepping, breakpoints, conditions, and waveform viewing tools. The debug
		/// data model contains HDL object and scope names, and maps them to memory addresses to let
		/// you examine the changing values of signals, variables and constants during the simulation. When
		/// the simulation completes, the simulation is written to a static simulator database file (WDB).
		/// HDL objects can be added to the simulation waveform database using the log_wave command
		/// which enables logging of waveform activity for the specified objects to the Vivado simulator
		/// waveform database.
		/// The waveform database is associated with a Wave Config file that stores the waveform activity
		/// for the simulation. The Wave Config file contains just the list of wave objects (signals, dividers,
		/// groups, virtual buses) to display, and their display properties, plus markers. The waveform
		/// database (WDB) contains the event data, values changing over time, for all traced signals,
		/// whether displayed or not.
		/// A Wave Config file is written to disk by the use of the save_wave_config command, and can
		/// be opened with the open_wave_config command.
		/// Use the open_wave_database command with the open_wave_config command to open a
		/// previously completed simulation for review in the Vivado IDE.
		/// TIP: Objects that were logged in the simulation waveform database, with the log_wave command, can be
		/// added posthumously to the wave configuration in a static simulation using the add_wave command.
		///
		/// The following example opens a WDB file with the specified name, then opens an associated
		/// Wave Config file, and finally uses the current_fileset command to open the simulation
		/// database in the Vivado IDE:
		/// open_wave_database {C:/Data/project_xsim/testbench_behav.wdb}
		/// open_wave_config {C:/Data/project_xsim/testbench_behav.wcfg}
		/// current_fileset
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1079
		/// </summary>
		/// <param name="protoinst">
		/// Required
		/// Specify a .protoinst file for protocol analysis
		/// </param>
		/// <param name="wdb">
		/// Required
		/// file name
		/// </param>
		/// <param name="noautoloadwcfg">
		/// Optional
		/// Do not automatically open associated WCFG files
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void open_wave_database(string protoinst, string wdb, bool? noautoloadwcfg = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("open_wave_database");
			_tcl.Add(command);
		}
		/// <summary>
		/// Turns on or off printing of name of the hdl process being simulated
		///
		/// Enables process tracing for simulation debugging purposes.
		/// During simulation the name of the HDL process that is evaluated will be written to the Tcl
		/// console, as well as the simulation source file and line number associated with the process.
		/// TIP: Process tracing provides more detailed information than is available with line tracing and the ltrace
		/// command.
		/// This feature can also be enabled using the PROCESS_TRACING property on the current
		/// simulation object:
		/// set_property PROCESS_TRACING on [current_sim]
		/// The command returns the state of process tracing, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1128
		/// </summary>
		/// <param name="value">
		/// Required
		/// value: on, true, yes. Otherwise set to off, false, no
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void ptrace(string value, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("ptrace");
			_tcl.Add(command);
		}
		/// <summary>
		/// Import simulation data in saif format
		///
		/// Reads a Switching Activity Interchange Format (SAIF) file for use during power analysis by the
		/// report_power command, or power optimization by power_opt_design. The read_saif
		/// command will annotate the design nodes with activity from the SAIF file and estimate power
		/// appropriately.
		/// Running report_power or power_opt_design after reading the SAIF file will use the activity
		/// rates from the specified file during optimization and analysis.
		///
		/// The following example:
		/// read_saif -strip_path design/top/F1 C:/Data/design1.saif
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1155
		/// </summary>
		/// <param name="file">
		/// Required
		/// Specifies the name of the SAIF file to be read
		/// </param>
		/// <param name="strip_path">
		/// Optional
		/// Specifies the name of the instance of the current design as
		/// it appears in the SAIF file
		/// </param>
		/// <param name="no_strip">
		/// Optional
		/// Do not strip first two levels of hierarchy from SAIF file
		/// </param>
		/// <param name="out_file">
		/// Optional
		/// Specifies the name of the output file that contains nets that
		/// could not be matched
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void read_saif(string file, string strip_path = null, bool? no_strip = null, string out_file = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("read_saif");
			_tcl.Add(command);
		}
		/// <summary>
		/// Recompile the design without changing compilation options and restart the current simulation
		///
		/// Relaunch the simulator to perform analysis and verification of an updated design.
		/// The relaunch_sim command suspends the current simulation, recompiles the current design
		/// into a new simulation snapshot, then connects the current simulation to the new snapshot, and
		/// restarts the simulation.
		/// In the typical HDL debug cycle you will compile a design into a simulation snapshot and launch a
		/// simulation, configuring the Vivado simulator IDE to display the signals of interest in the
		/// waveform viewer, as well as the scopes and objects of interest. During the debug process you
		/// may discover issues with your code or test bench, make corrections to your design, recompile
		/// and relaunch the simulator.
		/// This command lets you recompile the design, and relaunch the simulator while preserving the
		/// current Vivado simulator configuration, such as open waveform and code windows, Scopes and
		/// Objects window settings.
		/// IMPORTANT! The relaunch_sim command applies only to simulations running in the Vivado Design Suite
		/// IDE, not stand-alone or batch Vivado simulator runs.
		/// This command returns a transcript of its process, or returns an error if it fails.
		///
		/// The following command relaunches the current simulation:
		/// relaunch_sim
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1207
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>Current simulation object</returns>
		public void relaunch_sim(bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("relaunch_sim");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove breakpoints from a simulation
		///
		/// Remove specified breakpoints from the current simulation. You must have an open simulation to
		/// use this command.
		/// A breakpoint is a user-determined stopping point in the source code used for debugging the
		/// design. When simulating a design with breakpoints, simulation of the design stops at each
		/// breakpoint to let you examine values and verify the design behavior.
		/// The breakpoints in the current simulation can be reported using the report_bps command.
		/// This command returns nothing, or an error if the command fails.
		///
		/// The following example removes all the breakpoints in the current simulation:
		/// remove_bps -all
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1209
		/// </summary>
		/// <param name="all">
		/// Optional
		/// Remove all breakpoints
		/// </param>
		/// <param name="file">
		/// Optional
		/// The specific file to remove the breakpoint from given a line
		/// number
		/// </param>
		/// <param name="line">
		/// Optional
		/// The specific line number to remove the breakpoint given a
		/// filename Default: -1
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="BreakPointObjsOrIds">
		/// Optional
		/// A list of one or more breakpoint objects and/or breakpoint
		/// object ID's to be removed
		/// </param>
		public void remove_bps(bool? all = null, string file = null, string line = null, bool? quiet = null, bool? verbose = null, string BreakPointObjsOrIds = null)
		{
			var command = new SimpleTCLCommand("remove_bps");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove conditions from a simulation. The names can be specified as Tcl glob pattern
		///
		/// Remove specified conditions from the current simulation. You must have an open simulation to
		/// use this command.
		/// Conditions can be defined prior to starting the simulation. When a condition is added, the
		/// simulator evaluates the condition expression anytime a signal change is detected. When a
		/// specified condition expression becomes TRUE, the condition commands are run.
		/// The conditions in the current simulation can be reported using the report_conditions
		/// command.
		/// This command returns nothing, or an error if the command fails.
		///
		/// The following example removes the specified condition from the current simulation:
		/// remove_conditions condition3
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1215
		/// </summary>
		/// <param name="all">
		/// Optional
		/// Remove all conditions
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="ConditionObjs">
		/// Optional
		/// ConditionObjs, id's or names
		/// </param>
		public void remove_conditions(bool? all = null, bool? quiet = null, bool? verbose = null, string ConditionObjs = null)
		{
			var command = new SimpleTCLCommand("remove_conditions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove files or directories from a fileset
		///
		/// Removes the specified file objects from the current or specified fileset. The file is removed from
		/// the current project, but is not removed from the disk.
		/// Files can be specified as file name strings, or as file objects returned by the get_files
		/// command. When specified as strings, the file is looked for in the current or specified fileset.
		/// When the file object is specified by get_files, the fileset is defined by the object, and -
		/// fileset is ignored.
		/// When successful, this command returns nothing. If the specified file is not found, an error is
		/// returned.
		///
		/// The following example removes the file named C:/Design/top.xdc from the constraint set
		/// constrs_1:
		/// remove_files -fileset constrs_1 C:/Design/top.xdc
		/// Multiple files can be specified as follows:
		/// remove_files -fileset sim_1 top_tb1.vhdl top_tb2.vhdl
		/// The following example gets all the file objects in the current project, and removes them:
		/// remove_files [get_files]
		/// CAUTION! This will remove ALL files from your design.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1221
		/// </summary>
		/// <param name="files">
		/// Required
		/// Name of the file(s) to be removed
		/// </param>
		/// <param name="fileset">
		/// Optional
		/// Fileset name
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>list of files that were removed</returns>
		public void remove_files(string files, string fileset = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("remove_files");
			_tcl.Add(command);
		}
		/// <summary>
		/// Release force on signal, wire, or reg applied using 'add_force' command
		///
		/// Remove the specified force objects, or force IDs from the current simulation.
		/// Forces are applied to specific HDL objects using the add_forces command. This command
		/// removes those forces from the current simulation.
		/// IMPORTANT! If there are force/release statements on an HDL object in the test bench or module, these
		/// statements are overridden by the add_force command. When the remove_force command releases these
		/// objects to resume their normal operation, the Verilog force/release statements resume their effect.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example creates a force object using the add_force command, and captures the
		/// force ID in a Tcl variable, then removes that force object:
		/// set f10 [ add_force reset 1 300 ]
		/// remove_forces $f10
		/// The following example removes all force objects from the current simulation:
		/// remove_forces -all
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1223
		/// </summary>
		/// <param name="all">
		/// Optional
		/// Remove all forces
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="ForceObj">
		/// Optional
		/// ForceObj or id's
		/// </param>
		public void remove_forces(bool? all = null, bool? quiet = null, bool? verbose = null, string ForceObj = null)
		{
			var command = new SimpleTCLCommand("remove_forces");
			_tcl.Add(command);
		}
		/// <summary>
		/// Print details of the given breakpoint objects
		///
		/// Report a specific breakpoint object, or report all breakpoints in the current simulation. You must
		/// have an open simulation for this command to return anything.
		/// A breakpoint is a user-determined stopping point in the source code used for debugging the
		/// design. When simulating a design with breakpoints, simulation of the design stops at each
		/// breakpoint to let you examine values and verify the design behavior.
		/// This command returns the filename and line number of the specified breakpoints, or of all
		/// breakpoints in the current simulation, or returns an error if the command fails.
		///
		/// The following example reports all breakpoints in the current simulation:
		/// report_bps
		/// This example reports the specified breakpoints in the current simulation:
		/// report_bps bp1 bp2 bp5
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1268
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="BreakPointObjs">
		/// Optional
		/// List of breakpoint objects to report
		/// </param>
		/// <returns>Print the breakpoints id, file_name and line_number to the console in textual format</returns>
		public void report_bps(bool? quiet = null, bool? verbose = null, string BreakPointObjs = null)
		{
			var command = new SimpleTCLCommand("report_bps");
			_tcl.Add(command);
		}
		/// <summary>
		/// Print details of the given condition objects
		///
		/// Report a specific simulation condition, or report all conditions in the current simulation. You must
		/// have an open simulation for this command to return anything.
		/// Conditions can be defined prior to starting the simulation. When a condition is added, the
		/// simulator evaluates the condition expression anytime a signal change is detected. When a
		/// specified condition expression becomes TRUE, the condition commands are run.
		/// This command returns the condition identifier, expression, commands, and names of conditions,
		/// or returns an error if the command fails.
		///
		/// The following example reports conditions in the current simulation. The condition identifier,
		/// expression, commands, and names are reported:
		/// report_conditions
		/// #2: condition2
		/// Expression: {/testbench/reset == 0 }
		/// Command: {
		/// puts "Condition Reset was encountered at [current_time]. \
		/// Stopping simulation."
		/// stop }
		/// Name: resetLow
		/// #3: condition3
		/// Expression: {/testbench/leds_n == X000 }
		/// Command: {
		/// puts "Condition LED Unknown was encountered at [current_time]. \
		/// Stopping simulation."
		/// stop }
		/// Name: ledUnknown
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1294
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="ConditionObjs">
		/// Optional
		/// ConditionObjs, id's or names
		/// </param>
		/// <returns>Prints name, id, condition_expression and commands of each condition object on the console</returns>
		public void report_conditions(bool? quiet = null, bool? verbose = null, string ConditionObjs = null)
		{
			var command = new SimpleTCLCommand("report_conditions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Print drivers along with current driving values for an HDL wire or signal object
		///
		/// The report_drivers command prints the name and value of the driving signal, as well as the
		/// current value of a signal type HDL object.
		/// Use this command to determine what signal or process is driving the value on a specific HDL
		/// signal, or net object. A driver of a signal is the statement in the HDL source file that is performing
		/// assignment to the signal.
		/// The output format of report_drivers is as follows:
		/// Drivers for <hdl_object>
		/// <Value of HDL Object>: Net <Hierarchical name of the probed signal>
		/// [ Declared Net : <The declared signal to which the probed signal is
		/// connected>]
		/// <Value of Driver> : Driver <Hierarchical name of the HDL process
		/// containing
		/// the driver> at <file_name>:<line number>
		/// Note: The Declared Net is returned when the probed signal name is different from the hierarchical name of
		/// the actual declared signal due to the current scope of the simulation. Each bit of the declared net is printed
		/// for the probed signal.
		/// The values of signals returned by the report_drivers command depend on the state of the
		/// simulation. In the following example, the report is run before and after simulation:
		/// current_scope /testbench/dut
		/// report_drivers leds_n[3:0]
		/// Drivers for /testbench/dut/LEDS_n[3:0]
		/// 0 : Net /testbench/dut/LEDS_n[0]
		/// Declared Net : /testbench/leds_n[3]
		/// 0 : Driver /testbench/dut/line__187 at C:/Data/sources/sinegen_demo.vhd:187
		/// 0 : Driver /testbench/dut/line__186 at C:/Data/sources/sinegen_demo.vhd:186
		/// 0 : Driver /testbench/dut/line__185 at C:/Data/sources/sinegen_demo.vhd:185
		/// 0 : Driver /testbench/dut/line__184 at C:/Data/sources/sinegen_demo.vhd:184
		/// 0 : Net /testbench/dut/LEDS_n[1]
		/// Declared Net : /testbench/leds_n[2]
		/// 0 : Driver /testbench/dut/line__187 at C:/Data/sources/sinegen_demo.vhd:187
		/// 0 : Driver /testbench/dut/line__186 at C:/Data/sources/sinegen_demo.vhd:186
		/// 0 : Driver /testbench/dut/line__185 at C:/Data/sources/sinegen_demo.vhd:185
		/// 0 : Driver /testbench/dut/line__184 at C:/Data/sources/sinegen_demo.vhd:184
		/// 0 : Net /testbench/dut/LEDS_n[2]
		/// Declared Net : /testbench/leds_n[1]
		/// 0 : Driver /testbench/dut/line__187 at C:/Data/sources/sinegen_demo.vhd:187
		/// 1 : Driver /testbench/dut/line__186 at C:/Data/sources/sinegen_demo.vhd:186
		/// 1 : Driver /testbench/dut/line__185 at C:/Data/sources/sinegen_demo.vhd:185
		/// 1 : Driver /testbench/dut/line__184 at C:/Data/sources/sinegen_demo.vhd:184
		/// X : Net /testbench/dut/LEDS_n[3]
		/// Declared Net : /testbench/leds_n[0]
		/// 0 : Driver /testbench/dut/line__187 at C:/Data/sources/sinegen_demo.vhd:187
		/// 0 : Driver /testbench/dut/line__186 at C:/Data/sources/sinegen_demo.vhd:186
		/// 0 : Driver /testbench/dut/line__185 at C:/Data/sources/sinegen_demo.vhd:185
		/// 0 : Driver /testbench/dut/line__184 at C:/Data/sources/sinegen_demo.vhd:184
		/// run all
		/// report_drivers leds_n[3:0]
		/// Drivers for /testbench/dut/LEDS_n[3:0]
		/// 0 : Net /testbench/dut/LEDS_n[0]
		/// Declared Net : /testbench/leds_n[3]
		/// 0 : Driver /testbench/dut/line__187 at C:/Data/sources/sinegen_demo.vhd:187
		/// 0 : Driver /testbench/dut/line__186 at C:/Data/sources/sinegen_demo.vhd:186
		/// 0 : Driver /testbench/dut/line__185 at C:/Data/sources/sinegen_demo.vhd:185
		/// 0 : Driver /testbench/dut/line__184 at C:/Data/sources/sinegen_demo.vhd:184
		/// 1 : Net /testbench/dut/LEDS_n[1]
		/// Declared Net : /testbench/leds_n[2]
		/// 0 : Driver /testbench/dut/line__187 at C:/Data/sources/sinegen_demo.vhd:187
		/// 0 : Driver /testbench/dut/line__186 at C:/Data/sources/sinegen_demo.vhd:186
		/// 0 : Driver /testbench/dut/line__185 at C:/Data/sources/sinegen_demo.vhd:185
		/// 0 : Driver /testbench/dut/line__184 at C:/Data/sources/sinegen_demo.vhd:184
		/// 0 : Net /testbench/dut/LEDS_n[2]
		/// Declared Net : /testbench/leds_n[1]
		/// 1 : Driver /testbench/dut/line__187 at C:/Data/sources/sinegen_demo.vhd:187
		/// 1 : Driver /testbench/dut/line__186 at C:/Data/sources/sinegen_demo.vhd:186
		/// 1 : Driver /testbench/dut/line__185 at C:/Data/sources/sinegen_demo.vhd:185
		/// 1 : Driver /testbench/dut/line__184 at C:/Data/sources/sinegen_demo.vhd:184
		/// 0 : Net /testbench/dut/LEDS_n[3]
		/// Declared Net : /testbench/leds_n[0]
		/// 0 : Driver /testbench/dut/line__187 at C:/Data/sources/sinegen_demo.vhd:187
		/// 0 : Driver /testbench/dut/line__186 at C:/Data/sources/sinegen_demo.vhd:186
		/// 1 : Driver /testbench/dut/line__185 at C:/Data/sources/sinegen_demo.vhd:185
		/// 0 : Driver /testbench/dut/line__184 at C:/Data/sources/sinegen_demo.vhd:184
		/// Note: Notice the declared net is reported, because the current scope of the simulation is set to a different
		/// level than the top-level of the test bench.
		/// This command returns a report of the drivers on the specified objects, or returns an error if it
		/// fails.
		///
		/// The following example reports the drivers for the HDL objects returned by the get_objects
		/// command:
		/// report_drivers [get_objects leds_n]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1326
		/// </summary>
		/// <param name="hdl_object">
		/// Required
		/// Which hdl_object to report
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void report_drivers(string hdl_object, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_drivers");
			_tcl.Add(command);
		}
		/// <summary>
		/// Print, in textual format, stack frames when current_scope is a process waiting inside subprogram
		///
		/// Returns a list of strings of sub-program names, and the calling HDL process in the sub-program
		/// call hierarchy for the current HDL process scope, or current_scope. The list starts with the
		/// HDL process till the most recent sub-program in the hierarchy. Each frame has an associated
		/// frame-index. The most recent sub-program is shown at the top, and has an index "0". The symbol
		/// (->) is used to indicate the current_frame.
		/// By default, the most recently called sub-program frame is the current_frame. Other frames
		/// can be selected using current_frame command. In verbose mode, output gives the source
		/// line-file information for each and every call.
		/// IMPORTANT! report_frames strictly follows the current_scope. If the current_scope is not an
		/// HDL process scope waiting inside a sub-program, the command returns an empty list.
		/// This command returns the name of the design object of the current_instance, or returns nothing
		/// when set to the top of current design.
		///
		/// Example design:
		/// module top;
		/// int i;
		/// function void f(input int in1);
		/// automatic int a;
		/// a = in1 + 7;
		/// $display($time, " in f :: a %d in1 %d ", a, in1);
		/// endfunction
		/// task automatic t(input int in2);
		/// int b;
		/// b = in2 + 10;
		/// $display($time, " in t :: in2 %d b %d ", in2, b);
		/// #5;
		/// f(b); // Case C
		/// $display($time, " Back in t : after wait and f(%d) ", b);
		/// endtask
		/// initial begin // "/top/Initial18_0"
		/// $display($time, " in initial 1 ");
		/// i = 200;
		/// t(i); // Case B
		/// $display($time, " Back in initial 1 after t(%d) ", i);
		/// end
		/// initial begin // "/top/Initial25_1"
		/// $display($time, " in initial 2 ");
		/// #2;
		/// f(50); // Case A
		/// $display($time, " Back in initial 2 after f(50) ");
		/// end
		/// endmodule
		/// When simulation is stopped inside function "f" for its call at 'Case C', function "f" is called from
		/// task "t" at 'Case C', which itself is called from process "/top/Initial18_0" at 'Case B':
		/// > current_scope
		/// /top/Initial18_0
		/// 1. > report_frames
		/// -> 0 : f
		/// 1 : t
		/// 2: /top/Initial18_0
		/// 2. > report_frames -verbose
		/// -> 0 : f @top.v:6
		/// 1 : t @top.v:15
		/// 2 : /top/Initial18_0 @top.v:21
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1335
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>Returns string</returns>
		public void report_frames(bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_frames");
			_tcl.Add(command);
		}
		/// <summary>
		/// Print details of the given hdl objects (variable, signal, wire, or reg)
		///
		/// The report_objects command reports the type, name, and language of the specified HDL
		/// objects to the Tcl Console or Tcl shell. You must have an open simulation to use this command.
		/// This command returns a brief description of the specified objects. Use the describe command
		/// to return more detailed information.
		/// HDL objects include HDL signals, variables, or constants as defined in the Verilog or VHDL test
		/// bench and source files. An HDL signal includes Verilog wire or reg entities, and VHDL signals.
		/// Examples of HDL variables include Verilog real, realtime, time, and event. HDL constants include
		/// Verilog parameters and localparams, and VHDL generic and constants.
		/// The command returns the HDL object type, the name, and the code type (Verilog/VHDL) for
		/// each object, or returns an error if it fails.
		///
		/// Verilog parameters and localparams, and VHDL generic and constants.
		/// The command returns the HDL object type, the name, and the code type (Verilog/VHDL) for
		/// each object, or returns an error if it fails.
		/// Arguments
		/// -quiet - (Optional) Execute the command quietly, returning no messages from the command.
		/// The command also returns TCL_OK regardless of any errors encountered during execution.
		/// Note: Any errors encountered on the command-line, while launching the command, will be returned. Only
		/// errors occurring inside the command will be trapped.
		/// -verbose - (Optional) Temporarily override any message limits and return all messages from this
		/// command.
		/// Note: Message limits can be defined with the set_msg_config command.
		/// <hdl_objects> - (Optional) Specifies the objects to report. The default command reports all
		/// objects found in the current scope of the simulation, or current_scope.
		/// Note: Objects can be specified by name, or returned as objects by the get_objects command.
		/// Examples
		/// The following example shows how the specified objects reported depend upon the current scope
		/// of the simulation:
		/// current_scope testbench
		/// /testbench
		/// report_objects [get_objects leds_n]
		/// Declared: {leds_n[3:0]} Verilog
		/// current_scope dut
		/// /testbench/dut
		/// report_objects leds_n
		/// Out: {LEDS_n[3:0]} VHDL
		/// This example reports the specified HDL objects of the current simulation scope:
		/// report_objects [get_objects GPIO*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1363
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="hdl_objects">
		/// Optional
		/// The hdl_objects to report. Default is report_objects
		/// [get_objects *]
		/// </param>
		/// <returns>Print name, type, data_type of the HDL objects on console in textual format</returns>
		public void report_objects(bool? quiet = null, bool? verbose = null, string hdl_objects = null)
		{
			var command = new SimpleTCLCommand("report_objects");
			_tcl.Add(command);
		}
		/// <summary>
		/// Print names of the children scopes (declarative regions) of given scope(s) or the current scope
		///
		/// Reports the names and types of HDL Scopes in the current scope of the current simulation, or of
		/// specified scopes.
		/// An HDL Scope is a declarative region of an HDL file, where objects are declared. The following
		/// are examples of HDL Scopes in Verilog and VHDL:
		/// • Verilog scopes: module, function, task, process, other begin-end blocks
		/// • VHDL scopes: entity/architecture pair, block, function, procedure, process
		/// You must have an open simulation to use this command.
		///
		/// The following example reports the children scopes of /tb/UUT:
		/// report_scopes [get_scopes /tb/UUT/* filter {type==module}
		/// The following example reports the children scopes of the current scope:
		/// report_scopes
		/// VHDL Instance: {U_DEBOUNCE_0}
		/// VHDL Instance: {U_DEBOUNCE_1}
		/// VHDL Instance: {U_SINEGEN}
		/// VHDL Instance: {U_FSM}
		/// VHDL Process: {line__138}
		/// VHDL Process: {line__184}
		/// VHDL Process: {line__185}
		/// VHDL Process: {line__186}
		/// VHDL Process: {line__187}
		/// VHDL Process: {line__191}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1406
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="hdl_scopes">
		/// Optional
		/// The hdl_objects to report. Default is report_scopes
		/// [get_scopes *]
		/// </param>
		/// <returns>report_scopes prints a subset of properties of the HDL scope on console in textual format</returns>
		public void report_scopes(bool? quiet = null, bool? verbose = null, string hdl_scopes = null)
		{
			var command = new SimpleTCLCommand("report_scopes");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report info of simulation libraries
		///
		/// Report information on libraries compiled by the compile_simlib command.
		///
		/// The following example reports information related to the compiled simulation library at the
		/// specified path:
		/// report_simlib_info C:/Data/compiled_simlib
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1409
		/// </summary>
		/// <param name="path">
		/// Required
		/// Specify the path for pre-compiled libraries
		/// </param>
		/// <param name="file">
		/// Optional
		/// Output file Default: report_simlib_info.log
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append mode
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void report_simlib_info(string path, string file = null, bool? append = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_simlib_info");
			_tcl.Add(command);
		}
		/// <summary>
		/// Print names of processes in a design, which are waiting inside a subprogram, in textual format
		///
		/// Print name of the HDL process scopes waiting inside a subprogram in textual format.
		///
		/// Example design:
		/// module top;
		/// int i;
		/// function void f(input int in1);
		/// automatic int a;
		/// a = in1 + 7;
		/// $display($time, " in f :: a %d in1 %d ", a, in1);
		/// endfunction
		/// task automatic t(input int in2);
		/// int b;
		/// b = in2 + 10;
		/// $display($time, " in t :: in2 %d b %d ", in2, b);
		/// #5;
		/// f(b); // Case C
		/// $display($time, " Back in t : after wait and f(%d) ", b);
		/// endtask
		/// initial begin // "/top/Initial18_0"
		/// $display($time, " in initial 1 ");
		/// i = 200;
		/// t(i); // Case B
		/// $display($time, " Back in initial 1 after t(%d) ", i);
		/// end
		/// initial begin // "/top/Initial25_1"
		/// $display($time, " in initial 2 ");
		/// #2;
		/// f(50); // Case A
		/// $display($time, " Back in initial 2 after f(50) ");
		/// end
		/// endmodule
		/// When simulation is stopped inside function "f" for its call at 'Case A' , the two processes /top/
		/// Initial18_0 and /top/Initial25_1, are waiting inside task "t" (call at 'CaseB') and
		/// function "f" (call at 'CaseA') respectively.
		/// 1. > report_stacks
		/// Verilog Process: {/top/Initial18_0}
		/// Verilog Process: {/top/Initial25_1}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1414
		/// </summary>
		/// <param name="of_instance">
		/// Optional
		/// Default: NULL
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>Returns string</returns>
		public void report_stacks(string of_instance = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_stacks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Print current simulated value of given HDL objects (variable, signal, wire, or reg)
		///
		/// Report the values of the specified HDL objects at the current simulation run time.
		/// HDL objects include HDL signals, variables, or constants as defined in the Verilog or VHDL test
		/// bench and source files. An HDL signal includes Verilog wire or reg entities, and VHDL signals.
		/// Examples of HDL variables include Verilog real, realtime, time, and event.
		/// HDL constants include Verilog parameters and localparams, and VHDL generic and constants.
		/// The HDL scope, or scope, is defined by a declarative region in the HDL code such as a module,
		/// function, task, process, or begin-end blocks in Verilog. VHDL scopes include entity/architecture
		/// definitions, block, function, procedure, and process blocks.
		///
		/// HDL constants include Verilog parameters and localparams, and VHDL generic and constants.
		/// The HDL scope, or scope, is defined by a declarative region in the HDL code such as a module,
		/// function, task, process, or begin-end blocks in Verilog. VHDL scopes include entity/architecture
		/// definitions, block, function, procedure, and process blocks.
		/// Arguments
		/// -radix <arg> - (Optional) Specifies the radix to use when returning the value of the specified
		/// objects. Allowed values are: default, dec, bin, oct, hex, unsigned, ascii, or smag.
		/// Note: The radix dec indicates a signed decimal. Specify the radix unsigned when dealing with unsigned
		/// data.
		/// -quiet - (Optional) Execute the command quietly, returning no messages from the command.
		/// The command also returns TCL_OK regardless of any errors encountered during execution.
		/// Note: Any errors encountered on the command-line, while launching the command, will be returned. Only
		/// errors occurring inside the command will be trapped.
		/// -verbose - (Optional) Temporarily override any message limits and return all messages from this
		/// command.
		/// Note: Message limits can be defined with the set_msg_config command.
		/// <hdl_objects> - (Required) Specifies one or more HDL objects to return the values of. The object
		/// can be specified by name, or can be returned as an object from the get_objects command.
		/// Examples
		/// The following example reports the value of all objects at the current time:
		/// report_values [get_objects]
		/// This example shows the difference between the bin, dec, and unsigned radix on the value
		/// returned from the specified bus:
		/// report_values -radix bin /test/bench_VStatus_pad_0_i[7:0]
		/// Declared: {/test/bench_VStatus_pad_0_i[7:0]} Verilog 10100101
		/// report_values -radix unsigned /test/bench_VStatus_pad_0_i[7:0]
		/// Declared: {/test/bench_VStatus_pad_0_i[7:0]} Verilog 165
		/// report_values -radix dec /test/bench_VStatus_pad_0_i[7:0]
		/// Declared: {/test/bench_VStatus_pad_0_i[7:0]} Verilog -91
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1444
		/// </summary>
		/// <param name="radix">
		/// Optional
		/// The radix specifies the radix to use for printing the values of
		/// the hdl_objects. Allowed values are: default, dec, bin, oct,
		/// hex, unsigned, ascii, smag.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="hdl_objects">
		/// Optional
		/// The hdl_objects to report. Default is report_objects
		/// [get_objects *]
		/// </param>
		/// <returns>Print name and value of HDL objects on the console in textual format</returns>
		public void report_values(string radix = null, bool? quiet = null, bool? verbose = null, string hdl_objects = null)
		{
			var command = new SimpleTCLCommand("report_values");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reset an existing simulation run
		///
		/// Reset the current simulation to its starting condition, by cleaning out the various output files
		/// created during compilation and simulation for the specified simulation fileset.
		/// IMPORTANT! Local files will be removed from the project simulation folders without warning.
		/// The command returns nothing if successful, or an error if it fails.
		///
		/// The following example resets the post-synthesis timing simulation by removing files for the sim_2
		/// simset:
		/// reset_simulation -mode post-synthesis -type timing sim_2
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1481
		/// </summary>
		/// <param name="mode">
		/// Optional
		/// Remove generated data for the specified mode. Values:
		/// behavioral, post-synthesis, post-implementation Default:
		/// behavioral
		/// </param>
		/// <param name="type">
		/// Optional
		/// Remove generated data for the specified type. Applicable
		/// mode is post-synthesis or post-implementation. Values:
		/// functional, timing
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="simset">
		/// Optional
		/// Name of the simulation fileset to reset
		/// </param>
		public void reset_simulation(string mode = null, string type = null, bool? quiet = null, bool? verbose = null, string simset = null)
		{
			var command = new SimpleTCLCommand("reset_simulation");
			_tcl.Add(command);
		}
		/// <summary>
		/// Rewind simulation to post loading state (as if design was reloaded), time is set to 0
		///
		/// Return the current simulation to its initial state, as if the design was reloaded, resetting the
		/// current simulation time to 0.
		/// The restart command retains breakpoints, Tcl forces, and settings in the waveform
		/// configuration window, but resets all simulation values, and clears all other Tcl commands.
		///
		/// The following example restarts the current simulation:
		/// restart
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1502
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>
		/// </returns>
		public void restart(bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("restart");
			_tcl.Add(command);
		}
		/// <summary>
		/// Run the simulation for the specified time
		///
		/// Run the current simulation from the current time to the specified time, or until the simulation
		/// stops.
		/// A running simulation can be stopped at a predetermined time, at a specific breakpoint in the HDL
		/// source code, by encountering a TRUE condition, by evaluating the circuit until there are no
		/// remaining events, or by encountering a runtime error such as an out-of-bounds value.
		/// The run command instructs an existing simulation to run for a specified length of time, or until
		/// there are no remaining events. The time is specified as a floating point number indicating a
		/// period of time in the current simulation units, or in the specified units.
		///
		/// The following example runs an existing simulation for the specified simulation run time, using the
		/// default units (ns):
		/// run 1000
		/// The following example runs an existing simulation for 300 microseconds (us):
		/// run 300 us
		/// The following example runs the current simulation until no event is left in the event queue, a
		/// breakpoint or valid condition is met, or a simulation runtime error occurs:
		/// run -all
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1512
		/// </summary>
		/// <param name="all">
		/// Optional
		/// Runs simulation till a breakpoint, an exception or no events
		/// left in the queue
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="time">
		/// Optional
		/// Length of simulation time
		/// </param>
		/// <param name="unit">
		/// Optional
		/// Unit for time from the following time units: fs, ps, ns, us, ms,
		/// sec
		/// </param>
		public void run(bool? all = null, bool? quiet = null, bool? verbose = null, string time = null, string unit = null)
		{
			var command = new SimpleTCLCommand("run");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set the current value of an HDL object (variable, signal, wire, or reg) to a specified value
		///
		/// Specify the value of a single HDL object at the current simulation run time.
		/// HDL objects include HDL signals, variables, or constants as defined in the Verilog or VHDL test
		/// bench and source files. An HDL signal includes Verilog wire or reg entities, and VHDL signals.
		/// Examples of HDL variables include Verilog real, realtime, time, and event.
		/// HDL constants include Verilog parameters and localparams, and VHDL generic and constants.
		/// The HDL scope, or scope, is defined by a declarative region in the HDL code such as a module,
		/// function, task, process, or begin-end blocks in Verilog. VHDL scopes include entity/architecture
		/// definitions, block, function, procedure, and process blocks.
		///
		/// HDL constants include Verilog parameters and localparams, and VHDL generic and constants.
		/// The HDL scope, or scope, is defined by a declarative region in the HDL code such as a module,
		/// function, task, process, or begin-end blocks in Verilog. VHDL scopes include entity/architecture
		/// definitions, block, function, procedure, and process blocks.
		/// Arguments
		/// -radix <arg> - (Optional) Specifies the radix to use when returning the value of the specified
		/// object. Allowed values are: default, dec, bin, oct, hex, unsigned, ascii, or smag.
		/// Note: The radix dec indicates a signed decimal. Specify the radix unsigned when dealing with unsigned
		/// data.
		/// -quiet - (Optional) Execute the command quietly, returning no messages from the command.
		/// The command also returns TCL_OK regardless of any errors encountered during execution.
		/// Note: Any errors encountered on the command-line, while launching the command, will be returned. Only
		/// errors occurring inside the command will be trapped.
		/// -verbose - (Optional) Temporarily override any message limits and return all messages from this
		/// command.
		/// Note: Message limits can be defined with the set_msg_config command.
		/// <hdl_object> - (Required) Specifies a single HDL object to get the value of. The object can be
		/// specified by name, or can be returned as an object from the get_objects command.
		/// <value> - (Required) The value to set the specified object to. The specified <value> depends on
		/// the type of the <hdl_object>. HDL object types include: "logic", floating point, VHDL
		/// enumerated, and VHDL integral. For all but "logic" the -radix option is ignored.
		/// • "Logic" does not refer to an actual HDL object type, but means any object whose values are
		/// similar to those of VHDL std_logic, such as:
		/// ○ the Verilog implicit 4-state bit type,
		/// ○ the VHDL bit and std_logic predefined types,
		/// ○ any VHDL enumeration type which is a subset of std_logic, including the character literals
		/// '0' and '1'.
		/// • For logic types the value depends on the radix:
		/// ○ If the specified value has fewer bits than the logic type expects, the value is zero extended,
		/// but not sign extended, to match the expected length.
		/// ○ If the specified value has more bits than the logic type expects, the extra bits on the MSB
		/// side should all be zeros, or the Vivado simulator will return a "size mismatch" error.
		/// • Accepted values for floating point objects are floating point values.
		/// • The accepted value for non-logic VHDL enumerated types is a scalar value from the
		/// enumerated set of values, without single quotes in the case of characters.
		/// • Accepted values for VHDL integral types is a signed decimal integer in the range accepted by
		/// the type.
		/// Examples
		/// The following example sets the value of the sysClk signal:
		/// set_value sysClk Z
		/// This example uses the bin, dec, and unsigned radix to specify the same value on the given
		/// bus:
		/// set_value -radix bin /test/bench_VStatus_pad_0_i[7:0] 10100101
		/// set_value -radix unsigned /test/bench_VStatus_pad_0_i[7:0] 165
		/// set_value -radix dec /test/bench_VStatus_pad_0_i[7:0] -91
		/// The following example shows the bit extension performed when the provided value has fewer
		/// bits than the logic type expects:
		/// set_value -radix bin /test/bench_VStatus_pad_0_i[7:0] 101
		/// get_value -radix bin /test/bench_VStatus_pad_0_i[7:0]
		/// 00000101
		/// The following example shows the bit truncation performed when the provided value has more
		/// bits than the logic type expects:
		/// set_value -radix bin /test/bench_VStatus_pad_0_i[7:0] 0010100101
		/// get_value -radix bin /test/bench_VStatus_pad_0_i[7:0]
		/// 10100101
		/// set_value -radix bin /test/bench_VStatus_pad_0_i[7:0] 1110100101
		/// ERROR: [#UNDEF] Object size 8 does not match size of given value 1110100101
		/// Note: In the second set_value command, the extra bits are not zero, and so an error is returned.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1665
		/// </summary>
		/// <param name="hdl_object">
		/// Required
		/// Set the value on the given hdl_object.
		/// </param>
		/// <param name="value">
		/// Required
		/// The value to assign to the specified object.
		/// </param>
		/// <param name="radix">
		/// Optional
		/// radix specifies the radix to use for interpreting value.
		/// Allowed values are: default, dec, bin, oct, hex, unsigned,
		/// ascii, smag
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_value(string hdl_object, string value, string radix = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_value");
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
		/// Start capturing VCD output (equivalent of $dumpon verilog system task). This can be used after a
		/// stop_vcd TCL command has stopped VCD generation started by open_vcd
		///
		/// The start_vcd command specifies that the tool start writing Value Change Dump (VCD)
		/// information into the specified VCD object. This Tcl command models the behavior of the Verilog
		/// $dumpon system task.
		/// IMPORTANT! You must execute the open_vcd command before using the start_vcd command.
		/// Nothing is returned by this command.
		///
		/// The following example starts the writing of HDL signals into the current VCD file:
		/// start_vcd
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1681
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void start_vcd(bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("start_vcd");
			_tcl.Add(command);
		}
		/// <summary>
		/// Step simulation to the next statement
		///
		/// Step the current simulation to the next executable statement in the HDL source files.
		/// The line stepping feature lets you run the simulator stepping through the source code line-by￾line. This is helpful if you are interested in observing how each line or feature of your HDL source
		/// affects the results of simulation.
		/// The step command returns information related to the next executable line from the HDL source
		/// file, or returns an error if it fails.
		///
		/// The following example runs the current executable line of the HDL source code, and pauses at
		/// the next executable line, returning information about that line:
		/// step
		/// Stopped at time : 0 fs : File "C:/Data/ug937/sim/testbench.v" Line 17
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1685
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void step(bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("step");
			_tcl.Add(command);
		}
		/// <summary>
		/// Use within a condition to tell simulation to stop when a condition is true
		///
		/// The stop command pauses the current simulation. This command can be used within a
		/// condition, defined by add_condition, to pause the simulation when the condition is true.
		///
		/// The following example defines a condition named resetLow, that becomes true when the reset
		/// signal is low, and then puts a message to the standard output, and stops the current simulation:
		/// add_condition -name resetLow {/testbench/reset == 0 } {
		/// puts "Condition Reset was encountered at [current_time]. \
		/// Stopping simulation."
		/// stop }
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1687
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>A "stop" in simulation is a pause and not a quit</returns>
		public void stop(bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("stop");
			_tcl.Add(command);
		}
		/// <summary>
		/// Stop capturing VCD output (equivalent of $dumpoff verilog system task). The start_vcd TCL
		/// command can be used to resume capturing VCD
		///
		/// Stop writing the simulation values to the current Value Change Dump (VCD) file. This suspends
		/// the output of simulation information to the file until the process is resumed using the
		/// start_vcd command.
		/// This Tcl command models the behavior of the Verilog $dumpoff system task.
		/// IMPORTANT! You must execute the open_vcd command before using the stop_vcd command.
		/// Nothing is returned by the command.
		///
		/// The following example stops writing simulation values to the current VCD file:
		/// stop_vcd
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1696
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void stop_vcd(bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("stop_vcd");
			_tcl.Add(command);
		}
		/// <summary>
		/// write_sdf command generates flat sdf delay files for event simulation
		///
		/// Writes the timing delays for cells in the design to a Standard Delay Format (SDF) file.
		/// The output SDF file can be used by the write_verilog command to create Verilog netlists for
		/// static timing analysis and timing simulation.
		///
		/// The following example writes an SDF file to the specified directory:
		/// write_sdf C:/Data/FPGA_Design/designOut.sdf
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1851
		/// </summary>
		/// <param name="file">
		/// Required
		/// File name
		/// </param>
		/// <param name="process_corner">
		/// Optional
		/// Specify process corner for which SDF delays are required;
		/// Values: slow, fast Default: slow
		/// </param>
		/// <param name="cell">
		/// Optional
		/// Root of the design to write, e.g. des.subblk.cpu Default:
		/// whole design
		/// </param>
		/// <param name="rename_top">
		/// Optional
		/// Replace name of top module with custom name e.g. netlist
		/// Default: new top module name
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite existing SDF file
		/// </param>
		/// <param name="mode">
		/// Optional
		/// Specify sta (Static Timing Analysis) or timesim (Timing
		/// Simulation) mode for SDF Default: timesim
		/// </param>
		/// <param name="gzip">
		/// Optional
		/// write gzipped SDF
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void write_sdf(string file, string process_corner = null, string cell = null, string rename_top = null, bool? force = null, string mode = null, bool? gzip = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("write_sdf");
			_tcl.Add(command);
		}
		/// <summary>
		/// Export the current netlist in Verilog format
		///
		/// Write a Verilog netlist of the current design or from a specific cell of the design to the specified
		/// file or directory. The output is a IEEE 1364-2001 compliant Verilog HDL file that contains netlist
		/// information obtained from the input design files.
		/// You can output a complete netlist of the design or specific cell, or output a port list for the
		/// design, or a Verilog netlist for simulation or static timing analysis.
		///
		/// The following example writes a Verilog simulation netlist file for the whole design to the specified
		/// file and path:
		/// write_verilog C:/Data/my_verilog.v
		/// In the following example, because the -mode timesim and -sdf_anno options are specified,
		/// the $sdf_annotate statement will be added to the Verilog netlist. However, since the -
		/// sdf_file option is not specified, the SDF file is assumed to have the same name as the Verilog
		/// output file, with an .sdf file extension:
		/// write_verilog C:/Data/my_verilog.net -mode timesim -sdf_anno true
		/// Note: The SDF filename written to the $sdf_annotate statement will be my_verilog.sdf.
		/// In the following example, the functional simulation mode is specified, the option to keep VCC
		/// and GND primitives in the output simulation netlist is enabled, and the output file is specified:
		/// write_verilog -mode funcsim -keep_vcc_gnd out.v
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1853
		/// </summary>
		/// <param name="file">
		/// Required
		/// Which file to write
		/// </param>
		/// <param name="cell">
		/// Optional
		/// Root of the design to write, e.g. des.subblk.cpu Default:
		/// whole design
		/// </param>
		/// <param name="mode">
		/// Optional
		/// Values: design, pin_planning, synth_stub, sta, funcsim,
		/// timesim Default: design
		/// </param>
		/// <param name="lib">
		/// Optional
		/// Write each library into a separate file
		/// </param>
		/// <param name="port_diff_buffers">
		/// Optional
		/// Output differential buffers when writing in -port mode
		/// </param>
		/// <param name="write_all_overrides">
		/// Optional
		/// Write parameter overrides on Xilinx primitives even if the
		/// override value is the same as the default value
		/// </param>
		/// <param name="keep_vcc_gnd">
		/// Optional
		/// Don't replace VCC/GND instances by literal constants on
		/// load terminals. For simulation modes only.
		/// </param>
		/// <param name="rename_top">
		/// Optional
		/// Replace top module name with custom name e.g. netlist
		/// Default: new top module name
		/// </param>
		/// <param name="sdf_anno">
		/// Optional
		/// Specify if sdf_annotate system task statement is generated
		/// </param>
		/// <param name="sdf_file">
		/// Optional
		/// Full path to sdf file location Default: <file>.sdf
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite existing file
		/// </param>
		/// <param name="include_xilinx_libs">
		/// Optional
		/// Include simulation models directly in netlist instead of
		/// linking to library
		/// </param>
		/// <param name="logic_function_stripped">
		/// Optional
		/// Convert INIT strings on LUTs & RAMBs to fixed values.
		/// Resulting netlist will not behave correctly.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>the name of the output file or directory</returns>
		public void write_verilog(string file, string cell = null, string mode = null, bool? lib = null, bool? port_diff_buffers = null, bool? write_all_overrides = null, bool? keep_vcc_gnd = null, string rename_top = null, string sdf_anno = null, string sdf_file = null, bool? force = null, bool? include_xilinx_libs = null, bool? logic_function_stripped = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("write_verilog");
			_tcl.Add(command);
		}
		/// <summary>
		/// Export the current netlist in VHDL format
		///
		/// Write a VHDL netlist of the current design or from a specific cell of the design to the specified
		/// file or directory.
		/// The output of this command is a VHDL IEEE 1076.4 VITAL-2000 compliant VHDL file that
		/// contains netlist information obtained from the input design files. You can output a complete
		/// netlist of the design or specific cell, or output a port list for the design.
		///
		/// The following example writes a VHDL simulation netlist file for the whole design to the specified
		/// file and path:
		/// write_vhdl C:/Data/bft_top.vhd
		/// In the following example the entity definition of the top-level module is not output to the VHDL
		/// netlist:
		/// write_vhdl C:/Data/vhdl_arch_only.vhd -arch_only
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1857
		/// </summary>
		/// <param name="file">
		/// Required
		/// Which file to write
		/// </param>
		/// <param name="cell">
		/// Optional
		/// Root of the design to write, e.g. des.subblk.cpu Default:
		/// whole design
		/// </param>
		/// <param name="mode">
		/// Optional
		/// Output mode. Valid values: funcsim, pin_planning,
		/// synth_stub Default: funcsim
		/// </param>
		/// <param name="lib">
		/// Optional
		/// Write each library into a separate file
		/// </param>
		/// <param name="port_diff_buffers">
		/// Optional
		/// Output differential buffers when writing in -port mode
		/// </param>
		/// <param name="write_all_overrides">
		/// Optional
		/// Write parameter overrides on Xilinx primitives even if the
		/// same as the default value
		/// </param>
		/// <param name="keep_vcc_gnd">
		/// Optional
		/// Don't replace VCC/GND instances by literal constants on
		/// load terminals. For simulation modes only.
		/// </param>
		/// <param name="rename_top">
		/// Optional
		/// Replace top module name with custom name e.g. netlist
		/// Default: new top module name
		/// </param>
		/// <param name="arch_only">
		/// Optional
		/// Write only the architecture, not the entity declaration for the
		/// top cell
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite existing file
		/// </param>
		/// <param name="include_xilinx_libs">
		/// Optional
		/// Include simulation models directly in netlist instead of
		/// linking to library
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>the name of the output file or directory</returns>
		public void write_vhdl(string file, string cell = null, string mode = null, bool? lib = null, bool? port_diff_buffers = null, bool? write_all_overrides = null, bool? keep_vcc_gnd = null, string rename_top = null, bool? arch_only = null, bool? force = null, bool? include_xilinx_libs = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("write_vhdl");
			_tcl.Add(command);
		}
		/// <summary>
		/// Load a simulation snapshot for simulation and return a simulation object
		///
		/// The xsim command loads a simulation snapshot to run a batch mode simulation, or to provide a
		/// GUI and/or Tcl-based interactive simulation environment. The snapshot must be generated using
		/// the xelab command.
		///
		/// The following example launches xsim on the specified simulation snapshot:
		/// xsim C:/Data/project_xsim/project_xsim.sim/sim_1/behav/testbench_behav
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1865
		/// </summary>
		/// <param name="view">
		/// Required
		/// Open a wave configuration file. This switch may be repeated
		/// to open multiple files.
		/// </param>
		/// <param name="tclbatch">
		/// Required
		/// Specify the TCL file for batch mode execution
		/// </param>
		/// <param name="t">
		/// Required
		/// Specify the TCL file for batch mode execution
		/// </param>
		/// <param name="testplusarg">
		/// Required
		/// Specify plusargs to be used by $test$plusargs and $value
		/// $plusargs system functions
		/// </param>
		/// <param name="protoinst">
		/// Required
		/// Specify a .protoinst file for protocol analysis
		/// </param>
		/// <param name="ignore_feature">
		/// Required
		/// Specify System Verilog feature to be ignored at runtime.
		/// Choices are: assertion : Ignore concurrent assertions.
		/// </param>
		/// <param name="downgrade_severity">
		/// Required
		/// Downgrade severity level of System Verilog HDL
		/// messages.Choices are: error2warning|error2info|
		/// fatal2warning|fatal2info.
		/// </param>
		/// <param name="snapshot">
		/// Required
		/// The name of design snapshot or WDB file
		/// </param>
		/// <param name="autoloadwcfg">
		/// Optional
		/// For a WDB file named <name>.wdb, automatically open all
		/// WCFG files named <name>#.wcfg. Ignored if -view is
		/// present.
		/// </param>
		/// <param name="runall">
		/// Optional
		/// Run simulation until completion, then quit (does 'run -all;
		/// exit')
		/// </param>
		/// <param name="R">
		/// Optional
		/// Run simulation until completion, then quit (does 'run -all;
		/// exit')
		/// </param>
		/// <param name="maxdeltaid">
		/// Optional
		/// Specify the maximum delta number. Will report error if it
		/// exceeds maximum simulation loops at the same time
		/// Default: 10000
		/// </param>
		/// <param name="nolog">
		/// Optional
		/// Ignored (for compatibility with xsim command-line tool)
		/// </param>
		/// <param name="maxlogsize">
		/// Optional
		/// Set the maximum size a log file can reach in MB. The default
		/// setting is unlimited Default: -1
		/// </param>
		/// <param name="onfinish">
		/// Optional
		/// Specify behavior at end of simulation: quit|stop Default:
		/// stop
		/// </param>
		/// <param name="onerror">
		/// Optional
		/// Specify behavior upon simulation run-time error: quit|stop
		/// Default: stop
		/// </param>
		/// <param name="vcdfile">
		/// Optional
		/// Specify the vcd output file
		/// Name Description
		/// </param>
		/// <param name="vcdunit">
		/// Optional
		/// Specify the vcd output unit. Default is the same as the
		/// engine precision unit
		/// </param>
		/// <param name="wdb">
		/// Optional
		/// Specify the waveform database output file
		/// </param>
		/// <param name="tp">
		/// Optional
		/// Enable printing of hierarchical names of process being
		/// executed
		/// </param>
		/// <param name="tl">
		/// Optional
		/// Enable printing of file name and line number of statements
		/// being executed.
		/// </param>
		/// <param name="nosignalhandlers">
		/// Optional
		/// Run with no signal handlers to avoid conflict with security
		/// software
		/// </param>
		/// <param name="ieeewarnings">
		/// Optional
		/// Enable warnings from VHDL IEEE functions
		/// </param>
		/// <param name="stats">
		/// Optional
		/// Display memory and cpu stats upon exiting
		/// </param>
		/// <param name="scNoLogFile">
		/// Optional
		/// Keep the SystemC output separate from XSim output
		/// </param>
		/// <param name="sv_seed">
		/// Optional
		/// Seed for constraint random stimulus Default: 1
		/// </param>
		/// <param name="cov_db_dir">
		/// Optional
		/// System Verilog Coverage Run Directory. The coverage data
		/// will be present under <cov_db_dir>/xsim.covdb/
		/// <cov_db_name> directory.Default is ./ or inherits value set in
		/// similar xelab option.
		/// </param>
		/// <param name="cov_db_name">
		/// Optional
		/// System Verilog Coverage Run Name. The coverage data will
		/// be present under <cov_db_dir>/xsim.covdb/<cov_db_name>
		/// directory.Default is snapshot name or inherits value set in
		/// similar xelab option.
		/// </param>
		/// <param name="ignore_assertions">
		/// Optional
		/// Ignore System Verilog concurrent assertion constructs at
		/// runtime.
		/// </param>
		/// <param name="ignore_coverage">
		/// Optional
		/// Ignore System Verilog Functional Coverage at runtime.
		/// </param>
		/// <param name="downgrade_error2info">
		/// Optional
		/// Downgrade System verilog message severity from error to
		/// info level.
		/// </param>
		/// <param name="downgrade_error2warning">
		/// Optional
		/// Downgrade System verilog message severity from error to
		/// warning level.
		/// </param>
		/// <param name="downgrade_fatal2info">
		/// Optional
		/// Downgrade System verilog message severity from fatal to
		/// info level.
		/// </param>
		/// <param name="downgrade_fatal2warning">
		/// Optional
		/// Downgrade System verilog message severity from fatal to
		/// warning level.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>Current simulation object</returns>
		public void xsim(string view, string tclbatch, string t, string testplusarg, string protoinst, string ignore_feature, string downgrade_severity, string snapshot, bool? autoloadwcfg = null, bool? runall = null, bool? R = null, string maxdeltaid = null, bool? nolog = null, string maxlogsize = null, string onfinish = null, string onerror = null, string vcdfile = null, string vcdunit = null, string wdb = null, bool? tp = null, bool? tl = null, bool? nosignalhandlers = null, bool? ieeewarnings = null, bool? stats = null, bool? scNoLogFile = null, string sv_seed = null, string cov_db_dir = null, string cov_db_name = null, bool? ignore_assertions = null, bool? ignore_coverage = null, bool? downgrade_error2info = null, bool? downgrade_error2warning = null, bool? downgrade_fatal2info = null, bool? downgrade_fatal2warning = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("xsim");
			_tcl.Add(command);
		}
	}
}
