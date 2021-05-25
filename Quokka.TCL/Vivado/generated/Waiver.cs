#pragma warning disable IDE1006 // Naming Styles
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
		/// <para>
		/// Create a DRC/METHODOLOGY/CDC message waiver<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_waiver [-type &lt;arg&gt;] [-id &lt;arg&gt;] [-objects &lt;args&gt;] [-from &lt;args&gt;] [-to &lt;args&gt;] [-strings &lt;args&gt;] [-of_objects &lt;args&gt;] [-user &lt;arg&gt;] -description &lt;arg&gt; [-tags &lt;arg&gt;] [-timestamp &lt;arg&gt;] [-scoped] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// After report_drc, report_methodology, or report_cdc commands are run, they return<br/>
		/// messages of specific violations or conditions found in the design. These violations can prevent<br/>
		/// the design from progressing until they have been resolved or addressed in some way. The<br/>
		/// create_waiver command lets you select individual violations or specific checks that can be<br/>
		/// waived for a design, letting you move forward in the design flow.<br/>
		/// IMPORTANT! Use caution when waiving violations. Waivers may let you proceed in the design flow, but<br/>
		/// also let you create a design that is fundamentally flawed.<br/>
		/// The user creating the waiver is required to provide a user ID and description in the<br/>
		/// create_waiver command in order to provide some history of the waiver.<br/>
		/// A waiver must be specified for an individual DRC or methodology violation, or for a specific DRC<br/>
		/// or methodology check, or for a CDC path. The waiver must be assigned to a specific object, or<br/>
		/// specific violation ID, or for paths using -from/-to arguments. The form of the<br/>
		/// create_waiver command varies depending on the check, violation, or object being waived, as<br/>
		/// shown in the examples below.<br/>
		/// TIP: Although many of the arguments are described as optional, some form of identifier is required to<br/>
		/// associate the waiver with its target.<br/>
		/// To save waivers from one design session to the next, you must use write_waivers to create<br/>
		/// an XDC file of the waiver commands, and read_xdc to read those waivers back into the design<br/>
		/// when it is reopened.<br/>
		/// After creating a waiver, you will need to rerun the DRC, methodology, or CDC report to have the<br/>
		/// waiver considered in the analysis. To see what waivers are in place in the current design you can<br/>
		/// use the report_waivers command. In addition, the report_drc, report_methodology,<br/>
		/// and report_cdc commands have options to run the reports on waived violations or checks.<br/>
		/// Use the delete_waivers command to remove waivers from the design.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example creates a waiver for a methodology check based on the specified ID:<br/>
		/// create_waiver -id TIMING-18 -user samwise -description {waive rule check}<br/>
		/// The following example creates a DRC check waiver for the indicated ID on the specified list of<br/>
		/// port objects, and provides the timestamp in local time:<br/>
		/// create_waiver -type DRC -id UCIO-1 -user samwise -desc {waiving DRC<br/>
		/// violation} \<br/>
		/// -objects [get_ports {src_in* dest_out*}] \<br/>
		/// -timestamp [clock format [clock seconds] -gmt 0]<br/>
		/// The following example creates a waiver for specific CDC paths in the design, defined by the -<br/>
		/// from/-to arguments:<br/>
		/// create_waiver -type CDC -id CDC-6 -user samwise \<br/>
		/// -description {Paths to be re-tested later}\<br/>
		/// -from [list [get_pins {inst_xpm_grey/src_gray_ff_reg[3]/C \<br/>
		/// inst_xpm_grey/src_gray_ff_reg[16]/C \<br/>
		/// inst_xpm_grey/src_gray_ff_reg[22]/C \<br/>
		/// inst_xpm_grey/src_gray_ff_reg[25]/C}] ] \<br/>
		/// -to [list [get_pins {inst_xpm_grey/dest_graysync_ff_reg[0][1]/D \<br/>
		/// inst_xpm_grey/dest_graysync_ff_reg[0][6]/D \<br/>
		/// inst_xpm_grey/dest_graysync_ff_reg[0][9]/D \<br/>
		/// inst_xpm_grey/dest_graysync_ff_reg[0][24]/D}] ]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 367<br/>
		/// </para>
		/// </summary>
		/// <param name="description">(Required) Description string of the cause for the waiver</param>
		/// <param name="type">(Optional) Type of waiver - DRC, METHODOLOGY, CDC</param>
		/// <param name="id">
		/// <para>
		/// (Optional)<br/>
		/// ID of the DRC/METHODOLOGY/CDC message being waived,<br/>
		/// not needed for -of_objects use<br/>
		/// </para>
		/// </param>
		/// <param name="objects">
		/// <para>
		/// (Optional)<br/>
		/// List of inserted message objects for which a DRC/<br/>
		/// METHODOLOGY waiver will be set (i.e. %ELG, %SIG, etc. for<br/>
		/// cells or nets, etc., sites, etc., or '*CELL', '*NET', '*SITE', etc.<br/>
		/// as wildcards<br/>
		/// </para>
		/// </param>
		/// <param name="from">
		/// <para>
		/// (Optional)<br/>
		/// List of source (driver) pins or ports (or '*PORT', '*PIN' as<br/>
		/// wildcard) for which a CDC waiver will be set<br/>
		/// </para>
		/// </param>
		/// <param name="to">
		/// <para>
		/// (Optional)<br/>
		/// List of target (load) pins or ports (or '*PORT', '*PIN' as<br/>
		/// wildcard) for which a CDC waiver will be set<br/>
		/// </para>
		/// </param>
		/// <param name="strings">
		/// <para>
		/// (Optional)<br/>
		/// List of inserted message string values for which a DRC/<br/>
		/// METHODOLOGY waiver will be set (i.e. %STR for strings, or<br/>
		/// '*' as wildcard)<br/>
		/// </para>
		/// </param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// List of DRC/METHODOLOGY/CDC violation objects for which<br/>
		/// waiver(s) will be set<br/>
		/// </para>
		/// </param>
		/// <param name="user">
		/// <para>
		/// (Optional)<br/>
		/// Name of the user creating the waiver (required, but if not<br/>
		/// specified, the waivers will take the USER name from the<br/>
		/// environment if it is available)<br/>
		/// </para>
		/// </param>
		/// <param name="tags">
		/// <para>
		/// (Optional)<br/>
		/// Optional list of one or more tags to aid in subsequent<br/>
		/// waiver identification or categorization<br/>
		/// </para>
		/// </param>
		/// <param name="timestamp">
		/// <para>
		/// (Optional)<br/>
		/// Timestamp of waiver - for restaining the original time of a<br/>
		/// waiver being (re)created after being written<br/>
		/// </para>
		/// </param>
		/// <param name="scoped">
		/// <para>
		/// (Optional)<br/>
		/// Flag waiver to interpret object wildcards as scoped to the<br/>
		/// current_instance that is set<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">
		/// <para>
		/// (Optional)<br/>
		/// Suspend message limits during command execution<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// </param>
		/// <returns>waiver</returns>
		public TTCL create_waiver(String description, String type = null, String id = null, TCLParameterList objects = null, TCLParameterList from = null, TCLParameterList to = null, TCLParameterList strings = null, TCLParameterList of_objects = null, String user = null, String tags = null, String timestamp = null, bool? scoped = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_waiver [-type <arg>] [-id <arg>] [-objects <args>] [-from <args>] [-to <args>] [-strings <args>] [-of_objects <args>] [-user <arg>] -description <arg> [-tags <arg>] [-timestamp <arg>] [-scoped] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_waiver(description, type, id, objects, from, to, strings, of_objects, user, tags, timestamp, scoped, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Delete one or more DRC/METHODOLOGY/CDC message waivers<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_waivers [-scoped] [-quiet] [-verbose] [&lt;objects&gt;...]
		/// <br/>
		/// <para>
		/// After report_drc, report_methodology, or report_cdc commands are run, they return<br/>
		/// messages of specific violations or conditions found in the design. These violations can prevent<br/>
		/// the design from progressing until they have been resolved or addressed in some way. The<br/>
		/// create_waiver command lets you select individual violations or specific checks that can be<br/>
		/// waived for a design, letting you move forward in the design flow.<br/>
		/// Use the delete_waivers command to remove waivers from the design.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example deletes all the DRC waivers in the design:<br/>
		/// delete_waivers [get_waivers -type DRC]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 484<br/>
		/// </para>
		/// </summary>
		/// <param name="scoped">
		/// <para>
		/// (Optional)<br/>
		/// flag waiver to interpret object wildcards as scoped to the<br/>
		/// current_instance that is set<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="objects">
		/// <para>
		/// (Optional)<br/>
		/// List of waiver objects, or a list of message objects (cells,<br/>
		/// nets, sites, etc.) for which DRC/METHODOLOGY waiver(s)<br/>
		/// were set<br/>
		/// </para>
		/// </param>
		public TTCL delete_waivers(bool? scoped = null, bool? quiet = null, bool? verbose = null, TCLParameterList objects = null)
		{
			// TCL Syntax: delete_waivers [-scoped] [-quiet] [-verbose] [<objects>...]
			_tcl.Entry(_builder.delete_waivers(scoped, quiet, verbose, objects));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get one or more DRC/METHODOLOGY/CDC message waivers<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_waivers [-type &lt;arg&gt;] [-id &lt;arg&gt;] [-of_objects &lt;args&gt;] [-regexp] [-filter &lt;arg&gt;] [-nocase] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// The create_waiver command lets you select individual DRC, methodology, or CDC violations<br/>
		/// or rule checks that can be waived for a design, letting you move forward in the design flow. The<br/>
		/// get_waivers command lets you query the defined waiver objects in the current design.<br/>
		/// A waiver must be specified for an individual DRC or methodology violation, or for a specific DRC<br/>
		/// or methodology check, or for a CDC path. The waiver must be assigned to a specific object, or<br/>
		/// specific violation ID, or for paths using -from/-to arguments. You can format the<br/>
		/// get_waivers command to return the specific types of waivers you are looking for, or waivers<br/>
		/// associated with specific objects.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// You can report the waivers defined in the current design with report_waivers, and remove<br/>
		/// waivers from the design using delete_waivers.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example gets any waivers in the current design:<br/>
		/// get_waivers<br/>
		/// The following example gets all DRC check waivers:<br/>
		/// get_waivers -type DRC *<br/>
		/// The following example gets all waivers associated with the specified objects:<br/>
		/// get_waivers -of_objects [get_ports {src_in* dest_out*}]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 957<br/>
		/// </para>
		/// </summary>
		/// <param name="type">(Optional) Type of waiver - DRC, METHODOLOGY, CDC, ALL</param>
		/// <param name="id">(Optional) ID of the DRC/METHODOLOGY/CDC message being waived</param>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// List of objects (cells, nets, pins, sites, etc.) for which DRC/<br/>
		/// METHODLOGY/CDC waiver(s) were set<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">
		/// <para>
		/// (Optional)<br/>
		/// Match waiver names against patterns Default: * Values: The<br/>
		/// default search pattern is the wildcard *, or .* when -regexp<br/>
		/// is specified.<br/>
		/// </para>
		/// </param>
		/// <returns>waivers</returns>
		public TTCL get_waivers(String type = null, String id = null, TCLParameterList of_objects = null, bool? regexp = null, String filter = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_waivers [-type <arg>] [-id <arg>] [-of_objects <args>] [-regexp] [-filter <arg>] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_waivers(type, id, of_objects, regexp, filter, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report status of DRC/METHODOLOGY/CDC message waivers<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_waivers [-file &lt;arg&gt;] [-type &lt;arg&gt;] [-write_valid_waivers] [-write_ignored_waivers] [-append] [-return_string] [-show_msgs_with_no_waivers] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Reports DRC, METHODOLOGY, and CDC violation messages and displays what waivers are in<br/>
		/// place in the current design.<br/>
		/// In addition, the report_drc, report_methodology, and report_cdc commands have<br/>
		/// options to run the reports on waived violations or checks.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example reports all waivers in the current design:<br/>
		/// report_waivers<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1477<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Optional) Name of file to report waivers</param>
		/// <param name="type">(Optional) Type of waiver - ALL, DRC, METHODOLOGY, CDC</param>
		/// <param name="write_valid_waivers">
		/// <para>
		/// (Optional)<br/>
		/// (special) Specifies writing out the specific waivers which<br/>
		/// were used in the last report_drc/methodology/cdc run(s)<br/>
		/// </para>
		/// </param>
		/// <param name="write_ignored_waivers">
		/// <para>
		/// (Optional)<br/>
		/// (special) Specifies writing out the specific waivers which<br/>
		/// were NOT used in the last report_drc/methodology/cdc<br/>
		/// run(s)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the current report results to the file specified with - file</param>
		/// <param name="return_string">(Optional) Return report results as a string object</param>
		/// <param name="show_msgs_with_no_waivers">
		/// <para>
		/// (Optional)<br/>
		/// also list report_drc/methodology/cdc messages which have<br/>
		/// no defined waivers<br/>
		/// </para>
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
		/// <para>
		/// Write out one or more DRC/METHODOLOGY/CDC message waivers in command form<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_waivers [-type &lt;arg&gt;] [-objects &lt;args&gt;] [-return_string] [-force] [-quiet] [-verbose] [&lt;file&gt;]
		/// <br/>
		/// <para>
		/// To save waivers from one design session to the next, you must use write_waivers to create<br/>
		/// an XDC file of the waiver commands, and read_xdc to read those waivers back into the design<br/>
		/// when it is reopened.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// This example writes all waivers in the current design:<br/>
		/// write_waivers C:/Data/design_waivers.xdc<br/>
		/// The following example writes only DRC type waivers:<br/>
		/// write_waivers -type DRC C:/Data/drc_waivers.xdc<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1898<br/>
		/// </para>
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
#pragma warning restore IDE1006 // Naming Styles
