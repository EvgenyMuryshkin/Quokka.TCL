#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
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
		public TTCL add_drc_checks(String ruledeck, TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: add_drc_checks [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] -ruledeck <arg> [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.add_drc_checks(ruledeck, of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Applies board connections to given designs<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: apply_board_connection [-board_interface &lt;arg&gt;] -ip_intf &lt;arg&gt; -diagram &lt;arg&gt; [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Connects the interface pin of an IP core in the specified block design to the interface of the<br/>
		/// current board part in the current project or design.<br/>
		/// The board part provides a representation of the Xilinx device in the context of the board-level<br/>
		/// system, and can help define key aspects of the design, such as clock constraints, I/O port<br/>
		/// assignments, and supported interfaces. The board part file stores information regarding board<br/>
		/// attributes. The file, called board_part.xml, is located in the data/boards/board_parts<br/>
		/// folder of the Vivado Design Suite installation area.<br/>
		/// The command lets you quickly connect compatible interface pins of an IP integrator block design<br/>
		/// to the appropriate interface definition on the current board part. To make the connection<br/>
		/// between the IP core to the board part, the IP integrator of the Vivado Design Suite adds an<br/>
		/// external interface port and interface connection to the block design. The added external<br/>
		/// interface port is named for the specified board part interface.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The apply_board_connection commands uses the available interfaces of the current board<br/>
		/// part defined in the project. An error is returned if the project uses a target part rather than a<br/>
		/// target board. You can use the current_board_part command to identify the target board<br/>
		/// used by the project, or get_board_parts to list the boards available for use by the project.<br/>
		/// Use the get_board_part_interfaces command to determine the list of available interfaces<br/>
		/// on the current board.<br/>
		/// To remove an existing IP interface connection, specify the -ip_intf option, but do not specify<br/>
		/// the -board_interface. If no board part interface is specified, the IP interface pin is<br/>
		/// disconnected.<br/>
		/// This command returns a transcript of it actions, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 103<br/>
		/// </para>
		/// </summary>
		/// <param name="ip_intf">
		/// <para>
		/// (Required)<br/>
		/// Full path of IP interface name to which board automation<br/>
		/// need to be applied.<br/>
		/// </para>
		/// </param>
		/// <param name="diagram">(Required) The IP Integrator design name.</param>
		/// <param name="board_interface">(Optional) Board interface name to which connection need to be applied.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>sucess/failure status of applied action.</returns>
		public TTCL apply_board_connection(String ip_intf, String diagram, String board_interface = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: apply_board_connection [-board_interface <arg>] -ip_intf <arg> -diagram <arg> [-quiet] [-verbose]
			_tcl.Entry(_builder.apply_board_connection(ip_intf, diagram, board_interface, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Check if a module can be referenced<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: can_resolve_reference [-quiet] [-verbose] &lt;module&gt;...
		/// <br/>
		/// <para>
		/// This command is used to validate reference to modules prior to trying to import them into the<br/>
		/// design. Its primary use is in scripts like the script produced by the write_bd_tcl command,<br/>
		/// though you can use it in your own scripts as well.<br/>
		/// This command returns 0 if the reference cannot be resolved, or returns 1 if it can be resolved.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example determines if the reference to the specified module can be resolved:<br/>
		/// can_resolve_reference clk_div<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 124<br/>
		/// </para>
		/// </summary>
		/// <param name="module">(Required) module name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL can_resolve_reference(TCLParameterList module, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: can_resolve_reference [-quiet] [-verbose] <module>...
			_tcl.Entry(_builder.can_resolve_reference(module, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Manage the IP instance Synthesis cache. Lists out the IP Cache entries if no options are specified.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: config_ip_cache [-use_cache_location &lt;arg&gt;] [-use_project_cache] [-disable_cache] [-clear_output_repo] [-clear_local_cache] [-cache_has_match] [-cache_was_used] [-get_id] [-get_entry_location &lt;arg&gt;] [-remove] [-vlnv &lt;arg&gt;] [-old_swvers] [-unused] [-swver &lt;arg&gt;] [-num_days_old &lt;arg&gt;] [-num_days_unused &lt;arg&gt;] [-obs_synth_crc] [-disk_usage_output_repo] [-report] [-rptfile &lt;arg&gt;] [-csvfile &lt;arg&gt;] [-zip_cache &lt;arg&gt;] [-import_from_project] [-filter &lt;arg&gt;] [-regexp] [-nocase] [-purge] [-quiet] [-verbose] [&lt;ip&gt;]
		/// <br/>
		/// <para>
		/// This command lets you manage the Vivado Design Suite out-of-context (OOC) IP cache. The<br/>
		/// Vivado Design Suite caches the synthesis results for customized OOC IP in an IP repository, so<br/>
		/// multiple IP that use the same customization profile can share OOC synthesis results to decrease<br/>
		/// run time. The cached synthesis results can be reused in a single project from the project cache, or<br/>
		/// across multiple projects using a remote cache location.<br/>
		/// When generating the synthesis output products for an OOC IP, if a matching IP customization is<br/>
		/// found in the IP repository, the cached synthesis results will be used. If no suitable match is found<br/>
		/// in the IP repository, the synthesis output products will be generated as usual and the results,<br/>
		/// including the design checkpoint (DCP), will be copied into the IP synthesis cache for future use.<br/>
		/// TIP: When cached results are used, an information message is displayed in the Tcl console indicating the IP<br/>
		/// cache location used.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// You can specify a repository of cached IP synthesis results either within the current project, or at<br/>
		/// an external location. The location of the IP cache is defined by the IP_OUTPUT_REPO property<br/>
		/// on a project, with the value of a string defining a valid file system directory. You can set this<br/>
		/// property using the check_ip_cache command with either the -use_cache_location or<br/>
		/// the -use_project_cache options. The default IP synthesis cache location is in the current<br/>
		/// project folders.<br/>
		/// The use of the IP synthesis cache is controlled by the IP_CACHE_PERMISSIONS property that<br/>
		/// can be set with the set_property command. The current values are:<br/>
		/// • disabled - Do not use the IP synthesis cache. This is the default setting.<br/>
		/// • read - Use the IP synthesis cache to read OOC synthesis results from and apply as appropriate<br/>
		/// in the current project.<br/>
		/// • write - Use the IP synthesis cache to write OOC synthesis results into, but do not use them to<br/>
		/// read IP into the current project.<br/>
		/// • read write - Use the IP synthesis cache for both writing results to, and using those results in<br/>
		/// the current project.<br/>
		/// The config_ip_cache command should be followed by the update_ip_catalog command<br/>
		/// to read the specified IP cache repository into the Vivado tool.<br/>
		/// TIP: The IP synthesis cache can be enabled, and the cache repository specified, in the Vivado Design Suite<br/>
		/// IDE using the Settings dialog box. Refer to the Vivado Design Suite User Guide: Designing with IP (UG896)<br/>
		/// for more information on using the cache.<br/>
		/// By default, without any of the arguments specified below, the config_ip_cache command<br/>
		/// returns a list of entries in the IP synthesis cache, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 179<br/>
		/// </para>
		/// </summary>
		/// <param name="use_cache_location">(Optional) Set current project properties to use the specified cache location</param>
		/// <param name="use_project_cache">
		/// <para>
		/// (Optional)<br/>
		/// Set current project properties to use the default project IP<br/>
		/// cache location<br/>
		/// </para>
		/// </param>
		/// <param name="disable_cache">(Optional) Disable cache use.</param>
		/// <param name="clear_output_repo">
		/// <para>
		/// (Optional)<br/>
		/// Delete from disk and in memory all cache entries that exist<br/>
		/// in the current project's designated cache (local or remote).<br/>
		/// </para>
		/// </param>
		/// <param name="clear_local_cache">
		/// <para>
		/// (Optional)<br/>
		/// Delete from disk and in memory all local cache entries for<br/>
		/// this project.<br/>
		/// </para>
		/// </param>
		/// <param name="cache_has_match">
		/// <para>
		/// (Optional)<br/>
		/// Returns the cache-ID of the cache entry that would work for<br/>
		/// this IP instance; else ''.<br/>
		/// </para>
		/// </param>
		/// <param name="cache_was_used">
		/// <para>
		/// (Optional)<br/>
		/// Returns '1' if the cache was used to obtain the IP's current<br/>
		/// synthesis results; else '0'.<br/>
		/// </para>
		/// </param>
		/// <param name="get_id">(Optional) Calculate and return IP cache ID string for specified &lt;ip&gt;</param>
		/// <param name="get_entry_location">(Optional) Return directory where this cache-ID entry is located.</param>
		/// <param name="remove">
		/// <para>
		/// (Optional)<br/>
		/// Remove the corresponding cache entry for the specified IP<br/>
		/// instance or specified cachedInst; return cache ID string if<br/>
		/// successful, otherwise blank.<br/>
		/// </para>
		/// </param>
		/// <param name="vlnv">
		/// <para>
		/// (Optional)<br/>
		/// Used with -purge or -get_resource_data, specifies the VLNV<br/>
		/// of the cache entries to delete or find. May use a wildcard<br/>
		/// ('*') in one or more fields in the VLNV.<br/>
		/// </para>
		/// </param>
		/// <param name="old_swvers">
		/// <para>
		/// (Optional)<br/>
		/// Used with -purge to delete cache entries created with old<br/>
		/// Vivado SW Versions.<br/>
		/// </para>
		/// </param>
		/// <param name="unused">(Optional) Used with -purge to delete cache entries that have never been used.</param>
		/// <param name="swver">
		/// <para>
		/// (Optional)<br/>
		/// Used with -purge to delete any cache entries created from<br/>
		/// this specific Vivado SW Version (i.e., '2017.1').<br/>
		/// </para>
		/// </param>
		/// <param name="num_days_old">
		/// <para>
		/// (Optional)<br/>
		/// Used with -purge to delete any cache entries that are this<br/>
		/// number of days old or older.<br/>
		/// </para>
		/// </param>
		/// <param name="num_days_unused">
		/// <para>
		/// (Optional)<br/>
		/// Used with -purge to delete any cache entries that have not<br/>
		/// been used for this number of days or longer.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Name Description<br/>
		/// </para>
		/// </param>
		/// <param name="obs_synth_crc">
		/// <para>
		/// (Optional)<br/>
		/// Used with -purge to delete cache entries whose component<br/>
		/// synth checksum is not the same as the IP Catalog's current<br/>
		/// component synthesis checksum.<br/>
		/// </para>
		/// </param>
		/// <param name="disk_usage_output_repo">
		/// <para>
		/// (Optional)<br/>
		/// Return total disk usage in MB for all cache entries in the<br/>
		/// current project's ip_output_repo.<br/>
		/// </para>
		/// </param>
		/// <param name="report">
		/// <para>
		/// (Optional)<br/>
		/// Report cache statistics for the specified IP or cache object,<br/>
		/// or for the current cache location if none specified. If -rptfile<br/>
		/// is specified, write statistics to that file. If -dir is specified,<br/>
		/// write statistics for cache entries found under that directory.<br/>
		/// </para>
		/// </param>
		/// <param name="rptfile">
		/// <para>
		/// (Optional)<br/>
		/// Used with -report, specifies the text file to write the cache<br/>
		/// statistics to.<br/>
		/// </para>
		/// </param>
		/// <param name="csvfile">
		/// <para>
		/// (Optional)<br/>
		/// Used with -report, specifies the csv file to write the cache<br/>
		/// statistics to, in csv format.<br/>
		/// </para>
		/// </param>
		/// <param name="zip_cache">
		/// <para>
		/// (Optional)<br/>
		/// Zip up all cache entries used by the current project and<br/>
		/// write to the given filename.<br/>
		/// </para>
		/// </param>
		/// <param name="import_from_project">(Optional) Import existing synthesized IP from the project into the cache.</param>
		/// <param name="filter">(Optional) Filter result of '-list'</param>
		/// <param name="regexp">(Optional) Use regular expressions instead of globs in '-filter' argument(s)</param>
		/// <param name="nocase">(Optional) Use case insensitive matching in '-filter' argument(s)</param>
		/// <param name="purge">
		/// <para>
		/// (Optional)<br/>
		/// Delete all cache entries that match the specified type(s): -<br/>
		/// vlnv, -obs_swvers, -obs_synth_crc, and/or -swver. Returns<br/>
		/// the number of entries deleted.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="ip">(Optional) IP instance object, IP file, or IP name pattern</param>
		public TTCL config_ip_cache(String use_cache_location = null, bool? use_project_cache = null, bool? disable_cache = null, bool? clear_output_repo = null, bool? clear_local_cache = null, bool? cache_has_match = null, bool? cache_was_used = null, bool? get_id = null, String get_entry_location = null, bool? remove = null, String vlnv = null, bool? old_swvers = null, bool? unused = null, String swver = null, Int32? num_days_old = null, Int32? num_days_unused = null, bool? obs_synth_crc = null, bool? disk_usage_output_repo = null, bool? report = null, String rptfile = null, String csvfile = null, String zip_cache = null, bool? import_from_project = null, String filter = null, bool? regexp = null, bool? nocase = null, bool? purge = null, bool? quiet = null, bool? verbose = null, String ip = null)
		{
			// TCL Syntax: config_ip_cache [-use_cache_location <arg>] [-use_project_cache] [-disable_cache] [-clear_output_repo] [-clear_local_cache] [-cache_has_match] [-cache_was_used] [-get_id] [-get_entry_location <arg>] [-remove] [-vlnv <arg>] [-old_swvers] [-unused] [-swver <arg>] [-num_days_old <arg>] [-num_days_unused <arg>] [-obs_synth_crc] [-disk_usage_output_repo] [-report] [-rptfile <arg>] [-csvfile <arg>] [-zip_cache <arg>] [-import_from_project] [-filter <arg>] [-regexp] [-nocase] [-purge] [-quiet] [-verbose] [<ip>]
			_tcl.Entry(_builder.config_ip_cache(use_cache_location, use_project_cache, disable_cache, clear_output_repo, clear_local_cache, cache_has_match, cache_was_used, get_id, get_entry_location, remove, vlnv, old_swvers, unused, swver, num_days_old, num_days_unused, obs_synth_crc, disk_usage_output_repo, report, rptfile, csvfile, zip_cache, import_from_project, filter, regexp, nocase, purge, quiet, verbose, ip));
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
		public TTCL create_drc_ruledeck(TCLParameterList ruledecks, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_drc_ruledeck [-quiet] [-verbose] <ruledecks>...
			_tcl.Entry(_builder.create_drc_ruledeck(ruledecks, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create new PartitionDef<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_partition_def -name &lt;arg&gt; -module &lt;arg&gt; [-library &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// IMPORTANT! You must first define the project as a Partial Reconfiguration (PR) project by setting the<br/>
		/// PR_FLOW property on the project to TRUE, or by using the Tools → Enable Partial Reconfiguration<br/>
		/// command.<br/>
		/// The Partial Reconfiguration flow lets you create Partition Definitions (partitionDefs) from<br/>
		/// hierarchical cells in a design, and to specify reconfigurable modules (RMs) to be assigned to these<br/>
		/// partitionDefs to create a unique configurations of the design based on the combination of the<br/>
		/// core design and one or more RMs. The PR design flow requires the implementation of each PR<br/>
		/// configuration, resulting in partial bitstreams for the RMs, but complete bitstreams for each<br/>
		/// integrated configuration. Refer to the Vivado Design Suite User Guide: Dynamic Function eXchange<br/>
		/// (UG909) for more information.<br/>
		/// The create_partition_def command defines a partitionDef object in a PR project from a<br/>
		/// specified hierarchical cell. The partitionDef defines a partition hierarchy that RMs can be<br/>
		/// assigned to for a specific PR configuration.<br/>
		/// This command returns the name of the newly created partitionDef, or returns an error if the<br/>
		/// command fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 325<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of the PartitionDef</param>
		/// <param name="module">(Required) Module name of the PartitionDef</param>
		/// <param name="library">(Optional) Library name of the module of PartitionDef</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_partition_def(String name, String module, String library = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_partition_def -name <arg> -module <arg> [-library <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_partition_def(name, module, library, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create new Configuration<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_pr_configuration -name &lt;arg&gt; [-partitions &lt;args&gt;] [-greyboxes &lt;args&gt;] [-use_netlist] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// IMPORTANT! You must first define the project as a Partial Reconfiguration (PR) project by setting the<br/>
		/// PR_FLOW property on the project to TRUE, or by using the Tools → Enable Partial Reconfiguration<br/>
		/// command.<br/>
		/// The Partial Reconfiguration flow lets you create Partition Definitions (partitionDefs) from<br/>
		/// hierarchical cells in a design, and to specify reconfigurable modules (RMs) to be assigned to these<br/>
		/// partitionDefs to create unique configurations of the design based on the combination of the core<br/>
		/// design and one or more RMs. The PR design flow requires the implementation of each PR<br/>
		/// configuration, resulting in partial bitstreams for the RMs, but complete bitstreams for each<br/>
		/// integrated configuration. Refer to the Vivado Design Suite User Guide: Dynamic Function eXchange<br/>
		/// (UG909) for more information.<br/>
		/// The create_pr_configuration command defines the combination of the static logic and<br/>
		/// the RM to create a unique configuration of the design. The PR configuration is the design that is<br/>
		/// implemented and the bitstream is generated for.<br/>
		/// You will also need to create implementation runs for the PR configuration using the<br/>
		/// create_run -pr_config command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns the name of the newly created PR configuration, or returns an error if the<br/>
		/// command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 340<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of the Configuration</param>
		/// <param name="partitions">(Optional) List of partition instances and reconfig modules pairs</param>
		/// <param name="greyboxes">(Optional) List of instances to which buffers need to be inserted for all ports</param>
		/// <param name="use_netlist">
		/// <para>
		/// (Optional)<br/>
		/// Use netlist for getting instances of partition_defs to creating<br/>
		/// configurations<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_pr_configuration(String name, TCLParameterList partitions = null, TCLParameterList greyboxes = null, bool? use_netlist = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_pr_configuration -name <arg> [-partitions <args>] [-greyboxes <args>] [-use_netlist] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_pr_configuration(name, partitions, greyboxes, use_netlist, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create new reconfig Module<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_reconfig_module -name &lt;arg&gt; [-top &lt;arg&gt;] [-gate_level] -partition_def &lt;arg&gt; [-define_from &lt;arg&gt;] [-define_from_file &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// IMPORTANT! You must first define the project as a Partial Reconfiguration (PR) project by setting the<br/>
		/// PR_FLOW property on the project to TRUE, or by using the Tools → Enable Partial Reconfiguration<br/>
		/// command.<br/>
		/// The create_reconfig_module command defines an reconfigurable module (RM) from a<br/>
		/// specified hierarchical cell, or design file, and assigns it to the specified Partition Definition<br/>
		/// (partitionDef) in the current project.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The Partial Reconfiguration flow allows RMs to be swapped into and out of a partitionDef to<br/>
		/// create a unique configuration of the design based on the combination of the core design and an<br/>
		/// RM. A single partitionDef can have multiple RMs to contain different netlists, constraints, or<br/>
		/// implementations. Each instance of the partitionDef in the design can be assigned a different RM<br/>
		/// to support many different configurations. The PR design flow requires the implementation of<br/>
		/// each PR configuration, resulting in partial bitstreams for the RMs, but complete bitstreams for<br/>
		/// each integrated configuration. Refer to the Vivado Design Suite User Guide: Dynamic Function<br/>
		/// eXchange (UG909) for more information.<br/>
		/// This command returns the hierarchical name of the newly created RM, or returns an error if the<br/>
		/// command failed.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The example below creates a reconfigurable module with the specified name:<br/>
		/// create_reconfig_module -name fftBottom -partition_def \<br/>
		/// [get_partition_defs partDef1 ] -top fftTop<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 350<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of the Reconfig Module</param>
		/// <param name="partition_def">(Required) PartitionDef in which reconfig module will be created</param>
		/// <param name="top">(Optional) module name of the top module</param>
		/// <param name="gate_level">(Optional) Create Reconfig Module whcih alllows adding DCP/EDIF files only</param>
		/// <param name="define_from">(Optional) Name of the module in the source fileset to be the top of the blockset</param>
		/// <param name="define_from_file">
		/// <para>
		/// (Optional)<br/>
		/// full path of the top source file in the source fileset for which<br/>
		/// reconfigurable module to be created.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_reconfig_module(String name, String partition_def, String top = null, bool? gate_level = null, String define_from = null, String define_from_file = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_reconfig_module -name <arg> [-top <arg>] [-gate_level] -partition_def <arg> [-define_from <arg>] [-define_from_file <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_reconfig_module(name, partition_def, top, gate_level, define_from, define_from_file, quiet, verbose));
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
		/// Get the current board object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_board [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Returns the board in use in the current project.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// The board can be specified:<br/>
		/// • When the project is created by selecting Boards from the Default Part dialog box.<br/>
		/// • By setting the BOARD_PART property on the current project as shown in the example.<br/>
		/// • By selecting the Project Device in the Settings dialog box in an open project in the Vivado IDE.<br/>
		/// Refer to the Vivado Design Suite User Guide: System-Level Design Entry (UG895) for information on<br/>
		/// creating projects, and on configuring project settings.<br/>
		/// IMPORTANT! When you specify the board with the set_property command, the target part is also<br/>
		/// changed to match the part required by the specified BOARD property.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The current_board command returns the Vendor:Board_Name:File_Version attributes<br/>
		/// of the current board, as defined in the BOARD_PART property. The command returns nothing<br/>
		/// when the project targets a Xilinx FPGA instead of a TRD and board, or when the BOARD_PART<br/>
		/// property has not been defined. The command returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 379<br/>
		/// </para>
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
		/// <para>
		/// Get the current board_part object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_board_part [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Return the Xilinx device used in the current project or design.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// The board part provides a representation of the Xilinx device in the context of the board-level<br/>
		/// system, and is represented by the part0 component in the Board Interface file.<br/>
		/// The board can be specified:<br/>
		/// • When the project is created by selecting Boards from the Default Part dialog box.<br/>
		/// • By setting the BOARD_PART property on the current project as shown in the example.<br/>
		/// • By selecting the Project Device in the Settings dialog box in an open project in the Vivado IDE.<br/>
		/// Refer to the Vivado Design Suite User Guide: System-Level Design Entry (UG895) for information on<br/>
		/// creating projects, and on configuring project settings.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// IMPORTANT! When you specify the board with the set_property command, the target part is also<br/>
		/// changed to match the part required by the specified BOARD_PART property.<br/>
		/// The current_board_part command returns the NAME property of the current board part.<br/>
		/// The command returns a warning when the project targets a Xilinx FPGA instead of a board, or<br/>
		/// when the BOARD_PART property has not been defined. The command returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 382<br/>
		/// </para>
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
		/// <para>
		/// Get a list of PartitionDefs<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_pr_configuration [-quiet] [-verbose] [&lt;config&gt;...]
		/// <br/>
		/// <para>
		/// Get or set the current PR configuration.<br/>
		/// In the Partial Reconfiguration (PR) design flow, the PR configuration lets you specify a<br/>
		/// reconfigurable module (RM) to assign to a specific instance of a Partition Definition<br/>
		/// (partitionDef). This flow lets you create unique configurations of the design based on the<br/>
		/// combination of the core design and one or more RMs. The PR design flow requires the<br/>
		/// implementation of each PR configuration, resulting in partial bitstreams for the RMs, but<br/>
		/// complete bitstreams for each integrated configuration. Refer to the Vivado Design Suite User<br/>
		/// Guide: Dynamic Function eXchange (UG909) for more information.<br/>
		/// The current_pr_configuration either returns the PR configuration that is the current or active<br/>
		/// configfuration in the design, or lets you specify a PR configuration to make active.<br/>
		/// This command returns the name of the current PR configuration, or returns an error if the<br/>
		/// command fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 409<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="config">(Optional) Specify the PR configuration to be set as current (active); optional</param>
		/// <returns>list of PartitionDef objects</returns>
		public TTCL current_pr_configuration(bool? quiet = null, bool? verbose = null, TCLParameterList config = null)
		{
			// TCL Syntax: current_pr_configuration [-quiet] [-verbose] [<config>...]
			_tcl.Entry(_builder.current_pr_configuration(quiet, verbose, config));
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
		public TTCL delete_drc_check(TCLParameterList name, bool? quiet = null, bool? verbose = null)
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
		public TTCL delete_drc_ruledeck(bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: delete_drc_ruledeck [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.delete_drc_ruledeck(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Removes the HW Bitstream object from a list of hardware devices.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_hw_bitstream [-of_objects &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This command deletes the hw_bitstream object from the specified hw_device objects.<br/>
		/// This clears the PROGRAM.HW_BITSTREAM and PROGRAM.FILE properties on the hw_device<br/>
		/// objects, and deletes the hw_bitstream object.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 447<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_bitstream' objects of these types: 'hw_device'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>hardware devices</returns>
		public TTCL delete_hw_bitstream(TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_hw_bitstream [-of_objects <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.delete_hw_bitstream(of_objects, quiet, verbose));
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
		/// Delete one or more DRC/METHODOLOGY/CDC message waivers<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_waivers [-scoped] [-quiet] [-verbose] [&lt;objects&gt;...]
		/// <br/>
		/// <para>
		/// After report_drc, report_methodology, or report_cdc commands are run, they return<br/>
		/// messages of specific violations or conditions found in the design. These violations can prevent<br/>
		/// the design from progressing until they have been resolved or addressed in some way. The<br/>
		/// create_waiver command lets you select individual violations or specific checks that can be<br/>
		/// waived for a design, letting you move forward in the design flow.<br/>
		/// Use the delete_waivers command to remove waivers from the design.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example deletes all the DRC waivers in the design:<br/>
		/// delete_waivers [get_waivers -type DRC]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 484<br/>
		/// </para>
		/// </summary>
		/// <param name="scoped">
		/// <para>
		/// (Optional)<br/>
		/// flag waiver to interpret object wildcards as scoped to the<br/>
		/// current_instance that is set<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">
		/// <para>
		/// (Optional)<br/>
		/// List of waiver objects, or a list of message objects (cells,<br/>
		/// nets, sites, etc.) for which DRC/METHODOLOGY waiver(s)<br/>
		/// were set<br/>
		/// </para>
		/// </param>
		public TTCL delete_waivers(bool? scoped = null, bool? quiet = null, bool? verbose = null, TCLParameterList objects = null)
		{
			// TCL Syntax: delete_waivers [-scoped] [-quiet] [-verbose] [<objects>...]
			_tcl.Entry(_builder.delete_waivers(scoped, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Filter a list, resulting in new list<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: filter [-regexp] [-nocase] [-quiet] [-verbose] [&lt;objects&gt;] [&lt;filter&gt;]
		/// <br/>
		/// <para>
		/// Takes a list of objects, and returns a reduced list of objects that match the specified filter search<br/>
		/// pattern.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns a list of parts filtered for the specified speed grade:<br/>
		/// filter [get_parts] {speed == -3}<br/>
		/// The following example filters parts based according to speed grade -3 OR speed grade -2. All<br/>
		/// parts matching either speed grade will be returned.<br/>
		/// filter [get_parts] {speed == -3 || speed == -2}<br/>
		/// The following example uses regular expression and returns a list of VStatus ports in the design,<br/>
		/// with zero or more wildcards, and the numbers 0 to 9 appearing one or more times within square<br/>
		/// brackets:<br/>
		/// filter -regexp [get_ports] {NAME =~ VStatus.*\[[0-9]+\]}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 526<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Operators =~ and !~ use regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">(Optional) List of objects to filter</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <returns>new list</returns>
		public TTCL filter(bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, String objects = null, String filter = null)
		{
			// TCL Syntax: filter [-regexp] [-nocase] [-quiet] [-verbose] [<objects>] [<filter>]
			_tcl.Entry(_builder.filter(regexp, nocase, quiet, verbose, objects, filter));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Find a routing path between two nodes.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: find_routing_path [-allow_overlap] [-max_nodes &lt;arg&gt;] [-min_nodes &lt;arg&gt;] [-from &lt;args&gt;] [-to &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Finds a routing solution between two nodes on an unrouted, or partially routed net, in an<br/>
		/// implemented design.<br/>
		/// This command can be used to define a routing path to assign to the FIXED_ROUTE property of a<br/>
		/// net, which can be saved to the XDC file for later reuse. Refer to Vivado Design Suite Tutorial:<br/>
		/// Implementation (UG986) for an example of manual routing and the use of the FIXED_ROUTE<br/>
		/// property.<br/>
		/// You must define nodes for the start and end points of the routing path, and can specify the<br/>
		/// maximum and minimum number of nodes to use for the route path, including the start and end<br/>
		/// points. The nodes must be specified as objects returned by the get_nodes command. For<br/>
		/// unrouted net objects, since nodes have not been assigned to the net, the nodes can be found by<br/>
		/// association of the net to the bel_pin or site_pin:<br/>
		/// • Net &gt; Bel_Pin &gt; Bel &gt; Tile &gt; Node<br/>
		/// • Net &gt; Site_Pin &gt; Tile &gt; Node<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// For partially routed nets, the nodes can be found associated directly to the net. Refer to the<br/>
		/// Vivado Design Suite Properties Reference Guide (UG912) for more information on the relationship<br/>
		/// between these objects.<br/>
		/// The find_routing_path command returns a list of nodes representing the route path found<br/>
		/// from the start point to the end point, or returns "no path found" if the command runs but has no<br/>
		/// result, or returns an error if the command fails to run.<br/>
		/// The returned list of nodes can be assigned to the FIXED_ROUTE property using the<br/>
		/// set_property command as shown in the example.<br/>
		/// TIP: The report_property command does not return the string of the FIXED_ROUTE property. Use<br/>
		/// the get_property command instead.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example finds a routing path for the specified net, using one end as the -from<br/>
		/// point and the other end as the -to point, and assigns that path to the specified Tcl variable. Then<br/>
		/// it uses that Tcl variable to assign the path to the FIXED_ROUTE property of the net:<br/>
		/// set fndPath [find_routing_path -from [lindex [get_nodes -of \<br/>
		/// [get_site_pins -of [get_nets wbOutputData_OBUF[14]]]] 0] -to \<br/>
		/// [lindex [get_nodes -of [get_site_pins -of \<br/>
		/// [get_nets wbOutputData_OBUF[14]]]] 1]]<br/>
		/// set_property FIXED_ROUTE $fndPath [get_nets wbOutputData_OBUF[14]]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 532<br/>
		/// </para>
		/// </summary>
		/// <param name="allow_overlap">(Optional) Solution may include nodes used in existing routes.</param>
		/// <param name="max_nodes">
		/// <para>
		/// (Optional)<br/>
		/// Specifies the maximum number of nodes (including from<br/>
		/// and to nodes) allowed in solution. Default: 100<br/>
		/// </para>
		/// </param>
		/// <param name="min_nodes">
		/// <para>
		/// (Optional)<br/>
		/// Specifies the minimum number of nodes (including from<br/>
		/// and to nodes) allowed in solution. Default: 2<br/>
		/// </para>
		/// </param>
		/// <param name="from">(Optional) -from &lt;start node&gt; Start of routing path.</param>
		/// <param name="to">(Optional) -to &lt;end node&gt; End of routing path.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL find_routing_path(bool? allow_overlap = null, Int32? max_nodes = null, Int32? min_nodes = null, TCLParameterList from = null, TCLParameterList to = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: find_routing_path [-allow_overlap] [-max_nodes <arg>] [-min_nodes <arg>] [-from <args>] [-to <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.find_routing_path(allow_overlap, max_nodes, min_nodes, from, to, quiet, verbose));
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
		/// Get a list of bel_pins. If a design is loaded, gets the constructed site type bels.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_bel_pins [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns a list of pins on the specified BELs, or matching a specified search pattern.<br/>
		/// The default command gets a list of all pins on all BELs on the device.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the pins of the specified BELs associated with the specified range<br/>
		/// of sites on the device:<br/>
		/// get_bel_pins -of_objects [get_bels -of_objects [get_sites \<br/>
		/// -range {SLICE_X0Y0 SLICE_X1Y1}] ]<br/>
		/// The following example returns the clock enable (CE) pins of all BELs on the device:<br/>
		/// get_bel_pins *CE<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 594<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the bel_pin of these bels, sites, pins, or nets.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match bel_pin against patterns Default: *</param>
		/// <returns>bel_pin</returns>
		public TTCL get_bel_pins(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_bel_pins [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_bel_pins(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of bels. If a design is loaded, gets the constructed site type bels.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_bels [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-include_routing_bels] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Basic Elements, or BELs, are building blocks of logic, such as flip-flops, LUTs, and carry logic, that<br/>
		/// make up a SLICE. This command returns a list of BELs on the target part that match a specified<br/>
		/// search pattern in an open design.<br/>
		/// The default command gets a list of all BELs on the device.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the total number of BELs on the target part:<br/>
		/// llength [get_bels]<br/>
		/// The following example returns the BELs associated with the specified site:<br/>
		/// get_bels -of_objects [get_sites PHASER_IN_PHY_X0Y5]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 597<br/>
		/// </para>
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
		public TTCL get_bels(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? include_routing_bels = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_bels [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-include_routing_bels] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_bels(regexp, nocase, filter, of_objects, include_routing_bels, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of board bus net objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_bus_nets [-regexp] [-nocase] [-all] [-filter &lt;arg&gt;] -of_objects &lt;args&gt; [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of individual connection bus nets of the specified connection bus object, or the board<br/>
		/// component or board component pin objects.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Connection buses define the connections between the Xilinx device (part0) and other<br/>
		/// components on the board. Bus nets define individual connections of the connection bus.<br/>
		/// This command returns a list of connection bus nets, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the connection bus nets associated with the specified component of<br/>
		/// the current board:<br/>
		/// get_board_bus_nets -of_objects [get_board_components {*iic_main*}]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 600<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Required)<br/>
		/// Get 'board_bus_net' objects of these types: 'board_bus<br/>
		/// board_component board_component_pin'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="all">(Optional) Returns all enabled as well as disabled buses</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// match board net names against patterns Default: * Values:<br/>
		/// The default search pattern is the wildcard *, or .* when -<br/>
		/// regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of bus nets in the board</returns>
		public TTCL get_board_bus_nets(TCLParameterList of_objects, bool? regexp = null, bool? nocase = null, bool? all = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_board_bus_nets [-regexp] [-nocase] [-all] [-filter <arg>] -of_objects <args> [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_bus_nets(of_objects, regexp, nocase, all, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of board bus objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_buses [-regexp] [-nocase] [-all] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of connection buses defined on the current board, as defined in the Board Interface<br/>
		/// file.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Connection buses define the connections between the Xilinx device (part0) and other<br/>
		/// components on the board.<br/>
		/// This command returns a list of buses, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the connection buses associated with the specified component of<br/>
		/// the current board:<br/>
		/// get_board_buses -of_objects [get_board_components sgmii]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 603<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="all">(Optional) Returns all enabled as well as disabled buses</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'board_bus' objects of these types: 'board<br/>
		/// board_component board_bus_net'.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// match board bus names against patterns Default: * Values:<br/>
		/// The default search pattern is the wildcard *, or .* when -<br/>
		/// regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of buses in the board</returns>
		public TTCL get_board_buses(bool? regexp = null, bool? nocase = null, bool? all = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_board_buses [-regexp] [-nocase] [-all] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_buses(regexp, nocase, all, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of interfaces in the board components that implement busdef specified by VLNV<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_component_interfaces [-regexp] [-nocase] [-all] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of interfaces defined on the components found on the current board, as defined in the<br/>
		/// Board Interface file.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, defined components and<br/>
		/// supported interfaces. You can create custom boards by defining a custom Board Interface file, as<br/>
		/// described in the Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The component interface defines related groups of signals that are found on a component, or a<br/>
		/// component mode.<br/>
		/// This command returns a list of component interfaces, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the component interfaces defined in the Board Interface file for the<br/>
		/// specified board component:<br/>
		/// get_board_component_interfaces -of_objects [get_board_components *part0*]<br/>
		/// The following example gets the component interfaces defined in the Board Interface file, and<br/>
		/// then uses that information to create interfaces in the current project:<br/>
		/// #Get and Create Interfaces for I/O Ports<br/>
		/// foreach x [get_board_component_interfaces] {<br/>
		/// create_interface $x }<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 606<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="all">(Optional) Returns all enabled as well as disabled interfaces</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'board_component_interface' objects of these types:<br/>
		/// 'board board_component'.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Match Bus Interface names against patterns Default: *<br/>
		/// Values: The default search pattern is the wildcard *, or .*<br/>
		/// when -regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of bus interfaces</returns>
		public TTCL get_board_component_interfaces(bool? regexp = null, bool? nocase = null, bool? all = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_board_component_interfaces [-regexp] [-nocase] [-all] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_component_interfaces(regexp, nocase, all, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of component mode objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_component_modes [-regexp] [-nocase] [-all] [-filter &lt;arg&gt;] -of_objects &lt;args&gt; [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of various component modes defined on the current board, as defined in the Board<br/>
		/// Interface file.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The component mode defines various modes of operations that the components on a board may<br/>
		/// have, and the interfaces and preferred IP of those modes.<br/>
		/// This command returns a list of component modes, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the component modes defined in the Board Interface file of the<br/>
		/// specified board:<br/>
		/// get_board_component_modes -of_objects [get_board_components *part0*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 609<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Required) Get 'board_component_mode' objects of these types: 'board_component'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="all">(Optional) Returns all enabled as well as disabled interfaces</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// match board component modes against patterns Default: *<br/>
		/// Values: The default search pattern is the wildcard *, or .*<br/>
		/// when -regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of component modes in the board</returns>
		public TTCL get_board_component_modes(TCLParameterList of_objects, bool? regexp = null, bool? nocase = null, bool? all = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_board_component_modes [-regexp] [-nocase] [-all] [-filter <arg>] -of_objects <args> [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_component_modes(of_objects, regexp, nocase, all, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of board_part pins object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_component_pins [-regexp] [-nocase] [-filter &lt;arg&gt;] -of_objects &lt;args&gt; [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of individual board component pins of the specified board component object of the<br/>
		/// current_board.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// Board components define the list of components found on the board defined by the Board<br/>
		/// Interface file. Component pins enumerate the individual pins of the component.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns a list of component pin objects, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the component pins associated with the specified Xilinx device<br/>
		/// (part0) component object of the current board:<br/>
		/// get_board_component_pins -of_objects [get_board_components *part0*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 612<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Required)<br/>
		/// Get 'board_component_pin' objects of these types:<br/>
		/// 'board_component board_bus_net'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// match board component pin names against patterns<br/>
		/// Default: * Values: The default search pattern is the wildcard<br/>
		/// *, or .* when -regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of pins in the board_part</returns>
		public TTCL get_board_component_pins(TCLParameterList of_objects, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_board_component_pins [-regexp] [-nocase] [-filter <arg>] -of_objects <args> [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_component_pins(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get the list of components available in the board<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_components [-regexp] [-nocase] [-all] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of components defined on the current board, as defined in the Board Interface file.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// This command returns a list of components, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the components defined in the Board Interface file of the specified<br/>
		/// board:<br/>
		/// get_board_components -of_objects [get_boards zed]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 615<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="all">(Optional) Returns all enabled as well as disabled components</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'board_component' objects of these types: 'board<br/>
		/// board_bus board_component_pin'.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Match component names against patterns Default: *<br/>
		/// Values: The default search pattern is the wildcard *, or .*<br/>
		/// when -regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of component objects</returns>
		public TTCL get_board_components(bool? regexp = null, bool? nocase = null, bool? all = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_board_components [-regexp] [-nocase] [-all] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_components(regexp, nocase, all, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of interface ports object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_interface_ports [-regexp] [-nocase] [-filter &lt;arg&gt;] -of_objects &lt;args&gt; [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of various physical ports assigned to the component interfaces defined on the current<br/>
		/// board, as defined in the Board Interface file. The interface ports can be returned from component<br/>
		/// interfaces as specified by the get_board_component_interfaces command, or from the<br/>
		/// component pins returned by get_board_component_pins.<br/>
		/// The Board Interface file, board.xml located in the data/boards folder of the Vivado Design<br/>
		/// Suite installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// In the Board Interface file, a component interface includes a map of the logical ports, that are<br/>
		/// defined in the interface file, with a physical port that relates to the component pin or pins on the<br/>
		/// Xilinx device (part0).<br/>
		/// This command returns a list of the physical ports of the specified component interface, or returns<br/>
		/// an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the board interface ports defined in the Board Interface file for the<br/>
		/// specified board component:<br/>
		/// get_board_interface_ports -of_objects \<br/>
		/// [get_board_component_interfaces *gmii*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 618<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Required)<br/>
		/// Get 'board_component_pin' objects of these types:<br/>
		/// 'board_component_interface board_component_pin'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// match interface port names against patterns Default: *<br/>
		/// Values: The default search pattern is the wildcard *, or .*<br/>
		/// when -regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of ports in the given interface</returns>
		public TTCL get_board_interface_ports(TCLParameterList of_objects, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_board_interface_ports [-regexp] [-nocase] [-filter <arg>] -of_objects <args> [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_interface_ports(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of ip preference objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_ip_preferences [-regexp] [-nocase] [-filter &lt;arg&gt;] -of_objects &lt;args&gt; [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of IP preferences defined on the current board, as defined in the Board Interface file.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// IP preferences define the preferred IP to connect a component interface to in the Board Interface<br/>
		/// file.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns a list of preferred IP for specified component interfaces, or component<br/>
		/// modes, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the IP preferences of the specified component interfaces:<br/>
		/// get_board_ip_preferences -of_objects \<br/>
		/// [get_board_component_interfaces *clock*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 621<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Required)<br/>
		/// Get 'ip_preference' objects of these types:<br/>
		/// 'board_component_mode board_component_interface'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// match ip preferences against patterns Default: * Values: The<br/>
		/// default search pattern is the wildcard *, or .* when -regexp<br/>
		/// is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of ip preferences for the component</returns>
		public TTCL get_board_ip_preferences(TCLParameterList of_objects, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_board_ip_preferences [-regexp] [-nocase] [-filter <arg>] -of_objects <args> [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_ip_preferences(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of board jumper objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_jumpers [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of jumpers defined on the current board, as defined in the Board Interface file.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// The jumpers defined in the board file can be used to enable specific component modes and<br/>
		/// interfaces of the board.<br/>
		/// This command returns a list of jumpers, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the jumpers defined in the Board Interface file of the specified board:<br/>
		/// get_board_jumpers -of_objects [get_boards kc705]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 624<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'board_jumper' objects of these types: 'board'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// match jumper names against patterns Default: * Values:<br/>
		/// The default search pattern is the wildcard *, or .* when -<br/>
		/// regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of jumpers in the board</returns>
		public TTCL get_board_jumpers(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_board_jumpers [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_jumpers(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of board parameter objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_parameters [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of parameters defined on the current board, as defined in the Board Interface file.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// The parameters defined in the board file specify custom or user-defined characteristics of the<br/>
		/// board.<br/>
		/// This command returns a list of board parameters, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the parameters defined in the Board Interface file of the current<br/>
		/// board:<br/>
		/// get_board_parameters<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 627<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'board_parameter' objects of these types: 'board<br/>
		/// board_component board_component_interface'.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// match parameter names against patterns Default: * Values:<br/>
		/// The default search pattern is the wildcard *, or .* when -<br/>
		/// regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of parameters in the board</returns>
		public TTCL get_board_parameters(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_board_parameters [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_parameters(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of interfaces in the board_part that implement busdef specified by VLNV<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_part_interfaces [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of interfaces defined on the Xilinx device, or current board part as defined by the<br/>
		/// BOARD_PART property, on the board in use by the current project or open design.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The board part provides a representation of the Xilinx device in the context of the board-level<br/>
		/// system, and is represented by the part0 component in the Board Interface file. The<br/>
		/// current_board_part command returns the board part in use by the current project.<br/>
		/// The interfaces defined on the current board part define related groups of signals that can be used<br/>
		/// to quickly connect the elements of a block design in Vivado IP integrator, or configure IP from<br/>
		/// the Xilinx IP catalog. The interfaces available on the current_board_part can be used to<br/>
		/// define the interfaces required in an IP subsystem design, using create_bd_interface_port<br/>
		/// or create_bd_port. It can also be used to define the interfaces available in the overall FPGA<br/>
		/// design using create_interface and create_port.<br/>
		/// This command returns a list of available interfaces on the current board part, or returns an error<br/>
		/// if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of all interfaces defined on the current board part:<br/>
		/// join [get_board_part_interfaces] \n<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 630<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'board_component_interface' objects of these types:<br/>
		/// 'board board_component'.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Match Bus Interface names against patterns Default: *<br/>
		/// Values: The default search pattern is the wildcard *, or .*<br/>
		/// when -regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of bus interfaces</returns>
		public TTCL get_board_part_interfaces(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_board_part_interfaces [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_part_interfaces(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the list of board_part pins object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_part_pins [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of component pin objects on the current board part in use by the current project or<br/>
		/// design.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The board part provides a representation of the Xilinx device in the context of the board-level<br/>
		/// system, and is represented by the part0 component in the Board Interface file. The<br/>
		/// current_board_part command returns the board part in use by the current project.<br/>
		/// The board part pin represents the component pin of an implemented interface on the Xilinx<br/>
		/// device. The component pin includes properties like LOC, IOSTANDARD, and SLEW. Board part<br/>
		/// pins can be scalar or vector, so it is always represented as bitwise.<br/>
		/// The board part pins can be used to define and place PORTS in the top-level FPGA design, using<br/>
		/// the create_port and set_property PACKAGE_PIN commands.<br/>
		/// This command returns a list of component pins, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example returns the physical pins of the specified board part interface:<br/>
		/// get_board_part_pins -of [get_board_part_interfaces push_buttons_5bits]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example assigns the PACKAGE_PIN and IOSTANDARD properties on the specified<br/>
		/// port in the current design according to the properties on the leds_8bits pins in the current board:<br/>
		/// set_property PACKAGE_PIN [get_property LOC \<br/>
		/// [get_board_part_pins leds_8bits_TRI_O[1]]] [get_ports LEDS_n[1]]<br/>
		/// set_property IOSTANDARD [get_property IOSTANDARD \<br/>
		/// [get_board_part_pins leds_8bits_TRI_O[1]]] [get_ports LEDS_n[1]]<br/>
		/// The following example gets a list of board part pins assigned to the leds_8bits board part<br/>
		/// interface; stores those pins in a Tcl variable $boardPins, and then prints the LOC property for<br/>
		/// each of those pins:<br/>
		/// set boardPins [get_board_part_pins -of \<br/>
		/// [get_board_part_interfaces -filter {NAME == led_8bits}]]<br/>
		/// foreach pin $boardPins {puts "The location of $pin is: \<br/>
		/// [get_property LOC $pin]"}<br/>
		/// The location of leds_8bits_tri_o[0] is: AB8<br/>
		/// The location of leds_8bits_tri_o[1] is: AA8<br/>
		/// The location of leds_8bits_tri_o[2] is: AC9<br/>
		/// The location of leds_8bits_tri_o[3] is: AB9<br/>
		/// The location of leds_8bits_tri_o[4] is: AE26<br/>
		/// The location of leds_8bits_tri_o[5] is: G19<br/>
		/// The location of leds_8bits_tri_o[6] is: E18<br/>
		/// The location of leds_8bits_tri_o[7] is: F16<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 634<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'board_component_pin' objects of these types:<br/>
		/// 'board_component_interface board_interface_port'.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// match board_part pin names against patterns Default: *<br/>
		/// Values: The default search pattern is the wildcard *, or .*<br/>
		/// when -regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of pins in the board_part</returns>
		public TTCL get_board_part_pins(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_board_part_pins [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_part_pins(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get the list of board_part available in the project<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_board_parts [-regexp] [-nocase] [-latest_file_version] [-latest_hw_revision] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of available board parts in the board repository, as defined by the Board Interface files<br/>
		/// available for use by the current project or design.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The board part provides a representation of the Xilinx device in the context of the board-level<br/>
		/// system, and is represented by the part0 component in the Board Interface file. The<br/>
		/// current_board_part command returns the board part in use by the current project. Refer to<br/>
		/// the current_board_part command for the different methods of defining the board in use.<br/>
		/// This command returns the list of available Xilinx devices (part0) in the Board Interface files<br/>
		/// defined in the current board repository, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the board parts matching the specified filter search pattern:<br/>
		/// get_board_parts -filter {BOARD_NAME=~z*}<br/>
		/// The following example returns all board parts matching the specified search patterns:<br/>
		/// get_board_parts {*av* *kc*}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 638<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="latest_file_version">(Optional) Show only latest board parts by file version</param>
		/// <param name="latest_hw_revision">(Optional) Show only latest board parts by board revision</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Match Board Part names against patterns Default: * Values:<br/>
		/// The default search pattern is the wildcard *, or .* when -<br/>
		/// regexp is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of board_part objects</returns>
		public TTCL get_board_parts(bool? regexp = null, bool? nocase = null, bool? latest_file_version = null, bool? latest_hw_revision = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_board_parts [-regexp] [-nocase] [-latest_file_version] [-latest_hw_revision] [-filter <arg>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_board_parts(regexp, nocase, latest_file_version, latest_hw_revision, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get the list of boards available in the project<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_boards [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of evaluation boards available for use by the current project.<br/>
		/// The board file, board.xml located in the data/boards folder of the Vivado Design Suite<br/>
		/// installation area, stores information regarding board attributes. The board provides a<br/>
		/// representation of the overall system that the Xilinx device is a part of, and can help define key<br/>
		/// aspects of the design, such as clock constraints, I/O port assignments, and supported interfaces.<br/>
		/// You can create custom boards by defining a custom Board Interface file, as described in the<br/>
		/// Vivado Design Suite User Guide: System-Level Design Entry (UG895).<br/>
		/// The board in use by the project is returned by the current_board_part command.<br/>
		/// The board can be specified:<br/>
		/// • When the project is created by selecting Boards from the Default Part dialog box.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • By setting the BOARD property on the current project as shown in the example.<br/>
		/// • By selecting the Project Device in the Settings dialog box in an open project in the Vivado IDE.<br/>
		/// Refer to the Vivado Design Suite User Guide: System-Level Design Entry (UG895) for information on<br/>
		/// creating projects, and on configuring project settings.<br/>
		/// IMPORTANT! When you specify the board with the set_property command, the target part is also<br/>
		/// changed to match the part required by the specified BOARD property.<br/>
		/// This command returns a list of boards that are available for use by the current project, or returns<br/>
		/// an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the properties of the specified evaluation board:<br/>
		/// report_property [get_boards -filter {LIBRARY_NAME==artix7}]<br/>
		/// The following example returns all boards matching the specified search patterns:<br/>
		/// get_boards {*ar* *kc*}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 642<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'board' objects of these types: 'board_component'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Match Board names against patterns Default: * Values: The<br/>
		/// default search pattern is the wildcard *, or .* when -regexp<br/>
		/// is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of board objects</returns>
		public TTCL get_boards(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_boards [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_boards(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of CDC violations from a previous report_cdc run<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_cdc_violations [-name &lt;arg&gt;] [-regexp] [-filter &lt;arg&gt;] [-nocase] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of violation objects found in the design when the report_cdc command is run. The<br/>
		/// properties of individual violation objects can be queried using report_property or<br/>
		/// list_property commands for details of the violation.<br/>
		/// Violation objects are associated with the clock-domain crossing paths in the current design. The<br/>
		/// design objects associated with a methodology violation object can be obtained using the -<br/>
		/// of_objects option of the appropriate get_* command, such as get_cells, or get_nets<br/>
		/// for instance.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the CDC violations found in the current design, then returns a list<br/>
		/// of all those violations:<br/>
		/// report_cdc<br/>
		/// get_cdc_violations<br/>
		/// The following example generates list of violations in the named CDC report, and then gets the<br/>
		/// pins associated with any violations found:<br/>
		/// report_cdc -name cdc_1<br/>
		/// get_pins -of_objects [get_cdc_violations -name cdc_1]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 645<br/>
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
		/// Match CDC violations against patterns Default: * Values: The<br/>
		/// default search pattern is the wildcard *, or .* when -regexp<br/>
		/// is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of CDC violation objects</returns>
		public TTCL get_cdc_violations(String name = null, bool? regexp = null, String filter = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_cdc_violations [-name <arg>] [-regexp] [-filter <arg>] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_cdc_violations(name, regexp, filter, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of cells in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_cells [-hsc &lt;arg&gt;] [-hierarchical] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-match_style &lt;arg&gt;] [-include_replicated_objects] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of cell objects in the current design that match a specified search pattern. The default<br/>
		/// command returns a list of all cells in the current_instance of the open design, as specified by the<br/>
		/// current_instance command.<br/>
		/// You can use the -hierarchical option to extract cells from the hierarchy of the current<br/>
		/// design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The get_cells command also includes an option to get all replicated cells that are added to a<br/>
		/// design during physical optimization, or phys_opt_design. The use of the -<br/>
		/// include_replicated_objects option returns the replicated cells of an object when the<br/>
		/// original cell is returned. You can use this option to ensure that constraints or properties that are<br/>
		/// applied to a cell are also applied to its replicated cells.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example uses regular expression to return cells in the BFT example design that<br/>
		/// match the filter expressions for NAME and REF_NAME. In the first command the NAME is<br/>
		/// specified in the search pattern, while the second command filters on the NAME property. These<br/>
		/// commands return the same results:<br/>
		/// get_cells -regexp -filter { REF_NAME =~ FD.* } .*validFor.*<br/>
		/// get_cells -regexp -filter { NAME =~ .*validFor.* &amp;&amp; REF_NAME =~ FD.* }<br/>
		/// The following example searches all levels of the hierarchy for cells beginning with cpu, or fft, and<br/>
		/// joins each cell returned with the newline character to put it on a separate line:<br/>
		/// join [get_cells -hier {cpu* fft*}] \n<br/>
		/// This example gets a list of properties and property values attached to the second object of the<br/>
		/// list returned by get_cells:<br/>
		/// report_property [lindex [get_cells] 1]<br/>
		/// Note: If there are no cells matching the pattern you will get a warning.<br/>
		/// This example prints a list of the library cells instantiated into the design at all levels of the<br/>
		/// hierarchy, sorting the list for unique names so that each cell is only printed one time:<br/>
		/// foreach cell [lsort -unique [get_property LIB_CELL [get_cells -hier \<br/>
		/// -filter {IS_PRIMITIVE==1}]]] {puts $cell}<br/>
		/// The following example demonstrates the effect of -hierarchical searches, without and with<br/>
		/// -regexp:<br/>
		/// get_cells -hierarchical *mmcm*<br/>
		/// mmcm_replicator_inst_1<br/>
		/// mmcm_replicator_inst_1/mmcm_stage[0].mmcm_channel[0].mmcm<br/>
		/// get_cells -hierarchical -regexp .*mmcm.*<br/>
		/// mmcm_replicator_inst_1<br/>
		/// mmcm_replicator_inst_1/mmcm_stage[0].mmcm_channel[0].mmcm<br/>
		/// mmcm_replicator_inst_1/mmcm_stage[0].mmcm_channel[0].mmcm/GND<br/>
		/// mmcm_replicator_inst_1/mmcm_stage[0].mmcm_channel[0].mmcm/MMCM_Base<br/>
		/// Note: The last two cells (GND and MMCM_Base) were not returned in the first example (without -<br/>
		/// regexp) because the cell names do not match the search pattern, as it is applied to each level of the<br/>
		/// hierarchy.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example runs the report_drc command on the current design, and returns any<br/>
		/// cells associated with DRC violations:<br/>
		/// report_drc -name drc_1<br/>
		/// get_cells -of_objects [get_drc_violations]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 648<br/>
		/// </para>
		/// </summary>
		/// <param name="hsc">(Optional) Hierarchy separator Default: /</param>
		/// <param name="hierarchical">(Optional) Search level-by-level in current instance</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get cells of these pins, timing paths, nets, bels, clock<br/>
		/// regions, sites, or drc violations<br/>
		/// </para>
		/// </param>
		/// <param name="match_style">(Optional) Style of pattern matching Default: sdc Values: ucf, sdc</param>
		/// <param name="include_replicated_objects">
		/// <para>
		/// (Optional)<br/>
		/// Include replicated objects when searching for patterns. This<br/>
		/// option is valid only when patterns is specified.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match cell names against patterns Default: *</param>
		/// <returns>list of cell objects</returns>
		public TTCL get_cells(String hsc = null, bool? hierarchical = null, bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, get_cells_match_style? match_style = null, bool? include_replicated_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_cells [-hsc <arg>] [-hierarchical] [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-include_replicated_objects] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_cells(hsc, hierarchical, regexp, nocase, filter, of_objects, match_style, include_replicated_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of cfgmem_parts available in the software<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_cfgmem_parts [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Get a list of configuration flash memory devices supported by the Vivado Design Suite or Vivado<br/>
		/// Lab Edition.<br/>
		/// Xilinx® FPGAs can be configured from an external nonvolatile memory device, or they can be<br/>
		/// configured by an external smart source, such as a microprocessor, DSP processor,<br/>
		/// microcontroller, PC, or board tester. The two configuration datapaths include a serial datapath<br/>
		/// that is used to minimize the device pin requirements for configuration, and a parallel 8-bit, 16-bit,<br/>
		/// or 32-bit datapath used for higher performance or link to industry-standard interfaces ideal for<br/>
		/// external data sources like processors, or x8- or x16-parallel flash memory.<br/>
		/// The process whereby the design specific data is loaded or programmed into the Xilinx FPGA is<br/>
		/// called configuration. The create_hw_cfgmem command defines a flash memory device used<br/>
		/// for configuring and booting the hardware device.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// After the hw_cfgmem object is created, and associated with the hw_device, the configuration<br/>
		/// memory can be programmed with the bitstream and other data from a memory configuration file<br/>
		/// created with the write_cfgmem command. The hw_cfgmem object is programmed using the<br/>
		/// program_hw_cfgmem command.<br/>
		/// The configuration memory part can be used to define the hardware configuration memory in the<br/>
		/// Hardware Manager of the Vivado Design Suite, to enable programming and debugging the design<br/>
		/// in the FPGA hardware. Use the create_hw_cfgmem command to define the configuration<br/>
		/// memory for use with the current hardware device.<br/>
		/// This command returns a list of cfgmem_part objects that match the specified search criteria, or<br/>
		/// returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 653<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'cfgmem_part' objects of these types: 'part hw_device'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'cfgmem_part' objects against patterns. Default: *</param>
		/// <returns>list of cfgmem_part objects</returns>
		public TTCL get_cfgmem_parts(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_cfgmem_parts [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_cfgmem_parts(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get the clock regions for the current device.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_clock_regions [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of clock regions on the target part that match a specified search pattern. The default<br/>
		/// command gets a list of all clock regions on the device in an open design.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the clock regions matching the search pattern:<br/>
		/// get_clock_regions X0*<br/>
		/// The following example returns the clock regions filtered by the specified property:<br/>
		/// get_clock_regions -filter {LOW_X==0}<br/>
		/// Note: These two examples return the same set of clock regions.<br/>
		/// The following example returns the clock regions that the specified ILA debug core trigger is<br/>
		/// assigned to, or placed in:<br/>
		/// get_clock_regions -of_objects [get_cells -hierarchical basic_trigger*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 657<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions.</param>
		/// <param name="nocase">
		/// <para>
		/// (Optional)<br/>
		/// Perform case-insensitive matching. (valid only when -regexp<br/>
		/// specified).<br/>
		/// </para>
		/// </param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get the clock_regions of these tiles, sites, slrs, cells, or<br/>
		/// package bank<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match objects' name against patterns. Default: *</param>
		/// <returns>clock_regions</returns>
		public TTCL get_clock_regions(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_clock_regions [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_clock_regions(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of clocks in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_clocks [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-match_style &lt;arg&gt;] [-include_generated_clocks] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of clocks in the current design that match a specified search pattern. The default<br/>
		/// command gets a list of all clocks in the design, like the all_clocks command.<br/>
		/// Clocks can be created using the create_clock or the create_generated_clock<br/>
		/// commands, or can be automatically generated by the tool, at the output of an MMCM for<br/>
		/// instance.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of clocks matching the various search patterns:<br/>
		/// get_clocks {*clock *ck *Clk}<br/>
		/// Note: If there are no clocks matching the pattern you will get a warning.<br/>
		/// The following example gets the master clock object, and all generated clocks derived from that<br/>
		/// clock:<br/>
		/// get_clocks -include_generated_clocks wbClk<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example gets all properties and property values attached to the specified clock:<br/>
		/// report_property -all [get_clocks wbClk]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 660<br/>
		/// </para>
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
		public TTCL get_clocks(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, String match_style = null, bool? include_generated_clocks = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_clocks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-include_generated_clocks] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_clocks(regexp, nocase, filter, of_objects, match_style, include_generated_clocks, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create the Project summary dashboard<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_dashboard_gadgets [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Gets a list of the dashboard gadgets in the current project.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the dashboard gadgets in the current project:<br/>
		/// get_dashboard_gadgets<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 667<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Match gadget names against patterns Default: * Values: The<br/>
		/// default search pattern is the wildcard *<br/>
		/// </para>
		/// </param>
		public TTCL get_dashboard_gadgets(bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_dashboard_gadgets [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_dashboard_gadgets(quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of debug cores in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_debug_cores [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of Vivado Lab Edition debug cores in the current project that match a specified search<br/>
		/// pattern. The default command gets a list of all debug cores in the project.<br/>
		/// Debug cores are added to the project with the create_debug_core command. When a ILA<br/>
		/// debug core (labtools_ila_v3) is added to the project, it is contained within a Debug Hub core<br/>
		/// (labtools_xsdbmasterlib_v2), and includes a CLK port and a PROBE port as a default. Additional<br/>
		/// ports can be added to the debug core with the use of the create_debug_port command.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following command gets a list of the Vivado Lab Edition debug cores in the current project:<br/>
		/// get_debug_cores<br/>
		/// Note: A Debug Hub core is returned as one of the debug cores in the project. You cannot directly create<br/>
		/// this core, but it is automatically added by the tool when you add any ILA cores to the project.<br/>
		/// The following example gets the properties of the specified debug core:<br/>
		/// report_property [get_debug_cores myCore]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 669<br/>
		/// </para>
		/// </summary>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get cores of these debug ports or nets</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match debug cores against patterns Default: *</param>
		/// <returns>list of debug_core objects</returns>
		public TTCL get_debug_cores(String filter = null, TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_debug_cores [-filter <arg>] [-of_objects <args>] [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_debug_cores(filter, of_objects, regexp, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of debug ports in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_debug_ports [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of ports defined on ILA debug cores in the current project that match a specified<br/>
		/// search pattern. The default command gets a list of all debug ports in the project.<br/>
		/// Debug ports are defined when ILA debug cores are created with the create_debug_core<br/>
		/// command. Ports can be added to existing debug cores with the create_debug_port<br/>
		/// command.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following command gets a list of the ports from the ILA debug cores in the current project,<br/>
		/// with a PORT_WIDTH property of 8:<br/>
		/// get_debug_ports -filter {PORT_WIDTH==8}<br/>
		/// The following example gets the properties attached to the specified debug port:<br/>
		/// report_property [get_debug_ports myCore/PROBE1]<br/>
		/// Note: The debug port is defined by the core_name/port_name combination.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 672<br/>
		/// </para>
		/// </summary>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get ports of these debug cores</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match debug ports against patterns Default: *</param>
		/// <returns>list of debug_port objects</returns>
		public TTCL get_debug_ports(String filter = null, TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_debug_ports [-filter <arg>] [-of_objects <args>] [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_debug_ports(filter, of_objects, regexp, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of designs in the current project<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_designs [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of open designs in the current project that match a specified search pattern. The<br/>
		/// default command gets a list of all open designs in the project.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets all open designs in the current project:<br/>
		/// get_designs<br/>
		/// The following example gets the assigned properties of an open design matching the search<br/>
		/// pattern:<br/>
		/// report_property [get_designs r*]<br/>
		/// Note: If there are no designs matching the pattern you will get a warning.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 675<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match design names against patterns Default: *</param>
		/// <returns>list of design objects</returns>
		public TTCL get_designs(bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_designs [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_designs(regexp, nocase, filter, quiet, verbose, patterns));
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
		public TTCL get_drc_checks(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, String abbrev = null, TCLParameterList ruledecks = null, bool? quiet = null, bool? verbose = null, String patterns = null)
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
		public TTCL get_drc_ruledecks(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
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
		public TTCL get_drc_violations(String name = null, bool? regexp = null, String filter = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_drc_violations [-name <arg>] [-regexp] [-filter <arg>] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_drc_violations(name, regexp, filter, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of source files<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_files [-regexp] [-nocase] [-filter &lt;arg&gt;] [-compile_order &lt;arg&gt;] [-used_in &lt;arg&gt;] [-references] [-all] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of files in the current project that match a specified search pattern. The default<br/>
		/// command gets a list of all files in the project.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The get_files command returns a machine readable list of files in the project, in a design, or in<br/>
		/// a sub-design such as an IP core or block design. You can filter the results returned by<br/>
		/// get_files using one of the command arguments such as -of_objects, -compile_order,<br/>
		/// -used_in, and -filter.<br/>
		/// The -compile_order and -used_in options must be used together to return a list of files<br/>
		/// from the sources or constraints filesets used in synthesis, simulation, or implementation, sorted<br/>
		/// according to the order of evaluation by the Vivado tools. The -compile_order and -used_in<br/>
		/// options use complex file ordering rules that can change based on header files, include files, or<br/>
		/// other language options. You can also filter files returned by get_files according to the<br/>
		/// USED_IN property, using the -filter option instead of the -used_in option.<br/>
		/// You can use the report_compile_order command to generate a report of all files in the<br/>
		/// sources or constraints filesets, used in synthesis, simulation, AND implementation, sorted into<br/>
		/// different sections.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the VHDL files in the design that are used in simulation:<br/>
		/// get_files -filter {FILE_TYPE == VHDL &amp;&amp; USED_IN =~ simulation*}<br/>
		/// This example returns the design source files that are used in simulation:<br/>
		/// get_files -compile_order sources -used_in simulation<br/>
		/// This example gets a list of files associated with the specified IP core composite file (ip.xci), from<br/>
		/// the sources_1 fileset that are used in synthesis:<br/>
		/// get_files -compile_order sources -used_in synthesis -of [get_files ip.xci]<br/>
		/// The following example gets a list of the files found in the sources_1 and constrs_1 filesets:<br/>
		/// get_files -of [get_filesets {sources_1 constrs_1}]<br/>
		/// Note: If there are no files matching the pattern you will get a warning.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 691<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="compile_order">(Optional) Get files by type and in compilation order (must use with - used_in)</param>
		/// <param name="used_in">(Optional) Get files used in a specific step (must use with - compile_order)</param>
		/// <param name="references">
		/// <para>
		/// (Optional)<br/>
		/// Get files referenced in the provided objects (must use with -<br/>
		/// of_objects)<br/>
		/// </para>
		/// </param>
		/// <param name="all">(Optional) Include all internal files.</param>
		/// <param name="of_objects">(Optional) Get 'file' objects of these types: 'file fileset ip reconfig_module'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match file names against patterns Default: *</param>
		/// <returns>list of file objects</returns>
		public TTCL get_files(bool? regexp = null, bool? nocase = null, String filter = null, String compile_order = null, String used_in = null, bool? references = null, bool? all = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_files [-regexp] [-nocase] [-filter <arg>] [-compile_order <arg>] [-used_in <arg>] [-references] [-all] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_files(regexp, nocase, filter, compile_order, used_in, references, all, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of filesets in the current project<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_filesets [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of filesets in the current project that match a specified search pattern. The default<br/>
		/// command gets a list of all filesets in the project.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the source files in the Source Set:<br/>
		/// get_files -of_objects [get_filesets sources_1]<br/>
		/// The following example makes project_2 the active project, and then gets a list of filesets<br/>
		/// beginning with the letter s or the letter r:<br/>
		/// current_project project_2<br/>
		/// get_filesets s* r* -quiet<br/>
		/// Note: If there are no filesets matching the pattern, such as r*, you will get a warning that no filesets<br/>
		/// matched the specified pattern. However, in the above example the use of -quiet will suppress that<br/>
		/// warning message.<br/>
		/// The following example gets filesets beginning with the letter C, using a case insensitive regular<br/>
		/// expression:<br/>
		/// get_filesets C.* -regexp -nocase<br/>
		/// In the above example, constrs_1 and constrs_2 constraint sets would be returned if defined in<br/>
		/// the current project.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 695<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'fileset' objects of these types: 'reconfig_module'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match fileset names against patterns Default: *</param>
		/// <returns>list of fileset objects</returns>
		public TTCL get_filesets(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_filesets [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_filesets(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of generated clocks in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_generated_clocks [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-match_style &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of generated clocks in the current project that match a specified search pattern. The<br/>
		/// default command gets a list of all generated clocks in the project.<br/>
		/// A generated clock can be added to the design using the create_generated_clock<br/>
		/// command, or can be automatically generated by the tool, at the output of an MMCM for<br/>
		/// instance.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the names of all generated clocks in the current project:<br/>
		/// get_generated_clocks<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 698<br/>
		/// </para>
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
		public TTCL get_generated_clocks(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, String match_style = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_generated_clocks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_generated_clocks(regexp, nocase, filter, of_objects, match_style, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get highlighted objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_highlighted_objects [-color_index &lt;arg&gt;] [-rgb &lt;args&gt;] [-color &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Gets the highlighted objects in the current design open in the Vivado IDE. Objects can be<br/>
		/// highlighted with the highlight_objects command.<br/>
		/// You can get all highlighted objects in the design, or specify highlighted objects by color, by color<br/>
		/// index, or by RGB value.<br/>
		/// Note: This Tcl command works only when Vivado is run in GUI mode.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets all the highlighted objects in the current design:<br/>
		/// get_highlighted_objects<br/>
		/// The following example gets the object in the current design that are highlighted in the specified<br/>
		/// color:<br/>
		/// get_highlighted_objects -color cyan<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 706<br/>
		/// </para>
		/// </summary>
		/// <param name="color_index">(Optional) Color index</param>
		/// <param name="rgb">(Optional) RGB color index list</param>
		/// <param name="color">(Optional) Valid values are red green blue magenta yellow cyan and orange</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of highlighted objects</returns>
		public TTCL get_highlighted_objects(String color_index = null, TCLParameterList rgb = null, String color = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_highlighted_objects [-color_index <arg>] [-rgb <args>] [-color <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_highlighted_objects(color_index, rgb, color, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of hardware AXI transactions.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_axi_txns [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the read or write transactions for the specified JTAG to AXI Master core, hw_axi object.<br/>
		/// The JTAG to AXI Master is a customizable IP core that works as an AXI Master to drive AXI<br/>
		/// transactions and drive AXI signals that are internal to the hardware device. This IP can be used in<br/>
		/// Vivado® IP integrator or can be instantiated in HDL in a Vivado project.<br/>
		/// The JTAG-AXI core supports all memory-mapped AXI interfaces, except AXI4-Stream, and<br/>
		/// supports the AXI-Lite protocol. The AXI interface can be selected as a property of the core. The<br/>
		/// width of AXI data bus is customizable. This IP can drive any AXI4-Lite or Memory Mapped Slave<br/>
		/// directly, and can also be connected as the AXI Master to the interconnect. Run-time interaction<br/>
		/// with this core requires the use of the Vivado logic analyzer feature. Detailed documentation on<br/>
		/// the IP core can be found in the LogiCORE IP JTAG to AXI Master Product Guide (PG174). A tutorial<br/>
		/// showing its use can be found in the Vivado Design Suite Tutorial: Programming and Debugging<br/>
		/// (UG936).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The JTAG to AXI Master core must be instantiated in the RTL code, from the Xilinx IP catalog.<br/>
		/// AXI transactions are defined as complete READ or WRITE transactions between the AXI master<br/>
		/// and various slaves.<br/>
		/// This command returns a list of hw_axi_txn objects on the hw_device, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 708<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_axi_txn' objects of these types: 'hw_axi'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_axi_txn' objects against patterns. Default: *</param>
		/// <returns>hw_axi_txns</returns>
		public TTCL get_hw_axi_txns(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_axi_txns [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_axi_txns(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of hardware AXI objects.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_axis [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the JTAG to AXI Master core objects, or hw_axi objects, defined on the current hardware<br/>
		/// device.<br/>
		/// The JTAG to AXI Master is a customizable IP core that works as an AXI Master to drive AXI<br/>
		/// transactions and drive AXI signals that are internal to the hardware device. This IP can be used in<br/>
		/// Vivado® IP integrator or can be instantiated from the Xilinx® IP catalog into the HDL of a Vivado<br/>
		/// project. Run-time interaction with this core requires the use of the Vivado logic analyzer feature.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The JTAG-AXI core supports all memory-mapped AXI interfaces, except AXI4-Stream, and<br/>
		/// supports the AXI-Lite protocol. The AXI interface can be defined as a property of the core. The<br/>
		/// width of the AXI data bus is customizable. This IP can drive any AXI4-Lite or Memory Mapped<br/>
		/// Slave directly, and can also be connected as the AXI Master to the interconnect. Detailed<br/>
		/// documentation on the IP core can be found in the LogiCORE IP JTAG to AXI Master Product Guide<br/>
		/// (PG174). A tutorial showing its use can be found in the Vivado Design Suite Tutorial: Programming<br/>
		/// and Debugging (UG936).<br/>
		/// AXI cores can be found in the synthesized or implemented design netlist using the<br/>
		/// get_debug_cores command. This will return instances of the debug cores in the design that<br/>
		/// are related to the hw_axi objects, and other debug cores on the hw_device.<br/>
		/// This command returns a list of AXI Master core objects, hw_axis, on the hw_device, or returns an<br/>
		/// error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 711<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_axi' objects of these types: 'hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_axi' objects against patterns. Default: *</param>
		/// <returns>hw_axi</returns>
		public TTCL get_hw_axis(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_axis [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_axis(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of hardware cfgmems.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_cfgmems [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Get a list of hardware configuration memory (hw_cfgmem) objects created for the current<br/>
		/// hw_device.<br/>
		/// Xilinx FPGAs are configured by loading design-specific configuration data, in the form of a<br/>
		/// bitstream file, into the internal memory of the hw_device. The hw_cfgmem defines a flash<br/>
		/// memory device used for configuring and booting the Xilinx FPGA device. Once the hw_cfgmem<br/>
		/// object is created, and associated with the hw_device, the configuration memory can be<br/>
		/// programmed with the bitstream and other data using the program_hw_cfgmem command.<br/>
		/// The hw_cfgmem object is associated with the specified hw_device object through the<br/>
		/// PROGRAM.HW_CFGMEM property on the device object. The get_hw_cfgmems command lets<br/>
		/// you work with the hw_cfgmem object.<br/>
		/// This command returns a list of hw_cfgmem objects that match the specified search criteria, or<br/>
		/// returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 714<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_cfgmem' objects against patterns. Default: *</param>
		/// <returns>hardware cfgmems</returns>
		public TTCL get_hw_cfgmems(bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_cfgmems [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_cfgmems(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of Versal integrated and soft DDRMC cores.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_ddrmcs [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Xilinx Versal devices include integrated DDR Memory Controllers (DDRMC), as well as fabric<br/>
		/// based memory controllers. Refer to the LogiCore IP Product Guide: Versal ACAP Network on Chip<br/>
		/// and Integrated Memory Controller (PG313) for more information on the integrated controller core.<br/>
		/// Refer to Versal ACAP Soft DDR4 Memory IP (PG353) for more information on the fabric based<br/>
		/// memory controller. The memory controllers contain memory configuration and memory<br/>
		/// calibration data that can be accessed from the Xilinx Vivado Hardware Manager. The calibration<br/>
		/// and margin data are organized and presented in a graphical format for ease of analysis.<br/>
		/// The get_hw_ddrmc command returns a list of memory cores on the current hardware device.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the HBM with the specified DISPLAY_NAME:<br/>
		/// get_hw_hbms -filter {DISPLAY_NAME == HBM_2}<br/>
		/// The following example returns the DDRMC with the specified DISPLAY_NAME:<br/>
		/// get_hw_ddrmcs -filter {DISPLAY_NAME == DDRMC_1}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 717<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_ddrmc' objects of these types: 'hw_server<br/>
		/// hw_target hw_device'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_ddrmc' objects against patterns. Default: *</param>
		/// <returns>integrated and soft DDRMC cores</returns>
		public TTCL get_hw_ddrmcs(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_ddrmcs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_ddrmcs(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of hardware devices.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_devices [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the hardware devices on the open target of a connected hardware server.<br/>
		/// Each hardware target can have one or more Xilinx devices to program, or to use for debugging<br/>
		/// purposes. The current device is specified or returned by the current_hw_device command.<br/>
		/// This command returns a list of available hardware device objects, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 720<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_device' objects of these types: 'hw_target'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_device' objects against patterns. Default: *</param>
		/// <returns>hardware devices</returns>
		public TTCL get_hw_devices(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_devices [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_devices(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware HBM cores.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_hbms [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Certain Xilinx® UltraScale+ devices include an integrated High-Bandwidth Memory (HBM)<br/>
		/// controller. Refer to the LogiCore IP Product Guide: AXI High Bandwidth Memory Controller<br/>
		/// (PG276) for more information on this core. The HBM controller and memory stacks contain both<br/>
		/// performance counters and temperature sensors that can be accessed through an HBM activity<br/>
		/// monitor (amon) from within the Xilinx Vivado hardware manager. The HBM activity monitor can<br/>
		/// be used to gain real-time access to performance monitoring and temperature sensors on the<br/>
		/// physical device. The Vivado hardware manager displays read, write, and overall throughput of<br/>
		/// data, as well as the device temperature. The activity monitor displays, captures, and exports data<br/>
		/// to a CSV file when it is running.<br/>
		/// The get_hw_hbms command returns a list of HBM cores on the current hardware target.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the HBM with the specified DISPLAY_NAME:<br/>
		/// get_hw_hbms -filter {DISPLAY_NAME == HBM_2}<br/>
		/// This example returns all the HBM objects in the current device:<br/>
		/// get_hw_hbms<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 723<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_hbm' objects of these types: 'hw_server hw_target hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_hbm' objects against patterns. Default: *</param>
		/// <returns>hardware HBM cores</returns>
		public TTCL get_hw_hbms(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_hbms [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_hbms(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of hardware ILA data objects.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_ila_datas [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the ILA data objects in the Vivado logic analyzer.<br/>
		/// The upload_hw_ila_data command creates a hw_ila_data object in the process of moving<br/>
		/// the captured data from the ILA debug core, hw_ila, on the physical FPGA device, hw_device. The<br/>
		/// read_hw_ila_data command can also create a hw_ila_data object when reading an ILA data<br/>
		/// file from disk.<br/>
		/// The hw_ila_data object can be viewed in the waveform viewer of the Vivado logic analyzer by<br/>
		/// using the display_hw_ila_data command, and can be written to disk using the<br/>
		/// write_hw_ila_data command.<br/>
		/// This command returns a list of available hardware ILA data objects, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 726<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_ila_data' objects of these types: 'hw_ila hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_ila_data' objects against patterns. Default: *</param>
		/// <returns>hardware ILA data</returns>
		public TTCL get_hw_ila_datas(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_ila_datas [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_ila_datas(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of hardware ILA.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_ilas [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the ILA debug core objects defined on the current hardware device.<br/>
		/// The Integrated Logic Analyzer (ILA) debug core lets you perform in-system debug of<br/>
		/// implemented designs, or design bitstreams, on a programmed Xilinx FPGA. The ILA core includes<br/>
		/// many advanced features of modern logic analyzers, including boolean trigger equations, and edge<br/>
		/// transition triggers. You can use the ILA core to probe specific signals of the design, to trigger on<br/>
		/// programmed hardware events, and capture data from the Xilinx FPGA in real-time. Refer to<br/>
		/// LogiCORE IP Integrated Logic Analyzer (PG172) for details of the ILA core.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// You can add ILA debug cores into the RTL source files of a design, or in the synthesized netlist<br/>
		/// using the create_debug_core command. Refer to the Vivado Design Suite User Guide: Vivado<br/>
		/// Programming and Debugging (UG908) for more information on adding debug cores and signal<br/>
		/// probes to the design. You can get the debug cores in the synthesized netlist by using the<br/>
		/// get_debug_core commands. However, though they are related, the design debug cores are<br/>
		/// separate from the hardware debug cores found in the Hardware Manager feature of the Vivado<br/>
		/// Design Suite.<br/>
		/// Debug cores and probes are written to the probes file (.ltx) using the write_debug_probes<br/>
		/// command and associated with the hardware device, along with the bitstream file (.bit), using<br/>
		/// the PROBES.FILE and PROGRAM.FILE properties of the hw_device object. The hardware device<br/>
		/// is programmed with this information using the program_hw_devices command.<br/>
		/// The steps to debug your design in hardware using an ILA debug core are:<br/>
		/// 1. Connect to the hardware server and target using connect_hw_server and<br/>
		/// open_hw_target.<br/>
		/// 2. Program the FPGA with the bitstream (.bit) and probes (.ltx) files using<br/>
		/// program_hw_devices.<br/>
		/// 3. Set up the ILA debug core trigger and capture controls using set_property to set<br/>
		/// properties of the ILA.<br/>
		/// 4. Arm the ILA debug core trigger using run_hw_ila.<br/>
		/// 5. View the captured data from the ILA debug core in the Waveform window of the Vivado<br/>
		/// logic analyzer feature using display_hw_ila_data.<br/>
		/// 6. Optionally use the VIO debug core to drive control signals and/or view design status signals.<br/>
		/// See get_hw_vios for more information.<br/>
		/// 7. Optionally use the JTAG-to-AXI Master debug core to run transactions to interact with<br/>
		/// various AXI slave cores in your design. See get_hw_axis for more information.<br/>
		/// This command returns a list of ILA debug core objects on the device, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 729<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_ila' objects of these types: 'hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_ila' objects against patterns. Default: *</param>
		/// <returns>hardware ILAs</returns>
		public TTCL get_hw_ilas(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_ilas [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_ilas(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware Migs cores.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_migs [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the hw_mig objects on the current hardware device.<br/>
		/// Memory IP included in the Xilinx IP catalog are used to generate memory controllers and<br/>
		/// interfaces for Xilinx® devices. Memory IP includes different IP cores from the Xilinx IP catalog<br/>
		/// depending on the device architecture and memory interface specified. Refer to Zynq-7000 SoC<br/>
		/// and 7 Series Devices Memory Interface Solutions (UG586), or UltraScale Architecture-Based FPGAs<br/>
		/// Memory Interface Solutions (PG150), for details of the available memory IP.<br/>
		/// When added to a design, the memory IP needs to be implemented into the design. This occurs<br/>
		/// after the design is synthesized, during the design optimization phase of implementation, or<br/>
		/// opt_design, or can be done manually with the implement_mig_cores command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// A memory controller can be debug enabled when added into the design from the Xilinx IP<br/>
		/// catalog. In the Vivado logic analyzer, or the Vivado Lab Edition, memory controllers implemented<br/>
		/// into a design are associated with hw_mig objects, one hw_mig object per debug-enabled memory<br/>
		/// controller. The hw_mig object will have all the properties needed to get the calibration status and<br/>
		/// draw the per-bit eye margin views.<br/>
		/// In the Vivado logic analyzer, or Vivado Lab Edition, the hw_mig object lets you verify the<br/>
		/// calibration and read window margins in your memory interface design. You can use the hardware<br/>
		/// manager GUI to check the calibration status, verify the read margin for both rising and falling<br/>
		/// edges of the clock or DQS. You can also use an ILA core to verify the data integrity for the read<br/>
		/// and write operations.<br/>
		/// This command returns a list of hw_mig objects on the current hardware device, or returns an<br/>
		/// error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 733<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_mig' objects of these types: 'hw_server hw_target hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_mig' objects against patterns. Default: *</param>
		/// <returns>hardware migs cores</returns>
		public TTCL get_hw_migs(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_migs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_migs(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of soft PCIe core(s).<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_pcies [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-patterns &lt;arg&gt;] [-filter &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Get all the Peripheral Component Interconnect Express (PCIe) debug core objects, hw_pcie's,<br/>
		/// defined on the current hardware device.<br/>
		/// The customizable LogiCORE IP PCIe core for Xilinx ACAPs is designed for evaluating and<br/>
		/// monitoring the PCIe Link Training and Status State Machine (LTSSM) running on the Gigabit<br/>
		/// Transceivers (GTs). In the Vivado Hardware Manager, Versal PCIe soft cores implemented in the<br/>
		/// design, are represented as hw_pcie objects. You can use these PCIe debug cores to solve a range<br/>
		/// of debug and validation problems; from viewing the PCIe link info to the LTSSM state transition<br/>
		/// diagram.<br/>
		/// This command returns a list of PCIe debug core objects on the device, or returns an error if it<br/>
		/// fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns all the available PCIe cores<br/>
		/// get_hw_pcies<br/>
		/// The following example returns PCIe core with the specified DISPLAY_NAME<br/>
		/// get_hw_pcies -filter {NAME == "PCIe_0"}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 737<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_pcie' objects of these types: 'hw_server hw_target hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="patterns">(Optional) Match the 'hw_pcie' objects against patterns. Default: *</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>PCIe core(s)</returns>
		public TTCL get_hw_pcies(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String patterns = null, String filter = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_hw_pcies [-of_objects <args>] [-regexp] [-nocase] [-patterns <arg>] [-filter <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_hw_pcies(of_objects, regexp, nocase, patterns, filter, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of hardware probes.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_probes [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the hw_probe objects in the Hardware Manager that are defined on signals in the design,<br/>
		/// or that are assigned to the specified ILA or VIO debug cores.<br/>
		/// You can add ILA and VIO debug cores in the RTL source files of a design by customizing the core<br/>
		/// from the IP catalog, or add ILA debug cores into the synthesized netlist using the<br/>
		/// create_debug_core command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Signals in the design can be probed to monitor signal values and track hardware events on the<br/>
		/// FPGA device. Debug probes can be added to ILA debug cores in the synthesized netlist design<br/>
		/// using the create_debug_port command, and connected to signals in the design using<br/>
		/// connect_debug_port. Probes can only be added to VIO debug cores when the IP core is<br/>
		/// customized, or re-customized, from the IP catalog, and signals connected to it in the RTL design.<br/>
		/// Refer to the Vivado Design Suite User Guide: Vivado Programming and Debugging (UG908) for more<br/>
		/// information on adding ILA and VIO debug cores and signal probes to the design.<br/>
		/// Debug cores and probes are written to a probes file (.ltx) with write_debug_probes, and<br/>
		/// associated with the hardware device, along with the bitstream file (.bit), using the PROBES.FILE<br/>
		/// and PROGRAM.FILE properties of the hw_device object. The hardware device is programmed<br/>
		/// with this information using the program_hw_devices command.<br/>
		/// This command returns a list of debug probe objects on the device, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 740<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_probe' objects of these types: 'hw_interface hw_ila hw_vio'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_probe' objects against patterns. Default: *</param>
		/// <returns>hardware probes</returns>
		public TTCL get_hw_probes(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_probes [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_probes(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of hardware servers.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_servers [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// IMPORTANT! You must use the open_hw command to open the Hardware Manager in the Vivado<br/>
		/// Design Suite before using this command.<br/>
		/// This command returns hardware server objects that are connected to the current instance of the<br/>
		/// Vivado Design Suite through the use of the connect_hw_server command.<br/>
		/// Hardware servers are instances of the Xilinx hardware server (hw_server) application running<br/>
		/// remotely, or on the local machine. The hardware server manages connections to a hardware<br/>
		/// target, for instance a hardware board containing a JTAG chain of one or more Xilinx devices to be<br/>
		/// used for programming and debugging your FPGA design.<br/>
		/// This command returns a list of connected hardware server objects.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 744<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_server' objects against patterns. Default: *</param>
		/// <returns>hardware servers</returns>
		public TTCL get_hw_servers(bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_servers [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_servers(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO GT commons.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_commons [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the QPLL objects, hw_sio_commons, defined on the IBERT debug core on the current<br/>
		/// hardware device.<br/>
		/// For each serial transceiver channel, there is a ring PLL called Channel PLL (CPLL). In Xilinx<br/>
		/// UltraScale and 7 series FPGAs, the high-speed transceivers have an additional common or shared<br/>
		/// PLL per quad, or Quad PLL (QPLL). This QPLL is a shared LC PLL to support high speed, high<br/>
		/// performance, and low power multi-lane applications.<br/>
		/// On the device, the GTXE2_CHANNEL component has the serial transceiver and CPLL units and<br/>
		/// the GTXE2_COMMON has the QPLL unit.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns a list of QPLL objects on the device as hw_sio_common objects, or returns<br/>
		/// an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 747<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_sio_common' objects of these types: 'hw_server<br/>
		/// hw_target hw_device hw_sio_ibert hw_sio_gtgroup<br/>
		/// hw_sio_pll'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_common' objects against patterns. Default: *</param>
		/// <returns>hardware SIO GT commons</returns>
		public TTCL get_hw_sio_commons(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_commons [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_commons(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO GT groups.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_gtgroups [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the groups of GTs, hw_sio_gtgroups, as they relate to the quads that are in use on the<br/>
		/// IBERT debug core on the current hardware device.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// GT groups, relate to the IO Banks on the hardware device, with the number of available banks<br/>
		/// and GT pins determined by the target device. On the Kintex-7 xc7k325 part, for example, there<br/>
		/// are four quads, each containing four differential GT pins, and two differential REFCLK pins. Each<br/>
		/// GT pin has its own transmitter, TX, and receiver, RX. Quads can also include one shared PLL per<br/>
		/// quad, or Quad PLL. The quads are defined on the IBERT debug core, and can be customized with<br/>
		/// a number of user settings when the IBERT is added into the RTL design. Refer to the LogiCORE IP<br/>
		/// Integrated Bit Error Ratio Tester (IBERT) for 7 Series GTX Transceivers v3.0 (PG132)or to 7 Series<br/>
		/// FPGAs GTX/GTH Transceivers User Guide (UG476) or UltraScale Architecture GTH Transceivers User<br/>
		/// Guide (UG576) for more information.<br/>
		/// This command returns a list of GT group objects on the IBERT debug core, or returns an error if it<br/>
		/// fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 750<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_sio_gtgroup' objects of these types: 'hw_server<br/>
		/// hw_target hw_device hw_sio_ibert hw_sio_common<br/>
		/// hw_sio_pll hw_sio_gt hw_sio_tx hw_sio_rx'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_gtgroup' objects against patterns. Default: *</param>
		/// <returns>hardware SIO GT groups.</returns>
		public TTCL get_hw_sio_gtgroups(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_gtgroups [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_gtgroups(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO GTs.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_gts [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the Gigabit Transceiver objects (GTs), hw_sio_gt, that are in use on the IBERT debug core<br/>
		/// on the current hardware device.<br/>
		/// The customizable LogiCORE™ IP Integrated Bit Error Ratio Tester (IBERT) core for Xilinx® FPGAs<br/>
		/// is designed for evaluating and monitoring the Gigabit Transceivers (GTs). The IBERT core enables<br/>
		/// in-system serial I/O validation and debug, letting you measure and optimize your high-speed<br/>
		/// serial I/O links in your FPGA-based system. Refer to the LogiCORE IP Integrated Bit Error Ratio<br/>
		/// Tester (IBERT) for 7 Series GTX Transceivers v3.0 (PG132)or to 7 Series FPGAs GTX/GTH Transceivers<br/>
		/// User Guide (UG476) or UltraScale Architecture GTH Transceivers User Guide (UG576) for more<br/>
		/// information.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Using the IBERT debug core you can configure and tune the GT transmitters and receivers<br/>
		/// through the Dynamic Reconfiguration Port (DRP) port of the GTX transceiver. This lets you<br/>
		/// change property settings on the GTs, as well as registers that control the values on the ports.<br/>
		/// This command returns a list of GT objects on the IBERT debug core, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 754<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_sio_gt' objects of these types: 'hw_server hw_target<br/>
		/// hw_device hw_sio_ibert hw_sio_gtgroup hw_sio_pll hw_sio_tx<br/>
		/// hw_sio_rx hw_sio_link'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_gt' objects against patterns. Default: *</param>
		/// <returns>hardware SIO GTs</returns>
		public TTCL get_hw_sio_gts(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_gts [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_gts(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO IBERT cores.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_iberts [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the Integrated Bit Error Ratio Tester (IBERT) debug core objects, hw_sio_ibert, defined<br/>
		/// on the current hardware device.<br/>
		/// The customizable LogiCORE™ IP Integrated Bit Error Ratio Tester (IBERT) core for Xilinx® FPGAs<br/>
		/// is designed for evaluating and monitoring the Gigabit Transceivers (GTs). The IBERT core enables<br/>
		/// in-system serial I/O validation and debug, letting you measure and optimize your high-speed<br/>
		/// serial I/O links in your FPGA-based system. Refer to the LogiCORE IP Integrated Bit Error Ratio<br/>
		/// Tester (IBERT) for 7 Series GTX Transceivers v3.0 (PG132) for more information.<br/>
		/// The IBERT debug core lets you configure and control the major features of GTs on the device,<br/>
		/// including:<br/>
		/// • TX pre-emphasis and post-emphasis<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • TX differential swing<br/>
		/// • RX equalization<br/>
		/// • Decision Feedback Equalizer (DFE)<br/>
		/// • Phase-Locked Loop (PLL) divider settings<br/>
		/// You can use the IBERT core when you are interested in addressing a range of in-system debug<br/>
		/// and validation problems; from simple clocking and connectivity issues to complex margin analysis<br/>
		/// and channel optimization issues.<br/>
		/// This command returns a list of IBERT debug core objects on the device, or returns an error if it<br/>
		/// fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 757<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_sio_ibert' objects of these types: 'hw_server<br/>
		/// hw_target hw_device hw_sio_gtgroup hw_sio_gt<br/>
		/// hw_sio_common hw_sio_pll hw_sio_tx hw_sio_rx hw_sio_link'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_ibert' objects against patterns. Default: *</param>
		/// <returns>hardware SIO IBERT cores.</returns>
		public TTCL get_hw_sio_iberts(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_iberts [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_iberts(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO link groups.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_linkgroups [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the defined groups, or associations of communication links between TX and RX objects<br/>
		/// on the GTs of the IBERT debug core defined on the current hardware device.<br/>
		/// Vivado Serial I/O analyzer is a link-based analyzer. The links define the communication paths and<br/>
		/// protocols between transmitters and receivers of the GigaBit transceivers on the device. Link<br/>
		/// groups, or hw_sio_linkgroup objects, let you associate links into related groups, to collectively<br/>
		/// configure properties and run scans.<br/>
		/// This command returns a list of linkgroups on the IBERT debug core, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 761<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_sio_linkgroup' objects of these types: 'hw_sio_link'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_linkgroup' objects against patterns. Default: *</param>
		/// <returns>hardware SIO link groups</returns>
		public TTCL get_hw_sio_linkgroups(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_linkgroups [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_linkgroups(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO links.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_links [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the communication links between TX and RX objects on the GTs of the IBERT debug<br/>
		/// core defined on the current hardware device.<br/>
		/// Vivado Serial I/O analyzer is a link-based analyzer, which lets you link between any transmitter<br/>
		/// and receiver within the IBERT design. The links define the communication paths and protocols<br/>
		/// between transmitters and receivers of the GigaBit transceivers on the device. You can configure<br/>
		/// the links by using the set_property command to specify property values on the link object.<br/>
		/// This command returns a list of link objects on the IBERT debug core, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 764<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_sio_link' objects of these types: 'hw_server<br/>
		/// hw_target hw_device hw_sio_ibert hw_sio_gtgroup hw_sio_gt<br/>
		/// hw_sio_tx hw_sio_rx hw_sio_linkgroup'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_link' objects against patterns. Default: *</param>
		/// <returns>hardware SIO links</returns>
		public TTCL get_hw_sio_links(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_links [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_links(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO PLLs.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_plls [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the PLL objects, hw_sio_pll, defined on the IBERT debug core on the current hardware<br/>
		/// device.<br/>
		/// For each serial transceiver channel, there is a ring PLL called Channel PLL (CPLL). In Xilinx<br/>
		/// UltraScale and 7 series FPGAs, the GTX has an additional shared PLL per quad, or Quad PLL<br/>
		/// (QPLL). This QPLL is a shared LC PLL to support high speed, high performance, and low power<br/>
		/// multi-lane applications.<br/>
		/// On the device, the GTXE2_CHANNEL component has the serial transceiver and CPLL units and<br/>
		/// the GTXE2_COMMON has the QPLL unit.<br/>
		/// This command returns a list of all PLL objects, both CPLLs and QPLLs on the device, or returns an<br/>
		/// error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 767<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_sio_pll' objects of these types: 'hw_server hw_target<br/>
		/// hw_device hw_sio_ibert hw_sio_gtgroup hw_sio_gt<br/>
		/// hw_sio_common'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_pll' objects against patterns. Default: *</param>
		/// <returns>hardware SIO PLLs</returns>
		public TTCL get_hw_sio_plls(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_plls [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_plls(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO RXs.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_rxs [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the receiver objects, hw_sio_rx, of the Gigabit Transceivers (GTs) that are in use on the<br/>
		/// IBERT debug core on the current hardware device.<br/>
		/// On the hardware device, each GT includes an independent receiver, which consists of a PCS and<br/>
		/// a PMA. High-speed serial data flows from traces on the board into the PMA of the GTX/GTH<br/>
		/// transceiver RX, into the PCS, and finally into the FPGA logic.<br/>
		/// This command returns a list of receiver objects on the device, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 770<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_sio_rx' objects of these types: 'hw_server hw_target<br/>
		/// hw_device hw_sio_ibert hw_sio_gtgroup hw_sio_gt<br/>
		/// hw_sio_link'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_rx' objects against patterns. Default: *</param>
		/// <returns>hardware SIO RXs</returns>
		public TTCL get_hw_sio_rxs(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_rxs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_rxs(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO scans.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_scans [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns serial I/O analyzer scan objects for the IBERT debug core.<br/>
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the<br/>
		/// specialized Eye Scan hardware of Xilinx UltraScale devices or 7 Series FPGAs. The Vivado serial<br/>
		/// I/O analyzer feature lets you to create, run, and save link scans.<br/>
		/// This command returns one or more hw_sio_scan objects, or returns an error if he command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 773<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_sio_scan' objects of these types: 'hw_sio_rx<br/>
		/// hw_sio_link hw_sio_sweep'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_scan' objects against patterns. Default: *</param>
		/// <returns>hardware SIO scans</returns>
		public TTCL get_hw_sio_scans(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_scans [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_scans(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO sweeps.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_sweeps [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Return the serial I/O analyzer link sweep objects defined on the IBERT debug core.<br/>
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the<br/>
		/// specialized features of Xilinx UltraScale devices or 7 series FPGAs. It can also be helpful to run<br/>
		/// multiple scans on a the link with different configuration settings for the GTs. This can help you<br/>
		/// determine which settings are best for your design. The Vivado serial I/O analyzer feature enables<br/>
		/// you to define, run, and save link sweeps, or collections of link scans run across a range of values.<br/>
		/// This command returns a link sweep object that you can use with the run_hw_sio_sweep<br/>
		/// command to run analysis on the specified links, or GT receivers. You can also save the sweep<br/>
		/// scan to disk using the write_hw_sio_sweep command.<br/>
		/// You can remove the created sweep object using remove_hw_sio_sweep.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns one or more hw_sio_sweep objects, or returns an error if the command<br/>
		/// fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 776<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_sio_sweep' objects of these types: 'hw_sio_link hw_sio_scan'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_sweep' objects against patterns. Default: *</param>
		/// <returns>hardware SIO sweeps</returns>
		public TTCL get_hw_sio_sweeps(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_sweeps [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_sweeps(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO TXs.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_txs [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the transmitter objects, hw_sio_tx, of the Gigabit Transceivers (GTs) that are in use on the<br/>
		/// IBERT debug core on the current hardware device.<br/>
		/// On the hardware device, each GT includes an independent transmitter, which consists of a PCS<br/>
		/// and a PMA. Parallel data flows from the device logic into the FPGA TX interface, through the PCS<br/>
		/// and PMA, and then out the TX driver as high-speed serial data.<br/>
		/// This command returns a list of transmitter objects on the device, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 780<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_sio_tx' objects of these types: 'hw_server hw_target<br/>
		/// hw_device hw_sio_ibert hw_sio_gtgroup hw_sio_gt<br/>
		/// hw_sio_link'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_tx' objects against patterns. Default: *</param>
		/// <returns>hardware SIO TXs</returns>
		public TTCL get_hw_sio_txs(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_txs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_txs(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of Versal soft memory controller cores.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_softmcs [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 783<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_softmc' objects of these types: 'hw_server<br/>
		/// hw_target hw_device'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_softmc' objects against patterns. Default: *</param>
		/// <returns>soft memory controller cores</returns>
		public TTCL get_hw_softmcs(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_softmcs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_softmcs(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SysMons.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sysmons [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the Sysmon debug core objects defined on the current hardware device.<br/>
		/// The System Monitor (SYSMON) Analog-to-Digital Converter (ADC) is used to measure die<br/>
		/// temperature and voltage on the hw_device. The Sysmon monitors the physical environment via<br/>
		/// on-chip temperature and supply sensors. The ADC provides a high-precision analog interface for<br/>
		/// a range of applications. The ADC can access up to 17 external analog input channels. Refer to<br/>
		/// UltraScale Architecture System Monitor User Guide (UG580), or 7 Series FPGAs and Zynq-7000 SoC<br/>
		/// XADC Dual 12-Bit 1 MSPS Analog-to-Digital Converter User Guide (UG480) for more information on<br/>
		/// a specific device architecture.<br/>
		/// The hw_sysmon data is stored in dedicated registers called status registers accessible through the<br/>
		/// hw_sysmon_reg object. The values of the system monitor registers can be returned by the<br/>
		/// get_hw_sysmon_reg command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Every device that supports the system monitor will automatically have one or more hw_sysmon<br/>
		/// objects created when refresh_hw_device is called. When the hw_sysmon object is created, it<br/>
		/// is assigned a property for all the temperature and voltage registers, as well as the control<br/>
		/// registers. On the hw_sysmon object, the values assigned to the temperature and voltage registers<br/>
		/// are already translated to Celsius/Fahrenheit and Voltage.<br/>
		/// Although you can use the get_hw_sysmon_reg command to access the hex values stored in<br/>
		/// registers of a system monitor, you can also retrieve values of certain registers as formatted<br/>
		/// properties of the hw_sysmon object. For example, the following code retrieves the<br/>
		/// TEMPERATURE property of the specified hw_sysmon object rather than directly accessing the<br/>
		/// hex value of the register:<br/>
		/// set opTemp [get_property TEMPERATURE [get_hw_sysmons]<br/>
		/// This command returns a list of hw_sysmon objects on the current or specified hw_device, or<br/>
		/// returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 787<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_sysmon' objects of these types: 'hw_server<br/>
		/// hw_target hw_device'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sysmon' objects against patterns. Default: *</param>
		/// <returns>hardware sysmons</returns>
		public TTCL get_hw_sysmons(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sysmons [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sysmons(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of hardware targets.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_targets [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the available hardware targets of the connected hardware servers.<br/>
		/// The hardware target is a system board containing a JTAG chain of one or more Xilinx devices that<br/>
		/// you can program with a bitstream file, or use to debug your design. Connections between<br/>
		/// hardware targets on the system board and the Vivado Design Suite are managed by the Xilinx<br/>
		/// hardware server application, and the connect_hw_server command. Refer to Vivado Design<br/>
		/// Suite User Guide: Programming and Debugging (UG908) for a list of supported JTAG download<br/>
		/// cables and devices.<br/>
		/// Use the open_hw_target command to open a connection to one of the available hardware<br/>
		/// targets. The open target is automatically defined as the current hardware target. Alternatively,<br/>
		/// you can define the current target with the current_hw_target command, and then open a<br/>
		/// connection to the current target. The Vivado Design Suite directs programming and debug<br/>
		/// commands to the open target through the hardware server connection.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns a list of available hardware targets through all connected hardware<br/>
		/// servers, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 791<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_target' objects of these types: 'hw_server'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_target' objects against patterns. Default: *</param>
		/// <returns>hardware targets</returns>
		public TTCL get_hw_targets(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_targets [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_targets(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of hardware VIOs.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_vios [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the Virtual Input/Output (VIO) debug core objects that are defined on the current<br/>
		/// hardware device, hw_device.<br/>
		/// The Virtual Input/Output (VIO) debug core can both monitor and drive internal signals on a<br/>
		/// programmed Xilinx FPGA in real time. In the absence of physical access to the target hardware,<br/>
		/// you can use this debug feature to drive and monitor signals that are present on the physical<br/>
		/// device.<br/>
		/// The VIO core has hardware probes, hw_probe objects, to monitor and drive specific signals on<br/>
		/// the design. Input probes monitor signals as inputs to the VIO core. Output probes drive signals to<br/>
		/// specified values from the VIO core. Values on the debug core are driven onto the signals at the<br/>
		/// probe using the commit_hw_vio command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The VIO debug core needs to be instantiated in the RTL code, therefore you need to know what<br/>
		/// nets you want monitor and drive prior to debugging the design. The IP catalog provides the VIO<br/>
		/// core under the Debug category. Detailed documentation on the VIO core can be found in the<br/>
		/// LogiCORE IP Virtual Input/Output Product Guide (PG159).<br/>
		/// This command returns a list of VIO debug core objects on the device, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 794<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_vio' objects of these types: 'hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_vio' objects against patterns. Default: *</param>
		/// <returns>hardware VIOs</returns>
		public TTCL get_hw_vios(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_vios [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_vios(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of I/O port interfaces in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_interfaces [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of IO interfaces in the current project that match a specified search pattern. The<br/>
		/// default command gets a list of all IO interfaces in the project.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of all interfaces in the project:<br/>
		/// get_interfaces<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 797<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get interfaces of these pins or nets</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match I/O port interfaces against patterns Default: *</param>
		/// <returns>list of interface objects</returns>
		public TTCL get_interfaces(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_interfaces [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_interfaces(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of IO standards.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_io_standards [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Get a list of IOSTANDARDs available for use on the target device.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of differential IOSTANDARDs available for use on the target<br/>
		/// device:<br/>
		/// get_io_standards -filter {IS_DIFFERENTIAL}<br/>
		/// Note: If there are no objects matching the pattern you will get a warning.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 800<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get the IO standards of these bels, sites, package_pins,<br/>
		/// io_banks, ports.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match IO standards against patterns Default: *</param>
		/// <returns>IO standards</returns>
		public TTCL get_io_standards(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_io_standards [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_io_standards(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of iobanks.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_iobanks [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of I/O Banks on the target device in the current project that match a specified search<br/>
		/// pattern. The default command gets a list of all I/O Banks on the target device.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the I/O Bank of the specified package pin:<br/>
		/// get_iobanks -of_objects [get_package_pins H4]<br/>
		/// This example returns the GT Banks on the device:<br/>
		/// get_iobanks -filter {BANK_TYPE == BT_MGT}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 803<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get the iobanks of these package_pins, ports, clock regions,<br/>
		/// slrs or sites.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match iobanks against patterns Default: *</param>
		/// <returns>iobanks</returns>
		public TTCL get_iobanks(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_iobanks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_iobanks(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of results for IP upgrades during the current project<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_ip_upgrade_results [-srcset &lt;arg&gt;] [-quiet] [-verbose] [&lt;objects&gt;...]
		/// <br/>
		/// <para>
		/// Returns the names of the upgrade_log files for the specified IPs.<br/>
		/// This command is used by the Vivado IDE to populate the IP Status Report window with<br/>
		/// information from the upgrade_log file. You can use the command to quickly obtain the<br/>
		/// upgrade_log file name, and then use the appropriate file commands, to read or display the<br/>
		/// contents.<br/>
		/// This command returns the upgrade_log file names of the specified IP objects, or returns an error<br/>
		/// if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 806<br/>
		/// </para>
		/// </summary>
		/// <param name="srcset">
		/// <para>
		/// (Optional)<br/>
		/// (Optional) Specifies the source file set containing the<br/>
		/// upgraded IP Default: The current source fileset Values:<br/>
		/// Source set name<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">
		/// <para>
		/// (Optional)<br/>
		/// IP to be upgraded Values: IP instance(s) within the design,<br/>
		/// as returned by 'get_ips &lt;instance name&gt;' or 'get_bd_cells<br/>
		/// &lt;cell name&gt;'<br/>
		/// </para>
		/// </param>
		/// <returns>list of IP upgrade results</returns>
		public TTCL get_ip_upgrade_results(String srcset = null, bool? quiet = null, bool? verbose = null, TCLParameterList objects = null)
		{
			// TCL Syntax: get_ip_upgrade_results [-srcset <arg>] [-quiet] [-verbose] [<objects>...]
			_tcl.Entry(_builder.get_ip_upgrade_results(srcset, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of IP from the current IP Catalog<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_ipdefs [-name] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-all] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Get a list of IP cores defined in the IP catalog of the current project, based on the specified<br/>
		/// search pattern. The default is to return all IP cores defined in the Vivado tools IP catalog.<br/>
		/// By default, the search is based on the VLNV property of the IP cores in the catalog. You can<br/>
		/// specify the -name option to search on the display name of IP cores instead.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns a list of all IP cores with NAME property matching the specified<br/>
		/// pattern:<br/>
		/// get_ipdefs -filter {NAME=~*agilent*}<br/>
		/// TIP: The filter operator '=~' loosely matches the specified pattern.<br/>
		/// The following example returns a list of all AXI compliant IP cores:<br/>
		/// get_ipdefs -filter {IS_AXI==1}<br/>
		/// The following example returns IP from both the Vivado tools standard IP catalog and the IP<br/>
		/// integrator IP catalog:<br/>
		/// get_ipdefs -all *axi_interconnect*<br/>
		/// The following example filters the above results with the DESIGN_TOOL_CONTEXTS property to<br/>
		/// return only the IP integrator IP:<br/>
		/// get_ipdefs -all *axi_interconnect* -filter {DESIGN_TOOL_CONTEXTS =~*IPI*}<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// TIP: By filtering on the DESIGN_TOOL_CONTEXTS property, you can identify IP from the IP integrator<br/>
		/// catalog instead of the Vivado tools standard catalog.<br/>
		/// In some cases, where multiple versions of an IP are returned, you can also filter on the<br/>
		/// UPGRADE_VERSIONS property to get as specific version or the latest IP version, as shown in the<br/>
		/// following example:<br/>
		/// get_ipdefs -all *axi_interconnect* -filter {UPGRADE_VERSIONS == ""}<br/>
		/// TIP: The {UPGRADE_VERSIONS == ""} filter returns IP defs that have no upgrade, and so are the latest<br/>
		/// version.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 808<br/>
		/// </para>
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
		/// <para>
		/// (Optional)<br/>
		/// The patterns to match against Default: * Values: The default<br/>
		/// search pattern is the wildcard *, or .* when -regexp is<br/>
		/// specified.<br/>
		/// </para>
		/// </param>
		/// <returns>List of Catalog IP objects</returns>
		public TTCL get_ipdefs(bool? name = null, bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? all = null, bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_ipdefs [-name] [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-all] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_ipdefs(name, regexp, nocase, filter, of_objects, all, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of IPs in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_ips [-regexp] [-nocase] [-all] [-filter &lt;arg&gt;] [-exclude_bd_ips] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Get a list of IP cores in the current project based on the specified search pattern. The default<br/>
		/// command returns a list of all IPs in the project.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns a list of IP cores with names beginning with the string "EDK":<br/>
		/// get_ips EDK*<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 812<br/>
		/// </para>
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
		/// <para>
		/// (Optional)<br/>
		/// Match IP names against patterns Default: * Values: The<br/>
		/// default search pattern is the wildcard *, or .* when -regexp<br/>
		/// is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of IP objects</returns>
		public TTCL get_ips(bool? regexp = null, bool? nocase = null, bool? all = null, String filter = null, bool? exclude_bd_ips = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_ips [-regexp] [-nocase] [-all] [-filter <arg>] [-exclude_bd_ips] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_ips(regexp, nocase, all, filter, exclude_bd_ips, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of Library Cells<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_lib_cells [-regexp] [-filter &lt;arg&gt;] [-nocase] [-include_unsupported] [-of_objects &lt;args&gt;] [-quiet] [-verbose] &lt;patterns&gt;
		/// <br/>
		/// <para>
		/// Get a list of cells in the library for the target part of the current design. Use this command to<br/>
		/// query and look for a specific library cell, or type of cell and to get the properties of the cells.<br/>
		/// This command requires a hierarchical name which includes the library name as well as the cell<br/>
		/// name: lib_name/cell_name.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the number of the cells in the library for the target part in the current<br/>
		/// design, and then gets the number of AND type cells in that library:<br/>
		/// llength [get_lib_cells [get_libs]/*]<br/>
		/// 795<br/>
		/// llength [get_lib_cells [get_libs]/AND*]<br/>
		/// 18<br/>
		/// The following example gets the library cell for the specified cell object:<br/>
		/// get_lib_cells -of_objects [lindex [get_cells] 1]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 815<br/>
		/// </para>
		/// </summary>
		/// <param name="patterns">(Required) Match library cell names against patterns.</param>
		/// <param name="regexp">(Optional) Patterns are regular expressions.</param>
		/// <param name="filter">(Optional) Filter list with expression.</param>
		/// <param name="nocase">
		/// <para>
		/// (Optional)<br/>
		/// Perform case-insensitive matching when a pattern has been<br/>
		/// specified. This argument applies to the use of -regexp only.<br/>
		/// </para>
		/// </param>
		/// <param name="include_unsupported">(Optional) Include test-only library cells.</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get the library cells of the objects passed in here. Valid<br/>
		/// objects are cells or instances (ie, get_cells), cell pins (ie,<br/>
		/// get_pins) and library pins (ie, get_lib_pins).<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of library cells</returns>
		public TTCL get_lib_cells(String patterns, bool? regexp = null, String filter = null, bool? nocase = null, bool? include_unsupported = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_lib_cells [-regexp] [-filter <arg>] [-nocase] [-include_unsupported] [-of_objects <args>] [-quiet] [-verbose] <patterns>
			_tcl.Entry(_builder.get_lib_cells(patterns, regexp, filter, nocase, include_unsupported, of_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of Library Cell Pins<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_lib_pins [-regexp] [-filter &lt;arg&gt;] [-nocase] [-of_objects &lt;args&gt;] [-quiet] [-verbose] &lt;patterns&gt;
		/// <br/>
		/// <para>
		/// Gets a list of the pins on a specified cell of the cell library for the target part in the current design.<br/>
		/// Note: This command requires a hierarchical name which includes the library name and cell name as well as<br/>
		/// the pins: lib_name/cell_name/pins.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of all library cell pins:<br/>
		/// get_lib_pins xt_virtex6/AND2/*<br/>
		/// The following example gets a list of all pins, of all cells in the cell library for the target device:<br/>
		/// get_lib_pins [get_libs]/*/*<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 818<br/>
		/// </para>
		/// </summary>
		/// <param name="patterns">
		/// <para>
		/// (Required)<br/>
		/// Match library cell pin names against patterns of the form<br/>
		/// &lt;library cell pattern&gt;/&lt;library pin pattern&gt;.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are regular expressions</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="nocase">
		/// <para>
		/// (Optional)<br/>
		/// Perform case-insensitive matching when a pattern has been<br/>
		/// specified. This argument applies to the use of -regexp only.<br/>
		/// </para>
		/// </param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get the library cell pins of the objects passed in here. Valid<br/>
		/// objects are cells or instances (ie, get_cells), cell pins (ie,<br/>
		/// get_pins) and library cells (ie get_lib_cells).<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of library cell pins</returns>
		public TTCL get_lib_pins(String patterns, bool? regexp = null, String filter = null, bool? nocase = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_lib_pins [-regexp] [-filter <arg>] [-nocase] [-of_objects <args>] [-quiet] [-verbose] <patterns>
			_tcl.Entry(_builder.get_lib_pins(patterns, regexp, filter, nocase, of_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of Libraries<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_libs [-regexp] [-filter &lt;arg&gt;] [-nocase] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets the cell library for the target device in the current design. There is a library for each device<br/>
		/// family because there are primitives that may be available in one device family but not in others.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the cell library for the target part:<br/>
		/// get_libs<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 821<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are regular expressions</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="nocase">
		/// <para>
		/// (Optional)<br/>
		/// Perform case-insensitive matching when a pattern has been<br/>
		/// specified. This argument applies to the use of -regexp only.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match library names against patterns. Default: *</param>
		/// <returns>list of libraries</returns>
		public TTCL get_libs(bool? regexp = null, String filter = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_libs [-regexp] [-filter <arg>] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_libs(regexp, filter, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of macros in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_macros [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of macros in the current design that match a specified search pattern. The default<br/>
		/// command returns a list of all macros in the design.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the properties currently assigned to the macro matching the<br/>
		/// specified search pattern:<br/>
		/// report_property [get_macro *Macro1]<br/>
		/// Note: If there are no macros matching the pattern you will get a warning.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 824<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get macros of these cells</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match macro names against patterns Default: *</param>
		/// <returns>list of macro objects</returns>
		public TTCL get_macros(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_macros [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_macros(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get marked objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_marked_objects [-rgb &lt;args&gt;] [-color &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Get the marked objects in the current design open in the Vivado IDE. Objects can be marked<br/>
		/// with the mark_objects command.<br/>
		/// You can get all marked objects in the design, or specify marked objects by color, or by RGB value.<br/>
		/// Note: This Tcl command works only when Vivado is run in GUI mode.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets all the marked objects in the current design:<br/>
		/// get_marked_objects<br/>
		/// The following example gets the object in the current design that are marked in the specified<br/>
		/// color:<br/>
		/// get_marked_objects -color yellow<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 827<br/>
		/// </para>
		/// </summary>
		/// <param name="rgb">(Optional) RGB color index list</param>
		/// <param name="color">(Optional) Valid values are red green blue magenta yellow cyan and orange</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of marked objects</returns>
		public TTCL get_marked_objects(TCLParameterList rgb = null, String color = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_marked_objects [-rgb <args>] [-color <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_marked_objects(rgb, color, quiet, verbose));
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
		/// Get a list of nets in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_nets [-hsc &lt;arg&gt;] [-hierarchical] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-match_style &lt;arg&gt;] [-top_net_of_hierarchical_group] [-segments] [-boundary_type &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of nets in the current design that match a specified search pattern. The default<br/>
		/// command gets a list of all nets in the current_instance of the open design, as specified by the<br/>
		/// current_instance command.<br/>
		/// You can use the -hierarchical option to extract nets from the hierarchy of the current<br/>
		/// design.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example runs the report_drc command on the current design, returns the list of<br/>
		/// violations in the specified DRC report, and then returns any nets associated with the driverless<br/>
		/// net rule (NDRV):<br/>
		/// report_drc -name drc_1<br/>
		/// get_drc_violations -name drc_1<br/>
		/// get_nets -of_objects [get_drc_violations -name drc_1 NDRV*]<br/>
		/// The following example returns a list of nets that have been marked for debug with the<br/>
		/// connect_debug_port command:<br/>
		/// get_nets -hier -filter {MARK_DEBUG==1}<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This example returns the net attached to the specified hierarchical pin object, then returns the<br/>
		/// net segments attached to the pin object, then returns the top-level net segment attached to the<br/>
		/// pin object:<br/>
		/// get_nets \<br/>
		/// -of [get_pins cpuEngine/or1200_cpu/or1200_sprs/esr_reg[9]_i_3/I0]<br/>
		/// get_nets -segments \<br/>
		/// -of [get_pins cpuEngine/or1200_cpu/or1200_sprs/esr_reg[9]_i_3/I0]<br/>
		/// get_nets -top -segments \<br/>
		/// -of [get_pins cpuEngine/or1200_cpu/or1200_sprs/esr_reg[9]_i_3/I0]<br/>
		/// In the following example, the first command applies the -filter to find nets that have the<br/>
		/// IS_INTERNAL property, and then -segment is applied to return the segments of those nets. This<br/>
		/// command returns 0 net segments (and a warning). The second command, returns the segments<br/>
		/// of all nets, and filters the results to find the segments that have the IS_INTERNAL property, of<br/>
		/// which there are 448:<br/>
		/// llength [get_nets -segments -filter {IS_INTERNAL}]<br/>
		/// WARNING: [Vivado 12-1023] No nets matched for command 'get_nets -segments<br/>
		/// -filter IS_INTERNAL'.<br/>
		/// 0<br/>
		/// llength [filter [get_nets -segments] {IS_INTERNAL}]<br/>
		/// 448<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 842<br/>
		/// </para>
		/// </summary>
		/// <param name="hsc">(Optional) Hierarchy separator Default: /</param>
		/// <param name="hierarchical">(Optional) Search level-by-level in current instance</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get nets of these pins, ports, cells, timing paths or clocks,<br/>
		/// drc violations<br/>
		/// </para>
		/// </param>
		/// <param name="match_style">(Optional) Style of pattern matching, valid values are ucf, sdc Default: sdc</param>
		/// <param name="top_net_of_hierarchical_group">
		/// <para>
		/// (Optional)<br/>
		/// Return net segment(s) which belong(s) to the high level of a<br/>
		/// hierarchical net<br/>
		/// </para>
		/// </param>
		/// <param name="segments">(Optional) Return all segments of a net across the hierarchy</param>
		/// <param name="boundary_type">
		/// <para>
		/// (Optional)<br/>
		/// Return net segment connected to a hierarchical pin which<br/>
		/// resides at the same level as the pin (upper) or at the level<br/>
		/// below (lower), or both. Valid values are : upper, lower, both<br/>
		/// Default: upper<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match net names against patterns Default: *</param>
		/// <returns>list of net objects</returns>
		public TTCL get_nets(String hsc = null, bool? hierarchical = null, bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, String match_style = null, bool? top_net_of_hierarchical_group = null, bool? segments = null, String boundary_type = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_nets [-hsc <arg>] [-hierarchical] [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-top_net_of_hierarchical_group] [-segments] [-boundary_type <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_nets(hsc, hierarchical, regexp, nocase, filter, of_objects, match_style, top_net_of_hierarchical_group, segments, boundary_type, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of nodes in the device.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_nodes [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-uphill] [-downhill] [-flyover] [-from &lt;args&gt;] [-to &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns a list of nodes on the device that match a specified search pattern in an open design.<br/>
		/// The default command gets a list of all nodes on the device.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the nodes associated with the specified tile:<br/>
		/// get_nodes -of_objects [get_tiles CLBLM_R_X11Y158]<br/>
		/// The following example returns the nodes downhill from the specified node:<br/>
		/// get_nodes -downhill -of_objects [get_nodes LIOB33_SING_X0Y199/IOB_PADOUT0]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 847<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'node' objects of these types: 'net tile node bel_pin<br/>
		/// site_pin wire pip speed_model'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="uphill">
		/// <para>
		/// (Optional)<br/>
		/// Get the nodes uphill (driver) from the site_pin, pip, node or<br/>
		/// tile(s) provided in the -of_objects.<br/>
		/// </para>
		/// </param>
		/// <param name="downhill">
		/// <para>
		/// (Optional)<br/>
		/// Get the nodes downhill (loads) from the site_pin, pip, node<br/>
		/// or tile(s) provided in the -of_objects.<br/>
		/// </para>
		/// </param>
		/// <param name="flyover">(Optional) Get the nodes that fly over the given tile(s).</param>
		/// <param name="from">
		/// <para>
		/// (Optional)<br/>
		/// -from &lt;pip/site pin&gt; Return the nodes beginning at this pip<br/>
		/// or site pin. May be used in combination with uphill. Default<br/>
		/// is downhill. -all is implied.<br/>
		/// </para>
		/// </param>
		/// <param name="to">
		/// <para>
		/// (Optional)<br/>
		/// -to &lt;pip/site pin&gt; Return the nodes ending at this wire or<br/>
		/// site pin. May be used in combination with uphill. Default is<br/>
		/// downhill. -all is implied.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'node' objects against patterns. Default: *</param>
		/// <returns>nodes</returns>
		public TTCL get_nodes(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? uphill = null, bool? downhill = null, bool? flyover = null, TCLParameterList from = null, TCLParameterList to = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_nodes [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-uphill] [-downhill] [-flyover] [-from <args>] [-to <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_nodes(of_objects, regexp, nocase, filter, uphill, downhill, flyover, from, to, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of package pins<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_package_pins [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of the pins on the selected package for the target device. The default command gets a<br/>
		/// list of all pins on the package.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of the package pins associated with the specified bytegroup of<br/>
		/// an UltraScale device:<br/>
		/// get_package_pins -of [get_pkgpin_bytegroups BANK44_BYTE0]<br/>
		/// The following example gets the number of clock capable (CC) pins on the package:<br/>
		/// llength [get_package_pins -filter {IS_CLK_CAPABLE==1}]<br/>
		/// Note: If there are no pins matching the pattern you will get a warning.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 855<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get the list of package pin objects of these sites, bels,<br/>
		/// iobanks, pkgpin_bytegroups, pkgpin_nibbles, or ports.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match list of package pin objects against patterns Default: *</param>
		/// <returns>list of package pin objects</returns>
		public TTCL get_package_pins(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_package_pins [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_package_pins(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of PartitionDefs<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_partition_defs [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// IMPORTANT! You must first define the project as a Partial Reconfiguration (PR) project by setting the<br/>
		/// PR_FLOW property on the project to TRUE, or by using the Tools → Enable Partial Reconfiguration<br/>
		/// command.<br/>
		/// Get a list of all Partition Definition (partitionDef) objects in the current design, or the<br/>
		/// partitionDefs that match a specified search pattern.<br/>
		/// The Partial Reconfiguration flow lets you create Partition Definitions (partitionDefs) from<br/>
		/// hierarchical cells in a design, and to specify reconfigurable modules (RMs) to be assigned to these<br/>
		/// partitionDefs to create a unique configurations of the design based on the combination of the<br/>
		/// core design and one or more RMs. The PR design flow requires the implementation of each PR<br/>
		/// configuration, resulting in partial bitstreams for the RMs, but complete bitstreams for each<br/>
		/// integrated configuration. Refer to the Vivado Design Suite User Guide: Dynamic Function eXchange<br/>
		/// (UG909) for more information.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns a list of partitionDef objects, or returns an error if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 860<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match partition definition names against patterns Default: *</param>
		/// <returns>list of PartitionDef objects</returns>
		public TTCL get_partition_defs(bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_partition_defs [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_partition_defs(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of parts available in the software<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_parts [-regexp] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of parts that match a specified search pattern. The default command gets a list of all<br/>
		/// parts.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of 7vx485t parts, speed grade -1:<br/>
		/// get_parts -filter {DEVICE =~ xc7vx485t* &amp;&amp; speed == -1}<br/>
		/// The following example gets the number of 7 series and 6 series Virtex parts:<br/>
		/// llength [get_parts -regexp {xc7v.* xc6V.*} -nocase]<br/>
		/// Note: If there are no parts matching the pattern, the tool will return a warning.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 863<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the parts of the objects specified: project, design, or run.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Match part names against patterns Default: * Values: The<br/>
		/// default search pattern is the wildcard *, or .* when -regexp<br/>
		/// is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>list of part objects</returns>
		public TTCL get_parts(bool? regexp = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_parts [-regexp] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_parts(regexp, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of path groups in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_path_groups [-regexp] [-nocase] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of timing path groups in the current project that match a specified search pattern. The<br/>
		/// default command gets a list of all path groups in the design.<br/>
		/// Path groups are automatically created when a new clock is created in the design, containing all<br/>
		/// paths in that clocks domain. Path groups can also be manually created with the use of the<br/>
		/// group_path command.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of all the path groups in the design.<br/>
		/// get_path_groups<br/>
		/// The following example gets all path groups with the string "Clk" somewhere in the name:<br/>
		/// get_path_groups *Clk*<br/>
		/// Note: If no path groups match the pattern you will get a warning.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 866<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match path group names against patterns Default: *</param>
		/// <returns>list of path groups</returns>
		public TTCL get_path_groups(bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_path_groups [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_path_groups(regexp, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of Pblocks in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_pblocks [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-include_nested_pblocks] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of Pblocks defined in the current project that match a specific pattern. The default<br/>
		/// command gets a list of all Pblocks in the project.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of all Pblocks in the current project:<br/>
		/// get_pblocks<br/>
		/// This example gets a list of all Pblocks which do not have a Slice Range defined:<br/>
		/// get_pblocks -filter {GRIDTYPES !~ SLICE}<br/>
		/// The following example gets the Pblock assignments of the specified cell:<br/>
		/// get_pblocks -of [get_cells CORE/BR_TOP/RLD67_MUX/REG_PMBIST_C1]<br/>
		/// This example returns the specified Pblock, including any nested Pblocks:<br/>
		/// get_pblocks -include_nested_pblocks usbTop<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 868<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get Pblocks of these cells</param>
		/// <param name="include_nested_pblocks">(Optional) Display the the list of nested pblocks</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match Pblock names against patterns Default: *</param>
		/// <returns>list of Pblock objects</returns>
		public TTCL get_pblocks(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? include_nested_pblocks = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_pblocks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-include_nested_pblocks] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pblocks(regexp, nocase, filter, of_objects, include_nested_pblocks, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of pins in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_pins [-hsc &lt;arg&gt;] [-hierarchical] [-regexp] [-nocase] [-leaf] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-match_style &lt;arg&gt;] [-include_replicated_objects] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of pin objects in the current design that match a specified search pattern. The default<br/>
		/// command gets a list of all pins in the current_instance of the open design, as specified by the<br/>
		/// current_instance command. You can use the -hierarchical option to extract pins from<br/>
		/// the hierarchy of the current design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// IMPORTANT! Because there are so many pins in the design, the get_pins command can cause<br/>
		/// performance issues, and add significant time to processing design constraints. In many cases, a design<br/>
		/// constraint that is written with the get_pins command can be rewritten using the get_cells<br/>
		/// command, as shown in the examples, to significantly improve constraint processing and performance of the<br/>
		/// Vivado tool.<br/>
		/// The get_pins command also includes an option to get all replicated pins that are added to a<br/>
		/// design during physical optimization, or phys_opt_design. The use of the -<br/>
		/// include_replicated_objects option returns the pins on replicated cells when the pins of<br/>
		/// an original cell are returned. You can use this option to ensure that constraints or properties that<br/>
		/// are applied to the pins of a cell are also applied to the pins of its replicated cells.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of pins attached to the specified cells:<br/>
		/// get_pins -of_objects [get_cells usb*]<br/>
		/// Note: If there are no pins matching the pattern, the tool will return a warning.<br/>
		/// This example shows how using get_cells can improve the performance of the get_pins<br/>
		/// command:<br/>
		/// [get_pins -hier * -filter {NAME=~xx*/yy*}]<br/>
		/// can be rewritten as:<br/>
		/// [get_pins -filter {REF_PIN_NAME=~yy*} -of [get_cells -hier xx*]]<br/>
		/// The following shows how rewriting the set_max_delay constraint can significantly improve<br/>
		/// performance:<br/>
		/// set_max_delay 15 -from [get_pins -hier \<br/>
		/// -filter name=~*/aclk_dpram_reg*/*/CLK] \<br/>
		/// -to [get_cells -hier -filter name=~*/bclk_dout_reg*] -datapath_only<br/>
		/// can be rewritten as:<br/>
		/// set_max_delay 15 -from [get_pins -of \<br/>
		/// [get_cells -hier -filter name=~*aclk_dpram_reg*/*] \<br/>
		/// -filter {REF_PIN_NAME == CLK}] \<br/>
		/// -to [get_pins -of [get_cells -hier -filter {name =~ */bclk_dout_reg*}]<br/>
		/// \<br/>
		/// -filter {REF_PIN_NAME == D}] -datapath_only<br/>
		/// TIP: Although the second command syntax is more complex, the performance gains can be significant.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This example runs the report_drc command on the current design, and then returns any pins<br/>
		/// associated with DRC violations:<br/>
		/// report_drc -name drc_1<br/>
		/// get_pins -of_objects [get_drc_violations]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 871<br/>
		/// </para>
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
		/// <para>
		/// (Optional)<br/>
		/// Include replicated objects when searching for patterns. This<br/>
		/// option is valid only when patterns is specified.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match pin names against patterns Default: *</param>
		/// <returns>list of pin objects</returns>
		public TTCL get_pins(String hsc = null, bool? hierarchical = null, bool? regexp = null, bool? nocase = null, bool? leaf = null, String filter = null, TCLParameterList of_objects = null, String match_style = null, bool? include_replicated_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_pins [-hsc <arg>] [-hierarchical] [-regexp] [-nocase] [-leaf] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-include_replicated_objects] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pins(hsc, hierarchical, regexp, nocase, leaf, filter, of_objects, match_style, include_replicated_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of programmable interconnect points (pips) on the current device.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_pips [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-uphill] [-downhill] [-from &lt;args&gt;] [-to &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Programmable interconnect points, or PIPs, provide the physical routing paths on the device used<br/>
		/// to connect logic networks. This command returns a list of PIPs on the device that match a<br/>
		/// specified search pattern. The command requires a design to be open.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The default command gets a list of all PIPs on the device. However, this is not a recommended<br/>
		/// use of the command due to the number of pips on a device. You should specify the -<br/>
		/// of_objects argument to limit the number of pips returned.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the PIPs associated with the specified tile:<br/>
		/// get_pips -of_object [get_tiles DSP_R_X9Y75]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 876<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the pips of these sites, tiles, wires, nodes, pips, or nets.</param>
		/// <param name="uphill">(Optional) Get the pips uphill from the provided wire or pip.</param>
		/// <param name="downhill">(Optional) Get the pips downhill from the provided wire or pip.</param>
		/// <param name="from">
		/// <para>
		/// (Optional)<br/>
		/// -from &lt;pip/site pin&gt; Return the ordered list of pips<br/>
		/// beginning at this pip or site pin. May be used in<br/>
		/// combination with uphill. Default is downhill. -all is implied.<br/>
		/// </para>
		/// </param>
		/// <param name="to">
		/// <para>
		/// (Optional)<br/>
		/// -to &lt;pip/site pin&gt; Return the ordered list of pips ending at<br/>
		/// this wire or site pin. May be used in combination with uphill.<br/>
		/// Default is downhill. -all is implied.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match pips against patterns Default: *</param>
		/// <returns>pips</returns>
		public TTCL get_pips(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? uphill = null, bool? downhill = null, TCLParameterList from = null, TCLParameterList to = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_pips [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-uphill] [-downhill] [-from <args>] [-to <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pips(regexp, nocase, filter, of_objects, uphill, downhill, from, to, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of package pin byte groups.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_pkgpin_bytegroups [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of the byte groups on the I/O banks of the current Xilinx UltraScale device.<br/>
		/// For 7 series devices, the hierarchy of IO Banks is divided into two object types: I/O Banks and<br/>
		/// Package Pins. For Xilinx UltraScale FPGA devices, the IO Bank hierarchy includes two additional<br/>
		/// divisions: Byte groups and Nibbles.<br/>
		/// The relationships of these objects on an UltraScale device are defined as follows:<br/>
		/// • An iobank has 2 or 4 bytegroups.<br/>
		/// • Each pkgpin_bytegroup has 2 nibbles, an upper and lower, and has 13 package pins.<br/>
		/// • Each pkgpin_nibble has 6 or 7 pins, and is the upper or lower nibble of the pkgpin_bytegroup.<br/>
		/// • A package_pin is one pin of an iobank, a pkgpin_bytegroup, or a pkgpin_nibble.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of all pins on the package of the target device:<br/>
		/// get_pkgpin_bytegroups -of [get_iobanks 44]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 880<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the pin_group of these package_pins, iobank, site, or port.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match pin_group against patterns Default: *</param>
		/// <returns>pin_group</returns>
		public TTCL get_pkgpin_bytegroups(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_pkgpin_bytegroups [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pkgpin_bytegroups(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of pkgpin nibbles.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_pkgpin_nibbles [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Return a list of nibbles, or half-bytes, on the I/O banks of the current Xilinx UltraScale device.<br/>
		/// For 7 series devices, the hierarchy of IO Banks is divided into two object types: I/O Banks and<br/>
		/// Package Pins. For Xilinx UltraScale FPGA devices, the IO Bank hierarchy includes two additional<br/>
		/// divisions: Byte groups and Nibbles.<br/>
		/// The relationships of these objects on an UltraScale device are defined as follows:<br/>
		/// • An iobank has 2 or 4 bytegroups.<br/>
		/// • Each pkgpin_bytegroup has 2 nibbles, an upper and lower, and has 13 package pins.<br/>
		/// • Each pkgpin_nibble has 6 or 7 pins, and is the upper or lower nibble of the pkgpin_bytegroup.<br/>
		/// • A package_pin is one pin of an iobank, a pkgpin_bytegroup, or a pkgpin_nibble.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the Upper nibbles associated with the specified IO bank:<br/>
		/// get_pkgpin_nibbles -of [get_iobanks 44] -filter {TYPE == U}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 883<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the pin_nibble of these package_pins, iobank, site, or port.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match pin_nibble against patterns Default: *</param>
		/// <returns>pin_nibble</returns>
		public TTCL get_pkgpin_nibbles(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_pkgpin_nibbles [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pkgpin_nibbles(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of ports in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_ports [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-match_style &lt;arg&gt;] [-scoped_to_current_instance] [-no_traverse] [-prop_thru_buffers] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of port objects in the current design that match a specified search pattern. The default<br/>
		/// command gets a list of all ports in the design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of pins attached to the specified cell:<br/>
		/// get_ports -of_objects [lindex [get_cells] 1]<br/>
		/// Note: If there are no ports matching the pattern, the tool will return a warning.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example runs the report_drc command on the current design, returns the list of<br/>
		/// violations in the specified DRC report, and then returns the ports associated with any violations<br/>
		/// of the unspecified I/O Standard rule (NSTD):<br/>
		/// report_drc -name drc_1<br/>
		/// get_drc_violations -name drc_1<br/>
		/// get_ports -of_objects [get_drc_violations -name drc_1 NSTD*]<br/>
		/// This example specifies a cell for the current instance, returns the pins scoped to the current<br/>
		/// instance, and returns the top-level ports connected to those pins:<br/>
		/// current_instance [get_cells dac_spi*]<br/>
		/// get_ports -scoped_to_current_instance<br/>
		/// get_ports -scoped_to_current_instance -prop_thru_buffers<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 886<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get ports of these nets, instances, sites, clocks, timing paths,<br/>
		/// io standards, io banks, package pins, drc violations<br/>
		/// </para>
		/// </param>
		/// <param name="match_style">(Optional) Style of pattern matching, valid values are ucf, sdc Default: sdc</param>
		/// <param name="scoped_to_current_instance">
		/// <para>
		/// (Optional)<br/>
		/// Match patterns on instance pins specified using current<br/>
		/// instance, and then find top level connected ports.<br/>
		/// </para>
		/// </param>
		/// <param name="no_traverse">(Optional) Do not traverse to find top level terminals.</param>
		/// <param name="prop_thru_buffers">
		/// <para>
		/// (Optional)<br/>
		/// Allow propagate through buffers when traversing to find<br/>
		/// top level terminals connected to pins of scoped instance.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match port names against patterns Default: *</param>
		/// <returns>list of port objects</returns>
		public TTCL get_ports(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, String match_style = null, bool? scoped_to_current_instance = null, bool? no_traverse = null, bool? prop_thru_buffers = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_ports [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-match_style <arg>] [-scoped_to_current_instance] [-no_traverse] [-prop_thru_buffers] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_ports(regexp, nocase, filter, of_objects, match_style, scoped_to_current_instance, no_traverse, prop_thru_buffers, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of partition configurations<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_pr_configurations [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Get a list of PR configuration objects in the current project.<br/>
		/// In the Partial Reconfiguration (PR) design flow, the PR configuration lets you specify a<br/>
		/// reconfigurable module (RM) to assign to a specific instance of a Partition Definition<br/>
		/// (partitionDef). This flow lets you create unique configurations of the design based on the<br/>
		/// combination of the core design and one or more RMs. The PR design flow requires the<br/>
		/// implementation of each PR configuration, resulting in partial bitstreams for the RMs, but<br/>
		/// complete bitstreams for each integrated configuration. Refer to the Vivado Design Suite User<br/>
		/// Guide: Dynamic Function eXchange (UG909) for more information.<br/>
		/// This command returns a list of PR configuration objects, or returns an error if the command fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 892<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match partition configuration names against patterns Default: *</param>
		/// <returns>list of Configuration objects</returns>
		public TTCL get_pr_configurations(bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_pr_configurations [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pr_configurations(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of available unisim primitives for a part<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_primitives [-regexp] [-nocase] [-filter &lt;arg&gt;] [-part &lt;arg&gt;] [-retarget] [-macro] [-hierarchy] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Get a list of all supported primitives for the specified device. This command can be used on an<br/>
		/// open elaborated, synthesized, or implemented design, in which case it will get the PART from the<br/>
		/// current design. You can also specify the -part option to return the primitives for any device.<br/>
		/// By default the command always returns native primitives that can be placed on the target part<br/>
		/// without modification. The -retarget, -macro, and -hierarchy options add additional<br/>
		/// primitives to the list returned.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the native primitives for the current part, and includes macro<br/>
		/// primitives:<br/>
		/// get_primitives -macro<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 895<br/>
		/// </para>
		/// </summary>
		/// <param name="patterns">(Required) Match primitive types against patterns Default: *</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="part">(Optional) Part to get primitives for</param>
		/// <param name="retarget">
		/// <para>
		/// (Optional)<br/>
		/// Include primitive types that will be automatically retargeted<br/>
		/// to the current (or specified) part<br/>
		/// </para>
		/// </param>
		/// <param name="macro">
		/// <para>
		/// (Optional)<br/>
		/// Include primitive types that always convert into more basic,<br/>
		/// natively supported primitives, such as logic gates<br/>
		/// </para>
		/// </param>
		/// <param name="hierarchy">
		/// <para>
		/// (Optional)<br/>
		/// Include primitive types that will be automatically expanded<br/>
		/// into a hierarchy of leaf cells during implementation<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>primitive types</returns>
		public TTCL get_primitives(String patterns, bool? regexp = null, bool? nocase = null, String filter = null, String part = null, bool? retarget = null, bool? macro = null, bool? hierarchy = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_primitives [-regexp] [-nocase] [-filter <arg>] [-part <arg>] [-retarget] [-macro] [-hierarchy] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_primitives(patterns, regexp, nocase, filter, part, retarget, macro, hierarchy, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of projects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_projects [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of open projects that match the specified search pattern. The default gets a list of all<br/>
		/// open projects.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of all open projects.<br/>
		/// get_projects<br/>
		/// The following example sets a variable called project_found to the length of the list of projects<br/>
		/// returned by get_projects, then prints either that projects were found or were not found as<br/>
		/// appropriate:<br/>
		/// set project_found [llength [get_projects ISC*] ]<br/>
		/// if {$project_found &gt; 0} {puts "Project Found."} \<br/>
		/// else {puts "No Projects Found."}<br/>
		/// Note: If there are no projects matching the pattern you will get a warning.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 898<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match project names against patterns Default: *</param>
		/// <returns>list of project objects</returns>
		public TTCL get_projects(bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_projects [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_projects(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get properties of object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_property [-min] [-max] [-quiet] [-verbose] &lt;name&gt; &lt;object&gt;
		/// <br/>
		/// <para>
		/// Gets the current value of the named property from the specified object or objects. If multiple<br/>
		/// objects are specified, a list of values is returned.<br/>
		/// If the property is not currently assigned to the object, or is assigned without a value, then the<br/>
		/// get_property command returns nothing, or the null string. If multiple objects are queried, the<br/>
		/// null string is added to the list of values returned.<br/>
		/// If multiple objects are passed to the get_property command, you can use the -min or -max<br/>
		/// options to return the smallest or greatest value of the property specified by name. This feature<br/>
		/// can be useful when setting timing constraints.<br/>
		/// RECOMMENDED: For numeric properties, the min/max determination is based on numeric values. For all<br/>
		/// other properties, the determination is based on string sorting.<br/>
		/// This command returns a value, or list of values, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the NAME property from the specified cell:<br/>
		/// get_property NAME [lindex [get_cells] 3]<br/>
		/// The following example returns the smallest PERIOD property from the specified clock objects:<br/>
		/// get_property -min PERIOD [get_clocks]<br/>
		/// This example demonstrates the string based sorting of the SITE property for the specified ports:<br/>
		/// get_property SITE [get_ports]<br/>
		/// IOB_X1Y75 IOB_X1Y76 IOB_X1Y98 IOB_X1Y125 IOB_X0Y94 IOB_X1Y95 IOB_X1Y96<br/>
		/// IOB_X1Y93 IOB_X1Y94<br/>
		/// get_property -min SITE [get_ports]<br/>
		/// IOB_X0Y94<br/>
		/// get_property -max SITE [get_ports]<br/>
		/// IOB_X1Y98<br/>
		/// Note: While IOB_X1Y125 is the largest site value on the port objects, the property value IOB_X1Y98 is<br/>
		/// returned because of the sorting of the property values as strings.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 901<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of property whose value is to be retrieved</param>
		/// <param name="object">(Required) Object to query for properties</param>
		/// <param name="min">(Optional) Return only the minimum value</param>
		/// <param name="max">(Optional) Return only the maximum value</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>property value</returns>
		public TTCL get_property(String name, String @object, bool? min = null, bool? max = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_property [-min] [-max] [-quiet] [-verbose] <name> <object>
			_tcl.Entry(_builder.get_property(name, @object, min, max, quiet, verbose));
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
		/// Get a list of ReconfigModules<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_reconfig_modules [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Get a list of reconfigurable modules (RMs) in the current design that match a specified search<br/>
		/// pattern. The default command returns a list of all RMs in the current project.<br/>
		/// This command returns a list of RM objects, or returns an error if the command fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 906<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'reconfig_module' objects of these types: 'partition_def'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match reconfigurable module names against patterns Default: *</param>
		/// <returns>list of ReconfigModule objects</returns>
		public TTCL get_reconfig_modules(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_reconfig_modules [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_reconfig_modules(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
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
		/// Get a list of runs<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_runs [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of synthesis and implementation runs in the current project that match a specified<br/>
		/// search pattern. The default command gets a list of all runs defined in the project.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of all incomplete runs in the current project:<br/>
		/// get_runs -filter {PROGRESS &lt; 100}<br/>
		/// The following example gets a list of runs matching the specified pattern:<br/>
		/// get_runs imp*<br/>
		/// Note: If there are no runs matching the pattern you will get a warning.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 912<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'run' objects of these types: 'reconfig_module'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match run names against patterns Default: *</param>
		/// <returns>list of run objects</returns>
		public TTCL get_runs(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_runs [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_runs(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get selected objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_selected_objects [-primary] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Gets the objects currently selected in the Vivado IDE by the select_objects command. Can<br/>
		/// get the primary selected object and any secondary selected objects as well.<br/>
		/// Note: This Tcl command works only when Vivado is run in GUI mode.<br/>
		/// Primary objects are directly selected, while secondary objects are selected based on the selection<br/>
		/// rules currently defined by the Tools → Settings command. Refer to the Vivado Design Suite User<br/>
		/// Guide: Using the IDE (UG893) for more information on setting selection rules.<br/>
		/// This command returns a Tcl list of selected objects, even a list with just one object. This can be an<br/>
		/// issue for some of the Vivado tool commands that do not accept a list of objects, such as the<br/>
		/// current_instance command. In this case you can use lindex to pass a specific object from<br/>
		/// the get_selected_objects list to the current_instance command:<br/>
		/// current_instance [lindex [get_selected_objects] 0]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the properties of all currently selected objects, both primary and<br/>
		/// secondary:<br/>
		/// report_property [get_selected_objects]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 918<br/>
		/// </para>
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
		/// <para>
		/// Get a list of site_pins.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_site_pins [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns a list of site pins of the specified site, node, logical cell pin, or net objects in an open<br/>
		/// design.<br/>
		/// This command recommends the use of the -of_objects argument to prevent high run times<br/>
		/// and compute resources.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the site_pins of the specified Nets:<br/>
		/// get_site_pins -of_objects [get_nets *Clk]<br/>
		/// IOB_X1Y24/I<br/>
		/// The following example returns the output site_pins associated with the site SLICE_X21Y92:<br/>
		/// get_site_pins -of_objects [get_sites SLICE_X21Y92] -filter<br/>
		/// {DIRECTION==OUT}<br/>
		/// SLICE_X21Y92/A SLICE_X21Y92/AMUX SLICE_X21Y92/AQ<br/>
		/// SLICE_X21Y92/B SLICE_X21Y92/BMUX SLICE_X21Y92/BQ<br/>
		/// SLICE_X21Y92/C SLICE_X21Y92/CMUX SLICE_X21Y92/COUT<br/>
		/// SLICE_X21Y92/CQ SLICE_X21Y92/D SLICE_X21Y92/DMUX<br/>
		/// SLICE_X21Y92/DQ<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 923<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'site_pin' objects of these types: 'site xdef_site node pin<br/>
		/// net bel_pin'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'site_pin' objects against patterns. Default: *</param>
		/// <returns>site_pins</returns>
		public TTCL get_site_pins(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_site_pins [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_site_pins(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of site_pips from the given object.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_site_pips [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Programmable interconnect points, or PIPs, provide the physical routing paths on the device used<br/>
		/// to connect logic networks. This command returns a list of PIPs on specified sites that match a<br/>
		/// specified search pattern. The command requires a design to be open.<br/>
		/// This command requires the use of the -of_objects option to specify the sites to return PIPs<br/>
		/// from.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the pins of the specified BELs associated with the specified range<br/>
		/// of sites on the device:<br/>
		/// get_site_pips -of_objects [get_sites SLICE_X21Y92]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 926<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the site_pips of these sites.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match site_pips against patterns Default: *</param>
		/// <returns>site_pips</returns>
		public TTCL get_site_pips(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_site_pips [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_site_pips(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of Sites<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_sites [-regexp] [-filter &lt;arg&gt;] [-nocase] [-range &lt;args&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of sites on the target device that match a specified search pattern. The default<br/>
		/// command gets a list of all sites on the target device.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of all sites available on the target device:<br/>
		/// get_sites<br/>
		/// The following example returns the number of sites that are not currently used on the device.<br/>
		/// Both command forms in the example return the same results. The second command directly<br/>
		/// evaluates the IS_USED boolean property:<br/>
		/// llength [get_sites -filter {IS_USED==0}]<br/>
		/// -or-<br/>
		/// llength [get_sites -filter !IS_USED]<br/>
		/// Note: If no sites match the pattern you will get a warning.<br/>
		/// The following example gets all of the sites on the device, and returns the unique SITE_TYPEs:<br/>
		/// set sites [get_sites]<br/>
		/// set type {}<br/>
		/// foreach x $sites {<br/>
		/// set prop [get_property SITE_TYPE $x]<br/>
		/// if { [lsearch -exact $type $prop] == -1 } {<br/>
		/// lappend type $prop<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// }<br/>
		/// }<br/>
		/// foreach y $type {<br/>
		/// puts "SITE_TYPE: $y"<br/>
		/// }<br/>
		/// The following example shows three different forms for specifying the range of sites to return:<br/>
		/// get_sites -range {SLICE_X0Y0 SLICE_X1Y1}<br/>
		/// SLICE_X0Y0 SLICE_X0Y1 SLICE_X1Y0 SLICE_X1Y1<br/>
		/// get_sites -range SLICE_X0Y0 -range SLICE_X1Y1<br/>
		/// SLICE_X0Y0 SLICE_X0Y1 SLICE_X1Y0 SLICE_X1Y1<br/>
		/// get_sites -range {SLICE_X0Y0:SLICE_X1Y1}<br/>
		/// SLICE_X0Y0 SLICE_X0Y1 SLICE_X1Y0 SLICE_X1Y1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 929<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="range">
		/// <para>
		/// (Optional)<br/>
		/// Match site names which fall into the range. Range is defined<br/>
		/// by exactly two site names.<br/>
		/// </para>
		/// </param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get the sites of slrs, tiles, bels, pins, package_pins, ports,<br/>
		/// pblocks, nets, site_types, io_banks, cells, clock_regions or<br/>
		/// drc_violation<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Match site names against patterns. Bonded sites will also<br/>
		/// match on package pin names. Default: *<br/>
		/// </para>
		/// </param>
		/// <returns>list of site objects</returns>
		public TTCL get_sites(bool? regexp = null, String filter = null, bool? nocase = null, TCLParameterList range = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_sites [-regexp] [-filter <arg>] [-nocase] [-range <args>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_sites(regexp, filter, nocase, range, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of slrs.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_slrs [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Get a list of the super logic regions (SLRs) on the target device. On Devices that do not contain<br/>
		/// multiple SLRs, the SLR0 is returned.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example highlights each of the SLRs on the target device in a different color:<br/>
		/// foreach x [get_slrs] {<br/>
		/// incr i<br/>
		/// highlight_objects -color_index $i $x<br/>
		/// }<br/>
		/// Note: If there are no cells matching the pattern you will get a warning.<br/>
		/// The following example returns the number of super long lines (SLLs) between super logic regions<br/>
		/// on the current device:<br/>
		/// get_property NUM_SLLS [get_slrs SLR0]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 933<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get the slr of these device, tiles, sites, bels, sitepins, belpins,<br/>
		/// clock region, node, pip, pin, package pin, iobank, cell.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match slr against patterns Default: *</param>
		/// <returns>slr</returns>
		public TTCL get_slrs(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_slrs [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_slrs(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of speed_models in the device.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_speed_models [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-patterns &lt;arg&gt;] [-filter &lt;arg&gt;] [-speed_pattern &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Get speed models for UltraScale architecture device resources in the current design.<br/>
		/// Speed files are provided by Xilinx for each device and speed grade. Speed files contain speed<br/>
		/// models. There are speed models for the various elements of a device: nodes, pips, bels. There are<br/>
		/// speed models for setup and hold, propagation delays, jitter, etc.<br/>
		/// The speed models include information on the delays in nanoseconds (ns) associated with device<br/>
		/// resources like BELs and SITEs and routing resources. Speed models are used by the Vivado<br/>
		/// timing engine to perform analysis of the current design in the context of the target part.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The objects returned are the speed models associated with specific physical resources like pips<br/>
		/// and wires, drawn directly from the speed files. These can include capacitance and resistance<br/>
		/// values and buffer models.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// This command returns the specified speed model objects, or returns an error if the command<br/>
		/// fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the properties on the speed model for an A6LUT:<br/>
		/// report_property -all [lindex [get_speed_models -of \<br/>
		/// [get_bels SLICE_X0Y0/A6LUT]] 0]<br/>
		/// Property Type Read-only Value<br/>
		/// CLASS string true speed_model<br/>
		/// DELAY double true 0.043<br/>
		/// FAST_MAX double true 0.035<br/>
		/// FAST_MIN double true 0.028<br/>
		/// IS_INSTANCE_SPECIFIC bool true 1<br/>
		/// NAME string true bel_d_lut6_a1_o6<br/>
		/// NAME_LOGICAL string true bel_d_lut6_a1_o6<br/>
		/// SLOW_MAX double true 0.043<br/>
		/// SLOW_MIN double true 0.036<br/>
		/// SPEED_INDEX int true 65535<br/>
		/// TYPE string true bel_delay<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example returns the delays, in nanoseconds, for a specific A6LUT on the device,<br/>
		/// followed by the delay name for the specified object:<br/>
		/// set x [get_speed_models -of [get_bels SLICE_X0Y0/A6LUT]]<br/>
		/// puts [format "%6.3f : %s" [get_property DELAY [lindex $x 0 ]] \<br/>
		/// [get_property NAME [lindex $x 0 ]]]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 936<br/>
		/// </para>
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
		public TTCL get_speed_models(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String patterns = null, String filter = null, String speed_pattern = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_speed_models [-of_objects <args>] [-regexp] [-nocase] [-patterns <arg>] [-filter <arg>] [-speed_pattern <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_speed_models(of_objects, regexp, nocase, patterns, filter, speed_pattern, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of tiles.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_tiles [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// This command returns a list of tiles on the device in an open design. The default command gets a<br/>
		/// list of all tiles on the device.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the total number of tiles where the number of timing arcs is<br/>
		/// greater than 100 and 150 respectively:<br/>
		/// llength [get_tiles -filter {NUM_ARCS&gt;100} ]<br/>
		/// 13468<br/>
		/// llength [get_tiles -filter {NUM_ARCS&gt;150} ]<br/>
		/// 11691<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 943<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get the tiles of these slr, sites, bels, site_pins, bel_pins,<br/>
		/// nodes, wires, pips, nets, clock_regions.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match tiles against patterns Default: *</param>
		/// <returns>tiles</returns>
		public TTCL get_tiles(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_tiles [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_tiles(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
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
		/// Get one or more DRC/METHODOLOGY/CDC message waivers<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_waivers [-type &lt;arg&gt;] [-id &lt;arg&gt;] [-of_objects &lt;args&gt;] [-regexp] [-filter &lt;arg&gt;] [-nocase] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// The create_waiver command lets you select individual DRC, methodology, or CDC violations<br/>
		/// or rule checks that can be waived for a design, letting you move forward in the design flow. The<br/>
		/// get_waivers command lets you query the defined waiver objects in the current design.<br/>
		/// A waiver must be specified for an individual DRC or methodology violation, or for a specific DRC<br/>
		/// or methodology check, or for a CDC path. The waiver must be assigned to a specific object, or<br/>
		/// specific violation ID, or for paths using -from/-to arguments. You can format the<br/>
		/// get_waivers command to return the specific types of waivers you are looking for, or waivers<br/>
		/// associated with specific objects.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// You can report the waivers defined in the current design with report_waivers, and remove<br/>
		/// waivers from the design using delete_waivers.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example gets any waivers in the current design:<br/>
		/// get_waivers<br/>
		/// The following example gets all DRC check waivers:<br/>
		/// get_waivers -type DRC *<br/>
		/// The following example gets all waivers associated with the specified objects:<br/>
		/// get_waivers -of_objects [get_ports {src_in* dest_out*}]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 957<br/>
		/// </para>
		/// </summary>
		/// <param name="type">(Optional) Type of waiver - DRC, METHODOLOGY, CDC, ALL</param>
		/// <param name="id">(Optional) ID of the DRC/METHODOLOGY/CDC message being waived</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// List of objects (cells, nets, pins, sites, etc.) for which DRC/<br/>
		/// METHODLOGY/CDC waiver(s) were set<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Match waiver names against patterns Default: * Values: The<br/>
		/// default search pattern is the wildcard *, or .* when -regexp<br/>
		/// is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>waivers</returns>
		public TTCL get_waivers(String type = null, String id = null, TCLParameterList of_objects = null, bool? regexp = null, String filter = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_waivers [-type <arg>] [-id <arg>] [-of_objects <args>] [-regexp] [-filter <arg>] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_waivers(type, id, of_objects, regexp, filter, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of wires.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_wires [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-uphill] [-downhill] [-from &lt;args&gt;] [-to &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns a list of wires in the design that match a specified search pattern in an open design.<br/>
		/// The default command gets a list of all wires in the design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the wires associated with the specified tile:<br/>
		/// get_wires -of_objects [get_tiles IO_INT_INTERFACE_L_X0Y198]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 964<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get the wires of these tiles, nodes, pips, or nets.</param>
		/// <param name="uphill">(Optional) Get the wires uphill from the provided pip.</param>
		/// <param name="downhill">(Optional) Get the wires downhill from the provided pip.</param>
		/// <param name="from">
		/// <para>
		/// (Optional)<br/>
		/// -from &lt;pip/site pin&gt; Return the ordered list of wires<br/>
		/// beginning at this pip or site pin. May be used in<br/>
		/// combination with uphill. Default is downhill. -all is implied.<br/>
		/// </para>
		/// </param>
		/// <param name="to">
		/// <para>
		/// (Optional)<br/>
		/// -to &lt;pip/site pin&gt; Return the ordered list of wires ending at<br/>
		/// this wire or site pin. May be used in combination with uphill.<br/>
		/// Default is downhill. -all is implied.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match wires against patterns Default: *</param>
		/// <returns>wires</returns>
		public TTCL get_wires(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? uphill = null, bool? downhill = null, TCLParameterList from = null, TCLParameterList to = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_wires [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-uphill] [-downhill] [-from <args>] [-to <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_wires(regexp, nocase, filter, of_objects, uphill, downhill, from, to, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Return probe sample values<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: list_hw_samples [-quiet] [-verbose] [&lt;hw_probe&gt;]
		/// <br/>
		/// <para>
		/// Writes data samples from the specified hw_probe object on the current hw_ila.<br/>
		/// The number of captured samples returned from the specified probe is equal to the DATA_DEPTH<br/>
		/// property of the ILA core. The default data depth is 1024 samples. Data values are returned in the<br/>
		/// radix specified for the hw_probe, as determined by the DISPLAY_RADIX property.<br/>
		/// TIP: For any samples to be returned, data must have been captured by the specified port.<br/>
		/// The values are listed to the standard output, or can be captured to a Tcl variable for post-processing, or output to a file.<br/>
		/// The following is an example Tcl script that lists the data samples from hw_probes of interest:<br/>
		/// # Define a list of probes to get the data samples from<br/>
		/// set probeList [get_hw_probes *AR*]<br/>
		/// #Specify the radix for the return values<br/>
		/// set_property DISPLAY_RADIX BINARY [get_hw_probes *AR*]<br/>
		/// # Define a filename to write data to<br/>
		/// set fileName C:/Data/probeData1.txt<br/>
		/// # Open the specified file in write mode<br/>
		/// set FH [open $fileName w]<br/>
		/// # Write probe data for each probe<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// foreach x $probeList {<br/>
		/// puts $FH "$x:"<br/>
		/// puts $FH [list_hw_samples $x]<br/>
		/// }<br/>
		/// # Close the output file<br/>
		/// close $FH<br/>
		/// puts "Probe data written to $fileName\n"<br/>
		/// This command returns the requested output, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the data samples for the specified probe:<br/>
		/// list_hw_samples [get_hw_probes *probe18]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1030<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_probe">(Optional) hw_probe object</param>
		/// <returns>samples</returns>
		public TTCL list_hw_samples(bool? quiet = null, bool? verbose = null, String hw_probe = null)
		{
			// TCL Syntax: list_hw_samples [-quiet] [-verbose] [<hw_probe>]
			_tcl.Entry(_builder.list_hw_samples(quiet, verbose, hw_probe));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// List properties of object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: list_property [-class &lt;arg&gt;] [-regexp] [-quiet] [-verbose] [&lt;object&gt;] [&lt;pattern&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of all properties on a specified object or class.<br/>
		/// Note: report_property also returns a list of properties on an object or class of objects, but also reports<br/>
		/// the property type and property value.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns all properties of the specified CELL object:<br/>
		/// list_property [get_cells cpuEngine]<br/>
		/// The following example returns the properties matching the specified search pattern from the BEL<br/>
		/// class of objects:<br/>
		/// list_property -class bel *NUM*<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1034<br/>
		/// </para>
		/// </summary>
		/// <param name="class">(Optional) Object type to query for properties. Ignored if object is specified.</param>
		/// <param name="regexp">(Optional) Pattern is treated as a regular expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="object">(Optional) Object to query for properties</param>
		/// <param name="pattern">(Optional) Pattern to match properties against Default: *</param>
		/// <returns>list of property names</returns>
		public TTCL list_property(String @class = null, bool? regexp = null, bool? quiet = null, bool? verbose = null, String @object = null, String pattern = null)
		{
			// TCL Syntax: list_property [-class <arg>] [-regexp] [-quiet] [-verbose] [<object>] [<pattern>]
			_tcl.Entry(_builder.list_property(@class, regexp, quiet, verbose, @object, pattern));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// List legal property values of object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: list_property_value [-default] [-class &lt;arg&gt;] [-quiet] [-verbose] &lt;name&gt; [&lt;object&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of valid values for an enumerated type property of either a class of objects or a<br/>
		/// specific object.<br/>
		/// Note: The command cannot be used to return valid values for properties other than Enum properties. The<br/>
		/// report_property command will return the type of property to help you identify Enum properties.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the list of valid values for the KEEP_HIERARCHY property from<br/>
		/// cell objects:<br/>
		/// list_property_value KEEP_HIERARCHY -class cell<br/>
		/// The following example returns the same result, but uses an actual cell object in place of the<br/>
		/// general cell class:<br/>
		/// list_property_value KEEP_HIERARCHY [get_cells cpuEngine]<br/>
		/// The following example returns the default value for the specified property by using the current<br/>
		/// design as a representative of the design class:<br/>
		/// list_property_value -default BITSTREAM.GENERAL.COMPRESS [current_design]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1036<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of property whose legal values is to be retrieved</param>
		/// <param name="default">(Optional) Show only the default value.</param>
		/// <param name="class">
		/// <para>
		/// (Optional)<br/>
		/// Object type to query for legal property values. Ignored if<br/>
		/// object is specified.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="object">(Optional) Object to query for legal properties values</param>
		/// <returns>list of property values</returns>
		public TTCL list_property_value(String name, bool? @default = null, String @class = null, bool? quiet = null, bool? verbose = null, String @object = null)
		{
			// TCL Syntax: list_property_value [-default] [-class <arg>] [-quiet] [-verbose] <name> [<object>]
			_tcl.Entry(_builder.list_property_value(name, @default, @class, quiet, verbose, @object));
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
		public TTCL remove_drc_checks(String ruledeck, TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: remove_drc_checks [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] -ruledeck <arg> [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.remove_drc_checks(ruledeck, of_objects, regexp, nocase, filter, quiet, verbose, patterns));
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
		public TTCL reset_drc_check(TCLParameterList checks, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_drc_check [-quiet] [-verbose] [<checks>...]
			_tcl.Entry(_builder.reset_drc_check(checks, quiet, verbose));
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
		/// <summary>
		/// <para>
		/// Reset property on object(s)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_property [-quiet] [-verbose] &lt;property_name&gt; &lt;objects&gt;...
		/// <br/>
		/// <para>
		/// Restores the specified property to its default value on the specified object or objects. If no<br/>
		/// default is defined for the property, the property is unassigned on the specified object.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets the DOB_REG property on the specified Block RAM, and then resets<br/>
		/// the property:<br/>
		/// set_property DOB_REG 1 [get_cells usbEngine1/usbEngineSRAM/<br/>
		/// snoopyRam_reg_19]<br/>
		/// reset_property DOB_REG [get_cells usbEngine1/usbEngineSRAM/snoopyRam_reg_19]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1511<br/>
		/// </para>
		/// </summary>
		/// <param name="property_name">(Required) Name of property to reset</param>
		/// <param name="objects">(Required) Objects to set properties</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The value that was set if success, "" if failure</returns>
		public TTCL reset_property(String property_name, TCLParameterList objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_property [-quiet] [-verbose] <property_name> <objects>...
			_tcl.Entry(_builder.reset_property(property_name, objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// change to a stable state of a specified transition<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: run_state_hw_jtag [-state &lt;args&gt;] [-quiet] [-verbose] &lt;stable_state&gt;
		/// <br/>
		/// <para>
		/// Transition the hw_jtag object of the current hardware target to the specified TAP stable state.<br/>
		/// A hw_jtag object is created by the Hardware Manager feature of the Vivado Design Suite when a<br/>
		/// hardware target is opened in JTAG mode using the open_hw_target -jtag_mode command.<br/>
		/// The run_state_hw_jtag command specifies:<br/>
		/// • An ending or target TAP stable state to transition to.<br/>
		/// • An optional state path list to transition through to get from the current state to the target<br/>
		/// state.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// If an optional -state path list is defined, then the state list must contain all states needed to<br/>
		/// reach the stable state, or the command will return an error. If no state path list is defined, then<br/>
		/// the command will transition from the current state to the target state according to the state<br/>
		/// transition paths defined in the following table:<br/>
		/// Current Target State Transition Path<br/>
		/// State State<br/>
		/// DRPAUSE RESET DRPAUSE -&gt; DREXIT2 -&gt; DRUPDATE -&gt; DRSELECT -&gt;<br/>
		/// IRSELECT-&gt; RESET<br/>
		/// DRPAUSE IDLE DRPAUSE -&gt; DREXIT2 -&gt; DRUPDATE -&gt; IDLE<br/>
		/// DRPAUSE DRPAUSE DRPAUSE -&gt; DREXIT2 -&gt; DRUPDATE -&gt; DRSELECT -&gt;<br/>
		/// DRCAPTURE -&gt; DREXIT1 -&gt; DRPAUSE<br/>
		/// DRPAUSE IRPAUSE DRPAUSE -&gt; DREXIT2 -&gt; DRUPDATE -&gt; DRSELECT -&gt;<br/>
		/// IRSELECT -&gt; IRCAPTURE -&gt; IREXIT12 -&gt; IRPAUSE<br/>
		/// IDLE RESET IDLE -&gt; DRSELECT -&gt; IRSELECT -&gt; RESET<br/>
		/// IDLE IDLE IDLE<br/>
		/// IDLE DRPAUSE IDLE -&gt; DRSELECT -&gt; DRCAPTURE -&gt; DREXIT1 -&gt;<br/>
		/// DRPAUSE<br/>
		/// IDLE IRPAUSE IDLE -&gt; DRPAUSE -&gt; IRSELECT -&gt;IRCAPTURE -&gt;<br/>
		/// IREXIT1 -&gt; IRPAUSE<br/>
		/// IRPAUSE RESET IRPAUSE -&gt; IREXIT2 -&gt; IRUPDATE -&gt; DRSELECT -&gt;<br/>
		/// IRSELECT -&gt; RESET<br/>
		/// IRPAUSE IDLE IRPAUSE -&gt; IREXIT2 -&gt; IRUPDATE -&gt; IDLE<br/>
		/// IRPAUSE DRPAUSE IRPAUSE -&gt; IREXIT2 -&gt; IRUPDATE -&gt; DRSELECT -&gt;<br/>
		/// DRCAPTURE -&gt; DREXIT1 -&gt; DRPAUSE<br/>
		/// IRPAUSE IRPAUSE IRPAUSE -&gt; IREXIT2 -&gt; IRUPDATE -&gt; DRSELECT -&gt;<br/>
		/// IRSELECT -&gt; IRCAPTURE -&gt; IREXIT1 -&gt; IRPAUSE<br/>
		/// RESET RESET RESET<br/>
		/// RESET IDLE RESET -&gt; IDLE<br/>
		/// RESET DRPAUSE RESET -&gt; IDLE -&gt; DRSELECT -&gt; DRCAPTURE -&gt;<br/>
		/// DREXIT1 -&gt; DRPAUSE<br/>
		/// RESET IRPAUSE RESET -&gt; IDLE -&gt; DRSELECT -&gt; IRSELECT -&gt;<br/>
		/// IRCAPTURE -&gt; IREXIT1 -&gt; IRPAUSE<br/>
		/// This command returns the target stable state when successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1561<br/>
		/// </para>
		/// </summary>
		/// <param name="stable_state">
		/// <para>
		/// (Required)<br/>
		/// valid stable_state - valid stable states IDLE, RESET, IRPAUSE,<br/>
		/// and DRPAUSE<br/>
		/// </para>
		/// </param>
		/// <param name="state">(Optional) valid state path sequence to stable_state</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>hardware JTAG</returns>
		public TTCL run_state_hw_jtag(String stable_state, TCLParameterList state = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: run_state_hw_jtag [-state <args>] [-quiet] [-verbose] <stable_state>
			_tcl.Entry(_builder.run_state_hw_jtag(stable_state, state, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Forces IEEE 1149.1 TAP state machine to a stable state for a specified wait period<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: runtest_hw_jtag [-wait_state &lt;arg&gt;] [-end_state &lt;arg&gt;] [-sec &lt;arg&gt;] [-max_wait &lt;arg&gt;] [-tck &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Specify a wait operation for the hw_jtag object state machine which defines:<br/>
		/// • Which TAP stable state to go to perform the wait operation.<br/>
		/// • A wait time expressed as:<br/>
		/// ○ 'n' TCK cycles, where 'n' is a 32-bit unsigned decimal number.<br/>
		/// ○ A minimum and optionally maximum time in seconds to stay in the wait state, with<br/>
		/// min/max times specified as unsigned integers or real numbers.<br/>
		/// • The TAP stable state to go after the wait operation has completed.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The default values for -wait_state and -end_state are IDLE. If a non-IDLE wait_state or<br/>
		/// end_state are defined, then the hw_jtag object will first transition to the specified wait_state<br/>
		/// before starting the wait operation. Once the wait time has elapsed, the hw_jtag object transitions<br/>
		/// to the specified end_state. When the wait_state and/or end_state are specified by the<br/>
		/// runtest_hw_jtag command, subsequent commands will use the same wait_state/end_state<br/>
		/// unless they are changed.<br/>
		/// This command returns the end stable state, or returns an error if it fails.<br/>
		/// Note: If the command cannot meet the wait time specification, then it will raise an exception that can be<br/>
		/// trapped by the Tcl catch command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1564<br/>
		/// </para>
		/// </summary>
		/// <param name="wait_state">
		/// <para>
		/// (Optional)<br/>
		/// valid stable_state - valid stable states IDLE, RESET, IRPAUSE,<br/>
		/// and DRPAUSE<br/>
		/// </para>
		/// </param>
		/// <param name="end_state">
		/// <para>
		/// (Optional)<br/>
		/// valid stable_state - valid stable states IDLE, RESET, IRPAUSE,<br/>
		/// and DRPAUSE<br/>
		/// </para>
		/// </param>
		/// <param name="sec">(Optional) Number of seconds to wait in wait_state</param>
		/// <param name="max_wait">(Optional) Maximum Number of seconds to wait in wait_state - max timeout</param>
		/// <param name="tck">
		/// <para>
		/// (Optional)<br/>
		/// Number of TCK cycles to wait in wait_state Default: Number<br/>
		/// of TCK cycles to wait in wait_state<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL runtest_hw_jtag(String wait_state = null, String end_state = null, Int32? sec = null, Int32? max_wait = null, Int32? tck = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: runtest_hw_jtag [-wait_state <arg>] [-end_state <arg>] [-sec <arg>] [-max_wait <arg>] [-tck <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.runtest_hw_jtag(wait_state, end_state, sec, max_wait, tck, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Perform shift DR on 'hw_jtag'.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: scan_dr_hw_jtag [-tdi &lt;arg&gt;] [-tdo &lt;arg&gt;] [-mask &lt;arg&gt;] [-smask &lt;arg&gt;] [-quiet] [-verbose] &lt;length&gt;
		/// <br/>
		/// <para>
		/// The scan_dr_hw_jtag command specifies a scan pattern to be scanned into the JTAG<br/>
		/// interface target data register.<br/>
		/// The command targets a hw_jtag object which is created when the hw_target is opened in JTAG<br/>
		/// mode through the use of the open_hw_target -jtag_mode command.<br/>
		/// When targeting the hw_jtag object prior to shifting the scan pattern specified in the<br/>
		/// scan_dr_hw_jtag command, the last defined header property (HDR) will be pre-pended to the<br/>
		/// beginning of the specified data pattern, and the last defined trailer property (TDR) will be<br/>
		/// appended to the end of the data pattern.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The options can be specified in any order, but can only be specified once. The number of bits<br/>
		/// represented by the hex strings specified for -tdi, -tdo, -mask, or -smask cannot be greater<br/>
		/// than the maximum specified by &lt;length&gt;. Leading zeros are assumed for a hex string if the<br/>
		/// number of bits represented by the hex strings specified is less than the &lt;length&gt;.<br/>
		/// When shifting the data bits to the target data register, the scan_dr_hw_jtag command moves<br/>
		/// the JTAG TAP from the current stable state to the DRSHIFT state according to the state<br/>
		/// transition table below:<br/>
		/// Current State Transitions to get to DRSHIFT state<br/>
		/// RESET IDLE -&gt; DRSELECT -&gt; DRCAPTURE -&gt; DRSHIFT<br/>
		/// IDLE DRSELECT -&gt; DRCAPTURE -&gt;<br/>
		/// DRSHIFT<br/>
		/// IRPAUSE IREXIT2 -&gt; IRUPDATE -&gt; DRSELECT -&gt; DRCAPTURE -&gt;<br/>
		/// DRSHIFT<br/>
		/// DRPAUSE DREXIT2 -&gt;<br/>
		/// DRSHIFT<br/>
		/// DRPAUSE* DREXIT2 -&gt; DRUPDATE -&gt; DRSELECT -&gt; DRCAPTURE -&gt; DRSHIFT<br/>
		/// Note: * With -force_update option set.<br/>
		/// After the last data bit is shifted into the target data register, the scan_dr_hw_jtag command<br/>
		/// moves the JTAG TAP to the IDLE state, or to the stable state defined by the<br/>
		/// run_state_hw_jtag command.<br/>
		/// The scan_dr_hw_jtag command returns a hex array containing captured TDO data from the<br/>
		/// hw_jtag, or returns an error if it fails.<br/>
		/// The command raises an error that can be trapped by the Tcl catch command if TDO data from<br/>
		/// the hw_jtag does not match specified -tdo argument.<br/>
		/// TIP: If -tdo and -mask arguments are specified, then the mask is applied to the -tdo option and the<br/>
		/// hw_jtag TDO data returned before comparing the two.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1580<br/>
		/// </para>
		/// </summary>
		/// <param name="length">(Required) Number of bits to be scanned.</param>
		/// <param name="tdi">(Optional) Hex value to be scanned into the target</param>
		/// <param name="tdo">(Optional) Hex value to be compared against the scanned value</param>
		/// <param name="mask">(Optional) Hex value mask applied when comparing TDO values</param>
		/// <param name="smask">(Optional) Hex value mask applied to TDI value</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>hardware TDO</returns>
		public TTCL scan_dr_hw_jtag(Int32 length, String tdi = null, String tdo = null, String mask = null, String smask = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: scan_dr_hw_jtag [-tdi <arg>] [-tdo <arg>] [-mask <arg>] [-smask <arg>] [-quiet] [-verbose] <length>
			_tcl.Entry(_builder.scan_dr_hw_jtag(length, tdi, tdo, mask, smask, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Perform shift IR on 'hw_jtag'.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: scan_ir_hw_jtag [-tdi &lt;arg&gt;] [-tdo &lt;arg&gt;] [-mask &lt;arg&gt;] [-smask &lt;arg&gt;] [-quiet] [-verbose] &lt;length&gt;
		/// <br/>
		/// <para>
		/// The scan_ir_hw_jtag command specifies a scan pattern to be scanned into the JTAG<br/>
		/// interface target instruction register.<br/>
		/// The command targets a hw_jtag object which is created when the hw_target is opened in JTAG<br/>
		/// mode through the use of the open_hw_target -jtag_mode command.<br/>
		/// When targeting the hw_jtag object prior to shifting the scan pattern specified in the<br/>
		/// scan_ir_hw_jtag command, the last defined header property (HIR) will be pre-pended to the<br/>
		/// beginning of the specified data pattern, and the last defined trailer property (TIR) will be<br/>
		/// appended to the end of the data pattern.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The options can be specified in any order, but can only be specified once. The number of bits<br/>
		/// represented by the hex strings specified for -tdi, -tdo, -mask, or -smask cannot be greater<br/>
		/// than the maximum specified by &lt;length&gt;. Leading zeros are assumed for a hex string if the<br/>
		/// number of bits represented by the hex strings specified is less than the &lt;length&gt;.<br/>
		/// When shifting the bits into the target instruction register, the scan_ir_hw_jtag command<br/>
		/// moves the JTAG TAP from the current stable state to the IRSHIFT state according to the state<br/>
		/// transition table below:<br/>
		/// Current Transitions to get to<br/>
		/// State IRSHIFT state<br/>
		/// RESET IDLE &gt; DRSELECT &gt; IRSELECT &gt; IRCAPTURE &gt; IRSHIFT<br/>
		/// IDLE IRSELECT &gt; IRCAPTURE &gt; IRSHIFT<br/>
		/// DRPAUSE DREXIT2 &gt; DRUPDATE &gt; DRSELECT &gt; IRSELECT &gt; IRCAPTURE &gt; IRSHIFT<br/>
		/// IRPAUSE IREXIT2 &gt; IRSHIFT<br/>
		/// IRPAUSE* IREXIT2 &gt; IRUPDATE &gt; DRSELECT &gt; IRSELECT &gt; IRCAPTURE &gt; IRSHIFT<br/>
		/// Note: * With -force_update option set.<br/>
		/// After the last data bit is shifted into the target data register, the scan_ir_hw_jtag command<br/>
		/// moves the JTAG TAP to the IDLE state, or to the stable state defined by the run_state_hw_jtag<br/>
		/// command.<br/>
		/// The scan_ir_hw_jtag command returns a hex array containing captured TDO data from the<br/>
		/// hw_jtag, or returns an error if it fails.<br/>
		/// The command raises an error that can be trapped by the Tcl catch command if TDO data from<br/>
		/// the hw_jtag does not match specified -tdo argument.<br/>
		/// TIP: If -tdo and -mask arguments are specified, then the mask is applied to the -tdo option and the<br/>
		/// hw_jtag TDO data returned before comparing the two.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1584<br/>
		/// </para>
		/// </summary>
		/// <param name="length">(Required) Number of bits to be scanned.</param>
		/// <param name="tdi">(Optional) Hex value to be scanned into the target</param>
		/// <param name="tdo">(Optional) Hex value to be compared against the scanned value</param>
		/// <param name="mask">(Optional) Hex value mask applied when comparing TDO values</param>
		/// <param name="smask">(Optional) Hex value mask applied to TDI value</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>hardware TDO</returns>
		public TTCL scan_ir_hw_jtag(Int32 length, String tdi = null, String tdo = null, String mask = null, String smask = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: scan_ir_hw_jtag [-tdi <arg>] [-tdo <arg>] [-mask <arg>] [-smask <arg>] [-quiet] [-verbose] <length>
			_tcl.Entry(_builder.scan_ir_hw_jtag(length, tdi, tdo, mask, smask, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set property on object(s)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_property [-dict &lt;args&gt;] [-quiet] [-verbose] &lt;name&gt; &lt;value&gt; &lt;objects&gt;...
		/// <br/>
		/// <para>
		/// Assigns the defined property &lt;name&gt; and &lt;value&gt; to the specified &lt;objects&gt;.<br/>
		/// This command can be used to define any property on an object in the design. Each object has a<br/>
		/// set of predefined properties that have expected values, or a range of values. The set_property<br/>
		/// command can be used to define the values for these properties. To determine the defined set of<br/>
		/// properties on an object, use report_property, list_property, or<br/>
		/// list_property_values.<br/>
		/// You can also define custom properties for an object, by specifying a unique &lt;name&gt; and &lt;value&gt;<br/>
		/// pair for the object. If an object has custom properties, these will also be reported by the<br/>
		/// report_property and list_property commands.<br/>
		/// This command returns nothing if successful, and an error if it fails.<br/>
		/// TIP: You can use the get_property command to validate any properties that have been set on an<br/>
		/// object.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// Create a user-defined boolean property, TRUTH, for cell objects, and set the property on a cell:<br/>
		/// create_property -type bool truth cell<br/>
		/// set_property truth false [lindex [get_cells] 1]<br/>
		/// Use the -dict option to specify multiple properties at one time on the current design:<br/>
		/// set_property -dict "POST_CRC enable POST_CRC_ACTION correct_and_continue"<br/>
		/// \<br/>
		/// [current_design]<br/>
		/// The following example sets the TOP property of the current fileset to define the top module of<br/>
		/// the project:<br/>
		/// set_property top fftTop [current_fileset]<br/>
		/// set_property top_file {C:/Data/sources/fftTop.v} [current_fileset]<br/>
		/// Note: Defining the top module requires the TOP property to be set to the desired hierarchical block in the<br/>
		/// source fileset of the current project. In the preceding example TOP is the property name, fftTop is the<br/>
		/// value, and current_fileset is the object. In addition, the TOP_FILE property should be defined to point to<br/>
		/// the data source for the top module.<br/>
		/// This example shows how to set a property value that includes the dash character, '-'. The dash<br/>
		/// can cause the tool to interpret the value as a new command argument, rather than part of the<br/>
		/// value being specified, and will cause an error as shown. In this case, you must use the explicit<br/>
		/// form of the positional arguments in the set_property command:<br/>
		/// set_property {XELAB.MORE_OPTIONS} {-pulse_e_style ondetect} \<br/>
		/// [get_filesets sim_1]<br/>
		/// ERROR: [Common 17-170] Unknown option '-pulse_e_style ondetect',<br/>
		/// please type 'set_property -help' for usage info.<br/>
		/// set_property -name {XELAB.MORE_OPTIONS} -value {-pulse_e_style ondetect}\<br/>
		/// -objects [get_filesets sim_1]<br/>
		/// The following example sets the internal VREF property value for the specified IO Bank:<br/>
		/// set_property internal_vref {0.75} [get_iobanks 0]<br/>
		/// The following example defines a DCI Cascade by setting the DCI_CASCADE property for the<br/>
		/// specified IO Bank:<br/>
		/// set_property DCI_CASCADE {14} [get_iobanks 0 ]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example configures the synth_1 run, setting options for Vivado Synthesis 2013,<br/>
		/// and then launches the synthesis run:<br/>
		/// set_property flow {Vivado Synthesis 2016} \<br/>
		/// [get_runs synth_1]<br/>
		/// set_property STEPS.SYNTH_DESIGN.ARGS.GATED_CLOCK_CONVERSION on \<br/>
		/// [get_runs synth_1]<br/>
		/// set_property STEPS.SYNTH_DESIGN.ARGS.FSM_EXTRACTION one_hot \<br/>
		/// [get_runs synth_1]<br/>
		/// launch_runs synth_1<br/>
		/// This example is the same as the prior example, except that it uses the -dict option to set all the<br/>
		/// properties on the synthesis run in a single set_property command:<br/>
		/// set_property -dict [ list flow {Vivado Synthesis 2016} \<br/>
		/// STEPS.SYNTH_DESIGN.ARGS.GATED_CLOCK_CONVERSION on \<br/>
		/// STEPS.SYNTH_DESIGN.ARGS.FSM_EXTRACTION \<br/>
		/// one_hot ] [get_runs synth_1]<br/>
		/// launch_runs synth_1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1682<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of property to set. Not valid with -dict option</param>
		/// <param name="value">(Required) Value of property to set. Not valid with -dict option</param>
		/// <param name="objects">(Required) Objects to set properties on</param>
		/// <param name="dict">(Optional) list of name/value pairs of properties to set</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_property(String name, String value, TCLParameterList objects, TCLParameterList dict = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_property [-dict <args>] [-quiet] [-verbose] <name> <value> <objects>...
			_tcl.Entry(_builder.set_property(name, value, objects, dict, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Check whether the XML files describing a board in the given directory are valid. Only supported<br/>
		/// for board XML files with schema_version&gt;=2.0. The XML files must contain an appropriate<br/>
		/// DOCTYPE declaration to be fully validated. Examples: &lt;!DOCTYPE board SYSTEM "board.dtd"&gt;<br/>
		/// &lt;!-- for board.xml --&gt; &lt;!DOCTYPE ip_presets SYSTEM "preset.dtd"&gt; &lt;!-- for preset.xml --&gt; &lt;!<br/>
		/// DOCTYPE part_info SYSTEM "part0_pins.dtd"&gt; &lt;!-- for part0_pins.xml --&gt;<br/>
		/// Note that if a project is open and an IP repository loaded, this command will also validate certain<br/>
		/// IP and Interface attributes used in the board definition against the current IP repository.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: validate_board_files [-quiet] [-verbose] [&lt;dir&gt;...]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1796<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="dir">
		/// <para>
		/// (Optional)<br/>
		/// The name of a directory containing the board files<br/>
		/// (board.xml, part0_pins.xml, preset.xml) to be checked<br/>
		/// </para>
		/// </param>
		/// <returns>ok if all board files are valid</returns>
		public TTCL validate_board_files(bool? quiet = null, bool? verbose = null, TCLParameterList dir = null)
		{
			// TCL Syntax: validate_board_files [-quiet] [-verbose] [<dir>...]
			_tcl.Entry(_builder.validate_board_files(quiet, verbose, dir));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write a tcl script on disk that will recreate a given IP.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_ip_tcl [-force] [-no_ip_version] [-ip_name &lt;arg&gt;] [-show_defaults] [-multiple_files] [-quiet] [-verbose] [&lt;objects&gt;] [&lt;tcl_filename&gt;...]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1871<br/>
		/// </para>
		/// </summary>
		/// <param name="force">(Optional) Flag to overwrite existing file.</param>
		/// <param name="no_ip_version">
		/// <para>
		/// (Optional)<br/>
		/// Flag to not include the IP version in the IP VLNV in create_ip<br/>
		/// commands. NOTE - this may have implications if there are<br/>
		/// major IP version changes.<br/>
		/// </para>
		/// </param>
		/// <param name="ip_name">
		/// <para>
		/// (Optional)<br/>
		/// Set the name of the IP. This argument is not supported for<br/>
		/// multiple IP.<br/>
		/// </para>
		/// </param>
		/// <param name="show_defaults">(Optional) Add a comment containing the default parameter values of the IP.</param>
		/// <param name="multiple_files">(Optional) Flag to create a .tcl file for each IP supplied as an argument</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">
		/// <para>
		/// (Optional)<br/>
		/// IP(s) to be written to disk Values: IP instance(s) as returned<br/>
		/// by 'get_ips &lt;instance name&gt;'<br/>
		/// </para>
		/// </param>
		/// <param name="tcl_filename">
		/// <para>
		/// (Optional)<br/>
		/// File path to the exported tcl file. If the path is a directory and<br/>
		/// multiple IP are given as an argument, a file for each IP will<br/>
		/// be created. Default: ./<br/>
		/// </para>
		/// </param>
		/// <returns>IP TCL file</returns>
		public TTCL write_ip_tcl(bool? force = null, bool? no_ip_version = null, String ip_name = null, bool? show_defaults = null, bool? multiple_files = null, bool? quiet = null, bool? verbose = null, String objects = null, TCLParameterList tcl_filename = null)
		{
			// TCL Syntax: write_ip_tcl [-force] [-no_ip_version] [-ip_name <arg>] [-show_defaults] [-multiple_files] [-quiet] [-verbose] [<objects>] [<tcl_filename>...]
			_tcl.Entry(_builder.write_ip_tcl(force, no_ip_version, ip_name, show_defaults, multiple_files, quiet, verbose, objects, tcl_filename));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write out one or more DRC/METHODOLOGY/CDC message waivers in command form<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_waivers [-type &lt;arg&gt;] [-objects &lt;args&gt;] [-return_string] [-force] [-quiet] [-verbose] [&lt;file&gt;]
		/// <br/>
		/// <para>
		/// To save waivers from one design session to the next, you must use write_waivers to create<br/>
		/// an XDC file of the waiver commands, and read_xdc to read those waivers back into the design<br/>
		/// when it is reopened.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example writes all waivers in the current design:<br/>
		/// write_waivers C:/Data/design_waivers.xdc<br/>
		/// The following example writes only DRC type waivers:<br/>
		/// write_waivers -type DRC C:/Data/drc_waivers.xdc<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1898<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Name of file to write waivers</param>
		/// <param name="type">(Optional) Type of waiver(s) - ALL, DRC, METHODOLOGY, CDC to write</param>
		/// <param name="objects">(Optional) List of DRC/METHODOLOGY/CDC waiver objects to be written</param>
		/// <param name="return_string">(Optional) Return report results as a string object</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_waivers(String file, String type = null, TCLParameterList objects = null, bool? return_string = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_waivers [-type <arg>] [-objects <args>] [-return_string] [-force] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.write_waivers(file, type, objects, return_string, force, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
