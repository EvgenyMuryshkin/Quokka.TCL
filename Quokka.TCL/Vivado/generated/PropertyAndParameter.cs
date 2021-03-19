// Generated file, do not modify
// See VivadoGenerator for implementation
using System;
using Quokka.TCL.Tools;
namespace Quokka.TCL.Vivado
{
	public partial class PropertyAndParameterCommands
	{
		private readonly QuokkaTCL _tcl;
		public PropertyAndParameterCommands(QuokkaTCL tcl)
		{
			_tcl = tcl;
		}
		/// <summary>
		/// Create property for class of objects(s)
		/// </summary>
		public void create_property()
		{
			var command = new SimpleTCLCommand("create_property");
			_tcl.Add(command);
		}
		/// <summary>
		/// Filter a list, resulting in new list
		/// </summary>
		public void filter()
		{
			var command = new SimpleTCLCommand("filter");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get a parameter value
		/// </summary>
		public void get_param()
		{
			var command = new SimpleTCLCommand("get_param");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get properties of object
		/// </summary>
		public void get_property()
		{
			var command = new SimpleTCLCommand("get_property");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get all parameter names
		/// </summary>
		public void list_param()
		{
			var command = new SimpleTCLCommand("list_param");
			_tcl.Add(command);
		}
		/// <summary>
		/// List properties of object
		/// </summary>
		public void list_property()
		{
			var command = new SimpleTCLCommand("list_property");
			_tcl.Add(command);
		}
		/// <summary>
		/// List legal property values of object
		/// </summary>
		public void list_property_value()
		{
			var command = new SimpleTCLCommand("list_property_value");
			_tcl.Add(command);
		}
		/// <summary>
		/// Get information about all parameters
		/// </summary>
		public void report_param()
		{
			var command = new SimpleTCLCommand("report_param");
			_tcl.Add(command);
		}
		/// <summary>
		/// Report properties of object
		/// </summary>
		public void report_property()
		{
			var command = new SimpleTCLCommand("report_property");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reset a parameter
		/// </summary>
		public void reset_param()
		{
			var command = new SimpleTCLCommand("reset_param");
			_tcl.Add(command);
		}
		/// <summary>
		/// Reset property on object(s)
		/// </summary>
		public void reset_property()
		{
			var command = new SimpleTCLCommand("reset_property");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set a parameter value
		/// </summary>
		public void set_param()
		{
			var command = new SimpleTCLCommand("set_param");
			_tcl.Add(command);
		}
		/// <summary>
		/// Sets the part on the current project. If no project is open, then a diskless project is created.
		/// </summary>
		public void set_part()
		{
			var command = new SimpleTCLCommand("set_part");
			_tcl.Add(command);
		}
		/// <summary>
		/// Set property on object(s)
		/// </summary>
		public void set_property()
		{
			var command = new SimpleTCLCommand("set_property");
			_tcl.Add(command);
		}
	}
}
