// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class DebugCommands
	{
		private readonly QuokkaTCL _tcl;
		public DebugCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Apply trigger at startup init values to an ILA core in the design
		/// </summary>
		public void apply_hw_ila_trigger()
		{
			var command = new SimpleTCLCommand("apply_hw_ila_trigger");
			_tcl.Add(command);
		}
		/// <summary>
		/// Connect debug slave instances to the master instance. A valid master is a debug bridge or debug
		/// hub instance configured in "From BSCAN To DebugHUB" mode. A valid slave could be any of the
		/// following debug cores (Ex: ILA, VIO, JTAG_to_AXI). connect_debug_cores can only connect
		/// master and slave instances that exist in the same region (either in Reconfigurable Partition or
		/// static)
		/// </summary>
		public void connect_debug_cores()
		{
			var command = new SimpleTCLCommand("connect_debug_cores");
			_tcl.Add(command);
		}
		/// <summary>
		/// Connect nets and pins to debug port channels
		/// </summary>
		public void connect_debug_port()
		{
			var command = new SimpleTCLCommand("connect_debug_port");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new Integrated Logic Analyzer debug core
		/// </summary>
		public void create_debug_core()
		{
			var command = new SimpleTCLCommand("create_debug_core");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new debug port
		/// </summary>
		public void create_debug_port()
		{
			var command = new SimpleTCLCommand("create_debug_port");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete a debug core
		/// </summary>
		public void delete_debug_core()
		{
			var command = new SimpleTCLCommand("delete_debug_core");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete debug port
		/// </summary>
		public void delete_debug_port()
		{
			var command = new SimpleTCLCommand("delete_debug_port");
			_tcl.Add(command);
		}
		/// <summary>
		/// Disconnect nets and pins from debug port channels
		/// </summary>
		public void disconnect_debug_port()
		{
			var command = new SimpleTCLCommand("disconnect_debug_port");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of debug cores in the current design
		/// </summary>
		public void get_debug_cores()
		{
			var command = new SimpleTCLCommand("get_debug_cores");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of debug ports in the current design
		/// </summary>
		public void get_debug_ports()
		{
			var command = new SimpleTCLCommand("get_debug_ports");
			_tcl.Add(command);
		}
		/// <summary>
		/// Implement debug core
		/// </summary>
		public void implement_debug_core()
		{
			var command = new SimpleTCLCommand("implement_debug_core");
			_tcl.Add(command);
		}
		/// <summary>
		/// Modify routed probe connections to debug cores.
		/// </summary>
		public void modify_debug_ports()
		{
			var command = new SimpleTCLCommand("modify_debug_ports");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report details on debug cores
		/// </summary>
		public void report_debug_core()
		{
			var command = new SimpleTCLCommand("report_debug_core");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write debug probes to a file
		/// </summary>
		public void write_debug_probes()
		{
			var command = new SimpleTCLCommand("write_debug_probes");
			_tcl.Add(command);
		}
	}
}
