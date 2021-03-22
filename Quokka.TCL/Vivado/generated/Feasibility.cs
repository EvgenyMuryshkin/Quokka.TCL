// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class FeasibilityCommands
	{
		private readonly QuokkaTCL _tcl;
		public FeasibilityCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Deletes a list of available QoR suggestions
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
		/// See ug835-vivado-tcl-commands.pdf, page 458
		/// </summary>
		/// <param name="IDs">
		/// Required
		/// Match suggestion names against given names
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void delete_qor_suggestions(string IDs, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("delete_qor_suggestions");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("IDs", IDs);
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of available QoR suggestions
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
		/// See ug835-vivado-tcl-commands.pdf, page 883
		/// </summary>
		/// <param name="filter">
		/// Optional
		/// Filter list with expression
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="IDs">
		/// Optional
		/// Match suggestion names against given names
		/// </param>
		/// <returns>list of qor suggestion objects</returns>
		public void get_qor_suggestions(string filter = null, bool? quiet = null, bool? verbose = null, string IDs = null)
		{
			var command = new SimpleTCLCommand("get_qor_suggestions");
			command.OptionalString("filter", filter);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("IDs", IDs);
			_tcl.Add(command);
		}
		/// <summary>
		/// Read QoR Suggestions from the given file
		///
		/// Read the specified file and extract the QoR suggestions from the file.
		/// This command returns the name of the QoR file read, or returns an error if it fails.
		///
		/// The following example reads the QoR suggestions from the specified file, and then reports the
		/// QoR suggestions in the open design:
		/// read_qor_suggestions C:/Data/qor_results.rqs
		/// report_qor_suggestions -of_objects [get_qor_suggestions]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1153
		/// </summary>
		/// <param name="file">
		/// Required
		/// QoR suggestions file Values: Path to the QoR suggestions
		/// file, typically ending with .rqs.
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void read_qor_suggestions(string file, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("read_qor_suggestions");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("file", file);
			_tcl.Add(command);
		}
		/// <summary>
		/// Feasibility Checks
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
		/// See ug835-vivado-tcl-commands.pdf, page 1392
		/// </summary>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="max_paths">
		/// Optional
		/// Number of paths to consider for suggestion analysis
		/// Default: 100
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, do not overwrite the results file
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void report_qor_assessment(string file = null, string max_paths = null, bool? append = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_qor_assessment");
			command.OptionalString("file", file);
			command.OptionalString("max_paths", max_paths);
			command.Flag("append", append);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			_tcl.Add(command);
		}
		/// <summary>
		/// Recommend QoR Suggestions
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
		/// 2. Look at and ENABLE the suggestions you want to use (get_qor_suggestions)
		/// 3. Write the suggestions to an RQS file on disk (write_qor_suggestions).
		/// 4. Reset the design to the appropriate step.
		/// 5. Read the RQS file into the design to restore the suggestions (read_qor_suggestions).
		/// 6. Run the synthesis or implementation step to apply the suggestion (synth_design,
		/// opt_design...).
		///
		/// The following example reports suggestions after analyzing the worst 10 paths:
		/// report_qor_suggestions -max_paths 10
		/// This example reports existing suggestions in the design from a prior run of
		/// report_qor_suggestions:
		/// report_qor_suggestions -of_objects [get_qor_suggestions]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1395
		/// </summary>
		/// <param name="file">
		/// Optional
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="name">
		/// Optional
		/// Output the results to GUI panel with this name
		/// </param>
		/// <param name="append">
		/// Optional
		/// Append the results to file, don't overwrite the results file
		/// </param>
		/// <param name="return_string">
		/// Optional
		/// Return report as string
		/// </param>
		/// <param name="max_strategies">
		/// Optional
		/// Number of strategies to suggest Default: 3
		/// </param>
		/// <param name="max_paths">
		/// Optional
		/// Number of paths to consider for suggestion analysis
		/// Default: 100
		/// </param>
		/// <param name="evaluate_pipelining">
		/// Optional
		/// Generate DSP/BRAM pipelining xdc file
		/// </param>
		/// <param name="no_split">
		/// Optional
		/// Report without spliting the lines in tables
		/// </param>
		/// <param name="models_dir">
		/// Optional
		/// Path to the directory which consists of the models Default: /
		/// proj/rdi-xco/builds/HEAD/nightly/RUNNING_ BUILD/
		/// packages/customer/vivado/data/deca/models_dir
		/// </param>
		/// <param name="cell">
		/// Optional
		/// Report QOR suggestions for a given cell
		/// </param>
		/// <param name="of_objects">
		/// Optional
		/// List of QoR suggestion objects
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void report_qor_suggestions(string file = null, string name = null, bool? append = null, bool? return_string = null, string max_strategies = null, string max_paths = null, bool? evaluate_pipelining = null, bool? no_split = null, string models_dir = null, string cell = null, string of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("report_qor_suggestions");
			command.OptionalString("file", file);
			command.OptionalString("name", name);
			command.Flag("append", append);
			command.Flag("return_string", return_string);
			command.OptionalString("max_strategies", max_strategies);
			command.OptionalString("max_paths", max_paths);
			command.Flag("evaluate_pipelining", evaluate_pipelining);
			command.Flag("no_split", no_split);
			command.OptionalString("models_dir", models_dir);
			command.OptionalString("cell", cell);
			command.OptionalString("of_objects", of_objects);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			_tcl.Add(command);
		}
		/// <summary>
		/// Write QoR Suggestions to the given file
		///
		/// Write the QoR suggestions generated by the report_qor_suggestions command. You can
		/// combine the suggestions from the latest report with suggestions read into the design with
		/// read_qor_suggestions so that you can manage all suggestions in a single RQS file.
		/// To write out specific QoR suggestions, use the -of_objects option. When this is not specified, all
		/// suggestions will be written.
		/// The recommended way to manage suggestions is using RQS objects. However, it is possible to
		/// view and execute the commands using TCL. Specifying the -tcl_output_dir option writes Tcl
		/// scripts for the automated suggestions that are property based.
		/// Implementation strategies that use machine learning to analyze the design can be generated
		/// running report_qor_suggestions. When specifying the -strategy_dir option. Multiple
		/// TCL files and one RQS file will be written for each strategy. The TCL files aid integration into
		/// project or non project flows. The main RQS file should not be used as the suggestions are
		/// contained in the run specific files along with strategy information.
		/// This command returns the name of the output file created when successful, or returns an error if
		/// it fails.
		///
		/// This example reports QoR suggestions, then writes them to the specified file.
		/// report_qor_suggestions
		/// write_qor_suggestions C:/Data/qor_results.rqs
		/// This example reports QoR suggestions, then writes them to the specified file.
		/// report_qor_suggestions
		/// write_qor_suggestions -strategy_dir C:/Data/strategy_dir C:/Data/
		/// qor_suggestions.rqs
		/// In project mode you must then source the TCL script generated for project mode. There is one
		/// script per run to source. Examples of non project scripts are also given.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1845
		/// </summary>
		/// <param name="file">
		/// Required
		/// QoR suggestions file Values: A filename with alphanumeric
		/// characters and .rqs extension.
		/// </param>
		/// <param name="strategy_dir">
		/// Optional
		/// Directory to create Strategy RQS & TCL files Values: If
		/// passed a directory path, for each strategy suggested one set
		/// of RQS and TCL files will be generated.
		/// </param>
		/// <param name="tcl_output_dir">
		/// Optional
		/// Directory to create TCL files Values: TCL files for the QoR
		/// suggestions will be generated in the provided directory.
		/// </param>
		/// <param name="force">
		/// Optional
		/// Overwrite existing suggestions file
		/// </param>
		/// <param name="of_objects">
		/// Optional
		/// List of QoR suggestion objects
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void write_qor_suggestions(string file, string strategy_dir = null, string tcl_output_dir = null, bool? force = null, string of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("write_qor_suggestions");
			command.OptionalString("strategy_dir", strategy_dir);
			command.OptionalString("tcl_output_dir", tcl_output_dir);
			command.Flag("force", force);
			command.OptionalString("of_objects", of_objects);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("file", file);
			_tcl.Add(command);
		}
	}
}
