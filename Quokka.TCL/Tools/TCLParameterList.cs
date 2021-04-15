using System;
using System.Collections.Generic;
using System.Linq;

namespace Quokka.TCL.Tools
{
    public class TCLParameterList
    {
        public List<string> Params { get; private set; } = new List<string>();

        public TCLParameterList()
        {
        }

        public TCLParameterList(List<string> value)
        {
            Params = (value ?? new List<string>()).Where(v => !string.IsNullOrWhiteSpace(v)).ToList();
        }

        public static implicit operator TCLParameterList(string source)
        {
            return new TCLParameterList(new List<string>() { source });
        }

        public static implicit operator TCLParameterList(string[] source)
        {
            return new TCLParameterList((source ?? Array.Empty<string>()).ToList());
        }

        public static implicit operator TCLParameterList(List<string> source)
        {
            return new TCLParameterList((source ?? Enumerable.Empty<string>()).ToList());
        }
    }
}
