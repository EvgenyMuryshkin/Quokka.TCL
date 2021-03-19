// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class PowerCommands
	{
		private readonly QuokkaTCL _tcl;
		public PowerCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Delete power results that were stored in memory under a given name.
		/// </summary>
		public void delete_power_results()
		{
			var command = new SimpleTCLCommand("delete_power_results");
			_tcl.Add(command);
		}
		/// <summary>
		/// Optimize dynamic power using intelligent clock gating
		/// </summary>
		public void power_opt_design()
		{
			var command = new SimpleTCLCommand("power_opt_design");
			_tcl.Add(command);
		}
		/// <summary>
		/// Import simulation data in saif format
		/// </summary>
		public void read_saif()
		{
			var command = new SimpleTCLCommand("read_saif");
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
		/// Report power optimizations
		/// </summary>
		public void report_power_opt()
		{
			var command = new SimpleTCLCommand("report_power_opt");
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
		/// Set operating conditions for power estimation
		/// </summary>
		public void set_operating_conditions()
		{
			var command = new SimpleTCLCommand("set_operating_conditions");
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
		/// Set switching activity on specified objects or default types
		/// </summary>
		public void set_switching_activity()
		{
			var command = new SimpleTCLCommand("set_switching_activity");
			_tcl.Add(command);
		}
	}
}
