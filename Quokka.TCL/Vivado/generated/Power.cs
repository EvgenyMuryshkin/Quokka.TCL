#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class PowerCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public PowerCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// <para>
		/// Delete power results that were stored in memory under a given name.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_power_results -name &lt;arg&gt; [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Deletes the power analysis results for the specified results set.<br/>
		/// Note: This command operates silently and does not return direct feedback of its operation<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example runs power analysis, and then clears the results:<br/>
		/// report_power -name my_set<br/>
		/// delete_power_results -name my_set<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 466<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name for the set of results to clear</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_power_results(String name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_power_results -name <arg> [-quiet] [-verbose]
			_tcl.Entry(_builder.delete_power_results(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Optimize dynamic power using intelligent clock gating<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: power_opt_design [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Optimizes the dynamic power consumption of the design by changing clock gating to take<br/>
		/// advantage of clock enable on a flop. Clock gating optimizations are automatically performed on<br/>
		/// the entire design to improve power consumption while making no changes to the existing logic<br/>
		/// or the clocks that would alter the behavior of the design.<br/>
		/// You can configure the power optimization to include or exclude specific cells using the<br/>
		/// set_power_opt command.<br/>
		/// Note: Block RAM power optimizations are performed by default with the opt_design command. You can<br/>
		/// disable BRAM optimization by changing the defaults of opt_design, or by excluding specific cells from<br/>
		/// optimization using the set_power_opt command.<br/>
		/// You can also use the read_saif command prior to optimization, and power_opt_design will<br/>
		/// consider the activity data while optimizing the design.<br/>
		/// You can run power optimization after synthesis, or after placement. When run before placement,<br/>
		/// this command optimizes the design to save power. When run after placement, this command<br/>
		/// optimizes the design to save power while preserving timing. Running after placement limits the<br/>
		/// optimizations available to the power_opt_design command. To achieve the best results, the<br/>
		/// command should be run prior to placement.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example performs power optimization of the open design:<br/>
		/// power_opt_design<br/>
		/// This example optimizes the design, excluding the BRAM power optimization by specifying the<br/>
		/// optimizations to run, and then runs power optimization on the design:<br/>
		/// opt_design -retarget -propconst -sweep<br/>
		/// power_opt_design<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1134<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL power_opt_design(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: power_opt_design [-quiet] [-verbose]
			_tcl.Entry(_builder.power_opt_design(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Import simulation data in saif format<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_saif [-strip_path &lt;arg&gt;] [-no_strip] [-out_file &lt;arg&gt;] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Reads a Switching Activity Interchange Format (SAIF) file for use during power analysis by the<br/>
		/// report_power command, or power optimization by power_opt_design. The read_saif<br/>
		/// command will annotate the design nodes with activity from the SAIF file and estimate power<br/>
		/// appropriately.<br/>
		/// Running report_power or power_opt_design after reading the SAIF file will use the activity<br/>
		/// rates from the specified file during optimization and analysis.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example:<br/>
		/// read_saif -strip_path design/top/F1 C:/Data/design1.saif<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1176<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Specifies the name of the SAIF file to be read</param>
		/// <param name="strip_path">
		/// <para>
		/// (Optional)<br/>
		/// Specifies the name of the instance of the current design as<br/>
		/// it appears in the SAIF file<br/>
		/// </para>
		/// </param>
		/// <param name="no_strip">(Optional) Do not strip first two levels of hierarchy from SAIF file</param>
		/// <param name="out_file">
		/// <para>
		/// (Optional)<br/>
		/// Specifies the name of the output file that contains nets that<br/>
		/// could not be matched<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL read_saif(String file, String strip_path = null, bool? no_strip = null, String out_file = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_saif [-strip_path <arg>] [-no_strip] [-out_file <arg>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.read_saif(file, strip_path, no_strip, out_file, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Run power estimation and display report<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_power [-no_propagation] [-hier &lt;arg&gt;] [-hierarchical_depth &lt;arg&gt;] [-vid] [-advisory] [-file &lt;arg&gt;] [-name &lt;arg&gt;] [-format &lt;arg&gt;] [-xpe &lt;arg&gt;] [-l &lt;arg&gt;] [-return_string] [-append] [-rpx &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Run power analysis on the current design, and report details of power consumption based on the<br/>
		/// current operating conditions of the device, and the switching rates of the design. The operating<br/>
		/// conditions can be set using the set_operating_conditions command. The switching<br/>
		/// activity can be defined using the set_switching_activity command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Switching activity can also be read in from an SAIF file with the read_saif command. The<br/>
		/// Vivado tool will annotate the design nodes with activity from the SAIF file and estimate power<br/>
		/// appropriately.<br/>
		/// Power analysis requires an open synthesized design, or implemented design.<br/>
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be<br/>
		/// written to a file or returned as a string if desired.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example performs power analysis, without net propagation, and writes the results<br/>
		/// to an XML file for use in XPE:<br/>
		/// report_power -no_propagation -xpe C:/Data/design1.xpe<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1406<br/>
		/// </para>
		/// </summary>
		/// <param name="no_propagation">
		/// <para>
		/// (Optional)<br/>
		/// Disables the propagation engine to estimate the switching<br/>
		/// activity of nets.<br/>
		/// </para>
		/// </param>
		/// <param name="hier">(Optional) Hierarchy report style (logic, power, or all) Default: power</param>
		/// <param name="hierarchical_depth">(Optional) Specifies the depth level for textual hierarchical report Default: 4</param>
		/// <param name="vid">(Optional) Voltage ID (VID) of device is used</param>
		/// <param name="advisory">(Optional) Dump power advisory text report</param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="format">(Optional) Format for the power estimation report: text, xml Default: text</param>
		/// <param name="xpe">(Optional) Output the results to XML file for importing into XPE</param>
		/// <param name="l">
		/// <para>
		/// (Optional)<br/>
		/// Maximum number of lines to report in detailed reports (l &gt;=<br/>
		/// 0) Default: 10<br/>
		/// </para>
		/// </param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="append">(Optional) append power report to end of file</param>
		/// <param name="rpx">(Optional) Filename to output interactive results to.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_power(bool? no_propagation = null, String hier = null, String hierarchical_depth = null, bool? vid = null, bool? advisory = null, String file = null, String name = null, String format = null, String xpe = null, Int32? l = null, bool? return_string = null, bool? append = null, String rpx = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_power [-no_propagation] [-hier <arg>] [-hierarchical_depth <arg>] [-vid] [-advisory] [-file <arg>] [-name <arg>] [-format <arg>] [-xpe <arg>] [-l <arg>] [-return_string] [-append] [-rpx <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_power(no_propagation, hier, hierarchical_depth, vid, advisory, file, name, format, xpe, l, return_string, append, rpx, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report power optimizations<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_power_opt [-cell &lt;args&gt;] [-file &lt;arg&gt;] [-format &lt;arg&gt;] [-name &lt;arg&gt;] [-append] [-return_string] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Report power optimizations that have been performed on the design with the<br/>
		/// power_opt_design command.<br/>
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be<br/>
		/// written to a file or returned as a string if desired.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the power optimizations performed on the current design, writing<br/>
		/// them to the specified file in an XML format:<br/>
		/// report_power_opt -format xml -file C:/Data/power_opt.xml<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1410<br/>
		/// </para>
		/// </summary>
		/// <param name="cell">(Optional) list of instance names Default: empty</param>
		/// <param name="file">(Optional) output file</param>
		/// <param name="format">
		/// <para>
		/// (Optional)<br/>
		/// Specifies how to format the report. Default is 'text', another<br/>
		/// option is 'xml'. Only applies if -file is used. If xml output is<br/>
		/// used, -append is not allowed. Default: text<br/>
		/// </para>
		/// </param>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="append">(Optional) append if existing file. Otherwise overwrite existing file.</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_power_opt(TCLParameterList cell = null, String file = null, String format = null, String name = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_power_opt [-cell <args>] [-file <arg>] [-format <arg>] [-name <arg>] [-append] [-return_string] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_power_opt(cell, file, format, name, append, return_string, quiet, verbose));
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
		public TTCL reset_switching_activity(bool? @default = null, TCLParameterList type = null, bool? hier = null, bool? all = null, bool? no_deassert_resets = null, bool? quiet = null, bool? verbose = null, TCLParameterList objects = null)
		{
			// TCL Syntax: reset_switching_activity [-default] [-type <args>] [-hier] [-all] [-no_deassert_resets] [-quiet] [-verbose] [<objects>...]
			_tcl.Entry(_builder.reset_switching_activity(@default, type, hier, all, no_deassert_resets, quiet, verbose, objects));
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
		public TTCL set_switching_activity(String toggle_rate = null, String default_toggle_rate = null, TCLParameterList type = null, bool? all = null, String static_probability = null, String default_static_probability = null, Int32? signal_rate = null, bool? hier = null, bool? deassert_resets = null, bool? quiet = null, bool? verbose = null, TCLParameterList objects = null)
		{
			// TCL Syntax: set_switching_activity [-toggle_rate <arg>] [-default_toggle_rate <arg>] [-type <args>] [-all] [-static_probability <arg>] [-default_static_probability <arg>] [-signal_rate <arg>] [-hier] [-deassert_resets] [-quiet] [-verbose] [<objects>...]
			_tcl.Entry(_builder.set_switching_activity(toggle_rate, default_toggle_rate, type, all, static_probability, default_static_probability, signal_rate, hier, deassert_resets, quiet, verbose, objects));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
