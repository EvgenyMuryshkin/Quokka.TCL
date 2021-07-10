using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Quokka.TCL.Tools
{
    public class TCLEscaping
    {
        public static TCLEscaping Default = new TCLEscaping();

        public virtual string FileName(string s)
        {
            s = string.Join("/", s.Split('\\'));
            return Escape(s);
        }

        public virtual string Escape(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return s;

            if (Regex.IsMatch(s, "^[a-zA-Z0-9-_]*$"))
                return s;

            return $"{{{s}}}";
        }
    }
}
