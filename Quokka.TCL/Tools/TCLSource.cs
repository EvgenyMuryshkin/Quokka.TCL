namespace Quokka.TCL.Tools
{
    public class TCLSource : TCLEntry
    {
        string _name;
        public TCLSource(string name)
        {
            _name = name;
        }

        public override void Write(IndentedStringBuilder builder)
        {
            builder.Append($"source {_name}");
        }
    }
}
