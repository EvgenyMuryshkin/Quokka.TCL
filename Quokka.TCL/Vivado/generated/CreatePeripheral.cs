// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class CreatePeripheralCommands
	{
		private readonly TCLFile<VivadoTCL> _tcl;
		public CreatePeripheralCommands(TCLFile<VivadoTCL> tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Add a new bus interface to a peripheral.
		///
		///
		/// TCL Syntax: add_peripheral_interface -interface_mode <arg> -axi_type <arg> [-quiet] [-verbose] <name> <peripheral>
		///
		/// Add an AXI bus interface to a peripheral created with the create_peripheral command.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 55
		/// </summary>
		/// <param name="interface_mode">
		/// Required
		/// Mode of an interface, supported option - master,slave.
		/// </param>
		/// <param name="axi_type">
		/// Required
		/// Type of a axi interface, supported option - lite,full,stream.
		/// </param>
		/// <param name="name">
		/// Required
		/// Name to initialize the newly added element e.g S1_AXI,
		/// M1_AXI
		/// </param>
		/// <param name="peripheral">
		/// Required
		/// Peripheral object
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void add_peripheral_interface(string interface_mode, string axi_type, string name, string peripheral, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: add_peripheral_interface -interface_mode <arg> -axi_type <arg> [-quiet] [-verbose] <name> <peripheral>
			_tcl.Add(
				new SimpleTCLCommand("add_peripheral_interface")
					.RequiredNamedString("interface_mode", interface_mode)
					.RequiredNamedString("axi_type", axi_type)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.RequiredString(name)
					.RequiredString(peripheral)
			);
		}
		/// <summary>
		/// Create a peripheral with a VLNV.
		///
		///
		/// TCL Syntax: create_peripheral [-dir <arg>] [-quiet] [-verbose] <vendor> <library> <name> <version>
		///
		/// Create an AXI peripheral to add to the IP repository with the specified VLNV attribute.
		/// The AXI peripheral that is created is just a framework until interfaces have been added to the
		/// peripheral using the add_peripheral_interface command, and the peripheral has been
		/// generated using the generate_peripheral command.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 320
		/// </summary>
		/// <param name="vendor">
		/// Required
		/// Vendor, for example xilinx.com
		/// </param>
		/// <param name="library">
		/// Required
		/// Library, for example ip
		/// </param>
		/// <param name="name">
		/// Required
		/// Name, for example myip
		/// </param>
		/// <param name="version">
		/// Required
		/// Version, for example 1.4
		/// </param>
		/// <param name="dir">
		/// Optional
		/// Directory path for remote Peripheral to be created and
		/// managed outside the project
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void create_peripheral(string vendor, string library, string name, string version, string dir = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_peripheral [-dir <arg>] [-quiet] [-verbose] <vendor> <library> <name> <version>
			_tcl.Add(
				new SimpleTCLCommand("create_peripheral")
					.OptionalNamedString("dir", dir)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.RequiredString(vendor)
					.RequiredString(library)
					.RequiredString(name)
					.RequiredString(version)
			);
		}
		/// <summary>
		/// Generate output products for peripheral object.
		///
		///
		/// TCL Syntax: generate_peripheral [-driver] [-example_design] [-bfm_example_design] [-debug_hw_example_design] [-enable_interrupt] [-force] [-quiet] [-verbose] <peripheral>
		///
		/// Generate the output products for the specified peripheral object. The output products are
		/// written to the IP repository location specified when the IP is created by the
		/// create_peripheral command, under the name of the IP as specified at creation.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 532
		/// </summary>
		/// <param name="peripheral">
		/// Required
		/// peripheral object
		/// </param>
		/// <param name="driver">
		/// Optional
		/// Generate driver for peripheral.
		/// </param>
		/// <param name="example_design">
		/// Optional
		/// Generate all supported example designs for peripheral.
		/// </param>
		/// <param name="bfm_example_design">
		/// Optional
		/// Generate bfm simulation example design for peripheral.
		/// </param>
		/// <param name="debug_hw_example_design">
		/// Optional
		/// Generate debug hardware example design for peripheral.
		/// </param>
		/// <param name="enable_interrupt">
		/// Optional
		/// Generate peripheral with interrupt suppport.
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite the existing IP in the repository.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void generate_peripheral(string peripheral, bool? driver = null, bool? example_design = null, bool? bfm_example_design = null, bool? debug_hw_example_design = null, bool? enable_interrupt = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_peripheral [-driver] [-example_design] [-bfm_example_design] [-debug_hw_example_design] [-enable_interrupt] [-force] [-quiet] [-verbose] <peripheral>
			_tcl.Add(
				new SimpleTCLCommand("generate_peripheral")
					.Flag("driver", driver)
					.Flag("example_design", example_design)
					.Flag("bfm_example_design", bfm_example_design)
					.Flag("debug_hw_example_design", debug_hw_example_design)
					.Flag("enable_interrupt", enable_interrupt)
					.Flag("force", force)
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.RequiredString(peripheral)
			);
		}
		/// <summary>
		/// Save peripheral component to the disk.
		///
		///
		/// TCL Syntax: write_peripheral [-quiet] [-verbose] <peripheral>
		///
		/// Write the specified AXI peripheral object to disk in the form of the component.xml file. The
		/// peripheral is written to the repository location specified by the create_peripheral
		/// command, under the name specified at creation.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1838
		/// </summary>
		/// <param name="peripheral">
		/// Required
		/// Peripheral object
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void write_peripheral(string peripheral, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_peripheral [-quiet] [-verbose] <peripheral>
			_tcl.Add(
				new SimpleTCLCommand("write_peripheral")
					.Flag("quiet", quiet)
					.Flag("verbose", verbose)
					.RequiredString(peripheral)
			);
		}
	}
}
