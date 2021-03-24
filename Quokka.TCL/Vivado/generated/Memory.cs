// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
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
		/// Call IP Services to regenerate an IP, then stitch it into the current netlist
		///
		///
		/// TCL Syntax: implement_mig_cores [-outputdir <arg>] [-rtlonly] [-force] [-debug_output] [-quiet] [-verbose]
		///
		/// Implements the memory IP cores in the current project.
		/// Memory IP included in the Xilinx® IP catalog are used to generate memory controllers and
		/// interfaces for Xilinx devices. Memory IP includes different IP cores from the Xilinx IP catalog
		/// depending on the device architecture and memory interface specified. Refer to Zynq-7000 SoC
		/// and 7 Series Devices Memory Interface Solutions (UG586), or UltraScale Architecture-Based FPGAs
		/// Memory Interface Solutions (PG150), for details of the available memory IP.
		/// The implement_mig_cores command generates the RTL information for the physical
		/// interface (PHY) of the memory controller, and integrates the synthesized netlist of the memory
		/// controller into the top-level design.
		/// A memory controller can be debug enabled when added into the design from the Xilinx IP
		/// catalog. In the Vivado logic analyzer, or the Vivado Lab Edition, memory controllers implemented
		/// into a design are associated with hw_mig objects, one hw_mig object per debug-enabled memory
		/// controller. The hw_mig object will have all the properties needed to get the calibration status and
		/// draw the per-bit eye margin views.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Implementation of the memory IP, and debug core, is automatic when you launch an
		/// implementation run using the launch_runs command, or when you run opt_design.
		/// However, you can also use the implement_mig_cores command to integrate the memory IP
		/// without having to implement the whole design.
		/// TIP: All pins of the memory controller must be assigned prior to running the implement_mig_cores
		/// command, or an error will be returned. You can use report_drc to check the status of the memory
		/// controller.
		/// This command returns a transcript of its process, or returns an error if it fails.
		///
		/// The following example implements the memory IP cores in the current design:
		/// implement_mig_cores
		///
		/// See ug835-vivado-tcl-commands.pdf, page 980
		/// </summary>
		/// <param name="outputdir">(Optional) Target Output Directory for PHY IP Generated Files Default: empty</param>
		/// <param name="rtlonly">
		/// (Optional)
		/// Run the complete process to generate the PHY RTL code but
		/// do not replace the PHY core netlist
		/// </param>
		/// <param name="force">
		/// (Optional)
		/// Implement all non-optimized memory cores. When use with
		/// -rtlonly, optimized cores will be included, as well.
		/// </param>
		/// <param name="debug_output">(Optional) Enable debugging output.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL implement_mig_cores(string outputdir = null, bool? rtlonly = null, bool? force = null, bool? debug_output = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: implement_mig_cores [-outputdir <arg>] [-rtlonly] [-force] [-debug_output] [-quiet] [-verbose]
			_tcl.Entry(_builder.implement_mig_cores(outputdir, rtlonly, force, debug_output, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Call IP Services to regenerate an IP, then stitch it into the current netlist
		///
		///
		/// TCL Syntax: implement_xphy_cores [-outputdir <arg>] [-rtlonly] [-force] [-debug_output] [-update_delay_value_only] [-quiet] [-verbose]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 983
		/// </summary>
		/// <param name="outputdir">(Optional) Target Output Directory for PHY IP Generated Files Default: empty</param>
		/// <param name="rtlonly">
		/// (Optional)
		/// Run the complete process to generate the PHY RTL code but
		/// do not replace the PHY core netlist
		/// </param>
		/// <param name="force">
		/// (Optional)
		/// Implement all non-optimized memory cores. When use with
		/// -rtlonly, optimized cores will be included, as well.
		/// </param>
		/// <param name="debug_output">(Optional) Enable debugging output.</param>
		/// <param name="update_delay_value_only">(Optional) Update latest Delay value.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL implement_xphy_cores(string outputdir = null, bool? rtlonly = null, bool? force = null, bool? debug_output = null, bool? update_delay_value_only = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: implement_xphy_cores [-outputdir <arg>] [-rtlonly] [-force] [-debug_output] [-update_delay_value_only] [-quiet] [-verbose]
			_tcl.Entry(_builder.implement_xphy_cores(outputdir, rtlonly, force, debug_output, update_delay_value_only, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Update and initialize the BRAM initialization strings with contents of elf files.
		///
		///
		/// TCL Syntax: refresh_meminit [-quiet] [-verbose]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1223
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
