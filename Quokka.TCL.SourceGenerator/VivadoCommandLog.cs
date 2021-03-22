using Quokka.TCL.Tools;
using System.Collections.Generic;
using System.Linq;

namespace Quokka.TCL.SourceGenerator
{
    class VivadoCommandLogRecord
    {
        public string Name;
        public HashSet<string> DuplicateParams = new HashSet<string>();
        public HashSet<string> InconsistentUsage = new HashSet<string>();
    }

    class VivadoCommandLog
    {
        Dictionary<string, VivadoCommandLogRecord> _records = new Dictionary<string, VivadoCommandLogRecord>();

        public VivadoCommandLogRecord Command(string name)
        {
            if (!_records.ContainsKey(name))
                _records[name] = new VivadoCommandLogRecord() { Name = name };

            return _records[name];
        }

        public override string ToString()
        {
            var builder = new IndentedStringBuilder();

            builder.AppendLine($"# Generator log");

            foreach (var command in _records.Keys.OrderBy(p => p))
            {
                var record = _records[command];
                if (record.DuplicateParams.Any() || record.InconsistentUsage.Any())
                {
                    builder.AppendLine($"## Command: {record.Name}");
                    if (record.DuplicateParams.Any())
                    {
                        using (builder.Indent())
                        {
                            builder.AppendLine($"### Duplicate parameters:");
                            using (builder.Indent())
                            {
                                record.DuplicateParams.OrderBy(c => c).ToList().ForEach(l => builder.AppendLine(l));
                            }
                        }
                    }

                    if (record.InconsistentUsage.Any())
                    {
                        using (builder.Indent())
                        {
                            builder.AppendLine($"### Inconsistent Usage:");
                            using (builder.Indent())
                            {
                                record.InconsistentUsage.OrderBy(c => c).ToList().ForEach(l => builder.AppendLine(l));
                            }
                        }
                    }
                }
            }

            return builder.ToString();
        }
    }
}
