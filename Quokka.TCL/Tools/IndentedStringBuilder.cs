using System;
using System.Linq;
using System.Text;
using System.Reactive.Disposables;
using System.Collections.Generic;

namespace Quokka.TCL.Tools
{
    public class IndentedStringBuilder
    {
        StringBuilder _builder = new StringBuilder();
        int _indentCounter = 0;
        string IndentText => string.Join("", Enumerable.Range(0, _indentCounter).Select(_ => "\t"));

        public IDisposable Indent()
        {
            _indentCounter++;

            return Disposable.Create(() => _indentCounter--);
        }

        /// <summary>
        /// ee
        /// </summary>
        /// <param name="open">
        /// Param to open
        /// </param>
        /// <param name="close">
        /// Close token
        /// </param>
        /// <returns>disposable</returns>
        public IDisposable CodeBlock(string open = "{", string close = "}")
        {
            AppendLine(open);

            _indentCounter++;

            return Disposable.Create(() =>
            {
                _indentCounter--;
                AppendLine(close);
            });
        }
        public void AppendContent(string content)
        {
            _builder.Append(content);
        }

        public void AppendLine(string content)
        {
            var lines = content.Split('\n').Select(l => l.Trim());

            foreach (var l in lines)
            {
                if (string.IsNullOrWhiteSpace(l))
                {
                    _builder.AppendLine();
                    continue;
                }

                _builder.AppendLine($"{IndentText}{l}");
            }
        }

        public void AppendDocumentationSeparator()
        {
            AppendLine($"/// <br/>");
        }

        public void AppendDocumentationLines(params string[] lines)
        {
            AppendDocumentationLines(lines.ToList());
        }

        public void AppendDocumentationLinesIfAny(List<string> lines)
        {
            if (lines == null || !lines.Any())
                return;
            AppendDocumentationLines(lines);
            AppendDocumentationSeparator();
        }

        public void AppendDocumentationLines(List<string> lines)
        {
            if (lines == null || !lines.Any())
                return;

            AppendLine($"/// <para>");
            foreach (var l in lines)
            {
                AppendLine($"/// {l}<br/>");
            }
            AppendLine($"/// </para>");
        }

        public void AppendDocumentationSection(string section, List<string> lines)
        {
            if (lines == null)
                return;

            switch (lines.Count)
            {
                case 0:
                case 1:
                    AppendLine($"/// <{section}>{lines.SingleOrDefault()}</{section}>");
                    break;
                default:
                    AppendLine($"/// <{section}>");
                    AppendLine($"/// </{section}>");
                    break;
            }
        }

        public override string ToString()
        {
            return _builder.ToString();
        }
    }
}
