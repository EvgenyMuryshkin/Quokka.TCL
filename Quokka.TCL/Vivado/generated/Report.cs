// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class ReportCommands
	{
		private readonly QuokkaTCL _tcl;
		public ReportCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Calculate device configuration time (ms)
		///
		/// Estimates the time in milliseconds (ms) to configure a Xilinx device for the current design.
		/// TIP: The Device Configuration Mode must be defined for this command to work.
		/// Some applications require that the Xilinx device be configured and operational within a short
		/// time. This command lets you estimate the configuration time for the device and design in
		/// question. The configuration time includes the device initialization time plus the configuration
		/// time. Configuration time depends on the size of the device and speed of the configuration logic.
		/// For more information on the configuration time refer to UltraFast Design Methodology Guide for
		/// the Vivado Design Suite (UG949), the UltraScale Architecture Configuration User Guide (UG570), or
		/// the 7 Series FPGAs Configuration User Guide (UG470).
		/// Some of the settings needed to calculate the configuration time are stored as properties on the
		/// current design, such as the BITSTREAM.CONFIG.CONFIGRATE or
		/// BITSTREAM.CONFIG.EXTMASTERCCLK_EN properties. In some master modes, the FPGA
		/// provides the configuration clock to control configuration, with the nominal configuration clock
		/// frequency specified by BITSTREAM.CONFIG.CONFIGRATE. The property can be defined in the
		/// Edit Device Properties dialog box of the Vivado Design Suite IDE, or by using set_property to
		/// directly set the value of the specified property.
		/// For a slave configuration mode, or for configuration modes using an external master clock, the
		/// needed clock frequency is specified by the -clk_freq option.
		/// This command returns a value in milliseconds if successful, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 117
		/// </summary>
		/// <param name="verbose">
		/// Optional
		/// Print out calculation parameters
		/// </param>
		/// <param name="max">
		/// Optional
		/// Calculate Maximum Configuration Time
		/// </param>
		/// <param name="min">
		/// Optional
		/// Calculate Minimum Configuration Time
		/// </param>
		/// <param name="typical">
		/// Optional
		/// Calculate Typical Configuration Time
		/// </param>
		/// <param name="por_used">
		/// Optional
		/// (Deprecated) Specify if Power On Reset (POR) is used by
		/// using a non-zero por_ramp
		/// </param>
		/// <param name="por_ramp">
		/// Optional
		/// Specify a Power On Reset (POR) ramp rate as 1 ms to 50 ms
		/// Default: 0 ms
		/// </param>
		/// <param name="clk_freq">
		/// Optional
		/// Specify a clock frequency for Slave mode, or for Master
		/// mode if using external master clock (MHz) Default: 0 MHz
		/// </param>
		/// <param name="bitstream_size">
		/// Optional
		/// Specify a bitstream size to override the default Default: 0
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <returns>Report</returns>
		public void calc_config_time(bool? verbose = null, bool? max = null, bool? min = null, bool? typical = null, bool? por_used = null, string por_ramp = null, string clk_freq = null, string bitstream_size = null, bool? quiet = null)
		{
			var command = new SimpleTCLCommand("calc_config_time");
			_tcl.Add(command);
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
		/// Create a DRC violation
		///
		/// Create a DRC violation object and manage the list of design objects associated with the violation
		/// for reporting by the report_drc command.
		/// The create_drc_violation command is specified as part of the Tcl checker procedure that
		/// defines and implements the checking feature of a user-defined design rule check created by the
		/// create_drc_check command. A violation object is created by the Tcl checker each time a
		/// violation of the design rule is encountered.
		/// The process in brief is:
		/// • Write a Tcl checker procedure to define the method applied when checking the user-defined
		/// rule, and the objects to check against the rule. The Tcl checker procedure is defined in a
		/// separate Tcl script that must be loaded by the source command prior to running
		/// report_drc.
		/// • Use create_drc_violation in the Tcl checker to identify and flag violations found when
		/// checking the rule against a design.
		/// • Define a user-defined DRC rule check using the create_drc_check command that calls the
		/// Tcl checker proc from the -rule_body.
		/// • Create a rule deck using the create_drc_ruledeck command, and add the user-defined
		/// rule check to the rule deck using the add_drc_checks command.
		/// • Run report_drc, and specify either the rule deck, or the user-defined rule check to check
		/// for violations.
		/// Violations are reported by the report_drc command, and violation objects can be returned by
		/// the get_drc_violations command. The design objects associated with a DRC violation
		/// object can be obtained using the -of_objects option of the appropriate get_* command,
		/// such as get_cells, get_nets, or get_ports for instance:
		/// get_ports -of_objects [get_drc_violations -name drc_1 NSTD*]
		///
		/// The following Tcl script defines the dataWidthCheck procedure which is called by the -
		/// rule_body argument of the RAMW-1 check. This Tcl script file must be loaded into the tool
		/// using the source command, prior to running the report_drc command.
		/// Some features of the Tcl checker proc to notice are:
		/// • A list variable is created to store violations ($vios )
		/// • A violation object is created, and added to the list variable, each time a violation is found.
		/// • The placeholder key %ELG in the $msg string is dynamically substituted with the specific
		/// $bram cell associated with the violation.
		/// • The dataWidthCheck proc returns an error code when any violations are found ($vios >0)
		/// to inform the report_drc command of the results of the check.
		/// • The list of violations is passed along with the return code, and the violations are reported by
		/// report_drc.
		/// # This is a simplistic check -- report BRAM cells with WRITE_WIDTH_B
		/// # wider than 36.
		/// proc dataWidthCheck {} {
		/// # list to hold violations
		/// set vios {}
		/// # iterate through the objects to be checked
		/// foreach bram [get_cells -hier -filter {PRIMITIVE_SUBGROUP == bram}] {
		/// set bwidth [get_property WRITE_WIDTH_B $bram]
		/// if { $bwidth > 36} {
		/// # define the message to report when violations are found
		/// set msg "On cell %ELG, WRITE_WIDTH_B is $bwidth"
		/// set vio [ create_drc_violation -name {RAMW-1} -msg $msg $bram ]
		/// lappend vios $vio
		/// }
		/// }
		/// if {[llength $vios] > 0} {
		/// return -code error $vios
		/// } else {
		/// return {}
		/// }
		/// }
		/// create_drc_check -name {RAMW-1} -hiername {RAMB Checks} \
		/// -desc {Data Width Check} -rule_body dataWidthCheck \
		/// -severity Advisory
		/// Note: The script file can contain both the Tcl checker procedure, and the create_drc_check command
		/// that defines it for use by report_drc command. In this case, when the Tcl script file is sourced, both the
		/// dataWidthCheck proc and the RAMW-1 design rule check are loaded into the tool.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 260
		/// </summary>
		/// <param name="name">
		/// Required
		/// Specify the name for this rule. This is the typically a 4-6
		/// letter specification for your rule.
		/// </param>
		/// <param name="severity">
		/// Optional
		/// Specify severity level for a DRC rule. Default: WARNING.
		/// Values: FATAL, ERROR, CRITICAL WARNING, WARNING,
		/// ADVISORY.
		/// </param>
		/// <param name="msg">
		/// Optional
		/// Specify your message string for this DRC rule.
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
		/// Cells, ports, pins, nets, clock regions, sites, package banks to
		/// query.
		/// </param>
		public void create_drc_violation(string name, string severity = null, string msg = null, bool? quiet = null, bool? verbose = null, string objects = null)
		{
			var command = new SimpleTCLCommand("create_drc_violation");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create Configurable Report objects.
		///
		/// This command lets you create configurable report objects to add to synthesis and
		/// implementation runs, or to add to Report Strategies. A report object defines the report type and
		/// options that are run every time a specified step of a synthesis or implementation design run is
		/// completed. A Report Strategy lets you define a collection of report objects to associate with
		/// many synthesis and implementation runs, and reuse at different stages of the design flow. See
		/// the Vivado Design Suite User Guide: Implementation (UG904) for more information.
		/// Each report object has the 'OPTIONS.MORE_OPTIONS' property, which lets you specify
		/// command line options of the Tcl report_* command associated with the report object. These
		/// command line options are used when the report is generated during the synthesis or
		/// implementation run. You can specify the command line options using the -options argument as
		/// described below, or by manually setting the 'OPTIONS.MORE_OPTIONS' property of an existing
		/// report object using the set_property command. Refer to the specific report_* command for
		/// information on the available command line options.
		///
		/// The following example defines a new report object with the specified name and type and
		/// associates it with the route_design step of the impl_1 run:
		/// create_report_config -report_name post_route_datasheet -report_type
		/// report_datasheet \
		/// -steps route_design -runs impl_1
		/// This example is the same as the prior example, except it does not specify the name, and so the
		/// report object is named automatically as shown in the return value:
		/// create_report_config -report_type report_datasheet -steps route_design -
		/// runs impl_1
		/// impl_1_route_report_datasheet_0
		/// The following example creates a new report object for the timing summary report, with the
		/// specified command-line options, and associates the object with multiple steps of an
		/// implementation run:
		/// create_report_config -report_type report_timing_summary \
		/// -steps {opt_design place_design route_design} -runs {impl_2}\
		/// -options {-no_detailed_paths -report_unconstrained}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 343
		/// </summary>
		/// <param name="steps">
		/// Required
		/// List of run step(s) for object(s) created
		/// </param>
		/// <param name="runs">
		/// Required
		/// List of run(s) for object(s) created
		/// </param>
		/// <param name="copy_of">
		/// Required
		/// configurable report object to be copied
		/// </param>
		/// <param name="report_name">
		/// Optional
		/// Name of configurable report object created. Can not be
		/// used when creating multiple objects
		/// </param>
		/// <param name="report_type">
		/// Optional
		/// Type of configurable report object(s) created. Not required
		/// with '-copy_of'
		/// </param>
		/// <param name="options">
		/// Optional
		/// options for report command to be set at creation of
		/// configurable report object, except with '-copy_of'
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>List of configurable report objects</returns>
		public void create_report_config(string steps, string runs, string copy_of, string report_name = null, string report_type = null, string options = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("create_report_config");
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
		/// Clear a set of clock networks results from memory
		///
		/// Clear the results of the specified report_clock_networks report from the named result set.
		///
		/// The following example clears the specified results set from memory:
		/// delete_clock_network_results ClkNets
		///
		/// See ug835-vivado-tcl-commands.pdf, page 419
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
		public void delete_clock_networks_results(string name, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("delete_clock_networks_results");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete a set of existing configurable report objects
		///
		/// Removes specified report objects from the current project. The report objects are created by the
		/// create_report_config command.
		/// This command returns nothing if successful, or an error if it fails.
		///
		/// The following example deletes the specified report_config object:
		/// delete_report_configs [get_report_configs post_route_datasheet]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 462
		/// </summary>
		/// <param name="report_configs">
		/// Required
		/// List of configurable report objects to delete
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void delete_report_configs(string report_configs, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("delete_report_configs");
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
		/// Delete utilization results that were stored in memory under a given name.
		///
		/// Clear the specified utilization results from the named result set.
		///
		/// The following example clears the specified results set from memory:
		/// delete_utilization_results -name SSO1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 470
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
		public void delete_utilization_results(string name, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("delete_utilization_results");
			_tcl.Add(command);
		}
		/// <summary>
		/// Generate a set of configurable report objects
		///
		/// Generates specified report objects as created by the create_report_config command.
		/// Because the report objects are associated with specific steps of synthesis or implementation
		/// runs, those steps must be completed prior to the generation of the report. If a step is not
		/// completed, or the report is not enabled, then the generate_report command will return an
		/// error.
		///
		/// The following example generates the specified report object:
		/// generate_report [get_report_configs post_route_datasheet]
		/// TIP: If the report is already GENERATED according to the STATE property, the report will not be regenerated.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 535
		/// </summary>
		/// <param name="report_configs">
		/// Required
		/// List of configurable report objects to generate
		/// </param>
		/// <param name="jobs">
		/// Optional
		/// Number of jobs Default: 1
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void generate_reports(string report_configs, string jobs = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("generate_reports");
			_tcl.Add(command);
		}
		/// <summary>
		/// Returns the current message count, limit, or the message configuration rules previously defined
		/// by the set_msg_config command.
		///
		/// Returns the current message limit or count applied to a specified message ID or severity, or
		/// returns all message configuration rules defined in the current project. Message configuration
		/// rules are defined using the set_msg_config command.
		/// When used with -count this command will display the total number of messages that have
		/// been generated with the matching message id, or for the specified severity.
		/// IMPORTANT! The get_msg_config command reports the message count for the original CPU process from
		/// which Vivado was launched. Any sub-processes that the Vivado Design Suite launches, such as sub-processes
		/// used by the launch_runs command to launch synthesis and implementation runs, will not be reported in the
		/// message count. This can create confusion when the message count returned by get_msg_config -count
		/// is different from what is displayed in the Vivado IDE for instance, or different from what you expect. For this
		/// reason, the -count option is best used for non-project based designs.
		/// When used with -limit this command will display the current limit of messages with the
		/// matching message id, or for the specified severity.
		/// When used with -rules, it will display a table of all message configuration rules currently in
		/// effect.
		/// Note: You can only return the limit, the count, or the rules in a single get_msg_config command. An
		/// error is returned if more than one action is attempted.
		///
		/// The following example gets the current count of the specified INFO message:
		/// get_msg_config -id "Common 17-81" -count
		/// The following example returns the message configuration rules in the current project:
		/// get_msg_config -rules
		/// This example changes the severity of messages with the specified message ID, gets the current
		/// message configuration rules, and then shows two different command forms to reset the specific
		/// rule and restore the message:
		/// set_msg_config -id "Common 17-361" -severity INFO -new_severity WARNING
		/// get_msg_config -rules
		/// ---------------------
		/// Message control rules currently in effect are:
		/// Rule Name Rule Current
		/// Message Count
		/// 1 set_msg_config -ruleid {1} -id {Common 17-361} -severity {INFO} -
		/// new_severity {WARNING} 0
		/// ---------------------
		/// reset_msg_config -id "Common 17-361" -default_severity
		/// reset_msg_config -ruleid {1}
		/// TIP: In the preceding example, only one of the reset_msg_config commands is needed to reset the
		/// message.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 815
		/// </summary>
		/// <param name="id">
		/// Optional
		/// The message id to match. Should be used in conjunction
		/// with -limit or -count Default: empty
		/// </param>
		/// <param name="severity">
		/// Optional
		/// The message severity to match. Should be used in
		/// conjunction with -limit or -count Default: empty
		/// </param>
		/// <param name="rules">
		/// Optional
		/// Show a table displaying all message control rules for the
		/// current project
		/// </param>
		/// <param name="limit">
		/// Optional
		/// Show the limit for the number of messages matching either
		/// -id or -severity that will be displayed
		/// </param>
		/// <param name="count">
		/// Optional
		/// Show the number of messages matching either -id or -
		/// severity that have been displayed
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void get_msg_config(string id = null, string severity = null, bool? rules = null, bool? limit = null, bool? count = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("get_msg_config");
			_tcl.Add(command);
		}
		/// <summary>
		/// Internal TCL task for reporting PPLOCs on pins or nets
		///
		/// See ug835-vivado-tcl-commands.pdf, page 870
		/// </summary>
		/// <param name="nets">
		/// Required
		/// List of nets to report its PPLOCs
		/// </param>
		/// <param name="pins">
		/// Required
		/// List of pins to report its PPLOCs
		/// </param>
		/// <param name="count">
		/// Optional
		/// Count number of PPLOCs;; Do not report PPLOC or node
		/// names.
		/// </param>
		/// <param name="unlocked">
		/// Optional
		/// Report unlocked/unfixed PPLOCs only
		/// </param>
		/// <param name="locked">
		/// Optional
		/// Report locked/fixed PPLOCs only; use -level to specify locked
		/// level.
		/// </param>
		/// <param name="level">
		/// Optional
		/// Specify locked level; Valid values are placement and routing.
		/// Default: placement
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>PPLOC nodes or number of PPLOCs</returns>
		public void get_pplocs(string nets, string pins, bool? count = null, bool? unlocked = null, bool? locked = null, string level = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("get_pplocs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of Configurable Report objects
		///
		/// Returns a list of report objects created by the create_report_config command.
		/// This command returns the list of report objects matching the search pattern and filters, or returns
		/// an error if it fails.
		///
		/// The following example gets all of the report objects in the current project:
		/// get_report_configs
		/// The following example gets all of the report objects in the current project that are associated
		/// with the opt_design step:
		/// get_report_configs -filter {RUN_STEP == opt_design}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 888
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Get 'report' objects of these types: 'run'.
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
		/// Match report names against patterns Default: *
		/// </param>
		/// <returns>list of Configurable Report objects</returns>
		public void get_report_configs(string of_objects, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_report_configs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Open report from .rpx file
		///
		/// Read an RPX (protobuf) file into memory to reload report results into the Vivado Design Suite.
		/// This command requires an open implemented or synthesized design.
		/// The RPX file is written by report commands such as report_timing_summary, and
		/// report_pulse_width, that support the -rpx option, and is an interactive report file that can
		/// be reloaded into memory. Reloading the report into memory, reconnects the objects in the report
		/// to design objects so that cross-selection between the report in the Vivado IDE and the design is
		/// enabled.
		/// This command returns the report results to the Tcl console by default, or when -console is
		/// specified, or opens a report window in the Vivado IDE when -name is specified. This command
		/// returns an error if it fails.
		///
		/// The following example reads the specified RPX file an opens a named report in the Vivado IDE:
		/// open_report -name RPX1 design1_summary.rpx
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1068
		/// </summary>
		/// <param name="rpx">
		/// Required
		/// Report data file to be read
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, don't overwrite the results file
		/// </param>
		/// <param name="console">
		/// Optional
		/// Send output to console
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
		public void open_report(string rpx, string file = null, bool? append = null, bool? console = null, string name = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("open_report");
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
		/// Report carry chains
		///
		/// Report the details of the carry chains used by the current open design. The report includes the
		/// average depth of all carry chains, as well as the specific depth of each carry chain reported.
		/// By default, the longest carry chain is reported, but the number of chains reported can be
		/// specified.
		/// The command returns the carry chain report.
		///
		/// The following example returns the 10 longest carry chains in the design:
		/// report_carry_chains -max_chains 10
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1274
		/// </summary>
		/// <param name="cell">
		/// Required
		/// Report Carry Chains only for given cell
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
		/// <param name="return_string">
		/// Optional
		/// return report as string
		/// </param>
		/// <param name="max_chains">
		/// Optional
		/// Number of chains for which report is to be generated
		/// Default: 1
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
		public void report_carry_chains(string cell, string file = null, bool? append = null, bool? return_string = null, string max_chains = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_carry_chains");
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
		/// Report Implementation flow Config param
		///
		/// Report the user-definable implementation flow configuration parameters for the implementation
		/// processes. These are parameters that can be modified using the config_implementation
		/// command.
		/// This command returns the selected report or the name of the output file, or returns an error if it
		/// fails.
		///
		/// This example reports the user-configurable implementation parameters to the Tcl console:
		/// report_config_implementation
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1296
		/// </summary>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. Send output to console if -file
		/// is not used.
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite existing file
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append to existing file
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
		public void report_config_implementation(string file = null, bool? force = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_config_implementation");
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
		/// Report the unique control sets in design
		///
		/// Report the control sets of the current design.
		/// Control sets are the list of control signals (Clock, CE, SR) for SLICE registers and LUTs. Registers
		/// must belong to the same control set in order to be packed into the same device resource.
		/// Registers without a control signal cannot be packed into devices with registers having control
		/// signals. A high number of control sets can cause difficulty fitting the device and can cause routing
		/// congestion and timing issues.
		/// By default the report_control_sets command returns an abbreviated report indicating only
		/// the number of unique control sets. However, the -verbose arguments returns a detailed report
		/// of all control sets, for either the whole design or for the specified cells.
		///
		/// The following example reports the control sets of the current design, sorted by the clk and clkEn
		/// signals:
		/// report_control_sets -verbose -sort_by {clk clkEn}
		/// The following example reports the control sets of the specified cells, sorted by clk and set:
		/// report_control_sets -verbose -sort_by {clk set} -cells [get_cells usb*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1301
		/// </summary>
		/// <param name="sort_by">
		/// Required
		/// Sort criterion: can be used only when -verbose is used.
		/// Options are clk, clkEn, set. Ex: report_control_sets -verbose -
		/// sort_by {clk clkEn}
		/// </param>
		/// <param name="cells">
		/// Required
		/// Cells/bel_instances for which to report control sets
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
		/// <param name="hierarchical">
		/// Optional
		/// Generates text-based hierarchical report.
		/// </param>
		/// <param name="hierarchical_depth">
		/// Optional
		/// Specifies the depth level for textual hierarchical report
		/// Default: 0
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
		public void report_control_sets(string sort_by, string cells, string file = null, bool? append = null, bool? hierarchical = null, string hierarchical_depth = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_control_sets");
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
		/// Report details on debug cores
		///
		/// Writes a report of the various Vivado device tool debug cores in the current project, and the
		/// parameters of those cores. Debug cores can be added to a project using the
		/// create_debug_core command.
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be
		/// written to a file or returned as a string if desired.
		///
		/// The following example writes the debug core report to the specified file name at the specified
		/// location:
		/// report_debug_core -file C:/Data/FPGA_Design/project_1_cores.txt
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1307
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
		/// Return report as a string
		/// </param>
		/// <param name="full_path">
		/// Optional
		/// Display full hierarchical net path in report
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void report_debug_core(string file = null, bool? append = null, bool? return_string = null, bool? full_path = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_debug_core");
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
		/// Report system information.
		///
		/// Report the details of the system environment that the tool is running under. The details of the
		/// environment report include: operating system version, CPU, memory, available disk space, and
		/// specific settings of various environment variables.
		/// The default is to write the report to the standard output. However, the report can be written to a
		/// file instead.
		///
		/// The following example reports the current environment to the specified file:
		/// report_environment -file C:/Data/toolEnv.txt
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1329
		/// </summary>
		/// <param name="file">
		/// Optional
		/// Write system information to specified file.
		/// </param>
		/// <param name="format">
		/// Optional
		/// Specifies how to format the report. Default is 'text', another
		/// option is 'xml'. Only applies if -file is used. If xml output is
		/// used, -append is not allowed. Default: text
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append report to existing file
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// Return report content as a string value
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void report_environment(string file = null, string format = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_environment");
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
		/// Formatted report on Versal integrated and soft Memory Controllers' (DDRMCs) memory
		/// configurations, calibration status, stages, and window margins data.
		///
		/// Report formatted information on memory IP hardware configuration, calibration, and margin.
		/// Does not include the graphical margin scan plots that are available within the Vivado logic
		/// analyzer, or Vivado Lab Edition.
		/// In the Vivado tools, Versal memory controllers implemented into a design are associated with
		/// hw_ddrmc objects. These hw_ddrmc objects let you verify the calibration, read, and write
		/// window margins in your memory interface design. You can use the hardware manager GUI to
		/// check the calibration status, verify the read margin for both rising and falling edges of the clock,
		/// and write margin for both simple and complex patterns. You can also use an ILA and VIO core to
		/// verify the data integrity for the read and write operations.
		/// This command returns the reported data, or returns an error if it fails.
		///
		/// The following example generates the report on the hw_ddrmc objects and outputs them to the
		/// text file specified:
		/// report_hw_ddrmc -file C:/Data/ddrmc_report.txt [get_hw_ddrmcs]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1345
		/// </summary>
		/// <param name="hw_objects">
		/// Required
		/// hardware DDRMC objects
		/// </param>
		/// <param name="file">
		/// Optional
		/// file name (including full path) to output the report results to
		/// </param>
		/// <param name="append">
		/// Optional
		/// set this option to append the report results to a file
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// set this option to have report results returned as a string
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void report_hw_ddrmc(string hw_objects, string file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_hw_ddrmc");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report formatted hardware MIG calibration status and margin data
		///
		/// Report formatted information on memory IP hardware configuration, calibration, and margin.
		/// Does not include the graphical margin scan plots that are available within the Vivado logic
		/// analyzer, or Vivado Lab Edition.
		/// In the Vivado tools, memory controllers implemented into a design are associated with hw_mig
		/// objects. These hw_mig objects let you verify the calibration, read, and write window margins in
		/// your memory interface design. You can use the hardware manager GUI to check the calibration
		/// status, verify the read margin for both rising and falling edges of the clock, and write margin for
		/// both simple and complex patterns, or DQS. You can also use an ILA core to verify the data
		/// integrity for the read and write operations.
		/// This command returns the reported data, or returns an error if it fails.
		///
		/// The following example generates the report on the hw_mig objects and outputs to the text file
		/// specified:
		/// report_hw_mig -file C:/Data/hw_mig_report.txt [get_hw_migs]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1347
		/// </summary>
		/// <param name="hw_objects">
		/// Required
		/// hardware mig objects
		/// </param>
		/// <param name="file">
		/// Optional
		/// file name (including full path) to output the report results to
		/// </param>
		/// <param name="append">
		/// Optional
		/// set this option to append the report results to a file
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// set this option to have report results return as a string
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void report_hw_mig(string hw_objects, string file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_hw_mig");
			_tcl.Add(command);
		}
		/// <summary>
		/// Compute achievable incremental reuse for the given design-checkpoint and report
		///
		/// For use with the incremental implementation flow, this command reports on the amount of
		/// design overlap between the current design and an incremental checkpoint loaded using the
		/// read_checkpoint -incremental command.
		/// This report analyzes the loaded incremental checkpoint against the current design to see if the
		/// two are sufficiently correlated to drive incremental placement and routing. A low correlation
		/// between the current design and the checkpoint should discourage using the checkpoint as a
		/// basis for incremental place and route. Refer to the Vivado Design Suite User Guide: Implementation
		/// (UG904) for more information on incremental place and route.
		/// If there is a low correlation of reuse between the current design and the loaded incremental
		/// checkpoint, you will need to restore the original design using open_run or read_checkpoint.
		/// Alternatively, you can overload the incremental checkpoint in the current design by issuing the
		/// read_checkpoint -incremental command again to specify a new incremental checkpoint.
		/// For Partial Reconfiguration (PR) designs, the % of cells matching in Reconfigurable Modules (RM)
		/// are reported, the % of cells reused in RMs, and the % of cells fixed in RMs are also reported.
		/// There is also a Reconfigurable Modules Summary table added to the report.
		///
		/// The following example loads an incremental checkpoint into the current design, and then reports
		/// the correlation of the loaded incremental checkpoint to the current design:
		/// read_checkpoint -incremental C:/Data/reuse_checkpoint1.dcp
		/// report_incremental_reuse
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1351
		/// </summary>
		/// <param name="cells">
		/// Required
		/// Report incremental reuse of given list of cells
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
		/// <param name="hierarchical">
		/// Optional
		/// Generates text-based hierarchical incremental reuse report.
		/// </param>
		/// <param name="hierarchical_depth">
		/// Optional
		/// Specifies the depth level for textual hierachical incremental
		/// reuse report Default: 0
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
		public void report_incremental_reuse(string cells, string file = null, bool? append = null, bool? hierarchical = null, string hierarchical_depth = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_incremental_reuse");
			_tcl.Add(command);
		}
		/// <summary>
		/// Display information about all the IO sites on the device
		///
		/// Report details of the IO banks of the current design. Details include device specific information
		/// such as target part, package, and speed grade, and also provides information related to each pin
		/// on the device.
		/// This command returns the requested report, or returns an error if it fails.
		///
		/// The following example reports the IO blocks of the current design:
		/// report_io
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1354
		/// </summary>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. Send output to console if -file
		/// is not used.
		/// </param>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append to existing file
		/// </param>
		/// <param name="format">
		/// Optional
		/// Specifies how to format the report: text, xml. Default is
		/// 'text'. Only applies if -file is used. If xml output is used, -
		/// append is not allowed. Default: text
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
		public void report_io(string file = null, string name = null, bool? append = null, string format = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_io");
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
		/// Get operating conditions values for power estimation
		///
		/// Displays the real-world operating conditions that are used when performing analysis of the
		/// design. The reported values of operating conditions can be defined by the
		/// set_operating_conditions command.
		/// The environmental operating conditions of the device are used for power analysis when running
		/// the report_power command, but are not used during timing analysis.
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be
		/// written to a file or returned as a string if desired.
		///
		/// Specify an industrial temperature grade device with an ambient temperature of 75 degrees C and
		/// then write those settings to a file on disk.
		/// set_operating_conditions -grade industrial -junction_temp 75
		/// report_operating_conditions -grade -junction_temp -return_string -file \
		/// ~/conditions.txt
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1365
		/// </summary>
		/// <param name="voltage">
		/// Required
		/// Gets voltage value. Supported voltage supplies vary by
		/// family.
		/// </param>
		/// <param name="grade">
		/// Optional
		/// Temperature grade. Supported values vary by family.
		/// </param>
		/// <param name="process">
		/// Optional
		/// Gets process
		/// </param>
		/// <param name="junction_temp">
		/// Optional
		/// Junction Temperature (C): auto|degC
		/// </param>
		/// <param name="ambient_temp">
		/// Optional
		/// Ambient Temperature (C): default|degC
		/// </param>
		/// <param name="thetaja">
		/// Optional
		/// ThetaJA (C/W): auto|degC/W
		/// </param>
		/// <param name="thetasa">
		/// Optional
		/// Gets ThetaSA
		/// </param>
		/// <param name="airflow">
		/// Optional
		/// Airflow (LFM): 0 to 750
		/// </param>
		/// <param name="heatsink">
		/// Optional
		/// Gets dimensions of heatsink
		/// </param>
		/// <param name="thetajb">
		/// Optional
		/// Gets ThetaJB
		/// </param>
		/// <param name="board">
		/// Optional
		/// Board type: jedec, small, medium, large, custom
		/// </param>
		/// <param name="board_temp">
		/// Optional
		/// Board Temperature degC
		/// </param>
		/// <param name="board_layers">
		/// Optional
		/// Board layers: 4to7, 8to11, 12to15, 16+
		/// </param>
		/// <param name="design_power_budget">
		/// Optional
		/// Design Power Budget (W)
		/// </param>
		/// <param name="all">
		/// Optional
		/// Gets all operating conditions listed in this help message
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// return operating conditions as string
		/// </param>
		/// <param name="append">
		/// Optional
		/// append operating conditions to end of file
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void report_operating_conditions(string voltage, bool? grade = null, bool? process = null, bool? junction_temp = null, bool? ambient_temp = null, bool? thetaja = null, bool? thetasa = null, bool? airflow = null, bool? heatsink = null, bool? thetajb = null, bool? board = null, bool? board_temp = null, bool? board_layers = null, bool? design_power_budget = null, bool? all = null, string file = null, bool? return_string = null, bool? append = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_operating_conditions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get information about all parameters
		///
		/// Gets a list of all user-definable parameters, the current value, and a description of what the
		/// parameter configures or controls.
		///
		/// The following example returns the name, value, and description of all user-definable parameters:
		/// report_param
		/// The following example returns the name, value, and description of user-definable parameters
		/// that match the specified search pattern:
		/// report_param *coll*
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1368
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
		/// <param name="non_default">
		/// Optional
		/// Report only params that are set to a non default value
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
		/// <param name="pattern">
		/// Optional
		/// Display params matching pattern Default: *
		/// </param>
		/// <returns>param report</returns>
		public void report_param(string file = null, bool? append = null, bool? non_default = null, bool? return_string = null, bool? quiet = null, bool? verbose = null, string pattern = null)
		{
			var command = new SimpleTCLCommand("report_param");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report details of Physical Synthesis transformations.
		///
		/// Reports the results of the fanout driver replication and load redistribution optimizations
		/// performed by the phys_opt_design command.
		///
		/// The following example reports the physical optimizations performed in the current design by the
		/// phys_opt_design command:
		/// report_phys_opt -file C:/Data/physOpt_Report.txt
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1370
		/// </summary>
		/// <param name="file">
		/// Optional
		/// Output file
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file
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
		public void report_phys_opt(string file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_phys_opt");
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
		/// Report reconfigurable partition analysis across multiple configurations
		///
		/// IMPORTANT! You must first define the project as a Partial Reconfiguration (PR) project by setting the
		/// PR_FLOW property on the project to TRUE, or by using the Tools > Enable Partial Reconfiguration command.
		/// Report reconfigurable partition analysis across multiple configurations as defined by
		/// create_pr_configuration. This report compares each Reconfigurable Module that you
		/// select to give you input on your PR design. It examines resource usage, floorplanning, clocking,
		/// and timing metrics to help you manage the overall PR design. For more information on this
		/// command refer to the Vivado Design Suite User Guide: Dynamic Function eXchange (UG909).
		/// When this analysis is done, each RM is examined based on information in the checkpoints
		/// provided. While post-synthesis checkpoints can be supplied, the most complete information is
		/// not available until after opt_design when all the linking and expansion has been done.
		///
		/// The following example performs complexity analysis of the design:
		/// report_pr_configuration_analysis -complexity
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1381
		/// </summary>
		/// <param name="cells">
		/// Required
		/// List of reconfigurable cell names
		/// </param>
		/// <param name="dcps">
		/// Required
		/// List of design checkpoints for each reconfigurable cell. The
		/// order of dcps must match that of the -cells option.
		/// </param>
		/// <param name="complexity">
		/// Optional
		/// Run complexity analysis
		/// </param>
		/// <param name="clocking">
		/// Optional
		/// Run clocking analysis
		/// </param>
		/// <param name="timing">
		/// Optional
		/// Run boundary net timing analysis
		/// </param>
		/// <param name="rent">
		/// Optional
		/// Compute Rents component as part of complexity analysis.
		/// Runtime intensive for large designs.
		/// </param>
		/// <param name="nworst">
		/// Optional
		/// Specifies the N worst boundary paths. Default: 10
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void report_pr_configuration_analysis(string cells, string dcps, bool? complexity = null, bool? clocking = null, bool? timing = null, bool? rent = null, string nworst = null, string file = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_pr_configuration_analysis");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report properties of object
		///
		/// Gets the property name, property type, and property value for all of the properties on a specified
		/// object, or class of objects.
		/// Note: list_property also returns a list of all properties on an object, but does not include the property
		/// type or value.
		/// You can specify objects for report_property using the get_* series of commands to get a
		/// specific object. You can use the lindex command to return a specific object from a list of
		/// objects:
		/// report_property [lindex [get_cells] 0]
		/// However, if you are looking for the properties on a class of objects, you should use the -
		/// classoption instead of an actual object.
		/// This command returns a report of properties on the object, or returns an error if it fails.
		///
		/// The following example returns all properties of the specified object:
		/// report_property -all [get_cells cpuEngine]
		/// The following example returns the properties of the specified class of objects, rather than an
		/// actual object:
		/// report_property -class bel
		/// The following example returns properties on the current hw_device that match the specified
		/// pattern, specified as a regular expression:
		/// report_property [current_hw_device] -regexp .*PROG.*
		/// To determine which properties are available for the different design objects supported by the
		/// tool, you can use multiple report_property commands in sequence. The following example
		/// returns all properties of the specified current objects:
		/// report_property -all [current_project]
		/// report_property -all [current_fileset]
		/// report_property -all [current_design]
		/// report_property -all [current_run]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1384
		/// </summary>
		/// <param name="all">
		/// Optional
		/// Report all properties of object even if not set
		/// </param>
		/// <param name="class">
		/// Optional
		/// Object type to query for properties. Not valid with <object>
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// Set the result of running report_property in the Tcl
		/// interpreter's result variable
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output result to. Send output to console if -file
		/// is not used
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, don't overwrite the results file
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Pattern is treated as a regular expression
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="object">
		/// Optional
		/// Object to query for properties
		/// </param>
		/// <param name="pattern">
		/// Optional
		/// Pattern to match properties against Default: *
		/// </param>
		/// <returns>property report</returns>
		public void report_property(bool? all = null, string class = null, bool? return_string = null, string file = null, bool? append = null, bool? regexp = null, bool? quiet = null, bool? verbose = null, string object = null, string pattern = null)
		{
			var command = new SimpleTCLCommand("report_property");
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
		/// Report configuration about RAMs in design
		///
		/// Report RAM resource usage on the target part in the current synthesized or implemented design.
		/// The report is returned to the standard output, unless the -file or -return_string
		/// arguments are used.
		/// The report details the following tables:
		/// • Summary: The Summary table shows the utilization by RAM type, broken down into URAM,
		/// Block RAM and Distributed RAM. For each RAM type, it is broken down into the individual
		/// primitives. Also detailed is the inferred primitives. The inferred primitive % is important as the
		/// remaining tables are dependent on information provided by Vivado Synthesis during
		/// inference.
		/// Primitives that are directly inferred or inferred by use of XPMs, will be grouped by their RTL
		/// description. The report details how the RTL description of the array has been mapped to the
		/// primitives in the part, the key performance aspects of each port and connection information
		/// that can be used to determine if it is efficiently implemented from a power perspective.
		/// If using a different synthesis tool or instantiation of primitives is prevalent in the design then
		/// the -detail switch can be used to provide some more information but it will not group RAM
		/// together into larger arrays and some information will be lost. Only the Summary and Non￾Inferred primitives table are available.
		/// This information in the summary can be used to determine if there are imbalances in the
		/// utilization of different types of rams. The accuracy of the information increase after
		/// place_design. Based on the summary, a design might benefit from retargeting heavily used
		/// primitives to lesser used ones at the cost of being less efficient.
		/// Additionally Distributed RAM implementation can be evaluated. Distributed RAM primitives
		/// vary in their efficiency of Bits/LUT. For example, a RAM32M16 uses 8 LUTs and can have up
		/// to 14 data bits. Using RAM32X1D primitives, 8 LUTs yields a maximum of 8 bits when LUT
		/// combined.
		/// • Memory Description: The Memory Description table gives an RTL look at the inferred
		/// memories. It looks at depth, width, memory type and timing requirement. The table is ordered
		/// by the total number of bits in the memory array. The array name is repeated in the other
		/// tables so it can be used as a search term when the report is large.
		/// Note: For distributed RAMs, the read/write port is mapped to Port A and read port information is
		/// mapped to Port B regardless of the primitive port naming.
		/// • Memory Utilization: The Memory Utilization table details how each memory array is mapped
		/// to primitives. Also provided is information on how efficient the mapping is and whether the
		/// mapping is limited by depth or width.
		/// • Memory Performance: The Memory Performance table details performance aspects of the
		/// RAM. It includes information whether the output register is used, cascading has been used. If
		/// the -include_path_info switch is specified there is extra information on the worst path
		/// from each pin listed.
		/// • Memory Power: The Memory Power table details what power aspects of the RAM have been
		/// used. It includes information on cascading and whether the enable pin is tied to POWER or a
		/// signal.
		/// • Non-Inferred Memory Primitives: This table is reported when the -details option is
		/// specified. This will collate as much information as is possible for each primitive that is not
		/// inferred, and list it here. Due to the size of this part of the report, distributed RAM is not
		/// included.
		/// This command returns the requested report to the Tcl console, to a file, or as a string; or returns
		/// an error if it fails.
		///
		/// The following example provides a full report of the inferred and non-inferred RAM resources and
		/// writes the results to the specified file:
		/// report_ram_utilization -file C:/Data/ram_util.txt
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1399
		/// </summary>
		/// <param name="cells">
		/// Required
		/// Limits the reporting to only those memory arrays that are
		/// contained within the specified cells.
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append to existing file
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// return report as string
		/// </param>
		/// <param name="include_path_info">
		/// Optional
		/// Adds path info to the RAM inputs/outputs
		/// </param>
		/// <param name="detail">
		/// Optional
		/// When specified, the report will include information on
		/// primitives that are either not inferred or have been inferred
		/// with prior versions of Vivado Synthesis.
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
		public void report_ram_utilization(string cells, bool? append = null, string file = null, bool? return_string = null, bool? include_path_info = null, bool? detail = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_ram_utilization");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report on status of the routing.
		///
		/// Reports the state of routing in the current design.
		/// The route status report can include a wide range of information, from a simple 1 if the design has
		/// routing, to a complete route tree for each net in the design.
		///
		/// The following example reports the route status for the specified nets:
		/// report_route_status -of_objects [get_nets u4*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1402
		/// </summary>
		/// <param name="of_objects">
		/// Required
		/// Report detailed routing for these routes
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// Set the result of running the report in the Tcl interpreter's
		/// result variable
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
		/// <param name="route_type">
		/// Optional
		/// Only show routes with the given status: UNPLACED|
		/// NOLOADS|NODRIVER|UNROUTED|ANTENNAS|
		/// CONFLICTS|PAR TIAL|INTRASITE|HIERPORT|ROUTED
		/// (ignored if -of_objects is used)
		/// </param>
		/// <param name="list_all_nets">
		/// Optional
		/// list full route information for every net in the design
		/// (ignored if -of_objects is used)
		/// </param>
		/// <param name="show_all">
		/// Optional
		/// list all relevant pins for routes marked as UNPLACED or
		/// PARTIAL routes and list all relevant nodes for routes marked
		/// as ANTENNAS or CONFLICTS routes (by default only the first
		/// 15 pins or nodes are listed for a route)
		/// </param>
		/// <param name="dump_routes">
		/// Optional
		/// show the full routing tree for every routed net in the design.
		/// This is VERY VERBOSE.
		/// </param>
		/// <param name="has_routing">
		/// Optional
		/// returns 0 if there is no routing currently stored for this
		/// design and 1 if there is. All other options are ignored.
		/// </param>
		/// <param name="boolean_check">
		/// Optional
		/// returns 1 if the given flag is true and 0 if it is not. Value flags
		/// that can be checked are: PLACED_FULLY|
		/// PARTIALLY_ROUTED|ROUTED_FULLY|ERRORS_IN_ROUT ES.
		/// All other options are ignored (cannot be used with -
		/// has_routing).
		/// </param>
		/// <param name="ignore_cache">
		/// Optional
		/// throw away all cached information and recalculate the route
		/// status for the entire design (slow)
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void report_route_status(string of_objects, bool? return_string = null, string file = null, bool? append = null, string route_type = null, bool? list_all_nets = null, bool? show_all = null, bool? dump_routes = null, bool? has_routing = null, string boolean_check = null, bool? ignore_cache = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_route_status");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report the list of correct SIM_DEVICE attribute values for cell types in the target part
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1408
		/// </summary>
		/// <param name="part">
		/// Optional
		/// Part
		/// </param>
		/// <param name="file">
		/// Optional
		/// Output file
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file
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
		/// <returns>Report</returns>
		public void report_sim_device(string part = null, string file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_sim_device");
			_tcl.Add(command);
		}
		/// <summary>
		/// Run SSN analysis on the current package and pinout
		///
		/// Perform a simultaneous switching noise (SSN) analysis of the current design. The SSN analysis is
		/// an accurate method for predicting how output switching affects interface noise margins. The
		/// calculation and estimates are based on a range of variables intended to identify potential noise￾related issues in your design and should not be used as final design "sign off" criteria.
		/// SSN analysis provides estimates of the disruption that simultaneously switching outputs can
		/// cause on other output ports in the I/O bank. The SSN predictor incorporates I/O bank-specific
		/// electrical characteristics into the prediction to better model package effects on SSN.
		/// The report_ssn command can be affected by the temperature grade of the selected device as
		/// defined by the -grade option of the set_operating_condition command. Setting the
		/// temperature grade prior to running noise analysis lets you see how noisy signals can be on
		/// Commercial, Extended, Industrial, Q-Grade, or Military grade devices.
		/// By default, report_ssn assumes that every port toggles asynchronously. This results in a
		/// worst-case noise analysis, which may be overly pessimistic. The -phase option lets you consider
		/// clocking information available in the design to more accurately report SSN noise. Clocks must be
		/// defined using the create_clock and create_generated_clock commands. The period,
		/// phase shift and duty cycle of the generated clocks have significant impact on SSN analysis.
		/// The report_ssn command provides a detailed SSN analysis for Xilinx UltraScale architecture
		/// devices, Virtex-7, Kintex-7, and Artix-7 devices. The report is returned to the standard output,
		/// unless the -file, -return_string, or -name arguments are specified.
		/// TIP: Not all parts support the report_ssn command. The Vivado Design Suite will return an error if you run
		/// report_ssn on a target part that does not support SSN analysis. You can query the SSN_REPORT property of
		/// a part to see if it supports the command. Refer to the Examples for more information.
		///
		/// The following example performs an SSN analysis on the current design, formats the output as
		/// HTML, and writes the output to the specified file:
		/// report_ssn -format html -file C:/Data/devSSN.html
		/// The following example performs an SSN analysis, with phase analysis, and returns the output to a
		/// string which is stored in the specified variable:
		/// set devSSN [report_ssn -phase -format html -return_string]
		/// Note: The -format argument in the preceding example is ignored in the absence of -file.
		/// The following example queries the part in the current project to see if it supports the
		/// report_ssn command, and then gets a list of parts from the same part family that support the
		/// command:
		/// get_property SSN_REPORT [get_property PART [current_project]]
		/// get_parts -filter "FAMILY == [get_property FAMILY [get_property PART \
		/// [current_project]]] && SSN_REPORT"
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1411
		/// </summary>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// Return report as string
		/// </param>
		/// <param name="format">
		/// Optional
		/// Report format. Valid arguments are CSV, HTML, TXT Default:
		/// csv
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the report to the specified file
		/// </param>
		/// <param name="phase">
		/// Optional
		/// Account for multi-clock phase in the analysis
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>ssn report</returns>
		public void report_ssn(string name = null, bool? return_string = null, string format = null, string file = null, bool? append = null, bool? phase = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_ssn");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get switching activity on specified objects
		///
		/// This command is used to report different kinds of switching activity on design nets, ports, pins,
		/// and cells in the current synthesized or implemented design. These include simple signal rate and
		/// simple static probability on nets, ports, and pins; and state dependent static probabilities on cells.
		/// The reported values are defined using the set_switching_activity command.
		/// Note: This command returns the switching activity for the specified objects, or the current design.
		/// By default the report is written to the Tcl console or STD output. However, the results can also
		/// be written to a file or returned as a string if desired.
		///
		/// The following example reports the signal_rate and static probability value on all output ports:
		/// report_switching_activity -signal_rate -static_probability [all_outputs]
		/// The following example reports the signal_rate and static probability value on all LUT objects in
		/// the design:
		/// report_switching_activity -signal_rate -static_probability -type lut -all
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1416
		/// </summary>
		/// <param name="type">
		/// Required
		/// Specify nodes in a specific category. List of valid type values:
		/// io_output, io_bidir_enable, register, lut_ram, lut, dsp,
		/// bram_enable, bram_wr_enable, gt_txdata, gt_rxdata.
		/// </param>
		/// <param name="static_probability">
		/// Optional
		/// report static probability
		/// </param>
		/// <param name="signal_rate">
		/// Optional
		/// report signal rate
		/// </param>
		/// <param name="toggle_rate">
		/// Optional
		/// report toggle rate
		/// </param>
		/// <param name="default_static_probability">
		/// Optional
		/// report default static probability
		/// </param>
		/// <param name="default_toggle_rate">
		/// Optional
		/// report default toggle rate
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// return switching activity as string
		/// </param>
		/// <param name="append">
		/// Optional
		/// append switching activity to end of file
		/// </param>
		/// <param name="hier">
		/// Optional
		/// Hierarchically reports the switching activity on nets within a
		/// hierarchical instance provided via <objects> option.
		/// </param>
		/// <param name="all">
		/// Optional
		/// Report switching activities for all nets for the design.
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
		/// objects
		/// </param>
		public void report_switching_activity(string type, bool? static_probability = null, bool? signal_rate = null, bool? toggle_rate = null, bool? default_static_probability = null, bool? default_toggle_rate = null, string file = null, bool? return_string = null, bool? append = null, bool? hier = null, bool? all = null, bool? quiet = null, bool? verbose = null, string objects = null)
		{
			var command = new SimpleTCLCommand("report_switching_activity");
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
		/// Report details of Unisim primitive transformations.
		///
		/// Report the transformed primitives in the current design.
		/// As part of the process of opening the Synthesized design, and loading it into memory, the tool
		/// will transform legacy netlist primitives to the supported subset of Unisim primitives.
		/// As a default this report will be written to the standard output. However, the report can also be
		/// written to a file or returned to a Tcl string variable for further processing.
		///
		/// The following example reports the transformed primitives in the current design, and returns the
		/// result to the specified Tcl variable:
		/// set transPrim [ report_transformed_primitives -return_string ]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1437
		/// </summary>
		/// <param name="file">
		/// Optional
		/// Output file
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file
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
		public void report_transformed_primitives(string file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_transformed_primitives");
			_tcl.Add(command);
		}
		/// <summary>
		/// Compute utilization of device and display report
		///
		/// Report resource usage on the target part by the current synthesized or implemented design. The
		/// report is returned to the standard output, unless the -file, -return_string, or -name
		/// arguments are specified.
		/// TIP: Though resource usage can be reported early in the design process, the report will be more accurate as the
		/// design progresses from synthesis through implementation.
		/// This command returns the requested information, or returns an error if it fails.
		///
		/// The following example reports the resources collectively utilized by all the Pblocks in the design,
		/// and writes the results to the specified file:
		/// report_utilization -pblocks [get_pblocks] -file C:/Data/pblocks_util.txt
		/// This example reports the utilization for the whole design to the named report in the GUI, but
		/// exports the "Clocking - BUFGCTRL" table to the specified spreadsheet file:
		/// report_utilization -name utilization_1 -spreadsheet_file util_table.xlsx \
		/// -spreadsheet_table "Clocking - BUFGCTRL"
		/// The following example reports the resources utilized by each Pblock in the design, appending the
		/// report for each Pblock to a single specified file:
		/// foreach x [get_pblocks] {
		/// puts "Reporting Pblock: $x ----------------------------------"
		/// report_utilization -append -file C:/Data/pblocks_util.txt -pblocks $x
		/// }
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1439
		/// </summary>
		/// <param name="pblocks">
		/// Required
		/// Report utilization of given list of pblocks
		/// </param>
		/// <param name="cells">
		/// Required
		/// Report utilization of given list of cells
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
		/// <param name="evaluate_pblock">
		/// Optional
		/// Report utilization with demand as specified cells and supply
		/// as specified pblock area
		/// </param>
		/// <param name="exclude_child_pblocks">
		/// Optional
		/// Report utilization with out child pblocks
		/// </param>
		/// <param name="exclude_non_assigned">
		/// Optional
		/// Pblock utilization with out Non-assigned Cells
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// Return report as string
		/// </param>
		/// <param name="slr">
		/// Optional
		/// SLR wise utilization of resources
		/// </param>
		/// <param name="packthru">
		/// Optional
		/// Reports LUTs used exclusively as pack-thru
		/// </param>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name
		/// </param>
		/// <param name="no_primitives">
		/// Optional
		/// Removes "Primitives Section" from report_utilization o/p.
		/// </param>
		/// <param name="omit_locs">
		/// Optional
		/// Removes "Loced" column from report_utilization o/p.
		/// </param>
		/// <param name="hierarchical">
		/// Optional
		/// Generates text-based hierarchical report.
		/// </param>
		/// <param name="spreadsheet_file">
		/// Optional
		/// Specify file for exporting utilization tables as spreadsheets.
		/// This feature is available only in GUI mode.
		/// </param>
		/// <param name="spreadsheet_table">
		/// Optional
		/// Choose a particular utilization table to export as
		/// spreadsheet file. Default value : Hierarchy
		/// </param>
		/// <param name="spreadsheet_depth">
		/// Optional
		/// Specifies the depth level for spreadsheet. Default value : 8
		/// Default: 8
		/// </param>
		/// <param name="hierarchical_depth">
		/// Optional
		/// Specifies the depth level for textual hierarchical report
		/// Default: 0
		/// </param>
		/// <param name="hierarchical_percentages">
		/// Optional
		/// Report percentages in textual hierarchical report
		/// Name Description
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
		public void report_utilization(string pblocks, string cells, string file = null, bool? append = null, bool? evaluate_pblock = null, bool? exclude_child_pblocks = null, bool? exclude_non_assigned = null, bool? return_string = null, bool? slr = null, bool? packthru = null, string name = null, bool? no_primitives = null, bool? omit_locs = null, bool? hierarchical = null, string spreadsheet_file = null, string spreadsheet_table = null, string spreadsheet_depth = null, string hierarchical_depth = null, bool? hierarchical_percentages = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_utilization");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report status of DRC/METHODOLOGY/CDC message waivers
		///
		/// Reports DRC, METHODOLOGY, and CDC violation messages and displays what waivers are in
		/// place in the current design.
		/// In addition, the report_drc, report_methodology, and report_cdc commands have
		/// options to run the reports on waived violations or checks.
		///
		/// This example reports all waivers in the current design:
		/// report_waivers
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1446
		/// </summary>
		/// <param name="file">
		/// Optional
		/// Name of file to report waivers
		/// </param>
		/// <param name="type">
		/// Optional
		/// Type of waiver - ALL, DRC, METHODOLOGY, CDC
		/// </param>
		/// <param name="write_valid_waivers">
		/// Optional
		/// (special) Specifies writing out the specific waivers which
		/// were used in the last report_drc/methodology/cdc run(s)
		/// </param>
		/// <param name="write_ignored_waivers">
		/// Optional
		/// (special) Specifies writing out the specific waivers which
		/// were NOT used in the last report_drc/methodology/cdc
		/// run(s)
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the current report results to the file specified with -
		/// file
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// Return report results as a string object
		/// </param>
		/// <param name="show_msgs_with_no_waivers">
		/// Optional
		/// also list report_drc/methodology/cdc messages which have
		/// no defined waivers
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void report_waivers(string file = null, string type = null, bool? write_valid_waivers = null, bool? write_ignored_waivers = null, bool? append = null, bool? return_string = null, bool? show_msgs_with_no_waivers = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_waivers");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove DRC report
		///
		/// Clear the DRC results from the specified named result set.
		/// This command operates silently, returning nothing if successful, or returning an error if it fails.
		///
		/// The following example clears the specified results set from memory and the GUI:
		/// reset_drc -name DRC1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1449
		/// </summary>
		/// <param name="name">
		/// Optional
		/// DRC result name
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void reset_drc(string name = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("reset_drc");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove Methodology report
		///
		/// Clear the methodology results from the specified named result set.
		/// This command operates silently, returning nothing if successful, or returning an error if it fails.
		///
		/// The following example clears the specified results set from memory and the GUI:
		/// reset_methodology -name ultrafast_methodology_3
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1461
		/// </summary>
		/// <param name="name">
		/// Optional
		/// Methodology result name
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void reset_methodology(string name = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("reset_methodology");
			_tcl.Add(command);
		}
		/// <summary>
		/// Resets or removes a message control rule previously defined by the set_msg_config command.
		///
		/// This command restores the default settings of the message limits or severity for messages
		/// returned by the Vivado tool, or can unsuppress previously suppressed messages, as configured
		/// by the set_msg_config command.
		/// You can only perform one reset action for each reset_msg_config command. An error is
		/// returned if more than one action is attempted in a single reset_msg_config command.
		/// Message qualifiers of string, ID, and severity are used to determine which messages are reset by
		/// the reset_msg_config command. Multiple qualifiers have an AND relationship; only the
		/// messages matching the qualifiers will be reset.
		/// Note: You must supply at least one message qualifier to identify a message or group of messages to apply
		/// the command to, or an error is returned.
		/// To report the current rule configurations for messages, use the get_msg_config command.
		///
		/// The following example changes the severity of the specified message ID to a Critical Warning,
		/// and then resets the message to its default severity:
		/// set_msg_config -id "Common 17-81" -new_severity "CRITICAL WARNING"
		/// reset_msg_config -id "Common 17-81" -default_severity
		/// This example changes the severity of messages with the specified message ID, gets the current
		/// message configuration rules, and then shows two different command forms to reset the specific
		/// rule and restore the message:
		/// set_msg_config -id "Common 17-361" -severity INFO -new_severity WARNING
		/// get_msg_config -rules
		/// ---------------------
		/// Message control rules currently in effect are:
		/// Rule Name Rule Current
		/// Message Count
		/// 1 set_msg_config -ruleid {1} -id {Common 17-361} -severity {INFO} -
		/// new_severity {WARNING} 0
		/// ---------------------
		/// reset_msg_config -id "Common 17-361" -default_severity
		/// reset_msg_config -ruleid {1}
		/// TIP: In the preceding example, only one of the reset_msg_config commands is needed to reset the
		/// message.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1465
		/// </summary>
		/// <param name="string">
		/// Required
		/// A qualifier, only a rule created with a matching string
		/// qualifier will be reset/removed Default: empty
		/// </param>
		/// <param name="id">
		/// Optional
		/// A qualifier, only a rule created with a matching id qualifier
		/// will be reset/removed
		/// </param>
		/// <param name="severity">
		/// Optional
		/// A qualifier, only a rule created with a matching severity
		/// qualifier will be reset/removed
		/// </param>
		/// <param name="limit">
		/// Optional
		/// reset the limit values for message controls that match the
		/// given qualifiers for the current project
		/// </param>
		/// <param name="suppress">
		/// Optional
		/// stop suppressing messages that match the given qualifiers
		/// for the current project
		/// </param>
		/// <param name="count">
		/// Optional
		/// reset the count of messages for all message controls that
		/// match the given qualifiers for the current project. This will
		/// prevent messages from being suppressed by a -limit control
		/// until the message count once again exceeds the specified
		/// limit.
		/// </param>
		/// <param name="default_severity">
		/// Optional
		/// reset the message severity of all messages controls for the
		/// current project that match the given qualifiers to their
		/// default value
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// The values used for -string are full regular expressions
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void reset_msg_config(string string, string id = null, string severity = null, bool? limit = null, bool? suppress = null, bool? count = null, bool? default_severity = null, bool? regexp = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("reset_msg_config");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reset message count
		///
		/// Reset the message count for the specified message ID to 0. This restarts the message counter
		/// toward the specified message limit. This can be used to reset the count of specific messages that
		/// may be reaching the limit, or reset the count of all messages returned by the tool.
		/// Every message delivered by the tool has a unique global message ID that consists of an
		/// application sub-system code and a message identifier. This results in a message ID that looks like
		/// the following:
		/// "Common 17-54"
		/// "Netlist 29-28"
		/// "Synth 8-3295"
		/// You can get the current message count for a specific message ID using the get_msg_count
		/// command.
		///
		/// The following example resets the message count for all messages:
		/// reset_msg_count *
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1469
		/// </summary>
		/// <param name="id">
		/// Required
		/// Unique message Id to be reset, e.g. "Common 17-99".
		/// "reset_msg_count -id *" reset all counters
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>new message count</returns>
		public void reset_msg_count(string id, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("reset_msg_count");
			_tcl.Add(command);
		}
		/// <summary>
		/// Clear a SSN results set from memory
		///
		/// Clear the SSN results from the specified named result set.
		///
		/// The following example clears the specified results set from memory:
		/// reset_ssn SSN1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1483
		/// </summary>
		/// <param name="name">
		/// Required
		/// Name of the set of results
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void reset_ssn(string name, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("reset_ssn");
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
		/// Configure how the Vivado tool will display and manage specific messages, based on message ID,
		/// string, or severity.
		///
		/// This command lets you configure the messages returned by the Vivado tool in the current
		/// project. Use this command to change the severity of messages, to limit the number of times a
		/// message is reported, or to suppress the message altogether. However, you can only perform one
		/// of these actions at one time with set_msg_config:
		/// • Customize the severity of messages returned by the tool to specific levels appropriate to your
		/// usage. For instance, set the severity of a specified message ID from one type, such as
		/// WARNING, to another type, such as ERROR.
		/// IMPORTANT! You cannot downgrade a Vivado Design System ERROR message to make it less than an error.
		/// • Define the number of messages that will be returned by the tool during a design session, or
		/// single invocation. You can specify the limit of a specific message ID, or the limit for a specific
		/// severity of messages.
		/// TIP: The default message limit for all message IDs is set to 100, and is defined by the parameter
		/// messaging.defaultLimit. This is the limit applied to each separate message returned by the tool. You
		/// can report the current value of this parameter with the get_param command, and change it as needed using
		/// the set_param command.
		/// • Suppress a specific message ID from being reported by the tool at all. You can enable
		/// messages that were previously suppressed using the reset_msg_config command.
		/// • An error is returned if more than one action is attempted in a single set_msg_config
		/// command.
		/// Message qualifiers of string, ID, and severity are used to determine which messages are
		/// configured by the set_msg_config command. You must supply at least one message qualifier
		/// to identify a message or group of messages to apply the command to. Multiple qualifiers have an
		/// AND relationship; the configuration rule will be applied only to messages matching all qualifiers.
		/// TIP: set_msg_config does not support the use of wildcards in message qualifiers.
		/// Message configuration rules are project specific, and are persistent with the project when the
		/// project is closed and reopened.
		/// IMPORTANT! Message configuration rules apply to the current project and are passed automatically to
		/// subordinate processes, such as synthesis and implementation runs. Do not use set_msg_config in pre and
		/// post Tcl scripts.
		/// Use the get_msg_config command to report the current configuration of a specific message,
		/// or the configuration rules defined in the current project. Restore messages to their default
		/// configurations using the reset_msg_config command.
		/// The set_msg_config command is not supported by report_cdc as that command does not
		/// generate messages through the message manager.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example elevates a common INFO message to a Critical Warning:
		/// set_msg_config -id {[Common 17-81]} -new_severity "CRITICAL WARNING"
		/// IMPORTANT! In the following example the "Common 17-69" message is an ERROR message, and cannot be
		/// downgraded from an ERROR. The command in this example appears to work when run from the Tcl console,
		/// however it will not result in any change.
		/// set_msg_config -id {[Common 17-69]} -new_severity WARNING
		/// When the "Common 17-69" message is next thrown by the Vivado tool, a warning message is returned stating
		/// that an error cannot be downgraded, and the message is thrown as an ERROR:
		/// WARNING: [Common 17-239] ERROR Messages are prohibited to be downgraded.
		/// Message 'Common 17-69' is not downgraded.
		/// ERROR: [Common 17-69] Command failed: report_design_analysis
		/// -critical_paths can be run only after synthesis has successfully
		/// completed.
		/// The following example results in warning messages with message ID "17-35", and containing "clk"
		/// in the message, being redefined as Error messages:
		/// set_msg_config -severity warning -string "clk" -id "17-35" \
		/// -new_severity error
		/// This example changes the severity of messages with the specified message ID, gets the current
		/// message configuration rules, and then shows two different command forms to reset the specific
		/// rule and restore the message:
		/// set_msg_config -id "Common 17-361" -severity INFO -new_severity WARNING
		/// get_msg_config -rules
		/// ---------------------
		/// Message control rules currently in effect are:
		/// Rule Name Rule Current
		/// Message Count
		/// 1 set_msg_config -ruleid {1} -id {Common 17-361} -severity {INFO} -
		/// new_severity {WARNING} 0
		/// ---------------------
		/// reset_msg_config -id "Common 17-361" -default_severity
		/// reset_msg_config -ruleid {1}
		/// TIP: In the preceding example, only one of the reset_msg_config commands is needed to reset the
		/// message.
		/// This example shows the use of a parameter to change the default message limit, and then defines
		/// a new limit for the specified message id:
		/// get_param messaging.defaultLimit
		/// 100
		/// set_param messaging.defaultLimit 1000
		/// set_msg_config -id {[Common 17-81]} -limit 1500
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1619
		/// </summary>
		/// <param name="string">
		/// Required
		/// A qualifier, apply the selected operation only to messages
		/// that contain the given list of strings. Default: none
		/// </param>
		/// <param name="id">
		/// Optional
		/// A qualifier, apply the selected operation only to messages
		/// that match given message id. Example: '-id {Common
		/// 17-35}'. Default: match any id
		/// </param>
		/// <param name="severity">
		/// Optional
		/// A qualifier, apply the selected operation only to messages at
		/// the given severity level. Example: '-severity INFO' Default:
		/// match any severity
		/// </param>
		/// <param name="limit">
		/// Optional
		/// for the messages that match the qualifiers, limit the number
		/// of messages displayed to the given integer value. Can only
		/// be used in conjunction with one of -id or -severity.
		/// </param>
		/// <param name="new_severity">
		/// Optional
		/// for the messages that match the qualifiers, change the
		/// severity to the given value for the current project
		/// </param>
		/// <param name="suppress">
		/// Optional
		/// for the messages that match the qualifiers, suppress (do not
		/// display) any messages for the current project
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// The values used for -string are full regular expressions
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void set_msg_config(string string, string id = null, string severity = null, string limit = null, string new_severity = null, bool? suppress = null, bool? regexp = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("set_msg_config");
			_tcl.Add(command);
		}
		/// <summary>
		/// Returns the build for Vivado and the build date
		///
		/// Returns the version number of the Xilinx® tool. This includes the software version number, build
		/// number and date, and copyright information.
		///
		/// The following example returns only the version number for the software:
		/// version -short
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1769
		/// </summary>
		/// <param name="short">
		/// Optional
		/// Return only the numeric version number
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>
		/// </returns>
		public void version(bool? short = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("version");
			_tcl.Add(command);
		}
	}
}
