// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class SDCCommands
	{
		private readonly QuokkaTCL _tcl;
		public SDCCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Get a list of all clocks in the current design
		///
		/// Returns a list of all clocks that have been declared in the current design.
		/// To get a list of specific clocks in the design, use the get_clocks command, or use the filter
		/// command to filter the results returned by all_clocks.
		/// Clocks can be defined by using the create_clock or create_generated_clock
		/// commands.
		///
		/// The following example shows all clocks in the sample CPU netlist project:
		/// % all_clocks
		/// cpuClk wbClk usbClk phy_clk_pad_0_i phy_clk_pad_1_i fftClk
		/// The following example applies the set_propagated_clock command to all clocks, and also
		/// demonstrates how the returned list (all_clocks) can be passed to another command:
		/// % set_propagated_clock [all_clocks]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 69
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>list of clock objects</returns>
		public void all_clocks(bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("all_clocks");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of all input ports in the current design
		///
		/// Returns a list of all input port objects in the current design.
		/// To get a list of specific inputs in the design, use the get_ports command, or use the filter
		/// command to filter the results returned by all_inputs.
		/// The all_inputs command is scoped to return the objects hierarchically, from the top-level of
		/// the design or from the level of the current instance. By default the current instance is defined as
		/// the top level of the design, but can be changed by using the current_instance command.
		///
		/// The following example returns all input port objects in the current design:
		/// all_inputs
		/// This example gets all input port objects, filters out the GT ports, and sets the IOSTANDARD
		/// property for the non-GT ports:
		/// set non_gt_ports [filter [all_inputs] {!is_gt_term}]
		/// set_property IOSTANDARD LVCMOS18 $non_gt_ports
		/// The following example shows how the list returned can be passed to another command:
		/// set_input_delay 5 -clock REFCLK [all_inputs]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 85
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>list of port objects</returns>
		public void all_inputs(bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("all_inputs");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of all output ports in the current design
		///
		/// Returns a list of all output port objects that have been declared in the current design.
		/// To get a list of specific outputs in the design, use the get_ports command, or use the filter
		/// command to filter the results returned by all_outputs.
		/// The all_outputs command is scoped to return the objects hierarchically, from the top-level of
		/// the design or from the level of the current instance. By default the current instance is defined as
		/// the top level of the design, but can be changed by using the current_instance command.
		///
		/// The following example returns all the output ports in the current design:
		/// all_outputs
		/// The following example sets the output delay for all outputs in the design:
		/// set_output_delay 5 -clock REFCLK [all_outputs]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 89
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>list of port objects</returns>
		public void all_outputs(bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("all_outputs");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of register cells or pins in the current design
		///
		/// Returns a list of sequential register cells or register pins in the current design.
		/// TIP: Returned objects includes DSPs and BRAMs as they contain internal registers.
		/// The list of returned objects can be limited by the use of the arguments described below. You can
		/// limit the list of registers returned to a specific clock or clocks, or to registers triggered by the
		/// rising or falling edge of a specified clock.
		/// The list of registers returned by all_registers can also be limited or reduced by the filter
		/// command to filter according to properties assigned to the registers. Properties of an object can
		/// be returned by the list_property or report_property commands.
		/// You can also get a list of the pins of collected registers instead of the register objects by
		/// specifying one or more of the pin arguments.
		///
		/// The following example returns a list of registers that are triggered by the falling edge of any clock
		/// in the design:
		/// all_registers -fall_clock [all_clocks]
		/// The following example sets the minimum delay:
		/// set_min_delay 2.0 -to [all_registers -clock CCLK -data_pins]
		/// The following example extracts all registers on clk_A with *meta* in the name:
		/// filter [all_registers -clock clk_A] {name =~ *meta*}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 93
		/// </summary>
		/// <param name="clock">
		/// Optional
		/// Consider registers of this clock
		/// </param>
		/// <param name="rise_clock">
		/// Optional
		/// Consider registers triggered by clock rising edge
		/// </param>
		/// <param name="fall_clock">
		/// Optional
		/// Consider registers triggered by clock falling edge
		/// </param>
		/// <param name="cells">
		/// Optional
		/// Return list of cells (default)
		/// </param>
		/// <param name="data_pins">
		/// Optional
		/// Return list of register data pins
		/// </param>
		/// <param name="clock_pins">
		/// Optional
		/// Return list of register clock pins
		/// </param>
		/// <param name="async_pins">
		/// Optional
		/// Return list of async preset/clear pins
		/// </param>
		/// <param name="output_pins">
		/// Optional
		/// Return list of register output pins
		/// </param>
		/// <param name="level_sensitive">
		/// Optional
		/// Only consider level-sensitive latches
		/// </param>
		/// <param name="edge_triggered">
		/// Optional
		/// Only consider edge-triggered flip-flops
		/// </param>
		/// <param name="no_hierarchy">
		/// Optional
		/// Only search the current instance
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>list of cell or pin objects</returns>
		public void all_registers(string clock = null, string rise_clock = null, string fall_clock = null, bool? cells = null, bool? data_pins = null, bool? clock_pins = null, bool? async_pins = null, bool? output_pins = null, bool? level_sensitive = null, bool? edge_triggered = null, bool? no_hierarchy = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("all_registers");
			command.OptionalString("clock", clock);
			command.OptionalString("rise_clock", rise_clock);
			command.OptionalString("fall_clock", fall_clock);
			command.Flag("cells", cells);
			command.Flag("data_pins", data_pins);
			command.Flag("clock_pins", clock_pins);
			command.Flag("async_pins", async_pins);
			command.Flag("output_pins", output_pins);
			command.Flag("level_sensitive", level_sensitive);
			command.Flag("edge_triggered", edge_triggered);
			command.Flag("no_hierarchy", no_hierarchy);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a clock object
		///
		/// TIP: The XDC > Timing Constraints language templates and the Timing Constraints Wizard in the Vivado IDE
		/// offer timing diagrams and additional details around defining specific timing constraints. You can refer to these
		/// sources for additional information.
		/// Create a clock object with the specified period or waveform defined in nanoseconds (ns). This
		/// command defines primary clocks which are used by the timing engine as the delay propagation
		/// starting point of any clock edge. The defined clock can be added to the definition of an existing
		/// clock, or overwrite the existing clock.
		/// A virtual clock can be created that has no source in the design. A virtual clock can be used as a
		/// time reference for setting input and output delays but does not physically exist in the design.
		/// A clock can also be generated from an existing physical clock, and derive many of its properties
		/// from the master clock. Use the create_generated_clock command to derive a clock from
		/// an existing physical clock.
		/// IMPORTANT! If you use create_clock to create a generated clock, instead of
		/// create_generated_clock, the created clock does not inherit any of the properties of its source clock. The
		/// insertion delay and jitter of the parent clock will not be propagated to the generated clock, causing incorrect
		/// timing calculations.
		/// The create_clock command returns the name of the clock object that is created.
		///
		/// The following example creates a physical clock called bftClk and defines the clock period:
		/// create_clock -name bftClk -period 5.000 [get_ports bftClk]
		/// Note: If the get_ports command defining the objects is left off of this example, a virtual clock is created
		/// in the design rather than a physical clock.
		/// The following example creates a clock named clk on the input port, bftClk, with a period of 10ns,
		/// the rising edge at 2.4ns and the falling edge at 7.4ns:
		/// create_clock -name clk -period 10.000 -waveform {2.4 7.4} [get_ports
		/// bftClk]
		/// The following example creates a virtual clock since no clock source is specified:
		/// create_clock -name virtual_clock -period 5.000
		/// The following example creates a clock with the falling edge at 2ns and the rising edge at 7ns:
		/// create_clock -name clk -period 10.000 -waveform {7 2} [get_ports bftClk]
		/// Note: Because the falling edge is earlier than the rising edge in the -waveform definition, although it is
		/// specified as arg2, it occurs first in the waveform.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 241
		/// </summary>
		/// <param name="period">
		/// Required
		/// Clock period: Value > 0
		/// </param>
		/// <param name="name">
		/// Optional
		/// Clock name
		/// </param>
		/// <param name="waveform">
		/// Optional
		/// Clock edge specification
		/// </param>
		/// <param name="add">
		/// Optional
		/// Add to the existing clock in source_objects
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
		/// List of clock source ports, pins or nets
		/// </param>
		/// <returns>new clock object</returns>
		public void create_clock(string period, string name = null, string waveform = null, bool? add = null, bool? quiet = null, bool? verbose = null, string objects = null)
		{
			var command = new SimpleTCLCommand("create_clock");
			command.RequiredString("period", period);
			command.OptionalString("name", name);
			command.OptionalString("waveform", waveform);
			command.Flag("add", add);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("objects", objects);
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a generated clock object
		///
		/// TIP: The XDC > Timing Constraints language templates and the Timing Constraints Wizard in the Vivado IDE
		/// offer timing diagrams and additional details around defining specific timing constraints. You can refer to these
		/// sources for additional information.
		/// Generate a new clock object from an existing physical clock object in the design.
		/// Clocks can be added to a design in one of three ways:
		/// • Primary physical or virtual clocks defined with the create_clock command.
		/// • Derived clocks defined with the create_generated_clock command generated from a
		/// primary physical clock.
		/// • Derived clocks automatically generated by the Vivado Design Suite when a clock propagates
		/// through an MMCM/PLL/BUFR.
		/// You can also use the create_generated_clock command to change the name of clocks that
		/// the Vivado tool has auto-derived from an MMCM/PLL/BUFR. In this case, a new clock is not
		/// created, but an existing clock defined on the specified source object is renamed to the provided
		/// name. This requires -name and <object> to be specified, and supports the use of -source
		/// and/or -master_clock to further identify the clock to rename when multiple clocks exist on
		/// the source object. Refer to the Vivado Design Suite User Guide: Using Constraints (UG903) for more
		/// information on renaming auto-derived clocks.
		/// IMPORTANT! You cannot rename a clock that is already in use by other constraints at the time of renaming.
		/// You must rename the clock prior to any other appearance or use of the clock in an XDC file.
		/// This command returns the name of the clock object that is created, or returns an error if it fails.
		///
		/// The following example defines a generated clock that is divided from the master clock found on
		/// the specified CLK pin. Since -name is not specified, the generated clock is assigned the same
		/// name as the pin it is assigned to:
		/// create_generated_clock -divide_by 2 -source \
		/// [get_pins clkgen/cpuClk] [get_nets fftEngine/CLK]
		/// The following example defines a generated clock named CLK1 from the specified source clock,
		/// specifying the edges of the master clock to use as transition points for the generated clock, with
		/// edges shifted by the specified amount. In this example, the -edges option indicates that the
		/// second edge of the source clock is the first rising edge of the generated clock, the third edge of
		/// the source clock is the first falling edge of the generated clock, and the eighth edge of the source
		/// clock is the second rising edge of the generated clock. These values determine the period of the
		/// generated clock as the time from edge 2 to edge 8 of the source clock, and the duty cycle as the
		/// percentage of the period between edge 2 and edge 3 of the source clock. In addition, each edge
		/// of the generated clock is shifted by the specified amount:
		/// create_generated_clock -name CLK1 -source CMB/CLKIN -edges {2 3 8} \
		/// -edge_shift {0 -1.0 -2.0} CMB/CLKOUT
		/// Note: The waveform pattern of the generated clock is repeated based on the transitions defined by the -
		/// edges argument.
		/// This example creates two generated clocks from the output of a MUX, using -master_clock
		/// to identify which clock to use, using -add to assign the generated clocks to the Q pin of a flip
		/// flop, and using -name to define a name for the generated clock, since the object it is assigned to
		/// has multiple clocks assigned:
		/// create_generated_clock -source [get_pins muxOut] -master_clock M_CLKA \
		/// -divide_by 2 -add -name gen_CLKA [get_pins flop_Q]
		/// create_generated_clock -source [get_pins muxOut] -master_clock M_CLKB \
		/// -divide_by 2 -add -name gen_CLKB [get_pins flop_Q]
		/// The following example renames the automatically named clock that is derived by the Vivado
		/// Design Suite on the MMCM clock output:
		/// create_generated_clock -name CLK_DIV2 [get_pins mmcm/CLKOUT1]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 267
		/// </summary>
		/// <param name="objects">
		/// Required
		/// List of clock source ports, pins, or nets
		/// </param>
		/// <param name="name">
		/// Optional
		/// Generated clock name
		/// </param>
		/// <param name="source">
		/// Optional
		/// Master clock source object pin/port
		/// </param>
		/// <param name="edges">
		/// Optional
		/// Edge Specification
		/// </param>
		/// <param name="divide_by">
		/// Optional
		/// Period division factor: Value >= 1 Default: 1
		/// </param>
		/// <param name="multiply_by">
		/// Optional
		/// Period multiplication factor: Value >= 1 Default: 1
		/// </param>
		/// <param name="combinational">
		/// Optional
		/// Create a divide_by 1 clock through combinational logic
		/// </param>
		/// <param name="duty_cycle">
		/// Optional
		/// Duty cycle of clock period: Range: 0.0 to 100.0 Default: 50.0
		/// </param>
		/// <param name="invert">
		/// Optional
		/// Invert the signal
		/// </param>
		/// <param name="edge_shift">
		/// Optional
		/// Edge shift specification
		/// </param>
		/// <param name="add">
		/// Optional
		/// Add to the existing clock in source_objects
		/// </param>
		/// <param name="master_clock">
		/// Optional
		/// Use this clock if multiple clocks present at master pin
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>new clock object</returns>
		public void create_generated_clock(string objects, string name = null, string source = null, string edges = null, string divide_by = null, string multiply_by = null, bool? combinational = null, string duty_cycle = null, bool? invert = null, string edge_shift = null, bool? add = null, string master_clock = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("create_generated_clock");
			command.OptionalString("name", name);
			command.OptionalString("source", source);
			command.OptionalString("edges", edges);
			command.OptionalString("divide_by", divide_by);
			command.OptionalString("multiply_by", multiply_by);
			command.Flag("combinational", combinational);
			command.OptionalString("duty_cycle", duty_cycle);
			command.Flag("invert", invert);
			command.OptionalString("edge_shift", edge_shift);
			command.Flag("add", add);
			command.OptionalString("master_clock", master_clock);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("objects", objects);
			_tcl.Add(command);
		}
		/// <summary>
		/// Set or get the current design.
		///
		/// Defines the current design or returns the name of the current design in the active project.
		/// The current design and current instance are the target of most Tcl commands, design edits and
		/// constraint changes made in the tool. The current instance can be defined using the
		/// current_instance command.
		/// You can use the get_designs command to get a list of open designs in the active project, and
		/// use the get_projects command to get a list of open projects.
		///
		/// The following example sets the design rtl_1 as the current design:
		/// current_design rtl_1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 375
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
		/// <returns>design object</returns>
		public void current_design(bool? quiet = null, bool? verbose = null, string design = null)
		{
			var command = new SimpleTCLCommand("current_design");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("design", design);
			_tcl.Add(command);
		}
		/// <summary>
		/// Set or get the current instance
		///
		/// Set the current instance in the design hierarchy to the specified instance cell or to the top of the
		/// current design. By default, current_instance points to the top module of the
		/// current_design, which is not an instantiated cell object. You can also set
		/// current_instance to reference an instantiated hierarchical cell in the design.
		/// IMPORTANT! Since the top module is not an instantiated object, current_instance returns an empty
		/// string rather than a design object, when set to the top-level of the current design.
		/// The current design and current instance are the target of most of the commands and design
		/// changes you will make. The current design can be defined using the current_design
		/// command.
		/// You must specify the <instance> name relative to the currently defined instance, and use the
		/// established hierarchy separator to define instance paths. You can determine the current hierarchy
		/// separator with the get_hierarchy_separator command.
		/// Use '..' to traverse up the hierarchical instance path when specifying the current instance.
		/// This command returns the name of the design object of the current_instance, or returns nothing
		/// when set to the top of current design.
		///
		/// The following example sets the current instance to the top module of the current design:
		/// current_instance
		/// INFO: [Vivado 12-618] Current instance is the top level of design
		/// 'netlist_1'.
		/// In this example you have selected an object in the Vivado IDE, and you want to set that selected
		/// object as the current instance:
		/// current_instance [lindex [get_selected_objects] 0]
		/// Note: get_selected_objects returns a list, even of one object, so you must use lindex to specify an
		/// object from that list.
		/// The following example first sets the hierarchy separator character, and then sets the current
		/// instance relative to the presently defined current instance:
		/// set_hierarchy_separator |
		/// current_instance ..|cpu_iwb_dat_o|buffer_fifo
		/// The following example returns the name of the presently defined current instance:
		/// current_instance .
		/// cpuEngine|cpu_iwb_dat_o|buffer_fifo
		///
		/// See ug835-vivado-tcl-commands.pdf, page 396
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
		/// Name of instance
		/// </param>
		/// <returns>instance name</returns>
		public void current_instance(bool? quiet = null, bool? verbose = null, string instance = null)
		{
			var command = new SimpleTCLCommand("current_instance");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("instance", instance);
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of cells in the current design
		///
		/// Gets a list of cell objects in the current design that match a specified search pattern. The default
		/// command returns a list of all cells in the current_instance of the open design, as specified by the
		/// current_instance command.
		/// You can use the -hierarchical option to extract cells from the hierarchy of the current
		/// design.
		/// The get_cells command also includes an option to get all replicated cells that are added to a
		/// design during physical optimization, or phys_opt_design. The use of the -
		/// include_replicated_objects option returns the replicated cells of an object when the
		/// original cell is returned. You can use this option to ensure that constraints or properties that are
		/// applied to a cell are also applied to its replicated cells.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example uses regular expression to return cells in the BFT example design that
		/// match the filter expressions for NAME and REF_NAME. In the first command the NAME is
		/// specified in the search pattern, while the second command filters on the NAME property. These
		/// commands return the same results:
		/// get_cells -regexp -filter { REF_NAME =~ FD.* } .*validFor.*
		/// get_cells -regexp -filter { NAME =~ .*validFor.* && REF_NAME =~ FD.* }
		/// The following example searches all levels of the hierarchy for cells beginning with cpu, or fft, and
		/// joins each cell returned with the newline character to put it on a separate line:
		/// join [get_cells -hier {cpu* fft*}] \n
		/// This example gets a list of properties and property values attached to the second object of the
		/// list returned by get_cells:
		/// report_property [lindex [get_cells] 1]
		/// Note: If there are no cells matching the pattern you will get a warning.
		/// This example prints a list of the library cells instantiated into the design at all levels of the
		/// hierarchy, sorting the list for unique names so that each cell is only printed one time:
		/// foreach cell [lsort -unique [get_property LIB_CELL [get_cells -hier \
		/// -filter {IS_PRIMITIVE==1}]]] {puts $cell}
		/// The following example demonstrates the effect of -hierarchical searches, without and with
		/// -regexp:
		/// get_cells -hierarchical *mmcm*
		/// mmcm_replicator_inst_1
		/// mmcm_replicator_inst_1/mmcm_stage[0].mmcm_channel[0].mmcm
		/// get_cells -hierarchical -regexp .*mmcm.*
		/// mmcm_replicator_inst_1
		/// mmcm_replicator_inst_1/mmcm_stage[0].mmcm_channel[0].mmcm
		/// mmcm_replicator_inst_1/mmcm_stage[0].mmcm_channel[0].mmcm/GND
		/// mmcm_replicator_inst_1/mmcm_stage[0].mmcm_channel[0].mmcm/MMCM_Base
		/// Note: The last two cells (GND and MMCM_Base) were not returned in the first example (without -
		/// regexp) because the cell names do not match the search pattern, as it is applied to each level of the
		/// hierarchy.
		/// The following example runs the report_drc command on the current design, and returns any
		/// cells associated with DRC violations:
		/// report_drc -name drc_1
		/// get_cells -of_objects [get_drc_violations]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 635
		/// </summary>
		/// <param name="hsc">
		/// Optional
		/// Hierarchy separator Default: /
		/// </param>
		/// <param name="hierarchical">
		/// Optional
		/// Search level-by-level in current instance
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// Perform case-insensitive matching (valid only when -regexp
		/// specified)
		/// </param>
		/// <param name="filter">
		/// Optional
		/// Filter list with expression
		/// </param>
		/// <param name="of_objects">
		/// Optional
		/// Get cells of these pins, timing paths, nets, bels, clock
		/// regions, sites, or drc violations
		/// </param>
		/// <param name="match_style">
		/// Optional
		/// Style of pattern matching Default: sdc Values: ucf, sdc
		/// </param>
		/// <param name="include_replicated_objects">
		/// Optional
		/// Include replicated objects when searching for patterns. This
		/// option is valid only when patterns is specified.
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
		/// Match cell names against patterns Default: *
		/// </param>
		/// <returns>list of cell objects</returns>
		public void get_cells(string hsc = null, bool? hierarchical = null, bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, string match_style = null, bool? include_replicated_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_cells");
			command.OptionalString("hsc", hsc);
			command.Flag("hierarchical", hierarchical);
			command.Flag("regexp", regexp);
			command.Flag("nocase", nocase);
			command.OptionalString("filter", filter);
			command.OptionalString("of_objects", of_objects);
			command.OptionalString("match_style", match_style);
			command.Flag("include_replicated_objects", include_replicated_objects);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("patterns", patterns);
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of clocks in the current design
		///
		/// Gets a list of clocks in the current design that match a specified search pattern. The default
		/// command gets a list of all clocks in the design, like the all_clocks command.
		/// Clocks can be created using the create_clock or the create_generated_clock
		/// commands, or can be automatically generated by the tool, at the output of an MMCM for
		/// instance.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of clocks matching the various search patterns:
		/// get_clocks {*clock *ck *Clk}
		/// Note: If there are no clocks matching the pattern you will get a warning.
		/// The following example gets the master clock object, and all generated clocks derived from that
		/// clock:
		/// get_clocks -include_generated_clocks wbClk
		/// The following example gets all properties and property values attached to the specified clock:
		/// report_property -all [get_clocks wbClk]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 647
		/// </summary>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// Perform case-insensitive matching (valid only when -regexp
		/// specified)
		/// </param>
		/// <param name="filter">
		/// Optional
		/// Filter list with expression
		/// </param>
		/// <param name="of_objects">
		/// Optional
		/// Get clocks of these pins, nets, or cells
		/// </param>
		/// <param name="match_style">
		/// Optional
		/// Style of pattern matching, valid values are ucf, sdc Default:
		/// sdc
		/// </param>
		/// <param name="include_generated_clocks">
		/// Optional
		/// Include auto-inferred/generated_clocks also.
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
		/// Match clock names against patterns Default: *
		/// </param>
		/// <returns>list of clocks</returns>
		public void get_clocks(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, string match_style = null, bool? include_generated_clocks = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_clocks");
			command.Flag("regexp", regexp);
			command.Flag("nocase", nocase);
			command.OptionalString("filter", filter);
			command.OptionalString("of_objects", of_objects);
			command.OptionalString("match_style", match_style);
			command.Flag("include_generated_clocks", include_generated_clocks);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("patterns", patterns);
			_tcl.Add(command);
		}
		/// <summary>
		/// Get hierarchical separator character
		///
		/// Gets the character currently used for separating levels of hierarchy in the design. You can set the
		/// hierarchy separator using the set_hierarchy_separator command.
		///
		/// The following example gets the currently defined hierarchy separator:
		/// get_hierarchy_separator
		///
		/// See ug835-vivado-tcl-commands.pdf, page 689
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void get_hierarchy_separator(bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("get_hierarchy_separator");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of nets in the current design
		///
		/// Gets a list of nets in the current design that match a specified search pattern. The default
		/// command gets a list of all nets in the current_instance of the open design, as specified by the
		/// current_instance command.
		/// You can use the -hierarchical option to extract nets from the hierarchy of the current
		/// design.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example runs the report_drc command on the current design, returns the list of
		/// violations in the specified DRC report, and then returns any nets associated with the driverless
		/// net rule (NDRV):
		/// report_drc -name drc_1
		/// get_drc_violations -name drc_1
		/// get_nets -of_objects [get_drc_violations -name drc_1 NDRV*]
		/// The following example returns a list of nets that have been marked for debug with the
		/// connect_debug_port command:
		/// get_nets -hier -filter {MARK_DEBUG==1}
		/// This example returns the net attached to the specified hierarchical pin object, then returns the
		/// net segments attached to the pin object, then returns the top-level net segment attached to the
		/// pin object:
		/// get_nets \
		/// -of [get_pins cpuEngine/or1200_cpu/or1200_sprs/esr_reg[9]_i_3/I0]
		/// get_nets -segments \
		/// -of [get_pins cpuEngine/or1200_cpu/or1200_sprs/esr_reg[9]_i_3/I0]
		/// get_nets -top -segments \
		/// -of [get_pins cpuEngine/or1200_cpu/or1200_sprs/esr_reg[9]_i_3/I0]
		/// In the following example, the first command applies the -filter to find nets that have the
		/// IS_INTERNAL property, and then -segment is applied to return the segments of those nets. This
		/// command returns 0 net segments (and a warning). The second command, returns the segments
		/// of all nets, and filters the results to find the segments that have the IS_INTERNAL property, of
		/// which there are 448:
		/// llength [get_nets -segments -filter {IS_INTERNAL}]
		/// WARNING: [Vivado 12-1023] No nets matched for command 'get_nets -segments
		/// -filter IS_INTERNAL'.
		/// 0
		/// llength [filter [get_nets -segments] {IS_INTERNAL}]
		/// 448
		///
		/// See ug835-vivado-tcl-commands.pdf, page 822
		/// </summary>
		/// <param name="hsc">
		/// Optional
		/// Hierarchy separator Default: /
		/// </param>
		/// <param name="hierarchical">
		/// Optional
		/// Search level-by-level in current instance
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// Perform case-insensitive matching (valid only when -regexp
		/// specified)
		/// </param>
		/// <param name="filter">
		/// Optional
		/// Filter list with expression
		/// </param>
		/// <param name="of_objects">
		/// Optional
		/// Get nets of these pins, ports, cells, timing paths or clocks,
		/// drc violations
		/// </param>
		/// <param name="match_style">
		/// Optional
		/// Style of pattern matching, valid values are ucf, sdc Default:
		/// sdc
		/// </param>
		/// <param name="top_net_of_hierarchical_group">
		/// Optional
		/// Return net segment(s) which belong(s) to the high level of a
		/// hierarchical net
		/// </param>
		/// <param name="segments">
		/// Optional
		/// Return all segments of a net across the hierarchy
		/// </param>
		/// <param name="boundary_type">
		/// Optional
		/// Return net segment connected to a hierarchical pin which
		/// resides at the same level as the pin (upper) or at the level
		/// below (lower), or both. Valid values are : upper, lower, both
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
		/// Match net names against patterns Default: *
		/// </param>
		/// <returns>list of net objects</returns>
		public void get_nets(string hsc = null, bool? hierarchical = null, bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, string match_style = null, bool? top_net_of_hierarchical_group = null, bool? segments = null, string boundary_type = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_nets");
			command.OptionalString("hsc", hsc);
			command.Flag("hierarchical", hierarchical);
			command.Flag("regexp", regexp);
			command.Flag("nocase", nocase);
			command.OptionalString("filter", filter);
			command.OptionalString("of_objects", of_objects);
			command.OptionalString("match_style", match_style);
			command.Flag("top_net_of_hierarchical_group", top_net_of_hierarchical_group);
			command.Flag("segments", segments);
			command.OptionalString("boundary_type", boundary_type);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("patterns", patterns);
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of pins in the current design
		///
		/// Gets a list of pin objects in the current design that match a specified search pattern. The default
		/// command gets a list of all pins in the current_instance of the open design, as specified by the
		/// current_instance command. You can use the -hierarchical option to extract pins from
		/// the hierarchy of the current design.
		/// IMPORTANT! Because there are so many pins in the design, the get_pins command can cause performance
		/// issues, and add significant time to processing design constraints. In many cases, a design constraint that is
		/// written with the get_pins command can be rewritten using the get_cells command, as shown in the
		/// examples, to significantly improve constraint processing and performance of the Vivado tool.
		/// The get_pins command also includes an option to get all replicated pins that are added to a
		/// design during physical optimization, or phys_opt_design. The use of the -
		/// include_replicated_objects option returns the pins on replicated cells when the pins of
		/// an original cell are returned. You can use this option to ensure that constraints or properties that
		/// are applied to the pins of a cell are also applied to the pins of its replicated cells.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of pins attached to the specified cells:
		/// get_pins -of_objects [get_cells usb*]
		/// Note: If there are no pins matching the pattern, the tool will return a warning.
		/// This example shows how using get_cells can improve the performance of the get_pins
		/// command:
		/// [get_pins -hier * -filter {NAME=~xx*/yy*}]
		/// can be rewritten as:
		/// [get_pins -filter {REF_PIN_NAME=~yy*} -of [get_cells -hier xx*]]
		/// The following shows how rewriting the set_max_delay constraint can significantly improve
		/// performance:
		/// set_max_delay 15 -from [get_pins -hier \
		/// -filter name=~*/aclk_dpram_reg*/*/CLK] \
		/// -to [get_cells -hier -filter name=~*/bclk_dout_reg*] -datapath_only
		/// can be rewritten as:
		/// set_max_delay 15 -from [get_pins -of \
		/// [get_cells -hier -filter name=~*aclk_dpram_reg*/*] \
		/// -filter {REF_PIN_NAME == CLK}] \
		/// -to [get_pins -of [get_cells -hier -filter {name =~ */bclk_dout_reg*}]
		/// \
		/// -filter {REF_PIN_NAME == D}] -datapath_only
		/// TIP: Although the second command syntax is more complex, the performance gains can be significant.
		/// This example runs the report_drc command on the current design, and then returns any pins
		/// associated with DRC violations:
		/// report_drc -name drc_1
		/// get_pins -of_objects [get_drc_violations]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 851
		/// </summary>
		/// <param name="hsc">
		/// Optional
		/// Hierarchy separator Default: /
		/// </param>
		/// <param name="hierarchical">
		/// Optional
		/// Search level-by-level in current instance
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// Perform case-insensitive matching (valid only when -regexp
		/// specified)
		/// </param>
		/// <param name="leaf">
		/// Optional
		/// Get leaf/global pins of nets with -of_objects
		/// </param>
		/// <param name="filter">
		/// Optional
		/// Filter list with expression
		/// </param>
		/// <param name="of_objects">
		/// Optional
		/// Get pins of these cells, nets, timing paths, clocks, drc
		/// violations
		/// </param>
		/// <param name="match_style">
		/// Optional
		/// Style of pattern matching, valid values are ucf, sdc Default:
		/// sdc
		/// </param>
		/// <param name="include_replicated_objects">
		/// Optional
		/// Include replicated objects when searching for patterns. This
		/// option is valid only when patterns is specified.
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
		/// Match pin names against patterns Default: *
		/// </param>
		/// <returns>list of pin objects</returns>
		public void get_pins(string hsc = null, bool? hierarchical = null, bool? regexp = null, bool? nocase = null, bool? leaf = null, string filter = null, string of_objects = null, string match_style = null, bool? include_replicated_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_pins");
			command.OptionalString("hsc", hsc);
			command.Flag("hierarchical", hierarchical);
			command.Flag("regexp", regexp);
			command.Flag("nocase", nocase);
			command.Flag("leaf", leaf);
			command.OptionalString("filter", filter);
			command.OptionalString("of_objects", of_objects);
			command.OptionalString("match_style", match_style);
			command.Flag("include_replicated_objects", include_replicated_objects);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("patterns", patterns);
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of ports in the current design
		///
		/// Gets a list of port objects in the current design that match a specified search pattern. The default
		/// command gets a list of all ports in the design.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of pins attached to the specified cell:
		/// get_ports -of_objects [lindex [get_cells] 1]
		/// Note: If there are no ports matching the pattern, the tool will return a warning.
		/// The following example runs the report_drc command on the current design, returns the list of
		/// violations in the specified DRC report, and then returns the ports associated with any violations
		/// of the unspecified I/O Standard rule (NSTD):
		/// report_drc -name drc_1
		/// get_drc_violations -name drc_1
		/// get_ports -of_objects [get_drc_violations -name drc_1 NSTD*]
		/// This example specifies a cell for the current instance, returns the pins scoped to the current
		/// instance, and returns the top-level ports connected to those pins:
		/// current_instance [get_cells dac_spi*]
		/// get_ports -scoped_to_current_instance
		/// get_ports -scoped_to_current_instance -prop_thru_buffers
		///
		/// See ug835-vivado-tcl-commands.pdf, page 866
		/// </summary>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// Perform case-insensitive matching (valid only when -regexp
		/// specified)
		/// </param>
		/// <param name="filter">
		/// Optional
		/// Filter list with expression
		/// </param>
		/// <param name="of_objects">
		/// Optional
		/// Get ports of these nets, instances, sites, clocks, timing paths,
		/// io standards, io banks, package pins, drc violations
		/// </param>
		/// <param name="match_style">
		/// Optional
		/// Style of pattern matching, valid values are ucf, sdc Default:
		/// sdc
		/// </param>
		/// <param name="scoped_to_current_instance">
		/// Optional
		/// Match patterns on instance pins specified using current
		/// instance, and then find top level connected ports.
		/// </param>
		/// <param name="no_traverse">
		/// Optional
		/// Do not traverse to find top level terminals.
		/// </param>
		/// <param name="prop_thru_buffers">
		/// Optional
		/// Allow propagate through buffers when traversing to find
		/// top level terminals connected to pins of scoped instance.
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
		/// Match port names against patterns Default: *
		/// </param>
		/// <returns>list of port objects</returns>
		public void get_ports(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, string match_style = null, bool? scoped_to_current_instance = null, bool? no_traverse = null, bool? prop_thru_buffers = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_ports");
			command.Flag("regexp", regexp);
			command.Flag("nocase", nocase);
			command.OptionalString("filter", filter);
			command.OptionalString("of_objects", of_objects);
			command.OptionalString("match_style", match_style);
			command.Flag("scoped_to_current_instance", scoped_to_current_instance);
			command.Flag("no_traverse", no_traverse);
			command.Flag("prop_thru_buffers", prop_thru_buffers);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("patterns", patterns);
			_tcl.Add(command);
		}
		/// <summary>
		/// Groups paths for cost function calculations
		///
		/// This command lets you group a set of paths for cost function calculations, primarily for timing
		/// analysis. The Vivado tool automatically defines path groups of clock signals for special handling.
		/// User-defined path groups can be specified generally as from a startpoint, or to an endpoint, or as
		/// specific paths from-through-to specific points. Once a path group has been created, some timing
		/// analysis can be performed against it with the report_timing command.
		/// You can specify a weight for an existing path group of clocks, and let the placement, routing, and
		/// optimization engines prioritize those paths first.
		/// To remove a path from a path group, you must specify the -default option to remove the path
		/// from a named path group and restore the path to the standard "default" path group.
		/// This option has the following limitations:
		/// • For paths originally assigned by the tool to a clock path group, the -default option will
		/// revert those paths to the clock path group instead of reverting them to the "default" path
		/// group.
		/// • group_path -default and reset_path are completely independent commands. The
		/// reset_path command doesn't affect path groups, and the group_path command doesn't
		/// affect other timing exceptions .
		/// The path groups currently defined in a design can be found by using the get_path_groups
		/// command.
		/// Note: This command operates silently and does not return direct feedback of its operation.
		///
		/// The following example creates a group named signal_grp to the specified registers' endpoints
		/// matching *signal*reg/D, and then reports timing on the specified group:
		/// group_path -to [get_pins *signal*reg/D -hierarchical] -name signal_grp
		/// report_timing -group signal_grp
		/// The path group signal_grp is also returned by the get_path_groups command:
		/// get_path_groups signal_grp
		/// The following example removes the path from the signal_grp, restoring it to the default path
		/// group:
		/// group_path -to [get_pins *signal*reg/D -hierarchical] -default
		///
		/// See ug835-vivado-tcl-commands.pdf, page 948
		/// </summary>
		/// <param name="name">
		/// Optional
		/// The name of group, can be multiple names
		/// </param>
		/// <param name="weight">
		/// Optional
		/// Cost function Weight, Valid values are 1, 2 Default: 1.0
		/// </param>
		/// <param name="@default">
		/// Optional
		/// Restore path to its default group
		/// </param>
		/// <param name="from">
		/// Optional
		/// Filter by paths starting at these path startpoints
		/// </param>
		/// <param name="to">
		/// Optional
		/// Filter by paths terminating at these path endpoints
		/// </param>
		/// <param name="through">
		/// Optional
		/// Consider paths through pins, cells or nets
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void group_path(string name = null, string weight = null, bool? @default = null, string from = null, string to = null, string through = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("group_path");
			command.OptionalString("name", name);
			command.OptionalString("weight", weight);
			command.Flag("default", @default);
			command.OptionalString("from", from);
			command.OptionalString("to", to);
			command.OptionalString("through", through);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			_tcl.Add(command);
		}
		/// <summary>
		/// Specify that an input is 1, 0, rising or falling
		///
		/// Specifies that a pin or port is in a steady state of 1, 0, rising or falling.
		/// This command is usually used to force values onto the ports to help reduce the analysis space,
		/// runtime and memory consumption. It is important to let the Vivado timing engine know about
		/// signals that have a constant value. This is also critical to ensure that non-functional and irrelevant
		/// paths are not reported.
		/// Setting a case value on a pin results in disabling timing analysis through that pin. This means that
		/// timing paths through that pin are not reported.
		/// Note: This command returns nothing if successful, or returns an error if it fails.
		///
		/// In the example below, two clocks are created on the input pins of the BUFGMUX, clock_sel, but
		/// only clk_B is propagated through the output pin after setting the constant value 1 on the
		/// selection pin S:
		/// create_clock -name clk_A -period 10.0 [get_pins clock_sel/I0]
		/// create_clock -name clk_B -period 15.0 [get_pins clock_sel/I1]
		/// set_case_analysis 1 [get_pins clock_sel/S]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1563
		/// </summary>
		/// <param name="value">
		/// Required
		/// Logic value on the pin: Values: 0, 1, rising, falling, zero, one,
		/// rise, fall
		/// </param>
		/// <param name="objects">
		/// Required
		/// List of ports or pins
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_case_analysis(string value, string objects, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_case_analysis");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("value", value);
			command.RequiredString("objects", objects);
			_tcl.Add(command);
		}
		/// <summary>
		/// Set exclusive or asynchronous clock groups
		///
		/// TIP: The XDC > Timing Constraints language templates and the Timing Constraints Wizard in the Vivado IDE
		/// offer timing diagrams and additional details around defining specific timing constraints. You can refer to these
		/// sources for additional information.
		/// Define clocks, or groups of clocks, that are exclusive with or asynchronous to other clocks in the
		/// design. Exclusive clocks are not active at the same time, and paths between them can be ignored
		/// during timing analysis. Asynchronous clocks are clocks with no known phase relationship, which
		/// typically happens when they do not share the same primary clock or do not have a common
		/// period.
		/// Using this command is similar to defining false path constraints for data paths moving between
		/// exclusive or asynchronous clock domains. See the Vivado Design Suite User Guide: Using
		/// Constraints (UG903) for more information.
		/// If only one group is specified, the clocks in that group are asynchronous or exclusive to all other
		/// clocks in the design, but not to each other. If a new clock is created after the
		/// set_clock_groups command, it is asynchronous to that group as well.
		/// This command can also be used for multiple clocks that are derived from a single BUFGMUX as
		/// both of the clocks will not be active at the same time.
		/// Note: This command operates silently and does not return direct feedback of its operation.
		///
		/// Group all the elements driven by src_clk and sync_clk into separate clock groups. The clock
		/// groups are asynchronous to each other:
		/// set_clock_groups -group src_clk -group sync_clk -asynchronous
		/// The following example includes the generated clocks of the specified clocks, and adds those to
		/// the clock group:
		/// set_clock_groups -group [get_clocks -include_generated_clocks src_clk] \
		/// -group [get_clocks -include_generated_clocks sync_clk] -asynchronous
		/// Note: In the preceding example, src_clk and sync_clk, and all their generated clocks, are asynchronous.
		/// Otherwise the generated clocks would be timed against each other and the other master clock.
		/// In this example, the specified clocks are grouped together, and are asynchronous to all other
		/// clocks in the design:
		/// set_clock_groups -async -group [get_clocks {J_CLK U_CLK}]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1565
		/// </summary>
		/// <param name="name">
		/// Optional
		/// Name for clock grouping
		/// </param>
		/// <param name="logically_exclusive">
		/// Optional
		/// Specify logically exclusive clock groups
		/// </param>
		/// <param name="physically_exclusive">
		/// Optional
		/// Specify physically exclusive clock groups
		/// </param>
		/// <param name="asynchronous">
		/// Optional
		/// Specify asynchronous clock groups
		/// </param>
		/// <param name="group">
		/// Optional
		/// Clocks List
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_clock_groups(string name = null, bool? logically_exclusive = null, bool? physically_exclusive = null, bool? asynchronous = null, string group = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_clock_groups");
			command.OptionalString("name", name);
			command.Flag("logically_exclusive", logically_exclusive);
			command.Flag("physically_exclusive", physically_exclusive);
			command.Flag("asynchronous", asynchronous);
			command.OptionalString("group", group);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			_tcl.Add(command);
		}
		/// <summary>
		/// Capture actual or predicted clock latency
		///
		/// This command defines a clock's source or network latency for specified clocks, ports, or pins.
		/// Note: This command operates silently and does not return direct feedback of its operation.
		/// Source latency is the time in nanoseconds that a clock signal takes to propagate from its
		/// waveform origin to the clock definition point in the design. For example, this would be the time
		/// delay for the clock to propagate from its source (oscillator) on the system board to the FPGA
		/// input port.
		/// Network latency is the time a clock signal takes to propagate from its definition point in the
		/// design to a register clock pin on the timing path. The total clock latency at a register clock pin is
		/// the sum of a clock's source latency and network latency.
		///
		/// This example will set an early latency on the rising edge of CLK_A.
		/// set_clock_latency -source -rise -early 0.4 [get_ports CLK_A]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1568
		/// </summary>
		/// <param name="latency">
		/// Required
		/// Latency value
		/// </param>
		/// <param name="objects">
		/// Required
		/// List of clocks, ports or pins
		/// </param>
		/// <param name="clock">
		/// Optional
		/// List of relative clocks
		/// </param>
		/// <param name="rise">
		/// Optional
		/// Specify clock rise latency
		/// </param>
		/// <param name="fall">
		/// Optional
		/// Specify clock fall latency
		/// </param>
		/// <param name="min">
		/// Optional
		/// Specify clock rise and fall min condition latency
		/// </param>
		/// <param name="max">
		/// Optional
		/// Specify clock rise and fall max condition latency
		/// </param>
		/// <param name="source">
		/// Optional
		/// Specify clock rise and fall source latency
		/// </param>
		/// <param name="late">
		/// Optional
		/// Specify clock rise and fall late source latency
		/// </param>
		/// <param name="early">
		/// Optional
		/// Specify clock rise and fall early source latency
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_clock_latency(string latency, string objects, string clock = null, bool? rise = null, bool? fall = null, bool? min = null, bool? max = null, bool? source = null, bool? late = null, bool? early = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_clock_latency");
			command.OptionalString("clock", clock);
			command.Flag("rise", rise);
			command.Flag("fall", fall);
			command.Flag("min", min);
			command.Flag("max", max);
			command.Flag("source", source);
			command.Flag("late", late);
			command.Flag("early", early);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("latency", latency);
			command.RequiredString("objects", objects);
			_tcl.Add(command);
		}
		/// <summary>
		/// Set clock sense on ports or pins
		///
		/// Sets clock sense at specified ports or pins. This is used to define the positive or negative
		/// unateness at the pin relative to a clock object. However, the specified unateness only applies at a
		/// non-unate point in the clock network, at a point where the clock signal cannot be determined.
		/// Since the clock signal is not determined, the defined clock sense propagates forward from the
		/// given pins.
		/// Note: This command operates silently and does not return direct feedback of its operation.
		///
		/// The following example specifies that only the positive unate paths will propagate through the
		/// output pin of the XOR gate as compared with the original clock.
		/// set_clock_sense -positive [get_pins xor_a.z]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1571
		/// </summary>
		/// <param name="pins">
		/// Required
		/// List of port and/or pins
		/// </param>
		/// <param name="positive">
		/// Optional
		/// Specify positive unate (non_inverting) clock sense
		/// </param>
		/// <param name="negative">
		/// Optional
		/// Specify negative unate (inverting) clock sense
		/// </param>
		/// <param name="stop_propagation">
		/// Optional
		/// Stop clock propagation from specified pins
		/// </param>
		/// <param name="clocks">
		/// Optional
		/// List of clocks
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_clock_sense(string pins, bool? positive = null, bool? negative = null, bool? stop_propagation = null, string clocks = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_clock_sense");
			command.Flag("positive", positive);
			command.Flag("negative", negative);
			command.Flag("stop_propagation", stop_propagation);
			command.OptionalString("clocks", clocks);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("pins", pins);
			_tcl.Add(command);
		}
		/// <summary>
		/// set clock uncertainty
		///
		/// This command is used to add to the uncertainty of a clock in the design, and does not override
		/// the default jitter calculation. This is referred to as the user clock uncertainty. The
		/// set_clock_uncertainty command provides a convenient means to over-constrain some
		/// clocks in the design without changing the clock definitions and relationships. It can constrain
		/// setup and hold paths separately using the -setup and -hold options.
		/// Clock uncertainty is the maximum variation, specified in nanoseconds (ns), between two clock
		/// edges at registers within a single clock domain, or crossing between clock domains.
		/// The clock uncertainty is used during setup and hold analysis, where uncertainty is calculated for
		/// each timing path based on the clock edges used by the analysis and the clock tree topology. For
		/// example, for a path where the startpoint and endpoint are connected to the same clock net, the
		/// clock uncertainty is null because the same clock edge is used for both source and destination,
		/// unless the set_clock_uncertainty command is used to add uncertainty for the min delay
		/// analysis. The Vivado timing engine uses clock uncertainty in the slack calculation as determined
		/// by the following equation:
		/// • Setup Slack = Setup Path Requirement - Data Delay - Clock Uncertainty + Clock Skew
		/// Clock Uncertainty is a function of different elements of jitter, as determined by the following
		/// equation which is returned by the report_timing_summary or report_timing commands:
		/// • Clock Uncertainty = (√(Tsj2
		/// + Dj
		/// 2
		/// ))/2 + PE + UU
		/// Where:
		/// • Tsj = Total System Jitter as calculated using the system jitter. See set_system_jitter.
		/// • Dj
		/// = Discrete jitter is the amount of jitter introduced by hardware primitives such as MMCM
		/// or PLL. Discrete jitter is a feature of clocks generated by the MMCM, which includes the input
		/// jitter defined on the primary clock. See set_input_jitter.
		/// • PE = Phase Error, which comes from the MMCM/PLL device model.
		/// • UU = User Uncertainty, which defines the user clock uncertainty specified by this
		/// set_clock_uncertainty command.
		/// TIP: SYSTEM_JITTER is reported as a property of clocks, although it applies to all clocks in the design.
		/// INPUT_JITTER is also a property of primary clocks. These properties can be returned by the get_property or
		/// report_property commands. Jitter and clock uncertainty are reported by the
		/// report_timing_summary and report_timing commands.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example defines the uncertainty between all clock domains:
		/// set_clock_uncertainty 0.225 -from [get_clocks] -to [get_clocks]
		/// The following command defines setup and hold uncertainty within the wbClk clock domain:
		/// set_clock_uncertainty -setup 0.213 [get_clocks wbClk]
		/// set_clock_uncertainty -hold 0.167 [get_clocks wbClk]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1573
		/// </summary>
		/// <param name="uncertainty">
		/// Required
		/// Uncertainty of clock network
		/// </param>
		/// <param name="setup">
		/// Optional
		/// Specify clock uncertainty for setup checks
		/// </param>
		/// <param name="hold">
		/// Optional
		/// Specify clock uncertainty for hold checks
		/// </param>
		/// <param name="from">
		/// Optional
		/// Specify inter-clock uncertainty source clock
		/// </param>
		/// <param name="rise_from">
		/// Optional
		/// Specify inter-clock uncertainty source clock with rising edge
		/// </param>
		/// <param name="fall_from">
		/// Optional
		/// Specify inter-clock uncertainty source clock with falling edge
		/// </param>
		/// <param name="to">
		/// Optional
		/// Specify inter-clock uncertainty destination clock
		/// </param>
		/// <param name="rise_to">
		/// Optional
		/// Specify inter-clock uncertainty destination clock with rising
		/// edge
		/// </param>
		/// <param name="fall_to">
		/// Optional
		/// Specify inter-clock uncertainty destination clock with falling
		/// edge
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
		/// List of clocks, ports or pins
		/// </param>
		public void set_clock_uncertainty(string uncertainty, bool? setup = null, bool? hold = null, string from = null, string rise_from = null, string fall_from = null, string to = null, string rise_to = null, string fall_to = null, bool? quiet = null, bool? verbose = null, string objects = null)
		{
			var command = new SimpleTCLCommand("set_clock_uncertainty");
			command.Flag("setup", setup);
			command.Flag("hold", hold);
			command.OptionalString("from", from);
			command.OptionalString("rise_from", rise_from);
			command.OptionalString("fall_from", fall_from);
			command.OptionalString("to", to);
			command.OptionalString("rise_to", rise_to);
			command.OptionalString("fall_to", fall_to);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("uncertainty", uncertainty);
			command.OptionalString("objects", objects);
			_tcl.Add(command);
		}
		/// <summary>
		/// Create data to data checks
		///
		/// Performs a setup and hold check for a data pin with respect to another data pin. This is different
		/// from a conventional setup and hold check that is done with respect to a clock pin.
		/// This command defines min and max requirements between two endpoints, similar to setup (max)
		/// and hold (min) timing checks. Setup and hold checks are referenced from the related pin,
		/// specified by -from, to the constrained pin, specified by -to. The related pin is similar to the
		/// clock pin in a conventional setup and hold check. The timing analysis compares arrival times
		/// between the two specified endpoints. The difference must be less than the set_data_check
		/// <value> requirement in order to meet timing.
		/// Limitations of the set_data_check command include:
		/// • Variations in the destination clock delay are ignored.
		/// • This command is used for timing purposes only, and is not considered by the Vivado placer or
		/// router.
		/// Note: This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example defines a data check for a setup violation from pin A_IN to pin C_IN:
		/// set_data_check -from A_IN -to C_IN -setup 2.0
		/// In the above example, A_IN is the related pin and C_IN is the constrained pin. The above
		/// constraint would do a setup check of C_IN with respect to A_IN. The data at C_IN should arrive
		/// 2.0 ns prior to the edge of A_IN.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1576
		/// </summary>
		/// <param name="value">
		/// Required
		/// Setup or hold time of the defined checks
		/// </param>
		/// <param name="from">
		/// Optional
		/// From pin/port of data to data check
		/// </param>
		/// <param name="to">
		/// Optional
		/// To pin/port of the data to data check
		/// </param>
		/// <param name="rise_from">
		/// Optional
		/// Rise from pin/port of data to data check
		/// </param>
		/// <param name="fall_from">
		/// Optional
		/// Fall from pin/port of data to data check
		/// </param>
		/// <param name="rise_to">
		/// Optional
		/// Rise to pin/port of data to data check
		/// </param>
		/// <param name="fall_to">
		/// Optional
		/// Fall to pin/port of data to data check
		/// </param>
		/// <param name="setup">
		/// Optional
		/// Specify data check setup time
		/// </param>
		/// <param name="hold">
		/// Optional
		/// Specify data check hold time
		/// </param>
		/// <param name="clock">
		/// Optional
		/// Specify the clock domain at related pin/port of the checks
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_data_check(string value, string from = null, string to = null, string rise_from = null, string fall_from = null, string rise_to = null, string fall_to = null, bool? setup = null, bool? hold = null, string clock = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_data_check");
			command.OptionalString("from", from);
			command.OptionalString("to", to);
			command.OptionalString("rise_from", rise_from);
			command.OptionalString("fall_from", fall_from);
			command.OptionalString("rise_to", rise_to);
			command.OptionalString("fall_to", fall_to);
			command.Flag("setup", setup);
			command.Flag("hold", hold);
			command.OptionalString("clock", clock);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("value", value);
			_tcl.Add(command);
		}
		/// <summary>
		/// Disable timing arcs
		///
		/// Disables timing arcs within a specified cell or cells that lead to the output pins of the cell. Only
		/// the I/O paths between the clock port and the outputs of the cell are disabled.
		/// The purpose of disabling a timing arc is to prevent timing analysis through the arc.
		/// If a <cell> is specified, then all timing arcs in that cell are disabled. If the optional -from and -to
		/// arguments are specified, then the timing arcs are defined by the from/to pins. If only -from is
		/// speified then all timing arcs from that pin are disabled. If only -to is specified then all timing
		/// paths to that pin are disabled.
		/// If a <port> is specified, then all timing paths from a specified input port are disabled, or timing
		/// paths to a specified output port are disabled.
		/// Note: This command operates silently and does not return direct feedback of its operation
		///
		/// The following example disable the timing arc between the pins I0 and O of the LUT
		/// div_dec_ff_i/U0/count_i_1 to break a combinational loop:
		/// set_disable_timing -from I0 -to O [get_cells div_dec_ff_i/U0/count_i_1]
		/// The following example disables the timing arcs between the specified input pin to the specified
		/// output pin of a BRAM cell:
		/// set_disable_timing -from WEBWE[3] -to CLKMEM [get_cells \
		/// ldpc_dout360_channel/U_AP_FIFO_ldpc_dout360_channel_ram/mem_reg_0]
		/// The following example disables all timing arcs of the specified cell:
		/// set arcs [get_timing_arcs -of_objects [get_cells \
		/// ldpc_dout360_channel/U_AP_FIFO_ldpc_dout360_channel_ram/mem_reg_0]]
		/// set_disable_timing $arcs
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1581
		/// </summary>
		/// <param name="objects">
		/// Required
		/// List of cells or pins, ports, lib-cells, lib-pins, libcell/cell
		/// timing-arcs
		/// </param>
		/// <param name="from">
		/// Optional
		/// From pin on cell
		/// </param>
		/// <param name="to">
		/// Optional
		/// To pin on cell
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_disable_timing(string objects, string from = null, string to = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_disable_timing");
			command.OptionalString("from", from);
			command.OptionalString("to", to);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("objects", objects);
			_tcl.Add(command);
		}
		/// <summary>
		/// Define false path
		///
		/// TIP: The XDC > Timing Constraints language templates and the Timing Constraints Wizard in the Vivado IDE
		/// offer timing diagrams and additional details around defining specific timing constraints. You can refer to these
		/// sources for additional information.
		/// Sets false timing paths in the design that are ignored during timing analysis.
		/// Note: This command operates silently and does not return direct feedback of its operation
		///
		/// The following example eliminates the setup timing for paths from the bftClk:
		/// set_false_path -setup -from bftClk
		/// The following example excludes paths between the two clocks from timing analysis:
		/// set_false_path -from [get_clocks GT0_RXUSRCLK2_OUT] \
		/// -to [get_clocks DRPCLK_OUT]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1585
		/// </summary>
		/// <param name="setup">
		/// Optional
		/// Eliminate setup timing analysis for paths
		/// </param>
		/// <param name="hold">
		/// Optional
		/// Eliminate hold timing analysis for paths
		/// </param>
		/// <param name="rise">
		/// Optional
		/// Eliminate only rising delays for the defined paths
		/// </param>
		/// <param name="fall">
		/// Optional
		/// Eliminate only falling delays for the defined paths
		/// </param>
		/// <param name="reset_path">
		/// Optional
		/// Reset this path before setting false path
		/// </param>
		/// <param name="from">
		/// Optional
		/// List of path startpoints or clocks
		/// </param>
		/// <param name="rise_from">
		/// Optional
		/// Apply to paths rising from the list of startpoints or clocks
		/// </param>
		/// <param name="fall_from">
		/// Optional
		/// Apply to paths falling from the list of startpoints or clocks
		/// </param>
		/// <param name="to">
		/// Optional
		/// List of path endpoints or clocks
		/// </param>
		/// <param name="rise_to">
		/// Optional
		/// Apply to paths with rise transition at the list of endpoints or
		/// clocks
		/// </param>
		/// <param name="fall_to">
		/// Optional
		/// Apply to paths with fall transition at the list of endpoints or
		/// clocks
		/// </param>
		/// <param name="through">
		/// Optional
		/// List of through pins, cells or nets
		/// </param>
		/// <param name="rise_through">
		/// Optional
		/// Apply to paths rising through pins, cells or nets
		/// </param>
		/// <param name="fall_through">
		/// Optional
		/// Apply to paths falling through pins, cells or nets
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_false_path(bool? setup = null, bool? hold = null, bool? rise = null, bool? fall = null, bool? reset_path = null, string from = null, string rise_from = null, string fall_from = null, string to = null, string rise_to = null, string fall_to = null, string through = null, string rise_through = null, string fall_through = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_false_path");
			command.Flag("setup", setup);
			command.Flag("hold", hold);
			command.Flag("rise", rise);
			command.Flag("fall", fall);
			command.Flag("reset_path", reset_path);
			command.OptionalString("from", from);
			command.OptionalString("rise_from", rise_from);
			command.OptionalString("fall_from", fall_from);
			command.OptionalString("to", to);
			command.OptionalString("rise_to", rise_to);
			command.OptionalString("fall_to", fall_to);
			command.OptionalString("through", through);
			command.OptionalString("rise_through", rise_through);
			command.OptionalString("fall_through", fall_through);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			_tcl.Add(command);
		}
		/// <summary>
		/// Set hierarchical separator character
		///
		/// Sets the character that will be used for separating levels of hierarchy in the design.
		/// Note: This command operates silently and does not return direct feedback of its operation
		///
		/// This example changes the hierarchy separator to the '|' character:
		/// set_hierarchy_separator |
		/// The following example restores the default hierarchy separator, '/':
		/// set_hierarchy_separator
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1588
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="separator">
		/// Optional
		/// Hierarchy separator character Default: /
		/// </param>
		public void set_hierarchy_separator(bool? quiet = null, bool? verbose = null, string separator = null)
		{
			var command = new SimpleTCLCommand("set_hierarchy_separator");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("separator", separator);
			_tcl.Add(command);
		}
		/// <summary>
		/// Set input delay on ports
		///
		/// TIP: The XDC > Timing Constraints language templates and the Timing Constraints Wizard in the Vivado IDE
		/// offer timing diagrams and additional details around defining specific timing constraints. You can refer to these
		/// sources for additional information.
		/// Specifies the external system-level path delay on a primary input port relative to a clock edge at
		/// the interface of the design. The input delay value is specified in nanoseconds (ns), and can be
		/// positive or negative, depending on the clock and data relative phase at the interface of the
		/// device.
		/// To accurately model the system-level timing of your Xilinx FPGA design, you must assign timing
		/// delays for objects external to the FPGA onto the primary input or output ports in your design.
		/// These delays are defined by the set_input_delay and set_output_delay commands.
		/// IMPORTANT! If the input port also has a set_max_delay constraint assigned, the specified input delay
		/// value is considered part of the max_delay computation. That is, the input delay consumes a portion of the max
		/// delay on the timing path that includes the input port.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example specifies the input delay on port DIN. The input delay is 3 and is relative
		/// to the rising edge of clock clk1:
		/// set_input_delay -clock clk1 3 DIN
		/// The following example specifies the input delay on port DIN. The input delay is 2 and is relative
		/// to the falling edge of the clock clk1:
		/// set_input_delay -clock_fall -clock clk1 2 DIN
		/// The following example specifies the input delay on port reset. The input delay is 2 and is relative
		/// to the rising edge of the clock that appears on the pin wbClk_IBUF_BUFG_inst/O, originating
		/// from the clock wbClk:
		/// set_input_delay -clock wbClk 2 -reference_pin \
		/// [get_pin wbClk_IBUF_BUFG_inst/O] reset
		/// This example creates a clock named clk_ddr, and defines input delay constraints from data
		/// launched by both rising and falling edges of the clock outside the device to the data input of the
		/// internal flip-flop that is sensitive to both rising and falling clock edges:
		/// create_clock -name clk_ddr -period 6 [get_ports DDR_CLK_IN]
		/// set_input_delay -clock clk_ddr -max 2.1 [get_ports DDR_IN]
		/// set_input_delay -clock clk_ddr -max 1.9 [get_ports DDR_IN] -clock_fall -
		/// add_delay
		/// set_input_delay -clock clk_ddr -min 0.9 [get_ports DDR_IN]
		/// set_input_delay -clock clk_ddr -min 1.1 [get_ports DDR_IN] -clock_fall -
		/// add_delay
		/// Note: The use of the -add_delay option allows the new min and max delay constraints to exist alongside
		/// the first delays on the same port.
		/// The following example specifies the input delay on all non clock input ports of the design.
		/// Although all_inputs returns all ports of the design, including clock ports, set_input_delay will skip
		/// setting input delays on the clock ports. The input delay is 1 relative to the rising edge of the clock
		/// wbClk:
		/// set_input_delay -clock wbClk 1 [all_inputs]
		/// The following example sets an input delay of 4 relative to the rising edge of the clock wbClk on
		/// the ports reset and wbDataForInput:
		/// set_input_delay -clock wbClk 4 [list reset wbDataForInput]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1593
		/// </summary>
		/// <param name="delay">
		/// Required
		/// Delay value
		/// </param>
		/// <param name="objects">
		/// Required
		/// List of ports
		/// </param>
		/// <param name="clock">
		/// Optional
		/// Relative clock
		/// </param>
		/// <param name="reference_pin">
		/// Optional
		/// Relative pin or port
		/// </param>
		/// <param name="clock_fall">
		/// Optional
		/// Delay is relative to falling edge of clock
		/// </param>
		/// <param name="rise">
		/// Optional
		/// Specifies rising delay
		/// </param>
		/// <param name="fall">
		/// Optional
		/// Specifies falling delay
		/// </param>
		/// <param name="max">
		/// Optional
		/// Specifies maximum delay
		/// </param>
		/// <param name="min">
		/// Optional
		/// Specifies minimum delay
		/// </param>
		/// <param name="add_delay">
		/// Optional
		/// Don't remove existing input delay
		/// </param>
		/// <param name="network_latency_included">
		/// Optional
		/// Specifies network latency of clock already included
		/// </param>
		/// <param name="source_latency_included">
		/// Optional
		/// Specifies source latency of clock already included
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_input_delay(string delay, string objects, string clock = null, string reference_pin = null, bool? clock_fall = null, bool? rise = null, bool? fall = null, bool? max = null, bool? min = null, bool? add_delay = null, bool? network_latency_included = null, bool? source_latency_included = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_input_delay");
			command.OptionalString("clock", clock);
			command.OptionalString("reference_pin", reference_pin);
			command.Flag("clock_fall", clock_fall);
			command.Flag("rise", rise);
			command.Flag("fall", fall);
			command.Flag("max", max);
			command.Flag("min", min);
			command.Flag("add_delay", add_delay);
			command.Flag("network_latency_included", network_latency_included);
			command.Flag("source_latency_included", source_latency_included);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("delay", delay);
			command.RequiredString("objects", objects);
			_tcl.Add(command);
		}
		/// <summary>
		/// Set capacitance on ports and nets
		///
		/// Sets the load capacitance on output ports to the specified value. The load capacitance is used
		/// during power analysis when running the report_power command, but is not used during
		/// timing analysis.
		/// TIP: The default unit of capacitance is picofarads (pF), but can be changed using the set_units command.
		/// This command operates silently and does not return direct feedback of its operation.
		///
		/// The following example sets the specified load capacitance value for all ports:
		/// set_load 5.5 [all_outputs]
		/// The following example sets the rising and falling edge load capacitance for the specified output
		/// ports:
		/// set_load -rise -fall 8 [get_ports wbOutput*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1600
		/// </summary>
		/// <param name="capacitance">
		/// Required
		/// Capacitance value
		/// </param>
		/// <param name="objects">
		/// Required
		/// List of ports or nets
		/// </param>
		/// <param name="rise">
		/// Optional
		/// Specify the rise capacitance value (for ports only)
		/// </param>
		/// <param name="fall">
		/// Optional
		/// Specify the fall capacitance value (for ports only)
		/// </param>
		/// <param name="max">
		/// Optional
		/// Specify the maximum capacitance value
		/// </param>
		/// <param name="min">
		/// Optional
		/// Specify the minimum capacitance value
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_load(string capacitance, string objects, bool? rise = null, bool? fall = null, bool? max = null, bool? min = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_load");
			command.Flag("rise", rise);
			command.Flag("fall", fall);
			command.Flag("max", max);
			command.Flag("min", min);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("capacitance", capacitance);
			command.RequiredString("objects", objects);
			_tcl.Add(command);
		}
		/// <summary>
		/// Sets logic dc for port/pins
		///
		/// Sets the specified input ports or input pins to a logic value of 'X', as unknown or don't care. This
		/// command is NOT supported in Synthesis.
		/// Note: This command operates silently and does not return direct feedback of its operation.
		///
		/// The following example sets the specified port to 'X':
		/// set_logic_dc [get_ports reset]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1602
		/// </summary>
		/// <param name="objects">
		/// Required
		/// List of ports or pins
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_logic_dc(string objects, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_logic_dc");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("objects", objects);
			_tcl.Add(command);
		}
		/// <summary>
		/// Sets logic one for port/pins
		///
		/// Sets the specified input ports or input pins to a logic one. This command is NOT supported in
		/// Synthesis.
		/// Note: This command operates silently and does not return direct feedback of its operation.
		///
		/// The following example sets the specified input port to a logic one:
		/// set_logic_one [get_ports reset]
		/// The following example sets the input ports reset and wbDataForInput to a logic one:
		/// set_logic_one [list [get_ports reset] [get_ports wbDataForInput]]
		/// The following example sets the input pin I on instance reset_IBUF to a logic one:
		/// set_logic_one [get_pins reset_IBUF_inst/I]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1604
		/// </summary>
		/// <param name="objects">
		/// Required
		/// List of ports or pins
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_logic_one(string objects, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_logic_one");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("objects", objects);
			_tcl.Add(command);
		}
		/// <summary>
		/// Sets logic zero for port/pins
		///
		/// Sets the specified input ports and input pins to a logic zero. This command is NOT supported in
		/// Synthesis.
		/// Note: This command operates silently and does not return direct feedback of its operation.
		///
		/// The following example sets the specified port to logic state 0:
		/// set_logic_zero [get_ports reset]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1608
		/// </summary>
		/// <param name="objects">
		/// Required
		/// List of ports or pins
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_logic_zero(string objects, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_logic_zero");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("objects", objects);
			_tcl.Add(command);
		}
		/// <summary>
		/// Specify maximum delay for timing paths
		///
		/// TIP: The XDC > Timing Constraints language templates and the Timing Constraints Wizard in the Vivado IDE
		/// offer timing diagrams and additional details around defining specific timing constraints. You can refer to these
		/// sources for additional information.
		/// Sets the maximum delay allowed on a timing path, specified in nanoseconds (ns). The specified
		/// delay value is assigned to both the rising and falling edges of the defined timing paths unless the
		/// -rise or -fall arguments are specified.
		/// The maximum rising and falling delay cannot be less than the minimum rising and falling delay on
		/// the same path, as defined by the set_min_delay command. If this happens, the first assigned
		/// constraint is removed from the timing path as a conflict, and the delay value specified by the
		/// removed constraint is set to 0.
		/// The delay value must be assigned to a timing path as defined by at least one -from, -through,
		/// or -to argument. A general path delay such as -to endpoint will be over written by a more
		/// specific path definition such as -from/-to, or -from/-through/-to path definition.
		/// IMPORTANT! When assigned to a primary input or output port, any system-level delay consumes a portion of
		/// the max delay on the timing path that includes the input or output port. That is, the delay specified by
		/// set_input_delay or set_output_delay is considered part of the maximum delay.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example defines a maximum delay of 60 ns between all the input and output ports
		/// (feedthrough paths):
		/// set_max_delay 60 -from [all_inputs] -to [all_outputs]
		/// The following example clears the existing max delay and specifies a new > maximum delay for
		/// paths to endpoints clocked by the specified clock:
		/// set_max_delay -reset_path 50 -to [get_clocks spi_clk]
		/// The set_max_delay command is often used to define timing constraints for crossing clock
		/// domains when a simple synchronizer is used. In the following example, two flops (FF1 and FF2)
		/// are clocked by different clocks, and FF1/C connects directly to FF2/D through net1. To limit the
		/// delay on this connection to 4.0 ns use one of the following constraints:
		/// set_max_delay -from FF1 -to FF2 -datapath_only 4.0
		/// set_max_delay -from FF1/C -to FF2/D -datapath_only 4.0
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1610
		/// </summary>
		/// <param name="delay">
		/// Required
		/// Delay value
		/// </param>
		/// <param name="rise">
		/// Optional
		/// Delay value applies to rising path delays
		/// </param>
		/// <param name="fall">
		/// Optional
		/// Delay value applies to falling path delays
		/// </param>
		/// <param name="reset_path">
		/// Optional
		/// Reset this path before setting max delay
		/// </param>
		/// <param name="from">
		/// Optional
		/// List of path startpoints or clocks
		/// </param>
		/// <param name="rise_from">
		/// Optional
		/// Apply to paths rising from the list of startpoints or clocks
		/// </param>
		/// <param name="fall_from">
		/// Optional
		/// Apply to paths falling from the list of startpoints or clocks
		/// </param>
		/// <param name="to">
		/// Optional
		/// List of path endpoints or clocks
		/// </param>
		/// <param name="rise_to">
		/// Optional
		/// Apply to paths with rise transition at the list of endpoints or
		/// clocks
		/// </param>
		/// <param name="fall_to">
		/// Optional
		/// Apply to paths with fall transition at the list of endpoints or
		/// clocks
		/// </param>
		/// <param name="through">
		/// Optional
		/// List of through pins, cells or nets
		/// </param>
		/// <param name="rise_through">
		/// Optional
		/// Apply to paths rising through pins, cells or nets
		/// </param>
		/// <param name="fall_through">
		/// Optional
		/// Apply to paths falling through pins, cells or nets
		/// </param>
		/// <param name="datapath_only">
		/// Optional
		/// Remove clock skew and jitter from calculation
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_max_delay(string delay, bool? rise = null, bool? fall = null, bool? reset_path = null, string from = null, string rise_from = null, string fall_from = null, string to = null, string rise_to = null, string fall_to = null, string through = null, string rise_through = null, string fall_through = null, bool? datapath_only = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_max_delay");
			command.Flag("rise", rise);
			command.Flag("fall", fall);
			command.Flag("reset_path", reset_path);
			command.OptionalString("from", from);
			command.OptionalString("rise_from", rise_from);
			command.OptionalString("fall_from", fall_from);
			command.OptionalString("to", to);
			command.OptionalString("rise_to", rise_to);
			command.OptionalString("fall_to", fall_to);
			command.OptionalString("through", through);
			command.OptionalString("rise_through", rise_through);
			command.OptionalString("fall_through", fall_through);
			command.Flag("datapath_only", datapath_only);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("delay", delay);
			_tcl.Add(command);
		}
		/// <summary>
		/// Limit time borrowing for latches
		///
		/// Sets the maximum amount of time in nanoseconds that can be borrowed between nets when
		/// analyzing the timing on latches.
		/// Note: This command operates silently and does not return direct feedback of its operation.
		///
		/// The following example specifies that the latches attached to "all clocks" will be allowed 0 time
		/// units of borrowing. Effectively, this disables time borrowing throughout the entire design.
		/// set_max_time_borrow 0.0 [all_clocks]
		/// The following example specifies that nets in the top level of hierarchy are allowed 20 time units
		/// of time borrowing:
		/// set_max_time_borrow 20 {top/*}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1614
		/// </summary>
		/// <param name="delay">
		/// Required
		/// Delay value: Value >= 0
		/// </param>
		/// <param name="objects">
		/// Required
		/// List of clocks, cells, data pins or clock pins
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_max_time_borrow(string delay, string objects, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_max_time_borrow");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("delay", delay);
			command.RequiredString("objects", objects);
			_tcl.Add(command);
		}
		/// <summary>
		/// Specify minimum delay for timing paths
		///
		/// Sets the minimum delay allowed on a timing path, specified in nanoseconds (ns). The specified
		/// delay value is assigned to both the rising and falling edges of the defined timing paths unless the
		/// -rise or -fall arguments are specified.
		/// IMPORTANT! The minimum rising and falling delay cannot be greater than the maximum rising and falling
		/// delay on the same path. If this happens, the first assigned delay value is removed from the timing path and reset
		/// to 0.
		/// The delay value must be assigned to a timing path as defined by at least one -from, -through,
		/// or -to argument. A general path delay such as -to endpoint will be over written by a more
		/// specific path definition such as -from/-to, or -from/-through/-to path definition.
		/// This command operates silently and does not return direct feedback of its operation.
		///
		/// The following example specifies a minimum delay of 20ns between the primary input and output
		/// ports (combinational/feedthrough paths):
		/// set_min_delay 20 -from [all_inputs] -to [all_outputs]
		/// The following example defines a minimum delay of 20ns for timing paths with endpoints at all
		/// primary output ports:
		/// set_min_delay 20 -to [get_ports -filter {DIRECTION == out}]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1616
		/// </summary>
		/// <param name="delay">
		/// Required
		/// Delay value
		/// </param>
		/// <param name="rise">
		/// Optional
		/// Delay value applies to rising path delays
		/// </param>
		/// <param name="fall">
		/// Optional
		/// Delay value applies to falling path delays
		/// </param>
		/// <param name="reset_path">
		/// Optional
		/// Reset this path before setting min delay
		/// </param>
		/// <param name="from">
		/// Optional
		/// List of path startpoints or clocks
		/// </param>
		/// <param name="rise_from">
		/// Optional
		/// Apply to paths rising from the list of startpoints or clocks
		/// </param>
		/// <param name="fall_from">
		/// Optional
		/// Apply to paths falling from the list of startpoints or clocks
		/// </param>
		/// <param name="to">
		/// Optional
		/// List of path endpoints or clocks
		/// </param>
		/// <param name="rise_to">
		/// Optional
		/// Apply to paths with rise transition at the list of endpoints or
		/// clocks
		/// </param>
		/// <param name="fall_to">
		/// Optional
		/// Apply to paths with fall transition at the list of endpoints or
		/// clocks
		/// </param>
		/// <param name="through">
		/// Optional
		/// List of through pins, cells or nets
		/// </param>
		/// <param name="rise_through">
		/// Optional
		/// Apply to paths rising through pins, cells or nets
		/// </param>
		/// <param name="fall_through">
		/// Optional
		/// Apply to paths falling through pins, cells or nets
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_min_delay(string delay, bool? rise = null, bool? fall = null, bool? reset_path = null, string from = null, string rise_from = null, string fall_from = null, string to = null, string rise_to = null, string fall_to = null, string through = null, string rise_through = null, string fall_through = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_min_delay");
			command.Flag("rise", rise);
			command.Flag("fall", fall);
			command.Flag("reset_path", reset_path);
			command.OptionalString("from", from);
			command.OptionalString("rise_from", rise_from);
			command.OptionalString("fall_from", fall_from);
			command.OptionalString("to", to);
			command.OptionalString("rise_to", rise_to);
			command.OptionalString("fall_to", fall_to);
			command.OptionalString("through", through);
			command.OptionalString("rise_through", rise_through);
			command.OptionalString("fall_through", fall_through);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("delay", delay);
			_tcl.Add(command);
		}
		/// <summary>
		/// Define multicycle path
		///
		/// By default, the Vivado timing engine performs a single-cycle analysis, in which the setup check is
		/// performed at the destination on the capture edge, one clock cycle after the edge of the source
		/// clock. However, this may not be appropriate for certain timing paths. The most common example
		/// is a logic path that requires more than one clock cycle for the data to stabilize at the endpoint.
		/// The set_multicycle_path command lets you choose a path multiplier, N, to establish a
		/// timing path that takes N clock cycles from the start clock edge to the capture clock edge. The
		/// path multiplier defines the total number of clock cycles required for propagation of a signal from
		/// its origin to destination when that propagation is longer than a single clock cycle. For more
		/// information on the use of this command, refer to the Vivado Design Suite User Guide: Using
		/// Constraints (UG903).
		/// The set_multicycle_path command is used to specify path multipliers for setup and hold
		/// analysis, for rising and/or falling edges, with respect to the source clock or the destination clock.
		/// This command includes three elements:
		/// • The specification of the setup and hold analysis affected by the multicycle path.
		/// • The definition of the timing paths to which the multicycle path applies.
		/// • The path multiplier defining the number of clock cycles to apply to the timing analysis.
		/// By default the path multiplier applies to both the setup and hold analysis. The hold analysis is
		/// derived from the setup analysis, so it is moved along with the setup analysis. If the path multiplier
		/// moves the setup check N clock cycles, it moves the hold check N-1 clock cycles. However, this
		/// often results in hold timing failures.
		/// You can use a second set_multicycle_path command with the -hold option to restore the
		/// hold analysis to its original location. When the -hold option is specified the <path_multiplier>
		/// acts on the hold relationship to restore the hold check to its original position. For instance, the
		/// following command sequence extends the setup check for 3 clock cycles, and consequently
		/// extends the hold check by two clock cycles (N-1). The second command restores the hold check
		/// to its original position:
		/// set_multicycle_path 3 -from {usbEngine1/u4/csr_reg[26]/C} \
		/// -to {usbEngine1/u1/u2/sizd_c_reg[12]/D}
		/// set_multicycle_path 2 -from {usbEngine1/u4/csr_reg[26]/C} \
		/// -to {usbEngine1/u1/u2/sizd_c_reg[12]/D} -hold
		/// By default, the setup path multiplier is applied with respect to the destination clock, and the hold
		/// path multiplier is applied with respect to the source clock. Use the -start or -end options to
		/// change the default setup or hold analysis with respect to the source or destination clocks.
		/// This command operates silently when successful, or returns an error if the command fails.
		///
		/// The following example establishes a path multiplier of 3 clock cycles for the setup check of the
		/// timing path defined by the -from/-to options. A path multiplier of N-1, or 2 in this example, is
		/// used to decrement the hold check on the same timing path:
		/// set_multicycle_path 3 -setup -from [get_pins data0_reg/C] \
		/// -to [get_pins data1_reg/D]
		/// set_multicycle_path 2 -hold -from [get_pins data0_reg/C] \
		/// -to [get_pins data1_reg/D]
		/// Note: For more information on the relationship between the setup and hold analysis refer to the Vivado
		/// Design Suite User Guide: Using Constraints (UG903).
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1625
		/// </summary>
		/// <param name="path_multiplier">
		/// Required
		/// Number of cycles
		/// </param>
		/// <param name="setup">
		/// Optional
		/// Only setup multiplier is set
		/// </param>
		/// <param name="hold">
		/// Optional
		/// Only hold multiplier is set
		/// </param>
		/// <param name="rise">
		/// Optional
		/// Multiplier valid for rising delays on path endpoint
		/// </param>
		/// <param name="fall">
		/// Optional
		/// Multiplier valid for falling delays on path endpoint
		/// </param>
		/// <param name="start">
		/// Optional
		/// Multiplier measured against path startpoint
		/// </param>
		/// <param name="end">
		/// Optional
		/// Multiplier measured against path endpoint
		/// </param>
		/// <param name="reset_path">
		/// Optional
		/// Reset this path before setting multicycle
		/// </param>
		/// <param name="from">
		/// Optional
		/// List of path startpoints or clocks
		/// </param>
		/// <param name="rise_from">
		/// Optional
		/// Apply to paths rising from the list of startpoints or clocks
		/// </param>
		/// <param name="fall_from">
		/// Optional
		/// Apply to paths falling from the list of startpoints or clocks
		/// </param>
		/// <param name="to">
		/// Optional
		/// List of path endpoints or clocks
		/// </param>
		/// <param name="rise_to">
		/// Optional
		/// Apply to paths with rise transition at the list of endpoints or
		/// clocks
		/// </param>
		/// <param name="fall_to">
		/// Optional
		/// Apply to paths with fall transition at the list of endpoints or
		/// clocks
		/// </param>
		/// <param name="through">
		/// Optional
		/// List of through pins, cells or nets
		/// </param>
		/// <param name="rise_through">
		/// Optional
		/// Apply to paths rising through pins, cells or nets
		/// </param>
		/// <param name="fall_through">
		/// Optional
		/// Apply to paths falling through pins, cells or nets
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_multicycle_path(string path_multiplier, bool? setup = null, bool? hold = null, bool? rise = null, bool? fall = null, bool? start = null, bool? end = null, bool? reset_path = null, string from = null, string rise_from = null, string fall_from = null, string to = null, string rise_to = null, string fall_to = null, string through = null, string rise_through = null, string fall_through = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_multicycle_path");
			command.Flag("setup", setup);
			command.Flag("hold", hold);
			command.Flag("rise", rise);
			command.Flag("fall", fall);
			command.Flag("start", start);
			command.Flag("end", end);
			command.Flag("reset_path", reset_path);
			command.OptionalString("from", from);
			command.OptionalString("rise_from", rise_from);
			command.OptionalString("fall_from", fall_from);
			command.OptionalString("to", to);
			command.OptionalString("rise_to", rise_to);
			command.OptionalString("fall_to", fall_to);
			command.OptionalString("through", through);
			command.OptionalString("rise_through", rise_through);
			command.OptionalString("fall_through", fall_through);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("path_multiplier", path_multiplier);
			_tcl.Add(command);
		}
		/// <summary>
		/// Set operating conditions for power estimation
		///
		/// Sets the real-world operating conditions that are used when performing analysis of the design.
		/// The environmental operating conditions of the device are used for power analysis when running
		/// the report_power command.
		/// Note: This command operates silently and does not return direct feedback of its operation.
		/// Operating conditions can be restored to their default values with the use of the
		/// reset_operating_conditions command.
		/// Current operating conditions can be reported with the report_operating_conditions
		/// command.
		///
		/// The following example specifies an industrial grade device with an ambient operating
		/// temperature of 75 degrees C:
		/// set_operating_conditions -grade industrial -ambient_temp 75
		/// The following example sets the supply voltage Vccaux to a value of 1.9:
		/// set_operating_conditions -voltage {Vccaux 1.89}
		/// The following example sets the manufacturing process corner to maximum:
		/// set_operating_conditions -process maximum
		/// The following example sets the manufacturing process corner to maximum and the voltage
		/// supply Vccint to 0.875:
		/// set_operating_conditions -process maximum -voltage {Vccint 0.875}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1630
		/// </summary>
		/// <param name="voltage">
		/// Optional
		/// List of voltage pairs, e.g., {name value}. Supported voltage
		/// supplies vary by family.
		/// </param>
		/// <param name="grade">
		/// Optional
		/// Temperature grade. Supported values vary by family.
		/// Default: commercial
		/// </param>
		/// <param name="process">
		/// Optional
		/// Process data: typical or maximum Default: typical
		/// </param>
		/// <param name="junction_temp">
		/// Optional
		/// Junction Temperature (C): auto|degC Default: auto
		/// </param>
		/// <param name="ambient_temp">
		/// Optional
		/// Ambient Temperature (C): default|degC Default: default
		/// </param>
		/// <param name="thetaja">
		/// Optional
		/// ThetaJA (C/W): auto|degC/W Default: auto
		/// </param>
		/// <param name="thetasa">
		/// Optional
		/// ThetaSA (C/W): auto|degC/W Default: auto
		/// </param>
		/// <param name="airflow">
		/// Optional
		/// Airflow (LFM): 0 to 750 Default: varies by family
		/// </param>
		/// <param name="heatsink">
		/// Optional
		/// Dimensions of heatsink: none, low, medium, high, custom
		/// Default: medium
		/// </param>
		/// <param name="thetajb">
		/// Optional
		/// ThetaJB (C/W): auto|degC/W Default: auto
		/// </param>
		/// <param name="board">
		/// Optional
		/// Board type: jedec, small, medium, large, custom Default:
		/// medium
		/// </param>
		/// <param name="board_temp">
		/// Optional
		/// Board Temperature degC
		/// </param>
		/// <param name="board_layers">
		/// Optional
		/// Board layers: 4to7, 8to11, 12to15, 16+ Default: 8to11
		/// </param>
		/// <param name="design_power_budget">
		/// Optional
		/// Design Power Budget (W) Default: Unspecified
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_operating_conditions(string voltage = null, string grade = null, string process = null, string junction_temp = null, string ambient_temp = null, string thetaja = null, string thetasa = null, string airflow = null, string heatsink = null, string thetajb = null, string board = null, string board_temp = null, string board_layers = null, string design_power_budget = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_operating_conditions");
			command.OptionalString("voltage", voltage);
			command.OptionalString("grade", grade);
			command.OptionalString("process", process);
			command.OptionalString("junction_temp", junction_temp);
			command.OptionalString("ambient_temp", ambient_temp);
			command.OptionalString("thetaja", thetaja);
			command.OptionalString("thetasa", thetasa);
			command.OptionalString("airflow", airflow);
			command.OptionalString("heatsink", heatsink);
			command.OptionalString("thetajb", thetajb);
			command.OptionalString("board", board);
			command.OptionalString("board_temp", board_temp);
			command.OptionalString("board_layers", board_layers);
			command.OptionalString("design_power_budget", design_power_budget);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			_tcl.Add(command);
		}
		/// <summary>
		/// Set output delay on ports
		///
		/// TIP: The XDC > Timing Constraints language templates and the Timing Constraints Wizard in the Vivado IDE
		/// offer timing diagrams and additional details around defining specific timing constraints. You can refer to these
		/// sources for additional information.
		/// Specifies the external system-level path delay on a primary output port relative to a clock edge at
		/// the interface of the design. The output delay value is specified in nanoseconds (ns), and can be
		/// positive or negative, depending on the clock and data relative phase outside the FPGA device.
		/// To accurately model the system-level timing of your Xilinx FPGA design, you must assign timing
		/// delays for objects external to the FPGA onto the primary input or output ports in your design.
		/// These delays are defined by the set_input_delay and set_output_delay commands.
		/// IMPORTANT! If the output port also has a set_max_delay constraint assigned, the specified output delay
		/// value is considered part of the max_delay computation. That is, the output delay consumes a portion of the max
		/// delay on the timing path that includes the output port.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example sets an output delay on ports relative to the specified clock:
		/// set_output_delay 5.0 -clock [get_clocks cpuClk] [get_ports]
		/// The next example is the same as the prior example except that network latency is now included:
		/// set_output_delay 5.0 -clock [get_clocks cpuClk] \
		/// -network_latency_included [get_ports]
		/// This example creates a clock named clk_ddr, and defines output delay constraints from data
		/// launched by both rising and falling edges of the clock outside the device to the data output of
		/// the internal flip-flop that is sensitive to both rising and falling clock edges:
		/// create_clock -name clk_ddr -period 6 [get_ports DDR_CLK_IN]
		/// set_output_delay -clock clk_ddr -max 2.1 [get_ports DDR_OUT]
		/// set_output_delay -clock clk_ddr -max 1.9 [get_ports DDR_OUT] -clock_fall -
		/// add_delay
		/// set_output_delay -clock clk_ddr -min 0.9 [get_ports DDR_OUT]
		/// set_output_delay -clock clk_ddr -min 1.1 [get_ports DDR_OUT] -clock_fall -
		/// add_delay
		/// Note: The use of the -add_delay option allows the new min and max delay constraints to exist alongside
		/// the first delays on the same port.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1634
		/// </summary>
		/// <param name="delay">
		/// Required
		/// Delay value
		/// </param>
		/// <param name="objects">
		/// Required
		/// List of ports
		/// </param>
		/// <param name="clock">
		/// Optional
		/// Relative clock
		/// </param>
		/// <param name="reference_pin">
		/// Optional
		/// Relative pin or port
		/// </param>
		/// <param name="clock_fall">
		/// Optional
		/// Delay is relative to falling edge of clock
		/// </param>
		/// <param name="rise">
		/// Optional
		/// Specifies rising delay
		/// </param>
		/// <param name="fall">
		/// Optional
		/// Specifies falling delay
		/// </param>
		/// <param name="max">
		/// Optional
		/// Specifies maximum delay
		/// </param>
		/// <param name="min">
		/// Optional
		/// Specifies minimum delay
		/// </param>
		/// <param name="add_delay">
		/// Optional
		/// Don't remove existing input delay
		/// </param>
		/// <param name="network_latency_included">
		/// Optional
		/// Specifies network latency of clock already included
		/// </param>
		/// <param name="source_latency_included">
		/// Optional
		/// Specifies source latency of clock already included
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_output_delay(string delay, string objects, string clock = null, string reference_pin = null, bool? clock_fall = null, bool? rise = null, bool? fall = null, bool? max = null, bool? min = null, bool? add_delay = null, bool? network_latency_included = null, bool? source_latency_included = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_output_delay");
			command.OptionalString("clock", clock);
			command.OptionalString("reference_pin", reference_pin);
			command.Flag("clock_fall", clock_fall);
			command.Flag("rise", rise);
			command.Flag("fall", fall);
			command.Flag("max", max);
			command.Flag("min", min);
			command.Flag("add_delay", add_delay);
			command.Flag("network_latency_included", network_latency_included);
			command.Flag("source_latency_included", source_latency_included);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("delay", delay);
			command.RequiredString("objects", objects);
			_tcl.Add(command);
		}
		/// <summary>
		/// Specify propagated clock latency
		///
		/// Propagates clock latency throughout a clock network, resulting in more accurate skew and timing
		/// results throughout the clock network.
		/// Note: This command operates silently and does not return direct feedback of its operation.
		///
		/// This example specifies that the primary system clock from the top-level should be propagated:
		/// set_propagated_clock [get_clocks top/clk]
		/// This example specifies that all clocks from "sublevel1" should be propagated:
		/// set_propagated_clock [get_clocks sublevel1/*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1647
		/// </summary>
		/// <param name="objects">
		/// Required
		/// List of clocks, ports, or pins
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_propagated_clock(string objects, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_propagated_clock");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("objects", objects);
			_tcl.Add(command);
		}
		/// <summary>
		/// Set units for checking
		///
		/// This command specifies the default units to be assumed when the design is analyzed. Specifically,
		/// the -current, -voltage, -power, and -resistance options impact the values returned by
		/// the report_power command.
		/// The set_units command can be used multiple times to define and redefine units. If
		/// set_units includes a previously set unit value, the unit is redefined.
		/// Note: This command operates silently and does not return direct feedback of its operation.
		///
		/// Specify that voltage should be in millivolts and all values should use three digits
		/// set_units -voltage mV
		/// The following example changes the default unit for current to Amperes:
		/// set_units -voltage kV -current A
		/// Note: The second example of set_units redefines the Voltage units defined in the first example, as well
		/// as defining the units for current.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1663
		/// </summary>
		/// <param name="capacitance">
		/// Optional
		/// Capacitance unit in farad. Valid values are from kF-fF.
		/// Default: pF
		/// </param>
		/// <param name="current">
		/// Optional
		/// Current unit in ampere. Valid values are from kA-fA. Default:
		/// mA
		/// </param>
		/// <param name="voltage">
		/// Optional
		/// Voltage unit in volt. Valid values are from kV-fV. Default: V
		/// </param>
		/// <param name="power">
		/// Optional
		/// Wattage unit in watts. Valid values are from kW-fW. Default:
		/// mW
		/// </param>
		/// <param name="resistance">
		/// Optional
		/// Resistance unit in ohm. Valid values are from kOhm-fOhm.
		/// Default: ohm
		/// </param>
		/// <param name="altitude">
		/// Optional
		/// Altitude in metric or standard units. Valid values are meters
		/// and feet. Default: meters
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_units(string capacitance = null, string current = null, string voltage = null, string power = null, string resistance = null, string altitude = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_units");
			command.OptionalString("capacitance", capacitance);
			command.OptionalString("current", current);
			command.OptionalString("voltage", voltage);
			command.OptionalString("power", power);
			command.OptionalString("resistance", resistance);
			command.OptionalString("altitude", altitude);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			_tcl.Add(command);
		}
	}
}
