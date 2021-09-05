using System.Collections.Generic;

namespace Configurator
{
    public interface IReader
    {
        List<string> Read(string path);
    }
}
