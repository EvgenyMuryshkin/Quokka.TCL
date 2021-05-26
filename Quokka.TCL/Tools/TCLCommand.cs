using System.Collections.Generic;
using System.Linq;

namespace Quokka.TCL.Tools
{
    public abstract class TCLCommand : TCLEntry
    {
        public override string ToString()
        {
            var commandBuilder = new IndentedStringBuilder();
            Write(commandBuilder);
            return commandBuilder.ToString();
        }
    }
}
