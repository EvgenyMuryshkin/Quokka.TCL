using System.Collections.Generic;
using System.Linq;

namespace Quokka.TCL.Tools
{

    public abstract class TCLCommand : TCLEntry
    {
    }

    public abstract class TCLCommandParameter
    {
        public abstract void Write(IndentedStringBuilder builder);
    }

    public class TCLCommandFlagParameter : TCLCommandParameter
    {
        protected string _name;

        public TCLCommandFlagParameter(string name)
        {
            _name = name;
        }

        public override void Write(IndentedStringBuilder builder)
        {
            builder.AppendContent($" -{_name}");
        }
    }

    public class TCLCommandStringNamedParameter : TCLCommandParameter
    {
        protected string _name = "";
        protected string _value = "";

        public TCLCommandStringNamedParameter(string name, string value)
        {
            _name = name;
            _value = value;
        }

        public override void Write(IndentedStringBuilder builder)
        {
            builder.AppendContent($" -{_name} {_value}");
        }
    }

    public class TCLCommandStringListNamedParameter : TCLCommandParameter
    {
        protected string _name = "";
        protected TCLParameterList _value = new TCLParameterList();

        public TCLCommandStringListNamedParameter(string name, TCLParameterList value)
        {
            _name = name;
            _value = (value ?? new TCLParameterList());
        }

        public override void Write(IndentedStringBuilder builder)
        {
            builder.AppendContent($" -{_name} {string.Join(" ", _value)}");
        }
    }

    public class TCLCommandStringParameter : TCLCommandParameter
    {
        protected string _value = "";
        public TCLCommandStringParameter(string value)
        {
            _value = value;
        }

        public override void Write(IndentedStringBuilder builder)
        {
            builder.AppendContent($" {_value}");
        }
    }

    public class TCLCommandStringListParameter : TCLCommandParameter
    {
        protected TCLParameterList _value = new TCLParameterList();

        public TCLCommandStringListParameter(TCLParameterList value)
        {
            _value = (value ?? new TCLParameterList());
        }

        public override void Write(IndentedStringBuilder builder)
        {
            builder.AppendContent($" {string.Join(" ", _value.Params)}");
        }
    }
}
