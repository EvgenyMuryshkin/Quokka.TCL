#pragma warning disable IDE1006 // Naming Styles
// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
using System.Collections.Generic;
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
		/// <para>
		/// Auto detect the XPM Libraries that are used in the design and set the XPM_LIBRARIES project<br/>
		/// property.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: auto_detect_xpm [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// This command collects the list of Xilinx Parameterized Macros (XPM) used in RTL design files and<br/>
		/// sets the XPM_LIBRARIES property. Because it identifies XPM used in the RTL source files, it<br/>
		/// must be used after the RTL files are read or added to the design as shown in the example.<br/>
		/// TIP: This command is intended for use in non-project mode, and is not needed for project-based flows.<br/>
		/// This command will find all the XPMs used in the user RTL and update the XPM_LIBRARIES<br/>
		/// property on the current project. Synthesis and simulation will use the XPM_LIBRARIES property<br/>
		/// to properly support these macros.<br/>
		/// This command returns nothing, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reads the specified RTL file, and then uses auto_detect_xpm to define<br/>
		/// the XPM_LIBRARIES used in the files:<br/>
		/// read_verilog ../top_bgRAM_173_0.v<br/>
		/// read_xdc ../top_bgRAM_173_0.xdc<br/>
		/// auto_detect_xpm<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 116<br/>
		/// </para>
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
		/// <para>
		/// Add a hw_emu Xilinx Shell Archive to an existing hw Xilinx Shell Archive<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: combine_hw_platforms [-hw &lt;arg&gt;] [-hw_emu &lt;arg&gt;] [-o &lt;arg&gt;] [-add_digest] [-force] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 153<br/>
		/// </para>
		/// </summary>
		/// <param name="hw">
		/// <para>
		/// (Optional)<br/>
		/// A hw Xilinx Shell Archive Values: A filename with<br/>
		/// alphanumeric characters and .xsa extension.<br/>
		/// </para>
		/// </param>
		/// <param name="hw_emu">
		/// <para>
		/// (Optional)<br/>
		/// A hw_emu Xilinx Shell Archive Values: A filename with<br/>
		/// alphanumeric characters and .xsa extension.<br/>
		/// </para>
		/// </param>
		/// <param name="o">
		/// <para>
		/// (Optional)<br/>
		/// The (optional) output Xilinx Shell Archive. If not specified,<br/>
		/// the hw_emu will be added to the hw file, overwriting the<br/>
		/// original file. Values: A filename with alphanumeric<br/>
		/// characters and .xsa extension.<br/>
		/// </para>
		/// </param>
		/// <param name="add_digest">(Optional) Remove this!!!</param>
		/// <param name="force">(Optional) Overwrite existing Xilinx Shell Archive file</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL combine_hw_platforms(String hw = null, String hw_emu = null, String o = null, bool? add_digest = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: combine_hw_platforms [-hw <arg>] [-hw_emu <arg>] [-o <arg>] [-add_digest] [-force] [-quiet] [-verbose]
			_tcl.Entry(_builder.combine_hw_platforms(hw, hw_emu, o, add_digest, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Enable/disable WebTalk to send software, IP and device usage statistics to Xilinx. Note: WebTalk<br/>
		/// is always enabled for WebPACK users. WebTalk ignores user and install preference when a<br/>
		/// bitstream is generated using the WebPACK license. If a design is using a device contained in<br/>
		/// WebPACK and a WebPACK license is available, the WebPACK license will be used. To change<br/>
		/// this, please see answer record 34746.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: config_webtalk [-info] [-user &lt;arg&gt;] [-install &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// WebTalk is a secure design data collection feature of Xilinx software that helps Xilinx understand<br/>
		/// how you are using Xilinx devices, software, and Intellectual Property (IP).<br/>
		/// This command returns the current state of the WebTalk feature for the current user and software<br/>
		/// installation. You can also enable or disable WebTalk to send software, IP and device usage<br/>
		/// statistics to Xilinx. No data is sent if you disable WebTalk, except for the use of the WebPACK<br/>
		/// license to generate a bitstream.<br/>
		/// Participation in WebTalk is voluntary, except for the use of the WebPACK license. WebTalk data<br/>
		/// transmission is mandatory, and is always enabled for WebPACK users. WebTalk ignores user and<br/>
		/// install preference when a bitstream is generated using the WebPACK license.<br/>
		/// Note: If a design is using a device contained in WebPACK and a WebPACK license is available, the<br/>
		/// WebPACK license will be used. To change this, please see answer record 34746.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example returns the current state of the WebTalk configuration:<br/>
		/// config_webtalk -info<br/>
		/// INFO: [Coretcl-120] Webtalk has been disabled by the current user.<br/>
		/// INFO: [Coretcl-123] Webtalk has been enabled for the current installation.<br/>
		/// INFO: [Coretcl-110] This combination of user/install settings means that<br/>
		/// WebTalk is currently disabled.<br/>
		/// The following example enables WebTalk for the current user:<br/>
		/// config_webtalk -user on<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 192<br/>
		/// </para>
		/// </summary>
		/// <param name="info">(Optional) Show whether WebTalk is currently enabled or disabled</param>
		/// <param name="user">
		/// <para>
		/// (Optional)<br/>
		/// Enable/disable WebTalk for the current user. Specify either<br/>
		/// 'on' to enable or 'off' to disable. Default: empty<br/>
		/// </para>
		/// </param>
		/// <param name="install">
		/// <para>
		/// (Optional)<br/>
		/// Enable/disable WebTalk for all users of the current<br/>
		/// installation. Specify either 'on' to enable or 'off' to disable.<br/>
		/// If you specify 'off', individual users will not be able to enable<br/>
		/// WebTalk using the -user option. You may need<br/>
		/// administrator rights to use this option. Default: empty<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL config_webtalk(bool? info = null, String user = null, String install = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: config_webtalk [-info] [-user <arg>] [-install <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.config_webtalk(info, user, install, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Generate a port on a given reconfigurable cell<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: create_port_on_reconfigurable_module [-cell &lt;arg&gt;] [-port &lt;arg&gt;] [-direction &lt;arg&gt;] [-from &lt;arg&gt;] [-to &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 338<br/>
		/// </para>
		/// </summary>
		/// <param name="cell">(Optional) (Required) specify the HD.RECONFIGURABLE cell name for port punching</param>
		/// <param name="port">
		/// <para>
		/// (Optional)<br/>
		/// (Required) specify the newly added port name on given<br/>
		/// HD.RECONFIGURABLE cell<br/>
		/// </para>
		/// </param>
		/// <param name="direction">
		/// <para>
		/// (Optional)<br/>
		/// (Required) specify the direction of ports, it could be either<br/>
		/// INPUT, OUTPUT or INOUT<br/>
		/// </para>
		/// </param>
		/// <param name="from">(Optional) (Optional) specify the lower boundary of port bus Default: -1</param>
		/// <param name="to">(Optional) (Optional) specify the higher boundary of port bus Default: -1</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL create_port_on_reconfigurable_module(String cell = null, String port = null, String direction = null, String from = null, String to = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: create_port_on_reconfigurable_module [-cell <arg>] [-port <arg>] [-direction <arg>] [-from <arg>] [-to <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.create_port_on_reconfigurable_module(cell, port, direction, from, to, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Decrypt an AES-GCM encrypted bitstream<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: decrypt_bitstream -encrypted_file &lt;arg&gt; -keyfile &lt;arg&gt; [-force] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// During implementation of secure encrypted UltraScale architecture designs, bitstream-level<br/>
		/// verification must be performed on the final bitstream against the "golden" bitstream of the Xilinx<br/>
		/// tested Security Monitor (SecMon) IP.<br/>
		/// The decrypt_bitstream command takes an AES-GCM encrypted bitstream file (.bit<br/>
		/// or .rbt) from an implemented design that incorporates the SecMon IP, and an encryption key<br/>
		/// file (.nky or .nkz), and returns an unencrypted bitstream file. The decrypted bitstream can then<br/>
		/// be used to complete the bitstream verification process.<br/>
		/// This command returns the requested file if successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 426<br/>
		/// </para>
		/// </summary>
		/// <param name="encrypted_file">(Required) Input AES-GCM encrypted bitstream (.bit or .rbt)</param>
		/// <param name="keyfile">(Required) File containing encryption keys</param>
		/// <param name="file">(Required) Output decrypted bitstream (.bit, .bin or .rbt)</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL decrypt_bitstream(String encrypted_file, String keyfile, TCLObject file, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: decrypt_bitstream -encrypted_file <arg> -keyfile <arg> [-force] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.decrypt_bitstream(encrypted_file, keyfile, file, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Encrypt files in place with a language specific key file in IEEE 1735. no default<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: encrypt [-key &lt;arg&gt;] -lang &lt;arg&gt; [-ext &lt;arg&gt;] [-quiet] [-verbose] &lt;files&gt;...
		/// <br/>
		/// <para>
		/// TIP: The encrypt command is provided with limited access, and requires a special license to use.<br/>
		/// Allows anyone with an encryption license to encrypt Verilog or VHDL files using the IEEE 1735<br/>
		/// encryption standard.<br/>
		/// Encrypted files can be provided by third-party IP providers to protect their intellectual property,<br/>
		/// while still enabling the Vivado Design Suite to read the encrypted files for synthesis and<br/>
		/// simulation. The data is in plain text prior to encryption.<br/>
		/// IMPORTANT! Unless the -ext option is used, the specified files are encrypted in place, overwriting the<br/>
		/// input files with the encrypted files.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 505<br/>
		/// </para>
		/// </summary>
		/// <param name="lang">(Required) HDL language of the input/output file</param>
		/// <param name="files">(Required) Files to be encrypted in place</param>
		/// <param name="key">(Optional) key file to be used to encrypt; if absent, use embedded keys</param>
		/// <param name="ext">
		/// <para>
		/// (Optional)<br/>
		/// extension to use for encrypted file; the original source files<br/>
		/// will be preserved.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL encrypt(String lang, TCLObjectList files, String key = null, String ext = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: encrypt [-key <arg>] -lang <arg> [-ext <arg>] [-quiet] [-verbose] <files>...
			_tcl.Entry(_builder.encrypt(lang, files, key, ext, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Generate a base platform based on a given routed checkpoint<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: generate_base_platform [-source &lt;arg&gt;] [-reconfig_platform &lt;arg&gt;] [-base_platform &lt;arg&gt;] [-reconfig_platform_prefix &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 539<br/>
		/// </para>
		/// </summary>
		/// <param name="source">(Optional) (Required) Specify routed checkpoint path</param>
		/// <param name="reconfig_platform">(Optional) (Required) Specify reconfigurable platform module name</param>
		/// <param name="base_platform">
		/// <para>
		/// (Optional)<br/>
		/// (Optional) Specify the output file name, the default file<br/>
		/// name is 'base_platform'<br/>
		/// </para>
		/// </param>
		/// <param name="reconfig_platform_prefix">
		/// <para>
		/// (Optional)<br/>
		/// (Optional) Specify wrapper port name prefix from<br/>
		/// reconfigurable platform module, the default prefix is 'RL_'<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL generate_base_platform(String source = null, String reconfig_platform = null, String base_platform = null, String reconfig_platform_prefix = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_base_platform [-source <arg>] [-reconfig_platform <arg>] [-base_platform <arg>] [-reconfig_platform_prefix <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.generate_base_platform(source, reconfig_platform, base_platform, reconfig_platform_prefix, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write all the simulation .mem files.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: generate_mem_files [-force] [-quiet] [-verbose] &lt;directory&gt;
		/// <br/>
		/// <para>
		/// For embedded processor based designs, with associated Executable Linkable Files (ELF) from the<br/>
		/// Software Development Kit (SDK), this command merges the Block Memory Map (BMM) for the<br/>
		/// design with the program data in the ELF file to generate memory (MEM) files for use during<br/>
		/// simulation.<br/>
		/// The MEM file is a text file that describes how individual Block RAMs on the Xilinx device are<br/>
		/// grouped together to form a contiguous address space called an Address Block, with the ELF data<br/>
		/// mapped into the memory.<br/>
		/// The file names and the number of MEM files generated is determined by the memory map data<br/>
		/// specified by the processor system IP cores, or IP integrator block designs.<br/>
		/// This command returns the directory where the MEM files are written, or returns an error if it<br/>
		/// fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 542<br/>
		/// </para>
		/// </summary>
		/// <param name="directory">
		/// <para>
		/// (Required)<br/>
		/// Directory for exporting .mem files. Values: A directory with<br/>
		/// alphanumeric characters.<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Overwrite existing .mem files</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The name of the directory</returns>
		public TTCL generate_mem_files(TCLObject directory, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_mem_files [-force] [-quiet] [-verbose] <directory>
			_tcl.Entry(_builder.generate_mem_files(directory, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Generate PBLOCK by exclude static<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: generate_pblock [-cell &lt;arg&gt;] [-inverse_pblock &lt;arg&gt;] [-nested_pblock &lt;arg&gt;] [-nested_width &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 544<br/>
		/// </para>
		/// </summary>
		/// <param name="cell">(Optional) Specify cell to add to pblock.</param>
		/// <param name="inverse_pblock">
		/// <para>
		/// (Optional)<br/>
		/// Specify name of the inverse pblock. The pblock will cover<br/>
		/// everything that the static pblock does not.<br/>
		/// </para>
		/// </param>
		/// <param name="nested_pblock">
		/// <para>
		/// (Optional)<br/>
		/// Specify name of nested pblock inside inverse_pblock left<br/>
		/// adjacent to static pblock.<br/>
		/// </para>
		/// </param>
		/// <param name="nested_width">
		/// <para>
		/// (Optional)<br/>
		/// Specify the width of the nested pblock. The nested pblock<br/>
		/// height is the same as the adjacent static pblock. Default: 3<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL generate_pblock(String cell = null, String inverse_pblock = null, String nested_pblock = null, String nested_width = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_pblock [-cell <arg>] [-inverse_pblock <arg>] [-nested_pblock <arg>] [-nested_width <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.generate_pblock(cell, inverse_pblock, nested_pblock, nested_width, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Generate new platform based on base platform and wrapper module<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: generate_rl_platform [-use_source &lt;arg&gt;] [-reconfig_platform &lt;arg&gt;] [-base_platform &lt;arg&gt;] [-platform &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 550<br/>
		/// </para>
		/// </summary>
		/// <param name="use_source">(Optional) Specify wrapper checkpoint path</param>
		/// <param name="reconfig_platform">(Optional) (Required) Specify reconfigurable platform module name</param>
		/// <param name="base_platform">(Optional) (Required) Specify base platform checkpoint path</param>
		/// <param name="platform">
		/// <para>
		/// (Optional)<br/>
		/// (Optional) Specify new platform checkpoint path, the default<br/>
		/// file name is 'rl_platform.dcp'<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL generate_rl_platform(String use_source = null, String reconfig_platform = null, String base_platform = null, String platform = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_rl_platform [-use_source <arg>] [-reconfig_platform <arg>] [-base_platform <arg>] [-platform <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.generate_rl_platform(use_source, reconfig_platform, base_platform, platform, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Move HD.RECONFIGURABLE and related properties to sub-cells<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: generate_shx_platform [-base_platform &lt;arg&gt;] [-wrapper &lt;arg&gt;] [-output &lt;arg&gt;] [-reconfig_platform &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 551<br/>
		/// </para>
		/// </summary>
		/// <param name="base_platform">(Optional) Specify Base Platform DCP path.</param>
		/// <param name="wrapper">(Optional) Specify wrapper DCP path</param>
		/// <param name="output">(Optional) Specify output DCP name.</param>
		/// <param name="reconfig_platform">(Optional) Specify reconfigurable platform name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL generate_shx_platform(String base_platform = null, String wrapper = null, String output = null, String reconfig_platform = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: generate_shx_platform [-base_platform <arg>] [-wrapper <arg>] [-output <arg>] [-reconfig_platform <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.generate_shx_platform(base_platform, wrapper, output, reconfig_platform, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Infer differential pairs, typically for ports just imported from a CSV or XDC file<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: infer_diff_pairs [-file_type &lt;arg&gt;] [-quiet] [-verbose] [&lt;file&gt;...]
		/// <br/>
		/// <para>
		/// The infer_diff_pairs command can be used in an I/O Pin Planning project, after importing<br/>
		/// the I/O pin information using the read_csv or read_xdc command.<br/>
		/// There are several attributes that identify differential pairs in the file: Signal Name, DiffPair Signal,<br/>
		/// DiffPair Type, and I/O Standard.<br/>
		/// The tool will identify differential pairs using the following methods:<br/>
		/// • Matching Diff Pair - This is a direct definition of the two signals which make up a differential<br/>
		/// pair. Two port entries, each have DiffPair Signal values linking to the Signal Name of the other,<br/>
		/// and have complementary DiffPair Type values, one N and one P. The tool checks to ensure<br/>
		/// that the other attributes such as I/O Standard are compatible when forming the diff pair.<br/>
		/// • Unmatched Diff Pair - Two port entries, with complementary DiffPair Type values (one N, one<br/>
		/// P), but only one port has a DiffPair Signal linking to the other Signal Name. The tool will create<br/>
		/// the differential pair if all other attributes are compatible.<br/>
		/// • Single Port Diff Pair - A single port entry with a differential I/O Standard, a DiffPair Type value,<br/>
		/// and a DiffPair Signal that does not otherwise appear in the CSV. The tool will create the<br/>
		/// opposite side of the differential pair (the N or P side), with all properties matching those on<br/>
		/// the original port.<br/>
		/// • Inferred Diff Pair - Two ports entries, with Signal Names that imply the N and P side. The tool<br/>
		/// will infer a differential pair if all other attributes are compatible.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// After reading the port definitions from a CSV or XDC file, the tool will report that some<br/>
		/// differential pairs can be inferred from the data. You can run the infer_diff_pairs command<br/>
		/// to infer these differential pairs if you choose.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example imports the specified XDC file, and then infers differential pairs from the<br/>
		/// file:<br/>
		/// read_xdc C:/Vivado_Install/io_1.xdc<br/>
		/// infer_diff_pairs C:/Vivado_Install/io_1.xdc -file_type xdc<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 997<br/>
		/// </para>
		/// </summary>
		/// <param name="file_type">(Optional) Input file type: 'csv' or 'xdc' Default: file type</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="file">(Optional) Pin Planning CSV or XDC file Default: file</param>
		public TTCL infer_diff_pairs(String file_type = null, bool? quiet = null, bool? verbose = null, TCLObjectList file = null)
		{
			// TCL Syntax: infer_diff_pairs [-file_type <arg>] [-quiet] [-verbose] [<file>...]
			_tcl.Entry(_builder.infer_diff_pairs(file_type, quiet, verbose, file));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Open the Xilinx Shell Archive<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: open_hw_platform [-no_auto_upgrade] [-quiet] [-verbose] [&lt;file&gt;]
		/// <br/>
		/// <para>
		/// Open a Xilinx support archive (XSA) file and extract the Vivado project, block design, and IP from<br/>
		/// the archive. This will create a project directory and project file (.xpr) from the XSA.<br/>
		/// Note: The project will be created in the current working directory, or the directory from which the Vivado<br/>
		/// tool was launched.<br/>
		/// This command returns a transcript of its actions, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example opens the specified XSA, automatically upgrading the IP as needed:<br/>
		/// open_hw_platform C:/Data/zc706.xsa<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1082<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Required)<br/>
		/// Xilinx Shell Archive file Values: A filename with alphanumeric<br/>
		/// characters and .dsa/.xsa extension.<br/>
		/// </para>
		/// </param>
		/// <param name="no_auto_upgrade">(Optional) Disable BD auto upgrade</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The name of the shell file</returns>
		public TTCL open_hw_platform(TCLObject file, bool? no_auto_upgrade = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: open_hw_platform [-no_auto_upgrade] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.open_hw_platform(file, no_auto_upgrade, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Re-establish a parent cell as a Reconfigurable Partition while removing a lower-level<br/>
		/// Reconfigurable Partition when using the Hierarchical Dynamic Function eXchange solution.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: pr_recombine [-cell &lt;arg&gt;] [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1136<br/>
		/// </para>
		/// </summary>
		/// <param name="cell">(Optional) (Required) Specify reconfigurable container module name</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL pr_recombine(String cell = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: pr_recombine [-cell <arg>] [-quiet] [-verbose]
			_tcl.Entry(_builder.pr_recombine(cell, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Subdivide a Reconfigurable Partition into one or more lower-level Reconfigurable Partitions when<br/>
		/// using the Hierarchical Dynamic Function eXchange solution.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: pr_subdivide [-cell &lt;arg&gt;] [-subcells &lt;arg&gt;] [-quiet] [-verbose] [&lt;from_dcp&gt;]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1137<br/>
		/// </para>
		/// </summary>
		/// <param name="cell">(Optional) (Required) Specify parent reconfigurable partition module name</param>
		/// <param name="subcells">(Optional) (Required) Specify child reconfigurable partition module names</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="from_dcp">
		/// <para>
		/// (Optional)<br/>
		/// (Required) Specify OOC synthesized checkpoint path for the<br/>
		/// reconfigurable module specified by option -cell<br/>
		/// </para>
		/// </param>
		public TTCL pr_subdivide(String cell = null, String subcells = null, bool? quiet = null, bool? verbose = null, TCLObject from_dcp = null)
		{
			// TCL Syntax: pr_subdivide [-cell <arg>] [-subcells <arg>] [-quiet] [-verbose] [<from_dcp>]
			_tcl.Entry(_builder.pr_subdivide(cell, subcells, quiet, verbose, from_dcp));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Verify whether the design check points are replaceable on board. This command supports these<br/>
		/// formats: (1) 'pr_verify DCP1 DCP2 -full_check'; (2) 'pr_verify -initial DCP1 -additional {DCP2<br/>
		/// DCP3 DCP4 ...}'; (3) 'pr_verify -in_memory -additional {DCP2 DCP3 ...}'; For format (3), it must<br/>
		/// have an in-memory design opened.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: pr_verify [-full_check] [-file &lt;arg&gt;] [-initial &lt;arg&gt;] [-additional &lt;arg&gt;] [-in_memory] [-quiet] [-verbose] [&lt;file1&gt;] [&lt;file2&gt;]
		/// <br/>
		/// <para>
		/// This command is used to compare design checkpoint files for use in the Partial Reconfiguration<br/>
		/// flow.<br/>
		/// For Partial Reconfigurable designs to work in hardware, the placement and routing of static logic<br/>
		/// must be consistent between all configurations. In addition, proxy logic must be placed in the<br/>
		/// same locations and clock spine routing must match. The pr_verify command compares routed<br/>
		/// design checkpoint files (DCP) created for a Partial Reconfiguration design to verify that all<br/>
		/// imported resources match. For more information refer to the Vivado Design Suite User Guide:<br/>
		/// Dynamic Function eXchange (UG909).<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The two modes for pr_verify let you specify two DCP files to compare, or multiple DCP files<br/>
		/// to compare against the first DCP file. The syntax for the two modes is:<br/>
		/// • pr_verify DCP1 DCP2<br/>
		/// • pr_verify -initial DCP1 -additional {DCP2 DCP3 DCP4}<br/>
		/// The second mode is the same as repeating the pr_verify command to compare each<br/>
		/// additional DCP with the initial DCP, but keeps the initial DCP open to speed the additional<br/>
		/// comparisons:<br/>
		/// pr_verify DCP1 DCP2<br/>
		/// pr_verify DCP1 DCP3<br/>
		/// pr_verify DCP1 DCP4<br/>
		/// This command returns the results of the comparison, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example compares the two corner DCPs, specified with the -additional option,<br/>
		/// against the inital DCP, running a full check on the designs:<br/>
		/// pr_verify -full_check -initial FastConfig.dcp \<br/>
		/// -additional {corner1.dcp corner2.dcp}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1138<br/>
		/// </para>
		/// </summary>
		/// <param name="full_check">
		/// <para>
		/// (Optional)<br/>
		/// Default behavior is to report the first difference only; if this<br/>
		/// option is set to true, pr_verify will report complete<br/>
		/// difference in placement or routing<br/>
		/// </para>
		/// </param>
		/// <param name="file">
		/// <para>
		/// (Optional)<br/>
		/// Filename to output results to. Send output to console if -file<br/>
		/// is not used.<br/>
		/// </para>
		/// </param>
		/// <param name="initial">(Optional) Initial checkpoint (.dcp)</param>
		/// <param name="additional">(Optional) Additional checkpoints (.dcp)</param>
		/// <param name="in_memory">(Optional) use in-memory design for comparison, combined with - additional option</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <param name="file1">(Optional) Design checkpoint (.dcp) file one</param>
		/// <param name="file2">(Optional) Design checkpoint (.dcp) file two</param>
		public TTCL pr_verify(bool? full_check = null, String file = null, String initial = null, String additional = null, bool? in_memory = null, bool? quiet = null, bool? verbose = null, TCLObject file1 = null, TCLObject file2 = null)
		{
			// TCL Syntax: pr_verify [-full_check] [-file <arg>] [-initial <arg>] [-additional <arg>] [-in_memory] [-quiet] [-verbose] [<file1>] [<file2>]
			_tcl.Entry(_builder.pr_verify(full_check, file, initial, additional, in_memory, quiet, verbose, file1, file2));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Read one or more IPIntegrator design files<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_bd [-quiet] [-verbose] &lt;files&gt;...
		/// <br/>
		/// <para>
		/// Read the specified IP subsystem design files, or block designs, into the current project or the in-memory design. This command is similar to the add_files command. The block design file is<br/>
		/// added to the source fileset as it is read.<br/>
		/// RECOMMENDED: Files are read and referenced from their current location, and are not moved into the<br/>
		/// local project directories. To bring the file into the local project, use the import_files command<br/>
		/// instead.<br/>
		/// You can use this command to read block designs into the in-memory design, when running the<br/>
		/// Vivado tool in Non Project mode, in which there is no project file to maintain and manage the<br/>
		/// various project source files. Refer to the Vivado Design Suite User Guide: Design Flows Overview<br/>
		/// (UG892) for more information on Non Project mode.<br/>
		/// This command returns the name of the IP subsystem design files read, or returns an error if it<br/>
		/// fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reads the specified IP subsystem design into the current project:<br/>
		/// read_bd C:/Data/block_designs/design1.bd<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1151<br/>
		/// </para>
		/// </summary>
		/// <param name="files">(Required) IPIntegrator design file name(s)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of IPIntegrator design file objects that were added</returns>
		public TTCL read_bd(TCLObjectList files, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_bd [-quiet] [-verbose] <files>...
			_tcl.Entry(_builder.read_bd(files, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Read a design checkpoint<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_checkpoint [-cell &lt;arg&gt;] [-incremental] [-directive &lt;arg&gt;] [-auto_incremental] [-reuse_objects &lt;args&gt;] [-fix_objects &lt;args&gt;] [-dcp_cell_list &lt;args&gt;] [-quiet] [-verbose] [&lt;file&gt;]
		/// <br/>
		/// <para>
		/// Reads a design checkpoint file (DCP) that contains the netlist, constraints, and may optionally<br/>
		/// have the placement and routing information of an implemented design. You can save design<br/>
		/// checkpoints at any stage in the design using the write_checkpoint command.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The read_checkpoint command simply reads the associated checkpoint file, without opening<br/>
		/// a design or project in-memory. To create a project from the imported checkpoint, use the<br/>
		/// open_checkpoint command instead of read_checkpoint, or use the link_design<br/>
		/// command after read_checkpoint to open the in-memory design from the checkpoint or<br/>
		/// checkpoint files currently read.<br/>
		/// Note: When multiple design checkpoints are open in the Vivado tool, you must use the<br/>
		/// current_project command to switch between the open designs. You can use current_design to<br/>
		/// check which checkpoint is the active design.<br/>
		/// IMPORTANT! The -incremental switch is not intended to merge two DCP files into a single design. It<br/>
		/// applies the placement and routing of the incremental checkpoint to the netlist objects in the current<br/>
		/// design.<br/>
		/// After loading an incremental design checkpoint, you can use the<br/>
		/// report_incremental_reuse command to determine the percentage of physical data reused<br/>
		/// from the incremental checkpoint, in the current design. The place_design and<br/>
		/// route_design commands will run incremental place and route, preserving reused placement<br/>
		/// and routing information and incorporating it into the design solution.<br/>
		/// Reading a design checkpoint with -incremental, loads the physical data into the current in-memory design. To clear out the incremental design data, you must either reload the current<br/>
		/// design, using open_run to open the synthesis run for instance, or read a new incremental<br/>
		/// checkpoint to overwrite the one previously loaded.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example imports the specified checkpoint file into the tool, and then links the<br/>
		/// various design elements to create an in-memory design of the specified name:<br/>
		/// read_checkpoint C:/Data/checkpoint.dcp<br/>
		/// link_design -name Test1<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This example reads a design checkpoint on top of the current design for incremental place and<br/>
		/// route of the design:<br/>
		/// read_checkpoint -incremental C:/Data/routed.dcp<br/>
		/// This example reads a design checkpoint. Incremental algorithms will be used only if the timing is<br/>
		/// nearly met and if there is a high reuse:<br/>
		/// read_checkpoint -auto_incremental C:/Data/routed.dcp<br/>
		/// Reuse and fix the placement and routing associated with the DSPs and Block RAMs:<br/>
		/// read_checkpoint -incremental C:/Data/routed.dcp \<br/>
		/// -reuse_objects [all_rams] -reuse_objects [all_dsps] -fix_objects<br/>
		/// [current_design]<br/>
		/// TIP: The -reuse_objects option could also be written as:<br/>
		/// -reuse_objects [get_cells -hier -filter {PRIMITIVE_TYPE =~ BMEM.*.* ||<br/>
		/// PRIMITIVE_TYPE =~ MULT.dsp.* }]<br/>
		/// The following example reuses the placement and routing of the cells inside the hierarchical<br/>
		/// cpuEngine cell, and fixes the placement of the DSP cells:<br/>
		/// read_checkpoint -incremental C:/Data/routed.dcp -reuse_objects [get_cells<br/>
		/// cpuEngine] -fix_objects [all_dsps]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1153<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Design checkpoint file</param>
		/// <param name="cell">(Optional) Replace this cell with the checkpoint. The cell must be a black box.</param>
		/// <param name="incremental">(Optional) Input design checkpoint file to be used for re-using implementation.</param>
		/// <param name="directive">
		/// <para>
		/// (Optional)<br/>
		/// Mode of behavior (directive) for this command. Please refer<br/>
		/// to Arguments section of this help for values for this option.<br/>
		/// Default: RuntimeOptimized<br/>
		/// </para>
		/// </param>
		/// <param name="auto_incremental">
		/// <para>
		/// (Optional)<br/>
		/// Enters automatic mode for incremental compile. This is less<br/>
		/// aggressive than the standard incremental mode and will<br/>
		/// readily switch from incremental algorithms to the default<br/>
		/// algorithms if results might not be maintained. Should not<br/>
		/// be used with -reuse_objects.<br/>
		/// </para>
		/// </param>
		/// <param name="reuse_objects">(Optional) Reuse only given list of cells, clock regions, SLRs and Designs</param>
		/// <param name="fix_objects">(Optional) Fix only given list of cells, clock regions, SLRs or Design</param>
		/// <param name="dcp_cell_list">
		/// <para>
		/// (Optional)<br/>
		/// A list of cell/dcp pairs, e.g. {&lt;cell1&gt; &lt;dcp1&gt; &lt;cell2&gt; &lt;dcp2&gt;}.<br/>
		/// The option value should be in curly braces.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL read_checkpoint(TCLObject file, String cell = null, bool? incremental = null, String directive = null, bool? auto_incremental = null, TCLParameterList reuse_objects = null, TCLParameterList fix_objects = null, TCLParameterList dcp_cell_list = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_checkpoint [-cell <arg>] [-incremental] [-directive <arg>] [-auto_incremental] [-reuse_objects <args>] [-fix_objects <args>] [-dcp_cell_list <args>] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.read_checkpoint(file, cell, incremental, directive, auto_incremental, reuse_objects, fix_objects, dcp_cell_list, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Import package pin and port placement information<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_csv [-quiet_diff_pairs] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Imports port definition and package pin placement information from a comma separated value<br/>
		/// (CSV) file.<br/>
		/// The port definitions in a CSV file can be imported into an I/O Pin Planning project. In a Pin<br/>
		/// Planning project, importing a CSV file replaces the current port definitions. Any ports in the<br/>
		/// design that are not found in the imported CSV file will be removed.<br/>
		/// In all other projects the port definitions are defined in the source design data, however package<br/>
		/// pin assignments and port attributes can be read from the specified CSV file.<br/>
		/// The ports read from the CSV file can not have spaces in the name, or the tool will return an error.<br/>
		/// The specific format and requirements of the CSV file are described in the Vivado Design Suite User<br/>
		/// Guide: I/O and Clock Planning (UG899).<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example imports a CSV file into an open project:<br/>
		/// read_csv C/Data/pinList.csv<br/>
		/// The following example sets up a new IO Pin Planning project, and then imports the specified CSV<br/>
		/// file into it, and infers any differential pairs in the CSV file:<br/>
		/// create_project myPinPlan C:/Data/myPinPlan -part xc7v285tffg1157-1<br/>
		/// set_property design_mode PinPlanning [current_fileset]<br/>
		/// open_io_design -name io_1<br/>
		/// read_csv C:/Data/import.csv<br/>
		/// infer_diff_pairs -filetype csv C:/Data/import.csv<br/>
		/// Note: The design_mode property on the source fileset is what determines the nature of the project.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1157<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Pin Planning CSV file</param>
		/// <param name="quiet_diff_pairs">
		/// <para>
		/// (Optional)<br/>
		/// Suppress warnings about differential pair inference when<br/>
		/// importing I/O ports<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL read_csv(TCLObject file, bool? quiet_diff_pairs = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_csv [-quiet_diff_pairs] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.read_csv(file, quiet_diff_pairs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Read one or more EDIF or NGC files<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_edif [-quiet] [-verbose] &lt;files&gt;
		/// <br/>
		/// <para>
		/// Imports an EDIF or NGC netlist file into the Design Source fileset of the current project.<br/>
		/// IMPORTANT! NGC format files are not supported in the Vivado Design Suite for UltraScale devices. It is<br/>
		/// recommended that you regenerate the IP using the Vivado Design Suite IP customization tools with native<br/>
		/// output products. Alternatively, you can use the NGC2EDIF command to migrate the NGC file to EDIF<br/>
		/// format for importing. For more information refer to the ISE to Vivado Design Suite Migration Guide<br/>
		/// (UG911).<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example imports an EDIF file into the open project:<br/>
		/// read_edif C/Data/bft_top.edf<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1159<br/>
		/// </para>
		/// </summary>
		/// <param name="files">(Required) EDIF or NGC file name(s)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of file objects that were added</returns>
		public TTCL read_edif(TCLObject files, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_edif [-quiet] [-verbose] <files>
			_tcl.Entry(_builder.read_edif(files, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Read one or more IP files<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_ip [-quiet] [-verbose] &lt;files&gt;
		/// <br/>
		/// <para>
		/// Read the specified list of IP files (XCI) and add them to the design and the current fileset. Files are<br/>
		/// added by reference into the current project, just as in the add_files command.<br/>
		/// You can use this command to read the contents of source files into the in-memory design, when<br/>
		/// running the Vivado tool in Non Project mode, in which there is no project file to maintain and<br/>
		/// manage the various project source files. Refer to the Vivado Design Suite User Guide: Design Flows<br/>
		/// Overview (UG892) for more information on Non Project mode.<br/>
		/// When using the read_ip command all output products associated with the IP core, including<br/>
		/// the design checkpoint file (DCP) will be read into the in-memory design.<br/>
		/// TIP: In the project-based design flow, the Vivado tool will automatically generate the necessary output<br/>
		/// products associated with an IP core. However, in a non-project flow you must generate the necessary<br/>
		/// output products using the synth_ip or generate_target commands. For more information on<br/>
		/// working with IP refer to the Vivado Design Suite User Guide: Designing with IP (UG896).<br/>
		/// Use the import_ip command to add the IP cores and import the files into the local project<br/>
		/// directory.<br/>
		/// This command returns the list of files read.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reads the specified IP files:<br/>
		/// read_ip C:/test_ip/char_fifo.xci<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1167<br/>
		/// </para>
		/// </summary>
		/// <param name="files">(Required) IP file name(s)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of IP file objects that were added</returns>
		public TTCL read_ip(TCLObject files, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_ip [-quiet] [-verbose] <files>
			_tcl.Entry(_builder.read_ip(files, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Read one or more data files (.mem .mif .dat).<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_mem [-quiet] [-verbose] &lt;files&gt;...
		/// <br/>
		/// <para>
		/// This command reads memory files of type MEM, DAT, or COE, and adds the files to the in-memory design, or the current project, to initialize BRAM memory for behavioral simulation,<br/>
		/// synthesis and post-synthesis simulation.<br/>
		/// If the memory is not initialized in the design, then it will be initialized to all 0s.<br/>
		/// This command returns the name of the files read, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example:<br/>
		/// read_mem C:/Data/design1.mem<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1172<br/>
		/// </para>
		/// </summary>
		/// <param name="files">(Required) Data (.mem .coe .dat) file name(s)</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of file objects that were added</returns>
		public TTCL read_mem(TCLObjectList files, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_mem [-quiet] [-verbose] <files>...
			_tcl.Entry(_builder.read_mem(files, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Read QoR Suggestions from the given file<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_qor_suggestions [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Read the specified file and extract the QoR suggestions from the file.<br/>
		/// This command returns the name of the QoR file read, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reads the QoR suggestions from the specified file, and then reports the<br/>
		/// QoR suggestions in the open design:<br/>
		/// read_qor_suggestions C:/Data/qor_results.rqs<br/>
		/// report_qor_suggestions -of_objects [get_qor_suggestions]<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1174<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Required)<br/>
		/// QoR suggestions file Values: Path to the QoR suggestions<br/>
		/// file, typically ending with .rqs.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL read_qor_suggestions(TCLObject file, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_qor_suggestions [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.read_qor_suggestions(file, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Import simulation data in saif format<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_saif [-strip_path &lt;arg&gt;] [-no_strip] [-out_file &lt;arg&gt;] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Reads a Switching Activity Interchange Format (SAIF) file for use during power analysis by the<br/>
		/// report_power command, or power optimization by power_opt_design. The read_saif<br/>
		/// command will annotate the design nodes with activity from the SAIF file and estimate power<br/>
		/// appropriately.<br/>
		/// Running report_power or power_opt_design after reading the SAIF file will use the activity<br/>
		/// rates from the specified file during optimization and analysis.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example:<br/>
		/// read_saif -strip_path design/top/F1 C:/Data/design1.saif<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1176<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Specifies the name of the SAIF file to be read</param>
		/// <param name="strip_path">
		/// <para>
		/// (Optional)<br/>
		/// Specifies the name of the instance of the current design as<br/>
		/// it appears in the SAIF file<br/>
		/// </para>
		/// </param>
		/// <param name="no_strip">(Optional) Do not strip first two levels of hierarchy from SAIF file</param>
		/// <param name="out_file">
		/// <para>
		/// (Optional)<br/>
		/// Specifies the name of the output file that contains nets that<br/>
		/// could not be matched<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL read_saif(TCLObject file, String strip_path = null, bool? no_strip = null, String out_file = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_saif [-strip_path <arg>] [-no_strip] [-out_file <arg>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.read_saif(file, strip_path, no_strip, out_file, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Import schematic<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_schematic [-name &lt;arg&gt;] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Import a native schematic file that was previously exported from the Vivado Design Suite using<br/>
		/// the write_schematic command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1178<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Input file</param>
		/// <param name="name">(Optional) Schematic window title</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>name of the file previously exported</returns>
		public TTCL read_schematic(TCLObject file, String name = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_schematic [-name <arg>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.read_schematic(file, name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Read timing results from Trace STA tool<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_twx [-cell &lt;arg&gt;] [-pblock &lt;arg&gt;] [-quiet] [-verbose] &lt;name&gt; &lt;file&gt;
		/// <br/>
		/// <para>
		/// Imports timing results in the TWX format timing report files generated by the Xilinx Timing<br/>
		/// Reporter And Circuit Evaluator (TRACE) tool. The TWX file can be imported at the top-level,<br/>
		/// which is the default, or at a specific cell-level or relative to a specific Pblock.<br/>
		/// After the TWX files are imported, the timing results display in the Timing Results view in GUI<br/>
		/// mode.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reads the specified TWX file into the top-level of the design:<br/>
		/// read_twx C:/Data/timing_files/bft.twx<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1180<br/>
		/// </para>
		/// </summary>
		/// <param name="name">(Required) Name for the set of results</param>
		/// <param name="file">(Required) Name of the Trace import file</param>
		/// <param name="cell">(Optional) Interpret names in the report file as relative to the specified cell</param>
		/// <param name="pblock">(Optional) Interpret names in the report file as relative to the specified pblock</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL read_twx(TCLObject name, TCLObject file, String cell = null, String pblock = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_twx [-cell <arg>] [-pblock <arg>] [-quiet] [-verbose] <name> <file>
			_tcl.Entry(_builder.read_twx(name, file, cell, pblock, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Read one or more Verilog files<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_verilog [-library &lt;arg&gt;] [-sv] [-quiet] [-verbose] &lt;files&gt;...
		/// <br/>
		/// <para>
		/// Reads Verilog or SystemVerilog source files. This command is similar to the add_files<br/>
		/// command. The Verilog file is added to the source fileset as it is read. If the -library argument<br/>
		/// is specified, the file is added with the Library property defined appropriately.<br/>
		/// You can use this command to read the contents of source files into the in-memory design, when<br/>
		/// running the Vivado tool in Non Project mode, in which there is no project file to maintain and<br/>
		/// manage the various project source files. Refer to the Vivado Design Suite User Guide: Design Flows<br/>
		/// Overview (UG892) for more information on Non Project mode.<br/>
		/// Because SystemVerilog is a superset of the Verilog language, the read_verilog command can<br/>
		/// read both file types. However, for SystemVerilog files, the -sv option needs to be specified for<br/>
		/// read_verilog to enable compilation in the SystemVerilog mode. In this mode, the tool<br/>
		/// recognizes and honors the SystemVerilog keywords and constructs.<br/>
		/// You can have a mixture of both Verilog files (.v files), and SystemVerilog files (.sv files), as well as<br/>
		/// VHDL (using read_vhdl). When the tool compiles these files for synthesis, it creates separate<br/>
		/// "compilation units" for each file type. All files of the same type are compiled together.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reads the specified Verilog file and adds it to the source fileset:<br/>
		/// read_verilog C:/Data/FPGA_Design/new_module.v<br/>
		/// The following example creates two compilation units, one for SystemVerilog files and one for<br/>
		/// Verilog files:<br/>
		/// read_verilog -sv { file1.sv file2.sv file3.sv }<br/>
		/// read_verilog { file1.v file2.v file3.v}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1182<br/>
		/// </para>
		/// </summary>
		/// <param name="files">(Required) Verilog file name(s)</param>
		/// <param name="library">(Optional) Library name (ignored by Vivado synthesis) Default: default lib</param>
		/// <param name="sv">(Optional) Enable system verilog compilation</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of file objects that were added</returns>
		public TTCL read_verilog(TCLObjectList files, String library = null, bool? sv = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_verilog [-library <arg>] [-sv] [-quiet] [-verbose] <files>...
			_tcl.Entry(_builder.read_verilog(files, library, sv, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Read one or more VHDL files<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_vhdl -library &lt;arg&gt; [-vhdl2008] [-quiet] [-verbose] &lt;files&gt;
		/// <br/>
		/// <para>
		/// Reads VHDL source files. This command is similar to the add_files command. The VHDL files<br/>
		/// are added to the source fileset as the file is read. If the -library argument is specified, the file<br/>
		/// is added with the Library property defined.<br/>
		/// You can use this command to read the contents of source files into the in-memory design, when<br/>
		/// running the Vivado tool in Non Project mode, in which there is no project file to maintain and<br/>
		/// manage the various project source files. Refer to the Vivado Design Suite User Guide: Design Flows<br/>
		/// Overview (UG892) for more information on Non Project mode.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reads the specified VHDL file and adds it to the source fileset:<br/>
		/// read_vhdl C:/Data/FPGA_Design/new_module.vhdl<br/>
		/// This example reads multiple specified VHDL 2008 files:<br/>
		/// read_vhdl -vhdl2008 {file1.vhd file2.vhd file3.vhd}<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1184<br/>
		/// </para>
		/// </summary>
		/// <param name="library">(Required) VHDL library</param>
		/// <param name="files">(Required) VHDL file name(s)</param>
		/// <param name="vhdl2008">(Optional) VHDL file is version 2008.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of file objects that were added</returns>
		public TTCL read_vhdl(String library, TCLObject files, bool? vhdl2008 = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_vhdl -library <arg> [-vhdl2008] [-quiet] [-verbose] <files>
			_tcl.Entry(_builder.read_vhdl(library, files, vhdl2008, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// read physical and timing constraints from one of more files.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: read_xdc [-cells &lt;args&gt;] [-ref &lt;arg&gt;] [-quiet_diff_pairs] [-mode &lt;arg&gt;] [-unmanaged] [-no_add] [-quiet] [-verbose] &lt;files&gt;
		/// <br/>
		/// <para>
		/// Imports physical and timing constraints from a Xilinx Design Constraints file (XDC). The XDC is<br/>
		/// imported into the current_instance level of the design hierarchy, which defaults to the top-level of the design, or can be imported into specified cells. When imported at the top-level, the<br/>
		/// specified XDC file is added to the active constraint fileset.<br/>
		/// IMPORTANT! Constraints from the XDC file will overwrite any current constraints of the same name.<br/>
		/// Therefore, exercise some caution when reading a XDC file to be sure you will not overwrite important<br/>
		/// constraints.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command is similar to the add_files command in that the XDC file is added by reference<br/>
		/// rather than imported into the local project directory.<br/>
		/// You can use this command to read the contents of source files into the in-memory design, when<br/>
		/// running the Vivado tool in Non Project mode, in which there is no project file to maintain and<br/>
		/// manage the various project source files. Refer to the Vivado Design Suite User Guide: Design Flows<br/>
		/// Overview (UG892) for more information on Non Project mode.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reads the XDC file and applies it to the current design:<br/>
		/// read_xdc file_1.xdc<br/>
		/// The following example reads the XDC file and applies it ALL instances of the referenced module<br/>
		/// found in the current design:<br/>
		/// read_xdc -ref hex2led file_2.xdc<br/>
		/// The following example reads the XDC file and applies it ONLY to the specified instance within<br/>
		/// the referenced module:<br/>
		/// read_xdc -ref sixty -cells lsbcount file_3.xdc<br/>
		/// The following example reads the XDC file and applies it to the specified instances in the current<br/>
		/// design, even though they are instances of different modules:<br/>
		/// read_xdc -cells {one_decode sixty/msbcount} file_4.xdc<br/>
		/// Note: Multiple cells must be enclosed in quotes, "", or braces, {}.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1186<br/>
		/// </para>
		/// </summary>
		/// <param name="files">(Required) Input file(s) to read</param>
		/// <param name="cells">(Optional) Import constraints for these cells</param>
		/// <param name="ref">(Optional) Import constraints for this ref</param>
		/// <param name="quiet_diff_pairs">
		/// <para>
		/// (Optional)<br/>
		/// Suppress warnings about differential pair inference when<br/>
		/// importing I/O ports<br/>
		/// </para>
		/// </param>
		/// <param name="mode">
		/// <para>
		/// (Optional)<br/>
		/// Import constraints as out_of_context. Values: default,<br/>
		/// out_of_context Default: default<br/>
		/// </para>
		/// </param>
		/// <param name="unmanaged">(Optional) treat this file as unmanaged constraints file</param>
		/// <param name="no_add">(Optional) don't add this file to constraints fileset</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>list of files</returns>
		public TTCL read_xdc(TCLObject files, TCLParameterList cells = null, String @ref = null, bool? quiet_diff_pairs = null, read_xdc_mode? mode = null, bool? unmanaged = null, bool? no_add = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: read_xdc [-cells <args>] [-ref <arg>] [-quiet_diff_pairs] [-mode <arg>] [-unmanaged] [-no_add] [-quiet] [-verbose] <files>
			_tcl.Entry(_builder.read_xdc(files, cells, @ref, quiet_diff_pairs, mode, unmanaged, no_add, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Update and initialize the BRAM initialization strings with contents of elf files.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: refresh_meminit [-quiet] [-verbose]
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1223<br/>
		/// </para>
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
		/// <para>
		/// Write an abstract shell checkpoint of the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_abstract_shell -cell &lt;arg&gt; [-force] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1816<br/>
		/// </para>
		/// </summary>
		/// <param name="cell">(Required) Create an abstract shell for this reconfigurable cell</param>
		/// <param name="file">
		/// <para>
		/// (Required)<br/>
		/// Design checkpoint file Values: A filename with alphanumeric<br/>
		/// characters and .dcp extension.<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Overwrite existing checkpoint file</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The name of the checkpoint file</returns>
		public TTCL write_abstract_shell(String cell, TCLObject file, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_abstract_shell -cell <arg> [-force] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_abstract_shell(cell, file, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Export layout in native, pdf or svg<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_bd_layout [-force] [-format &lt;arg&gt;] [-orientation &lt;arg&gt;] [-scope &lt;arg&gt;] [-hierarchy &lt;arg&gt;] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Write the current open block design in the Vivado IP integrator to the specified file format.<br/>
		/// This command lets you print the block design, output it as a vector graphic file for use in<br/>
		/// documentation related to the design project, or recreate the block design layout in the Vivado IP<br/>
		/// integrator design canvas using the regenerate_bd_layout command.<br/>
		/// This command returns the name of the file written, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example prints the current block design to the specified PDF file:<br/>
		/// write_bd_layout -format pdf -orientation landscape C:/Data/microblaze.pdf<br/>
		/// The following example prints the specified hierarchical cell of the block design to the specified<br/>
		/// SVG file:<br/>
		/// write_bd_layout -format svg -orientation landscape C:/Data/microblaze.svg<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1817<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Output file</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="format">
		/// <para>
		/// (Optional)<br/>
		/// Values: native, pdf or svg. regenerate_bd_layout -layout_file<br/>
		/// can be used with native layout. Default: native<br/>
		/// </para>
		/// </param>
		/// <param name="orientation">(Optional) Values: landscape or portrait</param>
		/// <param name="scope">(Optional) Values: visible or all Default: all</param>
		/// <param name="hierarchy">(Optional) Hierarchy block</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>name of the output file</returns>
		public TTCL write_bd_layout(TCLObject file, bool? force = null, write_bd_layout_format? format = null, write_bd_layout_orientation? orientation = null, write_bd_layout_scope? scope = null, String hierarchy = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_bd_layout [-force] [-format <arg>] [-orientation <arg>] [-scope <arg>] [-hierarchy <arg>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_bd_layout(file, force, format, orientation, scope, hierarchy, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write a bitstream for the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_bitstream [-force] [-verbose] [-raw_bitfile] [-no_binary_bitfile] [-mask_file] [-readback_file] [-logic_location_file] [-bin_file] [-reference_bitfile &lt;arg&gt;] [-cell &lt;arg&gt;] [-no_partial_bitfile] [-quiet] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Writes a bitstream file for the current project. This command must be run on an Implemented<br/>
		/// Design. The bitstream written will be based on the open Implemented Design.<br/>
		/// The files that can be generated by the write_bitstream command include the following:<br/>
		/// • Bit file: The binary bitstream file (.bit).<br/>
		/// • Raw (ASCII) Bit file: A raw bit file (.rbt) that contains the same information as the binary<br/>
		/// bitstream file, but is in ASCII format.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • Mask file: A mask file (.msk) that has mask data in place of the configuration data in the<br/>
		/// bitstream file.<br/>
		/// • Logic Location file: An ASCII logic location file (.ll) that shows the bitstream position of<br/>
		/// latches, flip-flops, LUTs, Block RAMs, and I/O block inputs and outputs.<br/>
		/// • Bin file: A binary file (.bin) containing only the device programming data, without the header<br/>
		/// information found in the standard binary Bit file.<br/>
		/// • Reference Bit file: An incremental bitstream file containing only the differences from the<br/>
		/// current bitstream and a specified reference bitstream.<br/>
		/// The Vivado tool can write a compressed bitstream, if you have enabled compression by setting<br/>
		/// the BITSTREAM.GENERAL.COMPRESS property on the implemented design. Refer to the Vivado<br/>
		/// Design Suite User Guide: Programming and Debugging (UG908) for more information on Device<br/>
		/// Configuration Properties. To enable compression use the following Tcl command:<br/>
		/// set_property BITSTREAM.GENERAL.COMPRESS TRUE [current_design]<br/>
		/// The Vivado Design Suite can also write an encrypted bitstream to protect the intellectual<br/>
		/// property of the design in the bitstream. To create an encrypted bitstream you must first define<br/>
		/// the type of encryption to be used, and the encryption key. You can accomplish this most easily<br/>
		/// using the Encryption page of the Edit Device Properties dialog box in the Vivado IDE. Refer to<br/>
		/// the Vivado Design Suite User Guide: Programming and Debugging (UG908) for more information on<br/>
		/// the Edit Device Properties dialog box.<br/>
		/// You can also enable encryption by manually defining the appropriate properties on the<br/>
		/// implemented design as follows:<br/>
		/// set_property BITSTREAM.ENCRYPTION.ENCRYPT YES [get_designs impl_1]<br/>
		/// set_property BITSTREAM.ENCRYPTION.ENCRYPTKEYSELECT EFUSE [get_designs<br/>
		/// impl_1]<br/>
		/// set_property BITSTREAM.ENCRYPTION.KEY0 8675309 [get_designs impl_1]<br/>
		/// The properties associated with encryption include:<br/>
		/// • BITSTREAM.ENCRYPTION.ENCRYPT - Enables encryption when generating the bitstream<br/>
		/// with write_bitstream. This property accepts a value of YES or NO.<br/>
		/// • BITSTREAM.ENCRYPTION.ENCRYPTKEYSELECT - Specifies the method for storing the<br/>
		/// encryption key on the hardware device. The accepted values are BBRAM and EFUSE, referring<br/>
		/// to battery-backed SRAM or the eFUSE registers on the device.<br/>
		/// CAUTION! eFUSEs are one-time programmable cells on the hardware device, used to store the<br/>
		/// factory-programmed Device DNA, AES-GCM encryption key, and user specified values. Refer to the<br/>
		/// UltraScale Architecture Configuration User Guide (UG570) or 7 Series FPGAs Configuration User Guide<br/>
		/// (UG470) for more information on eFUSE registers.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// • BITSTREAM.ENCRYPTION.KEY0 - Specifies the encryption key to apply to the BBRAM, or<br/>
		/// the eFUSE FUSE_KEY registers on the device. The key can be specified as a 256 bit value, and<br/>
		/// will be required when accessing an encrypted bitstream to program, verify, or readback the<br/>
		/// hw_device.<br/>
		/// TIP: The write_bitstream command will write an NKY file of the same name as the bitstream file<br/>
		/// (with the .nky extension) when the BITSTREAM.ENCRYPTION.KEY0 property is specified. This<br/>
		/// encryption file can then be used in other designs by setting the BITSTREAM.ENCRYPTION.KEYFILE<br/>
		/// property.<br/>
		/// • BITSTREAM.ENCRYPTION.KEYFILE - Specifies an encryption key file (NKY or NKZ) as an<br/>
		/// alternative to setting the ENCRYPTION.KEY0 property. The specified encryption key file will<br/>
		/// be used during bitstream encryption.<br/>
		/// IMPORTANT! If both the BITSTREAM.ENCRYPTION.KEY0 and BITSTREAM.ENCRYPTION.KEYFILE<br/>
		/// properties are defined, the tool will use the encryption key specified by the<br/>
		/// BITSTREAM.ENCRYPTION.KEY0 property and return a message to that effect.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example enables compression and writes a bitstream file of the specified name:<br/>
		/// set_property BITSTREAM.GENERAL.COMPRESS TRUE [current_design]<br/>
		/// write_bitstream design1.bit<br/>
		/// The following example writes both the binary and ASCII forms of the bitstream:<br/>
		/// write_bitstream -raw_bitfile C:/Data/design1<br/>
		/// Note: The appropriate file extension will be added by the tool.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1824<br/>
		/// </para>
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
		/// <param name="no_partial_bitfile">(Optional) Do not write partial bit files for a Dynamic Function eXchange design</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		public TTCL write_bitstream(TCLObject file, bool? force = null, bool? verbose = null, bool? raw_bitfile = null, bool? no_binary_bitfile = null, bool? mask_file = null, bool? readback_file = null, bool? logic_location_file = null, bool? bin_file = null, String reference_bitfile = null, String cell = null, bool? no_partial_bitfile = null, bool? quiet = null)
		{
			// TCL Syntax: write_bitstream [-force] [-verbose] [-raw_bitfile] [-no_binary_bitfile] [-mask_file] [-readback_file] [-logic_location_file] [-bin_file] [-reference_bitfile <arg>] [-cell <arg>] [-no_partial_bitfile] [-quiet] <file>
			_tcl.Entry(_builder.write_bitstream(file, force, verbose, raw_bitfile, no_binary_bitfile, mask_file, readback_file, logic_location_file, bin_file, reference_bitfile, cell, no_partial_bitfile, quiet));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write a bmm file<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_bmm [-force] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// The Block RAM Memory Map (BMM) file is a text file that describes how individual block RAMs<br/>
		/// on an FPGA are grouped together into a contiguous address space called an Address Block.<br/>
		/// The write_bmm command exports BMM information from the current design to the specified<br/>
		/// file. For implemented designs the BMM file will be include placement information. The<br/>
		/// data2mem command uses the BMM file as input to direct the translation of programming data<br/>
		/// into the proper form for use in simulation, device programming, or software development in SDK.<br/>
		/// The command returns the name of the output file, or an error.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1829<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Required)<br/>
		/// Design bmm file Values: A filename with alphanumeric<br/>
		/// characters and .bmm extension.<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Overwrite existing BMM file.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The name of the bmm file</returns>
		public TTCL write_bmm(TCLObject file, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_bmm [-force] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_bmm(file, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Generate a design specific post-configuration BSDL file (.bsd).<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_bsdl [-force] [-bsd &lt;arg&gt;] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Generate a Boundary Scan Description Language (BSDL) file (.bsd) for the current design that<br/>
		/// reflects the post-configuration boundary scan architecture of the target device.<br/>
		/// The boundary scan architecture for the device is changed when the device is configured because<br/>
		/// certain connections between the boundary scan registers and pad may change. These changes<br/>
		/// must be communicated to the boundary scan tester through a post-configuration BSDL file.<br/>
		/// Refer to the Vivado Design Suite User Guide: Programming and Debugging (UG908) for more<br/>
		/// information on the available configuration modes.<br/>
		/// The write_bsdl command reads a pre-configuration BSDL file for the target part from the<br/>
		/// Vivado Design Suite installation area, and combines that with post-configuration data from the<br/>
		/// current design.<br/>
		/// This command returns the name of the output BSDL file, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1831<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Output file name. The .bsd extension is optional.</param>
		/// <param name="force">(Optional) Overwrite existing .bsd file</param>
		/// <param name="bsd">(Optional) Specify an updated generic BSDL file.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>name of the output file</returns>
		public TTCL write_bsdl(TCLObject file, bool? force = null, String bsd = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_bsdl [-force] [-bsd <arg>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_bsdl(file, force, bsd, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Create file(s) for programming flash memory.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_cfgmem [-force] -format &lt;arg&gt; -size &lt;arg&gt; [-interface &lt;arg&gt;] [-checksum] [-disablebitswap] [-loadbit &lt;arg&gt;] [-loaddata &lt;arg&gt;] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// This command formats a design specific configuration bitstream (.bit) file, and any specified<br/>
		/// data files, into a specified memory configuration file format to program into a flash memory<br/>
		/// device using the program_hw_cfgmem command. Supported memory configuration file formats<br/>
		/// are MCS, BIN, and HEX.<br/>
		/// TIP: When you generate a cfgmem file with write_cfgmem , by default the bits within a byte are bit-swapped, or mirrored, compared to bytes in the original input bitstream. You can disable bitswap using the<br/>
		/// -disablebitswap option as described below.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The process whereby the design specific data is loaded or programmed into the Xilinx® FPGA is<br/>
		/// called configuration. The create_hw_cfgmem command defines a flash memory device used<br/>
		/// for configuring and booting the hardware device.<br/>
		/// After the hw_cfgmem object is created, and associated with the hw_device, the configuration<br/>
		/// memory can be programmed with the bitstream and other data from a memory configuration file<br/>
		/// created with the write_cfgmem command. The hw_cfgmem object is programmed using the<br/>
		/// program_hw_cfgmem command.<br/>
		/// The write_cfgmem -loadbit command loads one or more specified bitstream files into the<br/>
		/// memory configuration file, filling the available memory of the device in an upward or downward<br/>
		/// direction from a specified starting address. You can also add data files to the memory<br/>
		/// configuration file, by specifying the starting address to load the file with -loaddata.<br/>
		/// TIP: When using -loadbit and -loaddata to fill the memory of the device, you must exercise care to<br/>
		/// insure that the bitstream and data files fit into the available memory and do not overwrite each other. Any<br/>
		/// data collisions will cause the write_cfgmem command to fail with an error.<br/>
		/// The write_cfgmem command returns a transcript of its process when successful, or returns an<br/>
		/// error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1833<br/>
		/// </para>
		/// </summary>
		/// <param name="format">(Required) Format of the file to generate</param>
		/// <param name="size">(Required) Size of memory that is being targeted in M Bytes (must be power of 2).</param>
		/// <param name="file">(Required) The name of the file to generate</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="interface">(Optional) Interface used to program device. Default: SMAPx8</param>
		/// <param name="checksum">
		/// <para>
		/// (Optional)<br/>
		/// Calculate a 32-bit checksum for each file. Memory will be<br/>
		/// filed with value of 0xFF unless a different byte value is<br/>
		/// specified. Default: 0xFF<br/>
		/// </para>
		/// </param>
		/// <param name="disablebitswap">(Optional) Disable bit swapping in a byte for bitfiles.</param>
		/// <param name="loadbit">(Optional) Load bit files into memory from given address.</param>
		/// <param name="loaddata">(Optional) Load data into memory from given address.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_cfgmem(String format, String size, TCLObject file, bool? force = null, String @interface = null, bool? checksum = null, bool? disablebitswap = null, String loadbit = null, String loaddata = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_cfgmem [-force] -format <arg> -size <arg> [-interface <arg>] [-checksum] [-disablebitswap] [-loadbit <arg>] [-loaddata <arg>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_cfgmem(format, size, file, force, @interface, checksum, disablebitswap, loadbit, loaddata, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write a checkpoint of the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_checkpoint [-force] [-cell &lt;arg&gt;] [-logic_function_stripped] [-encrypt] [-key &lt;arg&gt;] [-incremental_synth] [-quiet] [-verbose] [&lt;file&gt;]
		/// <br/>
		/// <para>
		/// Saves the design at any point in the design process so that you can quickly import it back into the<br/>
		/// tool as needed. A design checkpoint (DCP) can contain the netlist, the constraints, and any<br/>
		/// placement and routing information from the implemented design.<br/>
		/// TIP: In the Project mode, a DCP will not have timing constraints after synthesis. The timing constraints are<br/>
		/// annotated against the design during open_run or link_design commands, or when launching an<br/>
		/// implementation run. To create a DCP with timing constraints, create the design checkpoint after<br/>
		/// opt_design, or after the implementation run completes.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Use the read_checkpoint command to import a checkpoint file.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example creates the specified checkpoint file, overwriting a file of the same name<br/>
		/// if one already exists:<br/>
		/// write_checkpoint C:/Data/checkpoint1 -force<br/>
		/// Note: The tool will add the .dcp extension to the specified file name, and will overwrite an existing<br/>
		/// checkpoint1.dcp file.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1837<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Required)<br/>
		/// Design checkpoint file Values: A filename with alphanumeric<br/>
		/// characters and .dcp extension.<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Overwrite existing checkpoint file</param>
		/// <param name="cell">(Optional) Write a checkpoint of this cell</param>
		/// <param name="logic_function_stripped">
		/// <para>
		/// (Optional)<br/>
		/// Convert INIT strings on LUTs &amp; RAMBs to fixed values. Note<br/>
		/// that the resulting netlist will be nonfunctional.<br/>
		/// </para>
		/// </param>
		/// <param name="encrypt">(Optional) Encrypt unprotected modules using IEEE 1735 IP security version 2</param>
		/// <param name="key">
		/// <para>
		/// (Optional)<br/>
		/// Key file to be used with -encrypt option; Otherwise, use<br/>
		/// Xilinx public key<br/>
		/// </para>
		/// </param>
		/// <param name="incremental_synth">(Optional) export synthesis archive file to be used for re-using implementation.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The name of the checkpoint file</returns>
		public TTCL write_checkpoint(TCLObject file, bool? force = null, String cell = null, bool? logic_function_stripped = null, bool? encrypt = null, String key = null, bool? incremental_synth = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_checkpoint [-force] [-cell <arg>] [-logic_function_stripped] [-encrypt] [-key <arg>] [-incremental_synth] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.write_checkpoint(file, force, cell, logic_function_stripped, encrypt, key, incremental_synth, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Export package pin and port placement information<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_csv [-force] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Writes package pin and port placement information into a comma separated value (CSV) file.<br/>
		/// The specific format and requirements of the CSV file are described in the Vivado Design Suite User<br/>
		/// Guide: I/O and Clock Planning (UG899).<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example exports a CSV file from the current project:<br/>
		/// write_csv C:/Data/pinList.csv<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1840<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Pin Planning CSV file</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>name of the output file</returns>
		public TTCL write_csv(TCLObject file, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_csv [-force] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_csv(file, force, quiet, verbose));
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
		/// <summary>
		/// <para>
		/// Write programmable device image<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_device_image [-force] [-verbose] [-raw_partitions] [-mask_file] [-logic_location_file] [-cell &lt;arg&gt;] [-no_pdi] [-no_partial_pdifile] [-quiet] &lt;file&gt;
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1844<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) The name of the .rcfi and .rnpi files to generate</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="verbose">(Optional) Print write_device_image options</param>
		/// <param name="raw_partitions">(Optional) Write raw CFI and NPI partition files (.rcfi and .rnpi)</param>
		/// <param name="mask_file">(Optional) Write mask file (.msk_cfi)</param>
		/// <param name="logic_location_file">(Optional) Write logic location file (.ll)</param>
		/// <param name="cell">(Optional) Create only partial device image for named cell</param>
		/// <param name="no_pdi">(Optional) Do not generate pdi file</param>
		/// <param name="no_partial_pdifile">(Optional) Do not write partial pdi files for a Dynamic Function eXchange design</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		public TTCL write_device_image(TCLObject file, bool? force = null, bool? verbose = null, bool? raw_partitions = null, bool? mask_file = null, bool? logic_location_file = null, String cell = null, bool? no_pdi = null, bool? no_partial_pdifile = null, bool? quiet = null)
		{
			// TCL Syntax: write_device_image [-force] [-verbose] [-raw_partitions] [-mask_file] [-logic_location_file] [-cell <arg>] [-no_pdi] [-no_partial_pdifile] [-quiet] <file>
			_tcl.Entry(_builder.write_device_image(file, force, verbose, raw_partitions, mask_file, logic_location_file, cell, no_pdi, no_partial_pdifile, quiet));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Export the current netlist as an EDIF file<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_edif [-pblocks &lt;args&gt;] [-cell &lt;arg&gt;] [-force] [-security_mode &lt;arg&gt;] [-logic_function_stripped] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Writes the current netlist as an EDIF file, or outputs the contents of specific Pblocks or<br/>
		/// hierarchical cells as EDIF netlist files.<br/>
		/// In the case of either the -pblocks or -cell option being used, this argument specifies a<br/>
		/// directory name where the EDIF netlist files for each Pblock or cell will be written. The EDIF<br/>
		/// netlist file will be named after the Pblock or cell. If the directory specified does not exist, the tool<br/>
		/// will return an error.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example writes an EDIF netlist file for the whole design to the specified file name:<br/>
		/// write_edif C:/Data/edifOut.edn<br/>
		/// The following example outputs an EDIF netlist for all Pblocks in the design. The files will be<br/>
		/// written to the specified directory.<br/>
		/// write_edif -pblocks [get_pblocks] C:/Data/FPGA_Design/<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1845<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Output file (directory with -pblocks or -cell)</param>
		/// <param name="pblocks">(Optional) Export netlist for these pblocks (not valid with -cell)</param>
		/// <param name="cell">(Optional) Export netlist for this cell (not valid with -pblocks)</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="security_mode">
		/// <para>
		/// (Optional)<br/>
		/// If set to 'all', and some of design needs encryption then<br/>
		/// whole of design will be written to a single encrypted file<br/>
		/// Default: multifile<br/>
		/// </para>
		/// </param>
		/// <param name="logic_function_stripped">(Optional) Convert INIT strings on LUTs &amp; RAMBs to fixed values</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>the name of the output file or directory</returns>
		public TTCL write_edif(TCLObject file, TCLParameterList pblocks = null, String cell = null, bool? force = null, String security_mode = null, bool? logic_function_stripped = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_edif [-pblocks <args>] [-cell <arg>] [-force] [-security_mode <arg>] [-logic_function_stripped] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_edif(file, pblocks, cell, force, security_mode, logic_function_stripped, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write the Xilinx Shell Archive for the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_hw_platform [-fixed] [-force] [-include_bit] [-include_sim_content] [-minimal] [-hw] [-hw_emu] [-quiet] [-verbose] [&lt;file&gt;]
		/// <br/>
		/// <para>
		/// Writes a Xilinx support archive (XSA) of the current design for use as a hardware platform.<br/>
		/// All platforms are dynamically implemented during compilation, meaning that the accelerator logic<br/>
		/// coming is implemented along with some or all of the logic contained in the hardware platform<br/>
		/// design. The XSA represents the required portion of the hardware platform. The hardware<br/>
		/// platform design used to create a XSA consists of a Vivado IP integrator subsystem design with all<br/>
		/// the required board interface IP cores configured and connected to the device I/Os. The Vivado<br/>
		/// project must also include several required XSA and PFM properties needed to define the XSA.<br/>
		/// This command reports the name of the XSA file written, or returns an error if it fails.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example writes the XSA for the current project, overwriting a XSA file of the same<br/>
		/// name if one exists:<br/>
		/// write_hw_platform -force C:/Data/zc702.xsa<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1851<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Required)<br/>
		/// Device Support Archive file Values: A filename with<br/>
		/// alphanumeric characters and .xsa extension.<br/>
		/// </para>
		/// </param>
		/// <param name="fixed">(Optional) Write fixed Shell.</param>
		/// <param name="force">(Optional) Overwrite existing Xilinx Shell Archive file</param>
		/// <param name="include_bit">(Optional) Include bit file(s) in the Shell.</param>
		/// <param name="include_sim_content">(Optional) Include simulaton files in the Shell.</param>
		/// <param name="minimal">(Optional) Add only minimal files in the Shell.</param>
		/// <param name="hw">(Optional) Write shell for use in hardware only.</param>
		/// <param name="hw_emu">(Optional) Write shell for use in hardware emulation only.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The name of the Shell file</returns>
		public TTCL write_hw_platform(TCLObject file, bool? @fixed = null, bool? force = null, bool? include_bit = null, bool? include_sim_content = null, bool? minimal = null, bool? hw = null, bool? hw_emu = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_hw_platform [-fixed] [-force] [-include_bit] [-include_sim_content] [-minimal] [-hw] [-hw_emu] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.write_hw_platform(file, @fixed, force, include_bit, include_sim_content, minimal, hw, hw_emu, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write the unified JSON metadata file for the current design<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_hw_platform_metadata [-quiet] [-verbose] [&lt;file&gt;]
		/// <br/>
		/// <para>
		/// Writes a JSON metadata file for the platform represented by the current design.<br/>
		/// This command returns the name of the JSON file written, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example writes the JSON file for the current project:<br/>
		/// write_hw_platform_metadata C:/Data/zc102_platform.json<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1853<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Required)<br/>
		/// Unified JSON metadata file Values: A filename with<br/>
		/// alphanumeric characters and .json extension.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The name of the unified JSON metadata file</returns>
		public TTCL write_hw_platform_metadata(TCLObject file, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_hw_platform_metadata [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.write_hw_platform_metadata(file, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write IBIS models for current floorplan<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_ibis [-force] [-allmodels] [-nopin] [-no_pin_mapping] [-truncate &lt;arg&gt;] [-component_name &lt;arg&gt;] [-ibs &lt;arg&gt;] [-pkg &lt;arg&gt;] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Writes the IBIS models for the target device in the current design. The netlist and<br/>
		/// implementation details from the design are combined with the per-pin parasitic package<br/>
		/// information to create a custom IBIS model for the design.<br/>
		/// Because the write_ibis command incorporates design information into the IBIS Model, you<br/>
		/// must have an RTL, Netlist, or Implemented Design open when running this command.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example exports all buffer models for the target device, eliminates truncation of<br/>
		/// signal names, and specifies the file name and path to write:<br/>
		/// write_ibis -allmodels -truncate 0 C:/Data/FPGA_Design/ibisOut.txt<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1864<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Output file name. The .ibs extension is optional.</param>
		/// <param name="force">(Optional) Overwrite existing .ibs file</param>
		/// <param name="allmodels">
		/// <para>
		/// (Optional)<br/>
		/// Include all available buffer models for this architecture. By<br/>
		/// default, only buffer models used by the floorplan are<br/>
		/// included.<br/>
		/// </para>
		/// </param>
		/// <param name="nopin">
		/// <para>
		/// (Optional)<br/>
		/// Disable inclusion of the per-pin modeling of the package<br/>
		/// (path from the die pad to the package pin). Package is<br/>
		/// reduced to a single RLC transmission line model applied to<br/>
		/// all pins and defined in the [Package] section. Default: This<br/>
		/// option is not set. IBISWriter includes per-pin modeling of<br/>
		/// the package as RLC matrices in the [Define Package Model]<br/>
		/// section if this data is available.<br/>
		/// </para>
		/// </param>
		/// <param name="no_pin_mapping">
		/// <para>
		/// (Optional)<br/>
		/// Do not output the [Pin Mapping] section for ultrascale,<br/>
		/// ultrascale plus, and versal.<br/>
		/// </para>
		/// </param>
		/// <param name="truncate">
		/// <para>
		/// (Optional)<br/>
		/// Maximum length for a signal name in the output file. Names<br/>
		/// longer than this will be truncated. This property can be set<br/>
		/// to truncate signal name length to 20, 40, or 0 (unlimited).<br/>
		/// Default: Truncate signal name length to 40 characters in<br/>
		/// accordance with the IBIS version 4.2 specification. Default:<br/>
		/// 40<br/>
		/// </para>
		/// </param>
		/// <param name="component_name">
		/// <para>
		/// (Optional)<br/>
		/// Specify a new component name for use in multiple FPGA<br/>
		/// designs to replace the default.<br/>
		/// </para>
		/// </param>
		/// <param name="ibs">(Optional) Specify an updated generic IBIS models file.</param>
		/// <param name="pkg">(Optional) Specify an updated per pin parasitic package data file.</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>name of the output file</returns>
		public TTCL write_ibis(TCLObject file, bool? force = null, bool? allmodels = null, bool? nopin = null, bool? no_pin_mapping = null, String truncate = null, String component_name = null, String ibs = null, String pkg = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_ibis [-force] [-allmodels] [-nopin] [-no_pin_mapping] [-truncate <arg>] [-component_name <arg>] [-ibs <arg>] [-pkg <arg>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_ibis(file, force, allmodels, nopin, no_pin_mapping, truncate, component_name, ibs, pkg, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write file with inferred xdc timing constraints<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_inferred_xdc [-force] [-all] [-append] [-async_clocks] [-all_async_reg] [-clock_groups] [-clocks] [-excl_clocks] [-exceptions] [-io_constraints] [-merge_existing_constraints] [-name &lt;arg&gt;] [-quiet] [-verbose] [&lt;file&gt;]
		/// <br/>
		/// <para>
		/// You can use the write_inferred_xdc to find constraints that should be defined in the open<br/>
		/// synthesized or implemented design. Write timing constraints that are automatically generated by<br/>
		/// the Vivado timing engine, rather than defined in an existing XDC file and added to the design.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// Run write_inferred_xdc -clocks first to define suggested clock and generated clock<br/>
		/// constraints. The suggested clock constraints will be defined with a period of 1 ns. You can edit<br/>
		/// the recommended constraints to create clocks and generated clocks with the required clock<br/>
		/// period to meet the needs of your design.<br/>
		/// You can add the edited constraints file into the design using read_xdc, or add_files, and<br/>
		/// update_timing.<br/>
		/// You may need to run the write_inferred_xdc command multiple times, using various<br/>
		/// options like -clock_groups or -async_clocks, to capture all inferred timing constraints<br/>
		/// from the fully clocked design. You can use an iterative process of writing and sourcing the<br/>
		/// inferred clocked constraints, and then writing and sourcing additional constraint files to capture<br/>
		/// all inferred constraints. See the example below for more information.<br/>
		/// This command returns a transcript of the process when successful, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example writes the inferred clock constraints in the current design:<br/>
		/// write_inferred_xdc -clocks C:/Data/design1_inferred_clocks.xdc<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The write_inferred_xdc command may need to be run multiple times to capture all the<br/>
		/// inferred constraints, as is shown in this example:<br/>
		/// write_inferred_xdc -clocks clocks.xdc<br/>
		/// source clocks.xdc<br/>
		/// write_inferred_xdc -all all.xdc<br/>
		/// source all.xdc<br/>
		/// write_inferred_xdc -async_clocks async.xdc<br/>
		/// source async.xdc<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1867<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Filename to write constraints into</param>
		/// <param name="force">(Optional) Overwrite existing file.</param>
		/// <param name="all">
		/// <para>
		/// (Optional)<br/>
		/// Generate all constraints except missing clocks which are<br/>
		/// generated with the -clocks option<br/>
		/// </para>
		/// </param>
		/// <param name="append">(Optional) Append the constraints to file, don't overwrite the constraints file</param>
		/// <param name="async_clocks">(Optional) Find asynchronous clock groups</param>
		/// <param name="all_async_reg">
		/// <para>
		/// (Optional)<br/>
		/// Find the missing ASYNC_REG property for safe and unsafe<br/>
		/// Clock Domain Crossing<br/>
		/// </para>
		/// </param>
		/// <param name="clock_groups">
		/// <para>
		/// (Optional)<br/>
		/// Find asynchronous and exclusive clock groups, equivalent to<br/>
		/// options -async_clocks -excl_clocks<br/>
		/// </para>
		/// </param>
		/// <param name="clocks">(Optional) Find missing clock definitions</param>
		/// <param name="excl_clocks">(Optional) Find logically and physically exclusive clock groups</param>
		/// <param name="exceptions">(Optional) Find missing exceptions</param>
		/// <param name="io_constraints">(Optional) Find missing input and output delays</param>
		/// <param name="merge_existing_constraints">(Optional) Add existing user defined constraints to the generated constraints</param>
		/// <param name="name">
		/// <para>
		/// (Optional)<br/>
		/// Start constraints wizard in a GUI panel with this name. Do<br/>
		/// other command options can be combined with -name.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_inferred_xdc(TCLObject file, bool? force = null, bool? all = null, bool? append = null, bool? async_clocks = null, bool? all_async_reg = null, bool? clock_groups = null, bool? clocks = null, bool? excl_clocks = null, bool? exceptions = null, bool? io_constraints = null, bool? merge_existing_constraints = null, String name = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_inferred_xdc [-force] [-all] [-append] [-async_clocks] [-all_async_reg] [-clock_groups] [-clocks] [-excl_clocks] [-exceptions] [-io_constraints] [-merge_existing_constraints] [-name <arg>] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.write_inferred_xdc(file, force, all, append, async_clocks, all_async_reg, clock_groups, clocks, excl_clocks, exceptions, io_constraints, merge_existing_constraints, name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write the Memory Map Info of the design to a .mmi file.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_mem_info [-cell &lt;arg&gt;] [-no_partial_mmi] [-force_detect_xpm] [-force] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// This command writes a memory information (MMI) file defining the BRAM placement and<br/>
		/// address ranges to create a memory map of the design.<br/>
		/// IMPORTANT! write_mem_info requires an open implemented design so that the memory<br/>
		/// information includes the BRAM placement data, as well as the address ranges, required for proper<br/>
		/// programming.<br/>
		/// The memory map information (MMI) file, written by the write_mem_info command, is a text<br/>
		/// file that describes how individual Block RAMs on the Xilinx device are grouped together to form<br/>
		/// a contiguous address space called an Address Block.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The mem info file (MMI) contains memory mapping information similar to the Block Memory<br/>
		/// Map (BMM) file, but in a format that can be read by the updatemem command to merge with a<br/>
		/// bitstream (BIT) file. The updatemem command uses the MMI file to identify the physical BRAM<br/>
		/// resource that maps to a specific address range. Refer to the Vivado Design Suite User Guide:<br/>
		/// Embedded Processor Hardware Design (UG898) for more information on running updatemem.<br/>
		/// This command returns the name of the file created, or returns an error if it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1874<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Required)<br/>
		/// Design mem info file Values: A filename with alphanumeric<br/>
		/// characters and .mmi extension.<br/>
		/// </para>
		/// </param>
		/// <param name="cell">(Optional) Create only partial .mmi for named cell</param>
		/// <param name="no_partial_mmi">(Optional) Do not write partial bit files for a Dynamic Function eXchange design</param>
		/// <param name="force_detect_xpm">(Optional) Traverse netlist and check for XPM</param>
		/// <param name="force">(Optional) Overwrite existing mem info xml file</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>The name of the .mmi file</returns>
		public TTCL write_mem_info(TCLObject file, String cell = null, bool? no_partial_mmi = null, bool? force_detect_xpm = null, bool? force = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_mem_info [-cell <arg>] [-no_partial_mmi] [-force_detect_xpm] [-force] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_mem_info(file, cell, no_partial_mmi, force_detect_xpm, force, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Write QoR Suggestions to the given file<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_qor_suggestions [-strategy_dir &lt;arg&gt;] [-tcl_output_dir &lt;arg&gt;] [-force] [-of_objects &lt;args&gt;] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Write the QoR suggestions generated by the report_qor_suggestions command. You can<br/>
		/// combine the suggestions from the latest report with suggestions read into the design with<br/>
		/// read_qor_suggestions so that you can manage all suggestions in a single RQS file.<br/>
		/// To write out specific QoR suggestions, use the -of_objects option. When this is not specified,<br/>
		/// all suggestions will be written.<br/>
		/// The recommended way to manage suggestions is using RQS objects. However, it is possible to<br/>
		/// view and execute the commands using Tcl. Specifying the -tcl_output_dir option writes Tcl<br/>
		/// scripts for the automated suggestions that are property based.<br/>
		/// Implementation strategies that use machine learning to analyze the design can be generated<br/>
		/// running report_qor_suggestions. If you specify the -strategy_dir option, multiple Tcl<br/>
		/// files and one RQS file will be written for each strategy. The Tcl files aid integration into project or<br/>
		/// non project flows. The main RQS file should not be used as the suggestions are contained in the<br/>
		/// run specific files along with strategy information.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// This command returns the name of the output file created when successful, or returns an error if<br/>
		/// it fails.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example reports QoR suggestions, then writes non-strategy suggestions to the<br/>
		/// specified file.<br/>
		/// report_qor_suggestions<br/>
		/// write_qor_suggestions C:/Data/qor_results.rqs<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The following example reports QoR suggestions, then writes both strategy and non-strategy<br/>
		/// suggestions. It will create one RQS file for each strategy suggestion that exists, generating up to<br/>
		/// three by default. Into each RQS file, it writes one strategy suggestion and all non-strategy<br/>
		/// suggestions. This behavior means that for subsequent runs one RQS file per run is required.<br/>
		/// report_qor_suggestions<br/>
		/// write_qor_suggestions -strategy_dir C:/Data/strategy_dir C:/Data/<br/>
		/// qor_suggestions.rqs<br/>
		/// To make use of strategy suggestions, the directive for each implementation command<br/>
		/// (opt_design, place_design, phys_opt_design, and route_design) must be set to RQS.<br/>
		/// This can be configured automatically in project mode by sourcing the project mode Tcl script<br/>
		/// generated for each RQS file in the strategy_dir. There is also a non-project example Tcl script<br/>
		/// that demonstrates this requirement.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1883<br/>
		/// </para>
		/// </summary>
		/// <param name="file">
		/// <para>
		/// (Required)<br/>
		/// QoR suggestions file Values: A filename with alphanumeric<br/>
		/// characters and .rqs extension.<br/>
		/// </para>
		/// </param>
		/// <param name="strategy_dir">
		/// <para>
		/// (Optional)<br/>
		/// Directory to create Strategy RQS &amp; TCL files Values: If<br/>
		/// passed a directory path, for each strategy suggested one set<br/>
		/// of RQS and TCL files will be generated.<br/>
		/// </para>
		/// </param>
		/// <param name="tcl_output_dir">
		/// <para>
		/// (Optional)<br/>
		/// Directory to create TCL files Values: TCL files for the QoR<br/>
		/// suggestions will be generated in the provided directory.<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Overwrite existing suggestions file</param>
		/// <param name="of_objects">(Optional) List of QoR suggestion objects</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_qor_suggestions(TCLObject file, String strategy_dir = null, String tcl_output_dir = null, bool? force = null, TCLParameterList of_objects = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_qor_suggestions [-strategy_dir <arg>] [-tcl_output_dir <arg>] [-force] [-of_objects <args>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_qor_suggestions(file, strategy_dir, tcl_output_dir, force, of_objects, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Export schematic<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_schematic [-force] [-format &lt;arg&gt;] [-orientation &lt;arg&gt;] [-scope &lt;arg&gt;] [-name &lt;arg&gt;] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Output the currently opened, or specified Schematic window in the Vivado IDE to a file.<br/>
		/// The file can be written as a native ASCII file that can be read back into the Vivado IDE using the<br/>
		/// read_schematic command, or can be written as a PDF or SVG file for use outside of the Vivado<br/>
		/// Design Suite. This can be useful when documenting IP cores from the IP packager flow, or from<br/>
		/// the Vivado IP integrator.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1886<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Output file</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="format">
		/// <para>
		/// (Optional)<br/>
		/// Values: native or pdf. read_schematic can be used to view<br/>
		/// native format. Default: native<br/>
		/// </para>
		/// </param>
		/// <param name="orientation">(Optional) Values: landscape or portrait</param>
		/// <param name="scope">(Optional) Values: current_page, visible or all Default: current_page</param>
		/// <param name="name">(Optional) Schematic window title</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>name of the output file</returns>
		public TTCL write_schematic(TCLObject file, bool? force = null, write_schematic_format? format = null, write_schematic_orientation? orientation = null, write_schematic_scope? scope = null, String name = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_schematic [-force] [-format <arg>] [-orientation <arg>] [-scope <arg>] [-name <arg>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_schematic(file, force, format, orientation, scope, name, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// write_sdf command generates flat sdf delay files for event simulation<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_sdf [-process_corner &lt;arg&gt;] [-cell &lt;arg&gt;] [-rename_top &lt;arg&gt;] [-force] [-mode &lt;arg&gt;] [-gzip] [-multithread &lt;arg&gt;] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Writes the timing delays for cells in the design to a Standard Delay Format (SDF) file.<br/>
		/// The output SDF file can be used by the write_verilog command to create Verilog netlists for<br/>
		/// static timing analysis and timing simulation.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example writes an SDF file to the specified directory:<br/>
		/// write_sdf C:/Data/FPGA_Design/designOut.sdf<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1889<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) File name</param>
		/// <param name="process_corner">
		/// <para>
		/// (Optional)<br/>
		/// Specify process corner for which SDF delays are required;<br/>
		/// Values: slow, fast Default: slow<br/>
		/// </para>
		/// </param>
		/// <param name="cell">(Optional) Root of the design to write, e.g. des.subblk.cpu Default: whole design</param>
		/// <param name="rename_top">
		/// <para>
		/// (Optional)<br/>
		/// Replace name of top module with custom name e.g. netlist<br/>
		/// Default: new top module name<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Overwrite existing SDF file</param>
		/// <param name="mode">
		/// <para>
		/// (Optional)<br/>
		/// Specify sta (Static Timing Analysis) or timesim (Timing<br/>
		/// Simulation) mode for SDF Default: timesim<br/>
		/// </para>
		/// </param>
		/// <param name="gzip">(Optional) write gzipped SDF</param>
		/// <param name="multithread">(Optional) Run in multithread mode with specified number of threads Default: -1</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_sdf(TCLObject file, write_sdf_process_corner? process_corner = null, String cell = null, String rename_top = null, bool? force = null, String mode = null, bool? gzip = null, Int32? multithread = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_sdf [-process_corner <arg>] [-cell <arg>] [-rename_top <arg>] [-force] [-mode <arg>] [-gzip] [-multithread <arg>] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_sdf(file, process_corner, cell, rename_top, force, mode, gzip, multithread, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Export the current netlist in Verilog format<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_verilog [-cell &lt;arg&gt;] [-mode &lt;arg&gt;] [-lib] [-port_diff_buffers] [-write_all_overrides] [-keep_vcc_gnd] [-rename_top &lt;arg&gt;] [-sdf_anno &lt;arg&gt;] [-sdf_file &lt;arg&gt;] [-force] [-include_xilinx_libs] [-logic_function_stripped] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Write a Verilog netlist of the current design or from a specific cell of the design to the specified<br/>
		/// file or directory. The output is a IEEE 1364-2001 compliant Verilog HDL file that contains netlist<br/>
		/// information obtained from the input design files.<br/>
		/// You can output a complete netlist of the design or specific cell, or output a port list for the<br/>
		/// design, or a Verilog netlist for simulation or static timing analysis.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example writes a Verilog simulation netlist file for the whole design to the specified<br/>
		/// file and path:<br/>
		/// write_verilog C:/Data/my_verilog.v<br/>
		/// In the following example, because the -mode timesim and -sdf_anno options are specified,<br/>
		/// the $sdf_annotate statement will be added to the Verilog netlist. However, since the -<br/>
		/// sdf_file option is not specified, the SDF file is assumed to have the same name as the Verilog<br/>
		/// output file, with an .sdf file extension:<br/>
		/// write_verilog C:/Data/my_verilog.net -mode timesim -sdf_anno true<br/>
		/// Note: The SDF filename written to the $sdf_annotate statement will be my_verilog.sdf.<br/>
		/// In the following example, the functional simulation mode is specified, the option to keep VCC<br/>
		/// and GND primitives in the output simulation netlist is enabled, and the output file is specified:<br/>
		/// write_verilog -mode funcsim -keep_vcc_gnd out.v<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1891<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Which file to write</param>
		/// <param name="cell">(Optional) Root of the design to write, e.g. des.subblk.cpu Default: whole design</param>
		/// <param name="mode">
		/// <para>
		/// (Optional)<br/>
		/// Values: design, pin_planning, synth_stub, sta, funcsim,<br/>
		/// timesim Default: design<br/>
		/// </para>
		/// </param>
		/// <param name="lib">(Optional) Write each library into a separate file</param>
		/// <param name="port_diff_buffers">(Optional) Output differential buffers when writing in -port mode</param>
		/// <param name="write_all_overrides">
		/// <para>
		/// (Optional)<br/>
		/// Write parameter overrides on Xilinx primitives even if the<br/>
		/// override value is the same as the default value<br/>
		/// </para>
		/// </param>
		/// <param name="keep_vcc_gnd">
		/// <para>
		/// (Optional)<br/>
		/// Don't replace VCC/GND instances by literal constants on<br/>
		/// load terminals. For simulation modes only.<br/>
		/// </para>
		/// </param>
		/// <param name="rename_top">
		/// <para>
		/// (Optional)<br/>
		/// Replace top module name with custom name e.g. netlist<br/>
		/// Default: new top module name<br/>
		/// </para>
		/// </param>
		/// <param name="sdf_anno">(Optional) Specify if sdf_annotate system task statement is generated</param>
		/// <param name="sdf_file">(Optional) Full path to sdf file location Default: &lt;file&gt;.sdf</param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="include_xilinx_libs">
		/// <para>
		/// (Optional)<br/>
		/// Include simulation models directly in netlist instead of<br/>
		/// linking to library<br/>
		/// </para>
		/// </param>
		/// <param name="logic_function_stripped">
		/// <para>
		/// (Optional)<br/>
		/// Convert INIT strings on LUTs &amp; RAMBs to fixed values.<br/>
		/// Resulting netlist will not behave correctly.<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>the name of the output file or directory</returns>
		public TTCL write_verilog(TCLObject file, String cell = null, write_verilog_mode? mode = null, bool? lib = null, bool? port_diff_buffers = null, bool? write_all_overrides = null, bool? keep_vcc_gnd = null, String rename_top = null, String sdf_anno = null, String sdf_file = null, bool? force = null, bool? include_xilinx_libs = null, bool? logic_function_stripped = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_verilog [-cell <arg>] [-mode <arg>] [-lib] [-port_diff_buffers] [-write_all_overrides] [-keep_vcc_gnd] [-rename_top <arg>] [-sdf_anno <arg>] [-sdf_file <arg>] [-force] [-include_xilinx_libs] [-logic_function_stripped] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_verilog(file, cell, mode, lib, port_diff_buffers, write_all_overrides, keep_vcc_gnd, rename_top, sdf_anno, sdf_file, force, include_xilinx_libs, logic_function_stripped, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Export the current netlist in VHDL format<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_vhdl [-cell &lt;arg&gt;] [-mode &lt;arg&gt;] [-lib] [-port_diff_buffers] [-write_all_overrides] [-keep_vcc_gnd] [-rename_top &lt;arg&gt;] [-arch_only] [-force] [-include_xilinx_libs] [-quiet] [-verbose] &lt;file&gt;
		/// <br/>
		/// <para>
		/// Write a VHDL netlist of the current design or from a specific cell of the design to the specified<br/>
		/// file or directory.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// The output of this command is a VHDL IEEE 1076.4 VITAL-2000 compliant VHDL file that<br/>
		/// contains netlist information obtained from the input design files. You can output a complete<br/>
		/// netlist of the design or specific cell, or output a port list for the design.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example writes a VHDL simulation netlist file for the whole design to the specified<br/>
		/// file and path:<br/>
		/// write_vhdl C:/Data/bft_top.vhd<br/>
		/// In the following example the entity definition of the top-level module is not output to the VHDL<br/>
		/// netlist:<br/>
		/// write_vhdl C:/Data/vhdl_arch_only.vhd -arch_only<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1895<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Which file to write</param>
		/// <param name="cell">(Optional) Root of the design to write, e.g. des.subblk.cpu Default: whole design</param>
		/// <param name="mode">
		/// <para>
		/// (Optional)<br/>
		/// Output mode. Valid values: funcsim, pin_planning,<br/>
		/// synth_stub Default: funcsim<br/>
		/// </para>
		/// </param>
		/// <param name="lib">(Optional) Write each library into a separate file</param>
		/// <param name="port_diff_buffers">(Optional) Output differential buffers when writing in -port mode</param>
		/// <param name="write_all_overrides">
		/// <para>
		/// (Optional)<br/>
		/// Write parameter overrides on Xilinx primitives even if the<br/>
		/// same as the default value<br/>
		/// </para>
		/// </param>
		/// <param name="keep_vcc_gnd">
		/// <para>
		/// (Optional)<br/>
		/// Don't replace VCC/GND instances by literal constants on<br/>
		/// load terminals. For simulation modes only.<br/>
		/// </para>
		/// </param>
		/// <param name="rename_top">
		/// <para>
		/// (Optional)<br/>
		/// Replace top module name with custom name e.g. netlist<br/>
		/// Default: new top module name<br/>
		/// </para>
		/// </param>
		/// <param name="arch_only">
		/// <para>
		/// (Optional)<br/>
		/// Write only the architecture, not the entity declaration for the<br/>
		/// top cell<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Overwrite existing file</param>
		/// <param name="include_xilinx_libs">
		/// <para>
		/// (Optional)<br/>
		/// Include simulation models directly in netlist instead of<br/>
		/// linking to library<br/>
		/// </para>
		/// </param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		/// <returns>the name of the output file or directory</returns>
		public TTCL write_vhdl(TCLObject file, String cell = null, String mode = null, bool? lib = null, bool? port_diff_buffers = null, bool? write_all_overrides = null, bool? keep_vcc_gnd = null, String rename_top = null, bool? arch_only = null, bool? force = null, bool? include_xilinx_libs = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_vhdl [-cell <arg>] [-mode <arg>] [-lib] [-port_diff_buffers] [-write_all_overrides] [-keep_vcc_gnd] [-rename_top <arg>] [-arch_only] [-force] [-include_xilinx_libs] [-quiet] [-verbose] <file>
			_tcl.Entry(_builder.write_vhdl(file, cell, mode, lib, port_diff_buffers, write_all_overrides, keep_vcc_gnd, rename_top, arch_only, force, include_xilinx_libs, quiet, verbose));
			return _tcl;
		}
		/// <summary>
		/// <para>
		/// Writes constraints to a Xilinx Design Constraints (XDC) file. The default file extension for a XDC<br/>
		/// file is .xdc.<br/>
		/// </para>
		/// <br/>
		/// <br/>
		/// TCL Syntax: write_xdc [-no_fixed_only] [-constraints &lt;arg&gt;] [-cell &lt;arg&gt;] [-sdc] [-no_tool_comments] [-force] [-exclude_timing] [-exclude_physical] [-add_netlist_placement] [-logic_function_stripped] [-type &lt;args&gt;] [-write_id] [-quiet] [-verbose] [&lt;file&gt;]
		/// <br/>
		/// <para>
		/// Writes constraints to a Xilinx® Design Constraints file (XDC). The XDC can be exported from the<br/>
		/// top-level, which is the default, or from a specific hierarchical cell.<br/>
		/// UG835 (v2020.2) November 18, 2020 www.xilinx.com<br/>
		/// IMPORTANT! The write_xdc command writes the constraints to the specified file in the same order<br/>
		/// they are added to or executed in the design.<br/>
		/// The write_xdc command lets you write invalid XDC constraints so that you can quickly report<br/>
		/// constraints that have been ignored by the Vivado Design Suite due to a problem with the way<br/>
		/// the constraint is written or applied. This is useful for debugging constraint files applied in specific<br/>
		/// designs.<br/>
		/// This command can be used to create an XDC file from a design with UCF files. All constraints<br/>
		/// from the active constraint fileset will be exported to the XDC, even if they come from multiple<br/>
		/// files.<br/>
		/// TIP: The write_xdc command will not convert all UCF constraints into XDC format, and is not intended<br/>
		/// to automatically convert UCF based designs to XDC. Refer to the Vivado Design Suite Migration<br/>
		/// Methodology Guide (UG911) for more information on migrating UCF constraints to XDC.<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// The following example writes the valid and invalid constraints, including both fixed and unfixed<br/>
		/// cells, to the specified file:<br/>
		/// write_xdc -no_fixed_only -constraints all C:/Data/design.xdc<br/>
		/// This example writes only the invalid constraints, including both fixed and unfixed cells, to the<br/>
		/// specified file:<br/>
		/// write_xdc -constraints invalid C:/Data/bad_constraints.xdc<br/>
		/// The following example writes the physical constraints only, including any placement constraints<br/>
		/// defined in any netlist source files:<br/>
		/// write_xdc -exclude_timing -add_netlist_placement C:/Data/physical.xdc<br/>
		/// </para>
		/// <br/>
		/// <para>
		/// See ug835-vivado-tcl-commands.pdf, page 1900<br/>
		/// </para>
		/// </summary>
		/// <param name="file">(Required) Output constraints to the specified XDC file.</param>
		/// <param name="no_fixed_only">
		/// <para>
		/// (Optional)<br/>
		/// Export fixed and non-fixed placement (by default only fixed<br/>
		/// placement is exported)<br/>
		/// </para>
		/// </param>
		/// <param name="constraints">
		/// <para>
		/// (Optional)<br/>
		/// Include constraints that are flagged invalid Values: valid,<br/>
		/// invalid, all Default: valid<br/>
		/// </para>
		/// </param>
		/// <param name="cell">(Optional) Hierarchical cell for which constraints are exported.</param>
		/// <param name="sdc">(Optional) Export all timing constriants in SDC compatible format.</param>
		/// <param name="no_tool_comments">
		/// <para>
		/// (Optional)<br/>
		/// Don't write verbose tool generated comments to the xdc<br/>
		/// when translating from ucf.<br/>
		/// </para>
		/// </param>
		/// <param name="force">(Optional) Overwrite existing file.</param>
		/// <param name="exclude_timing">(Optional) Don't export timing constraints.</param>
		/// <param name="exclude_physical">(Optional) Don't export physical constraints.</param>
		/// <param name="add_netlist_placement">(Optional) Export netlist placement constraints.</param>
		/// <param name="logic_function_stripped">
		/// <para>
		/// (Optional)<br/>
		/// Write disable_timing constraints which are associated with<br/>
		/// having previously run write_edif with its -<br/>
		/// logic_function_stripped option.<br/>
		/// </para>
		/// </param>
		/// <param name="type">
		/// <para>
		/// (Optional)<br/>
		/// Types of constraint to export. Values: timing, io, misc, waiver<br/>
		/// and physical. If not specified, all constraints will be<br/>
		/// exported.<br/>
		/// </para>
		/// </param>
		/// <param name="write_id">(Optional) Write position number for timing constraints</param>
		/// <param name="quiet">(Optional) Ignore command errors</param>
		/// <param name="verbose">(Optional) Suspend message limits during command execution</param>
		public TTCL write_xdc(TCLObject file, bool? no_fixed_only = null, write_xdc_constraints? constraints = null, String cell = null, bool? sdc = null, bool? no_tool_comments = null, bool? force = null, bool? exclude_timing = null, bool? exclude_physical = null, bool? add_netlist_placement = null, bool? logic_function_stripped = null, TCLParameterList type = null, bool? write_id = null, bool? quiet = null, bool? verbose = null)
		{
			// TCL Syntax: write_xdc [-no_fixed_only] [-constraints <arg>] [-cell <arg>] [-sdc] [-no_tool_comments] [-force] [-exclude_timing] [-exclude_physical] [-add_netlist_placement] [-logic_function_stripped] [-type <args>] [-write_id] [-quiet] [-verbose] [<file>]
			_tcl.Entry(_builder.write_xdc(file, no_fixed_only, constraints, cell, sdc, no_tool_comments, force, exclude_timing, exclude_physical, add_netlist_placement, logic_function_stripped, type, write_id, quiet, verbose));
			return _tcl;
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles
