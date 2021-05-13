using System.Collections.Generic;

namespace Configurator
{
    public interface IDefaultConfigData
    {
        Dictionary<string, string> StringValues { get; }
        Dictionary<string, bool> BoolValues { get; }
        Dictionary<string, int> IntValues { get; }
        string Header { get; }
    }
}