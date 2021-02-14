using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configurator
{
    public class ConfigManager: IConfigManager
    {
        private IDataManager _dataManager;
        private IDefaultConfigData _defaultConfigData;

        private Dictionary<string, string> _сonfigFileSection;

        public ConfigManager(IDefaultConfigData defaultConfigData, IDataManager dataManager)
        {
            _defaultConfigData = defaultConfigData;
            _dataManager = dataManager;
            _сonfigFileSection = _dataManager.GetConfigSection(_defaultConfigData.Header);

            foreach (var key in _defaultConfigData.StringValues.Keys)
                if (!IsConfigFileContainsKey(key))
                    AppendFromDefaultData(key);
        }

        private bool IsConfigFileContainsKey(string key) => _сonfigFileSection.ContainsKey(key);

        private void AppendFromDefaultData(string key)
        {
            _сonfigFileSection.Add(key, _defaultConfigData.StringValues[key]);
        }

        public bool GetBool(string key)
        {
            bool result = false;
            if (IsConfigFileContainsKey(key))
                result = Convert.ToBoolean(_сonfigFileSection[key]);

            return result;
        }

        public string GetString(string key)
        {
            string result = "";
            if (IsConfigFileContainsKey(key))
                result = _сonfigFileSection[key];

            return result;
        }

        public int GetInt(string key)
        {
            int result = 0;
            if (IsConfigFileContainsKey(key))
                result = Convert.ToInt32(_сonfigFileSection[key]);

            return result;
        }

        public void SetValue<T>(string key, T value)
        {
            if (IsConfigFileContainsKey(key))
                _сonfigFileSection[key] = value.ToString();
            else
                _сonfigFileSection.Add(key, value.ToString());            
        }

        public void Save() => _dataManager.SetConfigSection(_defaultConfigData.Header, _сonfigFileSection);
    }
}