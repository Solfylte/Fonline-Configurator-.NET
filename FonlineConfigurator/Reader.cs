using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Configurator;

namespace FoConfig
{
    public class Reader : IReader
    {
        private string _path;

        public List<string> ReadOrCreate(string path)
        {
            _path = path;

            if (!File.Exists(_path))
            {
                File.Create(_path);
                return new List<string>();
            }
            else 
                return ReadAsText();
        }

        private List<string> ReadAsText()
        {
            string[] lines = File.ReadAllLines(_path);
            return lines.ToList<string>();
        }
    }
}