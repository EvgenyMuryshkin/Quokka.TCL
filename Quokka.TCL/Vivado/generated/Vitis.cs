// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class VitisCommands
	{
		private readonly QuokkaTCL _tcl;
		public VitisCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Open the Xilinx Shell Archive
		/// </summary>
		public void open_hw_platform()
		{
			var command = new SimpleTCLCommand("open_hw_platform");
			_tcl.Add(command);
		}
		/// <summary>
		/// Validate the specified harware platform
		/// </summary>
		public void validate_hw_platform()
		{
			var command = new SimpleTCLCommand("validate_hw_platform");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write the Xilinx Shell Archive for the current design
		/// </summary>
		public void write_hw_platform()
		{
			var command = new SimpleTCLCommand("write_hw_platform");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write the unified JSON metadata file for the current design
		/// </summary>
		public void write_hw_platform_metadata()
		{
			var command = new SimpleTCLCommand("write_hw_platform_metadata");
			_tcl.Add(command);
		}
	}
}
