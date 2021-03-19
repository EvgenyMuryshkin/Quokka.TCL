// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class PinPlanningCommands
	{
		private readonly QuokkaTCL _tcl;
		public PinPlanningCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Create a new I/O port interface
		/// </summary>
		public void create_interface()
		{
			var command = new SimpleTCLCommand("create_interface");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create scalar or bus port
		/// </summary>
		public void create_port()
		{
			var command = new SimpleTCLCommand("create_port");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete I/O port interfaces from the project
		/// </summary>
		public void delete_interface()
		{
			var command = new SimpleTCLCommand("delete_interface");
			_tcl.Add(command);
		}
		/// <summary>
		/// Make differential pair for 2 ports
		/// </summary>
		public void make_diff_pair_ports()
		{
			var command = new SimpleTCLCommand("make_diff_pair_ports");
			_tcl.Add(command);
		}
		/// <summary>
		/// Automatically place a set of ports
		/// </summary>
		public void place_ports()
		{
			var command = new SimpleTCLCommand("place_ports");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove the given list of top ports from the netlist.
		/// </summary>
		public void remove_port()
		{
			var command = new SimpleTCLCommand("remove_port");
			_tcl.Add(command);
		}
		/// <summary>
		/// Resize port bus in the current design
		/// </summary>
		public void resize_port_bus()
		{
			var command = new SimpleTCLCommand("resize_port_bus");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set user columns on one or more package pins
		/// </summary>
		public void set_package_pin_val()
		{
			var command = new SimpleTCLCommand("set_package_pin_val");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove differential pair relationship between 2 ports
		/// </summary>
		public void split_diff_pair_ports()
		{
			var command = new SimpleTCLCommand("split_diff_pair_ports");
			_tcl.Add(command);
		}
	}
}
