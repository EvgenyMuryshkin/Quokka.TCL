// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class ToolLaunchCommands
	{
		private readonly QuokkaTCL _tcl;
		public ToolLaunchCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Get registered simulators
		/// </summary>
		public void get_simulators()
		{
			var command = new SimpleTCLCommand("get_simulators");
			_tcl.Add(command);
		}
		/// <summary>
		/// Issues an error that you can not run this command
		/// </summary>
		public void launch_chipscope_analyzer()
		{
			var command = new SimpleTCLCommand("launch_chipscope_analyzer");
			_tcl.Add(command);
		}
		/// <summary>
		/// Issues an error that you can not run this command
		/// </summary>
		public void launch_impact()
		{
			var command = new SimpleTCLCommand("launch_impact");
			_tcl.Add(command);
		}
		/// <summary>
		/// Launch simulation
		/// </summary>
		public void launch_simulation()
		{
			var command = new SimpleTCLCommand("launch_simulation");
			_tcl.Add(command);
		}
	}
}
