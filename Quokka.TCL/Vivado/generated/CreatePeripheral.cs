#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class CreatePeripheralCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public CreatePeripheralCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// <para>
		/// Add a new bus interface to a peripheral.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: add_peripheral_interface -interface_mode &lt;arg&gt; -axi_type &lt;arg&gt; [-quiet] [-verbose] &lt;name&gt; &lt;peripheral&gt;
		/// <br/>
		/// <para>
		/// Add an AXI bus interface to a peripheral created with the create_peripheral command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 57<br/>
		/// </para>
		/// </summary>
		/// <param name="interface_mode">(Required) Mode of an interface, supported option - master,slave.</param>
		/// <param name="axi_type">(Required) Type of a axi interface, supported option - lite,full,stream.</param>
		/// <param name="name">(Required) Name to initialize the newly added element e.g S1_AXI, M1_AXI</param>
		/// <param name="peripheral">(Required) Peripheral object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL add_peripheral_interface(String interface_mode, String axi_type, String name, String peripheral, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: add_peripheral_interface -interface_mode <arg> -axi_type <arg> [-quiet] [-verbose] <name> <peripheral>
			_tcl.Entry(_builder.add_peripheral_interface(interface_mode, axi_type, name, peripheral, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a peripheral with a VLNV.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_peripheral [-dir &lt;arg&gt;] [-quiet] [-verbose] &lt;vendor&gt; &lt;library&gt; &lt;name&gt; &lt;version&gt;
		/// <br/>
		/// <para>
		/// Create an AXI peripheral to add to the IP repository with the specified VLNV attribute.<br/>
		/// The AXI peripheral that is created is just a framework until interfaces have been added to the<br/>
		/// peripheral using the add_peripheral_interface command, and the peripheral has been<br/>
		/// generated using the generate_peripheral command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 329<br/>
		/// </para>
		/// </summary>
		/// <param name="vendor">(Required) Vendor, for example xilinx.com</param>
		/// <param name="library">(Required) Library, for example ip</param>
		/// <param name="name">(Required) Name, for example myip</param>
		/// <param name="version">(Required) Version, for example 1.4</param>
		/// <param name="dir">
		/// <para>
		/// (Optional)<br/>
		/// Directory path for remote Peripheral to be created and<br/>
		/// managed outside the project<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_peripheral(String vendor, String library, String name, String version, String dir = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_peripheral [-dir <arg>] [-quiet] [-verbose] <vendor> <library> <name> <version>
			_tcl.Entry(_builder.create_peripheral(vendor, library, name, version, dir, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Generate output products for peripheral object.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: generate_peripheral [-driver] [-example_design] [-bfm_example_design] [-debug_hw_example_design] [-enable_interrupt] [-force] [-quiet] [-verbose] &lt;peripheral&gt;
		/// <br/>
		/// <para>
		/// Generate the output products for the specified peripheral object. The output products are<br/>
		/// written to the IP repository location specified when the IP is created by the<br/>
		/// create_peripheral command, under the name of the IP as specified at creation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 545<br/>
		/// </para>
		/// </summary>
		/// <param name="peripheral">(Required) peripheral object</param>
		/// <param name="driver">(Optional) Generate driver for peripheral.</param>
		/// <param name="example_design">(Optional) Generate all supported example designs for peripheral.</param>
		/// <param name="bfm_example_design">(Optional) Generate bfm simulation example design for peripheral.</param>
		/// <param name="debug_hw_example_design">(Optional) Generate debug hardware example design for peripheral.</param>
		/// <param name="enable_interrupt">(Optional) Generate peripheral with interrupt suppport.</param>
		/// <param name="force">(Optional) Overwrite the existing IP in the repository.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL generate_peripheral(String peripheral, bool? driver = null, bool? example_design = null, bool? bfm_example_design = null, bool? debug_hw_example_design = null, bool? enable_interrupt = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_peripheral [-driver] [-example_design] [-bfm_example_design] [-debug_hw_example_design] [-enable_interrupt] [-force] [-quiet] [-verbose] <peripheral>
			_tcl.Entry(_builder.generate_peripheral(peripheral, driver, example_design, bfm_example_design, debug_hw_example_design, enable_interrupt, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Save peripheral component to the disk.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_peripheral [-quiet] [-verbose] &lt;peripheral&gt;
		/// <br/>
		/// <para>
		/// Write the specified AXI peripheral object to disk in the form of the component.xml file. The<br/>
		/// peripheral is written to the repository location specified by the create_peripheral<br/>
		/// command, under the name specified at creation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1876<br/>
		/// </para>
		/// </summary>
		/// <param name="peripheral">(Required) Peripheral object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_peripheral(String peripheral, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_peripheral [-quiet] [-verbose] <peripheral>
			_tcl.Entry(_builder.write_peripheral(peripheral, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
