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

        private Dictionary<string, string> сonfigSection;

        protected Dictionary<Type, IConfigValueHandler> valueHandlers = new Dictionary<Type, IConfigValueHandler>();

        public BaseConfigManager(IDataManager dataManager)
        {
            this.dataManager = dataManager;
            this.сonfigSection = this.dataManager.GetConfigSection(GetHeader());

            CreateValueHandlers();
            AppendMissingPairs();
        }

        protected abstract string GetHeader();

        protected virtual void CreateValueHandlers()
        {
            valueHandlers.Add(typeof(string), new StringHandler(сonfigSection));
            valueHandlers.Add(typeof(int), new IntHandler(сonfigSection));
            valueHandlers.Add(typeof(bool), new BoolHandler(сonfigSection));
        }

        private void AppendMissingPairs()
        {
            Dictionary<string, string> defaultConfig = GetConfigByDefault();
            foreach (string key in defaultConfig.Keys)
            {
                if(!IsConfigFileContainsKey(key))
                    this.сonfigSection.Add(key, defaultConfig[key]);
            }
        }

        protected abstract Dictionary<string, string> GetConfigByDefault();

        public T GetValue<T>(string key)
        {
            IConfigValueHandler handler = valueHandlers[typeof(T)];
            return (T)handler.GetConvertedValue(key);
        }

        public bool GetValueByDefault<T>(string key, out T value)
        {
            throw new NotImplementedException();
        }

        public void SetValue<T>(string key, T value)
        {
            if (IsConfigFileContainsKey(key))
                this.сonfigSection[key] = value.ToString();
            else
                this.сonfigSection.Add(key, value.ToString());
        }

        private bool IsConfigFileContainsKey(string key) => this.сonfigSection.ContainsKey(key);

        public void Save() => this.dataManager.SetConfigSection(this.сonfigSection, GetHeader());
    }
}