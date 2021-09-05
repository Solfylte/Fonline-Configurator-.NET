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
        private Dictionary<string, Dictionary<string, string>> сonfigurationFileSections = new Dictionary<string, Dictionary<string, string>>();

        private string currentHeader = "";

        public FOnlineDataManager(IReader reader, IWriter writer, string path) 
                                : base(reader, writer, path)
        {
            FillConfigurationSections();
        }

        private void FillConfigurationSections()
        {
            foreach (var line in fileLines)
            {
                if (IsHeader(line))
                {
                    currentHeader = GetHeader(line);

                    if(!IsSectionAlreadyAdded())
                        AddConfigSection();
                }
                else if (IsSectionAlreadyAdded())
                {
                    AddСonfigLine(line);
                }
            }
        }

        private bool IsHeader(string line) => line.Contains("[") && line.Contains("]");

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
            сonfigurationFileSections.Add(currentHeader, new Dictionary<string, string>());
        }

        private bool IsSectionAlreadyAdded() => сonfigurationFileSections.ContainsKey(currentHeader);

        private void AddСonfigLine(string line)
        {
            string formatedLine = GetLineWithoutSpaces(line);
            string[] keyValuePair = formatedLine.Split(new char[] { '=' }, 2);

            if (keyValuePair.Length > 1 && !сonfigurationFileSections[currentHeader].ContainsKey(keyValuePair[0]))
                сonfigurationFileSections[currentHeader].Add(keyValuePair[0], keyValuePair[1]);
        }

        private string GetLineWithoutSpaces(string line) => line.Replace(" ", "").Replace("\t", "");

        public override Dictionary<string, string> GetConfigSection(string header)
        {
            bool isHaveSection = сonfigurationFileSections.ContainsKey(header);

            if (сonfigurationFileSections.Count > 0)
            {
                string zeroElement = сonfigurationFileSections.Keys.ElementAt<string>(0);
                bool zeroIsHeader = zeroElement.Equals(header, StringComparison.OrdinalIgnoreCase);
                string test = "[Game Options]";
                bool t1 = test.Equals(header);
                bool t2 = test.Equals(zeroElement);
            }
            if (сonfigurationFileSections.ContainsKey(header))
                return сonfigurationFileSections[header];
            else return new Dictionary<string, string>();
        }

        public override void SetConfigSection(Dictionary<string, string> configSection, string header)
        {
            if (!сonfigurationFileSections.ContainsKey(header))
                сonfigurationFileSections.Add(header, new Dictionary<string, string>());

            сonfigurationFileSections[header] = configSection;

            WriteToFile();
        }

        private void WriteToFile()
        {
            fileLines.Clear();
            foreach (var configSection in сonfigurationFileSections)
            {
                fileLines.Add(configSection.Key);
                foreach (var line in configSection.Value)
                     fileLines.Add(GetFormatedConfigLine(line));

                fileLines.Add("");
            }

            writer.Write(fileLines, path);
        }

        private string GetFormatedConfigLine(KeyValuePair<string, string> line) => $"{line.Key} = {line.Value}";
    }
}
