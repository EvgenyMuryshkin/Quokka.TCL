// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class IPIntegratorCommands
	{
		private readonly QuokkaTCL _tcl;
		public IPIntegratorCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Runs an automation rule on an IPI object.
		/// </summary>
		public void apply_bd_automation()
		{
			var command = new SimpleTCLCommand("apply_bd_automation");
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
		/// Automatically assign addresses to unmapped IP
		/// </summary>
		public void assign_bd_address()
		{
			var command = new SimpleTCLCommand("assign_bd_address");
			_tcl.Add(command);
		}
		/// <summary>
		/// Close a design.
		/// </summary>
		public void close_bd_design()
		{
			var command = new SimpleTCLCommand("close_bd_design");
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
		/// Connect intf_port and intf_pin list.
		/// </summary>
		public void connect_bd_intf_net()
		{
			var command = new SimpleTCLCommand("connect_bd_intf_net");
			_tcl.Add(command);
		}
		/// <summary>
		/// Connect port and pin object list.
		/// </summary>
		public void connect_bd_net()
		{
			var command = new SimpleTCLCommand("connect_bd_net");
			_tcl.Add(command);
		}
		/// <summary>
		/// Make copies of the objects and add the copies to the given hierarchical cell.
		/// </summary>
		public void copy_bd_objs()
		{
			var command = new SimpleTCLCommand("copy_bd_objs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new segment.
		/// </summary>
		public void create_bd_addr_seg()
		{
			var command = new SimpleTCLCommand("create_bd_addr_seg");
			_tcl.Add(command);
		}
		/// <summary>
		/// Add an IP cell from the IP catalog, or add a new hierarchical block.
		/// </summary>
		public void create_bd_cell()
		{
			var command = new SimpleTCLCommand("create_bd_cell");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new design and its top level hierarchy cell with the same name.
		/// </summary>
		public void create_bd_design()
		{
			var command = new SimpleTCLCommand("create_bd_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new intf_net.
		/// </summary>
		public void create_bd_intf_net()
		{
			var command = new SimpleTCLCommand("create_bd_intf_net");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new intf_pin.
		/// </summary>
		public void create_bd_intf_pin()
		{
			var command = new SimpleTCLCommand("create_bd_intf_pin");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new interface port.
		/// </summary>
		public void create_bd_intf_port()
		{
			var command = new SimpleTCLCommand("create_bd_intf_port");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new TLM interface port.
		/// </summary>
		public void create_bd_intf_tlm_port()
		{
			var command = new SimpleTCLCommand("create_bd_intf_tlm_port");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new net.
		/// </summary>
		public void create_bd_net()
		{
			var command = new SimpleTCLCommand("create_bd_net");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new pin.
		/// </summary>
		public void create_bd_pin()
		{
			var command = new SimpleTCLCommand("create_bd_pin");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new port for an IP subsystem design.
		/// </summary>
		public void create_bd_port()
		{
			var command = new SimpleTCLCommand("create_bd_port");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new TLM port for an IP subsystem design.
		/// </summary>
		public void create_bd_tlm_port()
		{
			var command = new SimpleTCLCommand("create_bd_tlm_port");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set or get current design.
		/// </summary>
		public void current_bd_design()
		{
			var command = new SimpleTCLCommand("current_bd_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set or get current cell instance.
		/// </summary>
		public void current_bd_instance()
		{
			var command = new SimpleTCLCommand("current_bd_instance");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete specified objects.
		/// </summary>
		public void delete_bd_objs()
		{
			var command = new SimpleTCLCommand("delete_bd_objs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Disconnect an intf_net.
		/// </summary>
		public void disconnect_bd_intf_net()
		{
			var command = new SimpleTCLCommand("disconnect_bd_intf_net");
			_tcl.Add(command);
		}
		/// <summary>
		/// Disconnect a net from the object.
		/// </summary>
		public void disconnect_bd_net()
		{
			var command = new SimpleTCLCommand("disconnect_bd_net");
			_tcl.Add(command);
		}
		/// <summary>
		/// Exclude segment from an address space.
		/// </summary>
		public void exclude_bd_addr_seg()
		{
			var command = new SimpleTCLCommand("exclude_bd_addr_seg");
			_tcl.Add(command);
		}
		/// <summary>
		/// Export current design as a static example design
		/// </summary>
		public void export_as_example_design()
		{
			var command = new SimpleTCLCommand("export_as_example_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Find a list of pins, ports or interfaces with a given relationship to the given object.
		/// </summary>
		public void find_bd_objs()
		{
			var command = new SimpleTCLCommand("find_bd_objs");
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
		/// Get a list of segments
		/// </summary>
		public void get_bd_addr_segs()
		{
			var command = new SimpleTCLCommand("get_bd_addr_segs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of addr_spaces
		/// </summary>
		public void get_bd_addr_spaces()
		{
			var command = new SimpleTCLCommand("get_bd_addr_spaces");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of block diagram cells
		/// </summary>
		public void get_bd_cells()
		{
			var command = new SimpleTCLCommand("get_bd_cells");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of designs
		/// </summary>
		public void get_bd_designs()
		{
			var command = new SimpleTCLCommand("get_bd_designs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of intf_nets
		/// </summary>
		public void get_bd_intf_nets()
		{
			var command = new SimpleTCLCommand("get_bd_intf_nets");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of intf_pins
		/// </summary>
		public void get_bd_intf_pins()
		{
			var command = new SimpleTCLCommand("get_bd_intf_pins");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of intf_ports
		/// </summary>
		public void get_bd_intf_ports()
		{
			var command = new SimpleTCLCommand("get_bd_intf_ports");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of nets
		/// </summary>
		public void get_bd_nets()
		{
			var command = new SimpleTCLCommand("get_bd_nets");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of pins
		/// </summary>
		public void get_bd_pins()
		{
			var command = new SimpleTCLCommand("get_bd_pins");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of ports
		/// </summary>
		public void get_bd_ports()
		{
			var command = new SimpleTCLCommand("get_bd_ports");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of registers
		/// </summary>
		public void get_bd_regs()
		{
			var command = new SimpleTCLCommand("get_bd_regs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of example designs
		/// </summary>
		public void get_example_designs()
		{
			var command = new SimpleTCLCommand("get_example_designs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of IPI example designs
		/// </summary>
		public void get_template_bd_designs()
		{
			var command = new SimpleTCLCommand("get_template_bd_designs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a hierarchical cell, and then move the group of cells into the hierarchy cell. The
		/// connections between these cells are maintained; the connections between these cells and other
		/// cells are maintained through crossing hierarchy cell.
		/// </summary>
		public void group_bd_cells()
		{
			var command = new SimpleTCLCommand("group_bd_cells");
			_tcl.Add(command);
		}
		/// <summary>
		/// include segment from an address space.
		/// </summary>
		public void include_bd_addr_seg()
		{
			var command = new SimpleTCLCommand("include_bd_addr_seg");
			_tcl.Add(command);
		}
		/// <summary>
		/// Creates an example design from a predefined template in an open project.
		/// </summary>
		public void instantiate_example_design()
		{
			var command = new SimpleTCLCommand("instantiate_example_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Creates a block design in IP integrator from a predefined template.
		/// </summary>
		public void instantiate_template_bd_design()
		{
			var command = new SimpleTCLCommand("instantiate_template_bd_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create external port for the corresponding interface pins. If a cell is specified, create external
		/// interface ports for all unconnected interface pins.
		/// </summary>
		public void make_bd_intf_pins_external()
		{
			var command = new SimpleTCLCommand("make_bd_intf_pins_external");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create external port for the corresponding pin. If a cell is specified, create external ports for all
		/// unconnected pins.
		/// </summary>
		public void make_bd_pins_external()
		{
			var command = new SimpleTCLCommand("make_bd_pins_external");
			_tcl.Add(command);
		}
		/// <summary>
		/// Move cells into a hierarchy cell. The connections between these cells are maintained; the
		/// connections between these cells and other cells are maintained through crossing hierarchy cell.
		/// </summary>
		public void move_bd_cells()
		{
			var command = new SimpleTCLCommand("move_bd_cells");
			_tcl.Add(command);
		}
		/// <summary>
		/// Open an existing IP subsystem design from disk file.
		/// </summary>
		public void open_bd_design()
		{
			var command = new SimpleTCLCommand("open_bd_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Read one or more IPIntegrator design files
		/// </summary>
		public void read_bd()
		{
			var command = new SimpleTCLCommand("read_bd");
			_tcl.Add(command);
		}
		/// <summary>
		/// Regenerate layout.
		/// </summary>
		public void regenerate_bd_layout()
		{
			var command = new SimpleTCLCommand("regenerate_bd_layout");
			_tcl.Add(command);
		}
		/// <summary>
		/// Replace cell1 with cell2 by disconnecting connections to cell1 and connecting those connections
		/// to cell2.
		/// </summary>
		public void replace_bd_cell()
		{
			var command = new SimpleTCLCommand("replace_bd_cell");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report differences between two block designs. Note this TCL command may compare bus￾interface parameters from IP .xit files that are not reported in the stand-alone diffbd executable.
		/// </summary>
		public void report_bd_diffs()
		{
			var command = new SimpleTCLCommand("report_bd_diffs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Save an existing IP subsystem design to disk file.
		/// </summary>
		public void save_bd_design()
		{
			var command = new SimpleTCLCommand("save_bd_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Save a copy of the existing IP subsystem design to specified disk file with a different name.
		/// Generated output products will not be saved.
		/// </summary>
		public void save_bd_design_as()
		{
			var command = new SimpleTCLCommand("save_bd_design_as");
			_tcl.Add(command);
		}
		/// <summary>
		/// Move the group of cells inside a hierarchy cell to its parent cell, and then remove the hierarchical
		/// cell. The connections between these cells are maintained; the connections between these cells
		/// and other cells are maintained through crossing hierarchy cell.
		/// </summary>
		public void ungroup_bd_cells()
		{
			var command = new SimpleTCLCommand("ungroup_bd_cells");
			_tcl.Add(command);
		}
		/// <summary>
		/// Upgrade configurable IPIntegrator cell(s) to later version
		/// </summary>
		public void upgrade_bd_cells()
		{
			var command = new SimpleTCLCommand("upgrade_bd_cells");
			_tcl.Add(command);
		}
		/// <summary>
		/// Run Parameter Propagation for specified design or for a specific cell.
		/// </summary>
		public void validate_bd_design()
		{
			var command = new SimpleTCLCommand("validate_bd_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Export the current design to a Tcl file on disk.
		/// </summary>
		public void write_bd_tcl()
		{
			var command = new SimpleTCLCommand("write_bd_tcl");
			_tcl.Add(command);
		}
	}
}
