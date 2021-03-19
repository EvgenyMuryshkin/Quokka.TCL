// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class ToolsCommands
	{
		private readonly QuokkaTCL _tcl;
		public ToolsCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Interactive phys_opt_design.
		/// </summary>
		public void iphys_opt_design()
		{
			var command = new SimpleTCLCommand("iphys_opt_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Open a netlist design
		/// </summary>
		public void link_design()
		{
			var command = new SimpleTCLCommand("link_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// List available features.
		/// </summary>
		public void list_features()
		{
			var command = new SimpleTCLCommand("list_features");
			_tcl.Add(command);
		}
		/// <summary>
		/// Load Tcl commands for a specified feature.
		/// </summary>
		public void load_features()
		{
			var command = new SimpleTCLCommand("load_features");
			_tcl.Add(command);
		}
		/// <summary>
		/// Optimize the current netlist. This will perform the retarget, propconst, sweep and
		/// bram_power_opt optimizations by default.
		/// </summary>
		public void opt_design()
		{
			var command = new SimpleTCLCommand("opt_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Optimize the current placed netlist.
		/// </summary>
		public void phys_opt_design()
		{
			var command = new SimpleTCLCommand("phys_opt_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Automatically place ports and leaf-level instances
		/// </summary>
		public void place_design()
		{
			var command = new SimpleTCLCommand("place_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// load iPhysOpt script and run it.
		/// </summary>
		public void read_iphys_opt_tcl()
		{
			var command = new SimpleTCLCommand("read_iphys_opt_tcl");
			_tcl.Add(command);
		}
		/// <summary>
		/// Register a Tcl proc with Vivado.
		/// </summary>
		public void register_proc()
		{
			var command = new SimpleTCLCommand("register_proc");
			_tcl.Add(command);
		}
		/// <summary>
		/// Perform pipeline register insertion analysis and display report.
		/// </summary>
		public void report_pipeline_analysis()
		{
			var command = new SimpleTCLCommand("report_pipeline_analysis");
			_tcl.Add(command);
		}
		/// <summary>
		/// Route the current design
		/// </summary>
		public void route_design()
		{
			var command = new SimpleTCLCommand("route_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Synthesize a design using Vivado Synthesis and open that design
		/// </summary>
		public void synth_design()
		{
			var command = new SimpleTCLCommand("synth_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Unregister a previously registered Tcl proc.
		/// </summary>
		public void unregister_proc()
		{
			var command = new SimpleTCLCommand("unregister_proc");
			_tcl.Add(command);
		}
		/// <summary>
		/// Update clock routing on global clocks if they are modified after placement
		/// </summary>
		public void update_clock_routing()
		{
			var command = new SimpleTCLCommand("update_clock_routing");
			_tcl.Add(command);
		}
		/// <summary>
		/// Update the NoC solution
		/// </summary>
		public void update_noc_qos()
		{
			var command = new SimpleTCLCommand("update_noc_qos");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write iPhysOpt script.
		/// </summary>
		public void write_iphys_opt_tcl()
		{
			var command = new SimpleTCLCommand("write_iphys_opt_tcl");
			_tcl.Add(command);
		}
	}
}
