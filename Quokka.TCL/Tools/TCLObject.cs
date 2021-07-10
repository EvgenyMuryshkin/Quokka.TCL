namespace Quokka.TCL.Tools
{
    public class TCLObject : TCLEntry
    {
        internal readonly string _value;
        internal readonly TCLCommand _command;
        public TCLObject(string value)
        {
            _value = value;
        }

        public TCLObject(TCLCommand command)
        {
            _command = command;
        }

        public override void Write(IndentedStringBuilder builder)
        {
            if (_value != null)
                builder.Append(_value);

            if (_command != null)
            {
                builder.Append("[");
                _command.Write(builder);
                builder.Append("]");
            }
        }

        public static implicit operator TCLObject(string source)
        {
            return new TCLObject(source);
        }


        public static implicit operator TCLObject(TCLCommand source)
        {
            return new TCLObject(source);
        }
    }
}
