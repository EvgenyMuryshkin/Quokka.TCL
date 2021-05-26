namespace Quokka.TCL.Tools
{
    public class TCLCommandObjectParameter : TCLCommandParameter
    {
        protected TCLObject _value;
        public TCLCommandObjectParameter(TCLObject value)
        {
            _value = value;
        }

        public override void Write(IndentedStringBuilder builder)
        {
            builder.Append($" ");
            _value.Write(builder);
        }
    }
}
