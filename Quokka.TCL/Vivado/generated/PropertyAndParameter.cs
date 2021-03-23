// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
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
		/// Create property for class of objects(s)
		///
		///
		/// TCL Syntax: create_property [-description <arg>] [-type <arg>] [-enum_values <args>] [-default_value <arg>] [-file_types <args>] [-display_text <arg>] [-quiet] [-verbose] <name> <class>
		///
		/// Creates a new property of the <type> specified with the user-defined <name> for the specified
		/// <class> of objects. The property that is created can be assigned to an object of the specified class
		/// with the set_property command, but is not automatically associated with all objects of that
		/// class.
		/// The report_property -all command will not report the newly created property for an
		/// object of the specified class until the property has been assigned to that object.
		///
		/// The following example defines a property called PURPOSE for cell objects:
		/// create_property PURPOSE cell
		/// Note: Because the -type was not specified, the value will default to strings.
		/// The following example creates a pin property called COUNT which holds an Integer value:
		/// create_property -type int COUNT pin
		///
		/// See ug835-vivado-tcl-commands.pdf, page 337
		/// </summary>
		/// <param name="name">(Required) Name of property to create</param>
		/// <param name="@class">
		/// (Required)
		/// Object type to create property for; valid values are: design,
		/// net, cell, pin, port, pblock, interface, fileset
		/// </param>
		/// <param name="description">(Optional) Description of property</param>
		/// <param name="type">
		/// (Optional)
		/// Type of property to create; valid values are: string, int, long,
		/// double, bool, enum, file Default: string
		/// </param>
		/// <param name="enum_values">(Optional) Enumeration values</param>
		/// <param name="default_value">(Optional) Default value of type string</param>
		/// <param name="file_types">(Optional) File type extensions (without the dot)</param>
		/// <param name="display_text">(Optional) Text to display when selecting the file in file browser</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The property that was created if success, "" if failure</returns>
		public TTCL create_property(string name, string @class, string description = null, string type = null, string enum_values = null, string default_value = null, string file_types = null, string display_text = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_property [-description <arg>] [-type <arg>] [-enum_values <args>] [-default_value <arg>] [-file_types <args>] [-display_text <arg>] [-quiet] [-verbose] <name> <class>
			_tcl.Entry(_builder.create_property(name, @class, description, type, enum_values, default_value, file_types, display_text, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Filter a list, resulting in new list
		///
		///
		/// TCL Syntax: filter [-regexp] [-nocase] [-quiet] [-verbose] [<objects>] [<filter>]
		///
		/// Takes a list of objects, and returns a reduced list of objects that match the specified filter search
		/// pattern.
		///
		/// The following example returns a list of parts filtered for the specified speed grade:
		/// filter [get_parts] {speed == -3}
		/// The following example filters parts based according to speed grade -3 OR speed grade -2. All
		/// parts matching either speed grade will be returned.
		/// filter [get_parts] {speed == -3 || speed == -2}
		/// The following example uses regular expression and returns a list of VStatus ports in the design,
		/// with zero or more wildcards, and the numbers 0 to 9 appearing one or more times within square
		/// brackets:
		/// filter -regexp [get_ports] {NAME =~ VStatus.*\[[0-9]+\]}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 515
		/// </summary>
		/// <param name="regexp">(Optional) Operators =~ and !~ use regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">(Optional) List of objects to filter</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <returns>new list</returns>
		public TTCL filter(bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, string objects = null, string filter = null)
		{
			// TCL Syntax: filter [-regexp] [-nocase] [-quiet] [-verbose] [<objects>] [<filter>]
			_tcl.Entry(_builder.filter(regexp, nocase, quiet, verbose, objects, filter));
			return _tcl;
		}
		/// <summary>
		/// Get a parameter value
		///
		///
		/// TCL Syntax: get_param [-quiet] [-verbose] <name>
		///
		/// This command gets the currently defined value for a specified tool parameter. These parameters
		/// are user-definable configuration settings that control various behaviors within the tool. Refer to
		/// report_param for a description of what each parameter configures or controls.
		///
		/// The following example returns the current value of the MaxThreads parameter used for multi￾threaded processes:
		/// get_param general.MaxThreads
		///
		/// See ug835-vivado-tcl-commands.pdf, page 838
		/// </summary>
		/// <param name="name">(Required) Parameter name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>parameter value</returns>
		public TTCL get_param(string name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_param [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.get_param(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get properties of object
		///
		///
		/// TCL Syntax: get_property [-min] [-max] [-quiet] [-verbose] <name> <object>
		///
		/// Gets the current value of the named property from the specified object or objects. If multiple
		/// objects are specified, a list of values is returned.
		/// If the property is not currently assigned to the object, or is assigned without a value, then the
		/// get_property command returns nothing, or the null string. If multiple objects are queried, the
		/// null string is added to the list of values returned.
		/// If multiple objects are passed to the get_property command, you can use the -min or -max
		/// options to return the smallest or greatest value of the property specified by name. This feature
		/// can be useful when setting timing constraints.
		/// RECOMMENDED: For numeric properties, the min/max determination is based on numeric values. For all
		/// other properties, the determination is based on string sorting.
		/// This command returns a value, or list of values, or returns an error if it fails.
		///
		/// The following example gets the NAME property from the specified cell:
		/// get_property NAME [lindex [get_cells] 3]
		/// The following example returns the smallest PERIOD property from the specified clock objects:
		/// get_property -min PERIOD [get_clocks]
		/// This example demonstrates the string based sorting of the SITE property for the specified ports:
		/// get_property SITE [get_ports]
		/// IOB_X1Y75 IOB_X1Y76 IOB_X1Y98 IOB_X1Y125 IOB_X0Y94 IOB_X1Y95 IOB_X1Y96
		/// IOB_X1Y93 IOB_X1Y94
		/// get_property -min SITE [get_ports]
		/// IOB_X0Y94
		/// get_property -max SITE [get_ports]
		/// IOB_X1Y98
		/// Note: While IOB_X1Y125 is the largest site value on the port objects, the property value IOB_X1Y98 is
		/// returned because of the sorting of the property values as strings.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 880
		/// </summary>
		/// <param name="name">(Required) Name of property whose value is to be retrieved</param>
		/// <param name="@object">(Required) Object to query for properties</param>
		/// <param name="min">(Optional) Return only the minimum value</param>
		/// <param name="max">(Optional) Return only the maximum value</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>property value</returns>
		public TTCL get_property(string name, string @object, bool? min = null, bool? max = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_property [-min] [-max] [-quiet] [-verbose] <name> <object>
			_tcl.Entry(_builder.get_property(name, @object, min, max, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get all parameter names
		///
		///
		/// TCL Syntax: list_param [-quiet] [-verbose]
		///
		/// Gets a list of user-definable configuration parameters. These parameters configure a variety of
		/// settings and behaviors of the tool. For more information on a specific parameter use the
		/// report_param command, which returns a description of the parameter as well as its current
		/// value.
		///
		/// The following example returns a list of all user-definable parameters:
		/// list_param
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1009
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
		/// List properties of object
		///
		///
		/// TCL Syntax: list_property [-class <arg>] [-regexp] [-quiet] [-verbose] [<object>] [<pattern>]
		///
		/// Gets a list of all properties on a specified object or class.
		/// Note: report_property also returns a list of properties on an object or class of objects, but also reports
		/// the property type and property value.
		///
		/// The following example returns all properties of the specified CELL object:
		/// list_property [get_cells cpuEngine]
		/// The following example returns the properties matching the specified search pattern from the BEL
		/// class of objects:
		/// list_property -class bel *NUM*
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1011
		/// </summary>
		/// <param name="@class">(Optional) Object type to query for properties. Ignored if object is specified.</param>
		/// <param name="regexp">(Optional) Pattern is treated as a regular expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="@object">(Optional) Object to query for properties</param>
		/// <param name="pattern">(Optional) Pattern to match properties against Default: *</param>
		/// <returns>list of property names</returns>
		public TTCL list_property(string @class = null, bool? regexp = null, bool? quiet = null, bool? verbose = null, string @object = null, string pattern = null)
		{
			// TCL Syntax: list_property [-class <arg>] [-regexp] [-quiet] [-verbose] [<object>] [<pattern>]
			_tcl.Entry(_builder.list_property(@class, regexp, quiet, verbose, @object, pattern));
			return _tcl;
		}
		/// <summary>
		/// List legal property values of object
		///
		///
		/// TCL Syntax: list_property_value [-default] [-class <arg>] [-quiet] [-verbose] <name> [<object>]
		///
		/// Gets a list of valid values for an enumerated type property of either a class of objects or a
		/// specific object.
		/// Note: The command cannot be used to return valid values for properties other than Enum properties. The
		/// report_property command will return the type of property to help you identify Enum properties.
		///
		/// The following example returns the list of valid values for the KEEP_HIERARCHY property from
		/// cell objects:
		/// list_property_value KEEP_HIERARCHY -class cell
		/// The following example returns the same result, but uses an actual cell object in place of the
		/// general cell class:
		/// list_property_value KEEP_HIERARCHY [get_cells cpuEngine]
		/// The following example returns the default value for the specified property by using the current
		/// design as a representative of the design class:
		/// list_property_value -default BITSTREAM.GENERAL.COMPRESS [current_design]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1013
		/// </summary>
		/// <param name="name">(Required) Name of property whose legal values is to be retrieved</param>
		/// <param name="@default">(Optional) Show only the default value.</param>
		/// <param name="@class">
		/// (Optional)
		/// Object type to query for legal property values. Ignored if
		/// object is specified.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="@object">(Optional) Object to query for legal properties values</param>
		/// <returns>list of property values</returns>
		public TTCL list_property_value(string name, bool? @default = null, string @class = null, bool? quiet = null, bool? verbose = null, string @object = null)
		{
			// TCL Syntax: list_property_value [-default] [-class <arg>] [-quiet] [-verbose] <name> [<object>]
			_tcl.Entry(_builder.list_property_value(name, @default, @class, quiet, verbose, @object));
			return _tcl;
		}
		/// <summary>
		/// Get information about all parameters
		///
		///
		/// TCL Syntax: report_param [-file <arg>] [-append] [-non_default] [-return_string] [-quiet] [-verbose] [<pattern>]
		///
		/// Gets a list of all user-definable parameters, the current value, and a description of what the
		/// parameter configures or controls.
		///
		/// The following example returns the name, value, and description of all user-definable parameters:
		/// report_param
		/// The following example returns the name, value, and description of user-definable parameters
		/// that match the specified search pattern:
		/// report_param *coll*
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1368
		/// </summary>
		/// <param name="file">
		/// (Optional)
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="non_default">(Optional) Report only params that are set to a non default value</param>
		/// <param name="return_string">(Optional) Return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="pattern">(Optional) Display params matching pattern Default: *</param>
		/// <returns>param report</returns>
		public TTCL report_param(string file = null, bool? append = null, bool? non_default = null, bool? return_string = null, bool? quiet = null, bool? verbose = null, string pattern = null)
		{
			// TCL Syntax: report_param [-file <arg>] [-append] [-non_default] [-return_string] [-quiet] [-verbose] [<pattern>]
			_tcl.Entry(_builder.report_param(file, append, non_default, return_string, quiet, verbose, pattern));
			return _tcl;
		}
		/// <summary>
		/// Report properties of object
		///
		///
		/// TCL Syntax: report_property [-all] [-class <arg>] [-return_string] [-file <arg>] [-append] [-regexp] [-quiet] [-verbose] [<object>] [<pattern>]
		///
		/// Gets the property name, property type, and property value for all of the properties on a specified
		/// object, or class of objects.
		/// Note: list_property also returns a list of all properties on an object, but does not include the property
		/// type or value.
		/// You can specify objects for report_property using the get_* series of commands to get a
		/// specific object. You can use the lindex command to return a specific object from a list of
		/// objects:
		/// report_property [lindex [get_cells] 0]
		/// However, if you are looking for the properties on a class of objects, you should use the -
		/// classoption instead of an actual object.
		/// This command returns a report of properties on the object, or returns an error if it fails.
		///
		/// The following example returns all properties of the specified object:
		/// report_property -all [get_cells cpuEngine]
		/// The following example returns the properties of the specified class of objects, rather than an
		/// actual object:
		/// report_property -class bel
		/// The following example returns properties on the current hw_device that match the specified
		/// pattern, specified as a regular expression:
		/// report_property [current_hw_device] -regexp .*PROG.*
		/// To determine which properties are available for the different design objects supported by the
		/// tool, you can use multiple report_property commands in sequence. The following example
		/// returns all properties of the specified current objects:
		/// report_property -all [current_project]
		/// report_property -all [current_fileset]
		/// report_property -all [current_design]
		/// report_property -all [current_run]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1384
		/// </summary>
		/// <param name="all">(Optional) Report all properties of object even if not set</param>
		/// <param name="@class">(Optional) Object type to query for properties. Not valid with <object></param>
		/// <param name="return_string">
		/// (Optional)
		/// Set the result of running report_property in the Tcl
		/// interpreter's result variable
		/// </param>
		/// <param name="file">
		/// (Optional)
		/// Filename to output result to. Send output to console if -file
		/// is not used
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="regexp">(Optional) Pattern is treated as a regular expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="@object">(Optional) Object to query for properties</param>
		/// <param name="pattern">(Optional) Pattern to match properties against Default: *</param>
		/// <returns>property report</returns>
		public TTCL report_property(bool? all = null, string @class = null, bool? return_string = null, string file = null, bool? append = null, bool? regexp = null, bool? quiet = null, bool? verbose = null, string @object = null, string pattern = null)
		{
			// TCL Syntax: report_property [-all] [-class <arg>] [-return_string] [-file <arg>] [-append] [-regexp] [-quiet] [-verbose] [<object>] [<pattern>]
			_tcl.Entry(_builder.report_property(all, @class, return_string, file, append, regexp, quiet, verbose, @object, pattern));
			return _tcl;
		}
		/// <summary>
		/// Reset a parameter
		///
		///
		/// TCL Syntax: reset_param [-quiet] [-verbose] <name>
		///
		/// Restores a user-definable configuration parameter that has been changed with the set_param
		/// command to its default value.
		/// You can use the report_param command to see which parameters are currently defined.
		///
		/// The following example restores the tcl.statsThreshold parameter to its default value:
		/// reset_param tcl.statsThreshold
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1474
		/// </summary>
		/// <param name="name">(Required) Parameter name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>original value</returns>
		public TTCL reset_param(string name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_param [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.reset_param(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Reset property on object(s)
		///
		///
		/// TCL Syntax: reset_property [-quiet] [-verbose] <property_name> <objects>...
		///
		/// Restores the specified property to its default value on the specified object or objects. If no
		/// default is defined for the property, the property is unassigned on the specified object.
		///
		/// The following example sets the DOB_REG property on the specified Block RAM, and then resets
		/// the property:
		/// set_property DOB_REG 1 [get_cells usbEngine1/usbEngineSRAM/
		/// snoopyRam_reg_19]
		/// reset_property DOB_REG [get_cells usbEngine1/usbEngineSRAM/
		/// snoopyRam_reg_19]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1478
		/// </summary>
		/// <param name="property_name">(Required) Name of property to reset</param>
		/// <param name="objects">(Required) Objects to set properties</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The value that was set if success, "" if failure</returns>
		public TTCL reset_property(string property_name, string objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_property [-quiet] [-verbose] <property_name> <objects>...
			_tcl.Entry(_builder.reset_property(property_name, objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Set a parameter value
		///
		///
		/// TCL Syntax: set_param [-quiet] [-verbose] <name> <value>
		///
		/// Sets the value of a user-definable configuration parameter. These parameters configure and
		/// control various behaviors of the tool. Refer to report_param for a description of currently
		/// defined parameters.
		/// As an example, a specific param that can be defined is the general.maxThreads parameter
		/// for the Vivado Design Suite. On multiprocessor systems, the Vivado Design Suite use multi￾threading to speed up certain processes, including DRC reporting, static timing analysis,
		/// placement, and routing. A default limit applies to all tasks and is based on the operating system.
		/// For Windows systems, the default is 2; for Linux systems the default is 8. The limit can be
		/// changed as follows:
		/// set_param general.maxThreads <value>
		/// Where <value> is an integer from 1 to 8, inclusive.
		/// The maximum number of simultaneous threads that can be used also varies by the task being
		/// run. You can change the maxThreads parameter prior to running these processes. The
		/// maximum number of threads for specific Tcl commands are:
		/// • phys_opt_design: 8
		/// • place_design: 8
		/// • report_drc: 8
		/// • report_timing and report_timing_summary: 8
		/// • route_design: 8
		/// • synth_design: 4
		/// You can use the reset_param command to restore any parameter that has been modified back
		/// to its default setting.
		/// Note: Setting a specified parameter value to -1 will disable the feature.
		///
		/// The following example sets the parameter defining how many threads to run for multi-threaded
		/// processes, including Placement, Routing, and Timing Analysis:
		/// set_param general.maxThreads 4
		/// Note: The Vivado tool supports between 1 to 8 threads. Use get_param to determine the current setting.
		/// The following example sets a new default value for message limit:
		/// set_param messaging.defaultLimit 1000
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1639
		/// </summary>
		/// <param name="name">(Required) Parameter name</param>
		/// <param name="value">(Required) Parameter value</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>newly set parameter value</returns>
		public TTCL set_param(string name, string value, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_param [-quiet] [-verbose] <name> <value>
			_tcl.Entry(_builder.set_param(name, value, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Sets the part on the current project. If no project is open, then a diskless project is created.
		///
		///
		/// TCL Syntax: set_part [-quiet] [-verbose] <part>
		///
		/// Change the part used by the current project for subsequent elaboration, synthesis,
		/// implementation, and analysis.
		/// TIP: The part is changed for the current project only, and not for the in-memory design. You can change the
		/// speed grade of the device in the in-memory design for timing analysis using the set_speed_grade
		/// command. You can change the part used when opening an existing design checkpoint using the -part option
		/// of the open_checkpoint or read_checkpoint commands.
		/// This command is provided to let you change the part for the in-memory project of non-project
		/// based designs, and does not support project-based designs. For a project-based design set the
		/// PART property on the project as follows:
		/// set_property PART xc7vx485tffg1158-2 [current_project]
		/// Use the get_parts command to get a list of the available parts.
		/// The set_part command creates an in-memory project for a non-project based design, or
		/// assigns the part to the existing in-memory project.
		/// Note: For a discussion of Project Mode and Non-Project Mode refer to the Vivado Design Suite User Guide:
		/// Design Flows Overview (UG892).
		/// This command returns the part that the in-memory project is set to use, or returns an error if it
		/// fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1642
		/// </summary>
		/// <param name="part">(Required) Set current project's part to this part.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_part(string part, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_part [-quiet] [-verbose] <part>
			_tcl.Entry(_builder.set_part(part, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Set property on object(s)
		///
		///
		/// TCL Syntax: set_property [-dict <args>] [-quiet] [-verbose] <name> <value> <objects>...
		///
		/// Assigns the defined property <name> and <value> to the specified <objects>.
		/// This command can be used to define any property on an object in the design. Each object has a
		/// set of predefined properties that have expected values, or a range of values. The set_property
		/// command can be used to define the values for these properties. To determine the defined set of
		/// properties on an object, use report_property, list_property, or
		/// list_property_values.
		/// You can also define custom properties for an object, by specifying a unique <name> and <value>
		/// pair for the object. If an object has custom properties, these will also be reported by the
		/// report_property and list_property commands.
		/// This command returns nothing if successful, and an error if it fails.
		/// TIP: You can use the get_property command to validate any properties that have been set on an object.
		///
		/// Create a user-defined boolean property, TRUTH, for cell objects, and set the property on a cell:
		/// create_property -type bool truth cell
		/// set_property truth false [lindex [get_cells] 1]
		/// Use the -dict option to specify multiple properties at one time on the current design:
		/// set_property -dict "POST_CRC enable POST_CRC_ACTION correct_and_continue"
		/// \
		/// [current_design]
		/// The following example sets the TOP property of the current fileset to define the top module of
		/// the project:
		/// set_property top fftTop [current_fileset]
		/// set_property top_file {C:/Data/sources/fftTop.v} [current_fileset]
		/// Note: Defining the top module requires the TOP property to be set to the desired hierarchical block in the
		/// source fileset of the current project. In the preceding example TOP is the property name, fftTop is the
		/// value, and current_fileset is the object. In addition, the TOP_FILE property should be defined to point to
		/// the data source for the top module.
		/// This example shows how to set a property value that includes the dash character, '-'. The dash
		/// can cause the tool to interpret the value as a new command argument, rather than part of the
		/// value being specified, and will cause an error as shown. In this case, you must use the explicit
		/// form of the positional arguments in the set_property command:
		/// set_property {XELAB.MORE_OPTIONS} {-pulse_e_style ondetect} \
		/// [get_filesets sim_1]
		/// ERROR: [Common 17-170] Unknown option '-pulse_e_style ondetect',
		/// please type 'set_property -help' for usage info.
		/// set_property -name {XELAB.MORE_OPTIONS} -value {-pulse_e_style ondetect}\
		/// -objects [get_filesets sim_1]
		/// The following example sets the internal VREF property value for the specified IO Bank:
		/// set_property internal_vref {0.75} [get_iobanks 0]
		/// The following example defines a DCI Cascade by setting the DCI_CASCADE property for the
		/// specified IO Bank:
		/// set_property DCI_CASCADE {14} [get_iobanks 0 ]
		/// The following example configures the synth_1 run, setting options for Vivado Synthesis 2013,
		/// and then launches the synthesis run:
		/// set_property flow {Vivado Synthesis 2016} \
		/// [get_runs synth_1]
		/// set_property STEPS.SYNTH_DESIGN.ARGS.FANOUT_LIMIT 500 \
		/// [get_runs synth_1]
		/// set_property STEPS.SYNTH_DESIGN.ARGS.GATED_CLOCK_CONVERSION on \
		/// [get_runs synth_1]
		/// set_property STEPS.SYNTH_DESIGN.ARGS.FSM_EXTRACTION one_hot \
		/// [get_runs synth_1]
		/// launch_runs synth_1
		/// This example is the same as the prior example, except that it uses the -dict option to set all the
		/// properties on the synthesis run in a single set_property command:
		/// set_property -dict [ list flow {Vivado Synthesis 2016} \
		/// STEPS.SYNTH_DESIGN.ARGS.FANOUT_LIMIT 500 \
		/// STEPS.SYNTH_DESIGN.ARGS.GATED_CLOCK_CONVERSION on \
		/// STEPS.SYNTH_DESIGN.ARGS.FSM_EXTRACTION \
		/// one_hot ] [get_runs synth_1]
		/// launch_runs synth_1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1649
		/// </summary>
		/// <param name="name">(Required) Name of property to set. Not valid with -dict option</param>
		/// <param name="value">(Required) Value of property to set. Not valid with -dict option</param>
		/// <param name="objects">(Required) Objects to set properties on</param>
		/// <param name="dict">(Optional) list of name/value pairs of properties to set</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_property(string name, string value, string objects, string dict = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_property [-dict <args>] [-quiet] [-verbose] <name> <value> <objects>...
			_tcl.Entry(_builder.set_property(name, value, objects, dict, quiet, verbose));
			return _tcl;
		}
	}
}
