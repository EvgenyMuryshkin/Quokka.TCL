#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class DebugCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public DebugCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// <para>
		/// Apply trigger at startup init values to an ILA core in the design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: apply_hw_ila_trigger [-ila_cell &lt;arg&gt;] [-quiet] [-verbose] [&lt;file&gt;]
		/// <br/>
		/// <para>
		/// Apply a trigger configuration file to the bitstream of a design, to support ILA trigger at startup.<br/>
		/// This command is used to configure the trigger settings of an ILA core in a design bitstream (.bit)<br/>
		/// file, so that the ILA debug core is armed to trigger on events immediately after device<br/>
		/// configuration and startup. This allows data to be captured from the earliest stages of device<br/>
		/// activity, which would not be possible through the use of the Hardware Manager feature of the<br/>
		/// Vivado Design Suite, and the run_hw_ila command.<br/>
		/// The apply_hw_ila_trigger command reads a trigger configuration file written by<br/>
		/// run_hw_ila -file and applies the various trigger settings to the ILA core in the implemented<br/>
		/// design. The trigger configuration for the ILA core then become part of the bitstream written by<br/>
		/// write_bitstream, that is used to program the Xilinx FPGA device.<br/>
		/// The process for using the trigger at startup feature includes the following steps:<br/>
		/// 1. From the Hardware Manager, use run_hw_ila -file to export the trigger register map<br/>
		/// file for the ILA core.<br/>
		/// 2. Open the implemented design, or the implemented design checkpoint.<br/>
		/// 3. Use the apply_hw_ila_trigger command to apply the trigger settings to the in-memory<br/>
		/// design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// 4. Use the write_bitstream command to write the bitstream with the applied trigger<br/>
		/// configuration file.<br/>
		/// Note: Be sure to use the write_bitstream command, and not the Flow Navigator commands in the<br/>
		/// Vivado IDE.<br/>
		/// 5. Return to the Hardware Manager, and use program_hw_device to program the hw_device<br/>
		/// using the new bitstream file.<br/>
		/// Once programmed, the new ILA core should immediately arm at startup. In the Vivado logic<br/>
		/// analyzer feature, you should see the "Trigger Capture Status" for the ILA core is now populated<br/>
		/// with captured data samples if trigger events or capture conditions have occurred. Refer to the<br/>
		/// Vivado Design Suite User Guide: Vivado Programming and Debugging (UG908) for more information.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 106<br/>
		/// </para>
		/// </summary>
		/// <param name="ila_cell">(Optional) Apply trigger settings to this ila cell</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="file">(Optional) ILA startup trigger settings file</param>
		public TTCL apply_hw_ila_trigger(String ila_cell = null, bool? quiet = null, bool? verbose = null, TCLObject file = null)
		{
			// TCL Syntax: apply_hw_ila_trigger [-ila_cell <arg>] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.apply_hw_ila_trigger(ila_cell, quiet, verbose, file));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Connect debug slave instances to the master instance. A valid master is a debug bridge or debug<br/>
		/// hub instance configured in "From BSCAN To DebugHUB" mode. A valid slave could be any of the<br/>
		/// following debug cores (Ex: ILA, VIO, JTAG_to_AXI). connect_debug_cores can only connect<br/>
		/// master and slave instances that exist in the same region (either in Reconfigurable Partition or<br/>
		/// static)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: connect_debug_cores -master &lt;args&gt; -slaves &lt;args&gt; [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Connect debug slave instances to the specified master instance. The command can add the<br/>
		/// specified slaves into an existing debug chain, where the specified slaves will be connected to the<br/>
		/// debug hub or bridge, without affecting debug slaves that are already in the connection chain.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Debug masters include both the Debug Hub and Debug Bridge. The Vivado Debug Hub core<br/>
		/// provides an interface between the JTAG Boundary Scan (BSCAN) interface of the Xilinx device<br/>
		/// and the Vivado Debug cores, including the Integrated Logic Analyzer (ILA), Virtual Input/Output<br/>
		/// (VIO), and the JTAG-to-AXI. The Vivado Debug Bridge is a debug controller that provides<br/>
		/// multiple options to communicate with the debug cores in both flat designs, or Partial<br/>
		/// Reconfiguration (PR) designs. The Debug Bridge can be configured to debug designs using a<br/>
		/// JTAG cable, or remotely through Ethernet, PCIe, or other interfaces using a Xilinx Virtual Cable<br/>
		/// (XVC), without the need for a JTAG cable. Refer to the Vivado Design Suite User Guide: Vivado<br/>
		/// Programming and Debugging (UG908) for more information.<br/>
		/// IMPORTANT! For Partial Reconfiguration (PR) designs, the connect_debug_cores command can<br/>
		/// only connect master and slave instances that occur in the Static Region, or in the same Reconfigurable<br/>
		/// Partition.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example connects the specified ILA cores to the debug bridge:<br/>
		/// connect_debug_cores -master [get_cells inst_count/debug_bridge_0] \<br/>
		/// -slaves [list [get_cells inst_count/ila_0] [get_cells inst_count/ila_1] ]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 198<br/>
		/// </para>
		/// </summary>
		/// <param name="master">
		/// <para>
		/// (Required)<br/>
		/// A valid debug bridge or debug hub instance configured in<br/>
		/// "From BSCAN To DebugHUB" mode. Only one master<br/>
		/// instance is allowed.<br/>
		/// </para>
		/// </param>
		/// <param name="slaves">
		/// <para>
		/// (Required)<br/>
		/// List of valid slave instances. A valid slave instance is any of<br/>
		/// the following debug cores (Ex: ILA, VIO, JTAG_to_AXI)<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>debug master and slave instances</returns>
		public TTCL connect_debug_cores(TCLParameterList master, TCLParameterList slaves, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: connect_debug_cores -master <args> -slaves <args> [-quiet] [-verbose]
			_tcl.Entry(_builder.connect_debug_cores(master, slaves, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Connect nets and pins to debug port channels<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: connect_debug_port [-channel_start_index &lt;arg&gt;] [-quiet] [-verbose] &lt;port&gt; &lt;nets&gt;...
		/// <br/>
		/// <para>
		/// Connects a signal from the netlist design to a port on an ILA debug core that was added to the<br/>
		/// design using the create_debug_core command. The signal can either be connected to a<br/>
		/// specific channel index on the port, or simply connected to an available channel on the port.<br/>
		/// If you try to connect too many signals to a port, or there are not enough channels to support the<br/>
		/// connection, the tool will return an error.<br/>
		/// Additional ports can be added to a debug core through the use of the create_debug_port<br/>
		/// command, and you can increase the available channels on an existing port with the<br/>
		/// set_property port_width command. See the examples below.<br/>
		/// You can disconnect signals from ports using the disconnect_debug_port command.<br/>
		/// When the debug core has been defined and connected, you can implement the debug core as a<br/>
		/// block for inclusion in the netlist design. Use the implement_debug_core command to<br/>
		/// implement the core.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a new PROBE port on the myCore debug core, increases the<br/>
		/// PORT_WIDTH property of the port in order to prepare it to receive the number of signals to be<br/>
		/// connected, and connects signals to the port starting at the third channel position (index 2).<br/>
		/// create_debug_port myCore PROBE<br/>
		/// set_property PORT_WIDTH 8 [get_debug_ports myCore/PROBE1]<br/>
		/// connect_debug_port myCore/PROBE1 [get_nets [list m0_ack_o m0_cyc_i \<br/>
		/// m0_err_o m0_rty_o m0_stb_i m0_we_i ]] -channel_start_index 2<br/>
		/// Note: If you specify too many nets to connect to the available channels on the port, the tool will return an<br/>
		/// error and will not connect the ports.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 201<br/>
		/// </para>
		/// </summary>
		/// <param name="port">(Required) Debug port name</param>
		/// <param name="nets">(Required) List of nets or pins</param>
		/// <param name="channel_start_index">(Optional) Connect nets starting at channel index</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL connect_debug_port(TCLObject port, TCLObjectList nets, String channel_start_index = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: connect_debug_port [-channel_start_index <arg>] [-quiet] [-verbose] <port> <nets>...
			_tcl.Entry(_builder.connect_debug_port(port, nets, channel_start_index, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new Integrated Logic Analyzer debug core<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_debug_core [-quiet] [-verbose] &lt;name&gt; &lt;type&gt;
		/// <br/>
		/// <para>
		/// Adds a new Integrated Logic Analyzer (ILA) debug core to an open netlist design in the current<br/>
		/// project. The ILA debug core defines ports for connecting nets to for debugging the design in the<br/>
		/// logic analyzer feature of the Vivado Design Suite available through the open_hw command.<br/>
		/// ILA debug cores can be added to the RTL source files of the design using debug cores from the<br/>
		/// Xilinx IP catalog, or added to the netlist design after synthesis using this command. Refer to the<br/>
		/// Vivado Design Suite User Guide: Vivado Programming and Debugging (UG908) for more information<br/>
		/// on using ILA debug cores.<br/>
		/// Note: A debug core can only be added to an open netlist design using this command.<br/>
		/// The ILA core is created with a CLK port and a PROBE port by default. The CLK port defines the<br/>
		/// clock domain for the ILA core, and allows you to probe signals that are common to that domain.<br/>
		/// The CLK port only supports one clock signal, and so you must create a separate debug core for<br/>
		/// each clock domain. The PROBE port provides a probe point for nets marked for debug with the<br/>
		/// MARK_DEBUG property. The PROBE port offers multiple channels to probe multiple nets from a<br/>
		/// single ILA core.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// You can add new ports to an existing ILA core with the create_debug_port command, and<br/>
		/// connect signals to the ports using the connect_debug_port command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example opens the synthesis run, creating the specified netlist design name, and<br/>
		/// then creates a new ILA debug core in that design:<br/>
		/// open_run -name netlist_1 synth_1<br/>
		/// create_debug_core myCore ila<br/>
		/// The properties of the debug core can be customized by using the set_property command as<br/>
		/// in the following example:<br/>
		/// set_property C_DATA_DEPTH 2048 [get_debug_cores myCore]<br/>
		/// This example marks a sequence of nets for debugging using the MARK_DEBUG property, creates<br/>
		/// a new debug core, connects the CLK port to the appropriate clock domain, and assigns the debug<br/>
		/// nets to the PROBE ports on the core:<br/>
		/// set_property MARK_DEBUG true [get_nets [list {control_reg[0]}<br/>
		/// {control_reg[1]} \<br/>
		/// {control_reg[2]} {control_reg[3]} {control_reg[4]} {control_reg[5]} \<br/>
		/// {control_reg[6]} {control_reg[7]} {control_reg[8]} {control_reg[9]} \<br/>
		/// {control_reg[10]} {control_reg[11]} {control_reg[12]} {control_reg[13]}<br/>
		/// \<br/>
		/// {control_reg[14]} {control_reg[15]} {control_reg[16]} {control_reg[17]}<br/>
		/// \<br/>
		/// {control_reg[18]} {control_reg[19]} {control_reg[20]} {control_reg[21]}<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// \<br/>
		/// {control_reg[22]} {control_reg[23]} {control_reg[24]} {control_reg[25]}<br/>
		/// \<br/>
		/// {control_reg[26]} {control_reg[27]} {control_reg[28]} {control_reg[29]}<br/>
		/// \<br/>
		/// {control_reg[30]} {control_reg[31]}]]<br/>
		/// create_debug_core u_ila_0 ila<br/>
		/// set_property port_width 1 [get_debug_ports u_ila_0/CLK]<br/>
		/// connect_debug_port u_ila_0/CLK [get_nets [list wbClk ]]<br/>
		/// set_property port_width 32 [get_debug_ports u_ila_0/PROBE0]<br/>
		/// connect_debug_port u_ila_0/PROBE0 [get_nets [list {control_reg[0]}<br/>
		/// {control_reg[1]} {control_reg[2]} {control_reg[3]} {control_reg[4]} \<br/>
		/// {control_reg[5]} {control_reg[6]} {control_reg[7]} {control_reg[8]} \<br/>
		/// {control_reg[9]} {control_reg[10]} {control_reg[11]} {control_reg[12]}<br/>
		/// \<br/>
		/// {control_reg[13]} {control_reg[14]} {control_reg[15]} {control_reg[16]}<br/>
		/// \<br/>
		/// {control_reg[17]} {control_reg[18]} {control_reg[19]} {control_reg[20]}<br/>
		/// \<br/>
		/// {control_reg[21]} {control_reg[22]} {control_reg[23]} {control_reg[24]}<br/>
		/// \<br/>
		/// {control_reg[25]} {control_reg[26]} {control_reg[27]} {control_reg[28]}<br/>
		/// \<br/>
		/// {control_reg[29]} {control_reg[30]} {control_reg[31]} ]]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 255<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of the new debug core instance</param>
		/// <param name="type">(Required) Type of the new debug core</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>new debug_core object</returns>
		public TTCL create_debug_core(TCLObject name, TCLObject type, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_debug_core [-quiet] [-verbose] <name> <type>
			_tcl.Entry(_builder.create_debug_core(name, type, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new debug port<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_debug_port [-quiet] [-verbose] &lt;name&gt; &lt;type&gt;
		/// <br/>
		/// <para>
		/// Defines a new port to be added to an existing Vivado ILA debug core that was added to the<br/>
		/// design using the create_debug_core command. The port provides connection points on an<br/>
		/// ILA core to attach nets from the design for debugging.<br/>
		/// When a new debug core is created using the create_debug_core command, it includes a clk<br/>
		/// and probe port by default. However, you can add trigger input/output port types as well. Refer<br/>
		/// to the Vivado Design Suite User Guide: Programming and Debugging (UG908) for more information<br/>
		/// on port types and purpose.<br/>
		/// A port can have one or more connection points to support one or more nets to debug. As a<br/>
		/// default new ports are defined as having a width of 1, allowing only one net to be attached. You<br/>
		/// can change the port width of probe ports to support multiple signals using the set_property<br/>
		/// port_width command (see Examples).<br/>
		/// Note: clk, trig_in, trig_in_ack, trig_out, and trig_out_ack ports can only have a width of 1.<br/>
		/// You can connect signals to ports using the connect_debug_port command, modify existing<br/>
		/// probe connections using modify_debug_ports, and disconnect signals with the<br/>
		/// disconnect_debug_port command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a new debug core, and then adds an additional probe port to the<br/>
		/// core, then sets the width of that new port to 8, and connects signals to the probe port:<br/>
		/// create_debug_core myCore ila<br/>
		/// create_debug_port myCore probe<br/>
		/// set_property PORT_WIDTH 8 myCore/probe1<br/>
		/// connect_debug_port -channel_start_index 1 myCore/probe1 \<br/>
		/// {m1_cyc_i m1_ack_o m1_err_o m1_rty_o}<br/>
		/// Note: Recall that the ILA core is created with a clk and probe port by default, so the new probe port is<br/>
		/// automatically numbered as probe1.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 258<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of the debug core instance</param>
		/// <param name="type">(Required) Type of the new debug port</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>new debug_port object</returns>
		public TTCL create_debug_port(TCLObject name, TCLObject type, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_debug_port [-quiet] [-verbose] <name> <type>
			_tcl.Entry(_builder.create_debug_port(name, type, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Delete a debug core<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_debug_core [-quiet] [-verbose] &lt;cores&gt;...
		/// <br/>
		/// <para>
		/// Removes Vivado Lab Edition debug cores from the current project that were added by the<br/>
		/// create_debug_core command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following command deletes the myCore debug core from the current project:<br/>
		/// delete_debug_core myCore<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following command deletes all debug cores from the current project:<br/>
		/// delete_debug_core [get_debug_cores]<br/>
		/// Note: The get_debug_cores command returns all debug cores as a default.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 434<br/>
		/// </para>
		/// </summary>
		/// <param name="cores">(Required) Debug cores to delete</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_debug_core(TCLObjectList cores, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_debug_core [-quiet] [-verbose] <cores>...
			_tcl.Entry(_builder.delete_debug_core(cores, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Delete debug port<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_debug_port [-quiet] [-verbose] &lt;ports&gt;...
		/// <br/>
		/// <para>
		/// Deletes ports from Vivado Lab Edition debug cores in the current project. You can disconnect a<br/>
		/// signal from a debug port using disconnect_debug_port, or remove the port altogether using<br/>
		/// this command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example deletes the DATA port from myCore:<br/>
		/// delete_debug_port myCore/DATA<br/>
		/// Note: Some ports cannot be deleted because an ILA port requires one CLK port and one TRIG port as a<br/>
		/// minimum.<br/>
		/// The following example deletes the trigger ports (TRIG) from the myCore debug core:<br/>
		/// delete_debug_port [get_debug_ports myCore/TRIG*]<br/>
		/// Note: This example will not delete all TRIG ports from myCore, because an ILA core must have at least one<br/>
		/// TRIG port. The effect of this command will be to delete the TRIG ports starting at TRIG0 and removing all<br/>
		/// of them except the last port.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 436<br/>
		/// </para>
		/// </summary>
		/// <param name="ports">(Required) Debug ports to delete</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_debug_port(TCLObjectList ports, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_debug_port [-quiet] [-verbose] <ports>...
			_tcl.Entry(_builder.delete_debug_port(ports, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Disconnect nets and pins from debug port channels<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: disconnect_debug_port [-channel_index &lt;arg&gt;] [-quiet] [-verbose] &lt;port&gt;
		/// <br/>
		/// <para>
		/// Disconnect signals from the debug ports.<br/>
		/// Signals from the Netlist Design are connected to ports of a ILA debug core using the<br/>
		/// connect_debug_port command.<br/>
		/// A port can also be deleted from the debug core rather than simply disconnected by using the<br/>
		/// delete_debug_port command.<br/>
		/// If you need to determine the specific name of a port on a debug core, use the<br/>
		/// get_debug_ports command to list all ports on a core. You can also use the<br/>
		/// report_debug_core command to list all of the cores in the projects, and their specific<br/>
		/// parameters.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example disconnects only the specified channel index from the PROBE1 port of<br/>
		/// myCore:<br/>
		/// disconnect_debug_port -channel_index 2 myCore/PROBE1<br/>
		/// If you do not specify the channel_index, all of the channels of the specified port will be<br/>
		/// disconnected, as in the following example:<br/>
		/// disconnect_debug_port myCore/PROBE1<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 494<br/>
		/// </para>
		/// </summary>
		/// <param name="port">(Required) Debug port name</param>
		/// <param name="channel_index">(Optional) Disconnect the net at channel index</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL disconnect_debug_port(TCLObject port, String channel_index = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: disconnect_debug_port [-channel_index <arg>] [-quiet] [-verbose] <port>
			_tcl.Entry(_builder.disconnect_debug_port(port, channel_index, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of debug cores in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_debug_cores [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of Vivado Lab Edition debug cores in the current project that match a specified search<br/>
		/// pattern. The default command gets a list of all debug cores in the project.<br/>
		/// Debug cores are added to the project with the create_debug_core command. When a ILA<br/>
		/// debug core (labtools_ila_v3) is added to the project, it is contained within a Debug Hub core<br/>
		/// (labtools_xsdbmasterlib_v2), and includes a CLK port and a PROBE port as a default. Additional<br/>
		/// ports can be added to the debug core with the use of the create_debug_port command.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following command gets a list of the Vivado Lab Edition debug cores in the current project:<br/>
		/// get_debug_cores<br/>
		/// Note: A Debug Hub core is returned as one of the debug cores in the project. You cannot directly create<br/>
		/// this core, but it is automatically added by the tool when you add any ILA cores to the project.<br/>
		/// The following example gets the properties of the specified debug core:<br/>
		/// report_property [get_debug_cores myCore]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 669<br/>
		/// </para>
		/// </summary>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get cores of these debug ports or nets</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match debug cores against patterns Default: *</param>
		/// <returns>list of debug_core objects</returns>
		public TTCL get_debug_cores(String filter = null, TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_debug_cores [-filter <arg>] [-of_objects <args>] [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_debug_cores(filter, of_objects, regexp, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of debug ports in the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_debug_ports [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Gets a list of ports defined on ILA debug cores in the current project that match a specified<br/>
		/// search pattern. The default command gets a list of all debug ports in the project.<br/>
		/// Debug ports are defined when ILA debug cores are created with the create_debug_core<br/>
		/// command. Ports can be added to existing debug cores with the create_debug_port<br/>
		/// command.<br/>
		/// Note: To improve memory and performance, the get_* commands return a container list of a single type<br/>
		/// of objects (e.g. cells, nets, pins, or ports). You can add new objects to the list (using lappend for instance),<br/>
		/// but you can only add the same type of object that is currently in the list. Adding a different type of object,<br/>
		/// or string, to the list is not permitted and will result in a Tcl error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following command gets a list of the ports from the ILA debug cores in the current project,<br/>
		/// with a PORT_WIDTH property of 8:<br/>
		/// get_debug_ports -filter {PORT_WIDTH==8}<br/>
		/// The following example gets the properties attached to the specified debug port:<br/>
		/// report_property [get_debug_ports myCore/PROBE1]<br/>
		/// Note: The debug port is defined by the core_name/port_name combination.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 672<br/>
		/// </para>
		/// </summary>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get ports of these debug cores</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching (valid only when -regexp specified)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match debug ports against patterns Default: *</param>
		/// <returns>list of debug_port objects</returns>
		public TTCL get_debug_ports(String filter = null, TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_debug_ports [-filter <arg>] [-of_objects <args>] [-regexp] [-nocase] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_debug_ports(filter, of_objects, regexp, nocase, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Implement debug core<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: implement_debug_core [-quiet] [-verbose] [&lt;cores&gt;...]
		/// <br/>
		/// <para>
		/// Implements the Vivado logic analyzer debug cores in the current project. The tools will be run<br/>
		/// once for any ILA debug cores specified, and run one more time for the Debug Hub core if all<br/>
		/// cores are specified. The ILA core (labtools_ila_v3) is the only core type currently supported by the<br/>
		/// create_debug_core command. The tool automatically adds a Debug Hub core<br/>
		/// (labtools_xsdbmasterlib_v2) to contain and configure the ILA cores in the project.<br/>
		/// The Vivado tool creates Debug Hub core and ILA cores initially as black boxes. These cores must<br/>
		/// be implemented prior to running through place and route. After the core is created with<br/>
		/// create_debug_core, and while ports are being added and connected with<br/>
		/// create_debug_port and connect_debug_port, the content of the debug core is not<br/>
		/// defined or visible within the design.<br/>
		/// Debug core implementation is automatic when you launch an implementation run using the<br/>
		/// launch_runs command, or during design optimization using opt_design. However, you can<br/>
		/// also use the implement_debug_core command to implement one or more of the cores in the<br/>
		/// design without having to implement the whole design.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example implements all debug cores in the current project:<br/>
		/// implement_debug_core [get_debug_cores]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 978<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="cores">(Optional) Debug core</param>
		public TTCL implement_debug_core(bool? quiet = null, bool? verbose = null, TCLObjectList cores = null)
		{
			// TCL Syntax: implement_debug_core [-quiet] [-verbose] [<cores>...]
			_tcl.Entry(_builder.implement_debug_core(quiet, verbose, cores));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Modify routed probe connections to debug cores.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: modify_debug_ports [-probes &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Modifies a routed design to connect nets to specified ports of debug cores. This command takes<br/>
		/// a list of connections to be made to specified debug probes. Each connection is defined as a Tcl<br/>
		/// list, enclosed in braces {}, specifying the following three elements separated by spaces:<br/>
		/// 1. The logical pin of the debug core to be connected.<br/>
		/// 2. The channel index of the specified probe.<br/>
		/// 3. The logical net of the signal to be probed.<br/>
		/// Multiple probe connections are specified as a list of lists, with each connection itself being a Tcl<br/>
		/// list as shown in the example.<br/>
		/// The command performs all of the netlist modifications to disconnect existing net connections to<br/>
		/// the specified probe ports as needed, connecting each net to be probed to the specified probe<br/>
		/// port, and automatically routing the modified connections. Nets that become disconnected during<br/>
		/// the process are left unconnected.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example modifies 3 probe connections:<br/>
		/// modify_debug_ports -probes [list {top/x_ila/probe0 0 top/inst_A/net_0} \<br/>
		/// {top/x_ila/probe1 1 top/inst_A/net_a} {top/x_ila/probe1 2 top/inst_A/<br/>
		/// net_b}]<br/>
		/// TIP: The modify_debug_ports command moves a port probe from one signal to another.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1064<br/>
		/// </para>
		/// </summary>
		/// <param name="probes">
		/// <para>
		/// (Required)<br/>
		/// List of probes to be connected: debug core pin, channel<br/>
		/// index, and logical net for each probe connection.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL modify_debug_ports(TCLParameterList probes, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: modify_debug_ports [-probes <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.modify_debug_ports(probes, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report details on debug cores<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_debug_core [-file &lt;arg&gt;] [-append] [-return_string] [-full_path] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Writes a report of the various Vivado device tool debug cores in the current project, and the<br/>
		/// parameters of those cores. Debug cores can be added to a project using the<br/>
		/// create_debug_core command.<br/>
		/// Note: By default the report is written to the Tcl console or STD output. However, the results can also be<br/>
		/// written to a file or returned as a string if desired.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example writes the debug core report to the specified file name at the specified<br/>
		/// location:<br/>
		/// report_debug_core -file C:/Data/FPGA_Design/project_1_cores.txt<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1334<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. (send output to console if -file<br/>
		/// is not used)<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the results to file, don't overwrite the results file</param>
		/// <param name="return_string">(Optional) Return report as a string</param>
		/// <param name="full_path">(Optional) Display full hierarchical net path in report</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_debug_core(String file = null, bool? append = null, bool? return_string = null, bool? full_path = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_debug_core [-file <arg>] [-append] [-return_string] [-full_path] [-quiet] [-verbose]
			_tcl.Entry(_builder.report_debug_core(file, append, return_string, full_path, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write debug probes to a file<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_debug_probes [-cell &lt;arg&gt;] [-no_partial_ltxfile] [-force] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Writes a Vivado Design Suite logic analyzer probes file containing ILA debug cores and signal<br/>
		/// probes added to the current design. The debug probes data file typically has a .ltx file<br/>
		/// extension.<br/>
		/// ILA cores are added to the design using the create_debug_core command. ILA probes are<br/>
		/// added to the design using the create_debug_port command, and connected to nets in your<br/>
		/// design using the connect_debug_port command.<br/>
		/// The specific information and use of the debug probes file is described in the Vivado Design Suite<br/>
		/// User Guide: Vivado Programming and Debugging (UG908).<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example write a debug probe file from the current design:<br/>
		/// write_debug_probes C:/Data/designProbes.ltx<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1842<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Debug probes file name (default extension is .ltx)</param>
		/// <param name="cell">(Optional) Hierarchical name of the Reconfigurable Partition Cell</param>
		/// <param name="no_partial_ltxfile">(Optional) Do not generate partial LTX files</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>name of the output file</returns>
		public TTCL write_debug_probes(TCLObject file, String cell = null, bool? no_partial_ltxfile = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_debug_probes [-cell <arg>] [-no_partial_ltxfile] [-force] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_debug_probes(file, cell, no_partial_ltxfile, force, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
