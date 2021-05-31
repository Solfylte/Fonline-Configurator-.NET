namespace Configurator
{
    public interface IConfigManager
    {
        T GetValue<T>(string key);
        void SetValue<T>(string key, T value);        
        void Save();
    }
}