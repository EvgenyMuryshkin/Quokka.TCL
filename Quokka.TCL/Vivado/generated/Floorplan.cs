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
		///
		/// Adds specified logic instances to a Pblock in an open implemented design. Once cells have been
		/// added to a Pblock, you can place the Pblocks onto the fabric of the FPGA using the
		/// resize_pblock command. The resize_pblock command can also be used to manually
		/// move and resize Pblocks.
		/// You can remove instances from the Pblock using the remove_cells_from_pblock command.
		///
		/// The following example creates a Pblock called pb_cpuEngine, and then adds only the leaf-cells
		/// found in the cpuEngine module, clearing placement constraints for placed instances:
		/// create_pblock pb_cpuEngine
		/// add_cells_to_pblock pb_cpuEngine [get_cells cpuEngine/*] \
		/// -add_primitives -clear_locs
		///
		/// See ug835-vivado-tcl-commands.pdf, page 33
		/// </summary>
		/// <param name="pblock">
		/// Required
		/// Pblock to add cells to
		/// </param>
		/// <param name="top">
		/// Optional
		/// Add the top level instance; This option can't be used with -
		/// cells, or -add_primitives options. You must specify either -
		/// cells or -top option.
		/// </param>
		/// <param name="add_primitives">
		/// Optional
		/// Assign to the pblock only primitive cells from the specified
		/// list of cells.
		/// </param>
		/// <param name="clear_locs">
		/// Optional
		/// Clear instance location constraints
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="cells">
		/// Optional
		/// Cells to add. You can't use this option with -top option. You
		/// must specify either -cells or -top option.
		/// </param>
		public void add_cells_to_pblock(string pblock, bool? top = null, bool? add_primitives = null, bool? clear_locs = null, bool? quiet = null, bool? verbose = null, string cells = null)
		{
			var command = new SimpleTCLCommand("add_cells_to_pblock");
			command.Flag("top", top);
			command.Flag("add_primitives", add_primitives);
			command.Flag("clear_locs", clear_locs);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("pblock", pblock);
			command.OptionalString("cells", cells);
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new Pblock
		///
		/// Defines a Pblock to allow you to add logic instances for floorplanning purposes.
		/// You can add logic elements to the Pblock using the add_cells_to_pblock command, and
		/// then place the Pblocks onto the fabric of the FPGA using the resize_pblocks command. The
		/// resize_pblock command can also be used to manually move and resize Pblocks.
		/// You can nest one Pblock inside another for hierarchical floorplanning using the set_property
		/// command to define the PARENT property as shown in the second example.
		///
		/// The following example creates a Pblock called pb_cpuEngine, and then adds only the leaf-cells
		/// found in the cpuEngine module, clearing placement constraints for placed instances:
		/// create_pblock pb_cpuEngine
		/// add_cells_to_pblock pb_cpuEngine [get_cells cpuEngine/*] \
		/// -add_primitives -clear_locs
		/// The following example shows nesting Pblocks, by creating Pblocks called pb_usbEngine0 and
		/// pb_usbEngine1, and a third Pblock called pb_usbTop. Then pb_usbEngine0 and pb_usbEngine1
		/// are nested inside pb_usbTop using the set_property command:
		/// create_pblock pb_usbEngine0
		/// create_pblock pb_usbEngine1
		/// create_pblock pb_usbTop
		/// set_property PARENT pb_usbTop [get_pblocks {pb_usbEngine?}]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 318
		/// </summary>
		/// <param name="name">
		/// Required
		/// Name of the new pblock
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <returns>new pblock object</returns>
		public void create_pblock(string name, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("create_pblock");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("name", name);
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove Pblock
		///
		/// Deletes the specified Pblocks from the design. Pblocks are created using the create_pblock
		/// command.
		///
		/// The following example deletes the specified Pblock as well as any Pblocks nested inside:
		/// delete_pblocks -hier cpuEngine
		///
		/// See ug835-vivado-tcl-commands.pdf, page 452
		/// </summary>
		/// <param name="pblocks">
		/// Required
		/// Pblocks to delete
		/// </param>
		/// <param name="hier">
		/// Optional
		/// Also delete all the children of Pblock
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void delete_pblocks(string pblocks, bool? hier = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("delete_pblocks");
			command.Flag("hier", hier);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("pblocks", pblocks);
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete an RPM
		///
		/// Deletes the specified Relationally Placed Macro (RPM) from the design.
		/// An RPM is a list of logic elements (FFS, LUT, CY4, RAM, etc.) collected into a set (U_SET, H_SET,
		/// and HU_SET). The placement of each element within the set, relative to other elements of the
		/// set, is controlled by Relative Location Constraints (RLOCs). Logic elements with RLOC constraints
		/// and common set names are associated in an RPM. Refer to the Constraints Guide (UG625) for
		/// more information on defining these constraints.
		/// Only user-defined RPMs can be deleted from the design. RPMs defined by the hierarchy or
		/// defined in the netlist cannot be deleted by this command.
		///
		/// The following example deletes the specified RPM (cs_ila_0/U0) from the design:
		/// delete_rpm cs_ila_0/U0
		///
		/// See ug835-vivado-tcl-commands.pdf, page 464
		/// </summary>
		/// <param name="rpm">
		/// Required
		/// RPM to delete
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void delete_rpm(string rpm, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("delete_rpm");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("rpm", rpm);
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of Pblocks in the current design
		///
		/// Gets a list of Pblocks defined in the current project that match a specific pattern. The default
		/// command gets a list of all Pblocks in the project.
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,
		/// or string, to the list is not permitted and will result in a Tcl error.
		///
		/// The following example gets a list of all Pblocks in the current project:
		/// get_pblocks
		/// This example gets a list of all Pblocks which do not have a Slice Range defined:
		/// get_pblocks -filter {GRIDTYPES !~ SLICE}
		/// The following example gets the Pblock assignments of the specified cell:
		/// get_pblocks -of [get_cells CORE/BR_TOP/RLD67_MUX/REG_PMBIST_C1]
		/// This example returns the specified Pblock, including any nested Pblocks:
		/// get_pblocks -include_nested_pblocks usbTop
		///
		/// See ug835-vivado-tcl-commands.pdf, page 848
		/// </summary>
		/// <param name="regexp">
		/// Optional
		/// Patterns are full regular expressions
		/// </param>
		/// <param name="nocase">
		/// Optional
		/// Perform case-insensitive matching (valid only when -regexp
		/// specified)
		/// </param>
		/// <param name="filter">
		/// Optional
		/// Filter list with expression
		/// </param>
		/// <param name="of_objects">
		/// Optional
		/// Get Pblocks of these cells
		/// </param>
		/// <param name="include_nested_pblock">
		/// Optional
		/// Display the the list of nested pblocks
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		/// <param name="patterns">
		/// Optional
		/// Match Pblock names against patterns Default: *
		/// </param>
		/// <returns>list of Pblock objects</returns>
		public void get_pblocks(bool? regexp = null, bool? nocase = null, string filter = null, string of_objects = null, bool? include_nested_pblock = null, bool? quiet = null, bool? verbose = null, string patterns = null)
		{
			var command = new SimpleTCLCommand("get_pblocks");
			command.Flag("regexp", regexp);
			command.Flag("nocase", nocase);
			command.OptionalString("filter", filter);
			command.OptionalString("of_objects", of_objects);
			command.Flag("include_nested_pblock", include_nested_pblock);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.OptionalString("patterns", patterns);
			_tcl.Add(command);
		}
		/// <summary>
		/// Move or place one or more instances to new locations. Sites and cells are required to be listed in
		/// the right order and there should be same number of sites as number of cells.
		///
		/// Places cells onto device resources of the target part. Cells can be placed onto specific BEL sites
		/// (e.g. SLICE_X49Y60/A6LUT), or into available SLICE resources (e.g. SLICE_X49Y60). If you
		/// specify the SLICE but not the BEL the tool will determine an appropriate BEL within the specified
		/// SLICE if one is available.
		/// When placing a cell onto a specified site, the site must not be currently occupied, or an error will
		/// be returned: Cannot set site and bel property of instances. Site
		/// SLICE_X49Y61 is already occupied.
		/// You can test if a site is occupied by querying the IS_OCCUPIED property of a BEL site:
		/// get_property IS_OCCUPIED [get_bels SLICE_X48Y60/D6LUT]
		/// Note: The IS_OCCUPIED property of a SLICE only tells you if some of the BELs within the SLICE are
		/// occupied; not whether or not the SLICE is fully occupied.
		/// This command can be used to place cells, or to move placed cells from one site on the device to
		/// another site. The command syntax is the same for placing an unplaced cell, or moving a placed
		/// cell.
		/// When moving a placed cell, if you specify only the SLICE for the site, the tool will attempt to
		/// place the cell onto the same BEL site in the new SLICE as it currently is placed. For instance
		/// moving a cell from the B6LUT, by specifying a new SLICE, will cause the tool to attempt to place
		/// the cell onto the B6LUT in the new SLICE. If this BEL site is currently occupied, an error is
		/// returned.
		/// Note: This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example places the specified cell onto the specified BEL site:
		/// place_cell div_cntr_reg_inferredi_4810_15889 SLICE_X49Y60/D6LUT
		/// The following example places the specified cell into the specified SLICE:
		/// place_cell div_cntr_reg_inferredi_4810_15889 SLICE_X49Y61
		/// Note: The tool will select an appropriate BEL site if one is available. If no BEL is available, and error will be
		/// returned.
		/// The following example places multiple cells onto multiple sites:
		/// place_cell { \
		/// cpuEngine/cpu_iwb_adr_o/buffer_fifo/i_4810_17734 SLICE_X49Y60/A6LUT \
		/// cpuEngine/or1200_cpu/or1200_mult_mac/i_4775_15857 SLICE_X49Y60/B6LUT \
		/// cpuEngine/cpu_iwb_adr_o/buffer_fifo/xlnx_opt_LUT_i_4810_18807_2 \
		/// SLICE_X49Y60/C6LUT }
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1098
		/// </summary>
		/// <param name="cell_site_list">
		/// Required
		/// a list of cells and sites in the interleaved order
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void place_cell(string cell_site_list, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("place_cell");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("cell_site_list", cell_site_list);
			_tcl.Add(command);
		}
		/// <summary>
		/// Resize Pblocks according to SLICE demand and re-position them according to connectivity
		///
		/// Places Pblocks onto the fabric of the FPGA. Pblocks must be created using the create_pblock
		/// command, and should be populated with assigned logic using the add_cells_to_pblock
		/// command.
		/// Note: An empty Pblock will be placed as directed, but results in a Pblock covering a single CLB tile (two
		/// SLICEs).
		///
		/// The following example places the specified Pblocks with a utilization of 75%:
		/// place_pblocks -effort LOW -utilization 75 block1 block2 block3 block4
		/// block5
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1106
		/// </summary>
		/// <param name="pblocks">
		/// Required
		/// List of Pblocks to place
		/// </param>
		/// <param name="effort">
		/// Optional
		/// Placer effort level (per Pblock) Values: LOW, MEDIUM, HIGH
		/// Default: HIGH
		/// </param>
		/// <param name="utilization">
		/// Optional
		/// Placer utilization (per Pblock)
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void place_pblocks(string pblocks, string effort = null, string utilization = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("place_pblocks");
			command.OptionalString("effort", effort);
			command.OptionalString("utilization", utilization);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("pblocks", pblocks);
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove cells from a Pblock
		///
		/// Removes the specified logic instances from a Pblock. Cells are added to a Pblock with the
		/// add_cells_to_pblock command.
		/// Note: Cells that have been placed will not be unplaced as they are removed from a Pblock. Any current
		/// LOC assignments are left intact.
		///
		/// The following example removes the specified cells from the pb_cpuEngine Pblock:
		/// remove_cells_from_pblock pb_cpuEngine [get_cells cpuEngine/cpu_dwb_dat_o/*]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1213
		/// </summary>
		/// <param name="pblock">
		/// Required
		/// Pblock to remove cells from
		/// </param>
		/// <param name="cells">
		/// Required
		/// Cells to remove
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void remove_cells_from_pblock(string pblock, string cells, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("remove_cells_from_pblock");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("pblock", pblock);
			command.RequiredString("cells", cells);
			_tcl.Add(command);
		}
		/// <summary>
		/// Move, resize, add and remove Pblock site-range constraints
		///
		/// Place, resize, move, or remove the specified Pblock. The Pblock must have been created using
		/// the create_pblock command.
		/// A Pblock consists of a group of cells that can be assigned to one or more independent or
		/// overlapping rectangles. Using the various options defined below, you can add sites to a rectangle,
		/// or remove sites from a rectangle, or define a new rectangle to be associated with an existing
		/// Pblock.
		///
		/// The following example resizes the Pblock by adding a range of SLICEs, and removing other
		/// SLICEs, but keeps all instances placed at their current location:
		/// resize_pblock block3 -add SLICE_X6Y67:SLICE_X11Y71 \
		/// -remove SLICE_X6Y71:SLICE_X7Y71 -locs keep_all
		/// This example create a Pblock region, and defines the Pblock area by adding a range of
		/// CLOCKREGIONs:
		/// create_pblock pblock_1
		/// resize_pblock pblock_1 -add {CLOCKREGION_X0Y10:CLOCKREGION_X1Y11}
		/// The following example moves the specified Pblock by adding a range of SLICEs, removing the
		/// existing range of SLICEs, and trims any placed logic that falls outside the new Pblock. Then it
		/// adds a new range of SLICEs and block ram to the specified Pblock in a second separate rectangle:
		/// resize_pblock block3 -add SLICE_X3Y8:SLICE_X10Y3 \
		/// -remove SLICE_X6Y67:SLICE_X11Y71 -locs trim
		/// resize_pblock block3 -add {SLICE_X6Y67:SLICE_X11Y71 \
		/// RAMB18_X0Y2:RAMB18_X1Y4}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1494
		/// </summary>
		/// <param name="pblock">
		/// Required
		/// Pblock to resize
		/// </param>
		/// <param name="add">
		/// Optional
		/// Add site ranges(s)
		/// </param>
		/// <param name="remove">
		/// Optional
		/// Remove site ranges(s)
		/// </param>
		/// <param name="from">
		/// Optional
		/// Site range(s) to move
		/// </param>
		/// <param name="to">
		/// Optional
		/// Site range destination(s)
		/// </param>
		/// <param name="replace">
		/// Optional
		/// Remove all existing ranges
		/// </param>
		/// <param name="locs">
		/// Optional
		/// LOC treatment Default: keep_all
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void resize_pblock(string pblock, string add = null, string remove = null, string from = null, string to = null, bool? replace = null, string locs = null, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("resize_pblock");
			command.OptionalString("add", add);
			command.OptionalString("remove", remove);
			command.OptionalString("from", from);
			command.OptionalString("to", to);
			command.Flag("replace", replace);
			command.OptionalString("locs", locs);
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("pblock", pblock);
			_tcl.Add(command);
		}
		/// <summary>
		/// Swap two locations
		///
		/// Swaps the LOC constraints assigned to two similar logic elements. A logic element is an element
		/// that can be placed onto a device resource on the FPGA.
		/// Some DRC checking is performed when the swap_locs command is executed to ensure that
		/// the two selected elements can in fact be assigned to their new locations. If the location of either
		/// element is invalid for any reason, the swap_locs command will fail and an error will be
		/// returned.
		///
		/// The following example swaps the instances assigned to the two specified device sites:
		/// swap_locs [get_sites {OLOGIC_X2Y1}] [get_sites {OLOGIC_X2Y0}]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1698
		/// </summary>
		/// <param name="aloc">
		/// Required
		/// First location (port/cell/site - should be of same type as
		/// 'bloc')
		/// </param>
		/// <param name="bloc">
		/// Required
		/// Second location (port/cell/site - should be of same type as
		/// 'aloc')
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void swap_locs(string aloc, string bloc, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("swap_locs");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("aloc", aloc);
			command.RequiredString("bloc", bloc);
			_tcl.Add(command);
		}
		/// <summary>
		/// Unplace one or more instances.
		///
		/// Unplace the specified cells from their current placement site.
		///
		/// The following example unplaces the specified cell:
		/// unplace_cell {fftEngine/fftInst/ingressLoop[6].ingressFifo/buffer_fifo/
		/// i_4773_12897}
		/// The following example unplaces multiple cells:
		/// unplace_cell {div_cntr_reg_inferredi_4810_15889 div_cntr_reg[0]
		/// div_cntr_reg[1]}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1721
		/// </summary>
		/// <param name="cell_list">
		/// Required
		/// a list of cells to be unplaced
		/// </param>
		/// <param name="quiet">
		/// Optional
		/// Ignore command errors
		/// </param>
		/// <param name="verbose">
		/// Optional
		/// Suspend message limits during command execution
		/// </param>
		public void unplace_cell(string cell_list, bool? quiet = null, bool? verbose = null)
		{
			var command = new SimpleTCLCommand("unplace_cell");
			command.Flag("quiet", quiet);
			command.Flag("verbose", verbose);
			command.RequiredString("cell_list", cell_list);
			_tcl.Add(command);
		}
	}
}
