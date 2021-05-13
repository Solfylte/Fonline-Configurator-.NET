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

            AppendMissingPairs<string>(_defaultConfigData.StringValues);
            AppendMissingPairs<bool>(_defaultConfigData.BoolValues);
            AppendMissingPairs<int>(_defaultConfigData.IntValues);
        }

        private void AppendMissingPairs<T>(Dictionary<string, T> keyValuePairs)
        {
            foreach (var key in keyValuePairs.Keys)
                if (!IsConfigFileContainsKey(key))
                    _сonfigFileSection.Add(key, keyValuePairs[key].ToString());
        }

        private bool IsConfigFileContainsKey(string key) => _сonfigFileSection.ContainsKey(key);

        private void AppendFromDefaultData(string key)
        {
            _сonfigFileSection.Add(key, _defaultConfigData.StringValues[key]);
        }

        public string GetString(string key)
        {
            string result = "";
            if (IsConfigFileContainsKey(key))
                result = _сonfigFileSection[key];

            return result;
        }

        public bool GetBool(string key)
        {
            bool result = false;
            if (IsConfigFileContainsKey(key))
            {
                if (IsBool(key))
                    result = Convert.ToBoolean(_сonfigFileSection[key]);
                else if(_defaultConfigData.BoolValues.ContainsKey(key))
                    result = _defaultConfigData.BoolValues[key];
            }

            return result;
        }

        private bool IsBool(string key)
        {
            string value = _сonfigFileSection[key].ToLower();
            return value.Equals("true") || value.Equals("false");
        }

        public int GetInt(string key)
        {
            int result = 0;
            if (IsConfigFileContainsKey(key))
            {
                if (IsInt(key))
                    result = Convert.ToInt32(_сonfigFileSection[key]);
                else if (_defaultConfigData.IntValues.ContainsKey(key))
                    result = _defaultConfigData.IntValues[key];
            }

            return result;
        }

        private bool IsInt(string key)
        {
            int outValue;
            return Int32.TryParse(_сonfigFileSection[key], out outValue);
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