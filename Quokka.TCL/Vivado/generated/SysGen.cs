// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class SysGenCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public SysGenCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// Create DSP source for Xilinx System Generator and add to the source fileset
		///
		///
		/// TCL Syntax: create_sysgen [-quiet] [-verbose] <name>
		///
		/// Create a DSP sub-module for use in the current project, and add it to the source files.
		/// This command will launch System Generator for DSP to let you design the hardware portion of
		/// your system design. System Generator is a DSP design tool from Xilinx that allows the RTL
		/// source files, Simulink® and MATLAB® software models, and C/C++ components of a DSP system
		/// to come together in a single simulation and implementation environment.
		/// For more information on using specific features of the tool refer to System Generator for DSP
		/// Getting Started Guide (UG639).
		/// You can also add existing DSP model files (.mdl) from System Generator into the current project
		/// using the add_files command.
		/// The command returns the name of the DSP module created and added to the project.
		///
		/// The following example launches System Generator and allows you to define and configure the
		/// specified DSP module:
		/// create_sysgen DSP_mod1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 365
		/// </summary>
		/// <param name="name">(Required) Sub module name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Name for the new sub module</returns>
		public TTCL create_sysgen(string name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_sysgen [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_sysgen(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Generate HDL wrapper for the specified source
		///
		///
		/// TCL Syntax: make_wrapper [-top] [-testbench] [-inst_template] [-fileset <arg>] [-import] [-force] [-quiet] [-verbose] <files>
		///
		/// Create a Verilog or VHDL wrapper for instantiating a sub-design into the project.
		/// The make_wrapper command will create a wrapper for Embedded Processor Designs from the
		/// IP integrator of the Vivado Design Suite, or any IP integrator block design, as well as DSP
		/// modules created in System Generator or MathWorks MatLab.
		/// You can generate a wrapper to make the sub-design the top-level of a stand-alone design, or for
		/// instantiating a sub-design into an existing design. You can also generate a wrapper for a
		/// simulation test bench of System Generator sub-designs.
		/// Note: The wrapper is generated in Verilog or VHDL according to the TARGET_LANGUAGE property on the
		/// project.
		/// The command returns information related to the creation of the wrappers, or returns an error if it
		/// fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example creates the instantiation template to integrate the specified IP integrator
		/// block design into the design hierarchy of the current project:
		/// make_wrapper -inst_template -fileset [get_filesets sources_1] \
		/// -files [get_files C:/Data/design_1/design_1.bd]
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1059
		/// </summary>
		/// <param name="files">(Required) Source file for which the wrapper needs to be generated</param>
		/// <param name="top">(Optional) Create a top-level wrapper for the specified source</param>
		/// <param name="testbench">(Optional) Create a testbench for the specified source</param>
		/// <param name="inst_template">
		/// (Optional)
		/// Create an instantiation template for the specified source.
		/// The template will not be added to the project and will be
		/// generated for reference purposes only.
		/// </param>
		/// <param name="fileset">(Optional) Fileset name</param>
		/// <param name="import">(Optional) Import generated wrapper to the project</param>
		/// <param name="force">(Optional) Overwrite existing source(s)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL make_wrapper(string files, bool? top = null, bool? testbench = null, bool? inst_template = null, string fileset = null, bool? import = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: make_wrapper [-top] [-testbench] [-inst_template] [-fileset <arg>] [-import] [-force] [-quiet] [-verbose] <files>
			_tcl.Entry(_builder.make_wrapper(files, top, testbench, inst_template, fileset, import, force, quiet, verbose));
			return _tcl;
		}
	}
}
