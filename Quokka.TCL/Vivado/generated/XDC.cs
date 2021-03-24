// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class XDCCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public XDCCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// Add cells to a Pblock
		///
		///
		/// TCL Syntax: add_cells_to_pblock [-top] [-add_primitives] [-clear_locs] [-quiet] [-verbose] <pblock> [<cells>...]
		///
		/// Adds specified logic instances to a Pblock in an open implemented design. Once cells have been
		/// added to a Pblock, you can place the Pblocks onto the fabric of the FPGA using the
		/// resize_pblock command. The resize_pblock command can also be used to manually
		/// move and resize Pblocks.
		/// You can remove instances from the Pblock using the remove_cells_from_pblock command.
		///
		/// The following example creates a Pblock called pb_cpuEngine, and then adds only the leaf-cells
		/// found in the cpuEngine module, clearing placement constraints for placed instances:
		/// create_pblock pb_cpuEngine
		/// add_cells_to_pblock pb_cpuEngine [get_cells cpuEngine/*] \
		/// -add_primitives -clear_locs
		///
		/// See ug835-vivado-tcl-commands.pdf, page 35
		/// </summary>
		/// <param name="pblock">(Required) Pblock to add cells to</param>
		/// <param name="top">
		/// (Optional)
		/// Add the top level instance; This option can't be used with -
		/// cells, or -add_primitives options. You must specify either -
		/// cells or -top option.
		/// </param>
		/// <param name="add_primitives">
		/// (Optional)
		/// Assign to the pblock only primitive cells from the specified
		/// list of cells.
		/// </param>
		/// <param name="clear_locs">(Optional) Clear instance location constraints</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="cells">
		/// (Optional)
		/// Cells to add. You can't use this option with -top option. You
		/// must specify either -cells or -top option.
		/// </param>
		public TTCL add_cells_to_pblock(string pblock, bool? top = null, bool? add_primitives = null, bool? clear_locs = null, bool? quiet = null, bool? verbose = null, string cells = null)
		{
			// TCL Syntax: add_cells_to_pblock [-top] [-add_primitives] [-clear_locs] [-quiet] [-verbose] <pblock> [<cells>...]
			_tcl.Entry(_builder.add_cells_to_pblock(pblock, top, add_primitives, clear_locs, quiet, verbose, cells));
			return _tcl;
		}
		/// <summary>
		/// Add power sources to power Rail
		///
		///
		/// TCL Syntax: add_to_power_rail [-power_sources <args>] [-quiet] [-verbose] <power_rail>
		///
		/// See ug835-vivado-tcl-commands.pdf, page 59
		/// </summary>
		/// <param name="power_rail">(Required) Power rail to add sources to</param>
		/// <param name="power_sources">(Optional) List of power_sources to add. Can be power rails and/or power supplies</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL add_to_power_rail(string power_rail, string power_sources = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: add_to_power_rail [-power_sources <args>] [-quiet] [-verbose] <power_rail>
			_tcl.Entry(_builder.add_to_power_rail(power_rail, power_sources, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of all clocks in the current design
		///
		///
		/// TCL Syntax: all_clocks [-quiet] [-verbose]
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
		/// See ug835-vivado-tcl-commands.pdf, page 72
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of clock objects</returns>
		public TTCL all_clocks(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: all_clocks [-quiet] [-verbose]
			_tcl.Entry(_builder.all_clocks(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of cpu cells in the current design
		///
		///
		/// TCL Syntax: all_cpus [-quiet] [-verbose]
		///
		/// Returns a list of all CPU cell objects in the current design. Creates a list of all the CPU cell objects
		/// that have been declared in the current design.
		/// The list of CPUs returned by all_cpus can also be limited or reduced by the filter command
		/// to filter according to properties assigned to the CPU cell objects. Properties of an object can be
		/// returned by the list_property or report_property commands.
		/// The all_cpus command is scoped to return the objects hierarchically, from the top-level of the
		/// design or from the level of the current instance. By default the current instance is defined as the
		/// top level of the design, but can be changed by using the current_instance command.
		/// Note: This command returns a list of CPU cell objects
		///
		/// The following example returns all CPU objects in the current design:
		/// all_cpus
		/// The following example shows how the list returned can be passed to another command:
		/// set_false_path -from [all_cpus] -to [all_registers]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 74
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of cpu cell objects</returns>
		public TTCL all_cpus(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: all_cpus [-quiet] [-verbose]
			_tcl.Entry(_builder.all_cpus(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of dsp cells in the current design
		///
		///
		/// TCL Syntax: all_dsps [-quiet] [-verbose]
		///
		/// Returns a list of all DSP cell objects that have been declared in the current design.
		/// The list of DSPs returned by all_dsps can also be limited or reduced by the filter command
		/// to filter according to properties assigned to the DSP objects. Properties of an object can be
		/// returned by the list_property or report_property commands.
		/// The all_dsps command is scoped to return the objects hierarchically, from the top-level of the
		/// design or from the level of the current instance. By default the current instance is defined as the
		/// top level of the design, but can be changed by using the current_instance command.
		///
		/// The following example returns a list of all DSPs defined in the current design, and filters that list
		/// to return a single DSP assigned to the specified SITE:
		/// filter [all_dsps] {SITE == DSP48_X1Y6}
		/// The following example shows how the list returned can be passed to another command:
		/// set_false_path -from [all_dsps] -to [all_registers]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 76
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of dsp cell objects</returns>
		public TTCL all_dsps(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: all_dsps [-quiet] [-verbose]
			_tcl.Entry(_builder.all_dsps(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of pins or cells in fanin of specified sinks
		///
		///
		/// TCL Syntax: all_fanin [-startpoints_only] [-flat] [-only_cells] [-levels <arg>] [-pin_levels <arg>] [-trace_arcs <arg>] [-quiet] [-verbose] <to>
		///
		/// Returns a list of port, pin or cell objects in the fan-in of the specified sinks.
		/// The all_fanin command is scoped to return objects from current level of the hierarchy of the
		/// design, either from the top-level or from the level of the current instance. By default the current
		/// instance is defined as the top level of the design, but can be changed by using the
		/// current_instance command. To return the fan-in across all levels of the hierarchy, use the -
		/// flat option.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example lists the timing fan-in of the led_pins output port:
		/// all_fanin [get_ports led_pins[*] ]
		/// The following example traces back from the clock pin of the specified flip- flop to the clock
		/// source (an MMCM output pin in this example):
		/// all_fanin -flat -startpoints_only [get_pins cmd_parse_i0/prescale_reg[7]/C]
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The following examples returns the ports connected to the input pins of IDELAYs, ignoring the
		/// hierarchy of the design:
		/// all_fanin -flat -startpoints_only [get_pins IDELAY*/IDATAIN]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 78
		/// </summary>
		/// <param name="to">(Required) List of sink pins, ports, or nets</param>
		/// <param name="startpoints_only">(Optional) Find only the timing startpoints</param>
		/// <param name="flat">(Optional) Hierarchy is ignored</param>
		/// <param name="only_cells">(Optional) Only cells</param>
		/// <param name="levels">(Optional) Maximum number of cell levels to traverse:Value >= 0 Default: 0</param>
		/// <param name="pin_levels">(Optional) Maximum number of pin levels to traverse:Value >= 0 Default: 0</param>
		/// <param name="trace_arcs">(Optional) Type of network arcs to trace: Values: timing, enabled, all</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of cell or pin objects</returns>
		public TTCL all_fanin(string to, bool? startpoints_only = null, bool? flat = null, bool? only_cells = null, string levels = null, string pin_levels = null, string trace_arcs = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: all_fanin [-startpoints_only] [-flat] [-only_cells] [-levels <arg>] [-pin_levels <arg>] [-trace_arcs <arg>] [-quiet] [-verbose] <to>
			_tcl.Entry(_builder.all_fanin(to, startpoints_only, flat, only_cells, levels, pin_levels, trace_arcs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of pins or cells in fanout of specified sources
		///
		///
		/// TCL Syntax: all_fanout [-endpoints_only] [-flat] [-only_cells] [-levels <arg>] [-pin_levels <arg>] [-trace_arcs <arg>] [-quiet] [-verbose] <from>
		///
		/// Returns a list of port, pin, or cell objects in the fanout of the specified sources.
		/// The all_fanout command is scoped to return objects from current level of the hierarchy of the
		/// design, either from the top-level or from the level of the current instance. By default the current
		/// instance is defined as the top level of the design, but can be changed by using the
		/// current_instance command. To return the fanout across all levels of the hierarchy, use the -
		/// flat option.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example gets the fanout for all input ports in the design:
		/// all_fanout [all_inputs]
		/// This example gets the fanout for all inputs assigned to I/O Bank 15 in the current design:
		/// all_fanout [filter [all_inputs] {IOBANK == 15}]
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 81
		/// </summary>
		/// <param name="from">(Required) List of source pins, ports, or nets</param>
		/// <param name="endpoints_only">(Optional) Find only the timing endpoints</param>
		/// <param name="flat">(Optional) Hierarchy is ignored</param>
		/// <param name="only_cells">(Optional) Only cells</param>
		/// <param name="levels">(Optional) Maximum number of cell levels to traverse:Value >= 0 Default: 0</param>
		/// <param name="pin_levels">(Optional) Maximum number of pin levels to traverse:Value >= 0 Default: 0</param>
		/// <param name="trace_arcs">(Optional) Type of network arcs to trace: Values: timing, enabled, all</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of cell or pin objects</returns>
		public TTCL all_fanout(string from, bool? endpoints_only = null, bool? flat = null, bool? only_cells = null, string levels = null, string pin_levels = null, string trace_arcs = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: all_fanout [-endpoints_only] [-flat] [-only_cells] [-levels <arg>] [-pin_levels <arg>] [-trace_arcs <arg>] [-quiet] [-verbose] <from>
			_tcl.Entry(_builder.all_fanout(from, endpoints_only, flat, only_cells, levels, pin_levels, trace_arcs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of flip flop cells in the current design
		///
		///
		/// TCL Syntax: all_ffs [-quiet] [-verbose]
		///
		/// Returns a list of all flip flop instances in the current design.
		/// You can use the get_cells command, or use the filter command to limit the results from
		/// the all_ffs command to return a list of flip-flop cells matching the specified properties.
		/// The all_ffs command is scoped to return the objects hierarchically, from the top-level of the
		/// design or from the level of the current instance. By default the current instance is defined as the
		/// top level of the design, but can be changed by using the current_instance command.
		///
		/// The following example returns the count of all flops in the design, then returns the count of all
		/// flops in the fftEngine module:
		/// current_instance
		/// INFO: [Vivado 12-618] Current instance is the top level of design
		/// 'netlist_1'.
		/// top
		/// llength [all_ffs]
		/// 15741
		/// current_instance fftEngine
		/// fftEngine
		/// llength [all_ffs]
		/// 1519
		/// This example filters the results of all_ffs to return only the FDRE flops:
		/// filter [all_ffs] {REF_NAME == FDRE}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 84
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of flip flop cell objects</returns>
		public TTCL all_ffs(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: all_ffs [-quiet] [-verbose]
			_tcl.Entry(_builder.all_ffs(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of hsio cells in the current design
		///
		///
		/// TCL Syntax: all_hsios [-quiet] [-verbose]
		///
		/// Returns a list of all High Speed IO (HSIO) cell objects that have been declared in the current
		/// design. These HSIO cell objects can be assigned to a variable or passed into another command.
		/// The list of high-speed IOs returned by all_hsios can also be limited or reduced by the
		/// filter command to filter according to properties assigned to the HSIO objects. Properties of
		/// an object can be returned by the list_property or report_property commands.
		/// The all_hsios command is scoped to return the objects hierarchically, from the top-level of
		/// the design or from the level of the current instance. By default the current instance is defined as
		/// the top level of the design, but can be changed by using the current_instance command.
		///
		/// The following example returns all HSIO objects in the current design:
		/// all_hsios
		/// The following example shows how the list returned can be directly passed to another command:
		/// set_false_path -from [all_hsios] -to [all_registers]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 86
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of hsio cell objects</returns>
		public TTCL all_hsios(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: all_hsios [-quiet] [-verbose]
			_tcl.Entry(_builder.all_hsios(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of all input ports in the current design
		///
		///
		/// TCL Syntax: all_inputs [-quiet] [-verbose]
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
		/// See ug835-vivado-tcl-commands.pdf, page 88
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of port objects</returns>
		public TTCL all_inputs(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: all_inputs [-quiet] [-verbose]
			_tcl.Entry(_builder.all_inputs(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of all latch cells in the current design
		///
		///
		/// TCL Syntax: all_latches [-quiet] [-verbose]
		///
		/// Returns a list of all latches that have been declared in the current design.
		/// The list of latches returned by all_latches can also be limited or reduced by the filter
		/// command to filter according to properties assigned to the latches. Properties of an object can be
		/// returned by the list_property or report_property commands.
		/// The all_latches command is scoped to return the objects hierarchically, from the top-level of
		/// the design or from the level of the current instance. By default the current instance is defined as
		/// the top level of the design, but can be changed by using the current_instance command.
		///
		/// The following example returns a list of all latches in the current design:
		/// all_latches
		/// The following example shows how the list returned can be passed to another command:
		/// set_false_path -from [all_mults] -to [all_latches]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 90
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of latch cell objects</returns>
		public TTCL all_latches(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: all_latches [-quiet] [-verbose]
			_tcl.Entry(_builder.all_latches(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of all output ports in the current design
		///
		///
		/// TCL Syntax: all_outputs [-quiet] [-verbose]
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
		/// See ug835-vivado-tcl-commands.pdf, page 92
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of port objects</returns>
		public TTCL all_outputs(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: all_outputs [-quiet] [-verbose]
			_tcl.Entry(_builder.all_outputs(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of ram cells in the current design
		///
		///
		/// TCL Syntax: all_rams [-quiet] [-verbose]
		///
		/// Returns a list of all the RAM cell objects present in the current instance, including Block RAMS,
		/// Block RAM FIFOs, and Distributed RAMS. These RAM cell objects can be assigned to a variable
		/// or passed into another command.
		/// To get a list of specific RAM cells in the design, use the filter command to filter the results
		/// returned by all_rams based on properties assigned to the RAM cells. Properties of an object
		/// can be returned by the list_property or report_property commands.
		/// The all_rams command is scoped to return the objects hierarchically, from the top-level of the
		/// design or from the level of the current instance. By default the current instance is defined as the
		/// top level of the design, but can be changed by using the current_instance command.
		///
		/// The following example returns all RAM cells in the design:
		/// all_rams
		/// This example returns all RAM cells in the design, and filters the results to return only the FIFO
		/// block memories:
		/// filter [all_rams] {PRIMITIVE_SUBGROUP == fifo}
		/// The following example sets the current instance, and returns all RAM objects hierarchically from
		/// the level of the current instance:
		/// current_instance usbEngine0
		/// all_rams
		///
		/// See ug835-vivado-tcl-commands.pdf, page 94
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of ram cell objects</returns>
		public TTCL all_rams(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: all_rams [-quiet] [-verbose]
			_tcl.Entry(_builder.all_rams(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of register cells or pins in the current design
		///
		///
		/// TCL Syntax: all_registers [-clock <args>] [-rise_clock <args>] [-fall_clock <args>] [-cells] [-data_pins] [-clock_pins] [-async_pins] [-output_pins] [-level_sensitive] [-edge_triggered] [-no_hierarchy] [-quiet] [-verbose]
		///
		/// Returns a list of sequential register cells or register pins in the current design.
		/// TIP: Returned objects includes DSPs and BRAMs as they contain internal registers.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
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
		/// See ug835-vivado-tcl-commands.pdf, page 96
		/// </summary>
		/// <param name="clock">(Optional) Consider registers of this clock</param>
		/// <param name="rise_clock">(Optional) Consider registers triggered by clock rising edge</param>
		/// <param name="fall_clock">(Optional) Consider registers triggered by clock falling edge</param>
		/// <param name="cells">(Optional) Return list of cells (default)</param>
		/// <param name="data_pins">(Optional) Return list of register data pins</param>
		/// <param name="clock_pins">(Optional) Return list of register clock pins</param>
		/// <param name="async_pins">(Optional) Return list of async preset/clear pins</param>
		/// <param name="output_pins">(Optional) Return list of register output pins</param>
		/// <param name="level_sensitive">(Optional) Only consider level-sensitive latches</param>
		/// <param name="edge_triggered">(Optional) Only consider edge-triggered flip-flops</param>
		/// <param name="no_hierarchy">(Optional) Only search the current instance</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of cell or pin objects</returns>
		public TTCL all_registers(string clock = null, string rise_clock = null, string fall_clock = null, bool? cells = null, bool? data_pins = null, bool? clock_pins = null, bool? async_pins = null, bool? output_pins = null, bool? level_sensitive = null, bool? edge_triggered = null, bool? no_hierarchy = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: all_registers [-clock <args>] [-rise_clock <args>] [-fall_clock <args>] [-cells] [-data_pins] [-clock_pins] [-async_pins] [-output_pins] [-level_sensitive] [-edge_triggered] [-no_hierarchy] [-quiet] [-verbose]
			_tcl.Entry(_builder.all_registers(clock, rise_clock, fall_clock, cells, data_pins, clock_pins, async_pins, output_pins, level_sensitive, edge_triggered, no_hierarchy, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Connect debug slave instances to the master instance. A valid master is a debug bridge or debug
		/// hub instance configured in "From BSCAN To DebugHUB" mode. A valid slave could be any of the
		/// following debug cores (Ex: ILA, VIO, JTAG_to_AXI). connect_debug_cores can only connect
		/// master and slave instances that exist in the same region (either in Reconfigurable Partition or
		/// static)
		///
		///
		/// TCL Syntax: connect_debug_cores -master <args> -slaves <args> [-quiet] [-verbose]
		///
		/// Connect debug slave instances to the specified master instance. The command can add the
		/// specified slaves into an existing debug chain, where the specified slaves will be connected to the
		/// debug hub or bridge, without affecting debug slaves that are already in the connection chain.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Debug masters include both the Debug Hub and Debug Bridge. The Vivado Debug Hub core
		/// provides an interface between the JTAG Boundary Scan (BSCAN) interface of the Xilinx device
		/// and the Vivado Debug cores, including the Integrated Logic Analyzer (ILA), Virtual Input/Output
		/// (VIO), and the JTAG-to-AXI. The Vivado Debug Bridge is a debug controller that provides
		/// multiple options to communicate with the debug cores in both flat designs, or Partial
		/// Reconfiguration (PR) designs. The Debug Bridge can be configured to debug designs using a
		/// JTAG cable, or remotely through Ethernet, PCIe, or other interfaces using a Xilinx Virtual Cable
		/// (XVC), without the need for a JTAG cable. Refer to the Vivado Design Suite User Guide: Vivado
		/// Programming and Debugging (UG908) for more information.
		/// IMPORTANT! For Partial Reconfiguration (PR) designs, the connect_debug_cores command can
		/// only connect master and slave instances that occur in the Static Region, or in the same Reconfigurable
		/// Partition.
		///
		/// The following example connects the specified ILA cores to the debug bridge:
		/// connect_debug_cores -master [get_cells inst_count/debug_bridge_0] \
		/// -slaves [list [get_cells inst_count/ila_0] [get_cells inst_count/ila_1] ]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 198
		/// </summary>
		/// <param name="master">
		/// (Required)
		/// A valid debug bridge or debug hub instance configured in
		/// "From BSCAN To DebugHUB" mode. Only one master
		/// instance is allowed.
		/// </param>
		/// <param name="slaves">
		/// (Required)
		/// List of valid slave instances. A valid slave instance is any of
		/// the following debug cores (Ex: ILA, VIO, JTAG_to_AXI)
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>debug master and slave instances</returns>
		public TTCL connect_debug_cores(string master, string slaves, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: connect_debug_cores -master <args> -slaves <args> [-quiet] [-verbose]
			_tcl.Entry(_builder.connect_debug_cores(master, slaves, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Connect nets and pins to debug port channels
		///
		///
		/// TCL Syntax: connect_debug_port [-channel_start_index <arg>] [-quiet] [-verbose] <port> <nets>...
		///
		/// Connects a signal from the netlist design to a port on an ILA debug core that was added to the
		/// design using the create_debug_core command. The signal can either be connected to a
		/// specific channel index on the port, or simply connected to an available channel on the port.
		/// If you try to connect too many signals to a port, or there are not enough channels to support the
		/// connection, the tool will return an error.
		/// Additional ports can be added to a debug core through the use of the create_debug_port
		/// command, and you can increase the available channels on an existing port with the
		/// set_property port_width command. See the examples below.
		/// You can disconnect signals from ports using the disconnect_debug_port command.
		/// When the debug core has been defined and connected, you can implement the debug core as a
		/// block for inclusion in the netlist design. Use the implement_debug_core command to
		/// implement the core.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example creates a new PROBE port on the myCore debug core, increases the
		/// PORT_WIDTH property of the port in order to prepare it to receive the number of signals to be
		/// connected, and connects signals to the port starting at the third channel position (index 2).
		/// create_debug_port myCore PROBE
		/// set_property PORT_WIDTH 8 [get_debug_ports myCore/PROBE1]
		/// connect_debug_port myCore/PROBE1 [get_nets [list m0_ack_o m0_cyc_i \
		/// m0_err_o m0_rty_o m0_stb_i m0_we_i ]] -channel_start_index 2
		/// Note: If you specify too many nets to connect to the available channels on the port, the tool will return an
		/// error and will not connect the ports.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 201
		/// </summary>
		/// <param name="port">(Required) Debug port name</param>
		/// <param name="nets">(Required) List of nets or pins</param>
		/// <param name="channel_start_index">(Optional) Connect nets starting at channel index</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL connect_debug_port(string port, string nets, string channel_start_index = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: connect_debug_port [-channel_start_index <arg>] [-quiet] [-verbose] <port> <nets>...
			_tcl.Entry(_builder.connect_debug_port(port, nets, channel_start_index, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Create a clock object
		///
		///
		/// TCL Syntax: create_clock -period <arg> [-name <arg>] [-waveform <args>] [-add] [-quiet] [-verbose] [<objects>]
		///
		/// TIP: The XDC > Timing Constraints language templates and the Timing Constraints Wizard in the Vivado
		/// IDE offer timing diagrams and additional details around defining specific timing constraints. You can refer
		/// to these sources for additional information.
		/// Create a clock object with the specified period or waveform defined in nanoseconds (ns). This
		/// command defines primary clocks which are used by the timing engine as the delay propagation
		/// starting point of any clock edge. The defined clock can be added to the definition of an existing
		/// clock, or overwrite the existing clock.
		/// A virtual clock can be created that has no source in the design. A virtual clock can be used as a
		/// time reference for setting input and output delays but does not physically exist in the design.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// A clock can also be generated from an existing physical clock, and derive many of its properties
		/// from the master clock. Use the create_generated_clock command to derive a clock from
		/// an existing physical clock.
		/// IMPORTANT! If you use create_clock to create a generated clock, instead of
		/// create_generated_clock, the created clock does not inherit any of the properties of its source
		/// clock. The insertion delay and jitter of the parent clock will not be propagated to the generated clock,
		/// causing incorrect timing calculations.
		/// The create_clock command returns the name of the clock object that is created.
		///
		/// The following example creates a physical clock called bftClk and defines the clock period:
		/// create_clock -name bftClk -period 5.000 [get_ports bftClk]
		/// Note: If the get_ports command defining the objects is left off of this example, a virtual clock is created
		/// in the design rather than a physical clock.
		/// The following example creates a clock named clk on the input port, bftClk, with a period of 10ns,
		/// the rising edge at 2.4ns and the falling edge at 7.4ns:
		/// create_clock -name clk -period 10.000 -waveform {2.4 7.4} [get_ports bftClk]
		/// The following example creates a virtual clock since no clock source is specified:
		/// create_clock -name virtual_clock -period 5.000
		/// The following example creates a clock with the falling edge at 2ns and the rising edge at 7ns:
		/// create_clock -name clk -period 10.000 -waveform {7 2} [get_ports bftClk]
		/// Note: Because the falling edge is earlier than the rising edge in the -waveform definition, although it is
		/// specified as arg2, it occurs first in the waveform.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 246
		/// </summary>
		/// <param name="period">(Required) Clock period: Value > 0</param>
		/// <param name="name">(Optional) Clock name</param>
		/// <param name="waveform">(Optional) Clock edge specification</param>
		/// <param name="add">(Optional) Add to the existing clock in source_objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">(Optional) List of clock source ports, pins or nets</param>
		/// <returns>new clock object</returns>
		public TTCL create_clock(string period, string name = null, string waveform = null, bool? add = null, bool? quiet = null, bool? verbose = null, string objects = null)
		{
			// TCL Syntax: create_clock -period <arg> [-name <arg>] [-waveform <args>] [-add] [-quiet] [-verbose] [<objects>]
			_tcl.Entry(_builder.create_clock(period, name, waveform, add, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// Create a new Integrated Logic Analyzer debug core
		///
		///
		/// TCL Syntax: create_debug_core [-quiet] [-verbose] <name> <type>
		///
		/// Adds a new Integrated Logic Analyzer (ILA) debug core to an open netlist design in the current
		/// project. The ILA debug core defines ports for connecting nets to for debugging the design in the
		/// logic analyzer feature of the Vivado Design Suite available through the open_hw command.
		/// ILA debug cores can be added to the RTL source files of the design using debug cores from the
		/// Xilinx IP catalog, or added to the netlist design after synthesis using this command. Refer to the
		/// Vivado Design Suite User Guide: Vivado Programming and Debugging (UG908) for more information
		/// on using ILA debug cores.
		/// Note: A debug core can only be added to an open netlist design using this command.
		/// The ILA core is created with a CLK port and a PROBE port by default. The CLK port defines the
		/// clock domain for the ILA core, and allows you to probe signals that are common to that domain.
		/// The CLK port only supports one clock signal, and so you must create a separate debug core for
		/// each clock domain. The PROBE port provides a probe point for nets marked for debug with the
		/// MARK_DEBUG property. The PROBE port offers multiple channels to probe multiple nets from a
		/// single ILA core.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// You can add new ports to an existing ILA core with the create_debug_port command, and
		/// connect signals to the ports using the connect_debug_port command.
		///
		/// The following example opens the synthesis run, creating the specified netlist design name, and
		/// then creates a new ILA debug core in that design:
		/// open_run -name netlist_1 synth_1
		/// create_debug_core myCore ila
		/// The properties of the debug core can be customized by using the set_property command as
		/// in the following example:
		/// set_property C_DATA_DEPTH 2048 [get_debug_cores myCore]
		/// This example marks a sequence of nets for debugging using the MARK_DEBUG property, creates
		/// a new debug core, connects the CLK port to the appropriate clock domain, and assigns the debug
		/// nets to the PROBE ports on the core:
		/// set_property MARK_DEBUG true [get_nets [list {control_reg[0]}
		/// {control_reg[1]} \
		/// {control_reg[2]} {control_reg[3]} {control_reg[4]} {control_reg[5]} \
		/// {control_reg[6]} {control_reg[7]} {control_reg[8]} {control_reg[9]} \
		/// {control_reg[10]} {control_reg[11]} {control_reg[12]} {control_reg[13]}
		/// \
		/// {control_reg[14]} {control_reg[15]} {control_reg[16]} {control_reg[17]}
		/// \
		/// {control_reg[18]} {control_reg[19]} {control_reg[20]} {control_reg[21]}
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// \
		/// {control_reg[22]} {control_reg[23]} {control_reg[24]} {control_reg[25]}
		/// \
		/// {control_reg[26]} {control_reg[27]} {control_reg[28]} {control_reg[29]}
		/// \
		/// {control_reg[30]} {control_reg[31]}]]
		/// create_debug_core u_ila_0 ila
		/// set_property port_width 1 [get_debug_ports u_ila_0/CLK]
		/// connect_debug_port u_ila_0/CLK [get_nets [list wbClk ]]
		/// set_property port_width 32 [get_debug_ports u_ila_0/PROBE0]
		/// connect_debug_port u_ila_0/PROBE0 [get_nets [list {control_reg[0]}
		/// {control_reg[1]} {control_reg[2]} {control_reg[3]} {control_reg[4]} \
		/// {control_reg[5]} {control_reg[6]} {control_reg[7]} {control_reg[8]} \
		/// {control_reg[9]} {control_reg[10]} {control_reg[11]} {control_reg[12]}
		/// \
		/// {control_reg[13]} {control_reg[14]} {control_reg[15]} {control_reg[16]}
		/// \
		/// {control_reg[17]} {control_reg[18]} {control_reg[19]} {control_reg[20]}
		/// \
		/// {control_reg[21]} {control_reg[22]} {control_reg[23]} {control_reg[24]}
		/// \
		/// {control_reg[25]} {control_reg[26]} {control_reg[27]} {control_reg[28]}
		/// \
		/// {control_reg[29]} {control_reg[30]} {control_reg[31]} ]]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 255
		/// </summary>
		/// <param name="name">(Required) Name of the new debug core instance</param>
		/// <param name="type">(Required) Type of the new debug core</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>new debug_core object</returns>
		public TTCL create_debug_core(string name, string type, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_debug_core [-quiet] [-verbose] <name> <type>
			_tcl.Entry(_builder.create_debug_core(name, type, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Create a new debug port
		///
		///
		/// TCL Syntax: create_debug_port [-quiet] [-verbose] <name> <type>
		///
		/// Defines a new port to be added to an existing Vivado ILA debug core that was added to the
		/// design using the create_debug_core command. The port provides connection points on an
		/// ILA core to attach nets from the design for debugging.
		/// When a new debug core is created using the create_debug_core command, it includes a clk
		/// and probe port by default. However, you can add trigger input/output port types as well. Refer
		/// to the Vivado Design Suite User Guide: Programming and Debugging (UG908) for more information
		/// on port types and purpose.
		/// A port can have one or more connection points to support one or more nets to debug. As a
		/// default new ports are defined as having a width of 1, allowing only one net to be attached. You
		/// can change the port width of probe ports to support multiple signals using the set_property
		/// port_width command (see Examples).
		/// Note: clk, trig_in, trig_in_ack, trig_out, and trig_out_ack ports can only have a width of 1.
		/// You can connect signals to ports using the connect_debug_port command, modify existing
		/// probe connections using modify_debug_ports, and disconnect signals with the
		/// disconnect_debug_port command.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example creates a new debug core, and then adds an additional probe port to the
		/// core, then sets the width of that new port to 8, and connects signals to the probe port:
		/// create_debug_core myCore ila
		/// create_debug_port myCore probe
		/// set_property PORT_WIDTH 8 myCore/probe1
		/// connect_debug_port -channel_start_index 1 myCore/probe1 \
		/// {m1_cyc_i m1_ack_o m1_err_o m1_rty_o}
		/// Note: Recall that the ILA core is created with a clk and probe port by default, so the new probe port is
		/// automatically numbered as probe1.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 258
		/// </summary>
		/// <param name="name">(Required) Name of the debug core instance</param>
		/// <param name="type">(Required) Type of the new debug port</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>new debug_port object</returns>
		public TTCL create_debug_port(string name, string type, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_debug_port [-quiet] [-verbose] <name> <type>
			_tcl.Entry(_builder.create_debug_port(name, type, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Create a generated clock object
		///
		///
		/// TCL Syntax: create_generated_clock [-name <arg>] [-source <args>] [-edges <args>] [-divide_by <arg>] [-multiply_by <arg>] [-combinational] [-duty_cycle <arg>] [-invert] [-edge_shift <args>] [-add] [-master_clock <args>] [-quiet] [-verbose] <objects>
		///
		/// TIP: The XDC > Timing Constraints language templates and the Timing Constraints Wizard in the Vivado
		/// IDE offer timing diagrams and additional details around defining specific timing constraints. You can refer
		/// to these sources for additional information.
		/// Generate a new clock object from an existing physical clock object in the design.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
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
		/// IMPORTANT! You cannot rename a clock that is already in use by other constraints at the time of
		/// renaming. You must rename the clock prior to any other appearance or use of the clock in an XDC file.
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
		/// See ug835-vivado-tcl-commands.pdf, page 275
		/// </summary>
		/// <param name="objects">(Required) List of clock source ports, pins, or nets</param>
		/// <param name="name">(Optional) Generated clock name</param>
		/// <param name="source">(Optional) Master clock source object pin/port</param>
		/// <param name="edges">(Optional) Edge Specification</param>
		/// <param name="divide_by">(Optional) Period division factor: Value >= 1 Default: 1</param>
		/// <param name="multiply_by">(Optional) Period multiplication factor: Value >= 1 Default: 1</param>
		/// <param name="combinational">(Optional) Create a divide_by 1 clock through combinational logic</param>
		/// <param name="duty_cycle">(Optional) Duty cycle of clock period: Range: 0.0 to 100.0 Default: 50.0</param>
		/// <param name="invert">(Optional) Invert the signal</param>
		/// <param name="edge_shift">(Optional) Edge shift specification</param>
		/// <param name="add">(Optional) Add to the existing clock in source_objects</param>
		/// <param name="master_clock">(Optional) Use this clock if multiple clocks present at master pin</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>new clock object</returns>
		public TTCL create_generated_clock(string objects, string name = null, string source = null, string edges = null, string divide_by = null, string multiply_by = null, bool? combinational = null, string duty_cycle = null, bool? invert = null, string edge_shift = null, bool? add = null, string master_clock = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_generated_clock [-name <arg>] [-source <args>] [-edges <args>] [-divide_by <arg>] [-multiply_by <arg>] [-combinational] [-duty_cycle <arg>] [-invert] [-edge_shift <args>] [-add] [-master_clock <args>] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.create_generated_clock(objects, name, source, edges, divide_by, multiply_by, combinational, duty_cycle, invert, edge_shift, add, master_clock, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Create a Macro
		///
		///
		/// TCL Syntax: create_macro [-quiet] [-verbose] <name>
		///
		/// Create a macro for the relative placement of cells.
		/// Macros are primarily used to place small groups of associated cells together to improve resource
		/// efficiency and enable faster interconnections. The create_macro command lets you define
		/// macros in an open synthesized or implemented design for relative placement by place_design,
		/// like RPMs defined by the RLOC constraint in RTL source files. Refer to the Vivado Design Suite
		/// User Guide: Implementation (UG904) for more information on defining relatively placed macros.
		/// After creating the macro, specific cells can be assigned to the macro using the update_macro
		/// command. To change a currently defined macro, you must delete the macro with
		/// delete_macro, recreate the macro, and update the macro with the new contents. You cannot
		/// simply overwrite an existing macro.
		/// Use delete_macro to delete a defined macro. Use get_macros to return a list of currently
		/// defined macros in the design.
		/// This command operates silently and does not return anything.
		///
		/// The following example creates a macro called usbMacro1:
		/// create_macro usbMacro1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 321
		/// </summary>
		/// <param name="name">(Required) Macro to create.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_macro(string name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_macro [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_macro(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Create a new Pblock
		///
		///
		/// TCL Syntax: create_pblock [-quiet] [-verbose] <name>
		///
		/// Defines a Pblock to allow you to add logic instances for floorplanning purposes.
		/// You can add logic elements to the Pblock using the add_cells_to_pblock command, and
		/// then place the Pblocks onto the fabric of the FPGA using the resize_pblocks command. The
		/// resize_pblock command can also be used to manually move and resize Pblocks.
		/// You can nest one Pblock inside another for hierarchical floorplanning using the set_property
		/// command to define the PARENT property as shown in the second example.
		///
		/// The following example creates a Pblock called pb_cpuEngine, and then adds only the leaf-cells
		/// found in the cpuEngine module, clearing placement constraints for placed instances:
		/// create_pblock pb_cpuEngine
		/// add_cells_to_pblock pb_cpuEngine [get_cells cpuEngine/*] \
		/// -add_primitives -clear_locs
		/// The following example shows nesting Pblocks, by creating Pblocks called pb_usbEngine0 and
		/// pb_usbEngine1, and a third Pblock called pb_usbTop. Then pb_usbEngine0 and pb_usbEngine1
		/// are nested inside pb_usbTop using the set_property command:
		/// create_pblock pb_usbEngine0
		/// create_pblock pb_usbEngine1
		/// create_pblock pb_usbTop
		/// set_property PARENT pb_usbTop [get_pblocks {pb_usbEngine?}]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 327
		/// </summary>
		/// <param name="name">(Required) Name of the new pblock</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>new pblock object</returns>
		public TTCL create_pblock(string name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_pblock [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_pblock(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Create a new Power Rail
		///
		///
		/// TCL Syntax: create_power_rail [-power_sources <args>] [-direct] [-quiet] [-verbose] <name>
		///
		/// See ug835-vivado-tcl-commands.pdf, page 339
		/// </summary>
		/// <param name="name">(Required) Name of the new power rail</param>
		/// <param name="power_sources">(Optional) List of power sources. Can be power rails and/or power supplies</param>
		/// <param name="direct">(Optional) Implies if the power is a direct rail</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>new power_rail object</returns>
		public TTCL create_power_rail(string name, string power_sources = null, bool? direct = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_power_rail [-power_sources <args>] [-direct] [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_power_rail(name, power_sources, direct, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Create property for class of objects(s)
		///
		///
		/// TCL Syntax: create_property [-description <arg>] [-type <arg>] [-enum_values <args>] [-default_value <arg>] [-file_types <args>] [-display_text <arg>] [-quiet] [-verbose] <name> <class>
		///
		/// Creates a new property of the <type> specified with the user-defined <name> for the specified
		/// <class> of objects. The property that is created can be assigned to an object of the specified class
		/// with the set_property command, but is not automatically associated with all objects of that
		/// class.
		/// The report_property -all command will not report the newly created property for an
		/// object of the specified class until the property has been assigned to that object.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example defines a property called PURPOSE for cell objects:
		/// create_property PURPOSE cell
		/// Note: Because the -type was not specified, the value will default to strings.
		/// The following example creates a pin property called COUNT which holds an Integer value:
		/// create_property -type int COUNT pin
		///
		/// See ug835-vivado-tcl-commands.pdf, page 347
		/// </summary>
		/// <param name="name">(Required) Name of property to create</param>
		/// <param name="@class">
		/// (Required)
		/// Object type to create property for; valid values are: design,
		/// net, cell, pin, port, pblock, interface, fileset
		/// </param>
		/// <param name="description">(Optional) Description of property</param>
		/// <param name="type">
		/// (Optional)
		/// Type of property to create; valid values are: string, int, long,
		/// double, bool, enum, file Default: string
		/// </param>
		/// <param name="enum_values">(Optional) Enumeration values</param>
		/// <param name="default_value">(Optional) Default value of type string</param>
		/// <param name="file_types">(Optional) File type extensions (without the dot)</param>
		/// <param name="display_text">(Optional) Text to display when selecting the file in file browser</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The property that was created if success, "" if failure</returns>
		public TTCL create_property(string name, string @class, string description = null, string type = null, string enum_values = null, string default_value = null, string file_types = null, string display_text = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_property [-description <arg>] [-type <arg>] [-enum_values <args>] [-default_value <arg>] [-file_types <args>] [-display_text <arg>] [-quiet] [-verbose] <name> <class>
			_tcl.Entry(_builder.create_property(name, @class, description, type, enum_values, default_value, file_types, display_text, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Create a DRC/METHODOLOGY/CDC message waiver
		///
		///
		/// TCL Syntax: create_waiver [-type <arg>] [-id <arg>] [-objects <args>] [-from <args>] [-to <args>] [-strings <args>] [-of_objects <args>] [-user <arg>] -description <arg> [-tags <arg>] [-timestamp <arg>] [-scoped] [-quiet] [-verbose]
		///
		/// After report_drc, report_methodology, or report_cdc commands are run, they return
		/// messages of specific violations or conditions found in the design. These violations can prevent
		/// the design from progressing until they have been resolved or addressed in some way. The
		/// create_waiver command lets you select individual violations or specific checks that can be
		/// waived for a design, letting you move forward in the design flow.
		/// IMPORTANT! Use caution when waiving violations. Waivers may let you proceed in the design flow, but
		/// also let you create a design that is fundamentally flawed.
		/// The user creating the waiver is required to provide a user ID and description in the
		/// create_waiver command in order to provide some history of the waiver.
		/// A waiver must be specified for an individual DRC or methodology violation, or for a specific DRC
		/// or methodology check, or for a CDC path. The waiver must be assigned to a specific object, or
		/// specific violation ID, or for paths using -from/-to arguments. The form of the
		/// create_waiver command varies depending on the check, violation, or object being waived, as
		/// shown in the examples below.
		/// TIP: Although many of the arguments are described as optional, some form of identifier is required to
		/// associate the waiver with its target.
		/// To save waivers from one design session to the next, you must use write_waivers to create
		/// an XDC file of the waiver commands, and read_xdc to read those waivers back into the design
		/// when it is reopened.
		/// After creating a waiver, you will need to rerun the DRC, methodology, or CDC report to have the
		/// waiver considered in the analysis. To see what waivers are in place in the current design you can
		/// use the report_waivers command. In addition, the report_drc, report_methodology,
		/// and report_cdc commands have options to run the reports on waived violations or checks.
		/// Use the delete_waivers command to remove waivers from the design.
		///
		/// This example creates a waiver for a methodology check based on the specified ID:
		/// create_waiver -id TIMING-18 -user samwise -description {waive rule check}
		/// The following example creates a DRC check waiver for the indicated ID on the specified list of
		/// port objects, and provides the timestamp in local time:
		/// create_waiver -type DRC -id UCIO-1 -user samwise -desc {waiving DRC
		/// violation} \
		/// -objects [get_ports {src_in* dest_out*}] \
		/// -timestamp [clock format [clock seconds] -gmt 0]
		/// The following example creates a waiver for specific CDC paths in the design, defined by the -
		/// from/-to arguments:
		/// create_waiver -type CDC -id CDC-6 -user samwise \
		/// -description {Paths to be re-tested later}\
		/// -from [list [get_pins {inst_xpm_grey/src_gray_ff_reg[3]/C \
		/// inst_xpm_grey/src_gray_ff_reg[16]/C \
		/// inst_xpm_grey/src_gray_ff_reg[22]/C \
		/// inst_xpm_grey/src_gray_ff_reg[25]/C}] ] \
		/// -to [list [get_pins {inst_xpm_grey/dest_graysync_ff_reg[0][1]/D \
		/// inst_xpm_grey/dest_graysync_ff_reg[0][6]/D \
		/// inst_xpm_grey/dest_graysync_ff_reg[0][9]/D \
		/// inst_xpm_grey/dest_graysync_ff_reg[0][24]/D}] ]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 367
		/// </summary>
		/// <param name="description">(Required) Description string of the cause for the waiver</param>
		/// <param name="type">(Optional) Type of waiver - DRC, METHODOLOGY, CDC</param>
		/// <param name="id">
		/// (Optional)
		/// ID of the DRC/METHODOLOGY/CDC message being waived,
		/// not needed for -of_objects use
		/// </param>
		/// <param name="objects">
		/// (Optional)
		/// List of inserted message objects for which a DRC/
		/// METHODOLOGY waiver will be set (i.e. %ELG, %SIG, etc. for
		/// cells or nets, etc., sites, etc., or '*CELL', '*NET', '*SITE', etc.
		/// as wildcards
		/// </param>
		/// <param name="from">
		/// (Optional)
		/// List of source (driver) pins or ports (or '*PORT', '*PIN' as
		/// wildcard) for which a CDC waiver will be set
		/// </param>
		/// <param name="to">
		/// (Optional)
		/// List of target (load) pins or ports (or '*PORT', '*PIN' as
		/// wildcard) for which a CDC waiver will be set
		/// </param>
		/// <param name="strings">
		/// (Optional)
		/// List of inserted message string values for which a DRC/
		/// METHODOLOGY waiver will be set (i.e. %STR for strings, or
		/// '*' as wildcard)
		/// </param>
		/// <param name="of_objects">
		/// (Optional)
		/// List of DRC/METHODOLOGY/CDC violation objects for which
		/// waiver(s) will be set
		/// </param>
		/// <param name="user">
		/// (Optional)
		/// Name of the user creating the waiver (required, but if not
		/// specified, the waivers will take the USER name from the
		/// environment if it is available)
		/// </param>
		/// <param name="tags">
		/// (Optional)
		/// Optional list of one or more tags to aid in subsequent
		/// waiver identification or categorization
		/// </param>
		/// <param name="timestamp">
		/// (Optional)
		/// Timestamp of waiver - for restaining the original time of a
		/// waiver being (re)created after being written
		/// </param>
		/// <param name="scoped">
		/// (Optional)
		/// Flag waiver to interpret object wildcards as scoped to the
		/// current_instance that is set
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">
		/// (Optional)
		/// Suspend message limits during command execution
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// </param>
		/// <returns>waiver</returns>
		public TTCL create_waiver(string description, string type = null, string id = null, string objects = null, string from = null, string to = null, string strings = null, string of_objects = null, string user = null, string tags = null, string timestamp = null, bool? scoped = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_waiver [-type <arg>] [-id <arg>] [-objects <args>] [-from <args>] [-to <args>] [-strings <args>] [-of_objects <args>] [-user <arg>] -description <arg> [-tags <arg>] [-timestamp <arg>] [-scoped] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_waiver(description, type, id, objects, from, to, strings, of_objects, user, tags, timestamp, scoped, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Set or get the current design.
		///
		///
		/// TCL Syntax: current_design [-quiet] [-verbose] [<design>]
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
		/// See ug835-vivado-tcl-commands.pdf, page 385
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="design">(Optional) Name of current design to be set</param>
		/// <returns>design object</returns>
		public TTCL current_design(bool? quiet = null, bool? verbose = null, string design = null)
		{
			// TCL Syntax: current_design [-quiet] [-verbose] [<design>]
			_tcl.Entry(_builder.current_design(quiet, verbose, design));
			return _tcl;
		}
		/// <summary>
		/// Set or get the current instance
		///
		///
		/// TCL Syntax: current_instance [-quiet] [-verbose] [<instance>]
		///
		/// Set the current instance in the design hierarchy to the specified instance cell or to the top of the
		/// current design. By default, current_instance points to the top module of the
		/// current_design, which is not an instantiated cell object. You can also set
		/// current_instance to reference an instantiated hierarchical cell in the design.
		/// IMPORTANT! Since the top module is not an instantiated object, current_instance returns an
		/// empty string rather than a design object, when set to the top-level of the current design.
		/// The current design and current instance are the target of most of the commands and design
		/// changes you will make. The current design can be defined using the current_design
		/// command.
		/// You must specify the <instance> name relative to the currently defined instance, and use the
		/// established hierarchy separator to define instance paths. You can determine the current hierarchy
		/// separator with the get_hierarchy_separator command.
		/// Use '..' to traverse up the hierarchical instance path when specifying the current instance.
		/// This command returns the name of the design object of the current_instance, or returns nothing
		/// when set to the top of current design.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
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
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The following example returns the name of the presently defined current instance:
		/// current_instance .
		/// cpuEngine|cpu_iwb_dat_o|buffer_fifo
		///
		/// See ug835-vivado-tcl-commands.pdf, page 406
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="instance">(Optional) Name of instance</param>
		/// <returns>instance name</returns>
		public TTCL current_instance(bool? quiet = null, bool? verbose = null, string instance = null)
		{
			// TCL Syntax: current_instance [-quiet] [-verbose] [<instance>]
			_tcl.Entry(_builder.current_instance(quiet, verbose, instance));
			return _tcl;
		}
		/// <summary>
		/// Delete a list of macros
		///
		///
		/// TCL Syntax: delete_macros [-quiet] [-verbose] <macros>
		///
		/// Delete one or more macro defined by the create_macro command.
		///
		/// The following example deletes a macro called usbMacro1:
		/// delete_macros usbMacro1
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 459
		/// </summary>
		/// <param name="macros">(Required) Macros to delete</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_macros(string macros, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_macros [-quiet] [-verbose] <macros>
			_tcl.Entry(_builder.delete_macros(macros, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Remove Pblock
		///
		///
		/// TCL Syntax: delete_pblocks [-hier] [-quiet] [-verbose] <pblocks>...
		///
		/// Deletes the specified Pblocks from the design. Pblocks are created using the create_pblock
		/// command.
		///
		/// The following example deletes the specified Pblock as well as any Pblocks nested inside:
		/// delete_pblocks -hier cpuEngine
		///
		/// See ug835-vivado-tcl-commands.pdf, page 463
		/// </summary>
		/// <param name="pblocks">(Required) Pblocks to delete</param>
		/// <param name="hier">(Optional) Also delete all the children of Pblock</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_pblocks(string pblocks, bool? hier = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_pblocks [-hier] [-quiet] [-verbose] <pblocks>...
			_tcl.Entry(_builder.delete_pblocks(pblocks, hier, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Delete a Power Rail
		///
		///
		/// TCL Syntax: delete_power_rails [-quiet] [-verbose] <power_rail>
		///
		/// See ug835-vivado-tcl-commands.pdf, page 465
		/// </summary>
		/// <param name="power_rail">(Required) power rail to delete</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_power_rails(string power_rail, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_power_rails [-quiet] [-verbose] <power_rail>
			_tcl.Entry(_builder.delete_power_rails(power_rail, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Filter a list, resulting in new list
		///
		///
		/// TCL Syntax: filter [-regexp] [-nocase] [-quiet] [-verbose] [<objects>] [<filter>]
		///
		/// Takes a list of objects, and returns a reduced list of objects that match the specified filter search
		/// pattern.
		///
		/// The following example returns a list of parts filtered for the specified speed grade:
		/// filter [get_parts] {speed == -3}
		/// The following example filters parts based according to speed grade -3 OR speed grade -2. All
		/// parts matching either speed grade will be returned.
		/// filter [get_parts] {speed == -3 || speed == -2}
		/// The following example uses regular expression and returns a list of VStatus ports in the design,
		/// with zero or more wildcards, and the numbers 0 to 9 appearing one or more times within square
		/// brackets:
		/// filter -regexp [get_ports] {NAME =~ VStatus.*\[[0-9]+\]}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 526
		/// </summary>
		/// <param name="regexp">(Optional) Operators =~ and !~ use regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">(Optional) List of objects to filter</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <returns>new list</returns>
		public TTCL filter(bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, string objects = null, string filter = null)
		{
			// TCL Syntax: filter [-regexp] [-nocase] [-quiet] [-verbose] [<objects>] [<filter>]
			_tcl.Entry(_builder.filter(regexp, nocase, quiet, verbose, objects, filter));
			return _tcl;
		}
		/// <summary>
		/// Get a list of bel_pins. If a design is loaded, gets the constructed site type bels.
		///
		///
		/// TCL Syntax: get_bel_pins [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns a list of pins on the specified BELs, or matching a specified search pattern.
		/// The default command gets a list of all pins on all BELs on the device.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example returns the pins of the specified BELs associated with the specified range
		/// of sites on the device:
		/// get_bel_pins -of_objects [get_bels -of_objects [get_sites \
		/// -range {SLICE_X0Y0 SLICE_X1Y1}] ]
		/// The following example returns the clock enable (CE) pins of all BELs on the device:
		/// get_bel_pins *CE
		///
		/// See ug835-vivado-tcl-commands.pdf, page 594
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the bel_pin of these bels, sites, pins, or nets.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match bel_pin against patterns Default: *</param>
		/// <returns>bel_pin</returns>
		public TTCL get_bel_pins(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_bel_pins [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_bel_pins(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of bels. If a design is loaded, gets the constructed site type bels.
		///
		///
		/// TCL Syntax: get_bels [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-include_routing_bels] [-quiet] [-verbose] [<patterns>]
		///
		/// Basic Elements, or BELs, are building blocks of logic, such as flip-flops, LUTs, and carry logic, that
		/// make up a SLICE. This command returns a list of BELs on the target part that match a specified
		/// search pattern in an open design.
		/// The default command gets a list of all BELs on the device.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example returns the total number of BELs on the target part:
		/// llength [get_bels]
		/// The following example returns the BELs associated with the specified site:
		/// get_bels -of_objects [get_sites PHASER_IN_PHY_X0Y5]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 597
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the bels of these slr, tiles, sites, cells, clock_regions or nets.</param>
		/// <param name="include_routing_bels">(Optional) Also look for and include matching rbels.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match bels against patterns Default: *</param>
		/// <returns>bels</returns>
		public TTCL get_bels(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? include_routing_bels = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_bels [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-include_routing_bels] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_bels(regexp, nocase, filter, of_objects, include_routing_bels, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of cells in the current design
		///
		///
		/// TCL Syntax: get_cells [-hsc <arg>] [-hierarchical] [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-include_replicated_objects] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of cell objects in the current design that match a specified search pattern. The default
		/// command returns a list of all cells in the current_instance of the open design, as specified by the
		/// current_instance command.
		/// You can use the -hierarchical option to extract cells from the hierarchy of the current
		/// design.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
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
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The following example runs the report_drc command on the current design, and returns any
		/// cells associated with DRC violations:
		/// report_drc -name drc_1
		/// get_cells -of_objects [get_drc_violations]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 648
		/// </summary>
		/// <param name="hsc">(Optional) Hierarchy separator Default: /</param>
		/// <param name="hierarchical">(Optional) Search level-by-level in current instance</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get cells of these pins, timing paths, nets, bels, clock
		/// regions, sites, or drc violations
		/// </param>
		/// <param name="match_style">(Optional) Style of pattern matching Default: sdc Values: ucf, sdc</param>
		/// <param name="include_replicated_objects">
		/// (Optional)
		/// Include replicated objects when searching for patterns. This
		/// option is valid only when patterns is specified.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match cell names against patterns Default: *</param>
		/// <returns>list of cell objects</returns>
		public TTCL get_cells(string hsc = null, bool? hierarchical = null, bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, string match_style = null, bool? include_replicated_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_cells [-hsc <arg>] [-hierarchical] [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-include_replicated_objects] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_cells(hsc, hierarchical, regexp, nocase, filter, of_objects, match_style, include_replicated_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of clocks in the current design
		///
		///
		/// TCL Syntax: get_clocks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-include_generated_clocks] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of clocks in the current design that match a specified search pattern. The default
		/// command gets a list of all clocks in the design, like the all_clocks command.
		/// Clocks can be created using the create_clock or the create_generated_clock
		/// commands, or can be automatically generated by the tool, at the output of an MMCM for
		/// instance.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
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
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The following example gets all properties and property values attached to the specified clock:
		/// report_property -all [get_clocks wbClk]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 660
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get clocks of these pins, nets, or cells</param>
		/// <param name="match_style">(Optional) Style of pattern matching, valid values are ucf, sdc Default: sdc</param>
		/// <param name="include_generated_clocks">(Optional) Include auto-inferred/generated_clocks also.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match clock names against patterns Default: *</param>
		/// <returns>list of clocks</returns>
		public TTCL get_clocks(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, string match_style = null, bool? include_generated_clocks = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_clocks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-include_generated_clocks] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_clocks(regexp, nocase, filter, of_objects, match_style, include_generated_clocks, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of debug cores in the current design
		///
		///
		/// TCL Syntax: get_debug_cores [-filter <arg>] [-of_objects <args>] [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of Vivado Lab Edition debug cores in the current project that match a specified search
		/// pattern. The default command gets a list of all debug cores in the project.
		/// Debug cores are added to the project with the create_debug_core command. When a ILA
		/// debug core (labtools_ila_v3) is added to the project, it is contained within a Debug Hub core
		/// (labtools_xsdbmasterlib_v2), and includes a CLK port and a PROBE port as a default. Additional
		/// ports can be added to the debug core with the use of the create_debug_port command.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following command gets a list of the Vivado Lab Edition debug cores in the current project:
		/// get_debug_cores
		/// Note: A Debug Hub core is returned as one of the debug cores in the project. You cannot directly create
		/// this core, but it is automatically added by the tool when you add any ILA cores to the project.
		/// The following example gets the properties of the specified debug core:
		/// report_property [get_debug_cores myCore]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 669
		/// </summary>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get cores of these debug ports or nets</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match debug cores against patterns Default: *</param>
		/// <returns>list of debug_core objects</returns>
		public TTCL get_debug_cores(string filter = null, string of_objects = null, bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_debug_cores [-filter <arg>] [-of_objects <args>] [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_debug_cores(filter, of_objects, regexp, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of debug ports in the current design
		///
		///
		/// TCL Syntax: get_debug_ports [-filter <arg>] [-of_objects <args>] [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of ports defined on ILA debug cores in the current project that match a specified
		/// search pattern. The default command gets a list of all debug ports in the project.
		/// Debug ports are defined when ILA debug cores are created with the create_debug_core
		/// command. Ports can be added to existing debug cores with the create_debug_port
		/// command.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following command gets a list of the ports from the ILA debug cores in the current project,
		/// with a PORT_WIDTH property of 8:
		/// get_debug_ports -filter {PORT_WIDTH==8}
		/// The following example gets the properties attached to the specified debug port:
		/// report_property [get_debug_ports myCore/PROBE1]
		/// Note: The debug port is defined by the core_name/port_name combination.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 672
		/// </summary>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get ports of these debug cores</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match debug ports against patterns Default: *</param>
		/// <returns>list of debug_port objects</returns>
		public TTCL get_debug_ports(string filter = null, string of_objects = null, bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_debug_ports [-filter <arg>] [-of_objects <args>] [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_debug_ports(filter, of_objects, regexp, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of generated clocks in the current design
		///
		///
		/// TCL Syntax: get_generated_clocks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of generated clocks in the current project that match a specified search pattern. The
		/// default command gets a list of all generated clocks in the project.
		/// A generated clock can be added to the design using the create_generated_clock
		/// command, or can be automatically generated by the tool, at the output of an MMCM for
		/// instance.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example gets the names of all generated clocks in the current project:
		/// get_generated_clocks
		///
		/// See ug835-vivado-tcl-commands.pdf, page 698
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get generated clocks of these pins, ports or nets</param>
		/// <param name="match_style">(Optional) Style of pattern matching, valid values are ucf, sdc Default: sdc</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match generated clock names against patterns Default: *</param>
		/// <returns>list of clocks</returns>
		public TTCL get_generated_clocks(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, string match_style = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_generated_clocks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_generated_clocks(regexp, nocase, filter, of_objects, match_style, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get hierarchical separator character
		///
		///
		/// TCL Syntax: get_hierarchy_separator [-quiet] [-verbose]
		///
		/// Gets the character currently used for separating levels of hierarchy in the design. You can set the
		/// hierarchy separator using the set_hierarchy_separator command.
		///
		/// The following example gets the currently defined hierarchy separator:
		/// get_hierarchy_separator
		///
		/// See ug835-vivado-tcl-commands.pdf, page 705
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL get_hierarchy_separator(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_hierarchy_separator [-quiet] [-verbose]
			_tcl.Entry(_builder.get_hierarchy_separator(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of iobanks.
		///
		///
		/// TCL Syntax: get_iobanks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of I/O Banks on the target device in the current project that match a specified search
		/// pattern. The default command gets a list of all I/O Banks on the target device.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example returns the I/O Bank of the specified package pin:
		/// get_iobanks -of_objects [get_package_pins H4]
		/// This example returns the GT Banks on the device:
		/// get_iobanks -filter {BANK_TYPE == BT_MGT}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 803
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get the iobanks of these package_pins, ports, clock regions,
		/// slrs or sites.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match iobanks against patterns Default: *</param>
		/// <returns>iobanks</returns>
		public TTCL get_iobanks(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_iobanks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_iobanks(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of macros in the current design
		///
		///
		/// TCL Syntax: get_macros [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of macros in the current design that match a specified search pattern. The default
		/// command returns a list of all macros in the design.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example returns the properties currently assigned to the macro matching the
		/// specified search pattern:
		/// report_property [get_macro *Macro1]
		/// Note: If there are no macros matching the pattern you will get a warning.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 824
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get macros of these cells</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match macro names against patterns Default: *</param>
		/// <returns>list of macro objects</returns>
		public TTCL get_macros(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_macros [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_macros(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of nets in the current design
		///
		///
		/// TCL Syntax: get_nets [-hsc <arg>] [-hierarchical] [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-top_net_of_hierarchical_group] [-segments] [-boundary_type <arg>] [-quiet] [-verbose] [<patterns>]
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
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
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
		/// See ug835-vivado-tcl-commands.pdf, page 842
		/// </summary>
		/// <param name="hsc">(Optional) Hierarchy separator Default: /</param>
		/// <param name="hierarchical">(Optional) Search level-by-level in current instance</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get nets of these pins, ports, cells, timing paths or clocks,
		/// drc violations
		/// </param>
		/// <param name="match_style">(Optional) Style of pattern matching, valid values are ucf, sdc Default: sdc</param>
		/// <param name="top_net_of_hierarchical_group">
		/// (Optional)
		/// Return net segment(s) which belong(s) to the high level of a
		/// hierarchical net
		/// </param>
		/// <param name="segments">(Optional) Return all segments of a net across the hierarchy</param>
		/// <param name="boundary_type">
		/// (Optional)
		/// Return net segment connected to a hierarchical pin which
		/// resides at the same level as the pin (upper) or at the level
		/// below (lower), or both. Valid values are : upper, lower, both
		/// Default: upper
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match net names against patterns Default: *</param>
		/// <returns>list of net objects</returns>
		public TTCL get_nets(string hsc = null, bool? hierarchical = null, bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, string match_style = null, bool? top_net_of_hierarchical_group = null, bool? segments = null, string boundary_type = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_nets [-hsc <arg>] [-hierarchical] [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-top_net_of_hierarchical_group] [-segments] [-boundary_type <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_nets(hsc, hierarchical, regexp, nocase, filter, of_objects, match_style, top_net_of_hierarchical_group, segments, boundary_type, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of nodes in the device.
		///
		///
		/// TCL Syntax: get_nodes [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-uphill] [-downhill] [-flyover] [-from <args>] [-to <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns a list of nodes on the device that match a specified search pattern in an open design.
		/// The default command gets a list of all nodes on the device.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example returns the nodes associated with the specified tile:
		/// get_nodes -of_objects [get_tiles CLBLM_R_X11Y158]
		/// The following example returns the nodes downhill from the specified node:
		/// get_nodes -downhill -of_objects [get_nodes LIOB33_SING_X0Y199/IOB_PADOUT0]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 847
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'node' objects of these types: 'net tile node bel_pin
		/// site_pin wire pip speed_model'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="uphill">
		/// (Optional)
		/// Get the nodes uphill (driver) from the site_pin, pip, node or
		/// tile(s) provided in the -of_objects.
		/// </param>
		/// <param name="downhill">
		/// (Optional)
		/// Get the nodes downhill (loads) from the site_pin, pip, node
		/// or tile(s) provided in the -of_objects.
		/// </param>
		/// <param name="flyover">(Optional) Get the nodes that fly over the given tile(s).</param>
		/// <param name="from">
		/// (Optional)
		/// -from <pip/site pin> Return the nodes beginning at this pip
		/// or site pin. May be used in combination with uphill. Default
		/// is downhill. -all is implied.
		/// </param>
		/// <param name="to">
		/// (Optional)
		/// -to <pip/site pin> Return the nodes ending at this wire or
		/// site pin. May be used in combination with uphill. Default is
		/// downhill. -all is implied.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'node' objects against patterns. Default: *</param>
		/// <returns>nodes</returns>
		public TTCL get_nodes(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? uphill = null, bool? downhill = null, bool? flyover = null, string from = null, string to = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_nodes [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-uphill] [-downhill] [-flyover] [-from <args>] [-to <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_nodes(of_objects, regexp, nocase, filter, uphill, downhill, flyover, from, to, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of package pins
		///
		///
		/// TCL Syntax: get_package_pins [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of the pins on the selected package for the target device. The default command gets a
		/// list of all pins on the package.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example gets a list of the package pins associated with the specified bytegroup of
		/// an UltraScale device:
		/// get_package_pins -of [get_pkgpin_bytegroups BANK44_BYTE0]
		/// The following example gets the number of clock capable (CC) pins on the package:
		/// llength [get_package_pins -filter {IS_CLK_CAPABLE==1}]
		/// Note: If there are no pins matching the pattern you will get a warning.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 855
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get the list of package pin objects of these sites, bels,
		/// iobanks, pkgpin_bytegroups, pkgpin_nibbles, or ports.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match list of package pin objects against patterns Default: *</param>
		/// <returns>list of package pin objects</returns>
		public TTCL get_package_pins(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_package_pins [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_package_pins(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of path groups in the current design
		///
		///
		/// TCL Syntax: get_path_groups [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of timing path groups in the current project that match a specified search pattern. The
		/// default command gets a list of all path groups in the design.
		/// Path groups are automatically created when a new clock is created in the design, containing all
		/// paths in that clocks domain. Path groups can also be manually created with the use of the
		/// group_path command.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example gets a list of all the path groups in the design.
		/// get_path_groups
		/// The following example gets all path groups with the string "Clk" somewhere in the name:
		/// get_path_groups *Clk*
		/// Note: If no path groups match the pattern you will get a warning.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 866
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match path group names against patterns Default: *</param>
		/// <returns>list of path groups</returns>
		public TTCL get_path_groups(bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_path_groups [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_path_groups(regexp, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of Pblocks in the current design
		///
		///
		/// TCL Syntax: get_pblocks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-include_nested_pblocks] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of Pblocks defined in the current project that match a specific pattern. The default
		/// command gets a list of all Pblocks in the project.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example gets a list of all Pblocks in the current project:
		/// get_pblocks
		/// This example gets a list of all Pblocks which do not have a Slice Range defined:
		/// get_pblocks -filter {GRIDTYPES !~ SLICE}
		/// The following example gets the Pblock assignments of the specified cell:
		/// get_pblocks -of [get_cells CORE/BR_TOP/RLD67_MUX/REG_PMBIST_C1]
		/// This example returns the specified Pblock, including any nested Pblocks:
		/// get_pblocks -include_nested_pblocks usbTop
		///
		/// See ug835-vivado-tcl-commands.pdf, page 868
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get Pblocks of these cells</param>
		/// <param name="include_nested_pblocks">(Optional) Display the the list of nested pblocks</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match Pblock names against patterns Default: *</param>
		/// <returns>list of Pblock objects</returns>
		public TTCL get_pblocks(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? include_nested_pblocks = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_pblocks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-include_nested_pblocks] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pblocks(regexp, nocase, filter, of_objects, include_nested_pblocks, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of pins in the current design
		///
		///
		/// TCL Syntax: get_pins [-hsc <arg>] [-hierarchical] [-regexp] [-nocase] [-leaf] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-include_replicated_objects] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of pin objects in the current design that match a specified search pattern. The default
		/// command gets a list of all pins in the current_instance of the open design, as specified by the
		/// current_instance command. You can use the -hierarchical option to extract pins from
		/// the hierarchy of the current design.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// IMPORTANT! Because there are so many pins in the design, the get_pins command can cause
		/// performance issues, and add significant time to processing design constraints. In many cases, a design
		/// constraint that is written with the get_pins command can be rewritten using the get_cells
		/// command, as shown in the examples, to significantly improve constraint processing and performance of the
		/// Vivado tool.
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
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// This example runs the report_drc command on the current design, and then returns any pins
		/// associated with DRC violations:
		/// report_drc -name drc_1
		/// get_pins -of_objects [get_drc_violations]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 871
		/// </summary>
		/// <param name="hsc">(Optional) Hierarchy separator Default: /</param>
		/// <param name="hierarchical">(Optional) Search level-by-level in current instance</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="leaf">(Optional) Get leaf/global pins of nets with -of_objects</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get pins of these cells, nets, timing paths, clocks, drc violations</param>
		/// <param name="match_style">(Optional) Style of pattern matching, valid values are ucf, sdc Default: sdc</param>
		/// <param name="include_replicated_objects">
		/// (Optional)
		/// Include replicated objects when searching for patterns. This
		/// option is valid only when patterns is specified.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match pin names against patterns Default: *</param>
		/// <returns>list of pin objects</returns>
		public TTCL get_pins(string hsc = null, bool? hierarchical = null, bool? regexp = null, bool? nocase = null, bool? leaf = null, string filter = null, string of_objects = null, string match_style = null, bool? include_replicated_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_pins [-hsc <arg>] [-hierarchical] [-regexp] [-nocase] [-leaf] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-include_replicated_objects] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pins(hsc, hierarchical, regexp, nocase, leaf, filter, of_objects, match_style, include_replicated_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of programmable interconnect points (pips) on the current device.
		///
		///
		/// TCL Syntax: get_pips [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-uphill] [-downhill] [-from <args>] [-to <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Programmable interconnect points, or PIPs, provide the physical routing paths on the device used
		/// to connect logic networks. This command returns a list of PIPs on the device that match a
		/// specified search pattern. The command requires a design to be open.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The default command gets a list of all PIPs on the device. However, this is not a recommended
		/// use of the command due to the number of pips on a device. You should specify the -
		/// of_objects argument to limit the number of pips returned.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example returns the PIPs associated with the specified tile:
		/// get_pips -of_object [get_tiles DSP_R_X9Y75]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 876
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the pips of these sites, tiles, wires, nodes, pips, or nets.</param>
		/// <param name="uphill">(Optional) Get the pips uphill from the provided wire or pip.</param>
		/// <param name="downhill">(Optional) Get the pips downhill from the provided wire or pip.</param>
		/// <param name="from">
		/// (Optional)
		/// -from <pip/site pin> Return the ordered list of pips
		/// beginning at this pip or site pin. May be used in
		/// combination with uphill. Default is downhill. -all is implied.
		/// </param>
		/// <param name="to">
		/// (Optional)
		/// -to <pip/site pin> Return the ordered list of pips ending at
		/// this wire or site pin. May be used in combination with uphill.
		/// Default is downhill. -all is implied.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match pips against patterns Default: *</param>
		/// <returns>pips</returns>
		public TTCL get_pips(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? uphill = null, bool? downhill = null, string from = null, string to = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_pips [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-uphill] [-downhill] [-from <args>] [-to <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pips(regexp, nocase, filter, of_objects, uphill, downhill, from, to, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of package pin byte groups.
		///
		///
		/// TCL Syntax: get_pkgpin_bytegroups [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of the byte groups on the I/O banks of the current Xilinx UltraScale device.
		/// For 7 series devices, the hierarchy of IO Banks is divided into two object types: I/O Banks and
		/// Package Pins. For Xilinx UltraScale FPGA devices, the IO Bank hierarchy includes two additional
		/// divisions: Byte groups and Nibbles.
		/// The relationships of these objects on an UltraScale device are defined as follows:
		/// • An iobank has 2 or 4 bytegroups.
		/// • Each pkgpin_bytegroup has 2 nibbles, an upper and lower, and has 13 package pins.
		/// • Each pkgpin_nibble has 6 or 7 pins, and is the upper or lower nibble of the pkgpin_bytegroup.
		/// • A package_pin is one pin of an iobank, a pkgpin_bytegroup, or a pkgpin_nibble.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of all pins on the package of the target device:
		/// get_pkgpin_bytegroups -of [get_iobanks 44]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 880
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the pin_group of these package_pins, iobank, site, or port.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match pin_group against patterns Default: *</param>
		/// <returns>pin_group</returns>
		public TTCL get_pkgpin_bytegroups(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_pkgpin_bytegroups [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pkgpin_bytegroups(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of pkgpin nibbles.
		///
		///
		/// TCL Syntax: get_pkgpin_nibbles [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Return a list of nibbles, or half-bytes, on the I/O banks of the current Xilinx UltraScale device.
		/// For 7 series devices, the hierarchy of IO Banks is divided into two object types: I/O Banks and
		/// Package Pins. For Xilinx UltraScale FPGA devices, the IO Bank hierarchy includes two additional
		/// divisions: Byte groups and Nibbles.
		/// The relationships of these objects on an UltraScale device are defined as follows:
		/// • An iobank has 2 or 4 bytegroups.
		/// • Each pkgpin_bytegroup has 2 nibbles, an upper and lower, and has 13 package pins.
		/// • Each pkgpin_nibble has 6 or 7 pins, and is the upper or lower nibble of the pkgpin_bytegroup.
		/// • A package_pin is one pin of an iobank, a pkgpin_bytegroup, or a pkgpin_nibble.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example returns the Upper nibbles associated with the specified IO bank:
		/// get_pkgpin_nibbles -of [get_iobanks 44] -filter {TYPE == U}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 883
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the pin_nibble of these package_pins, iobank, site, or port.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match pin_nibble against patterns Default: *</param>
		/// <returns>pin_nibble</returns>
		public TTCL get_pkgpin_nibbles(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_pkgpin_nibbles [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pkgpin_nibbles(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of ports in the current design
		///
		///
		/// TCL Syntax: get_ports [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-scoped_to_current_instance] [-no_traverse] [-prop_thru_buffers] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of port objects in the current design that match a specified search pattern. The default
		/// command gets a list of all ports in the design.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of pins attached to the specified cell:
		/// get_ports -of_objects [lindex [get_cells] 1]
		/// Note: If there are no ports matching the pattern, the tool will return a warning.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
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
		/// See ug835-vivado-tcl-commands.pdf, page 886
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get ports of these nets, instances, sites, clocks, timing paths,
		/// io standards, io banks, package pins, drc violations
		/// </param>
		/// <param name="match_style">(Optional) Style of pattern matching, valid values are ucf, sdc Default: sdc</param>
		/// <param name="scoped_to_current_instance">
		/// (Optional)
		/// Match patterns on instance pins specified using current
		/// instance, and then find top level connected ports.
		/// </param>
		/// <param name="no_traverse">(Optional) Do not traverse to find top level terminals.</param>
		/// <param name="prop_thru_buffers">
		/// (Optional)
		/// Allow propagate through buffers when traversing to find
		/// top level terminals connected to pins of scoped instance.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match port names against patterns Default: *</param>
		/// <returns>list of port objects</returns>
		public TTCL get_ports(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, string match_style = null, bool? scoped_to_current_instance = null, bool? no_traverse = null, bool? prop_thru_buffers = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_ports [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-scoped_to_current_instance] [-no_traverse] [-prop_thru_buffers] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_ports(regexp, nocase, filter, of_objects, match_style, scoped_to_current_instance, no_traverse, prop_thru_buffers, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of Power Rails in the current design
		///
		///
		/// TCL Syntax: get_power_rails [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 890
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match Power rail names against patterns Default: *</param>
		/// <returns>list of power rail objects</returns>
		public TTCL get_power_rails(bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_power_rails [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_power_rails(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get properties of object
		///
		///
		/// TCL Syntax: get_property [-min] [-max] [-quiet] [-verbose] <name> <object>
		///
		/// Gets the current value of the named property from the specified object or objects. If multiple
		/// objects are specified, a list of values is returned.
		/// If the property is not currently assigned to the object, or is assigned without a value, then the
		/// get_property command returns nothing, or the null string. If multiple objects are queried, the
		/// null string is added to the list of values returned.
		/// If multiple objects are passed to the get_property command, you can use the -min or -max
		/// options to return the smallest or greatest value of the property specified by name. This feature
		/// can be useful when setting timing constraints.
		/// RECOMMENDED: For numeric properties, the min/max determination is based on numeric values. For all
		/// other properties, the determination is based on string sorting.
		/// This command returns a value, or list of values, or returns an error if it fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example gets the NAME property from the specified cell:
		/// get_property NAME [lindex [get_cells] 3]
		/// The following example returns the smallest PERIOD property from the specified clock objects:
		/// get_property -min PERIOD [get_clocks]
		/// This example demonstrates the string based sorting of the SITE property for the specified ports:
		/// get_property SITE [get_ports]
		/// IOB_X1Y75 IOB_X1Y76 IOB_X1Y98 IOB_X1Y125 IOB_X0Y94 IOB_X1Y95 IOB_X1Y96
		/// IOB_X1Y93 IOB_X1Y94
		/// get_property -min SITE [get_ports]
		/// IOB_X0Y94
		/// get_property -max SITE [get_ports]
		/// IOB_X1Y98
		/// Note: While IOB_X1Y125 is the largest site value on the port objects, the property value IOB_X1Y98 is
		/// returned because of the sorting of the property values as strings.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 901
		/// </summary>
		/// <param name="name">(Required) Name of property whose value is to be retrieved</param>
		/// <param name="@object">(Required) Object to query for properties</param>
		/// <param name="min">(Optional) Return only the minimum value</param>
		/// <param name="max">(Optional) Return only the maximum value</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>property value</returns>
		public TTCL get_property(string name, string @object, bool? min = null, bool? max = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_property [-min] [-max] [-quiet] [-verbose] <name> <object>
			_tcl.Entry(_builder.get_property(name, @object, min, max, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of site_pins.
		///
		///
		/// TCL Syntax: get_site_pins [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns a list of site pins of the specified site, node, logical cell pin, or net objects in an open
		/// design.
		/// This command recommends the use of the -of_objects argument to prevent high run times
		/// and compute resources.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example returns the site_pins of the specified Nets:
		/// get_site_pins -of_objects [get_nets *Clk]
		/// IOB_X1Y24/I
		/// The following example returns the output site_pins associated with the site SLICE_X21Y92:
		/// get_site_pins -of_objects [get_sites SLICE_X21Y92] -filter
		/// {DIRECTION==OUT}
		/// SLICE_X21Y92/A SLICE_X21Y92/AMUX SLICE_X21Y92/AQ
		/// SLICE_X21Y92/B SLICE_X21Y92/BMUX SLICE_X21Y92/BQ
		/// SLICE_X21Y92/C SLICE_X21Y92/CMUX SLICE_X21Y92/COUT
		/// SLICE_X21Y92/CQ SLICE_X21Y92/D SLICE_X21Y92/DMUX
		/// SLICE_X21Y92/DQ
		///
		/// See ug835-vivado-tcl-commands.pdf, page 923
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'site_pin' objects of these types: 'site xdef_site node pin
		/// net bel_pin'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'site_pin' objects against patterns. Default: *</param>
		/// <returns>site_pins</returns>
		public TTCL get_site_pins(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_site_pins [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_site_pins(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of site_pips from the given object.
		///
		///
		/// TCL Syntax: get_site_pips [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Programmable interconnect points, or PIPs, provide the physical routing paths on the device used
		/// to connect logic networks. This command returns a list of PIPs on specified sites that match a
		/// specified search pattern. The command requires a design to be open.
		/// This command requires the use of the -of_objects option to specify the sites to return PIPs
		/// from.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example returns the pins of the specified BELs associated with the specified range
		/// of sites on the device:
		/// get_site_pips -of_objects [get_sites SLICE_X21Y92]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 926
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the site_pips of these sites.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match site_pips against patterns Default: *</param>
		/// <returns>site_pips</returns>
		public TTCL get_site_pips(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_site_pips [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_site_pips(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of Sites
		///
		///
		/// TCL Syntax: get_sites [-regexp] [-filter <arg>] [-nocase] [-range <args>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of sites on the target device that match a specified search pattern. The default
		/// command gets a list of all sites on the target device.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example gets a list of all sites available on the target device:
		/// get_sites
		/// The following example returns the number of sites that are not currently used on the device.
		/// Both command forms in the example return the same results. The second command directly
		/// evaluates the IS_USED boolean property:
		/// llength [get_sites -filter {IS_USED==0}]
		/// -or￾llength [get_sites -filter !IS_USED]
		/// Note: If no sites match the pattern you will get a warning.
		/// The following example gets all of the sites on the device, and returns the unique SITE_TYPEs:
		/// set sites [get_sites]
		/// set type {}
		/// foreach x $sites {
		/// set prop [get_property SITE_TYPE $x]
		/// if { [lsearch -exact $type $prop] == -1 } {
		/// lappend type $prop
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// }
		/// }
		/// foreach y $type {
		/// puts "SITE_TYPE: $y"
		/// }
		/// The following example shows three different forms for specifying the range of sites to return:
		/// get_sites -range {SLICE_X0Y0 SLICE_X1Y1}
		/// SLICE_X0Y0 SLICE_X0Y1 SLICE_X1Y0 SLICE_X1Y1
		/// get_sites -range SLICE_X0Y0 -range SLICE_X1Y1
		/// SLICE_X0Y0 SLICE_X0Y1 SLICE_X1Y0 SLICE_X1Y1
		/// get_sites -range {SLICE_X0Y0:SLICE_X1Y1}
		/// SLICE_X0Y0 SLICE_X0Y1 SLICE_X1Y0 SLICE_X1Y1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 929
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="range">
		/// (Optional)
		/// Match site names which fall into the range. Range is defined
		/// by exactly two site names.
		/// </param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get the sites of slrs, tiles, bels, pins, package_pins, ports,
		/// pblocks, nets, site_types, io_banks, cells, clock_regions or
		/// drc_violation
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// Match site names against patterns. Bonded sites will also
		/// match on package pin names. Default: *
		/// </param>
		/// <returns>list of site objects</returns>
		public TTCL get_sites(bool? regexp = null, string filter = null, bool? nocase = null, string range = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_sites [-regexp] [-filter <arg>] [-nocase] [-range <args>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_sites(regexp, filter, nocase, range, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of slrs.
		///
		///
		/// TCL Syntax: get_slrs [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Get a list of the super logic regions (SLRs) on the target device. On Devices that do not contain
		/// multiple SLRs, the SLR0 is returned.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example highlights each of the SLRs on the target device in a different color:
		/// foreach x [get_slrs] {
		/// incr i
		/// highlight_objects -color_index $i $x
		/// }
		/// Note: If there are no cells matching the pattern you will get a warning.
		/// The following example returns the number of super long lines (SLLs) between super logic regions
		/// on the current device:
		/// get_property NUM_SLLS [get_slrs SLR0]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 933
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get the slr of these device, tiles, sites, bels, sitepins, belpins,
		/// clock region, node, pip, pin, package pin, iobank, cell.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match slr against patterns Default: *</param>
		/// <returns>slr</returns>
		public TTCL get_slrs(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_slrs [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_slrs(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of speed_models in the device.
		///
		///
		/// TCL Syntax: get_speed_models [-of_objects <args>] [-regexp] [-nocase] [-patterns <arg>] [-filter <arg>] [-speed_pattern <arg>] [-quiet] [-verbose]
		///
		/// Get speed models for UltraScale architecture device resources in the current design.
		/// Speed files are provided by Xilinx for each device and speed grade. Speed files contain speed
		/// models. There are speed models for the various elements of a device: nodes, pips, bels. There are
		/// speed models for setup and hold, propagation delays, jitter, etc.
		/// The speed models include information on the delays in nanoseconds (ns) associated with device
		/// resources like BELs and SITEs and routing resources. Speed models are used by the Vivado
		/// timing engine to perform analysis of the current design in the context of the target part.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The objects returned are the speed models associated with specific physical resources like pips
		/// and wires, drawn directly from the speed files. These can include capacitance and resistance
		/// values and buffer models.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		/// This command returns the specified speed model objects, or returns an error if the command
		/// fails.
		///
		/// The following example reports the properties on the speed model for an A6LUT:
		/// report_property -all [lindex [get_speed_models -of \
		/// [get_bels SLICE_X0Y0/A6LUT]] 0]
		/// Property Type Read-only Value
		/// CLASS string true speed_model
		/// DELAY double true 0.043
		/// FAST_MAX double true 0.035
		/// FAST_MIN double true 0.028
		/// IS_INSTANCE_SPECIFIC bool true 1
		/// NAME string true bel_d_lut6_a1_o6
		/// NAME_LOGICAL string true bel_d_lut6_a1_o6
		/// SLOW_MAX double true 0.043
		/// SLOW_MIN double true 0.036
		/// SPEED_INDEX int true 65535
		/// TYPE string true bel_delay
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The following example returns the delays, in nanoseconds, for a specific A6LUT on the device,
		/// followed by the delay name for the specified object:
		/// set x [get_speed_models -of [get_bels SLICE_X0Y0/A6LUT]]
		/// puts [format "%6.3f : %s" [get_property DELAY [lindex $x 0 ]] \
		/// [get_property NAME [lindex $x 0 ]]]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 936
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'speed_model' objects of these types: 'node bel pip cell'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="patterns">(Optional) Match the 'speed_model' objects against patterns. Default: *</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="speed_pattern">(Optional) Returns a single model that exactly matches the pattern.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>speed_models</returns>
		public TTCL get_speed_models(string of_objects = null, bool? regexp = null, bool? nocase = null, string patterns = null, string filter = null, string speed_pattern = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_speed_models [-of_objects <args>] [-regexp] [-nocase] [-patterns <arg>] [-filter <arg>] [-speed_pattern <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_speed_models(of_objects, regexp, nocase, patterns, filter, speed_pattern, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of tiles.
		///
		///
		/// TCL Syntax: get_tiles [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// This command returns a list of tiles on the device in an open design. The default command gets a
		/// list of all tiles on the device.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example returns the total number of tiles where the number of timing arcs is
		/// greater than 100 and 150 respectively:
		/// llength [get_tiles -filter {NUM_ARCS>100} ]
		/// 13468
		/// llength [get_tiles -filter {NUM_ARCS>150} ]
		/// 11691
		///
		/// See ug835-vivado-tcl-commands.pdf, page 943
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get the tiles of these slr, sites, bels, site_pins, bel_pins,
		/// nodes, wires, pips, nets, clock_regions.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match tiles against patterns Default: *</param>
		/// <returns>tiles</returns>
		public TTCL get_tiles(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_tiles [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_tiles(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of timing arcs
		///
		///
		/// TCL Syntax: get_timing_arcs [-from <args>] [-to <args>] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose]
		///
		/// Gets a list of timing arcs for the specified objects. You can filter the timing arcs according to
		/// specified properties.
		/// Timing arcs are a part of a timing path. A timing arc can be a wire between two pins, or can be
		/// the internal path of a logic instance between an input pin and output pin, or clock input and data
		/// output pins.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example returns the timing arc from the output pin of the specified buffer:
		/// report_property -all [get_timing_arcs -of_objects [get_cells go_IBUF_inst]]
		/// The following example returns the timing arcs of the specified cell:
		/// get_timing_arcs -of_objects [get_cells count_reg[6]]
		/// {count_reg[6]/C --> count_reg[6]/Q [Reg Clk to Q] }
		/// {count_reg[6]/C --> count_reg[6]/D [setup] }
		/// {count_reg[6]/C --> count_reg[6]/D [hold] }
		/// {count_reg[6]/C --> count_reg[6]/CLR [recovery] }
		/// {count_reg[6]/C --> count_reg[6]/CE [hold] }
		/// {count_reg[6]/C --> count_reg[6]/CLR [removal] }
		/// {count_reg[6]/C --> count_reg[6]/CE [setup] }
		/// {count_reg[6]/CLR --> count_reg[6]/Q [Reg Set/Clr] }
		///
		/// See ug835-vivado-tcl-commands.pdf, page 946
		/// </summary>
		/// <param name="from">(Optional) List of pin or ports</param>
		/// <param name="to">(Optional) List of pin or ports</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get timing arcs for these cells</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of timing arc objects</returns>
		public TTCL get_timing_arcs(string from = null, string to = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_timing_arcs [-from <args>] [-to <args>] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_timing_arcs(from, to, filter, of_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of wires.
		///
		///
		/// TCL Syntax: get_wires [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-uphill] [-downhill] [-from <args>] [-to <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns a list of wires in the design that match a specified search pattern in an open design.
		/// The default command gets a list of all wires in the design.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example returns the wires associated with the specified tile:
		/// get_wires -of_objects [get_tiles IO_INT_INTERFACE_L_X0Y198]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 964
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the wires of these tiles, nodes, pips, or nets.</param>
		/// <param name="uphill">(Optional) Get the wires uphill from the provided pip.</param>
		/// <param name="downhill">(Optional) Get the wires downhill from the provided pip.</param>
		/// <param name="from">
		/// (Optional)
		/// -from <pip/site pin> Return the ordered list of wires
		/// beginning at this pip or site pin. May be used in
		/// combination with uphill. Default is downhill. -all is implied.
		/// </param>
		/// <param name="to">
		/// (Optional)
		/// -to <pip/site pin> Return the ordered list of wires ending at
		/// this wire or site pin. May be used in combination with uphill.
		/// Default is downhill. -all is implied.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match wires against patterns Default: *</param>
		/// <returns>wires</returns>
		public TTCL get_wires(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? uphill = null, bool? downhill = null, string from = null, string to = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_wires [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-uphill] [-downhill] [-from <args>] [-to <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_wires(regexp, nocase, filter, of_objects, uphill, downhill, from, to, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Groups paths for cost function calculations
		///
		///
		/// TCL Syntax: group_path [-name <args>] [-weight <arg>] [-default] [-from <args>] [-to <args>] [-through <args>] [-quiet] [-verbose]
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
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
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
		/// See ug835-vivado-tcl-commands.pdf, page 969
		/// </summary>
		/// <param name="name">(Optional) The name of group, can be multiple names</param>
		/// <param name="weight">(Optional) Cost function Weight, Valid values are 1, 2 Default: 1.0</param>
		/// <param name="@default">(Optional) Restore path to its default group</param>
		/// <param name="from">(Optional) Filter by paths starting at these path startpoints</param>
		/// <param name="to">(Optional) Filter by paths terminating at these path endpoints</param>
		/// <param name="through">(Optional) Consider paths through pins, cells or nets</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL group_path(string name = null, string weight = null, bool? @default = null, string from = null, string to = null, string through = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: group_path [-name <args>] [-weight <arg>] [-default] [-from <args>] [-to <args>] [-through <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.group_path(name, weight, @default, from, to, through, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Make differential pair for 2 ports
		///
		///
		/// TCL Syntax: make_diff_pair_ports [-quiet] [-verbose] <ports>...
		///
		/// Joins two existing ports to create a differential pair. The port directions, interfaces, and other
		/// properties must match in order for the specified ports to be joined as a differential pair.
		/// Otherwise an error will be returned.
		/// IMPORTANT! The two ports must first be created, either by using the create_port command or by
		/// reading in an XDC file, prior to making them into a differential pair.
		///
		/// The following example joins the two specified ports to create a differential pair:
		/// make_diff_pair_ports port_Pos1 port_Neg1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1057
		/// </summary>
		/// <param name="ports">(Required) Ports to join</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL make_diff_pair_ports(string ports, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: make_diff_pair_ports [-quiet] [-verbose] <ports>...
			_tcl.Entry(_builder.make_diff_pair_ports(ports, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Remove cells from a Pblock
		///
		///
		/// TCL Syntax: remove_cells_from_pblock [-quiet] [-verbose] <pblock> <cells>...
		///
		/// Removes the specified logic instances from a Pblock. Cells are added to a Pblock with the
		/// add_cells_to_pblock command.
		/// Note: Cells that have been placed will not be unplaced as they are removed from a Pblock. Any current
		/// LOC assignments are left intact.
		///
		/// The following example removes the specified cells from the pb_cpuEngine Pblock:
		/// remove_cells_from_pblock pb_cpuEngine [get_cells cpuEngine/cpu_dwb_dat_o/*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1237
		/// </summary>
		/// <param name="pblock">(Required) Pblock to remove cells from</param>
		/// <param name="cells">(Required) Cells to remove</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_cells_from_pblock(string pblock, string cells, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_cells_from_pblock [-quiet] [-verbose] <pblock> <cells>...
			_tcl.Entry(_builder.remove_cells_from_pblock(pblock, cells, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Remove power sources from Power Rail
		///
		///
		/// TCL Syntax: remove_from_power_rail [-power_sources <args>] [-quiet] [-verbose] <power_rail>
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1251
		/// </summary>
		/// <param name="power_rail">(Required) Power rail to remove power sources from</param>
		/// <param name="power_sources">
		/// (Optional)
		/// List of power sources to remove. Can be power rails and/or
		/// power supplies
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_from_power_rail(string power_rail, string power_sources = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_from_power_rail [-power_sources <args>] [-quiet] [-verbose] <power_rail>
			_tcl.Entry(_builder.remove_from_power_rail(power_rail, power_sources, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Reset operating conditions to tool default for power estimation
		///
		///
		/// TCL Syntax: reset_operating_conditions [-voltage <args>] [-grade] [-process] [-junction_temp] [-ambient_temp] [-thetaja] [-thetasa] [-airflow] [-heatsink] [-thetajb] [-board] [-board_temp] [-board_layers] [-design_power_budget] [-supply_current_budget <args>] [-quiet] [-verbose]
		///
		/// Resets the specified operating conditions to their default values. If no operating conditions are
		/// specified, all operating conditions are reset to their default values.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Operating conditions can be set using the set_operating_conditions command. The
		/// current values can be determined using the report_operating_conditions command. The
		/// environmental operating conditions of the device are used for power analysis when running the
		/// report_power command, but are not used during timing analysis.
		/// Note: This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example resets all the operating conditions for the design to their default setting:
		/// reset_operating_conditions
		/// The following example resets the junction, ambient, and board temperature for the design to
		/// their default settings:
		/// reset_operating_conditions -junction_temp -ambient_temp -board_temp
		/// The following example resets the voltage supply Vccint to its default value:
		/// reset_operating_conditions -voltage Vccint
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1504
		/// </summary>
		/// <param name="voltage">(Optional) Resets voltage value. Supported voltage supplies vary by family.</param>
		/// <param name="grade">(Optional) Resets temperature grade</param>
		/// <param name="process">(Optional) Resets process</param>
		/// <param name="junction_temp">(Optional) Resets Junction Temperature</param>
		/// <param name="ambient_temp">(Optional) Resets Ambient Temperature</param>
		/// <param name="thetaja">(Optional) Resets ThetaJA</param>
		/// <param name="thetasa">(Optional) Resets ThetaSA</param>
		/// <param name="airflow">(Optional) Resets Airflow</param>
		/// <param name="heatsink">(Optional) Resets dimensions of heatsink</param>
		/// <param name="thetajb">(Optional) Resets ThetaJB</param>
		/// <param name="board">(Optional) Resets Board type</param>
		/// <param name="board_temp">(Optional) Resets Board Temperature</param>
		/// <param name="board_layers">(Optional) Resets Board layers</param>
		/// <param name="design_power_budget">(Optional) Design Power Budget (W)</param>
		/// <param name="supply_current_budget">
		/// (Optional)
		/// Resets list of supply current budget 'name value' pairs.
		/// Supported voltage supplies vary by family.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_operating_conditions(string voltage = null, bool? grade = null, bool? process = null, bool? junction_temp = null, bool? ambient_temp = null, bool? thetaja = null, bool? thetasa = null, bool? airflow = null, bool? heatsink = null, bool? thetajb = null, bool? board = null, bool? board_temp = null, bool? board_layers = null, bool? design_power_budget = null, string supply_current_budget = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_operating_conditions [-voltage <args>] [-grade] [-process] [-junction_temp] [-ambient_temp] [-thetaja] [-thetasa] [-airflow] [-heatsink] [-thetajb] [-board] [-board_temp] [-board_layers] [-design_power_budget] [-supply_current_budget <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.reset_operating_conditions(voltage, grade, process, junction_temp, ambient_temp, thetaja, thetasa, airflow, heatsink, thetajb, board, board_temp, board_layers, design_power_budget, supply_current_budget, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Reset switching activity on specified objects
		///
		///
		/// TCL Syntax: reset_switching_activity [-default] [-type <args>] [-hier] [-all] [-no_deassert_resets] [-quiet] [-verbose] [<objects>...]
		///
		/// Resets the attributes of the switching activity on specified nets, ports, pins, and cells in the
		/// design.
		/// The switching activity is defined using the set_switching_activity command. The current
		/// switching activity defined for a specific port, pin, net, or cell can be found by using the
		/// report_switching_activity command.
		/// Note: The reset_switching_activity is used to reset switching activity for specified objects. Use
		/// set_switching_activity -default_toggle_rate or -default_static_probability to
		/// change or reset the default values for the current design.
		/// This command operates silently and does not return direct feedback of its operation.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example resets the signal_rate and static probability value on all output ports:
		/// reset_switching_activity -default [all_outputs]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1518
		/// </summary>
		/// <param name="@default">(Optional) Reset default static probability and default toggle rate</param>
		/// <param name="type">
		/// (Optional)
		/// Specify nodes in a specific category. List of valid type values:
		/// io_output, io_bidir_enable, register, lut_ram, lut, dsp,
		/// bram_enable, bram_wr_enable, gt_txdata, gt_rxdata.
		/// </param>
		/// <param name="hier">
		/// (Optional)
		/// Hierarchically resets the switching activity on a hierarchical
		/// cells provided as <objects>.
		/// </param>
		/// <param name="all">(Optional) Reset switching activity on all nets</param>
		/// <param name="no_deassert_resets">
		/// (Optional)
		/// A switch to undo the deassertion of resets via command
		/// set_switching_activity -deassert_resets
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">(Optional) Objects to reset switching activity on</param>
		public TTCL reset_switching_activity(bool? @default = null, string type = null, bool? hier = null, bool? all = null, bool? no_deassert_resets = null, bool? quiet = null, bool? verbose = null, string objects = null)
		{
			// TCL Syntax: reset_switching_activity [-default] [-type <args>] [-hier] [-all] [-no_deassert_resets] [-quiet] [-verbose] [<objects>...]
			_tcl.Entry(_builder.reset_switching_activity(@default, type, hier, all, no_deassert_resets, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// Move, resize, add and remove Pblock site-range constraints
		///
		///
		/// TCL Syntax: resize_pblock [-add <args>] [-remove <args>] [-from <args>] [-to <args>] [-replace] [-locs <arg>] [-quiet] [-verbose] <pblock>
		///
		/// Place, resize, move, or remove the specified Pblock. The Pblock must have been created using
		/// the create_pblock command.
		/// A Pblock consists of a group of cells that can be assigned to one or more independent or
		/// overlapping rectangles. Using the various options defined below, you can add sites to a rectangle,
		/// or remove sites from a rectangle, or define a new rectangle to be associated with an existing
		/// Pblock.
		///
		/// The following example resizes the Pblock by adding a range of SLICEs, and removing other
		/// SLICEs, but keeps all instances placed at their current location:
		/// resize_pblock block3 -add SLICE_X6Y67:SLICE_X11Y71 \
		/// -remove SLICE_X6Y71:SLICE_X7Y71 -locs keep_all
		/// This example create a Pblock region, and defines the Pblock area by adding a range of
		/// CLOCKREGIONs:
		/// create_pblock pblock_1
		/// resize_pblock pblock_1 -add {CLOCKREGION_X0Y10:CLOCKREGION_X1Y11}
		/// The following example moves the specified Pblock by adding a range of SLICEs, removing the
		/// existing range of SLICEs, and trims any placed logic that falls outside the new Pblock. Then it
		/// adds a new range of SLICEs and block ram to the specified Pblock in a second separate rectangle:
		/// resize_pblock block3 -add SLICE_X3Y8:SLICE_X10Y3 \
		/// -remove SLICE_X6Y67:SLICE_X11Y71 -locs trim
		/// resize_pblock block3 -add {SLICE_X6Y67:SLICE_X11Y71 \
		/// RAMB18_X0Y2:RAMB18_X1Y4}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1527
		/// </summary>
		/// <param name="pblock">(Required) Pblock to resize</param>
		/// <param name="add">(Optional) Add site ranges(s)</param>
		/// <param name="remove">(Optional) Remove site ranges(s)</param>
		/// <param name="from">(Optional) Site range(s) to move</param>
		/// <param name="to">(Optional) Site range destination(s)</param>
		/// <param name="replace">(Optional) Remove all existing ranges</param>
		/// <param name="locs">(Optional) LOC treatment Default: keep_all</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL resize_pblock(string pblock, string add = null, string remove = null, string from = null, string to = null, bool? replace = null, string locs = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: resize_pblock [-add <args>] [-remove <args>] [-from <args>] [-to <args>] [-replace] [-locs <arg>] [-quiet] [-verbose] <pblock>
			_tcl.Entry(_builder.resize_pblock(pblock, add, remove, from, to, replace, locs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Define bus skew
		///
		///
		/// TCL Syntax: set_bus_skew [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-through <args>] [-rise_through <args>] [-fall_through <args>] [-quiet] [-verbose] <value>
		///
		/// Set the bus skew requirement on bus signals that cross clock domains. The bus skew constraint
		/// defines the maximum skew spread between the fastest and slowest signals of the bus, and does
		/// not consider the overall datapath delay. The Vivado router will try to satisfy the set_bus_skew
		/// constraints. Example uses of the bus skew constraint include clock domain crossing for gray￾coded pointers, MUX-controlled and MUX-data holding CDC buses.
		/// TIP: Bus skew constraints are not overridden by clock groups, max delay, or false path, because
		/// set_bus_skew is a constraint between the signals of a bus, rather than on a particular path.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The set_bus_skew constraint can be combined with the set_max_delay constraint for good
		/// results. The set_bus_skew constraint does not care about the absolute datapath delay, but
		/// only about the relative arrival times of data at the destination, taking into account source and
		/// destination clock skew. You can help set_bus_skew by also using set_max_delay -
		/// datapath_only <SRC_CLK>. This constraint helps the Vivado placer to ensure that the
		/// source and destination registers are not placed too far apart, so that the router can more easily
		/// satisfy the set_bus_skew constraint. Refer to the Vivado Design Suite User Guide: Using
		/// Constraints (UG903) for more information.
		/// In order to not over constrain the skew requirement, the bus skew value should be approximately
		/// the smallest period of the two clock domains. This will prevent multiple data captures by the
		/// destination clock domain.
		/// The set_bus_skew command requires a timing path defined by both -from and -to, or some
		/// form such as -fall_from or -rise_to. You can optionally specify -through values to
		/// further refine the path. You should specify explicit signal paths with -from/-to instead of
		/// specifying entire clock domains:
		/// • set_bus_skew -from [get_pins <hierarchy/C>] -to [get_pins
		/// <hierarchy/D>] <value>
		/// • set_bus_skew -from [get_clocks <clock name>] -to get_clocks <clock
		/// name>] <value>
		/// TIP: Do not set bus skew constraints between timed synchronous clock domains.
		/// You can use the report_bus_skew command to report the calculated skew on paths in the
		/// current design.
		/// The set_bus_skew command returns nothing if successful, or an error if it fails.
		///
		/// The following example defines the bus skew between the gray-coded Read and Write pointers:
		/// set_bus_skew -from [get_pins gray_coded_read_ptr[*]/C] \
		/// -to [get_pins gray_coded_write_ptr[*]/D] 2.5
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1592
		/// </summary>
		/// <param name="value">(Required) Constraint value</param>
		/// <param name="from">(Optional) List of path startpoints or clocks</param>
		/// <param name="rise_from">(Optional) Apply to paths rising from the list of startpoints or clocks</param>
		/// <param name="fall_from">(Optional) Apply to paths falling from the list of startpoints or clocks</param>
		/// <param name="to">(Optional) List of path endpoints or clocks</param>
		/// <param name="rise_to">(Optional) Apply to paths with rise transition at the list of endpoints or clocks</param>
		/// <param name="fall_to">(Optional) Apply to paths with fall transition at the list of endpoints or clocks</param>
		/// <param name="through">(Optional) List of through pins, cells or nets</param>
		/// <param name="rise_through">(Optional) Apply to paths rising through pins, cells or nets</param>
		/// <param name="fall_through">(Optional) Apply to paths falling through pins, cells or nets</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_bus_skew(string value, string from = null, string rise_from = null, string fall_from = null, string to = null, string rise_to = null, string fall_to = null, string through = null, string rise_through = null, string fall_through = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_bus_skew [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-through <args>] [-rise_through <args>] [-fall_through <args>] [-quiet] [-verbose] <value>
			_tcl.Entry(_builder.set_bus_skew(value, from, rise_from, fall_from, to, rise_to, fall_to, through, rise_through, fall_through, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Specify that an input is 1, 0, rising or falling
		///
		///
		/// TCL Syntax: set_case_analysis [-quiet] [-verbose] <value> <objects>
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
		/// See ug835-vivado-tcl-commands.pdf, page 1596
		/// </summary>
		/// <param name="value">
		/// (Required)
		/// Logic value on the pin: Values: 0, 1, rising, falling, zero, one,
		/// rise, fall
		/// </param>
		/// <param name="objects">(Required) List of ports or pins</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_case_analysis(string value, string objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_case_analysis [-quiet] [-verbose] <value> <objects>
			_tcl.Entry(_builder.set_case_analysis(value, objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Set exclusive or asynchronous clock groups
		///
		///
		/// TCL Syntax: set_clock_groups [-name <arg>] [-logically_exclusive] [-physically_exclusive] [-asynchronous] [-group <args>] [-quiet] [-verbose]
		///
		/// TIP: The XDC > Timing Constraints language templates and the Timing Constraints Wizard in the Vivado
		/// IDE offer timing diagrams and additional details around defining specific timing constraints. You can refer
		/// to these sources for additional information.
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
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// This command can also be used for multiple clocks that are derived from a single BUFGMUX as
		/// both of the clocks will not be active at the same time.
		/// Note: This command operates silently and does not return direct feedback of its operation.
		///
		/// Group all the elements driven by src_clk and sync_clk into separate clock groups. The clock
		/// groups are asynchronous to each other:
		/// set_clock_groups -group src_clk -group sync_clk -asynchronous
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
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
		/// See ug835-vivado-tcl-commands.pdf, page 1598
		/// </summary>
		/// <param name="name">(Optional) Name for clock grouping</param>
		/// <param name="logically_exclusive">(Optional) Specify logically exclusive clock groups</param>
		/// <param name="physically_exclusive">(Optional) Specify physically exclusive clock groups</param>
		/// <param name="asynchronous">(Optional) Specify asynchronous clock groups</param>
		/// <param name="group">(Optional) Clocks List</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_clock_groups(string name = null, bool? logically_exclusive = null, bool? physically_exclusive = null, bool? asynchronous = null, string group = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_clock_groups [-name <arg>] [-logically_exclusive] [-physically_exclusive] [-asynchronous] [-group <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.set_clock_groups(name, logically_exclusive, physically_exclusive, asynchronous, group, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Capture actual or predicted clock latency
		///
		///
		/// TCL Syntax: set_clock_latency [-clock <args>] [-rise] [-fall] [-min] [-max] [-source] [-late] [-early] [-quiet] [-verbose] <latency> <objects>
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
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// This example will set an early latency on the rising edge of CLK_A.
		/// set_clock_latency -source -rise -early 0.4 [get_ports CLK_A]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1601
		/// </summary>
		/// <param name="latency">(Required) Latency value</param>
		/// <param name="objects">(Required) List of clocks, ports or pins</param>
		/// <param name="clock">(Optional) List of relative clocks</param>
		/// <param name="rise">(Optional) Specify clock rise latency</param>
		/// <param name="fall">(Optional) Specify clock fall latency</param>
		/// <param name="min">(Optional) Specify clock rise and fall min condition latency</param>
		/// <param name="max">(Optional) Specify clock rise and fall max condition latency</param>
		/// <param name="source">(Optional) Specify clock rise and fall source latency</param>
		/// <param name="late">(Optional) Specify clock rise and fall late source latency</param>
		/// <param name="early">(Optional) Specify clock rise and fall early source latency</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_clock_latency(string latency, string objects, string clock = null, bool? rise = null, bool? fall = null, bool? min = null, bool? max = null, bool? source = null, bool? late = null, bool? early = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_clock_latency [-clock <args>] [-rise] [-fall] [-min] [-max] [-source] [-late] [-early] [-quiet] [-verbose] <latency> <objects>
			_tcl.Entry(_builder.set_clock_latency(latency, objects, clock, rise, fall, min, max, source, late, early, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Set clock sense on ports or pins
		///
		///
		/// TCL Syntax: set_clock_sense [-positive] [-negative] [-stop_propagation] [-clocks <args>] [-quiet] [-verbose] <pins>
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
		/// See ug835-vivado-tcl-commands.pdf, page 1604
		/// </summary>
		/// <param name="pins">(Required) List of port and/or pins</param>
		/// <param name="positive">(Optional) Specify positive unate (non_inverting) clock sense</param>
		/// <param name="negative">(Optional) Specify negative unate (inverting) clock sense</param>
		/// <param name="stop_propagation">(Optional) Stop clock propagation from specified pins</param>
		/// <param name="clocks">(Optional) List of clocks</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_clock_sense(string pins, bool? positive = null, bool? negative = null, bool? stop_propagation = null, string clocks = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_clock_sense [-positive] [-negative] [-stop_propagation] [-clocks <args>] [-quiet] [-verbose] <pins>
			_tcl.Entry(_builder.set_clock_sense(pins, positive, negative, stop_propagation, clocks, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// set clock uncertainty
		///
		///
		/// TCL Syntax: set_clock_uncertainty [-setup] [-hold] [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-quiet] [-verbose] <uncertainty> [<objects>]
		///
		/// This command is used to add to the uncertainty of a clock in the design, and does not override
		/// the default jitter calculation. This is referred to as the user clock uncertainty. The
		/// set_clock_uncertainty command provides a convenient means to over-constrain some
		/// clocks in the design without changing the clock definitions and relationships. It can constrain
		/// setup and hold paths separately using the -setup and -hold options.
		/// Clock uncertainty is the maximum variation, specified in nanoseconds (ns), between two clock
		/// edges at registers within a single clock domain, or crossing between clock domains.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
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
		/// INPUT_JITTER is also a property of primary clocks. These properties can be returned by the
		/// get_property or report_property commands. Jitter and clock uncertainty are reported by the
		/// report_timing_summary and report_timing commands.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example defines the uncertainty between all clock domains:
		/// set_clock_uncertainty 0.225 -from [get_clocks] -to [get_clocks]
		/// The following command defines setup and hold uncertainty within the wbClk clock domain:
		/// set_clock_uncertainty -setup 0.213 [get_clocks wbClk]
		/// set_clock_uncertainty -hold 0.167 [get_clocks wbClk]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1606
		/// </summary>
		/// <param name="uncertainty">(Required) Uncertainty of clock network</param>
		/// <param name="setup">(Optional) Specify clock uncertainty for setup checks</param>
		/// <param name="hold">(Optional) Specify clock uncertainty for hold checks</param>
		/// <param name="from">(Optional) Specify inter-clock uncertainty source clock</param>
		/// <param name="rise_from">(Optional) Specify inter-clock uncertainty source clock with rising edge</param>
		/// <param name="fall_from">(Optional) Specify inter-clock uncertainty source clock with falling edge</param>
		/// <param name="to">(Optional) Specify inter-clock uncertainty destination clock</param>
		/// <param name="rise_to">(Optional) Specify inter-clock uncertainty destination clock with rising edge</param>
		/// <param name="fall_to">(Optional) Specify inter-clock uncertainty destination clock with falling edge</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">(Optional) List of clocks, ports or pins</param>
		public TTCL set_clock_uncertainty(string uncertainty, bool? setup = null, bool? hold = null, string from = null, string rise_from = null, string fall_from = null, string to = null, string rise_to = null, string fall_to = null, bool? quiet = null, bool? verbose = null, string objects = null)
		{
			// TCL Syntax: set_clock_uncertainty [-setup] [-hold] [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-quiet] [-verbose] <uncertainty> [<objects>]
			_tcl.Entry(_builder.set_clock_uncertainty(uncertainty, setup, hold, from, rise_from, fall_from, to, rise_to, fall_to, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// Create data to data checks
		///
		///
		/// TCL Syntax: set_data_check [-from <args>] [-to <args>] [-rise_from <args>] [-fall_from <args>] [-rise_to <args>] [-fall_to <args>] [-setup] [-hold] [-clock <args>] [-quiet] [-verbose] <value>
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
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
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
		/// See ug835-vivado-tcl-commands.pdf, page 1609
		/// </summary>
		/// <param name="value">(Required) Setup or hold time of the defined checks</param>
		/// <param name="from">(Optional) From pin/port of data to data check</param>
		/// <param name="to">(Optional) To pin/port of the data to data check</param>
		/// <param name="rise_from">(Optional) Rise from pin/port of data to data check</param>
		/// <param name="fall_from">(Optional) Fall from pin/port of data to data check</param>
		/// <param name="rise_to">(Optional) Rise to pin/port of data to data check</param>
		/// <param name="fall_to">(Optional) Fall to pin/port of data to data check</param>
		/// <param name="setup">(Optional) Specify data check setup time</param>
		/// <param name="hold">(Optional) Specify data check hold time</param>
		/// <param name="clock">(Optional) Specify the clock domain at related pin/port of the checks</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_data_check(string value, string from = null, string to = null, string rise_from = null, string fall_from = null, string rise_to = null, string fall_to = null, bool? setup = null, bool? hold = null, string clock = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_data_check [-from <args>] [-to <args>] [-rise_from <args>] [-fall_from <args>] [-rise_to <args>] [-fall_to <args>] [-setup] [-hold] [-clock <args>] [-quiet] [-verbose] <value>
			_tcl.Entry(_builder.set_data_check(value, from, to, rise_from, fall_from, rise_to, fall_to, setup, hold, clock, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Disable timing arcs
		///
		///
		/// TCL Syntax: set_disable_timing [-from <arg>] [-to <arg>] [-quiet] [-verbose] <objects>
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
		/// See ug835-vivado-tcl-commands.pdf, page 1614
		/// </summary>
		/// <param name="objects">
		/// (Required)
		/// List of cells or pins, ports, lib-cells, lib-pins, libcell/cell
		/// timing-arcs
		/// </param>
		/// <param name="from">(Optional) From pin on cell</param>
		/// <param name="to">(Optional) To pin on cell</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_disable_timing(string objects, string from = null, string to = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_disable_timing [-from <arg>] [-to <arg>] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.set_disable_timing(objects, from, to, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Set external delay
		///
		///
		/// TCL Syntax: set_external_delay -from <args> -to <args> [-min] [-max] [-add] [-quiet] [-verbose] <delay_value>
		///
		/// TIP: The XDC > Timing Constraints language templates and the Timing Constraints Wizard in the Vivado
		/// IDE offer timing diagrams and additional details around defining specific timing constraints. You can refer
		/// to these sources for additional information.
		/// Sets the external (feedback) delay in nanoseconds (ns) between an output and input port. The
		/// external delay is used in the calculation of the PLL/MMCM compensation delay for PLLs/
		/// MMCMs with external feedback.
		/// A min or max value can be specified. By default the value specified applies to both min (hold) and
		/// max (setup) compensation delays.
		/// The command returns the defined delay.
		///
		/// The following example sets the external feedback delay to 1.0 ns between the port ClkOut and
		/// ClkFb:
		/// set_external_delay -from [get_ports ClkOut] -to [get_ports ClkFb] 1.0
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1616
		/// </summary>
		/// <param name="from">(Required) Output port</param>
		/// <param name="to">(Required) Input port</param>
		/// <param name="delay_value">(Required) External (feedback) delay value</param>
		/// <param name="min">(Optional) Specifies minimum delay</param>
		/// <param name="max">(Optional) Specifies maximum delay</param>
		/// <param name="add">(Optional) Add to existing external delay</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_external_delay(string from, string to, string delay_value, bool? min = null, bool? max = null, bool? add = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_external_delay -from <args> -to <args> [-min] [-max] [-add] [-quiet] [-verbose] <delay_value>
			_tcl.Entry(_builder.set_external_delay(from, to, delay_value, min, max, add, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Define false path
		///
		///
		/// TCL Syntax: set_false_path [-setup] [-hold] [-rise] [-fall] [-reset_path] [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-through <args>] [-rise_through <args>] [-fall_through <args>] [-quiet] [-verbose]
		///
		/// TIP: The XDC > Timing Constraints language templates and the Timing Constraints Wizard in the Vivado
		/// IDE offer timing diagrams and additional details around defining specific timing constraints. You can refer
		/// to these sources for additional information.
		/// Sets false timing paths in the design that are ignored during timing analysis.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Note: This command operates silently and does not return direct feedback of its operation
		///
		/// The following example eliminates the setup timing for paths from the bftClk:
		/// set_false_path -setup -from bftClk
		/// The following example excludes paths between the two clocks from timing analysis:
		/// set_false_path -from [get_clocks GT0_RXUSRCLK2_OUT] \
		/// -to [get_clocks DRPCLK_OUT]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1618
		/// </summary>
		/// <param name="setup">(Optional) Eliminate setup timing analysis for paths</param>
		/// <param name="hold">(Optional) Eliminate hold timing analysis for paths</param>
		/// <param name="rise">(Optional) Eliminate only rising delays for the defined paths</param>
		/// <param name="fall">(Optional) Eliminate only falling delays for the defined paths</param>
		/// <param name="reset_path">(Optional) Reset this path before setting false path</param>
		/// <param name="from">(Optional) List of path startpoints or clocks</param>
		/// <param name="rise_from">(Optional) Apply to paths rising from the list of startpoints or clocks</param>
		/// <param name="fall_from">(Optional) Apply to paths falling from the list of startpoints or clocks</param>
		/// <param name="to">(Optional) List of path endpoints or clocks</param>
		/// <param name="rise_to">(Optional) Apply to paths with rise transition at the list of endpoints or clocks</param>
		/// <param name="fall_to">(Optional) Apply to paths with fall transition at the list of endpoints or clocks</param>
		/// <param name="through">(Optional) List of through pins, cells or nets</param>
		/// <param name="rise_through">(Optional) Apply to paths rising through pins, cells or nets</param>
		/// <param name="fall_through">(Optional) Apply to paths falling through pins, cells or nets</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_false_path(bool? setup = null, bool? hold = null, bool? rise = null, bool? fall = null, bool? reset_path = null, string from = null, string rise_from = null, string fall_from = null, string to = null, string rise_to = null, string fall_to = null, string through = null, string rise_through = null, string fall_through = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_false_path [-setup] [-hold] [-rise] [-fall] [-reset_path] [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-through <args>] [-rise_through <args>] [-fall_through <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.set_false_path(setup, hold, rise, fall, reset_path, from, rise_from, fall_from, to, rise_to, fall_to, through, rise_through, fall_through, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Set hierarchical separator character
		///
		///
		/// TCL Syntax: set_hierarchy_separator [-quiet] [-verbose] [<separator>]
		///
		/// Sets the character that will be used for separating levels of hierarchy in the design.
		/// Note: This command operates silently and does not return direct feedback of its operation
		///
		/// This example changes the hierarchy separator to the '|' character:
		/// set_hierarchy_separator |
		/// The following example restores the default hierarchy separator, '/':
		/// set_hierarchy_separator
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1621
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="separator">(Optional) Hierarchy separator character Default: /</param>
		public TTCL set_hierarchy_separator(bool? quiet = null, bool? verbose = null, string separator = null)
		{
			// TCL Syntax: set_hierarchy_separator [-quiet] [-verbose] [<separator>]
			_tcl.Entry(_builder.set_hierarchy_separator(quiet, verbose, separator));
			return _tcl;
		}
		/// <summary>
		/// Set input delay on ports
		///
		///
		/// TCL Syntax: set_input_delay [-clock <args>] [-reference_pin <args>] [-clock_fall] [-rise] [-fall] [-max] [-min] [-add_delay] [-network_latency_included] [-source_latency_included] [-quiet] [-verbose] <delay> <objects>
		///
		/// TIP: The XDC > Timing Constraints language templates and the Timing Constraints Wizard in the Vivado
		/// IDE offer timing diagrams and additional details around defining specific timing constraints. You can refer
		/// to these sources for additional information.
		/// Specifies the external system-level path delay on a primary input port relative to a clock edge at
		/// the interface of the design. The input delay value is specified in nanoseconds (ns), and can be
		/// positive or negative, depending on the clock and data relative phase at the interface of the
		/// device.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// To accurately model the system-level timing of your Xilinx FPGA design, you must assign timing
		/// delays for objects external to the FPGA onto the primary input or output ports in your design.
		/// These delays are defined by the set_input_delay and set_output_delay commands.
		/// IMPORTANT! If the input port also has a set_max_delay constraint assigned, the specified input
		/// delay value is considered part of the max_delay computation. That is, the input delay consumes a portion
		/// of the max delay on the timing path that includes the input port.
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
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The following example specifies the input delay on all non clock input ports of the design.
		/// Although all_inputs returns all ports of the design, including clock ports, set_input_delay will skip
		/// setting input delays on the clock ports. The input delay is 1 relative to the rising edge of the clock
		/// wbClk:
		/// set_input_delay -clock wbClk 1 [all_inputs]
		/// The following example sets an input delay of 4 relative to the rising edge of the clock wbClk on
		/// the ports reset and wbDataForInput:
		/// set_input_delay -clock wbClk 4 [list reset wbDataForInput]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1626
		/// </summary>
		/// <param name="delay">(Required) Delay value</param>
		/// <param name="objects">(Required) List of ports</param>
		/// <param name="clock">(Optional) Relative clock</param>
		/// <param name="reference_pin">(Optional) Relative pin or port</param>
		/// <param name="clock_fall">(Optional) Delay is relative to falling edge of clock</param>
		/// <param name="rise">(Optional) Specifies rising delay</param>
		/// <param name="fall">(Optional) Specifies falling delay</param>
		/// <param name="max">(Optional) Specifies maximum delay</param>
		/// <param name="min">(Optional) Specifies minimum delay</param>
		/// <param name="add_delay">(Optional) Don't remove existing input delay</param>
		/// <param name="network_latency_included">(Optional) Specifies network latency of clock already included</param>
		/// <param name="source_latency_included">(Optional) Specifies source latency of clock already included</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_input_delay(string delay, string objects, string clock = null, string reference_pin = null, bool? clock_fall = null, bool? rise = null, bool? fall = null, bool? max = null, bool? min = null, bool? add_delay = null, bool? network_latency_included = null, bool? source_latency_included = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_input_delay [-clock <args>] [-reference_pin <args>] [-clock_fall] [-rise] [-fall] [-max] [-min] [-add_delay] [-network_latency_included] [-source_latency_included] [-quiet] [-verbose] <delay> <objects>
			_tcl.Entry(_builder.set_input_delay(delay, objects, clock, reference_pin, clock_fall, rise, fall, max, min, add_delay, network_latency_included, source_latency_included, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Set input jitter for a clock object
		///
		///
		/// TCL Syntax: set_input_jitter [-quiet] [-verbose] <clock> <input_jitter>
		///
		/// Use the set_input_jitter command to specify additional jitter for a specific primary clock.
		/// Input jitter is the difference between successive clock edges due to variation from the ideal
		/// arrival times. This command sets the input jitter in nanoseconds (ns) for a specified primary clock,
		/// defined with the create_clock command. Because the command accepts a single clock, the
		/// jitter for each primary clock must be set individually.
		/// You can only use the set_input_jitter command to specify input jitter on primary clocks.
		/// You cannot use the command to set input jitter on generated or auto derived clocks. Input jitter is
		/// propagated to generated clocks from the master clock, except for MMCM and PLL.
		/// The input jitter is used in the calculation of discrete jitter, which is the amount of jitter introduced
		/// by hardware primitives such as MMCM or PLL. Discrete jitter is a feature of clocks generated by
		/// the MMCM. See set_clock_uncertainty.
		/// The set_input_jitter command is ignored during synthesis.
		/// TIP: INPUT_JITTER is a property of primary clocks that can be returned by the get_property or
		/// report_property commands.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example sets an input jitter value of 0.3 ns on two clocks, sysClk and procClk.
		/// Although the jitter values are the same, you must use two set_input_jitter commands
		/// since the command only takes one clock as an argument:
		/// set_input_jitter sysClk 0.3
		/// set_input_jitter procClk 0.3
		/// The following example defines a primary clock, sysClk, and a generated clock, sysClkDiv2, that is
		/// a divide by two version of the primary clock. An input jitter of 0.15 ns is specified on the primary
		/// clock. The input jitter is automatically propagated to the generated clock:
		/// create_clock -period 10 -name sysClk [get_ports sysClk]
		/// create_generated_clock -name sysClkDiv2 -source [get_ports sysClk] \
		/// -divide_by 2 [get_pins clkgen/sysClkDiv/Q]
		/// set_input_jitter sysClk 0.15
		/// Note: In this example sysClkDiv2 is generated by a divider implemented with flip-flops, so the input jitter is
		/// propagated from the primary clock.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1630
		/// </summary>
		/// <param name="clock">(Required) Clock</param>
		/// <param name="input_jitter">(Required) Input jitter: Value >= 0</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>clock</returns>
		public TTCL set_input_jitter(string clock, string input_jitter, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_input_jitter [-quiet] [-verbose] <clock> <input_jitter>
			_tcl.Entry(_builder.set_input_jitter(clock, input_jitter, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Set capacitance on output ports and output pins
		///
		///
		/// TCL Syntax: set_load [-rise] [-fall] [-max] [-min] [-quiet] [-verbose] <capacitance> <objects>
		///
		/// Sets the load capacitance on output ports to the specified value. The load capacitance is used
		/// during power analysis when running the report_power command, but is not used during
		/// timing analysis.
		/// TIP: The default unit of capacitance is picofarads (pF), but can be changed using the set_units
		/// command.
		/// This command operates silently and does not return direct feedback of its operation.
		///
		/// The following example sets the specified load capacitance value for all ports:
		/// set_load 5.5 [all_outputs]
		/// The following example sets the rising and falling edge load capacitance for the specified output
		/// ports:
		/// set_load -rise -fall 8 [get_ports wbOutput*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1633
		/// </summary>
		/// <param name="capacitance">(Required) Capacitance value</param>
		/// <param name="objects">(Required) List of output ports and output pins</param>
		/// <param name="rise">(Optional) Specify the rise capacitance value (for ports only)</param>
		/// <param name="fall">(Optional) Specify the fall capacitance value (for ports only)</param>
		/// <param name="max">(Optional) Specify the maximum capacitance value</param>
		/// <param name="min">(Optional) Specify the minimum capacitance value</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_load(string capacitance, string objects, bool? rise = null, bool? fall = null, bool? max = null, bool? min = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_load [-rise] [-fall] [-max] [-min] [-quiet] [-verbose] <capacitance> <objects>
			_tcl.Entry(_builder.set_load(capacitance, objects, rise, fall, max, min, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Sets logic dc for input ports and input pins
		///
		///
		/// TCL Syntax: set_logic_dc [-quiet] [-verbose] <objects>
		///
		/// Sets the specified input ports or input pins to a logic value of 'X', as unknown or don't care. This
		/// command is NOT supported in Synthesis.
		/// Note: This command operates silently and does not return direct feedback of its operation.
		///
		/// The following example sets the specified port to 'X':
		/// set_logic_dc [get_ports reset]
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1635
		/// </summary>
		/// <param name="objects">(Required) List of input ports and input pins</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_logic_dc(string objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_logic_dc [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.set_logic_dc(objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Sets logic one for input ports and input pins
		///
		///
		/// TCL Syntax: set_logic_one [-quiet] [-verbose] <objects>
		///
		/// Sets the specified input ports or input pins to a logic one. This command is NOT supported in
		/// Synthesis.
		/// Note: This command operates silently and does not return direct feedback of its operation.
		///
		/// The following example sets the specified input port to a logic one:
		/// set_logic_one [get_ports reset]
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The following example sets the input ports reset and wbDataForInput to a logic one:
		/// set_logic_one [list [get_ports reset] [get_ports wbDataForInput]]
		/// The following example sets the input pin I on instance reset_IBUF to a logic one:
		/// set_logic_one [get_pins reset_IBUF_inst/I]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1637
		/// </summary>
		/// <param name="objects">(Required) List of input ports and input pins</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_logic_one(string objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_logic_one [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.set_logic_one(objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Sets logic unconnected for output ports and output pins
		///
		///
		/// TCL Syntax: set_logic_unconnected [-quiet] [-verbose] <objects>
		///
		/// Defines the specified output ports or pins as unconnected.
		/// Note: This command operates silently and does not return direct feedback of its operation.
		///
		/// The following example sets the specified port to unconnected:
		/// set_logic_unconnected [get_ports OUT1]
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1639
		/// </summary>
		/// <param name="objects">(Required) List of output ports and output pins</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_logic_unconnected(string objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_logic_unconnected [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.set_logic_unconnected(objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Sets logic zero for input ports and input pins
		///
		///
		/// TCL Syntax: set_logic_zero [-quiet] [-verbose] <objects>
		///
		/// Sets the specified input ports and input pins to a logic zero. This command is NOT supported in
		/// Synthesis.
		/// Note: This command operates silently and does not return direct feedback of its operation.
		///
		/// The following example sets the specified port to logic state 0:
		/// set_logic_zero [get_ports reset]
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1641
		/// </summary>
		/// <param name="objects">(Required) List of input ports and input pins</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_logic_zero(string objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_logic_zero [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.set_logic_zero(objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Specify maximum delay for timing paths
		///
		///
		/// TCL Syntax: set_max_delay [-rise] [-fall] [-reset_path] [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-through <args>] [-rise_through <args>] [-fall_through <args>] [-datapath_only] [-quiet] [-verbose] <delay>
		///
		/// TIP: The XDC > Timing Constraints language templates and the Timing Constraints Wizard in the Vivado
		/// IDE offer timing diagrams and additional details around defining specific timing constraints. You can refer
		/// to these sources for additional information.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
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
		/// IMPORTANT! When assigned to a primary input or output port, any system-level delay consumes a
		/// portion of the max delay on the timing path that includes the input or output port. That is, the delay
		/// specified by set_input_delay or set_output_delay is considered part of the maximum delay.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example defines a maximum delay of 60 ns between all the input and output ports
		/// (feedthrough paths):
		/// set_max_delay 60 -from [all_inputs] -to [all_outputs]
		/// The following example clears the existing max delay and specifies a new > maximum delay for
		/// paths to endpoints clocked by the specified clock:
		/// set_max_delay -reset_path 50 -to [get_clocks spi_clk]
		/// The set_max_delay command is often used with -datapath_only to constrain asynchronous clock
		/// domains crossing when a simple synchronizer is used on the destination clock domain. In the
		/// following example, two flops (FF1 and FF2) are clocked by different clocks, and FF1/Q connects
		/// directly to FF2/D through net1. To limit the delay on this connection to 4.0 ns use the following
		/// constraints:
		/// set_max_delay -from FF1/C -to FF2/D -datapath_only 4.0
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1643
		/// </summary>
		/// <param name="delay">(Required) Delay value</param>
		/// <param name="rise">(Optional) Delay value applies to rising path delays</param>
		/// <param name="fall">(Optional) Delay value applies to falling path delays</param>
		/// <param name="reset_path">(Optional) Reset this path before setting max delay</param>
		/// <param name="from">(Optional) List of path startpoints or clocks</param>
		/// <param name="rise_from">(Optional) Apply to paths rising from the list of startpoints or clocks</param>
		/// <param name="fall_from">(Optional) Apply to paths falling from the list of startpoints or clocks</param>
		/// <param name="to">(Optional) List of path endpoints or clocks</param>
		/// <param name="rise_to">(Optional) Apply to paths with rise transition at the list of endpoints or clocks</param>
		/// <param name="fall_to">(Optional) Apply to paths with fall transition at the list of endpoints or clocks</param>
		/// <param name="through">(Optional) List of through pins, cells or nets</param>
		/// <param name="rise_through">(Optional) Apply to paths rising through pins, cells or nets</param>
		/// <param name="fall_through">(Optional) Apply to paths falling through pins, cells or nets</param>
		/// <param name="datapath_only">(Optional) Remove clock skew and jitter from calculation</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_max_delay(string delay, bool? rise = null, bool? fall = null, bool? reset_path = null, string from = null, string rise_from = null, string fall_from = null, string to = null, string rise_to = null, string fall_to = null, string through = null, string rise_through = null, string fall_through = null, bool? datapath_only = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_max_delay [-rise] [-fall] [-reset_path] [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-through <args>] [-rise_through <args>] [-fall_through <args>] [-datapath_only] [-quiet] [-verbose] <delay>
			_tcl.Entry(_builder.set_max_delay(delay, rise, fall, reset_path, from, rise_from, fall_from, to, rise_to, fall_to, through, rise_through, fall_through, datapath_only, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Limit time borrowing for latches
		///
		///
		/// TCL Syntax: set_max_time_borrow [-quiet] [-verbose] <delay> <objects>
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
		/// See ug835-vivado-tcl-commands.pdf, page 1647
		/// </summary>
		/// <param name="delay">(Required) Delay value: Value >= 0</param>
		/// <param name="objects">(Required) List of clocks, cells, data pins or clock pins</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_max_time_borrow(string delay, string objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_max_time_borrow [-quiet] [-verbose] <delay> <objects>
			_tcl.Entry(_builder.set_max_time_borrow(delay, objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Specify minimum delay for timing paths
		///
		///
		/// TCL Syntax: set_min_delay [-rise] [-fall] [-reset_path] [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-through <args>] [-rise_through <args>] [-fall_through <args>] [-quiet] [-verbose] <delay>
		///
		/// Sets the minimum delay allowed on a timing path, specified in nanoseconds (ns). The specified
		/// delay value is assigned to both the rising and falling edges of the defined timing paths unless the
		/// -rise or -fall arguments are specified.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// IMPORTANT! The minimum rising and falling delay cannot be greater than the maximum rising and
		/// falling delay on the same path. If this happens, the first assigned delay value is removed from the timing
		/// path and reset to 0.
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
		/// See ug835-vivado-tcl-commands.pdf, page 1649
		/// </summary>
		/// <param name="delay">(Required) Delay value</param>
		/// <param name="rise">(Optional) Delay value applies to rising path delays</param>
		/// <param name="fall">(Optional) Delay value applies to falling path delays</param>
		/// <param name="reset_path">(Optional) Reset this path before setting min delay</param>
		/// <param name="from">(Optional) List of path startpoints or clocks</param>
		/// <param name="rise_from">(Optional) Apply to paths rising from the list of startpoints or clocks</param>
		/// <param name="fall_from">(Optional) Apply to paths falling from the list of startpoints or clocks</param>
		/// <param name="to">(Optional) List of path endpoints or clocks</param>
		/// <param name="rise_to">(Optional) Apply to paths with rise transition at the list of endpoints or clocks</param>
		/// <param name="fall_to">(Optional) Apply to paths with fall transition at the list of endpoints or clocks</param>
		/// <param name="through">(Optional) List of through pins, cells or nets</param>
		/// <param name="rise_through">(Optional) Apply to paths rising through pins, cells or nets</param>
		/// <param name="fall_through">(Optional) Apply to paths falling through pins, cells or nets</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_min_delay(string delay, bool? rise = null, bool? fall = null, bool? reset_path = null, string from = null, string rise_from = null, string fall_from = null, string to = null, string rise_to = null, string fall_to = null, string through = null, string rise_through = null, string fall_through = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_min_delay [-rise] [-fall] [-reset_path] [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-through <args>] [-rise_through <args>] [-fall_through <args>] [-quiet] [-verbose] <delay>
			_tcl.Entry(_builder.set_min_delay(delay, rise, fall, reset_path, from, rise_from, fall_from, to, rise_to, fall_to, through, rise_through, fall_through, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Define multicycle path
		///
		///
		/// TCL Syntax: set_multicycle_path [-setup] [-hold] [-rise] [-fall] [-start] [-end] [-reset_path] [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-through <args>] [-rise_through <args>] [-fall_through <args>] [-quiet] [-verbose] <path_multiplier>
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
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
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
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1658
		/// </summary>
		/// <param name="path_multiplier">(Required) Number of cycles</param>
		/// <param name="setup">(Optional) Only setup multiplier is set</param>
		/// <param name="hold">(Optional) Only hold multiplier is set</param>
		/// <param name="rise">(Optional) Multiplier valid for rising delays on path endpoint</param>
		/// <param name="fall">(Optional) Multiplier valid for falling delays on path endpoint</param>
		/// <param name="start">(Optional) Multiplier measured against path startpoint</param>
		/// <param name="end">(Optional) Multiplier measured against path endpoint</param>
		/// <param name="reset_path">(Optional) Reset this path before setting multicycle</param>
		/// <param name="from">(Optional) List of path startpoints or clocks</param>
		/// <param name="rise_from">(Optional) Apply to paths rising from the list of startpoints or clocks</param>
		/// <param name="fall_from">(Optional) Apply to paths falling from the list of startpoints or clocks</param>
		/// <param name="to">(Optional) List of path endpoints or clocks</param>
		/// <param name="rise_to">(Optional) Apply to paths with rise transition at the list of endpoints or clocks</param>
		/// <param name="fall_to">(Optional) Apply to paths with fall transition at the list of endpoints or clocks</param>
		/// <param name="through">(Optional) List of through pins, cells or nets</param>
		/// <param name="rise_through">(Optional) Apply to paths rising through pins, cells or nets</param>
		/// <param name="fall_through">(Optional) Apply to paths falling through pins, cells or nets</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_multicycle_path(string path_multiplier, bool? setup = null, bool? hold = null, bool? rise = null, bool? fall = null, bool? start = null, bool? end = null, bool? reset_path = null, string from = null, string rise_from = null, string fall_from = null, string to = null, string rise_to = null, string fall_to = null, string through = null, string rise_through = null, string fall_through = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_multicycle_path [-setup] [-hold] [-rise] [-fall] [-start] [-end] [-reset_path] [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-through <args>] [-rise_through <args>] [-fall_through <args>] [-quiet] [-verbose] <path_multiplier>
			_tcl.Entry(_builder.set_multicycle_path(path_multiplier, setup, hold, rise, fall, start, end, reset_path, from, rise_from, fall_from, to, rise_to, fall_to, through, rise_through, fall_through, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Set operating conditions for power estimation
		///
		///
		/// TCL Syntax: set_operating_conditions [-voltage <args>] [-grade <arg>] [-process <arg>] [-junction_temp <arg>] [-ambient_temp <arg>] [-thetaja <arg>] [-thetasa <arg>] [-airflow <arg>] [-heatsink <arg>] [-thetajb <arg>] [-board <arg>] [-board_temp <arg>] [-board_layers <arg>] [-design_power_budget <arg>] [-supply_current_budget <args>] [-quiet] [-verbose]
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
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The following example sets the manufacturing process corner to maximum:
		/// set_operating_conditions -process maximum
		/// The following example sets the manufacturing process corner to maximum and the voltage
		/// supply Vccint to 0.875:
		/// set_operating_conditions -process maximum -voltage {Vccint 0.875}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1663
		/// </summary>
		/// <param name="voltage">
		/// (Optional)
		/// List of voltage pairs, e.g., {name value}. Supported voltage
		/// supplies vary by family.
		/// </param>
		/// <param name="grade">
		/// (Optional)
		/// Temperature grade. Supported values vary by family.
		/// Default: commercial
		/// </param>
		/// <param name="process">(Optional) Process data: typical or maximum Default: typical</param>
		/// <param name="junction_temp">(Optional) Junction Temperature (C): auto|degC Default: auto</param>
		/// <param name="ambient_temp">(Optional) Ambient Temperature (C): default|degC Default: default</param>
		/// <param name="thetaja">(Optional) ThetaJA (C/W): auto|degC/W Default: auto</param>
		/// <param name="thetasa">(Optional) ThetaSA (C/W): auto|degC/W Default: auto</param>
		/// <param name="airflow">(Optional) Airflow (LFM): 0 to 750 Default: varies by family</param>
		/// <param name="heatsink">
		/// (Optional)
		/// Dimensions of heatsink: none, low, medium, high, custom
		/// Default: medium
		/// </param>
		/// <param name="thetajb">(Optional) ThetaJB (C/W): auto|degC/W Default: auto</param>
		/// <param name="board">(Optional) Board type: jedec, small, medium, large, custom Default: medium</param>
		/// <param name="board_temp">(Optional) Board Temperature degC</param>
		/// <param name="board_layers">(Optional) Board layers: 4to7, 8to11, 12to15, 16+ Default: 8to11</param>
		/// <param name="design_power_budget">(Optional) Design Power Budget (W) Default: Unspecified</param>
		/// <param name="supply_current_budget">
		/// (Optional)
		/// Sets list of supply current budget 'name value' pairs.
		/// Supported voltage supplies vary by family.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_operating_conditions(string voltage = null, string grade = null, string process = null, string junction_temp = null, string ambient_temp = null, string thetaja = null, string thetasa = null, string airflow = null, string heatsink = null, string thetajb = null, string board = null, string board_temp = null, string board_layers = null, string design_power_budget = null, string supply_current_budget = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_operating_conditions [-voltage <args>] [-grade <arg>] [-process <arg>] [-junction_temp <arg>] [-ambient_temp <arg>] [-thetaja <arg>] [-thetasa <arg>] [-airflow <arg>] [-heatsink <arg>] [-thetajb <arg>] [-board <arg>] [-board_temp <arg>] [-board_layers <arg>] [-design_power_budget <arg>] [-supply_current_budget <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.set_operating_conditions(voltage, grade, process, junction_temp, ambient_temp, thetaja, thetasa, airflow, heatsink, thetajb, board, board_temp, board_layers, design_power_budget, supply_current_budget, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Set output delay on ports
		///
		///
		/// TCL Syntax: set_output_delay [-clock <args>] [-reference_pin <args>] [-clock_fall] [-rise] [-fall] [-max] [-min] [-add_delay] [-network_latency_included] [-source_latency_included] [-quiet] [-verbose] <delay> <objects>
		///
		/// TIP: The XDC > Timing Constraints language templates and the Timing Constraints Wizard in the Vivado
		/// IDE offer timing diagrams and additional details around defining specific timing constraints. You can refer
		/// to these sources for additional information.
		/// Specifies the external system-level path delay on a primary output port relative to a clock edge at
		/// the interface of the design. The output delay value is specified in nanoseconds (ns), and can be
		/// positive or negative, depending on the clock and data relative phase outside the FPGA device.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// To accurately model the system-level timing of your Xilinx FPGA design, you must assign timing
		/// delays for objects external to the FPGA onto the primary input or output ports in your design.
		/// These delays are defined by the set_input_delay and set_output_delay commands.
		/// IMPORTANT! If the output port also has a set_max_delay constraint assigned, the specified output
		/// delay value is considered part of the max_delay computation. That is, the output delay consumes a portion
		/// of the max delay on the timing path that includes the output port.
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
		/// See ug835-vivado-tcl-commands.pdf, page 1667
		/// </summary>
		/// <param name="delay">(Required) Delay value</param>
		/// <param name="objects">(Required) List of ports</param>
		/// <param name="clock">(Optional) Relative clock</param>
		/// <param name="reference_pin">(Optional) Relative pin or port</param>
		/// <param name="clock_fall">(Optional) Delay is relative to falling edge of clock</param>
		/// <param name="rise">(Optional) Specifies rising delay</param>
		/// <param name="fall">(Optional) Specifies falling delay</param>
		/// <param name="max">(Optional) Specifies maximum delay</param>
		/// <param name="min">(Optional) Specifies minimum delay</param>
		/// <param name="add_delay">(Optional) Don't remove existing input delay</param>
		/// <param name="network_latency_included">(Optional) Specifies network latency of clock already included</param>
		/// <param name="source_latency_included">(Optional) Specifies source latency of clock already included</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_output_delay(string delay, string objects, string clock = null, string reference_pin = null, bool? clock_fall = null, bool? rise = null, bool? fall = null, bool? max = null, bool? min = null, bool? add_delay = null, bool? network_latency_included = null, bool? source_latency_included = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_output_delay [-clock <args>] [-reference_pin <args>] [-clock_fall] [-rise] [-fall] [-max] [-min] [-add_delay] [-network_latency_included] [-source_latency_included] [-quiet] [-verbose] <delay> <objects>
			_tcl.Entry(_builder.set_output_delay(delay, objects, clock, reference_pin, clock_fall, rise, fall, max, min, add_delay, network_latency_included, source_latency_included, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Set user columns on one or more package pins
		///
		///
		/// TCL Syntax: set_package_pin_val [-quiet] [-verbose] <column> <value> <package_pins>...
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
		/// See ug835-vivado-tcl-commands.pdf, page 1670
		/// </summary>
		/// <param name="column">(Required) User column name</param>
		/// <param name="value">(Required) Value to set</param>
		/// <param name="package_pins">(Required) Package pin names</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_package_pin_val(string column, string value, string package_pins, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_package_pin_val [-quiet] [-verbose] <column> <value> <package_pins>...
			_tcl.Entry(_builder.set_package_pin_val(column, value, package_pins, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Set constraints for power optimization
		///
		///
		/// TCL Syntax: set_power_opt [-include_cells <args>] [-exclude_cells <args>] [-clocks <args>] [-cell_types <args>] [-quiet] [-verbose]
		///
		/// Specify cell instances to include or exclude in power optimization. The specified cells are
		/// optimized using the power_opt_design command.
		/// TIP: Block RAM optimizations are performed by default with the opt_design command. Some or all
		/// BRAM cells can be excluded from the opt_design optimization using the set_power_opt command
		/// as well.
		/// The effect of multiple set_power_opt commands is cumulative, so that you can specify a
		/// broad class of cell types to optimize, include specific hierarchical cells, and then exclude cells
		/// within the included hierarchy to refine the power optimization.
		/// The power optimizations that have been performed can be reported using the
		/// report_power_opt command.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example sets power optimization for BRAM cells only, and then runs power
		/// optimization:
		/// set_power_opt -cell_types bram
		/// power_opt_design
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The following example sets power optimization for BRAM and REG type cells, then adds SRLs,
		/// and runs power optimization. Then all cells are cleared, and only SRLs are included, and power
		/// optimization is run again:
		/// set_power_opt -cell_types { bram reg}
		/// set_power_opt -cell_types { srl}
		/// power_opt_design
		/// set_power_opt -cell_types { none}
		/// set_power_opt -cell_types { srl}
		/// power_opt_design
		/// The following example sets power optimization for BRAM cells only, excludes the cpuEngine
		/// block from optimization, but then includes the cpuEngine/cpu_dbg_dat_i block, then performs
		/// power optimization:
		/// set_power_opt -cell_types bram
		/// set_power_opt -exclude_cells cpuEngine
		/// set_power_opt -include_cells cpuEngine/cpu_dbg_dat_i
		/// power_opt_design
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1677
		/// </summary>
		/// <param name="include_cells">(Optional) Include only these instances for clock gating. Default: all</param>
		/// <param name="exclude_cells">(Optional) Exclude these instances from clock gating. Default: none</param>
		/// <param name="clocks">(Optional) Clock gate instances clocked by these clocks only. Default: all clocks</param>
		/// <param name="cell_types">
		/// (Optional)
		/// Clock gate these cell types only. Specify either [all|none], or
		/// one or more of [bram|reg|srl]. Default: all
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_power_opt(string include_cells = null, string exclude_cells = null, string clocks = null, string cell_types = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_power_opt [-include_cells <args>] [-exclude_cells <args>] [-clocks <args>] [-cell_types <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.set_power_opt(include_cells, exclude_cells, clocks, cell_types, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Specify propagated clock latency
		///
		///
		/// TCL Syntax: set_propagated_clock [-quiet] [-verbose] <objects>
		///
		/// Propagates clock latency throughout a clock network, resulting in more accurate skew and timing
		/// results throughout the clock network.
		/// Note: This command operates silently and does not return direct feedback of its operation.
		///
		/// This example specifies that the primary system clock from the top-level should be propagated:
		/// set_propagated_clock [get_clocks top/clk]
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// This example specifies that all clocks from "sublevel1" should be propagated:
		/// set_propagated_clock [get_clocks sublevel1/*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1680
		/// </summary>
		/// <param name="objects">(Required) List of clocks, ports, or pins</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_propagated_clock(string objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_propagated_clock [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.set_propagated_clock(objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Set property on object(s)
		///
		///
		/// TCL Syntax: set_property [-dict <args>] [-quiet] [-verbose] <name> <value> <objects>...
		///
		/// Assigns the defined property <name> and <value> to the specified <objects>.
		/// This command can be used to define any property on an object in the design. Each object has a
		/// set of predefined properties that have expected values, or a range of values. The set_property
		/// command can be used to define the values for these properties. To determine the defined set of
		/// properties on an object, use report_property, list_property, or
		/// list_property_values.
		/// You can also define custom properties for an object, by specifying a unique <name> and <value>
		/// pair for the object. If an object has custom properties, these will also be reported by the
		/// report_property and list_property commands.
		/// This command returns nothing if successful, and an error if it fails.
		/// TIP: You can use the get_property command to validate any properties that have been set on an
		/// object.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// Create a user-defined boolean property, TRUTH, for cell objects, and set the property on a cell:
		/// create_property -type bool truth cell
		/// set_property truth false [lindex [get_cells] 1]
		/// Use the -dict option to specify multiple properties at one time on the current design:
		/// set_property -dict "POST_CRC enable POST_CRC_ACTION correct_and_continue"
		/// \
		/// [current_design]
		/// The following example sets the TOP property of the current fileset to define the top module of
		/// the project:
		/// set_property top fftTop [current_fileset]
		/// set_property top_file {C:/Data/sources/fftTop.v} [current_fileset]
		/// Note: Defining the top module requires the TOP property to be set to the desired hierarchical block in the
		/// source fileset of the current project. In the preceding example TOP is the property name, fftTop is the
		/// value, and current_fileset is the object. In addition, the TOP_FILE property should be defined to point to
		/// the data source for the top module.
		/// This example shows how to set a property value that includes the dash character, '-'. The dash
		/// can cause the tool to interpret the value as a new command argument, rather than part of the
		/// value being specified, and will cause an error as shown. In this case, you must use the explicit
		/// form of the positional arguments in the set_property command:
		/// set_property {XELAB.MORE_OPTIONS} {-pulse_e_style ondetect} \
		/// [get_filesets sim_1]
		/// ERROR: [Common 17-170] Unknown option '-pulse_e_style ondetect',
		/// please type 'set_property -help' for usage info.
		/// set_property -name {XELAB.MORE_OPTIONS} -value {-pulse_e_style ondetect}\
		/// -objects [get_filesets sim_1]
		/// The following example sets the internal VREF property value for the specified IO Bank:
		/// set_property internal_vref {0.75} [get_iobanks 0]
		/// The following example defines a DCI Cascade by setting the DCI_CASCADE property for the
		/// specified IO Bank:
		/// set_property DCI_CASCADE {14} [get_iobanks 0 ]
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The following example configures the synth_1 run, setting options for Vivado Synthesis 2013,
		/// and then launches the synthesis run:
		/// set_property flow {Vivado Synthesis 2016} \
		/// [get_runs synth_1]
		/// set_property STEPS.SYNTH_DESIGN.ARGS.GATED_CLOCK_CONVERSION on \
		/// [get_runs synth_1]
		/// set_property STEPS.SYNTH_DESIGN.ARGS.FSM_EXTRACTION one_hot \
		/// [get_runs synth_1]
		/// launch_runs synth_1
		/// This example is the same as the prior example, except that it uses the -dict option to set all the
		/// properties on the synthesis run in a single set_property command:
		/// set_property -dict [ list flow {Vivado Synthesis 2016} \
		/// STEPS.SYNTH_DESIGN.ARGS.GATED_CLOCK_CONVERSION on \
		/// STEPS.SYNTH_DESIGN.ARGS.FSM_EXTRACTION \
		/// one_hot ] [get_runs synth_1]
		/// launch_runs synth_1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1682
		/// </summary>
		/// <param name="name">(Required) Name of property to set. Not valid with -dict option</param>
		/// <param name="value">(Required) Value of property to set. Not valid with -dict option</param>
		/// <param name="objects">(Required) Objects to set properties on</param>
		/// <param name="dict">(Optional) list of name/value pairs of properties to set</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_property(string name, string value, string objects, string dict = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_property [-dict <args>] [-quiet] [-verbose] <name> <value> <objects>...
			_tcl.Entry(_builder.set_property(name, value, objects, dict, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Set switching activity on specified objects or default types
		///
		///
		/// TCL Syntax: set_switching_activity [-toggle_rate <arg>] [-default_toggle_rate <arg>] [-type <args>] [-all] [-static_probability <arg>] [-default_static_probability <arg>] [-signal_rate <arg>] [-hier] [-deassert_resets] [-quiet] [-verbose] [<objects>...]
		///
		/// Sets the signal rate and the switching probability to be used when performing power estimation
		/// on the current synthesized or implemented design. These include simple signal rate and simple
		/// static probability on nets, ports, and pins; and state dependent static probabilities on cells.
		/// Note: This command operates silently and does not return direct feedback of its operation.
		/// The switching activity of a design affects both the static and dynamic power consumption. The
		/// static power is often dependent on logic state transitions, and the dynamic power is directly
		/// proportional to the toggle rate.
		/// The set_switching_activity command can be used to specify default activity rates for the
		/// whole design, or to define the activity of one or more signals in the design or on a specified
		/// module.
		/// The current switching activity attributes can be found by using the
		/// report_switching_activity command. The values can be set to their default values by
		/// using the reset_switching_activity command.
		/// Note: The reset_switching_activity is used to reset switching activity for specified objects. Use the
		/// set_switching_activity -default_toggle_rate or -default_static_probability to
		/// change or reset these values.
		///
		/// The following example specifies a signal rate and switching probability for all ports, then reports
		/// the switching attributes for those ports:
		/// set_switching_activity -signal_rate 55 -static_probability .33 [get_ports]
		/// report_switching_activity [get_ports]
		/// The following example specifies the default switching probability for the current design:
		/// set_switching_activity -default_static_probability .75
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// This example sets the specified toggle rate and static probability on all registers in the hierarchy
		/// of "CPU/MEM":
		/// set_switching_activity -type register -toggle_rate 0.4 \
		/// -static_probability 0.5 [get_cells CPU/MEM]
		/// This example sets the specified toggle rate and static probability on all registers in the hierarchy
		/// of "CPU/" and underneath hierarchy:
		/// set_switching_activity -type register -toggle_rate 0.4
		/// -static_probability 0.5 -hier [get_cells CPU]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1688
		/// </summary>
		/// <param name="toggle_rate">
		/// (Optional)
		/// Toggle rate (%) is the rate at which the output of
		/// synchronous logic element switches compared to a given
		/// clock input. It is modeled as a percentage between 0 - 200%.
		/// A toggle rate of 100% means that on average the output
		/// toggles once during every clock cycle, changing on either
		/// the rising or falling clock edges, and making the effective
		/// output signal frequency half of the clock frequency. Default:
		/// 0.0
		/// </param>
		/// <param name="default_toggle_rate">
		/// (Optional)
		/// The default toggle rate to be used in power analysis on the
		/// primary inputs of the design. The default toggle rate is set
		/// on those primary input nets whose switching activity is not
		/// specified by the user, simulation data or constraints of the
		/// design. Valid values are: 0 <= value < 200. The default value
		/// is 12.5. Default: 12.5
		/// </param>
		/// <param name="type">
		/// (Optional)
		/// Specify nodes in a specific category. List of valid type values:
		/// io_output, io_bidir_enable, register, lut_ram, lut, dsp,
		/// bram_enable, bram_wr_enable, gt_txdata, gt_rxdata.
		/// </param>
		/// <param name="all">
		/// (Optional)
		/// Used together with -type, set switching activity on -type nets
		/// within an instance
		/// </param>
		/// <param name="static_probability">(Optional) Static probability value: 0 <= Value <= 1 Default: 0.5</param>
		/// <param name="default_static_probability">
		/// (Optional)
		/// The default static probability to be used in power analysis
		/// on the design. The default static probability is set on those
		/// primary inputs whose switching activity is not specified by
		/// the user, simulation data or constraints of the design. Valid
		/// values are: 0 <= Value <= 1. The default value is 0.5. Default:
		/// 0.5
		/// </param>
		/// <param name="signal_rate">
		/// (Optional)
		/// The number of times an element changed state (high-to-low
		/// and low-to-high) per second. Xilinx tools express this as
		/// millions of transitions per second (Mtr/s). Default: 0.0
		/// </param>
		/// <param name="hier">
		/// (Optional)
		/// Hierarchically sets the switching activity on a hierarchical
		/// instance provided via <objects> option. This option should
		/// be used only with <objects> option
		/// </param>
		/// <param name="deassert_resets">
		/// (Optional)
		/// A switch to elegantly auto deassert all set,reset,preset and
		/// clear signals that do not have conflicted polarities
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">
		/// (Optional)
		/// Objects to set switching activity on
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// </param>
		public TTCL set_switching_activity(string toggle_rate = null, string default_toggle_rate = null, string type = null, bool? all = null, string static_probability = null, string default_static_probability = null, string signal_rate = null, bool? hier = null, bool? deassert_resets = null, bool? quiet = null, bool? verbose = null, string objects = null)
		{
			// TCL Syntax: set_switching_activity [-toggle_rate <arg>] [-default_toggle_rate <arg>] [-type <args>] [-all] [-static_probability <arg>] [-default_static_probability <arg>] [-signal_rate <arg>] [-hier] [-deassert_resets] [-quiet] [-verbose] [<objects>...]
			_tcl.Entry(_builder.set_switching_activity(toggle_rate, default_toggle_rate, type, all, static_probability, default_static_probability, signal_rate, hier, deassert_resets, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// Set system jitter
		///
		///
		/// TCL Syntax: set_system_jitter [-quiet] [-verbose] <system_jitter>
		///
		/// Sets the system jitter specified in nanoseconds (ns) for all clocks in the design, including primary
		/// and generated clocks. System jitter is used to account for excessive noise that affects all the
		/// clocks within the FPGA, like power supply noise and board noise. The default system jitter is
		/// technology-dependent and is predefined for each Xilinx FPGA family based on device
		/// characterization with several power supplies under all supported operating conditions.
		/// System Jitter is a component of the Total System Jitter (Tsj) used in the calculation of clock
		/// uncertainty for a path. It is due to the maximum noise (in time) that can be seen on the Vccint rail
		/// due to simultaneous switching of internal nodes, cross talk and other phenomenon that can
		/// impact timing on any path in the design.
		/// IMPORTANT! The jitter calculated by Xilinx takes into consideration the uncertainty introduced by the
		/// clocking resources, the input jitter and the system jitter. Using the set_system_jitter command
		/// overrides the default system jitter value calculated by Xilinx, and is not recommended.
		/// The System Jitter and the Input Jitter are random jitters which typically follow a Gaussian
		/// distribution and are added in a quadratic manner to represent the worst case combination. When
		/// the Input Jitter is null, the Total System Jitter (Tsj) for an internal register-to-register path has the
		/// following equation:
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// • Tsj = √(SourceClockSystemJitter2
		/// + DestinationClockSystemJitter2
		/// )
		/// For example, when using the default value for system jitter of 50ps:
		/// • Tsj = √(0.0502
		/// + 0.0502
		/// ) = 0.071ns = 71ps
		/// The set_system_jitter command applies to all the clocks in the design. Use the
		/// set_input_jitter command to specify additional jitter for a specific primary clock.
		/// TIP: SYSTEM_JITTER is reported as a property of clocks, although it applies to all clocks in the design.
		/// INPUT_JITTER is also a property of primary clocks. These properties can be returned by the
		/// get_property or report_property commands.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// This example defines the primary clock, sysClk, and specifies a system wide jitter of 0.1 ns:
		/// create_clock -period 10 -name sysClk [get_ports sysClk]
		/// set_system_jitter 0.1
		/// The following example defines a primary clock, sysClk, and a generated clock, sysClkDiv2, that is
		/// a divide by two version of the primary clock. A system jitter of 0.2 ns is specified that applies to
		/// all the clocks in the design. An additional input jitter of 0.09 ns is specified on only the primary
		/// clock:
		/// create_clock -period 10 -name sysClk [get_ports sysClk]
		/// create_generated_clock -name sysClkDiv2 -source [get_ports sysClk] \
		/// -divide_by 2 [get_pins clkgen/sysClkDiv/Q]
		/// set_system_jitter 0.2
		/// set_input_jitter sysClk 0.09
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The follow example defines two primary clocks, sysClk and procClk. A system jitter of 0.2 ns is
		/// defined for all the clocks in the system. An additional input jitter of 0.05 ns is specified for the
		/// clock procClk:
		/// create_clock -period 10 -name sysClk [get_ports sysClk]
		/// create_clock -period 25 -name procClk [get_ports procClk]
		/// set_system_jitter 0.2
		/// set_input_jitter procClk 0.05
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1693
		/// </summary>
		/// <param name="system_jitter">(Required) System jitter: Value >= 0</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>system_jitter</returns>
		public TTCL set_system_jitter(string system_jitter, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_system_jitter [-quiet] [-verbose] <system_jitter>
			_tcl.Entry(_builder.set_system_jitter(system_jitter, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Set units for checking
		///
		///
		/// TCL Syntax: set_units [-capacitance <arg>] [-current <arg>] [-voltage <arg>] [-power <arg>] [-resistance <arg>] [-altitude <arg>] [-quiet] [-verbose]
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
		/// See ug835-vivado-tcl-commands.pdf, page 1696
		/// </summary>
		/// <param name="capacitance">(Optional) Capacitance unit in farad. Valid values are from kF-fF. Default: pF</param>
		/// <param name="current">(Optional) Current unit in ampere. Valid values are from kA-fA. Default: mA</param>
		/// <param name="voltage">(Optional) Voltage unit in volt. Valid values are from kV-fV. Default: V</param>
		/// <param name="power">(Optional) Wattage unit in watts. Valid values are from kW-fW. Default: mW</param>
		/// <param name="resistance">(Optional) Resistance unit in ohm. Valid values are from kOhm-fOhm. Default: ohm</param>
		/// <param name="altitude">
		/// (Optional)
		/// Altitude in metric or standard units. Valid values are meters
		/// and feet. Default: meters
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_units(string capacitance = null, string current = null, string voltage = null, string power = null, string resistance = null, string altitude = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_units [-capacitance <arg>] [-current <arg>] [-voltage <arg>] [-power <arg>] [-resistance <arg>] [-altitude <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.set_units(capacitance, current, voltage, power, resistance, altitude, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Update a macro
		///
		///
		/// TCL Syntax: update_macro [-absolute_grid] [-quiet] [-verbose] <macro> <rlocs>
		///
		/// Populate a previously created macro with leaf cells and relative placements.
		/// A macro is made up of primitive, or leaf-level logic cells, and their associated connections,
		/// positioned in a placement grid. The specified relative locations, or <rlocs>, can be based on a
		/// relative grid, or on an absolute grid, called an RPM_GRID. Refer to the Vivado Design Suite User
		/// Guide: Implementation (UG904) for more information on absolute and relative placement grids
		/// A cell can only belong to a one macro. If you attempt to assign a leaf-level cell to multiple macros,
		/// the Vivado tool will return an error. If you attempt to assign a non-primitive cell to a macro, the
		/// tool will return an error.
		/// To change the contents of an existing macro, you must delete the macro with delete_macro,
		/// recreate it with create_macro, and update it with new contents. You cannot simply overwrite
		/// or modify an existing macro.
		///
		/// The following example creates a macro named usbMacro0, sets the current instance to the
		/// usbEngine0/u0 module, assigns three cells to the macro, with a relative placement for each cell
		/// to have two of them placed inside the same Slice, and the third placed in a vertically adjacent
		/// Slice:
		/// create_macro usbMacro0
		/// current_instance usbEngine0/u0
		/// update_macro usbMacro0 {rx_active_reg X0Y0 \
		/// rx_err_reg X0Y0 rx_valid_reg X0Y1}
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The following example creates a macro named usbMacro1, assigns three cells to the macro using
		/// the hierarchical path to the leaf-cell, with absolute coordinates specified for the cells in the
		/// macro:
		/// create_macro usbMacro1
		/// set Site1 [get_sites SLICE_X8Y77]
		/// set Site2 [get_sites SLICE_X9Y77]
		/// set Site3 [get_sites SLICE_X8Y78]
		/// set RPM1 X[get_property RPM_X $Site1]Y[get_property RPM_Y $Site1]
		/// set RPM2 X[get_property RPM_X $Site2]Y[get_property RPM_Y $Site2]
		/// set RPM3 X[get_property RPM_X $Site3]Y[get_property RPM_Y $Site3]
		/// update_macro usbMacro1 -absolute_grid "usbEngine1/u0/rx_active_reg $RPM1 \
		/// usbEngine1/u0/rx_err_reg $RPM2 usbEngine1/u0/rx_valid_reg $RPM3"
		/// Note: In the prior example, notice the use of Tcl variables to capture the Sites of interest, and extract the
		/// RPM_X and RPM_Y properties of those sites for use in the update_macro command. Also notice the use
		/// of quotes ("") instead of curly braces ({}) in the update_macro command. This is to allow the Tcl shell to
		/// perform variable substitution of the command. Refer to the Vivado Design Suite User Guide: Using Tcl
		/// Scripting (UG894) for more information on variables and variable substitution.
		/// This command reports the properties on the usbMacro1 macro to see the absolute grid
		/// coordinates assigned to the cells in the macro:
		/// report_property -all [get_macros usbMacro1]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1776
		/// </summary>
		/// <param name="macro">(Required) Macro to update</param>
		/// <param name="rlocs">(Required) a list interleaved instances and site names</param>
		/// <param name="absolute_grid">(Optional) Use absolute grid for relative locations</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL update_macro(string macro, string rlocs, bool? absolute_grid = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: update_macro [-absolute_grid] [-quiet] [-verbose] <macro> <rlocs>
			_tcl.Entry(_builder.update_macro(macro, rlocs, absolute_grid, quiet, verbose));
			return _tcl;
		}
	}
}
