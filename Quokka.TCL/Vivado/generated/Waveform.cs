// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class WaveformCommands
	{
		private readonly QuokkaTCL _tcl;
		public WaveformCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Add new waves
		///
		/// The add_wave command creates one or more new design-based wave objects.
		/// This command returns the name of the newly-created wave object(s).
		/// Note: This command can only be used when running a simulation. At a minimum, you must specify an
		/// item, which is an HDL object (signal) within the simulation project. In the Vivado interface, the object
		/// would display in the Objects Window.
		///
		/// The following example defines a wave group, defines a color for that group, and adds all signals
		/// that begin with the letter 's', and has at least one character following it followed by 0 or more
		/// characters, to the wave window in the wave group:
		/// set groupColor YELLOW
		/// set AXIS_ID [add_wave_group "Streaming Data"]
		/// add_wave -into $AXIS_ID -color $groupColor -regexp s.*
		/// Add the dout_tvalid signal from the rsb_design_testbench to the existing simulation waveform
		/// configuration:
		/// add_wave dout_tvalid /rsb_design_testbench/dout_tvalid
		///
		/// See ug835-vivado-tcl-commands.pdf, page 57
		/// </summary>
		/// <param name="items">
		/// Required
		/// the design objects from which to create wave objects
		/// </param>
		/// <param name="into">
		/// Optional
		/// the wave configuration, group, or virtual bus into which the
		/// new wave object(s) will be inserted.
		/// </param>
		/// <param name="at_wave">
		/// Optional
		/// inserts the new wave object(s) into the specified wave
		/// object, or after the specified wave object if not a group or
		/// virtual bus
		/// </param>
		/// <param name="after_wave">
		/// Optional
		/// inserts the new wave objects(s) after the specified wave
		/// object
		/// </param>
		/// <param name="before_wave">
		/// Optional
		/// inserts the new wave objects(s) before the specified wave
		/// object
		/// </param>
		/// <param name="reverse">
		/// Optional
		/// reverses the displayed bit order of the new wave objects(s)
		/// </param>
		/// <param name="radix">
		/// Optional
		/// sets the displayed radix of the new wave object(s) to the
		/// specified radix. Allowed values are: default, dec, bin, oct,
		/// hex, unsigned, ascii, smag
		/// </param>
		/// <param name="color">
		/// Optional
		/// sets the displayed color of the new wave object(s) to the
		/// specified color, which can be a standard color name or a
		/// string of the form #RRGGBB
		/// </param>
		/// <param name="name">
		/// Optional
		/// sets the displayed name of the single new wave object to
		/// the specified string
		/// </param>
		/// <param name="recursive">
		/// Optional
		/// if the design object is a scope, this option specifies that
		/// wave objects for all design objects under that scope should
		/// be created
		/// </param>
		/// <param name="r">
		/// Optional
		/// if the design object is a scope, this option specifies that
		/// wave objects for all design objects under that scope should
		/// be created
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// interprets <items> using regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// only when regexp is used, performs a case insensitive
		/// match
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>The new waves</returns>
		public void add_wave(string items, string into = null, string at_wave = null, string after_wave = null, string before_wave = null, bool? reverse = null, string radix = null, string color = null, string name = null, bool? recursive = null, bool? r = null, bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("add_wave");
			command.OptionalString("into", into);
			command.OptionalString("at_wave", at_wave);
			command.OptionalString("after_wave", after_wave);
			command.OptionalString("before_wave", before_wave);
			command.Flag("reverse", reverse);
			command.OptionalString("radix", radix);
			command.OptionalString("color", color);
			command.OptionalString("name", name);
			command.Flag("recursive", recursive);
			command.Flag("r", r);
			command.Flag("regexp", regexp);
			command.Flag("nocase", nocase);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("items", items);
			_tcl.Add(command);
		}
		/// <summary>
		/// Add a new divider
		///
		/// Creates a wave divider in the wave form viewer. The wave divider can be used to separate
		/// groups of related objects, for easier viewing.
		/// The wave divider can be added into a specified or current waveform configuration (WCFG) at the
		/// specified location. If no location is specified the wave divider is inserted at the end of the
		/// waveform configuration.
		/// This command returns the name of the newly-created wave divider.
		/// Note: This command can only be used when running a simulation.
		///
		/// The following example inserts a wave divider named Div1, after the CLK wave object:
		/// add_wave_divider -after_wave CLK Div1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 60
		/// </summary>
		/// <param name="into">
		/// Optional
		/// the wave configuration or group into which the new divider
		/// will be inserted.
		/// </param>
		/// <param name="at_wave">
		/// Optional
		/// inserts the new divider into the specified wave object, or
		/// after the specified wave object if not a group
		/// </param>
		/// <param name="after_wave">
		/// Optional
		/// inserts the new divider after the specified wave object
		/// </param>
		/// <param name="before_wave">
		/// Optional
		/// inserts the new divider before the specified wave object
		/// </param>
		/// <param name="color">
		/// Optional
		/// sets the displayed color of the new divider to the specified
		/// color, which can be a standard color name or a string of the
		/// form #RRGGBB Default: default
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="name">
		/// Optional
		/// the displayed name of the new divider to the specified
		/// string Default: new_divider
		/// </param>
		/// <returns>The new divider</returns>
		public void add_wave_divider(string into = null, string at_wave = null, string after_wave = null, string before_wave = null, string color = null, bool? quiet = null, bool? verbose = null, string name = null)
		{
			var command = new SimpleTCLCommand("add_wave_divider");
			command.OptionalString("into", into);
			command.OptionalString("at_wave", at_wave);
			command.OptionalString("after_wave", after_wave);
			command.OptionalString("before_wave", before_wave);
			command.OptionalString("color", color);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("name", name);
			_tcl.Add(command);
		}
		/// <summary>
		/// Add a new group
		///
		/// Creates a wave group into a specified or current waveform configuration. New wave objects and
		/// wave_dividers can be added into the wave group to build up the waveform display.
		/// The wave group can be inserted at a specified location. If no location is specified the group is
		/// inserted at the end of the specified waveform configuration.
		/// The command returns the name of the newly created wave group object.
		/// Note: This command can only be used when running a simulation.
		///
		/// Add a clk to the existing waveform configuration:
		/// add_wave_group clk
		/// group10
		///
		/// See ug835-vivado-tcl-commands.pdf, page 62
		/// </summary>
		/// <param name="into">
		/// Optional
		/// the wave configuration or group into which the new group
		/// will be inserted.
		/// </param>
		/// <param name="at_wave">
		/// Optional
		/// inserts the new group into the specified wave object, or
		/// after the specified wave object if not a group
		/// </param>
		/// <param name="after_wave">
		/// Optional
		/// inserts the new group after the specified wave object
		/// </param>
		/// <param name="before_wave">
		/// Optional
		/// inserts the new group before the specified wave object
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="name">
		/// Optional
		/// the displayed name of the new group to the specified string
		/// Default: new_group
		/// </param>
		/// <returns>The new group</returns>
		public void add_wave_group(string into = null, string at_wave = null, string after_wave = null, string before_wave = null, bool? quiet = null, bool? verbose = null, string name = null)
		{
			var command = new SimpleTCLCommand("add_wave_group");
			command.OptionalString("into", into);
			command.OptionalString("at_wave", at_wave);
			command.OptionalString("after_wave", after_wave);
			command.OptionalString("before_wave", before_wave);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("name", name);
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new wave marker
		///
		/// Creates a wave marker at the specified time and of the specified name in the current waveform
		/// configuration.
		/// This command returns nothing.
		/// Note: This command can only be used when running a simulation.
		///
		/// Add a marker to the existing waveform configuration at 500ns:
		/// add_wave_marker 500 ns
		///
		/// See ug835-vivado-tcl-commands.pdf, page 64
		/// </summary>
		/// <param name="into">
		/// Optional
		/// the wave configuration in which to create the marker
		/// </param>
		/// <param name="name">
		/// Optional
		/// sets the name of the new marker to the specified string
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="time">
		/// Optional
		/// the numerical portion of the new marker's time Default: 0
		/// </param>
		/// <param name="unit">
		/// Optional
		/// the time unit portion of the new marker's time. Allowed
		/// values are fs, ps, ns, us, ms, and s.
		/// </param>
		/// <returns>The new created marker</returns>
		public void add_wave_marker(string into = null, string name = null, bool? quiet = null, bool? verbose = null, string time = null, string unit = null)
		{
			var command = new SimpleTCLCommand("add_wave_marker");
			command.OptionalString("into", into);
			command.OptionalString("name", name);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("time", time);
			command.OptionalString("unit", unit);
			_tcl.Add(command);
		}
		/// <summary>
		/// Add a new virtual bus
		///
		/// The add_wave_virtual_bus command creates a new virtual bus of the specified <name>.
		/// The command inserts the virtual bus into the wave configuration (WCFG) where specified, or by
		/// default at the bottom of the existing WCFG. It returns a vb### for the newly-created virtual bus.
		/// Note: This command can only be used when running a simulation. At a minimum, you must specify a name,
		/// which is the name of the new virtual bus
		///
		/// Add a virtual bus of the name dout_tvalid to the end of the current waveform configuration:
		/// add_wave_virtual_bus dout_tvalid
		///
		/// See ug835-vivado-tcl-commands.pdf, page 66
		/// </summary>
		/// <param name="into">
		/// Optional
		/// the wave configuration, group, or virtual bus into which the
		/// new virtual bus will be inserted.
		/// </param>
		/// <param name="at_wave">
		/// Optional
		/// inserts the new virtual bus into the specified wave object, or
		/// after the specified wave object if not a group or virtual bus
		/// </param>
		/// <param name="after_wave">
		/// Optional
		/// inserts the new virtual bus after the specified wave object
		/// </param>
		/// <param name="before_wave">
		/// Optional
		/// inserts the new virtual bus before the specified wave object
		/// </param>
		/// <param name="reverse">
		/// Optional
		/// reverses the displayed bit order of the new virtual bus
		/// </param>
		/// <param name="radix">
		/// Optional
		/// sets the displayed radix of the new virtual bus to the
		/// specified radix. Allowed values are: default, dec, bin, oct,
		/// hex, unsigned, ascii, smag
		/// </param>
		/// <param name="color">
		/// Optional
		/// sets the displayed color of the new virtual bus to the
		/// specified color, which can be a standard color name or a
		/// string of the form #RRGGBB Default: default
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="name">
		/// Optional
		/// the displayed name of the new virtual bus to the specified
		/// string Default: new_virtual_bus
		/// </param>
		/// <returns>The new virtual bus</returns>
		public void add_wave_virtual_bus(string into = null, string at_wave = null, string after_wave = null, string before_wave = null, bool? reverse = null, string radix = null, string color = null, bool? quiet = null, bool? verbose = null, string name = null)
		{
			var command = new SimpleTCLCommand("add_wave_virtual_bus");
			command.OptionalString("into", into);
			command.OptionalString("at_wave", at_wave);
			command.OptionalString("after_wave", after_wave);
			command.OptionalString("before_wave", before_wave);
			command.Flag("reverse", reverse);
			command.OptionalString("radix", radix);
			command.OptionalString("color", color);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("name", name);
			_tcl.Add(command);
		}
		/// <summary>
		/// Closes the wave config
		///
		/// Close the current, or specified wave configuration.
		/// In the Vivado® simulator GUI, you can work with a waveform to analyze your design and debug
		/// your code. A wave configuration object displays with top-level HDL objects, and can be further
		/// populated using commands like add_wave and add_wave_divider. A new wave
		/// configuration object can be created in the current simulation with the create_wave_config
		/// command.
		/// Any changes made to a wave configuration object can be saved to a Wave Config file with the
		/// save_wave_config command. You can open a saved Wave Config file with the
		/// open_wave_config command.
		///
		/// The following example closes all Wave Config files associated with the current simulation:
		/// close_wave_config [get_wave_configs]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 147
		/// </summary>
		/// <param name="force">
		/// Optional
		/// Forces the closing of the wave configuration, even if
		/// changes would be lost. Default behavior is to reject the
		/// closing with an error if changes would be lost.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="wcfgobj">
		/// Optional
		/// Closes and destroys the specified wave configuration object,
		/// or the current wave configuration if none specified Default:
		/// NULL
		/// </param>
		public void close_wave_config(bool? force = null, bool? quiet = null, bool? verbose = null, string wcfgobj = null)
		{
			var command = new SimpleTCLCommand("close_wave_config");
			command.Flag("force", force);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("wcfgobj", wcfgobj);
			_tcl.Add(command);
		}
		/// <summary>
		/// Creates a new wave config
		///
		/// Create a new wave configuration object in the current simulation, and open the waveform
		/// configuration in the Vivado IDE. This will make the new wave configuration object the current
		/// wave configuration.
		/// In the Vivado® simulator GUI, you can work with a waveform to analyze your design and debug
		/// your code. The Wave Config file contains the list of wave objects (signals, dividers, groups, virtual
		/// buses) to display, and their display properties, plus markers. A wave configuration displays with
		/// top-level HDL objects, and can be further populated using commands like add_wave and
		/// add_wave_divider. Any changes made to a wave configuration can be saved to a Wave
		/// Config file with the save_wave_config command.
		/// This command returns the name of the waveform configuration created, or an error if it fails.
		///
		/// The following example creates a new wave configuration object with the specified name:
		/// create_wave_config testbench1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 361
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="name">
		/// Optional
		/// Creates a new wave configuration of the specified name, or
		/// a default name if no name given. A new wave window
		/// showing that WCFG is also created and made the current
		/// wave window
		/// </param>
		/// <returns>The new wave config</returns>
		public void create_wave_config(bool? quiet = null, bool? verbose = null, string name = null)
		{
			var command = new SimpleTCLCommand("create_wave_config");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("name", name);
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the current WCFG object and sets it to the specified WCFG object if given
		///
		/// Set or get the current wave configuration object for the current simulation.
		/// In the Vivado® simulator GUI, you can work with a waveform to analyze your design and debug
		/// your code. A wave configuration displays with top-level HDL objects, and can be further
		/// populated using commands like add_wave and add_wave_divider.
		/// This command returns the name of the current wave configuration object.
		///
		/// The following example gets the testbench wave config object and makes it the current wave
		/// configuration in the simulation:
		/// current_wave_config [get_wave_config testbench]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 413
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="wcfgObj">
		/// Optional
		/// Sets the current WCFG object to the given value of wcfgObj.
		/// Defaults to current
		/// </param>
		/// <returns>Returns the new or current wave configuration object</returns>
		public void current_wave_config(bool? quiet = null, bool? verbose = null, string wcfgObj = null)
		{
			var command = new SimpleTCLCommand("current_wave_config");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("wcfgObj", wcfgObj);
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the wave configs that match the given options
		///
		/// Get the wave configuration objects that match the specified search options in the current
		/// simulation.
		/// In the Vivado® simulator GUI, you can work with a waveform to analyze your design and debug
		/// your code. The Wave Config file contains the list of wave objects (signals, dividers, groups, virtual
		/// buses) to display, and their display properties, plus markers. A wave configuration displays with
		/// top-level HDL objects, and can be further populated using commands like add_wave and
		/// add_wave_divider.
		/// This command returns the matching wave configuration objects, or returns nothing if no objects
		/// matched the search pattern.
		///
		/// The following example returns all wave configuration objects, in the current simulation, that have
		/// unsaved changes:
		/// get_wave_config -filter {NEEDS_SAVE}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 939
		/// </summary>
		/// <param name="regexp">
		/// Optional
		/// interprets <patterns> using regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// only when regexp is used, performs a case insensitive
		/// match
		/// </param>
		/// <param name="filter">
		/// Optional
		/// filters <patterns> according to the specified property￾matching expressions
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="patterns">
		/// Optional
		/// the pattern strings to search for wave configuration names
		/// </param>
		/// <returns>Wave configs that match the given options</returns>
		public void get_wave_configs(bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_wave_configs");
			command.Flag("regexp", regexp);
			command.Flag("nocase", nocase);
			command.OptionalString("filter", filter);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("patterns", patterns);
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets wave objects from a wave configuration
		///
		/// See ug835-vivado-tcl-commands.pdf, page 942
		/// </summary>
		/// <param name="patterns">
		/// Required
		/// the design objects from which to create wave objects
		/// </param>
		/// <param name="of">
		/// Optional
		/// the wave configuration, group, or virtual bus to search
		/// </param>
		/// <param name="regexp">
		/// Optional
		/// interprets <patterns> using regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// only when regexp is used, performs a case insensitive
		/// match
		/// </param>
		/// <param name="filter">
		/// Optional
		/// filters <patterns> according to the specified property￾matching expressions
		/// </param>
		/// <param name="recursive">
		/// Optional
		/// if the design object is a scope, this option specifies that
		/// wave objects for all design objects under that scope should
		/// be created
		/// </param>
		/// <param name="r">
		/// Optional
		/// if the design object is a scope, this option specifies that
		/// wave objects for all design objects under that scope should
		/// be created
		/// </param>
		/// <param name="long_name">
		/// Optional
		/// search wave objects using the long form of their names
		/// </param>
		/// <param name="short_name">
		/// Optional
		/// search wave objects using the short form of their names
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>a collection of found wave objects</returns>
		public void get_waves(string patterns, string of = null, bool? regexp = null, bool? nocase = null, string filter = null, bool? recursive = null, bool? r = null, bool? long_name = null, bool? short_name = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("get_waves");
			command.OptionalString("of", of);
			command.Flag("regexp", regexp);
			command.Flag("nocase", nocase);
			command.OptionalString("filter", filter);
			command.Flag("recursive", recursive);
			command.Flag("r", r);
			command.Flag("long_name", long_name);
			command.Flag("short_name", short_name);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("patterns", patterns);
			_tcl.Add(command);
		}
		/// <summary>
		/// Moves wave objects from their current position to the specified position in the wave
		/// configuration
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1049
		/// </summary>
		/// <param name="items">
		/// Required
		/// wave objects to move
		/// </param>
		/// <param name="into">
		/// Optional
		/// the wave configuration, group, or virtual bus into which the
		/// wave object(s) will be moved.
		/// </param>
		/// <param name="at_wave">
		/// Optional
		/// inserts the new wave object(s) into the specified wave
		/// object, or after the specified wave object if not a group or
		/// virtual bus
		/// </param>
		/// <param name="after_wave">
		/// Optional
		/// inserts the new wave objects(s) after the specified wave
		/// object
		/// </param>
		/// <param name="before_wave">
		/// Optional
		/// inserts the new wave objects(s) before the specified wave
		/// object
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void move_wave(string items, string into = null, string at_wave = null, string after_wave = null, string before_wave = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("move_wave");
			command.OptionalString("into", into);
			command.OptionalString("at_wave", at_wave);
			command.OptionalString("after_wave", after_wave);
			command.OptionalString("before_wave", before_wave);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("items", items);
			_tcl.Add(command);
		}
		/// <summary>
		/// Open a wave config
		///
		/// Open the specified Wave Config file (.wcfg) in the current simulation.
		/// Vivado simulator uses a simulation debug data model to allow users to debug HDL source files
		/// using source code stepping, breakpoints, conditions, and waveform viewing tools. The debug
		/// data model contains HDL object and scope names, and maps them to memory addresses to let
		/// you examine the changing values of signals, variables and constants during the simulation.
		/// The waveform database is separate from the Wave Config file that stores the waveform activity
		/// for the simulation. The Wave Config file contains just the list of wave objects (signals, dividers,
		/// groups, virtual buses) to display, and their display properties, plus markers. The waveform
		/// database (WDB) contains the event data, values changing over time, for all traced signals,
		/// whether displayed or not.
		/// A wave configuration object is created in the current simulation with the
		/// create_wave_config command. A Wave Config file is written to disk by the use of the
		/// save_wave_config command, and can be opened with the open_wave_config command.
		/// The open_wave_config command opens a Wave Config file and maps it to the data source in
		/// the current simulation.
		/// IMPORTANT! Any HDL objects that are specified in the Wave Config file that are not found in the current
		/// simulation will be ignored.
		///
		/// The following example opens the specified Wave Config file:
		/// open_wave_config testbench.wcfg
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1077
		/// </summary>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="filename">
		/// Optional
		/// the name of a WCFG file from which to create a new wave
		/// configuration and corresponding wave window
		/// </param>
		/// <returns>The wave config opened</returns>
		public void open_wave_config(bool? quiet = null, bool? verbose = null, string filename = null)
		{
			var command = new SimpleTCLCommand("open_wave_config");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("filename", filename);
			_tcl.Add(command);
		}
		/// <summary>
		/// Removes wave objects from the current wave configuration
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1247
		/// </summary>
		/// <param name="items">
		/// Required
		/// wave objects to remove
		/// </param>
		/// <param name="of">
		/// Optional
		/// the wave configuration, group, or virtual bus to search
		/// Default: the current wave configuration
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void remove_wave(string items, string of = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("remove_wave");
			command.OptionalString("of", of);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("items", items);
			_tcl.Add(command);
		}
		/// <summary>
		/// Saves the specified or current wave configuration object to the given filename
		///
		/// Save the current or specified wave configuration object to a specified filename.
		/// If the wave configuration object has not been saved before, and does not have a FILE_PATH
		/// property value, the <filename> is required and the NAME of the wave configuration object will
		/// be changed to match the specified <filename>.
		/// If the specified wave configuration object has been previously saved, and has a FILE_PATH
		/// property, the object will be written to its current location, and the <filename> does not need to
		/// be specified.
		/// If the wave configuration object has a FILE_PATH property, but a different <filename> is
		/// specified, the wave configuration object will be saved to the new <filename>, and the object will
		/// be renamed to match the specified <filename>.
		///
		/// The following example saves the specified wave configuration object to a new filename:
		/// save_wave_config -object [get_wave_configs test.wcfg] \
		/// C:/Data/project/newTest
		/// Note: The wave config file will be assigned the .wcfg suffix since none is specified.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1545
		/// </summary>
		/// <param name="@object">
		/// Optional
		/// The WCFG or wave configuration to save. Default: Current
		/// wave configuration
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="filename">
		/// Optional
		/// Filename to save the specified or current wave
		/// configuration object
		/// </param>
		/// <returns>The wave configuration object saved</returns>
		public void save_wave_config(string @object = null, bool? quiet = null, bool? verbose = null, string filename = null)
		{
			var command = new SimpleTCLCommand("save_wave_config");
			command.OptionalString("object", @object);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("filename", filename);
			_tcl.Add(command);
		}
		/// <summary>
		/// Display help for one or more topics
		///
		/// Selects the specified object in the Waveform window of the Vivado IDE. This command is for
		/// selecting displayed items in the Waveform window only, and is similar to the select_objects
		/// command in the Vivado IDE.
		/// Note: Use the get_hdl_objects command to select simulation objects in the open simulation, or
		/// current_sim.
		/// Unselect selected objects using the select_wave_objects command with an empty string:
		/// select_wave_objects ""
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example selects the specified site on the device:
		/// select_wave_objects {sys_clk_p sysc_clk_n}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1557
		/// </summary>
		/// <param name="items">
		/// Required
		/// select waveform objects
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void select_wave_objects(string items, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("select_wave_objects");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("items", items);
			_tcl.Add(command);
		}
	}
}
