namespace Quokka.TCL.Tools
{
    public class TCLCommandStringParameter : TCLCommandParameter
    {
        protected string _value = "";
        public TCLCommandStringParameter(string value)
        {
            _value = value;
        }

        public override void Write(IndentedStringBuilder builder)
        {
            builder.Append($" {_value}");
        }
    }
}
