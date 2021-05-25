#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class FloorplanCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public FloorplanCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// <para>
		/// Add cells to a Pblock<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: add_cells_to_pblock [-top] [-add_primitives] [-clear_locs] [-quiet] [-verbose] &lt;pblock&gt; [&lt;cells&gt;...]
		/// <br/>
		/// <para>
		/// Adds specified logic instances to a Pblock in an open implemented design. Once cells have been<br/>
		/// added to a Pblock, you can place the Pblocks onto the fabric of the FPGA using the<br/>
		/// resize_pblock command. The resize_pblock command can also be used to manually<br/>
		/// move and resize Pblocks.<br/>
		/// You can remove instances from the Pblock using the remove_cells_from_pblock command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a Pblock called pb_cpuEngine, and then adds only the leaf-cells<br/>
		/// found in the cpuEngine module, clearing placement constraints for placed instances:<br/>
		/// create_pblock pb_cpuEngine<br/>
		/// add_cells_to_pblock pb_cpuEngine [get_cells cpuEngine/*] \<br/>
		/// -add_primitives -clear_locs<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 35<br/>
		/// </para>
		/// </summary>
		/// <param name="pblock">(Required) Pblock to add cells to</param>
		/// <param name="top">
		/// <para>
		/// (Optional)<br/>
		/// Add the top level instance; This option can't be used with -<br/>
		/// cells, or -add_primitives options. You must specify either -<br/>
		/// cells or -top option.<br/>
		/// </para>
		/// </param>
		/// <param name="add_primitives">
		/// <para>
		/// (Optional)<br/>
		/// Assign to the pblock only primitive cells from the specified<br/>
		/// list of cells.<br/>
		/// </para>
		/// </param>
		/// <param name="clear_locs">(Optional) Clear instance location constraints</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="cells">
		/// <para>
		/// (Optional)<br/>
		/// Cells to add. You can't use this option with -top option. You<br/>
		/// must specify either -cells or -top option.<br/>
		/// </para>
		/// </param>
		public TTCL add_cells_to_pblock(String pblock, bool? top = null, bool? add_primitives = null, bool? clear_locs = null, bool? quiet = null, bool? verbose = null, TCLParameterList cells = null)
		{
			// TCL Syntax: add_cells_to_pblock [-top] [-add_primitives] [-clear_locs] [-quiet] [-verbose] <pblock> [<cells>...]
			_tcl.Entry(_builder.add_cells_to_pblock(pblock, top, add_primitives, clear_locs, quiet, verbose, cells));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Add power sources to power Rail<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: add_to_power_rail [-power_sources &lt;args&gt;] [-quiet] [-verbose] &lt;power_rail&gt;
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 59<br/>
		/// </para>
		/// </summary>
		/// <param name="power_rail">(Required) Power rail to add sources to</param>
		/// <param name="power_sources">(Optional) List of power_sources to add. Can be power rails and/or power supplies</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL add_to_power_rail(String power_rail, TCLParameterList power_sources = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: add_to_power_rail [-power_sources <args>] [-quiet] [-verbose] <power_rail>
			_tcl.Entry(_builder.add_to_power_rail(power_rail, power_sources, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new Pblock<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_pblock [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// Defines a Pblock to allow you to add logic instances for floorplanning purposes.<br/>
		/// You can add logic elements to the Pblock using the add_cells_to_pblock command, and<br/>
		/// then place the Pblocks onto the fabric of the FPGA using the resize_pblocks command. The<br/>
		/// resize_pblock command can also be used to manually move and resize Pblocks.<br/>
		/// You can nest one Pblock inside another for hierarchical floorplanning using the set_property<br/>
		/// command to define the PARENT property as shown in the second example.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a Pblock called pb_cpuEngine, and then adds only the leaf-cells<br/>
		/// found in the cpuEngine module, clearing placement constraints for placed instances:<br/>
		/// create_pblock pb_cpuEngine<br/>
		/// add_cells_to_pblock pb_cpuEngine [get_cells cpuEngine/*] \<br/>
		/// -add_primitives -clear_locs<br/>
		/// The following example shows nesting Pblocks, by creating Pblocks called pb_usbEngine0 and<br/>
		/// pb_usbEngine1, and a third Pblock called pb_usbTop. Then pb_usbEngine0 and pb_usbEngine1<br/>
		/// are nested inside pb_usbTop using the set_property command:<br/>
		/// create_pblock pb_usbEngine0<br/>
		/// create_pblock pb_usbEngine1<br/>
		/// create_pblock pb_usbTop<br/>
		/// set_property PARENT pb_usbTop [get_pblocks {pb_usbEngine?}]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 327<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of the new pblock</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>new pblock object</returns>
		public TTCL create_pblock(String name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_pblock [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_pblock(name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new Power Rail<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_power_rail [-power_sources &lt;args&gt;] [-direct] [-quiet] [-verbose] &lt;name&gt;
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 339<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of the new power rail</param>
		/// <param name="power_sources">(Optional) List of power sources. Can be power rails and/or power supplies</param>
		/// <param name="direct">(Optional) Implies if the power is a direct rail</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>new power_rail object</returns>
		public TTCL create_power_rail(String name, TCLParameterList power_sources = null, bool? direct = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_power_rail [-power_sources <args>] [-direct] [-quiet] [-verbose] <name>
			_tcl.Entry(_builder.create_power_rail(name, power_sources, direct, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove Pblock<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_pblocks [-hier] [-quiet] [-verbose] &lt;pblocks&gt;...
		/// <br/>
		/// <para>
		/// Deletes the specified Pblocks from the design. Pblocks are created using the create_pblock<br/>
		/// command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example deletes the specified Pblock as well as any Pblocks nested inside:<br/>
		/// delete_pblocks -hier cpuEngine<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 463<br/>
		/// </para>
		/// </summary>
		/// <param name="pblocks">(Required) Pblocks to delete</param>
		/// <param name="hier">(Optional) Also delete all the children of Pblock</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_pblocks(TCLParameterList pblocks, bool? hier = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_pblocks [-hier] [-quiet] [-verbose] <pblocks>...
			_tcl.Entry(_builder.delete_pblocks(pblocks, hier, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Delete a Power Rail<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_power_rails [-quiet] [-verbose] &lt;power_rail&gt;
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 465<br/>
		/// </para>
		/// </summary>
		/// <param name="power_rail">(Required) power rail to delete</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_power_rails(String power_rail, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_power_rails [-quiet] [-verbose] <power_rail>
			_tcl.Entry(_builder.delete_power_rails(power_rail, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Delete an RPM<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_rpm [-quiet] [-verbose] &lt;rpm&gt;
		/// <br/>
		/// <para>
		/// Deletes the specified Relationally Placed Macro (RPM) from the design.<br/>
		/// An RPM is a list of logic elements (FFS, LUT, CY4, RAM, etc.) collected into a set (U_SET, H_SET,<br/>
		/// and HU_SET). The placement of each element within the set, relative to other elements of the<br/>
		/// set, is controlled by Relative Location Constraints (RLOCs). Logic elements with RLOC constraints<br/>
		/// and common set names are associated in an RPM. Refer to the Constraints Guide (UG625) for<br/>
		/// more information on defining these constraints.<br/>
		/// Only user-defined RPMs can be deleted from the design. RPMs defined by the hierarchy or<br/>
		/// defined in the netlist cannot be deleted by this command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example deletes the specified RPM (cs_ila_0/U0) from the design:<br/>
		/// delete_rpm cs_ila_0/U0<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 476<br/>
		/// </para>
		/// </summary>
		/// <param name="rpm">(Required) RPM to delete</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_rpm(String rpm, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_rpm [-quiet] [-verbose] <rpm>
			_tcl.Entry(_builder.delete_rpm(rpm, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of Pblocks in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_pblocks [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-include_nested_pblocks] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of Pblocks defined in the current project that match a specific pattern. The default<br/>
		/// command gets a list of all Pblocks in the project.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example gets a list of all Pblocks in the current project:<br/>
		/// get_pblocks<br/>
		/// This example gets a list of all Pblocks which do not have a Slice Range defined:<br/>
		/// get_pblocks -filter {GRIDTYPES !~ SLICE}<br/>
		/// The following example gets the Pblock assignments of the specified cell:<br/>
		/// get_pblocks -of [get_cells CORE/BR_TOP/RLD67_MUX/REG_PMBIST_C1]<br/>
		/// This example returns the specified Pblock, including any nested Pblocks:<br/>
		/// get_pblocks -include_nested_pblocks usbTop<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 868<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get Pblocks of these cells</param>
		/// <param name="include_nested_pblocks">(Optional) Display the the list of nested pblocks</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match Pblock names against patterns Default: *</param>
		/// <returns>list of Pblock objects</returns>
		public TTCL get_pblocks(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? include_nested_pblocks = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_pblocks [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-include_nested_pblocks] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_pblocks(regexp, nocase, filter, of_objects, include_nested_pblocks, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of Power Rails in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_power_rails [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 890<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match Power rail names against patterns Default: *</param>
		/// <returns>list of power rail objects</returns>
		public TTCL get_power_rails(bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_power_rails [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_power_rails(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Move or place one or more instances to new locations. Sites and cells are required to be listed in<br/>
		/// the right order and there should be same number of sites as number of cells.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: place_cell [-quiet] [-verbose] &lt;cell_site_list&gt;...
		/// <br/>
		/// <para>
		/// Places cells onto device resources of the target part. Cells can be placed onto specific BEL sites<br/>
		/// (e.g. SLICE_X49Y60/A6LUT), or into available SLICE resources (e.g. SLICE_X49Y60). If you<br/>
		/// specify the SLICE but not the BEL the tool will determine an appropriate BEL within the specified<br/>
		/// SLICE if one is available.<br/>
		/// When placing a cell onto a specified site, the site must not be currently occupied, or an error will<br/>
		/// be returned: Cannot set site and bel property of instances. Site<br/>
		/// SLICE_X49Y61 is already occupied.<br/>
		/// You can test if a site is occupied by querying the IS_OCCUPIED property of a BEL site:<br/>
		/// get_property IS_OCCUPIED [get_bels SLICE_X48Y60/D6LUT]<br/>
		/// Note: The IS_OCCUPIED property of a SLICE only tells you if some of the BELs within the SLICE are<br/>
		/// occupied; not whether or not the SLICE is fully occupied.<br/>
		/// This command can be used to place cells, or to move placed cells from one site on the device to<br/>
		/// another site. The command syntax is the same for placing an unplaced cell, or moving a placed<br/>
		/// cell.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// When moving a placed cell, if you specify only the SLICE for the site, the tool will attempt to<br/>
		/// place the cell onto the same BEL site in the new SLICE as it currently is placed. For instance<br/>
		/// moving a cell from the B6LUT, by specifying a new SLICE, will cause the tool to attempt to place<br/>
		/// the cell onto the B6LUT in the new SLICE. If this BEL site is currently occupied, an error is<br/>
		/// returned.<br/>
		/// Note: This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example places the specified cell onto the specified BEL site:<br/>
		/// place_cell div_cntr_reg_inferredi_4810_15889 SLICE_X49Y60/D6LUT<br/>
		/// The following example places the specified cell into the specified SLICE:<br/>
		/// place_cell div_cntr_reg_inferredi_4810_15889 SLICE_X49Y61<br/>
		/// Note: The tool will select an appropriate BEL site if one is available. If no BEL is available, and error will be<br/>
		/// returned.<br/>
		/// The following example places multiple cells onto multiple sites:<br/>
		/// place_cell { \<br/>
		/// cpuEngine/cpu_iwb_adr_o/buffer_fifo/i_4810_17734 SLICE_X49Y60/A6LUT \<br/>
		/// cpuEngine/or1200_cpu/or1200_mult_mac/i_4775_15857 SLICE_X49Y60/B6LUT \<br/>
		/// cpuEngine/cpu_iwb_adr_o/buffer_fifo/xlnx_opt_LUT_i_4810_18807_2 \<br/>
		/// SLICE_X49Y60/C6LUT }<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1121<br/>
		/// </para>
		/// </summary>
		/// <param name="cell_site_list">(Required) a list of cells and sites in the interleaved order</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL place_cell(TCLParameterList cell_site_list, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: place_cell [-quiet] [-verbose] <cell_site_list>...
			_tcl.Entry(_builder.place_cell(cell_site_list, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove cells from a Pblock<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_cells_from_pblock [-quiet] [-verbose] &lt;pblock&gt; &lt;cells&gt;...
		/// <br/>
		/// <para>
		/// Removes the specified logic instances from a Pblock. Cells are added to a Pblock with the<br/>
		/// add_cells_to_pblock command.<br/>
		/// Note: Cells that have been placed will not be unplaced as they are removed from a Pblock. Any current<br/>
		/// LOC assignments are left intact.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example removes the specified cells from the pb_cpuEngine Pblock:<br/>
		/// remove_cells_from_pblock pb_cpuEngine [get_cells cpuEngine/cpu_dwb_dat_o/*]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1237<br/>
		/// </para>
		/// </summary>
		/// <param name="pblock">(Required) Pblock to remove cells from</param>
		/// <param name="cells">(Required) Cells to remove</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_cells_from_pblock(String pblock, TCLParameterList cells, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_cells_from_pblock [-quiet] [-verbose] <pblock> <cells>...
			_tcl.Entry(_builder.remove_cells_from_pblock(pblock, cells, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove power sources from Power Rail<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_from_power_rail [-power_sources &lt;args&gt;] [-quiet] [-verbose] &lt;power_rail&gt;
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1251<br/>
		/// </para>
		/// </summary>
		/// <param name="power_rail">(Required) Power rail to remove power sources from</param>
		/// <param name="power_sources">
		/// <para>
		/// (Optional)<br/>
		/// List of power sources to remove. Can be power rails and/or<br/>
		/// power supplies<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_from_power_rail(String power_rail, TCLParameterList power_sources = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_from_power_rail [-power_sources <args>] [-quiet] [-verbose] <power_rail>
			_tcl.Entry(_builder.remove_from_power_rail(power_rail, power_sources, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Move, resize, add and remove Pblock site-range constraints<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: resize_pblock [-add &lt;args&gt;] [-remove &lt;args&gt;] [-from &lt;args&gt;] [-to &lt;args&gt;] [-replace] [-locs &lt;arg&gt;] [-quiet] [-verbose] &lt;pblock&gt;
		/// <br/>
		/// <para>
		/// Place, resize, move, or remove the specified Pblock. The Pblock must have been created using<br/>
		/// the create_pblock command.<br/>
		/// A Pblock consists of a group of cells that can be assigned to one or more independent or<br/>
		/// overlapping rectangles. Using the various options defined below, you can add sites to a rectangle,<br/>
		/// or remove sites from a rectangle, or define a new rectangle to be associated with an existing<br/>
		/// Pblock.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example resizes the Pblock by adding a range of SLICEs, and removing other<br/>
		/// SLICEs, but keeps all instances placed at their current location:<br/>
		/// resize_pblock block3 -add SLICE_X6Y67:SLICE_X11Y71 \<br/>
		/// -remove SLICE_X6Y71:SLICE_X7Y71 -locs keep_all<br/>
		/// This example create a Pblock region, and defines the Pblock area by adding a range of<br/>
		/// CLOCKREGIONs:<br/>
		/// create_pblock pblock_1<br/>
		/// resize_pblock pblock_1 -add {CLOCKREGION_X0Y10:CLOCKREGION_X1Y11}<br/>
		/// The following example moves the specified Pblock by adding a range of SLICEs, removing the<br/>
		/// existing range of SLICEs, and trims any placed logic that falls outside the new Pblock. Then it<br/>
		/// adds a new range of SLICEs and block ram to the specified Pblock in a second separate rectangle:<br/>
		/// resize_pblock block3 -add SLICE_X3Y8:SLICE_X10Y3 \<br/>
		/// -remove SLICE_X6Y67:SLICE_X11Y71 -locs trim<br/>
		/// resize_pblock block3 -add {SLICE_X6Y67:SLICE_X11Y71 \<br/>
		/// RAMB18_X0Y2:RAMB18_X1Y4}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1527<br/>
		/// </para>
		/// </summary>
		/// <param name="pblock">(Required) Pblock to resize</param>
		/// <param name="add">(Optional) Add site ranges(s)</param>
		/// <param name="remove">(Optional) Remove site ranges(s)</param>
		/// <param name="from">(Optional) Site range(s) to move</param>
		/// <param name="to">(Optional) Site range destination(s)</param>
		/// <param name="replace">(Optional) Remove all existing ranges</param>
		/// <param name="locs">(Optional) LOC treatment Default: keep_all</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL resize_pblock(String pblock, TCLParameterList add = null, TCLParameterList remove = null, TCLParameterList from = null, TCLParameterList to = null, bool? replace = null, String locs = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: resize_pblock [-add <args>] [-remove <args>] [-from <args>] [-to <args>] [-replace] [-locs <arg>] [-quiet] [-verbose] <pblock>
			_tcl.Entry(_builder.resize_pblock(pblock, add, remove, from, to, replace, locs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Swap two locations<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: swap_locs [-quiet] [-verbose] &lt;aloc&gt; &lt;bloc&gt;
		/// <br/>
		/// <para>
		/// Swaps the LOC constraints assigned to two similar logic elements. A logic element is an element<br/>
		/// that can be placed onto a device resource on the FPGA.<br/>
		/// Some DRC checking is performed when the swap_locs command is executed to ensure that<br/>
		/// the two selected elements can in fact be assigned to their new locations. If the location of either<br/>
		/// element is invalid for any reason, the swap_locs command will fail and an error will be<br/>
		/// returned.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example swaps the instances assigned to the two specified device sites:<br/>
		/// swap_locs [get_sites {OLOGIC_X2Y1}] [get_sites {OLOGIC_X2Y0}]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1731<br/>
		/// </para>
		/// </summary>
		/// <param name="aloc">(Required) First location (port/cell/site - should be of same type as 'bloc')</param>
		/// <param name="bloc">(Required) Second location (port/cell/site - should be of same type as 'aloc')</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL swap_locs(String aloc, String bloc, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: swap_locs [-quiet] [-verbose] <aloc> <bloc>
			_tcl.Entry(_builder.swap_locs(aloc, bloc, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Unplace one or more instances.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: unplace_cell [-quiet] [-verbose] &lt;cell_list&gt;...
		/// <br/>
		/// <para>
		/// Unplace the specified cells from their current placement site.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example unplaces the specified cell:<br/>
		/// unplace_cell {fftEngine/fftInst/ingressLoop[6].ingressFifo/buffer_fifo/<br/>
		/// i_4773_12897}<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example unplaces multiple cells:<br/>
		/// unplace_cell {div_cntr_reg_inferredi_4810_15889 div_cntr_reg[0]<br/>
		/// div_cntr_reg[1]}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1754<br/>
		/// </para>
		/// </summary>
		/// <param name="cell_list">(Required) a list of cells to be unplaced</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL unplace_cell(TCLParameterList cell_list, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: unplace_cell [-quiet] [-verbose] <cell_list>...
			_tcl.Entry(_builder.unplace_cell(cell_list, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
