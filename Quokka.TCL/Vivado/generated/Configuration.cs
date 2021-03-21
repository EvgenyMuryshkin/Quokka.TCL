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
		///
		/// This command lets you configure implementation parameters to control the behavior of the
		/// implementation process.
		/// The list of properties that can be configured, or have been configured by this command can be
		/// reported by the report_config_implementation command.
		///
		/// The following example configures implementation parameters:
		/// config_implementation { {incr.ignore_user_clock_uncertainty True}
		/// {<other_param> <other_value>} }
		///
		/// See ug835-vivado-tcl-commands.pdf, page 172
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="list">
		/// Optional
		/// list of config params which need to be configured
		/// </param>
		public void config_implementation(bool? quiet = null, bool? verbose = null, string list = null)
		{
			var command = new SimpleTCLCommand("config_implementation");
			_tcl.Add(command);
		}
	}
}
