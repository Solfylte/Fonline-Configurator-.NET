namespace Configurator
{
    public interface IConfigValueHandler
    {
        object GetConvertedValue(string key);
    }
}
