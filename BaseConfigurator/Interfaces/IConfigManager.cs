using System.Collections.Generic;

namespace Configurator
{
    /// <summary>
    /// Responsible for manipulating configuration fields and switching between config sections.
    /// *Doesn't implement IO or interpreting config files content (See IDataManager for this).
    /// </summary>
    public interface IConfigManager
    {
        void SwitchToConfigSection(string header);
        bool GetValue<T>(string key, out T value);
        void SetValue<T>(string key, T value);        
        void Save();
    }
}