namespace Quokka.TCL.Tools
{
    public class TCLCommandNamedFlagParameter : TCLCommandParameter
    {
        protected string _name;
        protected bool _value;
        public TCLCommandNamedFlagParameter(string name, bool value)
        {
            _name = name;
            _value = value;
        }

        public override void Write(IndentedStringBuilder builder)
        {
            builder.Append($" -{_name} {(_value ? "true" : "false")}");
        }
    }
}
