using System.Collections.Generic;

namespace Configurator
{
    public interface IConfigValueHandler
    {
        bool GetConvertedValue(string value, out object result);
    }
}
