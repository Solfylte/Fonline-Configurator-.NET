namespace Configurator
{
    public interface IConfigManager
    {
        bool GetBool(string key);
        string GetString(string key);
        int GetInt(string key);
        void SetValue<T>(string key, T value);
        void Save();
    }
}