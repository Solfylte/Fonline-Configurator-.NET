using System.Collections.Generic;

namespace Configurator
{
    public interface IWriter
    {
        void Write(List<string> lines, string path); 
    }
}