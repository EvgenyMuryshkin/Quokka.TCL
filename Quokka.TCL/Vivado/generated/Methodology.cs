#pragma warning disable IDE1006 // Naming Styles
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
		/// Get a list of Methodology rule check objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_methodology_checks [-regexp] [-nocase] [-filter &lt;arg&gt;] [-abbrev &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of the currently defined methodology checks. This list includes the factory defined<br/>
		/// methodology checks for process and timing.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following command gets a list of all synthesis methodology checks:<br/>
		/// get_methodology_checks SYNTH*<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 829<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="abbrev">(Optional) Get the largest ID for this abbrev</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'rule_check' objects against patterns. Default: *</param>
		/// <returns>list of Methodology rule_check objects</returns>
		public TTCL get_methodology_checks(bool? regexp = null, bool? nocase = null, String filter = null, String abbrev = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_methodology_checks [-regexp] [-nocase] [-filter <arg>] [-abbrev <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_methodology_checks(regexp, nocase, filter, abbrev, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of Methodology violations from a previous report_methodology run<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_methodology_violations [-name &lt;arg&gt;] [-regexp] [-filter &lt;arg&gt;] [-nocase] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of violation objects found in the design when the report_methodology command<br/>
		/// is run. The properties of individual violation objects can be queried using report_property or<br/>
		/// list_property commands for details of the violation.<br/>
		/// Violation objects are associated with the cells, nets, pins, or ports in the current design, or sites<br/>
		/// on the current device. The design objects associated with a methodology violation object can be<br/>
		/// obtained using the -of_objects option of the appropriate get_* command, such as<br/>
		/// get_cells, or get_nets for instance.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the methodology violations found in the current design, then<br/>
		/// returns a list of all those violations:<br/>
		/// report_methodology<br/>
		/// get_methodology_violations<br/>
		/// The following example generates list of violations in the named methodology report, and then<br/>
		/// gets the pins associated with any violations found:<br/>
		/// report_methodology -name method_1<br/>
		/// get_pins -of_objects [get_methodology_violations -name method_1]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 832<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Optional) Get the results with this name</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Match methodology_violations against patterns Default: *<br/>
		/// Values: The default search pattern is the wildcard *, or .*<br/>
		/// when -regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of Methodology violation objects</returns>
		public TTCL get_methodology_violations(String name = null, bool? regexp = null, String filter = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_methodology_violations [-name <arg>] [-regexp] [-filter <arg>] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_methodology_violations(name, regexp, filter, nocase, quiet, verbose, patterns));
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
		/// Reset one or more Methodology checks to factory defaults.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_methodology_check [-quiet] [-verbose] [&lt;checks&gt;...]
		/// <br/>
		/// <para>
		/// Reset the specified methodology checks to the defaults provided by the Vivado Design Suite.<br/>
		/// This will restore the check to its default configuration, including any changes to the IS_ENABLED<br/>
		/// or SEVERITY properties.<br/>
		/// The IS_ENABLED property can be modified on a specific methodology check to disable the rule<br/>
		/// from being checked, even when it is specified directly in the report_methodology command.<br/>
		/// The SEVERITY property is an enumerated property that can be modified to change the severity<br/>
		/// associated with a specific methodology check when a violation is found during the<br/>
		/// report_methodology command. The supported values are: FATAL, ERROR, "CRITICAL<br/>
		/// WARNING", WARNING, ADVISORY<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example modifies the IS_ENABLED and SEVERITY properties for the CHECK-4<br/>
		/// methodology check, reports the properties of the check to see the changes, and then resets the<br/>
		/// methodology check to its default setting:<br/>
		/// set_property IS_ENABLED false [get_methodology_checks CHECK-4]<br/>
		/// set_property SEVERITY Warning [get_methodology_checks CHECK-4]<br/>
		/// report_property [get_methodology_checks CHECK-4]<br/>
		/// reset_methodology_check [get_methodology_checks CHECK-4]<br/>
		/// report_property [get_methodology_checks CHECK-4]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1496<br/>
		/// </para>
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
#pragma warning restore IDE1006 // Naming Styles
