// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class FileIOCommands
	{
		private readonly QuokkaTCL _tcl;
		public FileIOCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Auto detect the XPM Libraries that are used in the design and set the XPM_LIBRARIES project
		/// property.
		/// </summary>
		public void auto_detect_xpm()
		{
			var command = new SimpleTCLCommand("auto_detect_xpm");
			_tcl.Add(command);
		}
		/// <summary>
		/// Enable/disable WebTalk to send software, IP and device usage statistics to Xilinx. Note: WebTalk
		/// is always enabled for WebPACK users. WebTalk ignores user and install preference when a
		/// bitstream is generated using the WebPACK license. If a design is using a device contained in
		/// WebPACK and a WebPACK license is available, the WebPACK license will be used. To change
		/// this, please see answer record 34746.
		/// </summary>
		public void config_webtalk()
		{
			var command = new SimpleTCLCommand("config_webtalk");
			_tcl.Add(command);
		}
		/// <summary>
		/// Generate a port on a given reconfigurable cell
		/// </summary>
		public void create_port_on_reconfigurable_module()
		{
			var command = new SimpleTCLCommand("create_port_on_reconfigurable_module");
			_tcl.Add(command);
		}
		/// <summary>
		/// Decrypt an AES-GCM encrypted bitstream
		/// </summary>
		public void decrypt_bitstream()
		{
			var command = new SimpleTCLCommand("decrypt_bitstream");
			_tcl.Add(command);
		}
		/// <summary>
		/// Encrypt files in place with a language specific key file in IEEE 1735. no default
		/// </summary>
		public void encrypt()
		{
			var command = new SimpleTCLCommand("encrypt");
			_tcl.Add(command);
		}
		/// <summary>
		/// Generate a base platform based on a given routed checkpoint
		/// </summary>
		public void generate_base_platform()
		{
			var command = new SimpleTCLCommand("generate_base_platform");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write all the simulation .mem files.
		/// </summary>
		public void generate_mem_files()
		{
			var command = new SimpleTCLCommand("generate_mem_files");
			_tcl.Add(command);
		}
		/// <summary>
		/// Generate PBLOCK by exclude static
		/// </summary>
		public void generate_pblock()
		{
			var command = new SimpleTCLCommand("generate_pblock");
			_tcl.Add(command);
		}
		/// <summary>
		/// Generate new platform based on base platform and wrapper module
		/// </summary>
		public void generate_rl_platform()
		{
			var command = new SimpleTCLCommand("generate_rl_platform");
			_tcl.Add(command);
		}
		/// <summary>
		/// Move HD.RECONFIGURABLE and related properties to sub-cells
		/// </summary>
		public void generate_shx_platform()
		{
			var command = new SimpleTCLCommand("generate_shx_platform");
			_tcl.Add(command);
		}
		/// <summary>
		/// Infer differential pairs, typically for ports just imported from a CSV or XDC file
		/// </summary>
		public void infer_diff_pairs()
		{
			var command = new SimpleTCLCommand("infer_diff_pairs");
			_tcl.Add(command);
		}
		/// <summary>
		/// Open the Xilinx Shell Archive
		/// </summary>
		public void open_hw_platform()
		{
			var command = new SimpleTCLCommand("open_hw_platform");
			_tcl.Add(command);
		}
		/// <summary>
		/// Re-establish a parent cell as a Reconfigurable Partition while removing a lower-level
		/// Reconfigurable Partition when using the Hierarchical Partial Reconfiguration solution.
		/// </summary>
		public void pr_recombine()
		{
			var command = new SimpleTCLCommand("pr_recombine");
			_tcl.Add(command);
		}
		/// <summary>
		/// Subdivide a Reconfigurable Partition into one or more lower-level Reconfigurable Partitions when
		/// using the Hierarchical Partial Reconfiguration solution.
		/// </summary>
		public void pr_subdivide()
		{
			var command = new SimpleTCLCommand("pr_subdivide");
			_tcl.Add(command);
		}
		/// <summary>
		/// Verify whether the design check points are replaceable on board. This command supports these
		/// formats: (1) 'pr_verify DCP1 DCP2 -full_check'; (2) 'pr_verify -initial DCP1 -additional {DCP2
		/// DCP3 DCP4 ...}'; (3) 'pr_verify -in_memory -additional {DCP2 DCP3 ...}'; For format (3), it must
		/// have an in-memory design opened.
		/// </summary>
		public void pr_verify()
		{
			var command = new SimpleTCLCommand("pr_verify");
			_tcl.Add(command);
		}
		/// <summary>
		/// Read one or more IPIntegrator design files
		/// </summary>
		public void read_bd()
		{
			var command = new SimpleTCLCommand("read_bd");
			_tcl.Add(command);
		}
		/// <summary>
		/// Read a design checkpoint
		/// </summary>
		public void read_checkpoint()
		{
			var command = new SimpleTCLCommand("read_checkpoint");
			_tcl.Add(command);
		}
		/// <summary>
		/// Import package pin and port placement information
		/// </summary>
		public void read_csv()
		{
			var command = new SimpleTCLCommand("read_csv");
			_tcl.Add(command);
		}
		/// <summary>
		/// Read one or more EDIF or NGC files
		/// </summary>
		public void read_edif()
		{
			var command = new SimpleTCLCommand("read_edif");
			_tcl.Add(command);
		}
		/// <summary>
		/// Read one or more IP files
		/// </summary>
		public void read_ip()
		{
			var command = new SimpleTCLCommand("read_ip");
			_tcl.Add(command);
		}
		/// <summary>
		/// Read one or more data files (.mem .mif .dat).
		/// </summary>
		public void read_mem()
		{
			var command = new SimpleTCLCommand("read_mem");
			_tcl.Add(command);
		}
		/// <summary>
		/// Read QoR Suggestions from the given file
		/// </summary>
		public void read_qor_suggestions()
		{
			var command = new SimpleTCLCommand("read_qor_suggestions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Import simulation data in saif format
		/// </summary>
		public void read_saif()
		{
			var command = new SimpleTCLCommand("read_saif");
			_tcl.Add(command);
		}
		/// <summary>
		/// Import schematic
		/// </summary>
		public void read_schematic()
		{
			var command = new SimpleTCLCommand("read_schematic");
			_tcl.Add(command);
		}
		/// <summary>
		/// Read timing results from Trace STA tool
		/// </summary>
		public void read_twx()
		{
			var command = new SimpleTCLCommand("read_twx");
			_tcl.Add(command);
		}
		/// <summary>
		/// Read one or more Verilog files
		/// </summary>
		public void read_verilog()
		{
			var command = new SimpleTCLCommand("read_verilog");
			_tcl.Add(command);
		}
		/// <summary>
		/// Read one or more VHDL files
		/// </summary>
		public void read_vhdl()
		{
			var command = new SimpleTCLCommand("read_vhdl");
			_tcl.Add(command);
		}
		/// <summary>
		/// read physical and timing constraints from one of more files.
		/// </summary>
		public void read_xdc()
		{
			var command = new SimpleTCLCommand("read_xdc");
			_tcl.Add(command);
		}
		/// <summary>
		/// Update and initialize the BRAM initialization strings with contents of elf files.
		/// </summary>
		public void refresh_meminit()
		{
			var command = new SimpleTCLCommand("refresh_meminit");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write an abstract shell checkpoint of the current design
		/// </summary>
		public void write_abstract_shell()
		{
			var command = new SimpleTCLCommand("write_abstract_shell");
			_tcl.Add(command);
		}
		/// <summary>
		/// Export layout in native, pdf or svg
		/// </summary>
		public void write_bd_layout()
		{
			var command = new SimpleTCLCommand("write_bd_layout");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write a bitstream for the current design
		/// </summary>
		public void write_bitstream()
		{
			var command = new SimpleTCLCommand("write_bitstream");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write a bmm file
		/// </summary>
		public void write_bmm()
		{
			var command = new SimpleTCLCommand("write_bmm");
			_tcl.Add(command);
		}
		/// <summary>
		/// Generate a design specific post-configuration BSDL file (.bsd).
		/// </summary>
		public void write_bsdl()
		{
			var command = new SimpleTCLCommand("write_bsdl");
			_tcl.Add(command);
		}
		/// <summary>
		/// Create file(s) for programming flash memory.
		/// </summary>
		public void write_cfgmem()
		{
			var command = new SimpleTCLCommand("write_cfgmem");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write a checkpoint of the current design
		/// </summary>
		public void write_checkpoint()
		{
			var command = new SimpleTCLCommand("write_checkpoint");
			_tcl.Add(command);
		}
		/// <summary>
		/// Export package pin and port placement information
		/// </summary>
		public void write_csv()
		{
			var command = new SimpleTCLCommand("write_csv");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write debug probes to a file
		/// </summary>
		public void write_debug_probes()
		{
			var command = new SimpleTCLCommand("write_debug_probes");
			_tcl.Add(command);
		}
		/// <summary>
		/// Export the current netlist as an EDIF file
		/// </summary>
		public void write_edif()
		{
			var command = new SimpleTCLCommand("write_edif");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write the Xilinx Shell Archive for the current design
		/// </summary>
		public void write_hw_platform()
		{
			var command = new SimpleTCLCommand("write_hw_platform");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write the unified JSON metadata file for the current design
		/// </summary>
		public void write_hw_platform_metadata()
		{
			var command = new SimpleTCLCommand("write_hw_platform_metadata");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write IBIS models for current floorplan
		/// </summary>
		public void write_ibis()
		{
			var command = new SimpleTCLCommand("write_ibis");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write file with inferred xdc timing constraints
		/// </summary>
		public void write_inferred_xdc()
		{
			var command = new SimpleTCLCommand("write_inferred_xdc");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write the Memory Map Info of the design to a .mmi file.
		/// </summary>
		public void write_mem_info()
		{
			var command = new SimpleTCLCommand("write_mem_info");
			_tcl.Add(command);
		}
		/// <summary>
		/// Write QoR Suggestions to the given file
		/// </summary>
		public void write_qor_suggestions()
		{
			var command = new SimpleTCLCommand("write_qor_suggestions");
			_tcl.Add(command);
		}
		/// <summary>
		/// Export schematic
		/// </summary>
		public void write_schematic()
		{
			var command = new SimpleTCLCommand("write_schematic");
			_tcl.Add(command);
		}
		/// <summary>
		/// write_sdf command generates flat sdf delay files for event simulation
		/// </summary>
		public void write_sdf()
		{
			var command = new SimpleTCLCommand("write_sdf");
			_tcl.Add(command);
		}
		/// <summary>
		/// Export the current netlist in Verilog format
		/// </summary>
		public void write_verilog()
		{
			var command = new SimpleTCLCommand("write_verilog");
			_tcl.Add(command);
		}
		/// <summary>
		/// Export the current netlist in VHDL format
		/// </summary>
		public void write_vhdl()
		{
			var command = new SimpleTCLCommand("write_vhdl");
			_tcl.Add(command);
		}
		/// <summary>
		/// Writes constraints to a Xilinx Design Constraints (XDC) file. The default file extension for a XDC
		/// file is .xdc.
		/// </summary>
		public void write_xdc()
		{
			var command = new SimpleTCLCommand("write_xdc");
			_tcl.Add(command);
		}
	}
}
