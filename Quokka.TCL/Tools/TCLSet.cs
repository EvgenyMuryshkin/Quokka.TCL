namespace Quokka.TCL.Tools
{
    public class TCLSet : TCLEntry
    {
        string _target;
        string _source;

        public TCLSet(string target, string source)
        {
            _target = target ?? "";
            _source = source ?? "";
        }

        public override void Write(IndentedStringBuilder builder)
        {
            builder.Append($"set {_target} {_source}");
        }
    }
}
