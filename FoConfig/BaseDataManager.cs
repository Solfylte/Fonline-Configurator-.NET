using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Configurator
{
    public abstract class BaseDataManager: IDataManager
    {
        protected List<string> fileLines = new List<string>();

        protected IWriter writer;
        protected IReader reader;
        protected string path;

        public BaseDataManager(IReader reader, IWriter writer, string path)
        {
            this.reader = reader;
            this.writer = writer;
            this.path = path;

            fileLines = reader.ReadOrCreate(path);
        }

        public abstract Dictionary<string, string> GetConfigSection(string header = "");
        public abstract void SetConfigSection(Dictionary<string, string> configSection, string header = "");
    }
}