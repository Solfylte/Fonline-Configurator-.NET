using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Configurator
{
    public class TextFileWriter : IWriter
    {
        private string path;
        private List<string> lines = new List<string>();

        public void Write(List<string> lines, string path)
        {
            this.path = path;
            this.lines = lines;

            WriteAsText();
        }

        private void WriteAsText()
        {
            if (File.Exists(path))
                File.Delete(path);

            using (StreamWriter sw = new StreamWriter(File.Create(path)))
            {
                foreach (var line in lines)
                    sw.WriteLine(line);

                sw.Close();
            }
        }
    }
}