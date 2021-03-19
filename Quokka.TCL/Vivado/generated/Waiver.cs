// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class WaiverCommands
	{
		private readonly QuokkaTCL _tcl;
		public WaiverCommands(QuokkaTCL tcl)
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
		/// Delete one or more DRC/METHODOLOGY/CDC message waivers
		/// </summary>
		public void delete_waivers()
		{
			var command = new SimpleTCLCommand("delete_waivers");
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
		/// Report status of DRC/METHODOLOGY/CDC message waivers
		/// </summary>
		public void report_waivers()
		{
			var command = new SimpleTCLCommand("report_waivers");
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
