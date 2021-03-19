// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class CreatePeripheralCommands
	{
		private readonly QuokkaTCL _tcl;
		public CreatePeripheralCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Add a new bus interface to a peripheral.
		/// </summary>
		public void add_peripheral_interface()
		{
			var command = new SimpleTCLCommand("add_peripheral_interface");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a peripheral with a VLNV.
		/// </summary>
		public void create_peripheral()
		{
			var command = new SimpleTCLCommand("create_peripheral");
			_tcl.Add(command);
		}
		/// <summary>
		/// Generate output products for peripheral object.
		/// </summary>
		public void generate_peripheral()
		{
			var command = new SimpleTCLCommand("generate_peripheral");
			_tcl.Add(command);
		}
		/// <summary>
		/// Save peripheral component to the disk.
		/// </summary>
		public void write_peripheral()
		{
			var command = new SimpleTCLCommand("write_peripheral");
			_tcl.Add(command);
		}
	}
}
