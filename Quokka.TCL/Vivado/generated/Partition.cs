// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class PartitionCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public PartitionCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// Create new PartitionDef
		///
		///
		/// TCL Syntax: create_partition_def -name <arg> -module <arg> [-library <arg>] [-quiet] [-verbose]
		///
		/// IMPORTANT! You must first define the project as a Partial Reconfiguration (PR) project by setting the
		/// PR_FLOW property on the project to TRUE, or by using the Tools → Enable Partial Reconfiguration
		/// command.
		/// The Partial Reconfiguration flow lets you create Partition Definitions (partitionDefs) from
		/// hierarchical cells in a design, and to specify reconfigurable modules (RMs) to be assigned to these
		/// partitionDefs to create a unique configurations of the design based on the combination of the
		/// core design and one or more RMs. The PR design flow requires the implementation of each PR
		/// configuration, resulting in partial bitstreams for the RMs, but complete bitstreams for each
		/// integrated configuration. Refer to the Vivado Design Suite User Guide: Dynamic Function eXchange
		/// (UG909) for more information.
		/// The create_partition_def command defines a partitionDef object in a PR project from a
		/// specified hierarchical cell. The partitionDef defines a partition hierarchy that RMs can be
		/// assigned to for a specific PR configuration.
		/// This command returns the name of the newly created partitionDef, or returns an error if the
		/// command fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 325
		/// </summary>
		/// <param name="name">(Required) Name of the PartitionDef</param>
		/// <param name="module">(Required) Module name of the PartitionDef</param>
		/// <param name="library">(Optional) Library name of the module of PartitionDef</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_partition_def(string name, string module, string library = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_partition_def -name <arg> -module <arg> [-library <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_partition_def(name, module, library, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Create new Configuration
		///
		///
		/// TCL Syntax: create_pr_configuration -name <arg> [-partitions <args>] [-greyboxes <args>] [-use_netlist] [-quiet] [-verbose]
		///
		/// IMPORTANT! You must first define the project as a Partial Reconfiguration (PR) project by setting the
		/// PR_FLOW property on the project to TRUE, or by using the Tools → Enable Partial Reconfiguration
		/// command.
		/// The Partial Reconfiguration flow lets you create Partition Definitions (partitionDefs) from
		/// hierarchical cells in a design, and to specify reconfigurable modules (RMs) to be assigned to these
		/// partitionDefs to create unique configurations of the design based on the combination of the core
		/// design and one or more RMs. The PR design flow requires the implementation of each PR
		/// configuration, resulting in partial bitstreams for the RMs, but complete bitstreams for each
		/// integrated configuration. Refer to the Vivado Design Suite User Guide: Dynamic Function eXchange
		/// (UG909) for more information.
		/// The create_pr_configuration command defines the combination of the static logic and
		/// the RM to create a unique configuration of the design. The PR configuration is the design that is
		/// implemented and the bitstream is generated for.
		/// You will also need to create implementation runs for the PR configuration using the
		/// create_run -pr_config command.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// This command returns the name of the newly created PR configuration, or returns an error if the
		/// command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 340
		/// </summary>
		/// <param name="name">(Required) Name of the Configuration</param>
		/// <param name="partitions">(Optional) List of partition instances and reconfig modules pairs</param>
		/// <param name="greyboxes">(Optional) List of instances to which buffers need to be inserted for all ports</param>
		/// <param name="use_netlist">
		/// (Optional)
		/// Use netlist for getting instances of partition_defs to creating
		/// configurations
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_pr_configuration(string name, TCLParameterList partitions = null, TCLParameterList greyboxes = null, bool? use_netlist = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_pr_configuration -name <arg> [-partitions <args>] [-greyboxes <args>] [-use_netlist] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_pr_configuration(name, partitions, greyboxes, use_netlist, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Create new reconfig Module
		///
		///
		/// TCL Syntax: create_reconfig_module -name <arg> [-top <arg>] [-gate_level] -partition_def <arg> [-define_from <arg>] [-define_from_file <arg>] [-quiet] [-verbose]
		///
		/// IMPORTANT! You must first define the project as a Partial Reconfiguration (PR) project by setting the
		/// PR_FLOW property on the project to TRUE, or by using the Tools → Enable Partial Reconfiguration
		/// command.
		/// The create_reconfig_module command defines an reconfigurable module (RM) from a
		/// specified hierarchical cell, or design file, and assigns it to the specified Partition Definition
		/// (partitionDef) in the current project.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The Partial Reconfiguration flow allows RMs to be swapped into and out of a partitionDef to
		/// create a unique configuration of the design based on the combination of the core design and an
		/// RM. A single partitionDef can have multiple RMs to contain different netlists, constraints, or
		/// implementations. Each instance of the partitionDef in the design can be assigned a different RM
		/// to support many different configurations. The PR design flow requires the implementation of
		/// each PR configuration, resulting in partial bitstreams for the RMs, but complete bitstreams for
		/// each integrated configuration. Refer to the Vivado Design Suite User Guide: Dynamic Function
		/// eXchange (UG909) for more information.
		/// This command returns the hierarchical name of the newly created RM, or returns an error if the
		/// command failed.
		///
		/// The example below creates a reconfigurable module with the specified name:
		/// create_reconfig_module -name fftBottom -partition_def \
		/// [get_partition_defs partDef1 ] -top fftTop
		///
		/// See ug835-vivado-tcl-commands.pdf, page 350
		/// </summary>
		/// <param name="name">(Required) Name of the Reconfig Module</param>
		/// <param name="partition_def">(Required) PartitionDef in which reconfig module will be created</param>
		/// <param name="top">(Optional) module name of the top module</param>
		/// <param name="gate_level">(Optional) Create Reconfig Module whcih alllows adding DCP/EDIF files only</param>
		/// <param name="define_from">(Optional) Name of the module in the source fileset to be the top of the blockset</param>
		/// <param name="define_from_file">
		/// (Optional)
		/// full path of the top source file in the source fileset for which
		/// reconfigurable module to be created.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_reconfig_module(string name, string partition_def, string top = null, bool? gate_level = null, string define_from = null, string define_from_file = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_reconfig_module -name <arg> [-top <arg>] [-gate_level] -partition_def <arg> [-define_from <arg>] [-define_from_file <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_reconfig_module(name, partition_def, top, gate_level, define_from, define_from_file, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of PartitionDefs
		///
		///
		/// TCL Syntax: current_pr_configuration [-quiet] [-verbose] [<config>...]
		///
		/// Get or set the current PR configuration.
		/// In the Partial Reconfiguration (PR) design flow, the PR configuration lets you specify a
		/// reconfigurable module (RM) to assign to a specific instance of a Partition Definition
		/// (partitionDef). This flow lets you create unique configurations of the design based on the
		/// combination of the core design and one or more RMs. The PR design flow requires the
		/// implementation of each PR configuration, resulting in partial bitstreams for the RMs, but
		/// complete bitstreams for each integrated configuration. Refer to the Vivado Design Suite User
		/// Guide: Dynamic Function eXchange (UG909) for more information.
		/// The current_pr_configuration either returns the PR configuration that is the current or active
		/// configfuration in the design, or lets you specify a PR configuration to make active.
		/// This command returns the name of the current PR configuration, or returns an error if the
		/// command fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 409
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="config">(Optional) Specify the PR configuration to be set as current (active); optional</param>
		/// <returns>list of PartitionDef objects</returns>
		public TTCL current_pr_configuration(bool? quiet = null, bool? verbose = null, TCLParameterList config = null)
		{
			// TCL Syntax: current_pr_configuration [-quiet] [-verbose] [<config>...]
			_tcl.Entry(_builder.current_pr_configuration(quiet, verbose, config));
			return _tcl;
		}
		/// <summary>
		/// Delete existing PartitionDefs
		///
		///
		/// TCL Syntax: delete_partition_defs [-merge <arg>] [-quiet] [-verbose] <partition_defs>
		///
		/// Delete the specified Partition Definition (partitionDef) objects from the current project.
		/// This command returns a transcript of the file merge process, returns nothing without file merge,
		/// or returns an error if the command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 461
		/// </summary>
		/// <param name="partition_defs">(Required) List of PartitionDefs to delete</param>
		/// <param name="merge">
		/// (Optional)
		/// Fileset to merge files into from the default RM of deleted
		/// Partition Def
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_partition_defs(string partition_defs, string merge = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_partition_defs [-merge <arg>] [-quiet] [-verbose] <partition_defs>
			_tcl.Entry(_builder.delete_partition_defs(partition_defs, merge, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Delete existing configurations
		///
		///
		/// TCL Syntax: delete_pr_configurations [-quiet] [-verbose] <configs>
		///
		/// Delete the specified PR configuration from the current project.
		/// This command returns nothing if successful, or returns an error if the command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 468
		/// </summary>
		/// <param name="configs">(Required) List of Configurations to delete</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_pr_configurations(string configs, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_pr_configurations [-quiet] [-verbose] <configs>
			_tcl.Entry(_builder.delete_pr_configurations(configs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Delete existing reconfig modules
		///
		///
		/// TCL Syntax: delete_reconfig_modules [-merge <arg>] [-quiet] [-verbose] <rms>
		///
		/// Delete the specified reconfigurable modules (RMs) from the current project.
		/// This command returns nothing if successful, or returns an error if the command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 472
		/// </summary>
		/// <param name="rms">(Required) List of Reconfig Modules to delete</param>
		/// <param name="merge">(Optional) Fileset to merge files into from the deleted Reconfig Module</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_reconfig_modules(string rms, string merge = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_reconfig_modules [-merge <arg>] [-quiet] [-verbose] <rms>
			_tcl.Entry(_builder.delete_reconfig_modules(rms, merge, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of PartitionDefs
		///
		///
		/// TCL Syntax: get_partition_defs [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// IMPORTANT! You must first define the project as a Partial Reconfiguration (PR) project by setting the
		/// PR_FLOW property on the project to TRUE, or by using the Tools → Enable Partial Reconfiguration
		/// command.
		/// Get a list of all Partition Definition (partitionDef) objects in the current design, or the
		/// partitionDefs that match a specified search pattern.
		/// The Partial Reconfiguration flow lets you create Partition Definitions (partitionDefs) from
		/// hierarchical cells in a design, and to specify reconfigurable modules (RMs) to be assigned to these
		/// partitionDefs to create a unique configurations of the design based on the combination of the
		/// core design and one or more RMs. The PR design flow requires the implementation of each PR
		/// configuration, resulting in partial bitstreams for the RMs, but complete bitstreams for each
		/// integrated configuration. Refer to the Vivado Design Suite User Guide: Dynamic Function eXchange
		/// (UG909) for more information.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// This command returns a list of partitionDef objects, or returns an error if the command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 860
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match partition definition names against patterns Default: *</param>
		/// <returns>list of PartitionDef objects</returns>
		public TTCL get_partition_defs(bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_partition_defs [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_partition_defs(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of partition configurations
		///
		///
		/// TCL Syntax: get_pr_configurations [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Get a list of PR configuration objects in the current project.
		/// In the Partial Reconfiguration (PR) design flow, the PR configuration lets you specify a
		/// reconfigurable module (RM) to assign to a specific instance of a Partition Definition
		/// (partitionDef). This flow lets you create unique configurations of the design based on the
		/// combination of the core design and one or more RMs. The PR design flow requires the
		/// implementation of each PR configuration, resulting in partial bitstreams for the RMs, but
		/// complete bitstreams for each integrated configuration. Refer to the Vivado Design Suite User
		/// Guide: Dynamic Function eXchange (UG909) for more information.
		/// This command returns a list of PR configuration objects, or returns an error if the command fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 892
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match partition configuration names against patterns Default: *</param>
		/// <returns>list of Configuration objects</returns>
		public TTCL get_pr_configurations(bool? regexp = null, bool? nocase = null, string filter = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_pr_configurations [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pr_configurations(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of ReconfigModules
		///
		///
		/// TCL Syntax: get_reconfig_modules [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Get a list of reconfigurable modules (RMs) in the current design that match a specified search
		/// pattern. The default command returns a list of all RMs in the current project.
		/// This command returns a list of RM objects, or returns an error if the command fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 906
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'reconfig_module' objects of these types: 'partition_def'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match reconfigurable module names against patterns Default: *</param>
		/// <returns>list of ReconfigModule objects</returns>
		public TTCL get_reconfig_modules(bool? regexp = null, bool? nocase = null, string filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_reconfig_modules [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_reconfig_modules(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Creates minimum PR Configurations and Child Impl runs automatically based on the combination
		/// of Partition Instances and RMs
		///
		///
		/// TCL Syntax: setup_pr_configurations [-partitions <args>] [-use_netlist] [-force] [-run <arg>] [-quiet] [-verbose]
		///
		/// Automatically creates the minimum PR configurations and child implementation runs based on
		/// the combination of Partition Instances and Reconfigurable Modules.
		/// In the Partial Reconfiguration (PR) design flow, the PR configuration lets you specify a
		/// reconfigurable module (RM) to assign to a specific instance of a Partition Definition
		/// (partitionDef). This flow lets you create unique configurations of the design based on the
		/// combination of the core design and one or more RMs. The PR design flow requires the
		/// implementation of each PR configuration, resulting in partial bitstreams for the RMs, but
		/// complete bitstreams for each integrated configuration. Refer to the Vivado Design Suite User
		/// Guide: Dynamic Function eXchange (UG909) for more information.
		/// This command is designed to work automatically to create the needed PR configurations and
		/// implementation runs for those configurations.
		/// This command returns nothing if successful, or returns an error if the command fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1704
		/// </summary>
		/// <param name="partitions">(Optional) List of partition instances and reconfig modules pairs</param>
		/// <param name="use_netlist">
		/// (Optional)
		/// Use netlist for getting instances of partition_defs to creating
		/// PR Configurations
		/// </param>
		/// <param name="force">
		/// (Optional)
		/// Using force deletes active parent impl run's PR
		/// Configuration and it's child runs and PR Configurations, and
		/// then creates new PR Configurations and runs
		/// </param>
		/// <param name="run">
		/// (Optional)
		/// Parent impl run to which child impl runs and PR
		/// Configurations need to be created
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL setup_pr_configurations(TCLParameterList partitions = null, bool? use_netlist = null, bool? force = null, string run = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: setup_pr_configurations [-partitions <args>] [-use_netlist] [-force] [-run <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.setup_pr_configurations(partitions, use_netlist, force, run, quiet, verbose));
			return _tcl;
		}
	}
}
