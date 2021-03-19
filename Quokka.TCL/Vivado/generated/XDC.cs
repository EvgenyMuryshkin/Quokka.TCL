// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class XDCCommands
	{
		private readonly QuokkaTCL _tcl;
		public XDCCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Add cells to a Pblock
		/// </summary>
		public void add_cells_to_pblock()
		{
			var command = new SimpleTCLCommand("add_cells_to_pblock");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of all clocks in the current design
		/// </summary>
		public void all_clocks()
		{
			var command = new SimpleTCLCommand("all_clocks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of cpu cells in the current design
		/// </summary>
		public void all_cpus()
		{
			var command = new SimpleTCLCommand("all_cpus");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of dsp cells in the current design
		/// </summary>
		public void all_dsps()
		{
			var command = new SimpleTCLCommand("all_dsps");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of pins or cells in fanin of specified sinks
		/// </summary>
		public void all_fanin()
		{
			var command = new SimpleTCLCommand("all_fanin");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of pins or cells in fanout of specified sources
		/// </summary>
		public void all_fanout()
		{
			var command = new SimpleTCLCommand("all_fanout");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of flip flop cells in the current design
		/// </summary>
		public void all_ffs()
		{
			var command = new SimpleTCLCommand("all_ffs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of hsio cells in the current design
		/// </summary>
		public void all_hsios()
		{
			var command = new SimpleTCLCommand("all_hsios");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of all input ports in the current design
		/// </summary>
		public void all_inputs()
		{
			var command = new SimpleTCLCommand("all_inputs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of all latch cells in the current design
		/// </summary>
		public void all_latches()
		{
			var command = new SimpleTCLCommand("all_latches");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of all output ports in the current design
		/// </summary>
		public void all_outputs()
		{
			var command = new SimpleTCLCommand("all_outputs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of ram cells in the current design
		/// </summary>
		public void all_rams()
		{
			var command = new SimpleTCLCommand("all_rams");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of register cells or pins in the current design
		/// </summary>
		public void all_registers()
		{
			var command = new SimpleTCLCommand("all_registers");
			_tcl.Add(command);
		}
		/// <summary>
		/// Connect debug slave instances to the master instance. A valid master is a debug bridge or debug
		/// hub instance configured in "From BSCAN To DebugHUB" mode. A valid slave could be any of the
		/// following debug cores (Ex: ILA, VIO, JTAG_to_AXI). connect_debug_cores can only connect
		/// master and slave instances that exist in the same region (either in Reconfigurable Partition or
		/// static)
		/// </summary>
		public void connect_debug_cores()
		{
			var command = new SimpleTCLCommand("connect_debug_cores");
			_tcl.Add(command);
		}
		/// <summary>
		/// Connect nets and pins to debug port channels
		/// </summary>
		public void connect_debug_port()
		{
			var command = new SimpleTCLCommand("connect_debug_port");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a clock object
		/// </summary>
		public void create_clock()
		{
			var command = new SimpleTCLCommand("create_clock");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new Integrated Logic Analyzer debug core
		/// </summary>
		public void create_debug_core()
		{
			var command = new SimpleTCLCommand("create_debug_core");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new debug port
		/// </summary>
		public void create_debug_port()
		{
			var command = new SimpleTCLCommand("create_debug_port");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a generated clock object
		/// </summary>
		public void create_generated_clock()
		{
			var command = new SimpleTCLCommand("create_generated_clock");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a Macro
		/// </summary>
		public void create_macro()
		{
			var command = new SimpleTCLCommand("create_macro");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new Pblock
		/// </summary>
		public void create_pblock()
		{
			var command = new SimpleTCLCommand("create_pblock");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create property for class of objects(s)
		/// </summary>
		public void create_property()
		{
			var command = new SimpleTCLCommand("create_property");
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
		/// Set or get the current design.
		/// </summary>
		public void current_design()
		{
			var command = new SimpleTCLCommand("current_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set or get the current instance
		/// </summary>
		public void current_instance()
		{
			var command = new SimpleTCLCommand("current_instance");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete a list of macros
		/// </summary>
		public void delete_macros()
		{
			var command = new SimpleTCLCommand("delete_macros");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove Pblock
		/// </summary>
		public void delete_pblocks()
		{
			var command = new SimpleTCLCommand("delete_pblocks");
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
		/// Get a list of cells in the current design
		/// </summary>
		public void get_cells()
		{
			var command = new SimpleTCLCommand("get_cells");
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
		/// Get a list of generated clocks in the current design
		/// </summary>
		public void get_generated_clocks()
		{
			var command = new SimpleTCLCommand("get_generated_clocks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get hierarchical separator character
		/// </summary>
		public void get_hierarchy_separator()
		{
			var command = new SimpleTCLCommand("get_hierarchy_separator");
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
		/// Get a list of macros in the current design
		/// </summary>
		public void get_macros()
		{
			var command = new SimpleTCLCommand("get_macros");
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
		/// Get properties of object
		/// </summary>
		public void get_property()
		{
			var command = new SimpleTCLCommand("get_property");
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
		/// Get a list of wires.
		/// </summary>
		public void get_wires()
		{
			var command = new SimpleTCLCommand("get_wires");
			_tcl.Add(command);
		}
		/// <summary>
		/// Groups paths for cost function calculations
		/// </summary>
		public void group_path()
		{
			var command = new SimpleTCLCommand("group_path");
			_tcl.Add(command);
		}
		/// <summary>
		/// Make differential pair for 2 ports
		/// </summary>
		public void make_diff_pair_ports()
		{
			var command = new SimpleTCLCommand("make_diff_pair_ports");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove cells from a Pblock
		/// </summary>
		public void remove_cells_from_pblock()
		{
			var command = new SimpleTCLCommand("remove_cells_from_pblock");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reset operating conditions to tool default for power estimation
		/// </summary>
		public void reset_operating_conditions()
		{
			var command = new SimpleTCLCommand("reset_operating_conditions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reset switching activity on specified objects
		/// </summary>
		public void reset_switching_activity()
		{
			var command = new SimpleTCLCommand("reset_switching_activity");
			_tcl.Add(command);
		}
		/// <summary>
		/// Move, resize, add and remove Pblock site-range constraints
		/// </summary>
		public void resize_pblock()
		{
			var command = new SimpleTCLCommand("resize_pblock");
			_tcl.Add(command);
		}
		/// <summary>
		/// Define bus skew
		/// </summary>
		public void set_bus_skew()
		{
			var command = new SimpleTCLCommand("set_bus_skew");
			_tcl.Add(command);
		}
		/// <summary>
		/// Specify that an input is 1, 0, rising or falling
		/// </summary>
		public void set_case_analysis()
		{
			var command = new SimpleTCLCommand("set_case_analysis");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set exclusive or asynchronous clock groups
		/// </summary>
		public void set_clock_groups()
		{
			var command = new SimpleTCLCommand("set_clock_groups");
			_tcl.Add(command);
		}
		/// <summary>
		/// Capture actual or predicted clock latency
		/// </summary>
		public void set_clock_latency()
		{
			var command = new SimpleTCLCommand("set_clock_latency");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set clock sense on ports or pins
		/// </summary>
		public void set_clock_sense()
		{
			var command = new SimpleTCLCommand("set_clock_sense");
			_tcl.Add(command);
		}
		/// <summary>
		/// set clock uncertainty
		/// </summary>
		public void set_clock_uncertainty()
		{
			var command = new SimpleTCLCommand("set_clock_uncertainty");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create data to data checks
		/// </summary>
		public void set_data_check()
		{
			var command = new SimpleTCLCommand("set_data_check");
			_tcl.Add(command);
		}
		/// <summary>
		/// Disable timing arcs
		/// </summary>
		public void set_disable_timing()
		{
			var command = new SimpleTCLCommand("set_disable_timing");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set external delay
		/// </summary>
		public void set_external_delay()
		{
			var command = new SimpleTCLCommand("set_external_delay");
			_tcl.Add(command);
		}
		/// <summary>
		/// Define false path
		/// </summary>
		public void set_false_path()
		{
			var command = new SimpleTCLCommand("set_false_path");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set hierarchical separator character
		/// </summary>
		public void set_hierarchy_separator()
		{
			var command = new SimpleTCLCommand("set_hierarchy_separator");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set input delay on ports
		/// </summary>
		public void set_input_delay()
		{
			var command = new SimpleTCLCommand("set_input_delay");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set input jitter for a clock object
		/// </summary>
		public void set_input_jitter()
		{
			var command = new SimpleTCLCommand("set_input_jitter");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set capacitance on ports and nets
		/// </summary>
		public void set_load()
		{
			var command = new SimpleTCLCommand("set_load");
			_tcl.Add(command);
		}
		/// <summary>
		/// Sets logic dc for port/pins
		/// </summary>
		public void set_logic_dc()
		{
			var command = new SimpleTCLCommand("set_logic_dc");
			_tcl.Add(command);
		}
		/// <summary>
		/// Sets logic one for port/pins
		/// </summary>
		public void set_logic_one()
		{
			var command = new SimpleTCLCommand("set_logic_one");
			_tcl.Add(command);
		}
		/// <summary>
		/// Sets logic unconnected for port/pins
		/// </summary>
		public void set_logic_unconnected()
		{
			var command = new SimpleTCLCommand("set_logic_unconnected");
			_tcl.Add(command);
		}
		/// <summary>
		/// Sets logic zero for port/pins
		/// </summary>
		public void set_logic_zero()
		{
			var command = new SimpleTCLCommand("set_logic_zero");
			_tcl.Add(command);
		}
		/// <summary>
		/// Specify maximum delay for timing paths
		/// </summary>
		public void set_max_delay()
		{
			var command = new SimpleTCLCommand("set_max_delay");
			_tcl.Add(command);
		}
		/// <summary>
		/// Limit time borrowing for latches
		/// </summary>
		public void set_max_time_borrow()
		{
			var command = new SimpleTCLCommand("set_max_time_borrow");
			_tcl.Add(command);
		}
		/// <summary>
		/// Specify minimum delay for timing paths
		/// </summary>
		public void set_min_delay()
		{
			var command = new SimpleTCLCommand("set_min_delay");
			_tcl.Add(command);
		}
		/// <summary>
		/// Define multicycle path
		/// </summary>
		public void set_multicycle_path()
		{
			var command = new SimpleTCLCommand("set_multicycle_path");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set operating conditions for power estimation
		/// </summary>
		public void set_operating_conditions()
		{
			var command = new SimpleTCLCommand("set_operating_conditions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set output delay on ports
		/// </summary>
		public void set_output_delay()
		{
			var command = new SimpleTCLCommand("set_output_delay");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set user columns on one or more package pins
		/// </summary>
		public void set_package_pin_val()
		{
			var command = new SimpleTCLCommand("set_package_pin_val");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set constraints for power optimization
		/// </summary>
		public void set_power_opt()
		{
			var command = new SimpleTCLCommand("set_power_opt");
			_tcl.Add(command);
		}
		/// <summary>
		/// Specify propagated clock latency
		/// </summary>
		public void set_propagated_clock()
		{
			var command = new SimpleTCLCommand("set_propagated_clock");
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
		/// Set switching activity on specified objects or default types
		/// </summary>
		public void set_switching_activity()
		{
			var command = new SimpleTCLCommand("set_switching_activity");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set system jitter
		/// </summary>
		public void set_system_jitter()
		{
			var command = new SimpleTCLCommand("set_system_jitter");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set units for checking
		/// </summary>
		public void set_units()
		{
			var command = new SimpleTCLCommand("set_units");
			_tcl.Add(command);
		}
		/// <summary>
		/// Update a macro
		/// </summary>
		public void update_macro()
		{
			var command = new SimpleTCLCommand("update_macro");
			_tcl.Add(command);
		}
	}
}
