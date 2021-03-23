// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class ObjectCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public ObjectCommands(TTCL tcl, VivadoTCLBuilder builder)
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
		/// Applies board connections to given designs
		///
		///
		/// TCL Syntax: apply_board_connection [-board_interface <arg>] -ip_intf <arg> -diagram <arg> [-quiet] [-verbose]
		///
		/// Connects the interface pin of an IP core in the specified block design to the interface of the
		/// current board part in the current project or design.
		/// The board part provides a representation of the Xilinx device in the context of the board-level
		/// system, and can help define key aspects of the design, such as clock constraints, I/O port
		/// assignments, and supported interfaces. The board part file stores information regarding board
		/// attributes. The file, called board_part.xml, is located in the data/boards/board_parts
		/// folder of the Vivado Design Suite installation area.
		/// The command lets you quickly connect compatible interface pins of an IP integrator block design
		/// to the appropriate interface definition on the current board part. To make the connection
		/// between the IP core to the board part, the IP integrator of the Vivado Design Suite adds an
		/// external interface port and interface connection to the block design. The added external
		/// interface port is named for the specified board part interface.
		/// The apply_board_connection commands uses the available interfaces of the current board
		/// part defined in the project. An error is returned if the project uses a target part rather than a
		/// target board. You can use the current_board_part command to identify the target board
		/// used by the project, or get_board_parts to list the boards available for use by the project.
		/// Use the get_board_part_interfaces command to determine the list of available interfaces
		/// on the current board.
		/// To remove an existing IP interface connection, specify the -ip_intf option, but do not specify
		/// the -board_interface. If no board part interface is specified, the IP interface pin is
		/// disconnected.
		/// This command returns a transcript of it actions, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 99
		/// </summary>
		/// <param name="ip_intf">
		/// (Required)
		/// Full path of IP interface name to which board automation
		/// need to be applied.
		/// </param>
		/// <param name="diagram">(Required) The IP Integrator design name.</param>
		/// <param name="board_interface">(Optional) Board interface name to which connection need to be applied.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>sucess/failure status of applied action.</returns>
		public TTCL apply_board_connection(string ip_intf, string diagram, string board_interface = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: apply_board_connection [-board_interface <arg>] -ip_intf <arg> -diagram <arg> [-quiet] [-verbose]
			_tcl.Entry(_builder.apply_board_connection(ip_intf, diagram, board_interface, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Check if a module can be referenced
		///
		///
		/// TCL Syntax: can_resolve_reference [-quiet] [-verbose] <module>...
		///
		/// This command is used to validate reference to modules prior to trying to import them into the
		/// design. Its primary use is in scripts like the script produced by the write_bd_tcl command,
		/// though you can use it in your own scripts as well.
		/// This command returns 0 if the reference cannot be resolved, or returns 1 if it can be resolved.
		///
		/// This example determines if the reference to the specified module can be resolved:
		/// can_resolve_reference clk_div
		///
		/// See ug835-vivado-tcl-commands.pdf, page 120
		/// </summary>
		/// <param name="module">(Required) module name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL can_resolve_reference(string module, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: can_resolve_reference [-quiet] [-verbose] <module>...
			_tcl.Entry(_builder.can_resolve_reference(module, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Manage the IP instance Synthesis cache. Lists out the IP Cache entries if no options are specified.
		///
		///
		/// TCL Syntax: config_ip_cache [-use_cache_location <arg>] [-use_project_cache] [-disable_cache] [-clear_output_repo] [-clear_local_cache] [-cache_has_match] [-cache_was_used] [-get_id] [-remove] [-vlnv <arg>] [-old_swvers] [-unused] [-swver <arg>] [-num_days_old <arg>] [-num_days_unused <arg>] [-obs_synth_crc] [-disk_usage_output_repo] [-report] [-rptfile <arg>] [-csvfile <arg>] [-import_from_project] [-filter <arg>] [-regexp] [-nocase] [-purge] [-quiet] [-verbose] [<ip>]
		///
		/// This command lets you manage the Vivado Design Suite out-of-context (OOC) IP cache. The
		/// Vivado Design Suite caches the synthesis results for customized OOC IP in an IP repository, so
		/// multiple IP that use the same customization profile can share OOC synthesis results to decrease
		/// run time. The cached synthesis results can be reused in a single project from the project cache, or
		/// across multiple projects using a remote cache location.
		/// When generating the synthesis output products for an OOC IP, if a matching IP customization is
		/// found in the IP repository, the cached synthesis results will be used. If no suitable match is found
		/// in the IP repository, the synthesis output products will be generated as usual and the results,
		/// including the design checkpoint (DCP), will be copied into the IP synthesis cache for future use.
		/// TIP: When cached results are used, an information message is displayed in the Tcl console indicating the IP
		/// cache location used.
		/// You can specify a repository of cached IP synthesis results either within the current project, or at
		/// an external location. The location of the IP cache is defined by the IP_OUTPUT_REPO property
		/// on a project, with the value of a string defining a valid file system directory. You can set this
		/// property using the check_ip_cache command with either the -use_cache_location or
		/// the -use_project_cache options. The default IP synthesis cache location is in the current
		/// project folders.
		/// The use of the IP synthesis cache is controlled by the IP_CACHE_PERMISSIONS property that
		/// can be set with the set_property command. The current values are:
		/// • disabled - Do not use the IP synthesis cache. This is the default setting.
		/// • read - Use the IP synthesis cache to read OOC synthesis results from and apply as appropriate
		/// in the current project.
		/// • write - Use the IP synthesis cache to write OOC synthesis results into, but do not use them to
		/// read IP into the current project.
		/// • read write - Use the IP synthesis cache for both writing results to, and using those results in
		/// the current project.
		/// The config_ip_cache command should be followed by the update_ip_catalog command
		/// to read the specified IP cache repository into the Vivado tool.
		/// TIP: The IP synthesis cache can be enabled, and the cache repository specified, in the Vivado Design Suite IDE
		/// using the Settings dialog box. Refer to the Vivado Design Suite User Guide: Designing with IP (UG896) for more
		/// information on using the cache.
		/// By default, without any of the arguments specified below, the config_ip_cache command
		/// returns a list of entries in the IP synthesis cache, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 174
		/// </summary>
		/// <param name="use_cache_location">(Optional) Set current project properties to use the specified cache location</param>
		/// <param name="use_project_cache">
		/// (Optional)
		/// Set current project properties to use the default project IP
		/// cache location
		/// </param>
		/// <param name="disable_cache">(Optional) Disable cache use.</param>
		/// <param name="clear_output_repo">
		/// (Optional)
		/// Delete from disk and in memory all cache entries that exist
		/// in the current project's designated cache (local or remote).
		/// </param>
		/// <param name="clear_local_cache">
		/// (Optional)
		/// Delete from disk and in memory all local cache entries for
		/// this project.
		/// </param>
		/// <param name="cache_has_match">
		/// (Optional)
		/// Returns the cache-ID of the cache entry that would work for
		/// this IP instance; else ''.
		/// </param>
		/// <param name="cache_was_used">
		/// (Optional)
		/// Returns '1' if the cache was used to obtain the IP's current
		/// synthesis results; else '0'.
		/// </param>
		/// <param name="get_id">(Optional) Calculate and return IP cache ID string for specified <ip></param>
		/// <param name="remove">
		/// (Optional)
		/// Remove the corresponding cache entry for the specified IP
		/// instance or specified cachedInst; return cache ID string if
		/// successful, otherwise blank.
		/// </param>
		/// <param name="vlnv">
		/// (Optional)
		/// Used with -purge or -get_resource_data, specifies the VLNV
		/// of the cache entries to delete or find. May use a wildcard
		/// ('*') in one or more fields in the VLNV.
		/// </param>
		/// <param name="old_swvers">
		/// (Optional)
		/// Used with -purge to delete cache entries created with old
		/// Vivado SW Versions.
		/// </param>
		/// <param name="unused">(Optional) Used with -purge to delete cache entries that have never been used.</param>
		/// <param name="swver">
		/// (Optional)
		/// Used with -purge to delete any cache entries created from
		/// this specific Vivado SW Version (i.e., '2017.1').
		/// </param>
		/// <param name="num_days_old">
		/// (Optional)
		/// Used with -purge to delete any cache entries that are this
		/// number of days old or older.
		/// </param>
		/// <param name="num_days_unused">
		/// (Optional)
		/// Used with -purge to delete any cache entries that have not
		/// been used for this number of days or longer.
		/// </param>
		/// <param name="obs_synth_crc">
		/// (Optional)
		/// Used with -purge to delete cache entries whose component
		/// synth checksum is not the same as the IP Catalog's current
		/// component synthesis checksum.
		/// Name Description
		/// </param>
		/// <param name="disk_usage_output_repo">
		/// (Optional)
		/// Return total disk usage in MB for all cache entries in the
		/// current project's ip_output_repo.
		/// </param>
		/// <param name="report">
		/// (Optional)
		/// Report cache statistics for the specified IP or cache object,
		/// or for the current cache location if none specified. If -rptfile
		/// is specified, write statistics to that file. If -dir is specified,
		/// write statistics for cache entries found under that directory.
		/// </param>
		/// <param name="rptfile">
		/// (Optional)
		/// Used with -report, specifies the text file to write the cache
		/// statistics to.
		/// </param>
		/// <param name="csvfile">
		/// (Optional)
		/// Used with -report, specifies the csv file to write the cache
		/// statistics to, in csv format.
		/// </param>
		/// <param name="import_from_project">(Optional) Import existing synthesized IP from the project into the cache.</param>
		/// <param name="filter">(Optional) Filter result of '-list'</param>
		/// <param name="regexp">(Optional) Use regular expressions instead of globs in '-filter' argument(s)</param>
		/// <param name="nocase">(Optional) Use case insensitive matching in '-filter' argument(s)</param>
		/// <param name="purge">
		/// (Optional)
		/// Delete all cache entries that match the specified type(s): -
		/// vlnv, -obs_swvers, -obs_synth_crc, and/or -swver. Returns
		/// the number of entries deleted.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="ip">(Optional) IP instance object, IP file, or IP name pattern</param>
		public TTCL config_ip_cache(string use_cache_location = null, bool? use_project_cache = null, bool? disable_cache = null, bool? clear_output_repo = null, bool? clear_local_cache = null, bool? cache_has_match = null, bool? cache_was_used = null, bool? get_id = null, bool? remove = null, string vlnv = null, bool? old_swvers = null, bool? unused = null, string swver = null, string num_days_old = null, string num_days_unused = null, bool? obs_synth_crc = null, bool? disk_usage_output_repo = null, bool? report = null, string rptfile = null, string csvfile = null, bool? import_from_project = null, string filter = null, bool? regexp = null, bool? nocase = null, bool? purge = null, bool? quiet = null, bool? verbose = null, string ip = null)
		{
			// TCL Syntax: config_ip_cache [-use_cache_location <arg>] [-use_project_cache] [-disable_cache] [-clear_output_repo] [-clear_local_cache] [-cache_has_match] [-cache_was_used] [-get_id] [-remove] [-vlnv <arg>] [-old_swvers] [-unused] [-swver <arg>] [-num_days_old <arg>] [-num_days_unused <arg>] [-obs_synth_crc] [-disk_usage_output_repo] [-report] [-rptfile <arg>] [-csvfile <arg>] [-import_from_project] [-filter <arg>] [-regexp] [-nocase] [-purge] [-quiet] [-verbose] [<ip>]
			_tcl.Entry(_builder.config_ip_cache(use_cache_location, use_project_cache, disable_cache, clear_output_repo, clear_local_cache, cache_has_match, cache_was_used, get_id, remove, vlnv, old_swvers, unused, swver, num_days_old, num_days_unused, obs_synth_crc, disk_usage_output_repo, report, rptfile, csvfile, import_from_project, filter, regexp, nocase, purge, quiet, verbose, ip));
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
		/// Create new PartitionDef
		///
		///
		/// TCL Syntax: create_partition_def -name <arg> -module <arg> [-library <arg>] [-quiet] [-verbose]
		///
		/// IMPORTANT! You must first define the project as a Partial Reconfiguration (PR) project by setting the
		/// PR_FLOW property on the project to TRUE, or by using the Tools > Enable Partial Reconfiguration command.
		/// The Partial Reconfiguration flow lets you create Partition Definitions (partitionDefs) from
		/// hierarchical cells in a design, and to specify reconfigurable modules (RMs) to be assigned to these
		/// partitionDefs to create a unique configurations of the design based on the combination of the
		/// core design and one or more RMs. The PR design flow requires the implementation of each PR
		/// configuration, resulting in partial bitstreams for the RMs, but complete bitstreams for each
		/// integrated configuration. Refer to the Vivado Design Suite User Guide: Dynamic Function eXchange
		/// (UG909) for more information.
		/// The create_partition_def command defines a partitionDef object in a PR project from a
		/// specified hierarchical cell. The partitionDef defines a partition hierarchy that RMs can be
		/// assigned to for a specific PR configuration.
		/// This command returns the name of the newly created partitionDef, or returns an error if the
		/// command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 316
		/// </summary>
		/// <param name="name">(Required) Name of the PartitionDef</param>
		/// <param name="module">(Required) Module name of the PartitionDef</param>
		/// <param name="library">(Optional) Library name of the module of PartitionDef</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_partition_def(string name, string module, string library = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_partition_def -name <arg> -module <arg> [-library <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_partition_def(name, module, library, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Create new Configuration
		///
		///
		/// TCL Syntax: create_pr_configuration -name <arg> [-partitions <args>] [-greyboxes <args>] [-use_netlist] [-quiet] [-verbose]
		///
		/// IMPORTANT! You must first define the project as a Partial Reconfiguration (PR) project by setting the
		/// PR_FLOW property on the project to TRUE, or by using the Tools > Enable Partial Reconfiguration command.
		/// The Partial Reconfiguration flow lets you create Partition Definitions (partitionDefs) from
		/// hierarchical cells in a design, and to specify reconfigurable modules (RMs) to be assigned to these
		/// partitionDefs to create unique configurations of the design based on the combination of the core
		/// design and one or more RMs. The PR design flow requires the implementation of each PR
		/// configuration, resulting in partial bitstreams for the RMs, but complete bitstreams for each
		/// integrated configuration. Refer to the Vivado Design Suite User Guide: Dynamic Function eXchange
		/// (UG909) for more information.
		/// The create_pr_configuration command defines the combination of the static logic and
		/// the RM to create a unique configuration of the design. The PR configuration is the design that is
		/// implemented and the bitstream is generated for.
		/// You will also need to create implementation runs for the PR configuration using the
		/// create_run -pr_config command.
		/// This command returns the name of the newly created PR configuration, or returns an error if the
		/// command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 330
		/// </summary>
		/// <param name="name">(Required) Name of the Configuration</param>
		/// <param name="partitions">(Optional) List of partition instances and reconfig modules pairs</param>
		/// <param name="greyboxes">(Optional) List of instances to which buffers need to be inserted for all ports</param>
		/// <param name="use_netlist">
		/// (Optional)
		/// Use netlist for getting instances of partition_defs to creating
		/// configurations
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_pr_configuration(string name, string partitions = null, string greyboxes = null, bool? use_netlist = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_pr_configuration -name <arg> [-partitions <args>] [-greyboxes <args>] [-use_netlist] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_pr_configuration(name, partitions, greyboxes, use_netlist, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Create new reconfig Module
		///
		///
		/// TCL Syntax: create_reconfig_module -name <arg> [-top <arg>] [-gate_level] -partition_def <arg> [-define_from <arg>] [-define_from_file <arg>] [-quiet] [-verbose]
		///
		/// IMPORTANT! You must first define the project as a Partial Reconfiguration (PR) project by setting the
		/// PR_FLOW property on the project to TRUE, or by using the Tools > Enable Partial Reconfiguration command.
		/// The create_reconfig_module command defines an reconfigurable module (RM) from a
		/// specified hierarchical cell, or design file, and assigns it to the specified Partition Definition
		/// (partitionDef) in the current project.
		/// The Partial Reconfiguration flow allows RMs to be swapped into and out of a partitionDef to
		/// create a unique configuration of the design based on the combination of the core design and an
		/// RM. A single partitionDef can have multiple RMs to contain different netlists, constraints, or
		/// implementations. Each instance of the partitionDef in the design can be assigned a different RM
		/// to support many different configurations. The PR design flow requires the implementation of
		/// each PR configuration, resulting in partial bitstreams for the RMs, but complete bitstreams for
		/// each integrated configuration. Refer to the Vivado Design Suite User Guide: Dynamic Function
		/// eXchange (UG909) for more information.
		/// This command returns the hierarchical name of the newly created RM, or returns an error if the
		/// command failed.
		///
		/// The example below creates a reconfigurable module with the specified name:
		/// create_reconfig_module -name fftBottom -partition_def \
		/// [get_partition_defs partDef1 ] -top fftTop
		///
		/// See ug835-vivado-tcl-commands.pdf, page 340
		/// </summary>
		/// <param name="name">(Required) Name of the Reconfig Module</param>
		/// <param name="partition_def">(Required) PartitionDef in which reconfig module will be created</param>
		/// <param name="top">(Optional) module name of the top module</param>
		/// <param name="gate_level">(Optional) Create Reconfig Module whcih alllows adding DCP/EDIF files only</param>
		/// <param name="define_from">(Optional) Name of the module in the source fileset to be the top of the blockset</param>
		/// <param name="define_from_file">
		/// (Optional)
		/// full path of the top source file in the source fileset for which
		/// reconfigurable module to be created.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_reconfig_module(string name, string partition_def, string top = null, bool? gate_level = null, string define_from = null, string define_from_file = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_reconfig_module -name <arg> [-top <arg>] [-gate_level] -partition_def <arg> [-define_from <arg>] [-define_from_file <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_reconfig_module(name, partition_def, top, gate_level, define_from, define_from_file, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Create Configurable Report objects.
		///
		///
		/// TCL Syntax: create_report_config [-report_name <arg>] [-report_type <arg>] -steps <args> -runs <args> [-options <arg>] [-copy_of <args>] [-quiet] [-verbose]
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
		/// <param name="steps">(Required) List of run step(s) for object(s) created</param>
		/// <param name="runs">(Required) List of run(s) for object(s) created</param>
		/// <param name="report_name">
		/// (Optional)
		/// Name of configurable report object created. Can not be
		/// used when creating multiple objects
		/// </param>
		/// <param name="report_type">
		/// (Optional)
		/// Type of configurable report object(s) created. Not required
		/// with '-copy_of'
		/// </param>
		/// <param name="options">
		/// (Optional)
		/// options for report command to be set at creation of
		/// configurable report object, except with '-copy_of'
		/// </param>
		/// <param name="copy_of">(Optional) configurable report object to be copied</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>List of configurable report objects</returns>
		public TTCL create_report_config(string steps, string runs, string report_name = null, string report_type = null, string options = null, string copy_of = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_report_config [-report_name <arg>] [-report_type <arg>] -steps <args> -runs <args> [-options <arg>] [-copy_of <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_report_config(steps, runs, report_name, report_type, options, copy_of, quiet, verbose));
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
		/// Get the current board object
		///
		///
		/// TCL Syntax: current_board [-quiet] [-verbose]
		///
		/// Returns the board in use in the current project.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// The board can be specified:
		/// • When the project is created by selecting Boards from the Default Part dialog box.
		/// • By setting the BOARD_PART property on the current project as shown in the example.
		/// • By selecting the Project Device in the Settings dialog box in an open project in the Vivado IDE.
		/// Refer to the Vivado Design Suite User Guide: System-Level Design Entry (UG895) for information on
		/// creating projects, and on configuring project settings.
		/// IMPORTANT! When you specify the board with the set_property command, the target part is also
		/// changed to match the part required by the specified BOARD property.
		/// The current_board command returns the Vendor:Board_Name:File_Version attributes
		/// of the current board, as defined in the BOARD_PART property. The command returns nothing
		/// when the project targets a Xilinx FPGA instead of a TRD and board, or when the BOARD_PART
		/// property has not been defined. The command returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 369
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>current board object</returns>
		public TTCL current_board(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: current_board [-quiet] [-verbose]
			_tcl.Entry(_builder.current_board(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get the current board_part object
		///
		///
		/// TCL Syntax: current_board_part [-quiet] [-verbose]
		///
		/// Return the Xilinx device used in the current project or design.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// The board part provides a representation of the Xilinx device in the context of the board-level
		/// system, and is represented by the part0 component in the Board Interface file.
		/// The board can be specified:
		/// • When the project is created by selecting Boards from the Default Part dialog box.
		/// • By setting the BOARD_PART property on the current project as shown in the example.
		/// • By selecting the Project Device in the Settings dialog box in an open project in the Vivado IDE.
		/// Refer to the Vivado Design Suite User Guide: System-Level Design Entry (UG895) for information on
		/// creating projects, and on configuring project settings.
		/// IMPORTANT! When you specify the board with the set_property command, the target part is also
		/// changed to match the part required by the specified BOARD_PART property.
		/// The current_board_part command returns the NAME property of the current board part.
		/// The command returns a warning when the project targets a Xilinx FPGA instead of a board, or
		/// when the BOARD_PART property has not been defined. The command returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 372
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>current board_part object</returns>
		public TTCL current_board_part(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: current_board_part [-quiet] [-verbose]
			_tcl.Entry(_builder.current_board_part(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of PartitionDefs
		///
		///
		/// TCL Syntax: current_pr_configuration [-quiet] [-verbose] [<config>...]
		///
		/// Get or set the current PR configuration.
		/// In the Partial Reconfiguration (PR) design flow, the PR configuration lets you specify a
		/// reconfigurable module (RM) to assign to a specific instance of a Partition Definition
		/// (partitionDef). This flow lets you create unique configurations of the design based on the
		/// combination of the core design and one or more RMs. The PR design flow requires the
		/// implementation of each PR configuration, resulting in partial bitstreams for the RMs, but
		/// complete bitstreams for each integrated configuration. Refer to the Vivado Design Suite User
		/// Guide: Dynamic Function eXchange (UG909) for more information.
		/// The current_pr_configuration either returns the PR configuration that is the current or active
		/// configfuration in the design, or lets you specify a PR configuration to make active.
		/// This command returns the name of the current PR configuration, or returns an error if the
		/// command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 399
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="config">(Optional) Specify the PR configuration to be set as current (active); optional</param>
		/// <returns>list of PartitionDef objects</returns>
		public TTCL current_pr_configuration(bool? quiet = null, bool? verbose = null, string config = null)
		{
			// TCL Syntax: current_pr_configuration [-quiet] [-verbose] [<config>...]
			_tcl.Entry(_builder.current_pr_configuration(quiet, verbose, config));
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
		/// Removes the HW Bitstream object from a list of hardware devices.
		///
		///
		/// TCL Syntax: delete_hw_bitstream [-of_objects <args>] [-quiet] [-verbose]
		///
		/// This command deletes the hw_bitstream object from the specified hw_device objects.
		/// This clears the PROGRAM.HW_BITSTREAM and PROGRAM.FILE properties on the hw_device
		/// objects, and deletes the hw_bitstream object.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 436
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_bitstream' objects of these types: 'hw_device'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>hardware devices</returns>
		public TTCL delete_hw_bitstream(string of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_hw_bitstream [-of_objects <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.delete_hw_bitstream(of_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Deletes a list of available QoR suggestions
		///
		///
		/// TCL Syntax: delete_qor_suggestions [-quiet] [-verbose] [<IDs>]
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
		/// <param name="IDs">(Required) Match suggestion names against given names</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_qor_suggestions(string IDs, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_qor_suggestions [-quiet] [-verbose] [<IDs>]
			_tcl.Entry(_builder.delete_qor_suggestions(IDs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Delete a set of existing configurable report objects
		///
		///
		/// TCL Syntax: delete_report_configs [-quiet] [-verbose] <report_configs>...
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
		/// <param name="report_configs">(Required) List of configurable report objects to delete</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_report_configs(string report_configs, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_report_configs [-quiet] [-verbose] <report_configs>...
			_tcl.Entry(_builder.delete_report_configs(report_configs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Delete one or more DRC/METHODOLOGY/CDC message waivers
		///
		///
		/// TCL Syntax: delete_waivers [-scoped] [-quiet] [-verbose] [<objects>...]
		///
		/// After report_drc, report_methodology, or report_cdc commands are run, they return
		/// messages of specific violations or conditions found in the design. These violations can prevent
		/// the design from progressing until they have been resolved or addressed in some way. The
		/// create_waiver command lets you select individual violations or specific checks that can be
		/// waived for a design, letting you move forward in the design flow.
		/// Use the delete_waivers command to remove waivers from the design.
		///
		/// This example deletes all the DRC waivers in the design:
		/// delete_waivers [get_waivers -type DRC]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 472
		/// </summary>
		/// <param name="scoped">
		/// (Optional)
		/// flag waiver to interpret object wildcards as scoped to the
		/// current_instance that is set
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">
		/// (Optional)
		/// List of waiver objects, or a list of message objects (cells,
		/// nets, sites, etc.) for which DRC/METHODOLOGY waiver(s)
		/// were set
		/// </param>
		public TTCL delete_waivers(bool? scoped = null, bool? quiet = null, bool? verbose = null, string objects = null)
		{
			// TCL Syntax: delete_waivers [-scoped] [-quiet] [-verbose] [<objects>...]
			_tcl.Entry(_builder.delete_waivers(scoped, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// Filter a list, resulting in new list
		///
		///
		/// TCL Syntax: filter [-regexp] [-nocase] [-quiet] [-verbose] [<objects>] [<filter>]
		///
		/// Takes a list of objects, and returns a reduced list of objects that match the specified filter search
		/// pattern.
		///
		/// The following example returns a list of parts filtered for the specified speed grade:
		/// filter [get_parts] {speed == -3}
		/// The following example filters parts based according to speed grade -3 OR speed grade -2. All
		/// parts matching either speed grade will be returned.
		/// filter [get_parts] {speed == -3 || speed == -2}
		/// The following example uses regular expression and returns a list of VStatus ports in the design,
		/// with zero or more wildcards, and the numbers 0 to 9 appearing one or more times within square
		/// brackets:
		/// filter -regexp [get_ports] {NAME =~ VStatus.*\[[0-9]+\]}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 515
		/// </summary>
		/// <param name="regexp">(Optional) Operators =~ and !~ use regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">(Optional) List of objects to filter</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <returns>new list</returns>
		public TTCL filter(bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, string objects = null, string filter = null)
		{
			// TCL Syntax: filter [-regexp] [-nocase] [-quiet] [-verbose] [<objects>] [<filter>]
			_tcl.Entry(_builder.filter(regexp, nocase, quiet, verbose, objects, filter));
			return _tcl;
		}
		/// <summary>
		/// Find a routing path between two nodes.
		///
		///
		/// TCL Syntax: find_routing_path [-allow_overlap] [-max_nodes <arg>] [-min_nodes <arg>] [-from <args>] [-to <args>] [-quiet] [-verbose]
		///
		/// Finds a routing solution between two nodes on an unrouted, or partially routed net, in an
		/// implemented design.
		/// This command can be used to define a routing path to assign to the FIXED_ROUTE property of a
		/// net, which can be saved to the XDC file for later reuse. Refer to Vivado Design Suite Tutorial:
		/// Implementation (UG986) for an example of manual routing and the use of the FIXED_ROUTE
		/// property.
		/// You must define nodes for the start and end points of the routing path, and can specify the
		/// maximum and minimum number of nodes to use for the route path, including the start and end
		/// points. The nodes must be specified as objects returned by the get_nodes command. For
		/// unrouted net objects, since nodes have not been assigned to the net, the nodes can be found by
		/// association of the net to the bel_pin or site_pin:
		/// • Net > Bel_Pin > Bel > Tile > Node
		/// • Net > Site_Pin > Tile > Node
		/// For partially routed nets, the nodes can be found associated directly to the net. Refer to the
		/// Vivado Design Suite Properties Reference Guide (UG912) for more information on the relationship
		/// between these objects.
		/// The find_routing_path command returns a list of nodes representing the route path found
		/// from the start point to the end point, or returns "no path found" if the command runs but has no
		/// result, or returns an error if the command fails to run.
		/// The returned list of nodes can be assigned to the FIXED_ROUTE property using the
		/// set_property command as shown in the example.
		/// TIP: The report_property command does not return the string of the FIXED_ROUTE property. Use the
		/// get_property command instead.
		///
		/// The following example finds a routing path for the specified net, using one end as the -from
		/// point and the other end as the -to point, and assigns that path to the specified Tcl variable. Then
		/// it uses that Tcl variable to assign the path to the FIXED_ROUTE property of the net:
		/// set fndPath [find_routing_path -from [lindex [get_nodes -of \
		/// [get_site_pins -of [get_nets wbOutputData_OBUF[14]]]] 0] -to \
		/// [lindex [get_nodes -of [get_site_pins -of \
		/// [get_nets wbOutputData_OBUF[14]]]] 1]]
		/// set_property FIXED_ROUTE $fndPath [get_nets wbOutputData_OBUF[14]]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 521
		/// </summary>
		/// <param name="allow_overlap">(Optional) Solution may include nodes used in existing routes.</param>
		/// <param name="max_nodes">
		/// (Optional)
		/// Specifies the maximum number of nodes (including from
		/// and to nodes) allowed in solution. Default: 100
		/// </param>
		/// <param name="min_nodes">
		/// (Optional)
		/// Specifies the minimum number of nodes (including from
		/// and to nodes) allowed in solution. Default: 2
		/// </param>
		/// <param name="from">(Optional) -from <start node> Start of routing path.</param>
		/// <param name="to">(Optional) -to <end node> End of routing path.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL find_routing_path(bool? allow_overlap = null, string max_nodes = null, string min_nodes = null, string from = null, string to = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: find_routing_path [-allow_overlap] [-max_nodes <arg>] [-min_nodes <arg>] [-from <args>] [-to <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.find_routing_path(allow_overlap, max_nodes, min_nodes, from, to, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Generate a set of configurable report objects
		///
		///
		/// TCL Syntax: generate_reports [-jobs <arg>] [-quiet] [-verbose] <report_configs>...
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
		/// <param name="report_configs">(Required) List of configurable report objects to generate</param>
		/// <param name="jobs">(Optional) Number of jobs Default: 1</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL generate_reports(string report_configs, string jobs = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_reports [-jobs <arg>] [-quiet] [-verbose] <report_configs>...
			_tcl.Entry(_builder.generate_reports(report_configs, jobs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of bel_pins. If a design is loaded, gets the constructed site type bels.
		///
		///
		/// TCL Syntax: get_bel_pins [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns a list of pins on the specified BELs, or matching a specified search pattern.
		/// The default command gets a list of all pins on all BELs on the device.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example returns the pins of the specified BELs associated with the specified range
		/// of sites on the device:
		/// get_bel_pins -of_objects [get_bels -of_objects [get_sites \
		/// -range {SLICE_X0Y0 SLICE_X1Y1}] ]
		/// The following example returns the clock enable (CE) pins of all BELs on the device:
		/// get_bel_pins *CE
		///
		/// See ug835-vivado-tcl-commands.pdf, page 581
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the bel_pin of these bels, sites, pins, or nets.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match bel_pin against patterns Default: *</param>
		/// <returns>bel_pin</returns>
		public TTCL get_bel_pins(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_bel_pins [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_bel_pins(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of bels. If a design is loaded, gets the constructed site type bels.
		///
		///
		/// TCL Syntax: get_bels [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-include_routing_bels] [-quiet] [-verbose] [<patterns>]
		///
		/// Basic Elements, or BELs, are building blocks of logic, such as flip-flops, LUTs, and carry logic, that
		/// make up a SLICE. This command returns a list of BELs on the target part that match a specified
		/// search pattern in an open design.
		/// The default command gets a list of all BELs on the device.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example returns the total number of BELs on the target part:
		/// llength [get_bels]
		/// The following example returns the BELs associated with the specified site:
		/// get_bels -of_objects [get_sites PHASER_IN_PHY_X0Y5]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 584
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the bels of these slr, tiles, sites, cells, clock_regions or nets.</param>
		/// <param name="include_routing_bels">(Optional) Also look for and include matching rbels.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match bels against patterns Default: *</param>
		/// <returns>bels</returns>
		public TTCL get_bels(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? include_routing_bels = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_bels [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-include_routing_bels] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_bels(regexp, nocase, filter, of_objects, include_routing_bels, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Gets the list of board bus net objects
		///
		///
		/// TCL Syntax: get_board_bus_nets [-regexp] [-nocase] [-all] [-filter <arg>] -of_objects <args> [-quiet] [-verbose] [<patterns>...]
		///
		/// Gets a list of individual connection bus nets of the specified connection bus object, or the board
		/// component or board component pin objects.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// Connection buses define the connections between the Xilinx device (part0) and other
		/// components on the board. Bus nets define individual connections of the connection bus.
		/// This command returns a list of connection bus nets, or returns an error if it fails.
		///
		/// The following example gets the connection bus nets associated with the specified component of
		/// the current board:
		/// get_board_bus_nets -of_objects [get_board_components {*iic_main*}]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 587
		/// </summary>
		/// <param name="of_objects">
		/// (Required)
		/// Get 'board_bus_net' objects of these types: 'board_bus
		/// board_component board_component_pin'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="all">(Optional) Returns all enabled as well as disabled buses</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// match board net names against patterns Default: * Values:
		/// The default search pattern is the wildcard *, or .* when -
		/// regexp is specified.
		/// </param>
		/// <returns>list of bus nets in the board</returns>
		public TTCL get_board_bus_nets(string of_objects, bool? regexp = null, bool? nocase = null, bool? all = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_board_bus_nets [-regexp] [-nocase] [-all] [-filter <arg>] -of_objects <args> [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_bus_nets(of_objects, regexp, nocase, all, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Gets the list of board bus objects
		///
		///
		/// TCL Syntax: get_board_buses [-regexp] [-nocase] [-all] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
		///
		/// Gets a list of connection buses defined on the current board, as defined in the Board Interface
		/// file.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// Connection buses define the connections between the Xilinx device (part0) and other
		/// components on the board.
		/// This command returns a list of buses, or returns an error if it fails.
		///
		/// The following example gets the connection buses associated with the specified component of
		/// the current board:
		/// get_board_buses -of_objects [get_board_components sgmii]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 590
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="all">(Optional) Returns all enabled as well as disabled buses</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'board_bus' objects of these types: 'board
		/// board_component board_bus_net'.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// match board bus names against patterns Default: * Values:
		/// The default search pattern is the wildcard *, or .* when -
		/// regexp is specified.
		/// </param>
		/// <returns>list of buses in the board</returns>
		public TTCL get_board_buses(bool? regexp = null, bool? nocase = null, bool? all = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_board_buses [-regexp] [-nocase] [-all] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_buses(regexp, nocase, all, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Gets the list of interfaces in the board components that implement busdef specified by VLNV
		///
		///
		/// TCL Syntax: get_board_component_interfaces [-regexp] [-nocase] [-all] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
		///
		/// Gets a list of interfaces defined on the components found on the current board, as defined in the
		/// Board Interface file.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, defined components and
		/// supported interfaces. You can create custom boards by defining a custom Board Interface file, as
		/// described in the Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// The component interface defines related groups of signals that are found on a component, or a
		/// component mode.
		/// This command returns a list of component interfaces, or returns an error if it fails.
		///
		/// The following example gets the component interfaces defined in the Board Interface file for the
		/// specified board component:
		/// get_board_component_interfaces -of_objects [get_board_components *part0*]
		/// The following example gets the component interfaces defined in the Board Interface file, and
		/// then uses that information to create interfaces in the current project:
		/// #Get and Create Interfaces for I/O Ports
		/// foreach x [get_board_component_interfaces] {
		/// create_interface $x }
		///
		/// See ug835-vivado-tcl-commands.pdf, page 593
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="all">(Optional) Returns all enabled as well as disabled interfaces</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'board_component_interface' objects of these types:
		/// 'board board_component'.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// Match Bus Interface names against patterns Default: *
		/// Values: The default search pattern is the wildcard *, or .*
		/// when -regexp is specified.
		/// </param>
		/// <returns>list of bus interfaces</returns>
		public TTCL get_board_component_interfaces(bool? regexp = null, bool? nocase = null, bool? all = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_board_component_interfaces [-regexp] [-nocase] [-all] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_component_interfaces(regexp, nocase, all, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Gets the list of component mode objects
		///
		///
		/// TCL Syntax: get_board_component_modes [-regexp] [-nocase] [-all] [-filter <arg>] -of_objects <args> [-quiet] [-verbose] [<patterns>...]
		///
		/// Gets a list of various component modes defined on the current board, as defined in the Board
		/// Interface file.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// The component mode defines various modes of operations that the components on a board may
		/// have, and the interfaces and preferred IP of those modes.
		/// This command returns a list of component modes, or returns an error if it fails.
		///
		/// The following example gets the component modes defined in the Board Interface file of the
		/// specified board:
		/// get_board_component_modes -of_objects [get_board_components *part0*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 596
		/// </summary>
		/// <param name="of_objects">(Required) Get 'board_component_mode' objects of these types: 'board_component'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="all">(Optional) Returns all enabled as well as disabled interfaces</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// match board component modes against patterns Default: *
		/// Values: The default search pattern is the wildcard *, or .*
		/// when -regexp is specified.
		/// </param>
		/// <returns>list of component modes in the board</returns>
		public TTCL get_board_component_modes(string of_objects, bool? regexp = null, bool? nocase = null, bool? all = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_board_component_modes [-regexp] [-nocase] [-all] [-filter <arg>] -of_objects <args> [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_component_modes(of_objects, regexp, nocase, all, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Gets the list of board_part pins object
		///
		///
		/// TCL Syntax: get_board_component_pins [-regexp] [-nocase] [-filter <arg>] -of_objects <args> [-quiet] [-verbose] [<patterns>...]
		///
		/// Gets a list of individual board component pins of the specified board component object of the
		/// current_board.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// Board components define the list of components found on the board defined by the Board
		/// Interface file. Component pins enumerate the individual pins of the component.
		/// This command returns a list of component pin objects, or returns an error if it fails.
		///
		/// The following example gets the component pins associated with the specified Xilinx device
		/// (part0) component object of the current board:
		/// get_board_component_pins -of_objects [get_board_components *part0*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 599
		/// </summary>
		/// <param name="of_objects">
		/// (Required)
		/// Get 'board_component_pin' objects of these types:
		/// 'board_component board_bus_net'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// match board component pin names against patterns
		/// Default: * Values: The default search pattern is the wildcard
		/// *, or .* when -regexp is specified.
		/// </param>
		/// <returns>list of pins in the board_part</returns>
		public TTCL get_board_component_pins(string of_objects, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_board_component_pins [-regexp] [-nocase] [-filter <arg>] -of_objects <args> [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_component_pins(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get the list of components available in the board
		///
		///
		/// TCL Syntax: get_board_components [-regexp] [-nocase] [-all] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
		///
		/// Gets a list of components defined on the current board, as defined in the Board Interface file.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// This command returns a list of components, or returns an error if it fails.
		///
		/// The following example gets the components defined in the Board Interface file of the specified
		/// board:
		/// get_board_components -of_objects [get_boards zed]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 602
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="all">(Optional) Returns all enabled as well as disabled components</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'board_component' objects of these types: 'board
		/// board_bus board_component_pin'.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// Match component names against patterns Default: *
		/// Values: The default search pattern is the wildcard *, or .*
		/// when -regexp is specified.
		/// </param>
		/// <returns>list of component objects</returns>
		public TTCL get_board_components(bool? regexp = null, bool? nocase = null, bool? all = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_board_components [-regexp] [-nocase] [-all] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_components(regexp, nocase, all, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Gets the list of interface ports object
		///
		///
		/// TCL Syntax: get_board_interface_ports [-regexp] [-nocase] [-filter <arg>] -of_objects <args> [-quiet] [-verbose] [<patterns>...]
		///
		/// Gets a list of various physical ports assigned to the component interfaces defined on the current
		/// board, as defined in the Board Interface file. The interface ports can be returned from component
		/// interfaces as specified by the get_board_component_interfaces command, or from the
		/// component pins returned by get_board_component_pins.
		/// The Board Interface file, board.xml located in the data/boards folder of the Vivado Design
		/// Suite installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// In the Board Interface file, a component interface includes a map of the logical ports, that are
		/// defined in the interface file, with a physical port that relates to the component pin or pins on the
		/// Xilinx device (part0).
		/// This command returns a list of the physical ports of the specified component interface, or returns
		/// an error if it fails.
		///
		/// The following example gets the board interface ports defined in the Board Interface file for the
		/// specified board component:
		/// get_board_interface_ports -of_objects \
		/// [get_board_component_interfaces *gmii*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 605
		/// </summary>
		/// <param name="of_objects">
		/// (Required)
		/// Get 'board_component_pin' objects of these types:
		/// 'board_component_interface board_component_pin'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// match interface port names against patterns Default: *
		/// Values: The default search pattern is the wildcard *, or .*
		/// when -regexp is specified.
		/// </param>
		/// <returns>list of ports in the given interface</returns>
		public TTCL get_board_interface_ports(string of_objects, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_board_interface_ports [-regexp] [-nocase] [-filter <arg>] -of_objects <args> [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_interface_ports(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Gets the list of ip preference objects
		///
		///
		/// TCL Syntax: get_board_ip_preferences [-regexp] [-nocase] [-filter <arg>] -of_objects <args> [-quiet] [-verbose] [<patterns>...]
		///
		/// Gets a list of IP preferences defined on the current board, as defined in the Board Interface file.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// IP preferences define the preferred IP to connect a component interface to in the Board Interface
		/// file.
		/// This command returns a list of preferred IP for specified component interfaces, or component
		/// modes, or returns an error if it fails.
		///
		/// The following example gets the IP preferences of the specified component interfaces:
		/// get_board_ip_preferences -of_objects \
		/// [get_board_component_interfaces *clock*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 608
		/// </summary>
		/// <param name="of_objects">
		/// (Required)
		/// Get 'ip_preference' objects of these types:
		/// 'board_component_mode board_component_interface'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// match ip preferences against patterns Default: * Values: The
		/// default search pattern is the wildcard *, or .* when -regexp
		/// is specified.
		/// </param>
		/// <returns>list of ip preferences for the component</returns>
		public TTCL get_board_ip_preferences(string of_objects, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_board_ip_preferences [-regexp] [-nocase] [-filter <arg>] -of_objects <args> [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_ip_preferences(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Gets the list of board jumper objects
		///
		///
		/// TCL Syntax: get_board_jumpers [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
		///
		/// Gets a list of jumpers defined on the current board, as defined in the Board Interface file.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// The jumpers defined in the board file can be used to enable specific component modes and
		/// interfaces of the board.
		/// This command returns a list of jumpers, or returns an error if it fails.
		///
		/// The following example gets the jumpers defined in the Board Interface file of the specified board:
		/// get_board_jumpers -of_objects [get_boards kc705]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 611
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'board_jumper' objects of these types: 'board'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// match jumper names against patterns Default: * Values:
		/// The default search pattern is the wildcard *, or .* when -
		/// regexp is specified.
		/// </param>
		/// <returns>list of jumpers in the board</returns>
		public TTCL get_board_jumpers(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_board_jumpers [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_jumpers(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Gets the list of board parameter objects
		///
		///
		/// TCL Syntax: get_board_parameters [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
		///
		/// Gets a list of parameters defined on the current board, as defined in the Board Interface file.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// The parameters defined in the board file specify custom or user-defined characteristics of the
		/// board.
		/// This command returns a list of board parameters, or returns an error if it fails.
		///
		/// The following example gets the parameters defined in the Board Interface file of the current
		/// board:
		/// get_board_parameters
		///
		/// See ug835-vivado-tcl-commands.pdf, page 614
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'board_parameter' objects of these types: 'board
		/// board_component board_component_interface'.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// match parameter names against patterns Default: * Values:
		/// The default search pattern is the wildcard *, or .* when -
		/// regexp is specified.
		/// </param>
		/// <returns>list of parameters in the board</returns>
		public TTCL get_board_parameters(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_board_parameters [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_parameters(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Gets the list of interfaces in the board_part that implement busdef specified by VLNV
		///
		///
		/// TCL Syntax: get_board_part_interfaces [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
		///
		/// Gets a list of interfaces defined on the Xilinx device, or current board part as defined by the
		/// BOARD_PART property, on the board in use by the current project or open design.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// The board part provides a representation of the Xilinx device in the context of the board-level
		/// system, and is represented by the part0 component in the Board Interface file. The
		/// current_board_part command returns the board part in use by the current project.
		/// The interfaces defined on the current board part define related groups of signals that can be used
		/// to quickly connect the elements of a block design in Vivado IP integrator, or configure IP from
		/// the Xilinx IP catalog. The interfaces available on the current_board_part can be used to
		/// define the interfaces required in an IP subsystem design, using create_bd_interface_port
		/// or create_bd_port. It can also be used to define the interfaces available in the overall FPGA
		/// design using create_interface and create_port.
		/// This command returns a list of available interfaces on the current board part, or returns an error
		/// if it fails.
		///
		/// The following example gets a list of all interfaces defined on the current board part:
		/// join [get_board_part_interfaces] \n
		///
		/// See ug835-vivado-tcl-commands.pdf, page 617
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'board_component_interface' objects of these types:
		/// 'board board_component'.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// Match Bus Interface names against patterns Default: *
		/// Values: The default search pattern is the wildcard *, or .*
		/// when -regexp is specified.
		/// </param>
		/// <returns>list of bus interfaces</returns>
		public TTCL get_board_part_interfaces(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_board_part_interfaces [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_part_interfaces(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Gets the list of board_part pins object
		///
		///
		/// TCL Syntax: get_board_part_pins [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
		///
		/// Gets a list of component pin objects on the current board part in use by the current project or
		/// design.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// The board part provides a representation of the Xilinx device in the context of the board-level
		/// system, and is represented by the part0 component in the Board Interface file. The
		/// current_board_part command returns the board part in use by the current project.
		/// The board part pin represents the component pin of an implemented interface on the Xilinx
		/// device. The component pin includes properties like LOC, IOSTANDARD, and SLEW. Board part
		/// pins can be scalar or vector, so it is always represented as bitwise.
		/// The board part pins can be used to define and place PORTS in the top-level FPGA design, using
		/// the create_port and set_property PACKAGE_PIN commands.
		/// This command returns a list of component pins, or returns an error if it fails.
		///
		/// This example returns the physical pins of the specified board part interface:
		/// get_board_part_pins -of [get_board_part_interfaces push_buttons_5bits]
		/// The following example assigns the PACKAGE_PIN and IOSTANDARD properties on the specified
		/// port in the current design according to the properties on the leds_8bits pins in the current board:
		/// set_property PACKAGE_PIN [get_property LOC \
		/// [get_board_part_pins leds_8bits_TRI_O[1]]] [get_ports LEDS_n[1]]
		/// set_property IOSTANDARD [get_property IOSTANDARD \
		/// [get_board_part_pins leds_8bits_TRI_O[1]]] [get_ports LEDS_n[1]]
		/// The following example gets a list of board part pins assigned to the leds_8bits board part
		/// interface; stores those pins in a Tcl variable $boardPins, and then prints the LOC property for
		/// each of those pins:
		/// set boardPins [get_board_part_pins -of \
		/// [get_board_part_interfaces -filter {NAME == led_8bits}]]
		/// foreach pin $boardPins {puts "The location of $pin is: \
		/// [get_property LOC $pin]"}
		/// The location of leds_8bits_tri_o[0] is: AB8
		/// The location of leds_8bits_tri_o[1] is: AA8
		/// The location of leds_8bits_tri_o[2] is: AC9
		/// The location of leds_8bits_tri_o[3] is: AB9
		/// The location of leds_8bits_tri_o[4] is: AE26
		/// The location of leds_8bits_tri_o[5] is: G19
		/// The location of leds_8bits_tri_o[6] is: E18
		/// The location of leds_8bits_tri_o[7] is: F16
		///
		/// See ug835-vivado-tcl-commands.pdf, page 621
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'board_component_pin' objects of these types:
		/// 'board_component_interface board_interface_port'.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// match board_part pin names against patterns Default: *
		/// Values: The default search pattern is the wildcard *, or .*
		/// when -regexp is specified.
		/// </param>
		/// <returns>list of pins in the board_part</returns>
		public TTCL get_board_part_pins(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_board_part_pins [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_part_pins(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get the list of board_part available in the project
		///
		///
		/// TCL Syntax: get_board_parts [-regexp] [-nocase] [-latest_file_version] [-latest_hw_revision] [-filter <arg>] [-quiet] [-verbose] [<patterns>...]
		///
		/// Gets a list of available board parts in the board repository, as defined by the Board Interface files
		/// available for use by the current project or design.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// The board part provides a representation of the Xilinx device in the context of the board-level
		/// system, and is represented by the part0 component in the Board Interface file. The
		/// current_board_part command returns the board part in use by the current project. Refer to
		/// the current_board_part command for the different methods of defining the board in use.
		/// This command returns the list of available Xilinx devices (part0) in the Board Interface files
		/// defined in the current board repository, or returns an error if it fails.
		///
		/// The following example returns the board parts matching the specified filter search pattern:
		/// get_board_parts -filter {BOARD_NAME=~z*}
		/// The following example returns all board parts matching the specified search patterns:
		/// get_board_parts {*av* *kc*}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 625
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="latest_file_version">(Optional) Show only latest board parts by file version</param>
		/// <param name="latest_hw_revision">(Optional) Show only latest board parts by board revision</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// Match Board Part names against patterns Default: * Values:
		/// The default search pattern is the wildcard *, or .* when -
		/// regexp is specified.
		/// </param>
		/// <returns>list of board_part objects</returns>
		public TTCL get_board_parts(bool? regexp = null, bool? nocase = null, bool? latest_file_version = null, bool? latest_hw_revision = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_board_parts [-regexp] [-nocase] [-latest_file_version] [-latest_hw_revision] [-filter <arg>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_parts(regexp, nocase, latest_file_version, latest_hw_revision, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get the list of boards available in the project
		///
		///
		/// TCL Syntax: get_boards [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
		///
		/// Gets a list of evaluation boards available for use by the current project.
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite
		/// installation area, stores information regarding board attributes. The board provides a
		/// representation of the overall system that the Xilinx device is a part of, and can help define key
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.
		/// You can create custom boards by defining a custom Board Interface file, as described in the
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).
		/// The board in use by the project is returned by the current_board_part command.
		/// The board can be specified:
		/// • When the project is created by selecting Boards from the Default Part dialog box.
		/// • By setting the BOARD property on the current project as shown in the example.
		/// • By selecting the Project Device in the Settings dialog box in an open project in the Vivado IDE.
		/// Refer to the Vivado Design Suite User Guide: System-Level Design Entry (UG895) for information on
		/// creating projects, and on configuring project settings.
		/// IMPORTANT! When you specify the board with the set_property command, the target part is also
		/// changed to match the part required by the specified BOARD property.
		/// This command returns a list of boards that are available for use by the current project, or returns
		/// an error if it fails.
		///
		/// The following example reports the properties of the specified evaluation board:
		/// report_property [get_boards -filter {LIBRARY_NAME==artix7}]
		/// The following example returns all boards matching the specified search patterns:
		/// get_boards {*ar* *kc*}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 629
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'board' objects of these types: 'board_component'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// Match Board names against patterns Default: * Values: The
		/// default search pattern is the wildcard *, or .* when -regexp
		/// is specified.
		/// </param>
		/// <returns>list of board objects</returns>
		public TTCL get_boards(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_boards [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_boards(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of CDC violations from a previous report_cdc run
		///
		///
		/// TCL Syntax: get_cdc_violations [-name <arg>] [-regexp] [-filter <arg>] [-nocase] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of violation objects found in the design when the report_cdc command is run. The
		/// properties of individual violation objects can be queried using report_property or
		/// list_property commands for details of the violation.
		/// Violation objects are associated with the clock-domain crossing paths in the current design. The
		/// design objects associated with a methodology violation object can be obtained using the -
		/// of_objects option of the appropriate get_* command, such as get_cells, or get_nets
		/// for instance.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example reports the CDC violations found in the current design, then returns a list
		/// of all those violations:
		/// report_cdc
		/// get_cdc_violations
		/// The following example generates list of violations in the named CDC report, and then gets the
		/// pins associated with any violations found:
		/// report_cdc -name cdc_1
		/// get_pins -of_objects [get_cdc_violations -name cdc_1]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 632
		/// </summary>
		/// <param name="name">(Optional) Get the results with this name</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// Match CDC violations against patterns Default: * Values: The
		/// default search pattern is the wildcard *, or .* when -regexp
		/// is specified.
		/// </param>
		/// <returns>list of CDC violation objects</returns>
		public TTCL get_cdc_violations(string name = null, bool? regexp = null, string filter = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_cdc_violations [-name <arg>] [-regexp] [-filter <arg>] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_cdc_violations(name, regexp, filter, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of cells in the current design
		///
		///
		/// TCL Syntax: get_cells [-hsc <arg>] [-hierarchical] [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-include_replicated_objects] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of cell objects in the current design that match a specified search pattern. The default
		/// command returns a list of all cells in the current_instance of the open design, as specified by the
		/// current_instance command.
		/// You can use the -hierarchical option to extract cells from the hierarchy of the current
		/// design.
		/// The get_cells command also includes an option to get all replicated cells that are added to a
		/// design during physical optimization, or phys_opt_design. The use of the -
		/// include_replicated_objects option returns the replicated cells of an object when the
		/// original cell is returned. You can use this option to ensure that constraints or properties that are
		/// applied to a cell are also applied to its replicated cells.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example uses regular expression to return cells in the BFT example design that
		/// match the filter expressions for NAME and REF_NAME. In the first command the NAME is
		/// specified in the search pattern, while the second command filters on the NAME property. These
		/// commands return the same results:
		/// get_cells -regexp -filter { REF_NAME =~ FD.* } .*validFor.*
		/// get_cells -regexp -filter { NAME =~ .*validFor.* && REF_NAME =~ FD.* }
		/// The following example searches all levels of the hierarchy for cells beginning with cpu, or fft, and
		/// joins each cell returned with the newline character to put it on a separate line:
		/// join [get_cells -hier {cpu* fft*}] \n
		/// This example gets a list of properties and property values attached to the second object of the
		/// list returned by get_cells:
		/// report_property [lindex [get_cells] 1]
		/// Note: If there are no cells matching the pattern you will get a warning.
		/// This example prints a list of the library cells instantiated into the design at all levels of the
		/// hierarchy, sorting the list for unique names so that each cell is only printed one time:
		/// foreach cell [lsort -unique [get_property LIB_CELL [get_cells -hier \
		/// -filter {IS_PRIMITIVE==1}]]] {puts $cell}
		/// The following example demonstrates the effect of -hierarchical searches, without and with
		/// -regexp:
		/// get_cells -hierarchical *mmcm*
		/// mmcm_replicator_inst_1
		/// mmcm_replicator_inst_1/mmcm_stage[0].mmcm_channel[0].mmcm
		/// get_cells -hierarchical -regexp .*mmcm.*
		/// mmcm_replicator_inst_1
		/// mmcm_replicator_inst_1/mmcm_stage[0].mmcm_channel[0].mmcm
		/// mmcm_replicator_inst_1/mmcm_stage[0].mmcm_channel[0].mmcm/GND
		/// mmcm_replicator_inst_1/mmcm_stage[0].mmcm_channel[0].mmcm/MMCM_Base
		/// Note: The last two cells (GND and MMCM_Base) were not returned in the first example (without -
		/// regexp) because the cell names do not match the search pattern, as it is applied to each level of the
		/// hierarchy.
		/// The following example runs the report_drc command on the current design, and returns any
		/// cells associated with DRC violations:
		/// report_drc -name drc_1
		/// get_cells -of_objects [get_drc_violations]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 635
		/// </summary>
		/// <param name="hsc">(Optional) Hierarchy separator Default: /</param>
		/// <param name="hierarchical">(Optional) Search level-by-level in current instance</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get cells of these pins, timing paths, nets, bels, clock
		/// regions, sites, or drc violations
		/// </param>
		/// <param name="match_style">(Optional) Style of pattern matching Default: sdc Values: ucf, sdc</param>
		/// <param name="include_replicated_objects">
		/// (Optional)
		/// Include replicated objects when searching for patterns. This
		/// option is valid only when patterns is specified.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match cell names against patterns Default: *</param>
		/// <returns>list of cell objects</returns>
		public TTCL get_cells(string hsc = null, bool? hierarchical = null, bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, string match_style = null, bool? include_replicated_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_cells [-hsc <arg>] [-hierarchical] [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-include_replicated_objects] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_cells(hsc, hierarchical, regexp, nocase, filter, of_objects, match_style, include_replicated_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of cfgmem_parts available in the software
		///
		///
		/// TCL Syntax: get_cfgmem_parts [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Get a list of configuration flash memory devices supported by the Vivado Design Suite or Vivado
		/// Lab Edition.
		/// Xilinx® FPGAs can be configured from an external nonvolatile memory device, or they can be
		/// configured by an external smart source, such as a microprocessor, DSP processor,
		/// microcontroller, PC, or board tester. The two configuration datapaths include a serial datapath
		/// that is used to minimize the device pin requirements for configuration, and a parallel 8-bit, 16-bit,
		/// or 32-bit datapath used for higher performance or link to industry-standard interfaces ideal for
		/// external data sources like processors, or x8- or x16-parallel flash memory.
		/// The process whereby the design specific data is loaded or programmed into the Xilinx FPGA is
		/// called configuration. The create_hw_cfgmem command defines a flash memory device used
		/// for configuring and booting the hardware device.
		/// After the hw_cfgmem object is created, and associated with the hw_device, the configuration
		/// memory can be programmed with the bitstream and other data from a memory configuration file
		/// created with the write_cfgmem command. The hw_cfgmem object is programmed using the
		/// program_hw_cfgmem command.
		/// The configuration memory part can be used to define the hardware configuration memory in the
		/// Hardware Manager of the Vivado Design Suite, to enable programming and debugging the design
		/// in the FPGA hardware. Use the create_hw_cfgmem command to define the configuration
		/// memory for use with the current hardware device.
		/// This command returns a list of cfgmem_part objects that match the specified search criteria, or
		/// returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 640
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'cfgmem_part' objects of these types: 'part hw_device'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'cfgmem_part' objects against patterns. Default: *</param>
		/// <returns>list of cfgmem_part objects</returns>
		public TTCL get_cfgmem_parts(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_cfgmem_parts [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_cfgmem_parts(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get the clock regions for the current device.
		///
		///
		/// TCL Syntax: get_clock_regions [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of clock regions on the target part that match a specified search pattern. The default
		/// command gets a list of all clock regions on the device in an open design.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example returns the clock regions matching the search pattern:
		/// get_clock_regions X0*
		/// The following example returns the clock regions filtered by the specified property:
		/// get_clock_regions -filter {LOW_X==0}
		/// Note: These two examples return the same set of clock regions.
		/// The following example returns the clock regions that the specified ILA debug core trigger is
		/// assigned to, or placed in:
		/// get_clock_regions -of_objects [get_cells -hierarchical basic_trigger*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 644
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions.</param>
		/// <param name="nocase">
		/// (Optional)
		/// Perform case-insensitive matching. (valid only when -regexp
		/// specified).
		/// </param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get the clock_regions of these tiles, sites, slrs, cells, or
		/// package bank
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match objects' name against patterns. Default: *</param>
		/// <returns>clock_regions</returns>
		public TTCL get_clock_regions(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_clock_regions [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_clock_regions(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of clocks in the current design
		///
		///
		/// TCL Syntax: get_clocks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-include_generated_clocks] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of clocks in the current design that match a specified search pattern. The default
		/// command gets a list of all clocks in the design, like the all_clocks command.
		/// Clocks can be created using the create_clock or the create_generated_clock
		/// commands, or can be automatically generated by the tool, at the output of an MMCM for
		/// instance.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of clocks matching the various search patterns:
		/// get_clocks {*clock *ck *Clk}
		/// Note: If there are no clocks matching the pattern you will get a warning.
		/// The following example gets the master clock object, and all generated clocks derived from that
		/// clock:
		/// get_clocks -include_generated_clocks wbClk
		/// The following example gets all properties and property values attached to the specified clock:
		/// report_property -all [get_clocks wbClk]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 647
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get clocks of these pins, nets, or cells</param>
		/// <param name="match_style">(Optional) Style of pattern matching, valid values are ucf, sdc Default: sdc</param>
		/// <param name="include_generated_clocks">(Optional) Include auto-inferred/generated_clocks also.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match clock names against patterns Default: *</param>
		/// <returns>list of clocks</returns>
		public TTCL get_clocks(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, string match_style = null, bool? include_generated_clocks = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_clocks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-include_generated_clocks] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_clocks(regexp, nocase, filter, of_objects, match_style, include_generated_clocks, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Create the Project summary dashboard
		///
		///
		/// TCL Syntax: get_dashboard_gadgets [-quiet] [-verbose] [<patterns>...]
		///
		/// Gets a list of the dashboard gadgets in the current project.
		///
		/// The following example returns the dashboard gadgets in the current project:
		/// get_dashboard_gadgets
		///
		/// See ug835-vivado-tcl-commands.pdf, page 651
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// Match gadget names against patterns Default: * Values: The
		/// default search pattern is the wildcard *
		/// </param>
		public TTCL get_dashboard_gadgets(bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_dashboard_gadgets [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_dashboard_gadgets(quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of debug cores in the current design
		///
		///
		/// TCL Syntax: get_debug_cores [-filter <arg>] [-of_objects <args>] [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of Vivado Lab Edition debug cores in the current project that match a specified search
		/// pattern. The default command gets a list of all debug cores in the project.
		/// Debug cores are added to the project with the create_debug_core command. When a ILA
		/// debug core (labtools_ila_v3) is added to the project, it is contained within a Debug Hub core
		/// (labtools_xsdbmasterlib_v2), and includes a CLK port and a PROBE port as a default. Additional
		/// ports can be added to the debug core with the use of the create_debug_port command.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following command gets a list of the Vivado Lab Edition debug cores in the current project:
		/// get_debug_cores
		/// Note: A Debug Hub core is returned as one of the debug cores in the project. You cannot directly create
		/// this core, but it is automatically added by the tool when you add any ILA cores to the project.
		/// The following example gets the properties of the specified debug core:
		/// report_property [get_debug_cores myCore]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 653
		/// </summary>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get cores of these debug ports or nets</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match debug cores against patterns Default: *</param>
		/// <returns>list of debug_core objects</returns>
		public TTCL get_debug_cores(string filter = null, string of_objects = null, bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_debug_cores [-filter <arg>] [-of_objects <args>] [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_debug_cores(filter, of_objects, regexp, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of debug ports in the current design
		///
		///
		/// TCL Syntax: get_debug_ports [-filter <arg>] [-of_objects <args>] [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of ports defined on ILA debug cores in the current project that match a specified
		/// search pattern. The default command gets a list of all debug ports in the project.
		/// Debug ports are defined when ILA debug cores are created with the create_debug_core
		/// command. Ports can be added to existing debug cores with the create_debug_port
		/// command.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following command gets a list of the ports from the ILA debug cores in the current project,
		/// with a PORT_WIDTH property of 8:
		/// get_debug_ports -filter {PORT_WIDTH==8}
		/// The following example gets the properties attached to the specified debug port:
		/// report_property [get_debug_ports myCore/PROBE1]
		/// Note: The debug port is defined by the core_name/port_name combination.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 656
		/// </summary>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get ports of these debug cores</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match debug ports against patterns Default: *</param>
		/// <returns>list of debug_port objects</returns>
		public TTCL get_debug_ports(string filter = null, string of_objects = null, bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_debug_ports [-filter <arg>] [-of_objects <args>] [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_debug_ports(filter, of_objects, regexp, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of designs in the current project
		///
		///
		/// TCL Syntax: get_designs [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of open designs in the current project that match a specified search pattern. The
		/// default command gets a list of all open designs in the project.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets all open designs in the current project:
		/// get_designs
		/// The following example gets the assigned properties of an open design matching the search
		/// pattern:
		/// report_property [get_designs r*]
		/// Note: If there are no designs matching the pattern you will get a warning.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 659
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match design names against patterns Default: *</param>
		/// <returns>list of design objects</returns>
		public TTCL get_designs(bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_designs [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_designs(regexp, nocase, filter, quiet, verbose, patterns));
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
		/// Get a list of source files
		///
		///
		/// TCL Syntax: get_files [-regexp] [-nocase] [-filter <arg>] [-compile_order <arg>] [-used_in <arg>] [-references] [-all] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of files in the current project that match a specified search pattern. The default
		/// command gets a list of all files in the project.
		/// The get_files command returns a machine readable list of files in the project, in a design, or in
		/// a sub-design such as an IP core or block design. You can filter the results returned by
		/// get_files using one of the command arguments such as -of_objects, -compile_order,
		/// -used_in, and -filter.
		/// The -compile_order and -used_in options must be used together to return a list of files
		/// from the sources or constraints filesets used in synthesis, simulation, or implementation, sorted
		/// according to the order of evaluation by the Vivado tools. The -compile_order and -used_in
		/// options use complex file ordering rules that can change based on header files, include files, or
		/// other language options. You can also filter files returned by get_files according to the
		/// USED_IN property, using the -filter option instead of the -used_in option.
		/// You can use the report_compile_order command to generate a report of all files in the
		/// sources or constraints filesets, used in synthesis, simulation, AND implementation, sorted into
		/// different sections.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example returns the VHDL files in the design that are used in simulation:
		/// get_files -filter {FILE_TYPE == VHDL && USED_IN =~ simulation*}
		/// This example returns the design source files that are used in simulation:
		/// get_files -compile_order sources -used_in simulation
		/// This example gets a list of files associated with the specified IP core composite file (ip.xci), from
		/// the sources_1 fileset that are used in synthesis:
		/// get_files -compile_order sources -used_in synthesis -of [get_files ip.xci]
		/// The following example gets a list of the files found in the sources_1 and constrs_1 filesets:
		/// get_files -of [get_filesets {sources_1 constrs_1}]
		/// Note: If there are no files matching the pattern you will get a warning.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 675
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="compile_order">(Optional) Get files by type and in compilation order (must use with - used_in)</param>
		/// <param name="used_in">(Optional) Get files used in a specific step (must use with - compile_order)</param>
		/// <param name="references">
		/// (Optional)
		/// Get files referenced in the provided objects (must use with -
		/// of_objects)
		/// </param>
		/// <param name="all">(Optional) Include all internal files.</param>
		/// <param name="of_objects">(Optional) Get 'file' objects of these types: 'file fileset ip reconfig_module'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match file names against patterns Default: *</param>
		/// <returns>list of file objects</returns>
		public TTCL get_files(bool? regexp = null, bool? nocase = null, string filter = null, string compile_order = null, string used_in = null, bool? references = null, bool? all = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_files [-regexp] [-nocase] [-filter <arg>] [-compile_order <arg>] [-used_in <arg>] [-references] [-all] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_files(regexp, nocase, filter, compile_order, used_in, references, all, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of filesets in the current project
		///
		///
		/// TCL Syntax: get_filesets [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of filesets in the current project that match a specified search pattern. The default
		/// command gets a list of all filesets in the project.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example returns the source files in the Source Set:
		/// get_files -of_objects [get_filesets sources_1]
		/// The following example makes project_2 the active project, and then gets a list of filesets
		/// beginning with the letter s or the letter r:
		/// current_project project_2
		/// get_filesets s* r* -quiet
		/// Note: If there are no filesets matching the pattern, such as r*, you will get a warning that no filesets
		/// matched the specified pattern. However, in the above example the use of -quiet will suppress that
		/// warning message.
		/// The following example gets filesets beginning with the letter C, using a case insensitive regular
		/// expression:
		/// get_filesets C.* -regexp -nocase
		/// In the above example, constrs_1 and constrs_2 constraint sets would be returned if defined in
		/// the current project.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 679
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'fileset' objects of these types: 'reconfig_module'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match fileset names against patterns Default: *</param>
		/// <returns>list of fileset objects</returns>
		public TTCL get_filesets(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_filesets [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_filesets(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of generated clocks in the current design
		///
		///
		/// TCL Syntax: get_generated_clocks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of generated clocks in the current project that match a specified search pattern. The
		/// default command gets a list of all generated clocks in the project.
		/// A generated clock can be added to the design using the create_generated_clock
		/// command, or can be automatically generated by the tool, at the output of an MMCM for
		/// instance.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets the names of all generated clocks in the current project:
		/// get_generated_clocks
		///
		/// See ug835-vivado-tcl-commands.pdf, page 682
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get generated clocks of these pins, ports or nets</param>
		/// <param name="match_style">(Optional) Style of pattern matching, valid values are ucf, sdc Default: sdc</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match generated clock names against patterns Default: *</param>
		/// <returns>list of clocks</returns>
		public TTCL get_generated_clocks(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, string match_style = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_generated_clocks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_generated_clocks(regexp, nocase, filter, of_objects, match_style, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get highlighted objects
		///
		///
		/// TCL Syntax: get_highlighted_objects [-color_index <arg>] [-rgb <args>] [-color <arg>] [-quiet] [-verbose]
		///
		/// Gets the highlighted objects in the current design open in the Vivado IDE. Objects can be
		/// highlighted with the highlight_objects command.
		/// You can get all highlighted objects in the design, or specify highlighted objects by color, by color
		/// index, or by RGB value.
		/// Note: This Tcl command works only when Vivado is run in GUI mode.
		///
		/// The following example gets all the highlighted objects in the current design:
		/// get_highlighted_objects
		/// The following example gets the object in the current design that are highlighted in the specified
		/// color:
		/// get_highlighted_objects -color cyan
		///
		/// See ug835-vivado-tcl-commands.pdf, page 690
		/// </summary>
		/// <param name="color_index">(Optional) Color index</param>
		/// <param name="rgb">(Optional) RGB color index list</param>
		/// <param name="color">(Optional) Valid values are red green blue magenta yellow cyan and orange</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of highlighted objects</returns>
		public TTCL get_highlighted_objects(string color_index = null, string rgb = null, string color = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_highlighted_objects [-color_index <arg>] [-rgb <args>] [-color <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_highlighted_objects(color_index, rgb, color, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of hardware AXI transactions.
		///
		///
		/// TCL Syntax: get_hw_axi_txns [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the read or write transactions for the specified JTAG to AXI Master core, hw_axi object.
		/// The JTAG to AXI Master is a customizable IP core that works as an AXI Master to drive AXI
		/// transactions and drive AXI signals that are internal to the hardware device. This IP can be used in
		/// Vivado® IP integrator or can be instantiated in HDL in a Vivado project.
		/// The JTAG-AXI core supports all memory-mapped AXI interfaces, except AXI4-Stream, and
		/// supports the AXI-Lite protocol. The AXI interface can be selected as a property of the core. The
		/// width of AXI data bus is customizable. This IP can drive any AXI4-Lite or Memory Mapped Slave
		/// directly, and can also be connected as the AXI Master to the interconnect. Run-time interaction
		/// with this core requires the use of the Vivado logic analyzer feature. Detailed documentation on
		/// the IP core can be found in the LogiCORE IP JTAG to AXI Master Product Guide (PG174). A tutorial
		/// showing its use can be found in the Vivado Design Suite Tutorial: Programming and Debugging
		/// (UG936).
		/// The JTAG to AXI Master core must be instantiated in the RTL code, from the Xilinx IP catalog.
		/// AXI transactions are defined as complete READ or WRITE transactions between the AXI master
		/// and various slaves.
		/// This command returns a list of hw_axi_txn objects on the hw_device, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 692
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_axi_txn' objects of these types: 'hw_axi'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_axi_txn' objects against patterns. Default: *</param>
		/// <returns>hw_axi_txns</returns>
		public TTCL get_hw_axi_txns(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_axi_txns [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_axi_txns(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of hardware AXI objects.
		///
		///
		/// TCL Syntax: get_hw_axis [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the JTAG to AXI Master core objects, or hw_axi objects, defined on the current hardware
		/// device.
		/// The JTAG to AXI Master is a customizable IP core that works as an AXI Master to drive AXI
		/// transactions and drive AXI signals that are internal to the hardware device. This IP can be used in
		/// Vivado® IP integrator or can be instantiated from the Xilinx® IP catalog into the HDL of a Vivado
		/// project. Run-time interaction with this core requires the use of the Vivado logic analyzer feature.
		/// The JTAG-AXI core supports all memory-mapped AXI interfaces, except AXI4-Stream, and
		/// supports the AXI-Lite protocol. The AXI interface can be defined as a property of the core. The
		/// width of the AXI data bus is customizable. This IP can drive any AXI4-Lite or Memory Mapped
		/// Slave directly, and can also be connected as the AXI Master to the interconnect. Detailed
		/// documentation on the IP core can be found in the LogiCORE IP JTAG to AXI Master Product Guide
		/// (PG174). A tutorial showing its use can be found in the Vivado Design Suite Tutorial: Programming
		/// and Debugging (UG936).
		/// AXI cores can be found in the synthesized or implemented design netlist using the
		/// get_debug_cores command. This will return instances of the debug cores in the design that
		/// are related to the hw_axi objects, and other debug cores on the hw_device.
		/// This command returns a list of AXI Master core objects, hw_axis, on the hw_device, or returns an
		/// error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 695
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_axi' objects of these types: 'hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_axi' objects against patterns. Default: *</param>
		/// <returns>hw_axi</returns>
		public TTCL get_hw_axis(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_axis [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_axis(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of hardware cfgmems.
		///
		///
		/// TCL Syntax: get_hw_cfgmems [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Get a list of hardware configuration memory (hw_cfgmem) objects created for the current
		/// hw_device.
		/// Xilinx FPGAs are configured by loading design-specific configuration data, in the form of a
		/// bitstream file, into the internal memory of the hw_device. The hw_cfgmem defines a flash
		/// memory device used for configuring and booting the Xilinx FPGA device. Once the hw_cfgmem
		/// object is created, and associated with the hw_device, the configuration memory can be
		/// programmed with the bitstream and other data using the program_hw_cfgmem command.
		/// The hw_cfgmem object is associated with the specified hw_device object through the
		/// PROGRAM.HW_CFGMEM property on the device object. The get_hw_cfgmems command lets
		/// you work with the hw_cfgmem object.
		/// This command returns a list of hw_cfgmem objects that match the specified search criteria, or
		/// returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 698
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_cfgmem' objects against patterns. Default: *</param>
		/// <returns>hardware cfgmems</returns>
		public TTCL get_hw_cfgmems(bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_cfgmems [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_cfgmems(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of Versal integrated and soft DDRMC cores.
		///
		///
		/// TCL Syntax: get_hw_ddrmcs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Xilinx Versal devices include integrated DDR Memory Controllers (DDRMC), as well as fabric
		/// based memory controllers. Refer to the LogiCore IP Product Guide: Versal ACAP Network on Chip
		/// and Integrated Memory Controller (PG313) for more information on the integrated controller core.
		/// Refer to Versal ACAP Soft DDR4 Memory IP (PG353) for more information on the fabric based
		/// memory controller. The memory controllers contain memory configuration and memory
		/// calibration data that can be accessed from the Xilinx Vivado Hardware Manager. The calibration
		/// and margin data are organized and presented in a graphical format for ease of analysis.
		/// The get_hw_ddrmc command returns a list of memory cores on the current hardware device.
		///
		/// The following example returns the HBM with the specified DISPLAY_NAME:
		/// get_hw_hbms -filter {DISPLAY_NAME == HBM_2}
		/// The following example returns the DDRMC with the specified DISPLAY_NAME:
		/// get_hw_ddrmcs -filter {DISPLAY_NAME == DDRMC_1}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 701
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_ddrmc' objects of these types: 'hw_server
		/// hw_target hw_device'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_ddrmc' objects against patterns. Default: *</param>
		/// <returns>integrated and soft DDRMC cores</returns>
		public TTCL get_hw_ddrmcs(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_ddrmcs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_ddrmcs(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of hardware devices.
		///
		///
		/// TCL Syntax: get_hw_devices [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the hardware devices on the open target of a connected hardware server.
		/// Each hardware target can have one or more Xilinx devices to program, or to use for debugging
		/// purposes. The current device is specified or returned by the current_hw_device command.
		/// This command returns a list of available hardware device objects, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 704
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_device' objects of these types: 'hw_target'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_device' objects against patterns. Default: *</param>
		/// <returns>hardware devices</returns>
		public TTCL get_hw_devices(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_devices [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_devices(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware HBM cores.
		///
		///
		/// TCL Syntax: get_hw_hbms [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Certain Xilinx® UltraScale+ devices include an integrated High-Bandwidth Memory (HBM)
		/// controller. Refer to the LogiCore IP Product Guide: AXI High Bandwidth Memory Controller
		/// (PG276) for more information on this core. The HBM controller and memory stacks contain both
		/// performance counters and temperature sensors that can be accessed through an HBM activity
		/// monitor (amon) from within the Xilinx Vivado hardware manager. The HBM activity monitor can
		/// be used to gain real-time access to performance monitoring and temperature sensors on the
		/// physical device. The Vivado hardware manager displays read, write, and overall throughput of
		/// data, as well as the device temperature. The activity monitor displays, captures, and exports data
		/// to a CSV file when it is running.
		/// The get_hw_hbms command returns a list of HBM cores on the current hardware target.
		///
		/// The following example returns the HBM with the specified DISPLAY_NAME:
		/// get_hw_hbms -filter {DISPLAY_NAME == HBM_2}
		/// This example returns all the HBM objects in the current device:
		/// get_hw_hbms
		///
		/// See ug835-vivado-tcl-commands.pdf, page 707
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_hbm' objects of these types: 'hw_server hw_target hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_hbm' objects against patterns. Default: *</param>
		/// <returns>hardware HBM cores</returns>
		public TTCL get_hw_hbms(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_hbms [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_hbms(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of hardware ILA data objects.
		///
		///
		/// TCL Syntax: get_hw_ila_datas [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the ILA data objects in the Vivado logic analyzer.
		/// The upload_hw_ila_data command creates a hw_ila_data object in the process of moving
		/// the captured data from the ILA debug core, hw_ila, on the physical FPGA device, hw_device. The
		/// read_hw_ila_data command can also create a hw_ila_data object when reading an ILA data
		/// file from disk.
		/// The hw_ila_data object can be viewed in the waveform viewer of the Vivado logic analyzer by
		/// using the display_hw_ila_data command, and can be written to disk using the
		/// write_hw_ila_data command.
		/// This command returns a list of available hardware ILA data objects, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 710
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_ila_data' objects of these types: 'hw_ila hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_ila_data' objects against patterns. Default: *</param>
		/// <returns>hardware ILA data</returns>
		public TTCL get_hw_ila_datas(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_ila_datas [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_ila_datas(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of hardware ILA.
		///
		///
		/// TCL Syntax: get_hw_ilas [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the ILA debug core objects defined on the current hardware device.
		/// The Integrated Logic Analyzer (ILA) debug core lets you perform in-system debug of
		/// implemented designs, or design bitstreams, on a programmed Xilinx FPGA. The ILA core includes
		/// many advanced features of modern logic analyzers, including boolean trigger equations, and edge
		/// transition triggers. You can use the ILA core to probe specific signals of the design, to trigger on
		/// programmed hardware events, and capture data from the Xilinx FPGA in real-time. Refer to
		/// LogiCORE IP Integrated Logic Analyzer (PG172) for details of the ILA core.
		/// You can add ILA debug cores into the RTL source files of a design, or in the synthesized netlist
		/// using the create_debug_core command. Refer to the Vivado Design Suite User Guide: Vivado
		/// Programming and Debugging (UG908) for more information on adding debug cores and signal
		/// probes to the design. You can get the debug cores in the synthesized netlist by using the
		/// get_debug_core commands. However, though they are related, the design debug cores are
		/// separate from the hardware debug cores found in the Hardware Manager feature of the Vivado
		/// Design Suite.
		/// Debug cores and probes are written to the probes file (.ltx) using the write_debug_probes
		/// command and associated with the hardware device, along with the bitstream file (.bit), using
		/// the PROBES.FILE and PROGRAM.FILE properties of the hw_device object. The hardware device
		/// is programmed with this information using the program_hw_devices command.
		/// The steps to debug your design in hardware using an ILA debug core are:
		/// 1. Connect to the hardware server and target using connect_hw_server and
		/// open_hw_target.
		/// 2. Program the FPGA with the bitstream (.bit) and probes (.ltx) files using
		/// program_hw_devices.
		/// 3. Set up the ILA debug core trigger and capture controls using set_property to set
		/// properties of the ILA.
		/// 4. Arm the ILA debug core trigger using run_hw_ila.
		/// 5. View the captured data from the ILA debug core in the Waveform window of the Vivado
		/// logic analyzer feature using display_hw_ila_data.
		/// 6. Optionally use the VIO debug core to drive control signals and/or view design status signals.
		/// See get_hw_vios for more information.
		/// 7. Optionally use the JTAG-to-AXI Master debug core to run transactions to interact with
		/// various AXI slave cores in your design. See get_hw_axis for more information.
		/// This command returns a list of ILA debug core objects on the device, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 713
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_ila' objects of these types: 'hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_ila' objects against patterns. Default: *</param>
		/// <returns>hardware ILAs</returns>
		public TTCL get_hw_ilas(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_ilas [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_ilas(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware Migs cores.
		///
		///
		/// TCL Syntax: get_hw_migs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the hw_mig objects on the current hardware device.
		/// Memory IP included in the Xilinx IP catalog are used to generate memory controllers and
		/// interfaces for Xilinx® devices. Memory IP includes different IP cores from the Xilinx IP catalog
		/// depending on the device architecture and memory interface specified. Refer to Zynq-7000 SoC
		/// and 7 Series Devices Memory Interface Solutions (UG586), or UltraScale Architecture-Based FPGAs
		/// Memory Interface Solutions (PG150), for details of the available memory IP.
		/// When added to a design, the memory IP needs to be implemented into the design. This occurs
		/// after the design is synthesized, during the design optimization phase of implementation, or
		/// opt_design, or can be done manually with the implement_mig_cores command.
		/// A memory controller can be debug enabled when added into the design from the Xilinx IP
		/// catalog. In the Vivado logic analyzer, or the Vivado Lab Edition, memory controllers implemented
		/// into a design are associated with hw_mig objects, one hw_mig object per debug-enabled memory
		/// controller. The hw_mig object will have all the properties needed to get the calibration status and
		/// draw the per-bit eye margin views.
		/// In the Vivado logic analyzer, or Vivado Lab Edition, the hw_mig object lets you verify the
		/// calibration and read window margins in your memory interface design. You can use the hardware
		/// manager GUI to check the calibration status, verify the read margin for both rising and falling
		/// edges of the clock or DQS. You can also use an ILA core to verify the data integrity for the read
		/// and write operations.
		/// This command returns a list of hw_mig objects on the current hardware device, or returns an
		/// error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 717
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_mig' objects of these types: 'hw_server hw_target hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_mig' objects against patterns. Default: *</param>
		/// <returns>hardware migs cores</returns>
		public TTCL get_hw_migs(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_migs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_migs(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of hardware probes.
		///
		///
		/// TCL Syntax: get_hw_probes [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the hw_probe objects in the Hardware Manager that are defined on signals in the design,
		/// or that are assigned to the specified ILA or VIO debug cores.
		/// You can add ILA and VIO debug cores in the RTL source files of a design by customizing the core
		/// from the IP catalog, or add ILA debug cores into the synthesized netlist using the
		/// create_debug_core command.
		/// Signals in the design can be probed to monitor signal values and track hardware events on the
		/// FPGA device. Debug probes can be added to ILA debug cores in the synthesized netlist design
		/// using the create_debug_port command, and connected to signals in the design using
		/// connect_debug_port. Probes can only be added to VIO debug cores when the IP core is
		/// customized, or re-customized, from the IP catalog, and signals connected to it in the RTL design.
		/// Refer to the Vivado Design Suite User Guide: Vivado Programming and Debugging (UG908) for more
		/// information on adding ILA and VIO debug cores and signal probes to the design.
		/// Debug cores and probes are written to a probes file (.ltx) with write_debug_probes, and
		/// associated with the hardware device, along with the bitstream file (.bit), using the PROBES.FILE
		/// and PROGRAM.FILE properties of the hw_device object. The hardware device is programmed
		/// with this information using the program_hw_devices command.
		/// This command returns a list of debug probe objects on the device, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 721
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_probe' objects of these types: 'hw_interface hw_ila hw_vio'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_probe' objects against patterns. Default: *</param>
		/// <returns>hardware probes</returns>
		public TTCL get_hw_probes(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_probes [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_probes(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of hardware servers.
		///
		///
		/// TCL Syntax: get_hw_servers [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// IMPORTANT! You must use the open_hw command to open the Hardware Manager in the Vivado Design
		/// Suite before using this command.
		/// This command returns hardware server objects that are connected to the current instance of the
		/// Vivado Design Suite through the use of the connect_hw_server command.
		/// Hardware servers are instances of the Xilinx hardware server (hw_server) application running
		/// remotely, or on the local machine. The hardware server manages connections to a hardware
		/// target, for instance a hardware board containing a JTAG chain of one or more Xilinx devices to be
		/// used for programming and debugging your FPGA design.
		/// This command returns a list of connected hardware server objects.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 725
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_server' objects against patterns. Default: *</param>
		/// <returns>hardware servers</returns>
		public TTCL get_hw_servers(bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_servers [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_servers(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO GT commons.
		///
		///
		/// TCL Syntax: get_hw_sio_commons [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the QPLL objects, hw_sio_commons, defined on the IBERT debug core on the current
		/// hardware device.
		/// For each serial transceiver channel, there is a ring PLL called Channel PLL (CPLL). In Xilinx
		/// UltraScale and 7 series FPGAs, the high-speed transceivers have an additional common or shared
		/// PLL per quad, or Quad PLL (QPLL). This QPLL is a shared LC PLL to support high speed, high
		/// performance, and low power multi-lane applications.
		/// On the device, the GTXE2_CHANNEL component has the serial transceiver and CPLL units and
		/// the GTXE2_COMMON has the QPLL unit.
		/// This command returns a list of QPLL objects on the device as hw_sio_common objects, or returns
		/// an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 728
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_sio_common' objects of these types: 'hw_server
		/// hw_target hw_device hw_sio_ibert hw_sio_gtgroup
		/// hw_sio_pll'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_common' objects against patterns. Default: *</param>
		/// <returns>hardware SIO GT commons</returns>
		public TTCL get_hw_sio_commons(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_sio_commons [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_commons(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO GT groups.
		///
		///
		/// TCL Syntax: get_hw_sio_gtgroups [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the groups of GTs, hw_sio_gtgroups, as they relate to the quads that are in use on the
		/// IBERT debug core on the current hardware device.
		/// GT groups, relate to the IO Banks on the hardware device, with the number of available banks
		/// and GT pins determined by the target device. On the Kintex-7 xc7k325 part, for example, there
		/// are four quads, each containing four differential GT pins, and two differential REFCLK pins. Each
		/// GT pin has its own transmitter, TX, and receiver, RX. Quads can also include one shared PLL per
		/// quad, or Quad PLL. The quads are defined on the IBERT debug core, and can be customized with
		/// a number of user settings when the IBERT is added into the RTL design. Refer to the LogiCORE IP
		/// Integrated Bit Error Ratio Tester (IBERT) for 7 Series GTX Transceivers v3.0 (PG132)or to 7 Series
		/// FPGAs GTX/GTH Transceivers User Guide (UG476) or UltraScale Architecture GTH Transceivers User
		/// Guide (UG576) for more information.
		/// This command returns a list of GT group objects on the IBERT debug core, or returns an error if it
		/// fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 731
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_sio_gtgroup' objects of these types: 'hw_server
		/// hw_target hw_device hw_sio_ibert hw_sio_common
		/// hw_sio_pll hw_sio_gt hw_sio_tx hw_sio_rx'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_gtgroup' objects against patterns. Default: *</param>
		/// <returns>hardware SIO GT groups.</returns>
		public TTCL get_hw_sio_gtgroups(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_sio_gtgroups [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_gtgroups(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO GTs.
		///
		///
		/// TCL Syntax: get_hw_sio_gts [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the Gigabit Transceiver objects (GTs), hw_sio_gt, that are in use on the IBERT debug core
		/// on the current hardware device.
		/// The customizable LogiCORE™ IP Integrated Bit Error Ratio Tester (IBERT) core for Xilinx® FPGAs
		/// is designed for evaluating and monitoring the Gigabit Transceivers (GTs). The IBERT core enables
		/// in-system serial I/O validation and debug, letting you measure and optimize your high-speed
		/// serial I/O links in your FPGA-based system. Refer to the LogiCORE IP Integrated Bit Error Ratio
		/// Tester (IBERT) for 7 Series GTX Transceivers v3.0 (PG132)or to 7 Series FPGAs GTX/GTH Transceivers
		/// User Guide (UG476) or UltraScale Architecture GTH Transceivers User Guide (UG576) for more
		/// information.
		/// Using the IBERT debug core you can configure and tune the GT transmitters and receivers
		/// through the Dynamic Reconfiguration Port (DRP) port of the GTX transceiver. This lets you
		/// change property settings on the GTs, as well as registers that control the values on the ports.
		/// This command returns a list of GT objects on the IBERT debug core, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 735
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_sio_gt' objects of these types: 'hw_server hw_target
		/// hw_device hw_sio_ibert hw_sio_gtgroup hw_sio_pll hw_sio_tx
		/// hw_sio_rx hw_sio_link'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_gt' objects against patterns. Default: *</param>
		/// <returns>hardware SIO GTs</returns>
		public TTCL get_hw_sio_gts(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_sio_gts [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_gts(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO IBERT cores.
		///
		///
		/// TCL Syntax: get_hw_sio_iberts [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the Integrated Bit Error Ratio Tester (IBERT) debug core objects, hw_sio_ibert, defined
		/// on the current hardware device.
		/// The customizable LogiCORE™ IP Integrated Bit Error Ratio Tester (IBERT) core for Xilinx® FPGAs
		/// is designed for evaluating and monitoring the Gigabit Transceivers (GTs). The IBERT core enables
		/// in-system serial I/O validation and debug, letting you measure and optimize your high-speed
		/// serial I/O links in your FPGA-based system. Refer to the LogiCORE IP Integrated Bit Error Ratio
		/// Tester (IBERT) for 7 Series GTX Transceivers v3.0 (PG132) for more information.
		/// The IBERT debug core lets you configure and control the major features of GTs on the device,
		/// including:
		/// • TX pre-emphasis and post-emphasis
		/// • TX differential swing
		/// • RX equalization
		/// • Decision Feedback Equalizer (DFE)
		/// • Phase-Locked Loop (PLL) divider settings
		/// You can use the IBERT core when you are interested in addressing a range of in-system debug
		/// and validation problems; from simple clocking and connectivity issues to complex margin analysis
		/// and channel optimization issues.
		/// This command returns a list of IBERT debug core objects on the device, or returns an error if it
		/// fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 738
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_sio_ibert' objects of these types: 'hw_server
		/// hw_target hw_device hw_sio_gtgroup hw_sio_gt
		/// hw_sio_common hw_sio_pll hw_sio_tx hw_sio_rx hw_sio_link'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_ibert' objects against patterns. Default: *</param>
		/// <returns>hardware SIO IBERT cores.</returns>
		public TTCL get_hw_sio_iberts(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_sio_iberts [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_iberts(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO link groups.
		///
		///
		/// TCL Syntax: get_hw_sio_linkgroups [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the defined groups, or associations of communication links between TX and RX objects
		/// on the GTs of the IBERT debug core defined on the current hardware device.
		/// Vivado Serial I/O analyzer is a link-based analyzer. The links define the communication paths and
		/// protocols between transmitters and receivers of the GigaBit transceivers on the device. Link
		/// groups, or hw_sio_linkgroup objects, let you associate links into related groups, to collectively
		/// configure properties and run scans.
		/// This command returns a list of linkgroups on the IBERT debug core, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 742
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_sio_linkgroup' objects of these types: 'hw_sio_link'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_linkgroup' objects against patterns. Default: *</param>
		/// <returns>hardware SIO link groups</returns>
		public TTCL get_hw_sio_linkgroups(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_sio_linkgroups [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_linkgroups(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO links.
		///
		///
		/// TCL Syntax: get_hw_sio_links [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the communication links between TX and RX objects on the GTs of the IBERT debug
		/// core defined on the current hardware device.
		/// Vivado Serial I/O analyzer is a link-based analyzer, which lets you link between any transmitter
		/// and receiver within the IBERT design. The links define the communication paths and protocols
		/// between transmitters and receivers of the GigaBit transceivers on the device. You can configure
		/// the links by using the set_property command to specify property values on the link object.
		/// This command returns a list of link objects on the IBERT debug core, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 745
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_sio_link' objects of these types: 'hw_server
		/// hw_target hw_device hw_sio_ibert hw_sio_gtgroup hw_sio_gt
		/// hw_sio_tx hw_sio_rx hw_sio_linkgroup'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_link' objects against patterns. Default: *</param>
		/// <returns>hardware SIO links</returns>
		public TTCL get_hw_sio_links(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_sio_links [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_links(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO PLLs.
		///
		///
		/// TCL Syntax: get_hw_sio_plls [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the PLL objects, hw_sio_pll, defined on the IBERT debug core on the current hardware
		/// device.
		/// For each serial transceiver channel, there is a ring PLL called Channel PLL (CPLL). In Xilinx
		/// UltraScale and 7 series FPGAs, the GTX has an additional shared PLL per quad, or Quad PLL
		/// (QPLL). This QPLL is a shared LC PLL to support high speed, high performance, and low power
		/// multi-lane applications.
		/// On the device, the GTXE2_CHANNEL component has the serial transceiver and CPLL units and
		/// the GTXE2_COMMON has the QPLL unit.
		/// This command returns a list of all PLL objects, both CPLLs and QPLLs on the device, or returns an
		/// error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 748
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_sio_pll' objects of these types: 'hw_server hw_target
		/// hw_device hw_sio_ibert hw_sio_gtgroup hw_sio_gt
		/// hw_sio_common'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_pll' objects against patterns. Default: *</param>
		/// <returns>hardware SIO PLLs</returns>
		public TTCL get_hw_sio_plls(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_sio_plls [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_plls(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO RXs.
		///
		///
		/// TCL Syntax: get_hw_sio_rxs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the receiver objects, hw_sio_rx, of the Gigabit Transceivers (GTs) that are in use on the
		/// IBERT debug core on the current hardware device.
		/// On the hardware device, each GT includes an independent receiver, which consists of a PCS and
		/// a PMA. High-speed serial data flows from traces on the board into the PMA of the GTX/GTH
		/// transceiver RX, into the PCS, and finally into the FPGA logic.
		/// This command returns a list of receiver objects on the device, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 751
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_sio_rx' objects of these types: 'hw_server hw_target
		/// hw_device hw_sio_ibert hw_sio_gtgroup hw_sio_gt
		/// hw_sio_link'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_rx' objects against patterns. Default: *</param>
		/// <returns>hardware SIO RXs</returns>
		public TTCL get_hw_sio_rxs(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_sio_rxs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_rxs(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO scans.
		///
		///
		/// TCL Syntax: get_hw_sio_scans [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns serial I/O analyzer scan objects for the IBERT debug core.
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the
		/// specialized Eye Scan hardware of Xilinx UltraScale devices or 7 Series FPGAs. The Vivado serial
		/// I/O analyzer feature lets you to create, run, and save link scans.
		/// This command returns one or more hw_sio_scan objects, or returns an error if he command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 754
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_sio_scan' objects of these types: 'hw_sio_rx
		/// hw_sio_link hw_sio_sweep'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_scan' objects against patterns. Default: *</param>
		/// <returns>hardware SIO scans</returns>
		public TTCL get_hw_sio_scans(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_sio_scans [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_scans(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO sweeps.
		///
		///
		/// TCL Syntax: get_hw_sio_sweeps [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Return the serial I/O analyzer link sweep objects defined on the IBERT debug core.
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the
		/// specialized features of Xilinx UltraScale devices or 7 series FPGAs. It can also be helpful to run
		/// multiple scans on a the link with different configuration settings for the GTs. This can help you
		/// determine which settings are best for your design. The Vivado serial I/O analyzer feature enables
		/// you to define, run, and save link sweeps, or collections of link scans run across a range of values.
		/// This command returns a link sweep object that you can use with the run_hw_sio_sweep
		/// command to run analysis on the specified links, or GT receivers. You can also save the sweep
		/// scan to disk using the write_hw_sio_sweep command.
		/// You can remove the created sweep object using remove_hw_sio_sweep.
		/// This command returns one or more hw_sio_sweep objects, or returns an error if the command
		/// fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 757
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_sio_sweep' objects of these types: 'hw_sio_link hw_sio_scan'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_sweep' objects against patterns. Default: *</param>
		/// <returns>hardware SIO sweeps</returns>
		public TTCL get_hw_sio_sweeps(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_sio_sweeps [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_sweeps(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO TXs.
		///
		///
		/// TCL Syntax: get_hw_sio_txs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the transmitter objects, hw_sio_tx, of the Gigabit Transceivers (GTs) that are in use on the
		/// IBERT debug core on the current hardware device.
		/// On the hardware device, each GT includes an independent transmitter, which consists of a PCS
		/// and a PMA. Parallel data flows from the device logic into the FPGA TX interface, through the PCS
		/// and PMA, and then out the TX driver as high-speed serial data.
		/// This command returns a list of transmitter objects on the device, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 761
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_sio_tx' objects of these types: 'hw_server hw_target
		/// hw_device hw_sio_ibert hw_sio_gtgroup hw_sio_gt
		/// hw_sio_link'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_tx' objects against patterns. Default: *</param>
		/// <returns>hardware SIO TXs</returns>
		public TTCL get_hw_sio_txs(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_sio_txs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_txs(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SysMons.
		///
		///
		/// TCL Syntax: get_hw_sysmons [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the Sysmon debug core objects defined on the current hardware device.
		/// The System Monitor (SYSMON) Analog-to-Digital Converter (ADC) is used to measure die
		/// temperature and voltage on the hw_device. The Sysmon monitors the physical environment via
		/// on-chip temperature and supply sensors. The ADC provides a high-precision analog interface for
		/// a range of applications. The ADC can access up to 17 external analog input channels. Refer to
		/// UltraScale Architecture System Monitor User Guide (UG580), or 7 Series FPGAs and Zynq-7000 SoC
		/// XADC Dual 12-Bit 1 MSPS Analog-to-Digital Converter User Guide (UG480) for more information on
		/// a specific device architecture.
		/// The hw_sysmon data is stored in dedicated registers called status registers accessible through the
		/// hw_sysmon_reg object. The values of the system monitor registers can be returned by the
		/// get_hw_sysmon_reg command.
		/// Every device that supports the system monitor will automatically have one or more hw_sysmon
		/// objects created when refresh_hw_device is called. When the hw_sysmon object is created, it
		/// is assigned a property for all the temperature and voltage registers, as well as the control
		/// registers. On the hw_sysmon object, the values assigned to the temperature and voltage registers
		/// are already translated to Celsius/Fahrenheit and Voltage.
		/// Although you can use the get_hw_sysmon_reg command to access the hex values stored in
		/// registers of a system monitor, you can also retrieve values of certain registers as formatted
		/// properties of the hw_sysmon object. For example, the following code retrieves the
		/// TEMPERATURE property of the specified hw_sysmon object rather than directly accessing the
		/// hex value of the register:
		/// set opTemp [get_property TEMPERATURE [get_hw_sysmons]
		/// This command returns a list of hw_sysmon objects on the current or specified hw_device, or
		/// returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 767
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_sysmon' objects of these types: 'hw_server
		/// hw_target hw_device'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sysmon' objects against patterns. Default: *</param>
		/// <returns>hardware sysmons</returns>
		public TTCL get_hw_sysmons(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_sysmons [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sysmons(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of hardware targets.
		///
		///
		/// TCL Syntax: get_hw_targets [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the available hardware targets of the connected hardware servers.
		/// The hardware target is a system board containing a JTAG chain of one or more Xilinx devices that
		/// you can program with a bitstream file, or use to debug your design. Connections between
		/// hardware targets on the system board and the Vivado Design Suite are managed by the Xilinx
		/// hardware server application, and the connect_hw_server command. Refer to Vivado Design
		/// Suite User Guide: Programming and Debugging (UG908) for a list of supported JTAG download
		/// cables and devices.
		/// Use the open_hw_target command to open a connection to one of the available hardware
		/// targets. The open target is automatically defined as the current hardware target. Alternatively,
		/// you can define the current target with the current_hw_target command, and then open a
		/// connection to the current target. The Vivado Design Suite directs programming and debug
		/// commands to the open target through the hardware server connection.
		/// This command returns a list of available hardware targets through all connected hardware
		/// servers, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 771
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_target' objects of these types: 'hw_server'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_target' objects against patterns. Default: *</param>
		/// <returns>hardware targets</returns>
		public TTCL get_hw_targets(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_targets [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_targets(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of hardware VIOs.
		///
		///
		/// TCL Syntax: get_hw_vios [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the Virtual Input/Output (VIO) debug core objects that are defined on the current
		/// hardware device, hw_device.
		/// The Virtual Input/Output (VIO) debug core can both monitor and drive internal signals on a
		/// programmed Xilinx FPGA in real time. In the absence of physical access to the target hardware,
		/// you can use this debug feature to drive and monitor signals that are present on the physical
		/// device.
		/// The VIO core has hardware probes, hw_probe objects, to monitor and drive specific signals on
		/// the design. Input probes monitor signals as inputs to the VIO core. Output probes drive signals to
		/// specified values from the VIO core. Values on the debug core are driven onto the signals at the
		/// probe using the commit_hw_vio command.
		/// The VIO debug core needs to be instantiated in the RTL code, therefore you need to know what
		/// nets you want monitor and drive prior to debugging the design. The IP catalog provides the VIO
		/// core under the Debug category. Detailed documentation on the VIO core can be found in the
		/// LogiCORE IP Virtual Input/Output Product Guide (PG159).
		/// This command returns a list of VIO debug core objects on the device, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 774
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_vio' objects of these types: 'hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_vio' objects against patterns. Default: *</param>
		/// <returns>hardware VIOs</returns>
		public TTCL get_hw_vios(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_hw_vios [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_vios(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of I/O port interfaces in the current design
		///
		///
		/// TCL Syntax: get_interfaces [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of IO interfaces in the current project that match a specified search pattern. The
		/// default command gets a list of all IO interfaces in the project.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of all interfaces in the project:
		/// get_interfaces
		///
		/// See ug835-vivado-tcl-commands.pdf, page 777
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get interfaces of these pins or nets</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match I/O port interfaces against patterns Default: *</param>
		/// <returns>list of interface objects</returns>
		public TTCL get_interfaces(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_interfaces [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_interfaces(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of IO standards.
		///
		///
		/// TCL Syntax: get_io_standards [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Get a list of IOSTANDARDs available for use on the target device.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of differential IOSTANDARDs available for use on the target
		/// device:
		/// get_io_standards -filter {IS_DIFFERENTIAL}
		/// Note: If there are no objects matching the pattern you will get a warning.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 780
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get the IO standards of these bels, sites, package_pins,
		/// io_banks, ports.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match IO standards against patterns Default: *</param>
		/// <returns>IO standards</returns>
		public TTCL get_io_standards(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_io_standards [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_io_standards(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of iobanks.
		///
		///
		/// TCL Syntax: get_iobanks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of I/O Banks on the target device in the current project that match a specified search
		/// pattern. The default command gets a list of all I/O Banks on the target device.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example returns the I/O Bank of the specified package pin:
		/// get_iobanks -of_objects [get_package_pins H4]
		/// This example returns the GT Banks on the device:
		/// get_iobanks -filter {BANK_TYPE == BT_MGT}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 783
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get the iobanks of these package_pins, ports, clock regions,
		/// slrs or sites.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match iobanks against patterns Default: *</param>
		/// <returns>iobanks</returns>
		public TTCL get_iobanks(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_iobanks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_iobanks(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of results for IP upgrades during the current project
		///
		///
		/// TCL Syntax: get_ip_upgrade_results [-srcset <arg>] [-quiet] [-verbose] [<objects>...]
		///
		/// Returns the names of the upgrade_log files for the specified IPs.
		/// This command is used by the Vivado IDE to populate the IP Status Report window with
		/// information from the upgrade_log file. You can use the command to quickly obtain the
		/// upgrade_log file name, and then use the appropriate file commands, to read or display the
		/// contents.
		/// This command returns the upgrade_log file names of the specified IP objects, or returns an error
		/// if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 786
		/// </summary>
		/// <param name="srcset">
		/// (Optional)
		/// (Optional) Specifies the source file set containing the
		/// upgraded IP Default: The current source fileset Values:
		/// Source set name
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">
		/// (Optional)
		/// IP to be upgraded Values: IP instance(s) within the design,
		/// as returned by 'get_ips <instance name>' or 'get_bd_cells
		/// <cell name>'
		/// </param>
		/// <returns>list of IP upgrade results</returns>
		public TTCL get_ip_upgrade_results(string srcset = null, bool? quiet = null, bool? verbose = null, string objects = null)
		{
			// TCL Syntax: get_ip_upgrade_results [-srcset <arg>] [-quiet] [-verbose] [<objects>...]
			_tcl.Entry(_builder.get_ip_upgrade_results(srcset, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// Get a list of IP from the current IP Catalog
		///
		///
		/// TCL Syntax: get_ipdefs [-name] [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-all] [-quiet] [-verbose] [<patterns>...]
		///
		/// Get a list of IP cores defined in the IP catalog of the current project, based on the specified
		/// search pattern. The default is to return all IP cores defined in the Vivado tools IP catalog.
		/// By default, the search is based on the VLNV property of the IP cores in the catalog. You can
		/// specify the -name option to search on the display name of IP cores instead.
		///
		/// The following example returns a list of all IP cores with NAME property matching the specified
		/// pattern:
		/// get_ipdefs -filter {NAME=~*agilent*}
		/// TIP: The filter operator '=~' loosely matches the specified pattern.
		/// The following example returns a list of all AXI compliant IP cores:
		/// get_ipdefs -filter {IS_AXI==1}
		/// The following example returns IP from both the Vivado tools standard IP catalog and the IP
		/// integrator IP catalog:
		/// get_ipdefs -all *axi_interconnect*
		/// The following example filters the above results with the DESIGN_TOOL_CONTEXTS property to
		/// return only the IP integrator IP:
		/// get_ipdefs -all *axi_interconnect* -filter {DESIGN_TOOL_CONTEXTS =~*IPI*}
		/// TIP: By filtering on the DESIGN_TOOL_CONTEXTS property, you can identify IP from the IP integrator catalog
		/// instead of the Vivado tools standard catalog.
		/// In some cases, where multiple versions of an IP are returned, you can also filter on the
		/// UPGRADE_VERSIONS property to get as specific version or the latest IP version, as shown in the
		/// following example:
		/// get_ipdefs -all *axi_interconnect* -filter {UPGRADE_VERSIONS == ""}
		/// TIP: The {UPGRADE_VERSIONS == ""} filter returns IP defs that have no upgrade, and so are the latest version.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 788
		/// </summary>
		/// <param name="name">(Optional) Match the pattern against IP display name instead of VLNV</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the IPDefs of the objects specified: IP inst or XCI file.</param>
		/// <param name="all">(Optional) Return hidden IP</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// The patterns to match against Default: * Values: The default
		/// search pattern is the wildcard *, or .* when -regexp is
		/// specified.
		/// </param>
		/// <returns>List of Catalog IP objects</returns>
		public TTCL get_ipdefs(bool? name = null, bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? all = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_ipdefs [-name] [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-all] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_ipdefs(name, regexp, nocase, filter, of_objects, all, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of IPs in the current design
		///
		///
		/// TCL Syntax: get_ips [-regexp] [-nocase] [-all] [-filter <arg>] [-exclude_bd_ips] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
		///
		/// Get a list of IP cores in the current project based on the specified search pattern. The default
		/// command returns a list of all IPs in the project.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example returns a list of IP cores with names beginning with the string "EDK":
		/// get_ips EDK*
		///
		/// See ug835-vivado-tcl-commands.pdf, page 792
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="all">(Optional) Include subcore IP in search</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="exclude_bd_ips">(Optional) Exclude all IP owned by a block design.</param>
		/// <param name="of_objects">(Optional) Get 'ip' objects of these types: 'ip file'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// Match IP names against patterns Default: * Values: The
		/// default search pattern is the wildcard *, or .* when -regexp
		/// is specified.
		/// </param>
		/// <returns>list of IP objects</returns>
		public TTCL get_ips(bool? regexp = null, bool? nocase = null, bool? all = null, string filter = null, bool? exclude_bd_ips = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_ips [-regexp] [-nocase] [-all] [-filter <arg>] [-exclude_bd_ips] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_ips(regexp, nocase, all, filter, exclude_bd_ips, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of Library Cells
		///
		///
		/// TCL Syntax: get_lib_cells [-regexp] [-filter <arg>] [-nocase] [-include_unsupported] [-of_objects <args>] [-quiet] [-verbose] <patterns>
		///
		/// Get a list of cells in the library for the target part of the current design. Use this command to
		/// query and look for a specific library cell, or type of cell and to get the properties of the cells.
		/// This command requires a hierarchical name which includes the library name as well as the cell
		/// name: lib_name/cell_name.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets the number of the cells in the library for the target part in the current
		/// design, and then gets the number of AND type cells in that library:
		/// llength [get_lib_cells [get_libs]/*]
		/// 795
		/// llength [get_lib_cells [get_libs]/AND*]
		/// 18
		/// The following example gets the library cell for the specified cell object:
		/// get_lib_cells -of_objects [lindex [get_cells] 1]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 795
		/// </summary>
		/// <param name="patterns">(Required) Match library cell names against patterns.</param>
		/// <param name="regexp">(Optional) Patterns are regular expressions.</param>
		/// <param name="filter">(Optional) Filter list with expression.</param>
		/// <param name="nocase">
		/// (Optional)
		/// Perform case-insensitive matching when a pattern has been
		/// specified. This argument applies to the use of -regexp only.
		/// </param>
		/// <param name="include_unsupported">(Optional) Include test-only library cells.</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get the library cells of the objects passed in here. Valid
		/// objects are cells or instances (ie, get_cells), cell pins (ie,
		/// get_pins) and library pins (ie, get_lib_pins).
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of library cells</returns>
		public TTCL get_lib_cells(string patterns, bool? regexp = null, string filter = null, bool? nocase = null, bool? include_unsupported = null, string of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_lib_cells [-regexp] [-filter <arg>] [-nocase] [-include_unsupported] [-of_objects <args>] [-quiet] [-verbose] <patterns>
			_tcl.Entry(_builder.get_lib_cells(patterns, regexp, filter, nocase, include_unsupported, of_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of Library Cell Pins
		///
		///
		/// TCL Syntax: get_lib_pins [-regexp] [-filter <arg>] [-nocase] [-of_objects <args>] [-quiet] [-verbose] <patterns>
		///
		/// Gets a list of the pins on a specified cell of the cell library for the target part in the current design.
		/// Note: This command requires a hierarchical name which includes the library name and cell name as well as
		/// the pins: lib_name/cell_name/pins.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of all library cell pins:
		/// get_lib_pins xt_virtex6/AND2/*
		/// The following example gets a list of all pins, of all cells in the cell library for the target device:
		/// get_lib_pins [get_libs]/*/*
		///
		/// See ug835-vivado-tcl-commands.pdf, page 798
		/// </summary>
		/// <param name="patterns">
		/// (Required)
		/// Match library cell pin names against patterns of the form
		/// <library cell pattern>/<library pin pattern>.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are regular expressions</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="nocase">
		/// (Optional)
		/// Perform case-insensitive matching when a pattern has been
		/// specified. This argument applies to the use of -regexp only.
		/// </param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get the library cell pins of the objects passed in here. Valid
		/// objects are cells or instances (ie, get_cells), cell pins (ie,
		/// get_pins) and library cells (ie get_lib_cells).
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of library cell pins</returns>
		public TTCL get_lib_pins(string patterns, bool? regexp = null, string filter = null, bool? nocase = null, string of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_lib_pins [-regexp] [-filter <arg>] [-nocase] [-of_objects <args>] [-quiet] [-verbose] <patterns>
			_tcl.Entry(_builder.get_lib_pins(patterns, regexp, filter, nocase, of_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of Libraries
		///
		///
		/// TCL Syntax: get_libs [-regexp] [-filter <arg>] [-nocase] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets the cell library for the target device in the current design. There is a library for each device
		/// family because there are primitives that may be available in one device family but not in others.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets the cell library for the target part:
		/// get_libs
		///
		/// See ug835-vivado-tcl-commands.pdf, page 801
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are regular expressions</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="nocase">
		/// (Optional)
		/// Perform case-insensitive matching when a pattern has been
		/// specified. This argument applies to the use of -regexp only.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match library names against patterns. Default: *</param>
		/// <returns>list of libraries</returns>
		public TTCL get_libs(bool? regexp = null, string filter = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_libs [-regexp] [-filter <arg>] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_libs(regexp, filter, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of macros in the current design
		///
		///
		/// TCL Syntax: get_macros [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of macros in the current design that match a specified search pattern. The default
		/// command returns a list of all macros in the design.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example returns the properties currently assigned to the macro matching the
		/// specified search pattern:
		/// report_property [get_macro *Macro1]
		/// Note: If there are no macros matching the pattern you will get a warning.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 804
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get macros of these cells</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match macro names against patterns Default: *</param>
		/// <returns>list of macro objects</returns>
		public TTCL get_macros(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_macros [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_macros(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get marked objects
		///
		///
		/// TCL Syntax: get_marked_objects [-rgb <args>] [-color <arg>] [-quiet] [-verbose]
		///
		/// Get the marked objects in the current design open in the Vivado IDE. Objects can be marked
		/// with the mark_objects command.
		/// You can get all marked objects in the design, or specify marked objects by color, or by RGB value.
		/// Note: This Tcl command works only when Vivado is run in GUI mode.
		///
		/// The following example gets all the marked objects in the current design:
		/// get_marked_objects
		/// The following example gets the object in the current design that are marked in the specified
		/// color:
		/// get_marked_objects -color yellow
		///
		/// See ug835-vivado-tcl-commands.pdf, page 807
		/// </summary>
		/// <param name="rgb">(Optional) RGB color index list</param>
		/// <param name="color">(Optional) Valid values are red green blue magenta yellow cyan and orange</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of marked objects</returns>
		public TTCL get_marked_objects(string rgb = null, string color = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_marked_objects [-rgb <args>] [-color <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_marked_objects(rgb, color, quiet, verbose));
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
		///
		/// The following command gets a list of all synthesis methodology checks:
		/// get_methodology_checks SYNTH*
		///
		/// See ug835-vivado-tcl-commands.pdf, page 809
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
		/// See ug835-vivado-tcl-commands.pdf, page 812
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
		/// Get the routed or estimated delays in picoseconds on a net from the driver to each load pin.
		///
		///
		/// TCL Syntax: get_net_delays -of_objects <args> [-regexp] [-nocase] [-patterns <arg>] [-filter <arg>] [-to <args>] [-interconnect_only] [-quiet] [-verbose]
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
		/// <param name="of_objects">(Required) Get 'net_delay' objects of these types: 'net'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="patterns">(Optional) Match the 'net_delay' objects against patterns. Default: *</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="to">(Optional) Get the delay of the net to the given terminal(s) or port(s).</param>
		/// <param name="interconnect_only">
		/// (Optional)
		/// Include only interconnect delays. The default is to include
		/// the intra-site delay.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>net_delays</returns>
		public TTCL get_net_delays(string of_objects, bool? regexp = null, bool? nocase = null, string patterns = null, string filter = null, string to = null, bool? interconnect_only = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_net_delays -of_objects <args> [-regexp] [-nocase] [-patterns <arg>] [-filter <arg>] [-to <args>] [-interconnect_only] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_net_delays(of_objects, regexp, nocase, patterns, filter, to, interconnect_only, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of nets in the current design
		///
		///
		/// TCL Syntax: get_nets [-hsc <arg>] [-hierarchical] [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-top_net_of_hierarchical_group] [-segments] [-boundary_type <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of nets in the current design that match a specified search pattern. The default
		/// command gets a list of all nets in the current_instance of the open design, as specified by the
		/// current_instance command.
		/// You can use the -hierarchical option to extract nets from the hierarchy of the current
		/// design.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example runs the report_drc command on the current design, returns the list of
		/// violations in the specified DRC report, and then returns any nets associated with the driverless
		/// net rule (NDRV):
		/// report_drc -name drc_1
		/// get_drc_violations -name drc_1
		/// get_nets -of_objects [get_drc_violations -name drc_1 NDRV*]
		/// The following example returns a list of nets that have been marked for debug with the
		/// connect_debug_port command:
		/// get_nets -hier -filter {MARK_DEBUG==1}
		/// This example returns the net attached to the specified hierarchical pin object, then returns the
		/// net segments attached to the pin object, then returns the top-level net segment attached to the
		/// pin object:
		/// get_nets \
		/// -of [get_pins cpuEngine/or1200_cpu/or1200_sprs/esr_reg[9]_i_3/I0]
		/// get_nets -segments \
		/// -of [get_pins cpuEngine/or1200_cpu/or1200_sprs/esr_reg[9]_i_3/I0]
		/// get_nets -top -segments \
		/// -of [get_pins cpuEngine/or1200_cpu/or1200_sprs/esr_reg[9]_i_3/I0]
		/// In the following example, the first command applies the -filter to find nets that have the
		/// IS_INTERNAL property, and then -segment is applied to return the segments of those nets. This
		/// command returns 0 net segments (and a warning). The second command, returns the segments
		/// of all nets, and filters the results to find the segments that have the IS_INTERNAL property, of
		/// which there are 448:
		/// llength [get_nets -segments -filter {IS_INTERNAL}]
		/// WARNING: [Vivado 12-1023] No nets matched for command 'get_nets -segments
		/// -filter IS_INTERNAL'.
		/// 0
		/// llength [filter [get_nets -segments] {IS_INTERNAL}]
		/// 448
		///
		/// See ug835-vivado-tcl-commands.pdf, page 822
		/// </summary>
		/// <param name="hsc">(Optional) Hierarchy separator Default: /</param>
		/// <param name="hierarchical">(Optional) Search level-by-level in current instance</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get nets of these pins, ports, cells, timing paths or clocks,
		/// drc violations
		/// </param>
		/// <param name="match_style">(Optional) Style of pattern matching, valid values are ucf, sdc Default: sdc</param>
		/// <param name="top_net_of_hierarchical_group">
		/// (Optional)
		/// Return net segment(s) which belong(s) to the high level of a
		/// hierarchical net
		/// </param>
		/// <param name="segments">(Optional) Return all segments of a net across the hierarchy</param>
		/// <param name="boundary_type">
		/// (Optional)
		/// Return net segment connected to a hierarchical pin which
		/// resides at the same level as the pin (upper) or at the level
		/// below (lower), or both. Valid values are : upper, lower, both
		/// Default: upper
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match net names against patterns Default: *</param>
		/// <returns>list of net objects</returns>
		public TTCL get_nets(string hsc = null, bool? hierarchical = null, bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, string match_style = null, bool? top_net_of_hierarchical_group = null, bool? segments = null, string boundary_type = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_nets [-hsc <arg>] [-hierarchical] [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-top_net_of_hierarchical_group] [-segments] [-boundary_type <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_nets(hsc, hierarchical, regexp, nocase, filter, of_objects, match_style, top_net_of_hierarchical_group, segments, boundary_type, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of nodes in the device.
		///
		///
		/// TCL Syntax: get_nodes [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-uphill] [-downhill] [-flyover] [-from <args>] [-to <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns a list of nodes on the device that match a specified search pattern in an open design.
		/// The default command gets a list of all nodes on the device.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example returns the nodes associated with the specified tile:
		/// get_nodes -of_objects [get_tiles CLBLM_R_X11Y158]
		/// The following example returns the nodes downhill from the specified node:
		/// get_nodes -downhill -of_objects [get_nodes LIOB33_SING_X0Y199/IOB_PADOUT0]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 827
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'node' objects of these types: 'net tile node bel_pin
		/// site_pin wire pip speed_model'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="uphill">
		/// (Optional)
		/// Get the nodes uphill (driver) from the site_pin, pip, node or
		/// tile(s) provided in the -of_objects.
		/// </param>
		/// <param name="downhill">
		/// (Optional)
		/// Get the nodes downhill (loads) from the site_pin, pip, node
		/// or tile(s) provided in the -of_objects.
		/// </param>
		/// <param name="flyover">(Optional) Get the nodes that fly over the given tile(s).</param>
		/// <param name="from">
		/// (Optional)
		/// -from <pip/site pin> Return the nodes beginning at this pip
		/// or site pin. May be used in combination with uphill. Default
		/// is downhill. -all is implied.
		/// </param>
		/// <param name="to">
		/// (Optional)
		/// -to <pip/site pin> Return the nodes ending at this wire or
		/// site pin. May be used in combination with uphill. Default is
		/// downhill. -all is implied.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'node' objects against patterns. Default: *</param>
		/// <returns>nodes</returns>
		public TTCL get_nodes(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? uphill = null, bool? downhill = null, bool? flyover = null, string from = null, string to = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_nodes [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-uphill] [-downhill] [-flyover] [-from <args>] [-to <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_nodes(of_objects, regexp, nocase, filter, uphill, downhill, flyover, from, to, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of package pins
		///
		///
		/// TCL Syntax: get_package_pins [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of the pins on the selected package for the target device. The default command gets a
		/// list of all pins on the package.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of the package pins associated with the specified bytegroup of
		/// an UltraScale device:
		/// get_package_pins -of [get_pkgpin_bytegroups BANK44_BYTE0]
		/// The following example gets the number of clock capable (CC) pins on the package:
		/// llength [get_package_pins -filter {IS_CLK_CAPABLE==1}]
		/// Note: If there are no pins matching the pattern you will get a warning.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 835
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get the list of package pin objects of these sites, bels,
		/// iobanks, pkgpin_bytegroups, pkgpin_nibbles, or ports.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match list of package pin objects against patterns Default: *</param>
		/// <returns>list of package pin objects</returns>
		public TTCL get_package_pins(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_package_pins [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_package_pins(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of PartitionDefs
		///
		///
		/// TCL Syntax: get_partition_defs [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// IMPORTANT! You must first define the project as a Partial Reconfiguration (PR) project by setting the
		/// PR_FLOW property on the project to TRUE, or by using the Tools → Enable Partial Reconfiguration command.
		/// Get a list of all Partition Definition (partitionDef) objects in the current design, or the
		/// partitionDefs that match a specified search pattern.
		/// The Partial Reconfiguration flow lets you create Partition Definitions (partitionDefs) from
		/// hierarchical cells in a design, and to specify reconfigurable modules (RMs) to be assigned to these
		/// partitionDefs to create a unique configurations of the design based on the combination of the
		/// core design and one or more RMs. The PR design flow requires the implementation of each PR
		/// configuration, resulting in partial bitstreams for the RMs, but complete bitstreams for each
		/// integrated configuration. Refer to the Vivado Design Suite User Guide: Dynamic Function eXchange
		/// (UG909) for more information.
		/// This command returns a list of partitionDef objects, or returns an error if the command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 840
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match partition definition names against patterns Default: *</param>
		/// <returns>list of PartitionDef objects</returns>
		public TTCL get_partition_defs(bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_partition_defs [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_partition_defs(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of parts available in the software
		///
		///
		/// TCL Syntax: get_parts [-regexp] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of parts that match a specified search pattern. The default command gets a list of all
		/// parts.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of 7vx485t parts, speed grade -1:
		/// get_parts -filter {DEVICE =~ xc7vx485t* && speed == -1}
		/// The following example gets the number of 7 series and 6 series Virtex parts:
		/// llength [get_parts -regexp {xc7v.* xc6V.*} -nocase]
		/// Note: If there are no parts matching the pattern, the tool will return a warning.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 843
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the parts of the objects specified: project, design, or run.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// Match part names against patterns Default: * Values: The
		/// default search pattern is the wildcard *, or .* when -regexp
		/// is specified.
		/// </param>
		/// <returns>list of part objects</returns>
		public TTCL get_parts(bool? regexp = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_parts [-regexp] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_parts(regexp, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of path groups in the current design
		///
		///
		/// TCL Syntax: get_path_groups [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of timing path groups in the current project that match a specified search pattern. The
		/// default command gets a list of all path groups in the design.
		/// Path groups are automatically created when a new clock is created in the design, containing all
		/// paths in that clocks domain. Path groups can also be manually created with the use of the
		/// group_path command.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of all the path groups in the design.
		/// get_path_groups
		/// The following example gets all path groups with the string "Clk" somewhere in the name:
		/// get_path_groups *Clk*
		/// Note: If no path groups match the pattern you will get a warning.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 846
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match path group names against patterns Default: *</param>
		/// <returns>list of path groups</returns>
		public TTCL get_path_groups(bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_path_groups [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_path_groups(regexp, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of Pblocks in the current design
		///
		///
		/// TCL Syntax: get_pblocks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-include_nested_pblock] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of Pblocks defined in the current project that match a specific pattern. The default
		/// command gets a list of all Pblocks in the project.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of all Pblocks in the current project:
		/// get_pblocks
		/// This example gets a list of all Pblocks which do not have a Slice Range defined:
		/// get_pblocks -filter {GRIDTYPES !~ SLICE}
		/// The following example gets the Pblock assignments of the specified cell:
		/// get_pblocks -of [get_cells CORE/BR_TOP/RLD67_MUX/REG_PMBIST_C1]
		/// This example returns the specified Pblock, including any nested Pblocks:
		/// get_pblocks -include_nested_pblocks usbTop
		///
		/// See ug835-vivado-tcl-commands.pdf, page 848
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get Pblocks of these cells</param>
		/// <param name="include_nested_pblock">(Optional) Display the the list of nested pblocks</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match Pblock names against patterns Default: *</param>
		/// <returns>list of Pblock objects</returns>
		public TTCL get_pblocks(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? include_nested_pblock = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_pblocks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-include_nested_pblock] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pblocks(regexp, nocase, filter, of_objects, include_nested_pblock, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of pins in the current design
		///
		///
		/// TCL Syntax: get_pins [-hsc <arg>] [-hierarchical] [-regexp] [-nocase] [-leaf] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-include_replicated_objects] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of pin objects in the current design that match a specified search pattern. The default
		/// command gets a list of all pins in the current_instance of the open design, as specified by the
		/// current_instance command. You can use the -hierarchical option to extract pins from
		/// the hierarchy of the current design.
		/// IMPORTANT! Because there are so many pins in the design, the get_pins command can cause performance
		/// issues, and add significant time to processing design constraints. In many cases, a design constraint that is
		/// written with the get_pins command can be rewritten using the get_cells command, as shown in the
		/// examples, to significantly improve constraint processing and performance of the Vivado tool.
		/// The get_pins command also includes an option to get all replicated pins that are added to a
		/// design during physical optimization, or phys_opt_design. The use of the -
		/// include_replicated_objects option returns the pins on replicated cells when the pins of
		/// an original cell are returned. You can use this option to ensure that constraints or properties that
		/// are applied to the pins of a cell are also applied to the pins of its replicated cells.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of pins attached to the specified cells:
		/// get_pins -of_objects [get_cells usb*]
		/// Note: If there are no pins matching the pattern, the tool will return a warning.
		/// This example shows how using get_cells can improve the performance of the get_pins
		/// command:
		/// [get_pins -hier * -filter {NAME=~xx*/yy*}]
		/// can be rewritten as:
		/// [get_pins -filter {REF_PIN_NAME=~yy*} -of [get_cells -hier xx*]]
		/// The following shows how rewriting the set_max_delay constraint can significantly improve
		/// performance:
		/// set_max_delay 15 -from [get_pins -hier \
		/// -filter name=~*/aclk_dpram_reg*/*/CLK] \
		/// -to [get_cells -hier -filter name=~*/bclk_dout_reg*] -datapath_only
		/// can be rewritten as:
		/// set_max_delay 15 -from [get_pins -of \
		/// [get_cells -hier -filter name=~*aclk_dpram_reg*/*] \
		/// -filter {REF_PIN_NAME == CLK}] \
		/// -to [get_pins -of [get_cells -hier -filter {name =~ */bclk_dout_reg*}]
		/// \
		/// -filter {REF_PIN_NAME == D}] -datapath_only
		/// TIP: Although the second command syntax is more complex, the performance gains can be significant.
		/// This example runs the report_drc command on the current design, and then returns any pins
		/// associated with DRC violations:
		/// report_drc -name drc_1
		/// get_pins -of_objects [get_drc_violations]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 851
		/// </summary>
		/// <param name="hsc">(Optional) Hierarchy separator Default: /</param>
		/// <param name="hierarchical">(Optional) Search level-by-level in current instance</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="leaf">(Optional) Get leaf/global pins of nets with -of_objects</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get pins of these cells, nets, timing paths, clocks, drc violations</param>
		/// <param name="match_style">(Optional) Style of pattern matching, valid values are ucf, sdc Default: sdc</param>
		/// <param name="include_replicated_objects">
		/// (Optional)
		/// Include replicated objects when searching for patterns. This
		/// option is valid only when patterns is specified.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match pin names against patterns Default: *</param>
		/// <returns>list of pin objects</returns>
		public TTCL get_pins(string hsc = null, bool? hierarchical = null, bool? regexp = null, bool? nocase = null, bool? leaf = null, string filter = null, string of_objects = null, string match_style = null, bool? include_replicated_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_pins [-hsc <arg>] [-hierarchical] [-regexp] [-nocase] [-leaf] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-include_replicated_objects] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pins(hsc, hierarchical, regexp, nocase, leaf, filter, of_objects, match_style, include_replicated_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of programmable interconnect points (pips) on the current device.
		///
		///
		/// TCL Syntax: get_pips [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-uphill] [-downhill] [-from <args>] [-to <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Programmable interconnect points, or PIPs, provide the physical routing paths on the device used
		/// to connect logic networks. This command returns a list of PIPs on the device that match a
		/// specified search pattern. The command requires a design to be open.
		/// The default command gets a list of all PIPs on the device. However, this is not a recommended
		/// use of the command due to the number of pips on a device. You should specify the -
		/// of_objects argument to limit the number of pips returned.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example returns the PIPs associated with the specified tile:
		/// get_pips -of_object [get_tiles DSP_R_X9Y75]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 856
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the pips of these sites, tiles, wires, nodes, pips, or nets.</param>
		/// <param name="uphill">(Optional) Get the pips uphill from the provided wire or pip.</param>
		/// <param name="downhill">(Optional) Get the pips downhill from the provided wire or pip.</param>
		/// <param name="from">
		/// (Optional)
		/// -from <pip/site pin> Return the ordered list of pips
		/// beginning at this pip or site pin. May be used in
		/// combination with uphill. Default is downhill. -all is implied.
		/// </param>
		/// <param name="to">
		/// (Optional)
		/// -to <pip/site pin> Return the ordered list of pips ending at
		/// this wire or site pin. May be used in combination with uphill.
		/// Default is downhill. -all is implied.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match pips against patterns Default: *</param>
		/// <returns>pips</returns>
		public TTCL get_pips(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? uphill = null, bool? downhill = null, string from = null, string to = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_pips [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-uphill] [-downhill] [-from <args>] [-to <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pips(regexp, nocase, filter, of_objects, uphill, downhill, from, to, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of package pin byte groups.
		///
		///
		/// TCL Syntax: get_pkgpin_bytegroups [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of the byte groups on the I/O banks of the current Xilinx UltraScale device.
		/// For 7 series devices, the hierarchy of IO Banks is divided into two object types: I/O Banks and
		/// Package Pins. For Xilinx UltraScale FPGA devices, the IO Bank hierarchy includes two additional
		/// divisions: Byte groups and Nibbles.
		/// The relationships of these objects on an UltraScale device are defined as follows:
		/// • An iobank has 2 or 4 bytegroups.
		/// • Each pkgpin_bytegroup has 2 nibbles, an upper and lower, and has 13 package pins.
		/// • Each pkgpin_nibble has 6 or 7 pins, and is the upper or lower nibble of the pkgpin_bytegroup.
		/// • A package_pin is one pin of an iobank, a pkgpin_bytegroup, or a pkgpin_nibble.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of all pins on the package of the target device:
		/// get_pkgpin_bytegroups -of [get_iobanks 44]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 860
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the pin_group of these package_pins, iobank, site, or port.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match pin_group against patterns Default: *</param>
		/// <returns>pin_group</returns>
		public TTCL get_pkgpin_bytegroups(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_pkgpin_bytegroups [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pkgpin_bytegroups(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of pkgpin nibbles.
		///
		///
		/// TCL Syntax: get_pkgpin_nibbles [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Return a list of nibbles, or half-bytes, on the I/O banks of the current Xilinx UltraScale device.
		/// For 7 series devices, the hierarchy of IO Banks is divided into two object types: I/O Banks and
		/// Package Pins. For Xilinx UltraScale FPGA devices, the IO Bank hierarchy includes two additional
		/// divisions: Byte groups and Nibbles.
		/// The relationships of these objects on an UltraScale device are defined as follows:
		/// • An iobank has 2 or 4 bytegroups.
		/// • Each pkgpin_bytegroup has 2 nibbles, an upper and lower, and has 13 package pins.
		/// • Each pkgpin_nibble has 6 or 7 pins, and is the upper or lower nibble of the pkgpin_bytegroup.
		/// • A package_pin is one pin of an iobank, a pkgpin_bytegroup, or a pkgpin_nibble.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example returns the Upper nibbles associated with the specified IO bank:
		/// get_pkgpin_nibbles -of [get_iobanks 44] -filter {TYPE == U}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 863
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the pin_nibble of these package_pins, iobank, site, or port.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match pin_nibble against patterns Default: *</param>
		/// <returns>pin_nibble</returns>
		public TTCL get_pkgpin_nibbles(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_pkgpin_nibbles [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pkgpin_nibbles(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of ports in the current design
		///
		///
		/// TCL Syntax: get_ports [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-scoped_to_current_instance] [-no_traverse] [-prop_thru_buffers] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of port objects in the current design that match a specified search pattern. The default
		/// command gets a list of all ports in the design.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of pins attached to the specified cell:
		/// get_ports -of_objects [lindex [get_cells] 1]
		/// Note: If there are no ports matching the pattern, the tool will return a warning.
		/// The following example runs the report_drc command on the current design, returns the list of
		/// violations in the specified DRC report, and then returns the ports associated with any violations
		/// of the unspecified I/O Standard rule (NSTD):
		/// report_drc -name drc_1
		/// get_drc_violations -name drc_1
		/// get_ports -of_objects [get_drc_violations -name drc_1 NSTD*]
		/// This example specifies a cell for the current instance, returns the pins scoped to the current
		/// instance, and returns the top-level ports connected to those pins:
		/// current_instance [get_cells dac_spi*]
		/// get_ports -scoped_to_current_instance
		/// get_ports -scoped_to_current_instance -prop_thru_buffers
		///
		/// See ug835-vivado-tcl-commands.pdf, page 866
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get ports of these nets, instances, sites, clocks, timing paths,
		/// io standards, io banks, package pins, drc violations
		/// </param>
		/// <param name="match_style">(Optional) Style of pattern matching, valid values are ucf, sdc Default: sdc</param>
		/// <param name="scoped_to_current_instance">
		/// (Optional)
		/// Match patterns on instance pins specified using current
		/// instance, and then find top level connected ports.
		/// </param>
		/// <param name="no_traverse">(Optional) Do not traverse to find top level terminals.</param>
		/// <param name="prop_thru_buffers">
		/// (Optional)
		/// Allow propagate through buffers when traversing to find
		/// top level terminals connected to pins of scoped instance.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match port names against patterns Default: *</param>
		/// <returns>list of port objects</returns>
		public TTCL get_ports(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, string match_style = null, bool? scoped_to_current_instance = null, bool? no_traverse = null, bool? prop_thru_buffers = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_ports [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-scoped_to_current_instance] [-no_traverse] [-prop_thru_buffers] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_ports(regexp, nocase, filter, of_objects, match_style, scoped_to_current_instance, no_traverse, prop_thru_buffers, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of partition configurations
		///
		///
		/// TCL Syntax: get_pr_configurations [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Get a list of PR configuration objects in the current project.
		/// In the Partial Reconfiguration (PR) design flow, the PR configuration lets you specify a
		/// reconfigurable module (RM) to assign to a specific instance of a Partition Definition
		/// (partitionDef). This flow lets you create unique configurations of the design based on the
		/// combination of the core design and one or more RMs. The PR design flow requires the
		/// implementation of each PR configuration, resulting in partial bitstreams for the RMs, but
		/// complete bitstreams for each integrated configuration. Refer to the Vivado Design Suite User
		/// Guide: Dynamic Function eXchange (UG909) for more information.
		/// This command returns a list of PR configuration objects, or returns an error if the command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 871
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match partition configuration names against patterns Default: *</param>
		/// <returns>list of Configuration objects</returns>
		public TTCL get_pr_configurations(bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_pr_configurations [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pr_configurations(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of available unisim primitives for a part
		///
		///
		/// TCL Syntax: get_primitives [-regexp] [-nocase] [-filter <arg>] [-part <arg>] [-retarget] [-macro] [-hierarchy] [-quiet] [-verbose] [<patterns>]
		///
		/// Get a list of all supported primitives for the specified device. This command can be used on an
		/// open elaborated, synthesized, or implemented design, in which case it will get the PART from the
		/// current design. You can also specify the -part option to return the primitives for any device.
		/// By default the command always returns native primitives that can be placed on the target part
		/// without modification. The -retarget, -macro, and -hierarchy options add additional
		/// primitives to the list returned.
		///
		/// The following example gets the native primitives for the current part, and includes macro
		/// primitives:
		/// get_primitives -macro
		///
		/// See ug835-vivado-tcl-commands.pdf, page 874
		/// </summary>
		/// <param name="patterns">(Required) Match primitive types against patterns Default: *</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="part">(Optional) Part to get primitives for</param>
		/// <param name="retarget">
		/// (Optional)
		/// Include primitive types that will be automatically retargeted
		/// to the current (or specified) part
		/// </param>
		/// <param name="macro">
		/// (Optional)
		/// Include primitive types that always convert into more basic,
		/// natively supported primitives, such as logic gates
		/// </param>
		/// <param name="hierarchy">
		/// (Optional)
		/// Include primitive types that will be automatically expanded
		/// into a hierarchy of leaf cells during implementation
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>primitive types</returns>
		public TTCL get_primitives(string patterns, bool? regexp = null, bool? nocase = null, string filter = null, string part = null, bool? retarget = null, bool? macro = null, bool? hierarchy = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_primitives [-regexp] [-nocase] [-filter <arg>] [-part <arg>] [-retarget] [-macro] [-hierarchy] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_primitives(patterns, regexp, nocase, filter, part, retarget, macro, hierarchy, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of projects
		///
		///
		/// TCL Syntax: get_projects [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of open projects that match the specified search pattern. The default gets a list of all
		/// open projects.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of all open projects.
		/// get_projects
		/// The following example sets a variable called project_found to the length of the list of projects
		/// returned by get_projects, then prints either that projects were found or were not found as
		/// appropriate:
		/// set project_found [llength [get_projects ISC*] ]
		/// if {$project_found > 0} {puts "Project Found."} \
		/// else {puts "No Projects Found."}
		/// Note: If there are no projects matching the pattern you will get a warning.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 877
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match project names against patterns Default: *</param>
		/// <returns>list of project objects</returns>
		public TTCL get_projects(bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_projects [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_projects(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get properties of object
		///
		///
		/// TCL Syntax: get_property [-min] [-max] [-quiet] [-verbose] <name> <object>
		///
		/// Gets the current value of the named property from the specified object or objects. If multiple
		/// objects are specified, a list of values is returned.
		/// If the property is not currently assigned to the object, or is assigned without a value, then the
		/// get_property command returns nothing, or the null string. If multiple objects are queried, the
		/// null string is added to the list of values returned.
		/// If multiple objects are passed to the get_property command, you can use the -min or -max
		/// options to return the smallest or greatest value of the property specified by name. This feature
		/// can be useful when setting timing constraints.
		/// RECOMMENDED: For numeric properties, the min/max determination is based on numeric values. For all
		/// other properties, the determination is based on string sorting.
		/// This command returns a value, or list of values, or returns an error if it fails.
		///
		/// The following example gets the NAME property from the specified cell:
		/// get_property NAME [lindex [get_cells] 3]
		/// The following example returns the smallest PERIOD property from the specified clock objects:
		/// get_property -min PERIOD [get_clocks]
		/// This example demonstrates the string based sorting of the SITE property for the specified ports:
		/// get_property SITE [get_ports]
		/// IOB_X1Y75 IOB_X1Y76 IOB_X1Y98 IOB_X1Y125 IOB_X0Y94 IOB_X1Y95 IOB_X1Y96
		/// IOB_X1Y93 IOB_X1Y94
		/// get_property -min SITE [get_ports]
		/// IOB_X0Y94
		/// get_property -max SITE [get_ports]
		/// IOB_X1Y98
		/// Note: While IOB_X1Y125 is the largest site value on the port objects, the property value IOB_X1Y98 is
		/// returned because of the sorting of the property values as strings.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 880
		/// </summary>
		/// <param name="name">(Required) Name of property whose value is to be retrieved</param>
		/// <param name="@object">(Required) Object to query for properties</param>
		/// <param name="min">(Optional) Return only the minimum value</param>
		/// <param name="max">(Optional) Return only the maximum value</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>property value</returns>
		public TTCL get_property(string name, string @object, bool? min = null, bool? max = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_property [-min] [-max] [-quiet] [-verbose] <name> <object>
			_tcl.Entry(_builder.get_property(name, @object, min, max, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of available QoR suggestions
		///
		///
		/// TCL Syntax: get_qor_suggestions [-filter <arg>] [-quiet] [-verbose] [<IDs>]
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
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="IDs">(Optional) Match suggestion names against given names</param>
		/// <returns>list of qor suggestion objects</returns>
		public TTCL get_qor_suggestions(string filter = null, bool? quiet = null, bool? verbose = null, string IDs = null)
		{
			// TCL Syntax: get_qor_suggestions [-filter <arg>] [-quiet] [-verbose] [<IDs>]
			_tcl.Entry(_builder.get_qor_suggestions(filter, quiet, verbose, IDs));
			return _tcl;
		}
		/// <summary>
		/// Get a list of ReconfigModules
		///
		///
		/// TCL Syntax: get_reconfig_modules [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Get a list of reconfigurable modules (RMs) in the current design that match a specified search
		/// pattern. The default command returns a list of all RMs in the current project.
		/// This command returns a list of RM objects, or returns an error if the command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 885
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'reconfig_module' objects of these types: 'partition_def'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match reconfigurable module names against patterns Default: *</param>
		/// <returns>list of ReconfigModule objects</returns>
		public TTCL get_reconfig_modules(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_reconfig_modules [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_reconfig_modules(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of Configurable Report objects
		///
		///
		/// TCL Syntax: get_report_configs [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
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
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'report' objects of these types: 'run'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match report names against patterns Default: *</param>
		/// <returns>list of Configurable Report objects</returns>
		public TTCL get_report_configs(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_report_configs [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_report_configs(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of runs
		///
		///
		/// TCL Syntax: get_runs [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of synthesis and implementation runs in the current project that match a specified
		/// search pattern. The default command gets a list of all runs defined in the project.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of all incomplete runs in the current project:
		/// get_runs -filter {PROGRESS < 100}
		/// The following example gets a list of runs matching the specified pattern:
		/// get_runs imp*
		/// Note: If there are no runs matching the pattern you will get a warning.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 891
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'run' objects of these types: 'reconfig_module'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match run names against patterns Default: *</param>
		/// <returns>list of run objects</returns>
		public TTCL get_runs(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_runs [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_runs(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get selected objects
		///
		///
		/// TCL Syntax: get_selected_objects [-primary] [-quiet] [-verbose]
		///
		/// Gets the objects currently selected in the Vivado IDE by the select_objects command. Can
		/// get the primary selected object and any secondary selected objects as well.
		/// Note: This Tcl command works only when Vivado is run in GUI mode.
		/// Primary objects are directly selected, while secondary objects are selected based on the selection
		/// rules currently defined by the Tools → Settings command. Refer to the Vivado Design Suite User
		/// Guide: Using the IDE (UG893) for more information on setting selection rules.
		/// This command returns a Tcl list of selected objects, even a list with just one object. This can be an
		/// issue for some of the Vivado tool commands that do not accept a list of objects, such as the
		/// current_instance command. In this case you can use lindex to pass a specific object from
		/// the get_selected_objects list to the current_instance command:
		/// current_instance [lindex [get_selected_objects] 0]
		///
		/// The following example reports the properties of all currently selected objects, both primary and
		/// secondary:
		/// report_property [get_selected_objects]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 897
		/// </summary>
		/// <param name="primary">(Optional) Do not include objects that were selected due to selection rules</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of selected objects</returns>
		public TTCL get_selected_objects(bool? primary = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_selected_objects [-primary] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_selected_objects(primary, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of site_pins.
		///
		///
		/// TCL Syntax: get_site_pins [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns a list of site pins of the specified site, node, logical cell pin, or net objects in an open
		/// design.
		/// This command recommends the use of the -of_objects argument to prevent high run times
		/// and compute resources.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example returns the site_pins of the specified Nets:
		/// get_site_pins -of_objects [get_nets *Clk]
		/// IOB_X1Y24/I
		/// The following example returns the output site_pins associated with the site SLICE_X21Y92:
		/// get_site_pins -of_objects [get_sites SLICE_X21Y92] -filter
		/// {DIRECTION==OUT}
		/// SLICE_X21Y92/A SLICE_X21Y92/AMUX SLICE_X21Y92/AQ
		/// SLICE_X21Y92/B SLICE_X21Y92/BMUX SLICE_X21Y92/BQ
		/// SLICE_X21Y92/C SLICE_X21Y92/CMUX SLICE_X21Y92/COUT
		/// SLICE_X21Y92/CQ SLICE_X21Y92/D SLICE_X21Y92/DMUX
		/// SLICE_X21Y92/DQ
		///
		/// See ug835-vivado-tcl-commands.pdf, page 902
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'site_pin' objects of these types: 'site xdef_site node pin
		/// net bel_pin'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'site_pin' objects against patterns. Default: *</param>
		/// <returns>site_pins</returns>
		public TTCL get_site_pins(string of_objects = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_site_pins [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_site_pins(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of site_pips from the given object.
		///
		///
		/// TCL Syntax: get_site_pips [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Programmable interconnect points, or PIPs, provide the physical routing paths on the device used
		/// to connect logic networks. This command returns a list of PIPs on specified sites that match a
		/// specified search pattern. The command requires a design to be open.
		/// This command requires the use of the -of_objects option to specify the sites to return PIPs
		/// from.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example returns the pins of the specified BELs associated with the specified range
		/// of sites on the device:
		/// get_site_pips -of_objects [get_sites SLICE_X21Y92]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 905
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the site_pips of these sites.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match site_pips against patterns Default: *</param>
		/// <returns>site_pips</returns>
		public TTCL get_site_pips(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_site_pips [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_site_pips(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of Sites
		///
		///
		/// TCL Syntax: get_sites [-regexp] [-filter <arg>] [-nocase] [-range <args>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of sites on the target device that match a specified search pattern. The default
		/// command gets a list of all sites on the target device.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of all sites available on the target device:
		/// get_sites
		/// The following example returns the number of sites that are not currently used on the device.
		/// Both command forms in the example return the same results. The second command directly
		/// evaluates the IS_USED boolean property:
		/// llength [get_sites -filter {IS_USED==0}]
		/// -or￾llength [get_sites -filter !IS_USED]
		/// Note: If no sites match the pattern you will get a warning.
		/// The following example gets all of the sites on the device, and returns the unique SITE_TYPEs:
		/// set sites [get_sites]
		/// set type {}
		/// foreach x $sites {
		/// set prop [get_property SITE_TYPE $x]
		/// if { [lsearch -exact $type $prop] == -1 } {
		/// lappend type $prop
		/// }
		/// }
		/// foreach y $type {
		/// puts "SITE_TYPE: $y"
		/// }
		/// The following example shows three different forms for specifying the range of sites to return:
		/// get_sites -range {SLICE_X0Y0 SLICE_X1Y1}
		/// SLICE_X0Y0 SLICE_X0Y1 SLICE_X1Y0 SLICE_X1Y1
		/// get_sites -range SLICE_X0Y0 -range SLICE_X1Y1
		/// SLICE_X0Y0 SLICE_X0Y1 SLICE_X1Y0 SLICE_X1Y1
		/// get_sites -range {SLICE_X0Y0:SLICE_X1Y1}
		/// SLICE_X0Y0 SLICE_X0Y1 SLICE_X1Y0 SLICE_X1Y1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 908
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="range">
		/// (Optional)
		/// Match site names which fall into the range. Range is defined
		/// by exactly two site names.
		/// </param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get the sites of slrs, tiles, bels, pins, package_pins, ports,
		/// pblocks, nets, site_types, io_banks, cells, clock_regions or
		/// drc_violation
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// Match site names against patterns. Bonded sites will also
		/// match on package pin names. Default: *
		/// </param>
		/// <returns>list of site objects</returns>
		public TTCL get_sites(bool? regexp = null, string filter = null, bool? nocase = null, string range = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_sites [-regexp] [-filter <arg>] [-nocase] [-range <args>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_sites(regexp, filter, nocase, range, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of slrs.
		///
		///
		/// TCL Syntax: get_slrs [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Get a list of the super logic regions (SLRs) on the target device. On Devices that do not contain
		/// multiple SLRs, the SLR0 is returned.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example highlights each of the SLRs on the target device in a different color:
		/// foreach x [get_slrs] {
		/// incr i
		/// highlight_objects -color_index $i $x
		/// }
		/// Note: If there are no cells matching the pattern you will get a warning.
		/// The following example returns the number of super long lines (SLLs) between super logic regions
		/// on the current device:
		/// get_property NUM_SLLS [get_slrs SLR0]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 912
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get the slr of these device, tiles, sites, bels, sitepins, belpins,
		/// clock region, node, pip, pin, package pin, iobank, cell.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match slr against patterns Default: *</param>
		/// <returns>slr</returns>
		public TTCL get_slrs(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_slrs [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_slrs(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of speed_models in the device.
		///
		///
		/// TCL Syntax: get_speed_models [-of_objects <args>] [-regexp] [-nocase] [-patterns <arg>] [-filter <arg>] [-speed_pattern <arg>] [-quiet] [-verbose]
		///
		/// Get speed models for UltraScale architecture device resources in the current design.
		/// Speed files are provided by Xilinx for each device and speed grade. Speed files contain speed
		/// models. There are speed models for the various elements of a device: nodes, pips, bels. There are
		/// speed models for setup and hold, propagation delays, jitter, etc.
		/// The speed models include information on the delays in nanoseconds (ns) associated with device
		/// resources like BELs and SITEs and routing resources. Speed models are used by the Vivado
		/// timing engine to perform analysis of the current design in the context of the target part.
		/// The objects returned are the speed models associated with specific physical resources like pips
		/// and wires, drawn directly from the speed files. These can include capacitance and resistance
		/// values and buffer models.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		/// This command returns the specified speed model objects, or returns an error if the command
		/// fails.
		///
		/// The following example reports the properties on the speed model for an A6LUT:
		/// report_property -all [lindex [get_speed_models -of \
		/// [get_bels SLICE_X0Y0/A6LUT]] 0]
		/// Property Type Read-only Value
		/// CLASS string true speed_model
		/// DELAY double true 0.043
		/// FAST_MAX double true 0.035
		/// FAST_MIN double true 0.028
		/// IS_INSTANCE_SPECIFIC bool true 1
		/// NAME string true bel_d_lut6_a1_o6
		/// NAME_LOGICAL string true bel_d_lut6_a1_o6
		/// SLOW_MAX double true 0.043
		/// SLOW_MIN double true 0.036
		/// SPEED_INDEX int true 65535
		/// TYPE string true bel_delay
		/// The following example returns the delays, in nanoseconds, for a specific A6LUT on the device,
		/// followed by the delay name for the specified object:
		/// set x [get_speed_models -of [get_bels SLICE_X0Y0/A6LUT]]
		/// puts [format "%6.3f : %s" [get_property DELAY [lindex $x 0 ]] \
		/// [get_property NAME [lindex $x 0 ]]]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 915
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'speed_model' objects of these types: 'node bel pip cell'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="patterns">(Optional) Match the 'speed_model' objects against patterns. Default: *</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="speed_pattern">(Optional) Returns a single model that exactly matches the pattern.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>speed_models</returns>
		public TTCL get_speed_models(string of_objects = null, bool? regexp = null, bool? nocase = null, string patterns = null, string filter = null, string speed_pattern = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_speed_models [-of_objects <args>] [-regexp] [-nocase] [-patterns <arg>] [-filter <arg>] [-speed_pattern <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_speed_models(of_objects, regexp, nocase, patterns, filter, speed_pattern, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of tiles.
		///
		///
		/// TCL Syntax: get_tiles [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// This command returns a list of tiles on the device in an open design. The default command gets a
		/// list of all tiles on the device.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example returns the total number of tiles where the number of timing arcs is
		/// greater than 100 and 150 respectively:
		/// llength [get_tiles -filter {NUM_ARCS>100} ]
		/// 13468
		/// llength [get_tiles -filter {NUM_ARCS>150} ]
		/// 11691
		///
		/// See ug835-vivado-tcl-commands.pdf, page 922
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// (Optional)
		/// Get the tiles of these slr, sites, bels, site_pins, bel_pins,
		/// nodes, wires, pips, nets, clock_regions.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match tiles against patterns Default: *</param>
		/// <returns>tiles</returns>
		public TTCL get_tiles(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_tiles [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_tiles(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of timing arcs
		///
		///
		/// TCL Syntax: get_timing_arcs [-from <args>] [-to <args>] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose]
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
		/// <param name="from">(Optional) List of pin or ports</param>
		/// <param name="to">(Optional) List of pin or ports</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get timing arcs for these cells</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of timing arc objects</returns>
		public TTCL get_timing_arcs(string from = null, string to = null, string filter = null, string of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_timing_arcs [-from <args>] [-to <args>] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_timing_arcs(from, to, filter, of_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get timing paths
		///
		///
		/// TCL Syntax: get_timing_paths [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-through <args>] [-rise_through <args>] [-fall_through <args>] [-delay_type <arg>] [-setup] [-hold] [-max_paths <arg>] [-nworst <arg>] [-unique_pins] [-slack_lesser_than <arg>] [-slack_greater_than <arg>] [-group <args>] [-no_report_unconstrained] [-user_ignored] [-routable_nets] [-sort_by <arg>] [-filter <arg>] [-regexp] [-nocase] [-cell <args>] [-quiet] [-verbose]
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
		/// (Optional)
		/// Type of path delay: Values: max, min, min_max, max_rise,
		/// max_fall, min_rise, min_fall Default: max
		/// </param>
		/// <param name="setup">(Optional) Get max delay timing paths (equivalent to -delay_type max)</param>
		/// <param name="hold">(Optional) Get min delay timing paths (equivalent to -delay_type min)</param>
		/// <param name="max_paths">(Optional) Maximum number of paths to return: Value >=1 Default: 1</param>
		/// <param name="nworst">(Optional) List N worst paths to endpoint: Value >=1 Default: 1</param>
		/// <param name="unique_pins">(Optional) for each unique set of pins, show at most 1 path per path group</param>
		/// <param name="slack_lesser_than">(Optional) Include paths with slack less than this Default: 1e+30</param>
		/// <param name="slack_greater_than">(Optional) Include paths with slack greater than this Default: -1e+30</param>
		/// <param name="group">(Optional) Limit paths in this group(s)</param>
		/// <param name="no_report_unconstrained">(Optional) Do not get unconstrained paths</param>
		/// <param name="user_ignored">
		/// (Optional)
		/// only report paths which have infinite slack because of
		/// set_false_path or set_clock_groups timing constraints
		/// </param>
		/// <param name="routable_nets">
		/// (Optional)
		/// store the number of routable nets traversed as a property
		/// on timing paths.
		/// </param>
		/// <param name="sort_by">(Optional) Sorting order of paths: Values: group, slack Default: slack</param>
		/// <param name="filter">(Optional) Filter list with expression Name Description</param>
		/// <param name="regexp">(Optional) Patterns specified in filter are full regular expressions</param>
		/// <param name="nocase">
		/// (Optional)
		/// Perform case-insensitive matching for patterns specified in
		/// filter (valid only when -regexp specified)
		/// </param>
		/// <param name="cell">(Optional) run get_timing_paths on the cell</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL get_timing_paths(string from = null, string rise_from = null, string fall_from = null, string to = null, string rise_to = null, string fall_to = null, string through = null, string rise_through = null, string fall_through = null, string delay_type = null, bool? setup = null, bool? hold = null, string max_paths = null, string nworst = null, bool? unique_pins = null, string slack_lesser_than = null, string slack_greater_than = null, string group = null, bool? no_report_unconstrained = null, bool? user_ignored = null, bool? routable_nets = null, string sort_by = null, string filter = null, bool? regexp = null, bool? nocase = null, string cell = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_timing_paths [-from <args>] [-rise_from <args>] [-fall_from <args>] [-to <args>] [-rise_to <args>] [-fall_to <args>] [-through <args>] [-rise_through <args>] [-fall_through <args>] [-delay_type <arg>] [-setup] [-hold] [-max_paths <arg>] [-nworst <arg>] [-unique_pins] [-slack_lesser_than <arg>] [-slack_greater_than <arg>] [-group <args>] [-no_report_unconstrained] [-user_ignored] [-routable_nets] [-sort_by <arg>] [-filter <arg>] [-regexp] [-nocase] [-cell <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_timing_paths(from, rise_from, fall_from, to, rise_to, fall_to, through, rise_through, fall_through, delay_type, setup, hold, max_paths, nworst, unique_pins, slack_lesser_than, slack_greater_than, group, no_report_unconstrained, user_ignored, routable_nets, sort_by, filter, regexp, nocase, cell, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get one or more DRC/METHODOLOGY/CDC message waivers
		///
		///
		/// TCL Syntax: get_waivers [-type <arg>] [-id <arg>] [-of_objects <args>] [-regexp] [-filter <arg>] [-nocase] [-quiet] [-verbose] [<patterns>]
		///
		/// The create_waiver command lets you select individual DRC, methodology, or CDC violations
		/// or rule checks that can be waived for a design, letting you move forward in the design flow. The
		/// get_waivers command lets you query the defined waiver objects in the current design.
		/// A waiver must be specified for an individual DRC or methodology violation, or for a specific DRC
		/// or methodology check, or for a CDC path. The waiver must be assigned to a specific object, or
		/// specific violation ID, or for paths using -from/-to arguments. You can format the
		/// get_waivers command to return the specific types of waivers you are looking for, or waivers
		/// associated with specific objects.
		/// You can report the waivers defined in the current design with report_waivers, and remove
		/// waivers from the design using delete_waivers.
		///
		/// This example gets any waivers in the current design:
		/// get_waivers
		/// The following example gets all DRC check waivers:
		/// get_waivers -type DRC *
		/// The following example gets all waivers associated with the specified objects:
		/// get_waivers -of_objects [get_ports {src_in* dest_out*}]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 936
		/// </summary>
		/// <param name="type">(Optional) Type of waiver - DRC, METHODOLOGY, CDC, ALL</param>
		/// <param name="id">(Optional) ID of the DRC/METHODOLOGY/CDC message being waived</param>
		/// <param name="of_objects">
		/// (Optional)
		/// List of objects (cells, nets, pins, sites, etc.) for which DRC/
		/// METHODLOGY/CDC waiver(s) were set
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// Match waiver names against patterns Default: * Values: The
		/// default search pattern is the wildcard *, or .* when -regexp
		/// is specified.
		/// </param>
		/// <returns>waivers</returns>
		public TTCL get_waivers(string type = null, string id = null, string of_objects = null, bool? regexp = null, string filter = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_waivers [-type <arg>] [-id <arg>] [-of_objects <args>] [-regexp] [-filter <arg>] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_waivers(type, id, of_objects, regexp, filter, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of wires.
		///
		///
		/// TCL Syntax: get_wires [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-uphill] [-downhill] [-from <args>] [-to <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns a list of wires in the design that match a specified search pattern in an open design.
		/// The default command gets a list of all wires in the design.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example returns the wires associated with the specified tile:
		/// get_wires -of_objects [get_tiles IO_INT_INTERFACE_L_X0Y198]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 943
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the wires of these tiles, nodes, pips, or nets.</param>
		/// <param name="uphill">(Optional) Get the wires uphill from the provided pip.</param>
		/// <param name="downhill">(Optional) Get the wires downhill from the provided pip.</param>
		/// <param name="from">
		/// (Optional)
		/// -from <pip/site pin> Return the ordered list of wires
		/// beginning at this pip or site pin. May be used in
		/// combination with uphill. Default is downhill. -all is implied.
		/// </param>
		/// <param name="to">
		/// (Optional)
		/// -to <pip/site pin> Return the ordered list of wires ending at
		/// this wire or site pin. May be used in combination with uphill.
		/// Default is downhill. -all is implied.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match wires against patterns Default: *</param>
		/// <returns>wires</returns>
		public TTCL get_wires(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? uphill = null, bool? downhill = null, string from = null, string to = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_wires [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-uphill] [-downhill] [-from <args>] [-to <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_wires(regexp, nocase, filter, of_objects, uphill, downhill, from, to, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Return probe sample values
		///
		///
		/// TCL Syntax: list_hw_samples [-quiet] [-verbose] [<hw_probe>]
		///
		/// Writes data samples from the specified hw_probe object on the current hw_ila.
		/// The number of captured samples returned from the specified probe is equal to the DATA_DEPTH
		/// property of the ILA core. The default data depth is 1024 samples. Data values are returned in the
		/// radix specified for the hw_probe, as determined by the DISPLAY_RADIX property.
		/// TIP: For any samples to be returned, data must have been captured by the specified port.
		/// The values are listed to the standard output, or can be captured to a Tcl variable for post￾processing, or output to a file.
		/// The following is an example Tcl script that lists the data samples from hw_probes of interest:
		/// # Define a list of probes to get the data samples from
		/// set probeList [get_hw_probes *AR*]
		/// #Specify the radix for the return values
		/// set_property DISPLAY_RADIX BINARY [get_hw_probes *AR*]
		/// # Define a filename to write data to
		/// set fileName C:/Data/probeData1.txt
		/// # Open the specified file in write mode
		/// set FH [open $fileName w]
		/// # Write probe data for each probe
		/// foreach x $probeList {
		/// puts $FH "$x:"
		/// puts $FH [list_hw_samples $x]
		/// }
		/// # Close the output file
		/// close $FH
		/// puts "Probe data written to $fileName\n"
		/// This command returns the requested output, or returns an error if it fails.
		///
		/// The following example returns the data samples for the specified probe:
		/// list_hw_samples [get_hw_probes *probe18]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1007
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_probe">(Optional) hw_probe object</param>
		/// <returns>samples</returns>
		public TTCL list_hw_samples(bool? quiet = null, bool? verbose = null, string hw_probe = null)
		{
			// TCL Syntax: list_hw_samples [-quiet] [-verbose] [<hw_probe>]
			_tcl.Entry(_builder.list_hw_samples(quiet, verbose, hw_probe));
			return _tcl;
		}
		/// <summary>
		/// List properties of object
		///
		///
		/// TCL Syntax: list_property [-class <arg>] [-regexp] [-quiet] [-verbose] [<object>] [<pattern>]
		///
		/// Gets a list of all properties on a specified object or class.
		/// Note: report_property also returns a list of properties on an object or class of objects, but also reports
		/// the property type and property value.
		///
		/// The following example returns all properties of the specified CELL object:
		/// list_property [get_cells cpuEngine]
		/// The following example returns the properties matching the specified search pattern from the BEL
		/// class of objects:
		/// list_property -class bel *NUM*
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1011
		/// </summary>
		/// <param name="@class">(Optional) Object type to query for properties. Ignored if object is specified.</param>
		/// <param name="regexp">(Optional) Pattern is treated as a regular expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="@object">(Optional) Object to query for properties</param>
		/// <param name="pattern">(Optional) Pattern to match properties against Default: *</param>
		/// <returns>list of property names</returns>
		public TTCL list_property(string @class = null, bool? regexp = null, bool? quiet = null, bool? verbose = null, string @object = null, string pattern = null)
		{
			// TCL Syntax: list_property [-class <arg>] [-regexp] [-quiet] [-verbose] [<object>] [<pattern>]
			_tcl.Entry(_builder.list_property(@class, regexp, quiet, verbose, @object, pattern));
			return _tcl;
		}
		/// <summary>
		/// List legal property values of object
		///
		///
		/// TCL Syntax: list_property_value [-default] [-class <arg>] [-quiet] [-verbose] <name> [<object>]
		///
		/// Gets a list of valid values for an enumerated type property of either a class of objects or a
		/// specific object.
		/// Note: The command cannot be used to return valid values for properties other than Enum properties. The
		/// report_property command will return the type of property to help you identify Enum properties.
		///
		/// The following example returns the list of valid values for the KEEP_HIERARCHY property from
		/// cell objects:
		/// list_property_value KEEP_HIERARCHY -class cell
		/// The following example returns the same result, but uses an actual cell object in place of the
		/// general cell class:
		/// list_property_value KEEP_HIERARCHY [get_cells cpuEngine]
		/// The following example returns the default value for the specified property by using the current
		/// design as a representative of the design class:
		/// list_property_value -default BITSTREAM.GENERAL.COMPRESS [current_design]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1013
		/// </summary>
		/// <param name="name">(Required) Name of property whose legal values is to be retrieved</param>
		/// <param name="@default">(Optional) Show only the default value.</param>
		/// <param name="@class">
		/// (Optional)
		/// Object type to query for legal property values. Ignored if
		/// object is specified.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="@object">(Optional) Object to query for legal properties values</param>
		/// <returns>list of property values</returns>
		public TTCL list_property_value(string name, bool? @default = null, string @class = null, bool? quiet = null, bool? verbose = null, string @object = null)
		{
			// TCL Syntax: list_property_value [-default] [-class <arg>] [-quiet] [-verbose] <name> [<object>]
			_tcl.Entry(_builder.list_property_value(name, @default, @class, quiet, verbose, @object));
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
		/// Report properties of object
		///
		///
		/// TCL Syntax: report_property [-all] [-class <arg>] [-return_string] [-file <arg>] [-append] [-regexp] [-quiet] [-verbose] [<object>] [<pattern>]
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
		/// <param name="all">(Optional) Report all properties of object even if not set</param>
		/// <param name="@class">(Optional) Object type to query for properties. Not valid with <object></param>
		/// <param name="return_string">
		/// (Optional)
		/// Set the result of running report_property in the Tcl
		/// interpreter's result variable
		/// </param>
		/// <param name="file">
		/// (Optional)
		/// Filename to output result to. Send output to console if -file
		/// is not used
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="regexp">(Optional) Pattern is treated as a regular expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="@object">(Optional) Object to query for properties</param>
		/// <param name="pattern">(Optional) Pattern to match properties against Default: *</param>
		/// <returns>property report</returns>
		public TTCL report_property(bool? all = null, string @class = null, bool? return_string = null, string file = null, bool? append = null, bool? regexp = null, bool? quiet = null, bool? verbose = null, string @object = null, string pattern = null)
		{
			// TCL Syntax: report_property [-all] [-class <arg>] [-return_string] [-file <arg>] [-append] [-regexp] [-quiet] [-verbose] [<object>] [<pattern>]
			_tcl.Entry(_builder.report_property(all, @class, return_string, file, append, regexp, quiet, verbose, @object, pattern));
			return _tcl;
		}
		/// <summary>
		/// Recommend QoR Suggestions
		///
		///
		/// TCL Syntax: report_qor_suggestions [-file <arg>] [-name <arg>] [-append] [-return_string] [-max_strategies <arg>] [-max_paths <arg>] [-evaluate_pipelining] [-no_split] [-models_dir <arg>] [-cell <args>] [-of_objects <args>] [-quiet] [-verbose]
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
		/// <param name="file">
		/// (Optional)
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="return_string">(Optional) Return report as string</param>
		/// <param name="max_strategies">(Optional) Number of strategies to suggest Default: 3</param>
		/// <param name="max_paths">(Optional) Number of paths to consider for suggestion analysis Default: 100</param>
		/// <param name="evaluate_pipelining">(Optional) Generate DSP/BRAM pipelining xdc file</param>
		/// <param name="no_split">(Optional) Report without spliting the lines in tables</param>
		/// <param name="models_dir">
		/// (Optional)
		/// Path to the directory which consists of the models Default: /
		/// proj/rdi-xco/builds/HEAD/nightly/RUNNING_ BUILD/
		/// packages/customer/vivado/data/deca/models_dir
		/// </param>
		/// <param name="cell">(Optional) Report QOR suggestions for a given cell</param>
		/// <param name="of_objects">(Optional) List of QoR suggestion objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_qor_suggestions(string file = null, string name = null, bool? append = null, bool? return_string = null, string max_strategies = null, string max_paths = null, bool? evaluate_pipelining = null, bool? no_split = null, string models_dir = null, string cell = null, string of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_qor_suggestions [-file <arg>] [-name <arg>] [-append] [-return_string] [-max_strategies <arg>] [-max_paths <arg>] [-evaluate_pipelining] [-no_split] [-models_dir <arg>] [-cell <args>] [-of_objects <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_qor_suggestions(file, name, append, return_string, max_strategies, max_paths, evaluate_pipelining, no_split, models_dir, cell, of_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Report status of DRC/METHODOLOGY/CDC message waivers
		///
		///
		/// TCL Syntax: report_waivers [-file <arg>] [-type <arg>] [-write_valid_waivers] [-write_ignored_waivers] [-append] [-return_string] [-show_msgs_with_no_waivers] [-quiet] [-verbose]
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
		/// <param name="file">(Optional) Name of file to report waivers</param>
		/// <param name="type">(Optional) Type of waiver - ALL, DRC, METHODOLOGY, CDC</param>
		/// <param name="write_valid_waivers">
		/// (Optional)
		/// (special) Specifies writing out the specific waivers which
		/// were used in the last report_drc/methodology/cdc run(s)
		/// </param>
		/// <param name="write_ignored_waivers">
		/// (Optional)
		/// (special) Specifies writing out the specific waivers which
		/// were NOT used in the last report_drc/methodology/cdc
		/// run(s)
		/// </param>
		/// <param name="append">(Optional) Append the current report results to the file specified with - file</param>
		/// <param name="return_string">(Optional) Return report results as a string object</param>
		/// <param name="show_msgs_with_no_waivers">
		/// (Optional)
		/// also list report_drc/methodology/cdc messages which have
		/// no defined waivers
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_waivers(string file = null, string type = null, bool? write_valid_waivers = null, bool? write_ignored_waivers = null, bool? append = null, bool? return_string = null, bool? show_msgs_with_no_waivers = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_waivers [-file <arg>] [-type <arg>] [-write_valid_waivers] [-write_ignored_waivers] [-append] [-return_string] [-show_msgs_with_no_waivers] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_waivers(file, type, write_valid_waivers, write_ignored_waivers, append, return_string, show_msgs_with_no_waivers, quiet, verbose));
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
		/// See ug835-vivado-tcl-commands.pdf, page 1463
		/// </summary>
		/// <param name="checks">(Required) The list of checks to reset.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_methodology_check(string checks, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_methodology_check [-quiet] [-verbose] [<checks>...]
			_tcl.Entry(_builder.reset_methodology_check(checks, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Reset property on object(s)
		///
		///
		/// TCL Syntax: reset_property [-quiet] [-verbose] <property_name> <objects>...
		///
		/// Restores the specified property to its default value on the specified object or objects. If no
		/// default is defined for the property, the property is unassigned on the specified object.
		///
		/// The following example sets the DOB_REG property on the specified Block RAM, and then resets
		/// the property:
		/// set_property DOB_REG 1 [get_cells usbEngine1/usbEngineSRAM/
		/// snoopyRam_reg_19]
		/// reset_property DOB_REG [get_cells usbEngine1/usbEngineSRAM/
		/// snoopyRam_reg_19]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1478
		/// </summary>
		/// <param name="property_name">(Required) Name of property to reset</param>
		/// <param name="objects">(Required) Objects to set properties</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The value that was set if success, "" if failure</returns>
		public TTCL reset_property(string property_name, string objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_property [-quiet] [-verbose] <property_name> <objects>...
			_tcl.Entry(_builder.reset_property(property_name, objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// change to a stable state of a specified transition
		///
		///
		/// TCL Syntax: run_state_hw_jtag [-state <args>] [-quiet] [-verbose] <stable_state>
		///
		/// Transition the hw_jtag object of the current hardware target to the specified TAP stable state.
		/// A hw_jtag object is created by the Hardware Manager feature of the Vivado Design Suite when a
		/// hardware target is opened in JTAG mode using the open_hw_target -jtag_mode command.
		/// The run_state_hw_jtag command specifies:
		/// • An ending or target TAP stable state to transition to.
		/// • An optional state path list to transition through to get from the current state to the target
		/// state.
		/// If an optional -state path list is defined, then the state list must contain all states needed to
		/// reach the stable state, or the command will return an error. If no state path list is defined, then
		/// the command will transition from the current state to the target state according to the state
		/// transition paths defined in the following table:
		/// Current Target State Transition Path
		/// State State
		/// DRPAUSE RESET DRPAUSE -> DREXIT2 -> DRUPDATE -> DRSELECT ->
		/// IRSELECT-> RESET
		/// DRPAUSE IDLE DRPAUSE -> DREXIT2 -> DRUPDATE -> IDLE
		/// DRPAUSE DRPAUSE DRPAUSE -> DREXIT2 -> DRUPDATE -> DRSELECT ->
		/// DRCAPTURE -> DREXIT1 -> DRPAUSE
		/// DRPAUSE IRPAUSE DRPAUSE -> DREXIT2 -> DRUPDATE -> DRSELECT ->
		/// IRSELECT -> IRCAPTURE -> IREXIT12 -> IRPAUSE
		/// IDLE RESET IDLE -> DRSELECT -> IRSELECT -> RESET
		/// IDLE IDLE IDLE
		/// IDLE DRPAUSE IDLE -> DRSELECT -> DRCAPTURE -> DREXIT1 ->
		/// DRPAUSE
		/// IDLE IRPAUSE IDLE -> DRPAUSE -> IRSELECT ->IRCAPTURE ->
		/// IREXIT1 -> IRPAUSE
		/// IRPAUSE RESET IRPAUSE -> IREXIT2 -> IRUPDATE -> DRSELECT ->
		/// IRSELECT -> RESET
		/// IRPAUSE IDLE IRPAUSE -> IREXIT2 -> IRUPDATE -> IDLE
		/// IRPAUSE DRPAUSE IRPAUSE -> IREXIT2 -> IRUPDATE -> DRSELECT ->
		/// DRCAPTURE -> DREXIT1 -> DRPAUSE
		/// IRPAUSE IRPAUSE IRPAUSE -> IREXIT2 -> IRUPDATE -> DRSELECT ->
		/// IRSELECT -> IRCAPTURE -> IREXIT1 -> IRPAUSE
		/// RESET RESET RESET
		/// RESET IDLE RESET -> IDLE
		/// RESET DRPAUSE RESET -> IDLE -> DRSELECT -> DRCAPTURE ->
		/// DREXIT1 -> DRPAUSE
		/// RESET IRPAUSE RESET -> IDLE -> DRSELECT -> IRSELECT ->
		/// IRCAPTURE -> IREXIT1 -> IRPAUSE
		/// This command returns the target stable state when successful, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1528
		/// </summary>
		/// <param name="stable_state">
		/// (Required)
		/// valid stable_state - valid stable states IDLE, RESET, IRPAUSE,
		/// and DRPAUSE
		/// </param>
		/// <param name="state">(Optional) valid state path sequence to stable_state</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>hardware JTAG</returns>
		public TTCL run_state_hw_jtag(string stable_state, string state = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: run_state_hw_jtag [-state <args>] [-quiet] [-verbose] <stable_state>
			_tcl.Entry(_builder.run_state_hw_jtag(stable_state, state, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Forces IEEE 1149.1 TAP state machine to a stable state for a specified wait period
		///
		///
		/// TCL Syntax: runtest_hw_jtag [-wait_state <arg>] [-end_state <arg>] [-sec <arg>] [-max_wait <arg>] [-tck <arg>] [-quiet] [-verbose]
		///
		/// Specify a wait operation for the hw_jtag object state machine which defines:
		/// • Which TAP stable state to go to perform the wait operation.
		/// • A wait time expressed as:
		/// ○ 'n' TCK cycles, where 'n' is a 32-bit unsigned decimal number.
		/// ○ A minimum and optionally maximum time in seconds to stay in the wait state, with
		/// min/max times specified as unsigned integers or real numbers.
		/// • The TAP stable state to go after the wait operation has completed.
		/// The default values for -wait_state and -end_state are IDLE. If a non-IDLE wait_state or
		/// end_state are defined, then the hw_jtag object will first transition to the specified wait_state
		/// before starting the wait operation. Once the wait time has elapsed, the hw_jtag object transitions
		/// to the specified end_state. When the wait_state and/or end_state are specified by the
		/// runtest_hw_jtag command, subsequent commands will use the same wait_state/end_state
		/// unless they are changed.
		/// This command returns the end stable state, or returns an error if it fails.
		/// Note: If the command cannot meet the wait time specification, then it will raise an exception that can be
		/// trapped by the Tcl catch command.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1531
		/// </summary>
		/// <param name="wait_state">
		/// (Optional)
		/// valid stable_state - valid stable states IDLE, RESET, IRPAUSE,
		/// and DRPAUSE
		/// </param>
		/// <param name="end_state">
		/// (Optional)
		/// valid stable_state - valid stable states IDLE, RESET, IRPAUSE,
		/// and DRPAUSE
		/// </param>
		/// <param name="sec">(Optional) Number of seconds to wait in wait_state</param>
		/// <param name="max_wait">(Optional) Maximum Number of seconds to wait in wait_state - max timeout</param>
		/// <param name="tck">
		/// (Optional)
		/// Number of TCK cycles to wait in wait_state Default: Number
		/// of TCK cycles to wait in wait_state
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL runtest_hw_jtag(string wait_state = null, string end_state = null, string sec = null, string max_wait = null, string tck = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: runtest_hw_jtag [-wait_state <arg>] [-end_state <arg>] [-sec <arg>] [-max_wait <arg>] [-tck <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.runtest_hw_jtag(wait_state, end_state, sec, max_wait, tck, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Perform shift DR on 'hw_jtag'.
		///
		///
		/// TCL Syntax: scan_dr_hw_jtag [-tdi <arg>] [-tdo <arg>] [-mask <arg>] [-smask <arg>] [-quiet] [-verbose] <length>
		///
		/// The scan_dr_hw_jtag command specifies a scan pattern to be scanned into the JTAG
		/// interface target data register.
		/// The command targets a hw_jtag object which is created when the hw_target is opened in JTAG
		/// mode through the use of the open_hw_target -jtag_mode command.
		/// When targeting the hw_jtag object prior to shifting the scan pattern specified in the
		/// scan_dr_hw_jtag command, the last defined header property (HDR) will be pre-pended to the
		/// beginning of the specified data pattern, and the last defined trailer property (TDR) will be
		/// appended to the end of the data pattern.
		/// The options can be specified in any order, but can only be specified once. The number of bits
		/// represented by the hex strings specified for -tdi, -tdo, -mask, or -smask cannot be greater
		/// than the maximum specified by <length>. Leading zeros are assumed for a hex string if the
		/// number of bits represented by the hex strings specified is less than the <length>.
		/// When shifting the data bits to the target data register, the scan_dr_hw_jtag command moves
		/// the JTAG TAP from the current stable state to the DRSHIFT state according to the state
		/// transition table below:
		/// Current State Transitions to get to DRSHIFT state
		/// RESET IDLE -> DRSELECT -> DRCAPTURE -> DRSHIFT
		/// IDLE DRSELECT -> DRCAPTURE ->
		/// DRSHIFT
		/// IRPAUSE IREXIT2 -> IRUPDATE -> DRSELECT -> DRCAPTURE ->
		/// DRSHIFT
		/// DRPAUSE DREXIT2 ->
		/// DRSHIFT
		/// DRPAUSE* DREXIT2 -> DRUPDATE -> DRSELECT -> DRCAPTURE -> DRSHIFT
		/// Note: * With -force_update option set.
		/// After the last data bit is shifted into the target data register, the scan_dr_hw_jtag command
		/// moves the JTAG TAP to the IDLE state, or to the stable state defined by the
		/// run_state_hw_jtag command.
		/// The scan_dr_hw_jtag command returns a hex array containing captured TDO data from the
		/// hw_jtag, or returns an error if it fails.
		/// The command raises an error that can be trapped by the Tcl catch command if TDO data from
		/// the hw_jtag does not match specified -tdo argument.
		/// TIP: If -tdo and -mask arguments are specified, then the mask is applied to the -tdo option and the hw_jtag
		/// TDO data returned before comparing the two.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1547
		/// </summary>
		/// <param name="length">(Required) Number of bits to be scanned.</param>
		/// <param name="tdi">(Optional) Hex value to be scanned into the target</param>
		/// <param name="tdo">(Optional) Hex value to be compared against the scanned value</param>
		/// <param name="mask">(Optional) Hex value mask applied when comparing TDO values</param>
		/// <param name="smask">(Optional) Hex value mask applied to TDI value</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>hardware TDO</returns>
		public TTCL scan_dr_hw_jtag(string length, string tdi = null, string tdo = null, string mask = null, string smask = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: scan_dr_hw_jtag [-tdi <arg>] [-tdo <arg>] [-mask <arg>] [-smask <arg>] [-quiet] [-verbose] <length>
			_tcl.Entry(_builder.scan_dr_hw_jtag(length, tdi, tdo, mask, smask, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Perform shift IR on 'hw_jtag'.
		///
		///
		/// TCL Syntax: scan_ir_hw_jtag [-tdi <arg>] [-tdo <arg>] [-mask <arg>] [-smask <arg>] [-quiet] [-verbose] <length>
		///
		/// The scan_ir_hw_jtag command specifies a scan pattern to be scanned into the JTAG
		/// interface target instruction register.
		/// The command targets a hw_jtag object which is created when the hw_target is opened in JTAG
		/// mode through the use of the open_hw_target -jtag_mode command.
		/// When targeting the hw_jtag object prior to shifting the scan pattern specified in the
		/// scan_ir_hw_jtag command, the last defined header property (HIR) will be pre-pended to the
		/// beginning of the specified data pattern, and the last defined trailer property (TIR) will be
		/// appended to the end of the data pattern.
		/// The options can be specified in any order, but can only be specified once. The number of bits
		/// represented by the hex strings specified for -tdi, -tdo, -mask, or -smask cannot be greater
		/// than the maximum specified by <length>. Leading zeros are assumed for a hex string if the
		/// number of bits represented by the hex strings specified is less than the <length>.
		/// When shifting the bits into the target instruction register, the scan_ir_hw_jtag command
		/// moves the JTAG TAP from the current stable state to the IRSHIFT state according to the state
		/// transition table below:
		/// Current Transitions to get to
		/// State IRSHIFT state
		/// RESET IDLE > DRSELECT > IRSELECT > IRCAPTURE > IRSHIFT
		/// IDLE IRSELECT > IRCAPTURE > IRSHIFT
		/// DRPAUSE DREXIT2 > DRUPDATE > DRSELECT > IRSELECT > IRCAPTURE > IRSHIFT
		/// IRPAUSE IREXIT2 > IRSHIFT
		/// IRPAUSE* IREXIT2 > IRUPDATE > DRSELECT > IRSELECT > IRCAPTURE > IRSHIFT
		/// Note: * With -force_update option set.
		/// After the last data bit is shifted into the target data register, the scan_ir_hw_jtag command
		/// moves the JTAG TAP to the IDLE state, or to the stable state defined by the run_state_hw_jtag
		/// command.
		/// The scan_ir_hw_jtag command returns a hex array containing captured TDO data from the
		/// hw_jtag, or returns an error if it fails.
		/// The command raises an error that can be trapped by the Tcl catch command if TDO data from
		/// the hw_jtag does not match specified -tdo argument.
		/// TIP: If -tdo and -mask arguments are specified, then the mask is applied to the -tdo option and the hw_jtag
		/// TDO data returned before comparing the two.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1551
		/// </summary>
		/// <param name="length">(Required) Number of bits to be scanned.</param>
		/// <param name="tdi">(Optional) Hex value to be scanned into the target</param>
		/// <param name="tdo">(Optional) Hex value to be compared against the scanned value</param>
		/// <param name="mask">(Optional) Hex value mask applied when comparing TDO values</param>
		/// <param name="smask">(Optional) Hex value mask applied to TDI value</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>hardware TDO</returns>
		public TTCL scan_ir_hw_jtag(string length, string tdi = null, string tdo = null, string mask = null, string smask = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: scan_ir_hw_jtag [-tdi <arg>] [-tdo <arg>] [-mask <arg>] [-smask <arg>] [-quiet] [-verbose] <length>
			_tcl.Entry(_builder.scan_ir_hw_jtag(length, tdi, tdo, mask, smask, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Set property on object(s)
		///
		///
		/// TCL Syntax: set_property [-dict <args>] [-quiet] [-verbose] <name> <value> <objects>...
		///
		/// Assigns the defined property <name> and <value> to the specified <objects>.
		/// This command can be used to define any property on an object in the design. Each object has a
		/// set of predefined properties that have expected values, or a range of values. The set_property
		/// command can be used to define the values for these properties. To determine the defined set of
		/// properties on an object, use report_property, list_property, or
		/// list_property_values.
		/// You can also define custom properties for an object, by specifying a unique <name> and <value>
		/// pair for the object. If an object has custom properties, these will also be reported by the
		/// report_property and list_property commands.
		/// This command returns nothing if successful, and an error if it fails.
		/// TIP: You can use the get_property command to validate any properties that have been set on an object.
		///
		/// Create a user-defined boolean property, TRUTH, for cell objects, and set the property on a cell:
		/// create_property -type bool truth cell
		/// set_property truth false [lindex [get_cells] 1]
		/// Use the -dict option to specify multiple properties at one time on the current design:
		/// set_property -dict "POST_CRC enable POST_CRC_ACTION correct_and_continue"
		/// \
		/// [current_design]
		/// The following example sets the TOP property of the current fileset to define the top module of
		/// the project:
		/// set_property top fftTop [current_fileset]
		/// set_property top_file {C:/Data/sources/fftTop.v} [current_fileset]
		/// Note: Defining the top module requires the TOP property to be set to the desired hierarchical block in the
		/// source fileset of the current project. In the preceding example TOP is the property name, fftTop is the
		/// value, and current_fileset is the object. In addition, the TOP_FILE property should be defined to point to
		/// the data source for the top module.
		/// This example shows how to set a property value that includes the dash character, '-'. The dash
		/// can cause the tool to interpret the value as a new command argument, rather than part of the
		/// value being specified, and will cause an error as shown. In this case, you must use the explicit
		/// form of the positional arguments in the set_property command:
		/// set_property {XELAB.MORE_OPTIONS} {-pulse_e_style ondetect} \
		/// [get_filesets sim_1]
		/// ERROR: [Common 17-170] Unknown option '-pulse_e_style ondetect',
		/// please type 'set_property -help' for usage info.
		/// set_property -name {XELAB.MORE_OPTIONS} -value {-pulse_e_style ondetect}\
		/// -objects [get_filesets sim_1]
		/// The following example sets the internal VREF property value for the specified IO Bank:
		/// set_property internal_vref {0.75} [get_iobanks 0]
		/// The following example defines a DCI Cascade by setting the DCI_CASCADE property for the
		/// specified IO Bank:
		/// set_property DCI_CASCADE {14} [get_iobanks 0 ]
		/// The following example configures the synth_1 run, setting options for Vivado Synthesis 2013,
		/// and then launches the synthesis run:
		/// set_property flow {Vivado Synthesis 2016} \
		/// [get_runs synth_1]
		/// set_property STEPS.SYNTH_DESIGN.ARGS.FANOUT_LIMIT 500 \
		/// [get_runs synth_1]
		/// set_property STEPS.SYNTH_DESIGN.ARGS.GATED_CLOCK_CONVERSION on \
		/// [get_runs synth_1]
		/// set_property STEPS.SYNTH_DESIGN.ARGS.FSM_EXTRACTION one_hot \
		/// [get_runs synth_1]
		/// launch_runs synth_1
		/// This example is the same as the prior example, except that it uses the -dict option to set all the
		/// properties on the synthesis run in a single set_property command:
		/// set_property -dict [ list flow {Vivado Synthesis 2016} \
		/// STEPS.SYNTH_DESIGN.ARGS.FANOUT_LIMIT 500 \
		/// STEPS.SYNTH_DESIGN.ARGS.GATED_CLOCK_CONVERSION on \
		/// STEPS.SYNTH_DESIGN.ARGS.FSM_EXTRACTION \
		/// one_hot ] [get_runs synth_1]
		/// launch_runs synth_1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1649
		/// </summary>
		/// <param name="name">(Required) Name of property to set. Not valid with -dict option</param>
		/// <param name="value">(Required) Value of property to set. Not valid with -dict option</param>
		/// <param name="objects">(Required) Objects to set properties on</param>
		/// <param name="dict">(Optional) list of name/value pairs of properties to set</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_property(string name, string value, string objects, string dict = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_property [-dict <args>] [-quiet] [-verbose] <name> <value> <objects>...
			_tcl.Entry(_builder.set_property(name, value, objects, dict, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Write a tcl script on disk that will recreate a given IP.
		///
		///
		/// TCL Syntax: write_ip_tcl [-force] [-no_ip_version] [-ip_name <arg>] [-show_defaults] [-multiple_files] [-quiet] [-verbose] [<objects>] [<tcl_filename>...]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1833
		/// </summary>
		/// <param name="force">(Optional) Flag to overwrite existing file.</param>
		/// <param name="no_ip_version">
		/// (Optional)
		/// Flag to not include the IP version in the IP VLNV in create_ip
		/// commands. NOTE - this may have implications if there are
		/// major IP version changes.
		/// </param>
		/// <param name="ip_name">
		/// (Optional)
		/// Set the name of the IP. This argument is not supported for
		/// multiple IP.
		/// </param>
		/// <param name="show_defaults">(Optional) Add a comment containing the default parameter values of the IP.</param>
		/// <param name="multiple_files">(Optional) Flag to create a .tcl file for each IP supplied as an argument</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">
		/// (Optional)
		/// IP(s) to be written to disk Values: IP instance(s) as returned
		/// by 'get_ips <instance name>'
		/// </param>
		/// <param name="tcl_filename">
		/// (Optional)
		/// File path to the exported tcl file. If the path is a directory and
		/// multiple IP are given as an argument, a file for each IP will
		/// be created. Default: ./
		/// </param>
		/// <returns>IP TCL file</returns>
		public TTCL write_ip_tcl(bool? force = null, bool? no_ip_version = null, string ip_name = null, bool? show_defaults = null, bool? multiple_files = null, bool? quiet = null, bool? verbose = null, string objects = null, string tcl_filename = null)
		{
			// TCL Syntax: write_ip_tcl [-force] [-no_ip_version] [-ip_name <arg>] [-show_defaults] [-multiple_files] [-quiet] [-verbose] [<objects>] [<tcl_filename>...]
			_tcl.Entry(_builder.write_ip_tcl(force, no_ip_version, ip_name, show_defaults, multiple_files, quiet, verbose, objects, tcl_filename));
			return _tcl;
		}
		/// <summary>
		/// Write out one or more DRC/METHODOLOGY/CDC message waivers in command form
		///
		///
		/// TCL Syntax: write_waivers [-type <arg>] [-objects <args>] [-return_string] [-force] [-quiet] [-verbose] [<file>]
		///
		/// To save waivers from one design session to the next, you must use write_waivers to create
		/// an XDC file of the waiver commands, and read_xdc to read those waivers back into the design
		/// when it is reopened.
		///
		/// This example writes all waivers in the current design:
		/// write_waivers C:/Data/design_waivers.xdc
		/// The following example writes only DRC type waivers:
		/// write_waivers -type DRC C:/Data/drc_waivers.xdc
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1860
		/// </summary>
		/// <param name="file">(Required) Name of file to write waivers</param>
		/// <param name="type">(Optional) Type of waiver(s) - ALL, DRC, METHODOLOGY, CDC to write</param>
		/// <param name="objects">(Optional) List of DRC/METHODOLOGY/CDC waiver objects to be written</param>
		/// <param name="return_string">(Optional) Return report results as a string object</param>
		/// <param name="force">(Optional) Overwrite existing file.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_waivers(string file, string type = null, string objects = null, bool? return_string = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_waivers [-type <arg>] [-objects <args>] [-return_string] [-force] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.write_waivers(file, type, objects, return_string, force, quiet, verbose));
			return _tcl;
		}
	}
}
