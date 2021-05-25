#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class MemoryCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public MemoryCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// <para>
		/// Call IP Services to regenerate an IP, then stitch it into the current netlist<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: implement_mig_cores [-outputdir &lt;arg&gt;] [-rtlonly] [-force] [-debug_output] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Implements the memory IP cores in the current project.<br/>
		/// Memory IP included in the Xilinx® IP catalog are used to generate memory controllers and<br/>
		/// interfaces for Xilinx devices. Memory IP includes different IP cores from the Xilinx IP catalog<br/>
		/// depending on the device architecture and memory interface specified. Refer to Zynq-7000 SoC<br/>
		/// and 7 Series Devices Memory Interface Solutions (UG586), or UltraScale Architecture-Based FPGAs<br/>
		/// Memory Interface Solutions (PG150), for details of the available memory IP.<br/>
		/// The implement_mig_cores command generates the RTL information for the physical<br/>
		/// interface (PHY) of the memory controller, and integrates the synthesized netlist of the memory<br/>
		/// controller into the top-level design.<br/>
		/// A memory controller can be debug enabled when added into the design from the Xilinx IP<br/>
		/// catalog. In the Vivado logic analyzer, or the Vivado Lab Edition, memory controllers implemented<br/>
		/// into a design are associated with hw_mig objects, one hw_mig object per debug-enabled memory<br/>
		/// controller. The hw_mig object will have all the properties needed to get the calibration status and<br/>
		/// draw the per-bit eye margin views.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Implementation of the memory IP, and debug core, is automatic when you launch an<br/>
		/// implementation run using the launch_runs command, or when you run opt_design.<br/>
		/// However, you can also use the implement_mig_cores command to integrate the memory IP<br/>
		/// without having to implement the whole design.<br/>
		/// TIP: All pins of the memory controller must be assigned prior to running the implement_mig_cores<br/>
		/// command, or an error will be returned. You can use report_drc to check the status of the memory<br/>
		/// controller.<br/>
		/// This command returns a transcript of its process, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example implements the memory IP cores in the current design:<br/>
		/// implement_mig_cores<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 980<br/>
		/// </para>
		/// </summary>
		/// <param name="outputdir">(Optional) Target Output Directory for PHY IP Generated Files Default: empty</param>
		/// <param name="rtlonly">
		/// <para>
		/// (Optional)<br/>
		/// Run the complete process to generate the PHY RTL code but<br/>
		/// do not replace the PHY core netlist<br/>
		/// </para>
		/// </param>
		/// <param name="force">
		/// <para>
		/// (Optional)<br/>
		/// Implement all non-optimized memory cores. When use with<br/>
		/// -rtlonly, optimized cores will be included, as well.<br/>
		/// </para>
		/// </param>
		/// <param name="debug_output">(Optional) Enable debugging output.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL implement_mig_cores(String outputdir = null, bool? rtlonly = null, bool? force = null, bool? debug_output = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: implement_mig_cores [-outputdir <arg>] [-rtlonly] [-force] [-debug_output] [-quiet] [-verbose]
			_tcl.Entry(_builder.implement_mig_cores(outputdir, rtlonly, force, debug_output, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Call IP Services to regenerate an IP, then stitch it into the current netlist<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: implement_xphy_cores [-outputdir &lt;arg&gt;] [-rtlonly] [-force] [-debug_output] [-update_delay_value_only] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 983<br/>
		/// </para>
		/// </summary>
		/// <param name="outputdir">(Optional) Target Output Directory for PHY IP Generated Files Default: empty</param>
		/// <param name="rtlonly">
		/// <para>
		/// (Optional)<br/>
		/// Run the complete process to generate the PHY RTL code but<br/>
		/// do not replace the PHY core netlist<br/>
		/// </para>
		/// </param>
		/// <param name="force">
		/// <para>
		/// (Optional)<br/>
		/// Implement all non-optimized memory cores. When use with<br/>
		/// -rtlonly, optimized cores will be included, as well.<br/>
		/// </para>
		/// </param>
		/// <param name="debug_output">(Optional) Enable debugging output.</param>
		/// <param name="update_delay_value_only">(Optional) Update latest Delay value.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL implement_xphy_cores(String outputdir = null, bool? rtlonly = null, bool? force = null, bool? debug_output = null, bool? update_delay_value_only = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: implement_xphy_cores [-outputdir <arg>] [-rtlonly] [-force] [-debug_output] [-update_delay_value_only] [-quiet] [-verbose]
			_tcl.Entry(_builder.implement_xphy_cores(outputdir, rtlonly, force, debug_output, update_delay_value_only, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Update and initialize the BRAM initialization strings with contents of elf files.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: refresh_meminit [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1223<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_meminit(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_meminit [-quiet] [-verbose]
			_tcl.Entry(_builder.refresh_meminit(quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
