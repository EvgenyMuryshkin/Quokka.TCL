// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class ProjectCommands
	{
		private readonly QuokkaTCL _tcl;
		public ProjectCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
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
		/// Add a new bus interface to a peripheral.
		/// </summary>
		public void add_peripheral_interface()
		{
			var command = new SimpleTCLCommand("add_peripheral_interface");
			_tcl.Add(command);
		}
		/// <summary>
		/// Applies board connections to given designs
		/// </summary>
		public void apply_board_connection()
		{
			var command = new SimpleTCLCommand("apply_board_connection");
			_tcl.Add(command);
		}
		/// <summary>
		/// Archive the current project
		/// </summary>
		public void archive_project()
		{
			var command = new SimpleTCLCommand("archive_project");
			_tcl.Add(command);
		}
		/// <summary>
		/// Auto detect the XPM Libraries that are used in the design and set the XPM_LIBRARIES project
		/// property.
		/// </summary>
		public void auto_detect_xpm()
		{
			var command = new SimpleTCLCommand("auto_detect_xpm");
			_tcl.Add(command);
		}
		/// <summary>
		/// Check if a module can be referenced
		/// </summary>
		public void can_resolve_reference()
		{
			var command = new SimpleTCLCommand("can_resolve_reference");
			_tcl.Add(command);
		}
		/// <summary>
		/// Check HDL syntax in the supplied fileset or active fileset.
		/// </summary>
		public void check_syntax()
		{
			var command = new SimpleTCLCommand("check_syntax");
			_tcl.Add(command);
		}
		/// <summary>
		/// Close the current design
		/// </summary>
		public void close_design()
		{
			var command = new SimpleTCLCommand("close_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Close current opened project
		/// </summary>
		public void close_project()
		{
			var command = new SimpleTCLCommand("close_project");
			_tcl.Add(command);
		}
		/// <summary>
		/// Compile C code into RTL
		/// </summary>
		public void compile_c()
		{
			var command = new SimpleTCLCommand("compile_c");
			_tcl.Add(command);
		}
		/// <summary>
		/// Copy an existing IP
		/// </summary>
		public void copy_ip()
		{
			var command = new SimpleTCLCommand("copy_ip");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create the Gadget for Project summary dashboard
		/// </summary>
		public void create_dashboard_gadget()
		{
			var command = new SimpleTCLCommand("create_dashboard_gadget");
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
		/// Creates a run for the given IP.
		/// </summary>
		public void create_ip_run()
		{
			var command = new SimpleTCLCommand("create_ip_run");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a peripheral with a VLNV.
		/// </summary>
		public void create_peripheral()
		{
			var command = new SimpleTCLCommand("create_peripheral");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new project
		/// </summary>
		public void create_project()
		{
			var command = new SimpleTCLCommand("create_project");
			_tcl.Add(command);
		}
		/// <summary>
		/// Define a synthesis or implementation run for the current project
		/// </summary>
		public void create_run()
		{
			var command = new SimpleTCLCommand("create_run");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create embedded source for XPS and add to the source fileset (Not supported anymore. Please
		/// use Vivado IP integrator.)
		/// </summary>
		public void create_xps()
		{
			var command = new SimpleTCLCommand("create_xps");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the current board_part object
		/// </summary>
		public void current_board_part()
		{
			var command = new SimpleTCLCommand("current_board_part");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the current fileset (any type) or set the current fileset (applicable to simulation filesets only)
		/// </summary>
		public void current_fileset()
		{
			var command = new SimpleTCLCommand("current_fileset");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set or get current project
		/// </summary>
		public void current_project()
		{
			var command = new SimpleTCLCommand("current_project");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set or get the current run
		/// </summary>
		public void current_run()
		{
			var command = new SimpleTCLCommand("current_run");
			_tcl.Add(command);
		}
		/// <summary>
		/// Deletes the gadgets from project summary dashboard
		/// </summary>
		public void delete_dashboard_gadgets()
		{
			var command = new SimpleTCLCommand("delete_dashboard_gadgets");
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
		/// Deletes the block fileset and run associated with a given IP.
		/// </summary>
		public void delete_ip_run()
		{
			var command = new SimpleTCLCommand("delete_ip_run");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete existing runs
		/// </summary>
		public void delete_runs()
		{
			var command = new SimpleTCLCommand("delete_runs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Find top module candidates in the supplied files, fileset, or active fileset. Returns a rank ordered
		/// list of candidates.
		/// </summary>
		public void find_top()
		{
			var command = new SimpleTCLCommand("find_top");
			_tcl.Add(command);
		}
		/// <summary>
		/// Generate output products for peripheral object.
		/// </summary>
		public void generate_peripheral()
		{
			var command = new SimpleTCLCommand("generate_peripheral");
			_tcl.Add(command);
		}
		/// <summary>
		/// Generate target data for the specified source
		/// </summary>
		public void generate_target()
		{
			var command = new SimpleTCLCommand("generate_target");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the list of board_part available in the project
		/// </summary>
		public void get_board_parts()
		{
			var command = new SimpleTCLCommand("get_board_parts");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the list of boards available in the project
		/// </summary>
		public void get_boards()
		{
			var command = new SimpleTCLCommand("get_boards");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create the Project summary dashboard
		/// </summary>
		public void get_dashboard_gadgets()
		{
			var command = new SimpleTCLCommand("get_dashboard_gadgets");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of source files
		/// </summary>
		public void get_files()
		{
			var command = new SimpleTCLCommand("get_files");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of filesets in the current project
		/// </summary>
		public void get_filesets()
		{
			var command = new SimpleTCLCommand("get_filesets");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of results for IP upgrades during the current project
		/// </summary>
		public void get_ip_upgrade_results()
		{
			var command = new SimpleTCLCommand("get_ip_upgrade_results");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of IPs in the current design
		/// </summary>
		public void get_ips()
		{
			var command = new SimpleTCLCommand("get_ips");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of projects
		/// </summary>
		public void get_projects()
		{
			var command = new SimpleTCLCommand("get_projects");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of runs
		/// </summary>
		public void get_runs()
		{
			var command = new SimpleTCLCommand("get_runs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Display help for one or more topics
		/// </summary>
		public void help()
		{
			var command = new SimpleTCLCommand("help");
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
		/// Import an IP file and add it to the fileset
		/// </summary>
		public void import_ip()
		{
			var command = new SimpleTCLCommand("import_ip");
			_tcl.Add(command);
		}
		/// <summary>
		/// Imports the given Synplify project file
		/// </summary>
		public void import_synplify()
		{
			var command = new SimpleTCLCommand("import_synplify");
			_tcl.Add(command);
		}
		/// <summary>
		/// Import XISE project file settings into the created project
		/// </summary>
		public void import_xise()
		{
			var command = new SimpleTCLCommand("import_xise");
			_tcl.Add(command);
		}
		/// <summary>
		/// Imports the given XST project file
		/// </summary>
		public void import_xst()
		{
			var command = new SimpleTCLCommand("import_xst");
			_tcl.Add(command);
		}
		/// <summary>
		/// Launch a set of runs
		/// </summary>
		public void launch_runs()
		{
			var command = new SimpleTCLCommand("launch_runs");
			_tcl.Add(command);
		}
		/// <summary>
		/// List applicable targets for the specified source
		/// </summary>
		public void list_targets()
		{
			var command = new SimpleTCLCommand("list_targets");
			_tcl.Add(command);
		}
		/// <summary>
		/// Locks or unlocks netlist, placement or routing of a design. The 'lock/unlock' will only applied on
		/// physically placed cells and routed nets
		/// </summary>
		public void lock_design()
		{
			var command = new SimpleTCLCommand("lock_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Generate HDL wrapper for the specified source
		/// </summary>
		public void make_wrapper()
		{
			var command = new SimpleTCLCommand("make_wrapper");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reposition the Gadget for Project summary dashboard
		/// </summary>
		public void move_dashboard_gadget()
		{
			var command = new SimpleTCLCommand("move_dashboard_gadget");
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
		/// Open a design checkpoint in a new project
		/// </summary>
		public void open_checkpoint()
		{
			var command = new SimpleTCLCommand("open_checkpoint");
			_tcl.Add(command);
		}
		/// <summary>
		/// Open the example project for the indicated IP
		/// </summary>
		public void open_example_project()
		{
			var command = new SimpleTCLCommand("open_example_project");
			_tcl.Add(command);
		}
		/// <summary>
		/// Open an IO design
		/// </summary>
		public void open_io_design()
		{
			var command = new SimpleTCLCommand("open_io_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Open a Vivado project file (.xpr)
		/// </summary>
		public void open_project()
		{
			var command = new SimpleTCLCommand("open_project");
			_tcl.Add(command);
		}
		/// <summary>
		/// Open a run into a netlist or implementation design
		/// </summary>
		public void open_run()
		{
			var command = new SimpleTCLCommand("open_run");
			_tcl.Add(command);
		}
		/// <summary>
		/// Refresh the current design
		/// </summary>
		public void refresh_design()
		{
			var command = new SimpleTCLCommand("refresh_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Update and initialize the BRAM initialization strings with contents of elf files.
		/// </summary>
		public void refresh_meminit()
		{
			var command = new SimpleTCLCommand("refresh_meminit");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reimport files when they are found out-of-date
		/// </summary>
		public void reimport_files()
		{
			var command = new SimpleTCLCommand("reimport_files");
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
		/// Change the order of source files in the active fileset
		/// </summary>
		public void reorder_files()
		{
			var command = new SimpleTCLCommand("reorder_files");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report the compile order by analyzing files and constructing a hierarchy.
		/// </summary>
		public void report_compile_order()
		{
			var command = new SimpleTCLCommand("report_compile_order");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reset current project
		/// </summary>
		public void reset_project()
		{
			var command = new SimpleTCLCommand("reset_project");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reset an existing run
		/// </summary>
		public void reset_runs()
		{
			var command = new SimpleTCLCommand("reset_runs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reset target data for the specified source
		/// </summary>
		public void reset_target()
		{
			var command = new SimpleTCLCommand("reset_target");
			_tcl.Add(command);
		}
		/// <summary>
		/// Save the current design's constraints
		/// </summary>
		public void save_constraints()
		{
			var command = new SimpleTCLCommand("save_constraints");
			_tcl.Add(command);
		}
		/// <summary>
		/// Save current design's constraints as a new set of constraints files
		/// </summary>
		public void save_constraints_as()
		{
			var command = new SimpleTCLCommand("save_constraints_as");
			_tcl.Add(command);
		}
		/// <summary>
		/// Save the current project under a new name
		/// </summary>
		public void save_project_as()
		{
			var command = new SimpleTCLCommand("save_project_as");
			_tcl.Add(command);
		}
		/// <summary>
		/// Sets the part on the current project. If no project is open, then a diskless project is created.
		/// </summary>
		public void set_part()
		{
			var command = new SimpleTCLCommand("set_part");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set Timing Speed Grade and Temperature Grade
		/// </summary>
		public void set_speed_grade()
		{
			var command = new SimpleTCLCommand("set_speed_grade");
			_tcl.Add(command);
		}
		/// <summary>
		/// Generate a synthesis netlist for an IP
		/// </summary>
		public void synth_ip()
		{
			var command = new SimpleTCLCommand("synth_ip");
			_tcl.Add(command);
		}
		/// <summary>
		/// Updates a fileset compile order and possibly top based on a design graph.
		/// </summary>
		public void update_compile_order()
		{
			var command = new SimpleTCLCommand("update_compile_order");
			_tcl.Add(command);
		}
		/// <summary>
		/// update the netlist of the current design
		/// </summary>
		public void update_design()
		{
			var command = new SimpleTCLCommand("update_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Update file(s) in the project based on the file(s) or directory(ies) specified
		/// </summary>
		public void update_files()
		{
			var command = new SimpleTCLCommand("update_files");
			_tcl.Add(command);
		}
		/// <summary>
		/// Update the dcp by adding the generated sw param info files to it
		/// </summary>
		public void update_sw_parameters()
		{
			var command = new SimpleTCLCommand("update_sw_parameters");
			_tcl.Add(command);
		}
		/// <summary>
		/// Block execution of further Tcl commands until the specified run completes.
		/// </summary>
		public void wait_on_run()
		{
			var command = new SimpleTCLCommand("wait_on_run");
			_tcl.Add(command);
		}
		/// <summary>
		/// Writes hardware definition for use in the software development
		/// </summary>
		public void write_hwdef()
		{
			var command = new SimpleTCLCommand("write_hwdef");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write a tcl script on disk that will recreate a given IP.
		/// </summary>
		public void write_ip_tcl()
		{
			var command = new SimpleTCLCommand("write_ip_tcl");
			_tcl.Add(command);
		}
		/// <summary>
		/// Save peripheral component to the disk.
		/// </summary>
		public void write_peripheral()
		{
			var command = new SimpleTCLCommand("write_peripheral");
			_tcl.Add(command);
		}
	}
}
