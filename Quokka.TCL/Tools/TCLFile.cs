using System.Collections.Generic;

namespace Quokka.TCL.Tools
{

    public abstract class TCLFile
    {
        protected List<TCLEntry> _entries = new List<TCLEntry>();

        public void Entry(TCLEntry entry)
        {
            _entries.Add(entry);
        }

        public override string ToString()
        {
            var builder = new IndentedStringBuilder();

            foreach (var entry in _entries)
            {
                entry.Write(builder);
            }

            return builder.ToString();
        }
    }
}
