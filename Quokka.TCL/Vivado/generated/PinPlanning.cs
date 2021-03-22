// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class PinPlanningCommands
	{
		private readonly QuokkaTCL _tcl;
		public PinPlanningCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Create a new I/O port interface
		///
		/// Creates a new interface for grouping scalar or differential I/O ports.
		///
		/// Create a new USB interface:
		/// create_interface USB0
		/// Create an Ethernet interface within the specified parent interface:
		/// create_interface -parent Top_Int ENET0
		///
		/// See ug835-vivado-tcl-commands.pdf, page 305
		/// </summary>
		/// <param name="name">
		/// Required
		/// Name for new I/O port interface
		/// </param>
		/// <param name="parent">
		/// Optional
		/// Assign new interface to this parent interface
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>new interface object</returns>
		public void create_interface(string name, string parent = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("create_interface");
			command.OptionalString("parent", parent);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("name", name);
			_tcl.Add(command);
		}
		/// <summary>
		/// Create scalar or bus port
		///
		/// Creates a port and specifies such parameters as direction, width, single-ended or differential, and
		/// optionally assigns it to an existing interface. New ports are added at the top-level of the design
		/// hierarchy.
		/// Bus ports can be created with increasing or decreasing bus indexes, using negative and positive
		/// index values.
		/// The create_port command can be used to create a new port in an I/O Planning project, or
		/// while editing the netlist of an open Synthesized or Implemented design.
		/// Netlist editing changes the in-memory view of the netlist in the current design. It does not
		/// change the files in the source fileset, or change the persistent design on the disk. Changes made
		/// to the netlist may be saved to a design checkpoint using the write_checkpoint command, or
		/// may be exported to a netlist file such as Verilog, VHDL, or EDIF, using the appropriate write_*
		/// command.
		/// Note: Netlist editing is not allowed on the elaborated RTL design.
		///
		/// The following example creates a new input port, named PORT0:
		/// create_port -direction IN PORT0
		/// The following example creates a new interface called Group1, and then creates a four-bit,
		/// differential pair output bus using the specified interface. Since the bus ports are defined as
		/// differential pairs, and only <name> is specified, the negative side ports are automatically named
		/// D_BUS_N:
		/// create_interface Group1
		/// create_port -direction OUT -from 0 -to 3 -diff_pair -interface Group1 D_BUS
		/// Note: This command results in the creation of eight ports: D_BUS[0] D_BUS_N[0] D_BUS[1] D_BUS_N[1]
		/// D_BUS[2] D_BUS_N[2] D_BUS[3] D_BUS_N[3]
		/// With only <name> specified, the following example creates differential pair output ports named
		/// data and data_N.
		/// create_port -direction OUT -diff_pair data
		/// With both <name> and <negative_name> specified, the following example creates differential
		/// pair output ports named data_P and data_N.
		/// create_port -direction OUT -diff_pair data_P data_N
		///
		/// See ug835-vivado-tcl-commands.pdf, page 326
		/// </summary>
		/// <param name="direction">
		/// Required
		/// Direction of port. Valid arguments are IN, OUT and INOUT
		/// </param>
		/// <param name="name">
		/// Required
		/// Name of the port
		/// </param>
		/// <param name="from">
		/// Optional
		/// Beginning index of new bus
		/// </param>
		/// <param name="to">
		/// Optional
		/// Ending index of new bus
		/// </param>
		/// <param name="diff_pair">
		/// Optional
		/// Create differential pair of ports
		/// </param>
		/// <param name="interface">
		/// Optional
		/// Assign new port to this interface
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="negative_name">
		/// Optional
		/// Optional negative name of a diff-pair
		/// </param>
		/// <returns>list of port objects that were created</returns>
		public void create_port(string direction, string name, string from = null, string to = null, bool? diff_pair = null, string interface = null, bool? quiet = null, bool? verbose = null, string negative_name = null)
		{
			var command = new SimpleTCLCommand("create_port");
			command.RequiredString("direction", direction);
			command.OptionalString("from", from);
			command.OptionalString("to", to);
			command.Flag("diff_pair", diff_pair);
			command.OptionalString("interface", interface);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("name", name);
			command.OptionalString("negative_name", negative_name);
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete I/O port interfaces from the project
		///
		/// Deletes an existing interface and optionally deletes all of the associated ports and buses using
		/// the interface.
		///
		/// The following example deletes the specified interface and all of its associated ports and buses:
		/// delete_interface USB0
		///
		/// See ug835-vivado-tcl-commands.pdf, page 444
		/// </summary>
		/// <param name="interfaces">
		/// Required
		/// I/O port interfaces to remove
		/// </param>
		/// <param name="all">
		/// Optional
		/// Also remove all of the ports and buses belonging to the
		/// interface
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void delete_interface(string interfaces, bool? all = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("delete_interface");
			command.Flag("all", all);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("interfaces", interfaces);
			_tcl.Add(command);
		}
		/// <summary>
		/// Make differential pair for 2 ports
		///
		/// Joins two existing ports to create a differential pair. The port directions, interfaces, and other
		/// properties must match in order for the specified ports to be joined as a differential pair.
		/// Otherwise an error will be returned.
		/// IMPORTANT! The two ports must first be created, either by using the create_port command or by reading
		/// in an XDC file, prior to making them into a differential pair.
		///
		/// The following example joins the two specified ports to create a differential pair:
		/// make_diff_pair_ports port_Pos1 port_Neg1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1034
		/// </summary>
		/// <param name="ports">
		/// Required
		/// Ports to join
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void make_diff_pair_ports(string ports, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("make_diff_pair_ports");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("ports", ports);
			_tcl.Add(command);
		}
		/// <summary>
		/// Automatically place a set of ports
		///
		/// Assign ports to the pins of the Xilinx FPGA package, by automatically or manually placing ports.
		/// • Automatically places ports on an available I/O or clocking site, or into the specified I/O banks.
		/// • Manually assigns ports to the specified package_pin when both the port and pin are specified.
		/// The place_ports command will not replace ports that are currently placed by the user, or
		/// ports that are placed and fixed.
		/// Note: This command operates silently and does not return direct feedback of its operation.
		///
		/// The following example places the port objects returned by the get_ports command, onto I/O
		/// bank 13 of the device, as returned by get_iobanks:
		/// place_ports -iobank [get_iobanks 13] [get_ports DataOut_pad_1_o]
		/// The follow example uses port_name package_pin pairs to manually place multiple ports:
		/// place_ports {LEDS_n[2] AA11 LEDS_n[3] AA10 LEDS_n[0] Y11 LEDS_n[1] Y10}
		/// The following example places all input ports onto I/O banks 12, 13, 14 and 15 of the device:
		/// place_ports -iobank [get_iobanks {12 13 14 15}] [all_inputs]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1108
		/// </summary>
		/// <param name="skip_unconnected_ports">
		/// Optional
		/// Do not place unconnected ports
		/// </param>
		/// <param name="check_only">
		/// Optional
		/// Only check IO/Clock placement DRCs
		/// </param>
		/// <param name="iobank">
		/// Optional
		/// Limit placement to the following banks
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="ports">
		/// Optional
		/// Ports to place (if omitted, all ports will be placed). If the
		/// arguments are interleaved objects of ports and package
		/// pins, then manual placement is performed
		/// </param>
		public void place_ports(bool? skip_unconnected_ports = null, bool? check_only = null, string iobank = null, bool? quiet = null, bool? verbose = null, string ports = null)
		{
			var command = new SimpleTCLCommand("place_ports");
			command.Flag("skip_unconnected_ports", skip_unconnected_ports);
			command.Flag("check_only", check_only);
			command.OptionalString("iobank", iobank);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("ports", ports);
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove the given list of top ports from the netlist.
		///
		/// Removes the specified ports or buses.
		/// To remove a bus port, you must specify the primary port name, and not specify a bus index. This
		/// ensures that the entire bus port is removed, and not just a portion of the bits associated with the
		/// bus. You can resize a bus port, eliminating bits, using the resize_port_bus command.
		/// The remove_port command will remove ports that have been added with the create_port
		/// command, but cannot delete ports that are defined in the RTL or netlist design.
		/// Netlist editing changes the in-memory view of the netlist in the current design. It does not
		/// change the files in the source fileset, or change the persistent design on the disk. Changes made
		/// to the netlist may be saved to a design checkpoint using the write_checkpoint command, or
		/// may be exported to a netlist file such as Verilog, VHDL, or EDIF, using the appropriate write_*
		/// command.
		/// Note: Netlist editing is not allowed on the elaborated RTL design.
		///
		/// The following example deletes the specified port:
		/// remove_port PORT0
		/// The following example deletes the two specified ports of a bus:
		/// remove_port BUS[1] BUS[2]
		/// The following example deletes both the N and P sides of a differential pair port:
		/// remove_port D_BUS_P[0]
		/// Note: Deleting either the N or the P side of a differential pair will also delete the other side of the pair.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1245
		/// </summary>
		/// <param name="ports">
		/// Required
		/// Ports and/or bus ports to remove
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void remove_port(string ports, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("remove_port");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("ports", ports);
			_tcl.Add(command);
		}
		/// <summary>
		/// Resize port bus in the current design
		///
		/// Resize an existing bus port, to grow the bus, shrink the bus, or renumber the current range of
		/// port indexes. You can only do a single grow, shrink, or renumber operation with each command.
		/// • You can grow the bus by indicating a new range of port indexes outside the current range of
		/// indexes. Growing the bus leaves existing port indexes connected as they currently are.
		/// • You can shrink the bus by indicating a new range of port indexes inside the current range of
		/// indexes. Shrinking the bus, eliminates connections to removed bus ports, but leaves the
		/// remaining ports connected as they currently are.
		/// • You can renumber the current bus indexes by providing a new range of port indexes with the
		/// same width as the current range. Renumbering ports changes the port index, but does not
		/// otherwise change connections.
		/// Netlist editing changes the in-memory view of the netlist in the current design. It does not
		/// change the files in the source fileset, or change the persistent design on the disk. Changes made
		/// to the netlist may be saved to a design checkpoint using the write_checkpoint command, or
		/// may be exported to a netlist file such as Verilog, VHDL, or EDIF, using the appropriate write_*
		/// command.
		/// Note: Netlist editing is not allowed on the elaborated RTL design.
		/// This command returns nothing if successful, and returns an error if it fails.
		///
		/// The following example creates a 32-bit output bus port, then renumbers the ports to include
		/// negative bus indexes, then shrinks the bus width from 32-bits to 16-bits:
		/// create_port -direction out -from 0 -to 31 outPorts
		/// resize_port_bus -from -16 -to 15 outPorts
		/// resize_port_bus -from -8 -to 7 outPorts
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1500
		/// </summary>
		/// <param name="port_bus_name">
		/// Required
		/// Name of the port bus to resize
		/// </param>
		/// <param name="from">
		/// Optional
		/// New starting bus index
		/// </param>
		/// <param name="to">
		/// Optional
		/// New ending bus index
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void resize_port_bus(string port_bus_name, string from = null, string to = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("resize_port_bus");
			command.OptionalString("from", from);
			command.OptionalString("to", to);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("port_bus_name", port_bus_name);
			_tcl.Add(command);
		}
		/// <summary>
		/// Set user columns on one or more package pins
		///
		/// Create user-defined package pin attributes and assign values to specific pins on the package.
		/// User-defined pin attributes can be defined in a CSV file and imported into an I/O Pin Planning
		/// project using read_csv, or can be edited in the project using this command.
		/// Note: Use the set_property command to set tool-defined properties of a package pin.
		///
		/// The following example creates a new user-defined column in the Package Pins view, and assigns
		/// the value true to the specified pin:
		/// set_package_pin_val -column track1 -value true -package_pins AK27
		/// The following example creates a user-defined column called Test, then assigns the value RED to
		/// all "AK" package pins, then changes the value to GREEN for the three specified pins:
		/// set_package_pin_val -column Test -value RED \
		/// -package_pins [get_package_pins AK*]
		/// set_package_pin_val -column Test -value GREEN \
		/// -package_pins {AK1 AK2 AK3}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1637
		/// </summary>
		/// <param name="column">
		/// Required
		/// User column name
		/// </param>
		/// <param name="value">
		/// Required
		/// Value to set
		/// </param>
		/// <param name="package_pins">
		/// Required
		/// Package pin names
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_package_pin_val(string column, string value, string package_pins, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_package_pin_val");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("column", column);
			command.RequiredString("value", value);
			command.RequiredString("package_pins", package_pins);
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove differential pair relationship between 2 ports
		///
		/// Splits an existing differential pair of ports into two single-ended ports.
		/// Note: This command operates silently and does not return direct feedback of its operation.
		///
		/// The following example splits the specified diff pair ports to form two single ended ports:
		/// split_diff_pair_ports PORT_N PORT_P
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1678
		/// </summary>
		/// <param name="ports">
		/// Required
		/// Ports to split
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void split_diff_pair_ports(string ports, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("split_diff_pair_ports");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("ports", ports);
			_tcl.Add(command);
		}
	}
}
