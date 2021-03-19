// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class WaveformCommands
	{
		private readonly QuokkaTCL _tcl;
		public WaveformCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Add new waves
		/// </summary>
		public void add_wave()
		{
			var command = new SimpleTCLCommand("add_wave");
			_tcl.Add(command);
		}
		/// <summary>
		/// Add a new divider
		/// </summary>
		public void add_wave_divider()
		{
			var command = new SimpleTCLCommand("add_wave_divider");
			_tcl.Add(command);
		}
		/// <summary>
		/// Add a new group
		/// </summary>
		public void add_wave_group()
		{
			var command = new SimpleTCLCommand("add_wave_group");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new wave marker
		/// </summary>
		public void add_wave_marker()
		{
			var command = new SimpleTCLCommand("add_wave_marker");
			_tcl.Add(command);
		}
		/// <summary>
		/// Add a new virtual bus
		/// </summary>
		public void add_wave_virtual_bus()
		{
			var command = new SimpleTCLCommand("add_wave_virtual_bus");
			_tcl.Add(command);
		}
		/// <summary>
		/// Closes the wave config
		/// </summary>
		public void close_wave_config()
		{
			var command = new SimpleTCLCommand("close_wave_config");
			_tcl.Add(command);
		}
		/// <summary>
		/// Creates a new wave config
		/// </summary>
		public void create_wave_config()
		{
			var command = new SimpleTCLCommand("create_wave_config");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the current WCFG object and sets it to the specified WCFG object if given
		/// </summary>
		public void current_wave_config()
		{
			var command = new SimpleTCLCommand("current_wave_config");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets the wave configs that match the given options
		/// </summary>
		public void get_wave_configs()
		{
			var command = new SimpleTCLCommand("get_wave_configs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Gets wave objects from a wave configuration
		/// </summary>
		public void get_waves()
		{
			var command = new SimpleTCLCommand("get_waves");
			_tcl.Add(command);
		}
		/// <summary>
		/// Moves wave objects from their current position to the specified position in the wave
		/// configuration
		/// </summary>
		public void move_wave()
		{
			var command = new SimpleTCLCommand("move_wave");
			_tcl.Add(command);
		}
		/// <summary>
		/// Open a wave config
		/// </summary>
		public void open_wave_config()
		{
			var command = new SimpleTCLCommand("open_wave_config");
			_tcl.Add(command);
		}
		/// <summary>
		/// Removes wave objects from the current wave configuration
		/// </summary>
		public void remove_wave()
		{
			var command = new SimpleTCLCommand("remove_wave");
			_tcl.Add(command);
		}
		/// <summary>
		/// Saves the specified or current wave configuration object to the given filename
		/// </summary>
		public void save_wave_config()
		{
			var command = new SimpleTCLCommand("save_wave_config");
			_tcl.Add(command);
		}
		/// <summary>
		/// Display help for one or more topics
		/// </summary>
		public void select_wave_objects()
		{
			var command = new SimpleTCLCommand("select_wave_objects");
			_tcl.Add(command);
		}
	}
}
