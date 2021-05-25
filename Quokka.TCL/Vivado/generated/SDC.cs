#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class SDCCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public SDCCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
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
		public TTCL create_clock(String period, String name = null, TCLParameterList waveform = null, bool? add = null, bool? quiet = null, bool? verbose = null, String objects = null)
		{
			// TCL Syntax: create_clock -period <arg> [-name <arg>] [-waveform <args>] [-add] [-quiet] [-verbose] [<objects>]
			_tcl.Entry(_builder.create_clock(period, name, waveform, add, quiet, verbose, objects));
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
		public TTCL create_generated_clock(String objects, String name = null, TCLParameterList source = null, TCLParameterList edges = null, String divide_by = null, String multiply_by = null, bool? combinational = null, String duty_cycle = null, bool? invert = null, TCLParameterList edge_shift = null, bool? add = null, TCLParameterList master_clock = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_generated_clock [-name <arg>] [-source <args>] [-edges <args>] [-divide_by <arg>] [-multiply_by <arg>] [-combinational] [-duty_cycle <arg>] [-invert] [-edge_shift <args>] [-add] [-master_clock <args>] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.create_generated_clock(objects, name, source, edges, divide_by, multiply_by, combinational, duty_cycle, invert, edge_shift, add, master_clock, quiet, verbose));
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
		public TTCL current_design(bool? quiet = null, bool? verbose = null, String design = null)
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
		public TTCL current_instance(bool? quiet = null, bool? verbose = null, String instance = null)
		{
			// TCL Syntax: current_instance [-quiet] [-verbose] [<instance>]
			_tcl.Entry(_builder.current_instance(quiet, verbose, instance));
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
		public TTCL get_cells(String hsc = null, bool? hierarchical = null, bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, get_cells_match_style? match_style = null, bool? include_replicated_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
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
		public TTCL get_clocks(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, String match_style = null, bool? include_generated_clocks = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_clocks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-include_generated_clocks] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_clocks(regexp, nocase, filter, of_objects, match_style, include_generated_clocks, quiet, verbose, patterns));
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
		public TTCL get_nets(String hsc = null, bool? hierarchical = null, bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, String match_style = null, bool? top_net_of_hierarchical_group = null, bool? segments = null, String boundary_type = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_nets [-hsc <arg>] [-hierarchical] [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-top_net_of_hierarchical_group] [-segments] [-boundary_type <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_nets(hsc, hierarchical, regexp, nocase, filter, of_objects, match_style, top_net_of_hierarchical_group, segments, boundary_type, quiet, verbose, patterns));
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
		public TTCL get_pins(String hsc = null, bool? hierarchical = null, bool? regexp = null, bool? nocase = null, bool? leaf = null, String filter = null, TCLParameterList of_objects = null, String match_style = null, bool? include_replicated_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_pins [-hsc <arg>] [-hierarchical] [-regexp] [-nocase] [-leaf] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-include_replicated_objects] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pins(hsc, hierarchical, regexp, nocase, leaf, filter, of_objects, match_style, include_replicated_objects, quiet, verbose, patterns));
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
		public TTCL get_ports(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, String match_style = null, bool? scoped_to_current_instance = null, bool? no_traverse = null, bool? prop_thru_buffers = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_ports [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-scoped_to_current_instance] [-no_traverse] [-prop_thru_buffers] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_ports(regexp, nocase, filter, of_objects, match_style, scoped_to_current_instance, no_traverse, prop_thru_buffers, quiet, verbose, patterns));
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
		public TTCL set_case_analysis(set_case_analysis_value value, String objects, bool? quiet = null, bool? verbose = null)
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
		public TTCL set_clock_latency(String latency, String objects, TCLParameterList clock = null, bool? rise = null, bool? fall = null, bool? min = null, bool? max = null, bool? source = null, bool? late = null, bool? early = null, bool? quiet = null, bool? verbose = null)
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
		public TTCL set_clock_sense(String pins, bool? positive = null, bool? negative = null, bool? stop_propagation = null, TCLParameterList clocks = null, bool? quiet = null, bool? verbose = null)
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
		public TTCL set_clock_uncertainty(String uncertainty, bool? setup = null, bool? hold = null, TCLParameterList from = null, TCLParameterList rise_from = null, TCLParameterList fall_from = null, TCLParameterList to = null, TCLParameterList rise_to = null, TCLParameterList fall_to = null, bool? quiet = null, bool? verbose = null, String objects = null)
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
		public TTCL set_data_check(String value, TCLParameterList from = null, TCLParameterList to = null, TCLParameterList rise_from = null, TCLParameterList fall_from = null, TCLParameterList rise_to = null, TCLParameterList fall_to = null, bool? setup = null, bool? hold = null, TCLParameterList clock = null, bool? quiet = null, bool? verbose = null)
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
		public TTCL set_disable_timing(String objects, String from = null, String to = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_disable_timing [-from <arg>] [-to <arg>] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.set_disable_timing(objects, from, to, quiet, verbose));
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
		public TTCL set_hierarchy_separator(bool? quiet = null, bool? verbose = null, String separator = null)
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
		public TTCL set_input_delay(String delay, String objects, TCLParameterList clock = null, TCLParameterList reference_pin = null, bool? clock_fall = null, bool? rise = null, bool? fall = null, bool? max = null, bool? min = null, bool? add_delay = null, bool? network_latency_included = null, bool? source_latency_included = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_input_delay [-clock <args>] [-reference_pin <args>] [-clock_fall] [-rise] [-fall] [-max] [-min] [-add_delay] [-network_latency_included] [-source_latency_included] [-quiet] [-verbose] <delay> <objects>
			_tcl.Entry(_builder.set_input_delay(delay, objects, clock, reference_pin, clock_fall, rise, fall, max, min, add_delay, network_latency_included, source_latency_included, quiet, verbose));
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
		public TTCL set_load(String capacitance, String objects, bool? rise = null, bool? fall = null, bool? max = null, bool? min = null, bool? quiet = null, bool? verbose = null)
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
		public TTCL set_logic_dc(String objects, bool? quiet = null, bool? verbose = null)
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
		public TTCL set_logic_one(String objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_logic_one [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.set_logic_one(objects, quiet, verbose));
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
		public TTCL set_logic_zero(String objects, bool? quiet = null, bool? verbose = null)
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
		public TTCL set_max_delay(String delay, bool? rise = null, bool? fall = null, bool? reset_path = null, TCLParameterList from = null, TCLParameterList rise_from = null, TCLParameterList fall_from = null, TCLParameterList to = null, TCLParameterList rise_to = null, TCLParameterList fall_to = null, TCLParameterList through = null, TCLParameterList rise_through = null, TCLParameterList fall_through = null, bool? datapath_only = null, bool? quiet = null, bool? verbose = null)
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
		public TTCL set_max_time_borrow(String delay, String objects, bool? quiet = null, bool? verbose = null)
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
		public TTCL set_min_delay(String delay, bool? rise = null, bool? fall = null, bool? reset_path = null, TCLParameterList from = null, TCLParameterList rise_from = null, TCLParameterList fall_from = null, TCLParameterList to = null, TCLParameterList rise_to = null, TCLParameterList fall_to = null, TCLParameterList through = null, TCLParameterList rise_through = null, TCLParameterList fall_through = null, bool? quiet = null, bool? verbose = null)
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
		public TTCL set_multicycle_path(Int32 path_multiplier, bool? setup = null, bool? hold = null, bool? rise = null, bool? fall = null, bool? start = null, bool? end = null, bool? reset_path = null, TCLParameterList from = null, TCLParameterList rise_from = null, TCLParameterList fall_from = null, TCLParameterList to = null, TCLParameterList rise_to = null, TCLParameterList fall_to = null, TCLParameterList through = null, TCLParameterList rise_through = null, TCLParameterList fall_through = null, bool? quiet = null, bool? verbose = null)
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
		public TTCL set_output_delay(String delay, String objects, TCLParameterList clock = null, TCLParameterList reference_pin = null, bool? clock_fall = null, bool? rise = null, bool? fall = null, bool? max = null, bool? min = null, bool? add_delay = null, bool? network_latency_included = null, bool? source_latency_included = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_output_delay [-clock <args>] [-reference_pin <args>] [-clock_fall] [-rise] [-fall] [-max] [-min] [-add_delay] [-network_latency_included] [-source_latency_included] [-quiet] [-verbose] <delay> <objects>
			_tcl.Entry(_builder.set_output_delay(delay, objects, clock, reference_pin, clock_fall, rise, fall, max, min, add_delay, network_latency_included, source_latency_included, quiet, verbose));
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
		public TTCL set_propagated_clock(String objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_propagated_clock [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.set_propagated_clock(objects, quiet, verbose));
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
	}
}
#pragma warning restore IDE1006 // Naming Styles
