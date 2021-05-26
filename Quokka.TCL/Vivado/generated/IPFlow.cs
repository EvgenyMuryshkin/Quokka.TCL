#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class IPFlowCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public IPFlowCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// <para>
		/// Add a new bus interface to a peripheral.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: add_peripheral_interface -interface_mode &lt;arg&gt; -axi_type &lt;arg&gt; [-quiet] [-verbose] &lt;name&gt; &lt;peripheral&gt;
		/// <br/>
		/// <para>
		/// Add an AXI bus interface to a peripheral created with the create_peripheral command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 57<br/>
		/// </para>
		/// </summary>
		/// <param name="interface_mode">(Required) Mode of an interface, supported option - master,slave.</param>
		/// <param name="axi_type">(Required) Type of a axi interface, supported option - lite,full,stream.</param>
		/// <param name="name">(Required) Name to initialize the newly added element e.g S1_AXI, M1_AXI</param>
		/// <param name="peripheral">(Required) Peripheral object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL add_peripheral_interface(String interface_mode, String axi_type, TCLObject name, TCLObject peripheral, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: add_peripheral_interface -interface_mode <arg> -axi_type <arg> [-quiet] [-verbose] <name> <peripheral>
			_tcl.Entry(_builder.add_peripheral_interface(interface_mode, axi_type, name, peripheral, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Compile C code into RTL<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: compile_c [-force] [-quiet] [-verbose] &lt;objects&gt;
		/// <br/>
		/// <para>
		/// In IP cores that are imported from Vivado HLS, the compile_c command detects C, C++, and<br/>
		/// SystemC files and converts those files to RTL for synthesis by the Vivado Design Suite.<br/>
		/// This lets you use Vivado HLS to describe IP cores in a high-level language, like C or C++ rather<br/>
		/// than RTL.<br/>
		/// When HLS-based IP cores are generated, they only deliver the C source. When the HLS-based IP<br/>
		/// is synthesized, either in the out-of-context flow, or with the top-level design, the compile_c<br/>
		/// command launches Vivado HLS to convert the C source files into RTL, and import the resulting<br/>
		/// RTL sources back into the design prior to synthesis.<br/>
		/// RECOMMENDED: The compile_c command is automatically called by the Vivado Design Suite when<br/>
		/// it encounters IP with C code from the Vivado HLS system. You should not need to manually call this<br/>
		/// command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 164<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) The objects which need C to RTL conversion</param>
		/// <param name="force">(Optional) Force generate product state regeneration</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL compile_c(TCLObject objects, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: compile_c [-force] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.compile_c(objects, force, quiet, verbose));
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
		public TTCL config_ip_cache(String use_cache_location = null, bool? use_project_cache = null, bool? disable_cache = null, bool? clear_output_repo = null, bool? clear_local_cache = null, bool? cache_has_match = null, bool? cache_was_used = null, bool? get_id = null, String get_entry_location = null, bool? remove = null, String vlnv = null, bool? old_swvers = null, bool? unused = null, String swver = null, Int32? num_days_old = null, Int32? num_days_unused = null, bool? obs_synth_crc = null, bool? disk_usage_output_repo = null, bool? report = null, String rptfile = null, String csvfile = null, String zip_cache = null, bool? import_from_project = null, String filter = null, bool? regexp = null, bool? nocase = null, bool? purge = null, bool? quiet = null, bool? verbose = null, TCLObject ip = null)
		{
			// TCL Syntax: config_ip_cache [-use_cache_location <arg>] [-use_project_cache] [-disable_cache] [-clear_output_repo] [-clear_local_cache] [-cache_has_match] [-cache_was_used] [-get_id] [-get_entry_location <arg>] [-remove] [-vlnv <arg>] [-old_swvers] [-unused] [-swver <arg>] [-num_days_old <arg>] [-num_days_unused <arg>] [-obs_synth_crc] [-disk_usage_output_repo] [-report] [-rptfile <arg>] [-csvfile <arg>] [-zip_cache <arg>] [-import_from_project] [-filter <arg>] [-regexp] [-nocase] [-purge] [-quiet] [-verbose] [<ip>]
			_tcl.Entry(_builder.config_ip_cache(use_cache_location, use_project_cache, disable_cache, clear_output_repo, clear_local_cache, cache_has_match, cache_was_used, get_id, get_entry_location, remove, vlnv, old_swvers, unused, swver, num_days_old, num_days_unused, obs_synth_crc, disk_usage_output_repo, report, rptfile, csvfile, zip_cache, import_from_project, filter, regexp, nocase, purge, quiet, verbose, ip));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Convert specified IP to or from core container format.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: convert_ips [-force] [-to_core_container] [-from_core_container] [-quiet] [-verbose] &lt;objects&gt;
		/// <br/>
		/// <para>
		/// This command converts existing IP into core container format, or reverts core container IP into<br/>
		/// the expanded non-core container format.<br/>
		/// The core container format for IP is a compressed zip file that reduces the file structure in the<br/>
		/// design, and increases tool performance.<br/>
		/// By default, the Vivado tool adds IP from the Xilinx IP catalog into a design using the core<br/>
		/// container format. However, the convert_ips command lets you convert IP in existing designs<br/>
		/// to take advantage of the core container format. In addition, the convert_ips command also<br/>
		/// lets you revert the compressed core container format into the expanded non-core container<br/>
		/// format.<br/>
		/// TIP: If neither -to_core_container or -from_core_container options are specified then the<br/>
		/// convert_ips command will convert the IP from its current format into the opposite form. Any core<br/>
		/// container IP will be converted to non-core container format, and any non-core container IP will be<br/>
		/// converted to core container format.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// IP that is user-managed, cannot be converted from its current format. IP that is locked requires<br/>
		/// the use of the -force option to convert. Refer to the Vivado Design Suite User Guide: Designing<br/>
		/// with IP (UG896) for more information on editing IP and the IS_LOCKED and IS_MANAGED<br/>
		/// properties.<br/>
		/// This command returns a transcript of its actions, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example converts all IP in the current project into core container format:<br/>
		/// convert_ips -to_core_container [get_ips]<br/>
		/// Note: Any IP already in the core container format will be skipped.<br/>
		/// The following example converts the specified IP file to core container format:<br/>
		/// convert_ips -to_core_container \<br/>
		/// [get_files C:/Data/wave1/wave1.srcs/sources_1/ip/char_fifo/char_fifo.xci]<br/>
		/// The following example toggles the current format of all IP in the design, switching from core<br/>
		/// container to non-core container, and from non-core container to core container:<br/>
		/// convert_ips [get_ips]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 210<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) Input objects for the IP. May IP or source file objects</param>
		/// <param name="force">(Optional) Force conversion even if the IP is locked.</param>
		/// <param name="to_core_container">(Optional) Convert IP to core container format.</param>
		/// <param name="from_core_container">(Optional) Convert IP to non core container format.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL convert_ips(TCLObject objects, bool? force = null, bool? to_core_container = null, bool? from_core_container = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: convert_ips [-force] [-to_core_container] [-from_core_container] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.convert_ips(objects, force, to_core_container, from_core_container, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Copy an existing IP<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: copy_ip -name &lt;arg&gt; [-dir &lt;arg&gt;] [-quiet] [-verbose] &lt;objects&gt;...
		/// <br/>
		/// <para>
		/// Create a copy of an IP core that has been previously instanced into the current project.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 218<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of copied IP</param>
		/// <param name="objects">(Required) IP to be copied</param>
		/// <param name="dir">
		/// <para>
		/// (Optional)<br/>
		/// Directory path for remote IP to be created and managed<br/>
		/// outside the project<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>IP file object that was added to the project</returns>
		public TTCL copy_ip(String name, TCLObjectList objects, String dir = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: copy_ip -name <arg> [-dir <arg>] [-quiet] [-verbose] <objects>...
			_tcl.Entry(_builder.copy_ip(name, objects, dir, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create an instance of a configurable IP and add it to the fileset<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_ip [-vlnv &lt;arg&gt;] -module_name &lt;arg&gt; [-dir &lt;arg&gt;] [-force] [-allow_hidden] [-vendor &lt;arg&gt;] [-library &lt;arg&gt;] [-name &lt;arg&gt;] [-version &lt;arg&gt;] [-revision &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This command creates an XCI file for a configurable IP core from the IP catalog, and adds it to the<br/>
		/// source files of the current project. This creates an IP source object which must be instantiated<br/>
		/// into the HDL design to create an instance of the IP core in the netlist.<br/>
		/// For multiple instances of the same core, simply instantiate the core module into the HDL design<br/>
		/// as many times as needed. However, to use the same IP core with different customizations, use<br/>
		/// the create_ip command to create separate IP source objects.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The create_ip command is used to import IP cores from the current IP catalog. Use the<br/>
		/// import_ip command to read existing XCI and XCO files directly, without having to add IP to a<br/>
		/// catalog.<br/>
		/// This command returns a transcript of the IP generation process, concluding with the file path and<br/>
		/// name of the imported IP core file.<br/>
		/// Note: IP cores are native to Vivado, and can be customized and regenerated within that tool. The<br/>
		/// convert_ip command lets you to convert legacy IP to native IP supported by Vivado.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The example below imports the IP core specified by the -vlnv string, and gives it the specified<br/>
		/// module name in the current project:<br/>
		/// create_ip -vlnv xilinx.com:ip:c_addsub:11.0 -module_name test_addr<br/>
		/// The following example, from Vivado, creates an IP block with the specified -vendor, -<br/>
		/// library, -name, -version values, and assigns it the specified module name. After the IP is<br/>
		/// created, attributes of the IP are customized using set_property commands. Then the<br/>
		/// instantiation template and the synthesis targets are generated for the IP:<br/>
		/// create_ip -name c_addsub -version 11.0 -vendor xilinx.com -library ip \<br/>
		/// -module_name c_addsub_v11_0_0<br/>
		/// set_property CONFIG.COMPONENT_NAME c_addsub_v11_0_0 \<br/>
		/// [get_ips c_addsub_v11_0_0]<br/>
		/// set_property CONFIG.A_WIDTH 32 [get_ips c_addsub_v11_0_0]<br/>
		/// set_property CONFIG.B_WIDTH 32 [get_ips c_addsub_v11_0_0]<br/>
		/// set_property CONFIG.ADD_MODE Add_Subtract [get_ips c_addsub_v11_0_0]<br/>
		/// set_property CONFIG.C_IN true [get_ips c_addsub_v11_0_0]<br/>
		/// generate_target {instantiation_template synthesis} \<br/>
		/// [get_files C:/Data/c_addsub_v11_0_0/c_addsub_v11_0_0.xci \<br/>
		/// -of_objects [get_filesets sources_1]]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 316<br/>
		/// </para>
		/// </summary>
		/// <param name="module_name">(Required) Name for the new IP that will be added to the project</param>
		/// <param name="vlnv">
		/// <para>
		/// (Optional)<br/>
		/// VLNV string for the Catalog IP from which the new IP will be<br/>
		/// created (colon delimited Vendor, Library, Name, Version)<br/>
		/// </para>
		/// </param>
		/// <param name="dir">
		/// <para>
		/// (Optional)<br/>
		/// Directory path for remote IP to be created and managed<br/>
		/// outside the project<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Overwrite existing IP instance; allowed only with -dir option</param>
		/// <param name="allow_hidden">(Optional) Allow hidden cores to be instantiated</param>
		/// <param name="vendor">(Optional) IP Vendor name</param>
		/// <param name="library">(Optional) IP Library name</param>
		/// <param name="name">(Optional) IP Name</param>
		/// <param name="version">(Optional) IP Version</param>
		/// <param name="revision">(Optional) (Optional) IP core revision</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of file objects that were added</returns>
		public TTCL create_ip(String module_name, String vlnv = null, String dir = null, bool? force = null, bool? allow_hidden = null, String vendor = null, String library = null, String name = null, String version = null, String revision = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_ip [-vlnv <arg>] -module_name <arg> [-dir <arg>] [-force] [-allow_hidden] [-vendor <arg>] [-library <arg>] [-name <arg>] [-version <arg>] [-revision <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_ip(module_name, vlnv, dir, force, allow_hidden, vendor, library, name, version, revision, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Creates a run for the given IP.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_ip_run [-force] [-quiet] [-verbose] &lt;objects&gt;
		/// <br/>
		/// <para>
		/// Defines a synthesis and implementation run for a single IP object as specified by the get_ips<br/>
		/// command, or for the specified IP core file (XCI) as specified by the get_files command.<br/>
		/// The IP run is used to generate the synthesis design checkpoint file (DCP) to support the out-of-context (OOC) IP flow, or to synthesize and implement an IP module in the OOC hierarchical<br/>
		/// design flow.<br/>
		/// Two runs are created: one for synthesis, and one for implementation. The runs are named after<br/>
		/// the IP core and the run type, &lt;ip_name&gt;_synth_1 and &lt;ip_name&gt;_impl_1.<br/>
		/// The IP source files required to synthesize the run are copied into the IP run directory. The<br/>
		/// attributes of the run can be configured with the use of the set_property command.<br/>
		/// This command returns the name of the synthesis run created for the IP module.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates synthesis and implementation runs for the specified IP module:<br/>
		/// create_ip_run [get_ips add1]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 319<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">
		/// <para>
		/// (Required)<br/>
		/// All of the IP objects (from get_ips or get_files) for which a<br/>
		/// run needs to be generated for.<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Force regeneration of products of the given IP.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_ip_run(TCLObject objects, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_ip_run [-force] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.create_ip_run(objects, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a peripheral with a VLNV.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_peripheral [-dir &lt;arg&gt;] [-quiet] [-verbose] &lt;vendor&gt; &lt;library&gt; &lt;name&gt; &lt;version&gt;
		/// <br/>
		/// <para>
		/// Create an AXI peripheral to add to the IP repository with the specified VLNV attribute.<br/>
		/// The AXI peripheral that is created is just a framework until interfaces have been added to the<br/>
		/// peripheral using the add_peripheral_interface command, and the peripheral has been<br/>
		/// generated using the generate_peripheral command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 329<br/>
		/// </para>
		/// </summary>
		/// <param name="vendor">(Required) Vendor, for example xilinx.com</param>
		/// <param name="library">(Required) Library, for example ip</param>
		/// <param name="name">(Required) Name, for example myip</param>
		/// <param name="version">(Required) Version, for example 1.4</param>
		/// <param name="dir">
		/// <para>
		/// (Optional)<br/>
		/// Directory path for remote Peripheral to be created and<br/>
		/// managed outside the project<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_peripheral(TCLObject vendor, TCLObject library, TCLObject name, TCLObject version, String dir = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_peripheral [-dir <arg>] [-quiet] [-verbose] <vendor> <library> <name> <version>
			_tcl.Entry(_builder.create_peripheral(vendor, library, name, version, dir, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Deletes the block fileset and run associated with a given IP.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_ip_run [-force] [-quiet] [-verbose] &lt;objects&gt;
		/// <br/>
		/// <para>
		/// Deletes the out-of-context (OOC) synthesis and implementation runs for the specified IP<br/>
		/// module.<br/>
		/// The contents of the run directory are deleted from the project as well as the run. However, the<br/>
		/// output products created by the run and copied to the IP sources folder, the DCP file and Verilog<br/>
		/// and VHDL structural netlists, are not deleted from the project. You must use the reset_target<br/>
		/// or generate_target command to update the IP output products.<br/>
		/// IMPORTANT! The command requires an IP object as specified by the get_ips or get_files<br/>
		/// command, and will not delete a run based on either the name of the run, or a run object as returned by<br/>
		/// get_runs.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example deletes the OOC synthesis and implementation runs from the specified IP<br/>
		/// module:<br/>
		/// delete_ip_run [get_ips add1]<br/>
		/// Note: In this example, all run results will also be removed from the run directory on the hard drive.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 457<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">
		/// <para>
		/// (Required)<br/>
		/// All of the IP objects (from get_ips or get_files) for which the<br/>
		/// block fileset and run will be deleted.<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Force the deletion of the block fileset and run.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_ip_run(TCLObject objects, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_ip_run [-force] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.delete_ip_run(objects, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Extract files from a core container to disk<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: extract_files [-base_dir &lt;arg&gt;] [-force] [-no_ip_dir] [-no_paths] [-quiet] [-verbose] &lt;files&gt;...
		/// <br/>
		/// <para>
		/// Extract the files from an IP in core container format.<br/>
		/// The core container format for IP is a compressed zip file that reduces the file structure in the<br/>
		/// design, and increases tool performance.<br/>
		/// This command returns a list of files extracted from the core container IP, or returns an error if it<br/>
		/// fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example extracts the files from the specified core container format IP to the<br/>
		/// specified base directory:<br/>
		/// extract_files -base_dir C:/Data [get_files char_fifo.xcix]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 524<br/>
		/// </para>
		/// </summary>
		/// <param name="files">(Required) Name of the file(s) to be extracted</param>
		/// <param name="base_dir">(Optional) Base directory for extracted files Default: ip_files</param>
		/// <param name="force">(Optional) Overwrite existing files</param>
		/// <param name="no_ip_dir">(Optional) Don't include the IP dir as part of the extract directory</param>
		/// <param name="no_paths">(Optional) Don't include directories when extracting files</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of files that were extracted with the new paths</returns>
		public TTCL extract_files(TCLObjectList files, String base_dir = null, bool? force = null, bool? no_ip_dir = null, bool? no_paths = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: extract_files [-base_dir <arg>] [-force] [-no_ip_dir] [-no_paths] [-quiet] [-verbose] <files>...
			_tcl.Entry(_builder.extract_files(files, base_dir, force, no_ip_dir, no_paths, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Generate output products for peripheral object.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: generate_peripheral [-driver] [-example_design] [-bfm_example_design] [-debug_hw_example_design] [-enable_interrupt] [-force] [-quiet] [-verbose] &lt;peripheral&gt;
		/// <br/>
		/// <para>
		/// Generate the output products for the specified peripheral object. The output products are<br/>
		/// written to the IP repository location specified when the IP is created by the<br/>
		/// create_peripheral command, under the name of the IP as specified at creation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 545<br/>
		/// </para>
		/// </summary>
		/// <param name="peripheral">(Required) peripheral object</param>
		/// <param name="driver">(Optional) Generate driver for peripheral.</param>
		/// <param name="example_design">(Optional) Generate all supported example designs for peripheral.</param>
		/// <param name="bfm_example_design">(Optional) Generate bfm simulation example design for peripheral.</param>
		/// <param name="debug_hw_example_design">(Optional) Generate debug hardware example design for peripheral.</param>
		/// <param name="enable_interrupt">(Optional) Generate peripheral with interrupt suppport.</param>
		/// <param name="force">(Optional) Overwrite the existing IP in the repository.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL generate_peripheral(TCLObject peripheral, bool? driver = null, bool? example_design = null, bool? bfm_example_design = null, bool? debug_hw_example_design = null, bool? enable_interrupt = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_peripheral [-driver] [-example_design] [-bfm_example_design] [-debug_hw_example_design] [-enable_interrupt] [-force] [-quiet] [-verbose] <peripheral>
			_tcl.Entry(_builder.generate_peripheral(peripheral, driver, example_design, bfm_example_design, debug_hw_example_design, enable_interrupt, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Generate target data for the specified source<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: generate_target [-force] [-quiet] [-verbose] &lt;name&gt; &lt;objects&gt;
		/// <br/>
		/// <para>
		/// This command generates target data for the specified IP objects (get_ips) or source file for IP<br/>
		/// cores (.xci and .xco), DSP modules (.slx or .mdl), or block designs (.bd). The target data<br/>
		/// that is generated are the files necessary to support the IP or block design through the FPGA<br/>
		/// design flow.<br/>
		/// The instantiation template, synthesis netlist, and simulation netlist are standard targets. However,<br/>
		/// each IP in the catalog may also support its own set of targets. You can view the available targets<br/>
		/// on an object by examining the SUPPORTED_TARGETS property, or you can use the<br/>
		/// list_targets command to list the targets for design source file.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example generates the change log for all of the IP cores in the current project, forcing<br/>
		/// regeneration of any targets that are up-to-date:<br/>
		/// generate_target changelog [get_ips] -force<br/>
		/// The following example generates the instantiation template and synthesis targets for all of the IP<br/>
		/// cores in the current project:<br/>
		/// generate_target {instantiation_template synthesis} [get_ips]<br/>
		/// TIP: Note the use of the braces to pass the list of targets to the command. The absence of the -force<br/>
		/// option means that only out-of-date targets will be regenerated.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example generates all targets for the specified block design:<br/>
		/// generate_target all \<br/>
		/// [get_files C:/Data/project_mb/project_mb.srcs/sources_1/bd/base_mb/<br/>
		/// base_mb.bd]<br/>
		/// IMPORTANT! The use of get_ips is not supported to generate targets for individual IP within block<br/>
		/// designs. The tool will return an error.<br/>
		/// The following queries the SUPPORTED_TARGETS property of the specified IP object, and then<br/>
		/// generates the example project for the IP:<br/>
		/// get_property SUPPORTED_TARGETS [get_ips blk_mem*]<br/>
		/// open_example_project -dir C:/Data/examples -force [get_ips blk_mem*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 552<br/>
		/// </para>
		/// </summary>
		/// <param name="name">
		/// <para>
		/// (Required)<br/>
		/// List of targets to be generated, or 'all' to generate all<br/>
		/// supported targets<br/>
		/// </para>
		/// </param>
		/// <param name="objects">(Required) The objects for which data needs to be generated</param>
		/// <param name="force">(Optional) Force target data regeneration</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL generate_target(TCLObject name, TCLObject objects, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_target [-force] [-quiet] [-verbose] <name> <objects>
			_tcl.Entry(_builder.generate_target(name, objects, force, quiet, verbose));
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
		public TTCL get_ip_upgrade_results(String srcset = null, bool? quiet = null, bool? verbose = null, TCLObjectList objects = null)
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
		public TTCL get_ipdefs(bool? name = null, bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? all = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
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
		public TTCL get_ips(bool? regexp = null, bool? nocase = null, bool? all = null, String filter = null, bool? exclude_bd_ips = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_ips [-regexp] [-nocase] [-all] [-filter <arg>] [-exclude_bd_ips] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_ips(regexp, nocase, all, filter, exclude_bd_ips, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Import an IP file and add it to the fileset<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: import_ip [-srcset &lt;arg&gt;] [-name &lt;arg&gt;] [-quiet] [-verbose] [&lt;files&gt;]
		/// <br/>
		/// <para>
		/// Adds an existing XCI or XCO file as an IP source into the current project, and copies it into the<br/>
		/// local project directory structure.<br/>
		/// The import_ip command allows you to read existing IP files directly, and copy them into the<br/>
		/// local project folders. Use the read_ip or add_files command to add IP files by reference into<br/>
		/// the current project.<br/>
		/// Use the create_ip command to create new IP files from the current IP catalog.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example copies the 10gig ethernet core into the current project, and assigns it a<br/>
		/// name of IP_block1:<br/>
		/// import_ip C:/Data/FPGA_Design/10gig_eth.xci -name IP_block1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 987<br/>
		/// </para>
		/// </summary>
		/// <param name="srcset">
		/// <para>
		/// (Optional)<br/>
		/// (Optional) Specifies the source file set containing the objects<br/>
		/// to be upgraded Default: The current source fileset Values:<br/>
		/// Source set name<br/>
		/// </para>
		/// </param>
		/// <param name="name">
		/// <para>
		/// (Optional)<br/>
		/// (Optional) Specifies a replacement name for the imported<br/>
		/// IP; may not be used with multiple files. Default: The current<br/>
		/// name for the imported IP Values: The new name for the<br/>
		/// imported IP<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="files">
		/// <para>
		/// (Optional)<br/>
		/// Names of the IP files to be imported Values: A list of XCI<br/>
		/// (and/or XCO) file name(s)<br/>
		/// </para>
		/// </param>
		/// <returns>list of file objects that were added</returns>
		public TTCL import_ip(String srcset = null, String name = null, bool? quiet = null, bool? verbose = null, TCLObject files = null)
		{
			// TCL Syntax: import_ip [-srcset <arg>] [-name <arg>] [-quiet] [-verbose] [<files>]
			_tcl.Entry(_builder.import_ip(srcset, name, quiet, verbose, files));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Open the example project for the indicated IP<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: open_example_project [-dir &lt;arg&gt;] [-force] [-in_process] [-quiet] [-verbose] &lt;objects&gt;...
		/// <br/>
		/// <para>
		/// Open an example project for the specified IP cores. The example project can be used to explore<br/>
		/// the features of the IP core in a stand-alone project, instead of integrated into the current project.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following copies the IP customization and opens the example project for the specified IP<br/>
		/// core in a new location:<br/>
		/// open_example_project -dir C:/Data/examples -force [get_ips blk_mem*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1077<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) The objects whose example projects will be opened</param>
		/// <param name="dir">(Optional) Path to directory where example project will be created</param>
		/// <param name="force">(Optional) Overwrite an example project if it exists</param>
		/// <param name="in_process">(Optional) Open the example project in the same process</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The Project that was opened</returns>
		public TTCL open_example_project(TCLObjectList objects, String dir = null, bool? force = null, bool? in_process = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: open_example_project [-dir <arg>] [-force] [-in_process] [-quiet] [-verbose] <objects>...
			_tcl.Entry(_builder.open_example_project(objects, dir, force, in_process, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Read one or more IP files<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_ip [-quiet] [-verbose] &lt;files&gt;
		/// <br/>
		/// <para>
		/// Read the specified list of IP files (XCI) and add them to the design and the current fileset. Files are<br/>
		/// added by reference into the current project, just as in the add_files command.<br/>
		/// You can use this command to read the contents of source files into the in-memory design, when<br/>
		/// running the Vivado tool in Non Project mode, in which there is no project file to maintain and<br/>
		/// manage the various project source files. Refer to the Vivado Design Suite User Guide: Design Flows<br/>
		/// Overview (UG892) for more information on Non Project mode.<br/>
		/// When using the read_ip command all output products associated with the IP core, including<br/>
		/// the design checkpoint file (DCP) will be read into the in-memory design.<br/>
		/// TIP: In the project-based design flow, the Vivado tool will automatically generate the necessary output<br/>
		/// products associated with an IP core. However, in a non-project flow you must generate the necessary<br/>
		/// output products using the synth_ip or generate_target commands. For more information on<br/>
		/// working with IP refer to the Vivado Design Suite User Guide: Designing with IP (UG896).<br/>
		/// Use the import_ip command to add the IP cores and import the files into the local project<br/>
		/// directory.<br/>
		/// This command returns the list of files read.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reads the specified IP files:<br/>
		/// read_ip C:/test_ip/char_fifo.xci<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1167<br/>
		/// </para>
		/// </summary>
		/// <param name="files">(Required) IP file name(s)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of IP file objects that were added</returns>
		public TTCL read_ip(TCLObject files, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_ip [-quiet] [-verbose] <files>
			_tcl.Entry(_builder.read_ip(files, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report on the status of the IP instances in the project.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_ip_status [-name &lt;arg&gt;] [-file &lt;arg&gt;] [-append] [-return_string] [-license_status] [-resource_data] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This command examines the IP cores in the current project, and reports the state of the IP with<br/>
		/// regard to the latest IP catalog. The following information is included in the IP Status report:<br/>
		/// • Instance Name - The name of the IP core in the current project.<br/>
		/// • IP Status - A description of the state of the IP in the current project.<br/>
		/// • Recommendation - A recommended action based on the status.<br/>
		/// • Lock Status - An explanation of the lock status of the IP in the current project.<br/>
		/// • Change Log - A reference to the change log for the IP update in the catalog. This will provide a<br/>
		/// description of the changes in the latest IP.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • IP Name - The name of the IP core in the catalog.<br/>
		/// • IP Version - The version of the IP in use in the current project.<br/>
		/// • New Version - The latest version of the IP in the catalog.<br/>
		/// • New license - The license status for the new IP version.<br/>
		/// • Original Part - The original part associated with the IP in the catalog.<br/>
		/// IP cores that are out of date, or locked, may need to be upgraded and the output products<br/>
		/// regenerated. Refer to the Vivado Design Suite User Guide: Designing with IP (UG896) for more<br/>
		/// information.<br/>
		/// The report_ip_status command checks the available licenses on the local machine, or on the<br/>
		/// license server, for all IP cores in the current project. If a license can be found, the license<br/>
		/// information is printed. If the license cannot be found, this information is also printed.<br/>
		/// This command returns the IP status report, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the IP status to the specified file, appending the results if the file<br/>
		/// already exists:<br/>
		/// report_ip_status -file C:/Data/reports/ip_status.txt -append<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1386<br/>
		/// </para>
		/// </summary>
		/// <param name="name">
		/// <para>
		/// (Optional)<br/>
		/// Output the results to GUI panel with this name Values: The<br/>
		/// name of the GUI dialog<br/>
		/// </para>
		/// </param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to (send output to console if -file<br/>
		/// is not used) Values: The report filename<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append to existing file</param>
		/// <param name="return_string">(Optional) Return report as string</param>
		/// <param name="license_status">(Optional) Report the license status of the generated outputs for each IP</param>
		/// <param name="resource_data">(Optional) Report the resource data usage for each IP instance</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>True for success</returns>
		public TTCL report_ip_status(String name = null, String file = null, bool? append = null, bool? return_string = null, bool? license_status = null, bool? resource_data = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_ip_status [-name <arg>] [-file <arg>] [-append] [-return_string] [-license_status] [-resource_data] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_ip_status(name, file, append, return_string, license_status, resource_data, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Reset target data for the specified source<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_target [-quiet] [-verbose] &lt;name&gt; &lt;objects&gt;
		/// <br/>
		/// <para>
		/// Remove the current target data for the specified IP core. This deletes any files that were<br/>
		/// delivered during generation of the specified targets. This does not remove the core from the<br/>
		/// current project, but does remove the associated target data from its referenced location.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example resets the instantiation template for the specified IP core:<br/>
		/// reset_target instantiation_template [get_ips blk_mem*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1521<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) List of targets to be reset, or 'all' to reset all generated targets</param>
		/// <param name="objects">(Required) The objects for which data needs to be reset</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_target(TCLObject name, TCLObject objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_target [-quiet] [-verbose] <name> <objects>
			_tcl.Entry(_builder.reset_target(name, objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Generate a synthesis netlist for an IP<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: synth_ip [-force] [-quiet] [-verbose] &lt;objects&gt;
		/// <br/>
		/// <para>
		/// This command is used in the non-project flow to create a synthesized design checkpoint file<br/>
		/// (DCP) to support the out-of-context (OOC) IP flow, or to synthesize and implement an IP module<br/>
		/// in the OOC hierarchical design flow. IP objects are specified by the get_ips command, or for<br/>
		/// the specified IP core file (XCI) as specified by the get_files command.<br/>
		/// IMPORTANT! To enable this functionality, the IP core must be marked for OOC generation by setting the<br/>
		/// GENERATE_SYNTH_CHECKPOINT property to true (or 1) using the set_property command on the<br/>
		/// XCI file.<br/>
		/// For project-based designs you would use the create_ip_run and launch_runs commands.<br/>
		/// Refer to the Vivado Design Suite User Guide: Design Flows Overview (UG892) for more information<br/>
		/// on Project and Non-Project Modes in Vivado.<br/>
		/// The synth_ip command will automatically generate any required target files prior to<br/>
		/// synthesizing the IP core. The source files required to synthesize the IP are copied into the IP run<br/>
		/// directory. Upon completion, any newly generated OOC target files (dcp, stub files, funcsim<br/>
		/// netlists...) are registered with the associated IP core.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example synthesizes the specified IP object, regenerating the netlist if the<br/>
		/// synthesized core is up-to-date:<br/>
		/// synth_ip [get_ips char_fifo] -force<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1742<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) All the objects for which a netlist needs to be generated for.</param>
		/// <param name="force">(Optional) Force regeneration of the netlist.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL synth_ip(TCLObject objects, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: synth_ip [-force] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.synth_ip(objects, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Update the IP Catalog. Before executing this command optionally use the following to set<br/>
		/// repository paths:'set_property ip_repo_paths &lt;repo_path_list&gt; [current_fileset]'<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: update_ip_catalog [-rebuild] [-add_ip &lt;arg&gt;] [-delete_ip &lt;arg&gt;] [-delete_mult_ip &lt;args&gt;] [-disable_ip &lt;arg&gt;] [-enable_ip &lt;arg&gt;] [-add_interface &lt;arg&gt;] [-create_index] [-repo_path &lt;arg&gt;] [-update_module_ref] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Update the IP catalog associated with the current design.<br/>
		/// The Xilinx® IP catalog, or repository, is located in the installation hierarchy of the Vivado Design<br/>
		/// Suite software release being used. You can also add custom IP to the repository by using the<br/>
		/// set_property command to set the IP_REPO_PATHS property on the source fileset to point to<br/>
		/// the locations of custom IP, as shown in the example below.<br/>
		/// The update_ip_catalog command lets you add, delete, disable, or enable individual IP cores<br/>
		/// in the catalog. When referring to individual cores, you can reference them by the path to the<br/>
		/// component.xml file, or by referencing the VLNV property of the IP.<br/>
		/// TIP: The VLNV property refers to the Vendor:Library:Name:Version string which uniquely identifies the IP<br/>
		/// in the catalog.<br/>
		/// This command returns a transcript of its process if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets the IP_REPO_PATHS property of the current Source fileset, to add an<br/>
		/// IP repository, then rebuilds the IP catalog index for the whole IP catalog:<br/>
		/// set_property IP_REPO_PATHS C:/Data/IP_LIB [current_fileset]<br/>
		/// update_ip_catalog -rebuild<br/>
		/// This example disables the IP specified by its VLNV property from the specified IP repository:<br/>
		/// update_ip_catalog -disable_ip {myCo.com:ip:custom_decoder:1.0} \<br/>
		/// -repo_path C:/Data/ip<br/>
		/// This example disables the IP specified by the path to the component.xml file, from the IP<br/>
		/// repository:<br/>
		/// update_ip_catalog -disable_ip C:/Data/ip/custom_encoder_1/component.xml \<br/>
		/// -repo_path C:/Xilinx/Vivado/data/ip<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1772<br/>
		/// </para>
		/// </summary>
		/// <param name="rebuild">
		/// <para>
		/// (Optional)<br/>
		/// Trigger a rebuild of the specified repository's index file or<br/>
		/// rebuild all repositories if none specified<br/>
		/// </para>
		/// </param>
		/// <param name="add_ip">
		/// <para>
		/// (Optional)<br/>
		/// Add the specified IP into the specified repository Values:<br/>
		/// Either a path to the IP's component.xml or to a zip file<br/>
		/// containing the IP<br/>
		/// </para>
		/// </param>
		/// <param name="delete_ip">
		/// <para>
		/// (Optional)<br/>
		/// Remove the specified IP from the specified repository<br/>
		/// Values: Either a path to the IP's component.xml or its VLNV<br/>
		/// </para>
		/// </param>
		/// <param name="delete_mult_ip">
		/// <para>
		/// (Optional)<br/>
		/// Remove the specified IPs from the specified repository<br/>
		/// Values: A list of IPs; either paths to the component.xml files<br/>
		/// or their VLNVs<br/>
		/// </para>
		/// </param>
		/// <param name="disable_ip">
		/// <para>
		/// (Optional)<br/>
		/// Disable the specified IP from the specified repository<br/>
		/// Values: Either a path to the IP's component.xml or its VLNV<br/>
		/// </para>
		/// </param>
		/// <param name="enable_ip">
		/// <para>
		/// (Optional)<br/>
		/// Enable the specified disabled IP from the specified<br/>
		/// repository Values: Either a path to the IP's component.xml<br/>
		/// or its VLNV<br/>
		/// </para>
		/// </param>
		/// <param name="add_interface">
		/// <para>
		/// (Optional)<br/>
		/// Add the specified interface into the specified repository<br/>
		/// Values: A path to the interface's xml file<br/>
		/// </para>
		/// </param>
		/// <param name="create_index">(Optional) Cache the specified repository's data on disk, to improve load time.</param>
		/// <param name="repo_path">
		/// <para>
		/// (Optional)<br/>
		/// Used in conjunction with rebuild, add_ip, delete_ip,<br/>
		/// delete_mult_ip, disable_ip or create_index to specify the path<br/>
		/// of the repository on which to operate<br/>
		/// </para>
		/// </param>
		/// <param name="update_module_ref">(Optional) Update module reference from their source (e.g. HDL file)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>True for success</returns>
		public TTCL update_ip_catalog(bool? rebuild = null, String add_ip = null, String delete_ip = null, TCLParameterList delete_mult_ip = null, String disable_ip = null, String enable_ip = null, String add_interface = null, bool? create_index = null, String repo_path = null, bool? update_module_ref = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: update_ip_catalog [-rebuild] [-add_ip <arg>] [-delete_ip <arg>] [-delete_mult_ip <args>] [-disable_ip <arg>] [-enable_ip <arg>] [-add_interface <arg>] [-create_index] [-repo_path <arg>] [-update_module_ref] [-quiet] [-verbose]
			_tcl.Entry(_builder.update_ip_catalog(rebuild, add_ip, delete_ip, delete_mult_ip, disable_ip, enable_ip, add_interface, create_index, repo_path, update_module_ref, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Refresh module reference definition and instance(s)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: update_module_reference [-quiet] [-verbose] [&lt;ips&gt;...]
		/// <br/>
		/// <para>
		/// Refresh the block design cell or cells that reference module definitions from RTL source files by<br/>
		/// rereading the module definition from the source file.<br/>
		/// Note: This command does not cause the Vivado tool to reread the source file. If changes have been made<br/>
		/// to the source file it must be separately updated.<br/>
		/// This command returns a transcript of the update process as well as any warnings related to<br/>
		/// design changes, or returns nothing if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example updates the specified module references in the current design:<br/>
		/// update_module_reference {rtlRam_0 uart_0}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1779<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="ips">
		/// <para>
		/// (Optional)<br/>
		/// module reference to be upgraded Values: IP instance<br/>
		/// name(s) within the design<br/>
		/// </para>
		/// </param>
		/// <returns>A return code indicating success or failure.</returns>
		public TTCL update_module_reference(bool? quiet = null, bool? verbose = null, TCLObjectList ips = null)
		{
			// TCL Syntax: update_module_reference [-quiet] [-verbose] [<ips>...]
			_tcl.Entry(_builder.update_module_reference(quiet, verbose, ips));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Upgrade a configurable IP to a later version<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: upgrade_ip [-srcset &lt;arg&gt;] [-vlnv &lt;arg&gt;] [-log &lt;arg&gt;] [-quiet] [-verbose] &lt;objects&gt;...
		/// <br/>
		/// <para>
		/// This command upgrades the specified IP cores from an older version to the latest version in the<br/>
		/// IP catalog.<br/>
		/// You can only upgrade IP that explicitly supports upgrading. The UPGRADE_VERSIONS property<br/>
		/// on the ipdef object indicates if there are upgrade versions for an IP core.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// TIP: The upgrade_ip command also accepts Block Design cell IP instances as bd_cell objects. The<br/>
		/// command upgrades the bd_cell objects within the Block Design, and does not require the diagram to be<br/>
		/// open in the Vivado IP integrator .<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example upgrades all IP cores in the current project to the latest version:<br/>
		/// upgrade_ip [get_ips]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1788<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">
		/// <para>
		/// (Required)<br/>
		/// IP to be upgraded Values: IP instance(s) within the design,<br/>
		/// as returned by 'get_ips &lt;instance name&gt;' or 'get_bd_cells<br/>
		/// &lt;cell name&gt;'<br/>
		/// </para>
		/// </param>
		/// <param name="srcset">
		/// <para>
		/// (Optional)<br/>
		/// (Optional) Specifies the source file set containing the IP to<br/>
		/// be upgraded Default: The current source fileset Values:<br/>
		/// Source set name<br/>
		/// </para>
		/// </param>
		/// <param name="vlnv">
		/// <para>
		/// (Optional)<br/>
		/// (Optional) Identifies the Catalog IP to which the IP will be<br/>
		/// upgraded. The VLNV string maps to the IPDEF property on<br/>
		/// the IP core. This is a strict comparison, and the upgrade will<br/>
		/// fail if the identified IP does not exist in the Catalog. Default:<br/>
		/// Latest version of the current IP Values: A string of the form<br/>
		/// '&lt;vendor&gt;:&lt;library&gt;:&lt;name&gt;:&lt;versio n&gt;'<br/>
		/// </para>
		/// </param>
		/// <param name="log">
		/// <para>
		/// (Optional)<br/>
		/// (Optional) Identifies the log file to which the IP upgrade<br/>
		/// report will be concatenated. Default: An empty string,<br/>
		/// indicating that no log will be written Values: A file path to an<br/>
		/// existing writable file, or a non-existent file location in a<br/>
		/// writable directory<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>A return code indicating success or failure.</returns>
		public TTCL upgrade_ip(TCLObjectList objects, String srcset = null, String vlnv = null, String log = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: upgrade_ip [-srcset <arg>] [-vlnv <arg>] [-log <arg>] [-quiet] [-verbose] <objects>...
			_tcl.Entry(_builder.upgrade_ip(objects, srcset, vlnv, log, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// This command applies any pending set_property commands and returns parameter validation<br/>
		/// messages, if any exist<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: validate_ip [-save_ip] [-quiet] [-verbose] [&lt;ips&gt;]
		/// <br/>
		/// <para>
		/// Perform DRC check on IP to ensure that it is properly constructed. This command returns 1<br/>
		/// when all IPs have been validated, or 0 when there is a problem.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example validates the IPs in the current project, and updates the persistent<br/>
		/// representation of the IP.<br/>
		/// validate_ip -save_ip [get_ips]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1801<br/>
		/// </para>
		/// </summary>
		/// <param name="save_ip">(Optional) Write IP files on the disk</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="ips">(Optional) IPs to be validated</param>
		public TTCL validate_ip(bool? save_ip = null, bool? quiet = null, bool? verbose = null, TCLObject ips = null)
		{
			// TCL Syntax: validate_ip [-save_ip] [-quiet] [-verbose] [<ips>]
			_tcl.Entry(_builder.validate_ip(save_ip, quiet, verbose, ips));
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
		public TTCL write_ip_tcl(bool? force = null, bool? no_ip_version = null, String ip_name = null, bool? show_defaults = null, bool? multiple_files = null, bool? quiet = null, bool? verbose = null, TCLObject objects = null, TCLObjectList tcl_filename = null)
		{
			// TCL Syntax: write_ip_tcl [-force] [-no_ip_version] [-ip_name <arg>] [-show_defaults] [-multiple_files] [-quiet] [-verbose] [<objects>] [<tcl_filename>...]
			_tcl.Entry(_builder.write_ip_tcl(force, no_ip_version, ip_name, show_defaults, multiple_files, quiet, verbose, objects, tcl_filename));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Save peripheral component to the disk.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_peripheral [-quiet] [-verbose] &lt;peripheral&gt;
		/// <br/>
		/// <para>
		/// Write the specified AXI peripheral object to disk in the form of the component.xml file. The<br/>
		/// peripheral is written to the repository location specified by the create_peripheral<br/>
		/// command, under the name specified at creation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1876<br/>
		/// </para>
		/// </summary>
		/// <param name="peripheral">(Required) Peripheral object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_peripheral(TCLObject peripheral, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_peripheral [-quiet] [-verbose] <peripheral>
			_tcl.Entry(_builder.write_peripheral(peripheral, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
