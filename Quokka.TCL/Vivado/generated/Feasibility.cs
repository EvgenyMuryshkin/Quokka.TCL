#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class FeasibilityCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public FeasibilityCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// <para>
		/// Deletes a list of available QoR suggestions<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_qor_suggestions [-quiet] [-verbose] [&lt;IDs&gt;]
		/// <br/>
		/// <para>
		/// Removes QoR suggestion objects that are currently in memory. Suggestion objects are generated<br/>
		/// running the report_qor_suggestion command, without specifying -of_objects, and by<br/>
		/// reading an RQS file using the read_qor_suggestions command. You can get QoR objects by<br/>
		/// using the get_qor_suggestions command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following deletes all the suggestion objects in memory:<br/>
		/// delete_qor_suggestions [get_qor_suggestions]<br/>
		/// The following deletes only the Utilization suggestions:<br/>
		/// delete_qor_suggestions [get_qor_suggestions -filter {CATEGORY==Utilization}]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 470<br/>
		/// </para>
		/// </summary>
		/// <param name="IDs">(Required) Match suggestion names against given names</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_qor_suggestions(TCLObject IDs, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_qor_suggestions [-quiet] [-verbose] [<IDs>]
			_tcl.Entry(_builder.delete_qor_suggestions(IDs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of available QoR suggestions<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_qor_suggestions [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;IDs&gt;]
		/// <br/>
		/// <para>
		/// Get existing QoR suggestion objects created by the report_qor_suggestions command, or<br/>
		/// read into the design using read_qor_suggestions. The selected QoR objects can be written<br/>
		/// to a file using the write_qor_suggestions command. The suggestions created by the report<br/>
		/// command remain in memory until delete_qor_suggestions is run, or until it is overwritten<br/>
		/// by another report.<br/>
		/// This command returns a list of existing QoR suggestion objects from the open design, or returns<br/>
		/// an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// To return an individual suggestion, you can supply the full ID:<br/>
		/// get_qor_suggestions RQS_CLOCK-5_1-1<br/>
		/// Due to the naming style of suggestions, wildcard searches do NOT work directly. However you<br/>
		/// can use the filter command with -regexp to use wildcards as follows:<br/>
		/// filter -regexp [get_qor_suggestions] {NAME =~ RQS_CLOCK.*}<br/>
		/// You can also filter suggestions objects within a given category. Available categories include:<br/>
		/// Timing, Congestion, Utilization, XDC, Clocking, and Strategy. For example, the following returns<br/>
		/// suggestions related to the Timing category:<br/>
		/// get_qor_suggestions -filter {CATEGORY==Timing}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 904<br/>
		/// </para>
		/// </summary>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="IDs">(Optional) Match suggestion names against given names</param>
		/// <returns>list of qor suggestion objects</returns>
		public TTCL get_qor_suggestions(String filter = null, bool? quiet = null, bool? verbose = null, TCLObject IDs = null)
		{
			// TCL Syntax: get_qor_suggestions [-filter <arg>] [-quiet] [-verbose] [<IDs>]
			_tcl.Entry(_builder.get_qor_suggestions(filter, quiet, verbose, IDs));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Read QoR Suggestions from the given file<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_qor_suggestions [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Read the specified file and extract the QoR suggestions from the file.<br/>
		/// This command returns the name of the QoR file read, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reads the QoR suggestions from the specified file, and then reports the<br/>
		/// QoR suggestions in the open design:<br/>
		/// read_qor_suggestions C:/Data/qor_results.rqs<br/>
		/// report_qor_suggestions -of_objects [get_qor_suggestions]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1174<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Required)<br/>
		/// QoR suggestions file Values: Path to the QoR suggestions<br/>
		/// file, typically ending with .rqs.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL read_qor_suggestions(TCLObject file, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_qor_suggestions [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.read_qor_suggestions(file, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Feasibility Checks<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_qor_assessment [-file &lt;arg&gt;] [-max_paths &lt;arg&gt;] [-append] [-return_string] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This command look for trouble spots in the design and assesses the likelihood of a design<br/>
		/// meeting design goals. This command requires an open elaborated, synthesized or implemented<br/>
		/// design for analysis.<br/>
		/// The Report QoR Assessment covers multiple categories:<br/>
		/// • Design Methodology<br/>
		/// • Synthesis<br/>
		/// • Implementation<br/>
		/// • Design Hierarchy<br/>
		/// • Partial Reconfiguration<br/>
		/// • Floorplanning<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The report_qor_assessment command includes a subset of report_methodology checks<br/>
		/// identifying bad practices that can lead to an expected problem. Yet, report_qor_assessment<br/>
		/// is also more comprehensive than report_methodology, because it includes other checks that<br/>
		/// are not necessarily bad practices but may have low success due to the structure, style, size, or<br/>
		/// complexity of the current design.<br/>
		/// A key feature of Report QOR Assessment is the ability to predict certain conditions that lead to<br/>
		/// congestion and performance degradation. This command can be run at any stage of the<br/>
		/// implementation flow after synthesis. The report_qor_assessment command will return a<br/>
		/// score from 1 - 5, where 1 is a failing grade, and 5 means the design will likely pass<br/>
		/// implementation and meet timing.<br/>
		/// For violations found by Report QOR Assessment, the Report QOR Suggestions command will<br/>
		/// make recommendations on how to avoid issues, or modify the design to improve results.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports suggestions after analyzing the worst 10 paths:<br/>
		/// report_qor_assessment -max_paths 10<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1423<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="max_paths">(Optional) Number of paths to consider for suggestion analysis Default: 100</param>
		/// <param name="append">(Optional) Append the results to file, do not overwrite the results file</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_qor_assessment(String file = null, Int32? max_paths = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_qor_assessment [-file <arg>] [-max_paths <arg>] [-append] [-return_string] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_qor_assessment(file, max_paths, append, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Recommend QoR Suggestions<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_qor_suggestions [-file &lt;arg&gt;] [-name &lt;arg&gt;] [-append] [-return_string] [-max_strategies &lt;arg&gt;] [-max_paths &lt;arg&gt;] [-no_split] [-report_all_suggestions] [-cells &lt;args&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Report design and tool option recommendations related to improving the quality of results (QoR).<br/>
		/// The report looks at timing constraints, netlist characteristics, failing timing paths, and congestion<br/>
		/// information to determine suggestions that can enhance the QoR. The report can be generated<br/>
		/// after synthesis, or after any implementation step, but requires a design to be open.<br/>
		/// The report_qor_suggestions command creates QoR suggestion objects related to the<br/>
		/// suggestions identified. These suggestion objects can be enabled for use by the Vivado tools to<br/>
		/// improve the quality of synthesis and implementation results. Some of these suggestions can be<br/>
		/// automatically applied, and some may require more manual intervention to implement design<br/>
		/// changes, or write Tcl design constraints.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Suggestion objects can be obtained using the get_qor_suggestions command. The QoR<br/>
		/// objects have properties that define what step they are APPLICABLE_FOR, if they are ENABLED<br/>
		/// to be used, if they can be automatically applied (AUTO), or what step the suggestions was<br/>
		/// GENERATED_AT. A suggestion must be ENABLED and the APPLICABLE_FOR synthesis or<br/>
		/// implementation step run in order for a suggestion to be applied to the design.<br/>
		/// You can write the suggestions from the design into an RQS file using the<br/>
		/// write_qor_suggestions command. After resetting the design flow to the appropriate step,<br/>
		/// you can read suggestions back into the design using the read_qor_suggestions command,<br/>
		/// and then run the synthesis or implementation step to apply the enabled suggestions.<br/>
		/// The recommended method for working with QoR suggestions is:<br/>
		/// 1. Run the report to create recommendations (report_qor_suggestions)<br/>
		/// 2. Write the suggestions to an RQS file on disk (write_qor_suggestions).<br/>
		/// 3. Reset the design to the appropriate step.<br/>
		/// 4. Read the RQS file into the design to restore the suggestions (read_qor_suggestions).<br/>
		/// 5. Run the synthesis or implementation step to apply the suggestion (synth_design,<br/>
		/// opt_design...).<br/>
		/// For strategy suggestions, a machine learning based analysis is conducted and the best 3<br/>
		/// strategies are reported. This analysis is only conducted on a routed design that has been<br/>
		/// implemented with<br/>
		/// • either default or explore directives for opt_design and<br/>
		/// • either all default or all explore directives for place_design, phys_opt_design, and<br/>
		/// route_design commands.<br/>
		/// Strategy suggestions do not apply to synthesis. Unlike the non-strategy suggestions, only one<br/>
		/// strategy suggestion can be applied to each run.<br/>
		/// The recommended method for working with QoR strategy suggestions is:<br/>
		/// 1. Run the report to create strategies and other<br/>
		/// recommendations(report_qor_suggestions).<br/>
		/// 2. Write the suggestions to a directory disk. There is one RQS file per strategy<br/>
		/// (write_qor_suggestions -strategy_dir).<br/>
		/// 3. Update all the directive settings to -directive RQS for opt_design, place_design,<br/>
		/// phys_opt_design, and route_design commands.<br/>
		/// 4. For each run, read one RQS file into the design. This will contain the strategy suggestion and<br/>
		/// all exported non-strategy suggestions(read_qor_suggestions).<br/>
		/// 5. Run the implementation step from the opt_design command to apply the strategy and all<br/>
		/// the design suggestions.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports suggestions after analyzing the worst 10 paths:<br/>
		/// report_qor_suggestions -max_paths 10<br/>
		/// This example reports existing suggestions in the design from a prior run of<br/>
		/// report_qor_suggestions:<br/>
		/// report_qor_suggestions -of_objects [get_qor_suggestions]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1426<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="name">(Optional) Output the results to GUI panel with this name</param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="return_string">(Optional) Return report as string</param>
		/// <param name="max_strategies">(Optional) Number of strategies to suggest Default: 3</param>
		/// <param name="max_paths">(Optional) Number of paths to consider for suggestion analysis Default: 100</param>
		/// <param name="no_split">(Optional) Report without spliting the lines in tables</param>
		/// <param name="report_all_suggestions">(Optional) Report all suggestions</param>
		/// <param name="cells">(Optional) Report QOR suggestions for a given cell</param>
		/// <param name="of_objects">(Optional) List of QoR suggestion objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_qor_suggestions(String file = null, String name = null, bool? append = null, bool? return_string = null, Int32? max_strategies = null, Int32? max_paths = null, bool? no_split = null, bool? report_all_suggestions = null, TCLParameterList cells = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_qor_suggestions [-file <arg>] [-name <arg>] [-append] [-return_string] [-max_strategies <arg>] [-max_paths <arg>] [-no_split] [-report_all_suggestions] [-cells <args>] [-of_objects <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_qor_suggestions(file, name, append, return_string, max_strategies, max_paths, no_split, report_all_suggestions, cells, of_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write QoR Suggestions to the given file<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_qor_suggestions [-strategy_dir &lt;arg&gt;] [-tcl_output_dir &lt;arg&gt;] [-force] [-of_objects &lt;args&gt;] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Write the QoR suggestions generated by the report_qor_suggestions command. You can<br/>
		/// combine the suggestions from the latest report with suggestions read into the design with<br/>
		/// read_qor_suggestions so that you can manage all suggestions in a single RQS file.<br/>
		/// To write out specific QoR suggestions, use the -of_objects option. When this is not specified,<br/>
		/// all suggestions will be written.<br/>
		/// The recommended way to manage suggestions is using RQS objects. However, it is possible to<br/>
		/// view and execute the commands using Tcl. Specifying the -tcl_output_dir option writes Tcl<br/>
		/// scripts for the automated suggestions that are property based.<br/>
		/// Implementation strategies that use machine learning to analyze the design can be generated<br/>
		/// running report_qor_suggestions. If you specify the -strategy_dir option, multiple Tcl<br/>
		/// files and one RQS file will be written for each strategy. The Tcl files aid integration into project or<br/>
		/// non project flows. The main RQS file should not be used as the suggestions are contained in the<br/>
		/// run specific files along with strategy information.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns the name of the output file created when successful, or returns an error if<br/>
		/// it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports QoR suggestions, then writes non-strategy suggestions to the<br/>
		/// specified file.<br/>
		/// report_qor_suggestions<br/>
		/// write_qor_suggestions C:/Data/qor_results.rqs<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example reports QoR suggestions, then writes both strategy and non-strategy<br/>
		/// suggestions. It will create one RQS file for each strategy suggestion that exists, generating up to<br/>
		/// three by default. Into each RQS file, it writes one strategy suggestion and all non-strategy<br/>
		/// suggestions. This behavior means that for subsequent runs one RQS file per run is required.<br/>
		/// report_qor_suggestions<br/>
		/// write_qor_suggestions -strategy_dir C:/Data/strategy_dir C:/Data/<br/>
		/// qor_suggestions.rqs<br/>
		/// To make use of strategy suggestions, the directive for each implementation command<br/>
		/// (opt_design, place_design, phys_opt_design, and route_design) must be set to RQS.<br/>
		/// This can be configured automatically in project mode by sourcing the project mode Tcl script<br/>
		/// generated for each RQS file in the strategy_dir. There is also a non-project example Tcl script<br/>
		/// that demonstrates this requirement.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1883<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Required)<br/>
		/// QoR suggestions file Values: A filename with alphanumeric<br/>
		/// characters and .rqs extension.<br/>
		/// </para>
		/// </param>
		/// <param name="strategy_dir">
		/// <para>
		/// (Optional)<br/>
		/// Directory to create Strategy RQS &amp; TCL files Values: If<br/>
		/// passed a directory path, for each strategy suggested one set<br/>
		/// of RQS and TCL files will be generated.<br/>
		/// </para>
		/// </param>
		/// <param name="tcl_output_dir">
		/// <para>
		/// (Optional)<br/>
		/// Directory to create TCL files Values: TCL files for the QoR<br/>
		/// suggestions will be generated in the provided directory.<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Overwrite existing suggestions file</param>
		/// <param name="of_objects">(Optional) List of QoR suggestion objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_qor_suggestions(TCLObject file, String strategy_dir = null, String tcl_output_dir = null, bool? force = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_qor_suggestions [-strategy_dir <arg>] [-tcl_output_dir <arg>] [-force] [-of_objects <args>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_qor_suggestions(file, strategy_dir, tcl_output_dir, force, of_objects, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
