// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class GUIControlCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public GUIControlCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// Create a custom command in the GUI
		///
		///
		/// TCL Syntax: create_gui_custom_command -name <arg> [-menu_name <arg>] [-description <arg>] [-show_on_toolbar] [-run_proc <arg>] [-toolbar_icon <arg>] [-command <arg>] [-tcl_file <arg>] [-quiet] [-verbose]
		///
		/// This commands creates a GUI menu item for a user custom command. The menu command
		/// appears in the Tools → Custom Commands menu in the Vivado IDE.
		/// The custom GUI command can also be shown/hidden on the toolbar menu. When the GUI
		/// button is clicked the custom command is executed. A Tcl file can also be sourced when the GUI
		/// button is clicked.
		/// You can use the get_gui_custom_commands to determine the list of user-defined custom
		/// commands.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example creates a GUI custom command with name 'print_version', and adds it to
		/// the toolbar.
		/// create_gui_custom_command -name print_version -command "version" \
		/// -description "Gets tool version" -show_on_toolbar
		///
		/// See ug835-vivado-tcl-commands.pdf, page 280
		/// </summary>
		/// <param name="name">(Required) Unique name of the command to create.</param>
		/// <param name="menu_name">(Optional) Menu name for the custom command.</param>
		/// <param name="description">
		/// (Optional)
		/// Display this text for the description of the menu item and
		/// optionally the toolbar button
		/// </param>
		/// <param name="show_on_toolbar">(Optional) Add this command to the toolbar</param>
		/// <param name="run_proc">
		/// (Optional)
		/// Needed when '-command' and 'tcl_file' options are both
		/// specified. If true, gui button will run command mentioned in
		/// '-command' option otherwise source script mentioned in '-
		/// tcl_file' option
		/// </param>
		/// <param name="toolbar_icon">(Optional) The full path to the PNG or JPEG file to display on the toolbar button</param>
		/// <param name="command">(Optional) The command to execute</param>
		/// <param name="tcl_file">(Optional) The full path to the Tcl file to source</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_gui_custom_command(string name, string menu_name = null, string description = null, bool? show_on_toolbar = null, string run_proc = null, string toolbar_icon = null, string command = null, string tcl_file = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_gui_custom_command -name <arg> [-menu_name <arg>] [-description <arg>] [-show_on_toolbar] [-run_proc <arg>] [-toolbar_icon <arg>] [-command <arg>] [-tcl_file <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_gui_custom_command(name, menu_name, description, show_on_toolbar, run_proc, toolbar_icon, command, tcl_file, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Create a custom command argument for a custom command in the GUI
		///
		///
		/// TCL Syntax: create_gui_custom_command_arg -command_name <arg> -arg_name <arg> [-default <arg>] [-comment <arg>] [-optional] [-quiet] [-verbose]
		///
		/// This commands defines an argument for a specific custom GUI command.
		/// You can use the get_gui_custom_commands to determine the list of defined custom
		/// commands. You can use the get_gui_custom_command_args to determine the list of
		/// defined GUI custom command arguments of a particular GUI custom command.
		///
		/// This example creates an argument named 'quiet' for the custom GUI command
		/// print_version. The argument is defined as optional and its default value is -quiet.
		/// create_gui_custom_command_arg -command_name print_version -arg_name quiet \
		/// -default "-quiet" -comment "Ignore commands errors" -optional
		///
		/// See ug835-vivado-tcl-commands.pdf, page 282
		/// </summary>
		/// <param name="command_name">
		/// (Required)
		/// Unique name of the custom command for which an
		/// argument is being created.
		/// </param>
		/// <param name="arg_name">(Required) Unique name of the custom command argument to create.</param>
		/// <param name="@default">(Optional) Default value of the custom command argument.</param>
		/// <param name="comment">(Optional) Comment for the custom command argument.</param>
		/// <param name="optional">(Optional) Make the custom command argument optional.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_gui_custom_command_arg(string command_name, string arg_name, string @default = null, string comment = null, bool? optional = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_gui_custom_command_arg -command_name <arg> -arg_name <arg> [-default <arg>] [-comment <arg>] [-optional] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_gui_custom_command_arg(command_name, arg_name, @default, comment, optional, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// End a set of commands that can be undone/redone as a group
		///
		///
		/// TCL Syntax: endgroup [-quiet] [-verbose]
		///
		/// Ends a sequence of commands that can be undone or redone as a series. Use startgroup to
		/// start the sequence of commands.
		/// You can have multiple command groups to undo or redo, but you cannot nest command groups.
		/// You must use endgroup to end a command sequence before using startgroup to create a
		/// new command sequence.
		/// TIP: The startgroup /endgroup commands are provided to support sequences of related commands
		/// that can be undone via the undo command, or redone if needed using the redo command. However,
		/// some Tcl commands can trigger an endgroup unexpectedly, and certain commands do not support either
		/// UNDO or REDO. The limitations are not fully defined.
		///
		/// The following example defines a startgroup, executes a sequence of related commands, and
		/// then executes the endgroup. This sequence of commands can be undone as a group:
		/// startgroup
		/// create_pblock pblock_wbArbEngine
		/// create_pblock pblock_usbEng
		/// add_cells_to_pblock pblock_wbArbEngine \
		/// [get_cells [list wbArbEngine]] -clear_locs
		/// add_cells_to_pblock pblock_usbEng \
		/// [get_cells [list usbEngine1/usbEngineSRAM]] -clear_locs
		/// endgroup
		///
		/// See ug835-vivado-tcl-commands.pdf, page 507
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL endgroup(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: endgroup [-quiet] [-verbose]
			_tcl.Entry(_builder.endgroup(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get custom command arguments
		///
		///
		/// TCL Syntax: get_gui_custom_command_args -command_name <arg> [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>...]
		///
		/// Returns the list of GUI custom command argument names for a particular GUI custom command.
		/// You can use the get_gui_custom_commands to determine the list of defined custom
		/// commands.
		///
		/// The following example returns a list of command arguments for the GUI custom command abc:
		/// get_gui_custom_command_args -command_name abc
		///
		/// See ug835-vivado-tcl-commands.pdf, page 701
		/// </summary>
		/// <param name="command_name">
		/// (Required)
		/// Unique name of the custom command whose arguments
		/// need to be displayed.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the custom command argument names against patterns Default: *</param>
		/// <returns>list of custom command argument names</returns>
		public TTCL get_gui_custom_command_args(string command_name, bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_gui_custom_command_args -command_name <arg> [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_gui_custom_command_args(command_name, regexp, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get custom commands
		///
		///
		/// TCL Syntax: get_gui_custom_commands [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>...]
		///
		/// Returns the list of GUI custom commands.
		///
		/// The following example returns a list of all the GUI custom commands which has names starting
		/// with 'p':
		/// get_gui_custom_commands p*
		///
		/// See ug835-vivado-tcl-commands.pdf, page 703
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the custom command names against patterns Default: *</param>
		/// <returns>list of custom command names</returns>
		public TTCL get_gui_custom_commands(bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_gui_custom_commands [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_gui_custom_commands(regexp, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get highlighted objects
		///
		///
		/// TCL Syntax: get_highlighted_objects [-color_index <arg>] [-rgb <args>] [-color <arg>] [-quiet] [-verbose]
		///
		/// Gets the highlighted objects in the current design open in the Vivado IDE. Objects can be
		/// highlighted with the highlight_objects command.
		/// You can get all highlighted objects in the design, or specify highlighted objects by color, by color
		/// index, or by RGB value.
		/// Note: This Tcl command works only when Vivado is run in GUI mode.
		///
		/// The following example gets all the highlighted objects in the current design:
		/// get_highlighted_objects
		/// The following example gets the object in the current design that are highlighted in the specified
		/// color:
		/// get_highlighted_objects -color cyan
		///
		/// See ug835-vivado-tcl-commands.pdf, page 706
		/// </summary>
		/// <param name="color_index">(Optional) Color index</param>
		/// <param name="rgb">(Optional) RGB color index list</param>
		/// <param name="color">(Optional) Valid values are red green blue magenta yellow cyan and orange</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of highlighted objects</returns>
		public TTCL get_highlighted_objects(string color_index = null, TCLParameterList rgb = null, string color = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_highlighted_objects [-color_index <arg>] [-rgb <args>] [-color <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_highlighted_objects(color_index, rgb, color, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get marked objects
		///
		///
		/// TCL Syntax: get_marked_objects [-rgb <args>] [-color <arg>] [-quiet] [-verbose]
		///
		/// Get the marked objects in the current design open in the Vivado IDE. Objects can be marked
		/// with the mark_objects command.
		/// You can get all marked objects in the design, or specify marked objects by color, or by RGB value.
		/// Note: This Tcl command works only when Vivado is run in GUI mode.
		///
		/// The following example gets all the marked objects in the current design:
		/// get_marked_objects
		/// The following example gets the object in the current design that are marked in the specified
		/// color:
		/// get_marked_objects -color yellow
		///
		/// See ug835-vivado-tcl-commands.pdf, page 827
		/// </summary>
		/// <param name="rgb">(Optional) RGB color index list</param>
		/// <param name="color">(Optional) Valid values are red green blue magenta yellow cyan and orange</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of marked objects</returns>
		public TTCL get_marked_objects(TCLParameterList rgb = null, string color = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_marked_objects [-rgb <args>] [-color <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_marked_objects(rgb, color, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get selected objects
		///
		///
		/// TCL Syntax: get_selected_objects [-primary] [-quiet] [-verbose]
		///
		/// Gets the objects currently selected in the Vivado IDE by the select_objects command. Can
		/// get the primary selected object and any secondary selected objects as well.
		/// Note: This Tcl command works only when Vivado is run in GUI mode.
		/// Primary objects are directly selected, while secondary objects are selected based on the selection
		/// rules currently defined by the Tools → Settings command. Refer to the Vivado Design Suite User
		/// Guide: Using the IDE (UG893) for more information on setting selection rules.
		/// This command returns a Tcl list of selected objects, even a list with just one object. This can be an
		/// issue for some of the Vivado tool commands that do not accept a list of objects, such as the
		/// current_instance command. In this case you can use lindex to pass a specific object from
		/// the get_selected_objects list to the current_instance command:
		/// current_instance [lindex [get_selected_objects] 0]
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example reports the properties of all currently selected objects, both primary and
		/// secondary:
		/// report_property [get_selected_objects]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 918
		/// </summary>
		/// <param name="primary">(Optional) Do not include objects that were selected due to selection rules</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of selected objects</returns>
		public TTCL get_selected_objects(bool? primary = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_selected_objects [-primary] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_selected_objects(primary, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Highlight objects in different colors
		///
		///
		/// TCL Syntax: highlight_objects [-color_index <arg>] [-rgb <args>] [-color <arg>] [-leaf_cells] [-quiet] [-verbose] <objects>
		///
		/// Highlights the specified or selected object or objects in a color as determined by one of the
		/// available color options.
		/// TIP: Only one of the available color option should be used to specify the highlight color. However, if more
		/// than one color option is used, the order of precedence to define the color is -rgb, -color_index, and -
		/// color.
		/// Selected objects are automatically unselected in order to display the objects in the specified
		/// highlight color. Objects can be unhighlighted with the unhighlight_objects command.
		///
		/// The following example highlights the currently selected objects in the color red:
		/// highlight_objects -color red [get_selected_objects]
		/// This example highlights the specified cells in green:
		/// highlight_objects -color green -leaf_cells [get_cells cpuEngine/*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 976
		/// </summary>
		/// <param name="objects">(Required) Objects to highlight</param>
		/// <param name="color_index">(Optional) Color index</param>
		/// <param name="rgb">(Optional) RGB color index list</param>
		/// <param name="color">(Optional) Valid values are red green blue magenta yellow cyan and orange</param>
		/// <param name="leaf_cells">(Optional) Leaf cells</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL highlight_objects(string objects, string color_index = null, TCLParameterList rgb = null, string color = null, bool? leaf_cells = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: highlight_objects [-color_index <arg>] [-rgb <args>] [-color <arg>] [-leaf_cells] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.highlight_objects(objects, color_index, rgb, color, leaf_cells, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Mark objects in GUI
		///
		///
		/// TCL Syntax: mark_objects [-rgb <args>] [-color <arg>] [-quiet] [-verbose] <objects>
		///
		/// Marks specified objects in GUI mode. This command places an iconic mark to aid in the location
		/// of the specified object or objects. The mark is displayed in a color as determined by one of the
		/// color options.
		/// Objects can be unmarked with the unmark_objects command.
		/// Note: Use only one color option. If both color options are specified, -rgb takes precedence over -color.
		///
		/// The following example adds a red icon to mark the currently selected objects:
		/// mark_objects -color red [get_selected_objects]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1062
		/// </summary>
		/// <param name="objects">(Required) Objects to mark</param>
		/// <param name="rgb">(Optional) RGB color index list</param>
		/// <param name="color">(Optional) Valid values are red green blue magenta yellow cyan and orange</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL mark_objects(string objects, TCLParameterList rgb = null, string color = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: mark_objects [-rgb <args>] [-color <arg>] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.mark_objects(objects, rgb, color, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Re-do previous command
		///
		///
		/// TCL Syntax: redo [-list] [-quiet] [-verbose]
		///
		/// IMPORTANT! The UNDO and REDO commands are intended for use in the Vivado IDE, and are not
		/// recommended for use in Tcl scripts to restore designs to a former state. To restore a design to a specific
		/// condition, you must write a design checkpoint using the write_checkpoint command, to be restored
		/// using read_checkpoint.
		/// Redo a command that has been previously undone. This command can be used repeatedly to
		/// redo a series of commands.
		/// If a command group has been created using the startgroup and endgroup commands, the
		/// redo command will redo the group of commands as a sequence.
		///
		/// The following example returns a list of commands that can be redone:
		/// redo -list
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1196
		/// </summary>
		/// <param name="list">(Optional) Show a list of redoable tasks</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>with -list, the list of redoable tasks</returns>
		public TTCL redo(bool? list = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: redo [-list] [-quiet] [-verbose]
			_tcl.Entry(_builder.redo(list, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Remove one or more custom command arguments
		///
		///
		/// TCL Syntax: remove_gui_custom_command_args -command_name <arg> [-quiet] [-verbose] <names>...
		///
		/// Remove one or more GUI custom command arguments of a particular GUI custom command.
		/// You can use the get_gui_custom_commands to determine the list of defined custom
		/// commands. You can use the get_gui_custom_command_args to determine the list of
		/// defined GUI custom command arguments for a particular GUI custom command.
		///
		/// Remove GUI custom command arguments with name 'arg1' and 'arg2' of a GUI custom command
		/// with name 'cmd_1' :
		/// remove_gui_custom_command_args -command_name cmd_1 {arg1 arg2}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1252
		/// </summary>
		/// <param name="command_name">(Required) name of custom command whose arguments are being removed.</param>
		/// <param name="names">(Required) name of one or more custom command arguments to remove.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_gui_custom_command_args(string command_name, TCLParameterList names, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_gui_custom_command_args -command_name <arg> [-quiet] [-verbose] <names>...
			_tcl.Entry(_builder.remove_gui_custom_command_args(command_name, names, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Remove one or more custom commands
		///
		///
		/// TCL Syntax: remove_gui_custom_commands [-quiet] [-verbose] <names>...
		///
		/// Remove one or more GUI custom commands.
		/// You can use the get_gui_custom_commands to determine the list of defined custom
		/// commands.
		///
		/// The following example removes the GUI custom commands with names 'abc' and 'xyz':
		/// remove_gui_custom_commands {abc xyz}
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1254
		/// </summary>
		/// <param name="names">(Required) name of one or more custom commands to remove</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_gui_custom_commands(TCLParameterList names, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_gui_custom_commands [-quiet] [-verbose] <names>...
			_tcl.Entry(_builder.remove_gui_custom_commands(names, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Select objects in GUI
		///
		///
		/// TCL Syntax: select_objects [-add] [-quiet] [-verbose] <objects>
		///
		/// Selects the specified object in the appropriate open views in the GUI mode. This command is for
		/// display purposes only. You must use the get_selected_objects command to return the
		/// selected objects for use in other commands.
		/// The select_objects command may select secondary objects in addition to the primary object
		/// specified. The selection of secondary objects is controlled through the use of Selection Rules
		/// defined in the Tools → Settings command. Refer to the Vivado Design Suite User Guide: Using the
		/// IDE (UG893) for more information on Setting Selection Rules.
		/// Selected objects can be unselected with the unselect_objects command.
		///
		/// The following example selects the specified site on the device:
		/// select_objects [get_sites SLICE_X56Y214]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1588
		/// </summary>
		/// <param name="objects">(Required) Objects to select</param>
		/// <param name="add">(Optional) Add to existing selection list</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL select_objects(string objects, bool? add = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: select_objects [-add] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.select_objects(objects, add, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Show objects in Find Results view
		///
		///
		/// TCL Syntax: show_objects [-name <arg>] [-quiet] [-verbose] <objects>
		///
		/// Populates the specified objects into the Find Results window in the Vivado IDE.
		/// Note: This command is only useful when run in the Vivado IDE. When run in Tcl or Batch mode the
		/// command simply returns without error or comment.
		///
		/// The following example shows all DSP objects in the current design in the Find Results window.
		/// show_objects -name All_DSPs [all_dsps]
		/// The following example shows all of the cells in the design hierarchy that are Clock or DSP
		/// PRIMITIVE_TYPEs:
		/// show_objects -name find_1 [get_cells -hierarchical \
		/// -filter { PRIMITIVE_TYPE =~ CLK.*.* || PRIMITIVE_TYPE =~ MULT.dsp.* } ]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1706
		/// </summary>
		/// <param name="objects">(Required) Objects to show Find Results view</param>
		/// <param name="name">(Optional) Tab title</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL show_objects(string objects, string name = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: show_objects [-name <arg>] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.show_objects(objects, name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Show netlist items in schematic view
		///
		///
		/// TCL Syntax: show_schematic [-add] [-remove] [-regenerate] [-pin_pairs] [-name <arg>] [-quiet] [-verbose] <objects>
		///
		/// Create a schematic view containing the specified design objects when the tool is invoked in GUI
		/// mode.
		/// The scope of the schematic that is displayed depends on the objects specified. A schematic
		/// created with cells, shows the specified cells and any connections between the cells. A schematic
		/// created with pins, shows the pin objects, or shows them connected as appropriate if -
		/// pin_pairs is specified. A schematic created with nets shows the nets, as well as the cells and
		/// ports connected to the nets.
		/// To display a schematic with multiple levels of hierarchy, use the current_instance command
		/// to set the top-level of the hierarchy, or the level of interest, and use the -hierarchical option
		/// when specifying design objects with a get_* command.
		/// Note: This command is only useful when run in the Vivado IDE. When run in Tcl or Batch mode the
		/// command simply returns without error or comment.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example creates a schematic for the top-level of the design, displaying the nets as
		/// well as the ports and cells they connect to:
		/// show_schematic [get_nets]
		/// The following example sets the level of hierarchy of interest, and creates a hierarchical schematic
		/// from the current level down:
		/// current_instance A
		/// show_schematic [get_nets -hier]
		/// The following example creates a schematic window showing the specified pins, and the wire
		/// connection between them:
		/// show_schematic -pin_pairs [get_pins {data0_i/O data_reg/D}]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1708
		/// </summary>
		/// <param name="objects">(Required) Netlist items to show in schematic view</param>
		/// <param name="add">(Optional) Add to existing schematic view</param>
		/// <param name="remove">(Optional) Remove from existing schematic view</param>
		/// <param name="regenerate">(Optional) Regenerate layout of schematic view</param>
		/// <param name="pin_pairs">
		/// (Optional)
		/// objects are treated as pair of connected pins. This can be
		/// useful to display paths
		/// </param>
		/// <param name="name">(Optional) Schematic window title</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL show_schematic(string objects, bool? add = null, bool? remove = null, bool? regenerate = null, bool? pin_pairs = null, string name = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: show_schematic [-add] [-remove] [-regenerate] [-pin_pairs] [-name <arg>] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.show_schematic(objects, add, remove, regenerate, pin_pairs, name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Start GUI
		///
		///
		/// TCL Syntax: start_gui [-verbose]
		///
		/// Launches the GUI when the tool is running in the Vivado Design Suite Tcl shell. The GUI is
		/// invoked with the current project, design, and run information.
		///
		/// The following example is executed from the command prompt when the tool is running in Tcl
		/// mode:
		/// Vivado% start_gui
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1713
		/// </summary>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL start_gui(bool? verbose = null)
		{
			// TCL Syntax: start_gui [-verbose]
			_tcl.Entry(_builder.start_gui(verbose));
			return _tcl;
		}
		/// <summary>
		/// Start a set of commands that can be undone/redone as a group
		///
		///
		/// TCL Syntax: startgroup [-try] [-quiet] [-verbose]
		///
		/// Starts a sequence of commands that can be undone or redone as a series. Use endgroup to end
		/// the sequence of commands.
		/// You can have multiple command groups to undo or redo, but you cannot nest command groups.
		/// You must use endgroup to end a command sequence before using startgroup to create a
		/// new command sequence.
		/// TIP: The startgroup /endgroup commands are provided to support sequences of related commands
		/// that can be undone via the undo command, or redone if needed using the redo command. However,
		/// some commands can trigger an endgroup unexpectedly, and certain commands do not support either
		/// undo or redo. The limitations are not fully defined.
		/// The startgroup command returns an integer value of 0 if a group is already started, and
		/// returns an integer value of 1 if the startgroup command has started a new group.
		///
		/// The following example defines a startgroup, executes a sequence of related commands, and
		/// then executes the endgroup. This sequence of commands can be undone or redone as a group:
		/// startgroup
		/// create_pblock pblock_wbArbEngine
		/// create_pblock pblock_usbEngnSRM
		/// add_cells_to_pblock pblock_wbArbEngine \
		/// [get_cells [list wbArbEngine]] -clear_locs
		/// add_cells_to_pblock pblock_usbEngnSRM \
		/// [get_cells [list usbEngine1/usbEngineSRAM]] -clear_locs
		/// endgroup
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1716
		/// </summary>
		/// <param name="@try">(Optional) Don't start a group if one has already been started</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>int</returns>
		public TTCL startgroup(bool? @try = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: startgroup [-try] [-quiet] [-verbose]
			_tcl.Entry(_builder.startgroup(@try, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Close GUI
		///
		///
		/// TCL Syntax: stop_gui [-verbose]
		///
		/// Stops GUI mode and places the tool into Tcl mode, running in the Vivado Design Suite Tcl shell. In
		/// Tcl mode, all commands must be entered as Tcl commands or through Tcl scripts.
		///
		/// The following example stops and closes the GUI and places the tool into Tcl mode:
		/// stop_gui
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1722
		/// </summary>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL stop_gui(bool? verbose = null)
		{
			// TCL Syntax: stop_gui [-verbose]
			_tcl.Entry(_builder.stop_gui(verbose));
			return _tcl;
		}
		/// <summary>
		/// Un-do previous command
		///
		///
		/// TCL Syntax: undo [-list] [-quiet] [-verbose]
		///
		/// IMPORTANT! The undo and redo commands are intended for use in the Vivado IDE, and are not
		/// recommended for use in Tcl scripts to restore designs to a former state. To restore a design to a specific
		/// condition, you must write a design checkpoint using the write_checkpoint command, to be restored
		/// using read_checkpoint.
		/// Undo a prior command. This command can be used repeatedly to undo a series of commands.
		/// If a group of commands has been created using the startgroup and endgroup commands,
		/// this command will undo that group as a sequence. The undo command will start at the
		/// endgroup command and continue to undo until it hits the startgroup command.
		/// If you undo a command, and then change your mind, you can redo the command.
		///
		/// The following example returns a list of commands that you can undo:
		/// undo -list
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1746
		/// </summary>
		/// <param name="list">(Optional) Show a list of undoable tasks</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>with -list, the list of undoable tasks</returns>
		public TTCL undo(bool? list = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: undo [-list] [-quiet] [-verbose]
			_tcl.Entry(_builder.undo(list, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Unhighlight objects that are currently highlighted
		///
		///
		/// TCL Syntax: unhighlight_objects [-color_index <arg>] [-rgb <args>] [-color <arg>] [-leaf_cells] [-quiet] [-verbose] [<objects>]
		///
		/// This command is for use in GUI mode. This command unhighlights the specified object or objects
		/// that were previously highlighted by the highlight_objects command.
		/// This command supports the color options as specified below. These options can be used to
		/// unhighlight all objects currently highlighted in the specified color. See the example below.
		///
		/// The following example unhighlights the specified cell objects:
		/// unhighlight_objects -leaf_cells [get_cells cpuEngine/*]
		/// The following example unhighlights all objects currently highlighted in the color yellow:
		/// unhighlight_objects -color yellow
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1750
		/// </summary>
		/// <param name="color_index">(Optional) Color index</param>
		/// <param name="rgb">(Optional) RGB color index list</param>
		/// <param name="color">(Optional) Valid values are red green blue magenta yellow cyan and orange</param>
		/// <param name="leaf_cells">(Optional) Leaf cells</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">(Optional) Objects to unhighlight</param>
		public TTCL unhighlight_objects(string color_index = null, TCLParameterList rgb = null, string color = null, bool? leaf_cells = null, bool? quiet = null, bool? verbose = null, string objects = null)
		{
			// TCL Syntax: unhighlight_objects [-color_index <arg>] [-rgb <args>] [-color <arg>] [-leaf_cells] [-quiet] [-verbose] [<objects>]
			_tcl.Entry(_builder.unhighlight_objects(color_index, rgb, color, leaf_cells, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// Unmark items that are currently marked
		///
		///
		/// TCL Syntax: unmark_objects [-rgb <args>] [-color <arg>] [-quiet] [-verbose] [<objects>]
		///
		/// Unmarks the specified object or objects that were previously marked by the mark_objects
		/// command. This command is for use in GUI mode.
		/// This command supports the color options as specified below. However, these options are not
		/// necessary to unmark a specific object, but can be used to unmark all objects currently marked in
		/// the specified color. See the example below.
		///
		/// The following example unmarks the selected objects:
		/// unmark_objects [get_selected_objects]
		/// The following example unmarks all objects currently marked in the color yellow:
		/// unmark_objects -color yellow
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1752
		/// </summary>
		/// <param name="rgb">(Optional) RGB color index list</param>
		/// <param name="color">(Optional) Valid values are red green blue magenta yellow cyan and orange</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">(Optional) Objects to unmark</param>
		public TTCL unmark_objects(TCLParameterList rgb = null, string color = null, bool? quiet = null, bool? verbose = null, string objects = null)
		{
			// TCL Syntax: unmark_objects [-rgb <args>] [-color <arg>] [-quiet] [-verbose] [<objects>]
			_tcl.Entry(_builder.unmark_objects(rgb, color, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// Unselect items that are currently selected
		///
		///
		/// TCL Syntax: unselect_objects [-quiet] [-verbose] [<objects>]
		///
		/// Unselects the specified object or objects that were previously selected by the
		/// select_objects command.
		/// This command will unselect both primary and secondary selected objects. The selection of
		/// secondary objects is controlled through the use of Selection Rules defined in the Tools → Settings
		/// command. Refer to the Vivado Design Suite User Guide: Using the IDE (UG893) for more
		/// information on Setting Selection Rules.
		///
		/// The following example unselects the specified site on the device:
		/// unselect_objects [get_sites SLICE_X56Y214]
		/// The following example unselects all currently selected objects:
		/// unselect_objects
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1758
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">(Optional) Objects to unselect</param>
		public TTCL unselect_objects(bool? quiet = null, bool? verbose = null, string objects = null)
		{
			// TCL Syntax: unselect_objects [-quiet] [-verbose] [<objects>]
			_tcl.Entry(_builder.unselect_objects(quiet, verbose, objects));
			return _tcl;
		}
	}
}
