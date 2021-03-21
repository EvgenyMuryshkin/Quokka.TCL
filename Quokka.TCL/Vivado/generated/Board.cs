// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class BoardCommands
	{
		private readonly QuokkaTCL _tcl;
		public BoardCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
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
		/// Get the current board object
		///
		/// Returns the board in use in the current project.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// The board can be specified:
		/// • When the project is created by selecting Boards from the Default Part dialog box.
		/// • By setting the BOARD_PART property on the current project as shown in the example.
		/// • By selecting the Project Device in the Settings dialog box in an open project in the Vivado IDE.
		/// Refer to the Vivado Design Suite User Guide: System-Level Design Entry (UG895) for information on
		/// creating projects, and on configuring project settings.
		/// IMPORTANT! When you specify the board with the set_property command, the target part is also
		/// changed to match the part required by the specified BOARD property.
		/// The current_board command returns the Vendor:Board_Name:File_Version attributes
		/// of the current board, as defined in the BOARD_PART property. The command returns nothing
		/// when the project targets a Xilinx FPGA instead of a TRD and board, or when the BOARD_PART
		/// property has not been defined. The command returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 369
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>current board object</returns>
		public void current_board(bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("current_board");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the current board_part object
		///
		/// Return the Xilinx device used in the current project or design.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// The board part provides a representation of the Xilinx device in the context of the board-level
		/// system, and is represented by the part0 component in the Board Interface file.
		/// The board can be specified:
		/// • When the project is created by selecting Boards from the Default Part dialog box.
		/// • By setting the BOARD_PART property on the current project as shown in the example.
		/// • By selecting the Project Device in the Settings dialog box in an open project in the Vivado IDE.
		/// Refer to the Vivado Design Suite User Guide: System-Level Design Entry (UG895) for information on
		/// creating projects, and on configuring project settings.
		/// IMPORTANT! When you specify the board with the set_property command, the target part is also
		/// changed to match the part required by the specified BOARD_PART property.
		/// The current_board_part command returns the NAME property of the current board part.
		/// The command returns a warning when the project targets a Xilinx FPGA instead of a board, or
		/// when the BOARD_PART property has not been defined. The command returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 372
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>current board_part object</returns>
		public void current_board_part(bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("current_board_part");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of board bus net objects
		///
		/// Gets a list of individual connection bus nets of the specified connection bus object, or the board
		/// component or board component pin objects.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// Connection buses define the connections between the Xilinx device (part0) and other
		/// components on the board. Bus nets define individual connections of the connection bus.
		/// This command returns a list of connection bus nets, or returns an error if it fails.
		///
		/// The following example gets the connection bus nets associated with the specified component of
		/// the current board:
		/// get_board_bus_nets -of_objects [get_board_components {*iic_main*}]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 587
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Get 'board_bus_net' objects of these types: 'board_bus
		/// board_component board_component_pin'.
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// Perform case-insensitive matching
		/// </param>
		/// <param name="all">
		/// Optional
		/// Returns all enabled as well as disabled buses
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
		/// match board net names against patterns Default: * Values:
		/// The default search pattern is the wildcard *, or .* when -
		/// regexp is specified.
		/// </param>
		/// <returns>list of bus nets in the board</returns>
		public void get_board_bus_nets(string of_objects, bool? regexp = null, bool? nocase = null, bool? all = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_board_bus_nets");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of board bus objects
		///
		/// Gets a list of connection buses defined on the current board, as defined in the Board Interface
		/// file.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// Connection buses define the connections between the Xilinx device (part0) and other
		/// components on the board.
		/// This command returns a list of buses, or returns an error if it fails.
		///
		/// The following example gets the connection buses associated with the specified component of
		/// the current board:
		/// get_board_buses -of_objects [get_board_components sgmii]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 590
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Get 'board_bus' objects of these types: 'board
		/// board_component board_bus_net'.
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// Perform case-insensitive matching
		/// </param>
		/// <param name="all">
		/// Optional
		/// Returns all enabled as well as disabled buses
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
		/// match board bus names against patterns Default: * Values:
		/// The default search pattern is the wildcard *, or .* when -
		/// regexp is specified.
		/// </param>
		/// <returns>list of buses in the board</returns>
		public void get_board_buses(string of_objects, bool? regexp = null, bool? nocase = null, bool? all = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_board_buses");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of interfaces in the board components that implement busdef specified by VLNV
		///
		/// Gets a list of interfaces defined on the components found on the current board, as defined in the
		/// Board Interface file.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, defined components and
		/// supported interfaces. You can create custom boards by defining a custom Board Interface file, as
		/// described in the Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// The component interface defines related groups of signals that are found on a component, or a
		/// component mode.
		/// This command returns a list of component interfaces, or returns an error if it fails.
		///
		/// The following example gets the component interfaces defined in the Board Interface file for the
		/// specified board component:
		/// get_board_component_interfaces -of_objects [get_board_components *part0*]
		/// The following example gets the component interfaces defined in the Board Interface file, and
		/// then uses that information to create interfaces in the current project:
		/// #Get and Create Interfaces for I/O Ports
		/// foreach x [get_board_component_interfaces] {
		/// create_interface $x }
		///
		/// See ug835-vivado-tcl-commands.pdf, page 593
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Get 'board_component_interface' objects of these types:
		/// 'board board_component'.
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// Perform case-insensitive matching
		/// </param>
		/// <param name="all">
		/// Optional
		/// Returns all enabled as well as disabled interfaces
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
		/// Match Bus Interface names against patterns Default: *
		/// Values: The default search pattern is the wildcard *, or .*
		/// when -regexp is specified.
		/// </param>
		/// <returns>list of bus interfaces</returns>
		public void get_board_component_interfaces(string of_objects, bool? regexp = null, bool? nocase = null, bool? all = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_board_component_interfaces");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of component mode objects
		///
		/// Gets a list of various component modes defined on the current board, as defined in the Board
		/// Interface file.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// The component mode defines various modes of operations that the components on a board may
		/// have, and the interfaces and preferred IP of those modes.
		/// This command returns a list of component modes, or returns an error if it fails.
		///
		/// The following example gets the component modes defined in the Board Interface file of the
		/// specified board:
		/// get_board_component_modes -of_objects [get_board_components *part0*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 596
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Get 'board_component_mode' objects of these types:
		/// 'board_component'.
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// Perform case-insensitive matching
		/// </param>
		/// <param name="all">
		/// Optional
		/// Returns all enabled as well as disabled interfaces
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
		/// match board component modes against patterns Default: *
		/// Values: The default search pattern is the wildcard *, or .*
		/// when -regexp is specified.
		/// </param>
		/// <returns>list of component modes in the board</returns>
		public void get_board_component_modes(string of_objects, bool? regexp = null, bool? nocase = null, bool? all = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_board_component_modes");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of board_part pins object
		///
		/// Gets a list of individual board component pins of the specified board component object of the
		/// current_board.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// Board components define the list of components found on the board defined by the Board
		/// Interface file. Component pins enumerate the individual pins of the component.
		/// This command returns a list of component pin objects, or returns an error if it fails.
		///
		/// The following example gets the component pins associated with the specified Xilinx device
		/// (part0) component object of the current board:
		/// get_board_component_pins -of_objects [get_board_components *part0*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 599
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Get 'board_component_pin' objects of these types:
		/// 'board_component board_bus_net'.
		/// </param>
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
		/// match board component pin names against patterns
		/// Default: * Values: The default search pattern is the wildcard
		/// *, or .* when -regexp is specified.
		/// </param>
		/// <returns>list of pins in the board_part</returns>
		public void get_board_component_pins(string of_objects, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_board_component_pins");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the list of components available in the board
		///
		/// Gets a list of components defined on the current board, as defined in the Board Interface file.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// This command returns a list of components, or returns an error if it fails.
		///
		/// The following example gets the components defined in the Board Interface file of the specified
		/// board:
		/// get_board_components -of_objects [get_boards zed]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 602
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Get 'board_component' objects of these types: 'board
		/// board_bus board_component_pin'.
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// Perform case-insensitive matching
		/// </param>
		/// <param name="all">
		/// Optional
		/// Returns all enabled as well as disabled components
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
		/// Match component names against patterns Default: *
		/// Values: The default search pattern is the wildcard *, or .*
		/// when -regexp is specified.
		/// </param>
		/// <returns>list of component objects</returns>
		public void get_board_components(string of_objects, bool? regexp = null, bool? nocase = null, bool? all = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_board_components");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of interface ports object
		///
		/// Gets a list of various physical ports assigned to the component interfaces defined on the current
		/// board, as defined in the Board Interface file. The interface ports can be returned from component
		/// interfaces as specified by the get_board_component_interfaces command, or from the
		/// component pins returned by get_board_component_pins.
		/// The Board Interface file, board.xml located in the data/boards folder of the Vivado Design
		/// Suite installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// In the Board Interface file, a component interface includes a map of the logical ports, that are
		/// defined in the interface file, with a physical port that relates to the component pin or pins on the
		/// Xilinx device (part0).
		/// This command returns a list of the physical ports of the specified component interface, or returns
		/// an error if it fails.
		///
		/// The following example gets the board interface ports defined in the Board Interface file for the
		/// specified board component:
		/// get_board_interface_ports -of_objects \
		/// [get_board_component_interfaces *gmii*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 605
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Get 'board_component_pin' objects of these types:
		/// 'board_component_interface board_component_pin'.
		/// </param>
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
		/// match interface port names against patterns Default: *
		/// Values: The default search pattern is the wildcard *, or .*
		/// when -regexp is specified.
		/// </param>
		/// <returns>list of ports in the given interface</returns>
		public void get_board_interface_ports(string of_objects, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_board_interface_ports");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of ip preference objects
		///
		/// Gets a list of IP preferences defined on the current board, as defined in the Board Interface file.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// IP preferences define the preferred IP to connect a component interface to in the Board Interface
		/// file.
		/// This command returns a list of preferred IP for specified component interfaces, or component
		/// modes, or returns an error if it fails.
		///
		/// The following example gets the IP preferences of the specified component interfaces:
		/// get_board_ip_preferences -of_objects \
		/// [get_board_component_interfaces *clock*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 608
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Get 'ip_preference' objects of these types:
		/// 'board_component_mode board_component_interface'.
		/// </param>
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
		/// match ip preferences against patterns Default: * Values: The
		/// default search pattern is the wildcard *, or .* when -regexp
		/// is specified.
		/// </param>
		/// <returns>list of ip preferences for the component</returns>
		public void get_board_ip_preferences(string of_objects, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_board_ip_preferences");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of board jumper objects
		///
		/// Gets a list of jumpers defined on the current board, as defined in the Board Interface file.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// The jumpers defined in the board file can be used to enable specific component modes and
		/// interfaces of the board.
		/// This command returns a list of jumpers, or returns an error if it fails.
		///
		/// The following example gets the jumpers defined in the Board Interface file of the specified board:
		/// get_board_jumpers -of_objects [get_boards kc705]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 611
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Get 'board_jumper' objects of these types: 'board'.
		/// </param>
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
		/// match jumper names against patterns Default: * Values:
		/// The default search pattern is the wildcard *, or .* when -
		/// regexp is specified.
		/// </param>
		/// <returns>list of jumpers in the board</returns>
		public void get_board_jumpers(string of_objects, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_board_jumpers");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of board parameter objects
		///
		/// Gets a list of parameters defined on the current board, as defined in the Board Interface file.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// The parameters defined in the board file specify custom or user-defined characteristics of the
		/// board.
		/// This command returns a list of board parameters, or returns an error if it fails.
		///
		/// The following example gets the parameters defined in the Board Interface file of the current
		/// board:
		/// get_board_parameters
		///
		/// See ug835-vivado-tcl-commands.pdf, page 614
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Get 'board_parameter' objects of these types: 'board
		/// board_component board_component_interface'.
		/// </param>
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
		/// match parameter names against patterns Default: * Values:
		/// The default search pattern is the wildcard *, or .* when -
		/// regexp is specified.
		/// </param>
		/// <returns>list of parameters in the board</returns>
		public void get_board_parameters(string of_objects, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_board_parameters");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of interfaces in the board_part that implement busdef specified by VLNV
		///
		/// Gets a list of interfaces defined on the Xilinx device, or current board part as defined by the
		/// BOARD_PART property, on the board in use by the current project or open design.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// The board part provides a representation of the Xilinx device in the context of the board-level
		/// system, and is represented by the part0 component in the Board Interface file. The
		/// current_board_part command returns the board part in use by the current project.
		/// The interfaces defined on the current board part define related groups of signals that can be used
		/// to quickly connect the elements of a block design in Vivado IP integrator, or configure IP from
		/// the Xilinx IP catalog. The interfaces available on the current_board_part can be used to
		/// define the interfaces required in an IP subsystem design, using create_bd_interface_port
		/// or create_bd_port. It can also be used to define the interfaces available in the overall FPGA
		/// design using create_interface and create_port.
		/// This command returns a list of available interfaces on the current board part, or returns an error
		/// if it fails.
		///
		/// The following example gets a list of all interfaces defined on the current board part:
		/// join [get_board_part_interfaces] \n
		///
		/// See ug835-vivado-tcl-commands.pdf, page 617
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Get 'board_component_interface' objects of these types:
		/// 'board board_component'.
		/// </param>
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
		/// Match Bus Interface names against patterns Default: *
		/// Values: The default search pattern is the wildcard *, or .*
		/// when -regexp is specified.
		/// </param>
		/// <returns>list of bus interfaces</returns>
		public void get_board_part_interfaces(string of_objects, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_board_part_interfaces");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of board_part pins object
		///
		/// Gets a list of component pin objects on the current board part in use by the current project or
		/// design.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// The board part provides a representation of the Xilinx device in the context of the board-level
		/// system, and is represented by the part0 component in the Board Interface file. The
		/// current_board_part command returns the board part in use by the current project.
		/// The board part pin represents the component pin of an implemented interface on the Xilinx
		/// device. The component pin includes properties like LOC, IOSTANDARD, and SLEW. Board part
		/// pins can be scalar or vector, so it is always represented as bitwise.
		/// The board part pins can be used to define and place PORTS in the top-level FPGA design, using
		/// the create_port and set_property PACKAGE_PIN commands.
		/// This command returns a list of component pins, or returns an error if it fails.
		///
		/// This example returns the physical pins of the specified board part interface:
		/// get_board_part_pins -of [get_board_part_interfaces push_buttons_5bits]
		/// The following example assigns the PACKAGE_PIN and IOSTANDARD properties on the specified
		/// port in the current design according to the properties on the leds_8bits pins in the current board:
		/// set_property PACKAGE_PIN [get_property LOC \
		/// [get_board_part_pins leds_8bits_TRI_O[1]]] [get_ports LEDS_n[1]]
		/// set_property IOSTANDARD [get_property IOSTANDARD \
		/// [get_board_part_pins leds_8bits_TRI_O[1]]] [get_ports LEDS_n[1]]
		/// The following example gets a list of board part pins assigned to the leds_8bits board part
		/// interface; stores those pins in a Tcl variable $boardPins, and then prints the LOC property for
		/// each of those pins:
		/// set boardPins [get_board_part_pins -of \
		/// [get_board_part_interfaces -filter {NAME == led_8bits}]]
		/// foreach pin $boardPins {puts "The location of $pin is: \
		/// [get_property LOC $pin]"}
		/// The location of leds_8bits_tri_o[0] is: AB8
		/// The location of leds_8bits_tri_o[1] is: AA8
		/// The location of leds_8bits_tri_o[2] is: AC9
		/// The location of leds_8bits_tri_o[3] is: AB9
		/// The location of leds_8bits_tri_o[4] is: AE26
		/// The location of leds_8bits_tri_o[5] is: G19
		/// The location of leds_8bits_tri_o[6] is: E18
		/// The location of leds_8bits_tri_o[7] is: F16
		///
		/// See ug835-vivado-tcl-commands.pdf, page 621
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Get 'board_component_pin' objects of these types:
		/// 'board_component_interface board_interface_port'.
		/// </param>
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
		/// match board_part pin names against patterns Default: *
		/// Values: The default search pattern is the wildcard *, or .*
		/// when -regexp is specified.
		/// </param>
		/// <returns>list of pins in the board_part</returns>
		public void get_board_part_pins(string of_objects, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_board_part_pins");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the list of board_part available in the project
		///
		/// Gets a list of available board parts in the board repository, as defined by the Board Interface files
		/// available for use by the current project or design.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// The board part provides a representation of the Xilinx device in the context of the board-level
		/// system, and is represented by the part0 component in the Board Interface file. The
		/// current_board_part command returns the board part in use by the current project. Refer to
		/// the current_board_part command for the different methods of defining the board in use.
		/// This command returns the list of available Xilinx devices (part0) in the Board Interface files
		/// defined in the current board repository, or returns an error if it fails.
		///
		/// The following example returns the board parts matching the specified filter search pattern:
		/// get_board_parts -filter {BOARD_NAME=~z*}
		/// The following example returns all board parts matching the specified search patterns:
		/// get_board_parts {*av* *kc*}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 625
		/// </summary>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// Perform case-insensitive matching
		/// </param>
		/// <param name="latest_file_version">
		/// Optional
		/// Show only latest board parts by file version
		/// </param>
		/// <param name="latest_hw_revision">
		/// Optional
		/// Show only latest board parts by board revision
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
		/// Match Board Part names against patterns Default: * Values:
		/// The default search pattern is the wildcard *, or .* when -
		/// regexp is specified.
		/// </param>
		/// <returns>list of board_part objects</returns>
		public void get_board_parts(bool? regexp = null, bool? nocase = null, bool? latest_file_version = null, bool? latest_hw_revision = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_board_parts");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the list of boards available in the project
		///
		/// Gets a list of evaluation boards available for use by the current project.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// The board in use by the project is returned by the current_board_part command.
		/// The board can be specified:
		/// • When the project is created by selecting Boards from the Default Part dialog box.
		/// • By setting the BOARD property on the current project as shown in the example.
		/// • By selecting the Project Device in the Settings dialog box in an open project in the Vivado IDE.
		/// Refer to the Vivado Design Suite User Guide: System-Level Design Entry (UG895) for information on
		/// creating projects, and on configuring project settings.
		/// IMPORTANT! When you specify the board with the set_property command, the target part is also
		/// changed to match the part required by the specified BOARD property.
		/// This command returns a list of boards that are available for use by the current project, or returns
		/// an error if it fails.
		///
		/// The following example reports the properties of the specified evaluation board:
		/// report_property [get_boards -filter {LIBRARY_NAME==artix7}]
		/// The following example returns all boards matching the specified search patterns:
		/// get_boards {*ar* *kc*}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 629
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Get 'board' objects of these types: 'board_component'.
		/// </param>
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
		/// Match Board names against patterns Default: * Values: The
		/// default search pattern is the wildcard *, or .* when -regexp
		/// is specified.
		/// </param>
		/// <returns>list of board objects</returns>
		public void get_boards(string of_objects, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_boards");
			_tcl.Add(command);
		}
	}
}
