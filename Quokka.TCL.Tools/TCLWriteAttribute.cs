using System;

namespace Quokka.TCL.Tools
{
    public class TCLWriteAttribute : Attribute
    {
        public TCLWriteAttribute(string value)
        {
            Value = value;
        }

        public string Value { get; set; }
    }
}
