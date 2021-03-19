// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class HardwareCommands
	{
		private readonly QuokkaTCL _tcl;
		public HardwareCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Select Pseudo Channel to add to Activity Monitor on the specified hardware HBM(s). Must
		/// specify the Memory Controller number first, follow by Pseudo Channel number.
		/// </summary>
		public void add_hw_hbm_pc()
		{
			var command = new SimpleTCLCommand("add_hw_hbm_pc");
			_tcl.Add(command);
		}
		/// <summary>
		/// Add an enumerated name-value pair to a hw_probe enumeration.
		/// </summary>
		public void add_hw_probe_enum()
		{
			var command = new SimpleTCLCommand("add_hw_probe_enum");
			_tcl.Add(command);
		}
		/// <summary>
		/// Issue JTAG Program command to hw_device
		/// </summary>
		public void boot_hw_device()
		{
			var command = new SimpleTCLCommand("boot_hw_device");
			_tcl.Add(command);
		}
		/// <summary>
		/// Close the hardware tool
		/// </summary>
		public void close_hw_manager()
		{
			var command = new SimpleTCLCommand("close_hw_manager");
			_tcl.Add(command);
		}
		/// <summary>
		/// Close a hardware target
		/// </summary>
		public void close_hw_target()
		{
			var command = new SimpleTCLCommand("close_hw_target");
			_tcl.Add(command);
		}
		/// <summary>
		/// Commit the property changes of the current hardware object. Inputs can be HBM or device
		/// hardware object. At least one object is required.
		/// </summary>
		public void commit_hw_hbm()
		{
			var command = new SimpleTCLCommand("commit_hw_hbm");
			_tcl.Add(command);
		}
		/// <summary>
		/// Commit the property changes of the current hardware object. Inputs can be any mig, device,
		/// target, or server hardware object. At least one object is required.
		/// </summary>
		public void commit_hw_mig()
		{
			var command = new SimpleTCLCommand("commit_hw_mig");
			_tcl.Add(command);
		}
		/// <summary>
		/// Commit the property changes of the current hardware object. Inputs can be any serial I/O
		/// (except scan and sweep), device, target, or server hardware object. At least one object is required.
		/// </summary>
		public void commit_hw_sio()
		{
			var command = new SimpleTCLCommand("commit_hw_sio");
			_tcl.Add(command);
		}
		/// <summary>
		/// Commit the property changes of the current hardware object. Inputs can be hw_server,
		/// hw_target, hw_device or hw_sysmon objects. At least one object is required.
		/// </summary>
		public void commit_hw_sysmon()
		{
			var command = new SimpleTCLCommand("commit_hw_sysmon");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write hardware VIO probe OUTPUT_VALUE properties values to VIO core(s).
		/// </summary>
		public void commit_hw_vio()
		{
			var command = new SimpleTCLCommand("commit_hw_vio");
			_tcl.Add(command);
		}
		/// <summary>
		/// Configure the device GTs for the specified device.
		/// </summary>
		public void config_hw_sio_gts()
		{
			var command = new SimpleTCLCommand("config_hw_sio_gts");
			_tcl.Add(command);
		}
		/// <summary>
		/// Open a connection to a hardware server
		/// </summary>
		public void connect_hw_server()
		{
			var command = new SimpleTCLCommand("connect_hw_server");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create hardware AXI transaction object
		/// </summary>
		public void create_hw_axi_txn()
		{
			var command = new SimpleTCLCommand("create_hw_axi_txn");
			_tcl.Add(command);
		}
		/// <summary>
		/// Read bitstream file into memory
		/// </summary>
		public void create_hw_bitstream()
		{
			var command = new SimpleTCLCommand("create_hw_bitstream");
			_tcl.Add(command);
		}
		/// <summary>
		/// Read cfgmem file into memory
		/// </summary>
		public void create_hw_cfgmem()
		{
			var command = new SimpleTCLCommand("create_hw_cfgmem");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a hw_device (jtag chain) on an open target
		/// </summary>
		public void create_hw_device()
		{
			var command = new SimpleTCLCommand("create_hw_device");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create hardware probe object
		/// </summary>
		public void create_hw_probe()
		{
			var command = new SimpleTCLCommand("create_hw_probe");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new link between hardware RX and TX endpoints. There must be at least one hardware
		/// TX or RX endpoint specified. If one is missing, the endpoint will be treated as Unknown. The
		/// unknown endpoint can be renamed in a link property.
		/// </summary>
		public void create_hw_sio_link()
		{
			var command = new SimpleTCLCommand("create_hw_sio_link");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new hardware SIO link group.
		/// </summary>
		public void create_hw_sio_linkgroup()
		{
			var command = new SimpleTCLCommand("create_hw_sio_linkgroup");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new hardware SIO scan. If a Link object is passed in, it must have a RX Endpoint object.
		/// </summary>
		public void create_hw_sio_scan()
		{
			var command = new SimpleTCLCommand("create_hw_sio_scan");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a new hardware SIO sweep. If a Link object is passed in, it must have a RX Endpoint
		/// object.
		/// </summary>
		public void create_hw_sio_sweep()
		{
			var command = new SimpleTCLCommand("create_hw_sio_sweep");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create a hw_target (jtag chain) and set its name
		/// </summary>
		public void create_hw_target()
		{
			var command = new SimpleTCLCommand("create_hw_target");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get or set the current hardware cfgmem
		/// </summary>
		public void current_hw_cfgmem()
		{
			var command = new SimpleTCLCommand("current_hw_cfgmem");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get or set the current hardware device
		/// </summary>
		public void current_hw_device()
		{
			var command = new SimpleTCLCommand("current_hw_device");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get or set the current hardware ILA
		/// </summary>
		public void current_hw_ila()
		{
			var command = new SimpleTCLCommand("current_hw_ila");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get or set the current hardware ILA data
		/// </summary>
		public void current_hw_ila_data()
		{
			var command = new SimpleTCLCommand("current_hw_ila_data");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get or set the current hardware server
		/// </summary>
		public void current_hw_server()
		{
			var command = new SimpleTCLCommand("current_hw_server");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get or set the current hardware target
		/// </summary>
		public void current_hw_target()
		{
			var command = new SimpleTCLCommand("current_hw_target");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete hardware AXI Transaction objects
		/// </summary>
		public void delete_hw_axi_txn()
		{
			var command = new SimpleTCLCommand("delete_hw_axi_txn");
			_tcl.Add(command);
		}
		/// <summary>
		/// Removes the HW Bitstream object from a list of hardware devices.
		/// </summary>
		public void delete_hw_bitstream()
		{
			var command = new SimpleTCLCommand("delete_hw_bitstream");
			_tcl.Add(command);
		}
		/// <summary>
		/// Removes hw_cfgmem object from memory
		/// </summary>
		public void delete_hw_cfgmem()
		{
			var command = new SimpleTCLCommand("delete_hw_cfgmem");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete hardware probe objects
		/// </summary>
		public void delete_hw_probe()
		{
			var command = new SimpleTCLCommand("delete_hw_probe");
			_tcl.Add(command);
		}
		/// <summary>
		/// Delete a hw_target
		/// </summary>
		public void delete_hw_target()
		{
			var command = new SimpleTCLCommand("delete_hw_target");
			_tcl.Add(command);
		}
		/// <summary>
		/// Automatically detect links between RX and TX endpoints. Create a new link group to contain the
		/// links.
		/// </summary>
		public void detect_hw_sio_links()
		{
			var command = new SimpleTCLCommand("detect_hw_sio_links");
			_tcl.Add(command);
		}
		/// <summary>
		/// Close a connection to a hardware server
		/// </summary>
		public void disconnect_hw_server()
		{
			var command = new SimpleTCLCommand("disconnect_hw_server");
			_tcl.Add(command);
		}
		/// <summary>
		/// Display hardware ILA data in viewer
		/// </summary>
		public void display_hw_ila_data()
		{
			var command = new SimpleTCLCommand("display_hw_ila_data");
			_tcl.Add(command);
		}
		/// <summary>
		/// Display an existing hardware SIO scan.
		/// </summary>
		public void display_hw_sio_scan()
		{
			var command = new SimpleTCLCommand("display_hw_sio_scan");
			_tcl.Add(command);
		}
		/// <summary>
		/// Execute SVF file on current_hw_target
		/// </summary>
		public void execute_hw_svf()
		{
			var command = new SimpleTCLCommand("execute_hw_svf");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of cfgmem_parts available in the software
		/// </summary>
		public void get_cfgmem_parts()
		{
			var command = new SimpleTCLCommand("get_cfgmem_parts");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of hardware AXI transactions.
		/// </summary>
		public void get_hw_axi_txns()
		{
			var command = new SimpleTCLCommand("get_hw_axi_txns");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of hardware AXI objects.
		/// </summary>
		public void get_hw_axis()
		{
			var command = new SimpleTCLCommand("get_hw_axis");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of hardware cfgmems.
		/// </summary>
		public void get_hw_cfgmems()
		{
			var command = new SimpleTCLCommand("get_hw_cfgmems");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of Versal integrated and soft DDRMC cores.
		/// </summary>
		public void get_hw_ddrmcs()
		{
			var command = new SimpleTCLCommand("get_hw_ddrmcs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of hardware devices.
		/// </summary>
		public void get_hw_devices()
		{
			var command = new SimpleTCLCommand("get_hw_devices");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware HBM cores.
		/// </summary>
		public void get_hw_hbms()
		{
			var command = new SimpleTCLCommand("get_hw_hbms");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of hardware ILA data objects.
		/// </summary>
		public void get_hw_ila_datas()
		{
			var command = new SimpleTCLCommand("get_hw_ila_datas");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of hardware ILA.
		/// </summary>
		public void get_hw_ilas()
		{
			var command = new SimpleTCLCommand("get_hw_ilas");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware Migs cores.
		/// </summary>
		public void get_hw_migs()
		{
			var command = new SimpleTCLCommand("get_hw_migs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of hardware probes.
		/// </summary>
		public void get_hw_probes()
		{
			var command = new SimpleTCLCommand("get_hw_probes");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of hardware servers.
		/// </summary>
		public void get_hw_servers()
		{
			var command = new SimpleTCLCommand("get_hw_servers");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO GT commons.
		/// </summary>
		public void get_hw_sio_commons()
		{
			var command = new SimpleTCLCommand("get_hw_sio_commons");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO GT groups.
		/// </summary>
		public void get_hw_sio_gtgroups()
		{
			var command = new SimpleTCLCommand("get_hw_sio_gtgroups");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO GTs.
		/// </summary>
		public void get_hw_sio_gts()
		{
			var command = new SimpleTCLCommand("get_hw_sio_gts");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO IBERT cores.
		/// </summary>
		public void get_hw_sio_iberts()
		{
			var command = new SimpleTCLCommand("get_hw_sio_iberts");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO link groups.
		/// </summary>
		public void get_hw_sio_linkgroups()
		{
			var command = new SimpleTCLCommand("get_hw_sio_linkgroups");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO links.
		/// </summary>
		public void get_hw_sio_links()
		{
			var command = new SimpleTCLCommand("get_hw_sio_links");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO PLLs.
		/// </summary>
		public void get_hw_sio_plls()
		{
			var command = new SimpleTCLCommand("get_hw_sio_plls");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO RXs.
		/// </summary>
		public void get_hw_sio_rxs()
		{
			var command = new SimpleTCLCommand("get_hw_sio_rxs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO scans.
		/// </summary>
		public void get_hw_sio_scans()
		{
			var command = new SimpleTCLCommand("get_hw_sio_scans");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO sweeps.
		/// </summary>
		public void get_hw_sio_sweeps()
		{
			var command = new SimpleTCLCommand("get_hw_sio_sweeps");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SIO TXs.
		/// </summary>
		public void get_hw_sio_txs()
		{
			var command = new SimpleTCLCommand("get_hw_sio_txs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get the system monitor register value
		/// </summary>
		public void get_hw_sysmon_reg()
		{
			var command = new SimpleTCLCommand("get_hw_sysmon_reg");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get list of hardware SysMons.
		/// </summary>
		public void get_hw_sysmons()
		{
			var command = new SimpleTCLCommand("get_hw_sysmons");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of hardware targets.
		/// </summary>
		public void get_hw_targets()
		{
			var command = new SimpleTCLCommand("get_hw_targets");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a list of hardware VIOs.
		/// </summary>
		public void get_hw_vios()
		{
			var command = new SimpleTCLCommand("get_hw_vios");
			_tcl.Add(command);
		}
		/// <summary>
		/// Return probe sample values
		/// </summary>
		public void list_hw_samples()
		{
			var command = new SimpleTCLCommand("list_hw_samples");
			_tcl.Add(command);
		}
		/// <summary>
		/// Open the hardware tool
		/// </summary>
		public void open_hw_manager()
		{
			var command = new SimpleTCLCommand("open_hw_manager");
			_tcl.Add(command);
		}
		/// <summary>
		/// Open a connection to a hardware target on the hardware server
		/// </summary>
		public void open_hw_target()
		{
			var command = new SimpleTCLCommand("open_hw_target");
			_tcl.Add(command);
		}
		/// <summary>
		/// Pause Activity Monitor runs for the specified hardware HBM(s)
		/// </summary>
		public void pause_hw_hbm_amon()
		{
			var command = new SimpleTCLCommand("pause_hw_hbm_amon");
			_tcl.Add(command);
		}
		/// <summary>
		/// Program Cfgmem object
		/// </summary>
		public void program_hw_cfgmem()
		{
			var command = new SimpleTCLCommand("program_hw_cfgmem");
			_tcl.Add(command);
		}
		/// <summary>
		/// Program hardware devices
		/// </summary>
		public void program_hw_devices()
		{
			var command = new SimpleTCLCommand("program_hw_devices");
			_tcl.Add(command);
		}
		/// <summary>
		/// Read hardware ILA data from a file
		/// </summary>
		public void read_hw_ila_data()
		{
			var command = new SimpleTCLCommand("read_hw_ila_data");
			_tcl.Add(command);
		}
		/// <summary>
		/// Read hardware SIO scan data from a file. A hardware SIO scan object will be created if not
		/// provided.
		/// </summary>
		public void read_hw_sio_scan()
		{
			var command = new SimpleTCLCommand("read_hw_sio_scan");
			_tcl.Add(command);
		}
		/// <summary>
		/// Read hardware SIO sweep data from a directory. A hardware SIO sweep object will be created if
		/// not provided.
		/// </summary>
		public void read_hw_sio_sweep()
		{
			var command = new SimpleTCLCommand("read_hw_sio_sweep");
			_tcl.Add(command);
		}
		/// <summary>
		/// Readback data from the hw_cfgmem object
		/// </summary>
		public void readback_hw_cfgmem()
		{
			var command = new SimpleTCLCommand("readback_hw_cfgmem");
			_tcl.Add(command);
		}
		/// <summary>
		/// Readback hardware devices
		/// </summary>
		public void readback_hw_device()
		{
			var command = new SimpleTCLCommand("readback_hw_device");
			_tcl.Add(command);
		}
		/// <summary>
		/// Refresh hardware AXI object status.
		/// </summary>
		public void refresh_hw_axi()
		{
			var command = new SimpleTCLCommand("refresh_hw_axi");
			_tcl.Add(command);
		}
		/// <summary>
		/// Refresh the status of the current hardware object. Inputs need to be any DDRMC object. At least
		/// one object is required. If properties are specified, but do not exist in the object, those properties
		/// will not be refreshed.
		/// </summary>
		public void refresh_hw_ddrmc()
		{
			var command = new SimpleTCLCommand("refresh_hw_ddrmc");
			_tcl.Add(command);
		}
		/// <summary>
		/// Refresh a hardware device. Read device and core information from device.
		/// </summary>
		public void refresh_hw_device()
		{
			var command = new SimpleTCLCommand("refresh_hw_device");
			_tcl.Add(command);
		}
		/// <summary>
		/// Refresh the status of the current hardware object. Inputs can be HBM or device hardware object.
		/// At least one object is required. If properties are specified that do not exist in the object, that
		/// property will not be refreshed.
		/// </summary>
		public void refresh_hw_hbm()
		{
			var command = new SimpleTCLCommand("refresh_hw_hbm");
			_tcl.Add(command);
		}
		/// <summary>
		/// Refresh the status of the current hardware object. Inputs can be any mig, device, target, or server
		/// hardware object. At least one object is required. If properties are specified that do not exist in the
		/// object, that property will not be refreshed.
		/// </summary>
		public void refresh_hw_mig()
		{
			var command = new SimpleTCLCommand("refresh_hw_mig");
			_tcl.Add(command);
		}
		/// <summary>
		/// Refresh a connection to a hardware server
		/// </summary>
		public void refresh_hw_server()
		{
			var command = new SimpleTCLCommand("refresh_hw_server");
			_tcl.Add(command);
		}
		/// <summary>
		/// Refresh the status of the specified hardware objects. Inputs can be any serial I/O (except scan
		/// and sweep), device, target, or server hardware object. At least one object is required. If properties
		/// are specified that do not exist in the object, that property will not be refreshed.
		/// </summary>
		public void refresh_hw_sio()
		{
			var command = new SimpleTCLCommand("refresh_hw_sio");
			_tcl.Add(command);
		}
		/// <summary>
		/// Refresh the status of the current hardware object. Inputs can be hw_server, hw_target,
		/// hw_device or hw_sysmon objects. At least one object is required. If properties are specified that
		/// do not exist in the object, that property will not be refreshed.
		/// </summary>
		public void refresh_hw_sysmon()
		{
			var command = new SimpleTCLCommand("refresh_hw_sysmon");
			_tcl.Add(command);
		}
		/// <summary>
		/// Refresh a hardware target
		/// </summary>
		public void refresh_hw_target()
		{
			var command = new SimpleTCLCommand("refresh_hw_target");
			_tcl.Add(command);
		}
		/// <summary>
		/// Update hardware probe INPUT_VALUE and ACTIVITY_VALUE properties with values read from
		/// hardware VIO core(s).
		/// </summary>
		public void refresh_hw_vio()
		{
			var command = new SimpleTCLCommand("refresh_hw_vio");
			_tcl.Add(command);
		}
		/// <summary>
		/// De-select Pseudo Channel from Activity Monitor on the specified hardware HBM(s). Must
		/// specify the Memory Controller number first, follow by Pseudo Channel number.
		/// </summary>
		public void remove_hw_hbm_pc()
		{
			var command = new SimpleTCLCommand("remove_hw_hbm_pc");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove enumerated name-value pairs from a hw_probe enumeration.
		/// </summary>
		public void remove_hw_probe_enum()
		{
			var command = new SimpleTCLCommand("remove_hw_probe_enum");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove an existing hardware SIO link.
		/// </summary>
		public void remove_hw_sio_link()
		{
			var command = new SimpleTCLCommand("remove_hw_sio_link");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove an existing hardware SIO link group.
		/// </summary>
		public void remove_hw_sio_linkgroup()
		{
			var command = new SimpleTCLCommand("remove_hw_sio_linkgroup");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove an existing hardware SIO scan.
		/// </summary>
		public void remove_hw_sio_scan()
		{
			var command = new SimpleTCLCommand("remove_hw_sio_scan");
			_tcl.Add(command);
		}
		/// <summary>
		/// Remove an existing hardware SIO sweep.
		/// </summary>
		public void remove_hw_sio_sweep()
		{
			var command = new SimpleTCLCommand("remove_hw_sio_sweep");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report formatted hardware AXI Transaction data
		/// </summary>
		public void report_hw_axi_txn()
		{
			var command = new SimpleTCLCommand("report_hw_axi_txn");
			_tcl.Add(command);
		}
		/// <summary>
		/// Formatted report on Versal integrated and soft Memory Controllers' (DDRMCs) memory
		/// configurations, calibration status, stages, and window margins data.
		/// </summary>
		public void report_hw_ddrmc()
		{
			var command = new SimpleTCLCommand("report_hw_ddrmc");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report formatted hardware MIG calibration status and margin data
		/// </summary>
		public void report_hw_mig()
		{
			var command = new SimpleTCLCommand("report_hw_mig");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report properties on hardware objects
		/// </summary>
		public void report_hw_targets()
		{
			var command = new SimpleTCLCommand("report_hw_targets");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reset hardware AXI core state.
		/// </summary>
		public void reset_hw_axi()
		{
			var command = new SimpleTCLCommand("reset_hw_axi");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reset hardware ILA control properties to default values.
		/// </summary>
		public void reset_hw_ila()
		{
			var command = new SimpleTCLCommand("reset_hw_ila");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reset hardware VIO ACTIVITY_VALUE properties, for hardware probes associated with specified
		/// hardware VIO objects.
		/// </summary>
		public void reset_hw_vio_activity()
		{
			var command = new SimpleTCLCommand("reset_hw_vio_activity");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reset hardware VIO core outputs to initial values.
		/// </summary>
		public void reset_hw_vio_outputs()
		{
			var command = new SimpleTCLCommand("reset_hw_vio_outputs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Resume Activity Monitor runs after paused for the specified hardware HBM(s)
		/// </summary>
		public void resume_hw_hbm_amon()
		{
			var command = new SimpleTCLCommand("resume_hw_hbm_amon");
			_tcl.Add(command);
		}
		/// <summary>
		/// Run hardware AXI read/write transaction(s)and update transaction status in hw_axi object..
		/// </summary>
		public void run_hw_axi()
		{
			var command = new SimpleTCLCommand("run_hw_axi");
			_tcl.Add(command);
		}
		/// <summary>
		/// Enable Activity Monitor runs for the specified hardware HBM(s)
		/// </summary>
		public void run_hw_hbm_amon()
		{
			var command = new SimpleTCLCommand("run_hw_hbm_amon");
			_tcl.Add(command);
		}
		/// <summary>
		/// Arm hardware ILAs.
		/// </summary>
		public void run_hw_ila()
		{
			var command = new SimpleTCLCommand("run_hw_ila");
			_tcl.Add(command);
		}
		/// <summary>
		/// Run hardware SIO scans.
		/// </summary>
		public void run_hw_sio_scan()
		{
			var command = new SimpleTCLCommand("run_hw_sio_scan");
			_tcl.Add(command);
		}
		/// <summary>
		/// Run hardware SIO sweeps.
		/// </summary>
		public void run_hw_sio_sweep()
		{
			var command = new SimpleTCLCommand("run_hw_sio_sweep");
			_tcl.Add(command);
		}
		/// <summary>
		/// change to a stable state of a specified transition
		/// </summary>
		public void run_state_hw_jtag()
		{
			var command = new SimpleTCLCommand("run_state_hw_jtag");
			_tcl.Add(command);
		}
		/// <summary>
		/// Forces IEEE 1149.1 TAP state machine to a stable state for a specified wait period
		/// </summary>
		public void runtest_hw_jtag()
		{
			var command = new SimpleTCLCommand("runtest_hw_jtag");
			_tcl.Add(command);
		}
		/// <summary>
		/// Perform shift DR on 'hw_jtag'.
		/// </summary>
		public void scan_dr_hw_jtag()
		{
			var command = new SimpleTCLCommand("scan_dr_hw_jtag");
			_tcl.Add(command);
		}
		/// <summary>
		/// Perform shift IR on 'hw_jtag'.
		/// </summary>
		public void scan_ir_hw_jtag()
		{
			var command = new SimpleTCLCommand("scan_ir_hw_jtag");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set the system monitor register value
		/// </summary>
		public void set_hw_sysmon_reg()
		{
			var command = new SimpleTCLCommand("set_hw_sysmon_reg");
			_tcl.Add(command);
		}
		/// <summary>
		/// Disable Activity Monitor runs for the specified hardware HBM(s)
		/// </summary>
		public void stop_hw_hbm_amon()
		{
			var command = new SimpleTCLCommand("stop_hw_hbm_amon");
			_tcl.Add(command);
		}
		/// <summary>
		/// Stop hardware SIO scans.
		/// </summary>
		public void stop_hw_sio_scan()
		{
			var command = new SimpleTCLCommand("stop_hw_sio_scan");
			_tcl.Add(command);
		}
		/// <summary>
		/// Stop hardware SIO sweeps.
		/// </summary>
		public void stop_hw_sio_sweep()
		{
			var command = new SimpleTCLCommand("stop_hw_sio_sweep");
			_tcl.Add(command);
		}
		/// <summary>
		/// Update the SmartLynq firmware image
		/// </summary>
		public void update_hw_firmware()
		{
			var command = new SimpleTCLCommand("update_hw_firmware");
			_tcl.Add(command);
		}
		/// <summary>
		/// Update the SmartLynq GPIO PMOD pin values
		/// </summary>
		public void update_hw_gpio()
		{
			var command = new SimpleTCLCommand("update_hw_gpio");
			_tcl.Add(command);
		}
		/// <summary>
		/// Stop capturing. Upload any captured hardware ILA data.
		/// </summary>
		public void upload_hw_ila_data()
		{
			var command = new SimpleTCLCommand("upload_hw_ila_data");
			_tcl.Add(command);
		}
		/// <summary>
		/// Verify hardware devices
		/// </summary>
		public void verify_hw_devices()
		{
			var command = new SimpleTCLCommand("verify_hw_devices");
			_tcl.Add(command);
		}
		/// <summary>
		/// Wait until all hardware ILA data has been captured.
		/// </summary>
		public void wait_on_hw_ila()
		{
			var command = new SimpleTCLCommand("wait_on_hw_ila");
			_tcl.Add(command);
		}
		/// <summary>
		/// Wait until hardware SIO scan has completed.
		/// </summary>
		public void wait_on_hw_sio_scan()
		{
			var command = new SimpleTCLCommand("wait_on_hw_sio_scan");
			_tcl.Add(command);
		}
		/// <summary>
		/// Wait until hardware SIO sweep has completed.
		/// </summary>
		public void wait_on_hw_sio_sweep()
		{
			var command = new SimpleTCLCommand("wait_on_hw_sio_sweep");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write hardware ILA data to a file
		/// </summary>
		public void write_hw_ila_data()
		{
			var command = new SimpleTCLCommand("write_hw_ila_data");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write scan data to a file.
		/// </summary>
		public void write_hw_sio_scan()
		{
			var command = new SimpleTCLCommand("write_hw_sio_scan");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write sweep data to a directory.
		/// </summary>
		public void write_hw_sio_sweep()
		{
			var command = new SimpleTCLCommand("write_hw_sio_sweep");
			_tcl.Add(command);
		}
		/// <summary>
		/// Generate SVF file for current_hw_target
		/// </summary>
		public void write_hw_svf()
		{
			var command = new SimpleTCLCommand("write_hw_svf");
			_tcl.Add(command);
		}
	}
}
