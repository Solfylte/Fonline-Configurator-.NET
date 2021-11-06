using Configurator;

namespace FOConfigGUIWinForm
{
    public interface ILocalizationManager: IConfigManager
    {
        void SetLanguage(string header);
        string[] GetLanguageHeaders();
    }
}