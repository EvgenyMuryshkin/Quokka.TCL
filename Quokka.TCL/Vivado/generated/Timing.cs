// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class TimingCommands
	{
		private readonly QuokkaTCL _tcl;
		public TimingCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Check the design for possible timing problems
		/// </summary>
		public void check_timing()
		{
			var command = new SimpleTCLCommand("check_timing");
			_tcl.Add(command);
		}
		/// <summary>
		/// This command configures general features of design analysis.
		/// </summary>
		public void config_design_analysis()
		{
			var command = new SimpleTCLCommand("config_design_analysis");
			_tcl.Add(command);
		}
		/// <summary>
		/// Configure timing analysis general settings
		/// </summary>
		public void config_timing_analysis()
		{
			var command = new SimpleTCLCommand("config_timing_analysis");
			_tcl.Add(command);
		}
		/// <summary>
		/// Configure single / multi corner timing analysis settings
		/// </summary>
		public void config_timing_corners()
		{
			var command = new SimpleTCLCommand("config_timing_corners");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create histogram
		/// </summary>
		public void create_slack_histogram()
		{
			var command = new SimpleTCLCommand("create_slack_histogram");
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
		/// Clear a set of timing results from memory
		/// </summary>
		public void delete_timing_results()
		{
			var command = new SimpleTCLCommand("delete_timing_results");
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
		/// Get a list of available QoR suggestions
		/// </summary>
		public void get_qor_suggestions()
		{
			var command = new SimpleTCLCommand("get_qor_suggestions");
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
		/// Read QoR Suggestions from the given file
		/// </summary>
		public void read_qor_suggestions()
		{
			var command = new SimpleTCLCommand("read_qor_suggestions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report timing paths
		/// </summary>
		public void report_bus_skew()
		{
			var command = new SimpleTCLCommand("report_bus_skew");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report the clock domain crossing (CDC) paths in the current design.
		/// </summary>
		public void report_cdc()
		{
			var command = new SimpleTCLCommand("report_cdc");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report on clock timing paths and unclocked registers
		/// </summary>
		public void report_clock_interaction()
		{
			var command = new SimpleTCLCommand("report_clock_interaction");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report clock networks
		/// </summary>
		public void report_clock_networks()
		{
			var command = new SimpleTCLCommand("report_clock_networks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report information about clock nets in design
		/// </summary>
		public void report_clock_utilization()
		{
			var command = new SimpleTCLCommand("report_clock_utilization");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report clocks
		/// </summary>
		public void report_clocks()
		{
			var command = new SimpleTCLCommand("report_clocks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report settings affecting timing analysis
		/// </summary>
		public void report_config_timing()
		{
			var command = new SimpleTCLCommand("report_config_timing");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report data sheet
		/// </summary>
		public void report_datasheet()
		{
			var command = new SimpleTCLCommand("report_datasheet");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report Design Analysis
		/// </summary>
		public void report_design_analysis()
		{
			var command = new SimpleTCLCommand("report_design_analysis");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report disabled timing arcs
		/// </summary>
		public void report_disable_timing()
		{
			var command = new SimpleTCLCommand("report_disable_timing");
			_tcl.Add(command);
		}
		/// <summary>
		/// Run DRC
		/// </summary>
		public void report_drc()
		{
			var command = new SimpleTCLCommand("report_drc");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report timing exceptions
		/// </summary>
		public void report_exceptions()
		{
			var command = new SimpleTCLCommand("report_exceptions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report high fanout nets
		/// </summary>
		public void report_high_fanout_nets()
		{
			var command = new SimpleTCLCommand("report_high_fanout_nets");
			_tcl.Add(command);
		}
		/// <summary>
		/// Methodology Checks
		/// </summary>
		public void report_methodology()
		{
			var command = new SimpleTCLCommand("report_methodology");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report pulse width check
		/// </summary>
		public void report_pulse_width()
		{
			var command = new SimpleTCLCommand("report_pulse_width");
			_tcl.Add(command);
		}
		/// <summary>
		/// Feasibility Checks
		/// </summary>
		public void report_qor_assessment()
		{
			var command = new SimpleTCLCommand("report_qor_assessment");
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
		/// Compute mean time between failures and display report
		/// </summary>
		public void report_synchronizer_mtbf()
		{
			var command = new SimpleTCLCommand("report_synchronizer_mtbf");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report timing paths
		/// </summary>
		public void report_timing()
		{
			var command = new SimpleTCLCommand("report_timing");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report timing summary
		/// </summary>
		public void report_timing_summary()
		{
			var command = new SimpleTCLCommand("report_timing_summary");
			_tcl.Add(command);
		}
		/// <summary>
		/// Resets the timing information on the current design
		/// </summary>
		public void reset_timing()
		{
			var command = new SimpleTCLCommand("reset_timing");
			_tcl.Add(command);
		}
		/// <summary>
		/// Sets the interconnect delay model for timing analysis.
		/// </summary>
		public void set_delay_model()
		{
			var command = new SimpleTCLCommand("set_delay_model");
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
		/// update timing
		/// </summary>
		public void update_timing()
		{
			var command = new SimpleTCLCommand("update_timing");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write file with inferred xdc timing constraints
		/// </summary>
		public void write_inferred_xdc()
		{
			var command = new SimpleTCLCommand("write_inferred_xdc");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write QoR Suggestions to the given file
		/// </summary>
		public void write_qor_suggestions()
		{
			var command = new SimpleTCLCommand("write_qor_suggestions");
			_tcl.Add(command);
		}
		/// <summary>
		/// write_sdf command generates flat sdf delay files for event simulation
		/// </summary>
		public void write_sdf()
		{
			var command = new SimpleTCLCommand("write_sdf");
			_tcl.Add(command);
		}
		/// <summary>
		/// Writes constraints to a Xilinx Design Constraints (XDC) file. The default file extension for a XDC
		/// file is .xdc.
		/// </summary>
		public void write_xdc()
		{
			var command = new SimpleTCLCommand("write_xdc");
			_tcl.Add(command);
		}
	}
}
