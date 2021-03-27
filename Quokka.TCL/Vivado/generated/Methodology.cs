// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class MethodologyCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public MethodologyCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
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
		public TTCL create_waiver(string description, string type = null, string id = null, TCLParameterList objects = null, TCLParameterList from = null, TCLParameterList to = null, TCLParameterList strings = null, TCLParameterList of_objects = null, string user = null, string tags = null, string timestamp = null, bool? scoped = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_waiver [-type <arg>] [-id <arg>] [-objects <args>] [-from <args>] [-to <args>] [-strings <args>] [-of_objects <args>] [-user <arg>] -description <arg> [-tags <arg>] [-timestamp <arg>] [-scoped] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_waiver(description, type, id, objects, from, to, strings, of_objects, user, tags, timestamp, scoped, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of Methodology rule check objects
		///
		///
		/// TCL Syntax: get_methodology_checks [-regexp] [-nocase] [-filter <arg>] [-abbrev <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of the currently defined methodology checks. This list includes the factory defined
		/// methodology checks for process and timing.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following command gets a list of all synthesis methodology checks:
		/// get_methodology_checks SYNTH*
		///
		/// See ug835-vivado-tcl-commands.pdf, page 829
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="abbrev">(Optional) Get the largest ID for this abbrev</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'rule_check' objects against patterns. Default: *</param>
		/// <returns>list of Methodology rule_check objects</returns>
		public TTCL get_methodology_checks(bool? regexp = null, bool? nocase = null, string filter = null, string abbrev = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_methodology_checks [-regexp] [-nocase] [-filter <arg>] [-abbrev <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_methodology_checks(regexp, nocase, filter, abbrev, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of Methodology violations from a previous report_methodology run
		///
		///
		/// TCL Syntax: get_methodology_violations [-name <arg>] [-regexp] [-filter <arg>] [-nocase] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of violation objects found in the design when the report_methodology command
		/// is run. The properties of individual violation objects can be queried using report_property or
		/// list_property commands for details of the violation.
		/// Violation objects are associated with the cells, nets, pins, or ports in the current design, or sites
		/// on the current device. The design objects associated with a methodology violation object can be
		/// obtained using the -of_objects option of the appropriate get_* command, such as
		/// get_cells, or get_nets for instance.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example reports the methodology violations found in the current design, then
		/// returns a list of all those violations:
		/// report_methodology
		/// get_methodology_violations
		/// The following example generates list of violations in the named methodology report, and then
		/// gets the pins associated with any violations found:
		/// report_methodology -name method_1
		/// get_pins -of_objects [get_methodology_violations -name method_1]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 832
		/// </summary>
		/// <param name="name">(Optional) Get the results with this name</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// Match methodology_violations against patterns Default: *
		/// Values: The default search pattern is the wildcard *, or .*
		/// when -regexp is specified.
		/// </param>
		/// <returns>list of Methodology violation objects</returns>
		public TTCL get_methodology_violations(string name = null, bool? regexp = null, string filter = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_methodology_violations [-name <arg>] [-regexp] [-filter <arg>] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_methodology_violations(name, regexp, filter, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Methodology Checks
		///
		///
		/// TCL Syntax: report_methodology [-name <arg>] [-cells <args>] [-checks <args>] [-file <arg>] [-rpx <arg>] [-append] [-waived] [-no_waivers] [-slack_lesser_than <arg>] [-return_string] [-quiet] [-verbose]
		///
		/// Check the current design against a specified set of methodology checks and report any errors or
		/// violations that are found.
		/// Methodology checks are a special class of design rule checks (DRC) that are accessible through
		/// this separate Tcl command. The methodology checks are a necessary part of the design flow, and
		/// should be considered mandatory after implementation and prior to generating the bitstream.
		/// TIP: Other than their availability through the separate report_methodology command, the checks
		/// are standard design rule checks in every other way.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
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
		/// See ug835-vivado-tcl-commands.pdf, page 1389
		/// </summary>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="cells">(Optional) Run report_methodology on the specified cell(s).</param>
		/// <param name="checks">
		/// (Optional)
		/// Report Methodology checks (see get_methodology_checks
		/// for available checks)
		/// </param>
		/// <param name="file">
		/// (Optional)
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="rpx">(Optional) Report filename for persisted results.</param>
		/// <param name="append">(Optional) Append the results to file, do not overwrite the results file</param>
		/// <param name="waived">(Optional) Output result is Waived checks</param>
		/// <param name="no_waivers">(Optional) Disable waivers for checks</param>
		/// <param name="slack_lesser_than">(Optional) Set SYNTH rules Slack Threshold value in 'ns' (float) Default: 2.0</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_methodology(string name = null, TCLParameterList cells = null, TCLParameterList checks = null, string file = null, string rpx = null, bool? append = null, bool? waived = null, bool? no_waivers = null, string slack_lesser_than = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_methodology [-name <arg>] [-cells <args>] [-checks <args>] [-file <arg>] [-rpx <arg>] [-append] [-waived] [-no_waivers] [-slack_lesser_than <arg>] [-return_string] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_methodology(name, cells, checks, file, rpx, append, waived, no_waivers, slack_lesser_than, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Remove Methodology report
		///
		///
		/// TCL Syntax: reset_methodology [-name <arg>] [-quiet] [-verbose]
		///
		/// Clear the methodology results from the specified named result set.
		/// This command operates silently, returning nothing if successful, or returning an error if it fails.
		///
		/// The following example clears the specified results set from memory and the GUI:
		/// reset_methodology -name ultrafast_methodology_3
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1494
		/// </summary>
		/// <param name="name">(Optional) Methodology result name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_methodology(string name = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_methodology [-name <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.reset_methodology(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Reset one or more Methodology checks to factory defaults.
		///
		///
		/// TCL Syntax: reset_methodology_check [-quiet] [-verbose] [<checks>...]
		///
		/// Reset the specified methodology checks to the defaults provided by the Vivado Design Suite.
		/// This will restore the check to its default configuration, including any changes to the IS_ENABLED
		/// or SEVERITY properties.
		/// The IS_ENABLED property can be modified on a specific methodology check to disable the rule
		/// from being checked, even when it is specified directly in the report_methodology command.
		/// The SEVERITY property is an enumerated property that can be modified to change the severity
		/// associated with a specific methodology check when a violation is found during the
		/// report_methodology command. The supported values are: FATAL, ERROR, "CRITICAL
		/// WARNING", WARNING, ADVISORY
		///
		/// The following example modifies the IS_ENABLED and SEVERITY properties for the CHECK-4
		/// methodology check, reports the properties of the check to see the changes, and then resets the
		/// methodology check to its default setting:
		/// set_property IS_ENABLED false [get_methodology_checks CHECK-4]
		/// set_property SEVERITY Warning [get_methodology_checks CHECK-4]
		/// report_property [get_methodology_checks CHECK-4]
		/// reset_methodology_check [get_methodology_checks CHECK-4]
		/// report_property [get_methodology_checks CHECK-4]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1496
		/// </summary>
		/// <param name="checks">(Required) The list of checks to reset.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_methodology_check(TCLParameterList checks, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_methodology_check [-quiet] [-verbose] [<checks>...]
			_tcl.Entry(_builder.reset_methodology_check(checks, quiet, verbose));
			return _tcl;
		}
	}
}
