using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Configurator
{
    public class DataManager: IDataManager
    {
        private Dictionary<string, Dictionary<string, string>> _сonfigurationFileSections = new Dictionary<string, Dictionary<string, string>>();

        private List<string> _fileLines = new List<string>();
        private string _currentHeader;

        private IWriter _writer;
        private IReader _reader;
        private string _path;

        public DataManager(IReader reader, IWriter writer, string path)
        {
            _reader = reader;
            _writer = writer;
            _path = path;

            _fileLines = reader.ReadOrCreate(_path);

            FillConfigurationSections();
        }

        private void FillConfigurationSections()
        {
            foreach (var line in _fileLines)
            {
                if (IsHeader(line))
                {
                    _currentHeader = line;
                    AddCurrentHeader();
                }
                else if (IsHeaderAlreadyAdded())
                {
                    AddСonfigLine(line);
                }
            }
        }

        private bool IsHeader(string line) => line.Contains("[") && line.Contains("]");
       
        private void AddCurrentHeader() => _сonfigurationFileSections.Add(_currentHeader, new Dictionary<string, string>());

        private bool IsHeaderAlreadyAdded() => _сonfigurationFileSections.ContainsKey(_currentHeader);

        private void AddСonfigLine(string line)
        {
            string formatedLine = GetLineWithoutSpaces(line);
            string[] keyValuePair = formatedLine.Split(new char[] { '=' }, 2);

            if (keyValuePair.Length > 1)
                _сonfigurationFileSections[_currentHeader].Add(keyValuePair[0], keyValuePair[1]);
        }

        private string GetLineWithoutSpaces(string line) => line.Replace(" ", "").Replace("\t", "");

        public Dictionary<string, string> GetConfigSection(string header)
        {
            if (_сonfigurationFileSections.ContainsKey(header))
                return _сonfigurationFileSections[header];
            else return new Dictionary<string, string>();
        }

        public void SetConfigSection(string header, Dictionary<string, string> configSection)
        {
            if (_сonfigurationFileSections.ContainsKey(header))
                _сonfigurationFileSections[header] = configSection;

            WriteToFile();
        }

        private void WriteToFile()
        {
            _fileLines = new List<string>();
            foreach (var configSection in _сonfigurationFileSections)
            {
                _fileLines.Add(configSection.Key);
                foreach (var line in configSection.Value)
                     _fileLines.Add(GetFormatedConfigLine(line));
            }
        }

        private string GetFormatedConfigLine(KeyValuePair<string, string> line) => $"{line.Key} = {line.Value}";
    }
}