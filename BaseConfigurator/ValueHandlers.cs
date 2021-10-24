using System;
using System.Collections.Generic;

namespace Configurator
{
    class StringHandler : IConfigValueHandler
    {
        public bool GetConvertedValue(string value, out object result)
        {
            result = value;
            return true;
        }
    }

    class IntHandler : IConfigValueHandler
    {
        public bool GetConvertedValue(string value, out object result)
        {
            result = null;

            if (Int32.TryParse(value, out int parseResult))
            {
                result = parseResult;
                return true;
            }
            else
                return false;
        }
    }

    class BoolHandler : IConfigValueHandler
    {
        public bool GetConvertedValue(string value, out object result)
        {
            result = null;

            if (Boolean.TryParse(value, out bool parseResult))
            {
                result = parseResult;
                return true;
            }
            else
                return false;
        }
    }
}
