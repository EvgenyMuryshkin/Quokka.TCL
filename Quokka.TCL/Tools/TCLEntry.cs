namespace Quokka.TCL.Tools
{
    public abstract class TCLEntry
    {
        public abstract void Write(IndentedStringBuilder builder);
        public virtual void WriteLine(IndentedStringBuilder builder)
        {
            Write(builder);
            builder.AppendLine();
        }
    }
}
