// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class VitisCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public VitisCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// Open the Xilinx Shell Archive
		///
		///
		/// TCL Syntax: open_hw_platform [-auto_upgrade] [-quiet] [-verbose] [<file>]
		///
		/// Open a Xilinx support archive (XSA) file and extract the Vivado project, block design, and IP from
		/// the archive. This will create a project directory and project file (.xpr) from the XSA.
		/// Note: The project will be created in the current working directory, or the directory from which the Vivado
		/// tool was launched.
		/// This command returns a transcript of its actions, or returns an error if it fails.
		///
		/// The following example opens the specified XSA, automatically upgrading the IP as needed:
		/// open_hw_platform -auto_upgrade C:/Data/zc706.xsa
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1059
		/// </summary>
		/// <param name="file">
		/// (Required)
		/// Xilinx Shell Archive file Values: A filename with alphanumeric
		/// characters and .dsa/.xsa extension.
		/// </param>
		/// <param name="auto_upgrade">(Optional) Automatically upgrade the BD</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The name of the shell file</returns>
		public TTCL open_hw_platform(string file, bool? auto_upgrade = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: open_hw_platform [-auto_upgrade] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.open_hw_platform(file, auto_upgrade, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Validate the specified harware platform
		///
		///
		/// TCL Syntax: validate_hw_platform [-verbose] [-quiet] [<file>]
		///
		/// Validate a Xilinx support archive (XSA) file to ensure it has the required content for the platform.
		/// This command returns information related to the validation of the XSA, or returns an error if it
		/// fails.
		///
		/// The following example validates the specified XSA, returning verbose information related to the
		/// platform contents:
		/// validate_hw_platform C:/Data/zc706.xsa -verbose
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1762
		/// </summary>
		/// <param name="verbose">(Optional) Dump verbose information</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="file">(Optional) Xilinx Shell Archive file Values: Path to shell file.</param>
		/// <returns>The name of the shell file</returns>
		public TTCL validate_hw_platform(bool? verbose = null, bool? quiet = null, string file = null)
		{
			// TCL Syntax: validate_hw_platform [-verbose] [-quiet] [<file>]
			_tcl.Entry(_builder.validate_hw_platform(verbose, quiet, file));
			return _tcl;
		}
		/// <summary>
		/// Write the Xilinx Shell Archive for the current design
		///
		///
		/// TCL Syntax: write_hw_platform [-fixed] [-force] [-include_bit] [-include_emulation] [-minimal] [-quiet] [-verbose] [<file>]
		///
		/// Writes a Xilinx support archive (XSA) of the current design for use as a hardware platform.
		/// All platforms are dynamically implemented during compilation, meaning that the accelerator logic
		/// coming is implemented along with some or all of the logic contained in the hardware platform
		/// design. The XSA represents the required portion of the hardware platform. The hardware
		/// platform design used to create a XSA consists of a Vivado IP integrator subsystem design with all
		/// the required board interface IP cores configured and connected to the device I/Os. The Vivado
		/// project must also include several required XSA and PFM properties needed to define the XSA.
		/// This command reports the name of the XSA file written, or returns an error if it fails.
		///
		/// The following example writes the XSA for the current project, overwriting a XSA file of the same
		/// name if one exists:
		/// write_XSA -force C:/Data/zc702.xsa
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1813
		/// </summary>
		/// <param name="file">
		/// (Required)
		/// Device Support Archive file Values: A filename with
		/// alphanumeric characters and .xsa extension.
		/// </param>
		/// <param name="@fixed">(Optional) Write fixed Shell.</param>
		/// <param name="force">(Optional) Overwrite existing Xilinx Shell Archive file</param>
		/// <param name="include_bit">(Optional) Include bit file(s) in the Shell.</param>
		/// <param name="include_emulation">(Optional) Generate and include hardware emulation support in the Shell.</param>
		/// <param name="minimal">(Optional) Add only minimal files in the Shell.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The name of the Shell file</returns>
		public TTCL write_hw_platform(string file, bool? @fixed = null, bool? force = null, bool? include_bit = null, bool? include_emulation = null, bool? minimal = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_hw_platform [-fixed] [-force] [-include_bit] [-include_emulation] [-minimal] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.write_hw_platform(file, @fixed, force, include_bit, include_emulation, minimal, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Write the unified JSON metadata file for the current design
		///
		///
		/// TCL Syntax: write_hw_platform_metadata [-quiet] [-verbose] [<file>]
		///
		/// Writes a JSON metadata file for the platform represented by the current design.
		/// This command returns the name of the JSON file written, or returns an error if it fails.
		///
		/// The following example writes the JSON file for the current project:
		/// write_hw_platform_metadata C:/Data/zc102_platform.json
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1815
		/// </summary>
		/// <param name="file">
		/// (Required)
		/// Unified JSON metadata file Values: A filename with
		/// alphanumeric characters and .json extension.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The name of the unified JSON metadata file</returns>
		public TTCL write_hw_platform_metadata(string file, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_hw_platform_metadata [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.write_hw_platform_metadata(file, quiet, verbose));
			return _tcl;
		}
	}
}
