#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class PropertyAndParameterCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public PropertyAndParameterCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// <para>
		/// Create property for class of objects(s)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_property [-description &lt;arg&gt;] [-type &lt;arg&gt;] [-enum_values &lt;args&gt;] [-default_value &lt;arg&gt;] [-file_types &lt;args&gt;] [-display_text &lt;arg&gt;] [-quiet] [-verbose] &lt;name&gt; &lt;class&gt;
		/// <br/>
		/// <para>
		/// Creates a new property of the &lt;type&gt; specified with the user-defined &lt;name&gt; for the specified<br/>
		/// &lt;class&gt; of objects. The property that is created can be assigned to an object of the specified class<br/>
		/// with the set_property command, but is not automatically associated with all objects of that<br/>
		/// class.<br/>
		/// The report_property -all command will not report the newly created property for an<br/>
		/// object of the specified class until the property has been assigned to that object.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example defines a property called PURPOSE for cell objects:<br/>
		/// create_property PURPOSE cell<br/>
		/// Note: Because the -type was not specified, the value will default to strings.<br/>
		/// The following example creates a pin property called COUNT which holds an Integer value:<br/>
		/// create_property -type int COUNT pin<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 347<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of property to create</param>
		/// <param name="class">
		/// <para>
		/// (Required)<br/>
		/// Object type to create property for; valid values are: design,<br/>
		/// net, cell, pin, port, pblock, interface, fileset<br/>
		/// </para>
		/// </param>
		/// <param name="description">(Optional) Description of property</param>
		/// <param name="type">
		/// <para>
		/// (Optional)<br/>
		/// Type of property to create; valid values are: string, int, long,<br/>
		/// double, bool, enum, file Default: string<br/>
		/// </para>
		/// </param>
		/// <param name="enum_values">(Optional) Enumeration values</param>
		/// <param name="default_value">(Optional) Default value of type string</param>
		/// <param name="file_types">(Optional) File type extensions (without the dot)</param>
		/// <param name="display_text">(Optional) Text to display when selecting the file in file browser</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The property that was created if success, "" if failure</returns>
		public TTCL create_property(String name, String @class, String description = null, String type = null, TCLParameterList enum_values = null, String default_value = null, TCLParameterList file_types = null, String display_text = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_property [-description <arg>] [-type <arg>] [-enum_values <args>] [-default_value <arg>] [-file_types <args>] [-display_text <arg>] [-quiet] [-verbose] <name> <class>
			_tcl.Entry(_builder.create_property(name, @class, description, type, enum_values, default_value, file_types, display_text, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Filter a list, resulting in new list<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: filter [-regexp] [-nocase] [-quiet] [-verbose] [&lt;objects&gt;] [&lt;filter&gt;]
		/// <br/>
		/// <para>
		/// Takes a list of objects, and returns a reduced list of objects that match the specified filter search<br/>
		/// pattern.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns a list of parts filtered for the specified speed grade:<br/>
		/// filter [get_parts] {speed == -3}<br/>
		/// The following example filters parts based according to speed grade -3 OR speed grade -2. All<br/>
		/// parts matching either speed grade will be returned.<br/>
		/// filter [get_parts] {speed == -3 || speed == -2}<br/>
		/// The following example uses regular expression and returns a list of VStatus ports in the design,<br/>
		/// with zero or more wildcards, and the numbers 0 to 9 appearing one or more times within square<br/>
		/// brackets:<br/>
		/// filter -regexp [get_ports] {NAME =~ VStatus.*\[[0-9]+\]}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 526<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Operators =~ and !~ use regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">(Optional) List of objects to filter</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <returns>new list</returns>
		public TTCL filter(bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, String objects = null, String filter = null)
		{
			// TCL Syntax: filter [-regexp] [-nocase] [-quiet] [-verbose] [<objects>] [<filter>]
			_tcl.Entry(_builder.filter(regexp, nocase, quiet, verbose, objects, filter));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a parameter value<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_param [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// This command gets the currently defined value for a specified tool parameter. These parameters<br/>
		/// are user-definable configuration settings that control various behaviors within the tool. Refer to<br/>
		/// report_param for a description of what each parameter configures or controls.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the current value of the MaxThreads parameter used for multi-threaded processes:<br/>
		/// get_param general.MaxThreads<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 858<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Parameter name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>parameter value</returns>
		public TTCL get_param(String name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_param [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.get_param(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get properties of object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_property [-min] [-max] [-quiet] [-verbose] &lt;name&gt; &lt;object&gt;
		/// <br/>
		/// <para>
		/// Gets the current value of the named property from the specified object or objects. If multiple<br/>
		/// objects are specified, a list of values is returned.<br/>
		/// If the property is not currently assigned to the object, or is assigned without a value, then the<br/>
		/// get_property command returns nothing, or the null string. If multiple objects are queried, the<br/>
		/// null string is added to the list of values returned.<br/>
		/// If multiple objects are passed to the get_property command, you can use the -min or -max<br/>
		/// options to return the smallest or greatest value of the property specified by name. This feature<br/>
		/// can be useful when setting timing constraints.<br/>
		/// RECOMMENDED: For numeric properties, the min/max determination is based on numeric values. For all<br/>
		/// other properties, the determination is based on string sorting.<br/>
		/// This command returns a value, or list of values, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the NAME property from the specified cell:<br/>
		/// get_property NAME [lindex [get_cells] 3]<br/>
		/// The following example returns the smallest PERIOD property from the specified clock objects:<br/>
		/// get_property -min PERIOD [get_clocks]<br/>
		/// This example demonstrates the string based sorting of the SITE property for the specified ports:<br/>
		/// get_property SITE [get_ports]<br/>
		/// IOB_X1Y75 IOB_X1Y76 IOB_X1Y98 IOB_X1Y125 IOB_X0Y94 IOB_X1Y95 IOB_X1Y96<br/>
		/// IOB_X1Y93 IOB_X1Y94<br/>
		/// get_property -min SITE [get_ports]<br/>
		/// IOB_X0Y94<br/>
		/// get_property -max SITE [get_ports]<br/>
		/// IOB_X1Y98<br/>
		/// Note: While IOB_X1Y125 is the largest site value on the port objects, the property value IOB_X1Y98 is<br/>
		/// returned because of the sorting of the property values as strings.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 901<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of property whose value is to be retrieved</param>
		/// <param name="object">(Required) Object to query for properties</param>
		/// <param name="min">(Optional) Return only the minimum value</param>
		/// <param name="max">(Optional) Return only the maximum value</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>property value</returns>
		public TTCL get_property(String name, String @object, bool? min = null, bool? max = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_property [-min] [-max] [-quiet] [-verbose] <name> <object>
			_tcl.Entry(_builder.get_property(name, @object, min, max, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get all parameter names<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: list_param [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Gets a list of user-definable configuration parameters. These parameters configure a variety of<br/>
		/// settings and behaviors of the tool. For more information on a specific parameter use the<br/>
		/// report_param command, which returns a description of the parameter as well as its current<br/>
		/// value.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns a list of all user-definable parameters:<br/>
		/// list_param<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1032<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list</returns>
		public TTCL list_param(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: list_param [-quiet] [-verbose]
			_tcl.Entry(_builder.list_param(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// List properties of object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: list_property [-class &lt;arg&gt;] [-regexp] [-quiet] [-verbose] [&lt;object&gt;] [&lt;pattern&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of all properties on a specified object or class.<br/>
		/// Note: report_property also returns a list of properties on an object or class of objects, but also reports<br/>
		/// the property type and property value.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns all properties of the specified CELL object:<br/>
		/// list_property [get_cells cpuEngine]<br/>
		/// The following example returns the properties matching the specified search pattern from the BEL<br/>
		/// class of objects:<br/>
		/// list_property -class bel *NUM*<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1034<br/>
		/// </para>
		/// </summary>
		/// <param name="class">(Optional) Object type to query for properties. Ignored if object is specified.</param>
		/// <param name="regexp">(Optional) Pattern is treated as a regular expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="object">(Optional) Object to query for properties</param>
		/// <param name="pattern">(Optional) Pattern to match properties against Default: *</param>
		/// <returns>list of property names</returns>
		public TTCL list_property(String @class = null, bool? regexp = null, bool? quiet = null, bool? verbose = null, String @object = null, String pattern = null)
		{
			// TCL Syntax: list_property [-class <arg>] [-regexp] [-quiet] [-verbose] [<object>] [<pattern>]
			_tcl.Entry(_builder.list_property(@class, regexp, quiet, verbose, @object, pattern));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// List legal property values of object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: list_property_value [-default] [-class &lt;arg&gt;] [-quiet] [-verbose] &lt;name&gt; [&lt;object&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of valid values for an enumerated type property of either a class of objects or a<br/>
		/// specific object.<br/>
		/// Note: The command cannot be used to return valid values for properties other than Enum properties. The<br/>
		/// report_property command will return the type of property to help you identify Enum properties.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the list of valid values for the KEEP_HIERARCHY property from<br/>
		/// cell objects:<br/>
		/// list_property_value KEEP_HIERARCHY -class cell<br/>
		/// The following example returns the same result, but uses an actual cell object in place of the<br/>
		/// general cell class:<br/>
		/// list_property_value KEEP_HIERARCHY [get_cells cpuEngine]<br/>
		/// The following example returns the default value for the specified property by using the current<br/>
		/// design as a representative of the design class:<br/>
		/// list_property_value -default BITSTREAM.GENERAL.COMPRESS [current_design]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1036<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of property whose legal values is to be retrieved</param>
		/// <param name="default">(Optional) Show only the default value.</param>
		/// <param name="class">
		/// <para>
		/// (Optional)<br/>
		/// Object type to query for legal property values. Ignored if<br/>
		/// object is specified.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="object">(Optional) Object to query for legal properties values</param>
		/// <returns>list of property values</returns>
		public TTCL list_property_value(String name, bool? @default = null, String @class = null, bool? quiet = null, bool? verbose = null, String @object = null)
		{
			// TCL Syntax: list_property_value [-default] [-class <arg>] [-quiet] [-verbose] <name> [<object>]
			_tcl.Entry(_builder.list_property_value(name, @default, @class, quiet, verbose, @object));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get information about all parameters<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_param [-file &lt;arg&gt;] [-append] [-non_default] [-return_string] [-quiet] [-verbose] [&lt;pattern&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of all user-definable parameters, the current value, and a description of what the<br/>
		/// parameter configures or controls.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the name, value, and description of all user-definable parameters:<br/>
		/// report_param<br/>
		/// The following example returns the name, value, and description of user-definable parameters<br/>
		/// that match the specified search pattern:<br/>
		/// report_param *coll*<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1399<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="non_default">(Optional) Report only params that are set to a non default value</param>
		/// <param name="return_string">(Optional) Return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="pattern">(Optional) Display params matching pattern Default: *</param>
		/// <returns>param report</returns>
		public TTCL report_param(String file = null, bool? append = null, bool? non_default = null, bool? return_string = null, bool? quiet = null, bool? verbose = null, String pattern = null)
		{
			// TCL Syntax: report_param [-file <arg>] [-append] [-non_default] [-return_string] [-quiet] [-verbose] [<pattern>]
			_tcl.Entry(_builder.report_param(file, append, non_default, return_string, quiet, verbose, pattern));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report properties of object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_property [-all] [-class &lt;arg&gt;] [-return_string] [-file &lt;arg&gt;] [-append] [-regexp] [-quiet] [-verbose] [&lt;object&gt;] [&lt;pattern&gt;]
		/// <br/>
		/// <para>
		/// Gets the property name, property type, and property value for all of the properties on a specified<br/>
		/// object, or class of objects.<br/>
		/// Note: list_property also returns a list of all properties on an object, but does not include the property<br/>
		/// type or value.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// You can specify objects for report_property using the get_* series of commands to get a<br/>
		/// specific object. You can use the lindex command to return a specific object from a list of<br/>
		/// objects:<br/>
		/// report_property [lindex [get_cells] 0]<br/>
		/// However, if you are looking for the properties on a class of objects, you should use the -<br/>
		/// classoption instead of an actual object.<br/>
		/// This command returns a report of properties on the object, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns all properties of the specified object:<br/>
		/// report_property -all [get_cells cpuEngine]<br/>
		/// The following example returns the properties of the specified class of objects, rather than an<br/>
		/// actual object:<br/>
		/// report_property -class bel<br/>
		/// The following example returns properties on the current hw_device that match the specified<br/>
		/// pattern, specified as a regular expression:<br/>
		/// report_property [current_hw_device] -regexp .*PROG.*<br/>
		/// To determine which properties are available for the different design objects supported by the<br/>
		/// tool, you can use multiple report_property commands in sequence. The following example<br/>
		/// returns all properties of the specified current objects:<br/>
		/// report_property -all [current_project]<br/>
		/// report_property -all [current_fileset]<br/>
		/// report_property -all [current_design]<br/>
		/// report_property -all [current_run]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1415<br/>
		/// </para>
		/// </summary>
		/// <param name="all">(Optional) Report all properties of object even if not set</param>
		/// <param name="class">(Optional) Object type to query for properties. Not valid with &lt;object&gt;</param>
		/// <param name="return_string">
		/// <para>
		/// (Optional)<br/>
		/// Set the result of running report_property in the Tcl<br/>
		/// interpreter's result variable<br/>
		/// </para>
		/// </param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output result to. Send output to console if -file<br/>
		/// is not used<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="regexp">(Optional) Pattern is treated as a regular expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="object">(Optional) Object to query for properties</param>
		/// <param name="pattern">(Optional) Pattern to match properties against Default: *</param>
		/// <returns>property report</returns>
		public TTCL report_property(bool? all = null, String @class = null, bool? return_string = null, String file = null, bool? append = null, bool? regexp = null, bool? quiet = null, bool? verbose = null, String @object = null, String pattern = null)
		{
			// TCL Syntax: report_property [-all] [-class <arg>] [-return_string] [-file <arg>] [-append] [-regexp] [-quiet] [-verbose] [<object>] [<pattern>]
			_tcl.Entry(_builder.report_property(all, @class, return_string, file, append, regexp, quiet, verbose, @object, pattern));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Reset a parameter<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_param [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Restores a user-definable configuration parameter that has been changed with the set_param<br/>
		/// command to its default value.<br/>
		/// You can use the report_param command to see which parameters are currently defined.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example restores the tcl.statsThreshold parameter to its default value:<br/>
		/// reset_param tcl.statsThreshold<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1507<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Parameter name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>original value</returns>
		public TTCL reset_param(String name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_param [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.reset_param(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Reset property on object(s)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_property [-quiet] [-verbose] &lt;property_name&gt; &lt;objects&gt;...
		/// <br/>
		/// <para>
		/// Restores the specified property to its default value on the specified object or objects. If no<br/>
		/// default is defined for the property, the property is unassigned on the specified object.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets the DOB_REG property on the specified Block RAM, and then resets<br/>
		/// the property:<br/>
		/// set_property DOB_REG 1 [get_cells usbEngine1/usbEngineSRAM/<br/>
		/// snoopyRam_reg_19]<br/>
		/// reset_property DOB_REG [get_cells usbEngine1/usbEngineSRAM/snoopyRam_reg_19]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1511<br/>
		/// </para>
		/// </summary>
		/// <param name="property_name">(Required) Name of property to reset</param>
		/// <param name="objects">(Required) Objects to set properties</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The value that was set if success, "" if failure</returns>
		public TTCL reset_property(String property_name, TCLParameterList objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_property [-quiet] [-verbose] <property_name> <objects>...
			_tcl.Entry(_builder.reset_property(property_name, objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set a parameter value<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_param [-quiet] [-verbose] &lt;name&gt; &lt;value&gt;
		/// <br/>
		/// <para>
		/// Sets the value of a user-definable configuration parameter. These parameters configure and<br/>
		/// control various behaviors of the tool. Refer to report_param for a description of currently<br/>
		/// defined parameters.<br/>
		/// As an example, a specific param that can be defined is the general.maxThreads parameter<br/>
		/// for the Vivado Design Suite. On multiprocessor systems, the Vivado Design Suite use multi-threading to speed up certain processes, including DRC reporting, static timing analysis,<br/>
		/// placement, and routing. A default limit applies to all tasks and is based on the operating system.<br/>
		/// For Windows systems, the default is 2; for Linux systems the default is 8. The limit can be<br/>
		/// changed as follows:<br/>
		/// set_param general.maxThreads &lt;value&gt;<br/>
		/// Where &lt;value&gt; is an integer from 1 to 8, inclusive.<br/>
		/// The maximum number of simultaneous threads that can be used also varies by the task being<br/>
		/// run. You can change the maxThreads parameter prior to running these processes. The<br/>
		/// maximum number of threads for specific Tcl commands are:<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • phys_opt_design: 8<br/>
		/// • place_design: 8<br/>
		/// • report_drc: 8<br/>
		/// • report_timing and report_timing_summary: 8<br/>
		/// • route_design: 8<br/>
		/// • synth_design: 4<br/>
		/// You can use the reset_param command to restore any parameter that has been modified back<br/>
		/// to its default setting.<br/>
		/// Note: Setting a specified parameter value to -1 will disable the feature.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example sets the parameter defining how many threads to run for multi-threaded<br/>
		/// processes, including Placement, Routing, and Timing Analysis:<br/>
		/// set_param general.maxThreads 4<br/>
		/// Note: The Vivado tool supports between 1 to 8 threads. Use get_param to determine the current setting.<br/>
		/// The following example sets a new default value for message limit:<br/>
		/// set_param messaging.defaultLimit 1000<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1672<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Parameter name</param>
		/// <param name="value">(Required) Parameter value</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>newly set parameter value</returns>
		public TTCL set_param(String name, String value, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_param [-quiet] [-verbose] <name> <value>
			_tcl.Entry(_builder.set_param(name, value, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Sets the part on the current project. If no project is open, then a diskless project is created.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_part [-quiet] [-verbose] &lt;part&gt;
		/// <br/>
		/// <para>
		/// Change the part used by the current project for subsequent elaboration, synthesis,<br/>
		/// implementation, and analysis.<br/>
		/// TIP: The part is changed for the current project only, and not for the in-memory design. You can change<br/>
		/// the speed grade of the device in the in-memory design for timing analysis using the set_speed_grade<br/>
		/// command. You can change the part used when opening an existing design checkpoint using the -part<br/>
		/// option of the open_checkpoint or read_checkpoint commands.<br/>
		/// This command is provided to let you change the part for the in-memory project of non-project<br/>
		/// based designs, and does not support project-based designs. For a project-based design set the<br/>
		/// PART property on the project as follows:<br/>
		/// set_property PART xc7vx485tffg1158-2 [current_project]<br/>
		/// Use the get_parts command to get a list of the available parts.<br/>
		/// The set_part command creates an in-memory project for a non-project based design, or<br/>
		/// assigns the part to the existing in-memory project.<br/>
		/// Note: For a discussion of Project Mode and Non-Project Mode refer to the Vivado Design Suite User Guide:<br/>
		/// Design Flows Overview (UG892).<br/>
		/// This command returns the part that the in-memory project is set to use, or returns an error if it<br/>
		/// fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1675<br/>
		/// </para>
		/// </summary>
		/// <param name="part">(Required) Set current project's part to this part.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_part(String part, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_part [-quiet] [-verbose] <part>
			_tcl.Entry(_builder.set_part(part, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set property on object(s)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_property [-dict &lt;args&gt;] [-quiet] [-verbose] &lt;name&gt; &lt;value&gt; &lt;objects&gt;...
		/// <br/>
		/// <para>
		/// Assigns the defined property &lt;name&gt; and &lt;value&gt; to the specified &lt;objects&gt;.<br/>
		/// This command can be used to define any property on an object in the design. Each object has a<br/>
		/// set of predefined properties that have expected values, or a range of values. The set_property<br/>
		/// command can be used to define the values for these properties. To determine the defined set of<br/>
		/// properties on an object, use report_property, list_property, or<br/>
		/// list_property_values.<br/>
		/// You can also define custom properties for an object, by specifying a unique &lt;name&gt; and &lt;value&gt;<br/>
		/// pair for the object. If an object has custom properties, these will also be reported by the<br/>
		/// report_property and list_property commands.<br/>
		/// This command returns nothing if successful, and an error if it fails.<br/>
		/// TIP: You can use the get_property command to validate any properties that have been set on an<br/>
		/// object.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// Create a user-defined boolean property, TRUTH, for cell objects, and set the property on a cell:<br/>
		/// create_property -type bool truth cell<br/>
		/// set_property truth false [lindex [get_cells] 1]<br/>
		/// Use the -dict option to specify multiple properties at one time on the current design:<br/>
		/// set_property -dict "POST_CRC enable POST_CRC_ACTION correct_and_continue"<br/>
		/// \<br/>
		/// [current_design]<br/>
		/// The following example sets the TOP property of the current fileset to define the top module of<br/>
		/// the project:<br/>
		/// set_property top fftTop [current_fileset]<br/>
		/// set_property top_file {C:/Data/sources/fftTop.v} [current_fileset]<br/>
		/// Note: Defining the top module requires the TOP property to be set to the desired hierarchical block in the<br/>
		/// source fileset of the current project. In the preceding example TOP is the property name, fftTop is the<br/>
		/// value, and current_fileset is the object. In addition, the TOP_FILE property should be defined to point to<br/>
		/// the data source for the top module.<br/>
		/// This example shows how to set a property value that includes the dash character, '-'. The dash<br/>
		/// can cause the tool to interpret the value as a new command argument, rather than part of the<br/>
		/// value being specified, and will cause an error as shown. In this case, you must use the explicit<br/>
		/// form of the positional arguments in the set_property command:<br/>
		/// set_property {XELAB.MORE_OPTIONS} {-pulse_e_style ondetect} \<br/>
		/// [get_filesets sim_1]<br/>
		/// ERROR: [Common 17-170] Unknown option '-pulse_e_style ondetect',<br/>
		/// please type 'set_property -help' for usage info.<br/>
		/// set_property -name {XELAB.MORE_OPTIONS} -value {-pulse_e_style ondetect}\<br/>
		/// -objects [get_filesets sim_1]<br/>
		/// The following example sets the internal VREF property value for the specified IO Bank:<br/>
		/// set_property internal_vref {0.75} [get_iobanks 0]<br/>
		/// The following example defines a DCI Cascade by setting the DCI_CASCADE property for the<br/>
		/// specified IO Bank:<br/>
		/// set_property DCI_CASCADE {14} [get_iobanks 0 ]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example configures the synth_1 run, setting options for Vivado Synthesis 2013,<br/>
		/// and then launches the synthesis run:<br/>
		/// set_property flow {Vivado Synthesis 2016} \<br/>
		/// [get_runs synth_1]<br/>
		/// set_property STEPS.SYNTH_DESIGN.ARGS.GATED_CLOCK_CONVERSION on \<br/>
		/// [get_runs synth_1]<br/>
		/// set_property STEPS.SYNTH_DESIGN.ARGS.FSM_EXTRACTION one_hot \<br/>
		/// [get_runs synth_1]<br/>
		/// launch_runs synth_1<br/>
		/// This example is the same as the prior example, except that it uses the -dict option to set all the<br/>
		/// properties on the synthesis run in a single set_property command:<br/>
		/// set_property -dict [ list flow {Vivado Synthesis 2016} \<br/>
		/// STEPS.SYNTH_DESIGN.ARGS.GATED_CLOCK_CONVERSION on \<br/>
		/// STEPS.SYNTH_DESIGN.ARGS.FSM_EXTRACTION \<br/>
		/// one_hot ] [get_runs synth_1]<br/>
		/// launch_runs synth_1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1682<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of property to set. Not valid with -dict option</param>
		/// <param name="value">(Required) Value of property to set. Not valid with -dict option</param>
		/// <param name="objects">(Required) Objects to set properties on</param>
		/// <param name="dict">(Optional) list of name/value pairs of properties to set</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_property(String name, String value, TCLParameterList objects, TCLParameterList dict = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_property [-dict <args>] [-quiet] [-verbose] <name> <value> <objects>...
			_tcl.Entry(_builder.set_property(name, value, objects, dict, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
