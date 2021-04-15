namespace Quokka.TCL.Tools
{
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
}
