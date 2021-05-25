#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class ToolsCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public ToolsCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// <para>
		/// Interactive phys_opt_design.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: iphys_opt_design [-fanout_opt] [-critical_cell_opt] [-placement_opt] [-rewire] [-net &lt;arg&gt;] -cluster &lt;args&gt; -place_cell &lt;args&gt; [-dsp_register_opt] [-bram_register_opt] [-uram_register_opt] [-shift_register_opt] [-cell &lt;arg&gt;] [-packing] [-unpacking] [-port &lt;arg&gt;] [-critical_pin_opt] [-equ_drivers_opt] [-skipped_optimization] [-insert_negative_edge_ffs] [-hold_fix] [-slr_crossing_opt] [-auto_pipeline] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// The iphys_opt_design command describes a specific optimization that was performed by the<br/>
		/// phys_opt_design command, such as replicating a critical cell or pulling registers from a block<br/>
		/// RAM to improve critical path delay. The iphys_opt_design command includes all the<br/>
		/// information necessary to recreate both the post-optimization logical netlist and the placement<br/>
		/// changes required for the optimized netlist.<br/>
		/// Interactive physical optimization can be used in two ways:<br/>
		/// • Applying post-placement physical optimizations to the pre-placement netlist to improve the<br/>
		/// overall placement result and improve design performance.<br/>
		/// • Saving the physical optimizations in a Tcl script to be repeated as needed.<br/>
		/// The various optimizations performed by phys_opt_design can be written to an iphys_opt Tcl<br/>
		/// script by write_iphys_opt_tcl, and read into the design by the read_iphys_opt_tcl<br/>
		/// command.<br/>
		/// TIP: The iphys_opt_design command is intended for use inside the iphys_opt Tcl script file. These<br/>
		/// commands can be edited in the context of the iphys_opt Tcl script, but they are not intended to be<br/>
		/// specified at the command line.<br/>
		/// This command returns a transcript of its processes, or an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example performs a critical cell optimization on the specified net and cluster of<br/>
		/// ports:<br/>
		/// iphys_opt_design -critical_cell_opt -net \<br/>
		/// {ADUR_CORE_INST/CPE_INST/CPE_ANT_RESOURCE_TDM_INST0 \<br/>
		/// /CPE_ANT_LINE_IQ_TDM_ANT0_INST/CPE_PN_MULT_INST/CPE_PN_MUL_INST3 \<br/>
		/// /Q_PNI_MULT_INST/pn_mult_reg[3][0]} \<br/>
		/// -cluster {pn_mult[3]_i_14_replica {\<br/>
		/// {ADUR_CORE_INST/CPE_INST/CPE_ANT_RESOURCE_TDM_INST0 \<br/>
		/// /CPE_ANT_LINE_IQ_TDM_ANT0_INST/CPE_PN_MULT_INST/CPE_PN_MUL_INST2 \<br/>
		/// /Q_ADD_INST/pn_mult_reg[3]_i_6_CARRY8/S[0]}}}\<br/>
		/// -cluster {pn_mult[3]_i_14_replica_1 {\<br/>
		/// {ADUR_CORE_INST/CPE_INST/CPE_ANT_RESOURCE_TDM_INST0 \<br/>
		/// /CPE_ANT_LINE_IQ_TDM_ANT0_INST/CPE_PN_MULT_INST/CPE_PN_MUL_INST0 \<br/>
		/// /Q_ADD_INST/pn_mult_reg[3]_i_10_CARRY8/S[0]}}}\<br/>
		/// The following example performs a shift register optimization on the specified cell:<br/>
		/// iphys_opt_design -shift_register_opt -cell \<br/>
		/// {ADUR_CORE_INST/EMIF_INTERFACE_INST/EMIF_HOST_IF_INST/DLY_INST1 \<br/>
		/// /PD_INST_FPGA/delay_chain_reg[9][16]_srl9} -port D<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1004<br/>
		/// </para>
		/// </summary>
		/// <param name="cluster">(Required) Clusters of load pins</param>
		/// <param name="place_cell">(Required) Place cell or cell connecting to pin to loc</param>
		/// <param name="fanout_opt">(Optional) Fanout optimization including very high fanout optimizations</param>
		/// <param name="critical_cell_opt">(Optional) Do cell-duplication based optimization on timing critical nets</param>
		/// <param name="placement_opt">(Optional) Move cells to reduce delay on timing-critical nets</param>
		/// <param name="rewire">(Optional) Do rewiring optimization</param>
		/// <param name="net">(Optional) net to be optimized</param>
		/// <param name="dsp_register_opt">(Optional) DSP register optimization</param>
		/// <param name="bram_register_opt">(Optional) BRAM register optimization</param>
		/// <param name="uram_register_opt">(Optional) UltraRAM register optimization</param>
		/// <param name="shift_register_opt">(Optional) Shift register optimization</param>
		/// <param name="cell">(Optional) cell to be optimized</param>
		/// <param name="packing">(Optional) Packing in DSP/BRAM</param>
		/// <param name="unpacking">(Optional) Unpacking in DSP/BRAM</param>
		/// <param name="port">(Optional) Port in DSP/BRAM that is optimized</param>
		/// <param name="critical_pin_opt">(Optional) Pin Swap optimization</param>
		/// <param name="equ_drivers_opt">(Optional) Equivalent driver rewiring</param>
		/// <param name="skipped_optimization">(Optional) The change is not committed</param>
		/// <param name="insert_negative_edge_ffs">(Optional) Inserting negative edge triggered FFs for high hold mitigation</param>
		/// <param name="hold_fix">(Optional) Inserting buffers for hold fix optimization</param>
		/// <param name="slr_crossing_opt">(Optional) Optimize slr crossing nets</param>
		/// <param name="auto_pipeline">(Optional) Auto pipeline</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">
		/// <para>
		/// (Optional)<br/>
		/// Suspend message limits during command execution<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// </param>
		public TTCL iphys_opt_design(TCLParameterList cluster, TCLParameterList place_cell, bool? fanout_opt = null, bool? critical_cell_opt = null, bool? placement_opt = null, bool? rewire = null, String net = null, bool? dsp_register_opt = null, bool? bram_register_opt = null, bool? uram_register_opt = null, bool? shift_register_opt = null, String cell = null, bool? packing = null, bool? unpacking = null, String port = null, bool? critical_pin_opt = null, bool? equ_drivers_opt = null, bool? skipped_optimization = null, bool? insert_negative_edge_ffs = null, bool? hold_fix = null, bool? slr_crossing_opt = null, bool? auto_pipeline = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: iphys_opt_design [-fanout_opt] [-critical_cell_opt] [-placement_opt] [-rewire] [-net <arg>] -cluster <args> -place_cell <args> [-dsp_register_opt] [-bram_register_opt] [-uram_register_opt] [-shift_register_opt] [-cell <arg>] [-packing] [-unpacking] [-port <arg>] [-critical_pin_opt] [-equ_drivers_opt] [-skipped_optimization] [-insert_negative_edge_ffs] [-hold_fix] [-slr_crossing_opt] [-auto_pipeline] [-quiet] [-verbose]
			_tcl.Entry(_builder.iphys_opt_design(cluster, place_cell, fanout_opt, critical_cell_opt, placement_opt, rewire, net, dsp_register_opt, bram_register_opt, uram_register_opt, shift_register_opt, cell, packing, unpacking, port, critical_pin_opt, equ_drivers_opt, skipped_optimization, insert_negative_edge_ffs, hold_fix, slr_crossing_opt, auto_pipeline, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Open a netlist design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: link_design [-name &lt;arg&gt;] [-part &lt;arg&gt;] [-constrset &lt;arg&gt;] [-top &lt;arg&gt;] [-mode &lt;arg&gt;] [-pr_config &lt;arg&gt;] [-reconfig_partitions &lt;args&gt;] [-partitions &lt;args&gt;] [-ignore_timing] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Opens a new or existing netlist design, linking the netlist files and constraints with the target part<br/>
		/// to create the design. This command is intended for use with netlist source files, such as files<br/>
		/// generated by third party synthesis tools, or Vivado synthesis through the synth_design<br/>
		/// command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The DESIGN_MODE property for the current source fileset must be defined as GateLvl in order<br/>
		/// to open a netlist design. If not, you will get the following error:<br/>
		/// ERROR: The design mode of 'sources_1' must be GateLvl.<br/>
		/// The -top switch is required for third-party synthesis designs. The netlist for the design must be<br/>
		/// rooted in a specific module. For project-based designs you can specify the TOP property on the<br/>
		/// project. However, in non-project mode, you must use the -top option for the link_design<br/>
		/// command.<br/>
		/// For project based designs with RTL source files, use launch_runs to launch synthesis or<br/>
		/// implementation, and then use the open_run command to open the design.<br/>
		/// For non-project based designs, use the open_checkpoint command to open a checkpoint into<br/>
		/// memory, opening the design in Non-Project Mode. Refer to the Vivado Design Suite User Guide:<br/>
		/// Design Flows Overview (UG892) for more information on Project Mode and Non-Project Mode.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following creates a new netlist design called Net1:<br/>
		/// link_design -name Net1<br/>
		/// Note: The default source set, constraint set, and part will be used in this example.<br/>
		/// The following example opens a netlist design called Net1, and specifies the constraint set to be<br/>
		/// used:<br/>
		/// link_design -name Net1 -constrset con1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1024<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Optional) Design name</param>
		/// <param name="part">(Optional) Target part</param>
		/// <param name="constrset">(Optional) Constraint fileset to use</param>
		/// <param name="top">(Optional) Specify the top module name when the structural netlist is Verilog</param>
		/// <param name="mode">(Optional) The design mode. Values: default, out_of_context Default: default</param>
		/// <param name="pr_config">(Optional) PR Configuration to apply while opening the design</param>
		/// <param name="reconfig_partitions">(Optional) List of reconfigurable partitions to load while opening the design</param>
		/// <param name="partitions">(Optional) List of partitions to load while opening the design</param>
		/// <param name="ignore_timing">(Optional) open a netlist design without the timing constraints.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>design object</returns>
		public TTCL link_design(String name = null, String part = null, String constrset = null, String top = null, link_design_mode? mode = null, String pr_config = null, TCLParameterList reconfig_partitions = null, TCLParameterList partitions = null, bool? ignore_timing = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: link_design [-name <arg>] [-part <arg>] [-constrset <arg>] [-top <arg>] [-mode <arg>] [-pr_config <arg>] [-reconfig_partitions <args>] [-partitions <args>] [-ignore_timing] [-quiet] [-verbose]
			_tcl.Entry(_builder.link_design(name, part, constrset, top, mode, pr_config, reconfig_partitions, partitions, ignore_timing, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// List available features.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: list_features [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// In order to reduce the memory footprint of the Vivado Design Suite, there are groups of Tcl<br/>
		/// commands called "features" which are unavailable for use until you run a command from that<br/>
		/// feature set, or unless you explicitly load the feature using the load_features command.<br/>
		/// This command lists the available features sets of the Vivado Design Suite that can be loaded with<br/>
		/// the load_features command.<br/>
		/// Note: If a feature has been previously loaded, it will not be listed as a feature available to load.<br/>
		/// This command returns a list of features, or an error message.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the list of features available to load into the Vivado Design Suite:<br/>
		/// list_features<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1028<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL list_features(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: list_features [-quiet] [-verbose]
			_tcl.Entry(_builder.list_features(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Load Tcl commands for a specified feature.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: load_features [-quiet] [-verbose] [&lt;features&gt;...]
		/// <br/>
		/// <para>
		/// Load the specified features of the Vivado Design Suite into memory.<br/>
		/// In order to reduce the memory footprint of the Vivado Design Suite, there are groups of Tcl<br/>
		/// commands called "features" which are unavailable for use until you run a command from that<br/>
		/// feature set, or unless you explicitly load the feature using the load_features command.<br/>
		/// For example, the load_features simulator command loads the commands for the Vivado<br/>
		/// simulator, as does directly launching the Vivado simulator using the launch_xsim command.<br/>
		/// To access the complete list of Tcl commands associated with a feature of the Vivado Design<br/>
		/// Suite, and the help text for these commands, you can load the feature into the application<br/>
		/// memory using the load_features command without actually running the feature of the tool.<br/>
		/// You can list the features that are available to be loaded using the list_features command.<br/>
		/// The list of features is dynamic, and changes from release to release.<br/>
		/// The command returns nothing if successful, or an error message if failed.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example loads the Vivado simulator feature:<br/>
		/// load_features simulator<br/>
		/// The following example loads all of the loadable feature sets of the Vivado Design Suite:<br/>
		/// load_features [list_features]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1040<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="features">
		/// <para>
		/// (Optional)<br/>
		/// Feature(s) to load, use list_features for a list of available<br/>
		/// features.<br/>
		/// </para>
		/// </param>
		public TTCL load_features(bool? quiet = null, bool? verbose = null, TCLParameterList features = null)
		{
			// TCL Syntax: load_features [-quiet] [-verbose] [<features>...]
			_tcl.Entry(_builder.load_features(quiet, verbose, features));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Optimize the current netlist. This will perform the retarget, propconst, sweep and<br/>
		/// bram_power_opt optimizations by default.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: opt_design [-retarget] [-propconst] [-sweep] [-bram_power_opt] [-remap] [-aggressive_remap] [-resynth_area] [-resynth_seq_area] [-directive &lt;arg&gt;] [-muxf_remap] [-hier_fanout_limit &lt;arg&gt;] [-bufg_opt] [-shift_register_opt] [-dsp_register_opt] [-srl_remap_modes &lt;arg&gt;] [-control_set_merge] [-merge_equivalent_drivers] [-carry_remap] [-debug_log] [-property_opt_only] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Optimizes a design netlist for the target part. Optimization can provide improvements to<br/>
		/// synthesized netlists from third-party tools, or for netlists that may not have been optimized<br/>
		/// during synthesis.<br/>
		/// Run this command after synthesis but prior to implementation to optimize the design and<br/>
		/// simplify the netlist before placing and routing the design. Assign the DONT_TOUCH property to<br/>
		/// prevent the optimization of individual cells.<br/>
		/// TIP: To see what actions opt_design is taking in optimizing your design, you can use the -verbose<br/>
		/// option to get a more detailed transcript of the process. This can help you in understanding and debugging<br/>
		/// some of the changes made to your design.<br/>
		/// The opt_design command performs the following optimizations by default:<br/>
		/// • Retarget<br/>
		/// • Constant Propagation<br/>
		/// • Sweep<br/>
		/// • Global Buffer (BUFG) optimizations<br/>
		/// • DSP Register optimizations<br/>
		/// • Shift-Register Logic optimizations<br/>
		/// • Block RAM Power optimizations<br/>
		/// • Implement MIG cores<br/>
		/// • Implement Debug cores<br/>
		/// IMPORTANT! Using command-line options for specific optimizations results in opt_design performing<br/>
		/// only the specified optimizations and disabling all others, even the ones that are usually performed by<br/>
		/// default.<br/>
		/// To perform LUT Remapping, you must specify -remap.<br/>
		/// To perform area-based re-synthesis, you must specify -resynth_area, or -directive<br/>
		/// ExploreArea.<br/>
		/// To perform sequential area-based re-synthesis, you must specify -resynth_seq_area, or -<br/>
		/// directive ExploreSequentialArea.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example performs all four default optimizations: retarget, constant propagation,<br/>
		/// sweep, and BRAM power optimization. The command returns detailed results with the -<br/>
		/// verbose switch:<br/>
		/// opt_design -verbose<br/>
		/// This example excludes specific BRAM cells from power optimization using the set_power_opt<br/>
		/// command, and then runs opt_design with the four default optimizations:<br/>
		/// set_power_opt -exclude_cells [get_cells \<br/>
		/// -filter {PRIMITIVE_TYPE =~ BMEM.*.*} \<br/>
		/// -of_objects [get_pins -leaf -filter {DIRECTION == IN} \<br/>
		/// -of_objects [get_nets -of_objects [get_pins clock/bufgctrl_clk_mld/<br/>
		/// O]]]]<br/>
		/// opt_design<br/>
		/// The following example performs the sweep and retarget optimizations:<br/>
		/// opt_design -sweep -retarget<br/>
		/// Note: Because -sweep and -retarget are expressly enabled in the prior example, -propconst<br/>
		/// optimization and -bram_power_opt are implicitly disabled.<br/>
		/// The following example directs the opt_design command to use various algorithms to achieve<br/>
		/// potentially better results:<br/>
		/// opt_design -directive Explore<br/>
		/// The following example directs the opt_design command to use various algorithms to achieve<br/>
		/// potentially better results, while focusing on area reduction:<br/>
		/// opt_design -directive ExploreArea<br/>
		/// This example uses the -srl_remap_modes argument with the automatic option to convert FF<br/>
		/// chains into SRLs when FF utilization is greater than 20%, or SRLs into FF chains when SRL<br/>
		/// utilization is over 50%:<br/>
		/// -srl_remap_modes {{target_ff_util 20 target_lutram_util 50}}<br/>
		/// TIP: In this case, the srl_remap is only performed if either specified utilization rate is exceeded, but NOT if<br/>
		/// both are exceeded.<br/>
		/// The following example uses the -srl_remap_modes argument with the manual option to<br/>
		/// convert FF chains with length greater than 5 to SRLs, and SRLs with depth less than or equal to 8<br/>
		/// to FF chains:<br/>
		/// -srl_remap_modes {{min_depth_ffs_to_srl 5}{max_depth_srl_to_ffs 8}}<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1105<br/>
		/// </para>
		/// </summary>
		/// <param name="retarget">(Optional) Retarget</param>
		/// <param name="propconst">(Optional) Propagate constants across leaf-level instances</param>
		/// <param name="sweep">(Optional) Remove unconnected leaf-level instances</param>
		/// <param name="bram_power_opt">(Optional) Perform Block RAM power optimizations</param>
		/// <param name="remap">(Optional) Remap logic optimally in LUTs</param>
		/// <param name="aggressive_remap">(Optional) High effort remap optimization</param>
		/// <param name="resynth_area">(Optional) Resynthesis</param>
		/// <param name="resynth_seq_area">(Optional) Resynthesis (with Sequential optimizations)</param>
		/// <param name="directive">
		/// <para>
		/// (Optional)<br/>
		/// Mode of behavior (directive) for this command. Please refer<br/>
		/// to Arguments section of this help for values for this option<br/>
		/// Default: Default<br/>
		/// </para>
		/// </param>
		/// <param name="muxf_remap">(Optional) Optimize all MuxFx cells to LUT3</param>
		/// <param name="hier_fanout_limit">(Optional) Replicate by module with threshold N</param>
		/// <param name="bufg_opt">(Optional) Insert, Merge and Split BUFGs</param>
		/// <param name="shift_register_opt">(Optional) Pull register stage from shift register</param>
		/// <param name="dsp_register_opt">(Optional) Push/Pull Registers out of a DSP</param>
		/// <param name="srl_remap_modes">(Optional) remap shift registers to flops or flops to shift registers</param>
		/// <param name="control_set_merge">(Optional) Merge all equivalent control set drivers to a single driver</param>
		/// <param name="merge_equivalent_drivers">(Optional) Merge all LUT,Flop equivalent driver replications</param>
		/// <param name="carry_remap">(Optional) reamp carries into luts</param>
		/// <param name="debug_log">(Optional) show debug message</param>
		/// <param name="property_opt_only">(Optional) Do targeted optimizations on tagged cells</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">
		/// <para>
		/// (Optional)<br/>
		/// Suspend message limits during command execution<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// </param>
		public TTCL opt_design(bool? retarget = null, bool? propconst = null, bool? sweep = null, bool? bram_power_opt = null, bool? remap = null, bool? aggressive_remap = null, bool? resynth_area = null, bool? resynth_seq_area = null, String directive = null, bool? muxf_remap = null, String hier_fanout_limit = null, bool? bufg_opt = null, bool? shift_register_opt = null, bool? dsp_register_opt = null, String srl_remap_modes = null, bool? control_set_merge = null, bool? merge_equivalent_drivers = null, bool? carry_remap = null, bool? debug_log = null, bool? property_opt_only = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: opt_design [-retarget] [-propconst] [-sweep] [-bram_power_opt] [-remap] [-aggressive_remap] [-resynth_area] [-resynth_seq_area] [-directive <arg>] [-muxf_remap] [-hier_fanout_limit <arg>] [-bufg_opt] [-shift_register_opt] [-dsp_register_opt] [-srl_remap_modes <arg>] [-control_set_merge] [-merge_equivalent_drivers] [-carry_remap] [-debug_log] [-property_opt_only] [-quiet] [-verbose]
			_tcl.Entry(_builder.opt_design(retarget, propconst, sweep, bram_power_opt, remap, aggressive_remap, resynth_area, resynth_seq_area, directive, muxf_remap, hier_fanout_limit, bufg_opt, shift_register_opt, dsp_register_opt, srl_remap_modes, control_set_merge, merge_equivalent_drivers, carry_remap, debug_log, property_opt_only, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Optimize the current placed netlist.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: phys_opt_design [-fanout_opt] [-placement_opt] [-routing_opt] [-slr_crossing_opt] [-rewire] [-insert_negative_edge_ffs] [-critical_cell_opt] [-dsp_register_opt] [-bram_register_opt] [-uram_register_opt] [-bram_enable_opt] [-shift_register_opt] [-hold_fix] [-aggressive_hold_fix] [-retime] [-force_replication_on_nets &lt;args&gt;] [-directive &lt;arg&gt;] [-critical_pin_opt] [-clock_opt] [-path_groups &lt;args&gt;] [-tns_cleanup] [-sll_reg_hold_fix] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Performs timing-driven optimization on the negative-slack paths of a design. A path should have<br/>
		/// negative slack near the worst negative slack (WNS) to be considered for optimization.<br/>
		/// Optimization will not be performed on designs without negative slack.<br/>
		/// This optional command can be run for post-place or post-route optimizations.<br/>
		/// RECOMMENDED: Because physical optimization requires timing data that is only available after<br/>
		/// placement, the command cannot be run prior to placement. However, the write_iphys_opt_tcl and<br/>
		/// read_iphys_opt_tcl commands let you write out the physical optimizations performed on the post-placed design, and then apply those optimizations to the design netlist prior to placement. Refer to the<br/>
		/// Vivado Design Suite User Guide: Implementation (UG904) for more information on interactive physical<br/>
		/// optimization.<br/>
		/// Post-place phys_opt_design performs the following optimizations by default:<br/>
		/// • high-fanout optimization<br/>
		/// • placement-based optimization of critical paths<br/>
		/// • rewire<br/>
		/// • critical-cell optimization<br/>
		/// • DSP register optimization<br/>
		/// • BRAM register optimization<br/>
		/// • URAM register optimization<br/>
		/// • a final fanout optimization<br/>
		/// TIP: Using command-line options for specific optimizations results in phys_opt_design performing<br/>
		/// only the specified optimizations and disabling all others, even the ones that are usually performed by<br/>
		/// default.<br/>
		/// Post-route phys_opt_design performs the following optimizations by default:<br/>
		/// • placement-based optimization of critical paths<br/>
		/// • routing optimization<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • rewire<br/>
		/// • critical-cell optimization<br/>
		/// Physical optimizations involve replication, re-timing, hold fixing, and placement improvement.<br/>
		/// The phys_opt_design command automatically performs all necessary netlist and placement<br/>
		/// changes.<br/>
		/// To perform re-timing you must specify the -retime option, or the -directive AddRetime<br/>
		/// option.<br/>
		/// To perform hold fixing you must specify the -hold_fix option, or the -directive<br/>
		/// ExploreWithHoldFix option.<br/>
		/// If the phys_opt_design command is used iteratively, the subsequent run optimizes the results<br/>
		/// of the prior run.<br/>
		/// TIP: The phys_opt_design can be multi-threaded to speed the process. Refer to the set_param<br/>
		/// command for more information on setting the general.maxThreads parameter.<br/>
		/// The command reports each net processed, a summary of any optimizations performed, and the<br/>
		/// WNS before and after optimization. Replicated objects are named by appending _replica to<br/>
		/// the original object name, followed by the replicated object count.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example performs a physical optimization of the current post-placement design,<br/>
		/// and then writes the iphys_opt Tcl script for use before placement:<br/>
		/// phys_opt_design<br/>
		/// write_iphys_opt_tcl C:/Data/my_iphys_opt.tcl<br/>
		/// This example sets the LOCK_PINS property on the specified cell, then performs physical<br/>
		/// optimizations including register re-timing, optimization of registers across DSP blocks and block<br/>
		/// RAMs, and pin swapping (excluding the locked pins) to improve timing:<br/>
		/// set_property LOCK_PINS {I3:A1 I2:A4} [get_cell cpuEngine/<br/>
		/// qmem_dack_reg_i_1]<br/>
		/// phys_opt_design -retime -dsp_register_opt -bram_register_opt \<br/>
		/// -critical_pin_opt<br/>
		/// This example directs phys_opt_design to run more iterations, with hold violation fixing, to<br/>
		/// achieve potentially better results:<br/>
		/// phys_opt_design -directive ExploreWithHoldFix<br/>
		/// This example directs phys_opt_design to consider more nets for replication:<br/>
		/// phys_opt_design -directive AggressiveFanoutOpt<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1114<br/>
		/// </para>
		/// </summary>
		/// <param name="fanout_opt">
		/// <para>
		/// (Optional)<br/>
		/// Do cell-duplication based optimization on high-fanout<br/>
		/// timing critical nets<br/>
		/// </para>
		/// </param>
		/// <param name="placement_opt">(Optional) Do placement based optimization on timing critical nets</param>
		/// <param name="routing_opt">(Optional) Do routing based optimization on timing critical nets</param>
		/// <param name="slr_crossing_opt">(Optional) Do placement optimization of SLR-crossing timing critical nets</param>
		/// <param name="rewire">(Optional) Do rewiring optimization</param>
		/// <param name="insert_negative_edge_ffs">(Optional) Insert negative edge triggered FFs for hold optimization</param>
		/// <param name="critical_cell_opt">(Optional) Do cell-duplication based optimization on timing critical nets</param>
		/// <param name="dsp_register_opt">(Optional) Do DSP register optimization</param>
		/// <param name="bram_register_opt">(Optional) Do BRAM register optimization</param>
		/// <param name="uram_register_opt">(Optional) Do UltraRAM register optimization</param>
		/// <param name="bram_enable_opt">(Optional) Do BRAM enable optimization</param>
		/// <param name="shift_register_opt">(Optional) Do Shift register optimization</param>
		/// <param name="hold_fix">(Optional) Attempt to improve slack of high hold violators</param>
		/// <param name="aggressive_hold_fix">(Optional) Attempt to aggressively improve slack of high hold violators</param>
		/// <param name="retime">(Optional) Do retiming optimization</param>
		/// <param name="force_replication_on_nets">(Optional) Force replication optimization on nets</param>
		/// <param name="directive">
		/// <para>
		/// (Optional)<br/>
		/// Mode of behavior (directive) for this command. Please refer<br/>
		/// to Arguments section of this help for values for this option<br/>
		/// Default: Default<br/>
		/// </para>
		/// </param>
		/// <param name="critical_pin_opt">(Optional) Do pin-swapping based optimization on timing critical nets</param>
		/// <param name="clock_opt">(Optional) Do clock skew optimization in post-route optimization</param>
		/// <param name="path_groups">(Optional) Work only on specified path groups</param>
		/// <param name="tns_cleanup">
		/// <para>
		/// (Optional)<br/>
		/// Work on all nets in the design that meet criteria for the<br/>
		/// specified optimizations to improve design tns<br/>
		/// </para>
		/// </param>
		/// <param name="sll_reg_hold_fix">
		/// <para>
		/// (Optional)<br/>
		/// Do hold fixing on SLL Tx-Rx paths<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Name Description<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL phys_opt_design(bool? fanout_opt = null, bool? placement_opt = null, bool? routing_opt = null, bool? slr_crossing_opt = null, bool? rewire = null, bool? insert_negative_edge_ffs = null, bool? critical_cell_opt = null, bool? dsp_register_opt = null, bool? bram_register_opt = null, bool? uram_register_opt = null, bool? bram_enable_opt = null, bool? shift_register_opt = null, bool? hold_fix = null, bool? aggressive_hold_fix = null, bool? retime = null, TCLParameterList force_replication_on_nets = null, String directive = null, bool? critical_pin_opt = null, bool? clock_opt = null, TCLParameterList path_groups = null, bool? tns_cleanup = null, bool? sll_reg_hold_fix = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: phys_opt_design [-fanout_opt] [-placement_opt] [-routing_opt] [-slr_crossing_opt] [-rewire] [-insert_negative_edge_ffs] [-critical_cell_opt] [-dsp_register_opt] [-bram_register_opt] [-uram_register_opt] [-bram_enable_opt] [-shift_register_opt] [-hold_fix] [-aggressive_hold_fix] [-retime] [-force_replication_on_nets <args>] [-directive <arg>] [-critical_pin_opt] [-clock_opt] [-path_groups <args>] [-tns_cleanup] [-sll_reg_hold_fix] [-quiet] [-verbose]
			_tcl.Entry(_builder.phys_opt_design(fanout_opt, placement_opt, routing_opt, slr_crossing_opt, rewire, insert_negative_edge_ffs, critical_cell_opt, dsp_register_opt, bram_register_opt, uram_register_opt, bram_enable_opt, shift_register_opt, hold_fix, aggressive_hold_fix, retime, force_replication_on_nets, directive, critical_pin_opt, clock_opt, path_groups, tns_cleanup, sll_reg_hold_fix, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Automatically place ports and leaf-level instances<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: place_design [-directive &lt;arg&gt;] [-no_timing_driven] [-timing_summary] [-unplace] [-post_place_opt] [-no_psip] [-no_bufg_opt] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Place the specified ports and logic cells in the current design, or all ports and logic cells, onto<br/>
		/// device resources on the target part. The tool optimizes placement to minimize negative timing<br/>
		/// slack and reduce overall wire length, while also attempting to spread out placement to reduce<br/>
		/// routing congestion.<br/>
		/// Placement is one step of the complete design implementation process, which can be run<br/>
		/// automatically through the use of the launch_runs command when running the Vivado tools in<br/>
		/// Project Mode.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// In Non-Project Mode, the implementation process must be run manually with the individual<br/>
		/// commands: opt_design, place_design, phys_opt_design, power_opt_design, and<br/>
		/// route_design. Refer to the Vivado Design Suite User Guide: Design Flows Overview (UG892) for<br/>
		/// a complete description of Project Mode and Non-Project Mode.<br/>
		/// Both placement and routing can be completed incrementally, based on prior results stored in a<br/>
		/// Design Checkpoint file (DCP), using the incremental implementation flow. Refer to the<br/>
		/// read_checkpoint command, or to Vivado Design Suite User Guide: Implementation (UG904) for<br/>
		/// more information on incremental place and route.<br/>
		/// TIP: The place_design can be multi-threaded to speed the process. Refer to the set_param<br/>
		/// command for more information on setting the general.maxThreads parameter.<br/>
		/// You can also manually place some elements of the design using place_ports, or by setting<br/>
		/// LOC properties on the cell, and then automatically place the remainder of the design using<br/>
		/// place_design.<br/>
		/// This command requires an open synthesized design, and it is recommended that you run the<br/>
		/// opt_design command prior to running place_design to avoid placing a suboptimal netlist.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example places the current design, runs optimization, routes the design, runs post<br/>
		/// placement optimization, and then reroutes the design to cleanup any unconnected nets as a<br/>
		/// result of post placement optimization:<br/>
		/// place_design<br/>
		/// phys_opt_design<br/>
		/// route_design<br/>
		/// place_design -post_place_opt<br/>
		/// phys_opt_design<br/>
		/// route_design<br/>
		/// The following example directs the Vivado placer to try different placement algorithms to achieve<br/>
		/// a better placement result:<br/>
		/// place_design -directive Explore<br/>
		/// This example unplaces the current design:<br/>
		/// place_design -unplace<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1124<br/>
		/// </para>
		/// </summary>
		/// <param name="directive">
		/// <para>
		/// (Optional)<br/>
		/// Mode of behavior (directive) for this command. Please refer<br/>
		/// to Arguments section of this help for values for this option.<br/>
		/// Default: Default<br/>
		/// </para>
		/// </param>
		/// <param name="no_timing_driven">(Optional) Do not run in timing driven mode</param>
		/// <param name="timing_summary">(Optional) Enable accurate post-placement timing summary.</param>
		/// <param name="unplace">(Optional) Unplace all the instances which are not locked by Constraints.</param>
		/// <param name="post_place_opt">(Optional) Run only the post commit optimizer</param>
		/// <param name="no_psip">
		/// <para>
		/// (Optional)<br/>
		/// Disable PSIP (Physical Synthesis In Placer) optimization<br/>
		/// during placement.<br/>
		/// </para>
		/// </param>
		/// <param name="no_bufg_opt">(Optional) Disable global buffer insertion during placement</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL place_design(String directive = null, bool? no_timing_driven = null, bool? timing_summary = null, bool? unplace = null, bool? post_place_opt = null, bool? no_psip = null, bool? no_bufg_opt = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: place_design [-directive <arg>] [-no_timing_driven] [-timing_summary] [-unplace] [-post_place_opt] [-no_psip] [-no_bufg_opt] [-quiet] [-verbose]
			_tcl.Entry(_builder.place_design(directive, no_timing_driven, timing_summary, unplace, post_place_opt, no_psip, no_bufg_opt, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// load iPhysOpt script and run it.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_iphys_opt_tcl [-fanout_opt] [-critical_cell_opt] [-placement_opt] [-rewire] [-dsp_register_opt] [-bram_register_opt] [-uram_register_opt] [-shift_register_opt] [-auto_pipeline] [-critical_pin_opt] [-equ_drivers_opt] [-include_skipped_optimizations] [-insert_negative_edge_ffs] [-hold_fix] [-slr_crossing_opt] [-quiet] [-verbose] [&lt;input&gt;]
		/// <br/>
		/// <para>
		/// Interactive physical optimization can be used in two ways:<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • Applying post-placement physical optimizations to the pre-placement netlist to improve the<br/>
		/// overall placement result and improve design performance.<br/>
		/// • Saving the physical optimizations in a Tcl script to be repeated as needed.<br/>
		/// To apply post-placement optimizations to the pre-placement netlist, you can reset the<br/>
		/// implementation run and open the synthesized design, or open the opt_design checkpoint, and<br/>
		/// read the iphys_opt Tcl script to apply the physical optimizations.<br/>
		/// You can apply all optimizations from the iphys_opt Tcl script, or apply specific optimizations using<br/>
		/// the options of the read_iphys_opt_tcl command. You can also include any optimizations<br/>
		/// that were defined but skipped during physical optimization.<br/>
		/// If the iphys_opt Tcl script includes placement data, you can use that data to place the optimized<br/>
		/// cells in the design.<br/>
		/// After reading the iphys_opt Tcl script, and placing the optimized cells, you can rerun placement<br/>
		/// for the overall design. The design now incorporates the benefits of the phys_opt_design<br/>
		/// optimizations before placement, such as fewer high-fanout nets due to replication, and fewer<br/>
		/// long distance paths from block RAM outputs. The results should be a better placement, and<br/>
		/// improved design performance, due to the early application of netlist optimizations.<br/>
		/// This command returns a transcript of its processes, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example applies the BRAM optimizations that are defined in the specified<br/>
		/// interactive physical optimization Tcl script, and applies any placement data for the optimized<br/>
		/// cells:<br/>
		/// open_checkpoint C:/Data/opt_design.dcp<br/>
		/// read_iphys_opt_tcl -shift_register_opt -placement_opt C:/Data/<br/>
		/// my_iphys_opt.tcl<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1169<br/>
		/// </para>
		/// </summary>
		/// <param name="input">(Required) iPhysOpt.tcl file</param>
		/// <param name="fanout_opt">(Optional) Fanout optimization including very high fanout optimizations</param>
		/// <param name="critical_cell_opt">(Optional) Do cell-duplication based optimization on timing critical nets</param>
		/// <param name="placement_opt">(Optional) Move cells to reduce delay on timing-critical nets</param>
		/// <param name="rewire">(Optional) Do rewiring optimization</param>
		/// <param name="dsp_register_opt">(Optional) DSP register optimization</param>
		/// <param name="bram_register_opt">(Optional) BRAM register optimization</param>
		/// <param name="uram_register_opt">(Optional) UltraRAM register optimization</param>
		/// <param name="shift_register_opt">(Optional) Shift register optimization</param>
		/// <param name="auto_pipeline">(Optional) Auto pipeline</param>
		/// <param name="critical_pin_opt">(Optional) Pin Swap optimization</param>
		/// <param name="equ_drivers_opt">(Optional) Equivalent driver rewiring</param>
		/// <param name="include_skipped_optimizations">(Optional) Apply undo changes</param>
		/// <param name="insert_negative_edge_ffs">(Optional) Inserting negative edge triggered FFs for high hold mitigation</param>
		/// <param name="hold_fix">(Optional) Inserting buffers for hold fix optimization</param>
		/// <param name="slr_crossing_opt">(Optional) Optimize slr crossing nets</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL read_iphys_opt_tcl(String input, bool? fanout_opt = null, bool? critical_cell_opt = null, bool? placement_opt = null, bool? rewire = null, bool? dsp_register_opt = null, bool? bram_register_opt = null, bool? uram_register_opt = null, bool? shift_register_opt = null, bool? auto_pipeline = null, bool? critical_pin_opt = null, bool? equ_drivers_opt = null, bool? include_skipped_optimizations = null, bool? insert_negative_edge_ffs = null, bool? hold_fix = null, bool? slr_crossing_opt = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_iphys_opt_tcl [-fanout_opt] [-critical_cell_opt] [-placement_opt] [-rewire] [-dsp_register_opt] [-bram_register_opt] [-uram_register_opt] [-shift_register_opt] [-auto_pipeline] [-critical_pin_opt] [-equ_drivers_opt] [-include_skipped_optimizations] [-insert_negative_edge_ffs] [-hold_fix] [-slr_crossing_opt] [-quiet] [-verbose] [<input>]
			_tcl.Entry(_builder.read_iphys_opt_tcl(input, fanout_opt, critical_cell_opt, placement_opt, rewire, dsp_register_opt, bram_register_opt, uram_register_opt, shift_register_opt, auto_pipeline, critical_pin_opt, equ_drivers_opt, include_skipped_optimizations, insert_negative_edge_ffs, hold_fix, slr_crossing_opt, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Register a Tcl proc with Vivado.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: register_proc [-quiet] [-verbose] &lt;proc&gt; [&lt;tasknm&gt;]
		/// <br/>
		/// <para>
		/// Register a Tcl procedure (proc) with the Vivado Tcl command interpretor to register the command<br/>
		/// with the Vivado Design Suite help system.<br/>
		/// The following is an example Tcl proc defined for use with the Vivado Design Suite:<br/>
		/// proc findCommand {option} {<br/>
		/// # Summary:<br/>
		/// # Searches through all Vivado Tcl commands for commands implementing<br/>
		/// # the specified argument.<br/>
		/// # Argument Usage:<br/>
		/// # option: Specifies the argument to search for.<br/>
		/// # Return Value:<br/>
		/// # Returns a list of Tcl commands that implement the option.<br/>
		/// # Categories: personal<br/>
		/// foreach cmd [lsort [info commands *]]<br/>
		/// {<br/>
		/// catch {<br/>
		/// if {[regexp "$option" [help -syntax $cmd]]}<br/>
		/// {<br/>
		/// puts $cmd<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// }<br/>
		/// }<br/>
		/// }<br/>
		/// } ;<br/>
		/// # End<br/>
		/// The commented lines beginning with '#' are used to define the help text for the registered<br/>
		/// command in the Vivado Design Suite help system.<br/>
		/// • # Summary: provides a brief description of the command.<br/>
		/// • # Argument Usage: provides a list and description of the various arguments for the proc.<br/>
		/// • # Return Value: provides a description of what is returned by the proc.<br/>
		/// • # Categories: provides an ability to define categories for registered procedures.<br/>
		/// After registering the procedure as a Tcl command, the Vivado help system will return this text<br/>
		/// when queried with:<br/>
		/// tasknm -help<br/>
		/// -or-<br/>
		/// help tasknm<br/>
		/// This command returns the name of the registered proc.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1226<br/>
		/// </para>
		/// </summary>
		/// <param name="proc">(Required) Name of proc to register. Proc must be known to Tcl</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="tasknm">
		/// <para>
		/// (Optional)<br/>
		/// Name of Tcl task that wraps the proc. Default: Register the<br/>
		/// proc using the root name proc (no namespaces).<br/>
		/// </para>
		/// </param>
		/// <returns>Nothing</returns>
		public TTCL register_proc(String proc, bool? quiet = null, bool? verbose = null, String tasknm = null)
		{
			// TCL Syntax: register_proc [-quiet] [-verbose] <proc> [<tasknm>]
			_tcl.Entry(_builder.register_proc(proc, quiet, verbose, tasknm));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Perform pipeline register insertion analysis and display report.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_pipeline_analysis [-cells &lt;args&gt;] [-verbose] [-clocks &lt;args&gt;] [-file &lt;arg&gt;] [-include_paths_to_pipeline] [-append] [-max_added_latency &lt;arg&gt;] [-report_loops] [-return_string] [-quiet]
		/// <br/>
		/// <para>
		/// This command performs an analysis of a synthesized design, hypothetically inserting pipeline<br/>
		/// stages in the design and reports the potential frequency (Fmax) increase of each clock domain.<br/>
		/// The analysis includes a search for loops in the design, which may not be improved by pipelining,<br/>
		/// and determines if such loops are critical paths in the design.<br/>
		/// Returns a table showing the pipeline stages and the Fmax improvement. The report begins with<br/>
		/// the original design and adds stages of latency (1, 2, ... ) until there is no further improvement in<br/>
		/// Fmax. This reports a theoretical upper limit to the frequency performance of the design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The analysis is typically run on the un-placed synthesized netlist where the logical netlist<br/>
		/// structure determines the performance. The report can be run on the top-level design, or on out-of-context (OOC) sub-modules. This report confirms whether the design frequency can be<br/>
		/// increased, as well as how many pipeline registers must be added to the design to achieve the<br/>
		/// Fmax improvement.<br/>
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be<br/>
		/// written to a file.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the name, period, waveform, and sources of the clocks in the<br/>
		/// current design:<br/>
		/// report_pipeline_analysis -file C:/Data/FPGA_Design/pipeline_report.txt<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1403<br/>
		/// </para>
		/// </summary>
		/// <param name="cells">
		/// <para>
		/// (Optional)<br/>
		/// Analyze each of the specified hierarchical cells separately<br/>
		/// and ignore feedback loops external to the cells.<br/>
		/// </para>
		/// </param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="clocks">(Optional) Filter report output to show only the specified clocks</param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="include_paths_to_pipeline">(Optional) Report paths to cut. (only available if -file is used)</param>
		/// <param name="append">(Optional) Append to existing file</param>
		/// <param name="max_added_latency">
		/// <para>
		/// (Optional)<br/>
		/// Maximum extra latency that can be inserted into the system<br/>
		/// (0 = unlimited). Default: 100<br/>
		/// </para>
		/// </param>
		/// <param name="report_loops">(Optional) Report loop information as well</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		public TTCL report_pipeline_analysis(TCLParameterList cells = null, bool? verbose = null, TCLParameterList clocks = null, String file = null, bool? include_paths_to_pipeline = null, bool? append = null, String max_added_latency = null, bool? report_loops = null, bool? return_string = null, bool? quiet = null)
		{
			// TCL Syntax: report_pipeline_analysis [-cells <args>] [-verbose] [-clocks <args>] [-file <arg>] [-include_paths_to_pipeline] [-append] [-max_added_latency <arg>] [-report_loops] [-return_string] [-quiet]
			_tcl.Entry(_builder.report_pipeline_analysis(cells, verbose, clocks, file, include_paths_to_pipeline, append, max_added_latency, report_loops, return_string, quiet));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Route the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: route_design [-unroute] [-release_memory] [-nets &lt;args&gt;] [-physical_nets] [-pins &lt;arg&gt;] [-directive &lt;arg&gt;] [-tns_cleanup] [-no_timing_driven] [-preserve] [-delay] [-auto_delay] -max_delay &lt;arg&gt; -min_delay &lt;arg&gt; [-timing_summary] [-finalize] [-ultrathreads] [-eco] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Route the nets in the current design to complete logic connections on the target part.<br/>
		/// Predefined routing strategies can be quickly selected using the route_design -directive<br/>
		/// command, or specific route options can be configured to define your own routing strategy.<br/>
		/// Routing can be completed automatically with route_design, or can be completed iteratively<br/>
		/// using the various options of the route_design command to achieve route completion and<br/>
		/// timing closure. Iterative routing provides you some control over the routing process to route<br/>
		/// critical nets first and then route less critical nets, and to control the level of effort and the timing<br/>
		/// algorithms for these various route passes.<br/>
		/// Routing is one step of the complete design implementation process, which can be run<br/>
		/// automatically through the use of the launch_runs command when running the Vivado tools in<br/>
		/// Project Mode.<br/>
		/// In Non-Project Mode, the implementation process must be run manually with the individual<br/>
		/// commands: opt_design, place_design, phys_opt_design, power_opt_design, and<br/>
		/// route_design. Refer to the Vivado Design Suite User Guide: Design Flows Overview (UG892) for a<br/>
		/// complete description of Project Mode and Non-Project Mode.<br/>
		/// TIP: The route_design can be multi-threaded to speed the process. Refer to the set_param<br/>
		/// command for more information on setting the general.maxThreads parameter.<br/>
		/// Both placement and routing can be completed incrementally, based on prior results stored in a<br/>
		/// Design Checkpoint file (DCP), using the incremental implementation flow. Refer to the<br/>
		/// read_checkpoint command, or to Vivado Design Suite User Guide: Implementation (UG904) for<br/>
		/// more information on incremental place and route.<br/>
		/// This command requires a placed design, and it is recommended that you have optimized the<br/>
		/// design with opt_design prior to placement.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// Route the entire design, and direct the router to try multiple algorithms for improving critical<br/>
		/// path delay:<br/>
		/// route_design -directive Explore<br/>
		/// The following example routes the set of timing critical nets, $criticalNets, to the shortest<br/>
		/// interconnect delay, marks the nets as fixed using the IS_ROUTE_FIXED property, and then routes<br/>
		/// the rest of the design using a low effort directive for fast results:<br/>
		/// route_design -delay -nets $criticalNets<br/>
		/// set_property IS_ROUTE_FIXED 1 $criticalNets<br/>
		/// route_design -directive RuntimeOptimized<br/>
		/// Route the specified nets using the fastest runtime:<br/>
		/// route_design -nets [get_nets ctrl0/ctr*]<br/>
		/// Route the specified nets to get the shortest interconnect delays:<br/>
		/// route_design -nets [get_nets ctrl0/ctr*] -delay<br/>
		/// Route to the specified pins:<br/>
		/// route_design -pins [get_pins ctrl0/reset_reg/D ctrl0/ram0/ADDRARDADDR]<br/>
		/// Route to a particular pin, try to achieve less than 500 ps delay:<br/>
		/// route_design -pins [get_pins ctrl0/reset_reg/D] -max_delay 500<br/>
		/// Route to a particular pin, try to achieve more than 200 ps delay:<br/>
		/// route_design -pins [get_pins ctrl0/ram0/ADDRARDADDR] -min_delay 200<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1539<br/>
		/// </para>
		/// </summary>
		/// <param name="max_delay">
		/// <para>
		/// (Required)<br/>
		/// Use with -pins option to specify the max_delay constraint on<br/>
		/// the pins.When specified -delay is implicit.<br/>
		/// </para>
		/// </param>
		/// <param name="min_delay">
		/// <para>
		/// (Required)<br/>
		/// Use with -pins option to specify the max_delay constraint on<br/>
		/// the pins.When specified -delay is implicit.<br/>
		/// </para>
		/// </param>
		/// <param name="unroute">
		/// <para>
		/// (Optional)<br/>
		/// Unroute whole design or the given nets/pins if used with -<br/>
		/// nets or -pins.<br/>
		/// </para>
		/// </param>
		/// <param name="release_memory">(Optional) Release Router memory. Not compatible with any other options.</param>
		/// <param name="nets">(Optional) Operate on the given nets.</param>
		/// <param name="physical_nets">(Optional) Operate on all physical nets.</param>
		/// <param name="pins">(Optional) Operate on the given pins.</param>
		/// <param name="directive">
		/// <para>
		/// (Optional)<br/>
		/// Mode of behavior (directive) for this command. Please refer<br/>
		/// to Arguments section of this help for values for this option.<br/>
		/// Default: Default<br/>
		/// </para>
		/// </param>
		/// <param name="tns_cleanup">(Optional) Do optional TNS clean up.</param>
		/// <param name="no_timing_driven">(Optional) Do not run in timing driven mode.</param>
		/// <param name="preserve">(Optional) Preserve existing routing.</param>
		/// <param name="delay">(Optional) Use with -nets or -pins option to route in delay driven mode.</param>
		/// <param name="auto_delay">(Optional) Use with -nets or -pins option to route in constraint driven mode.</param>
		/// <param name="timing_summary">(Optional) Enable post-router signoff timing summary.</param>
		/// <param name="finalize">(Optional) finalize route_design in interactive mode.</param>
		/// <param name="ultrathreads">(Optional) Enable Turbo mode routing.</param>
		/// <param name="eco">
		/// <para>
		/// (Optional)<br/>
		/// runs incremental router if there was eco modification on<br/>
		/// routed netlist.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL route_design(String max_delay, String min_delay, bool? unroute = null, bool? release_memory = null, TCLParameterList nets = null, bool? physical_nets = null, String pins = null, String directive = null, bool? tns_cleanup = null, bool? no_timing_driven = null, bool? preserve = null, bool? delay = null, bool? auto_delay = null, bool? timing_summary = null, bool? finalize = null, bool? ultrathreads = null, bool? eco = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: route_design [-unroute] [-release_memory] [-nets <args>] [-physical_nets] [-pins <arg>] [-directive <arg>] [-tns_cleanup] [-no_timing_driven] [-preserve] [-delay] [-auto_delay] -max_delay <arg> -min_delay <arg> [-timing_summary] [-finalize] [-ultrathreads] [-eco] [-quiet] [-verbose]
			_tcl.Entry(_builder.route_design(max_delay, min_delay, unroute, release_memory, nets, physical_nets, pins, directive, tns_cleanup, no_timing_driven, preserve, delay, auto_delay, timing_summary, finalize, ultrathreads, eco, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Synthesize a design using Vivado Synthesis and open that design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: synth_design [-name &lt;arg&gt;] [-part &lt;arg&gt;] [-constrset &lt;arg&gt;] [-top &lt;arg&gt;] [-include_dirs &lt;args&gt;] [-generic &lt;args&gt;] [-verilog_define &lt;args&gt;] [-flatten_hierarchy &lt;arg&gt;] [-gated_clock_conversion &lt;arg&gt;] [-directive &lt;arg&gt;] [-rtl] [-bufg &lt;arg&gt;] [-no_lc] [-shreg_min_size &lt;arg&gt;] [-mode &lt;arg&gt;] [-fsm_extraction &lt;arg&gt;] [-rtl_skip_mlo] [-rtl_skip_ip] [-rtl_skip_constraints] [-srl_style &lt;arg&gt;] [-keep_equivalent_registers] [-resource_sharing &lt;arg&gt;] [-cascade_dsp &lt;arg&gt;] [-control_set_opt_threshold &lt;arg&gt;] [-incremental &lt;arg&gt;] [-max_bram &lt;arg&gt;] [-max_uram &lt;arg&gt;] [-max_dsp &lt;arg&gt;] [-max_bram_cascade_height &lt;arg&gt;] [-max_uram_cascade_height &lt;arg&gt;] [-retiming] [-no_srlextract] [-assert] [-no_timing_driven] [-sfcu] [-debug_log] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Directly launches the Vivado synthesis engine to compile and synthesize a design in either<br/>
		/// Project Mode or Non-Project Mode in the Vivado Design Suite. Refer to the Vivado Design Suite<br/>
		/// User Guide: Design Flows Overview (UG892) for a complete description of Project Mode and Non-Project Mode.<br/>
		/// Vivado synthesis can be launched directly with the synth_design command in the Non-Project Mode of the Vivado Design Suite.<br/>
		/// TIP: The synth_design can be multi-threaded to speed the process. Refer to the set_param<br/>
		/// command for more information on setting the general.maxThreads parameter.<br/>
		/// In Project Mode, synthesis should be launched from an existing synthesis run created with the<br/>
		/// create_run command. The run is launched using the launch_runs command, and this in turn<br/>
		/// calls synth_design for Vivado synthesis.<br/>
		/// You can also use the synth_design command to elaborate RTL source files, and open an<br/>
		/// elaborated design:<br/>
		/// synth_design -rtl -name rtl_1<br/>
		/// This command returns a transcript of the synthesis process, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example uses the set_property command to define the target part for the<br/>
		/// active project, then elaborates the source files and opens an RTL design:<br/>
		/// set_property part xc7vx485tffg1158-1 [current_project]<br/>
		/// synth_design -rtl -name rtl_1<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: The default source set, constraint set, and part will be used in this example.<br/>
		/// The following example uses the find_top command to define the top of the current design for<br/>
		/// synthesis:<br/>
		/// synth_design -top [lindex [find_top] 0]<br/>
		/// Note: Since find_top returns multiple possible candidates, choosing index 0 chooses the best top<br/>
		/// candidate for synthesis.<br/>
		/// The following example runs synthesis on the current design, defining the top module and the<br/>
		/// target part, and specifying no flattening of the hierarchy. The results of the synthesis run are then<br/>
		/// opened in a netlist design:<br/>
		/// synth_design -top top -part xc7k70tfbg676-2 -flatten_hierarchy none<br/>
		/// open_run synth_1 -name netlist_1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1733<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Optional) Design name</param>
		/// <param name="part">(Optional) Target part</param>
		/// <param name="constrset">(Optional) Constraint fileset to use</param>
		/// <param name="top">(Optional) Specify the top module name</param>
		/// <param name="include_dirs">(Optional) Specify verilog search directories</param>
		/// <param name="generic">
		/// <para>
		/// (Optional)<br/>
		/// Specify generic parameters. Syntax: -generic<br/>
		/// &lt;name&gt;=&lt;value&gt; -generic &lt;name&gt;=&lt;value&gt; ...<br/>
		/// </para>
		/// </param>
		/// <param name="verilog_define">
		/// <para>
		/// (Optional)<br/>
		/// Specify verilog defines. Syntax: -verilog_define<br/>
		/// &lt;macro_name&gt;[=&lt;macro_text&gt;] -verilog_define<br/>
		/// &lt;macro_name&gt;[=&lt;macro_text&gt;] ...<br/>
		/// </para>
		/// </param>
		/// <param name="flatten_hierarchy">
		/// <para>
		/// (Optional)<br/>
		/// Flatten hierarchy during LUT mapping. Values: full, none,<br/>
		/// rebuilt Default: rebuilt<br/>
		/// </para>
		/// </param>
		/// <param name="gated_clock_conversion">
		/// <para>
		/// (Optional)<br/>
		/// Convert clock gating logic to flop enable. Values: off, on,<br/>
		/// auto Default: off<br/>
		/// </para>
		/// </param>
		/// <param name="directive">
		/// <para>
		/// (Optional)<br/>
		/// Synthesis directive. Values: default, RuntimeOptimized,<br/>
		/// AreaOptimized_high,<br/>
		/// AreaOptimized_medium,AlternateRoutability,<br/>
		/// AreaMapLargeShiftRegToBRAM, AreaMultThresholdDSP,<br/>
		/// FewerCarryChains,Perfor manceOptimized,<br/>
		/// LogicCompaction Default: default<br/>
		/// </para>
		/// </param>
		/// <param name="rtl">(Optional) Elaborate and open an rtl design</param>
		/// <param name="bufg">
		/// <para>
		/// (Optional)<br/>
		/// Max number of global clock buffers used by synthesis<br/>
		/// Default: 12<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Name Description<br/>
		/// </para>
		/// </param>
		/// <param name="no_lc">
		/// <para>
		/// (Optional)<br/>
		/// Disable LUT combining. Do not allow combining LUT pairs<br/>
		/// into single dual output LUTs.<br/>
		/// </para>
		/// </param>
		/// <param name="shreg_min_size">(Optional) Minimum length for chain of registers to be mapped onto SRL Default: 3</param>
		/// <param name="mode">(Optional) The design mode. Values: default, out_of_context Default: default</param>
		/// <param name="fsm_extraction">
		/// <para>
		/// (Optional)<br/>
		/// FSM Extraction Encoding. Values: off, one_hot, sequential,<br/>
		/// johnson, gray, user_encoding, auto Default: auto<br/>
		/// </para>
		/// </param>
		/// <param name="rtl_skip_mlo">
		/// <para>
		/// (Optional)<br/>
		/// Skip mandatory logic optimization for RTL elaboration of the<br/>
		/// design; requires -rtl option.<br/>
		/// </para>
		/// </param>
		/// <param name="rtl_skip_ip">
		/// <para>
		/// (Optional)<br/>
		/// Exclude subdesign checkpoints in the RTL elaboration of the<br/>
		/// design; requires -rtl option.<br/>
		/// </para>
		/// </param>
		/// <param name="rtl_skip_constraints">
		/// <para>
		/// (Optional)<br/>
		/// Do not load and validate constraints against elaborated<br/>
		/// design; requires -rtl option.<br/>
		/// </para>
		/// </param>
		/// <param name="srl_style">
		/// <para>
		/// (Optional)<br/>
		/// Static SRL Implementation Style. Values: register, srl, srl_reg,<br/>
		/// reg_srl, reg_srl_reg<br/>
		/// </para>
		/// </param>
		/// <param name="keep_equivalent_registers">
		/// <para>
		/// (Optional)<br/>
		/// Prevents registers sourced by the same logic from being<br/>
		/// merged. (Note that the merging can otherwise be<br/>
		/// prevented using the synthesis KEEP attribute)<br/>
		/// </para>
		/// </param>
		/// <param name="resource_sharing">(Optional) Sharing arithmetic operators. Value: auto, on, off Default: auto</param>
		/// <param name="cascade_dsp">
		/// <para>
		/// (Optional)<br/>
		/// Controls how adders summing DSP block outputs will be<br/>
		/// implemented. Value: auto, tree, force Default: auto<br/>
		/// </para>
		/// </param>
		/// <param name="control_set_opt_threshold">
		/// <para>
		/// (Optional)<br/>
		/// Threshold for synchronous control set optimization to lower<br/>
		/// number of control sets. Valid values are 'auto' and non-negative integers. The higher the number, the more control<br/>
		/// set optimization will be performed and fewer control sets<br/>
		/// will result. To disable control set optimization completely,<br/>
		/// set to 0. Default: auto<br/>
		/// </para>
		/// </param>
		/// <param name="incremental">(Optional) dcp file for incremental flowvalue of this is the file name</param>
		/// <param name="max_bram">
		/// <para>
		/// (Optional)<br/>
		/// Maximum number of block RAM allowed in design. (Note -1<br/>
		/// means that the tool will choose the max number allowed for<br/>
		/// the part in question) Default: -1<br/>
		/// </para>
		/// </param>
		/// <param name="max_uram">
		/// <para>
		/// (Optional)<br/>
		/// Maximum number of Ultra RAM blocks allowed in design.<br/>
		/// (Note -1 means that the tool will choose the max number<br/>
		/// allowed for the part in question) Default: -1<br/>
		/// </para>
		/// </param>
		/// <param name="max_dsp">
		/// <para>
		/// (Optional)<br/>
		/// Maximum number of block DSP allowed in design. (Note -1<br/>
		/// means that the tool will choose the max number allowed for<br/>
		/// the part in question) Default: -1<br/>
		/// </para>
		/// </param>
		/// <param name="max_bram_cascade_height">
		/// <para>
		/// (Optional)<br/>
		/// Controls the maximum number of BRAM that can be<br/>
		/// cascaded by the tool. (Note -1 means that the tool will<br/>
		/// choose the max number allowed for the part in question)<br/>
		/// Default: -1<br/>
		/// </para>
		/// </param>
		/// <param name="max_uram_cascade_height">
		/// <para>
		/// (Optional)<br/>
		/// Controls the maximum number of URAM that can be<br/>
		/// cascaded by the tool. (Note -1 means that the tool will<br/>
		/// choose the max number allowed for the part in question)<br/>
		/// Default: -1<br/>
		/// </para>
		/// </param>
		/// <param name="retiming">
		/// <para>
		/// (Optional)<br/>
		/// Seeks to improve circuit performance for intra-clock<br/>
		/// sequential paths by automatically moving registers (register<br/>
		/// balancing) across combinatorial gates or LUTs. It maintains<br/>
		/// the original behavior and latency of the circuit and does not<br/>
		/// require changes to the RTL sources.<br/>
		/// </para>
		/// </param>
		/// <param name="no_srlextract">
		/// <para>
		/// (Optional)<br/>
		/// Prevents the extraction of shift registers so that they get<br/>
		/// implemented as simple registers<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Name Description<br/>
		/// </para>
		/// </param>
		/// <param name="assert">
		/// <para>
		/// (Optional)<br/>
		/// Enable VHDL assert statements to be evaluated. A severity<br/>
		/// level of failure will stop the synthesis flow and produce an<br/>
		/// error.<br/>
		/// </para>
		/// </param>
		/// <param name="no_timing_driven">(Optional) Do not run in timing driven mode</param>
		/// <param name="sfcu">(Optional) Run in single-file compilation unit mode</param>
		/// <param name="debug_log">(Optional) Print detailed log files for debugging</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>design object</returns>
		public TTCL synth_design(String name = null, String part = null, String constrset = null, String top = null, TCLParameterList include_dirs = null, TCLParameterList generic = null, TCLParameterList verilog_define = null, synth_design_flatten_hierarchy? flatten_hierarchy = null, synth_design_gated_clock_conversion? gated_clock_conversion = null, synth_design_directive? directive = null, bool? rtl = null, Int32? bufg = null, bool? no_lc = null, String shreg_min_size = null, synth_design_mode? mode = null, synth_design_fsm_extraction? fsm_extraction = null, bool? rtl_skip_mlo = null, bool? rtl_skip_ip = null, bool? rtl_skip_constraints = null, synth_design_srl_style? srl_style = null, bool? keep_equivalent_registers = null, String resource_sharing = null, String cascade_dsp = null, Int32? control_set_opt_threshold = null, String incremental = null, Int32? max_bram = null, Int32? max_uram = null, Int32? max_dsp = null, Int32? max_bram_cascade_height = null, Int32? max_uram_cascade_height = null, bool? retiming = null, bool? no_srlextract = null, bool? assert = null, bool? no_timing_driven = null, bool? sfcu = null, bool? debug_log = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: synth_design [-name <arg>] [-part <arg>] [-constrset <arg>] [-top <arg>] [-include_dirs <args>] [-generic <args>] [-verilog_define <args>] [-flatten_hierarchy <arg>] [-gated_clock_conversion <arg>] [-directive <arg>] [-rtl] [-bufg <arg>] [-no_lc] [-shreg_min_size <arg>] [-mode <arg>] [-fsm_extraction <arg>] [-rtl_skip_mlo] [-rtl_skip_ip] [-rtl_skip_constraints] [-srl_style <arg>] [-keep_equivalent_registers] [-resource_sharing <arg>] [-cascade_dsp <arg>] [-control_set_opt_threshold <arg>] [-incremental <arg>] [-max_bram <arg>] [-max_uram <arg>] [-max_dsp <arg>] [-max_bram_cascade_height <arg>] [-max_uram_cascade_height <arg>] [-retiming] [-no_srlextract] [-assert] [-no_timing_driven] [-sfcu] [-debug_log] [-quiet] [-verbose]
			_tcl.Entry(_builder.synth_design(name, part, constrset, top, include_dirs, generic, verilog_define, flatten_hierarchy, gated_clock_conversion, directive, rtl, bufg, no_lc, shreg_min_size, mode, fsm_extraction, rtl_skip_mlo, rtl_skip_ip, rtl_skip_constraints, srl_style, keep_equivalent_registers, resource_sharing, cascade_dsp, control_set_opt_threshold, incremental, max_bram, max_uram, max_dsp, max_bram_cascade_height, max_uram_cascade_height, retiming, no_srlextract, assert, no_timing_driven, sfcu, debug_log, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Unregister a previously registered Tcl proc.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: unregister_proc [-quiet] [-verbose] &lt;tasknm&gt;
		/// <br/>
		/// <para>
		/// Unregister the Tcl command, or &lt;tasknm&gt;, from the Vivado Design Suite Tcl interpretor.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1756<br/>
		/// </para>
		/// </summary>
		/// <param name="tasknm">(Required) Name of Tcl task to unregister. The task must be wrapping a proc.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Nothing</returns>
		public TTCL unregister_proc(String tasknm, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: unregister_proc [-quiet] [-verbose] <tasknm>
			_tcl.Entry(_builder.unregister_proc(tasknm, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Update clock routing on global clocks if they are modified after placement<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: update_clock_routing [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// The update_clock_routing command is an advanced command used for manually updating<br/>
		/// the routing structures of all global clocks in designs targeting the UltraScale architecture. The<br/>
		/// command operates on all global clocks in a design, not individual clocks.<br/>
		/// Due to a more flexible clocking architecture, UltraScale and UltraScale+ designs require a two-step process for routing global clocks. First the Vivado placer assigns the routing resources<br/>
		/// required to route the global clocks from the clock source to the destination clock regions<br/>
		/// (CLOCK_ROOT or USER_CLOCK_ROOT). Next the Vivado router fills in the routing gaps on the<br/>
		/// clock nets. In between these two steps the resulting structures are called gap trees: each global<br/>
		/// clock net has its base routing resources assigned but with large routing gaps where no routing<br/>
		/// resources have been assigned.<br/>
		/// After gap trees are constructed, the router optimally routes the remaining clock network to all<br/>
		/// leaf-level primitives to fill in the routing gaps. During an implementation run the global clock<br/>
		/// routing is handled automatically. However in cases where the clock tree has been changed after<br/>
		/// implementation, by modifying the USER_CLOCK_ROOT property on a clock net for instance, the<br/>
		/// Vivado tool may need the update_clock_routing command to properly rebuild the gap trees<br/>
		/// and fill in the routing gaps.<br/>
		/// Examples of this include:<br/>
		/// • Moving the clock root of a global clock.<br/>
		/// • Adding or moving loads of a global clock into a clock region not yet occupied by the global<br/>
		/// clock, then running timing analysis on the updated design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// • Moving the clock root of a global clock.<br/>
		/// • Adding or moving loads of a global clock into a clock region not yet occupied by the global<br/>
		/// clock, then running timing analysis on the updated design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Arguments<br/>
		/// -quiet - (Optional) Execute the command quietly, returning no messages from the command.<br/>
		/// The command also returns TCL_OK regardless of any errors encountered during execution.<br/>
		/// Note: Any errors encountered on the command-line, while launching the command, will be returned. Only<br/>
		/// errors occurring inside the command will be trapped.<br/>
		/// -verbose - (Optional) Temporarily override any message limits and return all messages from this<br/>
		/// command.<br/>
		/// Note: Message limits can be defined with the set_msg_config command.<br/>
		/// Examples<br/>
		/// The following example updates the USER_CLOCK_ROOT property on the specified clock nets,<br/>
		/// unroutes the nets, and then updates the clock routing:<br/>
		/// set_property USER_CLOCK_ROOT X1Y0 [get_nets {clk1 clk2}]<br/>
		/// route_design -unroute -nets [get_nets {clk1 clk2}]<br/>
		/// update_clock_routing<br/>
		/// IMPORTANT! The unroute command is needed to clean out existing clock routing on the clock nets<br/>
		/// before updating the clock routing.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1761<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL update_clock_routing(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: update_clock_routing [-quiet] [-verbose]
			_tcl.Entry(_builder.update_clock_routing(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Update the NoC solution<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: update_noc_qos [-force] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1781<br/>
		/// </para>
		/// </summary>
		/// <param name="force">(Optional) Force update even if the existing solution is invalid</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL update_noc_qos(bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: update_noc_qos [-force] [-quiet] [-verbose]
			_tcl.Entry(_builder.update_noc_qos(force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write iPhysOpt script.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_iphys_opt_tcl [-place] [-binary] [-quiet] [-verbose] [&lt;output&gt;]
		/// <br/>
		/// <para>
		/// Because physical optimization requires timing data that is only available after placement, the<br/>
		/// phys_opt_design command cannot be run prior to placement. However, the interactive<br/>
		/// physical optimization feature, or iphys_opt_design, lets you write out the physical<br/>
		/// optimizations performed on the post-placed design, and then apply those optimizations to the<br/>
		/// design netlist prior to placement. Refer to the Vivado Design Suite User Guide: Implementation<br/>
		/// (UG904) for more information on interactive physical optimization.<br/>
		/// Interactive physical optimization can be used in two ways:<br/>
		/// • Applying post-placement physical optimizations to the pre-placement netlist to improve the<br/>
		/// overall placement result and improve design performance.<br/>
		/// • Saving the physical optimizations in a Tcl script to be repeated as needed.<br/>
		/// The write_iphys_opt_tcl command can only be run after placement, on a design that has<br/>
		/// had actual physical optimizations performed.<br/>
		/// TIP: You can use the report_phys_opt command to report the physical optimizations that have been<br/>
		/// performed on the design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The output is a Tcl script file with a sequence of iphys_opt_design commands listing the<br/>
		/// specific optimizations performed by the phys_opt_design command. The iphys_opt Tcl<br/>
		/// script can be edited to change the specific optimizations performed. The Tcl script provides a<br/>
		/// history of the physical optimizations performed on the design after placement, marked by date<br/>
		/// and history.<br/>
		/// IMPORTANT! The iphys_opt Tcl script contains the specific optimizations performed by the<br/>
		/// phys_opt_design command, but does not include placement and routing changes or results.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example writes the physical optimizations that have been performed in the current<br/>
		/// design to the specified Tcl script:<br/>
		/// write_iphys_opt_tcl C:/Data/myDesign_physopt.tcl<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1872<br/>
		/// </para>
		/// </summary>
		/// <param name="output">(Required) tcl file containing iPhysOpt script</param>
		/// <param name="place">(Optional) write out placement information</param>
		/// <param name="binary">(Optional) write out in binary format</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_iphys_opt_tcl(String output, bool? place = null, bool? binary = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_iphys_opt_tcl [-place] [-binary] [-quiet] [-verbose] [<output>]
			_tcl.Entry(_builder.write_iphys_opt_tcl(output, place, binary, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
