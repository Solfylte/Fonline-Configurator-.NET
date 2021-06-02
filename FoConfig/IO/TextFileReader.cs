using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Configurator
{
    public class TextFileReader : IReader
    {
        private string path;

        public List<string> Read(string path, bool isCreateIfNotExist = true)
        {
            this.path = path;

            if (!File.Exists(path) && isCreateIfNotExist)
            {
                File.Create(path);
                return new List<string>();
            }
            else
                return ReadAsText();
        }

        private List<string> ReadAsText()
        {
            string[] lines = File.ReadAllLines(path);
            return lines.ToList<string>();
        }
    }
}