using System;
using System.Collections.Generic;

namespace Configurator
{
    public abstract class BaseValueHandler : IConfigValueHandler
    {
        public abstract object GetConvertedValue(string key, Dictionary<string, string> configSection);
    }

    class StringHandler : BaseValueHandler
    {
        public override object GetConvertedValue(string key, Dictionary<string, string> configSection)
        {
            if (configSection.ContainsKey(key))
                return configSection[key];
            else
                return "";
        }
    }

    class IntHandler : BaseValueHandler
    {
        public override object GetConvertedValue(string key, Dictionary<string, string> configSection)
        {
            if (configSection.ContainsKey(key) && Int32.TryParse(configSection[key], out int value))
                return value;
            else
                return 0;
        }
    }

    class BoolHandler : BaseValueHandler
    {
        public override object GetConvertedValue(string key, Dictionary<string, string> configSection)
        {
            if (configSection.ContainsKey(key) && Boolean.TryParse(configSection[key], out bool value))
                return value;
            else
                return false;
        }
    }
}
