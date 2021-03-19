// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class SDCCommands
	{
		private readonly QuokkaTCL _tcl;
		public SDCCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
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
		/// Get a list of all input ports in the current design
		/// </summary>
		public void all_inputs()
		{
			var command = new SimpleTCLCommand("all_inputs");
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
		/// Get a list of register cells or pins in the current design
		/// </summary>
		public void all_registers()
		{
			var command = new SimpleTCLCommand("all_registers");
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
		/// Create a generated clock object
		/// </summary>
		public void create_generated_clock()
		{
			var command = new SimpleTCLCommand("create_generated_clock");
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
		/// Get hierarchical separator character
		/// </summary>
		public void get_hierarchy_separator()
		{
			var command = new SimpleTCLCommand("get_hierarchy_separator");
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
		/// Get a list of pins in the current design
		/// </summary>
		public void get_pins()
		{
			var command = new SimpleTCLCommand("get_pins");
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
		/// Groups paths for cost function calculations
		/// </summary>
		public void group_path()
		{
			var command = new SimpleTCLCommand("group_path");
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
		/// Specify propagated clock latency
		/// </summary>
		public void set_propagated_clock()
		{
			var command = new SimpleTCLCommand("set_propagated_clock");
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
	}
}
