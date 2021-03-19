// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class ConfigurationCommands
	{
		private readonly QuokkaTCL _tcl;
		public ConfigurationCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Configure Implementation
		/// </summary>
		public void config_implementation()
		{
			var command = new SimpleTCLCommand("config_implementation");
			_tcl.Add(command);
		}
	}
}
