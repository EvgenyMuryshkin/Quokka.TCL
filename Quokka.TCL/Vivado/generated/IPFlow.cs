// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class IPFlowCommands
	{
		private readonly TCLFile<VivadoTCL> _tcl;
		public IPFlowCommands(TCLFile<VivadoTCL> tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Add a new bus interface to a peripheral.
		///
		///
		/// TCL Syntax: add_peripheral_interface -interface_mode <arg> -axi_type <arg> [-quiet] [-verbose] <name> <peripheral>
		///
		/// Add an AXI bus interface to a peripheral created with the create_peripheral command.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 55
		/// </summary>
		/// <param name="interface_mode">
		/// Required
		/// Mode of an interface, supported option - master,slave.
		/// </param>
		/// <param name="axi_type">
		/// Required
		/// Type of a axi interface, supported option - lite,full,stream.
		/// </param>
		/// <param name="name">
		/// Required
		/// Name to initialize the newly added element e.g S1_AXI,
		/// M1_AXI
		/// </param>
		/// <param name="peripheral">
		/// Required
		/// Peripheral object
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void add_peripheral_interface(string interface_mode, string axi_type, string name, string peripheral, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: add_peripheral_interface -interface_mode <arg> -axi_type <arg> [-quiet] [-verbose] <name> <peripheral>
			_tcl.Add(
				new SimpleTCLCommand("add_peripheral_interface")
					.RequiredNamedString("interface_mode", interface_mode)
					.RequiredNamedString("axi_type", axi_type)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.RequiredString(name)
					.RequiredString(peripheral)
			);
		}
		/// <summary>
		/// Compile C code into RTL
		///
		///
		/// TCL Syntax: compile_c [-force] [-quiet] [-verbose] <objects>
		///
		/// In IP cores that are imported from Vivado HLS, the compile_c command detects C, C++, and
		/// SystemC files and converts those files to RTL for synthesis by the Vivado Design Suite.
		/// This lets you use Vivado HLS to describe IP cores in a high-level language, like C or C++ rather
		/// than RTL.
		/// When HLS-based IP cores are generated, they only deliver the C source. When the HLS-based IP
		/// is synthesized, either in the out-of-context flow, or with the top-level design, the compile_c
		/// command launches Vivado HLS to convert the C source files into RTL, and import the resulting
		/// RTL sources back into the design prior to synthesis.
		/// RECOMMENDED: The compile_c command is automatically called by the Vivado Design Suite when it
		/// encounters IP with C code from the Vivado HLS system. You should not need to manually call this command.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 159
		/// </summary>
		/// <param name="objects">
		/// Required
		/// The objects which need C to RTL conversion
		/// </param>
		/// <param name="force">
		/// Optional
		/// Force generate product state regeneration
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void compile_c(string objects, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: compile_c [-force] [-quiet] [-verbose] <objects>
			_tcl.Add(
				new SimpleTCLCommand("compile_c")
					.Flag("force", force)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.RequiredString(objects)
			);
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
		/// <param name="use_cache_location">
		/// Optional
		/// Set current project properties to use the specified cache
		/// location
		/// </param>
		/// <param name="use_project_cache">
		/// Optional
		/// Set current project properties to use the default project IP
		/// cache location
		/// </param>
		/// <param name="disable_cache">
		/// Optional
		/// Disable cache use.
		/// </param>
		/// <param name="clear_output_repo">
		/// Optional
		/// Delete from disk and in memory all cache entries that exist
		/// in the current project's designated cache (local or remote).
		/// </param>
		/// <param name="clear_local_cache">
		/// Optional
		/// Delete from disk and in memory all local cache entries for
		/// this project.
		/// </param>
		/// <param name="cache_has_match">
		/// Optional
		/// Returns the cache-ID of the cache entry that would work for
		/// this IP instance; else ''.
		/// </param>
		/// <param name="cache_was_used">
		/// Optional
		/// Returns '1' if the cache was used to obtain the IP's current
		/// synthesis results; else '0'.
		/// </param>
		/// <param name="get_id">
		/// Optional
		/// Calculate and return IP cache ID string for specified <ip>
		/// </param>
		/// <param name="remove">
		/// Optional
		/// Remove the corresponding cache entry for the specified IP
		/// instance or specified cachedInst; return cache ID string if
		/// successful, otherwise blank.
		/// </param>
		/// <param name="vlnv">
		/// Optional
		/// Used with -purge or -get_resource_data, specifies the VLNV
		/// of the cache entries to delete or find. May use a wildcard
		/// ('*') in one or more fields in the VLNV.
		/// </param>
		/// <param name="old_swvers">
		/// Optional
		/// Used with -purge to delete cache entries created with old
		/// Vivado SW Versions.
		/// </param>
		/// <param name="unused">
		/// Optional
		/// Used with -purge to delete cache entries that have never
		/// been used.
		/// </param>
		/// <param name="swver">
		/// Optional
		/// Used with -purge to delete any cache entries created from
		/// this specific Vivado SW Version (i.e., '2017.1').
		/// </param>
		/// <param name="num_days_old">
		/// Optional
		/// Used with -purge to delete any cache entries that are this
		/// number of days old or older.
		/// </param>
		/// <param name="num_days_unused">
		/// Optional
		/// Used with -purge to delete any cache entries that have not
		/// been used for this number of days or longer.
		/// </param>
		/// <param name="obs_synth_crc">
		/// Optional
		/// Used with -purge to delete cache entries whose component
		/// synth checksum is not the same as the IP Catalog's current
		/// component synthesis checksum.
		/// Name Description
		/// </param>
		/// <param name="disk_usage_output_repo">
		/// Optional
		/// Return total disk usage in MB for all cache entries in the
		/// current project's ip_output_repo.
		/// </param>
		/// <param name="report">
		/// Optional
		/// Report cache statistics for the specified IP or cache object,
		/// or for the current cache location if none specified. If -rptfile
		/// is specified, write statistics to that file. If -dir is specified,
		/// write statistics for cache entries found under that directory.
		/// </param>
		/// <param name="rptfile">
		/// Optional
		/// Used with -report, specifies the text file to write the cache
		/// statistics to.
		/// </param>
		/// <param name="csvfile">
		/// Optional
		/// Used with -report, specifies the csv file to write the cache
		/// statistics to, in csv format.
		/// </param>
		/// <param name="import_from_project">
		/// Optional
		/// Import existing synthesized IP from the project into the
		/// cache.
		/// </param>
		/// <param name="filter">
		/// Optional
		/// Filter result of '-list'
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Use regular expressions instead of globs in '-filter'
		/// argument(s)
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// Use case insensitive matching in '-filter' argument(s)
		/// </param>
		/// <param name="purge">
		/// Optional
		/// Delete all cache entries that match the specified type(s): -
		/// vlnv, -obs_swvers, -obs_synth_crc, and/or -swver. Returns
		/// the number of entries deleted.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="ip">
		/// Optional
		/// IP instance object, IP file, or IP name pattern
		/// </param>
		public void config_ip_cache(string use_cache_location = null, bool? use_project_cache = null, bool? disable_cache = null, bool? clear_output_repo = null, bool? clear_local_cache = null, bool? cache_has_match = null, bool? cache_was_used = null, bool? get_id = null, bool? remove = null, string vlnv = null, bool? old_swvers = null, bool? unused = null, string swver = null, string num_days_old = null, string num_days_unused = null, bool? obs_synth_crc = null, bool? disk_usage_output_repo = null, bool? report = null, string rptfile = null, string csvfile = null, bool? import_from_project = null, string filter = null, bool? regexp = null, bool? nocase = null, bool? purge = null, bool? quiet = null, bool? verbose = null, string ip = null)
		{
			// TCL Syntax: config_ip_cache [-use_cache_location <arg>] [-use_project_cache] [-disable_cache] [-clear_output_repo] [-clear_local_cache] [-cache_has_match] [-cache_was_used] [-get_id] [-remove] [-vlnv <arg>] [-old_swvers] [-unused] [-swver <arg>] [-num_days_old <arg>] [-num_days_unused <arg>] [-obs_synth_crc] [-disk_usage_output_repo] [-report] [-rptfile <arg>] [-csvfile <arg>] [-import_from_project] [-filter <arg>] [-regexp] [-nocase] [-purge] [-quiet] [-verbose] [<ip>]
			_tcl.Add(
				new SimpleTCLCommand("config_ip_cache")
					.OptionalNamedString("use_cache_location", use_cache_location)
					.Flag("use_project_cache", use_project_cache)
					.Flag("disable_cache", disable_cache)
					.Flag("clear_output_repo", clear_output_repo)
					.Flag("clear_local_cache", clear_local_cache)
					.Flag("cache_has_match", cache_has_match)
					.Flag("cache_was_used", cache_was_used)
					.Flag("get_id", get_id)
					.Flag("remove", remove)
					.OptionalNamedString("vlnv", vlnv)
					.Flag("old_swvers", old_swvers)
					.Flag("unused", unused)
					.OptionalNamedString("swver", swver)
					.OptionalNamedString("num_days_old", num_days_old)
					.OptionalNamedString("num_days_unused", num_days_unused)
					.Flag("obs_synth_crc", obs_synth_crc)
					.Flag("disk_usage_output_repo", disk_usage_output_repo)
					.Flag("report", report)
					.OptionalNamedString("rptfile", rptfile)
					.OptionalNamedString("csvfile", csvfile)
					.Flag("import_from_project", import_from_project)
					.OptionalNamedString("filter", filter)
					.Flag("regexp", regexp)
					.Flag("nocase", nocase)
					.Flag("purge", purge)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.OptionalString(ip)
			);
		}
		/// <summary>
		/// Convert specified IP to or from core container format.
		///
		///
		/// TCL Syntax: convert_ips [-force] [-to_core_container] [-from_core_container] [-quiet] [-verbose] <objects>
		///
		/// This command converts existing IP into core container format, or reverts core container IP into
		/// the expanded non-core container format.
		/// The core container format for IP is a compressed zip file that reduces the file structure in the
		/// design, and increases tool performance.
		/// By default, the Vivado tool adds IP from the Xilinx IP catalog into a design using the core
		/// container format. However, the convert_ips command lets you convert IP in existing designs
		/// to take advantage of the core container format. In addition, the convert_ips command also
		/// lets you revert the compressed core container format into the expanded non-core container
		/// format.
		/// TIP: If neither -to_core_container or -from_core_container options are specified then the
		/// convert_ips command will convert the IP from its current format into the opposite form. Any core container
		/// IP will be converted to non-core container format, and any non-core container IP will be converted to core
		/// container format.
		/// IP that is user-managed, cannot be converted from its current format. IP that is locked requires
		/// the use of the -force option to convert. Refer to the Vivado Design Suite User Guide: Designing
		/// with IP (UG896) for more information on editing IP and the IS_LOCKED and IS_MANAGED
		/// properties.
		/// This command returns a transcript of its actions, or returns an error if it fails.
		///
		/// The following example converts all IP in the current project into core container format:
		/// convert_ips -to_core_container [get_ips]
		/// Note: Any IP already in the core container format will be skipped.
		/// The following example converts the specified IP file to core container format:
		/// convert_ips -to_core_container \
		/// [get_files C:/Data/wave1/wave1.srcs/sources_1/ip/char_fifo/char_fifo.xci]
		/// The following example toggles the current format of all IP in the design, switching from core
		/// container to non-core container, and from non-core container to core container:
		/// convert_ips [get_ips]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 205
		/// </summary>
		/// <param name="objects">
		/// Required
		/// Input objects for the IP. May IP or source file objects
		/// </param>
		/// <param name="force">
		/// Optional
		/// Force conversion even if the IP is locked.
		/// </param>
		/// <param name="to_core_container">
		/// Optional
		/// Convert IP to core container format.
		/// </param>
		/// <param name="from_core_container">
		/// Optional
		/// Convert IP to non core container format.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void convert_ips(string objects, bool? force = null, bool? to_core_container = null, bool? from_core_container = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: convert_ips [-force] [-to_core_container] [-from_core_container] [-quiet] [-verbose] <objects>
			_tcl.Add(
				new SimpleTCLCommand("convert_ips")
					.Flag("force", force)
					.Flag("to_core_container", to_core_container)
					.Flag("from_core_container", from_core_container)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.RequiredString(objects)
			);
		}
		/// <summary>
		/// Copy an existing IP
		///
		///
		/// TCL Syntax: copy_ip -name <arg> [-dir <arg>] [-quiet] [-verbose] <objects>...
		///
		/// Create a copy of an IP core that has been previously instanced into the current project.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 213
		/// </summary>
		/// <param name="name">
		/// Required
		/// Name of copied IP
		/// </param>
		/// <param name="objects">
		/// Required
		/// IP to be copied
		/// </param>
		/// <param name="dir">
		/// Optional
		/// Directory path for remote IP to be created and managed
		/// outside the project
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>IP file object that was added to the project</returns>
		public void copy_ip(string name, string objects, string dir = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: copy_ip -name <arg> [-dir <arg>] [-quiet] [-verbose] <objects>...
			_tcl.Add(
				new SimpleTCLCommand("copy_ip")
					.RequiredNamedString("name", name)
					.OptionalNamedString("dir", dir)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.RequiredString(objects)
			);
		}
		/// <summary>
		/// Create an instance of a configurable IP and add it to the fileset
		///
		///
		/// TCL Syntax: create_ip [-vlnv <arg>] -module_name <arg> [-dir <arg>] [-force] [-allow_hidden] [-vendor <arg>] [-library <arg>] [-name <arg>] [-version <arg>] [-revision <arg>] [-quiet] [-verbose]
		///
		/// This command creates an XCI file for a configurable IP core from the IP catalog, and adds it to the
		/// source files of the current project. This creates an IP source object which must be instantiated
		/// into the HDL design to create an instance of the IP core in the netlist.
		/// For multiple instances of the same core, simply instantiate the core module into the HDL design
		/// as many times as needed. However, to use the same IP core with different customizations, use
		/// the create_ip command to create separate IP source objects.
		/// The create_ip command is used to import IP cores from the current IP catalog. Use the
		/// import_ip command to read existing XCI and XCO files directly, without having to add IP to a
		/// catalog.
		/// This command returns a transcript of the IP generation process, concluding with the file path and
		/// name of the imported IP core file.
		/// Note: IP cores are native to Vivado, and can be customized and regenerated within that tool. The
		/// convert_ip command lets you to convert legacy IP to native IP supported by Vivado.
		///
		/// The example below imports the IP core specified by the -vlnv string, and gives it the specified
		/// module name in the current project:
		/// create_ip -vlnv xilinx.com:ip:c_addsub:11.0 -module_name test_addr
		/// The following example, from Vivado, creates an IP block with the specified -vendor, -
		/// library, -name, -version values, and assigns it the specified module name. After the IP is
		/// created, attributes of the IP are customized using set_property commands. Then the
		/// instantiation template and the synthesis targets are generated for the IP:
		/// create_ip -name c_addsub -version 11.0 -vendor xilinx.com -library ip \
		/// -module_name c_addsub_v11_0_0
		/// set_property CONFIG.COMPONENT_NAME c_addsub_v11_0_0 \
		/// [get_ips c_addsub_v11_0_0]
		/// set_property CONFIG.A_WIDTH 32 [get_ips c_addsub_v11_0_0]
		/// set_property CONFIG.B_WIDTH 32 [get_ips c_addsub_v11_0_0]
		/// set_property CONFIG.ADD_MODE Add_Subtract [get_ips c_addsub_v11_0_0]
		/// set_property CONFIG.C_IN true [get_ips c_addsub_v11_0_0]
		/// generate_target {instantiation_template synthesis} \
		/// [get_files C:/Data/c_addsub_v11_0_0/c_addsub_v11_0_0.xci \
		/// -of_objects [get_filesets sources_1]]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 307
		/// </summary>
		/// <param name="module_name">
		/// Required
		/// Name for the new IP that will be added to the project
		/// </param>
		/// <param name="vlnv">
		/// Optional
		/// VLNV string for the Catalog IP from which the new IP will be
		/// created (colon delimited Vendor, Library, Name, Version)
		/// </param>
		/// <param name="dir">
		/// Optional
		/// Directory path for remote IP to be created and managed
		/// outside the project
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite existing IP instance; allowed only with -dir option
		/// </param>
		/// <param name="allow_hidden">
		/// Optional
		/// Allow hidden cores to be instantiated
		/// </param>
		/// <param name="vendor">
		/// Optional
		/// IP Vendor name
		/// </param>
		/// <param name="library">
		/// Optional
		/// IP Library name
		/// </param>
		/// <param name="name">
		/// Optional
		/// IP Name
		/// </param>
		/// <param name="version">
		/// Optional
		/// IP Version
		/// </param>
		/// <param name="revision">
		/// Optional
		/// (Optional) IP core revision
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>list of file objects that were added</returns>
		public void create_ip(string module_name, string vlnv = null, string dir = null, bool? force = null, bool? allow_hidden = null, string vendor = null, string library = null, string name = null, string version = null, string revision = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_ip [-vlnv <arg>] -module_name <arg> [-dir <arg>] [-force] [-allow_hidden] [-vendor <arg>] [-library <arg>] [-name <arg>] [-version <arg>] [-revision <arg>] [-quiet] [-verbose]
			_tcl.Add(
				new SimpleTCLCommand("create_ip")
					.OptionalNamedString("vlnv", vlnv)
					.RequiredNamedString("module_name", module_name)
					.OptionalNamedString("dir", dir)
					.Flag("force", force)
					.Flag("allow_hidden", allow_hidden)
					.OptionalNamedString("vendor", vendor)
					.OptionalNamedString("library", library)
					.OptionalNamedString("name", name)
					.OptionalNamedString("version", version)
					.OptionalNamedString("revision", revision)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
			);
		}
		/// <summary>
		/// Creates a run for the given IP.
		///
		///
		/// TCL Syntax: create_ip_run [-force] [-quiet] [-verbose] <objects>
		///
		/// Defines a synthesis and implementation run for a single IP object as specified by the get_ips
		/// command, or for the specified IP core file (XCI) as specified by the get_files command.
		/// The IP run is used to generate the synthesis design checkpoint file (DCP) to support the out-of￾context (OOC) IP flow, or to synthesize and implement an IP module in the OOC hierarchical
		/// design flow.
		/// Two runs are created: one for synthesis, and one for implementation. The runs are named after
		/// the IP core and the run type, <ip_name>_synth_1 and <ip_name>_impl_1.
		/// The IP source files required to synthesize the run are copied into the IP run directory. The
		/// attributes of the run can be configured with the use of the set_property command.
		/// This command returns the name of the synthesis run created for the IP module.
		///
		/// The following example creates synthesis and implementation runs for the specified IP module:
		/// create_ip_run [get_ips add1]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 310
		/// </summary>
		/// <param name="objects">
		/// Required
		/// All of the IP objects (from get_ips or get_files) for which a
		/// run needs to be generated for.
		/// </param>
		/// <param name="force">
		/// Optional
		/// Force regeneration of products of the given IP.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void create_ip_run(string objects, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_ip_run [-force] [-quiet] [-verbose] <objects>
			_tcl.Add(
				new SimpleTCLCommand("create_ip_run")
					.Flag("force", force)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.RequiredString(objects)
			);
		}
		/// <summary>
		/// Create a peripheral with a VLNV.
		///
		///
		/// TCL Syntax: create_peripheral [-dir <arg>] [-quiet] [-verbose] <vendor> <library> <name> <version>
		///
		/// Create an AXI peripheral to add to the IP repository with the specified VLNV attribute.
		/// The AXI peripheral that is created is just a framework until interfaces have been added to the
		/// peripheral using the add_peripheral_interface command, and the peripheral has been
		/// generated using the generate_peripheral command.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 320
		/// </summary>
		/// <param name="vendor">
		/// Required
		/// Vendor, for example xilinx.com
		/// </param>
		/// <param name="library">
		/// Required
		/// Library, for example ip
		/// </param>
		/// <param name="name">
		/// Required
		/// Name, for example myip
		/// </param>
		/// <param name="version">
		/// Required
		/// Version, for example 1.4
		/// </param>
		/// <param name="dir">
		/// Optional
		/// Directory path for remote Peripheral to be created and
		/// managed outside the project
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void create_peripheral(string vendor, string library, string name, string version, string dir = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_peripheral [-dir <arg>] [-quiet] [-verbose] <vendor> <library> <name> <version>
			_tcl.Add(
				new SimpleTCLCommand("create_peripheral")
					.OptionalNamedString("dir", dir)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.RequiredString(vendor)
					.RequiredString(library)
					.RequiredString(name)
					.RequiredString(version)
			);
		}
		/// <summary>
		/// Deletes the block fileset and run associated with a given IP.
		///
		///
		/// TCL Syntax: delete_ip_run [-force] [-quiet] [-verbose] <objects>
		///
		/// Deletes the out-of-context (OOC) synthesis and implementation runs for the specified IP
		/// module.
		/// The contents of the run directory are deleted from the project as well as the run. However, the
		/// output products created by the run and copied to the IP sources folder, the DCP file and Verilog
		/// and VHDL structural netlists, are not deleted from the project. You must use the reset_target
		/// or generate_target command to update the IP output products.
		/// IMPORTANT! The command requires an IP object as specified by the get_ips or get_files command,
		/// and will not delete a run based on either the name of the run, or a run object as returned by get_runs.
		///
		/// The following example deletes the OOC synthesis and implementation runs from the specified IP
		/// module:
		/// delete_ip_run [get_ips add1]
		/// Note: In this example, all run results will also be removed from the run directory on the hard drive.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 446
		/// </summary>
		/// <param name="objects">
		/// Required
		/// All of the IP objects (from get_ips or get_files) for which the
		/// block fileset and run will be deleted.
		/// </param>
		/// <param name="force">
		/// Optional
		/// Force the deletion of the block fileset and run.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void delete_ip_run(string objects, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_ip_run [-force] [-quiet] [-verbose] <objects>
			_tcl.Add(
				new SimpleTCLCommand("delete_ip_run")
					.Flag("force", force)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.RequiredString(objects)
			);
		}
		/// <summary>
		/// Extract files from a core container to disk
		///
		///
		/// TCL Syntax: extract_files [-base_dir <arg>] [-force] [-no_ip_dir] [-no_paths] [-quiet] [-verbose] <files>...
		///
		/// Extract the files from an IP in core container format.
		/// The core container format for IP is a compressed zip file that reduces the file structure in the
		/// design, and increases tool performance.
		/// This command returns a list of files extracted from the core container IP, or returns an error if it
		/// fails.
		///
		/// The following example extracts the files from the specified core container format IP to the
		/// specified base directory:
		/// extract_files -base_dir C:/Data [get_files char_fifo.xcix]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 513
		/// </summary>
		/// <param name="files">
		/// Required
		/// Name of the file(s) to be extracted
		/// </param>
		/// <param name="base_dir">
		/// Optional
		/// Base directory for extracted files Default: ip_files
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite existing files
		/// </param>
		/// <param name="no_ip_dir">
		/// Optional
		/// Don't include the IP dir as part of the extract directory
		/// </param>
		/// <param name="no_paths">
		/// Optional
		/// Don't include directories when extracting files
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>list of files that were extracted with the new paths</returns>
		public void extract_files(string files, string base_dir = null, bool? force = null, bool? no_ip_dir = null, bool? no_paths = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: extract_files [-base_dir <arg>] [-force] [-no_ip_dir] [-no_paths] [-quiet] [-verbose] <files>...
			_tcl.Add(
				new SimpleTCLCommand("extract_files")
					.OptionalNamedString("base_dir", base_dir)
					.Flag("force", force)
					.Flag("no_ip_dir", no_ip_dir)
					.Flag("no_paths", no_paths)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.RequiredString(files)
			);
		}
		/// <summary>
		/// Generate output products for peripheral object.
		///
		///
		/// TCL Syntax: generate_peripheral [-driver] [-example_design] [-bfm_example_design] [-debug_hw_example_design] [-enable_interrupt] [-force] [-quiet] [-verbose] <peripheral>
		///
		/// Generate the output products for the specified peripheral object. The output products are
		/// written to the IP repository location specified when the IP is created by the
		/// create_peripheral command, under the name of the IP as specified at creation.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 532
		/// </summary>
		/// <param name="peripheral">
		/// Required
		/// peripheral object
		/// </param>
		/// <param name="driver">
		/// Optional
		/// Generate driver for peripheral.
		/// </param>
		/// <param name="example_design">
		/// Optional
		/// Generate all supported example designs for peripheral.
		/// </param>
		/// <param name="bfm_example_design">
		/// Optional
		/// Generate bfm simulation example design for peripheral.
		/// </param>
		/// <param name="debug_hw_example_design">
		/// Optional
		/// Generate debug hardware example design for peripheral.
		/// </param>
		/// <param name="enable_interrupt">
		/// Optional
		/// Generate peripheral with interrupt suppport.
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite the existing IP in the repository.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void generate_peripheral(string peripheral, bool? driver = null, bool? example_design = null, bool? bfm_example_design = null, bool? debug_hw_example_design = null, bool? enable_interrupt = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_peripheral [-driver] [-example_design] [-bfm_example_design] [-debug_hw_example_design] [-enable_interrupt] [-force] [-quiet] [-verbose] <peripheral>
			_tcl.Add(
				new SimpleTCLCommand("generate_peripheral")
					.Flag("driver", driver)
					.Flag("example_design", example_design)
					.Flag("bfm_example_design", bfm_example_design)
					.Flag("debug_hw_example_design", debug_hw_example_design)
					.Flag("enable_interrupt", enable_interrupt)
					.Flag("force", force)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.RequiredString(peripheral)
			);
		}
		/// <summary>
		/// Generate target data for the specified source
		///
		///
		/// TCL Syntax: generate_target [-force] [-quiet] [-verbose] <name> <objects>
		///
		/// This command generates target data for the specified IP objects (get_ips) or source file for IP
		/// cores (.xci and .xco), DSP modules (.slx or .mdl), or block designs (.bd). The target data
		/// that is generated are the files necessary to support the IP or block design through the FPGA
		/// design flow.
		/// The instantiation template, synthesis netlist, and simulation netlist are standard targets. However,
		/// each IP in the catalog may also support its own set of targets. You can view the available targets
		/// on an object by examining the SUPPORTED_TARGETS property, or you can use the
		/// list_targets command to list the targets for design source file.
		///
		/// This example generates the change log for all of the IP cores in the current project, forcing
		/// regeneration of any targets that are up-to-date:
		/// generate_target changelog [get_ips] -force
		/// The following example generates the instantiation template and synthesis targets for all of the IP
		/// cores in the current project:
		/// generate_target {instantiation_template synthesis} [get_ips]
		/// TIP: Note the use of the braces to pass the list of targets to the command. The absence of the -force option
		/// means that only out-of-date targets will be regenerated.
		/// The following example generates all targets for the specified block design:
		/// generate_target all \
		/// [get_files C:/Data/project_mb/project_mb.srcs/sources_1/bd/base_mb/
		/// base_mb.bd]
		/// IMPORTANT! The use of get_ips is not supported to generate targets for individual IP within block designs.
		/// The tool will return an error.
		/// The following queries the SUPPORTED_TARGETS property of the specified IP object, and then
		/// generates the example project for the IP:
		/// get_property SUPPORTED_TARGETS [get_ips blk_mem*]
		/// open_example_project -dir C:/Data/examples -force [get_ips blk_mem*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 539
		/// </summary>
		/// <param name="name">
		/// Required
		/// List of targets to be generated, or 'all' to generate all
		/// supported targets
		/// </param>
		/// <param name="objects">
		/// Required
		/// The objects for which data needs to be generated
		/// </param>
		/// <param name="force">
		/// Optional
		/// Force target data regeneration
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void generate_target(string name, string objects, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_target [-force] [-quiet] [-verbose] <name> <objects>
			_tcl.Add(
				new SimpleTCLCommand("generate_target")
					.Flag("force", force)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.RequiredString(name)
					.RequiredString(objects)
			);
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
		/// Optional
		/// (Optional) Specifies the source file set containing the
		/// upgraded IP Default: The current source fileset Values:
		/// Source set name
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
		/// IP to be upgraded Values: IP instance(s) within the design,
		/// as returned by 'get_ips <instance name>' or 'get_bd_cells
		/// <cell name>'
		/// </param>
		/// <returns>list of IP upgrade results</returns>
		public void get_ip_upgrade_results(string srcset = null, bool? quiet = null, bool? verbose = null, string objects = null)
		{
			// TCL Syntax: get_ip_upgrade_results [-srcset <arg>] [-quiet] [-verbose] [<objects>...]
			_tcl.Add(
				new SimpleTCLCommand("get_ip_upgrade_results")
					.OptionalNamedString("srcset", srcset)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.OptionalString(objects)
			);
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
		/// <param name="name">
		/// Optional
		/// Match the pattern against IP display name instead of VLNV
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// Perform case-insensitive matching
		/// </param>
		/// <param name="filter">
		/// Optional
		/// Filter list with expression
		/// </param>
		/// <param name="of_objects">
		/// Optional
		/// Get the IPDefs of the objects specified: IP inst or XCI file.
		/// </param>
		/// <param name="all">
		/// Optional
		/// Return hidden IP
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
		/// The patterns to match against Default: * Values: The default
		/// search pattern is the wildcard *, or .* when -regexp is
		/// specified.
		/// </param>
		/// <returns>List of Catalog IP objects</returns>
		public void get_ipdefs(bool? name = null, bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? all = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_ipdefs [-name] [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-all] [-quiet] [-verbose] [<patterns>...]
			_tcl.Add(
				new SimpleTCLCommand("get_ipdefs")
					.Flag("name", name)
					.Flag("regexp", regexp)
					.Flag("nocase", nocase)
					.OptionalNamedString("filter", filter)
					.OptionalNamedString("of_objects", of_objects)
					.Flag("all", all)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.OptionalString(patterns)
			);
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
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// Perform case-insensitive matching
		/// </param>
		/// <param name="all">
		/// Optional
		/// Include subcore IP in search
		/// </param>
		/// <param name="filter">
		/// Optional
		/// Filter list with expression
		/// </param>
		/// <param name="exclude_bd_ips">
		/// Optional
		/// Exclude all IP owned by a block design.
		/// </param>
		/// <param name="of_objects">
		/// Optional
		/// Get 'ip' objects of these types: 'ip file'.
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
		/// Match IP names against patterns Default: * Values: The
		/// default search pattern is the wildcard *, or .* when -regexp
		/// is specified.
		/// </param>
		/// <returns>list of IP objects</returns>
		public void get_ips(bool? regexp = null, bool? nocase = null, bool? all = null, string filter = null, bool? exclude_bd_ips = null, string of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_ips [-regexp] [-nocase] [-all] [-filter <arg>] [-exclude_bd_ips] [-of_objects <args>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Add(
				new SimpleTCLCommand("get_ips")
					.Flag("regexp", regexp)
					.Flag("nocase", nocase)
					.Flag("all", all)
					.OptionalNamedString("filter", filter)
					.Flag("exclude_bd_ips", exclude_bd_ips)
					.OptionalNamedString("of_objects", of_objects)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.OptionalString(patterns)
			);
		}
		/// <summary>
		/// Import an IP file and add it to the fileset
		///
		///
		/// TCL Syntax: import_ip [-srcset <arg>] [-name <arg>] [-quiet] [-verbose] [<files>]
		///
		/// Adds an existing XCI or XCO file as an IP source into the current project, and copies it into the
		/// local project directory structure.
		/// The import_ip command allows you to read existing IP files directly, and copy them into the
		/// local project folders. Use the read_ip or add_files command to add IP files by reference into
		/// the current project.
		/// Use the create_ip command to create new IP files from the current IP catalog.
		///
		/// The following example copies the 10gig ethernet core into the current project, and assigns it a
		/// name of IP_block1:
		/// import_ip C:/Data/FPGA_Design/10gig_eth.xci -name IP_block1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 965
		/// </summary>
		/// <param name="srcset">
		/// Optional
		/// (Optional) Specifies the source file set containing the objects
		/// to be upgraded Default: The current source fileset Values:
		/// Source set name
		/// </param>
		/// <param name="name">
		/// Optional
		/// (Optional) Specifies a replacement name for the imported
		/// IP; may not be used with multiple files. Default: The current
		/// name for the imported IP Values: The new name for the
		/// imported IP
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="files">
		/// Optional
		/// Names of the IP files to be imported Values: A list of XCI
		/// (and/or XCO) file name(s)
		/// </param>
		/// <returns>list of file objects that were added</returns>
		public void import_ip(string srcset = null, string name = null, bool? quiet = null, bool? verbose = null, string files = null)
		{
			// TCL Syntax: import_ip [-srcset <arg>] [-name <arg>] [-quiet] [-verbose] [<files>]
			_tcl.Add(
				new SimpleTCLCommand("import_ip")
					.OptionalNamedString("srcset", srcset)
					.OptionalNamedString("name", name)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.OptionalString(files)
			);
		}
		/// <summary>
		/// Open the example project for the indicated IP
		///
		///
		/// TCL Syntax: open_example_project [-dir <arg>] [-force] [-in_process] [-quiet] [-verbose] <objects>...
		///
		/// Open an example project for the specified IP cores. The example project can be used to explore
		/// the features of the IP core in a stand-alone project, instead of integrated into the current project.
		///
		/// The following copies the IP customization and opens the example project for the specified IP
		/// core in a new location:
		/// open_example_project -dir C:/Data/examples -force [get_ips blk_mem*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1054
		/// </summary>
		/// <param name="objects">
		/// Required
		/// The objects whose example projects will be opened
		/// </param>
		/// <param name="dir">
		/// Optional
		/// Path to directory where example project will be created
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite an example project if it exists
		/// </param>
		/// <param name="in_process">
		/// Optional
		/// Open the example project in the same process
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>The Project that was opened</returns>
		public void open_example_project(string objects, string dir = null, bool? force = null, bool? in_process = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: open_example_project [-dir <arg>] [-force] [-in_process] [-quiet] [-verbose] <objects>...
			_tcl.Add(
				new SimpleTCLCommand("open_example_project")
					.OptionalNamedString("dir", dir)
					.Flag("force", force)
					.Flag("in_process", in_process)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.RequiredString(objects)
			);
		}
		/// <summary>
		/// Read one or more IP files
		///
		///
		/// TCL Syntax: read_ip [-quiet] [-verbose] <files>
		///
		/// Read the specified list of IP files (XCI) and add them to the design and the current fileset. Files are
		/// added by reference into the current project, just as in the add_files command.
		/// You can use this command to read the contents of source files into the in-memory design, when
		/// running the Vivado tool in Non Project mode, in which there is no project file to maintain and
		/// manage the various project source files. Refer to the Vivado Design Suite User Guide: Design Flows
		/// Overview (UG892) for more information on Non Project mode.
		/// When using the read_ip command all output products associated with the IP core, including
		/// the design checkpoint file (DCP) will be read into the in-memory design.
		/// TIP: In the project-based design flow, the Vivado tool will automatically generate the necessary output products
		/// associated with an IP core. However, in a non-project flow you must generate the necessary output products
		/// using the synth_ip or generate_target commands. For more information on working with IP refer to the
		/// Vivado Design Suite User Guide: Designing with IP (UG896).
		/// Use the import_ip command to add the IP cores and import the files into the local project
		/// directory.
		/// This command returns the list of files read.
		///
		/// The following example reads the specified IP files:
		/// read_ip C:/test_ip/char_fifo.xci
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1146
		/// </summary>
		/// <param name="files">
		/// Required
		/// IP file name(s)
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>list of IP file objects that were added</returns>
		public void read_ip(string files, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_ip [-quiet] [-verbose] <files>
			_tcl.Add(
				new SimpleTCLCommand("read_ip")
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.RequiredString(files)
			);
		}
		/// <summary>
		/// Report on the status of the IP instances in the project.
		///
		///
		/// TCL Syntax: report_ip_status [-name <arg>] [-file <arg>] [-append] [-return_string] [-license_status] [-resource_data] [-quiet] [-verbose]
		///
		/// This command examines the IP cores in the current project, and reports the state of the IP with
		/// regard to the latest IP catalog. The following information is included in the IP Status report:
		/// • Instance Name - The name of the IP core in the current project.
		/// • IP Status - A description of the state of the IP in the current project.
		/// • Recommendation - A recommended action based on the status.
		/// • Lock Status - An explanation of the lock status of the IP in the current project.
		/// • Change Log - A reference to the change log for the IP update in the catalog. This will provide a
		/// description of the changes in the latest IP.
		/// • IP Name - The name of the IP core in the catalog.
		/// • IP Version - The version of the IP in use in the current project.
		/// • New Version - The latest version of the IP in the catalog.
		/// • New license - The license status for the new IP version.
		/// • Original Part - The original part associated with the IP in the catalog.
		/// IP cores that are out of date, or locked, may need to be upgraded and the output products
		/// regenerated. Refer to the Vivado Design Suite User Guide: Designing with IP (UG896) for more
		/// information.
		/// The report_ip_status command checks the available licenses on the local machine, or on the
		/// license server, for all IP cores in the current project. If a license can be found, the license
		/// information is printed. If the license cannot be found, this information is also printed.
		/// This command returns the IP status report, or returns an error if it fails.
		///
		/// The following example reports the IP status to the specified file, appending the results if the file
		/// already exists:
		/// report_ip_status -file C:/Data/reports/ip_status.txt -append
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1356
		/// </summary>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name Values: The
		/// name of the GUI dialog
		/// </param>
		/// <param name="file">
		/// Optional
		/// Filename to output results to (send output to console if -file
		/// is not used) Values: The report filename
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append to existing file
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// Return report as string
		/// </param>
		/// <param name="license_status">
		/// Optional
		/// Report the license status of the generated outputs for each
		/// IP
		/// </param>
		/// <param name="resource_data">
		/// Optional
		/// Report the resource data usage for each IP instance
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>True for success</returns>
		public void report_ip_status(string name = null, string file = null, bool? append = null, bool? return_string = null, bool? license_status = null, bool? resource_data = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_ip_status [-name <arg>] [-file <arg>] [-append] [-return_string] [-license_status] [-resource_data] [-quiet] [-verbose]
			_tcl.Add(
				new SimpleTCLCommand("report_ip_status")
					.OptionalNamedString("name", name)
					.OptionalNamedString("file", file)
					.Flag("append", append)
					.Flag("return_string", return_string)
					.Flag("license_status", license_status)
					.Flag("resource_data", resource_data)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
			);
		}
		/// <summary>
		/// Reset target data for the specified source
		///
		///
		/// TCL Syntax: reset_target [-quiet] [-verbose] <name> <objects>
		///
		/// Remove the current target data for the specified IP core. This deletes any files that were
		/// delivered during generation of the specified targets. This does not remove the core from the
		/// current project, but does remove the associated target data from its referenced location.
		///
		/// The following example resets the instantiation template for the specified IP core:
		/// reset_target instantiation_template [get_ips blk_mem*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1488
		/// </summary>
		/// <param name="name">
		/// Required
		/// List of targets to be reset, or 'all' to reset all generated
		/// targets
		/// </param>
		/// <param name="objects">
		/// Required
		/// The objects for which data needs to be reset
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void reset_target(string name, string objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_target [-quiet] [-verbose] <name> <objects>
			_tcl.Add(
				new SimpleTCLCommand("reset_target")
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.RequiredString(name)
					.RequiredString(objects)
			);
		}
		/// <summary>
		/// Generate a synthesis netlist for an IP
		///
		///
		/// TCL Syntax: synth_ip [-force] [-quiet] [-verbose] <objects>
		///
		/// This command is used in the non-project flow to create a synthesized design checkpoint file
		/// (DCP) to support the out-of-context (OOC) IP flow, or to synthesize and implement an IP module
		/// in the OOC hierarchical design flow. IP objects are specified by the get_ips command, or for
		/// the specified IP core file (XCI) as specified by the get_files command.
		/// IMPORTANT! To enable this functionality, the IP core must be marked for OOC generation by setting the
		/// GENERATE_SYNTH_CHECKPOINT property to true (or 1) using the set_property command on the XCI file.
		/// For project-based designs you would use the create_ip_run and launch_runs commands.
		/// Refer to the Vivado Design Suite User Guide: Design Flows Overview (UG892) for more information
		/// on Project and Non-Project Modes in Vivado.
		/// The synth_ip command will automatically generate any required target files prior to
		/// synthesizing the IP core. The source files required to synthesize the IP are copied into the IP run
		/// directory. Upon completion, any newly generated OOC target files (dcp, stub files, funcsim
		/// netlists...) are registered with the associated IP core.
		///
		/// The following example synthesizes the specified IP object, regenerating the netlist if the
		/// synthesized core is up-to-date:
		/// synth_ip [get_ips char_fifo] -force
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1709
		/// </summary>
		/// <param name="objects">
		/// Required
		/// All the objects for which a netlist needs to be generated for.
		/// </param>
		/// <param name="force">
		/// Optional
		/// Force regeneration of the netlist.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void synth_ip(string objects, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: synth_ip [-force] [-quiet] [-verbose] <objects>
			_tcl.Add(
				new SimpleTCLCommand("synth_ip")
					.Flag("force", force)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.RequiredString(objects)
			);
		}
		/// <summary>
		/// Update the IP Catalog. Before executing this command optionally use the following to set
		/// repository paths:'set_property ip_repo_paths <repo_path_list> [current_fileset]'
		///
		///
		/// TCL Syntax: update_ip_catalog [-rebuild] [-add_ip <arg>] [-delete_ip <arg>] [-delete_mult_ip <args>] [-disable_ip <arg>] [-enable_ip <arg>] [-add_interface <arg>] [-create_index] [-repo_path <arg>] [-update_module_ref] [-quiet] [-verbose]
		///
		/// Update the IP catalog associated with the current design.
		/// The Xilinx® IP catalog, or repository, is located in the installation hierarchy of the Vivado Design
		/// Suite software release being used. You can also add custom IP to the repository by using the
		/// set_property command to set the IP_REPO_PATHS property on the source fileset to point to
		/// the locations of custom IP, as shown in the example below.
		/// The update_ip_catalog command lets you add, delete, disable, or enable individual IP cores
		/// in the catalog. When referring to individual cores, you can reference them by the path to the
		/// component.xml file, or by referencing the VLNV property of the IP.
		/// TIP: The VLNV property refers to the Vendor:Library:Name:Version string which uniquely identifies the IP in the
		/// catalog.
		/// This command returns a transcript of its process if successful, or returns an error if it fails.
		///
		/// The following example sets the IP_REPO_PATHS property of the current Source fileset, to add an
		/// IP repository, then rebuilds the IP catalog index for the whole IP catalog:
		/// set_property IP_REPO_PATHS C:/Data/IP_LIB [current_fileset]
		/// update_ip_catalog -rebuild
		/// This example disables the IP specified by its VLNV property from the specified IP repository:
		/// update_ip_catalog -disable_ip {myCo.com:ip:custom_decoder:1.0} \
		/// -repo_path C:/Data/ip
		/// This example disables the IP specified by the path to the component.xml file, from the IP
		/// repository:
		/// update_ip_catalog -disable_ip C:/Data/ip/custom_encoder_1/component.xml \
		/// -repo_path C:/Xilinx/Vivado/data/ip
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1738
		/// </summary>
		/// <param name="rebuild">
		/// Optional
		/// Trigger a rebuild of the specified repository's index file or
		/// rebuild all repositories if none specified
		/// </param>
		/// <param name="add_ip">
		/// Optional
		/// Add the specified IP into the specified repository Values:
		/// Either a path to the IP's component.xml or to a zip file
		/// containing the IP
		/// </param>
		/// <param name="delete_ip">
		/// Optional
		/// Remove the specified IP from the specified repository
		/// Values: Either a path to the IP's component.xml or its VLNV
		/// </param>
		/// <param name="delete_mult_ip">
		/// Optional
		/// Remove the specified IPs from the specified repository
		/// Values: A list of IPs; either paths to the component.xml files
		/// or their VLNVs
		/// </param>
		/// <param name="disable_ip">
		/// Optional
		/// Disable the specified IP from the specified repository
		/// Values: Either a path to the IP's component.xml or its VLNV
		/// </param>
		/// <param name="enable_ip">
		/// Optional
		/// Enable the specified disabled IP from the specified
		/// repository Values: Either a path to the IP's component.xml
		/// or its VLNV
		/// </param>
		/// <param name="add_interface">
		/// Optional
		/// Add the specified interface into the specified repository
		/// Values: A path to the interface's xml file
		/// </param>
		/// <param name="create_index">
		/// Optional
		/// Cache the specified repository's data on disk, to improve
		/// load time.
		/// </param>
		/// <param name="repo_path">
		/// Optional
		/// Used in conjunction with rebuild, add_ip, delete_ip,
		/// delete_mult_ip, disable_ip or create_index to specify the path
		/// of the repository on which to operate
		/// </param>
		/// <param name="update_module_ref">
		/// Optional
		/// Update module reference from their source (e.g. HDL file)
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>True for success</returns>
		public void update_ip_catalog(bool? rebuild = null, string add_ip = null, string delete_ip = null, string delete_mult_ip = null, string disable_ip = null, string enable_ip = null, string add_interface = null, bool? create_index = null, string repo_path = null, bool? update_module_ref = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: update_ip_catalog [-rebuild] [-add_ip <arg>] [-delete_ip <arg>] [-delete_mult_ip <args>] [-disable_ip <arg>] [-enable_ip <arg>] [-add_interface <arg>] [-create_index] [-repo_path <arg>] [-update_module_ref] [-quiet] [-verbose]
			_tcl.Add(
				new SimpleTCLCommand("update_ip_catalog")
					.Flag("rebuild", rebuild)
					.OptionalNamedString("add_ip", add_ip)
					.OptionalNamedString("delete_ip", delete_ip)
					.OptionalNamedString("delete_mult_ip", delete_mult_ip)
					.OptionalNamedString("disable_ip", disable_ip)
					.OptionalNamedString("enable_ip", enable_ip)
					.OptionalNamedString("add_interface", add_interface)
					.Flag("create_index", create_index)
					.OptionalNamedString("repo_path", repo_path)
					.Flag("update_module_ref", update_module_ref)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
			);
		}
		/// <summary>
		/// Refresh module reference definition and instance(s)
		///
		///
		/// TCL Syntax: update_module_reference [-quiet] [-verbose] [<ips>...]
		///
		/// Refresh the block design cell or cells that reference module definitions from RTL source files by
		/// rereading the module definition from the source file.
		/// Note: This command does not cause the Vivado tool to reread the source file. If changes have been made
		/// to the source file it must be separately updated.
		/// This command returns a transcript of the update process as well as any warnings related to
		/// design changes, or returns nothing if the command fails.
		///
		/// The following example updates the specified module references in the current design:
		/// update_module_reference {rtlRam_0 uart_0}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1745
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="ips">
		/// Optional
		/// module reference to be upgraded Values: IP instance
		/// name(s) within the design
		/// </param>
		/// <returns>A return code indicating success or failure.</returns>
		public void update_module_reference(bool? quiet = null, bool? verbose = null, string ips = null)
		{
			// TCL Syntax: update_module_reference [-quiet] [-verbose] [<ips>...]
			_tcl.Add(
				new SimpleTCLCommand("update_module_reference")
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.OptionalString(ips)
			);
		}
		/// <summary>
		/// Upgrade a configurable IP to a later version
		///
		///
		/// TCL Syntax: upgrade_ip [-srcset <arg>] [-vlnv <arg>] [-log <arg>] [-quiet] [-verbose] <objects>...
		///
		/// This command upgrades the specified IP cores from an older version to the latest version in the
		/// IP catalog.
		/// You can only upgrade IP that explicitly supports upgrading. The UPGRADE_VERSIONS property
		/// on the ipdef object indicates if there are upgrade versions for an IP core.
		/// TIP: The upgrade_ip command also accepts Block Design cell IP instances as bd_cell objects. The command
		/// upgrades the bd_cell objects within the Block Design, and does not require the diagram to be open in the Vivado
		/// IP integrator .
		///
		/// The following example upgrades all IP cores in the current project to the latest version:
		/// upgrade_ip [get_ips]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1754
		/// </summary>
		/// <param name="objects">
		/// Required
		/// IP to be upgraded Values: IP instance(s) within the design,
		/// as returned by 'get_ips <instance name>' or 'get_bd_cells
		/// <cell name>'
		/// </param>
		/// <param name="srcset">
		/// Optional
		/// (Optional) Specifies the source file set containing the IP to
		/// be upgraded Default: The current source fileset Values:
		/// Source set name
		/// </param>
		/// <param name="vlnv">
		/// Optional
		/// (Optional) Identifies the Catalog IP to which the IP will be
		/// upgraded. The VLNV string maps to the IPDEF property on
		/// the IP core. This is a strict comparison, and the upgrade will
		/// fail if the identified IP does not exist in the Catalog. Default:
		/// Latest version of the current IP Values: A string of the form
		/// '<vendor>:<library>:<name>:<versio n>'
		/// </param>
		/// <param name="log">
		/// Optional
		/// (Optional) Identifies the log file to which the IP upgrade
		/// report will be concatenated. Default: An empty string,
		/// indicating that no log will be written Values: A file path to an
		/// existing writable file, or a non-existent file location in a
		/// writable directory
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>A return code indicating success or failure.</returns>
		public void upgrade_ip(string objects, string srcset = null, string vlnv = null, string log = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: upgrade_ip [-srcset <arg>] [-vlnv <arg>] [-log <arg>] [-quiet] [-verbose] <objects>...
			_tcl.Add(
				new SimpleTCLCommand("upgrade_ip")
					.OptionalNamedString("srcset", srcset)
					.OptionalNamedString("vlnv", vlnv)
					.OptionalNamedString("log", log)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.RequiredString(objects)
			);
		}
		/// <summary>
		/// This command applies any pending set_property commands and returns parameter validation
		/// messages, if any exist
		///
		///
		/// TCL Syntax: validate_ip [-save_ip] [-quiet] [-verbose] [<ips>]
		///
		/// Perform DRC check on IP to ensure that it is properly constructed. This command returns 1
		/// when all IPs have been validated, or 0 when there is a problem.
		///
		/// The following example validates the IPs in the current project, and updates the persistent
		/// representation of the IP.
		/// validate_ip -save_ip [get_ips]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1764
		/// </summary>
		/// <param name="save_ip">
		/// Optional
		/// Write IP files on the disk
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="ips">
		/// Optional
		/// IPs to be validated
		/// </param>
		public void validate_ip(bool? save_ip = null, bool? quiet = null, bool? verbose = null, string ips = null)
		{
			// TCL Syntax: validate_ip [-save_ip] [-quiet] [-verbose] [<ips>]
			_tcl.Add(
				new SimpleTCLCommand("validate_ip")
					.Flag("save_ip", save_ip)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.OptionalString(ips)
			);
		}
		/// <summary>
		/// Write a tcl script on disk that will recreate a given IP.
		///
		///
		/// TCL Syntax: write_ip_tcl [-force] [-no_ip_version] [-ip_name <arg>] [-show_defaults] [-multiple_files] [-quiet] [-verbose] [<objects>] [<tcl_filename>...]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1833
		/// </summary>
		/// <param name="force">
		/// Optional
		/// Flag to overwrite existing file.
		/// </param>
		/// <param name="no_ip_version">
		/// Optional
		/// Flag to not include the IP version in the IP VLNV in create_ip
		/// commands. NOTE - this may have implications if there are
		/// major IP version changes.
		/// </param>
		/// <param name="ip_name">
		/// Optional
		/// Set the name of the IP. This argument is not supported for
		/// multiple IP.
		/// </param>
		/// <param name="show_defaults">
		/// Optional
		/// Add a comment containing the default parameter values of
		/// the IP.
		/// </param>
		/// <param name="multiple_files">
		/// Optional
		/// Flag to create a .tcl file for each IP supplied as an argument
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
		/// IP(s) to be written to disk Values: IP instance(s) as returned
		/// by 'get_ips <instance name>'
		/// </param>
		/// <param name="tcl_filename">
		/// Optional
		/// File path to the exported tcl file. If the path is a directory and
		/// multiple IP are given as an argument, a file for each IP will
		/// be created. Default: ./
		/// </param>
		/// <returns>IP TCL file</returns>
		public void write_ip_tcl(bool? force = null, bool? no_ip_version = null, string ip_name = null, bool? show_defaults = null, bool? multiple_files = null, bool? quiet = null, bool? verbose = null, string objects = null, string tcl_filename = null)
		{
			// TCL Syntax: write_ip_tcl [-force] [-no_ip_version] [-ip_name <arg>] [-show_defaults] [-multiple_files] [-quiet] [-verbose] [<objects>] [<tcl_filename>...]
			_tcl.Add(
				new SimpleTCLCommand("write_ip_tcl")
					.Flag("force", force)
					.Flag("no_ip_version", no_ip_version)
					.OptionalNamedString("ip_name", ip_name)
					.Flag("show_defaults", show_defaults)
					.Flag("multiple_files", multiple_files)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.OptionalString(objects)
					.OptionalString(tcl_filename)
			);
		}
		/// <summary>
		/// Save peripheral component to the disk.
		///
		///
		/// TCL Syntax: write_peripheral [-quiet] [-verbose] <peripheral>
		///
		/// Write the specified AXI peripheral object to disk in the form of the component.xml file. The
		/// peripheral is written to the repository location specified by the create_peripheral
		/// command, under the name specified at creation.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1838
		/// </summary>
		/// <param name="peripheral">
		/// Required
		/// Peripheral object
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void write_peripheral(string peripheral, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_peripheral [-quiet] [-verbose] <peripheral>
			_tcl.Add(
				new SimpleTCLCommand("write_peripheral")
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.RequiredString(peripheral)
			);
		}
	}
}
