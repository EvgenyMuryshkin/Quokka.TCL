// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class IPFlowCommands
	{
		private readonly QuokkaTCL _tcl;
		public IPFlowCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
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
		/// Compile C code into RTL
		/// </summary>
		public void compile_c()
		{
			var command = new SimpleTCLCommand("compile_c");
			_tcl.Add(command);
		}
		/// <summary>
		/// Manage the IP instance Synthesis cache. Lists out the IP Cache entries if no options are specified.
		/// </summary>
		public void config_ip_cache()
		{
			var command = new SimpleTCLCommand("config_ip_cache");
			_tcl.Add(command);
		}
		/// <summary>
		/// Convert specified IP to or from core container format.
		/// </summary>
		public void convert_ips()
		{
			var command = new SimpleTCLCommand("convert_ips");
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
		/// Create an instance of a configurable IP and add it to the fileset
		/// </summary>
		public void create_ip()
		{
			var command = new SimpleTCLCommand("create_ip");
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
		/// Deletes the block fileset and run associated with a given IP.
		/// </summary>
		public void delete_ip_run()
		{
			var command = new SimpleTCLCommand("delete_ip_run");
			_tcl.Add(command);
		}
		/// <summary>
		/// Extract files from a core container to disk
		/// </summary>
		public void extract_files()
		{
			var command = new SimpleTCLCommand("extract_files");
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
		/// Get a list of results for IP upgrades during the current project
		/// </summary>
		public void get_ip_upgrade_results()
		{
			var command = new SimpleTCLCommand("get_ip_upgrade_results");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of IP from the current IP Catalog
		/// </summary>
		public void get_ipdefs()
		{
			var command = new SimpleTCLCommand("get_ipdefs");
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
		/// Import an IP file and add it to the fileset
		/// </summary>
		public void import_ip()
		{
			var command = new SimpleTCLCommand("import_ip");
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
		/// Read one or more IP files
		/// </summary>
		public void read_ip()
		{
			var command = new SimpleTCLCommand("read_ip");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report on the status of the IP instances in the project.
		/// </summary>
		public void report_ip_status()
		{
			var command = new SimpleTCLCommand("report_ip_status");
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
		/// Generate a synthesis netlist for an IP
		/// </summary>
		public void synth_ip()
		{
			var command = new SimpleTCLCommand("synth_ip");
			_tcl.Add(command);
		}
		/// <summary>
		/// Update the IP Catalog. Before executing this command optionally use the following to set
		/// repository paths:'set_property ip_repo_paths <repo_path_list> [current_fileset]'
		/// </summary>
		public void update_ip_catalog()
		{
			var command = new SimpleTCLCommand("update_ip_catalog");
			_tcl.Add(command);
		}
		/// <summary>
		/// Refresh module reference definition and instance(s)
		/// </summary>
		public void update_module_reference()
		{
			var command = new SimpleTCLCommand("update_module_reference");
			_tcl.Add(command);
		}
		/// <summary>
		/// Upgrade a configurable IP to a later version
		/// </summary>
		public void upgrade_ip()
		{
			var command = new SimpleTCLCommand("upgrade_ip");
			_tcl.Add(command);
		}
		/// <summary>
		/// This command applies any pending set_property commands and returns parameter validation
		/// messages, if any exist
		/// </summary>
		public void validate_ip()
		{
			var command = new SimpleTCLCommand("validate_ip");
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
