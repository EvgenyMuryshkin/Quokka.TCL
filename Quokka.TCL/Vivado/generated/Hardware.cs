#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
namespace Quokka.TCL.Vivado
{
	public partial class HardwareCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public HardwareCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// <para>
		/// Select Pseudo Channel to add to Activity Monitor on the specified hardware HBM(s). Must<br/>
		/// specify the Memory Controller number first, follow by Pseudo Channel number.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: add_hw_hbm_pc [-quiet] [-verbose] &lt;mc_num&gt; &lt;pc_num&gt; &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// The HBM activity monitor (amon) can be used to gain real-time access to performance<br/>
		/// monitoring and temperature sensors certain Xilinx® UltraScale+ devices that include an<br/>
		/// integrated High-Bandwidth Memory (HBM) controller. Refer to the LogiCore IP Product Guide:<br/>
		/// AXI High Bandwidth Memory Controller (PG276) for more information on this core. The HBM<br/>
		/// controller and memory stacks contain both performance counters and temperature sensors that<br/>
		/// can be accessed through the HBM activity monitor from within the Xilinx Vivado hardware<br/>
		/// manager. Each HBM stack is split into eight independent memory channels, each of which is<br/>
		/// further divided into two 64-bit pseudo channels (pc).<br/>
		/// After configuring an HBM enabled device with a design that contains instances of the AXI High<br/>
		/// Bandwidth Memory Controller, the HBM cores will be visible in the Vivado hardware manager.<br/>
		/// The add_hw_hbm_pc command lets you specify a memory channel (mc)/psuedo channel (pc) to<br/>
		/// monitor in the HBM activity monitor prior to using the run_hw_hbm_amon command.<br/>
		/// TIP: The HBM activity monitor must not be running when adding or removing psuedo channels.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example adds the specified memory channels/psuedo channels on the defined<br/>
		/// HBM controller (hw_hbm) object, and then runs the HBM activity monitor in the Vivado<br/>
		/// hardware manager:<br/>
		/// set hbm_mon [get_hw_hbms *HBM_2]<br/>
		/// add_hw_hbm_pc 0 0 $hbm_mon<br/>
		/// add_hw_hbm_pc 0 1 $hbm_mon<br/>
		/// add_hw_hbm_pc 1 0 $hbm_mon<br/>
		/// add_hw_hbm_pc 1 1 $hbm_mon<br/>
		/// add_hw_hbm_pc 2 0 $hbm_mon<br/>
		/// add_hw_hbm_pc 2 1 $hbm_mon<br/>
		/// add_hw_hbm_pc 3 0 $hbm_mon<br/>
		/// add_hw_hbm_pc 3 1 $hbm_mon<br/>
		/// run_hw_hbm_amon $hbm_mon<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 52<br/>
		/// </para>
		/// </summary>
		/// <param name="mc_num">(Required) Memory Controller number to select: 0 to 7</param>
		/// <param name="pc_num">(Required) Pseudo Channel number to select: 0 or 1</param>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL add_hw_hbm_pc(TCLObject mc_num, TCLObject pc_num, TCLObject hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: add_hw_hbm_pc [-quiet] [-verbose] <mc_num> <pc_num> <hw_objects>
			_tcl.Entry(_builder.add_hw_hbm_pc(mc_num, pc_num, hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Add an enumerated name-value pair to a hw_probe enumeration.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: add_hw_probe_enum [-no_gui_update] [-dict &lt;args&gt;] [-quiet] [-verbose] &lt;name&gt; &lt;value&gt; &lt;hw_probe&gt;
		/// <br/>
		/// <para>
		/// Assign enumerated name/value pairs to specified hardware probe objects.<br/>
		/// This command is intended to make it easier to monitor the states of signals in the Vivado logic<br/>
		/// analyzer. The command lets you define a set of states, or enumerated names to be associated<br/>
		/// with specific values that may be found on a hw_probe object. This lets you monitor state<br/>
		/// machine probes and some other types of probes, by comparing symbolic names with trigger<br/>
		/// values and waveform data values.<br/>
		/// The enumerated name is added as an ENUM.NAME property on the specified hw_probe object,<br/>
		/// and associated with the specified bit value on the probe. Enumerated names can be used to<br/>
		/// specify trigger/capture compare values for hw_probes.<br/>
		/// TIP: Enumerated names are displayed in the waveform viewer of the Vivado logic analyzer. Display of the<br/>
		/// enumerated names can be disabled on a per probe basis. Refer to the Vivado Design Suite User Guide:<br/>
		/// Programming and Debugging (UG908) for more information on the waveform viewer.<br/>
		/// This command returns the enumerated name property, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example uses the -dict option to define the enumerated name/value pairs for<br/>
		/// the specified hw_probe object:<br/>
		/// add_hw_probe_enum -dict {ZERO eq5'h00 RED eq5'h12 GREEN eq5'h13 \<br/>
		/// BLUE eq5'h14 WHITE eq5'h15 YELLOW eq5'h16 GREY eq5'h17} \<br/>
		/// [get_hw_probes op1 -of_objects [current_hw_ila]]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example defines the enumerated name/value pairs for the specified hw_probe<br/>
		/// object:<br/>
		/// add_hw_probe_enum ZERO eq5'h00 [get_hw_probes op1 \<br/>
		/// -of_objects [current_hw_ila]]<br/>
		/// add_hw_probe_enum RED eq5'h12 [get_hw_probes op1 \<br/>
		/// -of_objects [current_hw_ila]]<br/>
		/// add_hw_probe_enum GREEN eq5'h13 [get_hw_probes op1 \<br/>
		/// -of_objects [current_hw_ila]]<br/>
		/// add_hw_probe_enum BLUE eq5'h14 [get_hw_probes op1 \<br/>
		/// -of_objects [current_hw_ila]]<br/>
		/// add_hw_probe_enum WHITE eq5'h15 [get_hw_probes op1 \<br/>
		/// -of_objects [current_hw_ila]]<br/>
		/// add_hw_probe_enum YELLOW eq5'h16 [get_hw_probes op1 \<br/>
		/// -of_objects [current_hw_ila]]<br/>
		/// add_hw_probe_enum GREY eq5'h17 [get_hw_probes op1 \<br/>
		/// -of_objects [current_hw_ila]]<br/>
		/// The following example returns the ENUM property assigned to the specified hw_probe object:<br/>
		/// report_property [get_hw_probes op1 -of_objects [current_hw_ila]] ENUM*<br/>
		/// Property Type Read-only Visible Value<br/>
		/// ENUM.ZERO string true true eq5'h00<br/>
		/// ENUM.RED string true true eq5'h12<br/>
		/// ENUM.GREEN string true true eq5'h13<br/>
		/// ENUM.BLUE string true true eq5'h14<br/>
		/// ENUM.WHITE string true true eq5'h15<br/>
		/// ENUM.YELLOW string true true eq5'h16<br/>
		/// ENUM.GREY string true true eq5'h17<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 54<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Enumerated name.</param>
		/// <param name="value">(Required) Explicit value.</param>
		/// <param name="hw_probe">(Required) hw_probe object.</param>
		/// <param name="no_gui_update">(Optional) Defer GUI update.</param>
		/// <param name="dict">(Optional) List of parameter name-value pairs.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL add_hw_probe_enum(TCLObject name, TCLObject value, TCLObject hw_probe, bool? no_gui_update = null, TCLParameterList dict = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: add_hw_probe_enum [-no_gui_update] [-dict <args>] [-quiet] [-verbose] <name> <value> <hw_probe>
			_tcl.Entry(_builder.add_hw_probe_enum(name, value, hw_probe, no_gui_update, dict, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Issue JTAG Program command to hw_device<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: boot_hw_device [-disable_done_check] [-timeout &lt;arg&gt;] [-quiet] [-verbose] &lt;hw_device&gt;
		/// <br/>
		/// <para>
		/// Issue JTAG PROGRAM command to the hw_device (FPGA).<br/>
		/// The boot_hw_device command triggers the FPGA boot and board startup sequence. The boot<br/>
		/// sequence starts the FPGA configuration process to clear the device of any prior programming,<br/>
		/// and then to load a new program, depending on the mode pin settings.<br/>
		/// The hw_device will boot based on its mode pin settings. If the FPGA's mode pins on the device<br/>
		/// are set to JTAG mode, or the interface is not active (e.g. the PROM is not configured) the net<br/>
		/// effect of the boot_hw_device command is to clear the prior programming.<br/>
		/// This command returns a 1 if it detects that the DONE pin has gone HIGH, or when the device<br/>
		/// has been cleared, otherwise it returns 0.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 118<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_device">(Required) Target hw_device connection</param>
		/// <param name="disable_done_check">(Optional) Disable done check for boot device</param>
		/// <param name="timeout">(Optional) Time out for boot (seconds) Default: default</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL boot_hw_device(TCLObject hw_device, bool? disable_done_check = null, String timeout = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: boot_hw_device [-disable_done_check] [-timeout <arg>] [-quiet] [-verbose] <hw_device>
			_tcl.Entry(_builder.boot_hw_device(hw_device, disable_done_check, timeout, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Close the hardware tool<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: close_hw_manager [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Close the Hardware Manager tool in the Vivado Design Suite.<br/>
		/// Opening the Hardware Manager using the open_hw_manager command, is the first step in<br/>
		/// programming and/or debugging your design in Xilinx FPGA hardware. For more information refer<br/>
		/// to the Vivado Design Suite User Guide: Programming and Debugging (UG908).<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 139<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL close_hw_manager(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: close_hw_manager [-quiet] [-verbose]
			_tcl.Entry(_builder.close_hw_manager(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Close a hardware target<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: close_hw_target [-quiet] [-verbose] [&lt;hw_target&gt;]
		/// <br/>
		/// <para>
		/// Close the connection to the current or specified hardware target that was previously opened<br/>
		/// using the open_hw_target command.<br/>
		/// The hardware target is a system board containing a JTAG chain of one or more Xilinx devices that<br/>
		/// you can program with a bitstream file, or use to debug your design. Connections between<br/>
		/// hardware targets on the system board and the Vivado Design Suite are managed by the<br/>
		/// hw_server application. Refer to Vivado Design Suite User Guide: Programming and Debugging<br/>
		/// (UG908) for a list of supported JTAG download cables and devices.<br/>
		/// This command returns connection messages from the hardware server, or returns an error if it<br/>
		/// fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 141<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_target">(Optional) hardware target Default: current hardware target</param>
		public TTCL close_hw_target(bool? quiet = null, bool? verbose = null, TCLObject hw_target = null)
		{
			// TCL Syntax: close_hw_target [-quiet] [-verbose] [<hw_target>]
			_tcl.Entry(_builder.close_hw_target(quiet, verbose, hw_target));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Commit the property changes of the current hardware object. Inputs can be HBM or device<br/>
		/// hardware object. At least one object is required.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: commit_hw_hbm [-quiet] [-verbose] &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// Commit the current values of properties defined on the specified HBM controller in the Vivado<br/>
		/// hardware manager to the current hardware device.<br/>
		/// The commit_hw_hbm command takes the current property values defined on a hw_hbm object<br/>
		/// and commits them to the current hardware device connected to the hardware server.<br/>
		/// When you change the property values on the hw_hbm object, they are not written to the<br/>
		/// hardware device until you use the commit_hw_hbm command.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example changes a property of the specified HBM controller object, and then<br/>
		/// commits the change to the device:<br/>
		/// set_property MC2.INIT.AM_REPEAT_EN 1 [get_hw_hbms *HBM_2]<br/>
		/// commit_hw_hbm [get_hw_hbm *HBM_2]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 154<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL commit_hw_hbm(TCLObject hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: commit_hw_hbm [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.commit_hw_hbm(hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Commit the property changes of the current hardware object. Inputs can be any mig, device,<br/>
		/// target, or server hardware object. At least one object is required.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: commit_hw_mig [-quiet] [-verbose] &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// Commit the current values of properties defined on the specified memory IP debug core<br/>
		/// hardware objects in the Hardware Manager feature of the Vivado Design Suite to the current<br/>
		/// hardware device.<br/>
		/// The commit_hw_mig command takes the current property values defined on a hw_mig object in<br/>
		/// the Vivado logic analyzer, and commits them to the current hardware device connected to the<br/>
		/// hardware server.<br/>
		/// When you change the property values on the hw_mig object, like the CONFIG.* properties, they<br/>
		/// are not written to the hardware device until you use the commit_hw_mig command.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 156<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL commit_hw_mig(TCLObject hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: commit_hw_mig [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.commit_hw_mig(hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Commit the property changes of the current hardware object. Inputs can be any serial I/O<br/>
		/// (except scan and sweep), device, target, or server hardware object. At least one object is required.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: commit_hw_sio [-quiet] [-verbose] &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// Commit the current values of properties defined on the specified serial I/O hardware objects in<br/>
		/// the Hardware Manager feature of the Vivado Design Suite to the current hardware device.<br/>
		/// Specified objects can include any serial I/O object such as GTs, RXs, TXs, PLLs, or Commons,<br/>
		/// excluding hw_sio_scan and hw_sio_sweep objects. SIO objects also include device, target, or<br/>
		/// server hardware objects.<br/>
		/// The SIO IBERT core operates on an object property-based set/commit use model. You can set<br/>
		/// the property values on the hardware objects using the set_property command. You can then<br/>
		/// drive those values onto the current hardware device using the commit_hw_sio command.<br/>
		/// TIP: To update the properties on the hardware object with the actual value on the device use the<br/>
		/// refresh_hw_sio command.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 158<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL commit_hw_sio(TCLObject hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: commit_hw_sio [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.commit_hw_sio(hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Commit the property changes of the current hardware object. Inputs can be hw_server,<br/>
		/// hw_target, hw_device or hw_sysmon objects. At least one object is required.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: commit_hw_sysmon [-quiet] [-verbose] &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// The commit_hw_sysmon command takes the current property values defined on a hw_sysmon<br/>
		/// object, and commits them to the system monitor registers on the hardware device.<br/>
		/// When you change the property values on the hw_sysmon object, like the CONFIG.* properties,<br/>
		/// they are not written to the hardware device until you use the commit_hw_sysmon command.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 160<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL commit_hw_sysmon(TCLObject hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: commit_hw_sysmon [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.commit_hw_sysmon(hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write hardware VIO probe OUTPUT_VALUE properties values to VIO core(s).<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: commit_hw_vio [-quiet] [-verbose] &lt;hw_objects&gt;...
		/// <br/>
		/// <para>
		/// Commit the current values defined on the probes of the VIO Debug core to the current hardware<br/>
		/// device.<br/>
		/// The Virtual Input/Output (VIO) debug core can both monitor and drive internal signals on a<br/>
		/// programmed Xilinx FPGA in real time. The VIO core uses hardware probes, hw_probe objects, to<br/>
		/// monitor and drive signals on the device. Input probes monitor signals as inputs to the VIO core.<br/>
		/// Output probes drive signals to specified values from the VIO core.<br/>
		/// The VIO core operates on an object property-based set/commit use model. You can set the<br/>
		/// OUTPUT_VALUE property on the output probes of the VIO core using the set_property<br/>
		/// command. You can then drive those values onto probed signals on the hardware device using the<br/>
		/// commit_hw_vio command.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 162<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_objects">(Required) List of hardware VIO and hardware probe objects.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL commit_hw_vio(TCLObjectList hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: commit_hw_vio [-quiet] [-verbose] <hw_objects>...
			_tcl.Entry(_builder.commit_hw_vio(hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Configure the device GTs for the specified device.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: config_hw_sio_gts [-dict &lt;args&gt;] [-quiet] [-verbose] &lt;hw_device&gt;
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 176<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_device">(Required) hardware device object</param>
		/// <param name="dict">
		/// <para>
		/// (Optional)<br/>
		/// list of name/value pairs of GT settings and values to use to<br/>
		/// configure GTs<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL config_hw_sio_gts(TCLObject hw_device, TCLParameterList dict = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: config_hw_sio_gts [-dict <args>] [-quiet] [-verbose] <hw_device>
			_tcl.Entry(_builder.config_hw_sio_gts(hw_device, dict, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Open a connection to a hardware server<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: connect_hw_server [-url &lt;arg&gt;] [-cs_url &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// IMPORTANT! You must use the open_hw command to open the Hardware Manager in the Vivado<br/>
		/// Design Suite before using this command.<br/>
		/// To open a hardware target containing a JTAG chain of one or more Xilinx devices, for<br/>
		/// programming and/or debugging your design, you must first connect to a Vivado tools hardware<br/>
		/// server (hw_server) to manage the connection to the hardware target (hw_target).<br/>
		/// The hw_server manages the connection to the physical programming target. It should be running<br/>
		/// on the machine connected to the hardware programmer, or test board, connected either locally<br/>
		/// or remotely. The hw_server command must be launched as a separate application, and can be<br/>
		/// found in the /bin folder of your Vivado Design Suite installation directory.<br/>
		/// To connect to a hardware server, the hw_server application must be running, and the host<br/>
		/// name and port number noted for the -url argument of the connect_hw_server command.<br/>
		/// The default URL for the hw_server process is localhost:3121. For more information on<br/>
		/// setting up and running the Vivado hardware server, refer to the Vivado Design Suite User Guide:<br/>
		/// Programming and Debugging (UG908).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// You can connect a single instance of the Vivado Design Suite to multiple hardware servers, to<br/>
		/// support programming and debugging different device configurations. However, you can only<br/>
		/// have one connection to a specific hardware server as identified by the host name/port number<br/>
		/// combination. An error is returned if you attempt to open a connection to a server that is already<br/>
		/// connected.<br/>
		/// The last connected hardware server is the current hardware server, unless changed by the<br/>
		/// current_hw_server command. Any connected server can be disconnected with the<br/>
		/// disconnect_hw_server command.<br/>
		/// This command returns the host name of the hardware server that has been connected.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 203<br/>
		/// </para>
		/// </summary>
		/// <param name="url">(Optional) hw_server url Default: localhost:3121</param>
		/// <param name="cs_url">
		/// <para>
		/// (Optional)<br/>
		/// Url to use for cs_server. If default url is used and no server is<br/>
		/// running there, cs_server will be automatically launched on<br/>
		/// the default url. Default: TCP:localhost:3042<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>hardware server</returns>
		public TTCL connect_hw_server(String url = null, String cs_url = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: connect_hw_server [-url <arg>] [-cs_url <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.connect_hw_server(url, cs_url, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create hardware AXI transaction object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_hw_axi_txn [-address &lt;arg&gt;] [-data &lt;arg&gt;] [-size &lt;arg&gt;] -type &lt;arg&gt; [-len &lt;arg&gt;] [-burst &lt;arg&gt;] [-cache &lt;arg&gt;] [-id &lt;arg&gt;] [-force] [-quiet] [-verbose] &lt;name&gt; &lt;hw_axi&gt;
		/// <br/>
		/// <para>
		/// Define a read or write transaction for the JTAG to AXI Master core, hw_axi object, specified by<br/>
		/// the get_hw_axis command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The JTAG to AXI Master is a customizable IP core that works as an AXI Master to drive AXI<br/>
		/// transactions and drive AXI signals that are internal to the hardware device. The JTAG-AXI core<br/>
		/// supports all memory-mapped AXI interfaces, except AXI4-Stream, and supports the AXI-Lite<br/>
		/// protocol. Detailed documentation on the IP core can be found in the LogiCORE IP JTAG to AXI<br/>
		/// Master Product Guide (PG174).<br/>
		/// AXI transactions are read/write burst transactions from the JTAG to AXI Master core onto AXI<br/>
		/// signals connected to the core. The AXI transaction lets you configure aspects of the read or write<br/>
		/// transaction such as the data to send and the address to send it to. These defined transactions are<br/>
		/// stored as properties of the specified hw_axi object, waiting to be run and reported using the<br/>
		/// run_hw_axi and report_hw_axi_txn commands.<br/>
		/// The command returns the name of the hw_axi_txn object created, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 284<br/>
		/// </para>
		/// </summary>
		/// <param name="type">(Required) READ or WRITE transaction.</param>
		/// <param name="name">(Required) Name of new object.</param>
		/// <param name="hw_axi">(Required) Associated hardware AXI core object.</param>
		/// <param name="address">(Optional) AXI read or write address. Default: Address zero</param>
		/// <param name="data">(Optional) Transaction data. Default: All zeroes</param>
		/// <param name="size">
		/// <para>
		/// (Optional)<br/>
		/// Deprecated. Data word size in bits. This is now automatically<br/>
		/// set based on the IP core properties.<br/>
		/// </para>
		/// </param>
		/// <param name="len">(Optional) Length of the transaction in data words. Default: 1</param>
		/// <param name="burst">(Optional) Burst type: INCR,FIXED or WRAP. Default: INCR</param>
		/// <param name="cache">(Optional) AXI cache type. Default: 3</param>
		/// <param name="id">(Optional) Address ID. Default: 0</param>
		/// <param name="force">
		/// <para>
		/// (Optional)<br/>
		/// Overwrite an existing transaction with the specified name if<br/>
		/// it exists, otherwise create a new transaction. Default: 0<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>New hardware AXI transaction object.</returns>
		public TTCL create_hw_axi_txn(String type, TCLObject name, TCLObject hw_axi, String address = null, String data = null, String size = null, String len = null, String burst = null, String cache = null, String id = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_hw_axi_txn [-address <arg>] [-data <arg>] [-size <arg>] -type <arg> [-len <arg>] [-burst <arg>] [-cache <arg>] [-id <arg>] [-force] [-quiet] [-verbose] <name> <hw_axi>
			_tcl.Entry(_builder.create_hw_axi_txn(type, name, hw_axi, address, data, size, len, burst, cache, id, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Read bitstream file into memory<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_hw_bitstream -hw_device &lt;arg&gt; [-mask &lt;arg&gt;] [-nky &lt;arg&gt;] [-detect_partial] [-quiet] [-verbose] [&lt;file&gt;]
		/// <br/>
		/// <para>
		/// Read a bitstream file, created with the write_bitstream command, to create a hw_bitstream<br/>
		/// object, and associate that object with a hw_device object in the Hardware Manager feature of<br/>
		/// the Vivado Design Suite.<br/>
		/// The hw_bitstream object is associated with the specified hw_device through the<br/>
		/// PROGRAM.HW_BITSTREAM property on the device. This property is automatically set by the<br/>
		/// create_hw_bitstream command. The PROGRAM.FILE property is also set to reflect the file<br/>
		/// path of the specified bitstream file.<br/>
		/// Note: A hw_bitstream object is also automatically created and associated with a hw_device object when<br/>
		/// you use the program_hw_devices command.<br/>
		/// The mask file written with the bitstream file, using the write_bitstream -mask command, is<br/>
		/// associated through the MASK property on the hw_bitstream object. The encryption key file<br/>
		/// required for use with an encrypted bitstream is associated through the ENCRYPTION.FILE<br/>
		/// property on the hw_bitstream object. These files are associated with the hw_bitstream object<br/>
		/// using the -mask and -nky options.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The created hw_bitstream object can be removed with the delete_hw_bitstream command.<br/>
		/// This command returns the name of the hw_bitstream object created, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 288<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_device">(Required) Target hw_device connection</param>
		/// <param name="file">(Required) Bitstream filename</param>
		/// <param name="mask">(Optional) Mask file for hw device</param>
		/// <param name="nky">(Optional) Encryption file for hw device</param>
		/// <param name="detect_partial">(Optional) detects partial bitstream</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_hw_bitstream(String hw_device, TCLObject file, String mask = null, String nky = null, bool? detect_partial = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_hw_bitstream -hw_device <arg> [-mask <arg>] [-nky <arg>] [-detect_partial] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.create_hw_bitstream(hw_device, file, mask, nky, detect_partial, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Read cfgmem file into memory<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_hw_cfgmem -hw_device &lt;arg&gt; [-quiet] [-verbose] &lt;mem_device&gt;
		/// <br/>
		/// <para>
		/// Create a hw_cfgmem object associated with the specified hw_device.<br/>
		/// The process whereby the bitstream data is loaded or programmed into the Xilinx® FPGA is called<br/>
		/// configuration. Configuration is designed to be flexible to accommodate different application<br/>
		/// needs and, wherever possible, to leverage existing system resources to minimize system costs.<br/>
		/// Xilinx FPGAs are configured by loading design-specific configuration data, in the form of a<br/>
		/// bitstream file, into the internal memory of the hw_device. The hw_cfgmem defines a flash<br/>
		/// memory device used for configuring and booting the Xilinx FPGA device. Once the hw_cfgmem<br/>
		/// object is created, and associated with the hw_device, the configuration memory can be<br/>
		/// programmed with the bitstream and other data using the program_hw_cfgmem command.<br/>
		/// The hw_cfgmem object is associated with the specified hw_device object through the<br/>
		/// PROGRAM.HW_CFGMEM property on the device object. Use the get_hw_cfgmems command<br/>
		/// to work with the hw_cfgmem object, or use the get_property command to obtain the object<br/>
		/// from the hw_device:<br/>
		/// get_property PROGRAM.HW_CFGMEM [current_hw_device]<br/>
		/// TIP: When creating a new hw_cfgmem object, you can also associate the object with a Tcl variable as<br/>
		/// shown in the example below. By referring to the variable, you can set properties on the object, and use the<br/>
		/// object with other Tcl commands like program_hw_cfgmem or readback_hw_cfgmem.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns the created hw_cfgmem object, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 291<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_device">(Required) hw_device object with which to associate hw_cfgmem object</param>
		/// <param name="mem_device">(Required) name of flash memory device as returned by get_cfgmem_parts</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_hw_cfgmem(String hw_device, TCLObject mem_device, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_hw_cfgmem -hw_device <arg> [-quiet] [-verbose] <mem_device>
			_tcl.Entry(_builder.create_hw_cfgmem(hw_device, mem_device, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a hw_device (jtag chain) on an open target<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_hw_device [-idcode &lt;arg&gt;] [-irlength &lt;arg&gt;] [-mask &lt;arg&gt;] [-part &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// The Vivado hardware manager supports programming of hardware devices through the use of<br/>
		/// Serial Vector Format (SVF) files. SVF files are ASCII files that contain both programming<br/>
		/// instructions and configuration data. These files are used by ATE machines and embedded<br/>
		/// controllers to perform boundary-scan operations. The SVF file captures the JTAG commands<br/>
		/// needed to program the bitstream directly into a Xilinx device, or indirectly into a flash memory<br/>
		/// device. The SVF file can be written using the write_hw_svf command, or applied to an open<br/>
		/// hw_target through the execute_hw_svf command. Refer to the Vivado Design Suite User Guide:<br/>
		/// Programming and Debugging (UG908) for more information.<br/>
		/// The specific process for creating the hw_svf file is:<br/>
		/// 1. Create an SVF target using create_hw_target.<br/>
		/// 2. Open the SVF target.<br/>
		/// 3. Create one or more devices on the SVF target using create_hw_device.<br/>
		/// 4. Program the devices using commands like program_hw_devices.<br/>
		/// 5. Write the SVF file of operation commands using write_hw_svf.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The create_hw_device command creates a hw_device object on an open SVF target, adding it<br/>
		/// to the JTAG chain. This device can be queried and programmed like other hw_targets using<br/>
		/// commands like get_hw_devices and program_hw_devices.<br/>
		/// You can create both Xilinx devices and user-defined parts to add to the JTAG chain on the open<br/>
		/// SVF hw_target. For Xilinx devices, simply specify a recognized part number and the Vivado tool<br/>
		/// will define it with the appropriate details. For user-defined parts you must specify the JTAG ID<br/>
		/// code, IR length, and mask details using the appropriate options. User-defined parts are added as<br/>
		/// space-holder devices to the JTAG chain as on the SVF hw_target. You can get the user-part with<br/>
		/// get_hw_devices command, and query the properties of the part with report_property,<br/>
		/// but you cannot program user-parts.<br/>
		/// IMPORTANT! You should create all the devices to define the JTAG chain for the SVF target, before<br/>
		/// performing any operations on the JTAG chain. If you mix create_hw_device commands with<br/>
		/// programming commands the JTAG chain referenced in the SVF file will be improperly defined and will not<br/>
		/// work during execute_hw_svf.<br/>
		/// After creating the hw_device on the SVF target, you can exercise the device with supported<br/>
		/// operations such as associating a bitstream file (.bit) and programming the device:<br/>
		/// set_property PROGRAM.FILE {C:/Data/design.bit} [current_hw_device]<br/>
		/// program_hw_devices [current_hw_device]<br/>
		/// The create_hw_device command returns nothing if successful, and returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates an SVF target, opens that target, and creates a new hw_device on<br/>
		/// the target:<br/>
		/// create_hw_target my_svf_target<br/>
		/// open_hw_target<br/>
		/// create_hw_device -part xc7k325t<br/>
		/// This example demonstrates the correct order of creating multiple devices on an SVF target. An<br/>
		/// SVF target is created and opened, then a Xilinx device, a user part, and a second Xilinx device are<br/>
		/// created on the current target. The bitstream properties are defined for the two Xilinx devices, the<br/>
		/// devices are programmed, and an SVF file is written:<br/>
		/// open_hw<br/>
		/// connect_hw_server<br/>
		/// create_hw_target my_svf_target<br/>
		/// open_hw_target<br/>
		/// create_hw_device -part xc7k325t<br/>
		/// create_hw_device -idcode 01234567 -irlength 8 -mask ffffffff -part<br/>
		/// userPart1<br/>
		/// create_hw_device -part xcku9p<br/>
		/// set_property PROGRAM.FILE {C:/Data/k7_design.bit} [lindex [get_hw_devices]<br/>
		/// 0]<br/>
		/// set_property PROGRAM.FILE {C:/Data/ku_design.bit} [lindex [get_hw_devices]<br/>
		/// 2]<br/>
		/// program_hw_devices [lindex [get_hw_devices] 0]<br/>
		/// program_hw_devices [lindex [get_hw_devices] 2]<br/>
		/// write_hw_svf C:/Data/myDesign.svf<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 294<br/>
		/// </para>
		/// </summary>
		/// <param name="idcode">(Optional) hexadecimal device id code</param>
		/// <param name="irlength">(Optional) decimal device ir length</param>
		/// <param name="mask">(Optional) hexadecimal device mask value</param>
		/// <param name="part">(Optional) part type of device to create</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_hw_device(String idcode = null, String irlength = null, String mask = null, String part = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_hw_device [-idcode <arg>] [-irlength <arg>] [-mask <arg>] [-part <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_hw_device(idcode, irlength, mask, part, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create hardware probe object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_hw_probe [-no_gui_update] [-map &lt;arg&gt;] [-quiet] [-verbose] &lt;name&gt; &lt;core&gt;
		/// <br/>
		/// <para>
		/// This command creates a new user-defined probe on the specified ILA core to define triggers and<br/>
		/// view data in the Vivado Logic Analyzer. The new probe can combine specific bit values of existing<br/>
		/// probes to simplify or clarify the data presented in the waveform viewer. Captured data samples<br/>
		/// from the user-defined probe can be reported with the list_hw_samples command.<br/>
		/// User-defined probes can map bit values from a single physical probe on the ILA core, or can<br/>
		/// combine bit values from multiple physical probes onto a single user-defined probe. Probes that<br/>
		/// map bits from a single probe can be used to create triggers and view data. Probes that combine<br/>
		/// bits from multiple physical probes can only be used for viewing data in the Vivado Logic Analyzer.<br/>
		/// You can delete user-defined probes with the delete_hw_probe command.<br/>
		/// The create_hw_probe command returns the user-defined probe name when successful, or<br/>
		/// returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example maps bits from multiple physical probes onto a new user-defined probe<br/>
		/// on the specified ILA core:<br/>
		/// create_hw_probe -map {0011 probe5[3:0] probe8 probe9} myProbeAR[9:0]<br/>
		/// hw_ila_1<br/>
		/// TIP: The -map option combines 10 bits onto the new probe, so the probe name specifies a matching port<br/>
		/// width.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example creates a hw_probe with copies of the most-significant bit to sign-extend<br/>
		/// a 30-bit signal to align it with other 32-bit signed signals:<br/>
		/// create_hw_probe -map {probe0[29] probe0[29] probe0[29:0]} \<br/>
		/// mySignExtendedProbe[31:0] [get_hw_ilas hw_ila_1]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 297<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name of new object. Bus probes have range appended.</param>
		/// <param name="core">(Required) Associated hardware ILA core object.</param>
		/// <param name="no_gui_update">(Optional) Defer GUI update.</param>
		/// <param name="map">(Optional) Declaration of bits. Default: 0</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>New hardware probe object.</returns>
		public TTCL create_hw_probe(TCLObject name, TCLObject core, bool? no_gui_update = null, String map = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_hw_probe [-no_gui_update] [-map <arg>] [-quiet] [-verbose] <name> <core>
			_tcl.Entry(_builder.create_hw_probe(name, core, no_gui_update, map, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new link between hardware RX and TX endpoints. There must be at least one hardware<br/>
		/// TX or RX endpoint specified. If one is missing, the endpoint will be treated as Unknown. The<br/>
		/// unknown endpoint can be renamed in a link property.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_hw_sio_link [-description &lt;arg&gt;] [-quiet] [-verbose] [&lt;hw_sio_rx&gt;] [&lt;hw_sio_tx&gt;]
		/// <br/>
		/// <para>
		/// Define a communication links between transmitter (TX) and receiver (RX) objects on the GTs of<br/>
		/// the IBERT debug core implemented on the current hardware device.<br/>
		/// Vivado Serial I/O analyzer is a link-based analyzer, which lets you link between any transmitter<br/>
		/// and receiver within the IBERT design. The links define the communication paths and protocols<br/>
		/// between transmitters and receivers of the GigaBit transceivers on the device. You can configure<br/>
		/// the links by using the set_property command to specify property values on the link object.<br/>
		/// Refer to the Vivado Design Suite User Guide: Programming and Debugging (UG908) for more<br/>
		/// information on configuring links.<br/>
		/// This command returns the created hw_sio_link object, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 300<br/>
		/// </para>
		/// </summary>
		/// <param name="description">(Optional) Description of link. Default: Link object name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_sio_rx">(Optional) RX endpoint. Default: None</param>
		/// <param name="hw_sio_tx">(Optional) TX endpoint. Default: None</param>
		/// <returns>The new hardware SIO link</returns>
		public TTCL create_hw_sio_link(String description = null, bool? quiet = null, bool? verbose = null, TCLObject hw_sio_rx = null, TCLObject hw_sio_tx = null)
		{
			// TCL Syntax: create_hw_sio_link [-description <arg>] [-quiet] [-verbose] [<hw_sio_rx>] [<hw_sio_tx>]
			_tcl.Entry(_builder.create_hw_sio_link(description, quiet, verbose, hw_sio_rx, hw_sio_tx));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new hardware SIO link group.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_hw_sio_linkgroup [-description &lt;arg&gt;] [-quiet] [-verbose] &lt;hw_sio_links&gt;
		/// <br/>
		/// <para>
		/// Create a new group to associate the specified TX to RX communication links on the IBERT debug<br/>
		/// core implemented on the current device.<br/>
		/// Vivado Serial I/O analyzer is a link-based analyzer. The links define the communication paths and<br/>
		/// protocols between transmitters and receivers of the GigaBit transceivers on the device. Link<br/>
		/// groups, or hw_sio_linkgroup objects, let you associate links into related groups, to collectively<br/>
		/// configure properties and run scans.<br/>
		/// This command returns the name of the linkgroup created, or returns an error if the command<br/>
		/// fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 303<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_sio_links">(Required) hardware SIO links</param>
		/// <param name="description">(Optional) Description of link group. Default: Link group object name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The new hardware SIO link group</returns>
		public TTCL create_hw_sio_linkgroup(TCLObject hw_sio_links, String description = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_hw_sio_linkgroup [-description <arg>] [-quiet] [-verbose] <hw_sio_links>
			_tcl.Entry(_builder.create_hw_sio_linkgroup(hw_sio_links, description, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new hardware SIO scan. If a Link object is passed in, it must have a RX Endpoint object.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_hw_sio_scan [-description &lt;arg&gt;] [-link_settings &lt;arg&gt;] [-quiet] [-verbose] &lt;scan_type&gt; &lt;hw_sio_object&gt;
		/// <br/>
		/// <para>
		/// Create a serial I/O analyzer scan object for the specified communication link on the IBERT debug<br/>
		/// core.<br/>
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the<br/>
		/// specialized Eye Scan hardware of Xilinx UltraScale devices or 7 series FPGAs. The Vivado serial<br/>
		/// I/O analyzer feature lets you to create, run, and save link scans.<br/>
		/// This command creates and returns a link scan object that you can use with the<br/>
		/// run_hw_sio_scan command to run analysis on the specified links, or GT receivers. You can<br/>
		/// also save the scan to disk using the write_hw_sio_scan command.<br/>
		/// You can remove the created scan object using remove_hw_sio_scan.<br/>
		/// This command returns the hw_sio_scan object, or returns an error if the command fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 305<br/>
		/// </para>
		/// </summary>
		/// <param name="scan_type">(Required) Scan Type Options: 1d_bathtub, 2d_full_eye</param>
		/// <param name="hw_sio_object">(Required) RX endpoint or Link object to perform scan on.</param>
		/// <param name="description">(Optional) Description of scan Default: Scan object name</param>
		/// <param name="link_settings">
		/// <para>
		/// (Optional)<br/>
		/// List of Link properties and values to set before running the<br/>
		/// scan. Default: None<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The new hardware SIO scan</returns>
		public TTCL create_hw_sio_scan(TCLObject scan_type, TCLObject hw_sio_object, String description = null, String link_settings = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_hw_sio_scan [-description <arg>] [-link_settings <arg>] [-quiet] [-verbose] <scan_type> <hw_sio_object>
			_tcl.Entry(_builder.create_hw_sio_scan(scan_type, hw_sio_object, description, link_settings, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a new hardware SIO sweep. If a Link object is passed in, it must have a RX Endpoint<br/>
		/// object.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_hw_sio_sweep [-description &lt;arg&gt;] [-iteration_settings &lt;arg&gt;] [-quiet] [-verbose] &lt;scan_type&gt; [&lt;hw_sio_link&gt;]
		/// <br/>
		/// <para>
		/// Create a serial I/O analyzer link sweep object to run multiple scans across a range of values.<br/>
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the<br/>
		/// specialized features of Xilinx® UltraScale™ devices or 7 series FPGAs. It can also be helpful to run<br/>
		/// multiple scans on a the link with different configuration settings for the GTs. This can help you<br/>
		/// determine which settings are best for your design. The Vivado® serial I/O analyzer feature<br/>
		/// enables you to define, run, and save link sweeps, or collections of link scans run across a range of<br/>
		/// values.<br/>
		/// This command creates and returns a link sweep object that you can use with the<br/>
		/// run_hw_sio_sweep command to run analysis on the specified links, or GT receivers. You can<br/>
		/// also save the sweep scan to disk using the write_hw_sio_sweep command.<br/>
		/// You can remove the created sweep object using remove_hw_sio_sweep.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns the hw_sio_sweep object, or returns an error if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 308<br/>
		/// </para>
		/// </summary>
		/// <param name="scan_type">(Required) Sweep Type Options: 1d_bathtub, 2d_full_eye</param>
		/// <param name="description">(Optional) Description of sweep Default: Sweep object name</param>
		/// <param name="iteration_settings">
		/// <para>
		/// (Optional)<br/>
		/// List of LINK_SETTINGS for each scan to set before running<br/>
		/// the sweep. Default: None<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_sio_link">(Optional) Link object to perform sweep on. Default: None</param>
		/// <returns>The new hardware SIO sweep</returns>
		public TTCL create_hw_sio_sweep(TCLObject scan_type, String description = null, String iteration_settings = null, bool? quiet = null, bool? verbose = null, TCLObject hw_sio_link = null)
		{
			// TCL Syntax: create_hw_sio_sweep [-description <arg>] [-iteration_settings <arg>] [-quiet] [-verbose] <scan_type> [<hw_sio_link>]
			_tcl.Entry(_builder.create_hw_sio_sweep(scan_type, description, iteration_settings, quiet, verbose, hw_sio_link));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create a hw_target (jtag chain) and set its name<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_hw_target [-copy &lt;arg&gt;] [-quiet] [-verbose] &lt;target_name&gt;
		/// <br/>
		/// <para>
		/// The Vivado hardware manager supports programming of hardware devices through the use of<br/>
		/// Serial Vector Format (SVF) files. SVF files are ASCII files that contain both programming<br/>
		/// instructions and configuration data. These files are used by ATE machines and embedded<br/>
		/// controllers to perform boundary-scan operations. The SVF file captures the JTAG commands<br/>
		/// needed to program the bitstream directly into a Xilinx device, or indirectly into a flash memory<br/>
		/// device. The SVF file can be written using the write_hw_svf command, or applied to an open<br/>
		/// hw_target through the execute_hw_svf command. Refer to the Vivado Design Suite User Guide:<br/>
		/// Programming and Debugging (UG908) for more information.<br/>
		/// The specific process for creating the hw_svf file is:<br/>
		/// 1. Create an SVF target using create_hw_target.<br/>
		/// 2. Open the SVF target.<br/>
		/// 3. Create one or more devices on the SVF target using create_hw_device.<br/>
		/// 4. Program the devices using commands like program_hw_devices.<br/>
		/// 5. Write the SVF file of operation commands using write_hw_svf.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The create_hw_target command creates an SVF hw_target object on the current hw_server<br/>
		/// that can be used as a platform for programming devices, and exporting the programming<br/>
		/// commands in an SVF file. The SVF target, is a hw_target object that can be queried and managed<br/>
		/// like other hw_targets using commands like get_hw_targets and current_hw_target.<br/>
		/// Note: When using the SVF flow, Xilinx recommends that you connect to a local hw_server on your system,<br/>
		/// as the SVF target does not require connection to an actual hardware board or device.<br/>
		/// SVF hw_targets can be identified by the boolean IS_SVF property that can be returned by<br/>
		/// get_property or report_property commands. This property is TRUE for SVF targets.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates a SVF hw_target object that is a copy of the specified hw_target:<br/>
		/// create_hw_target -copy [get_hw_targets *210203327996A] svfTarget<br/>
		/// The following example gets the currently defined SVF hw_target objects:<br/>
		/// get_hw_targets -filter {IS_SVF}<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example shows all of the steps needed for the SVF flow. First open the Vivado<br/>
		/// hardware manager and connect to a local hw_server; create and open an SVF hw_target; add a<br/>
		/// hw_device and program the bitstream into this device; and write the SVF file capturing the<br/>
		/// programming commands for the device:<br/>
		/// open_hw<br/>
		/// connect_hw_server<br/>
		/// create_hw_target my_svf_target<br/>
		/// open_hw_target<br/>
		/// create_hw_device -part xc7k325t<br/>
		/// set_property PROGRAM.FILE {C:/Data/k7_design.bit} [current_hw_device]<br/>
		/// program_hw_devices [current_hw_device]<br/>
		/// write_hw_svf my_xc7k325t.svf<br/>
		/// close_hw_target<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 311<br/>
		/// </para>
		/// </summary>
		/// <param name="target_name">(Required) name of hardware target to create</param>
		/// <param name="copy">(Optional) hardware target copy Default: copy of existing target</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>hardware targets</returns>
		public TTCL create_hw_target(TCLObject target_name, String copy = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_hw_target [-copy <arg>] [-quiet] [-verbose] <target_name>
			_tcl.Entry(_builder.create_hw_target(target_name, copy, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get or set the current hardware cfgmem<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_hw_cfgmem [-hw_device &lt;args&gt;] [-quiet] [-verbose] [&lt;hw_cfgmem&gt;]
		/// <br/>
		/// <para>
		/// Set or return the current hardware cfgmem object.<br/>
		/// The process whereby the design specific data is loaded or programmed into the Xilinx® FPGA is<br/>
		/// called configuration. The create_hw_cfgmem command defines a flash memory device used<br/>
		/// for configuring and booting the FPGA device.<br/>
		/// When a new hw_cfgmem object is created, it becomes the current hw_cfgmem object. You can<br/>
		/// use the current_hw_cfgmem to return the current hw_cfgmem object, or you can specify a<br/>
		/// hw_cfgmem object, as returned by get_hw_cfgmems, to change the current object.<br/>
		/// After the hw_cfgmem object is created, and associated with the hw_device, the configuration<br/>
		/// memory can be programmed with the bitstream and other data from a memory configuration file<br/>
		/// created with the write_cfgmem command.<br/>
		/// The hw_cfgmem object is programmed using the program_hw_cfgmem command.<br/>
		/// This command returns the current hardware cfgmem as an object, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 392<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_device">(Optional) list of hardware devices</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_cfgmem">(Optional) list of hardware cfgmems Default: current hardware cfgmem</param>
		/// <returns>hardware cfgmem</returns>
		public TTCL current_hw_cfgmem(TCLParameterList hw_device = null, bool? quiet = null, bool? verbose = null, TCLObject hw_cfgmem = null)
		{
			// TCL Syntax: current_hw_cfgmem [-hw_device <args>] [-quiet] [-verbose] [<hw_cfgmem>]
			_tcl.Entry(_builder.current_hw_cfgmem(hw_device, quiet, verbose, hw_cfgmem));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get or set the current hardware device<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_hw_device [-quiet] [-verbose] [&lt;hw_device&gt;]
		/// <br/>
		/// <para>
		/// Set or return the current Xilinx FPGA targeted by the Hardware Manager in the Vivado Design<br/>
		/// Suite for programming and debug.<br/>
		/// The hardware target is a system board containing a JTAG chain of one or more Xilinx devices that<br/>
		/// you can program with a bitstream file, or use to debug your design. Connections between<br/>
		/// hardware targets on the system board and the Vivado Design Suite are managed by the<br/>
		/// hw_server application, and the connect_hw_server command. Refer to Vivado Design Suite<br/>
		/// User Guide: Programming and Debugging (UG908) for a list of supported JTAG download cables<br/>
		/// and devices.<br/>
		/// Each hardware target can have one or more Xilinx devices to program, or to use for debugging<br/>
		/// purposes. The current device is specified or returned by the current_hw_device command.<br/>
		/// To access a Xilinx FPGA through the Hardware Manager, you must use the following Tcl<br/>
		/// command sequence:<br/>
		/// 1. open_hw - Opens the Hardware Manager in the Vivado Design Suite.<br/>
		/// 2. connect_hw_server - Makes a connection to a local or remote Xilinx hardware server<br/>
		/// application.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// 3. current_hw_target - Defines the hardware target of the connected server.<br/>
		/// 4. open_hw_target - Opens a connection to the hardware target.<br/>
		/// 5. current_hw_device - Specifies the Xilinx FPGA to use for programming and debugging.<br/>
		/// After connecting to the appropriate hardware device, you can program the device with a<br/>
		/// bitstream file using the program_hw_device command, and debug the device using any of a<br/>
		/// number of Hardware Manager Tcl commands. To interactively debug the device open the<br/>
		/// Hardware Manager in the Vivado Design Suite IDE.<br/>
		/// IMPORTANT! You can use the current_hw_server , current_hw_target , and<br/>
		/// current_hw_device commands to set the hardware for programming and debugging the design. You<br/>
		/// should exercise care when using these commands to insure that the current server, target, and device are in<br/>
		/// sync. The current device should be found on the current target, which should be found on the current<br/>
		/// server.<br/>
		/// This command returns the current hardware device as an object, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 394<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_device">(Optional) hardware device to set as current; optional</param>
		/// <returns>hardware device</returns>
		public TTCL current_hw_device(bool? quiet = null, bool? verbose = null, TCLObject hw_device = null)
		{
			// TCL Syntax: current_hw_device [-quiet] [-verbose] [<hw_device>]
			_tcl.Entry(_builder.current_hw_device(quiet, verbose, hw_device));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get or set the current hardware ILA<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_hw_ila [-quiet] [-verbose] [&lt;hw_ila&gt;]
		/// <br/>
		/// <para>
		/// Set or return the current hardware ILA debug core targeted by the Hardware Manager in the<br/>
		/// Vivado Design Suite for programming and debug.<br/>
		/// The Integrated Logic Analyzer (ILA) debug core lets you perform in-system debug of<br/>
		/// implemented designs, or design bitstreams, on a programmed Xilinx FPGA. The ILA core includes<br/>
		/// many advanced features of modern logic analyzers, including boolean trigger equations, and edge<br/>
		/// transition triggers. You can use the ILA core to probe specific signals of the design, to trigger on<br/>
		/// programmed hardware events, and capture data from the Xilinx FPGA in real-time. Refer to<br/>
		/// LogiCORE IP Integrated Logic Analyzer (PG172) for details of the ILA core.<br/>
		/// ILA debug cores can be added to a design instantiating an ILA core from the IP catalog into the<br/>
		/// RTL design, or using the create_debug_core command to add the ILA core to the synthesized<br/>
		/// netlist. Refer to Vivado Design Suite User Guide: Programming and Debugging (UG908) for more<br/>
		/// information on adding ILA debug cores to the design.<br/>
		/// After generating a bitstream from the design, and programming the device with the<br/>
		/// program_hw_devices command, the ILA debug cores in the design are accessible from the<br/>
		/// Hardware Manager using the get_hw_ilas command. The debug probes assigned to the ILA<br/>
		/// debug cores in the design can be returned with the get_hw_probes command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns the current hardware ILA core as an object, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 397<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_ila">(Optional) hardware ILA</param>
		/// <returns>hardware ILA</returns>
		public TTCL current_hw_ila(bool? quiet = null, bool? verbose = null, TCLObject hw_ila = null)
		{
			// TCL Syntax: current_hw_ila [-quiet] [-verbose] [<hw_ila>]
			_tcl.Entry(_builder.current_hw_ila(quiet, verbose, hw_ila));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get or set the current hardware ILA data<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_hw_ila_data [-quiet] [-verbose] [&lt;hw_ila_data&gt;]
		/// <br/>
		/// <para>
		/// Set or return the current ILA debug core data object.<br/>
		/// The ILA data object is created in the Vivado logic analyzer using the upload_hw_ila_data<br/>
		/// command, or the read_hw_ila_data command. By default, the current hw_ila_data object is<br/>
		/// the latest one created by the Vivado logic analyzer. The current_hw_ila_data command can<br/>
		/// be used to change that object.<br/>
		/// The ILA debug core captures sample data in real-time as the hardware device runs, based on the<br/>
		/// event triggers or capture conditions defined on the hw_ila object. The hw_ila object triggers on<br/>
		/// the hw_device are armed by the run_hw_ila command.<br/>
		/// The ILA data object can be displayed in the waveform window of the Vivado tools logic analyzer<br/>
		/// using the display_hw_ila_data command. You can also write the ILA data to disk with the<br/>
		/// write_hw_ila_data command to save the ILA debug information for later user and analysis.<br/>
		/// This command returns the captured hardware ILA debug core data as an object, or returns an<br/>
		/// error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 399<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_ila_data">(Optional) hardware ILA data</param>
		/// <returns>hardware ILA data</returns>
		public TTCL current_hw_ila_data(bool? quiet = null, bool? verbose = null, TCLObject hw_ila_data = null)
		{
			// TCL Syntax: current_hw_ila_data [-quiet] [-verbose] [<hw_ila_data>]
			_tcl.Entry(_builder.current_hw_ila_data(quiet, verbose, hw_ila_data));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get or set the current hardware server<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_hw_server [-quiet] [-verbose] [&lt;hw_server&gt;]
		/// <br/>
		/// <para>
		/// Defines the current hardware server from the list of hardware servers that are connected to the<br/>
		/// Vivado Design Suite, or returns the currently connected hardware server object.<br/>
		/// Hardware servers are instances of the Xilinx hardware server (hw_server) application running<br/>
		/// remotely, or on the local machine. The hardware server manages connections to a hardware<br/>
		/// target, such as a hardware board containing a JTAG chain of one or more Xilinx devices to be<br/>
		/// used for programming and debugging your FPGA design.<br/>
		/// Hardware servers are connected to the Vivado Design Suite with the connect_hw_server<br/>
		/// command. The current hardware server, and the current hardware target and device are the<br/>
		/// focus of most Hardware Manager Tcl commands. The current target and device can be defined<br/>
		/// using the current_hw_target and current_hw_device commands.<br/>
		/// Note: There is usually a current hw_server defined, either the last connected hardware server, or one you<br/>
		/// have defined with this command. However, if you disconnect the current hardware server, you will need to<br/>
		/// define a new current hw_server object.<br/>
		/// You can get a list of connected hardware servers using the get_hw_servers command. You<br/>
		/// can get a list of available hardware targets and devices using the get_hw_targets and<br/>
		/// get_hw_devices commands respectively.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns a hw_server object. If the &lt;hw_server&gt; is specified as part of the<br/>
		/// current_hw_server command, the specified server is defined as the current hardware server<br/>
		/// and that object is returned. If no server is specified, the current_hw_server command<br/>
		/// returns the current hardware server object.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 401<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_server">(Optional) hardware server</param>
		/// <returns>hardware server</returns>
		public TTCL current_hw_server(bool? quiet = null, bool? verbose = null, TCLObject hw_server = null)
		{
			// TCL Syntax: current_hw_server [-quiet] [-verbose] [<hw_server>]
			_tcl.Entry(_builder.current_hw_server(quiet, verbose, hw_server));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get or set the current hardware target<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: current_hw_target [-quiet] [-verbose] [&lt;hw_target&gt;]
		/// <br/>
		/// <para>
		/// After opening the Hardware Manager in the Vivado Design Suite, and connecting to the Xilinx<br/>
		/// hardware server (hw_server) using the connect_hw_server command, you will need to set<br/>
		/// the hardware target. This command sets or returns the current hardware target.<br/>
		/// The hardware target is a system board containing a JTAG chain of one or more Xilinx devices that<br/>
		/// you can program with a bitstream file, or use to debug your design. Connections between<br/>
		/// hardware targets on the system board and the Vivado Design Suite are managed by the<br/>
		/// hw_server object. Refer to Vivado Design Suite User Guide: Programming and Debugging (UG908)<br/>
		/// for a list of supported JTAG download cables and devices.<br/>
		/// The available hardware targets are defined when the Vivado tools Hardware Manager is<br/>
		/// connected to a hw_server. You can return a list of the available hardware targets using the<br/>
		/// get_hw_targets command, and define the current hardware target using the<br/>
		/// current_hw_target command.<br/>
		/// If the &lt;hw_target&gt; is specified as part of the current_hw_target command, the specified<br/>
		/// target is defined as the current hardware target and that object is returned. If no hardware target<br/>
		/// is specified, the current_hw_target command returns the current hardware target object.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Each hardware target can have one or more Xilinx devices to program, or to use for debugging<br/>
		/// purposes. The current device is specified or returned by the current_hw_device command.<br/>
		/// After specifying the current hardware target, you can open the connection through the hardware<br/>
		/// target, to the Xilinx device using the open _hw_target command.<br/>
		/// IMPORTANT! You can use the current_hw_server , current_hw_target , and<br/>
		/// current_hw_device commands to set the hardware for programming and debugging the design. You<br/>
		/// should exercise care when using these commands to insure that the current server, target, and device are in<br/>
		/// sync. The current device should be found on the current target, which should be found on the current<br/>
		/// server.<br/>
		/// This command returns the current hardware target as an object, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 403<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_target">(Optional) hardware target</param>
		/// <returns>hardware target</returns>
		public TTCL current_hw_target(bool? quiet = null, bool? verbose = null, TCLObject hw_target = null)
		{
			// TCL Syntax: current_hw_target [-quiet] [-verbose] [<hw_target>]
			_tcl.Entry(_builder.current_hw_target(quiet, verbose, hw_target));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Delete hardware AXI Transaction objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_hw_axi_txn [-quiet] [-verbose] &lt;hw_axi_txns&gt;...
		/// <br/>
		/// <para>
		/// This command deletes the named AXI transaction objects, hw_axi_txn, from the specified hw_axi<br/>
		/// objects.<br/>
		/// The create_hw_axi_txn command cannot create an object of the same name as an existing<br/>
		/// object. Use this command to delete any existing objects prior to creating new AXI transaction<br/>
		/// objects.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 445<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_axi_txns">(Required) hardware AXI Transaction object to delete</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_hw_axi_txn(TCLObjectList hw_axi_txns, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_hw_axi_txn [-quiet] [-verbose] <hw_axi_txns>...
			_tcl.Entry(_builder.delete_hw_axi_txn(hw_axi_txns, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Removes the HW Bitstream object from a list of hardware devices.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_hw_bitstream [-of_objects &lt;args&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This command deletes the hw_bitstream object from the specified hw_device objects.<br/>
		/// This clears the PROGRAM.HW_BITSTREAM and PROGRAM.FILE properties on the hw_device<br/>
		/// objects, and deletes the hw_bitstream object.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 447<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_bitstream' objects of these types: 'hw_device'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>hardware devices</returns>
		public TTCL delete_hw_bitstream(TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_hw_bitstream [-of_objects <args>] [-quiet] [-verbose]
			_tcl.Entry(_builder.delete_hw_bitstream(of_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Removes hw_cfgmem object from memory<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_hw_cfgmem [-quiet] [-verbose] &lt;cfgmem&gt;
		/// <br/>
		/// <para>
		/// Removes the specified hw_cfgmem object from the current hw_device.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 449<br/>
		/// </para>
		/// </summary>
		/// <param name="cfgmem">(Required) Valid hw_cfgmem object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_hw_cfgmem(TCLObject cfgmem, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_hw_cfgmem [-quiet] [-verbose] <cfgmem>
			_tcl.Entry(_builder.delete_hw_cfgmem(cfgmem, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Delete hardware probe objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_hw_probe [-quiet] [-verbose] &lt;hw_probes&gt;...
		/// <br/>
		/// <para>
		/// Delete a user-defined probe from the current hw_ila. The user-define probe must be created by<br/>
		/// the create_hw_probe command.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example deletes a user-defined hw_probe object on the current ILA core:<br/>
		/// delete_hw_probe [get_hw_probe probeAR]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 451<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_probes">(Required) hardware probe objects to delete</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_hw_probe(TCLObjectList hw_probes, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_hw_probe [-quiet] [-verbose] <hw_probes>...
			_tcl.Entry(_builder.delete_hw_probe(hw_probes, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Delete a hw_target<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: delete_hw_target [-quiet] [-verbose] [&lt;target_object&gt;]
		/// <br/>
		/// <para>
		/// This command deletes a virtual hardware target from the current_hw_server.<br/>
		/// The hw_target object must be a virtual target created by the create_hw_target command, or<br/>
		/// an error will be returned.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example deletes the specified hw_target:<br/>
		/// delete_hw_target [lindex [get_hw_targets] 1]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 453<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="target_object">(Optional) hardware target object to delete Default: current_hw_target</param>
		public TTCL delete_hw_target(bool? quiet = null, bool? verbose = null, TCLObject target_object = null)
		{
			// TCL Syntax: delete_hw_target [-quiet] [-verbose] [<target_object>]
			_tcl.Entry(_builder.delete_hw_target(quiet, verbose, target_object));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Automatically detect links between RX and TX endpoints. Create a new link group to contain the<br/>
		/// links.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: detect_hw_sio_links [-force] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Automatically detects existing or previously defined communication pathways between GT<br/>
		/// transmitters and receivers that are defined on the open hardware target.<br/>
		/// You can use this command if you change board connections while the serial I/O analyzer is<br/>
		/// running. The detection algorithm uses changing transmit patterns and detects links on received<br/>
		/// patterns to determine how GTs are connected to one another on the open hardware target.<br/>
		/// A transmitter or receiver of an individual GT on the IBERT debug core can only be used in one<br/>
		/// hw_sio_link at a time, so the command will not check GTs that are used in existing links. The -<br/>
		/// force option lets you clear all existing links before scanning the open hardware target to check<br/>
		/// all GTs.<br/>
		/// The detect_hw_sio_links command defines the found links, and creates a link group to<br/>
		/// associate the new links.<br/>
		/// This command returns the number of links found and the created hw_sio_linkgroup object, or<br/>
		/// returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 488<br/>
		/// </para>
		/// </summary>
		/// <param name="force">(Optional) Remove all existing links before detecting links</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>A new hardware SIO link group of found links</returns>
		public TTCL detect_hw_sio_links(bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: detect_hw_sio_links [-force] [-quiet] [-verbose]
			_tcl.Entry(_builder.detect_hw_sio_links(force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Close a connection to a hardware server<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: disconnect_hw_server [-quiet] [-verbose] [&lt;hw_server&gt;]
		/// <br/>
		/// <para>
		/// Disconnect the current or specified Vivado tools hardware server from the Vivado Design Suite.<br/>
		/// The current hardware server is either the last connected hardware server, or one you have<br/>
		/// manually defined with the current_hw_server command. If you disconnect the current<br/>
		/// hardware server, there will be no defined current hardware server until you define a new current<br/>
		/// hw_server object.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 496<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_server">(Optional) hardware server Default: current hardware server</param>
		public TTCL disconnect_hw_server(bool? quiet = null, bool? verbose = null, TCLObject hw_server = null)
		{
			// TCL Syntax: disconnect_hw_server [-quiet] [-verbose] [<hw_server>]
			_tcl.Entry(_builder.disconnect_hw_server(quiet, verbose, hw_server));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Display hardware ILA data in viewer<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: display_hw_ila_data [-wcfg &lt;arg&gt;] [-reset] [-quiet] [-verbose] [&lt;hw_ila_data&gt;...]
		/// <br/>
		/// <para>
		/// This command is intended for use with the graphical user interface of the Vivado Design Suite<br/>
		/// logic analyzer feature. It displays the specified ILA debug core data object in a wave config<br/>
		/// window of the Vivado logic analyzer.<br/>
		/// The ILA debug sample data is acquired from a running device using the upload_hw_ila_data<br/>
		/// command. This creates a hw_ila_data object that can be written to a file on disk using the<br/>
		/// write_hw_ila_data command. This command reads that ILA data file.<br/>
		/// The display characteristics of the ILA debug core in the waveform window are determined by the<br/>
		/// Wave Config file. The Wave Config file contains just the list of wave objects (signals, dividers,<br/>
		/// groups, virtual buses) to display, and their display properties, plus markers.<br/>
		/// A wave configuration object is created in the Vivado logic analyzer with the<br/>
		/// create_wave_config command. A Wave Config file is written to disk by the use of the<br/>
		/// save_wave_config command, and can be opened with the open_wave_config command.<br/>
		/// The open_wave_config command opens a Wave Config file and maps it to the data source in<br/>
		/// the current simulation.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 501<br/>
		/// </para>
		/// </summary>
		/// <param name="wcfg">(Optional) Import alternate wave config file</param>
		/// <param name="reset">(Optional) Force reset wave config file to default configuration</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_ila_data">(Optional) List of hardware ILA data objects. Default: Current hardware ILA data</param>
		public TTCL display_hw_ila_data(String wcfg = null, bool? reset = null, bool? quiet = null, bool? verbose = null, TCLObjectList hw_ila_data = null)
		{
			// TCL Syntax: display_hw_ila_data [-wcfg <arg>] [-reset] [-quiet] [-verbose] [<hw_ila_data>...]
			_tcl.Entry(_builder.display_hw_ila_data(wcfg, reset, quiet, verbose, hw_ila_data));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Display an existing hardware SIO scan.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: display_hw_sio_scan [-quiet] [-verbose] &lt;hw_sio_scans&gt;
		/// <br/>
		/// <para>
		/// This command is intended for use with the graphical user interface of the Vivado Design Suite<br/>
		/// serial I/O analyzer feature. It displays the specified SIO scan data object, or objects, in a Scan<br/>
		/// Plots window of the Vivado IDE.<br/>
		/// The SIO scan data can be read from a file on disk using the read_hw_sio_scan command, or<br/>
		/// from a hw_sio_scan object created by the run_hw_sio_scan command. The type of plot<br/>
		/// displayed is determined by the &lt;scan_type&gt; of the hw_sio_scan object.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 503<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_sio_scans">(Required) hardware SIO scans</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL display_hw_sio_scan(TCLObject hw_sio_scans, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: display_hw_sio_scan [-quiet] [-verbose] <hw_sio_scans>
			_tcl.Entry(_builder.display_hw_sio_scan(hw_sio_scans, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Execute SVF file on current_hw_target<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: execute_hw_svf [-quiet] [-verbose] &lt;file_name&gt;
		/// <br/>
		/// <para>
		/// The Vivado hardware manager supports programming of hardware devices through the use of<br/>
		/// Serial Vector Format (SVF) files. SVF files are ASCII files that contain both programming<br/>
		/// instructions and configuration data. These files are used by ATE machines and embedded<br/>
		/// controllers to perform boundary-scan operations. The SVF file is an ASCII files that captures the<br/>
		/// JTAG commands needed to program the bitstream directly into a Xilinx device, or indirectly into a<br/>
		/// flash memory device. The SVF file can be written using the write_hw_svf command, or used<br/>
		/// to program a device through the execute_hw_svf command. Refer to the Vivado Design Suite<br/>
		/// User Guide: Programming and Debugging (UG908) for more information.<br/>
		/// The execute_hw_svf command converts the SVF commands into Vivado Tcl commands and<br/>
		/// executes them on the specified target. This process could take some time depending on how big<br/>
		/// the SVF file is. The command requires an open, current hw_target object, with a JTAG chain that<br/>
		/// matches the device chain specified in the SVF file.<br/>
		/// TIP: The execute_hw_svf command is not a general purpose SVF reader, and should only be used to<br/>
		/// read and execute SVF files written by the Vivado tools.<br/>
		/// This command returns a transcript of its process, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example executes the specified SVF command file in verbose mode to display all of<br/>
		/// the commands being run:<br/>
		/// open_hw_target {houdini26:3121/xilinx_tcf/Digilent/210203327996A}<br/>
		/// execute_hw_svf -verbose C:/Data/k7_design.svf<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 512<br/>
		/// </para>
		/// </summary>
		/// <param name="file_name">(Required) SVF filename</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL execute_hw_svf(TCLObject file_name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: execute_hw_svf [-quiet] [-verbose] <file_name>
			_tcl.Entry(_builder.execute_hw_svf(file_name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of cfgmem_parts available in the software<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_cfgmem_parts [-regexp] [-nocase] [-filter &lt;arg&gt;] [-of_objects &lt;args&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Get a list of configuration flash memory devices supported by the Vivado Design Suite or Vivado<br/>
		/// Lab Edition.<br/>
		/// Xilinx® FPGAs can be configured from an external nonvolatile memory device, or they can be<br/>
		/// configured by an external smart source, such as a microprocessor, DSP processor,<br/>
		/// microcontroller, PC, or board tester. The two configuration datapaths include a serial datapath<br/>
		/// that is used to minimize the device pin requirements for configuration, and a parallel 8-bit, 16-bit,<br/>
		/// or 32-bit datapath used for higher performance or link to industry-standard interfaces ideal for<br/>
		/// external data sources like processors, or x8- or x16-parallel flash memory.<br/>
		/// The process whereby the design specific data is loaded or programmed into the Xilinx FPGA is<br/>
		/// called configuration. The create_hw_cfgmem command defines a flash memory device used<br/>
		/// for configuring and booting the hardware device.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// After the hw_cfgmem object is created, and associated with the hw_device, the configuration<br/>
		/// memory can be programmed with the bitstream and other data from a memory configuration file<br/>
		/// created with the write_cfgmem command. The hw_cfgmem object is programmed using the<br/>
		/// program_hw_cfgmem command.<br/>
		/// The configuration memory part can be used to define the hardware configuration memory in the<br/>
		/// Hardware Manager of the Vivado Design Suite, to enable programming and debugging the design<br/>
		/// in the FPGA hardware. Use the create_hw_cfgmem command to define the configuration<br/>
		/// memory for use with the current hardware device.<br/>
		/// This command returns a list of cfgmem_part objects that match the specified search criteria, or<br/>
		/// returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 653<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'cfgmem_part' objects of these types: 'part hw_device'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'cfgmem_part' objects against patterns. Default: *</param>
		/// <returns>list of cfgmem_part objects</returns>
		public TTCL get_cfgmem_parts(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_cfgmem_parts [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_cfgmem_parts(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of hardware AXI transactions.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_axi_txns [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the read or write transactions for the specified JTAG to AXI Master core, hw_axi object.<br/>
		/// The JTAG to AXI Master is a customizable IP core that works as an AXI Master to drive AXI<br/>
		/// transactions and drive AXI signals that are internal to the hardware device. This IP can be used in<br/>
		/// Vivado® IP integrator or can be instantiated in HDL in a Vivado project.<br/>
		/// The JTAG-AXI core supports all memory-mapped AXI interfaces, except AXI4-Stream, and<br/>
		/// supports the AXI-Lite protocol. The AXI interface can be selected as a property of the core. The<br/>
		/// width of AXI data bus is customizable. This IP can drive any AXI4-Lite or Memory Mapped Slave<br/>
		/// directly, and can also be connected as the AXI Master to the interconnect. Run-time interaction<br/>
		/// with this core requires the use of the Vivado logic analyzer feature. Detailed documentation on<br/>
		/// the IP core can be found in the LogiCORE IP JTAG to AXI Master Product Guide (PG174). A tutorial<br/>
		/// showing its use can be found in the Vivado Design Suite Tutorial: Programming and Debugging<br/>
		/// (UG936).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The JTAG to AXI Master core must be instantiated in the RTL code, from the Xilinx IP catalog.<br/>
		/// AXI transactions are defined as complete READ or WRITE transactions between the AXI master<br/>
		/// and various slaves.<br/>
		/// This command returns a list of hw_axi_txn objects on the hw_device, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 708<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_axi_txn' objects of these types: 'hw_axi'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_axi_txn' objects against patterns. Default: *</param>
		/// <returns>hw_axi_txns</returns>
		public TTCL get_hw_axi_txns(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_axi_txns [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_axi_txns(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of hardware AXI objects.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_axis [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the JTAG to AXI Master core objects, or hw_axi objects, defined on the current hardware<br/>
		/// device.<br/>
		/// The JTAG to AXI Master is a customizable IP core that works as an AXI Master to drive AXI<br/>
		/// transactions and drive AXI signals that are internal to the hardware device. This IP can be used in<br/>
		/// Vivado® IP integrator or can be instantiated from the Xilinx® IP catalog into the HDL of a Vivado<br/>
		/// project. Run-time interaction with this core requires the use of the Vivado logic analyzer feature.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The JTAG-AXI core supports all memory-mapped AXI interfaces, except AXI4-Stream, and<br/>
		/// supports the AXI-Lite protocol. The AXI interface can be defined as a property of the core. The<br/>
		/// width of the AXI data bus is customizable. This IP can drive any AXI4-Lite or Memory Mapped<br/>
		/// Slave directly, and can also be connected as the AXI Master to the interconnect. Detailed<br/>
		/// documentation on the IP core can be found in the LogiCORE IP JTAG to AXI Master Product Guide<br/>
		/// (PG174). A tutorial showing its use can be found in the Vivado Design Suite Tutorial: Programming<br/>
		/// and Debugging (UG936).<br/>
		/// AXI cores can be found in the synthesized or implemented design netlist using the<br/>
		/// get_debug_cores command. This will return instances of the debug cores in the design that<br/>
		/// are related to the hw_axi objects, and other debug cores on the hw_device.<br/>
		/// This command returns a list of AXI Master core objects, hw_axis, on the hw_device, or returns an<br/>
		/// error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 711<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_axi' objects of these types: 'hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_axi' objects against patterns. Default: *</param>
		/// <returns>hw_axi</returns>
		public TTCL get_hw_axis(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_axis [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_axis(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of hardware cfgmems.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_cfgmems [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Get a list of hardware configuration memory (hw_cfgmem) objects created for the current<br/>
		/// hw_device.<br/>
		/// Xilinx FPGAs are configured by loading design-specific configuration data, in the form of a<br/>
		/// bitstream file, into the internal memory of the hw_device. The hw_cfgmem defines a flash<br/>
		/// memory device used for configuring and booting the Xilinx FPGA device. Once the hw_cfgmem<br/>
		/// object is created, and associated with the hw_device, the configuration memory can be<br/>
		/// programmed with the bitstream and other data using the program_hw_cfgmem command.<br/>
		/// The hw_cfgmem object is associated with the specified hw_device object through the<br/>
		/// PROGRAM.HW_CFGMEM property on the device object. The get_hw_cfgmems command lets<br/>
		/// you work with the hw_cfgmem object.<br/>
		/// This command returns a list of hw_cfgmem objects that match the specified search criteria, or<br/>
		/// returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 714<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_cfgmem' objects against patterns. Default: *</param>
		/// <returns>hardware cfgmems</returns>
		public TTCL get_hw_cfgmems(bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_cfgmems [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_cfgmems(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of Versal integrated and soft DDRMC cores.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_ddrmcs [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Xilinx Versal devices include integrated DDR Memory Controllers (DDRMC), as well as fabric<br/>
		/// based memory controllers. Refer to the LogiCore IP Product Guide: Versal ACAP Network on Chip<br/>
		/// and Integrated Memory Controller (PG313) for more information on the integrated controller core.<br/>
		/// Refer to Versal ACAP Soft DDR4 Memory IP (PG353) for more information on the fabric based<br/>
		/// memory controller. The memory controllers contain memory configuration and memory<br/>
		/// calibration data that can be accessed from the Xilinx Vivado Hardware Manager. The calibration<br/>
		/// and margin data are organized and presented in a graphical format for ease of analysis.<br/>
		/// The get_hw_ddrmc command returns a list of memory cores on the current hardware device.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the HBM with the specified DISPLAY_NAME:<br/>
		/// get_hw_hbms -filter {DISPLAY_NAME == HBM_2}<br/>
		/// The following example returns the DDRMC with the specified DISPLAY_NAME:<br/>
		/// get_hw_ddrmcs -filter {DISPLAY_NAME == DDRMC_1}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 717<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_ddrmc' objects of these types: 'hw_server<br/>
		/// hw_target hw_device'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_ddrmc' objects against patterns. Default: *</param>
		/// <returns>integrated and soft DDRMC cores</returns>
		public TTCL get_hw_ddrmcs(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_ddrmcs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_ddrmcs(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of hardware devices.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_devices [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the hardware devices on the open target of a connected hardware server.<br/>
		/// Each hardware target can have one or more Xilinx devices to program, or to use for debugging<br/>
		/// purposes. The current device is specified or returned by the current_hw_device command.<br/>
		/// This command returns a list of available hardware device objects, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 720<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_device' objects of these types: 'hw_target'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_device' objects against patterns. Default: *</param>
		/// <returns>hardware devices</returns>
		public TTCL get_hw_devices(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_devices [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_devices(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware HBM cores.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_hbms [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Certain Xilinx® UltraScale+ devices include an integrated High-Bandwidth Memory (HBM)<br/>
		/// controller. Refer to the LogiCore IP Product Guide: AXI High Bandwidth Memory Controller<br/>
		/// (PG276) for more information on this core. The HBM controller and memory stacks contain both<br/>
		/// performance counters and temperature sensors that can be accessed through an HBM activity<br/>
		/// monitor (amon) from within the Xilinx Vivado hardware manager. The HBM activity monitor can<br/>
		/// be used to gain real-time access to performance monitoring and temperature sensors on the<br/>
		/// physical device. The Vivado hardware manager displays read, write, and overall throughput of<br/>
		/// data, as well as the device temperature. The activity monitor displays, captures, and exports data<br/>
		/// to a CSV file when it is running.<br/>
		/// The get_hw_hbms command returns a list of HBM cores on the current hardware target.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the HBM with the specified DISPLAY_NAME:<br/>
		/// get_hw_hbms -filter {DISPLAY_NAME == HBM_2}<br/>
		/// This example returns all the HBM objects in the current device:<br/>
		/// get_hw_hbms<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 723<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_hbm' objects of these types: 'hw_server hw_target hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_hbm' objects against patterns. Default: *</param>
		/// <returns>hardware HBM cores</returns>
		public TTCL get_hw_hbms(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_hbms [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_hbms(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of hardware ILA data objects.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_ila_datas [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the ILA data objects in the Vivado logic analyzer.<br/>
		/// The upload_hw_ila_data command creates a hw_ila_data object in the process of moving<br/>
		/// the captured data from the ILA debug core, hw_ila, on the physical FPGA device, hw_device. The<br/>
		/// read_hw_ila_data command can also create a hw_ila_data object when reading an ILA data<br/>
		/// file from disk.<br/>
		/// The hw_ila_data object can be viewed in the waveform viewer of the Vivado logic analyzer by<br/>
		/// using the display_hw_ila_data command, and can be written to disk using the<br/>
		/// write_hw_ila_data command.<br/>
		/// This command returns a list of available hardware ILA data objects, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 726<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_ila_data' objects of these types: 'hw_ila hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_ila_data' objects against patterns. Default: *</param>
		/// <returns>hardware ILA data</returns>
		public TTCL get_hw_ila_datas(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_ila_datas [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_ila_datas(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of hardware ILA.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_ilas [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the ILA debug core objects defined on the current hardware device.<br/>
		/// The Integrated Logic Analyzer (ILA) debug core lets you perform in-system debug of<br/>
		/// implemented designs, or design bitstreams, on a programmed Xilinx FPGA. The ILA core includes<br/>
		/// many advanced features of modern logic analyzers, including boolean trigger equations, and edge<br/>
		/// transition triggers. You can use the ILA core to probe specific signals of the design, to trigger on<br/>
		/// programmed hardware events, and capture data from the Xilinx FPGA in real-time. Refer to<br/>
		/// LogiCORE IP Integrated Logic Analyzer (PG172) for details of the ILA core.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// You can add ILA debug cores into the RTL source files of a design, or in the synthesized netlist<br/>
		/// using the create_debug_core command. Refer to the Vivado Design Suite User Guide: Vivado<br/>
		/// Programming and Debugging (UG908) for more information on adding debug cores and signal<br/>
		/// probes to the design. You can get the debug cores in the synthesized netlist by using the<br/>
		/// get_debug_core commands. However, though they are related, the design debug cores are<br/>
		/// separate from the hardware debug cores found in the Hardware Manager feature of the Vivado<br/>
		/// Design Suite.<br/>
		/// Debug cores and probes are written to the probes file (.ltx) using the write_debug_probes<br/>
		/// command and associated with the hardware device, along with the bitstream file (.bit), using<br/>
		/// the PROBES.FILE and PROGRAM.FILE properties of the hw_device object. The hardware device<br/>
		/// is programmed with this information using the program_hw_devices command.<br/>
		/// The steps to debug your design in hardware using an ILA debug core are:<br/>
		/// 1. Connect to the hardware server and target using connect_hw_server and<br/>
		/// open_hw_target.<br/>
		/// 2. Program the FPGA with the bitstream (.bit) and probes (.ltx) files using<br/>
		/// program_hw_devices.<br/>
		/// 3. Set up the ILA debug core trigger and capture controls using set_property to set<br/>
		/// properties of the ILA.<br/>
		/// 4. Arm the ILA debug core trigger using run_hw_ila.<br/>
		/// 5. View the captured data from the ILA debug core in the Waveform window of the Vivado<br/>
		/// logic analyzer feature using display_hw_ila_data.<br/>
		/// 6. Optionally use the VIO debug core to drive control signals and/or view design status signals.<br/>
		/// See get_hw_vios for more information.<br/>
		/// 7. Optionally use the JTAG-to-AXI Master debug core to run transactions to interact with<br/>
		/// various AXI slave cores in your design. See get_hw_axis for more information.<br/>
		/// This command returns a list of ILA debug core objects on the device, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 729<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_ila' objects of these types: 'hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_ila' objects against patterns. Default: *</param>
		/// <returns>hardware ILAs</returns>
		public TTCL get_hw_ilas(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_ilas [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_ilas(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware Migs cores.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_migs [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the hw_mig objects on the current hardware device.<br/>
		/// Memory IP included in the Xilinx IP catalog are used to generate memory controllers and<br/>
		/// interfaces for Xilinx® devices. Memory IP includes different IP cores from the Xilinx IP catalog<br/>
		/// depending on the device architecture and memory interface specified. Refer to Zynq-7000 SoC<br/>
		/// and 7 Series Devices Memory Interface Solutions (UG586), or UltraScale Architecture-Based FPGAs<br/>
		/// Memory Interface Solutions (PG150), for details of the available memory IP.<br/>
		/// When added to a design, the memory IP needs to be implemented into the design. This occurs<br/>
		/// after the design is synthesized, during the design optimization phase of implementation, or<br/>
		/// opt_design, or can be done manually with the implement_mig_cores command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// A memory controller can be debug enabled when added into the design from the Xilinx IP<br/>
		/// catalog. In the Vivado logic analyzer, or the Vivado Lab Edition, memory controllers implemented<br/>
		/// into a design are associated with hw_mig objects, one hw_mig object per debug-enabled memory<br/>
		/// controller. The hw_mig object will have all the properties needed to get the calibration status and<br/>
		/// draw the per-bit eye margin views.<br/>
		/// In the Vivado logic analyzer, or Vivado Lab Edition, the hw_mig object lets you verify the<br/>
		/// calibration and read window margins in your memory interface design. You can use the hardware<br/>
		/// manager GUI to check the calibration status, verify the read margin for both rising and falling<br/>
		/// edges of the clock or DQS. You can also use an ILA core to verify the data integrity for the read<br/>
		/// and write operations.<br/>
		/// This command returns a list of hw_mig objects on the current hardware device, or returns an<br/>
		/// error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 733<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_mig' objects of these types: 'hw_server hw_target hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_mig' objects against patterns. Default: *</param>
		/// <returns>hardware migs cores</returns>
		public TTCL get_hw_migs(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_migs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_migs(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of soft PCIe core(s).<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_pcies [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-patterns &lt;arg&gt;] [-filter &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Get all the Peripheral Component Interconnect Express (PCIe) debug core objects, hw_pcie's,<br/>
		/// defined on the current hardware device.<br/>
		/// The customizable LogiCORE IP PCIe core for Xilinx ACAPs is designed for evaluating and<br/>
		/// monitoring the PCIe Link Training and Status State Machine (LTSSM) running on the Gigabit<br/>
		/// Transceivers (GTs). In the Vivado Hardware Manager, Versal PCIe soft cores implemented in the<br/>
		/// design, are represented as hw_pcie objects. You can use these PCIe debug cores to solve a range<br/>
		/// of debug and validation problems; from viewing the PCIe link info to the LTSSM state transition<br/>
		/// diagram.<br/>
		/// This command returns a list of PCIe debug core objects on the device, or returns an error if it<br/>
		/// fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns all the available PCIe cores<br/>
		/// get_hw_pcies<br/>
		/// The following example returns PCIe core with the specified DISPLAY_NAME<br/>
		/// get_hw_pcies -filter {NAME == "PCIe_0"}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 737<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_pcie' objects of these types: 'hw_server hw_target hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="patterns">(Optional) Match the 'hw_pcie' objects against patterns. Default: *</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>PCIe core(s)</returns>
		public TTCL get_hw_pcies(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String patterns = null, String filter = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_hw_pcies [-of_objects <args>] [-regexp] [-nocase] [-patterns <arg>] [-filter <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.get_hw_pcies(of_objects, regexp, nocase, patterns, filter, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of hardware probes.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_probes [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the hw_probe objects in the Hardware Manager that are defined on signals in the design,<br/>
		/// or that are assigned to the specified ILA or VIO debug cores.<br/>
		/// You can add ILA and VIO debug cores in the RTL source files of a design by customizing the core<br/>
		/// from the IP catalog, or add ILA debug cores into the synthesized netlist using the<br/>
		/// create_debug_core command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Signals in the design can be probed to monitor signal values and track hardware events on the<br/>
		/// FPGA device. Debug probes can be added to ILA debug cores in the synthesized netlist design<br/>
		/// using the create_debug_port command, and connected to signals in the design using<br/>
		/// connect_debug_port. Probes can only be added to VIO debug cores when the IP core is<br/>
		/// customized, or re-customized, from the IP catalog, and signals connected to it in the RTL design.<br/>
		/// Refer to the Vivado Design Suite User Guide: Vivado Programming and Debugging (UG908) for more<br/>
		/// information on adding ILA and VIO debug cores and signal probes to the design.<br/>
		/// Debug cores and probes are written to a probes file (.ltx) with write_debug_probes, and<br/>
		/// associated with the hardware device, along with the bitstream file (.bit), using the PROBES.FILE<br/>
		/// and PROGRAM.FILE properties of the hw_device object. The hardware device is programmed<br/>
		/// with this information using the program_hw_devices command.<br/>
		/// This command returns a list of debug probe objects on the device, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 740<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_probe' objects of these types: 'hw_interface hw_ila hw_vio'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_probe' objects against patterns. Default: *</param>
		/// <returns>hardware probes</returns>
		public TTCL get_hw_probes(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_probes [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_probes(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of hardware servers.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_servers [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// IMPORTANT! You must use the open_hw command to open the Hardware Manager in the Vivado<br/>
		/// Design Suite before using this command.<br/>
		/// This command returns hardware server objects that are connected to the current instance of the<br/>
		/// Vivado Design Suite through the use of the connect_hw_server command.<br/>
		/// Hardware servers are instances of the Xilinx hardware server (hw_server) application running<br/>
		/// remotely, or on the local machine. The hardware server manages connections to a hardware<br/>
		/// target, for instance a hardware board containing a JTAG chain of one or more Xilinx devices to be<br/>
		/// used for programming and debugging your FPGA design.<br/>
		/// This command returns a list of connected hardware server objects.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 744<br/>
		/// </para>
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_server' objects against patterns. Default: *</param>
		/// <returns>hardware servers</returns>
		public TTCL get_hw_servers(bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_servers [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_servers(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO GT commons.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_commons [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the QPLL objects, hw_sio_commons, defined on the IBERT debug core on the current<br/>
		/// hardware device.<br/>
		/// For each serial transceiver channel, there is a ring PLL called Channel PLL (CPLL). In Xilinx<br/>
		/// UltraScale and 7 series FPGAs, the high-speed transceivers have an additional common or shared<br/>
		/// PLL per quad, or Quad PLL (QPLL). This QPLL is a shared LC PLL to support high speed, high<br/>
		/// performance, and low power multi-lane applications.<br/>
		/// On the device, the GTXE2_CHANNEL component has the serial transceiver and CPLL units and<br/>
		/// the GTXE2_COMMON has the QPLL unit.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns a list of QPLL objects on the device as hw_sio_common objects, or returns<br/>
		/// an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 747<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_sio_common' objects of these types: 'hw_server<br/>
		/// hw_target hw_device hw_sio_ibert hw_sio_gtgroup<br/>
		/// hw_sio_pll'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_common' objects against patterns. Default: *</param>
		/// <returns>hardware SIO GT commons</returns>
		public TTCL get_hw_sio_commons(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_sio_commons [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_commons(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO GT groups.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_gtgroups [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the groups of GTs, hw_sio_gtgroups, as they relate to the quads that are in use on the<br/>
		/// IBERT debug core on the current hardware device.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// GT groups, relate to the IO Banks on the hardware device, with the number of available banks<br/>
		/// and GT pins determined by the target device. On the Kintex-7 xc7k325 part, for example, there<br/>
		/// are four quads, each containing four differential GT pins, and two differential REFCLK pins. Each<br/>
		/// GT pin has its own transmitter, TX, and receiver, RX. Quads can also include one shared PLL per<br/>
		/// quad, or Quad PLL. The quads are defined on the IBERT debug core, and can be customized with<br/>
		/// a number of user settings when the IBERT is added into the RTL design. Refer to the LogiCORE IP<br/>
		/// Integrated Bit Error Ratio Tester (IBERT) for 7 Series GTX Transceivers v3.0 (PG132)or to 7 Series<br/>
		/// FPGAs GTX/GTH Transceivers User Guide (UG476) or UltraScale Architecture GTH Transceivers User<br/>
		/// Guide (UG576) for more information.<br/>
		/// This command returns a list of GT group objects on the IBERT debug core, or returns an error if it<br/>
		/// fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 750<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_sio_gtgroup' objects of these types: 'hw_server<br/>
		/// hw_target hw_device hw_sio_ibert hw_sio_common<br/>
		/// hw_sio_pll hw_sio_gt hw_sio_tx hw_sio_rx'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_gtgroup' objects against patterns. Default: *</param>
		/// <returns>hardware SIO GT groups.</returns>
		public TTCL get_hw_sio_gtgroups(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_sio_gtgroups [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_gtgroups(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO GTs.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_gts [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the Gigabit Transceiver objects (GTs), hw_sio_gt, that are in use on the IBERT debug core<br/>
		/// on the current hardware device.<br/>
		/// The customizable LogiCORE™ IP Integrated Bit Error Ratio Tester (IBERT) core for Xilinx® FPGAs<br/>
		/// is designed for evaluating and monitoring the Gigabit Transceivers (GTs). The IBERT core enables<br/>
		/// in-system serial I/O validation and debug, letting you measure and optimize your high-speed<br/>
		/// serial I/O links in your FPGA-based system. Refer to the LogiCORE IP Integrated Bit Error Ratio<br/>
		/// Tester (IBERT) for 7 Series GTX Transceivers v3.0 (PG132)or to 7 Series FPGAs GTX/GTH Transceivers<br/>
		/// User Guide (UG476) or UltraScale Architecture GTH Transceivers User Guide (UG576) for more<br/>
		/// information.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Using the IBERT debug core you can configure and tune the GT transmitters and receivers<br/>
		/// through the Dynamic Reconfiguration Port (DRP) port of the GTX transceiver. This lets you<br/>
		/// change property settings on the GTs, as well as registers that control the values on the ports.<br/>
		/// This command returns a list of GT objects on the IBERT debug core, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 754<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_sio_gt' objects of these types: 'hw_server hw_target<br/>
		/// hw_device hw_sio_ibert hw_sio_gtgroup hw_sio_pll hw_sio_tx<br/>
		/// hw_sio_rx hw_sio_link'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_gt' objects against patterns. Default: *</param>
		/// <returns>hardware SIO GTs</returns>
		public TTCL get_hw_sio_gts(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_sio_gts [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_gts(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO IBERT cores.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_iberts [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the Integrated Bit Error Ratio Tester (IBERT) debug core objects, hw_sio_ibert, defined<br/>
		/// on the current hardware device.<br/>
		/// The customizable LogiCORE™ IP Integrated Bit Error Ratio Tester (IBERT) core for Xilinx® FPGAs<br/>
		/// is designed for evaluating and monitoring the Gigabit Transceivers (GTs). The IBERT core enables<br/>
		/// in-system serial I/O validation and debug, letting you measure and optimize your high-speed<br/>
		/// serial I/O links in your FPGA-based system. Refer to the LogiCORE IP Integrated Bit Error Ratio<br/>
		/// Tester (IBERT) for 7 Series GTX Transceivers v3.0 (PG132) for more information.<br/>
		/// The IBERT debug core lets you configure and control the major features of GTs on the device,<br/>
		/// including:<br/>
		/// • TX pre-emphasis and post-emphasis<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • TX differential swing<br/>
		/// • RX equalization<br/>
		/// • Decision Feedback Equalizer (DFE)<br/>
		/// • Phase-Locked Loop (PLL) divider settings<br/>
		/// You can use the IBERT core when you are interested in addressing a range of in-system debug<br/>
		/// and validation problems; from simple clocking and connectivity issues to complex margin analysis<br/>
		/// and channel optimization issues.<br/>
		/// This command returns a list of IBERT debug core objects on the device, or returns an error if it<br/>
		/// fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 757<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_sio_ibert' objects of these types: 'hw_server<br/>
		/// hw_target hw_device hw_sio_gtgroup hw_sio_gt<br/>
		/// hw_sio_common hw_sio_pll hw_sio_tx hw_sio_rx hw_sio_link'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_ibert' objects against patterns. Default: *</param>
		/// <returns>hardware SIO IBERT cores.</returns>
		public TTCL get_hw_sio_iberts(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_sio_iberts [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_iberts(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO link groups.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_linkgroups [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the defined groups, or associations of communication links between TX and RX objects<br/>
		/// on the GTs of the IBERT debug core defined on the current hardware device.<br/>
		/// Vivado Serial I/O analyzer is a link-based analyzer. The links define the communication paths and<br/>
		/// protocols between transmitters and receivers of the GigaBit transceivers on the device. Link<br/>
		/// groups, or hw_sio_linkgroup objects, let you associate links into related groups, to collectively<br/>
		/// configure properties and run scans.<br/>
		/// This command returns a list of linkgroups on the IBERT debug core, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 761<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_sio_linkgroup' objects of these types: 'hw_sio_link'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_linkgroup' objects against patterns. Default: *</param>
		/// <returns>hardware SIO link groups</returns>
		public TTCL get_hw_sio_linkgroups(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_sio_linkgroups [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_linkgroups(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO links.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_links [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the communication links between TX and RX objects on the GTs of the IBERT debug<br/>
		/// core defined on the current hardware device.<br/>
		/// Vivado Serial I/O analyzer is a link-based analyzer, which lets you link between any transmitter<br/>
		/// and receiver within the IBERT design. The links define the communication paths and protocols<br/>
		/// between transmitters and receivers of the GigaBit transceivers on the device. You can configure<br/>
		/// the links by using the set_property command to specify property values on the link object.<br/>
		/// This command returns a list of link objects on the IBERT debug core, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 764<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_sio_link' objects of these types: 'hw_server<br/>
		/// hw_target hw_device hw_sio_ibert hw_sio_gtgroup hw_sio_gt<br/>
		/// hw_sio_tx hw_sio_rx hw_sio_linkgroup'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_link' objects against patterns. Default: *</param>
		/// <returns>hardware SIO links</returns>
		public TTCL get_hw_sio_links(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_sio_links [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_links(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO PLLs.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_plls [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the PLL objects, hw_sio_pll, defined on the IBERT debug core on the current hardware<br/>
		/// device.<br/>
		/// For each serial transceiver channel, there is a ring PLL called Channel PLL (CPLL). In Xilinx<br/>
		/// UltraScale and 7 series FPGAs, the GTX has an additional shared PLL per quad, or Quad PLL<br/>
		/// (QPLL). This QPLL is a shared LC PLL to support high speed, high performance, and low power<br/>
		/// multi-lane applications.<br/>
		/// On the device, the GTXE2_CHANNEL component has the serial transceiver and CPLL units and<br/>
		/// the GTXE2_COMMON has the QPLL unit.<br/>
		/// This command returns a list of all PLL objects, both CPLLs and QPLLs on the device, or returns an<br/>
		/// error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 767<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_sio_pll' objects of these types: 'hw_server hw_target<br/>
		/// hw_device hw_sio_ibert hw_sio_gtgroup hw_sio_gt<br/>
		/// hw_sio_common'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_pll' objects against patterns. Default: *</param>
		/// <returns>hardware SIO PLLs</returns>
		public TTCL get_hw_sio_plls(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_sio_plls [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_plls(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO RXs.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_rxs [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the receiver objects, hw_sio_rx, of the Gigabit Transceivers (GTs) that are in use on the<br/>
		/// IBERT debug core on the current hardware device.<br/>
		/// On the hardware device, each GT includes an independent receiver, which consists of a PCS and<br/>
		/// a PMA. High-speed serial data flows from traces on the board into the PMA of the GTX/GTH<br/>
		/// transceiver RX, into the PCS, and finally into the FPGA logic.<br/>
		/// This command returns a list of receiver objects on the device, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 770<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_sio_rx' objects of these types: 'hw_server hw_target<br/>
		/// hw_device hw_sio_ibert hw_sio_gtgroup hw_sio_gt<br/>
		/// hw_sio_link'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_rx' objects against patterns. Default: *</param>
		/// <returns>hardware SIO RXs</returns>
		public TTCL get_hw_sio_rxs(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_sio_rxs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_rxs(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO scans.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_scans [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns serial I/O analyzer scan objects for the IBERT debug core.<br/>
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the<br/>
		/// specialized Eye Scan hardware of Xilinx UltraScale devices or 7 Series FPGAs. The Vivado serial<br/>
		/// I/O analyzer feature lets you to create, run, and save link scans.<br/>
		/// This command returns one or more hw_sio_scan objects, or returns an error if he command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 773<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_sio_scan' objects of these types: 'hw_sio_rx<br/>
		/// hw_sio_link hw_sio_sweep'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_scan' objects against patterns. Default: *</param>
		/// <returns>hardware SIO scans</returns>
		public TTCL get_hw_sio_scans(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_sio_scans [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_scans(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO sweeps.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_sweeps [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Return the serial I/O analyzer link sweep objects defined on the IBERT debug core.<br/>
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the<br/>
		/// specialized features of Xilinx UltraScale devices or 7 series FPGAs. It can also be helpful to run<br/>
		/// multiple scans on a the link with different configuration settings for the GTs. This can help you<br/>
		/// determine which settings are best for your design. The Vivado serial I/O analyzer feature enables<br/>
		/// you to define, run, and save link sweeps, or collections of link scans run across a range of values.<br/>
		/// This command returns a link sweep object that you can use with the run_hw_sio_sweep<br/>
		/// command to run analysis on the specified links, or GT receivers. You can also save the sweep<br/>
		/// scan to disk using the write_hw_sio_sweep command.<br/>
		/// You can remove the created sweep object using remove_hw_sio_sweep.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns one or more hw_sio_sweep objects, or returns an error if the command<br/>
		/// fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 776<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_sio_sweep' objects of these types: 'hw_sio_link hw_sio_scan'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_sweep' objects against patterns. Default: *</param>
		/// <returns>hardware SIO sweeps</returns>
		public TTCL get_hw_sio_sweeps(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_sio_sweeps [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_sweeps(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SIO TXs.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sio_txs [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the transmitter objects, hw_sio_tx, of the Gigabit Transceivers (GTs) that are in use on the<br/>
		/// IBERT debug core on the current hardware device.<br/>
		/// On the hardware device, each GT includes an independent transmitter, which consists of a PCS<br/>
		/// and a PMA. Parallel data flows from the device logic into the FPGA TX interface, through the PCS<br/>
		/// and PMA, and then out the TX driver as high-speed serial data.<br/>
		/// This command returns a list of transmitter objects on the device, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 780<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_sio_tx' objects of these types: 'hw_server hw_target<br/>
		/// hw_device hw_sio_ibert hw_sio_gtgroup hw_sio_gt<br/>
		/// hw_sio_link'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_tx' objects against patterns. Default: *</param>
		/// <returns>hardware SIO TXs</returns>
		public TTCL get_hw_sio_txs(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_sio_txs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_txs(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of Versal soft memory controller cores.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_softmcs [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 783<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_softmc' objects of these types: 'hw_server<br/>
		/// hw_target hw_device'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_softmc' objects against patterns. Default: *</param>
		/// <returns>soft memory controller cores</returns>
		public TTCL get_hw_softmcs(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_softmcs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_softmcs(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get the system monitor register value<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sysmon_reg [-quiet] [-verbose] &lt;hw_sysmon&gt; &lt;hexaddress&gt;
		/// <br/>
		/// <para>
		/// Returns the hex value of the system monitor register defined at the specified address of the<br/>
		/// specified hw_sysmon object.<br/>
		/// The System Monitor (SYSMON) Analog-to-Digital Converter (ADC) is used to measure die<br/>
		/// temperature and voltage on the hw_device. The sysmon monitors the physical environment via<br/>
		/// on-chip temperature and supply sensors. The ADC can access up to 17 external analog input<br/>
		/// channels.<br/>
		/// Data for the system monitor is stored in dedicated registers, called status and control registers,<br/>
		/// accessible through the hw_sysmon_reg object. Refer to the Register Interface in UltraScale<br/>
		/// Architecture System Monitor User Guide (UG580), or 7 Series FPGAs and Zynq-7000 SoC XADC Dual<br/>
		/// 12-Bit 1 MSPS Analog-to-Digital Converter User Guide (UG480) for more information on the<br/>
		/// addresses of specific system monitor registers.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Although the get_hw_sysmon_reg command lets you directly access the values stored in<br/>
		/// registers of the hw_sysmon object, the recommended procedure is to retrieve the values of<br/>
		/// registers as formatted properties of the hw_sysmon object. For example, the following code<br/>
		/// retrieves the TEMPERATURE on the system monitor as a formatted property of the hw_sysmon<br/>
		/// object rather than accessing the hex value of the sysmon register:<br/>
		/// set opTemp [get_property TEMPERATURE [get_hw_sysmons]<br/>
		/// The get_property command returns the TEMPERATURE as a formatted value in degrees<br/>
		/// Celsius, Fahrenheit, or Kelvin as determined by the TEMPERATURE_SCALE property on the<br/>
		/// hw_sysmon object.<br/>
		/// TIP: You can also be sure the property value on the object is current by issuing the<br/>
		/// refresh_hw_sysmon command prior to get_property.<br/>
		/// The get_hw_sysmon_reg command returns the unformatted hex value of the hw_sysmon_reg<br/>
		/// object on the specified hw_sysmons at the specified address, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 784<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_sysmon">(Required) hw_sysmon object</param>
		/// <param name="hexaddress">(Required) Hex address to read from</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Register value in Hex.</returns>
		public TTCL get_hw_sysmon_reg(TCLObject hw_sysmon, TCLObject hexaddress, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_hw_sysmon_reg [-quiet] [-verbose] <hw_sysmon> <hexaddress>
			_tcl.Entry(_builder.get_hw_sysmon_reg(hw_sysmon, hexaddress, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get list of hardware SysMons.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_sysmons [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the Sysmon debug core objects defined on the current hardware device.<br/>
		/// The System Monitor (SYSMON) Analog-to-Digital Converter (ADC) is used to measure die<br/>
		/// temperature and voltage on the hw_device. The Sysmon monitors the physical environment via<br/>
		/// on-chip temperature and supply sensors. The ADC provides a high-precision analog interface for<br/>
		/// a range of applications. The ADC can access up to 17 external analog input channels. Refer to<br/>
		/// UltraScale Architecture System Monitor User Guide (UG580), or 7 Series FPGAs and Zynq-7000 SoC<br/>
		/// XADC Dual 12-Bit 1 MSPS Analog-to-Digital Converter User Guide (UG480) for more information on<br/>
		/// a specific device architecture.<br/>
		/// The hw_sysmon data is stored in dedicated registers called status registers accessible through the<br/>
		/// hw_sysmon_reg object. The values of the system monitor registers can be returned by the<br/>
		/// get_hw_sysmon_reg command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Every device that supports the system monitor will automatically have one or more hw_sysmon<br/>
		/// objects created when refresh_hw_device is called. When the hw_sysmon object is created, it<br/>
		/// is assigned a property for all the temperature and voltage registers, as well as the control<br/>
		/// registers. On the hw_sysmon object, the values assigned to the temperature and voltage registers<br/>
		/// are already translated to Celsius/Fahrenheit and Voltage.<br/>
		/// Although you can use the get_hw_sysmon_reg command to access the hex values stored in<br/>
		/// registers of a system monitor, you can also retrieve values of certain registers as formatted<br/>
		/// properties of the hw_sysmon object. For example, the following code retrieves the<br/>
		/// TEMPERATURE property of the specified hw_sysmon object rather than directly accessing the<br/>
		/// hex value of the register:<br/>
		/// set opTemp [get_property TEMPERATURE [get_hw_sysmons]<br/>
		/// This command returns a list of hw_sysmon objects on the current or specified hw_device, or<br/>
		/// returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 787<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">
		/// <para>
		/// (Optional)<br/>
		/// Get 'hw_sysmon' objects of these types: 'hw_server<br/>
		/// hw_target hw_device'.<br/>
		/// </para>
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sysmon' objects against patterns. Default: *</param>
		/// <returns>hardware sysmons</returns>
		public TTCL get_hw_sysmons(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_sysmons [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sysmons(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of hardware targets.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_targets [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the available hardware targets of the connected hardware servers.<br/>
		/// The hardware target is a system board containing a JTAG chain of one or more Xilinx devices that<br/>
		/// you can program with a bitstream file, or use to debug your design. Connections between<br/>
		/// hardware targets on the system board and the Vivado Design Suite are managed by the Xilinx<br/>
		/// hardware server application, and the connect_hw_server command. Refer to Vivado Design<br/>
		/// Suite User Guide: Programming and Debugging (UG908) for a list of supported JTAG download<br/>
		/// cables and devices.<br/>
		/// Use the open_hw_target command to open a connection to one of the available hardware<br/>
		/// targets. The open target is automatically defined as the current hardware target. Alternatively,<br/>
		/// you can define the current target with the current_hw_target command, and then open a<br/>
		/// connection to the current target. The Vivado Design Suite directs programming and debug<br/>
		/// commands to the open target through the hardware server connection.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns a list of available hardware targets through all connected hardware<br/>
		/// servers, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 791<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_target' objects of these types: 'hw_server'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_target' objects against patterns. Default: *</param>
		/// <returns>hardware targets</returns>
		public TTCL get_hw_targets(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_targets [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_targets(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Get a list of hardware VIOs.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: get_hw_vios [-of_objects &lt;args&gt;] [-regexp] [-nocase] [-filter &lt;arg&gt;] [-quiet] [-verbose] [&lt;patterns&gt;]
		/// <br/>
		/// <para>
		/// Returns the Virtual Input/Output (VIO) debug core objects that are defined on the current<br/>
		/// hardware device, hw_device.<br/>
		/// The Virtual Input/Output (VIO) debug core can both monitor and drive internal signals on a<br/>
		/// programmed Xilinx FPGA in real time. In the absence of physical access to the target hardware,<br/>
		/// you can use this debug feature to drive and monitor signals that are present on the physical<br/>
		/// device.<br/>
		/// The VIO core has hardware probes, hw_probe objects, to monitor and drive specific signals on<br/>
		/// the design. Input probes monitor signals as inputs to the VIO core. Output probes drive signals to<br/>
		/// specified values from the VIO core. Values on the debug core are driven onto the signals at the<br/>
		/// probe using the commit_hw_vio command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The VIO debug core needs to be instantiated in the RTL code, therefore you need to know what<br/>
		/// nets you want monitor and drive prior to debugging the design. The IP catalog provides the VIO<br/>
		/// core under the Debug category. Detailed documentation on the VIO core can be found in the<br/>
		/// LogiCORE IP Virtual Input/Output Product Guide (PG159).<br/>
		/// This command returns a list of VIO debug core objects on the device, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 794<br/>
		/// </para>
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_vio' objects of these types: 'hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_vio' objects against patterns. Default: *</param>
		/// <returns>hardware VIOs</returns>
		public TTCL get_hw_vios(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, TCLObject patterns = null)
		{
			// TCL Syntax: get_hw_vios [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_vios(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Return probe sample values<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: list_hw_samples [-quiet] [-verbose] [&lt;hw_probe&gt;]
		/// <br/>
		/// <para>
		/// Writes data samples from the specified hw_probe object on the current hw_ila.<br/>
		/// The number of captured samples returned from the specified probe is equal to the DATA_DEPTH<br/>
		/// property of the ILA core. The default data depth is 1024 samples. Data values are returned in the<br/>
		/// radix specified for the hw_probe, as determined by the DISPLAY_RADIX property.<br/>
		/// TIP: For any samples to be returned, data must have been captured by the specified port.<br/>
		/// The values are listed to the standard output, or can be captured to a Tcl variable for post-processing, or output to a file.<br/>
		/// The following is an example Tcl script that lists the data samples from hw_probes of interest:<br/>
		/// # Define a list of probes to get the data samples from<br/>
		/// set probeList [get_hw_probes *AR*]<br/>
		/// #Specify the radix for the return values<br/>
		/// set_property DISPLAY_RADIX BINARY [get_hw_probes *AR*]<br/>
		/// # Define a filename to write data to<br/>
		/// set fileName C:/Data/probeData1.txt<br/>
		/// # Open the specified file in write mode<br/>
		/// set FH [open $fileName w]<br/>
		/// # Write probe data for each probe<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// foreach x $probeList {<br/>
		/// puts $FH "$x:"<br/>
		/// puts $FH [list_hw_samples $x]<br/>
		/// }<br/>
		/// # Close the output file<br/>
		/// close $FH<br/>
		/// puts "Probe data written to $fileName\n"<br/>
		/// This command returns the requested output, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the data samples for the specified probe:<br/>
		/// list_hw_samples [get_hw_probes *probe18]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1030<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_probe">(Optional) hw_probe object</param>
		/// <returns>samples</returns>
		public TTCL list_hw_samples(bool? quiet = null, bool? verbose = null, TCLObject hw_probe = null)
		{
			// TCL Syntax: list_hw_samples [-quiet] [-verbose] [<hw_probe>]
			_tcl.Entry(_builder.list_hw_samples(quiet, verbose, hw_probe));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Open the hardware tool<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: open_hw_manager [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Open the Hardware Manager in the Vivado Design Suite in either the Vivado IDE or in Tcl or<br/>
		/// batch mode. Opening the Hardware Manager is the first step in programming and/or debugging<br/>
		/// your design in Xilinx FPGA hardware. For more information refer to the Vivado Design Suite User<br/>
		/// Guide: Programming and Debugging (UG908).<br/>
		/// Hardware Manager is a feature of the Vivado Design Suite which lets you interact with FPGA<br/>
		/// devices on a board. The features of the Hardware Manager include:<br/>
		/// • Logic Debug or Logic Analyzer- Debugging FPGA programmable logic designs.<br/>
		/// • Programming/Configuration - Program FPGA devices using JTAG and configuring flash<br/>
		/// memory devices connected to FPGAs.<br/>
		/// • In-system Serial I/O debug - Adjust SERDES receive/transmit settings and measure<br/>
		/// transmission bit error rates.<br/>
		/// • System Monitor - Control on chip system monitor and read system monitor temperature and<br/>
		/// voltage values.<br/>
		/// The Hardware Manager uses a number of first class objects, like hw_server, hw_target,<br/>
		/// hw_device, and hw_ila. Each of these objects is related to other objects, and has properties that<br/>
		/// can be set or read by the set_property and get_property commands to configure or<br/>
		/// control its function in the Hardware Manager. Refer to the Vivado Design Suite Properties<br/>
		/// Reference Guide (UG912) for more information on these objects.<br/>
		/// The steps to connect to hardware and program the target FPGA are:<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// 1. Open the hardware manager in the IDE (open_hw_manager).<br/>
		/// TIP: This step can be skipped if you are running in batch or Tcl mode.<br/>
		/// 2. Connect to a hardware server running either on the local machine, or on a remote network<br/>
		/// accessible host (connect_hw_server).<br/>
		/// 3. Open a hardware target on the connected hardware server (open_hw_target).<br/>
		/// 4. Identify the Xilinx FPGA on the open hardware target (current_hw_device,<br/>
		/// get_hw_devices).<br/>
		/// 5. Associate the bitstream data programming file (.bit), and probes file (.ltx) if one exists,<br/>
		/// with the appropriate FPGA (set_property).<br/>
		/// 6. Program or download the programming file into the hardware device<br/>
		/// (program_hw_device, refresh_hw_device).<br/>
		/// Note that you can run the Hardware Manager from within the Vivado tool without having a<br/>
		/// project or design open. You can open the Hardware Manager, connect to the hardware server,<br/>
		/// and program the device on the target by providing a bitstream file, and probes file for debugging.<br/>
		/// You can close the Hardware Manager using the close_hw_manager command.<br/>
		/// This command returns nothing if successful, and returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1079<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL open_hw_manager(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: open_hw_manager [-quiet] [-verbose]
			_tcl.Entry(_builder.open_hw_manager(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Open a connection to a hardware target on the hardware server<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: open_hw_target [-jtag_mode &lt;arg&gt;] [-xvc_url &lt;arg&gt;] [-auto_calibrate] [-quiet] [-verbose] [&lt;hw_target&gt;]
		/// <br/>
		/// <para>
		/// Opens a connection to the specified hardware target of the connected hardware servers, or<br/>
		/// opens the current hardware target.<br/>
		/// The hardware target is a system board containing a JTAG chain of one or more Xilinx devices that<br/>
		/// you can program with a bitstream file, or use to debug your design. Connections between<br/>
		/// hardware targets on the system board and the Vivado Design Suite are managed by the Xilinx<br/>
		/// hardware server application, and the connect_hw_server command. Refer to Vivado Design<br/>
		/// Suite User Guide: Programming and Debugging (UG908) for a list of supported JTAG download<br/>
		/// cables and devices.<br/>
		/// Each hardware target can have one or more Xilinx devices to program, or to use for debugging<br/>
		/// purposes. The current device is specified or returned by the current_hw_device command.<br/>
		/// Use the open_hw_target command to open a connection to one of the available hardware<br/>
		/// targets. The open target is automatically defined as the current hardware target. Alternatively,<br/>
		/// you can define the current target with the current_hw_target command, and then open the<br/>
		/// current target. The Vivado Design Suite directs programming and debug commands to the open<br/>
		/// target through the hardware server connection.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// An open connection to the hardware target can be closed using the close_hw_target<br/>
		/// command.<br/>
		/// The open_hw_target command returns connection messages from the hardware server, or<br/>
		/// returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1084<br/>
		/// </para>
		/// </summary>
		/// <param name="jtag_mode">(Optional) Open target in JTAG mode</param>
		/// <param name="xvc_url">(Optional) Open target connection to XVC server</param>
		/// <param name="auto_calibrate">(Optional) Auto-calibrate target for optimal frequency (SmartLynq cable only)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_target">(Optional) hardware target Default: current hardware target</param>
		public TTCL open_hw_target(String jtag_mode = null, String xvc_url = null, bool? auto_calibrate = null, bool? quiet = null, bool? verbose = null, TCLObject hw_target = null)
		{
			// TCL Syntax: open_hw_target [-jtag_mode <arg>] [-xvc_url <arg>] [-auto_calibrate] [-quiet] [-verbose] [<hw_target>]
			_tcl.Entry(_builder.open_hw_target(jtag_mode, xvc_url, auto_calibrate, quiet, verbose, hw_target));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Pause Activity Monitor runs for the specified hardware HBM(s)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: pause_hw_hbm_amon [-quiet] [-verbose] &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// The pause_hw_hbm_amon command pauses a running HBM activity monitor in the Vivado<br/>
		/// hardware manager that has been previously started using the run_hw_hbm_amon command.<br/>
		/// This command returns nothing when successful, or returns an error when it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example pauses the HBM activity monitor for the associated HBM core:<br/>
		/// pause_hw_hbm_amon [get_hw_hbms *HBM_2]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1112<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL pause_hw_hbm_amon(TCLObject hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: pause_hw_hbm_amon [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.pause_hw_hbm_amon(hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Program Cfgmem object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: program_hw_cfgmem [-svf_file &lt;arg&gt;] [-force] [-append] [-quiet] [-verbose] [&lt;hw_cfgmem&gt;...]
		/// <br/>
		/// <para>
		/// Erase, blank check, program, and/or verify the specified hw_cfgmem object with the memory<br/>
		/// configuration file defined in the object's PROGRAM.FILE property. The memory configuration file<br/>
		/// is created with the write_cfgmem command, and associated with the hw_cfgmem object using<br/>
		/// the set_property command as shown in the example.<br/>
		/// The process whereby the design specific data is loaded or programmed into the Xilinx FPGA is<br/>
		/// called configuration. The create_hw_cfgmem command defines a flash memory device used<br/>
		/// for configuring and booting the FPGA device.<br/>
		/// After the hw_cfgmem object is created, and associated with the hw_device, the configuration<br/>
		/// memory can be programmed with the bitstream and other data from a memory configuration file<br/>
		/// created with the write_cfgmem command. The hw_cfgmem object is programmed using the<br/>
		/// program_hw_cfgmem command.<br/>
		/// The program_hw_cfgmem command will run a multi-step process to erase the configuration<br/>
		/// memory device, perform a blank check to validate that the device is empty, program the device<br/>
		/// with the memory configuration file, and verify the programming on the device. Properties on the<br/>
		/// hw_cfgmem object determine which steps of the programming process are performed. These<br/>
		/// properties include:<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • PROGRAM.FILES - Specifies the memory configuration files to use for programming the<br/>
		/// device. The memory configuration files are created with the write_cfgmem command.<br/>
		/// • PROGRAM.ADDRESS_RANGE - Specifies the address range of the configuration memory<br/>
		/// device to program. The address range values can be:<br/>
		/// ○ {use_file} - Use only the address space required by the memory configuration file to<br/>
		/// erase, blank check, program, and verify.<br/>
		/// ○ {entire_device} - Erase, blank check, program, and verify the entire device.<br/>
		/// • PROGRAM.ERASE - Erases the contents of the flash memory when true. This is a boolean<br/>
		/// property with a value of 0 (false) or 1 (true).<br/>
		/// • PROGRAM.BLANK_CHECK - Checks the device to make sure the device is void of data prior<br/>
		/// to programming. This is a boolean property with a value of 0 (false) or 1 (true).<br/>
		/// • PROGRAM.CFG_PROGRAM - Program the device with the specified PROGRAM.FILE. This is<br/>
		/// a boolean property with a value of 0 (false) or 1 (true).<br/>
		/// • PROGRAM.VERIFY - Verify the device after programming. This is a boolean property with a<br/>
		/// value of 0 (false) or 1 (true).<br/>
		/// The program_hw_cfgmem command can also generate an SVF file for in-system and remote<br/>
		/// programming of Xilinx devices. SVF is an industry standard file format that is used to describe<br/>
		/// JTAG chain operations by describing the information that needs to be shifted into the device<br/>
		/// chain. SVF files are ASCII files that can be written and modified in any text editor. Many third-party programming utilities can use the SVF file to program Xilinx devices in a JTAG chain.<br/>
		/// This command returns a transcript of its process when successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1141<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_cfgmem">(Required) list of hardware cfgmems Default: current hardware cfgmem</param>
		/// <param name="svf_file">(Optional) svf file to be generated</param>
		/// <param name="force">(Optional) overwrite svf_file if it already exists</param>
		/// <param name="append">(Optional) append to svf file</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL program_hw_cfgmem(TCLObjectList hw_cfgmem, String svf_file = null, bool? force = null, bool? append = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: program_hw_cfgmem [-svf_file <arg>] [-force] [-append] [-quiet] [-verbose] [<hw_cfgmem>...]
			_tcl.Entry(_builder.program_hw_cfgmem(hw_cfgmem, svf_file, force, append, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Program hardware devices<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: program_hw_devices [-key &lt;arg&gt;] [-clear] [-skip_program_keys] [-skip_program_rsa] [-user_efuse &lt;arg&gt;] [-user_efuse_128 &lt;arg&gt;] [-control_efuse &lt;arg&gt;] [-security_efuse &lt;arg&gt;] [-only_export_efuse] [-svf_file &lt;arg&gt;] [-efuse_export_file &lt;arg&gt;] [-disable_eos_check] [-skip_reset] [-force] [-append] [-type &lt;arg&gt;] [-quiet] [-verbose] [&lt;hw_device&gt;...]
		/// <br/>
		/// <para>
		/// Program the specified hardware device object or objects on the open hardware target of the<br/>
		/// current hardware server.<br/>
		/// To access a Xilinx FPGA through the Hardware Manager, you must use the following Tcl<br/>
		/// command sequence:<br/>
		/// 1. open_hw - Opens the Hardware Manager in the Vivado Design Suite.<br/>
		/// 2. connect_hw_server - Makes a connection to a local or remote Vivado hardware server<br/>
		/// application.<br/>
		/// 3. current_hw_target - Defines the hardware target of the connected server.<br/>
		/// 4. open_hw_target - Opens a connection to the hardware target.<br/>
		/// 5. current_hw_device - Specifies the Xilinx FPGA to use for programming and debugging.<br/>
		/// After connecting to the target hardware device, you must associate the bitstream file<br/>
		/// (.bit, .rbt, .bin) from the design with the device, using the set_property command:<br/>
		/// set_property PROGRAM.FILE {C:/Data/design.bit} [current_hw_device]<br/>
		/// For debug purposes, you can also associate a probes file (.ltx) with the device using the<br/>
		/// PROBES.FILE property:<br/>
		/// set_property PROBES.FILE {C:/Data/debug_nets.ltx} [current_hw_device]<br/>
		/// Once the programming file has been associated with the hardware device, you can program the<br/>
		/// hardware device using the program_hw_devices command, and debug the device using any<br/>
		/// of a number of Hardware Manager Tcl commands. To interactively debug the device open the<br/>
		/// Hardware Manager in the Vivado Design Suite IDE.<br/>
		/// You can also program an encrypted bitstream into the specified hw_device. This requires the<br/>
		/// implemented design to have encryption properties assigned prior to generating the bitstream<br/>
		/// with the write_bitstream command. You can add ENCRYPTION properties to the design<br/>
		/// most easily using the Encryption page of the Edit Device Properties dialog box in the Vivado IDE.<br/>
		/// Refer to the Vivado Design Suite User Guide: Programming and Debugging (UG908) for more<br/>
		/// information on the Edit Device Properties dialog box.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Programming a device for an encrypted bitstream is a two-step process that requires running<br/>
		/// program_hw_devices once to program the encryption key into the BBR or eFUSE registers,<br/>
		/// and a second time to program the encrypted bitstream into the device:<br/>
		/// program_hw_devices -key bbr [current_hw_device]<br/>
		/// program_hw_device [current_hw_device]<br/>
		/// CAUTION! eFUSEs are one-time programmable cells on the hardware device, used to store the factory-programmed Device DNA, AES-GCM encryption key, and user specified values. Refer to the UltraScale<br/>
		/// Architecture Configuration (UG570) or 7 Series FPGAs Configuration User Guide (UG470) for more<br/>
		/// information on eFUSE registers.<br/>
		/// The program_hw_devices command can also generate a Serial Vector Format (SVF) file for in-system and remote programming of Xilinx devices. SVF is an industry standard file format that is<br/>
		/// used to describe JTAG chain operations by describing the information that needs to be shifted<br/>
		/// into the device chain. SVF files are ASCII files that can be written and modified in any text editor.<br/>
		/// Many third-party programming utilities can use the SVF file to program Xilinx devices in a JTAG<br/>
		/// chain.<br/>
		/// This command returns a transcript of its actions, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1144<br/>
		/// </para>
		/// </summary>
		/// <param name="key">(Optional) key option value for encryption programming: efuse,bbr,none</param>
		/// <param name="clear">(Optional) clear bbr registers, only valid for bbr</param>
		/// <param name="skip_program_keys">(Optional) skip programming keys specified in NKY file, if any</param>
		/// <param name="skip_program_rsa">(Optional) skip programming RSA key specified in NKY file, if any</param>
		/// <param name="user_efuse">(Optional) hex user fuse value for encryption programming</param>
		/// <param name="user_efuse_128">(Optional) hex user fuse 128 bit value for encryption programming</param>
		/// <param name="control_efuse">(Optional) hex control fuse value for encryption programming</param>
		/// <param name="security_efuse">(Optional) hex security fuse value for encryption programming</param>
		/// <param name="only_export_efuse">(Optional) do not program eFUSE; just export settings to efuse_export_file</param>
		/// <param name="svf_file">(Optional) svf file used to program device</param>
		/// <param name="efuse_export_file">(Optional) output file to store programmed eFUSE settings</param>
		/// <param name="disable_eos_check">(Optional) Disables End of Startup check after programming</param>
		/// <param name="skip_reset">(Optional) Skips resetting the device before programming</param>
		/// <param name="force">(Optional) overwrites svf file and creates empty file</param>
		/// <param name="append">(Optional) append to svf file</param>
		/// <param name="type">(Optional) bitstream file type to be used for programming: bit,bin,rbt</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_device">
		/// <para>
		/// (Optional)<br/>
		/// list of hardware devices Default: current hardware device<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// </param>
		/// <returns>hardware devices</returns>
		public TTCL program_hw_devices(String key = null, bool? clear = null, bool? skip_program_keys = null, bool? skip_program_rsa = null, String user_efuse = null, String user_efuse_128 = null, String control_efuse = null, String security_efuse = null, bool? only_export_efuse = null, String svf_file = null, String efuse_export_file = null, bool? disable_eos_check = null, bool? skip_reset = null, bool? force = null, bool? append = null, String type = null, bool? quiet = null, bool? verbose = null, TCLObjectList hw_device = null)
		{
			// TCL Syntax: program_hw_devices [-key <arg>] [-clear] [-skip_program_keys] [-skip_program_rsa] [-user_efuse <arg>] [-user_efuse_128 <arg>] [-control_efuse <arg>] [-security_efuse <arg>] [-only_export_efuse] [-svf_file <arg>] [-efuse_export_file <arg>] [-disable_eos_check] [-skip_reset] [-force] [-append] [-type <arg>] [-quiet] [-verbose] [<hw_device>...]
			_tcl.Entry(_builder.program_hw_devices(key, clear, skip_program_keys, skip_program_rsa, user_efuse, user_efuse_128, control_efuse, security_efuse, only_export_efuse, svf_file, efuse_export_file, disable_eos_check, skip_reset, force, append, type, quiet, verbose, hw_device));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Read hardware ILA data from a file<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_hw_ila_data [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Read ILA debug core data from the specified file, and create an hw_ila_data object.<br/>
		/// The ILA debug sample data is acquired from a running device using the upload_hw_ila_data<br/>
		/// command. This creates a hw_ila_data object that can be written to a file on disk using the<br/>
		/// write_hw_ila_data command. This command reads that ILA data file.<br/>
		/// The hw_ila_data object that is created by read_hw_ila_data is named after the &lt;file&gt; it is<br/>
		/// read from. If a hw_ila_data object of the same name already exists, the name of the object is<br/>
		/// assigned a number extension starting at 1: &lt;file&gt;_1.<br/>
		/// The new hw_ila_data object is not connected with, or associated with, any ILA debug cores in the<br/>
		/// design.<br/>
		/// After being read from disk, the ILA debug data can be viewed in the waveform viewer of the<br/>
		/// Vivado logic analyzer by using the display_hw_ila_data command.<br/>
		/// This command returns an ILA data object, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1161<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) hardware ILA data file name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Name of the output file</returns>
		public TTCL read_hw_ila_data(TCLObject file, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_hw_ila_data [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.read_hw_ila_data(file, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Read hardware SIO scan data from a file. A hardware SIO scan object will be created if not<br/>
		/// provided.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_hw_sio_scan [-quiet] [-verbose] &lt;file&gt; [&lt;hw_sio_scan&gt;]
		/// <br/>
		/// <para>
		/// Read a hardware SIO scan data file and create a hw_sio_scan object in the Hardware Manager<br/>
		/// feature of the Vivado Design Suite.<br/>
		/// The SIO scan data can be written to disk using the write_hw_sio_scan command, after<br/>
		/// running the scan using the run_hw_sio_scan command. This command reads that data file.<br/>
		/// If no hw_sio_scan object is specified, a new hw_sio_scan object is created and is named<br/>
		/// sequentially following any existing hw_sio_scan objects. After being read from disk, the SIO scan<br/>
		/// data can be plotted and viewed in the Vivado serial I/O analyzer by using the<br/>
		/// display_hw_sio_scan command.<br/>
		/// This command returns a hw_sio_scan object, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1163<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) hardware SIO scan file name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_sio_scan">(Optional) hardware SIO scan data object Default: None</param>
		/// <returns>hardware SIO scan object</returns>
		public TTCL read_hw_sio_scan(TCLObject file, bool? quiet = null, bool? verbose = null, TCLObject hw_sio_scan = null)
		{
			// TCL Syntax: read_hw_sio_scan [-quiet] [-verbose] <file> [<hw_sio_scan>]
			_tcl.Entry(_builder.read_hw_sio_scan(file, quiet, verbose, hw_sio_scan));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Read hardware SIO sweep data from a directory. A hardware SIO sweep object will be created if<br/>
		/// not provided.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_hw_sio_sweep [-quiet] [-verbose] &lt;directory&gt; [&lt;hw_sio_sweep&gt;]
		/// <br/>
		/// <para>
		/// Read a hardware SIO sweep data directory and create a hw_sio_sweep object in the Hardware<br/>
		/// Manager feature of the Vivado Design Suite.<br/>
		/// The SIO sweep data can be written to disk using the write_hw_sio_sweep command, after<br/>
		/// running the sweep using the run_hw_sio_sweep command. This command reads the sweep<br/>
		/// directory containing multiple SIO scan data files.<br/>
		/// If no hw_sio_sweep object is specified, a new hw_sio_sweep object is created and is named<br/>
		/// sequentially following any existing hw_sio_sweep objects. After being read from disk, any of the<br/>
		/// SIO scans in the sweep can be plotted and viewed in the Vivado serial I/O analyzer by using the<br/>
		/// display_hw_sio_scan command.<br/>
		/// This command returns a hw_sio_sweep object, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1165<br/>
		/// </para>
		/// </summary>
		/// <param name="directory">(Required) hardware SIO sweep directory name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_sio_sweep">(Optional) hardware SIO sweep data object Default: None</param>
		/// <returns>hardware SIO sweep object</returns>
		public TTCL read_hw_sio_sweep(TCLObject directory, bool? quiet = null, bool? verbose = null, TCLObject hw_sio_sweep = null)
		{
			// TCL Syntax: read_hw_sio_sweep [-quiet] [-verbose] <directory> [<hw_sio_sweep>]
			_tcl.Entry(_builder.read_hw_sio_sweep(directory, quiet, verbose, hw_sio_sweep));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Readback data from the hw_cfgmem object<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: readback_hw_cfgmem [-checksum] [-force] [-all] [-offset &lt;arg&gt;] -file &lt;arg&gt; [-format &lt;arg&gt;] [-datacount &lt;arg&gt;] [-quiet] [-verbose] [&lt;hw_cfgmem&gt;...]
		/// <br/>
		/// <para>
		/// Read programming data off of the hardware configuration memory device, specified as a<br/>
		/// hw_cfgmem object.<br/>
		/// This command reads back the memory configuration file data programmed into a flash memory<br/>
		/// device by the program_hw_cfgmem command and writes it to the specified file. The memory<br/>
		/// configuration file is created by the write_cfgmem command and combines the bitstream<br/>
		/// (.bit) file, and any specified data files, into the memory configuration file format.<br/>
		/// Readback is the process of reading data from the configuration memory device to verify that the<br/>
		/// bitstream and any additional data files were properly programmed into the flash memory device.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1189<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) File to write readback to</param>
		/// <param name="checksum">(Optional) readback and calculate checksum; cannot be used with -file option</param>
		/// <param name="force">(Optional) force write of file</param>
		/// <param name="all">(Optional) specify readback of all memory locations</param>
		/// <param name="offset">(Optional) memory offset value Default: 0x0</param>
		/// <param name="format">(Optional) File format of readback file</param>
		/// <param name="datacount">(Optional) number of data units to readback Default: 0x0</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_cfgmem">(Optional) list of hardware cfgmems Default: current hardware cfgmem</param>
		public TTCL readback_hw_cfgmem(String file, bool? checksum = null, bool? force = null, bool? all = null, String offset = null, String format = null, Int32? datacount = null, bool? quiet = null, bool? verbose = null, TCLObjectList hw_cfgmem = null)
		{
			// TCL Syntax: readback_hw_cfgmem [-checksum] [-force] [-all] [-offset <arg>] -file <arg> [-format <arg>] [-datacount <arg>] [-quiet] [-verbose] [<hw_cfgmem>...]
			_tcl.Entry(_builder.readback_hw_cfgmem(file, checksum, force, all, offset, format, datacount, quiet, verbose, hw_cfgmem));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Readback hardware devices<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: readback_hw_device [-force] [-capture] [-readback_file &lt;arg&gt;] [-bin_file &lt;arg&gt;] [-quiet] [-verbose] [&lt;hw_device&gt;...]
		/// <br/>
		/// <para>
		/// Read bitstream data from the current hardware device and write it to the specified readback or<br/>
		/// binary file.<br/>
		/// The Vivado device programmer will readback bitstream data from the Xilinx device through the<br/>
		/// open target.<br/>
		/// IMPORTANT! If the bitstream on the hw_device is encrypted, readback is not permitted.<br/>
		/// This command returns the name of the readback file created, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1193<br/>
		/// </para>
		/// </summary>
		/// <param name="force">(Optional) force write of file</param>
		/// <param name="capture">(Optional) capture configuration readback data (ultrascale only)</param>
		/// <param name="readback_file">(Optional) readback file for rbd file output</param>
		/// <param name="bin_file">(Optional) bin file for bin file output</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_device">(Optional) list of hardware devices Default: current hardware device</param>
		/// <returns>hardware devices</returns>
		public TTCL readback_hw_device(bool? force = null, bool? capture = null, String readback_file = null, String bin_file = null, bool? quiet = null, bool? verbose = null, TCLObjectList hw_device = null)
		{
			// TCL Syntax: readback_hw_device [-force] [-capture] [-readback_file <arg>] [-bin_file <arg>] [-quiet] [-verbose] [<hw_device>...]
			_tcl.Entry(_builder.readback_hw_device(force, capture, readback_file, bin_file, quiet, verbose, hw_device));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Refresh hardware AXI object status.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: refresh_hw_axi [-quiet] [-verbose] [&lt;hw_axis&gt;...]
		/// <br/>
		/// <para>
		/// Refresh the STATUS properties of the hw_axi object with the values from the current hw_device.<br/>
		/// The refresh command takes the values from the status registers of the JTAG to AXI MASTER on<br/>
		/// the hardware device, and populates them into the appropriate properties of the hw_axi object in<br/>
		/// the hardware manager.<br/>
		/// Refresh the STATUS properties of the specified hw_axi objects. THE STATUS properties include:<br/>
		/// STATUS.AXI_READ_BUSY, STATUS.AXI_READ_DONE, STATUS.AXI_WRITE_BUSY,<br/>
		/// STATUS.AXI_WRITE_DONE, STATUS.BRESP, and STATUS.RRESP.<br/>
		/// This command updates the properties on the hw_axi object, but otherwise returns nothing if<br/>
		/// successful. The command returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1200<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_axis">(Required) List of hardware AXI objects.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_hw_axi(TCLObjectList hw_axis, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_hw_axi [-quiet] [-verbose] [<hw_axis>...]
			_tcl.Entry(_builder.refresh_hw_axi(hw_axis, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Refresh the status of the current hardware object. Inputs need to be any DDRMC object. At least<br/>
		/// one object is required. If properties are specified, but do not exist in the object, those properties<br/>
		/// will not be refreshed.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: refresh_hw_ddrmc [-regexp] [-properties &lt;args&gt;] [-quiet] [-verbose] &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// Refreshes the in-memory contents of all of the properties, or specified properties, of the<br/>
		/// specified Versal DDR Memory Controller (DDRMC) objects with values read from the current<br/>
		/// hardware device.<br/>
		/// The refresh command takes the values from the DDRMC object implemented on the hardware<br/>
		/// device, and populates them into the appropriate properties of the hw_ddrmc object in the Vivado<br/>
		/// hardware manager. If only certain properties are specified, then those properties are updated<br/>
		/// from the hw device.<br/>
		/// At least one object is required. If properties are specified that do not exist in the object, that<br/>
		/// property will not be refreshed.<br/>
		/// This command updates the properties on the hw_ddrmc object, but otherwise returns nothing if<br/>
		/// successful. The command returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example refreshes all of the properties of the DDRMC objects in the Vivado<br/>
		/// hardware manager with the properties from the current hw_device:<br/>
		/// refresh_hw_ddrmc -properties {PHY_RANKS} [lindex [get_hw_ddrmcs] 3]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1202<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_objects">(Required) hardware DDRMC objects</param>
		/// <param name="regexp">(Optional) Properties list contains full regular expressions</param>
		/// <param name="properties">(Optional) List of properties to refresh Default: All properties in object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_hw_ddrmc(TCLObject hw_objects, bool? regexp = null, TCLParameterList properties = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_hw_ddrmc [-regexp] [-properties <args>] [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.refresh_hw_ddrmc(hw_objects, regexp, properties, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Refresh a hardware device. Read device and core information from device.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: refresh_hw_device [-update_hw_probes &lt;arg&gt;] [-disable_done_check] [-force_poll] [-quiet] [-verbose] [&lt;hw_device&gt;]
		/// <br/>
		/// <para>
		/// Refreshes the in-memory view of the device by scanning for debug and IBERT cores on the<br/>
		/// specified hw_device object, and also reads a probe file when directed.<br/>
		/// The Hardware Manager in the Vivado Design Suite creates, deletes, or updates the hw_ila,<br/>
		/// hw_vio, hw_sio*, and hw_axi objects based on the core information found in the device, and also<br/>
		/// what is read from the probes file in the case of ILA and VIO debug cores.<br/>
		/// Use the refresh_hw_device after the program_hw_devices to keep the in-memory<br/>
		/// hardware debug objects in sync with the state of the actual cores on the physical device.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1204<br/>
		/// </para>
		/// </summary>
		/// <param name="update_hw_probes">(Optional) Update hardware probe information, read from probes file</param>
		/// <param name="disable_done_check">(Optional) Disable done check for refresh device</param>
		/// <param name="force_poll">(Optional) Force poll of all targets</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_device">(Optional) hardware device Default: current hardware device</param>
		public TTCL refresh_hw_device(String update_hw_probes = null, bool? disable_done_check = null, bool? force_poll = null, bool? quiet = null, bool? verbose = null, TCLObject hw_device = null)
		{
			// TCL Syntax: refresh_hw_device [-update_hw_probes <arg>] [-disable_done_check] [-force_poll] [-quiet] [-verbose] [<hw_device>]
			_tcl.Entry(_builder.refresh_hw_device(update_hw_probes, disable_done_check, force_poll, quiet, verbose, hw_device));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Refresh the status of the current hardware object. Inputs can be HBM or device hardware object.<br/>
		/// At least one object is required. If properties are specified that do not exist in the object, that<br/>
		/// property will not be refreshed.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: refresh_hw_hbm [-regexp] [-properties &lt;args&gt;] [-quiet] [-verbose] &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// Refreshes the in-memory view of all of the properties, or specified properties, of the specified<br/>
		/// HBM controller objects with values read from the current hardware device.<br/>
		/// The refresh command takes the values from the HBM controller implemented on the hardware<br/>
		/// device, and populates them into the appropriate properties of the hw_hbm object in the Vivado<br/>
		/// hardware manager. If only certain properties are specified, then those properties are updated<br/>
		/// from the hw device.<br/>
		/// At least one object is required. If properties are specified that do not exist in the object, that<br/>
		/// property will not be refreshed.<br/>
		/// This command updates the properties on the hw_hbm object, but otherwise returns nothing if<br/>
		/// successful. The command returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example refreshes all of the properties of the HBM controller in the Vivado<br/>
		/// hardware manager with the properties from the current hw_device:<br/>
		/// refresh_hw_hbm [lindex [get_hw_hbms] 1]<br/>
		/// The following example refreshes the specified property of the HBM controller from the current<br/>
		/// hw_device:<br/>
		/// refresh_hw_hbm -properties {MC2.INIT.AM_REPEAT_EN} [get_hw_hbms *HBM_2]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1206<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="regexp">(Optional) Properties list contains full regular expressions</param>
		/// <param name="properties">(Optional) List of properties to refresh Default: All properties in object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_hw_hbm(TCLObject hw_objects, bool? regexp = null, TCLParameterList properties = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_hw_hbm [-regexp] [-properties <args>] [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.refresh_hw_hbm(hw_objects, regexp, properties, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Refresh the status of the current hardware object. Inputs can be any mig, device, target, or server<br/>
		/// hardware object. At least one object is required. If properties are specified that do not exist in the<br/>
		/// object, that property will not be refreshed.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: refresh_hw_mig [-regexp] [-properties &lt;args&gt;] [-quiet] [-verbose] &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// Refreshes the in-memory view of all of the properties, or specified properties, of the specified<br/>
		/// hw_mig objects with values read from the current hardware device.<br/>
		/// The refresh command takes the values from the memory controller implemented on the<br/>
		/// hardware device, and populates them into the appropriate properties of the hw_mig debug core<br/>
		/// in the Vivado logic analyzer, or standalone Vivado Lab Edition.<br/>
		/// At least one object is required. If properties are specified that do not exist in the object, that<br/>
		/// property will not be refreshed.<br/>
		/// This command updates the properties on the hw_mig object, but otherwise returns nothing if<br/>
		/// successful. The command returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1208<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="regexp">(Optional) Properties list contains full regular expressions</param>
		/// <param name="properties">(Optional) List of properties to refresh Default: All properties in object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_hw_mig(TCLObject hw_objects, bool? regexp = null, TCLParameterList properties = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_hw_mig [-regexp] [-properties <args>] [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.refresh_hw_mig(hw_objects, regexp, properties, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Refresh the PCIe core properties, by reading from HW.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: refresh_hw_pcie [-quiet] [-verbose] &lt;hw_pcie&gt;
		/// <br/>
		/// <para>
		/// Refresh for the Peripheral Component Interconnect Express (PCIe) debug core object, hw_pcie,<br/>
		/// defined on the current hardware device.<br/>
		/// The customizable LogiCORE IP PCIe core for Xilinx ACAPs is designed for evaluating and<br/>
		/// monitoring the PCIe Link Training and Status State Machine (LTSSM) running on the Gigabit<br/>
		/// Transceivers (GTs). In the Vivado Hardware Manager, Versal PCIe soft cores implemented in the<br/>
		/// design, are represented as hw_pcie objects. You can use these PCIe debug cores to solve a range<br/>
		/// of debug and validation problems; from viewing the PCIe link information to the LTSSM state<br/>
		/// transition diagram.<br/>
		/// This command reads data from the PCIe debug core and updates the relevant properties in the<br/>
		/// hw_pcie object.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example refreshes the PCIe core at index 0<br/>
		/// refresh_hw_pcie [lindex [get_hw_pcies] 0]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1210<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_pcie">(Required) Hardware PCIe object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_hw_pcie(TCLObject hw_pcie, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_hw_pcie [-quiet] [-verbose] <hw_pcie>
			_tcl.Entry(_builder.refresh_hw_pcie(hw_pcie, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Refresh a connection to a hardware server<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: refresh_hw_server [-force_poll] [-quiet] [-verbose] [&lt;hw_server&gt;]
		/// <br/>
		/// <para>
		/// Refresh or reopen the connection to the current or specified hardware server.<br/>
		/// This command returns the connection messages from the hardware server, or returns an error if<br/>
		/// it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1212<br/>
		/// </para>
		/// </summary>
		/// <param name="force_poll">(Optional) Force poll of all targets</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_server">(Optional) hardware server</param>
		public TTCL refresh_hw_server(bool? force_poll = null, bool? quiet = null, bool? verbose = null, TCLObject hw_server = null)
		{
			// TCL Syntax: refresh_hw_server [-force_poll] [-quiet] [-verbose] [<hw_server>]
			_tcl.Entry(_builder.refresh_hw_server(force_poll, quiet, verbose, hw_server));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Refresh the status of the specified hardware objects. Inputs can be any serial I/O (except scan<br/>
		/// and sweep), device, target, or server hardware object. At least one object is required. If properties<br/>
		/// are specified that do not exist in the object, that property will not be refreshed.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: refresh_hw_sio [-regexp] [-properties &lt;args&gt;] [-quiet] [-verbose] &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// Refreshes the in-memory view of all of the properties, or specified properties, of the specified<br/>
		/// hw_sio objects with values read from the actual object on the hardware device.<br/>
		/// Specified objects can include any serial I/O object such as GTs, RXs, TXs, PLLs, or Commons,<br/>
		/// excluding hw_sio_scan and hw_sio_sweep objects. SIO objects also include device, target, or<br/>
		/// server hardware objects.<br/>
		/// The refresh_hw_sio command reads the values of the specified objects on the hardware<br/>
		/// device, and applies the value to the associated property of the IBERT core in the Hardware<br/>
		/// Manager.<br/>
		/// This command returns no feedback of its operation if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1214<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="regexp">(Optional) Properties list contains full regular expressions</param>
		/// <param name="properties">(Optional) List of properties to refresh Default: All properties in object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_hw_sio(TCLObject hw_objects, bool? regexp = null, TCLParameterList properties = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_hw_sio [-regexp] [-properties <args>] [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.refresh_hw_sio(hw_objects, regexp, properties, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Refresh the status of the current hardware object. Inputs need to be any Soft MC object. At least<br/>
		/// one object is required. If properties are specified, but do not exist in the object, those properties<br/>
		/// will not be refreshed.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: refresh_hw_softmc [-regexp] [-properties &lt;args&gt;] [-quiet] [-verbose] &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1216<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_objects">(Required) hardware Soft MC objects</param>
		/// <param name="regexp">(Optional) Properties list contains full regular expressions</param>
		/// <param name="properties">(Optional) List of properties to refresh Default: All properties in object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_hw_softmc(TCLObject hw_objects, bool? regexp = null, TCLParameterList properties = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_hw_softmc [-regexp] [-properties <args>] [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.refresh_hw_softmc(hw_objects, regexp, properties, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Refresh the status of the current hardware object. Inputs can be hw_server, hw_target,<br/>
		/// hw_device or hw_sysmon objects. At least one object is required. If properties are specified that<br/>
		/// do not exist in the object, that property will not be refreshed.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: refresh_hw_sysmon [-regexp] [-properties &lt;args&gt;] [-quiet] [-verbose] &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// Refresh the properties of the hw_sysmon object with the values on the system monitor (XADC)<br/>
		/// from the current hw_device.<br/>
		/// The refresh command takes the values from the status registers of the system monitor on the<br/>
		/// hardware device, and populates them into the appropriate properties of the hw_sysmon object in<br/>
		/// the hardware manager.<br/>
		/// TIP: The hw_sysmon object is automatically refreshed at the rate specified by the<br/>
		/// SYSMON_REFRESH_RATE_MS on the object.<br/>
		/// This command updates the properties on the hw_sysmon object, but otherwise returns nothing if<br/>
		/// successful. The command returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1217<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="regexp">(Optional) Properties list contains full regular expressions</param>
		/// <param name="properties">(Optional) List of properties to refresh Default: All properties in object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_hw_sysmon(TCLObject hw_objects, bool? regexp = null, TCLParameterList properties = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_hw_sysmon [-regexp] [-properties <args>] [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.refresh_hw_sysmon(hw_objects, regexp, properties, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Refresh a hardware target<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: refresh_hw_target [-force_poll] [-quiet] [-verbose] [&lt;hw_target&gt;]
		/// <br/>
		/// <para>
		/// Refresh the connection to the specified hardware target on the current hardware server, and<br/>
		/// reload the hw_target object in the Hardware Manager of the Vivado Design Suite. If no<br/>
		/// hw_target object is specified, the current_hw_target will be refreshed.<br/>
		/// The hardware target is a system board containing a JTAG chain of one or more Xilinx devices that<br/>
		/// you can program with a bitstream file, or use to debug your design. Connections between<br/>
		/// hardware targets on the system board and the Vivado Design Suite are managed by the Xilinx<br/>
		/// hardware server application, and the connect_hw_server command. Refer to Vivado Design<br/>
		/// Suite User Guide: Programming and Debugging (UG908) for a list of supported JTAG download<br/>
		/// cables and devices.<br/>
		/// Each hardware target can have one or more Xilinx devices to program, or to use for debugging<br/>
		/// purposes. The current device is specified or returned by the current_hw_device command.<br/>
		/// After specifying the current hardware target, you can open the connection through the hardware<br/>
		/// target, to the Xilinx FPGA using the open_hw_target command.<br/>
		/// refresh_hw_target scans the devices on the hardware target and creates, deletes, or<br/>
		/// updates the hw_device objects available through the target. Available devices are returned using<br/>
		/// the get_hw_devices command.<br/>
		/// This command returns a transcript of the refresh process, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1219<br/>
		/// </para>
		/// </summary>
		/// <param name="force_poll">(Optional) Force poll of all targets</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_target">(Optional) hardware target</param>
		public TTCL refresh_hw_target(bool? force_poll = null, bool? quiet = null, bool? verbose = null, TCLObject hw_target = null)
		{
			// TCL Syntax: refresh_hw_target [-force_poll] [-quiet] [-verbose] [<hw_target>]
			_tcl.Entry(_builder.refresh_hw_target(force_poll, quiet, verbose, hw_target));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Update hardware probe INPUT_VALUE and ACTIVITY_VALUE properties with values read from<br/>
		/// hardware VIO core(s).<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: refresh_hw_vio [-update_output_values] [-quiet] [-verbose] &lt;hw_vios&gt;...
		/// <br/>
		/// <para>
		/// Update the INPUT_VALUE and ACTIVITY_VALUE properties of the input probes of the specified<br/>
		/// VIO debug cores with values read from the hw_vio core on the hardware device.<br/>
		/// The Virtual Input/Output (VIO) debug core can both monitor and drive internal signals on a<br/>
		/// programmed Xilinx device in real time. The VIO core uses hardware probes, hw_probe objects, to<br/>
		/// monitor and drive signals on the device. Input probes monitor signals as inputs to the VIO core.<br/>
		/// Output probes drive signals to specified values from the VIO core.<br/>
		/// The refresh_hw_vio command reads the signal values at the input probes of the VIO debug<br/>
		/// core on the device, and applies the value to the INPUT_VALUE property of the hw_probe, and<br/>
		/// updates the ACTIVITY_VALUE property on the probe as well.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1221<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_vios">(Required) List of hardware VIO objects.</param>
		/// <param name="update_output_values">
		/// <para>
		/// (Optional)<br/>
		/// Update hardware probe OUTPUT_VALUE property with<br/>
		/// values read from VIO core(s).<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_hw_vio(TCLObjectList hw_vios, bool? update_output_values = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_hw_vio [-update_output_values] [-quiet] [-verbose] <hw_vios>...
			_tcl.Entry(_builder.refresh_hw_vio(hw_vios, update_output_values, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// De-select Pseudo Channel from Activity Monitor on the specified hardware HBM(s). Must<br/>
		/// specify the Memory Controller number first, follow by Pseudo Channel number.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_hw_hbm_pc [-quiet] [-verbose] &lt;mc_num&gt; &lt;pc_num&gt; &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// The remove_hw_hbm_pc command removes a memory channel (mc)/psuedo channel (pc) that<br/>
		/// has been previously added to an HBM activity monitor using the add_hw_hbm_pc command.<br/>
		/// TIP: The HBM activity monitor must not be running when adding or removing psuedo channels.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example removes the previously added psuedo channel from the HBM activity<br/>
		/// monitor, and then runs the activity monitor:<br/>
		/// remove_hw_hbm_pc 2 0 [get_hw_hbms *HBM_2]<br/>
		/// run_hw_hbm_amon [get_hw_hbms *HBM_2]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1256<br/>
		/// </para>
		/// </summary>
		/// <param name="mc_num">(Required) Memory Controller number to de-select: 0 to 7</param>
		/// <param name="pc_num">(Required) Pseudo Channel number to de-select: 0 or 1</param>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_hw_hbm_pc(TCLObject mc_num, TCLObject pc_num, TCLObject hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_hw_hbm_pc [-quiet] [-verbose] <mc_num> <pc_num> <hw_objects>
			_tcl.Entry(_builder.remove_hw_hbm_pc(mc_num, pc_num, hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove enumerated name-value pairs from a hw_probe enumeration.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_hw_probe_enum [-no_gui_update] [-list &lt;args&gt;] [-remove_all] [-quiet] [-verbose] &lt;hw_probe&gt;
		/// <br/>
		/// <para>
		/// Remove the enumerated name/value pairs defined on a specified hw_probe object.<br/>
		/// The enumerated names (ENUM property) are added to a hw_probe object using the<br/>
		/// add_hw_probe_enum command. This command removes those defined properties.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example removes the list of enumerated names from the specified hw_probe<br/>
		/// object:<br/>
		/// remove_hw_probe_enum -list {WHITE YELLOW GREY} \<br/>
		/// [get_hw_probes op1 -of_objects [current_hw_ila]]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1258<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_probe">(Required) ILA hardware probe object.</param>
		/// <param name="no_gui_update">(Optional) Defer GUI update.</param>
		/// <param name="list">(Optional) List of enumerated names to remove.</param>
		/// <param name="remove_all">(Optional) Remove the whole enumeration for a hardware probe. Default: 0</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_hw_probe_enum(TCLObject hw_probe, bool? no_gui_update = null, TCLParameterList list = null, bool? remove_all = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_hw_probe_enum [-no_gui_update] [-list <args>] [-remove_all] [-quiet] [-verbose] <hw_probe>
			_tcl.Entry(_builder.remove_hw_probe_enum(hw_probe, no_gui_update, list, remove_all, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove an existing hardware SIO link.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_hw_sio_link [-quiet] [-verbose] &lt;hw_sio_links&gt;
		/// <br/>
		/// <para>
		/// Removes the specified communication links between TX and RX objects on the GTs of the IBERT<br/>
		/// debug core defined on the current hardware device.<br/>
		/// Vivado Serial I/O analyzer is a link-based analyzer, which lets you link between any transmitter<br/>
		/// and receiver within the IBERT design. The links define the communication paths and protocols<br/>
		/// between transmitters and receivers of the GigaBit transceivers on the device. This command<br/>
		/// removes those links.<br/>
		/// This command returns a list of link objects on the IBERT debug core, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1260<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_sio_links">(Required) hardware SIO links</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_hw_sio_link(TCLObject hw_sio_links, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_hw_sio_link [-quiet] [-verbose] <hw_sio_links>
			_tcl.Entry(_builder.remove_hw_sio_link(hw_sio_links, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove an existing hardware SIO link group.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_hw_sio_linkgroup [-quiet] [-verbose] &lt;hw_sio_linkgroups&gt;
		/// <br/>
		/// <para>
		/// Removes the specified group that associates communication links between TX and RX objects on<br/>
		/// the GTs of the IBERT debug core defined on the current hardware device.<br/>
		/// Vivado Serial I/O analyzer is a link-based analyzer. The links define the communication paths and<br/>
		/// protocols between transmitters and receivers of the GigaBit transceivers on the device. Link<br/>
		/// groups, or hw_sio_linkgroup objects, let you associate links into related groups, to collectively<br/>
		/// configure properties and run scans.<br/>
		/// TIP: The remove_hw_sio_linkgroup command removes the specified association, but does not<br/>
		/// remove the underlying communication links. Us the remove_hw_sio_link command to remove those<br/>
		/// objects.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1262<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_sio_linkgroups">(Required) hardware SIO linkgroups</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_hw_sio_linkgroup(TCLObject hw_sio_linkgroups, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_hw_sio_linkgroup [-quiet] [-verbose] <hw_sio_linkgroups>
			_tcl.Entry(_builder.remove_hw_sio_linkgroup(hw_sio_linkgroups, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove an existing hardware SIO scan.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_hw_sio_scan [-quiet] [-verbose] &lt;hw_sio_scans&gt;
		/// <br/>
		/// <para>
		/// Remove the specified serial I/O analyzer scan object.<br/>
		/// This command returns nothing if successful, or returns an error if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1264<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_sio_scans">(Required) hardware SIO scans</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_hw_sio_scan(TCLObject hw_sio_scans, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_hw_sio_scan [-quiet] [-verbose] <hw_sio_scans>
			_tcl.Entry(_builder.remove_hw_sio_scan(hw_sio_scans, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Remove an existing hardware SIO sweep.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: remove_hw_sio_sweep [-quiet] [-verbose] &lt;hw_sio_sweeps&gt;
		/// <br/>
		/// <para>
		/// Remove the specified serial I/O analyzer sweep scan object.<br/>
		/// This command returns nothing if successful, or returns an error if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1266<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_sio_sweeps">(Required) hardware SIO sweeps</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_hw_sio_sweep(TCLObject hw_sio_sweeps, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_hw_sio_sweep [-quiet] [-verbose] <hw_sio_sweeps>
			_tcl.Entry(_builder.remove_hw_sio_sweep(hw_sio_sweeps, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report formatted hardware AXI Transaction data<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_hw_axi_txn [-w &lt;arg&gt;] [-t &lt;arg&gt;] [-quiet] [-verbose] &lt;hw_axi_txns&gt;...
		/// <br/>
		/// <para>
		/// Report the results of the specified AXI transactions on the JTAG to AXI Master, hw_axi.<br/>
		/// You can use this command after creating hw_axi_txn objects on existing hw_axi objects, and<br/>
		/// then running the hw_axi to exercise the defined transaction.<br/>
		/// The JTAG to AXI Master core can only be controlled using Tcl commands. You can issue AXI read<br/>
		/// and write transactions using the create_hw_axi_txns command. However, before issuing<br/>
		/// these commands, it is important to reset the JTAG to AXI Master core using the reset_hw_axi<br/>
		/// command.<br/>
		/// This command reports the transaction data in the specified format, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1369<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_axi_txns">(Required) hardware AXI Transaction object to report</param>
		/// <param name="w">(Optional) Output data bytes per output line. Default: 8</param>
		/// <param name="t">
		/// <para>
		/// (Optional)<br/>
		/// d[SIZE] signed decimal, SIZE bytes per integer, b[SIZE]<br/>
		/// binary, SIZE bytes per integer, o[SIZE] octal, SIZE bytes per<br/>
		/// integer, u[SIZE] unsigned decimal, SIZE bytes per integer,<br/>
		/// x[SIZE] hexadecimal, SIZE bytes per integer Default: x4 (4-<br/>
		/// bytes in hex)<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_hw_axi_txn(TCLObjectList hw_axi_txns, String w = null, String t = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_hw_axi_txn [-w <arg>] [-t <arg>] [-quiet] [-verbose] <hw_axi_txns>...
			_tcl.Entry(_builder.report_hw_axi_txn(hw_axi_txns, w, t, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Formatted report on Versal integrated and soft Memory Controllers' (DDRMCs) memory<br/>
		/// configurations, calibration status, stages, and window margins data.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_hw_ddrmc [-file &lt;arg&gt;] [-append] [-return_string] [-quiet] [-verbose] &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// Report formatted information on memory IP hardware configuration, calibration, and margin.<br/>
		/// Does not include the graphical margin scan plots that are available within the Vivado logic<br/>
		/// analyzer, or Vivado Lab Edition.<br/>
		/// In the Vivado tools, Versal memory controllers implemented into a design are associated with<br/>
		/// hw_ddrmc objects. These hw_ddrmc objects let you verify the calibration, read, and write<br/>
		/// window margins in your memory interface design. You can use the hardware manager GUI to<br/>
		/// check the calibration status, verify the read margin for both rising and falling edges of the clock,<br/>
		/// and write margin for both simple and complex patterns. You can also use an ILA and VIO core to<br/>
		/// verify the data integrity for the read and write operations.<br/>
		/// This command returns the reported data, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example generates the report on the hw_ddrmc objects and outputs them to the<br/>
		/// text file specified:<br/>
		/// report_hw_ddrmc -file C:/Data/ddrmc_report.txt [get_hw_ddrmcs]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1372<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_objects">(Required) hardware DDRMC objects</param>
		/// <param name="file">(Optional) file name (including full path) to output the report results to</param>
		/// <param name="append">(Optional) set this option to append the report results to a file</param>
		/// <param name="return_string">(Optional) set this option to have report results returned as a string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_hw_ddrmc(TCLObject hw_objects, String file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_hw_ddrmc [-file <arg>] [-append] [-return_string] [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.report_hw_ddrmc(hw_objects, file, append, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report formatted hardware MIG calibration status and margin data<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_hw_mig [-file &lt;arg&gt;] [-append] [-return_string] [-quiet] [-verbose] &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// Report formatted information on memory IP hardware configuration, calibration, and margin.<br/>
		/// Does not include the graphical margin scan plots that are available within the Vivado logic<br/>
		/// analyzer, or Vivado Lab Edition.<br/>
		/// In the Vivado tools, memory controllers implemented into a design are associated with hw_mig<br/>
		/// objects. These hw_mig objects let you verify the calibration, read, and write window margins in<br/>
		/// your memory interface design. You can use the hardware manager GUI to check the calibration<br/>
		/// status, verify the read margin for both rising and falling edges of the clock, and write margin for<br/>
		/// both simple and complex patterns, or DQS. You can also use an ILA core to verify the data<br/>
		/// integrity for the read and write operations.<br/>
		/// This command returns the reported data, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example generates the report on the hw_mig objects and outputs to the text file<br/>
		/// specified:<br/>
		/// report_hw_mig -file C:/Data/hw_mig_report.txt [get_hw_migs]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1374<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_objects">(Required) hardware mig objects</param>
		/// <param name="file">(Optional) file name (including full path) to output the report results to</param>
		/// <param name="append">(Optional) set this option to append the report results to a file</param>
		/// <param name="return_string">(Optional) set this option to have report results return as a string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_hw_mig(TCLObject hw_objects, String file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_hw_mig [-file <arg>] [-append] [-return_string] [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.report_hw_mig(hw_objects, file, append, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Formatted report for PCIe core.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_hw_pcie [-file &lt;arg&gt;] [-append] [-return_string] [-quiet] [-verbose] &lt;hw_pcie&gt;
		/// <br/>
		/// <para>
		/// Generate a report for the Peripheral Component Interconnect Express (PCIe) debug core object,<br/>
		/// hw_pcie, defined on the current hardware device.<br/>
		/// The customizable LogiCORE IP PCIe core for Xilinx ACAPs is designed for evaluating and<br/>
		/// monitoring the PCIe Link Training and Status State Machine (LTSSM) running on the Gigabit<br/>
		/// Transceivers (GTs). In the Vivado Hardware Manager, Versal PCIe soft cores implemented in the<br/>
		/// design, are represented as hw_pcie objects. You can use these PCIe debug cores to solve a range<br/>
		/// of debug and validation problems; from viewing the PCIe link info to the LTSSM state transition<br/>
		/// diagram.<br/>
		/// This command generates a report with general information about the PCIe core, the LTSSM state<br/>
		/// visitation status and the trace data for the LTSSM transition graph.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example generates a report for the PCIe core at index 0<br/>
		/// report_hw_pcie [lindex [get_hw_pcies] 0]<br/>
		/// The following example generates the report for the hw_pcie objects and outputs them to the text<br/>
		/// file specified<br/>
		/// report_hw_pcie -file C:/data/pcie_report.txt [get_hw_pcies]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1376<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_pcie">(Required) Hardware PCIe object</param>
		/// <param name="file">(Optional) File name (including full path) to output the report results to</param>
		/// <param name="append">(Optional) Append the report results to a file</param>
		/// <param name="return_string">(Optional) Return report results as a string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_hw_pcie(TCLObject hw_pcie, String file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_hw_pcie [-file <arg>] [-append] [-return_string] [-quiet] [-verbose] <hw_pcie>
			_tcl.Entry(_builder.report_hw_pcie(hw_pcie, file, append, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Formatted report on Versal soft Memory Controller cores' (Soft MCs) memory configurations,<br/>
		/// calibration status, stages, and window margins data.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_hw_softmc [-file &lt;arg&gt;] [-append] [-return_string] [-quiet] [-verbose] &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1378<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_objects">(Required) hardware Soft MC objects</param>
		/// <param name="file">(Optional) file name (including full path) to output the report results to</param>
		/// <param name="append">(Optional) set this option to append the report results to a file</param>
		/// <param name="return_string">(Optional) set this option to have report results returned as a string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_hw_softmc(TCLObject hw_objects, String file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_hw_softmc [-file <arg>] [-append] [-return_string] [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.report_hw_softmc(hw_objects, file, append, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Report properties on hardware objects<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: report_hw_targets [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This command returns properties related to the configuration of all hw_targets on the<br/>
		/// current_hw_server object. The information reported by this command includes:<br/>
		/// • Server Property Information: The properties of the current_hw_server, including HOST and<br/>
		/// PORT.<br/>
		/// • Target Property Information: Reported for each target on the hw_server, including NAME,<br/>
		/// FREQUENCY, DEVICE_COUNT, and SVF.<br/>
		/// • Device Property Information: Reported for each device on a specific hw_target, including<br/>
		/// PART, ID CODE, IR LENGTH, MASK, PROGRAMMING and PROBES FILE.<br/>
		/// This command returns the requested information if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports the property information for all targets on the connected<br/>
		/// hw_server:<br/>
		/// report_hw_targets<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1379<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>hardware objects</returns>
		public TTCL report_hw_targets(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_hw_targets [-quiet] [-verbose]
			_tcl.Entry(_builder.report_hw_targets(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Reset hardware AXI core state.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_hw_axi [-quiet] [-verbose] [&lt;hw_axis&gt;...]
		/// <br/>
		/// <para>
		/// Reset the STATUS properties of the specified hw_axi objects, or the current device.<br/>
		/// The reset_hw_axi restores the hw_axi core on the current device to a known state from which<br/>
		/// to begin running AXI transactions. The STATUS properties include:<br/>
		/// • STATUS.AXI_READ_BUSY<br/>
		/// • STATUS.AXI_READ_DONE<br/>
		/// • STATUS.AXI_WRITE_BUSY<br/>
		/// • STATUS.AXI_WRITE_DONE<br/>
		/// • STATUS.BRESP - Write Response Channel Response. Indicates results of the write transfer.<br/>
		/// • STATUS.RRESP - Read Response Channel Response. Indicates results of the read transfer.<br/>
		/// The command returns nothing if successful, and returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1484<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_axis">(Required) List of hardware AXI objects.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_hw_axi(TCLObjectList hw_axis, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_hw_axi [-quiet] [-verbose] [<hw_axis>...]
			_tcl.Entry(_builder.reset_hw_axi(hw_axis, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Reset hardware ILA control properties to default values.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_hw_ila [-reset_compare_values &lt;arg&gt;] [-quiet] [-verbose] [&lt;hw_ilas&gt;...]
		/// <br/>
		/// <para>
		/// Reset the trigger and capture configuration properties on the specified ILA debug core, and the<br/>
		/// TRIGGER_COMPARE_VALUE and CAPTURE_COMPARE_VALUE properties on the core's debug<br/>
		/// probes.<br/>
		/// Properties of the hw_ila object are configured with the set_property command in preparation<br/>
		/// for the run_hw_ila command to configure the ILA core on the hw_device. This command<br/>
		/// restores the user-configurable properties on the specified hw_ila to their default settings. Refer<br/>
		/// to the Vivado Design Suite User Guide: Programming and Debugging (UG908) for more information<br/>
		/// on these properties.<br/>
		/// The default properties are:<br/>
		/// • CONTROL.DATA_DEPTH is set to the MAX_DATA_DEPTH of the hw_ila object.<br/>
		/// • CONTROL.TRIGGER_POSITION 0<br/>
		/// • CONTROL.WINDOW_COUNT 1<br/>
		/// • CONTROL.TRIGGER_MODE BASIC_ONLY<br/>
		/// • CONTROL.TRIGGER_CONDITION AND<br/>
		/// • CONTROL.TRIG_OUT_MODE DISABLED<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • CONTROL.CAPTURE_MODE ALWAYS<br/>
		/// • CONTROL.CAPTURE_CONDITION AND<br/>
		/// • TRIGGER_COMPARE_VALUE eq1'bX (on the hw_probes)<br/>
		/// • CAPTURE_COMPARE_VALUE eq1'bX (on the hw_probes)<br/>
		/// This command operates silently, returning nothing if successful, or returning an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1486<br/>
		/// </para>
		/// </summary>
		/// <param name="reset_compare_values">(Optional) Reset associated hardware probe compare values.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_ilas">(Optional) List of hardware ILA objects. Default: Current hardware ILA</param>
		public TTCL reset_hw_ila(String reset_compare_values = null, bool? quiet = null, bool? verbose = null, TCLObjectList hw_ilas = null)
		{
			// TCL Syntax: reset_hw_ila [-reset_compare_values <arg>] [-quiet] [-verbose] [<hw_ilas>...]
			_tcl.Entry(_builder.reset_hw_ila(reset_compare_values, quiet, verbose, hw_ilas));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Reset the PCIe core.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_hw_pcie [-quiet] [-verbose] &lt;hw_pcie&gt;
		/// <br/>
		/// <para>
		/// Reset the Peripheral Component Interconnect Express (PCIe) debug core object, hw_pcie,<br/>
		/// defined on the current hardware device.<br/>
		/// The customizable LogiCORE IP PCIe core for Xilinx ACAPs is designed for evaluating and<br/>
		/// monitoring the PCIe Link Training and Status State Machine (LTSSM) running on the Gigabit<br/>
		/// Transceivers (GTs). In the Vivado Hardware Manager, Versal PCIe soft cores implemented in the<br/>
		/// design, are represented as hw_pcie objects. You can use these PCIe debug cores to solve a range<br/>
		/// of debug and validation problems; from viewing the PCIe link info to the LTSSM state transition<br/>
		/// diagram.<br/>
		/// This command resets the PCIe soft IP in hardware.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example resets PCIe core at index 0<br/>
		/// reset_hw_pcie [lindex [get_hw_pcies] 0]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1488<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_pcie">(Required) Hardware PCIe object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_hw_pcie(TCLObject hw_pcie, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_hw_pcie [-quiet] [-verbose] <hw_pcie>
			_tcl.Entry(_builder.reset_hw_pcie(hw_pcie, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Reset hardware VIO ACTIVITY_VALUE properties, for hardware probes associated with specified<br/>
		/// hardware VIO objects.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_hw_vio_activity [-quiet] [-verbose] &lt;hw_vios&gt;...
		/// <br/>
		/// <para>
		/// Resets the ACTIVITY_VALUE properties for all hardware probes on the specified VIO debug core<br/>
		/// objects. The ACTIVITY_VALUE property is used by the Vivado IDE to represent transitions on<br/>
		/// the input probes of the VIO debug cores.<br/>
		/// In addition to reading values from the VIO input probes, you can also monitor the activity of the<br/>
		/// VIO input probes. The ACTIVITY_VALUE property is used to indicate when the values on the<br/>
		/// VIO inputs have changed in between periodic updates to the Vivado IDE. Refer to the Vivado<br/>
		/// Design Suite User Guide: Programming and Debugging (UG908) for more information.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1490<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_vios">(Required) List of hardware VIO objects.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_hw_vio_activity(TCLObjectList hw_vios, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_hw_vio_activity [-quiet] [-verbose] <hw_vios>...
			_tcl.Entry(_builder.reset_hw_vio_activity(hw_vios, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Reset hardware VIO core outputs to initial values.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: reset_hw_vio_outputs [-quiet] [-verbose] &lt;hw_vios&gt;...
		/// <br/>
		/// <para>
		/// Reset the hardware VIO debug core outputs to their initial, or "reset" state.<br/>
		/// The Virtual Input/Output (VIO) debug core can both monitor and drive internal signals on a<br/>
		/// programmed Xilinx FPGA in real time. The VIO core uses hardware probes, hw_probe objects, to<br/>
		/// monitor and drive signals on the device. Input probes monitor signals as inputs to the VIO core.<br/>
		/// Output probes drive signals to specified values from the VIO core.<br/>
		/// The reset_hw_vio_outputs command restores the signal values at the output probes of the<br/>
		/// specified hw_vio debug cores to their initial values. This affects the signal on the hw_device, but<br/>
		/// does not affect the OUTPUT_VALUE property of the hw_probe objects.<br/>
		/// TIP: This command has the effect of resetting the initial value of the signal on the hw_vio debug core,<br/>
		/// without resetting the properties on the hw_probe object.<br/>
		/// This command returns nothing if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1492<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_vios">(Required) List of hardware VIO objects.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_hw_vio_outputs(TCLObjectList hw_vios, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_hw_vio_outputs [-quiet] [-verbose] <hw_vios>...
			_tcl.Entry(_builder.reset_hw_vio_outputs(hw_vios, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Resume Activity Monitor runs after paused for the specified hardware HBM(s)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: resume_hw_hbm_amon [-quiet] [-verbose] &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// The resume_hw_hbm_amon command restarts a running HBM activity monitor in the Vivado<br/>
		/// hardware manager that has been previously paused using the pause_hw_hbm_amon command.<br/>
		/// This command returns nothing when successful, or returns an error when it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example restarts the HBM activity monitor for the associated HBM core:<br/>
		/// resume_hw_hbm_amon [get_hw_hbms *HBM_2]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1537<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL resume_hw_hbm_amon(TCLObject hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: resume_hw_hbm_amon [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.resume_hw_hbm_amon(hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Run hardware AXI read/write transaction(s)and update transaction status in hw_axi object..<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: run_hw_axi [-queue] [-quiet] [-verbose] &lt;hw_axi_txns&gt;...
		/// <br/>
		/// <para>
		/// Run the AXI transactions defined on the specified JTAG to AXI Master core.<br/>
		/// AXI transactions are created with the create_hw_axi_txns command.<br/>
		/// Run the specified hardware AXI read/write transactions on the AXI bus, and update the<br/>
		/// transaction status on the associated hw_axi object.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1547<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_axi_txns">(Required) hardware AXI Transaction object to execute on the AXI bus.</param>
		/// <param name="queue">(Optional) Queue Transaction. Default: 0</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL run_hw_axi(TCLObjectList hw_axi_txns, bool? queue = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: run_hw_axi [-queue] [-quiet] [-verbose] <hw_axi_txns>...
			_tcl.Entry(_builder.run_hw_axi(hw_axi_txns, queue, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Enable Activity Monitor runs for the specified hardware HBM(s)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: run_hw_hbm_amon [-quiet] [-verbose] &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// The HBM activity monitor (amon) can be used to gain real-time access to performance<br/>
		/// monitoring and temperature sensors certain Xilinx® UltraScale+ devices that include an<br/>
		/// integrated High-Bandwidth Memory (HBM) controller. Refer to the LogiCore IP Product Guide:<br/>
		/// AXI High Bandwidth Memory Controller (PG276) for more information on this core. The HBM<br/>
		/// controller and memory stacks contain both performance counters and temperature sensors that<br/>
		/// can be accessed through the HBM activity monitor from within the Xilinx Vivado hardware<br/>
		/// manager. The HBM activity monitor displays read, write, and overall throughput of data, as well<br/>
		/// as the device temperature. The activity monitor displays, captures, and exports data to a CSV file<br/>
		/// when it is running.<br/>
		/// The run_hw_hbm_amon command runs an HBM activity monitor in the Vivado hardware<br/>
		/// manager that has been previously configured using the add_hw_hbm_pc command.<br/>
		/// This command returns the file path and name of a CSV file the collected data will be written to,<br/>
		/// or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example runs the HBM activity monitor for the associated HBM core:<br/>
		/// run_hw_hbm_amon [get_hw_hbms *HBM_2]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1549<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL run_hw_hbm_amon(TCLObject hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: run_hw_hbm_amon [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.run_hw_hbm_amon(hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Arm hardware ILAs.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: run_hw_ila [-trigger_now] [-compile_only] [-file &lt;arg&gt;] [-force] [-quiet] [-verbose] [&lt;hw_ilas&gt;...]
		/// <br/>
		/// <para>
		/// Arm triggers and run the specified hardware ILA debug cores on the current hardware device.<br/>
		/// The Integrated Logic Analyzer (ILA) debug core lets you perform in-system debug of<br/>
		/// implemented designs, or design bitstreams, on a programmed Xilinx FPGA. The ILA core includes<br/>
		/// many advanced features of modern logic analyzers, including boolean trigger equations, and edge<br/>
		/// transition triggers. You can use the ILA core to probe specific signals of the design, to trigger on<br/>
		/// programmed hardware events, and capture data samples from the Xilinx FPGA in real-time. Refer<br/>
		/// to LogiCORE IP Integrated Logic Analyzer (PG172) for details of the ILA core.<br/>
		/// You can add ILA debug cores into the RTL source files of a design, or in the synthesized netlist<br/>
		/// using the create_debug_core command. Refer to the Vivado Design Suite User Guide: Vivado<br/>
		/// Programming and Debugging (UG908) for more information on adding debug cores and signal<br/>
		/// probes to the design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Debug cores and probes are written to a probes file (.ltx) using the write_debug_probes<br/>
		/// command, and associated with the hardware device along with the bitstream file (.bit) using<br/>
		/// the PROBES.FILE and PROGRAM.FILE properties of the hw_device object. The hardware device<br/>
		/// is programmed using the program_hw_devices command. The ILA debug cores in the design<br/>
		/// are accessible from the Hardware Manager using the get_hw_ilas command. The debug<br/>
		/// probes assigned to the ILA debug cores can be returned with the get_hw_probes command.<br/>
		/// The steps to debug your design in hardware using an ILA debug core are:<br/>
		/// 1. Connect to the hardware server and target using connect_hw_server and<br/>
		/// open_hw_target.<br/>
		/// 2. Program the FPGA with the bitstream (.bit) and probes (.ltx) files using<br/>
		/// program_hw_devices.<br/>
		/// 3. Set up the ILA debug core trigger events and data capture controls using set_property to<br/>
		/// configure properties of the ILA.<br/>
		/// 4. Arm the ILA debug core triggers on the Xilinx FPGA using run_hw_ila. When a trigger<br/>
		/// event occurs, or the capture condition is met, the ILA capture buffer is filled.<br/>
		/// 5. Uploaded sampled data from the hw_device into a Vivado logic analyzer hw_ila_data object<br/>
		/// using upload_hw_ila_data.<br/>
		/// 6. View the captured data in the Waveform window of the Vivado logic analyzer feature using<br/>
		/// display_hw_ila_data.<br/>
		/// You can set up an ILA debug core to trigger on specific events or conditions at the debug probes,<br/>
		/// and to capture data under specific conditions, using CONTROL properties on the hw_ila object.<br/>
		/// You set these properties with the set_property command. Refer to the Vivado Design Suite<br/>
		/// User Guide: Vivado Programming and Debugging (UG908) for more information on setting<br/>
		/// properties to configure debug cores and signal probes to monitor the design.<br/>
		/// RECOMMENDED: The Vivado IDE provides a graphical interface to configure hw_ila and hw_probes for<br/>
		/// trigger and capture. You can use the Vivado IDE to see the properties needed to configure and run the<br/>
		/// hw_ila.<br/>
		/// The specific properties on the hw_ila you can use to configure a debug core include the<br/>
		/// following:<br/>
		/// • CONTROL.DATA_DEPTH - Defaults to the MAX_DATA_DEPTH of the ILA debug core, which<br/>
		/// was set when the debug core was created or inserted into the design. The data depth defines<br/>
		/// the number of data samples the hw_ila object can capture in a data window. Set the data<br/>
		/// depth as an integer which is a power of two, from 1 to the maximum data depth<br/>
		/// (MAX_DATA_DEPTH) of the hw_ila.<br/>
		/// Note: The value of DATA_DEPTH is related to CONTROL.WINDOW_COUNT by the equation:<br/>
		/// DATA_DEPTH * WINDOW_COUNT = MAX_DATA_DEPTH<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • CONTROL.WINDOW_COUNT - Lets you divide the MAX_DATA_DEPTH of the ILA core into<br/>
		/// a number of data windows to store sample data from multiple trigger events. In the case of 10<br/>
		/// data windows for example, the first window will be filled at the first trigger event, and each<br/>
		/// subsequent window will be filled upon subsequent triggering events or capture conditions.<br/>
		/// • CONTROL.TRIGGER_POSITION - An integer value related to the DATA_DEPTH. Positions the<br/>
		/// trigger event in the sample data buffer. For a DATA_DEPTH of 1024, position 0 refers to the<br/>
		/// first (or left-most) data buffer and 1023 refers to the last (or right-most) data buffer. The<br/>
		/// TRIGGER_POSITION lets you capture sample data ahead of the trigger event. For instance,<br/>
		/// with a DATA_DEPTH of 256, a TRIGGER_POSITION of 100 allows you to capture 100 data<br/>
		/// samples ahead of the trigger, and 155 data samples at and after the trigger event.<br/>
		/// Note: In the case of run_hw_ila -trigger_now 1, the TRIGGER_POSITION merely positions the<br/>
		/// trigger mark in the Vivado logic analyzer waveform window. Because the trigger event is immediate,<br/>
		/// there is no time to capture data samples ahead of the trigger.<br/>
		/// • CONTROL.TRIGGER_MODE - Valid values include:<br/>
		/// ○ BASIC_ONLY - The trigger condition is the result of a Boolean equation using the<br/>
		/// TRIGGER_CONDITION to evaluate the values on each of the associated ILA probes.<br/>
		/// ○ BASIC_OR_TRIG_IN - The ILA core is triggered by a Boolean equation considering probe<br/>
		/// values, or by the TRIG_IN port on the core.<br/>
		/// ○ ADVANCED_ONLY - The ILA core is configured to have advanced trigger capabilities<br/>
		/// defined in a user-defined Trigger State Machine (TSM).<br/>
		/// ○ ADVANCED_OR_TRIG_IN - The ILA core is triggered by the TSM or by the TRIG_IN port<br/>
		/// on the core.<br/>
		/// ○ TRIG_IN_ONLY - The ILA core is triggered only by the TRIG_IN port on the core.<br/>
		/// • CONTROL.TRIGGER_CONDITION - Defines a Boolean equation which evaluates comparators<br/>
		/// on participating probes on the ILA debug core. When the condition evaluates to true, the<br/>
		/// BASIC trigger mode is satisfied. Valid values include:<br/>
		/// ○ AND - Trigger condition is "true" if all participating probe comparators evaluate "true",<br/>
		/// otherwise trigger condition is "false".<br/>
		/// ○ NAND - Trigger condition is "true" if at least one participating probe comparator evaluates<br/>
		/// "false", otherwise trigger condition is "false".<br/>
		/// ○ OR - Trigger condition is "true" if at least one participating probe comparator evaluates<br/>
		/// "true", otherwise trigger condition is "false".<br/>
		/// ○ NOR - Trigger condition is "true" if all participating probe comparators evaluate "false",<br/>
		/// otherwise trigger condition is "false".<br/>
		/// Note: The evaluation of the probes participating in the trigger condition is determined by the<br/>
		/// TRIGGER_COMPARE_VALUE property assigned to the hw_probe object, as returned by<br/>
		/// get_hw_probes. If the TRIGGER_COMPARE_VALUE is 'X' then it is not participating in the trigger<br/>
		/// condition.<br/>
		/// • CONTROL.TSM_FILE - Specify the path to a file defining a Trigger Finite State Machine (TSM)<br/>
		/// to be used for advanced trigger handling.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • CONTROL.TRIG_OUT_MODE - Used to transition the TRIG_OUT port on the ILA core to be<br/>
		/// used to drive the TRIG_IN port on other ILA cores. Valid values include:<br/>
		/// ○ DISABLED - Disable the TRIG_OUT port on the ILA core.<br/>
		/// ○ TRIGGER_ONLY - Transition the TRIG_OUT port when the trigger conditions have been<br/>
		/// satisfied.<br/>
		/// ○ TRIG_IN_ONLY - Transition the TRIG_OUT when the TRIG_IN signal transitions. Use this to<br/>
		/// pass the trigger event along a chain of ILA cores.<br/>
		/// ○ TRIGGER_OR_TRIG_IN - Transition the TRIG_OUT when either the trigger conditions are<br/>
		/// satisfied, or the TRIG_IN transitions.<br/>
		/// • CONTROL.CAPTURE_MODE - Valid values include ALWAYS or BASIC. Capture and store a<br/>
		/// data sample on the debug core ALWAYS during a given clock cycle, or only if the<br/>
		/// CAPTURE_CONDITION evaluates to "true" (BASIC).<br/>
		/// • CONTROL.CAPTURE_CONDITION - Defines a Boolean equation for participating probe<br/>
		/// comparators on the ILA debug core that must evaluate to TRUE to meet the data capture<br/>
		/// condition. When the capture condition evaluates to true, the BASIC capture mode is satisfied.<br/>
		/// Valid values include:<br/>
		/// ○ AND - Capture condition is "true" if all participating probe comparators evaluate "true",<br/>
		/// otherwise capture condition is "false".<br/>
		/// ○ NAND - Capture condition is "true" if at least one participating probe comparator evaluates<br/>
		/// "false", otherwise capture condition is "false".<br/>
		/// ○ OR - Capture condition is "true" if at least one participating probe comparator evaluates<br/>
		/// "true", otherwise capture condition is "false".<br/>
		/// ○ NOR - Capture condition is "true" if all participating probe comparators evaluate "false",<br/>
		/// otherwise capture condition is "false".<br/>
		/// Note: The evaluation of the probes participating in the capture condition is determined by the<br/>
		/// CAPTURE_COMPARE_VALUE property assigned to the hw_probe object, as returned by<br/>
		/// get_hw_probes. If the CAPTURE_COMPARE_VALUE is 'X' then it is not participating in the trigger<br/>
		/// condition.<br/>
		/// TIP: There are other properties on the ILA core that also determine the operation of the core, but they are<br/>
		/// not user-configurable.<br/>
		/// With the ILA core configured, you can use the run_hw_ila command to arm the ILA cores on<br/>
		/// the target part. When this command is run, the trigger configurations defined in the hw_ila and<br/>
		/// hw_probe objects are written to the target Xilinx FPGA (hw_device) and arms the ILA core or<br/>
		/// cores on the device.<br/>
		/// With the hw_ila armed and running, the wait_on_hw_ila command stops your Tcl script to<br/>
		/// wait for the data sample buffers to be populated with captured data. When the memory of the<br/>
		/// ILA core is full on the physical hw_device, the wait_on_hw_ila command returns, and your Tcl<br/>
		/// script resumes.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// You can use upload_hw_ila_data to upload the captured data from the physical memory of<br/>
		/// the hw_device into a hw_ila_data object in the Vivado logic analyzer. Then view the ILA data in<br/>
		/// the waveform window of the Vivado logic analyzer using display_hw_ila_data, and write<br/>
		/// the data for use in external tools using the write_hw_ila_data command.<br/>
		/// You can also immediately trigger the probes on the hw_device using the -trigger_now option,<br/>
		/// to capture data from the device right away, rather than waiting for trigger events or capture<br/>
		/// conditions to be met over time.<br/>
		/// You can use reset_hw_ila to restore the CONTROL properties of the ILA debug core to their<br/>
		/// default setting, and reset the probe comparator values to 'X'.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1551<br/>
		/// </para>
		/// </summary>
		/// <param name="trigger_now">(Optional) Trigger and capture immediately.</param>
		/// <param name="compile_only">(Optional) Test only compile trigger state machine file but do not upload.</param>
		/// <param name="file">(Optional) Trigger at startup file name. Command will not arm ILA core.</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_ilas">(Optional) hardware ILAs Default: Current hardware ILA</param>
		public TTCL run_hw_ila(bool? trigger_now = null, bool? compile_only = null, String file = null, bool? force = null, bool? quiet = null, bool? verbose = null, TCLObjectList hw_ilas = null)
		{
			// TCL Syntax: run_hw_ila [-trigger_now] [-compile_only] [-file <arg>] [-force] [-quiet] [-verbose] [<hw_ilas>...]
			_tcl.Entry(_builder.run_hw_ila(trigger_now, compile_only, file, force, quiet, verbose, hw_ilas));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Run hardware SIO scans.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: run_hw_sio_scan [-quiet] [-verbose] &lt;hw_sio_scans&gt;
		/// <br/>
		/// <para>
		/// Run the specified serial I/O analyzer link scan.<br/>
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the<br/>
		/// specialized Eye Scan hardware of Xilinx UltraScale devices or 7 series FPGAs. The Vivado serial<br/>
		/// I/O analyzer feature lets you to create, run, and save link scans.<br/>
		/// This command creates and returns a link scan object that you can use with the<br/>
		/// run_hw_sio_scan command to run analysis on the specified links, or GT receivers. You can<br/>
		/// also save the scan to disk using the write_hw_sio_scan command.<br/>
		/// This command run analysis on the specified scan objects. If running in a Tcl script, you can<br/>
		/// suspend the script while the scan completes using the wait_on_hw_sio_scan command. You<br/>
		/// can stop a running scan using the stop_hw_sio_scan command.<br/>
		/// You can save the scan to disk using the write_hw_sio_scan command.<br/>
		/// You can remove the created scan object using remove_hw_sio_scan.<br/>
		/// This command returns the hw_sio_scan object, or returns an error if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1557<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_sio_scans">(Required) hardware SIO scans</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL run_hw_sio_scan(TCLObject hw_sio_scans, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: run_hw_sio_scan [-quiet] [-verbose] <hw_sio_scans>
			_tcl.Entry(_builder.run_hw_sio_scan(hw_sio_scans, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Run hardware SIO sweeps.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: run_hw_sio_sweep [-quiet] [-verbose] &lt;hw_sio_sweeps&gt;
		/// <br/>
		/// <para>
		/// Run a serial I/O analyzer link sweep scan to run multiple scans across a range of values.<br/>
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the<br/>
		/// specialized features of Xilinx UltraScale devices or 7 series FPGAs. It can also be helpful to run<br/>
		/// multiple scans on a the link with different configuration settings for the GTs. This can help you<br/>
		/// determine which settings are best for your design. The Vivado serial I/O analyzer feature enables<br/>
		/// you to define, run, and save link sweeps, or collections of link scans run across a range of values.<br/>
		/// This command run analysis on the specified sweep scan objects. If running in a Tcl script, you can<br/>
		/// suspend the script while the sweep scan completes using the wait_on_hw_sio_sweep<br/>
		/// command. You can stop a running sweep scan using the stop_hw_sio_sweep command.<br/>
		/// You can save the sweep scan to disk using the write_hw_sio_sweep command.<br/>
		/// You can remove the created scan object using remove_hw_sio_sweep.<br/>
		/// This command returns the hw_sio_sweep object, or returns an error if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1559<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_sio_sweeps">(Required) hardware SIO sweeps</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL run_hw_sio_sweep(TCLObject hw_sio_sweeps, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: run_hw_sio_sweep [-quiet] [-verbose] <hw_sio_sweeps>
			_tcl.Entry(_builder.run_hw_sio_sweep(hw_sio_sweeps, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// change to a stable state of a specified transition<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: run_state_hw_jtag [-state &lt;args&gt;] [-quiet] [-verbose] &lt;stable_state&gt;
		/// <br/>
		/// <para>
		/// Transition the hw_jtag object of the current hardware target to the specified TAP stable state.<br/>
		/// A hw_jtag object is created by the Hardware Manager feature of the Vivado Design Suite when a<br/>
		/// hardware target is opened in JTAG mode using the open_hw_target -jtag_mode command.<br/>
		/// The run_state_hw_jtag command specifies:<br/>
		/// • An ending or target TAP stable state to transition to.<br/>
		/// • An optional state path list to transition through to get from the current state to the target<br/>
		/// state.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// If an optional -state path list is defined, then the state list must contain all states needed to<br/>
		/// reach the stable state, or the command will return an error. If no state path list is defined, then<br/>
		/// the command will transition from the current state to the target state according to the state<br/>
		/// transition paths defined in the following table:<br/>
		/// Current Target State Transition Path<br/>
		/// State State<br/>
		/// DRPAUSE RESET DRPAUSE -&gt; DREXIT2 -&gt; DRUPDATE -&gt; DRSELECT -&gt;<br/>
		/// IRSELECT-&gt; RESET<br/>
		/// DRPAUSE IDLE DRPAUSE -&gt; DREXIT2 -&gt; DRUPDATE -&gt; IDLE<br/>
		/// DRPAUSE DRPAUSE DRPAUSE -&gt; DREXIT2 -&gt; DRUPDATE -&gt; DRSELECT -&gt;<br/>
		/// DRCAPTURE -&gt; DREXIT1 -&gt; DRPAUSE<br/>
		/// DRPAUSE IRPAUSE DRPAUSE -&gt; DREXIT2 -&gt; DRUPDATE -&gt; DRSELECT -&gt;<br/>
		/// IRSELECT -&gt; IRCAPTURE -&gt; IREXIT12 -&gt; IRPAUSE<br/>
		/// IDLE RESET IDLE -&gt; DRSELECT -&gt; IRSELECT -&gt; RESET<br/>
		/// IDLE IDLE IDLE<br/>
		/// IDLE DRPAUSE IDLE -&gt; DRSELECT -&gt; DRCAPTURE -&gt; DREXIT1 -&gt;<br/>
		/// DRPAUSE<br/>
		/// IDLE IRPAUSE IDLE -&gt; DRPAUSE -&gt; IRSELECT -&gt;IRCAPTURE -&gt;<br/>
		/// IREXIT1 -&gt; IRPAUSE<br/>
		/// IRPAUSE RESET IRPAUSE -&gt; IREXIT2 -&gt; IRUPDATE -&gt; DRSELECT -&gt;<br/>
		/// IRSELECT -&gt; RESET<br/>
		/// IRPAUSE IDLE IRPAUSE -&gt; IREXIT2 -&gt; IRUPDATE -&gt; IDLE<br/>
		/// IRPAUSE DRPAUSE IRPAUSE -&gt; IREXIT2 -&gt; IRUPDATE -&gt; DRSELECT -&gt;<br/>
		/// DRCAPTURE -&gt; DREXIT1 -&gt; DRPAUSE<br/>
		/// IRPAUSE IRPAUSE IRPAUSE -&gt; IREXIT2 -&gt; IRUPDATE -&gt; DRSELECT -&gt;<br/>
		/// IRSELECT -&gt; IRCAPTURE -&gt; IREXIT1 -&gt; IRPAUSE<br/>
		/// RESET RESET RESET<br/>
		/// RESET IDLE RESET -&gt; IDLE<br/>
		/// RESET DRPAUSE RESET -&gt; IDLE -&gt; DRSELECT -&gt; DRCAPTURE -&gt;<br/>
		/// DREXIT1 -&gt; DRPAUSE<br/>
		/// RESET IRPAUSE RESET -&gt; IDLE -&gt; DRSELECT -&gt; IRSELECT -&gt;<br/>
		/// IRCAPTURE -&gt; IREXIT1 -&gt; IRPAUSE<br/>
		/// This command returns the target stable state when successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1561<br/>
		/// </para>
		/// </summary>
		/// <param name="stable_state">
		/// <para>
		/// (Required)<br/>
		/// valid stable_state - valid stable states IDLE, RESET, IRPAUSE,<br/>
		/// and DRPAUSE<br/>
		/// </para>
		/// </param>
		/// <param name="state">(Optional) valid state path sequence to stable_state</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>hardware JTAG</returns>
		public TTCL run_state_hw_jtag(TCLObject stable_state, TCLParameterList state = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: run_state_hw_jtag [-state <args>] [-quiet] [-verbose] <stable_state>
			_tcl.Entry(_builder.run_state_hw_jtag(stable_state, state, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Forces IEEE 1149.1 TAP state machine to a stable state for a specified wait period<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: runtest_hw_jtag [-wait_state &lt;arg&gt;] [-end_state &lt;arg&gt;] [-sec &lt;arg&gt;] [-max_wait &lt;arg&gt;] [-tck &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// Specify a wait operation for the hw_jtag object state machine which defines:<br/>
		/// • Which TAP stable state to go to perform the wait operation.<br/>
		/// • A wait time expressed as:<br/>
		/// ○ 'n' TCK cycles, where 'n' is a 32-bit unsigned decimal number.<br/>
		/// ○ A minimum and optionally maximum time in seconds to stay in the wait state, with<br/>
		/// min/max times specified as unsigned integers or real numbers.<br/>
		/// • The TAP stable state to go after the wait operation has completed.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The default values for -wait_state and -end_state are IDLE. If a non-IDLE wait_state or<br/>
		/// end_state are defined, then the hw_jtag object will first transition to the specified wait_state<br/>
		/// before starting the wait operation. Once the wait time has elapsed, the hw_jtag object transitions<br/>
		/// to the specified end_state. When the wait_state and/or end_state are specified by the<br/>
		/// runtest_hw_jtag command, subsequent commands will use the same wait_state/end_state<br/>
		/// unless they are changed.<br/>
		/// This command returns the end stable state, or returns an error if it fails.<br/>
		/// Note: If the command cannot meet the wait time specification, then it will raise an exception that can be<br/>
		/// trapped by the Tcl catch command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1564<br/>
		/// </para>
		/// </summary>
		/// <param name="wait_state">
		/// <para>
		/// (Optional)<br/>
		/// valid stable_state - valid stable states IDLE, RESET, IRPAUSE,<br/>
		/// and DRPAUSE<br/>
		/// </para>
		/// </param>
		/// <param name="end_state">
		/// <para>
		/// (Optional)<br/>
		/// valid stable_state - valid stable states IDLE, RESET, IRPAUSE,<br/>
		/// and DRPAUSE<br/>
		/// </para>
		/// </param>
		/// <param name="sec">(Optional) Number of seconds to wait in wait_state</param>
		/// <param name="max_wait">(Optional) Maximum Number of seconds to wait in wait_state - max timeout</param>
		/// <param name="tck">
		/// <para>
		/// (Optional)<br/>
		/// Number of TCK cycles to wait in wait_state Default: Number<br/>
		/// of TCK cycles to wait in wait_state<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL runtest_hw_jtag(String wait_state = null, String end_state = null, Int32? sec = null, Int32? max_wait = null, Int32? tck = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: runtest_hw_jtag [-wait_state <arg>] [-end_state <arg>] [-sec <arg>] [-max_wait <arg>] [-tck <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.runtest_hw_jtag(wait_state, end_state, sec, max_wait, tck, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Perform shift DR on 'hw_jtag'.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: scan_dr_hw_jtag [-tdi &lt;arg&gt;] [-tdo &lt;arg&gt;] [-mask &lt;arg&gt;] [-smask &lt;arg&gt;] [-quiet] [-verbose] &lt;length&gt;
		/// <br/>
		/// <para>
		/// The scan_dr_hw_jtag command specifies a scan pattern to be scanned into the JTAG<br/>
		/// interface target data register.<br/>
		/// The command targets a hw_jtag object which is created when the hw_target is opened in JTAG<br/>
		/// mode through the use of the open_hw_target -jtag_mode command.<br/>
		/// When targeting the hw_jtag object prior to shifting the scan pattern specified in the<br/>
		/// scan_dr_hw_jtag command, the last defined header property (HDR) will be pre-pended to the<br/>
		/// beginning of the specified data pattern, and the last defined trailer property (TDR) will be<br/>
		/// appended to the end of the data pattern.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The options can be specified in any order, but can only be specified once. The number of bits<br/>
		/// represented by the hex strings specified for -tdi, -tdo, -mask, or -smask cannot be greater<br/>
		/// than the maximum specified by &lt;length&gt;. Leading zeros are assumed for a hex string if the<br/>
		/// number of bits represented by the hex strings specified is less than the &lt;length&gt;.<br/>
		/// When shifting the data bits to the target data register, the scan_dr_hw_jtag command moves<br/>
		/// the JTAG TAP from the current stable state to the DRSHIFT state according to the state<br/>
		/// transition table below:<br/>
		/// Current State Transitions to get to DRSHIFT state<br/>
		/// RESET IDLE -&gt; DRSELECT -&gt; DRCAPTURE -&gt; DRSHIFT<br/>
		/// IDLE DRSELECT -&gt; DRCAPTURE -&gt;<br/>
		/// DRSHIFT<br/>
		/// IRPAUSE IREXIT2 -&gt; IRUPDATE -&gt; DRSELECT -&gt; DRCAPTURE -&gt;<br/>
		/// DRSHIFT<br/>
		/// DRPAUSE DREXIT2 -&gt;<br/>
		/// DRSHIFT<br/>
		/// DRPAUSE* DREXIT2 -&gt; DRUPDATE -&gt; DRSELECT -&gt; DRCAPTURE -&gt; DRSHIFT<br/>
		/// Note: * With -force_update option set.<br/>
		/// After the last data bit is shifted into the target data register, the scan_dr_hw_jtag command<br/>
		/// moves the JTAG TAP to the IDLE state, or to the stable state defined by the<br/>
		/// run_state_hw_jtag command.<br/>
		/// The scan_dr_hw_jtag command returns a hex array containing captured TDO data from the<br/>
		/// hw_jtag, or returns an error if it fails.<br/>
		/// The command raises an error that can be trapped by the Tcl catch command if TDO data from<br/>
		/// the hw_jtag does not match specified -tdo argument.<br/>
		/// TIP: If -tdo and -mask arguments are specified, then the mask is applied to the -tdo option and the<br/>
		/// hw_jtag TDO data returned before comparing the two.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1580<br/>
		/// </para>
		/// </summary>
		/// <param name="length">(Required) Number of bits to be scanned.</param>
		/// <param name="tdi">(Optional) Hex value to be scanned into the target</param>
		/// <param name="tdo">(Optional) Hex value to be compared against the scanned value</param>
		/// <param name="mask">(Optional) Hex value mask applied when comparing TDO values</param>
		/// <param name="smask">(Optional) Hex value mask applied to TDI value</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>hardware TDO</returns>
		public TTCL scan_dr_hw_jtag(TCLObject length, String tdi = null, String tdo = null, String mask = null, String smask = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: scan_dr_hw_jtag [-tdi <arg>] [-tdo <arg>] [-mask <arg>] [-smask <arg>] [-quiet] [-verbose] <length>
			_tcl.Entry(_builder.scan_dr_hw_jtag(length, tdi, tdo, mask, smask, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Perform shift IR on 'hw_jtag'.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: scan_ir_hw_jtag [-tdi &lt;arg&gt;] [-tdo &lt;arg&gt;] [-mask &lt;arg&gt;] [-smask &lt;arg&gt;] [-quiet] [-verbose] &lt;length&gt;
		/// <br/>
		/// <para>
		/// The scan_ir_hw_jtag command specifies a scan pattern to be scanned into the JTAG<br/>
		/// interface target instruction register.<br/>
		/// The command targets a hw_jtag object which is created when the hw_target is opened in JTAG<br/>
		/// mode through the use of the open_hw_target -jtag_mode command.<br/>
		/// When targeting the hw_jtag object prior to shifting the scan pattern specified in the<br/>
		/// scan_ir_hw_jtag command, the last defined header property (HIR) will be pre-pended to the<br/>
		/// beginning of the specified data pattern, and the last defined trailer property (TIR) will be<br/>
		/// appended to the end of the data pattern.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The options can be specified in any order, but can only be specified once. The number of bits<br/>
		/// represented by the hex strings specified for -tdi, -tdo, -mask, or -smask cannot be greater<br/>
		/// than the maximum specified by &lt;length&gt;. Leading zeros are assumed for a hex string if the<br/>
		/// number of bits represented by the hex strings specified is less than the &lt;length&gt;.<br/>
		/// When shifting the bits into the target instruction register, the scan_ir_hw_jtag command<br/>
		/// moves the JTAG TAP from the current stable state to the IRSHIFT state according to the state<br/>
		/// transition table below:<br/>
		/// Current Transitions to get to<br/>
		/// State IRSHIFT state<br/>
		/// RESET IDLE &gt; DRSELECT &gt; IRSELECT &gt; IRCAPTURE &gt; IRSHIFT<br/>
		/// IDLE IRSELECT &gt; IRCAPTURE &gt; IRSHIFT<br/>
		/// DRPAUSE DREXIT2 &gt; DRUPDATE &gt; DRSELECT &gt; IRSELECT &gt; IRCAPTURE &gt; IRSHIFT<br/>
		/// IRPAUSE IREXIT2 &gt; IRSHIFT<br/>
		/// IRPAUSE* IREXIT2 &gt; IRUPDATE &gt; DRSELECT &gt; IRSELECT &gt; IRCAPTURE &gt; IRSHIFT<br/>
		/// Note: * With -force_update option set.<br/>
		/// After the last data bit is shifted into the target data register, the scan_ir_hw_jtag command<br/>
		/// moves the JTAG TAP to the IDLE state, or to the stable state defined by the run_state_hw_jtag<br/>
		/// command.<br/>
		/// The scan_ir_hw_jtag command returns a hex array containing captured TDO data from the<br/>
		/// hw_jtag, or returns an error if it fails.<br/>
		/// The command raises an error that can be trapped by the Tcl catch command if TDO data from<br/>
		/// the hw_jtag does not match specified -tdo argument.<br/>
		/// TIP: If -tdo and -mask arguments are specified, then the mask is applied to the -tdo option and the<br/>
		/// hw_jtag TDO data returned before comparing the two.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1584<br/>
		/// </para>
		/// </summary>
		/// <param name="length">(Required) Number of bits to be scanned.</param>
		/// <param name="tdi">(Optional) Hex value to be scanned into the target</param>
		/// <param name="tdo">(Optional) Hex value to be compared against the scanned value</param>
		/// <param name="mask">(Optional) Hex value mask applied when comparing TDO values</param>
		/// <param name="smask">(Optional) Hex value mask applied to TDI value</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>hardware TDO</returns>
		public TTCL scan_ir_hw_jtag(TCLObject length, String tdi = null, String tdo = null, String mask = null, String smask = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: scan_ir_hw_jtag [-tdi <arg>] [-tdo <arg>] [-mask <arg>] [-smask <arg>] [-quiet] [-verbose] <length>
			_tcl.Entry(_builder.scan_ir_hw_jtag(length, tdi, tdo, mask, smask, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Set the system monitor register value<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: set_hw_sysmon_reg [-quiet] [-verbose] &lt;hw_sysmon&gt; &lt;hexaddress&gt; &lt;hexdata&gt;
		/// <br/>
		/// <para>
		/// Set the system monitor register at the specified address to the hex value specified. This<br/>
		/// command identifies a register on the hw_sysmon on the current device through its hex address<br/>
		/// value, and sets the specified hex data value into that register.<br/>
		/// IMPORTANT! Some of the registers on the system monitor are read-only and cannot be set directly. This<br/>
		/// command has no effect if you try to set the value of a read-only register on the system monitor.<br/>
		/// The System Monitor (SYSMON) Analog-to-Digital Converter (ADC) is used to measure die<br/>
		/// temperature and voltage on the hw_device. The Sysmon monitors the physical environment via<br/>
		/// on-chip temperature and supply sensors. The ADC can access up to 17 external analog input<br/>
		/// channels.<br/>
		/// Data for the system monitor is stored in dedicated registers, called status and control registers,<br/>
		/// accessible through the get_hw_sysmon_reg and set_hw_sysmon_reg commands. Refer to<br/>
		/// the Register Interface in UltraScale Architecture System Monitor User Guide (UG580), or 7 Series<br/>
		/// FPGAs and Zynq-7000 SoC XADC Dual 12-Bit 1 MSPS Analog-to-Digital Converter User Guide<br/>
		/// (UG480) for more information on the addresses of specific system monitor registers.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Although the set_hw_sysmon_reg command lets you directly write the specified hex data<br/>
		/// value into the registers of a system monitor, the recommended procedure is to update the values<br/>
		/// of properties on the hw_sysmon object using the set_property command, and then write the<br/>
		/// property values to the hw_sysmon object using the commit_hw_sysmon command.<br/>
		/// The set_hw_sysmon_reg command writes the specified hex value to the hw_sysmon_reg<br/>
		/// object on the hw_sysmon object at the specified address but returns nothing, or returns an error<br/>
		/// if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1623<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_sysmon">(Required) hw_sysmon object</param>
		/// <param name="hexaddress">(Required) Hex address to write to</param>
		/// <param name="hexdata">(Required) Hex write value</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_hw_sysmon_reg(TCLObject hw_sysmon, TCLObject hexaddress, TCLObject hexdata, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_hw_sysmon_reg [-quiet] [-verbose] <hw_sysmon> <hexaddress> <hexdata>
			_tcl.Entry(_builder.set_hw_sysmon_reg(hw_sysmon, hexaddress, hexdata, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Disable Activity Monitor runs for the specified hardware HBM(s)<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: stop_hw_hbm_amon [-quiet] [-verbose] &lt;hw_objects&gt;
		/// <br/>
		/// <para>
		/// The stop_hw_hbm_amon command stops a running HBM activity monitor in the Vivado<br/>
		/// hardware manager that has been previously started using the run_hw_hbm_amon command.<br/>
		/// This command returns nothing when successful, or returns an error when it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example stops the HBM activity monitor for the associated HBM core:<br/>
		/// stop_hw_hbm_amon [get_hw_hbms *HBM_2]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1723<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL stop_hw_hbm_amon(TCLObject hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: stop_hw_hbm_amon [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.stop_hw_hbm_amon(hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Stop hardware SIO scans.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: stop_hw_sio_scan [-quiet] [-verbose] &lt;hw_sio_scans&gt;
		/// <br/>
		/// <para>
		/// Stop the specified scan running in the Vivado serial I/O analyzer.<br/>
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the<br/>
		/// specialized Eye Scan hardware of Xilinx UltraScale devices or 7 series FPGAs. The Vivado serial<br/>
		/// I/O analyzer feature lets you to create, run, and save link scans.<br/>
		/// This command lets you stop a scan that is in progress as started with the run_hw_sio_scan<br/>
		/// command.<br/>
		/// You can remove the created scan object using remove_hw_sio_scan.<br/>
		/// This command returns a message if successful, or returns an error if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1725<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_sio_scans">(Required) hardware SIO scans</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL stop_hw_sio_scan(TCLObject hw_sio_scans, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: stop_hw_sio_scan [-quiet] [-verbose] <hw_sio_scans>
			_tcl.Entry(_builder.stop_hw_sio_scan(hw_sio_scans, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Stop hardware SIO sweeps.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: stop_hw_sio_sweep [-quiet] [-verbose] &lt;hw_sio_sweeps&gt;
		/// <br/>
		/// <para>
		/// Stop the specified sweep scan.<br/>
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the<br/>
		/// specialized features of Xilinx UltraScale devices or 7 series FPGAs. It can also be helpful to run<br/>
		/// multiple scans on a the link with different configuration settings for the GTs. This can help you<br/>
		/// determine which settings are best for your design. The Vivado serial I/O analyzer feature enables<br/>
		/// you to define, run, and save link sweeps, or collections of link scans run across a range of values.<br/>
		/// This command lets you stop a sweep scan that is in progress as started with the<br/>
		/// run_hw_sio_sweep command.<br/>
		/// You can remove the created sweep scan object using remove_hw_sio_sweep.<br/>
		/// This command returns nothing if successful, or returns an error if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1727<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_sio_sweeps">(Required) hardware SIO sweeps</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL stop_hw_sio_sweep(TCLObject hw_sio_sweeps, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: stop_hw_sio_sweep [-quiet] [-verbose] <hw_sio_sweeps>
			_tcl.Entry(_builder.stop_hw_sio_sweep(hw_sio_sweeps, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Update the SmartLynq firmware image<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: update_hw_firmware [-file_path &lt;arg&gt;] [-config_path &lt;arg&gt;] [-skip_update] [-reset] [-format] [-flash] [-quiet] [-verbose] [&lt;hw_server&gt;]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1770<br/>
		/// </para>
		/// </summary>
		/// <param name="file_path">(Optional) Optional path to BOOT.BIN file Default: Use default BOOT.BIN</param>
		/// <param name="config_path">(Optional) Optional path to config.ini file Default: No config.ini updated</param>
		/// <param name="skip_update">(Optional) Skip writing the BOOT.BIN to the SmartLynq</param>
		/// <param name="reset">
		/// <para>
		/// (Optional)<br/>
		/// Reset the SmartLynq cable after any other operations to<br/>
		/// complete the update and disconnects the hw_server<br/>
		/// </para>
		/// </param>
		/// <param name="format">
		/// <para>
		/// (Optional)<br/>
		/// Format the SmartLynq cable EMMC prior to any other<br/>
		/// operations. Any files on SmartLynq cable will be lost.<br/>
		/// </para>
		/// </param>
		/// <param name="flash">
		/// <para>
		/// (Optional)<br/>
		/// Flash the SmartLynq cable QSPI. This updates the primary<br/>
		/// FSBL and Safe Mode images.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_server">(Optional) hardware server Default: current hardware server</param>
		public TTCL update_hw_firmware(String file_path = null, String config_path = null, bool? skip_update = null, bool? reset = null, bool? format = null, bool? flash = null, bool? quiet = null, bool? verbose = null, TCLObject hw_server = null)
		{
			// TCL Syntax: update_hw_firmware [-file_path <arg>] [-config_path <arg>] [-skip_update] [-reset] [-format] [-flash] [-quiet] [-verbose] [<hw_server>]
			_tcl.Entry(_builder.update_hw_firmware(file_path, config_path, skip_update, reset, format, flash, quiet, verbose, hw_server));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Update the SmartLynq GPIO PMOD pin values<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: update_hw_gpio [-quiet] [-verbose] [&lt;output_enable_mask&gt;] [&lt;output_pin_values&gt;] [&lt;hw_server&gt;]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1771<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="output_enable_mask">
		/// <para>
		/// (Optional)<br/>
		/// 8 bit hex mask to enable output pins on GPIO Default: All<br/>
		/// output pins disabled<br/>
		/// </para>
		/// </param>
		/// <param name="output_pin_values">(Optional) 8 bit hex value of output pins Default: All output pins driven low</param>
		/// <param name="hw_server">(Optional) hardware server Default: current hardware server</param>
		/// <returns>All GPIO PMOD pin values</returns>
		public TTCL update_hw_gpio(bool? quiet = null, bool? verbose = null, TCLObject output_enable_mask = null, TCLObject output_pin_values = null, TCLObject hw_server = null)
		{
			// TCL Syntax: update_hw_gpio [-quiet] [-verbose] [<output_enable_mask>] [<output_pin_values>] [<hw_server>]
			_tcl.Entry(_builder.update_hw_gpio(quiet, verbose, output_enable_mask, output_pin_values, hw_server));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Stop capturing. Upload any captured hardware ILA data.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: upload_hw_ila_data [-quiet] [-verbose] [&lt;hw_ilas&gt;...]
		/// <br/>
		/// <para>
		/// Upload the captured data from the memory buffers of the specified ILA debug cores on the Xilinx<br/>
		/// FPGA hardware device, and move it into a hw_ila_data object in the Vivado logic analyzer.<br/>
		/// You can upload captured data from the ILA debug core at any time during the capture process<br/>
		/// triggered by the run_hw_ila command. However, you may want to use the wait_on_hw_ila<br/>
		/// command in any Tcl scripts, to wait until the sample data buffers of the ILA core are fully<br/>
		/// populated with data. If you run the upload_hw_ila_data command prior to this, you may see<br/>
		/// a message as follows:<br/>
		/// INFO: [Labtools 27-1965] The ILA core 'hw_ila_1' trigger was stopped by<br/>
		/// user \<br/>
		/// at 2014-Mar-06 08:59:30<br/>
		/// INFO: [Labtools 27-2212] The ILA core 'hw_ila_1' captured '6' windows with<br/>
		/// \<br/>
		/// '64' samples each, and a last partial window with '0' samples.<br/>
		/// The upload process creates a hw_ila_data object in the process of moving the captured data from<br/>
		/// the ILA debug core, hw_ila, on the physical FPGA device, hw_device. The hw_ila_data object is<br/>
		/// named after the hw_ila core it is uploaded from.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// TIP: Each hw_ila object has only one matching hw_ila_data object associated with it. Each time<br/>
		/// upload_hw_ila_data is run for a specific hw_ila core, the hw_ila_data object is overwritten if it already<br/>
		/// exists.<br/>
		/// The data object, hw_ila_data can be viewed in the waveform viewer of the Vivado logic analyzer<br/>
		/// by using the display_hw_ila_data command, and can be written to disk using the<br/>
		/// write_hw_ila_data command.<br/>
		/// This command returns a hw_ila_data object, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1791<br/>
		/// </para>
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_ilas">(Optional) List of hardware ILA objects. Default: Current hardware ILA</param>
		/// <returns>hardware ILA data objects</returns>
		public TTCL upload_hw_ila_data(bool? quiet = null, bool? verbose = null, TCLObjectList hw_ilas = null)
		{
			// TCL Syntax: upload_hw_ila_data [-quiet] [-verbose] [<hw_ilas>...]
			_tcl.Entry(_builder.upload_hw_ila_data(quiet, verbose, hw_ilas));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Verify hardware devices<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: verify_hw_devices [-key &lt;arg&gt;] [-user_efuse &lt;arg&gt;] [-control_efuse &lt;arg&gt;] [-security_efuse &lt;arg&gt;] [-verbose] [-quiet] [&lt;hw_device&gt;...]
		/// <br/>
		/// <para>
		/// For EFUSE encrypted devices, this command compares the bitstream assigned to the<br/>
		/// PROGRAM.FILE property on the specified hw_device with the bitstream programmed into the<br/>
		/// device with the program_hw_devices command.<br/>
		/// Filtered through a required mask file, associated with the hw_device, the verify_hw_devices<br/>
		/// command uses both the bitstream and mask file to compare only the bits that are marked as<br/>
		/// important in the mask file. A mask file can be created along with the bitstream using the<br/>
		/// write_bitstream command, and is associated with the hw_device using the<br/>
		/// create_hw_bitstream command.<br/>
		/// IMPORTANT! Verification cannot be performed on devices programmed with encrypted bitstreams, other<br/>
		/// than to verify that the -key has been programmed.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The verify_hw_devices command reports that the readback data matches the programmed<br/>
		/// bitstream if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1803<br/>
		/// </para>
		/// </summary>
		/// <param name="key">(Optional) option value for key verification: efuse</param>
		/// <param name="user_efuse">(Optional) hex user fuse value for verification</param>
		/// <param name="control_efuse">(Optional) hex control fuse value for verification</param>
		/// <param name="security_efuse">(Optional) hex security fuse value for verification</param>
		/// <param name="verbose">(Optional) Shows fuse values during verification</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="hw_device">(Optional) list of hardware devices Default: current hardware device</param>
		/// <returns>hardware devices</returns>
		public TTCL verify_hw_devices(String key = null, String user_efuse = null, String control_efuse = null, String security_efuse = null, bool? verbose = null, bool? quiet = null, TCLObjectList hw_device = null)
		{
			// TCL Syntax: verify_hw_devices [-key <arg>] [-user_efuse <arg>] [-control_efuse <arg>] [-security_efuse <arg>] [-verbose] [-quiet] [<hw_device>...]
			_tcl.Entry(_builder.verify_hw_devices(key, user_efuse, control_efuse, security_efuse, verbose, quiet, hw_device));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Wait until all hardware ILA data has been captured.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: wait_on_hw_ila [-timeout &lt;arg&gt;] [-quiet] [-verbose] [&lt;hw_ilas&gt;...]
		/// <br/>
		/// <para>
		/// Suspend Tcl script or Tcl command processing until the ILA debug core memory is filled by<br/>
		/// captured data samples.<br/>
		/// This command is used after the run_hw_ila command to pause Tcl processing to wait for the<br/>
		/// data buffers to fill up. When the wait_on_hw_ila command returns, the Tcl command or script<br/>
		/// processing can continue.<br/>
		/// With the ILA debug core memory filed with sample data, when Tcl processing resumes, you can<br/>
		/// upload the captured data samples into an ILA debug core data object, or hw_ila_data object. Use<br/>
		/// the upload_ila_data command to perform this action.<br/>
		/// This command operates silently, returning nothing if successful, or returning an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1808<br/>
		/// </para>
		/// </summary>
		/// <param name="timeout">(Optional) Timeout in minutes. Decimal value allowed Default: No timeout</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_ilas">(Optional) hardware ILA objects. Default: Current hardware ILA</param>
		public TTCL wait_on_hw_ila(String timeout = null, bool? quiet = null, bool? verbose = null, TCLObjectList hw_ilas = null)
		{
			// TCL Syntax: wait_on_hw_ila [-timeout <arg>] [-quiet] [-verbose] [<hw_ilas>...]
			_tcl.Entry(_builder.wait_on_hw_ila(timeout, quiet, verbose, hw_ilas));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Wait until hardware SIO scan has completed.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: wait_on_hw_sio_scan [-timeout &lt;arg&gt;] [-quiet] [-verbose] &lt;hw_sio_scans&gt;...
		/// <br/>
		/// <para>
		/// Suspend a Tcl script or Tcl command processing until the specified serial I/O analyzer scan is<br/>
		/// complete.<br/>
		/// This command is used after the run_hw_sio_scan command to pause Tcl processing to wait<br/>
		/// for the scan to complete. When the wait_on_sio_scan command returns, the Tcl command<br/>
		/// or script processing can continue.<br/>
		/// This command operates silently, returning nothing if successful, or returning an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1810<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_sio_scans">(Required) List of hardware SIO scan objects.</param>
		/// <param name="timeout">(Optional) Timeout in minutes. Decimal value allowed Default: No timeout</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL wait_on_hw_sio_scan(TCLObjectList hw_sio_scans, String timeout = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: wait_on_hw_sio_scan [-timeout <arg>] [-quiet] [-verbose] <hw_sio_scans>...
			_tcl.Entry(_builder.wait_on_hw_sio_scan(hw_sio_scans, timeout, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Wait until hardware SIO sweep has completed.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: wait_on_hw_sio_sweep [-timeout &lt;arg&gt;] [-quiet] [-verbose] &lt;hw_sio_sweeps&gt;...
		/// <br/>
		/// <para>
		/// Suspend a Tcl script or Tcl command processing until the serial I/O analyzer sweep scan is<br/>
		/// complete.<br/>
		/// This command is used after the run_hw_sio_sweep command to pause Tcl processing to wait<br/>
		/// for the sweep scan to complete. When the wait_on_sio_sweep command returns, the Tcl<br/>
		/// command or script processing can continue.<br/>
		/// This command operates silently, returning nothing if successful, or returning an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1812<br/>
		/// </para>
		/// </summary>
		/// <param name="hw_sio_sweeps">(Required) List of hardware SIO sweep objects.</param>
		/// <param name="timeout">(Optional) Timeout in minutes. Decimal value allowed Default: No timeout</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL wait_on_hw_sio_sweep(TCLObjectList hw_sio_sweeps, String timeout = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: wait_on_hw_sio_sweep [-timeout <arg>] [-quiet] [-verbose] <hw_sio_sweeps>...
			_tcl.Entry(_builder.wait_on_hw_sio_sweep(hw_sio_sweeps, timeout, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write hardware ILA data to a file<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_hw_ila_data [-force] [-csv_file] [-vcd_file] [-legacy_csv_file] [-quiet] [-verbose] &lt;file&gt; [&lt;hw_ila_data&gt;] [&lt;hw_ila_data&gt;]
		/// <br/>
		/// <para>
		/// Write the ILA debug core sample data, stored in the specified hw_ila_data object, to a binary file<br/>
		/// on the disk.<br/>
		/// A hw_ila_data object is created when the hw_ila is triggered on the hw_device, or by the<br/>
		/// upload_hw_ila_data command when moving the captured data from the physical FPGA<br/>
		/// device, hw_device.<br/>
		/// The write_hw_ila_data lets you write the data of the hw_ila_data object to a binary file on<br/>
		/// the disk for later review. You can read the ILA debug core data back into the Vivado logic<br/>
		/// analyzer using the read_hw_ila_data command, which creates a new hw_ila_data object.<br/>
		/// This command returns the name of the file written, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1848<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) hardware ILA data file name</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="csv_file">(Optional) Export CSV format file only</param>
		/// <param name="vcd_file">(Optional) Export VCD format file only</param>
		/// <param name="legacy_csv_file">(Optional) Export csv file without radix information.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_ila_data">(Optional) hardware ILA data object Default: Current hardware ILA data</param>
		/// <returns>Name of the output file</returns>
		public TTCL write_hw_ila_data(TCLObject file, bool? force = null, bool? csv_file = null, bool? vcd_file = null, bool? legacy_csv_file = null, bool? quiet = null, bool? verbose = null, TCLObject hw_ila_data = null)
		{
			// TCL Syntax: write_hw_ila_data [-force] [-csv_file] [-vcd_file] [-legacy_csv_file] [-quiet] [-verbose] <file> [<hw_ila_data>] [<hw_ila_data>]
			_tcl.Entry(_builder.write_hw_ila_data(file, force, csv_file, vcd_file, legacy_csv_file, quiet, verbose, hw_ila_data));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write scan data to a file.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_hw_sio_scan [-force] [-quiet] [-verbose] &lt;file&gt; &lt;hw_sio_scan&gt;
		/// <br/>
		/// <para>
		/// Write the populated hw_sio_scan object after run_hw_sio_scan completes.<br/>
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the<br/>
		/// specialized Eye Scan hardware of Xilinx UltraScale devices or 7 series FPGAs. The Vivado serial<br/>
		/// I/O analyzer feature lets you to create, run, and save link scans.<br/>
		/// This command saves the scan to disk after completing the scan run. The format of the file is a<br/>
		/// CSV file of values observed while running the scan.<br/>
		/// This command returns the filename of the file output, or returns an error if the command fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1855<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) hardware SIO_scan file name</param>
		/// <param name="hw_sio_scan">(Required) hardware SIO scan data object</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Name of the output file</returns>
		public TTCL write_hw_sio_scan(TCLObject file, TCLObject hw_sio_scan, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_hw_sio_scan [-force] [-quiet] [-verbose] <file> <hw_sio_scan>
			_tcl.Entry(_builder.write_hw_sio_scan(file, hw_sio_scan, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write sweep data to a directory.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_hw_sio_sweep [-force] [-quiet] [-verbose] &lt;directory&gt; &lt;hw_sio_sweep&gt;
		/// <br/>
		/// <para>
		/// Write the populated hw_sio_sweep object after run_hw_sio_sweep completes.<br/>
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the<br/>
		/// specialized features of Xilinx UltraScale devices or 7 series FPGAs. It can also be helpful to run<br/>
		/// multiple scans on a the link with different configuration settings for the GTs. This can help you<br/>
		/// determine which settings are best for your design. The Vivado serial I/O analyzer feature enables<br/>
		/// you to define, run, and save link sweeps, or collections of link scans run across a range of values.<br/>
		/// This command saves the specified link sweep object to disk after it has been populated by the<br/>
		/// run_hw_sio_sweep command.<br/>
		/// This command returns the name of the directory created, or returns an error if the command<br/>
		/// fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1857<br/>
		/// </para>
		/// </summary>
		/// <param name="directory">(Required) hardware SIO_sweep directory path</param>
		/// <param name="hw_sio_sweep">(Required) hardware SIO sweep data object</param>
		/// <param name="force">(Optional) Overwrite existing directory</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Name of the output directory</returns>
		public TTCL write_hw_sio_sweep(TCLObject directory, TCLObject hw_sio_sweep, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_hw_sio_sweep [-force] [-quiet] [-verbose] <directory> <hw_sio_sweep>
			_tcl.Entry(_builder.write_hw_sio_sweep(directory, hw_sio_sweep, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Generate SVF file for current_hw_target<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_hw_svf [-force] [-quiet] [-verbose] &lt;file_name&gt;
		/// <br/>
		/// <para>
		/// The Vivado hardware manager supports programming of hardware devices through the use of<br/>
		/// Serial Vector Format (SVF) files. SVF files are ASCII files that contain both programming<br/>
		/// instructions and configuration data. These files are used by ATE machines and embedded<br/>
		/// controllers to perform boundary-scan operations. The SVF file captures the JTAG commands<br/>
		/// needed to program the bitstream directly into a Xilinx device, or indirectly into a flash memory<br/>
		/// device. The SVF file can be written using the write_hw_svf command, or applied to an open<br/>
		/// hw_target through the execute_hw_svf command. Refer to the Vivado Design Suite User Guide:<br/>
		/// Programming and Debugging (UG908) for more information.<br/>
		/// The specific process for creating the hw_svf file is:<br/>
		/// 1. Create an SVF target using create_hw_target.<br/>
		/// 2. Open the SVF target.<br/>
		/// 3. Create one or more devices on the SVF target using create_hw_device.<br/>
		/// 4. Program the devices using commands like program_hw_devices.<br/>
		/// 5. Write the SVF file of operation commands using write_hw_svf.<br/>
		/// In programming the hw_devices in Step 4 above, the SVF commands for the operations are<br/>
		/// cached to a temporary file. The write_hw_svf command saves the cache by giving it a file<br/>
		/// name and moving it to the specified file path.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Note: Because this command is essentially flushing the cached SVF commands, after you use the<br/>
		/// write_hw_svf command, the cache is cleared, and restarted to capture any new device commands.<br/>
		/// This command returns a message indicating success, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example writes an SVF file to specified location:<br/>
		/// program_hw_devices [lindex [get_hw_devices] 0]<br/>
		/// write_hw_svf C:/Data/k7_design.svf<br/>
		/// This example demonstrates the correct order of creating multiple devices on an SVF target. An<br/>
		/// SVF target is created and opened, then a Xilinx device, a user part, and a second Xilinx device are<br/>
		/// created on the current target. The bitstream properties are defined for the two Xilinx devices, the<br/>
		/// devices are programmed, and an SVF file is written:<br/>
		/// open_hw<br/>
		/// connect_hw_server<br/>
		/// create_hw_target my_svf_target<br/>
		/// open_hw_target<br/>
		/// create_hw_device -part xc7k325t<br/>
		/// create_hw_device -idcode 01234567 -irlength 8 -mask ffffffff -part<br/>
		/// userPart1<br/>
		/// create_hw_device -part xcku9p<br/>
		/// set_property PROGRAM.FILE {C:/Data/k7_design.bit} [lindex [get_hw_devices]<br/>
		/// 0]<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// set_property PROGRAM.FILE {C:/Data/ku_design.bit} [lindex [get_hw_devices]<br/>
		/// 2]<br/>
		/// program_hw_devices [lindex [get_hw_devices] 0]<br/>
		/// program_hw_devices [lindex [get_hw_devices] 2]<br/>
		/// write_hw_svf C:/Data/myDesign.svf<br/>
		/// The following example demonstrates creating a device on an SVF target, creating a configuration<br/>
		/// memory object (hw_cfgmem) associated with that device, programming the device and<br/>
		/// configuration memory, and saving that command sequence to an SVF file:<br/>
		/// create_hw_target my_svf_target<br/>
		/// open_hw_target<br/>
		/// set device [create_hw_device -part xc7k325t]<br/>
		/// set_property PROGRAM.FILE {C:/Data/k7_design.bit} $device<br/>
		/// create_hw_cfgmem -hw_device $device -mem_dev [lindex \<br/>
		/// [get_cfgmem_parts {28f00am29ew-bpi-x16}] 0]<br/>
		/// set cfgMem [current_hw_cfgmem]<br/>
		/// set_property PROGRAM.ADDRESS_RANGE {use_file} $cfgMem<br/>
		/// set_property PROGRAM.BLANK_CHECK 0 $cfgMem<br/>
		/// set_property PROGRAM.BPI_RS_PINS {none} $cfgMem<br/>
		/// set_property PROGRAM.CFG_PROGRAM 1 $cfgMem<br/>
		/// set_property PROGRAM.CHECKSUM 0 $cfgMem<br/>
		/// set_property PROGRAM.ERASE 1 $cfgMem<br/>
		/// set_property PROGRAM.UNUSED_PIN_TERMINATION {pull-none} $cfgMem<br/>
		/// set_property PROGRAM.VERIFY 1 $cfgMem<br/>
		/// set_property PROGRAM.FILES [list {C:/data/flash.mcs} ] $cfgMem<br/>
		/// create_hw_bitstream -hw_device $device [get_property \<br/>
		/// PROGRAM.HW_CFGMEM_BITFILE $device]<br/>
		/// program_hw_devices $device<br/>
		/// program_hw_cfgmem -hw_cfgmem $cfgMem<br/>
		/// write_hw_svf C:/Data/myDesign.svf<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1859<br/>
		/// </para>
		/// </summary>
		/// <param name="file_name">(Required) SVF filename</param>
		/// <param name="force">(Optional) overwrite svf file if it exists</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_hw_svf(TCLObject file_name, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_hw_svf [-force] [-quiet] [-verbose] <file_name>
			_tcl.Entry(_builder.write_hw_svf(file_name, force, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
