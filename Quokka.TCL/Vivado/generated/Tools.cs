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
		/// Interactive phys_opt_design.
		///
		///
		/// TCL Syntax: iphys_opt_design [-fanout_opt] [-critical_cell_opt] [-placement_opt] [-rewire] [-net <arg>] -cluster <args> -place_cell <args> [-dsp_register_opt] [-bram_register_opt] [-uram_register_opt] [-shift_register_opt] [-cell <arg>] [-packing] [-unpacking] [-port <arg>] [-critical_pin_opt] [-equ_drivers_opt] [-skipped_optimization] [-insert_negative_edge_ffs] [-hold_fix] [-slr_crossing_opt] [-auto_pipeline] [-quiet] [-verbose]
		///
		/// The iphys_opt_design command describes a specific optimization that was performed by the
		/// phys_opt_design command, such as replicating a critical cell or pulling registers from a block
		/// RAM to improve critical path delay. The iphys_opt_design command includes all the
		/// information necessary to recreate both the post-optimization logical netlist and the placement
		/// changes required for the optimized netlist.
		/// Interactive physical optimization can be used in two ways:
		/// • Applying post-placement physical optimizations to the pre-placement netlist to improve the
		/// overall placement result and improve design performance.
		/// • Saving the physical optimizations in a Tcl script to be repeated as needed.
		/// The various optimizations performed by phys_opt_design can be written to an iphys_opt Tcl
		/// script by write_iphys_opt_tcl, and read into the design by the read_iphys_opt_tcl
		/// command.
		/// TIP: The iphys_opt_design command is intended for use inside the iphys_opt Tcl script file. These
		/// commands can be edited in the context of the iphys_opt Tcl script, but they are not intended to be
		/// specified at the command line.
		/// This command returns a transcript of its processes, or an error if it fails.
		///
		/// The following example performs a critical cell optimization on the specified net and cluster of
		/// ports:
		/// iphys_opt_design -critical_cell_opt -net \
		/// {ADUR_CORE_INST/CPE_INST/CPE_ANT_RESOURCE_TDM_INST0 \
		/// /CPE_ANT_LINE_IQ_TDM_ANT0_INST/CPE_PN_MULT_INST/CPE_PN_MUL_INST3 \
		/// /Q_PNI_MULT_INST/pn_mult_reg[3][0]} \
		/// -cluster {pn_mult[3]_i_14_replica {\
		/// {ADUR_CORE_INST/CPE_INST/CPE_ANT_RESOURCE_TDM_INST0 \
		/// /CPE_ANT_LINE_IQ_TDM_ANT0_INST/CPE_PN_MULT_INST/CPE_PN_MUL_INST2 \
		/// /Q_ADD_INST/pn_mult_reg[3]_i_6_CARRY8/S[0]}}}\
		/// -cluster {pn_mult[3]_i_14_replica_1 {\
		/// {ADUR_CORE_INST/CPE_INST/CPE_ANT_RESOURCE_TDM_INST0 \
		/// /CPE_ANT_LINE_IQ_TDM_ANT0_INST/CPE_PN_MULT_INST/CPE_PN_MUL_INST0 \
		/// /Q_ADD_INST/pn_mult_reg[3]_i_10_CARRY8/S[0]}}}\
		/// The following example performs a shift register optimization on the specified cell:
		/// iphys_opt_design -shift_register_opt -cell \
		/// {ADUR_CORE_INST/EMIF_INTERFACE_INST/EMIF_HOST_IF_INST/DLY_INST1 \
		/// /PD_INST_FPGA/delay_chain_reg[9][16]_srl9} -port D
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1004
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
		/// (Optional)
		/// Suspend message limits during command execution
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// </param>
		public TTCL iphys_opt_design(TCLParameterList cluster, TCLParameterList place_cell, bool? fanout_opt = null, bool? critical_cell_opt = null, bool? placement_opt = null, bool? rewire = null, string net = null, bool? dsp_register_opt = null, bool? bram_register_opt = null, bool? uram_register_opt = null, bool? shift_register_opt = null, string cell = null, bool? packing = null, bool? unpacking = null, string port = null, bool? critical_pin_opt = null, bool? equ_drivers_opt = null, bool? skipped_optimization = null, bool? insert_negative_edge_ffs = null, bool? hold_fix = null, bool? slr_crossing_opt = null, bool? auto_pipeline = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: iphys_opt_design [-fanout_opt] [-critical_cell_opt] [-placement_opt] [-rewire] [-net <arg>] -cluster <args> -place_cell <args> [-dsp_register_opt] [-bram_register_opt] [-uram_register_opt] [-shift_register_opt] [-cell <arg>] [-packing] [-unpacking] [-port <arg>] [-critical_pin_opt] [-equ_drivers_opt] [-skipped_optimization] [-insert_negative_edge_ffs] [-hold_fix] [-slr_crossing_opt] [-auto_pipeline] [-quiet] [-verbose]
			_tcl.Entry(_builder.iphys_opt_design(cluster, place_cell, fanout_opt, critical_cell_opt, placement_opt, rewire, net, dsp_register_opt, bram_register_opt, uram_register_opt, shift_register_opt, cell, packing, unpacking, port, critical_pin_opt, equ_drivers_opt, skipped_optimization, insert_negative_edge_ffs, hold_fix, slr_crossing_opt, auto_pipeline, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Open a netlist design
		///
		///
		/// TCL Syntax: link_design [-name <arg>] [-part <arg>] [-constrset <arg>] [-top <arg>] [-mode <arg>] [-pr_config <arg>] [-reconfig_partitions <args>] [-partitions <args>] [-ignore_timing] [-quiet] [-verbose]
		///
		/// Opens a new or existing netlist design, linking the netlist files and constraints with the target part
		/// to create the design. This command is intended for use with netlist source files, such as files
		/// generated by third party synthesis tools, or Vivado synthesis through the synth_design
		/// command.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The DESIGN_MODE property for the current source fileset must be defined as GateLvl in order
		/// to open a netlist design. If not, you will get the following error:
		/// ERROR: The design mode of 'sources_1' must be GateLvl.
		/// The -top switch is required for third-party synthesis designs. The netlist for the design must be
		/// rooted in a specific module. For project-based designs you can specify the TOP property on the
		/// project. However, in non-project mode, you must use the -top option for the link_design
		/// command.
		/// For project based designs with RTL source files, use launch_runs to launch synthesis or
		/// implementation, and then use the open_run command to open the design.
		/// For non-project based designs, use the open_checkpoint command to open a checkpoint into
		/// memory, opening the design in Non-Project Mode. Refer to the Vivado Design Suite User Guide:
		/// Design Flows Overview (UG892) for more information on Project Mode and Non-Project Mode.
		///
		/// The following creates a new netlist design called Net1:
		/// link_design -name Net1
		/// Note: The default source set, constraint set, and part will be used in this example.
		/// The following example opens a netlist design called Net1, and specifies the constraint set to be
		/// used:
		/// link_design -name Net1 -constrset con1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1024
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
		public TTCL link_design(string name = null, string part = null, string constrset = null, string top = null, string mode = null, string pr_config = null, TCLParameterList reconfig_partitions = null, TCLParameterList partitions = null, bool? ignore_timing = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: link_design [-name <arg>] [-part <arg>] [-constrset <arg>] [-top <arg>] [-mode <arg>] [-pr_config <arg>] [-reconfig_partitions <args>] [-partitions <args>] [-ignore_timing] [-quiet] [-verbose]
			_tcl.Entry(_builder.link_design(name, part, constrset, top, mode, pr_config, reconfig_partitions, partitions, ignore_timing, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// List available features.
		///
		///
		/// TCL Syntax: list_features [-quiet] [-verbose]
		///
		/// In order to reduce the memory footprint of the Vivado Design Suite, there are groups of Tcl
		/// commands called "features" which are unavailable for use until you run a command from that
		/// feature set, or unless you explicitly load the feature using the load_features command.
		/// This command lists the available features sets of the Vivado Design Suite that can be loaded with
		/// the load_features command.
		/// Note: If a feature has been previously loaded, it will not be listed as a feature available to load.
		/// This command returns a list of features, or an error message.
		///
		/// The following example returns the list of features available to load into the Vivado Design Suite:
		/// list_features
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1028
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
		/// Load Tcl commands for a specified feature.
		///
		///
		/// TCL Syntax: load_features [-quiet] [-verbose] [<features>...]
		///
		/// Load the specified features of the Vivado Design Suite into memory.
		/// In order to reduce the memory footprint of the Vivado Design Suite, there are groups of Tcl
		/// commands called "features" which are unavailable for use until you run a command from that
		/// feature set, or unless you explicitly load the feature using the load_features command.
		/// For example, the load_features simulator command loads the commands for the Vivado
		/// simulator, as does directly launching the Vivado simulator using the launch_xsim command.
		/// To access the complete list of Tcl commands associated with a feature of the Vivado Design
		/// Suite, and the help text for these commands, you can load the feature into the application
		/// memory using the load_features command without actually running the feature of the tool.
		/// You can list the features that are available to be loaded using the list_features command.
		/// The list of features is dynamic, and changes from release to release.
		/// The command returns nothing if successful, or an error message if failed.
		///
		/// The following example loads the Vivado simulator feature:
		/// load_features simulator
		/// The following example loads all of the loadable feature sets of the Vivado Design Suite:
		/// load_features [list_features]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1040
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="features">
		/// (Optional)
		/// Feature(s) to load, use list_features for a list of available
		/// features.
		/// </param>
		public TTCL load_features(bool? quiet = null, bool? verbose = null, TCLParameterList features = null)
		{
			// TCL Syntax: load_features [-quiet] [-verbose] [<features>...]
			_tcl.Entry(_builder.load_features(quiet, verbose, features));
			return _tcl;
		}
		/// <summary>
		/// Optimize the current netlist. This will perform the retarget, propconst, sweep and
		/// bram_power_opt optimizations by default.
		///
		///
		/// TCL Syntax: opt_design [-retarget] [-propconst] [-sweep] [-bram_power_opt] [-remap] [-aggressive_remap] [-resynth_area] [-resynth_seq_area] [-directive <arg>] [-muxf_remap] [-hier_fanout_limit <arg>] [-bufg_opt] [-shift_register_opt] [-dsp_register_opt] [-srl_remap_modes <arg>] [-control_set_merge] [-merge_equivalent_drivers] [-carry_remap] [-debug_log] [-property_opt_only] [-quiet] [-verbose]
		///
		/// Optimizes a design netlist for the target part. Optimization can provide improvements to
		/// synthesized netlists from third-party tools, or for netlists that may not have been optimized
		/// during synthesis.
		/// Run this command after synthesis but prior to implementation to optimize the design and
		/// simplify the netlist before placing and routing the design. Assign the DONT_TOUCH property to
		/// prevent the optimization of individual cells.
		/// TIP: To see what actions opt_design is taking in optimizing your design, you can use the -verbose
		/// option to get a more detailed transcript of the process. This can help you in understanding and debugging
		/// some of the changes made to your design.
		/// The opt_design command performs the following optimizations by default:
		/// • Retarget
		/// • Constant Propagation
		/// • Sweep
		/// • Global Buffer (BUFG) optimizations
		/// • DSP Register optimizations
		/// • Shift-Register Logic optimizations
		/// • Block RAM Power optimizations
		/// • Implement MIG cores
		/// • Implement Debug cores
		/// IMPORTANT! Using command-line options for specific optimizations results in opt_design performing
		/// only the specified optimizations and disabling all others, even the ones that are usually performed by
		/// default.
		/// To perform LUT Remapping, you must specify -remap.
		/// To perform area-based re-synthesis, you must specify -resynth_area, or -directive
		/// ExploreArea.
		/// To perform sequential area-based re-synthesis, you must specify -resynth_seq_area, or -
		/// directive ExploreSequentialArea.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example performs all four default optimizations: retarget, constant propagation,
		/// sweep, and BRAM power optimization. The command returns detailed results with the -
		/// verbose switch:
		/// opt_design -verbose
		/// This example excludes specific BRAM cells from power optimization using the set_power_opt
		/// command, and then runs opt_design with the four default optimizations:
		/// set_power_opt -exclude_cells [get_cells \
		/// -filter {PRIMITIVE_TYPE =~ BMEM.*.*} \
		/// -of_objects [get_pins -leaf -filter {DIRECTION == IN} \
		/// -of_objects [get_nets -of_objects [get_pins clock/bufgctrl_clk_mld/
		/// O]]]]
		/// opt_design
		/// The following example performs the sweep and retarget optimizations:
		/// opt_design -sweep -retarget
		/// Note: Because -sweep and -retarget are expressly enabled in the prior example, -propconst
		/// optimization and -bram_power_opt are implicitly disabled.
		/// The following example directs the opt_design command to use various algorithms to achieve
		/// potentially better results:
		/// opt_design -directive Explore
		/// The following example directs the opt_design command to use various algorithms to achieve
		/// potentially better results, while focusing on area reduction:
		/// opt_design -directive ExploreArea
		/// This example uses the -srl_remap_modes argument with the automatic option to convert FF
		/// chains into SRLs when FF utilization is greater than 20%, or SRLs into FF chains when SRL
		/// utilization is over 50%:
		/// -srl_remap_modes {{target_ff_util 20 target_lutram_util 50}}
		/// TIP: In this case, the srl_remap is only performed if either specified utilization rate is exceeded, but NOT if
		/// both are exceeded.
		/// The following example uses the -srl_remap_modes argument with the manual option to
		/// convert FF chains with length greater than 5 to SRLs, and SRLs with depth less than or equal to 8
		/// to FF chains:
		/// -srl_remap_modes {{min_depth_ffs_to_srl 5}{max_depth_srl_to_ffs 8}}
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1105
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
		/// (Optional)
		/// Mode of behavior (directive) for this command. Please refer
		/// to Arguments section of this help for values for this option
		/// Default: Default
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
		/// (Optional)
		/// Suspend message limits during command execution
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// </param>
		public TTCL opt_design(bool? retarget = null, bool? propconst = null, bool? sweep = null, bool? bram_power_opt = null, bool? remap = null, bool? aggressive_remap = null, bool? resynth_area = null, bool? resynth_seq_area = null, string directive = null, bool? muxf_remap = null, string hier_fanout_limit = null, bool? bufg_opt = null, bool? shift_register_opt = null, bool? dsp_register_opt = null, string srl_remap_modes = null, bool? control_set_merge = null, bool? merge_equivalent_drivers = null, bool? carry_remap = null, bool? debug_log = null, bool? property_opt_only = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: opt_design [-retarget] [-propconst] [-sweep] [-bram_power_opt] [-remap] [-aggressive_remap] [-resynth_area] [-resynth_seq_area] [-directive <arg>] [-muxf_remap] [-hier_fanout_limit <arg>] [-bufg_opt] [-shift_register_opt] [-dsp_register_opt] [-srl_remap_modes <arg>] [-control_set_merge] [-merge_equivalent_drivers] [-carry_remap] [-debug_log] [-property_opt_only] [-quiet] [-verbose]
			_tcl.Entry(_builder.opt_design(retarget, propconst, sweep, bram_power_opt, remap, aggressive_remap, resynth_area, resynth_seq_area, directive, muxf_remap, hier_fanout_limit, bufg_opt, shift_register_opt, dsp_register_opt, srl_remap_modes, control_set_merge, merge_equivalent_drivers, carry_remap, debug_log, property_opt_only, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Optimize the current placed netlist.
		///
		///
		/// TCL Syntax: phys_opt_design [-fanout_opt] [-placement_opt] [-routing_opt] [-slr_crossing_opt] [-rewire] [-insert_negative_edge_ffs] [-critical_cell_opt] [-dsp_register_opt] [-bram_register_opt] [-uram_register_opt] [-bram_enable_opt] [-shift_register_opt] [-hold_fix] [-aggressive_hold_fix] [-retime] [-force_replication_on_nets <args>] [-directive <arg>] [-critical_pin_opt] [-clock_opt] [-path_groups <args>] [-tns_cleanup] [-sll_reg_hold_fix] [-quiet] [-verbose]
		///
		/// Performs timing-driven optimization on the negative-slack paths of a design. A path should have
		/// negative slack near the worst negative slack (WNS) to be considered for optimization.
		/// Optimization will not be performed on designs without negative slack.
		/// This optional command can be run for post-place or post-route optimizations.
		/// RECOMMENDED: Because physical optimization requires timing data that is only available after
		/// placement, the command cannot be run prior to placement. However, the write_iphys_opt_tcl and
		/// read_iphys_opt_tcl commands let you write out the physical optimizations performed on the post￾placed design, and then apply those optimizations to the design netlist prior to placement. Refer to the
		/// Vivado Design Suite User Guide: Implementation (UG904) for more information on interactive physical
		/// optimization.
		/// Post-place phys_opt_design performs the following optimizations by default:
		/// • high-fanout optimization
		/// • placement-based optimization of critical paths
		/// • rewire
		/// • critical-cell optimization
		/// • DSP register optimization
		/// • BRAM register optimization
		/// • URAM register optimization
		/// • a final fanout optimization
		/// TIP: Using command-line options for specific optimizations results in phys_opt_design performing
		/// only the specified optimizations and disabling all others, even the ones that are usually performed by
		/// default.
		/// Post-route phys_opt_design performs the following optimizations by default:
		/// • placement-based optimization of critical paths
		/// • routing optimization
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// • rewire
		/// • critical-cell optimization
		/// Physical optimizations involve replication, re-timing, hold fixing, and placement improvement.
		/// The phys_opt_design command automatically performs all necessary netlist and placement
		/// changes.
		/// To perform re-timing you must specify the -retime option, or the -directive AddRetime
		/// option.
		/// To perform hold fixing you must specify the -hold_fix option, or the -directive
		/// ExploreWithHoldFix option.
		/// If the phys_opt_design command is used iteratively, the subsequent run optimizes the results
		/// of the prior run.
		/// TIP: The phys_opt_design can be multi-threaded to speed the process. Refer to the set_param
		/// command for more information on setting the general.maxThreads parameter.
		/// The command reports each net processed, a summary of any optimizations performed, and the
		/// WNS before and after optimization. Replicated objects are named by appending _replica to
		/// the original object name, followed by the replicated object count.
		///
		/// The following example performs a physical optimization of the current post-placement design,
		/// and then writes the iphys_opt Tcl script for use before placement:
		/// phys_opt_design
		/// write_iphys_opt_tcl C:/Data/my_iphys_opt.tcl
		/// This example sets the LOCK_PINS property on the specified cell, then performs physical
		/// optimizations including register re-timing, optimization of registers across DSP blocks and block
		/// RAMs, and pin swapping (excluding the locked pins) to improve timing:
		/// set_property LOCK_PINS {I3:A1 I2:A4} [get_cell cpuEngine/
		/// qmem_dack_reg_i_1]
		/// phys_opt_design -retime -dsp_register_opt -bram_register_opt \
		/// -critical_pin_opt
		/// This example directs phys_opt_design to run more iterations, with hold violation fixing, to
		/// achieve potentially better results:
		/// phys_opt_design -directive ExploreWithHoldFix
		/// This example directs phys_opt_design to consider more nets for replication:
		/// phys_opt_design -directive AggressiveFanoutOpt
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1114
		/// </summary>
		/// <param name="fanout_opt">
		/// (Optional)
		/// Do cell-duplication based optimization on high-fanout
		/// timing critical nets
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
		/// (Optional)
		/// Mode of behavior (directive) for this command. Please refer
		/// to Arguments section of this help for values for this option
		/// Default: Default
		/// </param>
		/// <param name="critical_pin_opt">(Optional) Do pin-swapping based optimization on timing critical nets</param>
		/// <param name="clock_opt">(Optional) Do clock skew optimization in post-route optimization</param>
		/// <param name="path_groups">(Optional) Work only on specified path groups</param>
		/// <param name="tns_cleanup">
		/// (Optional)
		/// Work on all nets in the design that meet criteria for the
		/// specified optimizations to improve design tns
		/// </param>
		/// <param name="sll_reg_hold_fix">
		/// (Optional)
		/// Do hold fixing on SLL Tx-Rx paths
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Name Description
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL phys_opt_design(bool? fanout_opt = null, bool? placement_opt = null, bool? routing_opt = null, bool? slr_crossing_opt = null, bool? rewire = null, bool? insert_negative_edge_ffs = null, bool? critical_cell_opt = null, bool? dsp_register_opt = null, bool? bram_register_opt = null, bool? uram_register_opt = null, bool? bram_enable_opt = null, bool? shift_register_opt = null, bool? hold_fix = null, bool? aggressive_hold_fix = null, bool? retime = null, TCLParameterList force_replication_on_nets = null, string directive = null, bool? critical_pin_opt = null, bool? clock_opt = null, TCLParameterList path_groups = null, bool? tns_cleanup = null, bool? sll_reg_hold_fix = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: phys_opt_design [-fanout_opt] [-placement_opt] [-routing_opt] [-slr_crossing_opt] [-rewire] [-insert_negative_edge_ffs] [-critical_cell_opt] [-dsp_register_opt] [-bram_register_opt] [-uram_register_opt] [-bram_enable_opt] [-shift_register_opt] [-hold_fix] [-aggressive_hold_fix] [-retime] [-force_replication_on_nets <args>] [-directive <arg>] [-critical_pin_opt] [-clock_opt] [-path_groups <args>] [-tns_cleanup] [-sll_reg_hold_fix] [-quiet] [-verbose]
			_tcl.Entry(_builder.phys_opt_design(fanout_opt, placement_opt, routing_opt, slr_crossing_opt, rewire, insert_negative_edge_ffs, critical_cell_opt, dsp_register_opt, bram_register_opt, uram_register_opt, bram_enable_opt, shift_register_opt, hold_fix, aggressive_hold_fix, retime, force_replication_on_nets, directive, critical_pin_opt, clock_opt, path_groups, tns_cleanup, sll_reg_hold_fix, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Automatically place ports and leaf-level instances
		///
		///
		/// TCL Syntax: place_design [-directive <arg>] [-no_timing_driven] [-timing_summary] [-unplace] [-post_place_opt] [-no_psip] [-no_bufg_opt] [-quiet] [-verbose]
		///
		/// Place the specified ports and logic cells in the current design, or all ports and logic cells, onto
		/// device resources on the target part. The tool optimizes placement to minimize negative timing
		/// slack and reduce overall wire length, while also attempting to spread out placement to reduce
		/// routing congestion.
		/// Placement is one step of the complete design implementation process, which can be run
		/// automatically through the use of the launch_runs command when running the Vivado tools in
		/// Project Mode.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// In Non-Project Mode, the implementation process must be run manually with the individual
		/// commands: opt_design, place_design, phys_opt_design, power_opt_design, and
		/// route_design. Refer to the Vivado Design Suite User Guide: Design Flows Overview (UG892) for
		/// a complete description of Project Mode and Non-Project Mode.
		/// Both placement and routing can be completed incrementally, based on prior results stored in a
		/// Design Checkpoint file (DCP), using the incremental implementation flow. Refer to the
		/// read_checkpoint command, or to Vivado Design Suite User Guide: Implementation (UG904) for
		/// more information on incremental place and route.
		/// TIP: The place_design can be multi-threaded to speed the process. Refer to the set_param
		/// command for more information on setting the general.maxThreads parameter.
		/// You can also manually place some elements of the design using place_ports, or by setting
		/// LOC properties on the cell, and then automatically place the remainder of the design using
		/// place_design.
		/// This command requires an open synthesized design, and it is recommended that you run the
		/// opt_design command prior to running place_design to avoid placing a suboptimal netlist.
		///
		/// The following example places the current design, runs optimization, routes the design, runs post
		/// placement optimization, and then reroutes the design to cleanup any unconnected nets as a
		/// result of post placement optimization:
		/// place_design
		/// phys_opt_design
		/// route_design
		/// place_design -post_place_opt
		/// phys_opt_design
		/// route_design
		/// The following example directs the Vivado placer to try different placement algorithms to achieve
		/// a better placement result:
		/// place_design -directive Explore
		/// This example unplaces the current design:
		/// place_design -unplace
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1124
		/// </summary>
		/// <param name="directive">
		/// (Optional)
		/// Mode of behavior (directive) for this command. Please refer
		/// to Arguments section of this help for values for this option.
		/// Default: Default
		/// </param>
		/// <param name="no_timing_driven">(Optional) Do not run in timing driven mode</param>
		/// <param name="timing_summary">(Optional) Enable accurate post-placement timing summary.</param>
		/// <param name="unplace">(Optional) Unplace all the instances which are not locked by Constraints.</param>
		/// <param name="post_place_opt">(Optional) Run only the post commit optimizer</param>
		/// <param name="no_psip">
		/// (Optional)
		/// Disable PSIP (Physical Synthesis In Placer) optimization
		/// during placement.
		/// </param>
		/// <param name="no_bufg_opt">(Optional) Disable global buffer insertion during placement</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL place_design(string directive = null, bool? no_timing_driven = null, bool? timing_summary = null, bool? unplace = null, bool? post_place_opt = null, bool? no_psip = null, bool? no_bufg_opt = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: place_design [-directive <arg>] [-no_timing_driven] [-timing_summary] [-unplace] [-post_place_opt] [-no_psip] [-no_bufg_opt] [-quiet] [-verbose]
			_tcl.Entry(_builder.place_design(directive, no_timing_driven, timing_summary, unplace, post_place_opt, no_psip, no_bufg_opt, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// load iPhysOpt script and run it.
		///
		///
		/// TCL Syntax: read_iphys_opt_tcl [-fanout_opt] [-critical_cell_opt] [-placement_opt] [-rewire] [-dsp_register_opt] [-bram_register_opt] [-uram_register_opt] [-shift_register_opt] [-auto_pipeline] [-critical_pin_opt] [-equ_drivers_opt] [-include_skipped_optimizations] [-insert_negative_edge_ffs] [-hold_fix] [-slr_crossing_opt] [-quiet] [-verbose] [<input>]
		///
		/// Interactive physical optimization can be used in two ways:
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// • Applying post-placement physical optimizations to the pre-placement netlist to improve the
		/// overall placement result and improve design performance.
		/// • Saving the physical optimizations in a Tcl script to be repeated as needed.
		/// To apply post-placement optimizations to the pre-placement netlist, you can reset the
		/// implementation run and open the synthesized design, or open the opt_design checkpoint, and
		/// read the iphys_opt Tcl script to apply the physical optimizations.
		/// You can apply all optimizations from the iphys_opt Tcl script, or apply specific optimizations using
		/// the options of the read_iphys_opt_tcl command. You can also include any optimizations
		/// that were defined but skipped during physical optimization.
		/// If the iphys_opt Tcl script includes placement data, you can use that data to place the optimized
		/// cells in the design.
		/// After reading the iphys_opt Tcl script, and placing the optimized cells, you can rerun placement
		/// for the overall design. The design now incorporates the benefits of the phys_opt_design
		/// optimizations before placement, such as fewer high-fanout nets due to replication, and fewer
		/// long distance paths from block RAM outputs. The results should be a better placement, and
		/// improved design performance, due to the early application of netlist optimizations.
		/// This command returns a transcript of its processes, or returns an error if it fails.
		///
		/// The following example applies the BRAM optimizations that are defined in the specified
		/// interactive physical optimization Tcl script, and applies any placement data for the optimized
		/// cells:
		/// open_checkpoint C:/Data/opt_design.dcp
		/// read_iphys_opt_tcl -shift_register_opt -placement_opt C:/Data/
		/// my_iphys_opt.tcl
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1169
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
		public TTCL read_iphys_opt_tcl(string input, bool? fanout_opt = null, bool? critical_cell_opt = null, bool? placement_opt = null, bool? rewire = null, bool? dsp_register_opt = null, bool? bram_register_opt = null, bool? uram_register_opt = null, bool? shift_register_opt = null, bool? auto_pipeline = null, bool? critical_pin_opt = null, bool? equ_drivers_opt = null, bool? include_skipped_optimizations = null, bool? insert_negative_edge_ffs = null, bool? hold_fix = null, bool? slr_crossing_opt = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_iphys_opt_tcl [-fanout_opt] [-critical_cell_opt] [-placement_opt] [-rewire] [-dsp_register_opt] [-bram_register_opt] [-uram_register_opt] [-shift_register_opt] [-auto_pipeline] [-critical_pin_opt] [-equ_drivers_opt] [-include_skipped_optimizations] [-insert_negative_edge_ffs] [-hold_fix] [-slr_crossing_opt] [-quiet] [-verbose] [<input>]
			_tcl.Entry(_builder.read_iphys_opt_tcl(input, fanout_opt, critical_cell_opt, placement_opt, rewire, dsp_register_opt, bram_register_opt, uram_register_opt, shift_register_opt, auto_pipeline, critical_pin_opt, equ_drivers_opt, include_skipped_optimizations, insert_negative_edge_ffs, hold_fix, slr_crossing_opt, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Register a Tcl proc with Vivado.
		///
		///
		/// TCL Syntax: register_proc [-quiet] [-verbose] <proc> [<tasknm>]
		///
		/// Register a Tcl procedure (proc) with the Vivado Tcl command interpretor to register the command
		/// with the Vivado Design Suite help system.
		/// The following is an example Tcl proc defined for use with the Vivado Design Suite:
		/// proc findCommand {option} {
		/// # Summary:
		/// # Searches through all Vivado Tcl commands for commands implementing
		/// # the specified argument.
		/// # Argument Usage:
		/// # option: Specifies the argument to search for.
		/// # Return Value:
		/// # Returns a list of Tcl commands that implement the option.
		/// # Categories: personal
		/// foreach cmd [lsort [info commands *]]
		/// {
		/// catch {
		/// if {[regexp "$option" [help -syntax $cmd]]}
		/// {
		/// puts $cmd
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// }
		/// }
		/// }
		/// } ;
		/// # End
		/// The commented lines beginning with '#' are used to define the help text for the registered
		/// command in the Vivado Design Suite help system.
		/// • # Summary: provides a brief description of the command.
		/// • # Argument Usage: provides a list and description of the various arguments for the proc.
		/// • # Return Value: provides a description of what is returned by the proc.
		/// • # Categories: provides an ability to define categories for registered procedures.
		/// After registering the procedure as a Tcl command, the Vivado help system will return this text
		/// when queried with:
		/// tasknm -help
		/// -or￾help tasknm
		/// This command returns the name of the registered proc.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1226
		/// </summary>
		/// <param name="proc">(Required) Name of proc to register. Proc must be known to Tcl</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="tasknm">
		/// (Optional)
		/// Name of Tcl task that wraps the proc. Default: Register the
		/// proc using the root name proc (no namespaces).
		/// </param>
		/// <returns>Nothing</returns>
		public TTCL register_proc(string proc, bool? quiet = null, bool? verbose = null, string tasknm = null)
		{
			// TCL Syntax: register_proc [-quiet] [-verbose] <proc> [<tasknm>]
			_tcl.Entry(_builder.register_proc(proc, quiet, verbose, tasknm));
			return _tcl;
		}
		/// <summary>
		/// Perform pipeline register insertion analysis and display report.
		///
		///
		/// TCL Syntax: report_pipeline_analysis [-cells <args>] [-verbose] [-clocks <args>] [-file <arg>] [-include_paths_to_pipeline] [-append] [-max_added_latency <arg>] [-report_loops] [-return_string] [-quiet]
		///
		/// This command performs an analysis of a synthesized design, hypothetically inserting pipeline
		/// stages in the design and reports the potential frequency (Fmax) increase of each clock domain.
		/// The analysis includes a search for loops in the design, which may not be improved by pipelining,
		/// and determines if such loops are critical paths in the design.
		/// Returns a table showing the pipeline stages and the Fmax improvement. The report begins with
		/// the original design and adds stages of latency (1, 2, ... ) until there is no further improvement in
		/// Fmax. This reports a theoretical upper limit to the frequency performance of the design.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The analysis is typically run on the un-placed synthesized netlist where the logical netlist
		/// structure determines the performance. The report can be run on the top-level design, or on out￾of-context (OOC) sub-modules. This report confirms whether the design frequency can be
		/// increased, as well as how many pipeline registers must be added to the design to achieve the
		/// Fmax improvement.
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be
		/// written to a file.
		///
		/// The following example returns the name, period, waveform, and sources of the clocks in the
		/// current design:
		/// report_pipeline_analysis -file C:/Data/FPGA_Design/pipeline_report.txt
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1403
		/// </summary>
		/// <param name="cells">
		/// (Optional)
		/// Analyze each of the specified hierarchical cells separately
		/// and ignore feedback loops external to the cells.
		/// </param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="clocks">(Optional) Filter report output to show only the specified clocks</param>
		/// <param name="file">
		/// (Optional)
		/// Filename to output results to. (send output to console if -file
		/// is not used)
		/// </param>
		/// <param name="include_paths_to_pipeline">(Optional) Report paths to cut. (only available if -file is used)</param>
		/// <param name="append">(Optional) Append to existing file</param>
		/// <param name="max_added_latency">
		/// (Optional)
		/// Maximum extra latency that can be inserted into the system
		/// (0 = unlimited). Default: 100
		/// </param>
		/// <param name="report_loops">(Optional) Report loop information as well</param>
		/// <param name="return_string">(Optional) return report as string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		public TTCL report_pipeline_analysis(TCLParameterList cells = null, bool? verbose = null, TCLParameterList clocks = null, string file = null, bool? include_paths_to_pipeline = null, bool? append = null, string max_added_latency = null, bool? report_loops = null, bool? return_string = null, bool? quiet = null)
		{
			// TCL Syntax: report_pipeline_analysis [-cells <args>] [-verbose] [-clocks <args>] [-file <arg>] [-include_paths_to_pipeline] [-append] [-max_added_latency <arg>] [-report_loops] [-return_string] [-quiet]
			_tcl.Entry(_builder.report_pipeline_analysis(cells, verbose, clocks, file, include_paths_to_pipeline, append, max_added_latency, report_loops, return_string, quiet));
			return _tcl;
		}
		/// <summary>
		/// Route the current design
		///
		///
		/// TCL Syntax: route_design [-unroute] [-release_memory] [-nets <args>] [-physical_nets] [-pins <arg>] [-directive <arg>] [-tns_cleanup] [-no_timing_driven] [-preserve] [-delay] [-auto_delay] -max_delay <arg> -min_delay <arg> [-timing_summary] [-finalize] [-ultrathreads] [-eco] [-quiet] [-verbose]
		///
		/// Route the nets in the current design to complete logic connections on the target part.
		/// Predefined routing strategies can be quickly selected using the route_design -directive
		/// command, or specific route options can be configured to define your own routing strategy.
		/// Routing can be completed automatically with route_design, or can be completed iteratively
		/// using the various options of the route_design command to achieve route completion and
		/// timing closure. Iterative routing provides you some control over the routing process to route
		/// critical nets first and then route less critical nets, and to control the level of effort and the timing
		/// algorithms for these various route passes.
		/// Routing is one step of the complete design implementation process, which can be run
		/// automatically through the use of the launch_runs command when running the Vivado tools in
		/// Project Mode.
		/// In Non-Project Mode, the implementation process must be run manually with the individual
		/// commands: opt_design, place_design, phys_opt_design, power_opt_design, and
		/// route_design. Refer to the Vivado Design Suite User Guide: Design Flows Overview (UG892) for a
		/// complete description of Project Mode and Non-Project Mode.
		/// TIP: The route_design can be multi-threaded to speed the process. Refer to the set_param
		/// command for more information on setting the general.maxThreads parameter.
		/// Both placement and routing can be completed incrementally, based on prior results stored in a
		/// Design Checkpoint file (DCP), using the incremental implementation flow. Refer to the
		/// read_checkpoint command, or to Vivado Design Suite User Guide: Implementation (UG904) for
		/// more information on incremental place and route.
		/// This command requires a placed design, and it is recommended that you have optimized the
		/// design with opt_design prior to placement.
		///
		/// Route the entire design, and direct the router to try multiple algorithms for improving critical
		/// path delay:
		/// route_design -directive Explore
		/// The following example routes the set of timing critical nets, $criticalNets, to the shortest
		/// interconnect delay, marks the nets as fixed using the IS_ROUTE_FIXED property, and then routes
		/// the rest of the design using a low effort directive for fast results:
		/// route_design -delay -nets $criticalNets
		/// set_property IS_ROUTE_FIXED 1 $criticalNets
		/// route_design -directive RuntimeOptimized
		/// Route the specified nets using the fastest runtime:
		/// route_design -nets [get_nets ctrl0/ctr*]
		/// Route the specified nets to get the shortest interconnect delays:
		/// route_design -nets [get_nets ctrl0/ctr*] -delay
		/// Route to the specified pins:
		/// route_design -pins [get_pins ctrl0/reset_reg/D ctrl0/ram0/ADDRARDADDR]
		/// Route to a particular pin, try to achieve less than 500 ps delay:
		/// route_design -pins [get_pins ctrl0/reset_reg/D] -max_delay 500
		/// Route to a particular pin, try to achieve more than 200 ps delay:
		/// route_design -pins [get_pins ctrl0/ram0/ADDRARDADDR] -min_delay 200
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1539
		/// </summary>
		/// <param name="max_delay">
		/// (Required)
		/// Use with -pins option to specify the max_delay constraint on
		/// the pins.When specified -delay is implicit.
		/// </param>
		/// <param name="min_delay">
		/// (Required)
		/// Use with -pins option to specify the max_delay constraint on
		/// the pins.When specified -delay is implicit.
		/// </param>
		/// <param name="unroute">
		/// (Optional)
		/// Unroute whole design or the given nets/pins if used with -
		/// nets or -pins.
		/// </param>
		/// <param name="release_memory">(Optional) Release Router memory. Not compatible with any other options.</param>
		/// <param name="nets">(Optional) Operate on the given nets.</param>
		/// <param name="physical_nets">(Optional) Operate on all physical nets.</param>
		/// <param name="pins">(Optional) Operate on the given pins.</param>
		/// <param name="directive">
		/// (Optional)
		/// Mode of behavior (directive) for this command. Please refer
		/// to Arguments section of this help for values for this option.
		/// Default: Default
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
		/// (Optional)
		/// runs incremental router if there was eco modification on
		/// routed netlist.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL route_design(string max_delay, string min_delay, bool? unroute = null, bool? release_memory = null, TCLParameterList nets = null, bool? physical_nets = null, string pins = null, string directive = null, bool? tns_cleanup = null, bool? no_timing_driven = null, bool? preserve = null, bool? delay = null, bool? auto_delay = null, bool? timing_summary = null, bool? finalize = null, bool? ultrathreads = null, bool? eco = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: route_design [-unroute] [-release_memory] [-nets <args>] [-physical_nets] [-pins <arg>] [-directive <arg>] [-tns_cleanup] [-no_timing_driven] [-preserve] [-delay] [-auto_delay] -max_delay <arg> -min_delay <arg> [-timing_summary] [-finalize] [-ultrathreads] [-eco] [-quiet] [-verbose]
			_tcl.Entry(_builder.route_design(max_delay, min_delay, unroute, release_memory, nets, physical_nets, pins, directive, tns_cleanup, no_timing_driven, preserve, delay, auto_delay, timing_summary, finalize, ultrathreads, eco, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Synthesize a design using Vivado Synthesis and open that design
		///
		///
		/// TCL Syntax: synth_design [-name <arg>] [-part <arg>] [-constrset <arg>] [-top <arg>] [-include_dirs <args>] [-generic <args>] [-verilog_define <args>] [-flatten_hierarchy <arg>] [-gated_clock_conversion <arg>] [-directive <arg>] [-rtl] [-bufg <arg>] [-no_lc] [-shreg_min_size <arg>] [-mode <arg>] [-fsm_extraction <arg>] [-rtl_skip_mlo] [-rtl_skip_ip] [-rtl_skip_constraints] [-srl_style <arg>] [-keep_equivalent_registers] [-resource_sharing <arg>] [-cascade_dsp <arg>] [-control_set_opt_threshold <arg>] [-incremental <arg>] [-max_bram <arg>] [-max_uram <arg>] [-max_dsp <arg>] [-max_bram_cascade_height <arg>] [-max_uram_cascade_height <arg>] [-retiming] [-no_srlextract] [-assert] [-no_timing_driven] [-sfcu] [-debug_log] [-quiet] [-verbose]
		///
		/// Directly launches the Vivado synthesis engine to compile and synthesize a design in either
		/// Project Mode or Non-Project Mode in the Vivado Design Suite. Refer to the Vivado Design Suite
		/// User Guide: Design Flows Overview (UG892) for a complete description of Project Mode and Non￾Project Mode.
		/// Vivado synthesis can be launched directly with the synth_design command in the Non￾Project Mode of the Vivado Design Suite.
		/// TIP: The synth_design can be multi-threaded to speed the process. Refer to the set_param
		/// command for more information on setting the general.maxThreads parameter.
		/// In Project Mode, synthesis should be launched from an existing synthesis run created with the
		/// create_run command. The run is launched using the launch_runs command, and this in turn
		/// calls synth_design for Vivado synthesis.
		/// You can also use the synth_design command to elaborate RTL source files, and open an
		/// elaborated design:
		/// synth_design -rtl -name rtl_1
		/// This command returns a transcript of the synthesis process, or returns an error if it fails.
		///
		/// The following example uses the set_property command to define the target part for the
		/// active project, then elaborates the source files and opens an RTL design:
		/// set_property part xc7vx485tffg1158-1 [current_project]
		/// synth_design -rtl -name rtl_1
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Note: The default source set, constraint set, and part will be used in this example.
		/// The following example uses the find_top command to define the top of the current design for
		/// synthesis:
		/// synth_design -top [lindex [find_top] 0]
		/// Note: Since find_top returns multiple possible candidates, choosing index 0 chooses the best top
		/// candidate for synthesis.
		/// The following example runs synthesis on the current design, defining the top module and the
		/// target part, and specifying no flattening of the hierarchy. The results of the synthesis run are then
		/// opened in a netlist design:
		/// synth_design -top top -part xc7k70tfbg676-2 -flatten_hierarchy none
		/// open_run synth_1 -name netlist_1
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1733
		/// </summary>
		/// <param name="name">(Optional) Design name</param>
		/// <param name="part">(Optional) Target part</param>
		/// <param name="constrset">(Optional) Constraint fileset to use</param>
		/// <param name="top">(Optional) Specify the top module name</param>
		/// <param name="include_dirs">(Optional) Specify verilog search directories</param>
		/// <param name="generic">
		/// (Optional)
		/// Specify generic parameters. Syntax: -generic
		/// <name>=<value> -generic <name>=<value> ...
		/// </param>
		/// <param name="verilog_define">
		/// (Optional)
		/// Specify verilog defines. Syntax: -verilog_define
		/// <macro_name>[=<macro_text>] -verilog_define
		/// <macro_name>[=<macro_text>] ...
		/// </param>
		/// <param name="flatten_hierarchy">
		/// (Optional)
		/// Flatten hierarchy during LUT mapping. Values: full, none,
		/// rebuilt Default: rebuilt
		/// </param>
		/// <param name="gated_clock_conversion">
		/// (Optional)
		/// Convert clock gating logic to flop enable. Values: off, on,
		/// auto Default: off
		/// </param>
		/// <param name="directive">
		/// (Optional)
		/// Synthesis directive. Values: default, RuntimeOptimized,
		/// AreaOptimized_high,
		/// AreaOptimized_medium,AlternateRoutability,
		/// AreaMapLargeShiftRegToBRAM, AreaMultThresholdDSP,
		/// FewerCarryChains,Perfor manceOptimized,
		/// LogicCompaction Default: default
		/// </param>
		/// <param name="rtl">(Optional) Elaborate and open an rtl design</param>
		/// <param name="bufg">
		/// (Optional)
		/// Max number of global clock buffers used by synthesis
		/// Default: 12
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Name Description
		/// </param>
		/// <param name="no_lc">
		/// (Optional)
		/// Disable LUT combining. Do not allow combining LUT pairs
		/// into single dual output LUTs.
		/// </param>
		/// <param name="shreg_min_size">(Optional) Minimum length for chain of registers to be mapped onto SRL Default: 3</param>
		/// <param name="mode">(Optional) The design mode. Values: default, out_of_context Default: default</param>
		/// <param name="fsm_extraction">
		/// (Optional)
		/// FSM Extraction Encoding. Values: off, one_hot, sequential,
		/// johnson, gray, user_encoding, auto Default: auto
		/// </param>
		/// <param name="rtl_skip_mlo">
		/// (Optional)
		/// Skip mandatory logic optimization for RTL elaboration of the
		/// design; requires -rtl option.
		/// </param>
		/// <param name="rtl_skip_ip">
		/// (Optional)
		/// Exclude subdesign checkpoints in the RTL elaboration of the
		/// design; requires -rtl option.
		/// </param>
		/// <param name="rtl_skip_constraints">
		/// (Optional)
		/// Do not load and validate constraints against elaborated
		/// design; requires -rtl option.
		/// </param>
		/// <param name="srl_style">
		/// (Optional)
		/// Static SRL Implementation Style. Values: register, srl, srl_reg,
		/// reg_srl, reg_srl_reg
		/// </param>
		/// <param name="keep_equivalent_registers">
		/// (Optional)
		/// Prevents registers sourced by the same logic from being
		/// merged. (Note that the merging can otherwise be
		/// prevented using the synthesis KEEP attribute)
		/// </param>
		/// <param name="resource_sharing">(Optional) Sharing arithmetic operators. Value: auto, on, off Default: auto</param>
		/// <param name="cascade_dsp">
		/// (Optional)
		/// Controls how adders summing DSP block outputs will be
		/// implemented. Value: auto, tree, force Default: auto
		/// </param>
		/// <param name="control_set_opt_threshold">
		/// (Optional)
		/// Threshold for synchronous control set optimization to lower
		/// number of control sets. Valid values are 'auto' and non￾negative integers. The higher the number, the more control
		/// set optimization will be performed and fewer control sets
		/// will result. To disable control set optimization completely,
		/// set to 0. Default: auto
		/// </param>
		/// <param name="incremental">(Optional) dcp file for incremental flowvalue of this is the file name</param>
		/// <param name="max_bram">
		/// (Optional)
		/// Maximum number of block RAM allowed in design. (Note -1
		/// means that the tool will choose the max number allowed for
		/// the part in question) Default: -1
		/// </param>
		/// <param name="max_uram">
		/// (Optional)
		/// Maximum number of Ultra RAM blocks allowed in design.
		/// (Note -1 means that the tool will choose the max number
		/// allowed for the part in question) Default: -1
		/// </param>
		/// <param name="max_dsp">
		/// (Optional)
		/// Maximum number of block DSP allowed in design. (Note -1
		/// means that the tool will choose the max number allowed for
		/// the part in question) Default: -1
		/// </param>
		/// <param name="max_bram_cascade_height">
		/// (Optional)
		/// Controls the maximum number of BRAM that can be
		/// cascaded by the tool. (Note -1 means that the tool will
		/// choose the max number allowed for the part in question)
		/// Default: -1
		/// </param>
		/// <param name="max_uram_cascade_height">
		/// (Optional)
		/// Controls the maximum number of URAM that can be
		/// cascaded by the tool. (Note -1 means that the tool will
		/// choose the max number allowed for the part in question)
		/// Default: -1
		/// </param>
		/// <param name="retiming">
		/// (Optional)
		/// Seeks to improve circuit performance for intra-clock
		/// sequential paths by automatically moving registers (register
		/// balancing) across combinatorial gates or LUTs. It maintains
		/// the original behavior and latency of the circuit and does not
		/// require changes to the RTL sources.
		/// </param>
		/// <param name="no_srlextract">
		/// (Optional)
		/// Prevents the extraction of shift registers so that they get
		/// implemented as simple registers
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Name Description
		/// </param>
		/// <param name="assert">
		/// (Optional)
		/// Enable VHDL assert statements to be evaluated. A severity
		/// level of failure will stop the synthesis flow and produce an
		/// error.
		/// </param>
		/// <param name="no_timing_driven">(Optional) Do not run in timing driven mode</param>
		/// <param name="sfcu">(Optional) Run in single-file compilation unit mode</param>
		/// <param name="debug_log">(Optional) Print detailed log files for debugging</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>design object</returns>
		public TTCL synth_design(string name = null, string part = null, string constrset = null, string top = null, TCLParameterList include_dirs = null, TCLParameterList generic = null, TCLParameterList verilog_define = null, string flatten_hierarchy = null, string gated_clock_conversion = null, string directive = null, bool? rtl = null, string bufg = null, bool? no_lc = null, string shreg_min_size = null, string mode = null, string fsm_extraction = null, bool? rtl_skip_mlo = null, bool? rtl_skip_ip = null, bool? rtl_skip_constraints = null, string srl_style = null, bool? keep_equivalent_registers = null, string resource_sharing = null, string cascade_dsp = null, string control_set_opt_threshold = null, string incremental = null, string max_bram = null, string max_uram = null, string max_dsp = null, string max_bram_cascade_height = null, string max_uram_cascade_height = null, bool? retiming = null, bool? no_srlextract = null, bool? assert = null, bool? no_timing_driven = null, bool? sfcu = null, bool? debug_log = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: synth_design [-name <arg>] [-part <arg>] [-constrset <arg>] [-top <arg>] [-include_dirs <args>] [-generic <args>] [-verilog_define <args>] [-flatten_hierarchy <arg>] [-gated_clock_conversion <arg>] [-directive <arg>] [-rtl] [-bufg <arg>] [-no_lc] [-shreg_min_size <arg>] [-mode <arg>] [-fsm_extraction <arg>] [-rtl_skip_mlo] [-rtl_skip_ip] [-rtl_skip_constraints] [-srl_style <arg>] [-keep_equivalent_registers] [-resource_sharing <arg>] [-cascade_dsp <arg>] [-control_set_opt_threshold <arg>] [-incremental <arg>] [-max_bram <arg>] [-max_uram <arg>] [-max_dsp <arg>] [-max_bram_cascade_height <arg>] [-max_uram_cascade_height <arg>] [-retiming] [-no_srlextract] [-assert] [-no_timing_driven] [-sfcu] [-debug_log] [-quiet] [-verbose]
			_tcl.Entry(_builder.synth_design(name, part, constrset, top, include_dirs, generic, verilog_define, flatten_hierarchy, gated_clock_conversion, directive, rtl, bufg, no_lc, shreg_min_size, mode, fsm_extraction, rtl_skip_mlo, rtl_skip_ip, rtl_skip_constraints, srl_style, keep_equivalent_registers, resource_sharing, cascade_dsp, control_set_opt_threshold, incremental, max_bram, max_uram, max_dsp, max_bram_cascade_height, max_uram_cascade_height, retiming, no_srlextract, assert, no_timing_driven, sfcu, debug_log, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Unregister a previously registered Tcl proc.
		///
		///
		/// TCL Syntax: unregister_proc [-quiet] [-verbose] <tasknm>
		///
		/// Unregister the Tcl command, or <tasknm>, from the Vivado Design Suite Tcl interpretor.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1756
		/// </summary>
		/// <param name="tasknm">(Required) Name of Tcl task to unregister. The task must be wrapping a proc.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Nothing</returns>
		public TTCL unregister_proc(string tasknm, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: unregister_proc [-quiet] [-verbose] <tasknm>
			_tcl.Entry(_builder.unregister_proc(tasknm, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Update clock routing on global clocks if they are modified after placement
		///
		///
		/// TCL Syntax: update_clock_routing [-quiet] [-verbose]
		///
		/// The update_clock_routing command is an advanced command used for manually updating
		/// the routing structures of all global clocks in designs targeting the UltraScale architecture. The
		/// command operates on all global clocks in a design, not individual clocks.
		/// Due to a more flexible clocking architecture, UltraScale and UltraScale+ designs require a two￾step process for routing global clocks. First the Vivado placer assigns the routing resources
		/// required to route the global clocks from the clock source to the destination clock regions
		/// (CLOCK_ROOT or USER_CLOCK_ROOT). Next the Vivado router fills in the routing gaps on the
		/// clock nets. In between these two steps the resulting structures are called gap trees: each global
		/// clock net has its base routing resources assigned but with large routing gaps where no routing
		/// resources have been assigned.
		/// After gap trees are constructed, the router optimally routes the remaining clock network to all
		/// leaf-level primitives to fill in the routing gaps. During an implementation run the global clock
		/// routing is handled automatically. However in cases where the clock tree has been changed after
		/// implementation, by modifying the USER_CLOCK_ROOT property on a clock net for instance, the
		/// Vivado tool may need the update_clock_routing command to properly rebuild the gap trees
		/// and fill in the routing gaps.
		/// Examples of this include:
		/// • Moving the clock root of a global clock.
		/// • Adding or moving loads of a global clock into a clock region not yet occupied by the global
		/// clock, then running timing analysis on the updated design.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// • Moving the clock root of a global clock.
		/// • Adding or moving loads of a global clock into a clock region not yet occupied by the global
		/// clock, then running timing analysis on the updated design.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Arguments
		/// -quiet - (Optional) Execute the command quietly, returning no messages from the command.
		/// The command also returns TCL_OK regardless of any errors encountered during execution.
		/// Note: Any errors encountered on the command-line, while launching the command, will be returned. Only
		/// errors occurring inside the command will be trapped.
		/// -verbose - (Optional) Temporarily override any message limits and return all messages from this
		/// command.
		/// Note: Message limits can be defined with the set_msg_config command.
		/// Examples
		/// The following example updates the USER_CLOCK_ROOT property on the specified clock nets,
		/// unroutes the nets, and then updates the clock routing:
		/// set_property USER_CLOCK_ROOT X1Y0 [get_nets {clk1 clk2}]
		/// route_design -unroute -nets [get_nets {clk1 clk2}]
		/// update_clock_routing
		/// IMPORTANT! The unroute command is needed to clean out existing clock routing on the clock nets
		/// before updating the clock routing.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1761
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
		/// Update the NoC solution
		///
		///
		/// TCL Syntax: update_noc_qos [-force] [-quiet] [-verbose]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1781
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
		/// Write iPhysOpt script.
		///
		///
		/// TCL Syntax: write_iphys_opt_tcl [-place] [-binary] [-quiet] [-verbose] [<output>]
		///
		/// Because physical optimization requires timing data that is only available after placement, the
		/// phys_opt_design command cannot be run prior to placement. However, the interactive
		/// physical optimization feature, or iphys_opt_design, lets you write out the physical
		/// optimizations performed on the post-placed design, and then apply those optimizations to the
		/// design netlist prior to placement. Refer to the Vivado Design Suite User Guide: Implementation
		/// (UG904) for more information on interactive physical optimization.
		/// Interactive physical optimization can be used in two ways:
		/// • Applying post-placement physical optimizations to the pre-placement netlist to improve the
		/// overall placement result and improve design performance.
		/// • Saving the physical optimizations in a Tcl script to be repeated as needed.
		/// The write_iphys_opt_tcl command can only be run after placement, on a design that has
		/// had actual physical optimizations performed.
		/// TIP: You can use the report_phys_opt command to report the physical optimizations that have been
		/// performed on the design.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The output is a Tcl script file with a sequence of iphys_opt_design commands listing the
		/// specific optimizations performed by the phys_opt_design command. The iphys_opt Tcl
		/// script can be edited to change the specific optimizations performed. The Tcl script provides a
		/// history of the physical optimizations performed on the design after placement, marked by date
		/// and history.
		/// IMPORTANT! The iphys_opt Tcl script contains the specific optimizations performed by the
		/// phys_opt_design command, but does not include placement and routing changes or results.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example writes the physical optimizations that have been performed in the current
		/// design to the specified Tcl script:
		/// write_iphys_opt_tcl C:/Data/myDesign_physopt.tcl
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1872
		/// </summary>
		/// <param name="output">(Required) tcl file containing iPhysOpt script</param>
		/// <param name="place">(Optional) write out placement information</param>
		/// <param name="binary">(Optional) write out in binary format</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_iphys_opt_tcl(string output, bool? place = null, bool? binary = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_iphys_opt_tcl [-place] [-binary] [-quiet] [-verbose] [<output>]
			_tcl.Entry(_builder.write_iphys_opt_tcl(output, place, binary, quiet, verbose));
			return _tcl;
		}
	}
}
