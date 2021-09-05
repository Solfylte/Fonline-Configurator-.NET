using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Configurator
{
    public class TextFileReader : IReader
    {
        private string path;

        public List<string> Read(string path)
        {
            this.path = path;

            if (File.Exists(path))
                return ReadAsText();
            else
                return new List<string>();
        }

        private List<string> ReadAsText()
        {
            string[] lines = File.ReadAllLines(path);
            return lines.ToList<string>();
        }
    }
}