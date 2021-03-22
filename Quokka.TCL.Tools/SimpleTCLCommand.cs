using System;
using System.Collections.Generic;

namespace Quokka.TCL.Tools
{
    public class SimpleTCLCommand : TCLCommand
    {
        private readonly string _name;
        private readonly List<TCLCommandParameter> _parameters = new List<TCLCommandParameter>();

        public SimpleTCLCommand(string name)
        {
            _name = name;
        }

        public override void Write(IndentedStringBuilder builder)
        {
            var commandBuilder = new IndentedStringBuilder();
            commandBuilder.AppendContent(_name);
            _parameters.ForEach(p => p.Write(commandBuilder));
            builder.AppendLine(commandBuilder.ToString());
        }

        public SimpleTCLCommand Flag(string name, bool? value)
        {
            if (value.HasValue && value.Value)
            {
                _parameters.Add(new TCLCommandFlagParameter(name));
            }

            return this;
        }

        public SimpleTCLCommand OptionalString(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _parameters.Add(new TCLCommandStringParameter(value));
            }

            return this;
        }

        public SimpleTCLCommand OptionalNamedString(string name, string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _parameters.Add(new TCLCommandStringNamedParameter(name, value));
            }

            return this;
        }

        public SimpleTCLCommand RequiredString(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException($"Parameter is required");

            _parameters.Add(new TCLCommandStringParameter(value));

            return this;
        }

        public SimpleTCLCommand RequiredNamedString(string name, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException($"Parameter '{name}' is required");

            _parameters.Add(new TCLCommandStringNamedParameter(name, value));

            return this;
        }
    }
}
