// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class projutilsCommands
	{
		private readonly QuokkaTCL _tcl;
		public projutilsCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// (User-written application) Convert all provided NGC files to a supported format
		/// </summary>
		public void convert_ngc()
		{
			var command = new SimpleTCLCommand("convert_ngc");
			_tcl.Add(command);
		}
		/// <summary>
		/// (User-written application) Copy a run from an already existing run, source-run, to a new copy of
		/// that run, destination-run.
		/// </summary>
		public void copy_run()
		{
			var command = new SimpleTCLCommand("copy_run");
			_tcl.Add(command);
		}
		/// <summary>
		/// (User-written application) Creates and launches a new run based on the suggestions by
		/// report_qor_suggestions. This proc looks for 5 files in the directory specified by the user.
		/// 1.RQSPreSynth_<newProjName>.xdc 2.RQSImplCommon_<newProjName>.xdc
		/// 3.RQSPreImpl_<newProjName>.xdc 4.RQSPreImpl_<newProjName>.tcl
		/// 5.RQSImplCommon_<newProjName>.tcl. There are 2 flows. One is creating both synth and impl
		/// runs and the other is creating only impl run making user specified synth run as the parent for the
		/// newly created impl run. In the first flow, we create a new synth run based on the current impl
		/// run's parent run (i,e current synth run). We create a new constraint fileset and add the current
		/// synth run's constraint fileset's files to that. And we add RQSPreSynth_<>.xdc file to newly
		/// created constraint set. We create a impl run based on the current impl run. We create a impl run
		/// constraint (if it is not same as the one that has already been created), and add the current impl
		/// run's constraint fileset's files to that. We also add RQSImplCommon_<>.xdc to new impl
		/// constraint fileset. We set STEPS.OPT_DESIGN.TCL.PRE property of newly created impl run to
		/// RQSImplCommon_<>.tcl file. In this flow, we ignore RQSPreImpl_<>.xdc/tcl files. In the second
		/// flow, user specified synth run is used as parent for the newly created impl run. So there is no
		/// synth run creation. We create impl run based on current impl run and user specified synth run.
		/// We create a new impl constraint fileset and add fileset to that form the current impl run's
		/// constraint fileset. We also add RQSImplCommon_<>.xdc , RQSPreImpl_<>.xdc files. If
		/// RQSPreImpl_<>.tcl file is available, it is set as STEPS.OPT_DESIGN.TCL.PRE property for new
		/// impl run otherwise RQSImplCommon_<>.tcl is set. In both the flows adding or setting files is
		/// subject to availability of those files in the output directory.
		/// </summary>
		public void create_rqs_run()
		{
			var command = new SimpleTCLCommand("create_rqs_run");
			_tcl.Add(command);
		}
		/// <summary>
		/// (User-written application) Create and write a single design checkpoint and stub files for a Block
		/// Design (BD), for use with third party synthesis tools. Perform synthesis as necessary.
		/// </summary>
		public void export_bd_synth()
		{
			var command = new SimpleTCLCommand("export_bd_synth");
			_tcl.Add(command);
		}
		/// <summary>
		/// (User-written application) Export Tcl script for re-creating the current project
		/// </summary>
		public void write_project_tcl()
		{
			var command = new SimpleTCLCommand("write_project_tcl");
			_tcl.Add(command);
		}
	}
}
