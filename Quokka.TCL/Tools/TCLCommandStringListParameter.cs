using System.Linq;

namespace Quokka.TCL.Tools
{
    public class TCLCommandStringListParameter : TCLCommandParameter
    {
        protected TCLParameterList _value = new TCLParameterList();

        public TCLCommandStringListParameter(TCLParameterList value)
        {
            _value = (value ?? new TCLParameterList());
        }

        public override void Write(IndentedStringBuilder builder)
        {
            builder.Append($" {string.Join(" ", _value.Params.Select(TCLEscaping.Default.Escape))}");
        }
    }

    public class TCLCommandObjectListParameter : TCLCommandParameter
    {
        protected TCLObjectList _value;

        public TCLCommandObjectListParameter(TCLObjectList value)
        {
            _value = value;
        }

        public override void Write(IndentedStringBuilder builder)
        {
            _value.Write(builder);
        }
    }
}
