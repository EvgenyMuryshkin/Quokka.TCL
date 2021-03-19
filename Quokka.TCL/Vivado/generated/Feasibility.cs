// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class FeasibilityCommands
	{
		private readonly QuokkaTCL _tcl;
		public FeasibilityCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
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
		/// Get a list of available QoR suggestions
		/// </summary>
		public void get_qor_suggestions()
		{
			var command = new SimpleTCLCommand("get_qor_suggestions");
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
		/// Write QoR Suggestions to the given file
		/// </summary>
		public void write_qor_suggestions()
		{
			var command = new SimpleTCLCommand("write_qor_suggestions");
			_tcl.Add(command);
		}
	}
}
