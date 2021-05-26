using System.Linq;

namespace Quokka.TCL.Tools
{
    public class TCLComment : TCLEntry
    {
        string _comment;
        public TCLComment(string comment)
        {
            _comment = comment ?? "";
        }

        public override void Write(IndentedStringBuilder builder)
        {
            var lines = _comment.Split('\n').Select(l => l.TrimEnd());
            lines.ForEach((l, idx, last) =>
            {
                builder.Append(l);

                if (!last)
                    builder.AppendLine();
            });
        }
    }
}
