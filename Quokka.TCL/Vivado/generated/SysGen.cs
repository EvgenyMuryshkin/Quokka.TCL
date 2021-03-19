// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class SysGenCommands
	{
		private readonly QuokkaTCL _tcl;
		public SysGenCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Create DSP source for Xilinx System Generator and add to the source fileset
		/// </summary>
		public void create_sysgen()
		{
			var command = new SimpleTCLCommand("create_sysgen");
			_tcl.Add(command);
		}
		/// <summary>
		/// Generate HDL wrapper for the specified source
		/// </summary>
		public void make_wrapper()
		{
			var command = new SimpleTCLCommand("make_wrapper");
			_tcl.Add(command);
		}
	}
}
