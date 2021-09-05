namespace Configurator
{
    public interface IConfigManager
    {
        void SwitchToConfigSection(string header);
        T GetValue<T>(string key);
        void SetValue<T>(string key, T value);        
        void Save();
    }
}