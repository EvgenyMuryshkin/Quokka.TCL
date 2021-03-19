// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class MemoryCommands
	{
		private readonly QuokkaTCL _tcl;
		public MemoryCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Call IP Services to regenerate an IP, then stitch it into the current netlist
		/// </summary>
		public void implement_mig_cores()
		{
			var command = new SimpleTCLCommand("implement_mig_cores");
			_tcl.Add(command);
		}
		/// <summary>
		/// Call IP Services to regenerate an IP, then stitch it into the current netlist
		/// </summary>
		public void implement_xphy_cores()
		{
			var command = new SimpleTCLCommand("implement_xphy_cores");
			_tcl.Add(command);
		}
		/// <summary>
		/// Update and initialize the BRAM initialization strings with contents of elf files.
		/// </summary>
		public void refresh_meminit()
		{
			var command = new SimpleTCLCommand("refresh_meminit");
			_tcl.Add(command);
		}
	}
}
