// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class GUIControlCommands
	{
		private readonly QuokkaTCL _tcl;
		public GUIControlCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Create a custom command in the GUI
		/// </summary>
		public void create_gui_custom_command()
		{
			var command = new SimpleTCLCommand("create_gui_custom_command");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a custom command argument for a custom command in the GUI
		/// </summary>
		public void create_gui_custom_command_arg()
		{
			var command = new SimpleTCLCommand("create_gui_custom_command_arg");
			_tcl.Add(command);
		}
		/// <summary>
		/// End a set of commands that can be undone/redone as a group
		/// </summary>
		public void endgroup()
		{
			var command = new SimpleTCLCommand("endgroup");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get custom command arguments
		/// </summary>
		public void get_gui_custom_command_args()
		{
			var command = new SimpleTCLCommand("get_gui_custom_command_args");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get custom commands
		/// </summary>
		public void get_gui_custom_commands()
		{
			var command = new SimpleTCLCommand("get_gui_custom_commands");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get highlighted objects
		/// </summary>
		public void get_highlighted_objects()
		{
			var command = new SimpleTCLCommand("get_highlighted_objects");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get marked objects
		/// </summary>
		public void get_marked_objects()
		{
			var command = new SimpleTCLCommand("get_marked_objects");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get selected objects
		/// </summary>
		public void get_selected_objects()
		{
			var command = new SimpleTCLCommand("get_selected_objects");
			_tcl.Add(command);
		}
		/// <summary>
		/// Highlight objects in different colors
		/// </summary>
		public void highlight_objects()
		{
			var command = new SimpleTCLCommand("highlight_objects");
			_tcl.Add(command);
		}
		/// <summary>
		/// Mark objects in GUI
		/// </summary>
		public void mark_objects()
		{
			var command = new SimpleTCLCommand("mark_objects");
			_tcl.Add(command);
		}
		/// <summary>
		/// Re-do previous command
		/// </summary>
		public void redo()
		{
			var command = new SimpleTCLCommand("redo");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove one or more custom command arguments
		/// </summary>
		public void remove_gui_custom_command_args()
		{
			var command = new SimpleTCLCommand("remove_gui_custom_command_args");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove one or more custom commands
		/// </summary>
		public void remove_gui_custom_commands()
		{
			var command = new SimpleTCLCommand("remove_gui_custom_commands");
			_tcl.Add(command);
		}
		/// <summary>
		/// Select objects in GUI
		/// </summary>
		public void select_objects()
		{
			var command = new SimpleTCLCommand("select_objects");
			_tcl.Add(command);
		}
		/// <summary>
		/// Show objects in Find Results view
		/// </summary>
		public void show_objects()
		{
			var command = new SimpleTCLCommand("show_objects");
			_tcl.Add(command);
		}
		/// <summary>
		/// Show netlist items in schematic view
		/// </summary>
		public void show_schematic()
		{
			var command = new SimpleTCLCommand("show_schematic");
			_tcl.Add(command);
		}
		/// <summary>
		/// Start GUI
		/// </summary>
		public void start_gui()
		{
			var command = new SimpleTCLCommand("start_gui");
			_tcl.Add(command);
		}
		/// <summary>
		/// Start a set of commands that can be undone/redone as a group
		/// </summary>
		public void startgroup()
		{
			var command = new SimpleTCLCommand("startgroup");
			_tcl.Add(command);
		}
		/// <summary>
		/// Close GUI
		/// </summary>
		public void stop_gui()
		{
			var command = new SimpleTCLCommand("stop_gui");
			_tcl.Add(command);
		}
		/// <summary>
		/// Un-do previous command
		/// </summary>
		public void undo()
		{
			var command = new SimpleTCLCommand("undo");
			_tcl.Add(command);
		}
		/// <summary>
		/// Unhighlight objects that are currently highlighted
		/// </summary>
		public void unhighlight_objects()
		{
			var command = new SimpleTCLCommand("unhighlight_objects");
			_tcl.Add(command);
		}
		/// <summary>
		/// Unmark items that are currently marked
		/// </summary>
		public void unmark_objects()
		{
			var command = new SimpleTCLCommand("unmark_objects");
			_tcl.Add(command);
		}
		/// <summary>
		/// Unselect items that are currently selected
		/// </summary>
		public void unselect_objects()
		{
			var command = new SimpleTCLCommand("unselect_objects");
			_tcl.Add(command);
		}
	}
}
