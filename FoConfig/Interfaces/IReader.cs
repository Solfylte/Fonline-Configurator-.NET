using System.Collections.Generic;

namespace Configurator
{
    public interface IReader
    {
        List<string> ReadOrCreate(string path);
    }
}
