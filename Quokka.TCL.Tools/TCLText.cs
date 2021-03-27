using System.Linq;

namespace Quokka.TCL.Tools
{
    public class TCLText : TCLEntry
    {
        string _text;
        public TCLText(string text)
        {
            _text = text;
        }

        public override void Write(IndentedStringBuilder builder)
        {
            var lines = _text.Split('\n').Select(l => l.TrimEnd());
            foreach (var l in lines)
            {
                builder.AppendLine($"{l}");
            }
        }
    }
}
