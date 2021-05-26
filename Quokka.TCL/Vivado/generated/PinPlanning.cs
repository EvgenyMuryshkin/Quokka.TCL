#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class PinPlanningCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public PinPlanningCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// <para>
		/// Create a new I/O port interface<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_interface [-parent &lt;arg&gt;] [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Creates a new interface for grouping scalar or differential I/O ports.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// Create a new USB interface:<br/>
		/// create_interface USB0<br/>
		/// Create an Ethernet interface within the specified parent interface:<br/>
		/// create_interface -parent Top_Int ENET0<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 314<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name for new I/O port interface</param>
		/// <param name="parent">(Optional) Assign new interface to this parent interface</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>new interface object</returns>
		public TTCL create_interface(TCLObject name, String parent = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_interface [-parent <arg>] [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_interface(name, parent, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create scalar or bus port<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_port -direction &lt;arg&gt; [-from &lt;arg&gt;] [-to &lt;arg&gt;] [-diff_pair] [-interface &lt;arg&gt;] [-quiet] [-verbose] &lt;name&gt; [&lt;negative_name&gt;]
		/// <br/>
		/// <para>
		/// Creates a port and specifies such parameters as direction, width, single-ended or differential, and<br/>
		/// optionally assigns it to an existing interface. New ports are added at the top-level of the design<br/>
		/// hierarchy.<br/>
		/// Bus ports can be created with increasing or decreasing bus indexes, using negative and positive<br/>
		/// index values.<br/>
		/// The create_port command can be used to create a new port in an I/O Planning project, or<br/>
		/// while editing the netlist of an open Synthesized or Implemented design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Netlist editing changes the in-memory view of the netlist in the current design. It does not<br/>
		/// change the files in the source fileset, or change the persistent design on the disk. Changes made<br/>
		/// to the netlist may be saved to a design checkpoint using the write_checkpoint command, or<br/>
		/// may be exported to a netlist file such as Verilog, VHDL, or EDIF, using the appropriate write_*<br/>
		/// command.<br/>
		/// Note: Netlist editing is not allowed on the elaborated RTL design.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a new input port, named PORT0:<br/>
		/// create_port -direction IN PORT0<br/>
		/// The following example creates a new interface called Group1, and then creates a four-bit,<br/>
		/// differential pair output bus using the specified interface. Since the bus ports are defined as<br/>
		/// differential pairs, and only &lt;name&gt; is specified, the negative side ports are automatically named<br/>
		/// D_BUS_N:<br/>
		/// create_interface Group1<br/>
		/// create_port -direction OUT -from 0 -to 3 -diff_pair -interface Group1 D_BUS<br/>
		/// Note: This command results in the creation of eight ports: D_BUS[0] D_BUS_N[0] D_BUS[1] D_BUS_N[1]<br/>
		/// D_BUS[2] D_BUS_N[2] D_BUS[3] D_BUS_N[3]<br/>
		/// With only &lt;name&gt; specified, the following example creates differential pair output ports named<br/>
		/// data and data_N.<br/>
		/// create_port -direction OUT -diff_pair data<br/>
		/// With both &lt;name&gt; and &lt;negative_name&gt; specified, the following example creates differential<br/>
		/// pair output ports named data_P and data_N.<br/>
		/// create_port -direction OUT -diff_pair data_P data_N<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 335<br/>
		/// </para>
		/// </summary>
		/// <param name="direction">(Required) Direction of port. Valid arguments are IN, OUT and INOUT</param>
		/// <param name="name">(Required) Name of the port</param>
		/// <param name="from">(Optional) Beginning index of new bus</param>
		/// <param name="to">(Optional) Ending index of new bus</param>
		/// <param name="diff_pair">(Optional) Create differential pair of ports</param>
		/// <param name="interface">(Optional) Assign new port to this interface</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="negative_name">(Optional) Optional negative name of a diff-pair</param>
		/// <returns>list of port objects that were created</returns>
		public TTCL create_port(String direction, TCLObject name, String from = null, String to = null, bool? diff_pair = null, String @interface = null, bool? quiet = null, bool? verbose = null, TCLObject negative_name = null)
		{
			// TCL Syntax: create_port -direction <arg> [-from <arg>] [-to <arg>] [-diff_pair] [-interface <arg>] [-quiet] [-verbose] <name> [<negative_name>]
			_tcl.Entry(_builder.create_port(direction, name, from, to, diff_pair, @interface, quiet, verbose, negative_name));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Delete I/O port interfaces from the project<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_interface [-all] [-quiet] [-verbose] &lt;interfaces&gt;...
		/// <br/>
		/// <para>
		/// Deletes an existing interface and optionally deletes all of the associated ports and buses using<br/>
		/// the interface.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example deletes the specified interface and all of its associated ports and buses:<br/>
		/// delete_interface USB0<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 455<br/>
		/// </para>
		/// </summary>
		/// <param name="interfaces">(Required) I/O port interfaces to remove</param>
		/// <param name="all">(Optional) Also remove all of the ports and buses belonging to the interface</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_interface(TCLObjectList interfaces, bool? all = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_interface [-all] [-quiet] [-verbose] <interfaces>...
			_tcl.Entry(_builder.delete_interface(interfaces, all, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Make differential pair for 2 ports<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: make_diff_pair_ports [-quiet] [-verbose] &lt;ports&gt;...
		/// <br/>
		/// <para>
		/// Joins two existing ports to create a differential pair. The port directions, interfaces, and other<br/>
		/// properties must match in order for the specified ports to be joined as a differential pair.<br/>
		/// Otherwise an error will be returned.<br/>
		/// IMPORTANT! The two ports must first be created, either by using the create_port command or by<br/>
		/// reading in an XDC file, prior to making them into a differential pair.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example joins the two specified ports to create a differential pair:<br/>
		/// make_diff_pair_ports port_Pos1 port_Neg1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1057<br/>
		/// </para>
		/// </summary>
		/// <param name="ports">(Required) Ports to join</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL make_diff_pair_ports(TCLObjectList ports, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: make_diff_pair_ports [-quiet] [-verbose] <ports>...
			_tcl.Entry(_builder.make_diff_pair_ports(ports, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Automatically place a set of ports<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: place_ports [-skip_unconnected_ports] [-check_only] [-iobank &lt;args&gt;] [-quiet] [-verbose] [&lt;ports&gt;...]
		/// <br/>
		/// <para>
		/// Assign ports to the pins of the Xilinx FPGA package, by automatically or manually placing ports.<br/>
		/// • Automatically places ports on an available I/O or clocking site, or into the specified I/O banks.<br/>
		/// • Manually assigns ports to the specified package_pin when both the port and pin are specified.<br/>
		/// The place_ports command will not replace ports that are currently placed by the user, or<br/>
		/// ports that are placed and fixed.<br/>
		/// Note: This command operates silently and does not return direct feedback of its operation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example places the port objects returned by the get_ports command, onto I/O<br/>
		/// bank 13 of the device, as returned by get_iobanks:<br/>
		/// place_ports -iobank [get_iobanks 13] [get_ports DataOut_pad_1_o]<br/>
		/// The follow example uses port_name package_pin pairs to manually place multiple ports:<br/>
		/// place_ports {LEDS_n[2] AA11 LEDS_n[3] AA10 LEDS_n[0] Y11 LEDS_n[1] Y10}<br/>
		/// The following example places all input ports onto I/O banks 12, 13, 14 and 15 of the device:<br/>
		/// place_ports -iobank [get_iobanks {12 13 14 15}] [all_inputs]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1129<br/>
		/// </para>
		/// </summary>
		/// <param name="skip_unconnected_ports">(Optional) Do not place unconnected ports</param>
		/// <param name="check_only">(Optional) Only check IO/Clock placement DRCs</param>
		/// <param name="iobank">(Optional) Limit placement to the following banks</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="ports">
		/// <para>
		/// (Optional)<br/>
		/// Ports to place (if omitted, all ports will be placed). If the<br/>
		/// arguments are interleaved objects of ports and package<br/>
		/// pins, then manual placement is performed<br/>
		/// </para>
		/// </param>
		public TTCL place_ports(bool? skip_unconnected_ports = null, bool? check_only = null, TCLParameterList iobank = null, bool? quiet = null, bool? verbose = null, TCLObjectList ports = null)
		{
			// TCL Syntax: place_ports [-skip_unconnected_ports] [-check_only] [-iobank <args>] [-quiet] [-verbose] [<ports>...]
			_tcl.Entry(_builder.place_ports(skip_unconnected_ports, check_only, iobank, quiet, verbose, ports));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove the given list of top ports from the netlist.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_port [-quiet] [-verbose] &lt;ports&gt;...
		/// <br/>
		/// <para>
		/// Removes the specified ports or buses.<br/>
		/// To remove a bus port, you must specify the primary port name, and not specify a bus index. This<br/>
		/// ensures that the entire bus port is removed, and not just a portion of the bits associated with the<br/>
		/// bus. You can resize a bus port, eliminating bits, using the resize_port_bus command.<br/>
		/// The remove_port command will remove ports that have been added with the create_port<br/>
		/// command, but cannot delete ports that are defined in the RTL or netlist design.<br/>
		/// Netlist editing changes the in-memory view of the netlist in the current design. It does not<br/>
		/// change the files in the source fileset, or change the persistent design on the disk. Changes made<br/>
		/// to the netlist may be saved to a design checkpoint using the write_checkpoint command, or<br/>
		/// may be exported to a netlist file such as Verilog, VHDL, or EDIF, using the appropriate write_*<br/>
		/// command.<br/>
		/// Note: Netlist editing is not allowed on the elaborated RTL design.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example deletes the specified port:<br/>
		/// remove_port PORT0<br/>
		/// The following example deletes the two specified ports of a bus:<br/>
		/// remove_port BUS[1] BUS[2]<br/>
		/// The following example deletes both the N and P sides of a differential pair port:<br/>
		/// remove_port D_BUS_P[0]<br/>
		/// Note: Deleting either the N or the P side of a differential pair will also delete the other side of the pair.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1272<br/>
		/// </para>
		/// </summary>
		/// <param name="ports">(Required) Ports and/or bus ports to remove</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_port(TCLObjectList ports, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_port [-quiet] [-verbose] <ports>...
			_tcl.Entry(_builder.remove_port(ports, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Resize port bus in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: resize_port_bus [-from &lt;arg&gt;] [-to &lt;arg&gt;] [-quiet] [-verbose] &lt;port_bus_name&gt;...
		/// <br/>
		/// <para>
		/// Resize an existing bus port, to grow the bus, shrink the bus, or renumber the current range of<br/>
		/// port indexes. You can only do a single grow, shrink, or renumber operation with each command.<br/>
		/// • You can grow the bus by indicating a new range of port indexes outside the current range of<br/>
		/// indexes. Growing the bus leaves existing port indexes connected as they currently are.<br/>
		/// • You can shrink the bus by indicating a new range of port indexes inside the current range of<br/>
		/// indexes. Shrinking the bus, eliminates connections to removed bus ports, but leaves the<br/>
		/// remaining ports connected as they currently are.<br/>
		/// • You can renumber the current bus indexes by providing a new range of port indexes with the<br/>
		/// same width as the current range. Renumbering ports changes the port index, but does not<br/>
		/// otherwise change connections.<br/>
		/// Netlist editing changes the in-memory view of the netlist in the current design. It does not<br/>
		/// change the files in the source fileset, or change the persistent design on the disk. Changes made<br/>
		/// to the netlist may be saved to a design checkpoint using the write_checkpoint command, or<br/>
		/// may be exported to a netlist file such as Verilog, VHDL, or EDIF, using the appropriate write_*<br/>
		/// command.<br/>
		/// Note: Netlist editing is not allowed on the elaborated RTL design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns nothing if successful, and returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a 32-bit output bus port, then renumbers the ports to include<br/>
		/// negative bus indexes, then shrinks the bus width from 32-bits to 16-bits:<br/>
		/// create_port -direction out -from 0 -to 31 outPorts<br/>
		/// resize_port_bus -from -16 -to 15 outPorts<br/>
		/// resize_port_bus -from -8 -to 7 outPorts<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1533<br/>
		/// </para>
		/// </summary>
		/// <param name="port_bus_name">(Required) Name of the port bus to resize</param>
		/// <param name="from">(Optional) New starting bus index</param>
		/// <param name="to">(Optional) New ending bus index</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL resize_port_bus(TCLObjectList port_bus_name, String from = null, String to = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: resize_port_bus [-from <arg>] [-to <arg>] [-quiet] [-verbose] <port_bus_name>...
			_tcl.Entry(_builder.resize_port_bus(port_bus_name, from, to, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set user columns on one or more package pins<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_package_pin_val [-quiet] [-verbose] &lt;column&gt; &lt;value&gt; &lt;package_pins&gt;...
		/// <br/>
		/// <para>
		/// Create user-defined package pin attributes and assign values to specific pins on the package.<br/>
		/// User-defined pin attributes can be defined in a CSV file and imported into an I/O Pin Planning<br/>
		/// project using read_csv, or can be edited in the project using this command.<br/>
		/// Note: Use the set_property command to set tool-defined properties of a package pin.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a new user-defined column in the Package Pins view, and assigns<br/>
		/// the value true to the specified pin:<br/>
		/// set_package_pin_val -column track1 -value true -package_pins AK27<br/>
		/// The following example creates a user-defined column called Test, then assigns the value RED to<br/>
		/// all "AK" package pins, then changes the value to GREEN for the three specified pins:<br/>
		/// set_package_pin_val -column Test -value RED \<br/>
		/// -package_pins [get_package_pins AK*]<br/>
		/// set_package_pin_val -column Test -value GREEN \<br/>
		/// -package_pins {AK1 AK2 AK3}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1670<br/>
		/// </para>
		/// </summary>
		/// <param name="column">(Required) User column name</param>
		/// <param name="value">(Required) Value to set</param>
		/// <param name="package_pins">(Required) Package pin names</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_package_pin_val(TCLObject column, TCLObject value, TCLObjectList package_pins, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_package_pin_val [-quiet] [-verbose] <column> <value> <package_pins>...
			_tcl.Entry(_builder.set_package_pin_val(column, value, package_pins, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove differential pair relationship between 2 ports<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: split_diff_pair_ports [-quiet] [-verbose] &lt;ports&gt;...
		/// <br/>
		/// <para>
		/// Splits an existing differential pair of ports into two single-ended ports.<br/>
		/// Note: This command operates silently and does not return direct feedback of its operation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example splits the specified diff pair ports to form two single ended ports:<br/>
		/// split_diff_pair_ports PORT_N PORT_P<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1711<br/>
		/// </para>
		/// </summary>
		/// <param name="ports">(Required) Ports to split</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL split_diff_pair_ports(TCLObjectList ports, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: split_diff_pair_ports [-quiet] [-verbose] <ports>...
			_tcl.Entry(_builder.split_diff_pair_ports(ports, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
