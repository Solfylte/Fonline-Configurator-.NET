using System.Collections.Generic;

namespace Configurator
{
    public interface IDataManager
    {
        Dictionary<string, string> GetConfigSection(string header);
        void SetConfigSection(string header, Dictionary<string, string> configSection);
    }
}