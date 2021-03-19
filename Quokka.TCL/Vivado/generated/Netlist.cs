// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class NetlistCommands
	{
		private readonly QuokkaTCL _tcl;
		public NetlistCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Connect a net to pins or ports
		/// </summary>
		public void connect_net()
		{
			var command = new SimpleTCLCommand("connect_net");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create cells in the current design
		/// </summary>
		public void create_cell()
		{
			var command = new SimpleTCLCommand("create_cell");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create nets in the current design
		/// </summary>
		public void create_net()
		{
			var command = new SimpleTCLCommand("create_net");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create pins in the current design
		/// </summary>
		public void create_pin()
		{
			var command = new SimpleTCLCommand("create_pin");
			_tcl.Add(command);
		}
		/// <summary>
		/// Disconnect a net from pins or ports
		/// </summary>
		public void disconnect_net()
		{
			var command = new SimpleTCLCommand("disconnect_net");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the routed or estimated delays in picoseconds on a net from the driver to each load pin.
		/// </summary>
		public void get_net_delays()
		{
			var command = new SimpleTCLCommand("get_net_delays");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove cells from the current design
		/// </summary>
		public void remove_cell()
		{
			var command = new SimpleTCLCommand("remove_cell");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove nets from the current design
		/// </summary>
		public void remove_net()
		{
			var command = new SimpleTCLCommand("remove_net");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove pins from the current design
		/// </summary>
		public void remove_pin()
		{
			var command = new SimpleTCLCommand("remove_pin");
			_tcl.Add(command);
		}
		/// <summary>
		/// rename a cell
		/// </summary>
		public void rename_cell()
		{
			var command = new SimpleTCLCommand("rename_cell");
			_tcl.Add(command);
		}
		/// <summary>
		/// rename a net
		/// </summary>
		public void rename_net()
		{
			var command = new SimpleTCLCommand("rename_net");
			_tcl.Add(command);
		}
		/// <summary>
		/// rename a pin
		/// </summary>
		public void rename_pin()
		{
			var command = new SimpleTCLCommand("rename_pin");
			_tcl.Add(command);
		}
		/// <summary>
		/// rename a port
		/// </summary>
		public void rename_port()
		{
			var command = new SimpleTCLCommand("rename_port");
			_tcl.Add(command);
		}
		/// <summary>
		/// rename a cell ref
		/// </summary>
		public void rename_ref()
		{
			var command = new SimpleTCLCommand("rename_ref");
			_tcl.Add(command);
		}
		/// <summary>
		/// Resize net bus in the current design
		/// </summary>
		public void resize_net_bus()
		{
			var command = new SimpleTCLCommand("resize_net_bus");
			_tcl.Add(command);
		}
		/// <summary>
		/// Resize pin bus in the current design
		/// </summary>
		public void resize_pin_bus()
		{
			var command = new SimpleTCLCommand("resize_pin_bus");
			_tcl.Add(command);
		}
		/// <summary>
		/// Tie off unused cell pins
		/// </summary>
		public void tie_unused_pins()
		{
			var command = new SimpleTCLCommand("tie_unused_pins");
			_tcl.Add(command);
		}
	}
}
