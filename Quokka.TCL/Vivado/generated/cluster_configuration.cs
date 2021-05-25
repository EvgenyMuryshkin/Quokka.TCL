#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class cluster_configurationCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public cluster_configurationCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// <para>
		/// Creates a cluster configuration<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_cluster_configuration -submit_cmd &lt;arg&gt; -kill_cmd &lt;arg&gt; -type &lt;arg&gt; [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Creates cluster configuration to be used for launching runs (synthesis and implementation).<br/>
		/// Cluster configuration is defined using name, submit command, kill command and type.<br/>
		/// Cluster configuration allows user to create configurations for different clusters and are persisted<br/>
		/// in Vivado tool settings. So user has to create cluster configuration just once and use whenever<br/>
		/// required.<br/>
		/// Currently, Vivado supports following clusters management tools.<br/>
		/// • Load Sharing Facility (LSF)<br/>
		/// • Sun Grid Engine (SGE)<br/>
		/// • Simple Linux Utility For Resource Management (SLURM)<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a cluster configuration named lsf_cluster_1 of type LSF. The<br/>
		/// submit command is bsub and the kill command is bkill.<br/>
		/// create_cluster_configuration lsf_cluster_1 bsub bkill LSF<br/>
		/// The following example creates a cluster configuration named lsf_medium of type LSF. The submit<br/>
		/// command is bsub with resource requirement string which looks for 64bit linux os with either<br/>
		/// rhel or centos distro and version of the os is 7 and the jobs will be submitted to medium queue.<br/>
		/// The kill command is bkill.<br/>
		/// create_cluster_configuration lsf_medium {bsub -R "select[os == lin &amp;&amp; type<br/>
		/// == X86_64 &amp;&amp; (osdistro == rhel || osdistro == centos) &amp;&amp; (osver == ws7)]" -<br/>
		/// N -q medium} bkill LSF<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example creates a cluster configuration named sge_conf of type SGE. The submit<br/>
		/// command is qsub and the kill command is qdel.<br/>
		/// create_cluster_configuration sge_conf qsub qdel SGE<br/>
		/// The following example creates a cluster configuration named slurm_conf of type SLURM. The<br/>
		/// submit command is sbatch and the kill command is scancel.<br/>
		/// create_cluster_configuration slurm_conf sbatch scancel SLURM<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 250<br/>
		/// </para>
		/// </summary>
		/// <param name="submit_cmd">(Required) Submit command of cluster configuration</param>
		/// <param name="kill_cmd">(Required) Kill command of cluster configuration</param>
		/// <param name="type">(Required) Type of cluster configuration</param>
		/// <param name="name">(Required) Name of cluster configuration</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_cluster_configuration(String submit_cmd, String kill_cmd, String type, String name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_cluster_configuration -submit_cmd <arg> -kill_cmd <arg> -type <arg> [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_cluster_configuration(submit_cmd, kill_cmd, type, name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Returns all cluster configuration objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_cluster_configurations [-filter &lt;arg&gt;] [-regexp] [-nocase] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of cluster configurations that includes Vivado default cluster configurations and cluster<br/>
		/// configurations created using the create_cluster_configuration command.<br/>
		/// Vivado supports the following cluster management tools.<br/>
		/// • Load Sharing Facility (LSF)<br/>
		/// • Sun Grid Engine (SGE)<br/>
		/// • Simple Linux Utility For Resource Management (SLURM)<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets the list of all cluster configurations.<br/>
		/// get_cluster_configurations<br/>
		/// The following example gets the cluster configuration with name 'lsf'.<br/>
		/// get_cluster_configurations lsf<br/>
		/// The following example gets the list of all default cluster configurations.<br/>
		/// get_cluster_configurations -filter {IS_DEFAULT}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 664<br/>
		/// </para>
		/// </summary>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match cluster configuration against patterns Default: *</param>
		public TTCL get_cluster_configurations(String filter = null, bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_cluster_configurations [-filter <arg>] [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_cluster_configurations(filter, regexp, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Removes list of cluster configurations<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_cluster_configurations [-quiet] [-verbose] &lt;cluster_configurations&gt;
		/// <br/>
		/// <para>
		/// Removes a list of cluster configurations. The list of cluster configurations to be removed is<br/>
		/// specified as input. This command can only remove user defined cluster configurations and cannot<br/>
		/// remove Vivado default cluster configurations. To identify if a cluster configuration is default or<br/>
		/// user-defined, use the following snippet:<br/>
		/// # if it returns 1 cluster configuration is Vivado default otherwise user<br/>
		/// defined.<br/>
		/// get_property IS_DEFAULT [get_cluster_configurations &lt;cluster configuration<br/>
		/// name&gt;]<br/>
		/// Currently, Vivado supports following clusters management tools:<br/>
		/// • Load Sharing Facility (LSF)<br/>
		/// • Sun Grid Engine (SGE)<br/>
		/// • Simple Linux Utility For Resource Management (SLURM)<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example removes the cluster configuration with name lsf_medium.<br/>
		/// remove_cluster_configurations [get_cluster_configurations lsf_medium]<br/>
		/// The following example removes all the user defined cluster configurations.<br/>
		/// remove_cluster_configurations [get_cluster_configurations -filter<br/>
		/// {IS_DEFAULT == 0}]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1239<br/>
		/// </para>
		/// </summary>
		/// <param name="cluster_configurations">(Required) List of cluster configurations</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_cluster_configurations(String cluster_configurations, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_cluster_configurations [-quiet] [-verbose] <cluster_configurations>
			_tcl.Entry(_builder.remove_cluster_configurations(cluster_configurations, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Validate list of cluster configurations<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: validate_cluster_configurations [-quiet] [-verbose] &lt;cluster_configurations&gt;
		/// <br/>
		/// <para>
		/// Validates the list of cluster configurations provided as an input. Use the<br/>
		/// get_cluster_configurations command to get a list of cluster configurations.<br/>
		/// validate_cluster_configurations validates the submit and kill command of the cluster<br/>
		/// configuration objects to ensure if a job can be submitted using a particular cluster configuration<br/>
		/// or not.<br/>
		/// Currently, Vivado supports following clusters management tools.<br/>
		/// • Load Sharing Facility (LSF)<br/>
		/// • Sun Grid Engine (SGE)<br/>
		/// • Simple Linux Utility For Resource Management (SLURM)<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example validates all the user defined cluster configurations.<br/>
		/// validate_cluster_configurations [get_cluster_configurations -filter<br/>
		/// {IS_DEFAULT == 0}]<br/>
		/// The following example validates a cluster configuration named lsf_medium.<br/>
		/// validate_cluster_configurations [get_cluster_configurations lsf_medium]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1797<br/>
		/// </para>
		/// </summary>
		/// <param name="cluster_configurations">(Required) List of cluster configurations</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL validate_cluster_configurations(String cluster_configurations, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: validate_cluster_configurations [-quiet] [-verbose] <cluster_configurations>
			_tcl.Entry(_builder.validate_cluster_configurations(cluster_configurations, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
