// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class FloorplanCommands
	{
		private readonly QuokkaTCL _tcl;
		public FloorplanCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Add cells to a Pblock
		/// </summary>
		public void add_cells_to_pblock()
		{
			var command = new SimpleTCLCommand("add_cells_to_pblock");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new Pblock
		/// </summary>
		public void create_pblock()
		{
			var command = new SimpleTCLCommand("create_pblock");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove Pblock
		/// </summary>
		public void delete_pblocks()
		{
			var command = new SimpleTCLCommand("delete_pblocks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete an RPM
		/// </summary>
		public void delete_rpm()
		{
			var command = new SimpleTCLCommand("delete_rpm");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of Pblocks in the current design
		/// </summary>
		public void get_pblocks()
		{
			var command = new SimpleTCLCommand("get_pblocks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Move or place one or more instances to new locations. Sites and cells are required to be listed in
		/// the right order and there should be same number of sites as number of cells.
		/// </summary>
		public void place_cell()
		{
			var command = new SimpleTCLCommand("place_cell");
			_tcl.Add(command);
		}
		/// <summary>
		/// Resize Pblocks according to SLICE demand and re-position them according to connectivity
		/// </summary>
		public void place_pblocks()
		{
			var command = new SimpleTCLCommand("place_pblocks");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove cells from a Pblock
		/// </summary>
		public void remove_cells_from_pblock()
		{
			var command = new SimpleTCLCommand("remove_cells_from_pblock");
			_tcl.Add(command);
		}
		/// <summary>
		/// Move, resize, add and remove Pblock site-range constraints
		/// </summary>
		public void resize_pblock()
		{
			var command = new SimpleTCLCommand("resize_pblock");
			_tcl.Add(command);
		}
		/// <summary>
		/// Swap two locations
		/// </summary>
		public void swap_locs()
		{
			var command = new SimpleTCLCommand("swap_locs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Unplace one or more instances.
		/// </summary>
		public void unplace_cell()
		{
			var command = new SimpleTCLCommand("unplace_cell");
			_tcl.Add(command);
		}
	}
}
