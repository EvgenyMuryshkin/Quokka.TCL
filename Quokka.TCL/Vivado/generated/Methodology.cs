// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class MethodologyCommands
	{
		private readonly QuokkaTCL _tcl;
		public MethodologyCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
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
		/// Methodology Checks
		/// </summary>
		public void report_methodology()
		{
			var command = new SimpleTCLCommand("report_methodology");
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
		/// Reset one or more Methodology checks to factory defaults.
		/// </summary>
		public void reset_methodology_check()
		{
			var command = new SimpleTCLCommand("reset_methodology_check");
			_tcl.Add(command);
		}
	}
}
