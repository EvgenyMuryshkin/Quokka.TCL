using System.Collections.Generic;
using System;
using Newtonsoft.Json;

namespace Quokka.TCL.SourceGenerator
{
    abstract class VivadoCommandParameter
    {
        static HashSet<string> keywords = new HashSet<string>()
        {
            "class", "default", "fixed", "object"
        };

        public string Name;
        public string UsageSectionToken;
        public string ArgumentsSectionToken;
        public bool IsNamed;
        public Type ElementType = typeof(string);
        public bool IsArray;
        public List<string> Description = new List<string>();

        public string CSName
        {
            get
            {
                if (keywords.Contains(Name))
                    return $"@{Name}";

                if (char.IsDigit(Name[0]))
                    return $"_{Name}";
                return Name;
            }
        }
    }

    class VivadoCommandRequiredParameter : VivadoCommandParameter
    {
        public VivadoCommandOptionalParameter MakeOptional()
        {
            return JsonConvert.DeserializeObject<VivadoCommandOptionalParameter>(JsonConvert.SerializeObject(this));
        }
    }

    class VivadoCommandOptionalParameter : VivadoCommandParameter
    {
        public VivadoCommandRequiredParameter MakeRequired()
        {
            return JsonConvert.DeserializeObject<VivadoCommandRequiredParameter>(JsonConvert.SerializeObject(this));
        }
    }

    class VivadoCommandOptionalFlagParameter : VivadoCommandOptionalParameter
    {

    }
}
