#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class NetlistCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public NetlistCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// <para>
		/// Connect a net to pins or ports<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: connect_net [-hierarchical] [-basename &lt;arg&gt;] [-net &lt;args&gt;] [-objects &lt;args&gt;] [-net_object_list &lt;args&gt;] [-dict &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This command allows the user to connect a specified net to one or more pins or ports in the<br/>
		/// netlist of an open Synthesized or Implemented Design.<br/>
		/// The connect_net command will also connect nets across levels of hierarchy in the design, by<br/>
		/// adding pins and hierarchical nets as needed to complete the connection. Added nets and pins can<br/>
		/// be assigned a custom basename to make them easy to identify, or will be assigned a basename<br/>
		/// by the Vivado tool.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// TIP: You can specify multiple nets, and a list of pins and ports to connect those nets to, using a single<br/>
		/// connect_net command with the -net_object_list or -dict options, to significantly speed the<br/>
		/// addition of multiple nets to the current design.<br/>
		/// Netlist editing changes the in-memory view of the netlist in the current design. It does not<br/>
		/// change the files in the source fileset, or change the persistent design on the disk. Changes made<br/>
		/// to the netlist may be saved to a design checkpoint using the write_checkpoint command, or<br/>
		/// may be exported to a netlist file such as Verilog, VHDL, or EDIF, using the appropriate write_*<br/>
		/// command.<br/>
		/// Note: Netlist editing is not allowed on the elaborated RTL design.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 206<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) List of pin and port objects to connect</param>
		/// <param name="hierarchical">
		/// <para>
		/// (Optional)<br/>
		/// Allow hierarchical connection, creating nets and pins as<br/>
		/// needed (see -basename).<br/>
		/// </para>
		/// </param>
		/// <param name="basename">
		/// <para>
		/// (Optional)<br/>
		/// base name to use for net / pin names needed when doing<br/>
		/// hierarchical connection (see -hier). Default value is inferred<br/>
		/// from the name of the net being connected (see -net).<br/>
		/// </para>
		/// </param>
		/// <param name="net">(Optional) Net to connect to given objects.</param>
		/// <param name="net_object_list">
		/// <para>
		/// (Optional)<br/>
		/// optional, a list of net and pin/port list pairs, each pin or port<br/>
		/// list element is connected to the corresponding net, e.g.<br/>
		/// { net_a { pin_b port_c } net_d pin_e }. Cannot be used with -<br/>
		/// net, -objects list is ignored when -net_object_list is used.<br/>
		/// </para>
		/// </param>
		/// <param name="dict">
		/// <para>
		/// (Optional)<br/>
		/// alternative to -net_object_list, faster, but requires a list of<br/>
		/// net and pin/port object pairs (must be a list of objects, not<br/>
		/// names or other TCL objects), each pin or port list element is<br/>
		/// connected to the corresponding net, e.g. { $net_1 $pin_1<br/>
		/// $net_2 $pin_2 }. Cannot be used with -net, -objects list is<br/>
		/// ignored when -dict is used.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL connect_net(TCLParameterList objects, bool? hierarchical = null, String basename = null, TCLParameterList net = null, TCLParameterList net_object_list = null, TCLParameterList dict = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: connect_net [-hierarchical] [-basename <arg>] [-net <args>] [-objects <args>] [-net_object_list <args>] [-dict <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.connect_net(objects, hierarchical, basename, net, net_object_list, dict, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create cells in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_cell -reference &lt;arg&gt; [-black_box] [-quiet] [-verbose] &lt;cells&gt;...
		/// <br/>
		/// <para>
		/// Add cells to the netlist of the current Synthesized or Implemented design.<br/>
		/// Note: You cannot add cells to library macros, or macro-primitives.<br/>
		/// New cell instances can be added to the top-level of the design, or hierarchically within any<br/>
		/// module of the design. Instances can reference an existing cell from the library or design source<br/>
		/// files, or a black box instance can be added that reference cells that have not yet been created.<br/>
		/// Netlist editing changes the in-memory view of the netlist in the current design. It does not<br/>
		/// change the files in the source fileset, or change the persistent design on the disk. Changes made<br/>
		/// to the netlist may be saved to a design checkpoint using the write_checkpoint command, or<br/>
		/// may be exported to a netlist file such as Verilog, VHDL, or EDIF, using the appropriate write_*<br/>
		/// command.<br/>
		/// Note: Netlist editing is not allowed on the elaborated RTL design.<br/>
		/// This command returns the name of the created cell instance or instances.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates three new cell instances of the or1200_cpu module with the<br/>
		/// specified instance names:<br/>
		/// create_cell -reference or1200_cpu myCell1 myCell2 myCell3<br/>
		/// The following example sets the hierarchy separator character, then creates a black box instance<br/>
		/// for the referenced cell, specifying a hierarchical instance name:<br/>
		/// set_hierarchy_separator |<br/>
		/// create_cell -reference dmaBlock -black_box usbEngine0|myDMA<br/>
		/// Note: The tool will return an error when -black_box is used, but the -reference cell already exists.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 243<br/>
		/// </para>
		/// </summary>
		/// <param name="reference">(Required) Library cell or design which cells reference</param>
		/// <param name="cells">(Required) Names of cells to create</param>
		/// <param name="black_box">(Optional) Create black box instance</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_cell(String reference, TCLObjectList cells, bool? black_box = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_cell -reference <arg> [-black_box] [-quiet] [-verbose] <cells>...
			_tcl.Entry(_builder.create_cell(reference, cells, black_box, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create nets in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_net [-from &lt;arg&gt;] [-to &lt;arg&gt;] [-quiet] [-verbose] &lt;nets&gt;...
		/// <br/>
		/// <para>
		/// Create new nets in the current netlist of an open Synthesized or Implemented Design.<br/>
		/// Note: You cannot add nets to library macros, or macro-primitives.<br/>
		/// Nets can be created hierarchically from the top-level of the design, or within any level of the<br/>
		/// hierarchy by specifying the hierarchical net name.<br/>
		/// Bus nets can be created with increasing or decreasing bus indexes, using negative and positive<br/>
		/// index values.<br/>
		/// New nets are unconnected in the netlist at the time of creation. You must connect nets as<br/>
		/// desired using the connect_net command. Connected nets can be unconnected using the<br/>
		/// disconnect_net command, and can be removed from the netlist using the remove_net<br/>
		/// command.<br/>
		/// Netlist editing changes the in-memory view of the netlist in the current design. It does not<br/>
		/// change the files in the source fileset, or change the persistent design on the disk. Changes made<br/>
		/// to the netlist may be saved to a design checkpoint using the write_checkpoint command, or<br/>
		/// may be exported to a netlist file such as Verilog, VHDL, or EDIF, using the appropriate write_*<br/>
		/// command.<br/>
		/// Note: Netlist editing is not allowed on the elaborated RTL design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 323<br/>
		/// </para>
		/// </summary>
		/// <param name="nets">(Required) Names of nets to create</param>
		/// <param name="from">(Optional) Starting bus index</param>
		/// <param name="to">(Optional) Ending bus index</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_net(TCLObjectList nets, String from = null, String to = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_net [-from <arg>] [-to <arg>] [-quiet] [-verbose] <nets>...
			_tcl.Entry(_builder.create_net(nets, from, to, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create pins in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_pin [-from &lt;arg&gt;] [-to &lt;arg&gt;] -direction &lt;arg&gt; [-quiet] [-verbose] &lt;pins&gt;...
		/// <br/>
		/// <para>
		/// Add single pins or bus pins to the current netlist of an open Synthesized or Implemented Design.<br/>
		/// You may define attributes of the pin such as direction and bus width, as well as the pin name.<br/>
		/// Bus pins can be created with increasing or decreasing bus indexes, using negative and positive<br/>
		/// index values.<br/>
		/// The pins must be created on an existing cell instance, or it is considered a top-level pin which<br/>
		/// should be created using the create_port command. If the instance name of a cell is not<br/>
		/// specified as part of the pin name, an error will be returned.<br/>
		/// Note: You cannot add pins to library macros, or macro-primitives.<br/>
		/// Netlist editing changes the in-memory view of the netlist in the current design. It does not<br/>
		/// change the files in the source fileset, or change the persistent design on the disk. Changes made<br/>
		/// to the netlist may be saved to a design checkpoint using the write_checkpoint command, or<br/>
		/// may be exported to a netlist file such as Verilog, VHDL, or EDIF, using the appropriate write_*<br/>
		/// command.<br/>
		/// Note: Netlist editing is not allowed on the elaborated RTL design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a new input pin on the cpuEngine module with the specified pin<br/>
		/// name:<br/>
		/// create_pin -direction IN cpuEngine/inPin<br/>
		/// The following example sets the hierarchy separator, creates a new black box instance of the<br/>
		/// reference cell, and creates a twenty-four bit bidirectional bus for that instance:<br/>
		/// set_hierarchy_separator |<br/>
		/// create_cell -reference dmaBlock -black_box usbEngine0|myDMA<br/>
		/// create_pin -direction INOUT -from 0 -to 23 usbEngine0|myDMA|dataBus<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 332<br/>
		/// </para>
		/// </summary>
		/// <param name="direction">(Required) Pin direction Values: IN, OUT, INOUT</param>
		/// <param name="pins">(Required) Names of pins to create</param>
		/// <param name="from">(Optional) Starting bus index</param>
		/// <param name="to">(Optional) Ending bus index</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_pin(create_pin_direction direction, TCLObjectList pins, String from = null, String to = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_pin [-from <arg>] [-to <arg>] -direction <arg> [-quiet] [-verbose] <pins>...
			_tcl.Entry(_builder.create_pin(direction, pins, from, to, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Disconnect a net from pins or ports<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: disconnect_net [-prune] [-net &lt;arg&gt;] [-objects &lt;args&gt;] [-pinlist &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This command allows the user to disconnect a specified net from one or more pins or ports in the<br/>
		/// netlist of an open Synthesized or Implemented Design.<br/>
		/// Netlist editing changes the in-memory view of the netlist in the current design. It does not<br/>
		/// change the files in the source fileset, or change the persistent design on the disk. Changes made<br/>
		/// to the netlist may be saved to a design checkpoint using the write_checkpoint command, or<br/>
		/// may be exported to a netlist file such as Verilog, VHDL, or EDIF, using the appropriate write_*<br/>
		/// command.<br/>
		/// Note: Netlist editing is not allowed on the elaborated RTL design.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 498<br/>
		/// </para>
		/// </summary>
		/// <param name="prune">
		/// <para>
		/// (Optional)<br/>
		/// When performing disconnect, remove the net and any<br/>
		/// pin/net chain up to the pin on any primitive instance as long<br/>
		/// as each object in the chain has only 1 remaining connection.<br/>
		/// </para>
		/// </param>
		/// <param name="net">
		/// <para>
		/// (Optional)<br/>
		/// Net to disconnect - optional, net attached to first pin or port<br/>
		/// object is used if not specified.<br/>
		/// </para>
		/// </param>
		/// <param name="objects">
		/// <para>
		/// (Optional)<br/>
		/// List of pin and port names to disconnect. String expressions<br/>
		/// are supported.<br/>
		/// </para>
		/// </param>
		/// <param name="pinlist">(Optional) List of pin and port objects to disconnect.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL disconnect_net(bool? prune = null, String net = null, TCLParameterList objects = null, TCLParameterList pinlist = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: disconnect_net [-prune] [-net <arg>] [-objects <args>] [-pinlist <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.disconnect_net(prune, net, objects, pinlist, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get the routed or estimated delays in picoseconds on a net from the driver to each load pin.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_net_delays -of_objects &lt;args&gt; [-regexp] [-nocase] [-patterns &lt;arg&gt;] [-filter &lt;arg&gt;] [-to &lt;args&gt;] [-interconnect_only] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Get delay objects for the specified nets in the current design, from the driver to each load pin, or<br/>
		/// to specified load pins, through specific pins.<br/>
		/// The delay object contains properties defining the maximum and minimum delays for the fast and<br/>
		/// slow process corners. Use the get_property command to extract the property of interest from<br/>
		/// the delay object. Delay property values on the delay object are specified in picoseconds.<br/>
		/// TIP: In most cases the Vivado tools return delay values specified in nanoseconds, but the delay object uses<br/>
		/// picoseconds.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The values returned are calculated or estimated depending upon whether the net is routed.<br/>
		/// Delay values can include the actual delay of routed interconnect, or estimated net delays for<br/>
		/// unrouted nets. The net delay can also include delay through logic elements or device sites, or just<br/>
		/// include the interconnect delay.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// The get_net_delays command returns the delay objects for the specified nets, or returns an<br/>
		/// error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the interconnect delay values for the specified net, and returns it in<br/>
		/// the form of a delay object:<br/>
		/// report_property -all [lindex [get_net_delays -interconnect_only \<br/>
		/// -of_objects [get_nets control_reg[*]]] 16 ]<br/>
		/// TIP: The FAST_MAX, FAST_MIN, SLOW_MAX, and SLOW_MIN properties on the delay object are<br/>
		/// reported in picoseconds.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 838<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Required) Get 'net_delay' objects of these types: 'net'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="patterns">(Optional) Match the 'net_delay' objects against patterns. Default: *</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="to">(Optional) Get the delay of the net to the given terminal(s) or port(s).</param>
		/// <param name="interconnect_only">
		/// <para>
		/// (Optional)<br/>
		/// Include only interconnect delays. The default is to include<br/>
		/// the intra-site delay.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>net_delays</returns>
		public TTCL get_net_delays(TCLParameterList of_objects, bool? regexp = null, bool? nocase = null, String patterns = null, String filter = null, TCLParameterList to = null, bool? interconnect_only = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_net_delays -of_objects <args> [-regexp] [-nocase] [-patterns <arg>] [-filter <arg>] [-to <args>] [-interconnect_only] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_net_delays(of_objects, regexp, nocase, patterns, filter, to, interconnect_only, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove cells from the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_cell [-quiet] [-verbose] &lt;cells&gt;...
		/// <br/>
		/// <para>
		/// Remove cells from the current netlist in either an open Synthesized or Implemented design.<br/>
		/// Note: You cannot remove cells from library macros, also called macro-primitives.<br/>
		/// Netlist editing changes the in-memory view of the netlist in the current design. It does not<br/>
		/// change the files in the source fileset, or change the persistent design on the disk. Changes made<br/>
		/// to the netlist may be saved to a design checkpoint using the write_checkpoint command, or<br/>
		/// may be exported to a netlist file such as Verilog, VHDL, or EDIF, using the appropriate write_*<br/>
		/// command.<br/>
		/// Note: Netlist editing is not allowed on the elaborated RTL design.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example removes the fftEngine from the in-memory netlist of the current design:<br/>
		/// remove_cell fftEngine<br/>
		/// remove_cell usbEngine0/usb_out<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1235<br/>
		/// </para>
		/// </summary>
		/// <param name="cells">(Required) List of cells to remove</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_cell(TCLObjectList cells, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_cell [-quiet] [-verbose] <cells>...
			_tcl.Entry(_builder.remove_cell(cells, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove nets from the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_net [-prune] [-quiet] [-verbose] &lt;nets&gt;...
		/// <br/>
		/// <para>
		/// Remove the specified net from the netlist of an open Synthesized or Implemented Design.<br/>
		/// Note: You cannot remove nets from library macros, also called macro-primitives.<br/>
		/// To remove a bus, you must specify the primary bus name, and not specify a bus index. This<br/>
		/// ensures that the entire bus is removed, and not just a portion of the bits associated with the bus.<br/>
		/// You can resize a bus, eliminating bits of the bus, using the resize_net_bus command.<br/>
		/// Netlist editing changes the in-memory view of the netlist in the current design. It does not<br/>
		/// change the files in the source fileset, or change the persistent design on the disk. Changes made<br/>
		/// to the netlist may be saved to a design checkpoint using the write_checkpoint command, or<br/>
		/// may be exported to a netlist file such as Verilog, VHDL, or EDIF, using the appropriate write_*<br/>
		/// command.<br/>
		/// Note: Netlist editing is not allowed on the elaborated RTL design.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1268<br/>
		/// </para>
		/// </summary>
		/// <param name="nets">(Required) List of nets to remove</param>
		/// <param name="prune">
		/// <para>
		/// (Optional)<br/>
		/// When performing net removal, remove pins and ports which<br/>
		/// are left unconnected as a result of the remove_net<br/>
		/// operation.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_net(TCLObjectList nets, bool? prune = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_net [-prune] [-quiet] [-verbose] <nets>...
			_tcl.Entry(_builder.remove_net(nets, prune, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove pins from the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_pin [-quiet] [-verbose] &lt;pins&gt;...
		/// <br/>
		/// <para>
		/// Remove pins from the current netlist in either an open Synthesized or Implemented design.<br/>
		/// Note: You cannot remove pins from library macros, or macro-primitives.<br/>
		/// To remove a bus pin, you must specify the primary pin name, and not specify a bus index. This<br/>
		/// ensures that the entire bus pin is removed, and not just a portion of the bits associated with the<br/>
		/// bus. You can resize a bus pin, eliminating bits, using the resize_pin_bus command.<br/>
		/// Netlist editing changes the in-memory view of the netlist in the current design. It does not<br/>
		/// change the files in the source fileset, or change the persistent design on the disk. Changes made<br/>
		/// to the netlist may be saved to a design checkpoint using the write_checkpoint command, or<br/>
		/// may be exported to a netlist file such as Verilog, VHDL, or EDIF, using the appropriate write_*<br/>
		/// command.<br/>
		/// Note: Netlist editing is not allowed on the elaborated RTL design.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example removes the specified pin from the cpuEngine in the in-memory netlist of<br/>
		/// the current design:<br/>
		/// remove_pin cpuEngine/inPin<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1270<br/>
		/// </para>
		/// </summary>
		/// <param name="pins">(Required) List of pins to remove</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_pin(TCLObjectList pins, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_pin [-quiet] [-verbose] <pins>...
			_tcl.Entry(_builder.remove_pin(pins, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// rename a cell<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: rename_cell -to &lt;arg&gt; [-quiet] [-verbose] &lt;cell&gt;...
		/// <br/>
		/// <para>
		/// Rename a single hierarchical or leaf-level cell in the current synthesized or implemented design.<br/>
		/// TIP: You cannot rename cells with DONT_TOUCH property set to TRUE.<br/>
		/// Netlist editing changes the in-memory view of the netlist in the current design. It does not<br/>
		/// change the files in the source fileset, or change the persistent design on the disk. Changes made<br/>
		/// to the netlist may be saved to a design checkpoint using the write_checkpoint command, or<br/>
		/// may be exported to a netlist file such as Verilog, VHDL, or EDIF, using the appropriate write_*<br/>
		/// command.<br/>
		/// Note: Netlist editing is not allowed on the elaborated RTL design.<br/>
		/// Changes to the names of cells, nets, pins, and ports, will also affect the design constraints defined<br/>
		/// in the in-memory design. Constraints are automatically modified to target the new object name,<br/>
		/// however these are not written back to the source XDC file. Saving the modified in-memory<br/>
		/// design using write_checkpoint will save both the renamed objects and modified constraints.<br/>
		/// This command returns nothing if successful, or an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example changes the name of the hierarchical or1200_cpu cell as specified:<br/>
		/// rename_cell -to or1200_gpu or1200_cpu<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1275<br/>
		/// </para>
		/// </summary>
		/// <param name="to">(Required) New name</param>
		/// <param name="cell">(Required) Cell to rename</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL rename_cell(String to, TCLObjectList cell, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: rename_cell -to <arg> [-quiet] [-verbose] <cell>...
			_tcl.Entry(_builder.rename_cell(to, cell, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// rename a net<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: rename_net -to &lt;arg&gt; [-quiet] [-verbose] &lt;net&gt;...
		/// <br/>
		/// <para>
		/// Rename a net in the current synthesized or implemented design.<br/>
		/// The following are limitations with regard to renaming nets:<br/>
		/// • You cannot rename nets that have DONT_TOUCH or MARK_DEBUG properties set to TRUE.<br/>
		/// • You cannot rename individual bits of a bus net, but you can collectively rename the whole bus.<br/>
		/// Netlist editing changes the in-memory view of the netlist in the current design. It does not<br/>
		/// change the files in the source fileset, or change the persistent design on the disk. Changes made<br/>
		/// to the netlist may be saved to a design checkpoint using the write_checkpoint command, or<br/>
		/// may be exported to a netlist file such as Verilog, VHDL, or EDIF, using the appropriate write_*<br/>
		/// command.<br/>
		/// Note: Netlist editing is not allowed on the elaborated RTL design.<br/>
		/// Changes to the names of cells, nets, pins, and ports, will also affect the design constraints defined<br/>
		/// in the in-memory design. Constraints are automatically modified to target the new object name,<br/>
		/// however these are not written back to the source XDC file. Saving the modified in-memory<br/>
		/// design using write_checkpoint will save both the renamed objects and modified constraints.<br/>
		/// This command returns nothing if successful, or an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example renames the specified bus signal:<br/>
		/// rename_net -to dataOut dout<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1277<br/>
		/// </para>
		/// </summary>
		/// <param name="to">(Required) New name</param>
		/// <param name="net">(Required) Net to rename</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL rename_net(String to, TCLObjectList net, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: rename_net -to <arg> [-quiet] [-verbose] <net>...
			_tcl.Entry(_builder.rename_net(to, net, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// rename a pin<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: rename_pin -to &lt;arg&gt; [-quiet] [-verbose] &lt;pin&gt;...
		/// <br/>
		/// <para>
		/// Rename the specified pin on a hierarchical cell in the current synthesized or implemented design.<br/>
		/// The following are limitations with regard to renaming pins:<br/>
		/// • Pins on primitive cells cannot be renamed.<br/>
		/// • A pin on a hierarchical cell that has the DONT_TOUCH property can be renamed, but a pin on<br/>
		/// an hierarchical cell inside a DON'T_TOUCH cell cannot be renamed.<br/>
		/// • You cannot rename individual bits of a bus pin, but you can collectively rename the whole bus.<br/>
		/// Netlist editing changes the in-memory view of the netlist in the current design. It does not<br/>
		/// change the files in the source fileset, or change the persistent design on the disk. Changes made<br/>
		/// to the netlist may be saved to a design checkpoint using the write_checkpoint command, or<br/>
		/// may be exported to a netlist file such as Verilog, VHDL, or EDIF, using the appropriate write_*<br/>
		/// command.<br/>
		/// Note: Netlist editing is not allowed on the elaborated RTL design.<br/>
		/// Changes to the names of cells, nets, pins, and ports, will also affect the design constraints defined<br/>
		/// in the in-memory design. Constraints are automatically modified to target the new object name,<br/>
		/// however these are not written back to the source XDC file. Saving the modified in-memory<br/>
		/// design using write_checkpoint will save both the renamed objects and modified constraints.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns nothing if successful, or an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example renames the specified pin:<br/>
		/// rename_pin -to in1 egressLoop[0].egressFifo/I1<br/>
		/// The following example shows the error that is returned when you try to rename a single bit of a<br/>
		/// bus, and then renames the whole bus pin:<br/>
		/// rename_pin -to din[0] egressLoop[0].egressFifo/buffer_fifo/dataInput[0]<br/>
		/// WARNING: [Coretcl 2-1480] rename_pin can not rename bits of a bus, \<br/>
		/// use resize_pin_bus instead.<br/>
		/// rename_pin -to dataInput egressLoop[0].egressFifo/buffer_fifo/din<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1279<br/>
		/// </para>
		/// </summary>
		/// <param name="to">(Required) New name</param>
		/// <param name="pin">(Required) Pin to rename</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL rename_pin(String to, TCLObjectList pin, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: rename_pin -to <arg> [-quiet] [-verbose] <pin>...
			_tcl.Entry(_builder.rename_pin(to, pin, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// rename a port<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: rename_port -to &lt;arg&gt; [-quiet] [-verbose] &lt;port&gt;...
		/// <br/>
		/// <para>
		/// Rename a single port in the current synthesized or implemented design.<br/>
		/// TIP: You cannot rename individual bits of a bus port, but you can collectively rename the whole bus.<br/>
		/// Netlist editing changes the in-memory view of the netlist in the current design. It does not<br/>
		/// change the files in the source fileset, or change the persistent design on the disk. Changes made<br/>
		/// to the netlist may be saved to a design checkpoint using the write_checkpoint command, or<br/>
		/// may be exported to a netlist file such as Verilog, VHDL, or EDIF, using the appropriate write_*<br/>
		/// command.<br/>
		/// Note: Netlist editing is not allowed on the elaborated RTL design.<br/>
		/// Changes to the names of cells, nets, pins, and ports, will also affect the design constraints defined<br/>
		/// in the in-memory design. Constraints are automatically modified to target the new object name,<br/>
		/// however these are not written back to the source XDC file. Saving the modified in-memory<br/>
		/// design using write_checkpoint will save both the renamed objects and modified constraints.<br/>
		/// This command returns nothing if successful, or an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example renames the specified bus port:<br/>
		/// rename_port -to wbInputData wbInDat<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1282<br/>
		/// </para>
		/// </summary>
		/// <param name="to">(Required) New name</param>
		/// <param name="port">(Required) Port to rename</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL rename_port(String to, TCLObjectList port, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: rename_port -to <arg> [-quiet] [-verbose] <port>...
			_tcl.Entry(_builder.rename_port(to, port, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// rename a cell ref<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: rename_ref [-ref &lt;arg&gt;] [-to &lt;arg&gt;] [-prefix_all &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Rename the reference name of a single non-primitive cell, or apply a reference prefix to all non-primitive cells in the current synthesized or implemented design.<br/>
		/// This command provides a mechanism to change the non-primitive reference names in the current<br/>
		/// design so that they do not collide with the reference names in another design. This lets two<br/>
		/// modules or designs be synthesized or simulated together, while avoiding any name collisions<br/>
		/// between the two designs.<br/>
		/// This command returns nothing when renaming the reference a single cell, and returns the<br/>
		/// number of cells renamed when used with -prefix_all. If the command fails, an error is<br/>
		/// returned.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example changes the specified reference name to the value indicated:<br/>
		/// rename_ref -ref usbf_top -to MOD1_usbf_top<br/>
		/// The following example applies the specified reference name prefix to all non-primitive cells in the<br/>
		/// current design:<br/>
		/// rename_ref -prefix_all MOD1_<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1284<br/>
		/// </para>
		/// </summary>
		/// <param name="ref">(Optional) Cell ref to rename</param>
		/// <param name="to">(Optional) New name</param>
		/// <param name="prefix_all">
		/// <para>
		/// (Optional)<br/>
		/// Rename all eligible hierarchical cell refs in the current<br/>
		/// design. Construct the new name using the given prefix plus<br/>
		/// the original name<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL rename_ref(String @ref = null, String to = null, String prefix_all = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: rename_ref [-ref <arg>] [-to <arg>] [-prefix_all <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.rename_ref(@ref, to, prefix_all, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Resize net bus in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: resize_net_bus [-from &lt;arg&gt;] [-to &lt;arg&gt;] [-quiet] [-verbose] &lt;net_bus_name&gt;...
		/// <br/>
		/// <para>
		/// Resize an existing bus net, to grow the bus, shrink the bus, or renumber the current range of<br/>
		/// indexes. You can only do a single grow, shrink, or renumber operation with each command.<br/>
		/// • You can grow the bus by indicating a new range of indexes outside the current range of<br/>
		/// indexes. Growing the bus leaves existing bits connected as they currently are.<br/>
		/// • You can shrink the bus by indicating a new range of indexes inside the current range of<br/>
		/// indexes. Shrinking the bus, eliminates connections to removed bits, but leaves the remaining<br/>
		/// bits connected as they currently are.<br/>
		/// • You can renumber the current bus indexes by providing a new range of indexes with the same<br/>
		/// width as the current range. Renumbering bits changes bus bit numeric identifiers, but doesn't<br/>
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
		/// See ug835-vivado-tcl-commands.pdf, page 1525<br/>
		/// </para>
		/// </summary>
		/// <param name="net_bus_name">(Required) Name of the net bus to resize</param>
		/// <param name="from">(Optional) New starting bus index</param>
		/// <param name="to">(Optional) New ending bus index</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL resize_net_bus(TCLObjectList net_bus_name, String from = null, String to = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: resize_net_bus [-from <arg>] [-to <arg>] [-quiet] [-verbose] <net_bus_name>...
			_tcl.Entry(_builder.resize_net_bus(net_bus_name, from, to, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Resize pin bus in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: resize_pin_bus [-from &lt;arg&gt;] [-to &lt;arg&gt;] [-quiet] [-verbose] &lt;pin_bus_name&gt;...
		/// <br/>
		/// <para>
		/// Resize an existing bus pin, to grow the bus, shrink the bus, or renumber the current range of pin<br/>
		/// indexes. You can only do a single grow, shrink, or renumber operation with each command.<br/>
		/// • You can grow the bus by indicating a new range of pin indexes outside the current range of<br/>
		/// indexes. Growing the bus leaves existing pins connected as they currently are.<br/>
		/// • You can shrink the bus by indicating a new range of pin indexes inside the current range of<br/>
		/// indexes. Shrinking the bus, eliminates connections to removed bus pins, but leaves the<br/>
		/// remaining pins connected as they currently are.<br/>
		/// • You can renumber the current bus indexes by providing a new range of pin indexes with the<br/>
		/// same width as the current range. Renumbering pins changes the pin index, but does not<br/>
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
		/// The following example creates a blackbox cell, then creates a 24-bit bidirectional bus for the<br/>
		/// specified hierarchical cell, then resizes the bus pin to expand the width to 32-bits, then<br/>
		/// renumbers the index to include negative bus indexes:<br/>
		/// create_cell -reference dmaBlock -black_box usbEngine0/myDMA<br/>
		/// create_pin -direction INOUT -from 0 -to 23 usbEngine0/myDMA/dataBus<br/>
		/// resize_pin_bus -from 0 -to 31 usbEngine0/myDMA/dataBus<br/>
		/// resize_pin_bus -from -16 -to 15 usbEngine0/myDMA/dataBus<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1530<br/>
		/// </para>
		/// </summary>
		/// <param name="pin_bus_name">(Required) Name of the pin bus to resize</param>
		/// <param name="from">(Optional) New starting bus index</param>
		/// <param name="to">(Optional) New ending bus index</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL resize_pin_bus(TCLObjectList pin_bus_name, String from = null, String to = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: resize_pin_bus [-from <arg>] [-to <arg>] [-quiet] [-verbose] <pin_bus_name>...
			_tcl.Entry(_builder.resize_pin_bus(pin_bus_name, from, to, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Tie off unused cell pins<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: tie_unused_pins [-of_objects &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Tie up or down the unconnected pins of cells in the open synthesized or implemented design.<br/>
		/// The command uses an internal process to identify whether a pin should be tied up or down.<br/>
		/// This command is intended to tie up or down the unconnected pins of cells added to the netlist<br/>
		/// with the create_cell command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1744<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) tie unused pins of specified cell(s)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL tie_unused_pins(TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: tie_unused_pins [-of_objects <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.tie_unused_pins(of_objects, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
