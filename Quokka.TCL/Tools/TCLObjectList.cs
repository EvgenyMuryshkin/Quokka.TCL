using System.Collections.Generic;
using System.Linq;

namespace Quokka.TCL.Tools
{
    public class TCLObjectList : TCLEntry
    {
        public List<TCLObject> Objects { get; private set; }
        public TCLObjectList(List<TCLObject> objects)
        {
            Objects = objects;
        }

        public override void Write(IndentedStringBuilder builder)
        {
            foreach (var obj in Objects)
            {
                builder.Append(" ");
                obj.Write(builder);
            }
        }

        public static implicit operator TCLObjectList(string source)
        {
            return new TCLObjectList(new List<TCLObject>() { source });
        }

        public static implicit operator TCLObjectList(TCLCommand source)
        {
            return new TCLObjectList(new List<TCLObject>() { source });
        }

        public static implicit operator TCLObjectList(TCLObject source)
        {
            return new TCLObjectList(new List<TCLObject>() { source });
        }

        public static implicit operator TCLObjectList(List<TCLObject> source)
        {
            return new TCLObjectList(source);
        }

        public static implicit operator TCLObjectList(List<string> source)
        {
            return new TCLObjectList(source.Select(s => new TCLObject(s)).ToList());
        }
    }
}
