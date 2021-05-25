#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class IPIntegratorCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public IPIntegratorCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// <para>
		/// Runs an automation rule on an IPI object.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: apply_bd_automation -rule &lt;arg&gt; [-config &lt;args&gt;] -dict &lt;arg&gt; -opts &lt;arg&gt; [-quiet] [-verbose] &lt;objects&gt;...
		/// <br/>
		/// <para>
		/// IP integrator provides the Designer Assistance feature, using the apply_bd_automation<br/>
		/// command, to automatically configure and/or add other relevant IP integrator cells around a<br/>
		/// selected IP integrator object. For more information on the Designer Assistance features refer to<br/>
		/// the Vivado Design Suite User Guide: Designing with IP (UG896) or the Vivado Design Suite User<br/>
		/// Guide: Designing IP Subsystems Using IP Integrator (UG994).<br/>
		/// Currently block and connection automation exists for cells, interfaces, pins and ports. The Block<br/>
		/// Automation feature is provided for certain complex blocks such as the Zynq device, MicroBlaze<br/>
		/// processor, AXI Ethernet and memory IP.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The Connection Automation feature helps automate different types of connections. For instance<br/>
		/// when connecting Slave AXI-MM interfaces, the automation will also connect up the relevant<br/>
		/// clock and reset pins and also create an interconnect if one is required. Connection Automation<br/>
		/// may also help with board-level connections; connecting pins and interfaces from relevant cells, to<br/>
		/// external ports and interfaces, and applying appropriate board constraints on these external I/Os.<br/>
		/// Note: This IP integrator command is issued from within the Vivado IDE via the Designer Assistance GUI<br/>
		/// feature. It is recommended that you make use of this command in IP integrator through the Vivado IDE,<br/>
		/// rather than directly from Tcl scripts. Use the write_bd_tcl command to output Tcl for use within a user<br/>
		/// script.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 99<br/>
		/// </para>
		/// </summary>
		/// <param name="rule">(Required) Rule ID string</param>
		/// <param name="dict">(Required) List of objects and corresponding parameter name-value pairs.</param>
		/// <param name="opts">(Required) List of settings that apply to all objects in this rule.</param>
		/// <param name="objects">(Required) The objects to run the automation rule on</param>
		/// <param name="config">(Optional) List of parameter value pairs</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Returns success or failure</returns>
		public TTCL apply_bd_automation(String rule, String dict, String opts, TCLParameterList objects, TCLParameterList config = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: apply_bd_automation -rule <arg> [-config <args>] -dict <arg> -opts <arg> [-quiet] [-verbose] <objects>...
			_tcl.Entry(_builder.apply_bd_automation(rule, dict, opts, objects, config, quiet, verbose));
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
		/// Automatically assign addresses to unmapped IP<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: assign_bd_address [-target_address_space &lt;arg&gt;] [-boundary] [-master_boundary] [-external] -dict &lt;arg&gt; [-import_from_file &lt;arg&gt;] [-export_to_file &lt;arg&gt;] [-export_gui_to_file &lt;arg&gt;] [-offset &lt;arg&gt;] [-range &lt;arg&gt;] [-base_high &lt;arg&gt;] [-force] [-quiet] [-verbose] [&lt;objects&gt;...]
		/// <br/>
		/// <para>
		/// Assign unmapped IP address segments to address spaces in the IP integrator subsystem design.<br/>
		/// If the target address space is not specified, the IP integrator will automatically assign the address<br/>
		/// segment to an available address space on a connected AXI master.<br/>
		/// If no bd_addr_seg objects are specified the assign_bd_address command will assign all<br/>
		/// unmapped address segments to any connected AXI master address spaces.<br/>
		/// This command returns the newly mapped address segments, or returns an error if it failed.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 112<br/>
		/// </para>
		/// </summary>
		/// <param name="dict">
		/// <para>
		/// (Required)<br/>
		/// dictionary of offset range address pairs, e.g. {offset<br/>
		/// 0x00000000 range 32K offset 0x20000000 range 32K} used to<br/>
		/// map an external interface to more than one address<br/>
		/// </para>
		/// </param>
		/// <param name="target_address_space">(Optional) Target address space to place segment into</param>
		/// <param name="boundary">
		/// <para>
		/// (Optional)<br/>
		/// assign peripherals to the exported slave hierarchical<br/>
		/// boundary of the design<br/>
		/// </para>
		/// </param>
		/// <param name="master_boundary">
		/// <para>
		/// (Optional)<br/>
		/// set hierarchical master boundary by assigning exported<br/>
		/// master interface segments to internal masters<br/>
		/// </para>
		/// </param>
		/// <param name="external">
		/// <para>
		/// (Optional)<br/>
		/// allow an external master interface to be mapped to more<br/>
		/// than one address<br/>
		/// </para>
		/// </param>
		/// <param name="import_from_file">
		/// <para>
		/// (Optional)<br/>
		/// import the addressing from file. When extension is csv,<br/>
		/// format = &lt;address space name&gt;,&lt;slave<br/>
		/// segment&gt;,&lt;offset&gt;,&lt;range&gt;<br/>
		/// </para>
		/// </param>
		/// <param name="export_to_file">
		/// <para>
		/// (Optional)<br/>
		/// export the address map to a file in csv format. format =<br/>
		/// &lt;address space name&gt;,&lt;slave segment&gt;,&lt;offset&gt;,&lt;range&gt;<br/>
		/// </para>
		/// </param>
		/// <param name="export_gui_to_file">
		/// <para>
		/// (Optional)<br/>
		/// export the address map to a file in csv format. Structure is<br/>
		/// same as Address Editor GUI<br/>
		/// </para>
		/// </param>
		/// <param name="offset">(Optional) Offset of assignment. e.g. 0x00000000</param>
		/// <param name="range">(Optional) Range of assignment. e.g. 4096, 4K, 16M, 1G</param>
		/// <param name="base_high">
		/// <para>
		/// (Optional)<br/>
		/// colon separated base:high offsets of a range assignment.<br/>
		/// e.g. 0x0000:0xFFFF<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) force the assignment, do not run any validity checks</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">(Optional) The objects to assign UG835 (v2020.2) November 18, 2020 www.xilinx.com</param>
		/// <returns>The newly mapped segments, "" if failed.</returns>
		public TTCL assign_bd_address(String dict, String target_address_space = null, bool? boundary = null, bool? master_boundary = null, bool? external = null, String import_from_file = null, String export_to_file = null, String export_gui_to_file = null, String offset = null, String range = null, String base_high = null, bool? force = null, bool? quiet = null, bool? verbose = null, TCLParameterList objects = null)
		{
			// TCL Syntax: assign_bd_address [-target_address_space <arg>] [-boundary] [-master_boundary] [-external] -dict <arg> [-import_from_file <arg>] [-export_to_file <arg>] [-export_gui_to_file <arg>] [-offset <arg>] [-range <arg>] [-base_high <arg>] [-force] [-quiet] [-verbose] [<objects>...]
			_tcl.Entry(_builder.assign_bd_address(dict, target_address_space, boundary, master_boundary, external, import_from_file, export_to_file, export_gui_to_file, offset, range, base_high, force, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Close a design.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: close_bd_design [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Closes the specified IP subsystem design in the IP integrator of the Vivado Design Suite.<br/>
		/// If the design has been modified, you will not be prompted to save the design prior to closing. You<br/>
		/// will need to run save_bd_design to save any changes made to the design before using the<br/>
		/// close_bd_design command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 135<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of design to close</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The design object, "" if failed.</returns>
		public TTCL close_bd_design(String name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: close_bd_design [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.close_bd_design(name, quiet, verbose));
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
		public TTCL compile_c(String objects, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: compile_c [-force] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.compile_c(objects, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Connect intf_port and intf_pin list.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: connect_bd_intf_net [-intf_net &lt;arg&gt;] [-boundary_type &lt;arg&gt;] [-quiet] [-verbose] &lt;object1&gt; &lt;object2&gt; [&lt;auto&gt;]
		/// <br/>
		/// <para>
		/// Connect the interface pins on an IP integrator cell to other interface pins, or to external interface<br/>
		/// ports. An interface is a grouping of signals that share a common function in the IP integrator<br/>
		/// subsystem design.<br/>
		/// This command will create an interface net of the name specified by the -intf_net option, will<br/>
		/// connect to an existing interface net of the specified name, or will assign a name if none is<br/>
		/// specified.<br/>
		/// Returns the connected interface net object, or returns an error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 194<br/>
		/// </para>
		/// </summary>
		/// <param name="object1">(Required) Name of intf_port or intf_pin to connect</param>
		/// <param name="object2">(Required) Name of intf_port or intf_pin to connect</param>
		/// <param name="intf_net">(Optional) The single intf_net that all objects connect to</param>
		/// <param name="boundary_type">
		/// <para>
		/// (Optional)<br/>
		/// Used when source object is on a hierarchical block's<br/>
		/// interface pin. Valid values are 'upper', 'lower', or 'both'. If<br/>
		/// 'lower' boundary, searches from the lower level of hierarchy<br/>
		/// onwards. Default: both<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="auto">(Optional) Automatically connect associated pins</param>
		/// <returns>TCL_OK, TCL_ERROR if failed.</returns>
		public TTCL connect_bd_intf_net(String object1, String object2, String intf_net = null, String boundary_type = null, bool? quiet = null, bool? verbose = null, String auto = null)
		{
			// TCL Syntax: connect_bd_intf_net [-intf_net <arg>] [-boundary_type <arg>] [-quiet] [-verbose] <object1> <object2> [<auto>]
			_tcl.Entry(_builder.connect_bd_intf_net(object1, object2, intf_net, boundary_type, quiet, verbose, auto));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Connect port and pin object list.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: connect_bd_net [-net &lt;arg&gt;] [-boundary_type &lt;arg&gt;] [-quiet] [-verbose] &lt;objects&gt;...
		/// <br/>
		/// <para>
		/// Create a new net in the current IP integrator subsystem design connecting the specified list of<br/>
		/// block diagram port and pin objects, or connect an existing net to the specified pins and ports.<br/>
		/// If the -net option is not specified, a new net is created connecting the listed objects. If -net is<br/>
		/// used, the specified net is either connected or created as needed.<br/>
		/// Use the get_bd_ports and get_bd_pins commands to specify the port and pin objects to<br/>
		/// connect.<br/>
		/// You can use this command to connect pins or ports at different levels of the subsystem design<br/>
		/// hierarchy. However, in this case, you cannot specify the -net option because the connection,<br/>
		/// when complete, will result in multiple nets rather than a single net.<br/>
		/// The command returns the connected IP integrator subsystem design net object, or returns an<br/>
		/// error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example connects two pins on different levels of the IP subsystem design<br/>
		/// hierarchy:<br/>
		/// connect_bd_net [get_bd_pins /vidOut_1/locked] \<br/>
		/// [get_bd_pins /newMod1/bridge_1/fid]<br/>
		/// Note: Because /vidOut_1/locked and /newMod1/bridge_1/fid are in different levels of the<br/>
		/// subsystem design hierarchy, the -net option is not specified. In this case, multiple nets are created for<br/>
		/// connection across the hierarchy.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 196<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) The objects connect to the net</param>
		/// <param name="net">(Optional) The single net that all objects connect to</param>
		/// <param name="boundary_type">
		/// <para>
		/// (Optional)<br/>
		/// Used when source object is on a hierarchical block's pin.<br/>
		/// Valid values are 'upper', 'lower', or 'both'. If 'lower'<br/>
		/// boundary, searches from the lower level of hierarchy<br/>
		/// onwards. Default: both<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>TCL_OK, TCL_ERROR if failed.</returns>
		public TTCL connect_bd_net(TCLParameterList objects, String net = null, String boundary_type = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: connect_bd_net [-net <arg>] [-boundary_type <arg>] [-quiet] [-verbose] <objects>...
			_tcl.Entry(_builder.connect_bd_net(objects, net, boundary_type, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Make copies of the objects and add the copies to the given hierarchical cell.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: copy_bd_objs [-prefix &lt;arg&gt;] [-from_design &lt;arg&gt;] [-quiet] [-verbose] &lt;parent_cell&gt; &lt;objects&gt;...
		/// <br/>
		/// <para>
		/// Use this command to copy IP integrator objects from one open subsystem design to a second<br/>
		/// subsystem design. The selected objects can be copied into the top-level of the current subsystem<br/>
		/// design, or into an existing hierarchical module.<br/>
		/// Because get_bd_cells, and other commands like it, operate on the current subsystem design,<br/>
		/// you must store the objects to be copied in a Tcl variable, as shown in the example below. Set the<br/>
		/// current subsystem design to the source design, select the group of objects to be copied, and<br/>
		/// store them in a Tcl variable. Then change the current_bd_design to the target design, and<br/>
		/// copy the selected objects. In this case, the -from_design option must be used.<br/>
		/// You can also use this command to copy objects from one level of hierarchy in the current<br/>
		/// subsystem design to another. In this case, the -from_design argument does not need to be<br/>
		/// specified.<br/>
		/// This command returns 0 if successful, and returns an error if it failed.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 215<br/>
		/// </para>
		/// </summary>
		/// <param name="parent_cell">(Required) Parent cell</param>
		/// <param name="objects">(Required) The objects to copy</param>
		/// <param name="prefix">(Optional) Prefix name to add to cells</param>
		/// <param name="from_design">(Optional) The design to own the original objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>0, "" if failed.</returns>
		public TTCL copy_bd_objs(String parent_cell, TCLParameterList objects, String prefix = null, String from_design = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: copy_bd_objs [-prefix <arg>] [-from_design <arg>] [-quiet] [-verbose] <parent_cell> <objects>...
			_tcl.Entry(_builder.copy_bd_objs(parent_cell, objects, prefix, from_design, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new segment.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_bd_addr_seg -range &lt;arg&gt; -offset &lt;arg&gt; [-quiet] [-verbose] [&lt;parent_addr_space&gt;] [&lt;slave_segment&gt;] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Create a new address segment object, bd_addr_seg, in the current IP integrator subsystem<br/>
		/// design.<br/>
		/// This command returns the newly created master address segment object, or returns nothing if it<br/>
		/// failed.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 222<br/>
		/// </para>
		/// </summary>
		/// <param name="range">(Required) Range of segment. e.g. 4096, 4K, 16M, 1G</param>
		/// <param name="offset">(Required) Offset of segment. e.g. 0x00000000</param>
		/// <param name="parent_addr_space">(Required) Parent address space of segment</param>
		/// <param name="slave_segment">(Required) Slave segment of the created segment</param>
		/// <param name="name">(Required) Name of segment to create</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The newly created segment object, "" if failed.</returns>
		public TTCL create_bd_addr_seg(String range, String offset, String parent_addr_space, String slave_segment, String name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_bd_addr_seg -range <arg> -offset <arg> [-quiet] [-verbose] [<parent_addr_space>] [<slave_segment>] <name>
			_tcl.Entry(_builder.create_bd_addr_seg(range, offset, parent_addr_space, slave_segment, name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Add an IP cell from the IP catalog, or add a new hierarchical block.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_bd_cell [-vlnv &lt;arg&gt;] [-type &lt;arg&gt;] [-reference &lt;arg&gt;] [-revision &lt;arg&gt;] [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Add a cell from the Vivado catalog to the current subsystem design, create a new hierarchical<br/>
		/// module to add to the subsystem design, or create a new module by referencing the module<br/>
		/// definition from an HDL source file.<br/>
		/// When adding an IP core from the catalog, the -vlnv argument is required.<br/>
		/// When creating a new hierarchical block design module, the -type hier argument is required.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// When creating a block design module that references an RTL module or entity declaration the -<br/>
		/// type module argument is required, as well as -reference. The module reference feature lets<br/>
		/// you add a module definition from an RTL file (Verilog or VHDL) into the block design. The source<br/>
		/// file containing the module definition must be added to the project, or read into the design before<br/>
		/// creating a module reference. Refer to the Vivado Design Suite User Guide: Designing IP Subsystems<br/>
		/// Using IP Integrator (UG994) for more information on referencing modules.<br/>
		/// This command returns the name of the newly created cell object, or returns nothing if the<br/>
		/// command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example adds an AXI FIFO core from the IP integrator catalog to the current subsystem<br/>
		/// design, with the specified name:<br/>
		/// create_bd_cell -vlnv xilinx.com:ip:axi_fifo_mm_s:4.0 axi_fifo_1<br/>
		/// Note: The -vlnv argument identifies the core to add from the Vivado catalog.<br/>
		/// This example creates a new block design container in the block design, referencing the specified<br/>
		/// module definition from a previously loaded BD source file:<br/>
		/// set bdc [ create_bd_cell -type container -reference hier_0 bdc ]<br/>
		/// This example creates a new module in the block design, referencing the specified module<br/>
		/// definition from a previously loaded RTL source file:<br/>
		/// create_bd_cell -type module -reference rtlRam rtlRam_0<br/>
		/// This example creates a new hierarchical module, myModule1, and moves the AXI FIFO from the<br/>
		/// prior example into the new module. myModule1 is set as the current instance in the subsystem<br/>
		/// design, and a new module is created, myModule2, which is added to the current instance. Finally<br/>
		/// the current instance is reset to point to the top-level of the subsystem design:<br/>
		/// create_bd_cell -type hier myModule1<br/>
		/// /myModule1<br/>
		/// move_bd_cells /myModule1 [get_bd_cells /axi_fifo_1]<br/>
		/// /myModule1<br/>
		/// current_bd_instance /myModule1<br/>
		/// /myModule1<br/>
		/// create_bd_cell -type hier myModule2<br/>
		/// /myModule1/myModule2<br/>
		/// current_bd_instance<br/>
		/// /<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 224<br/>
		/// </para>
		/// </summary>
		/// <param name="vlnv">(Required) Vendor:Library:Name:Version of the IP cell to add from the IP catalog.</param>
		/// <param name="name">(Required) Name of cell to create</param>
		/// <param name="type">
		/// <para>
		/// (Optional)<br/>
		/// Type of cell to create. Valid values are IP, hier, container and<br/>
		/// module. Default: IP<br/>
		/// </para>
		/// </param>
		/// <param name="reference">
		/// <para>
		/// (Optional)<br/>
		/// Top module-name or file-path of the module which is<br/>
		/// referred to create the cell.<br/>
		/// </para>
		/// </param>
		/// <param name="revision">(Optional) (Optional) Core revision Default: -1</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The newly created cell object. Returns nothing if the command fails.</returns>
		public TTCL create_bd_cell(String vlnv, String name, String type = null, String reference = null, String revision = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_bd_cell [-vlnv <arg>] [-type <arg>] [-reference <arg>] [-revision <arg>] [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_bd_cell(vlnv, name, type, reference, revision, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new design and its top level hierarchy cell with the same name.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_bd_design [-dir &lt;arg&gt;] [-cell &lt;arg&gt;] [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Create a new IP subsystem design module to add to the current project, and for use with the IP<br/>
		/// integrator of the Vivado Design Suite.<br/>
		/// An empty IP subsystem module is created and added to the source files of the current project.<br/>
		/// The subsystem module and file are created with the specified &lt;name&gt; in the current project at:<br/>
		/// &lt;project_name&gt;/&lt;project_name&gt;.srcs/sources_1/bd/&lt;name&gt;/&lt;name&gt;.bd<br/>
		/// This command returns the file path and name of the IP subsystem design created if the command<br/>
		/// is successful. An error is returned if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 227<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of design to create</param>
		/// <param name="dir">
		/// <para>
		/// (Optional)<br/>
		/// Directory path for remote BD to be created and managed<br/>
		/// outside the project<br/>
		/// </para>
		/// </param>
		/// <param name="cell">(Optional) hierarchical cell name which sub design to be copied into new design</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The newly created design object, "" if failed.</returns>
		public TTCL create_bd_design(String name, String dir = null, String cell = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_bd_design [-dir <arg>] [-cell <arg>] [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_bd_design(name, dir, cell, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new intf_net.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_bd_intf_net [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Create a new IP integrator interface net for the subsystem design.<br/>
		/// This command returns the newly created interface net object if successful, and returns noting if it<br/>
		/// failed.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 229<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of intf_net to create</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The newly created intf_net object, "" if failed.</returns>
		public TTCL create_bd_intf_net(String name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_bd_intf_net [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_bd_intf_net(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new intf_pin.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_bd_intf_pin [-vlnv &lt;arg&gt;] [-mode &lt;arg&gt;] [-quiet] [-verbose] [&lt;name&gt;]
		/// <br/>
		/// <para>
		/// Create a new interface pin on an IP integrator hierarchical module. An IP integrator interface is a<br/>
		/// grouping of signals that share a common function, and can include both individual signals and<br/>
		/// buses that share a related function. An AXI4-Lite master, for example, is an interface that<br/>
		/// includes a large number of individual signals plus multiple buses.<br/>
		/// To create a single connection pin, or standard bus pin, use the create_bd_pin command.<br/>
		/// Interface pins connect with other compatible interface pins, or interface ports. The interface pin<br/>
		/// is added as a port inside the hierarchical module, to connect outside of the module, and as a pin<br/>
		/// on the hierarchical module.<br/>
		/// You must define the hierarchical module as the current instance in the IP integrator subsystem<br/>
		/// design, using the current_bd_instance command. The current instance is the target of the<br/>
		/// create_bd_intf_pin command.<br/>
		/// This command returns the name of the newly created interface pin object if successful, and<br/>
		/// returns an error if it failed.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 231<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of intf_pin to create</param>
		/// <param name="vlnv">(Optional) Bus vlnv</param>
		/// <param name="mode">(Optional) Bus interface mode</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The newly created intf_pin object, "" if failed.</returns>
		public TTCL create_bd_intf_pin(String name, String vlnv = null, String mode = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_bd_intf_pin [-vlnv <arg>] [-mode <arg>] [-quiet] [-verbose] [<name>]
			_tcl.Entry(_builder.create_bd_intf_pin(name, vlnv, mode, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new interface port.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_bd_intf_port [-vlnv &lt;arg&gt;] [-mode &lt;arg&gt;] [-quiet] [-verbose] [&lt;name&gt;]
		/// <br/>
		/// <para>
		/// Create a new IP integrator subsystem design interface port. An IP integrator interface is a<br/>
		/// grouping of signals that share a common function, and can include both individual signals and<br/>
		/// buses that share a related function. An AXI4-Lite master, for example, is an interface that<br/>
		/// includes a large number of individual signals plus multiple buses.<br/>
		/// To create a single connection port, or common bus port, use the create_bd_port command.<br/>
		/// This command returns the name of the newly created interface port object if successful, and<br/>
		/// returns nothing if it failed.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 233<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of port to create</param>
		/// <param name="vlnv">(Optional) Bus vlnv</param>
		/// <param name="mode">(Optional) Bus interface mode</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The newly created interface port object, "" if failed.</returns>
		public TTCL create_bd_intf_port(String name, String vlnv = null, String mode = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_bd_intf_port [-vlnv <arg>] [-mode <arg>] [-quiet] [-verbose] [<name>]
			_tcl.Entry(_builder.create_bd_intf_port(name, vlnv, mode, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new TLM interface port.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_bd_intf_tlm_port -vlnv &lt;arg&gt; -mode &lt;arg&gt; [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 235<br/>
		/// </para>
		/// </summary>
		/// <param name="vlnv">(Required) TLM interface vlnv</param>
		/// <param name="mode">(Required) TLM interface mode</param>
		/// <param name="name">(Required) TLM interface name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The newly created TLM interface port object, "" if failed.</returns>
		public TTCL create_bd_intf_tlm_port(String vlnv, String mode, String name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_bd_intf_tlm_port -vlnv <arg> -mode <arg> [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_bd_intf_tlm_port(vlnv, mode, name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new net.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_bd_net [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Create a new net in the current IP integrator subsystem design.<br/>
		/// This command returns the newly created net object, or returns an error if failed.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 236<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of net to create</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The newly created net object, "" if failed.</returns>
		public TTCL create_bd_net(String name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_bd_net [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_bd_net(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new pin.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_bd_pin [-from &lt;arg&gt;] [-to &lt;arg&gt;] -dir &lt;arg&gt; [-type &lt;arg&gt;] [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Create a new pin to add to an IP integrator hierarchical module.<br/>
		/// This command returns the name of the newly created pin object, or returns an error message if it<br/>
		/// failed.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a new input pin on the specified module in the current IP<br/>
		/// integrator subsystem design:<br/>
		/// create_bd_pin -dir I -type rst /newMod1/rst<br/>
		/// /newMod1/rst<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 238<br/>
		/// </para>
		/// </summary>
		/// <param name="dir">(Required) Pin direction</param>
		/// <param name="name">(Required) Name of pin to create</param>
		/// <param name="from">(Optional) Begin index Default: Unspecified</param>
		/// <param name="to">(Optional) End index Default: Unspecified</param>
		/// <param name="type">(Optional) Pin type</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The newly created pin object, "" if failed.</returns>
		public TTCL create_bd_pin(String dir, String name, String from = null, String to = null, String type = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_bd_pin [-from <arg>] [-to <arg>] -dir <arg> [-type <arg>] [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_bd_pin(dir, name, from, to, type, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new port for an IP subsystem design.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_bd_port [-from &lt;arg&gt;] [-to &lt;arg&gt;] -dir &lt;arg&gt; [-type &lt;arg&gt;] [-freq_hz &lt;arg&gt;] [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Create a new port to add to an IP integrator subsystem design. The port is a connection to<br/>
		/// signals external to the subsystem design.<br/>
		/// This command returns the name of the newly created port object, or returns an error message if<br/>
		/// it failed.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a new bidirectional bus port in the current IP integrator<br/>
		/// subsystem design:<br/>
		/// create_bd_port -from 0 -to 32 -dir IO -type data addr<br/>
		/// /addr<br/>
		/// The following example creates a new 125 MHz clock port:<br/>
		/// create_bd_port -dir I -type clk -freq_hz 125000000 my_clock<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 240<br/>
		/// </para>
		/// </summary>
		/// <param name="dir">(Required) Port direction. Valid values are I, O, or IO.</param>
		/// <param name="name">(Required) Name of port to create</param>
		/// <param name="from">(Optional) Beginning index Default: Unspecified</param>
		/// <param name="to">(Optional) Ending index Default: Unspecified</param>
		/// <param name="type">(Optional) Port type. Valid values are clk, ce, rst, intr, data.</param>
		/// <param name="freq_hz">(Optional) Frequency in Hertz for clock ports Default: Unspecified</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The newly created port object. Returns nothing if the command fails.</returns>
		public TTCL create_bd_port(String dir, String name, String from = null, String to = null, String type = null, String freq_hz = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_bd_port [-from <arg>] [-to <arg>] -dir <arg> [-type <arg>] [-freq_hz <arg>] [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_bd_port(dir, name, from, to, type, freq_hz, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new TLM port for an IP subsystem design.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_bd_tlm_port [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 242<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of port to create</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The newly created TLM port object. Returns nothing if the command fails.</returns>
		public TTCL create_bd_tlm_port(String name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_bd_tlm_port [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_bd_tlm_port(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set or get current design.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_bd_design [-quiet] [-verbose] [&lt;design&gt;]
		/// <br/>
		/// <para>
		/// Defines the current IP subsystem design for use with the IP integrator of the Vivado Design<br/>
		/// Suite, or returns the name of the current design in the active project.<br/>
		/// The current IP subsystem design and current IP subsystem instance are the target of most of the<br/>
		/// IP integrator Tcl commands and design changes made in the tool. The current IP subsystem<br/>
		/// instance can be defined using the current_bd_instance command.<br/>
		/// You can use the get_bd_designs command to get a list of open IP subsystem designs in the<br/>
		/// active project.<br/>
		/// A complete list of IP integrator Tcl commands can be returned using the following command from<br/>
		/// the Vivado Design Suite Tcl shell:<br/>
		/// load_features IPIntegrator<br/>
		/// help -category IPintegrator<br/>
		/// Note: The load_features command is only needed if the IP integrator is not currently loaded in the<br/>
		/// Vivado Design Suite.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets the IP subsystem design as the current design:<br/>
		/// current_bd_design design_1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 375<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="design">(Optional) Name of current design to be set</param>
		/// <returns>The current design object, "" if failed.</returns>
		public TTCL current_bd_design(bool? quiet = null, bool? verbose = null, String design = null)
		{
			// TCL Syntax: current_bd_design [-quiet] [-verbose] [<design>]
			_tcl.Entry(_builder.current_bd_design(quiet, verbose, design));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set or get current cell instance.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_bd_instance [-quiet] [-verbose] [&lt;instance&gt;]
		/// <br/>
		/// <para>
		/// Set or get the current hierarchical cell instance in the current IP integrator subsystem design, as<br/>
		/// defined by current_bd_design. The current instance is referenced from the top-level of the<br/>
		/// subsystem design hierarchy, or "/".<br/>
		/// This command returns the current IP integrator cell instance object, or returns nothing if the<br/>
		/// command failed.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets the current instance in the subsystem design to the specified module:<br/>
		/// current_bd_instance module2<br/>
		/// The following example returns the current instance:<br/>
		/// current_bd_instance .<br/>
		/// This example resets the current instance of the subsystem design to the top level of the<br/>
		/// hierarchy:<br/>
		/// current_instance /<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 377<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="instance">(Optional) Name of current cell instance to be set</param>
		/// <returns>The current cell instance object, "" if failed.</returns>
		public TTCL current_bd_instance(bool? quiet = null, bool? verbose = null, String instance = null)
		{
			// TCL Syntax: current_bd_instance [-quiet] [-verbose] [<instance>]
			_tcl.Entry(_builder.current_bd_instance(quiet, verbose, instance));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Delete specified objects.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_bd_objs [-quiet] [-verbose] &lt;objects&gt;...
		/// <br/>
		/// <para>
		/// Delete specified objects from the current IP integrator subsystem design.<br/>
		/// Objects must be passed directly to the delete_bd_objs command, and not simply referenced<br/>
		/// by the object name. Pins are passed to the command by get_bd_pins, for instance, rather than<br/>
		/// by pin name.<br/>
		/// This command returns nothing if it is successful, and returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 428<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) The objects to be deleted</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Pass if successful in deleting objects</returns>
		public TTCL delete_bd_objs(TCLParameterList objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_bd_objs [-quiet] [-verbose] <objects>...
			_tcl.Entry(_builder.delete_bd_objs(objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Disconnect an intf_net.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: disconnect_bd_intf_net [-quiet] [-verbose] &lt;intf_net&gt; &lt;objects&gt;...
		/// <br/>
		/// <para>
		/// Disconnect a single interface net in the IP integrator subsystem design from the specified<br/>
		/// objects. An interface is a grouping of signals that share a common function in the IP integrator<br/>
		/// subsystem design.<br/>
		/// This command lets you disconnect the specified interface net from pins or ports in the IP<br/>
		/// subsystem design, without deleting the whole net. To delete the whole net, you should use the<br/>
		/// delete_bd_objs command.<br/>
		/// This command returns TCL_OK if it is successful, or TCL_ERROR if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 490<br/>
		/// </para>
		/// </summary>
		/// <param name="intf_net">(Required) The IntfNet that the objects connect to</param>
		/// <param name="objects">(Required) The objects to disconnect from the intf_net</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>TCL_OK, TCL_ERROR if failed.</returns>
		public TTCL disconnect_bd_intf_net(String intf_net, TCLParameterList objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: disconnect_bd_intf_net [-quiet] [-verbose] <intf_net> <objects>...
			_tcl.Entry(_builder.disconnect_bd_intf_net(intf_net, objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Disconnect a net from the object.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: disconnect_bd_net [-quiet] [-verbose] &lt;net&gt; &lt;objects&gt;...
		/// <br/>
		/// <para>
		/// Disconnect a single net in the IP integrator subsystem design from the specified objects.<br/>
		/// This command lets you disconnect the specified nets from pins or ports in the IP subsystem<br/>
		/// design, without deleting the whole net. To delete the whole net, you should use the<br/>
		/// delete_bd_objs command.<br/>
		/// This command returns TCL_OK if it is successful, or TCL_ERROR if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 492<br/>
		/// </para>
		/// </summary>
		/// <param name="net">(Required) The Net that the objects connect to</param>
		/// <param name="objects">(Required) The objects to disconnect from the net</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>TCL_OK, TCL_ERROR if failed.</returns>
		public TTCL disconnect_bd_net(String net, TCLParameterList objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: disconnect_bd_net [-quiet] [-verbose] <net> <objects>...
			_tcl.Entry(_builder.disconnect_bd_net(net, objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Exclude segment from an address space.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: exclude_bd_addr_seg [-target_address_space &lt;arg&gt;] [-quiet] [-verbose] [&lt;segment_to_exclude&gt;]
		/// <br/>
		/// <para>
		/// Exclude the specified AXI peripheral address segment from access by the AXI master it is<br/>
		/// mapped to, in order to support sparse connectivity and eliminate unneeded device resources.<br/>
		/// This command lets you exclude specific peripherals from being accessed by specific AXI masters.<br/>
		/// For example, in the case where AXI peripherals P0 and P1 are connected to two masters M0 and<br/>
		/// M1, you can use sparse connectivity to let M0 access both P0 and P1, and let M1 accesses P1,<br/>
		/// but exclude it from P0.<br/>
		/// In the IP integrator block design, address segments of AXI peripherals will have one of three<br/>
		/// states:<br/>
		/// • Unmapped - An AXI peripheral, or slave interface, is connected to an AXI master, but the<br/>
		/// peripheral has not been assigned an address segment in the master's address space and is not<br/>
		/// visible to the master.<br/>
		/// • Mapped - The AXI peripheral is mapped into the AXI master's address space, assigned an<br/>
		/// address segment or range, and is accessible through the master.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • Excluded - The AXI peripheral is mapped to the AXI master, and has been assigned an address,<br/>
		/// but is not accessible to the master. The address segment that the AXI slave occupies within<br/>
		/// the master address space is also considered filled.<br/>
		/// The purpose of excluding the address segment is to restrict access to peripherals that are<br/>
		/// connected to multiple masters. The validate_bd_design command will return a critical<br/>
		/// warning if a peripheral interface is connected to a master, but not mapped to an address segment<br/>
		/// of that master. However, by excluding the peripheral after it is mapped, the resources required to<br/>
		/// connect and provide access between the AXI master and the peripheral (the muxes and decoding<br/>
		/// for example) can be eliminated to conserve resources on the implemented design.<br/>
		/// TIP: When running assign_bd_address, the IP integrator will map unmapped address segments into<br/>
		/// address spaces, but will not map excluded address spaces.<br/>
		/// This command offers two syntaxes, for a previously mapped address segment, and an unmapped<br/>
		/// address segment:<br/>
		/// exclude_bd_addr_seg &lt;master_addr_seg&gt;<br/>
		/// exclude_bd_addr_seg -target_address_space &lt;master_addr_space&gt;<br/>
		/// &lt;slave_addr_seg&gt;<br/>
		/// In the second command syntax, when a slave segment is specified, the slave will first be assigned<br/>
		/// or mapped to the specified AXI master address space, and then it will be excluded from access by<br/>
		/// the master.<br/>
		/// This command returns nothing if successful, or returns an error if it failed.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 509<br/>
		/// </para>
		/// </summary>
		/// <param name="target_address_space">(Optional) Target address space to exclude the slave segment from</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="segment_to_exclude">(Optional) segment to exclude</param>
		/// <returns>The newly excluded segment object, "" if failed.</returns>
		public TTCL exclude_bd_addr_seg(String target_address_space = null, bool? quiet = null, bool? verbose = null, String segment_to_exclude = null)
		{
			// TCL Syntax: exclude_bd_addr_seg [-target_address_space <arg>] [-quiet] [-verbose] [<segment_to_exclude>]
			_tcl.Entry(_builder.exclude_bd_addr_seg(target_address_space, quiet, verbose, segment_to_exclude));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Export current design as a static example design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: export_as_example_design -vlnv &lt;arg&gt; [-no_ip_version] [-force] [-quiet] [-verbose] -directory &lt;arg&gt;
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 514<br/>
		/// </para>
		/// </summary>
		/// <param name="vlnv">(Required) VLNV of the example design to be generated</param>
		/// <param name="directory">(Required) Destination directory in which example design needs to be generated</param>
		/// <param name="no_ip_version">
		/// <para>
		/// (Optional)<br/>
		/// Flag to not include the IP version as part of the IP VLNV in<br/>
		/// create_bd_cell commands.<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) create a directory if it does not exist</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL export_as_example_design(String vlnv, String directory, bool? no_ip_version = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: export_as_example_design -vlnv <arg> [-no_ip_version] [-force] [-quiet] [-verbose] -directory <arg>
			_tcl.Entry(_builder.export_as_example_design(vlnv, directory, no_ip_version, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Find a list of pins, ports or interfaces with a given relationship to the given object.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: find_bd_objs -relation &lt;arg&gt; [-boundary_type &lt;arg&gt;] [-thru_hier] [-stop_at_interconnect] [-stop_at_container] [-end_type &lt;arg&gt;] [-quiet] [-verbose] &lt;objects&gt;...
		/// <br/>
		/// <para>
		/// Find a list of pins, ports or interfaces with a given relationship to the specified objects.<br/>
		/// This command returns a list of pins, ports or interface objects if successful, or returns an error if<br/>
		/// it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 529<br/>
		/// </para>
		/// </summary>
		/// <param name="relation">
		/// <para>
		/// (Required)<br/>
		/// Relation to the input objs: connected_to, addressable_slave,<br/>
		/// addressing_master. 'connected_to' will find corresponding<br/>
		/// pins, ports or interfaces that are connected to the given<br/>
		/// source objects, across hierarchy boundaries.<br/>
		/// </para>
		/// </param>
		/// <param name="objects">
		/// <para>
		/// (Required)<br/>
		/// One or more source object to start finding from<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// </param>
		/// <param name="boundary_type">
		/// <para>
		/// (Optional)<br/>
		/// Used when source object is an hierarchical block's pin or<br/>
		/// interface pin. Valid values are empty string for same level<br/>
		/// (default), 'lower', or 'all'. If 'lower' boundary, searches from<br/>
		/// within hierarchy. This option is only valid for relation:<br/>
		/// connected_to<br/>
		/// </para>
		/// </param>
		/// <param name="thru_hier">
		/// <para>
		/// (Optional)<br/>
		/// Flag used to ignore boundary of hierarchical blocks. If used<br/>
		/// used with boundary_type 'lower', flag will only affect the<br/>
		/// hierarchical blocks within parent hierarchical block.<br/>
		/// </para>
		/// </param>
		/// <param name="stop_at_interconnect">
		/// <para>
		/// (Optional)<br/>
		/// Flag used to stop at the axi_interconnect's boundary when -<br/>
		/// thru_hier is used.<br/>
		/// </para>
		/// </param>
		/// <param name="stop_at_container">
		/// <para>
		/// (Optional)<br/>
		/// Flag used to stop at the container's boundary when -<br/>
		/// thru_hier is used.<br/>
		/// </para>
		/// </param>
		/// <param name="end_type">
		/// <para>
		/// (Optional)<br/>
		/// Only to be used with objects that are pins or ports and bus<br/>
		/// interface pins or ports. For pins/ports - Default is to return<br/>
		/// the sink objects for a given source object and to return the<br/>
		/// source object for a given sink object. If 'all' is used for a<br/>
		/// given sink object, will return both source and other sink<br/>
		/// objectst that are connected to the source object. For bus<br/>
		/// interface pins/ports - Default is to return the end<br/>
		/// connection that is non-monitor interfaces. If 'monitor' is<br/>
		/// used, will only return the monitor interfaces. If 'all' is used,<br/>
		/// will return both end connection and monitor interfaces. If<br/>
		/// 'master', will return master interfaces and if 'slave', will<br/>
		/// return slave interfaces.This option is only valid for relation:<br/>
		/// connected_to<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>List of pins, ports or interface objects, "" if failed.</returns>
		public TTCL find_bd_objs(String relation, TCLParameterList objects, String boundary_type = null, bool? thru_hier = null, bool? stop_at_interconnect = null, bool? stop_at_container = null, String end_type = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: find_bd_objs -relation <arg> [-boundary_type <arg>] [-thru_hier] [-stop_at_interconnect] [-stop_at_container] [-end_type <arg>] [-quiet] [-verbose] <objects>...
			_tcl.Entry(_builder.find_bd_objs(relation, objects, boundary_type, thru_hier, stop_at_interconnect, stop_at_container, end_type, quiet, verbose));
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
		public TTCL generate_target(String name, String objects, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_target [-force] [-quiet] [-verbose] <name> <objects>
			_tcl.Entry(_builder.generate_target(name, objects, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of segments<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_bd_addr_segs [-regexp] [-hierarchical] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-excluded] [-addressed] [-unaddressed] [-addressing] [-addressables] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Get a list of address segments in the current IP integrator subsystem design.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the address segments of the specified address spaces:<br/>
		/// get_bd_addr_segs -of_objects [get_bd_addr_spaces -of_objects \<br/>
		/// [get_bd_cells /microblaze_1]]<br/>
		/// /microblaze_1/Data/SEG1<br/>
		/// /microblaze_1/Data/SEG3<br/>
		/// /microblaze_1/Instruction/SEG2<br/>
		/// Note: If there are no objects matching the pattern you will get a warning.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 555<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="hierarchical">(Optional) Hierarchical cells included</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get segments of these segments, interfaces, or registers</param>
		/// <param name="excluded">(Optional) Get excluded mapped segments -of_objects</param>
		/// <param name="addressed">(Optional) Get addressed segments of given -of_objects</param>
		/// <param name="unaddressed">(Optional) Get unaddressed segments of given objects</param>
		/// <param name="addressing">(Optional) Get addressing segments of given -of_objects</param>
		/// <param name="addressables">(Optional) Get addressable segments of given -of_objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match engine names against patterns Default: *</param>
		/// <returns>List of segment objects, "" if failed.</returns>
		public TTCL get_bd_addr_segs(bool? regexp = null, bool? hierarchical = null, String filter = null, TCLParameterList of_objects = null, bool? excluded = null, bool? addressed = null, bool? unaddressed = null, bool? addressing = null, bool? addressables = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_bd_addr_segs [-regexp] [-hierarchical] [-filter <arg>] [-of_objects <args>] [-excluded] [-addressed] [-unaddressed] [-addressing] [-addressables] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_bd_addr_segs(regexp, hierarchical, filter, of_objects, excluded, addressed, unaddressed, addressing, addressables, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of addr_spaces<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_bd_addr_spaces [-regexp] [-hierarchical] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Get a list of address spaces in the current IP integrator subsystem design.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example lists all of the address spaces in the current IP integrator subsystem<br/>
		/// design, listing one per line:<br/>
		/// join [get_bd_addr_spaces] \n<br/>
		/// /mdm_1/S_AXI<br/>
		/// /microblaze_1/Data<br/>
		/// /microblaze_1/Instruction<br/>
		/// /microblaze_1_axi_intc/s_axi<br/>
		/// /microblaze_1_local_memory/dlmb_bram_if_cntlr/SLMB<br/>
		/// /microblaze_1_local_memory/dlmb_bram_if_cntlr/SLMB1<br/>
		/// /microblaze_1_local_memory/dlmb_bram_if_cntlr/SLMB2<br/>
		/// /microblaze_1_local_memory/dlmb_bram_if_cntlr/SLMB3<br/>
		/// /microblaze_1_local_memory/dlmb_bram_if_cntlr/S_AXI_CTRL<br/>
		/// /microblaze_1_local_memory/ilmb_bram_if_cntlr/SLMB<br/>
		/// /microblaze_1_local_memory/ilmb_bram_if_cntlr/SLMB1<br/>
		/// /microblaze_1_local_memory/ilmb_bram_if_cntlr/SLMB2<br/>
		/// /microblaze_1_local_memory/ilmb_bram_if_cntlr/SLMB3<br/>
		/// /microblaze_1_local_memory/ilmb_bram_if_cntlr/S_AXI_CTRL<br/>
		/// /microblaze_1_local_memory/lmb_bram/S_1<br/>
		/// Note: If there are no objects matching the pattern you will get a warning.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example returns all of the properties attached to the third in a list, or index 2, of all<br/>
		/// address spaces in the current subsystem design:<br/>
		/// report_property -all [lindex [get_bd_addr_spaces] 2 ]<br/>
		/// Property Type Read-only Visible Value<br/>
		/// CLASS string true true bd_addr_space<br/>
		/// NAME string false true /microblaze_1/Instruction<br/>
		/// OFFSET string false true<br/>
		/// PATH string true true /microblaze_1/Instruction<br/>
		/// RANGE string false true -1<br/>
		/// TYPE string false true<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 559<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="hierarchical">(Optional) Hierarchical cells included</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get addr_spaces of these segments or interfaces</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match engine names against patterns Default: *</param>
		/// <returns>List of addr_space objects, "" if failed.</returns>
		public TTCL get_bd_addr_spaces(bool? regexp = null, bool? hierarchical = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_bd_addr_spaces [-regexp] [-hierarchical] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_bd_addr_spaces(regexp, hierarchical, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of block diagram cells<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_bd_cells [-regexp] [-hierarchical] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Get a list of cells in the current IP integrator subsystem design, or current subsystem instance. IP<br/>
		/// integrator subsystem cells are either IP cores drawn from the IP integrator catalog, or hierarchical<br/>
		/// modules created in the subsystem design with the create_bd_cell command.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of cells that include the specified IP integrator subsystem pin,<br/>
		/// and sorts the list to remove duplicate entries:<br/>
		/// lsort -unique [get_bd_cells -of_objects [get_bd_pins -hierarchical *aclk*]]<br/>
		/// Note: If there are no cells matching the pattern you will get a warning.<br/>
		/// The following example gets a list of all cells in all levels of the subsystem design hierarchy, and<br/>
		/// then filters the list to include only those cells whose name includes the specified text, or<br/>
		/// hierarchy:<br/>
		/// get_bd_cells -hierarchical -filter {NAME=~"/newMod1/*"}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 563<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="hierarchical">(Optional) Hierarchical cells included</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get cells of these pins or nets</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match engine names against patterns Default: *</param>
		/// <returns>List of block diagram cell objects, "" if failed.</returns>
		public TTCL get_bd_cells(bool? regexp = null, bool? hierarchical = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_bd_cells [-regexp] [-hierarchical] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_bd_cells(regexp, hierarchical, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of designs<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_bd_designs [-regexp] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of IP subsystem designs open in the current project that match a specified search<br/>
		/// pattern. The default command gets a list of all open IP subsystem designs in the project.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets all open IP subsystem designs in the current project:<br/>
		/// get_bd_designs<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 567<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get diagrams of these bd-cells or pins or nets</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match engine names against patterns Default: *</param>
		/// <returns>List of design objects, "" if failed.</returns>
		public TTCL get_bd_designs(bool? regexp = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_bd_designs [-regexp] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_bd_designs(regexp, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of intf_nets<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_bd_intf_nets [-regexp] [-hierarchical] [-filter &lt;arg&gt;] [-boundary_type &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of interface nets in the current IP integrator subsystem design that match a specified<br/>
		/// search pattern. The default command gets a list of all interface nets in the subsystem design.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the interface net attached to the specified pin of an IP integrator<br/>
		/// hierarchical module, and returns both the net at the level of the hierarchical module, and the net<br/>
		/// inside the hierarchical module:<br/>
		/// get_bd_intf_nets -boundary_type both -of_objects [get_bd_pins /newMod1/aclk]<br/>
		/// Note: If there are no interface nets matching the pattern you will get a warning.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example returns a list of all interface nets at all levels of the IP integrator<br/>
		/// subsystem design hierarchy:<br/>
		/// get_bd_intf_nets -hierarchical<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 570<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="hierarchical">(Optional) Hierarchical cells included</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="boundary_type">
		/// <para>
		/// (Optional)<br/>
		/// Used when source object is on a hierarchical block's<br/>
		/// interface pin. Valid values are 'upper', 'lower', or 'both'. If<br/>
		/// 'lower' boundary, searches from the lower level of hierarchy<br/>
		/// onwards. This option is only valid for connected_to relations.<br/>
		/// </para>
		/// </param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// One or a list of cells or interface pins/ports objects. List<br/>
		/// must be of one object type.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match engine names against patterns Default: *</param>
		/// <returns>List of pin objects, "" if failed.</returns>
		public TTCL get_bd_intf_nets(bool? regexp = null, bool? hierarchical = null, String filter = null, String boundary_type = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_bd_intf_nets [-regexp] [-hierarchical] [-filter <arg>] [-boundary_type <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_bd_intf_nets(regexp, hierarchical, filter, boundary_type, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of intf_pins<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_bd_intf_pins [-regexp] [-hierarchical] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of interface pin objects on the current IP subsystem design that match a specified<br/>
		/// search pattern. The default command gets a list of all interface pins in the subsystem design.<br/>
		/// The external connections of an IP integrator cell, or hierarchical module, are pins and interface<br/>
		/// pins. The external connections in an IP subsystem design are ports, or interface ports. Use the<br/>
		/// get_bd_ports and get_bd_intf_ports commands to select the port objects.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of interface pins attached to the specified cell:<br/>
		/// get_bd_intf_pins -of [get_bd_cells new_vidOut_1]<br/>
		/// Note: If there are no interface pins matching the pattern, the tool will return a warning.<br/>
		/// The following example gets a list of all interface pins, throughout the hierarchy of the IP<br/>
		/// integrator subsystem design, which match the specified name pattern:<br/>
		/// get_bd_intf_pins -hierarchical m_apb*<br/>
		/// The following example gets a list of interface pins attached to the specified subsystem net:<br/>
		/// get_bd_intf_pins -of [get_bd_intf_nets vidout_1_vtg_ce]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 574<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="hierarchical">(Optional) Hierarchical cells included</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// One or a list of cells, interface nets or pins objects. List must<br/>
		/// be of one object type.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match engine names against patterns Default: *</param>
		/// <returns>List of pin objects, "" if failed.</returns>
		public TTCL get_bd_intf_pins(bool? regexp = null, bool? hierarchical = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_bd_intf_pins [-regexp] [-hierarchical] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_bd_intf_pins(regexp, hierarchical, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of intf_ports<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_bd_intf_ports [-regexp] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of interface port objects in the current IP integrator subsystem design that match a<br/>
		/// specified search pattern. The default command gets a list of all interface ports in the subsystem<br/>
		/// design.<br/>
		/// The external connections in an IP subsystem design are ports, or interface ports. The external<br/>
		/// connections in an IP integrator cell, or hierarchical module, are pins and interface pins. Use the<br/>
		/// get_bd_pins and get_bd_intf_pins commands to select the pin objects.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the interface ports in the subsystem design that operate in Master<br/>
		/// mode:<br/>
		/// get_bd_intf_ports -filter {MODE=="master"}<br/>
		/// Note: If there are no interface ports matching the pattern, the tool will return a warning.<br/>
		/// This example returns the block design interface port that the specified bd_port is part of:<br/>
		/// get_bd_intf_ports -of [get_bd_ports sys_diff_clock_clk_n]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 578<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) One or a list of interface nets or ports objects.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match engine names against patterns Default: *</param>
		/// <returns>List of port objects, "" if failed.</returns>
		public TTCL get_bd_intf_ports(bool? regexp = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_bd_intf_ports [-regexp] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_bd_intf_ports(regexp, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of nets<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_bd_nets [-regexp] [-hierarchical] [-filter &lt;arg&gt;] [-boundary_type &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of nets in the current IP integrator subsystem design that match a specified search<br/>
		/// pattern. The default command gets a list of all nets in the subsystem design.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the net attached to the specified pin of an IP integrator hierarchical<br/>
		/// module, and returns both the net at the level of the hierarchical module, and the net inside the<br/>
		/// hierarchical module:<br/>
		/// get_bd_nets -boundary_type both -of_objects [get_bd_pins /newMod1/aclk]<br/>
		/// Note: If there are no nets matching the pattern you will get a warning.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example returns a list of all nets at all levels of the IP integrator subsystem design<br/>
		/// hierarchy:<br/>
		/// get_bd_nets -hierarchical<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 581<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="hierarchical">(Optional) Hierarchical cells included</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="boundary_type">
		/// <para>
		/// (Optional)<br/>
		/// Used when source object is on a hierarchical block's pin.<br/>
		/// Valid values are 'upper', 'lower', or 'both'. If 'lower'<br/>
		/// boundary, searches from the lower level of hierarchy<br/>
		/// onwards. This option is only valid for connected_to relations.<br/>
		/// </para>
		/// </param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// One or a list of cells or pins/ports objects. List must be of<br/>
		/// one object type.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match engine names against patterns Default: *</param>
		/// <returns>List of pin objects, "" if failed.</returns>
		public TTCL get_bd_nets(bool? regexp = null, bool? hierarchical = null, String filter = null, String boundary_type = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_bd_nets [-regexp] [-hierarchical] [-filter <arg>] [-boundary_type <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_bd_nets(regexp, hierarchical, filter, boundary_type, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of pins<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_bd_pins [-regexp] [-hierarchical] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of pin objects on the current IP subsystem design that match a specified search<br/>
		/// pattern. The default command gets a list of all pins in the subsystem design.<br/>
		/// The external connections in an IP integrator cell, or hierarchical module, are pins and interface<br/>
		/// pins. The external connections in an IP subsystem design are ports, or interface ports. Use the<br/>
		/// get_bd_ports and get_bd_intf_ports commands to select the port objects.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of pins attached to the specified cell:<br/>
		/// get_bd_pins -of [get_bd_cells new_vidOut_1]<br/>
		/// Note: If there are no pins matching the pattern, the tool will return a warning.<br/>
		/// The following example gets a list of all pins, throughout the hierarchy of the IP integrator<br/>
		/// subsystem design, which match the specified name pattern:<br/>
		/// get_bd_pins -hierarchical LMB*<br/>
		/// The following example gets a list of pins attached to the specified subsystem net:<br/>
		/// get_bd_pins -of [get_bd_nets vidout_1_vtg_ce]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 585<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="hierarchical">(Optional) Hierarchical cells included</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// One or a list of cells, nets or interface pins objects. List must<br/>
		/// be of one object type.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match engine names against patterns Default: *</param>
		/// <returns>List of pin objects, "" if failed.</returns>
		public TTCL get_bd_pins(bool? regexp = null, bool? hierarchical = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_bd_pins [-regexp] [-hierarchical] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_bd_pins(regexp, hierarchical, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of ports<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_bd_ports [-regexp] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of port objects in the current IP integrator subsystem design that match a specified<br/>
		/// search pattern. The default command gets a list of all ports in the subsystem design.<br/>
		/// The external connections in an IP subsystem design are ports, or interface ports. The external<br/>
		/// connections in an IP integrator cell, or hierarchical module, are pins and interface pins. Use the<br/>
		/// get_bd_pins and get_bd_intf_pins commands to select the pin objects.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the ports connected to the specified IP subsystem net:<br/>
		/// get_bd_ports -of_objects [get_bd_nets bridge_1_apb_m]<br/>
		/// Note: If there are no ports matching the pattern, the tool will return a warning.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 589<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) One or a list of nets or interface ports objects.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match engine names against patterns Default: *</param>
		/// <returns>List of port objects, "" if failed.</returns>
		public TTCL get_bd_ports(bool? regexp = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_bd_ports [-regexp] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_bd_ports(regexp, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of registers<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_bd_regs [-of_objects &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Get a list of registers using the objects of address segments, interface pins, and external interface<br/>
		/// ports. The register objects will provide the register's display name and the memory offset<br/>
		/// address. There is no default behavior for this command as it requires the use of -of_objects<br/>
		/// argument with a valid value that is an object of the address segments, interface pins, or external<br/>
		/// interface ports. The command will get the registers directly from the address segment objects or<br/>
		/// from address segments associated with the specified interface pin or interface port objects.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates an external interface pin, assigns an address space, and then gets<br/>
		/// the registers associated with that address space:<br/>
		/// % create_bd_cell -type ip -vlnv xilinx.com:ip:axi_gpio:2.0 axi_gpio_0<br/>
		/// % make_bd_intf_pins_external [get_bd_intf_pins axi_gpio_0/S_AXI]<br/>
		/// % assign_bd_address<br/>
		/// % get_bd_addr_segs<br/>
		/// /axi_gpio_0/S_AXI/Reg /S_AXI_0/SEG_axi_gpio_0_Reg<br/>
		/// % set seg [get_bd_addr_segs /axi_gpio_0/S_AXI/Reg]<br/>
		/// /axi_gpio_0/S_AXI/Reg<br/>
		/// % get_bd_regs -of_objects $seg<br/>
		/// GPIO_DATA GPIO_TRI GPIO2_DATA GPIO2_TRI GIER IP_IER IP_ISR<br/>
		/// %set regs [get_bd_regs -of_objects $seg]<br/>
		/// GPIO_DATA GPIO_TRI GPIO2_DATA GPIO2_TRI GIER IP_IER IP_ISR<br/>
		/// % set reg [lindex $regs 0]<br/>
		/// GPIO_DATA<br/>
		/// % report_property $reg<br/>
		/// Property Type Read-only Visible Value<br/>
		/// CLASS string true true bd_reg<br/>
		/// DISPLAYNAME string true true Channel_1_GPIO_DATA<br/>
		/// NAME string true true GPIO_DATA<br/>
		/// OFFSET string true true 0x0<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 592<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Required) Get registers of segments, interface pins, external interface ports</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>List of register objects, "" if failed.</returns>
		public TTCL get_bd_regs(TCLParameterList of_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_bd_regs [-of_objects <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_bd_regs(of_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of example designs<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_example_designs [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// The command returns a list of example designs available in the current release of the Vivado<br/>
		/// Design Suite, or returns an error if it fails.<br/>
		/// Example designs can be opened, or instantiated into the Vivado Design Suite, onto specific target<br/>
		/// hardware devices or boards.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns reports the properties of each of the example designs in the<br/>
		/// current release:<br/>
		/// foreach x [get_example_designs] {<br/>
		/// puts "********* Design $x **************"<br/>
		/// report_property -all $x}<br/>
		/// Note: The reported properties include the PARTS property which lists the compatible parts for the example<br/>
		/// design.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 688<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// The patterns to match against Default: * Values: The default<br/>
		/// search pattern is the wildcard *, or .* when -regexp is<br/>
		/// specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of design objects</returns>
		public TTCL get_example_designs(bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_example_designs [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_example_designs(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of IPI example designs<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_template_bd_designs [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// The command returns the list of template block designs available in the current release of the<br/>
		/// Vivado Design Suite, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the list of available block design templates in the current release:<br/>
		/// get_template_bd_designs<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 942<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of IPI design objects</returns>
		public TTCL get_template_bd_designs(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_template_bd_designs [-quiet] [-verbose]
			_tcl.Entry(_builder.get_template_bd_designs(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a hierarchical cell, and then move the group of cells into the hierarchy cell. The<br/>
		/// connections between these cells are maintained; the connections between these cells and other<br/>
		/// cells are maintained through crossing hierarchy cell.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: group_bd_cells [-prefix &lt;arg&gt;] [-quiet] [-verbose] [&lt;target_cell_name&gt;] [&lt;cells&gt;...]
		/// <br/>
		/// <para>
		/// Create a new hierarchical module in the current IP integrator subsystem design, and move the<br/>
		/// specified cells into that module.<br/>
		/// You can also optionally move a group of specified cells into the hierarchical module. The<br/>
		/// connections between the specified cells are maintained. The connections between the cells being<br/>
		/// moved are maintained; connections between these cells and other cells that are not being moved<br/>
		/// are maintained automatically by IP integrator adding pins and ports to cross the hierarchical<br/>
		/// boundary.<br/>
		/// You can also move cells into the hierarchical module by using the move_bd_cells command<br/>
		/// after the hierarchical module has been created using the create_bd_cells command.<br/>
		/// The command returns the name of the created hierarchical module if successful, or an error<br/>
		/// message if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 967<br/>
		/// </para>
		/// </summary>
		/// <param name="target_cell_name">(Required) Target cell</param>
		/// <param name="cells">(Required) Match engine names against cell names Default: *</param>
		/// <param name="prefix">(Optional) Prefix name to add to cells</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>0 if success.</returns>
		public TTCL group_bd_cells(String target_cell_name, TCLParameterList cells, String prefix = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: group_bd_cells [-prefix <arg>] [-quiet] [-verbose] [<target_cell_name>] [<cells>...]
			_tcl.Entry(_builder.group_bd_cells(target_cell_name, cells, prefix, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// include segment from an address space.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: include_bd_addr_seg [-quiet] [-verbose] [&lt;segment_to_include&gt;]
		/// <br/>
		/// <para>
		/// Reverses the exclusion of an AXI peripheral address segment from access by the AXI master, and<br/>
		/// restores the address segment to a mapped state.<br/>
		/// In the block design, address segments of AXI peripherals can have one of three states:<br/>
		/// • Unmapped - An AXI peripheral, or slave interface, is connected to an AXI master, but the<br/>
		/// peripheral has not been assigned an address segment in the master's address space and is not<br/>
		/// visible to the master.<br/>
		/// • Mapped - The AXI peripheral is mapped into the AXI master's address space, assigned an<br/>
		/// address segment or range, and is accessible through the master.<br/>
		/// • Excluded - The AXI peripheral is mapped to the AXI master, and has been assigned an address<br/>
		/// segment, but is not accessible to the master. The address segment that the AXI slave occupies<br/>
		/// within the master address space is also considered filled.<br/>
		/// The exclude_bd_addr_seg command lets you exclude specific address segments from access<br/>
		/// by the AXI master they are mapped to. The include_bd_addr_seg restores access to the<br/>
		/// mapped address segment.<br/>
		/// This command returns nothing if successful, or returns an error if it failed.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 995<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="segment_to_include">(Optional) Segment to include</param>
		/// <returns>The newly included segment object, "" if failed.</returns>
		public TTCL include_bd_addr_seg(bool? quiet = null, bool? verbose = null, String segment_to_include = null)
		{
			// TCL Syntax: include_bd_addr_seg [-quiet] [-verbose] [<segment_to_include>]
			_tcl.Entry(_builder.include_bd_addr_seg(quiet, verbose, segment_to_include));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Creates an example design from a predefined template in an open project.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: instantiate_example_design [-design &lt;arg&gt;] [-hier &lt;arg&gt;] [-project &lt;arg&gt;] [-project_location &lt;arg&gt;] [-options &lt;args&gt;] [-quiet] [-verbose] &lt;template&gt;
		/// <br/>
		/// <para>
		/// This command creates an example design from a predefined template in an open project. The<br/>
		/// target part specified by the open project must be compatible with the example design, as defined<br/>
		/// in the SUPPORTED_PARTS property of the example, or an error is returned.<br/>
		/// For the embedded processor example designs, base_microblaze and base_zynq, the example<br/>
		/// design must be created in an open block design in the Vivado IP integrator. Embedded processor<br/>
		/// example designs require the use of a board as defined by the BOARD_PART property, rather than<br/>
		/// a target part. Refer to the current_board_part command for more information.<br/>
		/// The command returns the name of the example design used and a transcript of commands; or it<br/>
		/// returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a new project as specified, overwriting an existing project of the<br/>
		/// same name if one is found, specifies the BOARD_PART property for the project, creates a new<br/>
		/// empty block design in the Vivado IP integrator, and then instantiates the Zynq embedded<br/>
		/// processor example design:<br/>
		/// create_project zynq1 -force<br/>
		/// set_property BOARD_PART em.avnet.com:zed:1.3 [current_project]<br/>
		/// create_bd_design myFirstZynq<br/>
		/// instantiate_example_design -design myFirstZynq \<br/>
		/// [lindex [get_example_designs] 1]<br/>
		/// This example reports the configurable properties of the specified example design:<br/>
		/// report_property [lindex [get_example_designs] 3] CONFIG.*<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This example creates a new empty project as specified, sets a target BOARD for the project,<br/>
		/// creates and opens a new empty block design, and then instantiates the configurable example<br/>
		/// design:<br/>
		/// create_project mb1 C:/Data/Vivado_Tutorial/Tutorial_Created_Data/mb1<br/>
		/// set_property board_part xilinx.com:kcu105:part0:1.1 [current_project]<br/>
		/// create_bd_design design_1<br/>
		/// instantiate_example_design -design design_1 \<br/>
		/// -options { Data_Cache.VALUE 8K Include_DDR4.VALUE true \<br/>
		/// Local_memory.VALUE 128K }\<br/>
		/// xilinx.com:design:config_mb:1.0<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 999<br/>
		/// </para>
		/// </summary>
		/// <param name="template">(Required) Configurable Design Name</param>
		/// <param name="design">(Optional) Block Design Name</param>
		/// <param name="hier">(Optional) Hierarchy Block</param>
		/// <param name="project">(Optional) Project Name</param>
		/// <param name="project_location">(Optional) Project location Default: .</param>
		/// <param name="options">(Optional) Configurable options</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Returns the name of the template applied.</returns>
		public TTCL instantiate_example_design(String template, String design = null, String hier = null, String project = null, String project_location = null, TCLParameterList options = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: instantiate_example_design [-design <arg>] [-hier <arg>] [-project <arg>] [-project_location <arg>] [-options <args>] [-quiet] [-verbose] <template>
			_tcl.Entry(_builder.instantiate_example_design(template, design, hier, project, project_location, options, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Creates a block design in IP integrator from a predefined template.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: instantiate_template_bd_design -design &lt;arg&gt; [-hier &lt;arg&gt;] [-options &lt;args&gt;] [-quiet] [-verbose] &lt;template&gt;
		/// <br/>
		/// <para>
		/// This command creates an example design from a template Block Design in the IP integrator of<br/>
		/// the Vivado Design Suite.<br/>
		/// The template diagram is created in an existing and open block design. In addition, the target part<br/>
		/// specified by the current project or in-memory project must be compatible with the template<br/>
		/// design or an error is returned.<br/>
		/// The command returns a transcript of its process, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example builds the specified template block design in the specified design:<br/>
		/// instantiate_template_bd_design -design myFirstZynq \<br/>
		/// [lindex [get_template_bd_designs] 1]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1002<br/>
		/// </para>
		/// </summary>
		/// <param name="design">(Required) Block Design Name</param>
		/// <param name="template">(Required) Configurable Design Name</param>
		/// <param name="hier">(Optional) Hierarchy Block</param>
		/// <param name="options">(Optional) Configurable options</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Returns the name of the template applied.</returns>
		public TTCL instantiate_template_bd_design(String design, String template, String hier = null, TCLParameterList options = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: instantiate_template_bd_design -design <arg> [-hier <arg>] [-options <args>] [-quiet] [-verbose] <template>
			_tcl.Entry(_builder.instantiate_template_bd_design(design, template, hier, options, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create external port for the corresponding interface pins. If a cell is specified, create external<br/>
		/// interface ports for all unconnected interface pins.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: make_bd_intf_pins_external [-quiet] [-verbose] &lt;objects&gt;...
		/// <br/>
		/// <para>
		/// Create an external interface port in the current block design and connect that to the selected<br/>
		/// block interface pin. If a bd_cell is specified as the argument, all unconnected block interface pins<br/>
		/// of that cell will be made external. The created external interface port will have the same<br/>
		/// properties as the selected block interface pin.<br/>
		/// IMPORTANT! For a group of block interface pins, one external port will be created per block interface pin.<br/>
		/// The selected block interface pin, if unconnected, will be connected to a new interface port at the<br/>
		/// top-most level of the block design.<br/>
		/// This command returns TCL_OK if it is successful, or TCL_ERROR if it fails, unless -quiet is<br/>
		/// specified.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example will select the specified block interface pin on the bd_cell axi_gpio_0,<br/>
		/// and connect it to an external interface port:<br/>
		/// make_bd_intf_pins_external [get_bd_intf_pins axi_gpio_0/S_AXI]<br/>
		/// The following example will look at all unconnected block interface pins of the bd_cell<br/>
		/// axi_gpio_0 and individually connect them to external interface ports:<br/>
		/// make_bd_intf_pins_external [get_bd_cells axi_gpio_0]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1053<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) The interface pins/cells to be made external</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Pass if successful in creating at least one interface port</returns>
		public TTCL make_bd_intf_pins_external(TCLParameterList objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: make_bd_intf_pins_external [-quiet] [-verbose] <objects>...
			_tcl.Entry(_builder.make_bd_intf_pins_external(objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create external port for the corresponding pin. If a cell is specified, create external ports for all<br/>
		/// unconnected pins.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: make_bd_pins_external [-quiet] [-verbose] &lt;objects&gt;...
		/// <br/>
		/// <para>
		/// Create an external port in the current block design and connect that to the selected block pin. If<br/>
		/// a bd_cell is specified as the argument, all unconnected block pins of that cell will be made<br/>
		/// external. The created external port will have the same properties as the selected block pin.<br/>
		/// IMPORTANT! For a group of block pins, one external port will be created per block pin.<br/>
		/// The selected block pin, if unconnected, will be connected to a new port at the topmost level of<br/>
		/// the block design.<br/>
		/// This command returns TCL_OK if it is successful, or TCL_ERROR if it fails, unless -quiet is<br/>
		/// specified.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example will select a block pin on the bd_cell axi_gpio_0 and connect it to an<br/>
		/// external port:<br/>
		/// make_bd_pins_external [get_bd_pins axi_gpio_0/s_axi_aclk]<br/>
		/// The following example will look at all unconnected block pins of the bd_cell axi_gpio_0 and<br/>
		/// individually connect them to external ports:<br/>
		/// make_bd_pins_external [get_bd_cells axi_gpio_0]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1055<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) The pins/cells to be made external</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Pass if successful in creating at least one port</returns>
		public TTCL make_bd_pins_external(TCLParameterList objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: make_bd_pins_external [-quiet] [-verbose] <objects>...
			_tcl.Entry(_builder.make_bd_pins_external(objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Move cells into a hierarchy cell. The connections between these cells are maintained; the<br/>
		/// connections between these cells and other cells are maintained through crossing hierarchy cell.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: move_bd_cells [-prefix &lt;arg&gt;] [-quiet] [-verbose] [&lt;parent_cell&gt;] [&lt;cells&gt;...]
		/// <br/>
		/// <para>
		/// Move IP integrator cells into the specified hierarchical module within the current subsystem<br/>
		/// design. The connections between the cells being moved are maintained; connections between<br/>
		/// these cells and other cells that are not being moved are maintained automatically by IP integrator<br/>
		/// adding pins and ports to cross the hierarchical boundary.<br/>
		/// Cells in the IP subsystem design can also be copied into a hierarchical module using<br/>
		/// copy_bd_objs, and can be grouped and added to a hierarchical module using<br/>
		/// group_bd_cells.<br/>
		/// This command returns the name of the &lt;parent_cell&gt; module when successful, or returns an<br/>
		/// error message if it failed.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1066<br/>
		/// </para>
		/// </summary>
		/// <param name="prefix">(Optional) Prefix name to add to cells</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="parent_cell">(Optional) Parent cell</param>
		/// <param name="cells">(Optional) Match engine names against cell names Default: *</param>
		/// <returns>0 if success.</returns>
		public TTCL move_bd_cells(String prefix = null, bool? quiet = null, bool? verbose = null, String parent_cell = null, TCLParameterList cells = null)
		{
			// TCL Syntax: move_bd_cells [-prefix <arg>] [-quiet] [-verbose] [<parent_cell>] [<cells>...]
			_tcl.Entry(_builder.move_bd_cells(prefix, quiet, verbose, parent_cell, cells));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Open an existing IP subsystem design from disk file.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: open_bd_design [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Open an IP subsystem design in the IP integrator of the Vivado IDE. The IP subsystem must<br/>
		/// previously have been created using the create_bd_design command.<br/>
		/// This command returns a message with the name of the opened IP subsystem design, or returns<br/>
		/// an error if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following opens the specified IP subsystem design in the current project:<br/>
		/// open_bd_design C:/Data/project1/project1.src/sources_1/bd/design_1/<br/>
		/// design_1.bd<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1073<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of IP subsystem design to open</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The design object. Returns nothing if the command fails.</returns>
		public TTCL open_bd_design(String name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: open_bd_design [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.open_bd_design(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Read one or more IPIntegrator design files<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_bd [-quiet] [-verbose] &lt;files&gt;...
		/// <br/>
		/// <para>
		/// Read the specified IP subsystem design files, or block designs, into the current project or the in-memory design. This command is similar to the add_files command. The block design file is<br/>
		/// added to the source fileset as it is read.<br/>
		/// RECOMMENDED: Files are read and referenced from their current location, and are not moved into the<br/>
		/// local project directories. To bring the file into the local project, use the import_files command<br/>
		/// instead.<br/>
		/// You can use this command to read block designs into the in-memory design, when running the<br/>
		/// Vivado tool in Non Project mode, in which there is no project file to maintain and manage the<br/>
		/// various project source files. Refer to the Vivado Design Suite User Guide: Design Flows Overview<br/>
		/// (UG892) for more information on Non Project mode.<br/>
		/// This command returns the name of the IP subsystem design files read, or returns an error if it<br/>
		/// fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reads the specified IP subsystem design into the current project:<br/>
		/// read_bd C:/Data/block_designs/design1.bd<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1151<br/>
		/// </para>
		/// </summary>
		/// <param name="files">(Required) IPIntegrator design file name(s)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of IPIntegrator design file objects that were added</returns>
		public TTCL read_bd(TCLParameterList files, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_bd [-quiet] [-verbose] <files>...
			_tcl.Entry(_builder.read_bd(files, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Regenerate layout.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: regenerate_bd_layout [-hierarchy &lt;arg&gt;] [-layout_file &lt;arg&gt;] [-routing] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Regenerate the layout of the current IP integrator subsystem design in the open canvas. This<br/>
		/// command updates and redraws the graphical elements of the subsystem design in the Vivado<br/>
		/// IDE.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1224<br/>
		/// </para>
		/// </summary>
		/// <param name="hierarchy">(Optional) Hierarchy path to the window</param>
		/// <param name="layout_file">(Optional) layout file previously exported by write_bd_layout using native format</param>
		/// <param name="routing">(Optional) Preserve placement of blocks and regenerate routing</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL regenerate_bd_layout(String hierarchy = null, String layout_file = null, bool? routing = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: regenerate_bd_layout [-hierarchy <arg>] [-layout_file <arg>] [-routing] [-quiet] [-verbose]
			_tcl.Entry(_builder.regenerate_bd_layout(hierarchy, layout_file, routing, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Replace cell1 with cell2 by disconnecting connections to cell1 and connecting those connections<br/>
		/// to cell2.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: replace_bd_cell [-preserve_name] [-preserve_configuration] [-quiet] [-verbose] [&lt;cell1&gt;] [&lt;cell2&gt;...]
		/// <br/>
		/// <para>
		/// Move the connections currently assigned to one IP integrator cell to another IP integrator cell in<br/>
		/// the current design. This is intended to help you quickly replace one cell with another by moving<br/>
		/// connections from the source cell to the target cell.<br/>
		/// The current, or existing cell, will be relocated from its current position in the block design, and<br/>
		/// the new replacing cell will be placed at that location. Connections to the pins and interface pins<br/>
		/// on the cell are preserved where possible, and result in a Critical Warning when connections must<br/>
		/// be removed.<br/>
		/// IMPORTANT! This command is not supported by the UNDO command.<br/>
		/// This command returns TCL_OK if it is successful, or returns TCL_ERROR if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1288<br/>
		/// </para>
		/// </summary>
		/// <param name="cell1">(Required) Cell with connections that are to be disconnected.</param>
		/// <param name="preserve_name">(Optional) cell2 will rename as cell1's name, cell1 rename as cell1name_old</param>
		/// <param name="preserve_configuration">(Optional) preserve configuration of cell1 on cell2</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="cell2">(Optional) Cell to be connected to connections that were disconnected from cell1.</param>
		/// <returns>TCL_OK, TCL_ERROR if failed.</returns>
		public TTCL replace_bd_cell(String cell1, bool? preserve_name = null, bool? preserve_configuration = null, bool? quiet = null, bool? verbose = null, TCLParameterList cell2 = null)
		{
			// TCL Syntax: replace_bd_cell [-preserve_name] [-preserve_configuration] [-quiet] [-verbose] [<cell1>] [<cell2>...]
			_tcl.Entry(_builder.replace_bd_cell(cell1, preserve_name, preserve_configuration, quiet, verbose, cell2));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report differences between two block designs. Note this TCL command may compare bus-interface parameters from IP .xit files that are not reported in the stand-alone diffbd executable.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_bd_diffs [-format &lt;arg&gt;] [-file &lt;arg&gt;] [-open_html] [-brief] [-strict] [-fast] [-return_string] [-depth &lt;arg&gt;] [-crossprobe] [-repository &lt;arg&gt;] [-take_snapshot] [-diff_snapshot] [-quiet] [-verbose] &lt;design1&gt; &lt;design2&gt;
		/// <br/>
		/// <para>
		/// Analyze and report the difference between two block design files (.bd).<br/>
		/// TIP: There is also a standalone version of this command, diffbd , that can be run from the command<br/>
		/// line. You can find out more information about this command by typing diffbd -h from the command<br/>
		/// line. Refer to the Vivado Design Suite User Guide: Designing IP Subsystems using IP Integrator (UG994) for<br/>
		/// more informaiton.<br/>
		/// This command performs a non-graphical comparison of two block designs to let you compare<br/>
		/// revisions of a block design from within revision control systems. Block designs must be specified<br/>
		/// as BD objects, as returned by current_bd_design, or get_bd_designs commands. The<br/>
		/// design objects can have the same name, but be returned from different .bd files. An error will be<br/>
		/// returned if the BD objects refer to the same design.<br/>
		/// The differences reported include additions, or changes to the IP in use in the block diagram,<br/>
		/// changes to design properties or parameters, changes to the design hierarchy, changes to<br/>
		/// connectivity, and changes memory addressing.<br/>
		/// This command returns the difference report for the two block designs specified, or returns an<br/>
		/// error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example compares the two specified block designs, one from a file path, the<br/>
		/// second from the current open block design, and creates and opens an HTML report format with<br/>
		/// the specified depth:<br/>
		/// report_bd_diffs C:/Data/Base_Zynq_MPSoC.bd [current_bd_design] \<br/>
		/// -file C:/Data/diffs5.htm -open_html -depth 5<br/>
		/// The following example takes a snapshot of the current open block design:<br/>
		/// report_bd_diffs -take_snapshot<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1291<br/>
		/// </para>
		/// </summary>
		/// <param name="design1">(Required) Name or file path of first block design to compare</param>
		/// <param name="design2">(Required) Name or file path of second block design to compare</param>
		/// <param name="format">(Optional) Format: html or text Default: text</param>
		/// <param name="file">(Optional) Optional output file name. *.htm* implies HTML format</param>
		/// <param name="open_html">(Optional) Open HTML report in a browser. Sets format to HTML</param>
		/// <param name="brief">(Optional) Output only whether files differ. Don't write report</param>
		/// <param name="strict">(Optional) Non-functional changes are treated as functional changes</param>
		/// <param name="fast">
		/// <para>
		/// (Optional)<br/>
		/// Read BD JSON directly instead of creating in-memory BDs<br/>
		/// when possible. Will not compare Bus-Interface parameters<br/>
		/// from .XIT files (same as stand-alone diffbd)<br/>
		/// </para>
		/// </param>
		/// <param name="return_string">(Optional) (Text only) Return the report as a string</param>
		/// <param name="depth">
		/// <para>
		/// (Optional)<br/>
		/// HTML Display Depth for equal items. Used to limit HTML file<br/>
		/// size. Does not affect not-equal items. Implies HTML format.<br/>
		/// Default: 4<br/>
		/// </para>
		/// </param>
		/// <param name="crossprobe">
		/// <para>
		/// (Optional)<br/>
		/// Enable links on HTML report to select Vivado objects.<br/>
		/// Implies open_html<br/>
		/// </para>
		/// </param>
		/// <param name="repository">(Optional) User repository for designs on disk</param>
		/// <param name="take_snapshot">(Optional) Take a snapshot of the current block design</param>
		/// <param name="diff_snapshot">(Optional) Compare the current block design against a snapshot</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>0 if no functional differences, &gt;0 if different, -1 on error</returns>
		public TTCL report_bd_diffs(String design1, String design2, String format = null, String file = null, bool? open_html = null, bool? brief = null, bool? strict = null, bool? fast = null, bool? return_string = null, String depth = null, bool? crossprobe = null, String repository = null, bool? take_snapshot = null, bool? diff_snapshot = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_bd_diffs [-format <arg>] [-file <arg>] [-open_html] [-brief] [-strict] [-fast] [-return_string] [-depth <arg>] [-crossprobe] [-repository <arg>] [-take_snapshot] [-diff_snapshot] [-quiet] [-verbose] <design1> <design2>
			_tcl.Entry(_builder.report_bd_diffs(design1, design2, format, file, open_html, brief, strict, fast, return_string, depth, crossprobe, repository, take_snapshot, diff_snapshot, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Save an existing IP subsystem design to disk file.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: save_bd_design [-quiet] [-verbose] [&lt;name&gt;]
		/// <br/>
		/// <para>
		/// Saves any changes to the current or specified IP subsystem design in the IP integrator of the<br/>
		/// Vivado Design Suite.<br/>
		/// This command returns TCL_OK if it is successful, or TCL_ERROR if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example saves the current IP subsystem design in the current project:<br/>
		/// save_bd_design<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1567<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="name">(Optional) Name of design to save.</param>
		/// <returns>TCL_OK, TCL_ERROR if failed.</returns>
		public TTCL save_bd_design(bool? quiet = null, bool? verbose = null, String name = null)
		{
			// TCL Syntax: save_bd_design [-quiet] [-verbose] [<name>]
			_tcl.Entry(_builder.save_bd_design(quiet, verbose, name));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Save a copy of the existing IP subsystem design to specified disk file with a different name.<br/>
		/// Generated output products will not be saved.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: save_bd_design_as [-dir &lt;arg&gt;] [-ignore_comments] [-force] [-quiet] [-verbose] [&lt;name&gt;]
		/// <br/>
		/// <para>
		/// Save a copy of an existing block design from the IP integrator to a new location, or with a<br/>
		/// different name. The generated output products of the block design will not be saved to the new<br/>
		/// block design.<br/>
		/// Note: You cannot create a copy of a block design that has locked IP. The IP must be unlocked or the<br/>
		/// command will return an error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example saves the current block design to the specified directory, and renames it<br/>
		/// to the specified name:<br/>
		/// save_bd_design_as -dir C:/Data new_Block<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1569<br/>
		/// </para>
		/// </summary>
		/// <param name="dir">
		/// <para>
		/// (Optional)<br/>
		/// Directory path for remote BD to be created and managed.<br/>
		/// This is required if a name is not specified<br/>
		/// </para>
		/// </param>
		/// <param name="ignore_comments">(Optional) Do not save user comments</param>
		/// <param name="force">(Optional) Overwrite existing file if present</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="name">
		/// <para>
		/// (Optional)<br/>
		/// Name of the design to create. This is required if a directory<br/>
		/// is not specified<br/>
		/// </para>
		/// </param>
		/// <returns>TCL_OK, TCL_ERROR if failed.</returns>
		public TTCL save_bd_design_as(String dir = null, bool? ignore_comments = null, bool? force = null, bool? quiet = null, bool? verbose = null, String name = null)
		{
			// TCL Syntax: save_bd_design_as [-dir <arg>] [-ignore_comments] [-force] [-quiet] [-verbose] [<name>]
			_tcl.Entry(_builder.save_bd_design_as(dir, ignore_comments, force, quiet, verbose, name));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Move the group of cells inside a hierarchy cell to its parent cell, and then remove the hierarchical<br/>
		/// cell. The connections between these cells are maintained; the connections between these cells<br/>
		/// and other cells are maintained through crossing hierarchy cell.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: ungroup_bd_cells [-prefix &lt;arg&gt;] [-quiet] [-verbose] [&lt;cells&gt;...]
		/// <br/>
		/// <para>
		/// This command is intended to undo the grouping of IP integrator cells into a hierarchical module,<br/>
		/// by either the group_bd_cells or the move_bd_cells commands. The command moves the<br/>
		/// cells inside a selected hierarchical module up one level to the parent cell, and then removes the<br/>
		/// hierarchical module.<br/>
		/// The connections between the selected cells are maintained. The connections between these cells<br/>
		/// and other cells are maintained automatically by removing unneeded subsystem ports and pins.<br/>
		/// This command returns 0 if successful, or an error message if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1748<br/>
		/// </para>
		/// </summary>
		/// <param name="cells">(Required) Match engine names against cell names Default: *</param>
		/// <param name="prefix">(Optional) Prefix name to add to cells</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>0 if success.</returns>
		public TTCL ungroup_bd_cells(TCLParameterList cells, String prefix = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: ungroup_bd_cells [-prefix <arg>] [-quiet] [-verbose] [<cells>...]
			_tcl.Entry(_builder.ungroup_bd_cells(cells, prefix, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// update the boundary of source designs of a specified block design container cell from its active<br/>
		/// variant source design or a specified design. Otherwise, update the boundary of a block design<br/>
		/// from another block design provided<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: update_bd_boundaries [-from_bd &lt;arg&gt;] [-check_only] [-quiet] [-verbose] [&lt;of_objects&gt;...]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1760<br/>
		/// </para>
		/// </summary>
		/// <param name="from_bd">(Optional) block design to copy the boundary from</param>
		/// <param name="check_only">
		/// <para>
		/// (Optional)<br/>
		/// report only the changes made when the boundary is copied,<br/>
		/// do not save the changes to disk<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// One or a list of block design container cells enabled for<br/>
		/// Dynamic Function Exchange or block desing names. List<br/>
		/// must be of one object type.<br/>
		/// </para>
		/// </param>
		/// <returns>TCL_OK on success, TCL_ERROR on failure.</returns>
		public TTCL update_bd_boundaries(String from_bd = null, bool? check_only = null, bool? quiet = null, bool? verbose = null, TCLParameterList of_objects = null)
		{
			// TCL Syntax: update_bd_boundaries [-from_bd <arg>] [-check_only] [-quiet] [-verbose] [<of_objects>...]
			_tcl.Entry(_builder.update_bd_boundaries(from_bd, check_only, quiet, verbose, of_objects));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Upgrade configurable IPIntegrator cell(s) to later version<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: upgrade_bd_cells [-latest &lt;arg&gt;] [-quiet] [-verbose] &lt;objects&gt;...
		/// <br/>
		/// <para>
		/// Upgrade IP integrator cells to the latest version available in the IP integrator catalog.<br/>
		/// This command lets you update IP integrator subsystem designs from an earlier release to use the<br/>
		/// IP cores from the latest catalog.<br/>
		/// This command returns the list of IP integrator cells that were upgraded, or returns an error if it<br/>
		/// fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1786<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) IPIntegrator cells to be upgraded</param>
		/// <param name="latest">(Optional) Upgrade the IPIntegrator block to the latest version</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>List of IPIntegrator cell names those were upgraded, "" if failed.</returns>
		public TTCL upgrade_bd_cells(TCLParameterList objects, String latest = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: upgrade_bd_cells [-latest <arg>] [-quiet] [-verbose] <objects>...
			_tcl.Entry(_builder.upgrade_bd_cells(objects, latest, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Run Parameter Propagation for specified design or for a specific cell.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: validate_bd_design [-force] [-design &lt;arg&gt;] [-include_pfm] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Validate an IP integrator subsystem design, or IP cell or hierarchical module.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example validates the current IP integrator subsystem design, forcing re-validation<br/>
		/// if needed:<br/>
		/// validate_bd_design -force<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1794<br/>
		/// </para>
		/// </summary>
		/// <param name="force">(Optional) Force re-run validation on the design</param>
		/// <param name="design">
		/// <para>
		/// (Optional)<br/>
		/// Design name. If not specified, run parameter propagation<br/>
		/// on current design<br/>
		/// </para>
		/// </param>
		/// <param name="include_pfm">(Optional) including validate pfm attributes on the design</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>TCL_OK, TCL_ERROR if failed.</returns>
		public TTCL validate_bd_design(bool? force = null, String design = null, bool? include_pfm = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: validate_bd_design [-force] [-design <arg>] [-include_pfm] [-quiet] [-verbose]
			_tcl.Entry(_builder.validate_bd_design(force, design, include_pfm, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Export the current design to a Tcl file on disk.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_bd_tcl [-force] [-bd_name &lt;arg&gt;] [-no_mig_contents] [-no_ip_version] [-ignore_minor_versions] [-bd_folder &lt;arg&gt;] [-check_ips &lt;arg&gt;] [-hier_blks &lt;arg&gt;] [-include_layout] [-exclude_layout] [-make_local] [-no_project_wrapper] [-exclude_pfm] [-updated_pfm_attrs] [-quiet] [-verbose] &lt;tcl_filename&gt;
		/// <br/>
		/// <para>
		/// Export the current IP integrator subsystem design as a Tcl script file to the disk.<br/>
		/// IMPORTANT! Any directory in the path specified by the &lt;name&gt; option must already exist, or the script<br/>
		/// will not be created.<br/>
		/// The Tcl script file lets you recreate, reuse, and customize IP integrator subsystem designs without<br/>
		/// having to archive the original subsystem design.<br/>
		/// When working with a new software release, you must use the output script from the<br/>
		/// write_bd_tcl command to create a block design in the same software release as the Tcl script<br/>
		/// was generated. This ensures the availability of the needed versions of any IP used in the script.<br/>
		/// You can then migrate the created block design into a new software release.<br/>
		/// This command returns TCL_OK if it is successful, or TCL_ERROR if it fails, unless -quiet is<br/>
		/// specified.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1820<br/>
		/// </para>
		/// </summary>
		/// <param name="tcl_filename">(Required) Name of exported Tcl file</param>
		/// <param name="force">(Optional) Flag to overwrite existing file.</param>
		/// <param name="bd_name">
		/// <para>
		/// (Optional)<br/>
		/// Name for block diagram. By default will use current block<br/>
		/// diagram's name.<br/>
		/// </para>
		/// </param>
		/// <param name="no_mig_contents">
		/// <para>
		/// (Optional)<br/>
		/// Flag to not include MIG PRJ contents into generated Tcl<br/>
		/// script, but instead will load PRJ from working directory.<br/>
		/// Default is to include MIG PRJ contents in Tcl script.<br/>
		/// </para>
		/// </param>
		/// <param name="no_ip_version">
		/// <para>
		/// (Optional)<br/>
		/// Flag to not include the IP version as part of the IP VLNV in<br/>
		/// create_bd_cell commands. NOTE - this may have<br/>
		/// implications if there are major IP version changes.<br/>
		/// </para>
		/// </param>
		/// <param name="ignore_minor_versions">
		/// <para>
		/// (Optional)<br/>
		/// Use this flag to create the cells in the design using their<br/>
		/// latest minor version. For example, a project contains<br/>
		/// versions of blk_mem_gen IP like 7.3, 7.4, 8.3, 8.4. In the<br/>
		/// design there is a blk_mem_gen_v7.4. With this flag,<br/>
		/// write_bd_tcl will generate the line: create_bd_cell -type ip -<br/>
		/// vlnv xilinx.com:ip:blk_mem_gen:7.* bmg_0_v7. When the<br/>
		/// generated Tcl script is sourced, the cell bmg_0_v7 will use<br/>
		/// the latest blk_mem_gen_v7.<br/>
		/// </para>
		/// </param>
		/// <param name="bd_folder">
		/// <para>
		/// (Optional)<br/>
		/// Remote BD feature - Specify the folder where the design will<br/>
		/// be generated when Tcl script is sourced.<br/>
		/// </para>
		/// </param>
		/// <param name="check_ips">
		/// <para>
		/// (Optional)<br/>
		/// By default value = true, therefore, will check if IPs/modules<br/>
		/// exist in the IP catalog or project before continuing to<br/>
		/// reconstruct the design. Valid values are (true/false), (yes/<br/>
		/// no), or (1/0).<br/>
		/// </para>
		/// </param>
		/// <param name="hier_blks">
		/// <para>
		/// (Optional)<br/>
		/// Comma separated list of hierarchical blocks in the design<br/>
		/// that will be generated by the Tcl script. Will include any sub-hierachical blocks within the specified blocks too. This<br/>
		/// option will not create the top-level design portion.<br/>
		/// </para>
		/// </param>
		/// <param name="include_layout">
		/// <para>
		/// (Optional)<br/>
		/// By default will NOT include the GUI layout of the design. Use<br/>
		/// this argument to include the layout information in the<br/>
		/// generated Tcl script.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Name Description<br/>
		/// </para>
		/// </param>
		/// <param name="exclude_layout">
		/// <para>
		/// (Optional)<br/>
		/// NOTE - This flag will be obsolete in a near future release, but<br/>
		/// is currently supported for backwards compatibility. Use this<br/>
		/// argument to not include the layout information in the<br/>
		/// generated Tcl script.<br/>
		/// </para>
		/// </param>
		/// <param name="make_local">(Optional) Use this flag when you want to write your remote BD out as a local BD.</param>
		/// <param name="no_project_wrapper">
		/// <para>
		/// (Optional)<br/>
		/// This option is used to write the BD create TCL procs without<br/>
		/// any project wrapper.<br/>
		/// </para>
		/// </param>
		/// <param name="exclude_pfm">(Optional) Use this flag to exclude pfm attributes for this design</param>
		/// <param name="updated_pfm_attrs">
		/// <para>
		/// (Optional)<br/>
		/// Use this flag to update the pfms to remove connected<br/>
		/// ports/interfaces from the values.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>TCL_OK, TCL_ERROR if failed.</returns>
		public TTCL write_bd_tcl(String tcl_filename, bool? force = null, String bd_name = null, bool? no_mig_contents = null, bool? no_ip_version = null, bool? ignore_minor_versions = null, String bd_folder = null, String check_ips = null, String hier_blks = null, bool? include_layout = null, bool? exclude_layout = null, bool? make_local = null, bool? no_project_wrapper = null, bool? exclude_pfm = null, bool? updated_pfm_attrs = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_bd_tcl [-force] [-bd_name <arg>] [-no_mig_contents] [-no_ip_version] [-ignore_minor_versions] [-bd_folder <arg>] [-check_ips <arg>] [-hier_blks <arg>] [-include_layout] [-exclude_layout] [-make_local] [-no_project_wrapper] [-exclude_pfm] [-updated_pfm_attrs] [-quiet] [-verbose] <tcl_filename>
			_tcl.Entry(_builder.write_bd_tcl(tcl_filename, force, bd_name, no_mig_contents, no_ip_version, ignore_minor_versions, bd_folder, check_ips, hier_blks, include_layout, exclude_layout, make_local, no_project_wrapper, exclude_pfm, updated_pfm_attrs, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
