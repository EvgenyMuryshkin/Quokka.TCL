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
		///
		/// IP integrator provides the Designer Assistance feature, using the apply_bd_automation
		/// command, to automatically configure and/or add other relevant IP integrator cells around a
		/// selected IP integrator object. For more information on the Designer Assistance features refer to
		/// the Vivado Design Suite User Guide: Designing with IP (UG896) or the Vivado Design Suite User
		/// Guide: Designing IP Subsystems Using IP Integrator (UG994).
		/// Currently block and connection automation exists for cells, interfaces, pins and ports. The Block
		/// Automation feature is provided for certain complex blocks such as the Zynq device, MicroBlaze
		/// processor, AXI Ethernet and memory IP.
		/// The Connection Automation feature helps automate different types of connections. For instance
		/// when connecting Slave AXI-MM interfaces, the automation will also connect up the relevant
		/// clock and reset pins and also create an interconnect if one is required. Connection Automation
		/// may also help with board-level connections; connecting pins and interfaces from relevant cells, to
		/// external ports and interfaces, and applying appropriate board constraints on these external I/Os.
		/// Note: This IP integrator command is issued from within the Vivado IDE via the Designer Assistance GUI
		/// feature. It is recommended that you make use of this command in IP integrator through the Vivado IDE,
		/// rather than directly from Tcl scripts. Use the write_bd_tcl command to output Tcl for use within a user
		/// script.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 96
		/// </summary>
		/// <param name="rule">
		/// Required
		/// Rule ID string
		/// </param>
		/// <param name="config">
		/// Required
		/// List of parameter value pairs
		/// </param>
		/// <param name="dict">
		/// Required
		/// List of objects and corresponding parameter name-value
		/// pairs.
		/// </param>
		/// <param name="opts">
		/// Required
		/// List of settings that apply to all objects in this rule.
		/// </param>
		/// <param name="objects">
		/// Required
		/// The objects to run the automation rule on
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>Returns success or failure</returns>
		public void apply_bd_automation(string rule, string config, string dict, string opts, string objects, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("apply_bd_automation");
			_tcl.Add(command);
		}
		/// <summary>
		/// Applies board connections to given designs
		///
		/// Connects the interface pin of an IP core in the specified block design to the interface of the
		/// current board part in the current project or design.
		/// The board part provides a representation of the Xilinx device in the context of the board-level
		/// system, and can help define key aspects of the design, such as clock constraints, I/O port
		/// assignments, and supported interfaces. The board part file stores information regarding board
		/// attributes. The file, called board_part.xml, is located in the data/boards/board_parts
		/// folder of the Vivado Design Suite installation area.
		/// The command lets you quickly connect compatible interface pins of an IP integrator block design
		/// to the appropriate interface definition on the current board part. To make the connection
		/// between the IP core to the board part, the IP integrator of the Vivado Design Suite adds an
		/// external interface port and interface connection to the block design. The added external
		/// interface port is named for the specified board part interface.
		/// The apply_board_connection commands uses the available interfaces of the current board
		/// part defined in the project. An error is returned if the project uses a target part rather than a
		/// target board. You can use the current_board_part command to identify the target board
		/// used by the project, or get_board_parts to list the boards available for use by the project.
		/// Use the get_board_part_interfaces command to determine the list of available interfaces
		/// on the current board.
		/// To remove an existing IP interface connection, specify the -ip_intf option, but do not specify
		/// the -board_interface. If no board part interface is specified, the IP interface pin is
		/// disconnected.
		/// This command returns a transcript of it actions, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 99
		/// </summary>
		/// <param name="ip_intf">
		/// Required
		/// Full path of IP interface name to which board automation
		/// need to be applied.
		/// </param>
		/// <param name="diagram">
		/// Required
		/// The IP Integrator design name.
		/// </param>
		/// <param name="board_interface">
		/// Optional
		/// Board interface name to which connection need to be
		/// applied.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>sucess/failure status of applied action.</returns>
		public void apply_board_connection(string ip_intf, string diagram, string board_interface = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("apply_board_connection");
			_tcl.Add(command);
		}
		/// <summary>
		/// Automatically assign addresses to unmapped IP
		///
		/// Assign unmapped IP address segments to address spaces in the IP integrator subsystem design.
		/// If the target address space is not specified, the IP integrator will automatically assign the address
		/// segment to an available address space on a connected AXI master.
		/// If no bd_addr_seg objects are specified the assign_bd_address command will assign all
		/// unmapped address segments to any connected AXI master address spaces.
		/// This command returns the newly mapped address segments, or returns an error if it failed.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 108
		/// </summary>
		/// <param name="dict">
		/// Required
		/// dictionary of offset range address pairs, e.g. {offset
		/// 0x00000000 range 32K offset 0x20000000 range 32K} used to
		/// map an external interface to more than one address
		/// </param>
		/// <param name="target_address_space">
		/// Optional
		/// Target address space to place segment into
		/// </param>
		/// <param name="boundary">
		/// Optional
		/// assign peripherals to the exported slave hierarchical
		/// boundary of the design
		/// </param>
		/// <param name="master_boundary">
		/// Optional
		/// set hierarchical master boundary by assigning exported
		/// master interface segments to internal masters
		/// </param>
		/// <param name="external">
		/// Optional
		/// allow an external master interface to be mapped to more
		/// than one address
		/// </param>
		/// <param name="import_from_file">
		/// Optional
		/// import the addressing from file. When extension is csv,
		/// format = <address space name>,<slave
		/// segment>,<offset>,<range>
		/// </param>
		/// <param name="export_to_file">
		/// Optional
		/// export the address map to a file in csv format. format =
		/// <address space name>,<slave segment>,<offset>,<range>
		/// </param>
		/// <param name="export_gui_to_file">
		/// Optional
		/// export the address map to a file in csv format. Structure is
		/// same as Address Editor GUI
		/// </param>
		/// <param name="offset">
		/// Optional
		/// Offset of assignment. e.g. 0x00000000
		/// </param>
		/// <param name="range">
		/// Optional
		/// Range of assignment. e.g. 4096, 4K, 16M, 1G
		/// </param>
		/// <param name="base_high">
		/// Optional
		/// colon separated base:high offsets of a range assignment.
		/// e.g. 0x0000:0xFFFF
		/// </param>
		/// <param name="force">
		/// Optional
		/// force the assignment, do not run any validity checks
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="objects">
		/// Optional
		/// The objects to assign
		/// </param>
		/// <returns>The newly mapped segments, "" if failed.</returns>
		public void assign_bd_address(string dict, string target_address_space = null, bool? boundary = null, bool? master_boundary = null, bool? external = null, string import_from_file = null, string export_to_file = null, string export_gui_to_file = null, string offset = null, string range = null, string base_high = null, bool? force = null, bool? quiet = null, bool? verbose = null, string objects = null)
		{
			var command = new SimpleTCLCommand("assign_bd_address");
			_tcl.Add(command);
		}
		/// <summary>
		/// Close a design.
		///
		/// Closes the specified IP subsystem design in the IP integrator of the Vivado Design Suite.
		/// If the design has been modified, you will not be prompted to save the design prior to closing. You
		/// will need to run save_bd_design to save any changes made to the design before using the
		/// close_bd_design command.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 131
		/// </summary>
		/// <param name="name">
		/// Required
		/// Name of design to close
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>The design object, "" if failed.</returns>
		public void close_bd_design(string name, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("close_bd_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Compile C code into RTL
		///
		/// In IP cores that are imported from Vivado HLS, the compile_c command detects C, C++, and
		/// SystemC files and converts those files to RTL for synthesis by the Vivado Design Suite.
		/// This lets you use Vivado HLS to describe IP cores in a high-level language, like C or C++ rather
		/// than RTL.
		/// When HLS-based IP cores are generated, they only deliver the C source. When the HLS-based IP
		/// is synthesized, either in the out-of-context flow, or with the top-level design, the compile_c
		/// command launches Vivado HLS to convert the C source files into RTL, and import the resulting
		/// RTL sources back into the design prior to synthesis.
		/// RECOMMENDED: The compile_c command is automatically called by the Vivado Design Suite when it
		/// encounters IP with C code from the Vivado HLS system. You should not need to manually call this command.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 159
		/// </summary>
		/// <param name="objects">
		/// Required
		/// The objects which need C to RTL conversion
		/// </param>
		/// <param name="force">
		/// Optional
		/// Force generate product state regeneration
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void compile_c(string objects, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("compile_c");
			_tcl.Add(command);
		}
		/// <summary>
		/// Connect intf_port and intf_pin list.
		///
		/// Connect the interface pins on an IP integrator cell to other interface pins, or to external interface
		/// ports. An interface is a grouping of signals that share a common function in the IP integrator
		/// subsystem design.
		/// This command will create an interface net of the name specified by the -intf_net option, will
		/// connect to an existing interface net of the specified name, or will assign a name if none is
		/// specified.
		/// Returns the connected interface net object, or returns an error.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 189
		/// </summary>
		/// <param name="object1">
		/// Required
		/// Name of intf_port or intf_pin to connect
		/// </param>
		/// <param name="object2">
		/// Required
		/// Name of intf_port or intf_pin to connect
		/// </param>
		/// <param name="intf_net">
		/// Optional
		/// The single intf_net that all objects connect to
		/// </param>
		/// <param name="boundary_type">
		/// Optional
		/// Used when source object is on a hierarchical block's
		/// interface pin. Valid values are 'upper', 'lower', or 'both'. If
		/// 'lower' boundary, searches from the lower level of hierarchy
		/// onwards. Default: both
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="auto">
		/// Optional
		/// Automatically connect associated pins
		/// </param>
		/// <returns>TCL_OK, TCL_ERROR if failed.</returns>
		public void connect_bd_intf_net(string object1, string object2, string intf_net = null, string boundary_type = null, bool? quiet = null, bool? verbose = null, string auto = null)
		{
			var command = new SimpleTCLCommand("connect_bd_intf_net");
			_tcl.Add(command);
		}
		/// <summary>
		/// Connect port and pin object list.
		///
		/// Create a new net in the current IP integrator subsystem design connecting the specified list of
		/// block diagram port and pin objects, or connect an existing net to the specified pins and ports.
		/// If the -net option is not specified, a new net is created connecting the listed objects. If -net is
		/// used, the specified net is either connected or created as needed.
		/// Use the get_bd_ports and get_bd_pins commands to specify the port and pin objects to
		/// connect.
		/// You can use this command to connect pins or ports at different levels of the subsystem design
		/// hierarchy. However, in this case, you cannot specify the -net option because the connection,
		/// when complete, will result in multiple nets rather than a single net.
		/// The command returns the connected IP integrator subsystem design net object, or returns an
		/// error.
		///
		/// The following example connects two pins on different levels of the IP subsystem design
		/// hierarchy:
		/// connect_bd_net [get_bd_pins /vidOut_1/locked] \
		/// [get_bd_pins /newMod1/bridge_1/fid]
		/// Note: Because /vidOut_1/locked and /newMod1/bridge_1/fid are in different levels of the
		/// subsystem design hierarchy, the -net option is not specified. In this case, multiple nets are created for
		/// connection across the hierarchy.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 191
		/// </summary>
		/// <param name="objects">
		/// Required
		/// The objects connect to the net
		/// </param>
		/// <param name="net">
		/// Optional
		/// The single net that all objects connect to
		/// </param>
		/// <param name="boundary_type">
		/// Optional
		/// Used when source object is on a hierarchical block's pin.
		/// Valid values are 'upper', 'lower', or 'both'. If 'lower'
		/// boundary, searches from the lower level of hierarchy
		/// onwards. Default: both
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>TCL_OK, TCL_ERROR if failed.</returns>
		public void connect_bd_net(string objects, string net = null, string boundary_type = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("connect_bd_net");
			_tcl.Add(command);
		}
		/// <summary>
		/// Make copies of the objects and add the copies to the given hierarchical cell.
		///
		/// Use this command to copy IP integrator objects from one open subsystem design to a second
		/// subsystem design. The selected objects can be copied into the top-level of the current subsystem
		/// design, or into an existing hierarchical module.
		/// Because get_bd_cells, and other commands like it, operate on the current subsystem design,
		/// you must store the objects to be copied in a Tcl variable, as shown in the example below. Set the
		/// current subsystem design to the source design, select the group of objects to be copied, and
		/// store them in a Tcl variable. Then change the current_bd_design to the target design, and
		/// copy the selected objects. In this case, the -from_design option must be used.
		/// You can also use this command to copy objects from one level of hierarchy in the current
		/// subsystem design to another. In this case, the -from_design argument does not need to be
		/// specified.
		/// This command returns 0 if successful, and returns an error if it failed.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 210
		/// </summary>
		/// <param name="parent_cell">
		/// Required
		/// Parent cell
		/// </param>
		/// <param name="objects">
		/// Required
		/// The objects to copy
		/// </param>
		/// <param name="prefix">
		/// Optional
		/// Prefix name to add to cells
		/// </param>
		/// <param name="from_design">
		/// Optional
		/// The design to own the original objects
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>0, "" if failed.</returns>
		public void copy_bd_objs(string parent_cell, string objects, string prefix = null, string from_design = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("copy_bd_objs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new segment.
		///
		/// Create a new address segment object, bd_addr_seg, in the current IP integrator subsystem
		/// design.
		/// This command returns the newly created master address segment object, or returns nothing if it
		/// failed.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 217
		/// </summary>
		/// <param name="range">
		/// Required
		/// Range of segment. e.g. 4096, 4K, 16M, 1G
		/// </param>
		/// <param name="offset">
		/// Required
		/// Offset of segment. e.g. 0x00000000
		/// </param>
		/// <param name="name">
		/// Required
		/// Name of segment to create
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="parent_addr_space">
		/// Optional
		/// Parent address space of segment
		/// </param>
		/// <param name="slave_segment">
		/// Optional
		/// Slave segment of the created segment
		/// </param>
		/// <returns>The newly created segment object, "" if failed.</returns>
		public void create_bd_addr_seg(string range, string offset, string name, bool? quiet = null, bool? verbose = null, string parent_addr_space = null, string slave_segment = null)
		{
			var command = new SimpleTCLCommand("create_bd_addr_seg");
			_tcl.Add(command);
		}
		/// <summary>
		/// Add an IP cell from the IP catalog, or add a new hierarchical block.
		///
		/// Add a cell from the Vivado catalog to the current subsystem design, create a new hierarchical
		/// module to add to the subsystem design, or create a new module by referencing the module
		/// definition from an HDL source file.
		/// When adding an IP core from the catalog, the -vlnv argument is required.
		/// When creating a new hierarchical block design module, the -type hier argument is required.
		/// When creating a block design module that references an RTL module or entity declaration the -
		/// type module argument is required, as well as -reference. The module reference feature lets
		/// you add a module definition from an RTL file (Verilog or VHDL) into the block design. The source
		/// file containing the module definition must be added to the project, or read into the design before
		/// creating a module reference. Refer to the Vivado Design Suite User Guide: Designing IP Subsystems
		/// Using IP Integrator (UG994) for more information on referencing modules.
		/// This command returns the name of the newly created cell object, or returns nothing if the
		/// command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 219
		/// </summary>
		/// <param name="name">
		/// Required
		/// Name of cell to create
		/// </param>
		/// <param name="vlnv">
		/// Optional
		/// Vendor:Library:Name:Version of the IP cell to add from the
		/// IP catalog.
		/// </param>
		/// <param name="type">
		/// Optional
		/// Type of cell to create. Valid values are IP, hier and module.
		/// Default: IP
		/// </param>
		/// <param name="reference">
		/// Optional
		/// Top module-name or file-path of the module which is
		/// referred to create the cell.
		/// </param>
		/// <param name="revision">
		/// Optional
		/// (Optional) Core revision Default: -1
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>The newly created cell object. Returns nothing if the command fails.</returns>
		public void create_bd_cell(string name, string vlnv = null, string type = null, string reference = null, string revision = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("create_bd_cell");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new design and its top level hierarchy cell with the same name.
		///
		/// Create a new IP subsystem design module to add to the current project, and for use with the IP
		/// integrator of the Vivado Design Suite.
		/// An empty IP subsystem module is created and added to the source files of the current project.
		/// The subsystem module and file are created with the specified <name> in the current project at:
		/// <project_name>/<project_name>.srcs/sources_1/bd/<name>/<name>.bd
		/// This command returns the file path and name of the IP subsystem design created if the command
		/// is successful. An error is returned if the command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 222
		/// </summary>
		/// <param name="name">
		/// Required
		/// Name of design to create
		/// </param>
		/// <param name="dir">
		/// Optional
		/// Directory path for remote BD to be created and managed
		/// outside the project
		/// </param>
		/// <param name="cell">
		/// Optional
		/// hierarchical cell name which sub design to be copied into
		/// new design
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>The newly created design object, "" if failed.</returns>
		public void create_bd_design(string name, string dir = null, string cell = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("create_bd_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new intf_net.
		///
		/// Create a new IP integrator interface net for the subsystem design.
		/// This command returns the newly created interface net object if successful, and returns noting if it
		/// failed.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 224
		/// </summary>
		/// <param name="name">
		/// Required
		/// Name of intf_net to create
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>The newly created intf_net object, "" if failed.</returns>
		public void create_bd_intf_net(string name, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("create_bd_intf_net");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new intf_pin.
		///
		/// Create a new interface pin on an IP integrator hierarchical module. An IP integrator interface is a
		/// grouping of signals that share a common function, and can include both individual signals and
		/// buses that share a related function. An AXI4-Lite master, for example, is an interface that
		/// includes a large number of individual signals plus multiple buses.
		/// To create a single connection pin, or standard bus pin, use the create_bd_pin command.
		/// Interface pins connect with other compatible interface pins, or interface ports. The interface pin
		/// is added as a port inside the hierarchical module, to connect outside of the module, and as a pin
		/// on the hierarchical module.
		/// You must define the hierarchical module as the current instance in the IP integrator subsystem
		/// design, using the current_bd_instance command. The current instance is the target of the
		/// create_bd_intf_pin command.
		/// This command returns the name of the newly created interface pin object if successful, and
		/// returns an error if it failed.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 226
		/// </summary>
		/// <param name="vlnv">
		/// Required
		/// Bus vlnv
		/// </param>
		/// <param name="mode">
		/// Required
		/// Bus interface mode
		/// </param>
		/// <param name="name">
		/// Required
		/// Name of intf_pin to create
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>The newly created intf_pin object, "" if failed.</returns>
		public void create_bd_intf_pin(string vlnv, string mode, string name, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("create_bd_intf_pin");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new interface port.
		///
		/// Create a new IP integrator subsystem design interface port. An IP integrator interface is a
		/// grouping of signals that share a common function, and can include both individual signals and
		/// buses that share a related function. An AXI4-Lite master, for example, is an interface that
		/// includes a large number of individual signals plus multiple buses.
		/// To create a single connection port, or common bus port, use the create_bd_port command.
		/// This command returns the name of the newly created interface port object if successful, and
		/// returns nothing if it failed.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 228
		/// </summary>
		/// <param name="vlnv">
		/// Required
		/// Bus vlnv
		/// </param>
		/// <param name="mode">
		/// Required
		/// Bus interface mode
		/// </param>
		/// <param name="name">
		/// Required
		/// Name of port to create
		/// </param>
		/// <param name="board_intf">
		/// Optional
		/// Creates port-maps for this external bus-interface using the
		/// specified interface of current board.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>The newly created interface port object, "" if failed.</returns>
		public void create_bd_intf_port(string vlnv, string mode, string name, string board_intf = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("create_bd_intf_port");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new TLM interface port.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 230
		/// </summary>
		/// <param name="vlnv">
		/// Required
		/// TLM interface vlnv
		/// </param>
		/// <param name="mode">
		/// Required
		/// TLM interface mode
		/// </param>
		/// <param name="name">
		/// Required
		/// TLM interface name
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>The newly created TLM interface port object, "" if failed.</returns>
		public void create_bd_intf_tlm_port(string vlnv, string mode, string name, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("create_bd_intf_tlm_port");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new net.
		///
		/// Create a new net in the current IP integrator subsystem design.
		/// This command returns the newly created net object, or returns an error if failed.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 231
		/// </summary>
		/// <param name="name">
		/// Required
		/// Name of net to create
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>The newly created net object, "" if failed.</returns>
		public void create_bd_net(string name, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("create_bd_net");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new pin.
		///
		/// Create a new pin to add to an IP integrator hierarchical module.
		/// This command returns the name of the newly created pin object, or returns an error message if it
		/// failed.
		///
		/// The following example creates a new input pin on the specified module in the current IP
		/// integrator subsystem design:
		/// create_bd_pin -dir I -type rst /newMod1/rst
		/// /newMod1/rst
		///
		/// See ug835-vivado-tcl-commands.pdf, page 233
		/// </summary>
		/// <param name="dir">
		/// Required
		/// Pin direction
		/// </param>
		/// <param name="name">
		/// Required
		/// Name of pin to create
		/// </param>
		/// <param name="from">
		/// Optional
		/// Begin index Default: Unspecified
		/// </param>
		/// <param name="to">
		/// Optional
		/// End index Default: Unspecified
		/// </param>
		/// <param name="type">
		/// Optional
		/// Pin type
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>The newly created pin object, "" if failed.</returns>
		public void create_bd_pin(string dir, string name, string from = null, string to = null, string type = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("create_bd_pin");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new port for an IP subsystem design.
		///
		/// Create a new port to add to an IP integrator subsystem design. The port is a connection to
		/// signals external to the subsystem design.
		/// This command returns the name of the newly created port object, or returns an error message if
		/// it failed.
		///
		/// The following example creates a new bidirectional bus port in the current IP integrator
		/// subsystem design:
		/// create_bd_port -from 0 -to 32 -dir IO -type data addr
		/// /addr
		/// The following example creates a new 125 MHz clock port:
		/// create_bd_port -dir I -type clk -freq_hz 125000000 my_clock
		///
		/// See ug835-vivado-tcl-commands.pdf, page 235
		/// </summary>
		/// <param name="dir">
		/// Required
		/// Port direction. Valid values are I, O, or IO.
		/// </param>
		/// <param name="name">
		/// Required
		/// Name of port to create
		/// </param>
		/// <param name="from">
		/// Optional
		/// Beginning index Default: Unspecified
		/// </param>
		/// <param name="to">
		/// Optional
		/// Ending index Default: Unspecified
		/// </param>
		/// <param name="type">
		/// Optional
		/// Port type. Valid values are clk, ce, rst, intr, data.
		/// </param>
		/// <param name="freq_hz">
		/// Optional
		/// Frequency in Hertz for clock ports Default: Unspecified
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>The newly created port object. Returns nothing if the command fails.</returns>
		public void create_bd_port(string dir, string name, string from = null, string to = null, string type = null, string freq_hz = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("create_bd_port");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new TLM port for an IP subsystem design.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 237
		/// </summary>
		/// <param name="name">
		/// Required
		/// Name of port to create
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>The newly created TLM port object. Returns nothing if the command fails.</returns>
		public void create_bd_tlm_port(string name, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("create_bd_tlm_port");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set or get current design.
		///
		/// Defines the current IP subsystem design for use with the IP integrator of the Vivado Design
		/// Suite, or returns the name of the current design in the active project.
		/// The current IP subsystem design and current IP subsystem instance are the target of most of the
		/// IP integrator Tcl commands and design changes made in the tool. The current IP subsystem
		/// instance can be defined using the current_bd_instance command.
		/// You can use the get_bd_designs command to get a list of open IP subsystem designs in the
		/// active project.
		/// A complete list of IP integrator Tcl commands can be returned using the following command from
		/// the Vivado Design Suite Tcl shell:
		/// load_features IPIntegrator
		/// help -category IPintegrator
		/// Note: The load_features command is only needed if the IP integrator is not currently loaded in the
		/// Vivado Design Suite.
		///
		/// The following example sets the IP subsystem design as the current design:
		/// current_bd_design design_1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 365
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="design">
		/// Optional
		/// Name of current design to be set
		/// </param>
		/// <returns>The current design object, "" if failed.</returns>
		public void current_bd_design(bool? quiet = null, bool? verbose = null, string design = null)
		{
			var command = new SimpleTCLCommand("current_bd_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set or get current cell instance.
		///
		/// Set or get the current hierarchical cell instance in the current IP integrator subsystem design, as
		/// defined by current_bd_design. The current instance is referenced from the top-level of the
		/// subsystem design hierarchy, or "/".
		/// This command returns the current IP integrator cell instance object, or returns nothing if the
		/// command failed.
		///
		/// The following example sets the current instance in the subsystem design to the specified module:
		/// current_bd_instance module2
		/// The following example returns the current instance:
		/// current_bd_instance .
		/// This example resets the current instance of the subsystem design to the top level of the
		/// hierarchy:
		/// current_instance /
		///
		/// See ug835-vivado-tcl-commands.pdf, page 367
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="instance">
		/// Optional
		/// Name of current cell instance to be set
		/// </param>
		/// <returns>The current cell instance object, "" if failed.</returns>
		public void current_bd_instance(bool? quiet = null, bool? verbose = null, string instance = null)
		{
			var command = new SimpleTCLCommand("current_bd_instance");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete specified objects.
		///
		/// Delete specified objects from the current IP integrator subsystem design.
		/// Objects must be passed directly to the delete_bd_objs command, and not simply referenced
		/// by the object name. Pins are passed to the command by get_bd_pins, for instance, rather than
		/// by pin name.
		/// This command returns nothing if it is successful, and returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 417
		/// </summary>
		/// <param name="objects">
		/// Required
		/// The objects to be deleted
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>Pass if successful in deleting objects</returns>
		public void delete_bd_objs(string objects, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("delete_bd_objs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Disconnect an intf_net.
		///
		/// Disconnect a single interface net in the IP integrator subsystem design from the specified
		/// objects. An interface is a grouping of signals that share a common function in the IP integrator
		/// subsystem design.
		/// This command lets you disconnect the specified interface net from pins or ports in the IP
		/// subsystem design, without deleting the whole net. To delete the whole net, you should use the
		/// delete_bd_objs command.
		/// This command returns TCL_OK is successful, or TCL_ERROR if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 478
		/// </summary>
		/// <param name="intf_net">
		/// Required
		/// The IntfNet that the objects connect to
		/// </param>
		/// <param name="objects">
		/// Required
		/// The objects to disconnect from the intf_net
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>TCL_OK, TCL_ERROR if failed.</returns>
		public void disconnect_bd_intf_net(string intf_net, string objects, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("disconnect_bd_intf_net");
			_tcl.Add(command);
		}
		/// <summary>
		/// Disconnect a net from the object.
		///
		/// Disconnect a single net in the IP integrator subsystem design from the specified objects.
		/// This command lets you disconnect the specified nets from pins or ports in the IP subsystem
		/// design, without deleting the whole net. To delete the whole net, you should use the
		/// delete_bd_objs command.
		/// This command returns TCL_OK if successful, or TCL_ERROR if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 480
		/// </summary>
		/// <param name="net">
		/// Required
		/// The Net that the objects connect to
		/// </param>
		/// <param name="objects">
		/// Required
		/// The objects to disconnect from the net
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>TCL_OK, TCL_ERROR if failed.</returns>
		public void disconnect_bd_net(string net, string objects, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("disconnect_bd_net");
			_tcl.Add(command);
		}
		/// <summary>
		/// Exclude segment from an address space.
		///
		/// Exclude the specified AXI peripheral address segment from access by the AXI master it is
		/// mapped to, in order to support sparse connectivity and eliminate unneeded device resources.
		/// This command lets you exclude specific peripherals from being accessed by specific AXI masters.
		/// For example, in the case where AXI peripherals P0 and P1 are connected to two masters M0 and
		/// M1, you can use sparse connectivity to let M0 access both P0 and P1, and let M1 accesses P1,
		/// but exclude it from P0.
		/// In the IP integrator block design, address segments of AXI peripherals will have one of three
		/// states:
		/// • Unmapped - An AXI peripheral, or slave interface, is connected to an AXI master, but the
		/// peripheral has not been assigned an address segment in the master's address space and is not
		/// visible to the master.
		/// • Mapped - The AXI peripheral is mapped into the AXI master's address space, assigned an
		/// address segment or range, and is accessible through the master.
		/// • Excluded - The AXI peripheral is mapped to the AXI master, and has been assigned an address,
		/// but is not accessible to the master. The address segment that the AXI slave occupies within
		/// the master address space is also considered filled.
		/// The purpose of excluding the address segment is to restrict access to peripherals that are
		/// connected to multiple masters. The validate_bd_design command will return a critical
		/// warning if a peripheral interface is connected to a master, but not mapped to an address segment
		/// of that master. However, by excluding the peripheral after it is mapped, the resources required to
		/// connect and provide access between the AXI master and the peripheral (the muxes and decoding
		/// for example) can be eliminated to conserve resources on the implemented design.
		/// TIP: When running assign_bd_address, the IP integrator will map unmapped address segments into address
		/// spaces, but will not map excluded address spaces.
		/// This command offers two syntaxes, for a previously mapped address segment, and an unmapped
		/// address segment:
		/// exclude_bd_addr_seg <master_addr_seg>
		/// exclude_bd_addr_seg -target_address_space <master_addr_space>
		/// <slave_addr_seg>
		/// In the second command syntax, when a slave segment is specified, the slave will first be assigned
		/// or mapped to the specified AXI master address space, and then it will be excluded from access by
		/// the master.
		/// This command returns nothing if successful, or returns an error if it failed.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 497
		/// </summary>
		/// <param name="target_address_space">
		/// Optional
		/// Target address space to exclude the slave segment from
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="segment_to_exclude">
		/// Optional
		/// segment to exclude
		/// </param>
		/// <returns>The newly excluded segment object, "" if failed.</returns>
		public void exclude_bd_addr_seg(string target_address_space = null, bool? quiet = null, bool? verbose = null, string segment_to_exclude = null)
		{
			var command = new SimpleTCLCommand("exclude_bd_addr_seg");
			_tcl.Add(command);
		}
		/// <summary>
		/// Export current design as a static example design
		///
		/// See ug835-vivado-tcl-commands.pdf, page 502
		/// </summary>
		/// <param name="vlnv">
		/// Required
		/// VLNV of the example design to be generated
		/// </param>
		/// <param name="directory">
		/// Required
		/// Destination directory in which example design needs to be
		/// generated
		/// </param>
		/// <param name="no_ip_version">
		/// Optional
		/// Flag to not include the IP version as part of the IP VLNV in
		/// create_bd_cell commands.
		/// </param>
		/// <param name="force">
		/// Optional
		/// create a directory if it does not exist
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void export_as_example_design(string vlnv, string directory, bool? no_ip_version = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("export_as_example_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Find a list of pins, ports or interfaces with a given relationship to the given object.
		///
		/// Find a list of pins, ports or interfaces with a given relationship to the specified objects.
		/// This command returns a list of pins, ports or interface objects if successful, or returns an error if
		/// it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 518
		/// </summary>
		/// <param name="relation">
		/// Required
		/// Relation to the input objs: connected_to, addressable_slave,
		/// addressing_master. 'connected_to' will find corresponding
		/// pins, ports or interfaces that are connected to the given
		/// source objects, across hierarchy boundaries.
		/// </param>
		/// <param name="objects">
		/// Required
		/// One or more source object to start finding from
		/// </param>
		/// <param name="boundary_type">
		/// Optional
		/// Used when source object is an hierarchical block's pin or
		/// interface pin. Valid values are empty string for same level
		/// (default), 'lower', or 'all'. If 'lower' boundary, searches from
		/// within hierarchy. This option is only valid for relation:
		/// connected_to
		/// </param>
		/// <param name="thru_hier">
		/// Optional
		/// Flag used to ignore boundary of hierarchical blocks. If used
		/// used with boundary_type 'lower', flag will only affect the
		/// hierarchical blocks within parent hierarchical block.
		/// </param>
		/// <param name="stop_at_interconnect">
		/// Optional
		/// Flag used to stop at the axi_interconnect's boundary when -
		/// thru_hier is used.
		/// </param>
		/// <param name="end_type">
		/// Optional
		/// Only to be used with objects that are pins or ports and bus
		/// interface pins or ports. For pins/ports - Default is to return
		/// the sink objects for a given source object and to return the
		/// source object for a given sink object. If 'all' is used for a
		/// given sink object, will return both source and other sink
		/// objectst that are connected to the source object. For bus
		/// interface pins/ports - Default is to return the end
		/// connection that is non-monitor interfaces. If 'monitor' is
		/// used, will only return the monitor interfaces. If 'all' is used,
		/// will return both end connection and monitor interfaces. This
		/// option is only valid for relation: connected_to
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>List of pins, ports or interface objects, "" if failed.</returns>
		public void find_bd_objs(string relation, string objects, string boundary_type = null, bool? thru_hier = null, bool? stop_at_interconnect = null, string end_type = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("find_bd_objs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Generate target data for the specified source
		///
		/// This command generates target data for the specified IP objects (get_ips) or source file for IP
		/// cores (.xci and .xco), DSP modules (.slx or .mdl), or block designs (.bd). The target data
		/// that is generated are the files necessary to support the IP or block design through the FPGA
		/// design flow.
		/// The instantiation template, synthesis netlist, and simulation netlist are standard targets. However,
		/// each IP in the catalog may also support its own set of targets. You can view the available targets
		/// on an object by examining the SUPPORTED_TARGETS property, or you can use the
		/// list_targets command to list the targets for design source file.
		///
		/// This example generates the change log for all of the IP cores in the current project, forcing
		/// regeneration of any targets that are up-to-date:
		/// generate_target changelog [get_ips] -force
		/// The following example generates the instantiation template and synthesis targets for all of the IP
		/// cores in the current project:
		/// generate_target {instantiation_template synthesis} [get_ips]
		/// TIP: Note the use of the braces to pass the list of targets to the command. The absence of the -force option
		/// means that only out-of-date targets will be regenerated.
		/// The following example generates all targets for the specified block design:
		/// generate_target all \
		/// [get_files C:/Data/project_mb/project_mb.srcs/sources_1/bd/base_mb/
		/// base_mb.bd]
		/// IMPORTANT! The use of get_ips is not supported to generate targets for individual IP within block designs.
		/// The tool will return an error.
		/// The following queries the SUPPORTED_TARGETS property of the specified IP object, and then
		/// generates the example project for the IP:
		/// get_property SUPPORTED_TARGETS [get_ips blk_mem*]
		/// open_example_project -dir C:/Data/examples -force [get_ips blk_mem*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 539
		/// </summary>
		/// <param name="name">
		/// Required
		/// List of targets to be generated, or 'all' to generate all
		/// supported targets
		/// </param>
		/// <param name="objects">
		/// Required
		/// The objects for which data needs to be generated
		/// </param>
		/// <param name="force">
		/// Optional
		/// Force target data regeneration
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void generate_target(string name, string objects, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("generate_target");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of segments
		///
		/// Get a list of address segments in the current IP integrator subsystem design.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets the address segments of the specified address spaces:
		/// get_bd_addr_segs -of_objects [get_bd_addr_spaces -of_objects \
		/// [get_bd_cells /microblaze_1]]
		/// /microblaze_1/Data/SEG1
		/// /microblaze_1/Data/SEG3
		/// /microblaze_1/Instruction/SEG2
		/// Note: If there are no objects matching the pattern you will get a warning.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 542
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Get segments of these segments, interfaces, or registers
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="hierarchical">
		/// Optional
		/// Hierarchical cells included
		/// </param>
		/// <param name="filter">
		/// Optional
		/// Filter list with expression
		/// </param>
		/// <param name="excluded">
		/// Optional
		/// Get excluded mapped segments -of_objects
		/// </param>
		/// <param name="addressed">
		/// Optional
		/// Get addressed segments of given -of_objects
		/// </param>
		/// <param name="unaddressed">
		/// Optional
		/// Get unaddressed segments of given objects
		/// </param>
		/// <param name="addressing">
		/// Optional
		/// Get addressing segments of given -of_objects
		/// </param>
		/// <param name="addressables">
		/// Optional
		/// Get addressable segments of given -of_objects
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
		/// Match engine names against patterns Default: *
		/// </param>
		/// <returns>List of segment objects, "" if failed.</returns>
		public void get_bd_addr_segs(string of_objects, bool? regexp = null, bool? hierarchical = null, string filter = null, bool? excluded = null, bool? addressed = null, bool? unaddressed = null, bool? addressing = null, bool? addressables = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_bd_addr_segs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of addr_spaces
		///
		/// Get a list of address spaces in the current IP integrator subsystem design.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example lists all of the address spaces in the current IP integrator subsystem
		/// design, listing one per line:
		/// join [get_bd_addr_spaces] \n
		/// /mdm_1/S_AXI
		/// /microblaze_1/Data
		/// /microblaze_1/Instruction
		/// /microblaze_1_axi_intc/s_axi
		/// /microblaze_1_local_memory/dlmb_bram_if_cntlr/SLMB
		/// /microblaze_1_local_memory/dlmb_bram_if_cntlr/SLMB1
		/// /microblaze_1_local_memory/dlmb_bram_if_cntlr/SLMB2
		/// /microblaze_1_local_memory/dlmb_bram_if_cntlr/SLMB3
		/// /microblaze_1_local_memory/dlmb_bram_if_cntlr/S_AXI_CTRL
		/// /microblaze_1_local_memory/ilmb_bram_if_cntlr/SLMB
		/// /microblaze_1_local_memory/ilmb_bram_if_cntlr/SLMB1
		/// /microblaze_1_local_memory/ilmb_bram_if_cntlr/SLMB2
		/// /microblaze_1_local_memory/ilmb_bram_if_cntlr/SLMB3
		/// /microblaze_1_local_memory/ilmb_bram_if_cntlr/S_AXI_CTRL
		/// /microblaze_1_local_memory/lmb_bram/S_1
		/// Note: If there are no objects matching the pattern you will get a warning.
		/// The following example returns all of the properties attached to the third in a list, or index 2, of all
		/// address spaces in the current subsystem design:
		/// report_property -all [lindex [get_bd_addr_spaces] 2 ]
		/// Property Type Read-only Visible Value
		/// CLASS string true true bd_addr_space
		/// NAME string false true /microblaze_1/Instruction
		/// OFFSET string false true
		/// PATH string true true /microblaze_1/Instruction
		/// RANGE string false true -1
		/// TYPE string false true
		///
		/// See ug835-vivado-tcl-commands.pdf, page 546
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Get addr_spaces of these segments or interfaces
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="hierarchical">
		/// Optional
		/// Hierarchical cells included
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
		/// Match engine names against patterns Default: *
		/// </param>
		/// <returns>List of addr_space objects, "" if failed.</returns>
		public void get_bd_addr_spaces(string of_objects, bool? regexp = null, bool? hierarchical = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_bd_addr_spaces");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of block diagram cells
		///
		/// Get a list of cells in the current IP integrator subsystem design, or current subsystem instance. IP
		/// integrator subsystem cells are either IP cores drawn from the IP integrator catalog, or hierarchical
		/// modules created in the subsystem design with the create_bd_cell command.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of cells that include the specified IP integrator subsystem pin,
		/// and sorts the list to remove duplicate entries:
		/// lsort -unique [get_bd_cells -of_objects [get_bd_pins -hierarchical *aclk*]]
		/// Note: If there are no cells matching the pattern you will get a warning.
		/// The following example gets a list of all cells in all levels of the subsystem design hierarchy, and
		/// then filters the list to include only those cells whose name includes the specified text, or
		/// hierarchy:
		/// get_bd_cells -hierarchical -filter {NAME=~"/newMod1/*"}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 550
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Get cells of these pins or nets
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="hierarchical">
		/// Optional
		/// Hierarchical cells included
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
		/// Match engine names against patterns Default: *
		/// </param>
		/// <returns>List of block diagram cell objects, "" if failed.</returns>
		public void get_bd_cells(string of_objects, bool? regexp = null, bool? hierarchical = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_bd_cells");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of designs
		///
		/// Gets a list of IP subsystem designs open in the current project that match a specified search
		/// pattern. The default command gets a list of all open IP subsystem designs in the project.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets all open IP subsystem designs in the current project:
		/// get_bd_designs
		///
		/// See ug835-vivado-tcl-commands.pdf, page 554
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Get diagrams of these bd-cells or pins or nets
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
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
		/// Match engine names against patterns Default: *
		/// </param>
		/// <returns>List of design objects, "" if failed.</returns>
		public void get_bd_designs(string of_objects, bool? regexp = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_bd_designs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of intf_nets
		///
		/// Gets a list of interface nets in the current IP integrator subsystem design that match a specified
		/// search pattern. The default command gets a list of all interface nets in the subsystem design.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets the interface net attached to the specified pin of an IP integrator
		/// hierarchical module, and returns both the net at the level of the hierarchical module, and the net
		/// inside the hierarchical module:
		/// get_bd_intf_nets -boundary_type both -of_objects [get_bd_pins /newMod1/
		/// aclk]
		/// Note: If there are no interface nets matching the pattern you will get a warning.
		/// The following example returns a list of all interface nets at all levels of the IP integrator
		/// subsystem design hierarchy:
		/// get_bd_intf_nets -hierarchical
		///
		/// See ug835-vivado-tcl-commands.pdf, page 557
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// One or a list of cells or interface pins/ports objects. List
		/// must be of one object type.
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="hierarchical">
		/// Optional
		/// Hierarchical cells included
		/// </param>
		/// <param name="filter">
		/// Optional
		/// Filter list with expression
		/// </param>
		/// <param name="boundary_type">
		/// Optional
		/// Used when source object is on a hierarchical block's
		/// interface pin. Valid values are 'upper', 'lower', or 'both'. If
		/// 'lower' boundary, searches from the lower level of hierarchy
		/// onwards. This option is only valid for connected_to relations.
		/// Default: upper
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
		/// Match engine names against patterns Default: *
		/// </param>
		/// <returns>List of pin objects, "" if failed.</returns>
		public void get_bd_intf_nets(string of_objects, bool? regexp = null, bool? hierarchical = null, string filter = null, string boundary_type = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_bd_intf_nets");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of intf_pins
		///
		/// Gets a list of interface pin objects on the current IP subsystem design that match a specified
		/// search pattern. The default command gets a list of all interface pins in the subsystem design.
		/// The external connections of an IP integrator cell, or hierarchical module, are pins and interface
		/// pins. The external connections in an IP subsystem design are ports, or interface ports. Use the
		/// get_bd_ports and get_bd_intf_ports commands to select the port objects.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of interface pins attached to the specified cell:
		/// get_bd_intf_pins -of [get_bd_cells new_vidOut_1]
		/// Note: If there are no interface pins matching the pattern, the tool will return a warning.
		/// The following example gets a list of all interface pins, throughout the hierarchy of the IP
		/// integrator subsystem design, which match the specified name pattern:
		/// get_bd_intf_pins -hierarchical m_apb*
		/// The following example gets a list of interface pins attached to the specified subsystem net:
		/// get_bd_intf_pins -of [get_bd_intf_nets vidout_1_vtg_ce]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 561
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// One or a list of cells, interface nets or pins objects. List must
		/// be of one object type.
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="hierarchical">
		/// Optional
		/// Hierarchical cells included
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
		/// Match engine names against patterns Default: *
		/// </param>
		/// <returns>List of pin objects, "" if failed.</returns>
		public void get_bd_intf_pins(string of_objects, bool? regexp = null, bool? hierarchical = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_bd_intf_pins");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of intf_ports
		///
		/// Gets a list of interface port objects in the current IP integrator subsystem design that match a
		/// specified search pattern. The default command gets a list of all interface ports in the subsystem
		/// design.
		/// The external connections in an IP subsystem design are ports, or interface ports. The external
		/// connections in an IP integrator cell, or hierarchical module, are pins and interface pins. Use the
		/// get_bd_pins and get_bd_intf_pins commands to select the pin objects.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets the interface ports in the subsystem design that operate in Master
		/// mode:
		/// get_bd_intf_ports -filter {MODE=="master"}
		/// Note: If there are no interface ports matching the pattern, the tool will return a warning.
		/// This example returns the block design interface port that the specified bd_port is part of:
		/// get_bd_intf_ports -of [get_bd_ports sys_diff_clock_clk_n]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 565
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// One or a list of interface nets or ports objects.
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
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
		/// Match engine names against patterns Default: *
		/// </param>
		/// <returns>List of port objects, "" if failed.</returns>
		public void get_bd_intf_ports(string of_objects, bool? regexp = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_bd_intf_ports");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of nets
		///
		/// Gets a list of nets in the current IP integrator subsystem design that match a specified search
		/// pattern. The default command gets a list of all nets in the subsystem design.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets the net attached to the specified pin of an IP integrator hierarchical
		/// module, and returns both the net at the level of the hierarchical module, and the net inside the
		/// hierarchical module:
		/// get_bd_nets -boundary_type both -of_objects [get_bd_pins /newMod1/aclk]
		/// Note: If there are no nets matching the pattern you will get a warning.
		/// The following example returns a list of all nets at all levels of the IP integrator subsystem design
		/// hierarchy:
		/// get_bd_nets -hierarchical
		///
		/// See ug835-vivado-tcl-commands.pdf, page 568
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// One or a list of cells or pins/ports objects. List must be of
		/// one object type.
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="hierarchical">
		/// Optional
		/// Hierarchical cells included
		/// </param>
		/// <param name="filter">
		/// Optional
		/// Filter list with expression
		/// </param>
		/// <param name="boundary_type">
		/// Optional
		/// Used when source object is on a hierarchical block's pin.
		/// Valid values are 'upper', 'lower', or 'both'. If 'lower'
		/// boundary, searches from the lower level of hierarchy
		/// onwards. This option is only valid for connected_to relations.
		/// Default: upper
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
		/// Match engine names against patterns Default: *
		/// </param>
		/// <returns>List of pin objects, "" if failed.</returns>
		public void get_bd_nets(string of_objects, bool? regexp = null, bool? hierarchical = null, string filter = null, string boundary_type = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_bd_nets");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of pins
		///
		/// Gets a list of pin objects on the current IP subsystem design that match a specified search
		/// pattern. The default command gets a list of all pins in the subsystem design.
		/// The external connections in an IP integrator cell, or hierarchical module, are pins and interface
		/// pins. The external connections in an IP subsystem design are ports, or interface ports. Use the
		/// get_bd_ports and get_bd_intf_ports commands to select the port objects.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of pins attached to the specified cell:
		/// get_bd_pins -of [get_bd_cells new_vidOut_1]
		/// Note: If there are no pins matching the pattern, the tool will return a warning.
		/// The following example gets a list of all pins, throughout the hierarchy of the IP integrator
		/// subsystem design, which match the specified name pattern:
		/// get_bd_pins -hierarchical LMB*
		/// The following example gets a list of pins attached to the specified subsystem net:
		/// get_bd_pins -of [get_bd_nets vidout_1_vtg_ce]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 572
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// One or a list of cells, nets or interface pins objects. List must
		/// be of one object type.
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="hierarchical">
		/// Optional
		/// Hierarchical cells included
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
		/// Match engine names against patterns Default: *
		/// </param>
		/// <returns>List of pin objects, "" if failed.</returns>
		public void get_bd_pins(string of_objects, bool? regexp = null, bool? hierarchical = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_bd_pins");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of ports
		///
		/// Gets a list of port objects in the current IP integrator subsystem design that match a specified
		/// search pattern. The default command gets a list of all ports in the subsystem design.
		/// The external connections in an IP subsystem design are ports, or interface ports. The external
		/// connections in an IP integrator cell, or hierarchical module, are pins and interface pins. Use the
		/// get_bd_pins and get_bd_intf_pins commands to select the pin objects.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets the ports connected to the specified IP subsystem net:
		/// get_bd_ports -of_objects [get_bd_nets bridge_1_apb_m]
		/// Note: If there are no ports matching the pattern, the tool will return a warning.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 576
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// One or a list of nets or interface ports objects.
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
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
		/// Match engine names against patterns Default: *
		/// </param>
		/// <returns>List of port objects, "" if failed.</returns>
		public void get_bd_ports(string of_objects, bool? regexp = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_bd_ports");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of registers
		///
		/// Get a list of registers using the objects of address segments, interface pins, and external interface
		/// ports. The register objects will provide the register's display name and the memory offset
		/// address. There is no default behavior for this command as it requires the use of -of_objects
		/// argument with a valid value that is an object of the address segments, interface pins, or external
		/// interface ports. The command will get the registers directly from the address segment objects or
		/// from address segments associated with the specified interface pin or interface port objects.
		///
		/// The following example creates an external interface pin, assigns an address space, and then gets
		/// the registers associated with that address space:
		/// % create_bd_cell -type ip -vlnv xilinx.com:ip:axi_gpio:2.0 axi_gpio_0
		/// % make_bd_intf_pins_external [get_bd_intf_pins axi_gpio_0/S_AXI]
		/// % assign_bd_address
		/// % get_bd_addr_segs
		/// /axi_gpio_0/S_AXI/Reg /S_AXI_0/SEG_axi_gpio_0_Reg
		/// % set seg [get_bd_addr_segs /axi_gpio_0/S_AXI/Reg]
		/// /axi_gpio_0/S_AXI/Reg
		/// % get_bd_regs -of_objects $seg
		/// GPIO_DATA GPIO_TRI GPIO2_DATA GPIO2_TRI GIER IP_IER IP_ISR
		/// %set regs [get_bd_regs -of_objects $seg]
		/// GPIO_DATA GPIO_TRI GPIO2_DATA GPIO2_TRI GIER IP_IER IP_ISR
		/// % set reg [lindex $regs 0]
		/// GPIO_DATA
		/// % report_property $reg
		/// Property Type Read-only Visible Value
		/// CLASS string true true bd_reg
		/// DISPLAYNAME string true true Channel_1_GPIO_DATA
		/// NAME string true true GPIO_DATA
		/// OFFSET string true true 0x0
		///
		/// See ug835-vivado-tcl-commands.pdf, page 579
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Get registers of segments, interface pins, external interface
		/// ports
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>List of register objects, "" if failed.</returns>
		public void get_bd_regs(string of_objects, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("get_bd_regs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of example designs
		///
		/// The command returns a list of example designs available in the current release of the Vivado
		/// Design Suite, or returns an error if it fails.
		/// Example designs can be opened, or instantiated into the Vivado Design Suite, onto specific target
		/// hardware devices or boards.
		///
		/// The following example returns reports the properties of each of the example designs in the
		/// current release:
		/// foreach x [get_example_designs] {
		/// puts "********* Design $x **************"
		/// report_property -all $x}
		/// Note: The reported properties include the PARTS property which lists the compatible parts for the example
		/// design.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 672
		/// </summary>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// Perform case-insensitive matching
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
		/// The patterns to match against Default: * Values: The default
		/// search pattern is the wildcard *, or .* when -regexp is
		/// specified.
		/// </param>
		/// <returns>list of design objects</returns>
		public void get_example_designs(bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_example_designs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of IPI example designs
		///
		/// The command returns the list of template block designs available in the current release of the
		/// Vivado Design Suite, or returns an error if it fails.
		///
		/// The following example returns the list of available block design templates in the current release:
		/// get_template_bd_designs
		///
		/// See ug835-vivado-tcl-commands.pdf, page 921
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>list of IPI design objects</returns>
		public void get_template_bd_designs(bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("get_template_bd_designs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a hierarchical cell, and then move the group of cells into the hierarchy cell. The
		/// connections between these cells are maintained; the connections between these cells and other
		/// cells are maintained through crossing hierarchy cell.
		///
		/// Create a new hierarchical module in the current IP integrator subsystem design, and move the
		/// specified cells into that module.
		/// You can also optionally move a group of specified cells into the hierarchical module. The
		/// connections between the specified cells are maintained. The connections between the cells being
		/// moved are maintained; connections between these cells and other cells that are not being moved
		/// are maintained automatically by IP integrator adding pins and ports to cross the hierarchical
		/// boundary.
		/// You can also move cells into the hierarchical module by using the move_bd_cells command
		/// after the hierarchical module has been created using the create_bd_cells command.
		/// The command returns the name of the created hierarchical module if successful, or an error
		/// message if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 946
		/// </summary>
		/// <param name="prefix">
		/// Optional
		/// Prefix name to add to cells
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="target_cell_name">
		/// Optional
		/// Target cell
		/// </param>
		/// <param name="cells">
		/// Optional
		/// Match engine names against cell names Default: *
		/// </param>
		/// <returns>0 if success.</returns>
		public void group_bd_cells(string prefix = null, bool? quiet = null, bool? verbose = null, string target_cell_name = null, string cells = null)
		{
			var command = new SimpleTCLCommand("group_bd_cells");
			_tcl.Add(command);
		}
		/// <summary>
		/// include segment from an address space.
		///
		/// Reverses the exclusion of an AXI peripheral address segment from access by the AXI master, and
		/// restores the address segment to a mapped state.
		/// In the block design, address segments of AXI peripherals can have one of three states:
		/// • Unmapped - An AXI peripheral, or slave interface, is connected to an AXI master, but the
		/// peripheral has not been assigned an address segment in the master's address space and is not
		/// visible to the master.
		/// • Mapped - The AXI peripheral is mapped into the AXI master's address space, assigned an
		/// address segment or range, and is accessible through the master.
		/// • Excluded - The AXI peripheral is mapped to the AXI master, and has been assigned an address
		/// segment, but is not accessible to the master. The address segment that the AXI slave occupies
		/// within the master address space is also considered filled.
		/// The exclude_bd_addr_seg command lets you exclude specific address segments from access
		/// by the AXI master they are mapped to. The include_bd_addr_seg restores access to the
		/// mapped address segment.
		/// This command returns nothing if successful, or returns an error if it failed.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 973
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="segment_to_include">
		/// Optional
		/// Segment to include
		/// </param>
		/// <returns>The newly included segment object, "" if failed.</returns>
		public void include_bd_addr_seg(bool? quiet = null, bool? verbose = null, string segment_to_include = null)
		{
			var command = new SimpleTCLCommand("include_bd_addr_seg");
			_tcl.Add(command);
		}
		/// <summary>
		/// Creates an example design from a predefined template in an open project.
		///
		/// This command creates an example design from a predefined template in an open project. The
		/// target part specified by the open project must be compatible with the example design, as defined
		/// in the SUPPORTED_PARTS property of the example, or an error is returned.
		/// For the embedded processor example designs, base_microblaze and base_zynq, the example
		/// design must be created in an open block design in the Vivado IP integrator. Embedded processor
		/// example designs require the use of a board as defined by the BOARD_PART property, rather than
		/// a target part. Refer to the current_board_part command for more information.
		/// The command returns the name of the example design used and a transcript of commands; or it
		/// returns an error if it fails.
		///
		/// The following example creates a new project as specified, overwriting an existing project of the
		/// same name if one is found, specifies the BOARD_PART property for the project, creates a new
		/// empty block design in the Vivado IP integrator, and then instantiates the Zynq embedded
		/// processor example design:
		/// create_project zynq1 -force
		/// set_property BOARD_PART em.avnet.com:zed:1.3 [current_project]
		/// create_bd_design myFirstZynq
		/// instantiate_example_design -design myFirstZynq \
		/// [lindex [get_example_designs] 1]
		/// This example reports the configurable properties of the specified example design:
		/// report_property [lindex [get_example_designs] 3] CONFIG.*
		/// This example creates a new empty project as specified, sets a target BOARD for the project,
		/// creates and opens a new empty block design, and then instantiates the configurable example
		/// design:
		/// create_project mb1 C:/Data/Vivado_Tutorial/Tutorial_Created_Data/mb1
		/// set_property board_part xilinx.com:kcu105:part0:1.1 [current_project]
		/// create_bd_design design_1
		/// instantiate_example_design -design design_1 \
		/// -options { Data_Cache.VALUE 8K Include_DDR4.VALUE true \
		/// Local_memory.VALUE 128K }\
		/// xilinx.com:design:config_mb:1.0
		///
		/// See ug835-vivado-tcl-commands.pdf, page 977
		/// </summary>
		/// <param name="options">
		/// Required
		/// Configurable options
		/// </param>
		/// <param name="template">
		/// Required
		/// Configurable Design Name
		/// </param>
		/// <param name="design">
		/// Optional
		/// Block Design Name
		/// </param>
		/// <param name="hier">
		/// Optional
		/// Hierarchy Block
		/// </param>
		/// <param name="project">
		/// Optional
		/// Project Name
		/// </param>
		/// <param name="project_location">
		/// Optional
		/// Project location Default: .
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>Returns the name of the template applied.</returns>
		public void instantiate_example_design(string options, string template, string design = null, string hier = null, string project = null, string project_location = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("instantiate_example_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Creates a block design in IP integrator from a predefined template.
		///
		/// This command creates an example design from a template Block Design in the IP integrator of
		/// the Vivado Design Suite.
		/// The template diagram is created in an existing and open block design. In addition, the target part
		/// specified by the current project or in-memory project must be compatible with the template
		/// design or an error is returned.
		/// The command returns a transcript of its process, or returns an error if it fails.
		///
		/// The following example builds the specified template block design in the specified design:
		/// instantiate_template_bd_design -design myFirstZynq \
		/// [lindex [get_template_bd_designs] 1]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 980
		/// </summary>
		/// <param name="design">
		/// Required
		/// Block Design Name
		/// </param>
		/// <param name="options">
		/// Required
		/// Configurable options
		/// </param>
		/// <param name="template">
		/// Required
		/// Configurable Design Name
		/// </param>
		/// <param name="hier">
		/// Optional
		/// Hierarchy Block
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>Returns the name of the template applied.</returns>
		public void instantiate_template_bd_design(string design, string options, string template, string hier = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("instantiate_template_bd_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create external port for the corresponding interface pins. If a cell is specified, create external
		/// interface ports for all unconnected interface pins.
		///
		/// Create an external interface port in the current block design and connect that to the selected
		/// block interface pin. If a bd_cell is specified as the argument, all unconnected block interface pins
		/// of that cell will be made external. The created external interface port will have the same
		/// properties as the selected block interface pin.
		/// IMPORTANT! For a group of block interface pins, one external port will be created per block interface pin.
		/// The selected block interface pin, if unconnected, will be connected to a new interface port at the
		/// top-most level of the block design.
		/// This command returns TCL_OK if successful, or TCL_ERROR if it fails, unless -quiet is specified.
		///
		/// The following example will select the specified block interface pin on the bd_cell axi_gpio_0,
		/// and connect it to an external interface port:
		/// make_bd_intf_pins_external [get_bd_intf_pins axi_gpio_0/S_AXI]
		/// The following example will look at all unconnected block interface pins of the bd_cell
		/// axi_gpio_0 and individually connect them to external interface ports:
		/// make_bd_intf_pins_external [get_bd_cells axi_gpio_0]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1030
		/// </summary>
		/// <param name="objects">
		/// Required
		/// The interface pins/cells to be made external
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>Pass if successful in creating at least one interface port</returns>
		public void make_bd_intf_pins_external(string objects, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("make_bd_intf_pins_external");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create external port for the corresponding pin. If a cell is specified, create external ports for all
		/// unconnected pins.
		///
		/// Create an external port in the current block design and connect that to the selected block pin. If
		/// a bd_cell is specified as the argument, all unconnected block pins of that cell will be made
		/// external. The created external port will have the same properties as the selected block pin.
		/// IMPORTANT! For a group of block pins, one external port will be created per block pin.
		/// The selected block pin, if unconnected, will be connected to a new port at the topmost level of
		/// the block design.
		/// This command returns TCL_OK if successful, or TCL_ERROR if it fails, unless -quiet is specified.
		///
		/// The following example will select a block pin on the bd_cell axi_gpio_0 and connect it to an
		/// external port:
		/// make_bd_pins_external [get_bd_pins axi_gpio_0/s_axi_aclk]
		/// The following example will look at all unconnected block pins of the bd_cell axi_gpio_0 and
		/// individually connect them to external ports:
		/// make_bd_pins_external [get_bd_cells axi_gpio_0]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1032
		/// </summary>
		/// <param name="objects">
		/// Required
		/// The pins/cells to be made external
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>Pass if successful in creating at least one port</returns>
		public void make_bd_pins_external(string objects, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("make_bd_pins_external");
			_tcl.Add(command);
		}
		/// <summary>
		/// Move cells into a hierarchy cell. The connections between these cells are maintained; the
		/// connections between these cells and other cells are maintained through crossing hierarchy cell.
		///
		/// Move IP integrator cells into the specified hierarchical module within the current subsystem
		/// design. The connections between the cells being moved are maintained; connections between
		/// these cells and other cells that are not being moved are maintained automatically by IP integrator
		/// adding pins and ports to cross the hierarchical boundary.
		/// Cells in the IP subsystem design can also be copied into a hierarchical module using
		/// copy_bd_objs, and can be grouped and added to a hierarchical module using
		/// group_bd_cells.
		/// This command returns the name of the <parent_cell> module when successful, or returns an
		/// error message if it failed.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1043
		/// </summary>
		/// <param name="prefix">
		/// Optional
		/// Prefix name to add to cells
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="parent_cell">
		/// Optional
		/// Parent cell
		/// </param>
		/// <param name="cells">
		/// Optional
		/// Match engine names against cell names Default: *
		/// </param>
		/// <returns>0 if success.</returns>
		public void move_bd_cells(string prefix = null, bool? quiet = null, bool? verbose = null, string parent_cell = null, string cells = null)
		{
			var command = new SimpleTCLCommand("move_bd_cells");
			_tcl.Add(command);
		}
		/// <summary>
		/// Open an existing IP subsystem design from disk file.
		///
		/// Open an IP subsystem design in the IP integrator of the Vivado IDE. The IP subsystem must
		/// previously have been created using the create_bd_design command.
		/// This command returns a message with the name of the opened IP subsystem design, or returns
		/// an error if the command fails.
		///
		/// The following opens the specified IP subsystem design in the current project:
		/// open_bd_design C:/Data/project1/project1.src/sources_1/bd/design_1/
		/// design_1.bd
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1050
		/// </summary>
		/// <param name="name">
		/// Required
		/// Name of IP subsystem design to open
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>The design object. Returns nothing if the command fails.</returns>
		public void open_bd_design(string name, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("open_bd_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Read one or more IPIntegrator design files
		///
		/// Read the specified IP subsystem design files, or block designs, into the current project or the in￾memory design. This command is similar to the add_files command. The block design file is
		/// added to the source fileset as it is read.
		/// RECOMMENDED: Files are read and referenced from their current location, and are not moved into the local
		/// project directories. To bring the file into the local project, use the import_files command instead.
		/// You can use this command to read block designs into the in-memory design, when running the
		/// Vivado tool in Non Project mode, in which there is no project file to maintain and manage the
		/// various project source files. Refer to the Vivado Design Suite User Guide: Design Flows Overview
		/// (UG892) for more information on Non Project mode.
		/// This command returns the name of the IP subsystem design files read, or returns an error if it
		/// fails.
		///
		/// The following example reads the specified IP subsystem design into the current project:
		/// read_bd C:/Data/block_designs/design1.bd
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1130
		/// </summary>
		/// <param name="files">
		/// Required
		/// IPIntegrator design file name(s)
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>list of IPIntegrator design file objects that were added</returns>
		public void read_bd(string files, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("read_bd");
			_tcl.Add(command);
		}
		/// <summary>
		/// Regenerate layout.
		///
		/// Regenerate the layout of the current IP integrator subsystem design in the open canvas. This
		/// command updates and redraws the graphical elements of the subsystem design in the Vivado
		/// IDE.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1200
		/// </summary>
		/// <param name="hierarchy">
		/// Optional
		/// Hierarchy path to the window
		/// </param>
		/// <param name="layout_file">
		/// Optional
		/// layout file previously exported by write_bd_layout using
		/// native format
		/// </param>
		/// <param name="routing">
		/// Optional
		/// Preserve placement of blocks and regenerate routing
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void regenerate_bd_layout(string hierarchy = null, string layout_file = null, bool? routing = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("regenerate_bd_layout");
			_tcl.Add(command);
		}
		/// <summary>
		/// Replace cell1 with cell2 by disconnecting connections to cell1 and connecting those connections
		/// to cell2.
		///
		/// Move the connections currently assigned to one IP integrator cell to another IP integrator cell in
		/// the current design. This is intended to help you quickly replace one cell with another by moving
		/// connections from the source cell to the target cell.
		/// The current, or existing cell, will be relocated from its current position in the block design, and
		/// the new replacing cell will be placed at that location. Connections to the pins and interface pins
		/// on the cell are preserved where possible, and result in a Critical Warning when connections must
		/// be removed.
		/// IMPORTANT! This command is not supported by the UNDO command.
		/// This command returns TCL_OK if successful, or returns TCL_ERROR if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1261
		/// </summary>
		/// <param name="preserve_name">
		/// Optional
		/// cell2 will rename as cell1's name, cell1 rename as
		/// cell1name_old
		/// </param>
		/// <param name="preserve_configuration">
		/// Optional
		/// preserve configuration of cell1 on cell2
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="cell1">
		/// Optional
		/// Cell with connections that are to be disconnected.
		/// </param>
		/// <param name="cell2">
		/// Optional
		/// Cell to be connected to connections that were disconnected
		/// from cell1.
		/// </param>
		/// <returns>TCL_OK, TCL_ERROR if failed.</returns>
		public void replace_bd_cell(bool? preserve_name = null, bool? preserve_configuration = null, bool? quiet = null, bool? verbose = null, string cell1 = null, string cell2 = null)
		{
			var command = new SimpleTCLCommand("replace_bd_cell");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report differences between two block designs. Note this TCL command may compare bus￾interface parameters from IP .xit files that are not reported in the stand-alone diffbd executable.
		///
		/// Analyze and report the difference between two block design files (.bd).
		/// TIP: There is also a standalone version of this command, diffbd, that can be run from the command line. You
		/// can find out more information about this command by typing diffbd -h from the command line. Refer to the
		/// Vivado Design Suite User Guide: Designing IP Subsystems using IP Integrator (UG994) for more informaiton.
		/// This command performs a non-graphical comparison of two block designs to let you compare
		/// revisions of a block design from within revision control systems. Block designs must be specified
		/// as BD objects, as returned by current_bd_design, or get_bd_designs commands. The
		/// design objects can have the same name, but be returned from different .bd files. An error will be
		/// returned if the BD objects refer to the same design.
		/// The differences reported include additions, or changes to the IP in use in the block diagram,
		/// changes to design properties or parameters, changes to the design hierarchy, changes to
		/// connectivity, and changes memory addressing.
		/// This command returns the difference report for the two block designs specified, or returns an
		/// error if it fails.
		///
		/// The following example compares the two specified block designs, one from a file path, the
		/// second from the current open block design, and creates and opens an HTML report format with
		/// the specified depth:
		/// report_bd_diffs C:/Data/Base_Zynq_MPSoC.bd [current_bd_design] \
		/// -file C:/Data/diffs5.htm -open_html -depth 5
		/// The following example takes a snapshot of the current open block design:
		/// report_bd_diffs -take_snapshot
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1264
		/// </summary>
		/// <param name="design1">
		/// Required
		/// Name or file path of first block design to compare
		/// </param>
		/// <param name="design2">
		/// Required
		/// Name or file path of second block design to compare
		/// </param>
		/// <param name="format">
		/// Optional
		/// Format: html or text Default: text
		/// </param>
		/// <param name="file">
		/// Optional
		/// Optional output file name. *.htm* implies HTML format
		/// </param>
		/// <param name="open_html">
		/// Optional
		/// Open HTML report in a browser. Sets format to HTML
		/// </param>
		/// <param name="brief">
		/// Optional
		/// Output only whether files differ. Don't write report
		/// </param>
		/// <param name="strict">
		/// Optional
		/// Non-functional changes are treated as functional changes
		/// </param>
		/// <param name="fast">
		/// Optional
		/// Read BD JSON directly instead of creating in-memory BDs
		/// when possible. Will not compare Bus-Interface parameters
		/// from .XIT files (same as stand-alone diffbd)
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// (Text only) Return the report as a string
		/// </param>
		/// <param name="depth">
		/// Optional
		/// HTML Display Depth for equal items. Used to limit HTML file
		/// size. Does not affect not-equal items. Implies HTML format.
		/// Default: 4
		/// </param>
		/// <param name="crossprobe">
		/// Optional
		/// Enable links on HTML report to select Vivado objects.
		/// Implies open_html
		/// </param>
		/// <param name="repository">
		/// Optional
		/// User repository for designs on disk
		/// </param>
		/// <param name="take_snapshot">
		/// Optional
		/// Take a snapshot of the current block design
		/// </param>
		/// <param name="diff_snapshot">
		/// Optional
		/// Compare the current block design against a snapshot
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>0 if no functional differences, >0 if different, -1 on error</returns>
		public void report_bd_diffs(string design1, string design2, string format = null, string file = null, bool? open_html = null, bool? brief = null, bool? strict = null, bool? fast = null, bool? return_string = null, string depth = null, bool? crossprobe = null, string repository = null, bool? take_snapshot = null, bool? diff_snapshot = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_bd_diffs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Save an existing IP subsystem design to disk file.
		///
		/// Saves any changes to the current or specified IP subsystem design in the IP integrator of the
		/// Vivado Design Suite.
		/// This command returns TCL_OK if successful, or TCL_ERROR if it fails.
		///
		/// The following example saves the current IP subsystem design in the current project:
		/// save_bd_design
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1534
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="name">
		/// Optional
		/// Name of design to save.
		/// </param>
		/// <returns>TCL_OK, TCL_ERROR if failed.</returns>
		public void save_bd_design(bool? quiet = null, bool? verbose = null, string name = null)
		{
			var command = new SimpleTCLCommand("save_bd_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Save a copy of the existing IP subsystem design to specified disk file with a different name.
		/// Generated output products will not be saved.
		///
		/// Save a copy of an existing block design from the IP integrator to a new location, or with a
		/// different name. The generated output products of the block design will not be saved to the new
		/// block design.
		/// Note: You cannot create a copy of a block design that has locked IP. The IP must be unlocked or the
		/// command will return an error.
		///
		/// The following example saves the current block design to the specified directory, and renames it
		/// to the specified name:
		/// save_bd_design_as -dir C:/Data new_Block
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1536
		/// </summary>
		/// <param name="dir">
		/// Optional
		/// Directory path for remote BD to be created and managed.
		/// This is required if a name is not specified
		/// </param>
		/// <param name="ignore_comments">
		/// Optional
		/// Do not save user comments
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite existing file if present
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="name">
		/// Optional
		/// Name of the design to create. This is required if a directory
		/// is not specified
		/// </param>
		/// <returns>TCL_OK, TCL_ERROR if failed.</returns>
		public void save_bd_design_as(string dir = null, bool? ignore_comments = null, bool? force = null, bool? quiet = null, bool? verbose = null, string name = null)
		{
			var command = new SimpleTCLCommand("save_bd_design_as");
			_tcl.Add(command);
		}
		/// <summary>
		/// Move the group of cells inside a hierarchy cell to its parent cell, and then remove the hierarchical
		/// cell. The connections between these cells are maintained; the connections between these cells
		/// and other cells are maintained through crossing hierarchy cell.
		///
		/// This command is intended to undo the grouping of IP integrator cells into a hierarchical module,
		/// by either the group_bd_cells or the move_bd_cells commands. The command moves the
		/// cells inside a selected hierarchical module up one level to the parent cell, and then removes the
		/// hierarchical module.
		/// The connections between the selected cells are maintained. The connections between these cells
		/// and other cells are maintained automatically by removing unneeded subsystem ports and pins.
		/// This command returns 0 if successful, or an error message if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1715
		/// </summary>
		/// <param name="prefix">
		/// Optional
		/// Prefix name to add to cells
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="cells">
		/// Optional
		/// Match engine names against cell names Default: *
		/// </param>
		/// <returns>0 if success.</returns>
		public void ungroup_bd_cells(string prefix = null, bool? quiet = null, bool? verbose = null, string cells = null)
		{
			var command = new SimpleTCLCommand("ungroup_bd_cells");
			_tcl.Add(command);
		}
		/// <summary>
		/// Upgrade configurable IPIntegrator cell(s) to later version
		///
		/// Upgrade IP integrator cells to the latest version available in the IP integrator catalog.
		/// This command lets you update IP integrator subsystem designs from an earlier release to use the
		/// IP cores from the latest catalog.
		/// This command returns the list of IP integrator cells that were upgraded, or returns an error if it
		/// fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1752
		/// </summary>
		/// <param name="objects">
		/// Required
		/// IPIntegrator cells to be upgraded
		/// </param>
		/// <param name="latest">
		/// Optional
		/// Upgrade the IPIntegrator block to the latest version
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>List of IPIntegrator cell names those were upgraded, "" if failed.</returns>
		public void upgrade_bd_cells(string objects, string latest = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("upgrade_bd_cells");
			_tcl.Add(command);
		}
		/// <summary>
		/// Run Parameter Propagation for specified design or for a specific cell.
		///
		/// Validate an IP integrator subsystem design, or IP cell or hierarchical module.
		///
		/// The following example validates the current IP integrator subsystem design, forcing re-validation
		/// if needed:
		/// validate_bd_design -force
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1760
		/// </summary>
		/// <param name="force">
		/// Optional
		/// Force re-run validation on the design
		/// </param>
		/// <param name="design">
		/// Optional
		/// Design name. If not specified, run parameter propagation
		/// on current design
		/// </param>
		/// <param name="include_pfm">
		/// Optional
		/// including validate pfm attributes on the design
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>TCL_OK, TCL_ERROR if failed.</returns>
		public void validate_bd_design(bool? force = null, string design = null, bool? include_pfm = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("validate_bd_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Export the current design to a Tcl file on disk.
		///
		/// Export the current IP integrator subsystem design as a Tcl script file to the disk.
		/// IMPORTANT! Any directory in the path specified by the <name> option must already exist, or the script will
		/// not be created.
		/// The Tcl script file lets you recreate, reuse, and customize IP integrator subsystem designs without
		/// having to archive the original subsystem design.
		/// When working with a new software release, you must use the output script from the
		/// write_bd_tcl command to create a block design in the same software release as the Tcl script
		/// was generated. This ensures the availability of the needed versions of any IP used in the script.
		/// You can then migrate the created block design into a new software release.
		/// This command returns TCL_OK if successful, or TCL_ERROR if it fails, unless -quiet is specified.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1783
		/// </summary>
		/// <param name="tcl_filename">
		/// Required
		/// Name of exported Tcl file
		/// </param>
		/// <param name="force">
		/// Optional
		/// Flag to overwrite existing file.
		/// </param>
		/// <param name="bd_name">
		/// Optional
		/// Name for block diagram. By default will use current block
		/// diagram's name.
		/// </param>
		/// <param name="no_mig_contents">
		/// Optional
		/// Flag to not include MIG PRJ contents into generated Tcl
		/// script, but instead will load PRJ from working directory.
		/// Default is to include MIG PRJ contents in Tcl script.
		/// </param>
		/// <param name="no_ip_version">
		/// Optional
		/// Flag to not include the IP version as part of the IP VLNV in
		/// create_bd_cell commands. NOTE - this may have
		/// implications if there are major IP version changes.
		/// </param>
		/// <param name="ignore_minor_versions">
		/// Optional
		/// Use this flag to create the cells in the design using their
		/// latest minor version. For example, a project contains
		/// versions of blk_mem_gen IP like 7.3, 7.4, 8.3, 8.4. In the
		/// design there is a blk_mem_gen_v7.4. With this flag,
		/// write_bd_tcl will generate the line: create_bd_cell -type ip -
		/// vlnv xilinx.com:ip:blk_mem_gen:7.* bmg_0_v7. When the
		/// generated Tcl script is sourced, the cell bmg_0_v7 will use
		/// the latest blk_mem_gen_v7.
		/// </param>
		/// <param name="bd_folder">
		/// Optional
		/// Remote BD feature - Specify the folder where the design will
		/// be generated when Tcl script is sourced.
		/// </param>
		/// <param name="check_ips">
		/// Optional
		/// By default value = true, therefore, will check if IPs/modules
		/// exist in the IP catalog or project before continuing to
		/// reconstruct the design. Valid values are (true/false), (yes/
		/// no), or (1/0).
		/// </param>
		/// <param name="hier_blks">
		/// Optional
		/// Comma separated list of hierarchical blocks in the design
		/// that will be generated by the Tcl script. Will include any sub￾hierachical blocks within the specified blocks too. This
		/// option will not create the top-level design portion.
		/// </param>
		/// <param name="include_layout">
		/// Optional
		/// By default will NOT include the GUI layout of the design. Use
		/// this argument to include the layout information in the
		/// generated Tcl script.
		/// </param>
		/// <param name="exclude_layout">
		/// Optional
		/// NOTE - This flag will be obsolete in a near future release, but
		/// is currently supported for backwards compatibility. Use this
		/// argument to not include the layout information in the
		/// generated Tcl script.
		/// Name Description
		/// </param>
		/// <param name="make_local">
		/// Optional
		/// Use this flag when you want to write your remote BD out as
		/// a local BD.
		/// </param>
		/// <param name="no_project_wrapper">
		/// Optional
		/// This option is used to write the BD create TCL procs without
		/// any project wrapper.
		/// </param>
		/// <param name="exclude_pfm">
		/// Optional
		/// Use this flag to exclude pfm attributes for this design
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>TCL_OK, TCL_ERROR if failed.</returns>
		public void write_bd_tcl(string tcl_filename, bool? force = null, string bd_name = null, bool? no_mig_contents = null, bool? no_ip_version = null, bool? ignore_minor_versions = null, string bd_folder = null, string check_ips = null, string hier_blks = null, bool? include_layout = null, bool? exclude_layout = null, bool? make_local = null, bool? no_project_wrapper = null, bool? exclude_pfm = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("write_bd_tcl");
			_tcl.Add(command);
		}
	}
}
