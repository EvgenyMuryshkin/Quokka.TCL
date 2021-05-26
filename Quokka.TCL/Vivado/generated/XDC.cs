#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
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
		/// <para>
		/// Add cells to a Pblock<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: add_cells_to_pblock [-top] [-add_primitives] [-clear_locs] [-quiet] [-verbose] &lt;pblock&gt; [&lt;cells&gt;...]
		/// <br/>
		/// <para>
		/// Adds specified logic instances to a Pblock in an open implemented design. Once cells have been<br/>
		/// added to a Pblock, you can place the Pblocks onto the fabric of the FPGA using the<br/>
		/// resize_pblock command. The resize_pblock command can also be used to manually<br/>
		/// move and resize Pblocks.<br/>
		/// You can remove instances from the Pblock using the remove_cells_from_pblock command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a Pblock called pb_cpuEngine, and then adds only the leaf-cells<br/>
		/// found in the cpuEngine module, clearing placement constraints for placed instances:<br/>
		/// create_pblock pb_cpuEngine<br/>
		/// add_cells_to_pblock pb_cpuEngine [get_cells cpuEngine/*] \<br/>
		/// -add_primitives -clear_locs<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 35<br/>
		/// </para>
		/// </summary>
		/// <param name="pblock">(Required) Pblock to add cells to</param>
		/// <param name="top">
		/// <para>
		/// (Optional)<br/>
		/// Add the top level instance; This option can't be used with -<br/>
		/// cells, or -add_primitives options. You must specify either -<br/>
		/// cells or -top option.<br/>
		/// </para>
		/// </param>
		/// <param name="add_primitives">
		/// <para>
		/// (Optional)<br/>
		/// Assign to the pblock only primitive cells from the specified<br/>
		/// list of cells.<br/>
		/// </para>
		/// </param>
		/// <param name="clear_locs">(Optional) Clear instance location constraints</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="cells">
		/// <para>
		/// (Optional)<br/>
		/// Cells to add. You can't use this option with -top option. You<br/>
		/// must specify either -cells or -top option.<br/>
		/// </para>
		/// </param>
		public TTCL add_cells_to_pblock(TCLObject pblock, bool? top = null, bool? add_primitives = null, bool? clear_locs = null, bool? quiet = null, bool? verbose = null, TCLObjectList cells = null)
		{
			// TCL Syntax: add_cells_to_pblock [-top] [-add_primitives] [-clear_locs] [-quiet] [-verbose] <pblock> [<cells>...]
			_tcl.Entry(_builder.add_cells_to_pblock(pblock, top, add_primitives, clear_locs, quiet, verbose, cells));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Add power sources to power Rail<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: add_to_power_rail [-power_sources &lt;args&gt;] [-quiet] [-verbose] &lt;power_rail&gt;
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 59<br/>
		/// </para>
		/// </summary>
		/// <param name="power_rail">(Required) Power rail to add sources to</param>
		/// <param name="power_sources">(Optional) List of power_sources to add. Can be power rails and/or power supplies</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL add_to_power_rail(TCLObject power_rail, TCLParameterList power_sources = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: add_to_power_rail [-power_sources <args>] [-quiet] [-verbose] <power_rail>
			_tcl.Entry(_builder.add_to_power_rail(power_rail, power_sources, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of all clocks in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: all_clocks [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Returns a list of all clocks that have been declared in the current design.<br/>
		/// To get a list of specific clocks in the design, use the get_clocks command, or use the filter<br/>
		/// command to filter the results returned by all_clocks.<br/>
		/// Clocks can be defined by using the create_clock or create_generated_clock<br/>
		/// commands.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example shows all clocks in the sample CPU netlist project:<br/>
		/// % all_clocks<br/>
		/// cpuClk wbClk usbClk phy_clk_pad_0_i phy_clk_pad_1_i fftClk<br/>
		/// The following example applies the set_propagated_clock command to all clocks, and also<br/>
		/// demonstrates how the returned list (all_clocks) can be passed to another command:<br/>
		/// % set_propagated_clock [all_clocks]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 72<br/>
		/// </para>
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
		/// <para>
		/// Get a list of cpu cells in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: all_cpus [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Returns a list of all CPU cell objects in the current design. Creates a list of all the CPU cell objects<br/>
		/// that have been declared in the current design.<br/>
		/// The list of CPUs returned by all_cpus can also be limited or reduced by the filter command<br/>
		/// to filter according to properties assigned to the CPU cell objects. Properties of an object can be<br/>
		/// returned by the list_property or report_property commands.<br/>
		/// The all_cpus command is scoped to return the objects hierarchically, from the top-level of the<br/>
		/// design or from the level of the current instance. By default the current instance is defined as the<br/>
		/// top level of the design, but can be changed by using the current_instance command.<br/>
		/// Note: This command returns a list of CPU cell objects<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns all CPU objects in the current design:<br/>
		/// all_cpus<br/>
		/// The following example shows how the list returned can be passed to another command:<br/>
		/// set_false_path -from [all_cpus] -to [all_registers]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 74<br/>
		/// </para>
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
		/// <para>
		/// Get a list of dsp cells in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: all_dsps [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Returns a list of all DSP cell objects that have been declared in the current design.<br/>
		/// The list of DSPs returned by all_dsps can also be limited or reduced by the filter command<br/>
		/// to filter according to properties assigned to the DSP objects. Properties of an object can be<br/>
		/// returned by the list_property or report_property commands.<br/>
		/// The all_dsps command is scoped to return the objects hierarchically, from the top-level of the<br/>
		/// design or from the level of the current instance. By default the current instance is defined as the<br/>
		/// top level of the design, but can be changed by using the current_instance command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns a list of all DSPs defined in the current design, and filters that list<br/>
		/// to return a single DSP assigned to the specified SITE:<br/>
		/// filter [all_dsps] {SITE == DSP48_X1Y6}<br/>
		/// The following example shows how the list returned can be passed to another command:<br/>
		/// set_false_path -from [all_dsps] -to [all_registers]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 76<br/>
		/// </para>
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
		/// <para>
		/// Get a list of pins or cells in fanin of specified sinks<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: all_fanin [-startpoints_only] [-flat] [-only_cells] [-levels &lt;arg&gt;] [-pin_levels &lt;arg&gt;] [-trace_arcs &lt;arg&gt;] [-quiet] [-verbose] &lt;to&gt;
		/// <br/>
		/// <para>
		/// Returns a list of port, pin or cell objects in the fan-in of the specified sinks.<br/>
		/// The all_fanin command is scoped to return objects from current level of the hierarchy of the<br/>
		/// design, either from the top-level or from the level of the current instance. By default the current<br/>
		/// instance is defined as the top level of the design, but can be changed by using the<br/>
		/// current_instance command. To return the fan-in across all levels of the hierarchy, use the -<br/>
		/// flat option.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example lists the timing fan-in of the led_pins output port:<br/>
		/// all_fanin [get_ports led_pins[*] ]<br/>
		/// The following example traces back from the clock pin of the specified flip- flop to the clock<br/>
		/// source (an MMCM output pin in this example):<br/>
		/// all_fanin -flat -startpoints_only [get_pins cmd_parse_i0/prescale_reg[7]/C]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following examples returns the ports connected to the input pins of IDELAYs, ignoring the<br/>
		/// hierarchy of the design:<br/>
		/// all_fanin -flat -startpoints_only [get_pins IDELAY*/IDATAIN]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 78<br/>
		/// </para>
		/// </summary>
		/// <param name="to">(Required) List of sink pins, ports, or nets</param>
		/// <param name="startpoints_only">(Optional) Find only the timing startpoints</param>
		/// <param name="flat">(Optional) Hierarchy is ignored</param>
		/// <param name="only_cells">(Optional) Only cells</param>
		/// <param name="levels">(Optional) Maximum number of cell levels to traverse:Value &gt;= 0 Default: 0</param>
		/// <param name="pin_levels">(Optional) Maximum number of pin levels to traverse:Value &gt;= 0 Default: 0</param>
		/// <param name="trace_arcs">(Optional) Type of network arcs to trace: Values: timing, enabled, all</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of cell or pin objects</returns>
		public TTCL all_fanin(TCLObject to, bool? startpoints_only = null, bool? flat = null, bool? only_cells = null, Int32? levels = null, Int32? pin_levels = null, all_fanin_trace_arcs? trace_arcs = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: all_fanin [-startpoints_only] [-flat] [-only_cells] [-levels <arg>] [-pin_levels <arg>] [-trace_arcs <arg>] [-quiet] [-verbose] <to>
			_tcl.Entry(_builder.all_fanin(to, startpoints_only, flat, only_cells, levels, pin_levels, trace_arcs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of pins or cells in fanout of specified sources<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: all_fanout [-endpoints_only] [-flat] [-only_cells] [-levels &lt;arg&gt;] [-pin_levels &lt;arg&gt;] [-trace_arcs &lt;arg&gt;] [-quiet] [-verbose] &lt;from&gt;
		/// <br/>
		/// <para>
		/// Returns a list of port, pin, or cell objects in the fanout of the specified sources.<br/>
		/// The all_fanout command is scoped to return objects from current level of the hierarchy of the<br/>
		/// design, either from the top-level or from the level of the current instance. By default the current<br/>
		/// instance is defined as the top level of the design, but can be changed by using the<br/>
		/// current_instance command. To return the fanout across all levels of the hierarchy, use the -<br/>
		/// flat option.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the fanout for all input ports in the design:<br/>
		/// all_fanout [all_inputs]<br/>
		/// This example gets the fanout for all inputs assigned to I/O Bank 15 in the current design:<br/>
		/// all_fanout [filter [all_inputs] {IOBANK == 15}]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 81<br/>
		/// </para>
		/// </summary>
		/// <param name="from">(Required) List of source pins, ports, or nets</param>
		/// <param name="endpoints_only">(Optional) Find only the timing endpoints</param>
		/// <param name="flat">(Optional) Hierarchy is ignored</param>
		/// <param name="only_cells">(Optional) Only cells</param>
		/// <param name="levels">(Optional) Maximum number of cell levels to traverse:Value &gt;= 0 Default: 0</param>
		/// <param name="pin_levels">(Optional) Maximum number of pin levels to traverse:Value &gt;= 0 Default: 0</param>
		/// <param name="trace_arcs">(Optional) Type of network arcs to trace: Values: timing, enabled, all</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of cell or pin objects</returns>
		public TTCL all_fanout(TCLObject from, bool? endpoints_only = null, bool? flat = null, bool? only_cells = null, Int32? levels = null, Int32? pin_levels = null, all_fanout_trace_arcs? trace_arcs = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: all_fanout [-endpoints_only] [-flat] [-only_cells] [-levels <arg>] [-pin_levels <arg>] [-trace_arcs <arg>] [-quiet] [-verbose] <from>
			_tcl.Entry(_builder.all_fanout(from, endpoints_only, flat, only_cells, levels, pin_levels, trace_arcs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of flip flop cells in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: all_ffs [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Returns a list of all flip flop instances in the current design.<br/>
		/// You can use the get_cells command, or use the filter command to limit the results from<br/>
		/// the all_ffs command to return a list of flip-flop cells matching the specified properties.<br/>
		/// The all_ffs command is scoped to return the objects hierarchically, from the top-level of the<br/>
		/// design or from the level of the current instance. By default the current instance is defined as the<br/>
		/// top level of the design, but can be changed by using the current_instance command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the count of all flops in the design, then returns the count of all<br/>
		/// flops in the fftEngine module:<br/>
		/// current_instance<br/>
		/// INFO: [Vivado 12-618] Current instance is the top level of design<br/>
		/// 'netlist_1'.<br/>
		/// top<br/>
		/// llength [all_ffs]<br/>
		/// 15741<br/>
		/// current_instance fftEngine<br/>
		/// fftEngine<br/>
		/// llength [all_ffs]<br/>
		/// 1519<br/>
		/// This example filters the results of all_ffs to return only the FDRE flops:<br/>
		/// filter [all_ffs] {REF_NAME == FDRE}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 84<br/>
		/// </para>
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
		/// <para>
		/// Get a list of hsio cells in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: all_hsios [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Returns a list of all High Speed IO (HSIO) cell objects that have been declared in the current<br/>
		/// design. These HSIO cell objects can be assigned to a variable or passed into another command.<br/>
		/// The list of high-speed IOs returned by all_hsios can also be limited or reduced by the<br/>
		/// filter command to filter according to properties assigned to the HSIO objects. Properties of<br/>
		/// an object can be returned by the list_property or report_property commands.<br/>
		/// The all_hsios command is scoped to return the objects hierarchically, from the top-level of<br/>
		/// the design or from the level of the current instance. By default the current instance is defined as<br/>
		/// the top level of the design, but can be changed by using the current_instance command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns all HSIO objects in the current design:<br/>
		/// all_hsios<br/>
		/// The following example shows how the list returned can be directly passed to another command:<br/>
		/// set_false_path -from [all_hsios] -to [all_registers]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 86<br/>
		/// </para>
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
		/// <para>
		/// Get a list of all input ports in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: all_inputs [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Returns a list of all input port objects in the current design.<br/>
		/// To get a list of specific inputs in the design, use the get_ports command, or use the filter<br/>
		/// command to filter the results returned by all_inputs.<br/>
		/// The all_inputs command is scoped to return the objects hierarchically, from the top-level of<br/>
		/// the design or from the level of the current instance. By default the current instance is defined as<br/>
		/// the top level of the design, but can be changed by using the current_instance command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns all input port objects in the current design:<br/>
		/// all_inputs<br/>
		/// This example gets all input port objects, filters out the GT ports, and sets the IOSTANDARD<br/>
		/// property for the non-GT ports:<br/>
		/// set non_gt_ports [filter [all_inputs] {!is_gt_term}]<br/>
		/// set_property IOSTANDARD LVCMOS18 $non_gt_ports<br/>
		/// The following example shows how the list returned can be passed to another command:<br/>
		/// set_input_delay 5 -clock REFCLK [all_inputs]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 88<br/>
		/// </para>
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
		/// <para>
		/// Get a list of all latch cells in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: all_latches [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Returns a list of all latches that have been declared in the current design.<br/>
		/// The list of latches returned by all_latches can also be limited or reduced by the filter<br/>
		/// command to filter according to properties assigned to the latches. Properties of an object can be<br/>
		/// returned by the list_property or report_property commands.<br/>
		/// The all_latches command is scoped to return the objects hierarchically, from the top-level of<br/>
		/// the design or from the level of the current instance. By default the current instance is defined as<br/>
		/// the top level of the design, but can be changed by using the current_instance command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns a list of all latches in the current design:<br/>
		/// all_latches<br/>
		/// The following example shows how the list returned can be passed to another command:<br/>
		/// set_false_path -from [all_mults] -to [all_latches]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 90<br/>
		/// </para>
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
		/// <para>
		/// Get a list of all output ports in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: all_outputs [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Returns a list of all output port objects that have been declared in the current design.<br/>
		/// To get a list of specific outputs in the design, use the get_ports command, or use the filter<br/>
		/// command to filter the results returned by all_outputs.<br/>
		/// The all_outputs command is scoped to return the objects hierarchically, from the top-level of<br/>
		/// the design or from the level of the current instance. By default the current instance is defined as<br/>
		/// the top level of the design, but can be changed by using the current_instance command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns all the output ports in the current design:<br/>
		/// all_outputs<br/>
		/// The following example sets the output delay for all outputs in the design:<br/>
		/// set_output_delay 5 -clock REFCLK [all_outputs]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 92<br/>
		/// </para>
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
		/// <para>
		/// Get a list of ram cells in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: all_rams [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Returns a list of all the RAM cell objects present in the current instance, including Block RAMS,<br/>
		/// Block RAM FIFOs, and Distributed RAMS. These RAM cell objects can be assigned to a variable<br/>
		/// or passed into another command.<br/>
		/// To get a list of specific RAM cells in the design, use the filter command to filter the results<br/>
		/// returned by all_rams based on properties assigned to the RAM cells. Properties of an object<br/>
		/// can be returned by the list_property or report_property commands.<br/>
		/// The all_rams command is scoped to return the objects hierarchically, from the top-level of the<br/>
		/// design or from the level of the current instance. By default the current instance is defined as the<br/>
		/// top level of the design, but can be changed by using the current_instance command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns all RAM cells in the design:<br/>
		/// all_rams<br/>
		/// This example returns all RAM cells in the design, and filters the results to return only the FIFO<br/>
		/// block memories:<br/>
		/// filter [all_rams] {PRIMITIVE_SUBGROUP == fifo}<br/>
		/// The following example sets the current instance, and returns all RAM objects hierarchically from<br/>
		/// the level of the current instance:<br/>
		/// current_instance usbEngine0<br/>
		/// all_rams<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 94<br/>
		/// </para>
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
		/// <para>
		/// Get a list of register cells or pins in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: all_registers [-clock &lt;args&gt;] [-rise_clock &lt;args&gt;] [-fall_clock &lt;args&gt;] [-cells] [-data_pins] [-clock_pins] [-async_pins] [-output_pins] [-level_sensitive] [-edge_triggered] [-no_hierarchy] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Returns a list of sequential register cells or register pins in the current design.<br/>
		/// TIP: Returned objects includes DSPs and BRAMs as they contain internal registers.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The list of returned objects can be limited by the use of the arguments described below. You can<br/>
		/// limit the list of registers returned to a specific clock or clocks, or to registers triggered by the<br/>
		/// rising or falling edge of a specified clock.<br/>
		/// The list of registers returned by all_registers can also be limited or reduced by the filter<br/>
		/// command to filter according to properties assigned to the registers. Properties of an object can<br/>
		/// be returned by the list_property or report_property commands.<br/>
		/// You can also get a list of the pins of collected registers instead of the register objects by<br/>
		/// specifying one or more of the pin arguments.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns a list of registers that are triggered by the falling edge of any clock<br/>
		/// in the design:<br/>
		/// all_registers -fall_clock [all_clocks]<br/>
		/// The following example sets the minimum delay:<br/>
		/// set_min_delay 2.0 -to [all_registers -clock CCLK -data_pins]<br/>
		/// The following example extracts all registers on clk_A with *meta* in the name:<br/>
		/// filter [all_registers -clock clk_A] {name =~ *meta*}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 96<br/>
		/// </para>
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
		public TTCL all_registers(TCLParameterList clock = null, TCLParameterList rise_clock = null, TCLParameterList fall_clock = null, bool? cells = null, bool? data_pins = null, bool? clock_pins = null, bool? async_pins = null, bool? output_pins = null, bool? level_sensitive = null, bool? edge_triggered = null, bool? no_hierarchy = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: all_registers [-clock <args>] [-rise_clock <args>] [-fall_clock <args>] [-cells] [-data_pins] [-clock_pins] [-async_pins] [-output_pins] [-level_sensitive] [-edge_triggered] [-no_hierarchy] [-quiet] [-verbose]
			_tcl.Entry(_builder.all_registers(clock, rise_clock, fall_clock, cells, data_pins, clock_pins, async_pins, output_pins, level_sensitive, edge_triggered, no_hierarchy, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Connect debug slave instances to the master instance. A valid master is a debug bridge or debug<br/>
		/// hub instance configured in "From BSCAN To DebugHUB" mode. A valid slave could be any of the<br/>
		/// following debug cores (Ex: ILA, VIO, JTAG_to_AXI). connect_debug_cores can only connect<br/>
		/// master and slave instances that exist in the same region (either in Reconfigurable Partition or<br/>
		/// static)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: connect_debug_cores -master &lt;args&gt; -slaves &lt;args&gt; [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Connect debug slave instances to the specified master instance. The command can add the<br/>
		/// specified slaves into an existing debug chain, where the specified slaves will be connected to the<br/>
		/// debug hub or bridge, without affecting debug slaves that are already in the connection chain.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Debug masters include both the Debug Hub and Debug Bridge. The Vivado Debug Hub core<br/>
		/// provides an interface between the JTAG Boundary Scan (BSCAN) interface of the Xilinx device<br/>
		/// and the Vivado Debug cores, including the Integrated Logic Analyzer (ILA), Virtual Input/Output<br/>
		/// (VIO), and the JTAG-to-AXI. The Vivado Debug Bridge is a debug controller that provides<br/>
		/// multiple options to communicate with the debug cores in both flat designs, or Partial<br/>
		/// Reconfiguration (PR) designs. The Debug Bridge can be configured to debug designs using a<br/>
		/// JTAG cable, or remotely through Ethernet, PCIe, or other interfaces using a Xilinx Virtual Cable<br/>
		/// (XVC), without the need for a JTAG cable. Refer to the Vivado Design Suite User Guide: Vivado<br/>
		/// Programming and Debugging (UG908) for more information.<br/>
		/// IMPORTANT! For Partial Reconfiguration (PR) designs, the connect_debug_cores command can<br/>
		/// only connect master and slave instances that occur in the Static Region, or in the same Reconfigurable<br/>
		/// Partition.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example connects the specified ILA cores to the debug bridge:<br/>
		/// connect_debug_cores -master [get_cells inst_count/debug_bridge_0] \<br/>
		/// -slaves [list [get_cells inst_count/ila_0] [get_cells inst_count/ila_1] ]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 198<br/>
		/// </para>
		/// </summary>
		/// <param name="master">
		/// <para>
		/// (Required)<br/>
		/// A valid debug bridge or debug hub instance configured in<br/>
		/// "From BSCAN To DebugHUB" mode. Only one master<br/>
		/// instance is allowed.<br/>
		/// </para>
		/// </param>
		/// <param name="slaves">
		/// <para>
		/// (Required)<br/>
		/// List of valid slave instances. A valid slave instance is any of<br/>
		/// the following debug cores (Ex: ILA, VIO, JTAG_to_AXI)<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>debug master and slave instances</returns>
		public TTCL connect_debug_cores(TCLParameterList master, TCLParameterList slaves, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: connect_debug_cores -master <args> -slaves <args> [-quiet] [-verbose]
			_tcl.Entry(_builder.connect_debug_cores(master, slaves, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Connect nets and pins to debug port channels<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: connect_debug_port [-channel_start_index &lt;arg&gt;] [-quiet] [-verbose] &lt;port&gt; &lt;nets&gt;...
		/// <br/>
		/// <para>
		/// Connects a signal from the netlist design to a port on an ILA debug core that was added to the<br/>
		/// design using the create_debug_core command. The signal can either be connected to a<br/>
		/// specific channel index on the port, or simply connected to an available channel on the port.<br/>
		/// If you try to connect too many signals to a port, or there are not enough channels to support the<br/>
		/// connection, the tool will return an error.<br/>
		/// Additional ports can be added to a debug core through the use of the create_debug_port<br/>
		/// command, and you can increase the available channels on an existing port with the<br/>
		/// set_property port_width command. See the examples below.<br/>
		/// You can disconnect signals from ports using the disconnect_debug_port command.<br/>
		/// When the debug core has been defined and connected, you can implement the debug core as a<br/>
		/// block for inclusion in the netlist design. Use the implement_debug_core command to<br/>
		/// implement the core.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a new PROBE port on the myCore debug core, increases the<br/>
		/// PORT_WIDTH property of the port in order to prepare it to receive the number of signals to be<br/>
		/// connected, and connects signals to the port starting at the third channel position (index 2).<br/>
		/// create_debug_port myCore PROBE<br/>
		/// set_property PORT_WIDTH 8 [get_debug_ports myCore/PROBE1]<br/>
		/// connect_debug_port myCore/PROBE1 [get_nets [list m0_ack_o m0_cyc_i \<br/>
		/// m0_err_o m0_rty_o m0_stb_i m0_we_i ]] -channel_start_index 2<br/>
		/// Note: If you specify too many nets to connect to the available channels on the port, the tool will return an<br/>
		/// error and will not connect the ports.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 201<br/>
		/// </para>
		/// </summary>
		/// <param name="port">(Required) Debug port name</param>
		/// <param name="nets">(Required) List of nets or pins</param>
		/// <param name="channel_start_index">(Optional) Connect nets starting at channel index</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL connect_debug_port(TCLObject port, TCLObjectList nets, String channel_start_index = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: connect_debug_port [-channel_start_index <arg>] [-quiet] [-verbose] <port> <nets>...
			_tcl.Entry(_builder.connect_debug_port(port, nets, channel_start_index, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a clock object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_clock -period &lt;arg&gt; [-name &lt;arg&gt;] [-waveform &lt;args&gt;] [-add] [-quiet] [-verbose] [&lt;objects&gt;]
		/// <br/>
		/// <para>
		/// TIP: The XDC &gt; Timing Constraints language templates and the Timing Constraints Wizard in the Vivado<br/>
		/// IDE offer timing diagrams and additional details around defining specific timing constraints. You can refer<br/>
		/// to these sources for additional information.<br/>
		/// Create a clock object with the specified period or waveform defined in nanoseconds (ns). This<br/>
		/// command defines primary clocks which are used by the timing engine as the delay propagation<br/>
		/// starting point of any clock edge. The defined clock can be added to the definition of an existing<br/>
		/// clock, or overwrite the existing clock.<br/>
		/// A virtual clock can be created that has no source in the design. A virtual clock can be used as a<br/>
		/// time reference for setting input and output delays but does not physically exist in the design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// A clock can also be generated from an existing physical clock, and derive many of its properties<br/>
		/// from the master clock. Use the create_generated_clock command to derive a clock from<br/>
		/// an existing physical clock.<br/>
		/// IMPORTANT! If you use create_clock to create a generated clock, instead of<br/>
		/// create_generated_clock, the created clock does not inherit any of the properties of its source<br/>
		/// clock. The insertion delay and jitter of the parent clock will not be propagated to the generated clock,<br/>
		/// causing incorrect timing calculations.<br/>
		/// The create_clock command returns the name of the clock object that is created.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a physical clock called bftClk and defines the clock period:<br/>
		/// create_clock -name bftClk -period 5.000 [get_ports bftClk]<br/>
		/// Note: If the get_ports command defining the objects is left off of this example, a virtual clock is created<br/>
		/// in the design rather than a physical clock.<br/>
		/// The following example creates a clock named clk on the input port, bftClk, with a period of 10ns,<br/>
		/// the rising edge at 2.4ns and the falling edge at 7.4ns:<br/>
		/// create_clock -name clk -period 10.000 -waveform {2.4 7.4} [get_ports bftClk]<br/>
		/// The following example creates a virtual clock since no clock source is specified:<br/>
		/// create_clock -name virtual_clock -period 5.000<br/>
		/// The following example creates a clock with the falling edge at 2ns and the rising edge at 7ns:<br/>
		/// create_clock -name clk -period 10.000 -waveform {7 2} [get_ports bftClk]<br/>
		/// Note: Because the falling edge is earlier than the rising edge in the -waveform definition, although it is<br/>
		/// specified as arg2, it occurs first in the waveform.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 246<br/>
		/// </para>
		/// </summary>
		/// <param name="period">(Required) Clock period: Value &gt; 0</param>
		/// <param name="name">(Optional) Clock name</param>
		/// <param name="waveform">(Optional) Clock edge specification</param>
		/// <param name="add">(Optional) Add to the existing clock in source_objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">(Optional) List of clock source ports, pins or nets</param>
		/// <returns>new clock object</returns>
		public TTCL create_clock(String period, String name = null, TCLParameterList waveform = null, bool? add = null, bool? quiet = null, bool? verbose = null, TCLObject objects = null)
		{
			// TCL Syntax: create_clock -period <arg> [-name <arg>] [-waveform <args>] [-add] [-quiet] [-verbose] [<objects>]
			_tcl.Entry(_builder.create_clock(period, name, waveform, add, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new Integrated Logic Analyzer debug core<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_debug_core [-quiet] [-verbose] &lt;name&gt; &lt;type&gt;
		/// <br/>
		/// <para>
		/// Adds a new Integrated Logic Analyzer (ILA) debug core to an open netlist design in the current<br/>
		/// project. The ILA debug core defines ports for connecting nets to for debugging the design in the<br/>
		/// logic analyzer feature of the Vivado Design Suite available through the open_hw command.<br/>
		/// ILA debug cores can be added to the RTL source files of the design using debug cores from the<br/>
		/// Xilinx IP catalog, or added to the netlist design after synthesis using this command. Refer to the<br/>
		/// Vivado Design Suite User Guide: Vivado Programming and Debugging (UG908) for more information<br/>
		/// on using ILA debug cores.<br/>
		/// Note: A debug core can only be added to an open netlist design using this command.<br/>
		/// The ILA core is created with a CLK port and a PROBE port by default. The CLK port defines the<br/>
		/// clock domain for the ILA core, and allows you to probe signals that are common to that domain.<br/>
		/// The CLK port only supports one clock signal, and so you must create a separate debug core for<br/>
		/// each clock domain. The PROBE port provides a probe point for nets marked for debug with the<br/>
		/// MARK_DEBUG property. The PROBE port offers multiple channels to probe multiple nets from a<br/>
		/// single ILA core.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// You can add new ports to an existing ILA core with the create_debug_port command, and<br/>
		/// connect signals to the ports using the connect_debug_port command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example opens the synthesis run, creating the specified netlist design name, and<br/>
		/// then creates a new ILA debug core in that design:<br/>
		/// open_run -name netlist_1 synth_1<br/>
		/// create_debug_core myCore ila<br/>
		/// The properties of the debug core can be customized by using the set_property command as<br/>
		/// in the following example:<br/>
		/// set_property C_DATA_DEPTH 2048 [get_debug_cores myCore]<br/>
		/// This example marks a sequence of nets for debugging using the MARK_DEBUG property, creates<br/>
		/// a new debug core, connects the CLK port to the appropriate clock domain, and assigns the debug<br/>
		/// nets to the PROBE ports on the core:<br/>
		/// set_property MARK_DEBUG true [get_nets [list {control_reg[0]}<br/>
		/// {control_reg[1]} \<br/>
		/// {control_reg[2]} {control_reg[3]} {control_reg[4]} {control_reg[5]} \<br/>
		/// {control_reg[6]} {control_reg[7]} {control_reg[8]} {control_reg[9]} \<br/>
		/// {control_reg[10]} {control_reg[11]} {control_reg[12]} {control_reg[13]}<br/>
		/// \<br/>
		/// {control_reg[14]} {control_reg[15]} {control_reg[16]} {control_reg[17]}<br/>
		/// \<br/>
		/// {control_reg[18]} {control_reg[19]} {control_reg[20]} {control_reg[21]}<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// \<br/>
		/// {control_reg[22]} {control_reg[23]} {control_reg[24]} {control_reg[25]}<br/>
		/// \<br/>
		/// {control_reg[26]} {control_reg[27]} {control_reg[28]} {control_reg[29]}<br/>
		/// \<br/>
		/// {control_reg[30]} {control_reg[31]}]]<br/>
		/// create_debug_core u_ila_0 ila<br/>
		/// set_property port_width 1 [get_debug_ports u_ila_0/CLK]<br/>
		/// connect_debug_port u_ila_0/CLK [get_nets [list wbClk ]]<br/>
		/// set_property port_width 32 [get_debug_ports u_ila_0/PROBE0]<br/>
		/// connect_debug_port u_ila_0/PROBE0 [get_nets [list {control_reg[0]}<br/>
		/// {control_reg[1]} {control_reg[2]} {control_reg[3]} {control_reg[4]} \<br/>
		/// {control_reg[5]} {control_reg[6]} {control_reg[7]} {control_reg[8]} \<br/>
		/// {control_reg[9]} {control_reg[10]} {control_reg[11]} {control_reg[12]}<br/>
		/// \<br/>
		/// {control_reg[13]} {control_reg[14]} {control_reg[15]} {control_reg[16]}<br/>
		/// \<br/>
		/// {control_reg[17]} {control_reg[18]} {control_reg[19]} {control_reg[20]}<br/>
		/// \<br/>
		/// {control_reg[21]} {control_reg[22]} {control_reg[23]} {control_reg[24]}<br/>
		/// \<br/>
		/// {control_reg[25]} {control_reg[26]} {control_reg[27]} {control_reg[28]}<br/>
		/// \<br/>
		/// {control_reg[29]} {control_reg[30]} {control_reg[31]} ]]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 255<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of the new debug core instance</param>
		/// <param name="type">(Required) Type of the new debug core</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>new debug_core object</returns>
		public TTCL create_debug_core(TCLObject name, TCLObject type, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_debug_core [-quiet] [-verbose] <name> <type>
			_tcl.Entry(_builder.create_debug_core(name, type, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new debug port<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_debug_port [-quiet] [-verbose] &lt;name&gt; &lt;type&gt;
		/// <br/>
		/// <para>
		/// Defines a new port to be added to an existing Vivado ILA debug core that was added to the<br/>
		/// design using the create_debug_core command. The port provides connection points on an<br/>
		/// ILA core to attach nets from the design for debugging.<br/>
		/// When a new debug core is created using the create_debug_core command, it includes a clk<br/>
		/// and probe port by default. However, you can add trigger input/output port types as well. Refer<br/>
		/// to the Vivado Design Suite User Guide: Programming and Debugging (UG908) for more information<br/>
		/// on port types and purpose.<br/>
		/// A port can have one or more connection points to support one or more nets to debug. As a<br/>
		/// default new ports are defined as having a width of 1, allowing only one net to be attached. You<br/>
		/// can change the port width of probe ports to support multiple signals using the set_property<br/>
		/// port_width command (see Examples).<br/>
		/// Note: clk, trig_in, trig_in_ack, trig_out, and trig_out_ack ports can only have a width of 1.<br/>
		/// You can connect signals to ports using the connect_debug_port command, modify existing<br/>
		/// probe connections using modify_debug_ports, and disconnect signals with the<br/>
		/// disconnect_debug_port command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a new debug core, and then adds an additional probe port to the<br/>
		/// core, then sets the width of that new port to 8, and connects signals to the probe port:<br/>
		/// create_debug_core myCore ila<br/>
		/// create_debug_port myCore probe<br/>
		/// set_property PORT_WIDTH 8 myCore/probe1<br/>
		/// connect_debug_port -channel_start_index 1 myCore/probe1 \<br/>
		/// {m1_cyc_i m1_ack_o m1_err_o m1_rty_o}<br/>
		/// Note: Recall that the ILA core is created with a clk and probe port by default, so the new probe port is<br/>
		/// automatically numbered as probe1.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 258<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of the debug core instance</param>
		/// <param name="type">(Required) Type of the new debug port</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>new debug_port object</returns>
		public TTCL create_debug_port(TCLObject name, TCLObject type, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_debug_port [-quiet] [-verbose] <name> <type>
			_tcl.Entry(_builder.create_debug_port(name, type, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a generated clock object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_generated_clock [-name &lt;arg&gt;] [-source &lt;args&gt;] [-edges &lt;args&gt;] [-divide_by &lt;arg&gt;] [-multiply_by &lt;arg&gt;] [-combinational] [-duty_cycle &lt;arg&gt;] [-invert] [-edge_shift &lt;args&gt;] [-add] [-master_clock &lt;args&gt;] [-quiet] [-verbose] &lt;objects&gt;
		/// <br/>
		/// <para>
		/// TIP: The XDC &gt; Timing Constraints language templates and the Timing Constraints Wizard in the Vivado<br/>
		/// IDE offer timing diagrams and additional details around defining specific timing constraints. You can refer<br/>
		/// to these sources for additional information.<br/>
		/// Generate a new clock object from an existing physical clock object in the design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Clocks can be added to a design in one of three ways:<br/>
		/// • Primary physical or virtual clocks defined with the create_clock command.<br/>
		/// • Derived clocks defined with the create_generated_clock command generated from a<br/>
		/// primary physical clock.<br/>
		/// • Derived clocks automatically generated by the Vivado Design Suite when a clock propagates<br/>
		/// through an MMCM/PLL/BUFR.<br/>
		/// You can also use the create_generated_clock command to change the name of clocks that<br/>
		/// the Vivado tool has auto-derived from an MMCM/PLL/BUFR. In this case, a new clock is not<br/>
		/// created, but an existing clock defined on the specified source object is renamed to the provided<br/>
		/// name. This requires -name and &lt;object&gt; to be specified, and supports the use of -source<br/>
		/// and/or -master_clock to further identify the clock to rename when multiple clocks exist on<br/>
		/// the source object. Refer to the Vivado Design Suite User Guide: Using Constraints (UG903) for more<br/>
		/// information on renaming auto-derived clocks.<br/>
		/// IMPORTANT! You cannot rename a clock that is already in use by other constraints at the time of<br/>
		/// renaming. You must rename the clock prior to any other appearance or use of the clock in an XDC file.<br/>
		/// This command returns the name of the clock object that is created, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example defines a generated clock that is divided from the master clock found on<br/>
		/// the specified CLK pin. Since -name is not specified, the generated clock is assigned the same<br/>
		/// name as the pin it is assigned to:<br/>
		/// create_generated_clock -divide_by 2 -source \<br/>
		/// [get_pins clkgen/cpuClk] [get_nets fftEngine/CLK]<br/>
		/// The following example defines a generated clock named CLK1 from the specified source clock,<br/>
		/// specifying the edges of the master clock to use as transition points for the generated clock, with<br/>
		/// edges shifted by the specified amount. In this example, the -edges option indicates that the<br/>
		/// second edge of the source clock is the first rising edge of the generated clock, the third edge of<br/>
		/// the source clock is the first falling edge of the generated clock, and the eighth edge of the source<br/>
		/// clock is the second rising edge of the generated clock. These values determine the period of the<br/>
		/// generated clock as the time from edge 2 to edge 8 of the source clock, and the duty cycle as the<br/>
		/// percentage of the period between edge 2 and edge 3 of the source clock. In addition, each edge<br/>
		/// of the generated clock is shifted by the specified amount:<br/>
		/// create_generated_clock -name CLK1 -source CMB/CLKIN -edges {2 3 8} \<br/>
		/// -edge_shift {0 -1.0 -2.0} CMB/CLKOUT<br/>
		/// Note: The waveform pattern of the generated clock is repeated based on the transitions defined by the -<br/>
		/// edges argument.<br/>
		/// This example creates two generated clocks from the output of a MUX, using -master_clock<br/>
		/// to identify which clock to use, using -add to assign the generated clocks to the Q pin of a flip<br/>
		/// flop, and using -name to define a name for the generated clock, since the object it is assigned to<br/>
		/// has multiple clocks assigned:<br/>
		/// create_generated_clock -source [get_pins muxOut] -master_clock M_CLKA \<br/>
		/// -divide_by 2 -add -name gen_CLKA [get_pins flop_Q]<br/>
		/// create_generated_clock -source [get_pins muxOut] -master_clock M_CLKB \<br/>
		/// -divide_by 2 -add -name gen_CLKB [get_pins flop_Q]<br/>
		/// The following example renames the automatically named clock that is derived by the Vivado<br/>
		/// Design Suite on the MMCM clock output:<br/>
		/// create_generated_clock -name CLK_DIV2 [get_pins mmcm/CLKOUT1]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 275<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) List of clock source ports, pins, or nets</param>
		/// <param name="name">(Optional) Generated clock name</param>
		/// <param name="source">(Optional) Master clock source object pin/port</param>
		/// <param name="edges">(Optional) Edge Specification</param>
		/// <param name="divide_by">(Optional) Period division factor: Value &gt;= 1 Default: 1</param>
		/// <param name="multiply_by">(Optional) Period multiplication factor: Value &gt;= 1 Default: 1</param>
		/// <param name="combinational">(Optional) Create a divide_by 1 clock through combinational logic</param>
		/// <param name="duty_cycle">(Optional) Duty cycle of clock period: Range: 0.0 to 100.0 Default: 50.0</param>
		/// <param name="invert">(Optional) Invert the signal</param>
		/// <param name="edge_shift">(Optional) Edge shift specification</param>
		/// <param name="add">(Optional) Add to the existing clock in source_objects</param>
		/// <param name="master_clock">(Optional) Use this clock if multiple clocks present at master pin</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>new clock object</returns>
		public TTCL create_generated_clock(TCLObject objects, String name = null, TCLParameterList source = null, TCLParameterList edges = null, String divide_by = null, String multiply_by = null, bool? combinational = null, String duty_cycle = null, bool? invert = null, TCLParameterList edge_shift = null, bool? add = null, TCLParameterList master_clock = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_generated_clock [-name <arg>] [-source <args>] [-edges <args>] [-divide_by <arg>] [-multiply_by <arg>] [-combinational] [-duty_cycle <arg>] [-invert] [-edge_shift <args>] [-add] [-master_clock <args>] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.create_generated_clock(objects, name, source, edges, divide_by, multiply_by, combinational, duty_cycle, invert, edge_shift, add, master_clock, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a Macro<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_macro [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Create a macro for the relative placement of cells.<br/>
		/// Macros are primarily used to place small groups of associated cells together to improve resource<br/>
		/// efficiency and enable faster interconnections. The create_macro command lets you define<br/>
		/// macros in an open synthesized or implemented design for relative placement by place_design,<br/>
		/// like RPMs defined by the RLOC constraint in RTL source files. Refer to the Vivado Design Suite<br/>
		/// User Guide: Implementation (UG904) for more information on defining relatively placed macros.<br/>
		/// After creating the macro, specific cells can be assigned to the macro using the update_macro<br/>
		/// command. To change a currently defined macro, you must delete the macro with<br/>
		/// delete_macro, recreate the macro, and update the macro with the new contents. You cannot<br/>
		/// simply overwrite an existing macro.<br/>
		/// Use delete_macro to delete a defined macro. Use get_macros to return a list of currently<br/>
		/// defined macros in the design.<br/>
		/// This command operates silently and does not return anything.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a macro called usbMacro1:<br/>
		/// create_macro usbMacro1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 321<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Macro to create.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_macro(TCLObject name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_macro [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_macro(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new Pblock<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_pblock [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Defines a Pblock to allow you to add logic instances for floorplanning purposes.<br/>
		/// You can add logic elements to the Pblock using the add_cells_to_pblock command, and<br/>
		/// then place the Pblocks onto the fabric of the FPGA using the resize_pblocks command. The<br/>
		/// resize_pblock command can also be used to manually move and resize Pblocks.<br/>
		/// You can nest one Pblock inside another for hierarchical floorplanning using the set_property<br/>
		/// command to define the PARENT property as shown in the second example.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a Pblock called pb_cpuEngine, and then adds only the leaf-cells<br/>
		/// found in the cpuEngine module, clearing placement constraints for placed instances:<br/>
		/// create_pblock pb_cpuEngine<br/>
		/// add_cells_to_pblock pb_cpuEngine [get_cells cpuEngine/*] \<br/>
		/// -add_primitives -clear_locs<br/>
		/// The following example shows nesting Pblocks, by creating Pblocks called pb_usbEngine0 and<br/>
		/// pb_usbEngine1, and a third Pblock called pb_usbTop. Then pb_usbEngine0 and pb_usbEngine1<br/>
		/// are nested inside pb_usbTop using the set_property command:<br/>
		/// create_pblock pb_usbEngine0<br/>
		/// create_pblock pb_usbEngine1<br/>
		/// create_pblock pb_usbTop<br/>
		/// set_property PARENT pb_usbTop [get_pblocks {pb_usbEngine?}]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 327<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of the new pblock</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>new pblock object</returns>
		public TTCL create_pblock(TCLObject name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_pblock [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_pblock(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new Power Rail<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_power_rail [-power_sources &lt;args&gt;] [-direct] [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 339<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of the new power rail</param>
		/// <param name="power_sources">(Optional) List of power sources. Can be power rails and/or power supplies</param>
		/// <param name="direct">(Optional) Implies if the power is a direct rail</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>new power_rail object</returns>
		public TTCL create_power_rail(TCLObject name, TCLParameterList power_sources = null, bool? direct = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_power_rail [-power_sources <args>] [-direct] [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_power_rail(name, power_sources, direct, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create property for class of objects(s)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_property [-description &lt;arg&gt;] [-type &lt;arg&gt;] [-enum_values &lt;args&gt;] [-default_value &lt;arg&gt;] [-file_types &lt;args&gt;] [-display_text &lt;arg&gt;] [-quiet] [-verbose] &lt;name&gt; &lt;class&gt;
		/// <br/>
		/// <para>
		/// Creates a new property of the &lt;type&gt; specified with the user-defined &lt;name&gt; for the specified<br/>
		/// &lt;class&gt; of objects. The property that is created can be assigned to an object of the specified class<br/>
		/// with the set_property command, but is not automatically associated with all objects of that<br/>
		/// class.<br/>
		/// The report_property -all command will not report the newly created property for an<br/>
		/// object of the specified class until the property has been assigned to that object.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example defines a property called PURPOSE for cell objects:<br/>
		/// create_property PURPOSE cell<br/>
		/// Note: Because the -type was not specified, the value will default to strings.<br/>
		/// The following example creates a pin property called COUNT which holds an Integer value:<br/>
		/// create_property -type int COUNT pin<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 347<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of property to create</param>
		/// <param name="class">
		/// <para>
		/// (Required)<br/>
		/// Object type to create property for; valid values are: design,<br/>
		/// net, cell, pin, port, pblock, interface, fileset<br/>
		/// </para>
		/// </param>
		/// <param name="description">(Optional) Description of property</param>
		/// <param name="type">
		/// <para>
		/// (Optional)<br/>
		/// Type of property to create; valid values are: string, int, long,<br/>
		/// double, bool, enum, file Default: string<br/>
		/// </para>
		/// </param>
		/// <param name="enum_values">(Optional) Enumeration values</param>
		/// <param name="default_value">(Optional) Default value of type string</param>
		/// <param name="file_types">(Optional) File type extensions (without the dot)</param>
		/// <param name="display_text">(Optional) Text to display when selecting the file in file browser</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The property that was created if success, "" if failure</returns>
		public TTCL create_property(TCLObject name, TCLObject @class, String description = null, String type = null, TCLParameterList enum_values = null, String default_value = null, TCLParameterList file_types = null, String display_text = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_property [-description <arg>] [-type <arg>] [-enum_values <args>] [-default_value <arg>] [-file_types <args>] [-display_text <arg>] [-quiet] [-verbose] <name> <class>
			_tcl.Entry(_builder.create_property(name, @class, description, type, enum_values, default_value, file_types, display_text, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a DRC/METHODOLOGY/CDC message waiver<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_waiver [-type &lt;arg&gt;] [-id &lt;arg&gt;] [-objects &lt;args&gt;] [-from &lt;args&gt;] [-to &lt;args&gt;] [-strings &lt;args&gt;] [-of_objects &lt;args&gt;] [-user &lt;arg&gt;] -description &lt;arg&gt; [-tags &lt;arg&gt;] [-timestamp &lt;arg&gt;] [-scoped] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// After report_drc, report_methodology, or report_cdc commands are run, they return<br/>
		/// messages of specific violations or conditions found in the design. These violations can prevent<br/>
		/// the design from progressing until they have been resolved or addressed in some way. The<br/>
		/// create_waiver command lets you select individual violations or specific checks that can be<br/>
		/// waived for a design, letting you move forward in the design flow.<br/>
		/// IMPORTANT! Use caution when waiving violations. Waivers may let you proceed in the design flow, but<br/>
		/// also let you create a design that is fundamentally flawed.<br/>
		/// The user creating the waiver is required to provide a user ID and description in the<br/>
		/// create_waiver command in order to provide some history of the waiver.<br/>
		/// A waiver must be specified for an individual DRC or methodology violation, or for a specific DRC<br/>
		/// or methodology check, or for a CDC path. The waiver must be assigned to a specific object, or<br/>
		/// specific violation ID, or for paths using -from/-to arguments. The form of the<br/>
		/// create_waiver command varies depending on the check, violation, or object being waived, as<br/>
		/// shown in the examples below.<br/>
		/// TIP: Although many of the arguments are described as optional, some form of identifier is required to<br/>
		/// associate the waiver with its target.<br/>
		/// To save waivers from one design session to the next, you must use write_waivers to create<br/>
		/// an XDC file of the waiver commands, and read_xdc to read those waivers back into the design<br/>
		/// when it is reopened.<br/>
		/// After creating a waiver, you will need to rerun the DRC, methodology, or CDC report to have the<br/>
		/// waiver considered in the analysis. To see what waivers are in place in the current design you can<br/>
		/// use the report_waivers command. In addition, the report_drc, report_methodology,<br/>
		/// and report_cdc commands have options to run the reports on waived violations or checks.<br/>
		/// Use the delete_waivers command to remove waivers from the design.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example creates a waiver for a methodology check based on the specified ID:<br/>
		/// create_waiver -id TIMING-18 -user samwise -description {waive rule check}<br/>
		/// The following example creates a DRC check waiver for the indicated ID on the specified list of<br/>
		/// port objects, and provides the timestamp in local time:<br/>
		/// create_waiver -type DRC -id UCIO-1 -user samwise -desc {waiving DRC<br/>
		/// violation} \<br/>
		/// -objects [get_ports {src_in* dest_out*}] \<br/>
		/// -timestamp [clock format [clock seconds] -gmt 0]<br/>
		/// The following example creates a waiver for specific CDC paths in the design, defined by the -<br/>
		/// from/-to arguments:<br/>
		/// create_waiver -type CDC -id CDC-6 -user samwise \<br/>
		/// -description {Paths to be re-tested later}\<br/>
		/// -from [list [get_pins {inst_xpm_grey/src_gray_ff_reg[3]/C \<br/>
		/// inst_xpm_grey/src_gray_ff_reg[16]/C \<br/>
		/// inst_xpm_grey/src_gray_ff_reg[22]/C \<br/>
		/// inst_xpm_grey/src_gray_ff_reg[25]/C}] ] \<br/>
		/// -to [list [get_pins {inst_xpm_grey/dest_graysync_ff_reg[0][1]/D \<br/>
		/// inst_xpm_grey/dest_graysync_ff_reg[0][6]/D \<br/>
		/// inst_xpm_grey/dest_graysync_ff_reg[0][9]/D \<br/>
		/// inst_xpm_grey/dest_graysync_ff_reg[0][24]/D}] ]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 367<br/>
		/// </para>
		/// </summary>
		/// <param name="description">(Required) Description string of the cause for the waiver</param>
		/// <param name="type">(Optional) Type of waiver - DRC, METHODOLOGY, CDC</param>
		/// <param name="id">
		/// <para>
		/// (Optional)<br/>
		/// ID of the DRC/METHODOLOGY/CDC message being waived,<br/>
		/// not needed for -of_objects use<br/>
		/// </para>
		/// </param>
		/// <param name="objects">
		/// <para>
		/// (Optional)<br/>
		/// List of inserted message objects for which a DRC/<br/>
		/// METHODOLOGY waiver will be set (i.e. %ELG, %SIG, etc. for<br/>
		/// cells or nets, etc., sites, etc., or '*CELL', '*NET', '*SITE', etc.<br/>
		/// as wildcards<br/>
		/// </para>
		/// </param>
		/// <param name="from">
		/// <para>
		/// (Optional)<br/>
		/// List of source (driver) pins or ports (or '*PORT', '*PIN' as<br/>
		/// wildcard) for which a CDC waiver will be set<br/>
		/// </para>
		/// </param>
		/// <param name="to">
		/// <para>
		/// (Optional)<br/>
		/// List of target (load) pins or ports (or '*PORT', '*PIN' as<br/>
		/// wildcard) for which a CDC waiver will be set<br/>
		/// </para>
		/// </param>
		/// <param name="strings">
		/// <para>
		/// (Optional)<br/>
		/// List of inserted message string values for which a DRC/<br/>
		/// METHODOLOGY waiver will be set (i.e. %STR for strings, or<br/>
		/// '*' as wildcard)<br/>
		/// </para>
		/// </param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// List of DRC/METHODOLOGY/CDC violation objects for which<br/>
		/// waiver(s) will be set<br/>
		/// </para>
		/// </param>
		/// <param name="user">
		/// <para>
		/// (Optional)<br/>
		/// Name of the user creating the waiver (required, but if not<br/>
		/// specified, the waivers will take the USER name from the<br/>
		/// environment if it is available)<br/>
		/// </para>
		/// </param>
		/// <param name="tags">
		/// <para>
		/// (Optional)<br/>
		/// Optional list of one or more tags to aid in subsequent<br/>
		/// waiver identification or categorization<br/>
		/// </para>
		/// </param>
		/// <param name="timestamp">
		/// <para>
		/// (Optional)<br/>
		/// Timestamp of waiver - for restaining the original time of a<br/>
		/// waiver being (re)created after being written<br/>
		/// </para>
		/// </param>
		/// <param name="scoped">
		/// <para>
		/// (Optional)<br/>
		/// Flag waiver to interpret object wildcards as scoped to the<br/>
		/// current_instance that is set<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">
		/// <para>
		/// (Optional)<br/>
		/// Suspend message limits during command execution<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// </param>
		/// <returns>waiver</returns>
		public TTCL create_waiver(String description, String type = null, String id = null, TCLParameterList objects = null, TCLParameterList from = null, TCLParameterList to = null, TCLParameterList strings = null, TCLParameterList of_objects = null, String user = null, String tags = null, String timestamp = null, bool? scoped = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_waiver [-type <arg>] [-id <arg>] [-objects <args>] [-from <args>] [-to <args>] [-strings <args>] [-of_objects <args>] [-user <arg>] -description <arg> [-tags <arg>] [-timestamp <arg>] [-scoped] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_waiver(description, type, id, objects, from, to, strings, of_objects, user, tags, timestamp, scoped, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set or get the current design.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_design [-quiet] [-verbose] [&lt;design&gt;]
		/// <br/>
		/// <para>
		/// Defines the current design or returns the name of the current design in the active project.<br/>
		/// The current design and current instance are the target of most Tcl commands, design edits and<br/>
		/// constraint changes made in the tool. The current instance can be defined using the<br/>
		/// current_instance command.<br/>
		/// You can use the get_designs command to get a list of open designs in the active project, and<br/>
		/// use the get_projects command to get a list of open projects.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets the design rtl_1 as the current design:<br/>
		/// current_design rtl_1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 385<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="design">(Optional) Name of current design to be set</param>
		/// <returns>design object</returns>
		public TTCL current_design(bool? quiet = null, bool? verbose = null, TCLObject design = null)
		{
			// TCL Syntax: current_design [-quiet] [-verbose] [<design>]
			_tcl.Entry(_builder.current_design(quiet, verbose, design));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set or get the current instance<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_instance [-quiet] [-verbose] [&lt;instance&gt;]
		/// <br/>
		/// <para>
		/// Set the current instance in the design hierarchy to the specified instance cell or to the top of the<br/>
		/// current design. By default, current_instance points to the top module of the<br/>
		/// current_design, which is not an instantiated cell object. You can also set<br/>
		/// current_instance to reference an instantiated hierarchical cell in the design.<br/>
		/// IMPORTANT! Since the top module is not an instantiated object, current_instance returns an<br/>
		/// empty string rather than a design object, when set to the top-level of the current design.<br/>
		/// The current design and current instance are the target of most of the commands and design<br/>
		/// changes you will make. The current design can be defined using the current_design<br/>
		/// command.<br/>
		/// You must specify the &lt;instance&gt; name relative to the currently defined instance, and use the<br/>
		/// established hierarchy separator to define instance paths. You can determine the current hierarchy<br/>
		/// separator with the get_hierarchy_separator command.<br/>
		/// Use '..' to traverse up the hierarchical instance path when specifying the current instance.<br/>
		/// This command returns the name of the design object of the current_instance, or returns nothing<br/>
		/// when set to the top of current design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets the current instance to the top module of the current design:<br/>
		/// current_instance<br/>
		/// INFO: [Vivado 12-618] Current instance is the top level of design<br/>
		/// 'netlist_1'.<br/>
		/// In this example you have selected an object in the Vivado IDE, and you want to set that selected<br/>
		/// object as the current instance:<br/>
		/// current_instance [lindex [get_selected_objects] 0]<br/>
		/// Note: get_selected_objects returns a list, even of one object, so you must use lindex to specify an<br/>
		/// object from that list.<br/>
		/// The following example first sets the hierarchy separator character, and then sets the current<br/>
		/// instance relative to the presently defined current instance:<br/>
		/// set_hierarchy_separator |<br/>
		/// current_instance ..|cpu_iwb_dat_o|buffer_fifo<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example returns the name of the presently defined current instance:<br/>
		/// current_instance .<br/>
		/// cpuEngine|cpu_iwb_dat_o|buffer_fifo<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 406<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="instance">(Optional) Name of instance</param>
		/// <returns>instance name</returns>
		public TTCL current_instance(bool? quiet = null, bool? verbose = null, TCLObject instance = null)
		{
			// TCL Syntax: current_instance [-quiet] [-verbose] [<instance>]
			_tcl.Entry(_builder.current_instance(quiet, verbose, instance));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Delete a list of macros<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_macros [-quiet] [-verbose] &lt;macros&gt;
		/// <br/>
		/// <para>
		/// Delete one or more macro defined by the create_macro command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example deletes a macro called usbMacro1:<br/>
		/// delete_macros usbMacro1<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 459<br/>
		/// </para>
		/// </summary>
		/// <param name="macros">(Required) Macros to delete</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_macros(TCLObject macros, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_macros [-quiet] [-verbose] <macros>
			_tcl.Entry(_builder.delete_macros(macros, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove Pblock<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_pblocks [-hier] [-quiet] [-verbose] &lt;pblocks&gt;...
		/// <br/>
		/// <para>
		/// Deletes the specified Pblocks from the design. Pblocks are created using the create_pblock<br/>
		/// command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example deletes the specified Pblock as well as any Pblocks nested inside:<br/>
		/// delete_pblocks -hier cpuEngine<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 463<br/>
		/// </para>
		/// </summary>
		/// <param name="pblocks">(Required) Pblocks to delete</param>
		/// <param name="hier">(Optional) Also delete all the children of Pblock</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_pblocks(TCLObjectList pblocks, bool? hier = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_pblocks [-hier] [-quiet] [-verbose] <pblocks>...
			_tcl.Entry(_builder.delete_pblocks(pblocks, hier, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Delete a Power Rail<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_power_rails [-quiet] [-verbose] &lt;power_rail&gt;
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 465<br/>
		/// </para>
		/// </summary>
		/// <param name="power_rail">(Required) power rail to delete</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_power_rails(TCLObject power_rail, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_power_rails [-quiet] [-verbose] <power_rail>
			_tcl.Entry(_builder.delete_power_rails(power_rail, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Filter a list, resulting in new list<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: filter [-regexp] [-nocase] [-quiet] [-verbose] [&lt;objects&gt;] [&lt;filter&gt;]
		/// <br/>
		/// <para>
		/// Takes a list of objects, and returns a reduced list of objects that match the specified filter search<br/>
		/// pattern.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns a list of parts filtered for the specified speed grade:<br/>
		/// filter [get_parts] {speed == -3}<br/>
		/// The following example filters parts based according to speed grade -3 OR speed grade -2. All<br/>
		/// parts matching either speed grade will be returned.<br/>
		/// filter [get_parts] {speed == -3 || speed == -2}<br/>
		/// The following example uses regular expression and returns a list of VStatus ports in the design,<br/>
		/// with zero or more wildcards, and the numbers 0 to 9 appearing one or more times within square<br/>
		/// brackets:<br/>
		/// filter -regexp [get_ports] {NAME =~ VStatus.*\[[0-9]+\]}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 526<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Operators =~ and !~ use regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">(Optional) List of objects to filter</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <returns>new list</returns>
		public TTCL filter(bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, TCLObject objects = null, TCLObject filter = null)
		{
			// TCL Syntax: filter [-regexp] [-nocase] [-quiet] [-verbose] [<objects>] [<filter>]
			_tcl.Entry(_builder.filter(regexp, nocase, quiet, verbose, objects, filter));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of bel_pins. If a design is loaded, gets the constructed site type bels.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_bel_pins [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns a list of pins on the specified BELs, or matching a specified search pattern.<br/>
		/// The default command gets a list of all pins on all BELs on the device.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the pins of the specified BELs associated with the specified range<br/>
		/// of sites on the device:<br/>
		/// get_bel_pins -of_objects [get_bels -of_objects [get_sites \<br/>
		/// -range {SLICE_X0Y0 SLICE_X1Y1}] ]<br/>
		/// The following example returns the clock enable (CE) pins of all BELs on the device:<br/>
		/// get_bel_pins *CE<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 594<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the bel_pin of these bels, sites, pins, or nets.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match bel_pin against patterns Default: *</param>
		/// <returns>bel_pin</returns>
		public TTCL get_bel_pins(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_bel_pins [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_bel_pins(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of bels. If a design is loaded, gets the constructed site type bels.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_bels [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-include_routing_bels] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Basic Elements, or BELs, are building blocks of logic, such as flip-flops, LUTs, and carry logic, that<br/>
		/// make up a SLICE. This command returns a list of BELs on the target part that match a specified<br/>
		/// search pattern in an open design.<br/>
		/// The default command gets a list of all BELs on the device.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the total number of BELs on the target part:<br/>
		/// llength [get_bels]<br/>
		/// The following example returns the BELs associated with the specified site:<br/>
		/// get_bels -of_objects [get_sites PHASER_IN_PHY_X0Y5]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 597<br/>
		/// </para>
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
		public TTCL get_bels(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? include_routing_bels = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_bels [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-include_routing_bels] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_bels(regexp, nocase, filter, of_objects, include_routing_bels, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of cells in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_cells [-hsc &lt;arg&gt;] [-hierarchical] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-match_style &lt;arg&gt;] [-include_replicated_objects] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of cell objects in the current design that match a specified search pattern. The default<br/>
		/// command returns a list of all cells in the current_instance of the open design, as specified by the<br/>
		/// current_instance command.<br/>
		/// You can use the -hierarchical option to extract cells from the hierarchy of the current<br/>
		/// design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The get_cells command also includes an option to get all replicated cells that are added to a<br/>
		/// design during physical optimization, or phys_opt_design. The use of the -<br/>
		/// include_replicated_objects option returns the replicated cells of an object when the<br/>
		/// original cell is returned. You can use this option to ensure that constraints or properties that are<br/>
		/// applied to a cell are also applied to its replicated cells.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example uses regular expression to return cells in the BFT example design that<br/>
		/// match the filter expressions for NAME and REF_NAME. In the first command the NAME is<br/>
		/// specified in the search pattern, while the second command filters on the NAME property. These<br/>
		/// commands return the same results:<br/>
		/// get_cells -regexp -filter { REF_NAME =~ FD.* } .*validFor.*<br/>
		/// get_cells -regexp -filter { NAME =~ .*validFor.* &amp;&amp; REF_NAME =~ FD.* }<br/>
		/// The following example searches all levels of the hierarchy for cells beginning with cpu, or fft, and<br/>
		/// joins each cell returned with the newline character to put it on a separate line:<br/>
		/// join [get_cells -hier {cpu* fft*}] \n<br/>
		/// This example gets a list of properties and property values attached to the second object of the<br/>
		/// list returned by get_cells:<br/>
		/// report_property [lindex [get_cells] 1]<br/>
		/// Note: If there are no cells matching the pattern you will get a warning.<br/>
		/// This example prints a list of the library cells instantiated into the design at all levels of the<br/>
		/// hierarchy, sorting the list for unique names so that each cell is only printed one time:<br/>
		/// foreach cell [lsort -unique [get_property LIB_CELL [get_cells -hier \<br/>
		/// -filter {IS_PRIMITIVE==1}]]] {puts $cell}<br/>
		/// The following example demonstrates the effect of -hierarchical searches, without and with<br/>
		/// -regexp:<br/>
		/// get_cells -hierarchical *mmcm*<br/>
		/// mmcm_replicator_inst_1<br/>
		/// mmcm_replicator_inst_1/mmcm_stage[0].mmcm_channel[0].mmcm<br/>
		/// get_cells -hierarchical -regexp .*mmcm.*<br/>
		/// mmcm_replicator_inst_1<br/>
		/// mmcm_replicator_inst_1/mmcm_stage[0].mmcm_channel[0].mmcm<br/>
		/// mmcm_replicator_inst_1/mmcm_stage[0].mmcm_channel[0].mmcm/GND<br/>
		/// mmcm_replicator_inst_1/mmcm_stage[0].mmcm_channel[0].mmcm/MMCM_Base<br/>
		/// Note: The last two cells (GND and MMCM_Base) were not returned in the first example (without -<br/>
		/// regexp) because the cell names do not match the search pattern, as it is applied to each level of the<br/>
		/// hierarchy.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example runs the report_drc command on the current design, and returns any<br/>
		/// cells associated with DRC violations:<br/>
		/// report_drc -name drc_1<br/>
		/// get_cells -of_objects [get_drc_violations]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 648<br/>
		/// </para>
		/// </summary>
		/// <param name="hsc">(Optional) Hierarchy separator Default: /</param>
		/// <param name="hierarchical">(Optional) Search level-by-level in current instance</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get cells of these pins, timing paths, nets, bels, clock<br/>
		/// regions, sites, or drc violations<br/>
		/// </para>
		/// </param>
		/// <param name="match_style">(Optional) Style of pattern matching Default: sdc Values: ucf, sdc</param>
		/// <param name="include_replicated_objects">
		/// <para>
		/// (Optional)<br/>
		/// Include replicated objects when searching for patterns. This<br/>
		/// option is valid only when patterns is specified.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match cell names against patterns Default: *</param>
		/// <returns>list of cell objects</returns>
		public TTCL get_cells(String hsc = null, bool? hierarchical = null, bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, get_cells_match_style? match_style = null, bool? include_replicated_objects = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_cells [-hsc <arg>] [-hierarchical] [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-include_replicated_objects] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_cells(hsc, hierarchical, regexp, nocase, filter, of_objects, match_style, include_replicated_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of clocks in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_clocks [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-match_style &lt;arg&gt;] [-include_generated_clocks] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of clocks in the current design that match a specified search pattern. The default<br/>
		/// command gets a list of all clocks in the design, like the all_clocks command.<br/>
		/// Clocks can be created using the create_clock or the create_generated_clock<br/>
		/// commands, or can be automatically generated by the tool, at the output of an MMCM for<br/>
		/// instance.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of clocks matching the various search patterns:<br/>
		/// get_clocks {*clock *ck *Clk}<br/>
		/// Note: If there are no clocks matching the pattern you will get a warning.<br/>
		/// The following example gets the master clock object, and all generated clocks derived from that<br/>
		/// clock:<br/>
		/// get_clocks -include_generated_clocks wbClk<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example gets all properties and property values attached to the specified clock:<br/>
		/// report_property -all [get_clocks wbClk]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 660<br/>
		/// </para>
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
		public TTCL get_clocks(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, String match_style = null, bool? include_generated_clocks = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_clocks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-include_generated_clocks] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_clocks(regexp, nocase, filter, of_objects, match_style, include_generated_clocks, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of debug cores in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_debug_cores [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of Vivado Lab Edition debug cores in the current project that match a specified search<br/>
		/// pattern. The default command gets a list of all debug cores in the project.<br/>
		/// Debug cores are added to the project with the create_debug_core command. When a ILA<br/>
		/// debug core (labtools_ila_v3) is added to the project, it is contained within a Debug Hub core<br/>
		/// (labtools_xsdbmasterlib_v2), and includes a CLK port and a PROBE port as a default. Additional<br/>
		/// ports can be added to the debug core with the use of the create_debug_port command.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following command gets a list of the Vivado Lab Edition debug cores in the current project:<br/>
		/// get_debug_cores<br/>
		/// Note: A Debug Hub core is returned as one of the debug cores in the project. You cannot directly create<br/>
		/// this core, but it is automatically added by the tool when you add any ILA cores to the project.<br/>
		/// The following example gets the properties of the specified debug core:<br/>
		/// report_property [get_debug_cores myCore]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 669<br/>
		/// </para>
		/// </summary>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get cores of these debug ports or nets</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match debug cores against patterns Default: *</param>
		/// <returns>list of debug_core objects</returns>
		public TTCL get_debug_cores(String filter = null, TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_debug_cores [-filter <arg>] [-of_objects <args>] [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_debug_cores(filter, of_objects, regexp, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of debug ports in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_debug_ports [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of ports defined on ILA debug cores in the current project that match a specified<br/>
		/// search pattern. The default command gets a list of all debug ports in the project.<br/>
		/// Debug ports are defined when ILA debug cores are created with the create_debug_core<br/>
		/// command. Ports can be added to existing debug cores with the create_debug_port<br/>
		/// command.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following command gets a list of the ports from the ILA debug cores in the current project,<br/>
		/// with a PORT_WIDTH property of 8:<br/>
		/// get_debug_ports -filter {PORT_WIDTH==8}<br/>
		/// The following example gets the properties attached to the specified debug port:<br/>
		/// report_property [get_debug_ports myCore/PROBE1]<br/>
		/// Note: The debug port is defined by the core_name/port_name combination.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 672<br/>
		/// </para>
		/// </summary>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get ports of these debug cores</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match debug ports against patterns Default: *</param>
		/// <returns>list of debug_port objects</returns>
		public TTCL get_debug_ports(String filter = null, TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_debug_ports [-filter <arg>] [-of_objects <args>] [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_debug_ports(filter, of_objects, regexp, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of generated clocks in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_generated_clocks [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-match_style &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of generated clocks in the current project that match a specified search pattern. The<br/>
		/// default command gets a list of all generated clocks in the project.<br/>
		/// A generated clock can be added to the design using the create_generated_clock<br/>
		/// command, or can be automatically generated by the tool, at the output of an MMCM for<br/>
		/// instance.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the names of all generated clocks in the current project:<br/>
		/// get_generated_clocks<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 698<br/>
		/// </para>
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
		public TTCL get_generated_clocks(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, String match_style = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_generated_clocks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_generated_clocks(regexp, nocase, filter, of_objects, match_style, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get hierarchical separator character<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hierarchy_separator [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Gets the character currently used for separating levels of hierarchy in the design. You can set the<br/>
		/// hierarchy separator using the set_hierarchy_separator command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the currently defined hierarchy separator:<br/>
		/// get_hierarchy_separator<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 705<br/>
		/// </para>
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
		/// <para>
		/// Get a list of iobanks.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_iobanks [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of I/O Banks on the target device in the current project that match a specified search<br/>
		/// pattern. The default command gets a list of all I/O Banks on the target device.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the I/O Bank of the specified package pin:<br/>
		/// get_iobanks -of_objects [get_package_pins H4]<br/>
		/// This example returns the GT Banks on the device:<br/>
		/// get_iobanks -filter {BANK_TYPE == BT_MGT}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 803<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get the iobanks of these package_pins, ports, clock regions,<br/>
		/// slrs or sites.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match iobanks against patterns Default: *</param>
		/// <returns>iobanks</returns>
		public TTCL get_iobanks(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_iobanks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_iobanks(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of macros in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_macros [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of macros in the current design that match a specified search pattern. The default<br/>
		/// command returns a list of all macros in the design.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the properties currently assigned to the macro matching the<br/>
		/// specified search pattern:<br/>
		/// report_property [get_macro *Macro1]<br/>
		/// Note: If there are no macros matching the pattern you will get a warning.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 824<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get macros of these cells</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match macro names against patterns Default: *</param>
		/// <returns>list of macro objects</returns>
		public TTCL get_macros(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_macros [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_macros(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of nets in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_nets [-hsc &lt;arg&gt;] [-hierarchical] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-match_style &lt;arg&gt;] [-top_net_of_hierarchical_group] [-segments] [-boundary_type &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of nets in the current design that match a specified search pattern. The default<br/>
		/// command gets a list of all nets in the current_instance of the open design, as specified by the<br/>
		/// current_instance command.<br/>
		/// You can use the -hierarchical option to extract nets from the hierarchy of the current<br/>
		/// design.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example runs the report_drc command on the current design, returns the list of<br/>
		/// violations in the specified DRC report, and then returns any nets associated with the driverless<br/>
		/// net rule (NDRV):<br/>
		/// report_drc -name drc_1<br/>
		/// get_drc_violations -name drc_1<br/>
		/// get_nets -of_objects [get_drc_violations -name drc_1 NDRV*]<br/>
		/// The following example returns a list of nets that have been marked for debug with the<br/>
		/// connect_debug_port command:<br/>
		/// get_nets -hier -filter {MARK_DEBUG==1}<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This example returns the net attached to the specified hierarchical pin object, then returns the<br/>
		/// net segments attached to the pin object, then returns the top-level net segment attached to the<br/>
		/// pin object:<br/>
		/// get_nets \<br/>
		/// -of [get_pins cpuEngine/or1200_cpu/or1200_sprs/esr_reg[9]_i_3/I0]<br/>
		/// get_nets -segments \<br/>
		/// -of [get_pins cpuEngine/or1200_cpu/or1200_sprs/esr_reg[9]_i_3/I0]<br/>
		/// get_nets -top -segments \<br/>
		/// -of [get_pins cpuEngine/or1200_cpu/or1200_sprs/esr_reg[9]_i_3/I0]<br/>
		/// In the following example, the first command applies the -filter to find nets that have the<br/>
		/// IS_INTERNAL property, and then -segment is applied to return the segments of those nets. This<br/>
		/// command returns 0 net segments (and a warning). The second command, returns the segments<br/>
		/// of all nets, and filters the results to find the segments that have the IS_INTERNAL property, of<br/>
		/// which there are 448:<br/>
		/// llength [get_nets -segments -filter {IS_INTERNAL}]<br/>
		/// WARNING: [Vivado 12-1023] No nets matched for command 'get_nets -segments<br/>
		/// -filter IS_INTERNAL'.<br/>
		/// 0<br/>
		/// llength [filter [get_nets -segments] {IS_INTERNAL}]<br/>
		/// 448<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 842<br/>
		/// </para>
		/// </summary>
		/// <param name="hsc">(Optional) Hierarchy separator Default: /</param>
		/// <param name="hierarchical">(Optional) Search level-by-level in current instance</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get nets of these pins, ports, cells, timing paths or clocks,<br/>
		/// drc violations<br/>
		/// </para>
		/// </param>
		/// <param name="match_style">(Optional) Style of pattern matching, valid values are ucf, sdc Default: sdc</param>
		/// <param name="top_net_of_hierarchical_group">
		/// <para>
		/// (Optional)<br/>
		/// Return net segment(s) which belong(s) to the high level of a<br/>
		/// hierarchical net<br/>
		/// </para>
		/// </param>
		/// <param name="segments">(Optional) Return all segments of a net across the hierarchy</param>
		/// <param name="boundary_type">
		/// <para>
		/// (Optional)<br/>
		/// Return net segment connected to a hierarchical pin which<br/>
		/// resides at the same level as the pin (upper) or at the level<br/>
		/// below (lower), or both. Valid values are : upper, lower, both<br/>
		/// Default: upper<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match net names against patterns Default: *</param>
		/// <returns>list of net objects</returns>
		public TTCL get_nets(String hsc = null, bool? hierarchical = null, bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, String match_style = null, bool? top_net_of_hierarchical_group = null, bool? segments = null, String boundary_type = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_nets [-hsc <arg>] [-hierarchical] [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-top_net_of_hierarchical_group] [-segments] [-boundary_type <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_nets(hsc, hierarchical, regexp, nocase, filter, of_objects, match_style, top_net_of_hierarchical_group, segments, boundary_type, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of nodes in the device.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_nodes [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-uphill] [-downhill] [-flyover] [-from &lt;args&gt;] [-to &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns a list of nodes on the device that match a specified search pattern in an open design.<br/>
		/// The default command gets a list of all nodes on the device.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the nodes associated with the specified tile:<br/>
		/// get_nodes -of_objects [get_tiles CLBLM_R_X11Y158]<br/>
		/// The following example returns the nodes downhill from the specified node:<br/>
		/// get_nodes -downhill -of_objects [get_nodes LIOB33_SING_X0Y199/IOB_PADOUT0]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 847<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'node' objects of these types: 'net tile node bel_pin<br/>
		/// site_pin wire pip speed_model'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="uphill">
		/// <para>
		/// (Optional)<br/>
		/// Get the nodes uphill (driver) from the site_pin, pip, node or<br/>
		/// tile(s) provided in the -of_objects.<br/>
		/// </para>
		/// </param>
		/// <param name="downhill">
		/// <para>
		/// (Optional)<br/>
		/// Get the nodes downhill (loads) from the site_pin, pip, node<br/>
		/// or tile(s) provided in the -of_objects.<br/>
		/// </para>
		/// </param>
		/// <param name="flyover">(Optional) Get the nodes that fly over the given tile(s).</param>
		/// <param name="from">
		/// <para>
		/// (Optional)<br/>
		/// -from &lt;pip/site pin&gt; Return the nodes beginning at this pip<br/>
		/// or site pin. May be used in combination with uphill. Default<br/>
		/// is downhill. -all is implied.<br/>
		/// </para>
		/// </param>
		/// <param name="to">
		/// <para>
		/// (Optional)<br/>
		/// -to &lt;pip/site pin&gt; Return the nodes ending at this wire or<br/>
		/// site pin. May be used in combination with uphill. Default is<br/>
		/// downhill. -all is implied.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'node' objects against patterns. Default: *</param>
		/// <returns>nodes</returns>
		public TTCL get_nodes(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? uphill = null, bool? downhill = null, bool? flyover = null, TCLParameterList from = null, TCLParameterList to = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_nodes [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-uphill] [-downhill] [-flyover] [-from <args>] [-to <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_nodes(of_objects, regexp, nocase, filter, uphill, downhill, flyover, from, to, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of package pins<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_package_pins [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of the pins on the selected package for the target device. The default command gets a<br/>
		/// list of all pins on the package.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of the package pins associated with the specified bytegroup of<br/>
		/// an UltraScale device:<br/>
		/// get_package_pins -of [get_pkgpin_bytegroups BANK44_BYTE0]<br/>
		/// The following example gets the number of clock capable (CC) pins on the package:<br/>
		/// llength [get_package_pins -filter {IS_CLK_CAPABLE==1}]<br/>
		/// Note: If there are no pins matching the pattern you will get a warning.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 855<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get the list of package pin objects of these sites, bels,<br/>
		/// iobanks, pkgpin_bytegroups, pkgpin_nibbles, or ports.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match list of package pin objects against patterns Default: *</param>
		/// <returns>list of package pin objects</returns>
		public TTCL get_package_pins(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_package_pins [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_package_pins(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of path groups in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_path_groups [-regexp] [-nocase] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of timing path groups in the current project that match a specified search pattern. The<br/>
		/// default command gets a list of all path groups in the design.<br/>
		/// Path groups are automatically created when a new clock is created in the design, containing all<br/>
		/// paths in that clocks domain. Path groups can also be manually created with the use of the<br/>
		/// group_path command.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of all the path groups in the design.<br/>
		/// get_path_groups<br/>
		/// The following example gets all path groups with the string "Clk" somewhere in the name:<br/>
		/// get_path_groups *Clk*<br/>
		/// Note: If no path groups match the pattern you will get a warning.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 866<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match path group names against patterns Default: *</param>
		/// <returns>list of path groups</returns>
		public TTCL get_path_groups(bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_path_groups [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_path_groups(regexp, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of Pblocks in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_pblocks [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-include_nested_pblocks] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of Pblocks defined in the current project that match a specific pattern. The default<br/>
		/// command gets a list of all Pblocks in the project.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of all Pblocks in the current project:<br/>
		/// get_pblocks<br/>
		/// This example gets a list of all Pblocks which do not have a Slice Range defined:<br/>
		/// get_pblocks -filter {GRIDTYPES !~ SLICE}<br/>
		/// The following example gets the Pblock assignments of the specified cell:<br/>
		/// get_pblocks -of [get_cells CORE/BR_TOP/RLD67_MUX/REG_PMBIST_C1]<br/>
		/// This example returns the specified Pblock, including any nested Pblocks:<br/>
		/// get_pblocks -include_nested_pblocks usbTop<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 868<br/>
		/// </para>
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
		public TTCL get_pblocks(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? include_nested_pblocks = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_pblocks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-include_nested_pblocks] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pblocks(regexp, nocase, filter, of_objects, include_nested_pblocks, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of pins in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_pins [-hsc &lt;arg&gt;] [-hierarchical] [-regexp] [-nocase] [-leaf] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-match_style &lt;arg&gt;] [-include_replicated_objects] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of pin objects in the current design that match a specified search pattern. The default<br/>
		/// command gets a list of all pins in the current_instance of the open design, as specified by the<br/>
		/// current_instance command. You can use the -hierarchical option to extract pins from<br/>
		/// the hierarchy of the current design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// IMPORTANT! Because there are so many pins in the design, the get_pins command can cause<br/>
		/// performance issues, and add significant time to processing design constraints. In many cases, a design<br/>
		/// constraint that is written with the get_pins command can be rewritten using the get_cells<br/>
		/// command, as shown in the examples, to significantly improve constraint processing and performance of the<br/>
		/// Vivado tool.<br/>
		/// The get_pins command also includes an option to get all replicated pins that are added to a<br/>
		/// design during physical optimization, or phys_opt_design. The use of the -<br/>
		/// include_replicated_objects option returns the pins on replicated cells when the pins of<br/>
		/// an original cell are returned. You can use this option to ensure that constraints or properties that<br/>
		/// are applied to the pins of a cell are also applied to the pins of its replicated cells.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of pins attached to the specified cells:<br/>
		/// get_pins -of_objects [get_cells usb*]<br/>
		/// Note: If there are no pins matching the pattern, the tool will return a warning.<br/>
		/// This example shows how using get_cells can improve the performance of the get_pins<br/>
		/// command:<br/>
		/// [get_pins -hier * -filter {NAME=~xx*/yy*}]<br/>
		/// can be rewritten as:<br/>
		/// [get_pins -filter {REF_PIN_NAME=~yy*} -of [get_cells -hier xx*]]<br/>
		/// The following shows how rewriting the set_max_delay constraint can significantly improve<br/>
		/// performance:<br/>
		/// set_max_delay 15 -from [get_pins -hier \<br/>
		/// -filter name=~*/aclk_dpram_reg*/*/CLK] \<br/>
		/// -to [get_cells -hier -filter name=~*/bclk_dout_reg*] -datapath_only<br/>
		/// can be rewritten as:<br/>
		/// set_max_delay 15 -from [get_pins -of \<br/>
		/// [get_cells -hier -filter name=~*aclk_dpram_reg*/*] \<br/>
		/// -filter {REF_PIN_NAME == CLK}] \<br/>
		/// -to [get_pins -of [get_cells -hier -filter {name =~ */bclk_dout_reg*}]<br/>
		/// \<br/>
		/// -filter {REF_PIN_NAME == D}] -datapath_only<br/>
		/// TIP: Although the second command syntax is more complex, the performance gains can be significant.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This example runs the report_drc command on the current design, and then returns any pins<br/>
		/// associated with DRC violations:<br/>
		/// report_drc -name drc_1<br/>
		/// get_pins -of_objects [get_drc_violations]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 871<br/>
		/// </para>
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
		/// <para>
		/// (Optional)<br/>
		/// Include replicated objects when searching for patterns. This<br/>
		/// option is valid only when patterns is specified.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match pin names against patterns Default: *</param>
		/// <returns>list of pin objects</returns>
		public TTCL get_pins(String hsc = null, bool? hierarchical = null, bool? regexp = null, bool? nocase = null, bool? leaf = null, String filter = null, TCLParameterList of_objects = null, String match_style = null, bool? include_replicated_objects = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_pins [-hsc <arg>] [-hierarchical] [-regexp] [-nocase] [-leaf] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-include_replicated_objects] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pins(hsc, hierarchical, regexp, nocase, leaf, filter, of_objects, match_style, include_replicated_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of programmable interconnect points (pips) on the current device.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_pips [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-uphill] [-downhill] [-from &lt;args&gt;] [-to &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Programmable interconnect points, or PIPs, provide the physical routing paths on the device used<br/>
		/// to connect logic networks. This command returns a list of PIPs on the device that match a<br/>
		/// specified search pattern. The command requires a design to be open.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The default command gets a list of all PIPs on the device. However, this is not a recommended<br/>
		/// use of the command due to the number of pips on a device. You should specify the -<br/>
		/// of_objects argument to limit the number of pips returned.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the PIPs associated with the specified tile:<br/>
		/// get_pips -of_object [get_tiles DSP_R_X9Y75]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 876<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the pips of these sites, tiles, wires, nodes, pips, or nets.</param>
		/// <param name="uphill">(Optional) Get the pips uphill from the provided wire or pip.</param>
		/// <param name="downhill">(Optional) Get the pips downhill from the provided wire or pip.</param>
		/// <param name="from">
		/// <para>
		/// (Optional)<br/>
		/// -from &lt;pip/site pin&gt; Return the ordered list of pips<br/>
		/// beginning at this pip or site pin. May be used in<br/>
		/// combination with uphill. Default is downhill. -all is implied.<br/>
		/// </para>
		/// </param>
		/// <param name="to">
		/// <para>
		/// (Optional)<br/>
		/// -to &lt;pip/site pin&gt; Return the ordered list of pips ending at<br/>
		/// this wire or site pin. May be used in combination with uphill.<br/>
		/// Default is downhill. -all is implied.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match pips against patterns Default: *</param>
		/// <returns>pips</returns>
		public TTCL get_pips(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? uphill = null, bool? downhill = null, TCLParameterList from = null, TCLParameterList to = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_pips [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-uphill] [-downhill] [-from <args>] [-to <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pips(regexp, nocase, filter, of_objects, uphill, downhill, from, to, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of package pin byte groups.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_pkgpin_bytegroups [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of the byte groups on the I/O banks of the current Xilinx UltraScale device.<br/>
		/// For 7 series devices, the hierarchy of IO Banks is divided into two object types: I/O Banks and<br/>
		/// Package Pins. For Xilinx UltraScale FPGA devices, the IO Bank hierarchy includes two additional<br/>
		/// divisions: Byte groups and Nibbles.<br/>
		/// The relationships of these objects on an UltraScale device are defined as follows:<br/>
		/// • An iobank has 2 or 4 bytegroups.<br/>
		/// • Each pkgpin_bytegroup has 2 nibbles, an upper and lower, and has 13 package pins.<br/>
		/// • Each pkgpin_nibble has 6 or 7 pins, and is the upper or lower nibble of the pkgpin_bytegroup.<br/>
		/// • A package_pin is one pin of an iobank, a pkgpin_bytegroup, or a pkgpin_nibble.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of all pins on the package of the target device:<br/>
		/// get_pkgpin_bytegroups -of [get_iobanks 44]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 880<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the pin_group of these package_pins, iobank, site, or port.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match pin_group against patterns Default: *</param>
		/// <returns>pin_group</returns>
		public TTCL get_pkgpin_bytegroups(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_pkgpin_bytegroups [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pkgpin_bytegroups(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of pkgpin nibbles.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_pkgpin_nibbles [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Return a list of nibbles, or half-bytes, on the I/O banks of the current Xilinx UltraScale device.<br/>
		/// For 7 series devices, the hierarchy of IO Banks is divided into two object types: I/O Banks and<br/>
		/// Package Pins. For Xilinx UltraScale FPGA devices, the IO Bank hierarchy includes two additional<br/>
		/// divisions: Byte groups and Nibbles.<br/>
		/// The relationships of these objects on an UltraScale device are defined as follows:<br/>
		/// • An iobank has 2 or 4 bytegroups.<br/>
		/// • Each pkgpin_bytegroup has 2 nibbles, an upper and lower, and has 13 package pins.<br/>
		/// • Each pkgpin_nibble has 6 or 7 pins, and is the upper or lower nibble of the pkgpin_bytegroup.<br/>
		/// • A package_pin is one pin of an iobank, a pkgpin_bytegroup, or a pkgpin_nibble.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the Upper nibbles associated with the specified IO bank:<br/>
		/// get_pkgpin_nibbles -of [get_iobanks 44] -filter {TYPE == U}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 883<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the pin_nibble of these package_pins, iobank, site, or port.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match pin_nibble against patterns Default: *</param>
		/// <returns>pin_nibble</returns>
		public TTCL get_pkgpin_nibbles(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_pkgpin_nibbles [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pkgpin_nibbles(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of ports in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_ports [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-match_style &lt;arg&gt;] [-scoped_to_current_instance] [-no_traverse] [-prop_thru_buffers] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of port objects in the current design that match a specified search pattern. The default<br/>
		/// command gets a list of all ports in the design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of pins attached to the specified cell:<br/>
		/// get_ports -of_objects [lindex [get_cells] 1]<br/>
		/// Note: If there are no ports matching the pattern, the tool will return a warning.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example runs the report_drc command on the current design, returns the list of<br/>
		/// violations in the specified DRC report, and then returns the ports associated with any violations<br/>
		/// of the unspecified I/O Standard rule (NSTD):<br/>
		/// report_drc -name drc_1<br/>
		/// get_drc_violations -name drc_1<br/>
		/// get_ports -of_objects [get_drc_violations -name drc_1 NSTD*]<br/>
		/// This example specifies a cell for the current instance, returns the pins scoped to the current<br/>
		/// instance, and returns the top-level ports connected to those pins:<br/>
		/// current_instance [get_cells dac_spi*]<br/>
		/// get_ports -scoped_to_current_instance<br/>
		/// get_ports -scoped_to_current_instance -prop_thru_buffers<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 886<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get ports of these nets, instances, sites, clocks, timing paths,<br/>
		/// io standards, io banks, package pins, drc violations<br/>
		/// </para>
		/// </param>
		/// <param name="match_style">(Optional) Style of pattern matching, valid values are ucf, sdc Default: sdc</param>
		/// <param name="scoped_to_current_instance">
		/// <para>
		/// (Optional)<br/>
		/// Match patterns on instance pins specified using current<br/>
		/// instance, and then find top level connected ports.<br/>
		/// </para>
		/// </param>
		/// <param name="no_traverse">(Optional) Do not traverse to find top level terminals.</param>
		/// <param name="prop_thru_buffers">
		/// <para>
		/// (Optional)<br/>
		/// Allow propagate through buffers when traversing to find<br/>
		/// top level terminals connected to pins of scoped instance.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match port names against patterns Default: *</param>
		/// <returns>list of port objects</returns>
		public TTCL get_ports(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, String match_style = null, bool? scoped_to_current_instance = null, bool? no_traverse = null, bool? prop_thru_buffers = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_ports [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-scoped_to_current_instance] [-no_traverse] [-prop_thru_buffers] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_ports(regexp, nocase, filter, of_objects, match_style, scoped_to_current_instance, no_traverse, prop_thru_buffers, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of Power Rails in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_power_rails [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 890<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match Power rail names against patterns Default: *</param>
		/// <returns>list of power rail objects</returns>
		public TTCL get_power_rails(bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_power_rails [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_power_rails(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get properties of object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_property [-min] [-max] [-quiet] [-verbose] &lt;name&gt; &lt;object&gt;
		/// <br/>
		/// <para>
		/// Gets the current value of the named property from the specified object or objects. If multiple<br/>
		/// objects are specified, a list of values is returned.<br/>
		/// If the property is not currently assigned to the object, or is assigned without a value, then the<br/>
		/// get_property command returns nothing, or the null string. If multiple objects are queried, the<br/>
		/// null string is added to the list of values returned.<br/>
		/// If multiple objects are passed to the get_property command, you can use the -min or -max<br/>
		/// options to return the smallest or greatest value of the property specified by name. This feature<br/>
		/// can be useful when setting timing constraints.<br/>
		/// RECOMMENDED: For numeric properties, the min/max determination is based on numeric values. For all<br/>
		/// other properties, the determination is based on string sorting.<br/>
		/// This command returns a value, or list of values, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the NAME property from the specified cell:<br/>
		/// get_property NAME [lindex [get_cells] 3]<br/>
		/// The following example returns the smallest PERIOD property from the specified clock objects:<br/>
		/// get_property -min PERIOD [get_clocks]<br/>
		/// This example demonstrates the string based sorting of the SITE property for the specified ports:<br/>
		/// get_property SITE [get_ports]<br/>
		/// IOB_X1Y75 IOB_X1Y76 IOB_X1Y98 IOB_X1Y125 IOB_X0Y94 IOB_X1Y95 IOB_X1Y96<br/>
		/// IOB_X1Y93 IOB_X1Y94<br/>
		/// get_property -min SITE [get_ports]<br/>
		/// IOB_X0Y94<br/>
		/// get_property -max SITE [get_ports]<br/>
		/// IOB_X1Y98<br/>
		/// Note: While IOB_X1Y125 is the largest site value on the port objects, the property value IOB_X1Y98 is<br/>
		/// returned because of the sorting of the property values as strings.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 901<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of property whose value is to be retrieved</param>
		/// <param name="object">(Required) Object to query for properties</param>
		/// <param name="min">(Optional) Return only the minimum value</param>
		/// <param name="max">(Optional) Return only the maximum value</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>property value</returns>
		public TTCL get_property(TCLObject name, TCLObject @object, bool? min = null, bool? max = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_property [-min] [-max] [-quiet] [-verbose] <name> <object>
			_tcl.Entry(_builder.get_property(name, @object, min, max, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of site_pins.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_site_pins [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns a list of site pins of the specified site, node, logical cell pin, or net objects in an open<br/>
		/// design.<br/>
		/// This command recommends the use of the -of_objects argument to prevent high run times<br/>
		/// and compute resources.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the site_pins of the specified Nets:<br/>
		/// get_site_pins -of_objects [get_nets *Clk]<br/>
		/// IOB_X1Y24/I<br/>
		/// The following example returns the output site_pins associated with the site SLICE_X21Y92:<br/>
		/// get_site_pins -of_objects [get_sites SLICE_X21Y92] -filter<br/>
		/// {DIRECTION==OUT}<br/>
		/// SLICE_X21Y92/A SLICE_X21Y92/AMUX SLICE_X21Y92/AQ<br/>
		/// SLICE_X21Y92/B SLICE_X21Y92/BMUX SLICE_X21Y92/BQ<br/>
		/// SLICE_X21Y92/C SLICE_X21Y92/CMUX SLICE_X21Y92/COUT<br/>
		/// SLICE_X21Y92/CQ SLICE_X21Y92/D SLICE_X21Y92/DMUX<br/>
		/// SLICE_X21Y92/DQ<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 923<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'site_pin' objects of these types: 'site xdef_site node pin<br/>
		/// net bel_pin'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'site_pin' objects against patterns. Default: *</param>
		/// <returns>site_pins</returns>
		public TTCL get_site_pins(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_site_pins [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_site_pins(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of site_pips from the given object.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_site_pips [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Programmable interconnect points, or PIPs, provide the physical routing paths on the device used<br/>
		/// to connect logic networks. This command returns a list of PIPs on specified sites that match a<br/>
		/// specified search pattern. The command requires a design to be open.<br/>
		/// This command requires the use of the -of_objects option to specify the sites to return PIPs<br/>
		/// from.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the pins of the specified BELs associated with the specified range<br/>
		/// of sites on the device:<br/>
		/// get_site_pips -of_objects [get_sites SLICE_X21Y92]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 926<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the site_pips of these sites.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match site_pips against patterns Default: *</param>
		/// <returns>site_pips</returns>
		public TTCL get_site_pips(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_site_pips [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_site_pips(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of Sites<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_sites [-regexp] [-filter &lt;arg&gt;] [-nocase] [-range &lt;args&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of sites on the target device that match a specified search pattern. The default<br/>
		/// command gets a list of all sites on the target device.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of all sites available on the target device:<br/>
		/// get_sites<br/>
		/// The following example returns the number of sites that are not currently used on the device.<br/>
		/// Both command forms in the example return the same results. The second command directly<br/>
		/// evaluates the IS_USED boolean property:<br/>
		/// llength [get_sites -filter {IS_USED==0}]<br/>
		/// -or-<br/>
		/// llength [get_sites -filter !IS_USED]<br/>
		/// Note: If no sites match the pattern you will get a warning.<br/>
		/// The following example gets all of the sites on the device, and returns the unique SITE_TYPEs:<br/>
		/// set sites [get_sites]<br/>
		/// set type {}<br/>
		/// foreach x $sites {<br/>
		/// set prop [get_property SITE_TYPE $x]<br/>
		/// if { [lsearch -exact $type $prop] == -1 } {<br/>
		/// lappend type $prop<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// }<br/>
		/// }<br/>
		/// foreach y $type {<br/>
		/// puts "SITE_TYPE: $y"<br/>
		/// }<br/>
		/// The following example shows three different forms for specifying the range of sites to return:<br/>
		/// get_sites -range {SLICE_X0Y0 SLICE_X1Y1}<br/>
		/// SLICE_X0Y0 SLICE_X0Y1 SLICE_X1Y0 SLICE_X1Y1<br/>
		/// get_sites -range SLICE_X0Y0 -range SLICE_X1Y1<br/>
		/// SLICE_X0Y0 SLICE_X0Y1 SLICE_X1Y0 SLICE_X1Y1<br/>
		/// get_sites -range {SLICE_X0Y0:SLICE_X1Y1}<br/>
		/// SLICE_X0Y0 SLICE_X0Y1 SLICE_X1Y0 SLICE_X1Y1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 929<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="range">
		/// <para>
		/// (Optional)<br/>
		/// Match site names which fall into the range. Range is defined<br/>
		/// by exactly two site names.<br/>
		/// </para>
		/// </param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get the sites of slrs, tiles, bels, pins, package_pins, ports,<br/>
		/// pblocks, nets, site_types, io_banks, cells, clock_regions or<br/>
		/// drc_violation<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Match site names against patterns. Bonded sites will also<br/>
		/// match on package pin names. Default: *<br/>
		/// </para>
		/// </param>
		/// <returns>list of site objects</returns>
		public TTCL get_sites(bool? regexp = null, String filter = null, bool? nocase = null, TCLParameterList range = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_sites [-regexp] [-filter <arg>] [-nocase] [-range <args>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_sites(regexp, filter, nocase, range, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of slrs.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_slrs [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Get a list of the super logic regions (SLRs) on the target device. On Devices that do not contain<br/>
		/// multiple SLRs, the SLR0 is returned.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example highlights each of the SLRs on the target device in a different color:<br/>
		/// foreach x [get_slrs] {<br/>
		/// incr i<br/>
		/// highlight_objects -color_index $i $x<br/>
		/// }<br/>
		/// Note: If there are no cells matching the pattern you will get a warning.<br/>
		/// The following example returns the number of super long lines (SLLs) between super logic regions<br/>
		/// on the current device:<br/>
		/// get_property NUM_SLLS [get_slrs SLR0]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 933<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get the slr of these device, tiles, sites, bels, sitepins, belpins,<br/>
		/// clock region, node, pip, pin, package pin, iobank, cell.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match slr against patterns Default: *</param>
		/// <returns>slr</returns>
		public TTCL get_slrs(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_slrs [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_slrs(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of speed_models in the device.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_speed_models [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-patterns &lt;arg&gt;] [-filter &lt;arg&gt;] [-speed_pattern &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Get speed models for UltraScale architecture device resources in the current design.<br/>
		/// Speed files are provided by Xilinx for each device and speed grade. Speed files contain speed<br/>
		/// models. There are speed models for the various elements of a device: nodes, pips, bels. There are<br/>
		/// speed models for setup and hold, propagation delays, jitter, etc.<br/>
		/// The speed models include information on the delays in nanoseconds (ns) associated with device<br/>
		/// resources like BELs and SITEs and routing resources. Speed models are used by the Vivado<br/>
		/// timing engine to perform analysis of the current design in the context of the target part.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The objects returned are the speed models associated with specific physical resources like pips<br/>
		/// and wires, drawn directly from the speed files. These can include capacitance and resistance<br/>
		/// values and buffer models.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// This command returns the specified speed model objects, or returns an error if the command<br/>
		/// fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the properties on the speed model for an A6LUT:<br/>
		/// report_property -all [lindex [get_speed_models -of \<br/>
		/// [get_bels SLICE_X0Y0/A6LUT]] 0]<br/>
		/// Property Type Read-only Value<br/>
		/// CLASS string true speed_model<br/>
		/// DELAY double true 0.043<br/>
		/// FAST_MAX double true 0.035<br/>
		/// FAST_MIN double true 0.028<br/>
		/// IS_INSTANCE_SPECIFIC bool true 1<br/>
		/// NAME string true bel_d_lut6_a1_o6<br/>
		/// NAME_LOGICAL string true bel_d_lut6_a1_o6<br/>
		/// SLOW_MAX double true 0.043<br/>
		/// SLOW_MIN double true 0.036<br/>
		/// SPEED_INDEX int true 65535<br/>
		/// TYPE string true bel_delay<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example returns the delays, in nanoseconds, for a specific A6LUT on the device,<br/>
		/// followed by the delay name for the specified object:<br/>
		/// set x [get_speed_models -of [get_bels SLICE_X0Y0/A6LUT]]<br/>
		/// puts [format "%6.3f : %s" [get_property DELAY [lindex $x 0 ]] \<br/>
		/// [get_property NAME [lindex $x 0 ]]]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 936<br/>
		/// </para>
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
		public TTCL get_speed_models(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String patterns = null, String filter = null, String speed_pattern = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_speed_models [-of_objects <args>] [-regexp] [-nocase] [-patterns <arg>] [-filter <arg>] [-speed_pattern <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_speed_models(of_objects, regexp, nocase, patterns, filter, speed_pattern, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of tiles.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_tiles [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// This command returns a list of tiles on the device in an open design. The default command gets a<br/>
		/// list of all tiles on the device.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the total number of tiles where the number of timing arcs is<br/>
		/// greater than 100 and 150 respectively:<br/>
		/// llength [get_tiles -filter {NUM_ARCS&gt;100} ]<br/>
		/// 13468<br/>
		/// llength [get_tiles -filter {NUM_ARCS&gt;150} ]<br/>
		/// 11691<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 943<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get the tiles of these slr, sites, bels, site_pins, bel_pins,<br/>
		/// nodes, wires, pips, nets, clock_regions.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match tiles against patterns Default: *</param>
		/// <returns>tiles</returns>
		public TTCL get_tiles(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_tiles [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_tiles(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of timing arcs<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_timing_arcs [-from &lt;args&gt;] [-to &lt;args&gt;] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Gets a list of timing arcs for the specified objects. You can filter the timing arcs according to<br/>
		/// specified properties.<br/>
		/// Timing arcs are a part of a timing path. A timing arc can be a wire between two pins, or can be<br/>
		/// the internal path of a logic instance between an input pin and output pin, or clock input and data<br/>
		/// output pins.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the timing arc from the output pin of the specified buffer:<br/>
		/// report_property -all [get_timing_arcs -of_objects [get_cells go_IBUF_inst]]<br/>
		/// The following example returns the timing arcs of the specified cell:<br/>
		/// get_timing_arcs -of_objects [get_cells count_reg[6]]<br/>
		/// {count_reg[6]/C --&gt; count_reg[6]/Q [Reg Clk to Q] }<br/>
		/// {count_reg[6]/C --&gt; count_reg[6]/D [setup] }<br/>
		/// {count_reg[6]/C --&gt; count_reg[6]/D [hold] }<br/>
		/// {count_reg[6]/C --&gt; count_reg[6]/CLR [recovery] }<br/>
		/// {count_reg[6]/C --&gt; count_reg[6]/CE [hold] }<br/>
		/// {count_reg[6]/C --&gt; count_reg[6]/CLR [removal] }<br/>
		/// {count_reg[6]/C --&gt; count_reg[6]/CE [setup] }<br/>
		/// {count_reg[6]/CLR --&gt; count_reg[6]/Q [Reg Set/Clr] }<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 946<br/>
		/// </para>
		/// </summary>
		/// <param name="from">(Optional) List of pin or ports</param>
		/// <param name="to">(Optional) List of pin or ports</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get timing arcs for these cells</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of timing arc objects</returns>
		public TTCL get_timing_arcs(TCLParameterList from = null, TCLParameterList to = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_timing_arcs [-from <args>] [-to <args>] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_timing_arcs(from, to, filter, of_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of wires.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_wires [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-uphill] [-downhill] [-from &lt;args&gt;] [-to &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns a list of wires in the design that match a specified search pattern in an open design.<br/>
		/// The default command gets a list of all wires in the design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the wires associated with the specified tile:<br/>
		/// get_wires -of_objects [get_tiles IO_INT_INTERFACE_L_X0Y198]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 964<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the wires of these tiles, nodes, pips, or nets.</param>
		/// <param name="uphill">(Optional) Get the wires uphill from the provided pip.</param>
		/// <param name="downhill">(Optional) Get the wires downhill from the provided pip.</param>
		/// <param name="from">
		/// <para>
		/// (Optional)<br/>
		/// -from &lt;pip/site pin&gt; Return the ordered list of wires<br/>
		/// beginning at this pip or site pin. May be used in<br/>
		/// combination with uphill. Default is downhill. -all is implied.<br/>
		/// </para>
		/// </param>
		/// <param name="to">
		/// <para>
		/// (Optional)<br/>
		/// -to &lt;pip/site pin&gt; Return the ordered list of wires ending at<br/>
		/// this wire or site pin. May be used in combination with uphill.<br/>
		/// Default is downhill. -all is implied.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match wires against patterns Default: *</param>
		/// <returns>wires</returns>
		public TTCL get_wires(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? uphill = null, bool? downhill = null, TCLParameterList from = null, TCLParameterList to = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_wires [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-uphill] [-downhill] [-from <args>] [-to <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_wires(regexp, nocase, filter, of_objects, uphill, downhill, from, to, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Groups paths for cost function calculations<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: group_path [-name &lt;args&gt;] [-weight &lt;arg&gt;] [-default] [-from &lt;args&gt;] [-to &lt;args&gt;] [-through &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This command lets you group a set of paths for cost function calculations, primarily for timing<br/>
		/// analysis. The Vivado tool automatically defines path groups of clock signals for special handling.<br/>
		/// User-defined path groups can be specified generally as from a startpoint, or to an endpoint, or as<br/>
		/// specific paths from-through-to specific points. Once a path group has been created, some timing<br/>
		/// analysis can be performed against it with the report_timing command.<br/>
		/// You can specify a weight for an existing path group of clocks, and let the placement, routing, and<br/>
		/// optimization engines prioritize those paths first.<br/>
		/// To remove a path from a path group, you must specify the -default option to remove the path<br/>
		/// from a named path group and restore the path to the standard "default" path group.<br/>
		/// This option has the following limitations:<br/>
		/// • For paths originally assigned by the tool to a clock path group, the -default option will<br/>
		/// revert those paths to the clock path group instead of reverting them to the "default" path<br/>
		/// group.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • group_path -default and reset_path are completely independent commands. The<br/>
		/// reset_path command doesn't affect path groups, and the group_path command doesn't<br/>
		/// affect other timing exceptions .<br/>
		/// The path groups currently defined in a design can be found by using the get_path_groups<br/>
		/// command.<br/>
		/// Note: This command operates silently and does not return direct feedback of its operation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a group named signal_grp to the specified registers' endpoints<br/>
		/// matching *signal*reg/D, and then reports timing on the specified group:<br/>
		/// group_path -to [get_pins *signal*reg/D -hierarchical] -name signal_grp<br/>
		/// report_timing -group signal_grp<br/>
		/// The path group signal_grp is also returned by the get_path_groups command:<br/>
		/// get_path_groups signal_grp<br/>
		/// The following example removes the path from the signal_grp, restoring it to the default path<br/>
		/// group:<br/>
		/// group_path -to [get_pins *signal*reg/D -hierarchical] -default<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 969<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Optional) The name of group, can be multiple names</param>
		/// <param name="weight">(Optional) Cost function Weight, Valid values are 1, 2 Default: 1.0</param>
		/// <param name="default">(Optional) Restore path to its default group</param>
		/// <param name="from">(Optional) Filter by paths starting at these path startpoints</param>
		/// <param name="to">(Optional) Filter by paths terminating at these path endpoints</param>
		/// <param name="through">(Optional) Consider paths through pins, cells or nets</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL group_path(TCLParameterList name = null, String weight = null, bool? @default = null, TCLParameterList from = null, TCLParameterList to = null, TCLParameterList through = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: group_path [-name <args>] [-weight <arg>] [-default] [-from <args>] [-to <args>] [-through <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.group_path(name, weight, @default, from, to, through, quiet, verbose));
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
		/// Remove cells from a Pblock<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_cells_from_pblock [-quiet] [-verbose] &lt;pblock&gt; &lt;cells&gt;...
		/// <br/>
		/// <para>
		/// Removes the specified logic instances from a Pblock. Cells are added to a Pblock with the<br/>
		/// add_cells_to_pblock command.<br/>
		/// Note: Cells that have been placed will not be unplaced as they are removed from a Pblock. Any current<br/>
		/// LOC assignments are left intact.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example removes the specified cells from the pb_cpuEngine Pblock:<br/>
		/// remove_cells_from_pblock pb_cpuEngine [get_cells cpuEngine/cpu_dwb_dat_o/*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1237<br/>
		/// </para>
		/// </summary>
		/// <param name="pblock">(Required) Pblock to remove cells from</param>
		/// <param name="cells">(Required) Cells to remove</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_cells_from_pblock(TCLObject pblock, TCLObjectList cells, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_cells_from_pblock [-quiet] [-verbose] <pblock> <cells>...
			_tcl.Entry(_builder.remove_cells_from_pblock(pblock, cells, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove power sources from Power Rail<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_from_power_rail [-power_sources &lt;args&gt;] [-quiet] [-verbose] &lt;power_rail&gt;
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1251<br/>
		/// </para>
		/// </summary>
		/// <param name="power_rail">(Required) Power rail to remove power sources from</param>
		/// <param name="power_sources">
		/// <para>
		/// (Optional)<br/>
		/// List of power sources to remove. Can be power rails and/or<br/>
		/// power supplies<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_from_power_rail(TCLObject power_rail, TCLParameterList power_sources = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_from_power_rail [-power_sources <args>] [-quiet] [-verbose] <power_rail>
			_tcl.Entry(_builder.remove_from_power_rail(power_rail, power_sources, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Reset operating conditions to tool default for power estimation<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_operating_conditions [-voltage &lt;args&gt;] [-grade] [-process] [-junction_temp] [-ambient_temp] [-thetaja] [-thetasa] [-airflow] [-heatsink] [-thetajb] [-board] [-board_temp] [-board_layers] [-design_power_budget] [-supply_current_budget &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Resets the specified operating conditions to their default values. If no operating conditions are<br/>
		/// specified, all operating conditions are reset to their default values.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Operating conditions can be set using the set_operating_conditions command. The<br/>
		/// current values can be determined using the report_operating_conditions command. The<br/>
		/// environmental operating conditions of the device are used for power analysis when running the<br/>
		/// report_power command, but are not used during timing analysis.<br/>
		/// Note: This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example resets all the operating conditions for the design to their default setting:<br/>
		/// reset_operating_conditions<br/>
		/// The following example resets the junction, ambient, and board temperature for the design to<br/>
		/// their default settings:<br/>
		/// reset_operating_conditions -junction_temp -ambient_temp -board_temp<br/>
		/// The following example resets the voltage supply Vccint to its default value:<br/>
		/// reset_operating_conditions -voltage Vccint<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1504<br/>
		/// </para>
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
		/// <para>
		/// (Optional)<br/>
		/// Resets list of supply current budget 'name value' pairs.<br/>
		/// Supported voltage supplies vary by family.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_operating_conditions(TCLParameterList voltage = null, bool? grade = null, bool? process = null, bool? junction_temp = null, bool? ambient_temp = null, bool? thetaja = null, bool? thetasa = null, bool? airflow = null, bool? heatsink = null, bool? thetajb = null, bool? board = null, bool? board_temp = null, bool? board_layers = null, bool? design_power_budget = null, TCLParameterList supply_current_budget = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_operating_conditions [-voltage <args>] [-grade] [-process] [-junction_temp] [-ambient_temp] [-thetaja] [-thetasa] [-airflow] [-heatsink] [-thetajb] [-board] [-board_temp] [-board_layers] [-design_power_budget] [-supply_current_budget <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.reset_operating_conditions(voltage, grade, process, junction_temp, ambient_temp, thetaja, thetasa, airflow, heatsink, thetajb, board, board_temp, board_layers, design_power_budget, supply_current_budget, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Reset switching activity on specified objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_switching_activity [-default] [-type &lt;args&gt;] [-hier] [-all] [-no_deassert_resets] [-quiet] [-verbose] [&lt;objects&gt;...]
		/// <br/>
		/// <para>
		/// Resets the attributes of the switching activity on specified nets, ports, pins, and cells in the<br/>
		/// design.<br/>
		/// The switching activity is defined using the set_switching_activity command. The current<br/>
		/// switching activity defined for a specific port, pin, net, or cell can be found by using the<br/>
		/// report_switching_activity command.<br/>
		/// Note: The reset_switching_activity is used to reset switching activity for specified objects. Use<br/>
		/// set_switching_activity -default_toggle_rate or -default_static_probability to<br/>
		/// change or reset the default values for the current design.<br/>
		/// This command operates silently and does not return direct feedback of its operation.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example resets the signal_rate and static probability value on all output ports:<br/>
		/// reset_switching_activity -default [all_outputs]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1518<br/>
		/// </para>
		/// </summary>
		/// <param name="default">(Optional) Reset default static probability and default toggle rate</param>
		/// <param name="type">
		/// <para>
		/// (Optional)<br/>
		/// Specify nodes in a specific category. List of valid type values:<br/>
		/// io_output, io_bidir_enable, register, lut_ram, lut, dsp,<br/>
		/// bram_enable, bram_wr_enable, gt_txdata, gt_rxdata.<br/>
		/// </para>
		/// </param>
		/// <param name="hier">
		/// <para>
		/// (Optional)<br/>
		/// Hierarchically resets the switching activity on a hierarchical<br/>
		/// cells provided as &lt;objects&gt;.<br/>
		/// </para>
		/// </param>
		/// <param name="all">(Optional) Reset switching activity on all nets</param>
		/// <param name="no_deassert_resets">
		/// <para>
		/// (Optional)<br/>
		/// A switch to undo the deassertion of resets via command<br/>
		/// set_switching_activity -deassert_resets<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">(Optional) Objects to reset switching activity on</param>
		public TTCL reset_switching_activity(bool? @default = null, TCLParameterList type = null, bool? hier = null, bool? all = null, bool? no_deassert_resets = null, bool? quiet = null, bool? verbose = null, TCLObjectList objects = null)
		{
			// TCL Syntax: reset_switching_activity [-default] [-type <args>] [-hier] [-all] [-no_deassert_resets] [-quiet] [-verbose] [<objects>...]
			_tcl.Entry(_builder.reset_switching_activity(@default, type, hier, all, no_deassert_resets, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Move, resize, add and remove Pblock site-range constraints<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: resize_pblock [-add &lt;args&gt;] [-remove &lt;args&gt;] [-from &lt;args&gt;] [-to &lt;args&gt;] [-replace] [-locs &lt;arg&gt;] [-quiet] [-verbose] &lt;pblock&gt;
		/// <br/>
		/// <para>
		/// Place, resize, move, or remove the specified Pblock. The Pblock must have been created using<br/>
		/// the create_pblock command.<br/>
		/// A Pblock consists of a group of cells that can be assigned to one or more independent or<br/>
		/// overlapping rectangles. Using the various options defined below, you can add sites to a rectangle,<br/>
		/// or remove sites from a rectangle, or define a new rectangle to be associated with an existing<br/>
		/// Pblock.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example resizes the Pblock by adding a range of SLICEs, and removing other<br/>
		/// SLICEs, but keeps all instances placed at their current location:<br/>
		/// resize_pblock block3 -add SLICE_X6Y67:SLICE_X11Y71 \<br/>
		/// -remove SLICE_X6Y71:SLICE_X7Y71 -locs keep_all<br/>
		/// This example create a Pblock region, and defines the Pblock area by adding a range of<br/>
		/// CLOCKREGIONs:<br/>
		/// create_pblock pblock_1<br/>
		/// resize_pblock pblock_1 -add {CLOCKREGION_X0Y10:CLOCKREGION_X1Y11}<br/>
		/// The following example moves the specified Pblock by adding a range of SLICEs, removing the<br/>
		/// existing range of SLICEs, and trims any placed logic that falls outside the new Pblock. Then it<br/>
		/// adds a new range of SLICEs and block ram to the specified Pblock in a second separate rectangle:<br/>
		/// resize_pblock block3 -add SLICE_X3Y8:SLICE_X10Y3 \<br/>
		/// -remove SLICE_X6Y67:SLICE_X11Y71 -locs trim<br/>
		/// resize_pblock block3 -add {SLICE_X6Y67:SLICE_X11Y71 \<br/>
		/// RAMB18_X0Y2:RAMB18_X1Y4}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1527<br/>
		/// </para>
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
		public TTCL resize_pblock(TCLObject pblock, TCLParameterList add = null, TCLParameterList remove = null, TCLParameterList from = null, TCLParameterList to = null, bool? replace = null, String locs = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: resize_pblock [-add <args>] [-remove <args>] [-from <args>] [-to <args>] [-replace] [-locs <arg>] [-quiet] [-verbose] <pblock>
			_tcl.Entry(_builder.resize_pblock(pblock, add, remove, from, to, replace, locs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Define bus skew<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_bus_skew [-from &lt;args&gt;] [-rise_from &lt;args&gt;] [-fall_from &lt;args&gt;] [-to &lt;args&gt;] [-rise_to &lt;args&gt;] [-fall_to &lt;args&gt;] [-through &lt;args&gt;] [-rise_through &lt;args&gt;] [-fall_through &lt;args&gt;] [-quiet] [-verbose] &lt;value&gt;
		/// <br/>
		/// <para>
		/// Set the bus skew requirement on bus signals that cross clock domains. The bus skew constraint<br/>
		/// defines the maximum skew spread between the fastest and slowest signals of the bus, and does<br/>
		/// not consider the overall datapath delay. The Vivado router will try to satisfy the set_bus_skew<br/>
		/// constraints. Example uses of the bus skew constraint include clock domain crossing for gray-coded pointers, MUX-controlled and MUX-data holding CDC buses.<br/>
		/// TIP: Bus skew constraints are not overridden by clock groups, max delay, or false path, because<br/>
		/// set_bus_skew is a constraint between the signals of a bus, rather than on a particular path.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The set_bus_skew constraint can be combined with the set_max_delay constraint for good<br/>
		/// results. The set_bus_skew constraint does not care about the absolute datapath delay, but<br/>
		/// only about the relative arrival times of data at the destination, taking into account source and<br/>
		/// destination clock skew. You can help set_bus_skew by also using set_max_delay -<br/>
		/// datapath_only &lt;SRC_CLK&gt;. This constraint helps the Vivado placer to ensure that the<br/>
		/// source and destination registers are not placed too far apart, so that the router can more easily<br/>
		/// satisfy the set_bus_skew constraint. Refer to the Vivado Design Suite User Guide: Using<br/>
		/// Constraints (UG903) for more information.<br/>
		/// In order to not over constrain the skew requirement, the bus skew value should be approximately<br/>
		/// the smallest period of the two clock domains. This will prevent multiple data captures by the<br/>
		/// destination clock domain.<br/>
		/// The set_bus_skew command requires a timing path defined by both -from and -to, or some<br/>
		/// form such as -fall_from or -rise_to. You can optionally specify -through values to<br/>
		/// further refine the path. You should specify explicit signal paths with -from/-to instead of<br/>
		/// specifying entire clock domains:<br/>
		/// • set_bus_skew -from [get_pins &lt;hierarchy/C&gt;] -to [get_pins<br/>
		/// &lt;hierarchy/D&gt;] &lt;value&gt;<br/>
		/// • set_bus_skew -from [get_clocks &lt;clock name&gt;] -to get_clocks &lt;clock<br/>
		/// name&gt;] &lt;value&gt;<br/>
		/// TIP: Do not set bus skew constraints between timed synchronous clock domains.<br/>
		/// You can use the report_bus_skew command to report the calculated skew on paths in the<br/>
		/// current design.<br/>
		/// The set_bus_skew command returns nothing if successful, or an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example defines the bus skew between the gray-coded Read and Write pointers:<br/>
		/// set_bus_skew -from [get_pins gray_coded_read_ptr[*]/C] \<br/>
		/// -to [get_pins gray_coded_write_ptr[*]/D] 2.5<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1592<br/>
		/// </para>
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
		public TTCL set_bus_skew(TCLObject value, TCLParameterList from = null, TCLParameterList rise_from = null, TCLParameterList fall_from = null, TCLParameterList to = null, TCLParameterList rise_to = null, TCLParameterList fall_to = null, TCLParameterList through = null, TCLParameterList rise_through = null, TCLParameterList fall_through = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_bus_skew [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-through <args>] [-rise_through <args>] [-fall_through <args>] [-quiet] [-verbose] <value>
			_tcl.Entry(_builder.set_bus_skew(value, from, rise_from, fall_from, to, rise_to, fall_to, through, rise_through, fall_through, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Specify that an input is 1, 0, rising or falling<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_case_analysis [-quiet] [-verbose] &lt;value&gt; &lt;objects&gt;
		/// <br/>
		/// <para>
		/// Specifies that a pin or port is in a steady state of 1, 0, rising or falling.<br/>
		/// This command is usually used to force values onto the ports to help reduce the analysis space,<br/>
		/// runtime and memory consumption. It is important to let the Vivado timing engine know about<br/>
		/// signals that have a constant value. This is also critical to ensure that non-functional and irrelevant<br/>
		/// paths are not reported.<br/>
		/// Setting a case value on a pin results in disabling timing analysis through that pin. This means that<br/>
		/// timing paths through that pin are not reported.<br/>
		/// Note: This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// In the example below, two clocks are created on the input pins of the BUFGMUX, clock_sel, but<br/>
		/// only clk_B is propagated through the output pin after setting the constant value 1 on the<br/>
		/// selection pin S:<br/>
		/// create_clock -name clk_A -period 10.0 [get_pins clock_sel/I0]<br/>
		/// create_clock -name clk_B -period 15.0 [get_pins clock_sel/I1]<br/>
		/// set_case_analysis 1 [get_pins clock_sel/S]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1596<br/>
		/// </para>
		/// </summary>
		/// <param name="value">
		/// <para>
		/// (Required)<br/>
		/// Logic value on the pin: Values: 0, 1, rising, falling, zero, one,<br/>
		/// rise, fall<br/>
		/// </para>
		/// </param>
		/// <param name="objects">(Required) List of ports or pins</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_case_analysis(set_case_analysis_value value, TCLObject objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_case_analysis [-quiet] [-verbose] <value> <objects>
			_tcl.Entry(_builder.set_case_analysis(value, objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set exclusive or asynchronous clock groups<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_clock_groups [-name &lt;arg&gt;] [-logically_exclusive] [-physically_exclusive] [-asynchronous] [-group &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// TIP: The XDC &gt; Timing Constraints language templates and the Timing Constraints Wizard in the Vivado<br/>
		/// IDE offer timing diagrams and additional details around defining specific timing constraints. You can refer<br/>
		/// to these sources for additional information.<br/>
		/// Define clocks, or groups of clocks, that are exclusive with or asynchronous to other clocks in the<br/>
		/// design. Exclusive clocks are not active at the same time, and paths between them can be ignored<br/>
		/// during timing analysis. Asynchronous clocks are clocks with no known phase relationship, which<br/>
		/// typically happens when they do not share the same primary clock or do not have a common<br/>
		/// period.<br/>
		/// Using this command is similar to defining false path constraints for data paths moving between<br/>
		/// exclusive or asynchronous clock domains. See the Vivado Design Suite User Guide: Using<br/>
		/// Constraints (UG903) for more information.<br/>
		/// If only one group is specified, the clocks in that group are asynchronous or exclusive to all other<br/>
		/// clocks in the design, but not to each other. If a new clock is created after the<br/>
		/// set_clock_groups command, it is asynchronous to that group as well.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command can also be used for multiple clocks that are derived from a single BUFGMUX as<br/>
		/// both of the clocks will not be active at the same time.<br/>
		/// Note: This command operates silently and does not return direct feedback of its operation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// Group all the elements driven by src_clk and sync_clk into separate clock groups. The clock<br/>
		/// groups are asynchronous to each other:<br/>
		/// set_clock_groups -group src_clk -group sync_clk -asynchronous<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example includes the generated clocks of the specified clocks, and adds those to<br/>
		/// the clock group:<br/>
		/// set_clock_groups -group [get_clocks -include_generated_clocks src_clk] \<br/>
		/// -group [get_clocks -include_generated_clocks sync_clk] -asynchronous<br/>
		/// Note: In the preceding example, src_clk and sync_clk, and all their generated clocks, are asynchronous.<br/>
		/// Otherwise the generated clocks would be timed against each other and the other master clock.<br/>
		/// In this example, the specified clocks are grouped together, and are asynchronous to all other<br/>
		/// clocks in the design:<br/>
		/// set_clock_groups -async -group [get_clocks {J_CLK U_CLK}]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1598<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Optional) Name for clock grouping</param>
		/// <param name="logically_exclusive">(Optional) Specify logically exclusive clock groups</param>
		/// <param name="physically_exclusive">(Optional) Specify physically exclusive clock groups</param>
		/// <param name="asynchronous">(Optional) Specify asynchronous clock groups</param>
		/// <param name="group">(Optional) Clocks List</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_clock_groups(String name = null, bool? logically_exclusive = null, bool? physically_exclusive = null, bool? asynchronous = null, TCLParameterList group = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_clock_groups [-name <arg>] [-logically_exclusive] [-physically_exclusive] [-asynchronous] [-group <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.set_clock_groups(name, logically_exclusive, physically_exclusive, asynchronous, group, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Capture actual or predicted clock latency<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_clock_latency [-clock &lt;args&gt;] [-rise] [-fall] [-min] [-max] [-source] [-late] [-early] [-quiet] [-verbose] &lt;latency&gt; &lt;objects&gt;
		/// <br/>
		/// <para>
		/// This command defines a clock's source or network latency for specified clocks, ports, or pins.<br/>
		/// Note: This command operates silently and does not return direct feedback of its operation.<br/>
		/// Source latency is the time in nanoseconds that a clock signal takes to propagate from its<br/>
		/// waveform origin to the clock definition point in the design. For example, this would be the time<br/>
		/// delay for the clock to propagate from its source (oscillator) on the system board to the FPGA<br/>
		/// input port.<br/>
		/// Network latency is the time a clock signal takes to propagate from its definition point in the<br/>
		/// design to a register clock pin on the timing path. The total clock latency at a register clock pin is<br/>
		/// the sum of a clock's source latency and network latency.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example will set an early latency on the rising edge of CLK_A.<br/>
		/// set_clock_latency -source -rise -early 0.4 [get_ports CLK_A]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1601<br/>
		/// </para>
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
		public TTCL set_clock_latency(TCLObject latency, TCLObject objects, TCLParameterList clock = null, bool? rise = null, bool? fall = null, bool? min = null, bool? max = null, bool? source = null, bool? late = null, bool? early = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_clock_latency [-clock <args>] [-rise] [-fall] [-min] [-max] [-source] [-late] [-early] [-quiet] [-verbose] <latency> <objects>
			_tcl.Entry(_builder.set_clock_latency(latency, objects, clock, rise, fall, min, max, source, late, early, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set clock sense on ports or pins<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_clock_sense [-positive] [-negative] [-stop_propagation] [-clocks &lt;args&gt;] [-quiet] [-verbose] &lt;pins&gt;
		/// <br/>
		/// <para>
		/// Sets clock sense at specified ports or pins. This is used to define the positive or negative<br/>
		/// unateness at the pin relative to a clock object. However, the specified unateness only applies at a<br/>
		/// non-unate point in the clock network, at a point where the clock signal cannot be determined.<br/>
		/// Since the clock signal is not determined, the defined clock sense propagates forward from the<br/>
		/// given pins.<br/>
		/// Note: This command operates silently and does not return direct feedback of its operation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example specifies that only the positive unate paths will propagate through the<br/>
		/// output pin of the XOR gate as compared with the original clock.<br/>
		/// set_clock_sense -positive [get_pins xor_a.z]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1604<br/>
		/// </para>
		/// </summary>
		/// <param name="pins">(Required) List of port and/or pins</param>
		/// <param name="positive">(Optional) Specify positive unate (non_inverting) clock sense</param>
		/// <param name="negative">(Optional) Specify negative unate (inverting) clock sense</param>
		/// <param name="stop_propagation">(Optional) Stop clock propagation from specified pins</param>
		/// <param name="clocks">(Optional) List of clocks</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_clock_sense(TCLObject pins, bool? positive = null, bool? negative = null, bool? stop_propagation = null, TCLParameterList clocks = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_clock_sense [-positive] [-negative] [-stop_propagation] [-clocks <args>] [-quiet] [-verbose] <pins>
			_tcl.Entry(_builder.set_clock_sense(pins, positive, negative, stop_propagation, clocks, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// set clock uncertainty<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_clock_uncertainty [-setup] [-hold] [-from &lt;args&gt;] [-rise_from &lt;args&gt;] [-fall_from &lt;args&gt;] [-to &lt;args&gt;] [-rise_to &lt;args&gt;] [-fall_to &lt;args&gt;] [-quiet] [-verbose] &lt;uncertainty&gt; [&lt;objects&gt;]
		/// <br/>
		/// <para>
		/// This command is used to add to the uncertainty of a clock in the design, and does not override<br/>
		/// the default jitter calculation. This is referred to as the user clock uncertainty. The<br/>
		/// set_clock_uncertainty command provides a convenient means to over-constrain some<br/>
		/// clocks in the design without changing the clock definitions and relationships. It can constrain<br/>
		/// setup and hold paths separately using the -setup and -hold options.<br/>
		/// Clock uncertainty is the maximum variation, specified in nanoseconds (ns), between two clock<br/>
		/// edges at registers within a single clock domain, or crossing between clock domains.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The clock uncertainty is used during setup and hold analysis, where uncertainty is calculated for<br/>
		/// each timing path based on the clock edges used by the analysis and the clock tree topology. For<br/>
		/// example, for a path where the startpoint and endpoint are connected to the same clock net, the<br/>
		/// clock uncertainty is null because the same clock edge is used for both source and destination,<br/>
		/// unless the set_clock_uncertainty command is used to add uncertainty for the min delay<br/>
		/// analysis. The Vivado timing engine uses clock uncertainty in the slack calculation as determined<br/>
		/// by the following equation:<br/>
		/// • Setup Slack = Setup Path Requirement - Data Delay - Clock Uncertainty + Clock Skew<br/>
		/// Clock Uncertainty is a function of different elements of jitter, as determined by the following<br/>
		/// equation which is returned by the report_timing_summary or report_timing commands:<br/>
		/// • Clock Uncertainty = (√(Tsj2<br/>
		/// + Dj<br/>
		/// 2<br/>
		/// ))/2 + PE + UU<br/>
		/// Where:<br/>
		/// • Tsj = Total System Jitter as calculated using the system jitter. See set_system_jitter.<br/>
		/// • Dj<br/>
		/// = Discrete jitter is the amount of jitter introduced by hardware primitives such as MMCM<br/>
		/// or PLL. Discrete jitter is a feature of clocks generated by the MMCM, which includes the input<br/>
		/// jitter defined on the primary clock. See set_input_jitter.<br/>
		/// • PE = Phase Error, which comes from the MMCM/PLL device model.<br/>
		/// • UU = User Uncertainty, which defines the user clock uncertainty specified by this<br/>
		/// set_clock_uncertainty command.<br/>
		/// TIP: SYSTEM_JITTER is reported as a property of clocks, although it applies to all clocks in the design.<br/>
		/// INPUT_JITTER is also a property of primary clocks. These properties can be returned by the<br/>
		/// get_property or report_property commands. Jitter and clock uncertainty are reported by the<br/>
		/// report_timing_summary and report_timing commands.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example defines the uncertainty between all clock domains:<br/>
		/// set_clock_uncertainty 0.225 -from [get_clocks] -to [get_clocks]<br/>
		/// The following command defines setup and hold uncertainty within the wbClk clock domain:<br/>
		/// set_clock_uncertainty -setup 0.213 [get_clocks wbClk]<br/>
		/// set_clock_uncertainty -hold 0.167 [get_clocks wbClk]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1606<br/>
		/// </para>
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
		public TTCL set_clock_uncertainty(TCLObject uncertainty, bool? setup = null, bool? hold = null, TCLParameterList from = null, TCLParameterList rise_from = null, TCLParameterList fall_from = null, TCLParameterList to = null, TCLParameterList rise_to = null, TCLParameterList fall_to = null, bool? quiet = null, bool? verbose = null, TCLObject objects = null)
		{
			// TCL Syntax: set_clock_uncertainty [-setup] [-hold] [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-quiet] [-verbose] <uncertainty> [<objects>]
			_tcl.Entry(_builder.set_clock_uncertainty(uncertainty, setup, hold, from, rise_from, fall_from, to, rise_to, fall_to, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create data to data checks<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_data_check [-from &lt;args&gt;] [-to &lt;args&gt;] [-rise_from &lt;args&gt;] [-fall_from &lt;args&gt;] [-rise_to &lt;args&gt;] [-fall_to &lt;args&gt;] [-setup] [-hold] [-clock &lt;args&gt;] [-quiet] [-verbose] &lt;value&gt;
		/// <br/>
		/// <para>
		/// Performs a setup and hold check for a data pin with respect to another data pin. This is different<br/>
		/// from a conventional setup and hold check that is done with respect to a clock pin.<br/>
		/// This command defines min and max requirements between two endpoints, similar to setup (max)<br/>
		/// and hold (min) timing checks. Setup and hold checks are referenced from the related pin,<br/>
		/// specified by -from, to the constrained pin, specified by -to. The related pin is similar to the<br/>
		/// clock pin in a conventional setup and hold check. The timing analysis compares arrival times<br/>
		/// between the two specified endpoints. The difference must be less than the set_data_check<br/>
		/// &lt;value&gt; requirement in order to meet timing.<br/>
		/// Limitations of the set_data_check command include:<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • Variations in the destination clock delay are ignored.<br/>
		/// • This command is used for timing purposes only, and is not considered by the Vivado placer or<br/>
		/// router.<br/>
		/// Note: This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example defines a data check for a setup violation from pin A_IN to pin C_IN:<br/>
		/// set_data_check -from A_IN -to C_IN -setup 2.0<br/>
		/// In the above example, A_IN is the related pin and C_IN is the constrained pin. The above<br/>
		/// constraint would do a setup check of C_IN with respect to A_IN. The data at C_IN should arrive<br/>
		/// 2.0 ns prior to the edge of A_IN.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1609<br/>
		/// </para>
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
		public TTCL set_data_check(TCLObject value, TCLParameterList from = null, TCLParameterList to = null, TCLParameterList rise_from = null, TCLParameterList fall_from = null, TCLParameterList rise_to = null, TCLParameterList fall_to = null, bool? setup = null, bool? hold = null, TCLParameterList clock = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_data_check [-from <args>] [-to <args>] [-rise_from <args>] [-fall_from <args>] [-rise_to <args>] [-fall_to <args>] [-setup] [-hold] [-clock <args>] [-quiet] [-verbose] <value>
			_tcl.Entry(_builder.set_data_check(value, from, to, rise_from, fall_from, rise_to, fall_to, setup, hold, clock, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Disable timing arcs<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_disable_timing [-from &lt;arg&gt;] [-to &lt;arg&gt;] [-quiet] [-verbose] &lt;objects&gt;
		/// <br/>
		/// <para>
		/// Disables timing arcs within a specified cell or cells that lead to the output pins of the cell. Only<br/>
		/// the I/O paths between the clock port and the outputs of the cell are disabled.<br/>
		/// The purpose of disabling a timing arc is to prevent timing analysis through the arc.<br/>
		/// If a &lt;cell&gt; is specified, then all timing arcs in that cell are disabled. If the optional -from and -to<br/>
		/// arguments are specified, then the timing arcs are defined by the from/to pins. If only -from is<br/>
		/// speified then all timing arcs from that pin are disabled. If only -to is specified then all timing<br/>
		/// paths to that pin are disabled.<br/>
		/// If a &lt;port&gt; is specified, then all timing paths from a specified input port are disabled, or timing<br/>
		/// paths to a specified output port are disabled.<br/>
		/// Note: This command operates silently and does not return direct feedback of its operation<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example disable the timing arc between the pins I0 and O of the LUT<br/>
		/// div_dec_ff_i/U0/count_i_1 to break a combinational loop:<br/>
		/// set_disable_timing -from I0 -to O [get_cells div_dec_ff_i/U0/count_i_1]<br/>
		/// The following example disables the timing arcs between the specified input pin to the specified<br/>
		/// output pin of a BRAM cell:<br/>
		/// set_disable_timing -from WEBWE[3] -to CLKMEM [get_cells \<br/>
		/// ldpc_dout360_channel/U_AP_FIFO_ldpc_dout360_channel_ram/mem_reg_0]<br/>
		/// The following example disables all timing arcs of the specified cell:<br/>
		/// set arcs [get_timing_arcs -of_objects [get_cells \<br/>
		/// ldpc_dout360_channel/U_AP_FIFO_ldpc_dout360_channel_ram/mem_reg_0]]<br/>
		/// set_disable_timing $arcs<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1614<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">
		/// <para>
		/// (Required)<br/>
		/// List of cells or pins, ports, lib-cells, lib-pins, libcell/cell<br/>
		/// timing-arcs<br/>
		/// </para>
		/// </param>
		/// <param name="from">(Optional) From pin on cell</param>
		/// <param name="to">(Optional) To pin on cell</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_disable_timing(TCLObject objects, String from = null, String to = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_disable_timing [-from <arg>] [-to <arg>] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.set_disable_timing(objects, from, to, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set external delay<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_external_delay -from &lt;args&gt; -to &lt;args&gt; [-min] [-max] [-add] [-quiet] [-verbose] &lt;delay_value&gt;
		/// <br/>
		/// <para>
		/// TIP: The XDC &gt; Timing Constraints language templates and the Timing Constraints Wizard in the Vivado<br/>
		/// IDE offer timing diagrams and additional details around defining specific timing constraints. You can refer<br/>
		/// to these sources for additional information.<br/>
		/// Sets the external (feedback) delay in nanoseconds (ns) between an output and input port. The<br/>
		/// external delay is used in the calculation of the PLL/MMCM compensation delay for PLLs/<br/>
		/// MMCMs with external feedback.<br/>
		/// A min or max value can be specified. By default the value specified applies to both min (hold) and<br/>
		/// max (setup) compensation delays.<br/>
		/// The command returns the defined delay.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets the external feedback delay to 1.0 ns between the port ClkOut and<br/>
		/// ClkFb:<br/>
		/// set_external_delay -from [get_ports ClkOut] -to [get_ports ClkFb] 1.0<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1616<br/>
		/// </para>
		/// </summary>
		/// <param name="from">(Required) Output port</param>
		/// <param name="to">(Required) Input port</param>
		/// <param name="delay_value">(Required) External (feedback) delay value</param>
		/// <param name="min">(Optional) Specifies minimum delay</param>
		/// <param name="max">(Optional) Specifies maximum delay</param>
		/// <param name="add">(Optional) Add to existing external delay</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_external_delay(TCLParameterList from, TCLParameterList to, TCLObject delay_value, bool? min = null, bool? max = null, bool? add = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_external_delay -from <args> -to <args> [-min] [-max] [-add] [-quiet] [-verbose] <delay_value>
			_tcl.Entry(_builder.set_external_delay(from, to, delay_value, min, max, add, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Define false path<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_false_path [-setup] [-hold] [-rise] [-fall] [-reset_path] [-from &lt;args&gt;] [-rise_from &lt;args&gt;] [-fall_from &lt;args&gt;] [-to &lt;args&gt;] [-rise_to &lt;args&gt;] [-fall_to &lt;args&gt;] [-through &lt;args&gt;] [-rise_through &lt;args&gt;] [-fall_through &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// TIP: The XDC &gt; Timing Constraints language templates and the Timing Constraints Wizard in the Vivado<br/>
		/// IDE offer timing diagrams and additional details around defining specific timing constraints. You can refer<br/>
		/// to these sources for additional information.<br/>
		/// Sets false timing paths in the design that are ignored during timing analysis.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: This command operates silently and does not return direct feedback of its operation<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example eliminates the setup timing for paths from the bftClk:<br/>
		/// set_false_path -setup -from bftClk<br/>
		/// The following example excludes paths between the two clocks from timing analysis:<br/>
		/// set_false_path -from [get_clocks GT0_RXUSRCLK2_OUT] \<br/>
		/// -to [get_clocks DRPCLK_OUT]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1618<br/>
		/// </para>
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
		public TTCL set_false_path(bool? setup = null, bool? hold = null, bool? rise = null, bool? fall = null, bool? reset_path = null, TCLParameterList from = null, TCLParameterList rise_from = null, TCLParameterList fall_from = null, TCLParameterList to = null, TCLParameterList rise_to = null, TCLParameterList fall_to = null, TCLParameterList through = null, TCLParameterList rise_through = null, TCLParameterList fall_through = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_false_path [-setup] [-hold] [-rise] [-fall] [-reset_path] [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-through <args>] [-rise_through <args>] [-fall_through <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.set_false_path(setup, hold, rise, fall, reset_path, from, rise_from, fall_from, to, rise_to, fall_to, through, rise_through, fall_through, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set hierarchical separator character<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_hierarchy_separator [-quiet] [-verbose] [&lt;separator&gt;]
		/// <br/>
		/// <para>
		/// Sets the character that will be used for separating levels of hierarchy in the design.<br/>
		/// Note: This command operates silently and does not return direct feedback of its operation<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example changes the hierarchy separator to the '|' character:<br/>
		/// set_hierarchy_separator |<br/>
		/// The following example restores the default hierarchy separator, '/':<br/>
		/// set_hierarchy_separator<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1621<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="separator">(Optional) Hierarchy separator character Default: /</param>
		public TTCL set_hierarchy_separator(bool? quiet = null, bool? verbose = null, TCLObject separator = null)
		{
			// TCL Syntax: set_hierarchy_separator [-quiet] [-verbose] [<separator>]
			_tcl.Entry(_builder.set_hierarchy_separator(quiet, verbose, separator));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set input delay on ports<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_input_delay [-clock &lt;args&gt;] [-reference_pin &lt;args&gt;] [-clock_fall] [-rise] [-fall] [-max] [-min] [-add_delay] [-network_latency_included] [-source_latency_included] [-quiet] [-verbose] &lt;delay&gt; &lt;objects&gt;
		/// <br/>
		/// <para>
		/// TIP: The XDC &gt; Timing Constraints language templates and the Timing Constraints Wizard in the Vivado<br/>
		/// IDE offer timing diagrams and additional details around defining specific timing constraints. You can refer<br/>
		/// to these sources for additional information.<br/>
		/// Specifies the external system-level path delay on a primary input port relative to a clock edge at<br/>
		/// the interface of the design. The input delay value is specified in nanoseconds (ns), and can be<br/>
		/// positive or negative, depending on the clock and data relative phase at the interface of the<br/>
		/// device.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// To accurately model the system-level timing of your Xilinx FPGA design, you must assign timing<br/>
		/// delays for objects external to the FPGA onto the primary input or output ports in your design.<br/>
		/// These delays are defined by the set_input_delay and set_output_delay commands.<br/>
		/// IMPORTANT! If the input port also has a set_max_delay constraint assigned, the specified input<br/>
		/// delay value is considered part of the max_delay computation. That is, the input delay consumes a portion<br/>
		/// of the max delay on the timing path that includes the input port.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example specifies the input delay on port DIN. The input delay is 3 and is relative<br/>
		/// to the rising edge of clock clk1:<br/>
		/// set_input_delay -clock clk1 3 DIN<br/>
		/// The following example specifies the input delay on port DIN. The input delay is 2 and is relative<br/>
		/// to the falling edge of the clock clk1:<br/>
		/// set_input_delay -clock_fall -clock clk1 2 DIN<br/>
		/// The following example specifies the input delay on port reset. The input delay is 2 and is relative<br/>
		/// to the rising edge of the clock that appears on the pin wbClk_IBUF_BUFG_inst/O, originating<br/>
		/// from the clock wbClk:<br/>
		/// set_input_delay -clock wbClk 2 -reference_pin \<br/>
		/// [get_pin wbClk_IBUF_BUFG_inst/O] reset<br/>
		/// This example creates a clock named clk_ddr, and defines input delay constraints from data<br/>
		/// launched by both rising and falling edges of the clock outside the device to the data input of the<br/>
		/// internal flip-flop that is sensitive to both rising and falling clock edges:<br/>
		/// create_clock -name clk_ddr -period 6 [get_ports DDR_CLK_IN]<br/>
		/// set_input_delay -clock clk_ddr -max 2.1 [get_ports DDR_IN]<br/>
		/// set_input_delay -clock clk_ddr -max 1.9 [get_ports DDR_IN] -clock_fall -<br/>
		/// add_delay<br/>
		/// set_input_delay -clock clk_ddr -min 0.9 [get_ports DDR_IN]<br/>
		/// set_input_delay -clock clk_ddr -min 1.1 [get_ports DDR_IN] -clock_fall -<br/>
		/// add_delay<br/>
		/// Note: The use of the -add_delay option allows the new min and max delay constraints to exist alongside<br/>
		/// the first delays on the same port.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example specifies the input delay on all non clock input ports of the design.<br/>
		/// Although all_inputs returns all ports of the design, including clock ports, set_input_delay will skip<br/>
		/// setting input delays on the clock ports. The input delay is 1 relative to the rising edge of the clock<br/>
		/// wbClk:<br/>
		/// set_input_delay -clock wbClk 1 [all_inputs]<br/>
		/// The following example sets an input delay of 4 relative to the rising edge of the clock wbClk on<br/>
		/// the ports reset and wbDataForInput:<br/>
		/// set_input_delay -clock wbClk 4 [list reset wbDataForInput]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1626<br/>
		/// </para>
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
		public TTCL set_input_delay(TCLObject delay, TCLObject objects, TCLParameterList clock = null, TCLParameterList reference_pin = null, bool? clock_fall = null, bool? rise = null, bool? fall = null, bool? max = null, bool? min = null, bool? add_delay = null, bool? network_latency_included = null, bool? source_latency_included = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_input_delay [-clock <args>] [-reference_pin <args>] [-clock_fall] [-rise] [-fall] [-max] [-min] [-add_delay] [-network_latency_included] [-source_latency_included] [-quiet] [-verbose] <delay> <objects>
			_tcl.Entry(_builder.set_input_delay(delay, objects, clock, reference_pin, clock_fall, rise, fall, max, min, add_delay, network_latency_included, source_latency_included, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set input jitter for a clock object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_input_jitter [-quiet] [-verbose] &lt;clock&gt; &lt;input_jitter&gt;
		/// <br/>
		/// <para>
		/// Use the set_input_jitter command to specify additional jitter for a specific primary clock.<br/>
		/// Input jitter is the difference between successive clock edges due to variation from the ideal<br/>
		/// arrival times. This command sets the input jitter in nanoseconds (ns) for a specified primary clock,<br/>
		/// defined with the create_clock command. Because the command accepts a single clock, the<br/>
		/// jitter for each primary clock must be set individually.<br/>
		/// You can only use the set_input_jitter command to specify input jitter on primary clocks.<br/>
		/// You cannot use the command to set input jitter on generated or auto derived clocks. Input jitter is<br/>
		/// propagated to generated clocks from the master clock, except for MMCM and PLL.<br/>
		/// The input jitter is used in the calculation of discrete jitter, which is the amount of jitter introduced<br/>
		/// by hardware primitives such as MMCM or PLL. Discrete jitter is a feature of clocks generated by<br/>
		/// the MMCM. See set_clock_uncertainty.<br/>
		/// The set_input_jitter command is ignored during synthesis.<br/>
		/// TIP: INPUT_JITTER is a property of primary clocks that can be returned by the get_property or<br/>
		/// report_property commands.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets an input jitter value of 0.3 ns on two clocks, sysClk and procClk.<br/>
		/// Although the jitter values are the same, you must use two set_input_jitter commands<br/>
		/// since the command only takes one clock as an argument:<br/>
		/// set_input_jitter sysClk 0.3<br/>
		/// set_input_jitter procClk 0.3<br/>
		/// The following example defines a primary clock, sysClk, and a generated clock, sysClkDiv2, that is<br/>
		/// a divide by two version of the primary clock. An input jitter of 0.15 ns is specified on the primary<br/>
		/// clock. The input jitter is automatically propagated to the generated clock:<br/>
		/// create_clock -period 10 -name sysClk [get_ports sysClk]<br/>
		/// create_generated_clock -name sysClkDiv2 -source [get_ports sysClk] \<br/>
		/// -divide_by 2 [get_pins clkgen/sysClkDiv/Q]<br/>
		/// set_input_jitter sysClk 0.15<br/>
		/// Note: In this example sysClkDiv2 is generated by a divider implemented with flip-flops, so the input jitter is<br/>
		/// propagated from the primary clock.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1630<br/>
		/// </para>
		/// </summary>
		/// <param name="clock">(Required) Clock</param>
		/// <param name="input_jitter">(Required) Input jitter: Value &gt;= 0</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>clock</returns>
		public TTCL set_input_jitter(TCLObject clock, TCLObject input_jitter, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_input_jitter [-quiet] [-verbose] <clock> <input_jitter>
			_tcl.Entry(_builder.set_input_jitter(clock, input_jitter, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set capacitance on output ports and output pins<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_load [-rise] [-fall] [-max] [-min] [-quiet] [-verbose] &lt;capacitance&gt; &lt;objects&gt;
		/// <br/>
		/// <para>
		/// Sets the load capacitance on output ports to the specified value. The load capacitance is used<br/>
		/// during power analysis when running the report_power command, but is not used during<br/>
		/// timing analysis.<br/>
		/// TIP: The default unit of capacitance is picofarads (pF), but can be changed using the set_units<br/>
		/// command.<br/>
		/// This command operates silently and does not return direct feedback of its operation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets the specified load capacitance value for all ports:<br/>
		/// set_load 5.5 [all_outputs]<br/>
		/// The following example sets the rising and falling edge load capacitance for the specified output<br/>
		/// ports:<br/>
		/// set_load -rise -fall 8 [get_ports wbOutput*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1633<br/>
		/// </para>
		/// </summary>
		/// <param name="capacitance">(Required) Capacitance value</param>
		/// <param name="objects">(Required) List of output ports and output pins</param>
		/// <param name="rise">(Optional) Specify the rise capacitance value (for ports only)</param>
		/// <param name="fall">(Optional) Specify the fall capacitance value (for ports only)</param>
		/// <param name="max">(Optional) Specify the maximum capacitance value</param>
		/// <param name="min">(Optional) Specify the minimum capacitance value</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_load(TCLObject capacitance, TCLObject objects, bool? rise = null, bool? fall = null, bool? max = null, bool? min = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_load [-rise] [-fall] [-max] [-min] [-quiet] [-verbose] <capacitance> <objects>
			_tcl.Entry(_builder.set_load(capacitance, objects, rise, fall, max, min, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Sets logic dc for input ports and input pins<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_logic_dc [-quiet] [-verbose] &lt;objects&gt;
		/// <br/>
		/// <para>
		/// Sets the specified input ports or input pins to a logic value of 'X', as unknown or don't care. This<br/>
		/// command is NOT supported in Synthesis.<br/>
		/// Note: This command operates silently and does not return direct feedback of its operation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets the specified port to 'X':<br/>
		/// set_logic_dc [get_ports reset]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1635<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) List of input ports and input pins</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_logic_dc(TCLObject objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_logic_dc [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.set_logic_dc(objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Sets logic one for input ports and input pins<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_logic_one [-quiet] [-verbose] &lt;objects&gt;
		/// <br/>
		/// <para>
		/// Sets the specified input ports or input pins to a logic one. This command is NOT supported in<br/>
		/// Synthesis.<br/>
		/// Note: This command operates silently and does not return direct feedback of its operation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets the specified input port to a logic one:<br/>
		/// set_logic_one [get_ports reset]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example sets the input ports reset and wbDataForInput to a logic one:<br/>
		/// set_logic_one [list [get_ports reset] [get_ports wbDataForInput]]<br/>
		/// The following example sets the input pin I on instance reset_IBUF to a logic one:<br/>
		/// set_logic_one [get_pins reset_IBUF_inst/I]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1637<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) List of input ports and input pins</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_logic_one(TCLObject objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_logic_one [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.set_logic_one(objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Sets logic unconnected for output ports and output pins<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_logic_unconnected [-quiet] [-verbose] &lt;objects&gt;
		/// <br/>
		/// <para>
		/// Defines the specified output ports or pins as unconnected.<br/>
		/// Note: This command operates silently and does not return direct feedback of its operation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets the specified port to unconnected:<br/>
		/// set_logic_unconnected [get_ports OUT1]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1639<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) List of output ports and output pins</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_logic_unconnected(TCLObject objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_logic_unconnected [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.set_logic_unconnected(objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Sets logic zero for input ports and input pins<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_logic_zero [-quiet] [-verbose] &lt;objects&gt;
		/// <br/>
		/// <para>
		/// Sets the specified input ports and input pins to a logic zero. This command is NOT supported in<br/>
		/// Synthesis.<br/>
		/// Note: This command operates silently and does not return direct feedback of its operation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets the specified port to logic state 0:<br/>
		/// set_logic_zero [get_ports reset]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1641<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) List of input ports and input pins</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_logic_zero(TCLObject objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_logic_zero [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.set_logic_zero(objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Specify maximum delay for timing paths<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_max_delay [-rise] [-fall] [-reset_path] [-from &lt;args&gt;] [-rise_from &lt;args&gt;] [-fall_from &lt;args&gt;] [-to &lt;args&gt;] [-rise_to &lt;args&gt;] [-fall_to &lt;args&gt;] [-through &lt;args&gt;] [-rise_through &lt;args&gt;] [-fall_through &lt;args&gt;] [-datapath_only] [-quiet] [-verbose] &lt;delay&gt;
		/// <br/>
		/// <para>
		/// TIP: The XDC &gt; Timing Constraints language templates and the Timing Constraints Wizard in the Vivado<br/>
		/// IDE offer timing diagrams and additional details around defining specific timing constraints. You can refer<br/>
		/// to these sources for additional information.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Sets the maximum delay allowed on a timing path, specified in nanoseconds (ns). The specified<br/>
		/// delay value is assigned to both the rising and falling edges of the defined timing paths unless the<br/>
		/// -rise or -fall arguments are specified.<br/>
		/// The maximum rising and falling delay cannot be less than the minimum rising and falling delay on<br/>
		/// the same path, as defined by the set_min_delay command. If this happens, the first assigned<br/>
		/// constraint is removed from the timing path as a conflict, and the delay value specified by the<br/>
		/// removed constraint is set to 0.<br/>
		/// The delay value must be assigned to a timing path as defined by at least one -from, -through,<br/>
		/// or -to argument. A general path delay such as -to endpoint will be over written by a more<br/>
		/// specific path definition such as -from/-to, or -from/-through/-to path definition.<br/>
		/// IMPORTANT! When assigned to a primary input or output port, any system-level delay consumes a<br/>
		/// portion of the max delay on the timing path that includes the input or output port. That is, the delay<br/>
		/// specified by set_input_delay or set_output_delay is considered part of the maximum delay.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example defines a maximum delay of 60 ns between all the input and output ports<br/>
		/// (feedthrough paths):<br/>
		/// set_max_delay 60 -from [all_inputs] -to [all_outputs]<br/>
		/// The following example clears the existing max delay and specifies a new &gt; maximum delay for<br/>
		/// paths to endpoints clocked by the specified clock:<br/>
		/// set_max_delay -reset_path 50 -to [get_clocks spi_clk]<br/>
		/// The set_max_delay command is often used with -datapath_only to constrain asynchronous clock<br/>
		/// domains crossing when a simple synchronizer is used on the destination clock domain. In the<br/>
		/// following example, two flops (FF1 and FF2) are clocked by different clocks, and FF1/Q connects<br/>
		/// directly to FF2/D through net1. To limit the delay on this connection to 4.0 ns use the following<br/>
		/// constraints:<br/>
		/// set_max_delay -from FF1/C -to FF2/D -datapath_only 4.0<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1643<br/>
		/// </para>
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
		public TTCL set_max_delay(TCLObject delay, bool? rise = null, bool? fall = null, bool? reset_path = null, TCLParameterList from = null, TCLParameterList rise_from = null, TCLParameterList fall_from = null, TCLParameterList to = null, TCLParameterList rise_to = null, TCLParameterList fall_to = null, TCLParameterList through = null, TCLParameterList rise_through = null, TCLParameterList fall_through = null, bool? datapath_only = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_max_delay [-rise] [-fall] [-reset_path] [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-through <args>] [-rise_through <args>] [-fall_through <args>] [-datapath_only] [-quiet] [-verbose] <delay>
			_tcl.Entry(_builder.set_max_delay(delay, rise, fall, reset_path, from, rise_from, fall_from, to, rise_to, fall_to, through, rise_through, fall_through, datapath_only, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Limit time borrowing for latches<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_max_time_borrow [-quiet] [-verbose] &lt;delay&gt; &lt;objects&gt;
		/// <br/>
		/// <para>
		/// Sets the maximum amount of time in nanoseconds that can be borrowed between nets when<br/>
		/// analyzing the timing on latches.<br/>
		/// Note: This command operates silently and does not return direct feedback of its operation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example specifies that the latches attached to "all clocks" will be allowed 0 time<br/>
		/// units of borrowing. Effectively, this disables time borrowing throughout the entire design.<br/>
		/// set_max_time_borrow 0.0 [all_clocks]<br/>
		/// The following example specifies that nets in the top level of hierarchy are allowed 20 time units<br/>
		/// of time borrowing:<br/>
		/// set_max_time_borrow 20 {top/*}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1647<br/>
		/// </para>
		/// </summary>
		/// <param name="delay">(Required) Delay value: Value &gt;= 0</param>
		/// <param name="objects">(Required) List of clocks, cells, data pins or clock pins</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_max_time_borrow(TCLObject delay, TCLObject objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_max_time_borrow [-quiet] [-verbose] <delay> <objects>
			_tcl.Entry(_builder.set_max_time_borrow(delay, objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Specify minimum delay for timing paths<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_min_delay [-rise] [-fall] [-reset_path] [-from &lt;args&gt;] [-rise_from &lt;args&gt;] [-fall_from &lt;args&gt;] [-to &lt;args&gt;] [-rise_to &lt;args&gt;] [-fall_to &lt;args&gt;] [-through &lt;args&gt;] [-rise_through &lt;args&gt;] [-fall_through &lt;args&gt;] [-quiet] [-verbose] &lt;delay&gt;
		/// <br/>
		/// <para>
		/// Sets the minimum delay allowed on a timing path, specified in nanoseconds (ns). The specified<br/>
		/// delay value is assigned to both the rising and falling edges of the defined timing paths unless the<br/>
		/// -rise or -fall arguments are specified.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// IMPORTANT! The minimum rising and falling delay cannot be greater than the maximum rising and<br/>
		/// falling delay on the same path. If this happens, the first assigned delay value is removed from the timing<br/>
		/// path and reset to 0.<br/>
		/// The delay value must be assigned to a timing path as defined by at least one -from, -through,<br/>
		/// or -to argument. A general path delay such as -to endpoint will be over written by a more<br/>
		/// specific path definition such as -from/-to, or -from/-through/-to path definition.<br/>
		/// This command operates silently and does not return direct feedback of its operation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example specifies a minimum delay of 20ns between the primary input and output<br/>
		/// ports (combinational/feedthrough paths):<br/>
		/// set_min_delay 20 -from [all_inputs] -to [all_outputs]<br/>
		/// The following example defines a minimum delay of 20ns for timing paths with endpoints at all<br/>
		/// primary output ports:<br/>
		/// set_min_delay 20 -to [get_ports -filter {DIRECTION == out}]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1649<br/>
		/// </para>
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
		public TTCL set_min_delay(TCLObject delay, bool? rise = null, bool? fall = null, bool? reset_path = null, TCLParameterList from = null, TCLParameterList rise_from = null, TCLParameterList fall_from = null, TCLParameterList to = null, TCLParameterList rise_to = null, TCLParameterList fall_to = null, TCLParameterList through = null, TCLParameterList rise_through = null, TCLParameterList fall_through = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_min_delay [-rise] [-fall] [-reset_path] [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-through <args>] [-rise_through <args>] [-fall_through <args>] [-quiet] [-verbose] <delay>
			_tcl.Entry(_builder.set_min_delay(delay, rise, fall, reset_path, from, rise_from, fall_from, to, rise_to, fall_to, through, rise_through, fall_through, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Define multicycle path<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_multicycle_path [-setup] [-hold] [-rise] [-fall] [-start] [-end] [-reset_path] [-from &lt;args&gt;] [-rise_from &lt;args&gt;] [-fall_from &lt;args&gt;] [-to &lt;args&gt;] [-rise_to &lt;args&gt;] [-fall_to &lt;args&gt;] [-through &lt;args&gt;] [-rise_through &lt;args&gt;] [-fall_through &lt;args&gt;] [-quiet] [-verbose] &lt;path_multiplier&gt;
		/// <br/>
		/// <para>
		/// By default, the Vivado timing engine performs a single-cycle analysis, in which the setup check is<br/>
		/// performed at the destination on the capture edge, one clock cycle after the edge of the source<br/>
		/// clock. However, this may not be appropriate for certain timing paths. The most common example<br/>
		/// is a logic path that requires more than one clock cycle for the data to stabilize at the endpoint.<br/>
		/// The set_multicycle_path command lets you choose a path multiplier, N, to establish a<br/>
		/// timing path that takes N clock cycles from the start clock edge to the capture clock edge. The<br/>
		/// path multiplier defines the total number of clock cycles required for propagation of a signal from<br/>
		/// its origin to destination when that propagation is longer than a single clock cycle. For more<br/>
		/// information on the use of this command, refer to the Vivado Design Suite User Guide: Using<br/>
		/// Constraints (UG903).<br/>
		/// The set_multicycle_path command is used to specify path multipliers for setup and hold<br/>
		/// analysis, for rising and/or falling edges, with respect to the source clock or the destination clock.<br/>
		/// This command includes three elements:<br/>
		/// • The specification of the setup and hold analysis affected by the multicycle path.<br/>
		/// • The definition of the timing paths to which the multicycle path applies.<br/>
		/// • The path multiplier defining the number of clock cycles to apply to the timing analysis.<br/>
		/// By default the path multiplier applies to both the setup and hold analysis. The hold analysis is<br/>
		/// derived from the setup analysis, so it is moved along with the setup analysis. If the path multiplier<br/>
		/// moves the setup check N clock cycles, it moves the hold check N-1 clock cycles. However, this<br/>
		/// often results in hold timing failures.<br/>
		/// You can use a second set_multicycle_path command with the -hold option to restore the<br/>
		/// hold analysis to its original location. When the -hold option is specified the &lt;path_multiplier&gt;<br/>
		/// acts on the hold relationship to restore the hold check to its original position. For instance, the<br/>
		/// following command sequence extends the setup check for 3 clock cycles, and consequently<br/>
		/// extends the hold check by two clock cycles (N-1). The second command restores the hold check<br/>
		/// to its original position:<br/>
		/// set_multicycle_path 3 -from {usbEngine1/u4/csr_reg[26]/C} \<br/>
		/// -to {usbEngine1/u1/u2/sizd_c_reg[12]/D}<br/>
		/// set_multicycle_path 2 -from {usbEngine1/u4/csr_reg[26]/C} \<br/>
		/// -to {usbEngine1/u1/u2/sizd_c_reg[12]/D} -hold<br/>
		/// By default, the setup path multiplier is applied with respect to the destination clock, and the hold<br/>
		/// path multiplier is applied with respect to the source clock. Use the -start or -end options to<br/>
		/// change the default setup or hold analysis with respect to the source or destination clocks.<br/>
		/// This command operates silently when successful, or returns an error if the command fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example establishes a path multiplier of 3 clock cycles for the setup check of the<br/>
		/// timing path defined by the -from/-to options. A path multiplier of N-1, or 2 in this example, is<br/>
		/// used to decrement the hold check on the same timing path:<br/>
		/// set_multicycle_path 3 -setup -from [get_pins data0_reg/C] \<br/>
		/// -to [get_pins data1_reg/D]<br/>
		/// set_multicycle_path 2 -hold -from [get_pins data0_reg/C] \<br/>
		/// -to [get_pins data1_reg/D]<br/>
		/// Note: For more information on the relationship between the setup and hold analysis refer to the Vivado<br/>
		/// Design Suite User Guide: Using Constraints (UG903).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1658<br/>
		/// </para>
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
		public TTCL set_multicycle_path(TCLObject path_multiplier, bool? setup = null, bool? hold = null, bool? rise = null, bool? fall = null, bool? start = null, bool? end = null, bool? reset_path = null, TCLParameterList from = null, TCLParameterList rise_from = null, TCLParameterList fall_from = null, TCLParameterList to = null, TCLParameterList rise_to = null, TCLParameterList fall_to = null, TCLParameterList through = null, TCLParameterList rise_through = null, TCLParameterList fall_through = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_multicycle_path [-setup] [-hold] [-rise] [-fall] [-start] [-end] [-reset_path] [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-through <args>] [-rise_through <args>] [-fall_through <args>] [-quiet] [-verbose] <path_multiplier>
			_tcl.Entry(_builder.set_multicycle_path(path_multiplier, setup, hold, rise, fall, start, end, reset_path, from, rise_from, fall_from, to, rise_to, fall_to, through, rise_through, fall_through, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set operating conditions for power estimation<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_operating_conditions [-voltage &lt;args&gt;] [-grade &lt;arg&gt;] [-process &lt;arg&gt;] [-junction_temp &lt;arg&gt;] [-ambient_temp &lt;arg&gt;] [-thetaja &lt;arg&gt;] [-thetasa &lt;arg&gt;] [-airflow &lt;arg&gt;] [-heatsink &lt;arg&gt;] [-thetajb &lt;arg&gt;] [-board &lt;arg&gt;] [-board_temp &lt;arg&gt;] [-board_layers &lt;arg&gt;] [-design_power_budget &lt;arg&gt;] [-supply_current_budget &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Sets the real-world operating conditions that are used when performing analysis of the design.<br/>
		/// The environmental operating conditions of the device are used for power analysis when running<br/>
		/// the report_power command.<br/>
		/// Note: This command operates silently and does not return direct feedback of its operation.<br/>
		/// Operating conditions can be restored to their default values with the use of the<br/>
		/// reset_operating_conditions command.<br/>
		/// Current operating conditions can be reported with the report_operating_conditions<br/>
		/// command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example specifies an industrial grade device with an ambient operating<br/>
		/// temperature of 75 degrees C:<br/>
		/// set_operating_conditions -grade industrial -ambient_temp 75<br/>
		/// The following example sets the supply voltage Vccaux to a value of 1.9:<br/>
		/// set_operating_conditions -voltage {Vccaux 1.89}<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example sets the manufacturing process corner to maximum:<br/>
		/// set_operating_conditions -process maximum<br/>
		/// The following example sets the manufacturing process corner to maximum and the voltage<br/>
		/// supply Vccint to 0.875:<br/>
		/// set_operating_conditions -process maximum -voltage {Vccint 0.875}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1663<br/>
		/// </para>
		/// </summary>
		/// <param name="voltage">
		/// <para>
		/// (Optional)<br/>
		/// List of voltage pairs, e.g., {name value}. Supported voltage<br/>
		/// supplies vary by family.<br/>
		/// </para>
		/// </param>
		/// <param name="grade">
		/// <para>
		/// (Optional)<br/>
		/// Temperature grade. Supported values vary by family.<br/>
		/// Default: commercial<br/>
		/// </para>
		/// </param>
		/// <param name="process">(Optional) Process data: typical or maximum Default: typical</param>
		/// <param name="junction_temp">(Optional) Junction Temperature (C): auto|degC Default: auto</param>
		/// <param name="ambient_temp">(Optional) Ambient Temperature (C): default|degC Default: default</param>
		/// <param name="thetaja">(Optional) ThetaJA (C/W): auto|degC/W Default: auto</param>
		/// <param name="thetasa">(Optional) ThetaSA (C/W): auto|degC/W Default: auto</param>
		/// <param name="airflow">(Optional) Airflow (LFM): 0 to 750 Default: varies by family</param>
		/// <param name="heatsink">
		/// <para>
		/// (Optional)<br/>
		/// Dimensions of heatsink: none, low, medium, high, custom<br/>
		/// Default: medium<br/>
		/// </para>
		/// </param>
		/// <param name="thetajb">(Optional) ThetaJB (C/W): auto|degC/W Default: auto</param>
		/// <param name="board">(Optional) Board type: jedec, small, medium, large, custom Default: medium</param>
		/// <param name="board_temp">(Optional) Board Temperature degC</param>
		/// <param name="board_layers">(Optional) Board layers: 4to7, 8to11, 12to15, 16+ Default: 8to11</param>
		/// <param name="design_power_budget">(Optional) Design Power Budget (W) Default: Unspecified</param>
		/// <param name="supply_current_budget">
		/// <para>
		/// (Optional)<br/>
		/// Sets list of supply current budget 'name value' pairs.<br/>
		/// Supported voltage supplies vary by family.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_operating_conditions(TCLParameterList voltage = null, String grade = null, String process = null, String junction_temp = null, String ambient_temp = null, String thetaja = null, String thetasa = null, String airflow = null, String heatsink = null, String thetajb = null, String board = null, String board_temp = null, String board_layers = null, String design_power_budget = null, TCLParameterList supply_current_budget = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_operating_conditions [-voltage <args>] [-grade <arg>] [-process <arg>] [-junction_temp <arg>] [-ambient_temp <arg>] [-thetaja <arg>] [-thetasa <arg>] [-airflow <arg>] [-heatsink <arg>] [-thetajb <arg>] [-board <arg>] [-board_temp <arg>] [-board_layers <arg>] [-design_power_budget <arg>] [-supply_current_budget <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.set_operating_conditions(voltage, grade, process, junction_temp, ambient_temp, thetaja, thetasa, airflow, heatsink, thetajb, board, board_temp, board_layers, design_power_budget, supply_current_budget, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set output delay on ports<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_output_delay [-clock &lt;args&gt;] [-reference_pin &lt;args&gt;] [-clock_fall] [-rise] [-fall] [-max] [-min] [-add_delay] [-network_latency_included] [-source_latency_included] [-quiet] [-verbose] &lt;delay&gt; &lt;objects&gt;
		/// <br/>
		/// <para>
		/// TIP: The XDC &gt; Timing Constraints language templates and the Timing Constraints Wizard in the Vivado<br/>
		/// IDE offer timing diagrams and additional details around defining specific timing constraints. You can refer<br/>
		/// to these sources for additional information.<br/>
		/// Specifies the external system-level path delay on a primary output port relative to a clock edge at<br/>
		/// the interface of the design. The output delay value is specified in nanoseconds (ns), and can be<br/>
		/// positive or negative, depending on the clock and data relative phase outside the FPGA device.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// To accurately model the system-level timing of your Xilinx FPGA design, you must assign timing<br/>
		/// delays for objects external to the FPGA onto the primary input or output ports in your design.<br/>
		/// These delays are defined by the set_input_delay and set_output_delay commands.<br/>
		/// IMPORTANT! If the output port also has a set_max_delay constraint assigned, the specified output<br/>
		/// delay value is considered part of the max_delay computation. That is, the output delay consumes a portion<br/>
		/// of the max delay on the timing path that includes the output port.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets an output delay on ports relative to the specified clock:<br/>
		/// set_output_delay 5.0 -clock [get_clocks cpuClk] [get_ports]<br/>
		/// The next example is the same as the prior example except that network latency is now included:<br/>
		/// set_output_delay 5.0 -clock [get_clocks cpuClk] \<br/>
		/// -network_latency_included [get_ports]<br/>
		/// This example creates a clock named clk_ddr, and defines output delay constraints from data<br/>
		/// launched by both rising and falling edges of the clock outside the device to the data output of<br/>
		/// the internal flip-flop that is sensitive to both rising and falling clock edges:<br/>
		/// create_clock -name clk_ddr -period 6 [get_ports DDR_CLK_IN]<br/>
		/// set_output_delay -clock clk_ddr -max 2.1 [get_ports DDR_OUT]<br/>
		/// set_output_delay -clock clk_ddr -max 1.9 [get_ports DDR_OUT] -clock_fall -<br/>
		/// add_delay<br/>
		/// set_output_delay -clock clk_ddr -min 0.9 [get_ports DDR_OUT]<br/>
		/// set_output_delay -clock clk_ddr -min 1.1 [get_ports DDR_OUT] -clock_fall -<br/>
		/// add_delay<br/>
		/// Note: The use of the -add_delay option allows the new min and max delay constraints to exist alongside<br/>
		/// the first delays on the same port.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1667<br/>
		/// </para>
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
		public TTCL set_output_delay(TCLObject delay, TCLObject objects, TCLParameterList clock = null, TCLParameterList reference_pin = null, bool? clock_fall = null, bool? rise = null, bool? fall = null, bool? max = null, bool? min = null, bool? add_delay = null, bool? network_latency_included = null, bool? source_latency_included = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_output_delay [-clock <args>] [-reference_pin <args>] [-clock_fall] [-rise] [-fall] [-max] [-min] [-add_delay] [-network_latency_included] [-source_latency_included] [-quiet] [-verbose] <delay> <objects>
			_tcl.Entry(_builder.set_output_delay(delay, objects, clock, reference_pin, clock_fall, rise, fall, max, min, add_delay, network_latency_included, source_latency_included, quiet, verbose));
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
		/// Set constraints for power optimization<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_power_opt [-include_cells &lt;args&gt;] [-exclude_cells &lt;args&gt;] [-clocks &lt;args&gt;] [-cell_types &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Specify cell instances to include or exclude in power optimization. The specified cells are<br/>
		/// optimized using the power_opt_design command.<br/>
		/// TIP: Block RAM optimizations are performed by default with the opt_design command. Some or all<br/>
		/// BRAM cells can be excluded from the opt_design optimization using the set_power_opt command<br/>
		/// as well.<br/>
		/// The effect of multiple set_power_opt commands is cumulative, so that you can specify a<br/>
		/// broad class of cell types to optimize, include specific hierarchical cells, and then exclude cells<br/>
		/// within the included hierarchy to refine the power optimization.<br/>
		/// The power optimizations that have been performed can be reported using the<br/>
		/// report_power_opt command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets power optimization for BRAM cells only, and then runs power<br/>
		/// optimization:<br/>
		/// set_power_opt -cell_types bram<br/>
		/// power_opt_design<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example sets power optimization for BRAM and REG type cells, then adds SRLs,<br/>
		/// and runs power optimization. Then all cells are cleared, and only SRLs are included, and power<br/>
		/// optimization is run again:<br/>
		/// set_power_opt -cell_types { bram reg}<br/>
		/// set_power_opt -cell_types { srl}<br/>
		/// power_opt_design<br/>
		/// set_power_opt -cell_types { none}<br/>
		/// set_power_opt -cell_types { srl}<br/>
		/// power_opt_design<br/>
		/// The following example sets power optimization for BRAM cells only, excludes the cpuEngine<br/>
		/// block from optimization, but then includes the cpuEngine/cpu_dbg_dat_i block, then performs<br/>
		/// power optimization:<br/>
		/// set_power_opt -cell_types bram<br/>
		/// set_power_opt -exclude_cells cpuEngine<br/>
		/// set_power_opt -include_cells cpuEngine/cpu_dbg_dat_i<br/>
		/// power_opt_design<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1677<br/>
		/// </para>
		/// </summary>
		/// <param name="include_cells">(Optional) Include only these instances for clock gating. Default: all</param>
		/// <param name="exclude_cells">(Optional) Exclude these instances from clock gating. Default: none</param>
		/// <param name="clocks">(Optional) Clock gate instances clocked by these clocks only. Default: all clocks</param>
		/// <param name="cell_types">
		/// <para>
		/// (Optional)<br/>
		/// Clock gate these cell types only. Specify either [all|none], or<br/>
		/// one or more of [bram|reg|srl]. Default: all<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_power_opt(TCLParameterList include_cells = null, TCLParameterList exclude_cells = null, TCLParameterList clocks = null, TCLParameterList cell_types = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_power_opt [-include_cells <args>] [-exclude_cells <args>] [-clocks <args>] [-cell_types <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.set_power_opt(include_cells, exclude_cells, clocks, cell_types, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Specify propagated clock latency<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_propagated_clock [-quiet] [-verbose] &lt;objects&gt;
		/// <br/>
		/// <para>
		/// Propagates clock latency throughout a clock network, resulting in more accurate skew and timing<br/>
		/// results throughout the clock network.<br/>
		/// Note: This command operates silently and does not return direct feedback of its operation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example specifies that the primary system clock from the top-level should be propagated:<br/>
		/// set_propagated_clock [get_clocks top/clk]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This example specifies that all clocks from "sublevel1" should be propagated:<br/>
		/// set_propagated_clock [get_clocks sublevel1/*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1680<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) List of clocks, ports, or pins</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_propagated_clock(TCLObject objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_propagated_clock [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.set_propagated_clock(objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set property on object(s)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_property [-dict &lt;args&gt;] [-quiet] [-verbose] &lt;name&gt; &lt;value&gt; &lt;objects&gt;...
		/// <br/>
		/// <para>
		/// Assigns the defined property &lt;name&gt; and &lt;value&gt; to the specified &lt;objects&gt;.<br/>
		/// This command can be used to define any property on an object in the design. Each object has a<br/>
		/// set of predefined properties that have expected values, or a range of values. The set_property<br/>
		/// command can be used to define the values for these properties. To determine the defined set of<br/>
		/// properties on an object, use report_property, list_property, or<br/>
		/// list_property_values.<br/>
		/// You can also define custom properties for an object, by specifying a unique &lt;name&gt; and &lt;value&gt;<br/>
		/// pair for the object. If an object has custom properties, these will also be reported by the<br/>
		/// report_property and list_property commands.<br/>
		/// This command returns nothing if successful, and an error if it fails.<br/>
		/// TIP: You can use the get_property command to validate any properties that have been set on an<br/>
		/// object.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// Create a user-defined boolean property, TRUTH, for cell objects, and set the property on a cell:<br/>
		/// create_property -type bool truth cell<br/>
		/// set_property truth false [lindex [get_cells] 1]<br/>
		/// Use the -dict option to specify multiple properties at one time on the current design:<br/>
		/// set_property -dict "POST_CRC enable POST_CRC_ACTION correct_and_continue"<br/>
		/// \<br/>
		/// [current_design]<br/>
		/// The following example sets the TOP property of the current fileset to define the top module of<br/>
		/// the project:<br/>
		/// set_property top fftTop [current_fileset]<br/>
		/// set_property top_file {C:/Data/sources/fftTop.v} [current_fileset]<br/>
		/// Note: Defining the top module requires the TOP property to be set to the desired hierarchical block in the<br/>
		/// source fileset of the current project. In the preceding example TOP is the property name, fftTop is the<br/>
		/// value, and current_fileset is the object. In addition, the TOP_FILE property should be defined to point to<br/>
		/// the data source for the top module.<br/>
		/// This example shows how to set a property value that includes the dash character, '-'. The dash<br/>
		/// can cause the tool to interpret the value as a new command argument, rather than part of the<br/>
		/// value being specified, and will cause an error as shown. In this case, you must use the explicit<br/>
		/// form of the positional arguments in the set_property command:<br/>
		/// set_property {XELAB.MORE_OPTIONS} {-pulse_e_style ondetect} \<br/>
		/// [get_filesets sim_1]<br/>
		/// ERROR: [Common 17-170] Unknown option '-pulse_e_style ondetect',<br/>
		/// please type 'set_property -help' for usage info.<br/>
		/// set_property -name {XELAB.MORE_OPTIONS} -value {-pulse_e_style ondetect}\<br/>
		/// -objects [get_filesets sim_1]<br/>
		/// The following example sets the internal VREF property value for the specified IO Bank:<br/>
		/// set_property internal_vref {0.75} [get_iobanks 0]<br/>
		/// The following example defines a DCI Cascade by setting the DCI_CASCADE property for the<br/>
		/// specified IO Bank:<br/>
		/// set_property DCI_CASCADE {14} [get_iobanks 0 ]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example configures the synth_1 run, setting options for Vivado Synthesis 2013,<br/>
		/// and then launches the synthesis run:<br/>
		/// set_property flow {Vivado Synthesis 2016} \<br/>
		/// [get_runs synth_1]<br/>
		/// set_property STEPS.SYNTH_DESIGN.ARGS.GATED_CLOCK_CONVERSION on \<br/>
		/// [get_runs synth_1]<br/>
		/// set_property STEPS.SYNTH_DESIGN.ARGS.FSM_EXTRACTION one_hot \<br/>
		/// [get_runs synth_1]<br/>
		/// launch_runs synth_1<br/>
		/// This example is the same as the prior example, except that it uses the -dict option to set all the<br/>
		/// properties on the synthesis run in a single set_property command:<br/>
		/// set_property -dict [ list flow {Vivado Synthesis 2016} \<br/>
		/// STEPS.SYNTH_DESIGN.ARGS.GATED_CLOCK_CONVERSION on \<br/>
		/// STEPS.SYNTH_DESIGN.ARGS.FSM_EXTRACTION \<br/>
		/// one_hot ] [get_runs synth_1]<br/>
		/// launch_runs synth_1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1682<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of property to set. Not valid with -dict option</param>
		/// <param name="value">(Required) Value of property to set. Not valid with -dict option</param>
		/// <param name="objects">(Required) Objects to set properties on</param>
		/// <param name="dict">(Optional) list of name/value pairs of properties to set</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_property(TCLObject name, TCLObject value, TCLObjectList objects, TCLParameterList dict = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_property [-dict <args>] [-quiet] [-verbose] <name> <value> <objects>...
			_tcl.Entry(_builder.set_property(name, value, objects, dict, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set switching activity on specified objects or default types<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_switching_activity [-toggle_rate &lt;arg&gt;] [-default_toggle_rate &lt;arg&gt;] [-type &lt;args&gt;] [-all] [-static_probability &lt;arg&gt;] [-default_static_probability &lt;arg&gt;] [-signal_rate &lt;arg&gt;] [-hier] [-deassert_resets] [-quiet] [-verbose] [&lt;objects&gt;...]
		/// <br/>
		/// <para>
		/// Sets the signal rate and the switching probability to be used when performing power estimation<br/>
		/// on the current synthesized or implemented design. These include simple signal rate and simple<br/>
		/// static probability on nets, ports, and pins; and state dependent static probabilities on cells.<br/>
		/// Note: This command operates silently and does not return direct feedback of its operation.<br/>
		/// The switching activity of a design affects both the static and dynamic power consumption. The<br/>
		/// static power is often dependent on logic state transitions, and the dynamic power is directly<br/>
		/// proportional to the toggle rate.<br/>
		/// The set_switching_activity command can be used to specify default activity rates for the<br/>
		/// whole design, or to define the activity of one or more signals in the design or on a specified<br/>
		/// module.<br/>
		/// The current switching activity attributes can be found by using the<br/>
		/// report_switching_activity command. The values can be set to their default values by<br/>
		/// using the reset_switching_activity command.<br/>
		/// Note: The reset_switching_activity is used to reset switching activity for specified objects. Use the<br/>
		/// set_switching_activity -default_toggle_rate or -default_static_probability to<br/>
		/// change or reset these values.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example specifies a signal rate and switching probability for all ports, then reports<br/>
		/// the switching attributes for those ports:<br/>
		/// set_switching_activity -signal_rate 55 -static_probability .33 [get_ports]<br/>
		/// report_switching_activity [get_ports]<br/>
		/// The following example specifies the default switching probability for the current design:<br/>
		/// set_switching_activity -default_static_probability .75<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This example sets the specified toggle rate and static probability on all registers in the hierarchy<br/>
		/// of "CPU/MEM":<br/>
		/// set_switching_activity -type register -toggle_rate 0.4 \<br/>
		/// -static_probability 0.5 [get_cells CPU/MEM]<br/>
		/// This example sets the specified toggle rate and static probability on all registers in the hierarchy<br/>
		/// of "CPU/" and underneath hierarchy:<br/>
		/// set_switching_activity -type register -toggle_rate 0.4<br/>
		/// -static_probability 0.5 -hier [get_cells CPU]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1688<br/>
		/// </para>
		/// </summary>
		/// <param name="toggle_rate">
		/// <para>
		/// (Optional)<br/>
		/// Toggle rate (%) is the rate at which the output of<br/>
		/// synchronous logic element switches compared to a given<br/>
		/// clock input. It is modeled as a percentage between 0 - 200%.<br/>
		/// A toggle rate of 100% means that on average the output<br/>
		/// toggles once during every clock cycle, changing on either<br/>
		/// the rising or falling clock edges, and making the effective<br/>
		/// output signal frequency half of the clock frequency. Default:<br/>
		/// 0.0<br/>
		/// </para>
		/// </param>
		/// <param name="default_toggle_rate">
		/// <para>
		/// (Optional)<br/>
		/// The default toggle rate to be used in power analysis on the<br/>
		/// primary inputs of the design. The default toggle rate is set<br/>
		/// on those primary input nets whose switching activity is not<br/>
		/// specified by the user, simulation data or constraints of the<br/>
		/// design. Valid values are: 0 &lt;= value &lt; 200. The default value<br/>
		/// is 12.5. Default: 12.5<br/>
		/// </para>
		/// </param>
		/// <param name="type">
		/// <para>
		/// (Optional)<br/>
		/// Specify nodes in a specific category. List of valid type values:<br/>
		/// io_output, io_bidir_enable, register, lut_ram, lut, dsp,<br/>
		/// bram_enable, bram_wr_enable, gt_txdata, gt_rxdata.<br/>
		/// </para>
		/// </param>
		/// <param name="all">
		/// <para>
		/// (Optional)<br/>
		/// Used together with -type, set switching activity on -type nets<br/>
		/// within an instance<br/>
		/// </para>
		/// </param>
		/// <param name="static_probability">(Optional) Static probability value: 0 &lt;= Value &lt;= 1 Default: 0.5</param>
		/// <param name="default_static_probability">
		/// <para>
		/// (Optional)<br/>
		/// The default static probability to be used in power analysis<br/>
		/// on the design. The default static probability is set on those<br/>
		/// primary inputs whose switching activity is not specified by<br/>
		/// the user, simulation data or constraints of the design. Valid<br/>
		/// values are: 0 &lt;= Value &lt;= 1. The default value is 0.5. Default:<br/>
		/// 0.5<br/>
		/// </para>
		/// </param>
		/// <param name="signal_rate">
		/// <para>
		/// (Optional)<br/>
		/// The number of times an element changed state (high-to-low<br/>
		/// and low-to-high) per second. Xilinx tools express this as<br/>
		/// millions of transitions per second (Mtr/s). Default: 0.0<br/>
		/// </para>
		/// </param>
		/// <param name="hier">
		/// <para>
		/// (Optional)<br/>
		/// Hierarchically sets the switching activity on a hierarchical<br/>
		/// instance provided via &lt;objects&gt; option. This option should<br/>
		/// be used only with &lt;objects&gt; option<br/>
		/// </para>
		/// </param>
		/// <param name="deassert_resets">
		/// <para>
		/// (Optional)<br/>
		/// A switch to elegantly auto deassert all set,reset,preset and<br/>
		/// clear signals that do not have conflicted polarities<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">
		/// <para>
		/// (Optional)<br/>
		/// Objects to set switching activity on<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// </param>
		public TTCL set_switching_activity(String toggle_rate = null, String default_toggle_rate = null, TCLParameterList type = null, bool? all = null, String static_probability = null, String default_static_probability = null, Int32? signal_rate = null, bool? hier = null, bool? deassert_resets = null, bool? quiet = null, bool? verbose = null, TCLObjectList objects = null)
		{
			// TCL Syntax: set_switching_activity [-toggle_rate <arg>] [-default_toggle_rate <arg>] [-type <args>] [-all] [-static_probability <arg>] [-default_static_probability <arg>] [-signal_rate <arg>] [-hier] [-deassert_resets] [-quiet] [-verbose] [<objects>...]
			_tcl.Entry(_builder.set_switching_activity(toggle_rate, default_toggle_rate, type, all, static_probability, default_static_probability, signal_rate, hier, deassert_resets, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set system jitter<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_system_jitter [-quiet] [-verbose] &lt;system_jitter&gt;
		/// <br/>
		/// <para>
		/// Sets the system jitter specified in nanoseconds (ns) for all clocks in the design, including primary<br/>
		/// and generated clocks. System jitter is used to account for excessive noise that affects all the<br/>
		/// clocks within the FPGA, like power supply noise and board noise. The default system jitter is<br/>
		/// technology-dependent and is predefined for each Xilinx FPGA family based on device<br/>
		/// characterization with several power supplies under all supported operating conditions.<br/>
		/// System Jitter is a component of the Total System Jitter (Tsj) used in the calculation of clock<br/>
		/// uncertainty for a path. It is due to the maximum noise (in time) that can be seen on the Vccint rail<br/>
		/// due to simultaneous switching of internal nodes, cross talk and other phenomenon that can<br/>
		/// impact timing on any path in the design.<br/>
		/// IMPORTANT! The jitter calculated by Xilinx takes into consideration the uncertainty introduced by the<br/>
		/// clocking resources, the input jitter and the system jitter. Using the set_system_jitter command<br/>
		/// overrides the default system jitter value calculated by Xilinx, and is not recommended.<br/>
		/// The System Jitter and the Input Jitter are random jitters which typically follow a Gaussian<br/>
		/// distribution and are added in a quadratic manner to represent the worst case combination. When<br/>
		/// the Input Jitter is null, the Total System Jitter (Tsj) for an internal register-to-register path has the<br/>
		/// following equation:<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • Tsj = √(SourceClockSystemJitter2<br/>
		/// + DestinationClockSystemJitter2<br/>
		/// )<br/>
		/// For example, when using the default value for system jitter of 50ps:<br/>
		/// • Tsj = √(0.0502<br/>
		/// + 0.0502<br/>
		/// ) = 0.071ns = 71ps<br/>
		/// The set_system_jitter command applies to all the clocks in the design. Use the<br/>
		/// set_input_jitter command to specify additional jitter for a specific primary clock.<br/>
		/// TIP: SYSTEM_JITTER is reported as a property of clocks, although it applies to all clocks in the design.<br/>
		/// INPUT_JITTER is also a property of primary clocks. These properties can be returned by the<br/>
		/// get_property or report_property commands.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example defines the primary clock, sysClk, and specifies a system wide jitter of 0.1 ns:<br/>
		/// create_clock -period 10 -name sysClk [get_ports sysClk]<br/>
		/// set_system_jitter 0.1<br/>
		/// The following example defines a primary clock, sysClk, and a generated clock, sysClkDiv2, that is<br/>
		/// a divide by two version of the primary clock. A system jitter of 0.2 ns is specified that applies to<br/>
		/// all the clocks in the design. An additional input jitter of 0.09 ns is specified on only the primary<br/>
		/// clock:<br/>
		/// create_clock -period 10 -name sysClk [get_ports sysClk]<br/>
		/// create_generated_clock -name sysClkDiv2 -source [get_ports sysClk] \<br/>
		/// -divide_by 2 [get_pins clkgen/sysClkDiv/Q]<br/>
		/// set_system_jitter 0.2<br/>
		/// set_input_jitter sysClk 0.09<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The follow example defines two primary clocks, sysClk and procClk. A system jitter of 0.2 ns is<br/>
		/// defined for all the clocks in the system. An additional input jitter of 0.05 ns is specified for the<br/>
		/// clock procClk:<br/>
		/// create_clock -period 10 -name sysClk [get_ports sysClk]<br/>
		/// create_clock -period 25 -name procClk [get_ports procClk]<br/>
		/// set_system_jitter 0.2<br/>
		/// set_input_jitter procClk 0.05<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1693<br/>
		/// </para>
		/// </summary>
		/// <param name="system_jitter">(Required) System jitter: Value &gt;= 0</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>system_jitter</returns>
		public TTCL set_system_jitter(TCLObject system_jitter, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_system_jitter [-quiet] [-verbose] <system_jitter>
			_tcl.Entry(_builder.set_system_jitter(system_jitter, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set units for checking<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_units [-capacitance &lt;arg&gt;] [-current &lt;arg&gt;] [-voltage &lt;arg&gt;] [-power &lt;arg&gt;] [-resistance &lt;arg&gt;] [-altitude &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This command specifies the default units to be assumed when the design is analyzed. Specifically,<br/>
		/// the -current, -voltage, -power, and -resistance options impact the values returned by<br/>
		/// the report_power command.<br/>
		/// The set_units command can be used multiple times to define and redefine units. If<br/>
		/// set_units includes a previously set unit value, the unit is redefined.<br/>
		/// Note: This command operates silently and does not return direct feedback of its operation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// Specify that voltage should be in millivolts and all values should use three digits<br/>
		/// set_units -voltage mV<br/>
		/// The following example changes the default unit for current to Amperes:<br/>
		/// set_units -voltage kV -current A<br/>
		/// Note: The second example of set_units redefines the Voltage units defined in the first example, as well<br/>
		/// as defining the units for current.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1696<br/>
		/// </para>
		/// </summary>
		/// <param name="capacitance">(Optional) Capacitance unit in farad. Valid values are from kF-fF. Default: pF</param>
		/// <param name="current">(Optional) Current unit in ampere. Valid values are from kA-fA. Default: mA</param>
		/// <param name="voltage">(Optional) Voltage unit in volt. Valid values are from kV-fV. Default: V</param>
		/// <param name="power">(Optional) Wattage unit in watts. Valid values are from kW-fW. Default: mW</param>
		/// <param name="resistance">(Optional) Resistance unit in ohm. Valid values are from kOhm-fOhm. Default: ohm</param>
		/// <param name="altitude">
		/// <para>
		/// (Optional)<br/>
		/// Altitude in metric or standard units. Valid values are meters<br/>
		/// and feet. Default: meters<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_units(String capacitance = null, String current = null, String voltage = null, String power = null, String resistance = null, String altitude = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_units [-capacitance <arg>] [-current <arg>] [-voltage <arg>] [-power <arg>] [-resistance <arg>] [-altitude <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.set_units(capacitance, current, voltage, power, resistance, altitude, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Update a macro<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: update_macro [-absolute_grid] [-quiet] [-verbose] &lt;macro&gt; &lt;rlocs&gt;
		/// <br/>
		/// <para>
		/// Populate a previously created macro with leaf cells and relative placements.<br/>
		/// A macro is made up of primitive, or leaf-level logic cells, and their associated connections,<br/>
		/// positioned in a placement grid. The specified relative locations, or &lt;rlocs&gt;, can be based on a<br/>
		/// relative grid, or on an absolute grid, called an RPM_GRID. Refer to the Vivado Design Suite User<br/>
		/// Guide: Implementation (UG904) for more information on absolute and relative placement grids<br/>
		/// A cell can only belong to a one macro. If you attempt to assign a leaf-level cell to multiple macros,<br/>
		/// the Vivado tool will return an error. If you attempt to assign a non-primitive cell to a macro, the<br/>
		/// tool will return an error.<br/>
		/// To change the contents of an existing macro, you must delete the macro with delete_macro,<br/>
		/// recreate it with create_macro, and update it with new contents. You cannot simply overwrite<br/>
		/// or modify an existing macro.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a macro named usbMacro0, sets the current instance to the<br/>
		/// usbEngine0/u0 module, assigns three cells to the macro, with a relative placement for each cell<br/>
		/// to have two of them placed inside the same Slice, and the third placed in a vertically adjacent<br/>
		/// Slice:<br/>
		/// create_macro usbMacro0<br/>
		/// current_instance usbEngine0/u0<br/>
		/// update_macro usbMacro0 {rx_active_reg X0Y0 \<br/>
		/// rx_err_reg X0Y0 rx_valid_reg X0Y1}<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example creates a macro named usbMacro1, assigns three cells to the macro using<br/>
		/// the hierarchical path to the leaf-cell, with absolute coordinates specified for the cells in the<br/>
		/// macro:<br/>
		/// create_macro usbMacro1<br/>
		/// set Site1 [get_sites SLICE_X8Y77]<br/>
		/// set Site2 [get_sites SLICE_X9Y77]<br/>
		/// set Site3 [get_sites SLICE_X8Y78]<br/>
		/// set RPM1 X[get_property RPM_X $Site1]Y[get_property RPM_Y $Site1]<br/>
		/// set RPM2 X[get_property RPM_X $Site2]Y[get_property RPM_Y $Site2]<br/>
		/// set RPM3 X[get_property RPM_X $Site3]Y[get_property RPM_Y $Site3]<br/>
		/// update_macro usbMacro1 -absolute_grid "usbEngine1/u0/rx_active_reg $RPM1 \<br/>
		/// usbEngine1/u0/rx_err_reg $RPM2 usbEngine1/u0/rx_valid_reg $RPM3"<br/>
		/// Note: In the prior example, notice the use of Tcl variables to capture the Sites of interest, and extract the<br/>
		/// RPM_X and RPM_Y properties of those sites for use in the update_macro command. Also notice the use<br/>
		/// of quotes ("") instead of curly braces ({}) in the update_macro command. This is to allow the Tcl shell to<br/>
		/// perform variable substitution of the command. Refer to the Vivado Design Suite User Guide: Using Tcl<br/>
		/// Scripting (UG894) for more information on variables and variable substitution.<br/>
		/// This command reports the properties on the usbMacro1 macro to see the absolute grid<br/>
		/// coordinates assigned to the cells in the macro:<br/>
		/// report_property -all [get_macros usbMacro1]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1776<br/>
		/// </para>
		/// </summary>
		/// <param name="macro">(Required) Macro to update</param>
		/// <param name="rlocs">(Required) a list interleaved instances and site names</param>
		/// <param name="absolute_grid">(Optional) Use absolute grid for relative locations</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL update_macro(TCLObject macro, TCLObject rlocs, bool? absolute_grid = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: update_macro [-absolute_grid] [-quiet] [-verbose] <macro> <rlocs>
			_tcl.Entry(_builder.update_macro(macro, rlocs, absolute_grid, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
