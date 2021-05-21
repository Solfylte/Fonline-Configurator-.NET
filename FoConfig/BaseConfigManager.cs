using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configurator
{
    public abstract class BaseConfigManager: IConfigManager
    {
        private IDataManager dataManager;
        private IDefaultConfigData defaultConfigData;

        private Dictionary<string, string> сonfigSection;

        private Dictionary<Type, IConfigValueHandler> valueHandlers = new Dictionary<Type, IConfigValueHandler>();

        public BaseConfigManager(IDefaultConfigData defaultConfigData, IDataManager dataManager)
        {
            this.defaultConfigData = defaultConfigData;
            this.dataManager = dataManager;
            this.сonfigSection = this.dataManager.GetConfigSection(this.defaultConfigData.Header);

            AppendMissingPairs<string>(this.defaultConfigData.StringValues);
            AppendMissingPairs<bool>(this.defaultConfigData.BoolValues);
            AppendMissingPairs<int>(this.defaultConfigData.IntValues);
        }

        private void AppendMissingPairs<T>(Dictionary<string, T> keyValuePairs)
        {
            foreach (var key in keyValuePairs.Keys)
                if (!IsConfigFileContainsKey(key))
                    this.сonfigSection.Add(key, keyValuePairs[key].ToString());
        }

        private bool IsConfigFileContainsKey(string key) => this.сonfigSection.ContainsKey(key);

        private void AppendFromDefaultData(string key)
        {
            this.сonfigSection.Add(key, this.defaultConfigData.StringValues[key]);
        }

        public T GetValue<T>(string key)
        {
            T result = default;
            if (IsConfigFileContainsKey(key))
            {
                IConfigValueHandler handler = valueHandlers[typeof(T)];
                result = (T)handler.GetConvertedValue(key);
            }

            return result;
        }

        public void SetValue<T>(string key, T value)
        {
            if (IsConfigFileContainsKey(key))
                this.сonfigSection[key] = value.ToString();
            else
                this.сonfigSection.Add(key, value.ToString());
        }

        public void Save() => this.dataManager.SetConfigSection(this.defaultConfigData.Header, this.сonfigSection);
    }
}