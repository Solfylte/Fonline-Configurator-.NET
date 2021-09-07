using System.Collections.Generic;

namespace Configurator
{
    public interface IConfigValueHandler
    {
        object GetConvertedValue(string key, Dictionary<string, string> configSection);
    }
}
