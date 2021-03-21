// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class TimingCommands
	{
		private readonly QuokkaTCL _tcl;
		public TimingCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Check the design for possible timing problems
		///
		/// Checks the design elements of ports, pins, and paths, against the current timing constraints. Use
		/// this command to identify possible problems with design data and timing constraints before
		/// running the report_timing command. The check_timing command runs a series of default
		/// timing checks, and reports a summary of any violations found. To get detailed information about
		/// violations, use the -verbose option.
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be
		/// written to the GUI with the -name option, or to a file with -file.
		/// Default Timing Checks:
		/// • constant_clock - Checks for clock signals connected to a constant signal (gnd/vss/data).
		/// • generated_clocks - Checks for loops, or circular definitions within the generated clock
		/// network. This check will return an error if a generated clock uses a second generated clock as
		/// its source, when the second generated clock uses the first clock as its source.
		/// • latch_loops - Checks for and warns of combinational latch loops in the design.
		/// • loops - Checks for and warns of combinational feedback loops in the design.
		/// • multiple_clock - Warns if multiple clocks reach a register clock pin. If more than one clock
		/// signal reaches a register clock pin it is unclear which clock will be used for analysis. In this
		/// case, use the set_case_analysis command so that only one clock will propagate to the
		/// register clock pin.
		/// • no_clock - Reports unclocked registers. In this case, no setup or hold checks are performed
		/// on data pins related to the register clock pin.
		/// • no_input_delay - Reports the input ports without an input delay constraint. Input delays
		/// can be assigned using the set_input_delay command. Input ports that are unclocked will
		/// not be checked for input delays.
		/// • no_output_delay - Reports the output ports without an output delay constraint. Output
		/// delays can be assigned using the set_output_delay command. Output ports that are
		/// unclocked will not be checked for output delays.
		/// • partial_input_delay - Reports the input ports having partially defined input delay
		/// constraints. Assigning set_input_delay -max or set_input_delay -min to an input
		/// port, without assigning the other, creates a partially defined input delay. In such cases, paths
		/// starting from the input port may become unconstrained and no timing checks will be done
		/// against the port. Assigning set_input_delay without specifying either -min or -max
		/// allows the tool to assume both min and max delays, and so does not result in a partial input
		/// delay.
		/// Note: Unclocked input ports are not checked for partial input delays.
		/// • partial_output_delay - Reports the output ports having partially defined output delay
		/// constraints. Assigning set_output_delay -max or set_output_delay -min to an
		/// output port, without assigning the other, creates a partially defined output delay. In such
		/// cases, paths reaching the port may become unconstrained and no timing checks will be done
		/// against the port. Assigning set_output_delay without specifying either -min or -max
		/// allows the tool to assume both min and max delays, and so does not result in a partial output
		/// delay.
		/// Note: Unclocked output ports are not checked for partial output delays.
		/// • pulse_width_clock - Reports clock pins that have only a pulse width check associated
		/// with the pin, and no setup or hold check, no recovery, removal, or clk->Q check.
		/// • unconstrained_internal_endpoints - This warning identifies timing path endpoints at
		/// register data pins that are not constrained. Endpoints at register data pins are constrained by
		/// clock assignment using the create_clock command. Endpoints at output ports are checked
		/// and reported by the no_output_delay check.
		/// • unexpandable_clocks - Reports clock sets in which the period is not expandable with
		/// respect to each other, when there is at least 1 path between the clock sets. A clock is
		/// unexpandable if no common multiples are found within 1000 cycles between the source and
		/// destination clocks.
		///
		/// The following example runs check_timing, but excludes the specified checks from the default
		/// timing checks:
		/// check_timing -exclude {loops generated_clocks}
		/// The following example uses the -verbose argument to obtain detailed results running just the
		/// multiple_clocks check, and then uses get_clocks to look further into the issue:
		/// check_timing -verbose -override_defaults {multiple_clock}
		/// Checking multiple_clock.
		/// There are 2 register/latch pins with multiple clocks.
		/// procEngine/mode_du/set_reg[0]/C
		/// provEngine/mode_du/set_reg[1]/C
		/// get_clocks -of_objects [get_pin procEngine/mode_du/set_reg[0]/C]
		/// sysClk coreClk
		///
		/// See ug835-vivado-tcl-commands.pdf, page 124
		/// </summary>
		/// <param name="override_defaults">
		/// Required
		/// Overrides the checks in the default timing checks listed
		/// below
		/// </param>
		/// <param name="include">
		/// Required
		/// Add this list of checks to be performed along with default
		/// timing checks listed below
		/// </param>
		/// <param name="exclude">
		/// Required
		/// Exclude this list of checks to be performed from the default
		/// timing checks listed below
		/// </param>
		/// <param name="cells">
		/// Required
		/// run check_timing on the specified cell(s)
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="no_header">
		/// Optional
		/// do not generate a report header
		/// </param>
		/// <param name="loop_limit">
		/// Optional
		/// Limit the number of loops reported for loops check Default:
		/// 100
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, don't overwrite the results file
		/// </param>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// return report as string
		/// </param>
		/// <param name="rpx">
		/// Optional
		/// Filename to output interactive results to.
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Return a detailed list of all timing problems found
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		public void check_timing(string override_defaults, string include, string exclude, string cells, string file = null, bool? no_header = null, string loop_limit = null, bool? append = null, string name = null, bool? return_string = null, string rpx = null, bool? verbose = null, bool? quiet = null)
		{
			var command = new SimpleTCLCommand("check_timing");
			_tcl.Add(command);
		}
		/// <summary>
		/// This command configures general features of design analysis.
		///
		/// This command configures features of the report_design_analysis command.
		/// The design analysis report analyzes timing paths at various stages in the Vivado tool flow,
		/// including synthesis, optimization, placement, routing. The -max_common_paths option
		/// specifies how many setup timing paths to capture at each stage in the flow.
		/// Note: This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example ignores the package delays during timing analysis:
		/// config_design_analysis 500
		///
		/// See ug835-vivado-tcl-commands.pdf, page 169
		/// </summary>
		/// <param name="max_common_paths">
		/// Optional
		/// Number of paths to consider for finding common paths
		/// across phases (< 20000) Default: 1000
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void config_design_analysis(string max_common_paths = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("config_design_analysis");
			_tcl.Add(command);
		}
		/// <summary>
		/// Configure timing analysis general settings
		///
		/// This command configures general features of timing analysis.
		/// Note: This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example ignores the package delays during timing analysis:
		/// config_timing_analysis -disable_flight_delays true
		///
		/// See ug835-vivado-tcl-commands.pdf, page 181
		/// </summary>
		/// <param name="enable_input_delay_default_clock">
		/// Optional
		/// Launch SDC unclocked input delays from an internally
		/// defined clock: Values: true, false; This option is not
		/// supported for UCF constraints
		/// </param>
		/// <param name="enable_preset_clear_arcs">
		/// Optional
		/// Time paths through asynchronous preset or clear timing
		/// arcs: true, false;
		/// </param>
		/// <param name="ignore_io_paths">
		/// Optional
		/// Ignore paths from primary inputs and paths to primary
		/// outputs: Values: true, false
		/// </param>
		/// <param name="disable_flight_delays">
		/// Optional
		/// Disable adding package times to IO Calculations : Values:
		/// true, false;
		/// </param>
		/// <param name="merge_exceptions">
		/// Optional
		/// Allow/Prevent the timing engine from merging timing
		/// exceptions : Values: true, false;
		/// </param>
		/// <param name="timing_early_launch_at_borrowing_latches">
		/// Optional
		/// Remove clock latency pessimism from the launching enable
		/// of paths through transparent latches. Values: auto, true,
		/// false Default: auto
		/// [-
		/// enable_time_borrowing_for_max_delay_exceptions
		/// ]
		/// Allow timing paths covered by set_max_delay timing
		/// exceptions to borrow time. Values: true, false
		/// </param>
		/// <param name="enable_time_borrowing_for_max_delay_exceptions">
		/// Optional
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void config_timing_analysis(string enable_input_delay_default_clock = null, string enable_preset_clear_arcs = null, string ignore_io_paths = null, string disable_flight_delays = null, string merge_exceptions = null, string timing_early_launch_at_borrowing_latches = null, string enable_time_borrowing_for_max_delay_exceptions = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("config_timing_analysis");
			_tcl.Add(command);
		}
		/// <summary>
		/// Configure single / multi corner timing analysis settings
		///
		/// This command configures the Slow and Fast timing corners in the current design for single or
		/// multi-corner timing analysis. A synthesized or implemented design must be opened when
		/// running this command.
		/// The variation in the manufacturing process of the physical device, and the voltage and
		/// temperature at which the device is operating, combine to create a timing corner. These three
		/// variables (PVT) determine the delay across the device. The fast corner represents a device
		/// operating with the smallest manufacturing process tolerances, the highest voltage, and the
		/// lowest temperature. The slow corner represents a device operating with the greatest
		/// manufacturing tolerances, the lowest voltage, and the highest temperature. By default the
		/// Vivado Design Suite performs both a setup and hold analysis for both slow and fast process
		/// corners, also known as quad analysis:
		/// config_timing_corners -corner Slow -setup -hold
		/// config_timing_corners -corner Fast -setup -hold
		/// The config_timing_corners command can be used to limit the default four corner analysis
		/// performed by the Vivado timing engine as appropriate to the design, to improve timing
		/// performance. To change or disable the default analysis for both corners, you must configure both
		/// the Fast and Slow corners:
		/// config_timing_corners -corner Slow -delay_type max
		/// config_timing_corners -corner Fast -delay_type none
		/// Note: This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example configures the Slow timing corner for both setup and hold analysis:
		/// config_timing_corners -corner slow -setup -hold
		/// config_timing_corners -corner slow -delay_type min_max
		/// Note: The two preceding examples have the same effect.
		/// The following example configures the Fast corner for min delay analysis, and disables the Slow
		/// corner analysis:
		/// config_timing_corners -corner fast -delay_type min
		/// config_timing_corners -corner slow -delay_type none
		///
		/// See ug835-vivado-tcl-commands.pdf, page 184
		/// </summary>
		/// <param name="corner">
		/// Optional
		/// Name of the timing corner to be modified : Values: Slow,
		/// Fast
		/// </param>
		/// <param name="delay_type">
		/// Optional
		/// Type of path delays to be analyzed for specified timing
		/// corner: Values: none, max, min, min_max
		/// </param>
		/// <param name="setup">
		/// Optional
		/// Enable timing corner for setup analysis (equivalent to -
		/// delay_type max)
		/// </param>
		/// <param name="hold">
		/// Optional
		/// Enable timing corner for hold analysis (equivalent to -
		/// delay_type min)
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void config_timing_corners(string corner = null, string delay_type = null, bool? setup = null, bool? hold = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("config_timing_corners");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create histogram
		///
		/// Create a slack histogram grouping paths into slack ranges, and displaying the results graphically.
		/// TIP: This command provides a graphical slack histogram that requires the tool to be running in GUI mode.
		///
		/// The following example creates a slack histogram of the current design, using the default values,
		/// and outputting the results to the named result set in the GUI:
		/// create_slack_histogram -name slack1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 352
		/// </summary>
		/// <param name="to">
		/// Required
		/// To clock
		/// </param>
		/// <param name="group">
		/// Required
		/// Limit report to paths in this group(s)
		/// </param>
		/// <param name="cells">
		/// Required
		/// run create_slack_histogram on the specified cell(s)
		/// </param>
		/// <param name="delay_type">
		/// Optional
		/// Type of path delay: Values: max, min, min_max Default: max
		/// </param>
		/// <param name="num_bins">
		/// Optional
		/// Maximum number of bins: Valid Range (1-100) Default: 10
		/// </param>
		/// <param name="slack_less_than">
		/// Optional
		/// Display paths with slack less than this Default: 1e+30
		/// </param>
		/// <param name="slack_greater_than">
		/// Optional
		/// Display paths with slack greater than this Default: -1e+30
		/// </param>
		/// <param name="report_unconstrained">
		/// Optional
		/// Report unconstrained end points
		/// </param>
		/// <param name="significant_digits">
		/// Optional
		/// Number of digits to display: Range: 0 to 3 Default: 3
		/// </param>
		/// <param name="scale">
		/// Optional
		/// Type of scale on which to draw the histogram; Values:
		/// linear, logarithmic Default: linear
		/// </param>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void create_slack_histogram(string to, string group, string cells, string delay_type = null, string num_bins = null, string slack_less_than = null, string slack_greater_than = null, bool? report_unconstrained = null, string significant_digits = null, string scale = null, string name = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("create_slack_histogram");
			_tcl.Add(command);
		}
		/// <summary>
		/// Deletes a list of available QoR suggestions
		///
		/// Removes QoR suggestion objects that are currently in memory. Suggestion objects are generated
		/// running the report_qor_suggestion command, without specifying -of_objects, and by
		/// reading an RQS file using the read_qor_suggestions command. You can get QoR objects by
		/// using the get_qor_suggestions command.
		///
		/// The following deletes all the suggestion objects in memory:
		/// delete_qor_suggestions [get_qor_suggestions]
		/// The following deletes only the Utilization suggestions:
		/// delete_qor_suggestions [get_qor_suggestions -filter {CATEGORY==Utilization}]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 458
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="IDs">
		/// Optional
		/// Match suggestion names against given names
		/// </param>
		public void delete_qor_suggestions(bool? quiet = null, bool? verbose = null, string IDs = null)
		{
			var command = new SimpleTCLCommand("delete_qor_suggestions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Clear a set of timing results from memory
		///
		/// Clear the specified timing results from the named result set. Both the type of the timing report,
		/// and the name of the timing report must be specified, or the command will fail.
		///
		/// The following example clears the specified results set from memory:
		/// delete_timing_results -type clock_interaction clkNets
		///
		/// See ug835-vivado-tcl-commands.pdf, page 468
		/// </summary>
		/// <param name="name">
		/// Required
		/// Name for the set of results to clear
		/// </param>
		/// <param name="type">
		/// Optional
		/// Type of timing results to clear; Values: bus_skew,
		/// check_timing, clock_interaction, clock_domain_crossings,
		/// config_timing, datasheet, pulse_width, slack_histogram,
		/// timing_path, timing_summary
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void delete_timing_results(string name, string type = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("delete_timing_results");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the routed or estimated delays in picoseconds on a net from the driver to each load pin.
		///
		/// Get delay objects for the specified nets in the current design, from the driver to each load pin, or
		/// to specified load pins, through specific pins.
		/// The delay object contains properties defining the maximum and minimum delays for the fast and
		/// slow process corners. Use the get_property command to extract the property of interest from
		/// the delay object. Delay property values on the delay object are specified in picoseconds.
		/// TIP: In most cases the Vivado tools return delay values specified in nanoseconds, but the delay object uses
		/// picoseconds.
		/// The values returned are calculated or estimated depending upon whether the net is routed.
		/// Delay values can include the actual delay of routed interconnect, or estimated net delays for
		/// unrouted nets. The net delay can also include delay through logic elements or device sites, or just
		/// include the interconnect delay.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		/// The get_net_delays command returns the delay objects for the specified nets, or returns an
		/// error if it fails.
		///
		/// The following example gets the interconnect delay values for the specified net, and returns it in
		/// the form of a delay object:
		/// report_property -all [lindex [get_net_delays -interconnect_only \
		/// -of_objects [get_nets control_reg[*]]] 16 ]
		/// TIP: The FAST_MAX, FAST_MIN, SLOW_MAX, and SLOW_MIN properties on the delay object are reported in
		/// picoseconds.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 818
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Get 'net_delay' objects of these types: 'net'.
		/// </param>
		/// <param name="to">
		/// Required
		/// Get the delay of the net to the given terminal(s) or port(s).
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// Perform case-insensitive matching. (valid only when -regexp
		/// specified)
		/// </param>
		/// <param name="patterns">
		/// Optional
		/// Match the 'net_delay' objects against patterns. Default: *
		/// </param>
		/// <param name="filter">
		/// Optional
		/// Filter list with expression
		/// </param>
		/// <param name="interconnect_only">
		/// Optional
		/// Include only interconnect delays. The default is to include
		/// the intra-site delay.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>net_delays</returns>
		public void get_net_delays(string of_objects, string to, bool? regexp = null, bool? nocase = null, string patterns = null, string filter = null, bool? interconnect_only = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("get_net_delays");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of available QoR suggestions
		///
		/// Get existing QoR suggestion objects created by the report_qor_suggestions command, or
		/// read into the design using read_qor_suggestions. The selected QoR objects can be written
		/// to a file using the write_qor_suggestions command. The suggestions created by the report
		/// command remain in memory until delete_qor_suggestions is run, or until it is overwritten
		/// by another report.
		/// This command returns a list of existing QoR suggestion objects from the open design, or returns
		/// an error if it fails.
		///
		/// To return an individual suggestion, you can supply the full ID:
		/// get_qor_suggestions RQS_CLOCK-5_1-1
		/// Due to the naming style of suggestions, wildcard searches do NOT work directly. However you
		/// can use the filter command with -regexp to use wildcards as follows:
		/// filter -regexp [get_qor_suggestions] {NAME =~ RQS_CLOCK.*}
		/// You can also filter suggestions objects within a given category. Available categories include:
		/// Timing, Congestion, Utilization, XDC, Clocking, and Strategy. For example, the following returns
		/// suggestions related to the Timing category:
		/// get_qor_suggestions -filter {CATEGORY==Timing}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 883
		/// </summary>
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
		/// <param name="IDs">
		/// Optional
		/// Match suggestion names against given names
		/// </param>
		/// <returns>list of qor suggestion objects</returns>
		public void get_qor_suggestions(string filter = null, bool? quiet = null, bool? verbose = null, string IDs = null)
		{
			var command = new SimpleTCLCommand("get_qor_suggestions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of timing arcs
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
		/// See ug835-vivado-tcl-commands.pdf, page 925
		/// </summary>
		/// <param name="from">
		/// Required
		/// List of pin or ports
		/// </param>
		/// <param name="to">
		/// Required
		/// List of pin or ports
		/// </param>
		/// <param name="of_objects">
		/// Required
		/// Get timing arcs for these cells
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
		/// <returns>list of timing arc objects</returns>
		public void get_timing_arcs(string from, string to, string of_objects, string filter = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("get_timing_arcs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get timing paths
		///
		/// Gets timing path objects that meet the specified criteria. This command can be used to predefine
		/// timing paths to pass to the report_timing command for instance. Another usage of this
		/// command is to create custom reporting and analysis.
		/// The get_timing_paths command is very similar to the report_timing command.
		/// However, get_timing_paths returns timing path objects which can be queried for properties,
		/// or passed to other Tcl commands for processing, where report_timing returns a file or a
		/// string.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets the five worst timing paths from the specified endpoint, and reports
		/// all the properties of the fourth timing path in the list:
		/// report_property -all [lindex [get_timing_paths -to [get_ports led_pins[*]]
		/// \
		/// -nworst 5] 3]
		/// The following example defines a procedure called custom_report, then reports the 100 worst
		/// paths from the clk_tx_clk_core_1 path group using that proc:
		/// proc custom_report { listOfPaths } {
		/// puts [format {%-40s %-40s %-20s %-20s %7s} "Startpoint" "Endpoint" \
		/// "Launch Clock" "Capture Clock" "Slack"]
		/// puts [string repeat "-" 140]
		/// foreach path $listOfPaths {
		/// set startpoint [get_property STARTPOINT_PIN $path]
		/// set startclock [get_property STARTPOINT_CLOCK $path]
		/// set endpoint [get_property ENDPOINT_PIN $path]
		/// set endclock [get_property ENDPOINT_CLOCK $path]
		/// set slack [get_property SLACK $path]
		/// puts [format {%-40s %-40s %-20s %-20s %7s} $startpoint $endpoint \
		/// $startclock $endclock $slack]
		/// }
		/// }
		/// set paths [get_timing_paths -group clk_tx_clk_core_1 -max_paths 100]\
		/// custom_report $path
		/// The following example illustrates how timing path objects can be used with the
		/// report_timing command:
		/// set paths [get_timing_paths -group clk_tx_clk_core_1 -max_paths 100]
		/// report_timing -of_objects $paths
		/// Which is the equivalent of:
		/// report_timing -group clk_tx_clk_core_1 -max_paths 100
		/// The following example returns timing paths where the logic levels are greater than the specified
		/// number of logic levels:
		/// get_timing_paths -max_paths 1000 -filter {LOGIC_LEVELS > 1}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 928
		/// </summary>
		/// <param name="from">
		/// Required
		/// From pins, ports, cells or clocks
		/// </param>
		/// <param name="rise_from">
		/// Required
		/// Rising from pins, ports, cells or clocks
		/// </param>
		/// <param name="fall_from">
		/// Required
		/// Falling from pins, ports, cells or clocks
		/// </param>
		/// <param name="to">
		/// Required
		/// To pins, ports, cells or clocks
		/// </param>
		/// <param name="rise_to">
		/// Required
		/// Rising to pins, ports, cells or clocks
		/// </param>
		/// <param name="fall_to">
		/// Required
		/// Falling to pins, ports, cells or clocks
		/// </param>
		/// <param name="through">
		/// Required
		/// Through pins, ports, cells or nets
		/// </param>
		/// <param name="rise_through">
		/// Required
		/// Rising through pins, ports, cells or nets
		/// </param>
		/// <param name="fall_through">
		/// Required
		/// Falling through pins, ports, cells or nets
		/// </param>
		/// <param name="group">
		/// Required
		/// Limit paths in this group(s)
		/// </param>
		/// <param name="cell">
		/// Required
		/// run get_timing_paths on the cell
		/// </param>
		/// <param name="delay_type">
		/// Optional
		/// Type of path delay: Values: max, min, min_max, max_rise,
		/// max_fall, min_rise, min_fall Default: max
		/// </param>
		/// <param name="setup">
		/// Optional
		/// Get max delay timing paths (equivalent to -delay_type max)
		/// </param>
		/// <param name="hold">
		/// Optional
		/// Get min delay timing paths (equivalent to -delay_type min)
		/// </param>
		/// <param name="max_paths">
		/// Optional
		/// Maximum number of paths to return: Value >=1 Default: 1
		/// </param>
		/// <param name="nworst">
		/// Optional
		/// List N worst paths to endpoint: Value >=1 Default: 1
		/// </param>
		/// <param name="unique_pins">
		/// Optional
		/// for each unique set of pins, show at most 1 path per path
		/// group
		/// </param>
		/// <param name="slack_lesser_than">
		/// Optional
		/// Include paths with slack less than this Default: 1e+30
		/// </param>
		/// <param name="slack_greater_than">
		/// Optional
		/// Include paths with slack greater than this Default: -1e+30
		/// </param>
		/// <param name="no_report_unconstrained">
		/// Optional
		/// Do not get unconstrained paths
		/// </param>
		/// <param name="user_ignored">
		/// Optional
		/// only report paths which have infinite slack because of
		/// set_false_path or set_clock_groups timing constraints
		/// </param>
		/// <param name="routable_nets">
		/// Optional
		/// store the number of routable nets traversed as a property
		/// on timing paths.
		/// </param>
		/// <param name="sort_by">
		/// Optional
		/// Sorting order of paths: Values: group, slack Default: slack
		/// </param>
		/// <param name="filter">
		/// Optional
		/// Filter list with expression
		/// Name Description
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Patterns specified in filter are full regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// Perform case-insensitive matching for patterns specified in
		/// filter (valid only when -regexp specified)
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void get_timing_paths(string from, string rise_from, string fall_from, string to, string rise_to, string fall_to, string through, string rise_through, string fall_through, string group, string cell, string delay_type = null, bool? setup = null, bool? hold = null, string max_paths = null, string nworst = null, bool? unique_pins = null, string slack_lesser_than = null, string slack_greater_than = null, bool? no_report_unconstrained = null, bool? user_ignored = null, bool? routable_nets = null, string sort_by = null, string filter = null, bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("get_timing_paths");
			_tcl.Add(command);
		}
		/// <summary>
		/// Read QoR Suggestions from the given file
		///
		/// Read the specified file and extract the QoR suggestions from the file.
		/// This command returns the name of the QoR file read, or returns an error if it fails.
		///
		/// The following example reads the QoR suggestions from the specified file, and then reports the
		/// QoR suggestions in the open design:
		/// read_qor_suggestions C:/Data/qor_results.rqs
		/// report_qor_suggestions -of_objects [get_qor_suggestions]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1153
		/// </summary>
		/// <param name="file">
		/// Required
		/// QoR suggestions file Values: Path to the QoR suggestions
		/// file, typically ending with .rqs.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void read_qor_suggestions(string file, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("read_qor_suggestions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report timing paths
		///
		/// Report the calculated bus skew among the signals constrained by set_bus_skew.
		/// The bus skew requirement applies to both the slow and fast corners. The Vivado tool determines
		/// the earliest and the latest arrival among all the signals of the bus and calculates the bus skew for
		/// both the Slow and Fast process corner, and reports the worst case skew. Each signal of the bus is
		/// reported relative to a reference signal from the same bus. Note that the reference signal can be
		/// different for each signal of the bus, which ever results in the worst bus skew for that signal.
		/// The bus skew report can be written to the Tcl console or command shell, assigned to a return
		/// string, or saved to a file.
		/// This command returns the bus skew report as specified, or returns an error if it fails.
		///
		/// The following example reports the bus skew for the 32 worst signals of each bus skew
		/// constraints in the design, reporting 1 path per bit of the bus with the full timing path, including
		/// input pins, with timing values:
		/// report_bus_skew -max 32 -nworst 1 -path_type full -input_pins
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1270
		/// </summary>
		/// <param name="cells">
		/// Required
		/// run report_bus_skew on the specified hierarchical cell(s)
		/// </param>
		/// <param name="delay_type">
		/// Optional
		/// Type of path delay: Values: max, min, min_max Default:
		/// min_max
		/// </param>
		/// <param name="setup">
		/// Optional
		/// Report max delay endpoint timing paths (equivalent to -
		/// delay_type max)
		/// </param>
		/// <param name="hold">
		/// Optional
		/// Report min delay endpoint timing paths (equivalent to -
		/// delay_type min)
		/// </param>
		/// <param name="no_detailed_paths">
		/// Optional
		/// Only report top level summary table
		/// </param>
		/// <param name="max_paths">
		/// Optional
		/// Maximum number of paths to output per bus skew
		/// constraint: Value >=1 Default: 1
		/// </param>
		/// <param name="nworst">
		/// Optional
		/// List up to N worst paths per endpoint per constraint: Value
		/// >=1 Default: 1
		/// </param>
		/// <param name="unique_pins">
		/// Optional
		/// For each unique set of pins, show at most 1 path per bus
		/// skew constraint
		/// </param>
		/// <param name="path_type">
		/// Optional
		/// Format for path report: Values: short, full, full_clock,
		/// full_clock_expanded Default: full_clock_expanded
		/// </param>
		/// <param name="sort_by_slack">
		/// Optional
		/// Sort summary and per-constraint sections by slack
		/// </param>
		/// <param name="input_pins">
		/// Optional
		/// Show input pins in path
		/// </param>
		/// <param name="no_header">
		/// Optional
		/// Do not generate a report header
		/// </param>
		/// <param name="significant_digits">
		/// Optional
		/// Number of digits to display: Range: 0 to 3 Default: 3
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, don't overwrite the results file
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// Return report as string
		/// </param>
		/// <param name="warn_on_violation">
		/// Optional
		/// Issue a critical warning when the report contains a timing
		/// violation
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
		public void report_bus_skew(string cells, string delay_type = null, bool? setup = null, bool? hold = null, bool? no_detailed_paths = null, string max_paths = null, string nworst = null, bool? unique_pins = null, string path_type = null, bool? sort_by_slack = null, bool? input_pins = null, bool? no_header = null, string significant_digits = null, string file = null, bool? append = null, bool? return_string = null, bool? warn_on_violation = null, string rpx = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_bus_skew");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report the clock domain crossing (CDC) paths in the current design.
		///
		/// This report shows in detail the clock domain crossing (CDC) paths in the current synthesized or
		/// implemented design. The command analyzes paths between asynchronous clocks, or clocks with
		/// no common period, as well as synchronous paths ignored by the user due to false path or max
		/// delay datapath_only exceptions.
		/// By default the report_cdc command reports domain crossing between all clocks in the design.
		/// However, you can limit the clocks of interest using the -from and -to options to specify the
		/// clock domains of interest.
		/// The report_cdc command only reports on paths where both source and destination clocks are
		/// defined. You should run the check_timing command prior to report_cdc to ensure that
		/// there are no unconstrained clocks in the design. I/O paths are only covered by report_cdc
		/// when input or output delay constraints have been specified on the I/O ports.
		/// The severity of the path report could be Critical, Warning or Info depending on the CDC
		/// topology identified. An unknown synchronization topology is Critical and needs to be reviewed.
		/// A double register synchronizer with missing ASYNC_REG property is a Warning. Clock Enable,
		/// MUX, and MUX Hold CDC structures are categorized as Warnings because you should check to
		/// ensure that the structure is safe. Other CDC paths are of severity Info.
		/// The report_cdc command returns the following information:
		/// • Severity
		/// • Source Clock
		/// • Destination Clock
		/// • CDC Type
		/// • Exceptions
		/// • Endpoints
		/// • Safe
		/// • Unknown
		/// • No ASYNC_REG property
		/// IMPORTANT! You cannot use the set_msg_config command to configure the severity of messages
		/// returned by the report_cdc command. This command does not generate messages through the message
		/// manager.
		///
		/// The following example reports the clock domain crossings in the current design, including any
		/// waived paths, using a verbose report form, and saving the results to a file:
		/// report_cdc -details -show_waiver -file C:/Data/cdc_report.txt
		/// The following example reports the clock domain crossings from a clock specified by name, to
		/// another specified as a clock object:
		/// report_cdc -from clk_pin_p -to [get_clocks clk_rx_clk_core]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1276
		/// </summary>
		/// <param name="from">
		/// Required
		/// From clocks
		/// </param>
		/// <param name="to">
		/// Required
		/// To clocks
		/// </param>
		/// <param name="cells">
		/// Required
		/// run report_cdc on the cells
		/// </param>
		/// <param name="details">
		/// Optional
		/// report the detail of the CDC timing paths not safely timed
		/// </param>
		/// <param name="summary">
		/// Optional
		/// report a summary by clocks of the CDC
		/// </param>
		/// <param name="all_checks_per_endpoint">
		/// Optional
		/// report all checks per endpoint
		/// </param>
		/// <param name="severity">
		/// Optional
		/// report only the severity specified (Info, Warning or Critical)
		/// </param>
		/// <param name="no_header">
		/// Optional
		/// Do not generate a report header
		/// </param>
		/// <param name="show_waiver">
		/// Optional
		/// Show the waived paths
		/// </param>
		/// <param name="no_waiver">
		/// Optional
		/// Ignore the waiver
		/// </param>
		/// <param name="waived">
		/// Optional
		/// Show only the waived paths
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, don't overwrite the results file
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// return report as string
		/// </param>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void report_cdc(string from, string to, string cells, bool? details = null, bool? summary = null, bool? all_checks_per_endpoint = null, string severity = null, bool? no_header = null, bool? show_waiver = null, bool? no_waiver = null, bool? waived = null, string file = null, bool? append = null, bool? return_string = null, string name = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_cdc");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report on clock timing paths and unclocked registers
		///
		/// Reports clock interactions and signals that cross clock domains to identify potential problems
		/// such a metastability, or data loss, or incoherency, where some visibility into the paths that cross
		/// clock domains is beneficial. This command requires an open synthesized or implemented design.
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be
		/// written to a file or returned as a string if desired.
		///
		/// The following example sets the model for interconnect delay, selects a device speed grade, and
		/// then runs report_clock_interaction:
		/// set_delay_model -interconnect none
		/// set_speed_grade -3
		/// report_clock_interaction -delay_type min_max \
		/// -significant_digits 3 -name "results_1"
		/// The following example returns the clock interactions, writing the report to the GUI, to the
		/// specified file, and returns a string which is assigned to the specified variable:
		/// set clk_int [report_clock_interaction -file clk_int.txt -name clk_int1 \
		/// -return_string]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1280
		/// </summary>
		/// <param name="cells">
		/// Required
		/// run report_clock_interaction on the specified cell(s)
		/// </param>
		/// <param name="delay_type">
		/// Optional
		/// Type of path delay: Values: max, min, min_max Default: max
		/// </param>
		/// <param name="setup">
		/// Optional
		/// Consider max delay timing paths (equivalent to -delay_type
		/// max)
		/// </param>
		/// <param name="hold">
		/// Optional
		/// Consider min delay timing paths (equivalent to -delay_type
		/// min)
		/// </param>
		/// <param name="significant_digits">
		/// Optional
		/// Number of digits to display: Range: 0 to 3 Default: 2
		/// </param>
		/// <param name="no_header">
		/// Optional
		/// do not generate a report header
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, don't overwrite the results file
		/// </param>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// Return report as string
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void report_clock_interaction(string cells, string delay_type = null, bool? setup = null, bool? hold = null, string significant_digits = null, bool? no_header = null, string file = null, bool? append = null, string name = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_clock_interaction");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report clock networks
		///
		/// Reports the network fanout of each clock net in the open synthesized or implemented design.
		/// The graphical form of the report, returned when the -name argument is specified, provides a
		/// hierarchical tree view of the clock network.
		/// The default report simply specifies the clock net names and the instance pins that are the
		/// startpoint of the clock.
		/// The report is returned to the standard output unless the -file, -return_string, or -name
		/// arguments are specified.
		///
		/// The following example reports the clock network names and startpoints to the specified file:
		/// report_clock_networks -file C:/Data/ClkNets.txt
		/// The following example reports the endpoints of the specified clock:
		/// report_clock_networks -endpoints_only -clocks wbClk
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1283
		/// </summary>
		/// <param name="clocks">
		/// Required
		/// List of clocks for clock network dump; if not specified, all
		/// clock networks are dumped
		/// </param>
		/// <param name="unconstrained_roots">
		/// Required
		/// List of unconstrained root pins/ports for clock network
		/// dump; if not specified, all unconstrained clock roots are
		/// dumped
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, don't overwrite the results file
		/// </param>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// return report as string
		/// </param>
		/// <param name="endpoints_only">
		/// Optional
		/// dump clock network endpoints only; Not to be used in
		/// conjunction with -levels option
		/// </param>
		/// <param name="levels">
		/// Optional
		/// expands clock network upto n levels of instances, Value: n >
		/// 0; Not to be used in conjunction with -endpoints_only option
		/// Default: 0
		/// </param>
		/// <param name="expand_buckets">
		/// Optional
		/// expands bucketed endpoints and displays pins; By default,
		/// endpoint pins are bucketed by celltype; This option only
		/// works in conjunction with -levels option or -endpoints_only
		/// option
		/// </param>
		/// <param name="suppress_endpoints">
		/// Optional
		/// suppress paths to clock or nonclock endpoint pins; Values:
		/// clock, nonclock
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void report_clock_networks(string clocks, string unconstrained_roots, string file = null, bool? append = null, string name = null, bool? return_string = null, bool? endpoints_only = null, string levels = null, bool? expand_buckets = null, string suppress_endpoints = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_clock_networks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report information about clock nets in design
		///
		/// Returns information related to clock nets in the design and clock resource usage on the target
		/// device.
		/// The generated clock utilization report can generate placement constraints for the currently
		/// placed clock resources. You can use these constraints to preserve the placement of clock
		/// resources for future iterations of the design, by using the -write_xdc option.
		/// IMPORTANT! For Ultrascale devices, if the intent is to recreate the current clock placement then use the
		/// BUFGCE LOC properties from the written XDC file. However, if the intent is to use the constraints as a starting
		/// point for the clocking architecture, while allowing the Vivado Design Suite some flexibility in placing clock
		/// resources, use the equivalent CLOCK_REGION properties instead of the BUFGCE LOC properties.
		/// By default the report is written to the Tcl console or STD output. However, the results can also
		/// be written to a file or returned as a string if desired.
		///
		/// The following example returns information about the clock nets in the design and the clock
		/// resources utilized on the target device, and writes it to the specified file:
		/// report_clock_utilization -file C:/Data/FPGA_Design/clock_util.txt
		/// The following example reports the clock nets and clock resource utilization to the standard
		/// output, but writes the XDC location constraints to the specified file:
		/// report_clock_utilization -write_xdc clock_util_xdc.txt
		/// Note: Because the path is not specified as part of the XDC file name, the file will be created in the current
		/// working directory, or the directory from which the tool was launched.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1286
		/// </summary>
		/// <param name="cells">
		/// Required
		/// Cells/bel_instances for which to report clock utilization
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append to existing file
		/// </param>
		/// <param name="write_xdc">
		/// Optional
		/// file to output clock constraint. File name must be given.
		/// </param>
		/// <param name="clock_roots_only">
		/// Optional
		/// Report only the Clock Root Assignments
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// return report as string
		/// </param>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>Report</returns>
		public void report_clock_utilization(string cells, string file = null, bool? append = null, string write_xdc = null, bool? clock_roots_only = null, bool? return_string = null, string name = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_clock_utilization");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report clocks
		///
		/// Returns a table showing all the clocks in a design, including propagated clocks, generated and
		/// auto-generated clocks, virtual clocks, and inverted clocks in the current synthesized or
		/// implemented design. More detailed information about each clock net can be obtained with the
		/// report_clock_utilization command.
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be
		/// written to a file or returned as a string if desired.
		///
		/// The following example returns the name, period, waveform, and sources of the clocks in the
		/// current design:
		/// report_clocks -file C:/Data/FPGA_Design/clock_out.txt
		/// The following example reports the clocks in the design with "Clock" in the name:
		/// report_clocks *Clock*
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1289
		/// </summary>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, don't overwrite the results file
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
		/// <param name="clocks">
		/// Optional
		/// List of clocks Default: *
		/// </param>
		public void report_clocks(string file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null, string clocks = null)
		{
			var command = new SimpleTCLCommand("report_clocks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report settings affecting timing analysis
		///
		/// Report the configuration of timing constraints of the current design.
		/// By default the report is abbreviated, containing only a few key timing constraints. Use the -all
		/// argument to return all timing related configuration.
		///
		/// The following example reports the current timing configuration, returns the information as a
		/// string, and sets that string into the specified Tcl variable:
		/// set timeConfig [report_config_timing -all -no_header -return_string]
		/// puts $timeConfig
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1298
		/// </summary>
		/// <param name="file">
		/// Optional
		/// Output the results to file
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, don't overwrite the results file
		/// </param>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// return report as string
		/// </param>
		/// <param name="all">
		/// Optional
		/// report all configuration settings (by default, only the
		/// typically important settings are reported
		/// </param>
		/// <param name="no_header">
		/// Optional
		/// do not generate a report header
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
		public void report_config_timing(string file = null, bool? append = null, string name = null, bool? return_string = null, bool? all = null, bool? no_header = null, string rpx = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_config_timing");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report data sheet
		///
		/// Create a "datasheet" report for the current design. Reports setup and hold times of input I/Os in
		/// relation to clocks, max/min delays from clocks to output pads, skews of input/ output buses.
		/// The datasheet report has the timing characteristics of a design at the package balls/pads,
		/// including the package trace flight times. To disable flight times use the following command:
		/// config_timing_analysis -disable_flight_delays true
		/// The source synchronous output skew can be automatically calculated by the Vivado Design Suite
		/// by using the -group switch for report_datasheet and grouping together all the ports of the
		/// data bus including the sourced clock output port. The sourced clock output port must be first in
		/// the group list. For example:
		/// report_datasheet -file output_filename -group [get_ports \
		/// {clock_port data_bit[0] data_bit[1] data_bit[2]}]
		///
		/// The following example returns the datasheet sorted by ports, for all process corners:
		/// report_datasheet -sort_by port -show_all_corners
		/// The following example reports the datasheet with the skew calculation for two groups of ports,
		/// with the first port of each group providing the reference for the skew calculation for that group.
		/// In this example, CLK0OUT is the forwarded clock for DATA0-4 and CLK1OUT is the forwarded
		/// clock for DATA4-7:
		/// report_datasheet -file ds.txt -group [get_ports \
		/// {CLK0OUT DATA0 DATA1 DATA2 DATA3}] \
		/// -group [get_ports {CLK1OUT DATA4 DATA5 DATA6 DATA7}]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1304
		/// </summary>
		/// <param name="group">
		/// Required
		/// List of output ports for skew calculation
		/// </param>
		/// <param name="significant_digits">
		/// Optional
		/// Number of digits to display: Range: 0 to 3 Default: 3
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, don't overwrite the results file
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// return report as string
		/// </param>
		/// <param name="sort_by">
		/// Optional
		/// Sorting order: Values: clock, port Default: clock
		/// </param>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name
		/// </param>
		/// <param name="show_all_corners">
		/// Optional
		/// provide all corners
		/// </param>
		/// <param name="show_oe_timing">
		/// Optional
		/// show output enable (tristate) timing
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
		public void report_datasheet(string group, string significant_digits = null, string file = null, bool? append = null, bool? return_string = null, string sort_by = null, string name = null, bool? show_all_corners = null, bool? show_oe_timing = null, string rpx = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_datasheet");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report Design Analysis
		///
		/// Provides timing data on critical path characteristics and complexity of the design to help identify
		/// and analyze problem areas that are subject to timing closure issues and routing congestion. For
		/// more information on this command refer to the Vivado Design Suite User Guide: Design Analysis
		/// and Closure Techniques (UG906).
		/// The report_design_analysis command currently has three modes of operation:
		/// • Timing: reports timing and physical characteristics of timing paths.
		/// • Complexity: analyzes the design for routing complexity and LUT distribution.
		/// • Congestion: analyzes the design for routing congestion.
		/// In timing mode, the command calls the static timing engine to analyze critical path data and
		/// report the characteristics of each path. The path characteristics include important elements such
		/// as clock skew, placement obstacles such as crossing clock regions, and physical constraints such
		/// as Pblocks and LOCs. The list of paths can be extended to include a number of top critical paths
		/// or specific paths can be analyzed by providing timing path objects to the command. The reports
		/// can also be extended to show the paths preceding and following the critical path.
		/// The following are definitions of the characteristics of the paths reported in timing mode:
		/// • PATH_TYPE: either SETUP or HOLD.
		/// • REQUIREMENT: delay requirement from static timing analysis.
		/// • PATH DELAY: data path delay from static timing analysis.
		/// • LOGIC DELAY: the portion of the PATH DELAY attributed to logic on the path.
		/// • NET DELAY: the portion of the PATH DELAY attributed to wires on the path. Note that the
		/// net delay is based on the estimated or actual routing delay as specified by the
		/// set_delay_model command.
		/// • CLOCK SKEW: difference in delay between the source and destination clocks.
		/// • SLACK: path timing slack from static timing analysis.
		/// • CLOCK RELATIONSHIP: SAME_CLOCK or RELATED_CLOCK. Helps identify potentially
		/// missed inter-clock constraints.
		/// • TIMING EXCEPTION: the timing exceptions, like set_false_path or
		/// set_multicycle_path, that are assigned to the path.
		/// • LOGIC LEVELS: number of logic levels between the source and destination, reported when
		/// the -logic_level_distribution is specified.
		/// • LOGICAL PATH: shorthand notation showing the ordered list of cells in the path including the
		/// start point and end point.
		/// Note: For Partial Reconfiguration (PR) designs, the logical path is appended to identify the cell as
		/// belonging to a reconfigurable partition (:RP#), or to the static region of the design (:S). A translation
		/// table at the bottom of the report maps :RP# to a specific reconfigurable partition.
		/// • START POINT CLOCK: the clock domain of the start point of the path.
		/// • END POINT CLOCK: the clock domain of the end point of the path.
		/// • START POINT PIN PRIMITIVE: the library cell and pin of the start point of the path.
		/// • END POINT PIN PRIMITIVE: the library cell and pin of the end point of the path.
		/// • START POINT PIN: the instance and pin name of the start point.
		/// • END POINT PIN: the instance and pin name of the end point.
		/// • COMB DSP: number of combinational DSP blocks in the path.
		/// • DOA REG: the number of DOA registers on the path.
		/// • DOB REG: the number of DOB registers on the path.
		/// • MREG: the number of MREG registers on the path.
		/// • PREG: the number of PREG registers on the path.
		/// • BRAM CROSSINGS: number of block RAM columns traversed by the path.
		/// • DSP CROSSINGS: number of DSP block columns traversed by the path.
		/// • IO CROSSINGS: number of IO columns traversed by the path.
		/// • CONFIG CROSSINGS: the number of CONFIG tile traversed by the path.
		/// • SLR CROSSINGS: number of SLRs traversed by the path.
		/// • BOUNDING BOX SIZE: the rectangular area covered by the critical path, measured in RPM
		/// GRID units which are based on the device RPM_X (horizontal) and RPM_Y (vertical) site
		/// coordinates. Since different sites (slices, DSP, block RAM, etc.) have different sizes, each site
		/// has unique RPM_X and RPM_Y properties to pinpoint its location within the device.
		/// • CLOCK REGION DISTANCE: An ordered pair showing the number of clock regions traversed
		/// in the horizontal and vertical directions from path startpoint to endpoint. Minimizing clock
		/// region crossings can improve critical path delay and clock skew.
		/// ○ Example 1: A critical path begins in clock region X1Y1 and ends in clock region X3Y3,
		/// resulting in a CLOCK_REGION_DISTANCE of (2, 2).
		/// ○ Example 2: a critical path begins in clock region X2Y1 and ends in X0Y0, resulting in a
		/// CLOCK_REGION_DISTANCE of (-2, -1).
		/// • PBLOCKS: number of Pblocks traversed by the path.
		/// • HIGH FANOUT: the greatest fanout of a net in the path.
		/// • CUMULATIVE FANOUT: the total fanout on the path.
		/// • DONT TOUCH: number of cells in the path with DONT_TOUCH value of TRUE. A value of
		/// TRUE for DONT_TOUCH on a cell prevents it from being optimized, disabling potentially
		/// beneficial optimizations such as phys_opt_design replication.
		/// • MARK DEBUG: number of cells in the path with a MARK_DEBUG value of TRUE. By default a
		/// net with MARK_DEBUG has DONT_TOUCH set to TRUE which disables optimization on that
		/// net. The DONT_TOUCH can be set to FALSE to enable optimization and potentially improve
		/// timing.
		/// • FIXED LOC: number of placed cells in the path with an IS_LOC_FIXED value of TRUE. FIXED
		/// cells cannot be moved by either place_design or phys_opt_design.
		/// • FIXED ROUTE: number of routed nets in the path with IS_ROUTE_FIXED value of TRUE.
		/// FIXED routes cannot be ripped up and rerouted by route_design.
		/// • HOLD FIX DETOUR: the amount of routing detour provided to fix hold timing to post-route
		/// critical paths.
		/// • COMBINED LUT PAIRS: number of LUT cells in the path that have been combined with other
		/// LUT cells into the same LUT BEL to use both the O6 and O5 outputs. LUT cells that have been
		/// combined with LUTNM, HLUTNM, or SOFT_HLUTNM can be uncombined and re-placed by
		/// setting their HLUTNM properties to an empty string. This allows exploring LUT combining and
		/// un-combining effects on timing and congestion reduction.
		/// • The following fields are reported for Partial Reconfiguration (PR) designs. Refer to the Vivado
		/// Design Suite User Guide: Dynamic Function eXchange (UG909) for more information.
		/// ○ PR PATH TYPE: Specifies the path as being completely in the static region, completely in a
		/// reconfigurable partition (RP), or as crossing the boundary between regions. The delay
		/// elements for the timing path are also broken down between the regions .
		/// ○ STATIC CROSSINGS: Reports the number of times a reconfigurable partition (RP) path
		/// crosses into the static region.
		/// ○ RP CROSSINGS: Reports the number of times a static region path crosses into a
		/// reconfigurable partition (RP) region.
		/// ○ BOUNDARY FANOUT: Reports the fanout of a boundary path at the PPLOC to its
		/// downstream loads .
		/// In complexity mode, the command performs complexity analysis of the current design and
		/// reports the Rent Exponent which is a measure of complexity, the Average Fanout, and a Primitive
		/// Histogram. The analysis can be performed on the top-level design or recursively on hierarchical
		/// levels of the design, with the ability to control the level of recursion.
		/// The following are definitions of the characteristics reported in complexity mode:
		/// • Rent: The Rent exponent, as defined by Rent's rule, is a measure of interconnect complexity in
		/// a netlist. Higher Rent indicates higher complexity and greater difficulty to avoid routing
		/// congestion. Most designs have a Rent in the 0.5 to 0.6 range. A Rent value of 0.65 is
		/// considered high and 0.85 is considered very high.
		/// • Average Fanout: This is the average fanout of a logic cell in the design, excluding global
		/// buffers. Higher average fanout may result in more difficulty for placement and routing. While
		/// absolute values may not predict difficultly, relative values between designs or between
		/// hierarchical levels may be more indicative.
		/// • Primitive Histogram: This displays the totals of certain primitive types used in the design. A
		/// high Rent may be caused by a predominance of LUT6 cells. If there are many more LUT6 than
		/// other size LUTs, the Rent may be reduced by adopting a more area-focused synthesis strategy.
		/// TIP: The complexity characteristics may not always predict routing congestion but can be used to pinpoint
		/// problem areas when congestion issues occur.
		/// In congestion mode the command analyzes the design and provides metrics to help you alleviate
		/// routing congestion. Using the results from the report_design_analysis command, you can
		/// change placement to avoid specific routing hot spots.
		/// The command returns the file created, or returns the analysis results to the Tcl console, or returns
		/// an error if it fails.
		///
		/// The following example performs complexity analysis of the two specified cells:
		/// report_design_analysis -complexity -cells {cpuEngine fftEngine}
		/// The following example performs complexity analysis of the specified bounding boxes:
		/// report_design_analysis -complexity \
		/// -bounding_boxes { "CLE_M_X21Y239:CLEL_R_X28Y254"
		/// "CLEL_R_X18Y171:CLE_M_X26Y186" }
		/// The following example provides an extended analysis of the worst critical path from the Block
		/// RAMs in the design:
		/// report_design_analysis -timing -of_timing_paths \
		/// [get_timing_paths -from [all_rams]]
		/// The following example performs complexity analysis for the specified cell, to a depth of two
		/// hierarchical levels, and performs timing and congestion analysis on the design:
		/// report_design_analysis -complexity -hierarchical_depth 2 -timing -setup \
		/// -hold -max_paths 10 -logic_level_distribution -logic_level_dist_paths 20 -
		/// congestion
		/// The following example uses the report_design_analysis command to return the timing
		/// paths with the specified end point clock and logic levels, and passes those paths to the
		/// report_timing command for analysis:
		/// report_timing -of_objects [report_design_analysis -end_point_clock cpuClk \
		/// -logic_levels 10 -timing -return_timing_paths]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1309
		/// </summary>
		/// <param name="cells">
		/// Required
		/// Report analysis information for given list of cells
		/// </param>
		/// <param name="bounding_boxes">
		/// Required
		/// Report interconnection complexity (Rent) for given list of
		/// bounding boxes Default: empty
		/// </param>
		/// <param name="of_timing_paths">
		/// Required
		/// Reports characteristics for these paths
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, don't overwrite the results file
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// Return report as string
		/// </param>
		/// <param name="complexity">
		/// Optional
		/// Finds the interconnection complexity (Rent) of the design
		/// </param>
		/// <param name="hierarchical_depth">
		/// Optional
		/// Hierarchical depth option for -complexity Default: 1
		/// </param>
		/// <param name="congestion">
		/// Optional
		/// Reports congestion of the design
		/// </param>
		/// <param name="min_congestion_level">
		/// Optional
		/// Minimum congestion level for reporting router congestion,
		/// integer value between 3 and 8 Default: 5
		/// </param>
		/// <param name="timing">
		/// Optional
		/// Reports characteristics of critical path
		/// </param>
		/// <param name="setup">
		/// Optional
		/// Reports characteristics of critical SETUP path
		/// </param>
		/// <param name="hold">
		/// Optional
		/// Reports characteristics of critical HOLD path
		/// </param>
		/// <param name="show_all">
		/// Optional
		/// Adds more characteristics to the timing characteristics
		/// report
		/// </param>
		/// <param name="full_logical_pin">
		/// Optional
		/// Display hierarchical pin names in the report
		/// </param>
		/// <param name="routed_vs_estimated">
		/// Optional
		/// Reports relevant characteristics of critical path in estimated
		/// mode
		/// </param>
		/// <param name="logic_level_distribution">
		/// Optional
		/// Reports logic level distribution
		/// </param>
		/// <param name="logic_level_dist_paths">
		/// Optional
		/// Number of critical paths for analyzing logic level distribution
		/// used along with -logic_level_distribution Default: 1000
		/// </param>
		/// <param name="min_level">
		/// Optional
		/// Group all paths with logic levels <min_level-1> and below
		/// into a single bin, value passed must be at least 1 Default:
		/// Not Used
		/// Name Description
		/// </param>
		/// <param name="max_level">
		/// Optional
		/// Group all paths with logic levels <max_level+1> and above
		/// into a single bin, where <max_level> must be the greater of
		/// zero or <min_level + 1> if -min_level is used Default: Not
		/// Used
		/// </param>
		/// <param name="return_timing_paths">
		/// Optional
		/// Returns timing path objects
		/// </param>
		/// <param name="max_paths">
		/// Optional
		/// Number of paths to consider for -timing option Default: 1
		/// </param>
		/// <param name="extend">
		/// Optional
		/// Reports characteristics of worst path before the start point
		/// of critical path and worst path after the end of the critical
		/// path
		/// </param>
		/// <param name="routes">
		/// Optional
		/// Reports distribution with respect to Routes instead of logic
		/// levels
		/// </param>
		/// <param name="end_point_clock">
		/// Optional
		/// Returns timing path objects filtered by a particular endpoint
		/// clock name as passed to this option
		/// </param>
		/// <param name="logic_levels">
		/// Optional
		/// Returns timing path objects bucketed under the bin name
		/// as passed to this option
		/// </param>
		/// <param name="qor_summary">
		/// Optional
		/// Design Flow summary
		/// </param>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name
		/// </param>
		/// <param name="no_pr_attribute">
		/// Optional
		/// Report without PR attributes
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void report_design_analysis(string cells, string bounding_boxes, string of_timing_paths, string file = null, bool? append = null, bool? return_string = null, bool? complexity = null, string hierarchical_depth = null, bool? congestion = null, string min_congestion_level = null, bool? timing = null, bool? setup = null, bool? hold = null, bool? show_all = null, bool? full_logical_pin = null, bool? routed_vs_estimated = null, bool? logic_level_distribution = null, string logic_level_dist_paths = null, string min_level = null, string max_level = null, bool? return_timing_paths = null, string max_paths = null, bool? extend = null, bool? routes = null, string end_point_clock = null, string logic_levels = null, bool? qor_summary = null, string name = null, bool? no_pr_attribute = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_design_analysis");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report disabled timing arcs
		///
		/// Displays a report of timing paths that will be excluded from timing analysis in the current
		/// synthesized or implemented design.
		/// The format of the report is organized into columns for "Cell or Port" to define the object
		/// associated with the timing path, "From" and "To" to define the timing path, the condition, and the
		/// reason for excluding the path from timing. The various reasons for exclusion are as follows:
		/// • constraint - set_disable_timing constraint is specified
		/// • constant - Logic constant
		/// • loop - Breaks a logic loop
		/// • bidirect instance path - Feedback path through bidirectional instances
		/// • bidirect net path - Feedback path on nets with bidirectional pins
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be
		/// written to a file or returned as a string if desired.
		///
		/// The following example reports all timing paths that will not be included in timing analysis:
		/// report_disable_timing
		/// The following example outputs the disable timing report as a string, stores it in a variable, and
		/// then puts it to the display:
		/// set bad_time [report_disable_timing -return_string]
		/// puts $bad_time
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1319
		/// </summary>
		/// <param name="cells">
		/// Required
		/// run report_disable_timing on the specified cell(s)
		/// </param>
		/// <param name="user_disabled">
		/// Optional
		/// report only user disabled arcs
		/// </param>
		/// <param name="column_style">
		/// Optional
		/// style for path report columns: Values: variable_width,
		/// anchor_left Default: variable_width
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, don't overwrite the results file
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
		public void report_disable_timing(string cells, bool? user_disabled = null, string column_style = null, string file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_disable_timing");
			_tcl.Add(command);
		}
		/// <summary>
		/// Run DRC
		///
		/// Check the current design against a specified set of design rule checks, or rule decks, and report
		/// any errors or violations that are found.
		/// The report_drc command requires an open design to check the design rules against. The
		/// command returns a report with the results of violations found by the design rule checks.
		/// Violations are returned as Vivado objects that can be listed with the get_drc_violations
		/// command, and are associated with cells, pins, ports, nets, and sites in the current design. You can
		/// get the cells, nets, and other design objects that are associated with DRC violation objects, using
		/// the -of_objects option of the get_cells command for instance.
		/// TIP: The report_drc can be multi-threaded to speed the process. Refer to the set_param command for
		/// more information on setting the general.maxThreads parameter.
		/// The Vivado tools include a large number of predefined design rule checks to be used by the
		/// report_drc command. Use the get_drc_checks command to list the currently defined
		/// design rule checks. You can also create new custom design rule checks using the
		/// create_drc_check command.
		/// A rule deck is a collection of design rule checks grouped for convenience, to be run at different
		/// stages of the FPGA design flow, such as during I/O planning or placement. The tool comes with a
		/// set of factory defined rule decks, but you can also create new user-defined rule decks with the
		/// create_drc_ruledeck command. Use the get_drc_ruledecks command to return a list
		/// of the currently defined rule decks available for use in the report_drc command.
		/// The report_drc command runs a default rule deck when the -checks or -ruledeck options
		/// are not specified. Creating a user-defined DRC automatically adds the new design rule check to
		/// the default rule deck.
		/// DRC rules can be enabled or disabled using the IS_ENABLED property on the rule check object.
		/// If a rule IS_ENABLED false, the rule will not be run by the report_drc command, whether it is
		/// specified directly using -checks, or indirectly with -ruledeck.
		/// TIP: You can reset the properties of a DRC rule to the factory default settings using the reset_drc_check
		/// command.
		/// You can reset the current results of the report_drc command, clearing any found violations,
		/// using the reset_drc command.
		///
		/// The following example lists the available rule decks. The results include all factory rule decks and
		/// all user-defined rule decks.
		/// get_drc_ruledecks
		/// The following example returns the list of DRC rules defined in the specified rule deck:
		/// get_drc_checks -of_objects [get_drc_ruledecks placer_checks]
		/// The following examples run the specified DRC rule deck and rules against the current design, and
		/// writes the results to the specified file:
		/// report_drc -ruledecks placer_checks -file C:/Data/DRC_Rpt1.txt
		/// report_drc -checks {IOCNT-1 IOPCPR-1 IOPCMGT-1 IOCTMGT-1 IODIR-1} \
		/// -file C:/Data/DRC_Rpt1.txt -append
		/// Note: The -append option adds the result of the second report_drc command to the specified file.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1322
		/// </summary>
		/// <param name="checks">
		/// Required
		/// DRC checks (see get_drc_checks for available checks)
		/// </param>
		/// <param name="ruledecks">
		/// Required
		/// Containers of DRC rule checks Default: default
		/// </param>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name
		/// </param>
		/// <param name="upgrade_cw">
		/// Optional
		/// Specifies if report_drc should upgrade all
		/// CRITICAL_WARNING violations to ERROR.
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="rpx">
		/// Optional
		/// Report filename for persisted results.
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, do not overwrite the results file
		/// </param>
		/// <param name="waived">
		/// Optional
		/// Output result is Waived checks
		/// </param>
		/// <param name="no_waivers">
		/// Optional
		/// Disable waivers for checks
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
		public void report_drc(string checks, string ruledecks, string name = null, bool? upgrade_cw = null, string file = null, string rpx = null, bool? append = null, bool? waived = null, bool? no_waivers = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_drc");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report timing exceptions
		///
		/// Report all timing exceptions applied to setup and hold checks defined by timing constraints in the
		/// current design, or report the exceptions on the specified timing paths.
		/// Timing exceptions can be defined by timing constraints such as set_false_path or
		/// set_multicycle_path that change the default assumptions for timing paths in the design.
		/// The exceptions are reported to the standard output by default, but can be redirected to a file or
		/// to a Tcl string variable.
		///
		/// This example reports all timing exceptions in the current design:
		/// report_exceptions
		/// This example reports all timing exceptions ignored or overridden in the current design:
		/// report_exceptions -ignored
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1331
		/// </summary>
		/// <param name="from">
		/// Required
		/// From pins, ports, cells or clocks
		/// </param>
		/// <param name="rise_from">
		/// Required
		/// Rising from pins, ports, cells or clocks
		/// </param>
		/// <param name="fall_from">
		/// Required
		/// Falling from pins, ports, cells or clocks
		/// </param>
		/// <param name="to">
		/// Required
		/// To pins, ports, cells or clocks
		/// </param>
		/// <param name="rise_to">
		/// Required
		/// Rising to pins, ports, cells or clocks
		/// </param>
		/// <param name="fall_to">
		/// Required
		/// Falling to pins, ports, cells or clocks
		/// </param>
		/// <param name="through">
		/// Required
		/// Through pins, ports, cells or nets
		/// </param>
		/// <param name="rise_through">
		/// Required
		/// Rising through pins, ports, cells or nets
		/// </param>
		/// <param name="fall_through">
		/// Required
		/// Falling through pins, ports, cells or nets
		/// </param>
		/// <param name="ignored">
		/// Optional
		/// Only report exceptions which are ignored
		/// </param>
		/// <param name="summary">
		/// Optional
		/// Report a summary of all exceptions
		/// </param>
		/// <param name="coverage">
		/// Optional
		/// Report the coverage of all timing exceptions
		/// </param>
		/// <param name="ignored_objects">
		/// Optional
		/// Report the list of ignored startpoints and endpoints
		/// </param>
		/// <param name="count_objects">
		/// Optional
		/// Report the number of objects in the timing exceptions
		/// </param>
		/// <param name="write_merged_exceptions">
		/// Optional
		/// Write merged timing exceptions
		/// </param>
		/// <param name="write_valid_exceptions">
		/// Optional
		/// Write timing exceptions with the valid objects only
		/// </param>
		/// <param name="no_header">
		/// Optional
		/// Do not generate a report header
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, don't overwrite the results file
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// Return report as string
		/// </param>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void report_exceptions(string from, string rise_from, string fall_from, string to, string rise_to, string fall_to, string through, string rise_through, string fall_through, bool? ignored = null, bool? summary = null, bool? coverage = null, bool? ignored_objects = null, bool? count_objects = null, bool? write_merged_exceptions = null, bool? write_valid_exceptions = null, bool? no_header = null, string file = null, bool? append = null, bool? return_string = null, string name = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_exceptions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report high fanout nets
		///
		/// Report the fanout of nets in the design, starting with the highest fanout nets, and working down.
		/// Options allow you to control various aspects of the report.
		/// This command can be run on an implemented design, or on the synthesized netlist. However, the
		/// results will be more complete on the implemented design.
		/// The command returns the fanout report of nets in the design, or returns an error if it fails.
		///
		/// The following example reports the top 100 nets with fanouts greater than 50 loads, returning a
		/// histogram of the results:
		/// report_high_fanout_nets -fanout_greater_than 50 -max_nets 100 -histogram
		/// The following example reports the fanout of nets for the specified clocks:
		/// report_high_fanout_nets -clocks [get_clocks gt*]
		/// This example reports the nets with fanouts less than 10 loads, and returns the results to a string
		/// stored as a Tcl variable:
		/// set myRep [report_high_fanout_nets -fanout_lesser_than 10 -return_string]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1338
		/// </summary>
		/// <param name="cells">
		/// Required
		/// Report the nets of the specified cells
		/// </param>
		/// <param name="clocks">
		/// Required
		/// Report the nets of the specified clocks
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="format">
		/// Optional
		/// Specifies how to format the report: text, xml. Default is
		/// 'text'. Only applies if -file is used. If xml output is used, -
		/// append is not allowed. Default: text
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append to existing file
		/// </param>
		/// <param name="ascending">
		/// Optional
		/// Report nets in ascending order
		/// </param>
		/// <param name="timing">
		/// Optional
		/// Report worst slack and worst delay values on nets
		/// </param>
		/// <param name="histogram">
		/// Optional
		/// Report histogram for high fanout nets
		/// </param>
		/// <param name="load_types">
		/// Optional
		/// Report load details
		/// </param>
		/// <param name="clock_regions">
		/// Optional
		/// Report clock region wise load distribution
		/// </param>
		/// <param name="slr">
		/// Optional
		/// Report SLR wise load distribution
		/// </param>
		/// <param name="max_nets">
		/// Optional
		/// Number of nets for which report is to be generated Default:
		/// 10
		/// </param>
		/// <param name="fanout_greater_than">
		/// Optional
		/// Report nets that have fanout greater than the specified
		/// integer, default 0 Default: 0
		/// </param>
		/// <param name="fanout_lesser_than">
		/// Optional
		/// Report nets that have fanout less than the specified integer,
		/// default INT_MAX Default: INT_MAX
		/// </param>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name
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
		/// <returns>Report</returns>
		public void report_high_fanout_nets(string cells, string clocks, string file = null, string format = null, bool? append = null, bool? ascending = null, bool? timing = null, bool? histogram = null, bool? load_types = null, bool? clock_regions = null, bool? slr = null, string max_nets = null, string fanout_greater_than = null, string fanout_lesser_than = null, string name = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_high_fanout_nets");
			_tcl.Add(command);
		}
		/// <summary>
		/// Methodology Checks
		///
		/// Check the current design against a specified set of methodology checks and report any errors or
		/// violations that are found.
		/// Methodology checks are a special class of design rule checks (DRC) that are accessible through
		/// this separate Tcl command. The methodology checks are a necessary part of the design flow, and
		/// should be considered mandatory after implementation and prior to generating the bitstream.
		/// TIP: Other than their availability through the separate report_methodology command, the checks are
		/// standard design rule checks in every other way.
		/// The report_methodology command requires an open design to check the design rules
		/// against. The command returns a report with the results of violations found by the design rule
		/// checks. Violations are returned as Vivado objects that can be listed with the
		/// get_methodology_violations command, and are associated with cells, pins, ports, nets,
		/// and sites in the current design. You can get the cells, nets, and other design objects that are
		/// associated with methodology violation objects, using the -of_objects option of the
		/// get_cells command for instance.
		/// The report_methodology command runs the methodology rule deck, or you can use the -
		/// checks option to specify the set of checks to run. Methodology checks can also be enabled or
		/// disabled in the default rule decks using the IS_ENABLED property on the rule check object:
		/// set_property IS_ENABLED FALSE [get_methodology_checks PDRC-190]
		/// If a rule IS_ENABLED false, the rule will not be run by the report_methodology command.
		/// TIP: You can reset the properties of a methodology rule to the factory default settings using the
		/// reset_methodology_check command.
		/// You can reset the current results of the report_methodology command, clearing any found
		/// violations, using the reset_methodology command.
		///
		/// The following examples run the default methodology checks against the current design, and
		/// writes the results to the specified file:
		/// report_methodology -file C:/Data/methodology_Rpt1.txt -append
		/// Note: The -append option adds the result to the specified file.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1359
		/// </summary>
		/// <param name="cells">
		/// Required
		/// Run report_methodology on the specified cell(s).
		/// </param>
		/// <param name="checks">
		/// Required
		/// Report Methodology checks (see get_methodology_checks
		/// for available checks)
		/// </param>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="rpx">
		/// Optional
		/// Report filename for persisted results.
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, do not overwrite the results file
		/// </param>
		/// <param name="waived">
		/// Optional
		/// Output result is Waived checks
		/// </param>
		/// <param name="no_waivers">
		/// Optional
		/// Disable waivers for checks
		/// </param>
		/// <param name="slack_lesser_than">
		/// Optional
		/// Set SYNTH rules Slack Threshold value in 'ns' (float) Default:
		/// 2.0
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
		public void report_methodology(string cells, string checks, string name = null, string file = null, string rpx = null, bool? append = null, bool? waived = null, bool? no_waivers = null, string slack_lesser_than = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_methodology");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report pulse width check
		///
		/// Reports the pulse width of the specified clock signals in the clock network and upon reaching the
		/// flip-flop. This command also performs high pulse width checking, using maximum delay for the
		/// rising edge and minimum delay for the falling edge of the clock. Performs low pulse width
		/// checking using minimum delay for the rising edge, and maximum delay for the falling edge. This
		/// results in a worst case analysis for the current Synthesis or Implemented Design because it
		/// assumes worst-case delays for both rising and falling edges. This command also reports the
		/// maximum skew, or maximum timing separation allowed between clock signals.
		/// The report includes minimum pulse width, maximum pulse width, low pulse width, high pulse
		/// width, and max skew checks by default. However, selecting a specific check will disable the other
		/// checks unless they are also specified.
		/// The default report is returned to the standard output, but can be redirected to a file, or to a Tcl
		/// string variable for further processing. The report is returned to the standard output by default,
		/// unless the -file, -return_string, or -name arguments are specified.
		///
		/// The following example performs the minimum period and low pulse width check, returning the
		/// results to a named results set in the GUI:
		/// report_pulse_width -min_period -low_pulse -name timing_1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1388
		/// </summary>
		/// <param name="clocks">
		/// Required
		/// List of clocks for which to report min pulse width/min period
		/// checks
		/// </param>
		/// <param name="cells">
		/// Required
		/// run report_pulse_width on the specified cell(s)
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, don't overwrite the results file
		/// </param>
		/// <param name="name">
		/// Optional
		/// Results name in which to store output
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// return report as string
		/// </param>
		/// <param name="warn_on_violation">
		/// Optional
		/// issue a critical warning when the report contains a timing
		/// violation
		/// </param>
		/// <param name="all_violators">
		/// Optional
		/// Only report pins/ports where check violations occur
		/// </param>
		/// <param name="significant_digits">
		/// Optional
		/// Number of digits to display: Range: 0 to 3 Default: 3
		/// </param>
		/// <param name="limit">
		/// Optional
		/// Number of checks of a particular type to report per clock:
		/// Default is 1 Default: 1
		/// </param>
		/// <param name="min_period">
		/// Optional
		/// Only report min period checks
		/// </param>
		/// <param name="max_period">
		/// Optional
		/// Only report max period checks
		/// </param>
		/// <param name="low_pulse">
		/// Optional
		/// Only report min low pulse width checks
		/// </param>
		/// <param name="high_pulse">
		/// Optional
		/// Only report min high pulse width checks
		/// </param>
		/// <param name="max_skew">
		/// Optional
		/// Only report max skew checks
		/// </param>
		/// <param name="no_header">
		/// Optional
		///
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
		/// <param name="objects">
		/// Optional
		/// List of objects to check min pulse width with
		/// </param>
		public void report_pulse_width(string clocks, string cells, string file = null, bool? append = null, string name = null, bool? return_string = null, bool? warn_on_violation = null, bool? all_violators = null, string significant_digits = null, string limit = null, bool? min_period = null, bool? max_period = null, bool? low_pulse = null, bool? high_pulse = null, bool? max_skew = null, bool? no_header = null, string rpx = null, bool? quiet = null, bool? verbose = null, string objects = null)
		{
			var command = new SimpleTCLCommand("report_pulse_width");
			_tcl.Add(command);
		}
		/// <summary>
		/// Feasibility Checks
		///
		/// This command look for trouble spots in the design and assesses the likelihood of a design
		/// meeting design goals. This command requires an open elaborated, synthesized or implemented
		/// design for analysis.
		/// The Report QoR Assessment covers multiple categories:
		/// • Design Methodology
		/// • Synthesis
		/// • Implementation
		/// • Design Hierarchy
		/// • Partial Reconfiguration
		/// • Floorplanning
		/// The report_qor_assessment command includes a subset of report_methodology checks
		/// identifying bad practices that can lead to an expected problem. Yet, report_qor_assessment
		/// is also more comprehensive than report_methodology, because it includes other checks that
		/// are not necessarily bad practices but may have low success due to the structure, style, size, or
		/// complexity of the current design.
		/// A key feature of Report QOR Assessment is the ability to predict certain conditions that lead to
		/// congestion and performance degradation. This command can be run at any stage of the
		/// implementation flow after synthesis. The report_qor_assessment command will return a
		/// score from 1 - 5, where 1 is a failing grade, and 5 means the design will likely pass
		/// implementation and meet timing.
		/// For violations found by Report QOR Assessment, the Report QOR Suggestions command will
		/// make recommendations on how to avoid issues, or modify the design to improve results.
		///
		/// The following example reports suggestions after analyzing the worst 10 paths:
		/// report_qor_assessment -max_paths 10
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1392
		/// </summary>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="max_paths">
		/// Optional
		/// Number of paths to consider for suggestion analysis
		/// Default: 100
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, do not overwrite the results file
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void report_qor_assessment(string file = null, string max_paths = null, bool? append = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_qor_assessment");
			_tcl.Add(command);
		}
		/// <summary>
		/// Recommend QoR Suggestions
		///
		/// Report design and tool option recommendations related to improving the quality of results (QoR).
		/// The report looks at timing constraints, netlist characteristics, failing timing paths, and congestion
		/// information to determine suggestions that can enhance the QoR. The report can be generated
		/// after synthesis, or after any implementation step, but requires a design to be open.
		/// The report_qor_suggestions command creates QoR suggestion objects related to the
		/// suggestions identified. These suggestion objects can be enabled for use by the Vivado tools to
		/// improve the quality of synthesis and implementation results. Some of these suggestions can be
		/// automatically applied, and some may require more manual intervention to implement design
		/// changes, or write Tcl design constraints.
		/// Suggestion objects can be obtained using the get_qor_suggestions command. The QoR
		/// objects have properties that define what step they are APPLICABLE_FOR, if they are ENABLED
		/// to be used, if they can be automatically applied (AUTO), or what step the suggestions was
		/// GENERATED_AT. A suggestion must be ENABLED and the APPLICABLE_FOR synthesis or
		/// implementation step run in order for a suggestion to be applied to the design.
		/// You can write the suggestions from the design into an RQS file using the
		/// write_qor_suggestions command. After resetting the design flow to the appropriate step,
		/// you can read suggestions back into the design using the read_qor_suggestions command,
		/// and then run the synthesis or implementation step to apply the enabled suggestions.
		/// The recommended method for working with QoR suggestions is:
		/// 1. Run the report to create recommendations (report_qor_suggestions)
		/// 2. Look at and ENABLE the suggestions you want to use (get_qor_suggestions)
		/// 3. Write the suggestions to an RQS file on disk (write_qor_suggestions).
		/// 4. Reset the design to the appropriate step.
		/// 5. Read the RQS file into the design to restore the suggestions (read_qor_suggestions).
		/// 6. Run the synthesis or implementation step to apply the suggestion (synth_design,
		/// opt_design...).
		///
		/// The following example reports suggestions after analyzing the worst 10 paths:
		/// report_qor_suggestions -max_paths 10
		/// This example reports existing suggestions in the design from a prior run of
		/// report_qor_suggestions:
		/// report_qor_suggestions -of_objects [get_qor_suggestions]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1395
		/// </summary>
		/// <param name="cell">
		/// Required
		/// Report QOR suggestions for a given cell
		/// </param>
		/// <param name="of_objects">
		/// Required
		/// List of QoR suggestion objects
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
		/// <param name="append">
		/// Optional
		/// Append the results to file, don't overwrite the results file
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// Return report as string
		/// </param>
		/// <param name="max_strategies">
		/// Optional
		/// Number of strategies to suggest Default: 3
		/// </param>
		/// <param name="max_paths">
		/// Optional
		/// Number of paths to consider for suggestion analysis
		/// Default: 100
		/// </param>
		/// <param name="evaluate_pipelining">
		/// Optional
		/// Generate DSP/BRAM pipelining xdc file
		/// </param>
		/// <param name="no_split">
		/// Optional
		/// Report without spliting the lines in tables
		/// </param>
		/// <param name="models_dir">
		/// Optional
		/// Path to the directory which consists of the models Default: /
		/// proj/rdi-xco/builds/HEAD/nightly/RUNNING_ BUILD/
		/// packages/customer/vivado/data/deca/models_dir
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void report_qor_suggestions(string cell, string of_objects, string file = null, string name = null, bool? append = null, bool? return_string = null, string max_strategies = null, string max_paths = null, bool? evaluate_pipelining = null, bool? no_split = null, string models_dir = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_qor_suggestions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Compute mean time between failures and display report
		///
		/// RECOMMENDED: This command is supported for Xilinx UltraScale devices only, and does not support 7 series
		/// devices.
		/// The report_synchronizer_mtbf command reports mean time between failures (MTBF) of
		/// each clock domain crossing (CDC) synchronizer chain in a design, and provides an overall MTBF
		/// covering all synchronizers. Synchronizer registers must have ASYNC_REG properties with value
		/// TRUE to be properly identified as synchronizers for reporting.
		/// Asynchronous clock domain crossings (CDCs) can fail due to metastability as data is captured
		/// asynchronously and may settle to different values on different loads in the circuit. Synchronizer
		/// registers are used to improve overall circuit reliability for designs which contain multiple clock
		/// domains, in which asynchronous data transfers occur, or in which external asynchronous signals
		/// are captured with an internal clock. A synchronizer chain consists of two or more registers
		/// connected sequentially with the first stage capturing the data signal from the asynchronous clock
		/// domain. The successive register stages provide additional settling time for metastable events and
		/// increase MTBF. The synchronizer registers must have ASYNC_REG properties with values of
		/// TRUE. Besides reporting MTBF, the ASYNC_REG properties instruct synthesis, simulation and
		/// implementation tools to optimize for increased MTBF and improve overall behavior of the
		/// synchronizer circuit.
		/// TIP: Avoid using different set/reset or clock enable control signals on registers within a synchronizer chain.
		/// This command returns the MTBF report, or returns an error if it fails. The command issues a
		/// warning message when the MTBF cannot be calculated correctly, for example when a CDC is
		/// improperly constrained. The following conditions result in an UNDEFINED synchronizer MTBF
		/// value:
		/// • One or both clocks of the CDC are unconstrained.
		/// • There is a timing violation involving registers in the synchronizer chain.
		/// • There is a zero toggle rate detected for the CDC data.
		/// In the case of a zero toggle rate, it may be necessary to use the set_switching_activity
		/// command to manually override the toggle rate on the CDC net with a realistic value. This
		/// involves assigning the Toggle Rate and the Static Probability:
		/// • Toggle Rate: The number of CDC data signal transitions measured in Million Transitions per
		/// Second.
		/// • Static Probability: The percentage of time during which the CDC data signal is driven at a high
		/// logic level.
		/// Example: to assign a toggle rate of 12.5% with 0.5 static probability on a CDC net named
		/// resync[0]:
		/// set_switching_activity -toggle_rate 12.5 -static_probability 0.5 \
		/// [get_nets resync[0]]
		/// The report contents include the following data for each synchronizer chain in the design:
		/// • MTBF: The Mean Time Between Failures for the CDC synchronizer reported in dynamic time
		/// units, from seconds to years. An invalid MTBF value is reported as UNDEFINED.
		/// • Data Toggle Rate: The rate at which the CDC data switches, based on the default switching
		/// activity for the design as reported by report_switching_activity. Measured in (Mts)
		/// Millions of Transitions per Second. The rate can be overridden using the
		/// set_switching_activity command targeting the CDC net object.
		/// • Data Sample Rate: The rate at which the CDC data is sampled, equivalent to the synchronizer
		/// chain frequency, measured in MHz.
		/// • Settling Time: The total amount of positive slack in nanoseconds on the timing paths from
		/// synchronizer register outputs. Higher Settling Time increases MTBF.
		/// • Sending Domain: The clock domain of the source of the CDC data. A value of
		/// UNCONSTRAINED is reported if the source clock is not defined.
		/// • Receiving Domain: The clock domain of the destination of the CDC data. A value of
		/// UNCONSTRAINED is reported if the destination clock is not defined.
		/// • Number of Stages: This is the length of the synchronizer chain, which equals the number of
		/// registers with ASYNC_REG value of TRUE. The MTBF calculation will determine the likelihood
		/// that the output register or registers (should the fanout be greater than 1) will experience a
		/// metastable event. For example in a typical synchronizer containing 2 registers with the
		/// ASYNC_REG property set, the MTBF calculation indicates the probability that the output
		/// register(s) following the last ASYNC_REG register will capture an incorrect value resulting from
		/// the metastable event. When a synchronizer is connected to more than 1 output register, the
		/// minimum slack from all the paths will be used in the MTBF calculation to ensure that all
		/// registers capture the same logic level.
		/// • CDC Net Name: This is the logical net name of the CDC data, the data that is captured
		/// asynchronously.
		/// This command returns the MTBF report, or returns an error if it fails.
		/// The report also includes an overall MTBF calculated using the MTBF of all synchronizers in the
		/// design, calculated as the inverse of the sum of the reciprocals of the individual synchronizer
		/// MTBF values: (1 / (1/MTBF_1 + 1/MTBF_2 + … + 1/MTBF_N) ) for N synchronizers.
		///
		/// The following example writes the MTBF report to the specified file:
		/// report_synchronizer_mtbf -file C:/Data/mtbf_report.txt
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1420
		/// </summary>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, don't overwrite the results file
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// Return the report output as a string
		/// </param>
		/// <param name="warn_if_mtbf_below">
		/// Optional
		/// Default: 1e+12
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="no_header">
		/// Optional
		/// Report without the header
		/// </param>
		/// <param name="report_endpoints">
		/// Optional
		/// Report cdc path end points
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>Report</returns>
		public void report_synchronizer_mtbf(string file = null, bool? append = null, bool? return_string = null, string warn_if_mtbf_below = null, bool? quiet = null, bool? no_header = null, bool? report_endpoints = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_synchronizer_mtbf");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report timing paths
		///
		/// IMPORTANT! If the design has no timing constraints, report_timing reports on unconstrained paths in the
		/// design. However, if even one path has timing constraints then report_timing only reports on the
		/// constrained paths in the design, unless unconstrained timing paths are specified by the -from/-to options.
		/// This command performs timing analysis on the specified timing paths of the current Synthesized
		/// or Implemented Design. By default the tool reports the timing path with the worst calculated
		/// slack within each path group. However, you can optionally increase the number of paths and
		/// delays reported with the use of the -nworst or -max_paths arguments.
		/// TIP: The report_timing can be multi-threaded to speed the process. Refer to the set_param command
		/// for more information on setting the general.maxThreads parameter.
		/// The timing engine runs in "quad" timing mode, analyzing min and max delays for both slow and
		/// fast corners. You can configure the type of analysis performed by the
		/// config_timing_corners command. However, it is not recommended to change the default
		/// because this reduces the timing analysis coverage.
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be
		/// written to the GUI, to a file, or returned as a string if desired.
		///
		/// The following example reports the timing for the 5 worst paths in the design, reporting the full
		/// timing path, including input pins, with timing values:
		/// report_timing -nworst 5 -path_type full -input_pins
		/// The following example shows the use of the multiple through points to define both a specific
		/// path (through state_reg1) and alternate paths (through count_3 or count_4), and writes the
		/// timing results to the specified file:
		/// report_timing -from go -through {state_reg1} \
		/// -through { count_3 count_4 } \
		/// -to done -path_type summary -file C:/Data/timing1.txt
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1424
		/// </summary>
		/// <param name="from">
		/// Required
		/// From pins, ports, cells or clocks
		/// </param>
		/// <param name="rise_from">
		/// Required
		/// Rising from pins, ports, cells or clocks
		/// </param>
		/// <param name="fall_from">
		/// Required
		/// Falling from pins, ports, cells or clocks
		/// </param>
		/// <param name="to">
		/// Required
		/// To pins, ports, cells or clocks
		/// </param>
		/// <param name="rise_to">
		/// Required
		/// Rising to pins, ports, cells or clocks
		/// </param>
		/// <param name="fall_to">
		/// Required
		/// Falling to pins, ports, cells or clocks
		/// </param>
		/// <param name="through">
		/// Required
		/// Through pins, ports, cells or nets
		/// </param>
		/// <param name="rise_through">
		/// Required
		/// Rising through pins, ports, cells or nets
		/// </param>
		/// <param name="fall_through">
		/// Required
		/// Falling through pins, ports, cells or nets
		/// </param>
		/// <param name="group">
		/// Required
		/// Limit report to paths in this group(s)
		/// </param>
		/// <param name="of_objects">
		/// Required
		/// Report timing for these paths
		/// </param>
		/// <param name="cells">
		/// Required
		/// run report_timing on the specified cell(s)
		/// </param>
		/// <param name="delay_type">
		/// Optional
		/// Type of path delay: Values: max, min, min_max, max_rise,
		/// max_fall, min_rise, min_fall Default: max
		/// </param>
		/// <param name="setup">
		/// Optional
		/// Report max delay timing paths (equivalent to -delay_type
		/// max)
		/// </param>
		/// <param name="hold">
		/// Optional
		/// Report min delay timing paths (equivalent to -delay_type
		/// min)
		/// </param>
		/// <param name="max_paths">
		/// Optional
		/// Maximum number of paths to output when sorted by slack,
		/// or per path group when sorted by group: Value >=1 Default:
		/// 1
		/// </param>
		/// <param name="nworst">
		/// Optional
		/// List up to N worst paths to endpoint: Value >=1 Default: 1
		/// </param>
		/// <param name="unique_pins">
		/// Optional
		/// for each unique set of pins, show at most 1 path per path
		/// group
		/// </param>
		/// <param name="path_type">
		/// Optional
		/// Format for path report: Values: end, summary, short, full,
		/// full_clock, full_clock_expanded Default: full_clock_expanded
		/// </param>
		/// <param name="input_pins">
		/// Optional
		/// Show input pins in path
		/// </param>
		/// <param name="no_header">
		/// Optional
		/// Do not generate a report header
		/// </param>
		/// <param name="no_reused_label">
		/// Optional
		/// Do not label reuse status on pins in the report
		/// Name Description
		/// </param>
		/// <param name="slack_lesser_than">
		/// Optional
		/// Display paths with slack less than this Default: 1e+30
		/// </param>
		/// <param name="slack_greater_than">
		/// Optional
		/// Display paths with slack greater than this Default: -1e+30
		/// </param>
		/// <param name="sort_by">
		/// Optional
		/// Sorting order of paths: Values: group, slack Default: slack
		/// </param>
		/// <param name="no_report_unconstrained">
		/// Optional
		/// Do not report infinite slack paths
		/// </param>
		/// <param name="user_ignored">
		/// Optional
		/// Only report paths which have infinite slack because of
		/// set_false_path or set_clock_groups timing constraints
		/// </param>
		/// <param name="significant_digits">
		/// Optional
		/// Number of digits to display: Range: 0 to 3 Default: 3
		/// </param>
		/// <param name="column_style">
		/// Optional
		/// style for path report columns: Values: variable_width,
		/// anchor_left, fixed_width Default: anchor_left
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, don't overwrite the results file
		/// </param>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name
		/// </param>
		/// <param name="no_pr_attribute">
		/// Optional
		/// for partial reconfiguration designs, do not report whether
		/// netlist resources are in the static or reconfigurable regions
		/// </param>
		/// <param name="routable_nets">
		/// Optional
		/// store the number of routable nets traversed as a property
		/// on timing paths.
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// return report as string
		/// </param>
		/// <param name="warn_on_violation">
		/// Optional
		/// issue a critical warning when the report contains a timing
		/// violation
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
		public void report_timing(string from, string rise_from, string fall_from, string to, string rise_to, string fall_to, string through, string rise_through, string fall_through, string group, string of_objects, string cells, string delay_type = null, bool? setup = null, bool? hold = null, string max_paths = null, string nworst = null, bool? unique_pins = null, string path_type = null, bool? input_pins = null, bool? no_header = null, bool? no_reused_label = null, string slack_lesser_than = null, string slack_greater_than = null, string sort_by = null, bool? no_report_unconstrained = null, bool? user_ignored = null, string significant_digits = null, string column_style = null, string file = null, bool? append = null, string name = null, bool? no_pr_attribute = null, bool? routable_nets = null, bool? return_string = null, bool? warn_on_violation = null, string rpx = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_timing");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report timing summary
		///
		/// TIP: The report_timing_summary can be multi-threaded to speed the process. Refer to the set_param
		/// command for more information on setting the general.maxThreads parameter.
		/// Generate a timing summary to help understand if the design has met timing requirements. The
		/// timing summary can be run on an open Synthesized or Implemented Design.
		/// The timing summary report includes the following information:
		/// • Timer Settings - Details the timing engine settings used to generate the timing information in
		/// the report.
		/// • Check Timing - Contains the same information that is produced by the check_timing
		/// command, which summarizes potential timing issues.
		/// • Design Timing Summary - Provides a summary of the timing of the design, including values for
		/// worst and total negative slack (WNS/TNS), worst and total hold slack (WHS/THS), and
		/// component switching limits (CSL).
		/// • Clock Definitions - Contains the same information that is produced by the report_clocks
		/// command, showing all the clocks that were created for the design, either by create_clock,
		/// create_generated_clock, or automatically by the tool.
		/// • Intra-Clock Table - Summarizes timing paths with the same source and destination clocks.
		/// • Inter-Clock Table - Summarizes timing paths with different source and destination clocks.
		/// • Path Group Table - Shows default path groups and user-defined path groups created by the
		/// group_path command.
		/// • Timing Details - Contains detailed timing paths, both max delay and min delay, as well as
		/// component switching limits for each clock defined, similar to the report_timing command.
		/// • Data sheet - Contains the same information that is produced by the report_datasheet
		/// command. It contains the timing characteristics of a design at the I/O ports. The data sheet
		/// information is added to the summary report only when the -datasheet option is specified.
		/// This command is automatically run during implementation as part of the launch_runs
		/// command.
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be
		/// written to a file or returned as a string if desired.
		///
		/// The following example reports the timing summary of the current design:
		/// report_timing_summary
		/// The following example reports the hold timing summary of the current design, including
		/// unconstrained paths, with the specified options:
		/// report_timing_summary -delay_type min -path_type full_clock_expanded \
		/// -report_unconstrained -max_paths 2 -nworst 1 -significant_digits 2 \
		/// -input_pins -name {timing_6}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1431
		/// </summary>
		/// <param name="cells">
		/// Required
		/// run report_timing_summary on the specified cell(s)
		/// </param>
		/// <param name="check_timing_verbose">
		/// Optional
		/// produce a verbose report when checking the design for
		/// potential timing problems
		/// </param>
		/// <param name="delay_type">
		/// Optional
		/// Type of path delay: Values: max, min, min_max Default:
		/// min_max
		/// </param>
		/// <param name="no_detailed_paths">
		/// Optional
		/// do not report timing paths for each clock and path group
		/// analyzed
		/// </param>
		/// <param name="setup">
		/// Optional
		/// Report max delay timing paths (equivalent to -delay_type
		/// max)
		/// </param>
		/// <param name="hold">
		/// Optional
		/// Report min delay timing paths (equivalent to -delay_type
		/// min)
		/// </param>
		/// <param name="max_paths">
		/// Optional
		/// Maximum number of paths to report per clock or path
		/// group: Value >=1 Default: 1
		/// </param>
		/// <param name="nworst">
		/// Optional
		/// List up to N worst paths to endpoint: Value >=1 Default: 1
		/// </param>
		/// <param name="unique_pins">
		/// Optional
		/// for each unique set of pins, show at most 1 path per path
		/// group
		/// </param>
		/// <param name="path_type">
		/// Optional
		/// Format for path report: Values: end summary short full
		/// full_clock full_clock_expanded Default: full_clock_expanded
		/// </param>
		/// <param name="no_reused_label">
		/// Optional
		/// Do not label reuse status on pins in the report
		/// </param>
		/// <param name="input_pins">
		/// Optional
		/// Show input pins in path
		/// </param>
		/// <param name="no_pr_attribute">
		/// Optional
		/// for partial reconfiguration designs, do not report whether
		/// netlist resources are in the static or reconfigurable regions
		/// </param>
		/// <param name="routable_nets">
		/// Optional
		/// store the number of routable nets traversed as a property
		/// on timing paths.
		/// </param>
		/// <param name="slack_lesser_than">
		/// Optional
		/// Display paths with slack less than this Default: 1e+30
		/// </param>
		/// <param name="report_unconstrained">
		/// Optional
		/// report unconstrained and user ignored paths
		/// </param>
		/// <param name="significant_digits">
		/// Optional
		/// Number of digits to display: Range: 0 to 3 Default: 3
		/// </param>
		/// <param name="no_header">
		/// Optional
		/// do not generate a report header
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, don't overwrite the results file
		/// Name Description
		/// </param>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// return report as string
		/// </param>
		/// <param name="warn_on_violation">
		/// Optional
		/// issue a critical warning when the report contains a timing
		/// violation
		/// </param>
		/// <param name="datasheet">
		/// Optional
		/// Include data sheet report
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
		public void report_timing_summary(string cells, bool? check_timing_verbose = null, string delay_type = null, bool? no_detailed_paths = null, bool? setup = null, bool? hold = null, string max_paths = null, string nworst = null, bool? unique_pins = null, string path_type = null, bool? no_reused_label = null, bool? input_pins = null, bool? no_pr_attribute = null, bool? routable_nets = null, string slack_lesser_than = null, bool? report_unconstrained = null, string significant_digits = null, bool? no_header = null, string file = null, bool? append = null, string name = null, bool? return_string = null, bool? warn_on_violation = null, bool? datasheet = null, string rpx = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_timing_summary");
			_tcl.Add(command);
		}
		/// <summary>
		/// Resets the timing information on the current design
		///
		/// Reset the timing data and constraints for the current design. Use this command to clear the
		/// current in-memory timing data and constraints, and force the timing engine to reevaluate the
		/// design comprehensively rather than iteratively.
		/// After clearing the constraints from the in-memory design, you must reload any needed
		/// constraints using the read_xdc command. The Vivado tool will not automatically reload the
		/// constraints.
		/// TIP: This command deletes the in-memory timing view, not the timing report. Use the
		/// delete_timing_results command to delete the reported timing information.
		///
		/// The following example clears the current timing data from memory, including any invalid timing
		/// constraints:
		/// reset_timing -invalid
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1490
		/// </summary>
		/// <param name="invalid">
		/// Optional
		/// Resets invalid timing constraints in addition to valid timing
		/// constraints.
		/// </param>
		/// <param name="clock_reservation">
		/// Optional
		/// Resets clock name reservations for auto-derived clocks in
		/// addition to valid timing constraints.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void reset_timing(bool? invalid = null, bool? clock_reservation = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("reset_timing");
			_tcl.Add(command);
		}
		/// <summary>
		/// Sets the interconnect delay model for timing analysis.
		///
		/// Sets the interconnect delay model for timing analysis. There are three settings for the
		/// interconnect delay model: "actual", "estimated", or "none".
		/// • If "actual" is selected, the actual delay from the routed interconnect will be used in timing
		/// analysis. If the design is only partially routed, then the actual delay from the routed portion
		/// will be used, along with estimated delay for the unrouted portion. The timing report will
		/// provide details regarding the source of the calculated delay.
		/// • If "estimated" delays are selected, the timing analysis will include an estimate of the
		/// interconnect delays based on the placement and connectivity of the design onto the device
		/// prior to implementation. Estimated delay can be specified even if the design is fully routed.
		/// • If "none" is selected, then no interconnect delay is included in the timing analysis, and only the
		/// logic delay is applied.
		/// Note: This command operates silently and does not return direct feedback of its operation.
		///
		/// The following command will use a timing delay model which is an estimated value.
		/// set_delay_model -interconnect estimated
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1579
		/// </summary>
		/// <param name="interconnect">
		/// Optional
		/// Interconnect delay model used for timing analysis: Values:
		/// estimated, actual(default), none
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_delay_model(string interconnect = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_delay_model");
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
			_tcl.Add(command);
		}
		/// <summary>
		/// Set external delay
		///
		/// TIP: The XDC > Timing Constraints language templates and the Timing Constraints Wizard in the Vivado IDE
		/// offer timing diagrams and additional details around defining specific timing constraints. You can refer to these
		/// sources for additional information.
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
		/// See ug835-vivado-tcl-commands.pdf, page 1583
		/// </summary>
		/// <param name="from">
		/// Required
		/// Output port
		/// </param>
		/// <param name="to">
		/// Required
		/// Input port
		/// </param>
		/// <param name="delay_value">
		/// Required
		/// External (feedback) delay value
		/// </param>
		/// <param name="min">
		/// Optional
		/// Specifies minimum delay
		/// </param>
		/// <param name="max">
		/// Optional
		/// Specifies maximum delay
		/// </param>
		/// <param name="add">
		/// Optional
		/// Add to existing external delay
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_external_delay(string from, string to, string delay_value, bool? min = null, bool? max = null, bool? add = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_external_delay");
			_tcl.Add(command);
		}
		/// <summary>
		/// update timing
		///
		/// Updates timing for the current design.
		/// Update the timing data to reflect any timing constraints that were added to the design since the
		/// timing engine was last run. This command updates the in-memory view of the timing database,
		/// without incurring the time of a full timing analysis.
		/// Timing is automatically updated by commands that change timing or need updated timing
		/// information, such as the report_timing command. The update_timing command lets you
		/// manually trigger the timing update to insure the latest constraints are applied to the timing
		/// engine.
		/// The update_timing command uses an incremental analysis approach by default, which
		/// updates only out-of-date information, to reduce process and analysis time. You can also specify a
		/// complete or full update to insure a comprehensive review of timing data in the design. However,
		/// to avoid long timing analysis run times, you should use the -full option only when you need to.
		///
		/// The following example performs a full update of the in-memory timing data:
		/// update_timing -full
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1750
		/// </summary>
		/// <param name="full">
		/// Optional
		/// Perform a full timing update instead of an incremental one
		/// </param>
		/// <param name="skip_delay_calc">
		/// Optional
		/// Skip delay calculation
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void update_timing(bool? full = null, bool? skip_delay_calc = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("update_timing");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write file with inferred xdc timing constraints
		///
		/// You can use the write_inferred_xdc to find constraints that should be defined in the open
		/// synthesized or implemented design. Write timing constraints that are automatically generated by
		/// the Vivado timing engine, rather than defined in an existing XDC file and added to the design.
		/// Run write_inferred_xdc -clocks first to define suggested clock and generated clock
		/// constraints. The suggested clock constraints will be defined with a period of 1 ns. You can edit
		/// the recommended constraints to create clocks and generated clocks with the required clock
		/// period to meet the needs of your design.
		/// You can add the edited constraints file into the design using read_xdc, or add_files, and
		/// update_timing.
		/// You may need to run the write_inferred_xdc command multiple times, using various
		/// options like -clock_groups or -async_clocks, to capture all inferred timing constraints
		/// from the fully clocked design. You can use an iterative process of writing and sourcing the
		/// inferred clocked constraints, and then writing and sourcing additional constraint files to capture
		/// all inferred constraints. See the example below for more information.
		/// This command returns a transcript of the process when successful, or returns an error if it fails.
		///
		/// The following example writes the inferred clock constraints in the current design:
		/// write_inferred_xdc -clocks C:/Data/design1_inferred_clocks.xdc
		/// The write_inferred_xdc command may need to be run multiple times to capture all the
		/// inferred constraints, as is shown in this example:
		/// write_inferred_xdc -clocks clocks.xdc
		/// source clocks.xdc
		/// write_inferred_xdc -all all.xdc
		/// source all.xdc
		/// write_inferred_xdc -async_clocks async.xdc
		/// source async.xdc
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1829
		/// </summary>
		/// <param name="force">
		/// Optional
		/// Overwrite existing file.
		/// </param>
		/// <param name="all">
		/// Optional
		/// Generate all constraints except missing clocks which are
		/// generated with the -clocks option
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the constraints to file, don't overwrite the
		/// constraints file
		/// </param>
		/// <param name="async_clocks">
		/// Optional
		/// Find asynchronous clock groups
		/// </param>
		/// <param name="all_async_reg">
		/// Optional
		/// Find the missing ASYNC_REG property for safe and unsafe
		/// Clock Domain Crossing
		/// </param>
		/// <param name="clock_groups">
		/// Optional
		/// Find asynchronous and exclusive clock groups, equivalent to
		/// options -async_clocks -excl_clocks
		/// </param>
		/// <param name="clocks">
		/// Optional
		/// Find missing clock definitions
		/// </param>
		/// <param name="excl_clocks">
		/// Optional
		/// Find logically and physically exclusive clock groups
		/// </param>
		/// <param name="exceptions">
		/// Optional
		/// Find missing exceptions
		/// </param>
		/// <param name="io_constraints">
		/// Optional
		/// Find missing input and output delays
		/// </param>
		/// <param name="merge_existing_constraints">
		/// Optional
		/// Add existing user defined constraints to the generated
		/// constraints
		/// </param>
		/// <param name="name">
		/// Optional
		/// Start constraints wizard in a GUI panel with this name. Do
		/// other command options can be combined with -name.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to write constraints into
		/// </param>
		public void write_inferred_xdc(bool? force = null, bool? all = null, bool? append = null, bool? async_clocks = null, bool? all_async_reg = null, bool? clock_groups = null, bool? clocks = null, bool? excl_clocks = null, bool? exceptions = null, bool? io_constraints = null, bool? merge_existing_constraints = null, string name = null, bool? quiet = null, bool? verbose = null, string file = null)
		{
			var command = new SimpleTCLCommand("write_inferred_xdc");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write QoR Suggestions to the given file
		///
		/// Write the QoR suggestions generated by the report_qor_suggestions command. You can
		/// combine the suggestions from the latest report with suggestions read into the design with
		/// read_qor_suggestions so that you can manage all suggestions in a single RQS file.
		/// To write out specific QoR suggestions, use the -of_objects option. When this is not specified, all
		/// suggestions will be written.
		/// The recommended way to manage suggestions is using RQS objects. However, it is possible to
		/// view and execute the commands using TCL. Specifying the -tcl_output_dir option writes Tcl
		/// scripts for the automated suggestions that are property based.
		/// Implementation strategies that use machine learning to analyze the design can be generated
		/// running report_qor_suggestions. When specifying the -strategy_dir option. Multiple
		/// TCL files and one RQS file will be written for each strategy. The TCL files aid integration into
		/// project or non project flows. The main RQS file should not be used as the suggestions are
		/// contained in the run specific files along with strategy information.
		/// This command returns the name of the output file created when successful, or returns an error if
		/// it fails.
		///
		/// This example reports QoR suggestions, then writes them to the specified file.
		/// report_qor_suggestions
		/// write_qor_suggestions C:/Data/qor_results.rqs
		/// This example reports QoR suggestions, then writes them to the specified file.
		/// report_qor_suggestions
		/// write_qor_suggestions -strategy_dir C:/Data/strategy_dir C:/Data/
		/// qor_suggestions.rqs
		/// In project mode you must then source the TCL script generated for project mode. There is one
		/// script per run to source. Examples of non project scripts are also given.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1845
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// List of QoR suggestion objects
		/// </param>
		/// <param name="file">
		/// Required
		/// QoR suggestions file Values: A filename with alphanumeric
		/// characters and .rqs extension.
		/// </param>
		/// <param name="strategy_dir">
		/// Optional
		/// Directory to create Strategy RQS & TCL files Values: If
		/// passed a directory path, for each strategy suggested one set
		/// of RQS and TCL files will be generated.
		/// </param>
		/// <param name="tcl_output_dir">
		/// Optional
		/// Directory to create TCL files Values: TCL files for the QoR
		/// suggestions will be generated in the provided directory.
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite existing suggestions file
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void write_qor_suggestions(string of_objects, string file, string strategy_dir = null, string tcl_output_dir = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("write_qor_suggestions");
			_tcl.Add(command);
		}
		/// <summary>
		/// write_sdf command generates flat sdf delay files for event simulation
		///
		/// Writes the timing delays for cells in the design to a Standard Delay Format (SDF) file.
		/// The output SDF file can be used by the write_verilog command to create Verilog netlists for
		/// static timing analysis and timing simulation.
		///
		/// The following example writes an SDF file to the specified directory:
		/// write_sdf C:/Data/FPGA_Design/designOut.sdf
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1851
		/// </summary>
		/// <param name="file">
		/// Required
		/// File name
		/// </param>
		/// <param name="process_corner">
		/// Optional
		/// Specify process corner for which SDF delays are required;
		/// Values: slow, fast Default: slow
		/// </param>
		/// <param name="cell">
		/// Optional
		/// Root of the design to write, e.g. des.subblk.cpu Default:
		/// whole design
		/// </param>
		/// <param name="rename_top">
		/// Optional
		/// Replace name of top module with custom name e.g. netlist
		/// Default: new top module name
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite existing SDF file
		/// </param>
		/// <param name="mode">
		/// Optional
		/// Specify sta (Static Timing Analysis) or timesim (Timing
		/// Simulation) mode for SDF Default: timesim
		/// </param>
		/// <param name="gzip">
		/// Optional
		/// write gzipped SDF
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void write_sdf(string file, string process_corner = null, string cell = null, string rename_top = null, bool? force = null, string mode = null, bool? gzip = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("write_sdf");
			_tcl.Add(command);
		}
		/// <summary>
		/// Writes constraints to a Xilinx Design Constraints (XDC) file. The default file extension for a XDC
		/// file is .xdc.
		///
		/// Writes constraints to a Xilinx® Design Constraints file (XDC). The XDC can be exported from the
		/// top-level, which is the default, or from a specific hierarchical cell.
		/// IMPORTANT! The write_xdc command writes the constraints to the specified file in the same order they
		/// are added to or executed in the design.
		/// The write_xdc command lets you write invalid XDC constraints so that you can quickly report
		/// constraints that have been ignored by the Vivado Design Suite due to a problem with the way
		/// the constraint is written or applied. This is useful for debugging constraint files applied in specific
		/// designs.
		/// This command can be used to create an XDC file from a design with UCF files. All constraints
		/// from the active constraint fileset will be exported to the XDC, even if they come from multiple
		/// files.
		/// TIP: The write_xdc command will not convert all UCF constraints into XDC format, and is not intended to
		/// automatically convert UCF based designs to XDC. Refer to the Vivado Design Suite Migration Methodology
		/// Guide (UG911) for more information on migrating UCF constraints to XDC.
		///
		/// The following example writes the valid and invalid constraints, including both fixed and unfixed
		/// cells, to the specified file:
		/// write_xdc -no_fixed_only -constraints all C:/Data/design.xdc
		/// This example writes only the invalid constraints, including both fixed and unfixed cells, to the
		/// specified file:
		/// write_xdc -constraints invalid C:/Data/bad_constraints.xdc
		/// The following example writes the physical constraints only, including any placement constraints
		/// defined in any netlist source files:
		/// write_xdc -exclude_timing -add_netlist_placement C:/Data/physical.xdc
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1862
		/// </summary>
		/// <param name="type">
		/// Required
		/// Types of constraint to export. Values: timing, io, misc, waiver
		/// and physical. If not specified, all constraints will be
		/// exported.
		/// </param>
		/// <param name="no_fixed_only">
		/// Optional
		/// Export fixed and non-fixed placement (by default only fixed
		/// placement is exported)
		/// </param>
		/// <param name="constraints">
		/// Optional
		/// Include constraints that are flagged invalid Values: valid,
		/// invalid, all Default: valid
		/// </param>
		/// <param name="cell">
		/// Optional
		/// Hierarchical cell for which constraints are exported.
		/// </param>
		/// <param name="sdc">
		/// Optional
		/// Export all timing constriants in SDC compatible format.
		/// </param>
		/// <param name="no_tool_comments">
		/// Optional
		/// Don't write verbose tool generated comments to the xdc
		/// when translating from ucf.
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite existing file.
		/// </param>
		/// <param name="exclude_timing">
		/// Optional
		/// Don't export timing constraints.
		/// </param>
		/// <param name="exclude_physical">
		/// Optional
		/// Don't export physical constraints.
		/// </param>
		/// <param name="add_netlist_placement">
		/// Optional
		/// Export netlist placement constraints.
		/// </param>
		/// <param name="logic_function_stripped">
		/// Optional
		/// Write disable_timing constraints which are associated with
		/// having previously run write_edif with its -
		/// logic_function_stripped option.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="file">
		/// Optional
		/// Output constraints to the specified XDC file.
		/// </param>
		public void write_xdc(string type, bool? no_fixed_only = null, string constraints = null, string cell = null, bool? sdc = null, bool? no_tool_comments = null, bool? force = null, bool? exclude_timing = null, bool? exclude_physical = null, bool? add_netlist_placement = null, bool? logic_function_stripped = null, bool? quiet = null, bool? verbose = null, string file = null)
		{
			var command = new SimpleTCLCommand("write_xdc");
			_tcl.Add(command);
		}
	}
}
