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
		/// Deletes a list of available QoR suggestions
		///
		///
		/// TCL Syntax: delete_qor_suggestions [-quiet] [-verbose] [<IDs>]
		///
		/// Removes QoR suggestion objects that are currently in memory. Suggestion objects are generated
		/// running the report_qor_suggestion command, without specifying -of_objects, and by
		/// reading an RQS file using the read_qor_suggestions command. You can get QoR objects by
		/// using the get_qor_suggestions command.
		///
		/// The following deletes all the suggestion objects in memory:
		/// delete_qor_suggestions [get_qor_suggestions]
		/// The following deletes only the Utilization suggestions:
		/// delete_qor_suggestions [get_qor_suggestions -filter {CATEGORY==Utilization}]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 470
		/// </summary>
		/// <param name="IDs">(Required) Match suggestion names against given names</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_qor_suggestions(string IDs, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_qor_suggestions [-quiet] [-verbose] [<IDs>]
			_tcl.Entry(_builder.delete_qor_suggestions(IDs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of available QoR suggestions
		///
		///
		/// TCL Syntax: get_qor_suggestions [-filter <arg>] [-quiet] [-verbose] [<IDs>]
		///
		/// Get existing QoR suggestion objects created by the report_qor_suggestions command, or
		/// read into the design using read_qor_suggestions. The selected QoR objects can be written
		/// to a file using the write_qor_suggestions command. The suggestions created by the report
		/// command remain in memory until delete_qor_suggestions is run, or until it is overwritten
		/// by another report.
		/// This command returns a list of existing QoR suggestion objects from the open design, or returns
		/// an error if it fails.
		///
		/// To return an individual suggestion, you can supply the full ID:
		/// get_qor_suggestions RQS_CLOCK-5_1-1
		/// Due to the naming style of suggestions, wildcard searches do NOT work directly. However you
		/// can use the filter command with -regexp to use wildcards as follows:
		/// filter -regexp [get_qor_suggestions] {NAME =~ RQS_CLOCK.*}
		/// You can also filter suggestions objects within a given category. Available categories include:
		/// Timing, Congestion, Utilization, XDC, Clocking, and Strategy. For example, the following returns
		/// suggestions related to the Timing category:
		/// get_qor_suggestions -filter {CATEGORY==Timing}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 904
		/// </summary>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="IDs">(Optional) Match suggestion names against given names</param>
		/// <returns>list of qor suggestion objects</returns>
		public TTCL get_qor_suggestions(string filter = null, bool? quiet = null, bool? verbose = null, string IDs = null)
		{
			// TCL Syntax: get_qor_suggestions [-filter <arg>] [-quiet] [-verbose] [<IDs>]
			_tcl.Entry(_builder.get_qor_suggestions(filter, quiet, verbose, IDs));
			return _tcl;
		}
		/// <summary>
		/// Read QoR Suggestions from the given file
		///
		///
		/// TCL Syntax: read_qor_suggestions [-quiet] [-verbose] <file>
		///
		/// Read the specified file and extract the QoR suggestions from the file.
		/// This command returns the name of the QoR file read, or returns an error if it fails.
		///
		/// The following example reads the QoR suggestions from the specified file, and then reports the
		/// QoR suggestions in the open design:
		/// read_qor_suggestions C:/Data/qor_results.rqs
		/// report_qor_suggestions -of_objects [get_qor_suggestions]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1174
		/// </summary>
		/// <param name="file">
		/// (Required)
		/// QoR suggestions file Values: Path to the QoR suggestions
		/// file, typically ending with .rqs.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL read_qor_suggestions(string file, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_qor_suggestions [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.read_qor_suggestions(file, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Feasibility Checks
		///
		///
		/// TCL Syntax: report_qor_assessment [-file <arg>] [-max_paths <arg>] [-append] [-return_string] [-quiet] [-verbose]
		///
		/// This command look for trouble spots in the design and assesses the likelihood of a design
		/// meeting design goals. This command requires an open elaborated, synthesized or implemented
		/// design for analysis.
		/// The Report QoR Assessment covers multiple categories:
		/// • Design Methodology
		/// • Synthesis
		/// • Implementation
		/// • Design Hierarchy
		/// • Partial Reconfiguration
		/// • Floorplanning
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The report_qor_assessment command includes a subset of report_methodology checks
		/// identifying bad practices that can lead to an expected problem. Yet, report_qor_assessment
		/// is also more comprehensive than report_methodology, because it includes other checks that
		/// are not necessarily bad practices but may have low success due to the structure, style, size, or
		/// complexity of the current design.
		/// A key feature of Report QOR Assessment is the ability to predict certain conditions that lead to
		/// congestion and performance degradation. This command can be run at any stage of the
		/// implementation flow after synthesis. The report_qor_assessment command will return a
		/// score from 1 - 5, where 1 is a failing grade, and 5 means the design will likely pass
		/// implementation and meet timing.
		/// For violations found by Report QOR Assessment, the Report QOR Suggestions command will
		/// make recommendations on how to avoid issues, or modify the design to improve results.
		///
		/// The following example reports suggestions after analyzing the worst 10 paths:
		/// report_qor_assessment -max_paths 10
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1423
		/// </summary>
		/// <param name="file">
		/// (Optional)
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="max_paths">(Optional) Number of paths to consider for suggestion analysis Default: 100</param>
		/// <param name="append">(Optional) Append the results to file, do not overwrite the results file</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_qor_assessment(string file = null, string max_paths = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_qor_assessment [-file <arg>] [-max_paths <arg>] [-append] [-return_string] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_qor_assessment(file, max_paths, append, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Recommend QoR Suggestions
		///
		///
		/// TCL Syntax: report_qor_suggestions [-file <arg>] [-name <arg>] [-append] [-return_string] [-max_strategies <arg>] [-max_paths <arg>] [-no_split] [-report_all_suggestions] [-cells <args>] [-of_objects <args>] [-quiet] [-verbose]
		///
		/// Report design and tool option recommendations related to improving the quality of results (QoR).
		/// The report looks at timing constraints, netlist characteristics, failing timing paths, and congestion
		/// information to determine suggestions that can enhance the QoR. The report can be generated
		/// after synthesis, or after any implementation step, but requires a design to be open.
		/// The report_qor_suggestions command creates QoR suggestion objects related to the
		/// suggestions identified. These suggestion objects can be enabled for use by the Vivado tools to
		/// improve the quality of synthesis and implementation results. Some of these suggestions can be
		/// automatically applied, and some may require more manual intervention to implement design
		/// changes, or write Tcl design constraints.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Suggestion objects can be obtained using the get_qor_suggestions command. The QoR
		/// objects have properties that define what step they are APPLICABLE_FOR, if they are ENABLED
		/// to be used, if they can be automatically applied (AUTO), or what step the suggestions was
		/// GENERATED_AT. A suggestion must be ENABLED and the APPLICABLE_FOR synthesis or
		/// implementation step run in order for a suggestion to be applied to the design.
		/// You can write the suggestions from the design into an RQS file using the
		/// write_qor_suggestions command. After resetting the design flow to the appropriate step,
		/// you can read suggestions back into the design using the read_qor_suggestions command,
		/// and then run the synthesis or implementation step to apply the enabled suggestions.
		/// The recommended method for working with QoR suggestions is:
		/// 1. Run the report to create recommendations (report_qor_suggestions)
		/// 2. Write the suggestions to an RQS file on disk (write_qor_suggestions).
		/// 3. Reset the design to the appropriate step.
		/// 4. Read the RQS file into the design to restore the suggestions (read_qor_suggestions).
		/// 5. Run the synthesis or implementation step to apply the suggestion (synth_design,
		/// opt_design...).
		/// For strategy suggestions, a machine learning based analysis is conducted and the best 3
		/// strategies are reported. This analysis is only conducted on a routed design that has been
		/// implemented with
		/// • either default or explore directives for opt_design and
		/// • either all default or all explore directives for place_design, phys_opt_design, and
		/// route_design commands.
		/// Strategy suggestions do not apply to synthesis. Unlike the non-strategy suggestions, only one
		/// strategy suggestion can be applied to each run.
		/// The recommended method for working with QoR strategy suggestions is:
		/// 1. Run the report to create strategies and other
		/// recommendations(report_qor_suggestions).
		/// 2. Write the suggestions to a directory disk. There is one RQS file per strategy
		/// (write_qor_suggestions -strategy_dir).
		/// 3. Update all the directive settings to -directive RQS for opt_design, place_design,
		/// phys_opt_design, and route_design commands.
		/// 4. For each run, read one RQS file into the design. This will contain the strategy suggestion and
		/// all exported non-strategy suggestions(read_qor_suggestions).
		/// 5. Run the implementation step from the opt_design command to apply the strategy and all
		/// the design suggestions.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example reports suggestions after analyzing the worst 10 paths:
		/// report_qor_suggestions -max_paths 10
		/// This example reports existing suggestions in the design from a prior run of
		/// report_qor_suggestions:
		/// report_qor_suggestions -of_objects [get_qor_suggestions]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1426
		/// </summary>
		/// <param name="file">
		/// (Optional)
		/// Filename to output results to. (send output to console if -file
		/// is not used)
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
		public TTCL report_qor_suggestions(string file = null, string name = null, bool? append = null, bool? return_string = null, string max_strategies = null, string max_paths = null, bool? no_split = null, bool? report_all_suggestions = null, TCLParameterList cells = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_qor_suggestions [-file <arg>] [-name <arg>] [-append] [-return_string] [-max_strategies <arg>] [-max_paths <arg>] [-no_split] [-report_all_suggestions] [-cells <args>] [-of_objects <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_qor_suggestions(file, name, append, return_string, max_strategies, max_paths, no_split, report_all_suggestions, cells, of_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Write QoR Suggestions to the given file
		///
		///
		/// TCL Syntax: write_qor_suggestions [-strategy_dir <arg>] [-tcl_output_dir <arg>] [-force] [-of_objects <args>] [-quiet] [-verbose] <file>
		///
		/// Write the QoR suggestions generated by the report_qor_suggestions command. You can
		/// combine the suggestions from the latest report with suggestions read into the design with
		/// read_qor_suggestions so that you can manage all suggestions in a single RQS file.
		/// To write out specific QoR suggestions, use the -of_objects option. When this is not specified,
		/// all suggestions will be written.
		/// The recommended way to manage suggestions is using RQS objects. However, it is possible to
		/// view and execute the commands using Tcl. Specifying the -tcl_output_dir option writes Tcl
		/// scripts for the automated suggestions that are property based.
		/// Implementation strategies that use machine learning to analyze the design can be generated
		/// running report_qor_suggestions. If you specify the -strategy_dir option, multiple Tcl
		/// files and one RQS file will be written for each strategy. The Tcl files aid integration into project or
		/// non project flows. The main RQS file should not be used as the suggestions are contained in the
		/// run specific files along with strategy information.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// This command returns the name of the output file created when successful, or returns an error if
		/// it fails.
		///
		/// The following example reports QoR suggestions, then writes non-strategy suggestions to the
		/// specified file.
		/// report_qor_suggestions
		/// write_qor_suggestions C:/Data/qor_results.rqs
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The following example reports QoR suggestions, then writes both strategy and non-strategy
		/// suggestions. It will create one RQS file for each strategy suggestion that exists, generating up to
		/// three by default. Into each RQS file, it writes one strategy suggestion and all non-strategy
		/// suggestions. This behavior means that for subsequent runs one RQS file per run is required.
		/// report_qor_suggestions
		/// write_qor_suggestions -strategy_dir C:/Data/strategy_dir C:/Data/
		/// qor_suggestions.rqs
		/// To make use of strategy suggestions, the directive for each implementation command
		/// (opt_design, place_design, phys_opt_design, and route_design) must be set to RQS.
		/// This can be configured automatically in project mode by sourcing the project mode Tcl script
		/// generated for each RQS file in the strategy_dir. There is also a non-project example Tcl script
		/// that demonstrates this requirement.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1883
		/// </summary>
		/// <param name="file">
		/// (Required)
		/// QoR suggestions file Values: A filename with alphanumeric
		/// characters and .rqs extension.
		/// </param>
		/// <param name="strategy_dir">
		/// (Optional)
		/// Directory to create Strategy RQS & TCL files Values: If
		/// passed a directory path, for each strategy suggested one set
		/// of RQS and TCL files will be generated.
		/// </param>
		/// <param name="tcl_output_dir">
		/// (Optional)
		/// Directory to create TCL files Values: TCL files for the QoR
		/// suggestions will be generated in the provided directory.
		/// </param>
		/// <param name="force">(Optional) Overwrite existing suggestions file</param>
		/// <param name="of_objects">(Optional) List of QoR suggestion objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_qor_suggestions(string file, string strategy_dir = null, string tcl_output_dir = null, bool? force = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_qor_suggestions [-strategy_dir <arg>] [-tcl_output_dir <arg>] [-force] [-of_objects <args>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_qor_suggestions(file, strategy_dir, tcl_output_dir, force, of_objects, quiet, verbose));
			return _tcl;
		}
	}
}
