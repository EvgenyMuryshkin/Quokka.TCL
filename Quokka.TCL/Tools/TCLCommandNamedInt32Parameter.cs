namespace Quokka.TCL.Tools
{
    public class TCLCommandNamedInt32Parameter : TCLCommandParameter
    {
        protected string _name = "";
        protected int _value = 0;

        public TCLCommandNamedInt32Parameter(string name, int value)
        {
            _name = name;
            _value = value;
        }

        public override void Write(IndentedStringBuilder builder)
        {
            builder.Append($" -{_name} {_value}");
        }
    }
}
