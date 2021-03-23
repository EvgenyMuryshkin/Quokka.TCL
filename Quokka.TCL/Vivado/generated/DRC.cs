// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
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
		/// Add DRC rule check objects to a rule deck
		///
		///
		/// TCL Syntax: add_drc_checks [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] -ruledeck <arg> [-quiet] [-verbose] [<patterns>]
		///
		/// Add design rule checks to the specified drc_ruledeck object.
		/// A rule deck is a collection of design rule checks grouped for convenience, to be run with the
		/// report_drc command at different stages of the Xilinx design flow, such as during I/O planning
		/// or placement. The tool comes with a set of factory defined rule decks, but you can also create
		/// new user-defined rule decks with the create_drc_ruledeck command.
		/// Use the get_drc_ruledecks command to return a list of the currently defined rule decks
		/// available for use in the report_drc command.
		/// You can add standard factory defined rule checks to the rule deck, or add user-defined rule
		/// checks that were created using the create_drc_check command. Use the get_drc_checks
		/// command to get a list of checks that can be added to a rule deck.
		/// Checks can also be removed from a rule deck using the remove_drc_checks command.
		/// Note: To temporarily disable a specific DRC rule, use the set_property command to set the
		/// IS_ENABLED property for the rule to false. This will disable the rule from being run in report_drc,
		/// without having to remove the rule from the rule deck. Use reset_drc_check to restore the rule to its
		/// default setting.
		/// This command returns the list of design rule checks that were added to the rule deck.
		///
		/// The following example adds the rule checks matching the specified search pattern to the
		/// project_rules rule deck:
		/// add_drc_checks -ruledeck project_rules {*DCI* *BUF*}
		/// The following example creates a new rule deck called placer+, copies all of the rule checks from
		/// the placer_checks rule deck into the placer+ rule deck, then adds some additional checks:
		/// create_drc_ruledeck placer+
		/// add_drc_checks -of_objects [get_drc_ruledecks placer_checks] \
		/// -ruledeck placer+
		/// add_drc_checks -ruledeck placer+ *IO*
		/// The following example adds only the rule checks with a severity of Warning to the rule deck:
		/// add_drc_checks -filter {SEVERITY == Warning} -ruledeck warn_only
		///
		/// See ug835-vivado-tcl-commands.pdf, page 38
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
		public TTCL add_drc_checks(string ruledeck, string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: add_drc_checks [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] -ruledeck <arg> [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.add_drc_checks(ruledeck, of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Create a user defined DRC rule
		///
		///
		/// TCL Syntax: create_drc_check [-hiername <arg>] -name <arg> [-desc <arg>] [-msg <arg>] -rule_body <arg> [-severity <arg>] [-quiet] [-verbose]
		///
		/// Create a new user-defined DRC rule check, drc_check, for use by the tool when running
		/// report_drc.
		/// This command allows you to define a unique name or abbreviation for the user-defined rule
		/// check, optionally group the rule into a special hierarchy and provide a description of the rule,
		/// define a general placeholder message for the check when violations are encountered, and refer
		/// to the Tcl code associated with the design rule check to be run during the report_drc
		/// command.
		/// The general placeholder message defined in this command is populated with specific information
		/// related to the design objects and violations found by the Tcl checker procedure, and by the
		/// create_drc_violation command.
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
		/// If a drc_check of the specified name is already defined in the tool, an error is returned. In this
		/// case, to overwrite or redefine and existing drc_check, you must first delete the check using the
		/// delete_drc_check command.
		/// The DRC rule check object features the is_enabled property that can be set to TRUE or
		/// FALSE using the set_property command. When a new rule check is created, the
		/// is_enabled property is set to TRUE as a default. Set the is_enabled property to FALSE to
		/// disable the rule check from being used when report_drc is run. This lets you create new DRC
		/// checks, add them to rule decks using add_drc_checks, and then enable them or disable them
		/// as needed without having to remove them from the rule deck.
		/// Each user defined DRC rule check has the 'USER_DEFINED' property, which lets you quickly
		/// identify and select user-defined rule checks.
		///
		/// The following example defines a new design rule check named RAMW-1, with the hierarchy
		/// name and description defined, using the default severity of Warning, and calling the
		/// dataWidthCheck procedure when the check is run:
		/// create_drc_check -name {RAMW-1} -hiername {RAMB} \
		/// -desc {Data Width Check} -rule_body dataWidthCheck -severity Advisory
		/// The following Tcl script defines the dataWidthCheck procedure which is called by the -
		/// rule_body argument of the RAMW-1 check. This Tcl script file must be loaded into the tool
		/// using the source command, prior to running the report_drc command.
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
		/// See ug835-vivado-tcl-commands.pdf, page 253
		/// </summary>
		/// <param name="name">
		/// (Required)
		/// Specify the name for this rule. This must be of the form
		/// PREFIX-id where XXXX is a 4-6 letter abbreviation and id is an
		/// integer identifying a particular rule. Similar checks should
		/// have the same abbreviation and each a unique id.
		/// </param>
		/// <param name="rule_body">
		/// (Required)
		/// The string representing the body of the rule. This can be a
		/// tcl proc name or any string of tcl code to be evaluated.
		/// </param>
		/// <param name="hiername">
		/// (Optional)
		/// Specify the hiername for this rule. When the DRC UI panel is
		/// created, this is used to place the new rule in the menu
		/// hierarchy. Use a dot (.) to separate layers in the menu
		/// hierarchy. It is optional and will default to User Defined.
		/// Default: User Defined
		/// </param>
		/// <param name="desc">
		/// (Optional)
		/// Specify the short description for this rule. It is optional and
		/// will default to <User rule - default description>. Default:
		/// User rule - default description
		/// </param>
		/// <param name="msg">
		/// (Optional)
		/// Specify the full description for this rule. Including the
		/// substitutions. Values are: %MSG_STRING
		/// %NETLIST_ELEMENT %SITE_GROUP %CLOCK_REGION
		/// %BANK %BEL_GROUP.
		/// </param>
		/// <param name="severity">
		/// (Optional)
		/// Specify severity level for a DRC rule. Default: Warning.
		/// Values: Error, Critical Warning, Warning, Advisory.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_drc_check(string name, string rule_body, string hiername = null, string desc = null, string msg = null, string severity = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_drc_check [-hiername <arg>] -name <arg> [-desc <arg>] [-msg <arg>] -rule_body <arg> [-severity <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_drc_check(name, rule_body, hiername, desc, msg, severity, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Create one or more user defined DRC rule deck objects
		///
		///
		/// TCL Syntax: create_drc_ruledeck [-quiet] [-verbose] <ruledecks>...
		///
		/// Create one or more user-defined rule decks for use when running report_drc.
		/// A drc_ruledeck object is a collection of design rule checks, grouped for convenience, to be run at
		/// different stages of the FPGA design flow, such as during I/O planning or placement. The tool
		/// comes with a set of factory predefined rule decks. Use the get_drc_ruledecks command to
		/// return a list of the currently defined rule decks.
		/// The rule decks created by this command are empty, without any checks. You must add design
		/// rule checks to the rule deck using the add_drc_checks command. Checks can be removed
		/// from a rule deck using the remove_drc_checks command. To see a list of design rule checks
		/// that are available to include in the ruledeck, use the get_drc_checks command.
		/// This command returns the list of drc_ruledecks created.
		///
		/// The following example creates two new drc_ruledeck objects:
		/// create_drc_ruledeck my_rules project_rules
		///
		/// See ug835-vivado-tcl-commands.pdf, page 258
		/// </summary>
		/// <param name="ruledecks">(Required) Names of DRC rule decks to create</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>drc_ruledeck</returns>
		public TTCL create_drc_ruledeck(string ruledecks, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_drc_ruledeck [-quiet] [-verbose] <ruledecks>...
			_tcl.Entry(_builder.create_drc_ruledeck(ruledecks, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Create a DRC violation
		///
		///
		/// TCL Syntax: create_drc_violation -name <arg> [-severity <arg>] [-msg <arg>] [-quiet] [-verbose] [<objects>...]
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
		/// (Required)
		/// Specify the name for this rule. This is the typically a 4-6
		/// letter specification for your rule.
		/// </param>
		/// <param name="severity">
		/// (Optional)
		/// Specify severity level for a DRC rule. Default: WARNING.
		/// Values: FATAL, ERROR, CRITICAL WARNING, WARNING,
		/// ADVISORY.
		/// </param>
		/// <param name="msg">(Optional) Specify your message string for this DRC rule.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">
		/// (Optional)
		/// Cells, ports, pins, nets, clock regions, sites, package banks to
		/// query.
		/// </param>
		public TTCL create_drc_violation(string name, string severity = null, string msg = null, bool? quiet = null, bool? verbose = null, string objects = null)
		{
			// TCL Syntax: create_drc_violation -name <arg> [-severity <arg>] [-msg <arg>] [-quiet] [-verbose] [<objects>...]
			_tcl.Entry(_builder.create_drc_violation(name, severity, msg, quiet, verbose, objects));
			return _tcl;
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
		/// IMPORTANT! Use caution when waiving violations. Waivers may let you proceed in the design flow, but also
		/// let you create a design that is fundamentally flawed.
		/// The user creating the waiver is required to provide a user ID and description in the
		/// create_waiver command in order to provide some history of the waiver.
		/// A waiver must be specified for an individual DRC or methodology violation, or for a specific DRC
		/// or methodology check, or for a CDC path. The waiver must be assigned to a specific object, or
		/// specific violation ID, or for paths using -from/-to arguments. The form of the
		/// create_waiver command varies depending on the check, violation, or object being waived, as
		/// shown in the examples below.
		/// TIP: Although many of the arguments are described as optional, some form of identifier is required to associate
		/// the waiver with its target.
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
		/// See ug835-vivado-tcl-commands.pdf, page 357
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
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>waiver</returns>
		public TTCL create_waiver(string description, string type = null, string id = null, string objects = null, string from = null, string to = null, string strings = null, string of_objects = null, string user = null, string tags = null, string timestamp = null, bool? scoped = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_waiver [-type <arg>] [-id <arg>] [-objects <args>] [-from <args>] [-to <args>] [-strings <args>] [-of_objects <args>] [-user <arg>] -description <arg> [-tags <arg>] [-timestamp <arg>] [-scoped] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_waiver(description, type, id, objects, from, to, strings, of_objects, user, tags, timestamp, scoped, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Delete one or more user-defined DRC checks.
		///
		///
		/// TCL Syntax: delete_drc_check [-quiet] [-verbose] <name>...
		///
		/// Delete a single user-defined design rule check from the current project. User-defined design rule
		/// checks are created using the create_drc_checks command.
		/// Note: You cannot delete factory defined rule checks.
		/// Once it has been deleted there is no way to recover a rule check. The undo command will not
		/// work.
		/// Note: This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example deletes the specified design rule check:
		/// delete_drc_check LJH-1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 427
		/// </summary>
		/// <param name="name">
		/// (Required)
		/// Specify the key for the check to remove. This is the typically
		/// of the form PREFIX-id where PREFIX is a 4-6 letter
		/// abbreviation and id is a unique identifier. Use
		/// get_drc_checks to determine the correct name to use. Only
		/// user-defined DRC checks may be deleted.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_drc_check(string name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_drc_check [-quiet] [-verbose] <name>...
			_tcl.Entry(_builder.delete_drc_check(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Delete one or more user defined DRC rule deck objects
		///
		///
		/// TCL Syntax: delete_drc_ruledeck [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Delete one or more user-defined drc_ruledeck objects from the current project. The rule deck
		/// does not have to be empty to be deleted, and once it is deleted there is no way to recover it. The
		/// undo command will not restore a deleted rule deck.
		/// Note: You cannot delete factory defined rule decks.
		/// A rule deck is a collection of design rule checks grouped for convenience, to be run with the
		/// report_drc command at different stages of the FPGA design flow, such as during I/O planning
		/// or placement. The tool comes with a set of factory defined rule decks, but you can also create
		/// new user-defined rule decks with the create_drc_ruledeck command.
		/// Note: This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example deletes all user-defined rule decks from the current project:
		/// delete_drc_ruledeck
		///
		/// See ug835-vivado-tcl-commands.pdf, page 429
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'drc_ruledeck' objects against patterns. Default: *</param>
		/// <returns>drc_ruledeck</returns>
		public TTCL delete_drc_ruledeck(bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: delete_drc_ruledeck [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.delete_drc_ruledeck(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of DRC rule check objects
		///
		///
		/// TCL Syntax: get_drc_checks [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-abbrev <arg>] [-ruledecks <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of the currently defined DRC checks. This list includes both factory defined design rule
		/// checks, and user-defined checks created by the create_drc_check command.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following command gets a list of all AVAL design rule checks:
		/// get_drc_checks AVAL*
		/// The following example gets the checks associated with the specified rule deck:
		/// get_drc_checks -of_objects [get_drc_ruledecks placer_checks]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 662
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
		public TTCL get_drc_checks(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, string abbrev = null, string ruledecks = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_drc_checks [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-abbrev <arg>] [-ruledecks <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_drc_checks(of_objects, regexp, nocase, filter, abbrev, ruledecks, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of DRC rule deck objects
		///
		///
		/// TCL Syntax: get_drc_ruledecks [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of currently defined rule decks for use with the report_drc command.
		/// A rule deck is a collection of design rule checks grouped for convenience, to be run at different
		/// stages of the FPGA design flow, such as during I/O planning or placement. The tool comes with a
		/// set of factory defined rule decks, but you can also create new user-defined rule decks with the
		/// create_drc_ruledeck command, and add checks to the rule deck using the
		/// add_drc_checks command.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of rule decks defined in the current project:
		/// get_drc_ruledecks
		/// The following example lists each of the checks associated with the placer_checks rule deck on a
		/// separate line:
		/// foreach rule [get_drc_checks -of_objects \
		/// [get_drc_ruledecks placer_checks]] {puts $rule}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 665
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'drc_ruledeck' objects of these types: 'rule_check'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'drc_ruledeck' objects against patterns. Default: *</param>
		/// <returns>drc_ruledeck</returns>
		public TTCL get_drc_ruledecks(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_drc_ruledecks [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_drc_ruledecks(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of DRC violations from a previous report_drc run
		///
		///
		/// TCL Syntax: get_drc_violations [-name <arg>] [-regexp] [-filter <arg>] [-nocase] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of violation objects found in the design when the report_drc command is run.
		/// Violation objects are created at the time DRC is run, either by the internal design rule checks
		/// provided by the Vivado tools, or created by the create_drc_violation command in user￾defined DRC checks. The properties of individual violation objects can be queried using
		/// report_property or list_property commands for details of the violation.
		/// Violation objects are associated with the cells, nets, pins, or ports in the current design, or sites
		/// on the current device. The design objects associated with a DRC violation object can be obtained
		/// using the -of_objects option of the appropriate get_* command, such as get_cells, or
		/// get_nets for instance.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example reports the DRC violations found in the current design, then returns a list
		/// of all those violations:
		/// report_drc
		/// get_drc_violations
		/// The following example gets the properties of the specified DRC violation:
		/// report_property [lindex [get_drc_violations] 0]
		/// The following example returns the list of violations in the specified DRC report of the current
		/// design, and then returns the ports associated with any violations of the unspecified I/O Standard
		/// rule (NSTD):
		/// get_drc_violations -name drc_1
		/// get_ports -of_objects [get_drc_violations -name drc_1 NSTD*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 668
		/// </summary>
		/// <param name="name">(Optional) Get the results with this name</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// Match drc_violations against patterns Default: * Values: The
		/// default search pattern is the wildcard *, or .* when -regexp
		/// is specified.
		/// </param>
		/// <returns>list of DRC violation objects</returns>
		public TTCL get_drc_violations(string name = null, bool? regexp = null, string filter = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_drc_violations [-name <arg>] [-regexp] [-filter <arg>] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_drc_violations(name, regexp, filter, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Remove DRC rule check objects from a user rule deck
		///
		///
		/// TCL Syntax: remove_drc_checks [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] -ruledeck <arg> [-quiet] [-verbose] [<patterns>]
		///
		/// Remove the specified design rule checks from a drc_ruledeck object.
		/// A rule deck is a collection of design rule checks grouped for convenience, to be run with the
		/// report_drc command at different stages of the FPGA design flow, such as during I/O planning
		/// or placement. The tool comes with a set of factory defined rule decks, but you can also create
		/// new user-defined rule decks with the create_drc_ruledeck command.
		/// Checks are added to a rule deck using the add_drc_checks command.
		/// The DRC rule check object features the IS_ENABLED property that can be set to true or false
		/// using the set_property command. When a new rule check is created, the IS_ENABLED
		/// property is set to true as a default. Set the IS_ENABLED property to false to disable the rule
		/// check from being used by report_drc without having to remove the rule from the rule deck.
		/// TIP: Use the reset_drc_check command to restore the DRC rule, and its properties, to the default settings.
		/// This command returns the list of design rule checks that were removed from the specified rule
		/// deck.
		///
		/// The following example removes the rule checks matching the specified filter pattern from the
		/// my_rules rule deck:
		/// remove_drc_checks -filter {GROUP == AVAL} -ruledeck my_rules
		/// The following example disables the specified DRC check without removing it from the rule deck:
		/// set_property IS_ENABLED FALSE [get_drc_checks RAMW-1]
		/// The following example removes all rule checks from the specified rule deck:
		/// remove_drc_checks -ruledeck my_rules
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1217
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
		public TTCL remove_drc_checks(string ruledeck, string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: remove_drc_checks [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] -ruledeck <arg> [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.remove_drc_checks(ruledeck, of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Run DRC
		///
		///
		/// TCL Syntax: report_drc [-name <arg>] [-upgrade_cw] [-checks <args>] [-ruledecks <args>] [-file <arg>] [-rpx <arg>] [-append] [-waived] [-no_waivers] [-return_string] [-quiet] [-verbose]
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
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="upgrade_cw">
		/// (Optional)
		/// Specifies if report_drc should upgrade all
		/// CRITICAL_WARNING violations to ERROR.
		/// </param>
		/// <param name="checks">(Optional) DRC checks (see get_drc_checks for available checks)</param>
		/// <param name="ruledecks">(Optional) Containers of DRC rule checks Default: default</param>
		/// <param name="file">
		/// (Optional)
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="rpx">(Optional) Report filename for persisted results.</param>
		/// <param name="append">(Optional) Append the results to file, do not overwrite the results file</param>
		/// <param name="waived">(Optional) Output result is Waived checks</param>
		/// <param name="no_waivers">(Optional) Disable waivers for checks</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_drc(string name = null, bool? upgrade_cw = null, string checks = null, string ruledecks = null, string file = null, string rpx = null, bool? append = null, bool? waived = null, bool? no_waivers = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_drc [-name <arg>] [-upgrade_cw] [-checks <args>] [-ruledecks <args>] [-file <arg>] [-rpx <arg>] [-append] [-waived] [-no_waivers] [-return_string] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_drc(name, upgrade_cw, checks, ruledecks, file, rpx, append, waived, no_waivers, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Remove DRC report
		///
		///
		/// TCL Syntax: reset_drc [-name <arg>] [-quiet] [-verbose]
		///
		/// Clear the DRC results from the specified named result set.
		/// This command operates silently, returning nothing if successful, or returning an error if it fails.
		///
		/// The following example clears the specified results set from memory and the GUI:
		/// reset_drc -name DRC1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1449
		/// </summary>
		/// <param name="name">(Optional) DRC result name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_drc(string name = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_drc [-name <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.reset_drc(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Reset one or more DRC checks to factory defaults.
		///
		///
		/// TCL Syntax: reset_drc_check [-quiet] [-verbose] [<checks>...]
		///
		/// Reset the specified DRC checks to the defaults provided by the Vivado Design Suite. This will
		/// restore the DRC check to its default configuration, including any changes to the IS_ENABLED or
		/// SEVERITY properties.
		/// The IS_ENABLED property can be modified on a specific DRC check to disable the rule from
		/// being checked, even when it is specified either directly in the report_drc command, or as part
		/// of a ruledeck.
		/// The SEVERITY property is a string property that can be modified to change the severity
		/// associated with a specific DRC rule when a violation is found during the report_drc command.
		/// The supported values are: FATAL, ERROR, "CRITICAL WARNING", WARNING, ADVISORY
		///
		/// The following example modifies the IS_ENABLED property for the ROAS-1 rule, modifies the
		/// SEVERITY property for the RFFC-1 rule, and then restores the default settings for all checks:
		/// set_property IS_ENABLED false [get_drc_checks ROAS-1]
		/// set_property SEVERITY "Critical Warning" [get_drc_checks RFFC-1]
		/// reset_drc_check [get_drc_checks]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1451
		/// </summary>
		/// <param name="checks">(Required) The list of checks to reset.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_drc_check(string checks, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_drc_check [-quiet] [-verbose] [<checks>...]
			_tcl.Entry(_builder.reset_drc_check(checks, quiet, verbose));
			return _tcl;
		}
	}
}
