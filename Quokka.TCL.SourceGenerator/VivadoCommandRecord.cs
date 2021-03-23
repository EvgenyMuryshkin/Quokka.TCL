using System.Collections.Generic;
using System.Linq;
using System;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Quokka.TCL.SourceGenerator
{
    class VivadoCommandRecordSection
    {
        public string SectionName;
        public Action<List<string>> Handler;

        public VivadoCommandRecordSection(string sectionName, Action<List<string>> handler)
        {
            SectionName = sectionName;
            Handler = handler;
        }
    }

    class VivadoCommandRecord
    {
        VivadoCommandLog _log;
        public VivdoCommandTextLines CommandData;
        public string Name = "";
        public List<string> ShortDescription = new List<string>();
        public List<string> Description = new List<string>();
        public List<string> Returns = new List<string>();
        public List<VivadoCommandParameter> Parameters = new List<VivadoCommandParameter>();
        public List<string> Examples = new List<string>();
        public string Syntax = "";

        public List<VivadoCommandParameter> orderedParameters => Parameters.Where(c => c is VivadoCommandRequiredParameter).Concat(Parameters.Where(c => c is VivadoCommandOptionalParameter)).ToList();

        public VivadoCommandRecord(VivadoCommandLog log, string name, VivdoCommandTextLines commandData)
        {
            _log = log;

            CommandData = commandData;
            Name = name;
            var lines = commandData.Lines;

            var orderedSections = new VivadoCommandRecordSection[]
            {
                new VivadoCommandRecordSection(name, OnCommand),
                new VivadoCommandRecordSection("Syntax", OnSyntax),
                new VivadoCommandRecordSection("Returns", OnReturns),
                new VivadoCommandRecordSection("Usage", OnUsage),
                new VivadoCommandRecordSection("Categories", OnCategories),
                new VivadoCommandRecordSection("Description", OnDescription),
                new VivadoCommandRecordSection("Arguments", OnArguments),
                new VivadoCommandRecordSection("Examples", OnExamples),
                new VivadoCommandRecordSection("See Also", OnSeeAlso),
            };

            // make sure that sections are in expected order
            var indexes = orderedSections
                .Select(s => new { name = s.SectionName, index = lines.IndexOf(s.SectionName) })
                .Where(s => s.index != -1)
                .ToList();

            for (var idx = 0; idx < indexes.Count - 1; idx++)
            {
                var thisSection = indexes[idx];
                var nextSection = indexes[idx + 1];
                if (thisSection.index > nextSection.index)
                {
                    throw new Exception($"Command {name}: Section {thisSection.name} is expected to be before {nextSection.name}");
                }
            }

            // process sections
            var existingSections = orderedSections.Where(s => indexes.Any(i => i.name == s.SectionName)).ToList();
            for (var idx = 0; idx < existingSections.Count; idx++)
            {
                var thisSection = existingSections[idx];
                var nextSection = existingSections.Skip(idx + 1).FirstOrDefault();

                var text = BaseGenerator.between(lines, thisSection.SectionName, nextSection?.SectionName);
                thisSection.Handler(text);
            }
        }

        void OnCommand(List<string> content)
        {
            ShortDescription = content;
        }

        string SpaceAndTailOrEOL = @"(?:\s+|$)(.*)";

        (VivadoCommandParameter, string) TryMatchOptionalFlag(string token)
        {
            var optionalFlag = Regex.Match(token, @"^\[\-(\w*)\]" + SpaceAndTailOrEOL);
            if (optionalFlag.Success)
            {
                var arg = new VivadoCommandOptionalFlagParameter()
                {
                    Name = optionalFlag.Groups[1].Value,
                    UsageSectionToken = $"[-{optionalFlag.Groups[1].Value}]",
                    ArgumentsSectionToken = $"-{optionalFlag.Groups[1].Value}",
                };

                return (arg, optionalFlag.Groups[2].Value);
            }

            return (null, token);
        }

        (VivadoCommandParameter, string) TryMatchOptionalParameter(string token)
        {
            var requiredParameter = Regex.Match(token, @"^\[<(\w*)>\]" + SpaceAndTailOrEOL);
            if (requiredParameter.Success)
            {
                var arg = new VivadoCommandOptionalParameter()
                {
                    Name = requiredParameter.Groups[1].Value,
                    UsageSectionToken = $"[<{requiredParameter.Groups[1].Value}>]",
                    ArgumentsSectionToken = $"<{requiredParameter.Groups[1].Value}>",
                };
                return (arg, requiredParameter.Groups[2].Value);
            }

            return (null, token);
        }

        (VivadoCommandParameter, string) TryMatchOptionalNamedParameter(string token)
        {
            var optionalNamedParameter = Regex.Match(token, @"^\[\-(\w*) <arg>\]" + SpaceAndTailOrEOL);
            if (optionalNamedParameter.Success)
            {
                var arg = new VivadoCommandOptionalParameter()
                {
                    Name = optionalNamedParameter.Groups[1].Value,
                    UsageSectionToken = $"[-{optionalNamedParameter.Groups[1].Value}]",
                    ArgumentsSectionToken = $"-{optionalNamedParameter.Groups[1].Value} <arg>",
                    IsNamed = true
                };
                return (arg, optionalNamedParameter.Groups[2].Value);
            }

            return (null, token);
        }

        (VivadoCommandParameter, string) TryMatchOptionalNamedListParameter(string token)
        {
            var requiredNamedListParameter = Regex.Match(token, @"^\[\-(\w*) <args>\]" + SpaceAndTailOrEOL);
            if (requiredNamedListParameter.Success)
            {
                var arg = new VivadoCommandOptionalParameter()
                {
                    Name = requiredNamedListParameter.Groups[1].Value,
                    UsageSectionToken = $"[-{requiredNamedListParameter.Groups[1].Value}]",
                    ArgumentsSectionToken = $"-{requiredNamedListParameter.Groups[1].Value} <args>",
                    IsNamed = true,
                    IsArray = true
                };
                return (arg, requiredNamedListParameter.Groups[2].Value);
            }

            return (null, token);
        }

        (VivadoCommandParameter, string) TryMatchOptionalListParameter(string token)
        {
            var optionalPatternsParameter = Regex.Match(token, @"^\[<(\w*)>\.\.\.\]" + SpaceAndTailOrEOL);
            if (optionalPatternsParameter.Success)
            {
                var arg = new VivadoCommandOptionalParameter()
                {
                    Name = optionalPatternsParameter.Groups[1].Value,
                    UsageSectionToken = $"[<{optionalPatternsParameter.Groups[1].Value}>]",
                    ArgumentsSectionToken = $"<{optionalPatternsParameter.Groups[1].Value}>",
                    IsArray = true
                };
                return (arg, optionalPatternsParameter.Groups[2].Value);
            }

            return (null, token);
        }

        (VivadoCommandParameter, string) TryMatchRequiredListParameter(string token)
        {
            var optionalPatternsParameter = Regex.Match(token, @"^<(\w*)>\.\.\." + SpaceAndTailOrEOL);
            if (optionalPatternsParameter.Success)
            {
                var arg = new VivadoCommandRequiredParameter()
                {
                    Name = optionalPatternsParameter.Groups[1].Value,
                    UsageSectionToken = $"<{optionalPatternsParameter.Groups[1].Value}>",
                    ArgumentsSectionToken = $"<{optionalPatternsParameter.Groups[1].Value}>",
                    IsArray = true
                };
                return (arg, optionalPatternsParameter.Groups[2].Value);
            }

            return (null, token);
        }

        (VivadoCommandParameter, string) TryMatchRequiredParameter(string token)
        {
            var requiredParameter = Regex.Match(token, @"^<(\w*)>" + SpaceAndTailOrEOL);
            if (requiredParameter.Success)
            {
                var arg = new VivadoCommandRequiredParameter()
                {
                    Name = requiredParameter.Groups[1].Value,
                    UsageSectionToken = $"<{requiredParameter.Groups[1].Value}>",
                    ArgumentsSectionToken = $"<{requiredParameter.Groups[1].Value}>",
                };
                return (arg, requiredParameter.Groups[2].Value);
            }

            return (null, token);
        }

        (VivadoCommandParameter, string) TryMatchRequiredNamedParameter(string token)
        {
            var requiredNamedParameter = Regex.Match(token, @"^\-(\w*) <arg>" + SpaceAndTailOrEOL);
            if (requiredNamedParameter.Success)
            {
                var arg = new VivadoCommandRequiredParameter()
                {
                    Name = requiredNamedParameter.Groups[1].Value,
                    UsageSectionToken = $"-{requiredNamedParameter.Groups[1].Value}",
                    ArgumentsSectionToken = $"-{requiredNamedParameter.Groups[1].Value} <arg>",
                    IsNamed = true
                };
                return (arg, requiredNamedParameter.Groups[2].Value);
            }

            return (null, token);
        }

        (VivadoCommandParameter, string) TryMatchRequiredNamedListParameter(string token)
        {
            var requiredNamedListParameter = Regex.Match(token, @"^\-(\w*) <args>" + SpaceAndTailOrEOL);
            if (requiredNamedListParameter.Success)
            {
                var arg = new VivadoCommandRequiredParameter()
                {
                    Name = requiredNamedListParameter.Groups[1].Value,
                    UsageSectionToken = $"-{requiredNamedListParameter.Groups[1].Value}",
                    ArgumentsSectionToken = $"-{requiredNamedListParameter.Groups[1].Value} <args>",
                    IsNamed = true,
                    IsArray = true
                };
                return (arg, requiredNamedListParameter.Groups[2].Value);
            }

            return (null, token);
        }

        void OnSyntax(List<string> content)
        {
            Syntax = string.Join(" ", content);

            var token = Syntax;
            if (!token.StartsWith(Name))
                throw new Exception($"Command {Name}: syntax does not start with command name - {Syntax}");

            token = token.Substring(Name.Length).TrimStart();
            VivadoCommandParameter arg = null;

            var match = new Func<string, (VivadoCommandParameter, string)>[]
            {
                TryMatchOptionalFlag,
                TryMatchOptionalParameter,
                TryMatchOptionalNamedParameter,
                TryMatchOptionalNamedListParameter,
                TryMatchOptionalListParameter,
                TryMatchRequiredParameter,
                TryMatchRequiredListParameter,
                TryMatchRequiredNamedParameter,
                TryMatchRequiredNamedListParameter,
            };

            while (!string.IsNullOrWhiteSpace(token))
            {
                foreach (var item in match)
                {
                    (arg, token) = item(token);
                    if (arg != null)
                    {
                        if (!Parameters.Any(a => a.Name == arg.Name))
                        {
                            Parameters.Add(arg);
                        }
                        else
                        {
                            _log.Command(Name).DuplicateParams.Add(arg.Name);
                        }

                        break;
                    }
                }

                if (arg == null)
                    throw new Exception($"Unrecognized syntax expression: {token}");
            }
        }

        void OnReturns(List<string> content)
        {
            Returns = content;
        }
        void OnUsage(List<string> content)
        {
            var source = content.ToList();
            if (source[0] == "Name Description")
                source.RemoveAt(0);

            VivadoCommandParameter arg = null;
            foreach (var line in source)
            {
                var splitMatch = Regex.Match(line, "(.*?)\\s+(.*)");

                var matchingArg = Parameters.SingleOrDefault(a => line.StartsWith(a.UsageSectionToken));
                if (matchingArg != null)
                {
                    arg = matchingArg;
                    arg.Description.Add(splitMatch.Groups[2].Value);
                }
                else
                {
                    if (arg == null)
                        throw new Exception($"Argument for usage line is not specified: {line}");

                    arg.Description.Add(line);
                }
            }
        }
        void OnCategories(List<string> content)
        {
        }
        void OnDescription(List<string> content)
        {
            Description = content;
        }
        void OnArguments(List<string> content)
        {
            // Syntax and Arguments sections sometimes disagree if parameter is optional or required.
            // Treat parameter as Required if Syntax or Argument section said it is required
            var fixUsage = Parameters.ToDictionary(p => p, p => p);

            foreach (var line in content)
            {
                var splitMatch = Regex.Match(line, "(.*?)\\s+(.*)");

                var matchingArg = Parameters.SingleOrDefault(a => line.StartsWith($"{a.ArgumentsSectionToken} "));
                if (matchingArg != null)
                {
                    var pattern = $"{matchingArg.ArgumentsSectionToken}" + @"\s-\s\((.*?)\)";
                    var usage = Regex.Match(line, pattern);
                    if (usage.Success)
                    {
                        switch (usage.Groups[1].Value.ToLower())
                        {
                            case "option":
                            case "optional":
                                /*
                                switch (matchingArg)
                                {
                                    case VivadoCommandRequiredParameter r:
                                        fixUsage[matchingArg] = r.MakeOptional();
                                        break;
                                    case VivadoCommandOptionalParameter o:
                                        // usage matched
                                        break;
                                    default:
                                        throw new Exception($"Unhandled parameter type: {matchingArg}");
                                }
                                */
                                break;
                            case "required":
                                switch (matchingArg)
                                {
                                    case VivadoCommandRequiredParameter r:
                                        // usage matched
                                        break;
                                    case VivadoCommandOptionalParameter o:
                                        fixUsage[matchingArg] = o.MakeRequired();
                                        _log.Command(Name).InconsistentUsage.Add(matchingArg.Name);
                                        break;
                                    default:
                                        throw new Exception($"Unhandled parameter type: {matchingArg}");
                                }
                                break;
                            default:
                                throw new Exception($"Usage type for argument '{matchingArg.Name}' not recognized: {usage.Groups[1].Value}");
                        }
                    }
                    else
                    {
                        // no usage specified
                        // throw new Exception($"No usage specified for {matchingArg.Name}");
                    }
                }
            }

            Parameters = Parameters.Select(p => fixUsage[p]).ToList();
            /*
            for (var idx = 0; idx < Parameters.Count; idx++)
            {
                var thisArg = Parameters[idx];
                var nextArg = Parameters.Skip(idx + 1).FirstOrDefault();

                var text = BaseGenerator.between(
                    content, 
                    $"-{thisArg.Name}", 
                    true,
                    nextArg?.Name == null ? null : $"-{nextArg?.Name}");

                if (text == null || !text.Any())
                {
                    // parameter does not have description, assume it is a boolean flag
                    //thisArg.IsFlag = true;
                    continue;
                }

                continue;

                throw new Exception($"Argument format was not recognized: {text[0]}");
            }
            */
        }
        void OnExamples(List<string> content)
        {
            Examples = content;
        }
        void OnSeeAlso(List<string> content)
        {
        }
    }
}
