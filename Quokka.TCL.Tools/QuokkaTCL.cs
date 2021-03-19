using System;
using System.Collections.Generic;

namespace Quokka.TCL.Tools
{
    public abstract class QuokkaTCLCommand
    {
        public abstract void Write(IndentedStringBuilder builder);
    }

    public class SimpleTCLCommand : QuokkaTCLCommand
    {
        private readonly string _name;
        public SimpleTCLCommand(string name)
        {
            _name = name;
        }

        public override void Write(IndentedStringBuilder builder)
        {
            builder.AppendLine(_name);
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
