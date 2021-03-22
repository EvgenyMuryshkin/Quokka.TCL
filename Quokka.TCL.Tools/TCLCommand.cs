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
}
