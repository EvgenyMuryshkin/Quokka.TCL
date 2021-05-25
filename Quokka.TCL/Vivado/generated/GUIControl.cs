#pragma warning disable IDE1006 // Naming Styles
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
		/// <para>
		/// Create a custom command in the GUI<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_gui_custom_command -name &lt;arg&gt; [-menu_name &lt;arg&gt;] [-description &lt;arg&gt;] [-show_on_toolbar] [-run_proc &lt;arg&gt;] [-toolbar_icon &lt;arg&gt;] [-command &lt;arg&gt;] [-tcl_file &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This commands creates a GUI menu item for a user custom command. The menu command<br/>
		/// appears in the Tools → Custom Commands menu in the Vivado IDE.<br/>
		/// The custom GUI command can also be shown/hidden on the toolbar menu. When the GUI<br/>
		/// button is clicked the custom command is executed. A Tcl file can also be sourced when the GUI<br/>
		/// button is clicked.<br/>
		/// You can use the get_gui_custom_commands to determine the list of user-defined custom<br/>
		/// commands.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a GUI custom command with name 'print_version', and adds it to<br/>
		/// the toolbar.<br/>
		/// create_gui_custom_command -name print_version -command "version" \<br/>
		/// -description "Gets tool version" -show_on_toolbar<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 280<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Unique name of the command to create.</param>
		/// <param name="menu_name">(Optional) Menu name for the custom command.</param>
		/// <param name="description">
		/// <para>
		/// (Optional)<br/>
		/// Display this text for the description of the menu item and<br/>
		/// optionally the toolbar button<br/>
		/// </para>
		/// </param>
		/// <param name="show_on_toolbar">(Optional) Add this command to the toolbar</param>
		/// <param name="run_proc">
		/// <para>
		/// (Optional)<br/>
		/// Needed when '-command' and 'tcl_file' options are both<br/>
		/// specified. If true, gui button will run command mentioned in<br/>
		/// '-command' option otherwise source script mentioned in '-<br/>
		/// tcl_file' option<br/>
		/// </para>
		/// </param>
		/// <param name="toolbar_icon">(Optional) The full path to the PNG or JPEG file to display on the toolbar button</param>
		/// <param name="command">(Optional) The command to execute</param>
		/// <param name="tcl_file">(Optional) The full path to the Tcl file to source</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_gui_custom_command(String name, String menu_name = null, String description = null, bool? show_on_toolbar = null, String run_proc = null, String toolbar_icon = null, String command = null, String tcl_file = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_gui_custom_command -name <arg> [-menu_name <arg>] [-description <arg>] [-show_on_toolbar] [-run_proc <arg>] [-toolbar_icon <arg>] [-command <arg>] [-tcl_file <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_gui_custom_command(name, menu_name, description, show_on_toolbar, run_proc, toolbar_icon, command, tcl_file, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a custom command argument for a custom command in the GUI<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_gui_custom_command_arg -command_name &lt;arg&gt; -arg_name &lt;arg&gt; [-default &lt;arg&gt;] [-comment &lt;arg&gt;] [-optional] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This commands defines an argument for a specific custom GUI command.<br/>
		/// You can use the get_gui_custom_commands to determine the list of defined custom<br/>
		/// commands. You can use the get_gui_custom_command_args to determine the list of<br/>
		/// defined GUI custom command arguments of a particular GUI custom command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example creates an argument named 'quiet' for the custom GUI command<br/>
		/// print_version. The argument is defined as optional and its default value is -quiet.<br/>
		/// create_gui_custom_command_arg -command_name print_version -arg_name quiet \<br/>
		/// -default "-quiet" -comment "Ignore commands errors" -optional<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 282<br/>
		/// </para>
		/// </summary>
		/// <param name="command_name">
		/// <para>
		/// (Required)<br/>
		/// Unique name of the custom command for which an<br/>
		/// argument is being created.<br/>
		/// </para>
		/// </param>
		/// <param name="arg_name">(Required) Unique name of the custom command argument to create.</param>
		/// <param name="default">(Optional) Default value of the custom command argument.</param>
		/// <param name="comment">(Optional) Comment for the custom command argument.</param>
		/// <param name="optional">(Optional) Make the custom command argument optional.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_gui_custom_command_arg(String command_name, String arg_name, String @default = null, String comment = null, bool? optional = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_gui_custom_command_arg -command_name <arg> -arg_name <arg> [-default <arg>] [-comment <arg>] [-optional] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_gui_custom_command_arg(command_name, arg_name, @default, comment, optional, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// End a set of commands that can be undone/redone as a group<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: endgroup [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Ends a sequence of commands that can be undone or redone as a series. Use startgroup to<br/>
		/// start the sequence of commands.<br/>
		/// You can have multiple command groups to undo or redo, but you cannot nest command groups.<br/>
		/// You must use endgroup to end a command sequence before using startgroup to create a<br/>
		/// new command sequence.<br/>
		/// TIP: The startgroup /endgroup commands are provided to support sequences of related commands<br/>
		/// that can be undone via the undo command, or redone if needed using the redo command. However,<br/>
		/// some Tcl commands can trigger an endgroup unexpectedly, and certain commands do not support either<br/>
		/// UNDO or REDO. The limitations are not fully defined.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example defines a startgroup, executes a sequence of related commands, and<br/>
		/// then executes the endgroup. This sequence of commands can be undone as a group:<br/>
		/// startgroup<br/>
		/// create_pblock pblock_wbArbEngine<br/>
		/// create_pblock pblock_usbEng<br/>
		/// add_cells_to_pblock pblock_wbArbEngine \<br/>
		/// [get_cells [list wbArbEngine]] -clear_locs<br/>
		/// add_cells_to_pblock pblock_usbEng \<br/>
		/// [get_cells [list usbEngine1/usbEngineSRAM]] -clear_locs<br/>
		/// endgroup<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 507<br/>
		/// </para>
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
		/// <para>
		/// Get custom command arguments<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_gui_custom_command_args -command_name &lt;arg&gt; [-regexp] [-nocase] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Returns the list of GUI custom command argument names for a particular GUI custom command.<br/>
		/// You can use the get_gui_custom_commands to determine the list of defined custom<br/>
		/// commands.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns a list of command arguments for the GUI custom command abc:<br/>
		/// get_gui_custom_command_args -command_name abc<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 701<br/>
		/// </para>
		/// </summary>
		/// <param name="command_name">
		/// <para>
		/// (Required)<br/>
		/// Unique name of the custom command whose arguments<br/>
		/// need to be displayed.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the custom command argument names against patterns Default: *</param>
		/// <returns>list of custom command argument names</returns>
		public TTCL get_gui_custom_command_args(String command_name, bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, TCLParameterList patterns = null)
		{
			// TCL Syntax: get_gui_custom_command_args -command_name <arg> [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_gui_custom_command_args(command_name, regexp, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get custom commands<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_gui_custom_commands [-regexp] [-nocase] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Returns the list of GUI custom commands.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns a list of all the GUI custom commands which has names starting<br/>
		/// with 'p':<br/>
		/// get_gui_custom_commands p*<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 703<br/>
		/// </para>
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
		/// <para>
		/// Get highlighted objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_highlighted_objects [-color_index &lt;arg&gt;] [-rgb &lt;args&gt;] [-color &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Gets the highlighted objects in the current design open in the Vivado IDE. Objects can be<br/>
		/// highlighted with the highlight_objects command.<br/>
		/// You can get all highlighted objects in the design, or specify highlighted objects by color, by color<br/>
		/// index, or by RGB value.<br/>
		/// Note: This Tcl command works only when Vivado is run in GUI mode.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets all the highlighted objects in the current design:<br/>
		/// get_highlighted_objects<br/>
		/// The following example gets the object in the current design that are highlighted in the specified<br/>
		/// color:<br/>
		/// get_highlighted_objects -color cyan<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 706<br/>
		/// </para>
		/// </summary>
		/// <param name="color_index">(Optional) Color index</param>
		/// <param name="rgb">(Optional) RGB color index list</param>
		/// <param name="color">(Optional) Valid values are red green blue magenta yellow cyan and orange</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of highlighted objects</returns>
		public TTCL get_highlighted_objects(String color_index = null, TCLParameterList rgb = null, String color = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_highlighted_objects [-color_index <arg>] [-rgb <args>] [-color <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_highlighted_objects(color_index, rgb, color, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get marked objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_marked_objects [-rgb &lt;args&gt;] [-color &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Get the marked objects in the current design open in the Vivado IDE. Objects can be marked<br/>
		/// with the mark_objects command.<br/>
		/// You can get all marked objects in the design, or specify marked objects by color, or by RGB value.<br/>
		/// Note: This Tcl command works only when Vivado is run in GUI mode.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets all the marked objects in the current design:<br/>
		/// get_marked_objects<br/>
		/// The following example gets the object in the current design that are marked in the specified<br/>
		/// color:<br/>
		/// get_marked_objects -color yellow<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 827<br/>
		/// </para>
		/// </summary>
		/// <param name="rgb">(Optional) RGB color index list</param>
		/// <param name="color">(Optional) Valid values are red green blue magenta yellow cyan and orange</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of marked objects</returns>
		public TTCL get_marked_objects(TCLParameterList rgb = null, String color = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_marked_objects [-rgb <args>] [-color <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_marked_objects(rgb, color, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get selected objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_selected_objects [-primary] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Gets the objects currently selected in the Vivado IDE by the select_objects command. Can<br/>
		/// get the primary selected object and any secondary selected objects as well.<br/>
		/// Note: This Tcl command works only when Vivado is run in GUI mode.<br/>
		/// Primary objects are directly selected, while secondary objects are selected based on the selection<br/>
		/// rules currently defined by the Tools → Settings command. Refer to the Vivado Design Suite User<br/>
		/// Guide: Using the IDE (UG893) for more information on setting selection rules.<br/>
		/// This command returns a Tcl list of selected objects, even a list with just one object. This can be an<br/>
		/// issue for some of the Vivado tool commands that do not accept a list of objects, such as the<br/>
		/// current_instance command. In this case you can use lindex to pass a specific object from<br/>
		/// the get_selected_objects list to the current_instance command:<br/>
		/// current_instance [lindex [get_selected_objects] 0]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the properties of all currently selected objects, both primary and<br/>
		/// secondary:<br/>
		/// report_property [get_selected_objects]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 918<br/>
		/// </para>
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
		/// <para>
		/// Highlight objects in different colors<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: highlight_objects [-color_index &lt;arg&gt;] [-rgb &lt;args&gt;] [-color &lt;arg&gt;] [-leaf_cells] [-quiet] [-verbose] &lt;objects&gt;
		/// <br/>
		/// <para>
		/// Highlights the specified or selected object or objects in a color as determined by one of the<br/>
		/// available color options.<br/>
		/// TIP: Only one of the available color option should be used to specify the highlight color. However, if more<br/>
		/// than one color option is used, the order of precedence to define the color is -rgb, -color_index, and -<br/>
		/// color.<br/>
		/// Selected objects are automatically unselected in order to display the objects in the specified<br/>
		/// highlight color. Objects can be unhighlighted with the unhighlight_objects command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example highlights the currently selected objects in the color red:<br/>
		/// highlight_objects -color red [get_selected_objects]<br/>
		/// This example highlights the specified cells in green:<br/>
		/// highlight_objects -color green -leaf_cells [get_cells cpuEngine/*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 976<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) Objects to highlight</param>
		/// <param name="color_index">(Optional) Color index</param>
		/// <param name="rgb">(Optional) RGB color index list</param>
		/// <param name="color">(Optional) Valid values are red green blue magenta yellow cyan and orange</param>
		/// <param name="leaf_cells">(Optional) Leaf cells</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL highlight_objects(String objects, String color_index = null, TCLParameterList rgb = null, String color = null, bool? leaf_cells = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: highlight_objects [-color_index <arg>] [-rgb <args>] [-color <arg>] [-leaf_cells] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.highlight_objects(objects, color_index, rgb, color, leaf_cells, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Mark objects in GUI<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: mark_objects [-rgb &lt;args&gt;] [-color &lt;arg&gt;] [-quiet] [-verbose] &lt;objects&gt;
		/// <br/>
		/// <para>
		/// Marks specified objects in GUI mode. This command places an iconic mark to aid in the location<br/>
		/// of the specified object or objects. The mark is displayed in a color as determined by one of the<br/>
		/// color options.<br/>
		/// Objects can be unmarked with the unmark_objects command.<br/>
		/// Note: Use only one color option. If both color options are specified, -rgb takes precedence over -color.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example adds a red icon to mark the currently selected objects:<br/>
		/// mark_objects -color red [get_selected_objects]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1062<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) Objects to mark</param>
		/// <param name="rgb">(Optional) RGB color index list</param>
		/// <param name="color">(Optional) Valid values are red green blue magenta yellow cyan and orange</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL mark_objects(String objects, TCLParameterList rgb = null, String color = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: mark_objects [-rgb <args>] [-color <arg>] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.mark_objects(objects, rgb, color, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Re-do previous command<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: redo [-list] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// IMPORTANT! The UNDO and REDO commands are intended for use in the Vivado IDE, and are not<br/>
		/// recommended for use in Tcl scripts to restore designs to a former state. To restore a design to a specific<br/>
		/// condition, you must write a design checkpoint using the write_checkpoint command, to be restored<br/>
		/// using read_checkpoint.<br/>
		/// Redo a command that has been previously undone. This command can be used repeatedly to<br/>
		/// redo a series of commands.<br/>
		/// If a command group has been created using the startgroup and endgroup commands, the<br/>
		/// redo command will redo the group of commands as a sequence.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns a list of commands that can be redone:<br/>
		/// redo -list<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1196<br/>
		/// </para>
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
		/// <para>
		/// Remove one or more custom command arguments<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_gui_custom_command_args -command_name &lt;arg&gt; [-quiet] [-verbose] &lt;names&gt;...
		/// <br/>
		/// <para>
		/// Remove one or more GUI custom command arguments of a particular GUI custom command.<br/>
		/// You can use the get_gui_custom_commands to determine the list of defined custom<br/>
		/// commands. You can use the get_gui_custom_command_args to determine the list of<br/>
		/// defined GUI custom command arguments for a particular GUI custom command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// Remove GUI custom command arguments with name 'arg1' and 'arg2' of a GUI custom command<br/>
		/// with name 'cmd_1' :<br/>
		/// remove_gui_custom_command_args -command_name cmd_1 {arg1 arg2}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1252<br/>
		/// </para>
		/// </summary>
		/// <param name="command_name">(Required) name of custom command whose arguments are being removed.</param>
		/// <param name="names">(Required) name of one or more custom command arguments to remove.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_gui_custom_command_args(String command_name, TCLParameterList names, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_gui_custom_command_args -command_name <arg> [-quiet] [-verbose] <names>...
			_tcl.Entry(_builder.remove_gui_custom_command_args(command_name, names, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove one or more custom commands<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_gui_custom_commands [-quiet] [-verbose] &lt;names&gt;...
		/// <br/>
		/// <para>
		/// Remove one or more GUI custom commands.<br/>
		/// You can use the get_gui_custom_commands to determine the list of defined custom<br/>
		/// commands.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example removes the GUI custom commands with names 'abc' and 'xyz':<br/>
		/// remove_gui_custom_commands {abc xyz}<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1254<br/>
		/// </para>
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
		/// <para>
		/// Select objects in GUI<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: select_objects [-add] [-quiet] [-verbose] &lt;objects&gt;
		/// <br/>
		/// <para>
		/// Selects the specified object in the appropriate open views in the GUI mode. This command is for<br/>
		/// display purposes only. You must use the get_selected_objects command to return the<br/>
		/// selected objects for use in other commands.<br/>
		/// The select_objects command may select secondary objects in addition to the primary object<br/>
		/// specified. The selection of secondary objects is controlled through the use of Selection Rules<br/>
		/// defined in the Tools → Settings command. Refer to the Vivado Design Suite User Guide: Using the<br/>
		/// IDE (UG893) for more information on Setting Selection Rules.<br/>
		/// Selected objects can be unselected with the unselect_objects command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example selects the specified site on the device:<br/>
		/// select_objects [get_sites SLICE_X56Y214]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1588<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) Objects to select</param>
		/// <param name="add">(Optional) Add to existing selection list</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL select_objects(String objects, bool? add = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: select_objects [-add] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.select_objects(objects, add, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Show objects in Find Results view<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: show_objects [-name &lt;arg&gt;] [-quiet] [-verbose] &lt;objects&gt;
		/// <br/>
		/// <para>
		/// Populates the specified objects into the Find Results window in the Vivado IDE.<br/>
		/// Note: This command is only useful when run in the Vivado IDE. When run in Tcl or Batch mode the<br/>
		/// command simply returns without error or comment.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example shows all DSP objects in the current design in the Find Results window.<br/>
		/// show_objects -name All_DSPs [all_dsps]<br/>
		/// The following example shows all of the cells in the design hierarchy that are Clock or DSP<br/>
		/// PRIMITIVE_TYPEs:<br/>
		/// show_objects -name find_1 [get_cells -hierarchical \<br/>
		/// -filter { PRIMITIVE_TYPE =~ CLK.*.* || PRIMITIVE_TYPE =~ MULT.dsp.* } ]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1706<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) Objects to show Find Results view</param>
		/// <param name="name">(Optional) Tab title</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL show_objects(String objects, String name = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: show_objects [-name <arg>] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.show_objects(objects, name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Show netlist items in schematic view<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: show_schematic [-add] [-remove] [-regenerate] [-pin_pairs] [-name &lt;arg&gt;] [-quiet] [-verbose] &lt;objects&gt;
		/// <br/>
		/// <para>
		/// Create a schematic view containing the specified design objects when the tool is invoked in GUI<br/>
		/// mode.<br/>
		/// The scope of the schematic that is displayed depends on the objects specified. A schematic<br/>
		/// created with cells, shows the specified cells and any connections between the cells. A schematic<br/>
		/// created with pins, shows the pin objects, or shows them connected as appropriate if -<br/>
		/// pin_pairs is specified. A schematic created with nets shows the nets, as well as the cells and<br/>
		/// ports connected to the nets.<br/>
		/// To display a schematic with multiple levels of hierarchy, use the current_instance command<br/>
		/// to set the top-level of the hierarchy, or the level of interest, and use the -hierarchical option<br/>
		/// when specifying design objects with a get_* command.<br/>
		/// Note: This command is only useful when run in the Vivado IDE. When run in Tcl or Batch mode the<br/>
		/// command simply returns without error or comment.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a schematic for the top-level of the design, displaying the nets as<br/>
		/// well as the ports and cells they connect to:<br/>
		/// show_schematic [get_nets]<br/>
		/// The following example sets the level of hierarchy of interest, and creates a hierarchical schematic<br/>
		/// from the current level down:<br/>
		/// current_instance A<br/>
		/// show_schematic [get_nets -hier]<br/>
		/// The following example creates a schematic window showing the specified pins, and the wire<br/>
		/// connection between them:<br/>
		/// show_schematic -pin_pairs [get_pins {data0_i/O data_reg/D}]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1708<br/>
		/// </para>
		/// </summary>
		/// <param name="objects">(Required) Netlist items to show in schematic view</param>
		/// <param name="add">(Optional) Add to existing schematic view</param>
		/// <param name="remove">(Optional) Remove from existing schematic view</param>
		/// <param name="regenerate">(Optional) Regenerate layout of schematic view</param>
		/// <param name="pin_pairs">
		/// <para>
		/// (Optional)<br/>
		/// objects are treated as pair of connected pins. This can be<br/>
		/// useful to display paths<br/>
		/// </para>
		/// </param>
		/// <param name="name">(Optional) Schematic window title</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL show_schematic(String objects, bool? add = null, bool? remove = null, bool? regenerate = null, bool? pin_pairs = null, String name = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: show_schematic [-add] [-remove] [-regenerate] [-pin_pairs] [-name <arg>] [-quiet] [-verbose] <objects>
			_tcl.Entry(_builder.show_schematic(objects, add, remove, regenerate, pin_pairs, name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Start GUI<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: start_gui [-verbose]
		/// <br/>
		/// <para>
		/// Launches the GUI when the tool is running in the Vivado Design Suite Tcl shell. The GUI is<br/>
		/// invoked with the current project, design, and run information.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example is executed from the command prompt when the tool is running in Tcl<br/>
		/// mode:<br/>
		/// Vivado% start_gui<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1713<br/>
		/// </para>
		/// </summary>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL start_gui(bool? verbose = null)
		{
			// TCL Syntax: start_gui [-verbose]
			_tcl.Entry(_builder.start_gui(verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Start a set of commands that can be undone/redone as a group<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: startgroup [-try] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Starts a sequence of commands that can be undone or redone as a series. Use endgroup to end<br/>
		/// the sequence of commands.<br/>
		/// You can have multiple command groups to undo or redo, but you cannot nest command groups.<br/>
		/// You must use endgroup to end a command sequence before using startgroup to create a<br/>
		/// new command sequence.<br/>
		/// TIP: The startgroup /endgroup commands are provided to support sequences of related commands<br/>
		/// that can be undone via the undo command, or redone if needed using the redo command. However,<br/>
		/// some commands can trigger an endgroup unexpectedly, and certain commands do not support either<br/>
		/// undo or redo. The limitations are not fully defined.<br/>
		/// The startgroup command returns an integer value of 0 if a group is already started, and<br/>
		/// returns an integer value of 1 if the startgroup command has started a new group.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example defines a startgroup, executes a sequence of related commands, and<br/>
		/// then executes the endgroup. This sequence of commands can be undone or redone as a group:<br/>
		/// startgroup<br/>
		/// create_pblock pblock_wbArbEngine<br/>
		/// create_pblock pblock_usbEngnSRM<br/>
		/// add_cells_to_pblock pblock_wbArbEngine \<br/>
		/// [get_cells [list wbArbEngine]] -clear_locs<br/>
		/// add_cells_to_pblock pblock_usbEngnSRM \<br/>
		/// [get_cells [list usbEngine1/usbEngineSRAM]] -clear_locs<br/>
		/// endgroup<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1716<br/>
		/// </para>
		/// </summary>
		/// <param name="try">(Optional) Don't start a group if one has already been started</param>
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
		/// <para>
		/// Close GUI<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: stop_gui [-verbose]
		/// <br/>
		/// <para>
		/// Stops GUI mode and places the tool into Tcl mode, running in the Vivado Design Suite Tcl shell. In<br/>
		/// Tcl mode, all commands must be entered as Tcl commands or through Tcl scripts.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example stops and closes the GUI and places the tool into Tcl mode:<br/>
		/// stop_gui<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1722<br/>
		/// </para>
		/// </summary>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL stop_gui(bool? verbose = null)
		{
			// TCL Syntax: stop_gui [-verbose]
			_tcl.Entry(_builder.stop_gui(verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Un-do previous command<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: undo [-list] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// IMPORTANT! The undo and redo commands are intended for use in the Vivado IDE, and are not<br/>
		/// recommended for use in Tcl scripts to restore designs to a former state. To restore a design to a specific<br/>
		/// condition, you must write a design checkpoint using the write_checkpoint command, to be restored<br/>
		/// using read_checkpoint.<br/>
		/// Undo a prior command. This command can be used repeatedly to undo a series of commands.<br/>
		/// If a group of commands has been created using the startgroup and endgroup commands,<br/>
		/// this command will undo that group as a sequence. The undo command will start at the<br/>
		/// endgroup command and continue to undo until it hits the startgroup command.<br/>
		/// If you undo a command, and then change your mind, you can redo the command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns a list of commands that you can undo:<br/>
		/// undo -list<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1746<br/>
		/// </para>
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
		/// <para>
		/// Unhighlight objects that are currently highlighted<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: unhighlight_objects [-color_index &lt;arg&gt;] [-rgb &lt;args&gt;] [-color &lt;arg&gt;] [-leaf_cells] [-quiet] [-verbose] [&lt;objects&gt;]
		/// <br/>
		/// <para>
		/// This command is for use in GUI mode. This command unhighlights the specified object or objects<br/>
		/// that were previously highlighted by the highlight_objects command.<br/>
		/// This command supports the color options as specified below. These options can be used to<br/>
		/// unhighlight all objects currently highlighted in the specified color. See the example below.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example unhighlights the specified cell objects:<br/>
		/// unhighlight_objects -leaf_cells [get_cells cpuEngine/*]<br/>
		/// The following example unhighlights all objects currently highlighted in the color yellow:<br/>
		/// unhighlight_objects -color yellow<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1750<br/>
		/// </para>
		/// </summary>
		/// <param name="color_index">(Optional) Color index</param>
		/// <param name="rgb">(Optional) RGB color index list</param>
		/// <param name="color">(Optional) Valid values are red green blue magenta yellow cyan and orange</param>
		/// <param name="leaf_cells">(Optional) Leaf cells</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">(Optional) Objects to unhighlight</param>
		public TTCL unhighlight_objects(String color_index = null, TCLParameterList rgb = null, String color = null, bool? leaf_cells = null, bool? quiet = null, bool? verbose = null, String objects = null)
		{
			// TCL Syntax: unhighlight_objects [-color_index <arg>] [-rgb <args>] [-color <arg>] [-leaf_cells] [-quiet] [-verbose] [<objects>]
			_tcl.Entry(_builder.unhighlight_objects(color_index, rgb, color, leaf_cells, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Unmark items that are currently marked<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: unmark_objects [-rgb &lt;args&gt;] [-color &lt;arg&gt;] [-quiet] [-verbose] [&lt;objects&gt;]
		/// <br/>
		/// <para>
		/// Unmarks the specified object or objects that were previously marked by the mark_objects<br/>
		/// command. This command is for use in GUI mode.<br/>
		/// This command supports the color options as specified below. However, these options are not<br/>
		/// necessary to unmark a specific object, but can be used to unmark all objects currently marked in<br/>
		/// the specified color. See the example below.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example unmarks the selected objects:<br/>
		/// unmark_objects [get_selected_objects]<br/>
		/// The following example unmarks all objects currently marked in the color yellow:<br/>
		/// unmark_objects -color yellow<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1752<br/>
		/// </para>
		/// </summary>
		/// <param name="rgb">(Optional) RGB color index list</param>
		/// <param name="color">(Optional) Valid values are red green blue magenta yellow cyan and orange</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">(Optional) Objects to unmark</param>
		public TTCL unmark_objects(TCLParameterList rgb = null, String color = null, bool? quiet = null, bool? verbose = null, String objects = null)
		{
			// TCL Syntax: unmark_objects [-rgb <args>] [-color <arg>] [-quiet] [-verbose] [<objects>]
			_tcl.Entry(_builder.unmark_objects(rgb, color, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Unselect items that are currently selected<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: unselect_objects [-quiet] [-verbose] [&lt;objects&gt;]
		/// <br/>
		/// <para>
		/// Unselects the specified object or objects that were previously selected by the<br/>
		/// select_objects command.<br/>
		/// This command will unselect both primary and secondary selected objects. The selection of<br/>
		/// secondary objects is controlled through the use of Selection Rules defined in the Tools → Settings<br/>
		/// command. Refer to the Vivado Design Suite User Guide: Using the IDE (UG893) for more<br/>
		/// information on Setting Selection Rules.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example unselects the specified site on the device:<br/>
		/// unselect_objects [get_sites SLICE_X56Y214]<br/>
		/// The following example unselects all currently selected objects:<br/>
		/// unselect_objects<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1758<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">(Optional) Objects to unselect</param>
		public TTCL unselect_objects(bool? quiet = null, bool? verbose = null, String objects = null)
		{
			// TCL Syntax: unselect_objects [-quiet] [-verbose] [<objects>]
			_tcl.Entry(_builder.unselect_objects(quiet, verbose, objects));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
