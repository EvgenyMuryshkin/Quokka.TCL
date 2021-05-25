#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class ReportCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public ReportCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// <para>
		/// Calculate device configuration time (ms)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: calc_config_time [-verbose] [-max] [-min] [-typical] [-por_used] [-por_ramp &lt;arg&gt;] [-clk_freq &lt;arg&gt;] [-bitstream_size &lt;arg&gt;] [-quiet]
		/// <br/>
		/// <para>
		/// Estimates the time in milliseconds (ms) to configure a Xilinx device for the current design.<br/>
		/// TIP: The Device Configuration Mode must be defined for this command to work.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Some applications require that the Xilinx device be configured and operational within a short<br/>
		/// time. This command lets you estimate the configuration time for the device and design in<br/>
		/// question. The configuration time includes the device initialization time plus the configuration<br/>
		/// time. Configuration time depends on the size of the device and speed of the configuration logic.<br/>
		/// For more information on the configuration time refer to UltraFast Design Methodology Guide for<br/>
		/// the Vivado Design Suite (UG949), the UltraScale Architecture Configuration User Guide (UG570), or<br/>
		/// the 7 Series FPGAs Configuration User Guide (UG470).<br/>
		/// Some of the settings needed to calculate the configuration time are stored as properties on the<br/>
		/// current design, such as the BITSTREAM.CONFIG.CONFIGRATE or<br/>
		/// BITSTREAM.CONFIG.EXTMASTERCCLK_EN properties. In some master modes, the FPGA<br/>
		/// provides the configuration clock to control configuration, with the nominal configuration clock<br/>
		/// frequency specified by BITSTREAM.CONFIG.CONFIGRATE. The property can be defined in the<br/>
		/// Edit Device Properties dialog box of the Vivado Design Suite IDE, or by using set_property to<br/>
		/// directly set the value of the specified property.<br/>
		/// For a slave configuration mode, or for configuration modes using an external master clock, the<br/>
		/// needed clock frequency is specified by the -clk_freq option.<br/>
		/// This command returns a value in milliseconds if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 121<br/>
		/// </para>
		/// </summary>
		/// <param name="verbose">(Optional) Print out calculation parameters</param>
		/// <param name="max">(Optional) Calculate Maximum Configuration Time</param>
		/// <param name="min">(Optional) Calculate Minimum Configuration Time</param>
		/// <param name="typical">(Optional) Calculate Typical Configuration Time</param>
		/// <param name="por_used">
		/// <para>
		/// (Optional)<br/>
		/// (Deprecated) Specify if Power On Reset (POR) is used by<br/>
		/// using a non-zero por_ramp<br/>
		/// </para>
		/// </param>
		/// <param name="por_ramp">
		/// <para>
		/// (Optional)<br/>
		/// Specify a Power On Reset (POR) ramp rate as 1 ms to 50 ms<br/>
		/// Default: 0 ms<br/>
		/// </para>
		/// </param>
		/// <param name="clk_freq">
		/// <para>
		/// (Optional)<br/>
		/// Specify a clock frequency for Slave mode, or for Master<br/>
		/// mode if using external master clock (MHz) Default: 0 MHz<br/>
		/// </para>
		/// </param>
		/// <param name="bitstream_size">(Optional) Specify a bitstream size to override the default Default: 0</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <returns>Report</returns>
		public TTCL calc_config_time(bool? verbose = null, bool? max = null, bool? min = null, bool? typical = null, bool? por_used = null, String por_ramp = null, String clk_freq = null, String bitstream_size = null, bool? quiet = null)
		{
			// TCL Syntax: calc_config_time [-verbose] [-max] [-min] [-typical] [-por_used] [-por_ramp <arg>] [-clk_freq <arg>] [-bitstream_size <arg>] [-quiet]
			_tcl.Entry(_builder.calc_config_time(verbose, max, min, typical, por_used, por_ramp, clk_freq, bitstream_size, quiet));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Check the design for possible timing problems<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: check_timing [-file &lt;arg&gt;] [-no_header] [-loop_limit &lt;arg&gt;] [-append] [-name &lt;arg&gt;] [-override_defaults &lt;args&gt;] [-include &lt;args&gt;] [-exclude &lt;args&gt;] [-return_string] [-rpx &lt;arg&gt;] [-cells &lt;args&gt;] [-verbose] [-quiet]
		/// <br/>
		/// <para>
		/// Checks the design elements of ports, pins, and paths, against the current timing constraints. Use<br/>
		/// this command to identify possible problems with design data and timing constraints before<br/>
		/// running the report_timing command. The check_timing command runs a series of default<br/>
		/// timing checks, and reports a summary of any violations found. To get detailed information about<br/>
		/// violations, use the -verbose option.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be<br/>
		/// written to the GUI with the -name option, or to a file with -file.<br/>
		/// Default Timing Checks:<br/>
		/// • constant_clock - Checks for clock signals connected to a constant signal (gnd/vss/data).<br/>
		/// • generated_clocks - Checks for loops, or circular definitions within the generated clock<br/>
		/// network. This check will return an error if a generated clock uses a second generated clock as<br/>
		/// its source, when the second generated clock uses the first clock as its source.<br/>
		/// • latch_loops - Checks for and warns of combinational latch loops in the design.<br/>
		/// • loops - Checks for and warns of combinational feedback loops in the design.<br/>
		/// • multiple_clock - Warns if multiple clocks reach a register clock pin. If more than one clock<br/>
		/// signal reaches a register clock pin it is unclear which clock will be used for analysis. In this<br/>
		/// case, use the set_case_analysis command so that only one clock will propagate to the<br/>
		/// register clock pin.<br/>
		/// • no_clock - Reports unclocked registers. In this case, no setup or hold checks are performed<br/>
		/// on data pins related to the register clock pin.<br/>
		/// • no_input_delay - Reports the input ports without an input delay constraint. Input delays<br/>
		/// can be assigned using the set_input_delay command. Input ports that are unclocked will<br/>
		/// not be checked for input delays.<br/>
		/// • no_output_delay - Reports the output ports without an output delay constraint. Output<br/>
		/// delays can be assigned using the set_output_delay command. Output ports that are<br/>
		/// unclocked will not be checked for output delays.<br/>
		/// • partial_input_delay - Reports the input ports having partially defined input delay<br/>
		/// constraints. Assigning set_input_delay -max or set_input_delay -min to an input<br/>
		/// port, without assigning the other, creates a partially defined input delay. In such cases, paths<br/>
		/// starting from the input port may become unconstrained and no timing checks will be done<br/>
		/// against the port. Assigning set_input_delay without specifying either -min or -max<br/>
		/// allows the tool to assume both min and max delays, and so does not result in a partial input<br/>
		/// delay.<br/>
		/// Note: Unclocked input ports are not checked for partial input delays.<br/>
		/// • partial_output_delay - Reports the output ports having partially defined output delay<br/>
		/// constraints. Assigning set_output_delay -max or set_output_delay -min to an<br/>
		/// output port, without assigning the other, creates a partially defined output delay. In such<br/>
		/// cases, paths reaching the port may become unconstrained and no timing checks will be done<br/>
		/// against the port. Assigning set_output_delay without specifying either -min or -max<br/>
		/// allows the tool to assume both min and max delays, and so does not result in a partial output<br/>
		/// delay.<br/>
		/// Note: Unclocked output ports are not checked for partial output delays.<br/>
		/// • pulse_width_clock - Reports clock pins that have only a pulse width check associated<br/>
		/// with the pin, and no setup or hold check, no recovery, removal, or clk-&gt;Q check.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • unconstrained_internal_endpoints - This warning identifies timing path endpoints at<br/>
		/// register data pins that are not constrained. Endpoints at register data pins are constrained by<br/>
		/// clock assignment using the create_clock command. Endpoints at output ports are checked<br/>
		/// and reported by the no_output_delay check.<br/>
		/// • unexpandable_clocks - Reports clock sets in which the period is not expandable with<br/>
		/// respect to each other, when there is at least 1 path between the clock sets. A clock is<br/>
		/// unexpandable if no common multiples are found within 1000 cycles between the source and<br/>
		/// destination clocks.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example runs check_timing, but excludes the specified checks from the default<br/>
		/// timing checks:<br/>
		/// check_timing -exclude {loops generated_clocks}<br/>
		/// The following example uses the -verbose argument to obtain detailed results running just the<br/>
		/// multiple_clocks check, and then uses get_clocks to look further into the issue:<br/>
		/// check_timing -verbose -override_defaults {multiple_clock}<br/>
		/// Checking multiple_clock.<br/>
		/// There are 2 register/latch pins with multiple clocks.<br/>
		/// procEngine/mode_du/set_reg[0]/C<br/>
		/// provEngine/mode_du/set_reg[1]/C<br/>
		/// get_clocks -of_objects [get_pin procEngine/mode_du/set_reg[0]/C]<br/>
		/// sysClk coreClk<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 128<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="no_header">(Optional) do not generate a report header</param>
		/// <param name="loop_limit">(Optional) Limit the number of loops reported for loops check Default: 100</param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="override_defaults">(Optional) Overrides the checks in the default timing checks listed below</param>
		/// <param name="include">
		/// <para>
		/// (Optional)<br/>
		/// Add this list of checks to be performed along with default<br/>
		/// timing checks listed below<br/>
		/// </para>
		/// </param>
		/// <param name="exclude">
		/// <para>
		/// (Optional)<br/>
		/// Exclude this list of checks to be performed from the default<br/>
		/// timing checks listed below<br/>
		/// </para>
		/// </param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="rpx">(Optional) Filename to output interactive results to.</param>
		/// <param name="cells">(Optional) run check_timing on the specified cell(s)</param>
		/// <param name="verbose">(Optional) Return a detailed list of all timing problems found</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		public TTCL check_timing(String file = null, bool? no_header = null, Int32? loop_limit = null, bool? append = null, String name = null, TCLParameterList override_defaults = null, TCLParameterList include = null, TCLParameterList exclude = null, bool? return_string = null, String rpx = null, TCLParameterList cells = null, bool? verbose = null, bool? quiet = null)
		{
			// TCL Syntax: check_timing [-file <arg>] [-no_header] [-loop_limit <arg>] [-append] [-name <arg>] [-override_defaults <args>] [-include <args>] [-exclude <args>] [-return_string] [-rpx <arg>] [-cells <args>] [-verbose] [-quiet]
			_tcl.Entry(_builder.check_timing(file, no_header, loop_limit, append, name, override_defaults, include, exclude, return_string, rpx, cells, verbose, quiet));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a DRC violation<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_drc_violation -name &lt;arg&gt; [-severity &lt;arg&gt;] [-msg &lt;arg&gt;] [-quiet] [-verbose] [&lt;objects&gt;...]
		/// <br/>
		/// <para>
		/// Create a DRC violation object and manage the list of design objects associated with the violation<br/>
		/// for reporting by the report_drc command.<br/>
		/// The create_drc_violation command is specified as part of the Tcl checker procedure that<br/>
		/// defines and implements the checking feature of a user-defined design rule check created by the<br/>
		/// create_drc_check command. A violation object is created by the Tcl checker each time a<br/>
		/// violation of the design rule is encountered.<br/>
		/// The process in brief is:<br/>
		/// • Write a Tcl checker procedure to define the method applied when checking the user-defined<br/>
		/// rule, and the objects to check against the rule. The Tcl checker procedure is defined in a<br/>
		/// separate Tcl script that must be loaded by the source command prior to running<br/>
		/// report_drc.<br/>
		/// • Use create_drc_violation in the Tcl checker to identify and flag violations found when<br/>
		/// checking the rule against a design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • Define a user-defined DRC rule check using the create_drc_check command that calls the<br/>
		/// Tcl checker proc from the -rule_body.<br/>
		/// • Create a rule deck using the create_drc_ruledeck command, and add the user-defined<br/>
		/// rule check to the rule deck using the add_drc_checks command.<br/>
		/// • Run report_drc, and specify either the rule deck, or the user-defined rule check to check<br/>
		/// for violations.<br/>
		/// Violations are reported by the report_drc command, and violation objects can be returned by<br/>
		/// the get_drc_violations command. The design objects associated with a DRC violation<br/>
		/// object can be obtained using the -of_objects option of the appropriate get_* command,<br/>
		/// such as get_cells, get_nets, or get_ports for instance:<br/>
		/// get_ports -of_objects [get_drc_violations -name drc_1 NSTD*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following Tcl script defines the dataWidthCheck procedure which is called by the -<br/>
		/// rule_body argument of the RAMW-1 check. This Tcl script file must be loaded into the tool<br/>
		/// using the source command, prior to running the report_drc command.<br/>
		/// Some features of the Tcl checker proc to notice are:<br/>
		/// • A list variable is created to store violations ($vios )<br/>
		/// • A violation object is created, and added to the list variable, each time a violation is found.<br/>
		/// • The placeholder key %ELG in the $msg string is dynamically substituted with the specific<br/>
		/// $bram cell associated with the violation.<br/>
		/// • The dataWidthCheck proc returns an error code when any violations are found ($vios &gt;0)<br/>
		/// to inform the report_drc command of the results of the check.<br/>
		/// • The list of violations is passed along with the return code, and the violations are reported by<br/>
		/// report_drc.<br/>
		/// # This is a simplistic check -- report BRAM cells with WRITE_WIDTH_B<br/>
		/// # wider than 36.<br/>
		/// proc dataWidthCheck {} {<br/>
		/// # list to hold violations<br/>
		/// set vios {}<br/>
		/// # iterate through the objects to be checked<br/>
		/// foreach bram [get_cells -hier -filter {PRIMITIVE_SUBGROUP == bram}] {<br/>
		/// set bwidth [get_property WRITE_WIDTH_B $bram]<br/>
		/// if { $bwidth &gt; 36} {<br/>
		/// # define the message to report when violations are found<br/>
		/// set msg "On cell %ELG, WRITE_WIDTH_B is $bwidth"<br/>
		/// set vio [ create_drc_violation -name {RAMW-1} -msg $msg $bram ]<br/>
		/// lappend vios $vio<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// }<br/>
		/// }<br/>
		/// if {[llength $vios] &gt; 0} {<br/>
		/// return -code error $vios<br/>
		/// } else {<br/>
		/// return {}<br/>
		/// }<br/>
		/// }<br/>
		/// create_drc_check -name {RAMW-1} -hiername {RAMB Checks} \<br/>
		/// -desc {Data Width Check} -rule_body dataWidthCheck \<br/>
		/// -severity Advisory<br/>
		/// Note: The script file can contain both the Tcl checker procedure, and the create_drc_check command<br/>
		/// that defines it for use by report_drc command. In this case, when the Tcl script file is sourced, both the<br/>
		/// dataWidthCheck proc and the RAMW-1 design rule check are loaded into the tool.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 268<br/>
		/// </para>
		/// </summary>
		/// <param name="name">
		/// <para>
		/// (Required)<br/>
		/// Specify the name for this rule. This is the typically a 4-6<br/>
		/// letter specification for your rule.<br/>
		/// </para>
		/// </param>
		/// <param name="severity">
		/// <para>
		/// (Optional)<br/>
		/// Specify severity level for a DRC rule. Default: WARNING.<br/>
		/// Values: FATAL, ERROR, CRITICAL WARNING, WARNING,<br/>
		/// ADVISORY.<br/>
		/// </para>
		/// </param>
		/// <param name="msg">(Optional) Specify your message string for this DRC rule.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">
		/// <para>
		/// (Optional)<br/>
		/// Cells, ports, pins, nets, clock regions, sites, package banks to<br/>
		/// query.<br/>
		/// </para>
		/// </param>
		public TTCL create_drc_violation(String name, create_drc_violation_severity? severity = null, String msg = null, bool? quiet = null, bool? verbose = null, TCLParameterList objects = null)
		{
			// TCL Syntax: create_drc_violation -name <arg> [-severity <arg>] [-msg <arg>] [-quiet] [-verbose] [<objects>...]
			_tcl.Entry(_builder.create_drc_violation(name, severity, msg, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create Configurable Report objects.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_report_config [-report_name &lt;arg&gt;] [-report_type &lt;arg&gt;] -steps &lt;args&gt; -runs &lt;args&gt; [-options &lt;arg&gt;] [-copy_of &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This command lets you create configurable report objects to add to synthesis and<br/>
		/// implementation runs, or to add to Report Strategies. A report object defines the report type and<br/>
		/// options that are run every time a specified step of a synthesis or implementation design run is<br/>
		/// completed. A Report Strategy lets you define a collection of report objects to associate with<br/>
		/// many synthesis and implementation runs, and reuse at different stages of the design flow. See<br/>
		/// the Vivado Design Suite User Guide: Implementation (UG904) for more information.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Each report object has the 'OPTIONS.MORE_OPTIONS' property, which lets you specify<br/>
		/// command line options of the Tcl report_* command associated with the report object. These<br/>
		/// command line options are used when the report is generated during the synthesis or<br/>
		/// implementation run. You can specify the command line options using the -options argument as<br/>
		/// described below, or by manually setting the 'OPTIONS.MORE_OPTIONS' property of an existing<br/>
		/// report object using the set_property command. Refer to the specific report_* command for<br/>
		/// information on the available command line options.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example defines a new report object with the specified name and type and<br/>
		/// associates it with the route_design step of the impl_1 run:<br/>
		/// create_report_config -report_name post_route_datasheet -report_type<br/>
		/// report_datasheet \<br/>
		/// -steps route_design -runs impl_1<br/>
		/// This example is the same as the prior example, except it does not specify the name, and so the<br/>
		/// report object is named automatically as shown in the return value:<br/>
		/// create_report_config -report_type report_datasheet -steps route_design -<br/>
		/// runs impl_1<br/>
		/// impl_1_route_report_datasheet_0<br/>
		/// The following example creates a new report object for the timing summary report, with the<br/>
		/// specified command-line options, and associates the object with multiple steps of an<br/>
		/// implementation run:<br/>
		/// create_report_config -report_type report_timing_summary \<br/>
		/// -steps {opt_design place_design route_design} -runs {impl_2}\<br/>
		/// -options {-no_detailed_paths -report_unconstrained}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 353<br/>
		/// </para>
		/// </summary>
		/// <param name="steps">(Required) List of run step(s) for object(s) created</param>
		/// <param name="runs">(Required) List of run(s) for object(s) created</param>
		/// <param name="report_name">
		/// <para>
		/// (Optional)<br/>
		/// Name of configurable report object created. Can not be<br/>
		/// used when creating multiple objects<br/>
		/// </para>
		/// </param>
		/// <param name="report_type">
		/// <para>
		/// (Optional)<br/>
		/// Type of configurable report object(s) created. Not required<br/>
		/// with '-copy_of'<br/>
		/// </para>
		/// </param>
		/// <param name="options">
		/// <para>
		/// (Optional)<br/>
		/// options for report command to be set at creation of<br/>
		/// configurable report object, except with '-copy_of'<br/>
		/// </para>
		/// </param>
		/// <param name="copy_of">(Optional) configurable report object to be copied</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>List of configurable report objects</returns>
		public TTCL create_report_config(TCLParameterList steps, TCLParameterList runs, String report_name = null, String report_type = null, String options = null, TCLParameterList copy_of = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_report_config [-report_name <arg>] [-report_type <arg>] -steps <args> -runs <args> [-options <arg>] [-copy_of <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_report_config(steps, runs, report_name, report_type, options, copy_of, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create histogram<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_slack_histogram [-to &lt;args&gt;] [-delay_type &lt;arg&gt;] [-num_bins &lt;arg&gt;] [-slack_less_than &lt;arg&gt;] [-slack_greater_than &lt;arg&gt;] [-group &lt;args&gt;] [-report_unconstrained] [-significant_digits &lt;arg&gt;] [-scale &lt;arg&gt;] [-name &lt;arg&gt;] [-cells &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Create a slack histogram grouping paths into slack ranges, and displaying the results graphically.<br/>
		/// TIP: This command provides a graphical slack histogram that requires the tool to be running in GUI mode.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a slack histogram of the current design, using the default values,<br/>
		/// and outputting the results to the named result set in the GUI:<br/>
		/// create_slack_histogram -name slack1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 362<br/>
		/// </para>
		/// </summary>
		/// <param name="to">(Optional) To clock</param>
		/// <param name="delay_type">(Optional) Type of path delay: Values: max, min, min_max Default: max</param>
		/// <param name="num_bins">(Optional) Maximum number of bins: Valid Range (1-100) Default: 10</param>
		/// <param name="slack_less_than">(Optional) Display paths with slack less than this Default: 1e+30</param>
		/// <param name="slack_greater_than">(Optional) Display paths with slack greater than this Default: -1e+30</param>
		/// <param name="group">(Optional) Limit report to paths in this group(s)</param>
		/// <param name="report_unconstrained">(Optional) Report unconstrained end points</param>
		/// <param name="significant_digits">(Optional) Number of digits to display: Range: 0 to 3 Default: 3</param>
		/// <param name="scale">
		/// <para>
		/// (Optional)<br/>
		/// Type of scale on which to draw the histogram; Values:<br/>
		/// linear, logarithmic Default: linear<br/>
		/// </para>
		/// </param>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="cells">(Optional) run create_slack_histogram on the specified cell(s)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_slack_histogram(TCLParameterList to = null, create_slack_histogram_delay_type? delay_type = null, Int32? num_bins = null, String slack_less_than = null, String slack_greater_than = null, TCLParameterList group = null, bool? report_unconstrained = null, Int32? significant_digits = null, create_slack_histogram_scale? scale = null, String name = null, TCLParameterList cells = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_slack_histogram [-to <args>] [-delay_type <arg>] [-num_bins <arg>] [-slack_less_than <arg>] [-slack_greater_than <arg>] [-group <args>] [-report_unconstrained] [-significant_digits <arg>] [-scale <arg>] [-name <arg>] [-cells <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_slack_histogram(to, delay_type, num_bins, slack_less_than, slack_greater_than, group, report_unconstrained, significant_digits, scale, name, cells, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Clear a set of clock networks results from memory<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_clock_networks_results [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Clear the results of the specified report_clock_networks report from the named result set.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example clears the specified results set from memory:<br/>
		/// delete_clock_network_results ClkNets<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 430<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name for the set of results to clear</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_clock_networks_results(String name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_clock_networks_results [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.delete_clock_networks_results(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Delete a set of existing configurable report objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_report_configs [-quiet] [-verbose] &lt;report_configs&gt;...
		/// <br/>
		/// <para>
		/// Removes specified report objects from the current project. The report objects are created by the<br/>
		/// create_report_config command.<br/>
		/// This command returns nothing if successful, or an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example deletes the specified report_config object:<br/>
		/// delete_report_configs [get_report_configs post_route_datasheet]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 474<br/>
		/// </para>
		/// </summary>
		/// <param name="report_configs">(Required) List of configurable report objects to delete</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_report_configs(TCLParameterList report_configs, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_report_configs [-quiet] [-verbose] <report_configs>...
			_tcl.Entry(_builder.delete_report_configs(report_configs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Clear a set of timing results from memory<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_timing_results [-type &lt;arg&gt;] [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Clear the specified timing results from the named result set. Both the type of the timing report,<br/>
		/// and the name of the timing report must be specified, or the command will fail.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example clears the specified results set from memory:<br/>
		/// delete_timing_results -type clock_interaction clkNets<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 480<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name for the set of results to clear</param>
		/// <param name="type">
		/// <para>
		/// (Optional)<br/>
		/// Type of timing results to clear; Values: bus_skew,<br/>
		/// check_timing, clock_interaction, clock_domain_crossings,<br/>
		/// config_timing, datasheet, pulse_width, slack_histogram,<br/>
		/// timing_path, timing_summary<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_timing_results(String name, delete_timing_results_type? type = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_timing_results [-type <arg>] [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.delete_timing_results(name, type, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Delete utilization results that were stored in memory under a given name.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_utilization_results -name &lt;arg&gt; [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Clear the specified utilization results from the named result set.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example clears the specified results set from memory:<br/>
		/// delete_utilization_results -name SSO1<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 482<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name for the set of results to clear</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_utilization_results(String name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_utilization_results -name <arg> [-quiet] [-verbose]
			_tcl.Entry(_builder.delete_utilization_results(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Generate a set of configurable report objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: generate_reports [-jobs &lt;arg&gt;] [-quiet] [-verbose] &lt;report_configs&gt;...
		/// <br/>
		/// <para>
		/// Generates specified report objects as created by the create_report_config command.<br/>
		/// Because the report objects are associated with specific steps of synthesis or implementation<br/>
		/// runs, those steps must be completed prior to the generation of the report. If a step is not<br/>
		/// completed, or the report is not enabled, then the generate_report command will return an<br/>
		/// error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example generates the specified report object:<br/>
		/// generate_report [get_report_configs post_route_datasheet]<br/>
		/// TIP: If the report is already GENERATED according to the STATE property, the report will not be<br/>
		/// regenerated.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 548<br/>
		/// </para>
		/// </summary>
		/// <param name="report_configs">(Required) List of configurable report objects to generate</param>
		/// <param name="jobs">(Optional) Number of jobs Default: 1</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL generate_reports(TCLParameterList report_configs, Int32? jobs = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_reports [-jobs <arg>] [-quiet] [-verbose] <report_configs>...
			_tcl.Entry(_builder.generate_reports(report_configs, jobs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Returns the current message count, limit, or the message configuration rules previously defined<br/>
		/// by the set_msg_config command.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_msg_config [-id &lt;arg&gt;] [-severity &lt;arg&gt;] [-rules] [-limit] [-count] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Returns the current message limit or count applied to a specified message ID or severity, or<br/>
		/// returns all message configuration rules defined in the current project. Message configuration<br/>
		/// rules are defined using the set_msg_config command.<br/>
		/// When used with -count this command will display the total number of messages that have<br/>
		/// been generated with the matching message id, or for the specified severity.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// IMPORTANT! The get_msg_config command reports the message count for the original CPU process<br/>
		/// from which Vivado was launched. Any sub-processes that the Vivado Design Suite launches, such as sub-processes used by the launch_runs command to launch synthesis and implementation runs, will not be<br/>
		/// reported in the message count. This can create confusion when the message count returned by<br/>
		/// get_msg_config -count is different from what is displayed in the Vivado IDE for instance, or<br/>
		/// different from what you expect. For this reason, the -count option is best used for non-project based<br/>
		/// designs.<br/>
		/// When used with -limit this command will display the current limit of messages with the<br/>
		/// matching message id, or for the specified severity.<br/>
		/// When used with -rules, it will display a table of all message configuration rules currently in<br/>
		/// effect.<br/>
		/// Note: You can only return the limit, the count, or the rules in a single get_msg_config command. An<br/>
		/// error is returned if more than one action is attempted.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the current count of the specified INFO message:<br/>
		/// get_msg_config -id "Common 17-81" -count<br/>
		/// The following example returns the message configuration rules in the current project:<br/>
		/// get_msg_config -rules<br/>
		/// This example changes the severity of messages with the specified message ID, gets the current<br/>
		/// message configuration rules, and then shows two different command forms to reset the specific<br/>
		/// rule and restore the message:<br/>
		/// set_msg_config -id "Common 17-361" -severity INFO -new_severity WARNING<br/>
		/// get_msg_config -rules<br/>
		/// ---------------------<br/>
		/// Message control rules currently in effect are:<br/>
		/// Rule Name Rule Current<br/>
		/// Message Count<br/>
		/// 1 set_msg_config -ruleid {1} -id {Common 17-361} -severity {INFO} -<br/>
		/// new_severity {WARNING} 0<br/>
		/// ---------------------<br/>
		/// reset_msg_config -id "Common 17-361" -default_severity<br/>
		/// reset_msg_config -ruleid {1}<br/>
		/// TIP: In the preceding example, only one of the reset_msg_config commands is needed to reset the<br/>
		/// message.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 835<br/>
		/// </para>
		/// </summary>
		/// <param name="id">
		/// <para>
		/// (Optional)<br/>
		/// The message id to match. Should be used in conjunction<br/>
		/// with -limit or -count Default: empty<br/>
		/// </para>
		/// </param>
		/// <param name="severity">
		/// <para>
		/// (Optional)<br/>
		/// The message severity to match. Should be used in<br/>
		/// conjunction with -limit or -count Default: empty<br/>
		/// </para>
		/// </param>
		/// <param name="rules">
		/// <para>
		/// (Optional)<br/>
		/// Show a table displaying all message control rules for the<br/>
		/// current project<br/>
		/// </para>
		/// </param>
		/// <param name="limit">
		/// <para>
		/// (Optional)<br/>
		/// Show the limit for the number of messages matching either<br/>
		/// -id or -severity that will be displayed<br/>
		/// </para>
		/// </param>
		/// <param name="count">
		/// <para>
		/// (Optional)<br/>
		/// Show the number of messages matching either -id or -<br/>
		/// severity that have been displayed<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL get_msg_config(String id = null, String severity = null, bool? rules = null, bool? limit = null, bool? count = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_msg_config [-id <arg>] [-severity <arg>] [-rules] [-limit] [-count] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_msg_config(id, severity, rules, limit, count, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Internal TCL task for reporting PPLOCs on pins or nets: (1) -nets option returns PPLOCs on given<br/>
		/// nets; (2) -pins option returns PPLOCs on given pins; (3) if option -nets and option -pins are both<br/>
		/// not specificed, it returns all PPLOCs in the design.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_pplocs -nets &lt;args&gt; -pins &lt;args&gt; [-count] [-unlocked] [-locked] [-level &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 891<br/>
		/// </para>
		/// </summary>
		/// <param name="nets">(Required) List of nets to report its PPLOCs</param>
		/// <param name="pins">(Required) List of pins to report its PPLOCs</param>
		/// <param name="count">(Optional) Count number of PPLOCs;; Do not report PPLOC or node names.</param>
		/// <param name="unlocked">(Optional) Report unlocked/unfixed PPLOCs only</param>
		/// <param name="locked">(Optional) Report locked/fixed PPLOCs only; use -level to specify locked level.</param>
		/// <param name="level">
		/// <para>
		/// (Optional)<br/>
		/// Specify locked level; Valid values are placement and routing.<br/>
		/// Default: placement<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>PPLOC nodes or number of PPLOCs</returns>
		public TTCL get_pplocs(TCLParameterList nets, TCLParameterList pins, bool? count = null, bool? unlocked = null, bool? locked = null, String level = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_pplocs -nets <args> -pins <args> [-count] [-unlocked] [-locked] [-level <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_pplocs(nets, pins, count, unlocked, locked, level, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of Configurable Report objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_report_configs [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns a list of report objects created by the create_report_config command.<br/>
		/// This command returns the list of report objects matching the search pattern and filters, or returns<br/>
		/// an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets all of the report objects in the current project:<br/>
		/// get_report_configs<br/>
		/// The following example gets all of the report objects in the current project that are associated<br/>
		/// with the opt_design step:<br/>
		/// get_report_configs -filter {RUN_STEP == opt_design}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 909<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'report' objects of these types: 'run'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match report names against patterns Default: *</param>
		/// <returns>list of Configurable Report objects</returns>
		public TTCL get_report_configs(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_report_configs [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_report_configs(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Open report from .rpx file<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: open_report [-file &lt;arg&gt;] [-append] [-console] [-name &lt;arg&gt;] [-return_string] [-quiet] [-verbose] &lt;rpx&gt;
		/// <br/>
		/// <para>
		/// Read an RPX (protobuf) file into memory to reload report results into the Vivado Design Suite.<br/>
		/// This command requires an open implemented or synthesized design.<br/>
		/// The RPX file is written by report commands such as report_timing_summary, and<br/>
		/// report_pulse_width, that support the -rpx option, and is an interactive report file that can<br/>
		/// be reloaded into memory. Reloading the report into memory, reconnects the objects in the report<br/>
		/// to design objects so that cross-selection between the report in the Vivado IDE and the design is<br/>
		/// enabled.<br/>
		/// This command returns the report results to the Tcl console by default, or when -console is<br/>
		/// specified, or opens a report window in the Vivado IDE when -name is specified. This command<br/>
		/// returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reads the specified RPX file an opens a named report in the Vivado IDE:<br/>
		/// open_report -name RPX1 design1_summary.rpx<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1091<br/>
		/// </para>
		/// </summary>
		/// <param name="rpx">(Required) Report data file to be read</param>
		/// <param name="file">(Optional) Filename to output results to</param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="console">(Optional) Send output to console</param>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="return_string">(Optional) Return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL open_report(String rpx, String file = null, bool? append = null, bool? console = null, String name = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: open_report [-file <arg>] [-append] [-console] [-name <arg>] [-return_string] [-quiet] [-verbose] <rpx>
			_tcl.Entry(_builder.open_report(rpx, file, append, console, name, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report timing paths<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_bus_skew [-delay_type &lt;arg&gt;] [-setup] [-hold] [-no_detailed_paths] [-max_paths &lt;arg&gt;] [-nworst &lt;arg&gt;] [-unique_pins] [-path_type &lt;arg&gt;] [-sort_by_slack] [-input_pins] [-no_header] [-significant_digits &lt;arg&gt;] [-file &lt;arg&gt;] [-append] [-return_string] [-warn_on_violation] [-rpx &lt;arg&gt;] [-cells &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Report the calculated bus skew among the signals constrained by set_bus_skew.<br/>
		/// The bus skew requirement applies to both the slow and fast corners. The Vivado tool determines<br/>
		/// the earliest and the latest arrival among all the signals of the bus and calculates the bus skew for<br/>
		/// both the Slow and Fast process corner, and reports the worst case skew. Each signal of the bus is<br/>
		/// reported relative to a reference signal from the same bus. Note that the reference signal can be<br/>
		/// different for each signal of the bus, which ever results in the worst bus skew for that signal.<br/>
		/// The bus skew report can be written to the Tcl console or command shell, assigned to a return<br/>
		/// string, or saved to a file.<br/>
		/// This command returns the bus skew report as specified, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the bus skew for the 32 worst signals of each bus skew<br/>
		/// constraints in the design, reporting 1 path per bit of the bus with the full timing path, including<br/>
		/// input pins, with timing values:<br/>
		/// report_bus_skew -max 32 -nworst 1 -path_type full -input_pins<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1297<br/>
		/// </para>
		/// </summary>
		/// <param name="delay_type">(Optional) Type of path delay: Values: max, min, min_max Default: min_max</param>
		/// <param name="setup">
		/// <para>
		/// (Optional)<br/>
		/// Report max delay endpoint timing paths (equivalent to -<br/>
		/// delay_type max)<br/>
		/// </para>
		/// </param>
		/// <param name="hold">
		/// <para>
		/// (Optional)<br/>
		/// Report min delay endpoint timing paths (equivalent to -<br/>
		/// delay_type min)<br/>
		/// </para>
		/// </param>
		/// <param name="no_detailed_paths">(Optional) Only report top level summary table</param>
		/// <param name="max_paths">
		/// <para>
		/// (Optional)<br/>
		/// Maximum number of paths to output per bus skew<br/>
		/// constraint: Value &gt;=1 Default: 1<br/>
		/// </para>
		/// </param>
		/// <param name="nworst">
		/// <para>
		/// (Optional)<br/>
		/// List up to N worst paths per endpoint per constraint: Value<br/>
		/// &gt;=1 Default: 1<br/>
		/// </para>
		/// </param>
		/// <param name="unique_pins">
		/// <para>
		/// (Optional)<br/>
		/// For each unique set of pins, show at most 1 path per bus<br/>
		/// skew constraint<br/>
		/// </para>
		/// </param>
		/// <param name="path_type">
		/// <para>
		/// (Optional)<br/>
		/// Format for path report: Values: short, full, full_clock,<br/>
		/// full_clock_expanded Default: full_clock_expanded<br/>
		/// </para>
		/// </param>
		/// <param name="sort_by_slack">(Optional) Sort summary and per-constraint sections by slack</param>
		/// <param name="input_pins">(Optional) Show input pins in path</param>
		/// <param name="no_header">(Optional) Do not generate a report header</param>
		/// <param name="significant_digits">(Optional) Number of digits to display: Range: 0 to 3 Default: 3</param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="return_string">(Optional) Return report as string</param>
		/// <param name="warn_on_violation">(Optional) Issue a critical warning when the report contains a timing violation</param>
		/// <param name="rpx">(Optional) Filename to output interactive results to.</param>
		/// <param name="cells">(Optional) run report_bus_skew on the specified hierarchical cell(s)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">
		/// <para>
		/// (Optional)<br/>
		/// Suspend message limits during command execution<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// </param>
		public TTCL report_bus_skew(report_bus_skew_delay_type? delay_type = null, bool? setup = null, bool? hold = null, bool? no_detailed_paths = null, Int32? max_paths = null, String nworst = null, bool? unique_pins = null, report_bus_skew_path_type? path_type = null, bool? sort_by_slack = null, bool? input_pins = null, bool? no_header = null, Int32? significant_digits = null, String file = null, bool? append = null, bool? return_string = null, bool? warn_on_violation = null, String rpx = null, TCLParameterList cells = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_bus_skew [-delay_type <arg>] [-setup] [-hold] [-no_detailed_paths] [-max_paths <arg>] [-nworst <arg>] [-unique_pins] [-path_type <arg>] [-sort_by_slack] [-input_pins] [-no_header] [-significant_digits <arg>] [-file <arg>] [-append] [-return_string] [-warn_on_violation] [-rpx <arg>] [-cells <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_bus_skew(delay_type, setup, hold, no_detailed_paths, max_paths, nworst, unique_pins, path_type, sort_by_slack, input_pins, no_header, significant_digits, file, append, return_string, warn_on_violation, rpx, cells, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report carry chains<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_carry_chains [-file &lt;arg&gt;] [-append] [-return_string] [-cell &lt;args&gt;] [-max_chains &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Report the details of the carry chains used by the current open design. The report includes the<br/>
		/// average depth of all carry chains, as well as the specific depth of each carry chain reported.<br/>
		/// By default, the longest carry chain is reported, but the number of chains reported can be<br/>
		/// specified.<br/>
		/// The command returns the carry chain report.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the 10 longest carry chains in the design:<br/>
		/// report_carry_chains -max_chains 10<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1301<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append to existing file</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="cell">(Optional) Report Carry Chains only for given cell</param>
		/// <param name="max_chains">(Optional) Number of chains for which report is to be generated Default: 1</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Report</returns>
		public TTCL report_carry_chains(String file = null, bool? append = null, bool? return_string = null, TCLParameterList cell = null, Int32? max_chains = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_carry_chains [-file <arg>] [-append] [-return_string] [-cell <args>] [-max_chains <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_carry_chains(file, append, return_string, cell, max_chains, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report the clock domain crossing (CDC) paths in the current design.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_cdc [-from &lt;args&gt;] [-to &lt;args&gt;] [-cells &lt;args&gt;] [-details] [-summary] [-all_checks_per_endpoint] [-severity &lt;arg&gt;] [-no_header] [-show_waiver] [-no_waiver] [-waived] [-file &lt;arg&gt;] [-append] [-return_string] [-name &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This report shows in detail the clock domain crossing (CDC) paths in the current synthesized or<br/>
		/// implemented design. The command analyzes paths between asynchronous clocks, or clocks with<br/>
		/// no common period, as well as synchronous paths ignored by the user due to false path or max<br/>
		/// delay datapath_only exceptions.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// By default the report_cdc command reports domain crossing between all clocks in the design.<br/>
		/// However, you can limit the clocks of interest using the -from and -to options to specify the<br/>
		/// clock domains of interest.<br/>
		/// The report_cdc command only reports on paths where both source and destination clocks are<br/>
		/// defined. You should run the check_timing command prior to report_cdc to ensure that<br/>
		/// there are no unconstrained clocks in the design. I/O paths are only covered by report_cdc<br/>
		/// when input or output delay constraints have been specified on the I/O ports.<br/>
		/// The severity of the path report could be Critical, Warning or Info depending on the CDC<br/>
		/// topology identified. An unknown synchronization topology is Critical and needs to be reviewed.<br/>
		/// A double register synchronizer with missing ASYNC_REG property is a Warning. Clock Enable,<br/>
		/// MUX, and MUX Hold CDC structures are categorized as Warnings because you should check to<br/>
		/// ensure that the structure is safe. Other CDC paths are of severity Info.<br/>
		/// The report_cdc command returns the following information:<br/>
		/// • Severity<br/>
		/// • Source Clock<br/>
		/// • Destination Clock<br/>
		/// • CDC Type<br/>
		/// • Exceptions<br/>
		/// • Endpoints<br/>
		/// • Safe<br/>
		/// • Unknown<br/>
		/// • No ASYNC_REG property<br/>
		/// IMPORTANT! You cannot use the set_msg_config command to configure the severity of messages<br/>
		/// returned by the report_cdc command. This command does not generate messages through the<br/>
		/// message manager.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the clock domain crossings in the current design, including any<br/>
		/// waived paths, using a verbose report form, and saving the results to a file:<br/>
		/// report_cdc -details -show_waiver -file C:/Data/cdc_report.txt<br/>
		/// The following example reports the clock domain crossings from a clock specified by name, to<br/>
		/// another specified as a clock object:<br/>
		/// report_cdc -from clk_pin_p -to [get_clocks clk_rx_clk_core]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1303<br/>
		/// </para>
		/// </summary>
		/// <param name="from">(Optional) From clocks</param>
		/// <param name="to">(Optional) To clocks</param>
		/// <param name="cells">(Optional) run report_cdc on the cells</param>
		/// <param name="details">(Optional) report the detail of the CDC timing paths not safely timed</param>
		/// <param name="summary">(Optional) report a summary by clocks of the CDC</param>
		/// <param name="all_checks_per_endpoint">(Optional) report all checks per endpoint</param>
		/// <param name="severity">(Optional) report only the severity specified (Info, Warning or Critical)</param>
		/// <param name="no_header">(Optional) Do not generate a report header</param>
		/// <param name="show_waiver">(Optional) Show the waived paths</param>
		/// <param name="no_waiver">(Optional) Ignore the waiver</param>
		/// <param name="waived">(Optional) Show only the waived paths</param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_cdc(TCLParameterList from = null, TCLParameterList to = null, TCLParameterList cells = null, bool? details = null, bool? summary = null, bool? all_checks_per_endpoint = null, String severity = null, bool? no_header = null, bool? show_waiver = null, bool? no_waiver = null, bool? waived = null, String file = null, bool? append = null, bool? return_string = null, String name = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_cdc [-from <args>] [-to <args>] [-cells <args>] [-details] [-summary] [-all_checks_per_endpoint] [-severity <arg>] [-no_header] [-show_waiver] [-no_waiver] [-waived] [-file <arg>] [-append] [-return_string] [-name <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_cdc(from, to, cells, details, summary, all_checks_per_endpoint, severity, no_header, show_waiver, no_waiver, waived, file, append, return_string, name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report on clock timing paths and unclocked registers<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_clock_interaction [-delay_type &lt;arg&gt;] [-setup] [-hold] [-significant_digits &lt;arg&gt;] [-no_header] [-file &lt;arg&gt;] [-append] [-name &lt;arg&gt;] [-return_string] [-cells &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Reports clock interactions and signals that cross clock domains to identify potential problems<br/>
		/// such a metastability, or data loss, or incoherency, where some visibility into the paths that cross<br/>
		/// clock domains is beneficial. This command requires an open synthesized or implemented design.<br/>
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be<br/>
		/// written to a file or returned as a string if desired.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets the model for interconnect delay, selects a device speed grade, and<br/>
		/// then runs report_clock_interaction:<br/>
		/// set_delay_model -interconnect none<br/>
		/// set_speed_grade -3<br/>
		/// report_clock_interaction -delay_type min_max \<br/>
		/// -significant_digits 3 -name "results_1"<br/>
		/// The following example returns the clock interactions, writing the report to the GUI, to the<br/>
		/// specified file, and returns a string which is assigned to the specified variable:<br/>
		/// set clk_int [report_clock_interaction -file clk_int.txt -name clk_int1 \<br/>
		/// -return_string]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1307<br/>
		/// </para>
		/// </summary>
		/// <param name="delay_type">(Optional) Type of path delay: Values: max, min, min_max Default: max</param>
		/// <param name="setup">(Optional) Consider max delay timing paths (equivalent to -delay_type max)</param>
		/// <param name="hold">(Optional) Consider min delay timing paths (equivalent to -delay_type min)</param>
		/// <param name="significant_digits">(Optional) Number of digits to display: Range: 0 to 3 Default: 2</param>
		/// <param name="no_header">(Optional) do not generate a report header</param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="return_string">(Optional) Return report as string</param>
		/// <param name="cells">(Optional) run report_clock_interaction on the specified cell(s)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_clock_interaction(report_clock_interaction_delay_type? delay_type = null, bool? setup = null, bool? hold = null, Int32? significant_digits = null, bool? no_header = null, String file = null, bool? append = null, String name = null, bool? return_string = null, TCLParameterList cells = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_clock_interaction [-delay_type <arg>] [-setup] [-hold] [-significant_digits <arg>] [-no_header] [-file <arg>] [-append] [-name <arg>] [-return_string] [-cells <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_clock_interaction(delay_type, setup, hold, significant_digits, no_header, file, append, name, return_string, cells, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report clock networks<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_clock_networks [-file &lt;arg&gt;] [-append] [-name &lt;arg&gt;] [-return_string] [-endpoints_only] [-levels &lt;arg&gt;] [-expand_buckets] [-suppress_endpoints &lt;arg&gt;] [-clocks &lt;args&gt;] [-unconstrained_roots &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Reports the network fanout of each clock net in the open synthesized or implemented design.<br/>
		/// The graphical form of the report, returned when the -name argument is specified, provides a<br/>
		/// hierarchical tree view of the clock network.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The default report simply specifies the clock net names and the instance pins that are the<br/>
		/// startpoint of the clock.<br/>
		/// The report is returned to the standard output unless the -file, -return_string, or -name<br/>
		/// arguments are specified.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the clock network names and startpoints to the specified file:<br/>
		/// report_clock_networks -file C:/Data/ClkNets.txt<br/>
		/// The following example reports the endpoints of the specified clock:<br/>
		/// report_clock_networks -endpoints_only -clocks wbClk<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1310<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="endpoints_only">
		/// <para>
		/// (Optional)<br/>
		/// dump clock network endpoints only; Not to be used in<br/>
		/// conjunction with -levels option<br/>
		/// </para>
		/// </param>
		/// <param name="levels">
		/// <para>
		/// (Optional)<br/>
		/// expands clock network upto n levels of instances, Value: n &gt;<br/>
		/// 0; Not to be used in conjunction with -endpoints_only option<br/>
		/// Default: 0<br/>
		/// </para>
		/// </param>
		/// <param name="expand_buckets">
		/// <para>
		/// (Optional)<br/>
		/// expands bucketed endpoints and displays pins; By default,<br/>
		/// endpoint pins are bucketed by celltype; This option only<br/>
		/// works in conjunction with -levels option or -endpoints_only<br/>
		/// option<br/>
		/// </para>
		/// </param>
		/// <param name="suppress_endpoints">
		/// <para>
		/// (Optional)<br/>
		/// suppress paths to clock or nonclock endpoint pins; Values:<br/>
		/// clock, nonclock<br/>
		/// </para>
		/// </param>
		/// <param name="clocks">
		/// <para>
		/// (Optional)<br/>
		/// List of clocks for clock network dump; if not specified, all<br/>
		/// clock networks are dumped<br/>
		/// </para>
		/// </param>
		/// <param name="unconstrained_roots">
		/// <para>
		/// (Optional)<br/>
		/// List of unconstrained root pins/ports for clock network<br/>
		/// dump; if not specified, all unconstrained clock roots are<br/>
		/// dumped<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_clock_networks(String file = null, bool? append = null, String name = null, bool? return_string = null, bool? endpoints_only = null, String levels = null, bool? expand_buckets = null, report_clock_networks_suppress_endpoints? suppress_endpoints = null, TCLParameterList clocks = null, TCLParameterList unconstrained_roots = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_clock_networks [-file <arg>] [-append] [-name <arg>] [-return_string] [-endpoints_only] [-levels <arg>] [-expand_buckets] [-suppress_endpoints <arg>] [-clocks <args>] [-unconstrained_roots <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_clock_networks(file, append, name, return_string, endpoints_only, levels, expand_buckets, suppress_endpoints, clocks, unconstrained_roots, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report information about clock nets in design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_clock_utilization [-file &lt;arg&gt;] [-append] [-write_xdc &lt;arg&gt;] [-cells &lt;args&gt;] [-clock_roots_only] [-return_string] [-name &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Returns information related to clock nets in the design and clock resource usage on the target<br/>
		/// device.<br/>
		/// The generated clock utilization report can generate placement constraints for the currently<br/>
		/// placed clock resources. You can use these constraints to preserve the placement of clock<br/>
		/// resources for future iterations of the design, by using the -write_xdc option.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// IMPORTANT! For Ultrascale devices, if the intent is to recreate the current clock placement then use the<br/>
		/// BUFGCE LOC properties from the written XDC file. However, if the intent is to use the constraints as a<br/>
		/// starting point for the clocking architecture, while allowing the Vivado Design Suite some flexibility in<br/>
		/// placing clock resources, use the equivalent CLOCK_REGION properties instead of the BUFGCE LOC<br/>
		/// properties.<br/>
		/// By default the report is written to the Tcl console or STD output. However, the results can also<br/>
		/// be written to a file or returned as a string if desired.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns information about the clock nets in the design and the clock<br/>
		/// resources utilized on the target device, and writes it to the specified file:<br/>
		/// report_clock_utilization -file C:/Data/FPGA_Design/clock_util.txt<br/>
		/// The following example reports the clock nets and clock resource utilization to the standard<br/>
		/// output, but writes the XDC location constraints to the specified file:<br/>
		/// report_clock_utilization -write_xdc clock_util_xdc.txt<br/>
		/// Note: Because the path is not specified as part of the XDC file name, the file will be created in the current<br/>
		/// working directory, or the directory from which the tool was launched.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1313<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append to existing file</param>
		/// <param name="write_xdc">(Optional) file to output clock constraint. File name must be given.</param>
		/// <param name="cells">(Optional) Cells/bel_instances for which to report clock utilization</param>
		/// <param name="clock_roots_only">(Optional) Report only the Clock Root Assignments</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Report</returns>
		public TTCL report_clock_utilization(String file = null, bool? append = null, String write_xdc = null, TCLParameterList cells = null, bool? clock_roots_only = null, bool? return_string = null, String name = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_clock_utilization [-file <arg>] [-append] [-write_xdc <arg>] [-cells <args>] [-clock_roots_only] [-return_string] [-name <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_clock_utilization(file, append, write_xdc, cells, clock_roots_only, return_string, name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report clocks<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_clocks [-file &lt;arg&gt;] [-append] [-return_string] [-quiet] [-verbose] [&lt;clocks&gt;]
		/// <br/>
		/// <para>
		/// Returns a table showing all the clocks in a design, including propagated clocks, generated and<br/>
		/// auto-generated clocks, virtual clocks, and inverted clocks in the current synthesized or<br/>
		/// implemented design. More detailed information about each clock net can be obtained with the<br/>
		/// report_clock_utilization command.<br/>
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be<br/>
		/// written to a file or returned as a string if desired.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the name, period, waveform, and sources of the clocks in the<br/>
		/// current design:<br/>
		/// report_clocks -file C:/Data/FPGA_Design/clock_out.txt<br/>
		/// The following example reports the clocks in the design with "Clock" in the name:<br/>
		/// report_clocks *Clock*<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1316<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="clocks">(Optional) List of clocks Default: *</param>
		public TTCL report_clocks(String file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null, String clocks = null)
		{
			// TCL Syntax: report_clocks [-file <arg>] [-append] [-return_string] [-quiet] [-verbose] [<clocks>]
			_tcl.Entry(_builder.report_clocks(file, append, return_string, quiet, verbose, clocks));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report Implementation flow Config param<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_config_implementation [-file &lt;arg&gt;] [-force] [-append] [-return_string] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Report the user-definable implementation flow configuration parameters for the implementation<br/>
		/// processes. These are parameters that can be modified using the config_implementation<br/>
		/// command.<br/>
		/// This command returns the selected report or the name of the output file, or returns an error if it<br/>
		/// fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example reports the user-configurable implementation parameters to the Tcl console:<br/>
		/// report_config_implementation<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1323<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. Send output to console if -file<br/>
		/// is not used.<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="append">(Optional) Append to existing file</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Report</returns>
		public TTCL report_config_implementation(String file = null, bool? force = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_config_implementation [-file <arg>] [-force] [-append] [-return_string] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_config_implementation(file, force, append, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report settings affecting timing analysis<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_config_timing [-file &lt;arg&gt;] [-append] [-name &lt;arg&gt;] [-return_string] [-all] [-no_header] [-rpx &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Report the configuration of timing constraints of the current design.<br/>
		/// By default the report is abbreviated, containing only a few key timing constraints. Use the -all<br/>
		/// argument to return all timing related configuration.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the current timing configuration, returns the information as a<br/>
		/// string, and sets that string into the specified Tcl variable:<br/>
		/// set timeConfig [report_config_timing -all -no_header -return_string]<br/>
		/// puts $timeConfig<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1325<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Optional) Output the results to file</param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="all">
		/// <para>
		/// (Optional)<br/>
		/// report all configuration settings (by default, only the<br/>
		/// typically important settings are reported<br/>
		/// </para>
		/// </param>
		/// <param name="no_header">(Optional) do not generate a report header</param>
		/// <param name="rpx">(Optional) Filename to output interactive results to.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_config_timing(String file = null, bool? append = null, String name = null, bool? return_string = null, bool? all = null, bool? no_header = null, String rpx = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_config_timing [-file <arg>] [-append] [-name <arg>] [-return_string] [-all] [-no_header] [-rpx <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_config_timing(file, append, name, return_string, all, no_header, rpx, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report the unique control sets in design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_control_sets [-file &lt;arg&gt;] [-append] [-hierarchical] [-hierarchical_depth &lt;arg&gt;] [-sort_by &lt;args&gt;] [-cells &lt;args&gt;] [-return_string] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Report the control sets of the current design.<br/>
		/// Control sets are the list of control signals (Clock, CE, SR) for SLICE registers and LUTs. Registers<br/>
		/// must belong to the same control set in order to be packed into the same device resource.<br/>
		/// Registers without a control signal cannot be packed into devices with registers having control<br/>
		/// signals. A high number of control sets can cause difficulty fitting the device and can cause routing<br/>
		/// congestion and timing issues.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// By default the report_control_sets command returns an abbreviated report indicating only<br/>
		/// the number of unique control sets. However, the -verbose arguments returns a detailed report<br/>
		/// of all control sets, for either the whole design or for the specified cells.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the control sets of the current design, sorted by the clk and clkEn<br/>
		/// signals:<br/>
		/// report_control_sets -verbose -sort_by {clk clkEn}<br/>
		/// The following example reports the control sets of the specified cells, sorted by clk and set:<br/>
		/// report_control_sets -verbose -sort_by {clk set} -cells [get_cells usb*]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1328<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append to existing file</param>
		/// <param name="hierarchical">(Optional) Generates text-based hierarchical report.</param>
		/// <param name="hierarchical_depth">(Optional) Specifies the depth level for textual hierarchical report Default: 0</param>
		/// <param name="sort_by">
		/// <para>
		/// (Optional)<br/>
		/// Sort criterion: can be used only when -verbose is used.<br/>
		/// Options are clk, clkEn, set. Ex: report_control_sets -verbose -<br/>
		/// sort_by {clk clkEn}<br/>
		/// </para>
		/// </param>
		/// <param name="cells">(Optional) Cells/bel_instances for which to report control sets</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Report</returns>
		public TTCL report_control_sets(String file = null, bool? append = null, bool? hierarchical = null, String hierarchical_depth = null, TCLParameterList sort_by = null, TCLParameterList cells = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_control_sets [-file <arg>] [-append] [-hierarchical] [-hierarchical_depth <arg>] [-sort_by <args>] [-cells <args>] [-return_string] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_control_sets(file, append, hierarchical, hierarchical_depth, sort_by, cells, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report data sheet<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_datasheet [-significant_digits &lt;arg&gt;] [-file &lt;arg&gt;] [-append] [-return_string] [-sort_by &lt;arg&gt;] [-name &lt;arg&gt;] [-show_all_corners] [-show_oe_timing] [-group &lt;args&gt;] [-rpx &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Create a "datasheet" report for the current design. Reports setup and hold times of input I/Os in<br/>
		/// relation to clocks, max/min delays from clocks to output pads, skews of input/ output buses.<br/>
		/// The datasheet report has the timing characteristics of a design at the package balls/pads,<br/>
		/// including the package trace flight times. To disable flight times use the following command:<br/>
		/// config_timing_analysis -disable_flight_delays true<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The source synchronous output skew can be automatically calculated by the Vivado Design Suite<br/>
		/// by using the -group switch for report_datasheet and grouping together all the ports of the<br/>
		/// data bus including the sourced clock output port. The sourced clock output port must be first in<br/>
		/// the group list. For example:<br/>
		/// report_datasheet -file output_filename -group [get_ports \<br/>
		/// {clock_port data_bit[0] data_bit[1] data_bit[2]}]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the datasheet sorted by ports, for all process corners:<br/>
		/// report_datasheet -sort_by port -show_all_corners<br/>
		/// The following example reports the datasheet with the skew calculation for two groups of ports,<br/>
		/// with the first port of each group providing the reference for the skew calculation for that group.<br/>
		/// In this example, CLK0OUT is the forwarded clock for DATA0-4 and CLK1OUT is the forwarded<br/>
		/// clock for DATA4-7:<br/>
		/// report_datasheet -file ds.txt -group [get_ports \<br/>
		/// {CLK0OUT DATA0 DATA1 DATA2 DATA3}] \<br/>
		/// -group [get_ports {CLK1OUT DATA4 DATA5 DATA6 DATA7}]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1331<br/>
		/// </para>
		/// </summary>
		/// <param name="significant_digits">(Optional) Number of digits to display: Range: 0 to 3 Default: 3</param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="sort_by">(Optional) Sorting order: Values: clock, port Default: clock</param>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="show_all_corners">(Optional) provide all corners</param>
		/// <param name="show_oe_timing">(Optional) show output enable (tristate) timing</param>
		/// <param name="group">(Optional) List of output ports for skew calculation</param>
		/// <param name="rpx">(Optional) Filename to output interactive results to.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_datasheet(Int32? significant_digits = null, String file = null, bool? append = null, bool? return_string = null, report_datasheet_sort_by? sort_by = null, String name = null, bool? show_all_corners = null, bool? show_oe_timing = null, TCLParameterList group = null, String rpx = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_datasheet [-significant_digits <arg>] [-file <arg>] [-append] [-return_string] [-sort_by <arg>] [-name <arg>] [-show_all_corners] [-show_oe_timing] [-group <args>] [-rpx <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_datasheet(significant_digits, file, append, return_string, sort_by, name, show_all_corners, show_oe_timing, group, rpx, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report details on debug cores<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_debug_core [-file &lt;arg&gt;] [-append] [-return_string] [-full_path] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Writes a report of the various Vivado device tool debug cores in the current project, and the<br/>
		/// parameters of those cores. Debug cores can be added to a project using the<br/>
		/// create_debug_core command.<br/>
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be<br/>
		/// written to a file or returned as a string if desired.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example writes the debug core report to the specified file name at the specified<br/>
		/// location:<br/>
		/// report_debug_core -file C:/Data/FPGA_Design/project_1_cores.txt<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1334<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="return_string">(Optional) Return report as a string</param>
		/// <param name="full_path">(Optional) Display full hierarchical net path in report</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_debug_core(String file = null, bool? append = null, bool? return_string = null, bool? full_path = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_debug_core [-file <arg>] [-append] [-return_string] [-full_path] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_debug_core(file, append, return_string, full_path, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report Design Analysis<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_design_analysis [-file &lt;arg&gt;] [-append] [-return_string] [-complexity] [-cells &lt;args&gt;] [-bounding_boxes &lt;args&gt;] [-hierarchical_depth &lt;arg&gt;] [-congestion] [-min_congestion_level &lt;arg&gt;] [-timing] [-setup] [-hold] [-show_all] [-full_logical_pin] [-routed_vs_estimated] [-logic_level_distribution] [-logic_level_dist_paths &lt;arg&gt;] [-min_level &lt;arg&gt;] [-max_level &lt;arg&gt;] [-return_timing_paths] [-of_timing_paths &lt;args&gt;] [-max_paths &lt;arg&gt;] [-extend] [-routes] [-end_point_clocks &lt;args&gt;] [-logic_levels &lt;arg&gt;] [-qor_summary] [-name &lt;arg&gt;] [-no_pr_attribute] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Provides timing data on critical path characteristics and complexity of the design to help identify<br/>
		/// and analyze problem areas that are subject to timing closure issues and routing congestion. For<br/>
		/// more information on this command refer to the Vivado Design Suite User Guide: Design Analysis<br/>
		/// and Closure Techniques (UG906).<br/>
		/// The report_design_analysis command currently has three modes of operation:<br/>
		/// • Timing: reports timing and physical characteristics of timing paths.<br/>
		/// • Complexity: analyzes the design for routing complexity and LUT distribution.<br/>
		/// • Congestion: analyzes the design for routing congestion.<br/>
		/// In timing mode, the command calls the static timing engine to analyze critical path data and<br/>
		/// report the characteristics of each path. The path characteristics include important elements such<br/>
		/// as clock skew, placement obstacles such as crossing clock regions, and physical constraints such<br/>
		/// as Pblocks and LOCs. The list of paths can be extended to include a number of top critical paths<br/>
		/// or specific paths can be analyzed by providing timing path objects to the command. The reports<br/>
		/// can also be extended to show the paths preceding and following the critical path.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following are definitions of the characteristics of the paths reported in timing mode:<br/>
		/// • PATH_TYPE: either SETUP or HOLD.<br/>
		/// • REQUIREMENT: delay requirement from static timing analysis.<br/>
		/// • PATH DELAY: data path delay from static timing analysis.<br/>
		/// • LOGIC DELAY: the portion of the PATH DELAY attributed to logic on the path.<br/>
		/// • NET DELAY: the portion of the PATH DELAY attributed to wires on the path. Note that the<br/>
		/// net delay is based on the estimated or actual routing delay as specified by the<br/>
		/// set_delay_model command.<br/>
		/// • CLOCK SKEW: difference in delay between the source and destination clocks.<br/>
		/// • SLACK: path timing slack from static timing analysis.<br/>
		/// • CLOCK RELATIONSHIP: SAME_CLOCK or RELATED_CLOCK. Helps identify potentially<br/>
		/// missed inter-clock constraints.<br/>
		/// • TIMING EXCEPTION: the timing exceptions, like set_false_path or<br/>
		/// set_multicycle_path, that are assigned to the path.<br/>
		/// • LOGIC LEVELS: number of logic levels between the source and destination, reported when<br/>
		/// the -logic_level_distribution is specified.<br/>
		/// • LOGICAL PATH: shorthand notation showing the ordered list of cells in the path including the<br/>
		/// start point and end point.<br/>
		/// Note: For Partial Reconfiguration (PR) designs, the logical path is appended to identify the cell as<br/>
		/// belonging to a reconfigurable partition (:RP#), or to the static region of the design (:S). A translation<br/>
		/// table at the bottom of the report maps :RP# to a specific reconfigurable partition.<br/>
		/// • START POINT CLOCK: the clock domain of the start point of the path.<br/>
		/// • END POINT CLOCK: the clock domain of the end point of the path.<br/>
		/// • START POINT PIN PRIMITIVE: the library cell and pin of the start point of the path.<br/>
		/// • END POINT PIN PRIMITIVE: the library cell and pin of the end point of the path.<br/>
		/// • START POINT PIN: the instance and pin name of the start point.<br/>
		/// • END POINT PIN: the instance and pin name of the end point.<br/>
		/// • COMB DSP: number of combinational DSP blocks in the path.<br/>
		/// • DOA REG: the number of DOA registers on the path.<br/>
		/// • DOB REG: the number of DOB registers on the path.<br/>
		/// • MREG: the number of MREG registers on the path.<br/>
		/// • PREG: the number of PREG registers on the path.<br/>
		/// • BRAM CROSSINGS: number of block RAM columns traversed by the path.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • DSP CROSSINGS: number of DSP block columns traversed by the path.<br/>
		/// • IO CROSSINGS: number of IO columns traversed by the path.<br/>
		/// • CONFIG CROSSINGS: the number of CONFIG tile traversed by the path.<br/>
		/// • SLR CROSSINGS: number of SLRs traversed by the path.<br/>
		/// • BOUNDING BOX SIZE: the rectangular area covered by the critical path, measured in RPM<br/>
		/// GRID units which are based on the device RPM_X (horizontal) and RPM_Y (vertical) site<br/>
		/// coordinates. Since different sites (slices, DSP, block RAM, etc.) have different sizes, each site<br/>
		/// has unique RPM_X and RPM_Y properties to pinpoint its location within the device.<br/>
		/// • CLOCK REGION DISTANCE: An ordered pair showing the number of clock regions traversed<br/>
		/// in the horizontal and vertical directions from path startpoint to endpoint. Minimizing clock<br/>
		/// region crossings can improve critical path delay and clock skew.<br/>
		/// ○ Example 1: A critical path begins in clock region X1Y1 and ends in clock region X3Y3,<br/>
		/// resulting in a CLOCK_REGION_DISTANCE of (2, 2).<br/>
		/// ○ Example 2: a critical path begins in clock region X2Y1 and ends in X0Y0, resulting in a<br/>
		/// CLOCK_REGION_DISTANCE of (-2, -1).<br/>
		/// • PBLOCKS: number of Pblocks traversed by the path.<br/>
		/// • HIGH FANOUT: the greatest fanout of a net in the path.<br/>
		/// • CUMULATIVE FANOUT: the total fanout on the path.<br/>
		/// • DONT TOUCH: number of cells in the path with DONT_TOUCH value of TRUE. A value of<br/>
		/// TRUE for DONT_TOUCH on a cell prevents it from being optimized, disabling potentially<br/>
		/// beneficial optimizations such as phys_opt_design replication.<br/>
		/// • MARK DEBUG: number of cells in the path with a MARK_DEBUG value of TRUE. By default a<br/>
		/// net with MARK_DEBUG has DONT_TOUCH set to TRUE which disables optimization on that<br/>
		/// net. The DONT_TOUCH can be set to FALSE to enable optimization and potentially improve<br/>
		/// timing.<br/>
		/// • FIXED LOC: number of placed cells in the path with an IS_LOC_FIXED value of TRUE. FIXED<br/>
		/// cells cannot be moved by either place_design or phys_opt_design.<br/>
		/// • FIXED ROUTE: number of routed nets in the path with IS_ROUTE_FIXED value of TRUE.<br/>
		/// FIXED routes cannot be ripped up and rerouted by route_design.<br/>
		/// • HOLD FIX DETOUR: the amount of routing detour provided to fix hold timing to post-route<br/>
		/// critical paths.<br/>
		/// • COMBINED LUT PAIRS: number of LUT cells in the path that have been combined with other<br/>
		/// LUT cells into the same LUT BEL to use both the O6 and O5 outputs. LUT cells that have been<br/>
		/// combined with LUTNM, HLUTNM, or SOFT_HLUTNM can be uncombined and re-placed by<br/>
		/// setting their HLUTNM properties to an empty string. This allows exploring LUT combining and<br/>
		/// un-combining effects on timing and congestion reduction.<br/>
		/// • The following fields are reported for Partial Reconfiguration (PR) designs. Refer to the Vivado<br/>
		/// Design Suite User Guide: Dynamic Function eXchange (UG909) for more information.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// ○ PR PATH TYPE: Specifies the path as being completely in the static region, completely in a<br/>
		/// reconfigurable partition (RP), or as crossing the boundary between regions. The delay<br/>
		/// elements for the timing path are also broken down between the regions .<br/>
		/// ○ STATIC CROSSINGS: Reports the number of times a reconfigurable partition (RP) path<br/>
		/// crosses into the static region.<br/>
		/// ○ RP CROSSINGS: Reports the number of times a static region path crosses into a<br/>
		/// reconfigurable partition (RP) region.<br/>
		/// ○ BOUNDARY FANOUT: Reports the fanout of a boundary path at the PPLOC to its<br/>
		/// downstream loads .<br/>
		/// In complexity mode, the command performs complexity analysis of the current design and<br/>
		/// reports the Rent Exponent which is a measure of complexity, the Average Fanout, and a Primitive<br/>
		/// Histogram. The analysis can be performed on the top-level design or recursively on hierarchical<br/>
		/// levels of the design, with the ability to control the level of recursion.<br/>
		/// The following are definitions of the characteristics reported in complexity mode:<br/>
		/// • Rent: The Rent exponent, as defined by Rent's rule, is a measure of interconnect complexity in<br/>
		/// a netlist. Higher Rent indicates higher complexity and greater difficulty to avoid routing<br/>
		/// congestion. Most designs have a Rent in the 0.5 to 0.6 range. A Rent value of 0.65 is<br/>
		/// considered high and 0.85 is considered very high.<br/>
		/// • Average Fanout: This is the average fanout of a logic cell in the design, excluding global<br/>
		/// buffers. Higher average fanout may result in more difficulty for placement and routing. While<br/>
		/// absolute values may not predict difficultly, relative values between designs or between<br/>
		/// hierarchical levels may be more indicative.<br/>
		/// • Primitive Histogram: This displays the totals of certain primitive types used in the design. A<br/>
		/// high Rent may be caused by a predominance of LUT6 cells. If there are many more LUT6 than<br/>
		/// other size LUTs, the Rent may be reduced by adopting a more area-focused synthesis strategy.<br/>
		/// TIP: The complexity characteristics may not always predict routing congestion but can be used to pinpoint<br/>
		/// problem areas when congestion issues occur.<br/>
		/// In congestion mode the command analyzes the design and provides metrics to help you alleviate<br/>
		/// routing congestion. Using the results from the report_design_analysis command, you can<br/>
		/// change placement to avoid specific routing hot spots.<br/>
		/// The command returns the file created, or returns the analysis results to the Tcl console, or returns<br/>
		/// an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example performs complexity analysis of the two specified cells:<br/>
		/// report_design_analysis -complexity -cells {cpuEngine fftEngine}<br/>
		/// The following example performs complexity analysis of the specified bounding boxes:<br/>
		/// report_design_analysis -complexity \<br/>
		/// -bounding_boxes { "CLE_M_X21Y239:CLEL_R_X28Y254"<br/>
		/// "CLEL_R_X18Y171:CLE_M_X26Y186" }<br/>
		/// The following example provides an extended analysis of the worst critical path from the Block<br/>
		/// RAMs in the design:<br/>
		/// report_design_analysis -timing -of_timing_paths \<br/>
		/// [get_timing_paths -from [all_rams]]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example performs complexity analysis for the specified cell, to a depth of two<br/>
		/// hierarchical levels, and performs timing and congestion analysis on the design:<br/>
		/// report_design_analysis -complexity -hierarchical_depth 2 -timing -setup \<br/>
		/// -hold -max_paths 10 -logic_level_distribution -logic_level_dist_paths 20 -<br/>
		/// congestion<br/>
		/// The following example uses the report_design_analysis command to return the timing<br/>
		/// paths with the specified end point clock and logic levels, and passes those paths to the<br/>
		/// report_timing command for analysis:<br/>
		/// report_timing -of_objects [report_design_analysis -end_point_clock cpuClk \<br/>
		/// -logic_levels 10 -timing -return_timing_paths]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1336<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="return_string">(Optional) Return report as string</param>
		/// <param name="complexity">(Optional) Finds the interconnection complexity (Rent) of the design</param>
		/// <param name="cells">(Optional) Report analysis information for given list of cells</param>
		/// <param name="bounding_boxes">
		/// <para>
		/// (Optional)<br/>
		/// Report interconnection complexity (Rent) for given list of<br/>
		/// bounding boxes Default: empty<br/>
		/// </para>
		/// </param>
		/// <param name="hierarchical_depth">(Optional) Hierarchical depth option for -complexity Default: 1</param>
		/// <param name="congestion">(Optional) Reports congestion of the design</param>
		/// <param name="min_congestion_level">
		/// <para>
		/// (Optional)<br/>
		/// Minimum congestion level for reporting router congestion,<br/>
		/// integer value between 3 and 8 Default: 5<br/>
		/// </para>
		/// </param>
		/// <param name="timing">(Optional) Reports characteristics of critical path</param>
		/// <param name="setup">(Optional) Reports characteristics of critical SETUP path</param>
		/// <param name="hold">(Optional) Reports characteristics of critical HOLD path</param>
		/// <param name="show_all">(Optional) Adds more characteristics to the timing characteristics report</param>
		/// <param name="full_logical_pin">(Optional) Display hierarchical pin names in the report</param>
		/// <param name="routed_vs_estimated">(Optional) Reports relevant characteristics of critical path in estimated mode</param>
		/// <param name="logic_level_distribution">(Optional) Reports logic level distribution</param>
		/// <param name="logic_level_dist_paths">
		/// <para>
		/// (Optional)<br/>
		/// Number of critical paths for analyzing logic level distribution<br/>
		/// used along with -logic_level_distribution Default: 1000<br/>
		/// </para>
		/// </param>
		/// <param name="min_level">
		/// <para>
		/// (Optional)<br/>
		/// Group all paths with logic levels &lt;min_level-1&gt; and below<br/>
		/// into a single bin, value passed must be at least 1 Default:<br/>
		/// Not Used<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Name Description<br/>
		/// </para>
		/// </param>
		/// <param name="max_level">
		/// <para>
		/// (Optional)<br/>
		/// Group all paths with logic levels &lt;max_level+1&gt; and above<br/>
		/// into a single bin, where &lt;max_level&gt; must be the greater of<br/>
		/// zero or &lt;min_level + 1&gt; if -min_level is used Default: Not<br/>
		/// Used<br/>
		/// </para>
		/// </param>
		/// <param name="return_timing_paths">(Optional) Returns timing path objects</param>
		/// <param name="of_timing_paths">(Optional) Reports characteristics for these paths</param>
		/// <param name="max_paths">(Optional) Number of paths to consider for -timing option Default: 1</param>
		/// <param name="extend">
		/// <para>
		/// (Optional)<br/>
		/// Reports characteristics of worst path before the start point<br/>
		/// of critical path and worst path after the end of the critical<br/>
		/// path<br/>
		/// </para>
		/// </param>
		/// <param name="routes">(Optional) Reports distribution with respect to Routes instead of logic levels</param>
		/// <param name="end_point_clocks">
		/// <para>
		/// (Optional)<br/>
		/// Returns timing path objects filtered by endpoint clock<br/>
		/// names as passed to this option<br/>
		/// </para>
		/// </param>
		/// <param name="logic_levels">
		/// <para>
		/// (Optional)<br/>
		/// Returns timing path objects bucketed under the bin name<br/>
		/// as passed to this option<br/>
		/// </para>
		/// </param>
		/// <param name="qor_summary">(Optional) Design Flow summary</param>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="no_pr_attribute">(Optional) Report without PR attributes</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_design_analysis(String file = null, bool? append = null, bool? return_string = null, bool? complexity = null, TCLParameterList cells = null, TCLParameterList bounding_boxes = null, String hierarchical_depth = null, bool? congestion = null, String min_congestion_level = null, bool? timing = null, bool? setup = null, bool? hold = null, bool? show_all = null, bool? full_logical_pin = null, bool? routed_vs_estimated = null, bool? logic_level_distribution = null, Int32? logic_level_dist_paths = null, String min_level = null, String max_level = null, bool? return_timing_paths = null, TCLParameterList of_timing_paths = null, Int32? max_paths = null, bool? extend = null, bool? routes = null, TCLParameterList end_point_clocks = null, String logic_levels = null, bool? qor_summary = null, String name = null, bool? no_pr_attribute = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_design_analysis [-file <arg>] [-append] [-return_string] [-complexity] [-cells <args>] [-bounding_boxes <args>] [-hierarchical_depth <arg>] [-congestion] [-min_congestion_level <arg>] [-timing] [-setup] [-hold] [-show_all] [-full_logical_pin] [-routed_vs_estimated] [-logic_level_distribution] [-logic_level_dist_paths <arg>] [-min_level <arg>] [-max_level <arg>] [-return_timing_paths] [-of_timing_paths <args>] [-max_paths <arg>] [-extend] [-routes] [-end_point_clocks <args>] [-logic_levels <arg>] [-qor_summary] [-name <arg>] [-no_pr_attribute] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_design_analysis(file, append, return_string, complexity, cells, bounding_boxes, hierarchical_depth, congestion, min_congestion_level, timing, setup, hold, show_all, full_logical_pin, routed_vs_estimated, logic_level_distribution, logic_level_dist_paths, min_level, max_level, return_timing_paths, of_timing_paths, max_paths, extend, routes, end_point_clocks, logic_levels, qor_summary, name, no_pr_attribute, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report disabled timing arcs<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_disable_timing [-user_disabled] [-column_style &lt;arg&gt;] [-file &lt;arg&gt;] [-append] [-cells &lt;args&gt;] [-return_string] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Displays a report of timing paths that will be excluded from timing analysis in the current<br/>
		/// synthesized or implemented design.<br/>
		/// The format of the report is organized into columns for "Cell or Port" to define the object<br/>
		/// associated with the timing path, "From" and "To" to define the timing path, the condition, and the<br/>
		/// reason for excluding the path from timing. The various reasons for exclusion are as follows:<br/>
		/// • constraint - set_disable_timing constraint is specified<br/>
		/// • constant - Logic constant<br/>
		/// • loop - Breaks a logic loop<br/>
		/// • bidirect instance path - Feedback path through bidirectional instances<br/>
		/// • bidirect net path - Feedback path on nets with bidirectional pins<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be<br/>
		/// written to a file or returned as a string if desired.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports all timing paths that will not be included in timing analysis:<br/>
		/// report_disable_timing<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example outputs the disable timing report as a string, stores it in a variable, and<br/>
		/// then puts it to the display:<br/>
		/// set bad_time [report_disable_timing -return_string]<br/>
		/// puts $bad_time<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1346<br/>
		/// </para>
		/// </summary>
		/// <param name="user_disabled">(Optional) report only user disabled arcs</param>
		/// <param name="column_style">
		/// <para>
		/// (Optional)<br/>
		/// style for path report columns: Values: variable_width,<br/>
		/// anchor_left Default: variable_width<br/>
		/// </para>
		/// </param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="cells">(Optional) run report_disable_timing on the specified cell(s)</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_disable_timing(bool? user_disabled = null, report_disable_timing_column_style? column_style = null, String file = null, bool? append = null, TCLParameterList cells = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_disable_timing [-user_disabled] [-column_style <arg>] [-file <arg>] [-append] [-cells <args>] [-return_string] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_disable_timing(user_disabled, column_style, file, append, cells, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Run DRC<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_drc [-name &lt;arg&gt;] [-upgrade_cw] [-checks &lt;args&gt;] [-ruledecks &lt;args&gt;] [-file &lt;arg&gt;] [-rpx &lt;arg&gt;] [-append] [-waived] [-no_waivers] [-return_string] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Check the current design against a specified set of design rule checks, or rule decks, and report<br/>
		/// any errors or violations that are found.<br/>
		/// The report_drc command requires an open design to check the design rules against. The<br/>
		/// command returns a report with the results of violations found by the design rule checks.<br/>
		/// Violations are returned as Vivado objects that can be listed with the get_drc_violations<br/>
		/// command, and are associated with cells, pins, ports, nets, and sites in the current design. You can<br/>
		/// get the cells, nets, and other design objects that are associated with DRC violation objects, using<br/>
		/// the -of_objects option of the get_cells command for instance.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// TIP: The report_drc can be multi-threaded to speed the process. Refer to the set_param command<br/>
		/// for more information on setting the general.maxThreads parameter.<br/>
		/// The Vivado tools include a large number of predefined design rule checks to be used by the<br/>
		/// report_drc command. Use the get_drc_checks command to list the currently defined<br/>
		/// design rule checks. You can also create new custom design rule checks using the<br/>
		/// create_drc_check command.<br/>
		/// A rule deck is a collection of design rule checks grouped for convenience, to be run at different<br/>
		/// stages of the FPGA design flow, such as during I/O planning or placement. The tool comes with a<br/>
		/// set of factory defined rule decks, but you can also create new user-defined rule decks with the<br/>
		/// create_drc_ruledeck command. Use the get_drc_ruledecks command to return a list<br/>
		/// of the currently defined rule decks available for use in the report_drc command.<br/>
		/// The report_drc command runs a default rule deck when the -checks or -ruledeck options<br/>
		/// are not specified. Creating a user-defined DRC automatically adds the new design rule check to<br/>
		/// the default rule deck.<br/>
		/// DRC rules can be enabled or disabled using the IS_ENABLED property on the rule check object.<br/>
		/// If a rule IS_ENABLED false, the rule will not be run by the report_drc command, whether it is<br/>
		/// specified directly using -checks, or indirectly with -ruledeck.<br/>
		/// TIP: You can reset the properties of a DRC rule to the factory default settings using the<br/>
		/// reset_drc_check command.<br/>
		/// You can reset the current results of the report_drc command, clearing any found violations,<br/>
		/// using the reset_drc command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example lists the available rule decks. The results include all factory rule decks and<br/>
		/// all user-defined rule decks.<br/>
		/// get_drc_ruledecks<br/>
		/// The following example returns the list of DRC rules defined in the specified rule deck:<br/>
		/// get_drc_checks -of_objects [get_drc_ruledecks placer_checks]<br/>
		/// The following examples run the specified DRC rule deck and rules against the current design, and<br/>
		/// writes the results to the specified file:<br/>
		/// report_drc -ruledecks placer_checks -file C:/Data/DRC_Rpt1.txt<br/>
		/// report_drc -checks {IOCNT-1 IOPCPR-1 IOPCMGT-1 IOCTMGT-1 IODIR-1} \<br/>
		/// -file C:/Data/DRC_Rpt1.txt -append<br/>
		/// Note: The -append option adds the result of the second report_drc command to the specified file.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1349<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="upgrade_cw">
		/// <para>
		/// (Optional)<br/>
		/// Specifies if report_drc should upgrade all<br/>
		/// CRITICAL_WARNING violations to ERROR.<br/>
		/// </para>
		/// </param>
		/// <param name="checks">(Optional) DRC checks (see get_drc_checks for available checks)</param>
		/// <param name="ruledecks">(Optional) Containers of DRC rule checks Default: default</param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="rpx">(Optional) Report filename for persisted results.</param>
		/// <param name="append">(Optional) Append the results to file, do not overwrite the results file</param>
		/// <param name="waived">(Optional) Output result is Waived checks</param>
		/// <param name="no_waivers">(Optional) Disable waivers for checks</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_drc(String name = null, bool? upgrade_cw = null, TCLParameterList checks = null, TCLParameterList ruledecks = null, String file = null, String rpx = null, bool? append = null, bool? waived = null, bool? no_waivers = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_drc [-name <arg>] [-upgrade_cw] [-checks <args>] [-ruledecks <args>] [-file <arg>] [-rpx <arg>] [-append] [-waived] [-no_waivers] [-return_string] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_drc(name, upgrade_cw, checks, ruledecks, file, rpx, append, waived, no_waivers, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report system information.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_environment [-file &lt;arg&gt;] [-format &lt;arg&gt;] [-append] [-return_string] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Report the details of the system environment that the tool is running under. The details of the<br/>
		/// environment report include: operating system version, CPU, memory, available disk space, and<br/>
		/// specific settings of various environment variables.<br/>
		/// The default is to write the report to the standard output. However, the report can be written to a<br/>
		/// file instead.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the current environment to the specified file:<br/>
		/// report_environment -file C:/Data/toolEnv.txt<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1356<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Optional) Write system information to specified file.</param>
		/// <param name="format">
		/// <para>
		/// (Optional)<br/>
		/// Specifies how to format the report. Default is 'text', another<br/>
		/// option is 'xml'. Only applies if -file is used. If xml output is<br/>
		/// used, -append is not allowed. Default: text<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append report to existing file</param>
		/// <param name="return_string">(Optional) Return report content as a string value</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_environment(String file = null, String format = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_environment [-file <arg>] [-format <arg>] [-append] [-return_string] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_environment(file, format, append, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report timing exceptions<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_exceptions [-from &lt;args&gt;] [-rise_from &lt;args&gt;] [-fall_from &lt;args&gt;] [-to &lt;args&gt;] [-rise_to &lt;args&gt;] [-fall_to &lt;args&gt;] [-through &lt;args&gt;] [-rise_through &lt;args&gt;] [-fall_through &lt;args&gt;] [-ignored] [-summary] [-coverage] [-ignored_objects] [-count_objects] [-write_merged_exceptions] [-write_valid_exceptions] [-no_header] [-file &lt;arg&gt;] [-append] [-return_string] [-name &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Report all timing exceptions applied to setup and hold checks defined by timing constraints in the<br/>
		/// current design, or report the exceptions on the specified timing paths.<br/>
		/// Timing exceptions can be defined by timing constraints such as set_false_path or<br/>
		/// set_multicycle_path that change the default assumptions for timing paths in the design.<br/>
		/// The exceptions are reported to the standard output by default, but can be redirected to a file or<br/>
		/// to a Tcl string variable.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example reports all timing exceptions in the current design:<br/>
		/// report_exceptions<br/>
		/// This example reports all timing exceptions ignored or overridden in the current design:<br/>
		/// report_exceptions -ignored<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1358<br/>
		/// </para>
		/// </summary>
		/// <param name="from">(Optional) From pins, ports, cells or clocks</param>
		/// <param name="rise_from">(Optional) Rising from pins, ports, cells or clocks</param>
		/// <param name="fall_from">(Optional) Falling from pins, ports, cells or clocks</param>
		/// <param name="to">(Optional) To pins, ports, cells or clocks</param>
		/// <param name="rise_to">(Optional) Rising to pins, ports, cells or clocks</param>
		/// <param name="fall_to">(Optional) Falling to pins, ports, cells or clocks</param>
		/// <param name="through">(Optional) Through pins, ports, cells or nets</param>
		/// <param name="rise_through">(Optional) Rising through pins, ports, cells or nets</param>
		/// <param name="fall_through">(Optional) Falling through pins, ports, cells or nets</param>
		/// <param name="ignored">(Optional) Only report exceptions which are fully ignored</param>
		/// <param name="summary">(Optional) Report a summary of all exceptions</param>
		/// <param name="coverage">(Optional) Report the coverage of all timing exceptions</param>
		/// <param name="ignored_objects">(Optional) Report the list of ignored startpoints and endpoints</param>
		/// <param name="count_objects">(Optional) Report the number of objects in the timing exceptions</param>
		/// <param name="write_merged_exceptions">(Optional) Write merged timing exceptions</param>
		/// <param name="write_valid_exceptions">(Optional) Write timing exceptions with the valid objects only</param>
		/// <param name="no_header">(Optional) Do not generate a report header</param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="return_string">(Optional) Return report as string</param>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">
		/// <para>
		/// (Optional)<br/>
		/// Suspend message limits during command execution<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// </param>
		public TTCL report_exceptions(TCLParameterList from = null, TCLParameterList rise_from = null, TCLParameterList fall_from = null, TCLParameterList to = null, TCLParameterList rise_to = null, TCLParameterList fall_to = null, TCLParameterList through = null, TCLParameterList rise_through = null, TCLParameterList fall_through = null, bool? ignored = null, bool? summary = null, bool? coverage = null, bool? ignored_objects = null, bool? count_objects = null, bool? write_merged_exceptions = null, bool? write_valid_exceptions = null, bool? no_header = null, String file = null, bool? append = null, bool? return_string = null, String name = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_exceptions [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-through <args>] [-rise_through <args>] [-fall_through <args>] [-ignored] [-summary] [-coverage] [-ignored_objects] [-count_objects] [-write_merged_exceptions] [-write_valid_exceptions] [-no_header] [-file <arg>] [-append] [-return_string] [-name <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_exceptions(from, rise_from, fall_from, to, rise_to, fall_to, through, rise_through, fall_through, ignored, summary, coverage, ignored_objects, count_objects, write_merged_exceptions, write_valid_exceptions, no_header, file, append, return_string, name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report high fanout nets<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_high_fanout_nets [-file &lt;arg&gt;] [-format &lt;arg&gt;] [-append] [-ascending] [-timing] [-histogram] [-load_types] [-clock_regions] [-slr] [-max_nets &lt;arg&gt;] [-fanout_greater_than &lt;arg&gt;] [-fanout_lesser_than &lt;arg&gt;] [-name &lt;arg&gt;] [-cells &lt;args&gt;] [-clocks &lt;args&gt;] [-return_string] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Report the fanout of nets in the design, starting with the highest fanout nets, and working down.<br/>
		/// Options allow you to control various aspects of the report.<br/>
		/// This command can be run on an implemented design, or on the synthesized netlist. However, the<br/>
		/// results will be more complete on the implemented design.<br/>
		/// The command returns the fanout report of nets in the design, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the fanout of nets for the specified clocks:<br/>
		/// report_high_fanout_nets -clocks [get_clocks gt*]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example reports the nets with fanouts less than 10 loads, and returns the results to<br/>
		/// a string stored as a Tcl variable:<br/>
		/// set myRep [report_high_fanout_nets -fanout_lesser_than 10 -return_string]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1365<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="format">
		/// <para>
		/// (Optional)<br/>
		/// Specifies how to format the report: text, xml. Default is<br/>
		/// 'text'. Only applies if -file is used. If xml output is used, -<br/>
		/// append is not allowed. Default: text<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append to existing file</param>
		/// <param name="ascending">(Optional) Report nets in ascending order</param>
		/// <param name="timing">(Optional) Report worst slack and worst delay values on nets</param>
		/// <param name="histogram">(Optional) Report histogram for high fanout nets</param>
		/// <param name="load_types">(Optional) Report load details</param>
		/// <param name="clock_regions">(Optional) Report clock region wise load distribution</param>
		/// <param name="slr">(Optional) Report SLR wise load distribution</param>
		/// <param name="max_nets">(Optional) Number of nets for which report is to be generated Default: 10</param>
		/// <param name="fanout_greater_than">
		/// <para>
		/// (Optional)<br/>
		/// Report nets that have fanout greater than the specified<br/>
		/// integer, default 0 Default: 0<br/>
		/// </para>
		/// </param>
		/// <param name="fanout_lesser_than">
		/// <para>
		/// (Optional)<br/>
		/// Report nets that have fanout less than the specified integer,<br/>
		/// default INT_MAX Default: INT_MAX<br/>
		/// </para>
		/// </param>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="cells">(Optional) Report the nets of the specified cells</param>
		/// <param name="clocks">(Optional) Report the nets of the specified clocks</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">
		/// <para>
		/// (Optional)<br/>
		/// Suspend message limits during command execution<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// </param>
		/// <returns>Report</returns>
		public TTCL report_high_fanout_nets(String file = null, String format = null, bool? append = null, bool? ascending = null, bool? timing = null, bool? histogram = null, bool? load_types = null, bool? clock_regions = null, bool? slr = null, Int32? max_nets = null, String fanout_greater_than = null, String fanout_lesser_than = null, String name = null, TCLParameterList cells = null, TCLParameterList clocks = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_high_fanout_nets [-file <arg>] [-format <arg>] [-append] [-ascending] [-timing] [-histogram] [-load_types] [-clock_regions] [-slr] [-max_nets <arg>] [-fanout_greater_than <arg>] [-fanout_lesser_than <arg>] [-name <arg>] [-cells <args>] [-clocks <args>] [-return_string] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_high_fanout_nets(file, format, append, ascending, timing, histogram, load_types, clock_regions, slr, max_nets, fanout_greater_than, fanout_lesser_than, name, cells, clocks, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Formatted report on Versal integrated and soft Memory Controllers' (DDRMCs) memory<br/>
		/// configurations, calibration status, stages, and window margins data.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_hw_ddrmc [-file &lt;arg&gt;] [-append] [-return_string] [-quiet] [-verbose] &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// Report formatted information on memory IP hardware configuration, calibration, and margin.<br/>
		/// Does not include the graphical margin scan plots that are available within the Vivado logic<br/>
		/// analyzer, or Vivado Lab Edition.<br/>
		/// In the Vivado tools, Versal memory controllers implemented into a design are associated with<br/>
		/// hw_ddrmc objects. These hw_ddrmc objects let you verify the calibration, read, and write<br/>
		/// window margins in your memory interface design. You can use the hardware manager GUI to<br/>
		/// check the calibration status, verify the read margin for both rising and falling edges of the clock,<br/>
		/// and write margin for both simple and complex patterns. You can also use an ILA and VIO core to<br/>
		/// verify the data integrity for the read and write operations.<br/>
		/// This command returns the reported data, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example generates the report on the hw_ddrmc objects and outputs them to the<br/>
		/// text file specified:<br/>
		/// report_hw_ddrmc -file C:/Data/ddrmc_report.txt [get_hw_ddrmcs]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1372<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_objects">(Required) hardware DDRMC objects</param>
		/// <param name="file">(Optional) file name (including full path) to output the report results to</param>
		/// <param name="append">(Optional) set this option to append the report results to a file</param>
		/// <param name="return_string">(Optional) set this option to have report results returned as a string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_hw_ddrmc(String hw_objects, String file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_hw_ddrmc [-file <arg>] [-append] [-return_string] [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.report_hw_ddrmc(hw_objects, file, append, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report formatted hardware MIG calibration status and margin data<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_hw_mig [-file &lt;arg&gt;] [-append] [-return_string] [-quiet] [-verbose] &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// Report formatted information on memory IP hardware configuration, calibration, and margin.<br/>
		/// Does not include the graphical margin scan plots that are available within the Vivado logic<br/>
		/// analyzer, or Vivado Lab Edition.<br/>
		/// In the Vivado tools, memory controllers implemented into a design are associated with hw_mig<br/>
		/// objects. These hw_mig objects let you verify the calibration, read, and write window margins in<br/>
		/// your memory interface design. You can use the hardware manager GUI to check the calibration<br/>
		/// status, verify the read margin for both rising and falling edges of the clock, and write margin for<br/>
		/// both simple and complex patterns, or DQS. You can also use an ILA core to verify the data<br/>
		/// integrity for the read and write operations.<br/>
		/// This command returns the reported data, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example generates the report on the hw_mig objects and outputs to the text file<br/>
		/// specified:<br/>
		/// report_hw_mig -file C:/Data/hw_mig_report.txt [get_hw_migs]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1374<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_objects">(Required) hardware mig objects</param>
		/// <param name="file">(Optional) file name (including full path) to output the report results to</param>
		/// <param name="append">(Optional) set this option to append the report results to a file</param>
		/// <param name="return_string">(Optional) set this option to have report results return as a string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_hw_mig(String hw_objects, String file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_hw_mig [-file <arg>] [-append] [-return_string] [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.report_hw_mig(hw_objects, file, append, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Formatted report on Versal soft Memory Controller cores' (Soft MCs) memory configurations,<br/>
		/// calibration status, stages, and window margins data.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_hw_softmc [-file &lt;arg&gt;] [-append] [-return_string] [-quiet] [-verbose] &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1378<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_objects">(Required) hardware Soft MC objects</param>
		/// <param name="file">(Optional) file name (including full path) to output the report results to</param>
		/// <param name="append">(Optional) set this option to append the report results to a file</param>
		/// <param name="return_string">(Optional) set this option to have report results returned as a string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_hw_softmc(String hw_objects, String file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_hw_softmc [-file <arg>] [-append] [-return_string] [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.report_hw_softmc(hw_objects, file, append, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Compute achievable incremental reuse for the given design-checkpoint and report<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_incremental_reuse [-file &lt;arg&gt;] [-append] [-cells &lt;args&gt;] [-hierarchical] [-hierarchical_depth &lt;arg&gt;] [-return_string] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// For use with the incremental implementation flow, this command reports on the amount of<br/>
		/// design overlap between the current design and an incremental checkpoint loaded using the<br/>
		/// read_checkpoint -incremental command.<br/>
		/// This report analyzes the loaded incremental checkpoint against the current design to see if the<br/>
		/// two are sufficiently correlated to drive incremental placement and routing. A low correlation<br/>
		/// between the current design and the checkpoint should discourage using the checkpoint as a<br/>
		/// basis for incremental place and route. Refer to the Vivado Design Suite User Guide: Implementation<br/>
		/// (UG904) for more information on incremental place and route.<br/>
		/// If there is a low correlation of reuse between the current design and the loaded incremental<br/>
		/// checkpoint, you will need to restore the original design using open_run or read_checkpoint.<br/>
		/// Alternatively, you can overload the incremental checkpoint in the current design by issuing the<br/>
		/// read_checkpoint -incremental command again to specify a new incremental checkpoint.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// For Partial Reconfiguration (PR) designs, the % of cells matching in Reconfigurable Modules (RM)<br/>
		/// are reported, the % of cells reused in RMs, and the % of cells fixed in RMs are also reported.<br/>
		/// There is also a Reconfigurable Modules Summary table added to the report.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example loads an incremental checkpoint into the current design, and then reports<br/>
		/// the correlation of the loaded incremental checkpoint to the current design:<br/>
		/// read_checkpoint -incremental C:/Data/reuse_checkpoint1.dcp<br/>
		/// report_incremental_reuse<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1381<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append to existing file</param>
		/// <param name="cells">(Optional) Report incremental reuse of given list of cells</param>
		/// <param name="hierarchical">(Optional) Generates text-based hierarchical incremental reuse report.</param>
		/// <param name="hierarchical_depth">
		/// <para>
		/// (Optional)<br/>
		/// Specifies the depth level for textual hierachical incremental<br/>
		/// reuse report Default: 0<br/>
		/// </para>
		/// </param>
		/// <param name="return_string">(Optional) Return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_incremental_reuse(String file = null, bool? append = null, TCLParameterList cells = null, bool? hierarchical = null, String hierarchical_depth = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_incremental_reuse [-file <arg>] [-append] [-cells <args>] [-hierarchical] [-hierarchical_depth <arg>] [-return_string] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_incremental_reuse(file, append, cells, hierarchical, hierarchical_depth, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Display information about all the IO sites on the device<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_io [-file &lt;arg&gt;] [-name &lt;arg&gt;] [-append] [-format &lt;arg&gt;] [-return_string] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Report details of the IO banks of the current design. Details include device specific information<br/>
		/// such as target part, package, and speed grade, and also provides information related to each pin<br/>
		/// on the device.<br/>
		/// This command returns the requested report, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the IO blocks of the current design:<br/>
		/// report_io<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1384<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. Send output to console if -file<br/>
		/// is not used.<br/>
		/// </para>
		/// </param>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="append">(Optional) Append to existing file</param>
		/// <param name="format">
		/// <para>
		/// (Optional)<br/>
		/// Specifies how to format the report: text, xml. Default is<br/>
		/// 'text'. Only applies if -file is used. If xml output is used, -<br/>
		/// append is not allowed. Default: text<br/>
		/// </para>
		/// </param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Report</returns>
		public TTCL report_io(String file = null, String name = null, bool? append = null, String format = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_io [-file <arg>] [-name <arg>] [-append] [-format <arg>] [-return_string] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_io(file, name, append, format, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Methodology Checks<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_methodology [-name &lt;arg&gt;] [-cells &lt;args&gt;] [-checks &lt;args&gt;] [-file &lt;arg&gt;] [-rpx &lt;arg&gt;] [-append] [-waived] [-no_waivers] [-slack_lesser_than &lt;arg&gt;] [-return_string] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Check the current design against a specified set of methodology checks and report any errors or<br/>
		/// violations that are found.<br/>
		/// Methodology checks are a special class of design rule checks (DRC) that are accessible through<br/>
		/// this separate Tcl command. The methodology checks are a necessary part of the design flow, and<br/>
		/// should be considered mandatory after implementation and prior to generating the bitstream.<br/>
		/// TIP: Other than their availability through the separate report_methodology command, the checks<br/>
		/// are standard design rule checks in every other way.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The report_methodology command requires an open design to check the design rules<br/>
		/// against. The command returns a report with the results of violations found by the design rule<br/>
		/// checks. Violations are returned as Vivado objects that can be listed with the<br/>
		/// get_methodology_violations command, and are associated with cells, pins, ports, nets,<br/>
		/// and sites in the current design. You can get the cells, nets, and other design objects that are<br/>
		/// associated with methodology violation objects, using the -of_objects option of the<br/>
		/// get_cells command for instance.<br/>
		/// The report_methodology command runs the methodology rule deck, or you can use the -<br/>
		/// checks option to specify the set of checks to run. Methodology checks can also be enabled or<br/>
		/// disabled in the default rule decks using the IS_ENABLED property on the rule check object:<br/>
		/// set_property IS_ENABLED FALSE [get_methodology_checks PDRC-190]<br/>
		/// If a rule IS_ENABLED false, the rule will not be run by the report_methodology command.<br/>
		/// TIP: You can reset the properties of a methodology rule to the factory default settings using the<br/>
		/// reset_methodology_check command.<br/>
		/// You can reset the current results of the report_methodology command, clearing any found<br/>
		/// violations, using the reset_methodology command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following examples run the default methodology checks against the current design, and<br/>
		/// writes the results to the specified file:<br/>
		/// report_methodology -file C:/Data/methodology_Rpt1.txt -append<br/>
		/// Note: The -append option adds the result to the specified file.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1389<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="cells">(Optional) Run report_methodology on the specified cell(s).</param>
		/// <param name="checks">
		/// <para>
		/// (Optional)<br/>
		/// Report Methodology checks (see get_methodology_checks<br/>
		/// for available checks)<br/>
		/// </para>
		/// </param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="rpx">(Optional) Report filename for persisted results.</param>
		/// <param name="append">(Optional) Append the results to file, do not overwrite the results file</param>
		/// <param name="waived">(Optional) Output result is Waived checks</param>
		/// <param name="no_waivers">(Optional) Disable waivers for checks</param>
		/// <param name="slack_lesser_than">(Optional) Set SYNTH rules Slack Threshold value in 'ns' (float) Default: 2.0</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_methodology(String name = null, TCLParameterList cells = null, TCLParameterList checks = null, String file = null, String rpx = null, bool? append = null, bool? waived = null, bool? no_waivers = null, String slack_lesser_than = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_methodology [-name <arg>] [-cells <args>] [-checks <args>] [-file <arg>] [-rpx <arg>] [-append] [-waived] [-no_waivers] [-slack_lesser_than <arg>] [-return_string] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_methodology(name, cells, checks, file, rpx, append, waived, no_waivers, slack_lesser_than, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get operating conditions values for power estimation<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_operating_conditions [-voltage &lt;args&gt;] [-voltage_range &lt;args&gt;] [-grade] [-process] [-junction_temp] [-ambient_temp] [-thetaja] [-thetasa] [-airflow] [-heatsink] [-thetajb] [-board] [-board_temp] [-board_layers] [-design_power_budget] [-all] [-file &lt;arg&gt;] [-return_string] [-append] [-supply_current_budget &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Displays the real-world operating conditions that are used when performing analysis of the<br/>
		/// design. The reported values of operating conditions can be defined by the<br/>
		/// set_operating_conditions command.<br/>
		/// The environmental operating conditions of the device are used for power analysis when running<br/>
		/// the report_power command, but are not used during timing analysis.<br/>
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be<br/>
		/// written to a file or returned as a string if desired.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// Specify an industrial temperature grade device with an ambient temperature of 75 degrees C and<br/>
		/// then write those settings to a file on disk.<br/>
		/// set_operating_conditions -grade industrial -junction_temp 75<br/>
		/// report_operating_conditions -grade -junction_temp -return_string -file \<br/>
		/// ~/conditions.txt<br/>
		/// Get voltage ranges of VCCINT and VCCAUX for the target device.<br/>
		/// report_operating_conditions -voltage_range {VCCINT VCCAUX}<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1395<br/>
		/// </para>
		/// </summary>
		/// <param name="voltage">(Optional) Gets voltage value. Supported voltage supplies vary by family.</param>
		/// <param name="voltage_range">(Optional) Gets voltage range. Supported voltage supplies vary by family.</param>
		/// <param name="grade">(Optional) Temperature grade. Supported values vary by family.</param>
		/// <param name="process">(Optional) Gets process</param>
		/// <param name="junction_temp">(Optional) Junction Temperature (C): auto|degC</param>
		/// <param name="ambient_temp">(Optional) Ambient Temperature (C): default|degC</param>
		/// <param name="thetaja">(Optional) ThetaJA (C/W): auto|degC/W</param>
		/// <param name="thetasa">(Optional) Gets ThetaSA</param>
		/// <param name="airflow">(Optional) Airflow (LFM): 0 to 750</param>
		/// <param name="heatsink">(Optional) Gets dimensions of heatsink</param>
		/// <param name="thetajb">(Optional) Gets ThetaJB</param>
		/// <param name="board">(Optional) Board type: jedec, small, medium, large, custom</param>
		/// <param name="board_temp">(Optional) Board Temperature degC</param>
		/// <param name="board_layers">(Optional) Board layers: 4to7, 8to11, 12to15, 16+</param>
		/// <param name="design_power_budget">(Optional) Design Power Budget (W)</param>
		/// <param name="all">(Optional) Gets all operating conditions listed in this help message</param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="return_string">(Optional) return operating conditions as string</param>
		/// <param name="append">(Optional) append operating conditions to end of file</param>
		/// <param name="supply_current_budget">
		/// <para>
		/// (Optional)<br/>
		/// Reports a list of supply current budget 'name value' pairs.<br/>
		/// Supported voltage supplies vary by family.<br/>
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
		public TTCL report_operating_conditions(TCLParameterList voltage = null, TCLParameterList voltage_range = null, bool? grade = null, bool? process = null, bool? junction_temp = null, bool? ambient_temp = null, bool? thetaja = null, bool? thetasa = null, bool? airflow = null, bool? heatsink = null, bool? thetajb = null, bool? board = null, bool? board_temp = null, bool? board_layers = null, bool? design_power_budget = null, bool? all = null, String file = null, bool? return_string = null, bool? append = null, TCLParameterList supply_current_budget = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_operating_conditions [-voltage <args>] [-voltage_range <args>] [-grade] [-process] [-junction_temp] [-ambient_temp] [-thetaja] [-thetasa] [-airflow] [-heatsink] [-thetajb] [-board] [-board_temp] [-board_layers] [-design_power_budget] [-all] [-file <arg>] [-return_string] [-append] [-supply_current_budget <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_operating_conditions(voltage, voltage_range, grade, process, junction_temp, ambient_temp, thetaja, thetasa, airflow, heatsink, thetajb, board, board_temp, board_layers, design_power_budget, all, file, return_string, append, supply_current_budget, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get information about all parameters<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_param [-file &lt;arg&gt;] [-append] [-non_default] [-return_string] [-quiet] [-verbose] [&lt;pattern&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of all user-definable parameters, the current value, and a description of what the<br/>
		/// parameter configures or controls.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the name, value, and description of all user-definable parameters:<br/>
		/// report_param<br/>
		/// The following example returns the name, value, and description of user-definable parameters<br/>
		/// that match the specified search pattern:<br/>
		/// report_param *coll*<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1399<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="non_default">(Optional) Report only params that are set to a non default value</param>
		/// <param name="return_string">(Optional) Return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="pattern">(Optional) Display params matching pattern Default: *</param>
		/// <returns>param report</returns>
		public TTCL report_param(String file = null, bool? append = null, bool? non_default = null, bool? return_string = null, bool? quiet = null, bool? verbose = null, String pattern = null)
		{
			// TCL Syntax: report_param [-file <arg>] [-append] [-non_default] [-return_string] [-quiet] [-verbose] [<pattern>]
			_tcl.Entry(_builder.report_param(file, append, non_default, return_string, quiet, verbose, pattern));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report details of Physical Synthesis transformations.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_phys_opt [-file &lt;arg&gt;] [-append] [-return_string] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Reports the results of the fanout driver replication and load redistribution optimizations<br/>
		/// performed by the phys_opt_design command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the physical optimizations performed in the current design by the<br/>
		/// phys_opt_design command:<br/>
		/// report_phys_opt -file C:/Data/physOpt_Report.txt<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1401<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Optional) Output file</param>
		/// <param name="append">(Optional) Append the results to file</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_phys_opt(String file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_phys_opt [-file <arg>] [-append] [-return_string] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_phys_opt(file, append, return_string, quiet, verbose));
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
		/// Report reconfigurable partition analysis across multiple configurations<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_pr_configuration_analysis [-complexity] [-clocking] [-timing] [-cells &lt;args&gt;] [-dcps &lt;args&gt;] [-rent] [-nworst &lt;arg&gt;] [-file &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// IMPORTANT! You must first define the project as a Partial Reconfiguration (PR) project by setting the<br/>
		/// PR_FLOW property on the project to TRUE, or by using the Tools → Enable Partial Reconfiguration<br/>
		/// command.<br/>
		/// Report reconfigurable partition analysis across multiple configurations as defined by<br/>
		/// create_pr_configuration. This report compares each Reconfigurable Module that you<br/>
		/// select to give you input on your PR design. It examines resource usage, floorplanning, clocking,<br/>
		/// and timing metrics to help you manage the overall PR design. For more information on this<br/>
		/// command refer to the Vivado Design Suite User Guide: Dynamic Function eXchange (UG909).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// When this analysis is done, each RM is examined based on information in the checkpoints<br/>
		/// provided. While post-synthesis checkpoints can be supplied, the most complete information is<br/>
		/// not available until after opt_design when all the linking and expansion has been done.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example performs complexity analysis of the design:<br/>
		/// report_pr_configuration_analysis -complexity<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1412<br/>
		/// </para>
		/// </summary>
		/// <param name="complexity">(Optional) Run complexity analysis</param>
		/// <param name="clocking">(Optional) Run clocking analysis</param>
		/// <param name="timing">(Optional) Run boundary net timing analysis</param>
		/// <param name="cells">(Optional) List of reconfigurable cell names</param>
		/// <param name="dcps">
		/// <para>
		/// (Optional)<br/>
		/// List of design checkpoints for each reconfigurable cell. The<br/>
		/// order of dcps must match that of the -cells option.<br/>
		/// </para>
		/// </param>
		/// <param name="rent">
		/// <para>
		/// (Optional)<br/>
		/// Compute Rents component as part of complexity analysis.<br/>
		/// Runtime intensive for large designs.<br/>
		/// </para>
		/// </param>
		/// <param name="nworst">(Optional) Specifies the N worst boundary paths. Default: 10</param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_pr_configuration_analysis(bool? complexity = null, bool? clocking = null, bool? timing = null, TCLParameterList cells = null, TCLParameterList dcps = null, bool? rent = null, String nworst = null, String file = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_pr_configuration_analysis [-complexity] [-clocking] [-timing] [-cells <args>] [-dcps <args>] [-rent] [-nworst <arg>] [-file <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_pr_configuration_analysis(complexity, clocking, timing, cells, dcps, rent, nworst, file, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report properties of object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_property [-all] [-class &lt;arg&gt;] [-return_string] [-file &lt;arg&gt;] [-append] [-regexp] [-quiet] [-verbose] [&lt;object&gt;] [&lt;pattern&gt;]
		/// <br/>
		/// <para>
		/// Gets the property name, property type, and property value for all of the properties on a specified<br/>
		/// object, or class of objects.<br/>
		/// Note: list_property also returns a list of all properties on an object, but does not include the property<br/>
		/// type or value.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// You can specify objects for report_property using the get_* series of commands to get a<br/>
		/// specific object. You can use the lindex command to return a specific object from a list of<br/>
		/// objects:<br/>
		/// report_property [lindex [get_cells] 0]<br/>
		/// However, if you are looking for the properties on a class of objects, you should use the -<br/>
		/// classoption instead of an actual object.<br/>
		/// This command returns a report of properties on the object, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns all properties of the specified object:<br/>
		/// report_property -all [get_cells cpuEngine]<br/>
		/// The following example returns the properties of the specified class of objects, rather than an<br/>
		/// actual object:<br/>
		/// report_property -class bel<br/>
		/// The following example returns properties on the current hw_device that match the specified<br/>
		/// pattern, specified as a regular expression:<br/>
		/// report_property [current_hw_device] -regexp .*PROG.*<br/>
		/// To determine which properties are available for the different design objects supported by the<br/>
		/// tool, you can use multiple report_property commands in sequence. The following example<br/>
		/// returns all properties of the specified current objects:<br/>
		/// report_property -all [current_project]<br/>
		/// report_property -all [current_fileset]<br/>
		/// report_property -all [current_design]<br/>
		/// report_property -all [current_run]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1415<br/>
		/// </para>
		/// </summary>
		/// <param name="all">(Optional) Report all properties of object even if not set</param>
		/// <param name="class">(Optional) Object type to query for properties. Not valid with &lt;object&gt;</param>
		/// <param name="return_string">
		/// <para>
		/// (Optional)<br/>
		/// Set the result of running report_property in the Tcl<br/>
		/// interpreter's result variable<br/>
		/// </para>
		/// </param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output result to. Send output to console if -file<br/>
		/// is not used<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="regexp">(Optional) Pattern is treated as a regular expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="object">(Optional) Object to query for properties</param>
		/// <param name="pattern">(Optional) Pattern to match properties against Default: *</param>
		/// <returns>property report</returns>
		public TTCL report_property(bool? all = null, String @class = null, bool? return_string = null, String file = null, bool? append = null, bool? regexp = null, bool? quiet = null, bool? verbose = null, String @object = null, String pattern = null)
		{
			// TCL Syntax: report_property [-all] [-class <arg>] [-return_string] [-file <arg>] [-append] [-regexp] [-quiet] [-verbose] [<object>] [<pattern>]
			_tcl.Entry(_builder.report_property(all, @class, return_string, file, append, regexp, quiet, verbose, @object, pattern));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report pulse width check<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_pulse_width [-file &lt;arg&gt;] [-append] [-name &lt;arg&gt;] [-return_string] [-warn_on_violation] [-all_violators] [-significant_digits &lt;arg&gt;] [-limit &lt;arg&gt;] [-min_period] [-max_period] [-low_pulse] [-high_pulse] [-max_skew] [-clocks &lt;args&gt;] [-no_header] [-cells &lt;args&gt;] [-rpx &lt;arg&gt;] [-quiet] [-verbose] [&lt;objects&gt;]
		/// <br/>
		/// <para>
		/// Reports the pulse width of the specified clock signals in the clock network and upon reaching the<br/>
		/// flip-flop. This command also performs high pulse width checking, using maximum delay for the<br/>
		/// rising edge and minimum delay for the falling edge of the clock. Performs low pulse width<br/>
		/// checking using minimum delay for the rising edge, and maximum delay for the falling edge. This<br/>
		/// results in a worst case analysis for the current Synthesis or Implemented Design because it<br/>
		/// assumes worst-case delays for both rising and falling edges. This command also reports the<br/>
		/// maximum skew, or maximum timing separation allowed between clock signals.<br/>
		/// The report includes minimum pulse width, maximum pulse width, low pulse width, high pulse<br/>
		/// width, and max skew checks by default. However, selecting a specific check will disable the other<br/>
		/// checks unless they are also specified.<br/>
		/// The default report is returned to the standard output, but can be redirected to a file, or to a Tcl<br/>
		/// string variable for further processing. The report is returned to the standard output by default,<br/>
		/// unless the -file, -return_string, or -name arguments are specified.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example performs the minimum period and low pulse width check, returning the<br/>
		/// results to a named results set in the GUI:<br/>
		/// report_pulse_width -min_period -low_pulse -name timing_1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1419<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="name">(Optional) Results name in which to store output</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="warn_on_violation">(Optional) issue a critical warning when the report contains a timing violation</param>
		/// <param name="all_violators">(Optional) Only report pins/ports where check violations occur</param>
		/// <param name="significant_digits">(Optional) Number of digits to display: Range: 0 to 3 Default: 3</param>
		/// <param name="limit">
		/// <para>
		/// (Optional)<br/>
		/// Number of checks of a particular type to report per clock:<br/>
		/// Default is 1 Default: 1<br/>
		/// </para>
		/// </param>
		/// <param name="min_period">(Optional) Only report min period checks</param>
		/// <param name="max_period">(Optional) Only report max period checks</param>
		/// <param name="low_pulse">(Optional) Only report min low pulse width checks</param>
		/// <param name="high_pulse">(Optional) Only report min high pulse width checks</param>
		/// <param name="max_skew">(Optional) Only report max skew checks</param>
		/// <param name="clocks">(Optional) List of clocks for which to report min pulse width/min period checks</param>
		/// <param name="no_header">(Optional) Do not generate a report header</param>
		/// <param name="cells">(Optional) run report_pulse_width on the specified cell(s)</param>
		/// <param name="rpx">(Optional) Filename to output interactive results to.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">(Optional) List of objects to check min pulse width with</param>
		public TTCL report_pulse_width(String file = null, bool? append = null, String name = null, bool? return_string = null, bool? warn_on_violation = null, bool? all_violators = null, Int32? significant_digits = null, Int32? limit = null, bool? min_period = null, bool? max_period = null, bool? low_pulse = null, bool? high_pulse = null, bool? max_skew = null, TCLParameterList clocks = null, bool? no_header = null, TCLParameterList cells = null, String rpx = null, bool? quiet = null, bool? verbose = null, String objects = null)
		{
			// TCL Syntax: report_pulse_width [-file <arg>] [-append] [-name <arg>] [-return_string] [-warn_on_violation] [-all_violators] [-significant_digits <arg>] [-limit <arg>] [-min_period] [-max_period] [-low_pulse] [-high_pulse] [-max_skew] [-clocks <args>] [-no_header] [-cells <args>] [-rpx <arg>] [-quiet] [-verbose] [<objects>]
			_tcl.Entry(_builder.report_pulse_width(file, append, name, return_string, warn_on_violation, all_violators, significant_digits, limit, min_period, max_period, low_pulse, high_pulse, max_skew, clocks, no_header, cells, rpx, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Feasibility Checks<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_qor_assessment [-file &lt;arg&gt;] [-max_paths &lt;arg&gt;] [-append] [-return_string] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This command look for trouble spots in the design and assesses the likelihood of a design<br/>
		/// meeting design goals. This command requires an open elaborated, synthesized or implemented<br/>
		/// design for analysis.<br/>
		/// The Report QoR Assessment covers multiple categories:<br/>
		/// • Design Methodology<br/>
		/// • Synthesis<br/>
		/// • Implementation<br/>
		/// • Design Hierarchy<br/>
		/// • Partial Reconfiguration<br/>
		/// • Floorplanning<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The report_qor_assessment command includes a subset of report_methodology checks<br/>
		/// identifying bad practices that can lead to an expected problem. Yet, report_qor_assessment<br/>
		/// is also more comprehensive than report_methodology, because it includes other checks that<br/>
		/// are not necessarily bad practices but may have low success due to the structure, style, size, or<br/>
		/// complexity of the current design.<br/>
		/// A key feature of Report QOR Assessment is the ability to predict certain conditions that lead to<br/>
		/// congestion and performance degradation. This command can be run at any stage of the<br/>
		/// implementation flow after synthesis. The report_qor_assessment command will return a<br/>
		/// score from 1 - 5, where 1 is a failing grade, and 5 means the design will likely pass<br/>
		/// implementation and meet timing.<br/>
		/// For violations found by Report QOR Assessment, the Report QOR Suggestions command will<br/>
		/// make recommendations on how to avoid issues, or modify the design to improve results.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports suggestions after analyzing the worst 10 paths:<br/>
		/// report_qor_assessment -max_paths 10<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1423<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="max_paths">(Optional) Number of paths to consider for suggestion analysis Default: 100</param>
		/// <param name="append">(Optional) Append the results to file, do not overwrite the results file</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_qor_assessment(String file = null, Int32? max_paths = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_qor_assessment [-file <arg>] [-max_paths <arg>] [-append] [-return_string] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_qor_assessment(file, max_paths, append, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Recommend QoR Suggestions<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_qor_suggestions [-file &lt;arg&gt;] [-name &lt;arg&gt;] [-append] [-return_string] [-max_strategies &lt;arg&gt;] [-max_paths &lt;arg&gt;] [-no_split] [-report_all_suggestions] [-cells &lt;args&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Report design and tool option recommendations related to improving the quality of results (QoR).<br/>
		/// The report looks at timing constraints, netlist characteristics, failing timing paths, and congestion<br/>
		/// information to determine suggestions that can enhance the QoR. The report can be generated<br/>
		/// after synthesis, or after any implementation step, but requires a design to be open.<br/>
		/// The report_qor_suggestions command creates QoR suggestion objects related to the<br/>
		/// suggestions identified. These suggestion objects can be enabled for use by the Vivado tools to<br/>
		/// improve the quality of synthesis and implementation results. Some of these suggestions can be<br/>
		/// automatically applied, and some may require more manual intervention to implement design<br/>
		/// changes, or write Tcl design constraints.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Suggestion objects can be obtained using the get_qor_suggestions command. The QoR<br/>
		/// objects have properties that define what step they are APPLICABLE_FOR, if they are ENABLED<br/>
		/// to be used, if they can be automatically applied (AUTO), or what step the suggestions was<br/>
		/// GENERATED_AT. A suggestion must be ENABLED and the APPLICABLE_FOR synthesis or<br/>
		/// implementation step run in order for a suggestion to be applied to the design.<br/>
		/// You can write the suggestions from the design into an RQS file using the<br/>
		/// write_qor_suggestions command. After resetting the design flow to the appropriate step,<br/>
		/// you can read suggestions back into the design using the read_qor_suggestions command,<br/>
		/// and then run the synthesis or implementation step to apply the enabled suggestions.<br/>
		/// The recommended method for working with QoR suggestions is:<br/>
		/// 1. Run the report to create recommendations (report_qor_suggestions)<br/>
		/// 2. Write the suggestions to an RQS file on disk (write_qor_suggestions).<br/>
		/// 3. Reset the design to the appropriate step.<br/>
		/// 4. Read the RQS file into the design to restore the suggestions (read_qor_suggestions).<br/>
		/// 5. Run the synthesis or implementation step to apply the suggestion (synth_design,<br/>
		/// opt_design...).<br/>
		/// For strategy suggestions, a machine learning based analysis is conducted and the best 3<br/>
		/// strategies are reported. This analysis is only conducted on a routed design that has been<br/>
		/// implemented with<br/>
		/// • either default or explore directives for opt_design and<br/>
		/// • either all default or all explore directives for place_design, phys_opt_design, and<br/>
		/// route_design commands.<br/>
		/// Strategy suggestions do not apply to synthesis. Unlike the non-strategy suggestions, only one<br/>
		/// strategy suggestion can be applied to each run.<br/>
		/// The recommended method for working with QoR strategy suggestions is:<br/>
		/// 1. Run the report to create strategies and other<br/>
		/// recommendations(report_qor_suggestions).<br/>
		/// 2. Write the suggestions to a directory disk. There is one RQS file per strategy<br/>
		/// (write_qor_suggestions -strategy_dir).<br/>
		/// 3. Update all the directive settings to -directive RQS for opt_design, place_design,<br/>
		/// phys_opt_design, and route_design commands.<br/>
		/// 4. For each run, read one RQS file into the design. This will contain the strategy suggestion and<br/>
		/// all exported non-strategy suggestions(read_qor_suggestions).<br/>
		/// 5. Run the implementation step from the opt_design command to apply the strategy and all<br/>
		/// the design suggestions.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports suggestions after analyzing the worst 10 paths:<br/>
		/// report_qor_suggestions -max_paths 10<br/>
		/// This example reports existing suggestions in the design from a prior run of<br/>
		/// report_qor_suggestions:<br/>
		/// report_qor_suggestions -of_objects [get_qor_suggestions]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1426<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="return_string">(Optional) Return report as string</param>
		/// <param name="max_strategies">(Optional) Number of strategies to suggest Default: 3</param>
		/// <param name="max_paths">(Optional) Number of paths to consider for suggestion analysis Default: 100</param>
		/// <param name="no_split">(Optional) Report without spliting the lines in tables</param>
		/// <param name="report_all_suggestions">(Optional) Report all suggestions</param>
		/// <param name="cells">(Optional) Report QOR suggestions for a given cell</param>
		/// <param name="of_objects">(Optional) List of QoR suggestion objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_qor_suggestions(String file = null, String name = null, bool? append = null, bool? return_string = null, Int32? max_strategies = null, Int32? max_paths = null, bool? no_split = null, bool? report_all_suggestions = null, TCLParameterList cells = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_qor_suggestions [-file <arg>] [-name <arg>] [-append] [-return_string] [-max_strategies <arg>] [-max_paths <arg>] [-no_split] [-report_all_suggestions] [-cells <args>] [-of_objects <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_qor_suggestions(file, name, append, return_string, max_strategies, max_paths, no_split, report_all_suggestions, cells, of_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report configuration about RAMs in design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_ram_utilization [-append] [-file &lt;arg&gt;] [-csv &lt;arg&gt;] [-return_string] [-cells &lt;args&gt;] [-include_path_info] [-include_lutram] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Reports RAM usage in the current design at any stage after synthesis. It is recommended to run<br/>
		/// this report after optimizations in opt_design have been run. The report is returned to the<br/>
		/// standard output, unless the -file or -return_string arguments are used.<br/>
		/// The report details the following tables:<br/>
		/// • Summary: The Summary table shows the utilization by RAM type, broken down into URAM,<br/>
		/// Block RAM and LUTRAM. For each RAM type, it is broken down into the individual primitives.<br/>
		/// Also detailed is the inferred primitive %. If using a synthesis tool other than Vivado Synthesis<br/>
		/// or instantiation of primitives, then rams will be reported under instantiated primitives.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The information in the summary can be used to determine if there are imbalances in the<br/>
		/// utilization of different types of RAMs. Based on the summary, a design might benefit from<br/>
		/// retargeting heavily used primitives to lesser used ones at the cost of being less efficient.<br/>
		/// Additionally LUTRAM implementation can be evaluated. LUTRAM primitives vary in their<br/>
		/// efficiency of Bits/LUT. For example, a RAM32M16 uses 8 LUTs and can have up to 14 data<br/>
		/// bits. Using RAM32X1D primitives, 8 LUTs yields a maximum of 8 bits when LUT combined.<br/>
		/// • Memory Description: The Memory Description table gives an RTL look at the inferred<br/>
		/// memories. It refers to memories that are inferred directly or indirectly using XPMs. The table is<br/>
		/// ordered by the total number of bits in the memory array. Items reported are memory type and<br/>
		/// mapping.<br/>
		/// The mapping format is &lt;report&gt;:&lt;physical&gt;:&lt;depth&gt;x&lt;width&gt;<br/>
		/// The following tables are repeated for inferred and instantiated primitives.Collectively they are<br/>
		/// refered to as the detailed tables.<br/>
		/// • Memory Utilization: The Memory Utilization table details how each memory array is mapped<br/>
		/// to primitives. Also provided is information on how efficient the mapping is and whether the<br/>
		/// mapping is limited by depth or width.<br/>
		/// • Memory Performance: The Memory Performance table details performance aspects of the<br/>
		/// RAM. It includes information whether the output register is used, cascading has been used. If<br/>
		/// the -include_path_info switch is specified there is extra information on the worst path<br/>
		/// from each pin listed.<br/>
		/// • Memory Power: The Memory Power table details what power aspects of the RAM have been<br/>
		/// used. It includes information on cascading and whether the enable pin is tied to POWER or a<br/>
		/// signal.<br/>
		/// This command returns the requested report to the Tcl console, to a file, or as a string; or returns<br/>
		/// an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example provides a full report of the inferred and non-inferred BlockRAM and<br/>
		/// UltraRAM resources and writes the results to both the specified text and CSV files:<br/>
		/// report_ram_utilization -csv ./ram_util.csv -file ./ram_util.txt<br/>
		/// The following example provides a full report of the inferred and non-inferred BlockRAM,<br/>
		/// UltraRAM and LUTRAM resources and writes the results to the specified CSV file:<br/>
		/// report_ram_utilization -csv ./ram_util.csv -include_lutram<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1430<br/>
		/// </para>
		/// </summary>
		/// <param name="append">(Optional) Append to existing file</param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="csv">(Optional) Write detailed tables to the CSV filename specified</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="cells">
		/// <para>
		/// (Optional)<br/>
		/// Limits the reporting to only those memory arrays that are<br/>
		/// contained within the specified cells.<br/>
		/// </para>
		/// </param>
		/// <param name="include_path_info">(Optional) Adds path info to the RAM inputs/outputs</param>
		/// <param name="include_lutram">(Optional) Adds LUTRAMs to the report</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Report</returns>
		public TTCL report_ram_utilization(bool? append = null, String file = null, String csv = null, bool? return_string = null, TCLParameterList cells = null, bool? include_path_info = null, bool? include_lutram = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_ram_utilization [-append] [-file <arg>] [-csv <arg>] [-return_string] [-cells <args>] [-include_path_info] [-include_lutram] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_ram_utilization(append, file, csv, return_string, cells, include_path_info, include_lutram, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report on status of the routing.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_route_status [-return_nets] [-return_string] [-file &lt;arg&gt;] [-append] [-of_objects &lt;args&gt;] [-route_type &lt;arg&gt;] [-list_all_nets] [-show_all] [-dump_routes] [-has_routing] [-boolean_check &lt;arg&gt;] [-ignore_cache] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Reports the state of routing in the current design.<br/>
		/// The route status report can include a wide range of information, from a simple 1 if the design has<br/>
		/// routing, to a complete route tree for each net in the design.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the route status for the specified nets:<br/>
		/// report_route_status -of_objects [get_nets u4*]<br/>
		/// The following example returns a list of nets that have routing but are not fully routed to the Find<br/>
		/// Results window in the Vivado IDE.<br/>
		/// show_objects [report_route_status -return_nets -route_type PARTIAL]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1433<br/>
		/// </para>
		/// </summary>
		/// <param name="return_nets">(Optional) Return a list of nets that match the given -route_type type</param>
		/// <param name="return_string">
		/// <para>
		/// (Optional)<br/>
		/// Set the result of running the report in the Tcl interpreter's<br/>
		/// result variable<br/>
		/// </para>
		/// </param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="of_objects">(Optional) Report detailed routing for these routes</param>
		/// <param name="route_type">
		/// <para>
		/// (Optional)<br/>
		/// Only show routes with the given status: UNPLACED|<br/>
		/// UNPLACED_ALL|UNROUTED|PARTIAL|GAPS|CONFLICTS|<br/>
		/// ANT ENNAS|NODRIVER|MULTI_DRIVER|LOCKED_NODES|<br/>
		/// HAS_ROUTING|INTR ASITE|NOLOADS|HIERPORT|ROUTED<br/>
		/// (ignored if -of_objects is used)<br/>
		/// </para>
		/// </param>
		/// <param name="list_all_nets">
		/// <para>
		/// (Optional)<br/>
		/// list full route information for every net in the design<br/>
		/// (ignored if -of_objects is used)<br/>
		/// </para>
		/// </param>
		/// <param name="show_all">
		/// <para>
		/// (Optional)<br/>
		/// list all relevant pins for routes marked as UNPLACED or<br/>
		/// PARTIAL routes and list all relevant nodes for routes marked<br/>
		/// as ANTENNAS or CONFLICTS routes (by default only the first<br/>
		/// 15 pins or nodes are listed for a route)<br/>
		/// </para>
		/// </param>
		/// <param name="dump_routes">
		/// <para>
		/// (Optional)<br/>
		/// show the full routing tree for every routed net in the design.<br/>
		/// This is VERY VERBOSE.<br/>
		/// </para>
		/// </param>
		/// <param name="has_routing">
		/// <para>
		/// (Optional)<br/>
		/// returns 0 if there is no routing currently stored for this<br/>
		/// design and 1 if there is. All other options are ignored.<br/>
		/// </para>
		/// </param>
		/// <param name="boolean_check">
		/// <para>
		/// (Optional)<br/>
		/// returns 1 if the given flag is true and 0 if it is not. Value flags<br/>
		/// that can be checked are: PLACED_FULLY|<br/>
		/// PARTIALLY_ROUTED|ROUTED_FULLY|ERRORS_IN_ROUT ES.<br/>
		/// All other options are ignored (cannot be used with -<br/>
		/// has_routing).<br/>
		/// </para>
		/// </param>
		/// <param name="ignore_cache">
		/// <para>
		/// (Optional)<br/>
		/// throw away all cached information and recalculate the route<br/>
		/// status for the entire design (slow)<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_route_status(bool? return_nets = null, bool? return_string = null, String file = null, bool? append = null, TCLParameterList of_objects = null, String route_type = null, bool? list_all_nets = null, bool? show_all = null, bool? dump_routes = null, bool? has_routing = null, String boolean_check = null, bool? ignore_cache = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_route_status [-return_nets] [-return_string] [-file <arg>] [-append] [-of_objects <args>] [-route_type <arg>] [-list_all_nets] [-show_all] [-dump_routes] [-has_routing] [-boolean_check <arg>] [-ignore_cache] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_route_status(return_nets, return_string, file, append, of_objects, route_type, list_all_nets, show_all, dump_routes, has_routing, boolean_check, ignore_cache, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report the list of correct SIM_DEVICE attribute values for cell types in the target part<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_sim_device [-part &lt;arg&gt;] [-file &lt;arg&gt;] [-append] [-return_string] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1439<br/>
		/// </para>
		/// </summary>
		/// <param name="part">(Optional) Part</param>
		/// <param name="file">(Optional) Output file</param>
		/// <param name="append">(Optional) Append the results to file</param>
		/// <param name="return_string">(Optional) Return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Report</returns>
		public TTCL report_sim_device(String part = null, String file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_sim_device [-part <arg>] [-file <arg>] [-append] [-return_string] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_sim_device(part, file, append, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Run SSN analysis on the current package and pinout<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_ssn [-name &lt;arg&gt;] [-return_string] [-format &lt;arg&gt;] [-file &lt;arg&gt;] [-append] [-phase] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Perform a simultaneous switching noise (SSN) analysis of the current design. The SSN analysis is<br/>
		/// an accurate method for predicting how output switching affects interface noise margins. The<br/>
		/// calculation and estimates are based on a range of variables intended to identify potential noise-related issues in your design and should not be used as final design "sign off" criteria.<br/>
		/// SSN analysis provides estimates of the disruption that simultaneously switching outputs can<br/>
		/// cause on other output ports in the I/O bank. The SSN predictor incorporates I/O bank-specific<br/>
		/// electrical characteristics into the prediction to better model package effects on SSN.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The report_ssn command can be affected by the temperature grade of the selected device as<br/>
		/// defined by the -grade option of the set_operating_condition command. Setting the<br/>
		/// temperature grade prior to running noise analysis lets you see how noisy signals can be on<br/>
		/// Commercial, Extended, Industrial, Q-Grade, or Military grade devices.<br/>
		/// By default, report_ssn assumes that every port toggles asynchronously. This results in a<br/>
		/// worst-case noise analysis, which may be overly pessimistic. The -phase option lets you consider<br/>
		/// clocking information available in the design to more accurately report SSN noise. Clocks must be<br/>
		/// defined using the create_clock and create_generated_clock commands. The period,<br/>
		/// phase shift and duty cycle of the generated clocks have significant impact on SSN analysis.<br/>
		/// The report_ssn command provides a detailed SSN analysis for Xilinx UltraScale architecture<br/>
		/// devices, Virtex-7, Kintex-7, and Artix-7 devices. The report is returned to the standard output,<br/>
		/// unless the -file, -return_string, or -name arguments are specified.<br/>
		/// TIP: Not all parts support the report_ssn command. The Vivado Design Suite will return an error if you<br/>
		/// run report_ssn on a target part that does not support SSN analysis. You can query the SSN_REPORT<br/>
		/// property of a part to see if it supports the command. Refer to the Examples for more information.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example performs an SSN analysis on the current design, formats the output as<br/>
		/// HTML, and writes the output to the specified file:<br/>
		/// report_ssn -format html -file C:/Data/devSSN.html<br/>
		/// The following example performs an SSN analysis, with phase analysis, and returns the output to a<br/>
		/// string which is stored in the specified variable:<br/>
		/// set devSSN [report_ssn -phase -format html -return_string]<br/>
		/// Note: The -format argument in the preceding example is ignored in the absence of -file.<br/>
		/// The following example queries the part in the current project to see if it supports the<br/>
		/// report_ssn command, and then gets a list of parts from the same part family that support the<br/>
		/// command:<br/>
		/// get_property SSN_REPORT [get_property PART [current_project]]<br/>
		/// get_parts -filter "FAMILY == [get_property FAMILY [get_property PART \<br/>
		/// [current_project]]] &amp;&amp; SSN_REPORT"<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1442<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="return_string">(Optional) Return report as string</param>
		/// <param name="format">(Optional) Report format. Valid arguments are CSV, HTML, TXT Default: csv</param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the report to the specified file</param>
		/// <param name="phase">(Optional) Account for multi-clock phase in the analysis</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>ssn report</returns>
		public TTCL report_ssn(String name = null, bool? return_string = null, String format = null, String file = null, bool? append = null, bool? phase = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_ssn [-name <arg>] [-return_string] [-format <arg>] [-file <arg>] [-append] [-phase] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_ssn(name, return_string, format, file, append, phase, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get switching activity on specified objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_switching_activity [-static_probability] [-signal_rate] [-toggle_rate] [-default_static_probability] [-default_toggle_rate] [-average] [-file &lt;arg&gt;] [-return_string] [-append] [-hier] [-all] [-type &lt;args&gt;] [-quiet] [-verbose] [&lt;objects&gt;...]
		/// <br/>
		/// <para>
		/// This command is used to report different kinds of switching activity on design nets, ports, pins,<br/>
		/// and cells in the current synthesized or implemented design. These include simple signal rate and<br/>
		/// simple static probability on nets, ports, and pins; and state dependent static probabilities on cells.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The reported values are defined using the set_switching_activity command.<br/>
		/// Note: This command returns the switching activity for the specified objects, or the current design.<br/>
		/// By default the report is written to the Tcl console or STD output. However, the results can also<br/>
		/// be written to a file or returned as a string if desired.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the signal_rate and static probability value on all output ports:<br/>
		/// report_switching_activity -signal_rate -static_probability [all_outputs]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example reports the signal_rate and static probability value on all LUT objects in<br/>
		/// the design:<br/>
		/// report_switching_activity -signal_rate -static_probability -type lut -all<br/>
		/// The following example reports the average toggle rate on all output ports:<br/>
		/// report_switching_activity -toggle_rate -average [all_outputs]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1447<br/>
		/// </para>
		/// </summary>
		/// <param name="static_probability">(Optional) report static probability</param>
		/// <param name="signal_rate">(Optional) report signal rate</param>
		/// <param name="toggle_rate">(Optional) report toggle rate</param>
		/// <param name="default_static_probability">(Optional) report default static probability</param>
		/// <param name="default_toggle_rate">(Optional) report default toggle rate</param>
		/// <param name="average">(Optional) Report the average switching activity for the specified objects.</param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="return_string">(Optional) return switching activity as string</param>
		/// <param name="append">(Optional) append switching activity to end of file</param>
		/// <param name="hier">
		/// <para>
		/// (Optional)<br/>
		/// Hierarchically reports the switching activity on nets within a<br/>
		/// hierarchical instance provided via &lt;objects&gt; option.<br/>
		/// </para>
		/// </param>
		/// <param name="all">(Optional) Report switching activities for all nets for the design.</param>
		/// <param name="type">
		/// <para>
		/// (Optional)<br/>
		/// Specify nodes in a specific category. List of valid type values:<br/>
		/// io_output, io_bidir_enable, register, lut_ram, lut, dsp,<br/>
		/// bram_enable, bram_wr_enable, gt_txdata, gt_rxdata.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">(Optional) objects</param>
		public TTCL report_switching_activity(bool? static_probability = null, bool? signal_rate = null, bool? toggle_rate = null, bool? default_static_probability = null, bool? default_toggle_rate = null, bool? average = null, String file = null, bool? return_string = null, bool? append = null, bool? hier = null, bool? all = null, TCLParameterList type = null, bool? quiet = null, bool? verbose = null, TCLParameterList objects = null)
		{
			// TCL Syntax: report_switching_activity [-static_probability] [-signal_rate] [-toggle_rate] [-default_static_probability] [-default_toggle_rate] [-average] [-file <arg>] [-return_string] [-append] [-hier] [-all] [-type <args>] [-quiet] [-verbose] [<objects>...]
			_tcl.Entry(_builder.report_switching_activity(static_probability, signal_rate, toggle_rate, default_static_probability, default_toggle_rate, average, file, return_string, append, hier, all, type, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Compute mean time between failures and display report<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_synchronizer_mtbf [-file &lt;arg&gt;] [-append] [-return_string] [-warn_if_mtbf_below &lt;arg&gt;] [-quiet] [-no_header] [-report_endpoints] [-verbose]
		/// <br/>
		/// <para>
		/// RECOMMENDED: This command is supported for Xilinx UltraScale devices only, and does not support 7<br/>
		/// series devices.<br/>
		/// The report_synchronizer_mtbf command reports mean time between failures (MTBF) of<br/>
		/// each clock domain crossing (CDC) synchronizer chain in a design, and provides an overall MTBF<br/>
		/// covering all synchronizers. Synchronizer registers must have ASYNC_REG properties with value<br/>
		/// TRUE to be properly identified as synchronizers for reporting.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Asynchronous clock domain crossings (CDCs) can fail due to metastability as data is captured<br/>
		/// asynchronously and may settle to different values on different loads in the circuit. Synchronizer<br/>
		/// registers are used to improve overall circuit reliability for designs which contain multiple clock<br/>
		/// domains, in which asynchronous data transfers occur, or in which external asynchronous signals<br/>
		/// are captured with an internal clock. A synchronizer chain consists of two or more registers<br/>
		/// connected sequentially with the first stage capturing the data signal from the asynchronous clock<br/>
		/// domain. The successive register stages provide additional settling time for metastable events and<br/>
		/// increase MTBF. The synchronizer registers must have ASYNC_REG properties with values of<br/>
		/// TRUE. Besides reporting MTBF, the ASYNC_REG properties instruct synthesis, simulation and<br/>
		/// implementation tools to optimize for increased MTBF and improve overall behavior of the<br/>
		/// synchronizer circuit.<br/>
		/// TIP: Avoid using different set/reset or clock enable control signals on registers within a synchronizer chain.<br/>
		/// This command returns the MTBF report, or returns an error if it fails. The command issues a<br/>
		/// warning message when the MTBF cannot be calculated correctly, for example when a CDC is<br/>
		/// improperly constrained. The following conditions result in an UNDEFINED synchronizer MTBF<br/>
		/// value:<br/>
		/// • One or both clocks of the CDC are unconstrained.<br/>
		/// • There is a timing violation involving registers in the synchronizer chain.<br/>
		/// • There is a zero toggle rate detected for the CDC data.<br/>
		/// In the case of a zero toggle rate, it may be necessary to use the set_switching_activity<br/>
		/// command to manually override the toggle rate on the CDC net with a realistic value. This<br/>
		/// involves assigning the Toggle Rate and the Static Probability:<br/>
		/// • Toggle Rate: The number of CDC data signal transitions measured in Million Transitions per<br/>
		/// Second.<br/>
		/// • Static Probability: The percentage of time during which the CDC data signal is driven at a high<br/>
		/// logic level.<br/>
		/// Example: to assign a toggle rate of 12.5% with 0.5 static probability on a CDC net named<br/>
		/// resync[0]:<br/>
		/// set_switching_activity -toggle_rate 12.5 -static_probability 0.5 \<br/>
		/// [get_nets resync[0]]<br/>
		/// The report contents include the following data for each synchronizer chain in the design:<br/>
		/// • MTBF: The Mean Time Between Failures for the CDC synchronizer reported in dynamic time<br/>
		/// units, from seconds to years. An invalid MTBF value is reported as UNDEFINED.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • Data Toggle Rate: The rate at which the CDC data switches, based on the default switching<br/>
		/// activity for the design as reported by report_switching_activity. Measured in (Mts)<br/>
		/// Millions of Transitions per Second. The rate can be overridden using the<br/>
		/// set_switching_activity command targeting the CDC net object.<br/>
		/// • Data Sample Rate: The rate at which the CDC data is sampled, equivalent to the synchronizer<br/>
		/// chain frequency, measured in MHz.<br/>
		/// • Settling Time: The total amount of positive slack in nanoseconds on the timing paths from<br/>
		/// synchronizer register outputs. Higher Settling Time increases MTBF.<br/>
		/// • Sending Domain: The clock domain of the source of the CDC data. A value of<br/>
		/// UNCONSTRAINED is reported if the source clock is not defined.<br/>
		/// • Receiving Domain: The clock domain of the destination of the CDC data. A value of<br/>
		/// UNCONSTRAINED is reported if the destination clock is not defined.<br/>
		/// • Number of Stages: This is the length of the synchronizer chain, which equals the number of<br/>
		/// registers with ASYNC_REG value of TRUE. The MTBF calculation will determine the likelihood<br/>
		/// that the output register or registers (should the fanout be greater than 1) will experience a<br/>
		/// metastable event. For example in a typical synchronizer containing 2 registers with the<br/>
		/// ASYNC_REG property set, the MTBF calculation indicates the probability that the output<br/>
		/// register(s) following the last ASYNC_REG register will capture an incorrect value resulting from<br/>
		/// the metastable event. When a synchronizer is connected to more than 1 output register, the<br/>
		/// minimum slack from all the paths will be used in the MTBF calculation to ensure that all<br/>
		/// registers capture the same logic level.<br/>
		/// • CDC Net Name: This is the logical net name of the CDC data, the data that is captured<br/>
		/// asynchronously.<br/>
		/// This command returns the MTBF report, or returns an error if it fails.<br/>
		/// The report also includes an overall MTBF calculated using the MTBF of all synchronizers in the<br/>
		/// design, calculated as the inverse of the sum of the reciprocals of the individual synchronizer<br/>
		/// MTBF values: (1 / (1/MTBF_1 + 1/MTBF_2 + … + 1/MTBF_N) ) for N synchronizers.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example writes the MTBF report to the specified file:<br/>
		/// report_synchronizer_mtbf -file C:/Data/mtbf_report.txt<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1451<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="return_string">(Optional) Return the report output as a string</param>
		/// <param name="warn_if_mtbf_below">(Optional) Default: 1e+12</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="no_header">(Optional) Report without the header</param>
		/// <param name="report_endpoints">(Optional) Report cdc path end points</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Report</returns>
		public TTCL report_synchronizer_mtbf(String file = null, bool? append = null, bool? return_string = null, String warn_if_mtbf_below = null, bool? quiet = null, bool? no_header = null, bool? report_endpoints = null, bool? verbose = null)
		{
			// TCL Syntax: report_synchronizer_mtbf [-file <arg>] [-append] [-return_string] [-warn_if_mtbf_below <arg>] [-quiet] [-no_header] [-report_endpoints] [-verbose]
			_tcl.Entry(_builder.report_synchronizer_mtbf(file, append, return_string, warn_if_mtbf_below, quiet, no_header, report_endpoints, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report timing paths<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_timing [-from &lt;args&gt;] [-rise_from &lt;args&gt;] [-fall_from &lt;args&gt;] [-to &lt;args&gt;] [-rise_to &lt;args&gt;] [-fall_to &lt;args&gt;] [-through &lt;args&gt;] [-rise_through &lt;args&gt;] [-fall_through &lt;args&gt;] [-delay_type &lt;arg&gt;] [-setup] [-hold] [-max_paths &lt;arg&gt;] [-nworst &lt;arg&gt;] [-unique_pins] [-path_type &lt;arg&gt;] [-input_pins] [-no_header] [-no_reused_label] [-slack_lesser_than &lt;arg&gt;] [-slack_greater_than &lt;arg&gt;] [-group &lt;args&gt;] [-sort_by &lt;arg&gt;] [-no_report_unconstrained] [-user_ignored] [-of_objects &lt;args&gt;] [-significant_digits &lt;arg&gt;] [-column_style &lt;arg&gt;] [-file &lt;arg&gt;] [-append] [-name &lt;arg&gt;] [-no_pr_attribute] [-routable_nets] [-return_string] [-warn_on_violation] [-cells &lt;args&gt;] [-rpx &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// IMPORTANT! If the design has no timing constraints, report_timing reports on unconstrained paths<br/>
		/// in the design. However, if even one path has timing constraints then report_timing only reports on<br/>
		/// the constrained paths in the design, unless unconstrained timing paths are specified by the -from /-to<br/>
		/// options.<br/>
		/// This command performs timing analysis on the specified timing paths of the current Synthesized<br/>
		/// or Implemented Design. By default the tool reports the timing path with the worst calculated<br/>
		/// slack within each path group. However, you can optionally increase the number of paths and<br/>
		/// delays reported with the use of the -nworst or -max_paths arguments.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// TIP: The report_timing can be multi-threaded to speed the process. Refer to the set_param<br/>
		/// command for more information on setting the general.maxThreads parameter.<br/>
		/// The timing engine runs in "quad" timing mode, analyzing min and max delays for both slow and<br/>
		/// fast corners. You can configure the type of analysis performed by the<br/>
		/// config_timing_corners command. However, it is not recommended to change the default<br/>
		/// because this reduces the timing analysis coverage.<br/>
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be<br/>
		/// written to the GUI, to a file, or returned as a string if desired.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the timing for the 5 worst paths in the design, reporting the full<br/>
		/// timing path, including input pins, with timing values:<br/>
		/// report_timing -nworst 5 -path_type full -input_pins<br/>
		/// The following example shows the use of the multiple through points to define both a specific<br/>
		/// path (through state_reg1) and alternate paths (through count_3 or count_4), and writes the<br/>
		/// timing results to the specified file:<br/>
		/// report_timing -from go -through {state_reg1} \<br/>
		/// -through { count_3 count_4 } \<br/>
		/// -to done -path_type summary -file C:/Data/timing1.txt<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1455<br/>
		/// </para>
		/// </summary>
		/// <param name="from">(Optional) From pins, ports, cells or clocks</param>
		/// <param name="rise_from">(Optional) Rising from pins, ports, cells or clocks</param>
		/// <param name="fall_from">(Optional) Falling from pins, ports, cells or clocks</param>
		/// <param name="to">(Optional) To pins, ports, cells or clocks</param>
		/// <param name="rise_to">(Optional) Rising to pins, ports, cells or clocks</param>
		/// <param name="fall_to">(Optional) Falling to pins, ports, cells or clocks</param>
		/// <param name="through">(Optional) Through pins, ports, cells or nets</param>
		/// <param name="rise_through">(Optional) Rising through pins, ports, cells or nets</param>
		/// <param name="fall_through">(Optional) Falling through pins, ports, cells or nets</param>
		/// <param name="delay_type">
		/// <para>
		/// (Optional)<br/>
		/// Type of path delay: Values: max, min, min_max, max_rise,<br/>
		/// max_fall, min_rise, min_fall Default: max<br/>
		/// </para>
		/// </param>
		/// <param name="setup">(Optional) Report max delay timing paths (equivalent to -delay_type max)</param>
		/// <param name="hold">(Optional) Report min delay timing paths (equivalent to -delay_type min)</param>
		/// <param name="max_paths">
		/// <para>
		/// (Optional)<br/>
		/// Maximum number of paths to output when sorted by slack,<br/>
		/// or per path group when sorted by group: Value &gt;=1 Default:<br/>
		/// 1<br/>
		/// </para>
		/// </param>
		/// <param name="nworst">(Optional) List up to N worst paths to endpoint: Value &gt;=1 Default: 1</param>
		/// <param name="unique_pins">(Optional) for each unique set of pins, show at most 1 path per path group</param>
		/// <param name="path_type">
		/// <para>
		/// (Optional)<br/>
		/// Format for path report: Values: end, summary, short, full,<br/>
		/// full_clock, full_clock_expanded Default: full_clock_expanded<br/>
		/// </para>
		/// </param>
		/// <param name="input_pins">(Optional) Show input pins in path</param>
		/// <param name="no_header">(Optional) Do not generate a report header</param>
		/// <param name="no_reused_label">
		/// <para>
		/// (Optional)<br/>
		/// Do not label reuse status on pins in the report<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Name Description<br/>
		/// </para>
		/// </param>
		/// <param name="slack_lesser_than">(Optional) Display paths with slack less than this Default: 1e+30</param>
		/// <param name="slack_greater_than">(Optional) Display paths with slack greater than this Default: -1e+30</param>
		/// <param name="group">(Optional) Limit report to paths in this group(s)</param>
		/// <param name="sort_by">(Optional) Sorting order of paths: Values: group, slack Default: slack</param>
		/// <param name="no_report_unconstrained">(Optional) Do not report infinite slack paths</param>
		/// <param name="user_ignored">
		/// <para>
		/// (Optional)<br/>
		/// Only report paths which have infinite slack because of<br/>
		/// set_false_path or set_clock_groups timing constraints<br/>
		/// </para>
		/// </param>
		/// <param name="of_objects">(Optional) Report timing for these paths</param>
		/// <param name="significant_digits">(Optional) Number of digits to display: Range: 0 to 3 Default: 3</param>
		/// <param name="column_style">
		/// <para>
		/// (Optional)<br/>
		/// style for path report columns: Values: variable_width,<br/>
		/// anchor_left, fixed_width Default: anchor_left<br/>
		/// </para>
		/// </param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="no_pr_attribute">
		/// <para>
		/// (Optional)<br/>
		/// for Dynamic Function eXchange designs, do not report<br/>
		/// whether netlist resources are in the static or reconfigurable<br/>
		/// regions<br/>
		/// </para>
		/// </param>
		/// <param name="routable_nets">
		/// <para>
		/// (Optional)<br/>
		/// store the number of routable nets traversed as a property<br/>
		/// on timing paths.<br/>
		/// </para>
		/// </param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="warn_on_violation">(Optional) issue a critical warning when the report contains a timing violation</param>
		/// <param name="cells">(Optional) run report_timing on the specified cell(s)</param>
		/// <param name="rpx">(Optional) Filename to output interactive results to.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_timing(TCLParameterList from = null, TCLParameterList rise_from = null, TCLParameterList fall_from = null, TCLParameterList to = null, TCLParameterList rise_to = null, TCLParameterList fall_to = null, TCLParameterList through = null, TCLParameterList rise_through = null, TCLParameterList fall_through = null, report_timing_delay_type? delay_type = null, bool? setup = null, bool? hold = null, Int32? max_paths = null, String nworst = null, bool? unique_pins = null, report_timing_path_type? path_type = null, bool? input_pins = null, bool? no_header = null, bool? no_reused_label = null, String slack_lesser_than = null, String slack_greater_than = null, TCLParameterList group = null, report_timing_sort_by? sort_by = null, bool? no_report_unconstrained = null, bool? user_ignored = null, TCLParameterList of_objects = null, Int32? significant_digits = null, report_timing_column_style? column_style = null, String file = null, bool? append = null, String name = null, bool? no_pr_attribute = null, bool? routable_nets = null, bool? return_string = null, bool? warn_on_violation = null, TCLParameterList cells = null, String rpx = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_timing [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-through <args>] [-rise_through <args>] [-fall_through <args>] [-delay_type <arg>] [-setup] [-hold] [-max_paths <arg>] [-nworst <arg>] [-unique_pins] [-path_type <arg>] [-input_pins] [-no_header] [-no_reused_label] [-slack_lesser_than <arg>] [-slack_greater_than <arg>] [-group <args>] [-sort_by <arg>] [-no_report_unconstrained] [-user_ignored] [-of_objects <args>] [-significant_digits <arg>] [-column_style <arg>] [-file <arg>] [-append] [-name <arg>] [-no_pr_attribute] [-routable_nets] [-return_string] [-warn_on_violation] [-cells <args>] [-rpx <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_timing(from, rise_from, fall_from, to, rise_to, fall_to, through, rise_through, fall_through, delay_type, setup, hold, max_paths, nworst, unique_pins, path_type, input_pins, no_header, no_reused_label, slack_lesser_than, slack_greater_than, group, sort_by, no_report_unconstrained, user_ignored, of_objects, significant_digits, column_style, file, append, name, no_pr_attribute, routable_nets, return_string, warn_on_violation, cells, rpx, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report timing summary<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_timing_summary [-check_timing_verbose] [-delay_type &lt;arg&gt;] [-no_detailed_paths] [-setup] [-hold] [-max_paths &lt;arg&gt;] [-nworst &lt;arg&gt;] [-unique_pins] [-path_type &lt;arg&gt;] [-no_reused_label] [-input_pins] [-no_pr_attribute] [-routable_nets] [-slack_lesser_than &lt;arg&gt;] [-report_unconstrained] [-significant_digits &lt;arg&gt;] [-no_header] [-file &lt;arg&gt;] [-append] [-name &lt;arg&gt;] [-return_string] [-warn_on_violation] [-datasheet] [-cells &lt;args&gt;] [-rpx &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// TIP: The report_timing_summary can be multi-threaded to speed the process. Refer to the<br/>
		/// set_param command for more information on setting the general.maxThreads parameter.<br/>
		/// Generate a timing summary to help understand if the design has met timing requirements. The<br/>
		/// timing summary can be run on an open Synthesized or Implemented Design.<br/>
		/// The timing summary report includes the following information:<br/>
		/// • Timer Settings - Details the timing engine settings used to generate the timing information in<br/>
		/// the report.<br/>
		/// • Check Timing - Contains the same information that is produced by the check_timing<br/>
		/// command, which summarizes potential timing issues.<br/>
		/// • Design Timing Summary - Provides a summary of the timing of the design, including values for<br/>
		/// worst and total negative slack (WNS/TNS), worst and total hold slack (WHS/THS), and<br/>
		/// component switching limits (CSL).<br/>
		/// • Clock Definitions - Contains the same information that is produced by the report_clocks<br/>
		/// command, showing all the clocks that were created for the design, either by create_clock,<br/>
		/// create_generated_clock, or automatically by the tool.<br/>
		/// • Intra-Clock Table - Summarizes timing paths with the same source and destination clocks.<br/>
		/// • Inter-Clock Table - Summarizes timing paths with different source and destination clocks.<br/>
		/// • Path Group Table - Shows default path groups and user-defined path groups created by the<br/>
		/// group_path command.<br/>
		/// • Timing Details - Contains detailed timing paths, both max delay and min delay, as well as<br/>
		/// component switching limits for each clock defined, similar to the report_timing command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • Data sheet - Contains the same information that is produced by the report_datasheet<br/>
		/// command. It contains the timing characteristics of a design at the I/O ports. The data sheet<br/>
		/// information is added to the summary report only when the -datasheet option is specified.<br/>
		/// This command is automatically run during implementation as part of the launch_runs<br/>
		/// command.<br/>
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be<br/>
		/// written to a file or returned as a string if desired.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the timing summary of the current design:<br/>
		/// report_timing_summary<br/>
		/// The following example reports the hold timing summary of the current design, including<br/>
		/// unconstrained paths, with the specified options:<br/>
		/// report_timing_summary -delay_type min -path_type full_clock_expanded \<br/>
		/// -report_unconstrained -max_paths 2 -nworst 1 -significant_digits 2 \<br/>
		/// -input_pins -name {timing_6}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1462<br/>
		/// </para>
		/// </summary>
		/// <param name="check_timing_verbose">
		/// <para>
		/// (Optional)<br/>
		/// produce a verbose report when checking the design for<br/>
		/// potential timing problems<br/>
		/// </para>
		/// </param>
		/// <param name="delay_type">(Optional) Type of path delay: Values: max, min, min_max Default: min_max</param>
		/// <param name="no_detailed_paths">(Optional) do not report timing paths for each clock and path group analyzed</param>
		/// <param name="setup">(Optional) Report max delay timing paths (equivalent to -delay_type max)</param>
		/// <param name="hold">(Optional) Report min delay timing paths (equivalent to -delay_type min)</param>
		/// <param name="max_paths">
		/// <para>
		/// (Optional)<br/>
		/// Maximum number of paths to report per clock or path<br/>
		/// group: Value &gt;=1 Default: 1<br/>
		/// </para>
		/// </param>
		/// <param name="nworst">(Optional) List up to N worst paths to endpoint: Value &gt;=1 Default: 1</param>
		/// <param name="unique_pins">(Optional) for each unique set of pins, show at most 1 path per path group</param>
		/// <param name="path_type">
		/// <para>
		/// (Optional)<br/>
		/// Format for path report: Values: end summary short full<br/>
		/// full_clock full_clock_expanded Default: full_clock_expanded<br/>
		/// </para>
		/// </param>
		/// <param name="no_reused_label">(Optional) Do not label reuse status on pins in the report</param>
		/// <param name="input_pins">(Optional) Show input pins in path</param>
		/// <param name="no_pr_attribute">
		/// <para>
		/// (Optional)<br/>
		/// for Dynamic Function eXchange designs, do not report<br/>
		/// whether netlist resources are in the static or reconfigurable<br/>
		/// regions<br/>
		/// </para>
		/// </param>
		/// <param name="routable_nets">
		/// <para>
		/// (Optional)<br/>
		/// store the number of routable nets traversed as a property<br/>
		/// on timing paths.<br/>
		/// </para>
		/// </param>
		/// <param name="slack_lesser_than">(Optional) Display paths with slack less than this Default: 1e+30</param>
		/// <param name="report_unconstrained">(Optional) report unconstrained and user ignored paths</param>
		/// <param name="significant_digits">(Optional) Number of digits to display: Range: 0 to 3 Default: 3</param>
		/// <param name="no_header">(Optional) do not generate a report header</param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Name Description<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="warn_on_violation">(Optional) issue a critical warning when the report contains a timing violation</param>
		/// <param name="datasheet">(Optional) Include data sheet report</param>
		/// <param name="cells">(Optional) run report_timing_summary on the specified cell(s)</param>
		/// <param name="rpx">(Optional) Filename to output interactive results to.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_timing_summary(bool? check_timing_verbose = null, report_timing_summary_delay_type? delay_type = null, bool? no_detailed_paths = null, bool? setup = null, bool? hold = null, Int32? max_paths = null, String nworst = null, bool? unique_pins = null, String path_type = null, bool? no_reused_label = null, bool? input_pins = null, bool? no_pr_attribute = null, bool? routable_nets = null, String slack_lesser_than = null, bool? report_unconstrained = null, Int32? significant_digits = null, bool? no_header = null, String file = null, bool? append = null, String name = null, bool? return_string = null, bool? warn_on_violation = null, bool? datasheet = null, TCLParameterList cells = null, String rpx = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_timing_summary [-check_timing_verbose] [-delay_type <arg>] [-no_detailed_paths] [-setup] [-hold] [-max_paths <arg>] [-nworst <arg>] [-unique_pins] [-path_type <arg>] [-no_reused_label] [-input_pins] [-no_pr_attribute] [-routable_nets] [-slack_lesser_than <arg>] [-report_unconstrained] [-significant_digits <arg>] [-no_header] [-file <arg>] [-append] [-name <arg>] [-return_string] [-warn_on_violation] [-datasheet] [-cells <args>] [-rpx <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_timing_summary(check_timing_verbose, delay_type, no_detailed_paths, setup, hold, max_paths, nworst, unique_pins, path_type, no_reused_label, input_pins, no_pr_attribute, routable_nets, slack_lesser_than, report_unconstrained, significant_digits, no_header, file, append, name, return_string, warn_on_violation, datasheet, cells, rpx, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report details of Unisim primitive transformations.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_transformed_primitives [-file &lt;arg&gt;] [-append] [-return_string] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Report the transformed primitives in the current design.<br/>
		/// As part of the process of opening the Synthesized design, and loading it into memory, the tool<br/>
		/// will transform legacy netlist primitives to the supported subset of Unisim primitives.<br/>
		/// As a default this report will be written to the standard output. However, the report can also be<br/>
		/// written to a file or returned to a Tcl string variable for further processing.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the transformed primitives in the current design, and returns the<br/>
		/// result to the specified Tcl variable:<br/>
		/// set transPrim [ report_transformed_primitives -return_string ]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1468<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Optional) Output file</param>
		/// <param name="append">(Optional) Append the results to file</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_transformed_primitives(String file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_transformed_primitives [-file <arg>] [-append] [-return_string] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_transformed_primitives(file, append, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Compute utilization of device and display report<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_utilization [-file &lt;arg&gt;] [-append] [-pblocks &lt;args&gt;] [-evaluate_pblock] [-exclude_child_pblocks] [-exclude_non_assigned] [-cells &lt;args&gt;] [-return_string] [-slr] [-packthru] [-name &lt;arg&gt;] [-no_primitives] [-omit_locs] [-hierarchical] [-spreadsheet_file &lt;arg&gt;] [-spreadsheet_table &lt;arg&gt;] [-spreadsheet_depth &lt;arg&gt;] [-hierarchical_depth &lt;arg&gt;] [-hierarchical_percentages] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Report resource usage on the target part by the current synthesized or implemented design. The<br/>
		/// report is returned to the standard output, unless the -file, -return_string, or -name<br/>
		/// arguments are specified.<br/>
		/// TIP: Though resource usage can be reported early in the design process, the report will be more accurate<br/>
		/// as the design progresses from synthesis through implementation.<br/>
		/// This command returns the requested information, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the resources collectively utilized by all the Pblocks in the design,<br/>
		/// and writes the results to the specified file:<br/>
		/// report_utilization -pblocks [get_pblocks] -file C:/Data/pblocks_util.txt<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This example reports the utilization for the whole design to the named report in the GUI, but<br/>
		/// exports the "Clocking - BUFGCTRL" table to the specified spreadsheet file:<br/>
		/// report_utilization -name utilization_1 -spreadsheet_file util_table.xlsx \<br/>
		/// -spreadsheet_table "Clocking - BUFGCTRL"<br/>
		/// The following example reports the resources utilized by each Pblock in the design, appending the<br/>
		/// report for each Pblock to a single specified file:<br/>
		/// foreach x [get_pblocks] {<br/>
		/// puts "Reporting Pblock: $x ----------------------------------"<br/>
		/// report_utilization -append -file C:/Data/pblocks_util.txt -pblocks $x<br/>
		/// }<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1470<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="pblocks">(Optional) Report utilization of given pblock</param>
		/// <param name="evaluate_pblock">
		/// <para>
		/// (Optional)<br/>
		/// Report utilization with demand as specified cells and supply<br/>
		/// as specified pblock area<br/>
		/// </para>
		/// </param>
		/// <param name="exclude_child_pblocks">(Optional) Report utilization with out child pblocks</param>
		/// <param name="exclude_non_assigned">(Optional) Pblock utilization with out Non-assigned Cells</param>
		/// <param name="cells">(Optional) Report utilization of given list of cells</param>
		/// <param name="return_string">(Optional) Return report as string</param>
		/// <param name="slr">(Optional) SLR wise utilization of resources</param>
		/// <param name="packthru">(Optional) Reports LUTs used exclusively as pack-thru</param>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="no_primitives">(Optional) Removes "Primitives Section" from report_utilization o/p.</param>
		/// <param name="omit_locs">(Optional) Removes "Loced" column from report_utilization o/p.</param>
		/// <param name="hierarchical">(Optional) Generates text-based hierarchical report.</param>
		/// <param name="spreadsheet_file">
		/// <para>
		/// (Optional)<br/>
		/// Specify file for exporting utilization tables as spreadsheets.<br/>
		/// This feature is available only in GUI mode.<br/>
		/// </para>
		/// </param>
		/// <param name="spreadsheet_table">
		/// <para>
		/// (Optional)<br/>
		/// Choose a particular utilization table to export as<br/>
		/// spreadsheet file. Default value : Hierarchy<br/>
		/// </para>
		/// </param>
		/// <param name="spreadsheet_depth">
		/// <para>
		/// (Optional)<br/>
		/// Specifies the depth level for spreadsheet. Default value : 8<br/>
		/// Default: 8<br/>
		/// </para>
		/// </param>
		/// <param name="hierarchical_depth">(Optional) Specifies the depth level for textual hierarchical report Default: 0</param>
		/// <param name="hierarchical_percentages">
		/// <para>
		/// (Optional)<br/>
		/// Report percentages in textual hierarchical report<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Name Description<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Report</returns>
		public TTCL report_utilization(String file = null, bool? append = null, TCLParameterList pblocks = null, bool? evaluate_pblock = null, bool? exclude_child_pblocks = null, bool? exclude_non_assigned = null, TCLParameterList cells = null, bool? return_string = null, bool? slr = null, bool? packthru = null, String name = null, bool? no_primitives = null, bool? omit_locs = null, bool? hierarchical = null, String spreadsheet_file = null, String spreadsheet_table = null, String spreadsheet_depth = null, String hierarchical_depth = null, bool? hierarchical_percentages = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_utilization [-file <arg>] [-append] [-pblocks <args>] [-evaluate_pblock] [-exclude_child_pblocks] [-exclude_non_assigned] [-cells <args>] [-return_string] [-slr] [-packthru] [-name <arg>] [-no_primitives] [-omit_locs] [-hierarchical] [-spreadsheet_file <arg>] [-spreadsheet_table <arg>] [-spreadsheet_depth <arg>] [-hierarchical_depth <arg>] [-hierarchical_percentages] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_utilization(file, append, pblocks, evaluate_pblock, exclude_child_pblocks, exclude_non_assigned, cells, return_string, slr, packthru, name, no_primitives, omit_locs, hierarchical, spreadsheet_file, spreadsheet_table, spreadsheet_depth, hierarchical_depth, hierarchical_percentages, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report status of DRC/METHODOLOGY/CDC message waivers<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_waivers [-file &lt;arg&gt;] [-type &lt;arg&gt;] [-write_valid_waivers] [-write_ignored_waivers] [-append] [-return_string] [-show_msgs_with_no_waivers] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Reports DRC, METHODOLOGY, and CDC violation messages and displays what waivers are in<br/>
		/// place in the current design.<br/>
		/// In addition, the report_drc, report_methodology, and report_cdc commands have<br/>
		/// options to run the reports on waived violations or checks.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example reports all waivers in the current design:<br/>
		/// report_waivers<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1477<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Optional) Name of file to report waivers</param>
		/// <param name="type">(Optional) Type of waiver - ALL, DRC, METHODOLOGY, CDC</param>
		/// <param name="write_valid_waivers">
		/// <para>
		/// (Optional)<br/>
		/// (special) Specifies writing out the specific waivers which<br/>
		/// were used in the last report_drc/methodology/cdc run(s)<br/>
		/// </para>
		/// </param>
		/// <param name="write_ignored_waivers">
		/// <para>
		/// (Optional)<br/>
		/// (special) Specifies writing out the specific waivers which<br/>
		/// were NOT used in the last report_drc/methodology/cdc<br/>
		/// run(s)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the current report results to the file specified with - file</param>
		/// <param name="return_string">(Optional) Return report results as a string object</param>
		/// <param name="show_msgs_with_no_waivers">
		/// <para>
		/// (Optional)<br/>
		/// also list report_drc/methodology/cdc messages which have<br/>
		/// no defined waivers<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_waivers(String file = null, String type = null, bool? write_valid_waivers = null, bool? write_ignored_waivers = null, bool? append = null, bool? return_string = null, bool? show_msgs_with_no_waivers = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_waivers [-file <arg>] [-type <arg>] [-write_valid_waivers] [-write_ignored_waivers] [-append] [-return_string] [-show_msgs_with_no_waivers] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_waivers(file, type, write_valid_waivers, write_ignored_waivers, append, return_string, show_msgs_with_no_waivers, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove DRC report<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_drc [-name &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Clear the DRC results from the specified named result set.<br/>
		/// This command operates silently, returning nothing if successful, or returning an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example clears the specified results set from memory and the GUI:<br/>
		/// reset_drc -name DRC1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1480<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Optional) DRC result name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_drc(String name = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_drc [-name <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.reset_drc(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove Methodology report<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_methodology [-name &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Clear the methodology results from the specified named result set.<br/>
		/// This command operates silently, returning nothing if successful, or returning an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example clears the specified results set from memory and the GUI:<br/>
		/// reset_methodology -name ultrafast_methodology_3<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1494<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Optional) Methodology result name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_methodology(String name = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_methodology [-name <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.reset_methodology(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Resets or removes a message control rule previously defined by the set_msg_config command.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_msg_config [-string &lt;args&gt;] [-id &lt;arg&gt;] [-severity &lt;arg&gt;] [-limit] [-suppress] [-count] [-default_severity] [-regexp] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This command restores the default settings of the message limits or severity for messages<br/>
		/// returned by the Vivado tool, or can unsuppress previously suppressed messages, as configured<br/>
		/// by the set_msg_config command.<br/>
		/// You can only perform one reset action for each reset_msg_config command. An error is<br/>
		/// returned if more than one action is attempted in a single reset_msg_config command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Message qualifiers of string, ID, and severity are used to determine which messages are reset by<br/>
		/// the reset_msg_config command. Multiple qualifiers have an AND relationship; only the<br/>
		/// messages matching the qualifiers will be reset.<br/>
		/// Note: You must supply at least one message qualifier to identify a message or group of messages to apply<br/>
		/// the command to, or an error is returned.<br/>
		/// To report the current rule configurations for messages, use the get_msg_config command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example changes the severity of the specified message ID to a Critical Warning,<br/>
		/// and then resets the message to its default severity:<br/>
		/// set_msg_config -id "Common 17-81" -new_severity "CRITICAL WARNING"<br/>
		/// reset_msg_config -id "Common 17-81" -default_severity<br/>
		/// This example changes the severity of messages with the specified message ID, gets the current<br/>
		/// message configuration rules, and then shows two different command forms to reset the specific<br/>
		/// rule and restore the message:<br/>
		/// set_msg_config -id "Common 17-361" -severity INFO -new_severity WARNING<br/>
		/// get_msg_config -rules<br/>
		/// ---------------------<br/>
		/// Message control rules currently in effect are:<br/>
		/// Rule Name Rule Current<br/>
		/// Message Count<br/>
		/// 1 set_msg_config -ruleid {1} -id {Common 17-361} -severity {INFO} -<br/>
		/// new_severity {WARNING} 0<br/>
		/// ---------------------<br/>
		/// reset_msg_config -id "Common 17-361" -default_severity<br/>
		/// reset_msg_config -ruleid {1}<br/>
		/// TIP: In the preceding example, only one of the reset_msg_config commands is needed to reset the<br/>
		/// message.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1498<br/>
		/// </para>
		/// </summary>
		/// <param name="string">
		/// <para>
		/// (Optional)<br/>
		/// A qualifier, only a rule created with a matching string<br/>
		/// qualifier will be reset/removed Default: empty<br/>
		/// </para>
		/// </param>
		/// <param name="id">
		/// <para>
		/// (Optional)<br/>
		/// A qualifier, only a rule created with a matching id qualifier<br/>
		/// will be reset/removed<br/>
		/// </para>
		/// </param>
		/// <param name="severity">
		/// <para>
		/// (Optional)<br/>
		/// A qualifier, only a rule created with a matching severity<br/>
		/// qualifier will be reset/removed<br/>
		/// </para>
		/// </param>
		/// <param name="limit">
		/// <para>
		/// (Optional)<br/>
		/// reset the limit values for message controls that match the<br/>
		/// given qualifiers for the current project<br/>
		/// </para>
		/// </param>
		/// <param name="suppress">
		/// <para>
		/// (Optional)<br/>
		/// stop suppressing messages that match the given qualifiers<br/>
		/// for the current project<br/>
		/// </para>
		/// </param>
		/// <param name="count">
		/// <para>
		/// (Optional)<br/>
		/// reset the count of messages for all message controls that<br/>
		/// match the given qualifiers for the current project. This will<br/>
		/// prevent messages from being suppressed by a -limit control<br/>
		/// until the message count once again exceeds the specified<br/>
		/// limit.<br/>
		/// </para>
		/// </param>
		/// <param name="default_severity">
		/// <para>
		/// (Optional)<br/>
		/// reset the message severity of all messages controls for the<br/>
		/// current project that match the given qualifiers to their<br/>
		/// default value<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) The values used for -string are full regular expressions</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_msg_config(TCLParameterList @string = null, String id = null, String severity = null, bool? limit = null, bool? suppress = null, bool? count = null, bool? default_severity = null, bool? regexp = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_msg_config [-string <args>] [-id <arg>] [-severity <arg>] [-limit] [-suppress] [-count] [-default_severity] [-regexp] [-quiet] [-verbose]
			_tcl.Entry(_builder.reset_msg_config(@string, id, severity, limit, suppress, count, default_severity, regexp, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Reset message count<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_msg_count [-quiet] [-verbose] &lt;id&gt;
		/// <br/>
		/// <para>
		/// Reset the message count for the specified message ID to 0. This restarts the message counter<br/>
		/// toward the specified message limit. This can be used to reset the count of specific messages that<br/>
		/// may be reaching the limit, or reset the count of all messages returned by the tool.<br/>
		/// Every message delivered by the tool has a unique global message ID that consists of an<br/>
		/// application sub-system code and a message identifier. This results in a message ID that looks like<br/>
		/// the following:<br/>
		/// "Common 17-54"<br/>
		/// "Netlist 29-28"<br/>
		/// "Synth 8-3295"<br/>
		/// You can get the current message count for a specific message ID using the get_msg_count<br/>
		/// command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example resets the message count for all messages:<br/>
		/// reset_msg_count *<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1502<br/>
		/// </para>
		/// </summary>
		/// <param name="id">
		/// <para>
		/// (Required)<br/>
		/// Unique message Id to be reset, e.g. "Common 17-99".<br/>
		/// "reset_msg_count -id *" reset all counters<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>new message count</returns>
		public TTCL reset_msg_count(String id, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_msg_count [-quiet] [-verbose] <id>
			_tcl.Entry(_builder.reset_msg_count(id, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Clear a SSN results set from memory<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_ssn [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Clear the SSN results from the specified named result set.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example clears the specified results set from memory:<br/>
		/// reset_ssn SSN1<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1516<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of the set of results</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_ssn(String name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_ssn [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.reset_ssn(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Resets the timing information on the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_timing [-invalid] [-clock_reservation] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Reset the timing data and constraints for the current design. Use this command to clear the<br/>
		/// current in-memory timing data and constraints, and force the timing engine to reevaluate the<br/>
		/// design comprehensively rather than iteratively.<br/>
		/// After clearing the constraints from the in-memory design, you must reload any needed<br/>
		/// constraints using the read_xdc command. The Vivado tool will not automatically reload the<br/>
		/// constraints.<br/>
		/// TIP: This command deletes the in-memory timing view, not the timing report. Use the<br/>
		/// delete_timing_results command to delete the reported timing information.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example clears the current timing data from memory, including any invalid timing<br/>
		/// constraints:<br/>
		/// reset_timing -invalid<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1523<br/>
		/// </para>
		/// </summary>
		/// <param name="invalid">
		/// <para>
		/// (Optional)<br/>
		/// Resets invalid timing constraints in addition to valid timing<br/>
		/// constraints.<br/>
		/// </para>
		/// </param>
		/// <param name="clock_reservation">
		/// <para>
		/// (Optional)<br/>
		/// Resets clock name reservations for auto-derived clocks in<br/>
		/// addition to valid timing constraints.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_timing(bool? invalid = null, bool? clock_reservation = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_timing [-invalid] [-clock_reservation] [-quiet] [-verbose]
			_tcl.Entry(_builder.reset_timing(invalid, clock_reservation, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Configure how the Vivado tool will display and manage specific messages, based on message ID,<br/>
		/// string, or severity.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_msg_config [-id &lt;arg&gt;] [-string &lt;args&gt;] [-severity &lt;arg&gt;] [-limit &lt;arg&gt;] [-new_severity &lt;arg&gt;] [-suppress] [-regexp] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This command lets you configure the messages returned by the Vivado tool in the current<br/>
		/// project. Use this command to change the severity of messages, to limit the number of times a<br/>
		/// message is reported, or to suppress the message altogether. However, you can only perform one<br/>
		/// of these actions at one time with set_msg_config:<br/>
		/// • Customize the severity of messages returned by the tool to specific levels appropriate to your<br/>
		/// usage. For instance, set the severity of a specified message ID from one type, such as<br/>
		/// WARNING, to another type, such as ERROR.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// IMPORTANT! You cannot downgrade a Vivado Design System ERROR message to make it less than an<br/>
		/// error.<br/>
		/// • Define the number of messages that will be returned by the tool during a design session, or<br/>
		/// single invocation. You can specify the limit of a specific message ID, or the limit for a specific<br/>
		/// severity of messages.<br/>
		/// TIP: The default message limit for all message IDs is set to 100, and is defined by the parameter<br/>
		/// messaging.defaultLimit . This is the limit applied to each separate message returned by the<br/>
		/// tool. You can report the current value of this parameter with the get_param command, and change it<br/>
		/// as needed using the set_param command.<br/>
		/// • Suppress a specific message ID from being reported by the tool at all. You can enable<br/>
		/// messages that were previously suppressed using the reset_msg_config command.<br/>
		/// • An error is returned if more than one action is attempted in a single set_msg_config<br/>
		/// command.<br/>
		/// Message qualifiers of string, ID, and severity are used to determine which messages are<br/>
		/// configured by the set_msg_config command. You must supply at least one message qualifier<br/>
		/// to identify a message or group of messages to apply the command to. Multiple qualifiers have an<br/>
		/// AND relationship; the configuration rule will be applied only to messages matching all qualifiers.<br/>
		/// TIP: set_msg_config does not support the use of wildcards in message qualifiers.<br/>
		/// Message configuration rules are project specific, and are persistent with the project when the<br/>
		/// project is closed and reopened.<br/>
		/// IMPORTANT! Message configuration rules apply to the current project and are passed automatically to<br/>
		/// subordinate processes, such as synthesis and implementation runs. Do not use set_msg_config in pre<br/>
		/// and post Tcl scripts.<br/>
		/// Use the get_msg_config command to report the current configuration of a specific message,<br/>
		/// or the configuration rules defined in the current project. Restore messages to their default<br/>
		/// configurations using the reset_msg_config command.<br/>
		/// The set_msg_config command is not supported by report_cdc as that command does not<br/>
		/// generate messages through the message manager.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example elevates a common INFO message to a Critical Warning:<br/>
		/// set_msg_config -id {[Common 17-81]} -new_severity "CRITICAL WARNING"<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// IMPORTANT! In the following example the "Common 17-69" message is an ERROR message, and cannot<br/>
		/// be downgraded from an ERROR. The command in this example appears to work when run from the Tcl<br/>
		/// console, however it will not result in any change.<br/>
		/// set_msg_config -id {[Common 17-69]} -new_severity WARNING<br/>
		/// When the "Common 17-69" message is next thrown by the Vivado tool, a warning message is returned<br/>
		/// stating that an error cannot be downgraded, and the message is thrown as an ERROR:<br/>
		/// WARNING: [Common 17-239] ERROR Messages are prohibited to be<br/>
		/// downgraded.<br/>
		/// Message 'Common 17-69' is not downgraded.<br/>
		/// ERROR: [Common 17-69] Command failed: report_design_analysis<br/>
		/// -critical_paths can be run only after synthesis has successfully<br/>
		/// completed.<br/>
		/// The following example results in warning messages with message ID "17-35", and containing "clk"<br/>
		/// in the message, being redefined as Error messages:<br/>
		/// set_msg_config -severity warning -string "clk" -id "17-35" \<br/>
		/// -new_severity error<br/>
		/// This example changes the severity of messages with the specified message ID, gets the current<br/>
		/// message configuration rules, and then shows two different command forms to reset the specific<br/>
		/// rule and restore the message:<br/>
		/// set_msg_config -id "Common 17-361" -severity INFO -new_severity WARNING<br/>
		/// get_msg_config -rules<br/>
		/// ---------------------<br/>
		/// Message control rules currently in effect are:<br/>
		/// Rule Name Rule Current<br/>
		/// Message Count<br/>
		/// 1 set_msg_config -ruleid {1} -id {Common 17-361} -severity {INFO} -<br/>
		/// new_severity {WARNING} 0<br/>
		/// ---------------------<br/>
		/// reset_msg_config -id "Common 17-361" -default_severity<br/>
		/// reset_msg_config -ruleid {1}<br/>
		/// TIP: In the preceding example, only one of the reset_msg_config commands is needed to reset the<br/>
		/// message.<br/>
		/// This example shows the use of a parameter to change the default message limit, and then defines<br/>
		/// a new limit for the specified message id:<br/>
		/// get_param messaging.defaultLimit<br/>
		/// 100<br/>
		/// set_param messaging.defaultLimit 1000<br/>
		/// set_msg_config -id {[Common 17-81]} -limit 1500<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1652<br/>
		/// </para>
		/// </summary>
		/// <param name="id">
		/// <para>
		/// (Optional)<br/>
		/// A qualifier, apply the selected operation only to messages<br/>
		/// that match given message id. Example: '-id {Common<br/>
		/// 17-35}'. Default: match any id<br/>
		/// </para>
		/// </param>
		/// <param name="string">
		/// <para>
		/// (Optional)<br/>
		/// A qualifier, apply the selected operation only to messages<br/>
		/// that contain the given list of strings. Default: none<br/>
		/// </para>
		/// </param>
		/// <param name="severity">
		/// <para>
		/// (Optional)<br/>
		/// A qualifier, apply the selected operation only to messages at<br/>
		/// the given severity level. Example: '-severity INFO' Default:<br/>
		/// match any severity<br/>
		/// </para>
		/// </param>
		/// <param name="limit">
		/// <para>
		/// (Optional)<br/>
		/// for the messages that match the qualifiers, limit the number<br/>
		/// of messages displayed to the given integer value. Can only<br/>
		/// be used in conjunction with one of -id or -severity.<br/>
		/// </para>
		/// </param>
		/// <param name="new_severity">
		/// <para>
		/// (Optional)<br/>
		/// for the messages that match the qualifiers, change the<br/>
		/// severity to the given value for the current project<br/>
		/// </para>
		/// </param>
		/// <param name="suppress">
		/// <para>
		/// (Optional)<br/>
		/// for the messages that match the qualifiers, suppress (do not<br/>
		/// display) any messages for the current project<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) The values used for -string are full regular expressions</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_msg_config(String id = null, TCLParameterList @string = null, String severity = null, Int32? limit = null, String new_severity = null, bool? suppress = null, bool? regexp = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_msg_config [-id <arg>] [-string <args>] [-severity <arg>] [-limit <arg>] [-new_severity <arg>] [-suppress] [-regexp] [-quiet] [-verbose]
			_tcl.Entry(_builder.set_msg_config(id, @string, severity, limit, new_severity, suppress, regexp, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Returns the build for Vivado and the build date<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: version [-short] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Returns the version number of the Xilinx® tool. This includes the software version number, build<br/>
		/// number and date, and copyright information.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns only the version number for the software:<br/>
		/// version -short<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1806<br/>
		/// </para>
		/// </summary>
		/// <param name="short">(Optional) Return only the numeric version number</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>
		/// </returns>
		public TTCL version(bool? @short = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: version [-short] [-quiet] [-verbose]
			_tcl.Entry(_builder.version(@short, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
