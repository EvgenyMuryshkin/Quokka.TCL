using System.Collections.Generic;

namespace Quokka.TCL.SourceGenerator
{
    class VivadoTCLFixes
    {
        public HashSet<string> Optional { get; set; }
        public HashSet<string> Required { get; set; }
        public HashSet<string> NotEnums { get; set; }
        public HashSet<string> Strings { get; set; }
        public HashSet<string> Ints { get; set; }

        public Dictionary<string, string> EnumValueReplace { get; set; }
    }
}
