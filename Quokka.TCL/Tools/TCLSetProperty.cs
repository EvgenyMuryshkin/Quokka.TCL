namespace Quokka.TCL.Tools
{
    public class TCLSetProperty : TCLEntry
    {
        string _name;
        string _value;
        string _target;

        public TCLSetProperty(string name, string value, string target)
        {
            _name = name ?? "";
            _value = value ?? "";
            _target = target ?? "";
        }

        public override void Write(IndentedStringBuilder builder)
        {
            builder.Append($"set_property {_name} {_value} [{_target}]");
        }
    }
}
