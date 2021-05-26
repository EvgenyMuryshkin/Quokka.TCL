#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class DRCCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public DRCCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// <para>
		/// Add DRC rule check objects to a rule deck<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: add_drc_checks [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] -ruledeck &lt;arg&gt; [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Add design rule checks to the specified drc_ruledeck object.<br/>
		/// A rule deck is a collection of design rule checks grouped for convenience, to be run with the<br/>
		/// report_drc command at different stages of the Xilinx design flow, such as during I/O planning<br/>
		/// or placement. The tool comes with a set of factory defined rule decks, but you can also create<br/>
		/// new user-defined rule decks with the create_drc_ruledeck command.<br/>
		/// Use the get_drc_ruledecks command to return a list of the currently defined rule decks<br/>
		/// available for use in the report_drc command.<br/>
		/// You can add standard factory defined rule checks to the rule deck, or add user-defined rule<br/>
		/// checks that were created using the create_drc_check command. Use the get_drc_checks<br/>
		/// command to get a list of checks that can be added to a rule deck.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Checks can also be removed from a rule deck using the remove_drc_checks command.<br/>
		/// Note: To temporarily disable a specific DRC rule, use the set_property command to set the<br/>
		/// IS_ENABLED property for the rule to false. This will disable the rule from being run in report_drc,<br/>
		/// without having to remove the rule from the rule deck. Use reset_drc_check to restore the rule to its<br/>
		/// default setting.<br/>
		/// This command returns the list of design rule checks that were added to the rule deck.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example adds the rule checks matching the specified search pattern to the<br/>
		/// project_rules rule deck:<br/>
		/// add_drc_checks -ruledeck project_rules {*DCI* *BUF*}<br/>
		/// The following example creates a new rule deck called placer+, copies all of the rule checks from<br/>
		/// the placer_checks rule deck into the placer+ rule deck, then adds some additional checks:<br/>
		/// create_drc_ruledeck placer+<br/>
		/// add_drc_checks -of_objects [get_drc_ruledecks placer_checks] \<br/>
		/// -ruledeck placer+<br/>
		/// add_drc_checks -ruledeck placer+ *IO*<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example adds only the rule checks with a severity of Warning to the rule deck:<br/>
		/// add_drc_checks -filter {SEVERITY == Warning} -ruledeck warn_only<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 40<br/>
		/// </para>
		/// </summary>
		/// <param name="ruledeck">(Required) DRC rule deck to modify</param>
		/// <param name="of_objects">(Optional) Get 'rule_check' objects of these types: 'drc_ruledeck'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'rule_check' objects against patterns. Default: *</param>
		/// <returns>drc_check</returns>
		public TTCL add_drc_checks(String ruledeck, TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: add_drc_checks [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] -ruledeck <arg> [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.add_drc_checks(ruledeck, of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a user defined DRC rule<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_drc_check [-hiername &lt;arg&gt;] -name &lt;arg&gt; [-desc &lt;arg&gt;] [-msg &lt;arg&gt;] -rule_body &lt;arg&gt; [-severity &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Create a new user-defined DRC rule check, drc_check, for use by the tool when running<br/>
		/// report_drc.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command allows you to define a unique name or abbreviation for the user-defined rule<br/>
		/// check, optionally group the rule into a special hierarchy and provide a description of the rule,<br/>
		/// define a general placeholder message for the check when violations are encountered, and refer<br/>
		/// to the Tcl code associated with the design rule check to be run during the report_drc<br/>
		/// command.<br/>
		/// The general placeholder message defined in this command is populated with specific information<br/>
		/// related to the design objects and violations found by the Tcl checker procedure, and by the<br/>
		/// create_drc_violation command.<br/>
		/// The process in brief is:<br/>
		/// • Write a Tcl checker procedure to define the method applied when checking the user-defined<br/>
		/// rule, and the objects to check against the rule. The Tcl checker procedure is defined in a<br/>
		/// separate Tcl script that must be loaded by the source command prior to running<br/>
		/// report_drc.<br/>
		/// • Use create_drc_violation in the Tcl checker to identify and flag violations found when<br/>
		/// checking the rule against a design.<br/>
		/// • Define a user-defined DRC rule check using the create_drc_check command that calls the<br/>
		/// Tcl checker proc from the -rule_body.<br/>
		/// • Create a rule deck using the create_drc_ruledeck command, and add the user-defined<br/>
		/// rule check to the rule deck using the add_drc_checks command.<br/>
		/// • Run report_drc, and specify either the rule deck, or the user-defined rule check to check<br/>
		/// for violations.<br/>
		/// If a drc_check of the specified name is already defined in the tool, an error is returned. In this<br/>
		/// case, to overwrite or redefine and existing drc_check, you must first delete the check using the<br/>
		/// delete_drc_check command.<br/>
		/// The DRC rule check object features the is_enabled property that can be set to TRUE or<br/>
		/// FALSE using the set_property command. When a new rule check is created, the<br/>
		/// is_enabled property is set to TRUE as a default. Set the is_enabled property to FALSE to<br/>
		/// disable the rule check from being used when report_drc is run. This lets you create new DRC<br/>
		/// checks, add them to rule decks using add_drc_checks, and then enable them or disable them<br/>
		/// as needed without having to remove them from the rule deck.<br/>
		/// Each user defined DRC rule check has the 'USER_DEFINED' property, which lets you quickly<br/>
		/// identify and select user-defined rule checks.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example defines a new design rule check named RAMW-1, with the hierarchy<br/>
		/// name and description defined, using the default severity of Warning, and calling the<br/>
		/// dataWidthCheck procedure when the check is run:<br/>
		/// create_drc_check -name {RAMW-1} -hiername {RAMB} \<br/>
		/// -desc {Data Width Check} -rule_body dataWidthCheck -severity Advisory<br/>
		/// The following Tcl script defines the dataWidthCheck procedure which is called by the -<br/>
		/// rule_body argument of the RAMW-1 check. This Tcl script file must be loaded into the tool<br/>
		/// using the source command, prior to running the report_drc command.<br/>
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
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: The script file can contain both the Tcl checker procedure, and the create_drc_check command<br/>
		/// that defines it for use by report_drc command. In this case, when the Tcl script file is sourced, both the<br/>
		/// dataWidthCheck proc and the RAMW-1 design rule check are loaded into the tool.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 261<br/>
		/// </para>
		/// </summary>
		/// <param name="name">
		/// <para>
		/// (Required)<br/>
		/// Specify the name for this rule. This must be of the form<br/>
		/// PREFIX-id where XXXX is a 4-6 letter abbreviation and id is an<br/>
		/// integer identifying a particular rule. Similar checks should<br/>
		/// have the same abbreviation and each a unique id.<br/>
		/// </para>
		/// </param>
		/// <param name="rule_body">
		/// <para>
		/// (Required)<br/>
		/// The string representing the body of the rule. This can be a<br/>
		/// tcl proc name or any string of tcl code to be evaluated.<br/>
		/// </para>
		/// </param>
		/// <param name="hiername">
		/// <para>
		/// (Optional)<br/>
		/// Specify the hiername for this rule. When the DRC UI panel is<br/>
		/// created, this is used to place the new rule in the menu<br/>
		/// hierarchy. Use a dot (.) to separate layers in the menu<br/>
		/// hierarchy. It is optional and will default to User Defined.<br/>
		/// Default: User Defined<br/>
		/// </para>
		/// </param>
		/// <param name="desc">
		/// <para>
		/// (Optional)<br/>
		/// Specify the short description for this rule. It is optional and<br/>
		/// will default to &lt;User rule - default description&gt;. Default:<br/>
		/// User rule - default description<br/>
		/// </para>
		/// </param>
		/// <param name="msg">
		/// <para>
		/// (Optional)<br/>
		/// Specify the full description for this rule. Including the<br/>
		/// substitutions. Values are: %MSG_STRING<br/>
		/// %NETLIST_ELEMENT %SITE_GROUP %CLOCK_REGION<br/>
		/// %BANK %BEL_GROUP.<br/>
		/// </para>
		/// </param>
		/// <param name="severity">
		/// <para>
		/// (Optional)<br/>
		/// Specify severity level for a DRC rule. Default: Warning.<br/>
		/// Values: Error, Critical Warning, Warning, Advisory.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_drc_check(String name, String rule_body, String hiername = null, String desc = null, String msg = null, create_drc_check_severity? severity = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_drc_check [-hiername <arg>] -name <arg> [-desc <arg>] [-msg <arg>] -rule_body <arg> [-severity <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_drc_check(name, rule_body, hiername, desc, msg, severity, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create one or more user defined DRC rule deck objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_drc_ruledeck [-quiet] [-verbose] &lt;ruledecks&gt;...
		/// <br/>
		/// <para>
		/// Create one or more user-defined rule decks for use when running report_drc.<br/>
		/// A drc_ruledeck object is a collection of design rule checks, grouped for convenience, to be run at<br/>
		/// different stages of the FPGA design flow, such as during I/O planning or placement. The tool<br/>
		/// comes with a set of factory predefined rule decks. Use the get_drc_ruledecks command to<br/>
		/// return a list of the currently defined rule decks.<br/>
		/// The rule decks created by this command are empty, without any checks. You must add design<br/>
		/// rule checks to the rule deck using the add_drc_checks command. Checks can be removed<br/>
		/// from a rule deck using the remove_drc_checks command. To see a list of design rule checks<br/>
		/// that are available to include in the ruledeck, use the get_drc_checks command.<br/>
		/// This command returns the list of drc_ruledecks created.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates two new drc_ruledeck objects:<br/>
		/// create_drc_ruledeck my_rules project_rules<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 266<br/>
		/// </para>
		/// </summary>
		/// <param name="ruledecks">(Required) Names of DRC rule decks to create</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>drc_ruledeck</returns>
		public TTCL create_drc_ruledeck(TCLObjectList ruledecks, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_drc_ruledeck [-quiet] [-verbose] <ruledecks>...
			_tcl.Entry(_builder.create_drc_ruledeck(ruledecks, quiet, verbose));
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
		public TTCL create_drc_violation(String name, create_drc_violation_severity? severity = null, String msg = null, bool? quiet = null, bool? verbose = null, TCLObjectList objects = null)
		{
			// TCL Syntax: create_drc_violation -name <arg> [-severity <arg>] [-msg <arg>] [-quiet] [-verbose] [<objects>...]
			_tcl.Entry(_builder.create_drc_violation(name, severity, msg, quiet, verbose, objects));
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
		/// Delete one or more user-defined DRC checks.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_drc_check [-quiet] [-verbose] &lt;name&gt;...
		/// <br/>
		/// <para>
		/// Delete a single user-defined design rule check from the current project. User-defined design rule<br/>
		/// checks are created using the create_drc_checks command.<br/>
		/// Note: You cannot delete factory defined rule checks.<br/>
		/// Once it has been deleted there is no way to recover a rule check. The undo command will not<br/>
		/// work.<br/>
		/// Note: This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example deletes the specified design rule check:<br/>
		/// delete_drc_check LJH-1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 438<br/>
		/// </para>
		/// </summary>
		/// <param name="name">
		/// <para>
		/// (Required)<br/>
		/// Specify the key for the check to remove. This is the typically<br/>
		/// of the form PREFIX-id where PREFIX is a 4-6 letter<br/>
		/// abbreviation and id is a unique identifier. Use<br/>
		/// get_drc_checks to determine the correct name to use. Only<br/>
		/// user-defined DRC checks may be deleted.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_drc_check(TCLObjectList name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_drc_check [-quiet] [-verbose] <name>...
			_tcl.Entry(_builder.delete_drc_check(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Delete one or more user defined DRC rule deck objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_drc_ruledeck [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Delete one or more user-defined drc_ruledeck objects from the current project. The rule deck<br/>
		/// does not have to be empty to be deleted, and once it is deleted there is no way to recover it. The<br/>
		/// undo command will not restore a deleted rule deck.<br/>
		/// Note: You cannot delete factory defined rule decks.<br/>
		/// A rule deck is a collection of design rule checks grouped for convenience, to be run with the<br/>
		/// report_drc command at different stages of the FPGA design flow, such as during I/O planning<br/>
		/// or placement. The tool comes with a set of factory defined rule decks, but you can also create<br/>
		/// new user-defined rule decks with the create_drc_ruledeck command.<br/>
		/// Note: This command returns nothing if successful, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example deletes all user-defined rule decks from the current project:<br/>
		/// delete_drc_ruledeck<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 440<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'drc_ruledeck' objects against patterns. Default: *</param>
		/// <returns>drc_ruledeck</returns>
		public TTCL delete_drc_ruledeck(bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: delete_drc_ruledeck [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.delete_drc_ruledeck(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of DRC rule check objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_drc_checks [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-abbrev &lt;arg&gt;] [-ruledecks &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of the currently defined DRC checks. This list includes both factory defined design rule<br/>
		/// checks, and user-defined checks created by the create_drc_check command.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following command gets a list of all AVAL design rule checks:<br/>
		/// get_drc_checks AVAL*<br/>
		/// The following example gets the checks associated with the specified rule deck:<br/>
		/// get_drc_checks -of_objects [get_drc_ruledecks placer_checks]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 678<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'rule_check' objects of these types: 'drc_ruledeck'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="abbrev">(Optional) Get the largest ID for this abbrev</param>
		/// <param name="ruledecks">(Optional) Containers of Report DRC rule checks Default: default</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'rule_check' objects against patterns. Default: *</param>
		/// <returns>list of DRC rule_check objects</returns>
		public TTCL get_drc_checks(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, String abbrev = null, TCLParameterList ruledecks = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_drc_checks [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-abbrev <arg>] [-ruledecks <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_drc_checks(of_objects, regexp, nocase, filter, abbrev, ruledecks, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of DRC rule deck objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_drc_ruledecks [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of currently defined rule decks for use with the report_drc command.<br/>
		/// A rule deck is a collection of design rule checks grouped for convenience, to be run at different<br/>
		/// stages of the FPGA design flow, such as during I/O planning or placement. The tool comes with a<br/>
		/// set of factory defined rule decks, but you can also create new user-defined rule decks with the<br/>
		/// create_drc_ruledeck command, and add checks to the rule deck using the<br/>
		/// add_drc_checks command.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of rule decks defined in the current project:<br/>
		/// get_drc_ruledecks<br/>
		/// The following example lists each of the checks associated with the placer_checks rule deck on a<br/>
		/// separate line:<br/>
		/// foreach rule [get_drc_checks -of_objects \<br/>
		/// [get_drc_ruledecks placer_checks]] {puts $rule}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 681<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'drc_ruledeck' objects of these types: 'rule_check'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'drc_ruledeck' objects against patterns. Default: *</param>
		/// <returns>drc_ruledeck</returns>
		public TTCL get_drc_ruledecks(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_drc_ruledecks [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_drc_ruledecks(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of DRC violations from a previous report_drc run<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_drc_violations [-name &lt;arg&gt;] [-regexp] [-filter &lt;arg&gt;] [-nocase] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of violation objects found in the design when the report_drc command is run.<br/>
		/// Violation objects are created at the time DRC is run, either by the internal design rule checks<br/>
		/// provided by the Vivado tools, or created by the create_drc_violation command in user-defined DRC checks. The properties of individual violation objects can be queried using<br/>
		/// report_property or list_property commands for details of the violation.<br/>
		/// Violation objects are associated with the cells, nets, pins, or ports in the current design, or sites<br/>
		/// on the current device. The design objects associated with a DRC violation object can be obtained<br/>
		/// using the -of_objects option of the appropriate get_* command, such as get_cells, or<br/>
		/// get_nets for instance.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the DRC violations found in the current design, then returns a list<br/>
		/// of all those violations:<br/>
		/// report_drc<br/>
		/// get_drc_violations<br/>
		/// The following example gets the properties of the specified DRC violation:<br/>
		/// report_property [lindex [get_drc_violations] 0]<br/>
		/// The following example returns the list of violations in the specified DRC report of the current<br/>
		/// design, and then returns the ports associated with any violations of the unspecified I/O Standard<br/>
		/// rule (NSTD):<br/>
		/// get_drc_violations -name drc_1<br/>
		/// get_ports -of_objects [get_drc_violations -name drc_1 NSTD*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 684<br/>
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
		/// Match drc_violations against patterns Default: * Values: The<br/>
		/// default search pattern is the wildcard *, or .* when -regexp<br/>
		/// is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of DRC violation objects</returns>
		public TTCL get_drc_violations(String name = null, bool? regexp = null, String filter = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_drc_violations [-name <arg>] [-regexp] [-filter <arg>] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_drc_violations(name, regexp, filter, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove DRC rule check objects from a user rule deck<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_drc_checks [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] -ruledeck &lt;arg&gt; [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Remove the specified design rule checks from a drc_ruledeck object.<br/>
		/// A rule deck is a collection of design rule checks grouped for convenience, to be run with the<br/>
		/// report_drc command at different stages of the FPGA design flow, such as during I/O planning<br/>
		/// or placement. The tool comes with a set of factory defined rule decks, but you can also create<br/>
		/// new user-defined rule decks with the create_drc_ruledeck command.<br/>
		/// Checks are added to a rule deck using the add_drc_checks command.<br/>
		/// The DRC rule check object features the IS_ENABLED property that can be set to true or false<br/>
		/// using the set_property command. When a new rule check is created, the IS_ENABLED<br/>
		/// property is set to true as a default. Set the IS_ENABLED property to false to disable the rule<br/>
		/// check from being used by report_drc without having to remove the rule from the rule deck.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// TIP: Use the reset_drc_check command to restore the DRC rule, and its properties, to the default<br/>
		/// settings.<br/>
		/// This command returns the list of design rule checks that were removed from the specified rule<br/>
		/// deck.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example removes the rule checks matching the specified filter pattern from the<br/>
		/// my_rules rule deck:<br/>
		/// remove_drc_checks -filter {GROUP == AVAL} -ruledeck my_rules<br/>
		/// The following example disables the specified DRC check without removing it from the rule deck:<br/>
		/// set_property IS_ENABLED FALSE [get_drc_checks RAMW-1]<br/>
		/// The following example removes all rule checks from the specified rule deck:<br/>
		/// remove_drc_checks -ruledeck my_rules<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1243<br/>
		/// </para>
		/// </summary>
		/// <param name="ruledeck">(Required) DRC rule deck to modify</param>
		/// <param name="of_objects">(Optional) Get 'rule_check' objects of these types: 'drc_ruledeck'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'rule_check' objects against patterns. Default: *</param>
		/// <returns>drc_check</returns>
		public TTCL remove_drc_checks(String ruledeck, TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: remove_drc_checks [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] -ruledeck <arg> [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.remove_drc_checks(ruledeck, of_objects, regexp, nocase, filter, quiet, verbose, patterns));
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
		/// Reset one or more DRC checks to factory defaults.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_drc_check [-quiet] [-verbose] [&lt;checks&gt;...]
		/// <br/>
		/// <para>
		/// Reset the specified DRC checks to the defaults provided by the Vivado Design Suite. This will<br/>
		/// restore the DRC check to its default configuration, including any changes to the IS_ENABLED or<br/>
		/// SEVERITY properties.<br/>
		/// The IS_ENABLED property can be modified on a specific DRC check to disable the rule from<br/>
		/// being checked, even when it is specified either directly in the report_drc command, or as part<br/>
		/// of a ruledeck.<br/>
		/// The SEVERITY property is a string property that can be modified to change the severity<br/>
		/// associated with a specific DRC rule when a violation is found during the report_drc command.<br/>
		/// The supported values are: FATAL, ERROR, "CRITICAL WARNING", WARNING, ADVISORY<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example modifies the IS_ENABLED property for the ROAS-1 rule, modifies the<br/>
		/// SEVERITY property for the RFFC-1 rule, and then restores the default settings for all checks:<br/>
		/// set_property IS_ENABLED false [get_drc_checks ROAS-1]<br/>
		/// set_property SEVERITY "Critical Warning" [get_drc_checks RFFC-1]<br/>
		/// reset_drc_check [get_drc_checks]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1482<br/>
		/// </para>
		/// </summary>
		/// <param name="checks">(Required) The list of checks to reset.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_drc_check(TCLObjectList checks, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_drc_check [-quiet] [-verbose] [<checks>...]
			_tcl.Entry(_builder.reset_drc_check(checks, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
