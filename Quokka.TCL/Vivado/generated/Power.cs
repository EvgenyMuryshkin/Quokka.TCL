// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class PowerCommands
	{
		private readonly QuokkaTCL _tcl;
		public PowerCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Delete power results that were stored in memory under a given name.
		///
		/// Deletes the power analysis results for the specified results set.
		/// Note: This command operates silently and does not return direct feedback of its operation
		///
		/// The following example runs power analysis, and then clears the results:
		/// report_power -name my_set
		/// delete_power_results -name my_set
		///
		/// See ug835-vivado-tcl-commands.pdf, page 454
		/// </summary>
		/// <param name="name">
		/// Required
		/// Name for the set of results to clear
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void delete_power_results(string name, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("delete_power_results");
			_tcl.Add(command);
		}
		/// <summary>
		/// Optimize dynamic power using intelligent clock gating
		///
		/// Optimizes the dynamic power consumption of the design by changing clock gating to take
		/// advantage of clock enable on a flop. Clock gating optimizations are automatically performed on
		/// the entire design to improve power consumption while making no changes to the existing logic
		/// or the clocks that would alter the behavior of the design.
		/// You can configure the power optimization to include or exclude specific cells using the
		/// set_power_opt command.
		/// Note: Block RAM power optimizations are performed by default with the opt_design command. You can
		/// disable BRAM optimization by changing the defaults of opt_design, or by excluding specific cells from
		/// optimization using the set_power_opt command.
		/// You can also use the read_saif command prior to optimization, and power_opt_design will
		/// consider the activity data while optimizing the design.
		/// You can run power optimization after synthesis, or after placement. When run before placement,
		/// this command optimizes the design to save power. When run after placement, this command
		/// optimizes the design to save power while preserving timing. Running after placement limits the
		/// optimizations available to the power_opt_design command. To achieve the best results, the
		/// command should be run prior to placement.
		///
		/// The following example performs power optimization of the open design:
		/// power_opt_design
		/// This example optimizes the design, excluding the BRAM power optimization by specifying the
		/// optimizations to run, and then runs power optimization on the design:
		/// opt_design -retarget -propconst -sweep
		/// power_opt_design
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1113
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void power_opt_design(bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("power_opt_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Import simulation data in saif format
		///
		/// Reads a Switching Activity Interchange Format (SAIF) file for use during power analysis by the
		/// report_power command, or power optimization by power_opt_design. The read_saif
		/// command will annotate the design nodes with activity from the SAIF file and estimate power
		/// appropriately.
		/// Running report_power or power_opt_design after reading the SAIF file will use the activity
		/// rates from the specified file during optimization and analysis.
		///
		/// The following example:
		/// read_saif -strip_path design/top/F1 C:/Data/design1.saif
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1155
		/// </summary>
		/// <param name="file">
		/// Required
		/// Specifies the name of the SAIF file to be read
		/// </param>
		/// <param name="strip_path">
		/// Optional
		/// Specifies the name of the instance of the current design as
		/// it appears in the SAIF file
		/// </param>
		/// <param name="no_strip">
		/// Optional
		/// Do not strip first two levels of hierarchy from SAIF file
		/// </param>
		/// <param name="out_file">
		/// Optional
		/// Specifies the name of the output file that contains nets that
		/// could not be matched
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void read_saif(string file, string strip_path = null, bool? no_strip = null, string out_file = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("read_saif");
			_tcl.Add(command);
		}
		/// <summary>
		/// Run power estimation and display report
		///
		/// Run power analysis on the current design, and report details of power consumption based on the
		/// current operating conditions of the device, and the switching rates of the design. The operating
		/// conditions can be set using the set_operating_conditions command. The switching
		/// activity can be defined using the set_switching_activity command.
		/// Switching activity can also be read in from an SAIF file with the read_saif command. The
		/// Vivado tool will annotate the design nodes with activity from the SAIF file and estimate power
		/// appropriately.
		/// Power analysis requires an open synthesized design, or implemented design.
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be
		/// written to a file or returned as a string if desired.
		///
		/// The following example performs power analysis, without net propagation, and writes the results
		/// to an XML file for use in XPE:
		/// report_power -no_propagation -xpe C:/Data/design1.xpe
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1375
		/// </summary>
		/// <param name="no_propagation">
		/// Optional
		/// Disables the propagation engine to estimate the switching
		/// activity of nets.
		/// </param>
		/// <param name="hier">
		/// Optional
		/// Hierarchy report style (logic, power, or all) Default: power
		/// </param>
		/// <param name="hierarchical_depth">
		/// Optional
		/// Specifies the depth level for textual hierarchical report
		/// Default: 4
		/// </param>
		/// <param name="vid">
		/// Optional
		/// Voltage ID (VID) of device is used
		/// </param>
		/// <param name="advisory">
		/// Optional
		/// Dump power advisory text report
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name
		/// </param>
		/// <param name="format">
		/// Optional
		/// Format for the power estimation report: text, xml Default:
		/// text
		/// </param>
		/// <param name="xpe">
		/// Optional
		/// Output the results to XML file for importing into XPE
		/// </param>
		/// <param name="l">
		/// Optional
		/// Maximum number of lines to report in detailed reports (l >=
		/// 0) Default: 10
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// return report as string
		/// </param>
		/// <param name="append">
		/// Optional
		/// append power report to end of file
		/// </param>
		/// <param name="rpx">
		/// Optional
		/// Filename to output interactive results to.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void report_power(bool? no_propagation = null, string hier = null, string hierarchical_depth = null, bool? vid = null, bool? advisory = null, string file = null, string name = null, string format = null, string xpe = null, string l = null, bool? return_string = null, bool? append = null, string rpx = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_power");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report power optimizations
		///
		/// Report power optimizations that have been performed on the design with the
		/// power_opt_design command.
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be
		/// written to a file or returned as a string if desired.
		///
		/// The following example reports the power optimizations performed on the current design, writing
		/// them to the specified file in an XML format:
		/// report_power_opt -format xml -file C:/Data/power_opt.xml
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1379
		/// </summary>
		/// <param name="cell">
		/// Required
		/// list of instance names Default: empty
		/// </param>
		/// <param name="file">
		/// Optional
		/// output file
		/// </param>
		/// <param name="format">
		/// Optional
		/// Specifies how to format the report. Default is 'text', another
		/// option is 'xml'. Only applies if -file is used. If xml output is
		/// used, -append is not allowed. Default: text
		/// </param>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name
		/// </param>
		/// <param name="append">
		/// Optional
		/// append if existing file. Otherwise overwrite existing file.
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// return report as string
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void report_power_opt(string cell, string file = null, string format = null, string name = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_power_opt");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reset operating conditions to tool default for power estimation
		///
		/// Resets the specified operating conditions to their default values. If no operating conditions are
		/// specified, all operating conditions are reset to their default values.
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
		/// See ug835-vivado-tcl-commands.pdf, page 1471
		/// </summary>
		/// <param name="voltage">
		/// Required
		/// Resets voltage value. Supported voltage supplies vary by
		/// family.
		/// </param>
		/// <param name="grade">
		/// Optional
		/// Resets temperature grade
		/// </param>
		/// <param name="process">
		/// Optional
		/// Resets process
		/// </param>
		/// <param name="junction_temp">
		/// Optional
		/// Resets Junction Temperature
		/// </param>
		/// <param name="ambient_temp">
		/// Optional
		/// Resets Ambient Temperature
		/// </param>
		/// <param name="thetaja">
		/// Optional
		/// Resets ThetaJA
		/// </param>
		/// <param name="thetasa">
		/// Optional
		/// Resets ThetaSA
		/// </param>
		/// <param name="airflow">
		/// Optional
		/// Resets Airflow
		/// </param>
		/// <param name="heatsink">
		/// Optional
		/// Resets dimensions of heatsink
		/// </param>
		/// <param name="thetajb">
		/// Optional
		/// Resets ThetaJB
		/// </param>
		/// <param name="board">
		/// Optional
		/// Resets Board type
		/// </param>
		/// <param name="board_temp">
		/// Optional
		/// Resets Board Temperature
		/// </param>
		/// <param name="board_layers">
		/// Optional
		/// Resets Board layers
		/// </param>
		/// <param name="design_power_budget">
		/// Optional
		/// Design Power Budget (W)
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void reset_operating_conditions(string voltage, bool? grade = null, bool? process = null, bool? junction_temp = null, bool? ambient_temp = null, bool? thetaja = null, bool? thetasa = null, bool? airflow = null, bool? heatsink = null, bool? thetajb = null, bool? board = null, bool? board_temp = null, bool? board_layers = null, bool? design_power_budget = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("reset_operating_conditions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reset switching activity on specified objects
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
		///
		/// The following example resets the signal_rate and static probability value on all output ports:
		/// reset_switching_activity -default [all_outputs]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1485
		/// </summary>
		/// <param name="type">
		/// Required
		/// Specify nodes in a specific category. List of valid type values:
		/// io_output, io_bidir_enable, register, lut_ram, lut, dsp,
		/// bram_enable, bram_wr_enable, gt_txdata, gt_rxdata.
		/// </param>
		/// <param name="default">
		/// Optional
		/// Reset default static probability and default toggle rate
		/// </param>
		/// <param name="hier">
		/// Optional
		/// Hierarchically resets the switching activity on a hierarchical
		/// cells provided as <objects>.
		/// </param>
		/// <param name="all">
		/// Optional
		/// Reset switching activity on all nets
		/// </param>
		/// <param name="no_deassert_resets">
		/// Optional
		/// A switch to undo the deassertion of resets via command
		/// set_switching_activity -deassert_resets
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
		/// Objects to reset switching activity on
		/// </param>
		public void reset_switching_activity(string type, bool? default = null, bool? hier = null, bool? all = null, bool? no_deassert_resets = null, bool? quiet = null, bool? verbose = null, string objects = null)
		{
			var command = new SimpleTCLCommand("reset_switching_activity");
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
		/// Required
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
		public void set_operating_conditions(string voltage, string grade = null, string process = null, string junction_temp = null, string ambient_temp = null, string thetaja = null, string thetasa = null, string airflow = null, string heatsink = null, string thetajb = null, string board = null, string board_temp = null, string board_layers = null, string design_power_budget = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_operating_conditions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set constraints for power optimization
		///
		/// Specify cell instances to include or exclude in power optimization. The specified cells are
		/// optimized using the power_opt_design command.
		/// TIP: Block RAM optimizations are performed by default with the opt_design command. Some or all BRAM
		/// cells can be excluded from the opt_design optimization using the set_power_opt command as well.
		/// The effect of multiple set_power_opt commands is cumulative, so that you can specify a
		/// broad class of cell types to optimize, include specific hierarchical cells, and then exclude cells
		/// within the included hierarchy to refine the power optimization.
		/// The power optimizations that have been performed can be reported using the
		/// report_power_opt command.
		///
		/// The following example sets power optimization for BRAM cells only, and then runs power
		/// optimization:
		/// set_power_opt -cell_types bram
		/// power_opt_design
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
		/// See ug835-vivado-tcl-commands.pdf, page 1644
		/// </summary>
		/// <param name="include_cells">
		/// Required
		/// Include only these instances for clock gating. Default: all
		/// </param>
		/// <param name="exclude_cells">
		/// Required
		/// Exclude these instances from clock gating. Default: none
		/// </param>
		/// <param name="clocks">
		/// Required
		/// Clock gate instances clocked by these clocks only. Default:
		/// all clocks
		/// </param>
		/// <param name="cell_types">
		/// Required
		/// Clock gate these cell types only. Specify either [all|none], or
		/// one or more of [bram|reg|srl]. Default: all
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_power_opt(string include_cells, string exclude_cells, string clocks, string cell_types, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_power_opt");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set switching activity on specified objects or default types
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
		/// This example sets the specified toggle rate and static probability on all registers in the hierarchy
		/// of "CPU/MEM":
		/// set_switching_activity -type register -toggle_rate 0.4 \
		/// -static_probability 0.5 [get_cells CPU/MEM]
		/// This example sets the specified toggle rate and static probability on all registers in the hierarchy
		/// of "CPU/" and underneath hierarchy:
		/// set_switching_activity -type register -toggle_rate 0.4
		/// -static_probability 0.5 -hier [get_cells CPU]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1655
		/// </summary>
		/// <param name="type">
		/// Required
		/// Specify nodes in a specific category. List of valid type values:
		/// io_output, io_bidir_enable, register, lut_ram, lut, dsp,
		/// bram_enable, bram_wr_enable, gt_txdata, gt_rxdata.
		/// </param>
		/// <param name="toggle_rate">
		/// Optional
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
		/// Optional
		/// The default toggle rate to be used in power analysis on the
		/// primary inputs of the design. The default toggle rate is set
		/// on those primary input nets whose switching activity is not
		/// specified by the user, simulation data or constraints of the
		/// design. Valid values are: 0 <= value < 200. The default value
		/// is 12.5. Default: 12.5
		/// </param>
		/// <param name="all">
		/// Optional
		/// Used together with -type, set switching activity on -type nets
		/// within an instance
		/// </param>
		/// <param name="static_probability">
		/// Optional
		/// Static probability value: 0 <= Value <= 1 Default: 0.5
		/// </param>
		/// <param name="default_static_probability">
		/// Optional
		/// The default static probability to be used in power analysis
		/// on the design. The default static probability is set on those
		/// primary inputs whose switching activity is not specified by
		/// the user, simulation data or constraints of the design. Valid
		/// values are: 0 <= Value <= 1. The default value is 0.5. Default:
		/// 0.5
		/// </param>
		/// <param name="signal_rate">
		/// Optional
		/// The number of times an element changed state (high-to-low
		/// and low-to-high) per second. Xilinx tools express this as
		/// millions of transitions per second (Mtr/s). Default: 0.0
		/// </param>
		/// <param name="hier">
		/// Optional
		/// Hierarchically sets the switching activity on a hierarchical
		/// instance provided via <objects> option. This option should
		/// be used only with <objects> option
		/// </param>
		/// <param name="deassert_resets">
		/// Optional
		/// A switch to elegantly auto deassert all set,reset,preset and
		/// clear signals that do not have conflicted polarities
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
		/// Objects to set switching activity on
		/// </param>
		public void set_switching_activity(string type, string toggle_rate = null, string default_toggle_rate = null, bool? all = null, string static_probability = null, string default_static_probability = null, string signal_rate = null, bool? hier = null, bool? deassert_resets = null, bool? quiet = null, bool? verbose = null, string objects = null)
		{
			var command = new SimpleTCLCommand("set_switching_activity");
			_tcl.Add(command);
		}
	}
}
