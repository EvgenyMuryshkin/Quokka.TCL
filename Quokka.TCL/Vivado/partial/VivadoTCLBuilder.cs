using Quokka.TCL.Tools;
using System.Linq;

namespace Quokka.TCL.Vivado
{
    public partial class VivadoTCLBuilder
    {
        string FileName(string source)
        {
            if (source == null)
                return null;

            return TCLEscaping.Default.FileName(source);
        }

        TCLObject FileName(TCLObject source)
        {
            if (source?._value != null)
                return TCLEscaping.Default.FileName(source._value);

            return source;
        }

        TCLObjectList FileName(TCLObjectList source)
        {
            if (source == null)
                return null;

            return new TCLObjectList(source.Objects.Select(FileName).ToList());
        }

        TCLParameterList FileName(TCLParameterList source)
        {
            if (source == null)
                return null;

            return new TCLParameterList(source.Params.Select(FileName).ToList());
        }
    }
}
