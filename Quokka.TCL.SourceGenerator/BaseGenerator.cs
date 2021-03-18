using System.Collections.Generic;
using System.Linq;

namespace Quokka.TCL.SourceGenerator
{
    public class BaseGenerator
    {
        protected int page(int p) => p - 1;

        protected List<string> between(List<string> lines, string from, string to)
        {
            var result = lines
                .SkipWhile(l => from == null || !l.StartsWith(from))
                .Skip(from == null ? 0 : 1)
                .TakeWhile(l => to == null || !l.StartsWith(to))
                .ToList();

            return result;
        }

        protected List<string> between(string source, string from, string to)
        {
            var lines = source.Split('\n').Select(l => l.Trim()).ToList();

            return between(lines, from, to);
        }
    }
}
