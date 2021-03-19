// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class ReportCommands
	{
		private readonly QuokkaTCL _tcl;
		public ReportCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Calculate device configuration time (ms)
		/// </summary>
		public void calc_config_time()
		{
			var command = new SimpleTCLCommand("calc_config_time");
			_tcl.Add(command);
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
		/// Create a DRC violation
		/// </summary>
		public void create_drc_violation()
		{
			var command = new SimpleTCLCommand("create_drc_violation");
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
		/// Create histogram
		/// </summary>
		public void create_slack_histogram()
		{
			var command = new SimpleTCLCommand("create_slack_histogram");
			_tcl.Add(command);
		}
		/// <summary>
		/// Clear a set of clock networks results from memory
		/// </summary>
		public void delete_clock_networks_results()
		{
			var command = new SimpleTCLCommand("delete_clock_networks_results");
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
		/// Clear a set of timing results from memory
		/// </summary>
		public void delete_timing_results()
		{
			var command = new SimpleTCLCommand("delete_timing_results");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete utilization results that were stored in memory under a given name.
		/// </summary>
		public void delete_utilization_results()
		{
			var command = new SimpleTCLCommand("delete_utilization_results");
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
		/// Returns the current message count, limit, or the message configuration rules previously defined
		/// by the set_msg_config command.
		/// </summary>
		public void get_msg_config()
		{
			var command = new SimpleTCLCommand("get_msg_config");
			_tcl.Add(command);
		}
		/// <summary>
		/// Internal TCL task for reporting PPLOCs on pins or nets
		/// </summary>
		public void get_pplocs()
		{
			var command = new SimpleTCLCommand("get_pplocs");
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
		/// Open report from .rpx file
		/// </summary>
		public void open_report()
		{
			var command = new SimpleTCLCommand("open_report");
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
		/// Report carry chains
		/// </summary>
		public void report_carry_chains()
		{
			var command = new SimpleTCLCommand("report_carry_chains");
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
		/// Report Implementation flow Config param
		/// </summary>
		public void report_config_implementation()
		{
			var command = new SimpleTCLCommand("report_config_implementation");
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
		/// Report the unique control sets in design
		/// </summary>
		public void report_control_sets()
		{
			var command = new SimpleTCLCommand("report_control_sets");
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
		/// Report details on debug cores
		/// </summary>
		public void report_debug_core()
		{
			var command = new SimpleTCLCommand("report_debug_core");
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
		/// Report system information.
		/// </summary>
		public void report_environment()
		{
			var command = new SimpleTCLCommand("report_environment");
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
		/// Formatted report on Versal integrated and soft Memory Controllers' (DDRMCs) memory
		/// configurations, calibration status, stages, and window margins data.
		/// </summary>
		public void report_hw_ddrmc()
		{
			var command = new SimpleTCLCommand("report_hw_ddrmc");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report formatted hardware MIG calibration status and margin data
		/// </summary>
		public void report_hw_mig()
		{
			var command = new SimpleTCLCommand("report_hw_mig");
			_tcl.Add(command);
		}
		/// <summary>
		/// Compute achievable incremental reuse for the given design-checkpoint and report
		/// </summary>
		public void report_incremental_reuse()
		{
			var command = new SimpleTCLCommand("report_incremental_reuse");
			_tcl.Add(command);
		}
		/// <summary>
		/// Display information about all the IO sites on the device
		/// </summary>
		public void report_io()
		{
			var command = new SimpleTCLCommand("report_io");
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
		/// Get operating conditions values for power estimation
		/// </summary>
		public void report_operating_conditions()
		{
			var command = new SimpleTCLCommand("report_operating_conditions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get information about all parameters
		/// </summary>
		public void report_param()
		{
			var command = new SimpleTCLCommand("report_param");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report details of Physical Synthesis transformations.
		/// </summary>
		public void report_phys_opt()
		{
			var command = new SimpleTCLCommand("report_phys_opt");
			_tcl.Add(command);
		}
		/// <summary>
		/// Run power estimation and display report
		/// </summary>
		public void report_power()
		{
			var command = new SimpleTCLCommand("report_power");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report reconfigurable partition analysis across multiple configurations
		/// </summary>
		public void report_pr_configuration_analysis()
		{
			var command = new SimpleTCLCommand("report_pr_configuration_analysis");
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
		/// Report configuration about RAMs in design
		/// </summary>
		public void report_ram_utilization()
		{
			var command = new SimpleTCLCommand("report_ram_utilization");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report on status of the routing.
		/// </summary>
		public void report_route_status()
		{
			var command = new SimpleTCLCommand("report_route_status");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report the list of correct SIM_DEVICE attribute values for cell types in the target part
		/// </summary>
		public void report_sim_device()
		{
			var command = new SimpleTCLCommand("report_sim_device");
			_tcl.Add(command);
		}
		/// <summary>
		/// Run SSN analysis on the current package and pinout
		/// </summary>
		public void report_ssn()
		{
			var command = new SimpleTCLCommand("report_ssn");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get switching activity on specified objects
		/// </summary>
		public void report_switching_activity()
		{
			var command = new SimpleTCLCommand("report_switching_activity");
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
		/// Report details of Unisim primitive transformations.
		/// </summary>
		public void report_transformed_primitives()
		{
			var command = new SimpleTCLCommand("report_transformed_primitives");
			_tcl.Add(command);
		}
		/// <summary>
		/// Compute utilization of device and display report
		/// </summary>
		public void report_utilization()
		{
			var command = new SimpleTCLCommand("report_utilization");
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
		/// Remove DRC report
		/// </summary>
		public void reset_drc()
		{
			var command = new SimpleTCLCommand("reset_drc");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove Methodology report
		/// </summary>
		public void reset_methodology()
		{
			var command = new SimpleTCLCommand("reset_methodology");
			_tcl.Add(command);
		}
		/// <summary>
		/// Resets or removes a message control rule previously defined by the set_msg_config command.
		/// </summary>
		public void reset_msg_config()
		{
			var command = new SimpleTCLCommand("reset_msg_config");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reset message count
		/// </summary>
		public void reset_msg_count()
		{
			var command = new SimpleTCLCommand("reset_msg_count");
			_tcl.Add(command);
		}
		/// <summary>
		/// Clear a SSN results set from memory
		/// </summary>
		public void reset_ssn()
		{
			var command = new SimpleTCLCommand("reset_ssn");
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
		/// Configure how the Vivado tool will display and manage specific messages, based on message ID,
		/// string, or severity.
		/// </summary>
		public void set_msg_config()
		{
			var command = new SimpleTCLCommand("set_msg_config");
			_tcl.Add(command);
		}
		/// <summary>
		/// Returns the build for Vivado and the build date
		/// </summary>
		public void version()
		{
			var command = new SimpleTCLCommand("version");
			_tcl.Add(command);
		}
	}
}
