namespace Quokka.TCL.Tools
{
    public class TCLCommandNamedStringListParameter : TCLCommandParameter
    {
        protected string _name = "";
        protected TCLParameterList _value = new TCLParameterList();

        public TCLCommandNamedStringListParameter(string name, TCLParameterList value)
        {
            _name = name;
            _value = (value ?? new TCLParameterList());
        }

        public override void Write(IndentedStringBuilder builder)
        {
            builder.Append($" -{_name} {string.Join(" ", _value)}");
        }
    }
}
