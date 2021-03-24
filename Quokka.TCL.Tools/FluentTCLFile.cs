using System;

namespace Quokka.TCL.Tools
{
    public class FluentTCLFile<TThis> : TCLFile
        where TThis : FluentTCLFile<TThis>
    {
        public FluentTCLFile<TThis> Comment(string comment)
        {
            _entries.Add(new TCLComment(comment));
            return this;
        }

        public FluentTCLFile<TThis> Add(TCLEntry entry)
        {
            _entries.Add(entry);
            return this;
        }

        public FluentTCLFile<TThis> Source(string script)
        {
            _entries.Add(new TCLSource(script));
            return this;

        }
        public FluentTCLFile<TThis> Set(string target, string source)
        {
            _entries.Add(new TCLSet(target, source));
            return this;
        }

        public FluentTCLFile<TThis> SetProperty(string name, string value, string target)
        {
            _entries.Add(new TCLSetProperty(name, value, target));
            return this;
        }

        public FluentTCLFile<TThis> Add<TFile>(FluentTCLFile<TFile> file)
            where TFile : FluentTCLFile<TFile>
        {
            if (file == null)
                throw new NullReferenceException(nameof(file));

            _entries.AddRange(file._entries);

            return this;
        }
    }
}
