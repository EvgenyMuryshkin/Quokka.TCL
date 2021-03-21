using Quokka.TCL.Tools;
using System.Collections.Generic;
using System.Linq;

namespace Quokka.TCL.SourceGenerator
{
    public class BaseGenerator
    {
        protected int page(int p) => p - 1;

        public static List<string> between(List<string> lines, string from, string to)
        {
            var result = lines
                .SkipWhile(l => from == null || !l.StartsWith(from))
                .Skip(from == null ? 0 : 1)
                .TakeWhile(l => to == null || !l.StartsWith(to))
                .ToList();

            return result;
        }

        public static List<string> between(List<string> lines, string from, bool includeFrom, string to)
        {
            var result = lines
                .SkipWhile(l => from == null || !l.StartsWith(from))
                .Skip((includeFrom || from == null) ? 0 : 1)
                .TakeWhile(l => to == null || !l.StartsWith(to))
                .ToList();

            return result;
        }

        public static List<string> between(string source, string from, string to)
        {
            var lines = source.Split('\n').Select(l => l.Trim()).ToList();

            return between(lines, from, to);
        }

        protected void Header(IndentedStringBuilder builder)
        {
            builder.AppendLine($"// Generated file, do not modify");
            builder.AppendLine($"// See {GetType().Name} for implementation");
            builder.AppendLine("using System;");
        }
    }
}
