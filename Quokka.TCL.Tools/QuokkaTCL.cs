using System;
using System.Collections.Generic;

namespace Quokka.TCL.Tools
{
    public abstract class QuokkaTCLCommand
    {
        public abstract void Write(IndentedStringBuilder builder);
    }

    public abstract class TCLCommandParameter
    {

    }

    public class TCLCommandNamedParameter : TCLCommandParameter
    {
        protected string _name;
        public TCLCommandNamedParameter(string name)
        {
            _name = name;
        }
    }
    public class TCLCommandFlagParameter : TCLCommandNamedParameter
    {
        public TCLCommandFlagParameter(string name) : base(name)
        {
        }
    }


    public class TCLCommandStringNamedParameter : TCLCommandNamedParameter
    {
        protected string _value = "";
        public TCLCommandStringNamedParameter(string name, string value) : base(name)
        {
            _value = value;
        }
    }

    public class SimpleTCLCommand : QuokkaTCLCommand
    {
        private readonly string _name;
        private readonly List<TCLCommandParameter> _parameters = new List<TCLCommandParameter>();

        public SimpleTCLCommand(string name)
        {
            _name = name;
        }

        public override void Write(IndentedStringBuilder builder)
        {
            builder.AppendLine(_name);
        }

        public SimpleTCLCommand Flag(string name, bool? value)
        {
            if ((bool)value)
            {
                _parameters.Add(new TCLCommandFlagParameter(name));
            }

            return this;
        }

        public SimpleTCLCommand OptionalString(string name, string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _parameters.Add(new TCLCommandStringNamedParameter(name, value));
            }

            return this;
        }

        public SimpleTCLCommand RequiredString(string name, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException($"Parameter '{name}' is required");

            _parameters.Add(new TCLCommandStringNamedParameter(name, value));

            return this;
        }
    }

    public class QuokkaTCL
    {
        List<QuokkaTCLCommand> _commands = new List<QuokkaTCLCommand>();

        public void Add(QuokkaTCLCommand command)
        {
            _commands.Add(command);
        }

        public override string ToString()
        {
            var builder = new IndentedStringBuilder();

            foreach (var command in _commands)
            {
                command.Write(builder);
            }

            return builder.ToString();
        }
    }
}
