#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class TimingCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public TimingCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
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
		/// This command configures general features of design analysis.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: config_design_analysis [-max_common_paths &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This command configures features of the report_design_analysis command.<br/>
		/// The design analysis report analyzes timing paths at various stages in the Vivado tool flow,<br/>
		/// including synthesis, optimization, placement, routing. The -max_common_paths option<br/>
		/// specifies how many setup timing paths to capture at each stage in the flow.<br/>
		/// Note: This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example ignores the package delays during timing analysis:<br/>
		/// config_design_analysis 500<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 174<br/>
		/// </para>
		/// </summary>
		/// <param name="max_common_paths">
		/// <para>
		/// (Optional)<br/>
		/// Number of paths to consider for finding common paths<br/>
		/// across phases (&lt; 20000) Default: 1000<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL config_design_analysis(Int32? max_common_paths = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: config_design_analysis [-max_common_paths <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.config_design_analysis(max_common_paths, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Configure timing analysis general settings<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: config_timing_analysis [-enable_input_delay_default_clock &lt;arg&gt;] [-enable_preset_clear_arcs &lt;arg&gt;] [-ignore_io_paths &lt;arg&gt;] [-disable_flight_delays &lt;arg&gt;] [-merge_exceptions &lt;arg&gt;] [-timing_early_launch_at_borrowing_latches &lt;arg&gt;] [-enable_time_borrowing_for_max_delay_exceptions &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This command configures general features of timing analysis.<br/>
		/// Note: This command returns nothing if successful, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example ignores the package delays during timing analysis:<br/>
		/// config_timing_analysis -disable_flight_delays true<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 186<br/>
		/// </para>
		/// </summary>
		/// <param name="enable_input_delay_default_clock">
		/// <para>
		/// (Optional)<br/>
		/// Launch SDC unclocked input delays from an internally<br/>
		/// defined clock: Values: true, false; This option is not<br/>
		/// supported for UCF constraints<br/>
		/// </para>
		/// </param>
		/// <param name="enable_preset_clear_arcs">
		/// <para>
		/// (Optional)<br/>
		/// Time paths through asynchronous preset or clear timing<br/>
		/// arcs: true, false;<br/>
		/// </para>
		/// </param>
		/// <param name="ignore_io_paths">
		/// <para>
		/// (Optional)<br/>
		/// Ignore paths from primary inputs and paths to primary<br/>
		/// outputs: Values: true, false<br/>
		/// </para>
		/// </param>
		/// <param name="disable_flight_delays">(Optional) Disable adding package times to IO Calculations : Values: true, false;</param>
		/// <param name="merge_exceptions">
		/// <para>
		/// (Optional)<br/>
		/// Allow/Prevent the timing engine from merging timing<br/>
		/// exceptions : Values: true, false;<br/>
		/// </para>
		/// </param>
		/// <param name="timing_early_launch_at_borrowing_latches">
		/// <para>
		/// (Optional)<br/>
		/// Remove clock latency pessimism from the launching enable<br/>
		/// of paths through transparent latches. Values: auto, true,<br/>
		/// false Default: auto<br/>
		/// [-<br/>
		/// enable_time_borrowing_for_max_delay_exceptions<br/>
		/// ]<br/>
		/// Allow timing paths covered by set_max_delay timing<br/>
		/// exceptions to borrow time. Values: true, false<br/>
		/// </para>
		/// </param>
		/// <param name="enable_time_borrowing_for_max_delay_exceptions">(Optional)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL config_timing_analysis(bool? enable_input_delay_default_clock = null, String enable_preset_clear_arcs = null, bool? ignore_io_paths = null, bool? disable_flight_delays = null, bool? merge_exceptions = null, bool? timing_early_launch_at_borrowing_latches = null, String enable_time_borrowing_for_max_delay_exceptions = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: config_timing_analysis [-enable_input_delay_default_clock <arg>] [-enable_preset_clear_arcs <arg>] [-ignore_io_paths <arg>] [-disable_flight_delays <arg>] [-merge_exceptions <arg>] [-timing_early_launch_at_borrowing_latches <arg>] [-enable_time_borrowing_for_max_delay_exceptions <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.config_timing_analysis(enable_input_delay_default_clock, enable_preset_clear_arcs, ignore_io_paths, disable_flight_delays, merge_exceptions, timing_early_launch_at_borrowing_latches, enable_time_borrowing_for_max_delay_exceptions, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Configure single / multi corner timing analysis settings<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: config_timing_corners [-corner &lt;arg&gt;] [-delay_type &lt;arg&gt;] [-setup] [-hold] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This command configures the Slow and Fast timing corners in the current design for single or<br/>
		/// multi-corner timing analysis. A synthesized or implemented design must be opened when<br/>
		/// running this command.<br/>
		/// The variation in the manufacturing process of the physical device, and the voltage and<br/>
		/// temperature at which the device is operating, combine to create a timing corner. These three<br/>
		/// variables (PVT) determine the delay across the device. The fast corner represents a device<br/>
		/// operating with the smallest manufacturing process tolerances, the highest voltage, and the<br/>
		/// lowest temperature. The slow corner represents a device operating with the greatest<br/>
		/// manufacturing tolerances, the lowest voltage, and the highest temperature. By default the<br/>
		/// Vivado Design Suite performs both a setup and hold analysis for both slow and fast process<br/>
		/// corners, also known as quad analysis:<br/>
		/// config_timing_corners -corner Slow -setup -hold<br/>
		/// config_timing_corners -corner Fast -setup -hold<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The config_timing_corners command can be used to limit the default four corner analysis<br/>
		/// performed by the Vivado timing engine as appropriate to the design, to improve timing<br/>
		/// performance. To change or disable the default analysis for both corners, you must configure both<br/>
		/// the Fast and Slow corners:<br/>
		/// config_timing_corners -corner Slow -delay_type max<br/>
		/// config_timing_corners -corner Fast -delay_type none<br/>
		/// Note: This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example configures the Slow timing corner for both setup and hold analysis:<br/>
		/// config_timing_corners -corner slow -setup -hold<br/>
		/// config_timing_corners -corner slow -delay_type min_max<br/>
		/// Note: The two preceding examples have the same effect.<br/>
		/// The following example configures the Fast corner for min delay analysis, and disables the Slow<br/>
		/// corner analysis:<br/>
		/// config_timing_corners -corner fast -delay_type min<br/>
		/// config_timing_corners -corner slow -delay_type none<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 189<br/>
		/// </para>
		/// </summary>
		/// <param name="corner">(Optional) Name of the timing corner to be modified : Values: Slow, Fast</param>
		/// <param name="delay_type">
		/// <para>
		/// (Optional)<br/>
		/// Type of path delays to be analyzed for specified timing<br/>
		/// corner: Values: none, max, min, min_max<br/>
		/// </para>
		/// </param>
		/// <param name="setup">
		/// <para>
		/// (Optional)<br/>
		/// Enable timing corner for setup analysis (equivalent to -<br/>
		/// delay_type max)<br/>
		/// </para>
		/// </param>
		/// <param name="hold">
		/// <para>
		/// (Optional)<br/>
		/// Enable timing corner for hold analysis (equivalent to -<br/>
		/// delay_type min)<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL config_timing_corners(config_timing_corners_corner? corner = null, config_timing_corners_delay_type? delay_type = null, bool? setup = null, bool? hold = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: config_timing_corners [-corner <arg>] [-delay_type <arg>] [-setup] [-hold] [-quiet] [-verbose]
			_tcl.Entry(_builder.config_timing_corners(corner, delay_type, setup, hold, quiet, verbose));
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
		/// Deletes a list of available QoR suggestions<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_qor_suggestions [-quiet] [-verbose] [&lt;IDs&gt;]
		/// <br/>
		/// <para>
		/// Removes QoR suggestion objects that are currently in memory. Suggestion objects are generated<br/>
		/// running the report_qor_suggestion command, without specifying -of_objects, and by<br/>
		/// reading an RQS file using the read_qor_suggestions command. You can get QoR objects by<br/>
		/// using the get_qor_suggestions command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following deletes all the suggestion objects in memory:<br/>
		/// delete_qor_suggestions [get_qor_suggestions]<br/>
		/// The following deletes only the Utilization suggestions:<br/>
		/// delete_qor_suggestions [get_qor_suggestions -filter {CATEGORY==Utilization}]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 470<br/>
		/// </para>
		/// </summary>
		/// <param name="IDs">(Required) Match suggestion names against given names</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_qor_suggestions(String IDs, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_qor_suggestions [-quiet] [-verbose] [<IDs>]
			_tcl.Entry(_builder.delete_qor_suggestions(IDs, quiet, verbose));
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
		/// Get the routed or estimated delays in picoseconds on a net from the driver to each load pin.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_net_delays -of_objects &lt;args&gt; [-regexp] [-nocase] [-patterns &lt;arg&gt;] [-filter &lt;arg&gt;] [-to &lt;args&gt;] [-interconnect_only] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Get delay objects for the specified nets in the current design, from the driver to each load pin, or<br/>
		/// to specified load pins, through specific pins.<br/>
		/// The delay object contains properties defining the maximum and minimum delays for the fast and<br/>
		/// slow process corners. Use the get_property command to extract the property of interest from<br/>
		/// the delay object. Delay property values on the delay object are specified in picoseconds.<br/>
		/// TIP: In most cases the Vivado tools return delay values specified in nanoseconds, but the delay object uses<br/>
		/// picoseconds.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The values returned are calculated or estimated depending upon whether the net is routed.<br/>
		/// Delay values can include the actual delay of routed interconnect, or estimated net delays for<br/>
		/// unrouted nets. The net delay can also include delay through logic elements or device sites, or just<br/>
		/// include the interconnect delay.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// The get_net_delays command returns the delay objects for the specified nets, or returns an<br/>
		/// error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the interconnect delay values for the specified net, and returns it in<br/>
		/// the form of a delay object:<br/>
		/// report_property -all [lindex [get_net_delays -interconnect_only \<br/>
		/// -of_objects [get_nets control_reg[*]]] 16 ]<br/>
		/// TIP: The FAST_MAX, FAST_MIN, SLOW_MAX, and SLOW_MIN properties on the delay object are<br/>
		/// reported in picoseconds.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 838<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Required) Get 'net_delay' objects of these types: 'net'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="patterns">(Optional) Match the 'net_delay' objects against patterns. Default: *</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="to">(Optional) Get the delay of the net to the given terminal(s) or port(s).</param>
		/// <param name="interconnect_only">
		/// <para>
		/// (Optional)<br/>
		/// Include only interconnect delays. The default is to include<br/>
		/// the intra-site delay.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>net_delays</returns>
		public TTCL get_net_delays(TCLParameterList of_objects, bool? regexp = null, bool? nocase = null, String patterns = null, String filter = null, TCLParameterList to = null, bool? interconnect_only = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_net_delays -of_objects <args> [-regexp] [-nocase] [-patterns <arg>] [-filter <arg>] [-to <args>] [-interconnect_only] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_net_delays(of_objects, regexp, nocase, patterns, filter, to, interconnect_only, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of available QoR suggestions<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_qor_suggestions [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;IDs&gt;]
		/// <br/>
		/// <para>
		/// Get existing QoR suggestion objects created by the report_qor_suggestions command, or<br/>
		/// read into the design using read_qor_suggestions. The selected QoR objects can be written<br/>
		/// to a file using the write_qor_suggestions command. The suggestions created by the report<br/>
		/// command remain in memory until delete_qor_suggestions is run, or until it is overwritten<br/>
		/// by another report.<br/>
		/// This command returns a list of existing QoR suggestion objects from the open design, or returns<br/>
		/// an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// To return an individual suggestion, you can supply the full ID:<br/>
		/// get_qor_suggestions RQS_CLOCK-5_1-1<br/>
		/// Due to the naming style of suggestions, wildcard searches do NOT work directly. However you<br/>
		/// can use the filter command with -regexp to use wildcards as follows:<br/>
		/// filter -regexp [get_qor_suggestions] {NAME =~ RQS_CLOCK.*}<br/>
		/// You can also filter suggestions objects within a given category. Available categories include:<br/>
		/// Timing, Congestion, Utilization, XDC, Clocking, and Strategy. For example, the following returns<br/>
		/// suggestions related to the Timing category:<br/>
		/// get_qor_suggestions -filter {CATEGORY==Timing}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 904<br/>
		/// </para>
		/// </summary>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="IDs">(Optional) Match suggestion names against given names</param>
		/// <returns>list of qor suggestion objects</returns>
		public TTCL get_qor_suggestions(String filter = null, bool? quiet = null, bool? verbose = null, String IDs = null)
		{
			// TCL Syntax: get_qor_suggestions [-filter <arg>] [-quiet] [-verbose] [<IDs>]
			_tcl.Entry(_builder.get_qor_suggestions(filter, quiet, verbose, IDs));
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
		/// Get timing paths<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_timing_paths [-from &lt;args&gt;] [-rise_from &lt;args&gt;] [-fall_from &lt;args&gt;] [-to &lt;args&gt;] [-rise_to &lt;args&gt;] [-fall_to &lt;args&gt;] [-through &lt;args&gt;] [-rise_through &lt;args&gt;] [-fall_through &lt;args&gt;] [-delay_type &lt;arg&gt;] [-setup] [-hold] [-max_paths &lt;arg&gt;] [-nworst &lt;arg&gt;] [-unique_pins] [-slack_lesser_than &lt;arg&gt;] [-slack_greater_than &lt;arg&gt;] [-group &lt;args&gt;] [-no_report_unconstrained] [-user_ignored] [-routable_nets] [-sort_by &lt;arg&gt;] [-filter &lt;arg&gt;] [-regexp] [-nocase] [-cell &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Gets timing path objects that meet the specified criteria. This command can be used to predefine<br/>
		/// timing paths to pass to the report_timing command for instance. Another usage of this<br/>
		/// command is to create custom reporting and analysis.<br/>
		/// The get_timing_paths command is very similar to the report_timing command.<br/>
		/// However, get_timing_paths returns timing path objects which can be queried for properties,<br/>
		/// or passed to other Tcl commands for processing, where report_timing returns a file or a<br/>
		/// string.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the five worst timing paths from the specified endpoint, and reports<br/>
		/// all the properties of the fourth timing path in the list:<br/>
		/// report_property -all [lindex [get_timing_paths -to [get_ports led_pins[*]]<br/>
		/// \<br/>
		/// -nworst 5] 3]<br/>
		/// The following example defines a procedure called custom_report, then reports the 100 worst<br/>
		/// paths from the clk_tx_clk_core_1 path group using that proc:<br/>
		/// proc custom_report { listOfPaths } {<br/>
		/// puts [format {%-40s %-40s %-20s %-20s %7s} "Startpoint" "Endpoint" \<br/>
		/// "Launch Clock" "Capture Clock" "Slack"]<br/>
		/// puts [string repeat "-" 140]<br/>
		/// foreach path $listOfPaths {<br/>
		/// set startpoint [get_property STARTPOINT_PIN $path]<br/>
		/// set startclock [get_property STARTPOINT_CLOCK $path]<br/>
		/// set endpoint [get_property ENDPOINT_PIN $path]<br/>
		/// set endclock [get_property ENDPOINT_CLOCK $path]<br/>
		/// set slack [get_property SLACK $path]<br/>
		/// puts [format {%-40s %-40s %-20s %-20s %7s} $startpoint $endpoint \<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// $startclock $endclock $slack]<br/>
		/// }<br/>
		/// }<br/>
		/// set paths [get_timing_paths -group clk_tx_clk_core_1 -max_paths 100]\<br/>
		/// custom_report $path<br/>
		/// The following example illustrates how timing path objects can be used with the<br/>
		/// report_timing command:<br/>
		/// set paths [get_timing_paths -group clk_tx_clk_core_1 -max_paths 100]<br/>
		/// report_timing -of_objects $paths<br/>
		/// Which is the equivalent of:<br/>
		/// report_timing -group clk_tx_clk_core_1 -max_paths 100<br/>
		/// The following example returns timing paths where the logic levels are greater than the specified<br/>
		/// number of logic levels:<br/>
		/// get_timing_paths -max_paths 1000 -filter {LOGIC_LEVELS &gt; 1}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 949<br/>
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
		/// <param name="setup">(Optional) Get max delay timing paths (equivalent to -delay_type max)</param>
		/// <param name="hold">(Optional) Get min delay timing paths (equivalent to -delay_type min)</param>
		/// <param name="max_paths">(Optional) Maximum number of paths to return: Value &gt;=1 Default: 1</param>
		/// <param name="nworst">(Optional) List N worst paths to endpoint: Value &gt;=1 Default: 1</param>
		/// <param name="unique_pins">(Optional) for each unique set of pins, show at most 1 path per path group</param>
		/// <param name="slack_lesser_than">(Optional) Include paths with slack less than this Default: 1e+30</param>
		/// <param name="slack_greater_than">(Optional) Include paths with slack greater than this Default: -1e+30</param>
		/// <param name="group">(Optional) Limit paths in this group(s)</param>
		/// <param name="no_report_unconstrained">(Optional) Do not get unconstrained paths</param>
		/// <param name="user_ignored">
		/// <para>
		/// (Optional)<br/>
		/// only report paths which have infinite slack because of<br/>
		/// set_false_path or set_clock_groups timing constraints<br/>
		/// </para>
		/// </param>
		/// <param name="routable_nets">
		/// <para>
		/// (Optional)<br/>
		/// store the number of routable nets traversed as a property<br/>
		/// on timing paths.<br/>
		/// </para>
		/// </param>
		/// <param name="sort_by">(Optional) Sorting order of paths: Values: group, slack Default: slack</param>
		/// <param name="filter">
		/// <para>
		/// (Optional)<br/>
		/// Filter list with expression<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Name Description<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns specified in filter are full regular expressions</param>
		/// <param name="nocase">
		/// <para>
		/// (Optional)<br/>
		/// Perform case-insensitive matching for patterns specified in<br/>
		/// filter (valid only when -regexp specified)<br/>
		/// </para>
		/// </param>
		/// <param name="cell">(Optional) run get_timing_paths on the cell</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL get_timing_paths(TCLParameterList from = null, TCLParameterList rise_from = null, TCLParameterList fall_from = null, TCLParameterList to = null, TCLParameterList rise_to = null, TCLParameterList fall_to = null, TCLParameterList through = null, TCLParameterList rise_through = null, TCLParameterList fall_through = null, get_timing_paths_delay_type? delay_type = null, bool? setup = null, bool? hold = null, Int32? max_paths = null, String nworst = null, bool? unique_pins = null, String slack_lesser_than = null, String slack_greater_than = null, TCLParameterList group = null, bool? no_report_unconstrained = null, bool? user_ignored = null, bool? routable_nets = null, get_timing_paths_sort_by? sort_by = null, String filter = null, bool? regexp = null, bool? nocase = null, TCLParameterList cell = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_timing_paths [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-through <args>] [-rise_through <args>] [-fall_through <args>] [-delay_type <arg>] [-setup] [-hold] [-max_paths <arg>] [-nworst <arg>] [-unique_pins] [-slack_lesser_than <arg>] [-slack_greater_than <arg>] [-group <args>] [-no_report_unconstrained] [-user_ignored] [-routable_nets] [-sort_by <arg>] [-filter <arg>] [-regexp] [-nocase] [-cell <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_timing_paths(from, rise_from, fall_from, to, rise_to, fall_to, through, rise_through, fall_through, delay_type, setup, hold, max_paths, nworst, unique_pins, slack_lesser_than, slack_greater_than, group, no_report_unconstrained, user_ignored, routable_nets, sort_by, filter, regexp, nocase, cell, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Read QoR Suggestions from the given file<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_qor_suggestions [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Read the specified file and extract the QoR suggestions from the file.<br/>
		/// This command returns the name of the QoR file read, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reads the QoR suggestions from the specified file, and then reports the<br/>
		/// QoR suggestions in the open design:<br/>
		/// read_qor_suggestions C:/Data/qor_results.rqs<br/>
		/// report_qor_suggestions -of_objects [get_qor_suggestions]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1174<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Required)<br/>
		/// QoR suggestions file Values: Path to the QoR suggestions<br/>
		/// file, typically ending with .rqs.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL read_qor_suggestions(String file, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_qor_suggestions [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.read_qor_suggestions(file, quiet, verbose));
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
		/// Sets the interconnect delay model for timing analysis.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_delay_model [-interconnect &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Sets the interconnect delay model for timing analysis. There are three settings for the<br/>
		/// interconnect delay model: "actual", "estimated", or "none".<br/>
		/// • If "actual" is selected, the actual delay from the routed interconnect will be used in timing<br/>
		/// analysis. If the design is only partially routed, then the actual delay from the routed portion<br/>
		/// will be used, along with estimated delay for the unrouted portion. The timing report will<br/>
		/// provide details regarding the source of the calculated delay.<br/>
		/// • If "estimated" delays are selected, the timing analysis will include an estimate of the<br/>
		/// interconnect delays based on the placement and connectivity of the design onto the device<br/>
		/// prior to implementation. Estimated delay can be specified even if the design is fully routed.<br/>
		/// • If "none" is selected, then no interconnect delay is included in the timing analysis, and only the<br/>
		/// logic delay is applied.<br/>
		/// Note: This command operates silently and does not return direct feedback of its operation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following command will use a timing delay model which is an estimated value.<br/>
		/// set_delay_model -interconnect estimated<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1612<br/>
		/// </para>
		/// </summary>
		/// <param name="interconnect">
		/// <para>
		/// (Optional)<br/>
		/// Interconnect delay model used for timing analysis: Values:<br/>
		/// estimated, actual(default), none<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_delay_model(set_delay_model_interconnect? interconnect = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_delay_model [-interconnect <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.set_delay_model(interconnect, quiet, verbose));
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
		public TTCL set_external_delay(TCLParameterList from, TCLParameterList to, String delay_value, bool? min = null, bool? max = null, bool? add = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_external_delay -from <args> -to <args> [-min] [-max] [-add] [-quiet] [-verbose] <delay_value>
			_tcl.Entry(_builder.set_external_delay(from, to, delay_value, min, max, add, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// update timing<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: update_timing [-full] [-skip_delay_calc] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Updates timing for the current design.<br/>
		/// Update the timing data to reflect any timing constraints that were added to the design since the<br/>
		/// timing engine was last run. This command updates the in-memory view of the timing database,<br/>
		/// without incurring the time of a full timing analysis.<br/>
		/// Timing is automatically updated by commands that change timing or need updated timing<br/>
		/// information, such as the report_timing command. The update_timing command lets you<br/>
		/// manually trigger the timing update to insure the latest constraints are applied to the timing<br/>
		/// engine.<br/>
		/// The update_timing command uses an incremental analysis approach by default, which<br/>
		/// updates only out-of-date information, to reduce process and analysis time. You can also specify a<br/>
		/// complete or full update to insure a comprehensive review of timing data in the design. However,<br/>
		/// to avoid long timing analysis run times, you should use the -full option only when you need to.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example performs a full update of the in-memory timing data:<br/>
		/// update_timing -full<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1784<br/>
		/// </para>
		/// </summary>
		/// <param name="full">(Optional) Perform a full timing update instead of an incremental one</param>
		/// <param name="skip_delay_calc">(Optional) Skip delay calculation</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL update_timing(bool? full = null, bool? skip_delay_calc = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: update_timing [-full] [-skip_delay_calc] [-quiet] [-verbose]
			_tcl.Entry(_builder.update_timing(full, skip_delay_calc, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write file with inferred xdc timing constraints<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_inferred_xdc [-force] [-all] [-append] [-async_clocks] [-all_async_reg] [-clock_groups] [-clocks] [-excl_clocks] [-exceptions] [-io_constraints] [-merge_existing_constraints] [-name &lt;arg&gt;] [-quiet] [-verbose] [&lt;file&gt;]
		/// <br/>
		/// <para>
		/// You can use the write_inferred_xdc to find constraints that should be defined in the open<br/>
		/// synthesized or implemented design. Write timing constraints that are automatically generated by<br/>
		/// the Vivado timing engine, rather than defined in an existing XDC file and added to the design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Run write_inferred_xdc -clocks first to define suggested clock and generated clock<br/>
		/// constraints. The suggested clock constraints will be defined with a period of 1 ns. You can edit<br/>
		/// the recommended constraints to create clocks and generated clocks with the required clock<br/>
		/// period to meet the needs of your design.<br/>
		/// You can add the edited constraints file into the design using read_xdc, or add_files, and<br/>
		/// update_timing.<br/>
		/// You may need to run the write_inferred_xdc command multiple times, using various<br/>
		/// options like -clock_groups or -async_clocks, to capture all inferred timing constraints<br/>
		/// from the fully clocked design. You can use an iterative process of writing and sourcing the<br/>
		/// inferred clocked constraints, and then writing and sourcing additional constraint files to capture<br/>
		/// all inferred constraints. See the example below for more information.<br/>
		/// This command returns a transcript of the process when successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example writes the inferred clock constraints in the current design:<br/>
		/// write_inferred_xdc -clocks C:/Data/design1_inferred_clocks.xdc<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The write_inferred_xdc command may need to be run multiple times to capture all the<br/>
		/// inferred constraints, as is shown in this example:<br/>
		/// write_inferred_xdc -clocks clocks.xdc<br/>
		/// source clocks.xdc<br/>
		/// write_inferred_xdc -all all.xdc<br/>
		/// source all.xdc<br/>
		/// write_inferred_xdc -async_clocks async.xdc<br/>
		/// source async.xdc<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1867<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Filename to write constraints into</param>
		/// <param name="force">(Optional) Overwrite existing file.</param>
		/// <param name="all">
		/// <para>
		/// (Optional)<br/>
		/// Generate all constraints except missing clocks which are<br/>
		/// generated with the -clocks option<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the constraints to file, don't overwrite the constraints file</param>
		/// <param name="async_clocks">(Optional) Find asynchronous clock groups</param>
		/// <param name="all_async_reg">
		/// <para>
		/// (Optional)<br/>
		/// Find the missing ASYNC_REG property for safe and unsafe<br/>
		/// Clock Domain Crossing<br/>
		/// </para>
		/// </param>
		/// <param name="clock_groups">
		/// <para>
		/// (Optional)<br/>
		/// Find asynchronous and exclusive clock groups, equivalent to<br/>
		/// options -async_clocks -excl_clocks<br/>
		/// </para>
		/// </param>
		/// <param name="clocks">(Optional) Find missing clock definitions</param>
		/// <param name="excl_clocks">(Optional) Find logically and physically exclusive clock groups</param>
		/// <param name="exceptions">(Optional) Find missing exceptions</param>
		/// <param name="io_constraints">(Optional) Find missing input and output delays</param>
		/// <param name="merge_existing_constraints">(Optional) Add existing user defined constraints to the generated constraints</param>
		/// <param name="name">
		/// <para>
		/// (Optional)<br/>
		/// Start constraints wizard in a GUI panel with this name. Do<br/>
		/// other command options can be combined with -name.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_inferred_xdc(String file, bool? force = null, bool? all = null, bool? append = null, bool? async_clocks = null, bool? all_async_reg = null, bool? clock_groups = null, bool? clocks = null, bool? excl_clocks = null, bool? exceptions = null, bool? io_constraints = null, bool? merge_existing_constraints = null, String name = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_inferred_xdc [-force] [-all] [-append] [-async_clocks] [-all_async_reg] [-clock_groups] [-clocks] [-excl_clocks] [-exceptions] [-io_constraints] [-merge_existing_constraints] [-name <arg>] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.write_inferred_xdc(file, force, all, append, async_clocks, all_async_reg, clock_groups, clocks, excl_clocks, exceptions, io_constraints, merge_existing_constraints, name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write QoR Suggestions to the given file<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_qor_suggestions [-strategy_dir &lt;arg&gt;] [-tcl_output_dir &lt;arg&gt;] [-force] [-of_objects &lt;args&gt;] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Write the QoR suggestions generated by the report_qor_suggestions command. You can<br/>
		/// combine the suggestions from the latest report with suggestions read into the design with<br/>
		/// read_qor_suggestions so that you can manage all suggestions in a single RQS file.<br/>
		/// To write out specific QoR suggestions, use the -of_objects option. When this is not specified,<br/>
		/// all suggestions will be written.<br/>
		/// The recommended way to manage suggestions is using RQS objects. However, it is possible to<br/>
		/// view and execute the commands using Tcl. Specifying the -tcl_output_dir option writes Tcl<br/>
		/// scripts for the automated suggestions that are property based.<br/>
		/// Implementation strategies that use machine learning to analyze the design can be generated<br/>
		/// running report_qor_suggestions. If you specify the -strategy_dir option, multiple Tcl<br/>
		/// files and one RQS file will be written for each strategy. The Tcl files aid integration into project or<br/>
		/// non project flows. The main RQS file should not be used as the suggestions are contained in the<br/>
		/// run specific files along with strategy information.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns the name of the output file created when successful, or returns an error if<br/>
		/// it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports QoR suggestions, then writes non-strategy suggestions to the<br/>
		/// specified file.<br/>
		/// report_qor_suggestions<br/>
		/// write_qor_suggestions C:/Data/qor_results.rqs<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example reports QoR suggestions, then writes both strategy and non-strategy<br/>
		/// suggestions. It will create one RQS file for each strategy suggestion that exists, generating up to<br/>
		/// three by default. Into each RQS file, it writes one strategy suggestion and all non-strategy<br/>
		/// suggestions. This behavior means that for subsequent runs one RQS file per run is required.<br/>
		/// report_qor_suggestions<br/>
		/// write_qor_suggestions -strategy_dir C:/Data/strategy_dir C:/Data/<br/>
		/// qor_suggestions.rqs<br/>
		/// To make use of strategy suggestions, the directive for each implementation command<br/>
		/// (opt_design, place_design, phys_opt_design, and route_design) must be set to RQS.<br/>
		/// This can be configured automatically in project mode by sourcing the project mode Tcl script<br/>
		/// generated for each RQS file in the strategy_dir. There is also a non-project example Tcl script<br/>
		/// that demonstrates this requirement.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1883<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Required)<br/>
		/// QoR suggestions file Values: A filename with alphanumeric<br/>
		/// characters and .rqs extension.<br/>
		/// </para>
		/// </param>
		/// <param name="strategy_dir">
		/// <para>
		/// (Optional)<br/>
		/// Directory to create Strategy RQS &amp; TCL files Values: If<br/>
		/// passed a directory path, for each strategy suggested one set<br/>
		/// of RQS and TCL files will be generated.<br/>
		/// </para>
		/// </param>
		/// <param name="tcl_output_dir">
		/// <para>
		/// (Optional)<br/>
		/// Directory to create TCL files Values: TCL files for the QoR<br/>
		/// suggestions will be generated in the provided directory.<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Overwrite existing suggestions file</param>
		/// <param name="of_objects">(Optional) List of QoR suggestion objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_qor_suggestions(String file, String strategy_dir = null, String tcl_output_dir = null, bool? force = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_qor_suggestions [-strategy_dir <arg>] [-tcl_output_dir <arg>] [-force] [-of_objects <args>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_qor_suggestions(file, strategy_dir, tcl_output_dir, force, of_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// write_sdf command generates flat sdf delay files for event simulation<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_sdf [-process_corner &lt;arg&gt;] [-cell &lt;arg&gt;] [-rename_top &lt;arg&gt;] [-force] [-mode &lt;arg&gt;] [-gzip] [-multithread &lt;arg&gt;] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Writes the timing delays for cells in the design to a Standard Delay Format (SDF) file.<br/>
		/// The output SDF file can be used by the write_verilog command to create Verilog netlists for<br/>
		/// static timing analysis and timing simulation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example writes an SDF file to the specified directory:<br/>
		/// write_sdf C:/Data/FPGA_Design/designOut.sdf<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1889<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) File name</param>
		/// <param name="process_corner">
		/// <para>
		/// (Optional)<br/>
		/// Specify process corner for which SDF delays are required;<br/>
		/// Values: slow, fast Default: slow<br/>
		/// </para>
		/// </param>
		/// <param name="cell">(Optional) Root of the design to write, e.g. des.subblk.cpu Default: whole design</param>
		/// <param name="rename_top">
		/// <para>
		/// (Optional)<br/>
		/// Replace name of top module with custom name e.g. netlist<br/>
		/// Default: new top module name<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Overwrite existing SDF file</param>
		/// <param name="mode">
		/// <para>
		/// (Optional)<br/>
		/// Specify sta (Static Timing Analysis) or timesim (Timing<br/>
		/// Simulation) mode for SDF Default: timesim<br/>
		/// </para>
		/// </param>
		/// <param name="gzip">(Optional) write gzipped SDF</param>
		/// <param name="multithread">(Optional) Run in multithread mode with specified number of threads Default: -1</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_sdf(String file, write_sdf_process_corner? process_corner = null, String cell = null, String rename_top = null, bool? force = null, String mode = null, bool? gzip = null, Int32? multithread = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_sdf [-process_corner <arg>] [-cell <arg>] [-rename_top <arg>] [-force] [-mode <arg>] [-gzip] [-multithread <arg>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_sdf(file, process_corner, cell, rename_top, force, mode, gzip, multithread, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Writes constraints to a Xilinx Design Constraints (XDC) file. The default file extension for a XDC<br/>
		/// file is .xdc.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_xdc [-no_fixed_only] [-constraints &lt;arg&gt;] [-cell &lt;arg&gt;] [-sdc] [-no_tool_comments] [-force] [-exclude_timing] [-exclude_physical] [-add_netlist_placement] [-logic_function_stripped] [-type &lt;args&gt;] [-write_id] [-quiet] [-verbose] [&lt;file&gt;]
		/// <br/>
		/// <para>
		/// Writes constraints to a Xilinx® Design Constraints file (XDC). The XDC can be exported from the<br/>
		/// top-level, which is the default, or from a specific hierarchical cell.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// IMPORTANT! The write_xdc command writes the constraints to the specified file in the same order<br/>
		/// they are added to or executed in the design.<br/>
		/// The write_xdc command lets you write invalid XDC constraints so that you can quickly report<br/>
		/// constraints that have been ignored by the Vivado Design Suite due to a problem with the way<br/>
		/// the constraint is written or applied. This is useful for debugging constraint files applied in specific<br/>
		/// designs.<br/>
		/// This command can be used to create an XDC file from a design with UCF files. All constraints<br/>
		/// from the active constraint fileset will be exported to the XDC, even if they come from multiple<br/>
		/// files.<br/>
		/// TIP: The write_xdc command will not convert all UCF constraints into XDC format, and is not intended<br/>
		/// to automatically convert UCF based designs to XDC. Refer to the Vivado Design Suite Migration<br/>
		/// Methodology Guide (UG911) for more information on migrating UCF constraints to XDC.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example writes the valid and invalid constraints, including both fixed and unfixed<br/>
		/// cells, to the specified file:<br/>
		/// write_xdc -no_fixed_only -constraints all C:/Data/design.xdc<br/>
		/// This example writes only the invalid constraints, including both fixed and unfixed cells, to the<br/>
		/// specified file:<br/>
		/// write_xdc -constraints invalid C:/Data/bad_constraints.xdc<br/>
		/// The following example writes the physical constraints only, including any placement constraints<br/>
		/// defined in any netlist source files:<br/>
		/// write_xdc -exclude_timing -add_netlist_placement C:/Data/physical.xdc<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1900<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Output constraints to the specified XDC file.</param>
		/// <param name="no_fixed_only">
		/// <para>
		/// (Optional)<br/>
		/// Export fixed and non-fixed placement (by default only fixed<br/>
		/// placement is exported)<br/>
		/// </para>
		/// </param>
		/// <param name="constraints">
		/// <para>
		/// (Optional)<br/>
		/// Include constraints that are flagged invalid Values: valid,<br/>
		/// invalid, all Default: valid<br/>
		/// </para>
		/// </param>
		/// <param name="cell">(Optional) Hierarchical cell for which constraints are exported.</param>
		/// <param name="sdc">(Optional) Export all timing constriants in SDC compatible format.</param>
		/// <param name="no_tool_comments">
		/// <para>
		/// (Optional)<br/>
		/// Don't write verbose tool generated comments to the xdc<br/>
		/// when translating from ucf.<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Overwrite existing file.</param>
		/// <param name="exclude_timing">(Optional) Don't export timing constraints.</param>
		/// <param name="exclude_physical">(Optional) Don't export physical constraints.</param>
		/// <param name="add_netlist_placement">(Optional) Export netlist placement constraints.</param>
		/// <param name="logic_function_stripped">
		/// <para>
		/// (Optional)<br/>
		/// Write disable_timing constraints which are associated with<br/>
		/// having previously run write_edif with its -<br/>
		/// logic_function_stripped option.<br/>
		/// </para>
		/// </param>
		/// <param name="type">
		/// <para>
		/// (Optional)<br/>
		/// Types of constraint to export. Values: timing, io, misc, waiver<br/>
		/// and physical. If not specified, all constraints will be<br/>
		/// exported.<br/>
		/// </para>
		/// </param>
		/// <param name="write_id">(Optional) Write position number for timing constraints</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_xdc(String file, bool? no_fixed_only = null, write_xdc_constraints? constraints = null, String cell = null, bool? sdc = null, bool? no_tool_comments = null, bool? force = null, bool? exclude_timing = null, bool? exclude_physical = null, bool? add_netlist_placement = null, bool? logic_function_stripped = null, TCLParameterList type = null, bool? write_id = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_xdc [-no_fixed_only] [-constraints <arg>] [-cell <arg>] [-sdc] [-no_tool_comments] [-force] [-exclude_timing] [-exclude_physical] [-add_netlist_placement] [-logic_function_stripped] [-type <args>] [-write_id] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.write_xdc(file, no_fixed_only, constraints, cell, sdc, no_tool_comments, force, exclude_timing, exclude_physical, add_netlist_placement, logic_function_stripped, type, write_id, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
