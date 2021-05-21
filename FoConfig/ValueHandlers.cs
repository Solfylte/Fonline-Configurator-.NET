using System;
using System.Collections.Generic;

namespace Configurator
{
    public abstract class BaseValueHandler : IConfigValueHandler
    {
        protected Dictionary<string, string> configSection;

        public BaseValueHandler(Dictionary<string, string> configSection)
        {
            this.configSection = configSection;
        }

        public abstract object GetConvertedValue(string key);
    }

    class StringHandler : BaseValueHandler
    {
        public StringHandler(Dictionary<string, string> configSection) : base(configSection){}

        public override object GetConvertedValue(string key)
        {
            if (configSection.ContainsKey(key))
                return configSection[key];
            else
                return "";
        }
    }

    class IntHandler : BaseValueHandler
    {
        public IntHandler(Dictionary<string, string> configSection) : base(configSection) { }

        public override object GetConvertedValue(string key)
        {
            if (configSection.ContainsKey(key) && Int32.TryParse(configSection[key], out int value))
                return value;
            else
                return 0;
        }
    }

    class BoolHandler : BaseValueHandler
    {
        public BoolHandler(Dictionary<string, string> configSection) : base(configSection) { }

        public override object GetConvertedValue(string key)
        {
            if (configSection.ContainsKey(key) && Boolean.TryParse(configSection[key], out bool value))
                return value;
            else
                return false;
        }
    }
}
