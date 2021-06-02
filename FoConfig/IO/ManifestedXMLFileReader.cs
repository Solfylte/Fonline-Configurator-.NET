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
    public class ManifestedXMLFileReader: IReader
    {
        private string path;

        public List<string> Read(string path, bool isCreateIfNotExist = false)
        {
            List<string> content = new List<string>();

            Assembly assembly = Assembly.GetExecutingAssembly();
            //this.path = assembly.GetManifestResourceNames().Single(str => str.EndsWith(path));

            int count = assembly.GetManifestResourceNames().Count();

            foreach (var item in assembly.GetManifestResourceNames())
            {
                string r = item;
            }

            using (Stream stream = assembly.GetManifestResourceStream(this.path))
            using (StreamReader streamReader = new StreamReader(stream))
            {
                return ReadAsText(streamReader);
            }
        }

        public List<string> ReadOrCreate(string path) { throw new NotImplementedException(); }

        private List<string> ReadAsText(StreamReader streamReader)
        {
            List<string> lines = new List<string>();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(streamReader);
            XmlNode rootNode = xmlDoc.DocumentElement;

            foreach (XmlNode childNode in rootNode.ChildNodes)
                lines.Add($"{childNode.Name}={childNode.Attributes[childNode.Name].Value}");

            return lines;
        }
    }
}
