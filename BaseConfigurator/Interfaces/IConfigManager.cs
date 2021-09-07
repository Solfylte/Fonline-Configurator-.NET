using System.Collections.Generic;

namespace Configurator
{
    public interface IConfigManager
    {
        string[] GetHeaders();
        void SwitchToConfigSection(string header);
        T GetValue<T>(string key);
        void SetValue<T>(string key, T value);        
        void Save();
    }
}