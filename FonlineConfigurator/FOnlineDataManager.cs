using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configurator;

namespace FOConfig
{
    public class FOnlineDataManager: BaseDataManager
    {
        protected override Dictionary<string, Dictionary<string, string>> ConfigurationFileSections { get; set; }
        protected override List<string> Headers { get; set; }

        private string currentHeader = "";

        public FOnlineDataManager(IReader reader, IWriter writer, string path) 
                                : base(reader, writer, path)
        {
            FillConfigurationSections();
        }

        private void FillConfigurationSections()
        {
            ConfigurationFileSections = new Dictionary<string, Dictionary<string, string>>();
            Headers = new List<string>();

            foreach (var line in fileLines)
            {
                if (IsHeader(line))
                {
                    currentHeader = GetHeader(line);
                    Headers.Add(currentHeader);

                    if (!IsSectionAlreadyAdded())
                        AddConfigSection();
                }
                else if (IsSectionAlreadyAdded())
                {
                    AddСonfigLine(line);
                }
            }
        }

        protected bool IsHeader(string line) => line.Contains("[") && line.Contains("]");

        private string GetHeader(string line)
        {
            int startIndex = line.IndexOf('[');
            int endIndex = line.IndexOf(']') + 1;

            if (endIndex < line.Length)
                return line.Substring(startIndex, endIndex);

            return line.Substring(startIndex);
        }

        private void AddConfigSection()
        {
            ConfigurationFileSections.Add(currentHeader, new Dictionary<string, string>());
        }

        private bool IsSectionAlreadyAdded() => ConfigurationFileSections.ContainsKey(currentHeader);

        private void AddСonfigLine(string line)
        {
            string formatedLine = GetLineWithoutSpaces(line);
            string[] keyValuePair = formatedLine.Split(new char[] { '=' }, 2);

            if (keyValuePair.Length > 1 && !ConfigurationFileSections[currentHeader].ContainsKey(keyValuePair[0]))
                ConfigurationFileSections[currentHeader].Add(keyValuePair[0], keyValuePair[1]);
        }

        private string GetLineWithoutSpaces(string line) => line.Replace(" ", "").Replace("\t", "");
    }
}
