namespace Quokka.TCL.Tools
{
    public class TCLCommandInt32Parameter : TCLCommandParameter
    {
        protected int _value = 0;
        public TCLCommandInt32Parameter(int value)
        {
            _value = value;
        }

        public override void Write(IndentedStringBuilder builder)
        {
            builder.AppendContent($" {_value}");
        }
    }
}
