#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class WaveformCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public WaveformCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// <para>
		/// Add new waves<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: add_wave [-into &lt;args&gt;] [-at_wave &lt;args&gt;] [-after_wave &lt;args&gt;] [-before_wave &lt;args&gt;] [-reverse] [-radix &lt;arg&gt;] [-color &lt;arg&gt;] [-name &lt;arg&gt;] [-recursive] [-r] [-regexp] [-nocase] [-quiet] [-verbose] &lt;items&gt;...
		/// <br/>
		/// <para>
		/// The add_wave command creates one or more new design-based wave objects.<br/>
		/// This command returns the name of the newly-created wave object(s).<br/>
		/// Note: This command can only be used when running a simulation. At a minimum, you must specify an<br/>
		/// item, which is an HDL object (signal) within the simulation project. In the Vivado interface, the object<br/>
		/// would display in the Objects Window.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example defines a wave group, defines a color for that group, and adds all signals<br/>
		/// that begin with the letter 's', and has at least one character following it followed by 0 or more<br/>
		/// characters, to the wave window in the wave group:<br/>
		/// set groupColor YELLOW<br/>
		/// set AXIS_ID [add_wave_group "Streaming Data"]<br/>
		/// add_wave -into $AXIS_ID -color $groupColor -regexp s.*<br/>
		/// Add the dout_tvalid signal from the rsb_design_testbench to the existing simulation waveform<br/>
		/// configuration:<br/>
		/// add_wave dout_tvalid /rsb_design_testbench/dout_tvalid<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 60<br/>
		/// </para>
		/// </summary>
		/// <param name="items">
		/// <para>
		/// (Required)<br/>
		/// the design objects from which to create wave objects<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// </param>
		/// <param name="into">
		/// <para>
		/// (Optional)<br/>
		/// the wave configuration, group, or virtual bus into which the<br/>
		/// new wave object(s) will be inserted.<br/>
		/// </para>
		/// </param>
		/// <param name="at_wave">
		/// <para>
		/// (Optional)<br/>
		/// inserts the new wave object(s) into the specified wave<br/>
		/// object, or after the specified wave object if not a group or<br/>
		/// virtual bus<br/>
		/// </para>
		/// </param>
		/// <param name="after_wave">(Optional) inserts the new wave objects(s) after the specified wave object</param>
		/// <param name="before_wave">(Optional) inserts the new wave objects(s) before the specified wave object</param>
		/// <param name="reverse">(Optional) reverses the displayed bit order of the new wave objects(s)</param>
		/// <param name="radix">
		/// <para>
		/// (Optional)<br/>
		/// sets the displayed radix of the new wave object(s) to the<br/>
		/// specified radix. Allowed values are: default, dec, bin, oct,<br/>
		/// hex, unsigned, ascii, smag<br/>
		/// </para>
		/// </param>
		/// <param name="color">
		/// <para>
		/// (Optional)<br/>
		/// sets the displayed color of the new wave object(s) to the<br/>
		/// specified color, which can be a standard color name or a<br/>
		/// string of the form #RRGGBB<br/>
		/// </para>
		/// </param>
		/// <param name="name">
		/// <para>
		/// (Optional)<br/>
		/// sets the displayed name of the single new wave object to<br/>
		/// the specified string<br/>
		/// </para>
		/// </param>
		/// <param name="recursive">
		/// <para>
		/// (Optional)<br/>
		/// if the design object is a scope, this option specifies that<br/>
		/// wave objects for all design objects under that scope should<br/>
		/// be created<br/>
		/// </para>
		/// </param>
		/// <param name="r">
		/// <para>
		/// (Optional)<br/>
		/// if the design object is a scope, this option specifies that<br/>
		/// wave objects for all design objects under that scope should<br/>
		/// be created<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) interprets &lt;items&gt; using regular expressions</param>
		/// <param name="nocase">(Optional) only when regexp is used, performs a case insensitive match</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The new waves</returns>
		public TTCL add_wave(TCLObjectList items, TCLParameterList into = null, TCLParameterList at_wave = null, TCLParameterList after_wave = null, TCLParameterList before_wave = null, bool? reverse = null, String radix = null, String color = null, String name = null, bool? recursive = null, bool? r = null, bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: add_wave [-into <args>] [-at_wave <args>] [-after_wave <args>] [-before_wave <args>] [-reverse] [-radix <arg>] [-color <arg>] [-name <arg>] [-recursive] [-r] [-regexp] [-nocase] [-quiet] [-verbose] <items>...
			_tcl.Entry(_builder.add_wave(items, into, at_wave, after_wave, before_wave, reverse, radix, color, name, recursive, r, regexp, nocase, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Add a new divider<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: add_wave_divider [-into &lt;args&gt;] [-at_wave &lt;args&gt;] [-after_wave &lt;args&gt;] [-before_wave &lt;args&gt;] [-color &lt;arg&gt;] [-quiet] [-verbose] [&lt;name&gt;]
		/// <br/>
		/// <para>
		/// Creates a wave divider in the wave form viewer. The wave divider can be used to separate<br/>
		/// groups of related objects, for easier viewing.<br/>
		/// The wave divider can be added into a specified or current waveform configuration (WCFG) at the<br/>
		/// specified location. If no location is specified the wave divider is inserted at the end of the<br/>
		/// waveform configuration.<br/>
		/// This command returns the name of the newly-created wave divider.<br/>
		/// Note: This command can only be used when running a simulation.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example inserts a wave divider named Div1, after the CLK wave object:<br/>
		/// add_wave_divider -after_wave CLK Div1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 63<br/>
		/// </para>
		/// </summary>
		/// <param name="into">
		/// <para>
		/// (Optional)<br/>
		/// the wave configuration or group into which the new divider<br/>
		/// will be inserted.<br/>
		/// </para>
		/// </param>
		/// <param name="at_wave">
		/// <para>
		/// (Optional)<br/>
		/// inserts the new divider into the specified wave object, or<br/>
		/// after the specified wave object if not a group<br/>
		/// </para>
		/// </param>
		/// <param name="after_wave">(Optional) inserts the new divider after the specified wave object</param>
		/// <param name="before_wave">(Optional) inserts the new divider before the specified wave object</param>
		/// <param name="color">
		/// <para>
		/// (Optional)<br/>
		/// sets the displayed color of the new divider to the specified<br/>
		/// color, which can be a standard color name or a string of the<br/>
		/// form #RRGGBB Default: default<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="name">
		/// <para>
		/// (Optional)<br/>
		/// the displayed name of the new divider to the specified<br/>
		/// string Default: new_divider<br/>
		/// </para>
		/// </param>
		/// <returns>The new divider</returns>
		public TTCL add_wave_divider(TCLParameterList into = null, TCLParameterList at_wave = null, TCLParameterList after_wave = null, TCLParameterList before_wave = null, String color = null, bool? quiet = null, bool? verbose = null, TCLObject name = null)
		{
			// TCL Syntax: add_wave_divider [-into <args>] [-at_wave <args>] [-after_wave <args>] [-before_wave <args>] [-color <arg>] [-quiet] [-verbose] [<name>]
			_tcl.Entry(_builder.add_wave_divider(into, at_wave, after_wave, before_wave, color, quiet, verbose, name));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Add a new group<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: add_wave_group [-into &lt;args&gt;] [-at_wave &lt;args&gt;] [-after_wave &lt;args&gt;] [-before_wave &lt;args&gt;] [-quiet] [-verbose] [&lt;name&gt;]
		/// <br/>
		/// <para>
		/// Creates a wave group into a specified or current waveform configuration. New wave objects and<br/>
		/// wave_dividers can be added into the wave group to build up the waveform display.<br/>
		/// The wave group can be inserted at a specified location. If no location is specified the group is<br/>
		/// inserted at the end of the specified waveform configuration.<br/>
		/// The command returns the name of the newly created wave group object.<br/>
		/// Note: This command can only be used when running a simulation.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// Add a clk to the existing waveform configuration:<br/>
		/// add_wave_group clk<br/>
		/// group10<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 65<br/>
		/// </para>
		/// </summary>
		/// <param name="into">
		/// <para>
		/// (Optional)<br/>
		/// the wave configuration or group into which the new group<br/>
		/// will be inserted.<br/>
		/// </para>
		/// </param>
		/// <param name="at_wave">
		/// <para>
		/// (Optional)<br/>
		/// inserts the new group into the specified wave object, or<br/>
		/// after the specified wave object if not a group<br/>
		/// </para>
		/// </param>
		/// <param name="after_wave">(Optional) inserts the new group after the specified wave object</param>
		/// <param name="before_wave">(Optional) inserts the new group before the specified wave object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="name">
		/// <para>
		/// (Optional)<br/>
		/// the displayed name of the new group to the specified string<br/>
		/// Default: new_group<br/>
		/// </para>
		/// </param>
		/// <returns>The new group</returns>
		public TTCL add_wave_group(TCLParameterList into = null, TCLParameterList at_wave = null, TCLParameterList after_wave = null, TCLParameterList before_wave = null, bool? quiet = null, bool? verbose = null, TCLObject name = null)
		{
			// TCL Syntax: add_wave_group [-into <args>] [-at_wave <args>] [-after_wave <args>] [-before_wave <args>] [-quiet] [-verbose] [<name>]
			_tcl.Entry(_builder.add_wave_group(into, at_wave, after_wave, before_wave, quiet, verbose, name));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new wave marker<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: add_wave_marker [-into &lt;arg&gt;] [-name &lt;arg&gt;] [-quiet] [-verbose] [&lt;time&gt;] [&lt;unit&gt;]
		/// <br/>
		/// <para>
		/// Creates a wave marker at the specified time and of the specified name in the current waveform<br/>
		/// configuration.<br/>
		/// This command returns nothing.<br/>
		/// Note: This command can only be used when running a simulation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// Add a marker to the existing waveform configuration at 500ns:<br/>
		/// add_wave_marker 500 ns<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 67<br/>
		/// </para>
		/// </summary>
		/// <param name="into">(Optional) the wave configuration in which to create the marker</param>
		/// <param name="name">(Optional) sets the name of the new marker to the specified string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="time">(Optional) the numerical portion of the new marker's time Default: 0</param>
		/// <param name="unit">
		/// <para>
		/// (Optional)<br/>
		/// the time unit portion of the new marker's time. Allowed<br/>
		/// values are fs, ps, ns, us, ms, and s.<br/>
		/// </para>
		/// </param>
		/// <returns>The new created marker</returns>
		public TTCL add_wave_marker(String into = null, String name = null, bool? quiet = null, bool? verbose = null, TCLObject time = null, TCLObject unit = null)
		{
			// TCL Syntax: add_wave_marker [-into <arg>] [-name <arg>] [-quiet] [-verbose] [<time>] [<unit>]
			_tcl.Entry(_builder.add_wave_marker(into, name, quiet, verbose, time, unit));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Add a new virtual bus<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: add_wave_virtual_bus [-into &lt;args&gt;] [-at_wave &lt;args&gt;] [-after_wave &lt;args&gt;] [-before_wave &lt;args&gt;] [-reverse] [-radix &lt;arg&gt;] [-color &lt;arg&gt;] [-quiet] [-verbose] [&lt;name&gt;]
		/// <br/>
		/// <para>
		/// The add_wave_virtual_bus command creates a new virtual bus of the specified &lt;name&gt;.<br/>
		/// The command inserts the virtual bus into the wave configuration (WCFG) where specified, or by<br/>
		/// default at the bottom of the existing WCFG. It returns a vb### for the newly-created virtual bus.<br/>
		/// Note: This command can only be used when running a simulation. At a minimum, you must specify a name,<br/>
		/// which is the name of the new virtual bus<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// Add a virtual bus of the name dout_tvalid to the end of the current waveform configuration:<br/>
		/// add_wave_virtual_bus dout_tvalid<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 69<br/>
		/// </para>
		/// </summary>
		/// <param name="into">
		/// <para>
		/// (Optional)<br/>
		/// the wave configuration, group, or virtual bus into which the<br/>
		/// new virtual bus will be inserted.<br/>
		/// </para>
		/// </param>
		/// <param name="at_wave">
		/// <para>
		/// (Optional)<br/>
		/// inserts the new virtual bus into the specified wave object, or<br/>
		/// after the specified wave object if not a group or virtual bus<br/>
		/// </para>
		/// </param>
		/// <param name="after_wave">(Optional) inserts the new virtual bus after the specified wave object</param>
		/// <param name="before_wave">(Optional) inserts the new virtual bus before the specified wave object</param>
		/// <param name="reverse">(Optional) reverses the displayed bit order of the new virtual bus</param>
		/// <param name="radix">
		/// <para>
		/// (Optional)<br/>
		/// sets the displayed radix of the new virtual bus to the<br/>
		/// specified radix. Allowed values are: default, dec, bin, oct,<br/>
		/// hex, unsigned, ascii, smag<br/>
		/// </para>
		/// </param>
		/// <param name="color">
		/// <para>
		/// (Optional)<br/>
		/// sets the displayed color of the new virtual bus to the<br/>
		/// specified color, which can be a standard color name or a<br/>
		/// string of the form #RRGGBB Default: default<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="name">
		/// <para>
		/// (Optional)<br/>
		/// the displayed name of the new virtual bus to the specified<br/>
		/// string Default: new_virtual_bus<br/>
		/// </para>
		/// </param>
		/// <returns>The new virtual bus</returns>
		public TTCL add_wave_virtual_bus(TCLParameterList into = null, TCLParameterList at_wave = null, TCLParameterList after_wave = null, TCLParameterList before_wave = null, bool? reverse = null, String radix = null, String color = null, bool? quiet = null, bool? verbose = null, TCLObject name = null)
		{
			// TCL Syntax: add_wave_virtual_bus [-into <args>] [-at_wave <args>] [-after_wave <args>] [-before_wave <args>] [-reverse] [-radix <arg>] [-color <arg>] [-quiet] [-verbose] [<name>]
			_tcl.Entry(_builder.add_wave_virtual_bus(into, at_wave, after_wave, before_wave, reverse, radix, color, quiet, verbose, name));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Closes the wave config<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: close_wave_config [-force] [-quiet] [-verbose] [&lt;wcfgobj&gt;]
		/// <br/>
		/// <para>
		/// Close the current, or specified wave configuration.<br/>
		/// In the Vivado® simulator GUI, you can work with a waveform to analyze your design and debug<br/>
		/// your code. A wave configuration object displays with top-level HDL objects, and can be further<br/>
		/// populated using commands like add_wave and add_wave_divider. A new wave<br/>
		/// configuration object can be created in the current simulation with the create_wave_config<br/>
		/// command.<br/>
		/// Any changes made to a wave configuration object can be saved to a Wave Config file with the<br/>
		/// save_wave_config command. You can open a saved Wave Config file with the<br/>
		/// open_wave_config command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example closes all Wave Config files associated with the current simulation:<br/>
		/// close_wave_config [get_wave_configs]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 151<br/>
		/// </para>
		/// </summary>
		/// <param name="force">
		/// <para>
		/// (Optional)<br/>
		/// Forces the closing of the wave configuration, even if<br/>
		/// changes would be lost. Default behavior is to reject the<br/>
		/// closing with an error if changes would be lost.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="wcfgobj">
		/// <para>
		/// (Optional)<br/>
		/// Closes and destroys the specified wave configuration object,<br/>
		/// or the current wave configuration if none specified Default:<br/>
		/// NULL<br/>
		/// </para>
		/// </param>
		public TTCL close_wave_config(bool? force = null, bool? quiet = null, bool? verbose = null, TCLObject wcfgobj = null)
		{
			// TCL Syntax: close_wave_config [-force] [-quiet] [-verbose] [<wcfgobj>]
			_tcl.Entry(_builder.close_wave_config(force, quiet, verbose, wcfgobj));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Creates a new wave config<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_wave_config [-quiet] [-verbose] [&lt;name&gt;]
		/// <br/>
		/// <para>
		/// Create a new wave configuration object in the current simulation, and open the waveform<br/>
		/// configuration in the Vivado IDE. This will make the new wave configuration object the current<br/>
		/// wave configuration.<br/>
		/// In the Vivado® simulator GUI, you can work with a waveform to analyze your design and debug<br/>
		/// your code. The Wave Config file contains the list of wave objects (signals, dividers, groups, virtual<br/>
		/// buses) to display, and their display properties, plus markers. A wave configuration displays with<br/>
		/// top-level HDL objects, and can be further populated using commands like add_wave and<br/>
		/// add_wave_divider. Any changes made to a wave configuration can be saved to a Wave<br/>
		/// Config file with the save_wave_config command.<br/>
		/// This command returns the name of the waveform configuration created, or an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a new wave configuration object with the specified name:<br/>
		/// create_wave_config testbench1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 371<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="name">
		/// <para>
		/// (Optional)<br/>
		/// Creates a new wave configuration of the specified name, or<br/>
		/// a default name if no name given. A new wave window<br/>
		/// showing that WCFG is also created and made the current<br/>
		/// wave window<br/>
		/// </para>
		/// </param>
		/// <returns>The new wave config</returns>
		public TTCL create_wave_config(bool? quiet = null, bool? verbose = null, TCLObject name = null)
		{
			// TCL Syntax: create_wave_config [-quiet] [-verbose] [<name>]
			_tcl.Entry(_builder.create_wave_config(quiet, verbose, name));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the current WCFG object and sets it to the specified WCFG object if given<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_wave_config [-quiet] [-verbose] [&lt;wcfgObj&gt;]
		/// <br/>
		/// <para>
		/// Set or get the current wave configuration object for the current simulation.<br/>
		/// In the Vivado® simulator GUI, you can work with a waveform to analyze your design and debug<br/>
		/// your code. A wave configuration displays with top-level HDL objects, and can be further<br/>
		/// populated using commands like add_wave and add_wave_divider.<br/>
		/// This command returns the name of the current wave configuration object.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the testbench wave config object and makes it the current wave<br/>
		/// configuration in the simulation:<br/>
		/// current_wave_config [get_wave_config testbench]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 424<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="wcfgObj">
		/// <para>
		/// (Optional)<br/>
		/// Sets the current WCFG object to the given value of wcfgObj.<br/>
		/// Defaults to current<br/>
		/// </para>
		/// </param>
		/// <returns>Returns the new or current wave configuration object</returns>
		public TTCL current_wave_config(bool? quiet = null, bool? verbose = null, TCLObject wcfgObj = null)
		{
			// TCL Syntax: current_wave_config [-quiet] [-verbose] [<wcfgObj>]
			_tcl.Entry(_builder.current_wave_config(quiet, verbose, wcfgObj));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets the wave configs that match the given options<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_wave_configs [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;...]
		/// <br/>
		/// <para>
		/// Get the wave configuration objects that match the specified search options in the current<br/>
		/// simulation.<br/>
		/// In the Vivado® simulator GUI, you can work with a waveform to analyze your design and debug<br/>
		/// your code. The Wave Config file contains the list of wave objects (signals, dividers, groups, virtual<br/>
		/// buses) to display, and their display properties, plus markers. A wave configuration displays with<br/>
		/// top-level HDL objects, and can be further populated using commands like add_wave and<br/>
		/// add_wave_divider.<br/>
		/// This command returns the matching wave configuration objects, or returns nothing if no objects<br/>
		/// matched the search pattern.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns all wave configuration objects, in the current simulation, that have<br/>
		/// unsaved changes:<br/>
		/// get_wave_config -filter {NEEDS_SAVE}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 960<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) interprets &lt;patterns&gt; using regular expressions</param>
		/// <param name="nocase">(Optional) only when regexp is used, performs a case insensitive match</param>
		/// <param name="filter">
		/// <para>
		/// (Optional)<br/>
		/// filters &lt;patterns&gt; according to the specified property-matching expressions<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) the pattern strings to search for wave configuration names</param>
		/// <returns>Wave configs that match the given options</returns>
		public TTCL get_wave_configs(bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObjectList patterns = null)
		{
			// TCL Syntax: get_wave_configs [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>...]
			_tcl.Entry(_builder.get_wave_configs(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Gets wave objects from a wave configuration<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_waves [-of &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-recursive] [-r] [-long_name] [-short_name] [-quiet] [-verbose] &lt;patterns&gt;...
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 963<br/>
		/// </para>
		/// </summary>
		/// <param name="patterns">(Required) the design objects from which to create wave objects</param>
		/// <param name="of">(Optional) the wave configuration, group, or virtual bus to search</param>
		/// <param name="regexp">(Optional) interprets &lt;patterns&gt; using regular expressions</param>
		/// <param name="nocase">(Optional) only when regexp is used, performs a case insensitive match</param>
		/// <param name="filter">
		/// <para>
		/// (Optional)<br/>
		/// filters &lt;patterns&gt; according to the specified property-matching expressions<br/>
		/// </para>
		/// </param>
		/// <param name="recursive">
		/// <para>
		/// (Optional)<br/>
		/// if the design object is a scope, this option specifies that<br/>
		/// wave objects for all design objects under that scope should<br/>
		/// be created<br/>
		/// </para>
		/// </param>
		/// <param name="r">
		/// <para>
		/// (Optional)<br/>
		/// if the design object is a scope, this option specifies that<br/>
		/// wave objects for all design objects under that scope should<br/>
		/// be created<br/>
		/// </para>
		/// </param>
		/// <param name="long_name">(Optional) search wave objects using the long form of their names</param>
		/// <param name="short_name">(Optional) search wave objects using the short form of their names</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>a collection of found wave objects</returns>
		public TTCL get_waves(TCLObjectList patterns, TCLParameterList of = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? recursive = null, bool? r = null, bool? long_name = null, bool? short_name = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_waves [-of <args>] [-regexp] [-nocase] [-filter <arg>] [-recursive] [-r] [-long_name] [-short_name] [-quiet] [-verbose] <patterns>...
			_tcl.Entry(_builder.get_waves(patterns, of, regexp, nocase, filter, recursive, r, long_name, short_name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Moves wave objects from their current position to the specified position in the wave<br/>
		/// configuration<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: move_wave [-into &lt;args&gt;] [-at_wave &lt;args&gt;] [-after_wave &lt;args&gt;] [-before_wave &lt;args&gt;] [-quiet] [-verbose] &lt;items&gt;...
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1072<br/>
		/// </para>
		/// </summary>
		/// <param name="items">(Required) wave objects to move</param>
		/// <param name="into">
		/// <para>
		/// (Optional)<br/>
		/// the wave configuration, group, or virtual bus into which the<br/>
		/// wave object(s) will be moved.<br/>
		/// </para>
		/// </param>
		/// <param name="at_wave">
		/// <para>
		/// (Optional)<br/>
		/// inserts the new wave object(s) into the specified wave<br/>
		/// object, or after the specified wave object if not a group or<br/>
		/// virtual bus<br/>
		/// </para>
		/// </param>
		/// <param name="after_wave">(Optional) inserts the new wave objects(s) after the specified wave object</param>
		/// <param name="before_wave">(Optional) inserts the new wave objects(s) before the specified wave object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL move_wave(TCLObjectList items, TCLParameterList into = null, TCLParameterList at_wave = null, TCLParameterList after_wave = null, TCLParameterList before_wave = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: move_wave [-into <args>] [-at_wave <args>] [-after_wave <args>] [-before_wave <args>] [-quiet] [-verbose] <items>...
			_tcl.Entry(_builder.move_wave(items, into, at_wave, after_wave, before_wave, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Open a wave config<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: open_wave_config [-quiet] [-verbose] [&lt;filename&gt;]
		/// <br/>
		/// <para>
		/// Open the specified Wave Config file (.wcfg) in the current simulation.<br/>
		/// Vivado simulator uses a simulation debug data model to allow users to debug HDL source files<br/>
		/// using source code stepping, breakpoints, conditions, and waveform viewing tools. The debug<br/>
		/// data model contains HDL object and scope names, and maps them to memory addresses to let<br/>
		/// you examine the changing values of signals, variables and constants during the simulation.<br/>
		/// The waveform database is separate from the Wave Config file that stores the waveform activity<br/>
		/// for the simulation. The Wave Config file contains just the list of wave objects (signals, dividers,<br/>
		/// groups, virtual buses) to display, and their display properties, plus markers. The waveform<br/>
		/// database (WDB) contains the event data, values changing over time, for all traced signals,<br/>
		/// whether displayed or not.<br/>
		/// A wave configuration object is created in the current simulation with the<br/>
		/// create_wave_config command. A Wave Config file is written to disk by the use of the<br/>
		/// save_wave_config command, and can be opened with the open_wave_config command.<br/>
		/// The open_wave_config command opens a Wave Config file and maps it to the data source in<br/>
		/// the current simulation.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// IMPORTANT! Any HDL objects that are specified in the Wave Config file that are not found in the current<br/>
		/// simulation will be ignored.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example opens the specified Wave Config file:<br/>
		/// open_wave_config testbench.wcfg<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1100<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="filename">
		/// <para>
		/// (Optional)<br/>
		/// the name of a WCFG file from which to create a new wave<br/>
		/// configuration and corresponding wave window<br/>
		/// </para>
		/// </param>
		/// <returns>The wave config opened</returns>
		public TTCL open_wave_config(bool? quiet = null, bool? verbose = null, TCLObject filename = null)
		{
			// TCL Syntax: open_wave_config [-quiet] [-verbose] [<filename>]
			_tcl.Entry(_builder.open_wave_config(quiet, verbose, filename));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Removes wave objects from the current wave configuration<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_wave [-of &lt;args&gt;] [-quiet] [-verbose] &lt;items&gt;...
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1274<br/>
		/// </para>
		/// </summary>
		/// <param name="items">(Required) wave objects to remove</param>
		/// <param name="of">
		/// <para>
		/// (Optional)<br/>
		/// the wave configuration, group, or virtual bus to search<br/>
		/// Default: the current wave configuration<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_wave(TCLObjectList items, TCLParameterList of = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_wave [-of <args>] [-quiet] [-verbose] <items>...
			_tcl.Entry(_builder.remove_wave(items, of, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Saves the specified or current wave configuration object to the given filename<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: save_wave_config [-object &lt;args&gt;] [-quiet] [-verbose] [&lt;filename&gt;]
		/// <br/>
		/// <para>
		/// Save the current or specified wave configuration object to a specified filename.<br/>
		/// If the wave configuration object has not been saved before, and does not have a FILE_PATH<br/>
		/// property value, the &lt;filename&gt; is required and the NAME of the wave configuration object will<br/>
		/// be changed to match the specified &lt;filename&gt;.<br/>
		/// If the specified wave configuration object has been previously saved, and has a FILE_PATH<br/>
		/// property, the object will be written to its current location, and the &lt;filename&gt; does not need to<br/>
		/// be specified.<br/>
		/// If the wave configuration object has a FILE_PATH property, but a different &lt;filename&gt; is<br/>
		/// specified, the wave configuration object will be saved to the new &lt;filename&gt;, and the object will<br/>
		/// be renamed to match the specified &lt;filename&gt;.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example saves the specified wave configuration object to a new filename:<br/>
		/// save_wave_config -object [get_wave_configs test.wcfg] \<br/>
		/// C:/Data/project/newTest<br/>
		/// Note: The wave config file will be assigned the .wcfg suffix since none is specified.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1578<br/>
		/// </para>
		/// </summary>
		/// <param name="object">
		/// <para>
		/// (Optional)<br/>
		/// The WCFG or wave configuration to save. Default: Current<br/>
		/// wave configuration<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="filename">(Optional) Filename to save the specified or current wave configuration object</param>
		/// <returns>The wave configuration object saved</returns>
		public TTCL save_wave_config(TCLParameterList @object = null, bool? quiet = null, bool? verbose = null, TCLObject filename = null)
		{
			// TCL Syntax: save_wave_config [-object <args>] [-quiet] [-verbose] [<filename>]
			_tcl.Entry(_builder.save_wave_config(@object, quiet, verbose, filename));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Display help for one or more topics<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: select_wave_objects [-quiet] [-verbose] &lt;items&gt;...
		/// <br/>
		/// <para>
		/// Selects the specified object in the Waveform window of the Vivado IDE. This command is for<br/>
		/// selecting displayed items in the Waveform window only, and is similar to the select_objects<br/>
		/// command in the Vivado IDE.<br/>
		/// Note: Use the get_hdl_objects command to select simulation objects in the open simulation, or<br/>
		/// current_sim.<br/>
		/// Unselect selected objects using the select_wave_objects command with an empty string:<br/>
		/// select_wave_objects ""<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example selects the specified site on the device:<br/>
		/// select_wave_objects {sys_clk_p sysc_clk_n}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1590<br/>
		/// </para>
		/// </summary>
		/// <param name="items">(Required) select waveform objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL select_wave_objects(TCLObjectList items, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: select_wave_objects [-quiet] [-verbose] <items>...
			_tcl.Entry(_builder.select_wave_objects(items, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
