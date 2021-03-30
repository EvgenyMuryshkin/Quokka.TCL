// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class WaiverCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public WaiverCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// Create a DRC/METHODOLOGY/CDC message waiver
		///
		///
		/// TCL Syntax: create_waiver [-type <arg>] [-id <arg>] [-objects <args>] [-from <args>] [-to <args>] [-strings <args>] [-of_objects <args>] [-user <arg>] -description <arg> [-tags <arg>] [-timestamp <arg>] [-scoped] [-quiet] [-verbose]
		///
		/// After report_drc, report_methodology, or report_cdc commands are run, they return
		/// messages of specific violations or conditions found in the design. These violations can prevent
		/// the design from progressing until they have been resolved or addressed in some way. The
		/// create_waiver command lets you select individual violations or specific checks that can be
		/// waived for a design, letting you move forward in the design flow.
		/// IMPORTANT! Use caution when waiving violations. Waivers may let you proceed in the design flow, but
		/// also let you create a design that is fundamentally flawed.
		/// The user creating the waiver is required to provide a user ID and description in the
		/// create_waiver command in order to provide some history of the waiver.
		/// A waiver must be specified for an individual DRC or methodology violation, or for a specific DRC
		/// or methodology check, or for a CDC path. The waiver must be assigned to a specific object, or
		/// specific violation ID, or for paths using -from/-to arguments. The form of the
		/// create_waiver command varies depending on the check, violation, or object being waived, as
		/// shown in the examples below.
		/// TIP: Although many of the arguments are described as optional, some form of identifier is required to
		/// associate the waiver with its target.
		/// To save waivers from one design session to the next, you must use write_waivers to create
		/// an XDC file of the waiver commands, and read_xdc to read those waivers back into the design
		/// when it is reopened.
		/// After creating a waiver, you will need to rerun the DRC, methodology, or CDC report to have the
		/// waiver considered in the analysis. To see what waivers are in place in the current design you can
		/// use the report_waivers command. In addition, the report_drc, report_methodology,
		/// and report_cdc commands have options to run the reports on waived violations or checks.
		/// Use the delete_waivers command to remove waivers from the design.
		///
		/// This example creates a waiver for a methodology check based on the specified ID:
		/// create_waiver -id TIMING-18 -user samwise -description {waive rule check}
		/// The following example creates a DRC check waiver for the indicated ID on the specified list of
		/// port objects, and provides the timestamp in local time:
		/// create_waiver -type DRC -id UCIO-1 -user samwise -desc {waiving DRC
		/// violation} \
		/// -objects [get_ports {src_in* dest_out*}] \
		/// -timestamp [clock format [clock seconds] -gmt 0]
		/// The following example creates a waiver for specific CDC paths in the design, defined by the -
		/// from/-to arguments:
		/// create_waiver -type CDC -id CDC-6 -user samwise \
		/// -description {Paths to be re-tested later}\
		/// -from [list [get_pins {inst_xpm_grey/src_gray_ff_reg[3]/C \
		/// inst_xpm_grey/src_gray_ff_reg[16]/C \
		/// inst_xpm_grey/src_gray_ff_reg[22]/C \
		/// inst_xpm_grey/src_gray_ff_reg[25]/C}] ] \
		/// -to [list [get_pins {inst_xpm_grey/dest_graysync_ff_reg[0][1]/D \
		/// inst_xpm_grey/dest_graysync_ff_reg[0][6]/D \
		/// inst_xpm_grey/dest_graysync_ff_reg[0][9]/D \
		/// inst_xpm_grey/dest_graysync_ff_reg[0][24]/D}] ]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 367
		/// </summary>
		/// <param name="description">(Required) Description string of the cause for the waiver</param>
		/// <param name="type">(Optional) Type of waiver - DRC, METHODOLOGY, CDC</param>
		/// <param name="id">
		/// (Optional)
		/// ID of the DRC/METHODOLOGY/CDC message being waived,
		/// not needed for -of_objects use
		/// </param>
		/// <param name="objects">
		/// (Optional)
		/// List of inserted message objects for which a DRC/
		/// METHODOLOGY waiver will be set (i.e. %ELG, %SIG, etc. for
		/// cells or nets, etc., sites, etc., or '*CELL', '*NET', '*SITE', etc.
		/// as wildcards
		/// </param>
		/// <param name="from">
		/// (Optional)
		/// List of source (driver) pins or ports (or '*PORT', '*PIN' as
		/// wildcard) for which a CDC waiver will be set
		/// </param>
		/// <param name="to">
		/// (Optional)
		/// List of target (load) pins or ports (or '*PORT', '*PIN' as
		/// wildcard) for which a CDC waiver will be set
		/// </param>
		/// <param name="strings">
		/// (Optional)
		/// List of inserted message string values for which a DRC/
		/// METHODOLOGY waiver will be set (i.e. %STR for strings, or
		/// '*' as wildcard)
		/// </param>
		/// <param name="of_objects">
		/// (Optional)
		/// List of DRC/METHODOLOGY/CDC violation objects for which
		/// waiver(s) will be set
		/// </param>
		/// <param name="user">
		/// (Optional)
		/// Name of the user creating the waiver (required, but if not
		/// specified, the waivers will take the USER name from the
		/// environment if it is available)
		/// </param>
		/// <param name="tags">
		/// (Optional)
		/// Optional list of one or more tags to aid in subsequent
		/// waiver identification or categorization
		/// </param>
		/// <param name="timestamp">
		/// (Optional)
		/// Timestamp of waiver - for restaining the original time of a
		/// waiver being (re)created after being written
		/// </param>
		/// <param name="scoped">
		/// (Optional)
		/// Flag waiver to interpret object wildcards as scoped to the
		/// current_instance that is set
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">
		/// (Optional)
		/// Suspend message limits during command execution
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// </param>
		/// <returns>waiver</returns>
		public TTCL create_waiver(String description, String type = null, String id = null, TCLParameterList objects = null, TCLParameterList from = null, TCLParameterList to = null, TCLParameterList strings = null, TCLParameterList of_objects = null, String user = null, String tags = null, String timestamp = null, bool? scoped = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_waiver [-type <arg>] [-id <arg>] [-objects <args>] [-from <args>] [-to <args>] [-strings <args>] [-of_objects <args>] [-user <arg>] -description <arg> [-tags <arg>] [-timestamp <arg>] [-scoped] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_waiver(description, type, id, objects, from, to, strings, of_objects, user, tags, timestamp, scoped, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Delete one or more DRC/METHODOLOGY/CDC message waivers
		///
		///
		/// TCL Syntax: delete_waivers [-scoped] [-quiet] [-verbose] [<objects>...]
		///
		/// After report_drc, report_methodology, or report_cdc commands are run, they return
		/// messages of specific violations or conditions found in the design. These violations can prevent
		/// the design from progressing until they have been resolved or addressed in some way. The
		/// create_waiver command lets you select individual violations or specific checks that can be
		/// waived for a design, letting you move forward in the design flow.
		/// Use the delete_waivers command to remove waivers from the design.
		///
		/// This example deletes all the DRC waivers in the design:
		/// delete_waivers [get_waivers -type DRC]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 484
		/// </summary>
		/// <param name="scoped">
		/// (Optional)
		/// flag waiver to interpret object wildcards as scoped to the
		/// current_instance that is set
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">
		/// (Optional)
		/// List of waiver objects, or a list of message objects (cells,
		/// nets, sites, etc.) for which DRC/METHODOLOGY waiver(s)
		/// were set
		/// </param>
		public TTCL delete_waivers(bool? scoped = null, bool? quiet = null, bool? verbose = null, TCLParameterList objects = null)
		{
			// TCL Syntax: delete_waivers [-scoped] [-quiet] [-verbose] [<objects>...]
			_tcl.Entry(_builder.delete_waivers(scoped, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// Get one or more DRC/METHODOLOGY/CDC message waivers
		///
		///
		/// TCL Syntax: get_waivers [-type <arg>] [-id <arg>] [-of_objects <args>] [-regexp] [-filter <arg>] [-nocase] [-quiet] [-verbose] [<patterns>]
		///
		/// The create_waiver command lets you select individual DRC, methodology, or CDC violations
		/// or rule checks that can be waived for a design, letting you move forward in the design flow. The
		/// get_waivers command lets you query the defined waiver objects in the current design.
		/// A waiver must be specified for an individual DRC or methodology violation, or for a specific DRC
		/// or methodology check, or for a CDC path. The waiver must be assigned to a specific object, or
		/// specific violation ID, or for paths using -from/-to arguments. You can format the
		/// get_waivers command to return the specific types of waivers you are looking for, or waivers
		/// associated with specific objects.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// You can report the waivers defined in the current design with report_waivers, and remove
		/// waivers from the design using delete_waivers.
		///
		/// This example gets any waivers in the current design:
		/// get_waivers
		/// The following example gets all DRC check waivers:
		/// get_waivers -type DRC *
		/// The following example gets all waivers associated with the specified objects:
		/// get_waivers -of_objects [get_ports {src_in* dest_out*}]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 957
		/// </summary>
		/// <param name="type">(Optional) Type of waiver - DRC, METHODOLOGY, CDC, ALL</param>
		/// <param name="id">(Optional) ID of the DRC/METHODOLOGY/CDC message being waived</param>
		/// <param name="of_objects">
		/// (Optional)
		/// List of objects (cells, nets, pins, sites, etc.) for which DRC/
		/// METHODLOGY/CDC waiver(s) were set
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// (Optional)
		/// Match waiver names against patterns Default: * Values: The
		/// default search pattern is the wildcard *, or .* when -regexp
		/// is specified.
		/// </param>
		/// <returns>waivers</returns>
		public TTCL get_waivers(String type = null, String id = null, TCLParameterList of_objects = null, bool? regexp = null, String filter = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_waivers [-type <arg>] [-id <arg>] [-of_objects <args>] [-regexp] [-filter <arg>] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_waivers(type, id, of_objects, regexp, filter, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Report status of DRC/METHODOLOGY/CDC message waivers
		///
		///
		/// TCL Syntax: report_waivers [-file <arg>] [-type <arg>] [-write_valid_waivers] [-write_ignored_waivers] [-append] [-return_string] [-show_msgs_with_no_waivers] [-quiet] [-verbose]
		///
		/// Reports DRC, METHODOLOGY, and CDC violation messages and displays what waivers are in
		/// place in the current design.
		/// In addition, the report_drc, report_methodology, and report_cdc commands have
		/// options to run the reports on waived violations or checks.
		///
		/// This example reports all waivers in the current design:
		/// report_waivers
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1477
		/// </summary>
		/// <param name="file">(Optional) Name of file to report waivers</param>
		/// <param name="type">(Optional) Type of waiver - ALL, DRC, METHODOLOGY, CDC</param>
		/// <param name="write_valid_waivers">
		/// (Optional)
		/// (special) Specifies writing out the specific waivers which
		/// were used in the last report_drc/methodology/cdc run(s)
		/// </param>
		/// <param name="write_ignored_waivers">
		/// (Optional)
		/// (special) Specifies writing out the specific waivers which
		/// were NOT used in the last report_drc/methodology/cdc
		/// run(s)
		/// </param>
		/// <param name="append">(Optional) Append the current report results to the file specified with - file</param>
		/// <param name="return_string">(Optional) Return report results as a string object</param>
		/// <param name="show_msgs_with_no_waivers">
		/// (Optional)
		/// also list report_drc/methodology/cdc messages which have
		/// no defined waivers
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_waivers(String file = null, String type = null, bool? write_valid_waivers = null, bool? write_ignored_waivers = null, bool? append = null, bool? return_string = null, bool? show_msgs_with_no_waivers = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_waivers [-file <arg>] [-type <arg>] [-write_valid_waivers] [-write_ignored_waivers] [-append] [-return_string] [-show_msgs_with_no_waivers] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_waivers(file, type, write_valid_waivers, write_ignored_waivers, append, return_string, show_msgs_with_no_waivers, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Write out one or more DRC/METHODOLOGY/CDC message waivers in command form
		///
		///
		/// TCL Syntax: write_waivers [-type <arg>] [-objects <args>] [-return_string] [-force] [-quiet] [-verbose] [<file>]
		///
		/// To save waivers from one design session to the next, you must use write_waivers to create
		/// an XDC file of the waiver commands, and read_xdc to read those waivers back into the design
		/// when it is reopened.
		///
		/// This example writes all waivers in the current design:
		/// write_waivers C:/Data/design_waivers.xdc
		/// The following example writes only DRC type waivers:
		/// write_waivers -type DRC C:/Data/drc_waivers.xdc
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1898
		/// </summary>
		/// <param name="file">(Required) Name of file to write waivers</param>
		/// <param name="type">(Optional) Type of waiver(s) - ALL, DRC, METHODOLOGY, CDC to write</param>
		/// <param name="objects">(Optional) List of DRC/METHODOLOGY/CDC waiver objects to be written</param>
		/// <param name="return_string">(Optional) Return report results as a string object</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_waivers(String file, String type = null, TCLParameterList objects = null, bool? return_string = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_waivers [-type <arg>] [-objects <args>] [-return_string] [-force] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.write_waivers(file, type, objects, return_string, force, quiet, verbose));
			return _tcl;
		}
	}
}
