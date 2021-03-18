using System;
namespace Quokka.TCL.Vivado
{
	public partial class VivadoTCL : QuokkaTCL
	{
		public BoardCommands Board = new BoardCommands();
		public ConfigurationCommands Configuration = new ConfigurationCommands();
		public CreatePeripheralCommands CreatePeripheral = new CreatePeripheralCommands();
		public DebugCommands Debug = new DebugCommands();
		public DRCCommands DRC = new DRCCommands();
		public FeasibilityCommands Feasibility = new FeasibilityCommands();
		public FileIOCommands FileIO = new FileIOCommands();
		public FloorplanCommands Floorplan = new FloorplanCommands();
		public GUIControlCommands GUIControl = new GUIControlCommands();
		public HardwareCommands Hardware = new HardwareCommands();
		public IPFlowCommands IPFlow = new IPFlowCommands();
		public IPIntegratorCommands IPIntegrator = new IPIntegratorCommands();
		public MemoryCommands Memory = new MemoryCommands();
		public MethodologyCommands Methodology = new MethodologyCommands();
		public NetlistCommands Netlist = new NetlistCommands();
		public ObjectCommands Object = new ObjectCommands();
		public PartitionCommands Partition = new PartitionCommands();
		public PinPlanningCommands PinPlanning = new PinPlanningCommands();
		public PlatformCommands Platform = new PlatformCommands();
		public PowerCommands Power = new PowerCommands();
		public ProjectCommands Project = new ProjectCommands();
		public projutilsCommands projutils = new projutilsCommands();
		public PropertyAndParameterCommands PropertyAndParameter = new PropertyAndParameterCommands();
		public ReportCommands Report = new ReportCommands();
		public SDCCommands SDC = new SDCCommands();
		public SimulationCommands Simulation = new SimulationCommands();
		public SysGenCommands SysGen = new SysGenCommands();
		public TimingCommands Timing = new TimingCommands();
		public ToolLaunchCommands ToolLaunch = new ToolLaunchCommands();
		public ToolsCommands Tools = new ToolsCommands();
		public VitisCommands Vitis = new VitisCommands();
		public WaiverCommands Waiver = new WaiverCommands();
		public WaveformCommands Waveform = new WaveformCommands();
		public XDCCommands XDC = new XDCCommands();
		public xilinxtclstoreCommands xilinxtclstore = new xilinxtclstoreCommands();
	}
}
