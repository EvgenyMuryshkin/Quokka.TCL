#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class vivado_preferencesCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public vivado_preferencesCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// <para>
		/// Returns the vivado prefernces object.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_vivado_preferences [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 423<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL current_vivado_preferences(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: current_vivado_preferences [-quiet] [-verbose]
			_tcl.Entry(_builder.current_vivado_preferences(quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
