using System.Collections.Generic;
using System;
using Newtonsoft.Json;

namespace Quokka.TCL.SourceGenerator
{
    enum VivadoCommandParameterUsage
    {
        Optional,
        Required
    }

    enum VivadoCommandParameterType
    {
        Flag,
        String,
        Enum
    }

    class StaticData
    {
        public static HashSet<string> keywords = new HashSet<string>()
        {
            "class", "default", "fixed", "object", "try", "internal", "ref", "interface",
            "short", "long", "string"
        };
    }

    class VivadoCommandParameter
    {
        public string Name;
        public string UsageSectionToken;
        public string ArgumentsSectionToken;
        public bool IsNamed;
        public Type ElementType = typeof(string);
        public bool IsArray;
        public List<string> Description = new List<string>();
        public string EnumName;
        public List<string> EnumValues = new List<string>();
        public VivadoCommandParameterUsage Usage;
        public VivadoCommandParameterType Type;

        public string CSName
        {
            get
            {
                if (StaticData.keywords.Contains(Name))
                    return $"@{Name}";

                if (char.IsDigit(Name[0]))
                    return $"_{Name}";
                return Name;
            }
        }

        public string ParamName
        {
            get
            {
                if (char.IsDigit(Name[0]))
                    return $"_{Name}";
                return Name;
            }
        }

        public override string ToString()
        {
            return $"Param: {Name}, {Type}, {Usage}";
        }
    }
}
