// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class ConfigurationCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public ConfigurationCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
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
		/// See ug835-vivado-tcl-commands.pdf, page 177
		/// </summary>
		/// <param name="list">(Required) list of config params which need to be configured</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL config_implementation(string list, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: config_implementation [-quiet] [-verbose] [<list>]
			_tcl.Entry(_builder.config_implementation(list, quiet, verbose));
			return _tcl;
		}
	}
}
