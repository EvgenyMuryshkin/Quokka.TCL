// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class ConfigurationCommands
	{
		private readonly TCLFile<VivadoTCL> _tcl;
		public ConfigurationCommands(TCLFile<VivadoTCL> tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Configure Implementation
		///
		///
		/// TCL Syntax: config_implementation [-quiet] [-verbose] [<list>]
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
		/// <param name="list">
		/// Required
		/// list of config params which need to be configured
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void config_implementation(string list, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: config_implementation [-quiet] [-verbose] [<list>]
			_tcl.Add(
				new SimpleTCLCommand("config_implementation")
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.RequiredString(list)
			);
		}
	}
}
