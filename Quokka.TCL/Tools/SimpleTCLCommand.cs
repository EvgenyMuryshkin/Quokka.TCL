using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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

        string EnumValue<T>(T value)
        {
            var enumType = typeof(T);
            if (enumType.IsConstructedGenericType)
                enumType = enumType.GetGenericArguments()[0];
            var member = enumType.GetMember(value.ToString()).Single();
            var tclWrite = member.GetCustomAttribute<TCLWriteAttribute>();
            if (tclWrite != null)
                return tclWrite.Value;

            return value.ToString();
        }

        public SimpleTCLCommand OptionalFlag(string name, bool? value)
        {
            if (value.HasValue && value.Value)
            {
                _parameters.Add(new TCLCommandFlagParameter(name));
            }

            return this;
        }

        public SimpleTCLCommand OptionalString(string name, string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _parameters.Add(new TCLCommandStringParameter(value));
            }

            return this;
        }

        public SimpleTCLCommand OptionalStringList(string name, TCLParameterList value)
        {
            if (value != null && value.Params.Any(v => !string.IsNullOrWhiteSpace(v)))
            {
                _parameters.Add(new TCLCommandStringListParameter(value));
            }

            return this;

        }

        public SimpleTCLCommand OptionalNamedString(string name, string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _parameters.Add(new TCLCommandNamedStringParameter(name, value));
            }

            return this;
        }

        public SimpleTCLCommand OptionalNamedInt32(string name, int? value)
        {
            if (value.HasValue)
            {
                _parameters.Add(new TCLCommandNamedInt32Parameter(name, value.Value));
            }

            return this;
        }

        public SimpleTCLCommand OptionalNamedEnum<T>(string name, T? value) where T : struct
        {
            if (value.HasValue)
            {
                _parameters.Add(new TCLCommandNamedStringParameter(name, EnumValue(value)));
            }

            return this;
        }

        public SimpleTCLCommand OptionalNamedFlag(string name, bool? value)
        {
            if (value.HasValue)
            {
                _parameters.Add(new TCLCommandNamedFlagParameter(name, value.Value));
            }

            return this;
        }

        public SimpleTCLCommand OptionalNamedStringList(string name, TCLParameterList value)
        {
            if (value != null && value.Params.Any(v => !string.IsNullOrWhiteSpace(v)))
            {
                _parameters.Add(new TCLCommandNamedStringListParameter(name, value));
            }

            return this;
        }

        public SimpleTCLCommand RequiredString(string name, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException($"Parameter is required but value was not provided: {name}");

            _parameters.Add(new TCLCommandStringParameter(value));

            return this;
        }

        public SimpleTCLCommand RequiredInt32(string name, int value)
        {
            _parameters.Add(new TCLCommandInt32Parameter(value));

            return this;
        }

        public SimpleTCLCommand RequiredEnum<T>(string name, T value) where T : struct
        {
            _parameters.Add(new TCLCommandStringParameter(EnumValue(value)));

            return this;
        }

        public SimpleTCLCommand RequiredStringList(string name, TCLParameterList value)
        {
            if (value == null || !value.Params.Any() || value.Params.All(v => string.IsNullOrWhiteSpace(v)))
                throw new ArgumentException($"Requires list of values: {name}");

            _parameters.Add(new TCLCommandStringListParameter(value));

            return this;
        }

        public SimpleTCLCommand RequiredNamedString(string name, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException($"Parameter '{name}' is required");

            _parameters.Add(new TCLCommandNamedStringParameter(name, value));

            return this;
        }

        public SimpleTCLCommand RequiredNamedEnum<T>(string name, T value) where T : struct
        {
            _parameters.Add(new TCLCommandNamedStringParameter(name, EnumValue(value)));

            return this;
        }

        public SimpleTCLCommand RequiredNamedStringList(string name, TCLParameterList value)
        {
            if (value == null || !value.Params.Any() || value.Params.All(v => string.IsNullOrWhiteSpace(v)))
                throw new ArgumentException($"Requires list of values");

            _parameters.Add(new TCLCommandNamedStringListParameter(name, value));

            return this;
        }
    }
}
