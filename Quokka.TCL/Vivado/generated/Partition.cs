// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class PartitionCommands
	{
		private readonly QuokkaTCL _tcl;
		public PartitionCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Create new PartitionDef
		/// </summary>
		public void create_partition_def()
		{
			var command = new SimpleTCLCommand("create_partition_def");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create new Configuration
		/// </summary>
		public void create_pr_configuration()
		{
			var command = new SimpleTCLCommand("create_pr_configuration");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create new reconfig Module
		/// </summary>
		public void create_reconfig_module()
		{
			var command = new SimpleTCLCommand("create_reconfig_module");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of PartitionDefs
		/// </summary>
		public void current_pr_configuration()
		{
			var command = new SimpleTCLCommand("current_pr_configuration");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete existing PartitionDefs
		/// </summary>
		public void delete_partition_defs()
		{
			var command = new SimpleTCLCommand("delete_partition_defs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete existing configurations
		/// </summary>
		public void delete_pr_configurations()
		{
			var command = new SimpleTCLCommand("delete_pr_configurations");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete existing reconfig modules
		/// </summary>
		public void delete_reconfig_modules()
		{
			var command = new SimpleTCLCommand("delete_reconfig_modules");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of PartitionDefs
		/// </summary>
		public void get_partition_defs()
		{
			var command = new SimpleTCLCommand("get_partition_defs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of partition configurations
		/// </summary>
		public void get_pr_configurations()
		{
			var command = new SimpleTCLCommand("get_pr_configurations");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of ReconfigModules
		/// </summary>
		public void get_reconfig_modules()
		{
			var command = new SimpleTCLCommand("get_reconfig_modules");
			_tcl.Add(command);
		}
		/// <summary>
		/// Creates minimum PR Configurations and Child Impl runs automatically based on the combination
		/// of Partition Instances and RMs
		/// </summary>
		public void setup_pr_configurations()
		{
			var command = new SimpleTCLCommand("setup_pr_configurations");
			_tcl.Add(command);
		}
	}
}
