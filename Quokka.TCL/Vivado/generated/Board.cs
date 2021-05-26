#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class BoardCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public BoardCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
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
		/// Get the current board object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_board [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Returns the board in use in the current project.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// The board can be specified:<br/>
		/// • When the project is created by selecting Boards from the Default Part dialog box.<br/>
		/// • By setting the BOARD_PART property on the current project as shown in the example.<br/>
		/// • By selecting the Project Device in the Settings dialog box in an open project in the Vivado IDE.<br/>
		/// Refer to the Vivado Design Suite User Guide: System-Level Design Entry (UG895) for information on<br/>
		/// creating projects, and on configuring project settings.<br/>
		/// IMPORTANT! When you specify the board with the set_property command, the target part is also<br/>
		/// changed to match the part required by the specified BOARD property.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The current_board command returns the Vendor:Board_Name:File_Version attributes<br/>
		/// of the current board, as defined in the BOARD_PART property. The command returns nothing<br/>
		/// when the project targets a Xilinx FPGA instead of a TRD and board, or when the BOARD_PART<br/>
		/// property has not been defined. The command returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 379<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>current board object</returns>
		public TTCL current_board(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: current_board [-quiet] [-verbose]
			_tcl.Entry(_builder.current_board(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get the current board_part object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_board_part [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Return the Xilinx device used in the current project or design.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// The board part provides a representation of the Xilinx device in the context of the board-level<br/>
		/// system, and is represented by the part0 component in the Board Interface file.<br/>
		/// The board can be specified:<br/>
		/// • When the project is created by selecting Boards from the Default Part dialog box.<br/>
		/// • By setting the BOARD_PART property on the current project as shown in the example.<br/>
		/// • By selecting the Project Device in the Settings dialog box in an open project in the Vivado IDE.<br/>
		/// Refer to the Vivado Design Suite User Guide: System-Level Design Entry (UG895) for information on<br/>
		/// creating projects, and on configuring project settings.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// IMPORTANT! When you specify the board with the set_property command, the target part is also<br/>
		/// changed to match the part required by the specified BOARD_PART property.<br/>
		/// The current_board_part command returns the NAME property of the current board part.<br/>
		/// The command returns a warning when the project targets a Xilinx FPGA instead of a board, or<br/>
		/// when the BOARD_PART property has not been defined. The command returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 382<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>current board_part object</returns>
		public TTCL current_board_part(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: current_board_part [-quiet] [-verbose]
			_tcl.Entry(_builder.current_board_part(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of board bus net objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_bus_nets [-regexp] [-nocase] [-all] [-filter &lt;arg&gt;] -of_objects &lt;args&gt; [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of individual connection bus nets of the specified connection bus object, or the board<br/>
		/// component or board component pin objects.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Connection buses define the connections between the Xilinx device (part0) and other<br/>
		/// components on the board. Bus nets define individual connections of the connection bus.<br/>
		/// This command returns a list of connection bus nets, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the connection bus nets associated with the specified component of<br/>
		/// the current board:<br/>
		/// get_board_bus_nets -of_objects [get_board_components {*iic_main*}]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 600<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Required)<br/>
		/// Get 'board_bus_net' objects of these types: 'board_bus<br/>
		/// board_component board_component_pin'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="all">(Optional) Returns all enabled as well as disabled buses</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// match board net names against patterns Default: * Values:<br/>
		/// The default search pattern is the wildcard *, or .* when -<br/>
		/// regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of bus nets in the board</returns>
		public TTCL get_board_bus_nets(TCLParameterList of_objects, bool? regexp = null, bool? nocase = null, bool? all = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_board_bus_nets [-regexp] [-nocase] [-all] [-filter <arg>] -of_objects <args> [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_bus_nets(of_objects, regexp, nocase, all, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of board bus objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_buses [-regexp] [-nocase] [-all] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of connection buses defined on the current board, as defined in the Board Interface<br/>
		/// file.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Connection buses define the connections between the Xilinx device (part0) and other<br/>
		/// components on the board.<br/>
		/// This command returns a list of buses, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the connection buses associated with the specified component of<br/>
		/// the current board:<br/>
		/// get_board_buses -of_objects [get_board_components sgmii]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 603<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="all">(Optional) Returns all enabled as well as disabled buses</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'board_bus' objects of these types: 'board<br/>
		/// board_component board_bus_net'.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// match board bus names against patterns Default: * Values:<br/>
		/// The default search pattern is the wildcard *, or .* when -<br/>
		/// regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of buses in the board</returns>
		public TTCL get_board_buses(bool? regexp = null, bool? nocase = null, bool? all = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_board_buses [-regexp] [-nocase] [-all] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_buses(regexp, nocase, all, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of interfaces in the board components that implement busdef specified by VLNV<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_component_interfaces [-regexp] [-nocase] [-all] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of interfaces defined on the components found on the current board, as defined in the<br/>
		/// Board Interface file.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, defined components and<br/>
		/// supported interfaces. You can create custom boards by defining a custom Board Interface file, as<br/>
		/// described in the Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The component interface defines related groups of signals that are found on a component, or a<br/>
		/// component mode.<br/>
		/// This command returns a list of component interfaces, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the component interfaces defined in the Board Interface file for the<br/>
		/// specified board component:<br/>
		/// get_board_component_interfaces -of_objects [get_board_components *part0*]<br/>
		/// The following example gets the component interfaces defined in the Board Interface file, and<br/>
		/// then uses that information to create interfaces in the current project:<br/>
		/// #Get and Create Interfaces for I/O Ports<br/>
		/// foreach x [get_board_component_interfaces] {<br/>
		/// create_interface $x }<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 606<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="all">(Optional) Returns all enabled as well as disabled interfaces</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'board_component_interface' objects of these types:<br/>
		/// 'board board_component'.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Match Bus Interface names against patterns Default: *<br/>
		/// Values: The default search pattern is the wildcard *, or .*<br/>
		/// when -regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of bus interfaces</returns>
		public TTCL get_board_component_interfaces(bool? regexp = null, bool? nocase = null, bool? all = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_board_component_interfaces [-regexp] [-nocase] [-all] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_component_interfaces(regexp, nocase, all, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of component mode objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_component_modes [-regexp] [-nocase] [-all] [-filter &lt;arg&gt;] -of_objects &lt;args&gt; [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of various component modes defined on the current board, as defined in the Board<br/>
		/// Interface file.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The component mode defines various modes of operations that the components on a board may<br/>
		/// have, and the interfaces and preferred IP of those modes.<br/>
		/// This command returns a list of component modes, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the component modes defined in the Board Interface file of the<br/>
		/// specified board:<br/>
		/// get_board_component_modes -of_objects [get_board_components *part0*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 609<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Required) Get 'board_component_mode' objects of these types: 'board_component'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="all">(Optional) Returns all enabled as well as disabled interfaces</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// match board component modes against patterns Default: *<br/>
		/// Values: The default search pattern is the wildcard *, or .*<br/>
		/// when -regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of component modes in the board</returns>
		public TTCL get_board_component_modes(TCLParameterList of_objects, bool? regexp = null, bool? nocase = null, bool? all = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_board_component_modes [-regexp] [-nocase] [-all] [-filter <arg>] -of_objects <args> [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_component_modes(of_objects, regexp, nocase, all, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of board_part pins object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_component_pins [-regexp] [-nocase] [-filter &lt;arg&gt;] -of_objects &lt;args&gt; [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of individual board component pins of the specified board component object of the<br/>
		/// current_board.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// Board components define the list of components found on the board defined by the Board<br/>
		/// Interface file. Component pins enumerate the individual pins of the component.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns a list of component pin objects, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the component pins associated with the specified Xilinx device<br/>
		/// (part0) component object of the current board:<br/>
		/// get_board_component_pins -of_objects [get_board_components *part0*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 612<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Required)<br/>
		/// Get 'board_component_pin' objects of these types:<br/>
		/// 'board_component board_bus_net'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// match board component pin names against patterns<br/>
		/// Default: * Values: The default search pattern is the wildcard<br/>
		/// *, or .* when -regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of pins in the board_part</returns>
		public TTCL get_board_component_pins(TCLParameterList of_objects, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_board_component_pins [-regexp] [-nocase] [-filter <arg>] -of_objects <args> [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_component_pins(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get the list of components available in the board<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_components [-regexp] [-nocase] [-all] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of components defined on the current board, as defined in the Board Interface file.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// This command returns a list of components, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the components defined in the Board Interface file of the specified<br/>
		/// board:<br/>
		/// get_board_components -of_objects [get_boards zed]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 615<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="all">(Optional) Returns all enabled as well as disabled components</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'board_component' objects of these types: 'board<br/>
		/// board_bus board_component_pin'.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Match component names against patterns Default: *<br/>
		/// Values: The default search pattern is the wildcard *, or .*<br/>
		/// when -regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of component objects</returns>
		public TTCL get_board_components(bool? regexp = null, bool? nocase = null, bool? all = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_board_components [-regexp] [-nocase] [-all] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_components(regexp, nocase, all, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of interface ports object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_interface_ports [-regexp] [-nocase] [-filter &lt;arg&gt;] -of_objects &lt;args&gt; [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of various physical ports assigned to the component interfaces defined on the current<br/>
		/// board, as defined in the Board Interface file. The interface ports can be returned from component<br/>
		/// interfaces as specified by the get_board_component_interfaces command, or from the<br/>
		/// component pins returned by get_board_component_pins.<br/>
		/// The Board Interface file, board.xml located in the data/boards folder of the Vivado Design<br/>
		/// Suite installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// In the Board Interface file, a component interface includes a map of the logical ports, that are<br/>
		/// defined in the interface file, with a physical port that relates to the component pin or pins on the<br/>
		/// Xilinx device (part0).<br/>
		/// This command returns a list of the physical ports of the specified component interface, or returns<br/>
		/// an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the board interface ports defined in the Board Interface file for the<br/>
		/// specified board component:<br/>
		/// get_board_interface_ports -of_objects \<br/>
		/// [get_board_component_interfaces *gmii*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 618<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Required)<br/>
		/// Get 'board_component_pin' objects of these types:<br/>
		/// 'board_component_interface board_component_pin'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// match interface port names against patterns Default: *<br/>
		/// Values: The default search pattern is the wildcard *, or .*<br/>
		/// when -regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of ports in the given interface</returns>
		public TTCL get_board_interface_ports(TCLParameterList of_objects, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_board_interface_ports [-regexp] [-nocase] [-filter <arg>] -of_objects <args> [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_interface_ports(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of ip preference objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_ip_preferences [-regexp] [-nocase] [-filter &lt;arg&gt;] -of_objects &lt;args&gt; [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of IP preferences defined on the current board, as defined in the Board Interface file.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// IP preferences define the preferred IP to connect a component interface to in the Board Interface<br/>
		/// file.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns a list of preferred IP for specified component interfaces, or component<br/>
		/// modes, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the IP preferences of the specified component interfaces:<br/>
		/// get_board_ip_preferences -of_objects \<br/>
		/// [get_board_component_interfaces *clock*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 621<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Required)<br/>
		/// Get 'ip_preference' objects of these types:<br/>
		/// 'board_component_mode board_component_interface'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// match ip preferences against patterns Default: * Values: The<br/>
		/// default search pattern is the wildcard *, or .* when -regexp<br/>
		/// is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of ip preferences for the component</returns>
		public TTCL get_board_ip_preferences(TCLParameterList of_objects, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_board_ip_preferences [-regexp] [-nocase] [-filter <arg>] -of_objects <args> [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_ip_preferences(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of board jumper objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_jumpers [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of jumpers defined on the current board, as defined in the Board Interface file.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// The jumpers defined in the board file can be used to enable specific component modes and<br/>
		/// interfaces of the board.<br/>
		/// This command returns a list of jumpers, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the jumpers defined in the Board Interface file of the specified board:<br/>
		/// get_board_jumpers -of_objects [get_boards kc705]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 624<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'board_jumper' objects of these types: 'board'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// match jumper names against patterns Default: * Values:<br/>
		/// The default search pattern is the wildcard *, or .* when -<br/>
		/// regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of jumpers in the board</returns>
		public TTCL get_board_jumpers(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_board_jumpers [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_jumpers(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of board parameter objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_parameters [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of parameters defined on the current board, as defined in the Board Interface file.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// The parameters defined in the board file specify custom or user-defined characteristics of the<br/>
		/// board.<br/>
		/// This command returns a list of board parameters, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the parameters defined in the Board Interface file of the current<br/>
		/// board:<br/>
		/// get_board_parameters<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 627<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'board_parameter' objects of these types: 'board<br/>
		/// board_component board_component_interface'.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// match parameter names against patterns Default: * Values:<br/>
		/// The default search pattern is the wildcard *, or .* when -<br/>
		/// regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of parameters in the board</returns>
		public TTCL get_board_parameters(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_board_parameters [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_parameters(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of interfaces in the board_part that implement busdef specified by VLNV<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_part_interfaces [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of interfaces defined on the Xilinx device, or current board part as defined by the<br/>
		/// BOARD_PART property, on the board in use by the current project or open design.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The board part provides a representation of the Xilinx device in the context of the board-level<br/>
		/// system, and is represented by the part0 component in the Board Interface file. The<br/>
		/// current_board_part command returns the board part in use by the current project.<br/>
		/// The interfaces defined on the current board part define related groups of signals that can be used<br/>
		/// to quickly connect the elements of a block design in Vivado IP integrator, or configure IP from<br/>
		/// the Xilinx IP catalog. The interfaces available on the current_board_part can be used to<br/>
		/// define the interfaces required in an IP subsystem design, using create_bd_interface_port<br/>
		/// or create_bd_port. It can also be used to define the interfaces available in the overall FPGA<br/>
		/// design using create_interface and create_port.<br/>
		/// This command returns a list of available interfaces on the current board part, or returns an error<br/>
		/// if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of all interfaces defined on the current board part:<br/>
		/// join [get_board_part_interfaces] \n<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 630<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'board_component_interface' objects of these types:<br/>
		/// 'board board_component'.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Match Bus Interface names against patterns Default: *<br/>
		/// Values: The default search pattern is the wildcard *, or .*<br/>
		/// when -regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of bus interfaces</returns>
		public TTCL get_board_part_interfaces(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_board_part_interfaces [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_part_interfaces(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of board_part pins object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_part_pins [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of component pin objects on the current board part in use by the current project or<br/>
		/// design.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The board part provides a representation of the Xilinx device in the context of the board-level<br/>
		/// system, and is represented by the part0 component in the Board Interface file. The<br/>
		/// current_board_part command returns the board part in use by the current project.<br/>
		/// The board part pin represents the component pin of an implemented interface on the Xilinx<br/>
		/// device. The component pin includes properties like LOC, IOSTANDARD, and SLEW. Board part<br/>
		/// pins can be scalar or vector, so it is always represented as bitwise.<br/>
		/// The board part pins can be used to define and place PORTS in the top-level FPGA design, using<br/>
		/// the create_port and set_property PACKAGE_PIN commands.<br/>
		/// This command returns a list of component pins, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example returns the physical pins of the specified board part interface:<br/>
		/// get_board_part_pins -of [get_board_part_interfaces push_buttons_5bits]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example assigns the PACKAGE_PIN and IOSTANDARD properties on the specified<br/>
		/// port in the current design according to the properties on the leds_8bits pins in the current board:<br/>
		/// set_property PACKAGE_PIN [get_property LOC \<br/>
		/// [get_board_part_pins leds_8bits_TRI_O[1]]] [get_ports LEDS_n[1]]<br/>
		/// set_property IOSTANDARD [get_property IOSTANDARD \<br/>
		/// [get_board_part_pins leds_8bits_TRI_O[1]]] [get_ports LEDS_n[1]]<br/>
		/// The following example gets a list of board part pins assigned to the leds_8bits board part<br/>
		/// interface; stores those pins in a Tcl variable $boardPins, and then prints the LOC property for<br/>
		/// each of those pins:<br/>
		/// set boardPins [get_board_part_pins -of \<br/>
		/// [get_board_part_interfaces -filter {NAME == led_8bits}]]<br/>
		/// foreach pin $boardPins {puts "The location of $pin is: \<br/>
		/// [get_property LOC $pin]"}<br/>
		/// The location of leds_8bits_tri_o[0] is: AB8<br/>
		/// The location of leds_8bits_tri_o[1] is: AA8<br/>
		/// The location of leds_8bits_tri_o[2] is: AC9<br/>
		/// The location of leds_8bits_tri_o[3] is: AB9<br/>
		/// The location of leds_8bits_tri_o[4] is: AE26<br/>
		/// The location of leds_8bits_tri_o[5] is: G19<br/>
		/// The location of leds_8bits_tri_o[6] is: E18<br/>
		/// The location of leds_8bits_tri_o[7] is: F16<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 634<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'board_component_pin' objects of these types:<br/>
		/// 'board_component_interface board_interface_port'.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// match board_part pin names against patterns Default: *<br/>
		/// Values: The default search pattern is the wildcard *, or .*<br/>
		/// when -regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of pins in the board_part</returns>
		public TTCL get_board_part_pins(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_board_part_pins [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_part_pins(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get the list of board_part available in the project<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_parts [-regexp] [-nocase] [-latest_file_version] [-latest_hw_revision] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of available board parts in the board repository, as defined by the Board Interface files<br/>
		/// available for use by the current project or design.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The board part provides a representation of the Xilinx device in the context of the board-level<br/>
		/// system, and is represented by the part0 component in the Board Interface file. The<br/>
		/// current_board_part command returns the board part in use by the current project. Refer to<br/>
		/// the current_board_part command for the different methods of defining the board in use.<br/>
		/// This command returns the list of available Xilinx devices (part0) in the Board Interface files<br/>
		/// defined in the current board repository, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the board parts matching the specified filter search pattern:<br/>
		/// get_board_parts -filter {BOARD_NAME=~z*}<br/>
		/// The following example returns all board parts matching the specified search patterns:<br/>
		/// get_board_parts {*av* *kc*}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 638<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="latest_file_version">(Optional) Show only latest board parts by file version</param>
		/// <param name="latest_hw_revision">(Optional) Show only latest board parts by board revision</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Match Board Part names against patterns Default: * Values:<br/>
		/// The default search pattern is the wildcard *, or .* when -<br/>
		/// regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of board_part objects</returns>
		public TTCL get_board_parts(bool? regexp = null, bool? nocase = null, bool? latest_file_version = null, bool? latest_hw_revision = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_board_parts [-regexp] [-nocase] [-latest_file_version] [-latest_hw_revision] [-filter <arg>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_parts(regexp, nocase, latest_file_version, latest_hw_revision, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get the list of boards available in the project<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_boards [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of evaluation boards available for use by the current project.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// The board in use by the project is returned by the current_board_part command.<br/>
		/// The board can be specified:<br/>
		/// • When the project is created by selecting Boards from the Default Part dialog box.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • By setting the BOARD property on the current project as shown in the example.<br/>
		/// • By selecting the Project Device in the Settings dialog box in an open project in the Vivado IDE.<br/>
		/// Refer to the Vivado Design Suite User Guide: System-Level Design Entry (UG895) for information on<br/>
		/// creating projects, and on configuring project settings.<br/>
		/// IMPORTANT! When you specify the board with the set_property command, the target part is also<br/>
		/// changed to match the part required by the specified BOARD property.<br/>
		/// This command returns a list of boards that are available for use by the current project, or returns<br/>
		/// an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the properties of the specified evaluation board:<br/>
		/// report_property [get_boards -filter {LIBRARY_NAME==artix7}]<br/>
		/// The following example returns all boards matching the specified search patterns:<br/>
		/// get_boards {*ar* *kc*}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 642<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'board' objects of these types: 'board_component'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Match Board names against patterns Default: * Values: The<br/>
		/// default search pattern is the wildcard *, or .* when -regexp<br/>
		/// is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of board objects</returns>
		public TTCL get_boards(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_boards [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_boards(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Check whether the XML files describing a board in the given directory are valid. Only supported<br/>
		/// for board XML files with schema_version&gt;=2.0. The XML files must contain an appropriate<br/>
		/// DOCTYPE declaration to be fully validated. Examples: &lt;!DOCTYPE board SYSTEM "board.dtd"&gt;<br/>
		/// &lt;!-- for board.xml --&gt; &lt;!DOCTYPE ip_presets SYSTEM "preset.dtd"&gt; &lt;!-- for preset.xml --&gt; &lt;!<br/>
		/// DOCTYPE part_info SYSTEM "part0_pins.dtd"&gt; &lt;!-- for part0_pins.xml --&gt;<br/>
		/// Note that if a project is open and an IP repository loaded, this command will also validate certain<br/>
		/// IP and Interface attributes used in the board definition against the current IP repository.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: validate_board_files [-quiet] [-verbose] [&lt;dir&gt;...]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1796<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="dir">
		/// <para>
		/// (Optional)<br/>
		/// The name of a directory containing the board files<br/>
		/// (board.xml, part0_pins.xml, preset.xml) to be checked<br/>
		/// </para>
		/// </param>
		/// <returns>ok if all board files are valid</returns>
		public TTCL validate_board_files(bool? quiet = null, bool? verbose = null, TCLObjectList dir = null)
		{
			// TCL Syntax: validate_board_files [-quiet] [-verbose] [<dir>...]
			_tcl.Entry(_builder.validate_board_files(quiet, verbose, dir));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
