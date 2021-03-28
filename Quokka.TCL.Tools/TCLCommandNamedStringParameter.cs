namespace Quokka.TCL.Tools
{
    public class TCLCommandNamedStringParameter : TCLCommandParameter
    {
        protected string _name = "";
        protected string _value = "";

        public TCLCommandNamedStringParameter(string name, string value)
        {
            _name = name;
            _value = value;
        }

        public override void Write(IndentedStringBuilder builder)
        {
            builder.AppendContent($" -{_name} {_value}");
        }
    }
}
