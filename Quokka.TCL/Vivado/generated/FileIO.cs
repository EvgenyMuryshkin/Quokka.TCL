// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class FileIOCommands<TTCL> where TTCL : TCLFile
	{
		private readonly TTCL _tcl;
		private readonly VivadoTCLBuilder _builder;
		public FileIOCommands(TTCL tcl, VivadoTCLBuilder builder)
		{
			_tcl = tcl;
			_builder = builder;
		}
		/// <summary>
		/// Auto detect the XPM Libraries that are used in the design and set the XPM_LIBRARIES project
		/// property.
		///
		///
		/// TCL Syntax: auto_detect_xpm [-quiet] [-verbose]
		///
		/// This command collects the list of Xilinx Parameterized Macros (XPM) used in RTL design files and
		/// sets the XPM_LIBRARIES property. Because it identifies XPM used in the RTL source files, it
		/// must be used after the RTL files are read or added to the design as shown in the example.
		/// TIP: This command is intended for use in non-project mode, and is not needed for project-based flows.
		/// This command will find all the XPMs used in the user RTL and update the XPM_LIBRARIES
		/// property on the current project. Synthesis and simulation will use the XPM_LIBRARIES property
		/// to properly support these macros.
		/// This command returns nothing, or returns an error if it fails.
		///
		/// The following example reads the specified RTL file, and then uses auto_detect_xpm to define
		/// the XPM_LIBRARIES used in the files:
		/// read_verilog ../top_bgRAM_173_0.v
		/// read_xdc ../top_bgRAM_173_0.xdc
		/// auto_detect_xpm
		///
		/// See ug835-vivado-tcl-commands.pdf, page 112
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL auto_detect_xpm(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: auto_detect_xpm [-quiet] [-verbose]
			_tcl.Entry(_builder.auto_detect_xpm(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Enable/disable WebTalk to send software, IP and device usage statistics to Xilinx. Note: WebTalk
		/// is always enabled for WebPACK users. WebTalk ignores user and install preference when a
		/// bitstream is generated using the WebPACK license. If a design is using a device contained in
		/// WebPACK and a WebPACK license is available, the WebPACK license will be used. To change
		/// this, please see answer record 34746.
		///
		///
		/// TCL Syntax: config_webtalk [-info] [-user <arg>] [-install <arg>] [-quiet] [-verbose]
		///
		/// WebTalk is a secure design data collection feature of Xilinx software that helps Xilinx understand
		/// how you are using Xilinx devices, software, and Intellectual Property (IP).
		/// This command returns the current state of the WebTalk feature for the current user and software
		/// installation. You can also enable or disable WebTalk to send software, IP and device usage
		/// statistics to Xilinx. No data is sent if you disable WebTalk, except for the use of the WebPACK
		/// license to generate a bitstream.
		/// Participation in WebTalk is voluntary, except for the use of the WebPACK license. WebTalk data
		/// transmission is mandatory, and is always enabled for WebPACK users. WebTalk ignores user and
		/// install preference when a bitstream is generated using the WebPACK license.
		/// Note: If a design is using a device contained in WebPACK and a WebPACK license is available, the
		/// WebPACK license will be used. To change this, please see answer record 34746.
		///
		/// The following example returns the current state of the WebTalk configuration:
		/// config_webtalk -info
		/// INFO: [Coretcl-120] Webtalk has been disabled by the current user.
		/// INFO: [Coretcl-123] Webtalk has been enabled for the current installation.
		/// INFO: [Coretcl-110] This combination of user/install settings means that
		/// WebTalk is currently disabled.
		/// The following example enables WebTalk for the current user:
		/// config_webtalk -user on
		///
		/// See ug835-vivado-tcl-commands.pdf, page 187
		/// </summary>
		/// <param name="info">(Optional) Show whether WebTalk is currently enabled or disabled</param>
		/// <param name="user">
		/// (Optional)
		/// Enable/disable WebTalk for the current user. Specify either
		/// 'on' to enable or 'off' to disable. Default: empty
		/// </param>
		/// <param name="install">
		/// (Optional)
		/// Enable/disable WebTalk for all users of the current
		/// installation. Specify either 'on' to enable or 'off' to disable.
		/// If you specify 'off', individual users will not be able to enable
		/// WebTalk using the -user option. You may need
		/// administrator rights to use this option. Default: empty
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL config_webtalk(bool? info = null, string user = null, string install = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: config_webtalk [-info] [-user <arg>] [-install <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.config_webtalk(info, user, install, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Generate a port on a given reconfigurable cell
		///
		///
		/// TCL Syntax: create_port_on_reconfigurable_module [-cell <arg>] [-port <arg>] [-direction <arg>] [-from <arg>] [-to <arg>] [-quiet] [-verbose]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 329
		/// </summary>
		/// <param name="cell">(Optional) (Required) specify the HD.RECONFIGURABLE cell name for port punching</param>
		/// <param name="port">
		/// (Optional)
		/// (Required) specify the newly added port name on given
		/// HD.RECONFIGURABLE cell
		/// </param>
		/// <param name="direction">
		/// (Optional)
		/// (Required) specify the direction of ports, it could be either
		/// INPUT, OUTPUT or INOUT
		/// </param>
		/// <param name="from">(Optional) (Optional) specify the lower boundary of port bus Default: -1</param>
		/// <param name="to">(Optional) (Optional) specify the higher boundary of port bus Default: -1</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_port_on_reconfigurable_module(string cell = null, string port = null, string direction = null, string from = null, string to = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_port_on_reconfigurable_module [-cell <arg>] [-port <arg>] [-direction <arg>] [-from <arg>] [-to <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_port_on_reconfigurable_module(cell, port, direction, from, to, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Decrypt an AES-GCM encrypted bitstream
		///
		///
		/// TCL Syntax: decrypt_bitstream -encrypted_file <arg> -keyfile <arg> [-force] [-quiet] [-verbose] <file>
		///
		/// During implementation of secure encrypted UltraScale architecture designs, bitstream-level
		/// verification must be performed on the final bitstream against the "golden" bitstream of the Xilinx
		/// tested Security Monitor (SecMon) IP.
		/// The decrypt_bitstream command takes an AES-GCM encrypted bitstream file (.bit
		/// or .rbt) from an implemented design that incorporates the SecMon IP, and an encryption key
		/// file (.nky or .nkz), and returns an unencrypted bitstream file. The decrypted bitstream can then
		/// be used to complete the bitstream verification process.
		/// This command returns the requested file if successful, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 415
		/// </summary>
		/// <param name="encrypted_file">(Required) Input AES-GCM encrypted bitstream (.bit or .rbt)</param>
		/// <param name="keyfile">(Required) File containing encryption keys</param>
		/// <param name="file">(Required) Output decrypted bitstream (.bit, .bin or .rbt)</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL decrypt_bitstream(string encrypted_file, string keyfile, string file, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: decrypt_bitstream -encrypted_file <arg> -keyfile <arg> [-force] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.decrypt_bitstream(encrypted_file, keyfile, file, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Encrypt files in place with a language specific key file in IEEE 1735. no default
		///
		///
		/// TCL Syntax: encrypt [-key <arg>] -lang <arg> [-ext <arg>] [-quiet] [-verbose] <files>...
		///
		/// TIP: The encrypt command is provided with limited access, and requires a special license to use.
		/// Allows anyone with an encryption license to encrypt Verilog or VHDL files using the IEEE 1735
		/// encryption standard.
		/// Encrypted files can be provided by third-party IP providers to protect their intellectual property,
		/// while still enabling the Vivado Design Suite to read the encrypted files for synthesis and
		/// simulation. The data is in plain text prior to encryption.
		/// IMPORTANT! Unless the -ext option is used, the specified files are encrypted in place, overwriting the input
		/// files with the encrypted files.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 493
		/// </summary>
		/// <param name="lang">(Required) HDL language of the input/output file</param>
		/// <param name="files">(Required) Files to be encrypted in place</param>
		/// <param name="key">(Optional) key file to be used to encrypt; if absent, use embedded keys</param>
		/// <param name="ext">
		/// (Optional)
		/// extension to use for encrypted file; the original source files
		/// will be preserved.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL encrypt(string lang, string files, string key = null, string ext = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: encrypt [-key <arg>] -lang <arg> [-ext <arg>] [-quiet] [-verbose] <files>...
			_tcl.Entry(_builder.encrypt(lang, files, key, ext, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Generate a base platform based on a given routed checkpoint
		///
		///
		/// TCL Syntax: generate_base_platform [-source <arg>] [-reconfig_platform <arg>] [-base_platform <arg>] [-reconfig_platform_prefix <arg>] [-quiet] [-verbose]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 528
		/// </summary>
		/// <param name="source">(Optional) (Required) Specify routed checkpoint path</param>
		/// <param name="reconfig_platform">(Optional) (Required) Specify reconfigurable platform module name</param>
		/// <param name="base_platform">
		/// (Optional)
		/// (Optional) Specify the output file name, the default file
		/// name is 'base_platform'
		/// </param>
		/// <param name="reconfig_platform_prefix">
		/// (Optional)
		/// (Optional) Specify wrapper port name prefix from
		/// reconfigurable platform module, the default prefix is 'RL_'
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL generate_base_platform(string source = null, string reconfig_platform = null, string base_platform = null, string reconfig_platform_prefix = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_base_platform [-source <arg>] [-reconfig_platform <arg>] [-base_platform <arg>] [-reconfig_platform_prefix <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.generate_base_platform(source, reconfig_platform, base_platform, reconfig_platform_prefix, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Write all the simulation .mem files.
		///
		///
		/// TCL Syntax: generate_mem_files [-force] [-quiet] [-verbose] <directory>
		///
		/// For embedded processor based designs, with associated Executable Linkable Files (ELF) from the
		/// Software Development Kit (SDK), this command merges the Block Memory Map (BMM) for the
		/// design with the program data in the ELF file to generate memory (MEM) files for use during
		/// simulation.
		/// The MEM file is a text file that describes how individual Block RAMs on the Xilinx device are
		/// grouped together to form a contiguous address space called an Address Block, with the ELF data
		/// mapped into the memory.
		/// The file names and the number of MEM files generated is determined by the memory map data
		/// specified by the processor system IP cores, or IP integrator block designs.
		/// This command returns the directory where the MEM files are written, or returns an error if it
		/// fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 529
		/// </summary>
		/// <param name="directory">
		/// (Required)
		/// Directory for exporting .mem files. Values: A directory with
		/// alphanumeric characters.
		/// </param>
		/// <param name="force">(Optional) Overwrite existing .mem files</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The name of the directory</returns>
		public TTCL generate_mem_files(string directory, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_mem_files [-force] [-quiet] [-verbose] <directory>
			_tcl.Entry(_builder.generate_mem_files(directory, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Generate PBLOCK by exclude static
		///
		///
		/// TCL Syntax: generate_pblock [-cell <arg>] [-inverse_pblock <arg>] [-nested_pblock <arg>] [-nested_width <arg>] [-quiet] [-verbose]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 531
		/// </summary>
		/// <param name="cell">(Optional) Specify cell to add to pblock.</param>
		/// <param name="inverse_pblock">
		/// (Optional)
		/// Specify name of the inverse pblock. The pblock will cover
		/// everything that the static pblock does not.
		/// </param>
		/// <param name="nested_pblock">
		/// (Optional)
		/// Specify name of nested pblock inside inverse_pblock left
		/// adjacent to static pblock.
		/// </param>
		/// <param name="nested_width">
		/// (Optional)
		/// Specify the width of the nested pblock. The nested pblock
		/// height is the same as the adjacent static pblock. Default: 3
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL generate_pblock(string cell = null, string inverse_pblock = null, string nested_pblock = null, string nested_width = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_pblock [-cell <arg>] [-inverse_pblock <arg>] [-nested_pblock <arg>] [-nested_width <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.generate_pblock(cell, inverse_pblock, nested_pblock, nested_width, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Generate new platform based on base platform and wrapper module
		///
		///
		/// TCL Syntax: generate_rl_platform [-use_source <arg>] [-reconfig_platform <arg>] [-base_platform <arg>] [-platform <arg>] [-quiet] [-verbose]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 537
		/// </summary>
		/// <param name="use_source">(Optional) Specify wrapper checkpoint path</param>
		/// <param name="reconfig_platform">(Optional) (Required) Specify reconfigurable platform module name</param>
		/// <param name="base_platform">(Optional) (Required) Specify base platform checkpoint path</param>
		/// <param name="platform">
		/// (Optional)
		/// (Optional) Specify new platform checkpoint path, the default
		/// file name is 'rl_platform.dcp'
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL generate_rl_platform(string use_source = null, string reconfig_platform = null, string base_platform = null, string platform = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_rl_platform [-use_source <arg>] [-reconfig_platform <arg>] [-base_platform <arg>] [-platform <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.generate_rl_platform(use_source, reconfig_platform, base_platform, platform, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Move HD.RECONFIGURABLE and related properties to sub-cells
		///
		///
		/// TCL Syntax: generate_shx_platform [-base_platform <arg>] [-wrapper <arg>] [-output <arg>] [-reconfig_platform <arg>] [-quiet] [-verbose]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 538
		/// </summary>
		/// <param name="base_platform">(Optional) Specify Base Platform DCP path.</param>
		/// <param name="wrapper">(Optional) Specify wrapper DCP path</param>
		/// <param name="output">(Optional) Specify output DCP name.</param>
		/// <param name="reconfig_platform">(Optional) Specify reconfigurable platform name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL generate_shx_platform(string base_platform = null, string wrapper = null, string output = null, string reconfig_platform = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_shx_platform [-base_platform <arg>] [-wrapper <arg>] [-output <arg>] [-reconfig_platform <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.generate_shx_platform(base_platform, wrapper, output, reconfig_platform, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Infer differential pairs, typically for ports just imported from a CSV or XDC file
		///
		///
		/// TCL Syntax: infer_diff_pairs [-file_type <arg>] [-quiet] [-verbose] [<file>...]
		///
		/// The infer_diff_pairs command can be used in an I/O Pin Planning project, after importing
		/// the I/O pin information using the read_csv or read_xdc command.
		/// There are several attributes that identify differential pairs in the file: Signal Name, DiffPair Signal,
		/// DiffPair Type, and I/O Standard.
		/// The tool will identify differential pairs using the following methods:
		/// • Matching Diff Pair - This is a direct definition of the two signals which make up a differential
		/// pair. Two port entries, each have DiffPair Signal values linking to the Signal Name of the other,
		/// and have complementary DiffPair Type values, one N and one P. The tool checks to ensure
		/// that the other attributes such as I/O Standard are compatible when forming the diff pair.
		/// • Unmatched Diff Pair - Two port entries, with complementary DiffPair Type values (one N, one
		/// P), but only one port has a DiffPair Signal linking to the other Signal Name. The tool will create
		/// the differential pair if all other attributes are compatible.
		/// • Single Port Diff Pair - A single port entry with a differential I/O Standard, a DiffPair Type value,
		/// and a DiffPair Signal that does not otherwise appear in the CSV. The tool will create the
		/// opposite side of the differential pair (the N or P side), with all properties matching those on
		/// the original port.
		/// • Inferred Diff Pair - Two ports entries, with Signal Names that imply the N and P side. The tool
		/// will infer a differential pair if all other attributes are compatible.
		/// After reading the port definitions from a CSV or XDC file, the tool will report that some
		/// differential pairs can be inferred from the data. You can run the infer_diff_pairs command
		/// to infer these differential pairs if you choose.
		///
		/// The following example imports the specified XDC file, and then infers differential pairs from the
		/// file:
		/// read_xdc C:/Vivado_Install/io_1.xdc
		/// infer_diff_pairs C:/Vivado_Install/io_1.xdc -file_type xdc
		///
		/// See ug835-vivado-tcl-commands.pdf, page 975
		/// </summary>
		/// <param name="file_type">(Optional) Input file type: 'csv' or 'xdc' Default: file type</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="file">(Optional) Pin Planning CSV or XDC file Default: file</param>
		public TTCL infer_diff_pairs(string file_type = null, bool? quiet = null, bool? verbose = null, string file = null)
		{
			// TCL Syntax: infer_diff_pairs [-file_type <arg>] [-quiet] [-verbose] [<file>...]
			_tcl.Entry(_builder.infer_diff_pairs(file_type, quiet, verbose, file));
			return _tcl;
		}
		/// <summary>
		/// Open the Xilinx Shell Archive
		///
		///
		/// TCL Syntax: open_hw_platform [-auto_upgrade] [-quiet] [-verbose] [<file>]
		///
		/// Open a Xilinx support archive (XSA) file and extract the Vivado project, block design, and IP from
		/// the archive. This will create a project directory and project file (.xpr) from the XSA.
		/// Note: The project will be created in the current working directory, or the directory from which the Vivado
		/// tool was launched.
		/// This command returns a transcript of its actions, or returns an error if it fails.
		///
		/// The following example opens the specified XSA, automatically upgrading the IP as needed:
		/// open_hw_platform -auto_upgrade C:/Data/zc706.xsa
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1059
		/// </summary>
		/// <param name="file">
		/// (Required)
		/// Xilinx Shell Archive file Values: A filename with alphanumeric
		/// characters and .dsa/.xsa extension.
		/// </param>
		/// <param name="auto_upgrade">(Optional) Automatically upgrade the BD</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The name of the shell file</returns>
		public TTCL open_hw_platform(string file, bool? auto_upgrade = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: open_hw_platform [-auto_upgrade] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.open_hw_platform(file, auto_upgrade, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Re-establish a parent cell as a Reconfigurable Partition while removing a lower-level
		/// Reconfigurable Partition when using the Hierarchical Partial Reconfiguration solution.
		///
		///
		/// TCL Syntax: pr_recombine [-cell <arg>] [-quiet] [-verbose]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1115
		/// </summary>
		/// <param name="cell">(Optional) (Required) Specify reconfigurable container module name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL pr_recombine(string cell = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: pr_recombine [-cell <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.pr_recombine(cell, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Subdivide a Reconfigurable Partition into one or more lower-level Reconfigurable Partitions when
		/// using the Hierarchical Partial Reconfiguration solution.
		///
		///
		/// TCL Syntax: pr_subdivide [-cell <arg>] [-subcells <arg>] [-quiet] [-verbose] [<from_dcp>]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1116
		/// </summary>
		/// <param name="cell">(Optional) (Required) Specify parent reconfigurable partition module name</param>
		/// <param name="subcells">(Optional) (Required) Specify child reconfigurable partition module names</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="from_dcp">
		/// (Optional)
		/// (Required) Specify OOC synthesized checkpoint path for the
		/// reconfigurable module specified by option -cell
		/// </param>
		public TTCL pr_subdivide(string cell = null, string subcells = null, bool? quiet = null, bool? verbose = null, string from_dcp = null)
		{
			// TCL Syntax: pr_subdivide [-cell <arg>] [-subcells <arg>] [-quiet] [-verbose] [<from_dcp>]
			_tcl.Entry(_builder.pr_subdivide(cell, subcells, quiet, verbose, from_dcp));
			return _tcl;
		}
		/// <summary>
		/// Verify whether the design check points are replaceable on board. This command supports these
		/// formats: (1) 'pr_verify DCP1 DCP2 -full_check'; (2) 'pr_verify -initial DCP1 -additional {DCP2
		/// DCP3 DCP4 ...}'; (3) 'pr_verify -in_memory -additional {DCP2 DCP3 ...}'; For format (3), it must
		/// have an in-memory design opened.
		///
		///
		/// TCL Syntax: pr_verify [-full_check] [-file <arg>] [-initial <arg>] [-additional <arg>] [-in_memory] [-quiet] [-verbose] [<file1>] [<file2>]
		///
		/// This command is used to compare design checkpoint files for use in the Partial Reconfiguration
		/// flow.
		/// For Partial Reconfigurable designs to work in hardware, the placement and routing of static logic
		/// must be consistent between all configurations. In addition, proxy logic must be placed in the
		/// same locations and clock spine routing must match. The pr_verify command compares routed
		/// design checkpoint files (DCP) created for a Partial Reconfiguration design to verify that all
		/// imported resources match. For more information refer to the Vivado Design Suite User Guide:
		/// Dynamic Function eXchange (UG909).
		/// The two modes for pr_verify let you specify two DCP files to compare, or multiple DCP files
		/// to compare against the first DCP file. The syntax for the two modes is:
		/// • pr_verify DCP1 DCP2
		/// • pr_verify -initial DCP1 -additional {DCP2 DCP3 DCP4}
		/// The second mode is the same as repeating the pr_verify command to compare each
		/// additional DCP with the initial DCP, but keeps the initial DCP open to speed the additional
		/// comparisons:
		/// pr_verify DCP1 DCP2
		/// pr_verify DCP1 DCP3
		/// pr_verify DCP1 DCP4
		/// This command returns the results of the comparison, or returns an error if it fails.
		///
		/// The following example compares the two corner DCPs, specified with the -additional option,
		/// against the inital DCP, running a full check on the designs:
		/// pr_verify -full_check -initial FastConfig.dcp \
		/// -additional {corner1.dcp corner2.dcp}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1117
		/// </summary>
		/// <param name="full_check">
		/// (Optional)
		/// Default behavior is to report the first difference only; if this
		/// option is set to true, pr_verify will report complete
		/// difference in placement or routing
		/// </param>
		/// <param name="file">
		/// (Optional)
		/// Filename to output results to. Send output to console if -file
		/// is not used.
		/// </param>
		/// <param name="initial">(Optional) Initial checkpoint (.dcp)</param>
		/// <param name="additional">(Optional) Additional checkpoints (.dcp)</param>
		/// <param name="in_memory">(Optional) use in-memory design for comparison, combined with - additional option</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="file1">(Optional) Design checkpoint (.dcp) file one</param>
		/// <param name="file2">(Optional) Design checkpoint (.dcp) file two</param>
		public TTCL pr_verify(bool? full_check = null, string file = null, string initial = null, string additional = null, bool? in_memory = null, bool? quiet = null, bool? verbose = null, string file1 = null, string file2 = null)
		{
			// TCL Syntax: pr_verify [-full_check] [-file <arg>] [-initial <arg>] [-additional <arg>] [-in_memory] [-quiet] [-verbose] [<file1>] [<file2>]
			_tcl.Entry(_builder.pr_verify(full_check, file, initial, additional, in_memory, quiet, verbose, file1, file2));
			return _tcl;
		}
		/// <summary>
		/// Read one or more IPIntegrator design files
		///
		///
		/// TCL Syntax: read_bd [-quiet] [-verbose] <files>...
		///
		/// Read the specified IP subsystem design files, or block designs, into the current project or the in￾memory design. This command is similar to the add_files command. The block design file is
		/// added to the source fileset as it is read.
		/// RECOMMENDED: Files are read and referenced from their current location, and are not moved into the local
		/// project directories. To bring the file into the local project, use the import_files command instead.
		/// You can use this command to read block designs into the in-memory design, when running the
		/// Vivado tool in Non Project mode, in which there is no project file to maintain and manage the
		/// various project source files. Refer to the Vivado Design Suite User Guide: Design Flows Overview
		/// (UG892) for more information on Non Project mode.
		/// This command returns the name of the IP subsystem design files read, or returns an error if it
		/// fails.
		///
		/// The following example reads the specified IP subsystem design into the current project:
		/// read_bd C:/Data/block_designs/design1.bd
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1130
		/// </summary>
		/// <param name="files">(Required) IPIntegrator design file name(s)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of IPIntegrator design file objects that were added</returns>
		public TTCL read_bd(string files, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_bd [-quiet] [-verbose] <files>...
			_tcl.Entry(_builder.read_bd(files, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Read a design checkpoint
		///
		///
		/// TCL Syntax: read_checkpoint [-cell <arg>] [-incremental] [-directive <arg>] [-reuse_objects <args>] [-fix_objects <args>] [-dcp_cell_list <args>] [-quiet] [-verbose] [<file>]
		///
		/// Reads a design checkpoint file (DCP) that contains the netlist, constraints, and may optionally
		/// have the placement and routing information of an implemented design. You can save design
		/// checkpoints at any stage in the design using the write_checkpoint command.
		/// The read_checkpoint command simply reads the associated checkpoint file, without opening
		/// a design or project in-memory. To create a project from the imported checkpoint, use the
		/// open_checkpoint command instead of read_checkpoint, or use the link_design
		/// command after read_checkpoint to open the in-memory design from the checkpoint or
		/// checkpoint files currently read.
		/// Note: When multiple design checkpoints are open in the Vivado tool, you must use the
		/// current_project command to switch between the open designs. You can use current_design to
		/// check which checkpoint is the active design.
		///
		/// The following example imports the specified checkpoint file into the tool, and then links the
		/// various design elements to create an in-memory design of the specified name:
		/// read_checkpoint C:/Data/checkpoint.dcp
		/// link_design -name Test1
		/// This example reads a design checkpoint on top of the current design for incremental place and
		/// route of the design:
		/// read_checkpoint -incremental C:/Data/routed.dcp
		/// Reuse and fix the placement and routing associated with the DSPs and Block RAMs:
		/// read_checkpoint -incremental C:/Data/routed.dcp \
		/// -reuse_objects [all_rams] -reuse_objects [all_dsps] -fix_objects
		/// [current_design]
		/// TIP: The -reuse_objects option could also be written as:
		/// -reuse_objects [get_cells -hier -filter {PRIMITIVE_TYPE =~ BMEM.*.* ||
		/// PRIMITIVE_TYPE =~ MULT.dsp.* }]
		/// The following example reuses the placement and routing of the cells inside the hierarchical
		/// cpuEngine cell, and fixes the placement of the DSP cells:
		/// read_checkpoint -incremental C:/Data/routed.dcp -reuse_objects [get_cells
		/// cpuEngine] -fix_objects [all_dsps]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1132
		/// </summary>
		/// <param name="file">(Required) Design checkpoint file</param>
		/// <param name="cell">(Optional) Replace this cell with the checkpoint. The cell must be a black box.</param>
		/// <param name="incremental">(Optional) Input design checkpoint file to be used for re-using implementation.</param>
		/// <param name="directive">
		/// (Optional)
		/// Mode of behavior (directive) for this command. Please refer
		/// to Arguments section of this help for values for this option.
		/// Default: RuntimeOptimized
		/// </param>
		/// <param name="reuse_objects">(Optional) Reuse only given list of cells, clock regions, SLRs and Designs</param>
		/// <param name="fix_objects">(Optional) Fix only given list of cells, clock regions, SLRs or Design</param>
		/// <param name="dcp_cell_list">
		/// (Optional)
		/// A list of cell/dcp pairs, e.g. {<cell1> <dcp1> <cell2> <dcp2>}.
		/// The option value should be in curly braces.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL read_checkpoint(string file, string cell = null, bool? incremental = null, string directive = null, string reuse_objects = null, string fix_objects = null, string dcp_cell_list = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_checkpoint [-cell <arg>] [-incremental] [-directive <arg>] [-reuse_objects <args>] [-fix_objects <args>] [-dcp_cell_list <args>] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.read_checkpoint(file, cell, incremental, directive, reuse_objects, fix_objects, dcp_cell_list, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Import package pin and port placement information
		///
		///
		/// TCL Syntax: read_csv [-quiet_diff_pairs] [-quiet] [-verbose] <file>
		///
		/// Imports port definition and package pin placement information from a comma separated value
		/// (CSV) file.
		/// The port definitions in a CSV file can be imported into an I/O Pin Planning project. In a Pin
		/// Planning project, importing a CSV file replaces the current port definitions. Any ports in the
		/// design that are not found in the imported CSV file will be removed.
		/// In all other projects the port definitions are defined in the source design data, however package
		/// pin assignments and port attributes can be read from the specified CSV file.
		/// The ports read from the CSV file can not have spaces in the name, or the tool will return an error.
		/// The specific format and requirements of the CSV file are described in the Vivado Design Suite User
		/// Guide: I/O and Clock Planning (UG899).
		///
		/// The following example imports a CSV file into an open project:
		/// read_csv C/Data/pinList.csv
		/// The following example sets up a new IO Pin Planning project, and then imports the specified CSV
		/// file into it, and infers any differential pairs in the CSV file:
		/// create_project myPinPlan C:/Data/myPinPlan -part xc7v285tffg1157-1
		/// set_property design_mode PinPlanning [current_fileset]
		/// open_io_design -name io_1
		/// read_csv C:/Data/import.csv
		/// infer_diff_pairs -filetype csv C:/Data/import.csv
		/// Note: The design_mode property on the source fileset is what determines the nature of the project.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1136
		/// </summary>
		/// <param name="file">(Required) Pin Planning CSV file</param>
		/// <param name="quiet_diff_pairs">
		/// (Optional)
		/// Suppress warnings about differential pair inference when
		/// importing I/O ports
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL read_csv(string file, bool? quiet_diff_pairs = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_csv [-quiet_diff_pairs] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.read_csv(file, quiet_diff_pairs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Read one or more EDIF or NGC files
		///
		///
		/// TCL Syntax: read_edif [-quiet] [-verbose] <files>
		///
		/// Imports an EDIF or NGC netlist file into the Design Source fileset of the current project.
		/// IMPORTANT! NGC format files are not supported in the Vivado Design Suite for UltraScale devices. It is
		/// recommended that you regenerate the IP using the Vivado Design Suite IP customization tools with native
		/// output products. Alternatively, you can use the NGC2EDIF command to migrate the NGC file to EDIF format
		/// for importing. For more information refer to the ISE to Vivado Design Suite Migration Guide (UG911).
		///
		/// The following example imports an EDIF file into the open project:
		/// read_edif C/Data/bft_top.edf
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1138
		/// </summary>
		/// <param name="files">(Required) EDIF or NGC file name(s)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of file objects that were added</returns>
		public TTCL read_edif(string files, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_edif [-quiet] [-verbose] <files>
			_tcl.Entry(_builder.read_edif(files, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Read one or more IP files
		///
		///
		/// TCL Syntax: read_ip [-quiet] [-verbose] <files>
		///
		/// Read the specified list of IP files (XCI) and add them to the design and the current fileset. Files are
		/// added by reference into the current project, just as in the add_files command.
		/// You can use this command to read the contents of source files into the in-memory design, when
		/// running the Vivado tool in Non Project mode, in which there is no project file to maintain and
		/// manage the various project source files. Refer to the Vivado Design Suite User Guide: Design Flows
		/// Overview (UG892) for more information on Non Project mode.
		/// When using the read_ip command all output products associated with the IP core, including
		/// the design checkpoint file (DCP) will be read into the in-memory design.
		/// TIP: In the project-based design flow, the Vivado tool will automatically generate the necessary output products
		/// associated with an IP core. However, in a non-project flow you must generate the necessary output products
		/// using the synth_ip or generate_target commands. For more information on working with IP refer to the
		/// Vivado Design Suite User Guide: Designing with IP (UG896).
		/// Use the import_ip command to add the IP cores and import the files into the local project
		/// directory.
		/// This command returns the list of files read.
		///
		/// The following example reads the specified IP files:
		/// read_ip C:/test_ip/char_fifo.xci
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1146
		/// </summary>
		/// <param name="files">(Required) IP file name(s)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of IP file objects that were added</returns>
		public TTCL read_ip(string files, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_ip [-quiet] [-verbose] <files>
			_tcl.Entry(_builder.read_ip(files, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Read one or more data files (.mem .mif .dat).
		///
		///
		/// TCL Syntax: read_mem [-quiet] [-verbose] <files>...
		///
		/// This command reads memory files of type MEM, DAT, or COE, and adds the files to the in￾memory design, or the current project, to initialize BRAM memory for behavioral simulation,
		/// synthesis and post-synthesis simulation.
		/// If the memory is not initialized in the design, then it will be initialized to all 0s.
		/// This command returns the name of the files read, or returns an error if it fails.
		///
		/// The following example:
		/// read_mem C:/Data/design1.mem
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1151
		/// </summary>
		/// <param name="files">(Required) Data (.mem .coe .dat) file name(s)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of file objects that were added</returns>
		public TTCL read_mem(string files, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_mem [-quiet] [-verbose] <files>...
			_tcl.Entry(_builder.read_mem(files, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Read QoR Suggestions from the given file
		///
		///
		/// TCL Syntax: read_qor_suggestions [-quiet] [-verbose] <file>
		///
		/// Read the specified file and extract the QoR suggestions from the file.
		/// This command returns the name of the QoR file read, or returns an error if it fails.
		///
		/// The following example reads the QoR suggestions from the specified file, and then reports the
		/// QoR suggestions in the open design:
		/// read_qor_suggestions C:/Data/qor_results.rqs
		/// report_qor_suggestions -of_objects [get_qor_suggestions]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1153
		/// </summary>
		/// <param name="file">
		/// (Required)
		/// QoR suggestions file Values: Path to the QoR suggestions
		/// file, typically ending with .rqs.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL read_qor_suggestions(string file, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_qor_suggestions [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.read_qor_suggestions(file, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Import simulation data in saif format
		///
		///
		/// TCL Syntax: read_saif [-strip_path <arg>] [-no_strip] [-out_file <arg>] [-quiet] [-verbose] <file>
		///
		/// Reads a Switching Activity Interchange Format (SAIF) file for use during power analysis by the
		/// report_power command, or power optimization by power_opt_design. The read_saif
		/// command will annotate the design nodes with activity from the SAIF file and estimate power
		/// appropriately.
		/// Running report_power or power_opt_design after reading the SAIF file will use the activity
		/// rates from the specified file during optimization and analysis.
		///
		/// The following example:
		/// read_saif -strip_path design/top/F1 C:/Data/design1.saif
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1155
		/// </summary>
		/// <param name="file">(Required) Specifies the name of the SAIF file to be read</param>
		/// <param name="strip_path">
		/// (Optional)
		/// Specifies the name of the instance of the current design as
		/// it appears in the SAIF file
		/// </param>
		/// <param name="no_strip">(Optional) Do not strip first two levels of hierarchy from SAIF file</param>
		/// <param name="out_file">
		/// (Optional)
		/// Specifies the name of the output file that contains nets that
		/// could not be matched
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL read_saif(string file, string strip_path = null, bool? no_strip = null, string out_file = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_saif [-strip_path <arg>] [-no_strip] [-out_file <arg>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.read_saif(file, strip_path, no_strip, out_file, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Import schematic
		///
		///
		/// TCL Syntax: read_schematic [-name <arg>] [-quiet] [-verbose] <file>
		///
		/// Import a native schematic file that was previously exported from the Vivado Design Suite using
		/// the write_schematic command.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1157
		/// </summary>
		/// <param name="file">(Required) Input file</param>
		/// <param name="name">(Optional) Schematic window title</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>name of the file previously exported</returns>
		public TTCL read_schematic(string file, string name = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_schematic [-name <arg>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.read_schematic(file, name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Read timing results from Trace STA tool
		///
		///
		/// TCL Syntax: read_twx [-cell <arg>] [-pblock <arg>] [-quiet] [-verbose] <name> <file>
		///
		/// Imports timing results in the TWX format timing report files generated by the Xilinx Timing
		/// Reporter And Circuit Evaluator (TRACE) tool. The TWX file can be imported at the top-level,
		/// which is the default, or at a specific cell-level or relative to a specific Pblock.
		/// After the TWX files are imported, the timing results display in the Timing Results view in GUI
		/// mode.
		///
		/// The following example reads the specified TWX file into the top-level of the design:
		/// read_twx C:/Data/timing_files/bft.twx
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1159
		/// </summary>
		/// <param name="name">(Required) Name for the set of results</param>
		/// <param name="file">(Required) Name of the Trace import file</param>
		/// <param name="cell">(Optional) Interpret names in the report file as relative to the specified cell</param>
		/// <param name="pblock">(Optional) Interpret names in the report file as relative to the specified pblock</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL read_twx(string name, string file, string cell = null, string pblock = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_twx [-cell <arg>] [-pblock <arg>] [-quiet] [-verbose] <name> <file>
			_tcl.Entry(_builder.read_twx(name, file, cell, pblock, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Read one or more Verilog files
		///
		///
		/// TCL Syntax: read_verilog [-library <arg>] [-sv] [-quiet] [-verbose] <files>...
		///
		/// Reads Verilog or SystemVerilog source files. This command is similar to the add_files
		/// command. The Verilog file is added to the source fileset as it is read. If the -library argument
		/// is specified, the file is added with the Library property defined appropriately.
		/// You can use this command to read the contents of source files into the in-memory design, when
		/// running the Vivado tool in Non Project mode, in which there is no project file to maintain and
		/// manage the various project source files. Refer to the Vivado Design Suite User Guide: Design Flows
		/// Overview (UG892) for more information on Non Project mode.
		/// Because SystemVerilog is a superset of the Verilog language, the read_verilog command can
		/// read both file types. However, for SystemVerilog files, the -sv option needs to be specified for
		/// read_verilog to enable compilation in the SystemVerilog mode. In this mode, the tool
		/// recognizes and honors the SystemVerilog keywords and constructs.
		/// You can have a mixture of both Verilog files (.v files), and SystemVerilog files (.sv files), as well as
		/// VHDL (using read_vhdl). When the tool compiles these files for synthesis, it creates separate
		/// "compilation units" for each file type. All files of the same type are compiled together.
		///
		/// The following example reads the specified Verilog file and adds it to the source fileset:
		/// read_verilog C:/Data/FPGA_Design/new_module.v
		/// The following example creates two compilation units, one for SystemVerilog files and one for
		/// Verilog files:
		/// read_verilog -sv { file1.sv file2.sv file3.sv }
		/// read_verilog { file1.v file2.v file3.v}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1161
		/// </summary>
		/// <param name="files">(Required) Verilog file name(s)</param>
		/// <param name="library">(Optional) Library name (ignored by Vivado synthesis) Default: default lib</param>
		/// <param name="sv">(Optional) Enable system verilog compilation</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of file objects that were added</returns>
		public TTCL read_verilog(string files, string library = null, bool? sv = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_verilog [-library <arg>] [-sv] [-quiet] [-verbose] <files>...
			_tcl.Entry(_builder.read_verilog(files, library, sv, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Read one or more VHDL files
		///
		///
		/// TCL Syntax: read_vhdl -library <arg> [-vhdl2008] [-quiet] [-verbose] <files>
		///
		/// Reads VHDL source files. This command is similar to the add_files command. The VHDL files
		/// are added to the source fileset as the file is read. If the -library argument is specified, the file
		/// is added with the Library property defined.
		/// You can use this command to read the contents of source files into the in-memory design, when
		/// running the Vivado tool in Non Project mode, in which there is no project file to maintain and
		/// manage the various project source files. Refer to the Vivado Design Suite User Guide: Design Flows
		/// Overview (UG892) for more information on Non Project mode.
		///
		/// The following example reads the specified VHDL file and adds it to the source fileset:
		/// read_vhdl C:/Data/FPGA_Design/new_module.vhdl
		/// This example reads multiple specified VHDL 2008 files:
		/// read_vhdl -vhdl2008 {file1.vhd file2.vhd file3.vhd}
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1163
		/// </summary>
		/// <param name="library">(Required) VHDL library</param>
		/// <param name="files">(Required) VHDL file name(s)</param>
		/// <param name="vhdl2008">(Optional) VHDL file is version 2008.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of file objects that were added</returns>
		public TTCL read_vhdl(string library, string files, bool? vhdl2008 = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_vhdl -library <arg> [-vhdl2008] [-quiet] [-verbose] <files>
			_tcl.Entry(_builder.read_vhdl(library, files, vhdl2008, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// read physical and timing constraints from one of more files.
		///
		///
		/// TCL Syntax: read_xdc [-cells <args>] [-ref <arg>] [-quiet_diff_pairs] [-mode <arg>] [-unmanaged] [-no_add] [-quiet] [-verbose] <files>
		///
		/// Imports physical and timing constraints from a Xilinx Design Constraints file (XDC). The XDC is
		/// imported into the current_instance level of the design hierarchy, which defaults to the top￾level of the design, or can be imported into specified cells. When imported at the top-level, the
		/// specified XDC file is added to the active constraint fileset.
		/// IMPORTANT! Constraints from the XDC file will overwrite any current constraints of the same name.
		/// Therefore, exercise some caution when reading a XDC file to be sure you will not overwrite important
		/// constraints.
		/// This command is similar to the add_files command in that the XDC file is added by reference
		/// rather than imported into the local project directory.
		/// You can use this command to read the contents of source files into the in-memory design, when
		/// running the Vivado tool in Non Project mode, in which there is no project file to maintain and
		/// manage the various project source files. Refer to the Vivado Design Suite User Guide: Design Flows
		/// Overview (UG892) for more information on Non Project mode.
		///
		/// The following example reads the XDC file and applies it to the current design:
		/// read_xdc file_1.xdc
		/// The following example reads the XDC file and applies it ALL instances of the referenced module
		/// found in the current design:
		/// read_xdc -ref hex2led file_2.xdc
		/// The following example reads the XDC file and applies it ONLY to the specified instance within
		/// the referenced module:
		/// read_xdc -ref sixty -cells lsbcount file_3.xdc
		/// The following example reads the XDC file and applies it to the specified instances in the current
		/// design, even though they are instances of different modules:
		/// read_xdc -cells {one_decode sixty/msbcount} file_4.xdc
		/// Note: Multiple cells must be enclosed in quotes, "", or braces, {}.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1165
		/// </summary>
		/// <param name="files">(Required) Input file(s) to read</param>
		/// <param name="cells">(Optional) Import constraints for these cells</param>
		/// <param name="@ref">(Optional) Import constraints for this ref</param>
		/// <param name="quiet_diff_pairs">
		/// (Optional)
		/// Suppress warnings about differential pair inference when
		/// importing I/O ports
		/// </param>
		/// <param name="mode">
		/// (Optional)
		/// Import constraints as out_of_context. Values: default,
		/// out_of_context Default: default
		/// </param>
		/// <param name="unmanaged">(Optional) treat this file as unmanaged constraints file</param>
		/// <param name="no_add">(Optional) don't add this file to constraints fileset</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of files</returns>
		public TTCL read_xdc(string files, string cells = null, string @ref = null, bool? quiet_diff_pairs = null, string mode = null, bool? unmanaged = null, bool? no_add = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_xdc [-cells <args>] [-ref <arg>] [-quiet_diff_pairs] [-mode <arg>] [-unmanaged] [-no_add] [-quiet] [-verbose] <files>
			_tcl.Entry(_builder.read_xdc(files, cells, @ref, quiet_diff_pairs, mode, unmanaged, no_add, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Update and initialize the BRAM initialization strings with contents of elf files.
		///
		///
		/// TCL Syntax: refresh_meminit [-quiet] [-verbose]
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1199
		/// </summary>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL refresh_meminit(bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: refresh_meminit [-quiet] [-verbose]
			_tcl.Entry(_builder.refresh_meminit(quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Write an abstract shell checkpoint of the current design
		///
		///
		/// TCL Syntax: write_abstract_shell -cell <arg> [-force] [-quiet] [-verbose] <file>
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1779
		/// </summary>
		/// <param name="cell">(Required) Create an abstract shell for this reconfigurable cell</param>
		/// <param name="file">
		/// (Required)
		/// Design checkpoint file Values: A filename with alphanumeric
		/// characters and .dcp extension.
		/// </param>
		/// <param name="force">(Optional) Overwrite existing checkpoint file</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The name of the checkpoint file</returns>
		public TTCL write_abstract_shell(string cell, string file, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_abstract_shell -cell <arg> [-force] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_abstract_shell(cell, file, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Export layout in native, pdf or svg
		///
		///
		/// TCL Syntax: write_bd_layout [-force] [-format <arg>] [-orientation <arg>] [-scope <arg>] [-hierarchy <arg>] [-quiet] [-verbose] <file>
		///
		/// Write the current open block design in the Vivado IP integrator to the specified file format.
		/// This command lets you print the block design, output it as a vector graphic file for use in
		/// documentation related to the design project, or recreate the block design layout in the Vivado IP
		/// integrator design canvas using the regenerate_bd_layout command.
		/// This command returns the name of the file written, or returns an error if it fails.
		///
		/// The following example prints the current block design to the specified PDF file:
		/// write_bd_layout -format pdf -orientation landscape C:/Data/microblaze.pdf
		/// The following example prints the specified hierarchical cell of the block design to the specified
		/// SVG file:
		/// write_bd_layout -format svg -orientation landscape C:/Data/microblaze.svg
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1780
		/// </summary>
		/// <param name="file">(Required) Output file</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="format">
		/// (Optional)
		/// Values: native, pdf or svg. regenerate_bd_layout -layout_file
		/// can be used with native layout. Default: native
		/// </param>
		/// <param name="orientation">(Optional) Values: landscape or portrait</param>
		/// <param name="scope">(Optional) Values: visible or all Default: all</param>
		/// <param name="hierarchy">(Optional) Hierarchy block</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>name of the output file</returns>
		public TTCL write_bd_layout(string file, bool? force = null, string format = null, string orientation = null, string scope = null, string hierarchy = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_bd_layout [-force] [-format <arg>] [-orientation <arg>] [-scope <arg>] [-hierarchy <arg>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_bd_layout(file, force, format, orientation, scope, hierarchy, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Write a bitstream for the current design
		///
		///
		/// TCL Syntax: write_bitstream [-force] [-verbose] [-raw_bitfile] [-no_binary_bitfile] [-mask_file] [-readback_file] [-logic_location_file] [-bin_file] [-reference_bitfile <arg>] [-cell <arg>] [-no_partial_bitfile] [-quiet] <file>
		///
		/// Writes a bitstream file for the current project. This command must be run on an Implemented
		/// Design. The bitstream written will be based on the open Implemented Design.
		/// The files that can be generated by the write_bitstream command include the following:
		/// • Bit file: The binary bitstream file (.bit).
		/// • Raw (ASCII) Bit file: A raw bit file (.rbt) that contains the same information as the binary
		/// bitstream file, but is in ASCII format.
		/// • Mask file: A mask file (.msk) that has mask data in place of the configuration data in the
		/// bitstream file.
		/// • Logic Location file: An ASCII logic location file (.ll) that shows the bitstream position of
		/// latches, flip-flops, LUTs, Block RAMs, and I/O block inputs and outputs.
		/// • Bin file: A binary file (.bin) containing only the device programming data, without the header
		/// information found in the standard binary Bit file.
		/// • Reference Bit file: An incremental bitstream file containing only the differences from the
		/// current bitstream and a specified reference bitstream.
		/// The Vivado tool can write a compressed bitstream, if you have enabled compression by setting
		/// the BITSTREAM.GENERAL.COMPRESS property on the implemented design. Refer to the Vivado
		/// Design Suite User Guide: Programming and Debugging (UG908) for more information on Device
		/// Configuration Properties. To enable compression use the following Tcl command:
		/// set_property BITSTREAM.GENERAL.COMPRESS TRUE [current_design]
		/// The Vivado Design Suite can also write an encrypted bitstream to protect the intellectual
		/// property of the design in the bitstream. To create an encrypted bitstream you must first define
		/// the type of encryption to be used, and the encryption key. You can accomplish this most easily
		/// using the Encryption page of the Edit Device Properties dialog box in the Vivado IDE. Refer to
		/// the Vivado Design Suite User Guide: Programming and Debugging (UG908) for more information on
		/// the Edit Device Properties dialog box.
		/// You can also enable encryption by manually defining the appropriate properties on the
		/// implemented design as follows:
		/// set_property BITSTREAM.ENCRYPTION.ENCRYPT YES [get_designs impl_1]
		/// set_property BITSTREAM.ENCRYPTION.ENCRYPTKEYSELECT EFUSE [get_designs
		/// impl_1]
		/// set_property BITSTREAM.ENCRYPTION.KEY0 8675309 [get_designs impl_1]
		/// The properties associated with encryption include:
		/// • BITSTREAM.ENCRYPTION.ENCRYPT - Enables encryption when generating the bitstream
		/// with write_bitstream. This property accepts a value of YES or NO.
		/// • BITSTREAM.ENCRYPTION.ENCRYPTKEYSELECT - Specifies the method for storing the
		/// encryption key on the hardware device. The accepted values are BBRAM and EFUSE, referring
		/// to battery-backed SRAM or the eFUSE registers on the device.
		/// CAUTION! eFUSEs are one-time programmable cells on the hardware device, used to store the factory￾programmed Device DNA, AES-GCM encryption key, and user specified values. Refer to the UltraScale
		/// Architecture Configuration User Guide (UG570) or 7 Series FPGAs Configuration User Guide (UG470) for more
		/// information on eFUSE registers.
		/// • BITSTREAM.ENCRYPTION.KEY0 - Specifies the encryption key to apply to the BBRAM, or
		/// the eFUSE FUSE_KEY registers on the device. The key can be specified as a 256 bit value, and
		/// will be required when accessing an encrypted bitstream to program, verify, or readback the
		/// hw_device.
		/// TIP: The write_bitstream command will write an NKY file of the same name as the bitstream file (with
		/// the .nky extension) when the BITSTREAM.ENCRYPTION.KEY0 property is specified. This encryption file can
		/// then be used in other designs by setting the BITSTREAM.ENCRYPTION.KEYFILE property.
		/// • BITSTREAM.ENCRYPTION.KEYFILE - Specifies an encryption key file (NKY or NKZ) as an
		/// alternative to setting the ENCRYPTION.KEY0 property. The specified encryption key file will
		/// be used during bitstream encryption.
		/// IMPORTANT! If both the BITSTREAM.ENCRYPTION.KEY0 and BITSTREAM.ENCRYPTION.KEYFILE properties
		/// are defined, the tool will use the encryption key specified by the BITSTREAM.ENCRYPTION.KEY0 property and
		/// return a message to that effect.
		///
		/// The following example enables compression and writes a bitstream file of the specified name:
		/// set_property BITSTREAM.GENERAL.COMPRESS TRUE [current_design]
		/// write_bitstream design1.bit
		/// The following example writes both the binary and ASCII forms of the bitstream:
		/// write_bitstream -raw_bitfile C:/Data/design1
		/// Note: The appropriate file extension will be added by the tool.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1787
		/// </summary>
		/// <param name="file">(Required) The name of the .bit file to generate</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="verbose">(Optional) Print write_bitstream options</param>
		/// <param name="raw_bitfile">(Optional) Write raw bit file (.rbt)</param>
		/// <param name="no_binary_bitfile">(Optional) Do not write binary bit file (.bit)</param>
		/// <param name="mask_file">(Optional) Write mask file (.msk)</param>
		/// <param name="readback_file">(Optional) Write readback files (.rbd, .msd)</param>
		/// <param name="logic_location_file">(Optional) Write logic location file (.ll)</param>
		/// <param name="bin_file">(Optional) Write binary bit file without header (.bin)</param>
		/// <param name="reference_bitfile">(Optional) Reference bitfile to be used for generating partial bitstream</param>
		/// <param name="cell">(Optional) Create only partial bitstream for named cell</param>
		/// <param name="no_partial_bitfile">(Optional) Do not write partial bit files for a partial reconfiguration design</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		public TTCL write_bitstream(string file, bool? force = null, bool? verbose = null, bool? raw_bitfile = null, bool? no_binary_bitfile = null, bool? mask_file = null, bool? readback_file = null, bool? logic_location_file = null, bool? bin_file = null, string reference_bitfile = null, string cell = null, bool? no_partial_bitfile = null, bool? quiet = null)
		{
			// TCL Syntax: write_bitstream [-force] [-verbose] [-raw_bitfile] [-no_binary_bitfile] [-mask_file] [-readback_file] [-logic_location_file] [-bin_file] [-reference_bitfile <arg>] [-cell <arg>] [-no_partial_bitfile] [-quiet] <file>
			_tcl.Entry(_builder.write_bitstream(file, force, verbose, raw_bitfile, no_binary_bitfile, mask_file, readback_file, logic_location_file, bin_file, reference_bitfile, cell, no_partial_bitfile, quiet));
			return _tcl;
		}
		/// <summary>
		/// Write a bmm file
		///
		///
		/// TCL Syntax: write_bmm [-force] [-quiet] [-verbose] <file>
		///
		/// The Block RAM Memory Map (BMM) file is a text file that describes how individual block RAMs
		/// on an FPGA are grouped together into a contiguous address space called an Address Block.
		/// The write_bmm command exports BMM information from the current design to the specified
		/// file. For implemented designs the BMM file will be include placement information. The
		/// data2mem command uses the BMM file as input to direct the translation of programming data
		/// into the proper form for use in simulation, device programming, or software development in SDK.
		/// The command returns the name of the output file, or an error.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1792
		/// </summary>
		/// <param name="file">
		/// (Required)
		/// Design bmm file Values: A filename with alphanumeric
		/// characters and .bmm extension.
		/// </param>
		/// <param name="force">(Optional) Overwrite existing BMM file.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The name of the bmm file</returns>
		public TTCL write_bmm(string file, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_bmm [-force] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_bmm(file, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Generate a design specific post-configuration BSDL file (.bsd).
		///
		///
		/// TCL Syntax: write_bsdl [-force] [-bsd <arg>] [-quiet] [-verbose] <file>
		///
		/// Generate a Boundary Scan Description Language (BSDL) file (.bsd) for the current design that
		/// reflects the post-configuration boundary scan architecture of the target device.
		/// The boundary scan architecture for the device is changed when the device is configured because
		/// certain connections between the boundary scan registers and pad may change. These changes
		/// must be communicated to the boundary scan tester through a post-configuration BSDL file.
		/// Refer to the Vivado Design Suite User Guide: Programming and Debugging (UG908) for more
		/// information on the available configuration modes.
		/// The write_bsdl command reads a pre-configuration BSDL file for the target part from the
		/// Vivado Design Suite installation area, and combines that with post-configuration data from the
		/// current design.
		/// This command returns the name of the output BSDL file, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1794
		/// </summary>
		/// <param name="file">(Required) Output file name. The .bsd extension is optional.</param>
		/// <param name="force">(Optional) Overwrite existing .bsd file</param>
		/// <param name="bsd">(Optional) Specify an updated generic BSDL file.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>name of the output file</returns>
		public TTCL write_bsdl(string file, bool? force = null, string bsd = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_bsdl [-force] [-bsd <arg>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_bsdl(file, force, bsd, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Create file(s) for programming flash memory.
		///
		///
		/// TCL Syntax: write_cfgmem [-force] -format <arg> -size <arg> [-interface <arg>] [-checksum] [-disablebitswap] [-loadbit <arg>] [-loaddata <arg>] [-quiet] [-verbose] <file>
		///
		/// This command formats a design specific configuration bitstream (.bit) file, and any specified
		/// data files, into a specified memory configuration file format to program into a flash memory
		/// device using the program_hw_cfgmem command. Supported memory configuration file formats
		/// are MCS, BIN, and HEX.
		/// TIP: When you generate a cfgmem file with write_cfgmem, by default the bits within a byte are bit-swapped,
		/// or mirrored, compared to bytes in the original input bitstream. You can disable bitswap using the -
		/// disablebitswap option as described below.
		/// The process whereby the design specific data is loaded or programmed into the Xilinx® FPGA is
		/// called configuration. The create_hw_cfgmem command defines a flash memory device used
		/// for configuring and booting the hardware device.
		/// After the hw_cfgmem object is created, and associated with the hw_device, the configuration
		/// memory can be programmed with the bitstream and other data from a memory configuration file
		/// created with the write_cfgmem command. The hw_cfgmem object is programmed using the
		/// program_hw_cfgmem command.
		/// The write_cfgmem -loadbit command loads one or more specified bitstream files into the
		/// memory configuration file, filling the available memory of the device in an upward or downward
		/// direction from a specified starting address. You can also add data files to the memory
		/// configuration file, by specifying the starting address to load the file with -loaddata.
		/// TIP: When using -loadbit and -loaddata to fill the memory of the device, you must exercise care to insure
		/// that the bitstream and data files fit into the available memory and do not overwrite each other. Any data
		/// collisions will cause the write_cfgmem command to fail with an error.
		/// The write_cfgmem command returns a transcript of its process when successful, or returns an
		/// error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1796
		/// </summary>
		/// <param name="format">(Required) Format of the file to generate</param>
		/// <param name="size">(Required) Size of memory that is being targeted in M Bytes (must be power of 2).</param>
		/// <param name="file">(Required) The name of the file to generate</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="@interface">(Optional) Interface used to program device. Default: SMAPx8</param>
		/// <param name="checksum">
		/// (Optional)
		/// Calculate a 32-bit checksum for each file. Memory will be
		/// filed with value of 0xFF unless a different byte value is
		/// specified. Default: 0xFF
		/// </param>
		/// <param name="disablebitswap">(Optional) Disable bit swapping in a byte for bitfiles.</param>
		/// <param name="loadbit">(Optional) Load bit files into memory from given address.</param>
		/// <param name="loaddata">(Optional) Load data into memory from given address.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_cfgmem(string format, string size, string file, bool? force = null, string @interface = null, bool? checksum = null, bool? disablebitswap = null, string loadbit = null, string loaddata = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_cfgmem [-force] -format <arg> -size <arg> [-interface <arg>] [-checksum] [-disablebitswap] [-loadbit <arg>] [-loaddata <arg>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_cfgmem(format, size, file, force, @interface, checksum, disablebitswap, loadbit, loaddata, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Write a checkpoint of the current design
		///
		///
		/// TCL Syntax: write_checkpoint [-force] [-cell <arg>] [-logic_function_stripped] [-encrypt] [-key <arg>] [-incremental_synth] [-quiet] [-verbose] <file>
		///
		/// Saves the design at any point in the design process so that you can quickly import it back into the
		/// tool as needed. A design checkpoint (DCP) can contain the netlist, the constraints, and any
		/// placement and routing information from the implemented design.
		/// TIP: In the Project mode, a DCP will not have timing constraints after synthesis. The timing constraints are
		/// annotated against the design during open_run or link_design commands, or when launching an
		/// implementation run. To create a DCP with timing constraints, create the design checkpoint after opt_design,
		/// or after the implementation run completes.
		/// Use the read_checkpoint command to import a checkpoint file.
		///
		/// The following example creates the specified checkpoint file, overwriting a file of the same name
		/// if one already exists:
		/// write_checkpoint C:/Data/checkpoint1 -force
		/// Note: The tool will add the .dcp extension to the specified file name, and will overwrite an existing
		/// checkpoint1.dcp file.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1800
		/// </summary>
		/// <param name="file">
		/// (Required)
		/// Design checkpoint file Values: A filename with alphanumeric
		/// characters and .dcp extension.
		/// </param>
		/// <param name="force">(Optional) Overwrite existing checkpoint file</param>
		/// <param name="cell">(Optional) Write a checkpoint of this cell</param>
		/// <param name="logic_function_stripped">
		/// (Optional)
		/// Convert INIT strings on LUTs & RAMBs to fixed values. Note
		/// that the resulting netlist will be nonfunctional.
		/// </param>
		/// <param name="encrypt">(Optional) Encrypt unprotected modules using IEEE 1735 IP security version 2</param>
		/// <param name="key">
		/// (Optional)
		/// Key file to be used with -encrypt option; Otherwise, use
		/// Xilinx public key
		/// </param>
		/// <param name="incremental_synth">(Optional) export synthesis archive file to be used for re-using implementation.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The name of the checkpoint file</returns>
		public TTCL write_checkpoint(string file, bool? force = null, string cell = null, bool? logic_function_stripped = null, bool? encrypt = null, string key = null, bool? incremental_synth = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_checkpoint [-force] [-cell <arg>] [-logic_function_stripped] [-encrypt] [-key <arg>] [-incremental_synth] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_checkpoint(file, force, cell, logic_function_stripped, encrypt, key, incremental_synth, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Export package pin and port placement information
		///
		///
		/// TCL Syntax: write_csv [-force] [-quiet] [-verbose] <file>
		///
		/// Writes package pin and port placement information into a comma separated value (CSV) file.
		/// The specific format and requirements of the CSV file are described in the Vivado Design Suite User
		/// Guide: I/O and Clock Planning (UG899).
		///
		/// The following example exports a CSV file from the current project:
		/// write_csv C:/Data/pinList.csv
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1803
		/// </summary>
		/// <param name="file">(Required) Pin Planning CSV file</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>name of the output file</returns>
		public TTCL write_csv(string file, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_csv [-force] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_csv(file, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Write debug probes to a file
		///
		///
		/// TCL Syntax: write_debug_probes [-cell <arg>] [-no_partial_ltxfile] [-force] [-quiet] [-verbose] <file>
		///
		/// Writes a Vivado Design Suite logic analyzer probes file containing ILA debug cores and signal
		/// probes added to the current design. The debug probes data file typically has a .ltx file
		/// extension.
		/// ILA cores are added to the design using the create_debug_core command. ILA probes are
		/// added to the design using the create_debug_port command, and connected to nets in your
		/// design using the connect_debug_port command.
		/// The specific information and use of the debug probes file is described in the Vivado Design Suite
		/// User Guide: Vivado Programming and Debugging (UG908).
		///
		/// The following example write a debug probe file from the current design:
		/// write_debug_probes C:/Data/designProbes.ltx
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1805
		/// </summary>
		/// <param name="file">(Required) Debug probes file name (default extension is .ltx)</param>
		/// <param name="cell">(Optional) Hierarchical name of the Reconfigurable Partition Cell</param>
		/// <param name="no_partial_ltxfile">(Optional) Do not generate partial LTX files</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>name of the output file</returns>
		public TTCL write_debug_probes(string file, string cell = null, bool? no_partial_ltxfile = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_debug_probes [-cell <arg>] [-no_partial_ltxfile] [-force] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_debug_probes(file, cell, no_partial_ltxfile, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Export the current netlist as an EDIF file
		///
		///
		/// TCL Syntax: write_edif [-pblocks <args>] [-cell <arg>] [-force] [-security_mode <arg>] [-logic_function_stripped] [-quiet] [-verbose] <file>
		///
		/// Writes the current netlist as an EDIF file, or outputs the contents of specific Pblocks or
		/// hierarchical cells as EDIF netlist files.
		/// In the case of either the -pblocks or -cell option being used, this argument specifies a
		/// directory name where the EDIF netlist files for each Pblock or cell will be written. The EDIF
		/// netlist file will be named after the Pblock or cell. If the directory specified does not exist, the tool
		/// will return an error.
		///
		/// The following example writes an EDIF netlist file for the whole design to the specified file name:
		/// write_edif C:/Data/edifOut.edn
		/// The following example outputs an EDIF netlist for all Pblocks in the design. The files will be
		/// written to the specified directory.
		/// write_edif -pblocks [get_pblocks] C:/Data/FPGA_Design/
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1807
		/// </summary>
		/// <param name="file">(Required) Output file (directory with -pblocks or -cell)</param>
		/// <param name="pblocks">(Optional) Export netlist for these pblocks (not valid with -cell)</param>
		/// <param name="cell">(Optional) Export netlist for this cell (not valid with -pblocks)</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="security_mode">
		/// (Optional)
		/// If set to 'all', and some of design needs encryption then
		/// whole of design will be written to a single encrypted file
		/// Default: multifile
		/// </param>
		/// <param name="logic_function_stripped">(Optional) Convert INIT strings on LUTs & RAMBs to fixed values</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>the name of the output file or directory</returns>
		public TTCL write_edif(string file, string pblocks = null, string cell = null, bool? force = null, string security_mode = null, bool? logic_function_stripped = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_edif [-pblocks <args>] [-cell <arg>] [-force] [-security_mode <arg>] [-logic_function_stripped] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_edif(file, pblocks, cell, force, security_mode, logic_function_stripped, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Write the Xilinx Shell Archive for the current design
		///
		///
		/// TCL Syntax: write_hw_platform [-fixed] [-force] [-include_bit] [-include_emulation] [-minimal] [-quiet] [-verbose] [<file>]
		///
		/// Writes a Xilinx support archive (XSA) of the current design for use as a hardware platform.
		/// All platforms are dynamically implemented during compilation, meaning that the accelerator logic
		/// coming is implemented along with some or all of the logic contained in the hardware platform
		/// design. The XSA represents the required portion of the hardware platform. The hardware
		/// platform design used to create a XSA consists of a Vivado IP integrator subsystem design with all
		/// the required board interface IP cores configured and connected to the device I/Os. The Vivado
		/// project must also include several required XSA and PFM properties needed to define the XSA.
		/// This command reports the name of the XSA file written, or returns an error if it fails.
		///
		/// The following example writes the XSA for the current project, overwriting a XSA file of the same
		/// name if one exists:
		/// write_XSA -force C:/Data/zc702.xsa
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1813
		/// </summary>
		/// <param name="file">
		/// (Required)
		/// Device Support Archive file Values: A filename with
		/// alphanumeric characters and .xsa extension.
		/// </param>
		/// <param name="@fixed">(Optional) Write fixed Shell.</param>
		/// <param name="force">(Optional) Overwrite existing Xilinx Shell Archive file</param>
		/// <param name="include_bit">(Optional) Include bit file(s) in the Shell.</param>
		/// <param name="include_emulation">(Optional) Generate and include hardware emulation support in the Shell.</param>
		/// <param name="minimal">(Optional) Add only minimal files in the Shell.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The name of the Shell file</returns>
		public TTCL write_hw_platform(string file, bool? @fixed = null, bool? force = null, bool? include_bit = null, bool? include_emulation = null, bool? minimal = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_hw_platform [-fixed] [-force] [-include_bit] [-include_emulation] [-minimal] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.write_hw_platform(file, @fixed, force, include_bit, include_emulation, minimal, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Write the unified JSON metadata file for the current design
		///
		///
		/// TCL Syntax: write_hw_platform_metadata [-quiet] [-verbose] [<file>]
		///
		/// Writes a JSON metadata file for the platform represented by the current design.
		/// This command returns the name of the JSON file written, or returns an error if it fails.
		///
		/// The following example writes the JSON file for the current project:
		/// write_hw_platform_metadata C:/Data/zc102_platform.json
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1815
		/// </summary>
		/// <param name="file">
		/// (Required)
		/// Unified JSON metadata file Values: A filename with
		/// alphanumeric characters and .json extension.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The name of the unified JSON metadata file</returns>
		public TTCL write_hw_platform_metadata(string file, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_hw_platform_metadata [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.write_hw_platform_metadata(file, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Write IBIS models for current floorplan
		///
		///
		/// TCL Syntax: write_ibis [-force] [-allmodels] [-nopin] [-no_pin_mapping] [-truncate <arg>] [-component_name <arg>] [-ibs <arg>] [-pkg <arg>] [-quiet] [-verbose] <file>
		///
		/// Writes the IBIS models for the target device in the current design. The netlist and
		/// implementation details from the design are combined with the per-pin parasitic package
		/// information to create a custom IBIS model for the design.
		/// Because the write_ibis command incorporates design information into the IBIS Model, you
		/// must have an RTL, Netlist, or Implemented Design open when running this command.
		///
		/// The following example exports all buffer models for the target device, eliminates truncation of
		/// signal names, and specifies the file name and path to write:
		/// write_ibis -allmodels -truncate 0 C:/Data/FPGA_Design/ibisOut.txt
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1826
		/// </summary>
		/// <param name="file">(Required) Output file name. The .ibs extension is optional.</param>
		/// <param name="force">(Optional) Overwrite existing .ibs file</param>
		/// <param name="allmodels">
		/// (Optional)
		/// Include all available buffer models for this architecture. By
		/// default, only buffer models used by the floorplan are
		/// included.
		/// </param>
		/// <param name="nopin">
		/// (Optional)
		/// Disable inclusion of the per-pin modeling of the package
		/// (path from the die pad to the package pin). Package is
		/// reduced to a single RLC transmission line model applied to
		/// all pins and defined in the [Package] section. Default: This
		/// option is not set. IBISWriter includes per-pin modeling of
		/// the package as RLC matrices in the [Define Package Model]
		/// section if this data is available.
		/// </param>
		/// <param name="no_pin_mapping">
		/// (Optional)
		/// Do not output the [Pin Mapping] section for ultrascale,
		/// ultrascale plus, and versal.
		/// </param>
		/// <param name="truncate">
		/// (Optional)
		/// Maximum length for a signal name in the output file. Names
		/// longer than this will be truncated. This property can be set
		/// to truncate signal name length to 20, 40, or 0 (unlimited).
		/// Default: Truncate signal name length to 40 characters in
		/// accordance with the IBIS version 4.2 specification. Default:
		/// 40
		/// </param>
		/// <param name="component_name">
		/// (Optional)
		/// Specify a new component name for use in multiple FPGA
		/// designs to replace the default.
		/// </param>
		/// <param name="ibs">(Optional) Specify an updated generic IBIS models file.</param>
		/// <param name="pkg">(Optional) Specify an updated per pin parasitic package data file.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>name of the output file</returns>
		public TTCL write_ibis(string file, bool? force = null, bool? allmodels = null, bool? nopin = null, bool? no_pin_mapping = null, string truncate = null, string component_name = null, string ibs = null, string pkg = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_ibis [-force] [-allmodels] [-nopin] [-no_pin_mapping] [-truncate <arg>] [-component_name <arg>] [-ibs <arg>] [-pkg <arg>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_ibis(file, force, allmodels, nopin, no_pin_mapping, truncate, component_name, ibs, pkg, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Write file with inferred xdc timing constraints
		///
		///
		/// TCL Syntax: write_inferred_xdc [-force] [-all] [-append] [-async_clocks] [-all_async_reg] [-clock_groups] [-clocks] [-excl_clocks] [-exceptions] [-io_constraints] [-merge_existing_constraints] [-name <arg>] [-quiet] [-verbose] [<file>]
		///
		/// You can use the write_inferred_xdc to find constraints that should be defined in the open
		/// synthesized or implemented design. Write timing constraints that are automatically generated by
		/// the Vivado timing engine, rather than defined in an existing XDC file and added to the design.
		/// Run write_inferred_xdc -clocks first to define suggested clock and generated clock
		/// constraints. The suggested clock constraints will be defined with a period of 1 ns. You can edit
		/// the recommended constraints to create clocks and generated clocks with the required clock
		/// period to meet the needs of your design.
		/// You can add the edited constraints file into the design using read_xdc, or add_files, and
		/// update_timing.
		/// You may need to run the write_inferred_xdc command multiple times, using various
		/// options like -clock_groups or -async_clocks, to capture all inferred timing constraints
		/// from the fully clocked design. You can use an iterative process of writing and sourcing the
		/// inferred clocked constraints, and then writing and sourcing additional constraint files to capture
		/// all inferred constraints. See the example below for more information.
		/// This command returns a transcript of the process when successful, or returns an error if it fails.
		///
		/// The following example writes the inferred clock constraints in the current design:
		/// write_inferred_xdc -clocks C:/Data/design1_inferred_clocks.xdc
		/// The write_inferred_xdc command may need to be run multiple times to capture all the
		/// inferred constraints, as is shown in this example:
		/// write_inferred_xdc -clocks clocks.xdc
		/// source clocks.xdc
		/// write_inferred_xdc -all all.xdc
		/// source all.xdc
		/// write_inferred_xdc -async_clocks async.xdc
		/// source async.xdc
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1829
		/// </summary>
		/// <param name="file">(Required) Filename to write constraints into</param>
		/// <param name="force">(Optional) Overwrite existing file.</param>
		/// <param name="all">
		/// (Optional)
		/// Generate all constraints except missing clocks which are
		/// generated with the -clocks option
		/// </param>
		/// <param name="append">(Optional) Append the constraints to file, don't overwrite the constraints file</param>
		/// <param name="async_clocks">(Optional) Find asynchronous clock groups</param>
		/// <param name="all_async_reg">
		/// (Optional)
		/// Find the missing ASYNC_REG property for safe and unsafe
		/// Clock Domain Crossing
		/// </param>
		/// <param name="clock_groups">
		/// (Optional)
		/// Find asynchronous and exclusive clock groups, equivalent to
		/// options -async_clocks -excl_clocks
		/// </param>
		/// <param name="clocks">(Optional) Find missing clock definitions</param>
		/// <param name="excl_clocks">(Optional) Find logically and physically exclusive clock groups</param>
		/// <param name="exceptions">(Optional) Find missing exceptions</param>
		/// <param name="io_constraints">(Optional) Find missing input and output delays</param>
		/// <param name="merge_existing_constraints">(Optional) Add existing user defined constraints to the generated constraints</param>
		/// <param name="name">
		/// (Optional)
		/// Start constraints wizard in a GUI panel with this name. Do
		/// other command options can be combined with -name.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_inferred_xdc(string file, bool? force = null, bool? all = null, bool? append = null, bool? async_clocks = null, bool? all_async_reg = null, bool? clock_groups = null, bool? clocks = null, bool? excl_clocks = null, bool? exceptions = null, bool? io_constraints = null, bool? merge_existing_constraints = null, string name = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_inferred_xdc [-force] [-all] [-append] [-async_clocks] [-all_async_reg] [-clock_groups] [-clocks] [-excl_clocks] [-exceptions] [-io_constraints] [-merge_existing_constraints] [-name <arg>] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.write_inferred_xdc(file, force, all, append, async_clocks, all_async_reg, clock_groups, clocks, excl_clocks, exceptions, io_constraints, merge_existing_constraints, name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Write the Memory Map Info of the design to a .mmi file.
		///
		///
		/// TCL Syntax: write_mem_info [-force] [-quiet] [-verbose] <file>
		///
		/// This command writes a memory information (MMI) file defining the BRAM placement and
		/// address ranges to create a memory map of the design.
		/// IMPORTANT! write_mem_info requires an open implemented design so that the memory information
		/// includes the BRAM placement data, as well as the address ranges, required for proper programming.
		/// The memory map information (MMI) file, written by the write_mem_info command, is a text
		/// file that describes how individual Block RAMs on the Xilinx device are grouped together to form
		/// a contiguous address space called an Address Block.
		/// The mem info file (MMI) contains memory mapping information similar to the Block Memory
		/// Map (BMM) file, but in a format that can be read by the updatemem command to merge with a
		/// bitstream (BIT) file. The updatemem command uses the MMI file to identify the physical BRAM
		/// resource that maps to a specific address range. Refer to the Vivado Design Suite User Guide:
		/// Embedded Processor Hardware Design (UG898) for more information on running updatemem.
		/// This command returns the name of the file created, or returns an error if it fails.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1836
		/// </summary>
		/// <param name="file">
		/// (Required)
		/// Design mem info file Values: A filename with alphanumeric
		/// characters and .mmi extension.
		/// </param>
		/// <param name="force">(Optional) Overwrite existing mem info xml file</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The name of the .mmi file</returns>
		public TTCL write_mem_info(string file, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_mem_info [-force] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_mem_info(file, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Write QoR Suggestions to the given file
		///
		///
		/// TCL Syntax: write_qor_suggestions [-strategy_dir <arg>] [-tcl_output_dir <arg>] [-force] [-of_objects <args>] [-quiet] [-verbose] <file>
		///
		/// Write the QoR suggestions generated by the report_qor_suggestions command. You can
		/// combine the suggestions from the latest report with suggestions read into the design with
		/// read_qor_suggestions so that you can manage all suggestions in a single RQS file.
		/// To write out specific QoR suggestions, use the -of_objects option. When this is not specified, all
		/// suggestions will be written.
		/// The recommended way to manage suggestions is using RQS objects. However, it is possible to
		/// view and execute the commands using TCL. Specifying the -tcl_output_dir option writes Tcl
		/// scripts for the automated suggestions that are property based.
		/// Implementation strategies that use machine learning to analyze the design can be generated
		/// running report_qor_suggestions. When specifying the -strategy_dir option. Multiple
		/// TCL files and one RQS file will be written for each strategy. The TCL files aid integration into
		/// project or non project flows. The main RQS file should not be used as the suggestions are
		/// contained in the run specific files along with strategy information.
		/// This command returns the name of the output file created when successful, or returns an error if
		/// it fails.
		///
		/// This example reports QoR suggestions, then writes them to the specified file.
		/// report_qor_suggestions
		/// write_qor_suggestions C:/Data/qor_results.rqs
		/// This example reports QoR suggestions, then writes them to the specified file.
		/// report_qor_suggestions
		/// write_qor_suggestions -strategy_dir C:/Data/strategy_dir C:/Data/
		/// qor_suggestions.rqs
		/// In project mode you must then source the TCL script generated for project mode. There is one
		/// script per run to source. Examples of non project scripts are also given.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1845
		/// </summary>
		/// <param name="file">
		/// (Required)
		/// QoR suggestions file Values: A filename with alphanumeric
		/// characters and .rqs extension.
		/// </param>
		/// <param name="strategy_dir">
		/// (Optional)
		/// Directory to create Strategy RQS & TCL files Values: If
		/// passed a directory path, for each strategy suggested one set
		/// of RQS and TCL files will be generated.
		/// </param>
		/// <param name="tcl_output_dir">
		/// (Optional)
		/// Directory to create TCL files Values: TCL files for the QoR
		/// suggestions will be generated in the provided directory.
		/// </param>
		/// <param name="force">(Optional) Overwrite existing suggestions file</param>
		/// <param name="of_objects">(Optional) List of QoR suggestion objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_qor_suggestions(string file, string strategy_dir = null, string tcl_output_dir = null, bool? force = null, string of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_qor_suggestions [-strategy_dir <arg>] [-tcl_output_dir <arg>] [-force] [-of_objects <args>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_qor_suggestions(file, strategy_dir, tcl_output_dir, force, of_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Export schematic
		///
		///
		/// TCL Syntax: write_schematic [-force] [-format <arg>] [-orientation <arg>] [-scope <arg>] [-name <arg>] [-quiet] [-verbose] <file>
		///
		/// Output the currently opened, or specified Schematic window in the Vivado IDE to a file.
		/// The file can be written as a native ASCII file that can be read back into the Vivado IDE using the
		/// read_schematic command, or can be written as a PDF or SVG file for use outside of the Vivado
		/// Design Suite. This can be useful when documenting IP cores from the IP packager flow, or from
		/// the Vivado IP integrator.
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1848
		/// </summary>
		/// <param name="file">(Required) Output file</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="format">
		/// (Optional)
		/// Values: native or pdf. read_schematic can be used to view
		/// native format. Default: native
		/// </param>
		/// <param name="orientation">(Optional) Values: landscape or portrait</param>
		/// <param name="scope">(Optional) Values: current_page, visible or all Default: current_page</param>
		/// <param name="name">(Optional) Schematic window title</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>name of the output file</returns>
		public TTCL write_schematic(string file, bool? force = null, string format = null, string orientation = null, string scope = null, string name = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_schematic [-force] [-format <arg>] [-orientation <arg>] [-scope <arg>] [-name <arg>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_schematic(file, force, format, orientation, scope, name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// write_sdf command generates flat sdf delay files for event simulation
		///
		///
		/// TCL Syntax: write_sdf [-process_corner <arg>] [-cell <arg>] [-rename_top <arg>] [-force] [-mode <arg>] [-gzip] [-quiet] [-verbose] <file>
		///
		/// Writes the timing delays for cells in the design to a Standard Delay Format (SDF) file.
		/// The output SDF file can be used by the write_verilog command to create Verilog netlists for
		/// static timing analysis and timing simulation.
		///
		/// The following example writes an SDF file to the specified directory:
		/// write_sdf C:/Data/FPGA_Design/designOut.sdf
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1851
		/// </summary>
		/// <param name="file">(Required) File name</param>
		/// <param name="process_corner">
		/// (Optional)
		/// Specify process corner for which SDF delays are required;
		/// Values: slow, fast Default: slow
		/// </param>
		/// <param name="cell">(Optional) Root of the design to write, e.g. des.subblk.cpu Default: whole design</param>
		/// <param name="rename_top">
		/// (Optional)
		/// Replace name of top module with custom name e.g. netlist
		/// Default: new top module name
		/// </param>
		/// <param name="force">(Optional) Overwrite existing SDF file</param>
		/// <param name="mode">
		/// (Optional)
		/// Specify sta (Static Timing Analysis) or timesim (Timing
		/// Simulation) mode for SDF Default: timesim
		/// </param>
		/// <param name="gzip">(Optional) write gzipped SDF</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_sdf(string file, string process_corner = null, string cell = null, string rename_top = null, bool? force = null, string mode = null, bool? gzip = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_sdf [-process_corner <arg>] [-cell <arg>] [-rename_top <arg>] [-force] [-mode <arg>] [-gzip] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_sdf(file, process_corner, cell, rename_top, force, mode, gzip, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Export the current netlist in Verilog format
		///
		///
		/// TCL Syntax: write_verilog [-cell <arg>] [-mode <arg>] [-lib] [-port_diff_buffers] [-write_all_overrides] [-keep_vcc_gnd] [-rename_top <arg>] [-sdf_anno <arg>] [-sdf_file <arg>] [-force] [-include_xilinx_libs] [-logic_function_stripped] [-quiet] [-verbose] <file>
		///
		/// Write a Verilog netlist of the current design or from a specific cell of the design to the specified
		/// file or directory. The output is a IEEE 1364-2001 compliant Verilog HDL file that contains netlist
		/// information obtained from the input design files.
		/// You can output a complete netlist of the design or specific cell, or output a port list for the
		/// design, or a Verilog netlist for simulation or static timing analysis.
		///
		/// The following example writes a Verilog simulation netlist file for the whole design to the specified
		/// file and path:
		/// write_verilog C:/Data/my_verilog.v
		/// In the following example, because the -mode timesim and -sdf_anno options are specified,
		/// the $sdf_annotate statement will be added to the Verilog netlist. However, since the -
		/// sdf_file option is not specified, the SDF file is assumed to have the same name as the Verilog
		/// output file, with an .sdf file extension:
		/// write_verilog C:/Data/my_verilog.net -mode timesim -sdf_anno true
		/// Note: The SDF filename written to the $sdf_annotate statement will be my_verilog.sdf.
		/// In the following example, the functional simulation mode is specified, the option to keep VCC
		/// and GND primitives in the output simulation netlist is enabled, and the output file is specified:
		/// write_verilog -mode funcsim -keep_vcc_gnd out.v
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1853
		/// </summary>
		/// <param name="file">(Required) Which file to write</param>
		/// <param name="cell">(Optional) Root of the design to write, e.g. des.subblk.cpu Default: whole design</param>
		/// <param name="mode">
		/// (Optional)
		/// Values: design, pin_planning, synth_stub, sta, funcsim,
		/// timesim Default: design
		/// </param>
		/// <param name="lib">(Optional) Write each library into a separate file</param>
		/// <param name="port_diff_buffers">(Optional) Output differential buffers when writing in -port mode</param>
		/// <param name="write_all_overrides">
		/// (Optional)
		/// Write parameter overrides on Xilinx primitives even if the
		/// override value is the same as the default value
		/// </param>
		/// <param name="keep_vcc_gnd">
		/// (Optional)
		/// Don't replace VCC/GND instances by literal constants on
		/// load terminals. For simulation modes only.
		/// </param>
		/// <param name="rename_top">
		/// (Optional)
		/// Replace top module name with custom name e.g. netlist
		/// Default: new top module name
		/// </param>
		/// <param name="sdf_anno">(Optional) Specify if sdf_annotate system task statement is generated</param>
		/// <param name="sdf_file">(Optional) Full path to sdf file location Default: <file>.sdf</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="include_xilinx_libs">
		/// (Optional)
		/// Include simulation models directly in netlist instead of
		/// linking to library
		/// </param>
		/// <param name="logic_function_stripped">
		/// (Optional)
		/// Convert INIT strings on LUTs & RAMBs to fixed values.
		/// Resulting netlist will not behave correctly.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>the name of the output file or directory</returns>
		public TTCL write_verilog(string file, string cell = null, string mode = null, bool? lib = null, bool? port_diff_buffers = null, bool? write_all_overrides = null, bool? keep_vcc_gnd = null, string rename_top = null, string sdf_anno = null, string sdf_file = null, bool? force = null, bool? include_xilinx_libs = null, bool? logic_function_stripped = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_verilog [-cell <arg>] [-mode <arg>] [-lib] [-port_diff_buffers] [-write_all_overrides] [-keep_vcc_gnd] [-rename_top <arg>] [-sdf_anno <arg>] [-sdf_file <arg>] [-force] [-include_xilinx_libs] [-logic_function_stripped] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_verilog(file, cell, mode, lib, port_diff_buffers, write_all_overrides, keep_vcc_gnd, rename_top, sdf_anno, sdf_file, force, include_xilinx_libs, logic_function_stripped, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Export the current netlist in VHDL format
		///
		///
		/// TCL Syntax: write_vhdl [-cell <arg>] [-mode <arg>] [-lib] [-port_diff_buffers] [-write_all_overrides] [-keep_vcc_gnd] [-rename_top <arg>] [-arch_only] [-force] [-include_xilinx_libs] [-quiet] [-verbose] <file>
		///
		/// Write a VHDL netlist of the current design or from a specific cell of the design to the specified
		/// file or directory.
		/// The output of this command is a VHDL IEEE 1076.4 VITAL-2000 compliant VHDL file that
		/// contains netlist information obtained from the input design files. You can output a complete
		/// netlist of the design or specific cell, or output a port list for the design.
		///
		/// The following example writes a VHDL simulation netlist file for the whole design to the specified
		/// file and path:
		/// write_vhdl C:/Data/bft_top.vhd
		/// In the following example the entity definition of the top-level module is not output to the VHDL
		/// netlist:
		/// write_vhdl C:/Data/vhdl_arch_only.vhd -arch_only
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1857
		/// </summary>
		/// <param name="file">(Required) Which file to write</param>
		/// <param name="cell">(Optional) Root of the design to write, e.g. des.subblk.cpu Default: whole design</param>
		/// <param name="mode">
		/// (Optional)
		/// Output mode. Valid values: funcsim, pin_planning,
		/// synth_stub Default: funcsim
		/// </param>
		/// <param name="lib">(Optional) Write each library into a separate file</param>
		/// <param name="port_diff_buffers">(Optional) Output differential buffers when writing in -port mode</param>
		/// <param name="write_all_overrides">
		/// (Optional)
		/// Write parameter overrides on Xilinx primitives even if the
		/// same as the default value
		/// </param>
		/// <param name="keep_vcc_gnd">
		/// (Optional)
		/// Don't replace VCC/GND instances by literal constants on
		/// load terminals. For simulation modes only.
		/// </param>
		/// <param name="rename_top">
		/// (Optional)
		/// Replace top module name with custom name e.g. netlist
		/// Default: new top module name
		/// </param>
		/// <param name="arch_only">
		/// (Optional)
		/// Write only the architecture, not the entity declaration for the
		/// top cell
		/// </param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="include_xilinx_libs">
		/// (Optional)
		/// Include simulation models directly in netlist instead of
		/// linking to library
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>the name of the output file or directory</returns>
		public TTCL write_vhdl(string file, string cell = null, string mode = null, bool? lib = null, bool? port_diff_buffers = null, bool? write_all_overrides = null, bool? keep_vcc_gnd = null, string rename_top = null, bool? arch_only = null, bool? force = null, bool? include_xilinx_libs = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_vhdl [-cell <arg>] [-mode <arg>] [-lib] [-port_diff_buffers] [-write_all_overrides] [-keep_vcc_gnd] [-rename_top <arg>] [-arch_only] [-force] [-include_xilinx_libs] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_vhdl(file, cell, mode, lib, port_diff_buffers, write_all_overrides, keep_vcc_gnd, rename_top, arch_only, force, include_xilinx_libs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// Writes constraints to a Xilinx Design Constraints (XDC) file. The default file extension for a XDC
		/// file is .xdc.
		///
		///
		/// TCL Syntax: write_xdc [-no_fixed_only] [-constraints <arg>] [-cell <arg>] [-sdc] [-no_tool_comments] [-force] [-exclude_timing] [-exclude_physical] [-add_netlist_placement] [-logic_function_stripped] [-type <args>] [-quiet] [-verbose] [<file>]
		///
		/// Writes constraints to a Xilinx® Design Constraints file (XDC). The XDC can be exported from the
		/// top-level, which is the default, or from a specific hierarchical cell.
		/// IMPORTANT! The write_xdc command writes the constraints to the specified file in the same order they
		/// are added to or executed in the design.
		/// The write_xdc command lets you write invalid XDC constraints so that you can quickly report
		/// constraints that have been ignored by the Vivado Design Suite due to a problem with the way
		/// the constraint is written or applied. This is useful for debugging constraint files applied in specific
		/// designs.
		/// This command can be used to create an XDC file from a design with UCF files. All constraints
		/// from the active constraint fileset will be exported to the XDC, even if they come from multiple
		/// files.
		/// TIP: The write_xdc command will not convert all UCF constraints into XDC format, and is not intended to
		/// automatically convert UCF based designs to XDC. Refer to the Vivado Design Suite Migration Methodology
		/// Guide (UG911) for more information on migrating UCF constraints to XDC.
		///
		/// The following example writes the valid and invalid constraints, including both fixed and unfixed
		/// cells, to the specified file:
		/// write_xdc -no_fixed_only -constraints all C:/Data/design.xdc
		/// This example writes only the invalid constraints, including both fixed and unfixed cells, to the
		/// specified file:
		/// write_xdc -constraints invalid C:/Data/bad_constraints.xdc
		/// The following example writes the physical constraints only, including any placement constraints
		/// defined in any netlist source files:
		/// write_xdc -exclude_timing -add_netlist_placement C:/Data/physical.xdc
		///
		/// See ug835-vivado-tcl-commands.pdf, page 1862
		/// </summary>
		/// <param name="file">(Required) Output constraints to the specified XDC file.</param>
		/// <param name="no_fixed_only">
		/// (Optional)
		/// Export fixed and non-fixed placement (by default only fixed
		/// placement is exported)
		/// </param>
		/// <param name="constraints">
		/// (Optional)
		/// Include constraints that are flagged invalid Values: valid,
		/// invalid, all Default: valid
		/// </param>
		/// <param name="cell">(Optional) Hierarchical cell for which constraints are exported.</param>
		/// <param name="sdc">(Optional) Export all timing constriants in SDC compatible format.</param>
		/// <param name="no_tool_comments">
		/// (Optional)
		/// Don't write verbose tool generated comments to the xdc
		/// when translating from ucf.
		/// </param>
		/// <param name="force">(Optional) Overwrite existing file.</param>
		/// <param name="exclude_timing">(Optional) Don't export timing constraints.</param>
		/// <param name="exclude_physical">(Optional) Don't export physical constraints.</param>
		/// <param name="add_netlist_placement">(Optional) Export netlist placement constraints.</param>
		/// <param name="logic_function_stripped">
		/// (Optional)
		/// Write disable_timing constraints which are associated with
		/// having previously run write_edif with its -
		/// logic_function_stripped option.
		/// </param>
		/// <param name="type">
		/// (Optional)
		/// Types of constraint to export. Values: timing, io, misc, waiver
		/// and physical. If not specified, all constraints will be
		/// exported.
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_xdc(string file, bool? no_fixed_only = null, string constraints = null, string cell = null, bool? sdc = null, bool? no_tool_comments = null, bool? force = null, bool? exclude_timing = null, bool? exclude_physical = null, bool? add_netlist_placement = null, bool? logic_function_stripped = null, string type = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_xdc [-no_fixed_only] [-constraints <arg>] [-cell <arg>] [-sdc] [-no_tool_comments] [-force] [-exclude_timing] [-exclude_physical] [-add_netlist_placement] [-logic_function_stripped] [-type <args>] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.write_xdc(file, no_fixed_only, constraints, cell, sdc, no_tool_comments, force, exclude_timing, exclude_physical, add_netlist_placement, logic_function_stripped, type, quiet, verbose));
			return _tcl;
		}
	}
}
