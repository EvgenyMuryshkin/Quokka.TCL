using System;
using System.Collections.Generic;

namespace Quokka.TCL.Tools
{
    public abstract class TCLEntry
    {
        public abstract void Write(IndentedStringBuilder builder);
    }

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

    public class TCLFile<TThis> : TCLFile
        where TThis : TCLFile<TThis>
    {
        public TCLFile<TThis> Comment(string comment)
        {
            _entries.Add(new TCLComment(comment));
            return this;
        }

        public TCLFile<TThis> Add(TCLEntry entry)
        {
            _entries.Add(entry);
            return this;
        }

        public TCLFile<TThis> Add<TFile>(TCLFile<TFile> file)
            where TFile : TCLFile<TFile>
        {
            if (file == null)
                throw new NullReferenceException(nameof(file));

            _entries.AddRange(file._entries);

            return this;
        }
    }
}
