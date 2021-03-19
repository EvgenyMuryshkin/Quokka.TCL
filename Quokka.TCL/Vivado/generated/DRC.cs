// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class DRCCommands
	{
		private readonly QuokkaTCL _tcl;
		public DRCCommands(QuokkaTCL tcl)
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
		/// Create a DRC violation
		/// </summary>
		public void create_drc_violation()
		{
			var command = new SimpleTCLCommand("create_drc_violation");
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
		/// Remove DRC rule check objects from a user rule deck
		/// </summary>
		public void remove_drc_checks()
		{
			var command = new SimpleTCLCommand("remove_drc_checks");
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
		/// Remove DRC report
		/// </summary>
		public void reset_drc()
		{
			var command = new SimpleTCLCommand("reset_drc");
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
	}
}
