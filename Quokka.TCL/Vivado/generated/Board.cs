// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class BoardCommands
	{
		private readonly QuokkaTCL _tcl;
		public BoardCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Applies board connections to given designs
		/// </summary>
		public void apply_board_connection()
		{
			var command = new SimpleTCLCommand("apply_board_connection");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the current board object
		/// </summary>
		public void current_board()
		{
			var command = new SimpleTCLCommand("current_board");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the current board_part object
		/// </summary>
		public void current_board_part()
		{
			var command = new SimpleTCLCommand("current_board_part");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of board bus net objects
		/// </summary>
		public void get_board_bus_nets()
		{
			var command = new SimpleTCLCommand("get_board_bus_nets");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of board bus objects
		/// </summary>
		public void get_board_buses()
		{
			var command = new SimpleTCLCommand("get_board_buses");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of interfaces in the board components that implement busdef specified by VLNV
		/// </summary>
		public void get_board_component_interfaces()
		{
			var command = new SimpleTCLCommand("get_board_component_interfaces");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of component mode objects
		/// </summary>
		public void get_board_component_modes()
		{
			var command = new SimpleTCLCommand("get_board_component_modes");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of board_part pins object
		/// </summary>
		public void get_board_component_pins()
		{
			var command = new SimpleTCLCommand("get_board_component_pins");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the list of components available in the board
		/// </summary>
		public void get_board_components()
		{
			var command = new SimpleTCLCommand("get_board_components");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of interface ports object
		/// </summary>
		public void get_board_interface_ports()
		{
			var command = new SimpleTCLCommand("get_board_interface_ports");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of ip preference objects
		/// </summary>
		public void get_board_ip_preferences()
		{
			var command = new SimpleTCLCommand("get_board_ip_preferences");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of board jumper objects
		/// </summary>
		public void get_board_jumpers()
		{
			var command = new SimpleTCLCommand("get_board_jumpers");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of board parameter objects
		/// </summary>
		public void get_board_parameters()
		{
			var command = new SimpleTCLCommand("get_board_parameters");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of interfaces in the board_part that implement busdef specified by VLNV
		/// </summary>
		public void get_board_part_interfaces()
		{
			var command = new SimpleTCLCommand("get_board_part_interfaces");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the list of board_part pins object
		/// </summary>
		public void get_board_part_pins()
		{
			var command = new SimpleTCLCommand("get_board_part_pins");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the list of board_part available in the project
		/// </summary>
		public void get_board_parts()
		{
			var command = new SimpleTCLCommand("get_board_parts");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the list of boards available in the project
		/// </summary>
		public void get_boards()
		{
			var command = new SimpleTCLCommand("get_boards");
			_tcl.Add(command);
		}
	}
}
