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

        private Dictionary<Type, IConfigValueHandler> valueHandlers = new Dictionary<Type, IConfigValueHandler>();

        private string currentHeader;
        protected string defaultConfigHeader;

        public BaseConfigManager(IDataManager dataManager, string defaultConfigHeader)
        {
            CreateValueHandlers();
            this.dataManager = dataManager;
            this.defaultConfigHeader = defaultConfigHeader;
            SwitchToConfigSection(defaultConfigHeader);
        }

        public virtual void SwitchToConfigSection(string header)
        {
            currentHeader = header;
            this.сonfigSection = this.dataManager.GetConfigSection(currentHeader);
        }

        protected virtual void CreateValueHandlers()
        {
            valueHandlers.Add(typeof(string), new StringHandler());
            valueHandlers.Add(typeof(int), new IntHandler());
            valueHandlers.Add(typeof(bool), new BoolHandler());
        }

        public T GetValue<T>(string key)
        {
            IConfigValueHandler handler = valueHandlers[typeof(T)];
            T result = (T)handler.GetConvertedValue(key, сonfigSection);
            return (T)handler.GetConvertedValue(key, сonfigSection);
        }

        public string[] GetHeaders() => dataManager.GetHeaders();

        public void SetValue<T>(string key, T value)
        {
            if (IsConfigFileContainsKey(key))
                this.сonfigSection[key] = value.ToString();
            else
                this.сonfigSection.Add(key, value.ToString());
        }

        private bool IsConfigFileContainsKey(string key) => this.сonfigSection.ContainsKey(key);

        public void Save() => this.dataManager.SetConfigSection(this.сonfigSection, currentHeader);
    }
}