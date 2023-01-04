using Quokka.TCL.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Quokka.TCL.Vivado
{
    public class FluentVivadoTCLFile<TThis> : FluentTCLFile<TThis>
        where TThis : FluentVivadoTCLFile<TThis>
    {
        protected readonly VivadoTCLBuilder _builder = new VivadoTCLBuilder();
        public VivadoTCLBuilder Builder => _builder;

        public FluentVivadoTCLFile(VivadoTCLBuilder builder = null)
        {
            _builder = builder ?? new VivadoTCLBuilder();
        }

        public TThis AddSources(string location, params string[] filters)
        {
            var resultFilters = filters.Where(f => string.IsNullOrEmpty(f)).ToList();
            if (!resultFilters.Any())
                resultFilters.Add("*.*");

            foreach (var filter in resultFilters)
            {
                var sources = Directory
                    .EnumerateFiles(location, filter, SearchOption.AllDirectories)
                    .ToList();

                if (sources.Any())
                {
                    foreach (var file in sources)
                    {
                        Add(_builder.add_files(files: file));
                    }
                }
            }

            return (TThis)this;
        }

        public SimpleTCLCommand Sim1 => _builder.get_filesets(patterns: "sim_1");
        public SimpleTCLCommand Sources1 => _builder.get_filesets(patterns: "sources_1");
        public SimpleTCLCommand CurrentProject => _builder.current_project();
        public SimpleTCLCommand CurrentFileSet => _builder.current_fileset();
    }
}
