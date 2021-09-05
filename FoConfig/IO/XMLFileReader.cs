using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Reflection;

namespace Configurator
{
    public class XMLFileReader: IReader
    {
        private string path;

        public List<string> Read(string path)
        {
            this.path = path;
            return ReadAsText();
        }

        private List<string> ReadAsText()
        {
            List<string> lines = new List<string>();

            XmlTextReader reader = new XmlTextReader(path);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(reader);
            XmlNode rootNode = xmlDoc.DocumentElement;

            foreach (XmlNode childNode in rootNode.ChildNodes)
                lines.Add($"{childNode.Name}={childNode.Attributes["value"].Value}");

            return lines;
        }
    }
}
