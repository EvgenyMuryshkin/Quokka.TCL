// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
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
		/// Creates a cluster configuration
		///
		///
		/// TCL Syntax: create_cluster_configuration -submit_cmd <arg> -kill_cmd <arg> -type <arg> [-quiet] [-verbose] <name>
		///
		/// Creates cluster configuration to be used for launching runs (synthesis and implementation).
		/// Cluster configuration is defined using name, submit command, kill command and type.
		/// Cluster configuration allows user to create configurations for different clusters and are persisted
		/// in Vivado tool settings. So user has to create cluster configuration just once and use whenever
		/// required.
		/// Currently, Vivado supports following clusters management tools.
		/// • Load Sharing Facility (LSF)
		/// • Sun Grid Engine (SGE)
		/// • Simple Linux Utility For Resource Management (SLURM)
		///
		/// The following example creates a cluster configuration named lsf_cluster_1 of type LSF. The
		/// submit command is bsub and the kill command is bkill.
		/// create_cluster_configuration lsf_cluster_1 bsub bkill LSF
		/// The following example creates a cluster configuration named lsf_medium of type LSF. The submit
		/// command is bsub with resource requirement string which looks for 64bit linux os with either
		/// rhel or centos distro and version of the os is 7 and the jobs will be submitted to medium queue.
		/// The kill command is bkill.
		/// create_cluster_configuration lsf_medium {bsub -R "select[os == lin && type
		/// == X86_64 && (osdistro == rhel || osdistro == centos) && (osver == ws7)]" -
		/// N -q medium} bkill LSF
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The following example creates a cluster configuration named sge_conf of type SGE. The submit
		/// command is qsub and the kill command is qdel.
		/// create_cluster_configuration sge_conf qsub qdel SGE
		/// The following example creates a cluster configuration named slurm_conf of type SLURM. The
		/// submit command is sbatch and the kill command is scancel.
		/// create_cluster_configuration slurm_conf sbatch scancel SLURM
		///
		/// See ug835-vivado-tcl-commands.pdf, page 250
		/// </summary>
		/// <param name="submit_cmd">(Required) Submit command of cluster configuration</param>
		/// <param name="kill_cmd">(Required) Kill command of cluster configuration</param>
		/// <param name="type">(Required) Type of cluster configuration</param>
		/// <param name="name">(Required) Name of cluster configuration</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_cluster_configuration(string submit_cmd, string kill_cmd, string type, string name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_cluster_configuration -submit_cmd <arg> -kill_cmd <arg> -type <arg> [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_cluster_configuration(submit_cmd, kill_cmd, type, name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Returns all cluster configuration objects
		///
		///
		/// TCL Syntax: get_cluster_configurations [-filter <arg>] [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
		///
		/// Gets a list of cluster configurations that includes Vivado default cluster configurations and cluster
		/// configurations created using the create_cluster_configuration command.
		/// Vivado supports the following cluster management tools.
		/// • Load Sharing Facility (LSF)
		/// • Sun Grid Engine (SGE)
		/// • Simple Linux Utility For Resource Management (SLURM)
		///
		/// The following example gets the list of all cluster configurations.
		/// get_cluster_configurations
		/// The following example gets the cluster configuration with name 'lsf'.
		/// get_cluster_configurations lsf
		/// The following example gets the list of all default cluster configurations.
		/// get_cluster_configurations -filter {IS_DEFAULT}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 664
		/// </summary>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match cluster configuration against patterns Default: *</param>
		public TTCL get_cluster_configurations(string filter = null, bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			// TCL Syntax: get_cluster_configurations [-filter <arg>] [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_cluster_configurations(filter, regexp, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Removes list of cluster configurations
		///
		///
		/// TCL Syntax: remove_cluster_configurations [-quiet] [-verbose] <cluster_configurations>
		///
		/// Removes a list of cluster configurations. The list of cluster configurations to be removed is
		/// specified as input. This command can only remove user defined cluster configurations and cannot
		/// remove Vivado default cluster configurations. To identify if a cluster configuration is default or
		/// user-defined, use the following snippet:
		/// # if it returns 1 cluster configuration is Vivado default otherwise user
		/// defined.
		/// get_property IS_DEFAULT [get_cluster_configurations <cluster configuration
		/// name>]
		/// Currently, Vivado supports following clusters management tools:
		/// • Load Sharing Facility (LSF)
		/// • Sun Grid Engine (SGE)
		/// • Simple Linux Utility For Resource Management (SLURM)
		///
		/// The following example removes the cluster configuration with name lsf_medium.
		/// remove_cluster_configurations [get_cluster_configurations lsf_medium]
		/// The following example removes all the user defined cluster configurations.
		/// remove_cluster_configurations [get_cluster_configurations -filter
		/// {IS_DEFAULT == 0}]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1239
		/// </summary>
		/// <param name="cluster_configurations">(Required) List of cluster configurations</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_cluster_configurations(string cluster_configurations, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_cluster_configurations [-quiet] [-verbose] <cluster_configurations>
			_tcl.Entry(_builder.remove_cluster_configurations(cluster_configurations, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Validate list of cluster configurations
		///
		///
		/// TCL Syntax: validate_cluster_configurations [-quiet] [-verbose] <cluster_configurations>
		///
		/// Validates the list of cluster configurations provided as an input. Use the
		/// get_cluster_configurations command to get a list of cluster configurations.
		/// validate_cluster_configurations validates the submit and kill command of the cluster
		/// configuration objects to ensure if a job can be submitted using a particular cluster configuration
		/// or not.
		/// Currently, Vivado supports following clusters management tools.
		/// • Load Sharing Facility (LSF)
		/// • Sun Grid Engine (SGE)
		/// • Simple Linux Utility For Resource Management (SLURM)
		///
		/// The following example validates all the user defined cluster configurations.
		/// validate_cluster_configurations [get_cluster_configurations -filter
		/// {IS_DEFAULT == 0}]
		/// The following example validates a cluster configuration named lsf_medium.
		/// validate_cluster_configurations [get_cluster_configurations lsf_medium]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1797
		/// </summary>
		/// <param name="cluster_configurations">(Required) List of cluster configurations</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL validate_cluster_configurations(string cluster_configurations, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: validate_cluster_configurations [-quiet] [-verbose] <cluster_configurations>
			_tcl.Entry(_builder.validate_cluster_configurations(cluster_configurations, quiet, verbose));
			return _tcl;
		}
	}
}
