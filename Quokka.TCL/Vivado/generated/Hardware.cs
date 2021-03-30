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
		/// Select Pseudo Channel to add to Activity Monitor on the specified hardware HBM(s). Must
		/// specify the Memory Controller number first, follow by Pseudo Channel number.
		///
		///
		/// TCL Syntax: add_hw_hbm_pc [-quiet] [-verbose] <mc_num> <pc_num> <hw_objects>
		///
		/// The HBM activity monitor (amon) can be used to gain real-time access to performance
		/// monitoring and temperature sensors certain Xilinx® UltraScale+ devices that include an
		/// integrated High-Bandwidth Memory (HBM) controller. Refer to the LogiCore IP Product Guide:
		/// AXI High Bandwidth Memory Controller (PG276) for more information on this core. The HBM
		/// controller and memory stacks contain both performance counters and temperature sensors that
		/// can be accessed through the HBM activity monitor from within the Xilinx Vivado hardware
		/// manager. Each HBM stack is split into eight independent memory channels, each of which is
		/// further divided into two 64-bit pseudo channels (pc).
		/// After configuring an HBM enabled device with a design that contains instances of the AXI High
		/// Bandwidth Memory Controller, the HBM cores will be visible in the Vivado hardware manager.
		/// The add_hw_hbm_pc command lets you specify a memory channel (mc)/psuedo channel (pc) to
		/// monitor in the HBM activity monitor prior to using the run_hw_hbm_amon command.
		/// TIP: The HBM activity monitor must not be running when adding or removing psuedo channels.
		/// This command returns nothing if successful, or returns an error if it fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example adds the specified memory channels/psuedo channels on the defined
		/// HBM controller (hw_hbm) object, and then runs the HBM activity monitor in the Vivado
		/// hardware manager:
		/// set hbm_mon [get_hw_hbms *HBM_2]
		/// add_hw_hbm_pc 0 0 $hbm_mon
		/// add_hw_hbm_pc 0 1 $hbm_mon
		/// add_hw_hbm_pc 1 0 $hbm_mon
		/// add_hw_hbm_pc 1 1 $hbm_mon
		/// add_hw_hbm_pc 2 0 $hbm_mon
		/// add_hw_hbm_pc 2 1 $hbm_mon
		/// add_hw_hbm_pc 3 0 $hbm_mon
		/// add_hw_hbm_pc 3 1 $hbm_mon
		/// run_hw_hbm_amon $hbm_mon
		///
		/// See ug835-vivado-tcl-commands.pdf, page 52
		/// </summary>
		/// <param name="mc_num">(Required) Memory Controller number to select: 0 to 7</param>
		/// <param name="pc_num">(Required) Pseudo Channel number to select: 0 or 1</param>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL add_hw_hbm_pc(String mc_num, String pc_num, String hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: add_hw_hbm_pc [-quiet] [-verbose] <mc_num> <pc_num> <hw_objects>
			_tcl.Entry(_builder.add_hw_hbm_pc(mc_num, pc_num, hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Add an enumerated name-value pair to a hw_probe enumeration.
		///
		///
		/// TCL Syntax: add_hw_probe_enum [-no_gui_update] [-dict <args>] [-quiet] [-verbose] <name> <value> <hw_probe>
		///
		/// Assign enumerated name/value pairs to specified hardware probe objects.
		/// This command is intended to make it easier to monitor the states of signals in the Vivado logic
		/// analyzer. The command lets you define a set of states, or enumerated names to be associated
		/// with specific values that may be found on a hw_probe object. This lets you monitor state
		/// machine probes and some other types of probes, by comparing symbolic names with trigger
		/// values and waveform data values.
		/// The enumerated name is added as an ENUM.NAME property on the specified hw_probe object,
		/// and associated with the specified bit value on the probe. Enumerated names can be used to
		/// specify trigger/capture compare values for hw_probes.
		/// TIP: Enumerated names are displayed in the waveform viewer of the Vivado logic analyzer. Display of the
		/// enumerated names can be disabled on a per probe basis. Refer to the Vivado Design Suite User Guide:
		/// Programming and Debugging (UG908) for more information on the waveform viewer.
		/// This command returns the enumerated name property, or returns an error if it fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example uses the -dict option to define the enumerated name/value pairs for
		/// the specified hw_probe object:
		/// add_hw_probe_enum -dict {ZERO eq5'h00 RED eq5'h12 GREEN eq5'h13 \
		/// BLUE eq5'h14 WHITE eq5'h15 YELLOW eq5'h16 GREY eq5'h17} \
		/// [get_hw_probes op1 -of_objects [current_hw_ila]]
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The following example defines the enumerated name/value pairs for the specified hw_probe
		/// object:
		/// add_hw_probe_enum ZERO eq5'h00 [get_hw_probes op1 \
		/// -of_objects [current_hw_ila]]
		/// add_hw_probe_enum RED eq5'h12 [get_hw_probes op1 \
		/// -of_objects [current_hw_ila]]
		/// add_hw_probe_enum GREEN eq5'h13 [get_hw_probes op1 \
		/// -of_objects [current_hw_ila]]
		/// add_hw_probe_enum BLUE eq5'h14 [get_hw_probes op1 \
		/// -of_objects [current_hw_ila]]
		/// add_hw_probe_enum WHITE eq5'h15 [get_hw_probes op1 \
		/// -of_objects [current_hw_ila]]
		/// add_hw_probe_enum YELLOW eq5'h16 [get_hw_probes op1 \
		/// -of_objects [current_hw_ila]]
		/// add_hw_probe_enum GREY eq5'h17 [get_hw_probes op1 \
		/// -of_objects [current_hw_ila]]
		/// The following example returns the ENUM property assigned to the specified hw_probe object:
		/// report_property [get_hw_probes op1 -of_objects [current_hw_ila]] ENUM*
		/// Property Type Read-only Visible Value
		/// ENUM.ZERO string true true eq5'h00
		/// ENUM.RED string true true eq5'h12
		/// ENUM.GREEN string true true eq5'h13
		/// ENUM.BLUE string true true eq5'h14
		/// ENUM.WHITE string true true eq5'h15
		/// ENUM.YELLOW string true true eq5'h16
		/// ENUM.GREY string true true eq5'h17
		///
		/// See ug835-vivado-tcl-commands.pdf, page 54
		/// </summary>
		/// <param name="name">(Required) Enumerated name.</param>
		/// <param name="value">(Required) Explicit value.</param>
		/// <param name="hw_probe">(Required) hw_probe object.</param>
		/// <param name="no_gui_update">(Optional) Defer GUI update.</param>
		/// <param name="dict">(Optional) List of parameter name-value pairs.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL add_hw_probe_enum(String name, String value, String hw_probe, bool? no_gui_update = null, TCLParameterList dict = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: add_hw_probe_enum [-no_gui_update] [-dict <args>] [-quiet] [-verbose] <name> <value> <hw_probe>
			_tcl.Entry(_builder.add_hw_probe_enum(name, value, hw_probe, no_gui_update, dict, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Issue JTAG Program command to hw_device
		///
		///
		/// TCL Syntax: boot_hw_device [-disable_done_check] [-timeout <arg>] [-quiet] [-verbose] <hw_device>
		///
		/// Issue JTAG PROGRAM command to the hw_device (FPGA).
		/// The boot_hw_device command triggers the FPGA boot and board startup sequence. The boot
		/// sequence starts the FPGA configuration process to clear the device of any prior programming,
		/// and then to load a new program, depending on the mode pin settings.
		/// The hw_device will boot based on its mode pin settings. If the FPGA's mode pins on the device
		/// are set to JTAG mode, or the interface is not active (e.g. the PROM is not configured) the net
		/// effect of the boot_hw_device command is to clear the prior programming.
		/// This command returns a 1 if it detects that the DONE pin has gone HIGH, or when the device
		/// has been cleared, otherwise it returns 0.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 118
		/// </summary>
		/// <param name="hw_device">(Required) Target hw_device connection</param>
		/// <param name="disable_done_check">(Optional) Disable done check for boot device</param>
		/// <param name="timeout">(Optional) Time out for boot (seconds) Default: default</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL boot_hw_device(String hw_device, bool? disable_done_check = null, String timeout = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: boot_hw_device [-disable_done_check] [-timeout <arg>] [-quiet] [-verbose] <hw_device>
			_tcl.Entry(_builder.boot_hw_device(hw_device, disable_done_check, timeout, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Close the hardware tool
		///
		///
		/// TCL Syntax: close_hw_manager [-quiet] [-verbose]
		///
		/// Close the Hardware Manager tool in the Vivado Design Suite.
		/// Opening the Hardware Manager using the open_hw_manager command, is the first step in
		/// programming and/or debugging your design in Xilinx FPGA hardware. For more information refer
		/// to the Vivado Design Suite User Guide: Programming and Debugging (UG908).
		///
		/// See ug835-vivado-tcl-commands.pdf, page 139
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
		/// Close a hardware target
		///
		///
		/// TCL Syntax: close_hw_target [-quiet] [-verbose] [<hw_target>]
		///
		/// Close the connection to the current or specified hardware target that was previously opened
		/// using the open_hw_target command.
		/// The hardware target is a system board containing a JTAG chain of one or more Xilinx devices that
		/// you can program with a bitstream file, or use to debug your design. Connections between
		/// hardware targets on the system board and the Vivado Design Suite are managed by the
		/// hw_server application. Refer to Vivado Design Suite User Guide: Programming and Debugging
		/// (UG908) for a list of supported JTAG download cables and devices.
		/// This command returns connection messages from the hardware server, or returns an error if it
		/// fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 141
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_target">(Optional) hardware target Default: current hardware target</param>
		public TTCL close_hw_target(bool? quiet = null, bool? verbose = null, String hw_target = null)
		{
			// TCL Syntax: close_hw_target [-quiet] [-verbose] [<hw_target>]
			_tcl.Entry(_builder.close_hw_target(quiet, verbose, hw_target));
			return _tcl;
		}
		/// <summary>
		/// Commit the property changes of the current hardware object. Inputs can be HBM or device
		/// hardware object. At least one object is required.
		///
		///
		/// TCL Syntax: commit_hw_hbm [-quiet] [-verbose] <hw_objects>
		///
		/// Commit the current values of properties defined on the specified HBM controller in the Vivado
		/// hardware manager to the current hardware device.
		/// The commit_hw_hbm command takes the current property values defined on a hw_hbm object
		/// and commits them to the current hardware device connected to the hardware server.
		/// When you change the property values on the hw_hbm object, they are not written to the
		/// hardware device until you use the commit_hw_hbm command.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example changes a property of the specified HBM controller object, and then
		/// commits the change to the device:
		/// set_property MC2.INIT.AM_REPEAT_EN 1 [get_hw_hbms *HBM_2]
		/// commit_hw_hbm [get_hw_hbm *HBM_2]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 154
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL commit_hw_hbm(String hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: commit_hw_hbm [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.commit_hw_hbm(hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Commit the property changes of the current hardware object. Inputs can be any mig, device,
		/// target, or server hardware object. At least one object is required.
		///
		///
		/// TCL Syntax: commit_hw_mig [-quiet] [-verbose] <hw_objects>
		///
		/// Commit the current values of properties defined on the specified memory IP debug core
		/// hardware objects in the Hardware Manager feature of the Vivado Design Suite to the current
		/// hardware device.
		/// The commit_hw_mig command takes the current property values defined on a hw_mig object in
		/// the Vivado logic analyzer, and commits them to the current hardware device connected to the
		/// hardware server.
		/// When you change the property values on the hw_mig object, like the CONFIG.* properties, they
		/// are not written to the hardware device until you use the commit_hw_mig command.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 156
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL commit_hw_mig(String hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: commit_hw_mig [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.commit_hw_mig(hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Commit the property changes of the current hardware object. Inputs can be any serial I/O
		/// (except scan and sweep), device, target, or server hardware object. At least one object is required.
		///
		///
		/// TCL Syntax: commit_hw_sio [-quiet] [-verbose] <hw_objects>
		///
		/// Commit the current values of properties defined on the specified serial I/O hardware objects in
		/// the Hardware Manager feature of the Vivado Design Suite to the current hardware device.
		/// Specified objects can include any serial I/O object such as GTs, RXs, TXs, PLLs, or Commons,
		/// excluding hw_sio_scan and hw_sio_sweep objects. SIO objects also include device, target, or
		/// server hardware objects.
		/// The SIO IBERT core operates on an object property-based set/commit use model. You can set
		/// the property values on the hardware objects using the set_property command. You can then
		/// drive those values onto the current hardware device using the commit_hw_sio command.
		/// TIP: To update the properties on the hardware object with the actual value on the device use the
		/// refresh_hw_sio command.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 158
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL commit_hw_sio(String hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: commit_hw_sio [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.commit_hw_sio(hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Commit the property changes of the current hardware object. Inputs can be hw_server,
		/// hw_target, hw_device or hw_sysmon objects. At least one object is required.
		///
		///
		/// TCL Syntax: commit_hw_sysmon [-quiet] [-verbose] <hw_objects>
		///
		/// The commit_hw_sysmon command takes the current property values defined on a hw_sysmon
		/// object, and commits them to the system monitor registers on the hardware device.
		/// When you change the property values on the hw_sysmon object, like the CONFIG.* properties,
		/// they are not written to the hardware device until you use the commit_hw_sysmon command.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 160
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL commit_hw_sysmon(String hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: commit_hw_sysmon [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.commit_hw_sysmon(hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Write hardware VIO probe OUTPUT_VALUE properties values to VIO core(s).
		///
		///
		/// TCL Syntax: commit_hw_vio [-quiet] [-verbose] <hw_objects>...
		///
		/// Commit the current values defined on the probes of the VIO Debug core to the current hardware
		/// device.
		/// The Virtual Input/Output (VIO) debug core can both monitor and drive internal signals on a
		/// programmed Xilinx FPGA in real time. The VIO core uses hardware probes, hw_probe objects, to
		/// monitor and drive signals on the device. Input probes monitor signals as inputs to the VIO core.
		/// Output probes drive signals to specified values from the VIO core.
		/// The VIO core operates on an object property-based set/commit use model. You can set the
		/// OUTPUT_VALUE property on the output probes of the VIO core using the set_property
		/// command. You can then drive those values onto probed signals on the hardware device using the
		/// commit_hw_vio command.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 162
		/// </summary>
		/// <param name="hw_objects">(Required) List of hardware VIO and hardware probe objects.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL commit_hw_vio(TCLParameterList hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: commit_hw_vio [-quiet] [-verbose] <hw_objects>...
			_tcl.Entry(_builder.commit_hw_vio(hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Configure the device GTs for the specified device.
		///
		///
		/// TCL Syntax: config_hw_sio_gts [-dict <args>] [-quiet] [-verbose] <hw_device>
		///
		/// See ug835-vivado-tcl-commands.pdf, page 176
		/// </summary>
		/// <param name="hw_device">(Required) hardware device object</param>
		/// <param name="dict">
		/// (Optional)
		/// list of name/value pairs of GT settings and values to use to
		/// configure GTs
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL config_hw_sio_gts(String hw_device, TCLParameterList dict = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: config_hw_sio_gts [-dict <args>] [-quiet] [-verbose] <hw_device>
			_tcl.Entry(_builder.config_hw_sio_gts(hw_device, dict, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Open a connection to a hardware server
		///
		///
		/// TCL Syntax: connect_hw_server [-url <arg>] [-cs_url <arg>] [-quiet] [-verbose]
		///
		/// IMPORTANT! You must use the open_hw command to open the Hardware Manager in the Vivado
		/// Design Suite before using this command.
		/// To open a hardware target containing a JTAG chain of one or more Xilinx devices, for
		/// programming and/or debugging your design, you must first connect to a Vivado tools hardware
		/// server (hw_server) to manage the connection to the hardware target (hw_target).
		/// The hw_server manages the connection to the physical programming target. It should be running
		/// on the machine connected to the hardware programmer, or test board, connected either locally
		/// or remotely. The hw_server command must be launched as a separate application, and can be
		/// found in the /bin folder of your Vivado Design Suite installation directory.
		/// To connect to a hardware server, the hw_server application must be running, and the host
		/// name and port number noted for the -url argument of the connect_hw_server command.
		/// The default URL for the hw_server process is localhost:3121. For more information on
		/// setting up and running the Vivado hardware server, refer to the Vivado Design Suite User Guide:
		/// Programming and Debugging (UG908).
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// You can connect a single instance of the Vivado Design Suite to multiple hardware servers, to
		/// support programming and debugging different device configurations. However, you can only
		/// have one connection to a specific hardware server as identified by the host name/port number
		/// combination. An error is returned if you attempt to open a connection to a server that is already
		/// connected.
		/// The last connected hardware server is the current hardware server, unless changed by the
		/// current_hw_server command. Any connected server can be disconnected with the
		/// disconnect_hw_server command.
		/// This command returns the host name of the hardware server that has been connected.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 203
		/// </summary>
		/// <param name="url">(Optional) hw_server url Default: localhost:3121</param>
		/// <param name="cs_url">
		/// (Optional)
		/// Url to use for cs_server. If default url is used and no server is
		/// running there, cs_server will be automatically launched on
		/// the default url. Default: TCP:localhost:3042
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
		/// Create hardware AXI transaction object
		///
		///
		/// TCL Syntax: create_hw_axi_txn [-address <arg>] [-data <arg>] [-size <arg>] -type <arg> [-len <arg>] [-burst <arg>] [-cache <arg>] [-id <arg>] [-force] [-quiet] [-verbose] <name> <hw_axi>
		///
		/// Define a read or write transaction for the JTAG to AXI Master core, hw_axi object, specified by
		/// the get_hw_axis command.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The JTAG to AXI Master is a customizable IP core that works as an AXI Master to drive AXI
		/// transactions and drive AXI signals that are internal to the hardware device. The JTAG-AXI core
		/// supports all memory-mapped AXI interfaces, except AXI4-Stream, and supports the AXI-Lite
		/// protocol. Detailed documentation on the IP core can be found in the LogiCORE IP JTAG to AXI
		/// Master Product Guide (PG174).
		/// AXI transactions are read/write burst transactions from the JTAG to AXI Master core onto AXI
		/// signals connected to the core. The AXI transaction lets you configure aspects of the read or write
		/// transaction such as the data to send and the address to send it to. These defined transactions are
		/// stored as properties of the specified hw_axi object, waiting to be run and reported using the
		/// run_hw_axi and report_hw_axi_txn commands.
		/// The command returns the name of the hw_axi_txn object created, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 284
		/// </summary>
		/// <param name="type">(Required) READ or WRITE transaction.</param>
		/// <param name="name">(Required) Name of new object.</param>
		/// <param name="hw_axi">(Required) Associated hardware AXI core object.</param>
		/// <param name="address">(Optional) AXI read or write address. Default: Address zero</param>
		/// <param name="data">(Optional) Transaction data. Default: All zeroes</param>
		/// <param name="size">
		/// (Optional)
		/// Deprecated. Data word size in bits. This is now automatically
		/// set based on the IP core properties.
		/// </param>
		/// <param name="len">(Optional) Length of the transaction in data words. Default: 1</param>
		/// <param name="burst">(Optional) Burst type: INCR,FIXED or WRAP. Default: INCR</param>
		/// <param name="cache">(Optional) AXI cache type. Default: 3</param>
		/// <param name="id">(Optional) Address ID. Default: 0</param>
		/// <param name="force">
		/// (Optional)
		/// Overwrite an existing transaction with the specified name if
		/// it exists, otherwise create a new transaction. Default: 0
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>New hardware AXI transaction object.</returns>
		public TTCL create_hw_axi_txn(String type, String name, String hw_axi, String address = null, String data = null, String size = null, String len = null, String burst = null, String cache = null, String id = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_hw_axi_txn [-address <arg>] [-data <arg>] [-size <arg>] -type <arg> [-len <arg>] [-burst <arg>] [-cache <arg>] [-id <arg>] [-force] [-quiet] [-verbose] <name> <hw_axi>
			_tcl.Entry(_builder.create_hw_axi_txn(type, name, hw_axi, address, data, size, len, burst, cache, id, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Read bitstream file into memory
		///
		///
		/// TCL Syntax: create_hw_bitstream -hw_device <arg> [-mask <arg>] [-nky <arg>] [-detect_partial] [-quiet] [-verbose] [<file>]
		///
		/// Read a bitstream file, created with the write_bitstream command, to create a hw_bitstream
		/// object, and associate that object with a hw_device object in the Hardware Manager feature of
		/// the Vivado Design Suite.
		/// The hw_bitstream object is associated with the specified hw_device through the
		/// PROGRAM.HW_BITSTREAM property on the device. This property is automatically set by the
		/// create_hw_bitstream command. The PROGRAM.FILE property is also set to reflect the file
		/// path of the specified bitstream file.
		/// Note: A hw_bitstream object is also automatically created and associated with a hw_device object when
		/// you use the program_hw_devices command.
		/// The mask file written with the bitstream file, using the write_bitstream -mask command, is
		/// associated through the MASK property on the hw_bitstream object. The encryption key file
		/// required for use with an encrypted bitstream is associated through the ENCRYPTION.FILE
		/// property on the hw_bitstream object. These files are associated with the hw_bitstream object
		/// using the -mask and -nky options.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The created hw_bitstream object can be removed with the delete_hw_bitstream command.
		/// This command returns the name of the hw_bitstream object created, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 288
		/// </summary>
		/// <param name="hw_device">(Required) Target hw_device connection</param>
		/// <param name="file">(Required) Bitstream filename</param>
		/// <param name="mask">(Optional) Mask file for hw device</param>
		/// <param name="nky">(Optional) Encryption file for hw device</param>
		/// <param name="detect_partial">(Optional) detects partial bitstream</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_hw_bitstream(String hw_device, String file, String mask = null, String nky = null, bool? detect_partial = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_hw_bitstream -hw_device <arg> [-mask <arg>] [-nky <arg>] [-detect_partial] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.create_hw_bitstream(hw_device, file, mask, nky, detect_partial, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Read cfgmem file into memory
		///
		///
		/// TCL Syntax: create_hw_cfgmem -hw_device <arg> [-quiet] [-verbose] <mem_device>
		///
		/// Create a hw_cfgmem object associated with the specified hw_device.
		/// The process whereby the bitstream data is loaded or programmed into the Xilinx® FPGA is called
		/// configuration. Configuration is designed to be flexible to accommodate different application
		/// needs and, wherever possible, to leverage existing system resources to minimize system costs.
		/// Xilinx FPGAs are configured by loading design-specific configuration data, in the form of a
		/// bitstream file, into the internal memory of the hw_device. The hw_cfgmem defines a flash
		/// memory device used for configuring and booting the Xilinx FPGA device. Once the hw_cfgmem
		/// object is created, and associated with the hw_device, the configuration memory can be
		/// programmed with the bitstream and other data using the program_hw_cfgmem command.
		/// The hw_cfgmem object is associated with the specified hw_device object through the
		/// PROGRAM.HW_CFGMEM property on the device object. Use the get_hw_cfgmems command
		/// to work with the hw_cfgmem object, or use the get_property command to obtain the object
		/// from the hw_device:
		/// get_property PROGRAM.HW_CFGMEM [current_hw_device]
		/// TIP: When creating a new hw_cfgmem object, you can also associate the object with a Tcl variable as
		/// shown in the example below. By referring to the variable, you can set properties on the object, and use the
		/// object with other Tcl commands like program_hw_cfgmem or readback_hw_cfgmem.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// This command returns the created hw_cfgmem object, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 291
		/// </summary>
		/// <param name="hw_device">(Required) hw_device object with which to associate hw_cfgmem object</param>
		/// <param name="mem_device">(Required) name of flash memory device as returned by get_cfgmem_parts</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_hw_cfgmem(String hw_device, String mem_device, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_hw_cfgmem -hw_device <arg> [-quiet] [-verbose] <mem_device>
			_tcl.Entry(_builder.create_hw_cfgmem(hw_device, mem_device, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Create a hw_device (jtag chain) on an open target
		///
		///
		/// TCL Syntax: create_hw_device [-idcode <arg>] [-irlength <arg>] [-mask <arg>] [-part <arg>] [-quiet] [-verbose]
		///
		/// The Vivado hardware manager supports programming of hardware devices through the use of
		/// Serial Vector Format (SVF) files. SVF files are ASCII files that contain both programming
		/// instructions and configuration data. These files are used by ATE machines and embedded
		/// controllers to perform boundary-scan operations. The SVF file captures the JTAG commands
		/// needed to program the bitstream directly into a Xilinx device, or indirectly into a flash memory
		/// device. The SVF file can be written using the write_hw_svf command, or applied to an open
		/// hw_target through the execute_hw_svf command. Refer to the Vivado Design Suite User Guide:
		/// Programming and Debugging (UG908) for more information.
		/// The specific process for creating the hw_svf file is:
		/// 1. Create an SVF target using create_hw_target.
		/// 2. Open the SVF target.
		/// 3. Create one or more devices on the SVF target using create_hw_device.
		/// 4. Program the devices using commands like program_hw_devices.
		/// 5. Write the SVF file of operation commands using write_hw_svf.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The create_hw_device command creates a hw_device object on an open SVF target, adding it
		/// to the JTAG chain. This device can be queried and programmed like other hw_targets using
		/// commands like get_hw_devices and program_hw_devices.
		/// You can create both Xilinx devices and user-defined parts to add to the JTAG chain on the open
		/// SVF hw_target. For Xilinx devices, simply specify a recognized part number and the Vivado tool
		/// will define it with the appropriate details. For user-defined parts you must specify the JTAG ID
		/// code, IR length, and mask details using the appropriate options. User-defined parts are added as
		/// space-holder devices to the JTAG chain as on the SVF hw_target. You can get the user-part with
		/// get_hw_devices command, and query the properties of the part with report_property,
		/// but you cannot program user-parts.
		/// IMPORTANT! You should create all the devices to define the JTAG chain for the SVF target, before
		/// performing any operations on the JTAG chain. If you mix create_hw_device commands with
		/// programming commands the JTAG chain referenced in the SVF file will be improperly defined and will not
		/// work during execute_hw_svf.
		/// After creating the hw_device on the SVF target, you can exercise the device with supported
		/// operations such as associating a bitstream file (.bit) and programming the device:
		/// set_property PROGRAM.FILE {C:/Data/design.bit} [current_hw_device]
		/// program_hw_devices [current_hw_device]
		/// The create_hw_device command returns nothing if successful, and returns an error if it fails.
		///
		/// The following example creates an SVF target, opens that target, and creates a new hw_device on
		/// the target:
		/// create_hw_target my_svf_target
		/// open_hw_target
		/// create_hw_device -part xc7k325t
		/// This example demonstrates the correct order of creating multiple devices on an SVF target. An
		/// SVF target is created and opened, then a Xilinx device, a user part, and a second Xilinx device are
		/// created on the current target. The bitstream properties are defined for the two Xilinx devices, the
		/// devices are programmed, and an SVF file is written:
		/// open_hw
		/// connect_hw_server
		/// create_hw_target my_svf_target
		/// open_hw_target
		/// create_hw_device -part xc7k325t
		/// create_hw_device -idcode 01234567 -irlength 8 -mask ffffffff -part
		/// userPart1
		/// create_hw_device -part xcku9p
		/// set_property PROGRAM.FILE {C:/Data/k7_design.bit} [lindex [get_hw_devices]
		/// 0]
		/// set_property PROGRAM.FILE {C:/Data/ku_design.bit} [lindex [get_hw_devices]
		/// 2]
		/// program_hw_devices [lindex [get_hw_devices] 0]
		/// program_hw_devices [lindex [get_hw_devices] 2]
		/// write_hw_svf C:/Data/myDesign.svf
		///
		/// See ug835-vivado-tcl-commands.pdf, page 294
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
		/// Create hardware probe object
		///
		///
		/// TCL Syntax: create_hw_probe [-no_gui_update] [-map <arg>] [-quiet] [-verbose] <name> <core>
		///
		/// This command creates a new user-defined probe on the specified ILA core to define triggers and
		/// view data in the Vivado Logic Analyzer. The new probe can combine specific bit values of existing
		/// probes to simplify or clarify the data presented in the waveform viewer. Captured data samples
		/// from the user-defined probe can be reported with the list_hw_samples command.
		/// User-defined probes can map bit values from a single physical probe on the ILA core, or can
		/// combine bit values from multiple physical probes onto a single user-defined probe. Probes that
		/// map bits from a single probe can be used to create triggers and view data. Probes that combine
		/// bits from multiple physical probes can only be used for viewing data in the Vivado Logic Analyzer.
		/// You can delete user-defined probes with the delete_hw_probe command.
		/// The create_hw_probe command returns the user-defined probe name when successful, or
		/// returns an error if it fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example maps bits from multiple physical probes onto a new user-defined probe
		/// on the specified ILA core:
		/// create_hw_probe -map {0011 probe5[3:0] probe8 probe9} myProbeAR[9:0]
		/// hw_ila_1
		/// TIP: The -map option combines 10 bits onto the new probe, so the probe name specifies a matching port
		/// width.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The following example creates a hw_probe with copies of the most-significant bit to sign-extend
		/// a 30-bit signal to align it with other 32-bit signed signals:
		/// create_hw_probe -map {probe0[29] probe0[29] probe0[29:0]} \
		/// mySignExtendedProbe[31:0] [get_hw_ilas hw_ila_1]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 297
		/// </summary>
		/// <param name="name">(Required) Name of new object. Bus probes have range appended.</param>
		/// <param name="core">(Required) Associated hardware ILA core object.</param>
		/// <param name="no_gui_update">(Optional) Defer GUI update.</param>
		/// <param name="map">(Optional) Declaration of bits. Default: 0</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>New hardware probe object.</returns>
		public TTCL create_hw_probe(String name, String core, bool? no_gui_update = null, String map = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_hw_probe [-no_gui_update] [-map <arg>] [-quiet] [-verbose] <name> <core>
			_tcl.Entry(_builder.create_hw_probe(name, core, no_gui_update, map, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Create a new link between hardware RX and TX endpoints. There must be at least one hardware
		/// TX or RX endpoint specified. If one is missing, the endpoint will be treated as Unknown. The
		/// unknown endpoint can be renamed in a link property.
		///
		///
		/// TCL Syntax: create_hw_sio_link [-description <arg>] [-quiet] [-verbose] [<hw_sio_rx>] [<hw_sio_tx>]
		///
		/// Define a communication links between transmitter (TX) and receiver (RX) objects on the GTs of
		/// the IBERT debug core implemented on the current hardware device.
		/// Vivado Serial I/O analyzer is a link-based analyzer, which lets you link between any transmitter
		/// and receiver within the IBERT design. The links define the communication paths and protocols
		/// between transmitters and receivers of the GigaBit transceivers on the device. You can configure
		/// the links by using the set_property command to specify property values on the link object.
		/// Refer to the Vivado Design Suite User Guide: Programming and Debugging (UG908) for more
		/// information on configuring links.
		/// This command returns the created hw_sio_link object, or returns an error if it fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 300
		/// </summary>
		/// <param name="description">(Optional) Description of link. Default: Link object name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_sio_rx">(Optional) RX endpoint. Default: None</param>
		/// <param name="hw_sio_tx">(Optional) TX endpoint. Default: None</param>
		/// <returns>The new hardware SIO link</returns>
		public TTCL create_hw_sio_link(String description = null, bool? quiet = null, bool? verbose = null, String hw_sio_rx = null, String hw_sio_tx = null)
		{
			// TCL Syntax: create_hw_sio_link [-description <arg>] [-quiet] [-verbose] [<hw_sio_rx>] [<hw_sio_tx>]
			_tcl.Entry(_builder.create_hw_sio_link(description, quiet, verbose, hw_sio_rx, hw_sio_tx));
			return _tcl;
		}
		/// <summary>
		/// Create a new hardware SIO link group.
		///
		///
		/// TCL Syntax: create_hw_sio_linkgroup [-description <arg>] [-quiet] [-verbose] <hw_sio_links>
		///
		/// Create a new group to associate the specified TX to RX communication links on the IBERT debug
		/// core implemented on the current device.
		/// Vivado Serial I/O analyzer is a link-based analyzer. The links define the communication paths and
		/// protocols between transmitters and receivers of the GigaBit transceivers on the device. Link
		/// groups, or hw_sio_linkgroup objects, let you associate links into related groups, to collectively
		/// configure properties and run scans.
		/// This command returns the name of the linkgroup created, or returns an error if the command
		/// fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 303
		/// </summary>
		/// <param name="hw_sio_links">(Required) hardware SIO links</param>
		/// <param name="description">(Optional) Description of link group. Default: Link group object name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The new hardware SIO link group</returns>
		public TTCL create_hw_sio_linkgroup(String hw_sio_links, String description = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_hw_sio_linkgroup [-description <arg>] [-quiet] [-verbose] <hw_sio_links>
			_tcl.Entry(_builder.create_hw_sio_linkgroup(hw_sio_links, description, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Create a new hardware SIO scan. If a Link object is passed in, it must have a RX Endpoint object.
		///
		///
		/// TCL Syntax: create_hw_sio_scan [-description <arg>] [-link_settings <arg>] [-quiet] [-verbose] <scan_type> <hw_sio_object>
		///
		/// Create a serial I/O analyzer scan object for the specified communication link on the IBERT debug
		/// core.
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the
		/// specialized Eye Scan hardware of Xilinx UltraScale devices or 7 series FPGAs. The Vivado serial
		/// I/O analyzer feature lets you to create, run, and save link scans.
		/// This command creates and returns a link scan object that you can use with the
		/// run_hw_sio_scan command to run analysis on the specified links, or GT receivers. You can
		/// also save the scan to disk using the write_hw_sio_scan command.
		/// You can remove the created scan object using remove_hw_sio_scan.
		/// This command returns the hw_sio_scan object, or returns an error if the command fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 305
		/// </summary>
		/// <param name="scan_type">(Required) Scan Type Options: 1d_bathtub, 2d_full_eye</param>
		/// <param name="hw_sio_object">(Required) RX endpoint or Link object to perform scan on.</param>
		/// <param name="description">(Optional) Description of scan Default: Scan object name</param>
		/// <param name="link_settings">
		/// (Optional)
		/// List of Link properties and values to set before running the
		/// scan. Default: None
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The new hardware SIO scan</returns>
		public TTCL create_hw_sio_scan(String scan_type, String hw_sio_object, String description = null, String link_settings = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_hw_sio_scan [-description <arg>] [-link_settings <arg>] [-quiet] [-verbose] <scan_type> <hw_sio_object>
			_tcl.Entry(_builder.create_hw_sio_scan(scan_type, hw_sio_object, description, link_settings, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Create a new hardware SIO sweep. If a Link object is passed in, it must have a RX Endpoint
		/// object.
		///
		///
		/// TCL Syntax: create_hw_sio_sweep [-description <arg>] [-iteration_settings <arg>] [-quiet] [-verbose] <scan_type> [<hw_sio_link>]
		///
		/// Create a serial I/O analyzer link sweep object to run multiple scans across a range of values.
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the
		/// specialized features of Xilinx® UltraScale™ devices or 7 series FPGAs. It can also be helpful to run
		/// multiple scans on a the link with different configuration settings for the GTs. This can help you
		/// determine which settings are best for your design. The Vivado® serial I/O analyzer feature
		/// enables you to define, run, and save link sweeps, or collections of link scans run across a range of
		/// values.
		/// This command creates and returns a link sweep object that you can use with the
		/// run_hw_sio_sweep command to run analysis on the specified links, or GT receivers. You can
		/// also save the sweep scan to disk using the write_hw_sio_sweep command.
		/// You can remove the created sweep object using remove_hw_sio_sweep.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// This command returns the hw_sio_sweep object, or returns an error if the command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 308
		/// </summary>
		/// <param name="scan_type">(Required) Sweep Type Options: 1d_bathtub, 2d_full_eye</param>
		/// <param name="description">(Optional) Description of sweep Default: Sweep object name</param>
		/// <param name="iteration_settings">
		/// (Optional)
		/// List of LINK_SETTINGS for each scan to set before running
		/// the sweep. Default: None
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_sio_link">(Optional) Link object to perform sweep on. Default: None</param>
		/// <returns>The new hardware SIO sweep</returns>
		public TTCL create_hw_sio_sweep(String scan_type, String description = null, String iteration_settings = null, bool? quiet = null, bool? verbose = null, String hw_sio_link = null)
		{
			// TCL Syntax: create_hw_sio_sweep [-description <arg>] [-iteration_settings <arg>] [-quiet] [-verbose] <scan_type> [<hw_sio_link>]
			_tcl.Entry(_builder.create_hw_sio_sweep(scan_type, description, iteration_settings, quiet, verbose, hw_sio_link));
			return _tcl;
		}
		/// <summary>
		/// Create a hw_target (jtag chain) and set its name
		///
		///
		/// TCL Syntax: create_hw_target [-copy <arg>] [-quiet] [-verbose] <target_name>
		///
		/// The Vivado hardware manager supports programming of hardware devices through the use of
		/// Serial Vector Format (SVF) files. SVF files are ASCII files that contain both programming
		/// instructions and configuration data. These files are used by ATE machines and embedded
		/// controllers to perform boundary-scan operations. The SVF file captures the JTAG commands
		/// needed to program the bitstream directly into a Xilinx device, or indirectly into a flash memory
		/// device. The SVF file can be written using the write_hw_svf command, or applied to an open
		/// hw_target through the execute_hw_svf command. Refer to the Vivado Design Suite User Guide:
		/// Programming and Debugging (UG908) for more information.
		/// The specific process for creating the hw_svf file is:
		/// 1. Create an SVF target using create_hw_target.
		/// 2. Open the SVF target.
		/// 3. Create one or more devices on the SVF target using create_hw_device.
		/// 4. Program the devices using commands like program_hw_devices.
		/// 5. Write the SVF file of operation commands using write_hw_svf.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The create_hw_target command creates an SVF hw_target object on the current hw_server
		/// that can be used as a platform for programming devices, and exporting the programming
		/// commands in an SVF file. The SVF target, is a hw_target object that can be queried and managed
		/// like other hw_targets using commands like get_hw_targets and current_hw_target.
		/// Note: When using the SVF flow, Xilinx recommends that you connect to a local hw_server on your system,
		/// as the SVF target does not require connection to an actual hardware board or device.
		/// SVF hw_targets can be identified by the boolean IS_SVF property that can be returned by
		/// get_property or report_property commands. This property is TRUE for SVF targets.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example creates a SVF hw_target object that is a copy of the specified hw_target:
		/// create_hw_target -copy [get_hw_targets *210203327996A] svfTarget
		/// The following example gets the currently defined SVF hw_target objects:
		/// get_hw_targets -filter {IS_SVF}
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The following example shows all of the steps needed for the SVF flow. First open the Vivado
		/// hardware manager and connect to a local hw_server; create and open an SVF hw_target; add a
		/// hw_device and program the bitstream into this device; and write the SVF file capturing the
		/// programming commands for the device:
		/// open_hw
		/// connect_hw_server
		/// create_hw_target my_svf_target
		/// open_hw_target
		/// create_hw_device -part xc7k325t
		/// set_property PROGRAM.FILE {C:/Data/k7_design.bit} [current_hw_device]
		/// program_hw_devices [current_hw_device]
		/// write_hw_svf my_xc7k325t.svf
		/// close_hw_target
		///
		/// See ug835-vivado-tcl-commands.pdf, page 311
		/// </summary>
		/// <param name="target_name">(Required) name of hardware target to create</param>
		/// <param name="copy">(Optional) hardware target copy Default: copy of existing target</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>hardware targets</returns>
		public TTCL create_hw_target(String target_name, String copy = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_hw_target [-copy <arg>] [-quiet] [-verbose] <target_name>
			_tcl.Entry(_builder.create_hw_target(target_name, copy, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get or set the current hardware cfgmem
		///
		///
		/// TCL Syntax: current_hw_cfgmem [-hw_device <args>] [-quiet] [-verbose] [<hw_cfgmem>]
		///
		/// Set or return the current hardware cfgmem object.
		/// The process whereby the design specific data is loaded or programmed into the Xilinx® FPGA is
		/// called configuration. The create_hw_cfgmem command defines a flash memory device used
		/// for configuring and booting the FPGA device.
		/// When a new hw_cfgmem object is created, it becomes the current hw_cfgmem object. You can
		/// use the current_hw_cfgmem to return the current hw_cfgmem object, or you can specify a
		/// hw_cfgmem object, as returned by get_hw_cfgmems, to change the current object.
		/// After the hw_cfgmem object is created, and associated with the hw_device, the configuration
		/// memory can be programmed with the bitstream and other data from a memory configuration file
		/// created with the write_cfgmem command.
		/// The hw_cfgmem object is programmed using the program_hw_cfgmem command.
		/// This command returns the current hardware cfgmem as an object, or returns an error if it fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 392
		/// </summary>
		/// <param name="hw_device">(Optional) list of hardware devices</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_cfgmem">(Optional) list of hardware cfgmems Default: current hardware cfgmem</param>
		/// <returns>hardware cfgmem</returns>
		public TTCL current_hw_cfgmem(TCLParameterList hw_device = null, bool? quiet = null, bool? verbose = null, String hw_cfgmem = null)
		{
			// TCL Syntax: current_hw_cfgmem [-hw_device <args>] [-quiet] [-verbose] [<hw_cfgmem>]
			_tcl.Entry(_builder.current_hw_cfgmem(hw_device, quiet, verbose, hw_cfgmem));
			return _tcl;
		}
		/// <summary>
		/// Get or set the current hardware device
		///
		///
		/// TCL Syntax: current_hw_device [-quiet] [-verbose] [<hw_device>]
		///
		/// Set or return the current Xilinx FPGA targeted by the Hardware Manager in the Vivado Design
		/// Suite for programming and debug.
		/// The hardware target is a system board containing a JTAG chain of one or more Xilinx devices that
		/// you can program with a bitstream file, or use to debug your design. Connections between
		/// hardware targets on the system board and the Vivado Design Suite are managed by the
		/// hw_server application, and the connect_hw_server command. Refer to Vivado Design Suite
		/// User Guide: Programming and Debugging (UG908) for a list of supported JTAG download cables
		/// and devices.
		/// Each hardware target can have one or more Xilinx devices to program, or to use for debugging
		/// purposes. The current device is specified or returned by the current_hw_device command.
		/// To access a Xilinx FPGA through the Hardware Manager, you must use the following Tcl
		/// command sequence:
		/// 1. open_hw - Opens the Hardware Manager in the Vivado Design Suite.
		/// 2. connect_hw_server - Makes a connection to a local or remote Xilinx hardware server
		/// application.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// 3. current_hw_target - Defines the hardware target of the connected server.
		/// 4. open_hw_target - Opens a connection to the hardware target.
		/// 5. current_hw_device - Specifies the Xilinx FPGA to use for programming and debugging.
		/// After connecting to the appropriate hardware device, you can program the device with a
		/// bitstream file using the program_hw_device command, and debug the device using any of a
		/// number of Hardware Manager Tcl commands. To interactively debug the device open the
		/// Hardware Manager in the Vivado Design Suite IDE.
		/// IMPORTANT! You can use the current_hw_server , current_hw_target , and
		/// current_hw_device commands to set the hardware for programming and debugging the design. You
		/// should exercise care when using these commands to insure that the current server, target, and device are in
		/// sync. The current device should be found on the current target, which should be found on the current
		/// server.
		/// This command returns the current hardware device as an object, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 394
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_device">(Optional) hardware device to set as current; optional</param>
		/// <returns>hardware device</returns>
		public TTCL current_hw_device(bool? quiet = null, bool? verbose = null, String hw_device = null)
		{
			// TCL Syntax: current_hw_device [-quiet] [-verbose] [<hw_device>]
			_tcl.Entry(_builder.current_hw_device(quiet, verbose, hw_device));
			return _tcl;
		}
		/// <summary>
		/// Get or set the current hardware ILA
		///
		///
		/// TCL Syntax: current_hw_ila [-quiet] [-verbose] [<hw_ila>]
		///
		/// Set or return the current hardware ILA debug core targeted by the Hardware Manager in the
		/// Vivado Design Suite for programming and debug.
		/// The Integrated Logic Analyzer (ILA) debug core lets you perform in-system debug of
		/// implemented designs, or design bitstreams, on a programmed Xilinx FPGA. The ILA core includes
		/// many advanced features of modern logic analyzers, including boolean trigger equations, and edge
		/// transition triggers. You can use the ILA core to probe specific signals of the design, to trigger on
		/// programmed hardware events, and capture data from the Xilinx FPGA in real-time. Refer to
		/// LogiCORE IP Integrated Logic Analyzer (PG172) for details of the ILA core.
		/// ILA debug cores can be added to a design instantiating an ILA core from the IP catalog into the
		/// RTL design, or using the create_debug_core command to add the ILA core to the synthesized
		/// netlist. Refer to Vivado Design Suite User Guide: Programming and Debugging (UG908) for more
		/// information on adding ILA debug cores to the design.
		/// After generating a bitstream from the design, and programming the device with the
		/// program_hw_devices command, the ILA debug cores in the design are accessible from the
		/// Hardware Manager using the get_hw_ilas command. The debug probes assigned to the ILA
		/// debug cores in the design can be returned with the get_hw_probes command.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// This command returns the current hardware ILA core as an object, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 397
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_ila">(Optional) hardware ILA</param>
		/// <returns>hardware ILA</returns>
		public TTCL current_hw_ila(bool? quiet = null, bool? verbose = null, String hw_ila = null)
		{
			// TCL Syntax: current_hw_ila [-quiet] [-verbose] [<hw_ila>]
			_tcl.Entry(_builder.current_hw_ila(quiet, verbose, hw_ila));
			return _tcl;
		}
		/// <summary>
		/// Get or set the current hardware ILA data
		///
		///
		/// TCL Syntax: current_hw_ila_data [-quiet] [-verbose] [<hw_ila_data>]
		///
		/// Set or return the current ILA debug core data object.
		/// The ILA data object is created in the Vivado logic analyzer using the upload_hw_ila_data
		/// command, or the read_hw_ila_data command. By default, the current hw_ila_data object is
		/// the latest one created by the Vivado logic analyzer. The current_hw_ila_data command can
		/// be used to change that object.
		/// The ILA debug core captures sample data in real-time as the hardware device runs, based on the
		/// event triggers or capture conditions defined on the hw_ila object. The hw_ila object triggers on
		/// the hw_device are armed by the run_hw_ila command.
		/// The ILA data object can be displayed in the waveform window of the Vivado tools logic analyzer
		/// using the display_hw_ila_data command. You can also write the ILA data to disk with the
		/// write_hw_ila_data command to save the ILA debug information for later user and analysis.
		/// This command returns the captured hardware ILA debug core data as an object, or returns an
		/// error if it fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 399
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_ila_data">(Optional) hardware ILA data</param>
		/// <returns>hardware ILA data</returns>
		public TTCL current_hw_ila_data(bool? quiet = null, bool? verbose = null, String hw_ila_data = null)
		{
			// TCL Syntax: current_hw_ila_data [-quiet] [-verbose] [<hw_ila_data>]
			_tcl.Entry(_builder.current_hw_ila_data(quiet, verbose, hw_ila_data));
			return _tcl;
		}
		/// <summary>
		/// Get or set the current hardware server
		///
		///
		/// TCL Syntax: current_hw_server [-quiet] [-verbose] [<hw_server>]
		///
		/// Defines the current hardware server from the list of hardware servers that are connected to the
		/// Vivado Design Suite, or returns the currently connected hardware server object.
		/// Hardware servers are instances of the Xilinx hardware server (hw_server) application running
		/// remotely, or on the local machine. The hardware server manages connections to a hardware
		/// target, such as a hardware board containing a JTAG chain of one or more Xilinx devices to be
		/// used for programming and debugging your FPGA design.
		/// Hardware servers are connected to the Vivado Design Suite with the connect_hw_server
		/// command. The current hardware server, and the current hardware target and device are the
		/// focus of most Hardware Manager Tcl commands. The current target and device can be defined
		/// using the current_hw_target and current_hw_device commands.
		/// Note: There is usually a current hw_server defined, either the last connected hardware server, or one you
		/// have defined with this command. However, if you disconnect the current hardware server, you will need to
		/// define a new current hw_server object.
		/// You can get a list of connected hardware servers using the get_hw_servers command. You
		/// can get a list of available hardware targets and devices using the get_hw_targets and
		/// get_hw_devices commands respectively.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// This command returns a hw_server object. If the <hw_server> is specified as part of the
		/// current_hw_server command, the specified server is defined as the current hardware server
		/// and that object is returned. If no server is specified, the current_hw_server command
		/// returns the current hardware server object.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 401
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_server">(Optional) hardware server</param>
		/// <returns>hardware server</returns>
		public TTCL current_hw_server(bool? quiet = null, bool? verbose = null, String hw_server = null)
		{
			// TCL Syntax: current_hw_server [-quiet] [-verbose] [<hw_server>]
			_tcl.Entry(_builder.current_hw_server(quiet, verbose, hw_server));
			return _tcl;
		}
		/// <summary>
		/// Get or set the current hardware target
		///
		///
		/// TCL Syntax: current_hw_target [-quiet] [-verbose] [<hw_target>]
		///
		/// After opening the Hardware Manager in the Vivado Design Suite, and connecting to the Xilinx
		/// hardware server (hw_server) using the connect_hw_server command, you will need to set
		/// the hardware target. This command sets or returns the current hardware target.
		/// The hardware target is a system board containing a JTAG chain of one or more Xilinx devices that
		/// you can program with a bitstream file, or use to debug your design. Connections between
		/// hardware targets on the system board and the Vivado Design Suite are managed by the
		/// hw_server object. Refer to Vivado Design Suite User Guide: Programming and Debugging (UG908)
		/// for a list of supported JTAG download cables and devices.
		/// The available hardware targets are defined when the Vivado tools Hardware Manager is
		/// connected to a hw_server. You can return a list of the available hardware targets using the
		/// get_hw_targets command, and define the current hardware target using the
		/// current_hw_target command.
		/// If the <hw_target> is specified as part of the current_hw_target command, the specified
		/// target is defined as the current hardware target and that object is returned. If no hardware target
		/// is specified, the current_hw_target command returns the current hardware target object.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Each hardware target can have one or more Xilinx devices to program, or to use for debugging
		/// purposes. The current device is specified or returned by the current_hw_device command.
		/// After specifying the current hardware target, you can open the connection through the hardware
		/// target, to the Xilinx device using the open _hw_target command.
		/// IMPORTANT! You can use the current_hw_server , current_hw_target , and
		/// current_hw_device commands to set the hardware for programming and debugging the design. You
		/// should exercise care when using these commands to insure that the current server, target, and device are in
		/// sync. The current device should be found on the current target, which should be found on the current
		/// server.
		/// This command returns the current hardware target as an object, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 403
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_target">(Optional) hardware target</param>
		/// <returns>hardware target</returns>
		public TTCL current_hw_target(bool? quiet = null, bool? verbose = null, String hw_target = null)
		{
			// TCL Syntax: current_hw_target [-quiet] [-verbose] [<hw_target>]
			_tcl.Entry(_builder.current_hw_target(quiet, verbose, hw_target));
			return _tcl;
		}
		/// <summary>
		/// Delete hardware AXI Transaction objects
		///
		///
		/// TCL Syntax: delete_hw_axi_txn [-quiet] [-verbose] <hw_axi_txns>...
		///
		/// This command deletes the named AXI transaction objects, hw_axi_txn, from the specified hw_axi
		/// objects.
		/// The create_hw_axi_txn command cannot create an object of the same name as an existing
		/// object. Use this command to delete any existing objects prior to creating new AXI transaction
		/// objects.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 445
		/// </summary>
		/// <param name="hw_axi_txns">(Required) hardware AXI Transaction object to delete</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_hw_axi_txn(TCLParameterList hw_axi_txns, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_hw_axi_txn [-quiet] [-verbose] <hw_axi_txns>...
			_tcl.Entry(_builder.delete_hw_axi_txn(hw_axi_txns, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Removes the HW Bitstream object from a list of hardware devices.
		///
		///
		/// TCL Syntax: delete_hw_bitstream [-of_objects <args>] [-quiet] [-verbose]
		///
		/// This command deletes the hw_bitstream object from the specified hw_device objects.
		/// This clears the PROGRAM.HW_BITSTREAM and PROGRAM.FILE properties on the hw_device
		/// objects, and deletes the hw_bitstream object.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 447
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
		/// Removes hw_cfgmem object from memory
		///
		///
		/// TCL Syntax: delete_hw_cfgmem [-quiet] [-verbose] <cfgmem>
		///
		/// Removes the specified hw_cfgmem object from the current hw_device.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 449
		/// </summary>
		/// <param name="cfgmem">(Required) Valid hw_cfgmem object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_hw_cfgmem(String cfgmem, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_hw_cfgmem [-quiet] [-verbose] <cfgmem>
			_tcl.Entry(_builder.delete_hw_cfgmem(cfgmem, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Delete hardware probe objects
		///
		///
		/// TCL Syntax: delete_hw_probe [-quiet] [-verbose] <hw_probes>...
		///
		/// Delete a user-defined probe from the current hw_ila. The user-define probe must be created by
		/// the create_hw_probe command.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example deletes a user-defined hw_probe object on the current ILA core:
		/// delete_hw_probe [get_hw_probe probeAR]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 451
		/// </summary>
		/// <param name="hw_probes">(Required) hardware probe objects to delete</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL delete_hw_probe(TCLParameterList hw_probes, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: delete_hw_probe [-quiet] [-verbose] <hw_probes>...
			_tcl.Entry(_builder.delete_hw_probe(hw_probes, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Delete a hw_target
		///
		///
		/// TCL Syntax: delete_hw_target [-quiet] [-verbose] [<target_object>]
		///
		/// This command deletes a virtual hardware target from the current_hw_server.
		/// The hw_target object must be a virtual target created by the create_hw_target command, or
		/// an error will be returned.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example deletes the specified hw_target:
		/// delete_hw_target [lindex [get_hw_targets] 1]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 453
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="target_object">(Optional) hardware target object to delete Default: current_hw_target</param>
		public TTCL delete_hw_target(bool? quiet = null, bool? verbose = null, String target_object = null)
		{
			// TCL Syntax: delete_hw_target [-quiet] [-verbose] [<target_object>]
			_tcl.Entry(_builder.delete_hw_target(quiet, verbose, target_object));
			return _tcl;
		}
		/// <summary>
		/// Automatically detect links between RX and TX endpoints. Create a new link group to contain the
		/// links.
		///
		///
		/// TCL Syntax: detect_hw_sio_links [-force] [-quiet] [-verbose]
		///
		/// Automatically detects existing or previously defined communication pathways between GT
		/// transmitters and receivers that are defined on the open hardware target.
		/// You can use this command if you change board connections while the serial I/O analyzer is
		/// running. The detection algorithm uses changing transmit patterns and detects links on received
		/// patterns to determine how GTs are connected to one another on the open hardware target.
		/// A transmitter or receiver of an individual GT on the IBERT debug core can only be used in one
		/// hw_sio_link at a time, so the command will not check GTs that are used in existing links. The -
		/// force option lets you clear all existing links before scanning the open hardware target to check
		/// all GTs.
		/// The detect_hw_sio_links command defines the found links, and creates a link group to
		/// associate the new links.
		/// This command returns the number of links found and the created hw_sio_linkgroup object, or
		/// returns an error if it fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 488
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
		/// Close a connection to a hardware server
		///
		///
		/// TCL Syntax: disconnect_hw_server [-quiet] [-verbose] [<hw_server>]
		///
		/// Disconnect the current or specified Vivado tools hardware server from the Vivado Design Suite.
		/// The current hardware server is either the last connected hardware server, or one you have
		/// manually defined with the current_hw_server command. If you disconnect the current
		/// hardware server, there will be no defined current hardware server until you define a new current
		/// hw_server object.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 496
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_server">(Optional) hardware server Default: current hardware server</param>
		public TTCL disconnect_hw_server(bool? quiet = null, bool? verbose = null, String hw_server = null)
		{
			// TCL Syntax: disconnect_hw_server [-quiet] [-verbose] [<hw_server>]
			_tcl.Entry(_builder.disconnect_hw_server(quiet, verbose, hw_server));
			return _tcl;
		}
		/// <summary>
		/// Display hardware ILA data in viewer
		///
		///
		/// TCL Syntax: display_hw_ila_data [-wcfg <arg>] [-reset] [-quiet] [-verbose] [<hw_ila_data>...]
		///
		/// This command is intended for use with the graphical user interface of the Vivado Design Suite
		/// logic analyzer feature. It displays the specified ILA debug core data object in a wave config
		/// window of the Vivado logic analyzer.
		/// The ILA debug sample data is acquired from a running device using the upload_hw_ila_data
		/// command. This creates a hw_ila_data object that can be written to a file on disk using the
		/// write_hw_ila_data command. This command reads that ILA data file.
		/// The display characteristics of the ILA debug core in the waveform window are determined by the
		/// Wave Config file. The Wave Config file contains just the list of wave objects (signals, dividers,
		/// groups, virtual buses) to display, and their display properties, plus markers.
		/// A wave configuration object is created in the Vivado logic analyzer with the
		/// create_wave_config command. A Wave Config file is written to disk by the use of the
		/// save_wave_config command, and can be opened with the open_wave_config command.
		/// The open_wave_config command opens a Wave Config file and maps it to the data source in
		/// the current simulation.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 501
		/// </summary>
		/// <param name="wcfg">(Optional) Import alternate wave config file</param>
		/// <param name="reset">(Optional) Force reset wave config file to default configuration</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_ila_data">(Optional) List of hardware ILA data objects. Default: Current hardware ILA data</param>
		public TTCL display_hw_ila_data(String wcfg = null, bool? reset = null, bool? quiet = null, bool? verbose = null, TCLParameterList hw_ila_data = null)
		{
			// TCL Syntax: display_hw_ila_data [-wcfg <arg>] [-reset] [-quiet] [-verbose] [<hw_ila_data>...]
			_tcl.Entry(_builder.display_hw_ila_data(wcfg, reset, quiet, verbose, hw_ila_data));
			return _tcl;
		}
		/// <summary>
		/// Display an existing hardware SIO scan.
		///
		///
		/// TCL Syntax: display_hw_sio_scan [-quiet] [-verbose] <hw_sio_scans>
		///
		/// This command is intended for use with the graphical user interface of the Vivado Design Suite
		/// serial I/O analyzer feature. It displays the specified SIO scan data object, or objects, in a Scan
		/// Plots window of the Vivado IDE.
		/// The SIO scan data can be read from a file on disk using the read_hw_sio_scan command, or
		/// from a hw_sio_scan object created by the run_hw_sio_scan command. The type of plot
		/// displayed is determined by the <scan_type> of the hw_sio_scan object.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 503
		/// </summary>
		/// <param name="hw_sio_scans">(Required) hardware SIO scans</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL display_hw_sio_scan(String hw_sio_scans, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: display_hw_sio_scan [-quiet] [-verbose] <hw_sio_scans>
			_tcl.Entry(_builder.display_hw_sio_scan(hw_sio_scans, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Execute SVF file on current_hw_target
		///
		///
		/// TCL Syntax: execute_hw_svf [-quiet] [-verbose] <file_name>
		///
		/// The Vivado hardware manager supports programming of hardware devices through the use of
		/// Serial Vector Format (SVF) files. SVF files are ASCII files that contain both programming
		/// instructions and configuration data. These files are used by ATE machines and embedded
		/// controllers to perform boundary-scan operations. The SVF file is an ASCII files that captures the
		/// JTAG commands needed to program the bitstream directly into a Xilinx device, or indirectly into a
		/// flash memory device. The SVF file can be written using the write_hw_svf command, or used
		/// to program a device through the execute_hw_svf command. Refer to the Vivado Design Suite
		/// User Guide: Programming and Debugging (UG908) for more information.
		/// The execute_hw_svf command converts the SVF commands into Vivado Tcl commands and
		/// executes them on the specified target. This process could take some time depending on how big
		/// the SVF file is. The command requires an open, current hw_target object, with a JTAG chain that
		/// matches the device chain specified in the SVF file.
		/// TIP: The execute_hw_svf command is not a general purpose SVF reader, and should only be used to
		/// read and execute SVF files written by the Vivado tools.
		/// This command returns a transcript of its process, or returns an error if it fails.
		///
		/// The following example executes the specified SVF command file in verbose mode to display all of
		/// the commands being run:
		/// open_hw_target {houdini26:3121/xilinx_tcf/Digilent/210203327996A}
		/// execute_hw_svf -verbose C:/Data/k7_design.svf
		///
		/// See ug835-vivado-tcl-commands.pdf, page 512
		/// </summary>
		/// <param name="file_name">(Required) SVF filename</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL execute_hw_svf(String file_name, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: execute_hw_svf [-quiet] [-verbose] <file_name>
			_tcl.Entry(_builder.execute_hw_svf(file_name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get a list of cfgmem_parts available in the software
		///
		///
		/// TCL Syntax: get_cfgmem_parts [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
		///
		/// Get a list of configuration flash memory devices supported by the Vivado Design Suite or Vivado
		/// Lab Edition.
		/// Xilinx® FPGAs can be configured from an external nonvolatile memory device, or they can be
		/// configured by an external smart source, such as a microprocessor, DSP processor,
		/// microcontroller, PC, or board tester. The two configuration datapaths include a serial datapath
		/// that is used to minimize the device pin requirements for configuration, and a parallel 8-bit, 16-bit,
		/// or 32-bit datapath used for higher performance or link to industry-standard interfaces ideal for
		/// external data sources like processors, or x8- or x16-parallel flash memory.
		/// The process whereby the design specific data is loaded or programmed into the Xilinx FPGA is
		/// called configuration. The create_hw_cfgmem command defines a flash memory device used
		/// for configuring and booting the hardware device.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// After the hw_cfgmem object is created, and associated with the hw_device, the configuration
		/// memory can be programmed with the bitstream and other data from a memory configuration file
		/// created with the write_cfgmem command. The hw_cfgmem object is programmed using the
		/// program_hw_cfgmem command.
		/// The configuration memory part can be used to define the hardware configuration memory in the
		/// Hardware Manager of the Vivado Design Suite, to enable programming and debugging the design
		/// in the FPGA hardware. Use the create_hw_cfgmem command to define the configuration
		/// memory for use with the current hardware device.
		/// This command returns a list of cfgmem_part objects that match the specified search criteria, or
		/// returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 653
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="of_objects">(Optional) Get 'cfgmem_part' objects of these types: 'part hw_device'.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'cfgmem_part' objects against patterns. Default: *</param>
		/// <returns>list of cfgmem_part objects</returns>
		public TTCL get_cfgmem_parts(bool? regexp = null, bool? nocase = null, String filter = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_cfgmem_parts [-regexp] [-nocase] [-filter <arg>] [-of_objects <args>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_cfgmem_parts(regexp, nocase, filter, of_objects, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of hardware AXI transactions.
		///
		///
		/// TCL Syntax: get_hw_axi_txns [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the read or write transactions for the specified JTAG to AXI Master core, hw_axi object.
		/// The JTAG to AXI Master is a customizable IP core that works as an AXI Master to drive AXI
		/// transactions and drive AXI signals that are internal to the hardware device. This IP can be used in
		/// Vivado® IP integrator or can be instantiated in HDL in a Vivado project.
		/// The JTAG-AXI core supports all memory-mapped AXI interfaces, except AXI4-Stream, and
		/// supports the AXI-Lite protocol. The AXI interface can be selected as a property of the core. The
		/// width of AXI data bus is customizable. This IP can drive any AXI4-Lite or Memory Mapped Slave
		/// directly, and can also be connected as the AXI Master to the interconnect. Run-time interaction
		/// with this core requires the use of the Vivado logic analyzer feature. Detailed documentation on
		/// the IP core can be found in the LogiCORE IP JTAG to AXI Master Product Guide (PG174). A tutorial
		/// showing its use can be found in the Vivado Design Suite Tutorial: Programming and Debugging
		/// (UG936).
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The JTAG to AXI Master core must be instantiated in the RTL code, from the Xilinx IP catalog.
		/// AXI transactions are defined as complete READ or WRITE transactions between the AXI master
		/// and various slaves.
		/// This command returns a list of hw_axi_txn objects on the hw_device, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 708
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_axi_txn' objects of these types: 'hw_axi'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_axi_txn' objects against patterns. Default: *</param>
		/// <returns>hw_axi_txns</returns>
		public TTCL get_hw_axi_txns(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_axi_txns [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_axi_txns(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of hardware AXI objects.
		///
		///
		/// TCL Syntax: get_hw_axis [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the JTAG to AXI Master core objects, or hw_axi objects, defined on the current hardware
		/// device.
		/// The JTAG to AXI Master is a customizable IP core that works as an AXI Master to drive AXI
		/// transactions and drive AXI signals that are internal to the hardware device. This IP can be used in
		/// Vivado® IP integrator or can be instantiated from the Xilinx® IP catalog into the HDL of a Vivado
		/// project. Run-time interaction with this core requires the use of the Vivado logic analyzer feature.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The JTAG-AXI core supports all memory-mapped AXI interfaces, except AXI4-Stream, and
		/// supports the AXI-Lite protocol. The AXI interface can be defined as a property of the core. The
		/// width of the AXI data bus is customizable. This IP can drive any AXI4-Lite or Memory Mapped
		/// Slave directly, and can also be connected as the AXI Master to the interconnect. Detailed
		/// documentation on the IP core can be found in the LogiCORE IP JTAG to AXI Master Product Guide
		/// (PG174). A tutorial showing its use can be found in the Vivado Design Suite Tutorial: Programming
		/// and Debugging (UG936).
		/// AXI cores can be found in the synthesized or implemented design netlist using the
		/// get_debug_cores command. This will return instances of the debug cores in the design that
		/// are related to the hw_axi objects, and other debug cores on the hw_device.
		/// This command returns a list of AXI Master core objects, hw_axis, on the hw_device, or returns an
		/// error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 711
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_axi' objects of these types: 'hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_axi' objects against patterns. Default: *</param>
		/// <returns>hw_axi</returns>
		public TTCL get_hw_axis(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_axis [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_axis(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of hardware cfgmems.
		///
		///
		/// TCL Syntax: get_hw_cfgmems [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Get a list of hardware configuration memory (hw_cfgmem) objects created for the current
		/// hw_device.
		/// Xilinx FPGAs are configured by loading design-specific configuration data, in the form of a
		/// bitstream file, into the internal memory of the hw_device. The hw_cfgmem defines a flash
		/// memory device used for configuring and booting the Xilinx FPGA device. Once the hw_cfgmem
		/// object is created, and associated with the hw_device, the configuration memory can be
		/// programmed with the bitstream and other data using the program_hw_cfgmem command.
		/// The hw_cfgmem object is associated with the specified hw_device object through the
		/// PROGRAM.HW_CFGMEM property on the device object. The get_hw_cfgmems command lets
		/// you work with the hw_cfgmem object.
		/// This command returns a list of hw_cfgmem objects that match the specified search criteria, or
		/// returns an error if it fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 714
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_cfgmem' objects against patterns. Default: *</param>
		/// <returns>hardware cfgmems</returns>
		public TTCL get_hw_cfgmems(bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_cfgmems [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_cfgmems(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of Versal integrated and soft DDRMC cores.
		///
		///
		/// TCL Syntax: get_hw_ddrmcs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Xilinx Versal devices include integrated DDR Memory Controllers (DDRMC), as well as fabric
		/// based memory controllers. Refer to the LogiCore IP Product Guide: Versal ACAP Network on Chip
		/// and Integrated Memory Controller (PG313) for more information on the integrated controller core.
		/// Refer to Versal ACAP Soft DDR4 Memory IP (PG353) for more information on the fabric based
		/// memory controller. The memory controllers contain memory configuration and memory
		/// calibration data that can be accessed from the Xilinx Vivado Hardware Manager. The calibration
		/// and margin data are organized and presented in a graphical format for ease of analysis.
		/// The get_hw_ddrmc command returns a list of memory cores on the current hardware device.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example returns the HBM with the specified DISPLAY_NAME:
		/// get_hw_hbms -filter {DISPLAY_NAME == HBM_2}
		/// The following example returns the DDRMC with the specified DISPLAY_NAME:
		/// get_hw_ddrmcs -filter {DISPLAY_NAME == DDRMC_1}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 717
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_ddrmc' objects of these types: 'hw_server
		/// hw_target hw_device'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_ddrmc' objects against patterns. Default: *</param>
		/// <returns>integrated and soft DDRMC cores</returns>
		public TTCL get_hw_ddrmcs(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_ddrmcs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_ddrmcs(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of hardware devices.
		///
		///
		/// TCL Syntax: get_hw_devices [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the hardware devices on the open target of a connected hardware server.
		/// Each hardware target can have one or more Xilinx devices to program, or to use for debugging
		/// purposes. The current device is specified or returned by the current_hw_device command.
		/// This command returns a list of available hardware device objects, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 720
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_device' objects of these types: 'hw_target'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_device' objects against patterns. Default: *</param>
		/// <returns>hardware devices</returns>
		public TTCL get_hw_devices(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_devices [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_devices(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware HBM cores.
		///
		///
		/// TCL Syntax: get_hw_hbms [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Certain Xilinx® UltraScale+ devices include an integrated High-Bandwidth Memory (HBM)
		/// controller. Refer to the LogiCore IP Product Guide: AXI High Bandwidth Memory Controller
		/// (PG276) for more information on this core. The HBM controller and memory stacks contain both
		/// performance counters and temperature sensors that can be accessed through an HBM activity
		/// monitor (amon) from within the Xilinx Vivado hardware manager. The HBM activity monitor can
		/// be used to gain real-time access to performance monitoring and temperature sensors on the
		/// physical device. The Vivado hardware manager displays read, write, and overall throughput of
		/// data, as well as the device temperature. The activity monitor displays, captures, and exports data
		/// to a CSV file when it is running.
		/// The get_hw_hbms command returns a list of HBM cores on the current hardware target.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example returns the HBM with the specified DISPLAY_NAME:
		/// get_hw_hbms -filter {DISPLAY_NAME == HBM_2}
		/// This example returns all the HBM objects in the current device:
		/// get_hw_hbms
		///
		/// See ug835-vivado-tcl-commands.pdf, page 723
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_hbm' objects of these types: 'hw_server hw_target hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_hbm' objects against patterns. Default: *</param>
		/// <returns>hardware HBM cores</returns>
		public TTCL get_hw_hbms(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_hbms [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_hbms(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of hardware ILA data objects.
		///
		///
		/// TCL Syntax: get_hw_ila_datas [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the ILA data objects in the Vivado logic analyzer.
		/// The upload_hw_ila_data command creates a hw_ila_data object in the process of moving
		/// the captured data from the ILA debug core, hw_ila, on the physical FPGA device, hw_device. The
		/// read_hw_ila_data command can also create a hw_ila_data object when reading an ILA data
		/// file from disk.
		/// The hw_ila_data object can be viewed in the waveform viewer of the Vivado logic analyzer by
		/// using the display_hw_ila_data command, and can be written to disk using the
		/// write_hw_ila_data command.
		/// This command returns a list of available hardware ILA data objects, or returns an error if it fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 726
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_ila_data' objects of these types: 'hw_ila hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_ila_data' objects against patterns. Default: *</param>
		/// <returns>hardware ILA data</returns>
		public TTCL get_hw_ila_datas(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_ila_datas [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_ila_datas(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of hardware ILA.
		///
		///
		/// TCL Syntax: get_hw_ilas [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the ILA debug core objects defined on the current hardware device.
		/// The Integrated Logic Analyzer (ILA) debug core lets you perform in-system debug of
		/// implemented designs, or design bitstreams, on a programmed Xilinx FPGA. The ILA core includes
		/// many advanced features of modern logic analyzers, including boolean trigger equations, and edge
		/// transition triggers. You can use the ILA core to probe specific signals of the design, to trigger on
		/// programmed hardware events, and capture data from the Xilinx FPGA in real-time. Refer to
		/// LogiCORE IP Integrated Logic Analyzer (PG172) for details of the ILA core.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// You can add ILA debug cores into the RTL source files of a design, or in the synthesized netlist
		/// using the create_debug_core command. Refer to the Vivado Design Suite User Guide: Vivado
		/// Programming and Debugging (UG908) for more information on adding debug cores and signal
		/// probes to the design. You can get the debug cores in the synthesized netlist by using the
		/// get_debug_core commands. However, though they are related, the design debug cores are
		/// separate from the hardware debug cores found in the Hardware Manager feature of the Vivado
		/// Design Suite.
		/// Debug cores and probes are written to the probes file (.ltx) using the write_debug_probes
		/// command and associated with the hardware device, along with the bitstream file (.bit), using
		/// the PROBES.FILE and PROGRAM.FILE properties of the hw_device object. The hardware device
		/// is programmed with this information using the program_hw_devices command.
		/// The steps to debug your design in hardware using an ILA debug core are:
		/// 1. Connect to the hardware server and target using connect_hw_server and
		/// open_hw_target.
		/// 2. Program the FPGA with the bitstream (.bit) and probes (.ltx) files using
		/// program_hw_devices.
		/// 3. Set up the ILA debug core trigger and capture controls using set_property to set
		/// properties of the ILA.
		/// 4. Arm the ILA debug core trigger using run_hw_ila.
		/// 5. View the captured data from the ILA debug core in the Waveform window of the Vivado
		/// logic analyzer feature using display_hw_ila_data.
		/// 6. Optionally use the VIO debug core to drive control signals and/or view design status signals.
		/// See get_hw_vios for more information.
		/// 7. Optionally use the JTAG-to-AXI Master debug core to run transactions to interact with
		/// various AXI slave cores in your design. See get_hw_axis for more information.
		/// This command returns a list of ILA debug core objects on the device, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 729
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_ila' objects of these types: 'hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_ila' objects against patterns. Default: *</param>
		/// <returns>hardware ILAs</returns>
		public TTCL get_hw_ilas(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_ilas [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_ilas(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware Migs cores.
		///
		///
		/// TCL Syntax: get_hw_migs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the hw_mig objects on the current hardware device.
		/// Memory IP included in the Xilinx IP catalog are used to generate memory controllers and
		/// interfaces for Xilinx® devices. Memory IP includes different IP cores from the Xilinx IP catalog
		/// depending on the device architecture and memory interface specified. Refer to Zynq-7000 SoC
		/// and 7 Series Devices Memory Interface Solutions (UG586), or UltraScale Architecture-Based FPGAs
		/// Memory Interface Solutions (PG150), for details of the available memory IP.
		/// When added to a design, the memory IP needs to be implemented into the design. This occurs
		/// after the design is synthesized, during the design optimization phase of implementation, or
		/// opt_design, or can be done manually with the implement_mig_cores command.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// A memory controller can be debug enabled when added into the design from the Xilinx IP
		/// catalog. In the Vivado logic analyzer, or the Vivado Lab Edition, memory controllers implemented
		/// into a design are associated with hw_mig objects, one hw_mig object per debug-enabled memory
		/// controller. The hw_mig object will have all the properties needed to get the calibration status and
		/// draw the per-bit eye margin views.
		/// In the Vivado logic analyzer, or Vivado Lab Edition, the hw_mig object lets you verify the
		/// calibration and read window margins in your memory interface design. You can use the hardware
		/// manager GUI to check the calibration status, verify the read margin for both rising and falling
		/// edges of the clock or DQS. You can also use an ILA core to verify the data integrity for the read
		/// and write operations.
		/// This command returns a list of hw_mig objects on the current hardware device, or returns an
		/// error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 733
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_mig' objects of these types: 'hw_server hw_target hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_mig' objects against patterns. Default: *</param>
		/// <returns>hardware migs cores</returns>
		public TTCL get_hw_migs(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_migs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_migs(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of soft PCIe core(s).
		///
		///
		/// TCL Syntax: get_hw_pcies [-of_objects <args>] [-regexp] [-nocase] [-patterns <arg>] [-filter <arg>] [-quiet] [-verbose]
		///
		/// Get all the Peripheral Component Interconnect Express (PCIe) debug core objects, hw_pcie's,
		/// defined on the current hardware device.
		/// The customizable LogiCORE IP PCIe core for Xilinx ACAPs is designed for evaluating and
		/// monitoring the PCIe Link Training and Status State Machine (LTSSM) running on the Gigabit
		/// Transceivers (GTs). In the Vivado Hardware Manager, Versal PCIe soft cores implemented in the
		/// design, are represented as hw_pcie objects. You can use these PCIe debug cores to solve a range
		/// of debug and validation problems; from viewing the PCIe link info to the LTSSM state transition
		/// diagram.
		/// This command returns a list of PCIe debug core objects on the device, or returns an error if it
		/// fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// The following example returns all the available PCIe cores
		/// get_hw_pcies
		/// The following example returns PCIe core with the specified DISPLAY_NAME
		/// get_hw_pcies -filter {NAME == "PCIe_0"}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 737
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
		/// Get a list of hardware probes.
		///
		///
		/// TCL Syntax: get_hw_probes [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the hw_probe objects in the Hardware Manager that are defined on signals in the design,
		/// or that are assigned to the specified ILA or VIO debug cores.
		/// You can add ILA and VIO debug cores in the RTL source files of a design by customizing the core
		/// from the IP catalog, or add ILA debug cores into the synthesized netlist using the
		/// create_debug_core command.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Signals in the design can be probed to monitor signal values and track hardware events on the
		/// FPGA device. Debug probes can be added to ILA debug cores in the synthesized netlist design
		/// using the create_debug_port command, and connected to signals in the design using
		/// connect_debug_port. Probes can only be added to VIO debug cores when the IP core is
		/// customized, or re-customized, from the IP catalog, and signals connected to it in the RTL design.
		/// Refer to the Vivado Design Suite User Guide: Vivado Programming and Debugging (UG908) for more
		/// information on adding ILA and VIO debug cores and signal probes to the design.
		/// Debug cores and probes are written to a probes file (.ltx) with write_debug_probes, and
		/// associated with the hardware device, along with the bitstream file (.bit), using the PROBES.FILE
		/// and PROGRAM.FILE properties of the hw_device object. The hardware device is programmed
		/// with this information using the program_hw_devices command.
		/// This command returns a list of debug probe objects on the device, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 740
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_probe' objects of these types: 'hw_interface hw_ila hw_vio'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_probe' objects against patterns. Default: *</param>
		/// <returns>hardware probes</returns>
		public TTCL get_hw_probes(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_probes [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_probes(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of hardware servers.
		///
		///
		/// TCL Syntax: get_hw_servers [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// IMPORTANT! You must use the open_hw command to open the Hardware Manager in the Vivado
		/// Design Suite before using this command.
		/// This command returns hardware server objects that are connected to the current instance of the
		/// Vivado Design Suite through the use of the connect_hw_server command.
		/// Hardware servers are instances of the Xilinx hardware server (hw_server) application running
		/// remotely, or on the local machine. The hardware server manages connections to a hardware
		/// target, for instance a hardware board containing a JTAG chain of one or more Xilinx devices to be
		/// used for programming and debugging your FPGA design.
		/// This command returns a list of connected hardware server objects.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 744
		/// </summary>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_server' objects against patterns. Default: *</param>
		/// <returns>hardware servers</returns>
		public TTCL get_hw_servers(bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_servers [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_servers(regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO GT commons.
		///
		///
		/// TCL Syntax: get_hw_sio_commons [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the QPLL objects, hw_sio_commons, defined on the IBERT debug core on the current
		/// hardware device.
		/// For each serial transceiver channel, there is a ring PLL called Channel PLL (CPLL). In Xilinx
		/// UltraScale and 7 series FPGAs, the high-speed transceivers have an additional common or shared
		/// PLL per quad, or Quad PLL (QPLL). This QPLL is a shared LC PLL to support high speed, high
		/// performance, and low power multi-lane applications.
		/// On the device, the GTXE2_CHANNEL component has the serial transceiver and CPLL units and
		/// the GTXE2_COMMON has the QPLL unit.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// This command returns a list of QPLL objects on the device as hw_sio_common objects, or returns
		/// an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 747
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_sio_common' objects of these types: 'hw_server
		/// hw_target hw_device hw_sio_ibert hw_sio_gtgroup
		/// hw_sio_pll'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_common' objects against patterns. Default: *</param>
		/// <returns>hardware SIO GT commons</returns>
		public TTCL get_hw_sio_commons(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_commons [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_commons(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO GT groups.
		///
		///
		/// TCL Syntax: get_hw_sio_gtgroups [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the groups of GTs, hw_sio_gtgroups, as they relate to the quads that are in use on the
		/// IBERT debug core on the current hardware device.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// GT groups, relate to the IO Banks on the hardware device, with the number of available banks
		/// and GT pins determined by the target device. On the Kintex-7 xc7k325 part, for example, there
		/// are four quads, each containing four differential GT pins, and two differential REFCLK pins. Each
		/// GT pin has its own transmitter, TX, and receiver, RX. Quads can also include one shared PLL per
		/// quad, or Quad PLL. The quads are defined on the IBERT debug core, and can be customized with
		/// a number of user settings when the IBERT is added into the RTL design. Refer to the LogiCORE IP
		/// Integrated Bit Error Ratio Tester (IBERT) for 7 Series GTX Transceivers v3.0 (PG132)or to 7 Series
		/// FPGAs GTX/GTH Transceivers User Guide (UG476) or UltraScale Architecture GTH Transceivers User
		/// Guide (UG576) for more information.
		/// This command returns a list of GT group objects on the IBERT debug core, or returns an error if it
		/// fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 750
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_sio_gtgroup' objects of these types: 'hw_server
		/// hw_target hw_device hw_sio_ibert hw_sio_common
		/// hw_sio_pll hw_sio_gt hw_sio_tx hw_sio_rx'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_gtgroup' objects against patterns. Default: *</param>
		/// <returns>hardware SIO GT groups.</returns>
		public TTCL get_hw_sio_gtgroups(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_gtgroups [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_gtgroups(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO GTs.
		///
		///
		/// TCL Syntax: get_hw_sio_gts [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the Gigabit Transceiver objects (GTs), hw_sio_gt, that are in use on the IBERT debug core
		/// on the current hardware device.
		/// The customizable LogiCORE™ IP Integrated Bit Error Ratio Tester (IBERT) core for Xilinx® FPGAs
		/// is designed for evaluating and monitoring the Gigabit Transceivers (GTs). The IBERT core enables
		/// in-system serial I/O validation and debug, letting you measure and optimize your high-speed
		/// serial I/O links in your FPGA-based system. Refer to the LogiCORE IP Integrated Bit Error Ratio
		/// Tester (IBERT) for 7 Series GTX Transceivers v3.0 (PG132)or to 7 Series FPGAs GTX/GTH Transceivers
		/// User Guide (UG476) or UltraScale Architecture GTH Transceivers User Guide (UG576) for more
		/// information.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Using the IBERT debug core you can configure and tune the GT transmitters and receivers
		/// through the Dynamic Reconfiguration Port (DRP) port of the GTX transceiver. This lets you
		/// change property settings on the GTs, as well as registers that control the values on the ports.
		/// This command returns a list of GT objects on the IBERT debug core, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 754
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_sio_gt' objects of these types: 'hw_server hw_target
		/// hw_device hw_sio_ibert hw_sio_gtgroup hw_sio_pll hw_sio_tx
		/// hw_sio_rx hw_sio_link'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_gt' objects against patterns. Default: *</param>
		/// <returns>hardware SIO GTs</returns>
		public TTCL get_hw_sio_gts(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_gts [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_gts(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO IBERT cores.
		///
		///
		/// TCL Syntax: get_hw_sio_iberts [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the Integrated Bit Error Ratio Tester (IBERT) debug core objects, hw_sio_ibert, defined
		/// on the current hardware device.
		/// The customizable LogiCORE™ IP Integrated Bit Error Ratio Tester (IBERT) core for Xilinx® FPGAs
		/// is designed for evaluating and monitoring the Gigabit Transceivers (GTs). The IBERT core enables
		/// in-system serial I/O validation and debug, letting you measure and optimize your high-speed
		/// serial I/O links in your FPGA-based system. Refer to the LogiCORE IP Integrated Bit Error Ratio
		/// Tester (IBERT) for 7 Series GTX Transceivers v3.0 (PG132) for more information.
		/// The IBERT debug core lets you configure and control the major features of GTs on the device,
		/// including:
		/// • TX pre-emphasis and post-emphasis
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// • TX differential swing
		/// • RX equalization
		/// • Decision Feedback Equalizer (DFE)
		/// • Phase-Locked Loop (PLL) divider settings
		/// You can use the IBERT core when you are interested in addressing a range of in-system debug
		/// and validation problems; from simple clocking and connectivity issues to complex margin analysis
		/// and channel optimization issues.
		/// This command returns a list of IBERT debug core objects on the device, or returns an error if it
		/// fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 757
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_sio_ibert' objects of these types: 'hw_server
		/// hw_target hw_device hw_sio_gtgroup hw_sio_gt
		/// hw_sio_common hw_sio_pll hw_sio_tx hw_sio_rx hw_sio_link'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_ibert' objects against patterns. Default: *</param>
		/// <returns>hardware SIO IBERT cores.</returns>
		public TTCL get_hw_sio_iberts(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_iberts [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_iberts(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO link groups.
		///
		///
		/// TCL Syntax: get_hw_sio_linkgroups [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the defined groups, or associations of communication links between TX and RX objects
		/// on the GTs of the IBERT debug core defined on the current hardware device.
		/// Vivado Serial I/O analyzer is a link-based analyzer. The links define the communication paths and
		/// protocols between transmitters and receivers of the GigaBit transceivers on the device. Link
		/// groups, or hw_sio_linkgroup objects, let you associate links into related groups, to collectively
		/// configure properties and run scans.
		/// This command returns a list of linkgroups on the IBERT debug core, or returns an error if it fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 761
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_sio_linkgroup' objects of these types: 'hw_sio_link'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_linkgroup' objects against patterns. Default: *</param>
		/// <returns>hardware SIO link groups</returns>
		public TTCL get_hw_sio_linkgroups(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_linkgroups [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_linkgroups(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO links.
		///
		///
		/// TCL Syntax: get_hw_sio_links [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the communication links between TX and RX objects on the GTs of the IBERT debug
		/// core defined on the current hardware device.
		/// Vivado Serial I/O analyzer is a link-based analyzer, which lets you link between any transmitter
		/// and receiver within the IBERT design. The links define the communication paths and protocols
		/// between transmitters and receivers of the GigaBit transceivers on the device. You can configure
		/// the links by using the set_property command to specify property values on the link object.
		/// This command returns a list of link objects on the IBERT debug core, or returns an error if it fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 764
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_sio_link' objects of these types: 'hw_server
		/// hw_target hw_device hw_sio_ibert hw_sio_gtgroup hw_sio_gt
		/// hw_sio_tx hw_sio_rx hw_sio_linkgroup'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_link' objects against patterns. Default: *</param>
		/// <returns>hardware SIO links</returns>
		public TTCL get_hw_sio_links(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_links [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_links(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO PLLs.
		///
		///
		/// TCL Syntax: get_hw_sio_plls [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the PLL objects, hw_sio_pll, defined on the IBERT debug core on the current hardware
		/// device.
		/// For each serial transceiver channel, there is a ring PLL called Channel PLL (CPLL). In Xilinx
		/// UltraScale and 7 series FPGAs, the GTX has an additional shared PLL per quad, or Quad PLL
		/// (QPLL). This QPLL is a shared LC PLL to support high speed, high performance, and low power
		/// multi-lane applications.
		/// On the device, the GTXE2_CHANNEL component has the serial transceiver and CPLL units and
		/// the GTXE2_COMMON has the QPLL unit.
		/// This command returns a list of all PLL objects, both CPLLs and QPLLs on the device, or returns an
		/// error if it fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 767
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_sio_pll' objects of these types: 'hw_server hw_target
		/// hw_device hw_sio_ibert hw_sio_gtgroup hw_sio_gt
		/// hw_sio_common'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_pll' objects against patterns. Default: *</param>
		/// <returns>hardware SIO PLLs</returns>
		public TTCL get_hw_sio_plls(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_plls [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_plls(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO RXs.
		///
		///
		/// TCL Syntax: get_hw_sio_rxs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the receiver objects, hw_sio_rx, of the Gigabit Transceivers (GTs) that are in use on the
		/// IBERT debug core on the current hardware device.
		/// On the hardware device, each GT includes an independent receiver, which consists of a PCS and
		/// a PMA. High-speed serial data flows from traces on the board into the PMA of the GTX/GTH
		/// transceiver RX, into the PCS, and finally into the FPGA logic.
		/// This command returns a list of receiver objects on the device, or returns an error if it fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 770
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_sio_rx' objects of these types: 'hw_server hw_target
		/// hw_device hw_sio_ibert hw_sio_gtgroup hw_sio_gt
		/// hw_sio_link'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_rx' objects against patterns. Default: *</param>
		/// <returns>hardware SIO RXs</returns>
		public TTCL get_hw_sio_rxs(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_rxs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_rxs(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO scans.
		///
		///
		/// TCL Syntax: get_hw_sio_scans [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns serial I/O analyzer scan objects for the IBERT debug core.
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the
		/// specialized Eye Scan hardware of Xilinx UltraScale devices or 7 Series FPGAs. The Vivado serial
		/// I/O analyzer feature lets you to create, run, and save link scans.
		/// This command returns one or more hw_sio_scan objects, or returns an error if he command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 773
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_sio_scan' objects of these types: 'hw_sio_rx
		/// hw_sio_link hw_sio_sweep'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_scan' objects against patterns. Default: *</param>
		/// <returns>hardware SIO scans</returns>
		public TTCL get_hw_sio_scans(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_scans [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_scans(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO sweeps.
		///
		///
		/// TCL Syntax: get_hw_sio_sweeps [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Return the serial I/O analyzer link sweep objects defined on the IBERT debug core.
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the
		/// specialized features of Xilinx UltraScale devices or 7 series FPGAs. It can also be helpful to run
		/// multiple scans on a the link with different configuration settings for the GTs. This can help you
		/// determine which settings are best for your design. The Vivado serial I/O analyzer feature enables
		/// you to define, run, and save link sweeps, or collections of link scans run across a range of values.
		/// This command returns a link sweep object that you can use with the run_hw_sio_sweep
		/// command to run analysis on the specified links, or GT receivers. You can also save the sweep
		/// scan to disk using the write_hw_sio_sweep command.
		/// You can remove the created sweep object using remove_hw_sio_sweep.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// This command returns one or more hw_sio_sweep objects, or returns an error if the command
		/// fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 776
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_sio_sweep' objects of these types: 'hw_sio_link hw_sio_scan'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_sweep' objects against patterns. Default: *</param>
		/// <returns>hardware SIO sweeps</returns>
		public TTCL get_hw_sio_sweeps(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_sweeps [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_sweeps(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SIO TXs.
		///
		///
		/// TCL Syntax: get_hw_sio_txs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the transmitter objects, hw_sio_tx, of the Gigabit Transceivers (GTs) that are in use on the
		/// IBERT debug core on the current hardware device.
		/// On the hardware device, each GT includes an independent transmitter, which consists of a PCS
		/// and a PMA. Parallel data flows from the device logic into the FPGA TX interface, through the PCS
		/// and PMA, and then out the TX driver as high-speed serial data.
		/// This command returns a list of transmitter objects on the device, or returns an error if it fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 780
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_sio_tx' objects of these types: 'hw_server hw_target
		/// hw_device hw_sio_ibert hw_sio_gtgroup hw_sio_gt
		/// hw_sio_link'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sio_tx' objects against patterns. Default: *</param>
		/// <returns>hardware SIO TXs</returns>
		public TTCL get_hw_sio_txs(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sio_txs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sio_txs(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get list of Versal soft memory controller cores.
		///
		///
		/// TCL Syntax: get_hw_softmcs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 783
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_softmc' objects of these types: 'hw_server
		/// hw_target hw_device'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_softmc' objects against patterns. Default: *</param>
		/// <returns>soft memory controller cores</returns>
		public TTCL get_hw_softmcs(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_softmcs [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_softmcs(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get the system monitor register value
		///
		///
		/// TCL Syntax: get_hw_sysmon_reg [-quiet] [-verbose] <hw_sysmon> <hexaddress>
		///
		/// Returns the hex value of the system monitor register defined at the specified address of the
		/// specified hw_sysmon object.
		/// The System Monitor (SYSMON) Analog-to-Digital Converter (ADC) is used to measure die
		/// temperature and voltage on the hw_device. The sysmon monitors the physical environment via
		/// on-chip temperature and supply sensors. The ADC can access up to 17 external analog input
		/// channels.
		/// Data for the system monitor is stored in dedicated registers, called status and control registers,
		/// accessible through the hw_sysmon_reg object. Refer to the Register Interface in UltraScale
		/// Architecture System Monitor User Guide (UG580), or 7 Series FPGAs and Zynq-7000 SoC XADC Dual
		/// 12-Bit 1 MSPS Analog-to-Digital Converter User Guide (UG480) for more information on the
		/// addresses of specific system monitor registers.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Although the get_hw_sysmon_reg command lets you directly access the values stored in
		/// registers of the hw_sysmon object, the recommended procedure is to retrieve the values of
		/// registers as formatted properties of the hw_sysmon object. For example, the following code
		/// retrieves the TEMPERATURE on the system monitor as a formatted property of the hw_sysmon
		/// object rather than accessing the hex value of the sysmon register:
		/// set opTemp [get_property TEMPERATURE [get_hw_sysmons]
		/// The get_property command returns the TEMPERATURE as a formatted value in degrees
		/// Celsius, Fahrenheit, or Kelvin as determined by the TEMPERATURE_SCALE property on the
		/// hw_sysmon object.
		/// TIP: You can also be sure the property value on the object is current by issuing the
		/// refresh_hw_sysmon command prior to get_property.
		/// The get_hw_sysmon_reg command returns the unformatted hex value of the hw_sysmon_reg
		/// object on the specified hw_sysmons at the specified address, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 784
		/// </summary>
		/// <param name="hw_sysmon">(Required) hw_sysmon object</param>
		/// <param name="hexaddress">(Required) Hex address to read from</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Register value in Hex.</returns>
		public TTCL get_hw_sysmon_reg(String hw_sysmon, String hexaddress, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: get_hw_sysmon_reg [-quiet] [-verbose] <hw_sysmon> <hexaddress>
			_tcl.Entry(_builder.get_hw_sysmon_reg(hw_sysmon, hexaddress, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Get list of hardware SysMons.
		///
		///
		/// TCL Syntax: get_hw_sysmons [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the Sysmon debug core objects defined on the current hardware device.
		/// The System Monitor (SYSMON) Analog-to-Digital Converter (ADC) is used to measure die
		/// temperature and voltage on the hw_device. The Sysmon monitors the physical environment via
		/// on-chip temperature and supply sensors. The ADC provides a high-precision analog interface for
		/// a range of applications. The ADC can access up to 17 external analog input channels. Refer to
		/// UltraScale Architecture System Monitor User Guide (UG580), or 7 Series FPGAs and Zynq-7000 SoC
		/// XADC Dual 12-Bit 1 MSPS Analog-to-Digital Converter User Guide (UG480) for more information on
		/// a specific device architecture.
		/// The hw_sysmon data is stored in dedicated registers called status registers accessible through the
		/// hw_sysmon_reg object. The values of the system monitor registers can be returned by the
		/// get_hw_sysmon_reg command.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Every device that supports the system monitor will automatically have one or more hw_sysmon
		/// objects created when refresh_hw_device is called. When the hw_sysmon object is created, it
		/// is assigned a property for all the temperature and voltage registers, as well as the control
		/// registers. On the hw_sysmon object, the values assigned to the temperature and voltage registers
		/// are already translated to Celsius/Fahrenheit and Voltage.
		/// Although you can use the get_hw_sysmon_reg command to access the hex values stored in
		/// registers of a system monitor, you can also retrieve values of certain registers as formatted
		/// properties of the hw_sysmon object. For example, the following code retrieves the
		/// TEMPERATURE property of the specified hw_sysmon object rather than directly accessing the
		/// hex value of the register:
		/// set opTemp [get_property TEMPERATURE [get_hw_sysmons]
		/// This command returns a list of hw_sysmon objects on the current or specified hw_device, or
		/// returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 787
		/// </summary>
		/// <param name="of_objects">
		/// (Optional)
		/// Get 'hw_sysmon' objects of these types: 'hw_server
		/// hw_target hw_device'.
		/// </param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_sysmon' objects against patterns. Default: *</param>
		/// <returns>hardware sysmons</returns>
		public TTCL get_hw_sysmons(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_sysmons [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_sysmons(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of hardware targets.
		///
		///
		/// TCL Syntax: get_hw_targets [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the available hardware targets of the connected hardware servers.
		/// The hardware target is a system board containing a JTAG chain of one or more Xilinx devices that
		/// you can program with a bitstream file, or use to debug your design. Connections between
		/// hardware targets on the system board and the Vivado Design Suite are managed by the Xilinx
		/// hardware server application, and the connect_hw_server command. Refer to Vivado Design
		/// Suite User Guide: Programming and Debugging (UG908) for a list of supported JTAG download
		/// cables and devices.
		/// Use the open_hw_target command to open a connection to one of the available hardware
		/// targets. The open target is automatically defined as the current hardware target. Alternatively,
		/// you can define the current target with the current_hw_target command, and then open a
		/// connection to the current target. The Vivado Design Suite directs programming and debug
		/// commands to the open target through the hardware server connection.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// This command returns a list of available hardware targets through all connected hardware
		/// servers, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 791
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_target' objects of these types: 'hw_server'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_target' objects against patterns. Default: *</param>
		/// <returns>hardware targets</returns>
		public TTCL get_hw_targets(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_targets [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_targets(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Get a list of hardware VIOs.
		///
		///
		/// TCL Syntax: get_hw_vios [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
		///
		/// Returns the Virtual Input/Output (VIO) debug core objects that are defined on the current
		/// hardware device, hw_device.
		/// The Virtual Input/Output (VIO) debug core can both monitor and drive internal signals on a
		/// programmed Xilinx FPGA in real time. In the absence of physical access to the target hardware,
		/// you can use this debug feature to drive and monitor signals that are present on the physical
		/// device.
		/// The VIO core has hardware probes, hw_probe objects, to monitor and drive specific signals on
		/// the design. Input probes monitor signals as inputs to the VIO core. Output probes drive signals to
		/// specified values from the VIO core. Values on the debug core are driven onto the signals at the
		/// probe using the commit_hw_vio command.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The VIO debug core needs to be instantiated in the RTL code, therefore you need to know what
		/// nets you want monitor and drive prior to debugging the design. The IP catalog provides the VIO
		/// core under the Debug category. Detailed documentation on the VIO core can be found in the
		/// LogiCORE IP Virtual Input/Output Product Guide (PG159).
		/// This command returns a list of VIO debug core objects on the device, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 794
		/// </summary>
		/// <param name="of_objects">(Optional) Get 'hw_vio' objects of these types: 'hw_device'.</param>
		/// <param name="regexp">(Optional) Patterns are full regular expressions</param>
		/// <param name="nocase">(Optional) Perform case-insensitive matching. (valid only when -regexp specified)</param>
		/// <param name="filter">(Optional) Filter list with expression</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="patterns">(Optional) Match the 'hw_vio' objects against patterns. Default: *</param>
		/// <returns>hardware VIOs</returns>
		public TTCL get_hw_vios(TCLParameterList of_objects = null, bool? regexp = null, bool? nocase = null, String filter = null, bool? quiet = null, bool? verbose = null, String patterns = null)
		{
			// TCL Syntax: get_hw_vios [-of_objects <args>] [-regexp] [-nocase] [-filter <arg>] [-quiet] [-verbose] [<patterns>]
			_tcl.Entry(_builder.get_hw_vios(of_objects, regexp, nocase, filter, quiet, verbose, patterns));
			return _tcl;
		}
		/// <summary>
		/// Return probe sample values
		///
		///
		/// TCL Syntax: list_hw_samples [-quiet] [-verbose] [<hw_probe>]
		///
		/// Writes data samples from the specified hw_probe object on the current hw_ila.
		/// The number of captured samples returned from the specified probe is equal to the DATA_DEPTH
		/// property of the ILA core. The default data depth is 1024 samples. Data values are returned in the
		/// radix specified for the hw_probe, as determined by the DISPLAY_RADIX property.
		/// TIP: For any samples to be returned, data must have been captured by the specified port.
		/// The values are listed to the standard output, or can be captured to a Tcl variable for post-processing, or output to a file.
		/// The following is an example Tcl script that lists the data samples from hw_probes of interest:
		/// # Define a list of probes to get the data samples from
		/// set probeList [get_hw_probes *AR*]
		/// #Specify the radix for the return values
		/// set_property DISPLAY_RADIX BINARY [get_hw_probes *AR*]
		/// # Define a filename to write data to
		/// set fileName C:/Data/probeData1.txt
		/// # Open the specified file in write mode
		/// set FH [open $fileName w]
		/// # Write probe data for each probe
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// foreach x $probeList {
		/// puts $FH "$x:"
		/// puts $FH [list_hw_samples $x]
		/// }
		/// # Close the output file
		/// close $FH
		/// puts "Probe data written to $fileName\n"
		/// This command returns the requested output, or returns an error if it fails.
		///
		/// The following example returns the data samples for the specified probe:
		/// list_hw_samples [get_hw_probes *probe18]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1030
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_probe">(Optional) hw_probe object</param>
		/// <returns>samples</returns>
		public TTCL list_hw_samples(bool? quiet = null, bool? verbose = null, String hw_probe = null)
		{
			// TCL Syntax: list_hw_samples [-quiet] [-verbose] [<hw_probe>]
			_tcl.Entry(_builder.list_hw_samples(quiet, verbose, hw_probe));
			return _tcl;
		}
		/// <summary>
		/// Open the hardware tool
		///
		///
		/// TCL Syntax: open_hw_manager [-quiet] [-verbose]
		///
		/// Open the Hardware Manager in the Vivado Design Suite in either the Vivado IDE or in Tcl or
		/// batch mode. Opening the Hardware Manager is the first step in programming and/or debugging
		/// your design in Xilinx FPGA hardware. For more information refer to the Vivado Design Suite User
		/// Guide: Programming and Debugging (UG908).
		/// Hardware Manager is a feature of the Vivado Design Suite which lets you interact with FPGA
		/// devices on a board. The features of the Hardware Manager include:
		/// • Logic Debug or Logic Analyzer- Debugging FPGA programmable logic designs.
		/// • Programming/Configuration - Program FPGA devices using JTAG and configuring flash
		/// memory devices connected to FPGAs.
		/// • In-system Serial I/O debug - Adjust SERDES receive/transmit settings and measure
		/// transmission bit error rates.
		/// • System Monitor - Control on chip system monitor and read system monitor temperature and
		/// voltage values.
		/// The Hardware Manager uses a number of first class objects, like hw_server, hw_target,
		/// hw_device, and hw_ila. Each of these objects is related to other objects, and has properties that
		/// can be set or read by the set_property and get_property commands to configure or
		/// control its function in the Hardware Manager. Refer to the Vivado Design Suite Properties
		/// Reference Guide (UG912) for more information on these objects.
		/// The steps to connect to hardware and program the target FPGA are:
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// 1. Open the hardware manager in the IDE (open_hw_manager).
		/// TIP: This step can be skipped if you are running in batch or Tcl mode.
		/// 2. Connect to a hardware server running either on the local machine, or on a remote network
		/// accessible host (connect_hw_server).
		/// 3. Open a hardware target on the connected hardware server (open_hw_target).
		/// 4. Identify the Xilinx FPGA on the open hardware target (current_hw_device,
		/// get_hw_devices).
		/// 5. Associate the bitstream data programming file (.bit), and probes file (.ltx) if one exists,
		/// with the appropriate FPGA (set_property).
		/// 6. Program or download the programming file into the hardware device
		/// (program_hw_device, refresh_hw_device).
		/// Note that you can run the Hardware Manager from within the Vivado tool without having a
		/// project or design open. You can open the Hardware Manager, connect to the hardware server,
		/// and program the device on the target by providing a bitstream file, and probes file for debugging.
		/// You can close the Hardware Manager using the close_hw_manager command.
		/// This command returns nothing if successful, and returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1079
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
		/// Open a connection to a hardware target on the hardware server
		///
		///
		/// TCL Syntax: open_hw_target [-jtag_mode <arg>] [-xvc_url <arg>] [-auto_calibrate] [-quiet] [-verbose] [<hw_target>]
		///
		/// Opens a connection to the specified hardware target of the connected hardware servers, or
		/// opens the current hardware target.
		/// The hardware target is a system board containing a JTAG chain of one or more Xilinx devices that
		/// you can program with a bitstream file, or use to debug your design. Connections between
		/// hardware targets on the system board and the Vivado Design Suite are managed by the Xilinx
		/// hardware server application, and the connect_hw_server command. Refer to Vivado Design
		/// Suite User Guide: Programming and Debugging (UG908) for a list of supported JTAG download
		/// cables and devices.
		/// Each hardware target can have one or more Xilinx devices to program, or to use for debugging
		/// purposes. The current device is specified or returned by the current_hw_device command.
		/// Use the open_hw_target command to open a connection to one of the available hardware
		/// targets. The open target is automatically defined as the current hardware target. Alternatively,
		/// you can define the current target with the current_hw_target command, and then open the
		/// current target. The Vivado Design Suite directs programming and debug commands to the open
		/// target through the hardware server connection.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// An open connection to the hardware target can be closed using the close_hw_target
		/// command.
		/// The open_hw_target command returns connection messages from the hardware server, or
		/// returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1084
		/// </summary>
		/// <param name="jtag_mode">(Optional) Open target in JTAG mode</param>
		/// <param name="xvc_url">(Optional) Open target connection to XVC server</param>
		/// <param name="auto_calibrate">(Optional) Auto-calibrate target for optimal frequency (SmartLynq cable only)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_target">(Optional) hardware target Default: current hardware target</param>
		public TTCL open_hw_target(String jtag_mode = null, String xvc_url = null, bool? auto_calibrate = null, bool? quiet = null, bool? verbose = null, String hw_target = null)
		{
			// TCL Syntax: open_hw_target [-jtag_mode <arg>] [-xvc_url <arg>] [-auto_calibrate] [-quiet] [-verbose] [<hw_target>]
			_tcl.Entry(_builder.open_hw_target(jtag_mode, xvc_url, auto_calibrate, quiet, verbose, hw_target));
			return _tcl;
		}
		/// <summary>
		/// Pause Activity Monitor runs for the specified hardware HBM(s)
		///
		///
		/// TCL Syntax: pause_hw_hbm_amon [-quiet] [-verbose] <hw_objects>
		///
		/// The pause_hw_hbm_amon command pauses a running HBM activity monitor in the Vivado
		/// hardware manager that has been previously started using the run_hw_hbm_amon command.
		/// This command returns nothing when successful, or returns an error when it fails.
		///
		/// The following example pauses the HBM activity monitor for the associated HBM core:
		/// pause_hw_hbm_amon [get_hw_hbms *HBM_2]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1112
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL pause_hw_hbm_amon(String hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: pause_hw_hbm_amon [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.pause_hw_hbm_amon(hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Program Cfgmem object
		///
		///
		/// TCL Syntax: program_hw_cfgmem [-svf_file <arg>] [-force] [-append] [-quiet] [-verbose] [<hw_cfgmem>...]
		///
		/// Erase, blank check, program, and/or verify the specified hw_cfgmem object with the memory
		/// configuration file defined in the object's PROGRAM.FILE property. The memory configuration file
		/// is created with the write_cfgmem command, and associated with the hw_cfgmem object using
		/// the set_property command as shown in the example.
		/// The process whereby the design specific data is loaded or programmed into the Xilinx FPGA is
		/// called configuration. The create_hw_cfgmem command defines a flash memory device used
		/// for configuring and booting the FPGA device.
		/// After the hw_cfgmem object is created, and associated with the hw_device, the configuration
		/// memory can be programmed with the bitstream and other data from a memory configuration file
		/// created with the write_cfgmem command. The hw_cfgmem object is programmed using the
		/// program_hw_cfgmem command.
		/// The program_hw_cfgmem command will run a multi-step process to erase the configuration
		/// memory device, perform a blank check to validate that the device is empty, program the device
		/// with the memory configuration file, and verify the programming on the device. Properties on the
		/// hw_cfgmem object determine which steps of the programming process are performed. These
		/// properties include:
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// • PROGRAM.FILES - Specifies the memory configuration files to use for programming the
		/// device. The memory configuration files are created with the write_cfgmem command.
		/// • PROGRAM.ADDRESS_RANGE - Specifies the address range of the configuration memory
		/// device to program. The address range values can be:
		/// ○ {use_file} - Use only the address space required by the memory configuration file to
		/// erase, blank check, program, and verify.
		/// ○ {entire_device} - Erase, blank check, program, and verify the entire device.
		/// • PROGRAM.ERASE - Erases the contents of the flash memory when true. This is a boolean
		/// property with a value of 0 (false) or 1 (true).
		/// • PROGRAM.BLANK_CHECK - Checks the device to make sure the device is void of data prior
		/// to programming. This is a boolean property with a value of 0 (false) or 1 (true).
		/// • PROGRAM.CFG_PROGRAM - Program the device with the specified PROGRAM.FILE. This is
		/// a boolean property with a value of 0 (false) or 1 (true).
		/// • PROGRAM.VERIFY - Verify the device after programming. This is a boolean property with a
		/// value of 0 (false) or 1 (true).
		/// The program_hw_cfgmem command can also generate an SVF file for in-system and remote
		/// programming of Xilinx devices. SVF is an industry standard file format that is used to describe
		/// JTAG chain operations by describing the information that needs to be shifted into the device
		/// chain. SVF files are ASCII files that can be written and modified in any text editor. Many third-party programming utilities can use the SVF file to program Xilinx devices in a JTAG chain.
		/// This command returns a transcript of its process when successful, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1141
		/// </summary>
		/// <param name="hw_cfgmem">(Required) list of hardware cfgmems Default: current hardware cfgmem</param>
		/// <param name="svf_file">(Optional) svf file to be generated</param>
		/// <param name="force">(Optional) overwrite svf_file if it already exists</param>
		/// <param name="append">(Optional) append to svf file</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL program_hw_cfgmem(TCLParameterList hw_cfgmem, String svf_file = null, bool? force = null, bool? append = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: program_hw_cfgmem [-svf_file <arg>] [-force] [-append] [-quiet] [-verbose] [<hw_cfgmem>...]
			_tcl.Entry(_builder.program_hw_cfgmem(hw_cfgmem, svf_file, force, append, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Program hardware devices
		///
		///
		/// TCL Syntax: program_hw_devices [-key <arg>] [-clear] [-skip_program_keys] [-skip_program_rsa] [-user_efuse <arg>] [-user_efuse_128 <arg>] [-control_efuse <arg>] [-security_efuse <arg>] [-only_export_efuse] [-svf_file <arg>] [-efuse_export_file <arg>] [-disable_eos_check] [-skip_reset] [-force] [-append] [-type <arg>] [-quiet] [-verbose] [<hw_device>...]
		///
		/// Program the specified hardware device object or objects on the open hardware target of the
		/// current hardware server.
		/// To access a Xilinx FPGA through the Hardware Manager, you must use the following Tcl
		/// command sequence:
		/// 1. open_hw - Opens the Hardware Manager in the Vivado Design Suite.
		/// 2. connect_hw_server - Makes a connection to a local or remote Vivado hardware server
		/// application.
		/// 3. current_hw_target - Defines the hardware target of the connected server.
		/// 4. open_hw_target - Opens a connection to the hardware target.
		/// 5. current_hw_device - Specifies the Xilinx FPGA to use for programming and debugging.
		/// After connecting to the target hardware device, you must associate the bitstream file
		/// (.bit, .rbt, .bin) from the design with the device, using the set_property command:
		/// set_property PROGRAM.FILE {C:/Data/design.bit} [current_hw_device]
		/// For debug purposes, you can also associate a probes file (.ltx) with the device using the
		/// PROBES.FILE property:
		/// set_property PROBES.FILE {C:/Data/debug_nets.ltx} [current_hw_device]
		/// Once the programming file has been associated with the hardware device, you can program the
		/// hardware device using the program_hw_devices command, and debug the device using any
		/// of a number of Hardware Manager Tcl commands. To interactively debug the device open the
		/// Hardware Manager in the Vivado Design Suite IDE.
		/// You can also program an encrypted bitstream into the specified hw_device. This requires the
		/// implemented design to have encryption properties assigned prior to generating the bitstream
		/// with the write_bitstream command. You can add ENCRYPTION properties to the design
		/// most easily using the Encryption page of the Edit Device Properties dialog box in the Vivado IDE.
		/// Refer to the Vivado Design Suite User Guide: Programming and Debugging (UG908) for more
		/// information on the Edit Device Properties dialog box.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Programming a device for an encrypted bitstream is a two-step process that requires running
		/// program_hw_devices once to program the encryption key into the BBR or eFUSE registers,
		/// and a second time to program the encrypted bitstream into the device:
		/// program_hw_devices -key bbr [current_hw_device]
		/// program_hw_device [current_hw_device]
		/// CAUTION! eFUSEs are one-time programmable cells on the hardware device, used to store the factory-programmed Device DNA, AES-GCM encryption key, and user specified values. Refer to the UltraScale
		/// Architecture Configuration (UG570) or 7 Series FPGAs Configuration User Guide (UG470) for more
		/// information on eFUSE registers.
		/// The program_hw_devices command can also generate a Serial Vector Format (SVF) file for in-system and remote programming of Xilinx devices. SVF is an industry standard file format that is
		/// used to describe JTAG chain operations by describing the information that needs to be shifted
		/// into the device chain. SVF files are ASCII files that can be written and modified in any text editor.
		/// Many third-party programming utilities can use the SVF file to program Xilinx devices in a JTAG
		/// chain.
		/// This command returns a transcript of its actions, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1144
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
		/// (Optional)
		/// list of hardware devices Default: current hardware device
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// </param>
		/// <returns>hardware devices</returns>
		public TTCL program_hw_devices(String key = null, bool? clear = null, bool? skip_program_keys = null, bool? skip_program_rsa = null, String user_efuse = null, String user_efuse_128 = null, String control_efuse = null, String security_efuse = null, bool? only_export_efuse = null, String svf_file = null, String efuse_export_file = null, bool? disable_eos_check = null, bool? skip_reset = null, bool? force = null, bool? append = null, String type = null, bool? quiet = null, bool? verbose = null, TCLParameterList hw_device = null)
		{
			// TCL Syntax: program_hw_devices [-key <arg>] [-clear] [-skip_program_keys] [-skip_program_rsa] [-user_efuse <arg>] [-user_efuse_128 <arg>] [-control_efuse <arg>] [-security_efuse <arg>] [-only_export_efuse] [-svf_file <arg>] [-efuse_export_file <arg>] [-disable_eos_check] [-skip_reset] [-force] [-append] [-type <arg>] [-quiet] [-verbose] [<hw_device>...]
			_tcl.Entry(_builder.program_hw_devices(key, clear, skip_program_keys, skip_program_rsa, user_efuse, user_efuse_128, control_efuse, security_efuse, only_export_efuse, svf_file, efuse_export_file, disable_eos_check, skip_reset, force, append, type, quiet, verbose, hw_device));
			return _tcl;
		}
		/// <summary>
		/// Read hardware ILA data from a file
		///
		///
		/// TCL Syntax: read_hw_ila_data [-quiet] [-verbose] <file>
		///
		/// Read ILA debug core data from the specified file, and create an hw_ila_data object.
		/// The ILA debug sample data is acquired from a running device using the upload_hw_ila_data
		/// command. This creates a hw_ila_data object that can be written to a file on disk using the
		/// write_hw_ila_data command. This command reads that ILA data file.
		/// The hw_ila_data object that is created by read_hw_ila_data is named after the <file> it is
		/// read from. If a hw_ila_data object of the same name already exists, the name of the object is
		/// assigned a number extension starting at 1: <file>_1.
		/// The new hw_ila_data object is not connected with, or associated with, any ILA debug cores in the
		/// design.
		/// After being read from disk, the ILA debug data can be viewed in the waveform viewer of the
		/// Vivado logic analyzer by using the display_hw_ila_data command.
		/// This command returns an ILA data object, or returns an error if it fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1161
		/// </summary>
		/// <param name="file">(Required) hardware ILA data file name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Name of the output file</returns>
		public TTCL read_hw_ila_data(String file, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_hw_ila_data [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.read_hw_ila_data(file, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Read hardware SIO scan data from a file. A hardware SIO scan object will be created if not
		/// provided.
		///
		///
		/// TCL Syntax: read_hw_sio_scan [-quiet] [-verbose] <file> [<hw_sio_scan>]
		///
		/// Read a hardware SIO scan data file and create a hw_sio_scan object in the Hardware Manager
		/// feature of the Vivado Design Suite.
		/// The SIO scan data can be written to disk using the write_hw_sio_scan command, after
		/// running the scan using the run_hw_sio_scan command. This command reads that data file.
		/// If no hw_sio_scan object is specified, a new hw_sio_scan object is created and is named
		/// sequentially following any existing hw_sio_scan objects. After being read from disk, the SIO scan
		/// data can be plotted and viewed in the Vivado serial I/O analyzer by using the
		/// display_hw_sio_scan command.
		/// This command returns a hw_sio_scan object, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1163
		/// </summary>
		/// <param name="file">(Required) hardware SIO scan file name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_sio_scan">(Optional) hardware SIO scan data object Default: None</param>
		/// <returns>hardware SIO scan object</returns>
		public TTCL read_hw_sio_scan(String file, bool? quiet = null, bool? verbose = null, String hw_sio_scan = null)
		{
			// TCL Syntax: read_hw_sio_scan [-quiet] [-verbose] <file> [<hw_sio_scan>]
			_tcl.Entry(_builder.read_hw_sio_scan(file, quiet, verbose, hw_sio_scan));
			return _tcl;
		}
		/// <summary>
		/// Read hardware SIO sweep data from a directory. A hardware SIO sweep object will be created if
		/// not provided.
		///
		///
		/// TCL Syntax: read_hw_sio_sweep [-quiet] [-verbose] <directory> [<hw_sio_sweep>]
		///
		/// Read a hardware SIO sweep data directory and create a hw_sio_sweep object in the Hardware
		/// Manager feature of the Vivado Design Suite.
		/// The SIO sweep data can be written to disk using the write_hw_sio_sweep command, after
		/// running the sweep using the run_hw_sio_sweep command. This command reads the sweep
		/// directory containing multiple SIO scan data files.
		/// If no hw_sio_sweep object is specified, a new hw_sio_sweep object is created and is named
		/// sequentially following any existing hw_sio_sweep objects. After being read from disk, any of the
		/// SIO scans in the sweep can be plotted and viewed in the Vivado serial I/O analyzer by using the
		/// display_hw_sio_scan command.
		/// This command returns a hw_sio_sweep object, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1165
		/// </summary>
		/// <param name="directory">(Required) hardware SIO sweep directory name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_sio_sweep">(Optional) hardware SIO sweep data object Default: None</param>
		/// <returns>hardware SIO sweep object</returns>
		public TTCL read_hw_sio_sweep(String directory, bool? quiet = null, bool? verbose = null, String hw_sio_sweep = null)
		{
			// TCL Syntax: read_hw_sio_sweep [-quiet] [-verbose] <directory> [<hw_sio_sweep>]
			_tcl.Entry(_builder.read_hw_sio_sweep(directory, quiet, verbose, hw_sio_sweep));
			return _tcl;
		}
		/// <summary>
		/// Readback data from the hw_cfgmem object
		///
		///
		/// TCL Syntax: readback_hw_cfgmem [-checksum] [-force] [-all] [-offset <arg>] -file <arg> [-format <arg>] [-datacount <arg>] [-quiet] [-verbose] [<hw_cfgmem>...]
		///
		/// Read programming data off of the hardware configuration memory device, specified as a
		/// hw_cfgmem object.
		/// This command reads back the memory configuration file data programmed into a flash memory
		/// device by the program_hw_cfgmem command and writes it to the specified file. The memory
		/// configuration file is created by the write_cfgmem command and combines the bitstream
		/// (.bit) file, and any specified data files, into the memory configuration file format.
		/// Readback is the process of reading data from the configuration memory device to verify that the
		/// bitstream and any additional data files were properly programmed into the flash memory device.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1189
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
		public TTCL readback_hw_cfgmem(String file, bool? checksum = null, bool? force = null, bool? all = null, String offset = null, String format = null, Int32? datacount = null, bool? quiet = null, bool? verbose = null, TCLParameterList hw_cfgmem = null)
		{
			// TCL Syntax: readback_hw_cfgmem [-checksum] [-force] [-all] [-offset <arg>] -file <arg> [-format <arg>] [-datacount <arg>] [-quiet] [-verbose] [<hw_cfgmem>...]
			_tcl.Entry(_builder.readback_hw_cfgmem(file, checksum, force, all, offset, format, datacount, quiet, verbose, hw_cfgmem));
			return _tcl;
		}
		/// <summary>
		/// Readback hardware devices
		///
		///
		/// TCL Syntax: readback_hw_device [-force] [-capture] [-readback_file <arg>] [-bin_file <arg>] [-quiet] [-verbose] [<hw_device>...]
		///
		/// Read bitstream data from the current hardware device and write it to the specified readback or
		/// binary file.
		/// The Vivado device programmer will readback bitstream data from the Xilinx device through the
		/// open target.
		/// IMPORTANT! If the bitstream on the hw_device is encrypted, readback is not permitted.
		/// This command returns the name of the readback file created, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1193
		/// </summary>
		/// <param name="force">(Optional) force write of file</param>
		/// <param name="capture">(Optional) capture configuration readback data (ultrascale only)</param>
		/// <param name="readback_file">(Optional) readback file for rbd file output</param>
		/// <param name="bin_file">(Optional) bin file for bin file output</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_device">(Optional) list of hardware devices Default: current hardware device</param>
		/// <returns>hardware devices</returns>
		public TTCL readback_hw_device(bool? force = null, bool? capture = null, String readback_file = null, String bin_file = null, bool? quiet = null, bool? verbose = null, TCLParameterList hw_device = null)
		{
			// TCL Syntax: readback_hw_device [-force] [-capture] [-readback_file <arg>] [-bin_file <arg>] [-quiet] [-verbose] [<hw_device>...]
			_tcl.Entry(_builder.readback_hw_device(force, capture, readback_file, bin_file, quiet, verbose, hw_device));
			return _tcl;
		}
		/// <summary>
		/// Refresh hardware AXI object status.
		///
		///
		/// TCL Syntax: refresh_hw_axi [-quiet] [-verbose] [<hw_axis>...]
		///
		/// Refresh the STATUS properties of the hw_axi object with the values from the current hw_device.
		/// The refresh command takes the values from the status registers of the JTAG to AXI MASTER on
		/// the hardware device, and populates them into the appropriate properties of the hw_axi object in
		/// the hardware manager.
		/// Refresh the STATUS properties of the specified hw_axi objects. THE STATUS properties include:
		/// STATUS.AXI_READ_BUSY, STATUS.AXI_READ_DONE, STATUS.AXI_WRITE_BUSY,
		/// STATUS.AXI_WRITE_DONE, STATUS.BRESP, and STATUS.RRESP.
		/// This command updates the properties on the hw_axi object, but otherwise returns nothing if
		/// successful. The command returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1200
		/// </summary>
		/// <param name="hw_axis">(Required) List of hardware AXI objects.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_hw_axi(TCLParameterList hw_axis, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_hw_axi [-quiet] [-verbose] [<hw_axis>...]
			_tcl.Entry(_builder.refresh_hw_axi(hw_axis, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Refresh the status of the current hardware object. Inputs need to be any DDRMC object. At least
		/// one object is required. If properties are specified, but do not exist in the object, those properties
		/// will not be refreshed.
		///
		///
		/// TCL Syntax: refresh_hw_ddrmc [-regexp] [-properties <args>] [-quiet] [-verbose] <hw_objects>
		///
		/// Refreshes the in-memory contents of all of the properties, or specified properties, of the
		/// specified Versal DDR Memory Controller (DDRMC) objects with values read from the current
		/// hardware device.
		/// The refresh command takes the values from the DDRMC object implemented on the hardware
		/// device, and populates them into the appropriate properties of the hw_ddrmc object in the Vivado
		/// hardware manager. If only certain properties are specified, then those properties are updated
		/// from the hw device.
		/// At least one object is required. If properties are specified that do not exist in the object, that
		/// property will not be refreshed.
		/// This command updates the properties on the hw_ddrmc object, but otherwise returns nothing if
		/// successful. The command returns an error if it fails.
		///
		/// The following example refreshes all of the properties of the DDRMC objects in the Vivado
		/// hardware manager with the properties from the current hw_device:
		/// refresh_hw_ddrmc -properties {PHY_RANKS} [lindex [get_hw_ddrmcs] 3]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1202
		/// </summary>
		/// <param name="hw_objects">(Required) hardware DDRMC objects</param>
		/// <param name="regexp">(Optional) Properties list contains full regular expressions</param>
		/// <param name="properties">(Optional) List of properties to refresh Default: All properties in object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_hw_ddrmc(String hw_objects, bool? regexp = null, TCLParameterList properties = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_hw_ddrmc [-regexp] [-properties <args>] [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.refresh_hw_ddrmc(hw_objects, regexp, properties, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Refresh a hardware device. Read device and core information from device.
		///
		///
		/// TCL Syntax: refresh_hw_device [-update_hw_probes <arg>] [-disable_done_check] [-force_poll] [-quiet] [-verbose] [<hw_device>]
		///
		/// Refreshes the in-memory view of the device by scanning for debug and IBERT cores on the
		/// specified hw_device object, and also reads a probe file when directed.
		/// The Hardware Manager in the Vivado Design Suite creates, deletes, or updates the hw_ila,
		/// hw_vio, hw_sio*, and hw_axi objects based on the core information found in the device, and also
		/// what is read from the probes file in the case of ILA and VIO debug cores.
		/// Use the refresh_hw_device after the program_hw_devices to keep the in-memory
		/// hardware debug objects in sync with the state of the actual cores on the physical device.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1204
		/// </summary>
		/// <param name="update_hw_probes">(Optional) Update hardware probe information, read from probes file</param>
		/// <param name="disable_done_check">(Optional) Disable done check for refresh device</param>
		/// <param name="force_poll">(Optional) Force poll of all targets</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_device">(Optional) hardware device Default: current hardware device</param>
		public TTCL refresh_hw_device(String update_hw_probes = null, bool? disable_done_check = null, bool? force_poll = null, bool? quiet = null, bool? verbose = null, String hw_device = null)
		{
			// TCL Syntax: refresh_hw_device [-update_hw_probes <arg>] [-disable_done_check] [-force_poll] [-quiet] [-verbose] [<hw_device>]
			_tcl.Entry(_builder.refresh_hw_device(update_hw_probes, disable_done_check, force_poll, quiet, verbose, hw_device));
			return _tcl;
		}
		/// <summary>
		/// Refresh the status of the current hardware object. Inputs can be HBM or device hardware object.
		/// At least one object is required. If properties are specified that do not exist in the object, that
		/// property will not be refreshed.
		///
		///
		/// TCL Syntax: refresh_hw_hbm [-regexp] [-properties <args>] [-quiet] [-verbose] <hw_objects>
		///
		/// Refreshes the in-memory view of all of the properties, or specified properties, of the specified
		/// HBM controller objects with values read from the current hardware device.
		/// The refresh command takes the values from the HBM controller implemented on the hardware
		/// device, and populates them into the appropriate properties of the hw_hbm object in the Vivado
		/// hardware manager. If only certain properties are specified, then those properties are updated
		/// from the hw device.
		/// At least one object is required. If properties are specified that do not exist in the object, that
		/// property will not be refreshed.
		/// This command updates the properties on the hw_hbm object, but otherwise returns nothing if
		/// successful. The command returns an error if it fails.
		///
		/// The following example refreshes all of the properties of the HBM controller in the Vivado
		/// hardware manager with the properties from the current hw_device:
		/// refresh_hw_hbm [lindex [get_hw_hbms] 1]
		/// The following example refreshes the specified property of the HBM controller from the current
		/// hw_device:
		/// refresh_hw_hbm -properties {MC2.INIT.AM_REPEAT_EN} [get_hw_hbms *HBM_2]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1206
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="regexp">(Optional) Properties list contains full regular expressions</param>
		/// <param name="properties">(Optional) List of properties to refresh Default: All properties in object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_hw_hbm(String hw_objects, bool? regexp = null, TCLParameterList properties = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_hw_hbm [-regexp] [-properties <args>] [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.refresh_hw_hbm(hw_objects, regexp, properties, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Refresh the status of the current hardware object. Inputs can be any mig, device, target, or server
		/// hardware object. At least one object is required. If properties are specified that do not exist in the
		/// object, that property will not be refreshed.
		///
		///
		/// TCL Syntax: refresh_hw_mig [-regexp] [-properties <args>] [-quiet] [-verbose] <hw_objects>
		///
		/// Refreshes the in-memory view of all of the properties, or specified properties, of the specified
		/// hw_mig objects with values read from the current hardware device.
		/// The refresh command takes the values from the memory controller implemented on the
		/// hardware device, and populates them into the appropriate properties of the hw_mig debug core
		/// in the Vivado logic analyzer, or standalone Vivado Lab Edition.
		/// At least one object is required. If properties are specified that do not exist in the object, that
		/// property will not be refreshed.
		/// This command updates the properties on the hw_mig object, but otherwise returns nothing if
		/// successful. The command returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1208
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="regexp">(Optional) Properties list contains full regular expressions</param>
		/// <param name="properties">(Optional) List of properties to refresh Default: All properties in object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_hw_mig(String hw_objects, bool? regexp = null, TCLParameterList properties = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_hw_mig [-regexp] [-properties <args>] [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.refresh_hw_mig(hw_objects, regexp, properties, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Refresh the PCIe core properties, by reading from HW.
		///
		///
		/// TCL Syntax: refresh_hw_pcie [-quiet] [-verbose] <hw_pcie>
		///
		/// Refresh for the Peripheral Component Interconnect Express (PCIe) debug core object, hw_pcie,
		/// defined on the current hardware device.
		/// The customizable LogiCORE IP PCIe core for Xilinx ACAPs is designed for evaluating and
		/// monitoring the PCIe Link Training and Status State Machine (LTSSM) running on the Gigabit
		/// Transceivers (GTs). In the Vivado Hardware Manager, Versal PCIe soft cores implemented in the
		/// design, are represented as hw_pcie objects. You can use these PCIe debug cores to solve a range
		/// of debug and validation problems; from viewing the PCIe link information to the LTSSM state
		/// transition diagram.
		/// This command reads data from the PCIe debug core and updates the relevant properties in the
		/// hw_pcie object.
		///
		/// The following example refreshes the PCIe core at index 0
		/// refresh_hw_pcie [lindex [get_hw_pcies] 0]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1210
		/// </summary>
		/// <param name="hw_pcie">(Required) Hardware PCIe object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_hw_pcie(String hw_pcie, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_hw_pcie [-quiet] [-verbose] <hw_pcie>
			_tcl.Entry(_builder.refresh_hw_pcie(hw_pcie, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Refresh a connection to a hardware server
		///
		///
		/// TCL Syntax: refresh_hw_server [-force_poll] [-quiet] [-verbose] [<hw_server>]
		///
		/// Refresh or reopen the connection to the current or specified hardware server.
		/// This command returns the connection messages from the hardware server, or returns an error if
		/// it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1212
		/// </summary>
		/// <param name="force_poll">(Optional) Force poll of all targets</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_server">(Optional) hardware server</param>
		public TTCL refresh_hw_server(bool? force_poll = null, bool? quiet = null, bool? verbose = null, String hw_server = null)
		{
			// TCL Syntax: refresh_hw_server [-force_poll] [-quiet] [-verbose] [<hw_server>]
			_tcl.Entry(_builder.refresh_hw_server(force_poll, quiet, verbose, hw_server));
			return _tcl;
		}
		/// <summary>
		/// Refresh the status of the specified hardware objects. Inputs can be any serial I/O (except scan
		/// and sweep), device, target, or server hardware object. At least one object is required. If properties
		/// are specified that do not exist in the object, that property will not be refreshed.
		///
		///
		/// TCL Syntax: refresh_hw_sio [-regexp] [-properties <args>] [-quiet] [-verbose] <hw_objects>
		///
		/// Refreshes the in-memory view of all of the properties, or specified properties, of the specified
		/// hw_sio objects with values read from the actual object on the hardware device.
		/// Specified objects can include any serial I/O object such as GTs, RXs, TXs, PLLs, or Commons,
		/// excluding hw_sio_scan and hw_sio_sweep objects. SIO objects also include device, target, or
		/// server hardware objects.
		/// The refresh_hw_sio command reads the values of the specified objects on the hardware
		/// device, and applies the value to the associated property of the IBERT core in the Hardware
		/// Manager.
		/// This command returns no feedback of its operation if successful, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1214
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="regexp">(Optional) Properties list contains full regular expressions</param>
		/// <param name="properties">(Optional) List of properties to refresh Default: All properties in object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_hw_sio(String hw_objects, bool? regexp = null, TCLParameterList properties = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_hw_sio [-regexp] [-properties <args>] [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.refresh_hw_sio(hw_objects, regexp, properties, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Refresh the status of the current hardware object. Inputs need to be any Soft MC object. At least
		/// one object is required. If properties are specified, but do not exist in the object, those properties
		/// will not be refreshed.
		///
		///
		/// TCL Syntax: refresh_hw_softmc [-regexp] [-properties <args>] [-quiet] [-verbose] <hw_objects>
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1216
		/// </summary>
		/// <param name="hw_objects">(Required) hardware Soft MC objects</param>
		/// <param name="regexp">(Optional) Properties list contains full regular expressions</param>
		/// <param name="properties">(Optional) List of properties to refresh Default: All properties in object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_hw_softmc(String hw_objects, bool? regexp = null, TCLParameterList properties = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_hw_softmc [-regexp] [-properties <args>] [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.refresh_hw_softmc(hw_objects, regexp, properties, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Refresh the status of the current hardware object. Inputs can be hw_server, hw_target,
		/// hw_device or hw_sysmon objects. At least one object is required. If properties are specified that
		/// do not exist in the object, that property will not be refreshed.
		///
		///
		/// TCL Syntax: refresh_hw_sysmon [-regexp] [-properties <args>] [-quiet] [-verbose] <hw_objects>
		///
		/// Refresh the properties of the hw_sysmon object with the values on the system monitor (XADC)
		/// from the current hw_device.
		/// The refresh command takes the values from the status registers of the system monitor on the
		/// hardware device, and populates them into the appropriate properties of the hw_sysmon object in
		/// the hardware manager.
		/// TIP: The hw_sysmon object is automatically refreshed at the rate specified by the
		/// SYSMON_REFRESH_RATE_MS on the object.
		/// This command updates the properties on the hw_sysmon object, but otherwise returns nothing if
		/// successful. The command returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1217
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="regexp">(Optional) Properties list contains full regular expressions</param>
		/// <param name="properties">(Optional) List of properties to refresh Default: All properties in object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_hw_sysmon(String hw_objects, bool? regexp = null, TCLParameterList properties = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_hw_sysmon [-regexp] [-properties <args>] [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.refresh_hw_sysmon(hw_objects, regexp, properties, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Refresh a hardware target
		///
		///
		/// TCL Syntax: refresh_hw_target [-force_poll] [-quiet] [-verbose] [<hw_target>]
		///
		/// Refresh the connection to the specified hardware target on the current hardware server, and
		/// reload the hw_target object in the Hardware Manager of the Vivado Design Suite. If no
		/// hw_target object is specified, the current_hw_target will be refreshed.
		/// The hardware target is a system board containing a JTAG chain of one or more Xilinx devices that
		/// you can program with a bitstream file, or use to debug your design. Connections between
		/// hardware targets on the system board and the Vivado Design Suite are managed by the Xilinx
		/// hardware server application, and the connect_hw_server command. Refer to Vivado Design
		/// Suite User Guide: Programming and Debugging (UG908) for a list of supported JTAG download
		/// cables and devices.
		/// Each hardware target can have one or more Xilinx devices to program, or to use for debugging
		/// purposes. The current device is specified or returned by the current_hw_device command.
		/// After specifying the current hardware target, you can open the connection through the hardware
		/// target, to the Xilinx FPGA using the open_hw_target command.
		/// refresh_hw_target scans the devices on the hardware target and creates, deletes, or
		/// updates the hw_device objects available through the target. Available devices are returned using
		/// the get_hw_devices command.
		/// This command returns a transcript of the refresh process, or returns an error if it fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1219
		/// </summary>
		/// <param name="force_poll">(Optional) Force poll of all targets</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_target">(Optional) hardware target</param>
		public TTCL refresh_hw_target(bool? force_poll = null, bool? quiet = null, bool? verbose = null, String hw_target = null)
		{
			// TCL Syntax: refresh_hw_target [-force_poll] [-quiet] [-verbose] [<hw_target>]
			_tcl.Entry(_builder.refresh_hw_target(force_poll, quiet, verbose, hw_target));
			return _tcl;
		}
		/// <summary>
		/// Update hardware probe INPUT_VALUE and ACTIVITY_VALUE properties with values read from
		/// hardware VIO core(s).
		///
		///
		/// TCL Syntax: refresh_hw_vio [-update_output_values] [-quiet] [-verbose] <hw_vios>...
		///
		/// Update the INPUT_VALUE and ACTIVITY_VALUE properties of the input probes of the specified
		/// VIO debug cores with values read from the hw_vio core on the hardware device.
		/// The Virtual Input/Output (VIO) debug core can both monitor and drive internal signals on a
		/// programmed Xilinx device in real time. The VIO core uses hardware probes, hw_probe objects, to
		/// monitor and drive signals on the device. Input probes monitor signals as inputs to the VIO core.
		/// Output probes drive signals to specified values from the VIO core.
		/// The refresh_hw_vio command reads the signal values at the input probes of the VIO debug
		/// core on the device, and applies the value to the INPUT_VALUE property of the hw_probe, and
		/// updates the ACTIVITY_VALUE property on the probe as well.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1221
		/// </summary>
		/// <param name="hw_vios">(Required) List of hardware VIO objects.</param>
		/// <param name="update_output_values">
		/// (Optional)
		/// Update hardware probe OUTPUT_VALUE property with
		/// values read from VIO core(s).
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_hw_vio(TCLParameterList hw_vios, bool? update_output_values = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_hw_vio [-update_output_values] [-quiet] [-verbose] <hw_vios>...
			_tcl.Entry(_builder.refresh_hw_vio(hw_vios, update_output_values, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// De-select Pseudo Channel from Activity Monitor on the specified hardware HBM(s). Must
		/// specify the Memory Controller number first, follow by Pseudo Channel number.
		///
		///
		/// TCL Syntax: remove_hw_hbm_pc [-quiet] [-verbose] <mc_num> <pc_num> <hw_objects>
		///
		/// The remove_hw_hbm_pc command removes a memory channel (mc)/psuedo channel (pc) that
		/// has been previously added to an HBM activity monitor using the add_hw_hbm_pc command.
		/// TIP: The HBM activity monitor must not be running when adding or removing psuedo channels.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example removes the previously added psuedo channel from the HBM activity
		/// monitor, and then runs the activity monitor:
		/// remove_hw_hbm_pc 2 0 [get_hw_hbms *HBM_2]
		/// run_hw_hbm_amon [get_hw_hbms *HBM_2]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1256
		/// </summary>
		/// <param name="mc_num">(Required) Memory Controller number to de-select: 0 to 7</param>
		/// <param name="pc_num">(Required) Pseudo Channel number to de-select: 0 or 1</param>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_hw_hbm_pc(String mc_num, String pc_num, String hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_hw_hbm_pc [-quiet] [-verbose] <mc_num> <pc_num> <hw_objects>
			_tcl.Entry(_builder.remove_hw_hbm_pc(mc_num, pc_num, hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Remove enumerated name-value pairs from a hw_probe enumeration.
		///
		///
		/// TCL Syntax: remove_hw_probe_enum [-no_gui_update] [-list <args>] [-remove_all] [-quiet] [-verbose] <hw_probe>
		///
		/// Remove the enumerated name/value pairs defined on a specified hw_probe object.
		/// The enumerated names (ENUM property) are added to a hw_probe object using the
		/// add_hw_probe_enum command. This command removes those defined properties.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// The following example removes the list of enumerated names from the specified hw_probe
		/// object:
		/// remove_hw_probe_enum -list {WHITE YELLOW GREY} \
		/// [get_hw_probes op1 -of_objects [current_hw_ila]]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1258
		/// </summary>
		/// <param name="hw_probe">(Required) ILA hardware probe object.</param>
		/// <param name="no_gui_update">(Optional) Defer GUI update.</param>
		/// <param name="list">(Optional) List of enumerated names to remove.</param>
		/// <param name="remove_all">(Optional) Remove the whole enumeration for a hardware probe. Default: 0</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_hw_probe_enum(String hw_probe, bool? no_gui_update = null, TCLParameterList list = null, bool? remove_all = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_hw_probe_enum [-no_gui_update] [-list <args>] [-remove_all] [-quiet] [-verbose] <hw_probe>
			_tcl.Entry(_builder.remove_hw_probe_enum(hw_probe, no_gui_update, list, remove_all, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Remove an existing hardware SIO link.
		///
		///
		/// TCL Syntax: remove_hw_sio_link [-quiet] [-verbose] <hw_sio_links>
		///
		/// Removes the specified communication links between TX and RX objects on the GTs of the IBERT
		/// debug core defined on the current hardware device.
		/// Vivado Serial I/O analyzer is a link-based analyzer, which lets you link between any transmitter
		/// and receiver within the IBERT design. The links define the communication paths and protocols
		/// between transmitters and receivers of the GigaBit transceivers on the device. This command
		/// removes those links.
		/// This command returns a list of link objects on the IBERT debug core, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1260
		/// </summary>
		/// <param name="hw_sio_links">(Required) hardware SIO links</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_hw_sio_link(String hw_sio_links, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_hw_sio_link [-quiet] [-verbose] <hw_sio_links>
			_tcl.Entry(_builder.remove_hw_sio_link(hw_sio_links, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Remove an existing hardware SIO link group.
		///
		///
		/// TCL Syntax: remove_hw_sio_linkgroup [-quiet] [-verbose] <hw_sio_linkgroups>
		///
		/// Removes the specified group that associates communication links between TX and RX objects on
		/// the GTs of the IBERT debug core defined on the current hardware device.
		/// Vivado Serial I/O analyzer is a link-based analyzer. The links define the communication paths and
		/// protocols between transmitters and receivers of the GigaBit transceivers on the device. Link
		/// groups, or hw_sio_linkgroup objects, let you associate links into related groups, to collectively
		/// configure properties and run scans.
		/// TIP: The remove_hw_sio_linkgroup command removes the specified association, but does not
		/// remove the underlying communication links. Us the remove_hw_sio_link command to remove those
		/// objects.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1262
		/// </summary>
		/// <param name="hw_sio_linkgroups">(Required) hardware SIO linkgroups</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_hw_sio_linkgroup(String hw_sio_linkgroups, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_hw_sio_linkgroup [-quiet] [-verbose] <hw_sio_linkgroups>
			_tcl.Entry(_builder.remove_hw_sio_linkgroup(hw_sio_linkgroups, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Remove an existing hardware SIO scan.
		///
		///
		/// TCL Syntax: remove_hw_sio_scan [-quiet] [-verbose] <hw_sio_scans>
		///
		/// Remove the specified serial I/O analyzer scan object.
		/// This command returns nothing if successful, or returns an error if the command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1264
		/// </summary>
		/// <param name="hw_sio_scans">(Required) hardware SIO scans</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_hw_sio_scan(String hw_sio_scans, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_hw_sio_scan [-quiet] [-verbose] <hw_sio_scans>
			_tcl.Entry(_builder.remove_hw_sio_scan(hw_sio_scans, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Remove an existing hardware SIO sweep.
		///
		///
		/// TCL Syntax: remove_hw_sio_sweep [-quiet] [-verbose] <hw_sio_sweeps>
		///
		/// Remove the specified serial I/O analyzer sweep scan object.
		/// This command returns nothing if successful, or returns an error if the command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1266
		/// </summary>
		/// <param name="hw_sio_sweeps">(Required) hardware SIO sweeps</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL remove_hw_sio_sweep(String hw_sio_sweeps, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: remove_hw_sio_sweep [-quiet] [-verbose] <hw_sio_sweeps>
			_tcl.Entry(_builder.remove_hw_sio_sweep(hw_sio_sweeps, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Report formatted hardware AXI Transaction data
		///
		///
		/// TCL Syntax: report_hw_axi_txn [-w <arg>] [-t <arg>] [-quiet] [-verbose] <hw_axi_txns>...
		///
		/// Report the results of the specified AXI transactions on the JTAG to AXI Master, hw_axi.
		/// You can use this command after creating hw_axi_txn objects on existing hw_axi objects, and
		/// then running the hw_axi to exercise the defined transaction.
		/// The JTAG to AXI Master core can only be controlled using Tcl commands. You can issue AXI read
		/// and write transactions using the create_hw_axi_txns command. However, before issuing
		/// these commands, it is important to reset the JTAG to AXI Master core using the reset_hw_axi
		/// command.
		/// This command reports the transaction data in the specified format, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1369
		/// </summary>
		/// <param name="hw_axi_txns">(Required) hardware AXI Transaction object to report</param>
		/// <param name="w">(Optional) Output data bytes per output line. Default: 8</param>
		/// <param name="t">
		/// (Optional)
		/// d[SIZE] signed decimal, SIZE bytes per integer, b[SIZE]
		/// binary, SIZE bytes per integer, o[SIZE] octal, SIZE bytes per
		/// integer, u[SIZE] unsigned decimal, SIZE bytes per integer,
		/// x[SIZE] hexadecimal, SIZE bytes per integer Default: x4 (4-
		/// bytes in hex)
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_hw_axi_txn(TCLParameterList hw_axi_txns, String w = null, String t = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_hw_axi_txn [-w <arg>] [-t <arg>] [-quiet] [-verbose] <hw_axi_txns>...
			_tcl.Entry(_builder.report_hw_axi_txn(hw_axi_txns, w, t, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Formatted report on Versal integrated and soft Memory Controllers' (DDRMCs) memory
		/// configurations, calibration status, stages, and window margins data.
		///
		///
		/// TCL Syntax: report_hw_ddrmc [-file <arg>] [-append] [-return_string] [-quiet] [-verbose] <hw_objects>
		///
		/// Report formatted information on memory IP hardware configuration, calibration, and margin.
		/// Does not include the graphical margin scan plots that are available within the Vivado logic
		/// analyzer, or Vivado Lab Edition.
		/// In the Vivado tools, Versal memory controllers implemented into a design are associated with
		/// hw_ddrmc objects. These hw_ddrmc objects let you verify the calibration, read, and write
		/// window margins in your memory interface design. You can use the hardware manager GUI to
		/// check the calibration status, verify the read margin for both rising and falling edges of the clock,
		/// and write margin for both simple and complex patterns. You can also use an ILA and VIO core to
		/// verify the data integrity for the read and write operations.
		/// This command returns the reported data, or returns an error if it fails.
		///
		/// The following example generates the report on the hw_ddrmc objects and outputs them to the
		/// text file specified:
		/// report_hw_ddrmc -file C:/Data/ddrmc_report.txt [get_hw_ddrmcs]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1372
		/// </summary>
		/// <param name="hw_objects">(Required) hardware DDRMC objects</param>
		/// <param name="file">(Optional) file name (including full path) to output the report results to</param>
		/// <param name="append">(Optional) set this option to append the report results to a file</param>
		/// <param name="return_string">(Optional) set this option to have report results returned as a string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_hw_ddrmc(String hw_objects, String file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_hw_ddrmc [-file <arg>] [-append] [-return_string] [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.report_hw_ddrmc(hw_objects, file, append, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Report formatted hardware MIG calibration status and margin data
		///
		///
		/// TCL Syntax: report_hw_mig [-file <arg>] [-append] [-return_string] [-quiet] [-verbose] <hw_objects>
		///
		/// Report formatted information on memory IP hardware configuration, calibration, and margin.
		/// Does not include the graphical margin scan plots that are available within the Vivado logic
		/// analyzer, or Vivado Lab Edition.
		/// In the Vivado tools, memory controllers implemented into a design are associated with hw_mig
		/// objects. These hw_mig objects let you verify the calibration, read, and write window margins in
		/// your memory interface design. You can use the hardware manager GUI to check the calibration
		/// status, verify the read margin for both rising and falling edges of the clock, and write margin for
		/// both simple and complex patterns, or DQS. You can also use an ILA core to verify the data
		/// integrity for the read and write operations.
		/// This command returns the reported data, or returns an error if it fails.
		///
		/// The following example generates the report on the hw_mig objects and outputs to the text file
		/// specified:
		/// report_hw_mig -file C:/Data/hw_mig_report.txt [get_hw_migs]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1374
		/// </summary>
		/// <param name="hw_objects">(Required) hardware mig objects</param>
		/// <param name="file">(Optional) file name (including full path) to output the report results to</param>
		/// <param name="append">(Optional) set this option to append the report results to a file</param>
		/// <param name="return_string">(Optional) set this option to have report results return as a string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_hw_mig(String hw_objects, String file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_hw_mig [-file <arg>] [-append] [-return_string] [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.report_hw_mig(hw_objects, file, append, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Formatted report for PCIe core.
		///
		///
		/// TCL Syntax: report_hw_pcie [-file <arg>] [-append] [-return_string] [-quiet] [-verbose] <hw_pcie>
		///
		/// Generate a report for the Peripheral Component Interconnect Express (PCIe) debug core object,
		/// hw_pcie, defined on the current hardware device.
		/// The customizable LogiCORE IP PCIe core for Xilinx ACAPs is designed for evaluating and
		/// monitoring the PCIe Link Training and Status State Machine (LTSSM) running on the Gigabit
		/// Transceivers (GTs). In the Vivado Hardware Manager, Versal PCIe soft cores implemented in the
		/// design, are represented as hw_pcie objects. You can use these PCIe debug cores to solve a range
		/// of debug and validation problems; from viewing the PCIe link info to the LTSSM state transition
		/// diagram.
		/// This command generates a report with general information about the PCIe core, the LTSSM state
		/// visitation status and the trace data for the LTSSM transition graph.
		///
		/// The following example generates a report for the PCIe core at index 0
		/// report_hw_pcie [lindex [get_hw_pcies] 0]
		/// The following example generates the report for the hw_pcie objects and outputs them to the text
		/// file specified
		/// report_hw_pcie -file C:/data/pcie_report.txt [get_hw_pcies]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1376
		/// </summary>
		/// <param name="hw_pcie">(Required) Hardware PCIe object</param>
		/// <param name="file">(Optional) File name (including full path) to output the report results to</param>
		/// <param name="append">(Optional) Append the report results to a file</param>
		/// <param name="return_string">(Optional) Return report results as a string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_hw_pcie(String hw_pcie, String file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_hw_pcie [-file <arg>] [-append] [-return_string] [-quiet] [-verbose] <hw_pcie>
			_tcl.Entry(_builder.report_hw_pcie(hw_pcie, file, append, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Formatted report on Versal soft Memory Controller cores' (Soft MCs) memory configurations,
		/// calibration status, stages, and window margins data.
		///
		///
		/// TCL Syntax: report_hw_softmc [-file <arg>] [-append] [-return_string] [-quiet] [-verbose] <hw_objects>
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1378
		/// </summary>
		/// <param name="hw_objects">(Required) hardware Soft MC objects</param>
		/// <param name="file">(Optional) file name (including full path) to output the report results to</param>
		/// <param name="append">(Optional) set this option to append the report results to a file</param>
		/// <param name="return_string">(Optional) set this option to have report results returned as a string</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL report_hw_softmc(String hw_objects, String file = null, bool? append = null, bool? return_string = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: report_hw_softmc [-file <arg>] [-append] [-return_string] [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.report_hw_softmc(hw_objects, file, append, return_string, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Report properties on hardware objects
		///
		///
		/// TCL Syntax: report_hw_targets [-quiet] [-verbose]
		///
		/// This command returns properties related to the configuration of all hw_targets on the
		/// current_hw_server object. The information reported by this command includes:
		/// • Server Property Information: The properties of the current_hw_server, including HOST and
		/// PORT.
		/// • Target Property Information: Reported for each target on the hw_server, including NAME,
		/// FREQUENCY, DEVICE_COUNT, and SVF.
		/// • Device Property Information: Reported for each device on a specific hw_target, including
		/// PART, ID CODE, IR LENGTH, MASK, PROGRAMMING and PROBES FILE.
		/// This command returns the requested information if successful, or returns an error if it fails.
		///
		/// The following example reports the property information for all targets on the connected
		/// hw_server:
		/// report_hw_targets
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1379
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
		/// Reset hardware AXI core state.
		///
		///
		/// TCL Syntax: reset_hw_axi [-quiet] [-verbose] [<hw_axis>...]
		///
		/// Reset the STATUS properties of the specified hw_axi objects, or the current device.
		/// The reset_hw_axi restores the hw_axi core on the current device to a known state from which
		/// to begin running AXI transactions. The STATUS properties include:
		/// • STATUS.AXI_READ_BUSY
		/// • STATUS.AXI_READ_DONE
		/// • STATUS.AXI_WRITE_BUSY
		/// • STATUS.AXI_WRITE_DONE
		/// • STATUS.BRESP - Write Response Channel Response. Indicates results of the write transfer.
		/// • STATUS.RRESP - Read Response Channel Response. Indicates results of the read transfer.
		/// The command returns nothing if successful, and returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1484
		/// </summary>
		/// <param name="hw_axis">(Required) List of hardware AXI objects.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_hw_axi(TCLParameterList hw_axis, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_hw_axi [-quiet] [-verbose] [<hw_axis>...]
			_tcl.Entry(_builder.reset_hw_axi(hw_axis, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Reset hardware ILA control properties to default values.
		///
		///
		/// TCL Syntax: reset_hw_ila [-reset_compare_values <arg>] [-quiet] [-verbose] [<hw_ilas>...]
		///
		/// Reset the trigger and capture configuration properties on the specified ILA debug core, and the
		/// TRIGGER_COMPARE_VALUE and CAPTURE_COMPARE_VALUE properties on the core's debug
		/// probes.
		/// Properties of the hw_ila object are configured with the set_property command in preparation
		/// for the run_hw_ila command to configure the ILA core on the hw_device. This command
		/// restores the user-configurable properties on the specified hw_ila to their default settings. Refer
		/// to the Vivado Design Suite User Guide: Programming and Debugging (UG908) for more information
		/// on these properties.
		/// The default properties are:
		/// • CONTROL.DATA_DEPTH is set to the MAX_DATA_DEPTH of the hw_ila object.
		/// • CONTROL.TRIGGER_POSITION 0
		/// • CONTROL.WINDOW_COUNT 1
		/// • CONTROL.TRIGGER_MODE BASIC_ONLY
		/// • CONTROL.TRIGGER_CONDITION AND
		/// • CONTROL.TRIG_OUT_MODE DISABLED
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// • CONTROL.CAPTURE_MODE ALWAYS
		/// • CONTROL.CAPTURE_CONDITION AND
		/// • TRIGGER_COMPARE_VALUE eq1'bX (on the hw_probes)
		/// • CAPTURE_COMPARE_VALUE eq1'bX (on the hw_probes)
		/// This command operates silently, returning nothing if successful, or returning an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1486
		/// </summary>
		/// <param name="reset_compare_values">(Optional) Reset associated hardware probe compare values.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_ilas">(Optional) List of hardware ILA objects. Default: Current hardware ILA</param>
		public TTCL reset_hw_ila(String reset_compare_values = null, bool? quiet = null, bool? verbose = null, TCLParameterList hw_ilas = null)
		{
			// TCL Syntax: reset_hw_ila [-reset_compare_values <arg>] [-quiet] [-verbose] [<hw_ilas>...]
			_tcl.Entry(_builder.reset_hw_ila(reset_compare_values, quiet, verbose, hw_ilas));
			return _tcl;
		}
		/// <summary>
		/// Reset the PCIe core.
		///
		///
		/// TCL Syntax: reset_hw_pcie [-quiet] [-verbose] <hw_pcie>
		///
		/// Reset the Peripheral Component Interconnect Express (PCIe) debug core object, hw_pcie,
		/// defined on the current hardware device.
		/// The customizable LogiCORE IP PCIe core for Xilinx ACAPs is designed for evaluating and
		/// monitoring the PCIe Link Training and Status State Machine (LTSSM) running on the Gigabit
		/// Transceivers (GTs). In the Vivado Hardware Manager, Versal PCIe soft cores implemented in the
		/// design, are represented as hw_pcie objects. You can use these PCIe debug cores to solve a range
		/// of debug and validation problems; from viewing the PCIe link info to the LTSSM state transition
		/// diagram.
		/// This command resets the PCIe soft IP in hardware.
		///
		/// The following example resets PCIe core at index 0
		/// reset_hw_pcie [lindex [get_hw_pcies] 0]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1488
		/// </summary>
		/// <param name="hw_pcie">(Required) Hardware PCIe object</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_hw_pcie(String hw_pcie, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_hw_pcie [-quiet] [-verbose] <hw_pcie>
			_tcl.Entry(_builder.reset_hw_pcie(hw_pcie, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Reset hardware VIO ACTIVITY_VALUE properties, for hardware probes associated with specified
		/// hardware VIO objects.
		///
		///
		/// TCL Syntax: reset_hw_vio_activity [-quiet] [-verbose] <hw_vios>...
		///
		/// Resets the ACTIVITY_VALUE properties for all hardware probes on the specified VIO debug core
		/// objects. The ACTIVITY_VALUE property is used by the Vivado IDE to represent transitions on
		/// the input probes of the VIO debug cores.
		/// In addition to reading values from the VIO input probes, you can also monitor the activity of the
		/// VIO input probes. The ACTIVITY_VALUE property is used to indicate when the values on the
		/// VIO inputs have changed in between periodic updates to the Vivado IDE. Refer to the Vivado
		/// Design Suite User Guide: Programming and Debugging (UG908) for more information.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1490
		/// </summary>
		/// <param name="hw_vios">(Required) List of hardware VIO objects.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_hw_vio_activity(TCLParameterList hw_vios, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_hw_vio_activity [-quiet] [-verbose] <hw_vios>...
			_tcl.Entry(_builder.reset_hw_vio_activity(hw_vios, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Reset hardware VIO core outputs to initial values.
		///
		///
		/// TCL Syntax: reset_hw_vio_outputs [-quiet] [-verbose] <hw_vios>...
		///
		/// Reset the hardware VIO debug core outputs to their initial, or "reset" state.
		/// The Virtual Input/Output (VIO) debug core can both monitor and drive internal signals on a
		/// programmed Xilinx FPGA in real time. The VIO core uses hardware probes, hw_probe objects, to
		/// monitor and drive signals on the device. Input probes monitor signals as inputs to the VIO core.
		/// Output probes drive signals to specified values from the VIO core.
		/// The reset_hw_vio_outputs command restores the signal values at the output probes of the
		/// specified hw_vio debug cores to their initial values. This affects the signal on the hw_device, but
		/// does not affect the OUTPUT_VALUE property of the hw_probe objects.
		/// TIP: This command has the effect of resetting the initial value of the signal on the hw_vio debug core,
		/// without resetting the properties on the hw_probe object.
		/// This command returns nothing if successful, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1492
		/// </summary>
		/// <param name="hw_vios">(Required) List of hardware VIO objects.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL reset_hw_vio_outputs(TCLParameterList hw_vios, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: reset_hw_vio_outputs [-quiet] [-verbose] <hw_vios>...
			_tcl.Entry(_builder.reset_hw_vio_outputs(hw_vios, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Resume Activity Monitor runs after paused for the specified hardware HBM(s)
		///
		///
		/// TCL Syntax: resume_hw_hbm_amon [-quiet] [-verbose] <hw_objects>
		///
		/// The resume_hw_hbm_amon command restarts a running HBM activity monitor in the Vivado
		/// hardware manager that has been previously paused using the pause_hw_hbm_amon command.
		/// This command returns nothing when successful, or returns an error when it fails.
		///
		/// The following example restarts the HBM activity monitor for the associated HBM core:
		/// resume_hw_hbm_amon [get_hw_hbms *HBM_2]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1537
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL resume_hw_hbm_amon(String hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: resume_hw_hbm_amon [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.resume_hw_hbm_amon(hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Run hardware AXI read/write transaction(s)and update transaction status in hw_axi object..
		///
		///
		/// TCL Syntax: run_hw_axi [-queue] [-quiet] [-verbose] <hw_axi_txns>...
		///
		/// Run the AXI transactions defined on the specified JTAG to AXI Master core.
		/// AXI transactions are created with the create_hw_axi_txns command.
		/// Run the specified hardware AXI read/write transactions on the AXI bus, and update the
		/// transaction status on the associated hw_axi object.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1547
		/// </summary>
		/// <param name="hw_axi_txns">(Required) hardware AXI Transaction object to execute on the AXI bus.</param>
		/// <param name="queue">(Optional) Queue Transaction. Default: 0</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL run_hw_axi(TCLParameterList hw_axi_txns, bool? queue = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: run_hw_axi [-queue] [-quiet] [-verbose] <hw_axi_txns>...
			_tcl.Entry(_builder.run_hw_axi(hw_axi_txns, queue, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Enable Activity Monitor runs for the specified hardware HBM(s)
		///
		///
		/// TCL Syntax: run_hw_hbm_amon [-quiet] [-verbose] <hw_objects>
		///
		/// The HBM activity monitor (amon) can be used to gain real-time access to performance
		/// monitoring and temperature sensors certain Xilinx® UltraScale+ devices that include an
		/// integrated High-Bandwidth Memory (HBM) controller. Refer to the LogiCore IP Product Guide:
		/// AXI High Bandwidth Memory Controller (PG276) for more information on this core. The HBM
		/// controller and memory stacks contain both performance counters and temperature sensors that
		/// can be accessed through the HBM activity monitor from within the Xilinx Vivado hardware
		/// manager. The HBM activity monitor displays read, write, and overall throughput of data, as well
		/// as the device temperature. The activity monitor displays, captures, and exports data to a CSV file
		/// when it is running.
		/// The run_hw_hbm_amon command runs an HBM activity monitor in the Vivado hardware
		/// manager that has been previously configured using the add_hw_hbm_pc command.
		/// This command returns the file path and name of a CSV file the collected data will be written to,
		/// or returns an error if it fails.
		///
		/// The following example runs the HBM activity monitor for the associated HBM core:
		/// run_hw_hbm_amon [get_hw_hbms *HBM_2]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1549
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL run_hw_hbm_amon(String hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: run_hw_hbm_amon [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.run_hw_hbm_amon(hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Arm hardware ILAs.
		///
		///
		/// TCL Syntax: run_hw_ila [-trigger_now] [-compile_only] [-file <arg>] [-force] [-quiet] [-verbose] [<hw_ilas>...]
		///
		/// Arm triggers and run the specified hardware ILA debug cores on the current hardware device.
		/// The Integrated Logic Analyzer (ILA) debug core lets you perform in-system debug of
		/// implemented designs, or design bitstreams, on a programmed Xilinx FPGA. The ILA core includes
		/// many advanced features of modern logic analyzers, including boolean trigger equations, and edge
		/// transition triggers. You can use the ILA core to probe specific signals of the design, to trigger on
		/// programmed hardware events, and capture data samples from the Xilinx FPGA in real-time. Refer
		/// to LogiCORE IP Integrated Logic Analyzer (PG172) for details of the ILA core.
		/// You can add ILA debug cores into the RTL source files of a design, or in the synthesized netlist
		/// using the create_debug_core command. Refer to the Vivado Design Suite User Guide: Vivado
		/// Programming and Debugging (UG908) for more information on adding debug cores and signal
		/// probes to the design.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Debug cores and probes are written to a probes file (.ltx) using the write_debug_probes
		/// command, and associated with the hardware device along with the bitstream file (.bit) using
		/// the PROBES.FILE and PROGRAM.FILE properties of the hw_device object. The hardware device
		/// is programmed using the program_hw_devices command. The ILA debug cores in the design
		/// are accessible from the Hardware Manager using the get_hw_ilas command. The debug
		/// probes assigned to the ILA debug cores can be returned with the get_hw_probes command.
		/// The steps to debug your design in hardware using an ILA debug core are:
		/// 1. Connect to the hardware server and target using connect_hw_server and
		/// open_hw_target.
		/// 2. Program the FPGA with the bitstream (.bit) and probes (.ltx) files using
		/// program_hw_devices.
		/// 3. Set up the ILA debug core trigger events and data capture controls using set_property to
		/// configure properties of the ILA.
		/// 4. Arm the ILA debug core triggers on the Xilinx FPGA using run_hw_ila. When a trigger
		/// event occurs, or the capture condition is met, the ILA capture buffer is filled.
		/// 5. Uploaded sampled data from the hw_device into a Vivado logic analyzer hw_ila_data object
		/// using upload_hw_ila_data.
		/// 6. View the captured data in the Waveform window of the Vivado logic analyzer feature using
		/// display_hw_ila_data.
		/// You can set up an ILA debug core to trigger on specific events or conditions at the debug probes,
		/// and to capture data under specific conditions, using CONTROL properties on the hw_ila object.
		/// You set these properties with the set_property command. Refer to the Vivado Design Suite
		/// User Guide: Vivado Programming and Debugging (UG908) for more information on setting
		/// properties to configure debug cores and signal probes to monitor the design.
		/// RECOMMENDED: The Vivado IDE provides a graphical interface to configure hw_ila and hw_probes for
		/// trigger and capture. You can use the Vivado IDE to see the properties needed to configure and run the
		/// hw_ila.
		/// The specific properties on the hw_ila you can use to configure a debug core include the
		/// following:
		/// • CONTROL.DATA_DEPTH - Defaults to the MAX_DATA_DEPTH of the ILA debug core, which
		/// was set when the debug core was created or inserted into the design. The data depth defines
		/// the number of data samples the hw_ila object can capture in a data window. Set the data
		/// depth as an integer which is a power of two, from 1 to the maximum data depth
		/// (MAX_DATA_DEPTH) of the hw_ila.
		/// Note: The value of DATA_DEPTH is related to CONTROL.WINDOW_COUNT by the equation:
		/// DATA_DEPTH * WINDOW_COUNT = MAX_DATA_DEPTH
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// • CONTROL.WINDOW_COUNT - Lets you divide the MAX_DATA_DEPTH of the ILA core into
		/// a number of data windows to store sample data from multiple trigger events. In the case of 10
		/// data windows for example, the first window will be filled at the first trigger event, and each
		/// subsequent window will be filled upon subsequent triggering events or capture conditions.
		/// • CONTROL.TRIGGER_POSITION - An integer value related to the DATA_DEPTH. Positions the
		/// trigger event in the sample data buffer. For a DATA_DEPTH of 1024, position 0 refers to the
		/// first (or left-most) data buffer and 1023 refers to the last (or right-most) data buffer. The
		/// TRIGGER_POSITION lets you capture sample data ahead of the trigger event. For instance,
		/// with a DATA_DEPTH of 256, a TRIGGER_POSITION of 100 allows you to capture 100 data
		/// samples ahead of the trigger, and 155 data samples at and after the trigger event.
		/// Note: In the case of run_hw_ila -trigger_now 1, the TRIGGER_POSITION merely positions the
		/// trigger mark in the Vivado logic analyzer waveform window. Because the trigger event is immediate,
		/// there is no time to capture data samples ahead of the trigger.
		/// • CONTROL.TRIGGER_MODE - Valid values include:
		/// ○ BASIC_ONLY - The trigger condition is the result of a Boolean equation using the
		/// TRIGGER_CONDITION to evaluate the values on each of the associated ILA probes.
		/// ○ BASIC_OR_TRIG_IN - The ILA core is triggered by a Boolean equation considering probe
		/// values, or by the TRIG_IN port on the core.
		/// ○ ADVANCED_ONLY - The ILA core is configured to have advanced trigger capabilities
		/// defined in a user-defined Trigger State Machine (TSM).
		/// ○ ADVANCED_OR_TRIG_IN - The ILA core is triggered by the TSM or by the TRIG_IN port
		/// on the core.
		/// ○ TRIG_IN_ONLY - The ILA core is triggered only by the TRIG_IN port on the core.
		/// • CONTROL.TRIGGER_CONDITION - Defines a Boolean equation which evaluates comparators
		/// on participating probes on the ILA debug core. When the condition evaluates to true, the
		/// BASIC trigger mode is satisfied. Valid values include:
		/// ○ AND - Trigger condition is "true" if all participating probe comparators evaluate "true",
		/// otherwise trigger condition is "false".
		/// ○ NAND - Trigger condition is "true" if at least one participating probe comparator evaluates
		/// "false", otherwise trigger condition is "false".
		/// ○ OR - Trigger condition is "true" if at least one participating probe comparator evaluates
		/// "true", otherwise trigger condition is "false".
		/// ○ NOR - Trigger condition is "true" if all participating probe comparators evaluate "false",
		/// otherwise trigger condition is "false".
		/// Note: The evaluation of the probes participating in the trigger condition is determined by the
		/// TRIGGER_COMPARE_VALUE property assigned to the hw_probe object, as returned by
		/// get_hw_probes. If the TRIGGER_COMPARE_VALUE is 'X' then it is not participating in the trigger
		/// condition.
		/// • CONTROL.TSM_FILE - Specify the path to a file defining a Trigger Finite State Machine (TSM)
		/// to be used for advanced trigger handling.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// • CONTROL.TRIG_OUT_MODE - Used to transition the TRIG_OUT port on the ILA core to be
		/// used to drive the TRIG_IN port on other ILA cores. Valid values include:
		/// ○ DISABLED - Disable the TRIG_OUT port on the ILA core.
		/// ○ TRIGGER_ONLY - Transition the TRIG_OUT port when the trigger conditions have been
		/// satisfied.
		/// ○ TRIG_IN_ONLY - Transition the TRIG_OUT when the TRIG_IN signal transitions. Use this to
		/// pass the trigger event along a chain of ILA cores.
		/// ○ TRIGGER_OR_TRIG_IN - Transition the TRIG_OUT when either the trigger conditions are
		/// satisfied, or the TRIG_IN transitions.
		/// • CONTROL.CAPTURE_MODE - Valid values include ALWAYS or BASIC. Capture and store a
		/// data sample on the debug core ALWAYS during a given clock cycle, or only if the
		/// CAPTURE_CONDITION evaluates to "true" (BASIC).
		/// • CONTROL.CAPTURE_CONDITION - Defines a Boolean equation for participating probe
		/// comparators on the ILA debug core that must evaluate to TRUE to meet the data capture
		/// condition. When the capture condition evaluates to true, the BASIC capture mode is satisfied.
		/// Valid values include:
		/// ○ AND - Capture condition is "true" if all participating probe comparators evaluate "true",
		/// otherwise capture condition is "false".
		/// ○ NAND - Capture condition is "true" if at least one participating probe comparator evaluates
		/// "false", otherwise capture condition is "false".
		/// ○ OR - Capture condition is "true" if at least one participating probe comparator evaluates
		/// "true", otherwise capture condition is "false".
		/// ○ NOR - Capture condition is "true" if all participating probe comparators evaluate "false",
		/// otherwise capture condition is "false".
		/// Note: The evaluation of the probes participating in the capture condition is determined by the
		/// CAPTURE_COMPARE_VALUE property assigned to the hw_probe object, as returned by
		/// get_hw_probes. If the CAPTURE_COMPARE_VALUE is 'X' then it is not participating in the trigger
		/// condition.
		/// TIP: There are other properties on the ILA core that also determine the operation of the core, but they are
		/// not user-configurable.
		/// With the ILA core configured, you can use the run_hw_ila command to arm the ILA cores on
		/// the target part. When this command is run, the trigger configurations defined in the hw_ila and
		/// hw_probe objects are written to the target Xilinx FPGA (hw_device) and arms the ILA core or
		/// cores on the device.
		/// With the hw_ila armed and running, the wait_on_hw_ila command stops your Tcl script to
		/// wait for the data sample buffers to be populated with captured data. When the memory of the
		/// ILA core is full on the physical hw_device, the wait_on_hw_ila command returns, and your Tcl
		/// script resumes.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// You can use upload_hw_ila_data to upload the captured data from the physical memory of
		/// the hw_device into a hw_ila_data object in the Vivado logic analyzer. Then view the ILA data in
		/// the waveform window of the Vivado logic analyzer using display_hw_ila_data, and write
		/// the data for use in external tools using the write_hw_ila_data command.
		/// You can also immediately trigger the probes on the hw_device using the -trigger_now option,
		/// to capture data from the device right away, rather than waiting for trigger events or capture
		/// conditions to be met over time.
		/// You can use reset_hw_ila to restore the CONTROL properties of the ILA debug core to their
		/// default setting, and reset the probe comparator values to 'X'.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1551
		/// </summary>
		/// <param name="trigger_now">(Optional) Trigger and capture immediately.</param>
		/// <param name="compile_only">(Optional) Test only compile trigger state machine file but do not upload.</param>
		/// <param name="file">(Optional) Trigger at startup file name. Command will not arm ILA core.</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_ilas">(Optional) hardware ILAs Default: Current hardware ILA</param>
		public TTCL run_hw_ila(bool? trigger_now = null, bool? compile_only = null, String file = null, bool? force = null, bool? quiet = null, bool? verbose = null, TCLParameterList hw_ilas = null)
		{
			// TCL Syntax: run_hw_ila [-trigger_now] [-compile_only] [-file <arg>] [-force] [-quiet] [-verbose] [<hw_ilas>...]
			_tcl.Entry(_builder.run_hw_ila(trigger_now, compile_only, file, force, quiet, verbose, hw_ilas));
			return _tcl;
		}
		/// <summary>
		/// Run hardware SIO scans.
		///
		///
		/// TCL Syntax: run_hw_sio_scan [-quiet] [-verbose] <hw_sio_scans>
		///
		/// Run the specified serial I/O analyzer link scan.
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the
		/// specialized Eye Scan hardware of Xilinx UltraScale devices or 7 series FPGAs. The Vivado serial
		/// I/O analyzer feature lets you to create, run, and save link scans.
		/// This command creates and returns a link scan object that you can use with the
		/// run_hw_sio_scan command to run analysis on the specified links, or GT receivers. You can
		/// also save the scan to disk using the write_hw_sio_scan command.
		/// This command run analysis on the specified scan objects. If running in a Tcl script, you can
		/// suspend the script while the scan completes using the wait_on_hw_sio_scan command. You
		/// can stop a running scan using the stop_hw_sio_scan command.
		/// You can save the scan to disk using the write_hw_sio_scan command.
		/// You can remove the created scan object using remove_hw_sio_scan.
		/// This command returns the hw_sio_scan object, or returns an error if the command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1557
		/// </summary>
		/// <param name="hw_sio_scans">(Required) hardware SIO scans</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL run_hw_sio_scan(String hw_sio_scans, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: run_hw_sio_scan [-quiet] [-verbose] <hw_sio_scans>
			_tcl.Entry(_builder.run_hw_sio_scan(hw_sio_scans, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Run hardware SIO sweeps.
		///
		///
		/// TCL Syntax: run_hw_sio_sweep [-quiet] [-verbose] <hw_sio_sweeps>
		///
		/// Run a serial I/O analyzer link sweep scan to run multiple scans across a range of values.
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the
		/// specialized features of Xilinx UltraScale devices or 7 series FPGAs. It can also be helpful to run
		/// multiple scans on a the link with different configuration settings for the GTs. This can help you
		/// determine which settings are best for your design. The Vivado serial I/O analyzer feature enables
		/// you to define, run, and save link sweeps, or collections of link scans run across a range of values.
		/// This command run analysis on the specified sweep scan objects. If running in a Tcl script, you can
		/// suspend the script while the sweep scan completes using the wait_on_hw_sio_sweep
		/// command. You can stop a running sweep scan using the stop_hw_sio_sweep command.
		/// You can save the sweep scan to disk using the write_hw_sio_sweep command.
		/// You can remove the created scan object using remove_hw_sio_sweep.
		/// This command returns the hw_sio_sweep object, or returns an error if the command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1559
		/// </summary>
		/// <param name="hw_sio_sweeps">(Required) hardware SIO sweeps</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL run_hw_sio_sweep(String hw_sio_sweeps, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: run_hw_sio_sweep [-quiet] [-verbose] <hw_sio_sweeps>
			_tcl.Entry(_builder.run_hw_sio_sweep(hw_sio_sweeps, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// change to a stable state of a specified transition
		///
		///
		/// TCL Syntax: run_state_hw_jtag [-state <args>] [-quiet] [-verbose] <stable_state>
		///
		/// Transition the hw_jtag object of the current hardware target to the specified TAP stable state.
		/// A hw_jtag object is created by the Hardware Manager feature of the Vivado Design Suite when a
		/// hardware target is opened in JTAG mode using the open_hw_target -jtag_mode command.
		/// The run_state_hw_jtag command specifies:
		/// • An ending or target TAP stable state to transition to.
		/// • An optional state path list to transition through to get from the current state to the target
		/// state.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// If an optional -state path list is defined, then the state list must contain all states needed to
		/// reach the stable state, or the command will return an error. If no state path list is defined, then
		/// the command will transition from the current state to the target state according to the state
		/// transition paths defined in the following table:
		/// Current Target State Transition Path
		/// State State
		/// DRPAUSE RESET DRPAUSE -> DREXIT2 -> DRUPDATE -> DRSELECT ->
		/// IRSELECT-> RESET
		/// DRPAUSE IDLE DRPAUSE -> DREXIT2 -> DRUPDATE -> IDLE
		/// DRPAUSE DRPAUSE DRPAUSE -> DREXIT2 -> DRUPDATE -> DRSELECT ->
		/// DRCAPTURE -> DREXIT1 -> DRPAUSE
		/// DRPAUSE IRPAUSE DRPAUSE -> DREXIT2 -> DRUPDATE -> DRSELECT ->
		/// IRSELECT -> IRCAPTURE -> IREXIT12 -> IRPAUSE
		/// IDLE RESET IDLE -> DRSELECT -> IRSELECT -> RESET
		/// IDLE IDLE IDLE
		/// IDLE DRPAUSE IDLE -> DRSELECT -> DRCAPTURE -> DREXIT1 ->
		/// DRPAUSE
		/// IDLE IRPAUSE IDLE -> DRPAUSE -> IRSELECT ->IRCAPTURE ->
		/// IREXIT1 -> IRPAUSE
		/// IRPAUSE RESET IRPAUSE -> IREXIT2 -> IRUPDATE -> DRSELECT ->
		/// IRSELECT -> RESET
		/// IRPAUSE IDLE IRPAUSE -> IREXIT2 -> IRUPDATE -> IDLE
		/// IRPAUSE DRPAUSE IRPAUSE -> IREXIT2 -> IRUPDATE -> DRSELECT ->
		/// DRCAPTURE -> DREXIT1 -> DRPAUSE
		/// IRPAUSE IRPAUSE IRPAUSE -> IREXIT2 -> IRUPDATE -> DRSELECT ->
		/// IRSELECT -> IRCAPTURE -> IREXIT1 -> IRPAUSE
		/// RESET RESET RESET
		/// RESET IDLE RESET -> IDLE
		/// RESET DRPAUSE RESET -> IDLE -> DRSELECT -> DRCAPTURE ->
		/// DREXIT1 -> DRPAUSE
		/// RESET IRPAUSE RESET -> IDLE -> DRSELECT -> IRSELECT ->
		/// IRCAPTURE -> IREXIT1 -> IRPAUSE
		/// This command returns the target stable state when successful, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1561
		/// </summary>
		/// <param name="stable_state">
		/// (Required)
		/// valid stable_state - valid stable states IDLE, RESET, IRPAUSE,
		/// and DRPAUSE
		/// </param>
		/// <param name="state">(Optional) valid state path sequence to stable_state</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>hardware JTAG</returns>
		public TTCL run_state_hw_jtag(String stable_state, TCLParameterList state = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: run_state_hw_jtag [-state <args>] [-quiet] [-verbose] <stable_state>
			_tcl.Entry(_builder.run_state_hw_jtag(stable_state, state, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Forces IEEE 1149.1 TAP state machine to a stable state for a specified wait period
		///
		///
		/// TCL Syntax: runtest_hw_jtag [-wait_state <arg>] [-end_state <arg>] [-sec <arg>] [-max_wait <arg>] [-tck <arg>] [-quiet] [-verbose]
		///
		/// Specify a wait operation for the hw_jtag object state machine which defines:
		/// • Which TAP stable state to go to perform the wait operation.
		/// • A wait time expressed as:
		/// ○ 'n' TCK cycles, where 'n' is a 32-bit unsigned decimal number.
		/// ○ A minimum and optionally maximum time in seconds to stay in the wait state, with
		/// min/max times specified as unsigned integers or real numbers.
		/// • The TAP stable state to go after the wait operation has completed.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The default values for -wait_state and -end_state are IDLE. If a non-IDLE wait_state or
		/// end_state are defined, then the hw_jtag object will first transition to the specified wait_state
		/// before starting the wait operation. Once the wait time has elapsed, the hw_jtag object transitions
		/// to the specified end_state. When the wait_state and/or end_state are specified by the
		/// runtest_hw_jtag command, subsequent commands will use the same wait_state/end_state
		/// unless they are changed.
		/// This command returns the end stable state, or returns an error if it fails.
		/// Note: If the command cannot meet the wait time specification, then it will raise an exception that can be
		/// trapped by the Tcl catch command.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1564
		/// </summary>
		/// <param name="wait_state">
		/// (Optional)
		/// valid stable_state - valid stable states IDLE, RESET, IRPAUSE,
		/// and DRPAUSE
		/// </param>
		/// <param name="end_state">
		/// (Optional)
		/// valid stable_state - valid stable states IDLE, RESET, IRPAUSE,
		/// and DRPAUSE
		/// </param>
		/// <param name="sec">(Optional) Number of seconds to wait in wait_state</param>
		/// <param name="max_wait">(Optional) Maximum Number of seconds to wait in wait_state - max timeout</param>
		/// <param name="tck">
		/// (Optional)
		/// Number of TCK cycles to wait in wait_state Default: Number
		/// of TCK cycles to wait in wait_state
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
		/// Perform shift DR on 'hw_jtag'.
		///
		///
		/// TCL Syntax: scan_dr_hw_jtag [-tdi <arg>] [-tdo <arg>] [-mask <arg>] [-smask <arg>] [-quiet] [-verbose] <length>
		///
		/// The scan_dr_hw_jtag command specifies a scan pattern to be scanned into the JTAG
		/// interface target data register.
		/// The command targets a hw_jtag object which is created when the hw_target is opened in JTAG
		/// mode through the use of the open_hw_target -jtag_mode command.
		/// When targeting the hw_jtag object prior to shifting the scan pattern specified in the
		/// scan_dr_hw_jtag command, the last defined header property (HDR) will be pre-pended to the
		/// beginning of the specified data pattern, and the last defined trailer property (TDR) will be
		/// appended to the end of the data pattern.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The options can be specified in any order, but can only be specified once. The number of bits
		/// represented by the hex strings specified for -tdi, -tdo, -mask, or -smask cannot be greater
		/// than the maximum specified by <length>. Leading zeros are assumed for a hex string if the
		/// number of bits represented by the hex strings specified is less than the <length>.
		/// When shifting the data bits to the target data register, the scan_dr_hw_jtag command moves
		/// the JTAG TAP from the current stable state to the DRSHIFT state according to the state
		/// transition table below:
		/// Current State Transitions to get to DRSHIFT state
		/// RESET IDLE -> DRSELECT -> DRCAPTURE -> DRSHIFT
		/// IDLE DRSELECT -> DRCAPTURE ->
		/// DRSHIFT
		/// IRPAUSE IREXIT2 -> IRUPDATE -> DRSELECT -> DRCAPTURE ->
		/// DRSHIFT
		/// DRPAUSE DREXIT2 ->
		/// DRSHIFT
		/// DRPAUSE* DREXIT2 -> DRUPDATE -> DRSELECT -> DRCAPTURE -> DRSHIFT
		/// Note: * With -force_update option set.
		/// After the last data bit is shifted into the target data register, the scan_dr_hw_jtag command
		/// moves the JTAG TAP to the IDLE state, or to the stable state defined by the
		/// run_state_hw_jtag command.
		/// The scan_dr_hw_jtag command returns a hex array containing captured TDO data from the
		/// hw_jtag, or returns an error if it fails.
		/// The command raises an error that can be trapped by the Tcl catch command if TDO data from
		/// the hw_jtag does not match specified -tdo argument.
		/// TIP: If -tdo and -mask arguments are specified, then the mask is applied to the -tdo option and the
		/// hw_jtag TDO data returned before comparing the two.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1580
		/// </summary>
		/// <param name="length">(Required) Number of bits to be scanned.</param>
		/// <param name="tdi">(Optional) Hex value to be scanned into the target</param>
		/// <param name="tdo">(Optional) Hex value to be compared against the scanned value</param>
		/// <param name="mask">(Optional) Hex value mask applied when comparing TDO values</param>
		/// <param name="smask">(Optional) Hex value mask applied to TDI value</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>hardware TDO</returns>
		public TTCL scan_dr_hw_jtag(Int32 length, String tdi = null, String tdo = null, String mask = null, String smask = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: scan_dr_hw_jtag [-tdi <arg>] [-tdo <arg>] [-mask <arg>] [-smask <arg>] [-quiet] [-verbose] <length>
			_tcl.Entry(_builder.scan_dr_hw_jtag(length, tdi, tdo, mask, smask, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Perform shift IR on 'hw_jtag'.
		///
		///
		/// TCL Syntax: scan_ir_hw_jtag [-tdi <arg>] [-tdo <arg>] [-mask <arg>] [-smask <arg>] [-quiet] [-verbose] <length>
		///
		/// The scan_ir_hw_jtag command specifies a scan pattern to be scanned into the JTAG
		/// interface target instruction register.
		/// The command targets a hw_jtag object which is created when the hw_target is opened in JTAG
		/// mode through the use of the open_hw_target -jtag_mode command.
		/// When targeting the hw_jtag object prior to shifting the scan pattern specified in the
		/// scan_ir_hw_jtag command, the last defined header property (HIR) will be pre-pended to the
		/// beginning of the specified data pattern, and the last defined trailer property (TIR) will be
		/// appended to the end of the data pattern.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The options can be specified in any order, but can only be specified once. The number of bits
		/// represented by the hex strings specified for -tdi, -tdo, -mask, or -smask cannot be greater
		/// than the maximum specified by <length>. Leading zeros are assumed for a hex string if the
		/// number of bits represented by the hex strings specified is less than the <length>.
		/// When shifting the bits into the target instruction register, the scan_ir_hw_jtag command
		/// moves the JTAG TAP from the current stable state to the IRSHIFT state according to the state
		/// transition table below:
		/// Current Transitions to get to
		/// State IRSHIFT state
		/// RESET IDLE > DRSELECT > IRSELECT > IRCAPTURE > IRSHIFT
		/// IDLE IRSELECT > IRCAPTURE > IRSHIFT
		/// DRPAUSE DREXIT2 > DRUPDATE > DRSELECT > IRSELECT > IRCAPTURE > IRSHIFT
		/// IRPAUSE IREXIT2 > IRSHIFT
		/// IRPAUSE* IREXIT2 > IRUPDATE > DRSELECT > IRSELECT > IRCAPTURE > IRSHIFT
		/// Note: * With -force_update option set.
		/// After the last data bit is shifted into the target data register, the scan_ir_hw_jtag command
		/// moves the JTAG TAP to the IDLE state, or to the stable state defined by the run_state_hw_jtag
		/// command.
		/// The scan_ir_hw_jtag command returns a hex array containing captured TDO data from the
		/// hw_jtag, or returns an error if it fails.
		/// The command raises an error that can be trapped by the Tcl catch command if TDO data from
		/// the hw_jtag does not match specified -tdo argument.
		/// TIP: If -tdo and -mask arguments are specified, then the mask is applied to the -tdo option and the
		/// hw_jtag TDO data returned before comparing the two.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1584
		/// </summary>
		/// <param name="length">(Required) Number of bits to be scanned.</param>
		/// <param name="tdi">(Optional) Hex value to be scanned into the target</param>
		/// <param name="tdo">(Optional) Hex value to be compared against the scanned value</param>
		/// <param name="mask">(Optional) Hex value mask applied when comparing TDO values</param>
		/// <param name="smask">(Optional) Hex value mask applied to TDI value</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>hardware TDO</returns>
		public TTCL scan_ir_hw_jtag(Int32 length, String tdi = null, String tdo = null, String mask = null, String smask = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: scan_ir_hw_jtag [-tdi <arg>] [-tdo <arg>] [-mask <arg>] [-smask <arg>] [-quiet] [-verbose] <length>
			_tcl.Entry(_builder.scan_ir_hw_jtag(length, tdi, tdo, mask, smask, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Set the system monitor register value
		///
		///
		/// TCL Syntax: set_hw_sysmon_reg [-quiet] [-verbose] <hw_sysmon> <hexaddress> <hexdata>
		///
		/// Set the system monitor register at the specified address to the hex value specified. This
		/// command identifies a register on the hw_sysmon on the current device through its hex address
		/// value, and sets the specified hex data value into that register.
		/// IMPORTANT! Some of the registers on the system monitor are read-only and cannot be set directly. This
		/// command has no effect if you try to set the value of a read-only register on the system monitor.
		/// The System Monitor (SYSMON) Analog-to-Digital Converter (ADC) is used to measure die
		/// temperature and voltage on the hw_device. The Sysmon monitors the physical environment via
		/// on-chip temperature and supply sensors. The ADC can access up to 17 external analog input
		/// channels.
		/// Data for the system monitor is stored in dedicated registers, called status and control registers,
		/// accessible through the get_hw_sysmon_reg and set_hw_sysmon_reg commands. Refer to
		/// the Register Interface in UltraScale Architecture System Monitor User Guide (UG580), or 7 Series
		/// FPGAs and Zynq-7000 SoC XADC Dual 12-Bit 1 MSPS Analog-to-Digital Converter User Guide
		/// (UG480) for more information on the addresses of specific system monitor registers.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Although the set_hw_sysmon_reg command lets you directly write the specified hex data
		/// value into the registers of a system monitor, the recommended procedure is to update the values
		/// of properties on the hw_sysmon object using the set_property command, and then write the
		/// property values to the hw_sysmon object using the commit_hw_sysmon command.
		/// The set_hw_sysmon_reg command writes the specified hex value to the hw_sysmon_reg
		/// object on the hw_sysmon object at the specified address but returns nothing, or returns an error
		/// if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1623
		/// </summary>
		/// <param name="hw_sysmon">(Required) hw_sysmon object</param>
		/// <param name="hexaddress">(Required) Hex address to write to</param>
		/// <param name="hexdata">(Required) Hex write value</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL set_hw_sysmon_reg(String hw_sysmon, String hexaddress, String hexdata, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: set_hw_sysmon_reg [-quiet] [-verbose] <hw_sysmon> <hexaddress> <hexdata>
			_tcl.Entry(_builder.set_hw_sysmon_reg(hw_sysmon, hexaddress, hexdata, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Disable Activity Monitor runs for the specified hardware HBM(s)
		///
		///
		/// TCL Syntax: stop_hw_hbm_amon [-quiet] [-verbose] <hw_objects>
		///
		/// The stop_hw_hbm_amon command stops a running HBM activity monitor in the Vivado
		/// hardware manager that has been previously started using the run_hw_hbm_amon command.
		/// This command returns nothing when successful, or returns an error when it fails.
		///
		/// The following example stops the HBM activity monitor for the associated HBM core:
		/// stop_hw_hbm_amon [get_hw_hbms *HBM_2]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1723
		/// </summary>
		/// <param name="hw_objects">(Required) hardware objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL stop_hw_hbm_amon(String hw_objects, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: stop_hw_hbm_amon [-quiet] [-verbose] <hw_objects>
			_tcl.Entry(_builder.stop_hw_hbm_amon(hw_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Stop hardware SIO scans.
		///
		///
		/// TCL Syntax: stop_hw_sio_scan [-quiet] [-verbose] <hw_sio_scans>
		///
		/// Stop the specified scan running in the Vivado serial I/O analyzer.
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the
		/// specialized Eye Scan hardware of Xilinx UltraScale devices or 7 series FPGAs. The Vivado serial
		/// I/O analyzer feature lets you to create, run, and save link scans.
		/// This command lets you stop a scan that is in progress as started with the run_hw_sio_scan
		/// command.
		/// You can remove the created scan object using remove_hw_sio_scan.
		/// This command returns a message if successful, or returns an error if the command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1725
		/// </summary>
		/// <param name="hw_sio_scans">(Required) hardware SIO scans</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL stop_hw_sio_scan(String hw_sio_scans, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: stop_hw_sio_scan [-quiet] [-verbose] <hw_sio_scans>
			_tcl.Entry(_builder.stop_hw_sio_scan(hw_sio_scans, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Stop hardware SIO sweeps.
		///
		///
		/// TCL Syntax: stop_hw_sio_sweep [-quiet] [-verbose] <hw_sio_sweeps>
		///
		/// Stop the specified sweep scan.
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the
		/// specialized features of Xilinx UltraScale devices or 7 series FPGAs. It can also be helpful to run
		/// multiple scans on a the link with different configuration settings for the GTs. This can help you
		/// determine which settings are best for your design. The Vivado serial I/O analyzer feature enables
		/// you to define, run, and save link sweeps, or collections of link scans run across a range of values.
		/// This command lets you stop a sweep scan that is in progress as started with the
		/// run_hw_sio_sweep command.
		/// You can remove the created sweep scan object using remove_hw_sio_sweep.
		/// This command returns nothing if successful, or returns an error if the command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1727
		/// </summary>
		/// <param name="hw_sio_sweeps">(Required) hardware SIO sweeps</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL stop_hw_sio_sweep(String hw_sio_sweeps, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: stop_hw_sio_sweep [-quiet] [-verbose] <hw_sio_sweeps>
			_tcl.Entry(_builder.stop_hw_sio_sweep(hw_sio_sweeps, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Update the SmartLynq firmware image
		///
		///
		/// TCL Syntax: update_hw_firmware [-file_path <arg>] [-config_path <arg>] [-skip_update] [-reset] [-format] [-flash] [-quiet] [-verbose] [<hw_server>]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1770
		/// </summary>
		/// <param name="file_path">(Optional) Optional path to BOOT.BIN file Default: Use default BOOT.BIN</param>
		/// <param name="config_path">(Optional) Optional path to config.ini file Default: No config.ini updated</param>
		/// <param name="skip_update">(Optional) Skip writing the BOOT.BIN to the SmartLynq</param>
		/// <param name="reset">
		/// (Optional)
		/// Reset the SmartLynq cable after any other operations to
		/// complete the update and disconnects the hw_server
		/// </param>
		/// <param name="format">
		/// (Optional)
		/// Format the SmartLynq cable EMMC prior to any other
		/// operations. Any files on SmartLynq cable will be lost.
		/// </param>
		/// <param name="flash">
		/// (Optional)
		/// Flash the SmartLynq cable QSPI. This updates the primary
		/// FSBL and Safe Mode images.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_server">(Optional) hardware server Default: current hardware server</param>
		public TTCL update_hw_firmware(String file_path = null, String config_path = null, bool? skip_update = null, bool? reset = null, bool? format = null, bool? flash = null, bool? quiet = null, bool? verbose = null, String hw_server = null)
		{
			// TCL Syntax: update_hw_firmware [-file_path <arg>] [-config_path <arg>] [-skip_update] [-reset] [-format] [-flash] [-quiet] [-verbose] [<hw_server>]
			_tcl.Entry(_builder.update_hw_firmware(file_path, config_path, skip_update, reset, format, flash, quiet, verbose, hw_server));
			return _tcl;
		}
		/// <summary>
		/// Update the SmartLynq GPIO PMOD pin values
		///
		///
		/// TCL Syntax: update_hw_gpio [-quiet] [-verbose] [<output_enable_mask>] [<output_pin_values>] [<hw_server>]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1771
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="output_enable_mask">
		/// (Optional)
		/// 8 bit hex mask to enable output pins on GPIO Default: All
		/// output pins disabled
		/// </param>
		/// <param name="output_pin_values">(Optional) 8 bit hex value of output pins Default: All output pins driven low</param>
		/// <param name="hw_server">(Optional) hardware server Default: current hardware server</param>
		/// <returns>All GPIO PMOD pin values</returns>
		public TTCL update_hw_gpio(bool? quiet = null, bool? verbose = null, String output_enable_mask = null, String output_pin_values = null, String hw_server = null)
		{
			// TCL Syntax: update_hw_gpio [-quiet] [-verbose] [<output_enable_mask>] [<output_pin_values>] [<hw_server>]
			_tcl.Entry(_builder.update_hw_gpio(quiet, verbose, output_enable_mask, output_pin_values, hw_server));
			return _tcl;
		}
		/// <summary>
		/// Stop capturing. Upload any captured hardware ILA data.
		///
		///
		/// TCL Syntax: upload_hw_ila_data [-quiet] [-verbose] [<hw_ilas>...]
		///
		/// Upload the captured data from the memory buffers of the specified ILA debug cores on the Xilinx
		/// FPGA hardware device, and move it into a hw_ila_data object in the Vivado logic analyzer.
		/// You can upload captured data from the ILA debug core at any time during the capture process
		/// triggered by the run_hw_ila command. However, you may want to use the wait_on_hw_ila
		/// command in any Tcl scripts, to wait until the sample data buffers of the ILA core are fully
		/// populated with data. If you run the upload_hw_ila_data command prior to this, you may see
		/// a message as follows:
		/// INFO: [Labtools 27-1965] The ILA core 'hw_ila_1' trigger was stopped by
		/// user \
		/// at 2014-Mar-06 08:59:30
		/// INFO: [Labtools 27-2212] The ILA core 'hw_ila_1' captured '6' windows with
		/// \
		/// '64' samples each, and a last partial window with '0' samples.
		/// The upload process creates a hw_ila_data object in the process of moving the captured data from
		/// the ILA debug core, hw_ila, on the physical FPGA device, hw_device. The hw_ila_data object is
		/// named after the hw_ila core it is uploaded from.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// TIP: Each hw_ila object has only one matching hw_ila_data object associated with it. Each time
		/// upload_hw_ila_data is run for a specific hw_ila core, the hw_ila_data object is overwritten if it already
		/// exists.
		/// The data object, hw_ila_data can be viewed in the waveform viewer of the Vivado logic analyzer
		/// by using the display_hw_ila_data command, and can be written to disk using the
		/// write_hw_ila_data command.
		/// This command returns a hw_ila_data object, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1791
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_ilas">(Optional) List of hardware ILA objects. Default: Current hardware ILA</param>
		/// <returns>hardware ILA data objects</returns>
		public TTCL upload_hw_ila_data(bool? quiet = null, bool? verbose = null, TCLParameterList hw_ilas = null)
		{
			// TCL Syntax: upload_hw_ila_data [-quiet] [-verbose] [<hw_ilas>...]
			_tcl.Entry(_builder.upload_hw_ila_data(quiet, verbose, hw_ilas));
			return _tcl;
		}
		/// <summary>
		/// Verify hardware devices
		///
		///
		/// TCL Syntax: verify_hw_devices [-key <arg>] [-user_efuse <arg>] [-control_efuse <arg>] [-security_efuse <arg>] [-verbose] [-quiet] [<hw_device>...]
		///
		/// For EFUSE encrypted devices, this command compares the bitstream assigned to the
		/// PROGRAM.FILE property on the specified hw_device with the bitstream programmed into the
		/// device with the program_hw_devices command.
		/// Filtered through a required mask file, associated with the hw_device, the verify_hw_devices
		/// command uses both the bitstream and mask file to compare only the bits that are marked as
		/// important in the mask file. A mask file can be created along with the bitstream using the
		/// write_bitstream command, and is associated with the hw_device using the
		/// create_hw_bitstream command.
		/// IMPORTANT! Verification cannot be performed on devices programmed with encrypted bitstreams, other
		/// than to verify that the -key has been programmed.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// The verify_hw_devices command reports that the readback data matches the programmed
		/// bitstream if successful, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1803
		/// </summary>
		/// <param name="key">(Optional) option value for key verification: efuse</param>
		/// <param name="user_efuse">(Optional) hex user fuse value for verification</param>
		/// <param name="control_efuse">(Optional) hex control fuse value for verification</param>
		/// <param name="security_efuse">(Optional) hex security fuse value for verification</param>
		/// <param name="verbose">(Optional) Shows fuse values during verification</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="hw_device">(Optional) list of hardware devices Default: current hardware device</param>
		/// <returns>hardware devices</returns>
		public TTCL verify_hw_devices(String key = null, String user_efuse = null, String control_efuse = null, String security_efuse = null, bool? verbose = null, bool? quiet = null, TCLParameterList hw_device = null)
		{
			// TCL Syntax: verify_hw_devices [-key <arg>] [-user_efuse <arg>] [-control_efuse <arg>] [-security_efuse <arg>] [-verbose] [-quiet] [<hw_device>...]
			_tcl.Entry(_builder.verify_hw_devices(key, user_efuse, control_efuse, security_efuse, verbose, quiet, hw_device));
			return _tcl;
		}
		/// <summary>
		/// Wait until all hardware ILA data has been captured.
		///
		///
		/// TCL Syntax: wait_on_hw_ila [-timeout <arg>] [-quiet] [-verbose] [<hw_ilas>...]
		///
		/// Suspend Tcl script or Tcl command processing until the ILA debug core memory is filled by
		/// captured data samples.
		/// This command is used after the run_hw_ila command to pause Tcl processing to wait for the
		/// data buffers to fill up. When the wait_on_hw_ila command returns, the Tcl command or script
		/// processing can continue.
		/// With the ILA debug core memory filed with sample data, when Tcl processing resumes, you can
		/// upload the captured data samples into an ILA debug core data object, or hw_ila_data object. Use
		/// the upload_ila_data command to perform this action.
		/// This command operates silently, returning nothing if successful, or returning an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1808
		/// </summary>
		/// <param name="timeout">(Optional) Timeout in minutes. Decimal value allowed Default: No timeout</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="hw_ilas">(Optional) hardware ILA objects. Default: Current hardware ILA</param>
		public TTCL wait_on_hw_ila(String timeout = null, bool? quiet = null, bool? verbose = null, TCLParameterList hw_ilas = null)
		{
			// TCL Syntax: wait_on_hw_ila [-timeout <arg>] [-quiet] [-verbose] [<hw_ilas>...]
			_tcl.Entry(_builder.wait_on_hw_ila(timeout, quiet, verbose, hw_ilas));
			return _tcl;
		}
		/// <summary>
		/// Wait until hardware SIO scan has completed.
		///
		///
		/// TCL Syntax: wait_on_hw_sio_scan [-timeout <arg>] [-quiet] [-verbose] <hw_sio_scans>...
		///
		/// Suspend a Tcl script or Tcl command processing until the specified serial I/O analyzer scan is
		/// complete.
		/// This command is used after the run_hw_sio_scan command to pause Tcl processing to wait
		/// for the scan to complete. When the wait_on_sio_scan command returns, the Tcl command
		/// or script processing can continue.
		/// This command operates silently, returning nothing if successful, or returning an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1810
		/// </summary>
		/// <param name="hw_sio_scans">(Required) List of hardware SIO scan objects.</param>
		/// <param name="timeout">(Optional) Timeout in minutes. Decimal value allowed Default: No timeout</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL wait_on_hw_sio_scan(TCLParameterList hw_sio_scans, String timeout = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: wait_on_hw_sio_scan [-timeout <arg>] [-quiet] [-verbose] <hw_sio_scans>...
			_tcl.Entry(_builder.wait_on_hw_sio_scan(hw_sio_scans, timeout, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Wait until hardware SIO sweep has completed.
		///
		///
		/// TCL Syntax: wait_on_hw_sio_sweep [-timeout <arg>] [-quiet] [-verbose] <hw_sio_sweeps>...
		///
		/// Suspend a Tcl script or Tcl command processing until the serial I/O analyzer sweep scan is
		/// complete.
		/// This command is used after the run_hw_sio_sweep command to pause Tcl processing to wait
		/// for the sweep scan to complete. When the wait_on_sio_sweep command returns, the Tcl
		/// command or script processing can continue.
		/// This command operates silently, returning nothing if successful, or returning an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1812
		/// </summary>
		/// <param name="hw_sio_sweeps">(Required) List of hardware SIO sweep objects.</param>
		/// <param name="timeout">(Optional) Timeout in minutes. Decimal value allowed Default: No timeout</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL wait_on_hw_sio_sweep(TCLParameterList hw_sio_sweeps, String timeout = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: wait_on_hw_sio_sweep [-timeout <arg>] [-quiet] [-verbose] <hw_sio_sweeps>...
			_tcl.Entry(_builder.wait_on_hw_sio_sweep(hw_sio_sweeps, timeout, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Write hardware ILA data to a file
		///
		///
		/// TCL Syntax: write_hw_ila_data [-force] [-csv_file] [-vcd_file] [-legacy_csv_file] [-quiet] [-verbose] <file> [<hw_ila_data>] [<hw_ila_data>]
		///
		/// Write the ILA debug core sample data, stored in the specified hw_ila_data object, to a binary file
		/// on the disk.
		/// A hw_ila_data object is created when the hw_ila is triggered on the hw_device, or by the
		/// upload_hw_ila_data command when moving the captured data from the physical FPGA
		/// device, hw_device.
		/// The write_hw_ila_data lets you write the data of the hw_ila_data object to a binary file on
		/// the disk for later review. You can read the ILA debug core data back into the Vivado logic
		/// analyzer using the read_hw_ila_data command, which creates a new hw_ila_data object.
		/// This command returns the name of the file written, or returns an error if it fails.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1848
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
		public TTCL write_hw_ila_data(String file, bool? force = null, bool? csv_file = null, bool? vcd_file = null, bool? legacy_csv_file = null, bool? quiet = null, bool? verbose = null, String hw_ila_data = null)
		{
			// TCL Syntax: write_hw_ila_data [-force] [-csv_file] [-vcd_file] [-legacy_csv_file] [-quiet] [-verbose] <file> [<hw_ila_data>] [<hw_ila_data>]
			_tcl.Entry(_builder.write_hw_ila_data(file, force, csv_file, vcd_file, legacy_csv_file, quiet, verbose, hw_ila_data));
			return _tcl;
		}
		/// <summary>
		/// Write scan data to a file.
		///
		///
		/// TCL Syntax: write_hw_sio_scan [-force] [-quiet] [-verbose] <file> <hw_sio_scan>
		///
		/// Write the populated hw_sio_scan object after run_hw_sio_scan completes.
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the
		/// specialized Eye Scan hardware of Xilinx UltraScale devices or 7 series FPGAs. The Vivado serial
		/// I/O analyzer feature lets you to create, run, and save link scans.
		/// This command saves the scan to disk after completing the scan run. The format of the file is a
		/// CSV file of values observed while running the scan.
		/// This command returns the filename of the file output, or returns an error if the command fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1855
		/// </summary>
		/// <param name="file">(Required) hardware SIO_scan file name</param>
		/// <param name="hw_sio_scan">(Required) hardware SIO scan data object</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Name of the output file</returns>
		public TTCL write_hw_sio_scan(String file, String hw_sio_scan, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_hw_sio_scan [-force] [-quiet] [-verbose] <file> <hw_sio_scan>
			_tcl.Entry(_builder.write_hw_sio_scan(file, hw_sio_scan, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Write sweep data to a directory.
		///
		///
		/// TCL Syntax: write_hw_sio_sweep [-force] [-quiet] [-verbose] <directory> <hw_sio_sweep>
		///
		/// Write the populated hw_sio_sweep object after run_hw_sio_sweep completes.
		/// To analyze the margin of a given link, it is often helpful to run a scan of the link using the
		/// specialized features of Xilinx UltraScale devices or 7 series FPGAs. It can also be helpful to run
		/// multiple scans on a the link with different configuration settings for the GTs. This can help you
		/// determine which settings are best for your design. The Vivado serial I/O analyzer feature enables
		/// you to define, run, and save link sweeps, or collections of link scans run across a range of values.
		/// This command saves the specified link sweep object to disk after it has been populated by the
		/// run_hw_sio_sweep command.
		/// This command returns the name of the directory created, or returns an error if the command
		/// fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1857
		/// </summary>
		/// <param name="directory">(Required) hardware SIO_sweep directory path</param>
		/// <param name="hw_sio_sweep">(Required) hardware SIO sweep data object</param>
		/// <param name="force">(Optional) Overwrite existing directory</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>Name of the output directory</returns>
		public TTCL write_hw_sio_sweep(String directory, String hw_sio_sweep, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_hw_sio_sweep [-force] [-quiet] [-verbose] <directory> <hw_sio_sweep>
			_tcl.Entry(_builder.write_hw_sio_sweep(directory, hw_sio_sweep, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Generate SVF file for current_hw_target
		///
		///
		/// TCL Syntax: write_hw_svf [-force] [-quiet] [-verbose] <file_name>
		///
		/// The Vivado hardware manager supports programming of hardware devices through the use of
		/// Serial Vector Format (SVF) files. SVF files are ASCII files that contain both programming
		/// instructions and configuration data. These files are used by ATE machines and embedded
		/// controllers to perform boundary-scan operations. The SVF file captures the JTAG commands
		/// needed to program the bitstream directly into a Xilinx device, or indirectly into a flash memory
		/// device. The SVF file can be written using the write_hw_svf command, or applied to an open
		/// hw_target through the execute_hw_svf command. Refer to the Vivado Design Suite User Guide:
		/// Programming and Debugging (UG908) for more information.
		/// The specific process for creating the hw_svf file is:
		/// 1. Create an SVF target using create_hw_target.
		/// 2. Open the SVF target.
		/// 3. Create one or more devices on the SVF target using create_hw_device.
		/// 4. Program the devices using commands like program_hw_devices.
		/// 5. Write the SVF file of operation commands using write_hw_svf.
		/// In programming the hw_devices in Step 4 above, the SVF commands for the operations are
		/// cached to a temporary file. The write_hw_svf command saves the cache by giving it a file
		/// name and moving it to the specified file path.
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// Note: Because this command is essentially flushing the cached SVF commands, after you use the
		/// write_hw_svf command, the cache is cleared, and restarted to capture any new device commands.
		/// This command returns a message indicating success, or returns an error if it fails.
		///
		/// The following example writes an SVF file to specified location:
		/// program_hw_devices [lindex [get_hw_devices] 0]
		/// write_hw_svf C:/Data/k7_design.svf
		/// This example demonstrates the correct order of creating multiple devices on an SVF target. An
		/// SVF target is created and opened, then a Xilinx device, a user part, and a second Xilinx device are
		/// created on the current target. The bitstream properties are defined for the two Xilinx devices, the
		/// devices are programmed, and an SVF file is written:
		/// open_hw
		/// connect_hw_server
		/// create_hw_target my_svf_target
		/// open_hw_target
		/// create_hw_device -part xc7k325t
		/// create_hw_device -idcode 01234567 -irlength 8 -mask ffffffff -part
		/// userPart1
		/// create_hw_device -part xcku9p
		/// set_property PROGRAM.FILE {C:/Data/k7_design.bit} [lindex [get_hw_devices]
		/// 0]
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com
		/// set_property PROGRAM.FILE {C:/Data/ku_design.bit} [lindex [get_hw_devices]
		/// 2]
		/// program_hw_devices [lindex [get_hw_devices] 0]
		/// program_hw_devices [lindex [get_hw_devices] 2]
		/// write_hw_svf C:/Data/myDesign.svf
		/// The following example demonstrates creating a device on an SVF target, creating a configuration
		/// memory object (hw_cfgmem) associated with that device, programming the device and
		/// configuration memory, and saving that command sequence to an SVF file:
		/// create_hw_target my_svf_target
		/// open_hw_target
		/// set device [create_hw_device -part xc7k325t]
		/// set_property PROGRAM.FILE {C:/Data/k7_design.bit} $device
		/// create_hw_cfgmem -hw_device $device -mem_dev [lindex \
		/// [get_cfgmem_parts {28f00am29ew-bpi-x16}] 0]
		/// set cfgMem [current_hw_cfgmem]
		/// set_property PROGRAM.ADDRESS_RANGE {use_file} $cfgMem
		/// set_property PROGRAM.BLANK_CHECK 0 $cfgMem
		/// set_property PROGRAM.BPI_RS_PINS {none} $cfgMem
		/// set_property PROGRAM.CFG_PROGRAM 1 $cfgMem
		/// set_property PROGRAM.CHECKSUM 0 $cfgMem
		/// set_property PROGRAM.ERASE 1 $cfgMem
		/// set_property PROGRAM.UNUSED_PIN_TERMINATION {pull-none} $cfgMem
		/// set_property PROGRAM.VERIFY 1 $cfgMem
		/// set_property PROGRAM.FILES [list {C:/data/flash.mcs} ] $cfgMem
		/// create_hw_bitstream -hw_device $device [get_property \
		/// PROGRAM.HW_CFGMEM_BITFILE $device]
		/// program_hw_devices $device
		/// program_hw_cfgmem -hw_cfgmem $cfgMem
		/// write_hw_svf C:/Data/myDesign.svf
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1859
		/// </summary>
		/// <param name="file_name">(Required) SVF filename</param>
		/// <param name="force">(Optional) overwrite svf file if it exists</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_hw_svf(String file_name, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_hw_svf [-force] [-quiet] [-verbose] <file_name>
			_tcl.Entry(_builder.write_hw_svf(file_name, force, quiet, verbose));
			return _tcl;
		}
	}
}
