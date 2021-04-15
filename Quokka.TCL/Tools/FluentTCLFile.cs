using System;

namespace Quokka.TCL.Tools
{
    public class FluentTCLFile<TThis> : TCLFile
        where TThis : FluentTCLFile<TThis>
    {
        public TThis Comment(string comment)
        {
            _entries.Add(new TCLComment(comment));
            return (TThis)this;
        }

        public TThis Add(TCLEntry entry)
        {
            _entries.Add(entry);
            return (TThis)this;
        }

        public TThis Source(string script)
        {
            _entries.Add(new TCLSource(script));
            return (TThis)this;
        }

        public TThis Set(string target, string source)
        {
            _entries.Add(new TCLSet(target, source));
            return (TThis)this;
        }

        public TThis SetProperty(string name, string value, string target)
        {
            _entries.Add(new TCLSetProperty(name, value, target));
            return (TThis)this;
        }

        public TThis SetProperty(string name, string value, TCLEntry target)
        {
            var builder = new IndentedStringBuilder();
            target.Write(builder);

            return SetProperty(name, value, builder.ToString().Trim());
        }

        public TThis Add<TFile>(FluentTCLFile<TFile> file)
            where TFile : FluentTCLFile<TFile>
        {
            if (file == null)
                throw new NullReferenceException(nameof(file));

            _entries.AddRange(file._entries);

            return (TThis)this;
        }
    }
}
