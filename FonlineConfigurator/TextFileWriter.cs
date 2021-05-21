using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Configurator;

namespace FOConfig
{
    public class TextFileWriter : IWriter
    {
        private string _path;
        private List<string> _lines = new List<string>();
        private StringBuilder _fileContent = new StringBuilder();

        public void Write(List<string> lines, string path)
        {
            _path = path;
            _lines = lines;

            FillFileContent();
            WriteAsText();
        }

        private void FillFileContent()
        {
            foreach (var line in _lines)
            {
                _fileContent.Append(line);
                _fileContent.Append("\n");
            }
        }

        private void WriteAsText() => File.WriteAllText(_path, _fileContent.ToString());
    }
}