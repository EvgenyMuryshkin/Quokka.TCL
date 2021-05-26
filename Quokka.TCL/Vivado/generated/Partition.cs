#pragma warning disable IDE1006 // Naming Styles
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
		/// <para>
		/// Create new PartitionDef<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_partition_def -name &lt;arg&gt; -module &lt;arg&gt; [-library &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// IMPORTANT! You must first define the project as a Partial Reconfiguration (PR) project by setting the<br/>
		/// PR_FLOW property on the project to TRUE, or by using the Tools → Enable Partial Reconfiguration<br/>
		/// command.<br/>
		/// The Partial Reconfiguration flow lets you create Partition Definitions (partitionDefs) from<br/>
		/// hierarchical cells in a design, and to specify reconfigurable modules (RMs) to be assigned to these<br/>
		/// partitionDefs to create a unique configurations of the design based on the combination of the<br/>
		/// core design and one or more RMs. The PR design flow requires the implementation of each PR<br/>
		/// configuration, resulting in partial bitstreams for the RMs, but complete bitstreams for each<br/>
		/// integrated configuration. Refer to the Vivado Design Suite User Guide: Dynamic Function eXchange<br/>
		/// (UG909) for more information.<br/>
		/// The create_partition_def command defines a partitionDef object in a PR project from a<br/>
		/// specified hierarchical cell. The partitionDef defines a partition hierarchy that RMs can be<br/>
		/// assigned to for a specific PR configuration.<br/>
		/// This command returns the name of the newly created partitionDef, or returns an error if the<br/>
		/// command fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 325<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of the PartitionDef</param>
		/// <param name="module">(Required) Module name of the PartitionDef</param>
		/// <param name="library">(Optional) Library name of the module of PartitionDef</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_partition_def(String name, String module, String library = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_partition_def -name <arg> -module <arg> [-library <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_partition_def(name, module, library, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create new Configuration<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_pr_configuration -name &lt;arg&gt; [-partitions &lt;args&gt;] [-greyboxes &lt;args&gt;] [-use_netlist] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// IMPORTANT! You must first define the project as a Partial Reconfiguration (PR) project by setting the<br/>
		/// PR_FLOW property on the project to TRUE, or by using the Tools → Enable Partial Reconfiguration<br/>
		/// command.<br/>
		/// The Partial Reconfiguration flow lets you create Partition Definitions (partitionDefs) from<br/>
		/// hierarchical cells in a design, and to specify reconfigurable modules (RMs) to be assigned to these<br/>
		/// partitionDefs to create unique configurations of the design based on the combination of the core<br/>
		/// design and one or more RMs. The PR design flow requires the implementation of each PR<br/>
		/// configuration, resulting in partial bitstreams for the RMs, but complete bitstreams for each<br/>
		/// integrated configuration. Refer to the Vivado Design Suite User Guide: Dynamic Function eXchange<br/>
		/// (UG909) for more information.<br/>
		/// The create_pr_configuration command defines the combination of the static logic and<br/>
		/// the RM to create a unique configuration of the design. The PR configuration is the design that is<br/>
		/// implemented and the bitstream is generated for.<br/>
		/// You will also need to create implementation runs for the PR configuration using the<br/>
		/// create_run -pr_config command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns the name of the newly created PR configuration, or returns an error if the<br/>
		/// command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 340<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of the Configuration</param>
		/// <param name="partitions">(Optional) List of partition instances and reconfig modules pairs</param>
		/// <param name="greyboxes">(Optional) List of instances to which buffers need to be inserted for all ports</param>
		/// <param name="use_netlist">
		/// <para>
		/// (Optional)<br/>
		/// Use netlist for getting instances of partition_defs to creating<br/>
		/// configurations<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_pr_configuration(String name, TCLParameterList partitions = null, TCLParameterList greyboxes = null, bool? use_netlist = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_pr_configuration -name <arg> [-partitions <args>] [-greyboxes <args>] [-use_netlist] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_pr_configuration(name, partitions, greyboxes, use_netlist, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create new reconfig Module<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_reconfig_module -name &lt;arg&gt; [-top &lt;arg&gt;] [-gate_level] -partition_def &lt;arg&gt; [-define_from &lt;arg&gt;] [-define_from_file &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// IMPORTANT! You must first define the project as a Partial Reconfiguration (PR) project by setting the<br/>
		/// PR_FLOW property on the project to TRUE, or by using the Tools → Enable Partial Reconfiguration<br/>
		/// command.<br/>
		/// The create_reconfig_module command defines an reconfigurable module (RM) from a<br/>
		/// specified hierarchical cell, or design file, and assigns it to the specified Partition Definition<br/>
		/// (partitionDef) in the current project.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The Partial Reconfiguration flow allows RMs to be swapped into and out of a partitionDef to<br/>
		/// create a unique configuration of the design based on the combination of the core design and an<br/>
		/// RM. A single partitionDef can have multiple RMs to contain different netlists, constraints, or<br/>
		/// implementations. Each instance of the partitionDef in the design can be assigned a different RM<br/>
		/// to support many different configurations. The PR design flow requires the implementation of<br/>
		/// each PR configuration, resulting in partial bitstreams for the RMs, but complete bitstreams for<br/>
		/// each integrated configuration. Refer to the Vivado Design Suite User Guide: Dynamic Function<br/>
		/// eXchange (UG909) for more information.<br/>
		/// This command returns the hierarchical name of the newly created RM, or returns an error if the<br/>
		/// command failed.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The example below creates a reconfigurable module with the specified name:<br/>
		/// create_reconfig_module -name fftBottom -partition_def \<br/>
		/// [get_partition_defs partDef1 ] -top fftTop<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 350<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of the Reconfig Module</param>
		/// <param name="partition_def">(Required) PartitionDef in which reconfig module will be created</param>
		/// <param name="top">(Optional) module name of the top module</param>
		/// <param name="gate_level">(Optional) Create Reconfig Module whcih alllows adding DCP/EDIF files only</param>
		/// <param name="define_from">(Optional) Name of the module in the source fileset to be the top of the blockset</param>
		/// <param name="define_from_file">
		/// <para>
		/// (Optional)<br/>
		/// full path of the top source file in the source fileset for which<br/>
		/// reconfigurable module to be created.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_reconfig_module(String name, String partition_def, String top = null, bool? gate_level = null, String define_from = null, String define_from_file = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_reconfig_module -name <arg> [-top <arg>] [-gate_level] -partition_def <arg> [-define_from <arg>] [-define_from_file <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_reconfig_module(name, partition_def, top, gate_level, define_from, define_from_file, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of PartitionDefs<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_pr_configuration [-quiet] [-verbose] [&lt;config&gt;...]
		/// <br/>
		/// <para>
		/// Get or set the current PR configuration.<br/>
		/// In the Partial Reconfiguration (PR) design flow, the PR configuration lets you specify a<br/>
		/// reconfigurable module (RM) to assign to a specific instance of a Partition Definition<br/>
		/// (partitionDef). This flow lets you create unique configurations of the design based on the<br/>
		/// combination of the core design and one or more RMs. The PR design flow requires the<br/>
		/// implementation of each PR configuration, resulting in partial bitstreams for the RMs, but<br/>
		/// complete bitstreams for each integrated configuration. Refer to the Vivado Design Suite User<br/>
		/// Guide: Dynamic Function eXchange (UG909) for more information.<br/>
		/// The current_pr_configuration either returns the PR configuration that is the current or active<br/>
		/// configfuration in the design, or lets you specify a PR configuration to make active.<br/>
		/// This command returns the name of the current PR configuration, or returns an error if the<br/>
		/// command fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 409<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="config">(Optional) Specify the PR configuration to be set as current (active); optional</param>
		/// <returns>list of PartitionDef objects</returns>
		public TTCL current_pr_configuration(bool? quiet = null, bool? verbose = null, TCLObjectList config = null)
		{
			// TCL Syntax: current_pr_configuration [-quiet] [-verbose] [<config>...]
			_tcl.Entry(_builder.current_pr_configuration(quiet, verbose, config));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Delete existing PartitionDefs<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_partition_defs [-merge &lt;arg&gt;] [-quiet] [-verbose] &lt;partition_defs&gt;
		/// <br/>
		/// <para>
		/// Delete the specified Partition Definition (partitionDef) objects from the current project.<br/>
		/// This command returns a transcript of the file merge process, returns nothing without file merge,<br/>
		/// or returns an error if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 461<br/>
		/// </para>
		/// </summary>
		/// <param name="partition_defs">(Required) List of PartitionDefs to delete</param>
		/// <param name="merge">
		/// <para>
		/// (Optional)<br/>
		/// Fileset to merge files into from the default RM of deleted<br/>
		/// Partition Def<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_partition_defs(TCLObject partition_defs, String merge = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_partition_defs [-merge <arg>] [-quiet] [-verbose] <partition_defs>
			_tcl.Entry(_builder.delete_partition_defs(partition_defs, merge, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Delete existing configurations<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_pr_configurations [-quiet] [-verbose] &lt;configs&gt;
		/// <br/>
		/// <para>
		/// Delete the specified PR configuration from the current project.<br/>
		/// This command returns nothing if successful, or returns an error if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 468<br/>
		/// </para>
		/// </summary>
		/// <param name="configs">(Required) List of Configurations to delete</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_pr_configurations(TCLObject configs, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_pr_configurations [-quiet] [-verbose] <configs>
			_tcl.Entry(_builder.delete_pr_configurations(configs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Delete existing reconfig modules<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_reconfig_modules [-merge &lt;arg&gt;] [-quiet] [-verbose] &lt;rms&gt;
		/// <br/>
		/// <para>
		/// Delete the specified reconfigurable modules (RMs) from the current project.<br/>
		/// This command returns nothing if successful, or returns an error if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 472<br/>
		/// </para>
		/// </summary>
		/// <param name="rms">(Required) List of Reconfig Modules to delete</param>
		/// <param name="merge">(Optional) Fileset to merge files into from the deleted Reconfig Module</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_reconfig_modules(TCLObject rms, String merge = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_reconfig_modules [-merge <arg>] [-quiet] [-verbose] <rms>
			_tcl.Entry(_builder.delete_reconfig_modules(rms, merge, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of PartitionDefs<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_partition_defs [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// IMPORTANT! You must first define the project as a Partial Reconfiguration (PR) project by setting the<br/>
		/// PR_FLOW property on the project to TRUE, or by using the Tools → Enable Partial Reconfiguration<br/>
		/// command.<br/>
		/// Get a list of all Partition Definition (partitionDef) objects in the current design, or the<br/>
		/// partitionDefs that match a specified search pattern.<br/>
		/// The Partial Reconfiguration flow lets you create Partition Definitions (partitionDefs) from<br/>
		/// hierarchical cells in a design, and to specify reconfigurable modules (RMs) to be assigned to these<br/>
		/// partitionDefs to create a unique configurations of the design based on the combination of the<br/>
		/// core design and one or more RMs. The PR design flow requires the implementation of each PR<br/>
		/// configuration, resulting in partial bitstreams for the RMs, but complete bitstreams for each<br/>
		/// integrated configuration. Refer to the Vivado Design Suite User Guide: Dynamic Function eXchange<br/>
		/// (UG909) for more information.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns a list of partitionDef objects, or returns an error if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 860<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match partition definition names against patterns Default: *</param>
		/// <returns>list of PartitionDef objects</returns>
		public TTCL get_partition_defs(bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_partition_defs [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_partition_defs(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of partition configurations<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_pr_configurations [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Get a list of PR configuration objects in the current project.<br/>
		/// In the Partial Reconfiguration (PR) design flow, the PR configuration lets you specify a<br/>
		/// reconfigurable module (RM) to assign to a specific instance of a Partition Definition<br/>
		/// (partitionDef). This flow lets you create unique configurations of the design based on the<br/>
		/// combination of the core design and one or more RMs. The PR design flow requires the<br/>
		/// implementation of each PR configuration, resulting in partial bitstreams for the RMs, but<br/>
		/// complete bitstreams for each integrated configuration. Refer to the Vivado Design Suite User<br/>
		/// Guide: Dynamic Function eXchange (UG909) for more information.<br/>
		/// This command returns a list of PR configuration objects, or returns an error if the command fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 892<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match partition configuration names against patterns Default: *</param>
		/// <returns>list of Configuration objects</returns>
		public TTCL get_pr_configurations(bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_pr_configurations [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pr_configurations(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of ReconfigModules<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_reconfig_modules [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Get a list of reconfigurable modules (RMs) in the current design that match a specified search<br/>
		/// pattern. The default command returns a list of all RMs in the current project.<br/>
		/// This command returns a list of RM objects, or returns an error if the command fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 906<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'reconfig_module' objects of these types: 'partition_def'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match reconfigurable module names against patterns Default: *</param>
		/// <returns>list of ReconfigModule objects</returns>
		public TTCL get_reconfig_modules(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_reconfig_modules [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_reconfig_modules(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Creates minimum PR Configurations and Child Impl runs automatically based on the combination<br/>
		/// of Partition Instances and RMs<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: setup_pr_configurations [-partitions &lt;args&gt;] [-use_netlist] [-force] [-run &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Automatically creates the minimum PR configurations and child implementation runs based on<br/>
		/// the combination of Partition Instances and Reconfigurable Modules.<br/>
		/// In the Partial Reconfiguration (PR) design flow, the PR configuration lets you specify a<br/>
		/// reconfigurable module (RM) to assign to a specific instance of a Partition Definition<br/>
		/// (partitionDef). This flow lets you create unique configurations of the design based on the<br/>
		/// combination of the core design and one or more RMs. The PR design flow requires the<br/>
		/// implementation of each PR configuration, resulting in partial bitstreams for the RMs, but<br/>
		/// complete bitstreams for each integrated configuration. Refer to the Vivado Design Suite User<br/>
		/// Guide: Dynamic Function eXchange (UG909) for more information.<br/>
		/// This command is designed to work automatically to create the needed PR configurations and<br/>
		/// implementation runs for those configurations.<br/>
		/// This command returns nothing if successful, or returns an error if the command fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1704<br/>
		/// </para>
		/// </summary>
		/// <param name="partitions">(Optional) List of partition instances and reconfig modules pairs</param>
		/// <param name="use_netlist">
		/// <para>
		/// (Optional)<br/>
		/// Use netlist for getting instances of partition_defs to creating<br/>
		/// PR Configurations<br/>
		/// </para>
		/// </param>
		/// <param name="force">
		/// <para>
		/// (Optional)<br/>
		/// Using force deletes active parent impl run's PR<br/>
		/// Configuration and it's child runs and PR Configurations, and<br/>
		/// then creates new PR Configurations and runs<br/>
		/// </para>
		/// </param>
		/// <param name="run">
		/// <para>
		/// (Optional)<br/>
		/// Parent impl run to which child impl runs and PR<br/>
		/// Configurations need to be created<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL setup_pr_configurations(TCLParameterList partitions = null, bool? use_netlist = null, bool? force = null, String run = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: setup_pr_configurations [-partitions <args>] [-use_netlist] [-force] [-run <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.setup_pr_configurations(partitions, use_netlist, force, run, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
