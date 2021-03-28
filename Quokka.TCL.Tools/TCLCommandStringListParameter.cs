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
            builder.AppendContent($" {string.Join(" ", _value.Params)}");
        }
    }
}
