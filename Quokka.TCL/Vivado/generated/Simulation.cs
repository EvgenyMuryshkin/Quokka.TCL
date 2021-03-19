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
		/// </summary>
		public void add_bp()
		{
			var command = new SimpleTCLCommand("add_bp");
			_tcl.Add(command);
		}
		/// <summary>
		/// Conditionally execute Tcl commands
		/// </summary>
		public void add_condition()
		{
			var command = new SimpleTCLCommand("add_condition");
			_tcl.Add(command);
		}
		/// <summary>
		/// Add sources to the active fileset
		/// </summary>
		public void add_files()
		{
			var command = new SimpleTCLCommand("add_files");
			_tcl.Add(command);
		}
		/// <summary>
		/// Force value of signal, wire, or reg to a specified value
		/// </summary>
		public void add_force()
		{
			var command = new SimpleTCLCommand("add_force");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a VCD checkpoint (equivalent of Verilog $dumpall system task)
		/// </summary>
		public void checkpoint_vcd()
		{
			var command = new SimpleTCLCommand("checkpoint_vcd");
			_tcl.Add(command);
		}
		/// <summary>
		/// Flush SAIF toggle information to the SAIF output file and close the file
		/// </summary>
		public void close_saif()
		{
			var command = new SimpleTCLCommand("close_saif");
			_tcl.Add(command);
		}
		/// <summary>
		/// Unload the current simulation without exiting Vivado
		/// </summary>
		public void close_sim()
		{
			var command = new SimpleTCLCommand("close_sim");
			_tcl.Add(command);
		}
		/// <summary>
		/// Flush VCD information to the VCD output file and close the file
		/// </summary>
		public void close_vcd()
		{
			var command = new SimpleTCLCommand("close_vcd");
			_tcl.Add(command);
		}
		/// <summary>
		/// Compile simulation libraries
		/// </summary>
		public void compile_simlib()
		{
			var command = new SimpleTCLCommand("compile_simlib");
			_tcl.Add(command);
		}
		/// <summary>
		/// Configure settings for compile_simlib
		/// </summary>
		public void config_compile_simlib()
		{
			var command = new SimpleTCLCommand("config_compile_simlib");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new fileset
		/// </summary>
		public void create_fileset()
		{
			var command = new SimpleTCLCommand("create_fileset");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get index of the selected subprogram frame (default, top i.e. most recent subprogram call) in the
		/// call-stack of the HDL process scope (current_scope). Sets current stack frame for the subprogram
		/// call-stack of the current_scope.
		/// </summary>
		public void current_frame()
		{
			var command = new SimpleTCLCommand("current_frame");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the current scope or set the current scope
		/// </summary>
		public void current_scope()
		{
			var command = new SimpleTCLCommand("current_scope");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set the current simulation object or get the current simulation object
		/// </summary>
		public void current_sim()
		{
			var command = new SimpleTCLCommand("current_sim");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report current simulation time
		/// </summary>
		public void current_time()
		{
			var command = new SimpleTCLCommand("current_time");
			_tcl.Add(command);
		}
		/// <summary>
		/// Return the current VCD object or make VCDObject the current VCD object
		/// </summary>
		public void current_vcd()
		{
			var command = new SimpleTCLCommand("current_vcd");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete a fileset
		/// </summary>
		public void delete_fileset()
		{
			var command = new SimpleTCLCommand("delete_fileset");
			_tcl.Add(command);
		}
		/// <summary>
		/// Describe an HDL object (variable, signal, wire, or reg) by printing type and declaration
		/// information
		/// </summary>
		public void describe()
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
		/// </summary>
		public void export_ip_user_files()
		{
			var command = new SimpleTCLCommand("export_ip_user_files");
			_tcl.Add(command);
		}
		/// <summary>
		/// (User-written application) Export a script and associated data files (if any) for driving standalone
		/// simulation using the specified simulator.
		/// </summary>
		public void export_simulation()
		{
			var command = new SimpleTCLCommand("export_simulation");
			_tcl.Add(command);
		}
		/// <summary>
		/// Flush VCD simulation output to the VCD output file (equivalent of $dumpflush verilog system
		/// task)
		/// </summary>
		public void flush_vcd()
		{
			var command = new SimpleTCLCommand("flush_vcd");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write all the simulation .mem files.
		/// </summary>
		public void generate_mem_files()
		{
			var command = new SimpleTCLCommand("generate_mem_files");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of HDL objects in one or more HDL scopes as per the specified pattern
		/// </summary>
		public void get_objects()
		{
			var command = new SimpleTCLCommand("get_objects");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of children HDL scopes of a scope
		/// </summary>
		public void get_scopes()
		{
			var command = new SimpleTCLCommand("get_scopes");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get registered simulators
		/// </summary>
		public void get_simulators()
		{
			var command = new SimpleTCLCommand("get_simulators");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of processes in a design, which are waiting inside a subprogram
		/// </summary>
		public void get_stacks()
		{
			var command = new SimpleTCLCommand("get_stacks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get current value of the selected HDL object (variable, signal, wire, reg)
		/// </summary>
		public void get_value()
		{
			var command = new SimpleTCLCommand("get_value");
			_tcl.Add(command);
		}
		/// <summary>
		/// Import files and/or directories into the active fileset
		/// </summary>
		public void import_files()
		{
			var command = new SimpleTCLCommand("import_files");
			_tcl.Add(command);
		}
		/// <summary>
		/// Launch simulation
		/// </summary>
		public void launch_simulation()
		{
			var command = new SimpleTCLCommand("launch_simulation");
			_tcl.Add(command);
		}
		/// <summary>
		/// Limit the maximum size of the VCD file on disk (equivalent of $dumplimit verilog task)
		/// </summary>
		public void limit_vcd()
		{
			var command = new SimpleTCLCommand("limit_vcd");
			_tcl.Add(command);
		}
		/// <summary>
		/// Log Switching Activity Interchange Format (SAIF) toggle for specified wire, signal, or reg
		/// </summary>
		public void log_saif()
		{
			var command = new SimpleTCLCommand("log_saif");
			_tcl.Add(command);
		}
		/// <summary>
		/// Log Value Change Dump (VCD) simulation output for specified wire, signal, or reg
		/// </summary>
		public void log_vcd()
		{
			var command = new SimpleTCLCommand("log_vcd");
			_tcl.Add(command);
		}
		/// <summary>
		/// Log simulation output for specified wire, signal, or reg for viewing using Vivado Simulators
		/// waveform viewer. Unlike add_wave, this command does not add the waveform object to
		/// waveform viewer (i.e. Waveform Configuration). It simply enables logging of output to the Vivado
		/// Simulators Waveform Database (WDB).
		/// </summary>
		public void log_wave()
		{
			var command = new SimpleTCLCommand("log_wave");
			_tcl.Add(command);
		}
		/// <summary>
		/// Turns on or off printing of file name and line number of the hdl statement being simulated
		/// </summary>
		public void ltrace()
		{
			var command = new SimpleTCLCommand("ltrace");
			_tcl.Add(command);
		}
		/// <summary>
		/// Moves the files from one fileset to another while maintaining all of their original properties.
		/// </summary>
		public void move_files()
		{
			var command = new SimpleTCLCommand("move_files");
			_tcl.Add(command);
		}
		/// <summary>
		/// Open file for storing signal switching rate for power estimation. The switching rate is written out
		/// in Switching Activity Interchange Format (SAIF) Only one SAIF is allowed to be open per
		/// simulation run.
		/// </summary>
		public void open_saif()
		{
			var command = new SimpleTCLCommand("open_saif");
			_tcl.Add(command);
		}
		/// <summary>
		/// Open a Value Change Dump (VCD) file for capturing simulation output. This Tcl command models
		/// behavior of $dumpfile Verilog system task
		/// </summary>
		public void open_vcd()
		{
			var command = new SimpleTCLCommand("open_vcd");
			_tcl.Add(command);
		}
		/// <summary>
		/// Open Waveform Database (WDB) file produced by a prior simulation run and return a simulation
		/// object
		/// </summary>
		public void open_wave_database()
		{
			var command = new SimpleTCLCommand("open_wave_database");
			_tcl.Add(command);
		}
		/// <summary>
		/// Turns on or off printing of name of the hdl process being simulated
		/// </summary>
		public void ptrace()
		{
			var command = new SimpleTCLCommand("ptrace");
			_tcl.Add(command);
		}
		/// <summary>
		/// Import simulation data in saif format
		/// </summary>
		public void read_saif()
		{
			var command = new SimpleTCLCommand("read_saif");
			_tcl.Add(command);
		}
		/// <summary>
		/// Recompile the design without changing compilation options and restart the current simulation
		/// </summary>
		public void relaunch_sim()
		{
			var command = new SimpleTCLCommand("relaunch_sim");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove breakpoints from a simulation
		/// </summary>
		public void remove_bps()
		{
			var command = new SimpleTCLCommand("remove_bps");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove conditions from a simulation. The names can be specified as Tcl glob pattern
		/// </summary>
		public void remove_conditions()
		{
			var command = new SimpleTCLCommand("remove_conditions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove files or directories from a fileset
		/// </summary>
		public void remove_files()
		{
			var command = new SimpleTCLCommand("remove_files");
			_tcl.Add(command);
		}
		/// <summary>
		/// Release force on signal, wire, or reg applied using 'add_force' command
		/// </summary>
		public void remove_forces()
		{
			var command = new SimpleTCLCommand("remove_forces");
			_tcl.Add(command);
		}
		/// <summary>
		/// Print details of the given breakpoint objects
		/// </summary>
		public void report_bps()
		{
			var command = new SimpleTCLCommand("report_bps");
			_tcl.Add(command);
		}
		/// <summary>
		/// Print details of the given condition objects
		/// </summary>
		public void report_conditions()
		{
			var command = new SimpleTCLCommand("report_conditions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Print drivers along with current driving values for an HDL wire or signal object
		/// </summary>
		public void report_drivers()
		{
			var command = new SimpleTCLCommand("report_drivers");
			_tcl.Add(command);
		}
		/// <summary>
		/// Print, in textual format, stack frames when current_scope is a process waiting inside subprogram
		/// </summary>
		public void report_frames()
		{
			var command = new SimpleTCLCommand("report_frames");
			_tcl.Add(command);
		}
		/// <summary>
		/// Print details of the given hdl objects (variable, signal, wire, or reg)
		/// </summary>
		public void report_objects()
		{
			var command = new SimpleTCLCommand("report_objects");
			_tcl.Add(command);
		}
		/// <summary>
		/// Print names of the children scopes (declarative regions) of given scope(s) or the current scope
		/// </summary>
		public void report_scopes()
		{
			var command = new SimpleTCLCommand("report_scopes");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report info of simulation libraries
		/// </summary>
		public void report_simlib_info()
		{
			var command = new SimpleTCLCommand("report_simlib_info");
			_tcl.Add(command);
		}
		/// <summary>
		/// Print names of processes in a design, which are waiting inside a subprogram, in textual format
		/// </summary>
		public void report_stacks()
		{
			var command = new SimpleTCLCommand("report_stacks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Print current simulated value of given HDL objects (variable, signal, wire, or reg)
		/// </summary>
		public void report_values()
		{
			var command = new SimpleTCLCommand("report_values");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reset an existing simulation run
		/// </summary>
		public void reset_simulation()
		{
			var command = new SimpleTCLCommand("reset_simulation");
			_tcl.Add(command);
		}
		/// <summary>
		/// Rewind simulation to post loading state (as if design was reloaded), time is set to 0
		/// </summary>
		public void restart()
		{
			var command = new SimpleTCLCommand("restart");
			_tcl.Add(command);
		}
		/// <summary>
		/// Run the simulation for the specified time
		/// </summary>
		public void run()
		{
			var command = new SimpleTCLCommand("run");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set the current value of an HDL object (variable, signal, wire, or reg) to a specified value
		/// </summary>
		public void set_value()
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
		/// </summary>
		public void setup_ip_static_library()
		{
			var command = new SimpleTCLCommand("setup_ip_static_library");
			_tcl.Add(command);
		}
		/// <summary>
		/// Start capturing VCD output (equivalent of $dumpon verilog system task). This can be used after a
		/// stop_vcd TCL command has stopped VCD generation started by open_vcd
		/// </summary>
		public void start_vcd()
		{
			var command = new SimpleTCLCommand("start_vcd");
			_tcl.Add(command);
		}
		/// <summary>
		/// Step simulation to the next statement
		/// </summary>
		public void step()
		{
			var command = new SimpleTCLCommand("step");
			_tcl.Add(command);
		}
		/// <summary>
		/// Use within a condition to tell simulation to stop when a condition is true
		/// </summary>
		public void stop()
		{
			var command = new SimpleTCLCommand("stop");
			_tcl.Add(command);
		}
		/// <summary>
		/// Stop capturing VCD output (equivalent of $dumpoff verilog system task). The start_vcd TCL
		/// command can be used to resume capturing VCD
		/// </summary>
		public void stop_vcd()
		{
			var command = new SimpleTCLCommand("stop_vcd");
			_tcl.Add(command);
		}
		/// <summary>
		/// write_sdf command generates flat sdf delay files for event simulation
		/// </summary>
		public void write_sdf()
		{
			var command = new SimpleTCLCommand("write_sdf");
			_tcl.Add(command);
		}
		/// <summary>
		/// Export the current netlist in Verilog format
		/// </summary>
		public void write_verilog()
		{
			var command = new SimpleTCLCommand("write_verilog");
			_tcl.Add(command);
		}
		/// <summary>
		/// Export the current netlist in VHDL format
		/// </summary>
		public void write_vhdl()
		{
			var command = new SimpleTCLCommand("write_vhdl");
			_tcl.Add(command);
		}
		/// <summary>
		/// Load a simulation snapshot for simulation and return a simulation object
		/// </summary>
		public void xsim()
		{
			var command = new SimpleTCLCommand("xsim");
			_tcl.Add(command);
		}
	}
}
