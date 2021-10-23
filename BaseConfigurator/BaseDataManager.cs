using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Configurator
{
    public abstract class BaseDataManager: IDataManager
    {
        protected List<string> fileLines = new List<string>();
        protected abstract Dictionary<string, Dictionary<string, string>> ConfigurationFileSections { get; set; }
        protected abstract List<string> Headers { get; set; }

        private IWriter writer;
        private IReader reader;
        private string path;

        public BaseDataManager(IReader reader, IWriter writer, string path)
        {
            this.reader = reader;
            this.writer = writer;
            this.path = path;

            fileLines = reader.Read(path);
        }

        public string[] GetHeaders() => Headers.ToArray();

        public Dictionary<string, string> GetConfigSection(string header)
        {
            if (ConfigurationFileSections.ContainsKey(header))
                return ConfigurationFileSections[header];
            else throw new Exception($"You tried get config section with header '{header}', " +
                                        $"but this header not exist in config file.");
        }

        public void SetConfigSection(Dictionary<string, string> configSection, string header)
        {
            if (!ConfigurationFileSections.ContainsKey(header))
                ConfigurationFileSections.Add(header, new Dictionary<string, string>());

            ConfigurationFileSections[header] = configSection;

            WriteToFile();
        }

        private void WriteToFile()
        {
            fileLines.Clear();
            foreach (var configSection in ConfigurationFileSections)
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