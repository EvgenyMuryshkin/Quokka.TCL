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

        public void AppendDocumentationLines(List<string> lines)
        {
            if (lines == null)
                return;

            foreach (var l in lines)
            {
                AppendLine($"/// {l}");
            }
        }

        public override string ToString()
        {
            return _builder.ToString();
        }
    }
}
