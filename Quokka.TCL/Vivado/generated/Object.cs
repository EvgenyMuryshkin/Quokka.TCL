// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class ObjectCommands
	{
		private readonly QuokkaTCL _tcl;
		public ObjectCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Add DRC rule check objects to a rule deck
		/// </summary>
		public void add_drc_checks()
		{
			var command = new SimpleTCLCommand("add_drc_checks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Applies board connections to given designs
		/// </summary>
		public void apply_board_connection()
		{
			var command = new SimpleTCLCommand("apply_board_connection");
			_tcl.Add(command);
		}
		/// <summary>
		/// Check if a module can be referenced
		/// </summary>
		public void can_resolve_reference()
		{
			var command = new SimpleTCLCommand("can_resolve_reference");
			_tcl.Add(command);
		}
		/// <summary>
		/// Manage the IP instance Synthesis cache. Lists out the IP Cache entries if no options are specified.
		/// </summary>
		public void config_ip_cache()
		{
			var command = new SimpleTCLCommand("config_ip_cache");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a user defined DRC rule
		/// </summary>
		public void create_drc_check()
		{
			var command = new SimpleTCLCommand("create_drc_check");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create one or more user defined DRC rule deck objects
		/// </summary>
		public void create_drc_ruledeck()
		{
			var command = new SimpleTCLCommand("create_drc_ruledeck");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create new PartitionDef
		/// </summary>
		public void create_partition_def()
		{
			var command = new SimpleTCLCommand("create_partition_def");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create new Configuration
		/// </summary>
		public void create_pr_configuration()
		{
			var command = new SimpleTCLCommand("create_pr_configuration");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create new reconfig Module
		/// </summary>
		public void create_reconfig_module()
		{
			var command = new SimpleTCLCommand("create_reconfig_module");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create Configurable Report objects.
		/// </summary>
		public void create_report_config()
		{
			var command = new SimpleTCLCommand("create_report_config");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a DRC/METHODOLOGY/CDC message waiver
		/// </summary>
		public void create_waiver()
		{
			var command = new SimpleTCLCommand("create_waiver");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the current board object
		/// </summary>
		public void current_board()
		{
			var command = new SimpleTCLCommand("current_board");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the current board_part object
		/// </summary>
		public void current_board_part()
		{
			var command = new SimpleTCLCommand("current_board_part");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of PartitionDefs
		/// </summary>
		public void current_pr_configuration()
		{
			var command = new SimpleTCLCommand("current_pr_configuration");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete one or more user-defined DRC checks.
		/// </summary>
		public void delete_drc_check()
		{
			var command = new SimpleTCLCommand("delete_drc_check");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete one or more user defined DRC rule deck objects
		/// </summary>
		public void delete_drc_ruledeck()
		{
			var command = new SimpleTCLCommand("delete_drc_ruledeck");
			_tcl.Add(command);
		}
		/// <summary>
		/// Removes the HW Bitstream object from a list of hardware devices.
		/// </summary>
		public void delete_hw_bitstream()
		{
			var command = new SimpleTCLCommand("delete_hw_bitstream");
			_tcl.Add(command);
		}
		/// <summary>
		/// Deletes a list of available QoR suggestions
		/// </summary>
		public void delete_qor_suggestions()
		{
			var command = new SimpleTCLCommand("delete_qor_suggestions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete a set of existing configurable report objects
		/// </summary>
		public void delete_report_configs()
		{
			var command = new SimpleTCLCommand("delete_report_configs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete one or more DRC/METHODOLOGY/CDC message waivers
		/// </summary>
		public void delete_waivers()
		{
			var command = new SimpleTCLCommand("delete_waivers");
			_tcl.Add(command);
		}
		/// <summary>
		/// Filter a list, resulting in new list
		/// </summary>
		public void filter()
		{
			var command = new SimpleTCLCommand("filter");
			_tcl.Add(command);
		}
		/// <summary>
		/// Find a routing path between two nodes.
		/// </summary>
		public void find_routing_path()
		{
			var command = new SimpleTCLCommand("find_routing_path");
			_tcl.Add(command);
		}
		/// <summary>
		/// Generate a set of configurable report objects
		/// </summary>
		public void generate_reports()
		{
			var command = new SimpleTCLCommand("generate_reports");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of bel_pins. If a design is loaded, gets the constructed site type bels.
		/// </summary>
		public void get_bel_pins()
		{
			var command = new SimpleTCLCommand("get_bel_pins");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of bels. If a design is loaded, gets the constructed site type bels.
		/// </summary>
		public void get_bels()
		{
			var command = new SimpleTCLCommand("get_bels");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of board bus net objects
		/// </summary>
		public void get_board_bus_nets()
		{
			var command = new SimpleTCLCommand("get_board_bus_nets");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of board bus objects
		/// </summary>
		public void get_board_buses()
		{
			var command = new SimpleTCLCommand("get_board_buses");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of interfaces in the board components that implement busdef specified by VLNV
		/// </summary>
		public void get_board_component_interfaces()
		{
			var command = new SimpleTCLCommand("get_board_component_interfaces");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of component mode objects
		/// </summary>
		public void get_board_component_modes()
		{
			var command = new SimpleTCLCommand("get_board_component_modes");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of board_part pins object
		/// </summary>
		public void get_board_component_pins()
		{
			var command = new SimpleTCLCommand("get_board_component_pins");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the list of components available in the board
		/// </summary>
		public void get_board_components()
		{
			var command = new SimpleTCLCommand("get_board_components");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of interface ports object
		/// </summary>
		public void get_board_interface_ports()
		{
			var command = new SimpleTCLCommand("get_board_interface_ports");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of ip preference objects
		/// </summary>
		public void get_board_ip_preferences()
		{
			var command = new SimpleTCLCommand("get_board_ip_preferences");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of board jumper objects
		/// </summary>
		public void get_board_jumpers()
		{
			var command = new SimpleTCLCommand("get_board_jumpers");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of board parameter objects
		/// </summary>
		public void get_board_parameters()
		{
			var command = new SimpleTCLCommand("get_board_parameters");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of interfaces in the board_part that implement busdef specified by VLNV
		/// </summary>
		public void get_board_part_interfaces()
		{
			var command = new SimpleTCLCommand("get_board_part_interfaces");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of board_part pins object
		/// </summary>
		public void get_board_part_pins()
		{
			var command = new SimpleTCLCommand("get_board_part_pins");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the list of board_part available in the project
		/// </summary>
		public void get_board_parts()
		{
			var command = new SimpleTCLCommand("get_board_parts");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the list of boards available in the project
		/// </summary>
		public void get_boards()
		{
			var command = new SimpleTCLCommand("get_boards");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of CDC violations from a previous report_cdc run
		/// </summary>
		public void get_cdc_violations()
		{
			var command = new SimpleTCLCommand("get_cdc_violations");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of cells in the current design
		/// </summary>
		public void get_cells()
		{
			var command = new SimpleTCLCommand("get_cells");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of cfgmem_parts available in the software
		/// </summary>
		public void get_cfgmem_parts()
		{
			var command = new SimpleTCLCommand("get_cfgmem_parts");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the clock regions for the current device.
		/// </summary>
		public void get_clock_regions()
		{
			var command = new SimpleTCLCommand("get_clock_regions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of clocks in the current design
		/// </summary>
		public void get_clocks()
		{
			var command = new SimpleTCLCommand("get_clocks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create the Project summary dashboard
		/// </summary>
		public void get_dashboard_gadgets()
		{
			var command = new SimpleTCLCommand("get_dashboard_gadgets");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of debug cores in the current design
		/// </summary>
		public void get_debug_cores()
		{
			var command = new SimpleTCLCommand("get_debug_cores");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of debug ports in the current design
		/// </summary>
		public void get_debug_ports()
		{
			var command = new SimpleTCLCommand("get_debug_ports");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of designs in the current project
		/// </summary>
		public void get_designs()
		{
			var command = new SimpleTCLCommand("get_designs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of DRC rule check objects
		/// </summary>
		public void get_drc_checks()
		{
			var command = new SimpleTCLCommand("get_drc_checks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of DRC rule deck objects
		/// </summary>
		public void get_drc_ruledecks()
		{
			var command = new SimpleTCLCommand("get_drc_ruledecks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of DRC violations from a previous report_drc run
		/// </summary>
		public void get_drc_violations()
		{
			var command = new SimpleTCLCommand("get_drc_violations");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of source files
		/// </summary>
		public void get_files()
		{
			var command = new SimpleTCLCommand("get_files");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of filesets in the current project
		/// </summary>
		public void get_filesets()
		{
			var command = new SimpleTCLCommand("get_filesets");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of generated clocks in the current design
		/// </summary>
		public void get_generated_clocks()
		{
			var command = new SimpleTCLCommand("get_generated_clocks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get highlighted objects
		/// </summary>
		public void get_highlighted_objects()
		{
			var command = new SimpleTCLCommand("get_highlighted_objects");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of hardware AXI transactions.
		/// </summary>
		public void get_hw_axi_txns()
		{
			var command = new SimpleTCLCommand("get_hw_axi_txns");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of hardware AXI objects.
		/// </summary>
		public void get_hw_axis()
		{
			var command = new SimpleTCLCommand("get_hw_axis");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of hardware cfgmems.
		/// </summary>
		public void get_hw_cfgmems()
		{
			var command = new SimpleTCLCommand("get_hw_cfgmems");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of Versal integrated and soft DDRMC cores.
		/// </summary>
		public void get_hw_ddrmcs()
		{
			var command = new SimpleTCLCommand("get_hw_ddrmcs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of hardware devices.
		/// </summary>
		public void get_hw_devices()
		{
			var command = new SimpleTCLCommand("get_hw_devices");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware HBM cores.
		/// </summary>
		public void get_hw_hbms()
		{
			var command = new SimpleTCLCommand("get_hw_hbms");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of hardware ILA data objects.
		/// </summary>
		public void get_hw_ila_datas()
		{
			var command = new SimpleTCLCommand("get_hw_ila_datas");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of hardware ILA.
		/// </summary>
		public void get_hw_ilas()
		{
			var command = new SimpleTCLCommand("get_hw_ilas");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware Migs cores.
		/// </summary>
		public void get_hw_migs()
		{
			var command = new SimpleTCLCommand("get_hw_migs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of hardware probes.
		/// </summary>
		public void get_hw_probes()
		{
			var command = new SimpleTCLCommand("get_hw_probes");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of hardware servers.
		/// </summary>
		public void get_hw_servers()
		{
			var command = new SimpleTCLCommand("get_hw_servers");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO GT commons.
		/// </summary>
		public void get_hw_sio_commons()
		{
			var command = new SimpleTCLCommand("get_hw_sio_commons");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO GT groups.
		/// </summary>
		public void get_hw_sio_gtgroups()
		{
			var command = new SimpleTCLCommand("get_hw_sio_gtgroups");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO GTs.
		/// </summary>
		public void get_hw_sio_gts()
		{
			var command = new SimpleTCLCommand("get_hw_sio_gts");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO IBERT cores.
		/// </summary>
		public void get_hw_sio_iberts()
		{
			var command = new SimpleTCLCommand("get_hw_sio_iberts");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO link groups.
		/// </summary>
		public void get_hw_sio_linkgroups()
		{
			var command = new SimpleTCLCommand("get_hw_sio_linkgroups");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO links.
		/// </summary>
		public void get_hw_sio_links()
		{
			var command = new SimpleTCLCommand("get_hw_sio_links");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO PLLs.
		/// </summary>
		public void get_hw_sio_plls()
		{
			var command = new SimpleTCLCommand("get_hw_sio_plls");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO RXs.
		/// </summary>
		public void get_hw_sio_rxs()
		{
			var command = new SimpleTCLCommand("get_hw_sio_rxs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO scans.
		/// </summary>
		public void get_hw_sio_scans()
		{
			var command = new SimpleTCLCommand("get_hw_sio_scans");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO sweeps.
		/// </summary>
		public void get_hw_sio_sweeps()
		{
			var command = new SimpleTCLCommand("get_hw_sio_sweeps");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO TXs.
		/// </summary>
		public void get_hw_sio_txs()
		{
			var command = new SimpleTCLCommand("get_hw_sio_txs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SysMons.
		/// </summary>
		public void get_hw_sysmons()
		{
			var command = new SimpleTCLCommand("get_hw_sysmons");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of hardware targets.
		/// </summary>
		public void get_hw_targets()
		{
			var command = new SimpleTCLCommand("get_hw_targets");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of hardware VIOs.
		/// </summary>
		public void get_hw_vios()
		{
			var command = new SimpleTCLCommand("get_hw_vios");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of I/O port interfaces in the current design
		/// </summary>
		public void get_interfaces()
		{
			var command = new SimpleTCLCommand("get_interfaces");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of IO standards.
		/// </summary>
		public void get_io_standards()
		{
			var command = new SimpleTCLCommand("get_io_standards");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of iobanks.
		/// </summary>
		public void get_iobanks()
		{
			var command = new SimpleTCLCommand("get_iobanks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of results for IP upgrades during the current project
		/// </summary>
		public void get_ip_upgrade_results()
		{
			var command = new SimpleTCLCommand("get_ip_upgrade_results");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of IP from the current IP Catalog
		/// </summary>
		public void get_ipdefs()
		{
			var command = new SimpleTCLCommand("get_ipdefs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of IPs in the current design
		/// </summary>
		public void get_ips()
		{
			var command = new SimpleTCLCommand("get_ips");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of Library Cells
		/// </summary>
		public void get_lib_cells()
		{
			var command = new SimpleTCLCommand("get_lib_cells");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of Library Cell Pins
		/// </summary>
		public void get_lib_pins()
		{
			var command = new SimpleTCLCommand("get_lib_pins");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of Libraries
		/// </summary>
		public void get_libs()
		{
			var command = new SimpleTCLCommand("get_libs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of macros in the current design
		/// </summary>
		public void get_macros()
		{
			var command = new SimpleTCLCommand("get_macros");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get marked objects
		/// </summary>
		public void get_marked_objects()
		{
			var command = new SimpleTCLCommand("get_marked_objects");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of Methodology rule check objects
		/// </summary>
		public void get_methodology_checks()
		{
			var command = new SimpleTCLCommand("get_methodology_checks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of Methodology violations from a previous report_methodology run
		/// </summary>
		public void get_methodology_violations()
		{
			var command = new SimpleTCLCommand("get_methodology_violations");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the routed or estimated delays in picoseconds on a net from the driver to each load pin.
		/// </summary>
		public void get_net_delays()
		{
			var command = new SimpleTCLCommand("get_net_delays");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of nets in the current design
		/// </summary>
		public void get_nets()
		{
			var command = new SimpleTCLCommand("get_nets");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of nodes in the device.
		/// </summary>
		public void get_nodes()
		{
			var command = new SimpleTCLCommand("get_nodes");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of package pins
		/// </summary>
		public void get_package_pins()
		{
			var command = new SimpleTCLCommand("get_package_pins");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of PartitionDefs
		/// </summary>
		public void get_partition_defs()
		{
			var command = new SimpleTCLCommand("get_partition_defs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of parts available in the software
		/// </summary>
		public void get_parts()
		{
			var command = new SimpleTCLCommand("get_parts");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of path groups in the current design
		/// </summary>
		public void get_path_groups()
		{
			var command = new SimpleTCLCommand("get_path_groups");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of Pblocks in the current design
		/// </summary>
		public void get_pblocks()
		{
			var command = new SimpleTCLCommand("get_pblocks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of pins in the current design
		/// </summary>
		public void get_pins()
		{
			var command = new SimpleTCLCommand("get_pins");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of programmable interconnect points (pips) on the current device.
		/// </summary>
		public void get_pips()
		{
			var command = new SimpleTCLCommand("get_pips");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of package pin byte groups.
		/// </summary>
		public void get_pkgpin_bytegroups()
		{
			var command = new SimpleTCLCommand("get_pkgpin_bytegroups");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of pkgpin nibbles.
		/// </summary>
		public void get_pkgpin_nibbles()
		{
			var command = new SimpleTCLCommand("get_pkgpin_nibbles");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of ports in the current design
		/// </summary>
		public void get_ports()
		{
			var command = new SimpleTCLCommand("get_ports");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of partition configurations
		/// </summary>
		public void get_pr_configurations()
		{
			var command = new SimpleTCLCommand("get_pr_configurations");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of available unisim primitives for a part
		/// </summary>
		public void get_primitives()
		{
			var command = new SimpleTCLCommand("get_primitives");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of projects
		/// </summary>
		public void get_projects()
		{
			var command = new SimpleTCLCommand("get_projects");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get properties of object
		/// </summary>
		public void get_property()
		{
			var command = new SimpleTCLCommand("get_property");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of available QoR suggestions
		/// </summary>
		public void get_qor_suggestions()
		{
			var command = new SimpleTCLCommand("get_qor_suggestions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of ReconfigModules
		/// </summary>
		public void get_reconfig_modules()
		{
			var command = new SimpleTCLCommand("get_reconfig_modules");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of Configurable Report objects
		/// </summary>
		public void get_report_configs()
		{
			var command = new SimpleTCLCommand("get_report_configs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of runs
		/// </summary>
		public void get_runs()
		{
			var command = new SimpleTCLCommand("get_runs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get selected objects
		/// </summary>
		public void get_selected_objects()
		{
			var command = new SimpleTCLCommand("get_selected_objects");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of site_pins.
		/// </summary>
		public void get_site_pins()
		{
			var command = new SimpleTCLCommand("get_site_pins");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of site_pips from the given object.
		/// </summary>
		public void get_site_pips()
		{
			var command = new SimpleTCLCommand("get_site_pips");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of Sites
		/// </summary>
		public void get_sites()
		{
			var command = new SimpleTCLCommand("get_sites");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of slrs.
		/// </summary>
		public void get_slrs()
		{
			var command = new SimpleTCLCommand("get_slrs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of speed_models in the device.
		/// </summary>
		public void get_speed_models()
		{
			var command = new SimpleTCLCommand("get_speed_models");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of tiles.
		/// </summary>
		public void get_tiles()
		{
			var command = new SimpleTCLCommand("get_tiles");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of timing arcs
		/// </summary>
		public void get_timing_arcs()
		{
			var command = new SimpleTCLCommand("get_timing_arcs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get timing paths
		/// </summary>
		public void get_timing_paths()
		{
			var command = new SimpleTCLCommand("get_timing_paths");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get one or more DRC/METHODOLOGY/CDC message waivers
		/// </summary>
		public void get_waivers()
		{
			var command = new SimpleTCLCommand("get_waivers");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of wires.
		/// </summary>
		public void get_wires()
		{
			var command = new SimpleTCLCommand("get_wires");
			_tcl.Add(command);
		}
		/// <summary>
		/// Return probe sample values
		/// </summary>
		public void list_hw_samples()
		{
			var command = new SimpleTCLCommand("list_hw_samples");
			_tcl.Add(command);
		}
		/// <summary>
		/// List properties of object
		/// </summary>
		public void list_property()
		{
			var command = new SimpleTCLCommand("list_property");
			_tcl.Add(command);
		}
		/// <summary>
		/// List legal property values of object
		/// </summary>
		public void list_property_value()
		{
			var command = new SimpleTCLCommand("list_property_value");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove DRC rule check objects from a user rule deck
		/// </summary>
		public void remove_drc_checks()
		{
			var command = new SimpleTCLCommand("remove_drc_checks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report properties of object
		/// </summary>
		public void report_property()
		{
			var command = new SimpleTCLCommand("report_property");
			_tcl.Add(command);
		}
		/// <summary>
		/// Recommend QoR Suggestions
		/// </summary>
		public void report_qor_suggestions()
		{
			var command = new SimpleTCLCommand("report_qor_suggestions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report status of DRC/METHODOLOGY/CDC message waivers
		/// </summary>
		public void report_waivers()
		{
			var command = new SimpleTCLCommand("report_waivers");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reset one or more DRC checks to factory defaults.
		/// </summary>
		public void reset_drc_check()
		{
			var command = new SimpleTCLCommand("reset_drc_check");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reset one or more Methodology checks to factory defaults.
		/// </summary>
		public void reset_methodology_check()
		{
			var command = new SimpleTCLCommand("reset_methodology_check");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reset property on object(s)
		/// </summary>
		public void reset_property()
		{
			var command = new SimpleTCLCommand("reset_property");
			_tcl.Add(command);
		}
		/// <summary>
		/// change to a stable state of a specified transition
		/// </summary>
		public void run_state_hw_jtag()
		{
			var command = new SimpleTCLCommand("run_state_hw_jtag");
			_tcl.Add(command);
		}
		/// <summary>
		/// Forces IEEE 1149.1 TAP state machine to a stable state for a specified wait period
		/// </summary>
		public void runtest_hw_jtag()
		{
			var command = new SimpleTCLCommand("runtest_hw_jtag");
			_tcl.Add(command);
		}
		/// <summary>
		/// Perform shift DR on 'hw_jtag'.
		/// </summary>
		public void scan_dr_hw_jtag()
		{
			var command = new SimpleTCLCommand("scan_dr_hw_jtag");
			_tcl.Add(command);
		}
		/// <summary>
		/// Perform shift IR on 'hw_jtag'.
		/// </summary>
		public void scan_ir_hw_jtag()
		{
			var command = new SimpleTCLCommand("scan_ir_hw_jtag");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set property on object(s)
		/// </summary>
		public void set_property()
		{
			var command = new SimpleTCLCommand("set_property");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write a tcl script on disk that will recreate a given IP.
		/// </summary>
		public void write_ip_tcl()
		{
			var command = new SimpleTCLCommand("write_ip_tcl");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write out one or more DRC/METHODOLOGY/CDC message waivers in command form
		/// </summary>
		public void write_waivers()
		{
			var command = new SimpleTCLCommand("write_waivers");
			_tcl.Add(command);
		}
	}
}
